import hashlib
import os
import sys
import shutil
import tempfile
import filecmp
import datetime
import stat
import time
import urllib
from util.util import *
import functools


class Package:

    def __init__(self, name, version=None, organization=None, configure_flags=None, sources=None, revision=None, git_branch=None, source_dir_name=None, override_properties=None, configure=None):
        Package.last_instance = self

        self.name = name
        self.version = version
        self.organization = organization

        self.configure_flags = []
        self.gcc_flags = list(Package.profile.gcc_flags)
        self.cpp_flags = list(Package.profile.gcc_flags)
        self.ld_flags = list(Package.profile.ld_flags)
        self.aux_files = [] # delete workspace-related files that are residing outside the workspace dir

        self.local_cpp_flags = []
        self.local_gcc_flags = []
        self.local_ld_flags = []
        self.local_configure_flags = []

        self.build_env = ''
        self.desc = None

        self._dirstack = []

        # additional files that need staging (besides binaries and scripts)
        # (use path relative to prefix root e.g. 'etc/something.config')
        self.extra_stage_files = []

        # fat binary parameters. On a 64-bit Darwin profile (m64 = True)
        # each package must decide if it will a) perform a multi-arch (64/32) build
        # b) request two builds that are lipoed at the end or c) request a 32-bit
        # build only or d) request a 64-bit build only.

        self.needs_lipo = False
        self.m32_only = False
        self.m64_only = False
        self.build_dependency = False
        self.dont_clean = False
        self.needs_build = None
        self.deploy_requests = []

        if configure_flags:
            self.configure_flags.extend(configure_flags)

        self.sources = sources
        if self.sources is None \
                and not self.__class__.default_sources is None:
            self.sources = list(self.__class__.default_sources)

        if self.organization is None and self.sources is not None and len(self.sources) > 0:
            self.organization = self.extract_organization(self.sources[0])

        self.source_dir_name = source_dir_name
        if self.source_dir_name is None:
            self.source_dir_name = "%s-%s" % (name, version)

        self.revision = revision

        if configure:
            self.configure = configure
        else:
            self.configure = './configure --prefix="%{package_prefix}"'

        self.make = 'make -j%s' % Package.profile.bockbuild.cpu_count
        self.makeinstall = None

        self.git_branch = git_branch
        self.git = Package.profile.bockbuild.git

        if not override_properties is None:
            for k, v in override_properties.iteritems():
                self.__dict__[k] = v

        self.makeinstall = self.makeinstall or 'make install DESTDIR=%{stage_root}'
        self.fetched = False

    def extract_organization(self, source):
        if (not "git" in source) or ("http" in source):
            return None
        if "git.gnome.org" in source:
            return None
        if "github" in source:
            pattern = r"github.com\W(\w+)\/\S+\.git"
            match = re.search(pattern, source)
            if match:
                return match.group(1)
            else:
                raise Exception(
                    "Cannot determine organization for %s" % source)
        else:
            raise Exception("Cannot determine organization for %s" % source)

    def try_get_version(self, source_dir):
        configure_ac = os.path.join(source_dir, 'configure.ac')
        if os.path.exists(configure_ac):
            with open(configure_ac) as file:
                # AC_INIT (...,[VERSION]...
                pattern = r"AC_INIT\(\S+?\s*,\s*\[(\d\S+?)\]"
                for x in range(40):
                    line = file.readline()
                    match = re.search(pattern, line)
                    if match:
                        return match.group(1)

    def trace(self, message):
        trace(message, skip=1)

    def resolve_version(self, source_dir):
        package_version = expand_macros(self.version, self)
        found_version = self.try_get_version(source_dir) or package_version
        if package_version is None:
            package_version = found_version
            trace('%s: Using found version %s' % (self.name, found_version))
        elif found_version[0] != package_version[0]:  # major version differs
            warn('Version in configure.ac is %s, package declares %s' %
                 (found_version, package_version))
        self.version = package_version

    @retry
    def fetch(self, dest):
        if self.fetched and os.path.lexists(dest):
            return

        scratch = self.profile.bockbuild.scratch
        resources = self.profile.bockbuild.resources
        source_cache_dir = self.profile.bockbuild.source_cache
        self.buildstring = []
        self.is_local = False
        scratch_workspace = os.path.join(scratch, '%s.workspace' % self.name)

        self.rm_if_exists(scratch_workspace)
        if os.path.lexists(dest):
            if os.path.islink(dest):
                delete(dest)
            elif os.path.isdir(dest):
                shutil.move(dest, scratch_workspace)
            else:
                error ('Unexpected workspace found at %s' % dest)


        def checkout(self, source_url, cache_dir, workspace_dir):
            def clean_git_workspace(dir):
                trace('Cleaning git workspace: ' + self.name)
                self.git('reset --hard', dir, hazard = True)
                if config.iterative == False:
                    self.git('clean -xffd', dir, hazard = True)
                else:
                    warn('iterative')

            def clean_local_git_workspace(dir): # avoid resetting and destroying work!
                self.git('clean -xffd', dir)

            def create_cache():
                # since this is a fresh cache, the workspace copy is invalid if
                # it exists
                if os.path.exists(workspace_dir):
                    self.rm(workspace_dir)
                progress('Cloning git repo: %s' % source_url)
                self.git('clone --mirror %s %s' %
                         (source_url, cache_dir), self.profile.bockbuild.root)

            def update_cache():
                trace('Updating cache: ' + cache_dir)
                if self.git_branch is None:
                    self.git('fetch --all --prune', cache_dir)
                else:
                    self.git('fetch origin %s' % self.git_branch, cache_dir)

            def create_workspace():
                self.git('clone --local --shared --recursive %s %s' %
                         (cache_dir, workspace_dir), cache_dir)

            def update_workspace():
                trace('Updating workspace')
                if self.git_branch is None:
                    self.git('fetch --all --prune', workspace_dir)
                else:
                    self.git('fetch origin %s:refs/remotes/origin/%s' %
                             (self.git_branch, self.git_branch), workspace_dir)

            def resolve():
                root = git_rootdir(self, os.path.realpath (workspace_dir))
                if not is_modifiable_repo(root):
                    return clean_local_git_workspace
                current_revision = git_get_revision(self, workspace_dir)
                target_revision = None

                if current_revision == self.revision:
                    return

                if not self.is_local and self.revision is None and self.git_branch is None:
                    warn(
                        'Package does not define revision or branch, defaulting to tip of "master"')
                    self.git_branch = self.git_branch or 'master'

                if self.revision is not None:
                    target_revision = self.revision

                if self.git_branch is not None:
                    self.git('checkout %s' % self.git_branch, workspace_dir)
                    self.git('merge origin/%s --ff-only' %
                             self.git_branch, workspace_dir)

                    if self.revision is None:  # target the tip of the branch
                        target_revision = git_get_revision(self, workspace_dir)

                if target_revision and (current_revision != target_revision):
                    self.git('reset --hard %s' %
                             target_revision, workspace_dir, hazard = True)

                self.git('submodule update --recursive', workspace_dir)

                current_revision = git_get_revision(self, workspace_dir)

                if (self.revision is not None and self.revision != current_revision):
                    error('Workspace error: Revision is %s, package specifies %s' % (
                        current_revision, self.revision))

                self.revision = current_revision

            def define():
                self.resolve_version(workspace_dir)

                str = self.name
                if self.version:
                    str += ' %s' % self.version

                str += ' (%s)' % git_shortid(self, workspace_dir)

                self.desc = str
                self.buildstring = ['%s <%s>' % (str, source_url)]

            if self.is_local:
                self.rm_if_exists(workspace_dir)
                work_committed = False
                if git_is_dirty (self, source_url):
                    if self.profile.bockbuild.cmd_options.release_build:
                        error ('Release builds cannot have uncommitted local changes!')
                    else:
                        info ('The repository is dirty, your changes will be committed.')
                        bockbuild_commit_msg = '"WIP (auto-committed by bockbuild)"'
                        top_commit_msg = git_get_commit_msg (self, source_url)
                        if top_commit_msg == bockbuild_commit_msg:
                            self.git ('commit -a --allow-empty --amend -m', source_url, options = [bockbuild_commit_msg])
                        else:
                            self.git('commit -a --allow-empty -m', source_url, options = [bockbuild_commit_msg])
                        work_committed = True
                self.shadow_copy (source_url, workspace_dir)
                if work_committed:
                    self.git ('reset HEAD~1', source_url)
            else:
                if os.path.exists(cache_dir):
                    update_cache()
                else:
                    create_cache()
                if os.path.exists(workspace_dir):
                    if self.dont_clean == True:  # previous workspace was left dirty, delete
                        clean_git_workspace(workspace_dir)
                    update_workspace()
                else:
                    create_workspace()

            cache = None  # at this point, the cache is not the problem; keep _fetch_sources from deleting it

            resolve()
            define()
            return clean_git_workspace

        def checkout_archive(archive, cache_dest, workspace_dir):
            def create_cache():
                progress('Downloading: %s' % archive)
                curl_bin = which('curl')
                if not curl_bin:
                    error('curl not found in PATH')
                run (curl_bin,['--location','--fail','--output', cache_dest, archive], None)

            def update_cache():
                pass

            def create_workspace(dir):
                filetype = get_filetype(cache_dest).lower()
                if filetype.startswith(('gzip', 'xz', 'zip', 'bzip2')):
                    self.extract_archive(cache_dest, scratch, validate_only=False)
                    expected_path = os.path.join(scratch, self.source_dir_name)
                    if not os.path.exists(expected_path):
                        error('Archive %s was extracted but not found at workspace path %s' % (
                            cache_dest, expected_path))
                    if expected_path != dir:
                        shutil.move(expected_path, dir)
                else: # create the directory and just place the downloaded file inside
                    ensure_dir(scratch_workspace)
                    shutil.copy(cache_dest, scratch_workspace)

            def update_workspace():
                pass

            def clean_archive(dir):
                try:
                    self.rm(dir)
                    create_workspace(dir)
                except Exception as e:
                    self.rm_if_exists(cache_dest)
                    self.rm_if_exists(workspace_dir)
                    raise

            def define():
                self.resolve_version(workspace_dir)
                self.desc = '%s %s' % (self.name, self.version)
                self.buildstring = ['%s <%s> md5: %s)' % (
                    self.desc, archive, md5(cache_dest))]

            if os.path.exists(cache_dest):
                update_cache()
            else:
                create_cache()

            if os.path.exists(workspace_dir):
                update_workspace()
            else:
                create_workspace(workspace_dir)

            define()

            return clean_archive

        def get_download_dest(url,version):
            if version is not None:
                dest_dir = '%s-%s' % (self.name, version)
            else:
                dest_dir = self.name
            try:
                os.makedirs (os.path.join(source_cache_dir, dest_dir))
            except OSError, e:
                if e.errno != os.errno.EEXIST:
                    raise
                pass
            return os.path.join(source_cache_dir, dest_dir, os.path.basename(url))

        def get_git_cache_path():
            if self.organization is None:
                name = self.name
            else:
                name = self.organization + "+" + self.name
            return os.path.join(source_cache_dir, name)

        clean_func = None  # what to run if the workspace needs to be redone

        expand_macros(self.sources, self)

        if not self.sources:
            def clean_nop (dir):
                pass
            self.sources = []
            self.desc = '%s %s' % (self.name, self.version)
            self.buildstring.extend(
                ['%s md5: %s' % (os.path.basename(self._path), md5(self._path))])
            clean_func = clean_nop

        local_sources = []

        try:
            for source in self.sources:
                resolved_source = None
                cache = None
                # if source.startswith ('http://'):
                #	raise Exception ('HTTP downloads are no longer allowed: %s', source)

                if source.startswith(('http://', 'https://', 'ftp://')) and not source.endswith('.git'):
                    cache = get_download_dest(source, self.version)
                    if self.profile.cache_host is not None:
                        cached_source = os.path.join(
                            self.profile.cache_host, os.path.basename(source))
                        try:
                            clean_func = checkout_archive(
                                cached_source, cache, scratch_workspace)
                            source = cached_source
                        except CommandException as e:
                            warn(repr(e))
                            verbose('Trying original source')
                            clean_func = checkout_archive(
                                source, cache, scratch_workspace)
                    else:
                        clean_func = checkout_archive(
                            source, cache, scratch_workspace)

                    resolved_source = scratch_workspace

                elif source.startswith(('git://', 'file://', 'ssh://')) or source.endswith('.git') or (os.path.isdir(source) and git_isrootdir (self, source)):
                    if os.path.isdir(source):
                        self.is_local = True
                        cache = None
                    else:
                        cache = get_git_cache_path()
                    clean_func = checkout(
                        self, source, cache, scratch_workspace)
                    resolved_source = scratch_workspace

                elif os.path.isabs(source) and os.path.isdir(source):
                    trace('copying local dir source %s ' % source)

                    def clean_local_copy(dir):
                        self.rm_if_exists(dir)

                    shutil.copytree(source, scratch_workspace)
                    resolved_source = scratch_workspace
                    self.resolve_version(scratch_workspace)
                    self.desc = '%s %s (local workspace: %s)' % (
                        self.name, self.version, source)
                    self.buildstring = ['local workspace: %s' % (source)]
                    clean_func = clean_local_copy
                else:
                    for path in resources:
                        if os.path.isfile(os.path.join(path, source)):
                            resolved_source = os.path.join(path, source)
                            self.buildstring.extend(
                                ['%s md5: %s' % (source, md5(resolved_source))])

                if resolved_source is None:
                    error('could not resolve source: %s' % source)
                trace('%s resolved to %s' % (source, resolved_source))

                local_sources.append(resolved_source)

        except Exception as e:
            if cache is not None:
                self.rm_if_exists(cache)
            self.rm_if_exists(scratch_workspace)
            raise

        if len(self.sources) != len(local_sources):
            error('Source number mismatch after processing: %s before, %s after ' % (
                self.sources, local_sources))

        if clean_func is None:
            error('workspace cleaning function (clean_func) must be set')

        self.local_sources = local_sources
        self.clean = clean_func

        if not os.path.exists(scratch_workspace):
            os.mkdir(scratch_workspace)

        self.workspace = dest
        shutil.move(scratch_workspace, self.workspace)

        if not os.path.exists(self.workspace):
            error ('Workspace was not created')
        self.fetched = True

    def request_build(self, reason):
        self.needs_build = reason

    def override_build(self, reason):
        self.needs_build = reason

    def start_build(self, arch, dest, stage):
        info(self.desc)
        self.package_prefix = dest
        self.staged_profile = stage
        protect_dir(self.staged_profile, recursive=True)

        workspace = self.workspace
        build_artifact = self.build_artifact

        if config.never_rebuild and os.path.isfile(build_artifact):
            if self.deploy_package(build_artifact, self.staged_profile):
                self.override_build(
                    'never_rebuild option enabled, using artifact')
            else:
                warn('Failed to deploy from artifact %s. Rebuilding' %
                     os.path.basename(build_artifact))

        if self.needs_build:
            verbose(self.buildstring)
            if (arch == 'darwin-universal' and self.needs_lipo):
                workspace_x86 = workspace + '-x86'
                workspace_x64 = workspace + '-x64'

                self.rm_if_exists(workspace_x86)
                self.rm_if_exists(workspace_x64)

                shutil.move(workspace, workspace_x86)
                self.shadow_copy(workspace_x86, workspace_x64)

                self.link(workspace_x86, workspace)
                stagedir_x32 = self.do_build(
                    'darwin-32', os.path.join(self.profile.bockbuild.scratch, self.name + '-x86.install'))

                self.link(workspace_x64, workspace)
                package_stage = self.do_build(
                    'darwin-64', os.path.join(self.profile.bockbuild.scratch, self.name + '-x64.install'))

                delete(workspace)
                shutil.move(workspace_x86, workspace)

                print 'lipo', self.name

                self.lipo_dirs(stagedir_x32, package_stage, 'lib')
                self.copy_side_by_side(
                    stagedir_x32, package_stage, 'bin', '32', '64')
            elif arch == 'toolchain':
                package_stage = self.do_build('darwin-64')
            elif self.m64_only:
                package_stage = self.do_build('darwin-64')
            elif self.m32_only:
                package_stage = self.do_build('darwin-32')
            else:
                package_stage = self.do_build(arch)

            self.make_artifact(package_stage, build_artifact)
        for target in self.deploy_requests:
            self.deploy_package(build_artifact, target)

    def deploy_package(self, artifact, dest):
        trace('Deploying (%s -> %s)' %
                 (os.path.basename(artifact), os.path.basename(dest)))

        unprotect_dir(dest, recursive=True)
        artifact_stage = artifact + '.extracted'

        try:
            assert_exists(artifact)
            self.rm_if_exists(artifact_stage)
            unzip(artifact, artifact_stage)
            assert_exists(artifact_stage)
        except Exception as e:
            self.rm_if_exists(artifact)
            self.rm_if_exists(artifact_stage)
            protect_dir(dest, recursive=True)
            return False

        ensure_dir(artifact_stage)

        # catalogue files
        files = list()
        size = 0

        for path in iterate_dir(artifact_stage, with_links = True, summary=False):
            relpath = os.path.relpath(path, artifact_stage)
            destpath = os.path.join(dest, relpath)
            if os.path.exists(destpath) and not identical_files(path, destpath):
                warn(
                    'Different file exists in package already: ''%s''' % relpath )
            files.append(relpath)
            if not os.path.islink(path):
                size = size + os.path.getsize(path)

        files.sort()
        is_changed(files, artifact + '.files')

        with open(artifact + '.files', 'w') as output:
            output.write('\n'.join(files))

        if len(files) != 0:
            merge_trees(artifact_stage, dest, False)

        self.sh = functools.partial(self.build_sh, cwd=artifact_stage)
        self.deploy()

        self.rm_if_exists(artifact_stage)

        protect_dir(dest, recursive=True)
        verbose ('%d files, %sMB' % (len(files), "{:.2f}".format (size /1024 / 1024 )))

        return True

    def do_build(self, arch, install_dir=None):
        progress('Building (arch: %s)' % arch)
        if install_dir is None:
            install_dir = os.path.join(
                self.profile.bockbuild.scratch, self.name + '.install')

        self.stage_root = install_dir
        self.rm_if_exists(self.stage_root)
        self.staged_prefix = os.path.join(
            self.stage_root, self.package_prefix[1:])

        os.makedirs(self.staged_prefix)

        # protect against relocation bugs often landing files in the wrong path
        protect_dir(self.stage_root)

        try:
            self.arch_build(arch)
            self.build_env = self.expand_build_env()
            self.sh = functools.partial(self.build_sh, cwd=self.workspace)
            self.prep()
            self.build()
            self.install()

            if not os.path.exists(self.staged_prefix):
                error('Result directory %s not found.' % self.staged_prefix)

            self.profile.process_package(self)

            if not self.dont_clean:
                self.clean (dir=self.workspace)
        except (Exception, KeyboardInterrupt) as e:
            self.rm_if_exists(self.stage_root)
            if isinstance(e, CommandException):
                if os.path.exists(self.workspace):
                    for path in self.aux_files:
                        self.rm_if_exists(path)
                    problem_dir = os.path.join(
                        self.profile.bockbuild.execution_root, os.path.basename(self.workspace) + '.problem')

                    # take this chance to clear out older .problems
                    for d in os.listdir(self.profile.bockbuild.execution_root):
                        if d.endswith('.problem'):
                            self.rm(os.path.join(self.profile.bockbuild.execution_root, d))

                    shutil.move(self.workspace, problem_dir)
                    info('Build moved to ./%s\n' % os.path.basename(problem_dir))
                info('Run "source ./%s" first to replicate bockbuild environment.' %
                    os.path.basename(self.profile.bockbuild.env_script))
                error(str(e))
            else:
                self.rm_if_exists(self.workspace)
                raise

        return self.staged_prefix

    def make_artifact(self, stage_dir, build_artifact):
        self.rm_if_exists(build_artifact)
        zip(stage_dir, build_artifact)
        self.rm_if_exists(stage_dir)

    def deploy(self):
        return

    def build_sh(self, command, cwd):
        if isinstance(command, list):
            map(lambda cmd: self.build_sh(cmd, cwd), command)
            return
        if not isinstance(command, str):
            error('command arg must be a string: %s' % repr(command))

        if not os.path.isdir(cwd):
            error('Directory does not exist: %s' % cwd)

        try:
            env_command = '%s %s' % (
                self.build_env, expand_macros(command, self))
        except Exception as e:
            error('MACRO EXPANSION ERROR: ' + str(e))
        if config.verbose is True:
            logprint('\t@\t' + expand_macros(command, self), bcolors.BOLD)

        with open(self.log, 'a') as log:
            log.write('%s\n' % env_command)

        full_command = '%s  >>%s 2>&1' % (env_command, self.log)
        try:
            run_shell(full_command, cwd=cwd)
        except Exception as e:
            with open(self.log, 'r') as log:
                output_text = log.readlines()
                for line in output_text:
                    line = line.replace(config.absolute_root, '@')
                    print line,
            warn('build env: ' + self.build_env)
            raise CommandException('command failed: %s' %
                                   expand_macros(command, self), cwd=cwd)

    def backtick(self, command):
        command = expand_macros(command, self)
        return backtick(command)

    def cwd(self):
        try:
            self._cwd = os.getcwd()
        except Exception as e:
            warn('In invalid directory: %s' % self._cwd)

        return self._cwd

    def cd(self, dir):
        dir = expand_macros(dir, self)

        if self.cwd() == dir:
            return

        os.chdir(dir)
        self.cwd()
        trace(dir)

    def pushd(self, dir):
        if len(self._dirstack) == 0:
            self._dirstack.append({'dir': self._cwd, 'caller': 'profile'})

        self.cd(dir)
        self._dirstack.append({'dir': self._cwd, 'caller': get_caller()})

    def popd(self, failure=False):
        caller = get_caller()

        cwd = self._dirstack.pop()
        if not failure:
            if cwd['caller'] != caller:
                warn('popd: Unmatched pushd/popd callers: (%s/%s)' %
                     (cwd['caller'], caller))
                # return False

            if cwd['dir'] != self.cwd() and not failure:
                warn ('popd: Inconsistent current dir state (expected ''%s'', was in ''%s''' % (
                    cwd['dir'], self._cwd))

        top = self._dirstack[-1]

        self.cd(top['dir'])

    def prep(self):
        return

    def rm_if_exists(self, path):
        path = expand_macros(path, self)
        if os.path.lexists(path):
            delete(path)

    def rm(self, path):
        delete(expand_macros(path, self))

    def link(self, source, link):
        trace('%s -> %s' % (link, source))
        source = expand_macros(source, self)
        link = expand_macros(link, self)
        if os.path.lexists(link):
            delete(link)
        os.symlink(source, link)

    def extract_archive(self, archive, cwd, validate_only, overwrite=False):
        root, ext = os.path.splitext(archive)

        if ext == '.zip':
            command = which('unzip')
            if not command:
                error('unzip not found')

            args = ["-qq"]
            if overwrite:
                args.extend(["-o"])
            if validate_only:
                args.extend(["-t"])

            args.extend([archive])
        else:
            command = which('tar')
            if not command:
                error('tar not found')
            args = ['xf', archive]
            if validate_only:
                args.extend(['-O'])
        run(command, args, cwd)

    def build(self):
        Package.configure(self)
        Package.make(self)

    def lipo_dirs(self, dir_64, dir_32, bin_subdir, replace_32=True):
        dir64_bin = os.path.join(dir_64, bin_subdir)
        dir32_bin = os.path.join(dir_32, bin_subdir)
        lipo_dir = tempfile.mkdtemp()
        lipo_bin = os.path.join(lipo_dir, bin_subdir)

        if not os.path.exists(dir64_bin):
            return  # we don't always have bin/lib dirs

        if not os.path.exists(lipo_bin):
            os.mkdir(lipo_bin)

        # take each 64-bit binary, lipo with binary of same name

        for root, dirs, filelist in os.walk(dir64_bin):
            relpath = os.path.relpath(root, dir64_bin)
            for file in filelist:
                if file.endswith('.a') or file.endswith('.dylib') or file.endswith('.so'):
                    dir64_file = os.path.join(dir64_bin, relpath, file)
                    dir32_file = os.path.join(dir32_bin, relpath, file)
                    lipo_file = os.path.join(lipo_bin, relpath, file)
                    if os.path.exists(dir32_file):
                        if not os.path.exists(os.path.join(lipo_bin, relpath)):
                            os.makedirs(os.path.join(lipo_bin, relpath))

                        if os.path.islink(dir64_file):
                            continue
                        lipo_cmd = 'lipo -create %s %s -output %s ' % (
                            dir64_file, dir32_file, lipo_file)
                        # print lipo_cmd
                        run_shell(lipo_cmd)
                        if replace_32:
                            # replace all 32-bit binaries with the new fat
                            # binaries
                            shutil.move(lipo_file, dir32_file)
                    else:
                        warn("lipo: 32-bit version of file %s not found" % file)

    #creates a deep hardlink copy of a directory
    def shadow_copy (self, source, dest, exclude_git = False):
        trace ('shadow_copy %s %s' % (source , dest))
        if os.path.exists(dest):
            error ('Destination directory must not exist')

        # Bockbuild state may be under the directory if we are copying a local workspace. Avoid recursive copying
        stateroot_parent = os.path.dirname (config.state_root)
        stateroot_name = os.path.basename (config.state_root)
        stateroot_found = False

        if not os.path.commonprefix  ([source, config.state_root]) == source:
            stateroot_found = True

        for root, subdirs, filelist in os.walk (source):
            relpath = os.path.relpath(root, source) # e.g. 'lib/mystuff'
            destpath = os.path.join(dest, relpath)
            os.makedirs(destpath)
            if exclude_git:
                subdirs[:] = [dir for dir in subdirs if dir != '.git']
            if not stateroot_found and root == stateroot_parent:
                subdirs [:] = [dir for dir in subdirs if dir != stateroot_name]
                stateroot_found = True
            for file in filelist:
                fullpath = os.path.join (root, file)
                if os.path.islink(fullpath):
                    target = os.path.join(os.path.dirname(fullpath), os.readlink(fullpath))
                    if not os.path.exists(fullpath) or os.path.commonprefix  ([config.state_root, target]) == config.state_root:
                        break
                os.link (fullpath, os.path.join (destpath, file))
        trace ('shadow_copy done')

    def copy_side_by_side(self, src_dir, dest_dir, bin_subdir, suffix, orig_suffix=None):
        def add_suffix(filename, sfx):
            fileparts = filename.split('.', 1)
            if len(fileparts) > 1:
                p = '%s%s.%s' % (fileparts[0], sfx, fileparts[1])
            else:
                p = '%s%s' % (filename, sfx)

            trace(p)
            return p

        src_dir = os.path.join(src_dir, bin_subdir)
        dest_dir = os.path.join(dest_dir, bin_subdir)
        trace('src_dir %s' % src_dir)
        trace('dest_dir %s' % dest_dir)

        if not os.path.exists(src_dir):
            return  # we don't always have bin/lib dirs

        for path in iterate_dir(src_dir):
            relpath = os.path.relpath(path, src_dir)
            reldir, filename = os.path.split(relpath)
            trace(reldir + '/' + filename)

            filetype = backtick('file -b "%s"' % path)[0]
            if filetype.startswith('Mach-O'):
                dest_file = os.path.join(
                    dest_dir, reldir, add_suffix(filename, suffix))
                trace(dest_file)
                dest_orig_file = os.path.join(dest_dir, reldir, filename)

                if not os.path.exists(dest_orig_file):
                    warn('lipo: %s exists in %s but not in %s' %
                          (relpath, src_dir, dest_dir))
                elif orig_suffix is not None:
                    suffixed = os.path.join(
                        dest_dir, reldir, add_suffix(filename, orig_suffix))
                    trace(dest_orig_file)
                    trace(suffixed)
                    shutil.move(dest_orig_file, suffixed)
                    os.symlink(os.path.basename(suffixed), dest_orig_file)

                if not os.path.exists(os.path.dirname(dest_file)):
                    os.makedirs(os.path.dirname(dest_file))

                shutil.copy2(path, dest_file)

    def arch_build(self, arch):
        Package.profile.arch_build(arch, self)

    def expand_build_env(self):
        return expand_macros(
            'OBJCFLAGS="%{gcc_flags} %{local_gcc_flags}" '
            'CFLAGS="%{gcc_flags} %{local_gcc_flags}" '
            'CXXFLAGS="%{gcc_flags} %{local_gcc_flags}" '
            'CPPFLAGS="%{cpp_flags} %{local_cpp_flags}" '
            'LDFLAGS="%{ld_flags} %{local_ld_flags}" ', self)

    def configure(self):
        self.sh('%{configure} %{configure_flags} %{local_configure_flags}')

    def make(self):
        self.sh('%{make}')

    def install(self):
        self.sh('%{makeinstall}')

Package.default_sources = None

# -------------------------------------
# Package Templates
# -------------------------------------


class GnomePackage (Package):

    def __init__(self, name, version_major='0', version_minor='0',
                 configure_flags=None, sources=None, override_properties=None):

        self.version_major = version_major
        self.version_minor = version_minor

        Package.__init__(self, name, '%{version_major}.%{version_minor}',
                         configure_flags=configure_flags,
                         sources=sources,
                         override_properties=override_properties)

GnomePackage.default_sources = [
    'http://ftp.gnome.org/pub/gnome/sources/%{name}/%{version_major}/%{name}-%{version}.tar.bz2'
]


class GnomeXzPackage (GnomePackage):
    pass

GnomeXzPackage.default_sources = [
    'http://ftp.gnome.org/pub/gnome/sources/%{name}/%{version_major}/%{name}-%{version}.tar.xz'
]


class GnomeGitPackage (Package):

    def __init__(self, name, version, revision,
                 configure_flags=None, sources=None, override_properties=None):
        Package.__init__(self, name, version,
                         configure='./autogen.sh --prefix="%{package_prefix}"',
                         configure_flags=configure_flags,
                         sources=sources,
                         override_properties=override_properties,
                         revision=revision)

GnomeGitPackage.default_sources = [
    'git://git.gnome.org/%{name}'
]


class GnuPackage (Package):
    pass
GnuPackage.default_sources = [
    'ftp://ftp.gnu.org/gnu/%{name}/%{name}-%{version}.tar.gz'
]


class GnuBz2Package (Package):
    pass
GnuBz2Package.default_sources = [
    'ftp://ftp.gnu.org/gnu/%{name}/%{name}-%{version}.tar.bz2'
]


class GnuXzPackage (Package):
    pass
GnuXzPackage.default_sources = [
    'ftp://ftp.gnu.org/gnu/%{name}/%{name}-%{version}.tar.xz'
]


class CairoGraphicsPackage (Package):
    pass
CairoGraphicsPackage.default_sources = [
    'http://cairographics.org/releases/%{name}-%{version}.tar.gz'
]


class CairoGraphicsXzPackage (Package):
    pass
CairoGraphicsXzPackage.default_sources = [
    'http://cairographics.org/releases/%{name}-%{version}.tar.xz'
]


class ProjectPackage (Package):

    def __init__(self, project, name, version, configure_flags=None,
                 sources=None, override_properties=None):

        self.project = project
        Package.__init__(self, name, version,
                         configure_flags=configure_flags,
                         sources=sources,
                         override_properties=override_properties)


class SourceForgePackage (ProjectPackage):
    pass
SourceForgePackage.default_sources = [
    'https://downloads.sourceforge.net/sourceforge/%{project}/%{name}-%{version}.tar.gz'
]


class FreeDesktopPackage (ProjectPackage):
    pass
FreeDesktopPackage.default_sources = [
    'http://%{project}.freedesktop.org/releases/%{name}-%{version}.tar.gz'
]


class GitHubTarballPackage (Package):

    def __init__(self, org, name, version, commit, configure, override_properties=None):
        Package.__init__(self, name, version, revision=commit, organization=org,
                         override_properties=override_properties)
        self.configure = configure
        self.source_dir_name = '%s-%s-%s' % (org, name, self.revision[:7])
GitHubTarballPackage.default_sources = [
    'https://github.com/%{organization}/%{name}/tarball/%{revision}'
]


class GitHubPackage (Package):

    def __init__(self, organization, name, version, revision=None, git_branch=None, configure=None, configure_flags=None, override_properties=None):
        Package.__init__(self, name, version,
                         organization=organization,
                         revision=revision,
                         git_branch=git_branch,
                         configure_flags=configure_flags,
                         configure=configure,
                         sources=[
                             'https://github.com/%{organization}/%{name}.git'],
                         override_properties=override_properties)


class GstreamerPackage (ProjectPackage):
    pass
GstreamerPackage.default_sources = [
    'https://%{project}.freedesktop.org/src/%{name}/%{name}-%{version}.tar.gz'
]


class XiphPackage (ProjectPackage):
    pass
XiphPackage.default_sources = [
    'https://downloads.xiph.org/releases/%{project}/%{name}-%{version}.tar.gz'
]
