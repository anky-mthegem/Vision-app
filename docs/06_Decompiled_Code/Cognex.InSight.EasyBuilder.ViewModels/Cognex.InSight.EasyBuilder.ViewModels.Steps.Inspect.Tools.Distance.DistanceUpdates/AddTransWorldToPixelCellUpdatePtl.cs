using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.Internal;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Distance.DistanceUpdates;

public class AddTransWorldToPixelCellUpdatePtl : ISnippetUpdate
{
	private static readonly CvsCellLocation TnmWEWq9tB;

	private static readonly CvsCellLocation CNwWbwxIA5;

	private static readonly CvsCellLocation scyWcCPGYZ;

	private static readonly CvsCellLocation TgsWQVv6E4;

	private static readonly CvsCellLocation ka2WgvDZcD;

	private readonly AddCellUpdate XURWMvpPyj;

	private readonly AddCellUpdate XVgWR4mQPs;

	private readonly AddCellUpdate Xg5W4tHMXD;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AddTransWorldToPixelCellUpdatePtl(SnippetLocalizer localizer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!Lxl5uMCFHmjwLnuTAAh()) ? 4 : 5);
		while (true)
		{
			switch (num)
			{
			case 3:
				Xg5W4tHMXD = new AddCellUpdate(ka2WgvDZcD, paVW3G3TlG, ka2WgvDZcD, localizer);
				num = 7;
				break;
			case 1:
				XVgWR4mQPs = new AddCellUpdate(TgsWQVv6E4, paVW3G3TlG, TgsWQVv6E4, localizer);
				num = 3;
				break;
			case 6:
				JZ1DOpCU8AmMpl4On8H(this);
				goto case 2;
			case 0:
			case 5:
				zEXRomCYmsQOK41208s();
				num = 6;
				break;
			case 2:
			case 4:
				XURWMvpPyj = new AddCellUpdate(scyWcCPGYZ, u0BWDj9cLb, localizer);
				goto case 1;
			default:
				num = 1;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	PasteBuffer ISnippetUpdate.Apply(PasteBuffer originalSnippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		PasteBuffer pasteBuffer = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				pasteBuffer = (PasteBuffer)kTwhrjCxfJief8IESHs(XURWMvpPyj, pasteBuffer);
				Lxl5uMCFHmjwLnuTAAh();
				if (!e5v0LfCM1cw3YAResK0())
				{
					num = 4;
					break;
				}
				num = 1;
				if (Lxl5uMCFHmjwLnuTAAh())
				{
					break;
				}
				goto case 6;
			case 5:
				pasteBuffer = (PasteBuffer)I8UhM7CHnER3IbaRXx3(originalSnippet);
				num = 0;
				break;
			case 2:
			case 4:
				pasteBuffer = (PasteBuffer)kTwhrjCxfJief8IESHs(XVgWR4mQPs, pasteBuffer);
				goto default;
			case 6:
				pasteBuffer = (PasteBuffer)WqPuvTCmJsB3j0ALdVY(pasteBuffer);
				num = 7;
				break;
			default:
				pasteBuffer = (PasteBuffer)kTwhrjCxfJief8IESHs(Xg5W4tHMXD, pasteBuffer);
				num = 6;
				break;
			case 7:
				return pasteBuffer;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static PasteBufferCell u0BWDj9cLb(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation loc = JdA9D7CQMny9kHtOH0M(P_0, scyWcCPGYZ);
		string text = (string)zXg7CfCN9f5Ip4sewfg(P_0);
		string text2 = (string)VZfjGZC2uWf7sl8bR18(CdQUGaROfy7He9T0foW.KbIzwHEDLa(26642), text);
		PasteBufferCell pasteBufferCell = new PasteBufferCell(loc);
		V8nyGpCcZxykJ0uT9uD(pasteBufferCell, text2);
		h5VMUiC1qIGrciG02mN(pasteBufferCell, "");
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static PasteBufferCell paVW3G3TlG(PasteBuffer P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation loc = JdA9D7CQMny9kHtOH0M(P_0, P_1);
		string text = (string)bx7yCHCuMFG1mp4P7GX(P_0, P_1);
		PasteBufferCell pasteBufferCell = new PasteBufferCell(loc);
		V8nyGpCcZxykJ0uT9uD(pasteBufferCell, text);
		h5VMUiC1qIGrciG02mN(pasteBufferCell, "");
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static PasteBuffer BgrWIlgNZS(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 16;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_00f7;
		IL_001a:
		string text = (string)qdbWVDAKqlmeuBNeBm4(P_0, TgsWQVv6E4);
		num = 4;
		goto IL_00f7;
		IL_00f7:
		string text4 = default;
		string text5 = default;
		string text3 = default;
		string text2 = default;
		int num2 = default;
		IReadOnlyCollection<string> source = default;
		PasteBufferCell pasteBufferCell = default;
		string absRefLocationOfCell2 = default;
		PasteBuffer pasteBuffer = default;
		string text7 = default;
		string absRefLocationOfCell = default;
		string text6 = default;
		while (true)
		{
			switch (num)
			{
			case 5:
			case 10:
				break;
			case 11:
				text4 = (string)nhaorVA5qGLEeKxjgQE(text5, text3, text2);
				goto case 3;
			case 13:
				num2 = 0;
				num = 0;
				continue;
			case 1:
			case 2:
				source = CvsParse.FindAllArgs((string)cINu5ACtHuqe574Kf5B(pasteBufferCell)).ToReadonlyList();
				absRefLocationOfCell2 = SnippetUpdateHelper.GetAbsRefLocationOfCell(P_0, TnmWEWq9tB);
				num = 7;
				continue;
			case 9:
				pasteBufferCell = (PasteBufferCell)rGcoNQChsvW1Fo7nefP(pasteBuffer, CNwWbwxIA5);
				Lxl5uMCFHmjwLnuTAAh();
				if (!e5v0LfCM1cw3YAResK0())
				{
					num = 1;
					if (true)
					{
						continue;
					}
					goto case 16;
				}
				num = 10;
				if (!e5v0LfCM1cw3YAResK0())
				{
					continue;
				}
				goto case 0;
			case 16:
				pasteBuffer = P_0.Clone();
				num = 9;
				continue;
			case 14:
				text7 = (string)DBX9ROALAIKDBqAhTHe(I3PcKKCzSga2hUgRfXt(1832), absRefLocationOfCell, I3PcKKCzSga2hUgRfXt(6970));
				goto case 13;
			default:
				num = 13;
				continue;
			case 8:
				text4 = (string)nhaorVA5qGLEeKxjgQE(text5, text6, text7);
				num = 3;
				if (Lxl5uMCFHmjwLnuTAAh())
				{
					continue;
				}
				goto case 12;
			case 12:
				text6 = (string)DBX9ROALAIKDBqAhTHe(I3PcKKCzSga2hUgRfXt(1832), absRefLocationOfCell2, I3PcKKCzSga2hUgRfXt(26692));
				break;
			case 0:
			case 6:
				if (num2 >= source.Count())
				{
					num = 17;
					continue;
				}
				text5 = source.ElementAt(num2);
				if (!text5.Contains(text3))
				{
					if (L3OXsDAwDYi8lhU6b9Q(text5, text6))
					{
						num = 8;
						continue;
					}
					goto case 15;
				}
				num = 11;
				continue;
			case 7:
				text3 = (string)DBX9ROALAIKDBqAhTHe(I3PcKKCzSga2hUgRfXt(1832), absRefLocationOfCell2, I3PcKKCzSga2hUgRfXt(6970));
				num = 12;
				continue;
			case 4:
				text2 = (string)I3PcKKCzSga2hUgRfXt(1832) + text + CdQUGaROfy7He9T0foW.KbIzwHEDLa(6970);
				absRefLocationOfCell = SnippetUpdateHelper.GetAbsRefLocationOfCell(P_0, ka2WgvDZcD);
				num = 14;
				continue;
			case 15:
				num2++;
				num = 6;
				continue;
			case 3:
				pasteBufferCell.Expression = (string)oRUptHAJivRBS8Nmbbm(cINu5ACtHuqe574Kf5B(pasteBufferCell), num2, text4);
				num = 15;
				continue;
			case 17:
				return pasteBuffer;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string G1QWf1xttq(PasteBuffer P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Lxl5uMCFHmjwLnuTAAh();
		int num;
		if (!e5v0LfCM1cw3YAResK0())
		{
			num = 2;
			if (e5v0LfCM1cw3YAResK0())
			{
			}
		}
		else
		{
			num = 6;
			if (e5v0LfCM1cw3YAResK0())
			{
			}
		}
		string text = default;
		string text2 = default;
		string text3 = default;
		string absRefLocationOfCell = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				text = (string)zXg7CfCN9f5Ip4sewfg(P_0);
				goto case 1;
			case 1:
			case 6:
				text2 = (string)qdbWVDAKqlmeuBNeBm4(P_0, scyWcCPGYZ);
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				goto case 4;
			case 4:
				if (!(P_1 == ka2WgvDZcD))
				{
					text3 = (string)I3PcKKCzSga2hUgRfXt(26810);
					num = 8;
					continue;
				}
				goto case 7;
			default:
				num = 7;
				continue;
			case 7:
				text3 = (string)I3PcKKCzSga2hUgRfXt(26702);
				num = 5;
				if (e5v0LfCM1cw3YAResK0())
				{
				}
				continue;
			case 3:
				absRefLocationOfCell = SnippetUpdateHelper.GetAbsRefLocationOfCell(P_0, TnmWEWq9tB);
				num = 4;
				if (Lxl5uMCFHmjwLnuTAAh())
				{
					continue;
				}
				break;
			case 5:
			case 8:
				break;
			}
			break;
		}
		return (string)wnP1WhAa1tH0UhaoZba(text3, text, text2, absRefLocationOfCell);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AddTransWorldToPixelCellUpdatePtl()
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
			default:
				TgsWQVv6E4 = new CvsCellLocation(8, 1);
				num = 3;
				break;
			case 1:
				zEXRomCYmsQOK41208s();
				num = 0;
				break;
			case 3:
				ka2WgvDZcD = new CvsCellLocation(8, 2);
				num = 8;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
				TnmWEWq9tB = new CvsCellLocation(3, 0);
				Lxl5uMCFHmjwLnuTAAh();
				num = (e5v0LfCM1cw3YAResK0() ? 5 : 7);
				break;
			case 6:
				scyWcCPGYZ = new CvsCellLocation(8, 0);
				goto default;
			case 2:
			case 7:
				CNwWbwxIA5 = new CvsCellLocation(3, 3);
				num = 6;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zEXRomCYmsQOK41208s()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JZ1DOpCU8AmMpl4On8H(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Lxl5uMCFHmjwLnuTAAh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool e5v0LfCM1cw3YAResK0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object I8UhM7CHnER3IbaRXx3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kTwhrjCxfJief8IESHs(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AddCellUpdate)P_0).Apply((PasteBuffer)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WqPuvTCmJsB3j0ALdVY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return BgrWIlgNZS((PasteBuffer)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation JdA9D7CQMny9kHtOH0M(object P_0, CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetLocationFromOrigin(offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zXg7CfCN9f5Ip4sewfg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SnippetUpdateHelper.InputImageLocationFactory((PasteBuffer)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VZfjGZC2uWf7sl8bR18(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void V8nyGpCcZxykJ0uT9uD(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Expression = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void h5VMUiC1qIGrciG02mN(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bx7yCHCuMFG1mp4P7GX(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return G1QWf1xttq((PasteBuffer)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rGcoNQChsvW1Fo7nefP(object P_0, CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetCellWithOffset(offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cINu5ACtHuqe574Kf5B(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object I3PcKKCzSga2hUgRfXt(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DBX9ROALAIKDBqAhTHe(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qdbWVDAKqlmeuBNeBm4(object P_0, CvsCellLocation cellOffset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SnippetUpdateHelper.GetAbsRefLocationOfCell((PasteBuffer)P_0, cellOffset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nhaorVA5qGLEeKxjgQE(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool L3OXsDAwDYi8lhU6b9Q(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Contains((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oRUptHAJivRBS8Nmbbm(object P_0, int P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsParse.ReplaceArg((string)P_0, P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wnP1WhAa1tH0UhaoZba(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2, P_3);
	}
}
