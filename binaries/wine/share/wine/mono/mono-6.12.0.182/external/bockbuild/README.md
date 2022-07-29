Note: This is the actively maintained version of Bockbuild, used to put together the Mono SDK package for macOS. The legacy versions (used for Banshee and older Mono versions) are available here: https://github.com/mono/bockbuild/tree/legacy

Please file issues with the Mono SDK package for macOS on the [Mono GitHub issues](https://github.com/mono/mono/issues) page.

The Mono macOS SDK
------------------

Bockbuild is already provided as a submodule of Mono. To build a functional distribution in Bockbuild's 'stage' directory, begin from a Mono checkout:

    $ git clone git@github.com:mono/mono
    $ cd mono
    $ ./scripts/mac-sdk-package.sh

To get a shell that uses your custom-built distribution (e.g. for testing, to build & run Monodevelop against it):

    $ ./external/bockbuild/bb MacSDK --shell
    
Finally, to create a package of the distribution that installs on the "system Mono" path (/Library/Frameworks/Mono.framework/Versions/...)

    $ ./external/bockbuild/bb MacSDK --package

Xamarin Releases
----------------

Release packages are built with the following:

    $ ./external/bockbuild/bb MacSDKRelease --package
