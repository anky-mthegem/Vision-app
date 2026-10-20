using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

public sealed class CvsInvalidInsertException : CvsException
{
	[CompilerGenerated]
	private CvsCellLocation JhbaFtDa4O;

	public CvsCellLocation CellLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return JhbaFtDa4O;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			JhbaFtDa4O = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsInvalidInsertException(CvsCellLocation cellLocation)
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
			case 3:
				base._002Ector();
				goto case 2;
			case 2:
			case 4:
				cI6877TNTOgfoKiKsZo(this, 0);
				goto case 5;
			default:
				num = 5;
				break;
			case 5:
				CellLocation = cellLocation;
				num = 6;
				break;
			case 0:
				lEHPaCTYYynRmoiglwK();
				_ = 0;
				num = (Es0SktTon7D3gw8XMC2() ? 3 : 4);
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsInvalidInsertException(string message, CvsCellLocation cellLocation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!JRhqdWTPEHSEldM2EyC())
		{
			num = 2;
		}
		else
		{
			num = 1;
			if (1 == 0)
			{
				goto IL_0092;
			}
		}
		goto IL_005f;
		IL_005f:
		while (true)
		{
			switch (num)
			{
			case 5:
				base._002Ector(message);
				num = 4;
				continue;
			default:
				CellLocation = cellLocation;
				num = 6;
				continue;
			case 4:
				HResult = 0;
				goto default;
			case 0:
			case 2:
				break;
			case 6:
				return;
			}
			break;
		}
		goto IL_0092;
		IL_0092:
		lEHPaCTYYynRmoiglwK();
		num = 5;
		if (1 == 0)
		{
			return;
		}
		goto IL_005f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsInvalidInsertException(string message, Exception innerException, CvsCellLocation cellLocation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (JRhqdWTPEHSEldM2EyC() ? 5 : 2);
		while (true)
		{
			switch (num)
			{
			case 4:
				cI6877TNTOgfoKiKsZo(this, 0);
				goto case 3;
			default:
				num = 3;
				if (Es0SktTon7D3gw8XMC2())
				{
					continue;
				}
				goto case 3;
			case 3:
				CellLocation = cellLocation;
				num = 6;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				lEHPaCTYYynRmoiglwK();
				break;
			case 1:
			case 5:
				break;
			case 6:
				return;
			}
			base._002Ector(message, innerException);
			num = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lEHPaCTYYynRmoiglwK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cI6877TNTOgfoKiKsZo(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Exception)P_0).HResult = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Es0SktTon7D3gw8XMC2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JRhqdWTPEHSEldM2EyC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
