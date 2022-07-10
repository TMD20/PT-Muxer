#!/bin/bash

curl -s -X POST --data-binary "$(cat test1.in)" http://127.0.0.1:5000/text > test1.out
diff test1.out test1.ans
