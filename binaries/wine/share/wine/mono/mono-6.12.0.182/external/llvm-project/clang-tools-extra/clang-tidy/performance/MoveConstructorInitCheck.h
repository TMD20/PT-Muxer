//===--- MoveConstructorInitCheck.h - clang-tidy-----------------*- C++ -*-===//
//
//                     The LLVM Compiler Infrastructure
//
// This file is distributed under the University of Illinois Open Source
// License. See LICENSE.TXT for details.
//
//===----------------------------------------------------------------------===//

#ifndef LLVM_CLANG_TOOLS_EXTRA_CLANG_TIDY_PERFORMANCE_MOVECONSTRUCTORINITCHECK_H
#define LLVM_CLANG_TOOLS_EXTRA_CLANG_TIDY_PERFORMANCE_MOVECONSTRUCTORINITCHECK_H

#include "../ClangTidy.h"
#include "../utils/IncludeInserter.h"

#include <memory>

namespace clang {
namespace tidy {
namespace performance {

/// The check flags user-defined move constructors that have a ctor-initializer
/// initializing a member or base class through a copy constructor instead of a
/// move constructor.
/// For the user-facing documentation see:
/// http://clang.llvm.org/extra/clang-tidy/checks/performance-move-constructor-init.html
class MoveConstructorInitCheck : public ClangTidyCheck {
public:
  MoveConstructorInitCheck(StringRef Name, ClangTidyContext *Context);
  void registerMatchers(ast_matchers::MatchFinder *Finder) override;
  void check(const ast_matchers::MatchFinder::MatchResult &Result) override;
  void registerPPCallbacks(clang::CompilerInstance &Compiler) override;
  void storeOptions(ClangTidyOptions::OptionMap &Opts) override;

private:
  std::unique_ptr<utils::IncludeInserter> Inserter;
  const utils::IncludeSorter::IncludeStyle IncludeStyle;
};

} // namespace performance
} // namespace tidy
} // namespace clang

#endif // LLVM_CLANG_TOOLS_EXTRA_CLANG_TIDY_PERFORMANCE_MOVECONSTRUCTORINITCHECK_H
