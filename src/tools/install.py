import os
import tarfile
import requests
import stat
from typing import Callable

from rich.progress import track
from tqdm import tqdm


import src.tools.general as utils
import config as config
import src.tools.paths as paths
import src.tools.directory as dirs
import src.tools.logger as logger


def javaInstallCheck()->bool:
    """
    Function to install java if needed
    method based on OS
    """
    if utils.getSystem() == "Windows":
        return True
    if os.path.exists(config.JAVAPATH):
        return True
    java = config.JAVAPATH
    msg =\
        f"""
        Java was not found
        Java is required to extract embedded forced subs on Linux
        Do you want some assistance installing it?

        Note: If you select No, then the program will continue without trying to extract from .sup files
        Install Location: {java}
        """
    if utils.singleSelectMenu(["Yes", "No"], msg) == "No":
        return False
    javaLink = "https://download.java.net/java/GA/jdk19.0.1/afdd2e245b014143b62ccb916125e3ce/10/GPL/openjdk-19.0.1_linux-x64_bin.tar.gz"
    javaTempTar = "java.tar.gz"

    with dirs.cwd(paths.createTempDir()):

        response = requests.get(javaLink, stream=True,)
        total_size_in_bytes = int(response.headers.get('content-length', 0))
        block_size = 1024  # 1 Kibibyte
        progressBar = tqdm(total=total_size_in_bytes, unit='B',
                           unit_scale=True, unit_divisor=1024)

        with open(javaTempTar, "wb") as fp:
            for data in response.iter_content(block_size):
                fp.write(data)
                progressBar.update(len(data))

        with tarfile.open(javaTempTar) as fp:
            fp.extractall(".")
        os.remove(javaTempTar)
        os.replace(os.listdir(".")[0], "java")
        os.replace("java", java)
    return True


def contyInstallCheckWine()-> Callable[..., bool]:
    """
    Function to install conty if needed
    """
    if utils.getSystem() == "Windows":
        return True
    elif os.path.exists(config.WINEPATH):
        return True
    elif os.path.exists(config.CONTYPATH):
        contyChmod()
        return True
    return contyInstaller()


def contyInstallCheckMono()->Callable[..., bool]:
    """
    Function to install conty if needed
    """
    if utils.getSystem() == "Windows":
        return True
    elif os.path.exists(config.MONOPATH):
        return True
    elif os.path.exists(config.CONTYPATH):
        contyChmod()
        return True
    return contyInstaller()


def contyInstaller()->bool:
    """
    Walk-through function to install conty if prompted
    """
    conty = os.path.dirname(config.CONTYPATH)
    info =\
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
    msg = "Do you want to install Conty?"
    if utils.singleSelectMenu(["Yes", "No"], msg) == "No":
        return False
    contyLink = "https://github.com/Kron4ek/Conty/releases/download/1.21.7/conty.sh"

    with dirs.cwd(conty):
        response = requests.get(contyLink, stream=True,)
        total_size_in_bytes = int(response.headers.get('content-length', 0))
        block_size = 1024  # 1 Kibibyte
        progressBar = tqdm(total=total_size_in_bytes, unit='B',
                           unit_scale=True, unit_divisor=1024)

        with open("conty.sh", "wb") as fp:
            for data in response.iter_content(block_size):
                fp.write(data)
                progressBar.update(len(data))
    contyChmod()
    return True


def contyChmod()->None:
    """
    Helper function to change enviromental variables for conty
    """
    os.environ["ALLOW_ROOT"] = "1"
    os.chmod(config.CONTYPATH, os.stat(config.CONTYPATH).st_mode | 0o111)
