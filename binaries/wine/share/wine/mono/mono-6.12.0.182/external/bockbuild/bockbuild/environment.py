import os
from util.util import *
from util.csproj import *
from collections import deque


class EnvironmentItem:

    def __init__(self, name, joinchar, values):
        self.name = name
        self.joinchar = joinchar
        self.values = values

    def __str__(self):
        return os.path.expandvars(self.joinchar.join(self.values))


class Environment:

    def __init__(self, profile):
        self._profile = profile

    def set(self, *argv):
        args = deque(argv)
        name = args.popleft()
        joinchar = args.popleft()
        if len(args) == 0:
            values = list(self.iter_flatten(joinchar))
            joinchar = ''
        else:
            values = list(self.iter_flatten(list(args)))

        self.__dict__[name] = EnvironmentItem(name, joinchar, values)
        return self.__dict__[name]

    def compile(self):
        expand_macros(self, self._profile)

    def write_source_script(self, filename):
        trace (filename)
        envscript = '#!/bin/sh\n'

        for k in self.get_names():
            envscript = envscript + 'export %s="%s"\n' % (k, self.__dict__[k])

        with open(filename, 'w') as f:
            f.write(envscript)
            trace(envscript)

        os.chmod(filename, 0o755)

    def serialize(self):
        names = sorted(self.get_names())
        for k in names:
            yield '%s = "%s"' % (k, self.__dict__[k])

    def dump_csproj(self):
        for k in self.get_names():
            print '<Variable name="%s" value="%s" />' % (k, self.__dict__[k])

    def write_csproj(self, file):
        writer = csproj_writer(file, self)
        writer.write()

    def export(self):
        for k in self.get_names():
            os.environ[k] = str(self.__dict__[k])

    def get_names(self):
        for k in self.__dict__.keys():
            if not k.startswith('_'):
                yield k

    def iter_flatten(self, iterable):
        if not isinstance(iterable, (list, tuple)):
            yield iterable
            return
        it = iter(iterable)
        for e in it:
            if isinstance(e, (list, tuple)):
                for f in self.iter_flatten(e):
                    yield f
            else:
                yield e
