from __future__ import annotations 
import logging
from rich import print
from rich.console import Console
from rich.markdown import Markdown
from typing import TYPE_CHECKING
if TYPE_CHECKING:
    from rich.console import Capture



logger=logging.getLogger("PTMuxer")

def print(message:str,style:str="bold green")->None:
    """
    Uses rich module to print a normal output to console

    Args:
        message (str): message to print
        style (str, optional): style information for text to pass to rich. Defaults to bold green.
    """
    console = Console()
    console.print(message,style=style)



def handleLogMessage(message:str, markup:str=True,style:str="bold green",**kwargs)->Capture:
    """
    Helper function to levage rich to enhance printing of logs

    Args:
        message (str): message to pass to rich
        markup (bool, optional): markup information to pass to rich. Defaults to True.
        style (str, optional): style information to pass to rich. Defaults to bold green.

    Returns:
        obj: return a console capture
    """
    console=Console(markup=markup,style=style)
    
        
    markdown=Markdown(message,style=style)
    with console.capture() as capture:
        console.print(markdown)
    return capture.get()
        
def loggingRevamp(function,style:str=None)->function:
    """
    returns a console capture

    Args:
        function (function): function to pass arguments to
        style (str, optional): style to pass to function. Defaults to None.

    Returns:
        function: returns function for logger
    """
    return lambda message,markup=True,style=style:  function(handleLogMessage(message,markup,style=style))
    

def setUpLogging(levelArg:str)->None:
    """
    Changes default log function to modified log functions with rich enhanchment
    sets logger default

    Args:
        levelArg (str): level to set the logger to
    """
    logger.setLevel(levelArg)
    logger.propagate=False
    stream = logging.StreamHandler()
    # create formatter
    formatter = logging.Formatter('%(asctime)s - %(name)s  - %(message)s')

    # # add formatter to stream
    stream.setFormatter(formatter)
    logger.addHandler(stream)
    #prettify all logs
    logger.debug=loggingRevamp(logger.debug,style="bold yellow")
    logger.info=loggingRevamp(logger.info,style="bold green")
    logger.warning=loggingRevamp(logger.warning,style="bold white")






