class LibTiffPackage (Package):

    def __init__(self):
        Package.__init__(self, 'tiff', '4.0.9',
                         configure_flags=[
                         ],
                         sources=[
                             'http://download.osgeo.org/libtiff/tiff-%{version}.tar.gz',
                         ])
        self.sources.extend([
            'patches/tiff/patch-tiffconf.diff',
            'patches/tiff/patch-tif_config.diff'
        ])

    def build(self):
        if Package.profile.name == 'darwin':
            Package.configure(self)
            for p in range(1, len(self.local_sources)):
                self.sh('patch -p0 < "%{local_sources[' + str(p) + ']}"')
            Package.make(self)
        else:
            Package.build(self)

LibTiffPackage()
