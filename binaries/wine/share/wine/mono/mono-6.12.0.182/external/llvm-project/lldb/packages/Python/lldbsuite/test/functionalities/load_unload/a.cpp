//===-- a.c -----------------------------------------------------*- C++ -*-===//
//
//                     The LLVM Compiler Infrastructure
//
// This file is distributed under the University of Illinois Open Source
// License. See LICENSE.TXT for details.
//
//===----------------------------------------------------------------------===//
extern int b_function ();

int a_init()
{
    return 234;
}

int a_global = a_init();

extern "C" int
a_function ()
{
    return b_function ();
}
