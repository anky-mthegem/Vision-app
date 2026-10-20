#define TRACE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cognex.InSight.Cell;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Services;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Controls.ViewModels;

public class ToolCellLocator : IToolCellLocator
{
	private readonly CvsInSight XgDfSh8XDk;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ToolCellLocator(CvsInSight insight)
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
			default:
				XgDfSh8XDk = insight;
				num = 5;
				break;
			case 0:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				By1gkoygyrg1cHYHHb3();
				num = ((!WVWCpqyytjWCJbdVOwg()) ? 3 : 4);
				break;
			case 1:
			case 4:
				base._002Ector();
				goto default;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<(CvsCellLocation location, string displayName)> GetColorLibraries()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return XgDfSh8XDk.Results.Cells.Cast<CvsCell>().Where([MethodImpl(MethodImplOptions.NoInlining)] (CvsCell cell) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mMwfGMhN8n(cell);
		}).Select([MethodImpl(MethodImplOptions.NoInlining)] (CvsCell P_0) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new
			{
				cell = P_0,
				libraryName = QdRfD4jPEl(P_0)
			};
		})
			.Where([MethodImpl(MethodImplOptions.NoInlining)] (_003C_003Eh__TransparentIdentifier0) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003Eh__TransparentIdentifier0.libraryName != null;
			})
			.Select([MethodImpl(MethodImplOptions.NoInlining)] (_003C_003Eh__TransparentIdentifier0) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return (Location: _003C_003Eh__TransparentIdentifier0.cell.Location, libraryName: _003C_003Eh__TransparentIdentifier0.libraryName);
			})
			.ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool mMwfGMhN8n(CvsCell P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (WVWCpqyytjWCJbdVOwg())
		{
			num = 4;
		}
		else
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_0056;
			}
		}
		goto IL_0074;
		IL_009b:
		string text = default;
		if (text != null)
		{
			num = 5;
			goto IL_0074;
		}
		goto IL_00bd;
		IL_00bd:
		return false;
		IL_0074:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			case 1:
			case 3:
				goto IL_0056;
			default:
				num = 2;
				continue;
			case 2:
				goto IL_009b;
			case 5:
				return LcmxrLgscB96uFtcWUt(text, LdWibpgwGvGgHrxvOW6(47174), StringComparison.InvariantCultureIgnoreCase);
			}
			break;
		}
		if (h9NK92y8aWw8JsITAYa(Qlrq6IyJguuYxuRdnJZ(VfpmJuyZBOyUaqSLrgP(P_0)), kgbOBx7BanbFa22Hp9.ol99ukmDA(47198), StringComparison.InvariantCultureIgnoreCase) == 0)
		{
			goto IL_0056;
		}
		goto IL_00bd;
		IL_0056:
		text = k05E6UyzprIsrRQ9jDn(P_0) as string;
		goto IL_009b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string QdRfD4jPEl(CvsCell P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			return new TrainMatchColorToolApi((ResourceNode)x0he3Xg9gG55B0mmq49(ibCDV4gL5hJEHLu1aCu(sF6pxtghro4GiBk9GHT(XgDfSh8XDk)), P_0.Location)).GetLibraryName().Result;
		}
		catch (Exception ex)
		{
			Trace.TraceWarning((string)HoprySgSes55avV8rMo(LdWibpgwGvGgHrxvOW6(47232), ex));
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private _003C_003Ef__AnonymousType3<CvsCell, string> aL6feoWXeG(CvsCell P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new
		{
			cell = P_0,
			libraryName = QdRfD4jPEl(P_0)
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WVWCpqyytjWCJbdVOwg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool By1gkoygyrg1cHYHHb3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VfpmJuyZBOyUaqSLrgP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).CellResult;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Qlrq6IyJguuYxuRdnJZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int h9NK92y8aWw8JsITAYa(object P_0, object P_1, StringComparison P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).IndexOf((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object k05E6UyzprIsrRQ9jDn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).CellValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LdWibpgwGvGgHrxvOW6(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LcmxrLgscB96uFtcWUt(object P_0, object P_1, StringComparison P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).StartsWith((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sF6pxtghro4GiBk9GHT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).CogSocket;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ibCDV4gL5hJEHLu1aCu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).Sheet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object x0he3Xg9gG55B0mmq49(object P_0, CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocketSheet)P_0).GetCellToolResourceNode(location);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HoprySgSes55avV8rMo(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}
}
