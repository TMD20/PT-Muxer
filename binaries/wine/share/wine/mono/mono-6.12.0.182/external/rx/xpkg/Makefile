

all: package

clean: android_clean iOS_clean

.PHONY: android android_build android_copy android_sign
android: Rx_Xamarin android_build android_copy #android_sign

android_build:
	xbuild Rx_Xamarin/Rx_Xamarin_android.sln /p:DelaySign=false /p:AssemblyOriginatorKeyFile=$(KEYFILE_SNK) /p:SignAssembly=$(SIGN_ASSEMBLY) /p:SignAssemblySpec=$(SIGN_ASSEMBLY_SPEC)

android_copy:
	for proj in Interfaces Core Linq PlatformServices Debugger Providers Runtime.Remoting Experimental ; \
	do \
		cp Rx_Xamarin/android/rx/System.Reactive.$$proj/bin/Debug/System.Reactive.$$proj.dll Rx_Xamarin/android/libs ; \
	done

android_sign:
	for proj in Interfaces Core Linq PlatformServices Debugger Providers Runtime.Remoting Experimental ; \
	do \
		sn -R Rx_Xamarin/android/libs/System.Reactive.$$proj.dll $(KEYFILE_SNK) ; \
	done

.PHONY: iOS iOS_build iOS_copy iOS_sign
iOS: Rx_Xamarin iOS_build iOS_sign #iOS_sign

iOS_build:
	xbuild Rx_Xamarin/Rx_Xamarin_iOS.sln

iOS_copy:
	for $$proj in Interfaces Core Linq PlatformServices Debugger Experimental \
	do \
		cp Rx_Xamarin/iOS/rx/System.Reactive.$(proj)/bin/Debug/System.Reactive.$(proj).dll Rx_Xamarin/iOS/libs \
	done

iOS_sign:
	for $$proj in Interfaces Core Linq PlatformServices Debugger Experimental \
	do \
		sn -R Rx_Xamarin/iOS/libs/System.Reactive.$(proj).dll $(KEYFILE_SNNK) \
	done

package: android iOS
	./build-package.sh

Rx_Xamarin:
	ln -s ../Rx/NET/Source/Rx_Xamarin Rx_Xamarin

android_clean: Rx_Xamarin
	xbuild Rx_Xamarin/Rx_Xamarin_android.sln /t:Clean

iOS_clean: Rx_Xamarin
	xbuild Rx_Xamarin/Rx_Xamarin_iOS.sln /t:Clean

