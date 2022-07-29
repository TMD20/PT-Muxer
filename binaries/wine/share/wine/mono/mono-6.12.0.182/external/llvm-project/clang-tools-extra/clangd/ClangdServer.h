//===--- ClangdServer.h - Main clangd server code ----------------*- C++-*-===//
//
//                     The LLVM Compiler Infrastructure
//
// This file is distributed under the University of Illinois Open Source
// License. See LICENSE.TXT for details.
//
//===----------------------------------------------------------------------===//

#ifndef LLVM_CLANG_TOOLS_EXTRA_CLANGD_CLANGDSERVER_H
#define LLVM_CLANG_TOOLS_EXTRA_CLANGD_CLANGDSERVER_H

#include "ClangdUnit.h"
#include "ClangdUnitStore.h"
#include "CodeComplete.h"
#include "DraftStore.h"
#include "Function.h"
#include "GlobalCompilationDatabase.h"
#include "Protocol.h"
#include "index/FileIndex.h"
#include "clang/Tooling/CompilationDatabase.h"
#include "clang/Tooling/Core/Replacement.h"
#include "llvm/ADT/IntrusiveRefCntPtr.h"
#include "llvm/ADT/Optional.h"
#include "llvm/ADT/StringRef.h"
#include <condition_variable>
#include <functional>
#include <mutex>
#include <string>
#include <thread>
#include <type_traits>
#include <utility>

namespace clang {
class PCHContainerOperations;

namespace clangd {

/// A tag supplied by the FileSytemProvider.
typedef std::string VFSTag;

/// A value of an arbitrary type and VFSTag that was supplied by the
/// FileSystemProvider when this value was computed.
template <class T> class Tagged {
public:
  // MSVC requires future<> arguments to be default-constructible.
  Tagged() = default;

  template <class U>
  Tagged(U &&Value, VFSTag Tag)
      : Value(std::forward<U>(Value)), Tag(std::move(Tag)) {}

  template <class U>
  Tagged(const Tagged<U> &Other) : Value(Other.Value), Tag(Other.Tag) {}

  template <class U>
  Tagged(Tagged<U> &&Other)
      : Value(std::move(Other.Value)), Tag(std::move(Other.Tag)) {}

  T Value = T();
  VFSTag Tag = VFSTag();
};

template <class T>
Tagged<typename std::decay<T>::type> make_tagged(T &&Value, VFSTag Tag) {
  return Tagged<typename std::decay<T>::type>(std::forward<T>(Value), Tag);
}

class DiagnosticsConsumer {
public:
  virtual ~DiagnosticsConsumer() = default;

  /// Called by ClangdServer when \p Diagnostics for \p File are ready.
  virtual void
  onDiagnosticsReady(PathRef File,
                     Tagged<std::vector<DiagWithFixIts>> Diagnostics) = 0;
};

class FileSystemProvider {
public:
  virtual ~FileSystemProvider() = default;
  /// Called by ClangdServer to obtain a vfs::FileSystem to be used for parsing.
  /// Name of the file that will be parsed is passed in \p File.
  ///
  /// \return A filesystem that will be used for all file accesses in clangd.
  /// A Tag returned by this method will be propagated to all results of clangd
  /// that will use this filesystem.
  virtual Tagged<IntrusiveRefCntPtr<vfs::FileSystem>>
  getTaggedFileSystem(PathRef File) = 0;
};

class RealFileSystemProvider : public FileSystemProvider {
public:
  /// \return getRealFileSystem() tagged with default tag, i.e. VFSTag()
  Tagged<IntrusiveRefCntPtr<vfs::FileSystem>>
  getTaggedFileSystem(PathRef File) override;
};

class ClangdServer;

/// Returns a number of a default async threads to use for ClangdScheduler.
/// Returned value is always >= 1 (i.e. will not cause requests to be processed
/// synchronously).
unsigned getDefaultAsyncThreadsCount();

/// Handles running WorkerRequests of ClangdServer on a number of worker
/// threads.
class ClangdScheduler {
public:
  /// If \p AsyncThreadsCount is 0, requests added using addToFront and addToEnd
  /// will be processed synchronously on the calling thread.
  // Otherwise, \p AsyncThreadsCount threads will be created to schedule the
  // requests.
  ClangdScheduler(unsigned AsyncThreadsCount);
  ~ClangdScheduler();

  /// Add a new request to run function \p F with args \p As to the start of the
  /// queue. The request will be run on a separate thread.
  template <class Func, class... Args>
  void addToFront(Func &&F, Args &&... As) {
    if (RunSynchronously) {
      std::forward<Func>(F)(std::forward<Args>(As)...);
      return;
    }

    {
      std::lock_guard<std::mutex> Lock(Mutex);
      RequestQueue.push_front(
          BindWithForward(std::forward<Func>(F), std::forward<Args>(As)...));
    }
    RequestCV.notify_one();
  }

  /// Add a new request to run function \p F with args \p As to the end of the
  /// queue. The request will be run on a separate thread.
  template <class Func, class... Args> void addToEnd(Func &&F, Args &&... As) {
    if (RunSynchronously) {
      std::forward<Func>(F)(std::forward<Args>(As)...);
      return;
    }

    {
      std::lock_guard<std::mutex> Lock(Mutex);
      RequestQueue.push_back(
          BindWithForward(std::forward<Func>(F), std::forward<Args>(As)...));
    }
    RequestCV.notify_one();
  }

private:
  bool RunSynchronously;
  std::mutex Mutex;
  /// We run some tasks on separate threads(parsing, CppFile cleanup).
  /// These threads looks into RequestQueue to find requests to handle and
  /// terminate when Done is set to true.
  std::vector<std::thread> Workers;
  /// Setting Done to true will make the worker threads terminate.
  bool Done = false;
  /// A queue of requests. Elements of this vector are async computations (i.e.
  /// results of calling std::async(std::launch::deferred, ...)).
  std::deque<UniqueFunction<void()>> RequestQueue;
  /// Condition variable to wake up worker threads.
  std::condition_variable RequestCV;
};

/// Provides API to manage ASTs for a collection of C++ files and request
/// various language features.
/// Currently supports async diagnostics, code completion, formatting and goto
/// definition.
class ClangdServer {
public:
  /// Creates a new ClangdServer instance.
  /// To process parsing requests asynchronously, ClangdServer will spawn \p
  /// AsyncThreadsCount worker threads. However, if \p AsyncThreadsCount is 0,
  /// all requests will be processed on the calling thread.
  ///
  /// ClangdServer uses \p FSProvider to get an instance of vfs::FileSystem for
  /// each parsing request. Results of code completion and diagnostics also
  /// include a tag, that \p FSProvider returns along with the vfs::FileSystem.
  ///
  /// The value of \p ResourceDir will be used to search for internal headers
  /// (overriding defaults and -resource-dir compiler flag). If \p ResourceDir
  /// is None, ClangdServer will call CompilerInvocation::GetResourcePath() to
  /// obtain the standard resource directory.
  ///
  /// ClangdServer uses \p CDB to obtain compilation arguments for parsing. Note
  /// that ClangdServer only obtains compilation arguments once for each newly
  /// added file (i.e., when processing a first call to addDocument) and reuses
  /// those arguments for subsequent reparses. However, ClangdServer will check
  /// if compilation arguments changed on calls to forceReparse().
  ///
  /// After each parsing request finishes, ClangdServer reports diagnostics to
  /// \p DiagConsumer. Note that a callback to \p DiagConsumer happens on a
  /// worker thread. Therefore, instances of \p DiagConsumer must properly
  /// synchronize access to shared state.
  ///
  /// \p StorePreamblesInMemory defines whether the Preambles generated by
  /// clangd are stored in-memory or on disk.
  ///
  /// If \p BuildDynamicSymbolIndex is true, ClangdServer builds a dynamic
  /// in-memory index for symbols in all opened files and uses the index to
  /// augment code completion results.
  ClangdServer(GlobalCompilationDatabase &CDB,
               DiagnosticsConsumer &DiagConsumer,
               FileSystemProvider &FSProvider, unsigned AsyncThreadsCount,
               bool StorePreamblesInMemory,
               bool BuildDynamicSymbolIndex = false,
               llvm::Optional<StringRef> ResourceDir = llvm::None);

  /// Set the root path of the workspace.
  void setRootPath(PathRef RootPath);

  /// Add a \p File to the list of tracked C++ files or update the contents if
  /// \p File is already tracked. Also schedules parsing of the AST for it on a
  /// separate thread. When the parsing is complete, DiagConsumer passed in
  /// constructor will receive onDiagnosticsReady callback.
  /// \return A future that will become ready when the rebuild (including
  /// diagnostics) is finished.
  std::future<Context> addDocument(Context Ctx, PathRef File,
                                   StringRef Contents);
  /// Remove \p File from list of tracked files, schedule a request to free
  /// resources associated with it.
  /// \return A future that will become ready when the file is removed and all
  /// associated resources are freed.
  std::future<Context> removeDocument(Context Ctx, PathRef File);
  /// Force \p File to be reparsed using the latest contents.
  /// Will also check if CompileCommand, provided by GlobalCompilationDatabase
  /// for \p File has changed. If it has, will remove currently stored Preamble
  /// and AST and rebuild them from scratch.
  std::future<Context> forceReparse(Context Ctx, PathRef File);

  /// DEPRECATED. Please use a callback-based version, this API is deprecated
  /// and will soon be removed.
  ///
  /// Run code completion for \p File at \p Pos.
  ///
  /// Request is processed asynchronously. You can use the returned future to
  /// wait for the results of the async request.
  ///
  /// If \p OverridenContents is not None, they will used only for code
  /// completion, i.e. no diagnostics update will be scheduled and a draft for
  /// \p File will not be updated. If \p OverridenContents is None, contents of
  /// the current draft for \p File will be used. If \p UsedFS is non-null, it
  /// will be overwritten by vfs::FileSystem used for completion.
  ///
  /// This method should only be called for currently tracked files. However, it
  /// is safe to call removeDocument for \p File after this method returns, even
  /// while returned future is not yet ready.
  std::future<std::pair<Context, Tagged<CompletionList>>>
  codeComplete(Context Ctx, PathRef File, Position Pos,
               const clangd::CodeCompleteOptions &Opts,
               llvm::Optional<StringRef> OverridenContents = llvm::None,
               IntrusiveRefCntPtr<vfs::FileSystem> *UsedFS = nullptr);

  /// A version of `codeComplete` that runs \p Callback on the processing thread
  /// when codeComplete results become available.
  void
  codeComplete(Context Ctx, PathRef File, Position Pos,
               const clangd::CodeCompleteOptions &Opts,
               UniqueFunction<void(Context, Tagged<CompletionList>)> Callback,
               llvm::Optional<StringRef> OverridenContents = llvm::None,
               IntrusiveRefCntPtr<vfs::FileSystem> *UsedFS = nullptr);

  /// Provide signature help for \p File at \p Pos. If \p OverridenContents is
  /// not None, they will used only for signature help, i.e. no diagnostics
  /// update will be scheduled and a draft for \p File will not be updated. If
  /// \p OverridenContents is None, contents of the current draft for \p File
  /// will be used. If \p UsedFS is non-null, it will be overwritten by
  /// vfs::FileSystem used for signature help. This method should only be called
  /// for currently tracked files.
  llvm::Expected<Tagged<SignatureHelp>>
  signatureHelp(const Context &Ctx, PathRef File, Position Pos,
                llvm::Optional<StringRef> OverridenContents = llvm::None,
                IntrusiveRefCntPtr<vfs::FileSystem> *UsedFS = nullptr);

  /// Get definition of symbol at a specified \p Line and \p Column in \p File.
  llvm::Expected<Tagged<std::vector<Location>>>
  findDefinitions(const Context &Ctx, PathRef File, Position Pos);

  /// Helper function that returns a path to the corresponding source file when
  /// given a header file and vice versa.
  llvm::Optional<Path> switchSourceHeader(PathRef Path);

  /// Get document highlights for a given position.
  llvm::Expected<Tagged<std::vector<DocumentHighlight>>>
  findDocumentHighlights(const Context &Ctx, PathRef File, Position Pos);

  /// Run formatting for \p Rng inside \p File with content \p Code.
  llvm::Expected<tooling::Replacements> formatRange(StringRef Code,
                                                    PathRef File, Range Rng);

  /// Run formatting for the whole \p File with content \p Code.
  llvm::Expected<tooling::Replacements> formatFile(StringRef Code,
                                                   PathRef File);

  /// Run formatting after a character was typed at \p Pos in \p File with
  /// content \p Code.
  llvm::Expected<tooling::Replacements>
  formatOnType(StringRef Code, PathRef File, Position Pos);

  /// Rename all occurrences of the symbol at the \p Pos in \p File to
  /// \p NewName.
  Expected<std::vector<tooling::Replacement>> rename(const Context &Ctx,
                                                     PathRef File, Position Pos,
                                                     llvm::StringRef NewName);

  /// Gets current document contents for \p File. \p File must point to a
  /// currently tracked file.
  /// FIXME(ibiryukov): This function is here to allow offset-to-Position
  /// conversions in outside code, maybe there's a way to get rid of it.
  std::string getDocument(PathRef File);

  /// Only for testing purposes.
  /// Waits until all requests to worker thread are finished and dumps AST for
  /// \p File. \p File must be in the list of added documents.
  std::string dumpAST(PathRef File);
  /// Called when an event occurs for a watched file in the workspace.
  void onFileEvent(const DidChangeWatchedFilesParams &Params);

private:
  /// FIXME: This stats several files to find a .clang-format file. I/O can be
  /// slow. Think of a way to cache this.
  llvm::Expected<tooling::Replacements>
  formatCode(llvm::StringRef Code, PathRef File,
             ArrayRef<tooling::Range> Ranges);

  std::future<Context>
  scheduleReparseAndDiags(Context Ctx, PathRef File, VersionedDraft Contents,
                          std::shared_ptr<CppFile> Resources,
                          Tagged<IntrusiveRefCntPtr<vfs::FileSystem>> TaggedFS);

  std::future<Context>
  scheduleCancelRebuild(Context Ctx, std::shared_ptr<CppFile> Resources);

  GlobalCompilationDatabase &CDB;
  DiagnosticsConsumer &DiagConsumer;
  FileSystemProvider &FSProvider;
  DraftStore DraftMgr;
  /// If set, this manages index for symbols in opened files.
  std::unique_ptr<FileIndex> FileIdx;
  CppFileCollection Units;
  std::string ResourceDir;
  // If set, this represents the workspace path.
  llvm::Optional<std::string> RootPath;
  std::shared_ptr<PCHContainerOperations> PCHs;
  bool StorePreamblesInMemory;
  /// Used to serialize diagnostic callbacks.
  /// FIXME(ibiryukov): get rid of an extra map and put all version counters
  /// into CppFile.
  std::mutex DiagnosticsMutex;
  /// Maps from a filename to the latest version of reported diagnostics.
  llvm::StringMap<DocVersion> ReportedDiagnosticVersions;
  // WorkScheduler has to be the last member, because its destructor has to be
  // called before all other members to stop the worker thread that references
  // ClangdServer
  ClangdScheduler WorkScheduler;
};

} // namespace clangd
} // namespace clang

#endif
