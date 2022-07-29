# Install script for directory: /usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/external/boringssl/crypto

# Set the install prefix
if(NOT DEFINED CMAKE_INSTALL_PREFIX)
  set(CMAKE_INSTALL_PREFIX "/usr/local/bin/mine/remux/binaries/wine/mono")
endif()
string(REGEX REPLACE "/$" "" CMAKE_INSTALL_PREFIX "${CMAKE_INSTALL_PREFIX}")

# Set the install configuration name.
if(NOT DEFINED CMAKE_INSTALL_CONFIG_NAME)
  if(BUILD_TYPE)
    string(REGEX REPLACE "^[^A-Za-z0-9_]+" ""
           CMAKE_INSTALL_CONFIG_NAME "${BUILD_TYPE}")
  else()
    set(CMAKE_INSTALL_CONFIG_NAME "")
  endif()
  message(STATUS "Install configuration: \"${CMAKE_INSTALL_CONFIG_NAME}\"")
endif()

# Set the component getting installed.
if(NOT CMAKE_INSTALL_COMPONENT)
  if(COMPONENT)
    message(STATUS "Install component: \"${COMPONENT}\"")
    set(CMAKE_INSTALL_COMPONENT "${COMPONENT}")
  else()
    set(CMAKE_INSTALL_COMPONENT)
  endif()
endif()

# Install shared libraries without execute permission?
if(NOT DEFINED CMAKE_INSTALL_SO_NO_EXE)
  set(CMAKE_INSTALL_SO_NO_EXE "1")
endif()

# Is this installation the result of a crosscompile?
if(NOT DEFINED CMAKE_CROSSCOMPILING)
  set(CMAKE_CROSSCOMPILING "FALSE")
endif()

if(NOT CMAKE_INSTALL_LOCAL_ONLY)
  # Include the install script for each subdirectory.
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/stack/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/lhash/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/err/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/buf/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/base64/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/bytestring/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/sha/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/md4/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/md5/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/modes/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/aes/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/des/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/rc4/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/conf/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/chacha/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/poly1305/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/curve25519/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/newhope/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/digest/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/cipher/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/rand/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/bio/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/bn/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/obj/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/asn1/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/engine/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/dh/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/dsa/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/rsa/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/ec/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/ecdh/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/ecdsa/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/hmac/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/cmac/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/evp/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/hkdf/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/pem/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/x509/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/x509v3/cmake_install.cmake")
  include("/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182/mono/btls/build-shared/boringssl/crypto/pkcs8/cmake_install.cmake")

endif()

