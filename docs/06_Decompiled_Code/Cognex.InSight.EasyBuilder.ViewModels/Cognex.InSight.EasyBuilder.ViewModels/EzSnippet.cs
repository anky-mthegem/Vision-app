using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Extensions;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.Internal;
using Cognex.InSight.Runtime;
using Cognex.InSight.Runtime.Extensions;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.Mvvm;
using in5ehVvjOmsr0LqxP1;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels;

public abstract class EzSnippet : BaseViewModel, IAsyncDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSetCellRangeAsync_003Ed__99 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzSnippet _003C_003E4__this;

		public CvsCellRange cellRange;

		public CvsCellCollection cells;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			X76IkaKI8L0J1O00bpUr();
			int num;
			if (r7Kqt0KIkMsXPAJtTWZN())
			{
				num = 4;
			}
			else
			{
				num = 1;
				if (1 == 0)
				{
					goto IL_01cb;
				}
			}
			goto IL_0198;
			IL_01cb:
			EzSnippet ezSnippet = _003C_003E4__this;
			num = 5;
			if (!X76IkaKI8L0J1O00bpUr())
			{
				goto IL_0198;
			}
			goto IL_01e2;
			IL_01e2:
			int num2 = _003C_003E1__state;
			num = 2;
			goto IL_0198;
			IL_0198:
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							ezSnippet.CellRange = cellRange;
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 9;
							if (!r7Kqt0KIkMsXPAJtTWZN())
							{
								goto IL_0073;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 1:
								return;
							case 5:
								return;
							case 4:
							case 6:
								break;
							case 9:
								_003C_003Eu__1 = default;
								num3 = 2;
								continue;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 10;
							case 7:
								awaiter = rrDc7AKIqDZAWhrX7gcW(ezSnippet.Parse(cells));
								num3 = 0;
								if (0 == 0)
								{
									continue;
								}
								goto case 3;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								if (r7Kqt0KIkMsXPAJtTWZN())
								{
									continue;
								}
								goto case 8;
							case 8:
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								X76IkaKI8L0J1O00bpUr();
								num3 = ((!r7Kqt0KIkMsXPAJtTWZN()) ? 1 : 6);
								continue;
							case 10:
								awaiter.GetResult();
								goto end_IL_010d;
							}
							goto IL_0073;
							continue;
							end_IL_010d:
							break;
						}
						goto end_IL_0028;
						IL_0073:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_0028:;
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
				case 0:
				case 4:
					goto IL_01e2;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_01cb;
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
		internal static TaskAwaiter rrDc7AKIqDZAWhrX7gcW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool r7Kqt0KIkMsXPAJtTWZN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool X76IkaKI8L0J1O00bpUr()
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
	private struct _003CAwaitIfUpdatingName_003Ed__100 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzSnippet _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Gd5xgEKIpO3g7Tvucd0X();
			int num;
			if (EOFFasKIEvS0unn2qZ4x())
			{
				num = 2;
			}
			else
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_0236;
				}
			}
			goto IL_0203;
			IL_0203:
			int num2 = default;
			EzSnippet ezSnippet = default;
			TaskAwaiter<bool> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 5:
					ezSnippet = _003C_003E4__this;
					num = 1;
					if (Gd5xgEKIpO3g7Tvucd0X())
					{
					}
					continue;
				case 1:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
							goto IL_0124;
						}
						if (ezSnippet.IsUpdatingName)
						{
							num3 = 5;
							goto IL_0124;
						}
						goto end_IL_0054;
						IL_0124:
						while (true)
						{
							switch (num3)
							{
							case 3:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 11:
								awaiter.GetResult();
								num3 = 4;
								continue;
							case 1:
							case 6:
								awaiter = Task.Run((Func<bool>)ezSnippet.YwF52VtFd3).GetAwaiter();
								num3 = 9;
								continue;
							case 8:
								return;
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 11;
							case 2:
								_003C_003Eu__1 = default;
								goto case 7;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								continue;
							case 7:
							case 10:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								continue;
							case 5:
								ezSnippet.aul5h6rd01 = new AutoResetEvent(initialState: false);
								_ = 1;
								if (Gd5xgEKIpO3g7Tvucd0X())
								{
									num3 = 10;
									continue;
								}
								num3 = 6;
								if (!Gd5xgEKIpO3g7Tvucd0X())
								{
									continue;
								}
								goto case 4;
							case 4:
							{
								AutoResetEvent aul5h6rd = ezSnippet.aul5h6rd01;
								if (aul5h6rd == null)
								{
									num3 = 12;
									continue;
								}
								E6B1bfKIXbCrgy9jTgVY(aul5h6rd);
								break;
							}
							case 12:
								break;
							}
							break;
						}
						ezSnippet.aul5h6rd01 = null;
						end_IL_0054:;
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
			goto IL_0236;
			IL_0236:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (false)
			{
				return;
			}
			goto IL_0203;
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
		internal static void E6B1bfKIXbCrgy9jTgVY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((WaitHandle)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EOFFasKIEvS0unn2qZ4x()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Gd5xgEKIpO3g7Tvucd0X()
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
	private struct _003CUpdateCellNames_003Ed__102 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Dictionary<string, string>> _003C_003Et__builder;

		public EzSnippet _003C_003E4__this;

		public string newSnippetName;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private CvsCellCollection _003Ccells_003E5__3;

		private Dictionary<string, string> _003Cnames_003E5__4;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		private IEnumerator<CvsCellLocation> _003C_003E7__wrap4;

		private TaskAwaiter<object> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!OHyrDBKI9gIm0L3brhNh()) ? 2 : 8);
			EzSnippet ezSnippet = default;
			TaskAwaiter<object> awaiter2 = default;
			CvsCell cvsCell = default;
			string text = default;
			string text2 = default;
			CvsCellLocation current = default;
			int num2 = default;
			string text4 = default;
			string text3 = default;
			Dictionary<string, string> result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					ezSnippet = _003C_003E4__this;
					num = 5;
					break;
				case 6:
					_003Cnames_003E5__4 = null;
					num = 4;
					break;
				case 7:
					_003Csheet_003E5__2 = null;
					goto case 3;
				default:
					num = 3;
					break;
				case 5:
					try
					{
						TaskAwaiter<CvsCellCollection> awaiter;
						CvsCellCollection result2;
						IEnumerator<CellViewModel> enumerator;
						switch (num2)
						{
						default:
							_003Csheet_003E5__2 = (CvsCogSocketSheet)ubOBusKI3BYgl7yDtbEL(VKyJkNKI7nsd0tmwLEYM(ezSnippet.InSight));
							awaiter = _003Csheet_003E5__2.RunAndGetCellResults().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_011e;
						case 0:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_011e;
						case 1:
							try
							{
								int num3;
								if (num2 != 1)
								{
									num3 = 0;
								}
								else
								{
									awaiter2 = _003C_003Eu__2;
									num3 = 15;
								}
								while (true)
								{
									IL_03ed:
									object value;
									switch (num3)
									{
									case 6:
										return;
									case 4:
									case 14:
										awaiter2.GetResult();
										num3 = 17;
										continue;
									case 11:
										if (!awaiter2.IsCompleted)
										{
											num3 = 16;
											continue;
										}
										goto case 4;
									case 1:
									case 2:
										if (cvsCell == null)
										{
											num3 = 10;
											continue;
										}
										value = rU5BBNKIFa7uqtFKvAVh(cvsCell);
										goto IL_0467;
									case 8:
										if (!text.Equals(text2, StringComparison.Ordinal))
										{
											_003Cnames_003E5__4[cvsCell.Name] = text;
											num3 = 9;
											continue;
										}
										break;
									case 13:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num3 = 6;
										if (OHyrDBKI9gIm0L3brhNh())
										{
											continue;
										}
										goto case 16;
									case 16:
										num2 = (_003C_003E1__state = 1);
										_003C_003Eu__2 = awaiter2;
										num3 = 13;
										continue;
									case 7:
										text = (string)OoiYuVKIRIGSIuMkrNE9(newSnippetName, text2);
										num3 = 5;
										continue;
									case 9:
										awaiter2 = _003Csheet_003E5__2.SetCellNameAsync(current, text).GetAwaiter();
										goto case 11;
									default:
										num3 = 11;
										continue;
									case 15:
										_003C_003Eu__2 = default;
										num3 = 12;
										continue;
									case 10:
										value = null;
										goto IL_0467;
									case 12:
										num2 = (_003C_003E1__state = -1);
										goto case 4;
									case 3:
										text2 = (string)OPmgAUKIMQ2XCANbt7Du(cvsCell);
										num3 = 7;
										continue;
									case 5:
										if (text != null)
										{
											num3 = 8;
											continue;
										}
										break;
									case 0:
									case 17:
										break;
										IL_0467:
										if (!string.IsNullOrEmpty((string)value))
										{
											num3 = 3;
											continue;
										}
										break;
									}
									while (evlVEBKITLlB8WHmAqrb(_003C_003E7__wrap4))
									{
										current = _003C_003E7__wrap4.Current;
										cvsCell = (CvsCell)Wij8K7KI0GYVIGF17Qgh(_003Ccells_003E5__3, current);
										if (current.IsValid)
										{
											dDDRGWKI4nyQoAOfiPye();
											num3 = ((!OHyrDBKI9gIm0L3brhNh()) ? 4 : 2);
											goto IL_03ed;
										}
									}
									break;
								}
							}
							finally
							{
								if (num2 < 0 && _003C_003E7__wrap4 != null)
								{
									_003C_003E7__wrap4.Dispose();
								}
							}
							_003C_003E7__wrap4 = null;
							awaiter = _003Csheet_003E5__2.RunAndGetCellResults().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 2);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							break;
						case 2:
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								break;
							}
							IL_011e:
							result2 = awaiter.GetResult();
							_003Ccells_003E5__3 = result2;
							_003Cnames_003E5__4 = new Dictionary<string, string>();
							enumerator = ezSnippet.AllProperties.GetEnumerator();
							try
							{
								while (evlVEBKITLlB8WHmAqrb(enumerator))
								{
									CellViewModel current2 = enumerator.Current;
									int num4 = 7;
									while (true)
									{
										switch (num4)
										{
										case 4:
											_003Cnames_003E5__4[text4] = text3;
											goto case 1;
										case 6:
											text3 = ReplaceSnippetNameInCellName(newSnippetName, text4);
											OHyrDBKI9gIm0L3brhNh();
											if (dDDRGWKI4nyQoAOfiPye())
											{
												num4 = 1;
												continue;
											}
											num4 = 8;
											if (0 == 0)
											{
												continue;
											}
											goto case 3;
										case 3:
											fcL7koKIW7r8VDSWec8s(current2, OoiYuVKIRIGSIuMkrNE9(newSnippetName, SN0piLKIAlphduU2Xgy1(current2)));
											num4 = 9;
											if (!dDDRGWKI4nyQoAOfiPye())
											{
												continue;
											}
											goto case 0;
										case 0:
											if (E85gecKI6fQpunFU6cOx(text3, text4, StringComparison.Ordinal))
											{
												break;
											}
											goto case 4;
										default:
											num4 = 4;
											continue;
										case 7:
											text4 = (string)RsXx1RKIj5vSL1o5DP6f(current2);
											num4 = 6;
											continue;
										case 2:
										case 8:
											if (text3 != null)
											{
												num4 = 0;
												continue;
											}
											break;
										case 1:
										case 5:
											fYEt4dKICJbgAOMNEdyj(current2, text3);
											num4 = 3;
											continue;
										case 9:
											break;
										}
										break;
									}
								}
							}
							finally
							{
								if (num2 < 0 && enumerator != null)
								{
									CDKSGwKIyZfIvFWaL0Qx(enumerator);
								}
							}
							_003C_003E7__wrap4 = ezSnippet.CellRange.GetEnumerator();
							goto case 1;
						}
						CvsCellCollection result3 = awaiter.GetResult();
						mTwTGVKIYaK9QWsUW2Ev(ezSnippet.Parent, result3);
						result = _003Cnames_003E5__4;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Csheet_003E5__2 = null;
						_003Ccells_003E5__3 = null;
						_003Cnames_003E5__4 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					num = 7;
					break;
				case 3:
					_003Ccells_003E5__3 = null;
					num = 6;
					break;
				case 0:
				case 8:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 9;
					if (1 == 0)
					{
						return;
					}
					break;
				case 9:
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
		internal static object VKyJkNKI7nsd0tmwLEYM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ubOBusKI3BYgl7yDtbEL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RsXx1RKIj5vSL1o5DP6f(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool E85gecKI6fQpunFU6cOx(object P_0, object P_1, StringComparison P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Equals((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fYEt4dKICJbgAOMNEdyj(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CellViewModel)P_0).CellName = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SN0piLKIAlphduU2Xgy1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).LocalizedCellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OoiYuVKIRIGSIuMkrNE9(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ReplaceSnippetNameInCellName((string)P_0, (string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fcL7koKIW7r8VDSWec8s(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CellViewModel)P_0).LocalizedCellName = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool evlVEBKITLlB8WHmAqrb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void CDKSGwKIyZfIvFWaL0Qx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Wij8K7KI0GYVIGF17Qgh(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rU5BBNKIFa7uqtFKvAVh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OPmgAUKIMQ2XCANbt7Du(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void mTwTGVKIYaK9QWsUW2Ev(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AppStepViewModel)P_0).Refresh((CvsCellCollection)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OHyrDBKI9gIm0L3brhNh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dDDRGWKI4nyQoAOfiPye()
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
	private struct _003CUpdateNameInternal_003Ed__103 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzSnippet _003C_003E4__this;

		public string newName;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<Dictionary<string, string>> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zeNnXyKIH2hBMGJQCTe1();
			int num;
			if (GuBWttKIU0eSlKbelR2I())
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_030f;
			IL_0054:
			int num2 = default;
			EzSnippet ezSnippet = default;
			try
			{
				if ((uint)num2 <= 1u || (R07txHKIxLYi5j6QRGnn(ezSnippet.Name, newName) && !ezSnippet.IsUpdatingName))
				{
					try
					{
						int num3;
						TaskAwaiter<Dictionary<string, string>> awaiter = default;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 16;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 15;
							}
							goto IL_0226;
						}
						TaskAwaiter awaiter2 = _003C_003Eu__1;
						goto IL_0184;
						IL_0226:
						Dictionary<string, string> result = default;
						while (true)
						{
							switch (num3)
							{
							case 2:
								awaiter2 = om1AYkKImjc05UyrcXCc(ezSnippet.SnippetName.WriteImmediateAsync(newName));
								if (!awaiter2.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 4;
							case 6:
								num2 = (_003C_003E1__state = -1);
								goto IL_00ca;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								_ = 0;
								if (GuBWttKIU0eSlKbelR2I())
								{
									num3 = 10;
									if (true)
									{
										continue;
									}
									goto case 17;
								}
								num3 = 13;
								continue;
							case 17:
								newName = ezSnippet.NKA5TX2DdC(newName);
								num3 = 14;
								if (zeNnXyKIH2hBMGJQCTe1())
								{
								}
								continue;
							case 15:
								_003C_003Eu__2 = default;
								num3 = 6;
								continue;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								if (!zeNnXyKIH2hBMGJQCTe1())
								{
									continue;
								}
								goto case 5;
							case 5:
								_003C_003Eu__1 = awaiter2;
								num3 = 0;
								if (GuBWttKIU0eSlKbelR2I())
								{
									continue;
								}
								goto case 14;
							case 14:
								ezSnippet.ak55jHdJKT(newName);
								num3 = 2;
								continue;
							case 16:
								ezSnippet.IsUpdatingName = true;
								num3 = 17;
								continue;
							case 11:
								num2 = (_003C_003E1__state = -1);
								num3 = 4;
								if (true)
								{
									continue;
								}
								goto case 12;
							case 12:
								_003C_003Eu__2 = awaiter;
								num3 = 9;
								continue;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 4:
								awaiter2.GetResult();
								num3 = 1;
								continue;
							case 7:
							case 10:
								return;
							case 1:
								awaiter = ezSnippet.UpdateCellNames(newName).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 12;
									continue;
								}
								goto IL_00ca;
							case 18:
								{
									ezSnippet.ED75CUrIgc(result);
									goto end_IL_0226;
								}
								IL_00ca:
								result = awaiter.GetResult();
								num3 = 18;
								continue;
							}
							goto IL_0184;
							continue;
							end_IL_0226:
							break;
						}
						goto end_IL_007d;
						IL_0184:
						_003C_003Eu__1 = default;
						num3 = 11;
						goto IL_0226;
						end_IL_007d:;
					}
					finally
					{
						if (num2 < 0)
						{
							ezSnippet.IsUpdatingName = false;
						}
					}
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0344;
			IL_030f:
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 1;
					if (true)
					{
						continue;
					}
					goto IL_0054;
				case 2:
				case 5:
					goto IL_0054;
				default:
					num = 4;
					if (zeNnXyKIH2hBMGJQCTe1())
					{
					}
					continue;
				case 4:
					goto IL_0344;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			ezSnippet = _003C_003E4__this;
			goto IL_0054;
			IL_0344:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_030f;
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
		internal static bool R07txHKIxLYi5j6QRGnn(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 != (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter om1AYkKImjc05UyrcXCc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GuBWttKIU0eSlKbelR2I()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zeNnXyKIH2hBMGJQCTe1()
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
	private struct _003COnDelete_003Ed__109 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzSnippet _003C_003E4__this;

		private AppStepViewModel _003Cparent_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private ValueTaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			int num2 = default;
			EzSnippet ezSnippet = default;
			ValueTaskAwaiter awaiter = default;
			TaskAwaiter awaiter2 = default;
			ValueTask valueTask = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					num2 = _003C_003E1__state;
					num = 6;
					continue;
				default:
					_003Cparent_003E5__2 = null;
					num = 4;
					if (true)
					{
						continue;
					}
					break;
				case 6:
					break;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 7;
					if (U7F8l9KIQS82eLEnLyJQ())
					{
						continue;
					}
					goto case 2;
				case 2:
				case 5:
					try
					{
						if ((uint)num2 > 1u)
						{
							_003Cparent_003E5__2 = ezSnippet.Parent;
						}
						try
						{
							int num3;
							if (num2 != 0)
							{
								if (num2 != 1)
								{
									U7F8l9KIQS82eLEnLyJQ();
									num3 = (SI4TENKINDq6v0ZuTX0Q() ? 9 : 2);
								}
								else
								{
									awaiter = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num3 = 4;
								}
								goto IL_019b;
							}
							awaiter2 = _003C_003Eu__1;
							goto IL_0209;
							IL_0209:
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 13;
							goto IL_019b;
							IL_019b:
							while (true)
							{
								switch (num3)
								{
								case 1:
								case 9:
									DpiAJoKIcX6SP3kuwana(ezSnippet.DeleteCommand);
									num3 = 5;
									continue;
								case 6:
									num2 = (_003C_003E1__state = 0);
									num3 = 12;
									continue;
								case 15:
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter;
									num3 = 14;
									continue;
								case 10:
									valueTask = Lbpt53KIuFaThVXm6sik(ezSnippet);
									num3 = 11;
									continue;
								case 5:
									awaiter2 = H9cnOPKI1YESjGOZBfV7(ezSnippet.UgQ54sEslO());
									num3 = 17;
									continue;
								case 16:
									if (!awaiter.IsCompleted)
									{
										num3 = 15;
										continue;
									}
									goto case 18;
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 8;
									continue;
								case 12:
									_003C_003Eu__1 = awaiter2;
									num3 = 3;
									continue;
								case 13:
									awaiter2.GetResult();
									num3 = 10;
									continue;
								case 11:
									awaiter = valueTask.GetAwaiter();
									num3 = 16;
									if (0 == 0)
									{
										continue;
									}
									return;
								case 8:
									return;
								default:
									num3 = 7;
									continue;
								case 4:
									num2 = (_003C_003E1__state = -1);
									num3 = 18;
									continue;
								case 7:
									break;
								case 17:
									if (!awaiter2.IsCompleted)
									{
										num3 = 6;
										continue;
									}
									goto case 13;
								case 14:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 0:
								case 2:
									HikIxpKI2mNWcdyI8Ukg(_003Cparent_003E5__2, false);
									goto case 1;
								case 18:
									awaiter.GetResult();
									goto end_IL_019b;
								}
								goto IL_0209;
								continue;
								end_IL_019b:
								break;
							}
						}
						finally
						{
							if (num2 < 0)
							{
								HikIxpKI2mNWcdyI8Ukg(_003Cparent_003E5__2, true);
							}
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cparent_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 7:
					return;
				}
				ezSnippet = _003C_003E4__this;
				_ = 1;
				num = ((!SI4TENKINDq6v0ZuTX0Q()) ? 5 : 0);
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
		internal static void HikIxpKI2mNWcdyI8Ukg(object P_0, bool value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AppStepViewModel)P_0).tavmqlZOoL(value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void DpiAJoKIcX6SP3kuwana(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BaseDelegateCommand)P_0).RaiseCanExecuteChanged();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter H9cnOPKI1YESjGOZBfV7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ValueTask Lbpt53KIuFaThVXm6sik(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).DisposeAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool U7F8l9KIQS82eLEnLyJQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SI4TENKINDq6v0ZuTX0Q()
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
	private struct _003CFireRemoveEventAsync_003Ed__111 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzSnippet _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (hZN75uKIhR1Qow3q2Tbe())
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_01a7;
			IL_0026:
			EzSnippet ezSnippet = _003C_003E4__this;
			num = 2;
			goto IL_01a7;
			IL_01a7:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					break;
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = k6FwomKIzbTZULH5Wbjx(ezSnippet.RXF5lY8rP5(ezSnippet.yrH5L6uEKS, EventArgs.Empty));
							num3 = 2;
							if (Mua29oKItKP5kS0rDR1l())
							{
								goto IL_007b;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
							if (false)
							{
								goto IL_00bc;
							}
						}
						goto IL_011e;
						IL_00bc:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_011e;
						IL_011e:
						while (true)
						{
							switch (num3)
							{
							case 2:
								break;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								continue;
							case 0:
							case 4:
								return;
							case 3:
							case 6:
								goto IL_00bc;
							case 1:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								continue;
							case 5:
								_003C_003Eu__1 = default;
								goto IL_00bc;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								_ = 1;
								if (Mua29oKItKP5kS0rDR1l())
								{
									num3 = 3;
									if (0 == 0)
									{
										continue;
									}
									goto case 7;
								}
								num3 = 0;
								if (hZN75uKIhR1Qow3q2Tbe())
								{
									continue;
								}
								goto IL_0167;
							case 9:
								goto IL_0167;
							}
							break;
						}
						goto IL_007b;
						IL_007b:
						if (!awaiter.IsCompleted)
						{
							num3 = 8;
							goto IL_011e;
						}
						goto IL_0167;
						IL_0167:
						awaiter.GetResult();
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
					continue;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
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
		internal static TaskAwaiter k6FwomKIzbTZULH5Wbjx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hZN75uKIhR1Qow3q2Tbe()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Mua29oKItKP5kS0rDR1l()
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
	private struct _003CFireAsyncEvent_003Ed__112 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Func<object, EventArgs, Task> handler;

		public EzSnippet _003C_003E4__this;

		public EventArgs e;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (jUdWJYKDKJApsgP3V5tv() ? 2 : 4);
			int num2 = default;
			TaskAwaiter awaiter = default;
			int num4 = default;
			Delegate[] array2 = default;
			Task[] array = default;
			EzSnippet arg = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 5:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
							goto IL_0181;
						}
						if (handler != null)
						{
							num3 = 12;
							goto IL_0181;
						}
						goto end_IL_0035;
						IL_0181:
						while (true)
						{
							switch (num3)
							{
							case 10:
								_003C_003Eu__1 = awaiter;
								goto case 4;
							case 3:
								num4 = 0;
								num3 = 13;
								continue;
							case 6:
								return;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 9;
								continue;
							case 4:
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								continue;
							case 11:
								num2 = (_003C_003E1__state = 0);
								num3 = 10;
								continue;
							case 12:
								array2 = (Delegate[])zPm0tRKD56N4qNHITmRY(handler);
								array = new Task[array2.Length];
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
								num4++;
								num3 = 1;
								continue;
							case 1:
							case 13:
								do
								{
									if (num4 < array2.Length)
									{
										array[num4] = ((Func<object, EventArgs, Task>)array2[num4])(arg, e);
										num3 = 0;
										continue;
									}
									_ = 0;
									if (!qim6xJKDLjo1SdY4AVOC())
									{
										num3 = 4;
										break;
									}
									num3 = 7;
									if (jUdWJYKDKJApsgP3V5tv())
									{
									}
									break;
								}
								while (!qim6xJKDLjo1SdY4AVOC());
								continue;
							case 5:
							case 7:
								awaiter = dKwqk7KDJUwgpXWyQtld(jsmf6ZKDwuPL8B1O6BjB(array));
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 11;
							default:
								num3 = 11;
								if (qim6xJKDLjo1SdY4AVOC())
								{
									continue;
								}
								goto case 9;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 14;
								if (true)
								{
									continue;
								}
								break;
							case 14:
								break;
							}
							break;
						}
						awaiter.GetResult();
						end_IL_0035:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 1:
					arg = _003C_003E4__this;
					num = 5;
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
		internal static object zPm0tRKD56N4qNHITmRY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Delegate)P_0).GetInvocationList();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jsmf6ZKDwuPL8B1O6BjB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.WhenAll((Task[])P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter dKwqk7KDJUwgpXWyQtld(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qim6xJKDLjo1SdY4AVOC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jUdWJYKDKJApsgP3V5tv()
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
	private struct _003COnCopy_003Ed__124 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzSnippet _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!kqv9jhKDa7b4iwd9hrNp()) ? 1 : 3);
			int num2 = default;
			EzSnippet ezSnippet = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 1:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ezSnippet.RXF5lY8rP5(ezSnippet.EhM5VjwYDs, EventArgs.Empty).GetAwaiter();
							num3 = 2;
							if (false)
							{
								goto IL_005e;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
						}
						goto IL_00ed;
						IL_00ed:
						while (true)
						{
							switch (num3)
							{
							case 5:
								break;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								goto case 9;
							default:
								return;
							case 7:
								return;
							case 0:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								continue;
							case 1:
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 8;
								continue;
							case 9:
								awaiter.GetResult();
								goto end_IL_00ed;
							}
							goto IL_005e;
							continue;
							end_IL_00ed:
							break;
						}
						goto end_IL_0035;
						IL_005e:
						_003C_003Eu__1 = awaiter;
						_ = 1;
						num3 = ((!hELUPIKDeWoyLroeP1Gm()) ? 1 : 7);
						goto IL_00ed;
						end_IL_0035:;
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
					num = 4;
					continue;
				case 5:
					ezSnippet = _003C_003E4__this;
					goto case 1;
				case 4:
					break;
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
		internal static bool kqv9jhKDa7b4iwd9hrNp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hELUPIKDeWoyLroeP1Gm()
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
	private struct _003CFireCopyEvent_003Ed__126 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzSnippet _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			EzSnippet ezSnippet = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ezSnippet.RXF5lY8rP5(ezSnippet.EhM5VjwYDs, EventArgs.Empty).GetAwaiter();
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
							if (ML1nasKDINlnDw3xwnVL())
							{
								goto IL_00e5;
							}
						}
						goto IL_008c;
						IL_00e5:
						_003C_003Eu__1 = default;
						num3 = 3;
						goto IL_008c;
						IL_008c:
						while (true)
						{
							switch (num3)
							{
							case 0:
								num2 = (_003C_003E1__state = 0);
								rMJUJdKDOxOR0kW20eLA();
								if (!ML1nasKDINlnDw3xwnVL())
								{
									num3 = 5;
									if (ML1nasKDINlnDw3xwnVL())
									{
									}
								}
								else
								{
									num3 = 6;
								}
								continue;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								return;
							case 6:
								return;
							case 1:
								break;
							case 2:
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 7;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									if (true)
									{
										continue;
									}
									goto case 3;
								}
								goto case 9;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 9:
								awaiter.GetResult();
								goto end_IL_008c;
							}
							goto IL_00e5;
							continue;
							end_IL_008c:
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						break;
					}
					goto case 5;
				case 5:
					num2 = _003C_003E1__state;
					num = 0;
					break;
				case 0:
					ezSnippet = _003C_003E4__this;
					rMJUJdKDOxOR0kW20eLA();
					num = (ML1nasKDINlnDw3xwnVL() ? 1 : 4);
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
		internal static bool rMJUJdKDOxOR0kW20eLA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ML1nasKDINlnDw3xwnVL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public const string InternalPrefix = "_";

	public const string PropertySeparator = ".";

	private string tpB5t32vZm;

	[CompilerGenerated]
	private readonly AsyncDelegateCommand xF95YeQ1Nl;

	[CompilerGenerated]
	private AsyncDelegateCommand w9G505IrBw;

	[CompilerGenerated]
	private Func<object, EventArgs, Task> EhM5VjwYDs;

	[CompilerGenerated]
	private Func<object, EventArgs, Task> yrH5L6uEKS;

	[CompilerGenerated]
	private EventHandler w925JHGE2W;

	[CompilerGenerated]
	private SnippetRenamedEventHandler vII59tUvOM;

	[CompilerGenerated]
	private EventHandler n8b5rihyYD;

	private AutoResetEvent aul5h6rd01;

	private string WR3583PGQr;

	private CvsCellRange Ohd5m88ZeK;

	private CvsInSight OGa51F3y3C;

	private AppStepViewModel FI15zgyXu1;

	private readonly List<CellViewModel> t7ypaLonr9;

	[CompilerGenerated]
	private readonly ObservableCollection<CellViewModel> peSp5SJ3wo;

	[CompilerGenerated]
	private Func<CellViewModel, bool> EnspphEXpM;

	private bool l9RpUjNe1T;

	[CompilerGenerated]
	private EditIntViewModel IFxp7ueNNq;

	[CompilerGenerated]
	private SnippetNameViewModel IycpNlPUmt;

	private BaseViewModel LkBpA74trk;

	[CompilerGenerated]
	private IRuntimeService JP7pdOS5eL;

	[CompilerGenerated]
	private IRuntimeModeService iBLp63pInk;

	[CompilerGenerated]
	private SnippetLocalizer Rxipux55rl;

	public AsyncDelegateCommand DeleteCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xF95YeQ1Nl;
		}
	}

	public AsyncDelegateCommand CopyCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return w9G505IrBw;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			w9G505IrBw = value;
		}
	}

	public virtual string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WR3583PGQr;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			H3YdH2KTFuY61nEUylh();
			int num = (cI6aEMKyaclniTrcgRI() ? 1 : 6);
			while (true)
			{
				switch (num)
				{
				case 3:
					if (UH1ICyKQxJ0dSSZooTK(value))
					{
						goto case 1;
					}
					return;
				case 0:
				case 6:
					if (Y4WGotKm1aSXFyG8x9c(WR3583PGQr, value))
					{
						num = 3;
						break;
					}
					return;
				case 5:
					WR3583PGQr = value;
					num = 7;
					break;
				case 4:
					R4f7dbK21xUtmAQicuN(SnippetName.SetValue(value));
					num = 5;
					if (H3YdH2KTFuY61nEUylh())
					{
						break;
					}
					goto case 1;
				case 1:
				case 2:
					if (!doAMB8KNe6VG5K9XcFW(Parent, value))
					{
						goto case 4;
					}
					return;
				default:
					num = 4;
					break;
				case 7:
					return;
				}
			}
		}
	}

	public CvsCellRange CellRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Ohd5m88ZeK;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref Ohd5m88ZeK, value, (string)rSpApaKcue81FWSDpEX(992));
		}
	}

	public CvsInSight InSight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OGa51F3y3C;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_0033;
			IL_001a:
			OGa51F3y3C = value;
			goto IL_00fc;
			IL_0033:
			while (true)
			{
				switch (num)
				{
				case 8:
					break;
				default:
					num = 1;
					continue;
				case 9:
					goto IL_0072;
				case 5:
					OGa51F3y3C.IsOnlineChanged += rvl5wXWk0D;
					num = 11;
					continue;
				case 6:
					if (OGa51F3y3C != null)
					{
						num = 9;
						continue;
					}
					break;
				case 2:
				case 10:
					hcB52QK19joOX0pyNcg(OGa51F3y3C, new EventHandler(rvl5wXWk0D));
					goto case 3;
				case 1:
					goto IL_00fc;
				case 0:
					FASsnBKhN0NVCwf54LE(OGa51F3y3C, new EventHandler(bS65Hy2X1u));
					num = 4;
					continue;
				case 4:
					ve73AgKtCwnBflfe9x0(OGa51F3y3C, new EventHandler(rvl5wXWk0D));
					num = 5;
					continue;
				case 3:
				case 7:
					cX6nXZKusUXDd5NK8Sp(OGa51F3y3C, new EventHandler(rvl5wXWk0D));
					num = 8;
					continue;
				case 11:
					return;
				}
				break;
				IL_0072:
				OGa51F3y3C.ResultsChanged -= bS65Hy2X1u;
				_ = 1;
				num = (cI6aEMKyaclniTrcgRI() ? 7 : 10);
			}
			goto IL_001a;
			IL_00fc:
			if (OGa51F3y3C != null)
			{
				num = 0;
				if (cI6aEMKyaclniTrcgRI())
				{
				}
				goto IL_0033;
			}
		}
	}

	public AppStepViewModel Parent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FI15zgyXu1;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!H3YdH2KTFuY61nEUylh())
			{
				goto IL_001e;
			}
			goto IL_0057;
			IL_001e:
			Sn1hS5KzURc1GC8CXtV(this);
			cI6aEMKyaclniTrcgRI();
			num = (H3YdH2KTFuY61nEUylh() ? 3 : 0);
			goto IL_0057;
			IL_0057:
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 1:
				case 3:
					FI15zgyXu1 = value;
					goto IL_0084;
				default:
					goto IL_0084;
				case 5:
					return;
				}
				break;
				IL_0084:
				B4621h5LcnMThnQK5Zi(this);
				num = 5;
			}
			goto IL_001e;
		}
	}

	public bool IsInSnippetEditMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Parent?.IsInSnippetEditMode ?? false;
		}
	}

	public bool IsRuntimeModeValidForEditing
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (RuntimeModeService != null)
			{
				return dSdiPA5KQJ876JEi1SX(RuntimeModeService);
			}
			return false;
		}
	}

	public IEnumerable<CellViewModel> AllProperties
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return t7ypaLonr9;
		}
	}

	public ObservableCollection<CellViewModel> Properties
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return peSp5SJ3wo;
		}
	}

	public Func<CellViewModel, bool> PropertyFilterPredicate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EnspphEXpM;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EnspphEXpM = value;
		}
	}

	public string CellNamePrefix
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			object obj;
			while (true)
			{
				switch (num)
				{
				default:
					obj = null;
					goto IL_0035;
				case 0:
				case 1:
					obj = null;
					goto IL_0035;
				case 4:
				{
					IEnumerable<CellViewModel> allProperties = AllProperties;
					if (allProperties != null)
					{
						CellViewModel cellViewModel = allProperties.ElementAtOrDefault(0);
						if (cellViewModel != null)
						{
							obj = ((object[])WnCYq755V2daATfRy7c(cellViewModel.CellName, new char[1] { '.' }))[0];
							goto IL_0035;
						}
						goto default;
					}
					_ = 1;
					num = (cI6aEMKyaclniTrcgRI() ? 3 : 0);
					continue;
				}
				case 5:
					{
						obj = "";
						break;
					}
					IL_0035:
					if (obj == null)
					{
						num = 5;
						continue;
					}
					break;
				}
				break;
			}
			return (string)obj;
		}
	}

	public bool IsUpdatingName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return l9RpUjNe1T;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
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
				case 0:
				case 1:
				{
					AutoResetEvent autoResetEvent = aul5h6rd01;
					if (autoResetEvent != null)
					{
						UqIen45wWttU7Zt12sq(autoResetEvent);
					}
					goto case 2;
				}
				default:
					num = 5;
					if (!cI6aEMKyaclniTrcgRI())
					{
						break;
					}
					goto case 2;
				case 2:
				case 4:
				case 5:
					l9RpUjNe1T = value;
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 3;
				case 3:
					if (!value)
					{
						H3YdH2KTFuY61nEUylh();
						if (cI6aEMKyaclniTrcgRI())
						{
							num = 4;
							if (cI6aEMKyaclniTrcgRI())
							{
							}
						}
						else
						{
							num = 0;
						}
						break;
					}
					goto case 2;
				case 6:
					return;
				}
			}
		}
	}

	public EditIntViewModel Order
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return IFxp7ueNNq;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IFxp7ueNNq = value;
		}
	}

	public SnippetNameViewModel SnippetName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return IycpNlPUmt;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IycpNlPUmt = value;
		}
	}

	internal BaseViewModel MainViewModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LkBpA74trk;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!cI6aEMKyaclniTrcgRI())
			{
				num = 3;
			}
			else
			{
				num = 4;
				if (1 == 0)
				{
					return;
				}
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					return;
				case 1:
				case 4:
				{
					EventHandler eventHandler = n8b5rihyYD;
					if (eventHandler == null)
					{
						return;
					}
					NDPRoL5JAiXPf3B9Kgm(eventHandler, this, EventArgs.Empty);
					num = 5;
					break;
				}
				default:
					num = 2;
					if (H3YdH2KTFuY61nEUylh())
					{
						break;
					}
					goto case 0;
				case 0:
				case 3:
					if (SetField(ref LkBpA74trk, value, (string)rSpApaKcue81FWSDpEX(1014)))
					{
						goto case 1;
					}
					return;
				case 5:
					return;
				}
			}
		}
	}

	protected IRuntimeService RuntimeService
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return JP7pdOS5eL;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			JP7pdOS5eL = value;
		}
	}

	protected IRuntimeModeService RuntimeModeService
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iBLp63pInk;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			iBLp63pInk = value;
		}
	}

	protected SnippetLocalizer Localizer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Rxipux55rl;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Rxipux55rl = value;
		}
	}

	public event Func<object, EventArgs, Task> Copy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Func<object, EventArgs, Task> func = EhM5VjwYDs;
			Func<object, EventArgs, Task> func2;
			do
			{
				func2 = func;
				Func<object, EventArgs, Task> value2 = (Func<object, EventArgs, Task>)Delegate.Combine(func2, value);
				func = Interlocked.CompareExchange(ref EhM5VjwYDs, value2, func2);
			}
			while ((object)func != func2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Func<object, EventArgs, Task> func = EhM5VjwYDs;
			Func<object, EventArgs, Task> func2;
			do
			{
				func2 = func;
				Func<object, EventArgs, Task> value2 = (Func<object, EventArgs, Task>)Delegate.Remove(func2, value);
				func = Interlocked.CompareExchange(ref EhM5VjwYDs, value2, func2);
			}
			while ((object)func != func2);
		}
	}

	public event Func<object, EventArgs, Task> Remove
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Func<object, EventArgs, Task> func = yrH5L6uEKS;
			Func<object, EventArgs, Task> func2;
			do
			{
				func2 = func;
				Func<object, EventArgs, Task> value2 = (Func<object, EventArgs, Task>)Delegate.Combine(func2, value);
				func = Interlocked.CompareExchange(ref yrH5L6uEKS, value2, func2);
			}
			while ((object)func != func2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Func<object, EventArgs, Task> func = yrH5L6uEKS;
			Func<object, EventArgs, Task> func2;
			do
			{
				func2 = func;
				Func<object, EventArgs, Task> value2 = (Func<object, EventArgs, Task>)Delegate.Remove(func2, value);
				func = Interlocked.CompareExchange(ref yrH5L6uEKS, value2, func2);
			}
			while ((object)func != func2);
		}
	}

	public event EventHandler DependencyChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					value2 = (EventHandler)kpx2PoKHXQHSjt986H1(eventHandler2, value);
					goto default;
				default:
					_ = 0;
					num = ((!H3YdH2KTFuY61nEUylh()) ? 2 : 0);
					continue;
				case 2:
				case 4:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						continue;
					}
					break;
				case 0:
				case 3:
					eventHandler = Interlocked.CompareExchange(ref w925JHGE2W, value2, eventHandler2);
					goto case 2;
				case 1:
					eventHandler = w925JHGE2W;
					num = 6;
					continue;
				case 6:
					break;
				case 7:
					return;
				}
				eventHandler2 = eventHandler;
				num = 5;
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
			cI6aEMKyaclniTrcgRI();
			int num = ((!H3YdH2KTFuY61nEUylh()) ? 5 : 3);
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					value2 = (EventHandler)oHtbwuKx8pVHyxEUrx5(eventHandler2, value);
					goto case 1;
				default:
					num = 1;
					break;
				case 1:
					eventHandler = Interlocked.CompareExchange(ref w925JHGE2W, value2, eventHandler2);
					goto case 4;
				case 0:
				case 3:
					eventHandler = w925JHGE2W;
					num = 6;
					break;
				case 6:
					eventHandler2 = eventHandler;
					num = 2;
					break;
				case 4:
				case 5:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						break;
					}
					goto case 6;
				case 7:
					return;
				}
			}
		}
	}

	public event SnippetRenamedEventHandler Rename
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			SnippetRenamedEventHandler snippetRenamedEventHandler = default;
			SnippetRenamedEventHandler snippetRenamedEventHandler2 = default;
			SnippetRenamedEventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					if ((object)snippetRenamedEventHandler == snippetRenamedEventHandler2)
					{
						num = 7;
						continue;
					}
					goto case 6;
				case 2:
				case 5:
					value2 = (SnippetRenamedEventHandler)kpx2PoKHXQHSjt986H1(snippetRenamedEventHandler2, value);
					break;
				case 4:
					snippetRenamedEventHandler = vII59tUvOM;
					num = 6;
					continue;
				case 6:
					snippetRenamedEventHandler2 = snippetRenamedEventHandler;
					_ = 1;
					num = (cI6aEMKyaclniTrcgRI() ? 1 : 5);
					continue;
				case 7:
					return;
				}
				snippetRenamedEventHandler = Interlocked.CompareExchange(ref vII59tUvOM, value2, snippetRenamedEventHandler2);
				num = 0;
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
			int num = 1;
			SnippetRenamedEventHandler value2 = default;
			SnippetRenamedEventHandler snippetRenamedEventHandler2 = default;
			SnippetRenamedEventHandler snippetRenamedEventHandler = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					value2 = (SnippetRenamedEventHandler)oHtbwuKx8pVHyxEUrx5(snippetRenamedEventHandler2, value);
					goto case 5;
				default:
					num = 5;
					continue;
				case 3:
				case 4:
					if ((object)snippetRenamedEventHandler == snippetRenamedEventHandler2)
					{
						num = 7;
						continue;
					}
					break;
				case 1:
					snippetRenamedEventHandler = vII59tUvOM;
					num = 6;
					continue;
				case 5:
					snippetRenamedEventHandler = Interlocked.CompareExchange(ref vII59tUvOM, value2, snippetRenamedEventHandler2);
					goto case 3;
				case 6:
					break;
				case 7:
					return;
				}
				snippetRenamedEventHandler2 = snippetRenamedEventHandler;
				cI6aEMKyaclniTrcgRI();
				num = ((!H3YdH2KTFuY61nEUylh()) ? 3 : 0);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected EzSnippet(AppStepViewModel appStepVm, SnippetLocalizer localizer = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		while (true)
		{
			switch (num)
			{
			case 2:
				xF95YeQ1Nl = new AsyncDelegateCommand(OnDelete, CanDelete);
				num = 1;
				continue;
			case 8:
				Parent = appStepVm;
				goto case 10;
			default:
				num = 10;
				if (H3YdH2KTFuY61nEUylh())
				{
					continue;
				}
				goto case 6;
			case 6:
				tpB5t32vZm = "";
				WR3583PGQr = string.Empty;
				Ohd5m88ZeK = CvsCellRange.Invalid;
				num = 12;
				if (0 == 0)
				{
					continue;
				}
				goto case 11;
			case 11:
				peSp5SJ3wo = new ObservableCollection<CellViewModel>();
				_ = 1;
				num = (cI6aEMKyaclniTrcgRI() ? 7 : 3);
				continue;
			case 1:
				CopyCommand = new AsyncDelegateCommand(OnCopy, CanCopy);
				goto case 7;
			case 7:
			case 9:
				RuntimeService = appStepVm.RuntimeService;
				num = 0;
				if (cI6aEMKyaclniTrcgRI())
				{
				}
				continue;
			case 0:
				RuntimeModeService = (IRuntimeModeService)MWZNBuKYaNJiyvvyKUC(appStepVm);
				num = 13;
				continue;
			case 10:
				Localizer = localizer ?? new SnippetLocalizer((ResourceManager)imEUQOKMiUkqcFxAoYw());
				InSight = appStepVm.InSight;
				num = 2;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				sHnhxVK0gWXETPT8dCB();
				num = 6;
				continue;
			case 3:
			case 4:
				Hp8iWwKFxE6YV5LGeGd(this);
				num = 8;
				if (H3YdH2KTFuY61nEUylh())
				{
					continue;
				}
				break;
			case 12:
				break;
			case 13:
				return;
			}
			t7ypaLonr9 = new List<CellViewModel>();
			num = 11;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual ValueTask DisposeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0044;
		IL_001a:
		RuntimeService = null;
		num = 6;
		goto IL_0044;
		IL_0044:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				RuntimeModeService = null;
				break;
			case 1:
				InSight = null;
				cI6aEMKyaclniTrcgRI();
				num = ((!H3YdH2KTFuY61nEUylh()) ? 4 : 0);
				continue;
			case 5:
				Parent = null;
				num = 1;
				if (0 == 0)
				{
					continue;
				}
				goto case 6;
			case 6:
				return new ValueTask((Task)Aa9getKULU4JPTyiHCa());
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal void OLV5BeveD3(EventHandler value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		EventHandler eventHandler = default;
		EventHandler value2 = default;
		EventHandler eventHandler2 = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				eventHandler = Interlocked.CompareExchange(ref n8b5rihyYD, value2, eventHandler2);
				num = 0;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
			case 5:
				value2 = (EventHandler)kpx2PoKHXQHSjt986H1(eventHandler2, value);
				goto case 6;
			default:
				num = 6;
				break;
			case 3:
				eventHandler = n8b5rihyYD;
				_ = 1;
				num = (cI6aEMKyaclniTrcgRI() ? 5 : 4);
				break;
			case 1:
			case 4:
				eventHandler2 = eventHandler;
				goto case 2;
			case 0:
				if ((object)eventHandler == eventHandler2)
				{
					num = 7;
					break;
				}
				goto case 1;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal void ppQ5ZMA0ch(EventHandler value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		H3YdH2KTFuY61nEUylh();
		int num;
		if (!cI6aEMKyaclniTrcgRI())
		{
			num = 2;
			if (cI6aEMKyaclniTrcgRI())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_004d;
		IL_00b6:
		EventHandler value2 = default;
		EventHandler eventHandler2 = default;
		EventHandler eventHandler = Interlocked.CompareExchange(ref n8b5rihyYD, value2, eventHandler2);
		num = 5;
		if (1 == 0)
		{
			return;
		}
		goto IL_004d;
		IL_004d:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			default:
				num = 6;
				continue;
			case 0:
			case 2:
				eventHandler = n8b5rihyYD;
				goto case 1;
			case 5:
				if ((object)eventHandler == eventHandler2)
				{
					num = 7;
					continue;
				}
				goto case 1;
			case 1:
			case 4:
				eventHandler2 = eventHandler;
				num = 3;
				if (!cI6aEMKyaclniTrcgRI())
				{
					continue;
				}
				goto IL_00b6;
			case 6:
				goto IL_00b6;
			case 7:
				return;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		value2 = (EventHandler)oHtbwuKx8pVHyxEUrx5(eventHandler2, value);
		goto IL_00b6;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnParentChanging()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnParentChanged()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsValidSnippetName(string name)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (string.IsNullOrWhiteSpace(name))
		{
			return false;
		}
		if (RCs7Sg5a2C8Ru8ecmFL(name, CdQUGaROfy7He9T0foW.KbIzwHEDLa(1044), StringComparison.Ordinal))
		{
			return false;
		}
		return sIPd5k5eVD0IYAfPp3r(name, rSpApaKcue81FWSDpEX(1050));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string RemoveSnippetIndexInName(string snippetName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Regex.Replace(snippetName, (string)rSpApaKcue81FWSDpEX(1088), "");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string AssembleFullCellName(string snippetName, string cellName, bool isInternal = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)ITO4lQ5OeHO44PbheEf(isInternal ? rSpApaKcue81FWSDpEX(1044) : string.Empty, snippetName, rSpApaKcue81FWSDpEX(1104), cellName);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ReplaceSnippetNameInCellName(string newSnippetName, string oldCellName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		(string snippetName, string propName, bool isInternal) tuple = SplitCellName(oldCellName);
		string item = tuple.propName;
		bool item2 = tuple.isInternal;
		if (item != null)
		{
			return AssembleFullCellName(newSnippetName, item, item2);
		}
		return oldCellName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static (string snippetName, string propName, bool isInternal) SplitCellName(string fullCellName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string item = null;
		string item2 = null;
		bool flag = false;
		if (!string.IsNullOrWhiteSpace(fullCellName))
		{
			flag = fullCellName.StartsWith(CdQUGaROfy7He9T0foW.KbIzwHEDLa(1044), StringComparison.Ordinal);
			int num = fullCellName.IndexOf(CdQUGaROfy7He9T0foW.KbIzwHEDLa(1104), StringComparison.Ordinal);
			if (num >= 0)
			{
				int num2 = (flag ? CdQUGaROfy7He9T0foW.KbIzwHEDLa(1044).Length : 0);
				item2 = fullCellName.Substring(num2, num - num2);
				item = fullCellName.Substring(num + 1);
			}
		}
		return (snippetName: item2, propName: item, isInternal: flag);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RefreshPotentialDependencies()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual CvsEditableDisplayGraphic[] GetFeatures(CvsCellCollection cells, CellType reqDataType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsEditableDisplayGraphic[0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual SourceLink[] GetSourceLinks(CellType reqDataType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new SourceLink[0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateOnEditModeChange()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetCellRangeAsync_003Ed__99))]
	public Task SetCellRangeAsync(CvsCellCollection cells, CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		_003CSetCellRangeAsync_003Ed__99 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine.cellRange = cellRange;
				goto case 4;
			default:
				num = 4;
				if (H3YdH2KTFuY61nEUylh())
				{
					continue;
				}
				goto case 7;
			case 7:
				stateMachine._003C_003Et__builder = ATWYtk5IreBABT8uUsq();
				_ = 1;
				if (!cI6aEMKyaclniTrcgRI())
				{
					num = 3;
					if (true)
					{
						continue;
					}
					goto case 2;
				}
				num = 6;
				continue;
			case 2:
			case 6:
				stateMachine.cells = cells;
				num = 5;
				continue;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 0;
				if (true)
				{
					continue;
				}
				break;
			case 8:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAwaitIfUpdatingName_003Ed__100))]
	public Task AwaitIfUpdatingName()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!cI6aEMKyaclniTrcgRI())
		{
			num = 4;
		}
		else
		{
			num = 5;
			if (false)
			{
				goto IL_0089;
			}
		}
		goto IL_003e;
		IL_003e:
		_003CAwaitIfUpdatingName_003Ed__100 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = ATWYtk5IreBABT8uUsq();
				break;
			case 1:
			case 5:
				break;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (H3YdH2KTFuY61nEUylh())
				{
					continue;
				}
				goto case 6;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0089;
		IL_0089:
		stateMachine._003C_003E4__this = this;
		num = 2;
		goto IL_003e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<EzSnippet> GetDependentSnippets(bool recursive, CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Parent.GetDependentSnippets(this, recursive, cells);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUpdateCellNames_003Ed__102))]
	protected virtual Task<Dictionary<string, string>> UpdateCellNames(string newSnippetName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CUpdateCellNames_003Ed__102 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Dictionary<string, string>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.newSnippetName = newSnippetName;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUpdateNameInternal_003Ed__103))]
	internal Task llY5g2dfVP(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		H3YdH2KTFuY61nEUylh();
		int num = (cI6aEMKyaclniTrcgRI() ? 2 : 5);
		_003CUpdateNameInternal_003Ed__103 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				break;
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			case 4:
				stateMachine.newName = P_0;
				goto case 3;
			default:
				num = 3;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool ods5MyNttS(CvsCellLocation P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CellRange.Contains(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void mSa5R0Ugrt(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = ((!cI6aEMKyaclniTrcgRI()) ? 1 : 3);
		IEnumerator<CellViewModel> enumerator = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				tpB5t32vZm = P_0;
				num = 4;
				break;
			case 4:
				Q6MKb65DEdM66US0Nc1(Properties);
				goto default;
			default:
				enumerator = AllProperties.GetEnumerator();
				num = 5;
				break;
			case 5:
				try
				{
					while (fahCce5iSADY471jOrs(enumerator))
					{
						CellViewModel current = enumerator.Current;
						cI6aEMKyaclniTrcgRI();
						int num2;
						if (H3YdH2KTFuY61nEUylh())
						{
							num2 = 2;
						}
						else
						{
							num2 = 3;
							if (cI6aEMKyaclniTrcgRI())
							{
								continue;
							}
						}
						switch (num2)
						{
						case 0:
						case 2:
							nTx5xfqg1J(current, _0020: false);
							break;
						}
					}
					return;
				}
				finally
				{
					if (enumerator != null)
					{
						JfPRDQ5nfKLkeFlsOkS(enumerator);
					}
				}
			}
		}
	}

	protected abstract Task Parse(CvsCellCollection cells);

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnResultsChanged(CvsResultSet results)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRuntimeModeChanged(bool isOnline, bool isLiveMode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		H3YdH2KTFuY61nEUylh();
		int num;
		if (!cI6aEMKyaclniTrcgRI())
		{
			num = 4;
		}
		else
		{
			num = 3;
			if (cI6aEMKyaclniTrcgRI())
			{
			}
		}
		while (true)
		{
			switch (num)
			{
			case 5:
				kmNDFa5d4IYGvP7Yx4y(DeleteCommand);
				goto case 2;
			case 1:
				Op69Js5lChX9JiPDeNw(this, rSpApaKcue81FWSDpEX(1110));
				num = 6;
				break;
			case 2:
			case 3:
				kmNDFa5d4IYGvP7Yx4y(CopyCommand);
				goto case 1;
			default:
				num = 1;
				break;
			case 0:
			case 4:
				ftGNtL5ftpeww3nlaRA(this, NU2R7x5VHm7Po25vubY(OGa51F3y3C));
				num = 5;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnDelete_003Ed__109))]
	protected virtual Task OnDelete()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!H3YdH2KTFuY61nEUylh()) ? 3 : 5);
		_003COnDelete_003Ed__109 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				if (!cI6aEMKyaclniTrcgRI())
				{
					break;
				}
				goto case 0;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = ATWYtk5IreBABT8uUsq();
				goto case 1;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool CanDelete()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (IsRuntimeModeValidForEditing && Parent.hNFm2VxOH5())
		{
			return !DeleteCommand.IsExecuting;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CFireRemoveEventAsync_003Ed__111))]
	private Task UgQ54sEslO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_008a;
		IL_0070:
		_003CFireRemoveEventAsync_003Ed__111 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_0058;
		IL_008a:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 0:
			case 1:
				goto IL_003e;
			case 3:
				goto IL_0058;
			case 2:
			case 5:
				goto IL_0070;
			default:
				num = 3;
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
		goto IL_001a;
		IL_003e:
		stateMachine._003C_003E4__this = this;
		goto IL_0070;
		IL_001a:
		stateMachine._003C_003Et__builder = ATWYtk5IreBABT8uUsq();
		_ = 0;
		if (H3YdH2KTFuY61nEUylh())
		{
			num = 0;
			if (1 == 0)
			{
				goto IL_003e;
			}
		}
		else
		{
			num = 5;
			if (1 == 0)
			{
				goto IL_0058;
			}
		}
		goto IL_008a;
		IL_0058:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_008a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CFireAsyncEvent_003Ed__112))]
	private Task RXF5lY8rP5(Func<object, EventArgs, Task> P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CFireAsyncEvent_003Ed__112 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.handler = P_0;
		stateMachine.e = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string NKA5TX2DdC(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (H3YdH2KTFuY61nEUylh())
		{
			num = 2;
			if (!H3YdH2KTFuY61nEUylh())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_006e;
		IL_009f:
		int num2 = 0;
		num = 4;
		goto IL_006e;
		IL_006e:
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				break;
			default:
				num = 5;
				if (true)
				{
					continue;
				}
				goto IL_009f;
			case 1:
			case 3:
				goto IL_009f;
			case 6:
				if (doAMB8KNe6VG5K9XcFW(Parent, text))
				{
					text = (string)f0DCBY5gpM1GgHXNDCA(rSpApaKcue81FWSDpEX(1170), P_0, ++num2);
					goto case 4;
				}
				num = 7;
				continue;
			case 4:
			case 5:
				if (Name != text)
				{
					num = 6;
					continue;
				}
				goto case 7;
			case 7:
				return text;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		text = P_0;
		goto IL_009f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool zuY5WI7jW2(CellViewModel P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ak55jHdJKT(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		mBSZ7G5skSd3STMnbgF(this, P_0);
		Op69Js5lChX9JiPDeNw(this, rSpApaKcue81FWSDpEX(1188));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void FireDependencyChanged()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EventHandler eventHandler = w925JHGE2W;
		if (eventHandler != null)
		{
			NDPRoL5JAiXPf3B9Kgm(eventHandler, this, EventArgs.Empty);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ED75CUrIgc(Dictionary<string, string> P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		vII59tUvOM?.Invoke(this, new SnippetRenamedEventArgs(CellRange, P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Iwq5OWVhKU(CellViewModel P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		CvsCellLocation cvsCellLocation = default;
		int row2 = default;
		int col = default;
		while (true)
		{
			switch (num)
			{
			case 7:
			{
				int row = cvsCellLocation.Row;
				cvsCellLocation = CellRange.Location;
				row2 = row - cvsCellLocation.Row;
				num = 5;
				if (cI6aEMKyaclniTrcgRI())
				{
					return;
				}
				break;
			}
			case 2:
				return;
			case 0:
				do
				{
					if (!QX2oBY5vv1hW16AShIV(P_0))
					{
						cvsCellLocation = KjQOdY5r6rVuX0ok2oi(P_0);
						num = 1;
						continue;
					}
					num = 2;
					break;
				}
				while (!H3YdH2KTFuY61nEUylh());
				break;
			case 5:
				if (!y5Ue635Z25cgDIx3daA(Vf4hBK5PNJVLR0xMdTP(this)))
				{
					goto case 6;
				}
				return;
			case 1:
			{
				int column = cvsCellLocation.Column;
				cvsCellLocation = CellRange.Location;
				col = column - cvsCellLocation.Column;
				_ = 1;
				if (cI6aEMKyaclniTrcgRI())
				{
					num = 8;
					break;
				}
				num = 4;
				if (H3YdH2KTFuY61nEUylh())
				{
					break;
				}
				goto case 3;
			}
			case 3:
			case 4:
				cvsCellLocation = KjQOdY5r6rVuX0ok2oi(P_0);
				goto case 7;
			default:
				num = 7;
				break;
			case 6:
			case 8:
				TH9BXC5bF3Wgx5JtfKK(P_0, Localizer.LocalizeCellName((string)f51IqL5B0vaocyCN6xh(P_0), new CvsCellLocation(row2, col), (string)Vf4hBK5PNJVLR0xMdTP(this)));
				num = 9;
				break;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void AddProperty(CellViewModel property)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!H3YdH2KTFuY61nEUylh()) ? 4 : 3);
		while (true)
		{
			switch (num)
			{
			case 2:
				nTx5xfqg1J(property, _0020: true);
				num = 5;
				break;
			case 0:
			case 3:
				t7ypaLonr9.InsertSorted(property, (IComparer<CellViewModel>)tQgyuo5Gfw0v81TF55y());
				goto case 1;
			case 1:
			case 4:
				Iwq5OWVhKU(property);
				goto case 2;
			default:
				num = 2;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void RemoveProperty(CellViewModel property)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		t7ypaLonr9.Remove(property);
		kCP5vqyTre(property);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void RemoveAllProperties()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		D9vpps5ocu1eouh5l4b(t7ypaLonr9);
		Properties.Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void bS65Hy2X1u(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (H3YdH2KTFuY61nEUylh())
		{
			num = 3;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 2;
			if (1 == 0)
			{
				goto IL_008c;
			}
		}
		goto IL_0048;
		IL_008c:
		ftGNtL5ftpeww3nlaRA(this, NU2R7x5VHm7Po25vubY(OGa51F3y3C));
		num = 5;
		goto IL_0048;
		IL_0048:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				break;
			default:
				num = 4;
				continue;
			case 0:
			case 3:
				if (OGa51F3y3C != null)
				{
					break;
				}
				return;
			case 4:
				goto IL_008c;
			case 5:
				return;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		if (!OGa51F3y3C.IsLiveAcquisition)
		{
			goto IL_008c;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rvl5wXWk0D(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		rwR7RS58EalbBWGMrkL(this, Nq0LVH5SJ3w1ix1cgxm(OGa51F3y3C), F2OEUe5kjF43mZ4WwWp(OGa51F3y3C));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnCopy_003Ed__124))]
	protected virtual Task OnCopy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003COnCopy_003Ed__124 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003Et__builder = ATWYtk5IreBABT8uUsq();
				cI6aEMKyaclniTrcgRI();
				if (H3YdH2KTFuY61nEUylh())
				{
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 4;
				}
				num = 3;
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 2:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool CanCopy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return IsRuntimeModeValidForEditing;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CFireCopyEvent_003Ed__126))]
	private Task rlD5yLfh4Z()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (H3YdH2KTFuY61nEUylh())
		{
			num = 4;
		}
		else
		{
			num = 2;
			if (1 == 0)
			{
				goto IL_00b3;
			}
		}
		_003CFireCopyEvent_003Ed__126 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				continue;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 3;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = ATWYtk5IreBABT8uUsq();
				goto case 1;
			case 6:
				break;
			}
			break;
		}
		goto IL_00b3;
		IL_00b3:
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nTx5xfqg1J(CellViewModel P_0, bool P_1)
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
			case 1:
			case 5:
				if (P_1)
				{
					goto case 2;
				}
				Properties.Add(P_0);
				num = 6;
				break;
			case 3:
				return;
			case 0:
				if (E9w5eyuR7g(P_0))
				{
					H3YdH2KTFuY61nEUylh();
					num = ((!cI6aEMKyaclniTrcgRI()) ? 5 : 4);
					break;
				}
				return;
			case 2:
			case 4:
				Properties.InsertSorted(P_0, d9xNWLNI0ju99j9W21.MS3pFfd3pd());
				return;
			default:
				num = 3;
				if (!H3YdH2KTFuY61nEUylh())
				{
					return;
				}
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void kCP5vqyTre(CellViewModel P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (Properties.Contains(P_0))
		{
			Properties.Remove(P_0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool E9w5eyuR7g(CellViewModel P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		while (true)
		{
			object obj;
			switch (num)
			{
			case 3:
			case 5:
				obj = "";
				goto IL_001d;
			case 6:
				if (P_0 != null)
				{
					num = 2;
					break;
				}
				goto IL_0083;
			case 2:
				if (P_0.Internal)
				{
					num = 7;
					break;
				}
				goto IL_0083;
			case 0:
			case 4:
				obj = null;
				goto IL_006a;
			case 7:
				return false;
			case 1:
				return true;
			default:
				cI6aEMKyaclniTrcgRI();
				num = ((!H3YdH2KTFuY61nEUylh()) ? 3 : 0);
				break;
			case 8:
				{
					return true;
				}
				IL_0083:
				if (y5Ue635Z25cgDIx3daA(tpB5t32vZm))
				{
					num = 1;
					break;
				}
				if (P_0 != null)
				{
					obj = P_0.DisplayName;
					goto IL_006a;
				}
				goto default;
				IL_001d:
				if (((string)obj).IndexOf(tpB5t32vZm, StringComparison.CurrentCultureIgnoreCase) >= 0)
				{
					num = 8;
					break;
				}
				return zuY5WI7jW2(P_0);
				IL_006a:
				if (obj == null)
				{
					goto case 3;
				}
				goto IL_001d;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool YwF52VtFd3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CFaYTM5qQobJ08UJwxI(aul5h6rd01);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sHnhxVK0gWXETPT8dCB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Hp8iWwKFxE6YV5LGeGd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseViewModel)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object imEUQOKMiUkqcFxAoYw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EZBSnippetStrings.ResourceManager;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MWZNBuKYaNJiyvvyKUC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).RuntimeModeService;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool H3YdH2KTFuY61nEUylh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cI6aEMKyaclniTrcgRI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Aa9getKULU4JPTyiHCa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kpx2PoKHXQHSjt986H1(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oHtbwuKx8pVHyxEUrx5(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Y4WGotKm1aSXFyG8x9c(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 != (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UH1ICyKQxJ0dSSZooTK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return IsValidSnippetName((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool doAMB8KNe6VG5K9XcFW(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).IsSnippetNameUsed((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void R4f7dbK21xUtmAQicuN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Task)P_0).IgnoreResult();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rSpApaKcue81FWSDpEX(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hcB52QK19joOX0pyNcg(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSight)P_0).IsLiveAcquisitionChanged -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cX6nXZKusUXDd5NK8Sp(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSight)P_0).IsOnlineChanged -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FASsnBKhN0NVCwf54LE(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSight)P_0).ResultsChanged += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ve73AgKtCwnBflfe9x0(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSight)P_0).IsLiveAcquisitionChanged += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Sn1hS5KzURc1GC8CXtV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzSnippet)P_0).OnParentChanging();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void B4621h5LcnMThnQK5Zi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzSnippet)P_0).OnParentChanged();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dSdiPA5KQJ876JEi1SX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IRuntimeModeService)P_0).IsOperatorOfflineAndNotInLiveMode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WnCYq755V2daATfRy7c(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Split((char[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UqIen45wWttU7Zt12sq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EventWaitHandle)P_0).Set();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NDPRoL5JAiXPf3B9Kgm(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (EventArgs)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RCs7Sg5a2C8Ru8ecmFL(object P_0, object P_1, StringComparison P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).StartsWith((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sIPd5k5eVD0IYAfPp3r(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Regex.IsMatch((string)P_0, (string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ITO4lQ5OeHO44PbheEf(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder ATWYtk5IreBABT8uUsq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Q6MKb65DEdM66US0Nc1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Collection<CellViewModel>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fahCce5iSADY471jOrs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JfPRDQ5nfKLkeFlsOkS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NU2R7x5VHm7Po25vubY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Results;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ftGNtL5ftpeww3nlaRA(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzSnippet)P_0).OnResultsChanged((CvsResultSet)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kmNDFa5d4IYGvP7Yx4y(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseDelegateCommand)P_0).RaiseCanExecuteChanged();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Op69Js5lChX9JiPDeNw(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object f0DCBY5gpM1GgHXNDCA(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mBSZ7G5skSd3STMnbgF(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzSnippet)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QX2oBY5vv1hW16AShIV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).Internal;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation KjQOdY5r6rVuX0ok2oi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Vf4hBK5PNJVLR0xMdTP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippet)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool y5Ue635Z25cgDIx3daA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object f51IqL5B0vaocyCN6xh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TH9BXC5bF3Wgx5JtfKK(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CellViewModel)P_0).LocalizedCellName = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tQgyuo5Gfw0v81TF55y()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return d9xNWLNI0ju99j9W21.MS3pFfd3pd();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void D9vpps5ocu1eouh5l4b(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((List<CellViewModel>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Nq0LVH5SJ3w1ix1cgxm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).IsOnline;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool F2OEUe5kjF43mZ4WwWp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).IsLiveAcquisition;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rwR7RS58EalbBWGMrkL(object P_0, bool isOnline, bool isLiveMode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzSnippet)P_0).OnRuntimeModeChanged(isOnline, isLiveMode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CFaYTM5qQobJ08UJwxI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((WaitHandle)P_0).WaitOne();
	}
}
