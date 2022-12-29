# Install

Instructions are provided for Linux and Windows

### Linux:

#### Required

* python 3.8 ; other version may work but not guaranteed

#### Optional

* wine
* mono
* tesseract-ocr
* udevil

#### Install

* git clone [https://github.com/TMD20/PTMuxer](https://github.com/TMD20/PTMuxer)
* python3.8 -m pip install --user virtualenv
* python3.8 -m venv env
* source env/bin/activate
* which python -> should be the virtualenv
* pip3 install -r requirements.txt
* deactivate -> Do this after installing the requirements
* chmod +x -R ./binaries | Alternativly 7zip, mkvmerge both need execution permission

### Windows

#### Required

* python3.8; other version of python may work but not guaranteed

Optional

* tesseract-ocr

#### Install

* git clone [https://github.com/TMD20/PTMuxer](https://github.com/TMD20/PTMuxer)
* py -3.8 -m pip install --user virtualenv
* py -3.8 -m venv env
* .\env\Scripts\activate
* which python -> should be the virtualenv
* py -m pip install -r requirements.txt
* deactivate -> Do this after installing the requirements
*   go to the binaries folder with the project folder and run the following binaries

    This seems to be required to give the correct permissions to these executables

    * /bdinfo/BDInfo.exe
    * /eac3to/eacto.exe
* Install any requirements when prompted

### General virtualenv Guide

General Guide: https://packaging.python.org/en/latest/guides/installing-using-pip-and-virtual-environments/

### &#x20;

