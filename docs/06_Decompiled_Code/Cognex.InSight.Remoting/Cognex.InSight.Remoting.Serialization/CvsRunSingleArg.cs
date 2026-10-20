using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "RunSingleArgument")]
public class CvsRunSingleArg : CvsPropertySheetArg
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsRunSingleArg(int argNum, bool enabled, bool isError, bool hasQuotes, bool isEmpty, object value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		while (true)
		{
			switch (num)
			{
			case 4:
				IsError = false;
				goto default;
			case 6:
				IsEmpty = false;
				num = 8;
				if (dPZw0341DvkiaVIVnAx())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 3:
				base._002Ector();
				num = 0;
				continue;
			case 8:
				Value = value;
				num = 10;
				continue;
			case 2:
				Disabled = !enabled;
				num = 4;
				continue;
			default:
				HasQuotes = false;
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
				ArgNum = argNum;
				num = 2;
				if (true)
				{
					continue;
				}
				break;
			case 7:
				break;
			case 10:
				return;
			}
			NPBx1148b8so3Kba50b();
			dPZw0341DvkiaVIVnAx();
			num = ((!tePC5s4JtQGVOX9CBxJ()) ? 3 : 9);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NPBx1148b8so3Kba50b()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dPZw0341DvkiaVIVnAx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tePC5s4JtQGVOX9CBxJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
