//===--- StaticAccessedThroughInstanceCheck.cpp - clang-tidy---------------===//
//
//                     The LLVM Compiler Infrastructure
//
// This file is distributed under the University of Illinois Open Source
// License. See LICENSE.TXT for details.
//
//===----------------------------------------------------------------------===//

#include "StaticAccessedThroughInstanceCheck.h"
#include "clang/AST/ASTContext.h"
#include "clang/ASTMatchers/ASTMatchFinder.h"

using namespace clang::ast_matchers;

namespace clang {
namespace tidy {
namespace readability {

static unsigned getNameSpecifierNestingLevel(const QualType &QType) {
  if (const ElaboratedType *ElType = QType->getAs<ElaboratedType>()) {
    const NestedNameSpecifier *NestedSpecifiers = ElType->getQualifier();
    unsigned NameSpecifierNestingLevel = 1;
    do {
      NameSpecifierNestingLevel++;
      NestedSpecifiers = NestedSpecifiers->getPrefix();
    } while (NestedSpecifiers);

    return NameSpecifierNestingLevel;
  }
  return 0;
}

void StaticAccessedThroughInstanceCheck::storeOptions(
    ClangTidyOptions::OptionMap &Opts) {
  Options.store(Opts, "NameSpecifierNestingThreshold",
                NameSpecifierNestingThreshold);
}

void StaticAccessedThroughInstanceCheck::registerMatchers(MatchFinder *Finder) {
  Finder->addMatcher(
      memberExpr(hasDeclaration(anyOf(cxxMethodDecl(isStaticStorageClass()),
                                      varDecl(hasStaticStorageDuration()))),
                 unless(isInTemplateInstantiation()))
          .bind("memberExpression"),
      this);
}

void StaticAccessedThroughInstanceCheck::check(
    const MatchFinder::MatchResult &Result) {
  const auto *MemberExpression =
      Result.Nodes.getNodeAs<MemberExpr>("memberExpression");

  if (MemberExpression->getLocStart().isMacroID())
    return;

  const Expr *BaseExpr = MemberExpression->getBase();

  // Do not warn for overlaoded -> operators.
  if (isa<CXXOperatorCallExpr>(BaseExpr))
    return;

  QualType BaseType =
      BaseExpr->getType()->isPointerType()
          ? BaseExpr->getType()->getPointeeType().getUnqualifiedType()
          : BaseExpr->getType().getUnqualifiedType();

  const ASTContext *AstContext = Result.Context;
  PrintingPolicy PrintingPolicyWithSupressedTag(AstContext->getLangOpts());
  PrintingPolicyWithSupressedTag.SuppressTagKeyword = true;
  std::string BaseTypeName =
      BaseType.getAsString(PrintingPolicyWithSupressedTag);

  SourceLocation MemberExprStartLoc = MemberExpression->getLocStart();
  auto Diag =
      diag(MemberExprStartLoc, "static member accessed through instance");

  if (BaseExpr->HasSideEffects(*AstContext) ||
      getNameSpecifierNestingLevel(BaseType) > NameSpecifierNestingThreshold)
    return;

  Diag << FixItHint::CreateReplacement(
      CharSourceRange::getCharRange(MemberExprStartLoc,
                                    MemberExpression->getMemberLoc()),
      BaseTypeName + "::");
}

} // namespace readability
} // namespace tidy
} // namespace clang
