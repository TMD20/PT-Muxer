include_directories(../../include)
option(ENABLE_NDK_ARM_WORKAROUND  "Enable workaround for clang compiler in NDK r18+ failing to compile aes-armv4.S" OFF)

if (${ARCH} STREQUAL "x86_64")
  set(
    AES_ARCH_SOURCES

    aes-x86_64.${ASM_EXT}
    aesni-x86_64.${ASM_EXT}
    bsaes-x86_64.${ASM_EXT}
    vpaes-x86_64.${ASM_EXT}
  )
endif()

if (${ARCH} STREQUAL "x86")
  set(
    AES_ARCH_SOURCES

    aes-586.${ASM_EXT}
    vpaes-x86.${ASM_EXT}
    aesni-x86.${ASM_EXT}
  )
endif()

if (${ARCH} STREQUAL "arm")
  set(
    AES_ARCH_SOURCES

    aes-armv4.${ASM_EXT}
    bsaes-armv7.${ASM_EXT}
    aesv8-armx.${ASM_EXT}
  )
if (ENABLE_NDK_ARM_WORKAROUND)
    #
    # This isn't really *for* Apple, it's for clang in general, but somebody sometime
    # ago chose to use __APPLE__ because back then clang was used by default only on
    # macOS. Android NDK r18 and newer dropped gcc and uses only clang, thus the need
    # to work around the build issue if the symbol is not defined:
    #
    #  [...]sdks/builds/android-armeabi-v7a-debug/mono/btls/build-shared/boringssl/crypto/aes/aes-armv4.S:363:2: error: out of range immediate fixup value
    #       sub r10,r3,#asm_AES_encrypt-AES_Te @ Te
    #       ^
    #  [...]sdks/builds/android-armeabi-v7a-debug/mono/btls/build-shared/boringssl/crypto/aes/aes-armv4.S:1010:2: error: out of range immediate fixup value
    #       sub r10,r3,#asm_AES_decrypt-AES_Td @ Td
    #       ^
    #
    add_definitions(-D__APPLE__)
  endif()
endif()

if (${ARCH} STREQUAL "aarch64")
  set(
    AES_ARCH_SOURCES

    aesv8-armx.${ASM_EXT}
  )
endif()

add_library(
  aes

  OBJECT

  aes.c
  mode_wrappers.c

  ${AES_ARCH_SOURCES}
)

perlasm(aes-x86_64.${ASM_EXT} asm/aes-x86_64.pl)
perlasm(aesni-x86_64.${ASM_EXT} asm/aesni-x86_64.pl)
perlasm(bsaes-x86_64.${ASM_EXT} asm/bsaes-x86_64.pl)
perlasm(vpaes-x86_64.${ASM_EXT} asm/vpaes-x86_64.pl)
perlasm(aes-586.${ASM_EXT} asm/aes-586.pl)
perlasm(vpaes-x86.${ASM_EXT} asm/vpaes-x86.pl)
perlasm(aesni-x86.${ASM_EXT} asm/aesni-x86.pl)
perlasm(aes-armv4.${ASM_EXT} asm/aes-armv4.pl)
perlasm(bsaes-armv7.${ASM_EXT} asm/bsaes-armv7.pl)
perlasm(aesv8-armx.${ASM_EXT} asm/aesv8-armx.pl)

if(ENABLE_TESTS)
add_executable(
  aes_test

  aes_test.cc
  $<TARGET_OBJECTS:test_support>
)

target_link_libraries(aes_test crypto)
add_dependencies(all_tests aes_test)
endif()
