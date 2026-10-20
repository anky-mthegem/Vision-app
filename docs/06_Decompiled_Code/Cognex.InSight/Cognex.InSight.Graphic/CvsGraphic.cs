using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.InSight.Internal;
using Cognex.InSight.Properties;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public abstract class CvsGraphic : ICloneable
{
	[CompilerGenerated]
	private Font wRuTixCwaT;

	[CompilerGenerated]
	private string VMlTd0ZklK;

	[NonSerialized]
	private PropertyChangedEventHandler udsTuX2IWx;

	private int xJJTGT5l26;

	internal CvsCellLocation mCellLocation;

	internal Color mColor;

	internal Color mHighlightColor;

	internal string mLabel;

	private bool CJrTDCrWeD;

	private bool EGQTefuf9h;

	private int NM5TS2GMMT;

	private byte QrUTr7MYGx;

	private bool RWcTCLx2Yc;

	private CvsCogFixture LQGT2wLS9B;

	[NonSerialized]
	private object hdcTyFZoxg;

	public CvsCellLocation CellLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mCellLocation;
		}
	}

	public Color Color
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mColor;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_004f;
			IL_001a:
			CheckLock();
			_ = 0;
			if (c9QF4hPSfUHC0sVmmCr())
			{
				num = 4;
			}
			else
			{
				num = 0;
				if (1 == 0)
				{
					goto IL_007e;
				}
			}
			goto IL_004f;
			IL_007e:
			OnPropertyChanged((string)p1KAWYPAGCI99Sk9k6i(33784));
			num = 5;
			if (1 == 0)
			{
				return;
			}
			goto IL_004f;
			IL_004f:
			switch (num)
			{
			case 3:
				break;
			case 1:
			case 4:
				mColor = value;
				goto IL_007e;
			default:
				goto IL_007e;
			case 5:
				return;
			}
			goto IL_001a;
		}
	}

	public Color HighlightColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (mHighlightColor.IsEmpty)
			{
				return mColor;
			}
			return mHighlightColor;
		}
	}

	public int HighlightColorAsRgb
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MRvl6VPY02MYDbJlgsK(mHighlightColor);
		}
	}

	public string Label
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mLabel;
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
					OTg6nQPNnbL3bRDqC8B(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(24842));
					num = 5;
					break;
				case 4:
					CheckLock();
					kUTwcDPELikgDYPLk82();
					if (c9QF4hPSfUHC0sVmmCr())
					{
						num = 3;
						break;
					}
					num = 0;
					if (c9QF4hPSfUHC0sVmmCr())
					{
						break;
					}
					return;
				case 1:
				case 3:
					mLabel = value;
					goto default;
				case 5:
					return;
				}
			}
		}
	}

	public Font Font
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wRuTixCwaT;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			wRuTixCwaT = value;
		}
	}

	public bool IsAlwaysShown
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CJrTDCrWeD;
		}
	}

	public bool IsDefaultEdit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EGQTefuf9h;
		}
	}

	protected int Flags
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return NM5TS2GMMT;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool IsFlyover
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (NM5TS2GMMT & 7) == 2;
		}
	}

	public bool IsLocked
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return RWcTCLx2Yc;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual int Id
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xJJTGT5l26;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual byte ZOrder
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return QrUTr7MYGx;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QrUTr7MYGx = value;
		}
	}

	public string UniqueId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return VMlTd0ZklK;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VMlTd0ZklK = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public object Ext
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hdcTyFZoxg;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hdcTyFZoxg = value;
		}
	}

	public CvsCogFixture Fixture
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LQGT2wLS9B;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			LQGT2wLS9B = value;
		}
	}

	internal virtual double[] InternalData
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

	public event PropertyChangedEventHandler PropertyChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			udsTuX2IWx = (PropertyChangedEventHandler)nfY7dmPxiOBVfMK3tSk(udsTuX2IWx, value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			udsTuX2IWx = (PropertyChangedEventHandler)M1mVCCP1Okbut3Qs3Sv(udsTuX2IWx, value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsGraphic()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (kUTwcDPELikgDYPLk82() ? 7 : 8);
		do
		{
			IL_003d:
			switch (num)
			{
			case 4:
				CJrTDCrWeD = true;
				goto case 6;
			default:
				num = 6;
				goto IL_003d;
			case 6:
				base._002Ector();
				num = 5;
				goto IL_003d;
			case 2:
			case 7:
				mHighlightColor = Color.Empty;
				num = 4;
				if (0 == 0)
				{
					goto IL_003d;
				}
				goto case 0;
			case 0:
			case 8:
				idjU21Pv6hDYZK8Pcsl();
				num = 1;
				if (c9QF4hPSfUHC0sVmmCr())
				{
					goto IL_003d;
				}
				goto case 1;
			case 1:
				mColor = Color.Empty;
				goto case 2;
			case 3:
				UniqueId = JClb1fPHZp89xOiNqkU().ToString();
				num = 9;
				if (c9QF4hPSfUHC0sVmmCr())
				{
					goto IL_003d;
				}
				break;
			case 5:
				break;
			case 9:
				return;
			}
			mCellLocation = CvsCellLocation.Invalid;
			num = 3;
		}
		while (c9QF4hPSfUHC0sVmmCr());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsGraphic(CvsGraphic graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		if (!kUTwcDPELikgDYPLk82())
		{
		}
		while (true)
		{
			switch (num)
			{
			case 8:
			case 9:
				mHighlightColor = graphic.mHighlightColor;
				num = 4;
				break;
			case 14:
				throw new ArgumentNullException((string)p1KAWYPAGCI99Sk9k6i(33742));
			case 7:
				idjU21Pv6hDYZK8Pcsl();
				num = 1;
				break;
			case 5:
				LQGT2wLS9B = graphic.LQGT2wLS9B;
				num = 15;
				if (!kUTwcDPELikgDYPLk82())
				{
					break;
				}
				goto case 4;
			case 4:
				CJrTDCrWeD = graphic.CJrTDCrWeD;
				num = 10;
				break;
			case 1:
				mColor = Color.Empty;
				mHighlightColor = Color.Empty;
				kUTwcDPELikgDYPLk82();
				num = ((!c9QF4hPSfUHC0sVmmCr()) ? 8 : 0);
				break;
			case 6:
				if (graphic != null)
				{
					UniqueId = (string)KV7YyLPDNSQDrsfj9vl(graphic);
					num = 3;
					if (0 == 0)
					{
						break;
					}
					goto case 7;
				}
				num = 14;
				break;
			case 0:
			case 2:
				CJrTDCrWeD = true;
				num = 13;
				if (0 == 0)
				{
					break;
				}
				goto case 11;
			case 11:
				mCellLocation = graphic.mCellLocation;
				num = 12;
				break;
			case 10:
				EGQTefuf9h = graphic.EGQTefuf9h;
				mLabel = graphic.mLabel;
				num = 5;
				break;
			case 12:
				mColor = graphic.mColor;
				goto case 8;
			case 13:
				v1DLK1PVQsmUVqljEjs(this);
				num = 6;
				break;
			case 3:
				xJJTGT5l26 = graphic.xJJTGT5l26;
				goto case 11;
			default:
				num = 11;
				break;
			case 15:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsGraphic(ImageConfig image)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_00b7;
		IL_001a:
		mCellLocation.Row = image.cellRow;
		num = 0;
		goto IL_00b7;
		IL_00b7:
		int color = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				break;
			case 11:
				v1DLK1PVQsmUVqljEjs(this);
				JYNTNq6FHF(image.flags);
				num = 10;
				continue;
			case 1:
				mColor = IuZjXdPUecxZB9Iwi0Y(color);
				num = 9;
				continue;
			case 0:
				mCellLocation.Column = image.cellCol;
				RWcTCLx2Yc = true;
				num = 14;
				continue;
			case 2:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 8;
				continue;
			case 6:
			case 13:
				xJJTGT5l26 = image.id;
				goto case 5;
			default:
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 8;
			case 8:
				mColor = Color.Empty;
				num = 4;
				continue;
			case 3:
			case 12:
				CJrTDCrWeD = true;
				num = 11;
				if (!kUTwcDPELikgDYPLk82())
				{
					continue;
				}
				goto case 10;
			case 10:
				UniqueId = JClb1fPHZp89xOiNqkU().ToString();
				goto case 6;
			case 5:
				color = image.color;
				num = 1;
				continue;
			case 4:
				mHighlightColor = Color.Empty;
				_ = 0;
				num = (c9QF4hPSfUHC0sVmmCr() ? 12 : 13);
				continue;
			case 9:
				mHighlightColor = iWuQwaPTbqQgZc1M28y((short)color);
				num = 7;
				continue;
			case 14:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsGraphic(CvsCellLocation location, string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 6:
			case 8:
				mCellLocation = location;
				num = 4;
				break;
			case 2:
			case 7:
				mHighlightColor = Color.Empty;
				num = 3;
				break;
			case 1:
				idjU21Pv6hDYZK8Pcsl();
				num = 0;
				break;
			case 0:
				mColor = Color.Empty;
				c9QF4hPSfUHC0sVmmCr();
				if (!kUTwcDPELikgDYPLk82())
				{
					num = 7;
					break;
				}
				num = 8;
				if (c9QF4hPSfUHC0sVmmCr())
				{
					break;
				}
				goto case 5;
			case 3:
				CJrTDCrWeD = true;
				num = 5;
				break;
			case 9:
				UniqueId = JClb1fPHZp89xOiNqkU().ToString();
				goto case 6;
			case 5:
				v1DLK1PVQsmUVqljEjs(this);
				goto case 9;
			default:
				num = 9;
				break;
			case 4:
				mLabel = label;
				num = 10;
				break;
			case 10:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsGraphic(CvsCellLocation location, CvsCogEditingShape editingShape)
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
		goto IL_00d8;
		IL_001a:
		string text = default;
		mColor = CvsCssParser.ConvertStringToColor(text);
		num = 15;
		goto IL_00d8;
		IL_00d8:
		while (true)
		{
			switch (num)
			{
			case 7:
			case 12:
				break;
			case 14:
				mColor = klfaXcPiYKwXVJhPS0d();
				num = 3;
				continue;
			case 0:
				mColor = Color.Empty;
				num = 1;
				continue;
			case 9:
				if (!ur5PmtP2U0PG3vh1PUu(text))
				{
					break;
				}
				return;
			case 6:
				idjU21Pv6hDYZK8Pcsl();
				num = 0;
				continue;
			case 1:
				mHighlightColor = Color.Empty;
				num = 5;
				continue;
			case 3:
				if (W6bSKoPqPxaUeEWTSxf(editingShape) != null)
				{
					_ = 1;
					num = ((!kUTwcDPELikgDYPLk82()) ? 4 : 7);
					continue;
				}
				return;
			case 2:
				mLabel = (string)v42uLFPdPL69WgD5Rk4(editingShape);
				goto case 13;
			default:
				num = 13;
				continue;
			case 5:
				CJrTDCrWeD = true;
				num = 11;
				continue;
			case 13:
				LQGT2wLS9B = editingShape.Fixture;
				num = 14;
				continue;
			case 4:
			case 10:
			{
				CvsCssParser cvsCssParser = new CvsCssParser();
				vENm35PBnI2AZHnAxNU(cvsCssParser, W6bSKoPqPxaUeEWTSxf(editingShape));
				CvsStyleClass cvsStyleClass = (CvsStyleClass)mW5sYiPj4uo4EMx0y0u(cvsCssParser, p1KAWYPAGCI99Sk9k6i(33760));
				if (cvsStyleClass != null)
				{
					text = (string)yhyPmiPc0kLq8AgrrJt(cvsStyleClass, p1KAWYPAGCI99Sk9k6i(33770));
					num = 9;
					if (0 == 0)
					{
						continue;
					}
					goto case 8;
				}
				return;
			}
			case 8:
				UniqueId = JClb1fPHZp89xOiNqkU().ToString();
				mCellLocation = location;
				num = 2;
				if (kUTwcDPELikgDYPLk82())
				{
				}
				continue;
			case 11:
				v1DLK1PVQsmUVqljEjs(this);
				num = 8;
				continue;
			case 15:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FromSerializableGraphic(CvsCogShape shape)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		c9QF4hPSfUHC0sVmmCr();
		int num = (kUTwcDPELikgDYPLk82() ? 4 : 7);
		CvsCellLocation cvsCellLocation = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				mColor = vXye6sPCCnp7wI9PhJu(blRu57PtLSoYBQRBUeW(shape));
				num = 6;
				break;
			case 1:
				mLabel = (string)hLmgifPKflBwVZj4mr8(shape);
				num = 8;
				break;
			case 3:
				mCellLocation = cvsCellLocation;
				num = 2;
				if (kUTwcDPELikgDYPLk82())
				{
				}
				break;
			case 0:
			case 7:
				cvsCellLocation = apjbmBP7s6nsVwfpfZg(jTEN82PWZO008obGJQZ(shape));
				num = 9;
				break;
			case 9:
				if (!cvsCellLocation.IsValid)
				{
					goto case 2;
				}
				num = 3;
				if (0 == 0)
				{
					break;
				}
				goto case 6;
			case 6:
				if (ur5PmtP2U0PG3vh1PUu(mLabel))
				{
					goto case 1;
				}
				goto default;
			case 8:
				xJJTGT5l26 = DXSkQ0P58VbU2sprspM(shape);
				num = 10;
				break;
			default:
				if (!string.IsNullOrEmpty((string)hLmgifPKflBwVZj4mr8(shape)))
				{
					num = 1;
					break;
				}
				goto case 8;
			case 10:
				Font = ((!string.IsNullOrEmpty(mLabel)) ? new Font(shape.Font, mA8BONPotK4tgURd65I(shape)) : null);
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return mCellLocation.GetHashCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphic Clone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (CvsGraphic)((ICloneable)this).Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	object ICloneable.Clone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return o2RjqPPPgwhcGFviBQu(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetDrawOrder()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (mCellLocation.Row << 16) | ((mCellLocation.Column & 0xFF) << 8) | ZOrder;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnPropertyChanged(string propertyName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (udsTuX2IWx != null)
		{
			WxTShiPrq41sHyP4on7(udsTuX2IWx, this, new PropertyChangedEventArgs(propertyName));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetColorARGB(int color)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		int num4 = default;
		int num2 = default;
		int num3 = default;
		int num5 = default;
		do
		{
			IL_0034:
			switch (num)
			{
			case 0:
				num4 = (color >> 8) & 0xFF;
				break;
			case 5:
				Color = oUG9yfP3Awm2Yf63S40(num2, num3, num4, num5);
				num = 7;
				goto IL_0034;
			case 1:
			case 6:
				num3 = (color >> 16) & 0xFF;
				num = 0;
				goto IL_0034;
			case 4:
				num2 = (color >> 24) & 0xFF;
				c9QF4hPSfUHC0sVmmCr();
				if (kUTwcDPELikgDYPLk82())
				{
					num = 2;
					if (c9QF4hPSfUHC0sVmmCr())
					{
						goto IL_0034;
					}
					goto case 5;
				}
				num = 6;
				goto IL_0034;
			case 7:
				return;
			}
			num5 = color & 0xFF;
			num = 5;
		}
		while (c9QF4hPSfUHC0sVmmCr());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual object GetSerializableGraphic()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void CheckLock()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (RWcTCLx2Yc)
		{
			throw new InvalidOperationException((string)CBsyE9POWokQY8KWljK());
		}
	}

	internal abstract object InternalClone();

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int JYNTNq6FHF(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!kUTwcDPELikgDYPLk82())
		{
			num = 4;
		}
		else
		{
			num = 6;
			if (kUTwcDPELikgDYPLk82())
			{
				goto IL_007b;
			}
		}
		goto IL_00ed;
		IL_00ed:
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				num2 = P_0 & 7;
				num = 7;
				continue;
			case 0:
			case 4:
				NM5TS2GMMT = P_0;
				break;
			case 1:
			case 6:
				break;
			case 7:
				switch (num2)
				{
				case 4:
					CJrTDCrWeD = true;
					num = 9;
					continue;
				case 1:
				case 3:
					CJrTDCrWeD = true;
					num = 3;
					continue;
				default:
					num = 8;
					continue;
				case 2:
					break;
				}
				CJrTDCrWeD = false;
				goto case 3;
			case 8:
				do
				{
					CJrTDCrWeD = true;
					num = 10;
				}
				while (!c9QF4hPSfUHC0sVmmCr());
				continue;
			default:
				num = 5;
				continue;
			case 3:
			case 5:
			case 9:
			case 10:
				return P_0 & -9;
			}
			break;
		}
		goto IL_007b;
		IL_007b:
		EGQTefuf9h = (P_0 & 8) == 8;
		num = 2;
		goto IL_00ed;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void idjU21Pv6hDYZK8Pcsl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Guid JClb1fPHZp89xOiNqkU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Guid.NewGuid();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool c9QF4hPSfUHC0sVmmCr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kUTwcDPELikgDYPLk82()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void v1DLK1PVQsmUVqljEjs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object p1KAWYPAGCI99Sk9k6i(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KV7YyLPDNSQDrsfj9vl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphic)P_0).UniqueId;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color IuZjXdPUecxZB9Iwi0Y(int color)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsColorHelper.InSightToARGB(color);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color iWuQwaPTbqQgZc1M28y(short index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsColorHelper.GetHighlightColor(index);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object v42uLFPdPL69WgD5Rk4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingObject)P_0).Title;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color klfaXcPiYKwXVJhPS0d()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.Blue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object W6bSKoPqPxaUeEWTSxf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingObject)P_0).Style;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vENm35PBnI2AZHnAxNU(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCssParser)P_0).ParseStyleSheet((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mW5sYiPj4uo4EMx0y0u(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCssParser)P_0).GetStyle((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yhyPmiPc0kLq8AgrrJt(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsStyleClass)P_0).GetAttribute((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ur5PmtP2U0PG3vh1PUu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jTEN82PWZO008obGJQZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation apjbmBP7s6nsVwfpfZg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.TryParse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int blRu57PtLSoYBQRBUeW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape)P_0).Color;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color vXye6sPCCnp7wI9PhJu(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.FromArgb(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hLmgifPKflBwVZj4mr8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape)P_0).Label;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int DXSkQ0P58VbU2sprspM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape)P_0).GraphicId;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int mA8BONPotK4tgURd65I(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape)P_0).FontSize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object o2RjqPPPgwhcGFviBQu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphic)P_0).InternalClone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int MRvl6VPY02MYDbJlgsK(Color P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ColorTranslator.ToOle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OTg6nQPNnbL3bRDqC8B(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nfY7dmPxiOBVfMK3tSk(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object M1mVCCP1Okbut3Qs3Sv(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WxTShiPrq41sHyP4on7(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (PropertyChangedEventArgs)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color oUG9yfP3Awm2Yf63S40(int P_0, int P_1, int P_2, int P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.FromArgb(P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CBsyE9POWokQY8KWljK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CvsGraphic_Locked;
	}
}
