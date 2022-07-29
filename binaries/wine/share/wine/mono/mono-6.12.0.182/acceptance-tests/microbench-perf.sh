#! /bin/sh
r='/usr/local/bin/mine/remux/binaries/wine/mono/mono-6.12.0.182'
aotpattern="--aot="

# if this is an aot invoke
if [[ $@ =~ $aotpattern ]];
then
# just aot the code
echo "$r/runtime/mono-wrapper $@"
exec $r/runtime/mono-wrapper $@
else
# else run it under perf
echo "$MONO_PERF_BINARY record -o $r/acceptance-tests/perf.data -v -s -g -- $r/mono/mini/mono-sgen $@"
exec $MONO_PERF_BINARY record -o $r/acceptance-tests/perf.data -v -s -g $r/mono/mini/mono-sgen $@
fi


