#!/bin/sh

mono xpkg.exe create ReactiveExtensionsForXamarin-1.0.xam \
	--name="Reactive Extensions (Rx)" \
	--publisher="Xamarin, Inc." \
	--website="http://www.xamarin.com" \
	--summary="A library for composing asynchronous and event-based programs using observable sequences and LINQ-style query operators." \
	--license="external/rx/Rx/NET/Source/license.txt" \
	--library=android:external/rx/Rx/NET/Source/Rx_Xamarin/android/libs/System.Reactive.Interfaces.dll \
	--library=android:external/rx/Rx/NET/Source/Rx_Xamarin/android/libs/System.Reactive.Core.dll \
	--library=android:external/rx/Rx/NET/Source/Rx_Xamarin/android/libs/System.Reactive.Linq.dll \
	--library=android:external/rx/Rx/NET/Source/Rx_Xamarin/android/libs/System.Reactive.PlatformServices.dll \
	--library=android:external/rx/Rx/NET/Source/Rx_Xamarin/android/libs/System.Reactive.Experimental.dll \
	--library=android:external/rx/Rx/NET/Source/Rx_Xamarin/android/libs/System.Reactive.Debugger.dll \
	--library=android:external/rx/Rx/NET/Source/Rx_Xamarin/android/libs/System.Reactive.Providers.dll \
	--details=Details.md \
	--getting-started=Details.md \
	--icon=logo_128x128.png \
    	--sample="GitHub API Client Sample. GitHub API client sample demonstrates use of Rx API with GitHub:external/rx/Rx/NET/Source/Rx_Xamarin/android/samples/GithubApiClientSample/GithubApiClientSample.sln"
