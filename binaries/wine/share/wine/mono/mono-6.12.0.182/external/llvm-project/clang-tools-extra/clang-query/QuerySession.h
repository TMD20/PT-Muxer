//===--- QuerySession.h - clang-query ---------------------------*- C++ -*-===//
//
//                     The LLVM Compiler Infrastructure
//
// This file is distributed under the University of Illinois Open Source
// License. See LICENSE.TXT for details.
//
//===----------------------------------------------------------------------===//

#ifndef LLVM_CLANG_TOOLS_EXTRA_CLANG_QUERY_QUERY_SESSION_H
#define LLVM_CLANG_TOOLS_EXTRA_CLANG_QUERY_QUERY_SESSION_H

#include "Query.h"
#include "clang/ASTMatchers/Dynamic/VariantValue.h"
#include "llvm/ADT/ArrayRef.h"
#include "llvm/ADT/StringMap.h"

namespace clang {

class ASTUnit;

namespace query {

/// Represents the state for a particular clang-query session.
class QuerySession {
public:
  QuerySession(llvm::ArrayRef<std::unique_ptr<ASTUnit>> ASTs)
      : ASTs(ASTs), OutKind(OK_Diag), BindRoot(true), Terminate(false) {}

  llvm::ArrayRef<std::unique_ptr<ASTUnit>> ASTs;
  OutputKind OutKind;
  bool BindRoot;
  bool Terminate;
  llvm::StringMap<ast_matchers::dynamic::VariantValue> NamedValues;
};

} // namespace query
} // namespace clang

#endif
