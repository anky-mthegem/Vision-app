using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

public class CvsGraphicLine3D : CvsGraphic3D, ICvsEditableGraphicExtended
{
	private CvsEditFlags EBIJDrkQ5q;

	[CompilerGenerated]
	private CvsCogLine3D yNiJeAxaBy;

	[CompilerGenerated]
	private double[] ugqJSMWleg;

	public CvsCogLine3D Line3D
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return yNiJeAxaBy;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			yNiJeAxaBy = value;
		}
	}

	public CvsEditFlags EditFlags
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EBIJDrkQ5q;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			while (true)
			{
				switch (num)
				{
				default:
					Uavvg33g4vrTB1QKy4n(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(33720));
					num = 5;
					break;
				case 4:
					CheckLock();
					_ = 1;
					num = (mWoGdA3023PNxPn4Yys() ? 3 : 0);
					break;
				case 0:
				case 1:
					EBIJDrkQ5q = value & (CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation | CvsEditFlags.InPlane);
					goto default;
				case 5:
					return;
				}
			}
		}
	}

	public double[] ProfileNormal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ugqJSMWleg;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ugqJSMWleg = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicLine3D(CvsGraphicLine3D graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		w7MjSf3plJW0hW6e4Kv();
		int num;
		if (!mWoGdA3023PNxPn4Yys())
		{
			num = 3;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_006a;
		IL_002a:
		EditFlags = AIZ5P13kggws6ompIRa(graphic);
		num = 6;
		goto IL_006a;
		IL_006a:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 1:
			case 4:
				EBIJDrkQ5q = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
				num = 5;
				continue;
			case 5:
				base._002Ector(graphic);
				break;
			default:
				num = 2;
				continue;
			case 0:
			case 3:
				gwDqc834uhE7vYQDnl0();
				goto case 1;
			case 6:
				return;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicLine3D(CvsCellLocation cellLocation, CvsCogEditingProfileLine3D editLine)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		CvsCogLine3D line3D = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				EditFlags = (CvsEditFlags)((N4cwvm3fvYIX4mr6eWp(editLine) ? 1 : 0) | (editLine.Resize ? 2 : 0) | (wFFrJY3FH0bG3J8iJKh(editLine) ? 4 : 0) | (qRSJOa3mVJY50w9xBOX(editLine) ? 16 : 0));
				num = 2;
				if (w7MjSf3plJW0hW6e4Kv())
				{
					break;
				}
				goto case 4;
			case 4:
				base._002Ector(cellLocation, editLine);
				goto case 3;
			case 7:
				FromSerializableGraphic(line3D);
				num = 6;
				break;
			case 0:
			case 1:
				EBIJDrkQ5q = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
				num = 4;
				break;
			case 8:
				gwDqc834uhE7vYQDnl0();
				_ = 1;
				num = (mWoGdA3023PNxPn4Yys() ? 5 : 0);
				break;
			case 2:
				ProfileNormal = (double[])EdcIPj3ye7VnjwTKPfT(editLine);
				num = 9;
				break;
			case 3:
			case 5:
				line3D = editLine.Line3D;
				goto case 7;
			default:
				num = 7;
				if (!w7MjSf3plJW0hW6e4Kv())
				{
					return;
				}
				break;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicLine3D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		mWoGdA3023PNxPn4Yys();
		int num;
		if (w7MjSf3plJW0hW6e4Kv())
		{
			num = 2;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0068;
		IL_002a:
		base._002Ector();
		num = 5;
		goto IL_0068;
		IL_0068:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 0:
			case 2:
				gwDqc834uhE7vYQDnl0();
				goto case 1;
			case 1:
			case 4:
				EBIJDrkQ5q = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
				break;
			default:
				goto IL_0085;
			case 5:
				return;
			}
			break;
			IL_0085:
			num = 3;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicLine3D(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void FromSerializableGraphic(CvsCogLine3D line)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base.FromSerializableGraphic(line);
		Line3D = line;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetSerializableGraphic()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return nEu0vg3ZUwmD42pIn7J(Line3D);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gwDqc834uhE7vYQDnl0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsEditFlags AIZ5P13kggws6ompIRa(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicLine3D)P_0).EditFlags;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool w7MjSf3plJW0hW6e4Kv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mWoGdA3023PNxPn4Yys()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool N4cwvm3fvYIX4mr6eWp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape3D)P_0).Move;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wFFrJY3FH0bG3J8iJKh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape3D)P_0).Rotate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qRSJOa3mVJY50w9xBOX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingProfileLine3D)P_0).InPlane;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EdcIPj3ye7VnjwTKPfT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingProfileLine3D)P_0).ProfileNormal;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Uavvg33g4vrTB1QKy4n(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nEu0vg3ZUwmD42pIn7J(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape)P_0).Clone();
	}
}
