using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicBlobProperties : CvsGraphicBlob
{
	private PointF O4PJUv4Wh5;

	private float hooJ0MfP7W;

	private int lTBJwqCgFo;

	private float LZ5JRsyBx2;

	private int wYKJs3Kmt8;

	private int MVVJ6gep9S;

	private float U4RJH1rJbe;

	public PointF Centroid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return O4PJUv4Wh5;
		}
	}

	public float Angle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hooJ0MfP7W;
		}
	}

	public int Area
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return lTBJwqCgFo;
		}
	}

	public float Elongation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LZ5JRsyBx2;
		}
	}

	public int Hole
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wYKJs3Kmt8;
		}
	}

	public int Perimeter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MVVJ6gep9S;
		}
	}

	public float Spread
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return U4RJH1rJbe;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public override int Id
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicBlobProperties(CvsGraphicBlobProperties graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!o0sfqL3PRSZUvI6KsZb())
		{
			goto IL_001e;
		}
		goto IL_00e4;
		IL_001e:
		U4RJH1rJbe = graphic.U4RJH1rJbe;
		num = 11;
		if (!o0sfqL3PRSZUvI6KsZb())
		{
			goto IL_003a;
		}
		goto IL_00e4;
		IL_00e4:
		while (true)
		{
			switch (num)
			{
			case 8:
			case 9:
				break;
			case 7:
				goto IL_003a;
			case 0:
				yZdfYS3NOwQXnTOjDs8();
				num = 1;
				if (0 == 0)
				{
					continue;
				}
				goto case 3;
			case 3:
				MVVJ6gep9S = graphic.MVVJ6gep9S;
				break;
			case 5:
				wYKJs3Kmt8 = graphic.wYKJs3Kmt8;
				num = 3;
				continue;
			case 1:
				goto IL_0093;
			case 6:
				LZ5JRsyBx2 = graphic.LZ5JRsyBx2;
				num = 5;
				continue;
			case 10:
				lTBJwqCgFo = graphic.lTBJwqCgFo;
				goto case 6;
			default:
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 2;
			case 2:
			case 4:
				O4PJUv4Wh5 = graphic.O4PJUv4Wh5;
				num = 7;
				continue;
			case 11:
				return;
			}
			break;
			IL_0093:
			base._002Ector(graphic);
			_ = 0;
			num = (o0sfqL3PRSZUvI6KsZb() ? 4 : 9);
		}
		goto IL_001e;
		IL_003a:
		hooJ0MfP7W = graphic.hooJ0MfP7W;
		num = 10;
		goto IL_00e4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicBlobProperties(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yZdfYS3NOwQXnTOjDs8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool o0sfqL3PRSZUvI6KsZb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sMy0Nj3YZGpF8b4hBZb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
