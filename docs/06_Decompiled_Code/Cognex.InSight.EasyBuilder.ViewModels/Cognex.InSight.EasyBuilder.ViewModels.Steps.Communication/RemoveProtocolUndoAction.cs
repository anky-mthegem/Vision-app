using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Internal;
using Cognex.Utilities.Sdk.InSightController;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public class RemoveProtocolUndoAction : RemoveSnippetUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDo_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RemoveProtocolUndoAction _003C_003E4__this;

		private IAsyncDisposable _003C_003E7__wrap1;

		private TaskAwaiter<IAsyncDisposable> _003C_003Eu__1;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private CvsCellCollection _003Ccells_003E5__5;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private ValueTaskAwaiter _003C_003Eu__4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			RemoveProtocolUndoAction removeProtocolUndoAction = default;
			TaskAwaiter awaiter3 = default;
			TaskAwaiter<CvsCellCollection> awaiter4 = default;
			CvsCellCollection result2 = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					try
					{
						TaskAwaiter<IAsyncDisposable> awaiter2;
						ValueTaskAwaiter awaiter;
						IAsyncDisposable result;
						switch (num2)
						{
						default:
							awaiter2 = removeProtocolUndoAction.CommStep.AppViewModel.PauseResults().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_009b;
						case 0:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_009b;
						case 1:
						case 2:
						case 3:
						case 4:
						case 5:
							try
							{
								int num3;
								switch (num2)
								{
								default:
									num3 = 27;
									if (1 == 0)
									{
										goto IL_00e1;
									}
									goto IL_03c2;
								case 3:
									awaiter3 = _003C_003Eu__3;
									num3 = 21;
									if (false)
									{
										goto IL_0171;
									}
									goto IL_03c2;
								case 5:
									awaiter3 = _003C_003Eu__3;
									_003C_003Eu__3 = default;
									num3 = 17;
									goto IL_03c2;
								case 1:
									awaiter4 = _003C_003Eu__2;
									num3 = 22;
									if (1 == 0)
									{
										goto IL_02bb;
									}
									goto IL_03c2;
								case 4:
									awaiter3 = _003C_003Eu__3;
									num3 = 32;
									goto IL_03c2;
								case 2:
									{
										awaiter3 = _003C_003Eu__3;
										num3 = 9;
										goto IL_03c2;
									}
									IL_03c2:
									while (true)
									{
										switch (num3)
										{
										case 17:
											break;
										case 13:
											_003C_003Eu__3 = awaiter3;
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
											num3 = 24;
											continue;
										case 26:
											num2 = (_003C_003E1__state = -1);
											num3 = 12;
											if (0 == 0)
											{
												continue;
											}
											goto case 16;
										case 16:
											_003C_003Eu__3 = awaiter3;
											num3 = 35;
											continue;
										case 34:
											if (!awaiter3.IsCompleted)
											{
												num3 = 3;
												continue;
											}
											goto case 12;
										case 31:
											return;
										case 8:
											goto IL_0171;
										case 12:
											awaiter3.GetResult();
											removeProtocolUndoAction.Ywri7DAfH0 = jPHPrG5Vi2BGRmkJPu7C(removeProtocolUndoAction.CommStep.FactoryProtocol);
											awaiter3 = XUaPXl5VDrgr8uZxJ6T5(removeProtocolUndoAction.SaveSnippet(removeProtocolUndoAction.Ywri7DAfH0));
											num3 = 1;
											continue;
										case 15:
											num2 = (_003C_003E1__state = 1);
											num3 = 2;
											continue;
										case 2:
											_003C_003Eu__2 = awaiter4;
											qF7hRP5Vao0nRCCyQc0P();
											if (!InL9Ao5Ve01eR7kKa8Ol())
											{
												num3 = 29;
												continue;
											}
											num3 = 14;
											if (true)
											{
												continue;
											}
											goto case 28;
										case 11:
											num2 = (_003C_003E1__state = -1);
											goto IL_0205;
										case 3:
											num2 = (_003C_003E1__state = 2);
											_003C_003Eu__3 = awaiter3;
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
											num3 = 20;
											continue;
										case 24:
											return;
										case 22:
											_003C_003Eu__2 = default;
											num3 = 19;
											if (qF7hRP5Vao0nRCCyQc0P())
											{
												continue;
											}
											goto case 18;
										case 18:
											if (!awaiter3.IsCompleted)
											{
												num3 = 28;
												continue;
											}
											goto IL_00ea;
										case 4:
										case 29:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
											return;
										case 19:
											goto IL_02bb;
										case 32:
											_003C_003Eu__3 = default;
											num3 = 11;
											if (InL9Ao5Ve01eR7kKa8Ol())
											{
											}
											continue;
										case 10:
											if (!awaiter4.IsCompleted)
											{
												num3 = 15;
												continue;
											}
											goto case 5;
										case 5:
											result2 = awaiter4.GetResult();
											num3 = 23;
											if (!InL9Ao5Ve01eR7kKa8Ol())
											{
												continue;
											}
											goto case 0;
										case 0:
											num2 = (_003C_003E1__state = 4);
											num3 = 16;
											continue;
										case 14:
											return;
										case 25:
											return;
										case 20:
											return;
										case 21:
											_003C_003Eu__3 = default;
											num2 = (_003C_003E1__state = -1);
											num3 = 33;
											continue;
										case 9:
											_003C_003Eu__3 = default;
											num3 = 26;
											continue;
										case 1:
											if (!awaiter3.IsCompleted)
											{
												num2 = (_003C_003E1__state = 3);
												_003C_003Eu__3 = awaiter3;
												goto case 30;
											}
											goto case 33;
										default:
											num3 = 30;
											continue;
										case 27:
											awaiter4 = ((CvsCogSocket)HnwiNr5VISrGacC9juJK(X83SAP5VOQIb8J2kJCUH(removeProtocolUndoAction.CommStep))).Sheet.RunAndGetCellResults().GetAwaiter();
											num3 = 10;
											continue;
										case 35:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
											return;
										case 28:
											num2 = (_003C_003E1__state = 5);
											num3 = 13;
											if (true)
											{
												continue;
											}
											goto case 7;
										case 7:
											if (!awaiter3.IsCompleted)
											{
												num3 = 0;
												continue;
											}
											goto IL_0205;
										case 23:
											_003Ccells_003E5__5 = result2;
											num3 = 6;
											continue;
										case 6:
											awaiter3 = XUaPXl5VDrgr8uZxJ6T5(removeProtocolUndoAction.eAki5PIubK());
											num3 = 34;
											continue;
										case 30:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
											num3 = 31;
											if (true)
											{
												continue;
											}
											goto case 33;
										case 33:
											awaiter3.GetResult();
											awaiter3 = XUaPXl5VDrgr8uZxJ6T5(removeProtocolUndoAction.CommStep.FireSnippetRemove(new SnippetRemoveEventArgs(_003Ccells_003E5__5, (EzSnippet)TxMDJq5VnI1u7bKP1ao6(removeProtocolUndoAction.CommStep))));
											num3 = 7;
											continue;
										case 36:
											{
												_003Ccells_003E5__5 = null;
												goto end_IL_00bc;
											}
											IL_0205:
											awaiter3.GetResult();
											num3 = 8;
											continue;
										}
										break;
									}
									goto IL_00e1;
									IL_02bb:
									num2 = (_003C_003E1__state = -1);
									num3 = 5;
									goto IL_03c2;
									IL_0171:
									awaiter3 = XUaPXl5VDrgr8uZxJ6T5(AyNh7C5VVchhNXmCXpS3(removeProtocolUndoAction.CommStep));
									num3 = 18;
									goto IL_03c2;
									IL_00e1:
									num2 = (_003C_003E1__state = -1);
									goto IL_00ea;
									IL_00ea:
									awaiter3.GetResult();
									num3 = 36;
									goto IL_03c2;
									end_IL_00bc:
									break;
								}
							}
							catch (object obj)
							{
								_003C_003E7__wrap2 = obj;
							}
							if (_003C_003E7__wrap1 == null)
							{
								break;
							}
							awaiter = EGHrwI5VfT1pEatENTeJ(_003C_003E7__wrap1).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 6);
								_003C_003Eu__4 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_05e1;
						case 6:
							{
								awaiter = _003C_003Eu__4;
								_003C_003Eu__4 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_05e1;
							}
							IL_05e1:
							awaiter.GetResult();
							break;
							IL_009b:
							result = awaiter2.GetResult();
							_003C_003E7__wrap1 = result;
							_003C_003E7__wrap2 = null;
							_003C_003E7__wrap3 = 0;
							goto case 1;
						}
						object obj2 = _003C_003E7__wrap2;
						if (obj2 != null)
						{
							dFwP0X5VlbRyiu7hkbI7(wrfp2w5VdfB0adxr21Ki((obj2 as Exception) ?? throw obj2));
						}
						_003C_003E7__wrap2 = null;
						_003C_003E7__wrap1 = null;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 0:
					do
					{
						removeProtocolUndoAction = _003C_003E4__this;
						InL9Ao5Ve01eR7kKa8Ol();
						if (!qF7hRP5Vao0nRCCyQc0P())
						{
							num = 5;
							continue;
						}
						num = 4;
						break;
					}
					while (InL9Ao5Ve01eR7kKa8Ol());
					continue;
				case 1:
					num2 = _003C_003E1__state;
					num = 0;
					continue;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
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
		internal static object X83SAP5VOQIb8J2kJCUH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HnwiNr5VISrGacC9juJK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter XUaPXl5VDrgr8uZxJ6T5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange jPHPrG5Vi2BGRmkJPu7C(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).CellRange;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TxMDJq5VnI1u7bKP1ao6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CommStepViewModel)P_0).FactoryProtocol;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AyNh7C5VVchhNXmCXpS3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CommStepViewModel)P_0).oDXehJ1f06();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ValueTask EGHrwI5VfT1pEatENTeJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IAsyncDisposable)P_0).DisposeAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wrfp2w5VdfB0adxr21Ki(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void dFwP0X5VlbRyiu7hkbI7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qF7hRP5Vao0nRCCyQc0P()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool InL9Ao5Ve01eR7kKa8Ol()
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
	private struct _003CRedo_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RemoveProtocolUndoAction _003C_003E4__this;

		private IAsyncDisposable _003C_003E7__wrap1;

		private TaskAwaiter<IAsyncDisposable> _003C_003Eu__1;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__3;

		private ValueTaskAwaiter _003C_003Eu__4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (qVY5Uw5Vg8l5RUc6VXi7())
			{
				num = 5;
				if (h9Ehpq5VsaeANA9ZSQdK())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_058d;
			IL_002a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_058d;
			IL_058d:
			RemoveProtocolUndoAction removeProtocolUndoAction = default;
			TaskAwaiter awaiter3 = default;
			TaskAwaiter<CvsCellCollection> awaiter4 = default;
			CvsCellCollection result2 = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 3:
					removeProtocolUndoAction = _003C_003E4__this;
					num = 4;
					continue;
				case 4:
					try
					{
						TaskAwaiter<IAsyncDisposable> awaiter2;
						ValueTaskAwaiter awaiter;
						IAsyncDisposable result;
						switch (num2)
						{
						default:
							awaiter2 = ((EasyBuilderApplicationViewModel)tTh6c45Vv6O8ayUmQuAF(removeProtocolUndoAction.CommStep)).PauseResults().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_00e6;
						case 0:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00e6;
						case 1:
						case 2:
						case 3:
						case 4:
							try
							{
								int num3;
								switch (num2)
								{
								default:
									num3 = 1;
									if (h9Ehpq5VsaeANA9ZSQdK())
									{
									}
									break;
								case 1:
									awaiter3 = _003C_003Eu__2;
									num3 = 27;
									break;
								case 2:
									awaiter4 = _003C_003Eu__3;
									num3 = 6;
									break;
								case 3:
									awaiter3 = _003C_003Eu__2;
									num3 = 15;
									break;
								case 4:
									awaiter3 = _003C_003Eu__2;
									num3 = 0;
									break;
								}
								while (true)
								{
									switch (num3)
									{
									case 27:
										_003C_003Eu__2 = default;
										num2 = (_003C_003E1__state = -1);
										num3 = 20;
										if (true)
										{
											continue;
										}
										goto case 18;
									case 18:
										num2 = (_003C_003E1__state = 3);
										num3 = 16;
										continue;
									case 16:
										_003C_003Eu__2 = awaiter3;
										num3 = 24;
										if (0 == 0)
										{
											continue;
										}
										goto case 25;
									case 25:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										return;
									case 6:
										_003C_003Eu__3 = default;
										num2 = (_003C_003E1__state = -1);
										goto case 22;
									default:
										num3 = 22;
										continue;
									case 22:
										result2 = awaiter4.GetResult();
										num3 = 5;
										continue;
									case 7:
										awaiter4 = ((CvsCogSocketSheet)FT3rHv5VBWCxNxhcPVmZ(hholH45VZrOlOrEo0EJ7(GykToL5VPESl9Exdqg0Z(removeProtocolUndoAction.CommStep)))).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
										num3 = 26;
										continue;
									case 23:
										_003C_003Eu__2 = awaiter3;
										num3 = 25;
										continue;
									case 2:
									case 21:
										num2 = (_003C_003E1__state = 1);
										num3 = 23;
										continue;
									case 1:
										awaiter3 = Aa7BH45VrqhBuINRDkQP(removeProtocolUndoAction.eAki5PIubK());
										num3 = 3;
										continue;
									case 4:
									case 10:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										num3 = 12;
										continue;
									case 20:
										awaiter3.GetResult();
										num3 = 7;
										continue;
									case 8:
										awaiter3.GetResult();
										awaiter3 = Aa7BH45VrqhBuINRDkQP(OIIWaV5VGFjs4KLbBslx(removeProtocolUndoAction.CommStep));
										if (!awaiter3.IsCompleted)
										{
											num2 = (_003C_003E1__state = 4);
											num3 = 19;
											continue;
										}
										break;
									case 3:
										if (!awaiter3.IsCompleted)
										{
											qVY5Uw5Vg8l5RUc6VXi7();
											num3 = (h9Ehpq5VsaeANA9ZSQdK() ? 4 : 21);
											continue;
										}
										goto case 20;
									case 14:
										num2 = (_003C_003E1__state = -1);
										num3 = 8;
										if (0 == 0)
										{
											continue;
										}
										goto case 0;
									case 0:
										_003C_003Eu__2 = default;
										num2 = (_003C_003E1__state = -1);
										num3 = 28;
										continue;
									case 17:
										_003C_003Eu__3 = awaiter4;
										goto case 4;
									case 19:
										_003C_003Eu__2 = awaiter3;
										num3 = 13;
										continue;
									case 13:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										num3 = 9;
										continue;
									case 26:
										if (!awaiter4.IsCompleted)
										{
											num2 = (_003C_003E1__state = 2);
											num3 = 17;
											continue;
										}
										goto case 22;
									case 11:
										if (!awaiter3.IsCompleted)
										{
											num3 = 18;
											continue;
										}
										goto case 8;
									case 15:
										_003C_003Eu__2 = default;
										num3 = 14;
										continue;
									case 12:
										return;
									case 24:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										return;
									case 9:
										return;
									case 5:
										awaiter3 = Aa7BH45VrqhBuINRDkQP(FUPGRy5VbXfmOm2bLIKP(removeProtocolUndoAction.CommStep, new SnippetRemoveEventArgs(result2, removeProtocolUndoAction.CommStep.FactoryProtocol)));
										num3 = 11;
										continue;
									case 28:
										break;
									}
									break;
								}
								awaiter3.GetResult();
							}
							catch (object obj)
							{
								_003C_003E7__wrap2 = obj;
							}
							if (_003C_003E7__wrap1 == null)
							{
								break;
							}
							awaiter = v5kTtD5VomELr8pAsIUO(_003C_003E7__wrap1).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 5);
								_003C_003Eu__4 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0514;
						case 5:
							{
								awaiter = _003C_003Eu__4;
								_003C_003Eu__4 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0514;
							}
							IL_0514:
							awaiter.GetResult();
							break;
							IL_00e6:
							result = awaiter2.GetResult();
							_003C_003E7__wrap1 = result;
							_003C_003E7__wrap2 = null;
							_003C_003E7__wrap3 = 0;
							goto case 1;
						}
						object obj2 = _003C_003E7__wrap2;
						if (obj2 != null)
						{
							cyPAmm5Vk14yTNTJFLmk(YmFtJH5VSF6PYqSVvjE3((obj2 as Exception) ?? throw obj2));
						}
						_003C_003E7__wrap2 = null;
						_003C_003E7__wrap1 = null;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				default:
					num = 2;
					if (qVY5Uw5Vg8l5RUc6VXi7())
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
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
		internal static object tTh6c45Vv6O8ayUmQuAF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Aa7BH45VrqhBuINRDkQP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GykToL5VPESl9Exdqg0Z(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hholH45VZrOlOrEo0EJ7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FT3rHv5VBWCxNxhcPVmZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FUPGRy5VbXfmOm2bLIKP(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).FireSnippetRemove((SnippetRemoveEventArgs)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OIIWaV5VGFjs4KLbBslx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CommStepViewModel)P_0).oDXehJ1f06();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ValueTask v5kTtD5VomELr8pAsIUO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IAsyncDisposable)P_0).DisposeAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YmFtJH5VSF6PYqSVvjE3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void cyPAmm5Vk14yTNTJFLmk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qVY5Uw5Vg8l5RUc6VXi7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool h9Ehpq5VsaeANA9ZSQdK()
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
	private struct _003CUndo_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RemoveProtocolUndoAction _003C_003E4__this;

		private IAsyncDisposable _003C_003E7__wrap1;

		private TaskAwaiter<IAsyncDisposable> _003C_003Eu__1;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private TaskAwaiter _003C_003Eu__2;

		private ValueTaskAwaiter _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!wYfSGI5VqG8yFrEpt8cL())
			{
				num = 1;
			}
			else
			{
				num = 3;
				if (!zxDll45V8Bwr3lMkhlGU())
				{
					goto IL_0041;
				}
			}
			goto IL_02f5;
			IL_0331:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_02f5;
			IL_0041:
			RemoveProtocolUndoAction removeProtocolUndoAction = default;
			int num2 = default;
			try
			{
				TaskAwaiter<IAsyncDisposable> awaiter2;
				ValueTaskAwaiter awaiter;
				IAsyncDisposable result;
				switch (num2)
				{
				default:
					awaiter2 = ((EasyBuilderApplicationViewModel)vgDFSi5VE2GDdi7dK3NT(removeProtocolUndoAction.CommStep)).PauseResults().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num2 = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_00b4;
				case 0:
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num2 = (_003C_003E1__state = -1);
					goto IL_00b4;
				case 1:
					try
					{
						int num3;
						if (num2 != 1)
						{
							wYfSGI5VqG8yFrEpt8cL();
							num3 = ((!zxDll45V8Bwr3lMkhlGU()) ? 2 : 8);
							goto IL_0181;
						}
						TaskAwaiter awaiter3 = _003C_003Eu__2;
						goto IL_0151;
						IL_0181:
						while (true)
						{
							switch (num3)
							{
							case 4:
								return;
							case 7:
								num2 = (_003C_003E1__state = 1);
								num3 = 9;
								continue;
							case 0:
							case 8:
								awaiter3 = removeProtocolUndoAction.PasteAndParseSnippet().GetAwaiter();
								num3 = 3;
								continue;
							case 3:
								if (!awaiter3.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto case 10;
							case 2:
							case 6:
								break;
							case 9:
								_003C_003Eu__2 = awaiter3;
								goto case 1;
							default:
								num3 = 1;
								if (true)
								{
									continue;
								}
								goto case 1;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								num3 = 4;
								if (wYfSGI5VqG8yFrEpt8cL())
								{
								}
								continue;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 10:
								awaiter3.GetResult();
								goto end_IL_0181;
							}
							goto IL_0151;
							continue;
							end_IL_0181:
							break;
						}
						goto end_IL_00d2;
						IL_0151:
						_003C_003Eu__2 = default;
						num3 = 5;
						goto IL_0181;
						end_IL_00d2:;
					}
					catch (object obj)
					{
						_003C_003E7__wrap2 = obj;
					}
					if (_003C_003E7__wrap1 == null)
					{
						break;
					}
					awaiter = A5TJrN5VpUSbKYAgNFUS(_003C_003E7__wrap1).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num2 = (_003C_003E1__state = 2);
						_003C_003Eu__3 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_027c;
				case 2:
					{
						awaiter = _003C_003Eu__3;
						_003C_003Eu__3 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_027c;
					}
					IL_027c:
					awaiter.GetResult();
					break;
					IL_00b4:
					result = awaiter2.GetResult();
					_003C_003E7__wrap1 = result;
					_003C_003E7__wrap2 = null;
					_003C_003E7__wrap3 = 0;
					goto case 1;
				}
				object obj2 = _003C_003E7__wrap2;
				if (obj2 != null)
				{
					VfVp4k5VX8MF6HSDtY9R(ExceptionDispatchInfo.Capture((obj2 as Exception) ?? throw obj2));
				}
				_003C_003E7__wrap2 = null;
				_003C_003E7__wrap1 = null;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0331;
			IL_02f5:
			while (true)
			{
				switch (num)
				{
				case 5:
					removeProtocolUndoAction = _003C_003E4__this;
					break;
				case 2:
				case 3:
					break;
				default:
					num = 4;
					continue;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 4:
					goto IL_0331;
				case 6:
					return;
				}
				break;
			}
			goto IL_0041;
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
		internal static object vgDFSi5VE2GDdi7dK3NT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ValueTask A5TJrN5VpUSbKYAgNFUS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IAsyncDisposable)P_0).DisposeAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void VfVp4k5VX8MF6HSDtY9R(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zxDll45V8Bwr3lMkhlGU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wYfSGI5VqG8yFrEpt8cL()
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
	private struct _003CRemoveAllInputsOutputsAsync_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RemoveProtocolUndoAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			RemoveProtocolUndoAction removeProtocolUndoAction = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					removeProtocolUndoAction = _003C_003E4__this;
					dwScpf5V4JR1coHUYbnh();
					if (jsdmA65V975HOCVx4Jmi())
					{
						num = 1;
						continue;
					}
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 4;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 1;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 11;
								continue;
							case 0:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto default;
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									if (jsdmA65V975HOCVx4Jmi())
									{
										continue;
									}
									goto case 3;
								}
								goto default;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								_ = 0;
								num3 = (jsdmA65V975HOCVx4Jmi() ? 14 : 10);
								continue;
							case 1:
								_003C_003Eu__1 = default;
								num3 = 3;
								continue;
							case 11:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								awaiter.GetResult();
								num3 = 13;
								if (dwScpf5V4JR1coHUYbnh())
								{
								}
								continue;
							case 13:
								awaiter = N8Sg8W5VjBskrY7OrucD(removeProtocolUndoAction.fGPip1or1F((FormatDataBase)Hs2yap5V6drTGglpSxPr(G0QQYd5V7sbTce2eNvVA(removeProtocolUndoAction.CommStep))));
								num3 = 15;
								continue;
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 12;
								if (dwScpf5V4JR1coHUYbnh())
								{
								}
								continue;
							case 12:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								continue;
							case 15:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 8;
									continue;
								}
								break;
							case 5:
							case 14:
								return;
							case 4:
								awaiter = N8Sg8W5VjBskrY7OrucD(removeProtocolUndoAction.fGPip1or1F((FormatDataBase)qbWEJl5V3Qls85ZbWZvP(G0QQYd5V7sbTce2eNvVA(removeProtocolUndoAction.CommStep))));
								num3 = 9;
								continue;
							case 16:
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
					break;
				case 0:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
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
		internal static object G0QQYd5V7sbTce2eNvVA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CommStepViewModel)P_0).FactoryProtocol;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qbWEJl5V3Qls85ZbWZvP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FactoryProtocol)P_0).InputData;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter N8Sg8W5VjBskrY7OrucD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Hs2yap5V6drTGglpSxPr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FactoryProtocol)P_0).OutputData;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jsdmA65V975HOCVx4Jmi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dwScpf5V4JR1coHUYbnh()
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
	private struct _003CRemoveAllElementsAsync_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FormatDataBase formatData;

		private int _003Ci_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			TaskAwaiter awaiter = default;
			int num4 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					cMIoLS5VAGtbFLadqBKo();
					if (LmHME95VCecv27vsiCWa())
					{
						num = 3;
						continue;
					}
					num = 0;
					if (true)
					{
						continue;
					}
					break;
				case 1:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Ci_003E5__2 = formatData.Elements.Count - 1;
							num3 = 10;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 11;
							if (1 == 0)
							{
								goto IL_00ba;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
							case 9:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								continue;
							case 11:
								_003C_003Eu__1 = default;
								num3 = 0;
								continue;
							case 8:
								awaiter.GetResult();
								num4 = _003Ci_003E5__2;
								num3 = 3;
								continue;
							case 1:
								return;
							case 5:
								break;
							case 4:
							case 6:
								goto IL_00f7;
							default:
								num3 = 1;
								continue;
							case 7:
								if (awaiter.IsCompleted)
								{
									goto case 8;
								}
								goto IL_0166;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 8;
								continue;
							case 3:
								_003Ci_003E5__2 = num4 - 1;
								num3 = 12;
								if (0 == 0)
								{
									continue;
								}
								goto case 10;
							case 10:
							case 12:
								if (_003Ci_003E5__2 >= 0)
								{
									awaiter = vlWD0V5VWfxYQQNix4RZ(ohFknH5VR7SbUml70V2J(formatData, _003Ci_003E5__2));
									num3 = 7;
									continue;
								}
								goto end_IL_0039;
							}
							break;
							IL_0166:
							_ = 0;
							num3 = (LmHME95VCecv27vsiCWa() ? 9 : 6);
						}
						goto IL_00ba;
						IL_00f7:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						IL_00ba:
						_003C_003Eu__1 = awaiter;
						goto IL_00f7;
						end_IL_0039:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 5:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 5;
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
		internal static object ohFknH5VR7SbUml70V2J(object P_0, int index)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FormatDataBase)P_0).RemoveElementAtAsync(index);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter vlWD0V5VWfxYQQNix4RZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LmHME95VCecv27vsiCWa()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cMIoLS5VAGtbFLadqBKo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly FfpType ExWiUqCcJ7;

	private CvsCellRange Ywri7DAfH0;

	public override string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)DLk8AX202q5rM4E7YM2(Resources.znyhSQ8CwN(), V5SyYe2yOuLmrKf4gK5(CommStepViewModel.FfpTypeStringConverter, ExWiUqCcJ7), CommStepViewModel.FfpTypeStringConverter.ConvertToString(FfpType.None));
		}
	}

	protected CommStepViewModel CommStep
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (CommStepViewModel)AppStepVm;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RemoveProtocolUndoAction(CommStepViewModel commStep, string protocolName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		q56X9g2Cs5ItBwUX6JL();
		int num;
		if (SXRJxG26BbioSgbvxSg())
		{
			num = 4;
		}
		else
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_0080;
			}
		}
		goto IL_0042;
		IL_0042:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				base._002Ector(commStep, protocolName);
				break;
			default:
				goto IL_005f;
			case 0:
			case 4:
				w6sp9e2AO1ZLbii2efa();
				goto case 1;
			case 2:
				break;
			case 5:
				return;
			}
			break;
			IL_005f:
			num = 2;
		}
		goto IL_0080;
		IL_0080:
		Enum.TryParse<FfpType>((string)wWNuhs2TjU3Xykl1VbT(s533eF2WorqnlF8oUMI(zcCp172Rl9n4wuX5Tp4(commStep))), out ExWiUqCcJ7);
		num = 5;
		goto IL_0042;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__8))]
	public override Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		q56X9g2Cs5ItBwUX6JL();
		int num;
		if (SXRJxG26BbioSgbvxSg())
		{
			num = 3;
		}
		else
		{
			num = 1;
			if (1 == 0)
			{
				goto IL_00b5;
			}
		}
		_003CDo_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				continue;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = b00tjH2Fpyn4svbCa9J();
				num = 4;
				continue;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 1;
			case 6:
				break;
			}
			break;
		}
		goto IL_00b5;
		IL_00b5:
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__9))]
	public override Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SXRJxG26BbioSgbvxSg();
		int num;
		if (!q56X9g2Cs5ItBwUX6JL())
		{
			num = 5;
		}
		else
		{
			num = 3;
			if (false)
			{
				goto IL_0046;
			}
		}
		goto IL_0060;
		IL_0046:
		_003CRedo_003Ed__9 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_008b;
		IL_008b:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0060;
		IL_0060:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = b00tjH2Fpyn4svbCa9J();
				goto case 1;
			case 2:
				break;
			default:
				num = 4;
				continue;
			case 4:
				goto IL_008b;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				goto case 6;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0046;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__10))]
	public override Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		q56X9g2Cs5ItBwUX6JL();
		int num;
		if (SXRJxG26BbioSgbvxSg())
		{
			num = 3;
			if (q56X9g2Cs5ItBwUX6JL())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 1;
			if (1 == 0)
			{
				goto IL_00c3;
			}
		}
		goto IL_007e;
		IL_002e:
		_003CUndo_003Ed__10 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (false)
		{
			goto IL_0048;
		}
		goto IL_007e;
		IL_00c3:
		return stateMachine._003C_003Et__builder.Task;
		IL_0048:
		stateMachine._003C_003Et__builder = b00tjH2Fpyn4svbCa9J();
		num = 4;
		if (q56X9g2Cs5ItBwUX6JL())
		{
			goto IL_0064;
		}
		goto IL_007e;
		IL_0064:
		stateMachine._003C_003E1__state = -1;
		goto IL_002e;
		IL_007e:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 0:
			case 3:
				goto IL_0048;
			case 1:
			case 2:
				goto IL_0064;
			default:
				num = 5;
				continue;
			case 4:
				stateMachine._003C_003E4__this = this;
				goto IL_0064;
			case 6:
				goto IL_00c3;
			}
			break;
		}
		goto IL_002e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveAllInputsOutputsAsync_003Ed__11))]
	private Task eAki5PIubK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CRemoveAllInputsOutputsAsync_003Ed__11 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				if (SXRJxG26BbioSgbvxSg())
				{
					num = 1;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				}
				num = 5;
				if (q56X9g2Cs5ItBwUX6JL())
				{
				}
				break;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
				stateMachine._003C_003Et__builder = b00tjH2Fpyn4svbCa9J();
				num = 4;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveAllElementsAsync_003Ed__12))]
	private Task fGPip1or1F(FormatDataBase P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CRemoveAllElementsAsync_003Ed__12 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
				stateMachine._003C_003Et__builder = b00tjH2Fpyn4svbCa9J();
				num = 5;
				break;
			case 5:
				stateMachine.formatData = P_0;
				_ = 0;
				num = ((!SXRJxG26BbioSgbvxSg()) ? 1 : 4);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void w6sp9e2AO1ZLbii2efa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zcCp172Rl9n4wuX5Tp4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CommStepViewModel)P_0).FactoryProtocol;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object s533eF2WorqnlF8oUMI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FactoryProtocol)P_0).GEu2LkjbgE();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wWNuhs2TjU3Xykl1VbT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EditStringViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SXRJxG26BbioSgbvxSg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool q56X9g2Cs5ItBwUX6JL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object V5SyYe2yOuLmrKf4gK5(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((TypeConverter)P_0).ConvertToString(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DLk8AX202q5rM4E7YM2(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder b00tjH2Fpyn4svbCa9J()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
