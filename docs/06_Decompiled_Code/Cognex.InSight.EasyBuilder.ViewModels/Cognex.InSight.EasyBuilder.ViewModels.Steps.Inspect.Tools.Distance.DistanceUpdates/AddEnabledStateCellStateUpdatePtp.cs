using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Distance.DistanceUpdates;

public class AddEnabledStateCellStateUpdatePtp : ISnippetUpdate
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AddEnabledStateCellStateUpdatePtp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		dagc5MCihhfOqecdV23(this);
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
		IEnumerator<PasteBufferCell> enumerator = default;
		CvsCellLocation cvsCellLocation = default;
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				pasteBuffer = (PasteBuffer)uMHsGQCnFg0tfodUrCs(originalSnippet);
				num = 0;
				continue;
			case 1:
			case 4:
				enumerator = pasteBuffer.Cells.GetEnumerator();
				num = 7;
				continue;
			case 0:
				cvsCellLocation = Hu8BFgCfs6CLP18AU1k(((PasteBufferCell)A09jYdCVLfSsyBs5RUc(pasteBuffer, CdQUGaROfy7He9T0foW.KbIzwHEDLa(8420))).Location);
				_ = 0;
				num = ((!RWyjysCImMj2xE7cb7E()) ? 1 : 6);
				continue;
			case 2:
			case 6:
				if (!cvsCellLocation.IsValid)
				{
					break;
				}
				goto case 3;
			default:
				num = 3;
				continue;
			case 3:
				text = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
				goto case 1;
			case 7:
				try
				{
					while (enumerator.MoveNext())
					{
						PasteBufferCell current = enumerator.Current;
						int num2 = 4;
						while (true)
						{
							switch (num2)
							{
							case 0:
							case 2:
								if (!o0k9GkCslLqIG1wMQeE(Ucet8AClLkF6BGaMTmX(IRbYhFCdX8YkdN2OSvP(current)), CdQUGaROfy7He9T0foW.KbIzwHEDLa(26602)))
								{
									break;
								}
								goto case 1;
							case 4:
								if (!((string)Ucet8AClLkF6BGaMTmX(IRbYhFCdX8YkdN2OSvP(current))).StartsWith((string)XM3KnuCg2dU0fI1LZ9Y(26532)))
								{
									num2 = 5;
									continue;
								}
								goto case 1;
							case 1:
							case 3:
								hJlDbOCvuJdLMP6GWQj(current, text);
								num2 = 6;
								continue;
							case 5:
								if (o0k9GkCslLqIG1wMQeE(Ucet8AClLkF6BGaMTmX(IRbYhFCdX8YkdN2OSvP(current)), CdQUGaROfy7He9T0foW.KbIzwHEDLa(26572)))
								{
									goto case 1;
								}
								goto default;
							default:
								RWyjysCImMj2xE7cb7E();
								num2 = (It4bvvCDx99hs27dk1g() ? 1 : 0);
								continue;
							case 6:
								break;
							}
							break;
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						mymkwjCrTwsn8BWCUAk(enumerator);
					}
				}
				break;
			}
			break;
		}
		return pasteBuffer;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dagc5MCihhfOqecdV23(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RWyjysCImMj2xE7cb7E()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool It4bvvCDx99hs27dk1g()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uMHsGQCnFg0tfodUrCs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object A09jYdCVLfSsyBs5RUc(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetCellWithPropertyName((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation Hu8BFgCfs6CLP18AU1k(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.TryParse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IRbYhFCdX8YkdN2OSvP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ucet8AClLkF6BGaMTmX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).ToLower();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XM3KnuCg2dU0fI1LZ9Y(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool o0k9GkCslLqIG1wMQeE(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).StartsWith((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hJlDbOCvuJdLMP6GWQj(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).State = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mymkwjCrTwsn8BWCUAk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}
}
