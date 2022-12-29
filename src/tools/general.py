import os
import re
import functools
import pathlib
import sys
import textwrap
import shutil
import sys
import unicodedata


from InquirerPy import inquirer
import arrow
from guessit import guessit

import src.tools.paths as paths


def convertArrow(input, parse=None):
    """
    converts time string into arrow object

    Args:
        input (str): time string to convert
        parse (str, optional): parse string to pass to arrow init. Defaults to None.

    Returns:
        obj: returns arrow obj
    """
    if parse:
        return arrow.get(input, parse)
    return arrow.get(input)

def subArrowTime(large, small):
    """
    subtracts smaller arrow obj time from larger (epoch time)

    Args:
        large (obj): larger arrow obj
        small (obj): smaller obj

    Returns:
        obj: new arrow obj
    """
    large = large.shift(hours=-small.hour)
    large = large.shift(minutes=-small.minute)
    large = large.shift(seconds=-small.second)
    large = large.shift(microseconds=-small.microsecond)
    return large


def addArrowTime(value, value2):
    """
    adds two arrow objects (epoch time)

    Args:
        value (obj): first arrow object
        value (obj): second arrow object

    Returns:
        obj: new arrow obj
    """    
    value = value.shift(hours=+value2.hour)
    value= value.shift(minutes=+value2.minute)
    value = value.shift(seconds=+value.second)
    value= value.shift(microseconds=+value2.microsecond)
    return value


def dehumanizeArrow(input):
    """
    attempts to convert humanize string into arrow object
    i.e 1hour to arrow object

    Args:
        input (str): humanized string

    Returns:
        obj: arrow object
    """
    now = arrow.utcnow()
    return now.dehumanize(input)
def getFormated(format,time=None):
    """
    Uses arrow to output time string using format as template
    if None time is set to current

    Args:
        format (str): format for time output
        time (str, optional): time str for arrow to process and convert. Defaults to None.

    Returns:
        str: formatted time string 
    """
    if time==None:
        return arrow.get().format(format)
    return arrow.get(time).format(format)


        


def sourcetoShowName(path):
    """
    Performs a base name operation on apth

    Args:
        path (str): path to perform base name action on

    Returns:
        str: base name of path
    """
    path = paths.convertPathType(path, "Linux")
    show=path
    if re.search(path,"D[0-9]|Disc"):
        show = str(pathlib.Path(path).parents[0])
    show = os.path.basename(show)
    show = re.sub(" +", " ", show)
    show = re.sub(" ", ".", show)

    return show


def requiredClassAttribute(*required):
    """
    Helper wrapper function for classes to require certain attributes be set before wrapped function can run

    Raises:
        RuntimeError: error if required value is not set

    Returns:
        function: returns wrapper function
    """
    # outter decorator takes in args which is scoped to inner decorator
    # Decorator requires we return a function that expects a function argument
    def requiredAttributeHelper(func):
        @functools.wraps(func)
        def wrapper(self, *args, **kwargs):
            for ele in required:
                if getattr(self, ele, None) == None:
                    raise RuntimeError(f"Required Parameter{ele} not set")
                return func(self, *args, **kwargs)
        return wrapper
    return requiredAttributeHelper


def removeDupesList(list):
    """
    Function to remove dupes from list

    Args:
        list (array): list of strs to evaluate

    Returns:
        array: deduped list
    """
    dupe = set()
    res = []
    for ele in list:
        if ele not in dupe:
            res.append(ele)
            dupe.add(ele)
    return res


def getIntInput(string, maxVal=float("inf")):
    """
    prompts user for an int input

    Args:
        string (str): message for input
        maxVal (int, optional): max value allowed for input. Defaults to float("inf").

    Returns:
        int: value entered by user
    """
    return int(inquirer.number(
        min_allowed=1,
        max_allowed=maxVal,
        message=string,
        mandatory=True
    ).execute())


def singleSelectMenu(items, message,default=None):
    """
    Prompts use to select one option from list

    Args:
        items (array): list of items to select from
        message (str): message for prompt
        default (str, optional): default option selected on init. Defaults to None.

    Returns:
        any: option selected by user
    """
    return inquirer.select(mandatory=True, message=textwrap.dedent(f"\n{message}\n"), choices=items,default=default).execute()


def multiSelectMenu(items, message):
    """
    Prompts use to select one or more options from list

    Args:
        items (array): list of items to select from
        message (str): message for prompt
        default (str_, optional): default option selected on init. Defaults to None.

    Returns:
        array: options selected by user
    """
    instructions=\
        """
        Press Space to add/remove selection
        Press Enter when Done
        """
    return inquirer.checkbox(validate=lambda x: len(x) > 0, invalid_message="Must Select at Least One item", mandatory=True, message=textwrap.dedent(f"\n{message}\n{instructions}\n"), choices=items).execute()


def textEnter(message, default=None):
    """
    Prompts user to enter str

    Args:
        message (str): message for prompt
        default (_type_, optional): default input. Defaults to None.

    Returns:
        str: confirmed input
    """
    if default != None:
        return inquirer.text(mandatory=True, validate=lambda x: len(x) > 0, invalid_message="Input can not be empty", message=textwrap.dedent(f"\n{message}\n"), default=default).execute()
    return inquirer.text(mandatory=True, validate=lambda x: len(x) > 0, invalid_message="Input can not be empty", message=textwrap.dedent(f"\n{message}\n")).execute()


def getTitle(source):
    """
    Helper function to propagate up directory tree to find  directory with title from source directory

    Args:
        source (str): path to source

    Returns:
        str: directory with title
    """

    parent = str(pathlib.Path(source).parents[1])
    if re.search("(BD25|BD50)", parent, re.IGNORECASE):
        None
    elif re.search("D[0-9]", source, re.IGNORECASE) or re.search("Disk [0-9]", parent, re.IGNORECASE):
        parent = str(pathlib.Path(parent).parents[0])
    return guessit(parent)["title"]


def cleanString(val):
    """
    Helper function to  perform normalization on unicode

    Args:
        val (str): str to cleanup

    Returns:
        str: cleaned str
    """
    clean_text = unicodedata.normalize("NFKD", val)
    return clean_text


def smart_truncate(content, length=100, suffix='...'):
    """
    Trunicates long str with suffix

    Args:
        content (_type_): str to trunicate
        length (int, optional): length to trunicate at. Defaults to 100.
        suffix (str, optional): str to use for trunication. Defaults to '...'.

    Returns:
        str: trunicated str
    """
    if len(content) <= length:
        return content
    else:
        return content[:length].rsplit(' ', 1)[0]+suffix



def getSystem():
    """
    Function to get current OS

    Returns:
        str: str of current OS
    """
    if sys.platform == "linux":
        return "Linux"
    else:
        return "Windows"
def getShell():
    """
    Function to get system shell 

    Returns:
        str: system shell
    """
    if sys.platform=="linux":
        return "bash"
    else:
        return None


