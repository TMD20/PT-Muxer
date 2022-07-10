#!/usr/bin/expect -f

# timeout after 60 seconds
set timeout 60

spawn ./discord-bot-test.sh

expect "I'm in\r"
expect "vdator-github-actions#7018\r"
