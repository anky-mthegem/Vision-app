using System;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Cell;

[Serializable]
public sealed class CvsCellEditString : CvsCell
{
	private int N0mf5orqFF;

	private readonly bool diCfYeuHdZ;

	public override object CellValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return g81OHYmwll3lnDIDO7T(this);
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
			return x2gSWZmsAkKI1Z0Uh7v(CellResult) as string;
		}
	}

	public int MaxChars
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return N0mf5orqFF;
		}
	}

	public override bool IsEditPassword
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return diCfYeuHdZ;
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
			return M3b8NXmhamT0wVnqCXK(typeof(string).TypeHandle);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellEditString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				diCfYeuHdZ = true;
				goto default;
			default:
				base._002Ector();
				num = 5;
				break;
			case 4:
				BfxDbfF86ufvxsp6YII();
				PTGJ0qFJOYU8TgR23nv();
				num = (NA4JbRFZxivAIJtFp8L() ? 3 : 0);
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellEditString(CvsCellEditString cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		while (true)
		{
			switch (num)
			{
			case 5:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				_ = 0;
				num = (NA4JbRFZxivAIJtFp8L() ? 6 : 0);
				break;
			case 3:
				N0mf5orqFF = cell.N0mf5orqFF;
				num = 4;
				break;
			case 0:
			case 2:
				base._002Ector(cell);
				goto case 3;
			default:
				num = 3;
				break;
			case 4:
				diCfYeuHdZ = cell.diCfYeuHdZ;
				num = 7;
				break;
			case 1:
			case 6:
				diCfYeuHdZ = true;
				goto case 0;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellEditString(CvsCellLocation location, CvsCogCellResult cellResult)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		CvsCogEditStringResult cvsCogEditStringResult = default;
		do
		{
			IL_0048:
			switch (num)
			{
			case 0:
				base._002Ector(location, cellResult);
				num = 3;
				goto IL_0048;
			case 3:
				cvsCogEditStringResult = (CvsCogEditStringResult)cellResult.Face;
				goto default;
			case 1:
			case 5:
				diCfYeuHdZ = true;
				num = 0;
				if (PTGJ0qFJOYU8TgR23nv())
				{
				}
				goto IL_0048;
			default:
				N0mf5orqFF = cvsCogEditStringResult.MaxLength;
				num = 7;
				if (true)
				{
					goto IL_0048;
				}
				goto case 2;
			case 2:
				BfxDbfF86ufvxsp6YII();
				_ = 1;
				if (PTGJ0qFJOYU8TgR23nv())
				{
					num = 6;
					if (NA4JbRFZxivAIJtFp8L())
					{
						goto IL_0048;
					}
					goto case 1;
				}
				num = 5;
				if (true)
				{
					goto IL_0048;
				}
				break;
			case 7:
				break;
			case 8:
				return;
			}
			diCfYeuHdZ = w3rGXYFzMsLh8YkaKE3(cvsCogEditStringResult);
			num = 8;
		}
		while (true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCellEditString(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)g81OHYmwll3lnDIDO7T(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BfxDbfF86ufvxsp6YII()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NA4JbRFZxivAIJtFp8L()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PTGJ0qFJOYU8TgR23nv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool w3rGXYFzMsLh8YkaKE3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditStringResult)P_0).MaskInput;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object g81OHYmwll3lnDIDO7T(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object x2gSWZmsAkKI1Z0Uh7v(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type M3b8NXmhamT0wVnqCXK(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}
}
