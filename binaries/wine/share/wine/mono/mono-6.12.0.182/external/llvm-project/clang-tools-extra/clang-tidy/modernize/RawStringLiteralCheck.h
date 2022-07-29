//===--- RawStringLiteralCheck.h - clang-tidy--------------------*- C++ -*-===//
//
//                     The LLVM Compiler Infrastructure
//
// This file is distributed under the University of Illinois Open Source
// License. See LICENSE.TXT for details.
//
//===----------------------------------------------------------------------===//

#ifndef LLVM_CLANG_TOOLS_EXTRA_CLANG_TIDY_MODERNIZE_RAW_STRING_LITERAL_H
#define LLVM_CLANG_TOOLS_EXTRA_CLANG_TIDY_MODERNIZE_RAW_STRING_LITERAL_H

#include "../ClangTidy.h"

namespace clang {
namespace tidy {
namespace modernize {

/// This check replaces string literals with escaped characters to
/// raw string literals.
///
/// For the user-facing documentation see:
/// http://clang.llvm.org/extra/clang-tidy/checks/modernize-raw-string-literal.html
class RawStringLiteralCheck : public ClangTidyCheck {
public:
  RawStringLiteralCheck(StringRef Name, ClangTidyContext *Context);

  void storeOptions(ClangTidyOptions::OptionMap &Options) override;
  void registerMatchers(ast_matchers::MatchFinder *Finder) override;
  void check(const ast_matchers::MatchFinder::MatchResult &Result) override;

private:
  void replaceWithRawStringLiteral(
      const ast_matchers::MatchFinder::MatchResult &Result,
      const StringLiteral *Literal, StringRef Replacement);

  std::string DelimiterStem;
  const bool ReplaceShorterLiterals;
};

} // namespace modernize
} // namespace tidy
} // namespace clang

#endif // LLVM_CLANG_TOOLS_EXTRA_CLANG_TIDY_MODERNIZE_RAW_STRING_LITERAL_H
