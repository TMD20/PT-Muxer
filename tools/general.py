import os
import re
import functools

from InquirerPy import inquirer

def mkdirSafe(target):
    print(target)
    if len(os.path.splitext(target)[1])>0:
        target=os.path.dirname(target)
    directories=[target]

    while target!= "/":
        target = os.path.dirname(target)
        directories.append(target)
    directories.reverse()
    for ele in directories:
        if not os.path.exists(ele):
            os.mkdir(ele)
    

def getRootDir():
    return os.path.dirname(os.path.dirname(os.path.realpath(__file__)))

    
def getShowName(path):
    show = re.sub("/BDMV/STREAM", "", path)
    show = os.path.basename(show)
    show=re.sub(" +"," ",show)
    show = re.sub(" ", ".", show)
    return show



def findFiles(path,string):
    matchlist=[]
    for tuple in os.walk(path):
        dir = tuple[0]
        files = tuple[2]
        for file in files:
            if re.search(string, file, re.IGNORECASE) != None:
                matchlist.append(os.path.join(dir, file))
    return matchlist


def findFolders(path, string):
    matchlist = []
    for tuple in os.walk(path):
        dir = tuple[0]
        if re.search(string, dir,re.IGNORECASE) != None:
            matchlist.append(os.path.join(dir))
    return matchlist


        


def requiredClassAttribute(*required):
        #outter decorator takes in args which is scoped to inner decorator
        #Decorator requires we return a function that expects a function argument
        def requiredAttributeHelper(func):
                @functools.wraps(func)
                def wrapper(self,*args, **kwargs):
                    for ele in required:
                        if getattr(self,ele,None)==None:
                                raise RuntimeError(f"Required Parameter{ele} not set")
                        return func(self,*args, **kwargs)
                return wrapper
        return requiredAttributeHelper

def removeDupesList(list):
    dupe=set()
    res=[]
    for ele in list:
        if ele not in dupe:
            res.append(ele)
            dupe.add(ele)
    return res

def getIntInput(string):
    while True:
        num = input(f"\n\n{string} ")
        try:
            int(num)
            return num
        except:
            None


def Menu(items, message):
    return inquirer.select(message=f"\n{message}\n", choices=items).execute()
        
        
def validateFiles(fileList):
    for file in fileList:
        if not os.path.exists(file):
            return file

def getBdinfo(remuxConfig):
    key = str(remuxConfig["Enabled_Tracks"]["Video"][0])
    output = os.path.dirname(
        remuxConfig["Tracks_Details"]["Video"][key]["file"])
    return findFiles(output,"bdinfo")[0]
   


def getEac3to(remuxConfig):
    key = str(remuxConfig["Enabled_Tracks"]["Video"][0])
    output = os.path.dirname(
        remuxConfig["Tracks_Details"]["Video"][key]["file"])
    return findFiles(output,"eac3to")[0]
       
        
    



   