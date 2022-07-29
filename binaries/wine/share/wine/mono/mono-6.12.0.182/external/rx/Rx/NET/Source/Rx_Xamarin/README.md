This directory contains unit test solutions for Rx on iOS and Android.

For iOS, it makes use of built-in Touch.Unit, so you can build the projects
immediately.
For Android, however, there are couple of dependencies that you need to
checkout: MonoDroid.Dialog and Andr.Unit. Andr.Unit also needs to replace
the default test target assembly with the actual tests assembly for Rx
in this solution. I put an easy Makefile to do these supplemental setup
tasks for those who can run it.

The assemblies are pre-built from mono repository so far. (In mono, those
Rx assemblies are built using make, so do those mobile ones.)
I hope to create project files so that anyone can easily hack Rx and
contribute to Microsoft team later.

