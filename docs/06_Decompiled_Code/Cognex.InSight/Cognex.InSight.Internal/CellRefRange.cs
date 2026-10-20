using System.Drawing;
using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

public sealed class CellRefRange : CvsReferenceRange
{
	private int gKRWDcUtuF;

	private int xAyWeNyl41;

	public int TextStart
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return gKRWDcUtuF;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			gKRWDcUtuF = value;
		}
	}

	public int TextEnd
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xAyWeNyl41;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xAyWeNyl41 = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CellRefRange(CvsCellRange range, int index, bool resizable, int textStart, int textEnd, bool absoluteRow, bool absoluteColumn, bool absoluteLastRow, bool absoluteLastColumn)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		aypgZNn2uGYqXdTyZdk();
		int num = ((!X39KUPnccxX67DVMCVP()) ? 1 : 5);
		while (true)
		{
			switch (num)
			{
			default:
				xAyWeNyl41 = textEnd;
				num = 6;
				continue;
			case 2:
				gKRWDcUtuF = textStart;
				goto default;
			case 0:
			case 5:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 4:
				break;
			case 6:
				return;
			}
			base._002Ector(range, Ewb0kynWqyytm7YiTdI(index), resizable, absoluteRow, absoluteColumn, absoluteLastRow, absoluteLastColumn);
			num = 2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CellRefRange(CellRefRange other)
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
				cY7ND3n7sI3BKQkSKXm();
				num = 5;
				if (aypgZNn2uGYqXdTyZdk())
				{
				}
				break;
			case 5:
				base._002Ector(other);
				X39KUPnccxX67DVMCVP();
				if (!aypgZNn2uGYqXdTyZdk())
				{
					num = 1;
					if (0 == 0)
					{
						break;
					}
					goto default;
				}
				num = 4;
				break;
			default:
				xAyWeNyl41 = N5J8WVnCwIcX5yjn8ub(other);
				num = 6;
				break;
			case 1:
			case 2:
				gKRWDcUtuF = kCrkfDntbNg9hiRB89v(other);
				goto default;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.ToString();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color Ewb0kynWqyytm7YiTdI(int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsReferenceRange.GetRangeColor(index);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool X39KUPnccxX67DVMCVP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool aypgZNn2uGYqXdTyZdk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cY7ND3n7sI3BKQkSKXm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int kCrkfDntbNg9hiRB89v(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellRefRange)P_0).TextStart;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int N5J8WVnCwIcX5yjn8ub(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellRefRange)P_0).TextEnd;
	}
}
