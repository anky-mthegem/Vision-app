using System;
using System.Runtime.CompilerServices;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Services;

public struct CellState : IEquatable<CellState>
{
	[CompilerGenerated]
	private CellEnabledState eGYTPnKXMY;

	[CompilerGenerated]
	private CvsCellLocation VqOTI9KIoE;

	[CompilerGenerated]
	private bool b0qT1kSH49;

	public CellEnabledState EnabledState
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return eGYTPnKXMY;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			eGYTPnKXMY = value;
		}
	}

	public CvsCellLocation CellReferenceLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return VqOTI9KIoE;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VqOTI9KIoE = value;
		}
	}

	public bool IsAbsoluteReference
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		readonly get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return b0qT1kSH49;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			b0qT1kSH49 = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CellState(CellEnabledState enabledState)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (0 == 0)
		{
			while (true)
			{
				switch (num)
				{
				case 3:
				case 5:
					break;
				default:
					num = 4;
					if (!DgL0a8K6At2PesyLrVw())
					{
						continue;
					}
					goto case 4;
				case 4:
					CellReferenceLocation = CvsCellLocation.Invalid;
					num = 7;
					continue;
				case 6:
					VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
					_ = 0;
					num = ((!WHNxsWKbFb08YkJKKNj()) ? 5 : 2);
					continue;
				case 1:
				case 2:
					this = default;
					num = 0;
					if (true)
					{
						continue;
					}
					goto case 0;
				case 0:
					if (enabledState != CellEnabledState.ConditionallyEnabled)
					{
						EnabledState = enabledState;
						goto case 4;
					}
					break;
				case 7:
					IsAbsoluteReference = true;
					num = 8;
					continue;
				case 8:
					return;
				}
				break;
			}
		}
		throw new ArgumentException((string)Ex736aKpEro1njS2Q0P(17662));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CellState(CvsCellLocation cellReferenceLocation, bool isAbsoluteReference)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!WHNxsWKbFb08YkJKKNj()) ? 2 : 4);
		do
		{
			IL_003d:
			switch (num)
			{
			case 6:
				EnabledState = CellEnabledState.ConditionallyEnabled;
				break;
			default:
				num = 3;
				if (WHNxsWKbFb08YkJKKNj())
				{
					goto IL_003d;
				}
				goto case 1;
			case 1:
			case 2:
				this = default;
				num = 6;
				if (WHNxsWKbFb08YkJKKNj())
				{
					goto IL_003d;
				}
				goto case 0;
			case 0:
			case 4:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				goto case 1;
			case 5:
				IsAbsoluteReference = isAbsoluteReference;
				num = 7;
				goto IL_003d;
			case 3:
				break;
			case 7:
				return;
			}
			CellReferenceLocation = cellReferenceLocation;
			num = 5;
		}
		while (!DgL0a8K6At2PesyLrVw());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (WHNxsWKbFb08YkJKKNj())
		{
			num = 6;
		}
		else
		{
			num = 4;
			if (!WHNxsWKbFb08YkJKKNj())
			{
				goto IL_00db;
			}
		}
		CellEnabledState enabledState2 = default;
		CellEnabledState enabledState = default;
		CvsCellLocation cellReferenceLocation = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				return enabledState2.ToString();
			case 2:
				if (enabledState != CellEnabledState.ConditionallyEnabled)
				{
					goto case 5;
				}
				cellReferenceLocation = CellReferenceLocation;
				num = 7;
				continue;
			default:
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 4:
				if ((uint)enabledState <= 2u)
				{
					enabledState2 = EnabledState;
					num = 3;
					continue;
				}
				num = 2;
				if (DgL0a8K6At2PesyLrVw())
				{
				}
				continue;
			case 0:
			case 6:
				enabledState = EnabledState;
				goto case 1;
			case 7:
				break;
			case 5:
				throw new ArgumentOutOfRangeException();
			}
			break;
		}
		goto IL_00db;
		IL_00db:
		return cellReferenceLocation.ToString(IsAbsoluteReference, IsAbsoluteReference);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(CellState other)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		CvsCellLocation cellReferenceLocation = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				if (EnabledState != CellEnabledState.ConditionallyEnabled)
				{
					DgL0a8K6At2PesyLrVw();
					num = (WHNxsWKbFb08YkJKKNj() ? 4 : 0);
					break;
				}
				cellReferenceLocation = CellReferenceLocation;
				goto default;
			case 1:
			case 4:
				return EnabledState == other.EnabledState;
			default:
				if (cellReferenceLocation.Equals(other.CellReferenceLocation))
				{
					num = 5;
					break;
				}
				return false;
			case 5:
				return IsAbsoluteReference == other.IsAbsoluteReference;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (obj == null)
		{
			return false;
		}
		if (obj is CellState)
		{
			return Equals((CellState)obj);
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
		return ((((int)EnabledState * 397) ^ CellReferenceLocation.GetHashCode()) * 397) ^ IsAbsoluteReference.GetHashCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator ==(CellState left, CellState right)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return left.Equals(right);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool operator !=(CellState left, CellState right)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return !left.Equals(right);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ex736aKpEro1njS2Q0P(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WHNxsWKbFb08YkJKKNj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DgL0a8K6At2PesyLrVw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
