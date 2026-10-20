using System;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicRegion3D : CvsGraphic3D, ICvsEditableGraphicExtended
{
	private CvsEditFlags ok2MDWeWZF;

	[CompilerGenerated]
	private CvsCogRegion3D q5FMeQ5mxH;

	public CvsEditFlags EditFlags
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ok2MDWeWZF;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (lH2XqnQARlds0R2jCni())
			{
				num = 2;
				if (VjY4OQQDbOuyMTffnMi())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_0045;
			IL_006c:
			TCtUr5QjCaDcnoWg4i1(this, mlZx08QBH1R6XPnK5Zv(33720));
			num = 5;
			if (true)
			{
				goto IL_0045;
			}
			goto IL_0088;
			IL_0088:
			CheckLock();
			goto IL_002a;
			IL_002a:
			ok2MDWeWZF = value & (CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation);
			goto IL_006c;
			IL_0045:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					break;
				default:
					num = 4;
					continue;
				case 4:
					goto IL_006c;
				case 0:
				case 2:
					goto IL_0088;
				case 5:
					return;
				}
				break;
			}
			goto IL_002a;
		}
	}

	public CvsCogRegion3D Region3D
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return q5FMeQ5mxH;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			q5FMeQ5mxH = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicRegion3D(CvsCellLocation cellLocation, CvsCogEditingRegion3D editRegion)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		CvsCogRegion3D region3D = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 6:
				region3D = (CvsCogRegion3D)svf9rTQTes8ROGmALZd(editRegion);
				goto case 4;
			default:
				num = 4;
				if (true)
				{
					break;
				}
				goto case 7;
			case 7:
				EditFlags = (CvsEditFlags)((cNh9CLQdy9Vti4UMx02(editRegion) ? 1 : 0) | (M4vknZQibjQt32dOxQQ(editRegion) ? 2 : 0) | (ReqHsEQq04fvsn4hthb(editRegion) ? 4 : 0));
				num = 8;
				break;
			case 0:
				MF9BthQUN6xNHsNuGHy();
				num = 5;
				break;
			case 5:
				ok2MDWeWZF = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
				_ = 1;
				num = ((!VjY4OQQDbOuyMTffnMi()) ? 1 : 6);
				break;
			case 4:
				FromSerializableGraphic(region3D);
				num = 7;
				break;
			case 1:
			case 2:
				base._002Ector(cellLocation, editRegion);
				goto case 3;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicRegion3D(CvsGraphicRegion3D graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (VjY4OQQDbOuyMTffnMi())
		{
			goto IL_001e;
		}
		goto IL_0037;
		IL_001e:
		ok2MDWeWZF = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
		goto IL_007f;
		IL_0037:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				break;
			case 4:
				goto IL_0064;
			default:
				goto IL_007f;
			case 5:
				return;
			}
			break;
			IL_0064:
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
			_ = 0;
			num = (lH2XqnQARlds0R2jCni() ? 3 : 0);
		}
		goto IL_001e;
		IL_007f:
		base._002Ector(graphic);
		num = 5;
		if (false)
		{
			return;
		}
		goto IL_0037;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicRegion3D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (VjY4OQQDbOuyMTffnMi() ? 3 : 4);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				goto case 1;
			case 2:
				base._002Ector();
				num = 5;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
			case 3:
				ok2MDWeWZF = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
				goto case 2;
			default:
				num = 2;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicRegion3D(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogRegion3D region3D)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base.FromSerializableGraphic(region3D);
		Region3D = region3D;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetSerializableGraphic()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCogRegion3D((double[])tUCSXqQcdoZkF55u6Ts(Region3D), (double[])qTtJnsQ2n2fSbnCZRY9(Region3D), TOgxJIQWMDpdknghdjM(Region3D), AkFLbkQ7Vj18Irm37ce(Region3D));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MF9BthQUN6xNHsNuGHy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object svf9rTQTes8ROGmALZd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingRegion3D)P_0).Region3D;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cNh9CLQdy9Vti4UMx02(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape3D)P_0).Move;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool M4vknZQibjQt32dOxQQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape3D)P_0).Resize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ReqHsEQq04fvsn4hthb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape3D)P_0).Rotate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lH2XqnQARlds0R2jCni()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VjY4OQQDbOuyMTffnMi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mlZx08QBH1R6XPnK5Zv(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TCtUr5QjCaDcnoWg4i1(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tUCSXqQcdoZkF55u6Ts(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape3D)P_0).ModelMatrix;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qTtJnsQ2n2fSbnCZRY9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion3D)P_0).Size;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double TOgxJIQWMDpdknghdjM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion3D)P_0).Curve;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int AkFLbkQ7Vj18Irm37ce(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape)P_0).Color;
	}
}
