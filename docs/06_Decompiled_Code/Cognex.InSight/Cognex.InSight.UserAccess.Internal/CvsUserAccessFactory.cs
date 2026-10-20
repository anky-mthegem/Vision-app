using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.UserAccess.Internal;

public static class CvsUserAccessFactory
{
	public enum ErrorCodes
	{
		BlankPassword = -10,
		InvalidCredentials = 49,
		InsufficientAccessRights = 50,
		ServerNotAvailable = 81
	}

	private static readonly object Vrq413Ujan;

	internal static TraceSwitch CDSTraceSwitch;

	[CompilerGenerated]
	private static ICvsConnectedUser EUZ4xlmbPR;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static ICvsConnectedUser ISEConnectedUser
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EUZ4xlmbPR;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EUZ4xlmbPR = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsUserAccessFactory()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ECX8n22n8wetJwgn26H();
		int num = ((!pClDaA2a8K8lTOEdFvk()) ? 1 : 5);
		while (true)
		{
			switch (num)
			{
			case 4:
				SpXmQh2b1EbQnM7TFJZ(new CvsClassicConnectedUser(kgbOBx7BanbFa22Hp9.ol99ukmDA(16862), "", CvsInSightSecurityAccess.Full, ftpReadEnabled: true, ftpWriteEnabled: true, customViewDefaultEnabled: false));
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 5:
				SkBdeX2GYXiTZ4nPp9v();
				num = 3;
				if (pClDaA2a8K8lTOEdFvk())
				{
					break;
				}
				goto case 1;
			case 1:
			case 2:
				CDSTraceSwitch = new TraceSwitch((string)sZpqUx2XLF65kEmJirX(16786), (string)sZpqUx2XLF65kEmJirX(16796));
				goto case 4;
			default:
				num = 4;
				if (true)
				{
					break;
				}
				goto case 3;
			case 3:
				Vrq413Ujan = new object();
				goto case 1;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SkBdeX2GYXiTZ4nPp9v()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sZpqUx2XLF65kEmJirX(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SpXmQh2b1EbQnM7TFJZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ISEConnectedUser = (ICvsConnectedUser)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pClDaA2a8K8lTOEdFvk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ECX8n22n8wetJwgn26H()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
