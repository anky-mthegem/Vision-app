using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;

public static class DynamicThresholdCalculator
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDynamicallyThresholdTool_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocketSheet sheet;

		public CvsCellLocation passFailLocation;

		public int lowerBound;

		public EditIntViewModel threshSelect;

		public int decrement;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CIDh3tKol032wj6efKSW();
			int num = (pVR93YKogvhmU0U7O15e() ? 2 : 4);
			int num2 = default;
			TaskAwaiter<CvsCellCollection> awaiter = default;
			bool flag = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					_003C_003Et__builder.SetResult();
					num = 5;
					break;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 3;
								if (false)
								{
									goto IL_006d;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 0;
								if (false)
								{
									goto IL_00b2;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 11;
							if (1 == 0)
							{
								goto IL_0317;
							}
						}
						goto IL_0278;
						IL_00d0:
						_003C_003Eu__1 = awaiter;
						num3 = 18;
						if (1 == 0)
						{
							goto IL_00e3;
						}
						goto IL_0278;
						IL_00b2:
						awaiter = sheet.RunAndGetCellResults().GetAwaiter();
						num3 = 17;
						if (1 == 0)
						{
							goto IL_00d0;
						}
						goto IL_0278;
						IL_0317:
						threshSelect.Value = ilRKZRKorXTpPcqkTf0r(lowerBound, threshSelect.Value);
						goto end_IL_0054;
						IL_00e3:
						_003C_003Eu__1 = default;
						num3 = 7;
						goto IL_0278;
						IL_006d:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 2;
						goto IL_0278;
						IL_0278:
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							case 15:
								return;
							case 3:
								goto IL_00b2;
							case 13:
								goto IL_00d0;
							case 11:
								goto IL_00e3;
							case 0:
								flag = lGGQtOKovIoIaqGXsa4d(oZ17dxKos2EXC62HewOf(awaiter.GetResult(), passFailLocation)).Equals(1.0);
								num3 = 5;
								if (true)
								{
									continue;
								}
								goto case 7;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 6;
								if (CIDh3tKol032wj6efKSW())
								{
									continue;
								}
								goto case 8;
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 14:
								if (awaiter.IsCompleted)
								{
									goto case 0;
								}
								num2 = (_003C_003E1__state = 1);
								num3 = 13;
								if (0 == 0)
								{
									continue;
								}
								goto case 5;
							case 5:
							case 12:
								if (threshSelect.Value > lowerBound)
								{
									goto case 4;
								}
								goto IL_0317;
							case 17:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 8;
									continue;
								}
								goto case 6;
							case 18:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 15;
								if (0 == 0)
								{
									continue;
								}
								goto case 9;
							case 9:
							case 10:
								awaiter = sheet.RunAndGetCellResults().GetAwaiter();
								num3 = 14;
								if (true)
								{
									continue;
								}
								goto case 6;
							case 6:
								flag = awaiter.GetResult()[passFailLocation].CellValue.Equals(1.0);
								lowerBound = Math.Max(lowerBound, threshSelect.Min);
								num3 = 12;
								continue;
							default:
								CIDh3tKol032wj6efKSW();
								if (pVR93YKogvhmU0U7O15e())
								{
									num3 = 4;
									continue;
								}
								num3 = 10;
								if (!pVR93YKogvhmU0U7O15e())
								{
									continue;
								}
								goto case 4;
							case 4:
							case 16:
								if (!flag)
								{
									threshSelect.Value -= decrement;
									goto default;
								}
								num3 = 19;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 2:
								return;
							case 19:
								goto IL_0317;
							}
							break;
						}
						goto IL_006d;
						end_IL_0054:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 3;
				default:
					num = 3;
					break;
				case 5:
					return;
				}
			}
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object oZ17dxKos2EXC62HewOf(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lGGQtOKovIoIaqGXsa4d(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).CellValue;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int ilRKZRKorXTpPcqkTf0r(int P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Math.Max(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CIDh3tKol032wj6efKSW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pVR93YKogvhmU0U7O15e()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDynamicallyThresholdTool_003Ed__0))]
	public static Task DynamicallyThresholdTool(CvsCogSocketSheet sheet, CvsCellLocation passFailLocation, EditIntViewModel threshSelect, int lowerBound = 5, int decrement = 5)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CDynamicallyThresholdTool_003Ed__0 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003Et__builder = EsjWhVfyIuPUp4y5Yer();
				num = 1;
				break;
			case 1:
				stateMachine.sheet = sheet;
				num = 2;
				break;
			case 6:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			case 3:
			case 9:
				stateMachine.threshSelect = threshSelect;
				num = 5;
				break;
			case 2:
				stateMachine.passFailLocation = passFailLocation;
				Px66B3fWjCe2keGYBtU();
				num = ((!aiR5FffTB9ks9LC1j74()) ? 9 : 4);
				break;
			case 5:
				stateMachine.lowerBound = lowerBound;
				goto case 8;
			default:
				num = 8;
				break;
			case 8:
				stateMachine.decrement = decrement;
				num = 6;
				break;
			case 4:
			case 7:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 10;
				break;
			case 10:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder EsjWhVfyIuPUp4y5Yer()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Px66B3fWjCe2keGYBtU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool aiR5FffTB9ks9LC1j74()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
