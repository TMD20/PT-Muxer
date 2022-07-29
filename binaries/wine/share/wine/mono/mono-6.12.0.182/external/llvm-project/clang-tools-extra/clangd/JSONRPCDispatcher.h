//===--- JSONRPCDispatcher.h - Main JSON parser entry point -----*- C++ -*-===//
//
//                     The LLVM Compiler Infrastructure
//
// This file is distributed under the University of Illinois Open Source
// License. See LICENSE.TXT for details.
//
//===----------------------------------------------------------------------===//

#ifndef LLVM_CLANG_TOOLS_EXTRA_CLANGD_JSONRPCDISPATCHER_H
#define LLVM_CLANG_TOOLS_EXTRA_CLANGD_JSONRPCDISPATCHER_H

#include "Context.h"
#include "JSONExpr.h"
#include "Logger.h"
#include "Protocol.h"
#include "Trace.h"
#include "clang/Basic/LLVM.h"
#include "llvm/ADT/SmallString.h"
#include "llvm/ADT/StringMap.h"
#include <iosfwd>
#include <mutex>

namespace clang {
namespace clangd {

/// Encapsulates output and logs streams and provides thread-safe access to
/// them.
class JSONOutput : public Logger {
  // FIXME(ibiryukov): figure out if we can shrink the public interface of
  // JSONOutput now that we pass Context everywhere.
public:
  JSONOutput(llvm::raw_ostream &Outs, llvm::raw_ostream &Logs,
             llvm::raw_ostream *InputMirror = nullptr, bool Pretty = false)
      : Pretty(Pretty), Outs(Outs), Logs(Logs), InputMirror(InputMirror) {}

  /// Emit a JSONRPC message.
  void writeMessage(const json::Expr &Result);

  /// Write a line to the logging stream.
  void log(const Context &Ctx, const Twine &Message) override;

  /// Mirror \p Message into InputMirror stream. Does nothing if InputMirror is
  /// null.
  /// Unlike other methods of JSONOutput, mirrorInput is not thread-safe.
  void mirrorInput(const Twine &Message);

  // Whether output should be pretty-printed.
  const bool Pretty;

private:
  llvm::raw_ostream &Outs;
  llvm::raw_ostream &Logs;
  llvm::raw_ostream *InputMirror;

  std::mutex StreamMutex;
};

/// Sends a successful reply. \p Ctx must either be the Context accepted by
/// JSONRPCDispatcher::Handler or be derived from it.
void reply(const Context &Ctx, json::Expr &&Result);
/// Sends an error response to the client, and logs it. \p Ctx must either be
/// the Context accepted by JSONRPCDispatcher::Handler or be derived from it.
void replyError(const Context &Ctx, ErrorCode code,
                const llvm::StringRef &Message);
/// Sends a request to the client. \p Ctx must either be the Context accepted by
/// JSONRPCDispatcher::Handler or be derived from it.
void call(const Context &Ctx, llvm::StringRef Method, json::Expr &&Params);

/// Main JSONRPC entry point. This parses the JSONRPC "header" and calls the
/// registered Handler for the method received.
class JSONRPCDispatcher {
public:
  // A handler responds to requests for a particular method name.
  using Handler = std::function<void(Context, const json::Expr &)>;

  /// Create a new JSONRPCDispatcher. UnknownHandler is called when an unknown
  /// method is received.
  JSONRPCDispatcher(Handler UnknownHandler)
      : UnknownHandler(std::move(UnknownHandler)) {}

  /// Registers a Handler for the specified Method.
  void registerHandler(StringRef Method, Handler H);

  /// Parses a JSONRPC message and calls the Handler for it.
  bool call(const json::Expr &Message, JSONOutput &Out) const;

private:
  llvm::StringMap<Handler> Handlers;
  Handler UnknownHandler;
};

/// Parses input queries from LSP client (coming from \p In) and runs call
/// method of \p Dispatcher for each query.
/// After handling each query checks if \p IsDone is set true and exits the loop
/// if it is.
/// Input stream(\p In) must be opened in binary mode to avoid preliminary
/// replacements of \r\n with \n.
void runLanguageServerLoop(std::istream &In, JSONOutput &Out,
                           JSONRPCDispatcher &Dispatcher, bool &IsDone);

} // namespace clangd
} // namespace clang

#endif
