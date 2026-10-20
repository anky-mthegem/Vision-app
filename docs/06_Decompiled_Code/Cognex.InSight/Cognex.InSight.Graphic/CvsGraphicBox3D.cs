using System;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicBox3D : CvsGraphic3D, ICvsEditableGraphicExtended
{
	private CvsEditFlags G8gBmKP6aJ;

	[CompilerGenerated]
	private CvsCogBox3D PGaBnbE9W8;

	[CompilerGenerated]
	private bool sONB9mA65Q;

	public CvsEditFlags EditFlags
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return G8gBmKP6aJ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			eNwPqSNl5ZXBXhccV1P();
			int num;
			if (GJ8VgcNQEwfKcnUT7FU())
			{
				num = 2;
				if (eNwPqSNl5ZXBXhccV1P())
				{
				}
			}
			else
			{
				num = 4;
			}
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					CheckLock();
					goto case 1;
				case 1:
				case 4:
					G8gBmKP6aJ = value & (CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation);
					break;
				default:
					num = 3;
					continue;
				case 3:
					break;
				case 5:
					return;
				}
				ySwIJENnK739iKVjjjY(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(33720));
				num = 5;
			}
		}
	}

	public CvsCogBox3D Box3D
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PGaBnbE9W8;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			PGaBnbE9W8 = value;
		}
	}

	public bool IsForHeightColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return sONB9mA65Q;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sONB9mA65Q = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicBox3D(CvsCellLocation cellLocation, CvsCogEditingBox3D editBox)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		CvsCogBox3D box3D = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				base._002Ector(cellLocation, editBox);
				num = 2;
				break;
			case 1:
			case 7:
				G8gBmKP6aJ = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
				num = 3;
				break;
			case 6:
				DCo0KlNe1wNHoZBbhyQ();
				GJ8VgcNQEwfKcnUT7FU();
				num = (eNwPqSNl5ZXBXhccV1P() ? 5 : 7);
				break;
			default:
				FromSerializableGraphic(box3D);
				num = 0;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
				box3D = (CvsCogBox3D)N4MnP2NulP7kBGO38do(editBox);
				goto default;
			case 0:
				EditFlags = (CvsEditFlags)((editBox.Move ? 1 : 0) | (rmOxRJNIZrxc56TYoZE(editBox) ? 2 : 0) | (pErCeiNRO8QJrNSJWuZ(editBox) ? 4 : 0));
				num = 8;
				break;
			case 8:
				IsForHeightColor = uGuRXWNaLdKIFsSgXgT(editBox);
				num = 9;
				break;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicBox3D(CvsGraphicBox3D graphic)
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
				base._002Ector(graphic);
				goto default;
			default:
				G8gBmKP6aJ = graphic.G8gBmKP6aJ;
				num = 6;
				break;
			case 2:
				DCo0KlNe1wNHoZBbhyQ();
				eNwPqSNl5ZXBXhccV1P();
				if (!GJ8VgcNQEwfKcnUT7FU())
				{
					num = 0;
					if (true)
					{
						break;
					}
					goto default;
				}
				num = 4;
				break;
			case 1:
			case 4:
				G8gBmKP6aJ = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
				num = 5;
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
	public CvsGraphicBox3D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		eNwPqSNl5ZXBXhccV1P();
		int num;
		if (GJ8VgcNQEwfKcnUT7FU())
		{
			num = 4;
		}
		else
		{
			num = 2;
			if (1 == 0)
			{
				goto IL_004f;
			}
		}
		goto IL_0068;
		IL_0028:
		base._002Ector();
		num = 5;
		goto IL_0068;
		IL_004f:
		G8gBmKP6aJ = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
		goto IL_0028;
		IL_0068:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 0:
			case 4:
				DCo0KlNe1wNHoZBbhyQ();
				goto IL_004f;
			case 1:
			case 2:
				goto IL_004f;
			default:
				num = 3;
				continue;
			case 5:
				return;
			}
			break;
		}
		goto IL_0028;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicBox3D(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogBox3D box3D)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base.FromSerializableGraphic(box3D);
		Box3D = box3D;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetSerializableGraphic()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCogBox3D(Box3D.ModelMatrix, Box3D.Size, Je8ymtNGmTGVKrYUCwk(Box3D));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DCo0KlNe1wNHoZBbhyQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object N4MnP2NulP7kBGO38do(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingBox3D)P_0).Box3D;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rmOxRJNIZrxc56TYoZE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape3D)P_0).Resize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pErCeiNRO8QJrNSJWuZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape3D)P_0).Rotate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uGuRXWNaLdKIFsSgXgT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingBox3D)P_0).IsForHeightColor;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GJ8VgcNQEwfKcnUT7FU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eNwPqSNl5ZXBXhccV1P()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ySwIJENnK739iKVjjjY(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Je8ymtNGmTGVKrYUCwk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape)P_0).Color;
	}
}
