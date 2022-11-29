import os
import itertools
import subprocess

import tools.commands as commands
import tools.general as utils
import tools.paths as paths
    
def process(output,source,outputs_list, playlistLocation):   
    eac3toPath = get_eac3toPath(output, source)
    paths.mkdirSafe(eac3toPath)

    os.chdir(output)
    run(playlistLocation, outputs_list, eac3toPath)
    cleanFiles(outputs_list)
    return output

 


def run(playlistLocation, outputs_list, eac3toPath):

    # get list of files
    eac3toWChapters = ["1:chapters.txt"]
    eac3toWChapters.extend(outputs_list)
    eac3toWoChapters = outputs_list
    eactoCommand = None
    playlistlocationFinal = utils.convertPathType(playlistLocation, "Linux")
    if utils.getSystem() == "Linux":
        playlistlocationFinal = utils.convertPathType(
            playlistLocation, "Windows")
    eactoCommand = commands.eac3to()

    command1 = list(itertools.chain.from_iterable([eactoCommand, [
                    playlistlocationFinal], eac3toWChapters, ["-progressnumbers", f"-log={eac3toPath}"]]))

    command2 = list(itertools.chain.from_iterable([eactoCommand, [
                    playlistlocationFinal], eac3toWoChapters, ["-progressnumbers", f"-log={eac3toPath}"]]))
    command3 = list(itertools.chain.from_iterable([eactoCommand, [
                    playlistlocationFinal], eac3toWChapters, ["-progressnumbers", "-demux", f"-log={eac3toPath}"]]))
    command4 = list(itertools.chain.from_iterable([eactoCommand, [
                    playlistlocationFinal], eac3toWoChapters, ["-progressnumbers", "-demux", f"-log={eac3toPath}"]]))
    commandslist = [command1, command2, command3, command4]
    status = 1
    for command in commandslist:
        with subprocess.Popen(command, stdout=subprocess.PIPE, stderr=subprocess.STDOUT, universal_newlines=True, bufsize=1) as p:
            for line in p.stdout:
                print(line, end='')
            p.wait()
            status = p.returncode
            if status == 0:
                break


def get_eac3toPath(output, source):
    show=utils.sourcetoShowName(source)
    return os.path.join(output, "output_logs", f"Eac3to.{show}.txt")


def cleanFiles(outputs_list):
    outputs_list = [f"{ele[1]}"for ele in outputs_list]
    outputs_list.append("chapters.txt")
    for file in os.listdir("."):
        if os.path.isfile(file) and file not in outputs_list:
            os.remove(file)