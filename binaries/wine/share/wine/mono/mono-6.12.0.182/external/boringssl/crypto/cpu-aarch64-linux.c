/* Copyright (c) 2016, Google Inc.
 *
 * Permission to use, copy, modify, and/or distribute this software for any
 * purpose with or without fee is hereby granted, provided that the above
 * copyright notice and this permission notice appear in all copies.
 *
 * THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
 * WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
 * MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY
 * SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
 * WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN ACTION
 * OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF OR IN
 * CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE. */

#include <openssl/cpu.h>

#if defined(OPENSSL_AARCH64) && !defined(OPENSSL_STATIC_ARMCAP)

#include <sys/auxv.h>

#include <openssl/arm_arch.h>

#include "internal.h"


extern uint32_t OPENSSL_armcap_P;

#if defined(__FreeBSD__)

#include <stdlib.h>
#include <sys/types.h>
#include <machine/armreg.h>

// Support for older version of armreg.h
#ifndef ID_AA64ISAR0_AES_VAL
#define ID_AA64ISAR0_AES_VAL ID_AA64ISAR0_AES
#endif
#ifndef ID_AA64ISAR0_SHA1_VAL
#define ID_AA64ISAR0_SHA1_VAL ID_AA64ISAR0_SHA1
#endif
#ifndef ID_AA64ISAR0_SHA2_VAL
#define ID_AA64ISAR0_SHA2_VAL ID_AA64ISAR0_SHA2
#endif

void OPENSSL_cpuid_setup(void) {
  if (getenv("QEMU_EMULATING") != NULL) {
    return;
  }

  uint64_t isar0_val = READ_SPECIALREG(id_aa64isar0_el1);

  OPENSSL_armcap_P |= ARMV7_NEON;

  if (ID_AA64ISAR0_AES_VAL(isar0_val) >= ID_AA64ISAR0_AES_BASE) {
    OPENSSL_armcap_P |= ARMV8_PMULL;
  }
  if (ID_AA64ISAR0_AES_VAL(isar0_val) >= ID_AA64ISAR0_AES_PMULL) {
    OPENSSL_armcap_P |= ARMV8_PMULL;
  }
  if (ID_AA64ISAR0_SHA1_VAL(isar0_val) >= ID_AA64ISAR0_SHA1_BASE) {
    OPENSSL_armcap_P |= ARMV8_SHA1;
  }
  if (ID_AA64ISAR0_SHA2_VAL(isar0_val) >= ID_AA64ISAR0_SHA2_BASE) {
    OPENSSL_armcap_P |= ARMV8_SHA256;
  }
}

#else // linux

void OPENSSL_cpuid_setup(void) {
  unsigned long hwcap = getauxval(AT_HWCAP);

  /* See /usr/include/asm/hwcap.h on an aarch64 installation for the source of
   * these values. */
  static const unsigned long kNEON = 1 << 1;
  static const unsigned long kAES = 1 << 3;
  static const unsigned long kPMULL = 1 << 4;
  static const unsigned long kSHA1 = 1 << 5;
  static const unsigned long kSHA256 = 1 << 6;

  if ((hwcap & kNEON) == 0) {
    /* Matching OpenSSL, if NEON is missing, don't report other features
     * either. */
    return;
  }

  OPENSSL_armcap_P |= ARMV7_NEON;

  if (hwcap & kAES) {
    OPENSSL_armcap_P |= ARMV8_AES;
  }
  if (hwcap & kPMULL) {
    OPENSSL_armcap_P |= ARMV8_PMULL;
  }
  if (hwcap & kSHA1) {
    OPENSSL_armcap_P |= ARMV8_SHA1;
  }
  if (hwcap & kSHA256) {
    OPENSSL_armcap_P |= ARMV8_SHA256;
  }
}

#endif

#endif /* OPENSSL_AARCH64 && !OPENSSL_STATIC_ARMCAP */
