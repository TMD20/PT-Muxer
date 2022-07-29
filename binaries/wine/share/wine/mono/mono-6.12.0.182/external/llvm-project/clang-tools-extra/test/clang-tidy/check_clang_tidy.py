#!/usr/bin/env python
#
#===- check_clang_tidy.py - ClangTidy Test Helper ------------*- python -*--===#
#
#                     The LLVM Compiler Infrastructure
#
# This file is distributed under the University of Illinois Open Source
# License. See LICENSE.TXT for details.
#
#===------------------------------------------------------------------------===#

r"""
ClangTidy Test Helper
=====================

This script runs clang-tidy in fix mode and verify fixes, messages or both.

Usage:
  check_clang_tidy.py [-resource-dir <resource-dir>] \
    [-assume-filename <file-with-source-extension>] \
    <source-file> <check-name> <temp-file> \
    -- [optional clang-tidy arguments]

Example:
  // RUN: %check_clang_tidy %s llvm-include-order %t -- -- -isystem %S/Inputs
"""

import argparse
import os
import re
import subprocess
import sys


def write_file(file_name, text):
  with open(file_name, 'w') as f:
    f.write(text)
    f.truncate()

def main():
  parser = argparse.ArgumentParser()
  parser.add_argument('-resource-dir')
  parser.add_argument('-assume-filename')
  parser.add_argument('input_file_name')
  parser.add_argument('check_name')
  parser.add_argument('temp_file_name')

  args, extra_args = parser.parse_known_args()

  resource_dir = args.resource_dir
  assume_file_name = args.assume_filename
  input_file_name = args.input_file_name
  check_name = args.check_name
  temp_file_name = args.temp_file_name

  file_name_with_extension = assume_file_name or input_file_name
  _, extension = os.path.splitext(file_name_with_extension)
  if extension not in ['.c', '.hpp', '.m', '.mm']:
    extension = '.cpp'
  temp_file_name = temp_file_name + extension

  clang_tidy_extra_args = extra_args
  if len(clang_tidy_extra_args) == 0:
    clang_tidy_extra_args = ['--']
    if extension in ['.cpp', '.hpp', '.mm']:
      clang_tidy_extra_args.append('--std=c++11')
    if extension in ['.m', '.mm']:
      clang_tidy_extra_args.extend(
          ['-fobjc-abi-version=2', '-fobjc-arc'])

  # Tests should not rely on STL being available, and instead provide mock
  # implementations of relevant APIs.
  clang_tidy_extra_args.append('-nostdinc++')

  if resource_dir is not None:
    clang_tidy_extra_args.append('-resource-dir=%s' % resource_dir)

  with open(input_file_name, 'r') as input_file:
    input_text = input_file.read()

  has_check_fixes = input_text.find('CHECK-FIXES') >= 0
  has_check_messages = input_text.find('CHECK-MESSAGES') >= 0

  if not has_check_fixes and not has_check_messages:
    sys.exit('Neither CHECK-FIXES nor CHECK-MESSAGES found in the input')

  # Remove the contents of the CHECK lines to avoid CHECKs matching on
  # themselves.  We need to keep the comments to preserve line numbers while
  # avoiding empty lines which could potentially trigger formatting-related
  # checks.
  cleaned_test = re.sub('// *CHECK-[A-Z-]*:[^\r\n]*', '//', input_text)

  write_file(temp_file_name, cleaned_test)

  original_file_name = temp_file_name + ".orig"
  write_file(original_file_name, cleaned_test)

  args = ['clang-tidy', temp_file_name, '-fix', '--checks=-*,' + check_name] + \
        clang_tidy_extra_args
  print('Running ' + repr(args) + '...')
  try:
    clang_tidy_output = \
        subprocess.check_output(args, stderr=subprocess.STDOUT).decode()
  except subprocess.CalledProcessError as e:
    print('clang-tidy failed:\n' + e.output.decode())
    raise

  print('------------------------ clang-tidy output -----------------------\n' +
        clang_tidy_output +
        '\n------------------------------------------------------------------')

  try:
    diff_output = subprocess.check_output(
        ['diff', '-u', original_file_name, temp_file_name],
        stderr=subprocess.STDOUT)
  except subprocess.CalledProcessError as e:
    diff_output = e.output

  print('------------------------------ Fixes -----------------------------\n' +
        diff_output.decode() +
        '\n------------------------------------------------------------------')

  if has_check_fixes:
    try:
      subprocess.check_output(
          ['FileCheck', '-input-file=' + temp_file_name, input_file_name,
           '-check-prefix=CHECK-FIXES', '-strict-whitespace'],
          stderr=subprocess.STDOUT)
    except subprocess.CalledProcessError as e:
      print('FileCheck failed:\n' + e.output.decode())
      raise

  if has_check_messages:
    messages_file = temp_file_name + '.msg'
    write_file(messages_file, clang_tidy_output)
    try:
      subprocess.check_output(
          ['FileCheck', '-input-file=' + messages_file, input_file_name,
           '-check-prefix=CHECK-MESSAGES',
           '-implicit-check-not={{warning|error}}:'],
          stderr=subprocess.STDOUT)
    except subprocess.CalledProcessError as e:
      print('FileCheck failed:\n' + e.output.decode())
      raise

if __name__ == '__main__':
  main()
