#!/bin/sh

mono xpkg.exe create RxForXamarin-2.1.xam \
	--name="Reactive Extensions (Rx) for Xamarin" \
	--publisher="Xamarin, Inc." \
	--website="http://www.xamarin.com" \
	--summary="a library for composing asynchronous and event-based programs using observable sequences and LINQ-style query operators." \
	--license="../Rx/NET/Source/license.txt" \
	--library=android:Rx_Xamarin/android/libs/System.Reactive.Interfaces.dll \
	--library=android:Rx_Xamarin/android/libs/System.Reactive.Core.dll \
	--library=android:Rx_Xamarin/android/libs/System.Reactive.Linq.dll \
	--library=android:Rx_Xamarin/android/libs/System.Reactive.PlatformServices.dll \
	--library=android:Rx_Xamarin/android/libs/System.Reactive.Experimental.dll \
	--library=android:Rx_Xamarin/android/libs/System.Reactive.Debugger.dll \
	--library=android:Rx_Xamarin/android/libs/System.Reactive.Providers.dll \
	--library=iOS:Rx_Xamarin/iOS/libs/System.Reactive.Interfaces.dll \
	--library=iOS:Rx_Xamarin/iOS/libs/System.Reactive.Core.dll \
	--library=iOS:Rx_Xamarin/iOS/libs/System.Reactive.Linq.dll \
	--library=iOS:Rx_Xamarin/iOS/libs/System.Reactive.PlatformServices.dll \
	--library=iOS:Rx_Xamarin/iOS/libs/System.Reactive.Experimental.dll \
	--library=iOS:Rx_Xamarin/iOS/libs/System.Reactive.Debugger.dll \
	--details=Details.md \
	--getting-started=GettingStarted.md \
	--details=Details.md \
	--icon=RxForXamarin_128x128.png \
   	--sample="Touch Event Observable Sample. Observable event pattern conversion sample using View.Touch event:Rx_Xamarin/android/samples/ReactiveAndroidSample/ReactiveAndroidSample.sln" \
   	--sample="GitHub API Client Sample. GitHub API client sample demonstrates use of Rx API with GitHub:Rx_Xamarin/android/samples/GithubApiClientSample/GithubApiClientSample.sln"
