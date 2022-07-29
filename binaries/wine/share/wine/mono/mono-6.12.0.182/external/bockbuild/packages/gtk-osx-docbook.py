class GtkOSXDocbookPackage (GitHubTarballPackage):

    def __init__(self):
        GitHubTarballPackage.__init__(self, 'jralls', 'gtk-osx-docbook',
                                      '1.0', '55419344c9d82ed06f50bfe22a924c49ad59f68e', '',
                                      override_properties={
                                          'build_dependency': True}
                                      )

    def build(self):
        return

    def install(self):
        self.sh('JHBUILD_PREFIX="%{staged_profile}" %{makeinstall}')

GtkOSXDocbookPackage()
