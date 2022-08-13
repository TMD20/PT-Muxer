import os
import requests_cache
root_dir = os.path.dirname(os.path.realpath(__file__))

eac3toLinuxPath = "/usr/local/bin/eac3to/eac3to.exe"
eac3toProjectPath = os.path.join(root_dir, "binaries/eac3to/eac3to.exe")

wineLinuxPath = "/usr/bin/wine"
wineProjectPath = os.path.join(root_dir, "binaries/wine/wine")

mkvmergeLinuxPath = "/usr/bin/mkvmerge"
mkvMergeProjectPath=os.path.join(root_dir, "binaries/mkvmerge")

bdSupLinuxPath="/usr/local/bin/bdsup2sub.exe"
bdSupProjectPath=os.path.join(root_dir, "binaries/bdsup2sub.exe")


supripLinuxPath = "/usr/local/bin/Subrip.exe"
supripProjectPath = os.path.join(
    root_dir, "binaries/suprip/SupRip.exe")

bdinfoLinuxPath = ""
bdinfoProjectPath = os.path.join(
    root_dir, "binaries/bdinfo/BDInfo.exe")

demuxPrefix="Mux"

session = requests_cache.CachedSession(os.path.join(root_dir,"cache"))
