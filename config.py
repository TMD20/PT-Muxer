import os
root_dir = os.path.dirname(os.path.realpath(__file__))

eac3toLinuxPath = "/usr/local/bin/eac3to/eac3to.exe"
eac3toProjectPath = os.path.join(root_dir, "binaries/eac3to/eacto.exe")

wineLinuxPath = "/usr/bin/wine"
wineProjectPath = os.path.join(root_dir, "binaries/wine-7.13-amd64/bin/wine")

mkvmergeLinuxPath = "/usr/bin/mkvmerge"
mkvMergeProjectPath=os.path.join(root_dir, "binaries/wine-7.13-amd64/mkvmerge")

bdSupLinuxPath="/usr/local/bin/bdsup2sub"
bdSupProjectPath=os.path.join(root_dir, "binaries/wine-7.13-amd64/bdsup2sub++1.0.2_Win32.exe")

bdinfoLinuxPath = ""
bdinfoProjectPath = os.path.join(
    root_dir, "binaries/bdinfo/BDInfo.exe")

demuxPrefix="Mux"