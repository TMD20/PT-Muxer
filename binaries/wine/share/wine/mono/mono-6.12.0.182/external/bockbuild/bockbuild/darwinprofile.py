import os
import shutil
from plistlib import Plist
from util.util import *
from unixprofile import UnixProfile
from profile import Profile
import stat
from distutils.version import LooseVersion, StrictVersion

# staging helper functions


def match_stageable_text(path, filetype):
    if os.path.islink(path) or os.path.isdir(path):
        return False
    return path.endswith('.pc') or 'libtool library file' in filetype or 'text executable' in filetype


def match_text(path, filetype):
    if os.path.islink(path) or os.path.isdir(path):
        return False
    return match_stageable_text(path, filetype) or 'text' in filetype


def match_stageable_binary(path, filetype):
    if os.path.islink(path) or os.path.isdir(path):
        return False
    return 'Mach-O' in filetype and not path.endswith('.a') and not 'dSYM' in path


def match_all(path, filetype):
    return True


def match_real_files(path, filetype):
    return (not os.path.islink(path) and not os.path.isdir(path))


class DarwinProfile (UnixProfile):

    # package order is very important.
    # autoconf and automake don't depend on CC
    # ccache uses a different CC since it's not installed yet
    # every thing after ccache needs a working ccache
    default_toolchain = [
        'cmake',
        'autoconf',
        'automake',
        'ccache',
        'libtool',
        'xz',
        'tar',

        # needed to autogen gtk+
        'gtk-osx-docbook',
        'gtk-doc'
    ]

    def use_Xcode(self, min_version='5.1.1', xcodebuild_version_prefix='Xcode '):
        xcrun_cc_str = backtick('xcrun cc --version')[0]
        cc_str = backtick('cc --version')[0]
        if xcrun_cc_str != cc_str:
            error('Multiple "cc" compiler versions found. (XCode-selected: "%s";"cc" at $PATH: "%s"' % (
            xcrun_cc_str, cc_str))
        xcodebuild_str = backtick('xcodebuild -version')[0]  # output: "Xcode X.X.X"
        if not xcodebuild_str.startswith(xcodebuild_version_prefix):
            error('Unexpected output from "xcodebuild" (first line: "%s"' % (xcodebuild_str))
        xcode_version = StrictVersion(xcodebuild_str[len(xcodebuild_version_prefix):])
        if xcode_version < StrictVersion(min_version):
            error('Xcode version required %s, installed %s' % (min_version, xcode_version))

        self.env.set('xcode_version', str(xcode_version))
        return xcode_version

    def attach (self, bockbuild):
        UnixProfile.attach (self, bockbuild)
        bockbuild.toolchain = list (DarwinProfile.default_toolchain)
        self.name = 'darwin'
        self.debug_info = []

        xcode_version = self.use_Xcode ()

        osx_sdk = backtick('xcrun --show-sdk-path')[0]
        if not os.path.exists(osx_sdk):
            error('Mac OS X SDK not found under %s' % osx_sdk)

        info('Using Xcode %s, SDK %s' % (xcode_version, os.path.basename(osx_sdk)))

        # Recent versions of XCode with recent MacOS SDKs buggily resolve several functions as existing on earlier OS X versions
        # even when they are not.
        xcode_blacklisted_functions = []

        # based on https://github.com/Homebrew/brew/blob/241ee989bb6a917cb6000a1aa06aa341c465a1b3/Library/Homebrew/extend/os/mac/extend/ENV/super.rb#L118-L128
        if xcode_version >= '8.0':
            xcode_blacklisted_functions.extend (['basename_r','clock_getres','clock_gettime','clock_settime','dirname_r','getentropy','mkostemp', 'mkostemps', 'timingsafe_bcmp'])

        if xcode_version >= '9.0':
            xcode_blacklisted_functions.extend (['fmemopen', 'futimens', 'open_memstream', 'utimensat'])

        map(lambda t : self.configure_flags.append ('ac_cv_func_%s=no' % t), xcode_blacklisted_functions)

        self.gcc_flags.extend([
            '-D_XOPEN_SOURCE',
            '-isysroot %s' % osx_sdk,
            # needed to ensure install_name_tool can succeed staging binaries
            '-Wl,-headerpad_max_install_names'
        ])

        self.ld_flags.extend([
            # needed to ensure install_name_tool can succeed staging binaries
            '-headerpad_max_install_names'
        ])

    def setup (self):
        if self.min_version:
            self.target_osx = '10.%s' % self.min_version
            self.gcc_flags.extend(
                ['-mmacosx-version-min=%s' % self.target_osx])
            self.env.set('MACOSX_DEPLOYMENT_TARGET', self.target_osx)

        if Profile.bockbuild.cmd_options.debug is True:
            self.gcc_flags.extend(['-O0', '-ggdb3'])

        if os.getenv('BOCKBUILD_USE_CCACHE') is None:
            self.env.set('CC',  'xcrun clang')
            self.env.set('CXX', 'xcrun clang++')
        else:
            self.env.set('CC',  'ccache xcrun clang')
            self.env.set('CXX', 'ccache xcrun clang++')

        if self.bockbuild.cmd_options.arch == 'default':
            self.bockbuild.cmd_options.arch = 'darwin-32'

    def arch_build(self, arch, package):
        if arch == 'darwin-universal':
            package.local_ld_flags = ['-arch i386', '-arch x86_64']
            package.local_gcc_flags = ['-arch i386', '-arch x86_64']
        elif arch == 'darwin-32':
            package.local_ld_flags = ['-arch i386', '-m32']
            package.local_gcc_flags = ['-arch i386', '-m32']
            package.local_configure_flags = [
                '--build=i386-apple-darwin13.0.0', '--host=i386-apple-darwin13.0.0', '--disable-dependency-tracking']
        elif arch == 'darwin-64':
            package.local_ld_flags = ['-arch x86_64 -m64']
            package.local_gcc_flags = ['-arch x86_64 -m64']
            package.local_configure_flags = [
                '--build=x86_64-apple-darwin13.0.0', '--host=x86_64-apple-darwin13.0.0', '--disable-dependency-tracking']
        else:
            error('Unknown arch %s' % arch)

        configure_cache =  '%s/%s-%s.cache' % (self.bockbuild.build_root, package.name, arch)
        package.aux_files.append (configure_cache)

        package.local_configure_flags.extend(
            ['--cache-file=%s' % configure_cache])

        package.local_configure_flags.extend(self.configure_flags)

        if package.name in self.debug_info:
            package.local_gcc_flags.extend(['-g'])

    def process_package(self, package):
        failure_count = 0

        def staging_harness(path, func, failure_count=failure_count):
            def relocate_to_profile(token):
                if token.find(package.staged_prefix) == -1 and token.find(package.staged_profile) == -1:
                    newtoken = token.replace(
                        package.package_prefix, package.staged_profile)
                else:
                    newtoken = token.replace(
                        package.staged_prefix, package.staged_profile)

                if newtoken != token:
                    package.trace('%s:\n\t%s\t->\t%s' %
                                  (os.path.basename(path), token, newtoken))
                return newtoken

            if (path.endswith('.release')):
                error('Staging backup exists in dir we''re trying to stage: %s' % path)

            backup = path + '.release'
            shutil.copy2(path, backup)
            try:
                trace('Staging %s' % path)
                func(path, relocate_to_profile)
                if os.path.exists(path + '.stage'):
                    os.remove(path)
                    shutil.move(path + '.stage', path)
                    shutil.copystat(backup, path)
            except CommandException as e:
                package.rm_if_exists(path)
                shutil.copy2(backup, path)
                package.rm(backup)
                warn('Staging failed for %s' % os.path.basename(path))
                error(str(e))
                failure_count = failure_count + 1
                if failure_count > 10:
                    error('Possible staging issue, >10 staging failures')

        extra_files = [os.path.join(package.staged_prefix, expand_macros(file, package))
                       for file in package.extra_stage_files]

        procs = []
        if package.name in self.debug_info:
            procs.append(self.generate_dsyms())

        procs.append(self.stage_textfiles(harness=staging_harness,
                                          match=match_stageable_text, extra_files=extra_files))
        procs.append(self.stage_binaries(
            harness=staging_harness, match=match_stageable_binary))

        Profile.postprocess(self, procs, package.staged_prefix)

    def process_release(self, directory):
        # validate staged install
        # TODO: move to end of '--build' instead of at the beginning of '--package'
        # unprotect_dir (self.staged_prefix, recursive = True)
        # Profile.postprocess (self, [self.validate_rpaths (match = self.match_stageable_binary),
        # self.validate_symlinks (match = self.match_symlinks)],
        # self.staged_prefix)

        unprotect_dir(directory, recursive=True)

        def destaging_harness(backup, func):
            path = backup[0:-len('.release')]
            trace(path)

            def relocate_for_release(token):
                newtoken = token.replace(self.staged_prefix, self.prefix).replace(directory, self.prefix)

                if newtoken != token:
                    trace('%s:\n\t%s\t->\t%s' %
                          (os.path.basename(path), token, newtoken))

                return newtoken

            try:
                trace('Destaging %s' % path)
                func(path, relocate_for_release)
                if os.path.exists(path + '.stage'):
                    os.remove(path)
                    shutil.move(path + '.stage', path)
                    shutil.copystat(backup, path)
                os.remove(backup)

            except Exception as e:
                warn ('Critical: Destaging failed for ''%s''' % path)
                raise

        def nop_harness(path, func):
            trace('Processing %s' % path)
            func(path, None)

        procs = [self.stage_textfiles(harness=destaging_harness, match=match_text),
                 self.stage_binaries(harness=destaging_harness, match=match_stageable_binary),
                 self.validate_symlinks(harness=nop_harness, match=match_all)]

        Profile.postprocess(self, procs, directory,
                            lambda l: l.endswith('.release'))

    class validate_text_staging (Profile.FileProcessor):
        problem_files = []

        def __init__(self, package):
            self.package = package
            Profile.FileProcessor.__init__(self)

        def process(self, path):
            with open(path) as text:
                stage_name = os.path.basename(self.package.stage_root)
                for line in text:
                    if stage_name in line:
                        warn('String ''%s'' was found in %s' %
                             (stage_name, self.relpath(path)))
                        self.problem_files.append(self.relpath(path))

        def end(self):
            if len(self.problem_files) > 0:
                error('Problematic staging files:\n' +
                      '\n'.join(self.problem_files))

    class validate_symlinks (Profile.FileProcessor):
        problem_links = []

        def process(self, path, fixup_func):
            trace(path)
            if os.path.islink(path) and path.endswith('.release'):
                # get rid of these symlinks
                os.unlink(path)
                return

            target = os.path.realpath(path)
            if not os.path.exists(target) or not target.startswith(self.root):
                self.problem_links.append(
                    '%s -> %s' % (self.relpath(path), target))

        def end(self):
            if len(self.problem_links) > 0:
                # TODO: Turn into error when we handle them
                warn('Broken symlinks:\n' + '\n'.join(self.problem_links))

    class generate_dsyms (Profile.FileProcessor):

        def __init__(self):
            Profile.FileProcessor.__init__(self, match=match_stageable_binary)

        def process(self, path):
            run_shell('dsymutil -t 2 "%s" >/dev/null' % path)
            run_shell('strip -S "%s" > /dev/null' % path)

    class validate_rpaths (Profile.FileProcessor):

        def process(self, path):
            if path.endswith('.release'):
                return
            libs = backtick('otool -L %s' % path)
            for line in libs:
                # parse 'otool -L'
                if not line.startswith('\t'):
                    continue
                rpath = line.strip().split(' ')[0]

                if not os.path.exists(rpath):
                    error('%s contains reference to non-existing file %s' %
                          (self.relpath(path), rpath))
                # if rpath.startswith (self.package.profile.MONO_ROOT):
                # 	error ('%s is linking to external distribution %s' % (path, rpath))

    class stage_textfiles (Profile.FileProcessor):

        def process(self, path, fixup_func):
            with open(path) as text:
                output = open(path + '.stage', 'w')
                for line in text:
                    tokens = line.split(" ")
                    for idx, token in enumerate(tokens):
                        remap = fixup_func(token)
                        tokens[idx] = remap

                    output.write(" ".join(tokens))
                output.close ()

    class stage_binaries (Profile.FileProcessor):

        def process(self, path, fixup_func):
            staged_path = fixup_func(path)


            run_shell('install_name_tool -id %s %s' %
                      (staged_path, path), fatal=False)
            libs = backtick('otool -L %s' % path)
            for line in libs:
                # parse 'otool -L'
                if not line.startswith('\t'):
                    continue
                rpath = line.strip().split(' ')[0]

                remap = fixup_func(rpath)
                if remap != rpath:
                    run_shell('install_name_tool -change %s %s %s' %
                              (rpath, remap, path), fatal=False)
