using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.Mvvm;
using Cognex.Utilities.Sdk.InSightController;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public class FactoryProtocol : EzSupportSnippet
{
	private static class kI4qFGRU6CQfD1McIrl
	{
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDisposeAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncValueTaskMethodBuilder _003C_003Et__builder;

		public FactoryProtocol _003C_003E4__this;

		private ValueTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			FactoryProtocol factoryProtocol = default;
			ValueTaskAwaiter awaiter = default;
			ValueTask valueTask = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							ul213s5IlL8iJKdwbPkT(factoryProtocol.InputData);
							num3 = 9;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								break;
							case 7:
								awaiter = valueTask.GetAwaiter();
								goto case 0;
							case 8:
								num2 = (_003C_003E1__state = 0);
								goto case 10;
							default:
								num3 = 10;
								continue;
							case 9:
								ul213s5IlL8iJKdwbPkT(factoryProtocol.OutputData);
								ux0psJ5Iflciyx5TkFtJ();
								num3 = ((!wmP2TZ5IdltfiQB80ZQE()) ? 6 : 0);
								continue;
							case 10:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								continue;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								if (ux0psJ5Iflciyx5TkFtJ())
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 4;
								continue;
							case 5:
								return;
							case 1:
							case 6:
								valueTask = factoryProtocol.P7F2ZbWKsK();
								num3 = 7;
								if (true)
								{
									continue;
								}
								break;
							case 11:
								break;
							}
							break;
						}
						awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 0:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (ux0psJ5Iflciyx5TkFtJ())
					{
						continue;
					}
					break;
				case 4:
					break;
				case 6:
					return;
				}
				factoryProtocol = _003C_003E4__this;
				wmP2TZ5IdltfiQB80ZQE();
				num = (ux0psJ5Iflciyx5TkFtJ() ? 1 : 5);
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
		internal static void ul213s5IlL8iJKdwbPkT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((FormatDataBase)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ux0psJ5Iflciyx5TkFtJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wmP2TZ5IdltfiQB80ZQE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CParse_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FactoryProtocol _003C_003E4__this;

		public CvsCellCollection cells;

		private IEnumerator<CvsCellLocation> _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			int num2 = default;
			FactoryProtocol factoryProtocol = default;
			TaskAwaiter awaiter = default;
			CvsCellLocation current = default;
			CvsCell cvsCell = default;
			FfpType result = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 3:
					num2 = _003C_003E1__state;
					_ = 1;
					num = ((!lklhQs5Is1jJsfKnrEyy()) ? 4 : 0);
					break;
				case 1:
				case 4:
					factoryProtocol = _003C_003E4__this;
					goto case 0;
				case 0:
				case 2:
					try
					{
						if ((uint)num2 > 1u)
						{
							factoryProtocol.RemoveAllProperties();
							factoryProtocol.vTw2JZruGC(null);
							factoryProtocol.InputData.ResetElements();
							p3XBM75IvGDJGEHBK1FG(factoryProtocol.OutputData);
							_003C_003E7__wrap1 = factoryProtocol.CellRange.GetEnumerator();
						}
						try
						{
							int num3;
							if (num2 != 0)
							{
								if (num2 != 1)
								{
									num3 = 32;
									if (!d66TT95IgklIoc4UbabN())
									{
										goto IL_00bd;
									}
								}
								else
								{
									awaiter = _003C_003Eu__1;
									num3 = 31;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 0;
							}
							goto IL_01e1;
							IL_00bd:
							num2 = (_003C_003E1__state = 1);
							num3 = 8;
							goto IL_01e1;
							IL_01e1:
							while (true)
							{
								object obj;
								string text;
								switch (num3)
								{
								case 19:
									break;
								case 13:
									ODbbZU5IEk1bQmb59Uhx(factoryProtocol.InputData, current);
									num3 = 23;
									if (true)
									{
										continue;
									}
									goto case 12;
								case 5:
									awaiter = F6uUC55Ioi4GYOoBZ6aK(factoryProtocol.InputData.SetInputTableEnd(current));
									if (!awaiter.IsCompleted)
									{
										num3 = 19;
										continue;
									}
									goto case 9;
								case 11:
									if (cvsCell == null)
									{
										num3 = 21;
										continue;
									}
									obj = qDfvw15IP4joLUYh2GN7(cvsCell);
									goto IL_03d3;
								case 3:
								case 16:
									factoryProtocol.vTw2JZruGC(new EditStringViewModel(factoryProtocol.InSight, cells, current, Resources.VG3Jz0woWv()));
									num3 = 22;
									continue;
								case 8:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 29:
									factoryProtocol.OutputData.e0eqZQS4cw(cvsCell);
									goto case 12;
								default:
									num3 = 14;
									continue;
								case 22:
									if (!string.IsNullOrEmpty((string)B21xsG5IbdvptTll0nrQ(factoryProtocol.GEu2LkjbgE())))
									{
										if (Enum.TryParse<FfpType>((string)B21xsG5IbdvptTll0nrQ(factoryProtocol.GEu2LkjbgE()), out result) && result != jDhb9b5IGVTIMnc51J0y(factoryProtocol.Parent))
										{
											num3 = 17;
											continue;
										}
										goto case 12;
									}
									num3 = 7;
									continue;
								case 4:
									factoryProtocol.AddProperty(factoryProtocol.ByteWordOrder);
									num3 = 33;
									continue;
								case 15:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								case 7:
									factoryProtocol.GEu2LkjbgE().Value = jDhb9b5IGVTIMnc51J0y(factoryProtocol.Parent).ToString();
									awaiter = F6uUC55Ioi4GYOoBZ6aK(factoryProtocol.GEu2LkjbgE().WriteImmediateAsync(jDhb9b5IGVTIMnc51J0y(factoryProtocol.Parent).ToString()));
									num3 = 30;
									continue;
								case 0:
									_003C_003Eu__1 = default;
									num3 = 10;
									continue;
								case 21:
									obj = null;
									goto IL_03d3;
								case 20:
									awaiter.GetResult();
									num3 = 27;
									continue;
								case 6:
									_003C_003Eu__1 = awaiter;
									num3 = 1;
									if (d66TT95IgklIoc4UbabN())
									{
										continue;
									}
									goto case 9;
								case 9:
									awaiter.GetResult();
									goto case 12;
								case 25:
									factoryProtocol.ByteWordOrder = new ListBoxViewModel(factoryProtocol.InSight, cells, current, Resources.HfaBZydiIu());
									num3 = 4;
									continue;
								case 2:
									zI0Byk5I8MKeVjBed0Vh(factoryProtocol.OutputData, current);
									num3 = 24;
									continue;
								case 30:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 0);
										num3 = 6;
										continue;
									}
									goto case 20;
								case 17:
									mMU0kN5ISVT4O1LYWBLL(factoryProtocol.Parent, result);
									num3 = 18;
									continue;
								case 10:
									num2 = (_003C_003E1__state = -1);
									num3 = 20;
									continue;
								case 1:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 31:
									_003C_003Eu__1 = default;
									num3 = 15;
									continue;
								case 12:
								case 14:
								case 18:
								case 23:
								case 24:
								case 26:
								case 27:
								case 28:
								case 32:
								case 33:
									{
										if (mRrvt05IpwiMcoRQnBIj(_003C_003E7__wrap1))
										{
											current = _003C_003E7__wrap1.Current;
											cvsCell = (CvsCell)rdY0nZ5IrjtKgaP9Zecw(cells, current);
											num3 = 11;
											if (true)
											{
												continue;
											}
											goto case 21;
										}
										goto end_IL_01e1;
									}
									IL_03d3:
									text = (string)obj;
									if (text != null)
									{
										if (!XuhFa75IBekNjvEkmehP(text, NCcAnr5IZWAxfSNvmcnb(51680), StringComparison.Ordinal))
										{
											if (F8Da155IkdmwQOBdaNRX(text, NCcAnr5IZWAxfSNvmcnb(51738), StringComparison.Ordinal))
											{
												num3 = 29;
												continue;
											}
											if (XuhFa75IBekNjvEkmehP(text, NCcAnr5IZWAxfSNvmcnb(51810), StringComparison.Ordinal))
											{
												num3 = 2;
												if (0 == 0)
												{
													continue;
												}
												goto case 2;
											}
											if (XuhFa75IBekNjvEkmehP(text, CdQUGaROfy7He9T0foW.KbIzwHEDLa(51888), StringComparison.Ordinal))
											{
												jd88Ua5IqULE33IDTG8d(factoryProtocol.InputData, current);
												num3 = 12;
												continue;
											}
											if (text.Equals(CdQUGaROfy7He9T0foW.KbIzwHEDLa(51958), StringComparison.Ordinal))
											{
												num3 = 13;
												continue;
											}
											if (!text.Equals(CdQUGaROfy7He9T0foW.KbIzwHEDLa(52016), StringComparison.Ordinal))
											{
												if (XuhFa75IBekNjvEkmehP(text, NCcAnr5IZWAxfSNvmcnb(52094), StringComparison.Ordinal))
												{
													num3 = 5;
													continue;
												}
												if (XuhFa75IBekNjvEkmehP(text, CdQUGaROfy7He9T0foW.KbIzwHEDLa(52168), StringComparison.Ordinal))
												{
													num3 = 25;
													continue;
												}
											}
											else
											{
												factoryProtocol.InputData.SetInputTableStart(current);
											}
										}
										else
										{
											_ = 0;
											if (!d66TT95IgklIoc4UbabN())
											{
												num3 = 26;
												continue;
											}
											num3 = 16;
											if (0 == 0)
											{
												continue;
											}
										}
									}
									goto case 12;
								}
								goto IL_00bd;
								continue;
								end_IL_01e1:
								break;
							}
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								ntT44E5IX7kLKvRdQfOU(_003C_003E7__wrap1);
							}
						}
						_003C_003E7__wrap1 = null;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 5;
				default:
					num = 5;
					break;
				case 6:
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
		internal static void p3XBM75IvGDJGEHBK1FG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((FormatDataBase)P_0).ResetElements();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rdY0nZ5IrjtKgaP9Zecw(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qDfvw15IP4joLUYh2GN7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object NCcAnr5IZWAxfSNvmcnb(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XuhFa75IBekNjvEkmehP(object P_0, object P_1, StringComparison P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Equals((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object B21xsG5IbdvptTll0nrQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EditStringViewModel)P_0).Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FfpType jDhb9b5IGVTIMnc51J0y(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CommStepViewModel)P_0).Protocol;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter F6uUC55Ioi4GYOoBZ6aK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void mMU0kN5ISVT4O1LYWBLL(object P_0, FfpType P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CommStepViewModel)P_0).xLge8fEcnH(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool F8Da155IkdmwQOBdaNRX(object P_0, object P_1, StringComparison P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).StartsWith((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void zI0Byk5I8MKeVjBed0Vh(object P_0, CvsCellLocation value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((FormatOutputData)P_0).nDSqhV1xg1(value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jd88Ua5IqULE33IDTG8d(object P_0, CvsCellLocation value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((FormatInputData)P_0).knpq2faxAc(value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ODbbZU5IEk1bQmb59Uhx(object P_0, CvsCellLocation value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((FormatInputData)P_0).qVxqkInUgN(value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mRrvt05IpwiMcoRQnBIj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ntT44E5IX7kLKvRdQfOU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool d66TT95IgklIoc4UbabN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lklhQs5Is1jJsfKnrEyy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRemoveReferences_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FactoryProtocol _003C_003E4__this;

		public SnippetPreRemoveEventArgs e;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!JYr8UK5I4gr4BDhweXHp())
			{
				num = 4;
			}
			else
			{
				num = 5;
				if (1 == 0)
				{
					goto IL_0367;
				}
			}
			goto IL_0334;
			IL_0334:
			int num2 = default;
			FactoryProtocol factoryProtocol = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 2;
					continue;
				case 1:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						switch (num2)
						{
						default:
							awaiter = yGhV1M5I3cbF0ndawINp(factoryProtocol.heD2nAJtDC((EzSnippet)XfVW5y5I75aOxEpls9Lv(e)));
							num3 = 20;
							break;
						case 2:
							awaiter = _003C_003Eu__1;
							num3 = 13;
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 14;
							break;
						case 1:
							awaiter = _003C_003Eu__1;
							num3 = 10;
							if (JYr8UK5I4gr4BDhweXHp())
							{
							}
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 20:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 5;
									continue;
								}
								goto case 8;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								continue;
							case 3:
								awaiter.GetResult();
								num3 = 6;
								continue;
							case 6:
								awaiter = ((Task)vy2yGu5Ijh5V3IU7Fo5C(factoryProtocol.OutputData, e.Snippet)).GetAwaiter();
								goto case 11;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 8;
								if (aHPIbB5I9byDMk2KQFpk())
								{
									continue;
								}
								goto case 14;
							case 14:
								_003C_003Eu__1 = default;
								num3 = 9;
								continue;
							case 19:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 18;
								continue;
							case 13:
								_003C_003Eu__1 = default;
								num3 = 2;
								continue;
							case 8:
								awaiter.GetResult();
								JYr8UK5I4gr4BDhweXHp();
								if (!aHPIbB5I9byDMk2KQFpk())
								{
									num3 = 11;
									continue;
								}
								num3 = 12;
								if (0 == 0)
								{
									continue;
								}
								goto case 2;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 21;
								if (aHPIbB5I9byDMk2KQFpk())
								{
									continue;
								}
								goto case 7;
							case 7:
							case 12:
								awaiter = yGhV1M5I3cbF0ndawINp(vy2yGu5Ijh5V3IU7Fo5C(factoryProtocol.InputData, XfVW5y5I75aOxEpls9Lv(e)));
								num3 = 16;
								if (0 == 0)
								{
									continue;
								}
								goto case 5;
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 17:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 4:
								return;
							case 10:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 3;
								if (aHPIbB5I9byDMk2KQFpk())
								{
									continue;
								}
								goto case 0;
							case 0:
								num2 = (_003C_003E1__state = 1);
								goto case 19;
							default:
								num3 = 19;
								continue;
							case 11:
							case 15:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 2);
									num3 = 17;
									if (0 == 0)
									{
										continue;
									}
									return;
								}
								break;
							case 18:
								return;
							case 16:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								goto case 3;
							case 21:
								break;
							}
							break;
						}
						awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 2:
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_0367;
			IL_0367:
			factoryProtocol = _003C_003E4__this;
			num = 1;
			goto IL_0334;
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
		internal static object XfVW5y5I75aOxEpls9Lv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SnippetPreRemoveEventArgs)P_0).Snippet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter yGhV1M5I3cbF0ndawINp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vy2yGu5Ijh5V3IU7Fo5C(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FormatDataBase)P_0).RemoveSnippetReferences((EzSnippet)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aHPIbB5I9byDMk2KQFpk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JYr8UK5I4gr4BDhweXHp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private ListBoxViewModel kwk2rFh3wv;

	[CompilerGenerated]
	private FormatInputData kq82hU1Cci;

	[CompilerGenerated]
	private FormatOutputData Qmr28MrFw4;

	[CompilerGenerated]
	private readonly DelegateCommand yOf2mqcPNe;

	[CompilerGenerated]
	private readonly DelegateCommand kBl21eUEwF;

	[CompilerGenerated]
	private EventHandler ngm2z7uSEv;

	[CompilerGenerated]
	private EditStringViewModel ogZqatrgl2;

	public override string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)WBEGTxNH33iSefGjp5b();
		}
	}

	public new CommStepViewModel Parent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (CommStepViewModel)base.Parent;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			base.Parent = value;
		}
	}

	public ListBoxViewModel ByteWordOrder
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kwk2rFh3wv;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kwk2rFh3wv = value;
		}
	}

	public FormatInputData InputData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kq82hU1Cci;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kq82hU1Cci = value;
		}
	}

	public FormatOutputData OutputData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Qmr28MrFw4;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Qmr28MrFw4 = value;
		}
	}

	public DelegateCommand CloseDetailsPanelCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return yOf2mqcPNe;
		}
	}

	public DelegateCommand FfpDetailsPanelToggle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kBl21eUEwF;
		}
	}

	public event EventHandler DetailsToggled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			tBYcCiNF3tSxxlh3QMx();
			int num;
			if (yNTlxbN0JO2dE27jduM())
			{
				num = 4;
			}
			else
			{
				num = 6;
				if (1 == 0)
				{
					return;
				}
			}
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					if ((object)eventHandler2 == eventHandler)
					{
						num = 7;
						continue;
					}
					break;
				case 5:
					value2 = (EventHandler)f5a0yINxDk69DnjxtTV(eventHandler, value);
					goto case 2;
				default:
					num = 2;
					continue;
				case 1:
				case 6:
					break;
				case 2:
					eventHandler2 = Interlocked.CompareExchange(ref ngm2z7uSEv, value2, eventHandler);
					num = 3;
					if (yNTlxbN0JO2dE27jduM())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 4:
					eventHandler2 = ngm2z7uSEv;
					break;
				case 7:
					return;
				}
				eventHandler = eventHandler2;
				num = 5;
				if (tBYcCiNF3tSxxlh3QMx())
				{
				}
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			yNTlxbN0JO2dE27jduM();
			int num;
			if (!tBYcCiNF3tSxxlh3QMx())
			{
				num = 2;
				if (!yNTlxbN0JO2dE27jduM())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_0079;
			IL_004c:
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = eventHandler2;
			num = 6;
			if (1 == 0)
			{
				goto IL_005a;
			}
			goto IL_0079;
			IL_005a:
			EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler, value);
			goto IL_002e;
			IL_002e:
			eventHandler2 = Interlocked.CompareExchange(ref ngm2z7uSEv, value2, eventHandler);
			num = 5;
			if (!yNTlxbN0JO2dE27jduM())
			{
				goto IL_004c;
			}
			goto IL_0079;
			IL_0079:
			while (true)
			{
				switch (num)
				{
				case 1:
					goto IL_004c;
				case 6:
					goto IL_005a;
				case 0:
				case 2:
					eventHandler2 = ngm2z7uSEv;
					num = 1;
					continue;
				case 5:
					if ((object)eventHandler2 == eventHandler)
					{
						num = 7;
						continue;
					}
					goto IL_004c;
				case 7:
					return;
				}
				break;
			}
			goto IL_002e;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FactoryProtocol(CommStepViewModel commStep)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				kBl21eUEwF = new DelegateCommand(ToggleDetailsPanel, [MethodImpl(MethodImplOptions.NoInlining)] () =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return true;
				});
				num = 2;
				if (tBYcCiNF3tSxxlh3QMx())
				{
				}
				break;
			case 1:
			case 6:
				base._002Ector(commStep);
				num = 7;
				break;
			case 0:
				OutputData = new FormatOutputData(commStep);
				goto default;
			case 3:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				_ = 0;
				num = (yNTlxbN0JO2dE27jduM() ? 6 : 5);
				break;
			case 7:
				InputData = new FormatInputData(commStep);
				num = 0;
				break;
			case 2:
				yOf2mqcPNe = new DelegateCommand(DoStopFormattingData, [MethodImpl(MethodImplOptions.NoInlining)] () =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return true;
				});
				num = 8;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ToggleDetailsPanel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EventHandler eventHandler = ngm2z7uSEv;
		if (eventHandler != null)
		{
			aIcSFgNMt3bNutvcLae(eventHandler, this, EventArgs.Empty);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoStopFormattingData()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ToggleDetailsPanel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__4))]
	public override ValueTask DisposeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (!yNTlxbN0JO2dE27jduM())
		{
			goto IL_001e;
		}
		goto IL_005c;
		IL_008d:
		_003CDisposeAsync_003Ed__4 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (0 == 0)
		{
			goto IL_005c;
		}
		goto IL_00a7;
		IL_005c:
		switch (num)
		{
		case 0:
			break;
		case 1:
		case 2:
			goto IL_0042;
		default:
			goto IL_008d;
		case 5:
			goto IL_00a7;
		case 6:
			return stateMachine._003C_003Et__builder.Task;
		}
		goto IL_001e;
		IL_0042:
		stateMachine._003C_003E1__state = -1;
		goto IL_008d;
		IL_001e:
		stateMachine._003C_003E4__this = this;
		yNTlxbN0JO2dE27jduM();
		if (!tBYcCiNF3tSxxlh3QMx())
		{
			num = 1;
			if (1 == 0)
			{
				goto IL_0042;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_005c;
		IL_00a7:
		stateMachine._003C_003Et__builder = gKZZlLNYC0mZrXYtf7Y();
		num = 0;
		goto IL_005c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CParse_003Ed__5))]
	protected override Task Parse(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0060;
		IL_001a:
		_003CParse_003Ed__5 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		num = 5;
		goto IL_0060;
		IL_0060:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 6:
				break;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine.cells = cells;
				goto case 2;
			default:
				num = 2;
				if (true)
				{
					continue;
				}
				goto case 3;
			case 3:
				stateMachine._003C_003Et__builder = aqkNGlNUReULrnF71Pi();
				yNTlxbN0JO2dE27jduM();
				if (!tBYcCiNF3tSxxlh3QMx())
				{
					num = 6;
					if (yNTlxbN0JO2dE27jduM())
					{
						continue;
					}
					goto case 2;
				}
				num = 0;
				continue;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal EditStringViewModel GEu2LkjbgE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ogZqatrgl2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal void vTw2JZruGC(EditStringViewModel value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ogZqatrgl2 = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveReferences_003Ed__36))]
	public override Task RemoveReferences(SnippetPreRemoveEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CRemoveReferences_003Ed__36 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 0;
				continue;
			case 0:
				stateMachine.e = e;
				goto default;
			default:
				yNTlxbN0JO2dE27jduM();
				if (tBYcCiNF3tSxxlh3QMx())
				{
					num = 1;
					continue;
				}
				num = 5;
				if (tBYcCiNF3tSxxlh3QMx())
				{
				}
				continue;
			case 2:
				stateMachine._003C_003Et__builder = aqkNGlNUReULrnF71Pi();
				num = 6;
				if (!tBYcCiNF3tSxxlh3QMx())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (true)
				{
					continue;
				}
				break;
			case 7:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private ValueTask P7F2ZbWKsK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.DisposeAsync();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task heD2nAJtDC(EzSnippet P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.RemoveSupportSnippetReferences(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool yNTlxbN0JO2dE27jduM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tBYcCiNF3tSxxlh3QMx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aIcSFgNMt3bNutvcLae(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (EventArgs)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncValueTaskMethodBuilder gKZZlLNYC0mZrXYtf7Y()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncValueTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder aqkNGlNUReULrnF71Pi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WBEGTxNH33iSefGjp5b()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.FactoryProtocol;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object f5a0yINxDk69DnjxtTV(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}
}
