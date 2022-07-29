#!/usr/bin/env python
# coding: utf8

import shutil
import io

from xml.etree import ElementTree
from xml.etree.ElementTree import Element
from xml.etree.ElementTree import Comment


class csproj_writer:

    def __init__(self, file, vars, condition="Debug|AnyCPU"):

        self.vars = vars
        self.file = file

        self.tree = ElementTree.parse(file)

        # get the namespace from the root Project element
        self.ns = self.tree.getroot().tag[1:].split("}")[0]

        # the python elementtree always puts a prefix,
        # hardcode it so we can substitute it later
        ElementTree.register_namespace("csproj0", self.ns)

        # find PropertyGroup
        group = self.tree.findall(".//{%s}PropertyGroup[@Condition]" % self.ns)

        for node in group:
            # only insert into Debug|AnyCPU
            if condition in (node.get("Condition")):
                self.insert_env_if_missing(node)
                self.substitute_env_var(node)

    def substitute_env_var(self, propertygroup):
        node = propertygroup.find(
            "./{%s}EnvironmentVariables/{%s}EnvironmentVariables" % (self.ns, self.ns))

        for name in self.vars.get_names():

            value = self.vars.__dict__[name]

            # check if variable is already set
            var = node.find("{%s}Variable[@name='%s']" % (self.ns, name))
            if var is not None:
                # update its value
                var.set('value', "%s" % value)
            else:
                # insert new node
                el = Element("{%s}Variable" % self.ns)
                el.set('name', name)
                el.set('value', "%s" % value)
                self.insert(node, 0, el)

    def insert_env_if_missing(self, node):
        # test if environment variable is present - it is usually double
        # wrapped
        outer = node.find("{%s}EnvironmentVariables" % self.ns)
        if outer is not None:
            # see if the inner node is present, too
            inner = node.find("{%s}EnvironmentVariables" % self.ns)
            if inner is None:
                inner = Element("{%s}EnvironmentVariables" % self.ns)
                self.insert(outer, 0, inner)

        else:
            outer = Element("{%s}EnvironmentVariables" % self.ns)
            inner = Element("{%s}EnvironmentVariables" % self.ns)
            #self.insert (outer, 0, Comment ("AUTO GENERATED VARIABLES - DO NOT INCLUDE IN ANY GIT COMMITS!"))
            self.insert(node, 1, outer)
            self.insert(outer, 0, inner)

    # wrapper arround Element.insert that appends a linebreak comment
    # HACK etree xml library can not pretty print
    def insert(self, node, pos, element):
        brcomment = Comment("REPLACE_WITH_LINEBREAK")
        node.insert(pos, brcomment)
        node.insert(pos, element)

    def write(self):

        xml = ElementTree.tostring(self.tree.getroot(), encoding="utf-8")

        # HACK the python xml library is nuts - manually remove the forced namespace
        # prefix and re-establish a minimal form of pretty printing
        xml = xml.replace("csproj0:", "")
        xml = xml.replace("xmlns:csproj0", "xmlns")
        xml = xml.replace("<!--REPLACE_WITH_LINEBREAK-->", "\n")

        f = open(self.file, 'w')
        f.write(xml)
