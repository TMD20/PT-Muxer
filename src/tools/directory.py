
import os

import src.tools.paths as paths
from typing import Union


class cwd:
    """
    This class creates a context provider for changing the directory on entrance
    returns to original directory at exit
    """
    def __init__( self,dir:Union[str, bytes, os.PathLike] )->None:
        self._olddir=os.getcwd()
        self._dir=dir
    def __enter__(self)->None:
        paths.mkdirSafe(self._dir)
        self._dir=paths.convertPathType(self._dir,type="Linux")
        os.chdir(self._dir)
    def __exit__(self, exc_type, exc_value, tb)->None:
        os.chdir(self._olddir)
        

