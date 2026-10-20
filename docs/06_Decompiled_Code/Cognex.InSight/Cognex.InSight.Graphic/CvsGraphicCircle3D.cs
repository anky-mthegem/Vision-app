using System;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicCircle3D : CvsGraphic3D, ICvsEditableGraphicExtended
{
	private CvsEditFlags pCiT6ToRVT;

	[CompilerGenerated]
	private CvsCogCircle3D I0DTHxjcfT;

	public CvsEditFlags EditFlags
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return pCiT6ToRVT;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			while (true)
			{
				switch (num)
				{
				default:
					fDu0RIokt0kJmQowqRr(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(33720));
					num = 5;
					if (true)
					{
						continue;
					}
					break;
				case 3:
					break;
				case 1:
				case 4:
					pCiT6ToRVT = value & (CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation);
					goto default;
				case 5:
					return;
				}
				CheckLock();
				_ = 1;
				num = ((!lKkROHobeGTnXpVARoZ()) ? 4 : 0);
			}
		}
	}

	public CvsCogCircle3D Circle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return I0DTHxjcfT;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			I0DTHxjcfT = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicCircle3D(CvsCellLocation cellLocation, CvsCogEditingCircle3D editCircle)
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
		goto IL_004b;
		IL_007e:
		CvsCogCircle3D circle = default;
		FromSerializableGraphic(circle);
		num = 5;
		if (!lKkROHobeGTnXpVARoZ())
		{
			goto IL_004b;
		}
		goto IL_0095;
		IL_004b:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				break;
			case 3:
			case 6:
				goto IL_0032;
			default:
				num = 0;
				continue;
			case 0:
				goto IL_007e;
			case 4:
				goto IL_0095;
			case 5:
				EditFlags = (CvsEditFlags)((tPg1PVopVIjefysoYXl(editCircle) ? 1 : 0) | (o4RlVXo0YAnPYOXlWT9(editCircle) ? 2 : 0) | (editCircle.Rotate ? 4 : 0));
				num = 8;
				continue;
			case 7:
				goto IL_00ec;
			case 8:
				return;
			}
			break;
			IL_00ec:
			pCiT6ToRVT = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
			_ = 1;
			num = ((!lKkROHobeGTnXpVARoZ()) ? 1 : 6);
		}
		goto IL_001a;
		IL_0095:
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		num = 7;
		goto IL_004b;
		IL_001a:
		base._002Ector(cellLocation, editCircle);
		goto IL_0032;
		IL_0032:
		circle = (CvsCogCircle3D)tapj5Uo6dtCJXjH7VKF(editCircle);
		goto IL_007e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicCircle3D(CvsGraphicCircle3D graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				base._002Ector(graphic);
				goto default;
			default:
				pCiT6ToRVT = graphic.pCiT6ToRVT;
				num = 6;
				if (true)
				{
					break;
				}
				goto case 4;
			case 4:
				pCiT6ToRVT = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
				lKkROHobeGTnXpVARoZ();
				if (!evyfWVoXEqneWujTdFU())
				{
					num = 5;
					break;
				}
				num = 0;
				if (lKkROHobeGTnXpVARoZ())
				{
				}
				break;
			case 1:
				u21aHDo4VylMaEecpTB();
				num = 4;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicCircle3D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!evyfWVoXEqneWujTdFU()) ? 2 : 4);
		while (true)
		{
			switch (num)
			{
			case 3:
				base._002Ector();
				num = 5;
				if (evyfWVoXEqneWujTdFU())
				{
					break;
				}
				goto case 1;
			case 1:
			case 2:
				pCiT6ToRVT = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
				goto case 3;
			default:
				num = 3;
				break;
			case 0:
			case 4:
				u21aHDo4VylMaEecpTB();
				goto case 1;
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
		return new CvsGraphicCircle3D(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogCircle3D circle)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base.FromSerializableGraphic(circle);
		Circle = circle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetSerializableGraphic()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCogCircle3D((double[])V1tcVLofhXFq0oYnuh1(Circle), oWHwtUoFE6VikQifR6P(Circle), vy5YIuomTZkqkH7wEHR(Circle));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tapj5Uo6dtCJXjH7VKF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingCircle3D)P_0).Circle3D;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tPg1PVopVIjefysoYXl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape3D)P_0).Move;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool o4RlVXo0YAnPYOXlWT9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape3D)P_0).Resize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool evyfWVoXEqneWujTdFU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lKkROHobeGTnXpVARoZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void u21aHDo4VylMaEecpTB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fDu0RIokt0kJmQowqRr(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object V1tcVLofhXFq0oYnuh1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape3D)P_0).ModelMatrix;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double oWHwtUoFE6VikQifR6P(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRoundShape)P_0).Radius;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int vy5YIuomTZkqkH7wEHR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape)P_0).Color;
	}
}
