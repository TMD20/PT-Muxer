import os
import requests_cache
import tempfile
import shutil


ROOT_DIR = os.path.dirname(os.path.realpath(__file__))

###
#bin
###
WINEPATH = shutil.which("wine")
JAVAPATH=shutil.which("java")  or os.path.join(ROOT_DIR,"bin","java/bin/java")
MONOPATH=shutil.which("mono")
CONTYPATH= os.path.join(ROOT_DIR,"bin","conty/conty.sh")

EACTOPATH = shutil.which("eac3to.exe") or os.path.join(ROOT_DIR, "bin/eac3to/eac3to.exe")
DGDEMUXLINUX=shutil.which("dgdemux") or os.path.join(ROOT_DIR,"bin/dgdemux/Linux/dgdemux")
DGDEMUXWINDOW=shutil.which("dgdemux") or os.path.join(ROOT_DIR,"bin/dgdemux/Windows/DGDemux.exe")




MKVMERGELINUX = shutil.which("mkvmerge") or os.path.join(ROOT_DIR, "bin/mkvmerge/Linux/mkvmerge")
MKVMERGEWINDOWS =  shutil.which("mkvmerge") or os.path.join(
    ROOT_DIR, "bin/mkvmerge/Windows/mkvmerge.exe")

BDSUPLINUX= os.path.join(ROOT_DIR, "bin/bdsup2sub/Linux/BDSup2Sub512.jar")
BDSUPWINDOWS= os.path.join(ROOT_DIR, "bin/bdsup2sub.exe")



BDINFOWINDOWSPATH = os.path.join(
    ROOT_DIR, "bin/bdinfo/BDInfo.exe")
BDINFOLINUXPATH= os.path.join(
    ROOT_DIR, "bin/bdinfo/BDInfo.exe")    

ISOEXTRACTWINDOWS = os.path.join(ROOT_DIR, "bin/7z/Windows/7za.exe")
ISOEXTRACTLINUX= os.path.join(ROOT_DIR, "bin/7z/Linux/7zzs")


SUPRIPPATH = shutil.which("Subrip.exe") or  os.path.join(
    ROOT_DIR, "bin/suprip/SupRip.exe")

AVISYNTH_LINUX_LIB= os.path.join(ROOT_DIR, "bin/avisynth/Linux/Lib")
FFMS2_LINUX_LIB=os.path.join(ROOT_DIR, "bin/avisynth/Linux/libffms2.so.5.0.0")
FFMS2=os.path.join(ROOT_DIR, "bin/avisynth/FFMS2.avsi")
FFMPEG_LINUX=os.path.join(ROOT_DIR, "bin/avisynth/ffmpeg")

###
#Global Settings
###
DEMUXPREFIX= "Mux"
CACHEDIR = os.path.join(os.path.expanduser("~"), ".cache","remuxer_cache")
SESSION = requests_cache.CachedSession(CACHEDIR)
TEMPFOLDER=tempfile.gettempdir()
TEMPPREFIX="PTMuxer_"
TEMPFOLDERMINCLEANUPTIME=60 #Max Value accepted is 1440 Minutes
MAXOCRLINECOUNT=50
MAXVOICELINECOUNT=50
