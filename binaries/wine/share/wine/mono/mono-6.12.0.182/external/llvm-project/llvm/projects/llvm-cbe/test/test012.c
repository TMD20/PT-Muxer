//===-- CBackend.cpp - Library for converting LLVM code to C --------------------===//
//
//                     The LLVM Compiler Infrastructure
//
// This file is distributed under the University of Illinois Open Source
// License. See LICENSE.TXT for details.
//
//===----------------------------------------------------------------------------===//
//
// This code tests to see that the CBE can handle subtraction between two variables.
//  *TW
//===----------------------------------------------------------------------------===//

int main()
{
    int i = 8, t = 2, x = 0;
    x = i-t;

    return x;
}
