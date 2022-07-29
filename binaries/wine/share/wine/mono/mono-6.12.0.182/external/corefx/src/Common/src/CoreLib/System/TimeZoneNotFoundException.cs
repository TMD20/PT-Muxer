// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.Serialization;

namespace System
{
    [Serializable]
#if MONO && MOBILE
    [System.Runtime.CompilerServices.TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
#else
    [System.Runtime.CompilerServices.TypeForwardedFrom("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
#endif
    public class TimeZoneNotFoundException : Exception
    {
        public TimeZoneNotFoundException()
        {
        }

        public TimeZoneNotFoundException(String message)
            : base(message)
        {
        }

        public TimeZoneNotFoundException(String message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected TimeZoneNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
