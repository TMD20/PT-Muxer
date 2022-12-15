import os
import requests_cache
import tempfile
import sys


root_dir = os.path.dirname(os.path.realpath(__file__))

eac3toSystemPath = "/usr/local/bin/eac3to/eac3to.exe"
eac3toProjectPath = os.path.join(root_dir, "binaries/eac3to/eac3to.exe")

dgDemuxLinux=os.path.join(root_dir,"binaries/dgdemux/Linux/dgdemux")
dgDemuxWindow=os.path.join(root_dir,"binaries/dgdemux/Linux/dgdemux")


wineSystemPath = "/usr/bin/wine"
wineProjectPath = os.path.join(root_dir, "binaries/wine/wine")
javaSystemPath="/usr/bin/java"


mkvmergeSystemPath = "/usr/bin/mkvmerge"
mkvMergeLinux = os.path.join(root_dir, "binaries/mkvmerge/Linux/mkvmerge")
mkvMergeWindows = os.path.join(
    root_dir, "binaries/mkvmerge/Windows/mkvmerge.exe")

bdSupWindows= os.path.join(root_dir, "binaries/bdsup2sub.exe")
bdSupLinux= os.path.join(root_dir, "binaries/bdsup2sub/Linux/BDSup2Sub512.jar")


bdinfoWindowsPath = os.path.join(
    root_dir, "binaries/bdinfo/BDInfo.exe")
bdinfoLinuxPath = os.path.join(
    root_dir, "binaries/bdinfo/BDInfo.exe")    

isoExtractWindows = os.path.join(root_dir, "binaries/7z/Windows/7za.exe")
isoExtractLinux= os.path.join(root_dir, "binaries/7z/Linux/7zzs")
demuxPrefix = "Mux"
cacheDir = os.path.join(os.path.expanduser("~"), ".cache","remuxer_cache")
session = requests_cache.CachedSession(cacheDir)
tempFolder=tempfile.gettempdir()
tempPrefix="PTMuxer_"
pythonPath='/usr/bin/python3'
