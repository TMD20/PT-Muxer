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

import config as config
import src.tools.general as utils
import src.tools.commands as commands
import src.tools.logger as logger

tempDirs = []


def createTempDir():
    """
    Creates a tempdirectory
    modified to create directory and default location or location at config.py

    Additional creates temp directory parent if needed
    

    Returns:
        str: path to created temp directory
    """
    mkdirSafe(os.path.join(config.tempFolder, "x"))

    tempDir = tempfile.mkdtemp(prefix=config.tempPrefix, dir=config.tempFolder)
    tempDirs.append(tempDir)
    return tempDir


def getOldTempPathDirs():
    """
    List of all directories match config.py tempPrefix within configured temp directory
    Limits to configured time limit

    Returns:
        array: list of directories
    """
    timeLimit = min(config.tempFolderCleanupTime, 1440)
    hour = timeLimit//60
    minute = timeLimit-(60*hour)
    criticalTime = utils.convertArrow(f"{hour:02d}:{minute:02d}", "hh:mm")
    results = search(config.tempFolder,
                     f"/{config.tempPrefix}[^/]*$", dir=True)
    return list(filter(lambda x: utils.convertArrow(os.stat(x).st_mtime) > criticalTime, results))


def getTempDirs():
    """
    returns all temp directories created during current run

    Returns:
        array: list of directories
    """
    return list(map(lambda x: convertPathType(x, type="Linux"), tempDirs))


def deleteTempDirs():
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


def search(path, query, case=False, dir=False, ignore=[], fullMatch=False, recursive=True):
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


def _excludeHelper(paths, dir, ignore):
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


def mkdirSafe(target):
    """
    Helper function to create path if not present
    Additionally creates parent paths of target if not present

    Args:
        target (str): target path to create directory for, assumed to be a file 
    """
    directories = list(reversed(pathlib.Path(target).parents))
    if len(os.path.splitext(target)[1]) == 0:
        directories.append(target)
    for ele in directories:
        if not os.path.exists(ele):
            os.mkdir(ele)


def rmSafe(path):
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


def extractISO(source, path):
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


def _extractISOProcessor(source, outPath):
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


def _ISOBinaryExtractHelper(source, outPath):
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


def _udevilExtractHelper(source, outPath):
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


def convertPathType(folder, type):
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


def switchPathType(folder):
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


def listdir(path="."):
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


def copytree(source, dest):
    """
    Function to copy one directory to path

    Args:
        source (str): source path to copy
        dest (str): path to copy to
    """
    shutil.copytree(source, dest, dirs_exist_ok=True)


def move(source, dest):
    """
    Function to move one directory to path

    Args:
        source (str): source path to move
        dest (str): path to move to
    """
    shutil.move(source, dest)


def getParentDir(path, level=0):
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
def rmDir(path):
    shutil.rmtree(path)