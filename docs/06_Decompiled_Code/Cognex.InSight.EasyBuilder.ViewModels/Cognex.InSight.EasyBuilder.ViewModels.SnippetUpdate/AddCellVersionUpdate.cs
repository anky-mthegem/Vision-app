using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Newtonsoft.Json.Linq;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;

public class AddCellVersionUpdate : ISnippetUpdate
{
	private readonly AddCellUpdate R7KKNxoYKb;

	private readonly int RX8KA6PgEZ;

	private readonly string jV5KdL3Hc6;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AddCellVersionUpdate(int latest, SnippetLocalizer localizer, string supportSnippetName = null)
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
				jV5KdL3Hc6 = supportSnippetName;
				num = 6;
				break;
			case 4:
				lRVbvitas9wvvhbkCB1(this);
				_ = 1;
				if (!TlrtEHtJZu5CiyUdWLE())
				{
					num = 5;
					if (!TlrtEHtJZu5CiyUdWLE())
					{
						break;
					}
					goto case 0;
				}
				num = 1;
				break;
			case 0:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 4;
				break;
			case 6:
				R7KKNxoYKb = new AddCellUpdate(new CvsCellLocation(0, 1), vVaK7nJ9cy, localizer, replaceCell: true);
				num = 7;
				break;
			case 2:
			case 5:
				RX8KA6PgEZ = latest;
				goto default;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell vVaK7nJ9cy(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string text = jV5KdL3Hc6 ?? SnippetPasteBuffer.GetToolName(P_0);
		PasteBufferCell pasteBufferCell = new PasteBufferCell(new CvsCellLocation(P_0.Origin.Row, ntXXU7tewg9085aIJle(P_0).Column + 1));
		Jc0wsNtOwTpWcEVcqU6(pasteBufferCell, string.Format(CdQUGaROfy7He9T0foW.KbIzwHEDLa(1906), RX8KA6PgEZ));
		UDIEYKtiP3d4cagUMdB(pasteBufferCell, BJjeCptDHmy7mJmVslZ(c6hsMItIF1r44iYL3Tb(1044), text, c6hsMItIF1r44iYL3Tb(31580)));
		pasteBufferCell.Value = (JToken)mPh7evtVpjwZ257ReIg(ivWBettngWUZPSn1QQB(c6hsMItIF1r44iYL3Tb(1906), RX8KA6PgEZ));
		nODJ8stfsjP4ouECe5M(pasteBufferCell, mPh7evtVpjwZ257ReIg(c6hsMItIF1r44iYL3Tb(7160)));
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PasteBuffer Apply(PasteBuffer originalSnippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return R7KKNxoYKb.Apply(originalSnippet);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lRVbvitas9wvvhbkCB1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RscbwJtwYcJG2WduRXb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TlrtEHtJZu5CiyUdWLE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation ntXXU7tewg9085aIJle(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Origin;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Jc0wsNtOwTpWcEVcqU6(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Expression = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object c6hsMItIF1r44iYL3Tb(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BJjeCptDHmy7mJmVslZ(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UDIEYKtiP3d4cagUMdB(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ivWBettngWUZPSn1QQB(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mPh7evtVpjwZ257ReIg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)(string?)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nODJ8stfsjP4ouECe5M(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Style = (JToken)P_1;
	}
}
