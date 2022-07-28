<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DON'T EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->
**Table of Contents**  *generated with [DocToc](https://github.com/thlorenz/doctoc)*

- [vdator](#vdator)
    - [Table of Contents](#table-of-contents)
    - [Supported pastebin sites](#supported-pastebin-sites)
    - [Setup](#setup)
      - [Create a python3 virtual environment:](#create-a-python3-virtual-environment)
      - [Installing dependencies](#installing-dependencies)
      - [Updating dependencies](#updating-dependencies)
      - [Running manually](#running-manually)
      - [Running with systemd](#running-with-systemd)
    - [Lint](#lint)
    - [Using](#using)
    - [Adding a pastebin site](#adding-a-pastebin-site)
    - [Adding a new check](#adding-a-new-check)
    - [API](#api)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

# vdator
> Remux validator Discord bot

[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)
[![Lint](https://github.com/werrpy/vdator/actions/workflows/lint.yml/badge.svg)](https://github.com/werrpy/vdator/actions/workflows/lint.yml)
[![Integration Tests](https://github.com/werrpy/vdator/actions/workflows/integration-tests.yml/badge.svg)](https://github.com/werrpy/vdator/actions/workflows/integration-tests.yml)

Takes a Pastebin link with BDInfo and MediaInfo dump, and validates the remux.

Checks:
```
Video track names
Movie/TV name format
IMDB/TMDB ids
Filename
Video language matches first audio language
No muxing mode
Uses latest mkvtoolnix
Video and audio track names match
DTS-HD MA 1.0/2.0 optionally to FLAC, LPCM 1.0/2.0 to FLAC, LPCM > 2.0 to DTS-HD MA
Commentary to AC-3 @ 224 kbps
Commentary track people and spellcheck
Subtitle order
Subtitle default flag
Should have chapters
Chapter languages
Chapter padding
```

### Table of Contents
- [Supported pastebin sites](#supported-pastebin-sites)
- [Setup](#setup)
  * [Create a python3 virtual environment](#create-a-python3-virtual-environment)
  * [Installing dependencies](#installing-dependencies)
  * [Updating dependencies](#updating-dependencies)
  * [Running manually](#running-manually)
  * [Running with systemd](#running-with-systemd)
- [Lint](#lint)
- [Using](#using)
- [Adding a pastebin site](#adding-a-pastebin-site)
- [Adding a new check](#adding-a-new-check)
- [API](#api)

### Supported pastebin sites

- [{d}paste](https://dpaste.com/)
- [dpaste](https://dpaste.org/)
- [Hey! Paste it](https://www.heypasteit.com/)
- [CentOS Pastebin Service](https://paste.centos.org/)
- [Paste.ee](https://paste.ee/)
- [openSUSE Paste](https://paste.opensuse.org/)
- [Pastebin](https://pastebin.com/)
- [Rentry.co - Markdown Pastebin](https://rentry.co/)
- [termbin](https://termbin.com/)
- [TextBin](https://textbin.net/)
- [Hastebin](https://www.toptal.com/developers/hastebin/)

### Setup

Requires Python >= 3.7

Create a [Discord bot](https://discordapp.com/developers/docs/intro) and add it to a server.
Copy the enviornment variables template `vdator/.env.EXAMPLE` to `vdator/.env`
Edit `vdator/.env` and set `DISCORD_BOT_SECRET` to your bot's token.

Request a [TMDB API Key](https://developers.themoviedb.org/3/getting-started/introduction) and set `TMDB_API_KEY`.

Don't forget to create channels on the server and set them in `vdator/.env` for `REVIEW_CHANNELS`, `REVIEW_REPLY_CHANNELS`, and `BOT_CHANNELS`.

To prevent overwriting the `vdator/.env` file when pulling changes from git, do `git update-index --skip-worktree vdator/.env`. When you want to pull a new `.env` file, do `git update-index --no-skip-worktree vdator/.env`.

#### Create a python3 virtual environment:

Use [pip and virtual env](https://packaging.python.org/guides/installing-using-pip-and-virtualenv/) to run vdator.

In the `vdator` directory run:
```bash
python3 -m venv .
```

If the command fails to install pip, you will see an error similar to:
```
Error: Command '['python3', '-Im', 'ensurepip', '--upgrade', '--default-pip']' returned non-zero exit status 1.
```
Start over by creating a virtual environment without pip, and then install pip manually inside it:
```bash
python3 -m venv --without-pip .
source bin/activate
curl https://bootstrap.pypa.io/get-pip.py | python3
deactivate
```

#### Installing dependencies

Install [PyHunSpell](https://github.com/blatinier/pyhunspell#installation)

Install dependencies

```bash
source bin/activate
pip3 install -r requirements.txt
deactivate
```

#### Updating dependencies

```bash
source bin/activate
pip3 install -r requirements.txt --upgrade
pip3 freeze > requirements.txt
deactivate
```

#### Running manually

Run the bot manually for testing, exceptions will get printed:
```bash
source bin/activate
python3 main.py
```

#### Running with systemd

Create a systemd service to run vdator, `/etc/systemd/system/vdator.service`

```
[Unit]
Description=vdator
After=multi-user.target

[Service]
WorkingDirectory=/home/USER/vdator/venv/vdator
User=
Group=
ExecStart=/home/USER/vdator/venv/bin/python3 /home/USER/vdator/venv/vdator/main.py
Type=idle
Restart=always
RestartSec=15

[Install]
WantedBy=multi-user.target
```

Set `User` to the user to run vdator as, and `Group` to the user's group (list with `groups`), usually both are the username.
Replace `/home/USER/vdator/venv/` with the full path to your venv.

Run `systemctl enable vdator` to start on boot. Use systemctl to start/stop vdator, `systemctl start vdator`, `systemctl stop vdator`, `systemctl restart vdator`

### Lint
```bash
black .
```

### Using

Type `!help` in one of the bot channels for more information.

### Adding a pastebin site

Edit `vdator/data/urls.json` and add your pastebin site.

```
# hostname
"example.com": {
    # regex to get paste's unique identifier
    "slug_regex": "https://example.com/(.*)",

    # regex to check if paste links directly to raw text, using {} in place of the unique identifier
    "raw_url_regex": "https?://pastebin.com/raw/{}",
    
    # link to raw text, using {} in place of the unique identifier
    "raw_url": "https://example.com/raw/{}"
}
```

### Adding a new check

Edit `vdator/checker.py`.

In the `run_checks()` method add:
```python
reply += MyNewCheck(self.reporter, self.mediainfo).run()
```

Edit `vdator/checks/__init__.py` and add:
```python
from .my_check import *
```

Create `vdator/checks/my_check.py`:
```python
from .check import *


class MyNewCheck(Check):
    def __init__(self, reporter, mediainfo):
        super().__init__(reporter, mediainfo, "Error running my check")

    # overriding abstract method
    def get_reply(self):
        reply = ""
        # use self.mediainfo here
        # use has() and has_many() to check if the mediainfo keys you need exist, for example:
        # if has_many(self.mediainfo, "video.0", ["height"]):
            # safe to use self.mediainfo["video"][0]["height"] here
        # use self.reporter.print_report() to print status messages
        reply += self.reporter.print_report("info", "Some info message")
        # lastly return the string result of the check which is appended to the bot reply in run_checks()
        return reply
```

### API

Run with `python api.py`

Default is port 5000, to use a different port set the PORT environment variable with `export PORT=5000 && python api.py`

Example using Postman:
```
POST http://127.0.0.1:5000/text
    Body, raw
    [INSERT TEXT HERE]
```

Gives back json:
```json
{
	"discord_reply":"...",
	"html_reply":"..."
}
```
**discord_reply** - the text that the bot usually sends to discord  
**html_reply** - discord text formatted as html

Insert the `html_reply` text into the `example_html_viewer.html` to see it formatted similar to discord.

For testing, force a specific version of mkvmerge with

````bash
export MKVMERGE_VERSION="Version 54.0.0 \"Hill The End\" 2021-05-22" && python api.py
````
