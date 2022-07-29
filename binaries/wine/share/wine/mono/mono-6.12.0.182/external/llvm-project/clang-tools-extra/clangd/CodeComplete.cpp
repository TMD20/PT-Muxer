//===--- CodeComplete.cpp ---------------------------------------*- C++-*-===//
//
//                     The LLVM Compiler Infrastructure
//
// This file is distributed under the University of Illinois Open Source
// License. See LICENSE.TXT for details.
//
//===---------------------------------------------------------------------===//
//
// AST-based completions are provided using the completion hooks in Sema.
//
// Signature help works in a similar way as code completion, but it is simpler
// as there are typically fewer candidates.
//
//===---------------------------------------------------------------------===//

#include "CodeComplete.h"
#include "CodeCompletionStrings.h"
#include "Compiler.h"
#include "Logger.h"
#include "index/Index.h"
#include "clang/Frontend/CompilerInstance.h"
#include "clang/Frontend/FrontendActions.h"
#include "clang/Sema/CodeCompleteConsumer.h"
#include "clang/Sema/Sema.h"
#include <queue>

namespace clang {
namespace clangd {
namespace {

CompletionItemKind toCompletionItemKind(CXCursorKind CursorKind) {
  switch (CursorKind) {
  case CXCursor_MacroInstantiation:
  case CXCursor_MacroDefinition:
    return CompletionItemKind::Text;
  case CXCursor_CXXMethod:
  case CXCursor_Destructor:
    return CompletionItemKind::Method;
  case CXCursor_FunctionDecl:
  case CXCursor_FunctionTemplate:
    return CompletionItemKind::Function;
  case CXCursor_Constructor:
    return CompletionItemKind::Constructor;
  case CXCursor_FieldDecl:
    return CompletionItemKind::Field;
  case CXCursor_VarDecl:
  case CXCursor_ParmDecl:
    return CompletionItemKind::Variable;
  // FIXME(ioeric): use LSP struct instead of class when it is suppoted in the
  // protocol.
  case CXCursor_StructDecl:
  case CXCursor_ClassDecl:
  case CXCursor_UnionDecl:
  case CXCursor_ClassTemplate:
  case CXCursor_ClassTemplatePartialSpecialization:
    return CompletionItemKind::Class;
  case CXCursor_Namespace:
  case CXCursor_NamespaceAlias:
  case CXCursor_NamespaceRef:
    return CompletionItemKind::Module;
  case CXCursor_EnumConstantDecl:
    return CompletionItemKind::Value;
  case CXCursor_EnumDecl:
    return CompletionItemKind::Enum;
  // FIXME(ioeric): figure out whether reference is the right type for aliases.
  case CXCursor_TypeAliasDecl:
  case CXCursor_TypeAliasTemplateDecl:
  case CXCursor_TypedefDecl:
  case CXCursor_MemberRef:
  case CXCursor_TypeRef:
    return CompletionItemKind::Reference;
  default:
    return CompletionItemKind::Missing;
  }
}

CompletionItemKind
toCompletionItemKind(CodeCompletionResult::ResultKind ResKind,
                     CXCursorKind CursorKind) {
  switch (ResKind) {
  case CodeCompletionResult::RK_Declaration:
    return toCompletionItemKind(CursorKind);
  case CodeCompletionResult::RK_Keyword:
    return CompletionItemKind::Keyword;
  case CodeCompletionResult::RK_Macro:
    return CompletionItemKind::Text; // unfortunately, there's no 'Macro'
                                     // completion items in LSP.
  case CodeCompletionResult::RK_Pattern:
    return CompletionItemKind::Snippet;
  }
  llvm_unreachable("Unhandled CodeCompletionResult::ResultKind.");
}

CompletionItemKind toCompletionItemKind(index::SymbolKind Kind) {
  using SK = index::SymbolKind;
  switch (Kind) {
  case SK::Unknown:
    return CompletionItemKind::Missing;
  case SK::Module:
  case SK::Namespace:
  case SK::NamespaceAlias:
    return CompletionItemKind::Module;
  case SK::Macro:
    return CompletionItemKind::Text;
  case SK::Enum:
    return CompletionItemKind::Enum;
  // FIXME(ioeric): use LSP struct instead of class when it is suppoted in the
  // protocol.
  case SK::Struct:
  case SK::Class:
  case SK::Protocol:
  case SK::Extension:
  case SK::Union:
    return CompletionItemKind::Class;
  // FIXME(ioeric): figure out whether reference is the right type for aliases.
  case SK::TypeAlias:
  case SK::Using:
    return CompletionItemKind::Reference;
  case SK::Function:
  // FIXME(ioeric): this should probably be an operator. This should be fixed
  // when `Operator` is support type in the protocol.
  case SK::ConversionFunction:
    return CompletionItemKind::Function;
  case SK::Variable:
  case SK::Parameter:
    return CompletionItemKind::Variable;
  case SK::Field:
    return CompletionItemKind::Field;
  // FIXME(ioeric): use LSP enum constant when it is supported in the protocol.
  case SK::EnumConstant:
    return CompletionItemKind::Value;
  case SK::InstanceMethod:
  case SK::ClassMethod:
  case SK::StaticMethod:
  case SK::Destructor:
    return CompletionItemKind::Method;
  case SK::InstanceProperty:
  case SK::ClassProperty:
  case SK::StaticProperty:
    return CompletionItemKind::Property;
  case SK::Constructor:
    return CompletionItemKind::Constructor;
  }
  llvm_unreachable("Unhandled clang::index::SymbolKind.");
}

/// Get the optional chunk as a string. This function is possibly recursive.
///
/// The parameter info for each parameter is appended to the Parameters.
std::string
getOptionalParameters(const CodeCompletionString &CCS,
                      std::vector<ParameterInformation> &Parameters) {
  std::string Result;
  for (const auto &Chunk : CCS) {
    switch (Chunk.Kind) {
    case CodeCompletionString::CK_Optional:
      assert(Chunk.Optional &&
             "Expected the optional code completion string to be non-null.");
      Result += getOptionalParameters(*Chunk.Optional, Parameters);
      break;
    case CodeCompletionString::CK_VerticalSpace:
      break;
    case CodeCompletionString::CK_Placeholder:
      // A string that acts as a placeholder for, e.g., a function call
      // argument.
      // Intentional fallthrough here.
    case CodeCompletionString::CK_CurrentParameter: {
      // A piece of text that describes the parameter that corresponds to
      // the code-completion location within a function call, message send,
      // macro invocation, etc.
      Result += Chunk.Text;
      ParameterInformation Info;
      Info.label = Chunk.Text;
      Parameters.push_back(std::move(Info));
      break;
    }
    default:
      Result += Chunk.Text;
      break;
    }
  }
  return Result;
}

/// A scored code completion result.
/// It may be promoted to a CompletionItem if it's among the top-ranked results.
struct CompletionCandidate {
  CompletionCandidate(CodeCompletionResult &Result)
      : Result(&Result), Score(score(Result)) {}

  CodeCompletionResult *Result;
  float Score; // 0 to 1, higher is better.

  // Comparison reflects rank: better candidates are smaller.
  bool operator<(const CompletionCandidate &C) const {
    if (Score != C.Score)
      return Score > C.Score;
    return *Result < *C.Result;
  }

  // Returns a string that sorts in the same order as operator<, for LSP.
  // Conceptually, this is [-Score, Name]. We convert -Score to an integer, and
  // hex-encode it for readability. Example: [0.5, "foo"] -> "41000000foo"
  std::string sortText() const {
    std::string S, NameStorage;
    llvm::raw_string_ostream OS(S);
    write_hex(OS, encodeFloat(-Score), llvm::HexPrintStyle::Lower,
              /*Width=*/2 * sizeof(Score));
    OS << Result->getOrderedName(NameStorage);
    return OS.str();
  }

private:
  static float score(const CodeCompletionResult &Result) {
    // Priority 80 is a really bad score.
    float Score = 1 - std::min<float>(80, Result.Priority) / 80;

    switch (static_cast<CXAvailabilityKind>(Result.Availability)) {
    case CXAvailability_Available:
      // No penalty.
      break;
    case CXAvailability_Deprecated:
      Score *= 0.1f;
      break;
    case CXAvailability_NotAccessible:
    case CXAvailability_NotAvailable:
      Score = 0;
      break;
    }
    return Score;
  }

  // Produces an integer that sorts in the same order as F.
  // That is: a < b <==> encodeFloat(a) < encodeFloat(b).
  static uint32_t encodeFloat(float F) {
    static_assert(std::numeric_limits<float>::is_iec559, "");
    static_assert(sizeof(float) == sizeof(uint32_t), "");
    constexpr uint32_t TopBit = ~(~uint32_t{0} >> 1);

    // Get the bits of the float. Endianness is the same as for integers.
    uint32_t U;
    memcpy(&U, &F, sizeof(float));
    // IEEE 754 floats compare like sign-magnitude integers.
    if (U & TopBit)    // Negative float.
      return 0 - U;    // Map onto the low half of integers, order reversed.
    return U + TopBit; // Positive floats map onto the high half of integers.
  }
};

/// \brief Information about the scope specifier in the qualified-id code
/// completion (e.g. "ns::ab?").
struct SpecifiedScope {
  /// The scope specifier as written. For example, for completion "ns::ab?", the
  /// written scope specifier is "ns".
  std::string Written;
  // If this scope specifier is recognized in Sema (e.g. as a namespace
  // context), this will be set to the fully qualfied name of the corresponding
  // context.
  std::string Resolved;
};

/// \brief Information from sema about (parital) symbol names to be completed.
/// For example, for completion "ns::ab^", this stores the scope specifier
/// "ns::" and the completion filter text "ab".
struct NameToComplete {
  // The partial identifier being completed, without qualifier.
  std::string Filter;

  /// This is set if the completion is for qualified IDs, e.g. "abc::x^".
  llvm::Optional<SpecifiedScope> SSInfo;
};

SpecifiedScope extraCompletionScope(Sema &S, const CXXScopeSpec &SS);

class CompletionItemsCollector : public CodeCompleteConsumer {
public:
  CompletionItemsCollector(const CodeCompleteOptions &CodeCompleteOpts,
                           CompletionList &Items, NameToComplete &CompletedName)
      : CodeCompleteConsumer(CodeCompleteOpts.getClangCompleteOpts(),
                             /*OutputIsBinary=*/false),
        ClangdOpts(CodeCompleteOpts), Items(Items),
        Allocator(std::make_shared<clang::GlobalCodeCompletionAllocator>()),
        CCTUInfo(Allocator), CompletedName(CompletedName),
        EnableSnippets(CodeCompleteOpts.EnableSnippets) {}

  void ProcessCodeCompleteResults(Sema &S, CodeCompletionContext Context,
                                  CodeCompletionResult *Results,
                                  unsigned NumResults) override final {
    if (auto SS = Context.getCXXScopeSpecifier())
      CompletedName.SSInfo = extraCompletionScope(S, **SS);

    CompletedName.Filter = S.getPreprocessor().getCodeCompletionFilter();
    std::priority_queue<CompletionCandidate> Candidates;
    for (unsigned I = 0; I < NumResults; ++I) {
      auto &Result = Results[I];
      if (!ClangdOpts.IncludeIneligibleResults &&
          (Result.Availability == CXAvailability_NotAvailable ||
           Result.Availability == CXAvailability_NotAccessible))
        continue;
      if (!CompletedName.Filter.empty() &&
          !fuzzyMatch(S, Context, CompletedName.Filter, Result))
        continue;
      Candidates.emplace(Result);
      if (ClangdOpts.Limit && Candidates.size() > ClangdOpts.Limit) {
        Candidates.pop();
        Items.isIncomplete = true;
      }
    }
    while (!Candidates.empty()) {
      auto &Candidate = Candidates.top();
      const auto *CCS = Candidate.Result->CreateCodeCompletionString(
          S, Context, *Allocator, CCTUInfo,
          CodeCompleteOpts.IncludeBriefComments);
      assert(CCS && "Expected the CodeCompletionString to be non-null");
      Items.items.push_back(ProcessCodeCompleteResult(Candidate, *CCS));
      Candidates.pop();
    }
    std::reverse(Items.items.begin(), Items.items.end());
  }

  GlobalCodeCompletionAllocator &getAllocator() override { return *Allocator; }

  CodeCompletionTUInfo &getCodeCompletionTUInfo() override { return CCTUInfo; }

private:
  bool fuzzyMatch(Sema &S, const CodeCompletionContext &CCCtx, StringRef Filter,
                  CodeCompletionResult Result) {
    switch (Result.Kind) {
    case CodeCompletionResult::RK_Declaration:
      if (auto *ID = Result.Declaration->getIdentifier())
        return fuzzyMatch(Filter, ID->getName());
      break;
    case CodeCompletionResult::RK_Keyword:
      return fuzzyMatch(Filter, Result.Keyword);
    case CodeCompletionResult::RK_Macro:
      return fuzzyMatch(Filter, Result.Macro->getName());
    case CodeCompletionResult::RK_Pattern:
      return fuzzyMatch(Filter, Result.Pattern->getTypedText());
    }
    auto *CCS = Result.CreateCodeCompletionString(
        S, CCCtx, *Allocator, CCTUInfo, /*IncludeBriefComments=*/false);
    return fuzzyMatch(Filter, CCS->getTypedText());
  }

  // Checks whether Target matches the Filter.
  // Currently just requires a case-insensitive subsequence match.
  // FIXME: make stricter and word-based: 'unique_ptr' should not match 'que'.
  // FIXME: return a score to be incorporated into ranking.
  static bool fuzzyMatch(StringRef Filter, StringRef Target) {
    size_t TPos = 0;
    for (char C : Filter) {
      TPos = Target.find_lower(C, TPos);
      if (TPos == StringRef::npos)
        return false;
    }
    return true;
  }

  CompletionItem
  ProcessCodeCompleteResult(const CompletionCandidate &Candidate,
                            const CodeCompletionString &CCS) const {

    // Adjust this to InsertTextFormat::Snippet iff we encounter a
    // CK_Placeholder chunk in SnippetCompletionItemsCollector.
    CompletionItem Item;

    Item.documentation = getDocumentation(CCS);
    Item.sortText = Candidate.sortText();

    Item.detail = getDetail(CCS);
    Item.filterText = getFilterText(CCS);
    getLabelAndInsertText(CCS, &Item.label, &Item.insertText, EnableSnippets);

    Item.insertTextFormat = EnableSnippets ? InsertTextFormat::Snippet
                                           : InsertTextFormat::PlainText;

    // Fill in the kind field of the CompletionItem.
    Item.kind = toCompletionItemKind(Candidate.Result->Kind,
                                     Candidate.Result->CursorKind);

    return Item;
  }

  CodeCompleteOptions ClangdOpts;
  CompletionList &Items;
  std::shared_ptr<clang::GlobalCodeCompletionAllocator> Allocator;
  CodeCompletionTUInfo CCTUInfo;
  NameToComplete &CompletedName;
  bool EnableSnippets;
}; // CompletionItemsCollector

class SignatureHelpCollector final : public CodeCompleteConsumer {

public:
  SignatureHelpCollector(const clang::CodeCompleteOptions &CodeCompleteOpts,
                         SignatureHelp &SigHelp)
      : CodeCompleteConsumer(CodeCompleteOpts, /*OutputIsBinary=*/false),
        SigHelp(SigHelp),
        Allocator(std::make_shared<clang::GlobalCodeCompletionAllocator>()),
        CCTUInfo(Allocator) {}

  void ProcessOverloadCandidates(Sema &S, unsigned CurrentArg,
                                 OverloadCandidate *Candidates,
                                 unsigned NumCandidates) override {
    SigHelp.signatures.reserve(NumCandidates);
    // FIXME(rwols): How can we determine the "active overload candidate"?
    // Right now the overloaded candidates seem to be provided in a "best fit"
    // order, so I'm not too worried about this.
    SigHelp.activeSignature = 0;
    assert(CurrentArg <= (unsigned)std::numeric_limits<int>::max() &&
           "too many arguments");
    SigHelp.activeParameter = static_cast<int>(CurrentArg);
    for (unsigned I = 0; I < NumCandidates; ++I) {
      const auto &Candidate = Candidates[I];
      const auto *CCS = Candidate.CreateSignatureString(
          CurrentArg, S, *Allocator, CCTUInfo, true);
      assert(CCS && "Expected the CodeCompletionString to be non-null");
      SigHelp.signatures.push_back(ProcessOverloadCandidate(Candidate, *CCS));
    }
  }

  GlobalCodeCompletionAllocator &getAllocator() override { return *Allocator; }

  CodeCompletionTUInfo &getCodeCompletionTUInfo() override { return CCTUInfo; }

private:
  // FIXME(ioeric): consider moving CodeCompletionString logic here to
  // CompletionString.h.
  SignatureInformation
  ProcessOverloadCandidate(const OverloadCandidate &Candidate,
                           const CodeCompletionString &CCS) const {
    SignatureInformation Result;
    const char *ReturnType = nullptr;

    Result.documentation = getDocumentation(CCS);

    for (const auto &Chunk : CCS) {
      switch (Chunk.Kind) {
      case CodeCompletionString::CK_ResultType:
        // A piece of text that describes the type of an entity or,
        // for functions and methods, the return type.
        assert(!ReturnType && "Unexpected CK_ResultType");
        ReturnType = Chunk.Text;
        break;
      case CodeCompletionString::CK_Placeholder:
        // A string that acts as a placeholder for, e.g., a function call
        // argument.
        // Intentional fallthrough here.
      case CodeCompletionString::CK_CurrentParameter: {
        // A piece of text that describes the parameter that corresponds to
        // the code-completion location within a function call, message send,
        // macro invocation, etc.
        Result.label += Chunk.Text;
        ParameterInformation Info;
        Info.label = Chunk.Text;
        Result.parameters.push_back(std::move(Info));
        break;
      }
      case CodeCompletionString::CK_Optional: {
        // The rest of the parameters are defaulted/optional.
        assert(Chunk.Optional &&
               "Expected the optional code completion string to be non-null.");
        Result.label +=
            getOptionalParameters(*Chunk.Optional, Result.parameters);
        break;
      }
      case CodeCompletionString::CK_VerticalSpace:
        break;
      default:
        Result.label += Chunk.Text;
        break;
      }
    }
    if (ReturnType) {
      Result.label += " -> ";
      Result.label += ReturnType;
    }
    return Result;
  }

  SignatureHelp &SigHelp;
  std::shared_ptr<clang::GlobalCodeCompletionAllocator> Allocator;
  CodeCompletionTUInfo CCTUInfo;

}; // SignatureHelpCollector

bool invokeCodeComplete(const Context &Ctx,
                        std::unique_ptr<CodeCompleteConsumer> Consumer,
                        const clang::CodeCompleteOptions &Options,
                        PathRef FileName,
                        const tooling::CompileCommand &Command,
                        PrecompiledPreamble const *Preamble, StringRef Contents,
                        Position Pos, IntrusiveRefCntPtr<vfs::FileSystem> VFS,
                        std::shared_ptr<PCHContainerOperations> PCHs) {
  std::vector<const char *> ArgStrs;
  for (const auto &S : Command.CommandLine)
    ArgStrs.push_back(S.c_str());

  VFS->setCurrentWorkingDirectory(Command.Directory);

  IgnoreDiagnostics DummyDiagsConsumer;
  auto CI = createInvocationFromCommandLine(
      ArgStrs,
      CompilerInstance::createDiagnostics(new DiagnosticOptions,
                                          &DummyDiagsConsumer, false),
      VFS);
  assert(CI && "Couldn't create CompilerInvocation");

  std::unique_ptr<llvm::MemoryBuffer> ContentsBuffer =
      llvm::MemoryBuffer::getMemBufferCopy(Contents, FileName);

  // Attempt to reuse the PCH from precompiled preamble, if it was built.
  if (Preamble) {
    auto Bounds =
        ComputePreambleBounds(*CI->getLangOpts(), ContentsBuffer.get(), 0);
    if (!Preamble->CanReuse(*CI, ContentsBuffer.get(), Bounds, VFS.get()))
      Preamble = nullptr;
  }

  auto Clang = prepareCompilerInstance(
      std::move(CI), Preamble, std::move(ContentsBuffer), std::move(PCHs),
      std::move(VFS), DummyDiagsConsumer);
  auto &DiagOpts = Clang->getDiagnosticOpts();
  DiagOpts.IgnoreWarnings = true;

  auto &FrontendOpts = Clang->getFrontendOpts();
  FrontendOpts.SkipFunctionBodies = true;
  FrontendOpts.CodeCompleteOpts = Options;
  FrontendOpts.CodeCompletionAt.FileName = FileName;
  FrontendOpts.CodeCompletionAt.Line = Pos.line + 1;
  FrontendOpts.CodeCompletionAt.Column = Pos.character + 1;

  Clang->setCodeCompletionConsumer(Consumer.release());

  SyntaxOnlyAction Action;
  if (!Action.BeginSourceFile(*Clang, Clang->getFrontendOpts().Inputs[0])) {
    log(Ctx,
        "BeginSourceFile() failed when running codeComplete for " + FileName);
    return false;
  }
  if (!Action.Execute()) {
    log(Ctx, "Execute() failed when running codeComplete for " + FileName);
    return false;
  }

  Action.EndSourceFile();

  return true;
}

CompletionItem indexCompletionItem(const Symbol &Sym, llvm::StringRef Filter,
                                   const SpecifiedScope &SSInfo) {
  CompletionItem Item;
  Item.kind = toCompletionItemKind(Sym.SymInfo.Kind);
  Item.label = Sym.Name;
  // FIXME(ioeric): support inserting/replacing scope qualifiers.
  Item.insertText = Sym.Name;
  // FIXME(ioeric): support snippets.
  Item.insertTextFormat = InsertTextFormat::PlainText;
  Item.filterText = Sym.Name;

  // FIXME(ioeric): sort symbols appropriately.
  Item.sortText = "";

  // FIXME(ioeric): use more symbol information (e.g. documentation, label) to
  // populate the completion item.

  return Item;
}

void completeWithIndex(const Context &Ctx, const SymbolIndex &Index,
                       llvm::StringRef Code, const SpecifiedScope &SSInfo,
                       llvm::StringRef Filter, CompletionList *Items) {
  FuzzyFindRequest Req;
  Req.Query = Filter;
  // FIXME(ioeric): add more possible scopes based on using namespaces and
  // containing namespaces.
  StringRef Scope = SSInfo.Resolved.empty() ? SSInfo.Written : SSInfo.Resolved;
  Req.Scopes = {Scope.trim(':').str()};

  Items->isIncomplete = !Index.fuzzyFind(Ctx, Req, [&](const Symbol &Sym) {
    Items->items.push_back(indexCompletionItem(Sym, Filter, SSInfo));
  });
}

SpecifiedScope extraCompletionScope(Sema &S, const CXXScopeSpec &SS) {
  SpecifiedScope Info;
  auto &SM = S.getSourceManager();
  auto SpecifierRange = SS.getRange();
  Info.Written = Lexer::getSourceText(
      CharSourceRange::getCharRange(SpecifierRange), SM, clang::LangOptions());
  if (SS.isValid()) {
    DeclContext *DC = S.computeDeclContext(SS);
    if (auto *NS = llvm::dyn_cast<NamespaceDecl>(DC)) {
      Info.Resolved = NS->getQualifiedNameAsString();
    } else if (llvm::dyn_cast<TranslationUnitDecl>(DC) != nullptr) {
      Info.Resolved = "::";
      // Sema does not include the suffix "::" in the range of SS, so we add
      // it back here.
      Info.Written = "::";
    }
  }
  return Info;
}

} // namespace

clang::CodeCompleteOptions CodeCompleteOptions::getClangCompleteOpts() const {
  clang::CodeCompleteOptions Result;
  Result.IncludeCodePatterns = EnableSnippets && IncludeCodePatterns;
  Result.IncludeMacros = IncludeMacros;
  Result.IncludeGlobals = IncludeGlobals;
  Result.IncludeBriefComments = IncludeBriefComments;

  // Enable index-based code completion when Index is provided.
  Result.IncludeNamespaceLevelDecls = !Index;

  return Result;
}

CompletionList codeComplete(const Context &Ctx, PathRef FileName,
                            const tooling::CompileCommand &Command,
                            PrecompiledPreamble const *Preamble,
                            StringRef Contents, Position Pos,
                            IntrusiveRefCntPtr<vfs::FileSystem> VFS,
                            std::shared_ptr<PCHContainerOperations> PCHs,
                            CodeCompleteOptions Opts) {
  CompletionList Results;
  NameToComplete CompletedName;
  auto Consumer =
      llvm::make_unique<CompletionItemsCollector>(Opts, Results, CompletedName);
  invokeCodeComplete(Ctx, std::move(Consumer), Opts.getClangCompleteOpts(),
                     FileName, Command, Preamble, Contents, Pos, std::move(VFS),
                     std::move(PCHs));
  if (Opts.Index && CompletedName.SSInfo) {
    if (!Results.items.empty())
      log(Ctx, "WARNING: Got completion results from sema for completion on "
               "qualified ID while symbol index is provided.");
    Results.items.clear();
    completeWithIndex(Ctx, *Opts.Index, Contents, *CompletedName.SSInfo,
                      CompletedName.Filter, &Results);
  }
  return Results;
}

SignatureHelp signatureHelp(const Context &Ctx, PathRef FileName,
                            const tooling::CompileCommand &Command,
                            PrecompiledPreamble const *Preamble,
                            StringRef Contents, Position Pos,
                            IntrusiveRefCntPtr<vfs::FileSystem> VFS,
                            std::shared_ptr<PCHContainerOperations> PCHs) {
  SignatureHelp Result;
  clang::CodeCompleteOptions Options;
  Options.IncludeGlobals = false;
  Options.IncludeMacros = false;
  Options.IncludeCodePatterns = false;
  Options.IncludeBriefComments = true;
  invokeCodeComplete(Ctx,
                     llvm::make_unique<SignatureHelpCollector>(Options, Result),
                     Options, FileName, Command, Preamble, Contents, Pos,
                     std::move(VFS), std::move(PCHs));
  return Result;
}

} // namespace clangd
} // namespace clang
