using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.InSight.Undo;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class UndoStructureChange : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDo_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoStructureChange _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			UndoStructureChange undoStructureChange = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					undoStructureChange = _003C_003E4__this;
					num = 4;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = undoStructureChange.Write(undoStructureChange.NewLinkText, undoStructureChange.OldLinkText, refresh: false).GetAwaiter();
							num3 = 1;
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
							case 4:
								_003C_003Eu__1 = awaiter;
								ehJ1Fe5KUWSmYHxL9q4w();
								if (!dCRlbs5KHDFH4CwyeWFL())
								{
									num3 = 5;
									if (dCRlbs5KHDFH4CwyeWFL())
									{
									}
									continue;
								}
								num3 = 7;
								if (true)
								{
									continue;
								}
								goto case 1;
							case 6:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 0:
								_003C_003Eu__1 = default;
								goto case 6;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								break;
							case 3:
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 2;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								continue;
							case 2:
								return;
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
					goto default;
				case 2:
					num2 = _003C_003E1__state;
					dCRlbs5KHDFH4CwyeWFL();
					num = (ehJ1Fe5KUWSmYHxL9q4w() ? 5 : 0);
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
		internal static bool ehJ1Fe5KUWSmYHxL9q4w()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dCRlbs5KHDFH4CwyeWFL()
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
	private struct _003CRedo_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoStructureChange _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0186;
			IL_001a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0186;
			IL_0186:
			int num2 = default;
			UndoStructureChange undoStructureChange = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 2:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = undoStructureChange.Write(undoStructureChange.NewLinkText, undoStructureChange.OldLinkText, refresh: true).GetAwaiter();
							HdSL2y5KmuMLpqOFfCTH();
							if (QbCvhL5KxZCT8GMkvkMl())
							{
								num3 = 7;
							}
							else
							{
								num3 = 3;
								if (HdSL2y5KmuMLpqOFfCTH())
								{
									goto IL_0146;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
							if (false)
							{
								goto IL_0080;
							}
						}
						goto IL_00b3;
						IL_00b3:
						while (true)
						{
							switch (num3)
							{
							case 1:
								return;
							case 3:
							case 6:
								break;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 1;
								continue;
							case 0:
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto IL_0146;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								continue;
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								continue;
							case 5:
								_003C_003Eu__1 = default;
								break;
							case 9:
								goto IL_0146;
							}
							break;
						}
						goto IL_0080;
						IL_0080:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_00b3;
						IL_0146:
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
					num = 0;
					continue;
				case 3:
					num2 = _003C_003E1__state;
					HdSL2y5KmuMLpqOFfCTH();
					num = ((!QbCvhL5KxZCT8GMkvkMl()) ? 4 : 5);
					continue;
				case 1:
				case 5:
					undoStructureChange = _003C_003E4__this;
					goto case 2;
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
		internal static bool QbCvhL5KxZCT8GMkvkMl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HdSL2y5KmuMLpqOFfCTH()
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
	private struct _003CSaveState_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NL1S9u5KNJmri2idLSHL();
			int num;
			if (CvqdMK5KQbQXLW0I3aGT())
			{
				num = 4;
			}
			else
			{
				num = 2;
				if (false)
				{
					goto IL_0041;
				}
			}
			goto IL_0182;
			IL_01a9:
			_003C_003Et__builder.SetResult();
			num = 5;
			goto IL_0182;
			IL_0041:
			int num2 = default;
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = KSwU6q5KcxFwXQucKiUx(QpjtD55K2yJLim9LKIX4());
					num3 = 3;
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 1;
				}
				while (true)
				{
					switch (num3)
					{
					case 3:
						if (!awaiter.IsCompleted)
						{
							num3 = 7;
							continue;
						}
						break;
					case 6:
					case 8:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 7:
						num2 = (_003C_003E1__state = 0);
						_ = 1;
						if (!NL1S9u5KNJmri2idLSHL())
						{
							num3 = 4;
							continue;
						}
						num3 = 8;
						if (1 == 0)
						{
							return;
						}
						continue;
					case 2:
					case 4:
						_003C_003Eu__1 = awaiter;
						num3 = 0;
						continue;
					case 1:
						_003C_003Eu__1 = default;
						goto case 6;
					case 5:
						return;
					case 0:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 5;
						if (true)
						{
							continue;
						}
						break;
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
			goto IL_01a9;
			IL_0182:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					break;
				case 1:
				case 2:
					break;
				default:
					num = 3;
					continue;
				case 3:
					goto IL_01a9;
				case 5:
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
		internal static object QpjtD55K2yJLim9LKIX4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter KSwU6q5KcxFwXQucKiUx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CvqdMK5KQbQXLW0I3aGT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NL1S9u5KNJmri2idLSHL()
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
	private struct _003CUndo_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoStructureChange _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (MbouMQ5KujbdQ0jRvSki() ? 2 : 3);
			UndoStructureChange undoStructureChange = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					undoStructureChange = _003C_003E4__this;
					num = 4;
					if (0 == 0)
					{
						break;
					}
					goto case 5;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = barvb15Khecff0H3xpvl(undoStructureChange.Write(undoStructureChange.OldLinkText, undoStructureChange.NewLinkText, refresh: true));
							num3 = 3;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
							if (false)
							{
								goto IL_0152;
							}
						}
						goto IL_00ab;
						IL_0152:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_00ab;
						IL_00ab:
						while (true)
						{
							switch (num3)
							{
							case 5:
								_003C_003Eu__1 = default;
								num3 = 8;
								continue;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 0;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
							case 6:
								num2 = (_003C_003E1__state = 0);
								goto case 2;
							case 2:
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								continue;
							case 3:
								if (!awaiter.IsCompleted)
								{
									MbouMQ5KujbdQ0jRvSki();
									if (!QyXukc5K1rlCIY9XInYJ())
									{
										num3 = 4;
										continue;
									}
									num3 = 6;
									if (!QyXukc5K1rlCIY9XInYJ())
									{
										return;
									}
									continue;
								}
								goto case 9;
							case 0:
								return;
							case 8:
								break;
							case 9:
								awaiter.GetResult();
								goto end_IL_00ab;
							}
							goto IL_0152;
							continue;
							end_IL_00ab:
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
					if (MbouMQ5KujbdQ0jRvSki())
					{
					}
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
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
		internal static TaskAwaiter barvb15Khecff0H3xpvl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QyXukc5K1rlCIY9XInYJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MbouMQ5KujbdQ0jRvSki()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public UndoStructureChange _003C_003E4__this;

		public string oldLinkText;

		public string newLinkText;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass27_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			vpKS6j55LiTXD7EmIaVL();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CWrite_003Eb__0(EzTool t)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tpd3Xn555GCAwmPPsv2U(XPas7455KT4aBD3LpqKs(t), _003C_003E4__this.ToolName);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CWrite_003Eb__1(CellViewModel p)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tpd3Xn555GCAwmPPsv2U(HUxwtL55w2oPc7QajPn6(p), _003C_003E4__this.PropertyName);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CWrite_003Eb__2(SourceLink n)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tpd3Xn555GCAwmPPsv2U(dRWYGa55JdBxkgQTmPvt(n), oldLinkText);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CWrite_003Eb__3(SourceLink n)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tpd3Xn555GCAwmPPsv2U(n.Text, newLinkText);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vpKS6j55LiTXD7EmIaVL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qi2KDg5KtSxT6SbmZSbq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JwrKSf5KzFOH9oYehGfv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XPas7455KT4aBD3LpqKs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tpd3Xn555GCAwmPPsv2U(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HUxwtL55w2oPc7QajPn6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).DisplayName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dRWYGa55JdBxkgQTmPvt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Text;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CWrite_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoStructureChange _003C_003E4__this;

		public string oldLinkText;

		public string newLinkText;

		private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

		public bool refresh;

		private IAsyncDisposable _003Cpause_003E5__2;

		private TaskAwaiter<IAsyncDisposable> _003C_003Eu__1;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private EzTool _003Ctool_003E5__5;

		private InputStructureViewModel _003Cproperty_003E5__6;

		private SourceLink _003ColdLink_003E5__7;

		private SourceLink _003CnewLink_003E5__8;

		private TaskAwaiter<object> _003C_003Eu__2;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__3;

		private TaskAwaiter _003C_003Eu__4;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__5;

		private ValueTaskAwaiter _003C_003Eu__6;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			UndoStructureChange undoStructureChange = default;
			TaskAwaiter<object> awaiter6 = default;
			TaskAwaiter awaiter3 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter5 = default;
			TaskAwaiter<CvsCellCollection> awaiter4 = default;
			bool? flag3 = default;
			bool flag4 = default;
			bool? flag2 = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					undoStructureChange = _003C_003E4__this;
					num = 1;
					continue;
				case 0:
					num2 = _003C_003E1__state;
					num = 2;
					continue;
				case 3:
				case 6:
					_003C_003E8__1 = null;
					break;
				case 1:
					try
					{
						TaskAwaiter<IAsyncDisposable> awaiter2;
						ValueTaskAwaiter awaiter;
						IAsyncDisposable result;
						switch (num2)
						{
						default:
							_003C_003E8__1 = new _003C_003Ec__DisplayClass27_0();
							_003C_003E8__1._003C_003E4__this = _003C_003E4__this;
							_003C_003E8__1.oldLinkText = oldLinkText;
							_003C_003E8__1.newLinkText = newLinkText;
							awaiter2 = undoStructureChange.Inspect.PauseResults().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_0113;
						case 0:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0113;
						case 1:
						case 2:
						case 3:
						case 4:
						case 5:
						case 6:
							try
							{
								int num3;
								switch (num2)
								{
								default:
									num3 = 46;
									goto IL_0558;
								case 1:
									awaiter6 = _003C_003Eu__2;
									num3 = 40;
									goto IL_0558;
								case 5:
									awaiter3 = _003C_003Eu__4;
									num3 = 8;
									if (!wgrVmN55acE850CdOjm4())
									{
										goto IL_03ab;
									}
									goto IL_0558;
								case 2:
									awaiter5 = _003C_003Eu__3;
									num3 = 9;
									goto IL_0558;
								case 6:
									awaiter4 = _003C_003Eu__5;
									num3 = 13;
									goto IL_0558;
								case 3:
									awaiter3 = _003C_003Eu__4;
									_003C_003Eu__4 = default;
									goto IL_026c;
								case 4:
									{
										awaiter3 = _003C_003Eu__4;
										num3 = 31;
										goto IL_0558;
									}
									IL_0558:
									while (true)
									{
										bool? flag;
										switch (num3)
										{
										case 51:
											if (!awaiter3.IsCompleted)
											{
												num3 = 2;
												continue;
											}
											goto case 23;
										case 42:
											num2 = (_003C_003E1__state = -1);
											num3 = 27;
											if (oh8Kjf55eJQZNtWyX1Aq())
											{
											}
											continue;
										case 9:
											_003C_003Eu__3 = default;
											num3 = 12;
											if (!oh8Kjf55eJQZNtWyX1Aq())
											{
												continue;
											}
											goto case 37;
										case 37:
											awaiter3.GetResult();
											goto case 36;
										case 36:
											awaiter3 = _003Cproperty_003E5__6.RemoveRef(_003ColdLink_003E5__7).GetAwaiter();
											num3 = 17;
											continue;
										case 31:
											_003C_003Eu__4 = default;
											num3 = 41;
											continue;
										case 47:
											break;
										case 30:
											return;
										case 39:
											_003Ctool_003E5__5 = null;
											num3 = 43;
											continue;
										case 0:
											num2 = (_003C_003E1__state = 6);
											_003C_003Eu__5 = awaiter4;
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
											num3 = 25;
											if (true)
											{
												continue;
											}
											goto end_IL_0558;
										case 11:
											goto end_IL_0558;
										case 35:
											_003C_003Eu__2 = awaiter6;
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter6, ref this);
											num3 = 30;
											continue;
										case 3:
											goto IL_029f;
										case 19:
											if (!awaiter6.IsCompleted)
											{
												num3 = 18;
												continue;
											}
											goto case 27;
										case 49:
											awaiter3 = blQDG655frLhbdNJdeku(_003Cproperty_003E5__6.AddRef(_003CnewLink_003E5__8));
											num3 = 51;
											if (true)
											{
												continue;
											}
											goto case 41;
										case 41:
											num2 = (_003C_003E1__state = -1);
											goto IL_034a;
										case 48:
											num2 = (_003C_003E1__state = 2);
											num3 = 33;
											continue;
										case 28:
											_003C_003Eu__4 = awaiter3;
											num3 = 16;
											continue;
										case 32:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
											return;
										case 34:
											goto IL_03ab;
										case 1:
											rnuLpx55sLe2yGe4Qu09(_003Cproperty_003E5__6);
											num3 = 39;
											continue;
										case 15:
											_003ColdLink_003E5__7 = null;
											num3 = 50;
											continue;
										case 52:
											awaiter3 = blQDG655frLhbdNJdeku(vn17MP55VY5adCsB5DbL(_003Ctool_003E5__5));
											if (awaiter3.IsCompleted)
											{
												goto case 37;
											}
											goto case 4;
										case 14:
										case 20:
											if (flag3 == flag4)
											{
												awaiter5 = undoStructureChange.Inspect.InSight.CogSocket.Sheet.RunAsync(fireSheetUpdated: false).GetAwaiter();
												num3 = 29;
												continue;
											}
											goto case 36;
										case 13:
											_003C_003Eu__5 = default;
											num3 = 6;
											if (!oh8Kjf55eJQZNtWyX1Aq())
											{
												continue;
											}
											goto case 45;
										case 45:
											flag2 = null;
											num3 = 24;
											continue;
										case 33:
											_003C_003Eu__3 = awaiter5;
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
											return;
										case 17:
											if (!awaiter3.IsCompleted)
											{
												num3 = 44;
												continue;
											}
											goto IL_034a;
										case 25:
											return;
										case 6:
											num2 = (_003C_003E1__state = -1);
											goto IL_04e6;
										case 44:
											num2 = (_003C_003E1__state = 4);
											num3 = 28;
											if (true)
											{
												continue;
											}
											goto case 27;
										case 27:
											awaiter6.GetResult();
											num3 = 5;
											continue;
										case 10:
											return;
										default:
											num3 = 11;
											if (0 == 0)
											{
												continue;
											}
											goto case 40;
										case 40:
											_003C_003Eu__2 = default;
											num3 = 42;
											if (true)
											{
												continue;
											}
											goto case 21;
										case 21:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
											num3 = 10;
											continue;
										case 43:
											_003Cproperty_003E5__6 = null;
											num3 = 15;
											continue;
										case 50:
											_003CnewLink_003E5__8 = null;
											num3 = 53;
											continue;
										case 2:
											num2 = (_003C_003E1__state = 5);
											num3 = 34;
											continue;
										case 7:
											_003C_003Eu__4 = awaiter3;
											num3 = 21;
											continue;
										case 18:
											num2 = (_003C_003E1__state = 1);
											num3 = 35;
											continue;
										case 24:
											flag = flag2;
											goto IL_06dc;
										case 23:
											awaiter3.GetResult();
											awaiter4 = ((CvsCogSocketSheet)YSUJ0A55lhnPl61NOL8k(WWvKNJ55OcGVuBH3FSc7(u1SjWw55dE7vlnCg548h(undoStructureChange.Inspect)))).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
											if (awaiter4.IsCompleted)
											{
												goto IL_04e6;
											}
											num3 = 0;
											if (!oh8Kjf55eJQZNtWyX1Aq())
											{
												continue;
											}
											goto case 29;
										case 29:
											if (awaiter5.IsCompleted)
											{
												break;
											}
											num3 = 48;
											if (true)
											{
												continue;
											}
											goto case 8;
										case 8:
											_003C_003Eu__4 = default;
											num2 = (_003C_003E1__state = -1);
											num3 = 23;
											continue;
										case 5:
										{
											if (ET26vP55DsShGVHAafIY(_003Cproperty_003E5__6) != CellType.Fixture)
											{
												goto case 36;
											}
											object obj = Xj44hW55ipkn9O5MmTkH(_003Ctool_003E5__5);
											if (obj != null)
											{
												CvsEditableDisplayGraphic cvsEditableDisplayGraphic = ((IEnumerable<CvsEditableDisplayGraphic>)obj).FirstOrDefault();
												if (cvsEditableDisplayGraphic == null)
												{
													num3 = 45;
													if (0 == 0)
													{
														continue;
													}
													goto case 51;
												}
												flag = rCoHZv55nYh6MYS3KvxT(cvsEditableDisplayGraphic);
												goto IL_06dc;
											}
											num3 = 36;
											continue;
										}
										case 16:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
											return;
										case 4:
										case 22:
											num2 = (_003C_003E1__state = 3);
											num3 = 7;
											continue;
										case 46:
											goto IL_07d9;
										case 38:
											goto IL_0815;
										case 26:
											if (!refresh)
											{
												goto case 39;
											}
											num3 = 1;
											if (0 == 0)
											{
												continue;
											}
											goto case 12;
										case 12:
											num2 = (_003C_003E1__state = -1);
											num3 = 47;
											continue;
										case 53:
											goto end_IL_0134;
											IL_06dc:
											flag3 = flag;
											flag4 = true;
											_ = 0;
											num3 = (wgrVmN55acE850CdOjm4() ? 20 : 4);
											continue;
											IL_034a:
											awaiter3.GetResult();
											num3 = 49;
											continue;
										}
										awaiter5.GetResult();
										num3 = 52;
										continue;
										IL_0815:
										_003CnewLink_003E5__8 = _003Cproperty_003E5__6.Links.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (SourceLink n) =>
										{
											while (false)
											{
												_ = ((object[])null)[0];
											}
											return _003C_003Ec__DisplayClass27_0.tpd3Xn555GCAwmPPsv2U(n.Text, _003C_003E8__1.newLinkText);
										});
										if (_003CnewLink_003E5__8 != null)
										{
											awaiter6 = ((CvsCogSocket)WWvKNJ55OcGVuBH3FSc7(undoStructureChange.Inspect.InSight)).Sheet.PutCellExpressionAsync(E1IU3R55IQ1J9vrKGDgV(_003Cproperty_003E5__6), _003CnewLink_003E5__8.Expression).GetAwaiter();
											num3 = 19;
											continue;
										}
										goto IL_08b7;
										IL_08b7:
										_003C_003E7__wrap3 = 1;
										goto end_IL_0134;
										IL_07d9:
										_003Ctool_003E5__5 = undoStructureChange.Inspect.Tools.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (EzTool t) =>
										{
											while (false)
											{
												_ = ((object[])null)[0];
											}
											return _003C_003Ec__DisplayClass27_0.tpd3Xn555GCAwmPPsv2U(_003C_003Ec__DisplayClass27_0.XPas7455KT4aBD3LpqKs(t), _003C_003E8__1._003C_003E4__this.ToolName);
										});
										if (_003Ctool_003E5__5 != null)
										{
											num3 = 3;
											continue;
										}
										goto IL_08b7;
										IL_04e6:
										CvsCellCollection result2 = awaiter4.GetResult();
										eh0cHB55gReYiBTsgK1S(undoStructureChange.Inspect, result2);
										num3 = 26;
										continue;
										IL_029f:
										_003Cproperty_003E5__6 = (InputStructureViewModel)_003Ctool_003E5__5.AllProperties.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (CellViewModel p) =>
										{
											while (false)
											{
												_ = ((object[])null)[0];
											}
											return _003C_003Ec__DisplayClass27_0.tpd3Xn555GCAwmPPsv2U(_003C_003Ec__DisplayClass27_0.HUxwtL55w2oPc7QajPn6(p), _003C_003E8__1._003C_003E4__this.PropertyName);
										});
										if (_003Cproperty_003E5__6 != null)
										{
											_003ColdLink_003E5__7 = _003Cproperty_003E5__6.Links.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (SourceLink n) =>
											{
												while (false)
												{
													_ = ((object[])null)[0];
												}
												return _003C_003Ec__DisplayClass27_0.tpd3Xn555GCAwmPPsv2U(_003C_003Ec__DisplayClass27_0.dRWYGa55JdBxkgQTmPvt(n), _003C_003E8__1.oldLinkText);
											});
											num3 = 38;
											continue;
										}
										goto IL_08b7;
										continue;
										end_IL_0558:
										break;
									}
									goto IL_026c;
									IL_03ab:
									_003C_003Eu__4 = awaiter3;
									num3 = 32;
									goto IL_0558;
									IL_026c:
									num2 = (_003C_003E1__state = -1);
									num3 = 37;
									goto IL_0558;
									end_IL_0134:
									break;
								}
							}
							catch (object obj2)
							{
								_003C_003E7__wrap2 = obj2;
							}
							if (_003Cpause_003E5__2 == null)
							{
								break;
							}
							awaiter = JCZ1Vu55vFEJZX2k8vca(_003Cpause_003E5__2).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 7);
								_003C_003Eu__6 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0940;
						case 7:
							{
								awaiter = _003C_003Eu__6;
								_003C_003Eu__6 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0940;
							}
							IL_0940:
							awaiter.GetResult();
							break;
							IL_0113:
							result = awaiter2.GetResult();
							_003Cpause_003E5__2 = result;
							_003C_003E7__wrap2 = null;
							_003C_003E7__wrap3 = 0;
							goto case 1;
						}
						object obj3 = _003C_003E7__wrap2;
						if (obj3 != null)
						{
							nMqtEX55P1wTIIDgJZhi(TcXsl755r2fNENp0IEm2((obj3 as Exception) ?? throw obj3));
						}
						int num4 = _003C_003E7__wrap3;
						if (num4 != 1)
						{
							_003C_003E7__wrap2 = null;
							_003Cpause_003E5__2 = null;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003E8__1 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				default:
					_ = 0;
					if (!wgrVmN55acE850CdOjm4())
					{
						num = 5;
						if (0 == 0)
						{
							continue;
						}
						goto case 1;
					}
					num = 6;
					continue;
				case 4:
				case 5:
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
		internal static object WWvKNJ55OcGVuBH3FSc7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation E1IU3R55IQ1J9vrKGDgV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CellType ET26vP55DsShGVHAafIY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).DataType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Xj44hW55ipkn9O5MmTkH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).GetViewableEditGraphics();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rCoHZv55nYh6MYS3KvxT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsDisplayableGraphic)P_0).Visible;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vn17MP55VY5adCsB5DbL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).WriteFixturedGraphics();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter blQDG655frLhbdNJdeku(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object u1SjWw55dE7vlnCg548h(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YSUJ0A55lhnPl61NOL8k(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void eh0cHB55gReYiBTsgK1S(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AppStepViewModel)P_0).Refresh((CvsCellCollection)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void rnuLpx55sLe2yGe4Qu09(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((InputStructureViewModel)P_0).RefreshSelectedLink();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ValueTask JCZ1Vu55vFEJZX2k8vca(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IAsyncDisposable)P_0).DisposeAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TcXsl755r2fNENp0IEm2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void nMqtEX55P1wTIIDgJZhi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wgrVmN55acE850CdOjm4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oh8Kjf55eJQZNtWyX1Aq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private InspectStepViewModel Q6IvlMvy91;

	[CompilerGenerated]
	private string TDpvTNajax;

	[CompilerGenerated]
	private string ECdvWkZqCD;

	[CompilerGenerated]
	private string ceOvjHKqNU;

	[CompilerGenerated]
	private string ToIvCIb7qg;

	protected InspectStepViewModel Inspect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Q6IvlMvy91;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Q6IvlMvy91 = value;
		}
	}

	protected string ToolName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TDpvTNajax;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			TDpvTNajax = value;
		}
	}

	protected string PropertyName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ECdvWkZqCD;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ECdvWkZqCD = value;
		}
	}

	protected string OldLinkText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ceOvjHKqNU;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ceOvjHKqNU = value;
		}
	}

	protected string NewLinkText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ToIvCIb7qg;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ToIvCIb7qg = value;
		}
	}

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)jxFDN6H2sRiIR9J2yXj(Resources.pd1hOYqP56(), EzSnippet.AssembleFullCellName(ToolName, PropertyName), OldLinkText, NewLinkText);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoStructureChange(InspectStepViewModel inspect, string toolName, string propertyName, SourceLink oldLink, SourceLink newLink)
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
			case 1:
			case 4:
				base._002Ector();
				num = 8;
				break;
			case 2:
			case 5:
				OldLinkText = (string)eDannrHNjntpOOWPQoY(oldLink);
				num = 3;
				if (true)
				{
					break;
				}
				goto case 8;
			case 8:
				Inspect = inspect;
				num = 0;
				break;
			case 6:
				PropertyName = propertyName;
				goto case 2;
			case 7:
				mZxW7HHQieme7GWBrKQ();
				TduBT6HxNACeo6LyUEh();
				num = ((!egfvCyHmwcF7yLlgwVA()) ? 4 : 2);
				break;
			case 3:
				NewLinkText = (string)eDannrHNjntpOOWPQoY(newLink);
				num = 9;
				break;
			case 0:
				ToolName = toolName;
				goto case 6;
			default:
				num = 6;
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__23))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		egfvCyHmwcF7yLlgwVA();
		int num = ((!TduBT6HxNACeo6LyUEh()) ? 3 : 4);
		_003CDo_003Ed__23 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = llEarMHcY1KXgWbxbdV();
				goto case 1;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__24))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (egfvCyHmwcF7yLlgwVA() ? 5 : 4);
		_003CRedo_003Ed__24 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = llEarMHcY1KXgWbxbdV();
				num = 1;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (TduBT6HxNACeo6LyUEh())
				{
					break;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSaveState_003Ed__25))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		TduBT6HxNACeo6LyUEh();
		int num;
		if (!egfvCyHmwcF7yLlgwVA())
		{
			num = 3;
		}
		else
		{
			num = 1;
			if (egfvCyHmwcF7yLlgwVA())
			{
			}
		}
		_003CSaveState_003Ed__25 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				break;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = llEarMHcY1KXgWbxbdV();
				num = 4;
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUndo_003Ed__26))]
	public Task Undo()
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
		goto IL_0034;
		IL_001a:
		_003CUndo_003Ed__26 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_005f;
		IL_0034:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				break;
			default:
				num = 4;
				continue;
			case 4:
				goto IL_005f;
			case 3:
				stateMachine._003C_003Et__builder = llEarMHcY1KXgWbxbdV();
				TduBT6HxNACeo6LyUEh();
				if (!egfvCyHmwcF7yLlgwVA())
				{
					num = 5;
					if (TduBT6HxNACeo6LyUEh())
					{
						continue;
					}
					goto case 1;
				}
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				goto case 6;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
		IL_005f:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0034;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWrite_003Ed__27))]
	protected Task Write(string newLinkText, string oldLinkText, bool refresh)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CWrite_003Ed__27 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				stateMachine.newLinkText = newLinkText;
				egfvCyHmwcF7yLlgwVA();
				if (TduBT6HxNACeo6LyUEh())
				{
					num = 0;
					if (TduBT6HxNACeo6LyUEh())
					{
						break;
					}
					goto case 8;
				}
				num = 5;
				break;
			case 8:
				stateMachine.refresh = refresh;
				num = 1;
				if (egfvCyHmwcF7yLlgwVA())
				{
				}
				break;
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			case 5:
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				break;
			case 0:
			case 3:
				stateMachine.oldLinkText = oldLinkText;
				goto case 8;
			default:
				num = 8;
				break;
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 7;
				break;
			case 4:
				stateMachine._003C_003Et__builder = llEarMHcY1KXgWbxbdV();
				num = 2;
				break;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mZxW7HHQieme7GWBrKQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eDannrHNjntpOOWPQoY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SourceLink)P_0).Text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TduBT6HxNACeo6LyUEh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool egfvCyHmwcF7yLlgwVA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jxFDN6H2sRiIR9J2yXj(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder llEarMHcY1KXgWbxbdV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
