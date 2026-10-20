using System;
using System.Runtime.CompilerServices;
using Cognex.InSight.Graphic;
using Cognex.InSight.Remoting.Serialization;
using Newtonsoft.Json;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

[Serializable]
public sealed class CvsFunctionGraphic
{
	private readonly int yrJLiEvLyZ;

	private int CuZLduMmRO;

	private int jyWLu1yVN0;

	private int ai7LGVBILy;

	private int LXZLDY5lxA;

	private int qFqLeX9yjL;

	private int YLPLS78d2S;

	private int sv3LrXusM5;

	private short uHQLCqHPMH;

	public int Index
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return yrJLiEvLyZ;
		}
	}

	public int EditStart
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LXZLDY5lxA;
		}
	}

	public int EditEnd
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qFqLeX9yjL;
		}
	}

	public int HighlightStart
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return YLPLS78d2S;
		}
	}

	public int HighlightEnd
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return sv3LrXusM5;
		}
	}

	public short Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return uHQLCqHPMH;
		}
	}

	[JsonIgnore]
	public CvsEditFlags EditFlags
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (CvsEditFlags)(uHQLCqHPMH >> 4);
		}
	}

	[JsonIgnore]
	public bool IsRegion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CuZLduMmRO == 125;
		}
	}

	[JsonIgnore]
	public bool IsCircle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CuZLduMmRO == 103;
		}
	}

	[JsonIgnore]
	public bool IsLine
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CuZLduMmRO == 117;
		}
	}

	[JsonIgnore]
	public bool IsPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CuZLduMmRO == 120;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsFunctionGraphic(int index, GraphicDescriptor graphicDescriptor)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		while (true)
		{
			switch (num)
			{
			case 9:
				uHQLCqHPMH = (short)pudY0ubwK8FVRG8eqHN(graphicDescriptor);
				num = 13;
				if (HC8koRXyr3V00NRDaWk())
				{
				}
				break;
			case 2:
			case 3:
				if (graphicDescriptor == null)
				{
					num = 1;
					break;
				}
				yrJLiEvLyZ = index;
				num = 0;
				break;
			case 7:
				sv3LrXusM5 = q9EpkvXzAmDSEt24jkH(graphicDescriptor);
				num = 9;
				break;
			case 10:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 12;
				break;
			case 4:
				qFqLeX9yjL = graphicDescriptor.EditEnd;
				num = 11;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
				CuZLduMmRO = graphicDescriptor.Kind;
				num = 5;
				break;
			case 12:
				base._002Ector();
				_ = 1;
				if (!HC8koRXyr3V00NRDaWk())
				{
					num = 3;
					if (true)
					{
						break;
					}
					goto default;
				}
				num = 8;
				if (F17ICeXmCHP4nUZMSGn())
				{
					break;
				}
				goto case 1;
			default:
				ai7LGVBILy = agtlufXZsD9qLZmBrZC(graphicDescriptor);
				LXZLDY5lxA = IxjfaVXJ2BTYhxqssgu(graphicDescriptor);
				num = 4;
				break;
			case 5:
				jyWLu1yVN0 = E5nOteXgy7XJoaAelr7(graphicDescriptor);
				goto default;
			case 1:
				throw new ArgumentNullException(kgbOBx7BanbFa22Hp9.ol99ukmDA(42576));
			case 11:
				YLPLS78d2S = vUjPpWX8HdBImDZBPJ5(graphicDescriptor);
				num = 7;
				if (!F17ICeXmCHP4nUZMSGn())
				{
					return;
				}
				break;
			case 13:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int E5nOteXgy7XJoaAelr7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((GraphicDescriptor)P_0).FixStart;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int agtlufXZsD9qLZmBrZC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((GraphicDescriptor)P_0).AuxFix;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int IxjfaVXJ2BTYhxqssgu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((GraphicDescriptor)P_0).EditStart;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int vUjPpWX8HdBImDZBPJ5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((GraphicDescriptor)P_0).HiLtStart;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int q9EpkvXzAmDSEt24jkH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((GraphicDescriptor)P_0).HiLtEnd;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int pudY0ubwK8FVRG8eqHN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((GraphicDescriptor)P_0).Flags;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool F17ICeXmCHP4nUZMSGn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HC8koRXyr3V00NRDaWk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
