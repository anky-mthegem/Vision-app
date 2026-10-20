using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Designer.Utils;
using Cognex.InSight;
using Cognex.InSight.EasyBuilder.ViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.Internal;
using Newtonsoft.Json.Linq;
using zsQqWwRgKaAshfKAktM;

namespace oF2MOjpuTE9ryB96aX;

internal class AXWGRD6PhpEZe2JbB8 : ISnippetUpdate
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public string toolName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass7_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NLFTEr5vcdq6dOLmGYra();
			mbSghq5v1K0A8oKaxTsU(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CUpdateSnippetName_003Eb__1(PasteBufferCell cell)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			string text = default;
			bool flag = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					return;
				case 6:
				case 8:
					s3212B5r5xgoS0RV2ZSe(cell, EzSnippet.AssembleFullCellName(toolName, text, flag));
					num = 9;
					break;
				case 4:
					text = (string)iEdCrj5vu7YUnpMGJVWg(cell);
					_ = 0;
					if (SxxkUH5vNgqOiomgufOh())
					{
						num = 7;
						if (UA4uyi5v2PTQb2NohdYy())
						{
						}
					}
					else
					{
						num = 8;
					}
					break;
				case 1:
				case 7:
					if (text != null)
					{
						if (oaV2Ts5vhkQg5QdDEXq2(text, ""))
						{
							num = 0;
							if (UA4uyi5v2PTQb2NohdYy())
							{
							}
							break;
						}
						return;
					}
					num = 3;
					if (true)
					{
						break;
					}
					goto case 0;
				case 0:
					flag = V4Pcxh5vzxh2T6U38CdZ(text, La4nfL5vtbwdqp4vHknV(1044), StringComparison.Ordinal);
					goto case 5;
				default:
					num = 5;
					break;
				case 5:
					if (!flag)
					{
						goto case 6;
					}
					num = 2;
					if (SxxkUH5vNgqOiomgufOh())
					{
						break;
					}
					goto case 2;
				case 2:
					text = (string)zN6lXf5rKsjjmDP6uQqF(text, TvDlY45rLtuFkwZbmGbl(La4nfL5vtbwdqp4vHknV(1044)));
					goto case 6;
				case 9:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NLFTEr5vcdq6dOLmGYra()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void mbSghq5v1K0A8oKaxTsU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SxxkUH5vNgqOiomgufOh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UA4uyi5v2PTQb2NohdYy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iEdCrj5vu7YUnpMGJVWg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oaV2Ts5vhkQg5QdDEXq2(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 != (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object La4nfL5vtbwdqp4vHknV(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool V4Pcxh5vzxh2T6U38CdZ(object P_0, object P_1, StringComparison P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).StartsWith((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int TvDlY45rLtuFkwZbmGbl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zN6lXf5rKsjjmDP6uQqF(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Substring(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void s3212B5r5xgoS0RV2ZSe(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((PasteBufferCell)P_0).Name = (string)P_1;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<PasteBufferCell, bool> _003C_003E9__7_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			k0ENl45ra3tbrCPiMlJR();
			kE4wDj5re4MFh1niSNY9(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CUpdateSnippetName_003Eb__7_0(PasteBufferCell c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (c.Name != null)
			{
				return wjuCpT5rDvt14jpoIkm0(HXwN9j5rOeOt7K96F90H(c), PmADMw5rIpQHsfI13pU9(1188)) != -1;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aKU64J5rwsjE1fiAGGml()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fUR0vC5rJbZR8FVmIbFx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void k0ENl45ra3tbrCPiMlJR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void kE4wDj5re4MFh1niSNY9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HXwN9j5rOeOt7K96F90H(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PmADMw5rIpQHsfI13pU9(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int wjuCpT5rDvt14jpoIkm0(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).LastIndexOf((string)P_1);
		}
	}

	private static string[] YAxGyr4A0y;

	private CvsFunctionTable qmlGxPxvBd;

	private IExpressionConstants bkyGv0P4Yy;

	private PasteBuffer DJoGeDxeRy;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AXWGRD6PhpEZe2JbB8(PasteBuffer P_0, CvsFunctionTable P_1, IExpressionConstants P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		while (true)
		{
			switch (num)
			{
			case 6:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 1;
				break;
			case 1:
				q9oZM3KLTQy6Vq7SvhFQ(this);
				num = 2;
				break;
			case 2:
				DJoGeDxeRy = P_0;
				goto default;
			default:
				seaLIxKLR9xGrWFaVSw0();
				if (!WoITjlKLW78NHwnKreqE())
				{
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				}
				num = 0;
				if (WoITjlKLW78NHwnKreqE())
				{
				}
				break;
			case 0:
			case 4:
				bkyGv0P4Yy = P_2;
				num = 7;
				break;
			case 3:
			case 5:
				qmlGxPxvBd = P_1;
				goto case 0;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PasteBuffer Apply(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = (seaLIxKLR9xGrWFaVSw0() ? 1 : 5);
		PasteBuffer pasteBuffer = default;
		bool flag = default;
		IEnumerator<PasteBufferCell> enumerator = default;
		string text = default;
		string[] array = default;
		PasteBufferCell cellWithFunction = default;
		string text2 = default;
		string text3 = default;
		CvsCellLocation cvsCellLocation = default;
		PasteBufferCell pasteBufferCell = default;
		List<string> list = default;
		string text4 = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				pasteBuffer = (PasteBuffer)CU3gjcKLyttc31ojlsik(DJoGeDxeRy);
				num = 2;
				break;
			case 2:
				flag = false;
				num = 4;
				break;
			default:
				enumerator = P_0.Cells.GetEnumerator();
				num = 6;
				break;
			case 6:
				try
				{
					while (sXPBcDKKLVuhZePu1ZEc(enumerator))
					{
						PasteBufferCell current = enumerator.Current;
						int num2 = 17;
						while (true)
						{
							switch (num2)
							{
							case 10:
								text = array[0];
								num2 = 20;
								continue;
							case 18:
								if (cellWithFunction != null)
								{
									num2 = 22;
									continue;
								}
								break;
							case 23:
								cellWithFunction.Data = (JToken)Yr3JJ5KLhDe0rqo9vpod(current);
								num2 = 14;
								continue;
							case 8:
								if (vIc0ooKLxeDxyOsDx5l4(array[1]))
								{
									break;
								}
								goto default;
							case 0:
								if (O4xm8TKLQoACVYoLNGD4(text2, text3))
								{
									cvsCellLocation = U0yZxrKL2MYWghFH1yUa(cUZTxIKLNIsYH5W1y2GE(pasteBufferCell));
									cvsCellLocation.Row += P_0.Range.Row - ARm3QbKLc9udF1hkPrJZ(pasteBuffer).Row;
									num2 = 2;
									continue;
								}
								break;
							case 14:
								list.Add(text2);
								num2 = 24;
								if (WoITjlKLW78NHwnKreqE())
								{
								}
								continue;
							case 1:
								if (!YAxGyr4A0y.Contains(text2, StringComparer.OrdinalIgnoreCase))
								{
									break;
								}
								num2 = 13;
								if (seaLIxKLR9xGrWFaVSw0())
								{
									continue;
								}
								goto case 17;
							case 17:
								text2 = CvsParse.FindIdentifier((string)i6CYgwKL0GTS0fbccA7R(current));
								num2 = 1;
								continue;
							case 5:
								flag = true;
								num2 = 8;
								continue;
							case 12:
								array = (string[])v9NIxFKLMHqoglZY1ksL(text4, new char[1] { '.' });
								if (array.Length == 2)
								{
									num2 = 10;
									continue;
								}
								break;
							case 6:
								((JToken)Yr3JJ5KLhDe0rqo9vpod(pasteBufferCell))[IthPeLKLYiyl1ewSRjKB(1524)] = (JToken?)gFBJYfKLtHTuPdGeQX91(Yr3JJ5KLhDe0rqo9vpod(current), IthPeLKLYiyl1ewSRjKB(1524));
								goto case 21;
							case 21:
								sDLOrDKLzH4kBLKYpk0u(pasteBufferCell, text4);
								break;
							default:
								pasteBufferCell = (PasteBufferCell)YxouLpKLmqWNDyq7gsQm(pasteBuffer, text4);
								num2 = 3;
								continue;
							case 16:
								if (flag)
								{
									goto case 8;
								}
								T5xGwqDjFW(pasteBuffer, text);
								num2 = 5;
								if (seaLIxKLR9xGrWFaVSw0())
								{
									continue;
								}
								goto case 7;
							case 7:
							case 19:
								text = (string)p2r4IWKLHktdB488eekI(text, 1);
								num2 = 16;
								continue;
							case 22:
								cellWithFunction.Value = (JToken)cUWL4WKL1MsmI7nSXvkN(current);
								num2 = 23;
								if (seaLIxKLR9xGrWFaVSw0())
								{
									continue;
								}
								goto case 9;
							case 9:
								if (!O4xm8TKLQoACVYoLNGD4(text2, CdQUGaROfy7He9T0foW.KbIzwHEDLa(1450)))
								{
									pasteBufferCell.Data = current.Data;
									num2 = 21;
								}
								else
								{
									num2 = 6;
								}
								continue;
							case 20:
								if (!m8jmDgKLUBR6Kc7xhh5r(text, IthPeLKLYiyl1ewSRjKB(1044)))
								{
									goto case 16;
								}
								_ = 1;
								if (WoITjlKLW78NHwnKreqE())
								{
									num2 = 4;
									continue;
								}
								num2 = 19;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
								cvsCellLocation.Column += ARm3QbKLc9udF1hkPrJZ(P_0).Column - ARm3QbKLc9udF1hkPrJZ(pasteBuffer).Column;
								n2uvXaKLuwSkwHtJVSCS(pasteBufferCell, cUWL4WKL1MsmI7nSXvkN(current));
								num2 = 9;
								if (true)
								{
									continue;
								}
								goto case 3;
							case 3:
								if (pasteBufferCell == null)
								{
									break;
								}
								text3 = CvsParse.FindIdentifier((string)i6CYgwKL0GTS0fbccA7R(current));
								num2 = 0;
								if (seaLIxKLR9xGrWFaVSw0())
								{
									continue;
								}
								goto case 15;
							case 15:
								if (string.IsNullOrEmpty(text4))
								{
									cellWithFunction = pasteBuffer.GetCellWithFunction(text2);
									num2 = 18;
									continue;
								}
								num2 = 12;
								if (seaLIxKLR9xGrWFaVSw0())
								{
									continue;
								}
								goto case 13;
							case 13:
								text4 = (string)BmYw2rKLF1RoR52VgxSw(current);
								num2 = 15;
								continue;
							case 24:
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
						g56V1WKKKQqjj0yb6ZYf(enumerator);
					}
				}
				t3mGHNCF09(P_0, pasteBuffer);
				num = 7;
				if (seaLIxKLR9xGrWFaVSw0())
				{
					break;
				}
				goto case 4;
			case 4:
				list = new List<string>();
				goto default;
			case 7:
				return pasteBuffer;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void t3mGHNCF09(PasteBuffer P_0, PasteBuffer P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_007c;
		IL_001a:
		eP7htdKKwNs0SZ9hQ5Uk(P_1, Or68hKKK5MswwnIKEGC7(P_0), qmlGxPxvBd, bkyGv0P4Yy);
		_ = 0;
		num = (seaLIxKLR9xGrWFaVSw0() ? 5 : 0);
		goto IL_007c;
		IL_007c:
		CvsCellRange cvsCellRange2 = default;
		CvsCellRange range = default;
		IEnumerator<PasteBufferCell> enumerator = default;
		CvsCellRange cvsCellRange = default;
		CellRefRange cellRefRange = default;
		int num3 = default;
		bool flag = default;
		PasteBufferCell pasteBufferCell = default;
		string text = default;
		CellRefRange[] array = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 1:
			case 5:
				cvsCellRange2 = ARm3QbKLc9udF1hkPrJZ(P_0);
				num = 4;
				continue;
			case 4:
				range = new CvsCellRange((string)IthPeLKLYiyl1ewSRjKB(33650));
				goto default;
			default:
				enumerator = P_0.Cells.GetEnumerator();
				num = 6;
				continue;
			case 6:
				try
				{
					while (sXPBcDKKLVuhZePu1ZEc(enumerator))
					{
						PasteBufferCell current = enumerator.Current;
						int num2 = 14;
						while (true)
						{
							switch (num2)
							{
							case 6:
								if (!cvsCellRange.Equals(range) && !cvsCellRange2.Contains(cellRefRange.Range))
								{
									goto case 0;
								}
								num3++;
								goto case 10;
							default:
								num2 = 0;
								continue;
							case 1:
							case 9:
								if (flag)
								{
									pasteBufferCell = (PasteBufferCell)YxouLpKLmqWNDyq7gsQm(P_1, current.Name);
									num2 = 3;
									continue;
								}
								break;
							case 14:
								if (vIc0ooKLxeDxyOsDx5l4(BmYw2rKLF1RoR52VgxSw(current)))
								{
									break;
								}
								num2 = 15;
								if (0 == 0)
								{
									continue;
								}
								goto case 8;
							case 8:
								if (zTxEmKKKObJyboQJqbDT(pasteBufferCell.Expression, text))
								{
									num2 = 12;
									continue;
								}
								break;
							case 4:
								cvsCellRange = zvnfMGKKeZlZMiC0ifxS(cellRefRange);
								num2 = 6;
								if (0 == 0)
								{
									continue;
								}
								goto case 12;
							case 12:
								HHSZ7aKKIuTn5m4vJr3h(pasteBufferCell, text);
								num2 = 17;
								continue;
							case 3:
								if (pasteBufferCell != null)
								{
									num2 = 8;
									continue;
								}
								break;
							case 2:
							case 5:
								flag = false;
								num2 = 7;
								continue;
							case 7:
								array = (CellRefRange[])fDaG2SKKapiw5o8a9dSc(CvsParse.Parse(qmlGxPxvBd, bkyGv0P4Yy, text, j5gKX6KKJgk4PoQh5tEW(text)));
								num2 = 13;
								continue;
							case 10:
							case 11:
							case 16:
								if (num3 < array.Length)
								{
									cellRefRange = array[num3];
									num2 = 4;
								}
								else
								{
									num2 = 1;
								}
								continue;
							case 0:
								flag = true;
								num2 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 15;
							case 15:
								text = (string)i6CYgwKL0GTS0fbccA7R(current);
								if (!U0yZxrKL2MYWghFH1yUa(cUZTxIKLNIsYH5W1y2GE(current)).IsValid)
								{
									break;
								}
								_ = 0;
								if (seaLIxKLR9xGrWFaVSw0())
								{
									num2 = 5;
									if (0 == 0)
									{
										continue;
									}
									goto case 13;
								}
								num2 = 11;
								continue;
							case 13:
								num3 = 0;
								num2 = 16;
								continue;
							case 17:
								break;
							}
							break;
						}
					}
					return;
				}
				finally
				{
					if (enumerator != null)
					{
						g56V1WKKKQqjj0yb6ZYf(enumerator);
					}
				}
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void T5xGwqDjFW(PasteBuffer P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		seaLIxKLR9xGrWFaVSw0();
		int num;
		if (!WoITjlKLW78NHwnKreqE())
		{
			num = 1;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_00e3;
		IL_002a:
		_003C_003Ec__DisplayClass7_0 obj = new _003C_003Ec__DisplayClass7_0();
		num = 5;
		goto IL_00e3;
		IL_00e3:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				break;
			case 5:
				obj.toolName = P_1;
				goto case 2;
			case 4:
				P_0.Cells.ForEach(obj._003CUpdateSnippetName_003Eb__1);
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 2;
			case 2:
			case 3:
			{
				PasteBufferCell pasteBufferCell = P_0.Cells.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (PasteBufferCell c) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return c.Name != null && _003C_003Ec.wjuCpT5rDvt14jpoIkm0(_003C_003Ec.HXwN9j5rOeOt7K96F90H(c), _003C_003Ec.PmADMw5rIpQHsfI13pU9(1188)) != -1;
				});
				n2uvXaKLuwSkwHtJVSCS(pasteBufferCell, UNlbFtKKDVo2k8RBJqUI(obj.toolName));
				MG04V6KKiuJoRCixbjck(pasteBufferCell.Data, IthPeLKLYiyl1ewSRjKB(1524), (JToken)obj.toolName);
				goto case 4;
			}
			default:
				num = 4;
				continue;
			case 6:
				return;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AXWGRD6PhpEZe2JbB8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		YrZ2F7KKnCRom2XlRgOG();
		YAxGyr4A0y = new string[15]
		{
			(string)IthPeLKLYiyl1ewSRjKB(33658),
			(string)IthPeLKLYiyl1ewSRjKB(33688),
			(string)IthPeLKLYiyl1ewSRjKB(33708),
			(string)IthPeLKLYiyl1ewSRjKB(33738),
			(string)IthPeLKLYiyl1ewSRjKB(33756),
			(string)IthPeLKLYiyl1ewSRjKB(33778),
			CdQUGaROfy7He9T0foW.KbIzwHEDLa(33804),
			(string)IthPeLKLYiyl1ewSRjKB(33846),
			(string)IthPeLKLYiyl1ewSRjKB(1450),
			(string)IthPeLKLYiyl1ewSRjKB(33870),
			(string)IthPeLKLYiyl1ewSRjKB(33894),
			(string)IthPeLKLYiyl1ewSRjKB(33912),
			(string)IthPeLKLYiyl1ewSRjKB(3014),
			(string)IthPeLKLYiyl1ewSRjKB(3046),
			CdQUGaROfy7He9T0foW.KbIzwHEDLa(33952)
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void q9oZM3KLTQy6Vq7SvhFQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool seaLIxKLR9xGrWFaVSw0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WoITjlKLW78NHwnKreqE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CU3gjcKLyttc31ojlsik(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object i6CYgwKL0GTS0fbccA7R(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BmYw2rKLF1RoR52VgxSw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object v9NIxFKLMHqoglZY1ksL(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Split((char[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IthPeLKLYiyl1ewSRjKB(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool m8jmDgKLUBR6Kc7xhh5r(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).StartsWith((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object p2r4IWKLHktdB488eekI(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Substring(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vIc0ooKLxeDxyOsDx5l4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YxouLpKLmqWNDyq7gsQm(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetCellWithName((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool O4xm8TKLQoACVYoLNGD4(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cUZTxIKLNIsYH5W1y2GE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation U0yZxrKL2MYWghFH1yUa(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.TryParse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellRange ARm3QbKLc9udF1hkPrJZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Range;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cUWL4WKL1MsmI7nSXvkN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void n2uvXaKLuwSkwHtJVSCS(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Value = (JToken)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Yr3JJ5KLhDe0rqo9vpod(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Data;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gFBJYfKLtHTuPdGeQX91(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((JToken)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sDLOrDKLzH4kBLKYpk0u(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sXPBcDKKLVuhZePu1ZEc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void g56V1WKKKQqjj0yb6ZYf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation Or68hKKK5MswwnIKEGC7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Origin;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eP7htdKKwNs0SZ9hQ5Uk(object P_0, CvsCellLocation upperLeftLocation, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBuffer)P_0).Relocate(upperLeftLocation, (CvsFunctionTable)P_2, (IExpressionConstants)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int j5gKX6KKJgk4PoQh5tEW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fDaG2SKKapiw5o8a9dSc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsParse)P_0).CellReferences;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellRange zvnfMGKKeZlZMiC0ifxS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsReferenceRange)P_0).Range;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zTxEmKKKObJyboQJqbDT(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 != (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HHSZ7aKKIuTn5m4vJr3h(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Expression = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UNlbFtKKDVo2k8RBJqUI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)(string?)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MG04V6KKiuJoRCixbjck(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((JToken)P_0)[P_1] = (JToken?)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YrZ2F7KKnCRom2XlRgOG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}
}
