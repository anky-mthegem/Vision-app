using System;
using System.Runtime.CompilerServices;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

[Serializable]
public sealed class CvsExpression
{
	private CvsCellLocation ahCWXG5MCF;

	private readonly string MEeWfxvdGL;

	private readonly string SniWj5hKfu;

	public CvsCellLocation Location
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ahCWXG5MCF;
		}
	}

	public string Expression
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MEeWfxvdGL;
		}
	}

	public bool Enabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return BWDVKta18S3MRXnJGVY(SniWj5hKfu, hvi8VraxAAhHlhibFJL(34482));
		}
	}

	public string CellReference
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0046;
			IL_0075:
			if (SniWj5hKfu == "")
			{
				num = 5;
				goto IL_0046;
			}
			return SniWj5hKfu;
			IL_00c4:
			return null;
			IL_0046:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					break;
				default:
					goto IL_0075;
				case 4:
					goto IL_0094;
				case 5:
					goto IL_00c4;
				}
				break;
				IL_0094:
				if (!(SniWj5hKfu == (string)hvi8VraxAAhHlhibFJL(34482)))
				{
					_ = 1;
					if (hItEL9aN3iiOi26pod8())
					{
						num = 0;
						if (0 == 0)
						{
							continue;
						}
						goto IL_0075;
					}
					num = 3;
					continue;
				}
				goto IL_00c4;
			}
			goto IL_001a;
			IL_001a:
			if (!FwMlZaarHdXYbsypsLa(SniWj5hKfu, hvi8VraxAAhHlhibFJL(41870)))
			{
				goto IL_0075;
			}
			goto IL_00c4;
		}
	}

	internal string CellState
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SniWj5hKfu;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ahCWXG5MCF.GetHashCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsExpression(CvsCellLocation location, string expression, string cellState)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		vk8UjoaYju6LLE5EI5r();
		int num;
		if (!hItEL9aN3iiOi26pod8())
		{
			num = 4;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 6;
		}
		goto IL_0064;
		IL_002a:
		SniWj5hKfu = cellState;
		num = 7;
		goto IL_0064;
		IL_0064:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 2:
				base._002Ector();
				num = 1;
				continue;
			case 1:
				ahCWXG5MCF = location;
				goto default;
			default:
				MEeWfxvdGL = expression;
				num = 5;
				continue;
			case 0:
			case 4:
				TlKItea3XBbvquv9EaE();
				num = 2;
				continue;
			case 7:
				return;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vk8UjoaYju6LLE5EI5r()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hItEL9aN3iiOi26pod8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hvi8VraxAAhHlhibFJL(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BWDVKta18S3MRXnJGVY(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 != (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FwMlZaarHdXYbsypsLa(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TlKItea3XBbvquv9EaE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}
}
