
class GracefulExit:
    def __init__( self,endProgram ):
        self.endProgram=endProgram
    def __enter__(self):
        pass
    def __exit__(self, exc_type, exc_value, tb):
        self.endProgram()
        


    

