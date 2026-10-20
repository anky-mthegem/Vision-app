using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicCross : CvsGraphic, ICvsEditableGraphic
{
	private PointF uNqJIJlBRK;

	private float PHWJ1ytulg;

	private float KAdJx5PfD4;

	private float so2JFqdGnd;

	private bool qdFJbaVoda;

	private RectangleF l49JafgKiw;

	private CvsEditFlags SenJOux0GV;

	internal override double[] InternalData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new double[5]
			{
				fGxggUr9CAYh4r32RPL(uNqJIJlBRK.Y),
				fGxggUr9CAYh4r32RPL(uNqJIJlBRK.X),
				fGxggUr9CAYh4r32RPL(PHWJ1ytulg),
				fGxggUr9CAYh4r32RPL(KAdJx5PfD4),
				fGxggUr9CAYh4r32RPL(so2JFqdGnd)
			};
		}
	}

	public PointF Center
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return uNqJIJlBRK;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			while (true)
			{
				IL_0031:
				switch (num)
				{
				case 1:
				case 3:
					uNqJIJlBRK = value;
					break;
				case 0:
					while (true)
					{
						CheckLock();
						Qokex91p0rcy65hDomo();
						if (IwDHOd16KpJH2cwBBr6())
						{
							break;
						}
						num = 4;
						if (IwDHOd16KpJH2cwBBr6())
						{
							goto IL_0031;
						}
					}
					num = 3;
					if (!Qokex91p0rcy65hDomo())
					{
						continue;
					}
					break;
				case 5:
					return;
				}
				K1XYLX1ymOGnsor2gVx(this, UZZ7AxrSaFB7cxlnoCd(33886));
				num = 5;
			}
		}
	}

	public float Height
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KAdJx5PfD4;
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
			if (IwDHOd16KpJH2cwBBr6())
			{
				num = 1;
			}
			else
			{
				num = 4;
				if (!IwDHOd16KpJH2cwBBr6())
				{
					return;
				}
			}
			while (true)
			{
				switch (num)
				{
				default:
					K1XYLX1ymOGnsor2gVx(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(34428));
					num = 5;
					break;
				case 0:
				case 1:
					CheckLock();
					num = 3;
					break;
				case 3:
					KAdJx5PfD4 = value;
					goto default;
				case 5:
					return;
				}
			}
		}
	}

	public float Width
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return so2JFqdGnd;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IwDHOd16KpJH2cwBBr6();
			int num = (Qokex91p0rcy65hDomo() ? 1 : 4);
			while (true)
			{
				switch (num)
				{
				default:
					K1XYLX1ymOGnsor2gVx(this, UZZ7AxrSaFB7cxlnoCd(34444));
					num = 5;
					if (true)
					{
						break;
					}
					goto case 3;
				case 3:
					so2JFqdGnd = value;
					goto default;
				case 0:
				case 4:
					CheckLock();
					num = 3;
					break;
				case 5:
					return;
				}
			}
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
			return PHWJ1ytulg;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (Qokex91p0rcy65hDomo() ? 2 : 3);
			while (true)
			{
				switch (num)
				{
				case 4:
					OnPropertyChanged((string)UZZ7AxrSaFB7cxlnoCd(34112));
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				case 0:
				case 3:
					CheckLock();
					goto case 1;
				case 1:
				case 2:
					PHWJ1ytulg = value;
					goto case 4;
				default:
					num = 4;
					break;
				case 5:
					return;
				}
			}
		}
	}

	public bool DrawArrows
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qdFJbaVoda;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (!IwDHOd16KpJH2cwBBr6())
			{
				goto IL_001e;
			}
			goto IL_0079;
			IL_003a:
			CheckLock();
			IwDHOd16KpJH2cwBBr6();
			if (!Qokex91p0rcy65hDomo())
			{
				num = 0;
				if (Qokex91p0rcy65hDomo())
				{
					goto IL_0060;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_0079;
			IL_0060:
			qdFJbaVoda = value;
			goto IL_001e;
			IL_0079:
			switch (num)
			{
			case 3:
				goto IL_003a;
			case 0:
			case 1:
				goto IL_0060;
			case 5:
				return;
			}
			goto IL_001e;
			IL_001e:
			K1XYLX1ymOGnsor2gVx(this, UZZ7AxrSaFB7cxlnoCd(34458));
			num = 5;
			if (1 == 0)
			{
				goto IL_003a;
			}
			goto IL_0079;
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
			return SenJOux0GV;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IwDHOd16KpJH2cwBBr6();
			int num = ((!Qokex91p0rcy65hDomo()) ? 1 : 4);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					CheckLock();
					num = 3;
					if (IwDHOd16KpJH2cwBBr6())
					{
						continue;
					}
					goto case 3;
				case 3:
					SenJOux0GV = value & (CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation);
					break;
				case 5:
					return;
				}
				K1XYLX1ymOGnsor2gVx(this, UZZ7AxrSaFB7cxlnoCd(33720));
				num = 5;
			}
		}
	}

	public RectangleF EditBounds
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return l49JafgKiw;
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
			if (IwDHOd16KpJH2cwBBr6())
			{
				num = 1;
			}
			else
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_0086;
				}
			}
			goto IL_0057;
			IL_0057:
			while (true)
			{
				switch (num)
				{
				default:
					goto IL_0024;
				case 4:
					l49JafgKiw = value;
					goto IL_0024;
				case 0:
				case 1:
					break;
				case 5:
					return;
				}
				break;
				IL_0024:
				K1XYLX1ymOGnsor2gVx(this, UZZ7AxrSaFB7cxlnoCd(33862));
				num = 5;
			}
			goto IL_0086;
			IL_0086:
			CheckLock();
			num = 4;
			goto IL_0057;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicCross(CvsGraphicCross graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Qokex91p0rcy65hDomo();
		int num;
		if (IwDHOd16KpJH2cwBBr6())
		{
			num = 3;
			if (!IwDHOd16KpJH2cwBBr6())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 6;
		}
		goto IL_00a4;
		IL_002e:
		qdFJbaVoda = true;
		num = 8;
		goto IL_00a4;
		IL_00a4:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 8:
				SenJOux0GV = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
				num = 10;
				continue;
			case 0:
			case 3:
				xpabn810cDWcLI3FieD();
				num = 2;
				continue;
			case 9:
				qdFJbaVoda = zsK6Yl1mshJOPmxiSWi(graphic);
				num = 11;
				continue;
			case 10:
				base._002Ector(graphic);
				num = 4;
				continue;
			case 4:
				uNqJIJlBRK = bQDMXy14jMa3XbevUAh(graphic);
				goto default;
			case 1:
				so2JFqdGnd = X7vb0e1FU1Sgv9WGlQP(graphic);
				num = 9;
				continue;
			default:
				PHWJ1ytulg = KebnDR1kaj0I1qKN8xO(graphic);
				num = 7;
				if (true)
				{
					continue;
				}
				goto case 7;
			case 7:
				KAdJx5PfD4 = E79R0j1fAhemmehbFgq(graphic);
				num = 1;
				continue;
			case 11:
				return;
			}
			break;
		}
		goto IL_002e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicCross(CvsCellLocation cellLocation, PointF center, float angle, float height, float width, string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		while (true)
		{
			switch (num)
			{
			case 1:
				PHWJ1ytulg = angle;
				goto case 6;
			case 6:
			case 7:
				KAdJx5PfD4 = height;
				num = 9;
				break;
			case 5:
				qdFJbaVoda = true;
				num = 2;
				break;
			case 3:
			case 4:
				base._002Ector(cellLocation, label);
				num = 10;
				break;
			case 8:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 5;
				break;
			case 10:
				uNqJIJlBRK = center;
				goto case 1;
			default:
				num = 1;
				break;
			case 0:
				qdFJbaVoda = true;
				num = 11;
				if (0 == 0)
				{
					break;
				}
				goto case 9;
			case 9:
				so2JFqdGnd = width;
				num = 0;
				break;
			case 2:
				SenJOux0GV = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
				_ = 0;
				num = (IwDHOd16KpJH2cwBBr6() ? 4 : 7);
				break;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicCross()
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
			case 6:
				qdFJbaVoda = true;
				goto case 2;
			case 2:
			case 3:
				SenJOux0GV = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
				goto case 5;
			default:
				num = 5;
				break;
			case 0:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				_ = 1;
				if (Qokex91p0rcy65hDomo())
				{
					num = 3;
					if (IwDHOd16KpJH2cwBBr6())
					{
						break;
					}
					goto case 2;
				}
				num = 6;
				break;
			case 5:
				base._002Ector();
				num = 4;
				break;
			case 4:
				Initialize(0, 0, 0f, 0f, 0f, 0f, 0f, "");
				num = 7;
				if (1 == 0)
				{
					return;
				}
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(int cellRow, int cellCol, float centerRow, float centerCol, float crossAngle, float crossHeight, float crossWidth, string crossLabel)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IwDHOd16KpJH2cwBBr6();
		int num = (Qokex91p0rcy65hDomo() ? 3 : 10);
		do
		{
			IL_0042:
			switch (num)
			{
			case 1:
				KAdJx5PfD4 = crossHeight;
				goto case 9;
			default:
				num = 9;
				goto IL_0042;
			case 0:
			case 10:
				CheckLock();
				num = 5;
				goto IL_0042;
			case 4:
				mLabel = crossLabel;
				num = 6;
				goto IL_0042;
			case 8:
				PHWJ1ytulg = crossAngle;
				num = 1;
				if (IwDHOd16KpJH2cwBBr6())
				{
					goto IL_0042;
				}
				goto case 9;
			case 9:
				so2JFqdGnd = crossWidth;
				num = 4;
				goto IL_0042;
			case 5:
				mCellLocation = new CvsCellLocation(cellRow, cellCol);
				break;
			case 7:
				K1XYLX1ymOGnsor2gVx(this, null);
				num = 11;
				if (IwDHOd16KpJH2cwBBr6())
				{
					goto IL_0042;
				}
				goto case 6;
			case 6:
				qdFJbaVoda = true;
				num = 7;
				if (0 == 0)
				{
					goto IL_0042;
				}
				break;
			case 2:
			case 3:
				break;
			case 11:
				return;
			}
			uNqJIJlBRK = new PointF(centerCol, centerRow);
			num = 8;
		}
		while (0 == 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicCross(CvsCellLocation cellLocation, CvsCogEditingCross editCross)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 9;
		CvsCogCross cvsCogCross = default;
		while (true)
		{
			switch (num)
			{
			case 9:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 0;
				break;
			case 11:
				cvsCogCross = (CvsCogCross)OZWRkA1gRhSw9EvkSPh(editCross);
				uNqJIJlBRK = new PointF((float)EG0u2q1Z73Rm2HYhLU9(cvsCogCross), (float)XwNIkB1JVMBTVoXu2i5(cvsCogCross));
				num = 4;
				break;
			case 0:
				qdFJbaVoda = true;
				num = 2;
				if (Qokex91p0rcy65hDomo())
				{
				}
				break;
			case 4:
				PHWJ1ytulg = (float)SFjfZW18Rviqau7tEDw(cvsCogCross);
				goto default;
			case 1:
				l49JafgKiw = E70lWlrLKyskh6kVI4p(tw1qbUrhMdlhvUNcLqe(editCross));
				num = 13;
				break;
			case 3:
			case 10:
				base._002Ector(cellLocation, editCross);
				num = 11;
				if (IwDHOd16KpJH2cwBBr6())
				{
					break;
				}
				goto default;
			default:
				KAdJx5PfD4 = (float)cvsCogCross.Height;
				so2JFqdGnd = (float)yXaofS1zV501bHg6USc(cvsCogCross);
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 5:
				mLabel = string.Empty;
				num = 7;
				if (Qokex91p0rcy65hDomo())
				{
				}
				break;
			case 7:
				qdFJbaVoda = true;
				num = 8;
				break;
			case 8:
				EditFlags = (CvsEditFlags)((Ocpo67rw2MQ5y0IkCvk(editCross) ? 1 : 0) | (editCross.Resize ? 2 : 0) | (TGsP15rsfRv8a11Wd1b(editCross) ? 4 : 0));
				num = 1;
				break;
			case 2:
				SenJOux0GV = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
				IwDHOd16KpJH2cwBBr6();
				if (Qokex91p0rcy65hDomo())
				{
					num = 12;
					if (true)
					{
						break;
					}
					goto case 1;
				}
				num = 10;
				break;
			case 13:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetSerializableGraphic()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCogCross(uNqJIJlBRK.X, uNqJIJlBRK.Y, so2JFqdGnd, KAdJx5PfD4, PHWJ1ytulg, mColor.ToArgb(), mCellLocation.ToString());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicCross(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogCross cross)
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
			case 2:
				Angle = (float)SFjfZW18Rviqau7tEDw(cross);
				goto default;
			default:
				_ = 1;
				num = ((!Qokex91p0rcy65hDomo()) ? 1 : 6);
				break;
			case 0:
				base.FromSerializableGraphic(cross);
				num = 5;
				break;
			case 4:
			case 6:
				Height = (float)cross.Height;
				num = 7;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
			case 3:
				Width = (float)yXaofS1zV501bHg6USc(cross);
				goto case 4;
			case 5:
				Center = new PointF((float)cross.X, (float)XwNIkB1JVMBTVoXu2i5(cross));
				num = 2;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xpabn810cDWcLI3FieD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF bQDMXy14jMa3XbevUAh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicCross)P_0).Center;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float KebnDR1kaj0I1qKN8xO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicCross)P_0).Angle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float E79R0j1fAhemmehbFgq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicCross)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float X7vb0e1FU1Sgv9WGlQP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicCross)P_0).Width;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zsK6Yl1mshJOPmxiSWi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicCross)P_0).DrawArrows;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IwDHOd16KpJH2cwBBr6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Qokex91p0rcy65hDomo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void K1XYLX1ymOGnsor2gVx(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OZWRkA1gRhSw9EvkSPh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingCross)P_0).Cross;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double EG0u2q1Z73Rm2HYhLU9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCross)P_0).X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double XwNIkB1JVMBTVoXu2i5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCross)P_0).Y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double SFjfZW18Rviqau7tEDw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCross)P_0).Angle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double yXaofS1zV501bHg6USc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCross)P_0).Width;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Ocpo67rw2MQ5y0IkCvk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingCross)P_0).Move;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TGsP15rsfRv8a11Wd1b(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingCross)P_0).Rotate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tw1qbUrhMdlhvUNcLqe(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape)P_0).Bounds;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RectangleF E70lWlrLKyskh6kVI4p(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRectangle)P_0).ToRectangleF();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double fGxggUr9CAYh4r32RPL(float P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToDouble(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UZZ7AxrSaFB7cxlnoCd(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}
}
