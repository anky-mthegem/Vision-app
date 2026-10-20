using System;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicSphere : CvsGraphic3D, ICvsEditableGraphicExtended
{
	private CvsEditFlags wRsMrAXsLi;

	[CompilerGenerated]
	private CvsCogSphere Yy4MCQtqIO;

	public CvsEditFlags EditFlags
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wRsMrAXsLi;
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
				default:
					RjlvCAQx2N6E6hdp2a4(this, nNCqgKQNDlsrurxdH8T(33720));
					num = 5;
					if (qE9mKNQt9c98r9g4dPO())
					{
						continue;
					}
					break;
				case 4:
					break;
				case 1:
				case 3:
					wRsMrAXsLi = value & (CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation);
					goto default;
				case 5:
					return;
				}
				CheckLock();
				_ = 0;
				num = (qE9mKNQt9c98r9g4dPO() ? 3 : 0);
			}
		}
	}

	public CvsCogSphere Sphere
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Yy4MCQtqIO;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Yy4MCQtqIO = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicSphere(CvsCellLocation cellLocation, CvsCogEditingSphere editSphere)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		CvsCogSphere sphere = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				wRsMrAXsLi = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
				_ = 1;
				if (!Gdvsa7QCQdxU62yQU2Q())
				{
					num = 0;
					if (true)
					{
						break;
					}
					goto case 0;
				}
				num = 5;
				break;
			case 0:
			case 2:
				base._002Ector(cellLocation, editSphere);
				goto case 3;
			case 6:
				VH8SsRQKAyAJJA1nPRL();
				num = 7;
				break;
			case 1:
				FromSerializableGraphic(sphere);
				num = 4;
				break;
			case 4:
				EditFlags = (CvsEditFlags)((Tn7DDVQoPaBWmaRQAgA(editSphere) ? 1 : 0) | (b6VyRtQPLLIGAK3cqku(editSphere) ? 2 : 0) | (L0iEXrQYIZDFaiaUXvv(editSphere) ? 4 : 0));
				num = 8;
				break;
			case 3:
			case 5:
				sphere = (CvsCogSphere)fbaawVQ5RrauoIGJKYt(editSphere);
				goto case 1;
			default:
				num = 1;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicSphere(CvsGraphicSphere graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (qE9mKNQt9c98r9g4dPO())
		{
			num = 2;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_007d;
		IL_003b:
		wRsMrAXsLi = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
		num = 3;
		goto IL_007d;
		IL_007d:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				break;
			case 1:
			case 4:
				goto IL_003b;
			case 5:
				wRsMrAXsLi = graphic.wRsMrAXsLi;
				num = 6;
				if (true)
				{
					continue;
				}
				goto case 3;
			case 3:
				base._002Ector(graphic);
				goto case 5;
			default:
				num = 5;
				continue;
			case 6:
				return;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		VH8SsRQKAyAJJA1nPRL();
		goto IL_003b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicSphere()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (qE9mKNQt9c98r9g4dPO())
		{
			num = 4;
		}
		else
		{
			num = 3;
			if (false)
			{
				goto IL_004d;
			}
		}
		goto IL_0066;
		IL_0036:
		VH8SsRQKAyAJJA1nPRL();
		goto IL_004d;
		IL_0024:
		base._002Ector();
		num = 5;
		if (1 == 0)
		{
			goto IL_0036;
		}
		goto IL_0066;
		IL_0066:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 0:
			case 4:
				goto IL_0036;
			case 1:
			case 3:
				goto IL_004d;
			default:
				num = 2;
				continue;
			case 5:
				return;
			}
			break;
		}
		goto IL_0024;
		IL_004d:
		wRsMrAXsLi = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
		goto IL_0024;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicSphere(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogSphere sphere)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base.FromSerializableGraphic(sphere);
		Sphere = sphere;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetSerializableGraphic()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCogSphere((double[])w4thX4Q12JCtCDDQprk(Sphere), OGm9I2QrptyOSBCjQ8o(Sphere), VUT9wyQ3XnPQCmmkobr(Sphere));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VH8SsRQKAyAJJA1nPRL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fbaawVQ5RrauoIGJKYt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingSphere)P_0).Sphere;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Tn7DDVQoPaBWmaRQAgA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape3D)P_0).Move;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool b6VyRtQPLLIGAK3cqku(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape3D)P_0).Resize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool L0iEXrQYIZDFaiaUXvv(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape3D)P_0).Rotate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qE9mKNQt9c98r9g4dPO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Gdvsa7QCQdxU62yQU2Q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nNCqgKQNDlsrurxdH8T(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RjlvCAQx2N6E6hdp2a4(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object w4thX4Q12JCtCDDQprk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape3D)P_0).ModelMatrix;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double OGm9I2QrptyOSBCjQ8o(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRoundShape)P_0).Radius;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int VUT9wyQ3XnPQCmmkobr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape)P_0).Color;
	}
}
