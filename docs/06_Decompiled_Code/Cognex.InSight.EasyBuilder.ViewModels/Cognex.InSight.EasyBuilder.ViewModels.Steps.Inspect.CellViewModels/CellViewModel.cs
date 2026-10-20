using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Cell;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime.ViewModels;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.InSight.Undo;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public abstract class CellViewModel : BaseViewModel, ICellViewModel
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnSourcePropertyChanged_003Ed__109 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CellViewModel _003C_003E4__this;

		public PropertyValueChangedEventArgs<CellViewModel> args;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			h38aQPKh7keb1YbTw1CK();
			int num = (b3m4k2Kh3qUNvcpxDEOd() ? 3 : 2);
			int num2 = default;
			CellViewModel cellViewModel = default;
			PropertyValueChangedEventHandler<CellViewModel> propertyValueChangedEventHandler = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 3:
					cellViewModel = _003C_003E4__this;
					num = 5;
					break;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							propertyValueChangedEventHandler = cellViewModel.Ofdw4eDj17;
							num3 = 3;
							goto IL_015c;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00f9;
						IL_00f9:
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						if (!h38aQPKh7keb1YbTw1CK())
						{
							goto IL_011e;
						}
						goto IL_015c;
						IL_0141:
						num2 = (_003C_003E1__state = 0);
						goto IL_018d;
						IL_015c:
						while (true)
						{
							switch (num3)
							{
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									if (b3m4k2Kh3qUNvcpxDEOd())
									{
									}
									continue;
								}
								goto case 10;
							case 1:
								return;
							case 3:
								break;
							case 0:
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 1;
								continue;
							case 6:
							case 7:
								goto IL_00f9;
							case 8:
								goto IL_011e;
							case 9:
								goto IL_0141;
							default:
								goto IL_018d;
							case 10:
								awaiter.GetResult();
								goto end_IL_0065;
							}
							break;
						}
						goto IL_00be;
						IL_011e:
						awaiter = IoILl1KhjrIggSrbh5Pb(propertyValueChangedEventHandler(cellViewModel, args));
						num3 = 5;
						if (!h38aQPKh7keb1YbTw1CK())
						{
							goto IL_0141;
						}
						goto IL_015c;
						IL_018d:
						h38aQPKh7keb1YbTw1CK();
						if (b3m4k2Kh3qUNvcpxDEOd())
						{
							num3 = 6;
							if (!h38aQPKh7keb1YbTw1CK())
							{
								goto IL_00be;
							}
						}
						else
						{
							num3 = 0;
						}
						goto IL_015c;
						IL_00be:
						if (propertyValueChangedEventHandler != null)
						{
							num3 = 8;
							goto IL_015c;
						}
						end_IL_0065:;
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
		internal static TaskAwaiter IoILl1KhjrIggSrbh5Pb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool h38aQPKh7keb1YbTw1CK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool b3m4k2Kh3qUNvcpxDEOd()
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
	private struct _003CWriteImmediateAsync_003Ed__117<TDataType> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CellViewModel _003C_003E4__this;

		public TDataType cellValue;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((1 == 0) ? 1 : 5);
			CellViewModel cellViewModel = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					cellViewModel = _003C_003E4__this;
					goto case 1;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 3;
					continue;
				case 1:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = WriteImmediateAsync(cellViewModel.InSight, cellViewModel.CellName, cellValue).GetAwaiter();
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								_ = 0;
								num3 = ((1 == 0) ? 3 : 5);
								continue;
							case 4:
							case 5:
								return;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								break;
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								continue;
							case 8:
								_003C_003Eu__1 = default;
								goto case 3;
							case 1:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 3:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 9:
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
				default:
					num = 4;
					continue;
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
		internal static bool Y6J7hrKh6QoxG3k27jbe()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Q7895gKhCv4UIGVKp3kc()
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
	private struct _003CWriteImmediateAsync_003Ed__118<TDataType> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string cellName;

		public TDataType cellValue;

		public CvsInSight insight;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			Dictionary<string, object> dictionary = default;
			TaskAwaiter<CvsCogSheetResult> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							dictionary = new Dictionary<string, object>();
							num3 = 6;
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
							case 2:
								awaiter = insight.CogSocket.Sheet.RunAsync(dictionary, fireSheetUpdated: false).GetAwaiter();
								num3 = 4;
								continue;
							case 1:
								return;
							case 3:
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 5;
							default:
								num3 = 5;
								continue;
							case 0:
								_003C_003Eu__1 = default;
								goto case 7;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 1;
								continue;
							case 7:
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 4:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_ = 0;
									num3 = (true ? 8 : 9);
									continue;
								}
								break;
							case 6:
								dictionary.Add(cellName, cellValue);
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
					break;
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					num = (true ? 4 : 3);
					continue;
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
		internal static bool P9o8icKhAUUr6UiiPYFX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool icYTHxKhRX2V44wBwRG7()
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
	private struct _003CRemoveReferences_003Ed__119 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IUndoAction> _003C_003Et__builder;

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
			if (bRr29NKhWoHnrBkP042K())
			{
				num = 3;
				if (APkg0KKhTCBYsT9r0NIk())
				{
				}
			}
			else
			{
				num = 1;
			}
			int num2 = default;
			IUndoAction result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = OVwXb3Kh0rqbsCEngvAs(VQDlikKhygGU9YcVgvQ9());
							num3 = 4;
							if (APkg0KKhTCBYsT9r0NIk())
							{
							}
							goto IL_009a;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0064;
						IL_0064:
						_003C_003Eu__1 = default;
						num3 = 2;
						goto IL_009a;
						IL_009a:
						while (true)
						{
							switch (num3)
							{
							case 5:
							case 9:
								break;
							case 3:
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								continue;
							case 1:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 7:
								return;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 1;
								continue;
							case 0:
								_003C_003Eu__1 = awaiter;
								_ = 1;
								num3 = ((!APkg0KKhTCBYsT9r0NIk()) ? 6 : 9);
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								continue;
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 1;
							case 10:
								result = null;
								goto end_IL_009a;
							}
							goto IL_0064;
							continue;
							end_IL_009a:
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
					return;
				}
				_003C_003Et__builder.SetResult(result);
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
		internal static object VQDlikKhygGU9YcVgvQ9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter OVwXb3Kh0rqbsCEngvAs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bRr29NKhWoHnrBkP042K()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool APkg0KKhTCBYsT9r0NIk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	protected static readonly ILogger Log;

	private static readonly HashSet<CellType> qWewuONRsc;

	[CompilerGenerated]
	private static readonly Func<CellViewModel, bool> bjBwFyTbXw;

	[CompilerGenerated]
	private CvsInSight iyewX2lhsi;

	[CompilerGenerated]
	private CvsCellLocation oGmwoeKvO2;

	private bool FT6wSAb2F5;

	private string M4nwDhxto1;

	[CompilerGenerated]
	private EventHandler lJGw3isdYK;

	protected string _cellName;

	private string ItYwIgAYb7;

	protected bool _isCellEnabled;

	protected bool _enabled;

	[CompilerGenerated]
	private bool LDswfBhZnA;

	private CvsCellComment OhJwEbC5sO;

	[CompilerGenerated]
	private readonly string dS5wbGyWwq;

	[CompilerGenerated]
	private bool pJ2wcl0ee0;

	private bool YNrwQyG8nL;

	[CompilerGenerated]
	private readonly bool kwywgQo2gi;

	[CompilerGenerated]
	private readonly string Qt8wMHOavV;

	private CellViewModel iSswR9X5eB;

	[CompilerGenerated]
	private PropertyValueChangedEventHandler<CellViewModel> Ofdw4eDj17;

	[CompilerGenerated]
	private PropertyValueChangedEventHandler<CellViewModel> BtqwlSH07F;

	protected CvsInSight InSight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iyewX2lhsi;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			iyewX2lhsi = value;
		}
	}

	public CvsCellLocation CellLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return oGmwoeKvO2;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oGmwoeKvO2 = value;
		}
	}

	public bool IsInitialized
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FT6wSAb2F5;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref FT6wSAb2F5, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(4976));
		}
	}

	public string RefExpression
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			if (!TWjsZA0AMj1q6j9rCSW())
			{
				goto IL_001e;
			}
			goto IL_008c;
			IL_001e:
			if (M4nwDhxto1 != null)
			{
				num = 5;
				goto IL_008c;
			}
			CvsCellLocation cellLocation = CellLocation;
			goto IL_005a;
			IL_005a:
			string result = cellLocation.ToString(absoluteRow: true, absoluteColumn: true);
			num = 6;
			goto IL_008c;
			IL_008c:
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				case 5:
					goto IL_0033;
				default:
					goto IL_005a;
				case 0:
				case 2:
				case 6:
					return result;
				}
				break;
				IL_0033:
				result = M4nwDhxto1;
				TWjsZA0AMj1q6j9rCSW();
				if (!U8ui4H0RQq4d0hKX2TV())
				{
					num = 0;
					if (TWjsZA0AMj1q6j9rCSW())
					{
						continue;
					}
					goto IL_005a;
				}
				num = 4;
			}
			goto IL_001e;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			M4nwDhxto1 = value;
		}
	}

	public abstract CellType DataType { get; }

	public abstract bool IsReadOnly { get; }

	public string CellName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _cellName;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref _cellName, value, (string)wPGJe00HhfQnM8r2VB0(27712));
		}
	}

	public string LocalizedCellName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ItYwIgAYb7 ?? CellName;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref ItYwIgAYb7, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(27732));
		}
	}

	public bool IsCellEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _isCellEnabled;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref _isCellEnabled, value, (string)wPGJe00HhfQnM8r2VB0(27770));
		}
	}

	public bool Enabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _enabled;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref _enabled, value, (string)wPGJe00HhfQnM8r2VB0(20568));
		}
	}

	public bool Error
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LDswfBhZnA;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			LDswfBhZnA = value;
		}
	}

	public CvsCellComment Comment
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OhJwEbC5sO;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			U8ui4H0RQq4d0hKX2TV();
			int num = ((!TWjsZA0AMj1q6j9rCSW()) ? 1 : 4);
			while (true)
			{
				switch (num)
				{
				default:
					FirePropertyChanged(CdQUGaROfy7He9T0foW.KbIzwHEDLa(27844));
					num = 5;
					break;
				case 0:
				case 4:
					if (SetField(ref OhJwEbC5sO, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(27800)))
					{
						num = 3;
						break;
					}
					return;
				case 3:
					qCVG2m0xmyP5953Srdx(this, wPGJe00HhfQnM8r2VB0(27818));
					goto default;
				case 5:
					return;
				}
			}
		}
	}

	public string CommentText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CvsCellComment comment = Comment;
			if (comment == null)
			{
				return null;
			}
			return (string)HOto280mKMIB8CFiGh4(comment);
		}
	}

	public SolidColorBrush CommentColorBrush
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			U8ui4H0RQq4d0hKX2TV();
			int num;
			if (TWjsZA0AMj1q6j9rCSW())
			{
				num = 3;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 4;
			}
			System.Windows.Media.Color color2 = default;
			System.Drawing.Color color = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				default:
					color2 = System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B);
					num = 5;
					continue;
				case 0:
				case 3:
					if (Comment != null)
					{
						color = MFEBHq0QmiN2m2xrVNm(Comment);
						goto default;
					}
					num = 1;
					if (!U8ui4H0RQq4d0hKX2TV())
					{
						continue;
					}
					goto case 5;
				case 5:
				{
					SolidColorBrush solidColorBrush = new SolidColorBrush();
					qLEnXX0NP4ZUumaK02A(solidColorBrush, color2);
					return solidColorBrush;
				}
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			return null;
		}
	}

	public string DisplayName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return dS5wbGyWwq;
		}
	}

	public bool Internal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return pJ2wcl0ee0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			pJ2wcl0ee0 = value;
		}
	}

	public bool IsBoundExternally
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return YNrwQyG8nL;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref YNrwQyG8nL, value, (string)wPGJe00HhfQnM8r2VB0(27882));
		}
	}

	public virtual bool IsLink
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kwywgQo2gi;
		}
	}

	CvsCellLocation ICellViewModel.Location
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellLocation;
		}
	}

	string ICellViewModel.CellName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellName;
		}
	}

	bool ICellViewModel.IsReadOnly
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DcUIUi0cwloISY5JrYJ(this);
		}
	}

	string ICellViewModel.LocalizedCellName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LocalizedCellName;
		}
	}

	protected virtual bool IsRuntimeModeValidForEditing
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (InSight != null && !VucONsFLH1j5pS5VsqZ(InSight))
			{
				return !cNbNPnFK1DHY9eDl5gB(InSight);
			}
			return false;
		}
	}

	public virtual bool IsPrimitive
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qWewuONRsc.Contains(BY7XrrF583bjWWIVJLW(this));
		}
	}

	public virtual string DisplayValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Qt8wMHOavV;
		}
	}

	public CellViewModel SourceProperty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iSswR9X5eB;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SuRwaP9gGT(value, _0020: true);
		}
	}

	public event EventHandler CellRefreshed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					eventHandler2 = eventHandler;
					num = 4;
					break;
				default:
					eventHandler = Interlocked.CompareExchange(ref lJGw3isdYK, value2, eventHandler2);
					num = 6;
					break;
				case 6:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						break;
					}
					goto case 1;
				case 4:
					value2 = (EventHandler)PvphqE0MOt34wmGN9t9(eventHandler2, value);
					goto default;
				case 0:
					eventHandler = lJGw3isdYK;
					TWjsZA0AMj1q6j9rCSW();
					num = ((!U8ui4H0RQq4d0hKX2TV()) ? 2 : 5);
					break;
				case 7:
					return;
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
			int num = 6;
			EventHandler eventHandler = default;
			EventHandler eventHandler2 = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					eventHandler = eventHandler2;
					num = 0;
					continue;
				case 6:
					eventHandler2 = lJGw3isdYK;
					_ = 0;
					if (TWjsZA0AMj1q6j9rCSW())
					{
						num = 5;
						if (U8ui4H0RQq4d0hKX2TV())
						{
						}
					}
					else
					{
						num = 2;
					}
					continue;
				case 4:
					if ((object)eventHandler2 == eventHandler)
					{
						num = 7;
						continue;
					}
					goto case 1;
				case 0:
					value2 = (EventHandler)XPXWO20Y5QUvERTHl2w(eventHandler, value);
					break;
				case 7:
					return;
				}
				eventHandler2 = Interlocked.CompareExchange(ref lJGw3isdYK, value2, eventHandler);
				num = 4;
			}
		}
	}

	public event PropertyValueChangedEventHandler<CellViewModel> SourcePropertyChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			PropertyValueChangedEventHandler<CellViewModel> propertyValueChangedEventHandler = Ofdw4eDj17;
			PropertyValueChangedEventHandler<CellViewModel> propertyValueChangedEventHandler2;
			do
			{
				propertyValueChangedEventHandler2 = propertyValueChangedEventHandler;
				PropertyValueChangedEventHandler<CellViewModel> value2 = (PropertyValueChangedEventHandler<CellViewModel>)Delegate.Combine(propertyValueChangedEventHandler2, value);
				propertyValueChangedEventHandler = Interlocked.CompareExchange(ref Ofdw4eDj17, value2, propertyValueChangedEventHandler2);
			}
			while ((object)propertyValueChangedEventHandler != propertyValueChangedEventHandler2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			PropertyValueChangedEventHandler<CellViewModel> propertyValueChangedEventHandler = Ofdw4eDj17;
			PropertyValueChangedEventHandler<CellViewModel> propertyValueChangedEventHandler2;
			do
			{
				propertyValueChangedEventHandler2 = propertyValueChangedEventHandler;
				PropertyValueChangedEventHandler<CellViewModel> value2 = (PropertyValueChangedEventHandler<CellViewModel>)Delegate.Remove(propertyValueChangedEventHandler2, value);
				propertyValueChangedEventHandler = Interlocked.CompareExchange(ref Ofdw4eDj17, value2, propertyValueChangedEventHandler2);
			}
			while ((object)propertyValueChangedEventHandler != propertyValueChangedEventHandler2);
		}
	}

	public event PropertyValueChangedEventHandler<CellViewModel> CellViewModelReplaced
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			PropertyValueChangedEventHandler<CellViewModel> propertyValueChangedEventHandler = BtqwlSH07F;
			PropertyValueChangedEventHandler<CellViewModel> propertyValueChangedEventHandler2;
			do
			{
				propertyValueChangedEventHandler2 = propertyValueChangedEventHandler;
				PropertyValueChangedEventHandler<CellViewModel> value2 = (PropertyValueChangedEventHandler<CellViewModel>)Delegate.Combine(propertyValueChangedEventHandler2, value);
				propertyValueChangedEventHandler = Interlocked.CompareExchange(ref BtqwlSH07F, value2, propertyValueChangedEventHandler2);
			}
			while ((object)propertyValueChangedEventHandler != propertyValueChangedEventHandler2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			PropertyValueChangedEventHandler<CellViewModel> propertyValueChangedEventHandler = BtqwlSH07F;
			PropertyValueChangedEventHandler<CellViewModel> propertyValueChangedEventHandler2;
			do
			{
				propertyValueChangedEventHandler2 = propertyValueChangedEventHandler;
				PropertyValueChangedEventHandler<CellViewModel> value2 = (PropertyValueChangedEventHandler<CellViewModel>)Delegate.Remove(propertyValueChangedEventHandler2, value);
				propertyValueChangedEventHandler = Interlocked.CompareExchange(ref BtqwlSH07F, value2, propertyValueChangedEventHandler2);
			}
			while ((object)propertyValueChangedEventHandler != propertyValueChangedEventHandler2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal static Func<CellViewModel, bool> oexw5f8eIR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return bjBwFyTbXw;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected CellViewModel(CvsInSight insight, string displayName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		while (true)
		{
			switch (num)
			{
			case 5:
				InSight = insight;
				goto case 6;
			default:
				num = 6;
				continue;
			case 3:
				dS5wbGyWwq = displayName;
				num = 8;
				if (TWjsZA0AMj1q6j9rCSW())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 4:
				Qt8wMHOavV = "";
				break;
			case 6:
				CellLocation = CvsCellLocation.Invalid;
				num = 3;
				continue;
			case 7:
				oTXQNJ0WKrFmQYYq58g();
				TWjsZA0AMj1q6j9rCSW();
				if (U8ui4H0RQq4d0hKX2TV())
				{
					num = 0;
					if (true)
					{
						continue;
					}
					goto case 6;
				}
				num = 4;
				continue;
			case 0:
			case 2:
				break;
			case 8:
				return;
			}
			IJKuYp0TqCIrhqNmHdd(this);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected CellViewModel(CvsInSight insight, CvsCellLocation loc, string displayName, bool isInitialized = true)
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
			case 4:
				InSight = insight;
				goto case 7;
			default:
				num = 7;
				continue;
			case 2:
			case 5:
				dS5wbGyWwq = displayName;
				goto case 6;
			case 6:
			case 8:
				IsInitialized = isInitialized;
				num = 9;
				if (TWjsZA0AMj1q6j9rCSW())
				{
					continue;
				}
				goto case 7;
			case 7:
				CellLocation = loc;
				TWjsZA0AMj1q6j9rCSW();
				num = ((!U8ui4H0RQq4d0hKX2TV()) ? 2 : 8);
				continue;
			case 3:
				oTXQNJ0WKrFmQYYq58g();
				num = 0;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
				IJKuYp0TqCIrhqNmHdd(this);
				num = 4;
				if (TWjsZA0AMj1q6j9rCSW())
				{
					continue;
				}
				break;
			case 0:
				break;
			case 9:
				return;
			}
			Qt8wMHOavV = "";
			num = 1;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected CellViewModel(CvsInSight insight, string virtualCellName, string refExpression, string displayName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		U8ui4H0RQq4d0hKX2TV();
		int num;
		if (TWjsZA0AMj1q6j9rCSW())
		{
			num = 9;
		}
		else
		{
			num = 7;
			if (!TWjsZA0AMj1q6j9rCSW())
			{
				goto IL_0060;
			}
		}
		goto IL_009f;
		IL_0073:
		oTXQNJ0WKrFmQYYq58g();
		num = 6;
		goto IL_009f;
		IL_0060:
		CellName = virtualCellName;
		num = 1;
		if (1 == 0)
		{
			goto IL_0073;
		}
		goto IL_009f;
		IL_009f:
		while (true)
		{
			switch (num)
			{
			case 6:
				Qt8wMHOavV = "";
				num = 5;
				if (!U8ui4H0RQq4d0hKX2TV())
				{
					continue;
				}
				goto case 3;
			case 3:
				InSight = insight;
				goto case 4;
			case 2:
				break;
			case 0:
			case 9:
				goto IL_0073;
			case 4:
			case 7:
				CellLocation = CvsCellLocation.Invalid;
				goto case 8;
			default:
				num = 8;
				continue;
			case 8:
				dS5wbGyWwq = displayName;
				num = 2;
				continue;
			case 1:
				RefExpression = refExpression;
				num = 10;
				continue;
			case 5:
				IJKuYp0TqCIrhqNmHdd(this);
				num = 3;
				continue;
			case 10:
				return;
			}
			break;
		}
		goto IL_0060;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Refresh(CvsCellCollection cells, bool init = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 12;
		if (!U8ui4H0RQq4d0hKX2TV())
		{
		}
		CvsCell cvsCell = default;
		CvsCellLocation cellLocation = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				aq7kxk0ySWPfbIVbk0U(this, cvsCell, init);
				num = 0;
				break;
			case 4:
				RefreshCellEnabled(cvsCell, init);
				U8ui4H0RQq4d0hKX2TV();
				num = (TWjsZA0AMj1q6j9rCSW() ? 1 : 3);
				break;
			case 6:
				r2UHmMvtb5(cvsCell, init);
				num = 13;
				if (true)
				{
					break;
				}
				goto case 7;
			case 7:
				if (InSight.IsLiveAcquisition)
				{
					return;
				}
				if (!init)
				{
					if (cvsCell != null)
					{
						num = 2;
						break;
					}
					return;
				}
				goto case 2;
			case 3:
			case 9:
				ibZnVQ0FuoSxLOUZNCJ(this, cvsCell, init);
				num = 6;
				break;
			case 1:
			case 5:
				RefreshCellError(cvsCell, init);
				goto case 7;
			default:
				num = 7;
				if (0 == 0)
				{
					break;
				}
				goto case 11;
			case 11:
				cellLocation = CellLocation;
				num = 8;
				break;
			case 10:
				cvsCell = cells[CellLocation];
				num = 4;
				break;
			case 8:
				if (!cellLocation.IsValid)
				{
					goto case 4;
				}
				num = 10;
				if (TWjsZA0AMj1q6j9rCSW())
				{
					break;
				}
				goto case 12;
			case 12:
				cvsCell = null;
				num = 11;
				if (!U8ui4H0RQq4d0hKX2TV())
				{
					break;
				}
				goto case 0;
			case 0:
				DW4OwQ002gLQpChWmpE(this, cvsCell, init);
				goto case 3;
			case 13:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void r2UHmMvtb5(CvsCell P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EventHandler eventHandler = lJGw3isdYK;
		if (eventHandler != null)
		{
			pxkkMd0UcqkdhFtCEB2(eventHandler, this, new CellViewModelRefreshEventArgs(P_0, P_1));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual CellViewModel FindMatch(string text)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!IfpLuH02nG8UmhZxudc(CellName, text))
		{
			return null;
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void RefreshCellEnabled(CvsCell cell, bool init)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 9;
		bool flag = default;
		CvsCellLocation cellLocation = default;
		while (true)
		{
			switch (num)
			{
			case 4:
			case 8:
				IsCellEnabled = flag;
				num = 11;
				continue;
			case 5:
				if (cellLocation.IsValid)
				{
					_ = 0;
					num = ((!TWjsZA0AMj1q6j9rCSW()) ? 4 : 10);
					continue;
				}
				goto case 0;
			case 2:
				_isCellEnabled = flag;
				num = 6;
				continue;
			case 3:
			case 10:
				if (cell != null)
				{
					num = 7;
					continue;
				}
				goto case 0;
			case 9:
				flag = false;
				num = 1;
				continue;
			case 1:
				cellLocation = CellLocation;
				num = 5;
				continue;
			case 7:
				flag = uUwTp2018ws7BhIN9bq(cell);
				goto case 0;
			default:
				num = 0;
				continue;
			case 0:
				if (!init)
				{
					if (cell == null)
					{
						break;
					}
					goto case 4;
				}
				num = 2;
				continue;
			case 6:
			case 11:
				break;
			}
			break;
		}
		Enabled = IsCellEnabled && MoH3lT0u6nLwtvK9jSq(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void RefreshCellError(CvsCell cell, bool init)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		CvsCellLocation cellLocation = default;
		bool value = default;
		do
		{
			IL_0046:
			switch (num)
			{
			case 2:
			case 6:
				if (cellLocation.IsValid)
				{
					num = 1;
					goto IL_0046;
				}
				break;
			case 1:
				if (cell == null)
				{
					break;
				}
				goto case 7;
			default:
				num = 7;
				goto IL_0046;
			case 4:
				value = false;
				num = 0;
				if (TWjsZA0AMj1q6j9rCSW())
				{
					goto IL_0046;
				}
				goto case 0;
			case 0:
				cellLocation = CellLocation;
				_ = 0;
				if (TWjsZA0AMj1q6j9rCSW())
				{
					num = 6;
					goto IL_0046;
				}
				num = 3;
				if (!U8ui4H0RQq4d0hKX2TV())
				{
					goto IL_0046;
				}
				break;
			case 7:
				value = muVbDT0hOVqM1Al0Yeu(cell);
				break;
			case 3:
			case 5:
				break;
			case 8:
				return;
			}
			Error = value;
			num = 8;
		}
		while (TWjsZA0AMj1q6j9rCSW());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void RefreshComment(CvsCell cell, bool init)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		CvsCellComment cvsCellComment = default;
		CvsCellLocation cellLocation = default;
		while (true)
		{
			object obj;
			switch (num)
			{
			case 2:
				if (cell == null)
				{
					goto default;
				}
				obj = R6WJ5m0tnkGxbVBR440(cell);
				goto IL_00c5;
			default:
				U8ui4H0RQq4d0hKX2TV();
				if (TWjsZA0AMj1q6j9rCSW())
				{
					num = 8;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				}
				num = 1;
				break;
			case 0:
				cvsCellComment = null;
				num = 3;
				break;
			case 7:
				return;
			case 3:
				cellLocation = CellLocation;
				num = 6;
				break;
			case 1:
			case 5:
				OhJwEbC5sO = cvsCellComment;
				num = 7;
				break;
			case 4:
			case 8:
				obj = null;
				goto IL_00c5;
			case 6:
				if (cellLocation.IsValid)
				{
					num = 2;
					break;
				}
				goto IL_00c6;
			case 9:
				return;
				IL_00c5:
				cvsCellComment = (CvsCellComment)obj;
				goto IL_00c6;
				IL_00c6:
				if (!init)
				{
					Comment = cvsCellComment;
					num = 9;
					break;
				}
				goto case 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void RefreshCellName(CvsCell cell, bool init)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (false)
		{
			return;
		}
		string text = default;
		CvsCellLocation cellLocation = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				return;
			case 8:
				if (cell == null)
				{
					goto case 5;
				}
				goto case 4;
			case 5:
				if (!init)
				{
					CellName = text;
					num = 10;
					if (TWjsZA0AMj1q6j9rCSW())
					{
						break;
					}
					goto case 8;
				}
				num = 2;
				break;
			case 4:
			case 9:
				text = (string)u3Res20zmd4JNfql92H(cell);
				goto case 5;
			default:
				num = 5;
				break;
			case 0:
				text = "";
				_ = 0;
				num = (TWjsZA0AMj1q6j9rCSW() ? 7 : 9);
				break;
			case 1:
			case 7:
				cellLocation = CellLocation;
				num = 3;
				break;
			case 2:
				_cellName = text;
				num = 6;
				break;
			case 3:
				if (cellLocation.IsValid)
				{
					num = 8;
					if (U8ui4H0RQq4d0hKX2TV())
					{
						return;
					}
					break;
				}
				goto case 5;
			case 10:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void RefreshValue(CvsCell cell, bool init)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static TDataType ConvertCellValue<TDataType>(CvsCell cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			if (cell != null && cell.CellValue != null && !cell.Error)
			{
				return (TDataType)Convert.ChangeType(cell.CellValue, typeof(TDataType));
			}
		}
		catch (Exception exception)
		{
			string message = string.Format(CdQUGaROfy7He9T0foW.KbIzwHEDLa(27920), cell.Location, cell.Expression, cell.CellValue);
			Log.WarnException(message, exception);
		}
		return default;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void RefreshButtonTextValue(Action<string> valueSetter, CvsCell cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (CellLocation.IsValid)
		{
			if (cell is CvsCellButton cvsCellButton)
			{
				valueSetter(cvsCellButton.Text);
			}
			else
			{
				valueSetter(string.Empty);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void RefreshStringValue(Action<string> valueSetter, CvsCell cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (CellLocation.IsValid)
		{
			if (cell is CvsCellString cvsCellString)
			{
				valueSetter(cvsCellString.Text);
			}
			else
			{
				valueSetter(string.Empty);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void RefreshIntValue(Action<int> valueSetter, CvsCell cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (CellLocation.IsValid)
		{
			if (cell is CvsCellFloat cvsCellFloat)
			{
				valueSetter((int)cvsCellFloat.Value);
			}
			else if (cell is CvsCellStatusLight cvsCellStatusLight)
			{
				valueSetter(cvsCellStatusLight.Value);
			}
			else
			{
				valueSetter(-1);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void RefreshFloatValue(Action<double> valueSetter, CvsCell cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (CellLocation.IsValid)
		{
			if (cell is CvsCellFloat cvsCellFloat)
			{
				valueSetter(cvsCellFloat.Value);
			}
			else
			{
				valueSetter(-1.0);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool YJwH11Te4e(CellViewModel P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (TWjsZA0AMj1q6j9rCSW())
		{
			num = 1;
		}
		else
		{
			num = 3;
			if (U8ui4H0RQq4d0hKX2TV())
			{
			}
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				return true;
			case 0:
			case 1:
				if (P_0 != null)
				{
					if (P_0 == this)
					{
						break;
					}
					goto default;
				}
				num = 4;
				continue;
			default:
				if (rdUNPHFwBAqKYm41vn5(DataType, P_0.DataType))
				{
					num = 5;
					continue;
				}
				break;
			case 5:
				return FARL07FJ8QWS3VoF14S(this, P_0);
			}
			break;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VD8Hzj9Lh8(CellType P_0, CellType P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_006f;
		IL_001a:
		if (!WEV4XmFaHIStiLx5VLZ(P_1))
		{
			num = 5;
			goto IL_006f;
		}
		goto IL_00a2;
		IL_00a2:
		return true;
		IL_006f:
		while (true)
		{
			switch (num)
			{
			case 0:
				if (P_0 != P_1)
				{
					U8ui4H0RQq4d0hKX2TV();
					if (TWjsZA0AMj1q6j9rCSW())
					{
						num = 4;
						if (true)
						{
							continue;
						}
						goto case 1;
					}
					num = 3;
					continue;
				}
				goto IL_00a2;
			case 1:
			case 4:
				if (WEV4XmFaHIStiLx5VLZ(P_0))
				{
					break;
				}
				goto case 5;
			case 5:
				return P_0 == CellType.Empty;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool InternalCanBeSourceProperty(CellViewModel other)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SuRwaP9gGT(CellViewModel P_0, bool P_1)
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
		goto IL_0067;
		IL_001a:
		CellViewModel previous = iSswR9X5eB;
		_ = 0;
		num = ((!TWjsZA0AMj1q6j9rCSW()) ? 5 : 0);
		goto IL_0067;
		IL_0067:
		PropertyValueChangedEventArgs<CellViewModel> args = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 3:
				OnSourcePropertyChanged(args);
				num = 6;
				continue;
			case 2:
			case 5:
				args = new PropertyValueChangedEventArgs<CellViewModel>(previous, iSswR9X5eB);
				goto case 3;
			default:
				num = 3;
				continue;
			case 0:
			case 1:
				if (SetField(ref iSswR9X5eB, P_0, (string)wPGJe00HhfQnM8r2VB0(28026)) & P_1)
				{
					goto case 2;
				}
				return;
			case 6:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnSourcePropertyChanged_003Ed__109))]
	protected virtual void OnSourcePropertyChanged(PropertyValueChangedEventArgs<CellViewModel> args)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003COnSourcePropertyChanged_003Ed__109 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.args = args;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReplacedWith(CellViewModel newCellVm)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		BtqwlSH07F?.Invoke(this, new PropertyValueChangedEventArgs<CellViewModel>(this, newCellVm));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteImmediateAsync_003Ed__117<>))]
	public Task WriteImmediateAsync<TDataType>(TDataType cellValue)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CWriteImmediateAsync_003Ed__117<TDataType> stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cellValue = cellValue;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteImmediateAsync_003Ed__118<>))]
	public static Task WriteImmediateAsync<TDataType>(CvsInSight insight, string cellName, TDataType cellValue)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CWriteImmediateAsync_003Ed__118<TDataType> stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine.insight = insight;
		stateMachine.cellName = cellName;
		stateMachine.cellValue = cellValue;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveReferences_003Ed__119))]
	internal virtual Task<IUndoAction> RemoveReferences(EzSnippet snippetToBeRemoved)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CRemoveReferences_003Ed__119 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IUndoAction>.Create();
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CellViewModel()
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
			default:
				bjBwFyTbXw = [MethodImpl(MethodImplOptions.NoInlining)] (CellViewModel _) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return true;
				};
				num = 6;
				if (TWjsZA0AMj1q6j9rCSW())
				{
					break;
				}
				goto case 1;
			case 1:
			case 2:
				qWewuONRsc = new HashSet<CellType>
				{
					CellType.Bool,
					CellType.Int,
					CellType.Float,
					CellType.String,
					CellType.Point,
					CellType.Circle,
					CellType.Line,
					CellType.Fixture,
					CellType.Patterns
				};
				goto default;
			case 5:
				Log = LogManager.GetLogger<CellViewModel>();
				TWjsZA0AMj1q6j9rCSW();
				num = ((!U8ui4H0RQq4d0hKX2TV()) ? 1 : 4);
				break;
			case 0:
				oTXQNJ0WKrFmQYYq58g();
				num = 5;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oTXQNJ0WKrFmQYYq58g()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IJKuYp0TqCIrhqNmHdd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseViewModel)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TWjsZA0AMj1q6j9rCSW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool U8ui4H0RQq4d0hKX2TV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aq7kxk0ySWPfbIVbk0U(object P_0, object P_1, bool init)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CellViewModel)P_0).RefreshComment((CvsCell)P_1, init);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DW4OwQ002gLQpChWmpE(object P_0, object P_1, bool init)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CellViewModel)P_0).RefreshCellName((CvsCell)P_1, init);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ibZnVQ0FuoSxLOUZNCJ(object P_0, object P_1, bool init)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CellViewModel)P_0).RefreshValue((CvsCell)P_1, init);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PvphqE0MOt34wmGN9t9(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XPXWO20Y5QUvERTHl2w(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pxkkMd0UcqkdhFtCEB2(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (EventArgs)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wPGJe00HhfQnM8r2VB0(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qCVG2m0xmyP5953Srdx(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HOto280mKMIB8CFiGh4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellComment)P_0).Text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static System.Drawing.Color MFEBHq0QmiN2m2xrVNm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellComment)P_0).FlagColor;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qLEnXX0NP4ZUumaK02A(object P_0, System.Windows.Media.Color P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SolidColorBrush)P_0).Color = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IfpLuH02nG8UmhZxudc(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DcUIUi0cwloISY5JrYJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).IsReadOnly;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uUwTp2018ws7BhIN9bq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Enabled;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MoH3lT0u6nLwtvK9jSq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).IsRuntimeModeValidForEditing;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool muVbDT0hOVqM1Al0Yeu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Error;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object R6WJ5m0tnkGxbVBR440(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).GetComment();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object u3Res20zmd4JNfql92H(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VucONsFLH1j5pS5VsqZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).IsLiveAcquisition;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cNbNPnFK1DHY9eDl5gB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).IsOnline;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CellType BY7XrrF583bjWWIVJLW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).DataType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rdUNPHFwBAqKYm41vn5(CellType P_0, CellType P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return VD8Hzj9Lh8(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FARL07FJ8QWS3VoF14S(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).InternalCanBeSourceProperty((CellViewModel)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WEV4XmFaHIStiLx5VLZ(CellType P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0.IsNumeric();
	}
}
