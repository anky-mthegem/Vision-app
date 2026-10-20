using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicRegion : CvsGraphic, ICvsEditableGraphic
{
	private PointF pkoM9DPchw;

	private double yboMUNJGJA;

	private double UH3M0YrdaG;

	private double dDvMwRKWgW;

	private double CFGMRD2aYd;

	private Color WEBMsw4uaa;

	private Color dGbM66INjm;

	private Size b4CMHhA028;

	private Size NPiMKCTZgQ;

	private bool pxwME3TbnT;

	private bool ol3MQbq1du;

	private bool HOVMNGcSo4;

	private bool Sr9MiqsqmX;

	private RectangleF vleMdCmOdn;

	private CvsEditFlags ddcMuGAgwC;

	internal override double[] InternalData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new double[6]
			{
				iQ2I3uQhXXkTGTAsxlQ(pkoM9DPchw.Y),
				iQ2I3uQhXXkTGTAsxlQ(pkoM9DPchw.X),
				UH3M0YrdaG,
				yboMUNJGJA,
				dDvMwRKWgW,
				CFGMRD2aYd
			};
		}
	}

	public PointF Location
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return pkoM9DPchw;
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
				case 1:
				case 4:
					pkoM9DPchw = value;
					break;
				case 3:
					do
					{
						CheckLock();
						_ = 1;
						if (oFlm4MMGSEIU35oIe9R())
						{
							num = 0;
							continue;
						}
						num = 4;
						break;
					}
					while (!v1FwqLMn5SwGbPhPIFe());
					continue;
				case 5:
					return;
				}
				gdrVoQQs2n7quIyUMAN(this, Cf1SKxQL4Ku1NiKrJJv(34080));
				num = 5;
			}
		}
	}

	public double Height
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return UH3M0YrdaG;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (oFlm4MMGSEIU35oIe9R())
			{
				goto IL_001e;
			}
			goto IL_0053;
			IL_001e:
			CheckLock();
			_ = 1;
			num = ((!oFlm4MMGSEIU35oIe9R()) ? 4 : 0);
			goto IL_0053;
			IL_0053:
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 1:
				case 4:
					UH3M0YrdaG = value;
					goto IL_0080;
				default:
					goto IL_0080;
				case 5:
					return;
				}
				break;
				IL_0080:
				OnPropertyChanged(kgbOBx7BanbFa22Hp9.ol99ukmDA(34428));
				num = 5;
			}
			goto IL_001e;
		}
	}

	public double Width
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return yboMUNJGJA;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_0069;
			IL_001a:
			CheckLock();
			_ = 1;
			num = (oFlm4MMGSEIU35oIe9R() ? 3 : 4);
			goto IL_0069;
			IL_0069:
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				default:
					goto IL_0036;
				case 1:
				case 4:
					yboMUNJGJA = value;
					goto IL_0036;
				case 5:
					return;
				}
				break;
				IL_0036:
				gdrVoQQs2n7quIyUMAN(this, Cf1SKxQL4Ku1NiKrJJv(34444));
				num = 5;
			}
			goto IL_001a;
		}
	}

	public double Angle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return dDvMwRKWgW;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			v1FwqLMn5SwGbPhPIFe();
			int num;
			if (!oFlm4MMGSEIU35oIe9R())
			{
				num = 3;
				if (oFlm4MMGSEIU35oIe9R())
				{
				}
			}
			else
			{
				num = 2;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					dDvMwRKWgW = value;
					break;
				default:
					num = 4;
					continue;
				case 4:
					break;
				case 0:
				case 3:
					CheckLock();
					goto case 1;
				case 5:
					return;
				}
				gdrVoQQs2n7quIyUMAN(this, Cf1SKxQL4Ku1NiKrJJv(34112));
				num = 5;
			}
		}
	}

	public double Curve
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CFGMRD2aYd;
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
			if (v1FwqLMn5SwGbPhPIFe())
			{
				num = 4;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 2;
			}
			goto IL_003f;
			IL_007c:
			gdrVoQQs2n7quIyUMAN(this, Cf1SKxQL4Ku1NiKrJJv(34510));
			num = 5;
			if (false)
			{
				return;
			}
			goto IL_003f;
			IL_003f:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					break;
				default:
					num = 3;
					continue;
				case 0:
				case 4:
					CheckLock();
					break;
				case 3:
					goto IL_007c;
				case 5:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			CFGMRD2aYd = value;
			goto IL_007c;
		}
	}

	public Color LabelForeColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WEBMsw4uaa;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			v1FwqLMn5SwGbPhPIFe();
			int num;
			if (!oFlm4MMGSEIU35oIe9R())
			{
				num = 2;
				if (oFlm4MMGSEIU35oIe9R())
				{
				}
			}
			else
			{
				num = 3;
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
				case 3:
					WEBMsw4uaa = value;
					break;
				default:
					num = 4;
					continue;
				case 4:
					break;
				case 5:
					return;
				}
				gdrVoQQs2n7quIyUMAN(this, Cf1SKxQL4Ku1NiKrJJv(34524));
				num = 5;
			}
		}
	}

	public Color LabelBackColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return dGbM66INjm;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			v1FwqLMn5SwGbPhPIFe();
			int num;
			if (!oFlm4MMGSEIU35oIe9R())
			{
				num = 2;
				if (!v1FwqLMn5SwGbPhPIFe())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_0047;
			IL_0070:
			gdrVoQQs2n7quIyUMAN(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(34556));
			num = 5;
			if (true)
			{
				goto IL_0047;
			}
			goto IL_008c;
			IL_008c:
			CheckLock();
			goto IL_002e;
			IL_002e:
			dGbM66INjm = value;
			goto IL_0070;
			IL_0047:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					break;
				default:
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					goto IL_0070;
				case 3:
					goto IL_0070;
				case 0:
				case 2:
					goto IL_008c;
				case 5:
					return;
				}
				break;
			}
			goto IL_002e;
		}
	}

	public Size MinimumSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return b4CMHhA028;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			v1FwqLMn5SwGbPhPIFe();
			int num = ((!oFlm4MMGSEIU35oIe9R()) ? 1 : 3);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					CheckLock();
					num = 4;
					if (true)
					{
						continue;
					}
					break;
				case 4:
					b4CMHhA028 = value;
					break;
				case 5:
					return;
				}
				gdrVoQQs2n7quIyUMAN(this, Cf1SKxQL4Ku1NiKrJJv(34790));
				num = 5;
			}
		}
	}

	public Size MaximumSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return NPiMKCTZgQ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oFlm4MMGSEIU35oIe9R();
			int num;
			if (v1FwqLMn5SwGbPhPIFe())
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
			}
			goto IL_006d;
			IL_002a:
			CheckLock();
			num = 3;
			goto IL_006d;
			IL_006d:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					break;
				default:
					goto IL_003a;
				case 3:
					NPiMKCTZgQ = value;
					goto IL_003a;
				case 5:
					return;
				}
				break;
				IL_003a:
				gdrVoQQs2n7quIyUMAN(this, Cf1SKxQL4Ku1NiKrJJv(34816));
				num = 5;
			}
			goto IL_002a;
		}
	}

	public bool DisplayAxisLabels
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return pxwME3TbnT;
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
			if (!oFlm4MMGSEIU35oIe9R())
			{
				num = 2;
			}
			else
			{
				num = 3;
				if (oFlm4MMGSEIU35oIe9R())
				{
				}
			}
			while (true)
			{
				switch (num)
				{
				case 4:
					gdrVoQQs2n7quIyUMAN(this, Cf1SKxQL4Ku1NiKrJJv(34842));
					num = 5;
					if (true)
					{
						break;
					}
					goto case 0;
				case 0:
				case 2:
					CheckLock();
					goto case 1;
				case 1:
				case 3:
					pxwME3TbnT = value;
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

	public bool DisplayScanLine
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ol3MQbq1du;
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
				case 0:
				case 1:
					ol3MQbq1du = value;
					goto default;
				default:
					gdrVoQQs2n7quIyUMAN(this, Cf1SKxQL4Ku1NiKrJJv(34880));
					num = 5;
					break;
				case 3:
					CheckLock();
					oFlm4MMGSEIU35oIe9R();
					num = ((!v1FwqLMn5SwGbPhPIFe()) ? 4 : 0);
					break;
				case 5:
					return;
				}
			}
		}
	}

	public bool DisplayXArrow
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HOVMNGcSo4;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!v1FwqLMn5SwGbPhPIFe())
			{
				goto IL_001e;
			}
			goto IL_0057;
			IL_001e:
			CheckLock();
			oFlm4MMGSEIU35oIe9R();
			num = (v1FwqLMn5SwGbPhPIFe() ? 3 : 0);
			goto IL_0057;
			IL_0057:
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 1:
				case 3:
					HOVMNGcSo4 = value;
					goto IL_0084;
				default:
					goto IL_0084;
				case 5:
					return;
				}
				break;
				IL_0084:
				gdrVoQQs2n7quIyUMAN(this, Cf1SKxQL4Ku1NiKrJJv(34914));
				num = 5;
				if (!v1FwqLMn5SwGbPhPIFe())
				{
					return;
				}
			}
			goto IL_001e;
		}
	}

	public bool DisplayYArrow
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Sr9MiqsqmX;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oFlm4MMGSEIU35oIe9R();
			int num;
			if (v1FwqLMn5SwGbPhPIFe())
			{
				num = 1;
				if (!v1FwqLMn5SwGbPhPIFe())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_0076;
				}
			}
			goto IL_0047;
			IL_0086:
			gdrVoQQs2n7quIyUMAN(this, Cf1SKxQL4Ku1NiKrJJv(34944));
			num = 5;
			if (false)
			{
				return;
			}
			goto IL_0047;
			IL_0076:
			CheckLock();
			num = 3;
			goto IL_0047;
			IL_002e:
			Sr9MiqsqmX = value;
			goto IL_0086;
			IL_0047:
			switch (num)
			{
			case 3:
				break;
			case 0:
			case 1:
				goto IL_0076;
			default:
				goto IL_0086;
			case 5:
				return;
			}
			goto IL_002e;
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
			return ddcMuGAgwC;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			do
			{
				IL_005a:
				switch (num)
				{
				case 3:
					CheckLock();
					v1FwqLMn5SwGbPhPIFe();
					if (!oFlm4MMGSEIU35oIe9R())
					{
						num = 4;
						if (!oFlm4MMGSEIU35oIe9R())
						{
							goto IL_005a;
						}
						goto case 1;
					}
					num = 0;
					if (!oFlm4MMGSEIU35oIe9R())
					{
						goto IL_005a;
					}
					break;
				case 1:
				case 4:
					ddcMuGAgwC = value & (CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation | CvsEditFlags.Bend);
					break;
				case 5:
					return;
				}
				gdrVoQQs2n7quIyUMAN(this, Cf1SKxQL4Ku1NiKrJJv(33720));
				num = 5;
			}
			while (0 == 0);
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
			return vleMdCmOdn;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oFlm4MMGSEIU35oIe9R();
			int num = ((!v1FwqLMn5SwGbPhPIFe()) ? 4 : 3);
			while (true)
			{
				switch (num)
				{
				case 1:
					vleMdCmOdn = value;
					goto default;
				default:
					gdrVoQQs2n7quIyUMAN(this, Cf1SKxQL4Ku1NiKrJJv(33862));
					num = 5;
					break;
				case 0:
				case 3:
					CheckLock();
					num = 1;
					break;
				case 5:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicRegion(CvsCellLocation cellLocation, CvsCogEditingRegion editRegion)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 13;
		CvsCogRegion region = default;
		while (true)
		{
			switch (num)
			{
			case 12:
				region = editRegion.Region;
				num = 10;
				if (v1FwqLMn5SwGbPhPIFe())
				{
					break;
				}
				goto case 1;
			case 1:
				DisplayScanLine = L3tTrMM6FiDAZAMkIhM(jBsvvRMbYjIcpOZGmLp(editRegion));
				goto case 8;
			case 0:
				ddcMuGAgwC = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation | CvsEditFlags.Bend;
				num = 4;
				if (true)
				{
					break;
				}
				goto case 3;
			case 3:
				b4CMHhA028 = new Size(2, 2);
				num = 0;
				break;
			case 13:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 3;
				break;
			case 6:
				EditFlags = (CvsEditFlags)((Tirut4M0I3PpEmm4PR1(editRegion) ? 1 : 0) | (qjLLvhM4QpY2GlohAd7(editRegion) ? 8 : 0) | (xKnXboMk058LpYZI3xY(editRegion) ? 2 : 0) | (F1RmDCMfGfWXF3vatoY(editRegion) ? 4 : 0));
				LabelForeColor = sYympTMF677Y4BVajNL();
				if (VNYUFTMmoQmskua5knj(editRegion) != null)
				{
					num = 2;
					break;
				}
				goto IL_010c;
			case 2:
				vleMdCmOdn = a5rSdFMyyNMTpQymFFd(VNYUFTMmoQmskua5knj(editRegion));
				goto IL_010c;
			case 10:
				FromSerializableGraphic(region);
				num = 14;
				break;
			case 14:
				mCellLocation = cellLocation;
				goto default;
			default:
				_ = 1;
				if (oFlm4MMGSEIU35oIe9R())
				{
					num = 8;
					break;
				}
				num = 11;
				if (!oFlm4MMGSEIU35oIe9R())
				{
					break;
				}
				goto case 5;
			case 5:
				DisplayYArrow = ((CvsCogRegion)jBsvvRMbYjIcpOZGmLp(editRegion)).ShowYArrow;
				num = 6;
				break;
			case 4:
				base._002Ector(cellLocation, editRegion);
				num = 12;
				if (!oFlm4MMGSEIU35oIe9R())
				{
					break;
				}
				goto case 8;
			case 8:
			case 9:
				DisplayXArrow = MSiKx1MpO8DJpCUR0Rp(jBsvvRMbYjIcpOZGmLp(editRegion));
				num = 5;
				break;
			case 7:
			case 11:
				DisplayAxisLabels = JNcRZKMXxAmbpIVJ8Y5(editRegion.Region);
				num = 1;
				if (false)
				{
					return;
				}
				break;
			case 15:
				return;
				IL_010c:
				UniqueId = cellLocation.ToString();
				num = 15;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicRegion(CvsCellLocation cellLocation, CvsCogEditingRectangle editRect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 17;
		CvsCogRectangle cvsCogRectangle = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				DisplayAxisLabels = true;
				num = 10;
				break;
			case 12:
				ddcMuGAgwC = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation | CvsEditFlags.Bend;
				num = 7;
				break;
			case 9:
				Sr9MiqsqmX = true;
				num = 4;
				break;
			case 17:
				fOtg5EMgOqk9K4l7pww();
				num = 6;
				if (v1FwqLMn5SwGbPhPIFe())
				{
					break;
				}
				goto case 5;
			case 5:
			case 16:
				Location = new PointF((float)cN3JekMJnkC7ukweGVt(cvsCogRectangle), (float)kca83tM8opVq9T1iuSt(cvsCogRectangle));
				num = 13;
				break;
			case 8:
				cvsCogRectangle = (CvsCogRectangle)jYrJOFMZmtxNF1X0sJl(editRect);
				_ = 0;
				if (v1FwqLMn5SwGbPhPIFe())
				{
					num = 16;
					if (0 == 0)
					{
						break;
					}
					goto case 11;
				}
				num = 3;
				if (!oFlm4MMGSEIU35oIe9R())
				{
					break;
				}
				goto case 6;
			case 11:
				if (VNYUFTMmoQmskua5knj(editRect) != null)
				{
					goto case 3;
				}
				goto IL_0125;
			case 6:
				b4CMHhA028 = new Size(2, 2);
				num = 12;
				break;
			case 0:
				LabelBackColor = U2KkcfQwUyDFS0BwkCR();
				LabelForeColor = Color.Blue;
				num = 11;
				break;
			case 14:
				Angle = 0.0;
				num = 2;
				break;
			case 3:
			case 15:
				vleMdCmOdn = a5rSdFMyyNMTpQymFFd(VNYUFTMmoQmskua5knj(editRect));
				goto IL_0125;
			case 10:
				DisplayScanLine = false;
				HOVMNGcSo4 = true;
				num = 9;
				if (true)
				{
					break;
				}
				goto case 4;
			case 4:
				EditFlags = (CvsEditFlags)((editRect.Move ? 1 : 0) | (so3i5VMzBdUo6sLGcRj(editRect) ? 2 : 0));
				num = 0;
				break;
			case 7:
				base._002Ector(cellLocation, editRect);
				num = 8;
				break;
			case 2:
				Curve = 0.0;
				goto case 1;
			default:
				num = 1;
				break;
			case 13:
				Height = (float)cvsCogRectangle.Height;
				Width = (float)cvsCogRectangle.Width;
				num = 14;
				break;
			case 18:
				return;
				IL_0125:
				UniqueId = cellLocation.ToString();
				num = 18;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicRegion(CvsGraphicRegion graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 15;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 11:
				Sr9MiqsqmX = graphic.Sr9MiqsqmX;
				num = 10;
				continue;
			case 3:
				HOVMNGcSo4 = graphic.HOVMNGcSo4;
				goto case 1;
			case 6:
				pxwME3TbnT = graphic.pxwME3TbnT;
				num = 9;
				continue;
			case 16:
				dDvMwRKWgW = graphic.dDvMwRKWgW;
				CFGMRD2aYd = graphic.CFGMRD2aYd;
				goto case 6;
			default:
				num = 6;
				continue;
			case 7:
				pkoM9DPchw = graphic.pkoM9DPchw;
				v1FwqLMn5SwGbPhPIFe();
				num = (oFlm4MMGSEIU35oIe9R() ? 1 : 8);
				continue;
			case 4:
				WEBMsw4uaa = graphic.WEBMsw4uaa;
				vleMdCmOdn = graphic.vleMdCmOdn;
				ddcMuGAgwC = graphic.ddcMuGAgwC;
				num = 17;
				continue;
			case 5:
			case 8:
				yboMUNJGJA = graphic.yboMUNJGJA;
				num = 14;
				if (true)
				{
					continue;
				}
				goto case 9;
			case 9:
				ol3MQbq1du = graphic.ol3MQbq1du;
				num = 3;
				continue;
			case 0:
				base._002Ector(graphic);
				num = 7;
				if (v1FwqLMn5SwGbPhPIFe())
				{
					continue;
				}
				goto case 14;
			case 14:
				UH3M0YrdaG = graphic.UH3M0YrdaG;
				num = 16;
				if (v1FwqLMn5SwGbPhPIFe())
				{
					continue;
				}
				goto case 13;
			case 13:
				b4CMHhA028 = new Size(2, 2);
				num = 2;
				continue;
			case 2:
				ddcMuGAgwC = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation | CvsEditFlags.Bend;
				num = 0;
				if (true)
				{
					continue;
				}
				goto case 12;
			case 12:
				dGbM66INjm = graphic.dGbM66INjm;
				num = 4;
				continue;
			case 15:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 13;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 10:
				break;
			case 17:
				return;
			}
			NPiMKCTZgQ = graphic.NPiMKCTZgQ;
			b4CMHhA028 = graphic.b4CMHhA028;
			num = 12;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicRegion(CvsCellLocation cellLocation, PointF location, double height, double width, double angle, double curve, string label)
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
			case 9:
				pxwME3TbnT = true;
				ol3MQbq1du = false;
				num = 2;
				continue;
			case 6:
				ddcMuGAgwC = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation | CvsEditFlags.Bend;
				base._002Ector(cellLocation, label);
				num = 3;
				continue;
			case 12:
				dDvMwRKWgW = angle;
				goto default;
			default:
				oFlm4MMGSEIU35oIe9R();
				num = ((!v1FwqLMn5SwGbPhPIFe()) ? 13 : 10);
				continue;
			case 2:
				HOVMNGcSo4 = true;
				num = 1;
				if (oFlm4MMGSEIU35oIe9R())
				{
				}
				continue;
			case 3:
				pkoM9DPchw = location;
				num = 5;
				if (v1FwqLMn5SwGbPhPIFe())
				{
					continue;
				}
				goto case 4;
			case 4:
				fOtg5EMgOqk9K4l7pww();
				num = 8;
				if (v1FwqLMn5SwGbPhPIFe())
				{
					continue;
				}
				goto case 7;
			case 7:
			case 10:
				CFGMRD2aYd = curve;
				num = 9;
				continue;
			case 0:
				UH3M0YrdaG = height;
				num = 12;
				continue;
			case 5:
				yboMUNJGJA = width;
				num = 0;
				if (v1FwqLMn5SwGbPhPIFe())
				{
					continue;
				}
				goto case 8;
			case 8:
				b4CMHhA028 = new Size(2, 2);
				num = 6;
				continue;
			case 11:
			case 13:
				break;
			case 1:
				Sr9MiqsqmX = true;
				break;
			case 14:
				return;
			}
			UniqueId = cellLocation.ToString();
			num = 14;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicRegion()
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
			case 5:
				base._002Ector();
				goto case 0;
			case 0:
			case 4:
				Initialize(0, 0, 0.0, 0.0, 1.0, 1.0, 0.0, 0.0, "");
				num = 7;
				break;
			case 1:
				b4CMHhA028 = new Size(2, 2);
				v1FwqLMn5SwGbPhPIFe();
				if (oFlm4MMGSEIU35oIe9R())
				{
					num = 0;
					if (v1FwqLMn5SwGbPhPIFe())
					{
						break;
					}
					goto case 0;
				}
				num = 3;
				break;
			case 6:
				fOtg5EMgOqk9K4l7pww();
				num = 1;
				break;
			case 2:
			case 3:
				ddcMuGAgwC = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation | CvsEditFlags.Bend;
				goto case 5;
			default:
				num = 5;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(int cellRow, int cellCol, double regionRow, double regionCol, double regionHeight, double regionWidth, double regionAngle, double regionCurve, string regionLabel)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0104;
		IL_001a:
		ol3MQbq1du = false;
		HOVMNGcSo4 = true;
		goto IL_005c;
		IL_0104:
		while (true)
		{
			switch (num)
			{
			case 8:
			case 11:
				break;
			case 5:
				dDvMwRKWgW = regionAngle;
				num = 3;
				continue;
			case 7:
				UH3M0YrdaG = regionHeight;
				num = 5;
				continue;
			case 4:
			case 9:
				goto IL_005c;
			case 6:
				CheckLock();
				num = 12;
				continue;
			case 12:
				mCellLocation = new CvsCellLocation(cellRow, cellCol);
				pkoM9DPchw = new PointF((float)regionCol, (float)regionRow);
				num = 10;
				continue;
			case 0:
				gdrVoQQs2n7quIyUMAN(this, null);
				num = 13;
				if (0 == 0)
				{
					continue;
				}
				goto case 2;
			case 2:
				pxwME3TbnT = true;
				v1FwqLMn5SwGbPhPIFe();
				num = ((!oFlm4MMGSEIU35oIe9R()) ? 11 : 4);
				continue;
			case 10:
				yboMUNJGJA = regionWidth;
				num = 7;
				continue;
			case 3:
				CFGMRD2aYd = regionCurve;
				goto case 1;
			default:
				num = 1;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
				mLabel = regionLabel;
				num = 2;
				if (oFlm4MMGSEIU35oIe9R())
				{
				}
				continue;
			case 13:
				return;
			}
			break;
		}
		goto IL_001a;
		IL_005c:
		Sr9MiqsqmX = true;
		num = 0;
		goto IL_0104;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicRegion(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetSerializableGraphic()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCogRegion(pkoM9DPchw.X, pkoM9DPchw.Y, yboMUNJGJA, UH3M0YrdaG, dDvMwRKWgW, CFGMRD2aYd, pxwME3TbnT, ol3MQbq1du, HOVMNGcSo4, Sr9MiqsqmX, mColor.ToArgb(), mCellLocation.ToString());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogRegion region)
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
			case 10:
				Height = (float)O5MY2yQEASwUCFKJntb(region);
				_ = 1;
				num = (oFlm4MMGSEIU35oIe9R() ? 2 : 6);
				continue;
			default:
				DisplayAxisLabels = JNcRZKMXxAmbpIVJ8Y5(region);
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 9;
			case 9:
				DisplayYArrow = zH5oNaQVHIxUdDUfLIP(region);
				num = 11;
				continue;
			case 3:
			case 6:
				Width = (float)WswbTOQvtUl5htApHWj(region);
				num = 7;
				continue;
			case 0:
				base.FromSerializableGraphic(region);
				num = 8;
				continue;
			case 8:
				Location = new PointF((float)kFsdEYQ9H8DB7LKwJAk(region), (float)a3nHW6QS2vkv0YL1GkM(region));
				num = 10;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 7:
				Angle = (float)region.Angle;
				Curve = (float)l1355QQHgbK46BBxwFk(region);
				goto default;
			case 1:
				DisplayXArrow = MSiKx1MpO8DJpCUR0Rp(region);
				num = 9;
				if (true)
				{
					continue;
				}
				break;
			case 4:
				break;
			case 11:
				return;
			}
			DisplayScanLine = L3tTrMM6FiDAZAMkIhM(region);
			num = 1;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JNcRZKMXxAmbpIVJ8Y5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).ShowAxesLabels;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jBsvvRMbYjIcpOZGmLp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingRegion)P_0).Region;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool L3tTrMM6FiDAZAMkIhM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).ShowScanLine;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MSiKx1MpO8DJpCUR0Rp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).ShowXArrow;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Tirut4M0I3PpEmm4PR1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingRegion)P_0).Move;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qjLLvhM4QpY2GlohAd7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingRegion)P_0).Bend;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xKnXboMk058LpYZI3xY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingRegion)P_0).Resize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool F1RmDCMfGfWXF3vatoY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingRegion)P_0).Rotate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color sYympTMF677Y4BVajNL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.Red;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VNYUFTMmoQmskua5knj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape)P_0).Bounds;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RectangleF a5rSdFMyyNMTpQymFFd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRectangle)P_0).ToRectangleF();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool v1FwqLMn5SwGbPhPIFe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oFlm4MMGSEIU35oIe9R()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fOtg5EMgOqk9K4l7pww()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jYrJOFMZmtxNF1X0sJl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingRectangle)P_0).Rectangle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double cN3JekMJnkC7ukweGVt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRectangle)P_0).X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double kca83tM8opVq9T1iuSt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRectangle)P_0).Y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool so3i5VMzBdUo6sLGcRj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingRectangle)P_0).Resize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color U2KkcfQwUyDFS0BwkCR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.Transparent;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gdrVoQQs2n7quIyUMAN(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double iQ2I3uQhXXkTGTAsxlQ(float P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToDouble(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Cf1SKxQL4Ku1NiKrJJv(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double kFsdEYQ9H8DB7LKwJAk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double a3nHW6QS2vkv0YL1GkM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).Y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double O5MY2yQEASwUCFKJntb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double WswbTOQvtUl5htApHWj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).Width;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double l1355QQHgbK46BBxwFk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).Curve;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zH5oNaQVHIxUdDUfLIP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).ShowYArrow;
	}
}
