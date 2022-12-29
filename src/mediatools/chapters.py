import tempfile
import sys

import pymplschapters as mpls

import src.tools.paths as paths
####
#Keeping this function for now
# Eac3to Doesn't detect chapters for some reason
# So currently not in use
####
def verifyChapters(playlistFile):
    saved_argv = sys.argv
    success=False
    tempDir=paths.createTempDir()
    try:
        sys.argv=["t","-p",playlistFile,"-d",tempDir]
        mpls.main()
        success=True
    except Exception as E:
        print(E)
    finally:
        sys.argv=saved_argv
        paths.rmSafe(tempDir)
        return success


