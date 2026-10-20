using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Controls.ViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.Undo;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public class UndoFormatStringArgumentChanged : IUndoAction
{
	private CommStepViewModel WuhkNOnlkM;

	private Type XM6kA6seOd;

	private int rhZkdsoP9Z;

	private FormatStringArgumentChangedArg KLVk60woau;

	private Type[] BF8kuROpaP;

	[CompilerGenerated]
	private string YxGkFWfxc0;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return YxGkFWfxc0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			YxGkFWfxc0 = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoFormatStringArgumentChanged(CommStepViewModel commAppStep, Type type, FormatStringArgViewModel arg, FormatStringArgumentChangedArg e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (!O8G35H15FhVxmJFxFK0())
		{
			goto IL_001e;
		}
		goto IL_0086;
		IL_001e:
		ckfLhF1afGveQ46rjqw(this);
		num = 11;
		goto IL_0086;
		IL_0086:
		EzFormatStringViewModel ezFormatStringViewModel = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 6:
				throw new NotSupportedException(type.ToString());
			case 9:
				rhZkdsoP9Z = ezFormatStringViewModel.Arguments.IndexOf(arg);
				num = 7;
				continue;
			case 5:
			case 10:
				XM6kA6seOd = type;
				goto case 2;
			default:
				num = 2;
				if (true)
				{
					continue;
				}
				goto case 7;
			case 7:
			{
				string text = arg.LocalizedCellName + (string)zylkBC1e2itUZDr4Eu9(1878) + (string)kn6Biy1O0LYpNh6REDl(e);
				Text = (string)IaENDJ1Dt8hxQg5mDsC(Resources.jG8ti4sE3u(), text, UKjb7Q1IvujUarYSvvg(e), e.NewValue);
				num = 12;
				if (!tQOW421wZnPx3mC91ZE())
				{
					continue;
				}
				goto case 1;
			}
			case 1:
			case 8:
				BF8kuROpaP = new Type[3]
				{
					typeof(WriteDataFtp),
					typeof(WriteDataSerial),
					typeof(WriteTcpIp)
				};
				num = 3;
				continue;
			case 0:
				ezFormatStringViewModel = msckpFgQIx();
				num = 9;
				continue;
			case 11:
				if (BF8kuROpaP.Contains(type))
				{
					WuhkNOnlkM = commAppStep;
					goto case 5;
				}
				num = 6;
				continue;
			case 4:
				b4Py7S1JpUy0l0tbC23();
				_ = 1;
				num = ((!tQOW421wZnPx3mC91ZE()) ? 8 : 10);
				continue;
			case 2:
				KLVk60woau = e;
				num = 0;
				if (true)
				{
					continue;
				}
				return;
			case 12:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)U0EWIt1iBiFJ014GakQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0059;
		IL_0088:
		FormatStringArgViewModel formatStringArgViewModel = default;
		nmFkUIWjXj(formatStringArgViewModel, (string)kn6Biy1O0LYpNh6REDl(KLVk60woau), KLVk60woau.NewValue);
		num = 7;
		goto IL_0059;
		IL_00fd:
		return (Task)U0EWIt1iBiFJ014GakQ();
		IL_0059:
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 2:
			case 5:
				goto IL_0031;
			default:
				num = 3;
				continue;
			case 0:
			case 4:
				goto IL_0088;
			case 1:
				goto IL_00af;
			case 3:
				goto IL_00d5;
			case 7:
				goto IL_00fd;
			}
			break;
			IL_00af:
			if (rhZkdsoP9Z >= 0)
			{
				O8G35H15FhVxmJFxFK0();
				if (!tQOW421wZnPx3mC91ZE())
				{
					num = 5;
					continue;
				}
				num = 0;
				if (!tQOW421wZnPx3mC91ZE())
				{
					continue;
				}
			}
			goto IL_00fd;
		}
		goto IL_001a;
		IL_001a:
		EzFormatStringViewModel ezFormatStringViewModel = msckpFgQIx();
		num = 1;
		if (!O8G35H15FhVxmJFxFK0())
		{
			goto IL_0031;
		}
		goto IL_0059;
		IL_0031:
		if (rhZkdsoP9Z < ezFormatStringViewModel.Arguments.Count)
		{
			goto IL_00d5;
		}
		goto IL_00fd;
		IL_00d5:
		formatStringArgViewModel = ezFormatStringViewModel.Arguments[rhZkdsoP9Z];
		goto IL_0088;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)U0EWIt1iBiFJ014GakQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!tQOW421wZnPx3mC91ZE())
		{
			num = 6;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 5;
			if (false)
			{
				goto IL_00b2;
			}
		}
		goto IL_006a;
		IL_00b2:
		FormatStringArgViewModel formatStringArgViewModel = default;
		nmFkUIWjXj(formatStringArgViewModel, (string)kn6Biy1O0LYpNh6REDl(KLVk60woau), (string)UKjb7Q1IvujUarYSvvg(KLVk60woau));
		num = 7;
		goto IL_006a;
		IL_00f5:
		return Task.CompletedTask;
		IL_0042:
		EzFormatStringViewModel ezFormatStringViewModel = default;
		if (rhZkdsoP9Z < KsveHh1nQsSdM6lRUc7(ezFormatStringViewModel.Arguments))
		{
			goto IL_00d9;
		}
		goto IL_00f5;
		IL_006a:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				break;
			case 2:
				goto IL_0042;
			default:
				num = 4;
				continue;
			case 0:
			case 6:
				ezFormatStringViewModel = msckpFgQIx();
				break;
			case 3:
				goto IL_00b2;
			case 4:
				goto IL_00d9;
			case 7:
				goto IL_00f5;
			}
			break;
		}
		goto IL_0026;
		IL_00d9:
		formatStringArgViewModel = ezFormatStringViewModel.Arguments[rhZkdsoP9Z];
		num = 3;
		goto IL_006a;
		IL_0026:
		if (rhZkdsoP9Z >= 0)
		{
			num = 2;
			if (!O8G35H15FhVxmJFxFK0())
			{
				goto IL_0042;
			}
			goto IL_006a;
		}
		goto IL_00f5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private EzFormatStringViewModel msckpFgQIx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		EzFormatStringViewModel result = default;
		while (true)
		{
			switch (num)
			{
			default:
				num = 4;
				continue;
			case 1:
			case 8:
				if (!(XM6kA6seOd == SNc7Ev1VeD8B8SscP3U(typeof(WriteDataFtp).TypeHandle)))
				{
					if (VTapiF1lxEenHrPXWXZ(XM6kA6seOd, typeof(WriteDataSerial)))
					{
						goto case 4;
					}
					if (XM6kA6seOd == SNc7Ev1VeD8B8SscP3U(typeof(WriteTcpIp).TypeHandle))
					{
						num = 0;
						continue;
					}
					break;
				}
				num = 6;
				continue;
			case 4:
				result = (EzFormatStringViewModel)o4mtH91dhU3spHACyWa(WuhkNOnlkM.WriteDataSerial);
				num = 2;
				continue;
			case 0:
				result = (EzFormatStringViewModel)o4mtH91dhU3spHACyWa(lRW1P41gvgCv9BWaxLT(WuhkNOnlkM));
				num = 9;
				if (!tQOW421wZnPx3mC91ZE())
				{
					continue;
				}
				goto case 5;
			case 5:
				result = null;
				tQOW421wZnPx3mC91ZE();
				num = ((!O8G35H15FhVxmJFxFK0()) ? 7 : 8);
				continue;
			case 6:
				result = (EzFormatStringViewModel)o4mtH91dhU3spHACyWa(Dt6WNS1fCWsuYH8Mb8x(WuhkNOnlkM));
				break;
			case 2:
			case 3:
			case 7:
			case 9:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nmFkUIWjXj(FormatStringArgViewModel P_0, string P_1, string P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 9;
		uint num2 = default;
		FormatStringPadding result = default;
		while (true)
		{
			switch (num)
			{
			case 16:
				return;
			case 14:
				if (num2 != 2991453855u)
				{
					num = 4;
					break;
				}
				if (!(P_1 == (string)zylkBC1e2itUZDr4Eu9(29914)))
				{
					return;
				}
				P_0.IncludeLabel = hEY1jJ1rA5av952XGrH(P_2);
				num = 20;
				break;
			case 6:
				QA9mbo1o8avRgrXnhwQ(P_0, result);
				num = 21;
				break;
			case 5:
				return;
			case 13:
				return;
			case 17:
				if (num2 != 1519477720)
				{
					return;
				}
				if (VPGB4O1suxah5gX8tGJ(P_1, zylkBC1e2itUZDr4Eu9(29956)))
				{
					iRdOQr1G9gFjN1CM9PC(P_0, e6cGKD1ZGxIdICyqcQk(P_2));
					num = 15;
				}
				else
				{
					num = 1;
				}
				break;
			case 11:
				if (num2 != 121036118)
				{
					_ = 1;
					num = (tQOW421wZnPx3mC91ZE() ? 13 : 0);
				}
				else if (P_1 == CdQUGaROfy7He9T0foW.KbIzwHEDLa(29990))
				{
					Enum.TryParse<FormatStringPadding>(P_2, out result);
					num = 6;
					if (!O8G35H15FhVxmJFxFK0())
					{
						return;
					}
				}
				else
				{
					num = 2;
				}
				break;
			case 4:
				return;
			case 7:
				return;
			case 19:
				return;
			case 8:
				return;
			default:
				num = 16;
				break;
			case 15:
				return;
			case 12:
				return;
			case 9:
				num2 = _003CPrivateImplementationDetails_003E.ComputeStringHash(P_1);
				num = 10;
				if (!O8G35H15FhVxmJFxFK0())
				{
					return;
				}
				break;
			case 18:
				return;
			case 0:
			case 3:
				if (num2 == 1401311868)
				{
					if (P_1 == (string)zylkBC1e2itUZDr4Eu9(29832))
					{
						uL2oKE1vUQghvjx0NMO(P_0, int.Parse(P_2));
					}
					return;
				}
				num = 17;
				if (0 == 0)
				{
					break;
				}
				goto case 10;
			case 10:
				if (num2 > 1519477720)
				{
					if (num2 > 2664231581u)
					{
						if (num2 != 2981129609u)
						{
							num = 14;
							break;
						}
						if (VPGB4O1suxah5gX8tGJ(P_1, zylkBC1e2itUZDr4Eu9(29890)))
						{
							UZNNnN1B7egsVQZophZ(P_0, e6cGKD1ZGxIdICyqcQk(P_2));
							return;
						}
						num = 8;
						break;
					}
					switch (num2)
					{
					case 2664231581u:
						if (!(P_1 == CdQUGaROfy7He9T0foW.KbIzwHEDLa(29942)))
						{
							num = 18;
							break;
						}
						O4cNaY1b8bp3vbqCrWx(P_0, P_2);
						num = 12;
						break;
					default:
						return;
					case 1592638979u:
						if (!VPGB4O1suxah5gX8tGJ(P_1, zylkBC1e2itUZDr4Eu9(29862)))
						{
							num = 19;
							break;
						}
						trtsYa1PpYfr8hiRkNE(P_0, hEY1jJ1rA5av952XGrH(P_2));
						num = 7;
						if (0 == 0)
						{
							break;
						}
						return;
					}
				}
				else
				{
					num = 11;
				}
				break;
			case 2:
				return;
			case 20:
				return;
			case 1:
				return;
			case 21:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void b4Py7S1JpUy0l0tbC23()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ckfLhF1afGveQ46rjqw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zylkBC1e2itUZDr4Eu9(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kn6Biy1O0LYpNh6REDl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FormatStringArgumentChangedArg)P_0).PropertyName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UKjb7Q1IvujUarYSvvg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FormatStringArgumentChangedArg)P_0).PreviousValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IaENDJ1Dt8hxQg5mDsC(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool O8G35H15FhVxmJFxFK0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tQOW421wZnPx3mC91ZE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object U0EWIt1iBiFJ014GakQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int KsveHh1nQsSdM6lRUc7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Collection<FormatStringArgViewModel>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type SNc7Ev1VeD8B8SscP3U(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Dt6WNS1fCWsuYH8Mb8x(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CommStepViewModel)P_0).WriteDataFtp;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object o4mtH91dhU3spHACyWa(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzFormatStringSupportSnippet)P_0).FormatString;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VTapiF1lxEenHrPXWXZ(Type P_0, Type P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lRW1P41gvgCv9BWaxLT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CommStepViewModel)P_0).WriteTcpIp;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VPGB4O1suxah5gX8tGJ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uL2oKE1vUQghvjx0NMO(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((FormatStringArgViewModel)P_0).DecimalPlaces = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hEY1jJ1rA5av952XGrH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return bool.Parse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void trtsYa1PpYfr8hiRkNE(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((FormatStringArgViewModel)P_0).IsFixedWidth = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int e6cGKD1ZGxIdICyqcQk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return int.Parse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UZNNnN1B7egsVQZophZ(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((FormatStringArgViewModel)P_0).FieldWidth = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void O4cNaY1b8bp3vbqCrWx(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((FormatStringArgViewModel)P_0).Label = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iRdOQr1G9gFjN1CM9PC(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((FormatStringArgViewModel)P_0).MaxStringLength = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QA9mbo1o8avRgrXnhwQ(object P_0, FormatStringPadding P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((FormatStringArgViewModel)P_0).Padding = P_1;
	}
}
