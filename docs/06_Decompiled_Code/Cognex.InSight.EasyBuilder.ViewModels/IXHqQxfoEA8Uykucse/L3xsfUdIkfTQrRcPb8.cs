using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Diagnostics.Logging;
using Cognex.InSight;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Internal;
using Cognex.InSight.Undo;
using zsQqWwRgKaAshfKAktM;

namespace IXHqQxfoEA8Uykucse;

internal class L3xsfUdIkfTQrRcPb8 : IUndoAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDo_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public L3xsfUdIkfTQrRcPb8 _003C_003E4__this;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = (MNaNQGKfF31RnrhhG4Zp() ? 1 : 5);
			L3xsfUdIkfTQrRcPb8 l3xsfUdIkfTQrRcPb = default;
			int num2 = default;
			TaskAwaiter<CvsCellCollection> awaiter = default;
			CvsCellCollection result = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					l3xsfUdIkfTQrRcPb = _003C_003E4__this;
					goto case 2;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							l3xsfUdIkfTQrRcPb.xveUu6EHks();
							num3 = 2;
							goto IL_00d6;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0068;
						IL_0068:
						_003C_003Eu__1 = default;
						num3 = 8;
						if (wbBDn6KfMYMqpRv6tyhi())
						{
						}
						goto IL_00d6;
						IL_00d6:
						while (true)
						{
							switch (num3)
							{
							case 4:
							case 5:
								break;
							case 7:
								return;
							case 6:
								result = awaiter.GetResult();
								num3 = 10;
								continue;
							case 0:
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								continue;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 9;
									continue;
								}
								goto case 6;
							case 2:
								awaiter = ((CvsCogSocketSheet)TqWijAKfUFYJLcDiYbpd(((CvsInSight)W2itPnKfYWwwKMjsy2SE(l3xsfUdIkfTQrRcPb.QOmUF95iwm())).CogSocket)).RunAndGetCellResults(l3xsfUdIkfTQrRcPb.nopUEaJbeh).GetAwaiter();
								num3 = 1;
								if (!wbBDn6KfMYMqpRv6tyhi())
								{
									continue;
								}
								goto case 8;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 6;
								continue;
							case 9:
								_003C_003Eu__1 = awaiter;
								MNaNQGKfF31RnrhhG4Zp();
								num3 = (wbBDn6KfMYMqpRv6tyhi() ? 4 : 0);
								continue;
							case 10:
								worHUGKfHMgXjaPUrpfq(l3xsfUdIkfTQrRcPb.QOmUF95iwm(), result);
								goto end_IL_00d6;
							}
							goto IL_0068;
							continue;
							end_IL_00d6:
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
				case 1:
					num2 = _003C_003E1__state;
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
		internal static object W2itPnKfYWwwKMjsy2SE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IInSightAppStep)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TqWijAKfUFYJLcDiYbpd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void worHUGKfHMgXjaPUrpfq(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IInSightAppStep)P_0).Refresh((CvsCellCollection)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MNaNQGKfF31RnrhhG4Zp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wbBDn6KfMYMqpRv6tyhi()
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
	private struct _003CRedo_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public L3xsfUdIkfTQrRcPb8 _003C_003E4__this;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (BTVgh6KfxNuA3jmCCixO())
			{
				num = 4;
				if (mv6RpPKfmr1LGVBYjwS5())
				{
				}
			}
			else
			{
				num = 2;
				if (mv6RpPKfmr1LGVBYjwS5())
				{
					return;
				}
			}
			int num2 = default;
			L3xsfUdIkfTQrRcPb8 l3xsfUdIkfTQrRcPb = default;
			TaskAwaiter<CvsCellCollection> awaiter = default;
			CvsCellCollection result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 5:
					l3xsfUdIkfTQrRcPb = _003C_003E4__this;
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					goto case 1;
				case 1:
					try
					{
						int num3;
						if (num2 != 0)
						{
							l3xsfUdIkfTQrRcPb.QOmUF95iwm().Snippets.Move(l3xsfUdIkfTQrRcPb.vlAUohPhpI(), l3xsfUdIkfTQrRcPb.FbPUDRkET8());
							BTVgh6KfxNuA3jmCCixO();
							if (!mv6RpPKfmr1LGVBYjwS5())
							{
								num3 = 2;
								if (1 == 0)
								{
									goto IL_00a5;
								}
							}
							else
							{
								num3 = 9;
								if (!BTVgh6KfxNuA3jmCCixO())
								{
									goto IL_0120;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
						}
						goto IL_0192;
						IL_00c3:
						result = awaiter.GetResult();
						num3 = 10;
						if (mv6RpPKfmr1LGVBYjwS5())
						{
						}
						goto IL_0192;
						IL_00a5:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 1;
						if (!BTVgh6KfxNuA3jmCCixO())
						{
							goto IL_00c3;
						}
						goto IL_0192;
						IL_0120:
						num2 = (_003C_003E1__state = 0);
						num3 = 8;
						goto IL_0192;
						IL_0192:
						while (true)
						{
							switch (num3)
							{
							case 6:
								break;
							case 7:
							case 9:
								goto IL_00c3;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								goto IL_00c3;
							case 3:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_00c3;
							case 4:
								goto IL_0120;
							case 0:
							case 2:
								awaiter = ((CvsCogSocket)ByqfHsKfNe3VSqosCthS(nUEBv7KfQn5G3qj6JEfL(l3xsfUdIkfTQrRcPb.QOmUF95iwm()))).Sheet.RunAndGetCellResults(l3xsfUdIkfTQrRcPb.nopUEaJbeh).GetAwaiter();
								num3 = 5;
								continue;
							case 1:
								return;
							case 8:
								_003C_003Eu__1 = awaiter;
								break;
							default:
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 10;
							case 10:
								GnLKafKf2Pl3OlbOfdoP(l3xsfUdIkfTQrRcPb.QOmUF95iwm(), result);
								goto end_IL_0067;
							}
							break;
						}
						goto IL_00a5;
						end_IL_0067:;
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
		internal static object nUEBv7KfQn5G3qj6JEfL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IInSightAppStep)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ByqfHsKfNe3VSqosCthS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GnLKafKf2Pl3OlbOfdoP(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IInSightAppStep)P_0).Refresh((CvsCellCollection)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BTVgh6KfxNuA3jmCCixO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mv6RpPKfmr1LGVBYjwS5()
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
	private struct _003CUndo_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public L3xsfUdIkfTQrRcPb8 _003C_003E4__this;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (lii4bVKfcnRjtkumdH7u())
			{
				num = 2;
				if (!lii4bVKfcnRjtkumdH7u())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_01d4;
			IL_002a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01d4;
			IL_01d4:
			int num2 = default;
			L3xsfUdIkfTQrRcPb8 l3xsfUdIkfTQrRcPb = default;
			TaskAwaiter<CvsCellCollection> awaiter = default;
			CvsCellCollection result = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							OqWpR4KfufcfYHI485Np(l3xsfUdIkfTQrRcPb.QOmUF95iwm().Snippets, l3xsfUdIkfTQrRcPb.FbPUDRkET8(), l3xsfUdIkfTQrRcPb.vlAUohPhpI());
							num3 = 8;
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
							case 8:
								awaiter = ((CvsCogSocket)zCH3rrKftNEt7dYTa0Xa(kOlOx5KfhqtuQWiHVyt4(l3xsfUdIkfTQrRcPb.QOmUF95iwm()))).Sheet.RunAndGetCellResults(l3xsfUdIkfTQrRcPb.l7bUfhQnAO).GetAwaiter();
								num3 = 0;
								continue;
							case 5:
								return;
							case 3:
							case 7:
								_003C_003Eu__1 = awaiter;
								goto default;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 1;
								continue;
							case 9:
								num2 = (_003C_003E1__state = 0);
								nP59iVKf1VCsy7Lc812D();
								num3 = (lii4bVKfcnRjtkumdH7u() ? 7 : 6);
								continue;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									continue;
								}
								goto IL_0163;
							case 1:
								num2 = (_003C_003E1__state = -1);
								goto IL_0163;
							default:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								continue;
							case 10:
								{
									iQtDq8KfzdkhFXfLDpyP(l3xsfUdIkfTQrRcPb.QOmUF95iwm(), result);
									break;
								}
								IL_0163:
								result = awaiter.GetResult();
								num3 = 10;
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
					break;
				default:
					num = 3;
					if (!nP59iVKf1VCsy7Lc812D())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 4:
					l3xsfUdIkfTQrRcPb = _003C_003E4__this;
					num = 5;
					continue;
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
		internal static void OqWpR4KfufcfYHI485Np(object P_0, int P_1, int P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ObservableCollection<EzSnippet>)P_0).Move(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kOlOx5KfhqtuQWiHVyt4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IInSightAppStep)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zCH3rrKftNEt7dYTa0Xa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void iQtDq8KfzdkhFXfLDpyP(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IInSightAppStep)P_0).Refresh((CvsCellCollection)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lii4bVKfcnRjtkumdH7u()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nP59iVKf1VCsy7Lc812D()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly ILogger TVrUI88v7x;

	private readonly Dictionary<string, object> l7bUfhQnAO;

	private readonly Dictionary<string, object> nopUEaJbeh;

	[CompilerGenerated]
	private readonly string o4hUbykOt8;

	[CompilerGenerated]
	private readonly IInSightAppStep qjkUc1pHhj;

	[CompilerGenerated]
	private readonly int vu4UQvCfMd;

	[CompilerGenerated]
	private readonly int Fu7UgZEmAn;

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
			return o4hUbykOt8;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public L3xsfUdIkfTQrRcPb8(IInSightAppStep P_0, int P_1, int P_2, string P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		while (true)
		{
			switch (num)
			{
			case 6:
				Fu7UgZEmAn = P_2;
				goto case 2;
			case 9:
				base._002Ector();
				num = 4;
				break;
			case 4:
				qjkUc1pHhj = P_0;
				goto case 5;
			default:
				num = 5;
				break;
			case 5:
				vu4UQvCfMd = P_1;
				num = 6;
				break;
			case 8:
				CYxcSEaNFI8PpRpLt1C();
				_ = 0;
				if (!Mx60Wjam2wFjB8XG8ju())
				{
					num = 2;
					if (true)
					{
						break;
					}
					goto case 9;
				}
				num = 3;
				break;
			case 1:
			case 3:
				l7bUfhQnAO = new Dictionary<string, object>();
				num = 0;
				break;
			case 2:
			case 7:
				o4hUbykOt8 = P_3;
				num = 10;
				break;
			case 0:
				nopUEaJbeh = new Dictionary<string, object>();
				num = 9;
				if (XqkAGsaQZ8P44A9ospV())
				{
					return;
				}
				break;
			case 10:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	protected IInSightAppStep QOmUF95iwm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return qjkUc1pHhj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	protected int vlAUohPhpI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return vu4UQvCfMd;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	protected int FbPUDRkET8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Fu7UgZEmAn;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)KHSnmva2eg2ONXBIbI0();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDo_003Ed__17))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!XqkAGsaQZ8P44A9ospV())
		{
			num = 3;
		}
		else
		{
			num = 5;
			if (false)
			{
				goto IL_0042;
			}
		}
		goto IL_005c;
		IL_0042:
		_003CDo_003Ed__17 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_0099;
		IL_0099:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_005c;
		IL_005c:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = UKQybqacPnCSOk0UVqn();
				goto case 1;
			case 2:
				break;
			default:
				num = 4;
				continue;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 2;
				continue;
			case 4:
				goto IL_0099;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0042;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void xveUu6EHks()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Mx60Wjam2wFjB8XG8ju();
		int num = (XqkAGsaQZ8P44A9ospV() ? 2 : 3);
		int num3 = default;
		IEnumerator<EzSnippet> enumerator = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				num3 = 1;
				num = 4;
				break;
			case 5:
				QOmUF95iwm().Snippets.Move(vlAUohPhpI(), FbPUDRkET8());
				goto case 6;
			default:
				num = 6;
				if (!XqkAGsaQZ8P44A9ospV())
				{
					break;
				}
				goto case 4;
			case 4:
				enumerator = QOmUF95iwm().Snippets.GetEnumerator();
				num = 7;
				break;
			case 0:
			case 3:
				if (FbPUDRkET8() <= QOmUF95iwm().Snippets.Count - 1)
				{
					goto case 5;
				}
				goto case 1;
			case 1:
			case 2:
				A2iSMHatlZo07nt5OmF(TVrUI88v7x, LogLevel.Error, TV4YKlahuGLc2WBtsvF(jTM8RAa1hRFs84kew9N(1992), FbPUDRkET8(), my4nnhau273beZjxIAr(QOmUF95iwm().Snippets)));
				num = 5;
				if (XqkAGsaQZ8P44A9ospV())
				{
				}
				break;
			case 7:
				try
				{
					while (enumerator.MoveNext())
					{
						EzSnippet current = enumerator.Current;
						_ = 0;
						int num2;
						if (Mx60Wjam2wFjB8XG8ju())
						{
							num2 = 3;
							if (1 == 0)
							{
								goto IL_0151;
							}
						}
						else
						{
							num2 = 1;
						}
						goto IL_017f;
						IL_0151:
						nopUEaJbeh.Add((string)zLf2jJeLEQP7o81WuVK(ymEbxuazY4X9rVBDt6I(current)), num3);
						goto IL_01ac;
						IL_01ac:
						num3++;
						num2 = 5;
						if (0 == 0)
						{
							goto IL_017f;
						}
						goto IL_01bc;
						IL_01bc:
						l7bUfhQnAO.Add((string)zLf2jJeLEQP7o81WuVK(ymEbxuazY4X9rVBDt6I(current)), ((EditNumericViewModel<int, CvsCellInt, CvsCellEditInt>)ymEbxuazY4X9rVBDt6I(current)).Value);
						num2 = 4;
						if (false)
						{
							continue;
						}
						goto IL_017f;
						IL_017f:
						switch (num2)
						{
						case 4:
							break;
						default:
							goto IL_01ac;
						case 0:
						case 3:
							goto IL_01bc;
						case 5:
							continue;
						}
						goto IL_0151;
					}
					return;
				}
				finally
				{
					enumerator?.Dispose();
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRedo_003Ed__19))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CRedo_003Ed__19 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			default:
				num = 0;
				continue;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003Et__builder = UKQybqacPnCSOk0UVqn();
				_ = 0;
				if (!Mx60Wjam2wFjB8XG8ju())
				{
					num = 5;
					continue;
				}
				num = 3;
				if (Mx60Wjam2wFjB8XG8ju())
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
	[AsyncStateMachine(typeof(_003CUndo_003Ed__20))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		XqkAGsaQZ8P44A9ospV();
		int num;
		if (Mx60Wjam2wFjB8XG8ju())
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
		goto IL_0056;
		IL_002a:
		_003CUndo_003Ed__20 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		num = 3;
		goto IL_0056;
		IL_0056:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				break;
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static L3xsfUdIkfTQrRcPb8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CYxcSEaNFI8PpRpLt1C();
		TVrUI88v7x = LogManager.GetLogger<L3xsfUdIkfTQrRcPb8>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CYxcSEaNFI8PpRpLt1C()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Mx60Wjam2wFjB8XG8ju()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XqkAGsaQZ8P44A9ospV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KHSnmva2eg2ONXBIbI0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder UKQybqacPnCSOk0UVqn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jTM8RAa1hRFs84kew9N(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int my4nnhau273beZjxIAr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Collection<EzSnippet>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TV4YKlahuGLc2WBtsvF(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void A2iSMHatlZo07nt5OmF(object P_0, LogLevel P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ILogger)P_0).Log(P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ymEbxuazY4X9rVBDt6I(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippet)P_0).Order;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zLf2jJeLEQP7o81WuVK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellName;
	}
}
