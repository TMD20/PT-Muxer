package = FreeDesktopPackage('%{name}', 'pkg-config', '0.27',
                             configure_flags=["--with-internal-glib"])

if package.profile.name == 'darwin':
    package.m64_only = True
