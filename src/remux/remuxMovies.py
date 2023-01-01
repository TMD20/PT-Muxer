from src.remux.base import Remux

class Remux(Remux):
    def __init__(self,args)->None:
        super().__init__(args)
        self._name="Movies"
        self._type="Movies"