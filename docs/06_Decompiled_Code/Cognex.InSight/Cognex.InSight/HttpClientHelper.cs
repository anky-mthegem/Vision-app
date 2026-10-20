using System;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Cognex.InSight.Properties;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

public class HttpClientHelper
{
	private static readonly X509Certificate2 Ntab0RedGW;

	private static readonly HttpClientHandler iK6bwamkGG;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool INEb9QCKb4(HttpRequestMessage P_0, X509Certificate2 P_1, X509Chain P_2, SslPolicyErrors P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return rvTFkDDUl1PbXInTl1D(P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool D6mbUdw6QV(object P_0, X509Certificate P_1, X509Chain P_2, SslPolicyErrors P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return rvTFkDDUl1PbXInTl1D(new X509Certificate2(P_1), P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static HttpClient CreateHttpClient(Uri baseUri = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xOEUdFDDghLwqNFZm9k();
		int num;
		if (GGBhBGDAPsy6nb8rVDB())
		{
			num = 1;
		}
		else
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_008b;
			}
		}
		goto IL_005c;
		IL_005c:
		HttpClient httpClient = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				goto IL_0028;
			case 3:
				if (HlmNoFDToRFwUlqqOUH(baseUri, null))
				{
					break;
				}
				goto case 5;
			case 5:
				return httpClient;
			}
			break;
			IL_0028:
			httpClient = new HttpClient(iK6bwamkGG, disposeHandler: false);
			num = 3;
		}
		goto IL_008b;
		IL_008b:
		TSKpAoDdVcDgHOTeqVQ(httpClient, baseUri);
		num = 5;
		goto IL_005c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddCognexCertValidation(HttpWebRequest request)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		crjXvkDietyEeqQlhwU(request, new RemoteCertificateValidationCallback(D6mbUdw6QV));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool InternalVerifyCognexChain(X509Certificate2 certificate, X509Chain chain, SslPolicyErrors sslErrors)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (0 == 0)
		{
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					break;
				case 1:
					if (sslErrors == SslPolicyErrors.None)
					{
						num = 6;
						continue;
					}
					p25jKfDBveEXX6dIkAt(hm7YRGDqFQHbgA4ZEmL(chain), X509RevocationMode.NoCheck);
					num = 2;
					if (GGBhBGDAPsy6nb8rVDB())
					{
						continue;
					}
					goto case 7;
				case 2:
					kicFcLDci8TTuMHggVU(KmOAEsDjPZdvMPuvDNM(chain.ChainPolicy), Ntab0RedGW);
					goto default;
				default:
					xOEUdFDDghLwqNFZm9k();
					num = (GGBhBGDAPsy6nb8rVDB() ? 5 : 0);
					continue;
				case 3:
				case 5:
					if (!iZg4c0D2FiNxC18vumo(chain, certificate))
					{
						if (rsX5ttD7nVlA4bEdNbM(LphaTZDWBnIImuVW2IW(chain)) == 0)
						{
							num = 7;
							continue;
						}
						return QgYZpFDK5byveYu0ZQ2(uZZAZ5DCScKmFJVxS4U(qnl7PJDt0y9cs3iEO7p(chain.ChainElements[rsX5ttD7nVlA4bEdNbM(chain.ChainElements) - 1])), uZZAZ5DCScKmFJVxS4U(Ntab0RedGW));
					}
					break;
				case 6:
					return true;
				case 7:
					return false;
				}
				break;
			}
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HttpClientHelper()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MrY2NyD5eRDJuSTRIZC();
		rqpH2UDoINaQFUrdWV9(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static HttpClientHelper()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xOEUdFDDghLwqNFZm9k();
		int num;
		if (GGBhBGDAPsy6nb8rVDB())
		{
			num = 4;
		}
		else
		{
			num = 3;
			if (!GGBhBGDAPsy6nb8rVDB())
			{
				return;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				Ntab0RedGW = new X509Certificate2((byte[])Il81sqDP58t4iBaSyh8());
				goto case 2;
			default:
				num = 2;
				break;
			case 2:
				iK6bwamkGG = new HttpClientHandler
				{
					ServerCertificateCustomValidationCallback = INEb9QCKb4,
					MaxConnectionsPerServer = 50
				};
				num = 5;
				if (GGBhBGDAPsy6nb8rVDB())
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				goto case 1;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rvTFkDDUl1PbXInTl1D(object P_0, object P_1, SslPolicyErrors sslErrors)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return InternalVerifyCognexChain((X509Certificate2)P_0, (X509Chain)P_1, sslErrors);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GGBhBGDAPsy6nb8rVDB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xOEUdFDDghLwqNFZm9k()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HlmNoFDToRFwUlqqOUH(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Uri)P_0 != (Uri)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TSKpAoDdVcDgHOTeqVQ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((HttpClient)P_0).BaseAddress = (Uri)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void crjXvkDietyEeqQlhwU(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((HttpWebRequest)P_0).ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hm7YRGDqFQHbgA4ZEmL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((X509Chain)P_0).ChainPolicy;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void p25jKfDBveEXX6dIkAt(object P_0, X509RevocationMode P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((X509ChainPolicy)P_0).RevocationMode = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KmOAEsDjPZdvMPuvDNM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((X509ChainPolicy)P_0).ExtraStore;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int kicFcLDci8TTuMHggVU(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((X509Certificate2Collection)P_0).Add((X509Certificate2)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool iZg4c0D2FiNxC18vumo(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((X509Chain)P_0).Build((X509Certificate2)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LphaTZDWBnIImuVW2IW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((X509Chain)P_0).ChainElements;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int rsX5ttD7nVlA4bEdNbM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((X509ChainElementCollection)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qnl7PJDt0y9cs3iEO7p(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((X509ChainElement)P_0).Certificate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uZZAZ5DCScKmFJVxS4U(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((X509Certificate2)P_0).Thumbprint;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QgYZpFDK5byveYu0ZQ2(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MrY2NyD5eRDJuSTRIZC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rqpH2UDoINaQFUrdWV9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Il81sqDP58t4iBaSyh8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.cognexRootCAPublic;
	}
}
