using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.Cnx.Geometry;

public struct CnxRectangle
{
	public CnxVector2 Location;

	public CnxVector2 Size;

	public int X
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Location.X;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Location.X = value;
		}
	}

	public int Y
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Location.Y;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Location.Y = value;
		}
	}

	public int SizeX
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Size.X;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Size.X = value;
		}
	}

	public int SizeY
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Size.Y;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Size.Y = value;
		}
	}

	public int LastX
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Location.X + Size.X;
		}
	}

	public int LastY
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Location.Y + Size.Y;
		}
	}

	public CnxVector2 LastLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Location + Size;
		}
	}

	public CnxVector2 Center
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new CnxVector2((X + LastX) / 2, (Y + LastY) / 2);
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
			if (Location.IsEmpty)
			{
				return Size.IsEmpty;
			}
			return false;
		}
	}

	public bool IsZeroSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (Size.X != 0)
			{
				return Size.Y == 0;
			}
			return true;
		}
	}

	public static CnxRectangle Empty
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

	public static CnxRectangle Infinite
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new CnxRectangle(0, 0, int.MaxValue, int.MaxValue);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxRectangle(int locationX, int locationY, int sizeX, int sizeY)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!nBuqZRkBuhSfEMLCT8()) ? 5 : 6);
		while (true)
		{
			switch (num)
			{
			case 1:
				Location.X = locationX;
				num = 2;
				if (!JlF9qJfx39HY6xLxdh())
				{
					break;
				}
				goto case 2;
			case 2:
				Location.Y = locationY;
				goto default;
			case 0:
			case 6:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 1;
				break;
			default:
				Size.X = sizeX;
				num = 4;
				if (JlF9qJfx39HY6xLxdh())
				{
				}
				break;
			case 4:
				Size.Y = sizeY;
				num = 7;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxRectangle(CnxVector2 location, CnxVector2 size)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nBuqZRkBuhSfEMLCT8();
		int num = (JlF9qJfx39HY6xLxdh() ? 3 : 4);
		while (true)
		{
			switch (num)
			{
			default:
				Size = size;
				num = 5;
				break;
			case 0:
			case 4:
				ogwablF6Au2YJsEUvX();
				num = 1;
				break;
			case 1:
				Location = location;
				goto default;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxRectangle(CnxVector2 size)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nBuqZRkBuhSfEMLCT8();
		int num;
		if (!JlF9qJfx39HY6xLxdh())
		{
			num = 4;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 1;
		}
		goto IL_0064;
		IL_0046:
		Location.Y = 0;
		goto IL_009e;
		IL_0064:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 1:
			case 2:
				goto IL_0046;
			default:
				num = 5;
				continue;
			case 0:
			case 4:
				ogwablF6Au2YJsEUvX();
				num = 3;
				continue;
			case 5:
				goto IL_009e;
			case 6:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		Location.X = 0;
		goto IL_0046;
		IL_009e:
		Size = size;
		num = 6;
		if (1 == 0)
		{
			return;
		}
		goto IL_0064;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CnxRectangle FromStartEnd(int x, int y, int lastX, int lastY)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CnxRectangle(x, y, lastX - x, lastY - y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator CnxRectangle(Rectangle rect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CnxRectangle(rect.X, rect.Y, rect.Width, rect.Height);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator Rectangle(CnxRectangle rect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new Rectangle(rect.X, rect.Y, rect.SizeX, rect.SizeY);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static implicit operator RectangleF(CnxRectangle rect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new RectangleF(rect.X, rect.Y, rect.SizeX, rect.SizeY);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator ==(CnxRectangle first, CnxRectangle second)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (first.Location == second.Location)
		{
			return fSVOSqmce4E5kBGDFf(first.Size, second.Size);
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator !=(CnxRectangle first, CnxRectangle second)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return !PQplATyBGscV20JC9Y(first, second);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (obj is CnxRectangle)
		{
			return PQplATyBGscV20JC9Y(this, (CnxRectangle)obj);
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(CnxRectangle other, int delta)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (Location.Equals(other.Location, delta))
		{
			return Size.Equals(other.Size, delta);
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
		return Location.GetHashCode() ^ Size.GetHashCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)SDw77cJ9MneDE9ZNHX(new string[8]
		{
			kgbOBx7BanbFa22Hp9.ol99ukmDA(706),
			Location.X.ToString(CultureInfo.CurrentCulture),
			(string)PlngmxgC0IKd9AUFom(714),
			Location.Y.ToString(CultureInfo.CurrentCulture),
			(string)PlngmxgC0IKd9AUFom(724),
			Size.X.ToString((IFormatProvider)ph7rnQZGC1D3ZqQnVZ()),
			kgbOBx7BanbFa22Hp9.ol99ukmDA(742),
			Size.Y.ToString((IFormatProvider)ph7rnQZGC1D3ZqQnVZ())
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Contains(CnxVector2 location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (ContainsX(location.X))
		{
			return ContainsY(location.Y);
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Contains(CnxRectangle rectangle)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (JlF9qJfx39HY6xLxdh())
		{
			goto IL_001e;
		}
		goto IL_006e;
		IL_00e2:
		CnxVector2 lastLocation = default;
		if (lastLocation.X <= Location.X + Size.X)
		{
			num = 6;
			if (JlF9qJfx39HY6xLxdh())
			{
			}
			goto IL_006e;
		}
		goto IL_013b;
		IL_013b:
		return false;
		IL_0046:
		if (Location.X <= lastLocation.X)
		{
			goto IL_00e2;
		}
		goto IL_013b;
		IL_001e:
		lastLocation = rectangle.LastLocation;
		nBuqZRkBuhSfEMLCT8();
		if (!JlF9qJfx39HY6xLxdh())
		{
			num = 3;
			if (!nBuqZRkBuhSfEMLCT8())
			{
				goto IL_0046;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_006e;
		IL_006e:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 2:
			case 5:
				goto IL_0046;
			default:
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 3:
				if (Contains(rectangle.Location))
				{
					goto IL_0046;
				}
				goto IL_013b;
			case 6:
				if (Location.Y <= lastLocation.Y)
				{
					num = 7;
					if (true)
					{
						continue;
					}
					goto IL_00e2;
				}
				goto IL_013b;
			case 0:
				goto IL_00e2;
			case 7:
				return lastLocation.Y <= Location.Y + Size.Y;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Contains(int x, int y)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (ContainsX(x))
		{
			return ContainsY(y);
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsY(int y)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (Location.Y <= y)
		{
			return y < Location.Y + Size.Y;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsX(int x)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (Location.X <= x)
		{
			return x < Location.X + Size.X;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CnxRectangle Intersect(CnxRectangle a, CnxRectangle b)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		int num3 = default;
		int num5 = default;
		int num4 = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				num3 = c5iHR6zagRKPtaRf1m(a.Location.Y, b.Location.Y);
				_ = 0;
				if (nBuqZRkBuhSfEMLCT8())
				{
					num = 0;
					if (nBuqZRkBuhSfEMLCT8())
					{
						continue;
					}
					goto case 4;
				}
				num = 4;
				if (!JlF9qJfx39HY6xLxdh())
				{
					continue;
				}
				goto case 6;
			case 4:
			case 5:
				if (num5 < num3)
				{
					break;
				}
				num = 8;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 7:
				num4 = c05or38OGF3CWyrrl1(a.LastLocation.X, b.LastLocation.X);
				num = 2;
				continue;
			case 0:
			case 3:
				num5 = c05or38OGF3CWyrrl1(a.LastLocation.Y, b.LastLocation.Y);
				goto case 1;
			default:
				num = 1;
				continue;
			case 1:
				if (num4 < num2)
				{
					break;
				}
				goto case 4;
			case 6:
				num2 = Math.Max(a.Location.X, b.Location.X);
				num = 7;
				continue;
			case 8:
				return new CnxRectangle(num2, num3, num4 - num2, num5 - num3);
			}
			break;
		}
		return qLYvOqswG1c2AJ5Qq6E();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CnxRectangle Union(CnxRectangle a, CnxRectangle b)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		int num4 = default;
		int num5 = default;
		int num2 = default;
		int num3 = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				num4 = c5iHR6zagRKPtaRf1m(c5iHR6zagRKPtaRf1m(a.Location.X, a.LastLocation.X), Math.Max(b.Location.X, b.LastLocation.X));
				goto default;
			default:
				num5 = Math.Max(c5iHR6zagRKPtaRf1m(a.Location.Y, a.LastLocation.Y), c5iHR6zagRKPtaRf1m(b.Location.Y, b.LastLocation.Y));
				num = 6;
				break;
			case 1:
				num2 = c05or38OGF3CWyrrl1(Math.Min(a.Location.X, a.LastLocation.X), c05or38OGF3CWyrrl1(b.Location.X, b.LastLocation.X));
				num = 4;
				break;
			case 4:
				num3 = c05or38OGF3CWyrrl1(c05or38OGF3CWyrrl1(a.Location.Y, a.LastLocation.Y), c05or38OGF3CWyrrl1(b.Location.Y, b.LastLocation.Y));
				_ = 0;
				num = ((!nBuqZRkBuhSfEMLCT8()) ? 5 : 0);
				break;
			case 6:
				return new CnxRectangle(num2, num3, num4 - num2, num5 - num3);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CnxRectangle[] Subtract(CnxRectangle a, CnxRectangle b)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		CnxRectangle cnxRectangle = default;
		CnxRectangle[] array2 = default;
		int num2 = default;
		CnxRectangle[] array = default;
		while (true)
		{
			switch (num)
			{
			case 12:
				return null;
			case 11:
				if (a.LastLocation.Y > cnxRectangle.LastLocation.Y)
				{
					array2[num2++] = new CnxRectangle(a.Location.X, cnxRectangle.LastLocation.Y, a.Size.X, a.LastLocation.Y - cnxRectangle.LastLocation.Y);
					num = 10;
					if (true)
					{
						continue;
					}
					goto case 15;
				}
				goto case 10;
			case 15:
				if (a.LastLocation.X <= cnxRectangle.LastLocation.X)
				{
					goto case 11;
				}
				goto default;
			case 0:
			case 1:
				if (cnxRectangle.IsEmpty)
				{
					return new CnxRectangle[1] { a };
				}
				if (cnxRectangle == a)
				{
					num = 3;
					continue;
				}
				array2 = new CnxRectangle[4];
				num = 13;
				continue;
			case 6:
				array2[num2++] = new CnxRectangle(a.Location.X, cnxRectangle.Location.Y, cnxRectangle.Location.X - a.Location.X, cnxRectangle.Size.Y);
				num = 15;
				continue;
			case 2:
				return array2;
			default:
				array2[num2++] = new CnxRectangle(cnxRectangle.LastLocation.X, cnxRectangle.Location.Y, a.LastLocation.X - cnxRectangle.LastLocation.X, cnxRectangle.Size.Y);
				num = 11;
				continue;
			case 10:
				if (num2 != 0)
				{
					if (num2 == 4)
					{
						num = 2;
						continue;
					}
					array = new CnxRectangle[num2];
					num = 9;
					continue;
				}
				num = 12;
				if (nBuqZRkBuhSfEMLCT8())
				{
					continue;
				}
				goto case 7;
			case 7:
				if (cnxRectangle.Location.Y > a.Location.Y)
				{
					array2[num2++] = new CnxRectangle(a.Location.X, a.Location.Y, a.Size.X, cnxRectangle.Location.Y - a.Location.Y);
					num = 14;
					continue;
				}
				goto case 14;
			case 9:
				TKiPHMsh4fh5NXexGSg(array2, 0, array, 0, num2);
				num = 16;
				continue;
			case 3:
				return null;
			case 14:
				if (cnxRectangle.Location.X > a.Location.X)
				{
					num = 6;
					continue;
				}
				goto case 15;
			case 13:
				num2 = 0;
				num = 7;
				continue;
			case 5:
				cnxRectangle = eNmsE3ssIRc8sWe0Obd(a, b);
				_ = 0;
				if (!nBuqZRkBuhSfEMLCT8())
				{
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				}
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 16:
				break;
			}
			break;
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Grow(int delta)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nBuqZRkBuhSfEMLCT8();
		int num = (JlF9qJfx39HY6xLxdh() ? 6 : 8);
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				SizeX += num2;
				num = 3;
				if (JlF9qJfx39HY6xLxdh())
				{
				}
				break;
			case 4:
				return false;
			default:
				num = 5;
				break;
			case 0:
			case 8:
				num2 = 2 * delta;
				goto case 1;
			case 3:
				SizeY += num2;
				num = 9;
				break;
			case 2:
				if (SizeY + num2 >= 0)
				{
					X -= delta;
					goto case 5;
				}
				num = 4;
				break;
			case 5:
				Y -= delta;
				num = 7;
				break;
			case 1:
			case 6:
				if (SizeX + num2 >= 0)
				{
					num = 2;
					break;
				}
				goto case 4;
			case 9:
				return true;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Shrink(int delta)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Grow(-delta);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxVector2 Confine(CnxVector2 point)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CnxVector2(c5iHR6zagRKPtaRf1m(X, c05or38OGF3CWyrrl1(LastX, point.X)), c5iHR6zagRKPtaRf1m(Y, c05or38OGF3CWyrrl1(LastY, point.Y)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nBuqZRkBuhSfEMLCT8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JlF9qJfx39HY6xLxdh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ogwablF6Au2YJsEUvX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fSVOSqmce4E5kBGDFf(CnxVector2 first, CnxVector2 second)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return first == second;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PQplATyBGscV20JC9Y(CnxRectangle first, CnxRectangle second)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return first == second;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PlngmxgC0IKd9AUFom(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ph7rnQZGC1D3ZqQnVZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.CurrentCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SDw77cJ9MneDE9ZNHX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Concat((string[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int c05or38OGF3CWyrrl1(int P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Min(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int c5iHR6zagRKPtaRf1m(int P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Max(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CnxRectangle qLYvOqswG1c2AJ5Qq6E()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Empty;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CnxRectangle eNmsE3ssIRc8sWe0Obd(CnxRectangle a, CnxRectangle b)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Intersect(a, b);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TKiPHMsh4fh5NXexGSg(object P_0, int P_1, object P_2, int P_3, int P_4)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Array.Copy((Array)P_0, P_1, (Array)P_2, P_3, P_4);
	}
}
