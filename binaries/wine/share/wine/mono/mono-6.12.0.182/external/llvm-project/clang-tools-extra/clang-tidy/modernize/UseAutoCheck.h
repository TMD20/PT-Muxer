//===--- UseAutoCheck.h - clang-tidy-----------------------------*- C++ -*-===//
//
//                     The LLVM Compiler Infrastructure
//
// This file is distributed under the University of Illinois Open Source
// License. See LICENSE.TXT for details.
//
//===----------------------------------------------------------------------===//

#ifndef LLVM_CLANG_TOOLS_EXTRA_CLANG_TIDY_MODERNIZE_USE_AUTO_H
#define LLVM_CLANG_TOOLS_EXTRA_CLANG_TIDY_MODERNIZE_USE_AUTO_H

#include "../ClangTidy.h"

namespace clang {
namespace tidy {
namespace modernize {

class UseAutoCheck : public ClangTidyCheck {
public:
  UseAutoCheck(StringRef Name, ClangTidyContext *Context);
  void storeOptions(ClangTidyOptions::OptionMap &Opts) override;
  void registerMatchers(ast_matchers::MatchFinder *Finder) override;
  void check(const ast_matchers::MatchFinder::MatchResult &Result) override;

private:
  void replaceIterators(const DeclStmt *D, ASTContext *Context);
  void replaceExpr(const DeclStmt *D, ASTContext *Context,
                   llvm::function_ref<QualType(const Expr *)> GetType,
                   StringRef Message);

  const bool RemoveStars;
};

} // namespace modernize
} // namespace tidy
} // namespace clang

#endif // LLVM_CLANG_TOOLS_EXTRA_CLANG_TIDY_MODERNIZE_USE_AUTO_H
