using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Cell;

[Serializable]
public class CvsCellString : CvsCell, ICvsCellText
{
	private static readonly Regex ziwfNUfNHj;

	public override object CellValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Text;
		}
	}

	public override Type DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return K01XAdy5mO6UhfmMFpA(typeof(string).TypeHandle);
		}
	}

	public override string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)K3cqAKyYseirycJRfSN(ziwfNUfNHj, (qsQN1TyomtlSTfphh0Q(CellResult) as string) ?? jR3fQwZCKT(), AHeqygyPpEVlZ9frMUW(9124));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IJJwA7ytIa5wnJ6RHke();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellString(CvsCellString cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IJJwA7ytIa5wnJ6RHke();
		base._002Ector(cell);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellString(CvsCellLocation location, CvsCogCellResult cellResult)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		base._002Ector(location, cellResult);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellString(CvsCellLocation location, string text)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!kn2XjcyWvZNG3QU5MTC())
		{
			goto IL_001e;
		}
		goto IL_0037;
		IL_001e:
		base._002Ector(location);
		goto IL_0064;
		IL_0037:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				break;
			default:
				goto IL_0064;
			case 0:
				goto IL_007a;
			case 5:
				return;
			}
			break;
			IL_007a:
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
			kn2XjcyWvZNG3QU5MTC();
			num = ((!GQ5mKYy7C9K6G7d4xkH()) ? 3 : 4);
		}
		goto IL_001e;
		IL_0064:
		XFyXuSyCobkgJ3Rj0xc(CellResult, text);
		num = 5;
		goto IL_0037;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCellString(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)gXTDatyKsMHMbcmw5NK(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string jR3fQwZCKT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		string text = default;
		while (true)
		{
			string text2;
			switch (num)
			{
			case 2:
				text2 = CellResult.Expression;
				if (text2 == null)
				{
					_ = 1;
					if (!GQ5mKYy7C9K6G7d4xkH())
					{
						num = 5;
						if (!GQ5mKYy7C9K6G7d4xkH())
						{
							break;
						}
						goto default;
					}
					num = 4;
					break;
				}
				goto IL_00ba;
			default:
				return text;
			case 0:
				if (n4uDX6yNhtV8UegZYXt(text, AHeqygyPpEVlZ9frMUW(7598)))
				{
					if (!mphFj4yxGMM0xVqTkOt(text))
					{
						num = 6;
						break;
					}
					return "";
				}
				goto default;
			case 1:
			case 5:
				text2 = "";
				goto IL_00ba;
			case 6:
				{
					return (string)QvTmoDyrNtQv6EyqfHd(kgbOBx7BanbFa22Hp9.ol99ukmDA(47174), text.Substring(0, biJKpWy1IM931dHJmDg(text, AHeqygyPpEVlZ9frMUW(7598))));
				}
				IL_00ba:
				text = text2;
				if (!text.StartsWith((string)AHeqygyPpEVlZ9frMUW(16876)))
				{
					num = 0;
					break;
				}
				goto default;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsCellString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IJJwA7ytIa5wnJ6RHke();
		ziwfNUfNHj = new Regex(kgbOBx7BanbFa22Hp9.ol99ukmDA(47180));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IJJwA7ytIa5wnJ6RHke()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kn2XjcyWvZNG3QU5MTC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GQ5mKYy7C9K6G7d4xkH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XFyXuSyCobkgJ3Rj0xc(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogCellResult)P_0).Value = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gXTDatyKsMHMbcmw5NK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type K01XAdy5mO6UhfmMFpA(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qsQN1TyomtlSTfphh0Q(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Face;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AHeqygyPpEVlZ9frMUW(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object K3cqAKyYseirycJRfSN(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Regex)P_0).Replace((string)P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool n4uDX6yNhtV8UegZYXt(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Contains((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mphFj4yxGMM0xVqTkOt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int biJKpWy1IM931dHJmDg(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).IndexOf((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QvTmoDyrNtQv6EyqfHd(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}
}
