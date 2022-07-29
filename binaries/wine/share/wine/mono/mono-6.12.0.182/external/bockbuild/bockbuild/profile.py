import os
from optparse import OptionParser
from util.util import *
from util.csproj import *
from environment import Environment
from bockbuild.package import *
import collections
import hashlib
import itertools


class Profile:
    def __init__ (self):
        Profile.loaded = self

    def attach (self, bockbuild):
        Profile.bockbuild = bockbuild

    class FileProcessor (object):

        def __init__(self, harness=None, match=None, process=None,  extra_files=None):
            self.harness = harness
            self.match = match
            self.files = list(extra_files) if extra_files else list()
            self.root = None

        def relpath(self, path):
            return os.path.relpath(path, self.root)

        def run(self):
            for path in self.files:
                self.harness(path, self.process)

        def end(self):
            return

    def postprocess(self, processors, directory, filefilter=None):
        def simple_harness(path, func):
            if not os.path.lexists(path):
                return  # file removed by previous processor function
            # TODO: Fix so that it works on symlinks
            # hash = hashlib.sha1(open(path).read()).hexdigest()
            func(path)
            if not os.path.lexists(path):
                trace('Removed file: %s' % path)
            # if hash != hashlib.sha1(open(path).read()).hexdigest():
            #	warn ('Changed file: %s' % path)

        for proc in processors:
            proc.root = directory
            if proc.harness is None:
                proc.harness = simple_harness
            if proc.match is None:
                error('proc %s has no match function' %
                      proc.__class__.__name__)

        for path in filter(filefilter, iterate_dir(directory, with_dirs=True, with_links=True)):
            filetype = get_filetype(path)
            for proc in processors:
                if proc.match(path, filetype) == True:
                    trace('%s  matched %s / %s' % (proc.__class__.__name__,
                                                   os.path.basename(path), filetype))
                    proc.files.append(path)

        for proc in processors:
            verbose('%s: %s items' %
                    (proc.__class__.__name__, len(proc.files)))
            proc.run()

        for proc in processors:
            proc.end()
            proc.harness = None
            proc.files = []

Profile.loaded = None
Profile.bockbuild = None