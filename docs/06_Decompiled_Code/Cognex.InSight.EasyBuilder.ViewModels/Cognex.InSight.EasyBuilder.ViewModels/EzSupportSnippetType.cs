using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Foundations.Mvvm.Common;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.Internal;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels;

public abstract class EzSupportSnippetType : EzSnippetType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddSupportSnippet_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzSupportSnippet> _003C_003Et__builder;

		public EzSupportSnippetType _003C_003E4__this;

		public ISnippetManager snippetManager;

		private EzSupportSnippet _003CsupportSnippet_003E5__2;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private CvsCellRange _003CpasteRange_003E5__5;

		private TaskAwaiter<CvsCellRange> _003C_003Eu__1;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__2;

		private TaskAwaiter<EzSupportSnippet> _003C_003Eu__3;

		private TaskAwaiter<bool> _003C_003Eu__4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			(Guid, CvsCellRange) tuple = default;
			EzSupportSnippetType ezSupportSnippetType = default;
			TaskAwaiter<EzSupportSnippet> awaiter4 = default;
			TaskAwaiter<CvsCellRange> awaiter2 = default;
			TaskAwaiter<CvsCellCollection> awaiter3 = default;
			CvsCellRange cvsCellRange = default;
			CvsCellCollection result3 = default;
			(Guid, CvsCellRange) tuple2 = default;
			int num2 = default;
			EzSupportSnippet result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					try
					{
						TaskAwaiter<bool> awaiter;
						if ((uint)num2 > 3u)
						{
							if (num2 == 4)
							{
								awaiter = _003C_003Eu__4;
								_003C_003Eu__4 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0562;
							}
							_003C_003E7__wrap3 = 0;
						}
						try
						{
							int num3;
							switch (num2)
							{
							default:
								tuple = ((EasyBuilderApplicationViewModel)XJ7HYnKDx8ofJ7sRnmS4(ezSupportSnippetType.Parent)).CommIoSnippets.Find(ezSupportSnippetType.einpbkPfEP);
								num3 = 19;
								goto IL_03ca;
							case 3:
								awaiter4 = _003C_003Eu__3;
								num3 = 6;
								if (false)
								{
									goto IL_0089;
								}
								goto IL_03ca;
							case 0:
								awaiter2 = _003C_003Eu__1;
								num3 = 25;
								goto IL_03ca;
							case 2:
								awaiter3 = _003C_003Eu__2;
								num3 = 8;
								goto IL_03ca;
							case 1:
								{
									awaiter2 = _003C_003Eu__1;
									_003C_003Eu__1 = default;
									goto IL_02da;
								}
								IL_03ca:
								while (true)
								{
									EzSupportSnippet result2;
									switch (num3)
									{
									case 9:
										return;
									case 20:
										break;
									case 30:
										if (!awaiter2.IsCompleted)
										{
											num3 = 14;
											if (true)
											{
												continue;
											}
											goto case 10;
										}
										goto case 29;
									case 10:
										_003CpasteRange_003E5__5 = cvsCellRange;
										goto IL_00c1;
									case 11:
										awaiter4 = ezSupportSnippetType.CreateSupportSnippet(ezSupportSnippetType.Guids[0], result3, _003CpasteRange_003E5__5).GetAwaiter();
										if (!awaiter4.IsCompleted)
										{
											num3 = 12;
											if (true)
											{
												continue;
											}
											goto case 28;
										}
										goto IL_02bf;
									case 28:
										if (!awaiter2.IsCompleted)
										{
											num3 = 5;
											continue;
										}
										goto IL_02e3;
									case 22:
										return;
									case 25:
										_003C_003Eu__1 = default;
										num3 = 27;
										if (rRV55qKDUnWCuVcCFcWr())
										{
											continue;
										}
										goto case 8;
									case 8:
										_003C_003Eu__2 = default;
										num2 = (_003C_003E1__state = -1);
										goto IL_017f;
									case 21:
										awaiter2 = ezSupportSnippetType.PasteSupportSnippet(ezSupportSnippetType.SnippetObjects[0], _003CpasteRange_003E5__5).GetAwaiter();
										num3 = 30;
										if (true)
										{
											continue;
										}
										goto case 31;
									case 31:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num3 = 22;
										if (true)
										{
											continue;
										}
										goto case 19;
									case 19:
										tuple2 = tuple;
										num3 = 3;
										continue;
									case 1:
										goto IL_01e4;
									case 3:
										if (!meKg0pKDmryZlbjV7nfc(tuple2.Item1, default))
										{
											num3 = 1;
											if (true)
											{
												continue;
											}
											return;
										}
										goto case 13;
									case 23:
										return;
									case 0:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										num3 = 9;
										if (HhDDgYKDHN5bl9voF14c())
										{
										}
										continue;
									case 6:
										_003C_003Eu__3 = default;
										num3 = 26;
										continue;
									case 29:
										awaiter2.GetResult();
										goto IL_00c1;
									case 26:
										num2 = (_003C_003E1__state = -1);
										goto IL_02bf;
									case 2:
									case 17:
										goto IL_02da;
									case 24:
										if (awaiter3.IsCompleted)
										{
											goto IL_017f;
										}
										num3 = 7;
										if (!HhDDgYKDHN5bl9voF14c())
										{
											continue;
										}
										goto case 7;
									case 7:
										num2 = (_003C_003E1__state = 2);
										_003C_003Eu__2 = awaiter3;
										num3 = 20;
										continue;
									case 4:
									case 16:
										return;
									case 14:
										num2 = (_003C_003E1__state = 0);
										num3 = 18;
										if (true)
										{
											continue;
										}
										goto case 12;
									case 12:
										num2 = (_003C_003E1__state = 3);
										_003C_003Eu__3 = awaiter4;
										num3 = 0;
										continue;
									case 27:
										num2 = (_003C_003E1__state = -1);
										num3 = 29;
										continue;
									case 13:
										_003CpasteRange_003E5__5 = tuple.Item2;
										num3 = 21;
										continue;
									case 5:
										num2 = (_003C_003E1__state = 1);
										goto case 15;
									default:
										num3 = 15;
										continue;
									case 15:
										_003C_003Eu__1 = awaiter2;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										_ = 0;
										num3 = (rRV55qKDUnWCuVcCFcWr() ? 4 : 2);
										continue;
									case 18:
										_003C_003Eu__1 = awaiter2;
										num3 = 31;
										continue;
									case 32:
										{
											_003CpasteRange_003E5__5 = default;
											goto end_IL_002f;
										}
										IL_02bf:
										result2 = awaiter4.GetResult();
										_003CsupportSnippet_003E5__2 = result2;
										num3 = 32;
										continue;
										IL_00c1:
										awaiter3 = ((CvsCogSocketSheet)B8pLiKKDcshARqMUaEad(QUgKPhKD21UiUd0KnCAp(hB2RpDKDNq5EF1SDPiJr(ezSupportSnippetType)))).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
										num3 = 24;
										continue;
										IL_017f:
										result3 = awaiter3.GetResult();
										num3 = 11;
										continue;
									}
									break;
									IL_01e4:
									CvsCellRange item = tuple2.Item2;
									cvsCellRange = default;
									if (e63eaDKDQIE24SYKa9hI(item, cvsCellRange))
									{
										num3 = 13;
										continue;
									}
									awaiter2 = ezSupportSnippetType.PasteSupportSnippet(ezSupportSnippetType.SnippetObjects[0], null, snippetManager).GetAwaiter();
									num3 = 28;
								}
								goto IL_0089;
								IL_02da:
								num2 = (_003C_003E1__state = -1);
								goto IL_02e3;
								IL_02e3:
								cvsCellRange = awaiter2.GetResult();
								num3 = 10;
								goto IL_03ca;
								IL_0089:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								num3 = 23;
								goto IL_03ca;
								end_IL_002f:
								break;
							}
						}
						catch (ArgumentOutOfRangeException ex)
						{
							_003C_003E7__wrap2 = ex;
							_003C_003E7__wrap3 = 1;
						}
						int num4 = _003C_003E7__wrap3;
						if (num4 == 1)
						{
							ArgumentOutOfRangeException ex2 = (ArgumentOutOfRangeException)_003C_003E7__wrap2;
							string text = (string)UgUmsDKD1ny3xxXZ0dKi();
							object broadcaster = yrFBV1KDuA59krvhhJQ7();
							EzSupportSnippetType sender = ezSupportSnippetType;
							ErrorMessageViewModel errorMessageViewModel = new ErrorMessageViewModel();
							Fc3HcsKDh0W7f6pgfxcE(errorMessageViewModel, text);
							errorMessageViewModel.Message = text;
							eU30l3KDtymeETTNii2l(errorMessageViewModel, ex2);
							awaiter = ((IViewModelBroadcaster)broadcaster).Broadcast(sender, errorMessageViewModel).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 4);
								_003C_003Eu__4 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0562;
						}
						goto IL_058c;
						IL_0562:
						awaiter.GetResult();
						zKJUNaKiLV3aKk8FtCUF(ewpXudKDz3PSLCEPRRQN((_003C_003E7__wrap2 as Exception) ?? throw _003C_003E7__wrap2));
						goto IL_058c;
						IL_058c:
						_003C_003E7__wrap2 = null;
						result = _003CsupportSnippet_003E5__2;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CsupportSnippet_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 6;
				default:
					num = 6;
					break;
				case 4:
					num2 = _003C_003E1__state;
					_ = 0;
					if (rRV55qKDUnWCuVcCFcWr())
					{
						num = 5;
						break;
					}
					num = 0;
					if (0 == 0)
					{
						break;
					}
					return;
				case 3:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					break;
				case 6:
					_003CsupportSnippet_003E5__2 = null;
					num = 3;
					break;
				case 1:
				case 5:
					ezSupportSnippetType = _003C_003E4__this;
					goto case 0;
				case 7:
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
		internal static object XJ7HYnKDx8ofJ7sRnmS4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool meKg0pKDmryZlbjV7nfc(Guid P_0, Guid P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0 != P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool e63eaDKDQIE24SYKa9hI(CvsCellRange P_0, CvsCellRange P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0 != P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hB2RpDKDNq5EF1SDPiJr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QUgKPhKD21UiUd0KnCAp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object B8pLiKKDcshARqMUaEad(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UgUmsDKD1ny3xxXZ0dKi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.Ks3LSV115L();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yrFBV1KDuA59krvhhJQ7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ViewModelBroadcaster.Default;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Fc3HcsKDh0W7f6pgfxcE(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BaseMessageViewModel)P_0).Heading = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void eU30l3KDtymeETTNii2l(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ErrorMessageViewModel)P_0).Exception = (Exception)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ewpXudKDz3PSLCEPRRQN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void zKJUNaKiLV3aKk8FtCUF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rRV55qKDUnWCuVcCFcWr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HhDDgYKDHN5bl9voF14c()
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
	private struct _003CPasteSupportSnippet_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCellRange> _003C_003Et__builder;

		public CvsCellCollection cells;

		public EzSupportSnippetType _003C_003E4__this;

		public ISnippetManager snippetManager;

		public PasteBuffer pasteObject;

		private CvsCellRange _003CpasteRange_003E5__2;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		private TaskAwaiter<CvsCellRange> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!CP4M0wKiK6JtqPWjZPrm())
			{
				goto IL_001e;
			}
			goto IL_03bf;
			IL_001e:
			CvsCellRange result = default;
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_03bf;
			IL_03bf:
			int num2 = default;
			EzSupportSnippetType ezSupportSnippetType = default;
			TaskAwaiter<CvsCellCollection> awaiter2 = default;
			TaskAwaiter<CvsCellRange> awaiter = default;
			CvsCellCollection result2 = default;
			CvsCellRange result3 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					n5KeLyKi5Q2JlPYjebfT();
					num = ((!CP4M0wKiK6JtqPWjZPrm()) ? 2 : 5);
					continue;
				case 1:
				case 5:
					ezSupportSnippetType = _003C_003E4__this;
					num = 0;
					continue;
				case 0:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							if (cells == null)
							{
								num3 = 3;
								goto IL_0106;
							}
							goto IL_0235;
						case 0:
							awaiter2 = _003C_003Eu__1;
							num3 = 9;
							goto IL_0106;
						case 1:
							awaiter = _003C_003Eu__2;
							num3 = 5;
							goto IL_0106;
						case 2:
							{
								awaiter = _003C_003Eu__2;
								num3 = 4;
								goto IL_0106;
							}
							IL_02f8:
							num2 = (_003C_003E1__state = -1);
							goto IL_0301;
							IL_0235:
							awaiter = snippetManager.GetSnippetLocation(cells, JOM5FGKieQ4CPt2UQ8gB(pasteObject), isRight: true).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num3 = 19;
								if (false)
								{
									return;
								}
								goto IL_0106;
							}
							goto IL_0301;
							IL_0344:
							result2 = awaiter2.GetResult();
							num3 = 14;
							if (false)
							{
								break;
							}
							goto IL_0106;
							IL_0301:
							result3 = awaiter.GetResult();
							num3 = 22;
							if (!n5KeLyKi5Q2JlPYjebfT())
							{
								goto IL_0106;
							}
							goto IL_031a;
							IL_0106:
							while (true)
							{
								switch (num3)
								{
								case 3:
									awaiter2 = ((CvsCogSocketSheet)dDuwJMKiaYRa3Z2Cm5Rv(CF6bjKKiJrFEnlLa1AEE(EkK8huKiwtln2J2eY5lp(ezSupportSnippetType)))).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
									num3 = 7;
									continue;
								case 7:
									if (!awaiter2.IsCompleted)
									{
										num3 = 2;
										if (!n5KeLyKi5Q2JlPYjebfT())
										{
											continue;
										}
										goto case 5;
									}
									goto IL_0344;
								case 5:
									_003C_003Eu__2 = default;
									num3 = 6;
									continue;
								case 16:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 13;
									continue;
								case 0:
									awaiter.GetResult();
									num3 = 24;
									if (CP4M0wKiK6JtqPWjZPrm())
									{
										continue;
									}
									goto case 18;
								case 18:
									_003C_003Eu__2 = awaiter;
									num3 = 16;
									continue;
								case 12:
								case 17:
									num2 = (_003C_003E1__state = 2);
									_003C_003Eu__2 = awaiter;
									num3 = 21;
									continue;
								case 23:
									awaiter = ezSupportSnippetType.PasteSupportSnippet(pasteObject, _003CpasteRange_003E5__2).GetAwaiter();
									num3 = 8;
									continue;
								case 4:
									_003C_003Eu__2 = default;
									goto case 11;
								case 10:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								case 14:
									cells = result2;
									num3 = 15;
									continue;
								case 15:
									break;
								case 13:
									return;
								case 8:
									if (awaiter.IsCompleted)
									{
										goto case 0;
									}
									_ = 0;
									if (!CP4M0wKiK6JtqPWjZPrm())
									{
										num3 = 11;
										if (0 == 0)
										{
											continue;
										}
										goto case 10;
									}
									num3 = 12;
									continue;
								case 11:
								case 20:
									num2 = (_003C_003E1__state = -1);
									num3 = 0;
									continue;
								case 22:
									_003CpasteRange_003E5__2 = result3;
									num3 = 23;
									continue;
								case 9:
									_003C_003Eu__1 = default;
									num3 = 1;
									continue;
								case 19:
									num2 = (_003C_003E1__state = 1);
									num3 = 18;
									continue;
								case 6:
									goto IL_02f8;
								case 2:
									goto IL_031a;
								case 1:
									goto IL_033b;
								case 21:
									goto end_IL_0067;
								case 24:
									result = _003CpasteRange_003E5__2;
									goto end_IL_0066;
								}
								break;
							}
							goto IL_0235;
							IL_031a:
							num2 = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter2;
							num3 = 10;
							if (!n5KeLyKi5Q2JlPYjebfT())
							{
								goto IL_0106;
							}
							goto IL_033b;
							IL_033b:
							num2 = (_003C_003E1__state = -1);
							goto IL_0344;
							end_IL_0067:
							break;
						}
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_0066:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_001e;
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
		internal static object EkK8huKiwtln2J2eY5lp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CF6bjKKiJrFEnlLa1AEE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dDuwJMKiaYRa3Z2Cm5Rv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange JOM5FGKieQ4CPt2UQ8gB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBuffer)P_0).Range;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CP4M0wKiK6JtqPWjZPrm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool n5KeLyKi5Q2JlPYjebfT()
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
	private struct _003CPasteSupportSnippet_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCellRange> _003C_003Et__builder;

		public PasteBuffer pasteObject;

		public EzSupportSnippetType _003C_003E4__this;

		public CvsCellRange pasteRange;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<object> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			EzSupportSnippetType ezSupportSnippetType = default;
			TaskAwaiter<object> awaiter = default;
			TaskAwaiter awaiter2 = default;
			byte[] array = default;
			CvsCellLocation cellOffset = default;
			CvsCellRange result = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					fZmAdLKiIZaNqVJlLwe7();
					num = ((!iWotsMKiOj9y4Iujvdx4()) ? 5 : 2);
					continue;
				case 1:
				case 2:
					ezSupportSnippetType = _003C_003E4__this;
					num = 0;
					continue;
				case 0:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_00a3;
							}
							num3 = 3;
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 13;
						}
						goto IL_011b;
						IL_011b:
						while (true)
						{
							switch (num3)
							{
							case 10:
								if (!awaiter2.IsCompleted)
								{
									num3 = 11;
									continue;
								}
								goto case 7;
							case 3:
								array = (byte[])WItfcSKiDcJFWwG7vUuR(pasteObject);
								num3 = 6;
								continue;
							case 0:
							case 15:
								break;
							case 5:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter;
								num3 = 2;
								continue;
							case 1:
								return;
							case 7:
							case 17:
								awaiter2.GetResult();
								goto case 8;
							default:
								num3 = 8;
								continue;
							case 14:
								return;
							case 4:
								if (cellOffset.IsValid)
								{
									num3 = 9;
									continue;
								}
								goto case 18;
							case 6:
								awaiter2 = ((Task)SWoIJKKinPqSyoZ5wbsM(ESe76vKiiqdeLeDGo7Fh(ezSupportSnippetType), pasteRange, array, false, false)).GetAwaiter();
								num3 = 10;
								if (true)
								{
									continue;
								}
								goto case 13;
							case 13:
								num2 = (_003C_003E1__state = -1);
								fZmAdLKiIZaNqVJlLwe7();
								num3 = (iWotsMKiOj9y4Iujvdx4() ? 17 : 0);
								continue;
							case 9:
								awaiter = ((CvsCogSocket)fITRKlKiVCH6Ahuqi40w(ESe76vKiiqdeLeDGo7Fh(ezSupportSnippetType))).Sheet.PutCellExpressionAsync(expression: ((EasyBuilderApplicationViewModel)srtCTmKifHP4ymd9pVAx(ezSupportSnippetType.Parent)).Acquired2DImageLocation.ToString(absoluteRow: true, absoluteColumn: true), location: ezSupportSnippetType.GetCellLocation(pasteRange.Location, cellOffset)).GetAwaiter();
								num3 = 16;
								continue;
							case 11:
								num2 = (_003C_003E1__state = 0);
								num3 = 12;
								continue;
							case 12:
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 14;
								continue;
							case 8:
								cellOffset = pasteObject.GetCellOffset([MethodImpl(MethodImplOptions.NoInlining)] (PasteBufferCell P_0) =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									string value = (string)Gqsg3R5N3I1XKtvkW1s(1390);
									return P_0.Name.EndsWith(value, StringComparison.Ordinal);
								});
								num3 = 4;
								continue;
							case 16:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								break;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 1;
								continue;
							case 18:
								result = pasteRange;
								goto end_IL_011b;
							}
							goto IL_00a3;
							continue;
							end_IL_011b:
							break;
						}
						goto end_IL_0060;
						IL_00a3:
						awaiter.GetResult();
						num3 = 18;
						goto IL_011b;
						end_IL_0060:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult(result);
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
		internal static object WItfcSKiDcJFWwG7vUuR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBuffer)P_0).ToBytes();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ESe76vKiiqdeLeDGo7Fh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SWoIJKKinPqSyoZ5wbsM(object P_0, CvsCellRange P_1, object P_2, bool P_3, bool P_4)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).PasteCellsAsync(P_1, (byte[])P_2, P_3, P_4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fITRKlKiVCH6Ahuqi40w(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object srtCTmKifHP4ymd9pVAx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iWotsMKiOj9y4Iujvdx4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fZmAdLKiIZaNqVJlLwe7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	protected const string InputImageCellName = "InputImage";

	[CompilerGenerated]
	private readonly CvsInSight RaRpQXhlWE;

	private AppStepViewModel VWRpguTnfl;

	protected override CvsInSight InSight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return RaRpQXhlWE;
		}
	}

	protected AppStepViewModel Parent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return VWRpguTnfl;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VWRpguTnfl = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected EzSupportSnippetType(AppStepViewModel appStepVm)
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
				VWRpguTnfl = appStepVm;
				num = 5;
				continue;
			case 3:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				HOWB7F5miFHF0GJ4sUl();
				if (b1JQTv5xwXQhGxsSL6F())
				{
					num = 0;
					continue;
				}
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 0:
			case 1:
				base._002Ector();
				goto default;
			case 5:
				break;
			}
			break;
		}
		RaRpQXhlWE = (CvsInSight)((appStepVm != null) ? BtQ80F5QvSbxEapctds(appStepVm) : null);
	}

	public abstract Task<EzSupportSnippet> CreateSupportSnippet(Guid guid, CvsCellCollection cells, CvsCellRange cellRange);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddSupportSnippet_003Ed__10))]
	public virtual Task<EzSupportSnippet> AddSupportSnippet(ISnippetManager snippetManager)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddSupportSnippet_003Ed__10 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzSupportSnippet>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.snippetManager = snippetManager;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPasteSupportSnippet_003Ed__11))]
	public virtual Task<CvsCellRange> PasteSupportSnippet(PasteBuffer pasteObject, CvsCellCollection cells, ISnippetManager snippetManager)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CPasteSupportSnippet_003Ed__11 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCellRange>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.pasteObject = pasteObject;
		stateMachine.cells = cells;
		stateMachine.snippetManager = snippetManager;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPasteSupportSnippet_003Ed__12))]
	public Task<CvsCellRange> PasteSupportSnippet(PasteBuffer pasteObject, CvsCellRange pasteRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CPasteSupportSnippet_003Ed__12 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCellRange>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.pasteObject = pasteObject;
		stateMachine.pasteRange = pasteRange;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool einpbkPfEP((Guid guid, CvsCellRange range) s)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return s.guid.Equals(Guids[0]);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	internal static bool nS1pcTqVfd(PasteBufferCell P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string value = (string)Gqsg3R5N3I1XKtvkW1s(1390);
		return P_0.Name.EndsWith(value, StringComparison.Ordinal);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BtQ80F5QvSbxEapctds(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool b1JQTv5xwXQhGxsSL6F()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HOWB7F5miFHF0GJ4sUl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Gqsg3R5N3I1XKtvkW1s(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}
}
