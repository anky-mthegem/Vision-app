using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Forms;
using AYcpgJR0ngPvVcDpiKJ;
using BdfAmxxd7h5WZk7gxy;
using Cognex.Common.Wpf.Extensions;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls;
using Cognex.InSight.Controls.Display;
using Cognex.InSight.Controls.Display.Controls;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ViewModels.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Inspect;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.Graphic;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime.ViewModels;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect;

public sealed class InspectStepDisplay : AppStepDisplayBase
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<CvsCell, bool> _003C_003E9__33_1;

		public static Func<CvsCell, bool> _003C_003E9__33_2;

		public static Func<CvsCell, bool> _003C_003E9__33_3;

		public static Func<CvsEditableDisplayGraphic, bool> _003C_003E9__34_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QUVFL9KvRFDxPmPmkePb();
			oFcCDBKvW0Qka0hk9Gje(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CUpdateActionEnables_003Eb__33_1(CvsCell cell)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (!CN2ir1KvT3t80A7SkxPR(cell))
			{
				return cell.CanBeOutputPin();
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CUpdateActionEnables_003Eb__33_2(CvsCell c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return cAaNfIYmra(c);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CUpdateActionEnables_003Eb__33_3(CvsCell c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DLxVmeKvybf3v6qwXGdr(c);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetFocusGraphic_003Eb__34_0(CvsEditableDisplayGraphic g)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bqs9XGKv0KkR4LXRj5Zl(g) != CvsEditFlags.None;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal object _003CFilterOutEditGraphics_003Eb__67_3<T>(CvsEditableDisplayGraphic g) where T : CvsCogShape
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return g.InSightGraphic.GetSerializableGraphic();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Dky0TBKvCopv4kORuoRh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SOsFGSKvA9deoEVBRgiH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void QUVFL9KvRFDxPmPmkePb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void oFcCDBKvW0Qka0hk9Gje(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CN2ir1KvT3t80A7SkxPR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCell.IsNullOrEmpty((CvsCell)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DLxVmeKvybf3v6qwXGdr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MdpNEFbL2c((CvsCell)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsEditFlags bqs9XGKv0KkR4LXRj5Zl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditableDisplayGraphic)P_0).EditFlags;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnGraphicChanged_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InspectStepDisplay _003C_003E4__this;

		public CvsEditEventArgs e;

		public object sender;

		private CvsCellCollection _003Ccells_003E5__2;

		private CvsEditableDisplayGraphic _003CeditableGraphic_003E5__3;

		private IEnumerator<EzTool> _003C_003E7__wrap3;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<IAsyncDisposable> _003C_003Eu__2;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__3;

		private ValueTaskAwaiter _003C_003Eu__4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			iIQHVWKvMsvrnH9ChicR();
			int num = ((!dGmVJ3KvFXR9E8tKIXX5()) ? 4 : 5);
			InspectStepDisplay inspectStepDisplay = default;
			int num2 = default;
			CvsCellLocation location = default;
			TaskAwaiter awaiter3 = default;
			EzTool current = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					inspectStepDisplay = _003C_003E4__this;
					num = 1;
					continue;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 2;
					continue;
				default:
					_003Ccells_003E5__2 = null;
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 6:
					break;
				case 1:
					try
					{
						if ((uint)num2 > 6u)
						{
							_003Ccells_003E5__2 = null;
						}
						try
						{
							TaskAwaiter<IAsyncDisposable> awaiter4;
							TaskAwaiter<CvsCellCollection> awaiter2;
							ValueTaskAwaiter awaiter;
							IAsyncDisposable result2;
							CvsCellCollection result;
							switch (num2)
							{
							default:
								JZnSSFKvY95V91cfvaAf(inspectStepDisplay.HpaN2GFW8S, TimeSpan.FromSeconds(1.0));
								_003CeditableGraphic_003E5__3 = Ydo3PoKvUy6ugHhDcRCM(e) as CvsEditableDisplayGraphic;
								if (_003CeditableGraphic_003E5__3 == null)
								{
									break;
								}
								location = zqRITRKvHRkAXsNuhbv1(_003CeditableGraphic_003E5__3);
								_003C_003E7__wrap3 = inspectStepDisplay.Inspect.Tools.GetEnumerator();
								goto case 0;
							case 0:
								try
								{
									if (num2 != 0)
									{
										goto IL_0273;
									}
									awaiter3 = _003C_003Eu__1;
									int num3 = 6;
									if (true)
									{
										goto IL_0193;
									}
									goto IL_0248;
									IL_0193:
									while (true)
									{
										switch (num3)
										{
										case 6:
											break;
										case 9:
											awaiter3.GetResult();
											num3 = 12;
											continue;
										default:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
											num3 = 7;
											if (!iIQHVWKvMsvrnH9ChicR())
											{
												continue;
											}
											goto case 10;
										case 10:
											_003C_003Eu__1 = awaiter3;
											goto default;
										case 3:
											if (!awaiter3.IsCompleted)
											{
												num3 = 2;
												continue;
											}
											goto case 9;
										case 0:
										case 4:
											goto IL_01f2;
										case 1:
											awaiter3 = jOkSJ2Kvm1E1fWeHxuAx(inspectStepDisplay.Inspect.SetCurrentSnippet(current));
											num3 = 3;
											continue;
										case 7:
											return;
										case 2:
											goto IL_0248;
										case 8:
											num2 = (_003C_003E1__state = -1);
											num3 = 9;
											continue;
										case 12:
											goto end_IL_0101;
										}
										break;
										IL_01f2:
										if (zcqwXyKvxi7LkLZr1Cwv(current).Contains(location))
										{
											num3 = 1;
											continue;
										}
										goto IL_0273;
									}
									goto IL_0134;
									IL_0273:
									if (EfxOvEKvQCb4HQbjIMo2(_003C_003E7__wrap3))
									{
										current = _003C_003E7__wrap3.Current;
										dGmVJ3KvFXR9E8tKIXX5();
										if (!iIQHVWKvMsvrnH9ChicR())
										{
											num3 = 4;
											if (false)
											{
												goto IL_0134;
											}
										}
										else
										{
											num3 = 11;
										}
										goto IL_0193;
									}
									goto end_IL_0101;
									IL_0134:
									_003C_003Eu__1 = default;
									num3 = 8;
									goto IL_0193;
									IL_0248:
									num2 = (_003C_003E1__state = 0);
									num3 = 10;
									goto IL_0193;
									end_IL_0101:;
								}
								finally
								{
									if (num2 < 0 && _003C_003E7__wrap3 != null)
									{
										_003C_003E7__wrap3.Dispose();
									}
								}
								_003C_003E7__wrap3 = null;
								if (inspectStepDisplay.B8VNs13RJJ == null && jxglTrKvNvS4MWKKqj1e(e))
								{
									awaiter4 = inspectStepDisplay.Inspect.PauseResults().GetAwaiter();
									if (!awaiter4.IsCompleted)
									{
										num2 = (_003C_003E1__state = 1);
										_003C_003Eu__2 = awaiter4;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										return;
									}
									goto IL_0327;
								}
								goto IL_0338;
							case 1:
								awaiter4 = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0327;
							case 2:
								awaiter3 = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_03e2;
							case 3:
								awaiter2 = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0458;
							case 4:
								awaiter3 = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0502;
							case 5:
								awaiter2 = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0578;
							case 6:
								{
									awaiter = _003C_003Eu__4;
									_003C_003Eu__4 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_0607;
								}
								IL_0607:
								awaiter.GetResult();
								inspectStepDisplay.B8VNs13RJJ = null;
								break;
								IL_0578:
								result = awaiter2.GetResult();
								_003Ccells_003E5__2 = result;
								goto IL_0589;
								IL_03e2:
								awaiter3.GetResult();
								goto IL_03e9;
								IL_03e9:
								awaiter2 = ((CvsCogSocketSheet)PWBUp2KvuaEy1DenBi9y(hujuQCKv1VxlDcW6HgjA(ApMSVwKvcuWX9p0j14na(inspectStepDisplay.Inspect)))).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 3);
									_003C_003Eu__3 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_0458;
								IL_0589:
								if (inspectStepDisplay.B8VNs13RJJ == null || !LBLgEyKvtN7EbVH0PcGn(e))
								{
									break;
								}
								awaiter = BRjDY0Kvzkf0jKaibB6G(inspectStepDisplay.B8VNs13RJJ).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 6);
									_003C_003Eu__4 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_0607;
								IL_0327:
								result2 = awaiter4.GetResult();
								inspectStepDisplay.B8VNs13RJJ = result2;
								goto IL_0338;
								IL_0338:
								if (e.IsEditingComposite)
								{
									if (e.IsEditingGraphic)
									{
										N3ZbIvKv2AOoE5COPIlh(inspectStepDisplay.Inspect, _003CeditableGraphic_003E5__3);
										goto IL_03e9;
									}
									CvsInSightDisplay inSightDisplay = sender as CvsInSightDisplay;
									awaiter3 = jOkSJ2Kvm1E1fWeHxuAx(inspectStepDisplay.Inspect.SendGraphic(_003CeditableGraphic_003E5__3, inSightDisplay));
									if (!awaiter3.IsCompleted)
									{
										num2 = (_003C_003E1__state = 2);
										_003C_003Eu__1 = awaiter3;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										return;
									}
									goto IL_03e2;
								}
								if (!dbB7lEKvhjG6EIEG0X6U(e) && jxglTrKvNvS4MWKKqj1e(e))
								{
									CvsInSightDisplay inSightDisplay2 = sender as CvsInSightDisplay;
									awaiter3 = jOkSJ2Kvm1E1fWeHxuAx(inspectStepDisplay.Inspect.SendGraphic(_003CeditableGraphic_003E5__3, inSightDisplay2));
									if (!awaiter3.IsCompleted)
									{
										num2 = (_003C_003E1__state = 4);
										_003C_003Eu__1 = awaiter3;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										return;
									}
									goto IL_0502;
								}
								goto IL_0589;
								IL_0458:
								result = awaiter2.GetResult();
								_003Ccells_003E5__2 = result;
								goto IL_0589;
								IL_0502:
								awaiter3.GetResult();
								awaiter2 = ((CvsCogSocketSheet)PWBUp2KvuaEy1DenBi9y(((CvsInSight)ApMSVwKvcuWX9p0j14na(inspectStepDisplay.Inspect)).CogSocket)).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 5);
									_003C_003Eu__3 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_0578;
							}
							_003CeditableGraphic_003E5__3 = null;
						}
						catch (Exception ex)
						{
							GixE1kKrLysu75n3QwdT(LogManager.GetLogger<InspectStepDisplay>(), LogLevel.Error, CdQUGaROfy7He9T0foW.KbIzwHEDLa(48564), ex);
							throw;
						}
						finally
						{
							if (num2 < 0)
							{
								U6qWvHKrKqkB3IXTWtFL(inspectStepDisplay.HpaN2GFW8S);
							}
						}
						if (_003Ccells_003E5__2 != null)
						{
							DUurgIKr5cTxoDLhXqgu(inspectStepDisplay.Inspect, _003Ccells_003E5__2);
						}
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
		internal static bool JZnSSFKvY95V91cfvaAf(object P_0, TimeSpan P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((WaitHandle)P_0).WaitOne(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Ydo3PoKvUy6ugHhDcRCM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditEventArgs)P_0).Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation zqRITRKvHRkAXsNuhbv1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditableDisplayGraphic)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange zcqwXyKvxi7LkLZr1Cwv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).CellRange;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter jOkSJ2Kvm1E1fWeHxuAx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EfxOvEKvQCb4HQbjIMo2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jxglTrKvNvS4MWKKqj1e(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditEventArgs)P_0).IsEditingGraphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void N3ZbIvKv2AOoE5COPIlh(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((InspectStepViewModel)P_0).UpdateCompositeViewModelGraphic((CvsEditableDisplayGraphic)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ApMSVwKvcuWX9p0j14na(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hujuQCKv1VxlDcW6HgjA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PWBUp2KvuaEy1DenBi9y(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dbB7lEKvhjG6EIEG0X6U(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditEventArgs)P_0).IsFocusChange;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LBLgEyKvtN7EbVH0PcGn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditEventArgs)P_0).EditGraphicEnd;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ValueTask BRjDY0Kvzkf0jKaibB6G(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IAsyncDisposable)P_0).DisposeAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GixE1kKrLysu75n3QwdT(object P_0, LogLevel P_1, object P_2, object P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).LogException(P_1, (string)P_2, (Exception)P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void U6qWvHKrKqkB3IXTWtFL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Mutex)P_0).ReleaseMutex();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void DUurgIKr5cTxoDLhXqgu(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AppStepViewModel)P_0).Refresh((CvsCellCollection)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dGmVJ3KvFXR9E8tKIXX5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iIQHVWKvMsvrnH9ChicR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public CvsCellRange cellRange;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass41_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			wykM9CKraWW3dHTDvgYs();
			r9SyOSKreEBY4Ne00nah(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CInspect_PropertyChanged_003Eb__2(CvsEditableDisplayGraphic g)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (cellRange.Contains(g.CellLocation))
			{
				return g.Visible;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void wykM9CKraWW3dHTDvgYs()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void r9SyOSKreEBY4Ne00nah(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RebNeVKrwMl4DNdwQjvj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Jn9hvpKrJkXCRIsR1wPS()
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
	private struct _003COnAddGraphicChanged_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InspectStepDisplay _003C_003E4__this;

		public object sender;

		public CvsEditEventArgs e;

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
			if (Gto6SHKrODlWSOGnfYLB())
			{
				num = 1;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 5;
				if (!Gto6SHKrODlWSOGnfYLB())
				{
					goto IL_022d;
				}
			}
			goto IL_01e5;
			IL_022d:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01e5;
			IL_01e5:
			InspectStepDisplay inspectStepDisplay = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					break;
				default:
					num = 3;
					continue;
				case 4:
					inspectStepDisplay = _003C_003E4__this;
					break;
				case 3:
					goto IL_022d;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			try
			{
				int num3;
				if (num2 != 0)
				{
					if (inspectStepDisplay.oPONCwLRso() != null)
					{
						num3 = 6;
						goto IL_0083;
					}
					goto IL_011e;
				}
				TaskAwaiter awaiter = _003C_003Eu__1;
				goto IL_0041;
				IL_0041:
				_003C_003Eu__1 = default;
				num3 = 8;
				goto IL_0083;
				IL_0083:
				while (true)
				{
					switch (num3)
					{
					case 7:
						break;
					case 0:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 7;
						continue;
					case 2:
						num2 = (_003C_003E1__state = 0);
						_ = 0;
						if (Gto6SHKrODlWSOGnfYLB())
						{
							num3 = 5;
							continue;
						}
						num3 = 1;
						if (Gto6SHKrODlWSOGnfYLB())
						{
							continue;
						}
						goto case 8;
					case 10:
						awaiter.GetResult();
						num3 = 11;
						if (!GN2iZiKrINdgovn3T2F8())
						{
							continue;
						}
						goto case 6;
					case 6:
						awaiter = q0vrdGKrDYs09sEcq7dg(inspectStepDisplay.fI8NXRbmFw(sender, e));
						num3 = 4;
						continue;
					case 11:
						goto IL_011e;
					case 9:
						goto end_IL_0026;
					case 8:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						continue;
					case 3:
					case 5:
						_003C_003Eu__1 = awaiter;
						num3 = 0;
						if (true)
						{
							continue;
						}
						goto end_IL_0026;
					case 1:
						goto end_IL_0026;
					case 4:
						if (!awaiter.IsCompleted)
						{
							num3 = 2;
							continue;
						}
						goto case 10;
					case 12:
						goto end_IL_0026;
					}
					break;
				}
				goto IL_0041;
				IL_011e:
				EzToolType uEnNPqJSWX = inspectStepDisplay.uEnNPqJSWX;
				if (uEnNPqJSWX != null)
				{
					AsyncDelegateCommand acceptAddCommand = uEnNPqJSWX.AcceptAddCommand;
					if (acceptAddCommand == null)
					{
						num3 = 12;
						if (GN2iZiKrINdgovn3T2F8())
						{
						}
						goto IL_0083;
					}
					acceptAddCommand.RaiseCanExecuteChanged();
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
			goto IL_022d;
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
		internal static TaskAwaiter q0vrdGKrDYs09sEcq7dg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Gto6SHKrODlWSOGnfYLB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GN2iZiKrINdgovn3T2F8()
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
	private struct _003COnGraphicChangedAsync_003Ed__44 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InspectStepDisplay _003C_003E4__this;

		public object sender;

		public CvsEditEventArgs e;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ghNG5mKrn39ImUMFe0Tm();
			int num;
			if (xHraGdKriqaGElsnrk9c())
			{
				num = 5;
				if (1 == 0)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_01db;
			IL_002a:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (ghNG5mKrn39ImUMFe0Tm())
			{
			}
			goto IL_01db;
			IL_01db:
			int num2 = default;
			InspectStepDisplay inspectStepDisplay = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 1:
					inspectStepDisplay = _003C_003E4__this;
					goto case 2;
				case 2:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = TNaNYbKrfuVHh81y1IaD(QH3tGIKrVY8J57M1kgwY(inspectStepDisplay.oPONCwLRso(), sender, e));
							num3 = 2;
							if (false)
							{
								goto IL_00a0;
							}
							goto IL_012d;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00f7;
						IL_00f7:
						_003C_003Eu__1 = default;
						num3 = 0;
						goto IL_012d;
						IL_012d:
						while (true)
						{
							switch (num3)
							{
							case 8:
								break;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 9:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 2:
								if (awaiter.IsCompleted)
								{
									goto case 9;
								}
								goto IL_00e1;
							case 5:
							case 7:
								goto IL_00f7;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 6;
								continue;
							case 6:
								return;
							case 1:
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 10:
								nJ4n2sKrdwlRQLdF5SnN(inspectStepDisplay.Display);
								goto end_IL_0071;
							}
							break;
							IL_00e1:
							_ = 1;
							num3 = (ghNG5mKrn39ImUMFe0Tm() ? 7 : 3);
						}
						goto IL_00a0;
						IL_00a0:
						_003C_003Eu__1 = awaiter;
						num3 = 4;
						goto IL_012d;
						end_IL_0071:;
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
		internal static object QH3tGIKrVY8J57M1kgwY(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IGraphicToolType)P_0).OnGraphicChanged(P_1, (CvsEditEventArgs)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter TNaNYbKrfuVHh81y1IaD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void nJ4n2sKrdwlRQLdF5SnN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsInSightDisplay)P_0).Invalidate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xHraGdKriqaGElsnrk9c()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ghNG5mKrn39ImUMFe0Tm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass67_0
	{
		public CvsCogShape shape;

		public InspectStepDisplay _003C_003E4__this;

		public CvsCellLocation cellLocation;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass67_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			nQ0CfUKrs8nQ0QkF1FtF();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CFilterOutEditGraphics_003Eb__1(EzTool t)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return oEtZ0hKrvwlJ9YQqKy33(t, cellLocation);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void nQ0CfUKrs8nQ0QkF1FtF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eRpj4aKrlfk4k98SG3tt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Xv2vhnKrgq5SdMKjiiul()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oEtZ0hKrvwlJ9YQqKy33(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).ods5MyNttS(P_1);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass67_2
	{
		public CvsCogAnnulus _003Cannulus_003E5__2;

		public CvsCogPoint _003Cpoint_003E5__3;

		public CvsCogRegion _003Cregion_003E5__4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass67_2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			EYyhaNKrbpI1FIhwiLIL(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CFilterOutEditGraphics_003Eb__4(CvsCogAnnulus g)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003Cannulus_003E5__2.IsGeometricallyEqual(g);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CFilterOutEditGraphics_003Eb__5(CvsCogPoint g)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003Cpoint_003E5__3.IsGeometricallyEqual(g);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CFilterOutEditGraphics_003Eb__6(CvsCogRegion g)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003Cregion_003E5__4.IsGeometricallyEqual(g);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void EYyhaNKrbpI1FIhwiLIL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iJywbNKrZgVEnLunmf8m()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hGBsTVKrBPyOenhKjBCK()
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
	private struct _003CDoPublish_003Ed__71 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public InspectStepDisplay _003C_003E4__this;

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
			if (!f9JLSkKro0FUIwuZIqBj())
			{
				num = 3;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_01f2;
				}
			}
			goto IL_01a8;
			IL_01a8:
			int num2 = default;
			InspectStepDisplay inspectStepDisplay = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					break;
				case 2:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((Task)L9eHkxKr8lZb3O783wdG(inspectStepDisplay.Inspect, z9gHMhKrS9B0dHIurASV(inspectStepDisplay.Display), cLA7OCKrkemiJHgO4X5k(inspectStepDisplay.Display))).GetAwaiter();
							num3 = 4;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
							if (!w3csySKrGQy4XcArh9uE())
							{
								goto IL_00c6;
							}
						}
						goto IL_0116;
						IL_00c6:
						if (!awaiter.IsCompleted)
						{
							w3csySKrGQy4XcArh9uE();
							if (!f9JLSkKro0FUIwuZIqBj())
							{
								num3 = 8;
								if (f9JLSkKro0FUIwuZIqBj())
								{
								}
							}
							else
							{
								num3 = 5;
								if (1 == 0)
								{
									goto IL_0168;
								}
							}
							goto IL_0116;
						}
						goto IL_0168;
						IL_0168:
						awaiter.GetResult();
						goto end_IL_0037;
						IL_0116:
						while (true)
						{
							switch (num3)
							{
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 2:
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 7:
								_003C_003Eu__1 = default;
								num3 = 3;
								if (true)
								{
									continue;
								}
								return;
							case 6:
								return;
							case 4:
								break;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 6;
								continue;
							case 1:
							case 8:
								num2 = (_003C_003E1__state = 0);
								goto case 2;
							case 9:
								goto IL_0168;
							}
							break;
						}
						goto IL_00c6;
						end_IL_0037:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto IL_01f2;
				default:
					num = 5;
					if (w3csySKrGQy4XcArh9uE())
					{
						continue;
					}
					goto case 1;
				case 1:
					inspectStepDisplay = _003C_003E4__this;
					goto case 2;
				case 5:
					goto IL_01f2;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_01f2:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (!w3csySKrGQy4XcArh9uE())
			{
				return;
			}
			goto IL_01a8;
			IL_0026:
			num2 = _003C_003E1__state;
			num = 1;
			goto IL_01a8;
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
		internal static object z9gHMhKrS9B0dHIurASV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSightDisplay)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange cLA7OCKrkemiJHgO4X5k(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSightDisplay)P_0).SelectedRange;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object L9eHkxKr8lZb3O783wdG(object P_0, object P_1, CvsCellRange selectedRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((InspectStepViewModel)P_0).PublishCellTags((CvsInSight)P_1, selectedRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool w3csySKrGQy4XcArh9uE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool f9JLSkKro0FUIwuZIqBj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private List<CvsEditableDisplayGraphic> MtmNvJyVvP;

	private List<CvsEditableDisplayGraphic> jOQNebC6ST;

	private readonly Mutex HpaN2GFW8S;

	[CompilerGenerated]
	private readonly SpreadsheetToolEditorViewModel wZ5NqeaMYd;

	private ExpressionToolbar Y0iNiPHyLk;

	[CompilerGenerated]
	private InspectStepViewModel dncNkjfRiw;

	private EzToolType uEnNPqJSWX;

	private IAsyncDisposable B8VNs13RJJ;

	private IGraphicToolType jO9NKS5xam;

	private IGraphicInvalidateToolType bF2NGVEBch;

	private System.Drawing.Point dFbNBwDgtX;

	private StepDisplayState MZeNZi89GL;

	[CompilerGenerated]
	private readonly CvsAction l5GNn09NNu;

	[CompilerGenerated]
	private readonly CvsAction c3SNtA0lW0;

	public SpreadsheetToolEditorViewModel SpreadsheetEditorViewModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wZ5NqeaMYd;
		}
	}

	public ExpressionToolbar SheetExpressionToolBar
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Y0iNiPHyLk;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Y0iNiPHyLk = value;
			Rp8cFpiv2EhMLyv9EZ5(Y0iNiPHyLk, ExpressionToolbar.UpdateCellNameCommandProperty, SpreadsheetEditorViewModel, XftrswisDV4vBHEUJja(3758), null, null);
		}
	}

	public InspectStepViewModel Inspect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return dncNkjfRiw;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dncNkjfRiw = value;
		}
	}

	private EzToolType AddingToolType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return uEnNPqJSWX;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			nOe5IDidvA0WlJUIOwA();
			int num;
			if (AQKDd9ifJ35WQeVBXO3())
			{
				num = 5;
			}
			else
			{
				num = 4;
				if (!AQKDd9ifJ35WQeVBXO3())
				{
					goto IL_006f;
				}
			}
			goto IL_00ad;
			IL_00ad:
			while (true)
			{
				switch (num)
				{
				case 8:
					if (uEnNPqJSWX != null)
					{
						mmPNOYaGQ8(uEnNPqJSWX as IGraphicToolType);
						num = 6;
						continue;
					}
					return;
				case 0:
				case 5:
					if (uEnNPqJSWX == null)
					{
						goto case 3;
					}
					goto case 1;
				case 9:
					break;
				case 11:
					uEnNPqJSWX = value;
					goto case 8;
				default:
					num = 8;
					if (AQKDd9ifJ35WQeVBXO3())
					{
						continue;
					}
					goto case 2;
				case 2:
					J8NNyPIkGY(null);
					num = 10;
					if (!nOe5IDidvA0WlJUIOwA())
					{
						continue;
					}
					goto case 6;
				case 6:
					J8NNyPIkGY(uEnNPqJSWX as IGraphicInvalidateToolType);
					num = 7;
					if (nOe5IDidvA0WlJUIOwA())
					{
					}
					continue;
				case 7:
					tONy0WiAvgES6DHVW1U(uEnNPqJSWX, new AddGraphicsChangedEventHandler(aBfN342Eyh));
					num = 9;
					continue;
				case 10:
					qYvwrli6oYF1yscOxck(uEnNPqJSWX, new AddGraphicsChangedEventHandler(aBfN342Eyh));
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					goto case 3;
				case 3:
					i5f2c3iCYVVGLENEv4b(Display, null);
					num = 11;
					continue;
				case 1:
				case 4:
					mmPNOYaGQ8(null);
					num = 2;
					if (true)
					{
						continue;
					}
					return;
				case 12:
					return;
				}
				break;
			}
			goto IL_006f;
			IL_006f:
			jOQNebC6ST = new List<CvsEditableDisplayGraphic>((IEnumerable<CvsEditableDisplayGraphic>)fwFLokiRL4JnBYrQ3ZC(Inspect.AddingToolType));
			num = 12;
			goto IL_00ad;
		}
	}

	public StepDisplayState State
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MZeNZi89GL;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 13;
			StepDisplayState mZeNZi89GL = default;
			while (true)
			{
				switch (num)
				{
				case 9:
					ld3pYlnB1X0mx9BC7yM(gxEvvInZqt1eO5H8K4L(LwtE0tnP4OdRv66Qibu(Display)), false);
					_ = 1;
					if (!nOe5IDidvA0WlJUIOwA())
					{
						num = 2;
						continue;
					}
					num = 0;
					if (AQKDd9ifJ35WQeVBXO3())
					{
						continue;
					}
					goto case 16;
				case 22:
					return;
				case 3:
					Inspect.InSight.GraphicsLayerFilter = null;
					num = 23;
					continue;
				case 6:
				case 19:
					MZeNZi89GL = value;
					if (Display == null)
					{
						num = 17;
						continue;
					}
					mZeNZi89GL = MZeNZi89GL;
					num = 21;
					continue;
				case 1:
					ld3pYlnB1X0mx9BC7yM(lVOK7enbBxEC2sQUHtc(LwtE0tnP4OdRv66Qibu(Display)), true);
					break;
				case 16:
					Display.EditInternalGraphics(jOQNebC6ST, TmfNUbNh0C(jOQNebC6ST), null, SE4NFofJg4, YO5NbQKuDD);
					num = 14;
					if (true)
					{
						continue;
					}
					goto case 4;
				case 4:
					switch (mZeNZi89GL)
					{
					case StepDisplayState.Init:
					case StepDisplayState.Live:
					case StepDisplayState.Run:
						break;
					default:
						goto IL_011b;
					case StepDisplayState.Edit:
						goto IL_025b;
					case StepDisplayState.Add:
						goto IL_0381;
					}
					goto case 6;
				case 12:
					((CvsAction)gxEvvInZqt1eO5H8K4L(LwtE0tnP4OdRv66Qibu(Display))).Suppressed = true;
					ld3pYlnB1X0mx9BC7yM(lVOK7enbBxEC2sQUHtc(LwtE0tnP4OdRv66Qibu(Display)), true);
					num = 16;
					continue;
				case 10:
					((CvsInSight)pr4E8YiZyL8DG6G4K0b(Inspect)).GraphicsLayerFilter = cgCNQkyja0;
					MtmNvJyVvP = GetViewableEditGraphics();
					ld3pYlnB1X0mx9BC7yM(gxEvvInZqt1eO5H8K4L(LwtE0tnP4OdRv66Qibu(Display)), true);
					num = 1;
					continue;
				case 7:
					return;
				case 14:
					return;
				case 2:
				case 5:
					((CvsAction)lVOK7enbBxEC2sQUHtc(Display.Edit)).Suppressed = false;
					num = 8;
					continue;
				case 8:
					calkvGnGtluNarAu1eX(((CvsInSightDisplayEdit)LwtE0tnP4OdRv66Qibu(Display)).CancelChanges);
					goto case 6;
				case 13:
					if (Display == null)
					{
						num = 15;
						continue;
					}
					mZeNZi89GL = MZeNZi89GL;
					num = 4;
					continue;
				case 11:
					return;
				case 17:
					return;
				case 21:
					switch (mZeNZi89GL)
					{
					default:
						return;
					case StepDisplayState.Init:
					{
						List<CvsEditableDisplayGraphic> list = jOQNebC6ST;
						if (list == null)
						{
							num = 7;
							continue;
						}
						JjsCNYno7QWdP6o0axq(list);
						return;
					}
					case StepDisplayState.Add:
						AddingToolType = Inspect?.AddingToolType;
						((CvsInSight)pr4E8YiZyL8DG6G4K0b(Inspect)).GraphicsLayerFilter = AddingToolType?.GraphicsLayerFilter;
						Ce4fq9nSHGyONT0UiFs(Display, true);
						num = 12;
						continue;
					case StepDisplayState.Edit:
						break;
					case StepDisplayState.Run:
						XGElminkkZZgJXCaQ7a(Display, true);
						num = 3;
						continue;
					case StepDisplayState.Live:
						return;
					}
					Ce4fq9nSHGyONT0UiFs(Display, true);
					num = 10;
					if (0 == 0)
					{
						continue;
					}
					goto case 2;
				default:
					num = 22;
					continue;
				case 15:
					return;
				case 20:
					((CvsAction)lVOK7enbBxEC2sQUHtc(Display.Edit)).Execute();
					((CvsInSight)pr4E8YiZyL8DG6G4K0b(Inspect)).GraphicsLayerFilter = null;
					num = 19;
					continue;
				case 0:
				case 18:
					break;
				case 23:
					return;
					IL_025b:
					ld3pYlnB1X0mx9BC7yM(gxEvvInZqt1eO5H8K4L(Display.Edit), false);
					ld3pYlnB1X0mx9BC7yM(lVOK7enbBxEC2sQUHtc(LwtE0tnP4OdRv66Qibu(Display)), false);
					num = 20;
					continue;
					IL_011b:
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					goto case 12;
					IL_0381:
					AddingToolType = null;
					num = 9;
					if (!nOe5IDidvA0WlJUIOwA())
					{
						continue;
					}
					goto case 20;
				}
				Display.EditInternalGraphics(MtmNvJyVvP, null, null, gbZNAkgRWu, iboNdIcau4);
				num = 11;
			}
		}
	}

	public CvsAction Publish
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return l5GNn09NNu;
		}
	}

	public CvsAction Unpublish
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return c3SNtA0lW0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InspectStepDisplay(CvsInSightDisplay display, InspectStepViewModel inspect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (AQKDd9ifJ35WQeVBXO3())
		{
			num = 8;
		}
		else
		{
			num = 6;
			if (1 == 0)
			{
				goto IL_009b;
			}
		}
		goto IL_0054;
		IL_0054:
		while (true)
		{
			switch (num)
			{
			case 2:
				SetInspect(inspect);
				num = 11;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 7:
				wZ5NqeaMYd = new SpreadsheetToolEditorViewModel();
				goto default;
			case 4:
				break;
			case 1:
				l5GNn09NNu = new CvsAction(UJbNgiG8YJ);
				num = 10;
				continue;
			case 3:
				HpaN2GFW8S = new Mutex();
				num = 4;
				continue;
			case 0:
			case 8:
				jnQGCQilmxSmKnFMsgE();
				num = 9;
				continue;
			case 9:
				jOQNebC6ST = new List<CvsEditableDisplayGraphic>();
				num = 3;
				if (true)
				{
					continue;
				}
				goto default;
			default:
				NbFXmqigLPl8yJmixda(SpreadsheetEditorViewModel, new EventHandler(AiaNcrXZKW));
				num = 1;
				continue;
			case 10:
				c3SNtA0lW0 = new CvsAction(fS2NMysBLv);
				num = 2;
				if (AQKDd9ifJ35WQeVBXO3())
				{
					continue;
				}
				return;
			case 11:
				return;
			}
			break;
		}
		goto IL_009b;
		IL_009b:
		base._002Ector(display);
		num = 7;
		goto IL_0054;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetInspect(InspectStepViewModel inspectStep)
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
			case 15:
				if (Inspect != null)
				{
					goto case 13;
				}
				return;
			default:
				num = 13;
				break;
			case 10:
				oKRPsgiGGQY8dTD7lvc(Inspect, new PropertyChangedEventHandler(c6PN6loQ51));
				FWtptjiolWEaJnLCnyT(Inspect.Snippets, new NotifyCollectionChangedEventHandler(kqONN8HH3s));
				State = StepDisplayState.Edit;
				num = 16;
				if (true)
				{
					break;
				}
				goto case 6;
			case 6:
				Display.InSight = (CvsInSight)pr4E8YiZyL8DG6G4K0b(Inspect);
				num = 4;
				if (nOe5IDidvA0WlJUIOwA())
				{
				}
				break;
			case 13:
				if (Display != null)
				{
					num = 6;
					break;
				}
				goto case 7;
			case 3:
				if (Inspect != null)
				{
					_ = 0;
					if (AQKDd9ifJ35WQeVBXO3())
					{
						num = 12;
						if (AQKDd9ifJ35WQeVBXO3())
						{
							break;
						}
						goto case 2;
					}
					num = 8;
					break;
				}
				goto case 14;
			case 2:
				K0vaF2iPFJTSyfP8PlR(Inspect, new EventHandler(Ir4N74hWKu));
				num = 0;
				break;
			case 9:
				qcvIFgibLgLLRp8XqEL(Inspect, new EventHandler(Ir4N74hWKu));
				num = 10;
				break;
			case 14:
				Inspect = inspectStep;
				num = 15;
				break;
			case 11:
				Inspect.BeginAdd -= cjVNuW7Qs5;
				num = 2;
				break;
			case 5:
			case 8:
				Inspect.Snippets.CollectionChanged -= kqONN8HH3s;
				MtmNvJyVvP = null;
				num = 14;
				break;
			case 7:
				CUiFnYiBlMQHaJJ61ud(Inspect, new EventHandler(cjVNuW7Qs5));
				num = 9;
				break;
			case 4:
				Display.ShowGrid = false;
				num = 7;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
				Inspect.PropertyChanged -= c6PN6loQ51;
				goto case 5;
			case 1:
			case 12:
				JCUpEWirtt9auE3vick(Display, null);
				num = 11;
				break;
			case 16:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetDisplayToNormalState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (!AQKDd9ifJ35WQeVBXO3())
		{
			goto IL_001e;
		}
		goto IL_0135;
		IL_001e:
		Display.DropHandlers.Remove(typeof(StringViewModel).FullName);
		num = 4;
		goto IL_0135;
		IL_0135:
		while (true)
		{
			switch (num)
			{
			case 11:
				break;
			case 0:
				Display.DropHandlers.Remove(wCd2DSiqcMlFuNSorLt(typeof(EditAnnulusViewModel).TypeHandle).FullName);
				nOe5IDidvA0WlJUIOwA();
				num = ((!AQKDd9ifJ35WQeVBXO3()) ? 5 : 6);
				continue;
			case 3:
				if (Display == null)
				{
					num = 15;
					if (0 == 0)
					{
						continue;
					}
					goto case 5;
				}
				Display.ResultsChanged -= XFp7zjGcdd;
				liGmvZiSUWEfkok2D2E(Display, new EventHandler(mLH71j5dAA));
				num = 10;
				continue;
			case 5:
			case 13:
				Display.DropHandlers.Remove(typeof(EditRegionViewModel).FullName);
				Display.DropHandlers.Remove(wCd2DSiqcMlFuNSorLt(typeof(RegionViewModel).TypeHandle).FullName);
				Display.DropHandlers.Remove(typeof(PointViewModel).FullName);
				num = 16;
				continue;
			case 17:
				Display.DropHandlers.Remove(wCd2DSiqcMlFuNSorLt(typeof(EditFloatViewModel).TypeHandle).FullName);
				break;
			default:
				num = 11;
				if (0 == 0)
				{
					continue;
				}
				goto case 4;
			case 4:
				Display.DropHandlers.Remove(typeof(EditStringViewModel).FullName);
				num = 0;
				continue;
			case 6:
			case 12:
				Display.DropHandlers.Remove(typeof(AnnulusViewModel).FullName);
				goto case 5;
			case 14:
				Display.DropHandlers.Remove(typeof(LineViewModel).FullName);
				num = 18;
				if (0 == 0)
				{
					continue;
				}
				return;
			case 15:
				return;
			case 7:
				Display.DropHandlers.Remove(typeof(EditIntViewModel).FullName);
				num = 2;
				continue;
			case 2:
				Display.DropHandlers.Remove(wCd2DSiqcMlFuNSorLt(typeof(FloatViewModel).TypeHandle).FullName);
				num = 17;
				if (true)
				{
					continue;
				}
				goto case 16;
			case 16:
				Display.DropHandlers.Remove(wCd2DSiqcMlFuNSorLt(typeof(CircleViewModel).TypeHandle).FullName);
				num = 14;
				continue;
			case 1:
				O56gBWi87F57uq2mfZn(Display, new EventHandler(rDENakggjr));
				num = 8;
				continue;
			case 10:
				Display.StateChanged -= lbG7mvw2Io;
				aHwb9aika9kbd0NLCCJ(Display, new EventHandler(eJNN5vC7ET));
				num = 1;
				if (AQKDd9ifJ35WQeVBXO3())
				{
					continue;
				}
				goto case 18;
			case 18:
				Display.DropHandlers.Remove(wCd2DSiqcMlFuNSorLt(typeof(FixtureViewModel).TypeHandle).FullName);
				num = 19;
				if (!nOe5IDidvA0WlJUIOwA())
				{
					continue;
				}
				goto case 9;
			case 9:
				Display.DropHandlers.Remove(wCd2DSiqcMlFuNSorLt(typeof(IntViewModel).TypeHandle).FullName);
				num = 7;
				continue;
			case 8:
				Display.DropHandlers.Remove(wCd2DSiqcMlFuNSorLt(typeof(BoolViewModel).TypeHandle).FullName);
				Display.DropHandlers.Remove(wCd2DSiqcMlFuNSorLt(typeof(CheckBoxViewModel).TypeHandle).FullName);
				num = 9;
				continue;
			case 19:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetDisplayToStepMode()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		do
		{
			IL_0170:
			switch (num)
			{
			case 2:
				if (Display.RunMode)
				{
					num = 6;
					if (nOe5IDidvA0WlJUIOwA())
					{
					}
				}
				else if (State == StepDisplayState.Init)
				{
					num = 1;
					if (nOe5IDidvA0WlJUIOwA())
					{
					}
				}
				else
				{
					State = MZeNZi89GL;
					num = 13;
				}
				goto IL_0170;
			case 7:
				Display.StateChanged += lbG7mvw2Io;
				AQKDd9ifJ35WQeVBXO3();
				if (!nOe5IDidvA0WlJUIOwA())
				{
					num = 5;
					if (!AQKDd9ifJ35WQeVBXO3())
					{
						return;
					}
				}
				else
				{
					num = 0;
				}
				goto IL_0170;
			case 0:
				return;
			case 9:
				return;
			case 1:
				State = StepDisplayState.Edit;
				return;
			case 6:
				State = StepDisplayState.Run;
				return;
			case 4:
			case 5:
				oMNbKciXQTJRUAYWnJM(Display, new EventHandler(eJNN5vC7ET));
				num = 11;
				goto IL_0170;
			case 8:
				if (Display == null)
				{
					num = 10;
					if (!AQKDd9ifJ35WQeVBXO3())
					{
						return;
					}
				}
				else
				{
					pMZoqriEqd8DUSZHZ6N(Display, new EventHandler(XFp7zjGcdd));
					num = 12;
				}
				goto IL_0170;
			case 10:
				return;
			case 12:
				rClZhaipSWJIGHAPpVo(Display, new EventHandler(mLH71j5dAA));
				num = 7;
				goto IL_0170;
			case 11:
				kFDNWNi9fVLBG3ClMDm(Display, new EventHandler(rDENakggjr));
				break;
			default:
				num = 3;
				if (true)
				{
					goto IL_0170;
				}
				break;
			case 3:
				break;
			case 13:
				return;
			}
			JCUpEWirtt9auE3vick(Display, pr4E8YiZyL8DG6G4K0b(Inspect));
			num = 2;
		}
		while (AQKDd9ifJ35WQeVBXO3());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void jPa7rjdfJ4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		AQKDd9ifJ35WQeVBXO3();
		int num;
		if (!nOe5IDidvA0WlJUIOwA())
		{
			num = 2;
			if (nOe5IDidvA0WlJUIOwA())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0050;
		IL_0077:
		lR378CGJDJ(r8p8wPi4s2QCDALmVHP(Display), ((CvsInSight)vyIriDi3S0tCIi6em8Y(Display)).IsLiveAcquisition);
		num = 5;
		if (0 == 0)
		{
			goto IL_0050;
		}
		goto IL_00a4;
		IL_00a4:
		F0pKnXi7ZTRp5jtZ1D7(SpreadsheetEditorViewModel, r8p8wPi4s2QCDALmVHP(Display));
		goto IL_002e;
		IL_002e:
		if (Display.InSight != null)
		{
			goto IL_0077;
		}
		return;
		IL_0050:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			default:
				num = 3;
				continue;
			case 3:
				goto IL_0077;
			case 0:
			case 2:
				goto IL_00a4;
			case 5:
				return;
			}
			break;
		}
		goto IL_002e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void d8d7hcgFW3(StepDisplayState P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (State != P_0)
		{
			State = P_0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lR378CGJDJ(bool P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (nOe5IDidvA0WlJUIOwA() ? 5 : 4);
		while (true)
		{
			switch (num)
			{
			case 7:
				return;
			case 8:
				if (Inspect.IsActive)
				{
					goto case 2;
				}
				return;
			case 6:
				d8d7hcgFW3(StepDisplayState.Live);
				num = 3;
				break;
			case 2:
			case 5:
				if (!P_0)
				{
					if (P_1)
					{
						num = 6;
						break;
					}
					d8d7hcgFW3(StepDisplayState.Edit);
					num = 9;
				}
				else
				{
					num = 1;
				}
				break;
			case 1:
				d8d7hcgFW3(StepDisplayState.Run);
				return;
			default:
				num = 7;
				if (!AQKDd9ifJ35WQeVBXO3())
				{
					return;
				}
				break;
			case 3:
				return;
			case 0:
			case 4:
				if (Inspect != null)
				{
					num = 8;
					break;
				}
				return;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetDisplay(CvsInSightDisplay display)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nOe5IDidvA0WlJUIOwA();
		int num;
		if (AQKDd9ifJ35WQeVBXO3())
		{
			num = 3;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 7;
		}
		goto IL_006e;
		IL_002a:
		S17iAVijb4n9ud2TK2d(this);
		num = 8;
		goto IL_006e;
		IL_006e:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 6:
				if (Display != null)
				{
					num = 5;
					if (AQKDd9ifJ35WQeVBXO3())
					{
						continue;
					}
					goto case 2;
				}
				return;
			case 2:
				Display = display;
				goto case 6;
			default:
				num = 6;
				if (true)
				{
					continue;
				}
				goto case 4;
			case 4:
				SetDisplayToNormalState();
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 3:
				base.SetDisplay(display);
				goto case 1;
			case 1:
			case 7:
				if (Display != null)
				{
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					return;
				}
				goto case 2;
			case 8:
				return;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void lbG7mvw2Io(object P_0, CvsDisplayStateChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ygLNp9mwVB();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mLH71j5dAA(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ygLNp9mwVB();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void XFp7zjGcdd(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ygLNp9mwVB();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rDENakggjr(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		jPa7rjdfJ4();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void eJNN5vC7ET(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SpreadsheetEditorViewModel.InSight = (CvsInSight)vyIriDi3S0tCIi6em8Y(Display);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ygLNp9mwVB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		bool flag2 = default;
		bool flag = default;
		bool enabled = default;
		while (true)
		{
			object obj;
			switch (num)
			{
			case 7:
				flag2 = false;
				num = 13;
				break;
			case 3:
				flag = false;
				num = 0;
				if (!nOe5IDidvA0WlJUIOwA())
				{
					break;
				}
				goto case 0;
			case 0:
				enabled = false;
				num = 6;
				break;
			case 13:
			{
				CvsCell[] source = qrtqoIiTuWHXl9pjEH8(Display).Select([MethodImpl(MethodImplOptions.NoInlining)] (CvsCellLocation P_0) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return ((CvsInSight)vyIriDi3S0tCIi6em8Y(Display)).Results.Cells[P_0];
				}).Where([MethodImpl(MethodImplOptions.NoInlining)] (CvsCell cell) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return !_003C_003Ec.CN2ir1KvT3t80A7SkxPR(cell) && cell.CanBeOutputPin();
				}).ToArray();
				flag = source.Any([MethodImpl(MethodImplOptions.NoInlining)] (CvsCell c) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return cAaNfIYmra(c);
				}) & flag2;
				enabled = source.Any([MethodImpl(MethodImplOptions.NoInlining)] (CvsCell c) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return _003C_003Ec.DLxVmeKvybf3v6qwXGdr(c);
				});
				goto case 9;
			}
			default:
				num = 9;
				if (!nOe5IDidvA0WlJUIOwA())
				{
					break;
				}
				goto case 4;
			case 4:
				CvsAction.SetEnabled(Unpublish, enabled);
				if (SheetExpressionToolBar != null)
				{
					num = 12;
					break;
				}
				return;
			case 5:
			case 11:
				Sl7AxQiFJycLNpkgwiD(SheetExpressionToolBar.ExpressionTextBox, false);
				num = 14;
				break;
			case 6:
				if (qwI2OciWQM140X7LgaL(Display.InSight) != null)
				{
					num = 7;
					if (!nOe5IDidvA0WlJUIOwA())
					{
						break;
					}
				}
				goto case 9;
			case 9:
				YNtVJCiyeYJTnjSyUk8(Publish, flag);
				num = 4;
				break;
			case 12:
				Sl7AxQiFJycLNpkgwiD(SheetExpressionToolBar.ExpressionTextBox, Display.State == CvsDisplayState.Normal || LtoEWyi033UC0CUpZ5H(Display) == CvsDisplayState.EditingCellExpression);
				return;
			case 10:
				YNtVJCiyeYJTnjSyUk8(Unpublish, false);
				if (SheetExpressionToolBar != null)
				{
					goto case 5;
				}
				return;
			case 2:
			{
				CvsInSightDisplay display = Display;
				if (display == null)
				{
					AQKDd9ifJ35WQeVBXO3();
					if (nOe5IDidvA0WlJUIOwA())
					{
						num = 5;
						break;
					}
					num = 8;
					if (true)
					{
						break;
					}
					goto case 1;
				}
				obj = display.InSight;
				goto IL_0262;
			}
			case 1:
			case 8:
				obj = null;
				goto IL_0262;
			case 14:
				return;
				IL_0262:
				if (obj == null || Display.InSight.State == CvsInSightState.NotConnected)
				{
					YNtVJCiyeYJTnjSyUk8(Publish, false);
					num = 10;
				}
				else
				{
					num = 3;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CvsEditableDisplayGraphic TmfNUbNh0C(List<CvsEditableDisplayGraphic> P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsEditableDisplayGraphic cvsEditableDisplayGraphic = P_0.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (CvsEditableDisplayGraphic g) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec.bqs9XGKv0KkR4LXRj5Zl(g) != CvsEditFlags.None;
		});
		if (cvsEditableDisplayGraphic is CvsDisplayableComposite cvsDisplayableComposite && cvsDisplayableComposite.Children.Length != 0)
		{
			cvsEditableDisplayGraphic = cvsDisplayableComposite.Children[0] as CvsEditableDisplayGraphic;
		}
		return cvsEditableDisplayGraphic;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Ir4N74hWKu(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		State = StepDisplayState.Edit;
		uSWNIOilgB();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void kqONN8HH3s(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		EzTool ezTool = default;
		NotifyCollectionChangedAction action = default;
		while (true)
		{
			switch (num)
			{
			case 9:
				State = StepDisplayState.Edit;
				num = 11;
				break;
			case 10:
				State = StepDisplayState.Edit;
				num = 1;
				break;
			case 3:
			case 5:
				if (ezTool != null)
				{
					goto case 2;
				}
				return;
			case 0:
				if (action == NotifyCollectionChangedAction.Remove)
				{
					num = 10;
					break;
				}
				return;
			case 8:
				action = P_1.Action;
				num = 7;
				break;
			case 2:
			case 6:
				do
				{
					CvsEditableDisplayGraphic[] viewableEditGraphics = ezTool.GetViewableEditGraphics();
					if (viewableEditGraphics != null)
					{
						if (viewableEditGraphics.Length != 0 && Inspect.IsActive)
						{
							num = 9;
							continue;
						}
						return;
					}
					num = 4;
					if (0 == 0)
					{
						break;
					}
					return;
				}
				while (1 == 0);
				break;
			case 1:
				return;
			default:
				AQKDd9ifJ35WQeVBXO3();
				num = ((!nOe5IDidvA0WlJUIOwA()) ? 3 : 2);
				break;
			case 7:
				if (action == NotifyCollectionChangedAction.Add)
				{
					ezTool = yPfb6jiYZWWioo75Obo(GOIkuXiMtm7K4WWXVer(P_1), 0) as EzTool;
					goto default;
				}
				num = 0;
				break;
			case 4:
				return;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnGraphicChanged_003Ed__37))]
	private Task gbZNAkgRWu(object P_0, CvsEditEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003COnGraphicChanged_003Ed__37 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 6:
				stateMachine.sender = P_0;
				goto case 3;
			case 4:
				stateMachine._003C_003E4__this = this;
				nOe5IDidvA0WlJUIOwA();
				num = (AQKDd9ifJ35WQeVBXO3() ? 6 : 7);
				continue;
			case 5:
				stateMachine._003C_003Et__builder = ESnHvIiUnZJr6ByyfLK();
				num = 4;
				if (nOe5IDidvA0WlJUIOwA())
				{
				}
				continue;
			case 0:
				stateMachine._003C_003E1__state = -1;
				num = 1;
				continue;
			case 3:
			case 7:
				stateMachine.e = P_1;
				goto case 0;
			default:
				num = 0;
				continue;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
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
	public override List<CvsEditableDisplayGraphic> GetViewableEditGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Inspect.GetViewableEditGraphics();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task iboNdIcau4(object P_0, CvsEditEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)mSXTn0iHRD4S45eEfEr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void c6PN6loQ51(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 15;
		bool? flag2 = default;
		while (true)
		{
			bool? flag;
			switch (num)
			{
			case 2:
			case 4:
				flag = flag2;
				goto IL_0028;
			case 9:
				if (iWObvUicjqLZQbuWM2y(Inspect))
				{
					goto case 7;
				}
				return;
			case 6:
				loBNlRYn13();
				num = 11;
				break;
			case 11:
				return;
			case 14:
				flag = flag2;
				goto IL_0028;
			case 7:
			case 8:
				if (State != StepDisplayState.Run)
				{
					goto case 3;
				}
				return;
			default:
				num = 3;
				if (AQKDd9ifJ35WQeVBXO3())
				{
					break;
				}
				goto case 5;
			case 5:
				State = StepDisplayState.Edit;
				num = 6;
				break;
			case 13:
				if (fJK1w5imH83KKKGXWD6(RKegD5ixxw8ElMyWVFF(P_1), CdQUGaROfy7He9T0foW.KbIzwHEDLa(3830), StringComparison.Ordinal))
				{
					num = 0;
					break;
				}
				return;
			case 0:
			{
				object obj = NLTluDiQ1rhWEVMcdl5(Inspect);
				if (obj != null)
				{
					object obj2 = Vt3cfwiN0jMFIlPUIdA(obj);
					if (obj2 != null)
					{
						flag = Lx6F7Oi2iyZi9Mw9iD0(obj2);
						goto IL_0028;
					}
					flag2 = null;
					_ = 1;
					if (nOe5IDidvA0WlJUIOwA())
					{
						num = 8;
						if (!nOe5IDidvA0WlJUIOwA())
						{
							break;
						}
						goto case 6;
					}
					num = 2;
					break;
				}
				flag2 = null;
				num = 14;
				break;
			}
			case 3:
				if (Inspect.CurrentTool == null)
				{
					if (UTniJJi1vINhlqC5pVt(Inspect) != null)
					{
						return;
					}
					num = 10;
				}
				else
				{
					num = 12;
				}
				break;
			case 16:
				State = StepDisplayState.Live;
				num = 9;
				break;
			case 1:
				FvGN4FqIx3();
				num = 17;
				if (!nOe5IDidvA0WlJUIOwA())
				{
					break;
				}
				goto case 12;
			case 12:
				FvGN4FqIx3();
				num = 5;
				break;
			case 10:
				if (State != StepDisplayState.Add)
				{
					State = StepDisplayState.Edit;
					num = 1;
					if (AQKDd9ifJ35WQeVBXO3())
					{
						break;
					}
					goto case 15;
				}
				return;
			case 15:
				if (!fJK1w5imH83KKKGXWD6(RKegD5ixxw8ElMyWVFF(P_1), XftrswisDV4vBHEUJja(3804), StringComparison.Ordinal))
				{
					num = 13;
					break;
				}
				goto case 0;
			case 17:
				return;
				IL_0028:
				flag2 = flag;
				if (flag2 == true)
				{
					num = 16;
					break;
				}
				goto case 9;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cjVNuW7Qs5(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		State = StepDisplayState.Add;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnAddGraphicChanged_003Ed__43))]
	private Task SE4NFofJg4(object P_0, CvsEditEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nOe5IDidvA0WlJUIOwA();
		int num;
		if (AQKDd9ifJ35WQeVBXO3())
		{
			num = 6;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 7;
			if (nOe5IDidvA0WlJUIOwA())
			{
				goto IL_0099;
			}
		}
		goto IL_005a;
		IL_005a:
		_003COnAddGraphicChanged_003Ed__43 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 6:
				break;
			case 3:
				stateMachine.e = P_1;
				goto IL_0099;
			default:
				goto IL_0099;
			case 2:
				stateMachine.sender = P_0;
				num = 3;
				continue;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				continue;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 2;
				continue;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_0099:
		stateMachine._003C_003E1__state = -1;
		num = 5;
		goto IL_005a;
		IL_002a:
		stateMachine._003C_003Et__builder = ESnHvIiUnZJr6ByyfLK();
		num = 1;
		goto IL_005a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnGraphicChangedAsync_003Ed__44))]
	private Task fI8NXRbmFw(object P_0, CvsEditEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (nOe5IDidvA0WlJUIOwA() ? 5 : 4);
		_003COnGraphicChangedAsync_003Ed__44 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				stateMachine._003C_003E1__state = -1;
				num = 3;
				break;
			case 6:
				stateMachine.e = P_1;
				goto case 7;
			default:
				num = 7;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 1;
				break;
			case 2:
			case 5:
				stateMachine.sender = P_0;
				num = 6;
				break;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private IGraphicToolType oPONCwLRso()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return jO9NKS5xam;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private void mmPNOYaGQ8(IGraphicToolType value)
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
			case 2:
			case 6:
				A6hbo2ihOJxGuRl1Vqq(Display, new MouseEventHandler(nfCNSTDeGs));
				goto case 3;
			case 1:
				Display.PaintGraphics += HVmNDuBNxW;
				num = 5;
				break;
			case 7:
				GIyj5LiutQuLd0jGwjH(Display, new PaintEventHandler(HVmNDuBNxW));
				_ = 0;
				if (!AQKDd9ifJ35WQeVBXO3())
				{
					num = 8;
					if (true)
					{
						break;
					}
					goto case 1;
				}
				num = 6;
				if (nOe5IDidvA0WlJUIOwA())
				{
				}
				break;
			case 5:
				KiNYgoitXNqORPsK2ja(Display, new MouseEventHandler(nfCNSTDeGs));
				num = 9;
				break;
			case 4:
				if (jO9NKS5xam != null)
				{
					num = 1;
					break;
				}
				return;
			case 0:
				if (jO9NKS5xam != null)
				{
					num = 7;
					if (nOe5IDidvA0WlJUIOwA())
					{
					}
					break;
				}
				goto case 3;
			case 3:
			case 8:
				jO9NKS5xam = value;
				goto case 4;
			default:
				num = 4;
				if (false)
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
	[SpecialName]
	private IGraphicInvalidateToolType QXnNwVVGFl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return bF2NGVEBch;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private void J8NNyPIkGY(IGraphicInvalidateToolType value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nOe5IDidvA0WlJUIOwA();
		int num;
		if (AQKDd9ifJ35WQeVBXO3())
		{
			num = 6;
		}
		else
		{
			num = 5;
			if (false)
			{
				goto IL_0078;
			}
		}
		goto IL_0041;
		IL_0078:
		Pd4rIGizEOB05S8BM3M(bF2NGVEBch, new EventHandler(JRNNomp0iU));
		num = 7;
		if (true)
		{
			goto IL_0041;
		}
		goto IL_009b;
		IL_009b:
		if (bF2NGVEBch != null)
		{
			num = 2;
			goto IL_0041;
		}
		return;
		IL_0041:
		while (true)
		{
			switch (num)
			{
			case 1:
				bF2NGVEBch = value;
				goto IL_009b;
			case 2:
				break;
			default:
				goto IL_009b;
			case 4:
				Pd4rIGizEOB05S8BM3M(bF2NGVEBch, new EventHandler(JRNNomp0iU));
				num = 1;
				continue;
			case 0:
			case 6:
				if (bF2NGVEBch != null)
				{
					num = 4;
					continue;
				}
				goto case 1;
			case 7:
				return;
			}
			break;
		}
		goto IL_0078;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void JRNNomp0iU(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		drXi17nLwjTpvmtXFpQ(Display);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nfCNSTDeGs(object P_0, MouseEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		PointF pointF = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				if (!pointF.IsEmpty)
				{
					goto default;
				}
				return;
			default:
				drXi17nLwjTpvmtXFpQ(Display);
				num = 6;
				if (!nOe5IDidvA0WlJUIOwA())
				{
					break;
				}
				goto case 4;
			case 4:
				dFbNBwDgtX = b8bhdWnKbjBdtwQH7Zh(P_1);
				_ = 1;
				num = (nOe5IDidvA0WlJUIOwA() ? 5 : 0);
				break;
			case 0:
			case 1:
				pointF = Ne3Wwcn53OqMpE3KBBs(oPONCwLRso());
				num = 2;
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void HVmNDuBNxW(object P_0, PaintEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		PointF pointF = default;
		PointF[] array = default;
		PointF center = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				pointF = array[0];
				goto case 5;
			case 1:
				yBgQsCnaSh8FYKuNCFc(SguW9pnJISv9bMqmvOs(Display), array);
				goto case 3;
			default:
				num = 3;
				break;
			case 5:
			case 6:
				RvWwAXnOAmfc7SgvEhf(P_1.Graphics, n6piGbneGDDkqTVAup5(), Ne3Wwcn53OqMpE3KBBs(oPONCwLRso()), pointF);
				num = 8;
				if (true)
				{
					break;
				}
				goto case 4;
			case 4:
				if (!center.IsEmpty)
				{
					_ = 1;
					num = ((!nOe5IDidvA0WlJUIOwA()) ? 7 : 6);
					break;
				}
				return;
			case 2:
			case 7:
				array = new PointF[1] { jkKRjynwH4c6w1G3mKD(dFbNBwDgtX) };
				num = 1;
				if (nOe5IDidvA0WlJUIOwA())
				{
				}
				break;
			case 0:
				center = oPONCwLRso().Center;
				num = 4;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void aBfN342Eyh(object P_0, AddGraphicsChangedEventHandlerArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!nOe5IDidvA0WlJUIOwA())
		{
			num = 2;
		}
		else
		{
			num = 6;
			if (nOe5IDidvA0WlJUIOwA())
			{
				goto IL_0093;
			}
		}
		goto IL_003d;
		IL_0093:
		if (P_1.ToAdd == null)
		{
			num = 3;
			goto IL_003d;
		}
		goto IL_00a9;
		IL_00a9:
		IEnumerator<CvsEditableDisplayGraphic> enumerator = P_1.ToBeRemoved.GetEnumerator();
		num = 5;
		goto IL_003d;
		IL_003d:
		while (true)
		{
			switch (num)
			{
			case 3:
				State = StepDisplayState.Add;
				return;
			default:
				num = 4;
				if (AQKDd9ifJ35WQeVBXO3())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				if (P_1.ToBeRemoved == null)
				{
					break;
				}
				goto IL_00a9;
			case 1:
			case 6:
				break;
			case 4:
				return;
			case 5:
				try
				{
					while (AJqACEniF8tY0yn1Pho(enumerator))
					{
						CvsEditableDisplayGraphic current = enumerator.Current;
						AQKDd9ifJ35WQeVBXO3();
						switch (nOe5IDidvA0WlJUIOwA() ? 3 : 2)
						{
						case 0:
						case 2:
							lLk2kgnDh9wZtoF6I0D(ifqpJGnINyVXJt3nkIN(Display), current, false);
							break;
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						vAlNrpnnheTp8tksZVb(enumerator);
					}
				}
				enumerator = P_1.ToAdd.GetEnumerator();
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 7:
				try
				{
					while (AJqACEniF8tY0yn1Pho(enumerator))
					{
						CvsEditableDisplayGraphic current2 = enumerator.Current;
						nOe5IDidvA0WlJUIOwA();
						switch ((!AQKDd9ifJ35WQeVBXO3()) ? 3 : 2)
						{
						case 0:
						case 2:
							ywoLf4nV2FUamjKiLGM(Display.InteractiveGraphics, current2, false);
							break;
						}
					}
					return;
				}
				finally
				{
					if (enumerator != null)
					{
						vAlNrpnnheTp8tksZVb(enumerator);
					}
				}
			}
			break;
		}
		goto IL_0093;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void uSWNIOilgB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			object obj = vyIriDi3S0tCIi6em8Y(Display);
			if (obj != null)
			{
				zpvp2VnfwKvxWWRQKn0(obj, true, true);
			}
		}
		catch (Exception ex)
		{
			HlFEHandwSnO0iuJ0AE(LogManager.GetLogger<InspectStepDisplay>(), LogLevel.Error, CdQUGaROfy7He9T0foW.KbIzwHEDLa(3854), ex);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool cAaNfIYmra(CvsCell P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!V0QKNInl9qXYtLg1Y5k(P_0) && !c8E2DHngbfZ19ALSitf(P_0))
		{
			return f1qGAMnvdA3WkY4nLgN(Gv3BeKnsRY6UdTdQL40(P_0));
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool MdpNEFbL2c(CvsCell P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (P_0.Output)
		{
			return !f1qGAMnvdA3WkY4nLgN(P_0.Name);
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task YO5NbQKuDD(object P_0, CvsEditEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		AddingToolType = null;
		return (Task)mSXTn0iHRD4S45eEfEr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AiaNcrXZKW(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xFDGernrt8fkFyL6SKH(Display);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool cgCNQkyja0(CvsCogShape P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!AQKDd9ifJ35WQeVBXO3()) ? 17 : 13);
		_003C_003Ec__DisplayClass67_0 CS_0024_003C_003E8__locals14 = default;
		_003C_003Ec__DisplayClass67_2 obj = default;
		fOZu4ITbNGZ3gNxDns fOZu4ITbNGZ3gNxDns2 = default;
		bool result = default;
		EzTool ezTool = default;
		while (true)
		{
			object obj2;
			switch (num)
			{
			case 11:
			{
				InspectStepViewModel inspect = Inspect;
				if (inspect == null)
				{
					num = 8;
					if (!nOe5IDidvA0WlJUIOwA())
					{
						continue;
					}
					goto case 4;
				}
				obj2 = inspect.Tools.FirstOrDefault(CS_0024_003C_003E8__locals14._003CFilterOutEditGraphics_003Eb__1);
				goto IL_0176;
			}
			case 4:
				CS_0024_003C_003E8__locals14.shape = P_0;
				CS_0024_003C_003E8__locals14._003C_003E4__this = this;
				CS_0024_003C_003E8__locals14.cellLocation = new CvsCellLocation((string)uXpbyrn8SAorHfehNA8(CS_0024_003C_003E8__locals14.shape));
				num = 11;
				continue;
			case 16:
				obj._003Cpoint_003E5__3 = CS_0024_003C_003E8__locals14.shape as CvsCogPoint;
				goto case 15;
			default:
				num = 15;
				if (AQKDd9ifJ35WQeVBXO3())
				{
					continue;
				}
				goto case 10;
			case 10:
				return JLCtTTnqokAqNUHGfLC(fOZu4ITbNGZ3gNxDns2, CS_0024_003C_003E8__locals14.shape);
			case 15:
				if (obj._003Cpoint_003E5__3 == null)
				{
					num = 9;
					continue;
				}
				result = GetEditableGraphicsOfType<CvsCogPoint>().Any(obj._003CFilterOutEditGraphics_003Eb__5);
				num = 2;
				continue;
			case 9:
				obj._003Cregion_003E5__4 = CS_0024_003C_003E8__locals14.shape as CvsCogRegion;
				num = 7;
				if (AQKDd9ifJ35WQeVBXO3())
				{
					continue;
				}
				goto case 8;
			case 8:
				obj2 = null;
				goto IL_0176;
			case 3:
				result = false;
				num = 19;
				if (nOe5IDidvA0WlJUIOwA())
				{
				}
				continue;
			case 5:
				obj._003Cannulus_003E5__2 = CS_0024_003C_003E8__locals14.shape as CvsCogAnnulus;
				if (obj._003Cannulus_003E5__2 == null)
				{
					num = 16;
					continue;
				}
				result = GetEditableGraphicsOfType<CvsCogAnnulus>().Any(obj._003CFilterOutEditGraphics_003Eb__4);
				break;
			case 6:
				if (fOZu4ITbNGZ3gNxDns2 != null)
				{
					num = 10;
					continue;
				}
				goto IL_0104;
			case 18:
				fOZu4ITbNGZ3gNxDns2 = ezTool as fOZu4ITbNGZ3gNxDns;
				num = 6;
				continue;
			case 0:
			case 13:
				CS_0024_003C_003E8__locals14 = new _003C_003Ec__DisplayClass67_0();
				num = 4;
				continue;
			case 7:
				if (obj._003Cregion_003E5__4 != null)
				{
					result = GetEditableGraphicsOfType<CvsCogRegion>().Any(obj._003CFilterOutEditGraphics_003Eb__6);
					num = 12;
				}
				else
				{
					num = 3;
				}
				continue;
			case 1:
			case 2:
			case 12:
			case 14:
			case 17:
			case 19:
				break;
				IL_0104:
				obj = new _003C_003Ec__DisplayClass67_2();
				if (!(CS_0024_003C_003E8__locals14.shape is CvsCogCompositeRegion))
				{
					num = 5;
					continue;
				}
				result = true;
				num = 1;
				if (true)
				{
					continue;
				}
				break;
				IL_0176:
				ezTool = (EzTool)obj2;
				if (ezTool != null)
				{
					num = 18;
					continue;
				}
				goto IL_0104;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoPublish_003Ed__71))]
	private void UJbNgiG8YJ()
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
		goto IL_0086;
		IL_001a:
		_003CDoPublish_003Ed__71 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		AQKDd9ifJ35WQeVBXO3();
		num = (nOe5IDidvA0WlJUIOwA() ? 4 : 5);
		goto IL_0086;
		IL_0086:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 0:
				stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
				num = 1;
				if (true)
				{
					continue;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fS2NMysBLv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		d8eyCSnpNl7NuUrpCZJ(SMod1GnEBMISMLhyKbE(Display.InSight.CogSocket), qrtqoIiTuWHXl9pjEH8(Display), true, new DictionaryEntry[3]
		{
			new DictionaryEntry(XftrswisDV4vBHEUJja(3900), string.Empty),
			new DictionaryEntry(XftrswisDV4vBHEUJja(3912), false),
			new DictionaryEntry(CdQUGaROfy7He9T0foW.KbIzwHEDLa(3926), false)
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private CvsCell s8eNRQajEf(CvsCellLocation P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)vyIriDi3S0tCIi6em8Y(Display)).Results.Cells[P_0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void FvGN4FqIx3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsInSightDisplay display = Display;
		if (display != null)
		{
			Ba351cnXaSouDkp1vvQ(display.InteractiveGraphics, null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void loBNlRYn13()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		CvsEditableDisplayGraphic cvsEditableDisplayGraphic = default;
		_003C_003Ec__DisplayClass41_0 obj = default;
		while (true)
		{
			object obj2;
			switch (num)
			{
			case 8:
			{
				CvsInSightDisplay display = Display;
				if (display == null)
				{
					return;
				}
				display.InteractiveGraphics.SetFocusGraphic(cvsEditableDisplayGraphic.Children[0]);
				num = 4;
				break;
			}
			case 6:
				return;
			case 1:
			case 3:
				obj.cellRange = ((EzSnippet)UTniJJi1vINhlqC5pVt(Inspect)).CellRange;
				num = 7;
				break;
			case 0:
				obj2 = null;
				goto IL_006c;
			case 9:
				return;
			case 4:
				return;
			case 10:
				while (!((IEnumerable<ICvsEditableDisplayGraphic>)UGHmsHn9YYy62DTIbeH(cvsEditableDisplayGraphic)).Any())
				{
					CvsInSightDisplay display2 = Display;
					if (display2 == null)
					{
						num = 5;
						if (AQKDd9ifJ35WQeVBXO3())
						{
							goto end_IL_00e4;
						}
						continue;
					}
					Ba351cnXaSouDkp1vvQ(display2.InteractiveGraphics, cvsEditableDisplayGraphic);
					num = 11;
					goto end_IL_00e4;
				}
				goto case 8;
			default:
				num = 8;
				if (!AQKDd9ifJ35WQeVBXO3())
				{
					return;
				}
				break;
			case 5:
				return;
			case 7:
			{
				List<CvsEditableDisplayGraphic> mtmNvJyVvP = MtmNvJyVvP;
				if (mtmNvJyVvP != null)
				{
					obj2 = mtmNvJyVvP.FirstOrDefault(obj._003CInspect_PropertyChanged_003Eb__2);
					goto IL_006c;
				}
				num = 0;
				break;
			}
			case 2:
				obj = new _003C_003Ec__DisplayClass41_0();
				_ = 1;
				num = ((!nOe5IDidvA0WlJUIOwA()) ? 3 : 9);
				break;
			case 11:
				return;
				IL_006c:
				cvsEditableDisplayGraphic = (CvsEditableDisplayGraphic)obj2;
				if (cvsEditableDisplayGraphic != null)
				{
					num = 10;
					if (nOe5IDidvA0WlJUIOwA())
					{
					}
					break;
				}
				return;
				end_IL_00e4:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jnQGCQilmxSmKnFMsgE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NbFXmqigLPl8yJmixda(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SpreadsheetToolEditorViewModel)P_0).DisplayFocusChanged += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AQKDd9ifJ35WQeVBXO3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nOe5IDidvA0WlJUIOwA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XftrswisDV4vBHEUJja(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Rp8cFpiv2EhMLyv9EZ5(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((DependencyObject)P_0).BindProperty((DependencyProperty)P_1, P_2, (string)P_3, (IValueConverter)P_4, P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JCUpEWirtt9auE3vick(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplay)P_0).InSight = (CvsInSight)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void K0vaF2iPFJTSyfP8PlR(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((InspectStepViewModel)P_0).CancelAdd -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pr4E8YiZyL8DG6G4K0b(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CUiFnYiBlMQHaJJ61ud(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((InspectStepViewModel)P_0).BeginAdd += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qcvIFgibLgLLRp8XqEL(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((InspectStepViewModel)P_0).CancelAdd += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oKRPsgiGGQY8dTD7lvc(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FWtptjiolWEaJnLCnyT(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ObservableCollection<EzSnippet>)P_0).CollectionChanged += (NotifyCollectionChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void liGmvZiSUWEfkok2D2E(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplay)P_0).SelectedRangeChanged -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aHwb9aika9kbd0NLCCJ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplay)P_0).InSightChanged -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void O56gBWi87F57uq2mfZn(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplay)P_0).RunModeChanged -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type wCd2DSiqcMlFuNSorLt(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pMZoqriEqd8DUSZHZ6N(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplay)P_0).ResultsChanged += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rClZhaipSWJIGHAPpVo(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplay)P_0).SelectedRangeChanged += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oMNbKciXQTJRUAYWnJM(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplay)P_0).InSightChanged += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kFDNWNi9fVLBG3ClMDm(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplay)P_0).RunModeChanged += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool r8p8wPi4s2QCDALmVHP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSightDisplay)P_0).RunMode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void F0pKnXi7ZTRp5jtZ1D7(object P_0, bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SpreadsheetToolEditorViewModel)P_0).RunMode = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vyIriDi3S0tCIi6em8Y(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSightDisplay)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void S17iAVijb4n9ud2TK2d(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((AppStepDisplayBase)P_0).SetDisplayToStepMode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qYvwrli6oYF1yscOxck(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzToolType)P_0).AddGraphicsChanged -= (AddGraphicsChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void i5f2c3iCYVVGLENEv4b(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplay)P_0).DisplayApplicationGraphics((CvsGraphic[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tONy0WiAvgES6DHVW1U(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzToolType)P_0).AddGraphicsChanged += (AddGraphicsChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fwFLokiRL4JnBYrQ3ZC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzToolType)P_0).GetEditableGraphics();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qwI2OciWQM140X7LgaL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Results;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellRange qrtqoIiTuWHXl9pjEH8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSightDisplay)P_0).SelectedRange;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YNtVJCiyeYJTnjSyUk8(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsAction.SetEnabled((CvsAction)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsDisplayState LtoEWyi033UC0CUpZ5H(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSightDisplay)P_0).State;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Sl7AxQiFJycLNpkgwiD(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((UIElement)P_0).IsEnabled = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GOIkuXiMtm7K4WWXVer(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((NotifyCollectionChangedEventArgs)P_0).NewItems;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yPfb6jiYZWWioo75Obo(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IList)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder ESnHvIiUnZJr6ByyfLK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mSXTn0iHRD4S45eEfEr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RKegD5ixxw8ElMyWVFF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertyChangedEventArgs)P_0).PropertyName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fJK1w5imH83KKKGXWD6(object P_0, object P_1, StringComparison P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NLTluDiQ1rhWEVMcdl5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).AppViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Vt3cfwiN0jMFIlPUIdA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BaseIdeViewModel)P_0).Runtime;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Lx6F7Oi2iyZi9Mw9iD0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((RuntimeViewModel)P_0).IsLiveMode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool iWObvUicjqLZQbuWM2y(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StepBase)P_0).IsActive;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UTniJJi1vINhlqC5pVt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((InspectStepViewModel)P_0).CurrentTool;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GIyj5LiutQuLd0jGwjH(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplay)P_0).PaintGraphics -= (PaintEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void A6hbo2ihOJxGuRl1Vqq(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Control)P_0).MouseMove -= (MouseEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KiNYgoitXNqORPsK2ja(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Control)P_0).MouseMove += (MouseEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Pd4rIGizEOB05S8BM3M(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IGraphicInvalidateToolType)P_0).Invalidate += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void drXi17nLwjTpvmtXFpQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplay)P_0).Invalidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static System.Drawing.Point b8bhdWnKbjBdtwQH7Zh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MouseEventArgs)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF Ne3Wwcn53OqMpE3KBBs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IGraphicToolType)P_0).Center;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF jkKRjynwH4c6w1G3mKD(System.Drawing.Point P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SguW9pnJISv9bMqmvOs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSightDisplay)P_0).ClientToSensorTransform;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yBgQsCnaSh8FYKuNCFc(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Matrix)P_0).TransformPoints((PointF[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object n6piGbneGDDkqTVAup5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Pens.Aqua;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RvWwAXnOAmfc7SgvEhf(object P_0, object P_1, PointF P_2, PointF P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Graphics)P_0).DrawLine((Pen)P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ifqpJGnINyVXJt3nkIN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSightDisplay)P_0).InteractiveGraphics;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lLk2kgnDh9wZtoF6I0D(object P_0, object P_1, bool P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplayInteractiveGraphics)P_0).EditGraphicRemove((ICvsEditableDisplayGraphic)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AJqACEniF8tY0yn1Pho(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vAlNrpnnheTp8tksZVb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ywoLf4nV2FUamjKiLGM(object P_0, object P_1, bool P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplayInteractiveGraphics)P_0).EditGraphicAdd((ICvsEditableDisplayGraphic)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zpvp2VnfwKvxWWRQKn0(object P_0, bool P_1, bool P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSight)P_0).MakeNewResult(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HlFEHandwSnO0iuJ0AE(object P_0, LogLevel P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ILogger)P_0).LogException(P_1, (string)P_2, (Exception)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool V0QKNInl9qXYtLg1Y5k(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Output;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool c8E2DHngbfZ19ALSitf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Error;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Gv3BeKnsRY6UdTdQL40(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool f1qGAMnvdA3WkY4nLgN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xFDGernrt8fkFyL6SKH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Control)P_0).Focus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LwtE0tnP4OdRv66Qibu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSightDisplay)P_0).Edit;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gxEvvInZqt1eO5H8K4L(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSightDisplayEdit)P_0).AcceptChanges;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ld3pYlnB1X0mx9BC7yM(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsAction)P_0).Suppressed = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lVOK7enbBxEC2sQUHtc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSightDisplayEdit)P_0).CancelChanges;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void calkvGnGtluNarAu1eX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsAction)P_0).Execute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JjsCNYno7QWdP6o0axq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((List<CvsEditableDisplayGraphic>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ce4fq9nSHGyONT0UiFs(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplay)P_0).IsEasyBuilder = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XGElminkkZZgJXCaQ7a(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplay)P_0).ShowGraphics = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uXpbyrn8SAorHfehNA8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JLCtTTnqokAqNUHGfLC(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((fOZu4ITbNGZ3gNxDns)P_0).ShouldBeFiltered((CvsCogShape)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SMod1GnEBMISMLhyKbE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).Sheet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void d8eyCSnpNl7NuUrpCZJ(object P_0, CvsCellRange P_1, bool P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogSocketSheet)P_0).ApplyCellAttributes(P_1, P_2, (DictionaryEntry[])P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ba351cnXaSouDkp1vvQ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplayInteractiveGraphics)P_0).SetFocusGraphic((ICvsEditableDisplayGraphic)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UGHmsHn9YYy62DTIbeH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).Children;
	}
}
