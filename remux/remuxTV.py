from remux.base import Remux

class Remux(Remux):
    def __init__(self,args):
        super().__init__(args)
        self._name="Movies"
        self._type="Movies"