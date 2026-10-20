using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Common;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.ViewModels.PropertySheet.FormatOutputBuffer;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Newtonsoft.Json.Linq;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public class FormatOutputData : FormatDataBase
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnElementsChanged_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FormatOutputData _003C_003E4__this;

		public NotifyCollectionChangedEventArgs e;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			FormatOutputData formatOutputData = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					NmwrjZ5nq6oZ0I1IW21j();
					if (!BdHqow5nEs7KPG7HDUVN())
					{
						num = 5;
						if (NmwrjZ5nq6oZ0I1IW21j())
						{
							break;
						}
						goto case 1;
					}
					num = 3;
					break;
				case 1:
				case 5:
					formatOutputData = _003C_003E4__this;
					goto case 2;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								_ = 1;
								num3 = (BdHqow5nEs7KPG7HDUVN() ? 11 : 9);
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num3 = 7;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 13;
							if (!NmwrjZ5nq6oZ0I1IW21j())
							{
								goto IL_01cc;
							}
						}
						goto IL_012e;
						IL_01cc:
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 1;
						goto IL_012e;
						IL_012e:
						while (true)
						{
							switch (num3)
							{
							case 5:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 15;
									continue;
								}
								goto case 1;
							case 2:
								num2 = (_003C_003E1__state = 1);
								num3 = 10;
								continue;
							case 0:
							case 9:
								awaiter = BVbsKB5npBRp2dQutsBv(formatOutputData.JkGqLIXJAU(e));
								num3 = 5;
								if (NmwrjZ5nq6oZ0I1IW21j())
								{
									continue;
								}
								goto case 10;
							case 10:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								continue;
							case 11:
								return;
							case 12:
								return;
							case 1:
								awaiter.GetResult();
								goto case 14;
							default:
								num3 = 14;
								if (!BdHqow5nEs7KPG7HDUVN())
								{
									continue;
								}
								goto case 3;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								continue;
							case 15:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								continue;
							case 4:
								return;
							case 13:
								break;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 14:
								awaiter = formatOutputData.SfBqtFh5ik().GetAwaiter();
								num3 = 8;
								continue;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									if (true)
									{
										continue;
									}
									goto case 7;
								}
								goto case 16;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 16:
								awaiter.GetResult();
								goto end_IL_012e;
							}
							goto IL_01cc;
							continue;
							end_IL_012e:
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
					goto case 4;
				default:
					num = 4;
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
		internal static TaskAwaiter BVbsKB5npBRp2dQutsBv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NmwrjZ5nq6oZ0I1IW21j()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BdHqow5nEs7KPG7HDUVN()
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
	private struct _003COnSelectedElementPropertyChanged_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FormatOutputData _003C_003E4__this;

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
			FormatOutputData formatOutputData = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 5:
					num2 = _003C_003E1__state;
					d0EwJR5n9dRTMQYg0S4x();
					if (QTNrfi5nXd5S2xGXCXWr())
					{
						num = 3;
						break;
					}
					num = 4;
					if (true)
					{
						break;
					}
					return;
				case 2:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = formatOutputData.SfBqtFh5ik().GetAwaiter();
							num3 = 0;
							if (1 == 0)
							{
								goto IL_006c;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
						}
						goto IL_00a8;
						IL_00a8:
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							case 3:
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								continue;
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								if (true)
								{
									continue;
								}
								return;
							case 7:
								return;
							case 6:
							case 8:
								goto IL_010a;
							case 5:
								_003C_003Eu__1 = awaiter;
								_ = 0;
								if (!QTNrfi5nXd5S2xGXCXWr())
								{
									num3 = 8;
									continue;
								}
								num3 = 4;
								if (QTNrfi5nXd5S2xGXCXWr())
								{
									continue;
								}
								goto case 0;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								goto case 9;
							case 9:
								awaiter.GetResult();
								goto end_IL_004e;
							}
							break;
						}
						goto IL_006c;
						IL_010a:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_00a8;
						IL_006c:
						_003C_003Eu__1 = default;
						goto IL_010a;
						end_IL_004e:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 0;
				default:
					num = 0;
					break;
				case 1:
				case 3:
					formatOutputData = _003C_003E4__this;
					goto case 2;
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
		internal static bool QTNrfi5nXd5S2xGXCXWr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool d0EwJR5n9dRTMQYg0S4x()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public CellViewModel property;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass5_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			pwNYDV5n3XniurIlkfAH(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CRemoveSnippetReferences_003Eb__0(DataElement e)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return sgn1fX5n6uOy2y8Tc3nJ(e.Cell.CellName, TLbVPj5njgLUk4Qg5W9J(property));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void pwNYDV5n3XniurIlkfAH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CbhFV25n4YOjgZUhx2ZY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PRwJIX5n7w6wxBBvEctM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TLbVPj5njgLUk4Qg5W9J(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sgn1fX5n6uOy2y8Tc3nJ(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRemoveSnippetReferences_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FormatOutputData _003C_003E4__this;

		public EzSnippet snippet;

		private IDisposable _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_0214;
			IL_0031:
			int num2 = default;
			FormatOutputData formatOutputData = default;
			try
			{
				if (num2 != 0)
				{
					_003C_003E7__wrap1 = (IDisposable)Y1aoeY5nRbdv9OOtNtdm(formatOutputData._suspendElementsEvents);
				}
				try
				{
					TaskAwaiter awaiter;
					if (num2 != 0)
					{
						IEnumerator<CellViewModel> enumerator = snippet.AllProperties.GetEnumerator();
						try
						{
							DataElement dataElement = default;
							while (enumerator.MoveNext())
							{
								_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass5_0();
								int num3 = 2;
								if (eJ481G5nAsA6R3tSM8iu())
								{
									goto IL_007b;
								}
								goto IL_00a6;
								IL_0110:
								formatOutputData.Elements.Remove(dataElement);
								num3 = 6;
								if (false)
								{
									continue;
								}
								goto IL_00a6;
								IL_00a6:
								while (true)
								{
									switch (num3)
									{
									case 1:
									case 4:
										break;
									default:
										num3 = 5;
										continue;
									case 2:
										goto IL_00d1;
									case 5:
										goto IL_00f9;
									case 0:
									case 3:
										goto IL_0110;
									case 6:
										goto IL_012a;
									}
									break;
									IL_00d1:
									CS_0024_003C_003E8__locals2.property = enumerator.Current;
									eJ481G5nAsA6R3tSM8iu();
									if (jKufoS5nCZZXPalljPMk())
									{
										num3 = 4;
										if (0 == 0)
										{
											continue;
										}
										goto IL_00f9;
									}
									num3 = 0;
								}
								goto IL_007b;
								IL_007b:
								dataElement = formatOutputData.Elements.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (DataElement e) =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									return _003C_003Ec__DisplayClass5_0.sgn1fX5n6uOy2y8Tc3nJ(e.Cell.CellName, _003C_003Ec__DisplayClass5_0.TLbVPj5njgLUk4Qg5W9J(CS_0024_003C_003E8__locals2.property));
								});
								goto IL_00f9;
								IL_00f9:
								if (dataElement == null)
								{
									continue;
								}
								goto IL_0110;
								IL_012a:;
							}
						}
						finally
						{
							if (num2 < 0 && enumerator != null)
							{
								vO6RpM5nWCEKU1VJop3V(enumerator);
							}
						}
						awaiter = formatOutputData.SfBqtFh5ik().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
					}
					awaiter.GetResult();
				}
				finally
				{
					if (num2 < 0 && _003C_003E7__wrap1 != null)
					{
						_003C_003E7__wrap1.Dispose();
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
			goto IL_0262;
			IL_0214:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					break;
				case 5:
					goto IL_0031;
				case 2:
					goto IL_0245;
				default:
					goto IL_0262;
				case 6:
					return;
				}
				break;
				IL_0245:
				num2 = _003C_003E1__state;
				_ = 1;
				num = ((!eJ481G5nAsA6R3tSM8iu()) ? 4 : 0);
			}
			goto IL_001a;
			IL_0262:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0214;
			IL_001a:
			formatOutputData = _003C_003E4__this;
			num = 5;
			if (eJ481G5nAsA6R3tSM8iu())
			{
				goto IL_0031;
			}
			goto IL_0214;
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
		internal static object Y1aoeY5nRbdv9OOtNtdm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ScopedCounter)P_0).Increment();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vO6RpM5nWCEKU1VJop3V(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jKufoS5nCZZXPalljPMk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eJ481G5nAsA6R3tSM8iu()
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
	private struct _003CBuildExpressions_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FormatOutputData _003C_003E4__this;

		private int _003CmaxExprLength_003E5__2;

		private int _003CcurrCellIndex_003E5__3;

		private IEnumerator<DataElement> _003C_003E7__wrap3;

		private string _003Cformat_003E5__5;

		private string _003CcellRef_003E5__6;

		private bool _003C_003E7__wrap6;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!e8O4VH5nTyYlLRfvOd0q()) ? 5 : 3);
			FormatOutputData formatOutputData = default;
			bool flag = default;
			string text = default;
			string text2 = default;
			DataElement current = default;
			TaskAwaiter<bool> awaiter2 = default;
			bool result = default;
			int num2 = default;
			do
			{
				IL_04e5:
				switch (num)
				{
				case 2:
					try
					{
						TaskAwaiter<CvsCogSheetResult> awaiter;
						switch (num2)
						{
						default:
							_003CmaxExprLength_003E5__2 = formatOutputData.InSight.ProcessorConstants.MaxExpressionLength;
							flag = false;
							_003CcurrCellIndex_003E5__3 = 0;
							text = "";
							text2 = "";
							_003C_003E7__wrap3 = formatOutputData.Elements.GetEnumerator();
							goto case 0;
						case 0:
							try
							{
								if (num2 != 0)
								{
									goto IL_02da;
								}
								awaiter2 = _003C_003Eu__1;
								goto IL_01a1;
								IL_0150:
								int num3;
								while (true)
								{
									switch (num3)
									{
									case 4:
										break;
									case 11:
										_003Cformat_003E5__5 = current.DataType.Format;
										num3 = 16;
										continue;
									case 0:
										text2 = (string)G9xbDU5nMcNiVmGcruFh(text2, _003CcellRef_003E5__6);
										num3 = 13;
										continue;
									case 5:
										awaiter2 = formatOutputData.XSxqYBfEXm(text, text2, _003CcurrCellIndex_003E5__3++).GetAwaiter();
										num3 = 12;
										continue;
									case 6:
										text2 = "";
										num3 = 7;
										continue;
									case 10:
										_003C_003E7__wrap6 = flag;
										num3 = 5;
										continue;
									case 1:
										return;
									default:
										goto IL_01a1;
									case 7:
										text = (string)xrxmI05nFH418GCLipaS(text, _003Cformat_003E5__5);
										num3 = 0;
										continue;
									case 12:
										if (!awaiter2.IsCompleted)
										{
											num2 = (_003C_003E1__state = 0);
											num3 = 14;
											if (0 == 0)
											{
												continue;
											}
											goto case 13;
										}
										goto case 2;
									case 13:
										_003Cformat_003E5__5 = null;
										_003CcellRef_003E5__6 = null;
										num3 = 18;
										continue;
									case 8:
									case 17:
										_003C_003Eu__1 = default;
										num2 = (_003C_003E1__state = -1);
										goto case 2;
									case 15:
										flag = _003C_003E7__wrap6 | result;
										num3 = 4;
										continue;
									case 16:
										_003CcellRef_003E5__6 = Qdbw9p5n0L5RyeHw3FZA(current.Cell).ToString(absoluteRow: true, absoluteColumn: true);
										num3 = 3;
										if (e8O4VH5nTyYlLRfvOd0q())
										{
											continue;
										}
										goto case 14;
									case 14:
										_003C_003Eu__1 = awaiter2;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num3 = 1;
										if (0 == 0)
										{
											continue;
										}
										goto case 3;
									case 3:
										if (FormatOutputBufferHelper.BuildExpression(text, text2, _003Cformat_003E5__5, _003CcellRef_003E5__6).Length >= _003CmaxExprLength_003E5__2)
										{
											num3 = 10;
											continue;
										}
										goto case 7;
									case 2:
									case 9:
										result = awaiter2.GetResult();
										num3 = 15;
										continue;
									case 18:
										goto IL_02da;
									}
									break;
								}
								goto IL_009c;
								IL_02da:
								if (etSYES5nYTaCm69E7OcX(_003C_003E7__wrap3))
								{
									current = _003C_003E7__wrap3.Current;
									num3 = 11;
									if (1 == 0)
									{
										goto IL_009c;
									}
									goto IL_0150;
								}
								goto end_IL_0078;
								IL_01a1:
								_ = 1;
								if (!PEmIa25nyt2W3PSRdsZ3())
								{
									num3 = 17;
									if (PEmIa25nyt2W3PSRdsZ3())
									{
									}
								}
								else
								{
									num3 = 2;
								}
								goto IL_0150;
								IL_009c:
								text = "";
								num3 = 6;
								goto IL_0150;
								end_IL_0078:;
							}
							finally
							{
								if (num2 < 0 && _003C_003E7__wrap3 != null)
								{
									Rwgu5m5nU2aN3VFSYRIN(_003C_003E7__wrap3);
								}
							}
							_003C_003E7__wrap3 = null;
							if (Bt3KON5nH89MBqm7Wxva(text) > 0 && Bt3KON5nH89MBqm7Wxva(text2) > 0)
							{
								_003C_003E7__wrap6 = flag;
								awaiter2 = formatOutputData.XSxqYBfEXm(text, text2, _003CcurrCellIndex_003E5__3++).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__1 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_03a5;
							}
							goto IL_03b8;
						case 1:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_03a5;
						case 2:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_041f;
						case 3:
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								break;
							}
							IL_041f:
							result = awaiter2.GetResult();
							flag = _003C_003E7__wrap6 | result;
							if (flag)
							{
								awaiter = ((CvsCogSocketSheet)yRA8Rh5nxIjWqgbcxaHJ(formatOutputData.InSight.CogSocket)).RunAsync(true).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 3);
									_003C_003Eu__2 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								break;
							}
							goto end_IL_0024;
							IL_03a5:
							result = awaiter2.GetResult();
							flag = _003C_003E7__wrap6 | result;
							goto IL_03b8;
							IL_03b8:
							_003C_003E7__wrap6 = flag;
							awaiter2 = formatOutputData.xw7q0SsFBu(_003CcurrCellIndex_003E5__3).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 2);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_041f;
						}
						awaiter.GetResult();
						end_IL_0024:;
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
					goto IL_04e5;
				case 1:
				case 5:
					formatOutputData = _003C_003E4__this;
					num = 2;
					if (e8O4VH5nTyYlLRfvOd0q())
					{
						goto IL_04e5;
					}
					goto case 0;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
			}
			while (0 == 0);
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
		internal static CvsCellLocation Qdbw9p5n0L5RyeHw3FZA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xrxmI05nFH418GCLipaS(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FormatOutputBufferHelper.AddFormatArg((string)P_0, (string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object G9xbDU5nMcNiVmGcruFh(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FormatOutputBufferHelper.AddCellArg((string)P_0, (string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool etSYES5nYTaCm69E7OcX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Rwgu5m5nU2aN3VFSYRIN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int Bt3KON5nH89MBqm7Wxva(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yRA8Rh5nxIjWqgbcxaHJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool e8O4VH5nTyYlLRfvOd0q()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PEmIa25nyt2W3PSRdsZ3()
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
	private struct _003CWriteOutputBuffer_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public string formatArgs;

		public string cellArgs;

		public FormatOutputData _003C_003E4__this;

		public int currCellIndex;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fMNnDs5nmVf4lkJpt5Ma();
			int num = ((!GZKeYf5nQYJBqUqDysTN()) ? 1 : 3);
			bool result = default;
			int num2 = default;
			FormatOutputData formatOutputData = default;
			string expression = default;
			TaskAwaiter<object> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (GZKeYf5nQYJBqUqDysTN())
					{
					}
					break;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					if (fMNnDs5nmVf4lkJpt5Ma())
					{
						break;
					}
					goto case 4;
				case 4:
					formatOutputData = _003C_003E4__this;
					goto case 2;
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							expression = (string)UaiTIZ5nNpNxcoTHqZqv(formatArgs, cellArgs, null, null);
							num3 = 2;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 7;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								if (GZKeYf5nQYJBqUqDysTN())
								{
								}
								continue;
							case 3:
								_003C_003Eu__1 = awaiter;
								goto case 4;
							default:
								num3 = 4;
								continue;
							case 1:
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								goto case 6;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 5:
								return;
							case 9:
								return;
							case 6:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 2:
								awaiter = ((CvsCogSocketSheet)c7QX3d5ncCvNiebrKT4n(gxKj3N5n2uPVA5nn7ivO(formatOutputData.InSight))).PutCellExpressionAsync(formatOutputData.TXHqJ0DanK()[currCellIndex], expression).GetAwaiter();
								_ = 0;
								num3 = (fMNnDs5nmVf4lkJpt5Ma() ? 8 : 9);
								continue;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 6;
								continue;
							case 10:
								result = true;
								break;
							}
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
		internal static object UaiTIZ5nNpNxcoTHqZqv(object P_0, object P_1, object P_2, object P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FormatOutputBufferHelper.BuildExpression((string)P_0, (string)P_1, (string)P_2, (string)P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gxKj3N5n2uPVA5nn7ivO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object c7QX3d5ncCvNiebrKT4n(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fMNnDs5nmVf4lkJpt5Ma()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GZKeYf5nQYJBqUqDysTN()
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
	private struct _003CClearEndingCells_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public FormatOutputData _003C_003E4__this;

		public int currCellIndex;

		private CvsCellCollection _003Ccells_003E5__2;

		private int _003Ci_003E5__3;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			int num2 = default;
			FormatOutputData formatOutputData = default;
			TaskAwaiter<object> awaiter = default;
			bool result = default;
			bool flag = default;
			int num4 = default;
			CvsCellLocation cvsCellLocation = default;
			do
			{
				IL_02cc:
				switch (num)
				{
				case 1:
					try
					{
						int num3;
						object obj;
						if (num2 != 0)
						{
							CvsInSight inSight = formatOutputData.InSight;
							if (inSight == null)
							{
								num3 = 16;
							}
							else
							{
								CvsResultSet results = inSight.Results;
								if (results != null)
								{
									obj = results.Cells;
									goto IL_00ed;
								}
								num3 = 8;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 11;
							if (false)
							{
								goto IL_00e2;
							}
						}
						goto IL_01e6;
						IL_00e2:
						obj = null;
						goto IL_00ed;
						IL_00ed:
						if (obj == null)
						{
							result = false;
							num3 = 0;
						}
						else
						{
							flag = false;
							num3 = 2;
						}
						goto IL_01e6;
						IL_01e6:
						while (true)
						{
							switch (num3)
							{
							case 17:
								_003Ci_003E5__3 = num4 + 1;
								num3 = 15;
								continue;
							case 12:
								if (Fihr945V5OTy48M54qWQ(xnvAbp5VLttCmtk6hTZV(omaRrP5nzDWCYVUQ66vC(_003Ccells_003E5__2, cvsCellLocation)), qLZTam5VKa6lvhkSPf3h(29400)))
								{
									goto IL_006f;
								}
								goto case 3;
							case 7:
								awaiter.GetResult();
								num3 = 5;
								if (0 == 0)
								{
									continue;
								}
								goto case 4;
							case 4:
								_003Ci_003E5__3 = currCellIndex;
								goto case 15;
							case 1:
								return;
							case 8:
								break;
							case 3:
							case 13:
								num4 = _003Ci_003E5__3;
								num3 = 17;
								continue;
							case 14:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 1;
								continue;
							case 6:
							case 10:
								awaiter = ((CvsCogSocket)lpLEHV5Vw6UoH4waJLvy(formatOutputData.InSight)).Sheet.PutCellExpressionAsync(cvsCellLocation, CdQUGaROfy7He9T0foW.KbIzwHEDLa(29400)).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 9;
									continue;
								}
								goto case 7;
							case 2:
								_003Ccells_003E5__2 = (CvsCellCollection)CslXCe5ntcHEPR1S2H0C(ECckuA5nhGKKDJvpVtHl(formatOutputData.InSight));
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto case 16;
							case 16:
								obj = null;
								goto IL_00ed;
							case 11:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 7;
								continue;
							case 9:
								_003C_003Eu__1 = awaiter;
								goto case 14;
							default:
								num3 = 14;
								if (true)
								{
									continue;
								}
								goto end_IL_0018;
							case 0:
								goto end_IL_0018;
							case 5:
								flag = true;
								goto case 3;
							case 15:
								if (_003Ci_003E5__3 < Qk8ojg5VJTj2jjnJpa1e(formatOutputData.TXHqJ0DanK()))
								{
									cvsCellLocation = formatOutputData.TXHqJ0DanK()[_003Ci_003E5__3];
									num3 = 12;
									if (0 == 0)
									{
										continue;
									}
									return;
								}
								num3 = 18;
								if (0 == 0)
								{
									continue;
								}
								goto case 18;
							case 18:
								result = flag;
								goto end_IL_0018;
							}
							break;
							IL_006f:
							_ = 1;
							num3 = (IZG2pA5nuE3u4IpXYkhD() ? 3 : 10);
						}
						goto IL_00e2;
						end_IL_0018:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Ccells_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				default:
					DOQOW95n1aIAvKLe8enw();
					if (!IZG2pA5nuE3u4IpXYkhD())
					{
						num = 5;
						if (0 == 0)
						{
							goto IL_02cc;
						}
						goto case 2;
					}
					num = 0;
					goto IL_02cc;
				case 2:
					num2 = _003C_003E1__state;
					num = 6;
					if (0 == 0)
					{
						goto IL_02cc;
					}
					goto case 6;
				case 6:
					formatOutputData = _003C_003E4__this;
					num = 1;
					goto IL_02cc;
				case 3:
				case 5:
					_003Ccells_003E5__2 = null;
					break;
				case 0:
				case 4:
					break;
				case 7:
					return;
				}
				_003C_003Et__builder.SetResult(result);
				num = 7;
			}
			while (DOQOW95n1aIAvKLe8enw());
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
		internal static object ECckuA5nhGKKDJvpVtHl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CslXCe5ntcHEPR1S2H0C(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object omaRrP5nzDWCYVUQ66vC(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xnvAbp5VLttCmtk6hTZV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qLZTam5VKa6lvhkSPf3h(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Fihr945V5OTy48M54qWQ(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 != (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lpLEHV5Vw6UoH4waJLvy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int Qk8ojg5VJTj2jjnJpa1e(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((List<CvsCellLocation>)P_0).Count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DOQOW95n1aIAvKLe8enw()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IZG2pA5nuE3u4IpXYkhD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private readonly List<CvsCellLocation> mKPqm8eixy;

	[CompilerGenerated]
	private CvsCellLocation ff4q1xwdPp;

	private string GvXqz9iDcE;

	private int wutiaaE9KB;

	public string FormattedOutput
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GvXqz9iDcE;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref GvXqz9iDcE, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(29456));
		}
	}

	public int OutputSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wutiaaE9KB;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref wutiaaE9KB, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(29490));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FormatOutputData(IInSightAppStep appStep)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (O7Di4O2s14OVkMcl5uC())
		{
			num = 4;
		}
		else
		{
			num = 3;
			if (false)
			{
				goto IL_0050;
			}
		}
		goto IL_0069;
		IL_0024:
		mKPqm8eixy = new List<CvsCellLocation>();
		num = 5;
		goto IL_0069;
		IL_0050:
		base._002Ector(appStep);
		goto IL_0024;
		IL_0069:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 0:
			case 4:
				GUjC7Y2rIIPQriEB0He();
				goto IL_0050;
			case 1:
			case 3:
				goto IL_0050;
			default:
				num = 2;
				continue;
			case 5:
				return;
			}
			break;
		}
		goto IL_0024;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ResetElements()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IDisposable disposable = (IDisposable)hEsCF72PV7UOQwnREbJ(_suspendElementsEvents);
		try
		{
			G3Sxek2ZPJAPmJ4Wfdt(TXHqJ0DanK());
			_ = 1;
			int num = (AKWbhW2vVI21vRs7vZK() ? 2 : 4);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					nDSqhV1xg1(CvsCellLocation.Invalid);
					goto case 1;
				case 1:
				case 2:
					FormattedOutput = string.Empty;
					goto case 3;
				default:
					num = 3;
					break;
				case 3:
					OutputSize = 0;
					num = 5;
					break;
				case 5:
					aTa0Kk2BVOG0Y5jPEio(Elements);
					return;
				}
			}
		}
		finally
		{
			if (disposable != null)
			{
				urNBD92b6W4ynMUTV9W(disposable);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnSheetExecuted()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base.OnSheetExecuted();
		kB0qVycQ7L();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnElementsChanged_003Ed__3))]
	protected override Task OnElementsChanged(NotifyCollectionChangedEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003COnElementsChanged_003Ed__3 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 6:
				stateMachine.e = e;
				goto default;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				O7Di4O2s14OVkMcl5uC();
				num = (AKWbhW2vVI21vRs7vZK() ? 1 : 6);
				break;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				if (!AKWbhW2vVI21vRs7vZK())
				{
					break;
				}
				goto case 0;
			case 0:
				stateMachine._003C_003Et__builder = tvh0ro2GZCJnBy4sGgm();
				num = 4;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnSelectedElementPropertyChanged_003Ed__4))]
	protected override Task OnSelectedElementPropertyChanged(string propertyName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003COnSelectedElementPropertyChanged_003Ed__4 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 4;
				continue;
			case 4:
				stateMachine._003C_003E4__this = this;
				O7Di4O2s14OVkMcl5uC();
				if (!AKWbhW2vVI21vRs7vZK())
				{
					num = 1;
					continue;
				}
				num = 0;
				if (O7Di4O2s14OVkMcl5uC())
				{
					continue;
				}
				goto default;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (true)
				{
					continue;
				}
				break;
			case 6:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveSnippetReferences_003Ed__5))]
	public override Task RemoveSnippetReferences(EzSnippet snippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CRemoveSnippetReferences_003Ed__5 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			case 1:
				stateMachine._003C_003E4__this = this;
				AKWbhW2vVI21vRs7vZK();
				num = (O7Di4O2s14OVkMcl5uC() ? 3 : 6);
				break;
			case 2:
			case 3:
				stateMachine.snippet = snippet;
				goto case 0;
			default:
				num = 0;
				break;
			case 4:
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 5:
				stateMachine._003C_003Et__builder = tvh0ro2GZCJnBy4sGgm();
				num = 1;
				if (AKWbhW2vVI21vRs7vZK())
				{
				}
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void e0eqZQS4cw(CvsCell P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (1 == 0)
		{
			return;
		}
		do
		{
			IL_003e:
			switch (num)
			{
			case 1:
			case 3:
				return;
			case 0:
				if (P_0 != null)
				{
					TXHqJ0DanK().Add(pxUJ5G2oYjWRh2C6mw4(P_0));
					break;
				}
				AKWbhW2vVI21vRs7vZK();
				num = (O7Di4O2s14OVkMcl5uC() ? 3 : 4);
				goto IL_003e;
			case 5:
				return;
			}
			k4YqnHAGxM((string)oMlxUg2SCYNFk9ZR3ke(P_0));
			num = 5;
		}
		while (true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal List<CvsCellLocation> TXHqJ0DanK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return mKPqm8eixy;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal CvsCellLocation UQsqrKkj6q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ff4q1xwdPp;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal void nDSqhV1xg1(CvsCellLocation value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ff4q1xwdPp = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool k4YqnHAGxM(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (O7Di4O2s14OVkMcl5uC())
		{
			num = 2;
			if (AKWbhW2vVI21vRs7vZK())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
		}
		IDisposable disposable = default;
		CellViewModel cellViewModel = default;
		CvsCellLocation cellLoc = default;
		DataElement item = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				break;
			default:
				num = 4;
				if (O7Di4O2s14OVkMcl5uC())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				if (!bFIRen28LaLucUeDvpt(P_0, tGVaEh2kdOSwMih9j8T(29400)))
				{
					disposable = _suspendElementsEvents.Increment();
					goto case 4;
				}
				break;
			case 4:
				try
				{
					IEnumerable<FormatOutputBufferCellRef> enumerable = FormatOutputBufferHelper.ParseExpression(P_0);
					if (enumerable == null || !enumerable.Any())
					{
						return false;
					}
					IEnumerator<FormatOutputBufferCellRef> enumerator = enumerable.GetEnumerator();
					try
					{
						while (aBGdDe2EkqcXaX4j7Zw(enumerator))
						{
							FormatOutputBufferCellRef current = enumerator.Current;
							int num2 = 0;
							while (true)
							{
								switch (num2)
								{
								case 3:
									cellViewModel = FindCellVm(cellLoc);
									_ = 0;
									num2 = ((!O7Di4O2s14OVkMcl5uC()) ? 1 : 6);
									continue;
								case 5:
									item = new DataElement(cellViewModel, current.Format);
									goto case 1;
								case 1:
								case 4:
									Elements.Add(item);
									num2 = 7;
									if (O7Di4O2s14OVkMcl5uC())
									{
										continue;
									}
									goto case 2;
								case 2:
								case 6:
									if (cellViewModel == null)
									{
										break;
									}
									goto case 5;
								default:
									num2 = 5;
									if (AKWbhW2vVI21vRs7vZK())
									{
									}
									continue;
								case 0:
									cellLoc = opQ5i02qU4UVJ1kX4QU(current.CellRef);
									num2 = 3;
									continue;
								case 7:
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
							urNBD92b6W4ynMUTV9W(enumerator);
						}
					}
					return true;
				}
				finally
				{
					if (disposable != null)
					{
						urNBD92b6W4ynMUTV9W(disposable);
					}
				}
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CBuildExpressions_003Ed__15))]
	private Task SfBqtFh5ik()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CBuildExpressions_003Ed__15 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
				stateMachine._003C_003Et__builder = tvh0ro2GZCJnBy4sGgm();
				_ = 1;
				if (!AKWbhW2vVI21vRs7vZK())
				{
					num = 4;
					break;
				}
				num = 0;
				if (AKWbhW2vVI21vRs7vZK())
				{
				}
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteOutputBuffer_003Ed__16))]
	private Task<bool> XSxqYBfEXm(string P_0, string P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CWriteOutputBuffer_003Ed__16 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.formatArgs = P_0;
		stateMachine.cellArgs = P_1;
		stateMachine.currCellIndex = P_2;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CClearEndingCells_003Ed__17))]
	private Task<bool> xw7q0SsFBu(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CClearEndingCells_003Ed__17 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.currCellIndex = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void kB0qVycQ7L()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		CvsCellLocation cvsCellLocation = default;
		byte[] array = default;
		OutputBufferData outputBufferData = default;
		while (true)
		{
			object obj2;
			object obj6;
			object obj;
			JObject obj5;
			switch (num)
			{
			case 1:
			case 3:
			{
				if (!cvsCellLocation.IsValid)
				{
					return;
				}
				object obj3 = rovtZC243kNPZ1MWfMX(nScNqt29GxJPdoXsTRC(InSight.Results), UQsqrKkj6q());
				if (obj3 == null)
				{
					num = 9;
					break;
				}
				object obj4 = O183LS27k64QCc1Tt4P(obj3);
				if (obj4 == null)
				{
					num = 0;
					break;
				}
				obj2 = ((CvsCogCellResult)obj4).Value;
				goto IL_00e1;
			}
			case 2:
				obj6 = null;
				goto IL_005c;
			case 7:
			{
				CvsInSight inSight = InSight;
				if (inSight == null)
				{
					num = 4;
					break;
				}
				object obj7 = dbjTir2piZCQIASYFBI(inSight);
				if (obj7 == null)
				{
					num = 5;
					break;
				}
				obj = LqFTWD2XmOHjKy69qVP(obj7);
				goto IL_0183;
			}
			case 8:
			case 11:
				FormattedOutput = (string)cfd69x2j22yQOF90nsn(array);
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 9;
			case 9:
				obj2 = null;
				goto IL_00e1;
			case 4:
				obj = null;
				goto IL_0183;
			case 0:
				obj2 = null;
				goto IL_00e1;
			default:
				num = 2;
				break;
			case 6:
				OutputSize = array.Length;
				num = 12;
				if (true)
				{
					break;
				}
				goto case 10;
			case 10:
				array = Convert.FromBase64String(((CvsCogByteArray)MKc02l23PNaktngV93d(outputBufferData)).Base64);
				goto case 8;
			case 5:
				obj = null;
				goto IL_0183;
			case 12:
				return;
				IL_00e1:
				obj5 = obj2 as JObject;
				if (obj5 != null)
				{
					obj6 = obj5.ToObject<OutputBufferData>();
					goto IL_005c;
				}
				goto case 2;
				IL_005c:
				outputBufferData = (OutputBufferData)obj6;
				if (outputBufferData != null)
				{
					num = 10;
					if (true)
					{
						break;
					}
					goto case 7;
				}
				return;
				IL_0183:
				if (obj == null)
				{
					return;
				}
				cvsCellLocation = UQsqrKkj6q();
				_ = 0;
				num = (O7Di4O2s14OVkMcl5uC() ? 1 : 11);
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task JkGqLIXJAU(NotifyCollectionChangedEventArgs P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnElementsChanged(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GUjC7Y2rIIPQriEB0He()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool O7Di4O2s14OVkMcl5uC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AKWbhW2vVI21vRs7vZK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hEsCF72PV7UOQwnREbJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ScopedCounter)P_0).Increment();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void G3Sxek2ZPJAPmJ4Wfdt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((List<CvsCellLocation>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aTa0Kk2BVOG0Y5jPEio(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Collection<DataElement>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void urNBD92b6W4ynMUTV9W(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder tvh0ro2GZCJnBy4sGgm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation pxUJ5G2oYjWRh2C6mw4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oMlxUg2SCYNFk9ZR3ke(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tGVaEh2kdOSwMih9j8T(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bFIRen28LaLucUeDvpt(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation opQ5i02qU4UVJ1kX4QU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.TryParse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool aBGdDe2EkqcXaX4j7Zw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dbjTir2piZCQIASYFBI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Results;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LqFTWD2XmOHjKy69qVP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsResultSet)P_0).Cells;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nScNqt29GxJPdoXsTRC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsResultSet)P_0).Cells;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rovtZC243kNPZ1MWfMX(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object O183LS27k64QCc1Tt4P(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).CellResult;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MKc02l23PNaktngV93d(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((OutputBufferData)P_0).BufferData;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cfd69x2j22yQOF90nsn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return FormatOutputBufferHelper.GetFormattedOutput((byte[])P_0);
	}
}
