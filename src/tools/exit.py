
class GracefulExit:
    """
    This class creates a context provider for running a command on entrance.
    on exit performs function

    Exit has a wide definition and includes graceful exits, forced exits, raised errors, etc
    """
    def __init__( self,endProgram ):
        self.endProgram=endProgram
    def __enter__(self):
        pass
    def __exit__(self, exc_type, exc_value, tb):
        self.endProgram()
        


    

