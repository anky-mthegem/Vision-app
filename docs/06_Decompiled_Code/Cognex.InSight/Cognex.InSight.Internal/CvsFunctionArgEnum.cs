using System;
using System.Runtime.CompilerServices;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

[Serializable]
public sealed class CvsFunctionArgEnum
{
	[CompilerGenerated]
	private string jllLE22pyK;

	[CompilerGenerated]
	private int vxHLQv5bVj;

	[CompilerGenerated]
	private bool i7cLNMcja7;

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
			return jllLE22pyK;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			jllLE22pyK = value;
		}
	}

	public int Code
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return vxHLQv5bVj;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			vxHLQv5bVj = value;
		}
	}

	public bool IsValid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return i7cLNMcja7;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			i7cLNMcja7 = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsFunctionArgEnum(string name, int value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		olM1N9XlFVjHYuSsUnY();
		int num;
		if (!rdJ5B6XeOeIdKBxC4R7())
		{
			num = 3;
			if (rdJ5B6XeOeIdKBxC4R7())
			{
			}
		}
		else
		{
			num = 6;
			if (!olM1N9XlFVjHYuSsUnY())
			{
				goto IL_009c;
			}
		}
		goto IL_004b;
		IL_004b:
		while (true)
		{
			switch (num)
			{
			case 5:
				Code = value;
				goto case 1;
			default:
				num = 1;
				continue;
			case 1:
				Name = (string)TdbFDKXIJhu8lLapQ8X(name);
				break;
			case 4:
			case 6:
				break;
			case 2:
				base._002Ector();
				num = 5;
				continue;
			case 0:
			case 3:
				Pjxme5XuDPZOpLjw4xX();
				num = 2;
				continue;
			case 7:
				return;
			}
			break;
		}
		goto IL_009c;
		IL_009c:
		IsValid = true;
		num = 7;
		if (rdJ5B6XeOeIdKBxC4R7())
		{
		}
		goto IL_004b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CvsFunctionArgEnum(int value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!olM1N9XlFVjHYuSsUnY()) ? 4 : 2);
		while (true)
		{
			switch (num)
			{
			case 3:
				IsValid = false;
				num = 5;
				continue;
			case 0:
			case 2:
				Pjxme5XuDPZOpLjw4xX();
				goto case 1;
			case 1:
			case 4:
				this._002Ector((string)LcPZkPXRSLxQyFAXhKa(42552), value);
				goto case 3;
			case 5:
				return;
			}
			num = 3;
			if (false)
			{
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsFunctionArgEnum CreateInvalid(int value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsFunctionArgEnum(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string sUsLsqIn4u(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		string text = default;
		int num2 = default;
		string text2 = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				if (!text.StartsWith((string)LcPZkPXRSLxQyFAXhKa(42570)))
				{
					goto case 6;
				}
				text = (string)eHu94pXGjVevfhcOrPA(text, 1);
				num = 2;
				continue;
			case 7:
				if (num2 != -1)
				{
					num = 1;
					continue;
				}
				break;
			case 1:
				text2 = (string)g8EHAnXnIoTPw9FdZob(P_0, 0, num2);
				_ = 0;
				num = ((!olM1N9XlFVjHYuSsUnY()) ? 8 : 0);
				continue;
			case 0:
			case 3:
				text = (string)eHu94pXGjVevfhcOrPA(P_0, num2 + 1);
				goto case 2;
			default:
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 6;
			case 6:
			case 8:
				P_0 = (string)sPjFkyXX9RLRfJ1d5t1(text2, LcPZkPXRSLxQyFAXhKa(358), text);
				num = 9;
				continue;
			case 5:
				num2 = hc56utXaXh77ZrmDwqt(P_0, '\t');
				num = 7;
				continue;
			case 9:
				break;
			}
			break;
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Pjxme5XuDPZOpLjw4xX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TdbFDKXIJhu8lLapQ8X(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sUsLsqIn4u((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool olM1N9XlFVjHYuSsUnY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rdJ5B6XeOeIdKBxC4R7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LcPZkPXRSLxQyFAXhKa(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int hc56utXaXh77ZrmDwqt(object P_0, char P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).IndexOf(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object g8EHAnXnIoTPw9FdZob(object P_0, int P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Substring(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eHu94pXGjVevfhcOrPA(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Substring(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sPjFkyXX9RLRfJ1d5t1(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}
}
