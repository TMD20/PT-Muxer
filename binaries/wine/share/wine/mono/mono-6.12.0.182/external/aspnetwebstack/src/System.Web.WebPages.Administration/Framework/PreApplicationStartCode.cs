﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.ComponentModel;

namespace System.Web.WebPages.Administration
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class PreApplicationStartCode
    {
        // NOTE: Do not add public fields, methods, or other members to this class.
        // This class does not show up in Intellisense so members on it will not be
        // discoverable by users. Place new members on more appropriate classes that
        // relate to the public API (for example, a LoginUrl property should go on a
        // membership-related class).

        private static bool _startWasCalled;

        public static void Start()
        {
            // Even though ASP.NET will only call each PreAppStart once, we sometimes internally call one PreAppStart from 
            // another PreAppStart to ensure that things get initialized in the right order. ASP.NET does not guarantee the 
            // order so we have to guard against multiple calls.
            // All Start calls are made on same thread, so no lock needed here.
            if (_startWasCalled)
            {
                return;
            }
            _startWasCalled = true;

            // Register the admin module
            SiteAdmin.RegisterAdminModule();
        }
    }
}
