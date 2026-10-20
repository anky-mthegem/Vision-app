using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicArrows : CvsGraphic
{
	public struct Arrow
	{
		public PointF Location;

		public float Angle;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Arrow Create(PointF loc, float angle)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (sK6d5VsNRiMxcpjVLtRV() ? 2 : 4);
			Arrow result = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					result.Angle = angle;
					num = 5;
					if (YFbhLpsNIOGaaRaKvTS7())
					{
						break;
					}
					goto case 1;
				case 1:
				case 2:
					result.Location = loc;
					goto case 3;
				default:
					num = 3;
					break;
				case 0:
				case 4:
					result = default;
					goto case 1;
				case 5:
					return result;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Arrow Clone(Arrow org)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sK6d5VsNRiMxcpjVLtRV();
			int num;
			if (YFbhLpsNIOGaaRaKvTS7())
			{
				num = 2;
				if (!YFbhLpsNIOGaaRaKvTS7())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_005f;
				}
			}
			goto IL_007e;
			IL_007e:
			Arrow result = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 0:
				case 2:
					result = default;
					goto IL_005f;
				case 1:
				case 3:
					goto IL_005f;
				default:
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto case 5;
				case 5:
					return result;
				}
				break;
			}
			goto IL_002e;
			IL_005f:
			result.Location = org.Location;
			goto IL_002e;
			IL_002e:
			result.Angle = org.Angle;
			num = 5;
			goto IL_007e;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YFbhLpsNIOGaaRaKvTS7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sK6d5VsNRiMxcpjVLtRV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly List<Arrow> a3qBqdtGim;

	public List<Arrow> Arrows
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return a3qBqdtGim;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicArrows(CvsGraphicArrows graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!DrWoP7YX6Zkl9YL8eTA()) ? 3 : 4);
		while (true)
		{
			switch (num)
			{
			case 5:
				NWhBgxjUj4(graphic.a3qBqdtGim);
				num = 6;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
				base._002Ector(graphic);
				goto case 5;
			default:
				num = 5;
				break;
			case 1:
			case 3:
				a3qBqdtGim = new List<Arrow>();
				num = 2;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				goto case 1;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicArrows()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DrWoP7YX6Zkl9YL8eTA();
		int num;
		if (!rkahXRYbdvBnlFO7HNe())
		{
			num = 3;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_006c;
		IL_002a:
		base._002Ector();
		num = 5;
		goto IL_006c;
		IL_006c:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 0:
			case 3:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				goto case 1;
			case 1:
			case 4:
				a3qBqdtGim = new List<Arrow>();
				break;
			default:
				goto IL_0089;
			case 5:
				return;
			}
			break;
			IL_0089:
			num = 2;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NWhBgxjUj4(List<Arrow> P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		foreach (Arrow item in P_0)
		{
			a3qBqdtGim.Add(Arrow.Clone(item));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(int cellRow, int cellCol, PointF start, float angle)
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
			case 0:
				a3qBqdtGim.Add(dEuq75Y69GmkihThfg0(start, angle));
				goto default;
			case 1:
			case 5:
				mCellLocation = new CvsCellLocation(cellRow, cellCol);
				num = 0;
				continue;
			default:
				QfdFhkYpSJaJcWkiRIM(this, null);
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 2:
				break;
			case 6:
				return;
			}
			CheckLock();
			_ = 1;
			num = ((!rkahXRYbdvBnlFO7HNe()) ? 5 : 4);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicArrows(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DrWoP7YX6Zkl9YL8eTA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rkahXRYbdvBnlFO7HNe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Arrow dEuq75Y69GmkihThfg0(PointF loc, float angle)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Arrow.Create(loc, angle);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QfdFhkYpSJaJcWkiRIM(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}
}
