class Autoconf (GnuPackage):

    def __init__(self):
        GnuPackage.__init__(self, 'autoconf', '2.69', override_properties={
                            'build_dependency': True})
        self.extra_stage_files = ['share/autoconf/autom4te.cfg']

    def install(self):
        Package.install(self)
        aclocal_dir = os.path.join(self.staged_prefix, "share", "aclocal")
        if not os.path.exists(aclocal_dir):
            os.makedirs(aclocal_dir)

    def arch_build(self, arch):
        if arch == 'darwin-universal':
            self.local_ld_flags = ['-arch i386', '-arch x86_64']
            self.local_gcc_flags = ['-arch i386', '-arch x86_64']
        elif arch == 'darwin-32':
            self.local_ld_flags = ['-arch i386', '-m32']
            self.local_gcc_flags = ['-arch i386', '-m32']
            self.local_configure_flags = ['--build=i386-apple-darwin13.0.0']
        elif arch == 'darwin-64':
            self.local_ld_flags = ['-arch x86_64 -m64']
            self.local_gcc_flags = ['-arch x86_64 -m64']


Autoconf()
