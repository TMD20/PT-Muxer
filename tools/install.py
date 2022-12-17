import os
import tarfile
import requests
import stat

from rich.progress import track
from tqdm import tqdm


import tools.general as utils
import config
import tools.paths as paths
import tools.directory as dirs
import tools.logger as logger


def javaInstallCheck():
        if utils.getSystem()=="Windows":
            return True
        if os.path.exists(config.javaPath):
            return True
        java=os.path.join(config.root_dir,"binaries","java")
        msg=\
        f"""
        Java was not found
        Java is required to extract embedded forced subs on Linux
        Do you want some assistance installing it?

        Note: If you select No, then the program will continue without trying to extract from .sup files
        Install Location: {java}
        """
        if utils.singleSelectMenu(["Yes","No"],msg)=="No":
            return False
        javaLink="https://download.java.net/java/GA/jdk19.0.1/afdd2e245b014143b62ccb916125e3ce/10/GPL/openjdk-19.0.1_linux-x64_bin.tar.gz"
        javaTempTar="java.tar.gz"

        with dirs.cwd(paths.createTempDir()):
  

            response=requests.get(javaLink,stream=True,)
            total_size_in_bytes= int(response.headers.get('content-length', 0))
            block_size = 1024 #1 Kibibyte
            progressBar=tqdm(total=total_size_in_bytes, unit='B', unit_scale=True, unit_divisor=1024)

            with open(javaTempTar,"wb") as fp:
                for data in response.iter_content(block_size):
                    fp.write(data)
                    progressBar.update(len(data))

            with tarfile.open(javaTempTar) as fp:
                fp.extractall(".")
            os.remove(javaTempTar)
            os.replace(os.listdir(".")[0],"java")
            os.replace("java",java)
        return True

def contyInstallCheckWine():
        if utils.getSystem()=="Windows":
            return True
        elif os.path.exists(config.winePath):
            return True
        elif os.path.exists(config.contyPath):
            contyChmod()
            return True
        return contyInstaller()

def contyInstallCheckMono():
        if utils.getSystem()=="Windows":
            return True
        elif os.path.exists(config.monoPath):
            return True
        elif os.path.exists(config.contyPath):
            contyChmod()
            return True
        return contyInstaller()        
        
def contyInstaller():
        conty=os.path.dirname(config.contyPath)
        info=\
        f"""
        Wine is not installed and is required to run eac3to/BDInfo on Linux
        If your running this script with sudo permissions
        You should install wine via you package manager
        
        
        Conty can be used if you do not have sudo access on your system
        It wraps all the required binaries for wine into a executable container
        https://github.com/Kron4ek/Conty
        Note: The file is somewhat large at 1.7GB
        Note: Using Conky with a root to run eac3to has been known to fail

        Install Location:{conty}
        """
        logger.print(info)
        msg="Do you want to install Conty?"
        if utils.singleSelectMenu(["Yes","No"],msg)=="No":
            return False
        contyLink="https://github.com/Kron4ek/Conty/releases/download/1.21.7/conty.sh"


        with dirs.cwd(conty):
            response=requests.get(contyLink,stream=True,)
            total_size_in_bytes= int(response.headers.get('content-length', 0))
            block_size = 1024 #1 Kibibyte
            progressBar=tqdm(total=total_size_in_bytes, unit='B', unit_scale=True, unit_divisor=1024)
                 
            with open("conty.sh","wb") as fp:
                for data in response.iter_content(block_size):
                    fp.write(data)
                    progressBar.update(len(data))
        contyChmod()
        return True    
def contyChmod():
    os.environ["ALLOW_ROOT"] = "1"
    os.chmod(config.contyPath,os.stat(config.contyPath).st_mode|0o111)