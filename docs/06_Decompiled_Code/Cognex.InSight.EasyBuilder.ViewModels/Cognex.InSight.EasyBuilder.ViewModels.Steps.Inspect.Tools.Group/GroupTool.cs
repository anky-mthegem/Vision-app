using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Composition;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Input;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Common.Commands;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.UndoableActions;
using Cognex.InSight.Undo;
using Cognex.Mvvm;
using IXHqQxfoEA8Uykucse;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Group;

[Export(typeof(GroupTool))]
public class GroupTool : EzTool
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDoAddChildToolAsync_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public object obj;

		public GroupTool _003C_003E4__this;

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
			if (!krkrPZKMBO4LdTivYBIw())
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
			}
			goto IL_0189;
			IL_01dc:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (false)
			{
				return;
			}
			goto IL_0189;
			IL_0189:
			GroupTool groupTool = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				default:
					num = 5;
					continue;
				case 1:
				case 2:
					groupTool = _003C_003E4__this;
					num = 4;
					continue;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 5:
					goto IL_01dc;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			try
			{
				EzTool ezTool = default;
				int num3;
				TaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					ezTool = obj as EzTool;
					_ = 1;
					num3 = (krkrPZKMBO4LdTivYBIw() ? 1 : 3);
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 2;
					if (1 == 0)
					{
						goto IL_00e6;
					}
				}
				goto IL_007a;
				IL_007a:
				while (true)
				{
					switch (num3)
					{
					case 6:
						num2 = (_003C_003E1__state = 0);
						num3 = 9;
						continue;
					case 9:
						_003C_003Eu__1 = awaiter;
						goto default;
					case 5:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						continue;
					case 7:
						return;
					case 0:
					case 3:
						break;
					case 8:
						if (!awaiter.IsCompleted)
						{
							num3 = 6;
							continue;
						}
						goto case 10;
					default:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 7;
						continue;
					case 2:
						_003C_003Eu__1 = default;
						num3 = 5;
						continue;
					case 10:
						awaiter.GetResult();
						goto end_IL_007a;
					}
					goto IL_00e6;
					continue;
					end_IL_007a:
					break;
				}
				goto end_IL_0026;
				IL_00e6:
				if (ezTool != null)
				{
					awaiter = qcJPXfKMbf1d9NAs52Iq(groupTool.AddChildToolAsync(ezTool));
					num3 = 8;
					goto IL_007a;
				}
				end_IL_0026:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01dc;
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
		internal static TaskAwaiter qcJPXfKMbf1d9NAs52Iq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lJsq5hKMZbuQ4C787fn2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool krkrPZKMBO4LdTivYBIw()
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
	private struct _003CDoRemoveChildToolAsync_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public object obj;

		public GroupTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!z3WKNlKMGlbSYyhg5wWd()) ? 5 : 4);
			int num2 = default;
			EzTool ezTool = default;
			TaskAwaiter awaiter = default;
			GroupTool groupTool = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							ezTool = obj as EzTool;
							num3 = 7;
							if (s7vWbSKMo3tSEVT1I1M7())
							{
								goto IL_0046;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
						}
						goto IL_0110;
						IL_0110:
						while (true)
						{
							switch (num3)
							{
							case 7:
								break;
							case 4:
								awaiter = b5gssAKMSvFS0ai9Y5Q2(groupTool.RemoveChildToolAsync(ezTool));
								s7vWbSKMo3tSEVT1I1M7();
								if (z3WKNlKMGlbSYyhg5wWd())
								{
									num3 = 0;
									continue;
								}
								num3 = 5;
								if (s7vWbSKMo3tSEVT1I1M7())
								{
								}
								continue;
							case 0:
							case 2:
								if (!awaiter.IsCompleted)
								{
									goto case 3;
								}
								goto case 10;
							case 8:
								return;
							case 1:
								_003C_003Eu__1 = awaiter;
								num3 = 9;
								if (!s7vWbSKMo3tSEVT1I1M7())
								{
									continue;
								}
								goto case 6;
							case 6:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (!s7vWbSKMo3tSEVT1I1M7())
								{
									continue;
								}
								goto case 3;
							case 3:
							case 5:
								num2 = (_003C_003E1__state = 0);
								goto case 1;
							default:
								num3 = 1;
								if (z3WKNlKMGlbSYyhg5wWd())
								{
									continue;
								}
								goto case 9;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								continue;
							case 10:
								awaiter.GetResult();
								goto end_IL_0110;
							}
							goto IL_0046;
							continue;
							end_IL_0110:
							break;
						}
						goto end_IL_0024;
						IL_0046:
						if (ezTool != null)
						{
							num3 = 4;
							goto IL_0110;
						}
						end_IL_0024:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 1;
				default:
					num = 1;
					break;
				case 1:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 3;
				case 3:
					groupTool = _003C_003E4__this;
					goto case 2;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 3;
					if (1 == 0)
					{
						return;
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
		internal static TaskAwaiter b5gssAKMSvFS0ai9Y5Q2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool z3WKNlKMGlbSYyhg5wWd()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool s7vWbSKMo3tSEVT1I1M7()
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
	private struct _003CInternalPostParse_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public GroupTool _003C_003E4__this;

		public CvsCellCollection cells;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!ANS5eDKMkmsMUcBCTcfX()) ? 1 : 4);
			int num2 = default;
			GroupTool groupTool = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 3;
					break;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 3:
					groupTool = _003C_003E4__this;
					goto case 1;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							groupTool.nnG4uPQKIR(cells);
							num3 = 2;
							goto IL_00c7;
						}
						awaiter = _003C_003Eu__1;
						goto IL_014d;
						IL_014d:
						_003C_003Eu__1 = default;
						num3 = 0;
						goto IL_00c7;
						IL_00c7:
						while (true)
						{
							switch (num3)
							{
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 7:
								return;
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 4;
							default:
								num3 = 4;
								continue;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 7;
								if (kJ0QuWKM8IdqTWudRq7O())
								{
								}
								continue;
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 1:
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								goto case 10;
							case 6:
							case 9:
								break;
							case 2:
								awaiter = tqXg8GKMqSnF4KWuQfND(groupTool.YqJ4Iyu5yD(cells));
								kJ0QuWKM8IdqTWudRq7O();
								num3 = (ANS5eDKMkmsMUcBCTcfX() ? 3 : 9);
								continue;
							case 10:
								awaiter.GetResult();
								goto end_IL_00c7;
							}
							goto IL_014d;
							continue;
							end_IL_00c7:
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
		internal static TaskAwaiter tqXg8GKMqSnF4KWuQfND(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ANS5eDKMkmsMUcBCTcfX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kJ0QuWKM8IdqTWudRq7O()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public List<EzSnippet> dependentSnippets;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass40_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			weLgVKKMXsPUSLpnw1tC();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CRefreshAvailableTools_003Eb__0(EzTool tool)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (!(tool is GroupTool) && !mjxnXlKM9G041qJxHK7y(tool))
			{
				return !dependentSnippets.Contains(tool);
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void weLgVKKMXsPUSLpnw1tC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VAjk41KMEbLPHgmDGJl9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cqFEt8KMpeQcl96ATjAD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mjxnXlKM9G041qJxHK7y(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).IsGrouped;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddChildToolAsync_003Ed__50 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzTool tool;

		public GroupTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!TmyeWAKM4XpADNNWqdSE()) ? 4 : 2);
			int num2 = default;
			GroupTool groupTool = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 4:
					groupTool = _003C_003E4__this;
					num = 3;
					if (0 == 0)
					{
						break;
					}
					goto case 3;
				case 3:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 7;
							goto IL_009e;
						}
						if (!(tool is GroupTool))
						{
							num3 = 2;
							goto IL_009e;
						}
						goto end_IL_0063;
						IL_009e:
						while (true)
						{
							switch (num3)
							{
							case 1:
								num2 = (_003C_003E1__state = 0);
								goto default;
							default:
								TmyeWAKM4XpADNNWqdSE();
								if (!ijstfdKM7gmFjOJAxHqi())
								{
									num3 = 0;
									continue;
								}
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								break;
							case 0:
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 5;
								continue;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 2:
								if (cG2ZtlKM3aS7Iu0cEG16(tool))
								{
									num3 = 3;
									continue;
								}
								awaiter = ((Task)dHBHPiKM6uWYIoxyEgWq(yVG1HlKMj93mWdRSxp9p(groupTool.InSight), groupTool.XeB4oTLdIf(tool))).GetAwaiter();
								num3 = 8;
								continue;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								break;
							case 6:
								return;
							case 9:
								return;
							case 3:
								goto end_IL_009e;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 10:
								break;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_009e:
							break;
						}
						end_IL_0063:;
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
					if (1 == 0)
					{
						return;
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
		internal static bool cG2ZtlKM3aS7Iu0cEG16(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).IsGrouped;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yVG1HlKMj93mWdRSxp9p(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dHBHPiKM6uWYIoxyEgWq(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TmyeWAKM4XpADNNWqdSE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ijstfdKM7gmFjOJAxHqi()
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
	private struct _003CRemoveChildToolAsync_003Ed__53 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public GroupTool _003C_003E4__this;

		public EzTool tool;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (sTA6uHKMAcDIiFvcDM0P() ? 1 : 2);
			int num2 = default;
			GroupTool groupTool = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (!groupTool.Children.Contains(tool))
							{
								sTA6uHKMAcDIiFvcDM0P();
								num3 = ((!iWe8YkKMCAcVnkLjvjS6()) ? 9 : 6);
							}
							else
							{
								awaiter = GZ3oPTKMWhcuILm5CoS8(((UndoRedoQueue)av8WmVKMR0MBPNfXgNZ7(groupTool.InSight)).AddUndo(groupTool.pM04DybHJZ(tool)));
								num3 = 8;
								if (1 == 0)
								{
									goto IL_0100;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
						}
						goto IL_0088;
						IL_0100:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 4;
						goto IL_0088;
						IL_0088:
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 9:
								_003C_003Eu__1 = awaiter;
								break;
							default:
								num3 = 7;
								if (sTA6uHKMAcDIiFvcDM0P())
								{
								}
								continue;
							case 0:
							case 6:
								goto end_IL_0088;
							case 7:
								break;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								goto case 10;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 1;
								continue;
							case 4:
								return;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 5:
								num2 = (_003C_003E1__state = 0);
								goto case 3;
							case 10:
								awaiter.GetResult();
								goto end_IL_0088;
							}
							goto IL_0100;
							continue;
							end_IL_0088:
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
				case 4:
					groupTool = _003C_003E4__this;
					num = 5;
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 4;
					if (1 == 0)
					{
						return;
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
		internal static object av8WmVKMR0MBPNfXgNZ7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter GZ3oPTKMWhcuILm5CoS8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iWe8YkKMCAcVnkLjvjS6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sTA6uHKMAcDIiFvcDM0P()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private BoolViewModel i3h4gQlgkt;

	[CompilerGenerated]
	private FloatViewModel PC24MAEidq;

	[CompilerGenerated]
	private readonly ICommand Chd4RDACRP;

	[CompilerGenerated]
	private readonly ICommand n4L44ipnqD;

	private InternalCheckBoxViewModel ADJ4lViWmX;

	private IList<EzTool> x5C4TCEZ5G;

	private IList<EzTool> mJA4WFU75g;

	public BoolViewModel ToolsPass
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return i3h4gQlgkt;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			i3h4gQlgkt = value;
		}
	}

	public FloatViewModel ToolExecutionTimes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PC24MAEidq;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			PC24MAEidq = value;
		}
	}

	public override string ImagePath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Tools_GroupIcon;
		}
	}

	public override bool AllowsAnyImageAsInput
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public ICommand AddToolCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Chd4RDACRP;
		}
	}

	public ICommand RemoveToolCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return n4L44ipnqD;
		}
	}

	public override bool IsCollapsibleParent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}
	}

	public override bool IsCollapsed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return base.IsCollapsed;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			jTWp8f7zhexkelPhMbX();
			int num;
			if (LKBjrt7tLGfgWA15v2X())
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 2;
			}
			goto IL_005f;
			IL_0046:
			base.IsCollapsed = value;
			goto IL_0086;
			IL_005f:
			IEnumerator<EzTool> enumerator = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					break;
				case 1:
				case 2:
					goto IL_0046;
				default:
					num = 3;
					continue;
				case 3:
					goto IL_0086;
				case 5:
					try
					{
						while (FrS4RY3eumblmPdCb1D(enumerator))
						{
							RxSJ9w3atDA9eKgVjuN(enumerator.Current, value);
						}
						return;
					}
					finally
					{
						if (enumerator != null)
						{
							ptbWkX3OMhCRlP6nRry(enumerator);
						}
					}
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			if (value != GRqG483JkrhUq3Qvqsb(this))
			{
				goto IL_0046;
			}
			return;
			IL_0086:
			enumerator = Children.GetEnumerator();
			num = 5;
			goto IL_005f;
		}
	}

	public IList<EzTool> AvailableTools
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return x5C4TCEZ5G;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref x5C4TCEZ5G, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(25424));
		}
	}

	public IList<EzTool> Children
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mJA4WFU75g;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref mJA4WFU75g, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(25456)))
			{
				DeleteCommand.RaiseCanExecuteChanged();
				CopyCommand.RaiseCanExecuteChanged();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GroupTool(InspectStepViewModel inspect, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		do
		{
			IL_0042:
			switch (num)
			{
			case 2:
			case 3:
				Chd4RDACRP = new AsyncRelayCommand<object>(Lu64NXbnKn);
				break;
			default:
				num = 4;
				if (0 == 0)
				{
					goto IL_0042;
				}
				goto case 5;
			case 5:
				lRRBmp3LpFFARZkMSKx();
				LKBjrt7tLGfgWA15v2X();
				num = (jTWp8f7zhexkelPhMbX() ? 3 : 0);
				goto IL_0042;
			case 0:
			case 1:
				base._002Ector(inspect, isInitialized);
				goto case 2;
			case 4:
				break;
			case 6:
				return;
			}
			n4L44ipnqD = new AsyncRelayCommand<object>(VY74AeZih8);
			num = 6;
		}
		while (true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnParentChanging()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (Parent != null)
		{
			ITS20s3KaDmjY8QaKWW(Parent.Tools, new NotifyCollectionChangedEventHandler(jxI46dPDrU));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnParentChanged()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (Parent != null)
		{
			bVyBCP35HTSeNuJ3jgs(Parent.Tools, new NotifyCollectionChangedEventHandler(jxI46dPDrU));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool CanCopy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetViewableEditGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Array.Empty<CvsEditableDisplayGraphic>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoAddChildToolAsync_003Ed__20))]
	private Task Lu64NXbnKn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003CDoAddChildToolAsync_003Ed__20 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 4;
				break;
			case 2:
				stateMachine.obj = P_0;
				goto default;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 6:
				stateMachine._003C_003Et__builder = zNhBB63wdMG7mZNDriR();
				_ = 0;
				num = (LKBjrt7tLGfgWA15v2X() ? 5 : 0);
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoRemoveChildToolAsync_003Ed__24))]
	private Task VY74AeZih8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CDoRemoveChildToolAsync_003Ed__24 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine.obj = P_0;
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 0;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003Et__builder = zNhBB63wdMG7mZNDriR();
				_ = 0;
				num = (LKBjrt7tLGfgWA15v2X() ? 6 : 4);
				break;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 1:
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalPreParse()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		eaV4ct9Gm3(Focus);
		base.InternalPreParse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInternalPostParse_003Ed__31))]
	protected override Task InternalPostParse(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CInternalPostParse_003Ed__31 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 3;
				break;
			case 2:
			case 6:
				stateMachine.cells = cells;
				goto case 4;
			default:
				num = 4;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				jTWp8f7zhexkelPhMbX();
				num = ((!LKBjrt7tLGfgWA15v2X()) ? 6 : 0);
				break;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalParseCell(string relativeCellName, CvsCellCollection cells, CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 5:
				AddProperty(ToolExecutionTimes);
				num = 8;
				if (!LKBjrt7tLGfgWA15v2X())
				{
					return;
				}
				break;
			case 3:
				return;
			case 4:
				if (!lqmZxx3ImFKR7dQV1G0(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(25326)))
				{
					LKBjrt7tLGfgWA15v2X();
					if (!jTWp8f7zhexkelPhMbX())
					{
						num = 6;
						break;
					}
					num = 0;
					if (1 == 0)
					{
						return;
					}
				}
				else
				{
					ToolsPass = new BoolViewModel(InSight, cells, loc, (string)Yub5dT3i6qhphkB9riV());
					num = 7;
				}
				break;
			case 1:
			case 6:
				if (lqmZxx3ImFKR7dQV1G0(relativeCellName, M18c293DEQmbbwJ2qw0(25366)))
				{
					ToolExecutionTimes = new FloatViewModel(InSight, cells, loc, (string)za4O0T3nQHbm0hks6Jo());
					num = 5;
					break;
				}
				return;
			case 2:
				return;
			case 0:
				return;
			case 7:
				AddProperty(ToolsPass);
				return;
			default:
				num = 3;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private InternalCheckBoxViewModel S2n4bkpr3f()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ADJ4lViWmX;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private void eaV4ct9Gm3(InternalCheckBoxViewModel value)
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
				pwUd6Q3VnaZ2HWEi3bJ(ADJ4lViWmX, new PropertyChangedEventHandler(hyJ4daXqhC));
				goto case 2;
			case 2:
			case 3:
				ADJ4lViWmX = value;
				goto case 4;
			default:
				num = 4;
				break;
			case 4:
				if (ADJ4lViWmX != null)
				{
					num = 6;
					break;
				}
				return;
			case 0:
				if (ADJ4lViWmX != null)
				{
					_ = 0;
					if (LKBjrt7tLGfgWA15v2X())
					{
						num = 5;
						break;
					}
					num = 3;
					if (!jTWp8f7zhexkelPhMbX())
					{
						break;
					}
				}
				goto case 2;
			case 6:
				X2wMC53fpLhET0t84gE(ADJ4lViWmX, new PropertyChangedEventHandler(hyJ4daXqhC));
				num = 7;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void hyJ4daXqhC(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		jTWp8f7zhexkelPhMbX();
		int num;
		if (LKBjrt7tLGfgWA15v2X())
		{
			num = 2;
			if (!LKBjrt7tLGfgWA15v2X())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_008b;
		IL_0069:
		if (CINyJO3lvWOEsNadmwy(S2n4bkpr3f()))
		{
			goto IL_0058;
		}
		return;
		IL_008b:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				break;
			case 3:
				goto IL_0058;
			case 1:
			case 4:
				goto IL_0069;
			default:
				num = 3;
				if (true)
				{
					continue;
				}
				return;
			case 5:
				return;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		if ((string)Y5Jc2o3dSshcOBUPtYo(P_1) == (string)M18c293DEQmbbwJ2qw0(5436))
		{
			goto IL_0069;
		}
		return;
		IL_0058:
		nnG4uPQKIR();
		num = 5;
		goto IL_008b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void jxI46dPDrU(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		NotifyCollectionChangedAction notifyCollectionChangedAction = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				notifyCollectionChangedAction = JM5j783gNbwekCI8eZq(P_1);
				jTWp8f7zhexkelPhMbX();
				num = (LKBjrt7tLGfgWA15v2X() ? 3 : 0);
				break;
			case 1:
			case 3:
				switch (notifyCollectionChangedAction)
				{
				default:
					return;
				case NotifyCollectionChangedAction.Add:
				case NotifyCollectionChangedAction.Remove:
				case NotifyCollectionChangedAction.Replace:
				case NotifyCollectionChangedAction.Reset:
					nnG4uPQKIR();
					num = 5;
					break;
				case NotifyCollectionChangedAction.Move:
					return;
				}
				break;
			default:
				return;
			case 0:
				return;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void nnG4uPQKIR(CvsCellCollection P_0 = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!LKBjrt7tLGfgWA15v2X()) ? 4 : 3);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				if (P_0 == null)
				{
					num = 1;
					if (true)
					{
						continue;
					}
					break;
				}
				goto case 2;
			case 5:
				break;
			case 2:
			case 4:
				rlc4F5r1k6(P_0);
				break;
			default:
				num = 5;
				if (!jTWp8f7zhexkelPhMbX())
				{
					continue;
				}
				goto case 1;
			case 1:
				P_0 = (CvsCellCollection)YKHgig3sPxlqNxbrMBe(InSight.Results);
				goto case 2;
			case 6:
				return;
			}
			CIk4X3tXhd(P_0);
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rlc4F5r1k6(CvsCellCollection P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!LKBjrt7tLGfgWA15v2X()) ? 6 : 4);
		_003C_003Ec__DisplayClass40_0 obj = default;
		IEnumerator<EzTool> enumerator = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				AvailableTools = Parent.Tools.Where(obj._003CRefreshAvailableTools_003Eb__0).ToList();
				num = 7;
				if (jTWp8f7zhexkelPhMbX())
				{
				}
				break;
			case 5:
				try
				{
					while (FrS4RY3eumblmPdCb1D(enumerator))
					{
						feUJhw3vcCGP6lTpOrS(enumerator.Current, P_0);
					}
				}
				finally
				{
					if (enumerator != null)
					{
						ptbWkX3OMhCRlP6nRry(enumerator);
					}
				}
				obj.dependentSnippets = GetDependentSnippets(recursive: true, P_0);
				num = 2;
				break;
			case 0:
			case 4:
				obj = new _003C_003Ec__DisplayClass40_0();
				goto case 1;
			case 1:
			case 6:
				if (Parent == null)
				{
					num = 3;
					break;
				}
				enumerator = Parent.Tools.GetEnumerator();
				goto case 5;
			case 3:
				return;
			default:
				num = 5;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CIk4X3tXhd(CvsCellCollection P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		string[] array = default;
		int num2 = default;
		CvsCellLocation cvsCellLocation = default;
		EzTool ezTool = default;
		List<EzTool> list = default;
		do
		{
			IL_00b3:
			switch (num)
			{
			case 2:
			{
				CvsCell cvsCell = P_0[PqSDuD3rlc3jDLuPP59(ToolsPass)];
				if (cvsCell == null)
				{
					num = 3;
				}
				else
				{
					array = (string[])U3am6o3ZrfvtNaGwevD(VRTdjW3PdkaUbIsQXAr(cvsCell), new char[1] { '&' }, StringSplitOptions.RemoveEmptyEntries);
					num = 5;
				}
				goto IL_00b3;
			}
			case 5:
				num2 = 0;
				num = 11;
				if (LKBjrt7tLGfgWA15v2X())
				{
					goto IL_00b3;
				}
				goto case 12;
			case 12:
				if (cvsCellLocation.IsValid)
				{
					num = 13;
					goto IL_00b3;
				}
				break;
			case 6:
				RxSJ9w3atDA9eKgVjuN(ezTool, GRqG483JkrhUq3Qvqsb(this));
				num = 4;
				goto IL_00b3;
			case 13:
				ezTool = (EzTool)zo9A3T3bxu5NKhKeMNR(Parent, cvsCellLocation);
				goto default;
			default:
				_ = 1;
				if (!jTWp8f7zhexkelPhMbX())
				{
					num = 10;
				}
				else
				{
					num = 9;
					if (jTWp8f7zhexkelPhMbX())
					{
						return;
					}
				}
				goto IL_00b3;
			case 8:
			case 9:
				list.Add(ezTool);
				num = 6;
				goto IL_00b3;
			case 0:
			case 11:
				if (num2 < array.Length)
				{
					cvsCellLocation = RiL0qt3B8bYgYMYi1Qc(array[num2]);
					num = 12;
				}
				else
				{
					Children = list;
					num = 14;
				}
				goto IL_00b3;
			case 1:
				list = new List<EzTool>();
				num = 2;
				if (LKBjrt7tLGfgWA15v2X())
				{
					goto IL_00b3;
				}
				goto case 7;
			case 7:
			case 10:
				if (ezTool == null)
				{
					break;
				}
				goto case 8;
			case 3:
				return;
			case 4:
				break;
			case 14:
				return;
			}
			num2++;
			num = 0;
		}
		while (!jTWp8f7zhexkelPhMbX());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddChildToolAsync_003Ed__50))]
	public Task AddChildToolAsync(EzTool tool)
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
		goto IL_0034;
		IL_001a:
		_003CAddChildToolAsync_003Ed__50 stateMachine = default;
		stateMachine.tool = tool;
		goto IL_0081;
		IL_0034:
		while (true)
		{
			switch (num)
			{
			case 2:
			case 6:
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			default:
				goto IL_0081;
			case 5:
				stateMachine._003C_003E4__this = this;
				jTWp8f7zhexkelPhMbX();
				if (!LKBjrt7tLGfgWA15v2X())
				{
					num = 1;
					continue;
				}
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
				stateMachine._003C_003Et__builder = zNhBB63wdMG7mZNDriR();
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 7;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
		IL_0081:
		stateMachine._003C_003E1__state = -1;
		num = 4;
		goto IL_0034;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IUndoAction XeB4oTLdIf(EzTool P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		UndoActionList actions = new UndoActionList((string)ADx5Gv3SqB6Pmpoflkp(vkr2jN3GC1gQoOQyAlt(), LkxqMy3oWSMtQPdvU41(P_0), LkxqMy3oWSMtQPdvU41(this)), new UndoCompositeCellExpressionChange(Parent, (string)VuniTr3ktS2r58AwSxA(ToolsPass), (string)M18c293DEQmbbwJ2qw0(18708), (string)VuniTr3ktS2r58AwSxA(OFl2i138LruIZs9uaRy(P_0)), append: true), new UndoCompositeCellExpressionChange(Parent, (string)VuniTr3ktS2r58AwSxA(ToolExecutionTimes), CdQUGaROfy7He9T0foW.KbIzwHEDLa(25476), (string)VuniTr3ktS2r58AwSxA(SfdFaH3qpTI59BIktLh(P_0)), append: true), new UndoAddLink(Parent.AppViewModel.PropertyLinks, (string)VuniTr3ktS2r58AwSxA(YEahEJ3EKPCuJFbMbDW(P_0)), (string)VuniTr3ktS2r58AwSxA(Enabled)), new UndoAddLink((PropertyLinks)FOCZIs3X0K1CbPIDL4S(eJM7pc3pkjSOFgr5POy(Parent)), (string)VuniTr3ktS2r58AwSxA(uVHVfT39CSLhhcMNtfL(P_0)), (string)VuniTr3ktS2r58AwSxA(ShowGraphics)), new UndoAddLink((PropertyLinks)FOCZIs3X0K1CbPIDL4S(eJM7pc3pkjSOFgr5POy(Parent)), (string)VuniTr3ktS2r58AwSxA(P_0.ShowResults), ShowResults.CellName), ijF4SruIuM(P_0));
		return new GroupToolUndoAction(Parent, Name, P_0.Name, actions, isAdding: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private L3xsfUdIkfTQrRcPb8 ijF4SruIuM(EzTool P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		int num3 = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				num3++;
				num = 6;
				continue;
			case 1:
			case 4:
				num3 = Parent.Snippets.IndexOf(this) + Children.Count();
				goto case 0;
			case 5:
				num2 = Parent.Snippets.IndexOf(P_0);
				_ = 0;
				num = (LKBjrt7tLGfgWA15v2X() ? 4 : 0);
				continue;
			case 0:
			case 2:
				if (num2 <= num3)
				{
					break;
				}
				goto case 3;
			default:
				num = 3;
				continue;
			case 6:
				break;
			}
			break;
		}
		return new L3xsfUdIkfTQrRcPb8(Parent, num2, num3, (string)eCwMOJ37J2WSgIjZKZX(RWHtl934bVcilESrb1G(), LkxqMy3oWSMtQPdvU41(P_0)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveChildToolAsync_003Ed__53))]
	public Task RemoveChildToolAsync(EzTool tool)
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
		goto IL_005a;
		IL_001a:
		_003CRemoveChildToolAsync_003Ed__53 stateMachine = default;
		stateMachine._003C_003Et__builder = zNhBB63wdMG7mZNDriR();
		LKBjrt7tLGfgWA15v2X();
		if (!jTWp8f7zhexkelPhMbX())
		{
			num = 4;
		}
		else
		{
			num = 2;
			if (1 == 0)
			{
				goto IL_0091;
			}
		}
		goto IL_005a;
		IL_0091:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 7;
		goto IL_005a;
		IL_005a:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 0:
				stateMachine.tool = tool;
				goto default;
			case 6:
				goto IL_0091;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 0;
				continue;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				if (LKBjrt7tLGfgWA15v2X())
				{
					continue;
				}
				goto case 7;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IUndoAction pM04DybHJZ(EzTool P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		UndoActionList actions = new UndoActionList((string)ADx5Gv3SqB6Pmpoflkp(CVhNEn331Ptu4shtQLP(), LkxqMy3oWSMtQPdvU41(P_0), Name), z7843iUArR(P_0), new UndoRemoveLink((PropertyLinks)FOCZIs3X0K1CbPIDL4S(eJM7pc3pkjSOFgr5POy(Parent)), (string)VuniTr3ktS2r58AwSxA(lFCFBg3jQIfarrryTiZ(P_0))), new UndoRemoveLink(((EasyBuilderApplicationViewModel)eJM7pc3pkjSOFgr5POy(Parent)).PropertyLinks, (string)VuniTr3ktS2r58AwSxA(P_0.ShowGraphics)), new UndoRemoveLink((PropertyLinks)FOCZIs3X0K1CbPIDL4S(eJM7pc3pkjSOFgr5POy(Parent)), (string)VuniTr3ktS2r58AwSxA(YEahEJ3EKPCuJFbMbDW(P_0))), new UndoCompositeCellExpressionChange(Parent, ToolExecutionTimes.CellName, (string)M18c293DEQmbbwJ2qw0(25476), (string)VuniTr3ktS2r58AwSxA(P_0.ExecutionTime), append: false), new UndoCompositeCellExpressionChange(Parent, (string)VuniTr3ktS2r58AwSxA(ToolsPass), CdQUGaROfy7He9T0foW.KbIzwHEDLa(18708), (string)VuniTr3ktS2r58AwSxA(OFl2i138LruIZs9uaRy(P_0)), append: false));
		return new GroupToolUndoAction(Parent, (string)LkxqMy3oWSMtQPdvU41(this), (string)LkxqMy3oWSMtQPdvU41(P_0), actions, isAdding: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IUndoAction z7843iUArR(EzTool P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = Parent.Snippets.IndexOf(P_0);
		int num2 = Parent.Snippets.IndexOf(this) + Children.Count();
		return new L3xsfUdIkfTQrRcPb8(Parent, num, num2, (string)eCwMOJ37J2WSgIjZKZX(RWHtl934bVcilESrb1G(), LkxqMy3oWSMtQPdvU41(P_0)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task YqJ4Iyu5yD(CvsCellCollection P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.InternalPostParse(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lRRBmp3LpFFARZkMSKx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LKBjrt7tLGfgWA15v2X()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jTWp8f7zhexkelPhMbX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ITS20s3KaDmjY8QaKWW(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((INotifyCollectionChanged)P_0).CollectionChanged -= (NotifyCollectionChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bVyBCP35HTSeNuJ3jgs(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((INotifyCollectionChanged)P_0).CollectionChanged += (NotifyCollectionChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder zNhBB63wdMG7mZNDriR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GRqG483JkrhUq3Qvqsb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzTool)P_0).IsCollapsed;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RxSJ9w3atDA9eKgVjuN(object P_0, bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzTool)P_0).IsCollapsed = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FrS4RY3eumblmPdCb1D(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ptbWkX3OMhCRlP6nRry(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lqmZxx3ImFKR7dQV1G0(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object M18c293DEQmbbwJ2qw0(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Yub5dT3i6qhphkB9riV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.cnurzp4TWS();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object za4O0T3nQHbm0hks6Jo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.XjsrhG47qf();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pwUd6Q3VnaZ2HWEi3bJ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void X2wMC53fpLhET0t84gE(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Y5Jc2o3dSshcOBUPtYo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertyChangedEventArgs)P_0).PropertyName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CINyJO3lvWOEsNadmwy(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((InternalCheckBoxViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static NotifyCollectionChangedAction JM5j783gNbwekCI8eZq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((NotifyCollectionChangedEventArgs)P_0).Action;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YKHgig3sPxlqNxbrMBe(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsResultSet)P_0).Cells;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void feUJhw3vcCGP6lTpOrS(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzTool)P_0).X62dzvTlqd((CvsCellCollection)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation PqSDuD3rlc3jDLuPP59(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VRTdjW3PdkaUbIsQXAr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object U3am6o3ZrfvtNaGwevD(object P_0, object P_1, StringSplitOptions P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Split((char[])P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation RiL0qt3B8bYgYMYi1Qc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.TryParse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zo9A3T3bxu5NKhKeMNR(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((InspectStepViewModel)P_0).WrlAbkIDX4(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vkr2jN3GC1gQoOQyAlt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.t3WGmGCSwN();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LkxqMy3oWSMtQPdvU41(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippet)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ADx5Gv3SqB6Pmpoflkp(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VuniTr3ktS2r58AwSxA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OFl2i138LruIZs9uaRy(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzTool)P_0).Pass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SfdFaH3qpTI59BIktLh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzTool)P_0).ExecutionTime;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YEahEJ3EKPCuJFbMbDW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzTool)P_0).Enabled;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eJM7pc3pkjSOFgr5POy(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).AppViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FOCZIs3X0K1CbPIDL4S(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EasyBuilderApplicationViewModel)P_0).PropertyLinks;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uVHVfT39CSLhhcMNtfL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzTool)P_0).ShowGraphics;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RWHtl934bVcilESrb1G()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.WDArmTU1K1();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eCwMOJ37J2WSgIjZKZX(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CVhNEn331Ptu4shtQLP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Or59lNn0c6();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lFCFBg3jQIfarrryTiZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzTool)P_0).ShowResults;
	}
}
