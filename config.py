import os
import requests_cache
import tempfile
import shutil


root_dir = os.path.dirname(os.path.realpath(__file__))

###
#Binaries
###
winePath = shutil.which("wine")
javaPath=shutil.which("java")  or os.path.join(root_dir,"binaries","java/bin/java")
monoPath=shutil.which("mono")
contyPath= os.path.join(root_dir,"binaries","conty/conty.sh")

eac3toPath = shutil.which("eac3to.exe") or os.path.join(root_dir, "binaries/eac3to/eac3to.exe")
dgDemuxLinux=shutil.which("dgdemux") or os.path.join(root_dir,"binaries/dgdemux/Linux/dgdemux")
dgDemuxWindow=shutil.which("dgdemux") or os.path.join(root_dir,"binaries/dgdemux/Windows/DGDemux.exe")




mkvMergeLinux = shutil.which("mkvmerge") or os.path.join(root_dir, "binaries/mkvmerge/Linux/mkvmerge")
mkvMergeWindows =  shutil.which("mkvmerge") or os.path.join(
    root_dir, "binaries/mkvmerge/Windows/mkvmerge.exe")

bdSupLinux= os.path.join(root_dir, "binaries/bdsup2sub/Linux/BDSup2Sub512.jar")
bdSupWindows= os.path.join(root_dir, "binaries/bdsup2sub.exe")



bdinfoWindowsPath = os.path.join(
    root_dir, "binaries/bdinfo/BDInfo.exe")
bdinfoLinuxPath = os.path.join(
    root_dir, "binaries/bdinfo/BDInfo.exe")    

isoExtractWindows = os.path.join(root_dir, "binaries/7z/Windows/7za.exe")
isoExtractLinux= os.path.join(root_dir, "binaries/7z/Linux/7zzs")


supripPath = shutil.which("Subrip.exe") or  os.path.join(
    root_dir, "binaries/suprip/SupRip.exe")


###
#Global Settings
###
demuxPrefix = "Mux"
cacheDir = os.path.join(os.path.expanduser("~"), ".cache","remuxer_cache")
session = requests_cache.CachedSession(cacheDir)
tempFolder=tempfile.gettempdir()
tempPrefix="PTMuxer_"
tempFolderCleanupTime=60 #Max Value accepted is 1440 Minutes
pythonPath='/usr/bin/python3'
maxOCRLineCount=50

