using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cognex.InSight.Properties;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

internal sealed class CvsCompositeShapeTypeConverter : EnumConverter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCompositeShapeTypeConverter()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		u7aP8oxmvRlC6GKtc72(this, typeof(CvsCompositeShapeType));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 7:
				return CvsCompositeShapeType.AnnulusType;
			case 5:
				if (text != null)
				{
					num = 6;
					continue;
				}
				break;
			case 2:
				text = value as string;
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 6;
			case 6:
				if (!(text == (string)YQ425ZxySciimUQ3PBe()))
				{
					if (SawpGtxZfDmRX6EkyjZ(text, vaTV3kxgyevkOkxDtYY()))
					{
						goto default;
					}
					if (!(text == (string)fZQqKKxJ8XqFjhKSihP()))
					{
						if (SawpGtxZfDmRX6EkyjZ(text, Resources.CompositeShapeType_Region))
						{
							num = 8;
							if (w0Mh2oxFInxr2N1jCmA())
							{
							}
							continue;
						}
						break;
					}
					num = 1;
					continue;
				}
				_ = 0;
				if (!I75fjmxfSbq7V728Yeb())
				{
					num = 0;
					continue;
				}
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
				return CvsCompositeShapeType.PolygonType;
			default:
				return CvsCompositeShapeType.CircleType;
			case 8:
				return CvsCompositeShapeType.RegionType;
			}
			break;
		}
		return T8yriqx8wn3An414OEI(this, context, culture, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		CvsCompositeShapeType cvsCompositeShapeType = default;
		CvsCompositeShapeType cvsCompositeShapeType2 = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				if (value is CvsCompositeShapeType)
				{
					num = 0;
					continue;
				}
				return AhD5qb1w27e72XkmQNE(this, context, culture, value, destinationType);
			case 1:
			case 2:
				switch (cvsCompositeShapeType)
				{
				case CvsCompositeShapeType.AnnulusType:
					return YQ425ZxySciimUQ3PBe();
				case CvsCompositeShapeType.CircleType:
					return Resources.CompositeShapeType_Circle;
				case CvsCompositeShapeType.PolygonType:
					return fZQqKKxJ8XqFjhKSihP();
				case CvsCompositeShapeType.RegionType:
					return aAbnhBxzIAqWSAA4Mmp();
				}
				goto default;
			case 0:
				do
				{
					cvsCompositeShapeType = (CvsCompositeShapeType)value;
					_ = 1;
					if (w0Mh2oxFInxr2N1jCmA())
					{
						num = 5;
						continue;
					}
					num = 1;
					break;
				}
				while (w0Mh2oxFInxr2N1jCmA());
				continue;
			default:
				cvsCompositeShapeType2 = CvsCompositeShapeType.None;
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 6:
				break;
			}
			break;
		}
		return cvsCompositeShapeType2.ToString();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void u7aP8oxmvRlC6GKtc72(object P_0, Type P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EnumConverter)P_0)._002Ector(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool I75fjmxfSbq7V728Yeb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool w0Mh2oxFInxr2N1jCmA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YQ425ZxySciimUQ3PBe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CompositeShapeType_Annulus;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vaTV3kxgyevkOkxDtYY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CompositeShapeType_Circle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SawpGtxZfDmRX6EkyjZ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fZQqKKxJ8XqFjhKSihP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CompositeShapeType_Polygon;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object T8yriqx8wn3An414OEI(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EnumConverter)P_0).ConvertFrom((ITypeDescriptorContext)P_1, (CultureInfo)P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aAbnhBxzIAqWSAA4Mmp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CompositeShapeType_Region;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AhD5qb1w27e72XkmQNE(object P_0, object P_1, object P_2, object P_3, Type P_4)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EnumConverter)P_0).ConvertTo((ITypeDescriptorContext)P_1, (CultureInfo)P_2, P_3, P_4);
	}
}
