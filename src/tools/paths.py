import tempfile
import re
import os
import pathlib
import subprocess
import functools
import shutil
import itertools
import traceback

import natsort
from typing import Any,List,Union


import config as config
import src.tools.general as utils
import src.tools.commands as commands
import src.tools.logger as logger

tempDirs = []


def createTempDir()->str:
    """
    Creates a tempdirectory
    modified to create directory and default location or location at config.py

    Additional creates temp directory parent if needed
    

    Returns:
        str: path to created temp directory
    """
    mkdirSafe(config.TEMPFOLDER)

    tempDir = tempfile.mkdtemp(prefix=config.TEMPPREFIX, dir=config.TEMPFOLDER)
    tempDirs.append(tempDir)
    return tempDir


def getOldTempPathDirs()->List[str]:
    """
    List of all directories match config.py TEMPPREFIX within configured temp directory
    Limits to configured time limit

    Returns:
        array: list of directories
    """
    timeLimit = min(config.TEMPFOLDERMINCLEANUPTIME, 1440)
    hour = timeLimit//60
    minute = timeLimit-(60*hour)
    criticalTime = utils.convertArrow(f"{hour:02d}:{minute:02d}", "hh:mm")
    results = search(config.TEMPFOLDER,
                     f"/{config.TEMPPREFIX}[^/]*$", dir=True)
    return list(filter(lambda x: utils.convertArrow(os.stat(x).st_mtime) > criticalTime, results))


def getTempDirs()->List[str]:
    """
    returns all temp directories created during current run

    Returns:
        array: list of directories
    """
    return list(map(lambda x: convertPathType(x, type="Linux"), tempDirs))


def deleteTempDirs()->None:
    """
    Generates list of temp directories
    removes all
    """
    folders = getTempDirs()
    for folder in list(filter(lambda x: os.path.exists(x), folders)):
        shutil.rmtree(folder)
    folders = getOldTempPathDirs()
    for folder in list(filter(lambda x: os.path.exists(x), folders)):
        shutil.rmtree(folder)


def search(path:Union[str, bytes, os.PathLike], query:str, case:bool=False, dir:bool=False, ignore:List[str]=[], fullMatch:bool=False, recursive:bool=True)->List[str]:
    """
    Function to search recursively in a directory for files or directories based on query

    Args:
        path (str): parent path to search within
        query (str): query to filter files or directory paths with
        case (bool, optional): Whether or not this is a case sensitive search. Defaults to False.
        dir (bool, optional): Whether or not to limit search to directories or files. Defaults to False.
        ignore (list, optional): list of strings not to include in results. Defaults to [].
        fullMatch (bool, optional): Whether or not to match substring of path or whole path. Defaults to False.
        recursive (bool, optional): Whether or not to go more than one level down in path. Defaults to True.

    Returns:
        array: list of paths matching query and args
    """
    searchMethod = re.search
    if fullMatch == True:
        searchMethod = re.match
    globSearch = "**/*"
    if recursive == False:
        globSearch = "*/"
    paths = list(map(lambda x: str(x), list(
        pathlib.Path(path).glob(globSearch))))
    paths = list(map(lambda x: convertPathType(x, type="Linux"), paths))
    paths = list(natsort.natsorted
                 (paths))
    filtered = _excludeHelper(paths, dir, ignore)
    if case:
        return list(filter(lambda x: searchMethod(query, x), filtered))
    else:
        return list(filter(lambda x: searchMethod(query, x, re.IGNORECASE), filtered))


def _excludeHelper(paths:List[Union[str, bytes, os.PathLike]], dir:bool, ignore:List[str])->List[str]:
    """
    Helper function for removing paths that match generated regex from array of words to ignore

    Args:
        paths (array): list of paths to evaluate
        dir (bool): Whether or not to limit search to directories or files
        ignore (array): list of strings to ignore
    Returns:
        array: returns filtered paths list
    """
    regexPattern = re.compile("|".join(ignore))
    filtered = list(filter(lambda x: os.path.isdir(x) == dir, paths))
    filtered = list(filter(lambda x: len(regexPattern.pattern)
                    == 0 or re.search(regexPattern, x) == None, filtered))
    return filtered


def mkdirSafe(target:Union[str, bytes, os.PathLike])->None:
    """
    Helper function to create path if not present
    Additionally creates parent paths of target if not present

    Args:
        target (str): target path to create directory
    """
    pathlib.Path(target).mkdir(exist_ok=True,parents=True)


def rmSafe(path:Union[str, bytes, os.PathLike])->None:
    """
    Helper function to remove path if present

    Args:
        path (str): path to attempt removal on
    """
    if not os.path.exists(path):
        return
    if os.path.isfile(path):
        os.remove(path)
    else:
        shutil.rmtree(path)


def extractISO(source:Union[str, bytes, os.PathLike], path:Union[str, bytes, os.PathLike])->str:
    """
    Manages extraction of ISO, and delection of conflicting files

    Args:
        source (str): ISO to process
        path (str): Path to put extracted iso in

    Returns:
        str: runs str to extracted ISO
    """
    basename = f"{os.path.basename(os.path.dirname(source))}_Extracted"
    outPath = os.path.join(path, basename)
    if os.path.exists(outPath):
        opts = ["Yes", "No"]
        remove = utils.singleSelectMenu(
            opts, f"Files already extraced\nDo you want to delete the folder:\n {outPath} ", default="No")
        if remove == "No":
            return search(outPath, "STREAM", dir=True)[0]
    return _extractISOProcessor(source, outPath)


def _extractISOProcessor(source:Union[str, bytes, os.PathLike], outPath:Union[str, bytes, os.PathLike])->str:
    """
    Extracts ISO

    Args:
        source (str): ISO to extract
        outPath (str): path to extract ISO to

    Raises:
        RuntimeError: erorr if outpath is empty

    Returns:
        str: path to extracted ISO
    """
    rmSafe(outPath)
    mkdirSafe(outPath)
    commandlist = [functools.partial(
        _ISOBinaryExtractHelper, source, outPath), functools.partial(_udevilExtractHelper, source, outPath)]
    for command in commandlist:
        try:
            command()
            break
        except Exception as e:
            logger.print(traceback.format_exc(), style="white")
            logger.print(e)
            rmSafe(outPath)
            continue
    if os.listdir(outPath) == 0:
        raise RuntimeError("Issue Extracting Files")

    if utils.singleSelectMenu(["Yes", "No"], f"Do you want to remove the ISO?\n{source}", default="No") == "Yes":
        os.remove(source)
    return search(outPath, "STREAM", dir=True)[0]


def _ISOBinaryExtractHelper(source:Union[str, bytes, os.PathLike], outPath:Union[str, bytes, os.PathLike])->None:
    """
    Uses 7z to extract ISO

    Args:
        source (str): ISO to extract
        outPath (str): path to extract ISO to

    Raises:
        Exception: raises error on 7z error
    """
    command = list(itertools.chain.from_iterable([commands.isoBinary(), [
                   "x", convertPathType(source, "Linux"),  "-bsp1", "-y", f"-o{outPath}", ]]))
    with subprocess.Popen(command) as p:
        p.wait()
        if p.returncode != 0:
            raise Exception("7z Extraction Error")


def _udevilExtractHelper(source:Union[str, bytes, os.PathLike], outPath:Union[str, bytes, os.PathLike])->None:
    """
    Uses udevil to extract ISO

    Args:
        source (str): ISO to extract
        outPath (str): path to extract ISO to

    """    
    logger.print("\nTrying Mounting ISO\nThen Extracting")
    mountpoint = f"/media/{os.getlogin()}/custom"
    mkdirSafe(f"/media/{os.getlogin()}")
    if os.path.exists(mountpoint):
        subprocess.run(
            ["udevil", "umount", mountpoint], subprocess.PIPE)
    subprocess.run(
        ["udevil", "mount", source, mountpoint], stdout=subprocess.PIPE)

    shutil.copytree(mountpoint, os.path.join(outPath))
    subprocess.run(
        ["udevil", "umount", mountpoint], subprocess.PIPE)


def convertPathType(folder:Union[str, bytes, os.PathLike], type:str)->str:
    """
    convert path type to Windows or Unix Type Paths

    Args:
        folder (str): folder to modify
        type (str): path type for conversion

    Returns:
        str: modified path
    """
    if type == "Linux":
        return re.sub(re.escape("\\"), "/", str(pathlib.PurePosixPath(folder)))
    elif type in ["Windows", "Window"]:
        return str(pathlib.PureWindowsPath(folder))


def switchPathType(folder:Union[str, bytes, os.PathLike])->str:
    """
    Queries current system as Windows or Linux
    Switches to other system type

    Args:
        folder (str): folder to modify
    Returns:
        str: modified path
    """
    if utils.getSystem() == "Linux":
        return convertPathType(folder, "Windows")
    return convertPathType(folder, "Linux")


def listdir(path:Union[str, bytes, os.PathLike]=".")->List[str]:
    """
    list directories 
    modified to use natural sorting, and to use linux type paths
    
    Note: not recursive

    Args:
        path (_type_, optional): path to list directories for. Defaults to '.'.

    Returns:
        array: list of paths within directory
    """
    path = path or "."
    if os.path.isdir(path):

        paths = list(pathlib.Path(path).iterdir())
        paths = list(map(lambda x: str(x), paths))
        paths = list(natsort.natsorted
                     (paths))
        return list(map(lambda x: convertPathType(x, type="Linux"), paths))
    return []


def copytree(source:Union[str, bytes, os.PathLike], dest:Union[str, bytes, os.PathLike])->None:
    """
    Function to copy one directory to path

    Args:
        source (str): source path to copy
        dest (str): path to copy to
    """
    shutil.copytree(source, dest, dirs_exist_ok=True)


def move(source:Union[str, bytes, os.PathLike], dest:Union[str, bytes, os.PathLike])->None:
    """
    Function to move one directory to path

    Args:
        source (str): source path to move
        dest (str): path to move to
    """
    shutil.move(source, dest)


def getParentDir(path:Union[str, bytes, os.PathLike], level:int=0)->str:
    """
    Function to move up directory tree by level height
    level 0 is direct parent

    Args:
        path (str): path to move up from
        level (int, optional): number of levels to move up. Defaults to 0.

    Returns:
        str: path to parent
    """
    parents = pathlib.Path(path).parents
    if level >= len(parents):
        return
    return str(parents[level])
def rmDir(path:Union[str, bytes, os.PathLike])->None:
    shutil.rmtree(path)