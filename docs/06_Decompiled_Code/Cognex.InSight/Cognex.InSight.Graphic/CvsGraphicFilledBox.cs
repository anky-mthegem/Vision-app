using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicFilledBox : CvsGraphic
{
	private PointF liQJW0a3fn;

	private float aq1J3NFrl2;

	private float DbGJLvAETs;

	private float pVOJk22ZZC;

	private float nMHJX2eGxv;

	private Color LYGJfF0PRj;

	private Color y87Jj62Eip;

	public PointF Location
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return liQJW0a3fn;
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
			if (W0ItkkrzTinsxx4mFW1())
			{
				num = 2;
			}
			else
			{
				num = 3;
				if (!W0ItkkrzTinsxx4mFW1())
				{
					goto IL_005a;
				}
			}
			goto IL_0073;
			IL_0024:
			ofJxIa3vInHuuntlN2n(this, MOWiom3EyiR9J9JTqZt(34080));
			num = 5;
			goto IL_0073;
			IL_005a:
			liQJW0a3fn = value;
			goto IL_0024;
			IL_0073:
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 0:
				case 2:
					CheckLock();
					goto IL_005a;
				case 1:
				case 3:
					goto IL_005a;
				default:
					num = 4;
					if (kUEDex3w5YoMgQ30aH0())
					{
					}
					continue;
				case 5:
					return;
				}
				break;
			}
			goto IL_0024;
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
			return DbGJLvAETs;
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
				case 1:
				case 4:
					DbGJLvAETs = value;
					goto default;
				default:
					ofJxIa3vInHuuntlN2n(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(34428));
					num = 5;
					break;
				case 0:
					CheckLock();
					W0ItkkrzTinsxx4mFW1();
					if (kUEDex3w5YoMgQ30aH0())
					{
						num = 3;
						break;
					}
					num = 4;
					if (!W0ItkkrzTinsxx4mFW1())
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

	public float Width
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aq1J3NFrl2;
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
				case 0:
					CheckLock();
					_ = 1;
					if (!kUEDex3w5YoMgQ30aH0())
					{
						num = 3;
						if (kUEDex3w5YoMgQ30aH0())
						{
						}
					}
					else
					{
						num = 4;
					}
					continue;
				case 1:
				case 3:
					aq1J3NFrl2 = value;
					break;
				case 5:
					return;
				}
				ofJxIa3vInHuuntlN2n(this, MOWiom3EyiR9J9JTqZt(34444));
				num = 5;
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
			return pVOJk22ZZC;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kUEDex3w5YoMgQ30aH0();
			int num = ((!W0ItkkrzTinsxx4mFW1()) ? 3 : 4);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					CheckLock();
					num = 1;
					continue;
				case 1:
					pVOJk22ZZC = value;
					break;
				case 5:
					return;
				}
				OnPropertyChanged(kgbOBx7BanbFa22Hp9.ol99ukmDA(34112));
				num = 5;
			}
		}
	}

	public float Curve
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return nMHJX2eGxv;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			W0ItkkrzTinsxx4mFW1();
			int num;
			if (!kUEDex3w5YoMgQ30aH0())
			{
				num = 2;
			}
			else
			{
				num = 4;
				if (!W0ItkkrzTinsxx4mFW1())
				{
					goto IL_0044;
				}
			}
			goto IL_005d;
			IL_0084:
			ofJxIa3vInHuuntlN2n(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(34510));
			num = 5;
			goto IL_005d;
			IL_0044:
			nMHJX2eGxv = value;
			goto IL_0084;
			IL_005d:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					CheckLock();
					break;
				case 1:
				case 4:
					break;
				default:
					num = 3;
					continue;
				case 3:
					goto IL_0084;
				case 5:
					return;
				}
				break;
			}
			goto IL_0044;
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
			return LYGJfF0PRj;
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
			if (!kUEDex3w5YoMgQ30aH0())
			{
				num = 3;
				if (kUEDex3w5YoMgQ30aH0())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 2;
				if (false)
				{
					return;
				}
			}
			goto IL_0043;
			IL_006a:
			OnPropertyChanged((string)MOWiom3EyiR9J9JTqZt(34524));
			num = 5;
			goto IL_0043;
			IL_0043:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					break;
				default:
					num = 4;
					continue;
				case 4:
					goto IL_006a;
				case 0:
				case 3:
					CheckLock();
					break;
				case 5:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			LYGJfF0PRj = value;
			goto IL_006a;
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
			return y87Jj62Eip;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (!W0ItkkrzTinsxx4mFW1())
			{
				goto IL_001e;
			}
			goto IL_0051;
			IL_001e:
			ofJxIa3vInHuuntlN2n(this, MOWiom3EyiR9J9JTqZt(34556));
			num = 5;
			goto IL_0051;
			IL_0051:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					y87Jj62Eip = value;
					break;
				case 0:
					do
					{
						CheckLock();
						_ = 1;
						if (kUEDex3w5YoMgQ30aH0())
						{
							num = 4;
							continue;
						}
						num = 3;
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicFilledBox(CvsGraphicFilledBox graphic)
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
			case 9:
				y87Jj62Eip = graphic.y87Jj62Eip;
				num = 8;
				break;
			case 2:
				base._002Ector(graphic);
				num = 0;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
			case 4:
				DbGJLvAETs = graphic.DbGJLvAETs;
				goto default;
			case 6:
				NYABVd3s7mBrNjECsTe();
				num = 2;
				break;
			default:
				pVOJk22ZZC = graphic.pVOJk22ZZC;
				num = 3;
				if (0 == 0)
				{
					break;
				}
				goto case 7;
			case 7:
				aq1J3NFrl2 = graphic.aq1J3NFrl2;
				_ = 0;
				num = (W0ItkkrzTinsxx4mFW1() ? 1 : 10);
				break;
			case 0:
				liQJW0a3fn = graphic.liQJW0a3fn;
				num = 7;
				if (0 == 0)
				{
					break;
				}
				goto case 8;
			case 8:
				LYGJfF0PRj = graphic.LYGJfF0PRj;
				num = 11;
				break;
			case 3:
				nMHJX2eGxv = graphic.nMHJX2eGxv;
				num = 9;
				break;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicFilledBox()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (kUEDex3w5YoMgQ30aH0() ? 2 : 4);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				NYABVd3s7mBrNjECsTe();
				goto case 1;
			case 1:
			case 2:
				base._002Ector();
				break;
			default:
				num = 3;
				continue;
			case 3:
				break;
			case 5:
				return;
			}
			Initialize(0, 0, 0f, 0f, 1f, 1f, 0f, 0f, "");
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(int cellRow, int cellCol, float regionRow, float regionCol, float regionHeight, float regionWidth, float regionAngle, float regionCurve, string regionLabel)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		if (!W0ItkkrzTinsxx4mFW1())
		{
			goto IL_001e;
		}
		goto IL_004a;
		IL_001e:
		mLabel = regionLabel;
		num = 2;
		goto IL_004a;
		IL_004a:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 4:
			case 10:
				DbGJLvAETs = regionHeight;
				goto default;
			case 3:
				aq1J3NFrl2 = regionWidth;
				kUEDex3w5YoMgQ30aH0();
				if (!W0ItkkrzTinsxx4mFW1())
				{
					num = 6;
					continue;
				}
				num = 10;
				if (true)
				{
					continue;
				}
				goto case 9;
			case 9:
				nMHJX2eGxv = regionCurve;
				num = 0;
				continue;
			case 1:
				liQJW0a3fn = new PointF(regionCol, regionRow);
				num = 3;
				continue;
			case 7:
				CheckLock();
				num = 8;
				if (W0ItkkrzTinsxx4mFW1())
				{
					continue;
				}
				goto case 2;
			case 2:
				OnPropertyChanged(null);
				num = 11;
				continue;
			default:
				pVOJk22ZZC = regionAngle;
				num = 9;
				continue;
			case 8:
				mCellLocation = new CvsCellLocation(cellRow, cellCol);
				num = 1;
				continue;
			case 11:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogFilledBox rect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0088;
		IL_001a:
		Angle = (float)FFiVXQ3S24dRVxo8plO(rect);
		num = 7;
		if (!W0ItkkrzTinsxx4mFW1())
		{
			goto IL_0037;
		}
		goto IL_0088;
		IL_0088:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 7:
				goto IL_0037;
			case 5:
				goto IL_004c;
			case 0:
				Width = (float)vQ2nkH39AOrOC5U5ktB(rect);
				break;
			default:
				num = 3;
				if (!kUEDex3w5YoMgQ30aH0())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 6:
				Location = new PointF((float)ygL6rw3h613pOGRjX0w(rect), (float)rect.Y);
				goto case 2;
			case 2:
			case 4:
				Height = (float)fCKc7N3LdIpeMDy3NUa(rect);
				num = 0;
				continue;
			case 8:
				return;
			}
			break;
			IL_004c:
			base.FromSerializableGraphic(rect);
			_ = 1;
			num = (kUEDex3w5YoMgQ30aH0() ? 4 : 6);
		}
		goto IL_001a;
		IL_0037:
		Curve = 0f;
		num = 8;
		goto IL_0088;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicFilledBox(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NYABVd3s7mBrNjECsTe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool W0ItkkrzTinsxx4mFW1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kUEDex3w5YoMgQ30aH0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double ygL6rw3h613pOGRjX0w(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogFilledBox)P_0).X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double fCKc7N3LdIpeMDy3NUa(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogFilledBox)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double vQ2nkH39AOrOC5U5ktB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogFilledBox)P_0).Width;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double FFiVXQ3S24dRVxo8plO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogFilledBox)P_0).Angle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MOWiom3EyiR9J9JTqZt(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ofJxIa3vInHuuntlN2n(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}
}
