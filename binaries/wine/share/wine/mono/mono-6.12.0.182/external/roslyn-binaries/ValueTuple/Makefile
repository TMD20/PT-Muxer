COMPILE = mkdir -p $(dir $(1)) && mcs -target:library -out:$(1) -nostdlib -r:$(2)/mscorlib.dll ValueTuple.cs

.PHONY: all
all: bin/Net45/ValueTuple.dll bin/Xamarin.Mac/ValueTuple.dll bin/Xamarin.iOS/ValueTuple.dll bin/Xamarin.Android/ValueTuple.dll

bin/Net45/ValueTuple.dll: ValueTuple.cs
	$(call COMPILE,$@,/Library/Frameworks/Mono.framework/Versions/Current/lib/mono/4.5)

bin/Xamarin.Mac/ValueTuple.dll: ValueTuple.cs
	$(call COMPILE,$@,/Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/Xamarin.Mac)

bin/Xamarin.iOS/ValueTuple.dll: ValueTuple.cs
	$(call COMPILE,$@,/Library/Frameworks/Xamarin.iOS.framework/Versions/Current/lib/mono/Xamarin.iOS)

bin/Xamarin.Android/ValueTuple.dll: ValueTuple.cs
	$(call COMPILE,$@,/Library/Frameworks/Xamarin.Android.framework/Versions/Current/lib/mono/2.1)

.PHONY: clean
clean:
	rm -rf bin
