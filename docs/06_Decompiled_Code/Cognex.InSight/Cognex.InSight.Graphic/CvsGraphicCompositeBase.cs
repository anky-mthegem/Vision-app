using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cognex.Cnx.Diagnostics;
using Cognex.Explorer.Diagnostics;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public abstract class CvsGraphicCompositeBase : CvsGraphic, ICvsEditableGraphic
{
	[CompilerGenerated]
	private bool shABZkRw57;

	private CvsCompositeSubregion[] d3lB8G6Yhu;

	private readonly RectangleF ih9BzC04TI;

	private CvsEditFlags SNUJPNAq4D;

	internal override double[] InternalData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return null;
		}
	}

	public CvsCompositeSubregion[] Subregions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return d3lB8G6Yhu;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!JZapid1S3nbslhDEhSv())
			{
				num = 3;
			}
			else
			{
				num = 2;
				if (1 == 0)
				{
					goto IL_0056;
				}
			}
			goto IL_006f;
			IL_0024:
			ua8A2l1YwXMZ5KOoWv8(this, EnB6Oy1N6kKxIIfOdGG(34138));
			num = 5;
			goto IL_006f;
			IL_0056:
			d3lB8G6Yhu = value;
			goto IL_0024;
			IL_006f:
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 0:
				case 3:
					CheckLock();
					goto IL_0056;
				case 1:
				case 2:
					goto IL_0056;
				default:
					num = 4;
					continue;
				case 5:
					return;
				}
				break;
			}
			goto IL_0024;
		}
	}

	protected virtual CvsEditFlags ValidEditFlags
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsEditFlags.Location | CvsEditFlags.Rotation | CvsEditFlags.AddItem | CvsEditFlags.DeleteItem | CvsEditFlags.EditItem;
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
			return SNUJPNAq4D;
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
					ua8A2l1YwXMZ5KOoWv8(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(33720));
					num = 5;
					break;
				case 0:
				case 1:
					SNUJPNAq4D = value & ValidEditFlags;
					goto default;
				case 4:
					CheckLock();
					hx1Ga119sieO5yAV08N();
					num = (JZapid1S3nbslhDEhSv() ? 3 : 0);
					break;
				case 5:
					return;
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
			return ih9BzC04TI;
		}
	}

	public bool MustBeExtrudeable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return shABZkRw57;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			shABZkRw57 = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicCompositeBase(CvsCompositeSubregion[] subRegions, bool mustBeExtrudeable)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (!hx1Ga119sieO5yAV08N())
		{
			goto IL_001e;
		}
		goto IL_003c;
		IL_001e:
		EditFlags = k7NaDs1vw83XD1dnJXq(this);
		goto IL_0065;
		IL_003c:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			default:
				goto IL_0065;
			case 1:
			case 4:
				d3lB8G6Yhu = MsPB2gtghk(subRegions);
				goto case 0;
			case 7:
				base._002Ector();
				num = 2;
				continue;
			case 6:
				ih9BzC04TI = RectangleF.Empty;
				num = 7;
				continue;
			case 0:
			case 5:
				MustBeExtrudeable = mustBeExtrudeable;
				num = 8;
				if (hx1Ga119sieO5yAV08N())
				{
					continue;
				}
				goto case 3;
			case 3:
				ulMqm31E9T4oNMaKTNq();
				num = 6;
				continue;
			case 8:
				return;
			}
			break;
		}
		goto IL_001e;
		IL_0065:
		JZapid1S3nbslhDEhSv();
		num = (hx1Ga119sieO5yAV08N() ? 1 : 0);
		goto IL_003c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicCompositeBase(CvsGraphicCompositeBase graphic)
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
			case 7:
				base._002Ector(graphic);
				hx1Ga119sieO5yAV08N();
				if (!JZapid1S3nbslhDEhSv())
				{
					num = 6;
					if (true)
					{
						break;
					}
					goto case 1;
				}
				num = 0;
				break;
			case 1:
				ih9BzC04TI = RectangleF.Empty;
				num = 7;
				break;
			case 0:
			case 5:
				MustBeExtrudeable = mqRl2N1VRvZsORFp1Al(graphic);
				num = 8;
				break;
			case 3:
			case 6:
				EditFlags = k7NaDs1vw83XD1dnJXq(this);
				goto case 4;
			default:
				num = 4;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
				ulMqm31E9T4oNMaKTNq();
				num = 1;
				if (0 == 0)
				{
					break;
				}
				goto case 4;
			case 4:
				d3lB8G6Yhu = MsPB2gtghk((CvsCompositeSubregion[])oDu1YU1HODTDwyX2WTc(graphic));
				goto case 0;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicCompositeBase(CvsCellLocation cellLocation, CvsCompositeSubregion[] subRegions, string label, bool mustBeExtrudeable)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		do
		{
			IL_007e:
			switch (num)
			{
			case 5:
				base._002Ector(cellLocation, label);
				goto case 0;
			case 4:
				ulMqm31E9T4oNMaKTNq();
				_ = 1;
				num = ((!JZapid1S3nbslhDEhSv()) ? 7 : 0);
				goto IL_007e;
			case 1:
			case 7:
				ih9BzC04TI = RectangleF.Empty;
				num = 5;
				goto IL_007e;
			case 0:
			case 3:
				EditFlags = k7NaDs1vw83XD1dnJXq(this);
				break;
			default:
				num = 2;
				goto IL_007e;
			case 6:
				MustBeExtrudeable = mustBeExtrudeable;
				num = 8;
				goto IL_007e;
			case 2:
				break;
			case 8:
				return;
			}
			d3lB8G6Yhu = MsPB2gtghk(subRegions);
			num = 6;
		}
		while (hx1Ga119sieO5yAV08N());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicCompositeBase(CvsCellLocation cellLocation, CvsCogEditingCompositeRegion editComposite, bool mustBeExtrudeable)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		CvsCogCompositeRegion composite = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				ulMqm31E9T4oNMaKTNq();
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
				base._002Ector(cellLocation, editComposite);
				num = 9;
				continue;
			case 9:
				composite = (CvsCogCompositeRegion)JvbjPM1Ar1IiYEYdt1l(editComposite);
				num = 3;
				continue;
			case 4:
				ih9BzC04TI = zD5Rya1iF21xgJc5UQr(editComposite.Bounds);
				goto case 6;
			case 6:
			case 7:
				MustBeExtrudeable = mustBeExtrudeable;
				num = 10;
				continue;
			case 3:
				FromSerializableGraphic(composite);
				goto default;
			default:
				_ = 0;
				num = ((!hx1Ga119sieO5yAV08N()) ? 6 : 0);
				continue;
			case 0:
			case 5:
				EditFlags = (CvsEditFlags)((rG0byY1DgU2ZkHHro5a(editComposite) ? 1 : 0) | (a8Q5AQ1UtuJNe8IrqYt(editComposite) ? 4 : 0) | (editComposite.AddRegions ? 64 : 0) | (VDrEte1TO2pLyqTk4wr(editComposite) ? 32 : 0) | (foF61V1de9qsF9tB5QZ(editComposite) ? 256 : 0));
				num = 4;
				if (hx1Ga119sieO5yAV08N())
				{
					continue;
				}
				break;
			case 2:
				break;
			case 10:
				return;
			}
			ih9BzC04TI = RectangleF.Empty;
			num = 1;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicCompositeBase(CvsCellLocation cellLocation, CvsCogEditingPolyline editPolyline)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!hx1Ga119sieO5yAV08N()) ? 3 : 9);
		CvsCogCompositeRegion composite = default;
		do
		{
			IL_013a:
			switch (num)
			{
			case 2:
				MustBeExtrudeable = false;
				num = 10;
				if (JZapid1S3nbslhDEhSv())
				{
				}
				goto IL_013a;
			case 5:
				composite = (CvsCogCompositeRegion)B2aotO1qs7ibACoNRZM(editPolyline);
				num = 7;
				if (!JZapid1S3nbslhDEhSv())
				{
					goto IL_013a;
				}
				goto case 0;
			case 0:
			case 9:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				break;
			case 6:
				base._002Ector(cellLocation, editPolyline);
				num = 5;
				goto IL_013a;
			case 4:
				EditFlags = (CvsEditFlags)((XiU9sG1BCrpMNsT51RQ(editPolyline) ? 1 : 0) | (editPolyline.Rotate ? 4 : 0) | (PZAJhR1jCAVJU5M080O(editPolyline) ? 2 : 0) | (U6LC8V1cZqLHhZmRa0l(editPolyline) ? 64 : 0) | (mjh3Ey12eQU8J2trVCK(editPolyline) ? 32 : 0) | (wFgcLi1WEaO5ut1gJZe(editPolyline) ? 256 : 0));
				num = 8;
				goto IL_013a;
			case 8:
				ih9BzC04TI = zD5Rya1iF21xgJc5UQr(SLQw9y17Tr5OWDPrmkg(editPolyline));
				num = 2;
				if (0 == 0)
				{
					goto IL_013a;
				}
				goto case 7;
			case 7:
				FromSerializableGraphic(composite);
				goto case 4;
			default:
				num = 4;
				goto IL_013a;
			case 1:
			case 3:
				break;
			case 10:
				return;
			}
			ih9BzC04TI = RectangleF.Empty;
			num = 6;
		}
		while (!JZapid1S3nbslhDEhSv());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicCompositeBase(CvsCellLocation cellLocation, CvsCogEditingMaskedRegion editMaskedRegion)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		CvsCogCompositeRegion composite = default;
		while (true)
		{
			switch (num)
			{
			case 5:
			case 8:
				EditFlags = (CvsEditFlags)((Flr8di1Ctqn3TCistDL(editMaskedRegion) ? 1 : 0) | (RxAPKe1KoQqbs4jW3CA(editMaskedRegion) ? 4 : 0) | (RcsyOF15KdTtGXxxdbV(editMaskedRegion) ? 2 : 0) | (editMaskedRegion.Bend ? 8 : 0) | (editMaskedRegion.AddRegions ? 64 : 0) | (dKW5NH1oaPpeT4cDrIG(editMaskedRegion) ? 32 : 0) | (a4W3hx1PbPeb76EbVmt(editMaskedRegion) ? 256 : 0));
				break;
			case 3:
				base._002Ector(cellLocation, editMaskedRegion);
				num = 4;
				continue;
			case 1:
				MustBeExtrudeable = false;
				num = 10;
				continue;
			case 4:
				composite = (CvsCogCompositeRegion)HCoLry1tYaBR2GoHhaL(editMaskedRegion);
				num = 9;
				if (true)
				{
					continue;
				}
				goto case 9;
			case 9:
				FromSerializableGraphic(composite);
				goto default;
			default:
				hx1Ga119sieO5yAV08N();
				num = ((!JZapid1S3nbslhDEhSv()) ? 8 : 0);
				continue;
			case 7:
				ih9BzC04TI = RectangleF.Empty;
				num = 3;
				continue;
			case 2:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 7;
				continue;
			case 0:
			case 6:
				break;
			case 10:
				return;
			}
			ih9BzC04TI = zD5Rya1iF21xgJc5UQr(editMaskedRegion.Bounds);
			num = 1;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicCompositeBase(bool mustBeExtrudeable)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!JZapid1S3nbslhDEhSv())
		{
			num = 1;
			if (!hx1Ga119sieO5yAV08N())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_0057;
		IL_003f:
		base._002Ector();
		goto IL_009d;
		IL_0057:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				break;
			case 2:
				goto IL_003f;
			case 4:
				ih9BzC04TI = RectangleF.Empty;
				num = 2;
				continue;
			default:
				goto IL_009d;
			case 6:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		ulMqm31E9T4oNMaKTNq();
		num = 4;
		if (!hx1Ga119sieO5yAV08N())
		{
			goto IL_003f;
		}
		goto IL_0057;
		IL_009d:
		Initialize(0, 0, new CvsCompositeSubregion[0], string.Empty, mustBeExtrudeable);
		num = 6;
		goto IL_0057;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(int cellRow, int cellCol, CvsCompositeSubregion[] subRegions, string Label, bool mustBeExtrudeable)
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
			case 3:
			case 7:
				d3lB8G6Yhu = MsPB2gtghk(subRegions);
				goto case 0;
			default:
				num = 0;
				continue;
			case 5:
				MustBeExtrudeable = mustBeExtrudeable;
				num = 2;
				if (hx1Ga119sieO5yAV08N())
				{
					continue;
				}
				goto case 4;
			case 4:
				CheckLock();
				hx1Ga119sieO5yAV08N();
				if (!JZapid1S3nbslhDEhSv())
				{
					num = 8;
					continue;
				}
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 1:
			case 8:
				EditFlags = k7NaDs1vw83XD1dnJXq(this);
				num = 6;
				continue;
			case 0:
				mLabel = Label;
				num = 5;
				if (hx1Ga119sieO5yAV08N())
				{
					continue;
				}
				goto case 6;
			case 6:
				mCellLocation = new CvsCellLocation(cellRow, cellCol);
				goto case 3;
			case 2:
				break;
			case 9:
				return;
			}
			ua8A2l1YwXMZ5KOoWv8(this, null);
			num = 9;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CvsCompositeSubregion[] MsPB2gtghk(CvsCompositeSubregion[] P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		JZapid1S3nbslhDEhSv();
		int num = ((!hx1Ga119sieO5yAV08N()) ? 2 : 3);
		int num3 = default;
		int num2 = default;
		CvsCompositeSubregion[] array2 = default;
		CvsCompositeSubregion src = default;
		CvsCompositeSubregion[] array = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				num3 = 0;
				num = 7;
				if (JZapid1S3nbslhDEhSv())
				{
				}
				break;
			case 1:
				num2++;
				num = 5;
				break;
			case 4:
				return new CvsCompositeSubregion[0];
			case 5:
			case 9:
				if (num2 >= array2.Length)
				{
					num = 11;
					break;
				}
				src = array2[num2];
				goto case 2;
			case 0:
			case 3:
				if (P_0 != null)
				{
					array = new CvsCompositeSubregion[P_0.Length];
					num = 8;
				}
				else
				{
					num = 4;
				}
				break;
			case 7:
				array2 = P_0;
				num = 10;
				if (!JZapid1S3nbslhDEhSv())
				{
					break;
				}
				goto case 2;
			case 2:
			case 6:
				array[num3++] = new CvsCompositeSubregion(src);
				num = 1;
				break;
			case 10:
				num2 = 0;
				goto case 5;
			default:
				num = 9;
				break;
			case 11:
				return array;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCompositeSubregion InsertGraphic(int index, CvsGraphic graphic, CvsCompositeOperation operation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 9;
		CvsCompositeSubregion result = default;
		if (true)
		{
			CvsGraphicPolygon cvsGraphicPolygon = default;
			CvsGraphicRegion cvsGraphicRegion = default;
			CvsGraphicCircle cvsGraphicCircle = default;
			CvsGraphicAnnulus cvsGraphicAnnulus = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (cvsGraphicPolygon == null)
					{
						break;
					}
					num = 4;
					if (hx1Ga119sieO5yAV08N())
					{
						continue;
					}
					goto case 7;
				case 7:
					cvsGraphicRegion = graphic as CvsGraphicRegion;
					if (cvsGraphicRegion == null)
					{
						cvsGraphicCircle = graphic as CvsGraphicCircle;
						if (cvsGraphicCircle != null)
						{
							num = 6;
							continue;
						}
						cvsGraphicAnnulus = graphic as CvsGraphicAnnulus;
						goto case 12;
					}
					num = 11;
					continue;
				case 11:
					result = InsertRegion(index, cvsGraphicRegion, operation);
					num = 3;
					continue;
				default:
					num = 12;
					continue;
				case 9:
					result = null;
					num = 7;
					continue;
				case 12:
					if (cvsGraphicAnnulus == null)
					{
						cvsGraphicPolygon = graphic as CvsGraphicPolygon;
						num = 2;
						if (true)
						{
							continue;
						}
						goto case 2;
					}
					num = 0;
					continue;
				case 6:
					result = InsertCircle(index, cvsGraphicCircle, operation);
					_ = 1;
					num = (JZapid1S3nbslhDEhSv() ? 1 : 10);
					continue;
				case 0:
					result = InsertAnnulus(index, cvsGraphicAnnulus, operation);
					break;
				case 4:
					result = InsertPolygon(index, cvsGraphicPolygon, operation);
					num = 13;
					continue;
				case 1:
				case 3:
				case 5:
				case 8:
				case 10:
				case 13:
					break;
				}
				break;
			}
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pciByUCy0f(int P_0, CvsCompositeSubregion P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		List<CvsCompositeSubregion> list = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				list = new List<CvsCompositeSubregion>(d3lB8G6Yhu);
				num = 2;
				if (JZapid1S3nbslhDEhSv())
				{
				}
				break;
			case 3:
				CheckLock();
				num = 0;
				break;
			case 8:
				list.Add(P_1);
				goto case 1;
			default:
				num = 4;
				break;
			case 1:
			case 4:
			case 5:
				d3lB8G6Yhu = list.ToArray();
				goto case 6;
			case 6:
			case 7:
				ua8A2l1YwXMZ5KOoWv8(this, EnB6Oy1N6kKxIIfOdGG(34162));
				num = 9;
				break;
			case 2:
				if (P_0 >= 0)
				{
					list.Insert(P_0, P_1);
					_ = 0;
					if (!hx1Ga119sieO5yAV08N())
					{
						num = 7;
						break;
					}
					num = 1;
					if (JZapid1S3nbslhDEhSv())
					{
					}
				}
				else
				{
					num = 8;
				}
				break;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCompositeSubregion InsertRegion(int index, CvsGraphicRegion region, CvsCompositeOperation operation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCompositeSubregion cvsCompositeSubregion = new CvsCompositeSubregion(region, operation);
		pciByUCy0f(index, cvsCompositeSubregion);
		return cvsCompositeSubregion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCompositeSubregion InsertCircle(int index, CvsGraphicCircle circle, CvsCompositeOperation operation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCompositeSubregion cvsCompositeSubregion = new CvsCompositeSubregion(circle, operation);
		pciByUCy0f(index, cvsCompositeSubregion);
		return cvsCompositeSubregion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCompositeSubregion InsertAnnulus(int index, CvsGraphicAnnulus annulus, CvsCompositeOperation operation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCompositeSubregion cvsCompositeSubregion = new CvsCompositeSubregion(annulus, operation);
		pciByUCy0f(index, cvsCompositeSubregion);
		return cvsCompositeSubregion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCompositeSubregion InsertPolygon(int index, CvsGraphicPolygon polygon, CvsCompositeOperation operation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCompositeSubregion cvsCompositeSubregion = new CvsCompositeSubregion(polygon, operation);
		pciByUCy0f(index, cvsCompositeSubregion);
		return cvsCompositeSubregion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearSubregions()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		hx1Ga119sieO5yAV08N();
		int num = (JZapid1S3nbslhDEhSv() ? 3 : 2);
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
				d3lB8G6Yhu = new CvsCompositeSubregion[0];
				break;
			default:
				num = 4;
				continue;
			case 4:
				break;
			case 5:
				return;
			}
			ua8A2l1YwXMZ5KOoWv8(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(34196));
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteSubregionByIndex(int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		List<CvsCompositeSubregion> list = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				CheckLock();
				num = 1;
				if (true)
				{
					continue;
				}
				goto case 3;
			case 3:
			case 5:
				d3lB8G6Yhu = (CvsCompositeSubregion[])yTHoFv11yDlFTlwghxL(list);
				break;
			case 0:
				uqaVs91xC77fLA7n0cO(list, index);
				goto default;
			default:
				_ = 0;
				num = (hx1Ga119sieO5yAV08N() ? 5 : 2);
				continue;
			case 1:
				list = new List<CvsCompositeSubregion>(d3lB8G6Yhu);
				num = 0;
				if (!JZapid1S3nbslhDEhSv())
				{
					continue;
				}
				break;
			case 2:
			case 4:
				break;
			case 7:
				return;
			}
			ua8A2l1YwXMZ5KOoWv8(this, EnB6Oy1N6kKxIIfOdGG(34196));
			num = 7;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteSubregionAfterIndex(int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (JZapid1S3nbslhDEhSv() ? 5 : 4);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				if (index > d3lB8G6Yhu.Length - 1)
				{
					num = 2;
					if (true)
					{
						break;
					}
					goto case 0;
				}
				Array.Resize(ref d3lB8G6Yhu, index + 1);
				goto case 3;
			case 0:
			case 4:
				if (index >= 0)
				{
					goto case 1;
				}
				goto case 2;
			case 3:
				ua8A2l1YwXMZ5KOoWv8(this, EnB6Oy1N6kKxIIfOdGG(34196));
				num = 6;
				if (!JZapid1S3nbslhDEhSv())
				{
					break;
				}
				goto case 2;
			case 2:
				throw new ArgumentException(kgbOBx7BanbFa22Hp9.ol99ukmDA(34230));
			default:
				num = 3;
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
	public void DeleteSubregionBeforeIndex(int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0033;
		IL_001a:
		int num2 = default;
		CvsCompositeSubregion[] array = new CvsCompositeSubregion[num2];
		goto IL_00b0;
		IL_0033:
		while (true)
		{
			switch (num)
			{
			case 7:
				break;
			case 5:
				goto IL_0072;
			case 1:
				d3lB8G6Yhu = array;
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 6;
			case 6:
				if (index >= 0)
				{
					num = 8;
					continue;
				}
				goto case 2;
			default:
				goto IL_00b0;
			case 2:
			case 3:
				throw new ArgumentException(kgbOBx7BanbFa22Hp9.ol99ukmDA(34230));
			case 8:
				goto IL_00ee;
			case 9:
				return;
			}
			break;
			IL_00ee:
			if (index <= d3lB8G6Yhu.Length - 1)
			{
				num2 = d3lB8G6Yhu.Length - index;
				num = 7;
				continue;
			}
			hx1Ga119sieO5yAV08N();
			if (JZapid1S3nbslhDEhSv())
			{
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				goto IL_0072;
			}
			num = 3;
			continue;
			IL_0072:
			OnPropertyChanged(kgbOBx7BanbFa22Hp9.ol99ukmDA(34196));
			num = 9;
		}
		goto IL_001a;
		IL_00b0:
		kQu4Tj1rtmoX8UFUh3g(d3lB8G6Yhu, index, array, 0, num2);
		num = 1;
		goto IL_0033;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteSubregion(CvsCompositeSubregion subRegion)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		if (!JZapid1S3nbslhDEhSv())
		{
		}
		int num2 = default;
		List<CvsCompositeSubregion> list = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 4:
				if (num2 >= QNjVBC137ag8TCIWure(list))
				{
					num = 11;
				}
				else if (list[num2] != subRegion)
				{
					num2++;
					num = 3;
				}
				else
				{
					num = 1;
				}
				break;
			case 8:
				CheckLock();
				num = 5;
				break;
			case 2:
				return;
			case 7:
				return;
			case 9:
				d3lB8G6Yhu = (CvsCompositeSubregion[])yTHoFv11yDlFTlwghxL(list);
				_ = 0;
				if (hx1Ga119sieO5yAV08N())
				{
					num = 10;
					if (hx1Ga119sieO5yAV08N())
					{
						break;
					}
					goto case 1;
				}
				num = 2;
				break;
			case 1:
				uqaVs91xC77fLA7n0cO(list, num2);
				goto case 9;
			default:
				num = 9;
				if (!JZapid1S3nbslhDEhSv())
				{
					break;
				}
				goto case 0;
			case 0:
				num2 = 0;
				num = 4;
				break;
			case 6:
			case 10:
				ua8A2l1YwXMZ5KOoWv8(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(34196));
				return;
			case 5:
				list = new List<CvsCompositeSubregion>(d3lB8G6Yhu);
				num = 0;
				break;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSubregionOperation(int index, CvsCompositeOperation operation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_003a;
		IL_001a:
		d3lB8G6Yhu[index].Operation = operation;
		goto IL_0083;
		IL_003a:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			case 3:
				goto IL_0067;
			default:
				goto IL_0083;
			case 5:
				return;
			}
			break;
			IL_0067:
			CheckLock();
			_ = 0;
			num = (hx1Ga119sieO5yAV08N() ? 4 : 0);
		}
		goto IL_001a;
		IL_0083:
		OnPropertyChanged((string)EnB6Oy1N6kKxIIfOdGG(34270));
		num = 5;
		goto IL_003a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCompositeOperation GetSubregionOperation(int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return d3lB8G6Yhu[index].Operation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BJXBVmuVZ1(int P_0, CvsCompositeSubregion P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		hx1Ga119sieO5yAV08N();
		int num = (JZapid1S3nbslhDEhSv() ? 1 : 3);
		while (true)
		{
			switch (num)
			{
			default:
				ua8A2l1YwXMZ5KOoWv8(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(34310));
				num = 5;
				if (JZapid1S3nbslhDEhSv())
				{
				}
				break;
			case 4:
				d3lB8G6Yhu[P_0] = P_1;
				goto default;
			case 0:
			case 3:
				CheckLock();
				num = 4;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSubregionRegion(int index, CvsGraphicRegion region)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCompositeOperation subregionOperation = GetSubregionOperation(index);
		BJXBVmuVZ1(index, new CvsCompositeSubregion(region, subregionOperation));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSubregionCircle(int index, CvsGraphicCircle circle)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCompositeOperation subregionOperation = GetSubregionOperation(index);
		BJXBVmuVZ1(index, new CvsCompositeSubregion(circle, subregionOperation));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSubregionAnnulus(int index, CvsGraphicAnnulus annulus)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCompositeOperation subregionOperation = GetSubregionOperation(index);
		BJXBVmuVZ1(index, new CvsCompositeSubregion(annulus, subregionOperation));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSubregionPolygon(int index, CvsGraphicPolygon polygon)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCompositeOperation subregionOperation = GetSubregionOperation(index);
		BJXBVmuVZ1(index, new CvsCompositeSubregion(polygon, subregionOperation));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetSerializableGraphic()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 13;
		CvsCogCompositeRegion cvsCogCompositeRegion = default;
		CvsCogSubRegion[] array = default;
		int num2 = default;
		CvsCompositeSubregion cvsCompositeSubregion = default;
		CvsCogShape shape = default;
		CvsCompositeShapeType cvsCompositeShapeType = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				YEHg4W1ektYSAAY157c(cvsCogCompositeRegion, array);
				num = 15;
				break;
			case 0:
			case 5:
			case 7:
			case 8:
			case 10:
			case 14:
				array[num2] = new CvsCogSubRegion(bNHuIW1lu0LQqjgWXQf(cvsCompositeSubregion) == CvsCompositeOperation.Add, shape);
				num2++;
				goto case 1;
			case 1:
				if (num2 >= Subregions.Length)
				{
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				}
				cvsCompositeSubregion = Subregions[num2];
				num = 11;
				break;
			case 12:
				array = new CvsCogSubRegion[Subregions.Length];
				hx1Ga119sieO5yAV08N();
				num = ((!JZapid1S3nbslhDEhSv()) ? 4 : 0);
				break;
			case 11:
				shape = null;
				num = 3;
				break;
			case 9:
				switch (cvsCompositeShapeType)
				{
				case CvsCompositeShapeType.RegionType:
					goto IL_005f;
				case CvsCompositeShapeType.PolygonType:
					goto IL_0136;
				case CvsCompositeShapeType.CircleType:
					goto IL_018c;
				case CvsCompositeShapeType.AnnulusType:
					shape = zDR3kw1QX27LkEftLSx(cvsCompositeSubregion.InSightGraphic as CvsGraphicAnnulus) as CvsCogShape;
					break;
				}
				goto case 0;
			default:
				num = 5;
				if (true)
				{
					break;
				}
				goto case 0;
			case 3:
				cvsCompositeShapeType = VUKnIL1Omjod96rXuXe(cvsCompositeSubregion);
				num = 9;
				if (!JZapid1S3nbslhDEhSv())
				{
					break;
				}
				goto case 1;
			case 2:
			case 4:
				num2 = 0;
				num = 1;
				if (hx1Ga119sieO5yAV08N())
				{
					break;
				}
				goto case 0;
			case 13:
				cvsCogCompositeRegion = new CvsCogCompositeRegion();
				num = 12;
				break;
			case 15:
				{
					return cvsCogCompositeRegion;
				}
				IL_018c:
				shape = zDR3kw1QX27LkEftLSx(TwNFNc1MMn2KKR2tgwu(cvsCompositeSubregion) as CvsGraphicCircle) as CvsCogShape;
				num = 8;
				if (hx1Ga119sieO5yAV08N())
				{
					break;
				}
				goto case 2;
				IL_0136:
				shape = zDR3kw1QX27LkEftLSx(TwNFNc1MMn2KKR2tgwu(cvsCompositeSubregion) as CvsGraphicPolygon) as CvsCogShape;
				num = 7;
				break;
				IL_005f:
				shape = zDR3kw1QX27LkEftLSx(TwNFNc1MMn2KKR2tgwu(cvsCompositeSubregion) as CvsGraphicRegion) as CvsCogShape;
				num = 14;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogCompositeRegion composite)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 20;
		int num2 = default;
		CvsGraphicRegion cvsGraphicRegion = default;
		CvsCompositeOperation operation = default;
		CvsCogRegion region = default;
		int num4 = default;
		CvsCogSubRegion[] array = default;
		CvsCogSubRegion cvsCogSubRegion = default;
		CvsGraphicAnnulus cvsGraphicAnnulus = default;
		CvsCogAnnulus cvsCogAnnulus = default;
		CvsCogPolygon cvsCogPolygon = default;
		CvsCogCircle cvsCogCircle = default;
		CvsGraphicCircle cvsGraphicCircle = default;
		while (true)
		{
			int num3;
			switch (num)
			{
			case 23:
				num3 = 0;
				goto IL_001f;
			case 17:
				Subregions[num2] = new CvsCompositeSubregion(cvsGraphicRegion, operation);
				num = 6;
				continue;
			case 4:
				cvsGraphicRegion.FromSerializableGraphic(region);
				num = 17;
				continue;
			case 3:
			case 5:
				if (num4 >= array.Length)
				{
					num = 25;
					if (hx1Ga119sieO5yAV08N())
					{
						continue;
					}
					goto case 0;
				}
				cvsCogSubRegion = array[num4];
				num = 24;
				continue;
			case 0:
				cvsGraphicAnnulus = new CvsGraphicAnnulus();
				num = 14;
				continue;
			case 19:
				Subregions = new CvsCompositeSubregion[((Array)FYJZGH1uDRhuRNeJiNw(composite)).Length];
				num = 10;
				if (JZapid1S3nbslhDEhSv())
				{
				}
				continue;
			case 14:
				OvrCmt1nH3iHF4ZQMc5(cvsGraphicAnnulus, cvsCogAnnulus);
				num = 8;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 7:
				num4 = 0;
				num = 5;
				continue;
			case 16:
				cvsCogPolygon = (CvsCogPolygon)GAAygB1RspViiFEWLCj(cvsCogSubRegion);
				num = 18;
				continue;
			case 1:
			case 2:
			case 6:
			case 13:
			case 21:
				num2++;
				num = 11;
				if (true)
				{
					continue;
				}
				goto case 9;
			case 9:
				cvsCogCircle = (CvsCogCircle)GAAygB1RspViiFEWLCj(cvsCogSubRegion);
				num = 15;
				continue;
			case 15:
				cvsGraphicCircle = new CvsGraphicCircle();
				XCjQQr1akwgJ5A7d8rl(cvsGraphicCircle, cvsCogCircle);
				goto default;
			default:
				_ = 1;
				if (!JZapid1S3nbslhDEhSv())
				{
					num = 22;
					if (hx1Ga119sieO5yAV08N())
					{
						continue;
					}
					goto case 24;
				}
				num = 21;
				continue;
			case 24:
				if (FtDd8v1IesLW1PbTt4R(cvsCogSubRegion))
				{
					num3 = 1;
					goto IL_001f;
				}
				num = 23;
				continue;
			case 8:
				Subregions[num2] = new CvsCompositeSubregion(cvsGraphicAnnulus, operation);
				num = 1;
				continue;
			case 20:
				base.FromSerializableGraphic(composite);
				num = 19;
				continue;
			case 18:
			{
				CvsGraphicPolygon cvsGraphicPolygon = new CvsGraphicPolygon();
				iBrRi01GhLPT4BfM41D(cvsGraphicPolygon, cvsCogPolygon);
				Subregions[num2] = new CvsCompositeSubregion(cvsGraphicPolygon, operation);
				goto case 1;
			}
			case 12:
			case 22:
				Subregions[num2] = new CvsCompositeSubregion(cvsGraphicCircle, operation);
				goto case 1;
			case 10:
				num2 = 0;
				array = (CvsCogSubRegion[])FYJZGH1uDRhuRNeJiNw(composite);
				num = 7;
				if (hx1Ga119sieO5yAV08N())
				{
					continue;
				}
				break;
			case 11:
				break;
			case 25:
				return;
				IL_001f:
				operation = (CvsCompositeOperation)num3;
				if (cvsCogSubRegion.Shape is CvsCogRegion)
				{
					region = (CvsCogRegion)GAAygB1RspViiFEWLCj(cvsCogSubRegion);
					cvsGraphicRegion = new CvsGraphicRegion();
					num = 4;
					continue;
				}
				if (cvsCogSubRegion.Shape is CvsCogCircle)
				{
					num = 9;
					continue;
				}
				if (!(GAAygB1RspViiFEWLCj(cvsCogSubRegion) is CvsCogAnnulus))
				{
					if (cvsCogSubRegion.Shape is CvsCogPolygon)
					{
						num = 16;
						if (0 == 0)
						{
							continue;
						}
						goto case 8;
					}
					CnxTraceChannel error = CvsTrace.Display.Error;
					object format = EnB6Oy1N6kKxIIfOdGG(34338);
					object[] array2 = new object[1];
					CvsCogShape shape = cvsCogSubRegion.Shape;
					array2[0] = ((shape != null) ? BGdYxP1bOLslIAheuIV(PkZkpD1XU2KVdWisFbo(shape)) : null);
					error.TraceMessage((string)format, array2);
					num = 2;
					continue;
				}
				cvsCogAnnulus = (CvsCogAnnulus)cvsCogSubRegion.Shape;
				num = 0;
				continue;
			}
			num4++;
			num = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ulMqm31E9T4oNMaKTNq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsEditFlags k7NaDs1vw83XD1dnJXq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicCompositeBase)P_0).ValidEditFlags;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hx1Ga119sieO5yAV08N()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JZapid1S3nbslhDEhSv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oDu1YU1HODTDwyX2WTc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicCompositeBase)P_0).Subregions;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mqRl2N1VRvZsORFp1Al(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicCompositeBase)P_0).MustBeExtrudeable;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JvbjPM1Ar1IiYEYdt1l(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingCompositeRegion)P_0).Region;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rG0byY1DgU2ZkHHro5a(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingCompositeRegion)P_0).Move;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool a8Q5AQ1UtuJNe8IrqYt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingCompositeRegion)P_0).Rotate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VDrEte1TO2pLyqTk4wr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingCompositeRegion)P_0).RemoveRegions;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool foF61V1de9qsF9tB5QZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingCompositeRegion)P_0).EditRegions;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RectangleF zD5Rya1iF21xgJc5UQr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRectangle)P_0).ToRectangleF();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object B2aotO1qs7ibACoNRZM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingPolyline)P_0).Region;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XiU9sG1BCrpMNsT51RQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingPolyline)P_0).Move;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PZAJhR1jCAVJU5M080O(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingPolyline)P_0).Scale;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool U6LC8V1cZqLHhZmRa0l(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingPolyline)P_0).AddPoints;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mjh3Ey12eQU8J2trVCK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingPolyline)P_0).RemovePoints;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wFgcLi1WEaO5ut1gJZe(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingPolyline)P_0).MovePoints;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SLQw9y17Tr5OWDPrmkg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape)P_0).Bounds;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HCoLry1tYaBR2GoHhaL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingMaskedRegion)P_0).Region;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Flr8di1Ctqn3TCistDL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingMaskedRegion)P_0).Move;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RxAPKe1KoQqbs4jW3CA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingMaskedRegion)P_0).Rotate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RcsyOF15KdTtGXxxdbV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingMaskedRegion)P_0).Resize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dKW5NH1oaPpeT4cDrIG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingMaskedRegion)P_0).RemoveRegions;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool a4W3hx1PbPeb76EbVmt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingMaskedRegion)P_0).EditRegions;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ua8A2l1YwXMZ5KOoWv8(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EnB6Oy1N6kKxIIfOdGG(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uqaVs91xC77fLA7n0cO(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((List<CvsCompositeSubregion>)P_0).RemoveAt(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yTHoFv11yDlFTlwghxL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsCompositeSubregion>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kQu4Tj1rtmoX8UFUh3g(object P_0, int P_1, object P_2, int P_3, int P_4)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Array.Copy((Array)P_0, P_1, (Array)P_2, P_3, P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int QNjVBC137ag8TCIWure(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsCompositeSubregion>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCompositeShapeType VUKnIL1Omjod96rXuXe(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCompositeSubregion)P_0).ShapeType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TwNFNc1MMn2KKR2tgwu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCompositeSubregion)P_0).InSightGraphic;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zDR3kw1QX27LkEftLSx(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphic)P_0).GetSerializableGraphic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCompositeOperation bNHuIW1lu0LQqjgWXQf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCompositeSubregion)P_0).Operation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YEHg4W1ektYSAAY157c(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogCompositeRegion)P_0).SubRegions = (CvsCogSubRegion[])P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FYJZGH1uDRhuRNeJiNw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCompositeRegion)P_0).SubRegions;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FtDd8v1IesLW1PbTt4R(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSubRegion)P_0).Add;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GAAygB1RspViiFEWLCj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSubRegion)P_0).Shape;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XCjQQr1akwgJ5A7d8rl(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicCircle)P_0).FromSerializableGraphic((CvsCogCircle)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OvrCmt1nH3iHF4ZQMc5(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicAnnulus)P_0).FromSerializableGraphic((CvsCogAnnulus)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iBrRi01GhLPT4BfM41D(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicPolygon)P_0).FromSerializableGraphic((CvsCogPolygon)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type PkZkpD1XU2KVdWisFbo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0.GetType();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BGdYxP1bOLslIAheuIV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MemberInfo)P_0).Name;
	}
}
