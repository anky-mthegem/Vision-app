using System;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using Newtonsoft.Json;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.VisionBuilder.Types;

[CvsSerializable("ToolChainServerInfo")]
public class Server
{
	[CompilerGenerated]
	private readonly string Kkoh77sNC8;

	[CompilerGenerated]
	private readonly string vLchmw9VII;

	[CompilerGenerated]
	private readonly string uPUhnHQZwT;

	[CompilerGenerated]
	private readonly string Q2dh9Qx4ZX;

	[CompilerGenerated]
	private readonly string OX1hUK07AB;

	[CompilerGenerated]
	private readonly string ls2h0c7ZIo;

	[JsonProperty(PropertyName = "Url")]
	public string Url
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Kkoh77sNC8;
		}
	}

	[JsonProperty(PropertyName = "Name")]
	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return vLchmw9VII;
		}
	}

	[JsonProperty(PropertyName = "Domain")]
	public string Domain
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return uPUhnHQZwT;
		}
	}

	[JsonProperty(PropertyName = "ClientId")]
	public string ClientId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Q2dh9Qx4ZX;
		}
	}

	[JsonProperty(PropertyName = "RedirectUri")]
	public string RedirectUri
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OX1hUK07AB;
		}
	}

	[JsonProperty(PropertyName = "Audience")]
	public string Audience
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ls2h0c7ZIo;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[JsonConstructor]
	public Server(string url, string name, string domain, string clientId, string redirectUri, string audience)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!u6FX1Zcnop1wtadhYPZ())
		{
			num = 5;
		}
		else
		{
			num = 2;
			if (!Mmbct7camHeZkY8IQk2())
			{
				goto IL_003f;
			}
		}
		goto IL_00f9;
		IL_00f9:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				O6D5imcGgdUWD49jQd2();
				goto case 1;
			case 3:
				break;
			case 8:
				ls2h0c7ZIo = GC8hYHbIGW(audience, (string)C7q3Dlcby2PFW1UhjB3(15584));
				num = 10;
				continue;
			case 1:
			case 2:
				b7VjdxcXJhIfeAdvmgL(this);
				num = 9;
				continue;
			case 9:
				Kkoh77sNC8 = (string)uTQJn8c6uZLNjslrcVD(url, C7q3Dlcby2PFW1UhjB3(15496));
				num = 3;
				continue;
			case 6:
				Q2dh9Qx4ZX = (string)uTQJn8c6uZLNjslrcVD(clientId, C7q3Dlcby2PFW1UhjB3(15534));
				num = 4;
				continue;
			case 7:
				uPUhnHQZwT = GC8hYHbIGW(domain, kgbOBx7BanbFa22Hp9.ol99ukmDA(15518));
				goto case 6;
			default:
				num = 6;
				continue;
			case 4:
				OX1hUK07AB = (string)uTQJn8c6uZLNjslrcVD(redirectUri, C7q3Dlcby2PFW1UhjB3(15556));
				num = 8;
				if (Mmbct7camHeZkY8IQk2())
				{
					continue;
				}
				return;
			case 10:
				return;
			}
			break;
		}
		goto IL_003f;
		IL_003f:
		vLchmw9VII = (string)uTQJn8c6uZLNjslrcVD(name, C7q3Dlcby2PFW1UhjB3(15506));
		num = 7;
		goto IL_00f9;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string GC8hYHbIGW(string JYIUaZBG2ATyxxIkDd, string erJLcJC5UI9ZG3YjNR)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (string.IsNullOrWhiteSpace(JYIUaZBG2ATyxxIkDd))
		{
			throw new ArgumentException((string)R4WRaxcp2eGHERCw2xe(erJLcJC5UI9ZG3YjNR, C7q3Dlcby2PFW1UhjB3(15604)), erJLcJC5UI9ZG3YjNR);
		}
		return JYIUaZBG2ATyxxIkDd;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		Server server = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				if (lbUSQCc4VUUSWPne6mY(Url, wvEJZvc05ig5MBBsK31(server)))
				{
					num = 3;
					break;
				}
				goto IL_0146;
			case 4:
				if (lbUSQCc4VUUSWPne6mY(Domain, server.Domain))
				{
					num = 5;
					break;
				}
				goto IL_0146;
			case 0:
				server = obj as Server;
				num = 7;
				break;
			case 7:
				if ((object)server != null)
				{
					Mmbct7camHeZkY8IQk2();
					num = ((!u6FX1Zcnop1wtadhYPZ()) ? 1 : 8);
					break;
				}
				return false;
			case 3:
				if (lbUSQCc4VUUSWPne6mY(Name, BMZYjxckRSZMcGt7Qxp(server)))
				{
					goto case 4;
				}
				goto IL_0146;
			default:
				num = 4;
				break;
			case 6:
			case 8:
				if (lbUSQCc4VUUSWPne6mY(RedirectUri, vcmlGdcfOlJSo9JCCyq(server)))
				{
					num = 9;
					if (!u6FX1Zcnop1wtadhYPZ())
					{
						break;
					}
					goto case 5;
				}
				goto IL_0146;
			case 5:
				if (ClientId == server.ClientId)
				{
					goto case 6;
				}
				goto IL_0146;
			case 9:
				{
					return lbUSQCc4VUUSWPne6mY(Audience, server.Audience);
				}
				IL_0146:
				return false;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Url, Name, Domain, ClientId, RedirectUri, Audience).GetHashCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator ==(Server left, Server right)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return left?.Equals(right) ?? ((object)right == null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator !=(Server left, Server right)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return !MBtpSNcFWbZ8KKVdWxM(left, right);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void O6D5imcGgdUWD49jQd2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void b7VjdxcXJhIfeAdvmgL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object C7q3Dlcby2PFW1UhjB3(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uTQJn8c6uZLNjslrcVD(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GC8hYHbIGW((string)P_0, (string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Mmbct7camHeZkY8IQk2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool u6FX1Zcnop1wtadhYPZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object R4WRaxcp2eGHERCw2xe(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wvEJZvc05ig5MBBsK31(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Server)P_0).Url;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lbUSQCc4VUUSWPne6mY(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BMZYjxckRSZMcGt7Qxp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Server)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vcmlGdcfOlJSo9JCCyq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Server)P_0).RedirectUri;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MBtpSNcFWbZ8KKVdWxM(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Server)P_0 == (Server)P_1;
	}
}
