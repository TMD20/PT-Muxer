//===-- CBackend.cpp - Library for converting LLVM code to C -----------------------===//
//
//                     The LLVM Compiler Infrastructure
//
// This file is distributed under the University of Illinois Open Source
// License. See LICENSE.TXT for details.
//
//===-------------------------------------------------------------------------------===//
//
// This code tests to see that the CBE can handle declaring and returning a unsigned short int.
// *TW
//===-------------------------------------------------------------------------------===//

int main(){

    unsigned short int a = 6;

    int ia = 0;
    ia = (int)a;

    return ia;
}

