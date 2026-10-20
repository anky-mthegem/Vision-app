using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Cognex.Cnx.Imaging;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

public class CvsDefaultImageConfiguration : ICvsImageConfigurationSource, INotifyPropertyChanged
{
	private CnxPixelFormat QZ8kn3ocEw;

	private CnxPixelFormat Wcuk9DgeUs;

	private CnxPixelFormat zGIkUmLcL1;

	[CompilerGenerated]
	private PropertyChangedEventHandler fXrk0UaX6b;

	public CnxPixelFormat ImageRenderFormat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return QZ8kn3ocEw;
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
			if (!DRB2Zi6dgDAeankWw4u())
			{
				num = 1;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_003f;
			IL_006c:
			AMvSb96cCaySr92K2mq(this, ASMG9w6jqwrl0i7RArB(43168));
			num = 5;
			if (hvymd76TZB7Ut1Blgei())
			{
				goto IL_003f;
			}
			goto IL_008c;
			IL_003f:
			switch (num)
			{
			case 3:
				break;
			default:
				goto IL_006c;
			case 0:
			case 1:
				goto IL_008c;
			case 5:
				return;
			}
			goto IL_0026;
			IL_0026:
			QZ8kn3ocEw = value;
			goto IL_006c;
			IL_008c:
			if (QZ8kn3ocEw != value)
			{
				num = 3;
				if (false)
				{
					return;
				}
				goto IL_003f;
			}
		}
	}

	public CnxPixelFormat ImageUIFormat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zGIkUmLcL1;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!hvymd76TZB7Ut1Blgei()) ? 3 : 2);
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					zGIkUmLcL1 = value;
					goto case 4;
				default:
					num = 4;
					break;
				case 0:
				case 2:
					if (zGIkUmLcL1 != value)
					{
						goto case 1;
					}
					return;
				case 4:
					OnPropertyChanged((string)ASMG9w6jqwrl0i7RArB(43206));
					num = 5;
					break;
				case 5:
					return;
				}
			}
		}
	}

	public CnxPixelFormat ImageConvertFormat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Wcuk9DgeUs;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (DRB2Zi6dgDAeankWw4u())
			{
				goto IL_001e;
			}
			goto IL_005d;
			IL_001e:
			if (Wcuk9DgeUs != value)
			{
				DRB2Zi6dgDAeankWw4u();
				num = ((!hvymd76TZB7Ut1Blgei()) ? 3 : 4);
				goto IL_005d;
			}
			return;
			IL_005d:
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 1:
				case 4:
					Wcuk9DgeUs = value;
					goto IL_008a;
				default:
					goto IL_008a;
				case 5:
					return;
				}
				break;
				IL_008a:
				AMvSb96cCaySr92K2mq(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(43236));
				num = 5;
				if (false)
				{
					return;
				}
			}
			goto IL_001e;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			PropertyChangedEventHandler value2 = default;
			PropertyChangedEventHandler propertyChangedEventHandler2 = default;
			PropertyChangedEventHandler propertyChangedEventHandler = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					value2 = (PropertyChangedEventHandler)rOet86624FPkMbqPV2J(propertyChangedEventHandler2, value);
					goto default;
				case 6:
					if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						num = 7;
						if (DRB2Zi6dgDAeankWw4u())
						{
						}
						break;
					}
					goto case 0;
				case 0:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					_ = 0;
					if (!hvymd76TZB7Ut1Blgei())
					{
						num = 4;
						if (true)
						{
							break;
						}
						goto case 6;
					}
					num = 5;
					break;
				default:
					propertyChangedEventHandler = Interlocked.CompareExchange(ref fXrk0UaX6b, value2, propertyChangedEventHandler2);
					num = 6;
					break;
				case 1:
					propertyChangedEventHandler = fXrk0UaX6b;
					num = 0;
					break;
				case 7:
					return;
				}
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hvymd76TZB7Ut1Blgei();
			int num = (DRB2Zi6dgDAeankWw4u() ? 2 : 4);
			PropertyChangedEventHandler propertyChangedEventHandler = default;
			PropertyChangedEventHandler propertyChangedEventHandler2 = default;
			PropertyChangedEventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						num = 7;
						continue;
					}
					goto case 5;
				case 1:
					value2 = (PropertyChangedEventHandler)qUBcZm6WIxPbyp6hMgr(propertyChangedEventHandler2, value);
					break;
				case 5:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					num = 1;
					continue;
				case 0:
				case 4:
					propertyChangedEventHandler = fXrk0UaX6b;
					num = 5;
					if (!DRB2Zi6dgDAeankWw4u())
					{
						continue;
					}
					break;
				case 7:
					return;
				}
				propertyChangedEventHandler = Interlocked.CompareExchange(ref fXrk0UaX6b, value2, propertyChangedEventHandler2);
				num = 6;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsDefaultImageConfiguration()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				return;
			case 9:
				return;
			case 12:
				if (num2 <= 16)
				{
					num = 4;
					break;
				}
				if (num2 == 24)
				{
					zGIkUmLcL1 = (QZ8kn3ocEw = (Wcuk9DgeUs = CnxPixelFormat.Format24bppRgb));
					return;
				}
				goto default;
			case 11:
				if (num2 != 16)
				{
					num = 8;
					break;
				}
				zGIkUmLcL1 = (QZ8kn3ocEw = (Wcuk9DgeUs = CnxPixelFormat.Format16bppRgb565));
				return;
			case 5:
				base._002Ector();
				num2 = WJmrK96BEpCxFYfXUl8(yhMIR86q6rHCWkXDsYL());
				num = 12;
				break;
			case 6:
			case 10:
				if (num2 == 32)
				{
					zGIkUmLcL1 = (QZ8kn3ocEw = (Wcuk9DgeUs = CnxPixelFormat.Format32bppRgb));
					num = 7;
					break;
				}
				num = 2;
				if (DRB2Zi6dgDAeankWw4u())
				{
					return;
				}
				break;
			case 7:
				return;
			case 2:
			case 8:
				zGIkUmLcL1 = (QZ8kn3ocEw = (Wcuk9DgeUs = CnxPixelFormat.Format16bppRgb565));
				num = 13;
				break;
			case 1:
				JockEg6ie5Wy3RpBQ1A();
				num = 5;
				break;
			case 4:
				if (num2 == 1)
				{
					zGIkUmLcL1 = (QZ8kn3ocEw = (Wcuk9DgeUs = CnxPixelFormat.Format1bppMonochrome));
					num = 3;
				}
				else
				{
					num = 11;
				}
				break;
			default:
				hvymd76TZB7Ut1Blgei();
				if (!DRB2Zi6dgDAeankWw4u())
				{
					num = 10;
					break;
				}
				num = 0;
				if (!DRB2Zi6dgDAeankWw4u())
				{
					break;
				}
				return;
			case 3:
				return;
			case 13:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnPropertyChanged(string propertyName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (fXrk0UaX6b != null)
		{
			ikFVoX678X5eNHqPTtH(fXrk0UaX6b, this, new PropertyChangedEventArgs(propertyName));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JockEg6ie5Wy3RpBQ1A()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yhMIR86q6rHCWkXDsYL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Screen.PrimaryScreen;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int WJmrK96BEpCxFYfXUl8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Screen)P_0).BitsPerPixel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hvymd76TZB7Ut1Blgei()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DRB2Zi6dgDAeankWw4u()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ASMG9w6jqwrl0i7RArB(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AMvSb96cCaySr92K2mq(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsDefaultImageConfiguration)P_0).OnPropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rOet86624FPkMbqPV2J(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qUBcZm6WIxPbyp6hMgr(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ikFVoX678X5eNHqPTtH(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (PropertyChangedEventArgs)P_2);
	}
}
