using System;
using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

[Serializable]
public class CvsCellInfo : INamedOperand
{
	private readonly CvsCellLocation eg1IHPAhwP;

	private readonly string hn9IKnaTkq;

	private readonly bool bajIEWh1Op;

	private readonly bool KuoIQt1tti;

	public CvsCellLocation Location
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return eg1IHPAhwP;
		}
	}

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hn9IKnaTkq;
		}
	}

	public bool Input
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bajIEWh1Op;
		}
	}

	public bool Output
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KuoIQt1tti;
		}
	}

	string INamedOperand.Expression
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			throw new NotImplementedException();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellInfo(CvsCellLocation location, string name, bool input, bool output)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 5:
			case 6:
				KuoIQt1tti = output;
				num = 8;
				continue;
			case 3:
				eg1IHPAhwP = location;
				num = 7;
				continue;
			case 1:
			case 4:
				bajIEWh1Op = input;
				goto case 5;
			case 2:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 0;
				continue;
			case 0:
				DmtXUcLQJouC4QEdS37(this);
				num = 3;
				if (Sg5gBHLOV6H8RAbZwj6())
				{
					continue;
				}
				goto case 7;
			case 7:
				hn9IKnaTkq = name;
				break;
			case 8:
				return;
			}
			oP1CnFLMgOMEGUi2Gom();
			if (!Sg5gBHLOV6H8RAbZwj6())
			{
				num = 6;
				continue;
			}
			num = 1;
			if (1 == 0)
			{
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellInfo(CvsCellInfo original)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Sg5gBHLOV6H8RAbZwj6();
		int num = (oP1CnFLMgOMEGUi2Gom() ? 4 : 2);
		while (true)
		{
			switch (num)
			{
			case 3:
			case 4:
				hn9IKnaTkq = (string)GnDAUjLexhtAkIiVb45(original);
				break;
			default:
				num = 1;
				continue;
			case 7:
				KuoIQt1tti = vhJZ4vLuGV0hj3oDRPn(original);
				num = 8;
				if (!oP1CnFLMgOMEGUi2Gom())
				{
					continue;
				}
				goto case 5;
			case 5:
				DmtXUcLQJouC4QEdS37(this);
				num = 6;
				if (Sg5gBHLOV6H8RAbZwj6())
				{
					continue;
				}
				goto case 6;
			case 6:
				eg1IHPAhwP = original.Location;
				goto case 3;
			case 0:
			case 2:
				EOfemuLlOBRqgWsVFfh();
				num = 5;
				continue;
			case 1:
				break;
			case 8:
				return;
			}
			bajIEWh1Op = original.Input;
			num = 7;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Location.GetHashCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_00a4;
		IL_001a:
		CvsCellInfo cvsCellInfo = default;
		if (cvsCellInfo != null)
		{
			num = 2;
			goto IL_00a4;
		}
		return false;
		IL_00a4:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 3:
			case 6:
				if (ml6fa1LaQjCL7QHd6uJ(Name, cvsCellInfo.Name))
				{
					goto case 4;
				}
				goto IL_00ee;
			case 0:
				cvsCellInfo = obj as CvsCellInfo;
				num = 1;
				continue;
			case 4:
			case 5:
				if (bajIEWh1Op == cvsCellInfo.bajIEWh1Op)
				{
					num = 7;
					continue;
				}
				goto IL_00ee;
			case 2:
				if (Oq8JPQLRSGeDtpvWD7J(Location, vUg8kTLIjDESrXUUM8Y(cvsCellInfo)))
				{
					goto default;
				}
				goto IL_00ee;
			default:
				_ = 0;
				num = (Sg5gBHLOV6H8RAbZwj6() ? 6 : 5);
				continue;
			case 7:
				{
					return KuoIQt1tti == cvsCellInfo.KuoIQt1tti;
				}
				IL_00ee:
				return false;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DmtXUcLQJouC4QEdS37(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Sg5gBHLOV6H8RAbZwj6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oP1CnFLMgOMEGUi2Gom()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EOfemuLlOBRqgWsVFfh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GnDAUjLexhtAkIiVb45(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellInfo)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vhJZ4vLuGV0hj3oDRPn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellInfo)P_0).Output;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation vUg8kTLIjDESrXUUM8Y(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellInfo)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Oq8JPQLRSGeDtpvWD7J(CvsCellLocation left, CvsCellLocation right)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return left == right;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ml6fa1LaQjCL7QHd6uJ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}
}
