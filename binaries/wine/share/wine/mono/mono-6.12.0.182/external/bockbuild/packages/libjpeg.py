class LibJpegPackage (Package):

    def __init__(self):
        Package.__init__(
            self,
            'libjpeg',
            '8',
            sources=[
                'http://www.ijg.org/files/jpegsrc.v8.tar.gz',
                'patches/libjpeg8.patch'])
        self.source_dir_name = 'jpeg-8'

    def prep(self):
        Package.prep(self)
        for p in range(1, len(self.local_sources)):
            self.sh('patch -p1 < "%{local_sources[' + str(p) + ']}"')

LibJpegPackage()
