# import os

# from pymediainfo import MediaInfo
# import orjson


# import remux.helpers as remuxHelper
# import tools.general as utils
# import remux.Movie.helpers as MovieHelper
# import tools.directory as dir
# import tools.logger as logger




# def Remux(args):
#     # Variables


  
#     with dir.cwd(args.outpath):

#         MovieHelper.ProcessBatch(fileName, remuxConfig, muxGenerator, args.outargs)
#         message = """If the Program made it this far the Movie MKV...
#         Should be in the output directory picked \
#         # Before Closing We will now print off file location and mediainfo"""
#         logger.print(message)
#         mediainfo = MediaInfo.parse(fileName, output="", full=False)
#         logger.print(f"\n\n{mediainfo}\n\n")
#         logger.print(f"As a Reminder the output location: {fileName}")



