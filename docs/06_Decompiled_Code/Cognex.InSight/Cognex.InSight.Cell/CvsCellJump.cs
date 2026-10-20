using System;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Cell;

[Serializable]
public sealed class CvsCellJump : CvsCell, ICvsCellText
{
	private string U5kf7ue4Bn;

	private string aYXfmANTG4;

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
			return PxkP6mm1XjeHSJoYyKR(typeof(CvsCellJump).TypeHandle);
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
			return U5kf7ue4Bn;
		}
	}

	public string DestCellLoc
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aYXfmANTG4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellJump()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (gK4Hfnmo8E7wKrii868())
		{
			num = 1;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_0082;
		IL_0026:
		base._002Ector();
		num = 6;
		goto IL_0082;
		IL_0082:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 4:
				U5kf7ue4Bn = "";
				goto case 2;
			case 0:
			case 1:
				aXJZm8mYmSB7cNrBAKQ();
				num = 4;
				continue;
			case 2:
			case 5:
				aYXfmANTG4 = (string)CGsVCmmNd6CXKTtZpES(7402);
				break;
			default:
				num = 3;
				continue;
			case 6:
				return;
			}
			break;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellJump(CvsCellJump cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 0:
				U5kf7ue4Bn = "";
				num = 5;
				break;
			case 5:
				aYXfmANTG4 = kgbOBx7BanbFa22Hp9.ol99ukmDA(7402);
				goto default;
			default:
				XI419KmPvQw0Csc9Wcy();
				num = ((!gK4Hfnmo8E7wKrii868()) ? 2 : 6);
				break;
			case 3:
			case 6:
				base._002Ector(cell);
				goto case 2;
			case 2:
			case 4:
				U5kf7ue4Bn = cell.U5kf7ue4Bn;
				num = 7;
				break;
			case 1:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 0;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellJump(CvsCellLocation location, CvsCogCellResult cellResult)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_00aa;
		IL_001a:
		aYXfmANTG4 = (string)cdq3nPmxVgcBVGbqtav((CvsCogJumpResult)cellResult.Face);
		num = 8;
		if (XI419KmPvQw0Csc9Wcy())
		{
		}
		goto IL_00aa;
		IL_00aa:
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 7:
				U5kf7ue4Bn = "";
				num = 0;
				continue;
			case 1:
				aXJZm8mYmSB7cNrBAKQ();
				num = 7;
				if (true)
				{
					continue;
				}
				goto default;
			default:
				U5kf7ue4Bn = ((CvsCogJumpResult)cellResult.Face).Caption;
				num = 6;
				if (gK4Hfnmo8E7wKrii868())
				{
					continue;
				}
				goto case 2;
			case 2:
			case 3:
				base._002Ector(location, cellResult);
				goto default;
			case 0:
				do
				{
					aYXfmANTG4 = (string)CGsVCmmNd6CXKTtZpES(7402);
					_ = 1;
					if (XI419KmPvQw0Csc9Wcy())
					{
						num = 5;
						continue;
					}
					num = 2;
					break;
				}
				while (!gK4Hfnmo8E7wKrii868());
				continue;
			case 8:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCellJump(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return U5kf7ue4Bn;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aXJZm8mYmSB7cNrBAKQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CGsVCmmNd6CXKTtZpES(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gK4Hfnmo8E7wKrii868()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XI419KmPvQw0Csc9Wcy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cdq3nPmxVgcBVGbqtav(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogJumpResult)P_0).DestCellLoc;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type PxkP6mm1XjeHSJoYyKR(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}
}
