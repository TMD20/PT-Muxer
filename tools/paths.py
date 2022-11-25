import tempfile

import config as config
def createTempDir():
    return tempfile.mkdtemp(prefix=config.tempPrefix, dir=config.tempFolder)