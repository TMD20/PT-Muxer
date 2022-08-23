import os
import requests_cache


root_dir = os.path.dirname(os.path.realpath(__file__))

eac3toSystemPath = "/usr/local/bin/eac3to/eac3to.exe"
eac3toProjectPath = os.path.join(root_dir, "binaries/eac3to/eac3to.exe")

wineSystemPath = "/usr/bin/wine"
wineProjectPath = os.path.join(root_dir, "binaries/wine/wine")

mkvmergeSystemPath = "/usr/bin/mkvmerge"
mkvMergeLinux=os.path.join(root_dir, "binaries/mkvmerge/Linux/mkvmerge")
mkvMergeWindows=os.path.join(root_dir, "binaries/mkvmerge/Windows/mkvmerge.exe")

bdSupSystemPath="/usr/local/bin/bdsup2sub.exe"
bdSupProjectPath=os.path.join(root_dir, "binaries/bdsup2sub.exe")


supripSystemPath = "/usr/local/bin/Subrip.exe"
supripProjectPath = os.path.join(
    root_dir, "binaries/suprip/SupRip.exe")

bdinfoSystemPath = ""
bdinfoProjectPath = os.path.join(
    root_dir, "binaries/bdinfo/BDInfo.exe")

demuxPrefix="Mux"

session = requests_cache.CachedSession(os.path.join(root_dir,"cache"))