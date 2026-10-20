using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

public class HttpQueryBuilder
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public bool encoded;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass12_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Lj9NrYsSqAyVFjHG7WxW();
			lhR12QsSB0mr3BKZUQPD(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CGetQuery_003Eb__0(KeyValuePair<string, string> kvp)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (encoded ? WebUtility.UrlEncode(kvp.Key) : kvp.Key) + kgbOBx7BanbFa22Hp9.ol99ukmDA(15302) + (encoded ? WebUtility.UrlEncode(kvp.Value) : kvp.Value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Lj9NrYsSqAyVFjHG7WxW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void lhR12QsSB0mr3BKZUQPD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool u4KefysSd6dw7OQ2Dpbf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool n6gbqCsSiefZA6lKnxgf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private Dictionary<string, string> JCjbRV0AgW;

	public string this[string key]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return JCjbRV0AgW[key];
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetParameter(key, value);
		}
	}

	public string Query
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GetQuery();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetParameter(string key, char delimiter = ',', params string[] values)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		while (true)
		{
			object obj;
			string value;
			switch (num)
			{
			case 1:
			case 2:
				if (values.Length <= 1)
				{
					goto IL_0041;
				}
				goto case 3;
			case 5:
				throw new ArgumentNullException(kgbOBx7BanbFa22Hp9.ol99ukmDA(8596));
			case 4:
				obj = "";
				goto IL_0067;
			case 6:
				if (cOkk2fDxr7ll4w5jpd5(key))
				{
					num = 0;
					break;
				}
				if (values != null)
				{
					_ = 1;
					if (CGsNSgDNwu9lSAIEgOg())
					{
						num = 7;
						break;
					}
					num = 1;
					if (!heaCK9DYAXd0DHccu2c())
					{
						return;
					}
					break;
				}
				goto IL_0041;
			case 3:
			case 7:
				if (values.Any(string.IsNullOrEmpty))
				{
					goto case 5;
				}
				goto IL_0041;
			default:
				num = 5;
				break;
			case 0:
				throw new ArgumentNullException((string)GEVUI0D1unCd8vTurRc(8586));
			case 8:
				return;
				IL_0041:
				if (values == null)
				{
					num = 4;
					break;
				}
				obj = pwN7hLDr4xLMbAGtcST(char.ToString(delimiter), values);
				goto IL_0067;
				IL_0067:
				value = (string)obj;
				JCjbRV0AgW[key] = value;
				num = 8;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetParameter(string key, params string[] values)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SetParameter(key, ',', values);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetParameter(string key)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return JCjbRV0AgW[key];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool RemoveParameter(string key)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return JCjbRV0AgW.Remove(key);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearQuery()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		lXnJr3D3MQIRD8RtVQk(JCjbRV0AgW);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Query;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetQuery(bool encoded = true)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CGsNSgDNwu9lSAIEgOg();
		int num;
		if (heaCK9DYAXd0DHccu2c())
		{
			num = 5;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_009c;
		IL_0040:
		_003C_003Ec__DisplayClass12_0 obj = default;
		obj.encoded = encoded;
		num = 3;
		goto IL_009c;
		IL_009c:
		IEnumerable<string> values = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				break;
			case 1:
			case 2:
				goto IL_0040;
			case 4:
				return string.Empty;
			case 3:
				if (lwsr2GDOjM8N4PQHyUj(JCjbRV0AgW) > 0)
				{
					values = JCjbRV0AgW.Select(obj._003CGetQuery_003Eb__0);
					num = 6;
					continue;
				}
				goto case 4;
			default:
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 6;
			case 6:
				return string.Join((string)GEVUI0D1unCd8vTurRc(8612), values);
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		obj = new _003C_003Ec__DisplayClass12_0();
		goto IL_0040;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HttpQueryBuilder()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (CGsNSgDNwu9lSAIEgOg() ? 4 : 3);
		while (true)
		{
			switch (num)
			{
			case 1:
				JCjbRV0AgW = new Dictionary<string, string>();
				goto default;
			default:
				F0f4jhDQ9TiBPposkIA(this);
				num = 5;
				break;
			case 0:
			case 3:
				n7YpX2DMWMUkjRoFoLx();
				num = 1;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cOkk2fDxr7ll4w5jpd5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GEVUI0D1unCd8vTurRc(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pwN7hLDr4xLMbAGtcST(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Join((string)P_0, (string[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool heaCK9DYAXd0DHccu2c()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CGsNSgDNwu9lSAIEgOg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lXnJr3D3MQIRD8RtVQk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Dictionary<string, string>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int lwsr2GDOjM8N4PQHyUj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Dictionary<string, string>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void n7YpX2DMWMUkjRoFoLx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void F0f4jhDQ9TiBPposkIA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
