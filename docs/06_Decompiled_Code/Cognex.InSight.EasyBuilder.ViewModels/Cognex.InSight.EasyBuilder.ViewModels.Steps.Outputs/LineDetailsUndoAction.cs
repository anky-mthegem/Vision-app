using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Input;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.Runtime;
using Cognex.InSight.Undo;
using Cognex.Platform.IO.IDE.DiscreteIOSettings.ViewModels;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Outputs;

public class LineDetailsUndoAction : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDo_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LineDetailsUndoAction _003C_003E4__this;

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
			LineDetailsUndoAction lineDetailsUndoAction = default;
			TaskAwaiter awaiter = default;
			do
			{
				IL_01aa:
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					goto IL_01aa;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							fu8MSPKvZ4lFoqrCUP7v(lineDetailsUndoAction.E837LApGRw.OkCommand, null);
							num3 = 6;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
						}
						while (true)
						{
							switch (num3)
							{
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								break;
							case 0:
								awaiter = ((Task)coOXMLKvbr31ngM6w6t2(lineDetailsUndoAction.N1R70JDHaY)).GetAwaiter();
								num3 = 4;
								continue;
							case 2:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 3:
								_003C_003Eu__1 = default;
								goto case 2;
							case 1:
							case 5:
								return;
							case 6:
								fu8MSPKvZ4lFoqrCUP7v(USZ0KCKvBVLYCwewGCUJ(lineDetailsUndoAction.x8t7VKFVMT), null);
								num3 = 0;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								goto case 9;
							default:
								num3 = 9;
								continue;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								_ = 1;
								if (QL4OnmKvPEvT1i8Z6IIr())
								{
									num3 = 2;
									if (1 == 0)
									{
										return;
									}
								}
								else
								{
									num3 = 1;
									if (QL4OnmKvPEvT1i8Z6IIr())
									{
									}
								}
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
				case 5:
					lineDetailsUndoAction = _003C_003E4__this;
					QL4OnmKvPEvT1i8Z6IIr();
					if (!k8h1M8KvrIpKSlwaBo6a())
					{
						num = 1;
						goto IL_01aa;
					}
					num = 0;
					if (k8h1M8KvrIpKSlwaBo6a())
					{
						goto IL_01aa;
					}
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
			}
			while (k8h1M8KvrIpKSlwaBo6a());
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
		internal static bool fu8MSPKvZ4lFoqrCUP7v(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ICommand)P_0).SafeExecute(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object USZ0KCKvBVLYCwewGCUJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DIOSettingsViewModel)P_0).OkCommand;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object coOXMLKvbr31ngM6w6t2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IIoConfigurationService)P_0).SaveConfiguration();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool k8h1M8KvrIpKSlwaBo6a()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QL4OnmKvPEvT1i8Z6IIr()
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

		public LineDetailsUndoAction _003C_003E4__this;

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
			LineDetailsUndoAction lineDetailsUndoAction = default;
			TaskAwaiter awaiter = default;
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
							lineDetailsUndoAction.oav7Joy4ht.SetDetailsValue(vw4KY2KvSaWDRFdptcse(lineDetailsUndoAction.oav7Joy4ht));
							num3 = 2;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							YZaIeyKvodxCeNqd3SLe();
							if (!Wgnt2PKvGKTtMJvmOGtg())
							{
								num3 = 6;
							}
							else
							{
								num3 = 0;
								if (false)
								{
									goto IL_00f7;
								}
							}
						}
						goto IL_0074;
						IL_0074:
						while (true)
						{
							switch (num3)
							{
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								continue;
							case 4:
								_003C_003Eu__1 = awaiter;
								goto case 10;
							default:
								num3 = 10;
								continue;
							case 0:
							case 7:
								_003C_003Eu__1 = default;
								goto case 6;
							case 5:
								return;
							case 3:
								break;
							case 6:
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								continue;
							case 1:
								CrCkBpKv8uodnL0DyyCY(C88rBvKvqEjHuOHxyQVs(lineDetailsUndoAction.x8t7VKFVMT), null);
								awaiter = c1XNEoKvEHIfDgkcoli1(lineDetailsUndoAction.N1R70JDHaY.SaveConfiguration());
								num3 = 3;
								if (YZaIeyKvodxCeNqd3SLe())
								{
								}
								continue;
							case 2:
								CrCkBpKv8uodnL0DyyCY(yrntOGKvkxyJZcD85HDS(lineDetailsUndoAction.E837LApGRw), null);
								num3 = 1;
								if (!YZaIeyKvodxCeNqd3SLe())
								{
									continue;
								}
								goto case 9;
							case 9:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								continue;
							case 11:
								goto IL_018c;
							}
							break;
						}
						goto IL_00f7;
						IL_018c:
						awaiter.GetResult();
						goto end_IL_0018;
						IL_00f7:
						if (!awaiter.IsCompleted)
						{
							num3 = 9;
							goto IL_0074;
						}
						goto IL_018c;
						end_IL_0018:;
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
					lineDetailsUndoAction = _003C_003E4__this;
					Wgnt2PKvGKTtMJvmOGtg();
					num = ((!YZaIeyKvodxCeNqd3SLe()) ? 1 : 4);
					continue;
				case 5:
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
		internal static object vw4KY2KvSaWDRFdptcse(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DetailsChangedArgs)P_0).NewValue;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yrntOGKvkxyJZcD85HDS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((LineDetailsViewModel)P_0).OkCommand;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CrCkBpKv8uodnL0DyyCY(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ICommand)P_0).SafeExecute(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object C88rBvKvqEjHuOHxyQVs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DIOSettingsViewModel)P_0).OkCommand;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter c1XNEoKvEHIfDgkcoli1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Wgnt2PKvGKTtMJvmOGtg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YZaIeyKvodxCeNqd3SLe()
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

		public LineDetailsUndoAction _003C_003E4__this;

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
			LineDetailsUndoAction lineDetailsUndoAction = default;
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
							lineDetailsUndoAction.oav7Joy4ht.SetDetailsValue(X1iqY5Kv9dIUxqDl1tqd(lineDetailsUndoAction.oav7Joy4ht));
							num3 = 9;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 10;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								continue;
							default:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 3:
							case 4:
								num2 = (_003C_003E1__state = 0);
								goto default;
							case 9:
								((ICommand)USC1gmKv4MPSbj2vihFu(lineDetailsUndoAction.E837LApGRw)).SafeExecute();
								num3 = 1;
								continue;
							case 6:
								return;
							case 10:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								continue;
							case 7:
								if (awaiter.IsCompleted)
								{
									break;
								}
								TyP2sfKvp74xpxUmnbGC();
								if (Gno619KvX7P4jxS6NIDK())
								{
									num3 = 2;
									continue;
								}
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 1;
							case 1:
								uaP7mBKv3Xc8Scx7OYo9(qMuXyDKv7Csx12QjruIt(lineDetailsUndoAction.x8t7VKFVMT), null);
								num3 = 8;
								continue;
							case 8:
								awaiter = p5KXBJKv6ytQnTaq0S4d(bppD5nKvjICAZwhkkFP5(lineDetailsUndoAction.N1R70JDHaY));
								num3 = 7;
								continue;
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
				case 1:
				case 4:
					lineDetailsUndoAction = _003C_003E4__this;
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
					num2 = _003C_003E1__state;
					Gno619KvX7P4jxS6NIDK();
					if (!TyP2sfKvp74xpxUmnbGC())
					{
						num = 2;
						if (Gno619KvX7P4jxS6NIDK())
						{
						}
					}
					else
					{
						num = 4;
					}
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
		internal static object X1iqY5Kv9dIUxqDl1tqd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DetailsChangedArgs)P_0).OldValue;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object USC1gmKv4MPSbj2vihFu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((LineDetailsViewModel)P_0).OkCommand;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qMuXyDKv7Csx12QjruIt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DIOSettingsViewModel)P_0).OkCommand;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uaP7mBKv3Xc8Scx7OYo9(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ICommand)P_0).SafeExecute(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bppD5nKvjICAZwhkkFP5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IIoConfigurationService)P_0).SaveConfiguration();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter p5KXBJKv6ytQnTaq0S4d(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TyP2sfKvp74xpxUmnbGC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Gno619KvX7P4jxS6NIDK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly Dictionary<string, object> S6d7tkTeZd;

	private readonly Dictionary<string, object> WNr7Yw1YZo;

	private readonly IIoConfigurationService N1R70JDHaY;

	private readonly DIOSettingsViewModel x8t7VKFVMT;

	private readonly LineDetailsViewModel E837LApGRw;

	private readonly DetailsChangedArgs oav7Joy4ht;

	[CompilerGenerated]
	private readonly string M1379tSSNc;

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
			return M1379tSSNc;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LineDetailsUndoAction(IIoConfigurationService configService, DIOSettingsViewModel dioSettings, LineDetailsViewModel lineDetails, DetailsChangedArgs changedArgs, string text = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!ggaBexiaQAuQrkfa5Lj())
		{
			num = 6;
		}
		else
		{
			num = 5;
			if (ggaBexiaQAuQrkfa5Lj())
			{
			}
		}
		while (true)
		{
			switch (num)
			{
			case 8:
				WNr7Yw1YZo = new Dictionary<string, object>();
				num = 2;
				break;
			case 7:
				N1R70JDHaY = configService;
				goto case 9;
			default:
				num = 9;
				break;
			case 0:
			case 6:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				goto case 1;
			case 2:
				base._002Ector();
				num = 7;
				break;
			case 4:
				E837LApGRw = lineDetails;
				num = 3;
				break;
			case 9:
				x8t7VKFVMT = dioSettings;
				num = 4;
				break;
			case 3:
				oav7Joy4ht = changedArgs;
				num = 10;
				break;
			case 1:
			case 5:
				S6d7tkTeZd = new Dictionary<string, object>();
				num = 8;
				break;
			case 10:
				M1379tSSNc = text ?? string.Format(Resources.pd1hOYqP56(), WrtXOuievZOovpg1N7g(changedArgs), c33aDPiO2PPSNyH5puC(changedArgs), YLykWmiI2L7bF2KKs5i(changedArgs));
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)ncQnZ2iDvDo9X8DvUEr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__8))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = (lZRIaOiJHmdHjeQb38J() ? 1 : 5);
		_003CDo_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = EvQvxSiigcMjLiHeYeF();
				num = 2;
				if (0 == 0)
				{
					break;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__9))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!lZRIaOiJHmdHjeQb38J()) ? 5 : 4);
		_003CRedo_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = EvQvxSiigcMjLiHeYeF();
				num = 1;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 2;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
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
	[AsyncStateMachine(typeof(_003CUndo_003Ed__10))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (ggaBexiaQAuQrkfa5Lj() ? 5 : 3);
		_003CUndo_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = EvQvxSiigcMjLiHeYeF();
				num = 1;
				break;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WrtXOuievZOovpg1N7g(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((DetailsChangedArgs)P_0).PropertyDisplayName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object c33aDPiO2PPSNyH5puC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((DetailsChangedArgs)P_0).OldValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YLykWmiI2L7bF2KKs5i(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((DetailsChangedArgs)P_0).NewValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lZRIaOiJHmdHjeQb38J()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ggaBexiaQAuQrkfa5Lj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ncQnZ2iDvDo9X8DvUEr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder EvQvxSiigcMjLiHeYeF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
