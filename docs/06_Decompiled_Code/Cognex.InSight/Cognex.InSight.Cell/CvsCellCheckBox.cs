using System;
using System.Runtime.CompilerServices;
using Cognex.InSight.Properties;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Cell;

[Serializable]
public sealed class CvsCellCheckBox : CvsCell, ICvsCellText
{
	private string hN5fAmeE3c;

	public override object CellValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Checked;
		}
	}

	public bool Checked
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			try
			{
				return x2BiyOFslU3Z1KfeU9J(yvshYVFwWps1yTNLKXD(CellResult));
			}
			catch (Exception)
			{
				string text = yvshYVFwWps1yTNLKXD(CellResult) as string;
				if (!zIjXKqFhgMok9V0LIMh(text))
				{
					return p8SKcUF9RFDrdiQnOhd(text, RF9agHFLrkghw8oX756(34482));
				}
				return false;
			}
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
			return hN5fAmeE3c;
		}
	}

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
			return cX5CNcFv1yS9ZG6gSqj(typeof(bool).TypeHandle);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellCheckBox()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		NUEBEFfgRmVymJJ6I2D();
		int num = (kQMM2DfZ9OF8vmq5BRj() ? 2 : 3);
		while (true)
		{
			switch (num)
			{
			case 4:
				base._002Ector();
				num = 5;
				break;
			case 1:
			case 2:
				hN5fAmeE3c = "";
				goto case 4;
			default:
				num = 4;
				break;
			case 0:
			case 3:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				goto case 1;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellCheckBox(CvsCellCheckBox cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0087;
		IL_001a:
		hN5fAmeE3c = "";
		num = 2;
		goto IL_0087;
		IL_0087:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				break;
			default:
				hN5fAmeE3c = cell.hN5fAmeE3c;
				num = 6;
				if (kQMM2DfZ9OF8vmq5BRj())
				{
				}
				continue;
			case 0:
				DITAvGfJx76Ap98g36J();
				kQMM2DfZ9OF8vmq5BRj();
				num = ((!NUEBEFfgRmVymJJ6I2D()) ? 4 : 5);
				continue;
			case 2:
				base._002Ector(cell);
				goto default;
			case 6:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellCheckBox(CvsCellLocation location, CvsCogCellResult cellResult)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		NUEBEFfgRmVymJJ6I2D();
		int num = (kQMM2DfZ9OF8vmq5BRj() ? 4 : 2);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				hN5fAmeE3c = "";
				num = 5;
				continue;
			case 5:
				base._002Ector(location, cellResult);
				break;
			default:
				num = 3;
				continue;
			case 0:
			case 2:
				DITAvGfJx76Ap98g36J();
				goto case 1;
			case 3:
				break;
			case 6:
				return;
			}
			hN5fAmeE3c = (string)JA9A6sfzNQctLkjA3Ml((CvsCogCheckBoxResult)DG7xhqf8t0oSCxUL505(cellResult));
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCellCheckBox(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		kQMM2DfZ9OF8vmq5BRj();
		int num = ((!NUEBEFfgRmVymJJ6I2D()) ? 2 : 3);
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				if (Checked)
				{
					goto case 1;
				}
				text = (string)OImB5kFSbXe3ZRbp4xQ();
				num = 5;
				continue;
			case 1:
			case 2:
				text = Resources.True;
				break;
			default:
				num = 4;
				continue;
			case 4:
			case 5:
				break;
			}
			break;
		}
		return (string)EHNj0cFEIKxH0MUYesG(hN5fAmeE3c, RF9agHFLrkghw8oX756(350), text);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NUEBEFfgRmVymJJ6I2D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kQMM2DfZ9OF8vmq5BRj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DITAvGfJx76Ap98g36J()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DG7xhqf8t0oSCxUL505(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Face;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JA9A6sfzNQctLkjA3Ml(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCheckBoxResult)P_0).Caption;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yvshYVFwWps1yTNLKXD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool x2BiyOFslU3Z1KfeU9J(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToBoolean(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zIjXKqFhgMok9V0LIMh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RF9agHFLrkghw8oX756(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool p8SKcUF9RFDrdiQnOhd(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 != (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OImB5kFSbXe3ZRbp4xQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.False;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EHNj0cFEIKxH0MUYesG(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type cX5CNcFv1yS9ZG6gSqj(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}
}
