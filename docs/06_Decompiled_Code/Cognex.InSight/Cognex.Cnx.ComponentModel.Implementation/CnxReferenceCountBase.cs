using System;
using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.Cnx.ComponentModel.Implementation;

public class CnxReferenceCountBase : ICnxReferenceCount, IDisposable
{
	private int DB0AE2dFe;

	[MethodImpl(MethodImplOptions.NoInlining)]
	int ICnxReferenceCount.AddReference()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ++DB0AE2dFe;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (B9B1FehCmr9lwNPovGy() ? 4 : 3);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				DB0AE2dFe--;
				num = 1;
				break;
			case 1:
				if (DB0AE2dFe < 1)
				{
					goto default;
				}
				return;
			default:
				FuPvonhK8vApgNivqyZ(this, true);
				num = 5;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Dispose(bool disposing)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxReferenceCountBase()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		X52a6rh5IYSViQPnuBs();
		nDFsf8hogo7EPytqWiQ(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lvV3ICht8KTTEhwKn1Q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool B9B1FehCmr9lwNPovGy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FuPvonhK8vApgNivqyZ(object P_0, bool disposing)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CnxReferenceCountBase)P_0).Dispose(disposing);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void X52a6rh5IYSViQPnuBs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nDFsf8hogo7EPytqWiQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
