=====================================
Extra Clang Tools 6.0.0 Release Notes
=====================================

.. contents::
   :local:
   :depth: 3

Written by the `LLVM Team <http://llvm.org/>`_

Introduction
============

This document contains the release notes for the Extra Clang Tools, part of the
Clang release 6.0.0. Here we describe the status of the Extra Clang Tools in
some detail, including major improvements from the previous release and new
feature work. All LLVM releases may be downloaded from the `LLVM releases web
site <http://llvm.org/releases/>`_.

For more information about Clang or LLVM, including information about
the latest release, please see the `Clang Web Site <http://clang.llvm.org>`_ or
the `LLVM Web Site <http://llvm.org>`_.

What's New in Extra Clang Tools 6.0.0?
======================================

Some of the major new features and improvements to Extra Clang Tools are listed
here. Generic improvements to Extra Clang Tools as a whole or to its underlying
infrastructure are described first, followed by tool-specific sections.

Improvements to clang-tidy
--------------------------

- New module `fuchsia` for Fuchsia style checks.

- New module `objc` for Objective-C style checks.

- New `android-cloexec-accept
  <clang-tidy/checks/android-cloexec-accept.html>`_ check

  Detects usage of ``accept()``.

- New `android-cloexec-accept4
  <clang-tidy/checks/android-cloexec-accept4.html>`_ check

  Checks if the required file flag ``SOCK_CLOEXEC`` is present in the argument of
  ``accept4()``.

- New `android-cloexec-dup
  <clang-tidy/checks/android-cloexec-dup.html>`_ check

  Detects usage of ``dup()``.

- New `android-cloexec-epoll-create
  <clang-tidy/checks/android-cloexec-epoll-create.html>`_ check

  Detects usage of ``epoll_create()``.

- New `android-cloexec-epoll-create1
  <clang-tidy/checks/android-cloexec-epoll-create1.html>`_ check

  Checks if the required file flag ``EPOLL_CLOEXEC`` is present in the argument of
  ``epoll_create1()``.

- New `android-cloexec-inotify-init
  <clang-tidy/checks/android-cloexec-inotify-init.html>`_ check

  Detects usage of ``inotify_init()``.

- New `android-cloexec-inotify-init1
  <clang-tidy/checks/android-cloexec-inotify-init1.html>`_ check

  Checks if the required file flag ``IN_CLOEXEC`` is present in the argument of
  ``inotify_init1()``.

- New `android-cloexec-memfd_create
  <clang-tidy/checks/android-cloexec-memfd-create.html>`_ check

  Checks if the required file flag ``MFD_CLOEXEC`` is present in the argument
  of ``memfd_create()``.

- New `bugprone-copy-constructor-init
  <clang-tidy/checks/bugprone-copy-constructor-init.html>`_ check

  Finds copy constructors which don't call the copy constructor of the base class.

- New `bugprone-integer-division
  <clang-tidy/checks/bugprone-integer-division.html>`_ check

  Finds cases where integer division in a floating point context is likely to
  cause unintended loss of precision.

- New `bugprone-misplaced-operator-in-strlen-in-alloc
  <clang-tidy/checks/bugprone-misplaced-operator-in-strlen-in-alloc.html>`_ check

  Finds cases where ``1`` is added to the string in the argument to
  ``strlen()``, ``strnlen()``, ``strnlen_s()``, ``wcslen()``, ``wcsnlen()``, and
  ``wcsnlen_s()`` instead of the result and the value is used as an argument to
  a memory allocation function (``malloc()``, ``calloc()``, ``realloc()``,
  ``alloca()``) or the ``new[]`` operator in `C++`.

- New `cppcoreguidelines-owning-memory <clang-tidy/checks/cppcoreguidelines-owning-memory.html>`_ check

  This check implements the type-based semantic of ``gsl::owner<T*>``, but without
  flow analysis.

- New `fuchsia-default-arguments
  <clang-tidy/checks/fuchsia-default-arguments.html>`_ check

  Warns if a function or method is declared or called with default arguments.

- New `fuchsia-overloaded-operator
  <clang-tidy/checks/fuchsia-overloaded-operator.html>`_ check

  Warns if an operator is overloaded, except for the assignment (copy and move) operators.

- New `fuchsia-virtual-inheritance
  <clang-tidy/checks/fuchsia-virtual-inheritance.html>`_ check

  Warns if classes are defined with virtual inheritance.

- New `google-objc-avoid-throwing-exception
  <clang-tidy/checks/google-objc-avoid-throwing-exception.html>`_ check

  Finds uses of throwing exceptions usages in Objective-C files.

- New `google-objc-global-variable-declaration
  <clang-tidy/checks/google-objc-global-variable-declaration.html>`_ check

  Finds global variable declarations in Objective-C files that do not follow the
  pattern of variable names in Google's Objective-C Style Guide.

- New `hicpp-exception-baseclass
  <clang-tidy/checks/hicpp-exception-baseclass.html>`_ check

  Ensures that all exception will be instances of ``std::exception`` and classes
  that are derived from it.

- New `hicpp-signed-bitwise
  <clang-tidy/checks/hicpp-signed-bitwise.html>`_ check

  Finds uses of bitwise operations on signed integer types, which may lead to
  undefined or implementation defined behaviour.

- New `objc-avoid-nserror-init
  <clang-tidy/checks/objc-avoid-nserror-init.html>`_ check

  Finds improper initialization of ``NSError`` objects.

- New `objc-avoid-spinlock
  <clang-tidy/checks/objc-avoid-spinlock.html>`_ check

  Finds usages of ``OSSpinlock``, which is deprecated due to potential livelock
  problems.

- New `objc-forbidden-subclassing
  <clang-tidy/checks/objc-forbidden-subclassing.html>`_ check

  Finds Objective-C classes which are subclasses of classes which are not
  designed to be subclassed.

- New `objc-property-declaration
  <clang-tidy/checks/objc-property-declaration.html>`_ check

  Finds property declarations in Objective-C files that do not follow the
  pattern of property names in Apple's programming guide.

- New `readability-static-accessed-through-instance
  <clang-tidy/checks/readability-static-accessed-through-instance.html>`_ check

  Finds member expressions that access static members through instances and
  replaces them with uses of the appropriate qualified-id.

- The 'misc-argument-comment' check was renamed to `bugprone-argument-comment
  <clang-tidy/checks/bugprone-argument-comment.html>`_

- The 'misc-assert-side-effect' check was renamed to `bugprone-assert-side-effect
  <clang-tidy/checks/bugprone-assert-side-effect.html>`_

- The 'misc-bool-pointer-implicit-conversion' check was renamed to `bugprone-bool-pointer-implicit-conversion
  <clang-tidy/checks/bugprone-bool-pointer-implicit-conversion.html>`_

- The 'misc-dangling-handle' check was renamed to `bugprone-dangling-handle
  <clang-tidy/checks/bugprone-dangling-handle.html>`_

- The 'misc-fold-init-type' check was renamed to `bugprone-fold-init-type
  <clang-tidy/checks/bugprone-fold-init-type.html>`_

- The 'misc-forward-declaration-namespace' check was renamed to `bugprone-forward-declaration-namespace
  <clang-tidy/checks/bugprone-forward-declaration-namespace.html>`_

- The 'misc-inaccurate-erase' check was renamed to `bugprone-inaccurate-erase
  <clang-tidy/checks/bugprone-inaccurate-erase.html>`_

- The 'misc-inefficient-algorithm' check was renamed to `performance-inefficient-algorithm
  <clang-tidy/checks/performance-inefficient-algorithm.html>`_

- The 'misc-move-const-arg' check was renamed to `performance-move-const-arg
  <clang-tidy/checks/performance-move-const-arg.html>`_

- The 'misc-move-constructor-init' check was renamed to `performance-move-constructor-init
  <clang-tidy/checks/performance-move-constructor-init.html>`_

- The 'misc-move-forwarding-reference' check was renamed to `bugprone-move-forwarding-reference
  <clang-tidy/checks/bugprone-move-forwarding-reference.html>`_

- The 'misc-multiple-statement-macro' check was renamed to `bugprone-multiple-statement-macro
  <clang-tidy/checks/bugprone-multiple-statement-macro.html>`_

- The 'misc-noexcept-move-constructor' check was renamed to `performance-noexcept-move-constructor
  <clang-tidy/checks/performance-noexcept-move-constructor.html>`_

- The 'misc-string-constructor' check was renamed to `bugprone-string-constructor
  <clang-tidy/checks/bugprone-string-constructor.html>`_

- The 'misc-use-after-move' check was renamed to `bugprone-use-after-move
  <clang-tidy/checks/bugprone-use-after-move.html>`_

- The 'performance-implicit-cast-in-loop' check was renamed to `performance-implicit-conversion-in-loop
  <clang-tidy/checks/performance-implicit-conversion-in-loop.html>`_

- The 'readability-implicit-bool-cast' check was renamed to `readability-implicit-bool-conversion
  <clang-tidy/checks/readability-implicit-bool-conversion.html>`_

    The check's options were renamed as follows:

    - `AllowConditionalIntegerCasts` -> `AllowIntegerConditions`,
    - `AllowConditionalPointerCasts` -> `AllowPointerConditions`.

- Added `modernize-use-emplace.IgnoreImplicitConstructors
  <clang-tidy/checks/modernize-use-emplace.html#cmdoption-arg-IgnoreImplicitConstructors>`_
  option.

- Added aliases for the `High Integrity C++ Coding Standard <http://www.codingstandard.com/section/index/>`_
  to already implemented checks in other modules.

  - `hicpp-deprecated-headers <clang-tidy/checks/hicpp-deprecated-headers.html>`_
  - `hicpp-move-const-arg <clang-tidy/checks/hicpp-move-const-arg.html>`_
  - `hicpp-no-array-decay <clang-tidy/checks/hicpp-no-array-decay.html>`_
  - `hicpp-no-malloc <clang-tidy/checks/hicpp-no-malloc.html>`_
  - `hicpp-static-assert <clang-tidy/checks/hicpp-static-assert.html>`_
  - `hicpp-use-auto <clang-tidy/checks/hicpp-use-auto.html>`_
  - `hicpp-use-emplace <clang-tidy/checks/hicpp-use-emplace.html>`_
  - `hicpp-use-noexcept <clang-tidy/checks/hicpp-use-noexcept.html>`_
  - `hicpp-use-nullptr <clang-tidy/checks/hicpp-use-nullptr.html>`_
  - `hicpp-vararg <clang-tidy/checks/hicpp-vararg.html>`_

- Added the ability to suppress specific checks (or all checks) in a ``NOLINT`` or ``NOLINTNEXTLINE`` comment.

- Added new functionality to `misc-redundant-expression
  <clang-tidy/checks/misc-redundant-expression.html>`_ check

  Finds redundant binary operator expressions where the operators are overloaded,
  and ones that contain the same macros twice.
  Also checks for assignment expressions that do not change the value of the
  assigned variable, and expressions that always evaluate to the same value
  because of possible operator confusion.
