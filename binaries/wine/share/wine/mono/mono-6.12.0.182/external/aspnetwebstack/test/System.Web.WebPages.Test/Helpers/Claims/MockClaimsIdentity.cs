﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace System.Web.Helpers.Claims.Test
{
    // Convenient class for mocking a ClaimsIdentity instance given some
    // prefabricated Claim instances.
    internal sealed class MockClaimsIdentity : ClaimsIdentity
    {
        private readonly List<Claim> _claims = new List<Claim>();

        public void AddClaim(string claimType, string value)
        {
            _claims.Add(new Claim(claimType, value));
        }

        public override IEnumerable<Claim> GetClaims()
        {
            return _claims;
        }
    }
}
