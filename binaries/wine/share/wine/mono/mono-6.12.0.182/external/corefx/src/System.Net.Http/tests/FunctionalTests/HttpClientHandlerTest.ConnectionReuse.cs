// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Net.Sockets;
using System.Net.Test.Common;
using System.Text;
using System.Threading.Tasks;

#if !MONO
using Microsoft.DotNet.XUnitExtensions;
using Microsoft.DotNet.RemoteExecutor;
#endif

using Xunit;
using Xunit.Abstractions;

namespace System.Net.Http.Functional.Tests
{
    using Configuration = System.Net.Test.Common.Configuration;

    public class HttpClientHandler_ConnectionReuse_Test : HttpClientTestBase
    {
        [Fact]
        public async Task Test17710()
        {
            using (HttpClient client = CreateHttpClient())
            {
                const string text = "THE POST CONTENT";
                var data = new StringContent(text);
                await LoopbackServer.CreateServerAsync(async (server, url) =>
                {
                    Task serverTask1 = server.AcceptConnectionAsync(async connection1 =>
                    {
                        await connection1.ReadRequestHeaderAsync();
                        var buffer = new char[text.Length];
                        var ret = await connection1.Reader.ReadBlockAsync(buffer, 0, buffer.Length);
                        Assert.Equal(text.Length, ret);
                        await connection1.SendResponseAsync(HttpStatusCode.OK, null, "hello");
                        await Task.Delay(500);
                        connection1.Dispose();
                    });

                    await client.PostAsync(url, data);

                    await serverTask1;

                    Task serverTask2 = server.AcceptConnectionAsync(async connection2 =>
                    {
                        await connection2.ReadRequestHeaderAsync();
                        var buffer = new char[text.Length];
                        var ret = await connection2.Reader.ReadBlockAsync(buffer, 0, buffer.Length);
                        Assert.Equal(text.Length, ret);
                        await connection2.SendResponseAsync(HttpStatusCode.OK, null, "hello");
                        await Task.Delay(500);
                        connection2.Dispose();
                    });

                    await client.PostAsync(url, data);
                });
            }
        }
    }
}
