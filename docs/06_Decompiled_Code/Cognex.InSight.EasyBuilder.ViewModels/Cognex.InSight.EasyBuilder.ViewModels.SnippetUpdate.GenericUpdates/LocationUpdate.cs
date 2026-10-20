using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Internal;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate.GenericUpdates;

public class LocationUpdate : ISnippetUpdate
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<CvsParseTokenRange, bool> _003C_003E9__11_0;

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
			gUYRFY5vmY4uHkNFxThI();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CReplaceLocationInExpression_003Eb__11_0(CvsParseTokenRange tr)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (tr.IsValid && twERod5vQdDvhp5rvNt4(tr.Type, CdQUGaROfy7He9T0foW.KbIzwHEDLa(22264)))
			{
				return tr.Text != null;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Cbh0tL5vHmZwOIiRuNPT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DxsRA65vxOrj2RUGQB7B()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gUYRFY5vmY4uHkNFxThI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool twERod5vQdDvhp5rvNt4(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}
	}

	private readonly CvsCellLocation n6xGRRqBOS;

	private readonly CvsCellLocation Q5sG43uWZn;

	private readonly CvsCellLocation Tq7GlYg6B1;

	private readonly Func<PasteBuffer, string> gtCGTwXdoS;

	private readonly Func<PasteBuffer, CvsCellLocation, string> K1WGWfXGLG;

	private readonly CvsFunctionTable n2IGjqhahD;

	private readonly IExpressionConstants Q81GCnhYWL;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LocationUpdate(CvsCellLocation cellToEditOffset, CvsCellLocation locationToReplaceOffset, Func<PasteBuffer, string> replacementFactory, CvsFunctionTable table, IExpressionConstants constants)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		base._002Ector();
		n6xGRRqBOS = cellToEditOffset;
		Q5sG43uWZn = locationToReplaceOffset;
		gtCGTwXdoS = replacementFactory;
		n2IGjqhahD = table;
		Q81GCnhYWL = constants;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LocationUpdate(CvsCellLocation cellToEditOffset, CvsCellLocation locationToReplaceOffset, Func<PasteBuffer, CvsCellLocation, string> replacementFactory, CvsCellLocation replacementFactoryCellOffset, CvsFunctionTable table, IExpressionConstants constants)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		base._002Ector();
		n6xGRRqBOS = cellToEditOffset;
		Q5sG43uWZn = locationToReplaceOffset;
		K1WGWfXGLG = replacementFactory;
		Tq7GlYg6B1 = replacementFactoryCellOffset;
		n2IGjqhahD = table;
		Q81GCnhYWL = constants;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PasteBuffer Apply(PasteBuffer originalSnippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0051;
		IL_001a:
		PasteBuffer pasteBuffer = (PasteBuffer)KPNMl8KLZqjYBW7NX1bJ(originalSnippet);
		_ = 0;
		num = (L1BhMFKLrxVVJDbfr5ln() ? 3 : 0);
		goto IL_0051;
		IL_0051:
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 1:
			case 3:
				text = UJ2GMnhdXd(pasteBuffer);
				goto IL_007e;
			default:
				goto IL_007e;
			case 5:
				return pasteBuffer;
			}
			break;
			IL_007e:
			pasteBuffer = (PasteBuffer)vySfw8KLBgWXdSYVBdKD(pasteBuffer, n2IGjqhahD, Q81GCnhYWL, n6xGRRqBOS, Q5sG43uWZn, text);
			num = 5;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static PasteBuffer ReplaceLocationInExpression(PasteBuffer originalSnippet, CvsFunctionTable table, IExpressionConstants constants, CvsCellLocation cellToEditOffset, CvsCellLocation locationToReplaceOffset, string replacement)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		object obj = KPNMl8KLZqjYBW7NX1bJ(originalSnippet);
		PasteBufferCell pasteBufferCell = (PasteBufferCell)zXbxKOKLbu1FVMRcQNo4(obj, cellToEditOffset);
		CvsCellLocation locationToReplace = oIqpnPKLG8qWTsEievav(obj, locationToReplaceOffset);
		CvsParse cvsParse = CvsParse.Parse(table, constants, pasteBufferCell.Expression, ((string)hKdTtvKLofxMlHjb3eND(pasteBufferCell)).Length);
		pasteBufferCell.Expression = (string)t3sS8rKLSU6hLGFsl9ki(cvsParse, locationToReplace, replacement);
		return (PasteBuffer)obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ReplaceLocationInExpression(CvsParse parse, CvsCellLocation locationToReplace, string replacement)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!afpBTQKLPrc5mGl7a8vO())
		{
			num = 2;
			if (afpBTQKLPrc5mGl7a8vO())
			{
			}
		}
		else
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_00af;
			}
		}
		IEnumerator<CvsParseTokenRange> enumerator = default;
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				enumerator = ((IEnumerable<CvsParseTokenRange>)ErYEoQKLkjHaq0xtGeXP(parse)).Where([MethodImpl(MethodImplOptions.NoInlining)] (CvsParseTokenRange tr) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return tr.IsValid && _003C_003Ec.twERod5vQdDvhp5rvNt4(tr.Type, CdQUGaROfy7He9T0foW.KbIzwHEDLa(22264)) && tr.Text != null;
				}).GetEnumerator();
				break;
			default:
				goto IL_008c;
			case 0:
			case 2:
				text = parse.Expression;
				goto case 1;
			case 4:
				break;
			}
			break;
			IL_008c:
			num = 4;
		}
		goto IL_00af;
		IL_00af:
		try
		{
			string text5 = default;
			string text6 = default;
			string text7 = default;
			string text3 = default;
			string text4 = default;
			int num6 = default;
			CvsCellLocation cvsCellLocation2 = default;
			string text2 = default;
			while (Ml6lseKL7IXOZOVvYNA6(enumerator))
			{
				CvsParseTokenRange current = enumerator.Current;
				int num2 = text.Length - parse.Expression.Length;
				int num3 = current.Start + num2;
				int num4 = current.End + num2;
				string[] array = (string[])wSrLURKL8uvcvm0WAG6T(current.Text, new char[1] { ':' });
				int num5 = 9;
				while (true)
				{
					switch (num5)
					{
					case 4:
						text = text5 + replacement + text6;
						num5 = 14;
						continue;
					case 13:
						text7 = text.Substring(num4);
						num5 = 11;
						continue;
					case 3:
					case 6:
						text3 = (string)Xmwg4LKLEq0mX3juSevS(text, 0, num3);
						num5 = 2;
						if (true)
						{
							continue;
						}
						goto case 7;
					case 7:
						text4 = text.Substring(0, num6 + 1);
						num5 = 13;
						if (0 == 0)
						{
							continue;
						}
						goto case 9;
					case 9:
						cvsCellLocation2 = CvsCellLocation.TryParse(array[0]);
						num5 = 10;
						if (0 == 0)
						{
							continue;
						}
						goto case 5;
					case 5:
					case 8:
						text = (string)mJDcXVKLXwLBDUC8aiWD(text3, replacement, text2);
						break;
					default:
						num5 = 7;
						continue;
					case 11:
						text = (string)mJDcXVKLXwLBDUC8aiWD(text4, replacement, text7);
						num5 = 1;
						continue;
					case 0:
						if (js4gV7KLqekxp8PIbBdw(cvsCellLocation2, locationToReplace))
						{
							afpBTQKLPrc5mGl7a8vO();
							num5 = ((!L1BhMFKLrxVVJDbfr5ln()) ? 8 : 6);
							continue;
						}
						break;
					case 1:
						if (!js4gV7KLqekxp8PIbBdw(cvsCellLocation2, locationToReplace))
						{
							break;
						}
						text5 = (string)Xmwg4LKLEq0mX3juSevS(text, 0, num3);
						num5 = 12;
						if (0 == 0)
						{
							continue;
						}
						goto case 12;
					case 12:
						text6 = (string)ku1ynBKLpFsNMJDYH6cH(text, num6);
						num5 = 4;
						continue;
					case 10:
						if (array.Length != 1)
						{
							CvsCellLocation cvsCellLocation = gCkTw4KL9UDvvV2JAq9O(array[1]);
							num6 = num3 + o4wQTyKL4Z4GWQwAwiwC(array[0]);
							if (js4gV7KLqekxp8PIbBdw(cvsCellLocation, locationToReplace))
							{
								goto case 7;
							}
							goto case 1;
						}
						num5 = 0;
						continue;
					case 2:
						text2 = (string)ku1ynBKLpFsNMJDYH6cH(text, num4);
						goto case 5;
					case 14:
						break;
					}
					break;
				}
			}
			return text;
		}
		finally
		{
			enumerator?.Dispose();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string UJ2GMnhdXd(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return K1WGWfXGLG?.Invoke(P_0, Tq7GlYg6B1) ?? gtCGTwXdoS(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KPNMl8KLZqjYBW7NX1bJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vySfw8KLBgWXdSYVBdKD(object P_0, object P_1, object P_2, CvsCellLocation cellToEditOffset, CvsCellLocation locationToReplaceOffset, object P_5)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ReplaceLocationInExpression((PasteBuffer)P_0, (CvsFunctionTable)P_1, (IExpressionConstants)P_2, cellToEditOffset, locationToReplaceOffset, (string)P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool L1BhMFKLrxVVJDbfr5ln()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool afpBTQKLPrc5mGl7a8vO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zXbxKOKLbu1FVMRcQNo4(object P_0, CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetCellWithOffset(offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation oIqpnPKLG8qWTsEievav(object P_0, CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetLocationFromOrigin(offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hKdTtvKLofxMlHjb3eND(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBufferCell)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object t3sS8rKLSU6hLGFsl9ki(object P_0, CvsCellLocation locationToReplace, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ReplaceLocationInExpression((CvsParse)P_0, locationToReplace, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ErYEoQKLkjHaq0xtGeXP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsParse)P_0).TokenRanges;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wSrLURKL8uvcvm0WAG6T(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Split((char[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool js4gV7KLqekxp8PIbBdw(CvsCellLocation P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Xmwg4LKLEq0mX3juSevS(object P_0, int P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Substring(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ku1ynBKLpFsNMJDYH6cH(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Substring(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mJDcXVKLXwLBDUC8aiWD(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation gCkTw4KL9UDvvV2JAq9O(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.TryParse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int o4wQTyKL4Z4GWQwAwiwC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Ml6lseKL7IXOZOVvYNA6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}
}
