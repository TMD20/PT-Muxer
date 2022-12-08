import logging
from rich import print
from rich.console import Console
from rich.markdown import Markdown



logger=logging.getLogger("PTMuxer")

def print(message,style=None):
    if style==None:
        style="bold green"
    console = Console()
    console.print(message,style=style)



def handleLogMessage(obj, markup=True,style=None,**kwargs):
    console=Console(markup=markup,style=style)
    if style==None:
        style="bold green"
    markdown=Markdown(obj,style=style)
    with console.capture() as capture:
        console.print(markdown)
    return capture.get()
        
def loggingRevamp(function,style=None):
    return lambda message,markup=True,style=style:  function(handleLogMessage(message,markup,style=style))
    

def setUpLogging(levelArg):
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






