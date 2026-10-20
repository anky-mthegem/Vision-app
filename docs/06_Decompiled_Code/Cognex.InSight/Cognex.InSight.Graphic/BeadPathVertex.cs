using System.Drawing;
using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

public class BeadPathVertex
{
	private readonly PointF HGXBTptFmM;

	private readonly BeadPathMaskFlags o17BBtXWM0;

	public BeadPathMaskFlags Flags
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return o17BBtXWM0;
		}
	}

	public PointF Location
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HGXBTptFmM;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BeadPathVertex(float x, float y, BeadPathMaskFlags flags)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!Jc7Kh5YfGTDFlmgqxqy())
		{
			num = 4;
			if (Jc7Kh5YfGTDFlmgqxqy())
			{
			}
		}
		else
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				HGXBTptFmM = new PointF(x, y);
				goto case 3;
			case 3:
				o17BBtXWM0 = flags;
				num = 6;
				continue;
			case 5:
				DFAH5LYmvBJiNR62oCa(this);
				goto case 1;
			case 0:
			case 4:
				SHpnkhYFWWrcMmg1wl6();
				num = 5;
				continue;
			case 6:
				return;
			}
			num = 3;
			if (Jc7Kh5YfGTDFlmgqxqy())
			{
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BeadPathVertex(PointF location, BeadPathMaskFlags flags)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				DFAH5LYmvBJiNR62oCa(this);
				goto case 2;
			case 4:
				o17BBtXWM0 = flags;
				num = 6;
				break;
			case 0:
				SHpnkhYFWWrcMmg1wl6();
				_ = 0;
				if (!iEwvh2YkfJWWVYCUJBu())
				{
					num = 5;
					break;
				}
				num = 3;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 2:
			case 5:
				HGXBTptFmM = location;
				goto case 4;
			default:
				num = 4;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BeadPathVertex(BeadPathVertex other)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!Jc7Kh5YfGTDFlmgqxqy())
		{
			num = 3;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 1;
		}
		goto IL_003e;
		IL_007a:
		o17BBtXWM0 = q0papuYy3t081U6ujqL(other);
		num = 5;
		if (Jc7Kh5YfGTDFlmgqxqy())
		{
		}
		goto IL_003e;
		IL_003e:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 0:
			case 3:
				SHpnkhYFWWrcMmg1wl6();
				num = 4;
				continue;
			default:
				goto IL_007a;
			case 5:
				return;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		DFAH5LYmvBJiNR62oCa(this);
		goto IL_007a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SHpnkhYFWWrcMmg1wl6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DFAH5LYmvBJiNR62oCa(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool iEwvh2YkfJWWVYCUJBu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Jc7Kh5YfGTDFlmgqxqy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static BeadPathMaskFlags q0papuYy3t081U6ujqL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BeadPathVertex)P_0).Flags;
	}
}
