using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight;
using Cognex.InSight.EasyBuilder.ViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using zsQqWwRgKaAshfKAktM;

namespace d6U6rfDQgjJaEyFRUK;

internal class vwi48nu0V1Jw83UB8d : ISnippetUpdate
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	PasteBuffer ISnippetUpdate.Apply(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		CvsCellRange cvsCellRange = default;
		CvsCellRange cvsCellRange2 = default;
		CvsCellLocation cvsCellLocation = default;
		PasteBufferCell pasteBufferCell = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				cvsCellRange.Rows -= 2;
				num = 1;
				continue;
			case 8:
				cvsCellRange2 = new CvsCellRange(TjvK2YKLa0E7cPieNY22(P_0).LastRow, P_0.Range.Column, 1, cvsCellLocation.Column - TjvK2YKLa0E7cPieNY22(P_0).Column);
				num = 7;
				continue;
			case 1:
				cvsCellRange.Row++;
				num = 8;
				continue;
			case 7:
				pasteBufferCell.Expression = (string)Fa1c7oKLe5RlNAeJCLvP(new string[5]
				{
					(string)OAkZdQKL5jExdQrnrs3p(33600),
					cvsCellRange.ToString(absoluteRow: true, absoluteColumn: true, absoluteLastRow: true, absoluteLastColumn: true),
					(string)OAkZdQKL5jExdQrnrs3p(5424),
					cvsCellRange2.ToString(absoluteRow: true, absoluteColumn: true, absoluteLastRow: true, absoluteLastColumn: true),
					(string)OAkZdQKL5jExdQrnrs3p(6970)
				});
				num = 11;
				continue;
			case 2:
				if (((string)qFDMVJKLKg5GB2cxiQQs(pasteBufferCell.Expression)).StartsWith((string)OAkZdQKL5jExdQrnrs3p(33582)))
				{
					_ = 0;
					num = ((!PLSio0ztHdC8ATECO1Z()) ? 6 : 5);
					continue;
				}
				break;
			case 9:
				if (pasteBufferCell != null)
				{
					num = 2;
					continue;
				}
				break;
			case 4:
			case 6:
				cvsCellRange = TjvK2YKLa0E7cPieNY22(P_0);
				goto case 0;
			default:
				num = 0;
				if (true)
				{
					continue;
				}
				goto case 3;
			case 3:
			case 5:
				cvsCellLocation = XJXiPvKLJ3Web8v0iJ0R(ChTXXKKLw7VFNrEVGujo(pasteBufferCell));
				goto case 4;
			case 10:
				pasteBufferCell = (PasteBufferCell)pWu8q7KLL67xXwMpiAky(P_0, CdQUGaROfy7He9T0foW.KbIzwHEDLa(4142));
				num = 9;
				continue;
			case 11:
				break;
			}
			break;
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public vwi48nu0V1Jw83UB8d()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ThQVQhKLOusyiPsMVSJN();
		HxOcfMKLIoIBOBdbg7eJ(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pWu8q7KLL67xXwMpiAky(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetCellWithPropertyName((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qFDMVJKLKg5GB2cxiQQs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).ToLower();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OAkZdQKL5jExdQrnrs3p(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ChTXXKKLw7VFNrEVGujo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation XJXiPvKLJ3Web8v0iJ0R(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.TryParse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellRange TjvK2YKLa0E7cPieNY22(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Range;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Fa1c7oKLe5RlNAeJCLvP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Concat((string[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PLSio0ztHdC8ATECO1Z()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool R85WYtzz8TcU9BSkP7B()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ThQVQhKLOusyiPsMVSJN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HxOcfMKLIoIBOBdbg7eJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
