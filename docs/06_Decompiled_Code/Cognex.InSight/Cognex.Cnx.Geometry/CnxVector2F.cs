using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.Cnx.Geometry;

public struct CnxVector2F
{
	public float X;

	public float Y;

	public static CnxVector2F Empty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return default;
		}
	}

	public static CnxVector2F Invalid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new CnxVector2F(float.NaN, float.NaN);
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
			if (X == 0f)
			{
				return Y == 0f;
			}
			return false;
		}
	}

	public bool IsInvalid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (!O0FdrYsjRMDZDw78jHr(X))
			{
				return O0FdrYsjRMDZDw78jHr(Y);
			}
			return true;
		}
	}

	public float Length
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (X != 0f)
			{
				if (Y != 0f)
				{
					return (float)Yl8CUoscUdwMD1lQIsC(X * X + Y * Y);
				}
				return uWCaC2sdNmbV77ik5bj(X);
			}
			return Math.Abs(Y);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxVector2F(float x, float y)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!wmboGMsDbNct7JDe0PX()) ? 4 : 3);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				X = x;
				break;
			default:
				num = 2;
				continue;
			case 2:
				break;
			case 0:
			case 3:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				goto case 1;
			case 5:
				return;
			}
			Y = y;
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator CnxVector2F(CnxVector2 vect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CnxVector2F(vect.X, vect.Y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator CnxVector2F(Point vect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CnxVector2F(vect.X, vect.Y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator CnxVector2F(PointF vect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CnxVector2F(vect.X, vect.Y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator PointF(CnxVector2F vect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new PointF(vect.X, vect.Y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator CnxVector2F(Size vect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CnxVector2F(vect.Width, vect.Height);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator CnxVector2F(SizeF vect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CnxVector2F(vect.Width, vect.Height);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator SizeF(CnxVector2F vect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new SizeF(vect.X, vect.Y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CnxVector2F operator +(CnxVector2F first, CnxVector2F second)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CnxVector2F(first.X + second.X, first.Y + second.Y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CnxVector2F operator -(CnxVector2F first, CnxVector2F second)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CnxVector2F(first.X - second.X, first.Y - second.Y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CnxVector2F operator *(CnxVector2F first, float second)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CnxVector2F(first.X * second, first.Y * second);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CnxVector2F operator /(CnxVector2F first, float second)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CnxVector2F(first.X / second, first.Y / second);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator ==(CnxVector2F first, CnxVector2F second)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (first.X == second.X)
		{
			return first.Y == second.Y;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator !=(CnxVector2F first, CnxVector2F second)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return !ObAgvBsT0oimvZf6094(first, second);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (obj is CnxVector2F)
		{
			return ObAgvBsT0oimvZf6094(this, (CnxVector2F)obj);
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(CnxVector2F other, float delta)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (uWCaC2sdNmbV77ik5bj(X - other.X) <= delta)
		{
			return uWCaC2sdNmbV77ik5bj(Y - other.Y) <= delta;
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
		return X.GetHashCode() ^ Y.GetHashCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)ycZ0xXsB620uN9Buguo(kgbOBx7BanbFa22Hp9.ol99ukmDA(706), X.ToString((IFormatProvider)NJhH6FsiTjP9EhN8CeL()), RQUjyEsqOy2Iaf0e5lF(714), Y.ToString((IFormatProvider)NJhH6FsiTjP9EhN8CeL()));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxVector2F Normalize()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		float length = Length;
		if (!(length <= 0f))
		{
			return e8MkHhs2yI0dcogjJ4x(this, length);
		}
		return Biv97RsWLYWnBQQv9bx();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxVector2 Ceiling()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CnxVector2((int)bMDPv1s7OwZV7UldJLa(X), (int)Math.Ceiling(Y));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxVector2 Floor()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CnxVector2((int)geYhsQst6lGG90DEVTZ(X), (int)geYhsQst6lGG90DEVTZ(Y));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxVector2 Round()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1 - (int)X;
		int num2 = 1 - (int)Y;
		return new CnxVector2((int)(X + 0.5f + (float)num) - num, (int)(Y + 0.5f + (float)num2) - num2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float Dot(CnxVector2F other)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return X * other.X + Y * other.Y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CnxVector2[] Round(CnxVector2F[] vectors)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		int num2 = default;
		CnxVector2[] array = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
			case 6:
				if (num2 >= vectors.Length)
				{
					num = 7;
					break;
				}
				array[num2] = vectors[num2].Round();
				goto default;
			case 0:
				num2 = 0;
				num = 6;
				break;
			case 5:
				array = new CnxVector2[vectors.Length];
				num = 0;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
			case 3:
				num2++;
				goto case 1;
			default:
				_ = 0;
				num = ((!wmboGMsDbNct7JDe0PX()) ? 1 : 2);
				break;
			case 7:
				return array;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wmboGMsDbNct7JDe0PX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool F1WbLBsUy7eKEltCGTc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ObAgvBsT0oimvZf6094(CnxVector2F first, CnxVector2F second)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return first == second;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float uWCaC2sdNmbV77ik5bj(float P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Abs(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NJhH6FsiTjP9EhN8CeL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.CurrentCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RQUjyEsqOy2Iaf0e5lF(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ycZ0xXsB620uN9Buguo(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool O0FdrYsjRMDZDw78jHr(float P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return float.IsNaN(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double Yl8CUoscUdwMD1lQIsC(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Sqrt(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CnxVector2F e8MkHhs2yI0dcogjJ4x(CnxVector2F first, float second)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return first / second;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CnxVector2 Biv97RsWLYWnBQQv9bx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CnxVector2.Empty;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double bMDPv1s7OwZV7UldJLa(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Ceiling(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double geYhsQst6lGG90DEVTZ(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Floor(P_0);
	}
}
