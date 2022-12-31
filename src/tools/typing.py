import argparse
import os
from typing import List
import typing
from src.demux.base import Demux

import src.mediatools.bdinfo as bdinfo
import src.sites.base.siteSourceData as siteSourceData
import src.sites.base.siteTrackSorter as siteTrackSorter

siteSourceData=siteSourceData.siteSourceData
siteTrackSorter=siteTrackSorter.siteTrackSorter
bdinfo=bdinfo.Bdinfo
bdArray=List[bdinfo]
siteSourceDataArray=List[siteSourceData]
dictList=List[dict]
strList=List[str]
filePath=typing.Union[str, bytes, os.PathLike]
filePathList=List[filePath]

