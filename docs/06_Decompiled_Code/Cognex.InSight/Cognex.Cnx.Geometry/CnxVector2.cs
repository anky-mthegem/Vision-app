using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.Cnx.Geometry;

public struct CnxVector2
{
	public int X;

	public int Y;

	public static CnxVector2 Empty
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

	public bool IsEmpty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if ((float)X == 0f)
			{
				return (float)Y == 0f;
			}
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxVector2(int x, int y)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qu5u5fs9AOmY71pqWLg();
		int num = ((!D4eaUcsLQZLPOR22GJy()) ? 1 : 3);
		while (true)
		{
			switch (num)
			{
			default:
				Y = y;
				num = 5;
				break;
			case 4:
				X = x;
				goto default;
			case 0:
			case 3:
				yU0oLDsSYfmQDL2jh4Q();
				num = 4;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator CnxVector2(Point vect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CnxVector2(vect.X, vect.Y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator Point(CnxVector2 vect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new Point(vect.X, vect.Y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator PointF(CnxVector2 vect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new PointF(vect.X, vect.Y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator CnxVector2(Size vect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CnxVector2(vect.Width, vect.Height);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator Size(CnxVector2 vect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new Size(vect.X, vect.Y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator SizeF(CnxVector2 vect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new SizeF(vect.X, vect.Y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CnxVector2 operator +(CnxVector2 first, CnxVector2 second)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CnxVector2(first.X + second.X, first.Y + second.Y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CnxVector2 operator -(CnxVector2 first, CnxVector2 second)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CnxVector2(first.X - second.X, first.Y - second.Y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CnxVector2 operator *(CnxVector2 first, int second)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CnxVector2(first.X * second, first.Y * second);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator ==(CnxVector2 first, CnxVector2 second)
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
	public static bool operator !=(CnxVector2 first, CnxVector2 second)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return !aoIi4GsE0JVeKi2Ac8M(first, second);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (obj is CnxVector2)
		{
			return this == (CnxVector2)obj;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(CnxVector2 other, int delta)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (xapg8UsvolaodH0Xoi9(X - other.X) <= delta)
		{
			return xapg8UsvolaodH0Xoi9(Y - other.Y) <= delta;
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
		return (string)kC6X77sAwRZvhebs2Go(Sg90fIsHocWtkbNdN5q(706), X.ToString((IFormatProvider)nXclOUsVj5VuXOKZMgu()), Sg90fIsHocWtkbNdN5q(714), Y.ToString(CultureInfo.CurrentCulture));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yU0oLDsSYfmQDL2jh4Q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool D4eaUcsLQZLPOR22GJy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qu5u5fs9AOmY71pqWLg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool aoIi4GsE0JVeKi2Ac8M(CnxVector2 first, CnxVector2 second)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return first == second;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int xapg8UsvolaodH0Xoi9(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Abs(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Sg90fIsHocWtkbNdN5q(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nXclOUsVj5VuXOKZMgu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.CurrentCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kC6X77sAwRZvhebs2Go(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}
}
