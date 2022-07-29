// RUN: %clangxx_xray -g -std=c++11 %s -o %t
// RUN: rm fdr-logging-1thr-* || true
// RUN: XRAY_OPTIONS=XRAY_OPTIONS="verbosity=1 patch_premain=true \
// RUN:   xray_naive_log=false xray_fdr_log=true \
// RUN:   xray_fdr_log_func_duration_threshold_us=0 \
// RUN:   xray_logfile_base=fdr-logging-1thr-" %run %t 2>&1
// RUN: %llvm_xray convert --output-format=yaml --symbolize --instr_map=%t \
// RUN:   "`ls fdr-logging-1thr-* | head -n1`" | FileCheck %s
// RUN: rm fdr-logging-1thr-*
//
// REQUIRES: x86_64-linux

#include "xray/xray_log_interface.h"
#include <cassert>

constexpr auto kBufferSize = 16384;
constexpr auto kBufferMax = 10;

[[clang::xray_always_instrument]] void __attribute__((noinline)) fn() { }

int main(int argc, char *argv[]) {
  using namespace __xray;
  FDRLoggingOptions Opts;

  auto status = __xray_log_init(kBufferSize, kBufferMax, &Opts, sizeof(Opts));
  assert(status == XRayLogInitStatus::XRAY_LOG_INITIALIZED);

  __xray_patch();
  fn();
  __xray_unpatch();
  assert(__xray_log_finalize() == XRAY_LOG_FINALIZED);
  assert(__xray_log_flushLog() == XRAY_LOG_FLUSHED);
  return 0;
}

// CHECK: records:
// CHECK-NEXT: - { type: 0, func-id: [[FID1:[0-9]+]], function: {{.*fn.*}}, cpu: {{.*}}, thread: [[THREAD1:[0-9]+]], kind: function-enter, tsc: {{[0-9]+}} }
// CHECK-NEXT: - { type: 0, func-id: [[FID1:[0-9]+]], function: {{.*fn.*}}, cpu: {{.*}}, thread: [[THREAD1:[0-9]+]], kind: function-exit, tsc: {{[0-9]+}} }
