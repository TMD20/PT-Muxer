using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo ("Mono.Security, PublicKey=002400000480000094000000060200000024000052534131000400000100010079159977d2d03a8e6bea7a2e74e8d1afcc93e8851974952bb480a12c9134474d04062447c37e0e68c080536fcf3c3fbe2ff9c979ce998475e506e8ce82dd5b0f350dc10e93bf2eeecf874b24770c5081dbea7447fddafa277b22de47d6ffea449674a4f9fccf84d15069089380284dbdd35f46cdff12a1bd78e4ef0065d016df")]

namespace System.Security.Cryptography.X509Certificates
{
	abstract class X509Certificate2Impl
	{
	}

	static class X509Helper2
	{
		internal static long GetSubjectNameHash (X509Certificate certificate)
		{
			throw null;
		}

		internal static void ExportAsPEM (X509Certificate certificate, Stream stream, bool includeHumanReadableForm)
		{
			throw null;
		}		
	}
}

namespace Mono.Net.Security
{
	static class NoReflectionHelper
	{
		internal static object GetInternalValidator (object provider, object settings)
		{
			throw null;
		}

		internal static object GetDefaultValidator (object settings)
		{
			throw null;
		}

		internal static object GetProvider ()
		{
			throw null;
		}

		internal static bool IsInitialized {
			get {
				throw null;
			}
		}

		internal static void Initialize ()
		{
			throw null;
		}

		internal static void Initialize (string provider)
		{
			throw null;
		}

		internal static HttpWebRequest CreateHttpsRequest (Uri requestUri, object provider, object settings)
		{
			throw null;
		}

		internal static object CreateHttpListener (object certificate, object provider, object settings)
		{
			throw null;
		}

		internal static object GetMonoSslStream (SslStream stream)
		{
			throw null;
		}

		internal static object GetMonoSslStream (HttpListenerContext context)
		{
			throw null;
		}

		internal static bool IsProviderSupported (string name)
		{
			throw null;
		}

		internal static object GetProvider (string name)
		{
			throw null;
		}
	}
}
