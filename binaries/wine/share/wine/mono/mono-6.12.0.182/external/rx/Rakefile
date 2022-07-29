require "rake/clean"

CLEAN.include "*.xam"
CLEAN.include "xpkg"

COMPONENT = "rx-1.0.xam"

file "xpkg/xpkg.exe" do
	puts "* Downloading xpkg..."
	mkdir "xpkg"
	sh "curl -L https://components.xamarin.com/submit/xpkg > xpkg.zip"
	sh "unzip -o xpkg.zip -d xpkg"
	sh "rm xpkg.zip"
end

task :default => "xpkg/xpkg.exe" do
	line = <<-END
		mono xpkg/xpkg.exe create #{COMPONENT} \
			--name="Reactive Extensions (Rx)" \
			--publisher="Xamarin, Inc." \
			--website="http://www.xamarin.com" \
			--summary="A library for composing asynchronous and event-based programs using observable sequences and LINQ-style query operators." \
			--license="Rx/NET/Source/license.txt" \
			--library=android:external/rx/Rx/NET/Source/Rx_Xamarin/android/libs/System.Reactive.Interfaces.dll \
			--library=android:external/rx/Rx/NET/Source/Rx_Xamarin/android/libs/System.Reactive.Core.dll \
			--library=android:external/rx/Rx/NET/Source/Rx_Xamarin/android/libs/System.Reactive.Linq.dll \
			--library=android:external/rx/Rx/NET/Source/Rx_Xamarin/android/libs/System.Reactive.PlatformServices.dll \
			--library=android:external/rx/Rx/NET/Source/Rx_Xamarin/android/libs/System.Reactive.Experimental.dll \
			--library=android:external/rx/Rx/NET/Source/Rx_Xamarin/android/libs/System.Reactive.Debugger.dll \
			--library=android:external/rx/Rx/NET/Source/Rx_Xamarin/android/libs/System.Reactive.Providers.dll \
			--details=component/Details.md \
			--getting-started=component/GettingStarted.md \
			--icon=component/rx_128x128.png \
			--sample="GitHub API Client. Demonstrates Rx with GitHub":"external/rx/Rx/NET/Source/Rx_Xamarin/android/samples/GithubApiClientSample/GithubApiClientSample.sln"
	END
	puts "* Creating #{COMPONENT}..."
	puts line.strip.gsub "\t\t", "\\\n    "
	sh line, :verbose => false
	puts "* Created #{COMPONENT}"
end
