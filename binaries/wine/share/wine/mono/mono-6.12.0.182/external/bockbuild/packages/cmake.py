from distutils.version import LooseVersion, StrictVersion


class SystemCMake (Package):

    def __init__(self):
        Package.__init__(self, 'cmake', 'system', sources=None)
        cmake_path = which('cmake')
        if cmake_path is None:
            error('cmake not found in PATH')
        self.cmake_path = cmake_path
        cmake_version_str = backtick('%s --version' % self.cmake_path)[0].split(' ')[2]
        cmake_version = StrictVersion(cmake_version_str)
        self.version = str(cmake_version)

    def build(self):
        pass

    def install(self):
        self.sh('mkdir -p "%{staged_prefix}/bin"')
        self.sh('ln -s -F %{cmake_path} "%{staged_prefix}/bin/cmake"')

SystemCMake()
