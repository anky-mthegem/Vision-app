using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

public sealed class CvsGraphicCheckArea : CvsGraphic
{
	private PointF tvbBUHtuAq;

	private SizeF pMgB0c4TrJ;

	private double Pq1BwsvmIl;

	private bool lOJBRxMZn2;

	public PointF Location
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tvbBUHtuAq;
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
					uwY3Q3NZTevV5bSoEN0(this, cSIG3aNgdMAQpaaLx5V(34080));
					num = 5;
					if (InuhX6NbOsmjSe3wmCv())
					{
					}
					break;
				case 1:
				case 3:
					tvbBUHtuAq = value;
					goto default;
				case 4:
					CheckLock();
					InuhX6NbOsmjSe3wmCv();
					if (!DnYf0WNXFajovq1iaVK())
					{
						num = 0;
						break;
					}
					num = 3;
					if (false)
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

	public SizeF Size
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return pMgB0c4TrJ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			InuhX6NbOsmjSe3wmCv();
			int num;
			if (DnYf0WNXFajovq1iaVK())
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_0043;
			IL_0082:
			uwY3Q3NZTevV5bSoEN0(this, cSIG3aNgdMAQpaaLx5V(34100));
			num = 5;
			goto IL_0043;
			IL_0043:
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				case 0:
				case 3:
					CheckLock();
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					goto IL_0082;
				default:
					goto IL_0082;
				case 5:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			pMgB0c4TrJ = value;
			goto IL_0082;
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
			return Pq1BwsvmIl;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!DnYf0WNXFajovq1iaVK()) ? 1 : 3);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					CheckLock();
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 4:
					Pq1BwsvmIl = value;
					break;
				case 5:
					return;
				}
				uwY3Q3NZTevV5bSoEN0(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(34112));
				num = 5;
			}
		}
	}

	public bool Pass
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return lOJBRxMZn2;
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
					if (!InuhX6NbOsmjSe3wmCv())
					{
						num = 4;
						if (0 == 0)
						{
							continue;
						}
						goto case 1;
					}
					num = 3;
					continue;
				case 1:
				case 4:
					lOJBRxMZn2 = value;
					break;
				case 5:
					return;
				}
				uwY3Q3NZTevV5bSoEN0(this, cSIG3aNgdMAQpaaLx5V(34126));
				num = 5;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicCheckArea()
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
			default:
				Pq1BwsvmIl = 0.0;
				num = 1;
				break;
			case 6:
				base._002Ector();
				_ = 0;
				if (DnYf0WNXFajovq1iaVK())
				{
					num = 5;
					break;
				}
				num = 3;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 0:
				pMgB0c4TrJ = SizeF.Empty;
				goto default;
			case 2:
			case 5:
				tvbBUHtuAq = PointF.Empty;
				num = 0;
				break;
			case 1:
				lOJBRxMZn2 = false;
				num = 8;
				break;
			case 7:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 6;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicCheckArea(CvsGraphicCheckArea checkArea)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!DnYf0WNXFajovq1iaVK())
		{
			goto IL_001e;
		}
		goto IL_00c8;
		IL_0052:
		base._002Ector(checkArea);
		goto IL_0094;
		IL_00c8:
		while (true)
		{
			IL_00c8_2:
			switch (num)
			{
			case 6:
				break;
			case 7:
				goto IL_003a;
			case 1:
			case 4:
				goto IL_0052;
			case 0:
				while (true)
				{
					eBvuebN674pAoE6sk1j();
					InuhX6NbOsmjSe3wmCv();
					if (DnYf0WNXFajovq1iaVK())
					{
						break;
					}
					num = 5;
					if (!DnYf0WNXFajovq1iaVK())
					{
						continue;
					}
					goto IL_00c8_2;
				}
				num = 4;
				if (DnYf0WNXFajovq1iaVK())
				{
					continue;
				}
				goto IL_0094;
			case 2:
			case 5:
				goto IL_0094;
			case 3:
				pMgB0c4TrJ = uHZtPXNp6j6qgnn7WBB(checkArea);
				break;
			default:
				num = 6;
				continue;
			case 8:
				return;
			}
			break;
		}
		goto IL_001e;
		IL_0094:
		tvbBUHtuAq = checkArea.Location;
		num = 3;
		goto IL_00c8;
		IL_001e:
		Pq1BwsvmIl = XArpQdN0DSaN5bAnZDg(checkArea);
		num = 7;
		if (!DnYf0WNXFajovq1iaVK())
		{
			goto IL_003a;
		}
		goto IL_00c8;
		IL_003a:
		lOJBRxMZn2 = WHj2UcN4q4grQYamwVF(checkArea);
		num = 8;
		if (1 == 0)
		{
			goto IL_0052;
		}
		goto IL_00c8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicCheckArea(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogCheckArea checkArea)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (DnYf0WNXFajovq1iaVK())
		{
			num = 3;
			if (!DnYf0WNXFajovq1iaVK())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_00a6;
		IL_002a:
		Pq1BwsvmIl = iMTfXwNmUwy9AEBIrsS(checkArea);
		num = 4;
		goto IL_00a6;
		IL_00a6:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 1:
			case 5:
				tvbBUHtuAq = new PointF((float)wx35gUNki4nXYKAQt64(checkArea), (float)GxbMsnNfQxwGksciwoG(checkArea));
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 4;
			case 4:
				lOJBRxMZn2 = e6Q4KaNyDaRcuybCXNW(checkArea);
				num = 7;
				continue;
			case 6:
				pMgB0c4TrJ = new SizeF((float)checkArea.Width, (float)nOnTR7NFF2jRnftUDph(checkArea));
				break;
			default:
				num = 2;
				continue;
			case 0:
			case 3:
				base.FromSerializableGraphic(checkArea);
				goto case 1;
			case 7:
				return;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DnYf0WNXFajovq1iaVK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool InuhX6NbOsmjSe3wmCv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eBvuebN674pAoE6sk1j()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SizeF uHZtPXNp6j6qgnn7WBB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicCheckArea)P_0).Size;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double XArpQdN0DSaN5bAnZDg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicCheckArea)P_0).Angle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WHj2UcN4q4grQYamwVF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicCheckArea)P_0).Pass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double wx35gUNki4nXYKAQt64(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCheckArea)P_0).X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double GxbMsnNfQxwGksciwoG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCheckArea)P_0).Y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double nOnTR7NFF2jRnftUDph(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCheckArea)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double iMTfXwNmUwy9AEBIrsS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCheckArea)P_0).Angle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool e6Q4KaNyDaRcuybCXNW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCheckArea)P_0).Pass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cSIG3aNgdMAQpaaLx5V(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uwY3Q3NZTevV5bSoEN0(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}
}
