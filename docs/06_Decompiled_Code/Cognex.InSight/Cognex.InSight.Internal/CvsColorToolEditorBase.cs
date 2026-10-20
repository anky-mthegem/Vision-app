using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

public abstract class CvsColorToolEditorBase
{
	public class CvsColorModelSamples
	{
		private float JJ4mKcnU0G;

		private float iFSmEwPxNM;

		private Color[] pn9mQfITDp;

		private Color[] zHPmNdpRai;

		private Color[] kaqmiSrAAM;

		private Color[] S6mmdn5LD2;

		private Color[] mtumur9ANt;

		public Color[,] SigmaColors
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				int num = 4;
				Color[,] array = default;
				int num2 = default;
				Color color2 = default;
				Color color = default;
				int num4 = default;
				while (true)
				{
					int num3;
					switch (num)
					{
					case 5:
						JCiwXlsrRpMs9Dy0T80N(array, num2, num3++, SlZrf8srI4SjfH0aR09a(color2.R, (color.G + color2.G) / 2, color2.B));
						JCiwXlsrRpMs9Dy0T80N(array, num2, num3++, SlZrf8srI4SjfH0aR09a(color2.R, color2.G, color2.B));
						num = 2;
						if (zToeMNsrQLMkA1t6XXmI())
						{
							continue;
						}
						goto case 14;
					case 14:
						JCiwXlsrRpMs9Dy0T80N(array, num2, num3++, SlZrf8srI4SjfH0aR09a(color.R, color.G, color.B));
						zToeMNsrQLMkA1t6XXmI();
						if (!FMwLYysrll35a8PPJbnF())
						{
							num = 6;
							continue;
						}
						num = 18;
						if (true)
						{
							continue;
						}
						goto case 9;
					case 2:
						num2++;
						goto case 0;
					case 9:
						array = new Color[num4, 13];
						num = 11;
						continue;
					case 1:
						JCiwXlsrRpMs9Dy0T80N(array, num2, num3++, SlZrf8srI4SjfH0aR09a(color2.R, color.G, color.B));
						JCiwXlsrRpMs9Dy0T80N(array, num2, num3++, SlZrf8srI4SjfH0aR09a(color2.R, (color.G + color2.G) / 2, color.B));
						JCiwXlsrRpMs9Dy0T80N(array, num2, num3++, SlZrf8srI4SjfH0aR09a(color2.R, color2.G, color.B));
						goto case 17;
					default:
						num = 17;
						continue;
					case 13:
						num3 = 0;
						num = 14;
						continue;
					case 10:
						color2 = zHPmNdpRai[num2];
						num = 13;
						continue;
					case 0:
					case 16:
					case 18:
						if (num2 >= num4)
						{
							num = 19;
							continue;
						}
						color = pn9mQfITDp[num2];
						num = 10;
						if (0 == 0)
						{
							continue;
						}
						break;
					case 3:
						JCiwXlsrRpMs9Dy0T80N(array, num2, num3++, SlZrf8srI4SjfH0aR09a((color.R + color2.R) / 2, color.G, color2.B));
						num = 8;
						continue;
					case 6:
					case 7:
						JCiwXlsrRpMs9Dy0T80N(array, num2, num3++, SlZrf8srI4SjfH0aR09a((color.R + color2.R) / 2, color.G, color.B));
						num = 1;
						continue;
					case 11:
						num2 = 0;
						num = 0;
						continue;
					case 8:
						JCiwXlsrRpMs9Dy0T80N(array, num2, num3++, Color.FromArgb(color2.R, color.G, color2.B));
						num = 5;
						continue;
					case 17:
						JCiwXlsrRpMs9Dy0T80N(array, num2, num3++, Color.FromArgb((color.R + color2.R) / 2, color2.G, color.B));
						JCiwXlsrRpMs9Dy0T80N(array, num2, num3++, Color.FromArgb(color.R, color2.G, color.B));
						num = 15;
						if (zToeMNsrQLMkA1t6XXmI())
						{
							continue;
						}
						goto case 15;
					case 15:
						array[num2, num3++] = SlZrf8srI4SjfH0aR09a(color.R, (color.G + color2.G) / 2, (color.B + color2.B) / 2);
						num = 12;
						if (0 == 0)
						{
							continue;
						}
						goto case 4;
					case 4:
						num4 = pn9mQfITDp.Length;
						num = 9;
						continue;
					case 12:
						JCiwXlsrRpMs9Dy0T80N(array, num2, num3++, SlZrf8srI4SjfH0aR09a(color.R, color.G, color2.B));
						num = 3;
						continue;
					case 19:
						break;
					}
					break;
				}
				return array;
			}
		}

		public Color[] HighlightLineColors
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return mtumur9ANt;
			}
		}

		public Color[] UpperMatteLineColors
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return S6mmdn5LD2;
			}
		}

		public Color[] LowerMatteLineColors
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return kaqmiSrAAM;
			}
		}

		public float HighlightUpperLimit
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return iFSmEwPxNM;
			}
		}

		public float UpperMatteLineLimit
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return JJ4mKcnU0G;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CvsColorModelSamples()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 7;
			while (true)
			{
				switch (num)
				{
				case 4:
				case 8:
					Vd2sp4sruSa4th0unMeE(this);
					num = 11;
					break;
				case 1:
					S6mmdn5LD2 = new Color[0];
					num = 0;
					if (true)
					{
						break;
					}
					goto case 0;
				case 0:
					mtumur9ANt = new Color[0];
					goto case 4;
				case 9:
					kaqmiSrAAM = new Color[0];
					num = 1;
					if (!FMwLYysrll35a8PPJbnF())
					{
						break;
					}
					goto case 10;
				case 10:
					pn9mQfITDp = new Color[0];
					num = 5;
					if (zToeMNsrQLMkA1t6XXmI())
					{
						break;
					}
					goto case 2;
				case 2:
				case 6:
					iFSmEwPxNM = 10f;
					num = 10;
					break;
				case 7:
					Yi0uMMsrereULFLZvIKd();
					num = 3;
					break;
				case 3:
					JJ4mKcnU0G = 10f;
					_ = 1;
					num = ((!FMwLYysrll35a8PPJbnF()) ? 6 : 4);
					break;
				case 5:
					zHPmNdpRai = new Color[0];
					goto case 9;
				default:
					num = 9;
					if (FMwLYysrll35a8PPJbnF())
					{
						return;
					}
					break;
				case 11:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Yi0uMMsrereULFLZvIKd()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Vd2sp4sruSa4th0unMeE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zToeMNsrQLMkA1t6XXmI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FMwLYysrll35a8PPJbnF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Color SlZrf8srI4SjfH0aR09a(int P_0, int P_1, int P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Color.FromArgb(P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void JCiwXlsrRpMs9Dy0T80N(object P_0, int P_1, int P_2, Color P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Color[,])P_0)[P_1, P_2] = P_3;
		}
	}

	protected internal enum CustomProtocolResponse
	{
		ExtractorGroupList = 0,
		ExtractorGroupData = 1,
		ExtractorModelData = 2,
		ExtractorEnabledGroupList = 3,
		ExtractorSigmaColorSamples = 4,
		ExtractorMatteLineColorSamples = 5,
		ExtractorHighlightLineColorSamples = 6,
		ExtractorLibraryName = 7,
		MatchModelList = 100,
		MatchModelData = 101,
		MatchEnabledModelList = 102,
		MatchMatteLineColorSamples = 103,
		MatchLibraryName = 104
	}

	private CvsInSight JcittWukNd;

	private CvsCellLocation lnPtWwgM1M;

	private bool pMxt3YotuG;

	private bool TdltLRIgiM;

	protected static TraceSwitch mSwitch;

	public CvsInSight InSight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return JcittWukNd;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			S7gxyqIIoocoFjdfw1E();
			int num = (L1p5BYIRjwJbYou61JI() ? 2 : 4);
			while (true)
			{
				switch (num)
				{
				case 3:
					return;
				case 0:
				case 4:
					if (!TdltLRIgiM)
					{
						JcittWukNd = value;
						num = 5;
						break;
					}
					goto case 1;
				case 1:
				case 2:
					Init(value, lnPtWwgM1M, pMxt3YotuG);
					return;
				default:
					num = 3;
					if (1 == 0)
					{
						return;
					}
					break;
				case 5:
					return;
				}
			}
		}
	}

	public CvsCellLocation CellLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return lnPtWwgM1M;
		}
	}

	protected bool InDialog
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return pMxt3YotuG;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsColorToolEditorBase()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		do
		{
			IL_0050:
			switch (num)
			{
			case 3:
				boiFrRIaiPueIbtavLA();
				_ = 0;
				if (S7gxyqIIoocoFjdfw1E())
				{
					num = 0;
					goto IL_0050;
				}
				num = 4;
				if (0 == 0)
				{
					goto IL_0050;
				}
				break;
			case 0:
			case 1:
				lnPtWwgM1M = CvsCellLocation.Invalid;
				break;
			case 5:
				return;
			}
			wiqPdwInXaKmQLlreMg(this);
			num = 5;
		}
		while (0 == 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(CvsInSight insight, CvsCellLocation cellLocation, bool inDialog)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0092;
		IL_001a:
		InvalidateData();
		num = 3;
		goto IL_0092;
		IL_0092:
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 2:
			case 7:
				lnPtWwgM1M = cellLocation;
				num = 5;
				continue;
			case 0:
				JcittWukNd = insight;
				_ = 0;
				num = ((!S7gxyqIIoocoFjdfw1E()) ? 1 : 7);
				continue;
			default:
				WK4toQvLCI();
				num = 6;
				continue;
			case 3:
				TdltLRIgiM = true;
				num = 9;
				continue;
			case 5:
				pMxt3YotuG = inDialog;
				goto default;
			case 8:
				BL7tA4HyHm();
				num = 0;
				continue;
			case 9:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Detach()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Init(null, CvsCellLocation.Invalid, inDialog: false);
		TdltLRIgiM = false;
	}

	public abstract void InvalidateData();

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WK4toQvLCI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = JcittWukNd;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BL7tA4HyHm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = JcittWukNd;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SendCommand(CvsColorToolCustomProtocolCommand cmd)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			CvsCellLocation propertySheet;
			if (JcittWukNd == null)
			{
				L1p5BYIRjwJbYou61JI();
				int num;
				if (S7gxyqIIoocoFjdfw1E())
				{
					num = 2;
					if (false)
					{
						return;
					}
				}
				else
				{
					num = 3;
				}
				switch (num)
				{
				case 0:
				case 2:
					return;
				}
			}
			else if (pMxt3YotuG)
			{
				propertySheet = CvsCellLocation.PropertySheet;
				goto IL_008c;
			}
			propertySheet = lnPtWwgM1M;
			goto IL_008c;
			IL_008c:
			CvsCellLocation loc = propertySheet;
			SendColorToolCommand(loc, cmd);
		}
		catch (CvsCommunicationException)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SendColorToolCommand(CvsCellLocation loc, CvsColorToolCustomProtocolCommand cmd)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsColorToolEditorBase()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		boiFrRIaiPueIbtavLA();
		mSwitch = new TraceSwitch((string)fSPkZ7IGkguKOnLo0ty(40350), (string)fSPkZ7IGkguKOnLo0ty(40374));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void boiFrRIaiPueIbtavLA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wiqPdwInXaKmQLlreMg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool S7gxyqIIoocoFjdfw1E()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool L1p5BYIRjwJbYou61JI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fSPkZ7IGkguKOnLo0ty(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}
}
