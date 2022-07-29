from profile import Profile
from bockbuild.environment import Environment
from bockbuild.util.util import *

class UnixProfile (Profile):

    def attach (self, bockbuild):
        Profile.attach (self, bockbuild)

        self.name = 'unix'
        self.env = Environment(self)
        self.staged_prefix = bockbuild.staged_prefix 
        self.toolchain_root = bockbuild.toolchain_root

        self.gcc_flags = ['-I%s/include' % self.staged_prefix]
        self.ld_flags = ['-L%s/lib' % self.staged_prefix]
        self.configure_flags = []

        self.env.set('bockbuild version', git_shortid(bockbuild, bockbuild.root))
        self.env.set('BUILD_PREFIX', '%{prefix}')

        self.env.set('PATH', ':',
                     '%{toolchain_root}/bin',
                     '%{staged_prefix}/bin',
                     '/usr/bin',
                     '/bin',
                     '/usr/local/bin')

        self.env.set('C_INCLUDE_PATH',  '%{staged_prefix}/include')

        #self.env.set ('LD_LIBRARY_PATH', '%{staged_prefix}/lib')

        self.env.set('ACLOCAL_FLAGS',   '-I%{staged_prefix}/share/aclocal')
        self.env.set('PKG_CONFIG_PATH', ':',
                     '%{staged_prefix}/lib/pkgconfig',
                     '%{staged_prefix}/share/pkgconfig',
                     '%{toolchain_root}/lib/pkgconfig',
                     '%{toolchain_root}/share/pkgconfig')

        self.env.set('XDG_CONFIG_DIRS', '%{staged_prefix}/etc/xdg')
        self.env.set('XDG_DATA_DIRS',   '%{staged_prefix}/share')
        self.env.set('XDG_CONFIG_HOME', '$HOME/.config')
