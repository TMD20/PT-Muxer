//===--- MisplacedArrayIndexCheck.cpp - clang-tidy-------------------------===//
//
//                     The LLVM Compiler Infrastructure
//
// This file is distributed under the University of Illinois Open Source
// License. See LICENSE.TXT for details.
//
//===----------------------------------------------------------------------===//

#include "MisplacedArrayIndexCheck.h"
#include "clang/AST/ASTContext.h"
#include "clang/ASTMatchers/ASTMatchFinder.h"
#include "clang/Lex/Lexer.h"
#include "clang/Tooling/FixIt.h"

using namespace clang::ast_matchers;

namespace clang {
namespace tidy {
namespace readability {

void MisplacedArrayIndexCheck::registerMatchers(MatchFinder *Finder) {
  Finder->addMatcher(arraySubscriptExpr(hasLHS(hasType(isInteger())),
                                        hasRHS(hasType(isAnyPointer())))
                         .bind("expr"),
                     this);
}

void MisplacedArrayIndexCheck::check(const MatchFinder::MatchResult &Result) {
  const auto *ArraySubscriptE =
      Result.Nodes.getNodeAs<ArraySubscriptExpr>("expr");

  auto Diag = diag(ArraySubscriptE->getLocStart(), "confusing array subscript "
                                                   "expression, usually the "
                                                   "index is inside the []");

  // Only try to fixit when LHS and RHS can be swapped directly without changing
  // the logic.
  const Expr *RHSE = ArraySubscriptE->getRHS()->IgnoreParenImpCasts();
  if (!isa<StringLiteral>(RHSE) && !isa<DeclRefExpr>(RHSE) &&
      !isa<MemberExpr>(RHSE))
    return;

  const StringRef LText = tooling::fixit::getText(
      ArraySubscriptE->getLHS()->getSourceRange(), *Result.Context);
  const StringRef RText = tooling::fixit::getText(
      ArraySubscriptE->getRHS()->getSourceRange(), *Result.Context);

  Diag << FixItHint::CreateReplacement(
      ArraySubscriptE->getLHS()->getSourceRange(), RText);
  Diag << FixItHint::CreateReplacement(
      ArraySubscriptE->getRHS()->getSourceRange(), LText);
}

} // namespace readability
} // namespace tidy
} // namespace clang
