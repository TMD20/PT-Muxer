

import os
import re
import functools

def mkdirSafe(target):
    if not os.path.exists(target):
            os.mkdir(target)
def getShowName(path):
        return os.path.basename(re.sub("/BDMV/STREAM","",path))    

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

        
        
        
        
        
        
        
        
        
    



   