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
using Cognex.Designer.Utils.Operations;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Controls.ViewModels.PropertySheet.FormatElement;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public class FormatInputData : FormatDataBase
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSetInputTableEnd_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FormatInputData _003C_003E4__this;

		public CvsCellLocation endCell;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (SYb93w5D8qcjuAQqOcKH())
			{
				goto IL_001e;
			}
			goto IL_0218;
			IL_001e:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (SYb93w5D8qcjuAQqOcKH())
			{
			}
			goto IL_0218;
			IL_0218:
			int num2 = default;
			FormatInputData formatInputData = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (!formatInputData.PAyqBddu0t.IsValid)
							{
								goto IL_0192;
							}
							num3 = 8;
							if (false)
							{
								goto IL_005f;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
						}
						goto IL_00ad;
						IL_00ad:
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 10:
								break;
							case 8:
								goto IL_0075;
							case 6:
								if (!awaiter.IsCompleted)
								{
									goto default;
								}
								goto case 12;
							case 11:
								goto IL_00f8;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								continue;
							default:
								num2 = (_003C_003E1__state = 0);
								num3 = 11;
								if (0 == 0)
								{
									continue;
								}
								goto case 4;
							case 4:
								throw new InvalidProgramException((string)rTtH8N5DqexygWZPm72C(52382));
							case 0:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								if (0 == 0)
								{
									continue;
								}
								goto IL_0192;
							case 1:
								goto IL_0192;
							case 9:
								return;
							case 12:
								awaiter.GetResult();
								goto end_IL_003d;
							}
							break;
							IL_0075:
							if (formatInputData.PAyqBddu0t.IsEmpty)
							{
								num3 = 1;
								continue;
							}
							if (formatInputData.PAyqBddu0t.Count() == 1)
							{
								formatInputData.PAyqBddu0t.LastLocation = endCell;
								IXA6Sj5Dkw45Tto6m8ym();
								if (SYb93w5D8qcjuAQqOcKH())
								{
									num3 = 7;
									if (0 == 0)
									{
										continue;
									}
									goto IL_00f8;
								}
								num3 = 10;
								continue;
							}
							num3 = 4;
							continue;
							IL_00f8:
							_003C_003Eu__1 = awaiter;
							num3 = 2;
						}
						goto IL_005f;
						IL_005f:
						awaiter = XaHEUy5DEr6VmOFFtOVl(formatInputData.vnhq41f5GT());
						num3 = 6;
						goto IL_00ad;
						IL_0192:
						throw new InvalidProgramException((string)rTtH8N5DqexygWZPm72C(52230));
						end_IL_003d:;
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
					num = 5;
					continue;
				case 0:
				case 1:
					formatInputData = _003C_003E4__this;
					goto case 2;
				case 3:
					num2 = _003C_003E1__state;
					_ = 0;
					if (!IXA6Sj5Dkw45Tto6m8ym())
					{
						num = 4;
						continue;
					}
					num = 0;
					if (SYb93w5D8qcjuAQqOcKH())
					{
					}
					continue;
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
		internal static object rTtH8N5DqexygWZPm72C(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter XaHEUy5DEr6VmOFFtOVl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IXA6Sj5Dkw45Tto6m8ym()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SYb93w5D8qcjuAQqOcKH()
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
	private struct _003COnElementsChanged_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FormatInputData _003C_003E4__this;

		public NotifyCollectionChangedEventArgs e;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KXeiye5DpFSUNwgNlARG();
			int num = (JRPgRS5DXQLixPpeMDqJ() ? 4 : 5);
			int num2 = default;
			FormatInputData formatInputData = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<CvsCogSheetResult> awaiter2 = default;
			NotifyCollectionChangedAction notifyCollectionChangedAction = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 4:
					formatInputData = _003C_003E4__this;
					num = 2;
					if (true)
					{
						break;
					}
					goto case 3;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							awaiter = r5gE0b5D95tIYSBfTG3C(formatInputData.dG8qxm9Ncc(e));
							num3 = 3;
							goto IL_030e;
						case 3:
							awaiter = _003C_003Eu__1;
							num3 = 30;
							if (JRPgRS5DXQLixPpeMDqJ())
							{
							}
							goto IL_030e;
						case 1:
							awaiter = _003C_003Eu__1;
							num3 = 21;
							goto IL_030e;
						case 4:
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 34;
							if (JRPgRS5DXQLixPpeMDqJ())
							{
								goto IL_0230;
							}
							goto IL_030e;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 4;
							goto IL_030e;
						case 2:
							{
								awaiter = _003C_003Eu__1;
								goto IL_04cc;
							}
							IL_030e:
							while (true)
							{
								switch (num3)
								{
								case 23:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 15;
									continue;
								case 10:
									if (!awaiter.IsCompleted)
									{
										num3 = 13;
										continue;
									}
									goto case 25;
								case 30:
									_003C_003Eu__1 = default;
									num3 = 22;
									continue;
								case 17:
									return;
								case 4:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 14;
									continue;
								case 22:
									break;
								case 18:
									if (!awaiter.IsCompleted)
									{
										num3 = 5;
										continue;
									}
									goto case 24;
								case 9:
									return;
								case 32:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 11;
									if (KXeiye5DpFSUNwgNlARG())
									{
										continue;
									}
									goto case 0;
								case 0:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 9;
									continue;
								case 20:
									num2 = (_003C_003E1__state = -1);
									num3 = 24;
									continue;
								case 1:
									_003C_003Eu__1 = awaiter;
									num3 = 8;
									continue;
								case 5:
									num2 = (_003C_003E1__state = 2);
									num3 = 32;
									if (JRPgRS5DXQLixPpeMDqJ())
									{
									}
									continue;
								case 14:
									awaiter.GetResult();
									num3 = 26;
									if (0 == 0)
									{
										continue;
									}
									return;
								case 15:
									return;
								case 13:
									goto end_IL_030e;
								case 12:
									return;
								case 21:
									goto IL_02a0;
								case 16:
								case 29:
									_003C_003Eu__2 = awaiter2;
									num3 = 23;
									if (0 == 0)
									{
										continue;
									}
									goto case 26;
								case 26:
									notifyCollectionChangedAction = b20OBo5D4vEVukMP4xqv(e);
									num3 = 2;
									continue;
								case 11:
									return;
								default:
									num3 = 31;
									continue;
								case 8:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 17;
									continue;
								case 2:
									switch (notifyCollectionChangedAction)
									{
									case NotifyCollectionChangedAction.Move:
										break;
									case NotifyCollectionChangedAction.Add:
										goto IL_03dc;
									case NotifyCollectionChangedAction.Remove:
										goto IL_0482;
									default:
										goto IL_04e2;
									}
									awaiter = r5gE0b5D95tIYSBfTG3C(formatInputData.y3DqT83iZf(vTws8g5D3eyl3ZVTlZiW(VFyrfP5D7oTO1aoDIqvE(e), 0) as DataElement, Y6oY995DjZIB3QiOxtmQ(e), e.NewStartingIndex));
									num3 = 18;
									continue;
								case 24:
									awaiter.GetResult();
									num3 = 7;
									continue;
								case 3:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 0);
										num3 = 6;
										continue;
									}
									goto case 14;
								case 19:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 12;
									continue;
								case 25:
								case 27:
									awaiter.GetResult();
									num3 = 28;
									continue;
								case 6:
									_003C_003Eu__1 = awaiter;
									num3 = 19;
									if (true)
									{
										continue;
									}
									goto IL_04cc;
								case 31:
									goto IL_04cc;
								case 7:
								case 28:
								case 33:
									goto IL_04e2;
								case 34:
									{
										awaiter2.GetResult();
										goto end_IL_006a;
									}
									IL_04e2:
									awaiter2 = ((CvsCogSocketSheet)hsV9VH5DAIQRZrJXMx5h(VJ8hBI5DCZvRNBVnW7Cb(formatInputData.InSight))).RunAsync(true).GetAwaiter();
									if (!awaiter2.IsCompleted)
									{
										num2 = (_003C_003E1__state = 4);
										goto case 16;
									}
									goto case 34;
									IL_0482:
									awaiter = r5gE0b5D95tIYSBfTG3C(formatInputData.r6DqjUNLYc(((IList)ajg46N5D6eyPtFdbGu2v(e))[0] as DataElement, e.OldStartingIndex));
									num3 = 10;
									continue;
								}
								num2 = (_003C_003E1__state = -1);
								_ = 0;
								num3 = ((!KXeiye5DpFSUNwgNlARG()) ? 16 : 25);
								continue;
								IL_03dc:
								awaiter = formatInputData.bY1qlD108C(vTws8g5D3eyl3ZVTlZiW(VFyrfP5D7oTO1aoDIqvE(e), 0) as DataElement).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__1 = awaiter;
									num3 = 0;
									continue;
								}
								goto IL_02b5;
								IL_02b5:
								awaiter.GetResult();
								num3 = 33;
								continue;
								IL_02a0:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_02b5;
								continue;
								end_IL_030e:
								break;
							}
							goto IL_0230;
							IL_04cc:
							_003C_003Eu__1 = default;
							num3 = 20;
							goto IL_030e;
							IL_0230:
							num2 = (_003C_003E1__state = 3);
							num3 = 1;
							goto IL_030e;
							end_IL_006a:
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
					goto case 3;
				default:
					num = 3;
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
		internal static TaskAwaiter r5gE0b5D95tIYSBfTG3C(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static NotifyCollectionChangedAction b20OBo5D4vEVukMP4xqv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((NotifyCollectionChangedEventArgs)P_0).Action;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VFyrfP5D7oTO1aoDIqvE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((NotifyCollectionChangedEventArgs)P_0).NewItems;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vTws8g5D3eyl3ZVTlZiW(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IList)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int Y6oY995DjZIB3QiOxtmQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((NotifyCollectionChangedEventArgs)P_0).OldStartingIndex;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ajg46N5D6eyPtFdbGu2v(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((NotifyCollectionChangedEventArgs)P_0).OldItems;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VJ8hBI5DCZvRNBVnW7Cb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hsV9VH5DAIQRZrJXMx5h(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KXeiye5DpFSUNwgNlARG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JRPgRS5DXQLixPpeMDqJ()
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
	private struct _003COnSelectedElementPropertyChanged_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FormatInputData _003C_003E4__this;

		public string propertyName;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_02da;
			IL_001a:
			int num2 = _003C_003E1__state;
			num = 0;
			if (BLagnO5DWXonC9DQPmLG())
			{
				goto IL_0031;
			}
			goto IL_02da;
			IL_02da:
			TaskAwaiter awaiter = default;
			FormatInputData formatInputData = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 0:
					goto IL_0031;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 11;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 10;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_ = 0;
							if (!M1bRoW5DRTUqCoGrF8mM())
							{
								num3 = 6;
							}
							else
							{
								num3 = 7;
								if (BLagnO5DWXonC9DQPmLG())
								{
									goto IL_029a;
								}
							}
						}
						while (true)
						{
							object obj;
							switch (num3)
							{
							case 6:
							case 15:
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
								continue;
							case 17:
							{
								DataElement selectedElement = formatInputData.SelectedElement;
								if (selectedElement == null)
								{
									goto case 2;
								}
								obj = selectedElement.DataType;
								goto IL_016d;
							}
							default:
								num3 = 2;
								continue;
							case 9:
								awaiter = zc2Cpq5DTabgPOaYXp3B(formatInputData.G0tqWZaIpY());
								num3 = 16;
								continue;
							case 4:
							case 7:
								_003C_003Eu__1 = default;
								num3 = 14;
								continue;
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 12;
								continue;
							case 1:
								awaiter.GetResult();
								num3 = 17;
								continue;
							case 10:
								_003C_003Eu__1 = default;
								goto case 6;
							case 2:
								obj = null;
								goto IL_016d;
							case 13:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								continue;
							case 3:
								if (propertyName == CdQUGaROfy7He9T0foW.KbIzwHEDLa(52452))
								{
									num3 = 9;
									if (true)
									{
										continue;
									}
									goto case 11;
								}
								goto end_IL_009b;
							case 11:
								awaiter = zc2Cpq5DTabgPOaYXp3B(formatInputData.HW4qvedVgU(propertyName));
								if (awaiter.IsCompleted)
								{
									goto case 1;
								}
								num3 = 5;
								if (!BLagnO5DWXonC9DQPmLG())
								{
									continue;
								}
								goto case 16;
							case 16:
								if (!awaiter.IsCompleted)
								{
									num3 = 13;
									continue;
								}
								break;
							case 8:
								return;
							case 14:
								num2 = (_003C_003E1__state = -1);
								num3 = 1;
								if (true)
								{
									continue;
								}
								goto case 12;
							case 12:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 18:
								break;
								IL_016d:
								if (obj != null)
								{
									if (!QIGbw65D0mvU0ZtZHGw0(propertyName, vAcm3G5DyxhPK0V62qQ5(29194)))
									{
										num3 = 3;
										continue;
									}
									goto case 9;
								}
								goto end_IL_009b;
							}
							goto IL_029a;
							continue;
							end_IL_009b:
							break;
						}
						goto end_IL_0052;
						IL_029a:
						awaiter.GetResult();
						end_IL_0052:;
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
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_0031:
			formatInputData = _003C_003E4__this;
			BLagnO5DWXonC9DQPmLG();
			num = ((!M1bRoW5DRTUqCoGrF8mM()) ? 1 : 4);
			goto IL_02da;
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
		internal static TaskAwaiter zc2Cpq5DTabgPOaYXp3B(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vAcm3G5DyxhPK0V62qQ5(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QIGbw65D0mvU0ZtZHGw0(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool M1bRoW5DRTUqCoGrF8mM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BLagnO5DWXonC9DQPmLG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public CellViewModel property;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass19_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EkjtBw5DYBNlsOsh2uM8();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CRemoveSnippetReferences_003Eb__0(DataElement e)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)apHYlZ5DHflmuntlHolr(PbrmdI5DU1UVk2DiIE1b(e)) == property.CellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void EkjtBw5DYBNlsOsh2uM8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wbVwCg5DFXODb5JphxcS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cm5rJ95DMefDQoIpTxyI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PbrmdI5DU1UVk2DiIE1b(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DataElement)P_0).Cell;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object apHYlZ5DHflmuntlHolr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellName;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRemoveSnippetReferences_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FormatInputData _003C_003E4__this;

		public EzSnippet snippet;

		private IDisposable _003C_003E7__wrap1;

		private IEnumerator<CellViewModel> _003C_003E7__wrap2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bJ2Nig5DmfuG1H9Agykf();
			int num = (hR6nEu5DxaBHmje2VZEm() ? 1 : 2);
			int num2 = default;
			FormatInputData formatInputData = default;
			TaskAwaiter awaiter = default;
			DataElement dataElement = default;
			int num4 = default;
			_003C_003Ec__DisplayClass19_0 obj = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				case 5:
					formatInputData = _003C_003E4__this;
					num = 4;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (!bJ2Nig5DmfuG1H9Agykf())
					{
						break;
					}
					goto case 4;
				case 4:
					try
					{
						if (num2 != 0)
						{
							_003C_003E7__wrap1 = (IDisposable)jUyT1e5DQ2PMPOEJWQMy(formatInputData._suspendElementsEvents);
						}
						try
						{
							if (num2 != 0)
							{
								_003C_003E7__wrap2 = snippet.AllProperties.GetEnumerator();
							}
							try
							{
								if (num2 != 0)
								{
									goto IL_0256;
								}
								awaiter = _003C_003Eu__1;
								int num3 = 11;
								goto IL_016b;
								IL_016b:
								while (true)
								{
									switch (num3)
									{
									case 12:
										num2 = (_003C_003E1__state = -1);
										num3 = 3;
										continue;
									case 7:
										num2 = (_003C_003E1__state = 0);
										num3 = 10;
										if (0 == 0)
										{
											continue;
										}
										goto case 1;
									case 1:
										if (!awaiter.IsCompleted)
										{
											num3 = 7;
											continue;
										}
										goto case 3;
									case 10:
										_003C_003Eu__1 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									case 9:
										formatInputData.Elements.Remove(dataElement);
										num3 = 13;
										if (hR6nEu5DxaBHmje2VZEm())
										{
											continue;
										}
										goto case 13;
									case 13:
										awaiter = rqb0hy5DN6JFyO4XiLNM(formatInputData.r6DqjUNLYc(dataElement, num4));
										goto case 1;
									default:
										num3 = 1;
										continue;
									case 3:
										awaiter.GetResult();
										num3 = 14;
										continue;
									case 2:
									case 5:
										if (dataElement == null)
										{
											break;
										}
										num3 = 8;
										if (0 == 0)
										{
											continue;
										}
										goto case 11;
									case 11:
										_003C_003Eu__1 = default;
										num3 = 12;
										continue;
									case 6:
										dataElement = formatInputData.Elements.FirstOrDefault(obj._003CRemoveSnippetReferences_003Eb__0);
										goto case 2;
									case 8:
										num4 = formatInputData.Elements.IndexOf(dataElement);
										num3 = 9;
										if (hR6nEu5DxaBHmje2VZEm())
										{
											continue;
										}
										goto case 0;
									case 0:
									case 4:
										obj.property = _003C_003E7__wrap2.Current;
										num3 = 6;
										if (!bJ2Nig5DmfuG1H9Agykf())
										{
											continue;
										}
										break;
									case 14:
										break;
									}
									break;
								}
								goto IL_0256;
								IL_0256:
								if (_003C_003E7__wrap2.MoveNext())
								{
									obj = new _003C_003Ec__DisplayClass19_0();
									_ = 0;
									num3 = ((!hR6nEu5DxaBHmje2VZEm()) ? 5 : 4);
									goto IL_016b;
								}
							}
							finally
							{
								if (num2 < 0 && _003C_003E7__wrap2 != null)
								{
									miFxZ45D2KBF9KVBREle(_003C_003E7__wrap2);
								}
							}
							_003C_003E7__wrap2 = null;
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								miFxZ45D2KBF9KVBREle(_003C_003E7__wrap1);
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
					goto default;
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
		internal static object jUyT1e5DQ2PMPOEJWQMy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ScopedCounter)P_0).Increment();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter rqb0hy5DN6JFyO4XiLNM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void miFxZ45D2KBF9KVBREle(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hR6nEu5DxaBHmje2VZEm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bJ2Nig5DmfuG1H9Agykf()
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
	private struct _003CGetFormats_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<string>> _003C_003Et__builder;

		public FormatInputData _003C_003E4__this;

		private TaskAwaiter<string> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!h0nq8t5D1KRnIFpILtBZ())
			{
				num = 1;
			}
			else
			{
				num = 3;
				if (false)
				{
					goto IL_02ca;
				}
			}
			goto IL_0286;
			IL_0286:
			List<string> result = default;
			int num2 = default;
			FormatInputData formatInputData = default;
			List<string> list = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					continue;
				case 2:
				case 3:
					try
					{
						TaskAwaiter<string> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((CvsCogSocketSheet)Up3fqK5DhNANnspj85qm(itb1Dp5DuEOXVv34NDpD(formatInputData.InSight))).GetCellExpressionAsync(formatInputData.rnFqea0GmU()).GetAwaiter();
							num3 = 6;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
						}
						while (true)
						{
							string result2;
							switch (num3)
							{
							case 3:
								result = new List<string>();
								num3 = 15;
								continue;
							case 13:
								result = new List<string>();
								num3 = 14;
								if (0 == 0)
								{
									continue;
								}
								goto case 9;
							case 9:
								_003C_003Eu__1 = awaiter;
								num3 = 11;
								if (0 == 0)
								{
									continue;
								}
								goto case 5;
							case 5:
								num2 = (_003C_003E1__state = -1);
								goto IL_00ab;
							case 12:
								break;
							case 11:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 0;
								if (true)
								{
									continue;
								}
								goto default;
							default:
								result = new List<string>();
								num3 = 12;
								continue;
							case 2:
							{
								if (g5P8gZ5Dzj4paSN8w6qn(list) < 1)
								{
									num3 = 13;
									continue;
								}
								string text = list[0]?.Replace(CdQUGaROfy7He9T0foW.KbIzwHEDLa(1544), "");
								if (rfiP1S5DtQosr1EdhGhu(text))
								{
									num3 = 3;
									continue;
								}
								result = ((IEnumerable<string>)VfV0Qf5iLDDUuZYW1XTx(text, new char[1] { ':' })).ToList();
								break;
							}
							case 8:
								_003C_003Eu__1 = default;
								num3 = 5;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 0:
								return;
							case 1:
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 9;
								continue;
							case 14:
								break;
							case 6:
								if (!awaiter.IsCompleted)
								{
									_ = 1;
									if (h0nq8t5D1KRnIFpILtBZ())
									{
										num3 = 10;
										if (0 == 0)
										{
											continue;
										}
										break;
									}
									num3 = 4;
									continue;
								}
								goto IL_00ab;
							case 15:
								break;
								IL_00ab:
								result2 = awaiter.GetResult();
								if (rfiP1S5DtQosr1EdhGhu(result2))
								{
									goto default;
								}
								list = CvsParse.FindAllArgs(result2).ToList();
								num3 = 2;
								continue;
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
					goto case 4;
				default:
					num = 4;
					continue;
				case 5:
					formatInputData = _003C_003E4__this;
					goto case 2;
				case 0:
				case 1:
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_02ca;
			IL_02ca:
			num2 = _003C_003E1__state;
			num = 5;
			if (1 == 0)
			{
				return;
			}
			goto IL_0286;
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
		internal static object itb1Dp5DuEOXVv34NDpD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Up3fqK5DhNANnspj85qm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rfiP1S5DtQosr1EdhGhu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.IsNullOrEmpty((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int g5P8gZ5Dzj4paSN8w6qn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((List<string>)P_0).Count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VfV0Qf5iLDDUuZYW1XTx(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Split((char[])P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool I3Puyt5DcMbTuncLq7Rp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool h0nq8t5D1KRnIFpILtBZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<string, string, string> _003C_003E9__21_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oLtGI85iwiWPw9WZ8GjO();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oLtGI85iwiWPw9WZ8GjO();
			p8JGOM5iJh591t8UfL5I(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CSetFormats_003Eb__21_0(string agg, string fmt)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)LuCxbo5ieVdW5RLFX1RE(agg, FXqxUn5iamatE9eb4Amt(1884), fmt);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void oLtGI85iwiWPw9WZ8GjO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool I0fsgh5iKL7UnrQOMwuf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QLShPH5i5oh9EnZ0uY5K()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void p8JGOM5iJh591t8UfL5I(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FXqxUn5iamatE9eb4Amt(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LuCxbo5ieVdW5RLFX1RE(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1 + (string)P_2;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSetFormats_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public List<string> formats;

		public FormatInputData _003C_003E4__this;

		public bool runSheet;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			TaskAwaiter<object> awaiter2 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter = default;
			FormatInputData formatInputData = default;
			string expression = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = 7;
							break;
						case 0:
							awaiter2 = _003C_003Eu__1;
							num3 = 13;
							break;
						case 1:
							awaiter = _003C_003Eu__2;
							num3 = 2;
							break;
						}
						while (true)
						{
							string text;
							string text2;
							switch (num3)
							{
							case 15:
								return;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 15;
								continue;
							case 12:
								text = string.Empty;
								goto IL_00ba;
							case 5:
								awaiter2 = ((CvsCogSocketSheet)LaDjr55ifFZ5AMpB3p5P(kcxRTE5iV6UyRJ2tJygo(formatInputData.InSight))).PutCellExpressionAsync(formatInputData.rnFqea0GmU(), expression).GetAwaiter();
								num3 = 1;
								if (!useq2w5iIw7dFJCSgnQ0())
								{
									continue;
								}
								goto case 16;
							case 16:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 9:
								awaiter2.GetResult();
								if (runSheet)
								{
									awaiter = ((CvsCogSocketSheet)LaDjr55ifFZ5AMpB3p5P(kcxRTE5iV6UyRJ2tJygo(formatInputData.InSight))).RunAsync(true).GetAwaiter();
									num3 = 8;
									continue;
								}
								goto end_IL_01b9;
							case 8:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 6;
							case 6:
							case 11:
								num2 = (_003C_003E1__state = 1);
								num3 = 17;
								if (useq2w5iIw7dFJCSgnQ0())
								{
								}
								continue;
							case 13:
								_003C_003Eu__1 = default;
								goto case 16;
							default:
								num3 = 16;
								if (VYm7vP5iO49pS59sXyvK())
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Eu__2 = default;
								num3 = 14;
								continue;
							case 7:
								if (oOobYf5iDt0sRbR66MER(formats) > 0)
								{
									text = formats.Aggregate([MethodImpl(MethodImplOptions.NoInlining)] (string agg, string fmt) =>
									{
										while (false)
										{
											_ = ((object[])null)[0];
										}
										return (string)_003C_003Ec.LuCxbo5ieVdW5RLFX1RE(agg, _003C_003Ec.FXqxUn5iamatE9eb4Amt(1884), fmt);
									});
									goto IL_00ba;
								}
								num3 = 12;
								continue;
							case 1:
								if (!awaiter2.IsCompleted)
								{
									_ = 1;
									num3 = ((!useq2w5iIw7dFJCSgnQ0()) ? 3 : 6);
									continue;
								}
								goto case 9;
							case 3:
							case 4:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								num3 = 10;
								continue;
							case 14:
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
								continue;
							case 17:
								_003C_003Eu__2 = awaiter;
								num3 = 0;
								continue;
							case 18:
								break;
								IL_00ba:
								text2 = text;
								expression = (string)HkIcEP5inxj9F8nXG0QD(Qi0CRG5iiRW1lLNOX2ae(52464), text2, Qi0CRG5iiRW1lLNOX2ae(52506));
								num3 = 5;
								if (0 == 0)
								{
									continue;
								}
								goto case 5;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_01b9:
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
					break;
				case 5:
					num2 = _003C_003E1__state;
					num = 0;
					continue;
				case 0:
					formatInputData = _003C_003E4__this;
					VYm7vP5iO49pS59sXyvK();
					if (useq2w5iIw7dFJCSgnQ0())
					{
						num = 4;
						if (0 == 0)
						{
							continue;
						}
						goto case 5;
					}
					num = 1;
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
		internal static int oOobYf5iDt0sRbR66MER(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((List<string>)P_0).Count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Qi0CRG5iiRW1lLNOX2ae(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HkIcEP5inxj9F8nXG0QD(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1 + (string)P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kcxRTE5iV6UyRJ2tJygo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LaDjr55ifFZ5AMpB3p5P(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VYm7vP5iO49pS59sXyvK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool useq2w5iIw7dFJCSgnQ0()
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
	private struct _003CParseTable_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FormatInputData _003C_003E4__this;

		private List<string> _003Cformats_003E5__2;

		private TaskAwaiter<List<string>> _003C_003Eu__1;

		private IDisposable _003C_003E7__wrap2;

		private int _003Ccol_003E5__4;

		private int _003Crow_003E5__5;

		private CvsCellLocation _003CinputBufferCellLoc_003E5__6;

		private TaskAwaiter<string> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!rx2Hdm5ideZ4WhNCu8LS()) ? 3 : 2);
			FormatInputData formatInputData = default;
			int num2 = default;
			TaskAwaiter<string> awaiter2 = default;
			string result = default;
			CvsCellLocation cvsCellLocation = default;
			CellViewModel cellViewModel = default;
			string text = default;
			DataElement item = default;
			int num4 = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					_003Cformats_003E5__2 = null;
					num = 4;
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 3:
					formatInputData = _003C_003E4__this;
					num = 5;
					break;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 7;
					break;
				case 5:
					try
					{
						TaskAwaiter<List<string>> awaiter;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0111;
						}
						if (num2 == 1)
						{
							goto IL_0132;
						}
						if (formatInputData.PAyqBddu0t.IsValid && !formatInputData.PAyqBddu0t.IsEmpty && formatInputData.rnFqea0GmU().IsValid)
						{
							awaiter = formatInputData.TyXqMIHTu4().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0111;
						}
						goto end_IL_0072;
						IL_0132:
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
								_003C_003Eu__2 = default;
								num3 = 3;
							}
							while (true)
							{
								switch (num3)
								{
								case 0:
									_003Ccol_003E5__4 = 0;
									num3 = 16;
									continue;
								case 21:
									_003Ccol_003E5__4 += 2;
									num3 = 24;
									if (true)
									{
										continue;
									}
									goto case 7;
								case 7:
									if (!I57RmH5irBruRMoQFY5b(result))
									{
										if (s9Z5de5iZPLejkWPFJXa(result, IN7Mb75iPZrT4054SumK(1838)))
										{
											num3 = 17;
											continue;
										}
										cvsCellLocation = YnVCjj5iBfGmWiSUBM3T(result);
										goto case 14;
									}
									goto end_IL_03d0;
								case 1:
									_003C_003Eu__2 = awaiter2;
									num3 = 4;
									continue;
								case 2:
									cellViewModel.IsBoundExternally = true;
									num3 = 9;
									continue;
								case 22:
									uj4PrZ5iGVrJlII0tLYk(FormatDataBase.Logger, text);
									num3 = 23;
									continue;
								case 23:
									goto end_IL_03d0;
								case 4:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 6;
									if (fO6rqV5ilIs6M2toRb4J())
									{
									}
									continue;
								case 8:
								case 13:
									if (cellViewModel != null)
									{
										item = new DataElement(cellViewModel, _003Cformats_003E5__2[T9uoXu5ion5kOULqaLSU(formatInputData.Elements)]);
										num3 = 2;
									}
									else
									{
										text = (string)OmvhnD5ibyOOZA7mYR4U(CdQUGaROfy7He9T0foW.KbIzwHEDLa(52660), cvsCellLocation);
										num3 = 22;
									}
									continue;
								case 14:
									if (!cvsCellLocation.IsValid)
									{
										string message = string.Format((string)IN7Mb75iPZrT4054SumK(52514), result, _003CinputBufferCellLoc_003E5__6);
										FormatDataBase.Logger.Warn(message);
										num3 = 18;
										if (0 == 0)
										{
											continue;
										}
										goto case 12;
									}
									cellViewModel = formatInputData.FindCellVm(cvsCellLocation);
									_ = 1;
									if (fO6rqV5ilIs6M2toRb4J())
									{
										num3 = 5;
										if (0 == 0)
										{
											continue;
										}
										goto case 3;
									}
									num3 = 8;
									continue;
								case 12:
									_003CinputBufferCellLoc_003E5__6 = default;
									goto case 5;
								case 3:
									num2 = (_003C_003E1__state = -1);
									goto IL_030a;
								case 18:
									goto end_IL_03d0;
								case 20:
									_003Crow_003E5__5 = num4 + 1;
									goto case 10;
								case 10:
									if (_003Crow_003E5__5 < formatInputData.PAyqBddu0t.Rows)
									{
										_003CinputBufferCellLoc_003E5__6 = new CvsCellLocation(formatInputData.PAyqBddu0t.Row + _003Crow_003E5__5, formatInputData.PAyqBddu0t.Column + _003Ccol_003E5__4);
										num3 = 11;
										continue;
									}
									num3 = 21;
									if (0 == 0)
									{
										continue;
									}
									goto case 15;
								case 15:
									if (!awaiter2.IsCompleted)
									{
										num2 = (_003C_003E1__state = 1);
										num3 = 1;
										continue;
									}
									goto IL_030a;
								case 6:
									return;
								case 17:
									goto end_IL_03d0;
								default:
									num3 = 14;
									if (rx2Hdm5ideZ4WhNCu8LS())
									{
										continue;
									}
									goto case 9;
								case 9:
									formatInputData.Elements.Add(item);
									num3 = 12;
									continue;
								case 5:
								case 19:
									num4 = _003Crow_003E5__5;
									num3 = 20;
									if (!fO6rqV5ilIs6M2toRb4J())
									{
										continue;
									}
									goto case 11;
								case 11:
									awaiter2 = ((CvsCogSocketSheet)wOCuGf5iv7UwTgpO3VDd(qTOkOX5isdEeXBZil2QH(formatInputData.InSight))).GetCellExpressionAsync(_003CinputBufferCellLoc_003E5__6).GetAwaiter();
									num3 = 15;
									if (!fO6rqV5ilIs6M2toRb4J())
									{
										continue;
									}
									break;
								case 16:
								case 24:
									break;
									IL_030a:
									result = awaiter2.GetResult();
									num3 = 7;
									continue;
								}
								if (_003Ccol_003E5__4 < formatInputData.PAyqBddu0t.Columns)
								{
									_003Crow_003E5__5 = 0;
									num3 = 10;
									continue;
								}
								goto IL_04e3;
								continue;
								end_IL_03d0:
								break;
							}
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap2 != null)
							{
								B3IX0H5iSDc6Nbw3EBlY(_003C_003E7__wrap2);
							}
						}
						goto end_IL_0072;
						IL_0111:
						List<string> result2 = awaiter.GetResult();
						_003Cformats_003E5__2 = result2;
						_003C_003E7__wrap2 = (IDisposable)o5B2G55igp2wQTNFS0E5(formatInputData._suspendElementsEvents);
						goto IL_0132;
						IL_04e3:
						_003C_003E7__wrap2 = null;
						end_IL_0072:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cformats_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 6;
				default:
					num = 6;
					break;
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
		internal static object o5B2G55igp2wQTNFS0E5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ScopedCounter)P_0).Increment();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qTOkOX5isdEeXBZil2QH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wOCuGf5iv7UwTgpO3VDd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool I57RmH5irBruRMoQFY5b(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.IsNullOrEmpty((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IN7Mb75iPZrT4054SumK(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool s9Z5de5iZPLejkWPFJXa(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation YnVCjj5iBfGmWiSUBM3T(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCellLocation.TryParse((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OmvhnD5ibyOOZA7mYR4U(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void uj4PrZ5iGVrJlII0tLYk(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).Warn((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int T9uoXu5ion5kOULqaLSU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Collection<DataElement>)P_0).Count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void B3IX0H5iSDc6Nbw3EBlY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rx2Hdm5ideZ4WhNCu8LS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fO6rqV5ilIs6M2toRb4J()
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
	private struct _003CAddInputRef_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DataElement element;

		public FormatInputData _003C_003E4__this;

		private CvsCellLocation _003CinputBufGetValCell_003E5__2;

		private CvsCellLocation _003CcacheSnippetCell_003E5__3;

		private CvsCellLocation _003CrefSnippetCell_003E5__4;

		private TaskAwaiter<List<string>> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<object> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			vBGeln5ikPWbRIv5t31e();
			int num = (WA55vi5i8SteuFTdihWy() ? 5 : 2);
			int num2 = default;
			TaskAwaiter<List<string>> awaiter3 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<object> awaiter2 = default;
			(CvsCellLocation, CvsCellLocation) tuple = default;
			FormatInputData formatInputData = default;
			List<string> result = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 4:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							Ly38Ia5iE7nU6Yi08P5M(xvwpZM5iqP1Ap1OhbSVo(element), true);
							num3 = 14;
							if (WA55vi5i8SteuFTdihWy())
							{
								return;
							}
							goto IL_01b5;
						case 0:
							awaiter3 = _003C_003Eu__1;
							num3 = 29;
							goto IL_01b5;
						case 4:
							awaiter = _003C_003Eu__2;
							num3 = 10;
							goto IL_01b5;
						case 3:
							awaiter = _003C_003Eu__2;
							num3 = 1;
							if (false)
							{
								goto IL_015c;
							}
							goto IL_01b5;
						case 2:
							awaiter2 = _003C_003Eu__3;
							num3 = 18;
							if (vBGeln5ikPWbRIv5t31e())
							{
								goto IL_01b5;
							}
							goto IL_0355;
						case 1:
							{
								awaiter = _003C_003Eu__2;
								num3 = 36;
								goto IL_01b5;
							}
							IL_01b5:
							while (true)
							{
								switch (num3)
								{
								case 16:
									return;
								case 1:
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 20;
									continue;
								case 18:
									_003C_003Eu__3 = default;
									num3 = 6;
									continue;
								case 36:
									_003C_003Eu__2 = default;
									num3 = 12;
									if (true)
									{
										continue;
									}
									goto case 11;
								case 11:
									_003C_003Eu__2 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 8:
									if (!awaiter.IsCompleted)
									{
										num3 = 15;
										continue;
									}
									goto case 4;
								case 14:
									tuple = formatInputData.M9EqyR4lXS(evgqFK5iph5nZZ4HnYf2(formatInputData.Elements) - 1);
									num3 = 5;
									if (vBGeln5ikPWbRIv5t31e())
									{
										continue;
									}
									return;
								case 35:
									return;
								case 15:
									break;
								case 21:
									awaiter = EFrO9r5i4D4kdDxkcnQF(formatInputData.fLbqRaenIC(result));
									num3 = 8;
									if (0 == 0)
									{
										continue;
									}
									goto case 30;
								case 30:
									_003C_003Eu__3 = awaiter2;
									num3 = 27;
									continue;
								case 4:
									awaiter.GetResult();
									goto case 33;
								default:
									num3 = 33;
									continue;
								case 17:
									awaiter = EFrO9r5i4D4kdDxkcnQF(formatInputData.kevqOQgVqG(_003CrefSnippetCell_003E5__4, _003CcacheSnippetCell_003E5__3));
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 3);
										num3 = 24;
										continue;
									}
									goto case 20;
								case 20:
									awaiter.GetResult();
									awaiter = EFrO9r5i4D4kdDxkcnQF(formatInputData.Fecqw3oSBj(_003CrefSnippetCell_003E5__4, evgqFK5iph5nZZ4HnYf2(formatInputData.Elements) - 1));
									if (!awaiter.IsCompleted)
									{
										num3 = 9;
										continue;
									}
									goto case 37;
								case 0:
								case 13:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 22;
									continue;
								case 3:
								case 28:
									num2 = (_003C_003E1__state = 0);
									num3 = 31;
									if (true)
									{
										continue;
									}
									goto case 23;
								case 23:
									num2 = (_003C_003E1__state = -1);
									num3 = 37;
									continue;
								case 9:
									num2 = (_003C_003E1__state = 4);
									num3 = 11;
									if (!WA55vi5i8SteuFTdihWy())
									{
										continue;
									}
									goto case 27;
								case 27:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								case 2:
									goto IL_0355;
								case 29:
									goto IL_036b;
								case 31:
									_003C_003Eu__1 = awaiter3;
									num3 = 25;
									if (!WA55vi5i8SteuFTdihWy())
									{
										continue;
									}
									return;
								case 22:
									return;
								case 24:
									_003C_003Eu__2 = awaiter;
									num3 = 19;
									continue;
								case 6:
									goto IL_03d3;
								case 5:
									goto IL_03f0;
								case 7:
									goto IL_0437;
								case 12:
									num2 = (_003C_003E1__state = -1);
									num3 = 4;
									continue;
								case 34:
									num2 = (_003C_003E1__state = 2);
									num3 = 30;
									continue;
								case 10:
									_003C_003Eu__2 = default;
									num3 = 23;
									if (WA55vi5i8SteuFTdihWy())
									{
									}
									continue;
								case 33:
									awaiter2 = ((CvsCogSocketSheet)BJC8vr5i7fyc7WgJLtqy(formatInputData.InSight.CogSocket)).PutCellExpressionAsync(_003CinputBufGetValCell_003E5__2, _003CrefSnippetCell_003E5__4.ToString()).GetAwaiter();
									num3 = 2;
									continue;
								case 26:
									result.Add(((FormatElementViewModel)TWZeo25i9VdhKuQ3xQ9w(element)).Format);
									num3 = 21;
									continue;
								case 25:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num3 = 16;
									continue;
								case 19:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 35;
									if (vBGeln5ikPWbRIv5t31e())
									{
										continue;
									}
									goto case 32;
								case 32:
									_003C_003Eu__2 = awaiter;
									goto case 0;
								case 37:
									awaiter.GetResult();
									goto end_IL_003e;
								}
								break;
							}
							goto IL_015c;
							IL_03d3:
							num2 = (_003C_003E1__state = -1);
							goto IL_03dc;
							IL_036b:
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0380;
							IL_0355:
							if (!awaiter2.IsCompleted)
							{
								num3 = 34;
								goto IL_01b5;
							}
							goto IL_03dc;
							IL_0380:
							result = awaiter3.GetResult();
							num3 = 26;
							goto IL_01b5;
							IL_03dc:
							awaiter2.GetResult();
							num3 = 17;
							if (0 == 0)
							{
								goto IL_01b5;
							}
							goto IL_03f0;
							IL_03f0:
							_003CinputBufGetValCell_003E5__2 = tuple.Item1;
							_003CcacheSnippetCell_003E5__3 = tuple.Item2;
							_003CrefSnippetCell_003E5__4 = robXNR5iXee5VTQoQ9Ax(xvwpZM5iqP1Ap1OhbSVo(element));
							awaiter3 = formatInputData.TyXqMIHTu4().GetAwaiter();
							num3 = 7;
							if (0 == 0)
							{
								goto IL_01b5;
							}
							goto IL_0437;
							IL_0437:
							if (!awaiter3.IsCompleted)
							{
								_ = 0;
								num3 = (vBGeln5ikPWbRIv5t31e() ? 28 : 0);
								goto IL_01b5;
							}
							goto IL_0380;
							IL_015c:
							num2 = (_003C_003E1__state = 1);
							num3 = 32;
							goto IL_01b5;
							end_IL_003e:
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
				case 1:
					formatInputData = _003C_003E4__this;
					num = 4;
					if (WA55vi5i8SteuFTdihWy())
					{
					}
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 1;
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
		internal static object xvwpZM5iqP1Ap1OhbSVo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DataElement)P_0).Cell;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Ly38Ia5iE7nU6Yi08P5M(object P_0, bool value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CellViewModel)P_0).IsBoundExternally = value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int evgqFK5iph5nZZ4HnYf2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Collection<DataElement>)P_0).Count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation robXNR5iXee5VTQoQ9Ax(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TWZeo25i9VdhKuQ3xQ9w(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DataElement)P_0).DataType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter EFrO9r5i4D4kdDxkcnQF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BJC8vr5i7fyc7WgJLtqy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vBGeln5ikPWbRIv5t31e()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WA55vi5i8SteuFTdihWy()
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
	private struct _003CMoveInputRef_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FormatInputData _003C_003E4__this;

		public int oldIndex;

		public int newIndex;

		public DataElement element;

		private CvsCellLocation _003ColdGetValueCellLoc_003E5__2;

		private CvsCellLocation _003ColdCacheCellLoc_003E5__3;

		private CvsCellLocation _003CnewGetValueCellLoc_003E5__4;

		private CvsCellLocation _003CnewCacheCellLoc_003E5__5;

		private CvsCellLocation _003ColdRefSnippetCellLoc_003E5__6;

		private CvsCellLocation _003CnewRefSnippetCellLoc_003E5__7;

		private CvsCellRange _003ColdCacheCellRange_003E5__8;

		private CvsCellRange _003CnewCacheCellRange_003E5__9;

		private byte[] _003ColdCachedCellData_003E5__10;

		private TaskAwaiter<List<string>> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<string> _003C_003Eu__3;

		private TaskAwaiter<object> _003C_003Eu__4;

		private TaskAwaiter<byte[]> _003C_003Eu__5;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			int num2 = default;
			TaskAwaiter<List<string>> awaiter3 = default;
			FormatInputData formatInputData = default;
			TaskAwaiter<byte[]> awaiter5 = default;
			TaskAwaiter awaiter4 = default;
			TaskAwaiter<string> awaiter2 = default;
			TaskAwaiter<object> awaiter = default;
			byte[] result3 = default;
			List<string> result = default;
			byte[] result4 = default;
			string result2 = default;
			(CvsCellLocation, CvsCellLocation) tuple = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					num2 = _003C_003E1__state;
					num = 0;
					continue;
				case 3:
				case 5:
					_003ColdCachedCellData_003E5__10 = null;
					break;
				case 1:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							awaiter3 = formatInputData.TyXqMIHTu4().GetAwaiter();
							num3 = 21;
							goto IL_08ee;
						case 7:
							awaiter5 = _003C_003Eu__5;
							num3 = 67;
							goto IL_08ee;
						case 8:
							awaiter4 = _003C_003Eu__2;
							num3 = 12;
							goto IL_08ee;
						case 9:
							awaiter4 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num3 = 49;
							if (false)
							{
								goto IL_03ef;
							}
							goto IL_08ee;
						case 11:
							awaiter4 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num3 = 54;
							goto IL_08ee;
						case 1:
							awaiter4 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num3 = 65;
							goto IL_08ee;
						case 6:
							awaiter5 = _003C_003Eu__5;
							_003C_003Eu__5 = default;
							num3 = 75;
							goto IL_08ee;
						case 10:
							awaiter4 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num3 = 13;
							goto IL_08ee;
						case 3:
							awaiter2 = _003C_003Eu__3;
							_003C_003Eu__3 = default;
							num3 = 43;
							goto IL_08ee;
						case 5:
							awaiter = _003C_003Eu__4;
							num3 = 31;
							goto IL_08ee;
						case 0:
							awaiter3 = _003C_003Eu__1;
							num3 = 78;
							goto IL_08ee;
						case 2:
							awaiter2 = _003C_003Eu__3;
							_003C_003Eu__3 = default;
							num3 = 50;
							goto IL_08ee;
						case 4:
							{
								awaiter = _003C_003Eu__4;
								num3 = 33;
								goto IL_08ee;
							}
							IL_08ee:
							while (true)
							{
								switch (num3)
								{
								case 23:
									num2 = (_003C_003E1__state = -1);
									num3 = 34;
									continue;
								case 27:
									awaiter4.GetResult();
									awaiter4 = zm712d5iAhKkH64BJs8S(formatInputData.Fecqw3oSBj(_003ColdRefSnippetCellLoc_003E5__6, newIndex));
									num3 = 36;
									continue;
								case 0:
									if (!awaiter2.IsCompleted)
									{
										num3 = 5;
										continue;
									}
									goto case 73;
								case 68:
									num2 = (_003C_003E1__state = -1);
									num3 = 47;
									continue;
								case 39:
									_003ColdCachedCellData_003E5__10 = result3;
									num3 = 25;
									continue;
								case 8:
									_003C_003Eu__3 = awaiter2;
									num3 = 66;
									continue;
								case 17:
									awaiter4 = zm712d5iAhKkH64BJs8S(formatInputData.fLbqRaenIC(result));
									num3 = 71;
									if (0 == 0)
									{
										continue;
									}
									goto case 35;
								case 35:
									num2 = (_003C_003E1__state = 11);
									num3 = 20;
									continue;
								case 81:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
									num3 = 19;
									continue;
								case 69:
									awaiter4 = ((Task)QtPQn35iyBW2DJLcgKSg(AbrFla5iRxjNyD98o4qQ(nYTaw95iTw47S7G5sOw6(formatInputData.InSight)), _003CnewCacheCellRange_003E5__9, _003ColdCachedCellData_003E5__10, false, false)).GetAwaiter();
									num3 = 53;
									if (true)
									{
										continue;
									}
									goto case 9;
								case 9:
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter3;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num3 = 15;
									continue;
								case 74:
									num2 = (_003C_003E1__state = 6);
									num3 = 72;
									continue;
								case 5:
									num2 = (_003C_003E1__state = 3);
									num3 = 8;
									continue;
								case 44:
									_003C_003Eu__5 = awaiter5;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
									return;
								case 59:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
									num3 = 38;
									continue;
								case 49:
									num2 = (_003C_003E1__state = -1);
									num3 = 27;
									continue;
								case 3:
									num2 = (_003C_003E1__state = 5);
									_ = 1;
									num3 = (KbqZGG5ijoPA3ZE4wfEG() ? 30 : 6);
									continue;
								case 57:
									awaiter4 = zm712d5iAhKkH64BJs8S(QtPQn35iyBW2DJLcgKSg(AbrFla5iRxjNyD98o4qQ(formatInputData.InSight.CogSocket), _003ColdCacheCellRange_003E5__8, result4, false, false));
									if (!awaiter4.IsCompleted)
									{
										num3 = 11;
										continue;
									}
									goto case 52;
								case 10:
									_003CnewCacheCellRange_003E5__9 = new CvsCellRange(_003CnewCacheCellLoc_003E5__5);
									awaiter5 = ((CvsCogSocket)nYTaw95iTw47S7G5sOw6(formatInputData.InSight)).Sheet.CopyCellsAsync(_003ColdCacheCellRange_003E5__8).GetAwaiter();
									if (!awaiter5.IsCompleted)
									{
										num3 = 74;
										if (0 == 0)
										{
											continue;
										}
										return;
									}
									goto IL_0891;
								case 37:
									return;
								case 25:
									awaiter5 = ((CvsCogSocketSheet)AbrFla5iRxjNyD98o4qQ(nYTaw95iTw47S7G5sOw6(formatInputData.InSight))).CopyCellsAsync(_003CnewCacheCellRange_003E5__9).GetAwaiter();
									num3 = 28;
									continue;
								case 83:
									_003C_003Eu__2 = awaiter4;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
									num3 = 22;
									continue;
								case 79:
									awaiter.GetResult();
									num3 = 29;
									continue;
								case 62:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
									num3 = 37;
									if (0 == 0)
									{
										continue;
									}
									goto case 34;
								case 34:
									result = awaiter3.GetResult();
									result[oldIndex] = result[newIndex];
									result[newIndex] = (string)TKujiu5iCNhkeMqCK8Va(c8VxkR5i6vFQRASh1rEY(element));
									num3 = 17;
									continue;
								case 48:
									_003C_003Eu__3 = awaiter2;
									num3 = 2;
									continue;
								case 64:
									return;
								case 40:
									break;
								case 30:
								case 80:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
									return;
								case 51:
									awaiter2 = ((CvsCogSocketSheet)AbrFla5iRxjNyD98o4qQ(nYTaw95iTw47S7G5sOw6(formatInputData.InSight))).GetCellExpressionAsync(_003CnewGetValueCellLoc_003E5__4).GetAwaiter();
									num3 = 0;
									continue;
								case 67:
									_003C_003Eu__5 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_0475;
								case 4:
									_003ColdRefSnippetCellLoc_003E5__6 = k7DC5D5iW0cuFae170Cv(result2);
									num3 = 51;
									continue;
								case 31:
									_003C_003Eu__4 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 79;
									continue;
								case 78:
									_003C_003Eu__1 = default;
									num3 = 23;
									continue;
								case 61:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 4);
										_003C_003Eu__4 = awaiter;
										num3 = 55;
										if (!KbqZGG5ijoPA3ZE4wfEG())
										{
											continue;
										}
										goto case 12;
									}
									goto case 47;
								case 12:
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 52;
									if (!KbqZGG5ijoPA3ZE4wfEG())
									{
										continue;
									}
									goto case 28;
								case 28:
									if (!awaiter5.IsCompleted)
									{
										num2 = (_003C_003E1__state = 7);
										num3 = 44;
										continue;
									}
									goto IL_0475;
								case 33:
									_003C_003Eu__4 = default;
									num3 = 68;
									continue;
								case 21:
									if (!awaiter3.IsCompleted)
									{
										num3 = 9;
										continue;
									}
									goto case 34;
								case 63:
									awaiter = ((CvsCogSocketSheet)AbrFla5iRxjNyD98o4qQ(nYTaw95iTw47S7G5sOw6(formatInputData.InSight))).PutCellExpressionAsync(_003ColdGetValueCellLoc_003E5__2, _003CnewRefSnippetCellLoc_003E5__7.ToString()).GetAwaiter();
									num3 = 61;
									continue;
								case 20:
									_003C_003Eu__2 = awaiter4;
									goto case 30;
								case 26:
									if (!awaiter2.IsCompleted)
									{
										num3 = 1;
										continue;
									}
									goto case 58;
								case 50:
									num2 = (_003C_003E1__state = -1);
									num3 = 58;
									continue;
								case 46:
									awaiter4.GetResult();
									num3 = 60;
									continue;
								case 6:
								case 42:
									_003C_003Eu__4 = awaiter;
									num3 = 24;
									if (0 == 0)
									{
										continue;
									}
									goto case 77;
								case 77:
									num2 = (_003C_003E1__state = 1);
									num3 = 7;
									continue;
								case 72:
									_003C_003Eu__5 = awaiter5;
									num3 = 81;
									continue;
								case 38:
									return;
								case 19:
									return;
								case 73:
								{
									string result5 = awaiter2.GetResult();
									_003CnewRefSnippetCellLoc_003E5__7 = k7DC5D5iW0cuFae170Cv(result5);
									num3 = 63;
									continue;
								}
								case 65:
									num2 = (_003C_003E1__state = -1);
									num3 = 46;
									continue;
								case 22:
									return;
								case 54:
									num2 = (_003C_003E1__state = -1);
									num3 = 84;
									continue;
								case 24:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 56;
									continue;
								case 70:
									return;
								case 71:
									if (!awaiter4.IsCompleted)
									{
										num3 = 77;
										continue;
									}
									goto case 46;
								case 55:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 45;
									continue;
								case 56:
									return;
								case 52:
									awaiter4.GetResult();
									num3 = 69;
									continue;
								case 60:
									tuple = formatInputData.M9EqyR4lXS(oldIndex);
									_003ColdGetValueCellLoc_003E5__2 = tuple.Item1;
									_003ColdCacheCellLoc_003E5__3 = tuple.Item2;
									tuple = formatInputData.M9EqyR4lXS(newIndex);
									_003CnewGetValueCellLoc_003E5__4 = tuple.Item1;
									num3 = 76;
									if (KbqZGG5ijoPA3ZE4wfEG())
									{
									}
									continue;
								case 1:
									num2 = (_003C_003E1__state = 2);
									num3 = 48;
									continue;
								case 18:
									if (!awaiter4.IsCompleted)
									{
										num3 = 35;
										continue;
									}
									goto case 84;
								case 14:
									awaiter2 = ((CvsCogSocketSheet)AbrFla5iRxjNyD98o4qQ(formatInputData.InSight.CogSocket)).GetCellExpressionAsync(_003ColdGetValueCellLoc_003E5__2).GetAwaiter();
									num3 = 26;
									continue;
								case 11:
									num2 = (_003C_003E1__state = 8);
									_003C_003Eu__2 = awaiter4;
									num3 = 62;
									continue;
								case 76:
									_003CnewCacheCellLoc_003E5__5 = tuple.Item2;
									num3 = 14;
									continue;
								case 15:
									return;
								case 13:
									num2 = (_003C_003E1__state = -1);
									num3 = 32;
									if (0 == 0)
									{
										continue;
									}
									goto case 75;
								case 75:
									num2 = (_003C_003E1__state = -1);
									goto IL_0891;
								case 32:
									awaiter4.GetResult();
									awaiter4 = zm712d5iAhKkH64BJs8S(formatInputData.Fecqw3oSBj(_003CnewRefSnippetCellLoc_003E5__7, oldIndex));
									num3 = 18;
									if (true)
									{
										continue;
									}
									goto case 41;
								case 41:
									if (!awaiter.IsCompleted)
									{
										goto case 3;
									}
									goto case 79;
								default:
									num3 = 3;
									continue;
								case 66:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 70;
									if (IbP0ZB5i37QSY3fpCJ5X())
									{
										continue;
									}
									goto case 2;
								case 2:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 16;
									continue;
								case 43:
									num2 = (_003C_003E1__state = -1);
									num3 = 73;
									continue;
								case 7:
									_003C_003Eu__2 = awaiter4;
									num3 = 59;
									if (0 == 0)
									{
										continue;
									}
									goto case 53;
								case 53:
									if (!awaiter4.IsCompleted)
									{
										num3 = 40;
										if (KbqZGG5ijoPA3ZE4wfEG())
										{
										}
										continue;
									}
									goto case 27;
								case 47:
									awaiter.GetResult();
									awaiter = ((CvsCogSocketSheet)AbrFla5iRxjNyD98o4qQ(nYTaw95iTw47S7G5sOw6(formatInputData.InSight))).PutCellExpressionAsync(_003CnewGetValueCellLoc_003E5__4, _003ColdRefSnippetCellLoc_003E5__6.ToString()).GetAwaiter();
									num3 = 41;
									if (true)
									{
										continue;
									}
									goto case 29;
								case 29:
									_003ColdCacheCellRange_003E5__8 = new CvsCellRange(_003ColdCacheCellLoc_003E5__3);
									num3 = 10;
									continue;
								case 58:
									result2 = awaiter2.GetResult();
									num3 = 4;
									continue;
								case 36:
									if (!awaiter4.IsCompleted)
									{
										num2 = (_003C_003E1__state = 10);
										num3 = 83;
										if (IbP0ZB5i37QSY3fpCJ5X())
										{
											continue;
										}
										return;
									}
									goto case 32;
								case 16:
									return;
								case 82:
									_003C_003Eu__2 = awaiter4;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
									num3 = 64;
									continue;
								case 45:
									return;
								case 84:
									{
										awaiter4.GetResult();
										goto end_IL_08ee;
									}
									IL_0475:
									result4 = awaiter5.GetResult();
									num3 = 57;
									if (!KbqZGG5ijoPA3ZE4wfEG())
									{
										continue;
									}
									goto case 4;
									IL_0891:
									result3 = awaiter5.GetResult();
									num3 = 39;
									continue;
								}
								goto IL_03ef;
								continue;
								end_IL_08ee:
								break;
							}
							break;
							IL_03ef:
							num2 = (_003C_003E1__state = 9);
							num3 = 82;
							goto IL_08ee;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003ColdCachedCellData_003E5__10 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				default:
					IbP0ZB5i37QSY3fpCJ5X();
					if (KbqZGG5ijoPA3ZE4wfEG())
					{
						num = 2;
						if (0 == 0)
						{
							continue;
						}
						goto case 1;
					}
					num = 5;
					if (!KbqZGG5ijoPA3ZE4wfEG())
					{
						continue;
					}
					goto case 0;
				case 0:
					formatInputData = _003C_003E4__this;
					num = 1;
					continue;
				case 2:
				case 4:
					break;
				case 7:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 7;
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
		internal static object c8VxkR5i6vFQRASh1rEY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DataElement)P_0).DataType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TKujiu5iCNhkeMqCK8Va(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FormatElementViewModel)P_0).Format;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter zm712d5iAhKkH64BJs8S(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AbrFla5iRxjNyD98o4qQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation k7DC5D5iW0cuFae170Cv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCellLocation.TryParse((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nYTaw95iTw47S7G5sOw6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QtPQn35iyBW2DJLcgKSg(object P_0, CvsCellRange P_1, object P_2, bool P_3, bool P_4)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).InternalPasteCellsAsync(P_1, (byte[])P_2, P_3, P_4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IbP0ZB5i37QSY3fpCJ5X()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KbqZGG5ijoPA3ZE4wfEG()
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
	private struct _003CUpdateSelectedElement_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FormatInputData _003C_003E4__this;

		private TaskAwaiter<List<string>> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<List<string>> awaiter2 = default;
			List<string> result = default;
			FormatInputData formatInputData = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__2;
								goto IL_017e;
							}
							num3 = 7;
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 1;
						}
						goto IL_0083;
						IL_0083:
						while (true)
						{
							switch (num3)
							{
							case 5:
							case 12:
								result = awaiter2.GetResult();
								num3 = 14;
								if (0 == 0)
								{
									continue;
								}
								goto case 15;
							case 15:
								_003C_003Eu__2 = awaiter;
								num3 = 2;
								continue;
							case 14:
								result[formatInputData.SelectedIndex] = (string)rfvNX05iYPc32UGnMQkM(Vwqjoa5iMPalCCXnOCfO(formatInputData.SelectedElement));
								goto case 4;
							default:
								num3 = 4;
								continue;
							case 11:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									if (!X34rta5iFHxR6j6RP5c8())
									{
										continue;
									}
									return;
								}
								goto case 16;
							case 10:
								return;
							case 4:
								awaiter = W4kclK5iUWpFCRYoPcWn(formatInputData.fLbqRaenIC(result, _0020: true));
								num3 = 11;
								continue;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 10;
								continue;
							case 7:
								awaiter2 = formatInputData.TyXqMIHTu4().GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 9;
									continue;
								}
								goto case 5;
							case 9:
								_003C_003Eu__1 = awaiter2;
								num3 = 0;
								continue;
							case 8:
							case 13:
								break;
							case 6:
								return;
							case 1:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								R1aRDs5i01aSblRFBNhy();
								if (X34rta5iFHxR6j6RP5c8())
								{
									num3 = 8;
									if (true)
									{
										continue;
									}
									goto case 4;
								}
								num3 = 12;
								continue;
							case 3:
								num2 = (_003C_003E1__state = 1);
								num3 = 15;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 6;
								continue;
							case 16:
								awaiter.GetResult();
								goto end_IL_0083;
							}
							goto IL_017e;
							continue;
							end_IL_0083:
							break;
						}
						goto end_IL_0018;
						IL_017e:
						_003C_003Eu__2 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						goto IL_0083;
						end_IL_0018:;
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
					num = 4;
					break;
				case 4:
					formatInputData = _003C_003E4__this;
					R1aRDs5i01aSblRFBNhy();
					if (X34rta5iFHxR6j6RP5c8())
					{
						num = 1;
						if (0 == 0)
						{
							break;
						}
						goto default;
					}
					num = 0;
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
		internal static object Vwqjoa5iMPalCCXnOCfO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DataElement)P_0).DataType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rfvNX05iYPc32UGnMQkM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FormatElementViewModel)P_0).Format;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter W4kclK5iUWpFCRYoPcWn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool R1aRDs5i01aSblRFBNhy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool X34rta5iFHxR6j6RP5c8()
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
	private struct _003CRemoveInputRef_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FormatInputData _003C_003E4__this;

		public DataElement removeElement;

		public int oldIndex;

		private IDisposable _003C_003E7__wrap1;

		private int _003ClastTableIndex_003E5__3;

		private CvsCellLocation _003CcacheCellLoc_003E5__4;

		private CvsCellLocation _003CsnippetCellLoc_003E5__5;

		private CvsCellLocation _003ClastCacheExprLoc_003E5__6;

		private TaskAwaiter<string> _003C_003Eu__1;

		private TaskAwaiter<List<string>> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private int _003Ci_003E5__7;

		private TaskAwaiter<object> _003C_003Eu__4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (cBELJM5iHB7XaLHw0lZp())
			{
				num = 4;
				if (owHGXu5ixX7aOA355K60())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_09cd;
			IL_0a20:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_09cd;
			IL_09cd:
			int num2 = default;
			FormatInputData formatInputData = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 3:
					break;
				default:
					num = 1;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 5:
					formatInputData = _003C_003E4__this;
					break;
				case 1:
					goto IL_0a20;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			try
			{
				if ((uint)num2 > 7u)
				{
					IDisposable disposable = null;
					if (WbsqVh5iNX4HIXTg4w7R(TbxCsQ5iQjIIeUSjCDr5(XScSY25imP8qwUdum4d9(formatInputData.AppStep))) == null)
					{
						disposable = (IDisposable)sxo8NP5iuRHaVp2X4J3R(TbxCsQ5iQjIIeUSjCDr5(XScSY25imP8qwUdum4d9(formatInputData.AppStep)), oCUYDL5i1JDmJVF5bhhF(X6Bu6J5i2hZlIBvdSJHp(), ((CellViewModel)ItePRN5icVGHKOSAQlt5(removeElement)).CellName), Array.Empty<StepDescriptor>());
					}
					_003C_003E7__wrap1 = disposable;
				}
				try
				{
					int num3;
					TaskAwaiter awaiter2 = default;
					TaskAwaiter<string> awaiter4 = default;
					TaskAwaiter<object> awaiter = default;
					TaskAwaiter<List<string>> awaiter3 = default;
					(CvsCellLocation, CvsCellLocation) tuple = default;
					CvsCellLocation item = default;
					string result2 = default;
					List<string> result = default;
					CvsCellLocation item2 = default;
					int num4 = default;
					switch (num2)
					{
					default:
						((CellViewModel)ItePRN5icVGHKOSAQlt5(removeElement)).IsBoundExternally = false;
						num3 = 36;
						if (!cBELJM5iHB7XaLHw0lZp())
						{
							goto IL_00d1;
						}
						goto IL_0497;
					case 3:
						awaiter2 = _003C_003Eu__3;
						_003C_003Eu__3 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_032e;
					case 4:
						awaiter2 = _003C_003Eu__3;
						num3 = 41;
						goto IL_0497;
					case 0:
						awaiter4 = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 62;
						if (cBELJM5iHB7XaLHw0lZp())
						{
							goto IL_0497;
						}
						goto IL_0616;
					case 5:
						awaiter = _003C_003Eu__4;
						num3 = 64;
						goto IL_0497;
					case 7:
						awaiter = _003C_003Eu__4;
						num3 = 25;
						goto IL_0497;
					case 1:
						awaiter3 = _003C_003Eu__2;
						num3 = 22;
						goto IL_0497;
					case 2:
						awaiter2 = _003C_003Eu__3;
						num3 = 44;
						goto IL_0497;
					case 6:
						{
							awaiter = _003C_003Eu__4;
							num3 = 1;
							goto IL_0497;
						}
						IL_0497:
						while (true)
						{
							switch (num3)
							{
							case 16:
								break;
							case 1:
								_003C_003Eu__4 = default;
								num3 = 0;
								continue;
							case 63:
								_003ClastCacheExprLoc_003E5__6 = tuple.Item2;
								num3 = 53;
								continue;
							case 14:
								awaiter = ((CvsCogSocket)On0GER5ih3UjTB2fkCpw(formatInputData.InSight)).Sheet.ClearCellsAsync(new CvsCellRange(_003ClastCacheExprLoc_003E5__6)).GetAwaiter();
								goto case 21;
							case 8:
								tuple = formatInputData.M9EqyR4lXS(oldIndex);
								num3 = 33;
								continue;
							case 31:
								awaiter.GetResult();
								goto case 46;
							case 46:
								_003CcacheCellLoc_003E5__4 = default;
								num3 = 27;
								continue;
							case 38:
								awaiter = ((CvsCogSocket)On0GER5ih3UjTB2fkCpw(formatInputData.InSight)).Sheet.PutCellExpressionAsync(item, (string)N4MnsC5n5cZMYHbJFJk3(1838)).GetAwaiter();
								num3 = 32;
								if (!owHGXu5ixX7aOA355K60())
								{
									continue;
								}
								goto case 10;
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
								num3 = 50;
								continue;
							case 54:
								_003C_003Eu__1 = awaiter4;
								num3 = 10;
								continue;
							case 36:
								_003ClastTableIndex_003E5__3 = formatInputData.Elements.Count;
								num3 = 8;
								continue;
							case 47:
								num2 = (_003C_003E1__state = -1);
								goto IL_0203;
							case 51:
								tuple = formatInputData.M9EqyR4lXS(_003ClastTableIndex_003E5__3);
								num3 = 20;
								if (true)
								{
									continue;
								}
								goto case 3;
							case 3:
							case 11:
								num2 = (_003C_003E1__state = 1);
								num3 = 7;
								continue;
							case 40:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 34;
								if (!owHGXu5ixX7aOA355K60())
								{
									continue;
								}
								goto case 23;
							case 23:
								num2 = (_003C_003E1__state = -1);
								num3 = 13;
								continue;
							case 20:
								item = tuple.Item1;
								num3 = 63;
								continue;
							case 58:
								if (!_003ClastCacheExprLoc_003E5__6.IsValid)
								{
									goto case 46;
								}
								awaiter = ((CvsCogSocketSheet)uloLtX5nwyvkQnqgsRlH(On0GER5ih3UjTB2fkCpw(formatInputData.InSight))).ClearCellsAsync(new CvsCellRange(item, _003ClastCacheExprLoc_003E5__6)).GetAwaiter();
								num3 = 29;
								if (cBELJM5iHB7XaLHw0lZp())
								{
									continue;
								}
								goto case 32;
							case 32:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 5);
									_003C_003Eu__4 = awaiter;
									num3 = 5;
									continue;
								}
								goto IL_0203;
							case 26:
								_003C_003Eu__3 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							case 37:
								goto IL_0341;
							case 9:
								_003CsnippetCellLoc_003E5__5 = IFxPaC5itd6Lx0slohXH(result2);
								awaiter3 = formatInputData.TyXqMIHTu4().GetAwaiter();
								num3 = 60;
								continue;
							case 45:
								_003C_003Eu__4 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 19;
								continue;
							case 52:
								oToTKE5izIwhsSNIg6fi(result, oldIndex);
								num3 = 59;
								continue;
							case 12:
								awaiter2 = ETDH4v5nL8LCpUhLlGy1(formatInputData.m7fqHag5Vk(_003CcacheCellLoc_003E5__4, _003CsnippetCellLoc_003E5__5));
								if (awaiter2.IsCompleted)
								{
									goto IL_032e;
								}
								num3 = 24;
								if (cBELJM5iHB7XaLHw0lZp())
								{
									continue;
								}
								goto case 33;
							case 33:
								item2 = tuple.Item1;
								num3 = 35;
								continue;
							case 29:
								if (!awaiter.IsCompleted)
								{
									num3 = 37;
									continue;
								}
								goto case 31;
							case 22:
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0421;
							case 61:
								if (_003Ci_003E5__7 >= _003ClastTableIndex_003E5__3)
								{
									num3 = 51;
									continue;
								}
								awaiter2 = ETDH4v5nL8LCpUhLlGy1(formatInputData.j08qCaavgy(_003Ci_003E5__7));
								num3 = 49;
								if (0 == 0)
								{
									continue;
								}
								goto case 60;
							case 62:
								result2 = awaiter4.GetResult();
								num3 = 9;
								continue;
							case 34:
								return;
							case 41:
								_003C_003Eu__3 = default;
								goto case 42;
							default:
								num3 = 42;
								continue;
							case 35:
								_003CcacheCellLoc_003E5__4 = tuple.Item2;
								awaiter4 = ((CvsCogSocket)On0GER5ih3UjTB2fkCpw(formatInputData.InSight)).Sheet.GetCellExpressionAsync(item2).GetAwaiter();
								num3 = 39;
								if (true)
								{
									continue;
								}
								return;
							case 50:
								return;
							case 43:
								goto IL_0616;
							case 18:
								num2 = (_003C_003E1__state = -1);
								num3 = 31;
								continue;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 39:
								if (awaiter4.IsCompleted)
								{
									goto case 62;
								}
								num2 = (_003C_003E1__state = 0);
								num3 = 54;
								if (!owHGXu5ixX7aOA355K60())
								{
									continue;
								}
								goto case 24;
							case 24:
								num2 = (_003C_003E1__state = 3);
								num3 = 26;
								if (true)
								{
									continue;
								}
								return;
							case 19:
								return;
							case 13:
								awaiter2.GetResult();
								num3 = 12;
								continue;
							case 6:
								num4 = _003Ci_003E5__7;
								num3 = 28;
								if (cBELJM5iHB7XaLHw0lZp())
								{
									continue;
								}
								goto case 56;
							case 56:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								num3 = 30;
								if (0 == 0)
								{
									continue;
								}
								goto case 53;
							case 53:
								if (!pajb385nKyfaWioknwlA(item, formatInputData.PAyqBddu0t.Location))
								{
									num3 = 2;
									continue;
								}
								goto case 38;
							case 59:
								awaiter2 = ETDH4v5nL8LCpUhLlGy1(formatInputData.fLbqRaenIC(result));
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 2);
									_003C_003Eu__3 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 55;
									continue;
								}
								goto case 13;
							case 30:
								return;
							case 17:
								_003Ci_003E5__7 = oldIndex;
								goto case 61;
							case 60:
								if (awaiter3.IsCompleted)
								{
									goto IL_0421;
								}
								goto IL_07bb;
							case 25:
								_003C_003Eu__4 = default;
								num3 = 18;
								continue;
							case 21:
							case 48:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 6);
									num3 = 43;
									continue;
								}
								goto IL_0840;
							case 27:
								_003CsnippetCellLoc_003E5__5 = default;
								num3 = 65;
								continue;
							case 55:
								return;
							case 0:
								num2 = (_003C_003E1__state = -1);
								goto IL_0840;
							case 15:
								return;
							case 44:
								_003C_003Eu__3 = default;
								num3 = 23;
								continue;
							case 2:
								while (true)
								{
									if (!pajb385nKyfaWioknwlA(_003ClastCacheExprLoc_003E5__6, formatInputData.PAyqBddu0t.LastLocation))
									{
										if (_003ClastCacheExprLoc_003E5__6.IsValid)
										{
											num3 = 58;
											if (!owHGXu5ixX7aOA355K60())
											{
												break;
											}
											continue;
										}
										goto case 46;
									}
									num3 = 38;
									break;
								}
								continue;
							case 42:
								num2 = (_003C_003E1__state = -1);
								num3 = 57;
								continue;
							case 64:
								_003C_003Eu__4 = default;
								num3 = 47;
								if (owHGXu5ixX7aOA355K60())
								{
								}
								continue;
							case 4:
								num2 = (_003C_003E1__state = 4);
								num3 = 16;
								continue;
							case 7:
								_003C_003Eu__2 = awaiter3;
								num3 = 56;
								continue;
							case 57:
								awaiter2.GetResult();
								num3 = 6;
								continue;
							case 28:
								_003Ci_003E5__7 = num4 + 1;
								num3 = 61;
								continue;
							case 49:
								if (!awaiter2.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								goto case 57;
							case 65:
								{
									_003ClastCacheExprLoc_003E5__6 = default;
									goto end_IL_008b;
								}
								IL_0421:
								result = awaiter3.GetResult();
								num3 = 52;
								continue;
								IL_0840:
								awaiter.GetResult();
								num3 = 46;
								continue;
								IL_0203:
								awaiter.GetResult();
								num3 = 14;
								continue;
							}
							break;
							IL_07bb:
							owHGXu5ixX7aOA355K60();
							num3 = (cBELJM5iHB7XaLHw0lZp() ? 3 : 21);
						}
						goto IL_00d1;
						IL_0616:
						_003C_003Eu__4 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 15;
						goto IL_0497;
						IL_032e:
						awaiter2.GetResult();
						num3 = 17;
						if (1 == 0)
						{
							goto IL_0341;
						}
						goto IL_0497;
						IL_0341:
						num2 = (_003C_003E1__state = 7);
						num3 = 45;
						goto IL_0497;
						IL_00d1:
						_003C_003Eu__3 = awaiter2;
						num3 = 40;
						goto IL_0497;
						end_IL_008b:
						break;
					}
				}
				finally
				{
					if (num2 < 0 && _003C_003E7__wrap1 != null)
					{
						OMI45U5nJSBpj2CLicCF(_003C_003E7__wrap1);
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
			goto IL_0a20;
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
		internal static object XScSY25imP8qwUdum4d9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IInSightAppStep)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TbxCsQ5iQjIIeUSjCDr5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EasyBuilderApplicationViewModel)P_0).OperationProgressManager;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WbsqVh5iNX4HIXTg4w7R(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).ActiveOperation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object X6Bu6J5i2hZlIBvdSJHp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.Hai9HDpTg7();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ItePRN5icVGHKOSAQlt5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DataElement)P_0).Cell;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object oCUYDL5i1JDmJVF5bhhF(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object sxo8NP5iuRHaVp2X4J3R(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).StartBlockingOperation((string)P_1, (StepDescriptor[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object On0GER5ih3UjTB2fkCpw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation IFxPaC5itd6Lx0slohXH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCellLocation.TryParse((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void oToTKE5izIwhsSNIg6fi(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((List<string>)P_0).RemoveAt(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter ETDH4v5nL8LCpUhLlGy1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pajb385nKyfaWioknwlA(CvsCellLocation P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0 == P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object N4MnsC5n5cZMYHbJFJk3(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object uloLtX5nwyvkQnqgsRlH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void OMI45U5nJSBpj2CLicCF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cBELJM5iHB7XaLHw0lZp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool owHGXu5ixX7aOA355K60()
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
	private struct _003CMoveInputRefForDelete_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public int destIndex;

		public FormatInputData _003C_003E4__this;

		private CvsCellLocation _003CsrcCacheCellLoc_003E5__2;

		private CvsCellLocation _003CdstGetValueCellLoc_003E5__3;

		private CvsCellLocation _003CdstCacheCellLoc_003E5__4;

		private CvsCellLocation _003CrefSnippetCellLoc_003E5__5;

		private TaskAwaiter<string> _003C_003Eu__1;

		private TaskAwaiter<object> _003C_003Eu__2;

		private TaskAwaiter<byte[]> _003C_003Eu__3;

		private TaskAwaiter _003C_003Eu__4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (sKimtt5namGQ68QkxGgf())
			{
				num = 5;
			}
			else
			{
				num = 4;
				if (jrhGW75nefba3yxBceW6())
				{
				}
			}
			int num2 = default;
			int num4 = default;
			TaskAwaiter awaiter3 = default;
			TaskAwaiter<string> awaiter4 = default;
			TaskAwaiter<object> awaiter2 = default;
			TaskAwaiter<byte[]> awaiter = default;
			FormatInputData formatInputData = default;
			(CvsCellLocation, CvsCellLocation) tuple = default;
			CvsCellLocation item = default;
			string result = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							num4 = destIndex + 1;
							num3 = 10;
							if (false)
							{
								goto IL_0053;
							}
							goto IL_0325;
						case 3:
							awaiter3 = _003C_003Eu__4;
							num3 = 37;
							goto IL_0325;
						case 0:
							awaiter4 = _003C_003Eu__1;
							num3 = 6;
							goto IL_0325;
						case 4:
							awaiter3 = _003C_003Eu__4;
							_003C_003Eu__4 = default;
							num3 = 27;
							goto IL_0325;
						case 1:
							awaiter2 = _003C_003Eu__2;
							goto IL_03da;
						case 2:
							{
								awaiter = _003C_003Eu__3;
								num3 = 7;
								goto IL_0325;
							}
							IL_0325:
							while (true)
							{
								switch (num3)
								{
								case 10:
									break;
								case 18:
									awaiter3.GetResult();
									awaiter3 = formatInputData.Fecqw3oSBj(_003CrefSnippetCellLoc_003E5__5, destIndex).GetAwaiter();
									if (!awaiter3.IsCompleted)
									{
										num3 = 12;
										continue;
									}
									goto case 38;
								case 30:
									if (!awaiter2.IsCompleted)
									{
										num3 = 35;
										continue;
									}
									goto case 22;
								case 3:
									_003CdstGetValueCellLoc_003E5__3 = tuple.Item1;
									num3 = 25;
									continue;
								case 37:
									_003C_003Eu__4 = default;
									num3 = 11;
									if (sKimtt5namGQ68QkxGgf())
									{
										continue;
									}
									return;
								case 2:
									return;
								case 29:
									return;
								case 4:
									_003CsrcCacheCellLoc_003E5__2 = tuple.Item2;
									num3 = 24;
									continue;
								case 17:
								case 28:
									_003C_003Eu__4 = awaiter3;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								case 22:
									awaiter2.GetResult();
									awaiter = ((CvsCogSocketSheet)I5QZDv5nOTJQHrfa0toZ(formatInputData.InSight.CogSocket)).CopyCellsAsync(new CvsCellRange(_003CsrcCacheCellLoc_003E5__2)).GetAwaiter();
									num3 = 13;
									continue;
								case 6:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_0187;
								case 16:
								{
									byte[] result2 = awaiter.GetResult();
									awaiter3 = goHpIu5nnfj4WUcvB0Bb(PjVBZX5nixbnUDSMV43k(I5QZDv5nOTJQHrfa0toZ(formatInputData.InSight.CogSocket), new CvsCellRange(_003CdstCacheCellLoc_003E5__4), result2, false, false));
									num3 = 19;
									continue;
								}
								case 32:
									awaiter4 = ((CvsCogSocketSheet)I5QZDv5nOTJQHrfa0toZ(formatInputData.InSight.CogSocket)).GetCellExpressionAsync(item).GetAwaiter();
									if (!awaiter4.IsCompleted)
									{
										num3 = 15;
										continue;
									}
									goto IL_0187;
								case 9:
									return;
								case 36:
									num2 = (_003C_003E1__state = -1);
									num3 = 16;
									continue;
								case 23:
									_003C_003Eu__1 = awaiter4;
									num3 = 26;
									continue;
								case 19:
									if (awaiter3.IsCompleted)
									{
										goto case 18;
									}
									goto IL_0253;
								case 31:
									awaiter2 = ((CvsCogSocket)zmgsYh5nDnraiPE9671d(formatInputData.InSight)).Sheet.PutCellExpressionAsync(_003CdstGetValueCellLoc_003E5__3, _003CrefSnippetCellLoc_003E5__5.ToString()).GetAwaiter();
									num3 = 30;
									continue;
								case 1:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 34;
									continue;
								case 8:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								case 0:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								default:
									num3 = 14;
									if (jrhGW75nefba3yxBceW6())
									{
									}
									continue;
								case 14:
									goto IL_03da;
								case 26:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
									num3 = 9;
									continue;
								case 12:
									num2 = (_003C_003E1__state = 4);
									_003C_003Eu__4 = awaiter3;
									num3 = 8;
									if (true)
									{
										continue;
									}
									goto case 13;
								case 13:
									if (!awaiter.IsCompleted)
									{
										num3 = 21;
										continue;
									}
									goto case 16;
								case 5:
									item = tuple.Item1;
									num3 = 4;
									continue;
								case 33:
									_003C_003Eu__2 = awaiter2;
									num3 = 0;
									if (sKimtt5namGQ68QkxGgf())
									{
										continue;
									}
									return;
								case 34:
									return;
								case 20:
									_003CrefSnippetCellLoc_003E5__5 = n6o1oj5nIsuiJojFETut(result);
									num3 = 31;
									continue;
								case 21:
									num2 = (_003C_003E1__state = 2);
									_003C_003Eu__3 = awaiter;
									num3 = 1;
									if (sKimtt5namGQ68QkxGgf())
									{
										continue;
									}
									goto case 11;
								case 11:
									num2 = (_003C_003E1__state = -1);
									num3 = 18;
									continue;
								case 15:
									num2 = (_003C_003E1__state = 0);
									num3 = 23;
									continue;
								case 25:
									_003CdstCacheCellLoc_003E5__4 = tuple.Item2;
									num3 = 32;
									continue;
								case 24:
									tuple = formatInputData.M9EqyR4lXS(destIndex);
									num3 = 3;
									if (sKimtt5namGQ68QkxGgf())
									{
										continue;
									}
									goto case 35;
								case 35:
									num2 = (_003C_003E1__state = 1);
									num3 = 33;
									if (true)
									{
										continue;
									}
									goto case 7;
								case 7:
									_003C_003Eu__3 = default;
									num3 = 36;
									continue;
								case 27:
									num2 = (_003C_003E1__state = -1);
									num3 = 38;
									continue;
								case 38:
									{
										awaiter3.GetResult();
										goto end_IL_0025;
									}
									IL_0187:
									result = awaiter4.GetResult();
									num3 = 20;
									continue;
								}
								break;
								IL_0253:
								num2 = (_003C_003E1__state = 3);
								_ = 0;
								num3 = (sKimtt5namGQ68QkxGgf() ? 17 : 2);
							}
							goto IL_0053;
							IL_03da:
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 22;
							goto IL_0325;
							IL_0053:
							tuple = formatInputData.M9EqyR4lXS(num4);
							num3 = 5;
							goto IL_0325;
							end_IL_0025:
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
					goto case 3;
				default:
					num = 3;
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					if (sKimtt5namGQ68QkxGgf())
					{
						break;
					}
					goto case 3;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						break;
					}
					goto case 1;
				case 1:
					formatInputData = _003C_003E4__this;
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
		internal static object I5QZDv5nOTJQHrfa0toZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation n6o1oj5nIsuiJojFETut(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCellLocation.TryParse((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zmgsYh5nDnraiPE9671d(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PjVBZX5nixbnUDSMV43k(object P_0, CvsCellRange P_1, object P_2, bool P_3, bool P_4)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).InternalPasteCellsAsync(P_1, (byte[])P_2, P_3, P_4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter goHpIu5nnfj4WUcvB0Bb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sKimtt5namGQ68QkxGgf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jrhGW75nefba3yxBceW6()
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
	private struct _003CCacheSnippetCell_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCellLocation origCellLoc;

		public FormatInputData _003C_003E4__this;

		public CvsCellLocation cacheCellLoc;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<object> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
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
			goto IL_0455;
			IL_001a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0455;
			IL_0455:
			int num2 = default;
			CvsCellRange cellRange = default;
			TaskAwaiter<byte[]> awaiter3 = default;
			TaskAwaiter<object> awaiter = default;
			TaskAwaiter awaiter2 = default;
			FormatInputData formatInputData = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					iV0nsS5nfTeberIfVWWK();
					num = (Ni3ORm5nVVRGQlGhkvy3() ? 2 : 0);
					continue;
				case 5:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							cellRange = new CvsCellRange(origCellLoc);
							num3 = 3;
							goto IL_0253;
						case 0:
							awaiter3 = _003C_003Eu__1;
							num3 = 7;
							goto IL_0253;
						case 3:
							awaiter = _003C_003Eu__3;
							num3 = 19;
							goto IL_0253;
						case 1:
							awaiter2 = _003C_003Eu__2;
							goto IL_007d;
						case 2:
							{
								awaiter = _003C_003Eu__3;
								num3 = 8;
								goto IL_0253;
							}
							IL_0253:
							while (true)
							{
								switch (num3)
								{
								case 15:
									awaiter = ((CvsCogSocketSheet)klF9an5nlp3o0QEMjuNI(TfOIYM5ndFrslkH5q2WE(formatInputData.InSight))).PutCellCommentAsync(cacheCellLoc, (string)null).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num3 = 23;
										if (0 == 0)
										{
											continue;
										}
										goto case 11;
									}
									goto case 28;
								case 11:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 10;
									continue;
								case 1:
								case 9:
									if (!awaiter3.IsCompleted)
									{
										num3 = 24;
										continue;
									}
									goto case 0;
								case 26:
									return;
								case 20:
									_003C_003Eu__2 = awaiter2;
									num3 = 11;
									continue;
								case 23:
									num2 = (_003C_003E1__state = 3);
									num3 = 25;
									continue;
								case 19:
									_003C_003Eu__3 = default;
									num3 = 27;
									continue;
								case 17:
									awaiter = ((CvsCogSocketSheet)klF9an5nlp3o0QEMjuNI(TfOIYM5ndFrslkH5q2WE(formatInputData.InSight))).PutCellNameAsync(cacheCellLoc, (object)null).GetAwaiter();
									num3 = 18;
									continue;
								case 14:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num3 = 26;
									if (0 == 0)
									{
										continue;
									}
									return;
								case 22:
									return;
								case 18:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 2);
										_003C_003Eu__3 = awaiter;
										num3 = 2;
										if (true)
										{
											continue;
										}
										goto case 27;
									}
									goto IL_0336;
								case 27:
									num2 = (_003C_003E1__state = -1);
									num3 = 28;
									continue;
								case 0:
								{
									byte[] result = awaiter3.GetResult();
									CvsCellRange cvsCellRange = new CvsCellRange(cacheCellLoc);
									awaiter2 = PMLhjF5nss5vWE1o3XKw(nAqDBP5nghJ9PirYNWAk(((CvsCogSocket)TfOIYM5ndFrslkH5q2WE(formatInputData.InSight)).Sheet, cvsCellRange, result, false, false));
									if (!awaiter2.IsCompleted)
									{
										num3 = 21;
										continue;
									}
									goto IL_0401;
								}
								case 10:
									return;
								case 21:
									num2 = (_003C_003E1__state = 1);
									num3 = 20;
									continue;
								case 6:
									num2 = (_003C_003E1__state = -1);
									num3 = 0;
									continue;
								case 2:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 4:
									num2 = (_003C_003E1__state = -1);
									goto IL_0336;
								case 25:
									_003C_003Eu__3 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 22;
									if (!iV0nsS5nfTeberIfVWWK())
									{
										continue;
									}
									goto case 8;
								case 8:
									_003C_003Eu__3 = default;
									num3 = 4;
									continue;
								case 24:
									num2 = (_003C_003E1__state = 0);
									num3 = 12;
									continue;
								case 3:
									awaiter3 = ((CvsCogSocketSheet)klF9an5nlp3o0QEMjuNI(TfOIYM5ndFrslkH5q2WE(formatInputData.InSight))).CopyCellsAsync(cellRange).GetAwaiter();
									_ = 1;
									if (iV0nsS5nfTeberIfVWWK())
									{
										num3 = 16;
										if (!iV0nsS5nfTeberIfVWWK())
										{
											continue;
										}
										goto case 21;
									}
									num3 = 9;
									if (Ni3ORm5nVVRGQlGhkvy3())
									{
										continue;
									}
									goto case 7;
								case 7:
									_003C_003Eu__1 = default;
									num3 = 6;
									continue;
								case 12:
									_003C_003Eu__1 = awaiter3;
									num3 = 14;
									continue;
								case 5:
									num2 = (_003C_003E1__state = -1);
									goto IL_0401;
								case 28:
									{
										awaiter.GetResult();
										goto end_IL_0253;
									}
									IL_0401:
									awaiter2.GetResult();
									num3 = 17;
									continue;
									IL_0336:
									awaiter.GetResult();
									num3 = 15;
									continue;
								}
								goto IL_007d;
								continue;
								end_IL_0253:
								break;
							}
							break;
							IL_007d:
							_003C_003Eu__2 = default;
							num3 = 5;
							goto IL_0253;
						}
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
				case 2:
					formatInputData = _003C_003E4__this;
					num = 5;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_001a;
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
		internal static object TfOIYM5ndFrslkH5q2WE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object klF9an5nlp3o0QEMjuNI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nAqDBP5nghJ9PirYNWAk(object P_0, CvsCellRange P_1, object P_2, bool P_3, bool P_4)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).InternalPasteCellsAsync(P_1, (byte[])P_2, P_3, P_4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter PMLhjF5nss5vWE1o3XKw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ni3ORm5nVVRGQlGhkvy3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iV0nsS5nfTeberIfVWWK()
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
	private struct _003CRestoreSnippetCell_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FormatInputData _003C_003E4__this;

		public CvsCellLocation origCellLoc;

		public CvsCellLocation cacheCellLoc;

		private string _003CcellName_003E5__2;

		private string _003CcellComment_003E5__3;

		private TaskAwaiter<string> _003C_003Eu__1;

		private TaskAwaiter<byte[]> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private TaskAwaiter<object> _003C_003Eu__4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			TaskAwaiter<string> awaiter4 = default;
			FormatInputData formatInputData = default;
			TaskAwaiter<object> awaiter2 = default;
			TaskAwaiter<byte[]> awaiter3 = default;
			TaskAwaiter awaiter = default;
			byte[] result2 = default;
			CvsCellRange cvsCellRange = default;
			string result = default;
			while (true)
			{
				switch (num)
				{
				case 7:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							awaiter4 = ((CvsCogSocketSheet)l33NKw5nZ1mUQJZKIngc(inCHbd5nPwikO8q3f69K(formatInputData.InSight))).GetCellNameAsync(origCellLoc).GetAwaiter();
							num3 = 30;
							goto IL_01b4;
						case 5:
							awaiter2 = _003C_003Eu__4;
							_003C_003Eu__4 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 42;
							goto IL_01b4;
						case 1:
							awaiter4 = _003C_003Eu__1;
							num3 = 12;
							goto IL_01b4;
						case 0:
							awaiter4 = _003C_003Eu__1;
							num3 = 2;
							if (0 == 0)
							{
								goto IL_01b4;
							}
							goto IL_032b;
						case 2:
							awaiter3 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 4;
							goto IL_01b4;
						case 4:
							awaiter2 = _003C_003Eu__4;
							num3 = 3;
							goto IL_01b4;
						case 3:
							{
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num3 = 13;
								goto IL_01b4;
							}
							IL_01b4:
							while (true)
							{
								switch (num3)
								{
								case 22:
									num2 = (_003C_003E1__state = -1);
									goto IL_006b;
								case 19:
									awaiter2 = ((CvsCogSocketSheet)l33NKw5nZ1mUQJZKIngc(inCHbd5nPwikO8q3f69K(formatInputData.InSight))).PutCellNameAsync(origCellLoc, (object)_003CcellName_003E5__2).GetAwaiter();
									num3 = 8;
									continue;
								case 4:
									result2 = awaiter3.GetResult();
									num3 = 31;
									continue;
								case 30:
									if (!awaiter4.IsCompleted)
									{
										num3 = 21;
										continue;
									}
									goto IL_0466;
								case 5:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 37;
									continue;
								case 25:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
									num3 = 10;
									continue;
								case 33:
									return;
								case 15:
									_003C_003Eu__1 = awaiter4;
									num3 = 11;
									continue;
								case 6:
								{
									CvsCellRange cellRange = new CvsCellRange(cacheCellLoc);
									awaiter3 = ((CvsCogSocket)inCHbd5nPwikO8q3f69K(formatInputData.InSight)).Sheet.CopyCellsAsync(cellRange).GetAwaiter();
									num3 = 23;
									if (0 == 0)
									{
										continue;
									}
									goto case 7;
								}
								case 7:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 26;
									if (!e64YFv5nrMOnFRAiPlEF())
									{
										continue;
									}
									goto case 9;
								case 9:
									_003C_003Eu__2 = awaiter3;
									goto case 18;
								default:
									num3 = 18;
									continue;
								case 16:
									awaiter4 = ((CvsCogSocket)inCHbd5nPwikO8q3f69K(formatInputData.InSight)).Sheet.GetCellCommentAsync(origCellLoc).GetAwaiter();
									num3 = 39;
									if (M4V7JI5nvyJb90iT25rv())
									{
										continue;
									}
									goto case 31;
								case 31:
									cvsCellRange = new CvsCellRange(origCellLoc);
									num3 = 14;
									if (true)
									{
										continue;
									}
									return;
								case 38:
									return;
								case 11:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
									num3 = 38;
									continue;
								case 21:
									num2 = (_003C_003E1__state = 0);
									num3 = 34;
									continue;
								case 12:
									_003C_003Eu__1 = default;
									num3 = 22;
									continue;
								case 10:
									return;
								case 34:
									break;
								case 40:
									goto IL_033f;
								case 2:
									_003C_003Eu__1 = default;
									num3 = 27;
									continue;
								case 24:
									_003CcellName_003E5__2 = result;
									num3 = 16;
									if (0 == 0)
									{
										continue;
									}
									return;
								case 0:
									return;
								case 23:
									if (awaiter3.IsCompleted)
									{
										goto case 4;
									}
									num2 = (_003C_003E1__state = 2);
									num3 = 9;
									if (0 == 0)
									{
										continue;
									}
									goto case 39;
								case 39:
									if (!awaiter4.IsCompleted)
									{
										num3 = 29;
										continue;
									}
									goto IL_006b;
								case 32:
									num2 = (_003C_003E1__state = 3);
									_003C_003Eu__3 = awaiter;
									num3 = 5;
									if (true)
									{
										continue;
									}
									goto case 28;
								case 28:
								case 35:
									awaiter2.GetResult();
									goto case 1;
								case 13:
									num2 = (_003C_003E1__state = -1);
									num3 = 20;
									continue;
								case 14:
									awaiter = iwQAUW5nbZrABHHXXjsC(qQQDjx5nBuJthLAGfVwJ(l33NKw5nZ1mUQJZKIngc(formatInputData.InSight.CogSocket), cvsCellRange, result2, false, false));
									if (!awaiter.IsCompleted)
									{
										num3 = 32;
										continue;
									}
									goto case 20;
								case 27:
									num2 = (_003C_003E1__state = -1);
									goto IL_0466;
								case 1:
								case 36:
									awaiter2 = ((CvsCogSocketSheet)l33NKw5nZ1mUQJZKIngc(inCHbd5nPwikO8q3f69K(formatInputData.InSight))).PutCellCommentAsync(origCellLoc, _003CcellComment_003E5__3).GetAwaiter();
									if (!awaiter2.IsCompleted)
									{
										num2 = (_003C_003E1__state = 5);
										num3 = 17;
										continue;
									}
									goto case 42;
								case 26:
									return;
								case 37:
									return;
								case 3:
									goto IL_04fa;
								case 8:
									if (!awaiter2.IsCompleted)
									{
										num2 = (_003C_003E1__state = 4);
										_003C_003Eu__4 = awaiter2;
										num3 = 7;
										continue;
									}
									goto case 28;
								case 17:
									_003C_003Eu__4 = awaiter2;
									num3 = 41;
									if (true)
									{
										continue;
									}
									goto case 18;
								case 18:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num3 = 0;
									if (e64YFv5nrMOnFRAiPlEF())
									{
									}
									continue;
								case 41:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 33;
									continue;
								case 29:
									num2 = (_003C_003E1__state = 1);
									num3 = 15;
									continue;
								case 20:
									awaiter.GetResult();
									num3 = 19;
									continue;
								case 42:
									{
										awaiter2.GetResult();
										goto end_IL_0019;
									}
									IL_006b:
									result = awaiter4.GetResult();
									num3 = 40;
									continue;
									IL_0466:
									result = awaiter4.GetResult();
									num3 = 24;
									continue;
								}
								break;
								IL_04fa:
								_003C_003Eu__4 = default;
								num2 = (_003C_003E1__state = -1);
								M4V7JI5nvyJb90iT25rv();
								num3 = (e64YFv5nrMOnFRAiPlEF() ? 1 : 28);
							}
							goto IL_032b;
							IL_032b:
							_003C_003Eu__1 = awaiter4;
							num3 = 25;
							if (true)
							{
								goto IL_01b4;
							}
							goto IL_033f;
							IL_033f:
							_003CcellComment_003E5__3 = result;
							num3 = 6;
							goto IL_01b4;
							end_IL_0019:
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CcellName_003E5__2 = null;
						_003CcellComment_003E5__3 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					_ = 0;
					num = (M4V7JI5nvyJb90iT25rv() ? 1 : 0);
					break;
				case 1:
				case 3:
					_003CcellName_003E5__2 = null;
					goto default;
				case 2:
					formatInputData = _003C_003E4__this;
					num = 7;
					break;
				case 6:
					_003C_003Et__builder.SetResult();
					num = 8;
					break;
				default:
					_003CcellComment_003E5__3 = null;
					num = 6;
					if (e64YFv5nrMOnFRAiPlEF())
					{
					}
					break;
				case 5:
					num2 = _003C_003E1__state;
					num = 2;
					break;
				case 8:
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
		internal static object inCHbd5nPwikO8q3f69K(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object l33NKw5nZ1mUQJZKIngc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qQQDjx5nBuJthLAGfVwJ(object P_0, CvsCellRange P_1, object P_2, bool P_3, bool P_4)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).InternalPasteCellsAsync(P_1, (byte[])P_2, P_3, P_4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter iwQAUW5nbZrABHHXXjsC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool M4V7JI5nvyJb90iT25rv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool e64YFv5nrMOnFRAiPlEF()
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
	private struct _003CUpdateGetBufferDataCell_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FormatInputData _003C_003E4__this;

		public int inputBufferIndex;

		public CvsCellLocation snippetCellLoc;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			string expression = default;
			FormatInputData formatInputData = default;
			TaskAwaiter<object> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							expression = (string)fSE4WE5nStwm0WroJWvq(CdQUGaROfy7He9T0foW.KbIzwHEDLa(52754), formatInputData.l9XqillOoF().ToString(absoluteRow: true, absoluteColumn: true), inputBufferIndex);
							num3 = 4;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
							if (gQKlpt5noERoD1Zl53Eb())
							{
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 5:
								return;
							case 9:
								return;
							case 4:
								awaiter = ((CvsCogSocketSheet)OUQVh45n8KA3c8DOslJa(IhsfWX5nk2jTo9ykErQb(formatInputData.InSight))).PutCellExpressionAsync(snippetCellLoc, expression).GetAwaiter();
								num3 = 7;
								continue;
							case 1:
								num2 = (_003C_003E1__state = 0);
								Ktf6GK5nGcvZqq9u5Di2();
								if (!gQKlpt5noERoD1Zl53Eb())
								{
									num3 = 8;
									continue;
								}
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 3;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								break;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 3:
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 6;
							default:
								num3 = 6;
								continue;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 0:
								_003C_003Eu__1 = default;
								num3 = 2;
								continue;
							case 10:
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
					goto case 5;
				default:
					num = 5;
					if (Ktf6GK5nGcvZqq9u5Di2())
					{
						continue;
					}
					goto case 1;
				case 1:
				case 3:
					formatInputData = _003C_003E4__this;
					goto case 2;
				case 0:
					break;
				case 6:
					return;
				}
				do
				{
					num2 = _003C_003E1__state;
					gQKlpt5noERoD1Zl53Eb();
					if (!Ktf6GK5nGcvZqq9u5Di2())
					{
						num = 4;
						continue;
					}
					num = 3;
					break;
				}
				while (false);
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
		internal static object fSE4WE5nStwm0WroJWvq(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IhsfWX5nk2jTo9ykErQb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OUQVh45n8KA3c8DOslJa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ktf6GK5nGcvZqq9u5Di2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gQKlpt5noERoD1Zl53Eb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private int t5iqseOKjJ;

	[CompilerGenerated]
	private CvsCellLocation gIaqKQRv2U;

	[CompilerGenerated]
	private CvsCellLocation tnFqGDYKYE;

	private CvsCellRange PAyqBddu0t;

	public int SelectedIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return t5iqseOKjJ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref t5iqseOKjJ, value, (string)hCnmjC2gTyD5BIrQU4F(29370));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FormatInputData(IInSightAppStep appStep)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = (ClTOUA2DCCI78lG5KmK() ? 1 : 3);
		while (true)
		{
			switch (num)
			{
			case 4:
				base._002Ector(appStep);
				break;
			case 0:
			case 1:
				Ad877S2n3c5Nm7589L0();
				num = 4;
				continue;
			case 5:
				return;
			}
			PAyqBddu0t = CvsCellRange.Invalid;
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ResetElements()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IDisposable disposable = (IDisposable)oQe9152VgO8LgSkOOT2(_suspendElementsEvents);
		try
		{
			knpq2faxAc(CvsCellLocation.Invalid);
			B5R5hY2iPgnXAapU3cB();
			int num = ((!ClTOUA2DCCI78lG5KmK()) ? 2 : 3);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					qVxqkInUgN(CvsCellLocation.Invalid);
					break;
				case 4:
					wC5cLi2fdUZwQw0AwuX(Elements);
					return;
				}
				PAyqBddu0t = CvsCellRange.Invalid;
				num = 4;
			}
		}
		finally
		{
			if (disposable != null)
			{
				xCNnJH2dlBdhTjIDInH(disposable);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetInputTableStart(CvsCellLocation startCell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		PAyqBddu0t = new CvsCellRange(startCell);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetInputTableEnd_003Ed__3))]
	public Task SetInputTableEnd(CvsCellLocation endCell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CSetInputTableEnd_003Ed__3 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 6:
				stateMachine._003C_003E4__this = this;
				goto case 0;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 0:
			case 2:
				stateMachine.endCell = endCell;
				goto case 3;
			default:
				num = 3;
				break;
			case 3:
				stateMachine._003C_003E1__state = -1;
				num = 4;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003Et__builder = LaYoSL2l2H3Mv1wFEBZ();
				B5R5hY2iPgnXAapU3cB();
				num = (ClTOUA2DCCI78lG5KmK() ? 6 : 0);
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal CvsCellLocation rnFqea0GmU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return gIaqKQRv2U;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal void knpq2faxAc(CvsCellLocation value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gIaqKQRv2U = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal CvsCellLocation l9XqillOoF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return tnFqGDYKYE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal void qVxqkInUgN(CvsCellLocation value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		tnFqGDYKYE = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnElementsChanged_003Ed__17))]
	protected override Task OnElementsChanged(NotifyCollectionChangedEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		B5R5hY2iPgnXAapU3cB();
		int num;
		if (ClTOUA2DCCI78lG5KmK())
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 6;
		}
		goto IL_0072;
		IL_0046:
		_003COnElementsChanged_003Ed__17 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		num = 2;
		goto IL_0072;
		IL_0072:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			case 5:
				goto IL_0046;
			case 2:
				stateMachine.e = e;
				goto default;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 1;
				continue;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		stateMachine._003C_003Et__builder = LaYoSL2l2H3Mv1wFEBZ();
		num = 5;
		if (!ClTOUA2DCCI78lG5KmK())
		{
			goto IL_0046;
		}
		goto IL_0072;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnSelectedElementPropertyChanged_003Ed__18))]
	protected override Task OnSelectedElementPropertyChanged(string propertyName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (!ClTOUA2DCCI78lG5KmK())
		{
			goto IL_001e;
		}
		goto IL_0038;
		IL_001e:
		_003COnSelectedElementPropertyChanged_003Ed__18 stateMachine = default;
		stateMachine.propertyName = propertyName;
		goto IL_0085;
		IL_0038:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				break;
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			default:
				goto IL_0085;
			case 5:
				stateMachine._003C_003Et__builder = LaYoSL2l2H3Mv1wFEBZ();
				num = 1;
				continue;
			case 1:
				goto IL_00ad;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
			IL_00ad:
			stateMachine._003C_003E4__this = this;
			ClTOUA2DCCI78lG5KmK();
			num = (B5R5hY2iPgnXAapU3cB() ? 4 : 0);
		}
		goto IL_001e;
		IL_0085:
		stateMachine._003C_003E1__state = -1;
		num = 6;
		goto IL_0038;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveSnippetReferences_003Ed__19))]
	public override Task RemoveSnippetReferences(EzSnippet snippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CRemoveSnippetReferences_003Ed__19 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine.snippet = snippet;
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 0;
				break;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (ClTOUA2DCCI78lG5KmK())
				{
					break;
				}
				goto case 6;
			case 6:
				stateMachine._003C_003E4__this = this;
				B5R5hY2iPgnXAapU3cB();
				if (!ClTOUA2DCCI78lG5KmK())
				{
					num = 4;
					if (0 == 0)
					{
						break;
					}
					goto default;
				}
				num = 1;
				break;
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 6;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetFormats_003Ed__20))]
	private Task<List<string>> TyXqMIHTu4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetFormats_003Ed__20 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<List<string>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetFormats_003Ed__21))]
	private Task fLbqRaenIC(List<string> P_0, bool P_1 = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CSetFormats_003Ed__21 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.formats = P_0;
		stateMachine.runSheet = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CParseTable_003Ed__22))]
	private Task vnhq41f5GT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CParseTable_003Ed__22 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
				stateMachine._003C_003Et__builder = LaYoSL2l2H3Mv1wFEBZ();
				_ = 1;
				if (!B5R5hY2iPgnXAapU3cB())
				{
					num = 2;
					if (0 == 0)
					{
						break;
					}
					goto case 4;
				}
				num = 5;
				if (true)
				{
					break;
				}
				goto default;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddInputRef_003Ed__23))]
	private Task bY1qlD108C(DataElement P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003CAddInputRef_003Ed__23 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 6:
				stateMachine._003C_003Et__builder = LaYoSL2l2H3Mv1wFEBZ();
				_ = 1;
				if (B5R5hY2iPgnXAapU3cB())
				{
					num = 3;
					if (ClTOUA2DCCI78lG5KmK())
					{
						continue;
					}
					goto case 4;
				}
				num = 0;
				continue;
			case 5:
				stateMachine._003C_003E1__state = -1;
				num = 4;
				if (B5R5hY2iPgnXAapU3cB())
				{
				}
				continue;
			case 2:
			case 3:
				stateMachine.element = P_0;
				goto case 5;
			default:
				num = 5;
				if (0 == 0)
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
	[AsyncStateMachine(typeof(_003CMoveInputRef_003Ed__24))]
	private Task y3DqT83iZf(DataElement P_0, int P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CMoveInputRef_003Ed__24 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine.newIndex = P_2;
				num = 5;
				break;
			case 0:
				stateMachine.element = P_0;
				num = 3;
				if (true)
				{
					break;
				}
				goto case 6;
			case 6:
			case 8:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				break;
			case 3:
				stateMachine.oldIndex = P_1;
				goto case 4;
			default:
				num = 4;
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 6;
			case 2:
				do
				{
					stateMachine._003C_003Et__builder = LaYoSL2l2H3Mv1wFEBZ();
					ClTOUA2DCCI78lG5KmK();
					if (B5R5hY2iPgnXAapU3cB())
					{
						num = 8;
						continue;
					}
					num = 7;
					if (B5R5hY2iPgnXAapU3cB())
					{
					}
					break;
				}
				while (!ClTOUA2DCCI78lG5KmK());
				break;
			case 1:
			case 7:
				stateMachine._003C_003E4__this = this;
				num = 0;
				break;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUpdateSelectedElement_003Ed__25))]
	private Task G0tqWZaIpY()
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
		goto IL_004c;
		IL_0032:
		_003CUpdateSelectedElement_003Ed__25 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_00a5;
		IL_004c:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				break;
			case 2:
			case 3:
				goto IL_0032;
			default:
				num = 0;
				if (true)
				{
					continue;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003Et__builder = LaYoSL2l2H3Mv1wFEBZ();
				_ = 0;
				if (!ClTOUA2DCCI78lG5KmK())
				{
					num = 3;
					continue;
				}
				num = 5;
				if (B5R5hY2iPgnXAapU3cB())
				{
				}
				continue;
			case 0:
				goto IL_00a5;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
		IL_00a5:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (B5R5hY2iPgnXAapU3cB())
		{
		}
		goto IL_004c;
		IL_001a:
		stateMachine._003C_003E4__this = this;
		goto IL_0032;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveInputRef_003Ed__26))]
	private Task r6DqjUNLYc(DataElement P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		B5R5hY2iPgnXAapU3cB();
		int num = ((!ClTOUA2DCCI78lG5KmK()) ? 7 : 4);
		_003CRemoveInputRef_003Ed__26 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 7:
				stateMachine._003C_003E4__this = this;
				num = 3;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 6:
				stateMachine.oldIndex = P_1;
				goto case 2;
			default:
				num = 2;
				break;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = LaYoSL2l2H3Mv1wFEBZ();
				goto case 1;
			case 3:
				stateMachine.removeElement = P_0;
				num = 6;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CMoveInputRefForDelete_003Ed__27))]
	private Task j08qCaavgy(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CMoveInputRefForDelete_003Ed__27 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
				stateMachine.destIndex = P_0;
				goto case 4;
			default:
				num = 4;
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 0:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				_ = 0;
				num = ((!ClTOUA2DCCI78lG5KmK()) ? 3 : 6);
				break;
			case 1:
			case 6:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCacheSnippetCell_003Ed__28))]
	private Task kevqOQgVqG(CvsCellLocation P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!B5R5hY2iPgnXAapU3cB())
		{
			num = 6;
			if (B5R5hY2iPgnXAapU3cB())
			{
			}
		}
		else
		{
			num = 3;
		}
		_003CCacheSnippetCell_003Ed__28 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				continue;
			case 7:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
			case 6:
				stateMachine._003C_003Et__builder = LaYoSL2l2H3Mv1wFEBZ();
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
			case 3:
				stateMachine.origCellLoc = P_0;
				num = 1;
				if (ClTOUA2DCCI78lG5KmK())
				{
					continue;
				}
				goto case 1;
			case 1:
				stateMachine.cacheCellLoc = P_1;
				goto case 4;
			default:
				num = 4;
				if (0 == 0)
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
	[AsyncStateMachine(typeof(_003CRestoreSnippetCell_003Ed__29))]
	private Task m7fqHag5Vk(CvsCellLocation P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CRestoreSnippetCell_003Ed__29 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 7:
				stateMachine._003C_003E4__this = this;
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				goto case 2;
			case 2:
				stateMachine.cacheCellLoc = P_0;
				goto case 3;
			case 6:
				stateMachine._003C_003E1__state = -1;
				num = 0;
				continue;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				continue;
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				_ = 1;
				num = ((!B5R5hY2iPgnXAapU3cB()) ? 7 : 4);
				continue;
			case 3:
			case 4:
				stateMachine.origCellLoc = P_1;
				goto case 6;
			default:
				num = 6;
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
	[AsyncStateMachine(typeof(_003CUpdateGetBufferDataCell_003Ed__30))]
	private Task Fecqw3oSBj(CvsCellLocation P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CUpdateGetBufferDataCell_003Ed__30 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder = LaYoSL2l2H3Mv1wFEBZ();
				_ = 0;
				num = ((!ClTOUA2DCCI78lG5KmK()) ? 6 : 5);
				break;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 2;
				if (B5R5hY2iPgnXAapU3cB())
				{
				}
				break;
			case 7:
				stateMachine._003C_003E1__state = -1;
				num = 0;
				break;
			case 2:
				stateMachine.snippetCellLoc = P_0;
				goto case 3;
			case 3:
			case 6:
				stateMachine.inputBufferIndex = P_1;
				goto case 7;
			default:
				num = 7;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private (CvsCellLocation getValueCellLoc, CvsCellLocation cacheCellLoc) M9EqyR4lXS(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int row = PAyqBddu0t.Location.Row + P_0 % PAyqBddu0t.Rows;
		int num = PAyqBddu0t.Location.Column + P_0 / PAyqBddu0t.Rows % PAyqBddu0t.Columns * 2;
		CvsCellLocation cvsCellLocation = new CvsCellLocation(row, num);
		CvsCellLocation cvsCellLocation2 = new CvsCellLocation(row, num + 1);
		if (!PAyqBddu0t.Contains(cvsCellLocation) || !PAyqBddu0t.Contains(cvsCellLocation2))
		{
			return (getValueCellLoc: CvsCellLocation.Invalid, cacheCellLoc: CvsCellLocation.Invalid);
		}
		return (getValueCellLoc: cvsCellLocation, cacheCellLoc: cvsCellLocation2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task dG8qxm9Ncc(NotifyCollectionChangedEventArgs P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnElementsChanged(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task HW4qvedVgU(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnSelectedElementPropertyChanged(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ad877S2n3c5Nm7589L0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ClTOUA2DCCI78lG5KmK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool B5R5hY2iPgnXAapU3cB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oQe9152VgO8LgSkOOT2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ScopedCounter)P_0).Increment();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wC5cLi2fdUZwQw0AwuX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Collection<DataElement>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xCNnJH2dlBdhTjIDInH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder LaYoSL2l2H3Mv1wFEBZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hCnmjC2gTyD5BIrQU4F(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}
}
