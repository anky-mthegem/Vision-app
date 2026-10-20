using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.Cnx.Drawing;

public struct CnxColor
{
	public int Argb;

	private static Dictionary<int, string> eqspDnnNy;

	private static Dictionary<string, int> f4ihE7FHU;

	public byte A
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (byte)(Argb >> 24);
		}
	}

	public byte R
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (byte)(Argb >> 16);
		}
	}

	public byte G
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (byte)(Argb >> 8);
		}
	}

	public byte B
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (byte)Argb;
		}
	}

	public byte Brightness
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (byte)(77 * R + 151 * G + 28 * B >> 8);
		}
	}

	public CnxColor Grayscale
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			byte brightness = Brightness;
			return new CnxColor(A, brightness, brightness, brightness);
		}
	}

	public bool IsEmpty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Argb == 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxColor(int argb)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		Argb = argb;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxColor(byte a, byte r, byte g, byte b)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EgmKi0s599d1RuoIK94();
		Argb = (a << 24) | (r << 16) | (g << 8) | b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxColor(byte r, byte g, byte b)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		Argb = -16777216 | (r << 16) | (g << 8) | b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator CnxColor(Color clr)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CnxColor(clr.ToArgb());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator Color(CnxColor clr)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.FromArgb(clr.Argb);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxColor Brighten(int step)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		m54Ip7sCJ8GshRrEVjp();
		int num;
		if (!V5aPA6sKhADDgLHh6TC())
		{
			num = 13;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 6;
			if (V5aPA6sKhADDgLHh6TC())
			{
			}
		}
		goto IL_0132;
		IL_002a:
		int b = B;
		num = 8;
		goto IL_0132;
		IL_0132:
		int r = default;
		int num4 = default;
		int g = default;
		int num5 = default;
		byte b2 = default;
		int num3 = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 9:
				r = R;
				num = 7;
				continue;
			case 3:
				num4 = b;
				num = 14;
				continue;
			case 1:
			case 6:
				return new CnxColor(Argb);
			case 8:
				num4 = r;
				if (num4 < g)
				{
					num4 = g;
					num = 11;
					continue;
				}
				goto case 11;
			case 0:
			case 13:
				if (step > 0)
				{
					num5 = step + 1;
					num = 9;
					continue;
				}
				goto case 1;
			case 5:
				if (num4 == 0)
				{
					b2 = (byte)(num3 / num5);
					num = 12;
					continue;
				}
				if (num4 < 255)
				{
					num = 4;
					continue;
				}
				return new CnxColor(A, (byte)Math.Min(255, (r + num3) / num5), (byte)bUhDyvsofVZO1PkOMdU(255, (g + num3) / num5), (byte)bUhDyvsofVZO1PkOMdU(255, (b + num3) / num5));
			case 14:
				num3 = step * 256 + num5 / 2;
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 12;
			case 12:
				return new CnxColor(A, b2, b2, b2);
			case 7:
				g = G;
				num = 2;
				if (true)
				{
					continue;
				}
				goto case 11;
			case 11:
				if (num4 < b)
				{
					goto case 3;
				}
				goto case 14;
			default:
				num = 3;
				continue;
			case 4:
				num2 = (num4 + num3) / num5;
				num = 10;
				continue;
			case 10:
				num3 = num4 / 2;
				num = 15;
				continue;
			case 15:
				return new CnxColor(A, (byte)Math.Min(255, (r * num2 + num3) / num4), (byte)Math.Min(255, (g * num2 + num3) / num4), (byte)bUhDyvsofVZO1PkOMdU(255, (b * num2 + num3) / num4));
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxColor Darken(int step)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		m54Ip7sCJ8GshRrEVjp();
		int num;
		if (!V5aPA6sKhADDgLHh6TC())
		{
			num = 3;
		}
		else
		{
			num = 2;
			if (V5aPA6sKhADDgLHh6TC())
			{
			}
		}
		int num3 = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				if (step <= 0)
				{
					goto case 1;
				}
				num3 = step + 1;
				goto case 4;
			case 1:
			case 2:
				return new CnxColor(Argb);
			default:
				num = 4;
				break;
			case 4:
				num2 = num3 / 2;
				num = 5;
				break;
			case 5:
				return new CnxColor(A, (byte)((R + num2) / num3), (byte)((G + num2) / num3), (byte)((B + num2) / num3));
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxColor Merge(CnxColor other, int step)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		V5aPA6sKhADDgLHh6TC();
		int num = ((!m54Ip7sCJ8GshRrEVjp()) ? 3 : 2);
		int num3 = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				if (step <= 0)
				{
					goto case 1;
				}
				num3 = step + 1;
				goto case 4;
			case 4:
				num2 = num3 / 2;
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
			case 3:
				return new CnxColor(other.Argb);
			default:
				num = 4;
				break;
			case 5:
				return new CnxColor((byte)((step * A + other.A + num2) / num3), (byte)((step * R + other.R + num2) / num3), (byte)((step * G + other.G + num2) / num3), (byte)((step * B + other.B + num2) / num3));
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxColor Mute(int grayness)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Grayscale.Merge(this, grayness);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)KFaj3ZsYpttyuhljm9f(fp0WJtsPmE28XqQkWx7(760), Argb.ToString((string)fp0WJtsPmE28XqQkWx7(766)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CnxColor Parse(string str)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (V5aPA6sKhADDgLHh6TC() ? 2 : 6);
		int value = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				if (f4ihE7FHU.TryGetValue(str.ToLower(), out value))
				{
					num = 7;
					if (!V5aPA6sKhADDgLHh6TC())
					{
						break;
					}
					goto case 0;
				}
				throw new InvalidCastException((string)KFaj3ZsYpttyuhljm9f(fp0WJtsPmE28XqQkWx7(774), str));
			case 0:
			case 6:
				if (str == null)
				{
					num = 3;
					break;
				}
				if (str[0] == '#')
				{
					num = 1;
					break;
				}
				goto IL_00b3;
			case 3:
				return CnxColors.Empty;
			case 5:
				pv7cMDsxJ6PUsJZqW3n();
				goto case 2;
			case 1:
				try
				{
					return new CnxColor(Convert.ToInt32((string)M7wC4dsNqDBmY2HLSKZ(str, 1), 16));
				}
				catch (OverflowException)
				{
				}
				catch (FormatException)
				{
				}
				goto IL_00b3;
			default:
				num = 5;
				break;
			case 7:
				{
					return new CnxColor(value);
				}
				IL_00b3:
				if (f4ihE7FHU != null)
				{
					goto case 2;
				}
				goto case 5;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetName(IFormatProvider formatProvider)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		m54Ip7sCJ8GshRrEVjp();
		int num;
		if (!V5aPA6sKhADDgLHh6TC())
		{
			num = 3;
			if (!m54Ip7sCJ8GshRrEVjp())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_0057;
		IL_0091:
		string value = ToString();
		num = 6;
		goto IL_0057;
		IL_00c2:
		return value;
		IL_002e:
		if (!eqspDnnNy.TryGetValue(Argb, out value))
		{
			goto IL_0091;
		}
		goto IL_00c2;
		IL_0057:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			default:
				num = 4;
				continue;
			case 1:
			case 5:
				pv7cMDsxJ6PUsJZqW3n();
				num = 2;
				continue;
			case 4:
				goto IL_0091;
			case 0:
			case 3:
				if (eqspDnnNy != null)
				{
					break;
				}
				goto case 1;
			case 6:
				goto IL_00c2;
			}
			break;
		}
		goto IL_002e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void kb1OGurLA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		V5aPA6sKhADDgLHh6TC();
		int num;
		if (m54Ip7sCJ8GshRrEVjp())
		{
			num = 2;
		}
		else
		{
			num = 3;
			if (!m54Ip7sCJ8GshRrEVjp())
			{
				goto IL_0049;
			}
		}
		Type obj = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				obj = cSubWBs14Zj4SGDK6w0(typeof(CnxColor).TypeHandle);
				break;
			case 1:
			case 3:
				break;
			default:
				num = 4;
				continue;
			case 4:
				goto IL_0080;
			}
			break;
		}
		goto IL_0049;
		IL_0080:
		bool lockTaken = default;
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			int num2 = 21;
			if (V5aPA6sKhADDgLHh6TC())
			{
				goto IL_0098;
			}
			goto IL_0301;
			IL_0098:
			int num3 = num3 + 1;
			num2 = 20;
			if (V5aPA6sKhADDgLHh6TC())
			{
				goto IL_00ae;
			}
			goto IL_0301;
			IL_00ae:
			PropertyInfo propertyInfo = default;
			Color color = (Color)M30dA0sOK90aSIvQrjI(propertyInfo, null, null);
			num2 = 15;
			goto IL_0301;
			IL_0301:
			Dictionary<int, string> dictionary2 = default;
			CnxColor cnxColor = default;
			FieldInfo fieldInfo = default;
			int num4 = default;
			string key2 = default;
			Dictionary<string, int> dictionary = default;
			string key = default;
			FieldInfo[] fields = default;
			PropertyInfo[] properties = default;
			while (true)
			{
				switch (num2)
				{
				case 6:
					break;
				case 10:
					goto IL_00ae;
				case 4:
					dictionary2.Add(cnxColor.Argb, fieldInfo.Name);
					num2 = 22;
					continue;
				case 0:
					num3 = 0;
					num2 = 12;
					continue;
				case 16:
					goto IL_00f3;
				case 7:
					dictionary2.Add(num4, propertyInfo.Name);
					num2 = 14;
					continue;
				case 14:
					key2 = (string)P4t5MjsMP1coBA8BnT3(propertyInfo.Name);
					num2 = 8;
					continue;
				case 19:
					cnxColor = (CnxColor)Y6Y7Fjsll9FLIGW0lvh(fieldInfo, null);
					if (!dictionary2.ContainsKey(cnxColor.Argb))
					{
						num2 = 4;
						continue;
					}
					goto case 22;
				case 18:
					eqspDnnNy = dictionary2;
					num2 = 23;
					if (0 == 0)
					{
						continue;
					}
					goto case 5;
				case 5:
				case 17:
					dictionary.Add(key, cnxColor.Argb);
					num2 = 6;
					continue;
				case 1:
					fields = cSubWBs14Zj4SGDK6w0(typeof(CnxColors).TypeHandle).GetFields(BindingFlags.Static | BindingFlags.Public);
					num2 = 0;
					continue;
				case 8:
					if (!dictionary.ContainsKey(key2))
					{
						dictionary.Add(key2, num4);
						num2 = 11;
						continue;
					}
					goto case 11;
				case 11:
					num3++;
					num2 = 9;
					continue;
				case 15:
					num4 = color.ToArgb();
					num2 = 3;
					continue;
				case 3:
					if (!dictionary2.ContainsKey(num4))
					{
						num2 = 7;
						if (V5aPA6sKhADDgLHh6TC())
						{
						}
						continue;
					}
					goto case 14;
				case 12:
				case 20:
					do
					{
						if (num3 < fields.Length)
						{
							fieldInfo = fields[num3];
							if (!(VpEEKUsQTW8fhMZT0MT(fieldInfo) == cSubWBs14Zj4SGDK6w0(typeof(CnxColor).TypeHandle)))
							{
								goto end_IL_0301;
							}
							num2 = 19;
							continue;
						}
						num2 = 18;
						break;
					}
					while (false);
					continue;
				case 21:
					dictionary2 = new Dictionary<int, string>();
					num2 = 16;
					if (true)
					{
						continue;
					}
					goto case 22;
				case 22:
					key = (string)P4t5MjsMP1coBA8BnT3(VU0WbRse4B9LwRtul4F(fieldInfo));
					if (dictionary.ContainsKey(key))
					{
						break;
					}
					goto case 5;
				case 2:
				case 9:
				case 13:
					if (num3 < properties.Length)
					{
						propertyInfo = properties[num3];
						if (MrUQX2s38cG3lFf2OEP(wGRWnjsrtqjkMmy52l4(propertyInfo), typeof(Color)))
						{
							num2 = 10;
							continue;
						}
						goto case 11;
					}
					goto case 1;
				default:
					num2 = 1;
					continue;
				case 23:
					{
						f4ihE7FHU = dictionary;
						return;
					}
					end_IL_0301:
					break;
				}
				break;
				IL_00f3:
				dictionary = new Dictionary<string, int>();
				properties = typeof(Color).GetProperties(BindingFlags.Static | BindingFlags.Public);
				num3 = 0;
				_ = 0;
				num2 = ((!m54Ip7sCJ8GshRrEVjp()) ? 5 : 13);
			}
			goto IL_0098;
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(obj);
			}
		}
		IL_0049:
		lockTaken = false;
		goto IL_0080;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (obj is CnxColor)
		{
			return ((CnxColor)obj).Argb == Argb;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator ==(CnxColor a, CnxColor b)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return a.Argb == b.Argb;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator !=(CnxColor a, CnxColor b)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return a.Argb != b.Argb;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Argb;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetHue()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 12;
		float num2 = default;
		float num3 = default;
		float num7 = default;
		float num8 = default;
		float num4 = default;
		float num5 = default;
		float num6 = default;
		while (true)
		{
			switch (num)
			{
			case 20:
				num2 = (num3 - num7) / num8;
				m54Ip7sCJ8GshRrEVjp();
				if (!V5aPA6sKhADDgLHh6TC())
				{
					num = 14;
					continue;
				}
				num = 10;
				if (true)
				{
					continue;
				}
				goto case 21;
			case 1:
				if (num7 > num4)
				{
					num = 7;
					if (0 == 0)
					{
						continue;
					}
					goto case 12;
				}
				goto case 11;
			case 12:
				if (R == G)
				{
					num = 15;
					continue;
				}
				goto IL_0207;
			case 19:
				num4 = num3;
				num = 0;
				continue;
			case 6:
				if (num7 < num5)
				{
					num = 8;
					continue;
				}
				goto case 18;
			case 10:
			case 17:
				num2 = 4f + (num6 - num3) / num8;
				goto case 14;
			case 14:
			case 16:
				num2 *= 60f;
				num = 4;
				continue;
			case 11:
				if (num3 > num4)
				{
					goto case 19;
				}
				goto case 0;
			default:
				num = 19;
				continue;
			case 7:
				num4 = num7;
				num = 11;
				continue;
			case 8:
				num5 = num7;
				num = 18;
				continue;
			case 2:
				if (num6 == num4)
				{
					num = 20;
					continue;
				}
				if (num3 == num4)
				{
					num2 = 2f + (num7 - num6) / num8;
				}
				else if (num7 == num4)
				{
					goto case 10;
				}
				goto case 14;
			case 15:
				if (R == B)
				{
					num = 5;
					continue;
				}
				goto IL_0207;
			case 21:
				num7 = (float)(int)B / 255f;
				num5 = num6;
				if (num3 < num5)
				{
					num = 3;
					continue;
				}
				goto case 6;
			case 3:
				num5 = num3;
				num = 6;
				continue;
			case 13:
				num2 += 360f;
				num = 22;
				continue;
			case 0:
				num8 = num4 - num5;
				num = 9;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				return 0f;
			case 18:
				num4 = num6;
				num = 1;
				continue;
			case 9:
				num2 = 0f;
				num = 2;
				continue;
			case 4:
				if (num2 < 0f)
				{
					num = 13;
					continue;
				}
				break;
			case 22:
				break;
				IL_0207:
				num6 = (float)(int)R / 255f;
				num3 = (float)(int)G / 255f;
				num = 21;
				continue;
			}
			break;
		}
		return num2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool m54Ip7sCJ8GshRrEVjp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool V5aPA6sKhADDgLHh6TC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EgmKi0s599d1RuoIK94()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int bUhDyvsofVZO1PkOMdU(int P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Min(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fp0WJtsPmE28XqQkWx7(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KFaj3ZsYpttyuhljm9f(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object M7wC4dsNqDBmY2HLSKZ(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Substring(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pv7cMDsxJ6PUsJZqW3n()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		kb1OGurLA();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type cSubWBs14Zj4SGDK6w0(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type wGRWnjsrtqjkMmy52l4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertyInfo)P_0).PropertyType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MrUQX2s38cG3lFf2OEP(Type P_0, Type P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object M30dA0sOK90aSIvQrjI(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object P4t5MjsMP1coBA8BnT3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).ToLower();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type VpEEKUsQTW8fhMZT0MT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FieldInfo)P_0).FieldType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Y6Y7Fjsll9FLIGW0lvh(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FieldInfo)P_0).GetValue(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VU0WbRse4B9LwRtul4F(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MemberInfo)P_0).Name;
	}
}
