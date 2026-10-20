using System;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Cell;

[Serializable]
public sealed class CvsCellButton : CvsCell, ICvsCellText
{
	private string nQVfoiTcoM;

	public override bool IsEditCell
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}
	}

	public override Type DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Fmme0ofylivQUyxSIZW(typeof(CvsCellButton).TypeHandle);
		}
	}

	public override string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return nQVfoiTcoM;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellButton()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!kWwphLf4hrXnN28O993()) ? 2 : 3);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				Pdl4mCff7OI8AugpjRK();
				goto case 1;
			case 1:
			case 2:
				nQVfoiTcoM = "";
				break;
			default:
				num = 4;
				continue;
			case 4:
				break;
			case 5:
				return;
			}
			base._002Ector();
			num = 5;
			if (KJK0AKfk6p4M6OXEvFG())
			{
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellButton(CvsCellButton cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (kWwphLf4hrXnN28O993())
		{
			num = 3;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_004e;
		IL_0026:
		Pdl4mCff7OI8AugpjRK();
		num = 4;
		goto IL_004e;
		IL_004e:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				break;
			case 2:
			case 5:
				base._002Ector(cell);
				goto case 1;
			default:
				num = 1;
				continue;
			case 1:
				nQVfoiTcoM = cell.nQVfoiTcoM;
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 4;
			case 4:
				nQVfoiTcoM = "";
				goto case 2;
			case 6:
				return;
			}
			break;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellButton(CvsCellLocation location, CvsCogCellResult cellResult)
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
			case 1:
			case 4:
				nQVfoiTcoM = "";
				goto case 2;
			case 2:
			case 5:
				base._002Ector(location, cellResult);
				goto case 3;
			default:
				num = 3;
				break;
			case 3:
				nQVfoiTcoM = (string)R5t0QXfmi3jWc9hQu9S((CvsCogButtonResult)lH0UEQfF93vZ4VvBXL0(cellResult));
				num = 6;
				break;
			case 0:
				Pdl4mCff7OI8AugpjRK();
				KJK0AKfk6p4M6OXEvFG();
				num = (kWwphLf4hrXnN28O993() ? 4 : 5);
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCellButton(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return nQVfoiTcoM;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Pdl4mCff7OI8AugpjRK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kWwphLf4hrXnN28O993()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool KJK0AKfk6p4M6OXEvFG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lH0UEQfF93vZ4VvBXL0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Face;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object R5t0QXfmi3jWc9hQu9S(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogButtonResult)P_0).Caption;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type Fmme0ofylivQUyxSIZW(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}
}
