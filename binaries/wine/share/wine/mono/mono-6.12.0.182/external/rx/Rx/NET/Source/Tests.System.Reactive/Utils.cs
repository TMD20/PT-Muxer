// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Linq;
using System.Reactive.Subjects;
using System.Runtime.Versioning;

namespace ReactiveTests
{
    static class Utils
    {
        public static bool IsRunningWithPortableLibraryBinaries()
        {
#if DESKTOPCLR20
            return false;
#else

            var a = typeof(ISubject<int>).Assembly.GetCustomAttributes(typeof(TargetFrameworkAttribute), false).Cast<TargetFrameworkAttribute>().SingleOrDefault();
            return a != null && a.FrameworkDisplayName == ".NET Portable Subset";
#endif
        }

        public static string GetTestBaseDirectory()
        {
#if MONODROID || MONOTOUCH
            // There is no accessible file system inside android application.
            return System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
#else
            return System.AppDomain.CurrentDomain.BaseDirectory;
#endif
        }
    }
}
