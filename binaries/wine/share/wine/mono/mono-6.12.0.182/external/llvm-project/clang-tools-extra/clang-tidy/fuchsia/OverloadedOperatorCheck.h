//===--- OverloadedOperatorCheck.h - clang-tidy------------------*- C++ -*-===//
//
//                     The LLVM Compiler Infrastructure
//
// This file is distributed under the University of Illinois Open Source
// License. See LICENSE.TXT for details.
//
//===----------------------------------------------------------------------===//

#ifndef LLVM_CLANG_TOOLS_EXTRA_CLANG_TIDY_FUCHSIA_OVERLOADED_OPERATOR_H
#define LLVM_CLANG_TOOLS_EXTRA_CLANG_TIDY_FUCHSIA_OVERLOADED_OPERATOR_H

#include "../ClangTidy.h"

namespace clang {
namespace tidy {
namespace fuchsia {

/// Overloading operators is disallowed by the Fuchsia coding standard.
///
/// For the user-facing documentation see:
/// http://clang.llvm.org/extra/clang-tidy/checks/fuchsia-overloaded-operator.html
class OverloadedOperatorCheck : public ClangTidyCheck {
public:
  OverloadedOperatorCheck(StringRef Name, ClangTidyContext *Context)
      : ClangTidyCheck(Name, Context) {}
  void registerMatchers(ast_matchers::MatchFinder *Finder) override;
  void check(const ast_matchers::MatchFinder::MatchResult &Result) override;
};

} // namespace fuchsia
} // namespace tidy
} // namespace clang

#endif // LLVM_CLANG_TOOLS_EXTRA_CLANG_TIDY_FUCHSIA_OVERLOADED_OPERATOR_H
