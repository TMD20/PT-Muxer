﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.IdentityModel.Selectors;

namespace System.Web.Http
{
    public class CustomUsernamePasswordValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (userName == "username" && password == "password")
            {
                return;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
