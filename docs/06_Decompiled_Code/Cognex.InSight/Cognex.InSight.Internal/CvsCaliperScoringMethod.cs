using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cognex.InSight.Properties;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

public class CvsCaliperScoringMethod : ICloneable
{
	public enum ScoringMethodParameter
	{
		Xc,
		X1,
		X0,
		Xch,
		X1h,
		X0h,
		Y0,
		Y1,
		Y0h,
		Y1h
	}

	private int xCktKfSq7x;

	private double yCytE0a8Xk;

	private double pFntQ9tQiL;

	private EdgeMode gEvtN0JZZf;

	private CaliperScoringMethodType V5YtiSlbpb;

	private List<KeyValuePair<double, double>> IvjtdloAaY;

	public double X0Low;

	public double X1Low;

	public double XCLow;

	public double X0High;

	public double X1High;

	public double XCHigh;

	public double Y0Low;

	public double Y1Low;

	public double Y0High;

	public double Y1High;

	public double YMax;

	public float YMin;

	private double cjstuuq04Z;

	private double fXwtGH4OZu;

	private double y7TtDKRSKF;

	private bool E8rteapZFU;

	private double eQPtSjYm4P;

	private double DcTtrItLmL;

	private double JC8tC89mbG;

	private double mR3t2Fe5uO;

	public int Id
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xCktKfSq7x;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xCktKfSq7x = value;
		}
	}

	public double RegionSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return yCytE0a8Xk;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			yCytE0a8Xk = value;
		}
	}

	public double EdgePairSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return pFntQ9tQiL;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			pFntQ9tQiL = value;
		}
	}

	public EdgeMode EdgeMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return gEvtN0JZZf;
		}
	}

	public CaliperScoringMethodType Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return V5YtiSlbpb;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 35;
			while (true)
			{
				switch (num)
				{
				case 35:
					if (value != V5YtiSlbpb)
					{
						num = 24;
						break;
					}
					return;
				case 11:
					V5YtiSlbpb = value;
					num = 37;
					break;
				case 44:
					gX3t9dI6no();
					return;
				case 7:
				case 22:
					DcTtrItLmL = (eQPtSjYm4P = 0.0);
					num = 27;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				case 0:
					X0Low = X0High;
					num = 12;
					break;
				case 43:
					if (value != CaliperScoringMethodType.FullRegionPosition)
					{
						num = 40;
						break;
					}
					goto IL_05ba;
				case 1:
					if (value != CaliperScoringMethodType.EdgePairSize)
					{
						num = 5;
						if (EwptNXI87ZnT9Th2AZO())
						{
							break;
						}
						goto case 37;
					}
					goto IL_0512;
				case 37:
					gX3t9dI6no();
					return;
				case 45:
					mR3t2Fe5uO = (JC8tC89mbG = yCytE0a8Xk / 2.0);
					num = 26;
					break;
				case 8:
					return;
				case 23:
					mR3t2Fe5uO = (JC8tC89mbG = yCytE0a8Xk / 2.0);
					num = 50;
					break;
				case 38:
					XCLow = XCHigh;
					num = 11;
					if (!Yb6uIVIzw21fQB93C8X())
					{
						break;
					}
					goto case 50;
				case 50:
					V5YtiSlbpb = value;
					num = 44;
					break;
				case 3:
					yCytE0a8Xk = cjstuuq04Z;
					num = 4;
					if (1 == 0)
					{
						return;
					}
					break;
				case 48:
					return;
				case 30:
					DcTtrItLmL = (eQPtSjYm4P = 0.0);
					num = 23;
					break;
				case 33:
					yCytE0a8Xk = cjstuuq04Z;
					num = 32;
					break;
				case 24:
					if (value != CaliperScoringMethodType.FullRegionPositionNormalized)
					{
						if (value != CaliperScoringMethodType.FullRegionPosition)
						{
							goto IL_0100;
						}
						num = 42;
						if (EwptNXI87ZnT9Th2AZO())
						{
							break;
						}
						goto case 14;
					}
					goto case 42;
				case 14:
					if (V5YtiSlbpb != CaliperScoringMethodType.EdgePairSize)
					{
						num = 18;
						break;
					}
					goto IL_0512;
				case 17:
					if (V5YtiSlbpb != CaliperScoringMethodType.Position)
					{
						goto IL_0100;
					}
					num = 2;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				case 2:
					GetDirection();
					num = 3;
					if (true)
					{
						break;
					}
					goto case 4;
				case 4:
					y7TtDKRSKF = (fXwtGH4OZu = yCytE0a8Xk - 1.0);
					num = 19;
					break;
				case 40:
					if (V5YtiSlbpb == CaliperScoringMethodType.FullRegionPosition)
					{
						num = 39;
						break;
					}
					goto IL_0617;
				case 6:
					X1Low = (float)S1ADEjRwsqoDwf1CPJa(DcTtrItLmL * 0.6, 0);
					num = 36;
					break;
				case 15:
					if (value == CaliperScoringMethodType.EdgePairSizeDifferenceAsymmetric)
					{
						ScoringMethodDirection direction = GetDirection();
						yCytE0a8Xk = cjstuuq04Z;
						y7TtDKRSKF = yCytE0a8Xk - pFntQ9tQiL;
						DcTtrItLmL = 0.0 - pFntQ9tQiL;
						mR3t2Fe5uO = 0.0;
						X0High = X0Low;
						X1High = X1Low;
						XCHigh = XCLow;
						if (Y1High < 0.0)
						{
							Y1High = Y1Low;
						}
						if (Y0High < 0.0)
						{
							Y0High = Y0Low;
						}
						if (direction != ScoringMethodDirection.LowMiddleCutOff)
						{
							X0Low = (float)S1ADEjRwsqoDwf1CPJa(DcTtrItLmL * 0.2, 0);
							num = 34;
						}
						else
						{
							X0Low = (float)S1ADEjRwsqoDwf1CPJa(DcTtrItLmL * 0.8, 0);
							num = 6;
						}
						break;
					}
					goto IL_04cd;
				case 12:
					X1Low = X1High;
					num = 38;
					if (0 == 0)
					{
						break;
					}
					goto case 49;
				case 49:
					V5YtiSlbpb = value;
					gX3t9dI6no();
					num = 8;
					break;
				case 10:
					if (V5YtiSlbpb != CaliperScoringMethodType.FullRegionPosition)
					{
						goto IL_0046;
					}
					goto IL_03dd;
				case 28:
					V5YtiSlbpb = value;
					yCytE0a8Xk = cjstuuq04Z;
					y7TtDKRSKF = (fXwtGH4OZu = yCytE0a8Xk - 1.0);
					DcTtrItLmL = (eQPtSjYm4P = 0.0);
					num = 45;
					break;
				case 47:
					if (V5YtiSlbpb != CaliperScoringMethodType.PositionNormalized || value != CaliperScoringMethodType.Position)
					{
						if (V5YtiSlbpb == CaliperScoringMethodType.EdgePairSizeDifference)
						{
							num = 15;
							break;
						}
						goto IL_04cd;
					}
					num = 28;
					if (!Yb6uIVIzw21fQB93C8X())
					{
						break;
					}
					goto case 27;
				case 27:
					mR3t2Fe5uO = DcTtrItLmL;
					gX3t9dI6no();
					num = 9;
					if (true)
					{
						break;
					}
					goto case 34;
				case 34:
					X1Low = (float)S1ADEjRwsqoDwf1CPJa(DcTtrItLmL * 0.6, 0);
					XCLow = (float)S1ADEjRwsqoDwf1CPJa(DcTtrItLmL * 0.8, 0);
					goto case 29;
				case 29:
					V5YtiSlbpb = value;
					gX3t9dI6no();
					return;
				case 32:
					y7TtDKRSKF = (fXwtGH4OZu = yCytE0a8Xk - 1.0);
					num = 30;
					break;
				case 5:
					if (V5YtiSlbpb != CaliperScoringMethodType.None)
					{
						throw new ArgumentException();
					}
					goto IL_0512;
				case 19:
					DcTtrItLmL = (eQPtSjYm4P = 0.0);
					mR3t2Fe5uO = DcTtrItLmL;
					num = 49;
					break;
				case 16:
					if (value == CaliperScoringMethodType.Position)
					{
						num = 33;
						break;
					}
					goto IL_0046;
				case 31:
					gX3t9dI6no();
					num = 51;
					break;
				case 46:
					if (V5YtiSlbpb == CaliperScoringMethodType.EdgePairSizeDifferenceAsymmetric)
					{
						num = 25;
						break;
					}
					goto IL_00c5;
				case 26:
					gX3t9dI6no();
					num = 48;
					break;
				case 25:
					yCytE0a8Xk = cjstuuq04Z;
					num = 20;
					if (0 == 0)
					{
						break;
					}
					goto case 39;
				case 39:
					if (value == CaliperScoringMethodType.FullRegionPositionNormalized)
					{
						goto IL_05ba;
					}
					goto IL_0617;
				case 36:
					XCLow = (float)S1ADEjRwsqoDwf1CPJa(DcTtrItLmL * 0.2, 0);
					num = 29;
					break;
				case 13:
					if (value != CaliperScoringMethodType.PositionNormalized)
					{
						num = 47;
						if (false)
						{
							return;
						}
						break;
					}
					goto case 28;
				case 9:
					return;
				default:
					num = 13;
					if (Yb6uIVIzw21fQB93C8X())
					{
					}
					break;
				case 18:
					if (V5YtiSlbpb == CaliperScoringMethodType.EdgePairSizeDifference)
					{
						num = 1;
						break;
					}
					goto case 5;
				case 21:
				case 41:
					yCytE0a8Xk = cjstuuq04Z;
					y7TtDKRSKF = (fXwtGH4OZu = yCytE0a8Xk - 1.0);
					goto case 7;
				case 42:
					if (V5YtiSlbpb != CaliperScoringMethodType.PositionNormalized)
					{
						num = 17;
						break;
					}
					goto case 2;
				case 20:
					y7TtDKRSKF = PdEQ4oRsNI6pE6wFy5V(pFntQ9tQiL - yCytE0a8Xk);
					DcTtrItLmL = 0.0;
					mR3t2Fe5uO = 0.0;
					num = 0;
					break;
				case 51:
					return;
					IL_05ba:
					V5YtiSlbpb = value;
					EwptNXI87ZnT9Th2AZO();
					num = (Yb6uIVIzw21fQB93C8X() ? 7 : 41);
					break;
					IL_0100:
					if (V5YtiSlbpb != CaliperScoringMethodType.FullRegionPositionNormalized)
					{
						num = 10;
						if (true)
						{
							break;
						}
						goto case 23;
					}
					goto IL_03dd;
					IL_0046:
					if (V5YtiSlbpb == CaliperScoringMethodType.FullRegionPositionNormalized)
					{
						num = 43;
						break;
					}
					goto case 40;
					IL_03dd:
					if (value != CaliperScoringMethodType.PositionNormalized)
					{
						num = 16;
						break;
					}
					goto case 33;
					IL_0617:
					if (V5YtiSlbpb != CaliperScoringMethodType.Position)
					{
						goto case 47;
					}
					goto case 13;
					IL_04cd:
					if (value == CaliperScoringMethodType.EdgePairSizeDifference)
					{
						num = 46;
						break;
					}
					goto IL_00c5;
					IL_00c5:
					if (value == CaliperScoringMethodType.EdgePairSizeDifference)
					{
						num = 14;
						break;
					}
					goto case 18;
					IL_0512:
					V5YtiSlbpb = value;
					num = 31;
					if (0 == 0)
					{
						break;
					}
					goto case 19;
				}
			}
		}
	}

	public List<KeyValuePair<double, double>> InvalidRegions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return IvjtdloAaY;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IvjtdloAaY = value;
		}
	}

	public bool UnPlottable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return E8rteapZFU;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			E8rteapZFU = value;
		}
	}

	public double MaxRegion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return y7TtDKRSKF;
		}
	}

	public double MinRegion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DcTtrItLmL;
		}
	}

	public double MidPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mR3t2Fe5uO;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCaliperScoringMethod(CaliperScoringMethodType type, int id, double regionWidth, double edgeWidth, EdgeMode mode)
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
				YMax = 100.0;
				goto case 2;
			case 5:
				EVltRxbKDO(type, id, regionWidth, edgeWidth, mode);
				num = 6;
				if (!Yb6uIVIzw21fQB93C8X())
				{
					break;
				}
				goto case 6;
			case 6:
				E8rteapZFU = !U6NtnxncrA();
				num = 7;
				break;
			case 2:
			case 4:
				vAIbNwRL8towEQuhqCD(this);
				goto case 5;
			default:
				num = 5;
				break;
			case 3:
				J3IXtuRhEoZTmUiBZbI();
				_ = 0;
				if (!EwptNXI87ZnT9Th2AZO())
				{
					num = 4;
					if (0 == 0)
					{
						break;
					}
					goto case 5;
				}
				num = 0;
				if (Yb6uIVIzw21fQB93C8X())
				{
				}
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCaliperScoringMethod(CvsCaliperScoringMethod mtd)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_01a8;
		IL_001a:
		Y1High = mtd.Y1High;
		num = 22;
		goto IL_01a8;
		IL_01a8:
		while (true)
		{
			switch (num)
			{
			case 13:
				break;
			case 12:
				gEvtN0JZZf = WN0U77Rv5DqpGc8c9mh(mtd);
				num = 15;
				continue;
			case 1:
				frKt691BsZ(mtd.InvalidRegions);
				num = 21;
				continue;
			case 19:
				yCytE0a8Xk = fJMQFjRS3f4tN9UMBDp(mtd);
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				pFntQ9tQiL = V75TRwRElsM3rcXeeOZ(mtd);
				num = 12;
				continue;
			case 21:
				X0Low = mtd.X0Low;
				X1Low = mtd.X1Low;
				num = 3;
				continue;
			case 7:
			case 9:
				eQPtSjYm4P = mtd.eQPtSjYm4P;
				JC8tC89mbG = mtd.JC8tC89mbG;
				num = 14;
				continue;
			case 4:
				X0High = mtd.X0High;
				num = 2;
				continue;
			case 6:
				Y0Low = mtd.Y0Low;
				num = 18;
				continue;
			case 11:
				if (mtd.InvalidRegions != null)
				{
					num = 1;
					continue;
				}
				goto case 21;
			case 8:
			case 17:
				fXwtGH4OZu = mtd.fXwtGH4OZu;
				goto case 7;
			case 15:
				DcTtrItLmL = mtd.DcTtrItLmL;
				y7TtDKRSKF = mtd.y7TtDKRSKF;
				num = 16;
				continue;
			case 20:
				YMax = 100.0;
				num = 0;
				continue;
			case 2:
				X1High = mtd.X1High;
				XCHigh = mtd.XCHigh;
				num = 6;
				continue;
			case 14:
				E8rteapZFU = mtd.E8rteapZFU;
				goto case 11;
			default:
				num = 11;
				continue;
			case 0:
				base._002Ector();
				V5YtiSlbpb = AbXe2FR93Yw7UpZWPre(mtd);
				num = 19;
				continue;
			case 3:
				XCLow = mtd.XCLow;
				num = 4;
				continue;
			case 16:
				mR3t2Fe5uO = mtd.mR3t2Fe5uO;
				EwptNXI87ZnT9Th2AZO();
				if (Yb6uIVIzw21fQB93C8X())
				{
					num = 7;
					if (true)
					{
						continue;
					}
					goto case 15;
				}
				num = 17;
				continue;
			case 18:
				Y1Low = mtd.Y1Low;
				Y0High = mtd.Y0High;
				num = 13;
				if (EwptNXI87ZnT9Th2AZO())
				{
					continue;
				}
				goto case 10;
			case 10:
				J3IXtuRhEoZTmUiBZbI();
				num = 20;
				if (0 == 0)
				{
					continue;
				}
				return;
			case 22:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCaliperScoringMethod(CaliperScoringMethodType type, int id, double edgeWidth, double regionWidth, EdgeMode mode, float xc, float x0, float x1, float y0, float y1, float xch, float x0h, float x1h, float y0h, float y1h)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		CaliperScoringMethodType type2 = default;
		while (true)
		{
			switch (num)
			{
			case 13:
				X0Low = Math.Round((double)x0 * EdgePairSize, 1);
				_ = 0;
				if (EwptNXI87ZnT9Th2AZO())
				{
					num = 8;
					if (true)
					{
						break;
					}
					goto case 12;
				}
				num = 23;
				break;
			case 12:
				base._002Ector();
				num = 10;
				if (true)
				{
					break;
				}
				goto case 8;
			case 8:
			case 19:
				X1Low = S1ADEjRwsqoDwf1CPJa((double)x1 * EdgePairSize, 1);
				XCLow = Math.Round((double)xc * EdgePairSize, 1);
				goto IL_0145;
			case 17:
				E8rteapZFU = !U6NtnxncrA();
				num = 6;
				break;
			case 11:
				switch (type2)
				{
				case CaliperScoringMethodType.EdgePairSizeDifference:
					break;
				case CaliperScoringMethodType.Position:
				case CaliperScoringMethodType.Contrast:
				case CaliperScoringMethodType.FullRegionPosition:
					goto IL_00e3;
				default:
					goto IL_0122;
				case CaliperScoringMethodType.Straddle:
					goto IL_0145;
				case CaliperScoringMethodType.EdgePairSizeDifferenceAsymmetric:
					goto IL_01e4;
				case CaliperScoringMethodType.EdgePairSize:
				case CaliperScoringMethodType.PositionNormalized:
				case CaliperScoringMethodType.FullRegionPositionNormalized:
					goto IL_0305;
				}
				X0Low = S1ADEjRwsqoDwf1CPJa((double)x0 * EdgePairSize, 1);
				X1Low = S1ADEjRwsqoDwf1CPJa((double)x1 * EdgePairSize, 1);
				num = 3;
				if (EwptNXI87ZnT9Th2AZO())
				{
					break;
				}
				goto case 17;
			case 7:
				YMax = 100.0;
				num = 12;
				break;
			case 16:
			case 18:
			case 21:
			case 23:
				goto IL_0145;
			case 6:
				if (Type != CaliperScoringMethodType.Straddle)
				{
					num = 9;
					break;
				}
				return;
			case 9:
				type2 = Type;
				num = 11;
				if (EwptNXI87ZnT9Th2AZO())
				{
					break;
				}
				goto case 14;
			case 14:
				XCLow = xc;
				num = 18;
				break;
			case 1:
				Y0Low = y0;
				num = 0;
				break;
			case 4:
				J3IXtuRhEoZTmUiBZbI();
				num = 7;
				break;
			case 10:
				EVltRxbKDO(type, id, regionWidth, edgeWidth, mode);
				num = 1;
				break;
			case 2:
				XCLow = S1ADEjRwsqoDwf1CPJa((double)xc * edgeWidth, 1);
				goto IL_0145;
			case 20:
				X1Low = x1;
				goto case 14;
			default:
				num = 14;
				break;
			case 0:
				Y1Low = y1;
				Y0High = y0h;
				Y1High = y1h;
				num = 17;
				break;
			case 5:
				X1Low = Math.Round((double)x1 * edgeWidth, 1);
				num = 2;
				break;
			case 15:
				X1High = S1ADEjRwsqoDwf1CPJa((double)x1h * EdgePairSize, 1);
				num = 22;
				break;
			case 3:
				XCLow = S1ADEjRwsqoDwf1CPJa((double)xc * EdgePairSize, 1);
				goto IL_0145;
			case 22:
				XCHigh = S1ADEjRwsqoDwf1CPJa((double)xch * EdgePairSize, 1);
				num = 13;
				break;
			case 24:
				return;
				IL_0305:
				X0Low = S1ADEjRwsqoDwf1CPJa((double)x0 * edgeWidth, 1);
				num = 5;
				break;
				IL_01e4:
				_ = RegionSize / EdgePairSize;
				X0High = S1ADEjRwsqoDwf1CPJa((double)x0h * EdgePairSize, 1);
				num = 15;
				break;
				IL_0122:
				num = 16;
				break;
				IL_00e3:
				X0Low = x0;
				num = 20;
				break;
				IL_0145:
				gX3t9dI6no();
				num = 24;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetName()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (Type != CaliperScoringMethodType.Straddle)
		{
			return GetName(Type, GetDirection());
		}
		return (string)zL1ktqRHRajJWwkQYmj();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetName(CaliperScoringMethodType type, ScoringMethodDirection direction)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		while (true)
		{
			switch (num)
			{
			case 3:
				return Resources.CaliperPositionRightSide;
			case 9:
				return (string)MBEXnURDkWciHubO008();
			case 2:
				return (string)vNW0lHRTVn3wZLWBkVx();
			default:
				num = 6;
				break;
			case 10:
				switch (type)
				{
				case CaliperScoringMethodType.FullRegionPositionNormalized:
					break;
				case CaliperScoringMethodType.Contrast:
					goto IL_0056;
				case CaliperScoringMethodType.EdgePairSize:
					goto IL_0074;
				default:
					goto IL_00f7;
				case CaliperScoringMethodType.FullRegionPosition:
					goto IL_010d;
				case CaliperScoringMethodType.EdgePairSizeDifference:
					goto IL_0129;
				case CaliperScoringMethodType.Position:
					goto IL_0144;
				case CaliperScoringMethodType.PositionNormalized:
					goto IL_0160;
				case CaliperScoringMethodType.EdgePairSizeDifferenceAsymmetric:
					goto IL_019c;
				case CaliperScoringMethodType.Straddle:
					return (string)zL1ktqRHRajJWwkQYmj();
				}
				if (direction == ScoringMethodDirection.LowMiddleCutOff)
				{
					_ = 1;
					if (!Yb6uIVIzw21fQB93C8X())
					{
						num = 1;
						if (Yb6uIVIzw21fQB93C8X())
						{
						}
					}
					else
					{
						num = 5;
					}
					break;
				}
				return (string)hr4CXARjvc1xvsIqQPO();
			case 6:
				return (string)gqwDTmRiFUf3fqBpgCL();
			case 1:
			case 7:
				return (string)Mgh91gRBoRf2uiIifEp();
			case 0:
				return (string)Pf5pb6RVYJ7jiGHsoUR();
			case 5:
			case 8:
				return (string)MgtRIkR2PlmAFFMIids(iqitMARcoMRrDD2bo35(), pFntQ9tQiL);
			case 11:
				return (string)MgtRIkR2PlmAFFMIids(iqitMARcoMRrDD2bo35(), pFntQ9tQiL);
			case 4:
				{
					return string.Empty;
				}
				IL_019c:
				if (direction == ScoringMethodDirection.LowMiddleCutOff)
				{
					num = 11;
					break;
				}
				return string.Format((string)kJ6cUvRW40Nd0EOC3Gh(), pFntQ9tQiL);
				IL_0056:
				if (direction == ScoringMethodDirection.LowMiddleCutOff)
				{
					num = 2;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				}
				return (string)cnVC7GRdU9jYI1eeX3u();
				IL_0160:
				if (direction != ScoringMethodDirection.LowMiddleCutOff)
				{
					return (string)nKwkriRUf3PpaiIp1XR();
				}
				num = 9;
				break;
				IL_0144:
				if (direction == ScoringMethodDirection.LowMiddleCutOff)
				{
					num = 0;
					break;
				}
				return (string)onJFLORAnmkCS9o0NCc();
				IL_00f7:
				num = 4;
				break;
				IL_0129:
				if (direction == ScoringMethodDirection.LowMiddleCutOff)
				{
					goto case 5;
				}
				return (string)MgtRIkR2PlmAFFMIids(kJ6cUvRW40Nd0EOC3Gh(), pFntQ9tQiL);
				IL_010d:
				if (direction != ScoringMethodDirection.LowMiddleCutOff)
				{
					return Resources.CaliperPositionLeftSide;
				}
				num = 3;
				break;
				IL_0074:
				if (direction == ScoringMethodDirection.LowMiddleCutOff)
				{
					goto case 6;
				}
				return (string)rCiDpaRqG9H5l28lSAU();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ScoringMethodDirection GetDirection()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EwptNXI87ZnT9Th2AZO();
		int num = ((!Yb6uIVIzw21fQB93C8X()) ? 1 : 4);
		while (true)
		{
			switch (num)
			{
			case 5:
				if (!(XCLow > X0Low))
				{
					goto default;
				}
				return ScoringMethodDirection.HighOuterCutOff;
			case 2:
				throw new ArgumentException(kgbOBx7BanbFa22Hp9.ol99ukmDA(40400));
			case 0:
			case 1:
				if (Type != CaliperScoringMethodType.Straddle)
				{
					if (Type != CaliperScoringMethodType.EdgePairSizeDifferenceAsymmetric)
					{
						num = 5;
						break;
					}
					if (XCHigh > X0High)
					{
						return ScoringMethodDirection.HighOuterCutOff;
					}
					num = 6;
				}
				else
				{
					num = 2;
				}
				break;
			default:
				return ScoringMethodDirection.LowMiddleCutOff;
			case 6:
				return ScoringMethodDirection.LowMiddleCutOff;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SetDirection(ScoringMethodDirection direction)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		double num2 = default;
		CaliperScoringMethodType type = default;
		while (true)
		{
			double xCLow;
			switch (num)
			{
			case 11:
				X0Low = num2;
				num = 12;
				continue;
			case 3:
				if (Type == CaliperScoringMethodType.Straddle)
				{
					num = 16;
					if (true)
					{
						continue;
					}
					goto case 5;
				}
				if (X1Low == XCLow)
				{
					X1Low = X0Low;
				}
				else if (X1Low == X0Low)
				{
					_ = 0;
					if (EwptNXI87ZnT9Th2AZO())
					{
						num = 0;
						if (EwptNXI87ZnT9Th2AZO())
						{
							continue;
						}
						goto case 6;
					}
					num = 15;
					continue;
				}
				goto case 13;
			case 5:
			case 15:
				switch (type)
				{
				case CaliperScoringMethodType.EdgePairSizeDifferenceAsymmetric:
					break;
				default:
					goto IL_008d;
				case CaliperScoringMethodType.EdgePairSizeDifference:
				case CaliperScoringMethodType.EdgePairSize:
				case CaliperScoringMethodType.PositionNormalized:
				case CaliperScoringMethodType.Position:
				case CaliperScoringMethodType.Contrast:
				case CaliperScoringMethodType.FullRegionPositionNormalized:
				case CaliperScoringMethodType.FullRegionPosition:
					goto IL_0218;
				case CaliperScoringMethodType.Straddle:
					goto end_IL_013e;
				}
				if (X1High == XCHigh)
				{
					num = 14;
					continue;
				}
				if (X1High == X0High)
				{
					num = 1;
					continue;
				}
				goto case 7;
			case 16:
				throw new ArgumentException((string)oR7RZhR7NbBGsxEg0Rr(40412));
			case 6:
				X0High = num2;
				num = 19;
				continue;
			case 12:
				num2 = XCHigh;
				num = 9;
				if (0 == 0)
				{
					continue;
				}
				goto case 14;
			case 14:
				X1High = X0High;
				goto case 7;
			default:
				num = 7;
				if (true)
				{
					continue;
				}
				goto case 7;
			case 7:
			case 17:
				num2 = XCLow;
				num = 4;
				continue;
			case 4:
				XCLow = X0Low;
				num = 11;
				continue;
			case 10:
				type = Type;
				goto case 5;
			case 0:
			case 2:
				X1Low = XCLow;
				num = 13;
				continue;
			case 13:
				if (direction != GetDirection())
				{
					num = 10;
					continue;
				}
				return false;
			case 9:
				XCHigh = X0High;
				num = 6;
				if (EwptNXI87ZnT9Th2AZO())
				{
					continue;
				}
				goto case 1;
			case 1:
				X1High = XCHigh;
				num = 17;
				if (!Yb6uIVIzw21fQB93C8X())
				{
					continue;
				}
				break;
			case 8:
			case 18:
			case 19:
				break;
				IL_0218:
				xCLow = XCLow;
				XCLow = X0Low;
				X0Low = xCLow;
				num = 8;
				if (!Yb6uIVIzw21fQB93C8X())
				{
					continue;
				}
				goto case 13;
				IL_008d:
				num = 18;
				if (EwptNXI87ZnT9Th2AZO())
				{
					continue;
				}
				goto case 16;
				end_IL_013e:
				break;
			}
			break;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SetValue(ScoringMethodParameter valType, double value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 17;
		bool result = default;
		while (true)
		{
			switch (num)
			{
			case 20:
				Y1High = value;
				num = 2;
				continue;
			default:
				num = 25;
				if (!Yb6uIVIzw21fQB93C8X())
				{
					continue;
				}
				goto case 3;
			case 3:
				result = true;
				break;
			case 23:
				XCHigh = value;
				num = 12;
				continue;
			case 0:
				result = true;
				num = 7;
				continue;
			case 5:
				XCLow = value;
				num = 15;
				continue;
			case 15:
				result = true;
				num = 11;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
				Y0High = value;
				num = 16;
				continue;
			case 2:
				result = true;
				num = 26;
				continue;
			case 9:
				X0High = value;
				num = 3;
				continue;
			case 13:
				switch (valType)
				{
				case ScoringMethodParameter.Y1:
					break;
				case ScoringMethodParameter.X1h:
					goto IL_011c;
				default:
					goto IL_021b;
				case ScoringMethodParameter.X0h:
					goto IL_023f;
				case ScoringMethodParameter.X0:
					goto IL_02a2;
				case ScoringMethodParameter.Y0h:
					goto IL_0311;
				case ScoringMethodParameter.Xc:
					goto IL_0374;
				case ScoringMethodParameter.Y0:
					goto IL_03d9;
				case ScoringMethodParameter.Xch:
					goto IL_0445;
				case ScoringMethodParameter.X1:
					goto IL_04a8;
				case ScoringMethodParameter.Y1h:
					goto IL_0541;
				}
				if (!bCCtwxBXgS(XCLow, X0Low, X1Low, Y0Low, value, XCHigh, X0High, X1High, Y0High, Y1High, y7TtDKRSKF, DcTtrItLmL, mR3t2Fe5uO))
				{
					break;
				}
				goto case 25;
			case 19:
				Y0Low = value;
				num = 0;
				continue;
			case 12:
				result = true;
				break;
			case 10:
				result = true;
				break;
			case 25:
				Y1Low = value;
				result = true;
				break;
			case 17:
				result = false;
				num = 13;
				continue;
			case 6:
			case 24:
				X0Low = value;
				num = 14;
				continue;
			case 14:
				result = true;
				num = 22;
				if (EwptNXI87ZnT9Th2AZO())
				{
					continue;
				}
				break;
			case 16:
				result = true;
				break;
			case 4:
			case 7:
			case 8:
			case 11:
			case 18:
			case 21:
			case 22:
			case 26:
				break;
				IL_0541:
				if (!bCCtwxBXgS(XCLow, X0Low, X1Low, Y0Low, Y1Low, XCHigh, X0High, X1High, Y0High, value, y7TtDKRSKF, DcTtrItLmL, mR3t2Fe5uO))
				{
					break;
				}
				num = 20;
				if (EwptNXI87ZnT9Th2AZO())
				{
					continue;
				}
				goto case 16;
				IL_04a8:
				if (bCCtwxBXgS(XCLow, X0Low, value, Y0Low, Y1Low, XCHigh, X0High, X1High, Y0High, Y1High, y7TtDKRSKF, DcTtrItLmL, mR3t2Fe5uO))
				{
					X1Low = value;
					num = 10;
					continue;
				}
				break;
				IL_0445:
				if (bCCtwxBXgS(XCLow, X0Low, X1Low, Y0Low, Y1Low, value, X0High, X1High, Y0High, Y1High, y7TtDKRSKF, DcTtrItLmL, mR3t2Fe5uO))
				{
					num = 23;
					continue;
				}
				break;
				IL_03d9:
				if (bCCtwxBXgS(XCLow, X0Low, X1Low, value, Y1Low, XCHigh, X0High, X1High, Y0High, Y1High, y7TtDKRSKF, DcTtrItLmL, mR3t2Fe5uO))
				{
					num = 19;
					continue;
				}
				break;
				IL_0374:
				if (bCCtwxBXgS(value, X0Low, X1Low, Y0Low, Y1Low, XCHigh, X0High, X1High, Y0High, Y1High, y7TtDKRSKF, DcTtrItLmL, mR3t2Fe5uO))
				{
					num = 5;
					continue;
				}
				break;
				IL_0311:
				if (bCCtwxBXgS(XCLow, X0Low, X1Low, Y0Low, Y1Low, XCHigh, X0High, X1High, value, Y1High, y7TtDKRSKF, DcTtrItLmL, mR3t2Fe5uO))
				{
					num = 1;
					continue;
				}
				break;
				IL_02a2:
				if (bCCtwxBXgS(XCLow, value, X1Low, Y0Low, Y1Low, XCHigh, X0High, X1High, Y0High, Y1High, y7TtDKRSKF, DcTtrItLmL, mR3t2Fe5uO))
				{
					_ = 0;
					num = ((!EwptNXI87ZnT9Th2AZO()) ? 18 : 24);
					continue;
				}
				break;
				IL_023f:
				if (bCCtwxBXgS(XCLow, X0Low, X1Low, Y0Low, Y1Low, XCHigh, value, X1High, Y0High, Y1High, y7TtDKRSKF, DcTtrItLmL, mR3t2Fe5uO))
				{
					num = 9;
					continue;
				}
				break;
				IL_021b:
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 19;
				IL_011c:
				if (bCCtwxBXgS(XCLow, X0Low, X1Low, Y0Low, Y1Low, XCHigh, X0High, value, Y0High, Y1High, y7TtDKRSKF, DcTtrItLmL, mR3t2Fe5uO))
				{
					X1High = value;
					result = true;
					num = 8;
					continue;
				}
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetEquationValue(ScoringMethodParameter valType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		double num2 = default;
		if (EwptNXI87ZnT9Th2AZO())
		{
			while (true)
			{
				switch (num)
				{
				case 7:
					num2 = lFmtmUlCt9(X0High);
					num = 0;
					continue;
				case 10:
					num2 = lFmtmUlCt9(X1High);
					break;
				case 2:
					switch (valType)
					{
					case ScoringMethodParameter.Y0h:
						num2 = Y0High;
						num = 13;
						continue;
					case ScoringMethodParameter.Y1h:
						num2 = Y1High;
						num = 15;
						continue;
					case ScoringMethodParameter.Y1:
						num2 = Y1Low;
						num = 9;
						continue;
					case ScoringMethodParameter.X1h:
						if (Type == CaliperScoringMethodType.EdgePairSizeDifferenceAsymmetric)
						{
							num = 10;
							continue;
						}
						break;
					default:
						num = 5;
						if (Yb6uIVIzw21fQB93C8X())
						{
						}
						continue;
					case ScoringMethodParameter.Xc:
						num2 = lFmtmUlCt9(XCLow);
						num = 14;
						continue;
					case ScoringMethodParameter.X0:
						num2 = lFmtmUlCt9(X0Low);
						break;
					case ScoringMethodParameter.X1:
						num2 = lFmtmUlCt9(X1Low);
						break;
					case ScoringMethodParameter.Y0:
						num2 = Y0Low;
						_ = 1;
						if (Yb6uIVIzw21fQB93C8X())
						{
							num = 3;
							continue;
						}
						num = 12;
						if (EwptNXI87ZnT9Th2AZO())
						{
							continue;
						}
						break;
					case ScoringMethodParameter.Xch:
						if (Type == CaliperScoringMethodType.EdgePairSizeDifferenceAsymmetric)
						{
							num = 1;
							if (Yb6uIVIzw21fQB93C8X())
							{
							}
							continue;
						}
						break;
					case ScoringMethodParameter.X0h:
						if (Type == CaliperScoringMethodType.EdgePairSizeDifferenceAsymmetric)
						{
							num = 7;
							continue;
						}
						break;
					}
					break;
				case 8:
					num2 = -1.0;
					num = 2;
					continue;
				case 1:
					num2 = lFmtmUlCt9(XCHigh);
					break;
				default:
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 0:
				case 3:
				case 4:
				case 5:
				case 6:
				case 9:
				case 11:
				case 12:
				case 13:
				case 14:
				case 15:
					break;
				}
				break;
			}
		}
		return S1ADEjRwsqoDwf1CPJa(num2, 4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private double lFmtmUlCt9(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		switch (Type)
		{
		case CaliperScoringMethodType.Position:
		case CaliperScoringMethodType.Contrast:
		case CaliperScoringMethodType.FullRegionPosition:
			return P_0;
		case CaliperScoringMethodType.EdgePairSizeDifference:
		case CaliperScoringMethodType.EdgePairSize:
		case CaliperScoringMethodType.PositionNormalized:
		case CaliperScoringMethodType.FullRegionPositionNormalized:
		case CaliperScoringMethodType.EdgePairSizeDifferenceAsymmetric:
			return P_0 / EdgePairSize;
		default:
			return -1.0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool U6NtnxncrA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (Type == CaliperScoringMethodType.Straddle || Type == CaliperScoringMethodType.Contrast)
		{
			return true;
		}
		return pFntQ9tQiL <= cjstuuq04Z;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsWithinRanges()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return bCCtwxBXgS(XCLow, X0Low, X1Low, Y0Low, Y1Low, XCHigh, X0High, X1High, Y0High, Y1High, fXwtGH4OZu, eQPtSjYm4P, JC8tC89mbG);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsValidEdgeMode()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return d8wt0ooSSN(EdgeMode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gX3t9dI6no()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 15;
		CaliperScoringMethodType type = default;
		double num2 = default;
		double num3 = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				if (X0Low > yCytE0a8Xk / 2.0)
				{
					num = 33;
					if (!EwptNXI87ZnT9Th2AZO())
					{
						return;
					}
					break;
				}
				return;
			case 13:
				return;
			case 18:
				if (XCLow < 0.0)
				{
					num = 6;
					break;
				}
				goto case 10;
			case 17:
				y7TtDKRSKF = X0High;
				num = 31;
				break;
			case 5:
				return;
			case 34:
				X1Low += (float)G4Q3n5RtuMOr2xnHDLT(cjstuuq04Z / 2.0);
				goto IL_00c0;
			case 4:
				y7TtDKRSKF = XCHigh;
				num = 36;
				break;
			case 7:
				XCLow += G4Q3n5RtuMOr2xnHDLT(cjstuuq04Z / 2.0);
				num = 19;
				break;
			case 25:
				if (GetDirection() != ScoringMethodDirection.LowMiddleCutOff)
				{
					type = Type;
					Yb6uIVIzw21fQB93C8X();
					if (EwptNXI87ZnT9Th2AZO())
					{
						num = 14;
						if (0 == 0)
						{
							break;
						}
						goto case 34;
					}
					num = 0;
					if (EwptNXI87ZnT9Th2AZO())
					{
						break;
					}
					goto case 4;
				}
				num = 21;
				break;
			case 33:
				num2 = X0Low - yCytE0a8Xk / 2.0;
				num = 9;
				if (0 == 0)
				{
					break;
				}
				goto case 36;
			case 36:
				z1mtU4ndSs();
				num = 26;
				break;
			case 9:
				y7TtDKRSKF += num2 + 1.0;
				num = 8;
				break;
			case 10:
				if (X0Low > y7TtDKRSKF)
				{
					y7TtDKRSKF = X0Low;
					num = 35;
					break;
				}
				return;
			case 6:
				DcTtrItLmL = XCLow;
				goto case 24;
			default:
				num = 24;
				if (0 == 0)
				{
					break;
				}
				goto case 19;
			case 19:
				X0Low += Math.Ceiling(cjstuuq04Z / 2.0);
				num = 1;
				if (EwptNXI87ZnT9Th2AZO())
				{
					break;
				}
				goto case 1;
			case 1:
				X1Low += G4Q3n5RtuMOr2xnHDLT(cjstuuq04Z / 2.0);
				num = 3;
				break;
			case 20:
				z1mtU4ndSs();
				goto IL_036a;
			case 8:
				DcTtrItLmL -= num2;
				num = 27;
				break;
			case 31:
				z1mtU4ndSs();
				num = 32;
				break;
			case 35:
				z1mtU4ndSs();
				num = 5;
				break;
			case 32:
				if (X0Low < DcTtrItLmL)
				{
					num = 12;
					if (0 == 0)
					{
						break;
					}
					goto case 27;
				}
				return;
			case 27:
				z1mtU4ndSs();
				num = 30;
				if (!Yb6uIVIzw21fQB93C8X())
				{
					break;
				}
				goto case 37;
			case 37:
				DcTtrItLmL = XCLow;
				z1mtU4ndSs();
				goto IL_0402;
			case 11:
				y7TtDKRSKF = XCLow;
				z1mtU4ndSs();
				num = 38;
				if (Yb6uIVIzw21fQB93C8X())
				{
				}
				break;
			case 15:
				uXotHcTn0L();
				num = 25;
				if (!Yb6uIVIzw21fQB93C8X())
				{
					break;
				}
				goto case 2;
			case 2:
				XCLow += (float)G4Q3n5RtuMOr2xnHDLT(cjstuuq04Z / 2.0);
				num = 28;
				break;
			case 28:
				X0Low += (float)Math.Ceiling(cjstuuq04Z / 2.0);
				num = 34;
				break;
			case 26:
				return;
			case 22:
				if (X0Low < 0.0)
				{
					DcTtrItLmL = X0Low;
					num = 20;
					break;
				}
				goto IL_036a;
			case 14:
			case 23:
				if ((uint)(type - 3) <= 1u)
				{
					if (X0Low < 0.0)
					{
						num = 2;
						break;
					}
					goto IL_00c0;
				}
				num = 16;
				break;
			case 30:
				return;
			case 24:
				z1mtU4ndSs();
				num = 10;
				break;
			case 21:
				type = Type;
				if ((uint)(type - 3) <= 1u)
				{
					if (XCLow < 0.0)
					{
						num = 7;
						break;
					}
					goto case 3;
				}
				if (type == CaliperScoringMethodType.EdgePairSizeDifferenceAsymmetric)
				{
					if (X0High > y7TtDKRSKF)
					{
						num = 17;
						break;
					}
					goto case 32;
				}
				num = 18;
				break;
			case 16:
				if (type != CaliperScoringMethodType.EdgePairSizeDifferenceAsymmetric)
				{
					num = 22;
					if (true)
					{
						break;
					}
					goto case 0;
				}
				if (XCLow < DcTtrItLmL)
				{
					num = 37;
					break;
				}
				goto IL_0402;
			case 0:
			case 29:
				DcTtrItLmL -= num3;
				z1mtU4ndSs();
				return;
			case 12:
				DcTtrItLmL = X0Low;
				z1mtU4ndSs();
				num = 13;
				break;
			case 38:
				return;
				IL_0402:
				if (XCHigh > y7TtDKRSKF)
				{
					num = 4;
					break;
				}
				return;
				IL_00c0:
				if (XCLow > yCytE0a8Xk / 2.0)
				{
					num3 = XCLow - yCytE0a8Xk / 2.0;
					y7TtDKRSKF += num3 + 1.0;
					goto case 0;
				}
				return;
				IL_036a:
				if (XCLow > y7TtDKRSKF)
				{
					num = 11;
					break;
				}
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void z1mtU4ndSs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Yb6uIVIzw21fQB93C8X();
		int num;
		if (EwptNXI87ZnT9Th2AZO())
		{
			num = 1;
		}
		else
		{
			num = 3;
			if (Yb6uIVIzw21fQB93C8X())
			{
				goto IL_0050;
			}
		}
		goto IL_0086;
		IL_0050:
		yCytE0a8Xk = Convert.ToInt32(S1ADEjRwsqoDwf1CPJa(y7TtDKRSKF + Math.Abs(DcTtrItLmL), 0));
		goto IL_0101;
		IL_0101:
		if (Type != CaliperScoringMethodType.EdgePairSizeDifferenceAsymmetric)
		{
			num = 7;
			if (true)
			{
				goto IL_0086;
			}
			goto IL_011a;
		}
		return;
		IL_0086:
		while (true)
		{
			switch (num)
			{
			case 5:
				CMLtsBmhTE(fXwtGH4OZu, y7TtDKRSKF);
				goto case 2;
			case 4:
				break;
			default:
				num = 6;
				continue;
			case 2:
			case 3:
				CMLtsBmhTE(DcTtrItLmL, eQPtSjYm4P);
				num = 4;
				continue;
			case 7:
				mR3t2Fe5uO = yCytE0a8Xk / 2.0 - PdEQ4oRsNI6pE6wFy5V(DcTtrItLmL);
				num = 8;
				continue;
			case 6:
				goto IL_0101;
			case 0:
			case 1:
				goto IL_011a;
			case 8:
				return;
			}
			break;
		}
		goto IL_0050;
		IL_011a:
		uXotHcTn0L();
		num = 5;
		if (Yb6uIVIzw21fQB93C8X())
		{
		}
		goto IL_0086;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool d8wt0ooSSN(EdgeMode P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		switch (Type)
		{
		case CaliperScoringMethodType.Position:
		case CaliperScoringMethodType.Contrast:
		case CaliperScoringMethodType.FullRegionPosition:
			return true;
		default:
			return P_0 == EdgeMode.EdgePair;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsValidScore()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (IsWithinRanges())
		{
			return bCCtwxBXgS(XCLow, X0Low, X1Low, Y0Low, Y1Low, XCHigh, X0High, X1High, Y0High, Y1High, y7TtDKRSKF, DcTtrItLmL, mR3t2Fe5uO);
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool bCCtwxBXgS(double P_0, double P_1, double P_2, double P_3, double P_4, double P_5, double P_6, double P_7, double P_8, double P_9, double P_10, double P_11, double P_12)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 12;
		if (!EwptNXI87ZnT9Th2AZO())
		{
			goto IL_001e;
		}
		goto IL_021f;
		IL_03c0:
		if (!(P_3 <= YMax))
		{
			goto IL_03e0;
		}
		int num2 = ((P_4 >= (double)YMin) ? 1 : 0);
		goto IL_03e1;
		IL_03e1:
		bool result = (byte)num2 != 0;
		goto IL_05d5;
		IL_03e0:
		num2 = 0;
		goto IL_03e1;
		IL_001e:
		if (P_0 <= P_10)
		{
			num = 30;
			goto IL_021f;
		}
		goto IL_03e0;
		IL_05d5:
		return result;
		IL_021f:
		ScoringMethodDirection direction = default;
		while (true)
		{
			IL_021f_2:
			int num6;
			int num5;
			int num3;
			int num4;
			switch (num)
			{
			case 39:
				break;
			case 17:
				if (P_8 >= P_9 && P_3 <= YMax)
				{
					num = 19;
					if (0 == 0)
					{
						continue;
					}
					goto case 13;
				}
				goto IL_00e2;
			case 13:
				if (P_1 >= P_2)
				{
					num = 10;
					continue;
				}
				goto IL_0338;
			case 44:
				if (P_3 >= P_4 && P_3 <= YMax)
				{
					goto case 11;
				}
				goto IL_04f8;
			case 5:
				if (P_8 >= P_9 && P_3 <= YMax)
				{
					num = 8;
					continue;
				}
				goto IL_048e;
			case 31:
				if (P_3 <= YMax)
				{
					num = 36;
					continue;
				}
				goto IL_0432;
			case 42:
				goto IL_00c2;
			case 4:
				if (P_3 >= P_4)
				{
					num = 31;
					if (EwptNXI87ZnT9Th2AZO())
					{
						continue;
					}
					goto case 3;
				}
				goto IL_0432;
			case 3:
			case 33:
				if (direction == ScoringMethodDirection.HighOuterCutOff)
				{
					num = 25;
					continue;
				}
				goto IL_05d5;
			case 35:
				if (P_1 >= P_11)
				{
					num = 4;
					continue;
				}
				goto IL_0432;
			case 25:
				if (Type != CaliperScoringMethodType.EdgePairSizeDifferenceAsymmetric)
				{
					num = 23;
					continue;
				}
				if (P_1 >= P_2)
				{
					num = 43;
					continue;
				}
				goto IL_048e;
			case 45:
				if (P_7 >= P_5)
				{
					num = 26;
					continue;
				}
				goto IL_00e2;
			case 1:
				if (Type == CaliperScoringMethodType.PositionNormalized)
				{
					num = 13;
					continue;
				}
				if (P_1 >= P_2)
				{
					num = 22;
					continue;
				}
				goto IL_04f8;
			case 19:
				if (P_4 >= (double)YMin)
				{
					num = 42;
					continue;
				}
				goto IL_00e2;
			case 26:
				if (P_6 <= P_10)
				{
					num = 14;
					continue;
				}
				goto IL_00e2;
			case 14:
				if (!(P_0 >= P_11))
				{
					goto IL_00e2;
				}
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 18;
			case 18:
				if (P_2 >= P_1)
				{
					num = 39;
					continue;
				}
				goto IL_03e0;
			case 32:
				if (P_6 >= P_1 && P_5 <= P_10)
				{
					num = 37;
					continue;
				}
				goto IL_048e;
			case 7:
				if (Type != CaliperScoringMethodType.Position)
				{
					num = 1;
					continue;
				}
				goto case 13;
			case 8:
				if (P_4 >= (double)YMin && P_8 <= YMax)
				{
					goto case 24;
				}
				goto IL_048e;
			default:
				num = 24;
				if (EwptNXI87ZnT9Th2AZO())
				{
					continue;
				}
				goto case 23;
			case 23:
				if (Type != CaliperScoringMethodType.Position)
				{
					num = 38;
					continue;
				}
				goto IL_0458;
			case 43:
				if (P_2 >= P_0)
				{
					num = 27;
					if (true)
					{
						continue;
					}
					goto case 12;
				}
				goto IL_048e;
			case 12:
				result = false;
				num = 9;
				continue;
			case 15:
				num6 = ((P_4 >= (double)YMin) ? 1 : 0);
				goto IL_0339;
			case 16:
				if (P_0 >= 0.0 && P_3 >= P_4)
				{
					num = 29;
					continue;
				}
				goto IL_0338;
			case 28:
				if (P_1 <= P_10 && P_0 >= 0.0)
				{
					num = 44;
					continue;
				}
				goto IL_04f8;
			case 22:
				if (P_2 >= P_0)
				{
					num = 28;
					continue;
				}
				goto IL_04f8;
			case 27:
				if (P_5 >= P_7 && P_7 >= P_6)
				{
					num = 32;
					continue;
				}
				goto IL_048e;
			case 21:
				goto IL_03c0;
			case 0:
				if (P_3 >= P_8)
				{
					num = 17;
					continue;
				}
				goto IL_00e2;
			case 6:
				if (!(P_5 >= P_0))
				{
					goto IL_00e2;
				}
				num = 40;
				if (0 == 0)
				{
					continue;
				}
				goto case 36;
			case 36:
				num5 = ((P_4 >= (double)YMin) ? 1 : 0);
				goto IL_0433;
			case 38:
				while (Type != CaliperScoringMethodType.PositionNormalized)
				{
					if (P_0 >= P_2)
					{
						num = 18;
						if (true)
						{
							goto IL_021f_2;
						}
						continue;
					}
					goto IL_03e0;
				}
				goto IL_0458;
			case 24:
				num3 = ((P_9 >= (double)YMin) ? 1 : 0);
				goto IL_048f;
			case 40:
				if (!(P_3 >= P_4))
				{
					goto IL_00e2;
				}
				num = 0;
				if (!Yb6uIVIzw21fQB93C8X())
				{
					continue;
				}
				goto case 37;
			case 37:
				if (P_1 >= MinRegion)
				{
					num = 2;
					continue;
				}
				goto IL_048e;
			case 11:
			case 34:
				num4 = ((P_4 >= (double)YMin) ? 1 : 0);
				goto IL_04f9;
			case 10:
				if (!(P_2 >= P_0) || !(P_1 + P_11 <= P_12))
				{
					goto IL_0338;
				}
				num = 16;
				if (EwptNXI87ZnT9Th2AZO())
				{
					continue;
				}
				goto case 29;
			case 29:
				if (P_3 <= YMax)
				{
					num = 15;
					continue;
				}
				goto IL_0338;
			case 2:
				if (P_3 >= P_4)
				{
					num = 20;
					continue;
				}
				goto IL_048e;
			case 41:
				if (direction != ScoringMethodDirection.LowMiddleCutOff)
				{
					_ = 0;
					if (!EwptNXI87ZnT9Th2AZO())
					{
						num = 11;
						if (0 == 0)
						{
							continue;
						}
						goto case 5;
					}
					num = 33;
					continue;
				}
				goto IL_0495;
			case 20:
				if (P_3 >= P_8)
				{
					num = 5;
					continue;
				}
				goto IL_048e;
			case 9:
				goto IL_059b;
			case 30:
				if (!(P_1 >= P_11) || !(P_3 >= P_4))
				{
					goto IL_03e0;
				}
				num = 21;
				if (true)
				{
					continue;
				}
				goto IL_05d5;
			case 46:
				goto IL_05d5;
				IL_04f8:
				num4 = 0;
				goto IL_04f9;
				IL_04f9:
				result = (byte)num4 != 0;
				goto IL_05d5;
				IL_0432:
				num5 = 0;
				goto IL_0433;
				IL_0433:
				result = (byte)num5 != 0;
				goto IL_05d5;
				IL_0339:
				result = (byte)num6 != 0;
				goto IL_05d5;
				IL_0338:
				num6 = 0;
				goto IL_0339;
				IL_048e:
				num3 = 0;
				goto IL_048f;
				IL_048f:
				result = (byte)num3 != 0;
				goto IL_05d5;
				IL_0458:
				if (P_0 >= P_2 && P_2 >= P_1 && P_0 + P_11 <= P_12)
				{
					num = 35;
					continue;
				}
				goto IL_0432;
			}
			break;
			IL_059b:
			if (Type == CaliperScoringMethodType.Straddle)
			{
				result = true;
				num = 46;
			}
			else
			{
				direction = GetDirection();
				num = 41;
			}
			continue;
			IL_00e3:
			int num7;
			result = (byte)num7 != 0;
			goto IL_05d5;
			IL_00e2:
			num7 = 0;
			goto IL_00e3;
			IL_0495:
			if (Type != CaliperScoringMethodType.EdgePairSizeDifferenceAsymmetric)
			{
				num = 7;
				if (Yb6uIVIzw21fQB93C8X())
				{
				}
				continue;
			}
			if (P_0 >= P_2 && P_2 >= P_1 && P_6 >= P_7)
			{
				num = 45;
				continue;
			}
			goto IL_00e2;
			IL_00c2:
			if (!(P_8 <= YMax))
			{
				goto IL_00e2;
			}
			num7 = ((P_9 >= (double)YMin) ? 1 : 0);
			goto IL_00e3;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EVltRxbKDO(CaliperScoringMethodType P_0, int P_1, double P_2, double P_3, EdgeMode P_4)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 30;
		CaliperScoringMethodType type = default;
		while (true)
		{
			switch (num)
			{
			case 31:
				XCHigh = Math.Round(y7TtDKRSKF * 0.8, 0);
				num = 26;
				break;
			case 14:
				P_2 = 256.0;
				num = 11;
				break;
			case 4:
			case 8:
				Y0High = 100.0;
				num = 10;
				if (false)
				{
					return;
				}
				break;
			case 20:
				return;
			case 3:
				X0Low = Math.Round(DcTtrItLmL * 0.2, 0);
				X1Low = Math.Round(DcTtrItLmL * 0.6, 0);
				num = 25;
				break;
			case 2:
				Y1Low = 20.0;
				EwptNXI87ZnT9Th2AZO();
				num = (Yb6uIVIzw21fQB93C8X() ? 1 : 4);
				break;
			case 36:
				DcTtrItLmL = (eQPtSjYm4P = 0.0);
				mR3t2Fe5uO = DcTtrItLmL;
				num = 15;
				break;
			case 15:
				X0Low = S1ADEjRwsqoDwf1CPJa(P_2 * 0.2, 0);
				X1Low = S1ADEjRwsqoDwf1CPJa(P_2 * 0.6, 0);
				XCLow = S1ADEjRwsqoDwf1CPJa(P_2 * 0.8, 0);
				num = 9;
				if (true)
				{
					break;
				}
				goto case 30;
			case 30:
				V5YtiSlbpb = P_0;
				num = 29;
				break;
			case 17:
				DcTtrItLmL = (eQPtSjYm4P = 0.0);
				num = 21;
				break;
			case 21:
				mR3t2Fe5uO = (JC8tC89mbG = yCytE0a8Xk / 2.0);
				XCLow = Math.Round(mR3t2Fe5uO * 0.8, 0);
				num = 13;
				break;
			case 19:
				mR3t2Fe5uO = 0.0;
				num = 3;
				break;
			case 32:
				mR3t2Fe5uO = DcTtrItLmL;
				XCLow = 32.0;
				goto case 34;
			default:
				num = 34;
				break;
			case 9:
				return;
			case 23:
				X1Low = S1ADEjRwsqoDwf1CPJa(P_2 * 0.6, 0);
				X0Low = S1ADEjRwsqoDwf1CPJa(P_2 * 0.8, 0);
				return;
			case 26:
				X1High = S1ADEjRwsqoDwf1CPJa(y7TtDKRSKF * 0.6, 0);
				num = 12;
				if (EwptNXI87ZnT9Th2AZO())
				{
					break;
				}
				goto case 25;
			case 25:
				XCLow = S1ADEjRwsqoDwf1CPJa(DcTtrItLmL * 0.8, 0);
				num = 31;
				break;
			case 7:
				XCLow = S1ADEjRwsqoDwf1CPJa(P_2 * 0.2, 0);
				num = 23;
				break;
			case 38:
				Y0Low = 100.0;
				num = 2;
				break;
			case 29:
				Id = P_1;
				num = 28;
				break;
			case 24:
				type = Type;
				num = 33;
				break;
			case 1:
			case 16:
				X0Low = S1ADEjRwsqoDwf1CPJa(mR3t2Fe5uO * 0.2, 0);
				num = 35;
				break;
			case 13:
				X1Low = S1ADEjRwsqoDwf1CPJa(mR3t2Fe5uO * 0.6, 0);
				goto case 1;
			case 6:
				DcTtrItLmL = (eQPtSjYm4P = 0.0);
				mR3t2Fe5uO = 0.0;
				num = 0;
				break;
			case 18:
				pFntQ9tQiL = P_3;
				gEvtN0JZZf = P_4;
				num = 38;
				if (true)
				{
					break;
				}
				goto case 33;
			case 33:
				switch (type)
				{
				case CaliperScoringMethodType.EdgePairSizeDifferenceAsymmetric:
					y7TtDKRSKF = (fXwtGH4OZu = yCytE0a8Xk - P_3);
					DcTtrItLmL = (eQPtSjYm4P = 0.0 - P_3);
					num = 19;
					goto end_IL_024b;
				case CaliperScoringMethodType.EdgePairSizeDifference:
					y7TtDKRSKF = (fXwtGH4OZu = Math.Abs(P_3 - yCytE0a8Xk));
					num = 6;
					goto end_IL_024b;
				case CaliperScoringMethodType.EdgePairSize:
					y7TtDKRSKF = (fXwtGH4OZu = yCytE0a8Xk);
					num = 36;
					goto end_IL_024b;
				default:
					num = 27;
					if (Yb6uIVIzw21fQB93C8X())
					{
					}
					goto end_IL_024b;
				case CaliperScoringMethodType.PositionNormalized:
				case CaliperScoringMethodType.Position:
					break;
				case CaliperScoringMethodType.Contrast:
					y7TtDKRSKF = (fXwtGH4OZu = yCytE0a8Xk - 1.0);
					DcTtrItLmL = (eQPtSjYm4P = 0.0);
					num = 32;
					goto end_IL_024b;
				case CaliperScoringMethodType.FullRegionPositionNormalized:
				case CaliperScoringMethodType.FullRegionPosition:
					y7TtDKRSKF = (fXwtGH4OZu = yCytE0a8Xk - 1.0);
					DcTtrItLmL = (eQPtSjYm4P = 0.0);
					num = 22;
					goto end_IL_024b;
				case CaliperScoringMethodType.Straddle:
					return;
				}
				y7TtDKRSKF = (fXwtGH4OZu = yCytE0a8Xk - 1.0);
				num = 17;
				if (EwptNXI87ZnT9Th2AZO())
				{
					break;
				}
				goto case 0;
			case 10:
				Y1High = 20.0;
				num = 24;
				break;
			case 37:
				X0Low = S1ADEjRwsqoDwf1CPJa(y7TtDKRSKF * 0.8, 0);
				num = 20;
				if (!Yb6uIVIzw21fQB93C8X())
				{
					break;
				}
				goto case 11;
			case 11:
				yCytE0a8Xk = (cjstuuq04Z = P_2);
				num = 18;
				if (!EwptNXI87ZnT9Th2AZO())
				{
					return;
				}
				break;
			case 27:
				return;
			case 0:
				XCLow = Math.Round(y7TtDKRSKF * 0.2, 0);
				num = 5;
				break;
			case 35:
				return;
			case 34:
				X1Low = 156.0;
				X0Low = 208.0;
				return;
			case 22:
				mR3t2Fe5uO = DcTtrItLmL;
				num = 7;
				break;
			case 12:
				X0High = S1ADEjRwsqoDwf1CPJa(y7TtDKRSKF * 0.2, 0);
				num = 39;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				X1Low = Math.Round(y7TtDKRSKF * 0.6, 0);
				num = 37;
				if (Yb6uIVIzw21fQB93C8X())
				{
				}
				break;
			case 28:
				if (Type == CaliperScoringMethodType.Contrast)
				{
					num = 14;
					if (Yb6uIVIzw21fQB93C8X())
					{
					}
					break;
				}
				goto case 11;
			case 39:
				return;
				end_IL_024b:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)L2nipZRCTempOwovtax(new CultureInfo((string)oR7RZhR7NbBGsxEg0Rr(40482)), oR7RZhR7NbBGsxEg0Rr(40496), new object[12]
		{
			Type.ToString(),
			xCktKfSq7x,
			X0Low,
			X1Low,
			XCLow,
			X0High,
			X1High,
			XCHigh,
			Y0Low,
			Y1Low,
			Y0High,
			Y1High
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CMLtsBmhTE(double P_0, double P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!EwptNXI87ZnT9Th2AZO()) ? 2 : 5);
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				return;
			case 0:
			case 5:
				if (P_0.Equals(P_1))
				{
					return;
				}
				if (IvjtdloAaY == null)
				{
					num = 3;
					break;
				}
				goto case 4;
			case 4:
				IvjtdloAaY.Add(new KeyValuePair<double, double>(P_0, P_1));
				num = 6;
				break;
			case 3:
				IvjtdloAaY = new List<KeyValuePair<double, double>>();
				goto case 4;
			default:
				num = 4;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void frKt691BsZ(List<KeyValuePair<double, double>> P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (IvjtdloAaY == null)
		{
			IvjtdloAaY = new List<KeyValuePair<double, double>>();
		}
		IvjtdloAaY.AddRange(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void uXotHcTn0L()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (IvjtdloAaY != null)
		{
			bsyhd8RKUVMY9V1Qn6u(IvjtdloAaY);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Clone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCaliperScoringMethod(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetEdgeModeString(EdgeMode edgeMode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (!EwptNXI87ZnT9Th2AZO())
		{
			goto IL_001e;
		}
		goto IL_0037;
		IL_005c:
		_ = 1;
		if (!Yb6uIVIzw21fQB93C8X())
		{
			num = 2;
		}
		else
		{
			num = 0;
			if (1 == 0)
			{
				goto IL_00ca;
			}
		}
		goto IL_0037;
		IL_00ca:
		string result = default;
		return result;
		IL_0037:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			default:
				goto IL_005c;
			case 6:
				if (edgeMode != EdgeMode.SingleEdge)
				{
					num = 5;
					if (true)
					{
						continue;
					}
					goto IL_00ca;
				}
				result = (string)Lp82JpR51GZCqh3naeM();
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
				result = string.Empty;
				num = 6;
				if (EwptNXI87ZnT9Th2AZO())
				{
					continue;
				}
				goto case 2;
			case 2:
			case 3:
				result = Resources.EdgeModeEdgePair;
				goto IL_00ca;
			case 0:
			case 4:
			case 7:
				goto IL_00ca;
			}
			break;
		}
		goto IL_001e;
		IL_001e:
		if (edgeMode == EdgeMode.EdgePair)
		{
			goto IL_005c;
		}
		goto IL_00ca;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EwptNXI87ZnT9Th2AZO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Yb6uIVIzw21fQB93C8X()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double S1ADEjRwsqoDwf1CPJa(double P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Round(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double PdEQ4oRsNI6pE6wFy5V(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Abs(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void J3IXtuRhEoZTmUiBZbI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vAIbNwRL8towEQuhqCD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CaliperScoringMethodType AbXe2FR93Yw7UpZWPre(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCaliperScoringMethod)P_0).Type;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double fJMQFjRS3f4tN9UMBDp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCaliperScoringMethod)P_0).RegionSize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double V75TRwRElsM3rcXeeOZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCaliperScoringMethod)P_0).EdgePairSize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EdgeMode WN0U77Rv5DqpGc8c9mh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCaliperScoringMethod)P_0).EdgeMode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zL1ktqRHRajJWwkQYmj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CaliperStraddle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Pf5pb6RVYJ7jiGHsoUR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CaliperPositionEitherSideOfTheRegion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object onJFLORAnmkCS9o0NCc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CaliperPositionInRegionCenter;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MBEXnURDkWciHubO008()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CaliperPositionEitherSideOfTheRegionNormalized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nKwkriRUf3PpaiIp1XR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CaliperPositionInRegionCenterNormalized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vNW0lHRTVn3wZLWBkVx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CaliperHighContrast;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cnVC7GRdU9jYI1eeX3u()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CaliperLowContrast;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gqwDTmRiFUf3fqBpgCL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CaliperLargerSizes;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rCiDpaRqG9H5l28lSAU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CaliperSmallerSizes;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Mgh91gRBoRf2uiIifEp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CaliperPositionRightSideNormalized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hr4CXARjvc1xvsIqQPO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CaliperPositionLeftSideNormalized;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iqitMARcoMRrDD2bo35()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CaliperSizesFurthestFromPixels;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MgtRIkR2PlmAFFMIids(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kJ6cUvRW40Nd0EOC3Gh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CaliperSizesClosestToPixels;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oR7RZhR7NbBGsxEg0Rr(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double G4Q3n5RtuMOr2xnHDLT(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Ceiling(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object L2nipZRCTempOwovtax(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((IFormatProvider)P_0, (string)P_1, (object[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bsyhd8RKUVMY9V1Qn6u(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((List<KeyValuePair<double, double>>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Lp82JpR51GZCqh3naeM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.EdgeModeSingleEdge;
	}
}
