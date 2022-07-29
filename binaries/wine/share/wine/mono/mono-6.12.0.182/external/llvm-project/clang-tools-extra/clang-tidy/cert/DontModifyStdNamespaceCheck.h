//===--- DontModifyStdNamespaceCheck.h - clang-tidy--------------*- C++ -*-===//
//
//                     The LLVM Compiler Infrastructure
//
// This file is distributed under the University of Illinois Open Source
// License. See LICENSE.TXT for details.
//
//===----------------------------------------------------------------------===//

#ifndef LLVM_CLANG_TOOLS_EXTRA_CLANG_TIDY_CERT_DONT_MODIFY_STD_NAMESPACE_H
#define LLVM_CLANG_TOOLS_EXTRA_CLANG_TIDY_CERT_DONT_MODIFY_STD_NAMESPACE_H

#include "../ClangTidy.h"

namespace clang {
namespace tidy {
namespace cert {

/// Modification of the std or posix namespace can result in undefined behavior.
/// This check warns for such modifications.
///
/// For the user-facing documentation see:
/// http://clang.llvm.org/extra/clang-tidy/checks/cert-msc53-cpp.html
class DontModifyStdNamespaceCheck : public ClangTidyCheck {
public:
  DontModifyStdNamespaceCheck(StringRef Name, ClangTidyContext *Context)
      : ClangTidyCheck(Name, Context) {}
  void registerMatchers(ast_matchers::MatchFinder *Finder) override;
  void check(const ast_matchers::MatchFinder::MatchResult &Result) override;
};

} // namespace cert
} // namespace tidy
} // namespace clang

#endif // LLVM_CLANG_TOOLS_EXTRA_CLANG_TIDY_CERT_DONT_MODIFY_STD_NAMESPACE_H
