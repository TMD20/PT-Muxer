import json
import subprocess
import srt
import datetime
import logging
import asyncio
import websockets
import functools

from queue import Queue
from pathlib import Path
from timeit import default_timer as timer
from vosk import KaldiRecognizer, Model
from multiprocessing.dummy import Pool

CHUNK_SIZE = 4000
SAMPLE_RATE = 16000.0


class Transcriber:

    def __init__(self,model,model_name,lang):
        self.model = Model(model_path=model,
                           model_name=model_name, lang=lang)
        

    def recognize_stream(self, rec, stream, maxLines):
        tot_samples = 0
        result = []

        while len(result) < maxLines:
            data = stream.stdout.read(CHUNK_SIZE)

            if len(data) == 0:
                break

            tot_samples += len(data)
            if rec.AcceptWaveform(data):
                jres = json.loads(rec.Result())
                if len(jres["text"]) > 0:
                    result.append(jres["text"])

        jres = json.loads(rec.FinalResult())
        result.append(jres["text"])

        return result, tot_samples

    async def recognize_stream_server(self, proc):
        async with websockets.connect(self.args.server) as websocket:
            tot_samples = 0
            result = []

            await websocket.send('{ "config" : { "sample_rate" : %f } }' % (SAMPLE_RATE))
            while True:
                data = await proc.stdout.read(CHUNK_SIZE)
                tot_samples += len(data)
                if len(data) == 0:
                    break
                await websocket.send(data)
                jres = json.loads(await websocket.recv())
                logging.info(jres)
                if not 'partial' in jres:
                    result.append(jres)
            await websocket.send('{"eof" : 1}')
            jres = json.loads(await websocket.recv())
            logging.info(jres)
            result.append(jres)

            return result, tot_samples

    def format_result(self, result, words_per_line=7):
        final_result = ''
        if self.args.output_type == 'srt':
            subs = []

            for i, res in enumerate(result):
                if not 'result' in res:
                    continue
                words = res['result']

                for j in range(0, len(words), words_per_line):
                    line = words[j: j + words_per_line]
                    s = srt.Subtitle(index=len(subs),
                                     content=' '.join([l['word']
                                                      for l in line]),
                                     start=datetime.timedelta(
                                         seconds=line[0]['start']),
                                     end=datetime.timedelta(seconds=line[-1]['end']))
                    subs.append(s)
            final_result = srt.compose(subs)

        elif self.args.output_type == 'txt':
            for part in result:
                final_result += part['text'] + ' '
        return final_result

    def resample_ffmpeg(self, infile):
        cmd = "ffmpeg -nostdin -loglevel quiet -i {} -ar {} -ac 1 -f s16le -".format(
            str(infile), SAMPLE_RATE)
        stream = subprocess.Popen(cmd.split(), stdout=subprocess.PIPE)
        return stream

    async def resample_ffmpeg_async(self, infile):
        cmd = "ffmpeg -nostdin -loglevel quiet -i {} -ar {} -ac 1 -f s16le -".format(
            str(infile), SAMPLE_RATE)
        return await asyncio.create_subprocess_shell(cmd, stdout=subprocess.PIPE)

    async def server_worker(self):
        while True:
            try:
                input_file, output_file = self.queue.get_nowait()
            except:
                break

            logging.info('Recognizing {}'.format(input_file))
            start_time = timer()
            proc = await self.resample_ffmpeg_async(input_file)
            result, tot_samples = await self.recognize_stream_server(proc)

            final_result = self.format_result(result)
            if output_file != '':
                logging.info('File {} processing complete'.format(output_file))
                with open(output_file, 'w', encoding='utf-8') as fh:
                    fh.write(final_result)
            else:
                print(final_result)

            await proc.wait()

            elapsed = timer() - start_time
            logging.info('Execution time: {:.3f} sec; xRT {:.3f}'.format(
                elapsed, float(elapsed) * (2 * SAMPLE_RATE) / tot_samples))
            self.queue.task_done()

    def pool_worker(self,inputdata,maxLines):
        logging.info('Recognizing {}'.format(inputdata))

        start_time = timer()

        try:
            stream = self.resample_ffmpeg(inputdata)
        except Exception:
            logging.info('Missing ffmpeg, please install and try again')
            return
        rec = KaldiRecognizer(self.model, SAMPLE_RATE)
        rec.SetWords(True)
        result, tot_samples = self.recognize_stream(
            rec, stream, 50)

        elapsed = timer() - start_time
        logging.info('Execution time: {:.3f} sec; xRT {:.3f}'.format(
            elapsed, float(elapsed) * (2 * SAMPLE_RATE) / tot_samples))
        return result

    async def process_task_list_server(self, task_list):
        self.queue = Queue()
        [self.queue.put(x) for x in task_list]
        workers = [asyncio.create_task(self.server_worker())
                   for i in range(self.args.tasks)]
        await asyncio.gather(*workers)

    def process_task_list_pool(self, task_list,maxLines):
        funct = functools.partial(self.pool_worker,maxLines=maxLines)
        with Pool() as pool:
            return pool.map(funct, task_list)[0]

    def process_task_list(self, task_list,maxLines):
        return self.process_task_list_pool(task_list,maxLines)
