using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal.Analysis;

public class CvsCellReference
{
	private CvsCellLocation AvUXH1puOu;

	private readonly CvsCellRange En6XKutPOq;

	private readonly bool rMqXEu7BFe;

	private readonly CellRefRange yiMXQjLVHD;

	public CvsCellLocation CellLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return AvUXH1puOu;
		}
	}

	public CvsCellRange ReferencedRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return En6XKutPOq;
		}
	}

	public bool IsCellStateReference
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rMqXEu7BFe;
		}
	}

	public CellRefRange ExpressionCellReference
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return yiMXQjLVHD;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellReference(CvsCellLocation cellLocation, CvsCellRange referencedRange, bool isCellStateReference)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Pvhr0l4Fg5F7AgZw7Tk();
		int num = (GPNNgE4msCyfbuTUi95() ? 1 : 2);
		while (true)
		{
			switch (num)
			{
			default:
				En6XKutPOq = referencedRange;
				num = 6;
				break;
			case 6:
				rMqXEu7BFe = isCellStateReference;
				num = 7;
				break;
			case 0:
			case 2:
				e8vLH64yRvlg6Tg3CR6();
				num = 4;
				break;
			case 5:
				AvUXH1puOu = cellLocation;
				goto default;
			case 4:
				xKqedH4godE3A9Atl0M(this);
				num = 5;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellReference(CvsCellLocation cellLocation, CellRefRange expressionCellReference)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!GPNNgE4msCyfbuTUi95())
		{
			num = 6;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 5;
			if (1 == 0)
			{
				return;
			}
		}
		goto IL_0066;
		IL_0026:
		AvUXH1puOu = cellLocation;
		num = 2;
		goto IL_0066;
		IL_0066:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 7:
				yiMXQjLVHD = expressionCellReference;
				num = 8;
				continue;
			case 2:
				En6XKutPOq = oSfOsP4ZmQKex4NCGKq(expressionCellReference);
				goto case 3;
			default:
				num = 3;
				continue;
			case 1:
			case 5:
				xKqedH4godE3A9Atl0M(this);
				num = 4;
				continue;
			case 3:
				rMqXEu7BFe = false;
				num = 7;
				continue;
			case 0:
			case 6:
				e8vLH64yRvlg6Tg3CR6();
				goto case 1;
			case 8:
				return;
			}
			break;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AvUXH1puOu.GetHashCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (GPNNgE4msCyfbuTUi95() ? 4 : 3);
		CvsCellReference cvsCellReference = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				if (cvsCellReference == null)
				{
					break;
				}
				goto case 2;
			case 2:
			case 4:
				if (!(nxGVZt4J13WW9lS8hE5(cvsCellReference) == CellLocation))
				{
					break;
				}
				goto case 1;
			default:
				num = 1;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 3:
				cvsCellReference = obj as CvsCellReference;
				num = 5;
				if (!GPNNgE4msCyfbuTUi95())
				{
					continue;
				}
				goto case 1;
			case 1:
				if (!ti8DhN48XrZn0Ttfpn3(cvsCellReference.ReferencedRange, ReferencedRange))
				{
					break;
				}
				num = 6;
				if (true)
				{
					continue;
				}
				goto case 6;
			case 6:
				return cvsCellReference.IsCellStateReference == IsCellStateReference;
			}
			break;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void e8vLH64yRvlg6Tg3CR6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xKqedH4godE3A9Atl0M(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Pvhr0l4Fg5F7AgZw7Tk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GPNNgE4msCyfbuTUi95()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellRange oSfOsP4ZmQKex4NCGKq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsReferenceRange)P_0).Range;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation nxGVZt4J13WW9lS8hE5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellReference)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ti8DhN48XrZn0Ttfpn3(CvsCellRange left, CvsCellRange right)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return left == right;
	}
}
