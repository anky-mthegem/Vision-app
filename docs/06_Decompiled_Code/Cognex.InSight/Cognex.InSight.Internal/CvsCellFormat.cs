using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

[Serializable]
[DebuggerDisplay("Cell: {Location}")]
public sealed class CvsCellFormat : ICloneable
{
	public enum TextScaleModeType
	{
		Default,
		Proportional,
		ShrinkOnly,
		Fixed
	}

	public static readonly string DefaultFontName;

	public static readonly FontStyle DefaultFontStyle;

	public const float DefaultFontSize = 9f;

	public const int DefaultGraphicLineWidth = 2;

	public static CvsFont DefaultUnscaledFont;

	private string abfo99bObQ;

	private float T0AoU4DQhX;

	private FontStyle Ix5o0giU7S;

	private Color kdIowiYogT;

	private Color jEXoRwlE6F;

	private int vMtosM10Is;

	private string Ysno6j9bXo;

	private float V2AoHWjUlV;

	private int ixNoKtMTcv;

	public const StringAlignment StringAlignmentUnspecified = (StringAlignment)(-1);

	private StringAlignment Bi1oEkKZ5O;

	private StringAlignment g9KoQF3HCO;

	private string lLSoNmT9NP;

	[NonSerialized]
	private CvsFont NqEoisei1q;

	[NonSerialized]
	private CvsFont F6BodsLhyn;

	[NonSerialized]
	private CvsFont DkaouULEUv;

	[NonSerialized]
	private CvsFont OFpoGoeFGP;

	[NonSerialized]
	private CvsFont E8loDR6Fn3;

	private TextScaleModeType IjgoeGTaZk;

	private Color li1oSy3VjP;

	private CvsCellLocation SPLorYsyBd;

	private static readonly List<string> V9toCmxnGL;

	public const int MaxGraphicLineWidth = 10;

	public const int MinGraphicLineWidth = 1;

	public bool IsDefaultFont
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
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
			goto IL_00b5;
			IL_00b5:
			Color color = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					goto IL_0036;
				case 1:
				case 2:
					goto IL_0051;
				case 6:
					goto IL_006d;
				case 3:
					color = ForeColor;
					break;
				case 0:
					if (FontSize == 9f)
					{
						num = 3;
						if (BMXhAWeAp1eORPEVtXZ())
						{
							continue;
						}
						goto case 8;
					}
					goto IL_0116;
				case 8:
					return color.IsEmpty;
				}
				break;
				IL_0051:
				if (Ix5o0giU7S == DefaultFontStyle)
				{
					num = 0;
					if (true)
					{
						continue;
					}
					goto IL_006d;
				}
				goto IL_0116;
				IL_006d:
				if (!vTBCVbeQ9ntBhOKWV7c(abfo99bObQ, DefaultFontName))
				{
					pjS3D2eDs9bANbaEnKU();
					num = ((!BMXhAWeAp1eORPEVtXZ()) ? 7 : 2);
					continue;
				}
				goto IL_0116;
			}
			goto IL_001a;
			IL_0116:
			return false;
			IL_0036:
			color = BackColor;
			num = 8;
			if (pjS3D2eDs9bANbaEnKU())
			{
			}
			goto IL_00b5;
			IL_001a:
			if (color.IsEmpty)
			{
				num = 5;
				if (!BMXhAWeAp1eORPEVtXZ())
				{
					goto IL_0036;
				}
				goto IL_00b5;
			}
			goto IL_0116;
		}
	}

	public bool IsDefaultGraphicsFont
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (kPHYTse7lqJog9JHv1E(Ysno6j9bXo, DefaultFontName))
			{
				return V2AoHWjUlV == 9f;
			}
			return false;
		}
	}

	public bool IsSheetFormat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return !SPLorYsyBd.IsValid;
		}
	}

	public CvsCellLocation Location
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SPLorYsyBd;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SPLorYsyBd = value;
		}
	}

	public string FontName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return abfo99bObQ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			BMXhAWeAp1eORPEVtXZ();
			int num;
			if (!pjS3D2eDs9bANbaEnKU())
			{
				num = 3;
				if (!BMXhAWeAp1eORPEVtXZ())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 4;
				if (false)
				{
					goto IL_008d;
				}
			}
			goto IL_005e;
			IL_008d:
			abfo99bObQ = value;
			num = 5;
			goto IL_005e;
			IL_005e:
			switch (num)
			{
			case 0:
			case 3:
				break;
			case 1:
				goto IL_0040;
			default:
				goto IL_008d;
			case 5:
				return;
			}
			goto IL_002e;
			IL_002e:
			if (value == null)
			{
				num = 1;
				if (false)
				{
					goto IL_0040;
				}
				goto IL_005e;
			}
			goto IL_008d;
			IL_0040:
			value = (string)nhBTI8eBCL4q99w3qvt(36622);
			goto IL_008d;
		}
	}

	public float FontSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return T0AoU4DQhX;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			BMXhAWeAp1eORPEVtXZ();
			int num;
			if (!pjS3D2eDs9bANbaEnKU())
			{
				num = 3;
			}
			else
			{
				num = 4;
				if (!BMXhAWeAp1eORPEVtXZ())
				{
					return;
				}
			}
			while (true)
			{
				switch (num)
				{
				case 5:
					value = 9f;
					goto case 2;
				default:
					num = 2;
					if (pjS3D2eDs9bANbaEnKU())
					{
					}
					break;
				case 2:
					T0AoU4DQhX = value;
					num = 6;
					break;
				case 1:
				case 4:
					if (double.IsNaN(value))
					{
						num = 5;
						break;
					}
					goto case 2;
				case 0:
				case 3:
					if (value == 0f)
					{
						goto case 5;
					}
					goto case 1;
				case 6:
					return;
				}
			}
		}
	}

	public bool Bold
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (FontStyle & FontStyle.Bold) == FontStyle.Bold;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			BMXhAWeAp1eORPEVtXZ();
			int num;
			if (!pjS3D2eDs9bANbaEnKU())
			{
				num = 3;
				if (1 == 0)
				{
					return;
				}
			}
			else
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					return;
				case 0:
				case 3:
					if (!value)
					{
						FontStyle &= ~FontStyle.Bold;
						num = 5;
						continue;
					}
					num = 4;
					if (BMXhAWeAp1eORPEVtXZ())
					{
						continue;
					}
					break;
				case 4:
					break;
				case 5:
					return;
				}
				break;
			}
			FontStyle |= FontStyle.Bold;
		}
	}

	public bool Italic
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (FontStyle & FontStyle.Italic) == FontStyle.Italic;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (0 == 0)
			{
				while (true)
				{
					switch (num)
					{
					case 1:
					case 3:
						break;
					default:
						return;
					case 4:
						if (value)
						{
							BMXhAWeAp1eORPEVtXZ();
							num = ((!pjS3D2eDs9bANbaEnKU()) ? 3 : 0);
							continue;
						}
						FontStyle &= ~FontStyle.Italic;
						num = 5;
						if (pjS3D2eDs9bANbaEnKU())
						{
							return;
						}
						continue;
					case 0:
						return;
					case 5:
						return;
					}
					break;
				}
			}
			FontStyle |= FontStyle.Italic;
		}
	}

	public FontStyle FontStyle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Ix5o0giU7S;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Ix5o0giU7S = value;
		}
	}

	public Color ForeColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kdIowiYogT;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kdIowiYogT = value;
		}
	}

	public Color BackColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return jEXoRwlE6F;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			jEXoRwlE6F = value;
		}
	}

	public StringAlignment HorizontalAlignment
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Bi1oEkKZ5O;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Bi1oEkKZ5O = value;
		}
	}

	public StringAlignment VerticalAlignment
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return g9KoQF3HCO;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			g9KoQF3HCO = value;
		}
	}

	public TextScaleModeType TextScaleMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return IjgoeGTaZk;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IjgoeGTaZk = value;
		}
	}

	public int DecimalPlaces
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return vMtosM10Is;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			vMtosM10Is = bPSOGle0oXmUQcaOfeW(pJX4nhepKO0ruEe8mTA(value, 0), 6);
			lLSoNmT9NP = null;
		}
	}

	public int GraphicsLineWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ixNoKtMTcv;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ixNoKtMTcv = CvsMath.Clamp(value, 1, 10);
		}
	}

	public string GraphicsFontName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Ysno6j9bXo;
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
				switch (num)
				{
				default:
					Ysno6j9bXo = value;
					num = 5;
					break;
				case 1:
				case 4:
					value = (string)nhBTI8eBCL4q99w3qvt(36622);
					goto default;
				case 0:
					if (value == null)
					{
						_ = 0;
						num = (BMXhAWeAp1eORPEVtXZ() ? 4 : 3);
						break;
					}
					goto default;
				case 5:
					return;
				}
			}
		}
	}

	public float GraphicsFontSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return V2AoHWjUlV;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (pjS3D2eDs9bANbaEnKU() ? 2 : 4);
			while (true)
			{
				switch (num)
				{
				case 3:
					V2AoHWjUlV = value;
					num = 5;
					if (!pjS3D2eDs9bANbaEnKU())
					{
						break;
					}
					goto case 1;
				case 1:
				case 2:
					value = 9f;
					goto case 3;
				default:
					num = 3;
					break;
				case 0:
				case 4:
					if (value != 0f)
					{
						goto case 3;
					}
					goto case 1;
				case 5:
					return;
				}
			}
		}
	}

	public string NumericFormatString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (lLSoNmT9NP == null)
			{
				lLSoNmT9NP = (string)o4MpnAekIQuD1AKFbiT(nhBTI8eBCL4q99w3qvt(36636), DecimalPlaces.ToString((IFormatProvider)myBRVSe42M0YrFGRY6S()));
			}
			return lLSoNmT9NP;
		}
	}

	public Color CommentFlagColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return li1oSy3VjP;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			li1oSy3VjP = value;
		}
	}

	public CvsFont ScaledFont
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OFpoGoeFGP;
		}
	}

	public CvsFont UnscaledFont
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DkaouULEUv;
		}
	}

	public CvsFont GraphicsFont
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return E8loDR6Fn3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitDefaultUnscaledFont()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (DefaultUnscaledFont == null)
		{
			DefaultUnscaledFont = CvsFont.CreateInstance(new Font(DefaultFontName, 9f));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellFormat(CvsCellLocation location)
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
			case 13:
				ixNoKtMTcv = 2;
				BMXhAWeAp1eORPEVtXZ();
				num = (pjS3D2eDs9bANbaEnKU() ? 7 : 9);
				break;
			case 8:
				V2AoHWjUlV = 9f;
				num = 13;
				break;
			case 3:
				zxRoA6eT0FyfuPFsHLJ(this);
				goto case 7;
			case 2:
				a6PCuQeUfgcPNOSnr42();
				num = 4;
				break;
			case 5:
				vMtosM10Is = 3;
				goto case 14;
			default:
				num = 14;
				break;
			case 7:
			case 12:
				Location = location;
				num = 15;
				break;
			case 0:
				jEXoRwlE6F = Color.Empty;
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 4;
			case 4:
				abfo99bObQ = DefaultFontName;
				num = 1;
				break;
			case 1:
				T0AoU4DQhX = 9f;
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 6;
			case 6:
				Ix5o0giU7S = DefaultFontStyle;
				num = 11;
				break;
			case 9:
			case 10:
				Bi1oEkKZ5O = (StringAlignment)(-1);
				g9KoQF3HCO = (StringAlignment)(-1);
				li1oSy3VjP = CvsCellComment.DefaultFlagColor;
				num = 3;
				if (0 == 0)
				{
					break;
				}
				goto case 14;
			case 14:
				Ysno6j9bXo = DefaultFontName;
				num = 8;
				break;
			case 11:
				kdIowiYogT = Color.Empty;
				num = 0;
				break;
			case 15:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellFormat(CvsCellLocation cellLocation, string cellStyle, string graphicsStyle)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		BMXhAWeAp1eORPEVtXZ();
		int num = (pjS3D2eDs9bANbaEnKU() ? 2 : 3);
		while (true)
		{
			switch (num)
			{
			case 5:
				iVmo3j5nFi(graphicsStyle);
				num = 6;
				break;
			case 1:
			case 2:
				this._002Ector(cellLocation);
				num = 4;
				break;
			case 0:
			case 3:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				goto case 1;
			case 4:
				rMLoWyiS0Q(cellStyle);
				goto case 5;
			default:
				num = 5;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Color wuwotU7tvB(CvsStyleClass P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string attribute = P_0.GetAttribute(P_1);
		if (!TSBqVHedmO0NGowhjOQ(attribute))
		{
			return qOLOXgeiwVlQPiPjnem(attribute);
		}
		return Color.Empty;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rMLoWyiS0Q(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 13;
		string text2 = default;
		StringAlignment bi1oEkKZ5O = default;
		string text3 = default;
		CvsStyleClass cvsStyleClass = default;
		CvsCssParser cvsCssParser = default;
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				if (!kPHYTse7lqJog9JHv1E(text2, kgbOBx7BanbFa22Hp9.ol99ukmDA(35648)))
				{
					if (!(text2 == (string)nhBTI8eBCL4q99w3qvt(35662)))
					{
						num = 12;
						break;
					}
					bi1oEkKZ5O = StringAlignment.Center;
					num = 7;
					break;
				}
				bi1oEkKZ5O = StringAlignment.Far;
				goto case 6;
			case 19:
				if (!kPHYTse7lqJog9JHv1E(text2, nhBTI8eBCL4q99w3qvt(35596)))
				{
					num = 9;
					break;
				}
				bi1oEkKZ5O = StringAlignment.Center;
				num = 18;
				break;
			case 4:
				if (!TSBqVHedmO0NGowhjOQ(text3))
				{
					num = 23;
					break;
				}
				goto IL_02f2;
			case 12:
				bi1oEkKZ5O = (StringAlignment)(-1);
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 14;
			case 14:
				if (cvsStyleClass != null)
				{
					kdIowiYogT = NVsVe8ecYD7k8RNgm72(cvsStyleClass, kgbOBx7BanbFa22Hp9.ol99ukmDA(33770));
					jEXoRwlE6F = NVsVe8ecYD7k8RNgm72(cvsStyleClass, nhBTI8eBCL4q99w3qvt(35472));
					num = 22;
					break;
				}
				goto IL_02f2;
			case 25:
				li1oSy3VjP = NVsVe8ecYD7k8RNgm72(cvsStyleClass, kgbOBx7BanbFa22Hp9.ol99ukmDA(33770));
				num = 27;
				if (0 == 0)
				{
					break;
				}
				goto case 18;
			case 9:
				bi1oEkKZ5O = (StringAlignment)(-1);
				goto case 18;
			case 18:
			case 24:
				g9KoQF3HCO = bi1oEkKZ5O;
				goto case 15;
			default:
				num = 15;
				break;
			case 20:
				if (!kPHYTse7lqJog9JHv1E(text2, kgbOBx7BanbFa22Hp9.ol99ukmDA(35636)))
				{
					num = 0;
					break;
				}
				bi1oEkKZ5O = StringAlignment.Near;
				goto case 6;
			case 15:
				text2 = (string)mGiWt9e2WCqGTgJG17e(cvsStyleClass, nhBTI8eBCL4q99w3qvt(35612));
				num = 20;
				break;
			case 26:
				if (cvsStyleClass != null)
				{
					num = 25;
					break;
				}
				return;
			case 1:
			case 16:
				return;
			case 13:
				if (!TSBqVHedmO0NGowhjOQ(P_0))
				{
					cvsCssParser = new CvsCssParser();
					num = 21;
				}
				else
				{
					pjS3D2eDs9bANbaEnKU();
					num = ((!BMXhAWeAp1eORPEVtXZ()) ? 10 : 16);
				}
				break;
			case 11:
				vMtosM10Is = uRKLpheWSPybGNOvl1M(text) - 4;
				num = 3;
				break;
			case 2:
				if (kPHYTse7lqJog9JHv1E(text2, kgbOBx7BanbFa22Hp9.ol99ukmDA(35580)))
				{
					bi1oEkKZ5O = StringAlignment.Far;
					goto case 18;
				}
				num = 19;
				break;
			case 6:
			case 7:
			case 10:
			case 17:
				Bi1oEkKZ5O = bi1oEkKZ5O;
				num = 8;
				break;
			case 8:
				text3 = (string)mGiWt9e2WCqGTgJG17e(cvsStyleClass, kgbOBx7BanbFa22Hp9.ol99ukmDA(35678));
				num = 4;
				break;
			case 21:
				gIRrcmeqJCEZleujl87(cvsCssParser, P_0);
				cvsStyleClass = (CvsStyleClass)q8rMyQejgmUlTYCbq8R(cvsCssParser, nhBTI8eBCL4q99w3qvt(35458));
				num = 14;
				if (BMXhAWeAp1eORPEVtXZ())
				{
					break;
				}
				goto case 23;
			case 23:
				pbEoLLdFHT(text3);
				goto IL_02f2;
			case 3:
				text2 = cvsStyleClass.GetAttribute((string)nhBTI8eBCL4q99w3qvt(35538));
				num = 5;
				break;
			case 5:
				if (text2 == kgbOBx7BanbFa22Hp9.ol99ukmDA(35570))
				{
					bi1oEkKZ5O = StringAlignment.Near;
					num = 24;
				}
				else
				{
					num = 2;
				}
				break;
			case 22:
				text = (string)mGiWt9e2WCqGTgJG17e(cvsStyleClass, nhBTI8eBCL4q99w3qvt(35508));
				if (!TSBqVHedmO0NGowhjOQ(text))
				{
					num = 11;
					break;
				}
				goto case 3;
			case 27:
				return;
				IL_02f2:
				cvsStyleClass = (CvsStyleClass)q8rMyQejgmUlTYCbq8R(cvsCssParser, nhBTI8eBCL4q99w3qvt(35690));
				num = 26;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void iVmo3j5nFi(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 12;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_013c;
		IL_001a:
		string attribute = default;
		TextScaleModeType ijgoeGTaZk = default;
		if (kPHYTse7lqJog9JHv1E(attribute, kgbOBx7BanbFa22Hp9.ol99ukmDA(35820)))
		{
			ijgoeGTaZk = TextScaleModeType.ShrinkOnly;
			num = 9;
		}
		else
		{
			ijgoeGTaZk = TextScaleModeType.Default;
			num = 5;
		}
		goto IL_013c;
		IL_013c:
		CvsStyleClass cvsStyleClass = default;
		string text = default;
		string attribute2 = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				break;
			case 8:
				if (kPHYTse7lqJog9JHv1E(attribute, nhBTI8eBCL4q99w3qvt(35778)))
				{
					ijgoeGTaZk = TextScaleModeType.Fixed;
					num = 2;
				}
				else
				{
					num = 11;
				}
				continue;
			case 3:
			case 14:
				E8loDR6Fn3 = CvsFont.CreateInstance(new Font(Ysno6j9bXo, V2AoHWjUlV), canDisposeFontIfUnused: true);
				num = 17;
				continue;
			case 0:
				if (cvsStyleClass == null)
				{
					return;
				}
				text = (string)mGiWt9e2WCqGTgJG17e(cvsStyleClass, nhBTI8eBCL4q99w3qvt(35710));
				num = 15;
				continue;
			case 6:
				if (!string.IsNullOrEmpty(attribute2))
				{
					num = 16;
					continue;
				}
				return;
			case 10:
				attribute = cvsStyleClass.GetAttribute((string)nhBTI8eBCL4q99w3qvt(35738));
				num = 8;
				continue;
			case 16:
				ParseGraphicsFontString(attribute2, ref Ysno6j9bXo, ref V2AoHWjUlV);
				goto case 3;
			case 11:
				if (kPHYTse7lqJog9JHv1E(attribute, kgbOBx7BanbFa22Hp9.ol99ukmDA(35792)))
				{
					ijgoeGTaZk = TextScaleModeType.Proportional;
					goto case 2;
				}
				break;
			default:
				num = 7;
				continue;
			case 1:
			case 4:
				ixNoKtMTcv = x2geqFetuDssbTFAoWr(text);
				num = 10;
				continue;
			case 13:
				return;
			case 12:
				if (!string.IsNullOrEmpty(P_0))
				{
					CvsCssParser cvsCssParser = new CvsCssParser();
					gIRrcmeqJCEZleujl87(cvsCssParser, P_0);
					cvsStyleClass = (CvsStyleClass)q8rMyQejgmUlTYCbq8R(cvsCssParser, "");
					num = 0;
					continue;
				}
				num = 13;
				if (BMXhAWeAp1eORPEVtXZ())
				{
					continue;
				}
				goto case 15;
			case 15:
				if (TSBqVHedmO0NGowhjOQ(text))
				{
					goto case 10;
				}
				_ = 0;
				if (!BMXhAWeAp1eORPEVtXZ())
				{
					num = 3;
					continue;
				}
				num = 1;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
			case 5:
			case 9:
				IjgoeGTaZk = ijgoeGTaZk;
				attribute2 = cvsStyleClass.GetAttribute((string)nhBTI8eBCL4q99w3qvt(35678));
				num = 6;
				if (true)
				{
					continue;
				}
				return;
			case 17:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pbEoLLdFHT(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 16;
		string text = default;
		FontStyle fontStyle = default;
		FontStyle ix5o0giU7S = default;
		Match match = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				if (!(text == kgbOBx7BanbFa22Hp9.ol99ukmDA(35930)))
				{
					num = 6;
					break;
				}
				fontStyle = FontStyle.Strikeout;
				num = 12;
				break;
			case 2:
			case 3:
				if (OBwaIaeKJSd1WHPHaV8(text, kgbOBx7BanbFa22Hp9.ol99ukmDA(35866)))
				{
					goto case 4;
				}
				if (!NClqyheoc1yyyP5K38V(text, nhBTI8eBCL4q99w3qvt(35872)))
				{
					ix5o0giU7S = Ix5o0giU7S;
					if (!kPHYTse7lqJog9JHv1E(text, nhBTI8eBCL4q99w3qvt(35880)))
					{
						num = 14;
						break;
					}
					fontStyle = FontStyle.Bold;
					num = 0;
				}
				else
				{
					num = 7;
				}
				break;
			case 10:
				Ix5o0giU7S = FontStyle.Regular;
				num = 15;
				break;
			case 17:
				if (!kPHYTse7lqJog9JHv1E(text, kgbOBx7BanbFa22Hp9.ol99ukmDA(35908)))
				{
					num = 8;
					break;
				}
				fontStyle = FontStyle.Underline;
				num = 13;
				break;
			case 6:
				fontStyle = FontStyle.Regular;
				goto case 0;
			case 0:
			case 12:
			case 13:
				Ix5o0giU7S = ix5o0giU7S | fontStyle;
				num = 11;
				break;
			case 14:
				if (!(text == (string)nhBTI8eBCL4q99w3qvt(35892)))
				{
					goto case 17;
				}
				fontStyle = FontStyle.Italic;
				goto case 0;
			default:
				num = 17;
				break;
			case 16:
				match = new Regex(kgbOBx7BanbFa22Hp9.ol99ukmDA(35836)).Match(P_0);
				num = 10;
				if (!pjS3D2eDs9bANbaEnKU())
				{
					break;
				}
				goto case 7;
			case 7:
				FontSize = (float)Convert.ToDouble((string)ixe4WeePp8Clfp3IryA(text, 0, text.Length - 2));
				num = 1;
				if (!pjS3D2eDs9bANbaEnKU())
				{
					break;
				}
				goto case 1;
			case 4:
			case 5:
				abfo99bObQ = (string)Evqv9ve5yudEM7c8Gau(text, new char[1] { '"' });
				num = 9;
				break;
			case 1:
			case 9:
			case 11:
				match = match.NextMatch();
				goto case 15;
			case 15:
				if (match.Success)
				{
					text = (string)oHDVeKeCNZ6dnN7w150(match);
					BMXhAWeAp1eORPEVtXZ();
					if (pjS3D2eDs9bANbaEnKU())
					{
						num = 5;
						if (true)
						{
							break;
						}
						goto case 10;
					}
					num = 2;
					break;
				}
				num = 18;
				if (!BMXhAWeAp1eORPEVtXZ())
				{
					return;
				}
				break;
			case 18:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ParseGraphicsFontString(string fontStr, ref string fontName, ref float fontSize)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		BMXhAWeAp1eORPEVtXZ();
		int num;
		if (!pjS3D2eDs9bANbaEnKU())
		{
			num = 8;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 6;
			if (pjS3D2eDs9bANbaEnKU())
			{
			}
		}
		goto IL_005a;
		IL_002a:
		int num2 = default;
		fontName = (string)aOwOy4exvneNkwMacJV(fontStr, num2 + 1);
		num = 9;
		goto IL_005a;
		IL_005a:
		string text = default;
		int num3 = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				break;
			case 4:
				text = fontStr.Substring(0, num3);
				goto case 5;
			default:
				num = 5;
				continue;
			case 1:
			case 6:
				num3 = agEvCteYOZ7Mq3a5Dah(fontStr, ' ');
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				goto case 3;
			case 3:
				if (num3 > 0)
				{
					num = 4;
					continue;
				}
				break;
			case 0:
			case 8:
				num2 = 0;
				goto case 1;
			case 2:
				num2 = num3;
				num = 7;
				if (pjS3D2eDs9bANbaEnKU())
				{
				}
				continue;
			case 5:
				fontSize = (float)XSXkIWeN8OpfuefFrmw(ixe4WeePp8Clfp3IryA(text, 0, uRKLpheWSPybGNOvl1M(text) - 2));
				num = 2;
				continue;
			case 9:
				return;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OvioksqVdP(StringBuilder P_0, string P_1, Color P_2, Color P_3)
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
		goto IL_0038;
		IL_001a:
		if (P_2 == P_3)
		{
			return;
		}
		uL8aulerKeyUvnxmCBm(P_0, P_1 + (string)nhBTI8eBCL4q99w3qvt(5954) + jdtojOii2S(P_2) + kgbOBx7BanbFa22Hp9.ol99ukmDA(35952));
		num = 5;
		goto IL_0038;
		IL_0038:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			default:
				return;
			case 3:
				if (!NmUhuoe1LoBkK4cEQaf(P_2, Color.Empty))
				{
					_ = 0;
					num = (BMXhAWeAp1eORPEVtXZ() ? 4 : 0);
					continue;
				}
				return;
			case 0:
				return;
			case 5:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string FCroXQOfng(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		StringBuilder stringBuilder = default;
		while (true)
		{
			switch (num)
			{
			default:
				uL8aulerKeyUvnxmCBm(stringBuilder, kgbOBx7BanbFa22Hp9.ol99ukmDA(6452));
				num = 0;
				break;
			case 0:
				uL8aulerKeyUvnxmCBm(stringBuilder, Ca5ofWT6af(li1oSy3VjP));
				num = 7;
				break;
			case 4:
				if (HFHoYjmGmQ())
				{
					num = 5;
					break;
				}
				stringBuilder = new StringBuilder(P_0);
				_ = 1;
				num = ((!pjS3D2eDs9bANbaEnKU()) ? 1 : 6);
				break;
			case 5:
				return P_0;
			case 1:
			case 2:
				if (uRKLpheWSPybGNOvl1M(P_0) > 0)
				{
					goto default;
				}
				goto case 0;
			case 7:
				return stringBuilder.ToString();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ToCellStyle()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (pjS3D2eDs9bANbaEnKU())
		{
			goto IL_0299;
		}
		goto IL_038f;
		IL_0299:
		if (vTBCVbeQ9ntBhOKWV7c(abfo99bObQ, DefaultFontName))
		{
			goto IL_01bc;
		}
		num = 22;
		goto IL_038f;
		IL_01bc:
		StringBuilder stringBuilder = default;
		stringBuilder.Append(kgbOBx7BanbFa22Hp9.ol99ukmDA(36304));
		num = 26;
		goto IL_038f;
		IL_038f:
		string text = default;
		StringAlignment bi1oEkKZ5O = default;
		while (true)
		{
			switch (num)
			{
			case 27:
				OvioksqVdP(stringBuilder, (string)nhBTI8eBCL4q99w3qvt(35472), jEXoRwlE6F, KZJ5FgeOCeq78ktxE47());
				num = 24;
				continue;
			case 19:
				uL8aulerKeyUvnxmCBm(stringBuilder, nhBTI8eBCL4q99w3qvt(36376));
				goto IL_0074;
			case 25:
				uvGbkFe3uu6WLjnwFti(stringBuilder, nhBTI8eBCL4q99w3qvt(33770), kdIowiYogT, Color.Navy);
				num = 27;
				if (BMXhAWeAp1eORPEVtXZ())
				{
					continue;
				}
				goto case 9;
			case 9:
				stringBuilder.Append((string)nhBTI8eBCL4q99w3qvt(35978));
				xO3pDJeMXQRVcgBUCKT(stringBuilder, '0', vMtosM10Is);
				uL8aulerKeyUvnxmCBm(stringBuilder, nhBTI8eBCL4q99w3qvt(36018));
				num = 11;
				continue;
			case 10:
				uL8aulerKeyUvnxmCBm(stringBuilder, LtmGXteeytAJBBKbHI5(nhBTI8eBCL4q99w3qvt(36408), T0AoU4DQhX));
				stringBuilder.Append((string)nhBTI8eBCL4q99w3qvt(35952));
				num = 28;
				continue;
			case 24:
				if (vMtosM10Is != 3)
				{
					num = 9;
					if (0 == 0)
					{
						continue;
					}
					break;
				}
				goto IL_042b;
			case 6:
			case 7:
			case 16:
			case 20:
				break;
			case 23:
				text = stringBuilder.ToString();
				num = 13;
				continue;
			case 22:
				goto IL_0180;
			case 18:
				text = "";
				num = 29;
				if (0 == 0)
				{
					continue;
				}
				goto case 8;
			case 8:
				if (FontSize != 9f)
				{
					goto IL_01bc;
				}
				goto case 28;
			case 14:
				return FCroXQOfng("");
			case 28:
				uL8aulerKeyUvnxmCBm(stringBuilder, nhBTI8eBCL4q99w3qvt(5896));
				num = 23;
				continue;
			case 13:
				if (kPHYTse7lqJog9JHv1E(text, kgbOBx7BanbFa22Hp9.ol99ukmDA(36432)))
				{
					num = 18;
					if (pjS3D2eDs9bANbaEnKU())
					{
					}
					continue;
				}
				goto case 29;
			case 2:
			case 4:
			case 5:
			case 12:
			case 21:
				goto end_IL_038f;
			case 15:
				goto IL_02b8;
			case 17:
				if ((Ix5o0giU7S & FontStyle.Italic) != 0)
				{
					stringBuilder.Append((string)nhBTI8eBCL4q99w3qvt(36334));
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					goto case 26;
				}
				goto case 3;
			case 26:
				if ((Ix5o0giU7S & FontStyle.Bold) != 0)
				{
					uL8aulerKeyUvnxmCBm(stringBuilder, kgbOBx7BanbFa22Hp9.ol99ukmDA(36320));
					num = 17;
					continue;
				}
				goto case 17;
			case 3:
				if ((Ix5o0giU7S & FontStyle.Strikeout) != 0)
				{
					num = 1;
					if (true)
					{
						continue;
					}
					goto case 1;
				}
				goto IL_0350;
			case 1:
				uL8aulerKeyUvnxmCBm(stringBuilder, kgbOBx7BanbFa22Hp9.ol99ukmDA(36352));
				goto IL_0350;
			default:
				num = 2;
				continue;
			case 0:
				goto IL_0416;
			case 11:
				goto IL_042b;
			case 29:
				{
					return FCroXQOfng(text);
				}
				IL_0350:
				if ((Ix5o0giU7S & FontStyle.Underline) != 0)
				{
					num = 19;
					continue;
				}
				goto IL_0074;
				IL_0074:
				uL8aulerKeyUvnxmCBm(stringBuilder, fV3wmGelcGUH25BVDYZ(nhBTI8eBCL4q99w3qvt(35866), abfo99bObQ, nhBTI8eBCL4q99w3qvt(36400)));
				num = 10;
				continue;
			}
			goto IL_015e;
			IL_0416:
			if (!TdPocbMtKI())
			{
				stringBuilder = new StringBuilder(kgbOBx7BanbFa22Hp9.ol99ukmDA(35960));
				num = 25;
				if (0 == 0)
				{
					continue;
				}
				goto IL_015e;
			}
			num = 14;
			continue;
			IL_042b:
			bi1oEkKZ5O = g9KoQF3HCO;
			switch (bi1oEkKZ5O)
			{
			case StringAlignment.Near:
				uL8aulerKeyUvnxmCBm(stringBuilder, nhBTI8eBCL4q99w3qvt(36028));
				num = 16;
				continue;
			case StringAlignment.Center:
				break;
			case StringAlignment.Far:
				uL8aulerKeyUvnxmCBm(stringBuilder, nhBTI8eBCL4q99w3qvt(36126));
				num = 6;
				continue;
			default:
				_ = 1;
				num = (pjS3D2eDs9bANbaEnKU() ? 4 : 20);
				continue;
			}
			stringBuilder.Append((string)nhBTI8eBCL4q99w3qvt(36074));
			goto IL_015e;
			IL_015e:
			bi1oEkKZ5O = Bi1oEkKZ5O;
			num = 15;
			continue;
			IL_02b8:
			switch (bi1oEkKZ5O)
			{
			case StringAlignment.Center:
				uL8aulerKeyUvnxmCBm(stringBuilder, nhBTI8eBCL4q99w3qvt(36218));
				num = 21;
				continue;
			default:
				num = 5;
				continue;
			case StringAlignment.Far:
				stringBuilder.Append(kgbOBx7BanbFa22Hp9.ol99ukmDA(36262));
				break;
			case StringAlignment.Near:
				uL8aulerKeyUvnxmCBm(stringBuilder, nhBTI8eBCL4q99w3qvt(36178));
				break;
			}
			break;
			IL_0180:
			if (Ix5o0giU7S == DefaultFontStyle)
			{
				num = 8;
				continue;
			}
			goto IL_01bc;
			continue;
			end_IL_038f:
			break;
		}
		goto IL_0299;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string Ca5ofWT6af(Color P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)nhBTI8eBCL4q99w3qvt(36452) + (string)Q2wowFeuDV5stTOdqBo(P_0) + (string)nhBTI8eBCL4q99w3qvt(36488);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string jdtojOii2S(Color P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)OY46UCeIpmgkivEXAYM(CultureInfo.InvariantCulture, nhBTI8eBCL4q99w3qvt(36496), new object[4]
		{
			P_0.R,
			P_0.G,
			P_0.B,
			(float)(int)P_0.A / 255f
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ToGraphicsStyle()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		StringBuilder stringBuilder = default;
		bool flag = default;
		TextScaleModeType ijgoeGTaZk = default;
		while (true)
		{
			switch (num)
			{
			case 19:
				mxal65eRwPmOHPox40w(stringBuilder, ixNoKtMTcv);
				num = 14;
				continue;
			case 18:
				uL8aulerKeyUvnxmCBm(stringBuilder, nhBTI8eBCL4q99w3qvt(36550));
				num = 19;
				continue;
			case 4:
				if (MoUomrSVbv())
				{
					num = 9;
					continue;
				}
				stringBuilder = new StringBuilder("");
				flag = false;
				num = 1;
				continue;
			case 17:
				switch (ijgoeGTaZk)
				{
				case TextScaleModeType.Fixed:
					uL8aulerKeyUvnxmCBm(stringBuilder, nhBTI8eBCL4q99w3qvt(35778));
					num = 20;
					continue;
				case TextScaleModeType.Proportional:
					stringBuilder.Append((string)nhBTI8eBCL4q99w3qvt(35792));
					num = 0;
					if (pjS3D2eDs9bANbaEnKU())
					{
					}
					continue;
				case TextScaleModeType.ShrinkOnly:
					stringBuilder.Append((string)nhBTI8eBCL4q99w3qvt(35820));
					num = 7;
					continue;
				}
				goto default;
			default:
				pjS3D2eDs9bANbaEnKU();
				if (BMXhAWeAp1eORPEVtXZ())
				{
					num = 15;
					continue;
				}
				num = 10;
				if (!pjS3D2eDs9bANbaEnKU())
				{
					continue;
				}
				goto case 8;
			case 14:
				flag = true;
				num = 12;
				if (pjS3D2eDs9bANbaEnKU())
				{
				}
				continue;
			case 3:
				uL8aulerKeyUvnxmCBm(stringBuilder, Ysno6j9bXo ?? "");
				uL8aulerKeyUvnxmCBm(stringBuilder, nhBTI8eBCL4q99w3qvt(35952));
				num = 22;
				continue;
			case 12:
				if (IjgoeGTaZk != TextScaleModeType.Default)
				{
					num = 21;
					continue;
				}
				goto case 5;
			case 2:
				ijgoeGTaZk = IjgoeGTaZk;
				num = 17;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 9:
				return "";
			case 10:
			case 16:
				flag = false;
				stringBuilder.Append(kgbOBx7BanbFa22Hp9.ol99ukmDA(35952));
				num = 6;
				continue;
			case 13:
				uL8aulerKeyUvnxmCBm(stringBuilder, nhBTI8eBCL4q99w3qvt(35952));
				goto IL_0227;
			case 1:
				if (ixNoKtMTcv != 2)
				{
					num = 18;
					continue;
				}
				goto case 12;
			case 0:
			case 7:
			case 11:
			case 15:
			case 20:
				flag = true;
				num = 5;
				if (BMXhAWeAp1eORPEVtXZ())
				{
					continue;
				}
				goto case 5;
			case 5:
				if (!vTBCVbeQ9ntBhOKWV7c(Ysno6j9bXo, DefaultFontName) && V2AoHWjUlV == 9f)
				{
					break;
				}
				if (flag)
				{
					goto case 10;
				}
				goto case 6;
			case 8:
				uL8aulerKeyUvnxmCBm(stringBuilder, LtmGXteeytAJBBKbHI5(nhBTI8eBCL4q99w3qvt(36408), V2AoHWjUlV));
				num = 3;
				continue;
			case 6:
				stringBuilder.Append((string)nhBTI8eBCL4q99w3qvt(36304));
				num = 8;
				continue;
			case 21:
				if (flag)
				{
					num = 13;
					continue;
				}
				goto IL_0227;
			case 22:
				break;
				IL_0227:
				uL8aulerKeyUvnxmCBm(stringBuilder, nhBTI8eBCL4q99w3qvt(36580));
				num = 2;
				continue;
			}
			break;
		}
		return stringBuilder.ToString();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string UpdateCommentFlagColor(CvsCellFormat format, Color commentFlagColor)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (BMXhAWeAp1eORPEVtXZ())
		{
			num = 2;
			if (pjS3D2eDs9bANbaEnKU())
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
			case 1:
			case 3:
				if (weSTPHeaTH1PdmNUWMs(commentFlagColor, CvsCellComment.DefaultFlagColor))
				{
					goto case 4;
				}
				return "";
			default:
				num = 4;
				break;
			case 0:
			case 2:
				if (format == null)
				{
					goto case 1;
				}
				WdvqxoeGbOsS6FVilSY(format, commentFlagColor);
				num = 5;
				break;
			case 4:
				return (string)Do7af9enOQfSZLp0tPT(commentFlagColor);
			case 5:
				return (string)fRQODYeXWos610ulp1x(format);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellFormat(CvsCellFormat other)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 20;
		while (true)
		{
			switch (num)
			{
			case 20:
				a6PCuQeUfgcPNOSnr42();
				num = 16;
				continue;
			case 7:
				Ysno6j9bXo = DefaultFontName;
				V2AoHWjUlV = 9f;
				ixNoKtMTcv = 2;
				num = 8;
				if (BMXhAWeAp1eORPEVtXZ())
				{
					continue;
				}
				goto case 15;
			case 15:
				NqEoisei1q = other.NqEoisei1q;
				goto case 11;
			default:
				num = 11;
				continue;
			case 2:
				ixNoKtMTcv = other.ixNoKtMTcv;
				Ysno6j9bXo = other.Ysno6j9bXo;
				goto case 1;
			case 6:
				Ix5o0giU7S = ehnPBhebxrOTdAVSHqh(other);
				num = 24;
				continue;
			case 21:
				IjgoeGTaZk = other.IjgoeGTaZk;
				num = 10;
				if (0 == 0)
				{
					continue;
				}
				goto case 23;
			case 23:
				vMtosM10Is = other.vMtosM10Is;
				num = 0;
				continue;
			case 24:
				kdIowiYogT = other.kdIowiYogT;
				num = 12;
				if (0 == 0)
				{
					continue;
				}
				goto case 18;
			case 18:
				zxRoA6eT0FyfuPFsHLJ(this);
				num = 4;
				continue;
			case 9:
				DkaouULEUv = other.DkaouULEUv;
				num = 21;
				if (0 == 0)
				{
					continue;
				}
				goto case 16;
			case 16:
				abfo99bObQ = DefaultFontName;
				T0AoU4DQhX = 9f;
				Ix5o0giU7S = DefaultFontStyle;
				kdIowiYogT = Color.Empty;
				jEXoRwlE6F = Color.Empty;
				num = 5;
				continue;
			case 1:
			case 22:
				V2AoHWjUlV = other.V2AoHWjUlV;
				num = 25;
				continue;
			case 3:
			case 17:
				OFpoGoeFGP = other.OFpoGoeFGP;
				num = 9;
				if (BMXhAWeAp1eORPEVtXZ())
				{
					continue;
				}
				goto case 13;
			case 13:
				g9KoQF3HCO = other.g9KoQF3HCO;
				pjS3D2eDs9bANbaEnKU();
				if (!BMXhAWeAp1eORPEVtXZ())
				{
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					goto case 6;
				}
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				goto case 14;
			case 14:
				g9KoQF3HCO = (StringAlignment)(-1);
				num = 19;
				continue;
			case 11:
				abfo99bObQ = other.abfo99bObQ;
				T0AoU4DQhX = other.T0AoU4DQhX;
				num = 6;
				if (BMXhAWeAp1eORPEVtXZ())
				{
					continue;
				}
				goto case 5;
			case 5:
				vMtosM10Is = 3;
				num = 7;
				if (!pjS3D2eDs9bANbaEnKU())
				{
					continue;
				}
				goto case 12;
			case 12:
				Bi1oEkKZ5O = other.Bi1oEkKZ5O;
				num = 13;
				continue;
			case 4:
				jEXoRwlE6F = other.jEXoRwlE6F;
				num = 23;
				continue;
			case 19:
				li1oSy3VjP = CvsCellComment.DefaultFlagColor;
				num = 18;
				continue;
			case 0:
				F6BodsLhyn = other.F6BodsLhyn;
				num = 15;
				continue;
			case 10:
				li1oSy3VjP = other.li1oSy3VjP;
				num = 2;
				if (true)
				{
					continue;
				}
				break;
			case 8:
				break;
			case 25:
				return;
			}
			Bi1oEkKZ5O = (StringAlignment)(-1);
			num = 14;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 14;
		CvsCellFormat cvsCellFormat = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				if (Ix5o0giU7S == ehnPBhebxrOTdAVSHqh(cvsCellFormat) && kdIowiYogT == cvsCellFormat.kdIowiYogT)
				{
					num = 0;
					continue;
				}
				break;
			case 17:
				if (OFpoGoeFGP == cvsCellFormat.OFpoGoeFGP && DkaouULEUv == cvsCellFormat.DkaouULEUv)
				{
					num = 5;
					if (pjS3D2eDs9bANbaEnKU())
					{
					}
					continue;
				}
				break;
			case 9:
				if (g9KoQF3HCO == cvsCellFormat.g9KoQF3HCO)
				{
					num = 17;
					continue;
				}
				break;
			case 0:
				if (Bi1oEkKZ5O == cvsCellFormat.Bi1oEkKZ5O)
				{
					num = 9;
					continue;
				}
				break;
			case 10:
				if (!NmUhuoe1LoBkK4cEQaf(jEXoRwlE6F, cvsCellFormat.jEXoRwlE6F))
				{
					break;
				}
				num = 2;
				if (BMXhAWeAp1eORPEVtXZ())
				{
					continue;
				}
				goto case 2;
			case 2:
				if (r8x9tVe6u7a8HnmqdsW(SPLorYsyBd, cvsCellFormat.SPLorYsyBd))
				{
					_ = 1;
					num = (pjS3D2eDs9bANbaEnKU() ? 1 : 13);
					continue;
				}
				break;
			case 12:
				if (V2AoHWjUlV == cvsCellFormat.V2AoHWjUlV)
				{
					num = 6;
					continue;
				}
				break;
			case 3:
				if (kPHYTse7lqJog9JHv1E(Ysno6j9bXo, cvsCellFormat.Ysno6j9bXo))
				{
					num = 12;
					continue;
				}
				break;
			case 14:
				if (!(obj is CvsCellFormat))
				{
					num = 16;
					if (true)
					{
						continue;
					}
					goto case 16;
				}
				cvsCellFormat = (CvsCellFormat)obj;
				num = 10;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 16:
				return false;
			case 1:
			case 15:
				if (IjgoeGTaZk == cvsCellFormat.IjgoeGTaZk)
				{
					num = 18;
					continue;
				}
				break;
			case 4:
			case 13:
				if (vMtosM10Is == cvsCellFormat.vMtosM10Is && ixNoKtMTcv == cvsCellFormat.ixNoKtMTcv)
				{
					num = 3;
					continue;
				}
				break;
			case 11:
				if (T0AoU4DQhX == cvsCellFormat.T0AoU4DQhX)
				{
					num = 8;
					continue;
				}
				break;
			case 5:
				if (E8loDR6Fn3 != cvsCellFormat.E8loDR6Fn3)
				{
					break;
				}
				goto case 1;
			case 7:
				if (!kPHYTse7lqJog9JHv1E(abfo99bObQ, cvsCellFormat.abfo99bObQ))
				{
					break;
				}
				goto case 11;
			default:
				num = 11;
				continue;
			case 6:
				if (F6BodsLhyn != cvsCellFormat.F6BodsLhyn || NqEoisei1q != cvsCellFormat.NqEoisei1q)
				{
					break;
				}
				num = 7;
				if (BMXhAWeAp1eORPEVtXZ())
				{
					continue;
				}
				goto case 18;
			case 18:
				return NmUhuoe1LoBkK4cEQaf(li1oSy3VjP, cvsCellFormat.li1oSy3VjP);
			}
			break;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SPLorYsyBd.GetHashCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsTextFormat GetTextFormat(CvsTextFormat defaultValue)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		StringAlignment stringAlignment = default;
		CvsTextFormat cvsTextFormat = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stringAlignment = HorizontalAlignment;
				num = 0;
				continue;
			case 2:
				switch (stringAlignment)
				{
				case StringAlignment.Near:
					cvsTextFormat = (cvsTextFormat & ~(CvsTextFormat.VCenter | CvsTextFormat.Bottom)) | CvsTextFormat.Top;
					BMXhAWeAp1eORPEVtXZ();
					num = (pjS3D2eDs9bANbaEnKU() ? 6 : 4);
					continue;
				case StringAlignment.Center:
					cvsTextFormat = (cvsTextFormat & ~CvsTextFormat.Bottom) | CvsTextFormat.VCenter;
					break;
				case StringAlignment.Far:
					cvsTextFormat = (cvsTextFormat & ~CvsTextFormat.VCenter) | CvsTextFormat.Bottom;
					num = 12;
					continue;
				}
				break;
			case 0:
				switch (stringAlignment)
				{
				case StringAlignment.Far:
					goto IL_0082;
				case StringAlignment.Center:
					goto IL_00e3;
				case StringAlignment.Near:
					goto IL_0152;
				}
				num = 1;
				continue;
			default:
				num = 11;
				continue;
			case 1:
			case 5:
			case 10:
			case 11:
				stringAlignment = VerticalAlignment;
				num = 2;
				if (true)
				{
					continue;
				}
				break;
			case 7:
				cvsTextFormat = defaultValue;
				num = 3;
				if (BMXhAWeAp1eORPEVtXZ())
				{
					continue;
				}
				goto case 1;
			case 4:
			case 6:
			case 8:
			case 9:
			case 12:
				break;
				IL_0152:
				cvsTextFormat = (cvsTextFormat & ~(CvsTextFormat.Center | CvsTextFormat.Right)) | CvsTextFormat.Top;
				num = 10;
				if (0 == 0)
				{
					continue;
				}
				break;
				IL_00e3:
				cvsTextFormat = (cvsTextFormat & ~CvsTextFormat.Right) | CvsTextFormat.Center;
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				break;
				IL_0082:
				cvsTextFormat = (cvsTextFormat & ~CvsTextFormat.Center) | CvsTextFormat.Right;
				goto case 1;
			}
			break;
		}
		return cvsTextFormat;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDefaultFonts(CvsFont unscaledFont, CvsFont scaledFont)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		pjS3D2eDs9bANbaEnKU();
		int num = ((!BMXhAWeAp1eORPEVtXZ()) ? 5 : 10);
		FontStyle fontStyle = default;
		Font font = default;
		float emSize = default;
		do
		{
			IL_0046:
			switch (num)
			{
			case 14:
				DkaouULEUv = NqEoisei1q;
				goto case 9;
			default:
				num = 9;
				if (true)
				{
					goto IL_0046;
				}
				goto case 4;
			case 4:
				if (Italic)
				{
					fontStyle |= FontStyle.Italic;
					num = 2;
					goto IL_0046;
				}
				goto case 2;
			case 3:
				if (!Italic)
				{
					num = 14;
					if (pjS3D2eDs9bANbaEnKU())
					{
					}
					goto IL_0046;
				}
				goto IL_0244;
			case 8:
				if (FontSize == 0f)
				{
					num = 3;
					if (0 == 0)
					{
						goto IL_0046;
					}
					goto case 7;
				}
				goto IL_0244;
			case 7:
				if (FontName == null)
				{
					num = 8;
					if (0 == 0)
					{
						goto IL_0046;
					}
					goto case 12;
				}
				goto IL_0244;
			case 12:
				font = new Font((FontFamily)tO5CCDey4oxobxGJnEt(DkaouULEUv.TextFont), emSize, OpHMoFefsccLLQNaaRj(agBDqyeF6hjOnPEGy4b(DkaouULEUv)), XX07TReg8Pt42id4lD4(agBDqyeF6hjOnPEGy4b(DkaouULEUv)), ((Font)agBDqyeF6hjOnPEGy4b(DkaouULEUv)).GdiCharSet);
				num = 6;
				if (0 == 0)
				{
					goto IL_0046;
				}
				goto case 2;
			case 2:
				try
				{
					string name = ((Font)agBDqyeF6hjOnPEGy4b(NqEoisei1q)).FontFamily.Name;
					DkaouULEUv = CvsFont.CreateInstance(new Font((FontName != null) ? FontName : name, (FontSize != 0f) ? FontSize : ((Font)agBDqyeF6hjOnPEGy4b(NqEoisei1q)).Size, fontStyle), canDisposeFontIfUnused: true);
				}
				catch (Exception)
				{
					DkaouULEUv = NqEoisei1q;
					OFpoGoeFGP = F6BodsLhyn;
					return;
				}
				emSize = f4902kemGW6JVwofbOF(DkaouULEUv.TextFont) * f4902kemGW6JVwofbOF(F6BodsLhyn.TextFont) / f4902kemGW6JVwofbOF(agBDqyeF6hjOnPEGy4b(NqEoisei1q));
				num = 12;
				goto IL_0046;
			case 0:
			case 10:
				NqEoisei1q = unscaledFont;
				goto case 1;
			case 9:
				OFpoGoeFGP = F6BodsLhyn;
				return;
			case 1:
			case 5:
				F6BodsLhyn = scaledFont;
				num = 13;
				goto IL_0046;
			case 13:
				if (Bold)
				{
					goto IL_0244;
				}
				num = 7;
				if (!pjS3D2eDs9bANbaEnKU())
				{
					goto IL_0046;
				}
				goto case 11;
			case 11:
				if (Bold)
				{
					fontStyle |= FontStyle.Bold;
					num = 4;
					if (BMXhAWeAp1eORPEVtXZ())
					{
						goto IL_0046;
					}
					break;
				}
				goto case 4;
			case 6:
				break;
			case 15:
				return;
				IL_0244:
				fontStyle = OpHMoFefsccLLQNaaRj(NqEoisei1q.TextFont);
				num = 11;
				goto IL_0046;
			}
			OFpoGoeFGP = CvsFont.CreateInstance(font, canDisposeFontIfUnused: true);
			num = 15;
		}
		while (BMXhAWeAp1eORPEVtXZ());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private bool TdPocbMtKI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!BMXhAWeAp1eORPEVtXZ()) ? 10 : 8);
		while (true)
		{
			switch (num)
			{
			case 6:
			case 10:
				if (FontSize == 9f)
				{
					num = 5;
					continue;
				}
				break;
			case 9:
				if (!kPHYTse7lqJog9JHv1E(abfo99bObQ, DefaultFontName))
				{
					break;
				}
				goto case 1;
			default:
				num = 1;
				continue;
			case 2:
				if (kdIowiYogT == Color.Empty)
				{
					num = 7;
					continue;
				}
				break;
			case 1:
				if (Ix5o0giU7S != DefaultFontStyle)
				{
					break;
				}
				goto case 6;
			case 4:
				if (!NmUhuoe1LoBkK4cEQaf(jEXoRwlE6F, Color.Empty))
				{
					break;
				}
				num = 9;
				if (!pjS3D2eDs9bANbaEnKU())
				{
					continue;
				}
				goto case 3;
			case 3:
				if (VerticalAlignment != (StringAlignment)(-1))
				{
					break;
				}
				num = 11;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 7:
				if (!NmUhuoe1LoBkK4cEQaf(jEXoRwlE6F, KZJ5FgeOCeq78ktxE47()))
				{
					num = 4;
					continue;
				}
				goto case 9;
			case 5:
				if (HorizontalAlignment == (StringAlignment)(-1))
				{
					num = 3;
					continue;
				}
				break;
			case 0:
			case 8:
				if (!NmUhuoe1LoBkK4cEQaf(kdIowiYogT, cfrZ3yeZsxMs1XNqwyq()))
				{
					num = 2;
					continue;
				}
				goto case 7;
			case 11:
				return DecimalPlaces == 3;
			}
			break;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private bool HFHoYjmGmQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!(li1oSy3VjP == Color.Navy))
		{
			return NmUhuoe1LoBkK4cEQaf(li1oSy3VjP, CvsCellComment.DefaultFlagColor);
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private bool MoUomrSVbv()
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
				if (kPHYTse7lqJog9JHv1E(Ysno6j9bXo, DefaultFontName))
				{
					num = 5;
					continue;
				}
				break;
			case 0:
			case 1:
				if (IjgoeGTaZk != TextScaleModeType.Default)
				{
					break;
				}
				goto default;
			case 4:
				if (ixNoKtMTcv != 2)
				{
					break;
				}
				_ = 0;
				if (!BMXhAWeAp1eORPEVtXZ())
				{
					num = 3;
					continue;
				}
				num = 0;
				if (BMXhAWeAp1eORPEVtXZ())
				{
					continue;
				}
				goto case 5;
			case 5:
				return V2AoHWjUlV == 9f;
			}
			break;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	object ICloneable.Clone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCellFormat(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsCellFormat()
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
			case 2:
			case 3:
				DefaultFontStyle = FontStyle.Regular;
				goto case 5;
			default:
				num = 5;
				if (BMXhAWeAp1eORPEVtXZ())
				{
					break;
				}
				goto case 5;
			case 5:
				DefaultUnscaledFont = CvsFont.CreateInstance(new Font(DefaultFontName, 9f));
				num = 6;
				break;
			case 0:
			case 1:
				DefaultFontName = kgbOBx7BanbFa22Hp9.ol99ukmDA(36622);
				goto case 2;
			case 6:
				V9toCmxnGL = new List<string>(1);
				num = 7;
				break;
			case 4:
				a6PCuQeUfgcPNOSnr42();
				BMXhAWeAp1eORPEVtXZ();
				if (pjS3D2eDs9bANbaEnKU())
				{
					num = 3;
					if (true)
					{
						break;
					}
					goto case 6;
				}
				num = 0;
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
	internal static bool BMXhAWeAp1eORPEVtXZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pjS3D2eDs9bANbaEnKU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void a6PCuQeUfgcPNOSnr42()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zxRoA6eT0FyfuPFsHLJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TSBqVHedmO0NGowhjOQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color qOLOXgeiwVlQPiPjnem(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCssParser.ConvertStringToColor((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gIRrcmeqJCEZleujl87(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCssParser)P_0).ParseStyleSheet((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nhBTI8eBCL4q99w3qvt(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object q8rMyQejgmUlTYCbq8R(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCssParser)P_0).GetStyle((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color NVsVe8ecYD7k8RNgm72(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return wuwotU7tvB((CvsStyleClass)P_0, (string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mGiWt9e2WCqGTgJG17e(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsStyleClass)P_0).GetAttribute((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int uRKLpheWSPybGNOvl1M(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kPHYTse7lqJog9JHv1E(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int x2geqFetuDssbTFAoWr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToInt32((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oHDVeKeCNZ6dnN7w150(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Capture)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool OBwaIaeKJSd1WHPHaV8(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).StartsWith((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Evqv9ve5yudEM7c8Gau(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Trim((char[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NClqyheoc1yyyP5K38V(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).EndsWith((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ixe4WeePp8Clfp3IryA(object P_0, int P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Substring(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int agEvCteYOZ7Mq3a5Dah(object P_0, char P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).IndexOf(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double XSXkIWeN8OpfuefFrmw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToDouble((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aOwOy4exvneNkwMacJV(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Substring(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NmUhuoe1LoBkK4cEQaf(Color P_0, Color P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uL8aulerKeyUvnxmCBm(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uvGbkFe3uu6WLjnwFti(object P_0, object P_1, Color P_2, Color P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		OvioksqVdP((StringBuilder)P_0, (string)P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color KZJ5FgeOCeq78ktxE47()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.Transparent;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xO3pDJeMXQRVcgBUCKT(object P_0, char P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StringBuilder)P_0).Append(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vTBCVbeQ9ntBhOKWV7c(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 != (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fV3wmGelcGUH25BVDYZ(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LtmGXteeytAJBBKbHI5(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Q2wowFeuDV5stTOdqBo(Color P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return jdtojOii2S(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OY46UCeIpmgkivEXAYM(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((IFormatProvider)P_0, (string)P_1, (object[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mxal65eRwPmOHPox40w(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StringBuilder)P_0).Append(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool weSTPHeaTH1PdmNUWMs(Color P_0, Color P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 != P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Do7af9enOQfSZLp0tPT(Color P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Ca5ofWT6af(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WdvqxoeGbOsS6FVilSY(object P_0, Color value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCellFormat)P_0).CommentFlagColor = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fRQODYeXWos610ulp1x(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellFormat)P_0).ToCellStyle();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FontStyle ehnPBhebxrOTdAVSHqh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellFormat)P_0).FontStyle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool r8x9tVe6u7a8HnmqdsW(CvsCellLocation left, CvsCellLocation right)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return left == right;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int pJX4nhepKO0ruEe8mTA(int P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Max(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int bPSOGle0oXmUQcaOfeW(int P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Min(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object myBRVSe42M0YrFGRY6S()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.InvariantCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object o4MpnAekIQuD1AKFbiT(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FontStyle OpHMoFefsccLLQNaaRj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Font)P_0).Style;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object agBDqyeF6hjOnPEGy4b(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFont)P_0).TextFont;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float f4902kemGW6JVwofbOF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Font)P_0).Size;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tO5CCDey4oxobxGJnEt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Font)P_0).FontFamily;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GraphicsUnit XX07TReg8Pt42id4lD4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Font)P_0).Unit;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color cfrZ3yeZsxMs1XNqwyq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.Navy;
	}
}
