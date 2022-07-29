﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;

namespace PortableLibraryProfile7
{
    public class MyExtensions
    {
        public static IObservable<DateTime> GetClock()
        {
            return Observable.Interval(TimeSpan.FromSeconds(1)).Select(_ => DateTime.Now);
        }
    }
}
