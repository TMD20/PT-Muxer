
import os
import tools.paths as paths
class cwd:
    def __init__( self,dir ):
        self._olddir=os.getcwd()
        self._dir=dir
    def __enter__(self):
        paths.mkdirSafe(os.path.join(self._dir,""))
        self._dir=paths.convertPathType(self._dir,type="Linux")
        os.chdir(self._dir)
    def __exit__(self, exc_type, exc_value, tb):
        os.chdir(self._olddir)
        

