using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicText : CvsGraphic
{
	private PointF hNsM2wB8s3;

	private Color myJMye515L;

	public PointF Location
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hNsM2wB8s3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zI0gcvQOxJT2xRUv2yj();
			int num;
			if (!HdWlXoQMBFVUMENX9d8())
			{
				num = 2;
			}
			else
			{
				num = 3;
				if (HdWlXoQMBFVUMENX9d8())
				{
					goto IL_005e;
				}
			}
			goto IL_0077;
			IL_0028:
			eFJ59ZQp2aysldmdxOs(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(34080));
			num = 5;
			goto IL_0077;
			IL_005e:
			hNsM2wB8s3 = value;
			goto IL_0028;
			IL_0077:
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 0:
				case 2:
					CheckLock();
					goto IL_005e;
				case 1:
				case 3:
					goto IL_005e;
				default:
					num = 4;
					continue;
				case 5:
					return;
				}
				break;
			}
			goto IL_0028;
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
			return myJMye515L;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (HdWlXoQMBFVUMENX9d8() ? 3 : 4);
			while (true)
			{
				switch (num)
				{
				case 2:
					OnPropertyChanged((string)ukDiHDQ0DyS9eFC9xas(34974));
					num = 5;
					continue;
				case 0:
				case 4:
					CheckLock();
					goto case 1;
				case 1:
				case 3:
					myJMye515L = value;
					goto case 2;
				case 5:
					return;
				}
				num = 2;
				if (!zI0gcvQOxJT2xRUv2yj())
				{
					return;
				}
			}
		}
	}

	public bool IsPlotString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Flags & 0x10) == 16;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicText(CvsGraphicText graphic)
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
				hNsM2wB8s3 = graphic.hNsM2wB8s3;
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 3:
				base._002Ector(graphic);
				goto default;
			case 0:
				break;
			case 5:
				return;
			}
			do
			{
				oyrulCQQX3FN6v9UMNt();
				_ = 0;
				if (!zI0gcvQOxJT2xRUv2yj())
				{
					num = 4;
					continue;
				}
				num = 3;
				break;
			}
			while (1 == 0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicText(CvsCellLocation cell, PointF location, string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!HdWlXoQMBFVUMENX9d8())
		{
			num = 4;
			if (!zI0gcvQOxJT2xRUv2yj())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_0059;
		IL_003f:
		base._002Ector(cell, label);
		goto IL_0080;
		IL_0059:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			case 1:
			case 3:
				goto IL_003f;
			default:
				num = 2;
				continue;
			case 2:
				goto IL_0080;
			case 5:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		oyrulCQQX3FN6v9UMNt();
		goto IL_003f;
		IL_0080:
		hNsM2wB8s3 = location;
		num = 5;
		goto IL_0059;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicText()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		oyrulCQQX3FN6v9UMNt();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(int cellRow, int cellCol, float textRow, float textCol, string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!HdWlXoQMBFVUMENX9d8())
		{
			num = 2;
		}
		else
		{
			num = 4;
			if (1 == 0)
			{
				return;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 5:
				OnPropertyChanged(null);
				num = 7;
				break;
			case 6:
				mCellLocation = new CvsCellLocation(cellRow, cellCol);
				num = 1;
				break;
			default:
				hNsM2wB8s3 = new PointF(textCol, textRow);
				num = 5;
				break;
			case 0:
			case 2:
				CheckLock();
				num = 6;
				break;
			case 1:
				mLabel = label;
				goto default;
			case 7:
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
		return new CvsGraphicText(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetSerializableGraphic()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCogText cvsCogText = new CvsCogText();
		co5b0qQlcRtlBYA5yC4(cvsCogText, CellLocation.ToString());
		s7CTLRQe8ixjGn5v2S8(cvsCogText, Color.ToArgb());
		qyyaA4Qu7OGAcP8Vy9v(cvsCogText, Label);
		CEw4NCQITlPWl7nbdCD(cvsCogText, Location.X);
		jnAB95QRHS8X0EeWy28(cvsCogText, Location.Y);
		return cvsCogText;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogText text)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_00c8;
		IL_001a:
		base.FromSerializableGraphic(text);
		HdWlXoQMBFVUMENX9d8();
		if (zI0gcvQOxJT2xRUv2yj())
		{
			num = 5;
		}
		else
		{
			num = 3;
			if (HdWlXoQMBFVUMENX9d8())
			{
				return;
			}
		}
		goto IL_00c8;
		IL_00c8:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 4:
				myJMye515L = RMmJM1Q6IWyjDAr5Jk6(text.BackgroundColor);
				num = 7;
				if (true)
				{
					continue;
				}
				goto case 6;
			case 6:
				Font = ((!HKmFy8QnYvcD7rwJ8Rp(mLabel)) ? new Font((string)paWJdNQG4EDZIB3OkFl(text), text.FontSize) : null);
				if (i6JfMQQXwcXDcCZHSXR(text) != lquiPgQbFfYIv3Qpaea().ToArgb())
				{
					num = 4;
					if (true)
					{
						continue;
					}
					goto case 2;
				}
				return;
			case 2:
			case 3:
				mLabel = (string)tpIHU3Qa44fuRyFFTJg(text);
				goto case 6;
			default:
				num = 6;
				continue;
			case 1:
			case 5:
				hNsM2wB8s3 = new PointF((float)text.X, (float)text.Y);
				goto case 2;
			case 7:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oyrulCQQX3FN6v9UMNt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zI0gcvQOxJT2xRUv2yj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HdWlXoQMBFVUMENX9d8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void co5b0qQlcRtlBYA5yC4(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogShape)P_0).CellLocation = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void s7CTLRQe8ixjGn5v2S8(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogShape)P_0).Color = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qyyaA4Qu7OGAcP8Vy9v(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogText)P_0).Text = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CEw4NCQITlPWl7nbdCD(object P_0, double P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogText)P_0).X = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jnAB95QRHS8X0EeWy28(object P_0, double P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogText)P_0).Y = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tpIHU3Qa44fuRyFFTJg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogText)P_0).Text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HKmFy8QnYvcD7rwJ8Rp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object paWJdNQG4EDZIB3OkFl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape)P_0).Font;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int i6JfMQQXwcXDcCZHSXR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogText)P_0).BackgroundColor;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color lquiPgQbFfYIv3Qpaea()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.Transparent;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color RMmJM1Q6IWyjDAr5Jk6(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.FromArgb(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eFJ59ZQp2aysldmdxOs(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ukDiHDQ0DyS9eFC9xas(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}
}
