using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Newtonsoft.Json.Linq;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels;

public class SnippetPasteBuffer
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		public CvsCellLocation guidLoc;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass0_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			reaOPgKnPflABV8qkykh();
			V2TLKTKnZ3pm5eHxW6ic(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetGuidCell_003Eb__0(PasteBufferCell c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return h8KPx0KnbkxvkeVLYPnx(WiL6XtKnBhTOXl1i2DBw(c), guidLoc.ToString(), StringComparison.Ordinal);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void reaOPgKnPflABV8qkykh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void V2TLKTKnZ3pm5eHxW6ic(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OCAHuEKnve5LBaGXjfh6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mvTOtvKnr3tl2EiY1ILj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WiL6XtKnBhTOXl1i2DBw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool h8KPx0KnbkxvkeVLYPnx(object P_0, object P_1, StringComparison P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Equals((string)P_1, P_2);
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<PasteBufferCell, bool> _003C_003E9__2_0;

		public static Func<PasteBufferCell, bool> _003C_003E9__4_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rOOJqBKnSGnSRDm8riAh();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rOOJqBKnSGnSRDm8riAh();
			EGhEmkKnkylpCMqx7f7b(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetVersionCell_003Eb__2_0(PasteBufferCell c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return c.Name.EndsWith(CdQUGaROfy7He9T0foW.KbIzwHEDLa(48182), StringComparison.Ordinal);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetToolNameCell_003Eb__4_0(PasteBufferCell c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iGFTrFKn8C6tJExaDF36(c.Name, CdQUGaROfy7He9T0foW.KbIzwHEDLa(1188), StringComparison.Ordinal);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void rOOJqBKnSGnSRDm8riAh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hI8UETKnGQFkjUcU3Ok6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tXtU5lKnoVb9I5qtbLZG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void EGhEmkKnkylpCMqx7f7b(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iGFTrFKn8C6tJExaDF36(object P_0, object P_1, StringComparison P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).EndsWith((string)P_1, P_2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static PasteBufferCell GetGuidCell(PasteBuffer buffer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass0_0();
		CS_0024_003C_003E8__locals2.guidLoc = At6wQDJXoId6BDPlWAd(buffer).Location;
		return buffer.Cells.First([MethodImpl(MethodImplOptions.NoInlining)] (PasteBufferCell c) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec__DisplayClass0_0.h8KPx0KnbkxvkeVLYPnx(_003C_003Ec__DisplayClass0_0.WiL6XtKnBhTOXl1i2DBw(c), CS_0024_003C_003E8__locals2.guidLoc.ToString(), StringComparison.Ordinal);
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Guid GetGuid(PasteBuffer buffer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new Guid((string)OHXgf3J4SJW3bsUaBjy(asrdOKJ9VOsTLaJ3OMN(buffer)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static PasteBufferCell GetVersionCell(PasteBuffer buffer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return buffer.Cells.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (PasteBufferCell c) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return c.Name.EndsWith(CdQUGaROfy7He9T0foW.KbIzwHEDLa(48182), StringComparison.Ordinal);
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetSnippetVersion(PasteBuffer buffer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		PasteBufferCell versionCell = GetVersionCell(buffer);
		if (versionCell != null)
		{
			return ((IEnumerable<JToken>)cWgMMZJ7kNIM6n3HbVS(versionCell)).Value<int>();
		}
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static PasteBufferCell GetToolNameCell(PasteBuffer buffer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return buffer.Cells.First([MethodImpl(MethodImplOptions.NoInlining)] (PasteBufferCell c) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec.iGFTrFKn8C6tJExaDF36(c.Name, CdQUGaROfy7He9T0foW.KbIzwHEDLa(1188), StringComparison.Ordinal);
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetToolName(PasteBuffer buffer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return cWgMMZJ7kNIM6n3HbVS(L4m1VnJ3sOgI49AFYgY(buffer)).ToString();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static PasteBufferCell GetCellInTool(PasteBuffer buffer, string cellName, bool isInternal = false, bool isSupportSnippet = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string snippetName = (string)(isSupportSnippet ? GetSupportSnippetName(buffer) : woniVLJjQyTnwtJHYn7(buffer));
		return (PasteBufferCell)p4MSVlJ6vtZ2Mt2kBl7(buffer, EzSnippet.AssembleFullCellName(snippetName, cellName, isInternal));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetSupportSnippetName(PasteBuffer buffer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (!fbJGy5JpviR7vDrlwG9())
		{
		}
		int num3 = default;
		int length = default;
		string text = default;
		while (true)
		{
			int num2;
			object obj;
			switch (num)
			{
			default:
				num2 = 0;
				goto IL_0029;
			case 4:
			{
				PasteBufferCell versionCell = GetVersionCell(buffer);
				if (versionCell == null)
				{
					num = 0;
					continue;
				}
				obj = versionCell.Name;
				goto IL_00c3;
			}
			case 2:
			case 5:
				return null;
			case 0:
				obj = null;
				goto IL_00c3;
			case 6:
				break;
				IL_0029:
				num3 = num2;
				length = fhGs6FJAf2D3L4cEsKF(text, ggAVaHJCVG17PKKxjuO(1104)) - num3;
				num = 6;
				continue;
				IL_00c3:
				text = (string)obj;
				if (text != null)
				{
					if (text.StartsWith((string)ggAVaHJCVG17PKKxjuO(1044)))
					{
						num2 = 1;
						goto IL_0029;
					}
					goto default;
				}
				_ = 0;
				if (!N4S2wpJEc5FRwQSmdpa())
				{
					num = 1;
					continue;
				}
				num = 5;
				if (true)
				{
					continue;
				}
				break;
			}
			break;
		}
		return text.Substring(num3, length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SnippetPasteBuffer()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		lepUsVJRN63wVLJSXoE();
		zdiQn0JWyGqyWmASA1b(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellRange At6wQDJXoId6BDPlWAd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Range;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool N4S2wpJEc5FRwQSmdpa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fbJGy5JpviR7vDrlwG9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object asrdOKJ9VOsTLaJ3OMN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetGuidCell((PasteBuffer)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OHXgf3J4SJW3bsUaBjy(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Comment;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cWgMMZJ7kNIM6n3HbVS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object L4m1VnJ3sOgI49AFYgY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetToolNameCell((PasteBuffer)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object woniVLJjQyTnwtJHYn7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetToolName((PasteBuffer)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object p4MSVlJ6vtZ2Mt2kBl7(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetCellWithName((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ggAVaHJCVG17PKKxjuO(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int fhGs6FJAf2D3L4cEsKF(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).IndexOf((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lepUsVJRN63wVLJSXoE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zdiQn0JWyGqyWmASA1b(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
