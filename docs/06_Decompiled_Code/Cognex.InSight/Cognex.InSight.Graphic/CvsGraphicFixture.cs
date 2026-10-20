using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicFixture : CvsGraphic, ICvsEditableGraphic
{
	private PointF wu9Jceyh18;

	private float t9JJ5Ug1yL;

	private CvsEditFlags wowJYCgxgy;

	private RectangleF s01J7NDFDn;

	internal override double[] InternalData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new double[3]
			{
				Convert.ToDouble(wu9Jceyh18.Y),
				sEZRRM3jHtIK4bM9qmy(wu9Jceyh18.X),
				Convert.ToDouble(t9JJ5Ug1yL)
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
			return wu9Jceyh18;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sgC0SL3HLAVFGrR7MEf();
			int num;
			if (!fTbeJp3V9UoMm75w9gT())
			{
				num = 4;
				if (fTbeJp3V9UoMm75w9gT())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_0047;
			IL_0084:
			LGg89d3qRNebGQLZK1t(this, H8jAux3ctM4cC2IEoNC(33886));
			num = 5;
			if (false)
			{
				return;
			}
			goto IL_0047;
			IL_0047:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					break;
				default:
					num = 2;
					continue;
				case 0:
				case 4:
					CheckLock();
					break;
				case 2:
					goto IL_0084;
				case 5:
					return;
				}
				break;
			}
			goto IL_002e;
			IL_002e:
			wu9Jceyh18 = value;
			goto IL_0084;
		}
	}

	public float Theta
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return t9JJ5Ug1yL;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (!sgC0SL3HLAVFGrR7MEf())
			{
				goto IL_001e;
			}
			goto IL_0051;
			IL_001e:
			LGg89d3qRNebGQLZK1t(this, H8jAux3ctM4cC2IEoNC(34588));
			num = 5;
			goto IL_0051;
			IL_0051:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					t9JJ5Ug1yL = value;
					break;
				case 3:
					do
					{
						CheckLock();
						fTbeJp3V9UoMm75w9gT();
						if (!sgC0SL3HLAVFGrR7MEf())
						{
							num = 4;
							continue;
						}
						num = 0;
						break;
					}
					while (1 == 0);
					continue;
				case 5:
					return;
				}
				break;
			}
			goto IL_001e;
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
			return wowJYCgxgy;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sgC0SL3HLAVFGrR7MEf();
			int num = (fTbeJp3V9UoMm75w9gT() ? 4 : 3);
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					wowJYCgxgy = value & (CvsEditFlags.Location | CvsEditFlags.Rotation);
					break;
				default:
					num = 2;
					if (fTbeJp3V9UoMm75w9gT())
					{
					}
					continue;
				case 0:
				case 3:
					CheckLock();
					goto case 1;
				case 2:
					break;
				case 5:
					return;
				}
				OnPropertyChanged(kgbOBx7BanbFa22Hp9.ol99ukmDA(33720));
				num = 5;
				if (fTbeJp3V9UoMm75w9gT())
				{
				}
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
			return s01J7NDFDn;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!sgC0SL3HLAVFGrR7MEf()) ? 3 : 2);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					CheckLock();
					goto case 1;
				case 1:
				case 3:
					s01J7NDFDn = value;
					break;
				default:
					num = 4;
					continue;
				case 4:
					break;
				case 5:
					return;
				}
				LGg89d3qRNebGQLZK1t(this, H8jAux3ctM4cC2IEoNC(33862));
				num = 5;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicFixture(CvsGraphicFixture graphic)
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
				wowJYCgxgy = CvsEditFlags.Location | CvsEditFlags.Rotation;
				goto case 2;
			case 3:
				t9JJ5Ug1yL = graphic.t9JJ5Ug1yL;
				num = 7;
				continue;
			case 5:
				wu9Jceyh18 = graphic.wu9Jceyh18;
				num = 3;
				continue;
			case 0:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				_ = 0;
				num = (sgC0SL3HLAVFGrR7MEf() ? 6 : 4);
				continue;
			case 2:
			case 4:
				base._002Ector(graphic);
				goto case 5;
			case 7:
				return;
			}
			num = 5;
			if (1 == 0)
			{
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicFixture(CvsCellLocation cellLocation, PointF point, float angle, string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		fTbeJp3V9UoMm75w9gT();
		int num;
		if (sgC0SL3HLAVFGrR7MEf())
		{
			num = 2;
			if (!sgC0SL3HLAVFGrR7MEf())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 4;
			if (!sgC0SL3HLAVFGrR7MEf())
			{
				goto IL_0084;
			}
		}
		goto IL_0049;
		IL_002e:
		base._002Ector(cellLocation, label);
		goto IL_00bb;
		IL_0084:
		wowJYCgxgy = CvsEditFlags.Location | CvsEditFlags.Rotation;
		num = 1;
		if (sgC0SL3HLAVFGrR7MEf())
		{
			goto IL_0049;
		}
		goto IL_009b;
		IL_00bb:
		wu9Jceyh18 = point;
		num = 5;
		goto IL_0049;
		IL_009b:
		t9JJ5Ug1yL = angle;
		num = 7;
		goto IL_0049;
		IL_0049:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 6:
				goto IL_0084;
			case 5:
				goto IL_009b;
			case 0:
			case 2:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 6;
				continue;
			default:
				goto IL_00bb;
			case 7:
				return;
			}
			break;
		}
		goto IL_002e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicFixture(CvsCellLocation cellLocation, CvsCogEditingFixture editFixture)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		sgC0SL3HLAVFGrR7MEf();
		int num;
		if (!fTbeJp3V9UoMm75w9gT())
		{
			num = 4;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 1;
			if (fTbeJp3V9UoMm75w9gT())
			{
			}
		}
		goto IL_011c;
		IL_002a:
		s01J7NDFDn = ((CvsCogRectangle)BUPIio3d8I8f7ScC3D2(editFixture)).ToRectangleF();
		num = 11;
		goto IL_011c;
		IL_011c:
		CvsCogFixture cvsCogFixture = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				break;
			case 6:
				cvsCogFixture = (CvsCogFixture)afcaG33ApT02YSBi7CW(editFixture);
				num = 5;
				if (fTbeJp3V9UoMm75w9gT())
				{
				}
				continue;
			case 9:
				mLabel = string.Empty;
				num = 10;
				continue;
			case 0:
			case 4:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 7;
				continue;
			case 7:
				wowJYCgxgy = CvsEditFlags.Location | CvsEditFlags.Rotation;
				goto case 1;
			case 10:
				EditFlags = (CvsEditFlags)((gIcMyo3TB23PGcOP8mN(editFixture) ? 1 : 0) | (editFixture.Rotate ? 4 : 0));
				num = 8;
				continue;
			case 3:
				t9JJ5Ug1yL = (float)cvsCogFixture.Angle;
				num = 9;
				continue;
			case 5:
				wu9Jceyh18 = new PointF((float)jt3Cym3DnY6BdaKKpxF(cvsCogFixture), (float)prFddR3UEb27o32pqop(cvsCogFixture));
				goto case 3;
			default:
				num = 3;
				continue;
			case 1:
			case 2:
				base._002Ector(cellLocation, editFixture);
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				return;
			case 11:
				return;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicFixture()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!fTbeJp3V9UoMm75w9gT())
		{
			num = 3;
		}
		else
		{
			num = 5;
			if (!sgC0SL3HLAVFGrR7MEf())
			{
				goto IL_0041;
			}
		}
		goto IL_0059;
		IL_00b0:
		EyOQJ93i18w00X2ZRGc();
		num = 4;
		goto IL_0059;
		IL_0084:
		Initialize(0, 0, 0f, 0f, 0f, "");
		num = 6;
		if (!fTbeJp3V9UoMm75w9gT())
		{
			goto IL_0059;
		}
		goto IL_00b0;
		IL_0059:
		while (true)
		{
			switch (num)
			{
			case 4:
				wowJYCgxgy = CvsEditFlags.Location | CvsEditFlags.Rotation;
				break;
			case 2:
			case 5:
				break;
			default:
				num = 1;
				continue;
			case 1:
				goto IL_0084;
			case 0:
			case 3:
				goto IL_00b0;
			case 6:
				return;
			}
			break;
		}
		goto IL_0041;
		IL_0041:
		base._002Ector();
		goto IL_0084;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(int cellRow, int cellCol, float pointRow, float pointCol, float angle, string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		while (true)
		{
			switch (num)
			{
			case 6:
				CheckLock();
				num = 1;
				break;
			case 1:
				mCellLocation = new CvsCellLocation(cellRow, cellCol);
				sgC0SL3HLAVFGrR7MEf();
				num = (fTbeJp3V9UoMm75w9gT() ? 3 : 7);
				break;
			case 4:
				t9JJ5Ug1yL = angle;
				goto case 0;
			default:
				num = 0;
				break;
			case 3:
			case 5:
				LGg89d3qRNebGQLZK1t(this, null);
				num = 8;
				break;
			case 0:
				mLabel = label;
				goto case 3;
			case 2:
			case 7:
				wu9Jceyh18 = new PointF(pointCol, pointRow);
				num = 4;
				break;
			case 8:
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
		return new CvsCogFixture(wu9Jceyh18.X, wu9Jceyh18.Y, t9JJ5Ug1yL, mColor.ToArgb(), mCellLocation.ToString());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogFixture fixture)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!sgC0SL3HLAVFGrR7MEf()) ? 2 : 4);
		while (true)
		{
			switch (num)
			{
			case 3:
				t9JJ5Ug1yL = (float)f548ge3Btjqbqmrcql2(fixture);
				num = 5;
				break;
			case 0:
			case 4:
				base.FromSerializableGraphic(fixture);
				goto case 1;
			case 1:
			case 2:
				wu9Jceyh18 = new PointF((float)fixture.X, (float)prFddR3UEb27o32pqop(fixture));
				goto case 3;
			default:
				num = 3;
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
		return new CvsGraphicFixture(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sgC0SL3HLAVFGrR7MEf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fTbeJp3V9UoMm75w9gT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object afcaG33ApT02YSBi7CW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingFixture)P_0).EditableFixture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double jt3Cym3DnY6BdaKKpxF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogFixture)P_0).X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double prFddR3UEb27o32pqop(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogFixture)P_0).Y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gIcMyo3TB23PGcOP8mN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingFixture)P_0).Move;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BUPIio3d8I8f7ScC3D2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape)P_0).Bounds;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EyOQJ93i18w00X2ZRGc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LGg89d3qRNebGQLZK1t(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double f548ge3Btjqbqmrcql2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogFixture)P_0).Angle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double sEZRRM3jHtIK4bM9qmy(float P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToDouble(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object H8jAux3ctM4cC2IEoNC(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}
}
