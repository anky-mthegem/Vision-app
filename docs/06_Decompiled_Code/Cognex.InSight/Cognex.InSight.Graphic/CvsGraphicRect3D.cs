using System;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicRect3D : CvsGraphic3D, ICvsEditableGraphicExtended
{
	private CvsEditFlags yZyMmEtrEU;

	[CompilerGenerated]
	private CvsCogRect3D ryCMnBXy9c;

	public CvsEditFlags EditFlags
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return yZyMmEtrEU;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
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
				case 1:
				case 3:
					yZyMmEtrEU = value & (CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation | CvsEditFlags.InPlane);
					break;
				case 4:
					do
					{
						CheckLock();
						XhfE2RMrnrChWF5NNbc();
						if (XV5iO2M3P3kybxyfaMk())
						{
							num = 0;
							continue;
						}
						num = 3;
						break;
					}
					while (!XhfE2RMrnrChWF5NNbc());
					continue;
				case 5:
					return;
				}
				jrR4ggMRSME6n0YBuVZ(this, MBOkBEMIy27WhvO2DFB(33720));
				num = 5;
			}
		}
	}

	public CvsCogRect3D Rect3D
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ryCMnBXy9c;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ryCMnBXy9c = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicRect3D(CvsCellLocation cellLocation, CvsCogEditingShape3D editShape)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		CvsCogShape3D shape3D = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				yZyMmEtrEU = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
				num = 2;
				if (true)
				{
					break;
				}
				goto case 7;
			case 7:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				XhfE2RMrnrChWF5NNbc();
				if (!XV5iO2M3P3kybxyfaMk())
				{
					num = 4;
					break;
				}
				num = 3;
				if (true)
				{
					break;
				}
				return;
			case 2:
				base._002Ector(cellLocation, editShape);
				num = 6;
				break;
			case 6:
				shape3D = editShape.Shape3D;
				goto case 0;
			default:
				num = 0;
				if (true)
				{
					break;
				}
				goto case 3;
			case 3:
			case 5:
				EditFlags = (CvsEditFlags)((EOPglSMMjhY4rupJhpr(editShape) ? 1 : 0) | (gPBVCXMQvjmvSsFuMws(editShape) ? 2 : 0) | (editShape.Rotate ? 4 : 0));
				num = 8;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
				or0bMsMOfQ5gFp69845(this, shape3D);
				goto case 3;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicRect3D(CvsCellLocation cellLocation, CvsCogEditingRectangle3D editRect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		XhfE2RMrnrChWF5NNbc();
		int num = (XV5iO2M3P3kybxyfaMk() ? 2 : 7);
		CvsCogRect3D rect = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				FromSerializableGraphic(rect);
				num = 5;
				break;
			case 4:
				base._002Ector(cellLocation, editRect);
				num = 6;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
			case 2:
				yZyMmEtrEU = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
				num = 4;
				if (XV5iO2M3P3kybxyfaMk())
				{
				}
				break;
			case 6:
				rect = (CvsCogRect3D)OgR34HMl34iRotKeM67(editRect);
				goto case 3;
			default:
				num = 3;
				break;
			case 5:
				EditFlags = (CvsEditFlags)((EOPglSMMjhY4rupJhpr(editRect) ? 1 : 0) | (gPBVCXMQvjmvSsFuMws(editRect) ? 2 : 0) | (KL5AMTMelXO436cgvpH(editRect) ? 4 : 0) | (editRect.InPlane ? 16 : 0));
				num = 8;
				break;
			case 0:
			case 7:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				goto case 1;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicRect3D(CvsGraphicRect3D graphic)
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
			case 3:
				ztddtXMuBtO8IdkMwYE();
				_ = 1;
				num = (XV5iO2M3P3kybxyfaMk() ? 5 : 0);
				break;
			case 0:
			case 1:
				yZyMmEtrEU = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
				goto case 2;
			case 4:
				yZyMmEtrEU = graphic.yZyMmEtrEU;
				num = 6;
				if (XV5iO2M3P3kybxyfaMk())
				{
				}
				break;
			case 2:
			case 5:
				base._002Ector(graphic);
				goto case 4;
			default:
				num = 4;
				if (false)
				{
					return;
				}
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicRect3D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (XhfE2RMrnrChWF5NNbc())
		{
			num = 3;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0054;
		IL_003b:
		yZyMmEtrEU = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
		goto IL_007b;
		IL_0054:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				break;
			case 1:
			case 2:
				goto IL_003b;
			default:
				num = 4;
				continue;
			case 4:
				goto IL_007b;
			case 5:
				return;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		ztddtXMuBtO8IdkMwYE();
		goto IL_003b;
		IL_007b:
		base._002Ector();
		num = 5;
		goto IL_0054;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicRect3D(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogRect3D rect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base.FromSerializableGraphic(rect);
		Rect3D = rect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetSerializableGraphic()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCogRect3D((double[])t0s0QMMaugBxIITeuGG(Rect3D), Rect3D.Size, Rect3D.Color);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void or0bMsMOfQ5gFp69845(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).FromSerializableGraphic((CvsCogShape)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EOPglSMMjhY4rupJhpr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape3D)P_0).Move;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gPBVCXMQvjmvSsFuMws(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape3D)P_0).Resize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XhfE2RMrnrChWF5NNbc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XV5iO2M3P3kybxyfaMk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OgR34HMl34iRotKeM67(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingRectangle3D)P_0).Rect3D;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool KL5AMTMelXO436cgvpH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape3D)P_0).Rotate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ztddtXMuBtO8IdkMwYE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MBOkBEMIy27WhvO2DFB(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jrR4ggMRSME6n0YBuVZ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object t0s0QMMaugBxIITeuGG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape3D)P_0).ModelMatrix;
	}
}
