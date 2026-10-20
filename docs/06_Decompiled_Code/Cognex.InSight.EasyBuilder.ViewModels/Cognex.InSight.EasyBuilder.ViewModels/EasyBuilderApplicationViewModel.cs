using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Composition;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.CogNamer.Client;
using Cognex.Common.Commands;
using Cognex.Designer.Utils.Operations;
using Cognex.Diagnostics.Logging;
using Cognex.Extensions;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display;
using Cognex.InSight.Controls.ViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Layouts;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Image;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Outputs;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Run;
using Cognex.InSight.Filmstrip.ViewModels;
using Cognex.InSight.IDE.Common;
using Cognex.InSight.IDE.Common.Authentication;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime;
using Cognex.InSight.Runtime.ViewModels;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.InSight.Undo;
using Cognex.Mvvm;
using kp16K3byhUkqwMQDFZ;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels;

[Export(typeof(EasyBuilderApplicationViewModel))]
[Shared]
public class EasyBuilderApplicationViewModel : BaseIdeViewModel, ISnippetManager, ISnippetOwner, IRuntimeModeConstraint
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<AppStepViewModel, bool> _003C_003E9__12_0;

		public static Func<AppStepViewModel, bool> _003C_003E9__42_0;

		public static Func<AppStepViewModel, int> _003C_003E9__44_0;

		public static Func<AppStepViewModel, bool> _003C_003E9__44_1;

		public static Func<AppStepViewModel, bool> _003C_003E9__47_0;

		public static Func<EzSnippet, int> _003C_003E9__64_2;

		public static Func<AppStepViewModel, bool> _003C_003E9__69_0;

		public static Func<ISnippetOwner, SnippetUpdateViewModel> _003C_003E9__126_0;

		public static Func<CellViewModel, CvsCellLocation> _003C_003E9__133_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			mO7tdkKJIbdlp1HJr32u();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			mO7tdkKJIbdlp1HJr32u();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CInitSupportSnippetTypes_003Eb__12_0(AppStepViewModel s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return s is InspectStepViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CFilterSteps_003Eb__42_0(AppStepViewModel s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return !(s is RunStepViewModel);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int _003CInitializeSteps_003Eb__44_0(AppStepViewModel s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return s.Order;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CInitializeSteps_003Eb__44_1(AppStepViewModel s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return s is InspectStepViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CInitializeInternal_003Eb__47_0(AppStepViewModel step)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mvnQ2BKJD0oinHfRvVPK(step);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int _003CPasteSnippetInLocation_003Eb__64_2(EzSnippet s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return B5yZHnKJiooJHBSwBAnb(s).LastRow;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003COnJobLoading_003Eb__69_0(AppStepViewModel s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mvnQ2BKJD0oinHfRvVPK(s);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SnippetUpdateViewModel _003CUpdateSnippetsToLatestRevision_003Eb__126_0(ISnippetOwner o)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new SnippetUpdateViewModel(o);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal CvsCellLocation _003CReadCurrentPropertyLinks_003Eb__133_0(CellViewModel property)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mZDxZcKJndlErdevKsH6(property);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void mO7tdkKJIbdlp1HJr32u()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vqutXiKJeUmaZyeQTv6l()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VsAe4tKJObE7m4HPWEKN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mvnQ2BKJD0oinHfRvVPK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((StepBase)P_0).IsEnabled;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange B5yZHnKJiooJHBSwBAnb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).CellRange;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation mZDxZcKJndlErdevKsH6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInitializeSteps_003Ed__44 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		private IEnumerator<AppStepViewModel> _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
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
			goto IL_0400;
			IL_001a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0400;
			IL_0400:
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			IInSightAppStep current2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					num = 0;
					continue;
				case 4:
					num2 = _003C_003E1__state;
					_ = 1;
					if (!UmcQ8CKJfsbdoVe3oMI8())
					{
						num = 2;
						if (true)
						{
							continue;
						}
						goto case 0;
					}
					num = 5;
					continue;
				case 0:
					try
					{
						if (num2 != 0)
						{
							IEnumerable<AppStepViewModel> jnUrIxu3L = easyBuilderApplicationViewModel.JnUrIxu3L;
							ObservableCollection<AppStepViewModel> list = new ObservableCollection<AppStepViewModel>();
							IEnumerator<AppStepViewModel> enumerator = jnUrIxu3L.GetEnumerator();
							try
							{
								while (lkkXZaKJlMh1a20gio31(enumerator))
								{
									IInSightAppStep current;
									IInSightAppStep appStepViewModel = (current = enumerator.Current);
									if (current != null)
									{
										current.AppViewModel = easyBuilderApplicationViewModel;
										oUUsw8KJdajZtm7dKHv5(current, easyBuilderApplicationViewModel.duohQ2pLC);
									}
									ISnippetOwner snippetOwner = appStepViewModel as ISnippetOwner;
									int num3 = 5;
									while (true)
									{
										switch (num3)
										{
										case 1:
										case 4:
											snippetOwner.SnippetAdded += easyBuilderApplicationViewModel.sBVDaoaFM;
											goto case 2;
										case 3:
											snippetOwner.SnippetRenamed += easyBuilderApplicationViewModel.vrAbfgqHK;
											num3 = 7;
											continue;
										case 2:
										case 6:
											snippetOwner.SnippetPreRemove += easyBuilderApplicationViewModel.Se0I84Do6;
											goto case 0;
										default:
											num3 = 0;
											continue;
										case 0:
											snippetOwner.SnippetRemove += easyBuilderApplicationViewModel.tbvfsff7b;
											num3 = 3;
											continue;
										case 5:
											if (snippetOwner != null)
											{
												UmcQ8CKJfsbdoVe3oMI8();
												num3 = (EtHF2FKJVAewi3wx4eDd() ? 4 : 6);
												continue;
											}
											break;
										case 7:
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
									kSHiGqKJgvT8qTd6tsn4(enumerator);
								}
							}
							jnUrIxu3L = jnUrIxu3L.OrderBy([MethodImpl(MethodImplOptions.NoInlining)] (AppStepViewModel s) =>
							{
								while (false)
								{
									_ = ((object[])null)[0];
								}
								return s.Order;
							});
							list.AddRange(jnUrIxu3L);
							easyBuilderApplicationViewModel.Steps = new ReadOnlyObservableCollection<AppStepViewModel>(list);
							easyBuilderApplicationViewModel.Inspect = easyBuilderApplicationViewModel.Steps.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (AppStepViewModel s) =>
							{
								while (false)
								{
									_ = ((object[])null)[0];
								}
								return s is InspectStepViewModel;
							}) as InspectStepViewModel;
							_003C_003E7__wrap1 = easyBuilderApplicationViewModel.Steps.GetEnumerator();
						}
						try
						{
							if (num2 != 0)
							{
								goto IL_038b;
							}
							awaiter = _003C_003Eu__1;
							int num4 = 0;
							goto IL_0342;
							IL_0342:
							while (true)
							{
								switch (num4)
								{
								case 2:
								case 10:
									if (!awaiter.IsCompleted)
									{
										num4 = 6;
										continue;
									}
									goto case 4;
								case 6:
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									num4 = 3;
									continue;
								case 7:
									if (current2 == null)
									{
										break;
									}
									num4 = 9;
									if (!UmcQ8CKJfsbdoVe3oMI8())
									{
										continue;
									}
									goto case 0;
								case 0:
									_003C_003Eu__1 = default;
									num4 = 5;
									if (0 == 0)
									{
										continue;
									}
									goto case 4;
								case 4:
								case 8:
									awaiter.GetResult();
									num4 = 11;
									continue;
								case 1:
									return;
								case 5:
									num2 = (_003C_003E1__state = -1);
									goto case 4;
								case 9:
									awaiter = W9nXQqKJvveLSp48QRHN(HJBfJRKJs76UkHJq8B3f(current2, easyBuilderApplicationViewModel, false));
									UmcQ8CKJfsbdoVe3oMI8();
									num4 = (EtHF2FKJVAewi3wx4eDd() ? 10 : 4);
									continue;
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num4 = 1;
									if (UmcQ8CKJfsbdoVe3oMI8())
									{
									}
									continue;
								case 11:
									break;
								}
								break;
							}
							goto IL_038b;
							IL_038b:
							if (lkkXZaKJlMh1a20gio31(_003C_003E7__wrap1))
							{
								current2 = _003C_003E7__wrap1.Current;
								num4 = 7;
								goto IL_0342;
							}
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
					break;
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
		internal static void oUUsw8KJdajZtm7dKHv5(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IInSightAppStep)P_0).InSight = (CvsInSight)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lkkXZaKJlMh1a20gio31(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void kSHiGqKJgvT8qTd6tsn4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HJBfJRKJs76UkHJq8B3f(object P_0, object P_1, bool jobLoading)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IInSightAppStep)P_0).BeginInitialization((EasyBuilderApplicationViewModel)P_1, jobLoading);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter W9nXQqKJvveLSp48QRHN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EtHF2FKJVAewi3wx4eDd()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UmcQ8CKJfsbdoVe3oMI8()
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
	private struct _003CInitialize_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					goto case 2;
				case 2:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = sZ5VWMKJZeP2YoWxp0R5(easyBuilderApplicationViewModel.Initialize(registerSheet: true));
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
							case 1:
								_003C_003Eu__1 = default;
								goto case 0;
							case 4:
							case 5:
								return;
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (P6kYrCKJrjOs0WETQkD2())
								{
									continue;
								}
								goto case 8;
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								if (0 == 0)
								{
									continue;
								}
								goto case 3;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								break;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								_ = 0;
								num3 = (P6kYrCKJrjOs0WETQkD2() ? 5 : 0);
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
					goto case 5;
				default:
					num = 5;
					break;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 3:
					num2 = _003C_003E1__state;
					_ = 1;
					if (ebt7YfKJP2tj0whkjHV9())
					{
						num = 4;
						if (true)
						{
							break;
						}
						goto case 2;
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
		internal static TaskAwaiter sZ5VWMKJZeP2YoWxp0R5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool P6kYrCKJrjOs0WETQkD2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ebt7YfKJP2tj0whkjHV9()
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
	private struct _003CInitialize_003Ed__46 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		public bool registerSheet;

		private ITopLevelProgressableOperation _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!dP9BHhKJBqluqsc0yKne())
			{
				goto IL_001e;
			}
			goto IL_01e8;
			IL_001e:
			int num2 = default;
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			try
			{
				if (num2 != 0)
				{
					bool flag = easyBuilderApplicationViewModel.OperationProgressManager != null && !easyBuilderApplicationViewModel.OperationProgressManager.HasOperationsPending;
					_003C_003E7__wrap1 = (ITopLevelProgressableOperation)(flag ? TQD52HKJoIU0sdghB6bZ(easyBuilderApplicationViewModel.OperationProgressManager, KaSCOBKJGD8GSSva40Q9(), Array.Empty<StepDescriptor>()) : null);
				}
				try
				{
					TaskAwaiter awaiter;
					int num3;
					if (num2 != 0)
					{
						awaiter = Mdusk5KJSRiUxnEfkYWg(easyBuilderApplicationViewModel.Ccq6EpyOb(registerSheet));
						num3 = 3;
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
						case 5:
							_003C_003Eu__1 = awaiter;
							num3 = 8;
							continue;
						case 3:
							if (awaiter.IsCompleted)
							{
								break;
							}
							num3 = 6;
							if (!hfsp8aKJbuUXPd1TyWRb())
							{
								continue;
							}
							goto case 7;
						case 7:
							num2 = (_003C_003E1__state = -1);
							num3 = 9;
							continue;
						case 6:
							num2 = (_003C_003E1__state = 0);
							_ = 0;
							if (dP9BHhKJBqluqsc0yKne())
							{
								num3 = 5;
								continue;
							}
							num3 = 1;
							if (dP9BHhKJBqluqsc0yKne())
							{
								continue;
							}
							break;
						case 0:
							_003C_003Eu__1 = default;
							num3 = 7;
							continue;
						default:
							return;
						case 1:
							return;
						case 8:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 9:
							break;
						}
						break;
					}
					awaiter.GetResult();
				}
				finally
				{
					if (num2 < 0 && _003C_003E7__wrap1 != null)
					{
						PcElNCKJkltmijjA7aXb(_003C_003E7__wrap1);
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
			goto IL_0249;
			IL_01e8:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					break;
				default:
					num = 5;
					continue;
				case 4:
					num2 = _003C_003E1__state;
					_ = 1;
					if (!hfsp8aKJbuUXPd1TyWRb())
					{
						num = 3;
						if (0 == 0)
						{
							continue;
						}
						goto case 1;
					}
					num = 0;
					continue;
				case 1:
				case 3:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					break;
				case 5:
					goto IL_0249;
				case 6:
					return;
				}
				break;
			}
			goto IL_001e;
			IL_0249:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (1 == 0)
			{
				return;
			}
			goto IL_01e8;
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
		internal static object KaSCOBKJGD8GSSva40Q9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.UY7Yflc8qh();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TQD52HKJoIU0sdghB6bZ(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).StartBlockingOperation((string)P_1, (StepDescriptor[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Mdusk5KJSRiUxnEfkYWg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PcElNCKJkltmijjA7aXb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dP9BHhKJBqluqsc0yKne()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hfsp8aKJbuUXPd1TyWRb()
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
	private struct _003CInitializeInternal_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		public bool registerSheet;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<FilmstripPanelViewModel> _003C_003Eu__2;

		private TaskAwaiter<CvsCogEasyBuilderConfig> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			TaskAwaiter awaiter = default;
			int num2 = default;
			do
			{
				IL_0730:
				switch (num)
				{
				case 1:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					wWagXOKJ83EtdFaYRNBh();
					if (!tyGVMGKJqbjbc0jxqHIO())
					{
						num = 4;
						if (wWagXOKJ83EtdFaYRNBh())
						{
							goto IL_0730;
						}
						goto case 0;
					}
					num = 5;
					if (0 == 0)
					{
						goto IL_0730;
					}
					break;
				case 0:
					num2 = _003C_003E1__state;
					num = 1;
					if (tyGVMGKJqbjbc0jxqHIO())
					{
					}
					goto IL_0730;
				case 2:
				case 4:
					try
					{
						TaskAwaiter<FilmstripPanelViewModel> awaiter3;
						TaskAwaiter<CvsCogEasyBuilderConfig> awaiter2;
						CvsCogEasyBuilderConfig result;
						FilmstripPanelViewModel result2;
						FilmstripPanelViewModel filmstrip;
						switch (num2)
						{
						default:
							awaiter = ((Task)HUahcjKJpZdL2YBbKNpu(easyBuilderApplicationViewModel, easyBuilderApplicationViewModel.duohQ2pLC, easyBuilderApplicationViewModel.HL08gGhGi, HPpRruKJEdUnImYqNJEr(easyBuilderApplicationViewModel.duohQ2pLC), CdQUGaROfy7He9T0foW.KbIzwHEDLa(47868))).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_00f4;
						case 0:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00f4;
						case 1:
							awaiter3 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_01ad;
						case 2:
							try
							{
								int num3;
								if (num2 != 2)
								{
									tyGVMGKJqbjbc0jxqHIO();
									if (wWagXOKJ83EtdFaYRNBh())
									{
										num3 = 3;
										if (!wWagXOKJ83EtdFaYRNBh())
										{
											goto IL_0233;
										}
									}
									else
									{
										num3 = 4;
									}
									goto IL_02f4;
								}
								awaiter = _003C_003Eu__1;
								goto IL_028d;
								IL_0233:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 7;
								goto IL_02f4;
								IL_02f4:
								while (true)
								{
									switch (num3)
									{
									case 9:
										break;
									case 8:
										num2 = (_003C_003E1__state = -1);
										num3 = 10;
										continue;
									case 5:
										num2 = (_003C_003E1__state = 2);
										num3 = 2;
										continue;
									case 1:
										if (!awaiter.IsCompleted)
										{
											num3 = 5;
											if (wWagXOKJ83EtdFaYRNBh())
											{
												continue;
											}
											goto IL_028d;
										}
										goto case 10;
									case 4:
									case 6:
										goto IL_028d;
									case 7:
										return;
									case 0:
									case 3:
										awaiter = ((Task)AVcnvXKJRxI1q9wNU093(IoW616KJXGWGd6VFRLQC(easyBuilderApplicationViewModel), false)).GetAwaiter();
										num3 = 1;
										continue;
									case 2:
										_003C_003Eu__1 = awaiter;
										break;
									default:
										num3 = 9;
										continue;
									case 10:
										awaiter.GetResult();
										goto end_IL_020c;
									}
									break;
								}
								goto IL_0233;
								IL_028d:
								_003C_003Eu__1 = default;
								num3 = 8;
								goto IL_02f4;
								end_IL_020c:;
							}
							catch (Exception ex)
							{
								string message = (string)BcwhE2KJ42U1PAZxS0EQ(47894);
								Logger.LogException(LogLevel.Warn, message, ex);
							}
							goto IL_035d;
						case 3:
							awaiter2 = _003C_003Eu__3;
							_003C_003Eu__3 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_040f;
						case 4:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0477;
						case 5:
						case 6:
							break;
							IL_040f:
							result = awaiter2.GetResult();
							easyBuilderApplicationViewModel.EasyBuilderConfig = result;
							awaiter = gS3ipTKJYY0DcHQh5xpj(easyBuilderApplicationViewModel.ypxdImN6p());
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 4);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0477;
							IL_00f4:
							awaiter.GetResult();
							W9soI0KJ98OtkWbtpRhZ(IoW616KJXGWGd6VFRLQC(easyBuilderApplicationViewModel), easyBuilderApplicationViewModel);
							((RuntimeViewModel)IoW616KJXGWGd6VFRLQC(easyBuilderApplicationViewModel)).RuntimeModeService.RuntimeModeChanged += easyBuilderApplicationViewModel.i8vFnXAl5;
							if (registerSheet)
							{
								tFkdmSKJ3luX3CtRbEbH(easyBuilderApplicationViewModel, BcwhE2KJ42U1PAZxS0EQ(616), F7DCQkKJ750B5NS6qU7p(easyBuilderApplicationViewModel.duohQ2pLC.CogSocket));
							}
							awaiter3 = FilmstripPanelViewModel.CreateAsync(easyBuilderApplicationViewModel.duohQ2pLC).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter3;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_01ad;
							IL_0477:
							awaiter.GetResult();
							easyBuilderApplicationViewModel.Inspect?.InitToolTypes(easyBuilderApplicationViewModel.EasyBuilderConfig);
							break;
							IL_035d:
							SinBnKKJTL51wFsVkbxc(Nn0cECKJWx8D5mknlOnW(easyBuilderApplicationViewModel), new EventHandler(easyBuilderApplicationViewModel.UwauqbPLL));
							((AcquisitionSettingsViewModel)JZTTjYKJy2vnElnTV3qR(easyBuilderApplicationViewModel)).AreGraphicsEditingPropertiesEnabled = false;
							VESN1oKJ0jHJeW5y8htt(JZTTjYKJy2vnElnTV3qR(easyBuilderApplicationViewModel), false);
							easyBuilderApplicationViewModel.PropertyLinks = null;
							rGkFgPKJFNMqs55cgnWM(easyBuilderApplicationViewModel.P2rz3AUMr);
							qExHSuKJMquI7s2bKaFD(easyBuilderApplicationViewModel.InSight, true, false);
							awaiter2 = easyBuilderApplicationViewModel.duohQ2pLC.CogSocket.GetEasyBuilderConfiguration().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 3);
								_003C_003Eu__3 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_040f;
							IL_01ad:
							result2 = awaiter3.GetResult();
							easyBuilderApplicationViewModel.Filmstrip = result2;
							OogimoKJjwg080Sfx72D(easyBuilderApplicationViewModel.Filmstrip, new PropertyChangedEventHandler(easyBuilderApplicationViewModel.ENfcHuHQX));
							filmstrip = easyBuilderApplicationViewModel.Filmstrip;
							if (filmstrip != null)
							{
								qxLnOoKJARejHopDBELm(filmstrip, QA8BosKJ65t58txe1koT(IoW616KJXGWGd6VFRLQC(easyBuilderApplicationViewModel)), r1Ywp7KJCw7S6x3Yyx5t(IoW616KJXGWGd6VFRLQC(easyBuilderApplicationViewModel)));
							}
							if (easyBuilderApplicationViewModel.IsLiveMode)
							{
								goto case 2;
							}
							goto IL_035d;
						}
						try
						{
							int num4;
							if (num2 != 5)
							{
								tyGVMGKJqbjbc0jxqHIO();
								if (wWagXOKJ83EtdFaYRNBh())
								{
									num4 = 4;
								}
								else
								{
									num4 = 7;
									if (!wWagXOKJ83EtdFaYRNBh())
									{
										goto IL_0503;
									}
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num4 = 6;
							}
							goto IL_0554;
							IL_0554:
							while (true)
							{
								switch (num4)
								{
								case 15:
									awaiter = gS3ipTKJYY0DcHQh5xpj(((CvsCogSocket)PTELiEKJUFLZNe3EdXto(easyBuilderApplicationViewModel.duohQ2pLC)).Sheet.CheckForSnippets());
									num4 = 1;
									if (0 == 0)
									{
										continue;
									}
									goto case 5;
								case 5:
									num2 = (_003C_003E1__state = 6);
									goto case 7;
								case 9:
									break;
								case 11:
									goto IL_0526;
								case 6:
									num2 = (_003C_003E1__state = -1);
									break;
								default:
									num4 = 9;
									continue;
								case 14:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num4 = 2;
									if (0 == 0)
									{
										continue;
									}
									goto case 0;
								case 0:
								case 4:
									if (num2 != 6)
									{
										num4 = 15;
										if (!tyGVMGKJqbjbc0jxqHIO())
										{
											continue;
										}
										goto case 13;
									}
									awaiter = _003C_003Eu__1;
									_003C_003Eu__1 = default;
									num4 = 11;
									continue;
								case 13:
									num2 = (_003C_003E1__state = 5);
									num4 = 14;
									continue;
								case 12:
									return;
								case 8:
									if (!awaiter.IsCompleted)
									{
										num4 = 5;
										if (true)
										{
											continue;
										}
										goto case 7;
									}
									goto case 16;
								case 7:
								case 10:
									_003C_003Eu__1 = awaiter;
									num4 = 3;
									continue;
								case 1:
									if (!awaiter.IsCompleted)
									{
										num4 = 13;
										continue;
									}
									break;
								case 2:
									return;
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num4 = 12;
									continue;
								case 16:
									awaiter.GetResult();
									goto end_IL_049c;
								}
								break;
							}
							goto IL_0503;
							IL_0526:
							num2 = (_003C_003E1__state = -1);
							num4 = 16;
							goto IL_0554;
							IL_0503:
							awaiter.GetResult();
							awaiter = gS3ipTKJYY0DcHQh5xpj(easyBuilderApplicationViewModel.TUbXLFygM());
							num4 = 8;
							if (!wWagXOKJ83EtdFaYRNBh())
							{
								goto IL_0526;
							}
							goto IL_0554;
							end_IL_049c:;
						}
						catch (Exception ex2)
						{
							string text = (string)BcwhE2KJ42U1PAZxS0EQ(48030);
							QES0ZVKJH7MjpFPcq3NZ(Logger, LogLevel.Error, text, ex2);
							easyBuilderApplicationViewModel.eSQoToKje(_0020: false);
						}
						easyBuilderApplicationViewModel.ActiveStep = easyBuilderApplicationViewModel.Steps.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (AppStepViewModel step) =>
						{
							while (false)
							{
								_ = ((object[])null)[0];
							}
							return _003C_003Ec.mvnQ2BKJD0oinHfRvVPK(step);
						});
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
			while (wWagXOKJ83EtdFaYRNBh());
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
		internal static object HPpRruKJEdUnImYqNJEr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HUahcjKJpZdL2YBbKNpu(object P_0, object P_1, object P_2, object P_3, object P_4)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BaseIdeViewModel)P_0).CreateServices((CvsInSight)P_1, (CogNamerDevice)P_2, (UndoRedoQueue)P_3, (string)P_4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IoW616KJXGWGd6VFRLQC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BaseIdeViewModel)P_0).Runtime;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void W9soI0KJ98OtkWbtpRhZ(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((RuntimeViewModel)P_0).AddConstraint((IRuntimeModeConstraint)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BcwhE2KJ42U1PAZxS0EQ(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object F7DCQkKJ750B5NS6qU7p(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void tFkdmSKJ3luX3CtRbEbH(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BaseIdeViewModel)P_0).RegisterSheet((string)P_1, (CvsCogSocketSheet)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void OogimoKJjwg080Sfx72D(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Cognex.Mvvm.BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QA8BosKJ65t58txe1koT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((RuntimeViewModel)P_0).RuntimeService;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object r1Ywp7KJCw7S6x3Yyx5t(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((RuntimeViewModel)P_0).RuntimeModeService;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void qxLnOoKJARejHopDBELm(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((FilmstripPanelViewModel)P_0).InitializeServices((IRuntimeService)P_1, (IRuntimeModeService)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AVcnvXKJRxI1q9wNU093(object P_0, bool P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((RuntimeViewModel)P_0).SetLiveMode(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Nn0cECKJWx8D5mknlOnW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BaseIdeViewModel)P_0).JobManagementService;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void SinBnKKJTL51wFsVkbxc(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((JobManagementService)P_0).NewJobLoaded += (EventHandler)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JZTTjYKJy2vnElnTV3qR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BaseIdeViewModel)P_0).AcqSettings;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void VESN1oKJ0jHJeW5y8htt(object P_0, bool P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AcquisitionSettingsViewModel)P_0).IsDragDropAllowed = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void rGkFgPKJFNMqs55cgnWM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((List<EzSnippet>)P_0).Clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void qExHSuKJMquI7s2bKaFD(object P_0, bool P_1, bool P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsInSight)P_0).MakeNewResult(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter gS3ipTKJYY0DcHQh5xpj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PTELiEKJUFLZNe3EdXto(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void QES0ZVKJH7MjpFPcq3NZ(object P_0, LogLevel P_1, object P_2, object P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).LogException(P_1, (string)P_2, (Exception)P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wWagXOKJ83EtdFaYRNBh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tyGVMGKJqbjbc0jxqHIO()
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
	private struct _003CNewJobUpdate_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

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
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
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
					K0b3s8KJxviI4IqyiSNT();
					if (!TQgneVKJm2gUPBOhpsPo())
					{
						num = 2;
						if (K0b3s8KJxviI4IqyiSNT())
						{
							break;
						}
						goto case 1;
					}
					num = 4;
					break;
				case 1:
				case 2:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					num = 0;
					break;
				case 0:
					try
					{
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							goto IL_0117;
						}
						int num3;
						if (easyBuilderApplicationViewModel.oTuTPJkpi())
						{
							num3 = 9;
							if (TQgneVKJm2gUPBOhpsPo())
							{
								goto IL_0088;
							}
							goto IL_00c9;
						}
						goto end_IL_0067;
						IL_012f:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						goto IL_00c9;
						IL_0117:
						_003C_003Eu__1 = default;
						num3 = 1;
						if (true)
						{
							goto IL_00c9;
						}
						goto IL_012f;
						IL_00c9:
						while (true)
						{
							switch (num3)
							{
							case 0:
								break;
							case 7:
								_003C_003Eu__1 = awaiter;
								break;
							default:
								num3 = 0;
								continue;
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 2:
							case 6:
								goto IL_0117;
							case 1:
								goto IL_012f;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								goto case 10;
							case 9:
								awaiter = zFEc5cKJQl1IggdxRwVm(easyBuilderApplicationViewModel.OF2Wjt7ga());
								num3 = 8;
								continue;
							case 3:
							case 5:
								return;
							case 10:
								awaiter.GetResult();
								goto end_IL_0067;
							}
							break;
						}
						goto IL_0088;
						IL_0088:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						K0b3s8KJxviI4IqyiSNT();
						num3 = (TQgneVKJm2gUPBOhpsPo() ? 2 : 3);
						goto IL_00c9;
						end_IL_0067:;
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
		internal static TaskAwaiter zFEc5cKJQl1IggdxRwVm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool K0b3s8KJxviI4IqyiSNT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TQgneVKJm2gUPBOhpsPo()
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
	private struct _003CSetupEasyBuilderIfAllowed_003Ed__51 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		private bool _003CshowAppSteps_003E5__2;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

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
			goto IL_048f;
			IL_001a:
			int num2 = _003C_003E1__state;
			_ = 0;
			num = ((!N03vHIKJNmUMnqNAGRdd()) ? 2 : 4);
			goto IL_048f;
			IL_048f:
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			TaskAwaiter awaiter2 = default;
			TaskAwaiter<bool> awaiter = default;
			bool? snippetsNeedUpdates = default;
			bool flag2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 1:
				case 4:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					num = 0;
					continue;
				case 0:
					try
					{
						int num3;
						bool result;
						switch (num2)
						{
						default:
							((IdeMessageBannerViewModel)uQSCBCKJcNv9HB6vS7uL(easyBuilderApplicationViewModel)).Messages.Remove((string)Nq9JggKJ1JIDTGMWlwnL());
							num3 = 15;
							if (PbiNSuKJ2X1MLZRX3GIt())
							{
								goto IL_0080;
							}
							goto IL_020e;
						case 1:
							awaiter2 = _003C_003Eu__2;
							num3 = 5;
							if (!N03vHIKJNmUMnqNAGRdd())
							{
								goto IL_00f9;
							}
							goto IL_020e;
						case 2:
							awaiter2 = _003C_003Eu__2;
							num3 = 9;
							goto IL_020e;
						case 0:
							{
								awaiter = _003C_003Eu__1;
								num3 = 17;
								goto IL_020e;
							}
							IL_020e:
							while (true)
							{
								bool flag;
								switch (num3)
								{
								case 3:
									break;
								case 10:
									goto IL_009a;
								case 5:
									_003C_003Eu__2 = default;
									num3 = 24;
									continue;
								case 0:
									_003C_003Eu__2 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								case 24:
									goto IL_00f9;
								case 1:
									awaiter2 = AGdJRBKaLgWZGv5Q4oY2(easyBuilderApplicationViewModel.TniS9jcdI());
									num3 = 23;
									if (0 == 0)
									{
										continue;
									}
									goto case 7;
								case 7:
								case 25:
									num2 = (_003C_003E1__state = -1);
									num3 = 28;
									continue;
								case 18:
									awaiter2.GetResult();
									goto IL_013f;
								case 12:
									flag = easyBuilderApplicationViewModel.YkFe36inZ((CvsCellCollection)EQuG74KJzO2Fkcf6F4tb(D1IUZfKJt10GUby5ZEhZ(easyBuilderApplicationViewModel.InSight)));
									goto IL_0177;
								case 11:
									((IdeMessageBannerViewModel)uQSCBCKJcNv9HB6vS7uL(easyBuilderApplicationViewModel)).Messages.Remove((string)Nq9JggKJ1JIDTGMWlwnL());
									snippetsNeedUpdates = easyBuilderApplicationViewModel.SnippetsNeedUpdates;
									num3 = 26;
									continue;
								case 4:
									_003CshowAppSteps_003E5__2 = easyBuilderApplicationViewModel.IsEzbEditable && !flag2;
									if (_003CshowAppSteps_003E5__2)
									{
										goto case 1;
									}
									goto IL_013f;
								default:
									num3 = 1;
									continue;
								case 19:
									num2 = (_003C_003E1__state = 0);
									num3 = 20;
									if (true)
									{
										continue;
									}
									goto case 15;
								case 15:
									awaiter = ((CvsCogSocketSheet)K8uD5nKJhZIQVPTn0VDv(UmrK2kKJu0yPkZCVLrWh(easyBuilderApplicationViewModel.duohQ2pLC))).GetEasyBuilderEditable().GetAwaiter();
									num3 = 10;
									if (N03vHIKJNmUMnqNAGRdd())
									{
										continue;
									}
									return;
								case 14:
									return;
								case 13:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 16;
									if (PbiNSuKJ2X1MLZRX3GIt())
									{
									}
									continue;
								case 22:
									_003C_003Eu__2 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 14;
									continue;
								case 23:
									if (!awaiter2.IsCompleted)
									{
										num3 = 6;
										continue;
									}
									goto case 18;
								case 21:
									if (!awaiter2.IsCompleted)
									{
										num2 = (_003C_003E1__state = 2);
										num3 = 22;
										continue;
									}
									goto case 28;
								case 16:
									return;
								case 20:
									_003C_003Eu__1 = awaiter;
									num3 = 13;
									continue;
								case 6:
									num2 = (_003C_003E1__state = 1);
									num3 = 0;
									if (N03vHIKJNmUMnqNAGRdd())
									{
										continue;
									}
									goto case 9;
								case 9:
									_003C_003Eu__2 = default;
									goto case 7;
								case 26:
									if (snippetsNeedUpdates.HasValue)
									{
										flag = snippetsNeedUpdates == true;
										goto IL_0177;
									}
									num3 = 12;
									if (N03vHIKJNmUMnqNAGRdd())
									{
										continue;
									}
									goto case 27;
								case 27:
									awaiter2 = AGdJRBKaLgWZGv5Q4oY2(((CvsCogSocketSheet)K8uD5nKJhZIQVPTn0VDv(UmrK2kKJu0yPkZCVLrWh(easyBuilderApplicationViewModel.duohQ2pLC))).CheckForSnippets());
									num3 = 21;
									continue;
								case 2:
								case 8:
									if (!easyBuilderApplicationViewModel.IsEzbEditable)
									{
										((IdeMessageBannerViewModel)uQSCBCKJcNv9HB6vS7uL(easyBuilderApplicationViewModel)).Messages.Add((string)Nq9JggKJ1JIDTGMWlwnL());
										num3 = 4;
										if (N03vHIKJNmUMnqNAGRdd())
										{
											continue;
										}
										goto case 11;
									}
									num3 = 11;
									continue;
								case 17:
									goto IL_0415;
								case 28:
									{
										awaiter2.GetResult();
										goto end_IL_0049;
									}
									IL_013f:
									easyBuilderApplicationViewModel.eSQoToKje(_003CshowAppSteps_003E5__2);
									num3 = 27;
									continue;
									IL_0177:
									flag2 = flag;
									easyBuilderApplicationViewModel.SnippetsNeedUpdates = flag2;
									goto case 4;
								}
								break;
							}
							goto IL_0080;
							IL_0415:
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_042a;
							IL_00f9:
							num2 = (_003C_003E1__state = -1);
							num3 = 18;
							goto IL_020e;
							IL_0080:
							flag2 = false;
							_ = 1;
							if (!PbiNSuKJ2X1MLZRX3GIt())
							{
								num3 = 2;
								if (1 == 0)
								{
									goto IL_009a;
								}
							}
							else
							{
								num3 = 7;
							}
							goto IL_020e;
							IL_042a:
							result = awaiter.GetResult();
							easyBuilderApplicationViewModel.IsEzbEditable = result;
							num3 = 3;
							if (PbiNSuKJ2X1MLZRX3GIt())
							{
							}
							goto IL_020e;
							IL_009a:
							if (!awaiter.IsCompleted)
							{
								num3 = 19;
								goto IL_020e;
							}
							goto IL_042a;
							end_IL_0049:
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
		internal static object uQSCBCKJcNv9HB6vS7uL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BaseIdeViewModel)P_0).MessageBanner;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Nq9JggKJ1JIDTGMWlwnL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.EeWrOFw5Us();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UmrK2kKJu0yPkZCVLrWh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object K8uD5nKJhZIQVPTn0VDv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object D1IUZfKJt10GUby5ZEhZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EQuG74KJzO2Fkcf6F4tb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter AGdJRBKaLgWZGv5Q4oY2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool N03vHIKJNmUMnqNAGRdd()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PbiNSuKJ2X1MLZRX3GIt()
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
	private struct _003CSetupEasyBuilder_003Ed__53 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		private TaskAwaiter<int> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<byte[]> _003C_003Eu__3;

		private TaskAwaiter<EzSupportSnippet> _003C_003Eu__4;

		private IEnumerator<AppStepViewModel> _003C_003E7__wrap1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (pSJTBhKa5ZHb2WnZpR4r() ? 2 : 5);
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			TaskAwaiter awaiter = default;
			IInSightAppStep current = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (pSQjLVKaKWjrgglGAB38())
					{
						continue;
					}
					goto case 4;
				case 4:
					try
					{
						TaskAwaiter<int> awaiter4;
						TaskAwaiter<byte[]> awaiter3;
						TaskAwaiter<EzSupportSnippet> awaiter2;
						int result;
						EzSupportSnippet result2;
						switch (num2)
						{
						default:
							iGTTyxKawGq46LNQspGS(easyBuilderApplicationViewModel.MessageBanner.Messages);
							awaiter4 = ((CvsCogSocketSheet)fOgdniKaaNWkZ7taCkF5(AYKdP6KaJf5Hkw0LneeV(easyBuilderApplicationViewModel.duohQ2pLC))).GetRowCountAsync().GetAwaiter();
							if (!awaiter4.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter4;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
								return;
							}
							goto IL_00de;
						case 0:
							awaiter4 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00de;
						case 1:
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0159;
						case 2:
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_01cc;
						case 3:
							awaiter3 = _003C_003Eu__3;
							_003C_003Eu__3 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_024b;
						case 4:
							awaiter2 = _003C_003Eu__4;
							_003C_003Eu__4 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_02bd;
						case 5:
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_033a;
						case 6:
							try
							{
								int num3;
								if (num2 != 6)
								{
									num3 = 0;
								}
								else
								{
									awaiter = _003C_003Eu__2;
									num3 = 1;
								}
								while (true)
								{
									switch (num3)
									{
									case 4:
									case 6:
										num2 = (_003C_003E1__state = 6);
										_003C_003Eu__2 = awaiter;
										goto case 10;
									default:
										num3 = 10;
										if (pSQjLVKaKWjrgglGAB38())
										{
											continue;
										}
										goto case 10;
									case 10:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num3 = 3;
										if (!pSJTBhKa5ZHb2WnZpR4r())
										{
											continue;
										}
										goto case 11;
									case 11:
										awaiter.GetResult();
										num3 = 12;
										continue;
									case 9:
										if (current == null)
										{
											break;
										}
										pSJTBhKa5ZHb2WnZpR4r();
										if (pSQjLVKaKWjrgglGAB38())
										{
											num3 = 7;
											if (!pSQjLVKaKWjrgglGAB38())
											{
												return;
											}
										}
										else
										{
											num3 = 6;
										}
										continue;
									case 3:
										return;
									case 1:
										_003C_003Eu__2 = default;
										num3 = 8;
										continue;
									case 2:
									case 7:
										awaiter = o6ifYmKae2BfBWWipQdj(TdZ0pvKaIWyw8IWAcxCw(current, easyBuilderApplicationViewModel));
										num3 = 5;
										continue;
									case 8:
										num2 = (_003C_003E1__state = -1);
										num3 = 11;
										if (true)
										{
											continue;
										}
										goto case 5;
									case 5:
										if (!awaiter.IsCompleted)
										{
											goto case 4;
										}
										goto case 11;
									case 0:
									case 12:
										break;
									}
									if (pVaq2vKaDhSLHDV9V4gZ(_003C_003E7__wrap1))
									{
										current = _003C_003E7__wrap1.Current;
										num3 = 9;
										continue;
									}
									break;
								}
							}
							finally
							{
								if (num2 < 0 && _003C_003E7__wrap1 != null)
								{
									lNjgiNKaim9yZuR0fqOG(_003C_003E7__wrap1);
								}
							}
							_003C_003E7__wrap1 = null;
							easyBuilderApplicationViewModel.Steps = easyBuilderApplicationViewModel.UILayout.sP2bblEtOlY(easyBuilderApplicationViewModel);
							awaiter = o6ifYmKae2BfBWWipQdj(easyBuilderApplicationViewModel.ReadCurrentPropertyLinks());
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 7);
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							break;
						case 7:
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								break;
							}
							IL_024b:
							awaiter3.GetResult();
							awaiter2 = easyBuilderApplicationViewModel.nQR5aKbwQR.OfType<PropertyLinksType>().First().AddSupportSnippet(easyBuilderApplicationViewModel)
								.GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 4);
								_003C_003Eu__4 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_02bd;
							IL_00de:
							result = awaiter4.GetResult();
							easyBuilderApplicationViewModel.sHu1r1vdB = result;
							awaiter = o6ifYmKae2BfBWWipQdj(easyBuilderApplicationViewModel.P2cCx1icJ(easyBuilderApplicationViewModel.duohQ2pLC, easyBuilderApplicationViewModel.dsLwr6hip));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0159;
							IL_0341:
							_003C_003E7__wrap1 = easyBuilderApplicationViewModel.Steps.GetEnumerator();
							goto case 6;
							IL_0159:
							awaiter.GetResult();
							awaiter = o6ifYmKae2BfBWWipQdj(easyBuilderApplicationViewModel.P2cCx1icJ(easyBuilderApplicationViewModel.duohQ2pLC, easyBuilderApplicationViewModel.KHGyvUrkn));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 2);
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_01cc;
							IL_02bd:
							result2 = awaiter2.GetResult();
							easyBuilderApplicationViewModel.PropertyLinks = result2 as PropertyLinks;
							awaiter = o6ifYmKae2BfBWWipQdj(easyBuilderApplicationViewModel.nRV3NFP7G(easyBuilderApplicationViewModel, new SnippetAddedEventArgs(easyBuilderApplicationViewModel.PropertyLinks, SnippetAddedEventType.Created)));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 5);
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_033a;
							IL_01cc:
							awaiter.GetResult();
							if (easyBuilderApplicationViewModel.PropertyLinks == null)
							{
								awaiter3 = ((UndoHandler)YV4SU9KaOXBoQMETMR6K(easyBuilderApplicationViewModel.InSight)).SendCopyAsync(new CvsCellRange(0, 0, 1, 1)).GetAwaiter();
								if (!awaiter3.IsCompleted)
								{
									num2 = (_003C_003E1__state = 3);
									_003C_003Eu__3 = awaiter3;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								}
								goto IL_024b;
							}
							goto IL_0341;
							IL_033a:
							awaiter.GetResult();
							goto IL_0341;
						}
						awaiter.GetResult();
						if (easyBuilderApplicationViewModel.Inspect?.StepDisplay is InspectStepDisplay inspectStepDisplay)
						{
							s3p7j3KancO2WCZttAjJ(inspectStepDisplay, StepDisplayState.Init);
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
					continue;
				case 1:
				case 2:
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					break;
				case 6:
					return;
				}
				easyBuilderApplicationViewModel = _003C_003E4__this;
				num = 4;
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
		internal static void iGTTyxKawGq46LNQspGS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Collection<string>)P_0).Clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AYKdP6KaJf5Hkw0LneeV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fOgdniKaaNWkZ7taCkF5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter o6ifYmKae2BfBWWipQdj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YV4SU9KaOXBoQMETMR6K(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TdZ0pvKaIWyw8IWAcxCw(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IInSightAppStep)P_0).CompleteInitializationAsync((ISnippetManager)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pVaq2vKaDhSLHDV9V4gZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void lNjgiNKaim9yZuR0fqOG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void s3p7j3KancO2WCZttAjJ(object P_0, StepDisplayState value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((InspectStepDisplay)P_0).State = value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pSQjLVKaKWjrgglGAB38()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pSJTBhKa5ZHb2WnZpR4r()
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
	private struct _003CStep_SnippetAdded_003Ed__58 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		public object source;

		public SnippetAddedEventArgs e;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EjBlRxKaf6F4JMRI7DY4();
			int num = ((!Ep5y9uKaV0L7mN6RaPVP()) ? 4 : 5);
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					num = 2;
					if (0 == 0)
					{
						break;
					}
					goto case 3;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (Ep5y9uKaV0L7mN6RaPVP())
					{
						break;
					}
					goto case 2;
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = pK1BhoKadaAdbmP0y86b(easyBuilderApplicationViewModel.nRV3NFP7G(source, e));
							_ = 0;
							if (Ep5y9uKaV0L7mN6RaPVP())
							{
								num3 = 3;
							}
							else
							{
								num3 = 2;
								if (EjBlRxKaf6F4JMRI7DY4())
								{
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
						}
						while (true)
						{
							switch (num3)
							{
							case 5:
								_003C_003Eu__1 = default;
								num3 = 4;
								continue;
							case 6:
								return;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 4;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 1:
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 0:
							case 3:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 1;
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
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
					goto case 3;
				default:
					num = 3;
					break;
				case 0:
				case 5:
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
		internal static TaskAwaiter pK1BhoKadaAdbmP0y86b(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ep5y9uKaV0L7mN6RaPVP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EjBlRxKaf6F4JMRI7DY4()
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
	private struct _003COnSnippetAdded_003Ed__59 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		public object source;

		public SnippetAddedEventArgs e;

		private IEnumerator<AppStepViewModel> _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			netgmQKalWRV8DFmE2On();
			int num = (z11jutKags2a5U3bIBhs() ? 1 : 4);
			int num2 = default;
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			TaskAwaiter awaiter = default;
			ISnippetConsumer snippetConsumer = default;
			AppStepViewModel current = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						if (num2 != 0)
						{
							_003C_003E7__wrap1 = easyBuilderApplicationViewModel.Steps.GetEnumerator();
						}
						try
						{
							int num3;
							if (num2 == 0)
							{
								awaiter = _003C_003Eu__1;
								num3 = 4;
								if (0 == 0)
								{
									goto IL_00c5;
								}
							}
							goto IL_01b0;
							IL_00c5:
							while (true)
							{
								switch (num3)
								{
								case 4:
									_003C_003Eu__1 = default;
									num3 = 10;
									continue;
								case 11:
									awaiter.GetResult();
									num3 = 12;
									continue;
								case 10:
									num2 = (_003C_003E1__state = -1);
									num3 = 11;
									continue;
								case 5:
									_003C_003Eu__1 = awaiter;
									goto case 7;
								default:
									num3 = 7;
									continue;
								case 8:
									if (snippetConsumer == null)
									{
										break;
									}
									goto case 3;
								case 6:
									snippetConsumer = current as ISnippetConsumer;
									num3 = 8;
									if (!z11jutKags2a5U3bIBhs())
									{
										continue;
									}
									goto case 0;
								case 0:
								case 1:
									if (current == source)
									{
										break;
									}
									num3 = 6;
									if (true)
									{
										continue;
									}
									goto case 7;
								case 7:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 2;
									continue;
								case 3:
								case 9:
									awaiter = OD3iBuKav8rn364SV7pW(FxBovTKasw78ampeTEte(snippetConsumer, e));
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 0);
										num3 = 5;
										continue;
									}
									goto case 11;
								case 2:
									return;
								case 12:
									break;
								}
								break;
							}
							goto IL_01b0;
							IL_01b0:
							if (yCD16VKare5NrlfKcmYo(_003C_003E7__wrap1))
							{
								current = _003C_003E7__wrap1.Current;
								z11jutKags2a5U3bIBhs();
								num3 = (netgmQKalWRV8DFmE2On() ? 1 : 9);
								goto IL_00c5;
							}
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								gaR0tvKaP9ooO5Op8NlX(_003C_003E7__wrap1);
							}
						}
						_003C_003E7__wrap1 = null;
						easyBuilderApplicationViewModel.P2rz3AUMr.Add(e.Snippet);
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
					if (!z11jutKags2a5U3bIBhs())
					{
						break;
					}
					goto case 2;
				case 2:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					num = 5;
					break;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
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
		internal static object FxBovTKasw78ampeTEte(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ISnippetConsumer)P_0).AddDefaultReferences((SnippetAddedEventArgs)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter OD3iBuKav8rn364SV7pW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yCD16VKare5NrlfKcmYo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gaR0tvKaP9ooO5Op8NlX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool netgmQKalWRV8DFmE2On()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool z11jutKags2a5U3bIBhs()
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
	private struct _003CStep_SnippetPreRemove_003Ed__60 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		public SnippetPreRemoveEventArgs e;

		private TaskAwaiter _003C_003Eu__1;

		private IEnumerator<AppStepViewModel> _003C_003E7__wrap1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			TaskAwaiter awaiter = default;
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			int num2 = default;
			ISnippetConsumer snippetConsumer = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					try
					{
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								goto IL_00a0;
							}
							awaiter = easyBuilderApplicationViewModel.PropertyLinks.RemoveReferences(e).GetAwaiter();
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
						_003C_003E7__wrap1 = easyBuilderApplicationViewModel.Steps.GetEnumerator();
						goto IL_00a0;
						IL_00a0:
						try
						{
							int num3;
							if (num2 != 1)
							{
								num3 = 7;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 6;
								if (k6PRjhKaBIo4aSmVvoft())
								{
								}
							}
							while (true)
							{
								switch (num3)
								{
								case 2:
									if (snippetConsumer != null)
									{
										awaiter = gbjTEMKaG7ZUajAevj0B(jHpJCjKabtfb8wn4g6Xq(snippetConsumer, e));
										num3 = 5;
										if (H4BqZLKaZhNJpWEWkSVC())
										{
											break;
										}
										goto case 11;
									}
									goto case 7;
								case 11:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 0;
									break;
								case 5:
									if (!awaiter.IsCompleted)
									{
										num3 = 10;
										break;
									}
									goto case 3;
								case 8:
									num2 = (_003C_003E1__state = -1);
									goto case 3;
								case 10:
									num2 = (_003C_003E1__state = 1);
									k6PRjhKaBIo4aSmVvoft();
									num3 = (H4BqZLKaZhNJpWEWkSVC() ? 1 : 3);
									break;
								case 6:
									_003C_003Eu__1 = default;
									num3 = 8;
									break;
								case 3:
								case 9:
									awaiter.GetResult();
									num3 = 12;
									break;
								case 1:
								case 4:
									_003C_003Eu__1 = awaiter;
									goto case 11;
								default:
									num3 = 11;
									break;
								case 0:
									return;
								case 7:
								case 12:
									if (cyixGtKao5AeieAlFbOG(_003C_003E7__wrap1))
									{
										snippetConsumer = _003C_003E7__wrap1.Current as ISnippetConsumer;
										num3 = 2;
										if (H4BqZLKaZhNJpWEWkSVC())
										{
											break;
										}
										goto case 6;
									}
									goto end_IL_01a9;
								}
								continue;
								end_IL_01a9:
								break;
							}
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								LGBDTmKaSLpPPZEO4OcX(_003C_003E7__wrap1);
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
					break;
				case 4:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					H4BqZLKaZhNJpWEWkSVC();
					num = (k6PRjhKaBIo4aSmVvoft() ? 1 : 0);
					continue;
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					if (true)
					{
						continue;
					}
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
		internal static object jHpJCjKabtfb8wn4g6Xq(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ISnippetConsumer)P_0).RemoveReferences((SnippetPreRemoveEventArgs)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter gbjTEMKaG7ZUajAevj0B(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cyixGtKao5AeieAlFbOG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LGBDTmKaSLpPPZEO4OcX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool H4BqZLKaZhNJpWEWkSVC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool k6PRjhKaBIo4aSmVvoft()
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
	private struct _003CStep_SnippetRemove_003Ed__61 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		public object source;

		public SnippetRemoveEventArgs e;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					_ = 1;
					if (!vUsX0KKa8B4L0ut2G6j1())
					{
						num = 4;
						continue;
					}
					num = 5;
					if (false)
					{
						return;
					}
					continue;
				case 1:
					num2 = _003C_003E1__state;
					num = 0;
					if (true)
					{
						continue;
					}
					goto case 2;
				case 2:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = easyBuilderApplicationViewModel.pRJEXORuA(source, e).GetAwaiter();
							num3 = 2;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
							if (1 == 0)
							{
								goto IL_00a7;
							}
						}
						goto IL_00ee;
						IL_00a7:
						_003C_003Eu__1 = awaiter;
						num3 = 3;
						goto IL_00ee;
						IL_00ee:
						while (true)
						{
							IL_00ee_2:
							switch (num3)
							{
							default:
								return;
							case 5:
								return;
							case 6:
								break;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 0;
								continue;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 2:
								while (!awaiter.IsCompleted)
								{
									fvtLngKakJHpsR494qMo();
									if (vUsX0KKa8B4L0ut2G6j1())
									{
										num3 = 5;
										if (!fvtLngKakJHpsR494qMo())
										{
											continue;
										}
									}
									else
									{
										num3 = 7;
									}
									goto IL_00ee_2;
								}
								goto case 9;
							case 1:
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								continue;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 9:
								awaiter.GetResult();
								goto end_IL_00ee;
							}
							goto IL_00a7;
							continue;
							end_IL_00ee:
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
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
				if (vUsX0KKa8B4L0ut2G6j1())
				{
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
		internal static bool fvtLngKakJHpsR494qMo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vUsX0KKa8B4L0ut2G6j1()
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
	private struct _003CPauseResults_003Ed__62 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IAsyncDisposable> _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		private JHLvFIyVUX9ZfVXh6y _003Cblocker_003E5__2;

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
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			TaskAwaiter awaiter = default;
			IAsyncDisposable result = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003Cblocker_003E5__2 = null;
					num = 4;
					continue;
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							object obj = jAoS1oKap9kQ6n4I2AUJ(easyBuilderApplicationViewModel);
							_003Cblocker_003E5__2 = new JHLvFIyVUX9ZfVXh6y((IRuntimeService)((obj != null) ? B0UOpdKaXMsCNsw9QFHG(obj) : null), easyBuilderApplicationViewModel.InSight);
							num3 = 9;
							if (1 == 0)
							{
								goto IL_0064;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
						}
						goto IL_00ac;
						IL_0064:
						awaiter.GetResult();
						num3 = 10;
						if (1 == 0)
						{
							goto IL_0077;
						}
						goto IL_00ac;
						IL_0077:
						num2 = (_003C_003E1__state = -1);
						num3 = 2;
						if (1 == 0)
						{
							goto IL_008c;
						}
						goto IL_00ac;
						IL_008c:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						IL_00ac:
						while (true)
						{
							switch (num3)
							{
							case 2:
								break;
							case 1:
								goto IL_0077;
							case 3:
							case 7:
								goto IL_008c;
							default:
								return;
							case 0:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								continue;
							case 5:
								return;
							case 6:
								goto IL_0116;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 1;
								if (true)
								{
									continue;
								}
								goto case 9;
							case 9:
								awaiter = ((Task)dtc0NOKa9KxJBusu8voV(_003Cblocker_003E5__2)).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								break;
							case 10:
								result = _003Cblocker_003E5__2;
								goto end_IL_0029;
							}
							break;
							IL_0116:
							_003C_003Eu__1 = awaiter;
							hvFZ0oKaEp7enG10DpYD();
							num3 = (mpOkymKaqwrRjjVHkuVH() ? 7 : 5);
						}
						goto IL_0064;
						end_IL_0029:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cblocker_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 5;
				default:
					num = 5;
					continue;
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					continue;
				case 1:
				case 6:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					goto case 2;
				case 0:
					break;
				case 7:
					return;
				}
				do
				{
					num2 = _003C_003E1__state;
					_ = 0;
					if (!mpOkymKaqwrRjjVHkuVH())
					{
						num = 3;
						continue;
					}
					num = 6;
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
		internal static object jAoS1oKap9kQ6n4I2AUJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BaseIdeViewModel)P_0).Runtime;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object B0UOpdKaXMsCNsw9QFHG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((RuntimeViewModel)P_0).RuntimeService;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dtc0NOKa9KxJBusu8voV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((JHLvFIyVUX9ZfVXh6y)P_0).rotpMsombT();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mpOkymKaqwrRjjVHkuVH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hvFZ0oKaEp7enG10DpYD()
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
	private struct _003CShiftSnippetsIntoUnusedRange_003Ed__63 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCellRange range;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		private CvsCellRange _003Cremaining_003E5__2;

		private int _003Cdelta_003E5__3;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (lidINbKa4VdA7TLMCGqo())
			{
				num = 3;
			}
			else
			{
				num = 5;
				if (false)
				{
					goto IL_003d;
				}
			}
			goto IL_03c7;
			IL_003d:
			int num2 = default;
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			try
			{
				int num4 = default;
				int num3;
				TaskAwaiter awaiter2 = default;
				TaskAwaiter<byte[]> awaiter = default;
				CvsCellRange cvsCellRange = default;
				byte[] result = default;
				switch (num2)
				{
				default:
					num4 = range.LastRow + 2;
					num3 = 18;
					goto IL_0248;
				case 2:
					awaiter2 = _003C_003Eu__2;
					_003C_003Eu__2 = default;
					num3 = 16;
					goto IL_0248;
				case 1:
					awaiter2 = _003C_003Eu__2;
					goto IL_0204;
				case 0:
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						num3 = 17;
						goto IL_0248;
					}
					IL_0248:
					while (true)
					{
						switch (num3)
						{
						case 19:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							num3 = 13;
							if (!t8cjRDKa7U7Yc9Ire3DJ())
							{
								continue;
							}
							goto case 5;
						case 5:
							num2 = (_003C_003E1__state = 2);
							num3 = 0;
							continue;
						case 13:
							return;
						case 17:
							num2 = (_003C_003E1__state = -1);
							num3 = 12;
							if (!t8cjRDKa7U7Yc9Ire3DJ())
							{
								continue;
							}
							return;
						case 21:
							return;
						case 2:
							_003C_003Eu__1 = awaiter;
							num3 = 8;
							continue;
						case 9:
							num2 = (_003C_003E1__state = 0);
							num3 = 2;
							continue;
						case 20:
							_003Cdelta_003E5__3 = range.Rows + 1;
							cvsCellRange = _003Cremaining_003E5__2;
							cvsCellRange.Row -= _003Cdelta_003E5__3;
							num3 = 23;
							continue;
						case 16:
							num2 = (_003C_003E1__state = -1);
							num3 = 24;
							continue;
						case 8:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 22;
							if (!t8cjRDKa7U7Yc9Ire3DJ())
							{
								continue;
							}
							goto case 10;
						case 10:
							awaiter = ((UndoHandler)wOPPOZKa3B7BgWxnC6tE(easyBuilderApplicationViewModel.InSight)).SendCutAsync(_003Cremaining_003E5__2).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num3 = 9;
								continue;
							}
							goto case 12;
						case 23:
							awaiter2 = ((Task)dra1TvKajiJ6ExaaZNUS(easyBuilderApplicationViewModel.InSight, cvsCellRange, result, true, false)).GetAwaiter();
							num3 = 4;
							continue;
						case 18:
							_003Cremaining_003E5__2 = new CvsCellRange(num4, range.Column, easyBuilderApplicationViewModel.sHu1r1vdB - num4, 8);
							num3 = 10;
							continue;
						case 1:
						case 14:
							break;
						case 4:
							if (awaiter2.IsCompleted)
							{
								goto IL_0219;
							}
							goto default;
						default:
							_ = 0;
							if (!lidINbKa4VdA7TLMCGqo())
							{
								num3 = 1;
								if (lidINbKa4VdA7TLMCGqo())
								{
									continue;
								}
								goto case 2;
							}
							num3 = 15;
							continue;
						case 6:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							num3 = 21;
							continue;
						case 11:
						case 15:
							num2 = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter2;
							num3 = 6;
							continue;
						case 22:
							return;
						case 3:
							if (!awaiter2.IsCompleted)
							{
								num3 = 5;
								continue;
							}
							goto case 24;
						case 0:
							_003C_003Eu__2 = awaiter2;
							num3 = 19;
							if (t8cjRDKa7U7Yc9Ire3DJ())
							{
							}
							continue;
						case 12:
							result = awaiter.GetResult();
							num3 = 20;
							continue;
						case 7:
							awaiter2 = tyicjPKa6xYXWdIblQe0(easyBuilderApplicationViewModel.ParseShiftedSnippetsInRange(_003Cremaining_003E5__2, -_003Cdelta_003E5__3));
							num3 = 3;
							continue;
						case 24:
							awaiter2.GetResult();
							goto end_IL_003e;
						}
						break;
					}
					goto IL_0204;
					IL_0204:
					_003C_003Eu__2 = default;
					num2 = (_003C_003E1__state = -1);
					goto IL_0219;
					IL_0219:
					awaiter2.GetResult();
					num3 = 7;
					goto IL_0248;
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
			goto IL_03f4;
			IL_03f4:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (t8cjRDKa7U7Yc9Ire3DJ())
			{
			}
			goto IL_03c7;
			IL_03c7:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 2:
					break;
				default:
					num = 4;
					if (true)
					{
						continue;
					}
					goto IL_03f4;
				case 4:
					goto IL_03f4;
				case 1:
				case 5:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					num = 2;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_003d;
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
		internal static object wOPPOZKa3B7BgWxnC6tE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dra1TvKajiJ6ExaaZNUS(object P_0, CvsCellRange P_1, object P_2, bool P_3, bool P_4)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).PasteCellsAsync(P_1, (byte[])P_2, P_3, P_4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter tyicjPKa6xYXWdIblQe0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lidINbKa4VdA7TLMCGqo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool t8cjRDKa7U7Yc9Ire3DJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass64_0
	{
		public CvsCellRange destSnippetRange;

		public EzSnippet beginSnippet;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass64_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CPasteSnippetInLocation_003Eb__0(EzSnippet s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return b9UxtSKaRq1GeSPheHRS(s).Contains(destSnippetRange.Location);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CPasteSnippetInLocation_003Eb__1(EzSnippet s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return b9UxtSKaRq1GeSPheHRS(s).Column == b9UxtSKaRq1GeSPheHRS(beginSnippet).Column;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eDgxcoKaCOfu8graurPl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eLiVj9KaAd7nekDHGktI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange b9UxtSKaRq1GeSPheHRS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).CellRange;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPasteSnippetInLocation_003Ed__64 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PasteBuffer snippet;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		private _003C_003Ec__DisplayClass64_0 _003C_003E8__1;

		private CvsCellRange _003CcopyRange_003E5__2;

		private int _003CshiftDistance_003E5__3;

		private CvsCellLocation _003CnewBeginLocation_003E5__4;

		private Size _003CcutRangeSize_003E5__5;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			int num2 = default;
			TaskAwaiter<byte[]> awaiter2 = default;
			TaskAwaiter awaiter = default;
			byte[] result = default;
			int num4 = default;
			CvsCellLocation location = default;
			int height = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					num = 5;
					break;
				case 0:
					_003C_003Et__builder.SetResult();
					num = 7;
					break;
				default:
					_003C_003E8__1 = null;
					num = 0;
					break;
				case 6:
					num2 = _003C_003E1__state;
					dmM3bTKaTleMNYPOBWY0();
					num = ((!hYnkY7KaWidRAFcohAWD()) ? 2 : 4);
					break;
				case 5:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							_003C_003E8__1 = new _003C_003Ec__DisplayClass64_0();
							num3 = 21;
							goto IL_0442;
						case 0:
							awaiter2 = _003C_003Eu__1;
							num3 = 19;
							goto IL_0442;
						case 3:
							awaiter = _003C_003Eu__2;
							num3 = 13;
							if (!hYnkY7KaWidRAFcohAWD())
							{
								goto IL_02ac;
							}
							goto IL_0442;
						case 1:
							awaiter = _003C_003Eu__2;
							num3 = 6;
							if (1 == 0)
							{
								goto IL_02db;
							}
							goto IL_0442;
						case 2:
							{
								awaiter = _003C_003Eu__2;
								num3 = 35;
								goto IL_0442;
							}
							IL_0442:
							while (true)
							{
								switch (num3)
								{
								case 16:
								{
									CvsCellRange cvsCellRange = new CvsCellRange(_003CnewBeginLocation_003E5__4, _003CcutRangeSize_003E5__5);
									awaiter = FV1VXNKaMptQB1nf65Ty(RhkCetKaF7KWIHoL9Thn(easyBuilderApplicationViewModel.InSight, cvsCellRange, result, true, false));
									if (!awaiter.IsCompleted)
									{
										num3 = 25;
										continue;
									}
									goto case 22;
								}
								case 20:
									_003C_003Eu__1 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 33;
									continue;
								case 28:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 12;
									continue;
								case 11:
									_003CcutRangeSize_003E5__5 = default;
									goto IL_0120;
								case 0:
									num2 = (_003C_003E1__state = 3);
									num3 = 27;
									if (true)
									{
										continue;
									}
									goto case 4;
								case 4:
									num4 = location.Row + _003CshiftDistance_003E5__3;
									num3 = 32;
									continue;
								case 29:
									num2 = (_003C_003E1__state = -1);
									goto IL_0193;
								case 6:
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 22;
									continue;
								case 17:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								case 33:
									return;
								case 15:
									awaiter2 = ((UndoHandler)l87soRKa0nFEl0TGLgUj(easyBuilderApplicationViewModel.InSight)).SendCutAsync(_003CcopyRange_003E5__2).GetAwaiter();
									dmM3bTKaTleMNYPOBWY0();
									if (!hYnkY7KaWidRAFcohAWD())
									{
										num3 = 24;
										if (true)
										{
											continue;
										}
										goto case 0;
									}
									num3 = 2;
									continue;
								case 7:
									num2 = (_003C_003E1__state = 0);
									num3 = 20;
									continue;
								case 2:
								case 10:
									if (!awaiter2.IsCompleted)
									{
										num3 = 7;
										continue;
									}
									goto IL_0193;
								case 8:
									_003CcopyRange_003E5__2 = new CvsCellRange(location, _003CcutRangeSize_003E5__5);
									num3 = 15;
									continue;
								case 26:
									throw new ArgumentOutOfRangeException(string.Empty, Resources.Ks3LSV115L());
								case 31:
									return;
								case 23:
								case 24:
									break;
								case 3:
									return;
								case 5:
									goto IL_02db;
								case 12:
									return;
								case 27:
									_003C_003Eu__2 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 31;
									continue;
								case 22:
									awaiter.GetResult();
									_003CnewBeginLocation_003E5__4 = default;
									num3 = 11;
									continue;
								case 37:
									_003CshiftDistance_003E5__3 = snippet.Range.Rows + 1;
									num3 = 4;
									continue;
								case 18:
									_003C_003E8__1.beginSnippet = easyBuilderApplicationViewModel.P2rz3AUMr.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (EzSnippet s) =>
									{
										while (false)
										{
											_ = ((object[])null)[0];
										}
										return _003C_003Ec__DisplayClass64_0.b9UxtSKaRq1GeSPheHRS(s).Contains(_003C_003E8__1.destSnippetRange.Location);
									});
									num3 = 1;
									continue;
								case 14:
									_003CcutRangeSize_003E5__5 = new Size(8, height);
									num3 = 8;
									if (!dmM3bTKaTleMNYPOBWY0())
									{
										continue;
									}
									goto case 30;
								case 30:
									num2 = (_003C_003E1__state = -1);
									num3 = 38;
									continue;
								case 21:
									_003C_003E8__1.destSnippetRange = snippet.Range;
									num3 = 18;
									continue;
								case 9:
									goto IL_040c;
								case 25:
									num2 = (_003C_003E1__state = 1);
									goto case 36;
								default:
									num3 = 36;
									if (0 == 0)
									{
										continue;
									}
									goto case 32;
								case 32:
								{
									_003CnewBeginLocation_003E5__4 = new CvsCellLocation(num4, location.Column);
									int num5 = easyBuilderApplicationViewModel.P2rz3AUMr.Where([MethodImpl(MethodImplOptions.NoInlining)] (EzSnippet s) =>
									{
										while (false)
										{
											_ = ((object[])null)[0];
										}
										return _003C_003Ec__DisplayClass64_0.b9UxtSKaRq1GeSPheHRS(s).Column == _003C_003Ec__DisplayClass64_0.b9UxtSKaRq1GeSPheHRS(_003C_003E8__1.beginSnippet).Column;
									}).Max([MethodImpl(MethodImplOptions.NoInlining)] (EzSnippet s) =>
									{
										while (false)
										{
											_ = ((object[])null)[0];
										}
										return _003C_003Ec.B5yZHnKJiooJHBSwBAnb(s).LastRow;
									});
									int num6 = easyBuilderApplicationViewModel.sHu1r1vdB - _003CshiftDistance_003E5__3;
									if (num5 < num6)
									{
										height = easyBuilderApplicationViewModel.sHu1r1vdB - num4;
										num3 = 14;
									}
									else
									{
										num3 = 26;
									}
									continue;
								}
								case 1:
								{
									bool flag = _003C_003E8__1.beginSnippet != null;
									_003CcopyRange_003E5__2 = CvsCellRange.Empty;
									_003CshiftDistance_003E5__3 = 0;
									if (flag)
									{
										location = IH0VUcKayQaELRZbvCa3(_003C_003E8__1.beginSnippet).Location;
										num3 = 37;
										continue;
									}
									goto IL_0120;
								}
								case 19:
									_003C_003Eu__1 = default;
									num3 = 29;
									continue;
								case 36:
									_003C_003Eu__2 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 3;
									continue;
								case 13:
									_003C_003Eu__2 = default;
									num3 = 30;
									if (0 == 0)
									{
										continue;
									}
									goto case 34;
								case 34:
									num2 = (_003C_003E1__state = 2);
									_003C_003Eu__2 = awaiter;
									num3 = 28;
									if (dmM3bTKaTleMNYPOBWY0())
									{
									}
									continue;
								case 35:
									_003C_003Eu__2 = default;
									num3 = 17;
									continue;
								case 38:
									goto end_IL_0071;
									IL_0120:
									awaiter = easyBuilderApplicationViewModel.InSight.PasteCellsAsync(_003C_003E8__1.destSnippetRange, (byte[])jdANJNKaYjEGUPecNeSH(snippet), cutFromSameSheet: true, runSheet: false).GetAwaiter();
									break;
									IL_0193:
									result = awaiter2.GetResult();
									num3 = 16;
									continue;
								}
								break;
							}
							goto IL_02ac;
							IL_02db:
							awaiter = FV1VXNKaMptQB1nf65Ty(easyBuilderApplicationViewModel.ParseShiftedSnippetsInRange(_003CcopyRange_003E5__2, _003CshiftDistance_003E5__3));
							if (awaiter.IsCompleted)
							{
								break;
							}
							num3 = 0;
							if (!hYnkY7KaWidRAFcohAWD())
							{
								return;
							}
							goto IL_0442;
							IL_040c:
							awaiter.GetResult();
							num3 = 5;
							if (dmM3bTKaTleMNYPOBWY0())
							{
							}
							goto IL_0442;
							IL_02ac:
							if (awaiter.IsCompleted)
							{
								goto IL_040c;
							}
							num3 = 34;
							goto IL_0442;
							end_IL_0071:
							break;
						}
						awaiter.GetResult();
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
		internal static CvsCellRange IH0VUcKayQaELRZbvCa3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).CellRange;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object l87soRKa0nFEl0TGLgUj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RhkCetKaF7KWIHoL9Thn(object P_0, CvsCellRange P_1, object P_2, bool P_3, bool P_4)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).PasteCellsAsync(P_1, (byte[])P_2, P_3, P_4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter FV1VXNKaMptQB1nf65Ty(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jdANJNKaYjEGUPecNeSH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBuffer)P_0).ToBytes();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hYnkY7KaWidRAFcohAWD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dmM3bTKaTleMNYPOBWY0()
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
	private struct _003CParseShiftedSnippetsInRange_003Ed__65 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		public CvsCellRange range;

		public int shiftDistance;

		private CvsCellCollection _003Ccells_003E5__2;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		private List<EzSnippet>.Enumerator _003C_003E7__wrap2;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			int num2 = default;
			TaskAwaiter awaiter2 = default;
			EzSnippet current = default;
			CvsCellRange cellRange = default;
			while (true)
			{
				switch (num)
				{
				case 3:
				case 4:
					_003C_003Et__builder.SetResult();
					num = 7;
					break;
				case 0:
				case 1:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					num = 6;
					break;
				case 2:
					num2 = _003C_003E1__state;
					fqImA5KaH72ogy1JsB8D();
					num = ((!e4PAZhKaU8jwKvA0YUGD()) ? 3 : 0);
					break;
				case 6:
					try
					{
						TaskAwaiter<CvsCellCollection> awaiter;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								goto IL_00f4;
							}
							awaiter = ((CvsCogSocket)rw35ynKaxwLCLpH5Ewix(easyBuilderApplicationViewModel.InSight)).Sheet.RunAndGetCellResults().GetAwaiter();
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
						CvsCellCollection result = awaiter.GetResult();
						_003Ccells_003E5__2 = result;
						_003C_003E7__wrap2 = easyBuilderApplicationViewModel.P2rz3AUMr.GetEnumerator();
						goto IL_00f4;
						IL_00f4:
						try
						{
							int num3;
							if (num2 != 1)
							{
								num3 = 6;
								if (false)
								{
									goto IL_0107;
								}
							}
							else
							{
								awaiter2 = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num3 = 11;
							}
							goto IL_01d0;
							IL_01d0:
							while (true)
							{
								switch (num3)
								{
								case 9:
									break;
								case 2:
									if (!awaiter2.IsCompleted)
									{
										num3 = 12;
										continue;
									}
									goto case 1;
								case 1:
									awaiter2.GetResult();
									num3 = 13;
									continue;
								case 0:
									if (range.Contains(current.CellRange.Location))
									{
										cellRange = current.CellRange;
										num3 = 9;
										continue;
									}
									goto case 6;
								case 4:
									return;
								case 8:
									return;
								case 11:
									num2 = (_003C_003E1__state = -1);
									num3 = 1;
									continue;
								case 12:
									num2 = (_003C_003E1__state = 1);
									goto case 10;
								default:
									num3 = 10;
									if (0 == 0)
									{
										continue;
									}
									goto case 6;
								case 5:
								case 7:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								case 3:
									awaiter2 = ((Task)xk2qwrKam0RlgTeNPjuo(current, _003Ccells_003E5__2, cellRange)).GetAwaiter();
									num3 = 2;
									continue;
								case 10:
									_003C_003Eu__2 = awaiter2;
									_ = 1;
									if (fqImA5KaH72ogy1JsB8D())
									{
										num3 = 4;
										if (true)
										{
											continue;
										}
										goto case 3;
									}
									num3 = 5;
									if (fqImA5KaH72ogy1JsB8D())
									{
									}
									continue;
								case 6:
								case 13:
									if (_003C_003E7__wrap2.MoveNext())
									{
										current = _003C_003E7__wrap2.Current;
										num3 = 0;
										if (0 == 0)
										{
											continue;
										}
										goto case 5;
									}
									goto end_IL_01d0;
								}
								goto IL_0107;
								continue;
								end_IL_01d0:
								break;
							}
							goto end_IL_00f4;
							IL_0107:
							cellRange.Row += shiftDistance;
							num3 = 3;
							goto IL_01d0;
							end_IL_00f4:;
						}
						finally
						{
							if (num2 < 0)
							{
								((IDisposable)_003C_003E7__wrap2/*cast due to constrained. prefix*/).Dispose();
							}
						}
						_003C_003E7__wrap2 = default;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Ccells_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 5;
				default:
					num = 5;
					break;
				case 5:
					_003Ccells_003E5__2 = null;
					goto case 3;
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
		internal static object rw35ynKaxwLCLpH5Ewix(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xk2qwrKam0RlgTeNPjuo(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool e4PAZhKaU8jwKvA0YUGD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fqImA5KaH72ogy1JsB8D()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass66_0
	{
		public CvsCellRange cellRange;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass66_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			g6M0BkKa2TRsGiYPYJG5();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003COnSnippetRemove_003Eb__0(CvsCell c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			CvsCellLocation cvsCellLocation = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					if (cvsCellLocation.Column < cellRange.Column)
					{
						break;
					}
					goto case 2;
				case 4:
					if (cvsCellLocation.Column > cellRange.LastColumn)
					{
						break;
					}
					num = 3;
					if (true)
					{
						continue;
					}
					goto case 6;
				case 6:
					cvsCellLocation = c.Location;
					_ = 1;
					num = (RSDIOeKaN70A689DJ1OS() ? 5 : 0);
					continue;
				case 2:
				case 5:
					cvsCellLocation = T9B88JKacjmquXIuXNld(c);
					goto case 4;
				default:
					num = 4;
					continue;
				case 3:
					cvsCellLocation = T9B88JKacjmquXIuXNld(c);
					num = 7;
					continue;
				case 7:
					return cvsCellLocation.Row > cellRange.LastRow;
				}
				break;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void g6M0BkKa2TRsGiYPYJG5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RgJujeKaQcFlQPYFn305()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RSDIOeKaN70A689DJ1OS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation T9B88JKacjmquXIuXNld(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Location;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnSnippetRemove_003Ed__66 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SnippetRemoveEventArgs e;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		private _003C_003Ec__DisplayClass66_0 _003C_003E8__1;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<object> awaiter2 = default;
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__2;
								goto IL_020a;
							}
							num3 = 15;
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_ = 1;
							num3 = ((!bpiEdLKauR1s70j2sB9j()) ? 3 : 7);
						}
						goto IL_004a;
						IL_004a:
						while (true)
						{
							switch (num3)
							{
							case 0:
								num2 = (_003C_003E1__state = -1);
								goto case 9;
							default:
								num3 = 9;
								continue;
							case 9:
								awaiter2.GetResult();
								num3 = 5;
								continue;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 8;
								continue;
							case 4:
								return;
							case 15:
								_003C_003E8__1 = new _003C_003Ec__DisplayClass66_0();
								num3 = 10;
								continue;
							case 11:
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								continue;
							case 12:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							case 8:
								awaiter.GetResult();
								num3 = 18;
								continue;
							case 2:
								awaiter = easyBuilderApplicationViewModel.ShiftSnippetsIntoUnusedRange(_003C_003E8__1.cellRange).GetAwaiter();
								if (awaiter.IsCompleted)
								{
									goto case 8;
								}
								num2 = (_003C_003E1__state = 1);
								num3 = 11;
								if (yyTMGxKa1djhSM8BiJXD())
								{
									continue;
								}
								goto case 14;
							case 14:
								awaiter2 = ((CvsCogSocketSheet)ohuG4DKazjF1lW9awHjw(easyBuilderApplicationViewModel.InSight.CogSocket)).ClearCellsAsync(_003C_003E8__1.cellRange).GetAwaiter();
								if (awaiter2.IsCompleted)
								{
									goto case 9;
								}
								num3 = 16;
								if (yyTMGxKa1djhSM8BiJXD())
								{
									continue;
								}
								goto case 3;
							case 3:
							case 6:
								_003C_003Eu__1 = default;
								num3 = 0;
								if (!bpiEdLKauR1s70j2sB9j())
								{
									continue;
								}
								goto case 16;
							case 16:
								num2 = (_003C_003E1__state = 0);
								num3 = 17;
								if (0 == 0)
								{
									continue;
								}
								break;
							case 7:
							case 13:
								break;
							case 5:
								if (((IEnumerable<CvsCell>)MUkgmeKeLApXhUDXGfxE(easyBuilderApplicationViewModel.InSight.Results)).FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (CvsCell c) =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									int num4 = 6;
									CvsCellLocation cvsCellLocation = default;
									while (true)
									{
										switch (num4)
										{
										case 0:
										case 1:
											if (cvsCellLocation.Column < _003C_003E8__1.cellRange.Column)
											{
												break;
											}
											goto case 2;
										case 4:
											if (cvsCellLocation.Column > _003C_003E8__1.cellRange.LastColumn)
											{
												break;
											}
											num4 = 3;
											if (true)
											{
												continue;
											}
											goto case 6;
										case 6:
											cvsCellLocation = c.Location;
											_ = 1;
											num4 = (_003C_003Ec__DisplayClass66_0.RSDIOeKaN70A689DJ1OS() ? 5 : 0);
											continue;
										case 2:
										case 5:
											cvsCellLocation = _003C_003Ec__DisplayClass66_0.T9B88JKacjmquXIuXNld(c);
											goto case 4;
										default:
											num4 = 4;
											continue;
										case 3:
											cvsCellLocation = _003C_003Ec__DisplayClass66_0.T9B88JKacjmquXIuXNld(c);
											num4 = 7;
											continue;
										case 7:
											return cvsCellLocation.Row > _003C_003E8__1.cellRange.LastRow;
										}
										break;
									}
									return false;
								}) != null)
								{
									num3 = 2;
									continue;
								}
								goto case 18;
							case 10:
								_003C_003E8__1.cellRange = tCMqldKatU9IOqj1Y3CQ(G4rv0pKahQtxkcqIpWor(e));
								num3 = 14;
								continue;
							case 17:
								_003C_003Eu__1 = awaiter2;
								num3 = 12;
								continue;
							case 18:
								easyBuilderApplicationViewModel.P2rz3AUMr.Remove(e.Snippet);
								goto end_IL_004a;
							}
							goto IL_020a;
							continue;
							end_IL_004a:
							break;
						}
						goto end_IL_0018;
						IL_020a:
						_003C_003Eu__2 = default;
						num3 = 1;
						goto IL_004a;
						end_IL_0018:;
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
					bpiEdLKauR1s70j2sB9j();
					num = ((!yyTMGxKa1djhSM8BiJXD()) ? 5 : 6);
					continue;
				case 0:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 1:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					num = 2;
					continue;
				case 3:
				case 6:
					_003C_003E8__1 = null;
					break;
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
		internal static object G4rv0pKahQtxkcqIpWor(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SnippetRemoveEventArgs)P_0).Snippet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange tCMqldKatU9IOqj1Y3CQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).CellRange;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ohuG4DKazjF1lW9awHjw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MUkgmeKeLApXhUDXGfxE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yyTMGxKa1djhSM8BiJXD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bpiEdLKauR1s70j2sB9j()
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
	private struct _003CStep_SnippetRenamed_003Ed__67 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		public object source;

		public SnippetRenamedEventArgs e;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			Task task = default;
			ISnippetConsumer snippetConsumer = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					goto case 0;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 4;
				case 4:
					num2 = _003C_003E1__state;
					F3vVroKe5ASJbgusxdi4();
					num = (tsgJ6vKeKb4T4etACBSD() ? 5 : 0);
					break;
				case 0:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						if (num2 != 0)
						{
							List<Task> list = new List<Task>();
							IEnumerator<AppStepViewModel> enumerator = easyBuilderApplicationViewModel.Steps.GetEnumerator();
							try
							{
								while (FdtFZkKeJyH5Eu02hkOT(enumerator))
								{
									AppStepViewModel current = enumerator.Current;
									int num3 = 7;
									while (true)
									{
										switch (num3)
										{
										case 3:
										case 4:
											if (task != null)
											{
												num3 = 0;
												continue;
											}
											break;
										case 0:
											list.Add(task);
											num3 = 8;
											continue;
										case 6:
											task = (Task)C66EuvKewJmHFesQyGAt(snippetConsumer, e);
											goto case 3;
										case 2:
										case 5:
											if (snippetConsumer == null)
											{
												break;
											}
											goto case 6;
										default:
											num3 = 6;
											continue;
										case 7:
											if (current == source)
											{
												break;
											}
											num3 = 1;
											if (true)
											{
												continue;
											}
											goto case 1;
										case 1:
											snippetConsumer = current as ISnippetConsumer;
											tsgJ6vKeKb4T4etACBSD();
											if (F3vVroKe5ASJbgusxdi4())
											{
												num3 = 3;
												continue;
											}
											num3 = 5;
											if (tsgJ6vKeKb4T4etACBSD())
											{
												continue;
											}
											break;
										case 8:
											break;
										}
										break;
									}
								}
							}
							finally
							{
								if (num2 < 0)
								{
									enumerator?.Dispose();
								}
							}
							awaiter = st5KbJKeaCjmBJWg5gAY(Task.WhenAll(list));
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
		internal static object C66EuvKewJmHFesQyGAt(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ISnippetConsumer)P_0).RenameReferences((SnippetRenamedEventArgs)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FdtFZkKeJyH5Eu02hkOT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter st5KbJKeaCjmBJWg5gAY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tsgJ6vKeKb4T4etACBSD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool F3vVroKe5ASJbgusxdi4()
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
	private struct _003COnJobLoading_003Ed__69 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private IEnumerator<AppStepViewModel> _003C_003E7__wrap1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!eqihUSKeeGEAjI7b3YN9())
			{
				goto IL_001e;
			}
			goto IL_0305;
			IL_001e:
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			int num2 = default;
			try
			{
				TaskAwaiter awaiter = default;
				switch (num2)
				{
				default:
					awaiter = easyBuilderApplicationViewModel.DLpqZLnpw().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num2 = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0087;
				case 0:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num2 = (_003C_003E1__state = -1);
					goto IL_0087;
				case 1:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num2 = (_003C_003E1__state = -1);
					goto IL_0112;
				case 2:
					break;
					IL_0112:
					awaiter.GetResult();
					easyBuilderApplicationViewModel.PropertyLinks = null;
					ClarjtKeDxhFhFlQ7xo9(easyBuilderApplicationViewModel.P2rz3AUMr);
					_003C_003E7__wrap1 = easyBuilderApplicationViewModel.Steps.GetEnumerator();
					break;
					IL_0087:
					awaiter.GetResult();
					awaiter = QSVT8vKeIVuPajU4hpVI(easyBuilderApplicationViewModel.C11guoYo3(easyBuilderApplicationViewModel.Steps.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (AppStepViewModel s) =>
					{
						while (false)
						{
							_ = ((object[])null)[0];
						}
						return _003C_003Ec.mvnQ2BKJD0oinHfRvVPK(s);
					})));
					if (!awaiter.IsCompleted)
					{
						num2 = (_003C_003E1__state = 1);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0112;
				}
				try
				{
					int num3;
					if (num2 != 2)
					{
						eqihUSKeeGEAjI7b3YN9();
						if (!vkT9d0KeO4N7p93bW0iL())
						{
							num3 = 7;
							if (false)
							{
								goto IL_0160;
							}
						}
						else
						{
							num3 = 11;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						num3 = 1;
					}
					IInSightAppStep current = default;
					while (true)
					{
						IL_0179:
						switch (num3)
						{
						case 9:
							break;
						default:
							num3 = 5;
							if (0 == 0)
							{
								continue;
							}
							goto IL_01be;
						case 5:
							goto IL_01be;
						case 6:
							return;
						case 8:
							num2 = (_003C_003E1__state = 2);
							num3 = 9;
							continue;
						case 1:
							_003C_003Eu__1 = default;
							num3 = 3;
							if (0 == 0)
							{
								continue;
							}
							return;
						case 11:
							return;
						case 10:
							if (!awaiter.IsCompleted)
							{
								num3 = 8;
								continue;
							}
							goto case 4;
						case 2:
							awaiter = ((Task)qnEJmCKei4NNZPZcbkxx(current, easyBuilderApplicationViewModel, true)).GetAwaiter();
							num3 = 10;
							continue;
						case 4:
							awaiter.GetResult();
							num3 = 12;
							continue;
						case 3:
							num2 = (_003C_003E1__state = -1);
							num3 = 4;
							continue;
						case 0:
						case 7:
						case 12:
							while (zdXDtRKenVc9K1eln2Xr(_003C_003E7__wrap1))
							{
								current = _003C_003E7__wrap1.Current;
								if (current != null)
								{
									num3 = 2;
									goto IL_0179;
								}
							}
							goto end_IL_013d;
						}
						break;
					}
					goto IL_0160;
					IL_01be:
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
					IL_0160:
					_003C_003Eu__1 = awaiter;
					goto IL_01be;
					end_IL_013d:;
				}
				finally
				{
					if (num2 < 0 && _003C_003E7__wrap1 != null)
					{
						u0aqTFKeVP6rFiBY9Rcu(_003C_003E7__wrap1);
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
			goto IL_036a;
			IL_0305:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					break;
				case 0:
					do
					{
						easyBuilderApplicationViewModel = _003C_003E4__this;
						vkT9d0KeO4N7p93bW0iL();
						if (!eqihUSKeeGEAjI7b3YN9())
						{
							num = 5;
							continue;
						}
						num = 1;
						break;
					}
					while (1 == 0);
					continue;
				case 4:
					num2 = _003C_003E1__state;
					num = 0;
					continue;
				default:
					goto IL_036a;
				case 6:
					return;
				}
				break;
			}
			goto IL_001e;
			IL_036a:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (!eqihUSKeeGEAjI7b3YN9())
			{
				return;
			}
			goto IL_0305;
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
		internal static TaskAwaiter QSVT8vKeIVuPajU4hpVI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ClarjtKeDxhFhFlQ7xo9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((List<EzSnippet>)P_0).Clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qnEJmCKei4NNZPZcbkxx(object P_0, object P_1, bool jobLoading)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IInSightAppStep)P_0).BeginInitialization((EasyBuilderApplicationViewModel)P_1, jobLoading);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zdXDtRKenVc9K1eln2Xr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void u0aqTFKeVP6rFiBY9Rcu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eqihUSKeeGEAjI7b3YN9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vkT9d0KeO4N7p93bW0iL()
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
	private struct _003COnJobLoaded_003Ed__70 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

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
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						switch (num2)
						{
						default:
							awaiter = oxPu2lKelS8IhOuCOK9W(easyBuilderApplicationViewModel.Am9iPlpys());
							num3 = 7;
							break;
						case 1:
							awaiter = _003C_003Eu__1;
							num3 = 3;
							break;
						case 2:
							awaiter = _003C_003Eu__1;
							num3 = 5;
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 0;
							break;
						}
						while (true)
						{
							object obj;
							Task task;
							switch (num3)
							{
							case 3:
								_003C_003Eu__1 = default;
								num3 = 23;
								continue;
							case 6:
								return;
							case 15:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 13:
							{
								awaiter.GetResult();
								RuntimeViewModel runtime = easyBuilderApplicationViewModel.Runtime;
								if (runtime == null)
								{
									num3 = 4;
									continue;
								}
								IRuntimeService runtimeService = runtime.RuntimeService;
								if (runtimeService == null)
								{
									num3 = 17;
									if (0 == 0)
									{
										continue;
									}
									goto case 22;
								}
								obj = BoQ6yRKesNZdkkXX97KH(runtimeService);
								goto IL_02fd;
							}
							case 4:
								obj = null;
								goto IL_02fd;
							case 22:
								num2 = (_003C_003E1__state = -1);
								num3 = 8;
								continue;
							case 19:
								awaiter = oxPu2lKelS8IhOuCOK9W(easyBuilderApplicationViewModel.TUbXLFygM());
								if (!awaiter.IsCompleted)
								{
									num3 = 18;
									continue;
								}
								goto case 13;
							case 14:
								num2 = (_003C_003E1__state = 2);
								num3 = 12;
								continue;
							case 0:
								_003C_003Eu__1 = default;
								num3 = 22;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
							case 10:
								_003C_003Eu__1 = awaiter;
								goto case 2;
							case 23:
								num2 = (_003C_003E1__state = -1);
								num3 = 13;
								if (true)
								{
									continue;
								}
								goto case 12;
							case 12:
								_003C_003Eu__1 = awaiter;
								num3 = 15;
								if (!kUPeLNKedmFAUrpugIqx())
								{
									continue;
								}
								goto case 18;
							case 18:
								num2 = (_003C_003E1__state = 1);
								num3 = 11;
								continue;
							case 20:
								easyBuilderApplicationViewModel.SnippetsNeedUpdates = easyBuilderApplicationViewModel.YkFe36inZ((CvsCellCollection)XppDTrKegbiPowRkWfIS(easyBuilderApplicationViewModel.InSight.Results));
								num3 = 19;
								continue;
							case 5:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 24;
								continue;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									KWeUYMKefYCW6uxFDFbS();
									if (kUPeLNKedmFAUrpugIqx())
									{
										num3 = 21;
										continue;
									}
									num3 = 10;
									if (true)
									{
										continue;
									}
								}
								goto case 8;
							case 8:
								awaiter.GetResult();
								num3 = 20;
								continue;
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 14;
									continue;
								}
								break;
							case 11:
								_003C_003Eu__1 = awaiter;
								num3 = 16;
								if (KWeUYMKefYCW6uxFDFbS())
								{
									continue;
								}
								goto case 16;
							case 16:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 6;
								continue;
							case 2:
							case 21:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 17:
								obj = null;
								goto IL_02fd;
							case 24:
								break;
								IL_02fd:
								task = (Task)obj;
								if (task != null)
								{
									awaiter = oxPu2lKelS8IhOuCOK9W(task);
									num3 = 9;
									continue;
								}
								goto end_IL_025b;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_025b:
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
					continue;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 4:
					break;
				case 1:
				case 3:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					goto case 0;
				case 6:
					return;
				}
				num2 = _003C_003E1__state;
				kUPeLNKedmFAUrpugIqx();
				if (KWeUYMKefYCW6uxFDFbS())
				{
					num = 3;
					continue;
				}
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				break;
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
		internal static TaskAwaiter oxPu2lKelS8IhOuCOK9W(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XppDTrKegbiPowRkWfIS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BoQ6yRKesNZdkkXX97KH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IRuntimeService)P_0).Ready();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KWeUYMKefYCW6uxFDFbS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kUPeLNKedmFAUrpugIqx()
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
	private struct _003CUpdateActiveStep_003Ed__104 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		public AppStepViewModel newStep;

		private AppStepViewModel _003ColdStep_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (!R5aAwyKev9BBvp88MH1F())
			{
				goto IL_001e;
			}
			goto IL_03af;
			IL_001e:
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = _003C_003E4__this;
			num = 6;
			goto IL_03af;
			IL_03af:
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					break;
				case 2:
				case 4:
					_003C_003Et__builder.SetResult();
					num = 7;
					if (0 == 0)
					{
						continue;
					}
					goto case 6;
				case 6:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 5;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 15;
								if (G8lXdmKerCeCV4ciaEBm())
								{
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
							if (false)
							{
								goto IL_008a;
							}
						}
						goto IL_0223;
						IL_009f:
						if (awaiter.IsCompleted)
						{
							goto IL_011e;
						}
						num3 = 10;
						goto IL_0223;
						IL_0223:
						while (true)
						{
							switch (num3)
							{
							case 14:
							case 18:
								if (easyBuilderApplicationViewModel.tuC5o8i1EB != null)
								{
									num3 = 2;
									continue;
								}
								goto case 19;
							case 4:
								return;
							case 23:
								break;
							case 21:
								goto IL_009f;
							case 19:
								easyBuilderApplicationViewModel.FirePropertyChanged((string)Pcdcl2KeqYQwYfKdqfy7(48116));
								num3 = 24;
								continue;
							case 22:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								num3 = 16;
								if (R5aAwyKev9BBvp88MH1F())
								{
									continue;
								}
								goto case 12;
							case 12:
								if (!awaiter.IsCompleted)
								{
									num3 = 22;
									if (R5aAwyKev9BBvp88MH1F())
									{
										continue;
									}
									goto case 10;
								}
								goto case 7;
							case 10:
								num2 = (_003C_003E1__state = 0);
								num3 = 11;
								continue;
							case 3:
							case 8:
								goto IL_011e;
							case 17:
								awaiter = Fu4MpgKeZ5puyKBgGmIW(wc31XXKebCYxP9JTryTN(newStep, _003ColdStep_003E5__2));
								num3 = 12;
								if (R5aAwyKev9BBvp88MH1F())
								{
									continue;
								}
								goto case 6;
							case 6:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								G8lXdmKerCeCV4ciaEBm();
								num3 = ((!R5aAwyKev9BBvp88MH1F()) ? 14 : 3);
								continue;
							case 1:
								Qj4q6kKeoFcQxMPGwLUt(a5050UKeGJAGEcCghAhT(easyBuilderApplicationViewModel), easyBuilderApplicationViewModel.IsLiveModeAllowed);
								if (!aM7eSGKeSJ3YcjBatr0L(easyBuilderApplicationViewModel.tuC5o8i1EB))
								{
									UepaDVKe8qqywU4THl3L(FBpWG0KekpO50gH2NKw9(a5050UKeGJAGEcCghAhT(easyBuilderApplicationViewModel), false));
									num3 = 19;
									continue;
								}
								goto case 19;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								continue;
							case 11:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 9:
								easyBuilderApplicationViewModel.tuC5o8i1EB = newStep;
								tDVop9KeBFJsaDSdpEd6(easyBuilderApplicationViewModel);
								num3 = 20;
								continue;
							case 20:
								if (newStep == null)
								{
									goto case 14;
								}
								goto case 17;
							default:
								num3 = 17;
								if (R5aAwyKev9BBvp88MH1F())
								{
									continue;
								}
								goto case 15;
							case 15:
								_003C_003Eu__1 = default;
								num3 = 23;
								if (G8lXdmKerCeCV4ciaEBm())
								{
								}
								continue;
							case 2:
								if (a5050UKeGJAGEcCghAhT(easyBuilderApplicationViewModel) != null)
								{
									num3 = 1;
									continue;
								}
								goto case 19;
							case 13:
								if (_003ColdStep_003E5__2 != null)
								{
									awaiter = Fu4MpgKeZ5puyKBgGmIW(pdp0qOKePmqAh7Ktx0Bu(_003ColdStep_003E5__2, newStep));
									num3 = 21;
									continue;
								}
								goto case 9;
							case 16:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 5:
								_003ColdStep_003E5__2 = easyBuilderApplicationViewModel.tuC5o8i1EB;
								num3 = 13;
								continue;
							case 7:
								awaiter.GetResult();
								easyBuilderApplicationViewModel.R8Ck1WDkk(newStep);
								goto case 14;
							case 24:
								N2fvIyKeESw6r1C9He0V(easyBuilderApplicationViewModel.ToggleFilmstripCommand);
								goto end_IL_0046;
							}
							break;
						}
						goto IL_008a;
						IL_008a:
						num2 = (_003C_003E1__state = -1);
						num3 = 7;
						if (1 == 0)
						{
							goto IL_009f;
						}
						goto IL_0223;
						IL_011e:
						awaiter.GetResult();
						num3 = 9;
						goto IL_0223;
						end_IL_0046:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003ColdStep_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 5;
				default:
					num = 5;
					continue;
				case 3:
					num2 = _003C_003E1__state;
					G8lXdmKerCeCV4ciaEBm();
					num = ((!R5aAwyKev9BBvp88MH1F()) ? 2 : 0);
					continue;
				case 5:
					_003ColdStep_003E5__2 = null;
					goto case 2;
				case 7:
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
		internal static object pdp0qOKePmqAh7Ktx0Bu(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((StepBase)P_0).LeaveStep((StepBase)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Fu4MpgKeZ5puyKBgGmIW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void tDVop9KeBFJsaDSdpEd6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EasyBuilderApplicationViewModel)P_0).OnActiveStepChanged();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wc31XXKebCYxP9JTryTN(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((StepBase)P_0).EnterStep((StepBase)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object a5050UKeGJAGEcCghAhT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BaseIdeViewModel)P_0).Runtime;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Qj4q6kKeoFcQxMPGwLUt(object P_0, bool P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((RuntimeViewModel)P_0).IsLiveModeAllowed = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aM7eSGKeSJ3YcjBatr0L(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((StepBase)P_0).CanEnableLiveMode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FBpWG0KekpO50gH2NKw9(object P_0, bool P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((RuntimeViewModel)P_0).SetLiveMode(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UepaDVKe8qqywU4THl3L(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Task)P_0).IgnoreResult();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Pcdcl2KeqYQwYfKdqfy7(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void N2fvIyKeESw6r1C9He0V(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BaseDelegateCommand)P_0).RaiseCanExecuteChanged();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool R5aAwyKev9BBvp88MH1F()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool G8lXdmKerCeCV4ciaEBm()
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
	private struct _003CDoResetJobStatistics_003Ed__121 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		private TaskAwaiter<IAsyncDisposable> _003C_003Eu__1;

		private object _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private ValueTaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			do
			{
				IL_0237:
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					goto IL_0237;
				case 1:
				case 2:
					try
					{
						if ((uint)num2 > 1u)
						{
							easyBuilderApplicationViewModel.e1t4CpG2L(_0020: true);
						}
						try
						{
							TaskAwaiter<IAsyncDisposable> awaiter;
							if (num2 == 0)
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_00a7;
							}
							ValueTaskAwaiter awaiter2;
							if (num2 == 1)
							{
								awaiter2 = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_01b1;
							}
							if (easyBuilderApplicationViewModel.Inspect != null)
							{
								awaiter = easyBuilderApplicationViewModel.PauseResults().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_00a7;
							}
							goto end_IL_0038;
							IL_01b1:
							awaiter2.GetResult();
							goto IL_01b8;
							IL_00a7:
							IAsyncDisposable result = awaiter.GetResult();
							_003C_003E7__wrap1 = null;
							_003C_003E7__wrap2 = 0;
							try
							{
								object obj = NeLIlYKe92Y18oEePB30(easyBuilderApplicationViewModel.Inspect);
								int num3;
								if (obj == null)
								{
									_ = 0;
									if (CCLr7vKepafOb3ueVMyF())
									{
										num3 = 2;
										goto IL_0108;
									}
									num3 = 3;
									if (true)
									{
										goto IL_0108;
									}
								}
								else
								{
									((JobPassFail)obj).ResetCommand?.HgmHLOyrXd();
								}
								goto end_IL_00bd;
								IL_0108:
								switch (num3)
								{
								case 0:
								case 2:
									break;
								case 3:
									break;
								}
								end_IL_00bd:;
							}
							catch (object obj2)
							{
								_003C_003E7__wrap1 = obj2;
							}
							if (result != null)
							{
								awaiter2 = AT4aF5Ke4bRDiMxSZYAl(result).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_01b1;
							}
							goto IL_01b8;
							IL_01b8:
							object obj3 = _003C_003E7__wrap1;
							if (obj3 != null)
							{
								WlMlqnKe3BbMYK4A0s37(RtBW4vKe7VlDXABUCwqC((obj3 as Exception) ?? throw obj3));
							}
							_003C_003E7__wrap1 = null;
							end_IL_0038:;
						}
						finally
						{
							if (num2 < 0)
							{
								easyBuilderApplicationViewModel.e1t4CpG2L(_0020: false);
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
					break;
				case 5:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					sIU0nwKeX86V7n8kfv0c();
					if (!CCLr7vKepafOb3ueVMyF())
					{
						num = 0;
					}
					else
					{
						num = 1;
						if (sIU0nwKeX86V7n8kfv0c())
						{
						}
					}
					goto IL_0237;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
			}
			while (CCLr7vKepafOb3ueVMyF());
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
		internal static object NeLIlYKe92Y18oEePB30(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((InspectStepViewModel)P_0).JobPassFail;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ValueTask AT4aF5Ke4bRDiMxSZYAl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IAsyncDisposable)P_0).DisposeAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RtBW4vKe7VlDXABUCwqC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WlMlqnKe3BbMYK4A0s37(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CCLr7vKepafOb3ueVMyF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sIU0nwKeX86V7n8kfv0c()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass126_0
	{
		public CvsCellCollection cells;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass126_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			RWjI2NKeCVdx2VBkOFsV();
			mqyWbjKeAuCrk9NKWVrP(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RWjI2NKeCVdx2VBkOFsV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void mqyWbjKeAuCrk9NKWVrP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sA6NBHKejwMfouNvinbs()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GPkeQoKe6qVEgD7opdSw()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass126_1
	{
		public (Guid guid, CvsCellRange range) snippet;

		public _003C_003Ec__DisplayClass126_0 CS_0024_003C_003E8__locals1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass126_1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			DHRJdDKeTEj52EGdwrbi(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CUpdateSnippetsToLatestRevision_003Eb__1(SnippetUpdateViewModel s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return U8nnOUKeyjB7DDZ2NTWo(s, snippet.guid, CS_0024_003C_003E8__locals1.cells, snippet.range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void DHRJdDKeTEj52EGdwrbi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yiDbRwKeRcx4kYCVTkIG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rgH4BIKeWIZNtIGhTiVe()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool U8nnOUKeyjB7DDZ2NTWo(object P_0, Guid guid, object P_2, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SnippetUpdateViewModel)P_0).NeedsUpdate(guid, (CvsCellCollection)P_2, range);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUpdateSnippetsToLatestRevision_003Ed__126 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		private _003C_003Ec__DisplayClass126_0 _003C_003E8__1;

		private ITopLevelProgressableOperation _003C_003E7__wrap1;

		private List<SnippetUpdateViewModel> _003CupdateVms_003E5__3;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		private IEnumerator<(Guid guid, CvsCellRange range)> _003C_003E7__wrap3;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			TaskAwaiter awaiter = default;
			SnippetUpdateViewModel snippetUpdateViewModel = default;
			_003C_003Ec__DisplayClass126_1 obj = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 2:
				case 5:
					try
					{
						if ((uint)num2 > 2u)
						{
							_003C_003E7__wrap1 = (ITopLevelProgressableOperation)(IoYGdZKeM4L5qUOdfnxH(easyBuilderApplicationViewModel.OperationProgressManager) ? QsNKZjKeUPqZqajEol72(easyBuilderApplicationViewModel.OperationProgressManager, MPej9rKeYCPY6h3Qa5L8(), Array.Empty<StepDescriptor>()) : null);
						}
						try
						{
							TaskAwaiter<CvsCellCollection> awaiter2;
							CvsCellCollection result;
							IEnumerable<(Guid, CvsCellRange)> snippetsFromCells;
							switch (num2)
							{
							default:
								_003C_003E8__1 = new _003C_003Ec__DisplayClass126_0();
								_003CupdateVms_003E5__3 = easyBuilderApplicationViewModel.Steps.OfType<ISnippetOwner>().Append(easyBuilderApplicationViewModel).Select([MethodImpl(MethodImplOptions.NoInlining)] (ISnippetOwner o) =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									return new SnippetUpdateViewModel(o);
								})
									.ToList();
								awaiter2 = ((CvsCogSocketSheet)P64GZ4Kex3yeNKYY1oyy(m5LbrwKeH9NeSFieoSvO(easyBuilderApplicationViewModel.duohQ2pLC))).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_0130;
							case 0:
								awaiter2 = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0130;
							case 1:
								try
								{
									int num3;
									if (num2 != 1)
									{
										num3 = 4;
										goto IL_02d5;
									}
									awaiter = _003C_003Eu__2;
									goto IL_0197;
									IL_0197:
									_003C_003Eu__2 = default;
									num3 = 12;
									goto IL_02d5;
									IL_02d5:
									while (true)
									{
										switch (num3)
										{
										case 3:
											awaiter.GetResult();
											num3 = 14;
											continue;
										case 6:
										case 8:
											num2 = (_003C_003E1__state = 1);
											num3 = 1;
											continue;
										case 0:
										case 9:
											break;
										case 1:
											_003C_003Eu__2 = awaiter;
											num3 = 13;
											continue;
										case 5:
											if (snippetUpdateViewModel != null)
											{
												awaiter = ((Task)V96hxpKembGlweXg2Ifx(snippetUpdateViewModel, obj.snippet.guid, obj.CS_0024_003C_003E8__locals1.cells, obj.snippet.range)).GetAwaiter();
												num3 = 7;
												if (0 == 0)
												{
													continue;
												}
												goto case 11;
											}
											goto case 4;
										case 11:
											obj.CS_0024_003C_003E8__locals1 = _003C_003E8__1;
											num3 = 10;
											if (0 == 0)
											{
												continue;
											}
											goto case 12;
										case 12:
											num2 = (_003C_003E1__state = -1);
											num3 = 3;
											if (!mRStVjKeFEqqpUaLSVnw())
											{
												continue;
											}
											goto case 13;
										case 13:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											return;
										case 2:
											snippetUpdateViewModel = _003CupdateVms_003E5__3.FirstOrDefault(obj._003CUpdateSnippetsToLatestRevision_003Eb__1);
											num3 = 5;
											continue;
										case 10:
											obj.snippet = _003C_003E7__wrap3.Current;
											num3 = 2;
											continue;
										case 7:
											if (awaiter.IsCompleted)
											{
												goto case 3;
											}
											goto default;
										default:
											_ = 1;
											num3 = ((!mRStVjKeFEqqpUaLSVnw()) ? 8 : 0);
											continue;
										case 4:
										case 14:
											if (uJBr8rKeQrxi98rIFNLH(_003C_003E7__wrap3))
											{
												obj = new _003C_003Ec__DisplayClass126_1();
												num3 = 11;
												continue;
											}
											goto end_IL_02d5;
										}
										goto IL_0197;
										continue;
										end_IL_02d5:
										break;
									}
								}
								finally
								{
									if (num2 < 0 && _003C_003E7__wrap3 != null)
									{
										mdlq3jKeNlcCRu8wfkxj(_003C_003E7__wrap3);
									}
								}
								_003C_003E7__wrap3 = null;
								easyBuilderApplicationViewModel.SnippetsNeedUpdates = easyBuilderApplicationViewModel.YkFe36inZ((CvsCellCollection)Pk4aNIKecjinnZ0tTSEw(N5qvwBKe2uwuFRXXjLUy(easyBuilderApplicationViewModel.InSight)));
								awaiter = easyBuilderApplicationViewModel.TUbXLFygM().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 2);
									_003C_003Eu__2 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								break;
							case 2:
								{
									awaiter = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									break;
								}
								IL_0130:
								result = awaiter2.GetResult();
								_003C_003E8__1.cells = result;
								snippetsFromCells = GetSnippetsFromCells(_003C_003E8__1.cells);
								_003C_003E7__wrap3 = snippetsFromCells.GetEnumerator();
								goto case 1;
							}
							awaiter.GetResult();
							_003C_003E8__1 = null;
							_003CupdateVms_003E5__3 = null;
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								mdlq3jKeNlcCRu8wfkxj(_003C_003E7__wrap1);
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
					goto case 3;
				default:
					num = 3;
					continue;
				case 0:
				case 1:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					goto case 2;
				case 4:
					break;
				case 6:
					return;
				}
				do
				{
					num2 = _003C_003E1__state;
					mRStVjKeFEqqpUaLSVnw();
					if (!bNnxxiKe0jlby33lAFgG())
					{
						num = 5;
						continue;
					}
					num = 0;
					break;
				}
				while (1 == 0);
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
		internal static bool IoYGdZKeM4L5qUOdfnxH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).HasNoOperationsPending;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MPej9rKeYCPY6h3Qa5L8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.AMwhYPy1Il();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QsNKZjKeUPqZqajEol72(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).StartBlockingOperation((string)P_1, (StepDescriptor[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object m5LbrwKeH9NeSFieoSvO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object P64GZ4Kex3yeNKYY1oyy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object V96hxpKembGlweXg2Ifx(object P_0, Guid guid, object P_2, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SnippetUpdateViewModel)P_0).UpdateSnippet(guid, (CvsCellCollection)P_2, range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uJBr8rKeQrxi98rIFNLH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void mdlq3jKeNlcCRu8wfkxj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object N5qvwBKe2uwuFRXXjLUy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Pk4aNIKecjinnZ0tTSEw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bNnxxiKe0jlby33lAFgG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mRStVjKeFEqqpUaLSVnw()
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
	private struct _003CReadCurrentPropertyLinks_003Ed__133 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		private List<CellViewModel> _003Cproperties_003E5__2;

		private ILookup<CvsCellLocation, CellViewModel> _003CpropertyLookup_003E5__3;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (!KBaDLEKe1EkN5ORCgUmS())
			{
				goto IL_001e;
			}
			goto IL_0063;
			IL_001e:
			_003C_003Et__builder.SetResult();
			num = 8;
			goto IL_0063;
			IL_0063:
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			int num2 = default;
			CellViewModel cellViewModel = default;
			CvsCellLocation key = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					break;
				case 4:
					_003CpropertyLookup_003E5__3 = null;
					break;
				case 7:
					_003Cproperties_003E5__2 = null;
					goto case 4;
				default:
					num = 4;
					continue;
				case 3:
					num2 = _003C_003E1__state;
					KBaDLEKe1EkN5ORCgUmS();
					num = ((!BMX5HRKeuxajP2JeuPJG()) ? 6 : 2);
					continue;
				case 1:
				case 6:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					num = 0;
					if (!BMX5HRKeuxajP2JeuPJG())
					{
						continue;
					}
					goto case 0;
				case 0:
					try
					{
						TaskAwaiter<CvsCellCollection> awaiter;
						if (num2 != 0)
						{
							_003Cproperties_003E5__2 = new List<CellViewModel>();
							IEnumerator<AppStepViewModel> enumerator = easyBuilderApplicationViewModel.Steps.GetEnumerator();
							try
							{
								while (mVTTwGKehOPCMcC28x5f(enumerator))
								{
									ISnippetOwner snippetOwner = enumerator.Current as ISnippetOwner;
									_ = 1;
									int num3;
									if (!BMX5HRKeuxajP2JeuPJG())
									{
										num3 = 2;
										if (false)
										{
											goto IL_0115;
										}
									}
									else
									{
										num3 = 3;
									}
									goto IL_012e;
									IL_012e:
									switch (num3)
									{
									case 0:
									case 2:
										break;
									default:
										goto IL_0157;
									case 4:
										continue;
									}
									goto IL_0115;
									IL_0115:
									if (snippetOwner == null)
									{
										continue;
									}
									goto IL_0157;
									IL_0157:
									_003Cproperties_003E5__2.AddRange(snippetOwner.GetLinkableProperties());
									num3 = 4;
									goto IL_012e;
								}
							}
							finally
							{
								if (num2 < 0 && enumerator != null)
								{
									SZF2LtKete6YX1UDK4QQ(enumerator);
								}
							}
							_003CpropertyLookup_003E5__3 = _003Cproperties_003E5__2.ToLookup([MethodImpl(MethodImplOptions.NoInlining)] (CellViewModel property) =>
							{
								while (false)
								{
									_ = ((object[])null)[0];
								}
								return _003C_003Ec.mZDxZcKJndlErdevKsH6(property);
							});
							awaiter = ((CvsCogSocketSheet)ii8jnsKezeAJfBi5gWc7(easyBuilderApplicationViewModel.InSight.CogSocket)).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
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
						CvsCellCollection result = awaiter.GetResult();
						List<CellViewModel>.Enumerator enumerator2 = _003Cproperties_003E5__2.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								CellViewModel current = enumerator2.Current;
								int num4 = 4;
								while (true)
								{
									switch (num4)
									{
									case 4:
										cellViewModel = null;
										_ = 1;
										num4 = (BMX5HRKeuxajP2JeuPJG() ? 2 : 5);
										continue;
									case 1:
									case 5:
										key = Ua6q4rKOKWWRs98Ik3wE(easyBuilderApplicationViewModel.PropertyLinks, result, u66JXoKOLBXptUdAs3ja(current));
										num4 = 0;
										continue;
									case 0:
										if (key.IsValid)
										{
											goto default;
										}
										goto case 6;
									default:
										cellViewModel = _003CpropertyLookup_003E5__3[key].FirstOrDefault();
										num4 = 6;
										if (true)
										{
											continue;
										}
										goto case 6;
									case 6:
										dFFO66KO5OxAg4r0HO3s(current, cellViewModel, false);
										num4 = 7;
										if (true)
										{
											continue;
										}
										break;
									case 7:
										break;
									}
									break;
								}
							}
						}
						finally
						{
							if (num2 < 0)
							{
								((IDisposable)enumerator2/*cast due to constrained. prefix*/).Dispose();
							}
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cproperties_003E5__2 = null;
						_003CpropertyLookup_003E5__3 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					num = 7;
					if (0 == 0)
					{
						continue;
					}
					return;
				case 8:
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
		internal static bool mVTTwGKehOPCMcC28x5f(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void SZF2LtKete6YX1UDK4QQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ii8jnsKezeAJfBi5gWc7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object u66JXoKOLBXptUdAs3ja(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation Ua6q4rKOKWWRs98Ik3wE(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyLinks)P_0).GetSourceCellLocation((CvsCellCollection)P_1, (string)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void dFFO66KO5OxAg4r0HO3s(object P_0, object P_1, bool P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CellViewModel)P_0).SuRwaP9gGT((CellViewModel)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KBaDLEKe1EkN5ORCgUmS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BMX5HRKeuxajP2JeuPJG()
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
	private struct _003CParseSheet_003Ed__137 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsInSight insight;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		public Func<Guid, CvsCellCollection, CvsCellRange, Task> handleMatch;

		private CvsCellCollection _003Ccells_003E5__2;

		private List<Guid> _003CusedGuids_003E5__3;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		private IEnumerator<(Guid guid, CvsCellRange range)> _003C_003E7__wrap3;

		private TaskAwaiter _003C_003Eu__2;

		private List<(Guid guid, CvsCellRange range)>.Enumerator _003C_003E7__wrap4;

		private Guid _003Cguid_003E5__6;

		private TaskAwaiter<object> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0608;
			IL_001a:
			int num2 = _003C_003E1__state;
			_ = 1;
			num = (D7RFCcKOJmJqnhMKbSJL() ? 5 : 4);
			goto IL_0608;
			IL_0608:
			TaskAwaiter awaiter2 = default;
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			(Guid, CvsCellRange) current = default;
			TaskAwaiter<object> awaiter3 = default;
			CvsCellRange cvsCellRange = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (D7RFCcKOJmJqnhMKbSJL())
					{
					}
					continue;
				case 0:
					try
					{
						if ((uint)num2 <= 3u || (insight != null && zJxks8KOas4W5i4PGmKg(insight) != CvsInSightState.NotConnected))
						{
							try
							{
								TaskAwaiter<CvsCellCollection> awaiter;
								CvsCellCollection result;
								switch (num2)
								{
								default:
									awaiter = ((CvsCogSocketSheet)gfJxS8KOehJtwPZ4iwbs(insight.CogSocket)).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 0);
										_003C_003Eu__1 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									goto IL_00f6;
								case 0:
									awaiter = _003C_003Eu__1;
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_00f6;
								case 1:
									try
									{
										int num3;
										if (num2 != 1)
										{
											num3 = 9;
										}
										else
										{
											awaiter2 = _003C_003Eu__2;
											num3 = 7;
										}
										while (true)
										{
											switch (num3)
											{
											case 8:
												num2 = (_003C_003E1__state = 1);
												goto case 5;
											default:
												num3 = 5;
												continue;
											case 5:
												_003C_003Eu__2 = awaiter2;
												num3 = 4;
												continue;
											case 1:
											case 11:
												if (easyBuilderApplicationViewModel.R3THMSc9R(current.Item1))
												{
													goto case 2;
												}
												awaiter2 = wwwPAIKOI8uiP6obkrma(easyBuilderApplicationViewModel.rn5O0mxIL(current.Item1, _003Ccells_003E5__2, current.Item2, handleMatch));
												if (!awaiter2.IsCompleted)
												{
													num3 = 8;
													continue;
												}
												goto case 0;
											case 7:
												_003C_003Eu__2 = default;
												num2 = (_003C_003E1__state = -1);
												num3 = 0;
												if (B4MhW3KOwcSemntSSaQg())
												{
													continue;
												}
												goto case 4;
											case 4:
												_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
												num3 = 3;
												continue;
											case 2:
											case 10:
												easyBuilderApplicationViewModel.CommIoSnippets.Add(current);
												num3 = 6;
												if (true)
												{
													continue;
												}
												break;
											case 3:
												return;
											case 0:
												awaiter2.GetResult();
												num3 = 12;
												if (D7RFCcKOJmJqnhMKbSJL())
												{
												}
												continue;
											case 6:
											case 9:
											case 12:
												break;
											}
											if (!HHogUBKODl5tNPWq2PAX(_003C_003E7__wrap3))
											{
												break;
											}
											current = _003C_003E7__wrap3.Current;
											D7RFCcKOJmJqnhMKbSJL();
											if (!B4MhW3KOwcSemntSSaQg())
											{
												num3 = 10;
												if (D7RFCcKOJmJqnhMKbSJL())
												{
												}
											}
											else
											{
												num3 = 11;
											}
										}
									}
									finally
									{
										if (num2 < 0 && _003C_003E7__wrap3 != null)
										{
											KYSwp9KOiRXbcpaUtMbt(_003C_003E7__wrap3);
										}
									}
									_003C_003E7__wrap3 = null;
									_003CusedGuids_003E5__3 = new List<Guid>();
									_003C_003E7__wrap4 = easyBuilderApplicationViewModel.CommIoSnippets.GetEnumerator();
									break;
								case 2:
								case 3:
									break;
									IL_00f6:
									result = awaiter.GetResult();
									_003Ccells_003E5__2 = result;
									wpKKOYKOOq06Rwsoo0uY(easyBuilderApplicationViewModel.CommIoSnippets);
									if (_003Ccells_003E5__2 != null)
									{
										_003C_003E7__wrap3 = GetSnippetsFromCells(_003Ccells_003E5__2).GetEnumerator();
										goto case 1;
									}
									goto end_IL_0079;
								}
								try
								{
									if (num2 == 2)
									{
										goto IL_037e;
									}
									if (num2 != 3)
									{
										goto IL_0567;
									}
									awaiter2 = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_0543;
									IL_037e:
									try
									{
										int num4;
										if (num2 != 2)
										{
											B4MhW3KOwcSemntSSaQg();
											num4 = (D7RFCcKOJmJqnhMKbSJL() ? 1 : 9);
										}
										else
										{
											awaiter3 = _003C_003Eu__3;
											num4 = 8;
										}
										while (true)
										{
											switch (num4)
											{
											case 7:
												num2 = (_003C_003E1__state = -1);
												num4 = 10;
												continue;
											case 6:
												return;
											case 8:
												_003C_003Eu__3 = default;
												num4 = 7;
												continue;
											case 0:
											case 9:
												awaiter3 = ((CvsCogSocket)vi2w7wKOnQE37MUhdQi0(easyBuilderApplicationViewModel.InSight)).Sheet.ClearCellsAsync(cvsCellRange).GetAwaiter();
												num4 = 5;
												continue;
											case 4:
												_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
												num4 = 6;
												if (!D7RFCcKOJmJqnhMKbSJL())
												{
													continue;
												}
												goto case 5;
											case 5:
												if (!awaiter3.IsCompleted)
												{
													num4 = 2;
													continue;
												}
												break;
											case 2:
												num2 = (_003C_003E1__state = 2);
												goto case 1;
											case 1:
											case 3:
												_003C_003Eu__3 = awaiter3;
												goto case 4;
											default:
												num4 = 4;
												if (!D7RFCcKOJmJqnhMKbSJL())
												{
													continue;
												}
												break;
											case 10:
												break;
											}
											break;
										}
										awaiter3.GetResult();
									}
									catch (Exception ex)
									{
										bmDYf8KOV3Spdk7uBYw2(Logger, LogLevel.Error, Resources.DyaneBpxJ1(), ex);
									}
									goto IL_055b;
									IL_0543:
									awaiter2.GetResult();
									_003CusedGuids_003E5__3.Add(_003Cguid_003E5__6);
									goto IL_055b;
									IL_0567:
									if (_003C_003E7__wrap4.MoveNext())
									{
										(_003Cguid_003E5__6, cvsCellRange) = _003C_003E7__wrap4.Current;
										if (_003CusedGuids_003E5__3.Contains(_003Cguid_003E5__6))
										{
											goto IL_037e;
										}
										awaiter2 = easyBuilderApplicationViewModel.rn5O0mxIL(_003Cguid_003E5__6, _003Ccells_003E5__2, cvsCellRange, handleMatch).GetAwaiter();
										if (!awaiter2.IsCompleted)
										{
											num2 = (_003C_003E1__state = 3);
											_003C_003Eu__2 = awaiter2;
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
											return;
										}
										goto IL_0543;
									}
									goto end_IL_0331;
									IL_055b:
									_003Cguid_003E5__6 = default;
									goto IL_0567;
									end_IL_0331:;
								}
								finally
								{
									if (num2 < 0)
									{
										((IDisposable)_003C_003E7__wrap4/*cast due to constrained. prefix*/).Dispose();
									}
								}
								_003C_003E7__wrap4 = default;
								_003Ccells_003E5__2 = null;
								_003CusedGuids_003E5__3 = null;
								end_IL_0079:;
							}
							catch (Exception ex2)
							{
								Logger.LogException(LogLevel.Error, Resources.oHXrSl3GVC(), ex2);
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
					goto default;
				case 1:
				case 4:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					num = 0;
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
		internal static CvsInSightState zJxks8KOas4W5i4PGmKg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).State;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gfJxS8KOehJtwPZ4iwbs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void wpKKOYKOOq06Rwsoo0uY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((List<(Guid, CvsCellRange)>)P_0).Clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter wwwPAIKOI8uiP6obkrma(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HHogUBKODl5tNPWq2PAX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void KYSwp9KOiRXbcpaUtMbt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vi2w7wKOnQE37MUhdQi0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void bmDYf8KOV3Spdk7uBYw2(object P_0, LogLevel P_1, object P_2, object P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).LogException(P_1, (string)P_2, (Exception)P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool B4MhW3KOwcSemntSSaQg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool D7RFCcKOJmJqnhMKbSJL()
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
	private struct _003CTryHandleMatch_003Ed__138 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Func<Guid, CvsCellCollection, CvsCellRange, Task> handleMatch;

		public Guid guid;

		public CvsCellCollection cells;

		public CvsCellRange range;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

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
			if (RTtKkjKOf7mI7IY8tqgo())
			{
				num = 2;
			}
			else
			{
				num = 3;
				if (false)
				{
					goto IL_0063;
				}
			}
			goto IL_0216;
			IL_0035:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0216;
			IL_0063:
			int num2 = default;
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					int num3;
					if (num2 != 0)
					{
						awaiter = TWFFMdKOlhgf2EJXJUEm(handleMatch(guid, cells, range));
						_ = 0;
						if (RTtKkjKOf7mI7IY8tqgo())
						{
							num3 = 8;
							if (!RTtKkjKOf7mI7IY8tqgo())
							{
								goto IL_00ab;
							}
						}
						else
						{
							num3 = 4;
							if (!RTtKkjKOf7mI7IY8tqgo())
							{
								goto IL_0107;
							}
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						num3 = 6;
					}
					goto IL_0127;
					IL_00ab:
					_003C_003Eu__1 = awaiter;
					num3 = 1;
					goto IL_0127;
					IL_0127:
					while (true)
					{
						switch (num3)
						{
						case 2:
						case 4:
							break;
						case 6:
							_003C_003Eu__1 = default;
							num3 = 5;
							continue;
						case 0:
						case 8:
							if (!awaiter.IsCompleted)
							{
								num3 = 3;
								continue;
							}
							goto case 9;
						case 3:
							num2 = (_003C_003E1__state = 0);
							break;
						case 1:
							goto IL_0107;
						default:
							num3 = 7;
							continue;
						case 5:
							num2 = (_003C_003E1__state = -1);
							num3 = 9;
							continue;
						case 7:
							return;
						case 9:
							awaiter.GetResult();
							goto end_IL_0066;
						}
						break;
					}
					goto IL_00ab;
					IL_0107:
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
					end_IL_0066:;
				}
				catch (Exception ex)
				{
					string text = (string)IDfO5DKOs5t55PQ4kBBu(ln1SsNKOgcxepTtC8XDY(), guid, range);
					DWc6uwKOvemIk1K8Zxvo(Logger, LogLevel.Error, text, ex);
					((IdeMessageBannerViewModel)by2QXcKOrWvMV3o3uZyB(easyBuilderApplicationViewModel)).Messages.Add(text);
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0035;
			IL_0216:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					num = 5;
					continue;
				case 4:
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 5:
					goto IL_0063;
				default:
					num = 4;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0035;
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
		internal static TaskAwaiter TWFFMdKOlhgf2EJXJUEm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ln1SsNKOgcxepTtC8XDY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.CGErM9DEDy();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IDfO5DKOs5t55PQ4kBBu(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void DWc6uwKOvemIk1K8Zxvo(object P_0, LogLevel P_1, object P_2, object P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).LogException(P_1, (string)P_2, (Exception)P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object by2QXcKOrWvMV3o3uZyB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BaseIdeViewModel)P_0).MessageBanner;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RTtKkjKOf7mI7IY8tqgo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool r8UVlqKOdEHTroSOV4w2()
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
	private struct _003CHandleInspSnippetMatch_003Ed__141 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		public Guid guid;

		public CvsCellCollection cells;

		public CvsCellRange range;

		private TaskAwaiter _003C_003Eu__1;

		private IEnumerator<ISnippetOwner> _003C_003E7__wrap1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ydjkxKKOZsc2PsoKE3g4();
			int num = (jZl93qKOPOoe8Vc4tU7N() ? 1 : 2);
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			TaskAwaiter awaiter = default;
			int num2 = default;
			ISnippetOwner current = default;
			do
			{
				IL_02e5:
				switch (num)
				{
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 5;
					if (true)
					{
						goto IL_02e5;
					}
					goto case 5;
				case 5:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					num = 4;
					goto IL_02e5;
				case 4:
					try
					{
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00d4;
						}
						if (num2 != 1)
						{
							if (easyBuilderApplicationViewModel.Supports(guid))
							{
								awaiter = V6i58CKOB8w6c1q7sBRs(((ISnippetOwner)easyBuilderApplicationViewModel).AddSnippet(guid, cells, range, SnippetAddedEventType.Located));
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_00d4;
							}
							_003C_003E7__wrap1 = easyBuilderApplicationViewModel.Steps.OfType<ISnippetOwner>().GetEnumerator();
						}
						try
						{
							int num3;
							if (num2 != 1)
							{
								num3 = 5;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num3 = 0;
							}
							while (true)
							{
								switch (num3)
								{
								case 4:
									awaiter.GetResult();
									num3 = 12;
									break;
								case 1:
								case 11:
									if (current.Supports(guid))
									{
										num3 = 10;
										if (false)
										{
											return;
										}
										break;
									}
									goto case 5;
								case 8:
									return;
								case 3:
									num2 = (_003C_003E1__state = 1);
									goto case 9;
								default:
									num3 = 9;
									if (true)
									{
										break;
									}
									goto case 0;
								case 0:
									num2 = (_003C_003E1__state = -1);
									num3 = 4;
									if (jZl93qKOPOoe8Vc4tU7N())
									{
										break;
									}
									goto case 9;
								case 9:
									_003C_003Eu__1 = awaiter;
									goto case 2;
								case 10:
									awaiter = V6i58CKOB8w6c1q7sBRs(current.AddSnippet(guid, cells, range));
									num3 = 7;
									break;
								case 2:
								case 6:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 8;
									break;
								case 7:
									if (!awaiter.IsCompleted)
									{
										num3 = 3;
										break;
									}
									goto case 4;
								case 5:
								case 12:
									if (nEv80OKObAuO3hqQJfJH(_003C_003E7__wrap1))
									{
										current = _003C_003E7__wrap1.Current;
										jZl93qKOPOoe8Vc4tU7N();
										if (!ydjkxKKOZsc2PsoKE3g4())
										{
											num3 = 11;
											if (!ydjkxKKOZsc2PsoKE3g4())
											{
												break;
											}
											goto case 4;
										}
										num3 = 2;
										break;
									}
									goto end_IL_01a4;
								}
								continue;
								end_IL_01a4:
								break;
							}
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								jncPyBKOG1TicT7edk6Y(_003C_003E7__wrap1);
							}
						}
						_003C_003E7__wrap1 = null;
						goto end_IL_004c;
						IL_00d4:
						awaiter.GetResult();
						end_IL_004c:;
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
			while (true);
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
		internal static TaskAwaiter V6i58CKOB8w6c1q7sBRs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nEv80OKObAuO3hqQJfJH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jncPyBKOG1TicT7edk6Y(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jZl93qKOPOoe8Vc4tU7N()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ydjkxKKOZsc2PsoKE3g4()
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
	private struct _003CHandleAcqSnippetMatch_003Ed__142 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		public Guid guid;

		public CvsCellCollection cells;

		public CvsCellRange range;

		private IEnumerator<AppStepViewModel> _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fAq8BTKOSbqFsu626m63();
			int num;
			if (Ok4bn2KOobY5f9R5JMFa())
			{
				num = 2;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
				if (fAq8BTKOSbqFsu626m63())
				{
				}
			}
			goto IL_0277;
			IL_002a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0277;
			IL_0277:
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			IAcqInSightAppStep acqInSightAppStep = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 1:
				case 5:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					num = 4;
					if (true)
					{
						continue;
					}
					goto case 4;
				case 4:
					try
					{
						if (num2 != 0)
						{
							_003C_003E7__wrap1 = easyBuilderApplicationViewModel.Steps.GetEnumerator();
						}
						try
						{
							if (num2 != 0)
							{
								goto IL_0202;
							}
							awaiter = _003C_003Eu__1;
							int num3 = 7;
							goto IL_0139;
							IL_0139:
							while (true)
							{
								switch (num3)
								{
								case 1:
									if (acqInSightAppStep != null)
									{
										num3 = 10;
										continue;
									}
									break;
								case 4:
									num2 = (_003C_003E1__state = -1);
									num3 = 11;
									if (Ok4bn2KOobY5f9R5JMFa())
									{
										continue;
									}
									goto case 10;
								case 10:
									if (!HSjqN5KOkKkSsAEUJc5s(acqInSightAppStep, guid))
									{
										break;
									}
									Ok4bn2KOobY5f9R5JMFa();
									if (!fAq8BTKOSbqFsu626m63())
									{
										num3 = 8;
										if (!Ok4bn2KOobY5f9R5JMFa())
										{
											return;
										}
									}
									else
									{
										num3 = 6;
									}
									continue;
								case 0:
									return;
								case 7:
									_003C_003Eu__1 = default;
									num3 = 4;
									continue;
								case 3:
									_003C_003Eu__1 = awaiter;
									goto default;
								case 9:
									num2 = (_003C_003E1__state = 0);
									num3 = 3;
									if (fAq8BTKOSbqFsu626m63())
									{
									}
									continue;
								case 2:
								case 8:
									awaiter = acqInSightAppStep.AddSnippet(guid, cells, range).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num3 = 9;
										if (Ok4bn2KOobY5f9R5JMFa())
										{
											continue;
										}
										goto default;
									}
									goto case 11;
								default:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 0;
									continue;
								case 11:
									awaiter.GetResult();
									num3 = 12;
									continue;
								case 12:
									break;
								}
								break;
							}
							goto IL_0202;
							IL_0202:
							if (jJ2dHDKO8mb5W0C3lMN3(_003C_003E7__wrap1))
							{
								acqInSightAppStep = _003C_003E7__wrap1.Current as IAcqInSightAppStep;
								num3 = 1;
								if (fAq8BTKOSbqFsu626m63())
								{
								}
								goto IL_0139;
							}
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								HXdUjaKOqxdAQp37ZQxp(_003C_003E7__wrap1);
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
					break;
				default:
					num = 3;
					if (true)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
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
		internal static bool HSjqN5KOkKkSsAEUJc5s(object P_0, Guid guid)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IAcqInSightAppStep)P_0).Supports(guid);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jJ2dHDKO8mb5W0C3lMN3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void HXdUjaKOqxdAQp37ZQxp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ok4bn2KOobY5f9R5JMFa()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fAq8BTKOSbqFsu626m63()
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
	private struct _003CGetSnippetLocation_003Ed__143 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCellRange> _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		public CvsCellRange range;

		public bool right;

		private TaskAwaiter<CvsCellRange> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			int num2 = default;
			CvsCellRange result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					ejru3kKOp0docLi2AQ7v();
					if (eWoQLAKOEkAgwdrgPS2c())
					{
						num = 1;
						continue;
					}
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto case 5;
				case 1:
				case 2:
					try
					{
						TaskAwaiter<CvsCellRange> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = GetSnippetLocationFromCells((CvsCellCollection)FrlP9EKO9VjJy7j4iyc2(Itv4hOKOXTNILuIrQkN4(easyBuilderApplicationViewModel.InSight)), range, right, easyBuilderApplicationViewModel.sHu1r1vdB).GetAwaiter();
							_ = 0;
							if (eWoQLAKOEkAgwdrgPS2c())
							{
								num3 = 7;
							}
							else
							{
								num3 = 2;
								if (!eWoQLAKOEkAgwdrgPS2c())
								{
									goto IL_009f;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
							if (!eWoQLAKOEkAgwdrgPS2c())
							{
								goto IL_00ea;
							}
						}
						goto IL_011f;
						IL_00ff:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						IL_009f:
						num2 = (_003C_003E1__state = 0);
						num3 = 6;
						if (ejru3kKOp0docLi2AQ7v())
						{
							goto IL_00b8;
						}
						goto IL_011f;
						IL_00ea:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						if (1 == 0)
						{
							goto IL_00ff;
						}
						goto IL_011f;
						IL_00b8:
						if (!awaiter.IsCompleted)
						{
							num3 = 4;
							goto IL_011f;
						}
						goto IL_016c;
						IL_011f:
						while (true)
						{
							switch (num3)
							{
							case 6:
								_003C_003Eu__1 = awaiter;
								goto IL_00ff;
							case 4:
								break;
							case 0:
							case 7:
								goto IL_00b8;
							case 5:
								return;
							case 8:
								goto IL_00ea;
							case 2:
							case 3:
								goto IL_00ff;
							default:
								num3 = 5;
								continue;
							case 1:
								_003C_003Eu__1 = default;
								num3 = 8;
								continue;
							case 9:
								goto IL_016c;
							}
							break;
						}
						goto IL_009f;
						IL_016c:
						result = awaiter.GetResult();
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
		internal static object Itv4hOKOXTNILuIrQkN4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FrlP9EKO9VjJy7j4iyc2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eWoQLAKOEkAgwdrgPS2c()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ejru3kKOp0docLi2AQ7v()
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
	private struct _003CGetSnippetLocation_003Ed__144 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCellRange> _003C_003Et__builder;

		public CvsCellCollection cells;

		public CvsCellRange range;

		public bool right;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		private TaskAwaiter<CvsCellRange> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			MbWni1KO73ujqIPsj8jD();
			int num = ((!tH7cI4KO4kPPBkXUjcc2()) ? 4 : 2);
			CvsCellRange result = default;
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (true)
					{
						break;
					}
					goto case 1;
				case 1:
				case 4:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					num = 5;
					if (!MbWni1KO73ujqIPsj8jD())
					{
						break;
					}
					goto case 5;
				case 5:
					try
					{
						TaskAwaiter<CvsCellRange> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = GetSnippetLocationFromCells(cells, range, right, easyBuilderApplicationViewModel.sHu1r1vdB).GetAwaiter();
							num3 = 5;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 3:
								return;
							case 5:
								if (!awaiter.IsCompleted)
								{
									MbWni1KO73ujqIPsj8jD();
									if (tH7cI4KO4kPPBkXUjcc2())
									{
										num3 = 7;
										continue;
									}
									num3 = 2;
									if (0 == 0)
									{
										continue;
									}
								}
								break;
							case 2:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 3;
								continue;
							case 4:
								_003C_003Eu__1 = default;
								goto case 2;
							case 9:
								break;
							}
							break;
						}
						result = awaiter.GetResult();
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
				case 2:
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
		internal static bool tH7cI4KO4kPPBkXUjcc2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MbWni1KO73ujqIPsj8jD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass153_0
	{
		public EasyBuilderApplicationViewModel _003C_003E4__this;

		public object param;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass153_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			QT7iB4KO6h04yMCbG2Zk(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task _003COnEditTool_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003E4__this.V4tvIWmgN(param as EzTool);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void QT7iB4KO6h04yMCbG2Zk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xGFJDPKO3QOfVXgu48Ax()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BnG24iKOjZYEhXHGcHy4()
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
	private struct _003COnEditToolAsync_003Ed__154 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		public EzTool tool;

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
			TaskAwaiter awaiter = default;
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
							goto IL_00d6;
						}
						if (easyBuilderApplicationViewModel.ActiveStep != easyBuilderApplicationViewModel.Inspect)
						{
							num3 = 4;
							goto IL_00d6;
						}
						goto end_IL_0018;
						IL_00d6:
						while (true)
						{
							switch (num3)
							{
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 9;
								continue;
							case 2:
								_003C_003Eu__1 = default;
								goto case 7;
							case 7:
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								continue;
							case 4:
								easyBuilderApplicationViewModel.ActiveStep = easyBuilderApplicationViewModel.Inspect;
								num3 = 10;
								continue;
							case 3:
								return;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								break;
							case 9:
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								_ = 1;
								num3 = ((!Fe52BGKOAUpE9oiDBhmT()) ? 6 : 7);
								continue;
							case 5:
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								continue;
							case 10:
								if (tool != null)
								{
									awaiter = l3iCgsKORA2pq9XNgFW8(easyBuilderApplicationViewModel.Inspect.SetCurrentSnippet(tool));
									num3 = 0;
									continue;
								}
								goto end_IL_00d6;
							case 11:
								break;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_00d6:
							break;
						}
						end_IL_0018:;
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
				case 0:
					num2 = _003C_003E1__state;
					Fe52BGKOAUpE9oiDBhmT();
					if (G4jdIPKOCq8g6j03wLu7())
					{
						num = 4;
						if (Fe52BGKOAUpE9oiDBhmT())
						{
						}
					}
					else
					{
						num = 3;
					}
					break;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (Fe52BGKOAUpE9oiDBhmT())
					{
					}
					break;
				case 1:
				case 4:
					easyBuilderApplicationViewModel = _003C_003E4__this;
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
		internal static TaskAwaiter l3iCgsKORA2pq9XNgFW8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool G4jdIPKOCq8g6j03wLu7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Fe52BGKOAUpE9oiDBhmT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass155_0
	{
		public EasyBuilderApplicationViewModel _003C_003E4__this;

		public CvsCellCollection cells;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass155_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Vb0hPgKOyDIZpu1BkDwN();
			X8TMbGKO0HjYMJvgAB6C(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SnippetUpdateViewModel _003CCheckIfJobNeedsUpdate_003Eb__0(ISnippetOwner s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new SnippetUpdateViewModel(s, _003C_003E4__this.OperationProgressManager);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Vb0hPgKOyDIZpu1BkDwN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void X8TMbGKO0HjYMJvgAB6C(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool J1qPDtKOW2nrG0AXgiaN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HnLXkWKOTRLr0Qr5YBVs()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass156_0
	{
		public Guid guid;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass156_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xDkTrPKOmoR5q1TdD53Y();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CSupports_003Eb__0(EzSupportSnippetType s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<Guid>)WROqZVKOQ3xQtc02sV1m(s)).Contains(guid);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void xDkTrPKOmoR5q1TdD53Y()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bgiKKkKOHhwTHsgSj0ZK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MYUevoKOx4yosAGGpeID()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WROqZVKOQ3xQtc02sV1m(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).Guids;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddSnippet_003Ed__157 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		public Guid guid;

		public CvsCellCollection cells;

		public CvsCellRange snippetRange;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			BgiBMIKONQ57rIwo54KT();
			int num;
			if (!y6bQUGKO2rOWtfIePHqY())
			{
				num = 3;
				if (!BgiBMIKONQ57rIwo54KT())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_01c2;
			IL_002e:
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = _003C_003E4__this;
			num = 5;
			goto IL_01c2;
			IL_01c2:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					break;
				case 2:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					break;
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = FpvkgoKOcM3eC7lrfbHO(((ISnippetOwner)easyBuilderApplicationViewModel).AddSnippet(guid, cells, snippetRange, SnippetAddedEventType.Located));
							num3 = 8;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
						}
						while (true)
						{
							switch (num3)
							{
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								break;
							case 4:
								_003C_003Eu__1 = default;
								goto case 6;
							case 0:
								do
								{
									_003C_003Eu__1 = awaiter;
									_ = 1;
									if (y6bQUGKO2rOWtfIePHqY())
									{
										num3 = 7;
										continue;
									}
									num3 = 1;
									break;
								}
								while (false);
								continue;
							case 2:
								return;
							case 6:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 5;
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								continue;
							case 1:
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 2;
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
					goto case 2;
				default:
					num = 2;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_002e;
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
		internal static TaskAwaiter FpvkgoKOcM3eC7lrfbHO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BgiBMIKONQ57rIwo54KT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool y6bQUGKO2rOWtfIePHqY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass158_0
	{
		public Guid guid;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass158_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			i4l7YEKOhIW0N1d0NbY4();
			yJ28evKOtJAVLDagqwM0(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002EAddSnippet_003Eb__0(EzSupportSnippetType s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return s.Guids.Contains(guid);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void i4l7YEKOhIW0N1d0NbY4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yJ28evKOtJAVLDagqwM0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LG2oE6KO1JTi6d2HiH4f()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JXBOc9KOu8PA8KWbTiaC()
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
	private struct _003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetOwner_002DAddSnippet_003Ed__158 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Guid guid;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange snippetRange;

		public SnippetAddedEventType action;

		private TaskAwaiter<EzSupportSnippet> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!GmDeKsKILvRLTBca6fVj())
			{
				num = 4;
			}
			else
			{
				num = 2;
				if (1 == 0)
				{
					goto IL_0363;
				}
			}
			goto IL_0319;
			IL_0319:
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<EzSupportSnippet> awaiter2 = default;
			EzSupportSnippet result = default;
			_003C_003Ec__DisplayClass158_0 obj = default;
			EzSnippet ezSnippet = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					num = 3;
					continue;
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 9;
								if (1 == 0)
								{
									goto IL_004e;
								}
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 15;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 19;
						}
						goto IL_010e;
						IL_010e:
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 10:
								break;
							case 14:
								goto IL_006b;
							case 19:
								goto IL_0083;
							case 8:
								return;
							case 16:
								if (!awaiter.IsCompleted)
								{
									num3 = 17;
									continue;
								}
								goto case 20;
							case 17:
								num2 = (_003C_003E1__state = 1);
								num3 = 14;
								if (true)
								{
									continue;
								}
								goto case 7;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 8;
								continue;
							case 2:
								result = awaiter2.GetResult();
								goto case 12;
							default:
								num3 = 12;
								continue;
							case 18:
								num2 = (_003C_003E1__state = -1);
								num3 = 20;
								continue;
							case 9:
								obj = new _003C_003Ec__DisplayClass158_0();
								B5WaF7KOzDkNZnxeuS0m();
								if (!GmDeKsKILvRLTBca6fVj())
								{
									num3 = 11;
									if (true)
									{
										continue;
									}
									goto case 15;
								}
								num3 = 3;
								continue;
							case 15:
								_003C_003Eu__2 = default;
								num3 = 18;
								if (true)
								{
									continue;
								}
								goto case 13;
							case 13:
							{
								EzSupportSnippetType ezSupportSnippetType = easyBuilderApplicationViewModel.nQR5aKbwQR.FirstOrDefault(obj._003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002EAddSnippet_003Eb__0);
								ezSnippet = null;
								if (ezSupportSnippetType is PropertyLinksType)
								{
									num3 = 6;
									continue;
								}
								goto IL_0055;
							}
							case 1:
							case 11:
								obj.guid = guid;
								num3 = 13;
								continue;
							case 4:
								awaiter = easyBuilderApplicationViewModel.nRV3NFP7G(easyBuilderApplicationViewModel, new SnippetAddedEventArgs(ezSnippet, action)).GetAwaiter();
								num3 = 16;
								if (!GmDeKsKILvRLTBca6fVj())
								{
									continue;
								}
								goto case 0;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 2;
								if (0 == 0)
								{
									continue;
								}
								goto case 6;
							case 6:
								awaiter2 = easyBuilderApplicationViewModel.nQR5aKbwQR.OfType<PropertyLinksType>().First().CreateSupportSnippet(obj.guid, cells, snippetRange)
									.GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter2;
									num3 = 7;
									continue;
								}
								goto case 2;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 12:
								easyBuilderApplicationViewModel.PropertyLinks = result as PropertyLinks;
								break;
							case 20:
								awaiter.GetResult();
								goto end_IL_0035;
							}
							break;
						}
						goto IL_004e;
						IL_0055:
						if (ezSnippet != null)
						{
							num3 = 4;
							if (GmDeKsKILvRLTBca6fVj())
							{
								goto IL_006b;
							}
							goto IL_010e;
						}
						goto end_IL_0035;
						IL_0083:
						_003C_003Eu__1 = default;
						num3 = 0;
						goto IL_010e;
						IL_006b:
						_003C_003Eu__2 = awaiter;
						num3 = 5;
						if (!B5WaF7KOzDkNZnxeuS0m())
						{
							goto IL_0083;
						}
						goto IL_010e;
						IL_004e:
						ezSnippet = easyBuilderApplicationViewModel.PropertyLinks;
						goto IL_0055;
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
					num = 5;
					if (B5WaF7KOzDkNZnxeuS0m())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 5:
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_0363;
			IL_0363:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (!B5WaF7KOzDkNZnxeuS0m())
			{
				return;
			}
			goto IL_0319;
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
		internal static bool B5WaF7KOzDkNZnxeuS0m()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GmDeKsKILvRLTBca6fVj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass159_0
	{
		public Guid guid;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass159_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			jitqmJKIwxtAusFEAyeI(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002EUpdateSnippet_003Eb__0(EzSupportSnippetType s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<Guid>)NCHKGAKIJKbC7BXcH29u(s)).Contains(guid);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jitqmJKIwxtAusFEAyeI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yx6ai7KIKhBSuCl4iwI7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ShjpFGKI5I5JN8PNvMmY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object NCHKGAKIJKbC7BXcH29u(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).Guids;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetOwner_002DUpdateSnippet_003Ed__159 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Guid guid;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		public CvsCellRange snippetRange;

		public CvsCellCollection cells;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			B7cs5JKIai0nRKrQMAtd();
			int num = (WiMNWtKIeU4xOJpvkg2O() ? 5 : 4);
			int num2 = default;
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			_003C_003Ec__DisplayClass159_0 obj = default;
			TaskAwaiter awaiter = default;
			EzSupportSnippetType ezSupportSnippetType = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 3;
					break;
				case 3:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					goto case 2;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							obj = new _003C_003Ec__DisplayClass159_0();
							num3 = 0;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
							if (1 == 0)
							{
								goto IL_0120;
							}
						}
						goto IL_013b;
						IL_00d3:
						_003C_003Eu__1 = awaiter;
						num3 = 7;
						goto IL_013b;
						IL_0120:
						num2 = (_003C_003E1__state = 0);
						goto IL_00d3;
						IL_013b:
						while (true)
						{
							switch (num3)
							{
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								continue;
							case 3:
							case 9:
								awaiter = kCFjtAKIOoTAnsEh7BPk(ezSupportSnippetType.UpdateSnippet(snippetRange, cells));
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								goto case 12;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 8;
								continue;
							case 11:
								ezSupportSnippetType = easyBuilderApplicationViewModel.nQR5aKbwQR.FirstOrDefault(obj._003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002EUpdateSnippet_003Eb__0);
								num3 = 10;
								continue;
							case 6:
								return;
							case 1:
								goto IL_0120;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								if (!WiMNWtKIeU4xOJpvkg2O())
								{
									continue;
								}
								goto case 0;
							case 0:
								obj.guid = guid;
								num3 = 11;
								continue;
							case 10:
								goto IL_01b8;
							case 12:
								awaiter.GetResult();
								goto end_IL_0065;
							}
							break;
							IL_01b8:
							if (ezSupportSnippetType != null)
							{
								_ = 1;
								num3 = ((!WiMNWtKIeU4xOJpvkg2O()) ? 9 : 4);
								continue;
							}
							goto end_IL_0065;
						}
						goto IL_00d3;
						end_IL_0065:;
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
		internal static TaskAwaiter kCFjtAKIOoTAnsEh7BPk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool B7cs5JKIai0nRKrQMAtd()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WiMNWtKIeU4xOJpvkg2O()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass160_0
	{
		public Guid guid;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass160_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			itMD95KIi16xsmEtp8jM();
			Fm9WdLKIn8ugT97pbwKU(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002ESnippetNeedsUpdate_003Eb__0(EzSupportSnippetType s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<Guid>)NsQb0nKIV1fLAefTolZA(s)).Contains(guid);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void itMD95KIi16xsmEtp8jM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Fm9WdLKIn8ugT97pbwKU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nVT3E2KIIc6mhsBm6dGl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sGQ0ynKIDyFt4OebSh4n()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object NsQb0nKIV1fLAefTolZA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).Guids;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDisposeAsyncCore_003Ed__173 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncValueTaskMethodBuilder _003C_003Et__builder;

		public EasyBuilderApplicationViewModel _003C_003E4__this;

		private IEnumerator<IAsyncDisposable> _003C_003E7__wrap1;

		private ValueTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (qbiH6iKIfh7bkO01RYHw())
			{
				num = 3;
				if (tbHmHgKIdQAZSEImp7NR())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
				if (false)
				{
					return;
				}
			}
			goto IL_0350;
			IL_038c:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0350;
			IL_0350:
			EasyBuilderApplicationViewModel easyBuilderApplicationViewModel = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				default:
					num = 4;
					continue;
				case 1:
				case 5:
					easyBuilderApplicationViewModel = _003C_003E4__this;
					num = 2;
					continue;
				case 4:
					goto IL_038c;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			try
			{
				ValueTaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					if (num2 == 1)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_02f1;
					}
					easyBuilderApplicationViewModel.ActiveStep = null;
					if (easyBuilderApplicationViewModel.Steps == null)
					{
						goto IL_020f;
					}
					_003C_003E7__wrap1 = easyBuilderApplicationViewModel.Steps.OfType<IAsyncDisposable>().GetEnumerator();
				}
				ValueTask valueTask = default;
				try
				{
					if (num2 != 0)
					{
						goto IL_018b;
					}
					awaiter = _003C_003Eu__1;
					goto IL_0120;
					IL_00c5:
					int num3;
					while (true)
					{
						switch (num3)
						{
						case 8:
							break;
						case 4:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						default:
							num3 = 6;
							if (true)
							{
								continue;
							}
							return;
						case 6:
							return;
						case 1:
						case 5:
							goto IL_0120;
						case 2:
							num2 = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							num3 = 4;
							continue;
						case 9:
							num2 = (_003C_003E1__state = -1);
							num3 = 8;
							continue;
						case 7:
							if (!awaiter.IsCompleted)
							{
								num3 = 2;
								continue;
							}
							break;
						case 0:
						case 3:
							awaiter = valueTask.GetAwaiter();
							num3 = 7;
							continue;
						case 10:
							goto IL_018b;
						}
						break;
					}
					goto IL_0094;
					IL_018b:
					if (mCyaUsKIgCPg4pIl8UCy(_003C_003E7__wrap1))
					{
						valueTask = a03PKmKIlWJyvM4ku8vL(_003C_003E7__wrap1.Current);
						_ = 0;
						if (qbiH6iKIfh7bkO01RYHw())
						{
							num3 = 3;
							if (false)
							{
								goto IL_0094;
							}
						}
						else
						{
							num3 = 1;
							if (1 == 0)
							{
								goto IL_0120;
							}
						}
						goto IL_00c5;
					}
					goto end_IL_0060;
					IL_0094:
					awaiter.GetResult();
					num3 = 10;
					goto IL_00c5;
					IL_0120:
					_003C_003Eu__1 = default;
					num3 = 9;
					goto IL_00c5;
					end_IL_0060:;
				}
				finally
				{
					if (num2 < 0 && _003C_003E7__wrap1 != null)
					{
						vqg5fcKIsLun9E9ZAlrb(_003C_003E7__wrap1);
					}
				}
				_003C_003E7__wrap1 = null;
				IEnumerator<IDisposable> enumerator = easyBuilderApplicationViewModel.Steps.OfType<IDisposable>().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						vqg5fcKIsLun9E9ZAlrb(enumerator.Current);
					}
				}
				finally
				{
					if (num2 < 0 && enumerator != null)
					{
						vqg5fcKIsLun9E9ZAlrb(enumerator);
					}
				}
				goto IL_020f;
				IL_020f:
				easyBuilderApplicationViewModel.DisplayStatusBar?.Dispose();
				if (easyBuilderApplicationViewModel.Filmstrip != null)
				{
					easyBuilderApplicationViewModel.Filmstrip.PropertyChanged -= easyBuilderApplicationViewModel.ENfcHuHQX;
					easyBuilderApplicationViewModel.Filmstrip.Dispose();
				}
				object obj = xt47hbKIvrXP8i4wPdsx(easyBuilderApplicationViewModel);
				if (((obj != null) ? lBvjVfKIrPOcSBXVP6PN(obj) : null) != null)
				{
					((IRuntimeModeService)zDEjoQKIP2s9ZAYsUAV5(easyBuilderApplicationViewModel.Runtime)).RuntimeModeChanged -= easyBuilderApplicationViewModel.i8vFnXAl5;
					ETEZD8KIZyHHKYqOQt9G(xt47hbKIvrXP8i4wPdsx(easyBuilderApplicationViewModel));
				}
				valueTask = easyBuilderApplicationViewModel.iU1PG0rZf();
				awaiter = valueTask.GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num2 = (_003C_003E1__state = 1);
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_02f1;
				IL_02f1:
				awaiter.GetResult();
				if (easyBuilderApplicationViewModel.duohQ2pLC != null)
				{
					CQh5ihKIB5niPBReOvwG(easyBuilderApplicationViewModel.duohQ2pLC);
					easyBuilderApplicationViewModel.duohQ2pLC = null;
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_038c;
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
		internal static ValueTask a03PKmKIlWJyvM4ku8vL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IAsyncDisposable)P_0).DisposeAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mCyaUsKIgCPg4pIl8UCy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vqg5fcKIsLun9E9ZAlrb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xt47hbKIvrXP8i4wPdsx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BaseIdeViewModel)P_0).Runtime;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lBvjVfKIrPOcSBXVP6PN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((RuntimeViewModel)P_0).RuntimeModeService;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zDEjoQKIP2s9ZAYsUAV5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((RuntimeViewModel)P_0).RuntimeModeService;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ETEZD8KIZyHHKYqOQt9G(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((RuntimeViewModel)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void CQh5ihKIB5niPBReOvwG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsInSight)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qbiH6iKIfh7bkO01RYHw()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tbHmHgKIdQAZSEImp7NR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass178_0
	{
		public string functionName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass178_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			aOhXv1KIo1QgkPi7XMPG();
			BunqtDKISYR1aaq1TstV(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CFindAcquired2DImageLocation_003Eb__1(string acqFunction)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return acqFunction.Equals(functionName, StringComparison.OrdinalIgnoreCase);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void aOhXv1KIo1QgkPi7XMPG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BunqtDKISYR1aaq1TstV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bDJ5OZKIbVMbBoMeVhkY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KC0rsHKIGUt09NmyJqWT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private IEnumerable<AppStepViewModel> JnUrIxu3L;

	private CvsInSight duohQ2pLC;

	protected static readonly ILogger Logger;

	private readonly CogNamerDevice HL08gGhGi;

	private readonly UserData HpNmEU0y2;

	private int sHu1r1vdB;

	private List<EzSnippet> P2rz3AUMr;

	private EzSupportSnippetType[] nQR5aKbwQR;

	[CompilerGenerated]
	private readonly IOperationProgressManager gly55phwHC;

	[CompilerGenerated]
	private EventHandler S875pBftxt;

	private CvsCogEasyBuilderConfig m0X5UFGqIW;

	[CompilerGenerated]
	private EasyBuilderLayout D0f57S3rak;

	private bool oSy5NBiiLU;

	private bool? VW45AQy5jG;

	[CompilerGenerated]
	private InspectStepViewModel DNd5dljFZA;

	[CompilerGenerated]
	private ReadOnlyObservableCollection<AppStepViewModel> FyD56R02Rp;

	[CompilerGenerated]
	private FilmstripPanelViewModel b7L5uwfVyI;

	[CompilerGenerated]
	private readonly DisplayStatusBarViewModel s2J5F9Wfru;

	private CvsInSightDisplay zNU5Xhjhyv;

	private AppStepViewModel tuC5o8i1EB;

	[CompilerGenerated]
	private EventHandler Owe5SwMqik;

	[CompilerGenerated]
	private readonly DelegateCommand oix5Dqcy8h;

	[CompilerGenerated]
	private readonly AsyncDelegateCommand HKK53ENqhR;

	private bool reA5IQnQ7s;

	[CompilerGenerated]
	private readonly AsyncDelegateCommand YC15fiM5j5;

	private PropertyLinks PPP5EC6gfL;

	[CompilerGenerated]
	private readonly List<(Guid guid, CvsCellRange range)> poZ5bbof96;

	[CompilerGenerated]
	private RelayCommand SC95cUG8jW;

	public const string Acquired2DImageCellName = "Acquired";

	private CvsCellLocation? lEm5QPUYrS;

	public IOperationProgressManager OperationProgressManager
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return gly55phwHC;
		}
	}

	bool IRuntimeModeConstraint.IsRunModeEnabled
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

	public CvsCellLocation JobPassCellLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xTwECWYK95pQ5F5UZK();
			int num;
			if (!nuRFE5UNWs9SuD3VRP())
			{
				num = 7;
				if (1 == 0)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 6;
			}
			goto IL_00b7;
			IL_0086:
			CvsCellLocation? cvsCellLocation2;
			CvsCellLocation? cvsCellLocation = cvsCellLocation2;
			if (!cvsCellLocation.HasValue)
			{
				num = 9;
				goto IL_00b7;
			}
			return cvsCellLocation.GetValueOrDefault();
			IL_007c:
			BoolViewModel pass;
			cvsCellLocation2 = pass.CellLocation;
			goto IL_0086;
			IL_0076:
			CvsCellLocation? cvsCellLocation3 = default;
			cvsCellLocation2 = cvsCellLocation3;
			goto IL_0086;
			IL_00b7:
			while (true)
			{
				JobPassFail jobPassFail;
				switch (num)
				{
				case 5:
					break;
				case 2:
					goto IL_0046;
				case 4:
					cvsCellLocation3 = null;
					num = 3;
					continue;
				case 3:
					goto IL_0076;
				case 8:
					cvsCellLocation3 = null;
					break;
				default:
					num = 5;
					continue;
				case 0:
				case 7:
				{
					InspectStepViewModel inspect = Inspect;
					if (inspect != null)
					{
						jobPassFail = inspect.JobPassFail;
						if (jobPassFail != null)
						{
							goto IL_0030;
						}
						num = 8;
						if (true)
						{
							continue;
						}
						goto case 4;
					}
					goto case 1;
				}
				case 1:
				case 6:
					cvsCellLocation3 = null;
					num = 2;
					continue;
				case 9:
					return CvsCellLocation.Invalid;
				}
				break;
				IL_0030:
				pass = jobPassFail.Pass;
				if (pass == null)
				{
					num = 4;
					continue;
				}
				goto IL_007c;
			}
			goto IL_002a;
			IL_0046:
			cvsCellLocation2 = cvsCellLocation3;
			goto IL_0086;
			IL_002a:
			cvsCellLocation2 = cvsCellLocation3;
			goto IL_0086;
		}
	}

	public CvsCogEasyBuilderConfig EasyBuilderConfig
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return m0X5UFGqIW;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			m0X5UFGqIW = value;
			UILayout = (EasyBuilderLayout)Nj8IOPQ4mm7p32m939(EasyBuilderConfig);
		}
	}

	public EasyBuilderLayout UILayout
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return D0f57S3rak;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			D0f57S3rak = value;
		}
	}

	public string CameraModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)nxtkHGclxSClgsWWcc(ySaPJY297twcJ9oO1q(S7Gtq7NPms6dAJsMb6(InSight)));
		}
	}

	public bool IsEzbEditable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return oSy5NBiiLU;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref oSy5NBiiLU, value, (string)bJsCnd1mxLKL6JRwLn(640)))
			{
				HnY0SMu2BGF5Yo5BUx(UpdateSnippetsToLatestRevisionCommand);
			}
		}
	}

	public bool? SnippetsNeedUpdates
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return VW45AQy5jG;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			MessageBanner.Messages.Remove(Resources.A79hn5foI0());
			VW45AQy5jG = value;
			if (VW45AQy5jG.HasValue && VW45AQy5jG.Value)
			{
				MessageBanner.Messages.Add(Resources.A79hn5foI0());
			}
			else
			{
				MessageBanner.Messages.Remove(Resources.A79hn5foI0());
			}
			UpdateSnippetsToLatestRevisionCommand.RaiseCanExecuteChanged();
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
			return DNd5dljFZA;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			DNd5dljFZA = value;
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
			return duohQ2pLC;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			nuRFE5UNWs9SuD3VRP();
			int num;
			if (xTwECWYK95pQ5F5UZK())
			{
				num = 4;
			}
			else
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_010f;
				}
			}
			goto IL_00b9;
			IL_00b9:
			while (true)
			{
				switch (num)
				{
				case 3:
				case 5:
					break;
				case 6:
					OvTCvYKV1SoVCS9AlKV(duohQ2pLC, HL08gGhGi, CdQUGaROfy7He9T0foW.KbIzwHEDLa(616), HpNmEU0y2);
					num = 2;
					continue;
				case 1:
					Display.InSight = duohQ2pLC;
					goto IL_00ec;
				default:
					num = 7;
					continue;
				case 7:
					goto IL_00ec;
				case 2:
					goto IL_010f;
				case 0:
				case 4:
					goto IL_012b;
				case 8:
					return;
				}
				break;
			}
			goto IL_0028;
			IL_00ec:
			IEnumerator<IInSightAppStep> enumerator = Steps.OfType<IInSightAppStep>().GetEnumerator();
			goto IL_0028;
			IL_0028:
			try
			{
				while (enumerator.MoveNext())
				{
					hG3XkNKfxc8Re3OWxBE(enumerator.Current, duohQ2pLC);
				}
			}
			finally
			{
				if (enumerator != null)
				{
					vxdL6pKd43qO9p9JVIe(enumerator);
				}
			}
			VGE7SGrDU();
			num = 8;
			goto IL_00b9;
			IL_012b:
			duohQ2pLC = value;
			num = 6;
			goto IL_00b9;
			IL_010f:
			if (Display.Connected)
			{
				goto IL_00ec;
			}
			num = 1;
			if (true)
			{
				goto IL_00b9;
			}
			goto IL_012b;
		}
	}

	public ReadOnlyObservableCollection<AppStepViewModel> Steps
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FyD56R02Rp;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			FyD56R02Rp = value;
		}
	}

	public FilmstripPanelViewModel Filmstrip
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return b7L5uwfVyI;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			b7L5uwfVyI = value;
		}
	}

	public DisplayStatusBarViewModel DisplayStatusBar
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return s2J5F9Wfru;
		}
	}

	public CvsInSightDisplay Display
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zNU5Xhjhyv;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			nuRFE5UNWs9SuD3VRP();
			int num = ((!xTwECWYK95pQ5F5UZK()) ? 9 : 8);
			IEnumerator<AppStepViewModel> enumerator = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					enumerator = Steps.GetEnumerator();
					num = 2;
					if (nuRFE5UNWs9SuD3VRP())
					{
					}
					break;
				case 2:
				{
					try
					{
						while (enumerator.MoveNext())
						{
							AppStepDisplayBase stepDisplay = enumerator.Current.StepDisplay;
							if (stepDisplay == null)
							{
								_ = 1;
								int num2;
								if (!nuRFE5UNWs9SuD3VRP())
								{
									num2 = 2;
								}
								else
								{
									num2 = 3;
									if (false)
									{
										continue;
									}
								}
								switch (num2)
								{
								}
							}
							else
							{
								stepDisplay.SetDisplay(value);
							}
						}
					}
					finally
					{
						enumerator?.Dispose();
					}
					object obj = lrnZiBKltyodBp2i0q9(ActiveStep);
					if (obj != null)
					{
						NfYRWNKgXDEeU3BZPZr(obj);
					}
					goto case 1;
				}
				default:
					num = 1;
					break;
				case 7:
				case 9:
					J0SxUOKvXGE9ydrdPXI(zNU5Xhjhyv, new CvsDisplayStateChangedEventHandler(f12QGCmYp));
					num = 10;
					break;
				case 6:
					if (SetField(ref zNU5Xhjhyv, value, (string)bJsCnd1mxLKL6JRwLn(866)))
					{
						num = 3;
						break;
					}
					goto case 5;
				case 4:
					zNU5Xhjhyv.StateChanged -= f12QGCmYp;
					num = 6;
					break;
				case 5:
					if (zNU5Xhjhyv != null)
					{
						goto case 7;
					}
					return;
				case 0:
				case 8:
					if (zNU5Xhjhyv != null)
					{
						num = 4;
						if (nuRFE5UNWs9SuD3VRP())
						{
						}
						break;
					}
					goto case 6;
				case 1:
					A2rDSuKspnttUYOeE3Z(DisplayStatusBar, value);
					num = 5;
					break;
				case 10:
					return;
				}
			}
		}
	}

	public bool IsOperatorOnline
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return d4Z0asKPUdSwlgb29TM(yT8mLrKDY4o38GRvi7b(this));
		}
	}

	public bool IsLiveMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FgZ1N5KZwYRBV7c9iLt(yT8mLrKDY4o38GRvi7b(this));
		}
	}

	public bool IsLiveModeAllowed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (!dd8YckKIxa9iqw3YqPc(Filmstrip))
			{
				AppStepViewModel appStepViewModel = tuC5o8i1EB;
				if (appStepViewModel == null)
				{
					return true;
				}
				return UrFlORKBJprBYWoMH7D(appStepViewModel);
			}
			return false;
		}
	}

	public AppStepViewModel ActiveStep
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tuC5o8i1EB;
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
			if (!nuRFE5UNWs9SuD3VRP())
			{
				num = 3;
				if (!xTwECWYK95pQ5F5UZK())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_007f;
			IL_0046:
			hMUb2dKbkLtr7dGm1Z4(this, CdQUGaROfy7He9T0foW.KbIzwHEDLa(884));
			num = 5;
			goto IL_007f;
			IL_007f:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					break;
				case 1:
					return;
				case 2:
					goto IL_0046;
				case 4:
					return;
				default:
					num = 2;
					continue;
				case 5:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			if (tuC5o8i1EB == value)
			{
				return;
			}
			AItyNJKnWLDKShH6HTE(C11guoYo3(value));
			goto IL_0046;
		}
	}

	public string HelpTopic
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			AppStepViewModel appStepViewModel = tuC5o8i1EB;
			return (string)(((appStepViewModel != null) ? mPwNSjKoP97O2GumUyx(appStepViewModel) : null) ?? "");
		}
	}

	public DelegateCommand ToggleFilmstripCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return oix5Dqcy8h;
		}
	}

	public AsyncDelegateCommand ResetJobStatisticsCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HKK53ENqhR;
		}
	}

	public AsyncDelegateCommand UpdateSnippetsToLatestRevisionCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return YC15fiM5j5;
		}
	}

	public PropertyLinks PropertyLinks
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PPP5EC6gfL;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			PPP5EC6gfL = value;
			RKSndcKptWFVPwv2Jlg(this, bJsCnd1mxLKL6JRwLn(906));
		}
	}

	public List<(Guid guid, CvsCellRange range)> CommIoSnippets
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return poZ5bbof96;
		}
	}

	public RelayCommand EditToolCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SC95cUG8jW;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SC95cUG8jW = value;
		}
	}

	public CvsCellLocation Acquired2DImageLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			CvsCellLocation? cvsCellLocation = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					lEm5QPUYrS = KZp21dCSS();
					num = 2;
					break;
				case 2:
					cvsCellLocation = lEm5QPUYrS;
					goto default;
				case 4:
					while (!lEm5QPUYrS.HasValue)
					{
						_ = 1;
						if (nuRFE5UNWs9SuD3VRP())
						{
							num = 0;
							if (xTwECWYK95pQ5F5UZK())
							{
								goto end_IL_0047;
							}
							continue;
						}
						num = 5;
						goto end_IL_0047;
					}
					goto case 2;
				default:
					if (!cvsCellLocation.HasValue)
					{
						num = 6;
						if (0 == 0)
						{
							break;
						}
						goto case 6;
					}
					return cvsCellLocation.GetValueOrDefault();
				case 6:
					{
						return CvsCellLocation.Invalid;
					}
					end_IL_0047:
					break;
				}
			}
		}
	}

	event EventHandler IRuntimeModeConstraint.RuntimeModeConstraintChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QGYLwLXoS(value);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KLIJXKXi0(value);
		}
	}

	public event EventHandler ActiveStepChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!xTwECWYK95pQ5F5UZK()) ? 6 : 2);
			EventHandler eventHandler2 = default;
			EventHandler value2 = default;
			EventHandler eventHandler = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					eventHandler2 = Owe5SwMqik;
					break;
				case 4:
					eventHandler2 = Interlocked.CompareExchange(ref Owe5SwMqik, value2, eventHandler);
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					goto case 3;
				case 3:
					if ((object)eventHandler2 == eventHandler)
					{
						num = 7;
						continue;
					}
					break;
				case 5:
					value2 = (EventHandler)E9e63VKGv5PqO3CyVbO(eventHandler, value);
					goto case 4;
				default:
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 1:
				case 6:
					break;
				case 7:
					return;
				}
				eventHandler = eventHandler2;
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
			int num = 3;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0067;
			IL_001a:
			EventHandler eventHandler = Owe5SwMqik;
			_ = 1;
			if (!nuRFE5UNWs9SuD3VRP())
			{
				num = 6;
			}
			else
			{
				num = 0;
				if (false)
				{
					return;
				}
			}
			goto IL_0067;
			IL_0067:
			EventHandler eventHandler2 = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 5:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						continue;
					}
					goto case 1;
				case 0:
				case 2:
					value2 = (EventHandler)UCAjuUmjfkF08W8WH2(eventHandler2, value);
					goto case 4;
				default:
					num = 4;
					continue;
				case 4:
					eventHandler = Interlocked.CompareExchange(ref Owe5SwMqik, value2, eventHandler2);
					num = 5;
					continue;
				case 1:
				case 6:
					eventHandler2 = eventHandler;
					goto case 0;
				case 7:
					return;
				}
				break;
			}
			goto IL_001a;
		}
	}

	public event Func<object, SnippetAddedEventArgs, Task> SnippetAdded
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
		}
	}

	public event Func<object, SnippetPreRemoveEventArgs, Task> SnippetPreRemove
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
		}
	}

	public event Func<object, SnippetRemoveEventArgs, Task> SnippetRemove
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
		}
	}

	public event SnippetRenamedEventHandler SnippetRenamed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EasyBuilderApplicationViewModel(CvsInSight insight, IEnumerable<AppStepViewModel> steps, IOperationProgressManager operationProgressManager)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		P2rz3AUMr = new List<EzSnippet>();
		poZ5bbof96 = new List<(Guid, CvsCellRange)>();
		base._002Ector();
		duohQ2pLC = insight ?? throw new ArgumentException(CdQUGaROfy7He9T0foW.KbIzwHEDLa(566));
		JnUrIxu3L = yUhNCh6i0(steps);
		gly55phwHC = operationProgressManager;
		oix5Dqcy8h = new DelegateCommand(NK3Mb3O6x, SjcRudLKh);
		YC15fiM5j5 = new AsyncDelegateCommand(OF2Wjt7ga, oTuTPJkpi);
		HKK53ENqhR = new AsyncDelegateCommand(FdYlcnQcs);
		VGE7SGrDU();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[ImportingConstructor]
	public EasyBuilderApplicationViewModel([Import] InSightStartupArgs startupArgs, [ImportMany] IEnumerable<AppStepViewModel> steps, [Import] IOperationProgressManager operationProgressManager)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		P2rz3AUMr = new List<EzSnippet>();
		poZ5bbof96 = new List<(Guid, CvsCellRange)>();
		base._002Ector();
		JnUrIxu3L = yUhNCh6i0(steps);
		gly55phwHC = operationProgressManager;
		EditToolCommand = new RelayCommand(e7GxxBEJY);
		HL08gGhGi = startupArgs.CogNamerDevice;
		HpNmEU0y2 = startupArgs.User;
		LoggedInUserName = HpNmEU0y2?.Username ?? "";
		duohQ2pLC = new CvsInSight();
		duohQ2pLC.Connect(HL08gGhGi, CdQUGaROfy7He9T0foW.KbIzwHEDLa(616), HpNmEU0y2);
		InSight.CogSocket.Sheet.IdOutOfOrder += giNAtCB2X;
		s2J5F9Wfru = new DisplayStatusBarViewModel();
		oix5Dqcy8h = new DelegateCommand(NK3Mb3O6x, SjcRudLKh);
		YC15fiM5j5 = new AsyncDelegateCommand(OF2Wjt7ga, oTuTPJkpi);
		HKK53ENqhR = new AsyncDelegateCommand(FdYlcnQcs, pVmjrw6jQ);
		VGE7SGrDU();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VGE7SGrDU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (!xTwECWYK95pQ5F5UZK())
		{
			goto IL_001e;
		}
		goto IL_00dd;
		IL_00dd:
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 4:
				goto IL_0033;
			case 1:
				goto IL_0052;
			default:
				goto IL_00a0;
			case 2:
			case 5:
				goto IL_00bb;
			case 7:
				return;
			}
			break;
			IL_0052:
			Inspect = JnUrIxu3L.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (AppStepViewModel s) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return s is InspectStepViewModel;
			}) as InspectStepViewModel;
			_ = 0;
			num = (xTwECWYK95pQ5F5UZK() ? 5 : 0);
		}
		goto IL_001e;
		IL_00bb:
		if (KLdFnlH3IMh8PxfLNr(Inspect) != null)
		{
			goto IL_0033;
		}
		goto IL_00a0;
		IL_00a0:
		YofrSVxj96NtjFa64G(Inspect, InSight);
		num = 4;
		goto IL_00dd;
		IL_001e:
		if (Inspect != null)
		{
			goto IL_00bb;
		}
		num = 1;
		goto IL_00dd;
		IL_0033:
		nQR5aKbwQR = new EzSupportSnippetType[1]
		{
			new PropertyLinksType(this)
		};
		num = 7;
		goto IL_00dd;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	internal CogNamerDevice iWIKIyxRi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return HL08gGhGi;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void QGYLwLXoS(EventHandler value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xTwECWYK95pQ5F5UZK();
		int num;
		if (!nuRFE5UNWs9SuD3VRP())
		{
			num = 5;
		}
		else
		{
			num = 3;
			if (nuRFE5UNWs9SuD3VRP())
			{
			}
		}
		EventHandler eventHandler2 = default;
		EventHandler eventHandler = default;
		EventHandler value2 = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				if ((object)eventHandler2 == eventHandler)
				{
					num = 7;
					break;
				}
				goto case 1;
			case 1:
			case 3:
				eventHandler = eventHandler2;
				num = 2;
				break;
			case 2:
				value2 = (EventHandler)Delegate.Combine(eventHandler, value);
				goto case 6;
			default:
				num = 6;
				break;
			case 6:
				eventHandler2 = Interlocked.CompareExchange(ref S875pBftxt, value2, eventHandler);
				num = 4;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 5:
				eventHandler2 = S875pBftxt;
				goto case 1;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void KLIJXKXi0(EventHandler value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (xTwECWYK95pQ5F5UZK())
		{
			num = 5;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0045;
		IL_0074:
		EventHandler value2 = default;
		EventHandler eventHandler2 = default;
		EventHandler eventHandler = Interlocked.CompareExchange(ref S875pBftxt, value2, eventHandler2);
		num = 2;
		goto IL_0045;
		IL_0045:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			default:
				num = 6;
				continue;
			case 6:
				goto IL_0074;
			case 2:
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
				continue;
			case 0:
			case 5:
				eventHandler = S875pBftxt;
				goto case 1;
			case 7:
				return;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		value2 = (EventHandler)UCAjuUmjfkF08W8WH2(eventHandler2, value);
		goto IL_0074;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerable<AppStepViewModel> yUhNCh6i0(IEnumerable<AppStepViewModel> P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0.Where([MethodImpl(MethodImplOptions.NoInlining)] (AppStepViewModel s) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return !(s is RunStepViewModel);
		}).ToList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void giNAtCB2X(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			vkORX9h7RWSVfyONoE(this);
		}
		catch (Exception ex)
		{
			uCJxYkz4xK1CiIxEkD(Logger, LogLevel.Error, WRGrd3tlOekZDlZXTh(), ex);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInitializeSteps_003Ed__44))]
	private Task ypxdImN6p()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CInitializeSteps_003Ed__44 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
				stateMachine._003C_003Et__builder = v36vsbKLl0YBmhb19GR();
				_ = 1;
				num = (nuRFE5UNWs9SuD3VRP() ? 5 : 4);
				break;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInitialize_003Ed__45))]
	public Task Initialize()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (nuRFE5UNWs9SuD3VRP())
		{
			goto IL_001e;
		}
		goto IL_0086;
		IL_001e:
		_003CInitialize_003Ed__45 stateMachine = default;
		stateMachine._003C_003Et__builder = v36vsbKLl0YBmhb19GR();
		_ = 0;
		if (xTwECWYK95pQ5F5UZK())
		{
			num = 0;
			if (false)
			{
				goto IL_0042;
			}
		}
		else
		{
			num = 2;
			if (nuRFE5UNWs9SuD3VRP())
			{
			}
		}
		goto IL_0086;
		IL_0086:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 0:
			case 1:
				goto IL_0042;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001e;
		IL_0042:
		stateMachine._003C_003E4__this = this;
		num = 5;
		goto IL_0086;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInitialize_003Ed__46))]
	public Task Initialize(bool registerSheet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CInitialize_003Ed__46 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			case 2:
			case 3:
				stateMachine.registerSheet = registerSheet;
				goto case 1;
			default:
				num = 1;
				if (xTwECWYK95pQ5F5UZK())
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003Et__builder = v36vsbKLl0YBmhb19GR();
				num = 0;
				break;
			case 4:
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 0:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				if (nuRFE5UNWs9SuD3VRP())
				{
					num = 6;
					break;
				}
				num = 3;
				if (nuRFE5UNWs9SuD3VRP())
				{
				}
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInitializeInternal_003Ed__47))]
	private Task Ccq6EpyOb(bool P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xTwECWYK95pQ5F5UZK();
		int num = (nuRFE5UNWs9SuD3VRP() ? 3 : 4);
		_003CInitializeInternal_003Ed__47 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 2:
			case 3:
				stateMachine.registerSheet = P_0;
				goto case 6;
			default:
				num = 6;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = v36vsbKLl0YBmhb19GR();
				num = 1;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CNewJobUpdate_003Ed__48))]
	private void UwauqbPLL(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xTwECWYK95pQ5F5UZK();
		int num = (nuRFE5UNWs9SuD3VRP() ? 4 : 3);
		_003CNewJobUpdate_003Ed__48 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 5:
				stateMachine._003C_003E1__state = -1;
				break;
			default:
				num = 2;
				continue;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = FgW2nvKKRkBH2QXVcug();
				goto case 1;
			case 2:
				break;
			case 6:
				return;
			}
			stateMachine._003C_003Et__builder.Start(ref stateMachine);
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReconnectInSight()
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
			case 1:
			case 4:
				InSight = (CvsInSight)cWhPlUK5lFaXpDkcqaR(Display);
				goto default;
			case 3:
				Display.AutoReconnect = true;
				_ = 1;
				num = ((!nuRFE5UNWs9SuD3VRP()) ? 4 : 0);
				break;
			default:
				if (!UO8VA3KwVFgJDt5jdgO(Display))
				{
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 5;
				}
				return;
			case 5:
				throw new CvsNotConnectedException((string)bJsCnd1mxLKL6JRwLn(670));
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void i8vFnXAl5(object P_0, RuntimeModeChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HnY0SMu2BGF5Yo5BUx(UpdateSnippetsToLatestRevisionCommand);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetupEasyBuilderIfAllowed_003Ed__51))]
	private Task TUbXLFygM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xTwECWYK95pQ5F5UZK();
		int num = (nuRFE5UNWs9SuD3VRP() ? 1 : 2);
		_003CSetupEasyBuilderIfAllowed_003Ed__51 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = v36vsbKLl0YBmhb19GR();
				num = 4;
				if (0 == 0)
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
	private void eSQoToKje(bool P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		using IEnumerator<AppStepViewModel> enumerator = Steps.GetEnumerator();
		while (GTxpZxKaiOCLBiFWT0U(enumerator))
		{
			AppStepViewModel current = enumerator.Current;
			nuRFE5UNWs9SuD3VRP();
			int num = ((!xTwECWYK95pQ5F5UZK()) ? 2 : 3);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					if (!(current is SetupImageStepViewModel))
					{
						goto IL_0086;
					}
					break;
				default:
					goto IL_0086;
				case 4:
					break;
				}
				break;
				IL_0086:
				cH5co6KJCcK9ldxOHl6(current, P_0);
				num = 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetupEasyBuilder_003Ed__53))]
	private Task TniS9jcdI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nuRFE5UNWs9SuD3VRP();
		int num;
		if (xTwECWYK95pQ5F5UZK())
		{
			num = 5;
			if (nuRFE5UNWs9SuD3VRP())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0074;
		IL_0042:
		_003CSetupEasyBuilder_003Ed__53 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0074;
		IL_0074:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			case 2:
				goto IL_0042;
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto IL_0042;
			default:
				num = 2;
				continue;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = v36vsbKLl0YBmhb19GR();
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		stateMachine._003C_003E4__this = this;
		num = 3;
		if (1 == 0)
		{
			goto IL_0042;
		}
		goto IL_0074;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CStep_SnippetAdded_003Ed__58))]
	private Task sBVDaoaFM(object P_0, SnippetAddedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CStep_SnippetAdded_003Ed__58 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003E1__state = -1;
				num = 3;
				break;
			case 0:
				stateMachine._003C_003E4__this = this;
				xTwECWYK95pQ5F5UZK();
				if (!nuRFE5UNWs9SuD3VRP())
				{
					num = 7;
					break;
				}
				num = 1;
				if (!nuRFE5UNWs9SuD3VRP())
				{
					break;
				}
				goto case 3;
			case 6:
				stateMachine.e = P_1;
				goto default;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 2:
			case 7:
				stateMachine.source = P_0;
				num = 6;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003Et__builder = v36vsbKLl0YBmhb19GR();
				num = 0;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnSnippetAdded_003Ed__59))]
	private Task nRV3NFP7G(object P_0, SnippetAddedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003COnSnippetAdded_003Ed__59 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 6:
				stateMachine.source = P_0;
				goto case 3;
			case 5:
				stateMachine._003C_003E1__state = -1;
				num = 1;
				break;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
				stateMachine._003C_003Et__builder = v36vsbKLl0YBmhb19GR();
				num = 7;
				break;
			case 7:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				if (!xTwECWYK95pQ5F5UZK())
				{
					num = 4;
					break;
				}
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 3;
			case 3:
			case 4:
				stateMachine.e = P_1;
				goto case 5;
			default:
				num = 5;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CStep_SnippetPreRemove_003Ed__60))]
	private Task Se0I84Do6(object P_0, SnippetPreRemoveEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003CStep_SnippetPreRemove_003Ed__60 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				stateMachine._003C_003Et__builder = v36vsbKLl0YBmhb19GR();
				xTwECWYK95pQ5F5UZK();
				if (!nuRFE5UNWs9SuD3VRP())
				{
					num = 5;
					continue;
				}
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 3;
				if (xTwECWYK95pQ5F5UZK())
				{
					continue;
				}
				goto case 3;
			case 3:
				stateMachine.e = P_1;
				goto case 2;
			default:
				num = 2;
				continue;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			case 7:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CStep_SnippetRemove_003Ed__61))]
	private Task tbvfsff7b(object P_0, SnippetRemoveEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!nuRFE5UNWs9SuD3VRP())
		{
			num = 4;
		}
		else
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_00dd;
			}
		}
		_003CStep_SnippetRemove_003Ed__61 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003E1__state = -1;
				num = 7;
				continue;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 6:
				stateMachine.e = P_1;
				goto case 2;
			default:
				num = 2;
				continue;
			case 5:
				stateMachine.source = P_0;
				num = 6;
				continue;
			case 7:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				continue;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = v36vsbKLl0YBmhb19GR();
				goto case 1;
			case 8:
				break;
			}
			break;
		}
		goto IL_00dd;
		IL_00dd:
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPauseResults_003Ed__62))]
	public Task<IAsyncDisposable> PauseResults()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CPauseResults_003Ed__62 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IAsyncDisposable>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CShiftSnippetsIntoUnusedRange_003Ed__63))]
	public Task ShiftSnippetsIntoUnusedRange(CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003CShiftSnippetsIntoUnusedRange_003Ed__63 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 5;
				break;
			case 1:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			case 2:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 0;
				break;
			case 0:
				stateMachine.range = range;
				goto default;
			default:
				nuRFE5UNWs9SuD3VRP();
				num = (xTwECWYK95pQ5F5UZK() ? 1 : 2);
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPasteSnippetInLocation_003Ed__64))]
	public Task PasteSnippetInLocation(PasteBuffer snippet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!nuRFE5UNWs9SuD3VRP())
		{
			num = 1;
			if (nuRFE5UNWs9SuD3VRP())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 6;
		}
		goto IL_005c;
		IL_0042:
		_003CPasteSnippetInLocation_003Ed__64 stateMachine = default;
		stateMachine.snippet = snippet;
		goto IL_008b;
		IL_005c:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 2:
			case 6:
				goto IL_0042;
			default:
				num = 4;
				continue;
			case 4:
				goto IL_008b;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = v36vsbKLl0YBmhb19GR();
				num = 3;
				continue;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		stateMachine._003C_003E4__this = this;
		goto IL_0042;
		IL_008b:
		stateMachine._003C_003E1__state = -1;
		num = 5;
		goto IL_005c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CParseShiftedSnippetsInRange_003Ed__65))]
	public Task ParseShiftedSnippetsInRange(CvsCellRange range, int shiftDistance)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xTwECWYK95pQ5F5UZK();
		int num;
		if (!nuRFE5UNWs9SuD3VRP())
		{
			num = 2;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 7;
		}
		goto IL_0086;
		IL_002a:
		_003CParseShiftedSnippetsInRange_003Ed__65 stateMachine = default;
		stateMachine.range = range;
		num = 3;
		goto IL_0086;
		IL_0086:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (!nuRFE5UNWs9SuD3VRP())
				{
					continue;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				continue;
			case 3:
				stateMachine.shiftDistance = shiftDistance;
				goto case 4;
			default:
				num = 4;
				continue;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = v36vsbKLl0YBmhb19GR();
				goto case 1;
			case 1:
			case 7:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (nuRFE5UNWs9SuD3VRP())
				{
				}
				continue;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnSnippetRemove_003Ed__66))]
	private Task pRJEXORuA(object P_0, SnippetRemoveEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003COnSnippetRemove_003Ed__66 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 2:
				stateMachine.e = P_1;
				goto default;
			default:
				_ = 1;
				if (nuRFE5UNWs9SuD3VRP())
				{
					num = 0;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				}
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 6;
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 1:
				stateMachine._003C_003Et__builder = v36vsbKLl0YBmhb19GR();
				num = 6;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CStep_SnippetRenamed_003Ed__67))]
	private void vrAbfgqHK(object P_0, SnippetRenamedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		_003CStep_SnippetRenamed_003Ed__67 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine.source = P_0;
				num = 6;
				break;
			case 3:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				if (xTwECWYK95pQ5F5UZK())
				{
					num = 1;
					if (0 == 0)
					{
						break;
					}
					goto case 6;
				}
				num = 0;
				break;
			case 6:
				stateMachine.e = P_1;
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 7:
				stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
				num = 3;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ENfcHuHQX(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		FilmstripPanelViewModel filmstripPanelViewModel = default;
		while (true)
		{
			switch (num)
			{
			case 5:
			case 6:
				try
				{
					AItyNJKnWLDKShH6HTE(TfZZ85KixYnf8O9UZss(yT8mLrKDY4o38GRvi7b(this), false));
				}
				catch (Exception ex)
				{
					string text = (string)bJsCnd1mxLKL6JRwLn(756);
					uCJxYkz4xK1CiIxEkD(Logger, LogLevel.Error, text, ex);
				}
				goto IL_004c;
			case 7:
				if (!dd8YckKIxa9iqw3YqPc(filmstripPanelViewModel))
				{
					goto IL_004c;
				}
				goto case 4;
			default:
				num = 4;
				break;
			case 4:
				if (((RuntimeViewModel)yT8mLrKDY4o38GRvi7b(this)).IsLiveMode)
				{
					goto case 5;
				}
				goto IL_004c;
			case 1:
				if (filmstripPanelViewModel != null)
				{
					_ = 1;
					if (nuRFE5UNWs9SuD3VRP())
					{
						num = 6;
						break;
					}
					num = 0;
					if (xTwECWYK95pQ5F5UZK())
					{
						break;
					}
					goto case 0;
				}
				return;
			case 0:
			case 2:
				if (Vo6hpmKOV1lWkEbLxdR(gqoIk0Kej895l6kw9ts(P_1), bJsCnd1mxLKL6JRwLn(712)))
				{
					num = 7;
					break;
				}
				return;
			case 3:
				filmstripPanelViewModel = P_0 as FilmstripPanelViewModel;
				num = 1;
				break;
			case 8:
				return;
				IL_004c:
				((RuntimeViewModel)yT8mLrKDY4o38GRvi7b(this)).IsLiveModeAllowed = !filmstripPanelViewModel.IsFilmstripRecording;
				num = 8;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnJobLoading_003Ed__69))]
	protected override Task OnJobLoading()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nuRFE5UNWs9SuD3VRP();
		int num = ((!xTwECWYK95pQ5F5UZK()) ? 1 : 5);
		_003COnJobLoading_003Ed__69 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 4;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnJobLoaded_003Ed__70))]
	protected override Task OnJobLoaded()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (xTwECWYK95pQ5F5UZK())
		{
			num = 5;
		}
		else
		{
			num = 2;
			if (1 == 0)
			{
				goto IL_0087;
			}
		}
		goto IL_003e;
		IL_003e:
		_003COnJobLoaded_003Ed__70 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				continue;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = v36vsbKLl0YBmhb19GR();
				break;
			case 1:
			case 2:
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0087;
		IL_0087:
		stateMachine._003C_003E4__this = this;
		num = 3;
		goto IL_003e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void f12QGCmYp(object P_0, CvsDisplayStateChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EventHandler eventHandler = S875pBftxt;
		if (eventHandler != null)
		{
			l5nI67KrHZrXCGtp6Bb(eventHandler, this, EventArgs.Empty);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUpdateActiveStep_003Ed__104))]
	private Task C11guoYo3(AppStepViewModel P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (nuRFE5UNWs9SuD3VRP())
		{
			goto IL_001e;
		}
		goto IL_0050;
		IL_001e:
		_003CUpdateActiveStep_003Ed__104 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_00bf;
		IL_0050:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 3:
				stateMachine.newStep = P_0;
				break;
			default:
				num = 5;
				continue;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
				stateMachine._003C_003Et__builder = v36vsbKLl0YBmhb19GR();
				nuRFE5UNWs9SuD3VRP();
				if (!xTwECWYK95pQ5F5UZK())
				{
					num = 6;
					continue;
				}
				num = 2;
				if (xTwECWYK95pQ5F5UZK())
				{
					continue;
				}
				goto IL_00bf;
			case 4:
			case 6:
				goto IL_00bf;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001e;
		IL_00bf:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 7;
		goto IL_0050;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnActiveStepChanged()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EventHandler eventHandler = Owe5SwMqik;
		if (eventHandler != null)
		{
			l5nI67KrHZrXCGtp6Bb(eventHandler, this, EventArgs.Empty);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NK3Mb3O6x()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		TT1lAuKkHEalnn9fAMp(ActiveStep, !Je1iIaKSFtn910FgnEb(ActiveStep));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool SjcRudLKh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ActiveStep.AllowFilmstrip;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void e1t4CpG2L(bool P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		reA5IQnQ7s = P_0;
		HnY0SMu2BGF5Yo5BUx(ResetJobStatisticsCommand);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoResetJobStatistics_003Ed__121))]
	private Task FdYlcnQcs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nuRFE5UNWs9SuD3VRP();
		int num = ((!xTwECWYK95pQ5F5UZK()) ? 5 : 4);
		_003CDoResetJobStatistics_003Ed__121 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 1;
				break;
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = v36vsbKLl0YBmhb19GR();
				num = 2;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool oTuTPJkpi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		bool? snippetsNeedUpdates2 = default;
		bool value = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				if (!snippetsNeedUpdates2.HasValue)
				{
					num = 2;
					continue;
				}
				goto case 5;
			case 6:
			case 9:
				if (!snippetsNeedUpdates2.Value)
				{
					break;
				}
				num = 3;
				if (xTwECWYK95pQ5F5UZK())
				{
					continue;
				}
				goto case 8;
			case 8:
				snippetsNeedUpdates2 = SnippetsNeedUpdates;
				_ = 1;
				num = (nuRFE5UNWs9SuD3VRP() ? 9 : 0);
				continue;
			case 3:
				if (IsEzbEditable)
				{
					num = 10;
					continue;
				}
				break;
			case 0:
			case 1:
				value = snippetsNeedUpdates2 == true;
				num = 4;
				continue;
			case 2:
				value = YkFe36inZ((CvsCellCollection)VFA3chKqsobWd2EdXVy(CBwrBMK8cOmFQ007yOF(InSight)));
				num = 7;
				continue;
			case 7:
			{
				bool? snippetsNeedUpdates = value;
				SnippetsNeedUpdates = snippetsNeedUpdates;
				goto case 5;
			}
			default:
				num = 5;
				continue;
			case 5:
				snippetsNeedUpdates2 = SnippetsNeedUpdates;
				goto case 6;
			case 10:
				return yZ34P8KEWiTxav60b6Q(yT8mLrKDY4o38GRvi7b(this));
			}
			break;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUpdateSnippetsToLatestRevision_003Ed__126))]
	private Task OF2Wjt7ga()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CUpdateSnippetsToLatestRevision_003Ed__126 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 5;
				break;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				num = (xTwECWYK95pQ5F5UZK() ? 1 : 4);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool pVmjrw6jQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return !reA5IQnQ7s;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<CellViewModel> GetLinkableProperties()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Enumerable.Empty<CellViewModel>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CReadCurrentPropertyLinks_003Ed__133))]
	public Task ReadCurrentPropertyLinks()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nuRFE5UNWs9SuD3VRP();
		int num;
		if (xTwECWYK95pQ5F5UZK())
		{
			num = 4;
		}
		else
		{
			num = 3;
			if (false)
			{
				goto IL_00b9;
			}
		}
		_003CReadCurrentPropertyLinks_003Ed__133 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				continue;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 1;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				break;
			}
			break;
		}
		goto IL_00b9;
		IL_00b9:
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CParseSheet_003Ed__137))]
	private Task P2cCx1icJ(CvsInSight P_0, Func<Guid, CvsCellCollection, CvsCellRange, Task> P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CParseSheet_003Ed__137 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.insight = P_0;
		stateMachine.handleMatch = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CTryHandleMatch_003Ed__138))]
	private Task rn5O0mxIL(Guid P_0, CvsCellCollection P_1, CvsCellRange P_2, Func<Guid, CvsCellCollection, CvsCellRange, Task> P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CTryHandleMatch_003Ed__138 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.guid = P_0;
		stateMachine.cells = P_1;
		stateMachine.range = P_2;
		stateMachine.handleMatch = P_3;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool R3THMSc9R(Guid P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CommStepViewModel commStepViewModel = Steps.OfType<CommStepViewModel>().First();
		OutputsStepViewModel outputsStepViewModel = Steps.OfType<OutputsStepViewModel>().First();
		if (!O2lNZIKXTSHC8PF10PW(commStepViewModel, P_0))
		{
			return kcmqE6K9lCLTD8Bkqba(outputsStepViewModel, P_0);
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<(Guid guid, CvsCellRange range)> GetSnippetsFromCells(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		List<(Guid, CvsCellRange)> list = new List<(Guid, CvsCellRange)>();
		Guid[] array = new Guid[3];
		CvsCell[] array2 = new CvsCell[3];
		foreach (CvsCell cell in cells)
		{
			string text = cell.GetComment()?.Text;
			if (string.IsNullOrEmpty(text) || !Guid.TryParse(text, out var result))
			{
				continue;
			}
			int num = cell.Location.Column / 9;
			if (array[num] != Guid.Empty && array[num] == result)
			{
				CvsCellLocation location = array2[num].Location;
				CvsCellLocation location2 = cell.Location;
				if (!new Size(location2.Column - location.Column + 1, location2.Row - location.Row + 1).IsEmpty)
				{
					list.Add(new ValueTuple<Guid, CvsCellRange>(item2: new CvsCellRange(location, location2), item1: result));
					array2[num] = null;
					array[num] = Guid.Empty;
				}
				else
				{
					array2[num] = cell;
					array[num] = result;
				}
			}
			else
			{
				array2[num] = cell;
				array[num] = result;
			}
		}
		return list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CHandleInspSnippetMatch_003Ed__141))]
	private Task dsLwr6hip(Guid P_0, CvsCellCollection P_1, CvsCellRange P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CHandleInspSnippetMatch_003Ed__141 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				continue;
			case 7:
				stateMachine.cells = P_1;
				goto case 0;
			default:
				num = 0;
				continue;
			case 1:
				stateMachine.guid = P_0;
				num = 7;
				continue;
			case 0:
				stateMachine.range = P_2;
				_ = 0;
				if (xTwECWYK95pQ5F5UZK())
				{
					num = 8;
					if (xTwECWYK95pQ5F5UZK())
					{
						continue;
					}
					goto case 2;
				}
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 3;
				continue;
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 1;
				continue;
			case 5:
			case 8:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			case 9:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CHandleAcqSnippetMatch_003Ed__142))]
	private Task KHGyvUrkn(Guid P_0, CvsCellCollection P_1, CvsCellRange P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		if (!xTwECWYK95pQ5F5UZK())
		{
			goto IL_001e;
		}
		goto IL_00b8;
		IL_00ef:
		_003CHandleAcqSnippetMatch_003Ed__142 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 9;
		if (xTwECWYK95pQ5F5UZK())
		{
			goto IL_00b8;
		}
		goto IL_010d;
		IL_00b8:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 3;
				if (nuRFE5UNWs9SuD3VRP())
				{
				}
				continue;
			case 4:
				stateMachine.range = P_2;
				num = 0;
				if (nuRFE5UNWs9SuD3VRP())
				{
				}
				continue;
			case 8:
				goto IL_006e;
			case 7:
				stateMachine.cells = P_1;
				goto case 4;
			default:
				num = 4;
				continue;
			case 5:
			case 6:
				goto IL_00ef;
			case 3:
				goto IL_010d;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
			IL_006e:
			stateMachine._003C_003Et__builder = v36vsbKLl0YBmhb19GR();
			xTwECWYK95pQ5F5UZK();
			if (nuRFE5UNWs9SuD3VRP())
			{
				num = 5;
				continue;
			}
			num = 2;
			if (nuRFE5UNWs9SuD3VRP())
			{
			}
		}
		goto IL_001e;
		IL_010d:
		stateMachine.guid = P_0;
		num = 7;
		if (nuRFE5UNWs9SuD3VRP())
		{
		}
		goto IL_00b8;
		IL_001e:
		stateMachine._003C_003E1__state = -1;
		goto IL_00ef;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSnippetLocation_003Ed__143))]
	public Task<CvsCellRange> GetSnippetLocation(CvsCellRange range, bool right = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetSnippetLocation_003Ed__143 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCellRange>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.range = range;
		stateMachine.right = right;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSnippetLocation_003Ed__144))]
	public Task<CvsCellRange> GetSnippetLocation(CvsCellCollection cells, CvsCellRange range, bool right = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetSnippetLocation_003Ed__144 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCellRange>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cells = cells;
		stateMachine.range = range;
		stateMachine.right = right;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Task<CvsCellRange> GetSnippetLocationFromCells(CvsCellCollection cells, CvsCellRange range, bool isRight, int maxRows)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int[] array = new int[3];
		foreach (CvsCell cell in cells)
		{
			int num = Math.Min(cell.Location.Column / 9, 2);
			if (cell.Location.Row + 2 > array[num])
			{
				array[num] = cell.Location.Row + 2;
			}
		}
		bool flag = false;
		CvsCellRange result = range;
		if (isRight)
		{
			for (int num2 = array.Length - 1; num2 >= 0; num2--)
			{
				int num3 = array[num2];
				if (result.Rows <= maxRows - num3)
				{
					result.Row = num3;
					result.Column = num2 * 9;
					flag = true;
					break;
				}
			}
		}
		else
		{
			for (int i = 0; i < array.Length; i++)
			{
				int num4 = array[i];
				if (result.Rows <= maxRows - num4)
				{
					result.Row = num4;
					result.Column = i * 9;
					flag = true;
					break;
				}
			}
		}
		if (!flag)
		{
			throw new ArgumentOutOfRangeException("", Resources.Ks3LSV115L());
		}
		return Task.FromResult(result);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SourceLink[] GetSourceLinks(CellType reqDataType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nuRFE5UNWs9SuD3VRP();
		int num;
		if (xTwECWYK95pQ5F5UZK())
		{
			num = 2;
		}
		else
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_0081;
			}
		}
		IEnumerator<AppStepViewModel> enumerator = default;
		List<SourceLink> list = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				enumerator = Steps.GetEnumerator();
				break;
			default:
				goto IL_005f;
			case 0:
			case 2:
				list = new List<SourceLink>();
				goto case 1;
			case 4:
				break;
			}
			break;
			IL_005f:
			num = 4;
		}
		goto IL_0081;
		IL_0081:
		try
		{
			SourceLink[] sourceLinks = default;
			while (GTxpZxKaiOCLBiFWT0U(enumerator))
			{
				ISnippetOwner snippetOwner = enumerator.Current as ISnippetOwner;
				xTwECWYK95pQ5F5UZK();
				int num2;
				if (!nuRFE5UNWs9SuD3VRP())
				{
					num2 = 6;
					if (nuRFE5UNWs9SuD3VRP())
					{
					}
				}
				else
				{
					num2 = 4;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						list.AddRange(sourceLinks);
						num2 = 7;
						continue;
					case 5:
						sourceLinks = snippetOwner.GetSourceLinks(reqDataType);
						num2 = 2;
						continue;
					case 2:
						if (sourceLinks == null)
						{
							break;
						}
						goto default;
					case 0:
					case 6:
						if (snippetOwner != null)
						{
							num2 = 5;
							continue;
						}
						break;
					default:
						if (sourceLinks.Length != 0)
						{
							num2 = 1;
							continue;
						}
						break;
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
				vxdL6pKd43qO9p9JVIe(enumerator);
			}
		}
		return (SourceLink[])Nl6sVPK4VPCrTcay3sq(list);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<IGrouping<string, CellViewModel>> GetSourceablePropertiesGrouped(CellViewModel targetProperty, Func<CellViewModel, bool> predicate = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		List<IGrouping<string, CellViewModel>> list = new List<IGrouping<string, CellViewModel>>();
		foreach (AppStepViewModel step in Steps)
		{
			if (step is ISnippetOwner snippetOwner)
			{
				List<IGrouping<string, CellViewModel>> list2 = snippetOwner.GetSourceablePropertiesGrouped(targetProperty, predicate).ToList();
				if (list2.Any())
				{
					list.AddRange(list2);
				}
			}
		}
		return list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<IGrouping<string, CellViewModel>> GetSourceablePrimitivesGrouped(CellViewModel targetProperty = null, Func<CellViewModel, bool> predicate = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		List<IGrouping<string, CellViewModel>> list = new List<IGrouping<string, CellViewModel>>();
		foreach (AppStepViewModel step in Steps)
		{
			if (step is ISnippetOwner snippetOwner)
			{
				List<IGrouping<string, CellViewModel>> list2 = snippetOwner.GetSourceablePrimitivesGrouped(targetProperty, predicate).ToList();
				if (list2.Any())
				{
					list.AddRange(list2);
				}
			}
		}
		return list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void e7GxxBEJY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass153_0 obj = new _003C_003Ec__DisplayClass153_0();
		obj._003C_003E4__this = this;
		obj.param = P_0;
		Task.Run([MethodImpl(MethodImplOptions.NoInlining)] () =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return obj._003C_003E4__this.V4tvIWmgN(obj.param as EzTool);
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnEditToolAsync_003Ed__154))]
	private Task V4tvIWmgN(EzTool P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xTwECWYK95pQ5F5UZK();
		int num = (nuRFE5UNWs9SuD3VRP() ? 1 : 6);
		_003COnEditToolAsync_003Ed__154 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine.tool = P_0;
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 4;
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (nuRFE5UNWs9SuD3VRP())
				{
				}
				break;
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 0:
			case 6:
				stateMachine._003C_003Et__builder = v36vsbKLl0YBmhb19GR();
				num = 2;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool YkFe36inZ(CvsCellCollection P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xTwECWYK95pQ5F5UZK();
		int num = (nuRFE5UNWs9SuD3VRP() ? 4 : 3);
		_003C_003Ec__DisplayClass155_0 CS_0024_003C_003E8__locals5 = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass155_0();
				num = 1;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
				CS_0024_003C_003E8__locals5._003C_003E4__this = this;
				goto default;
			default:
				CS_0024_003C_003E8__locals5.cells = P_0;
				num = 5;
				break;
			case 5:
				return Steps.OfType<ISnippetOwner>().Append(this).Select(CS_0024_003C_003E8__locals5._003CCheckIfJobNeedsUpdate_003Eb__0)
					.ToList()
					.Any(RequiresUpdate);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Supports(Guid guid)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass156_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass156_0();
		CS_0024_003C_003E8__locals2.guid = guid;
		return nQR5aKbwQR.Any([MethodImpl(MethodImplOptions.NoInlining)] (EzSupportSnippetType s) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<Guid>)_003C_003Ec__DisplayClass156_0.WROqZVKOQ3xQtc02sV1m(s)).Contains(CS_0024_003C_003E8__locals2.guid);
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddSnippet_003Ed__157))]
	public Task AddSnippet(Guid guid, CvsCellCollection cells, CvsCellRange snippetRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		_003CAddSnippet_003Ed__157 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine.guid = guid;
				_ = 0;
				if (xTwECWYK95pQ5F5UZK())
				{
					num = 4;
					if (nuRFE5UNWs9SuD3VRP())
					{
					}
				}
				else
				{
					num = 5;
				}
				break;
			case 5:
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				break;
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			case 8:
				stateMachine._003C_003Et__builder = v36vsbKLl0YBmhb19GR();
				num = 2;
				if (true)
				{
					break;
				}
				goto case 7;
			case 7:
				stateMachine.snippetRange = snippetRange;
				num = 1;
				break;
			case 3:
			case 4:
				stateMachine.cells = cells;
				goto case 7;
			default:
				num = 7;
				break;
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 0;
				break;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetOwner_002DAddSnippet_003Ed__158))]
	Task ISnippetOwner.AddSnippet(Guid guid, CvsCellCollection cells, CvsCellRange snippetRange, SnippetAddedEventType action)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!xTwECWYK95pQ5F5UZK()) ? 7 : 2);
		_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetOwner_002DAddSnippet_003Ed__158 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine.cells = cells;
				goto case 4;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 1;
				if (true)
				{
					break;
				}
				goto case 4;
			case 4:
			case 7:
				stateMachine.snippetRange = snippetRange;
				goto case 9;
			default:
				num = 9;
				if (xTwECWYK95pQ5F5UZK())
				{
					break;
				}
				goto case 6;
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 10;
				break;
			case 9:
				stateMachine.action = action;
				num = 8;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 3;
				break;
			case 8:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				break;
			case 3:
				stateMachine.guid = guid;
				num = 5;
				break;
			case 10:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetOwner_002DUpdateSnippet_003Ed__159))]
	Task ISnippetOwner.UpdateSnippet(Guid guid, CvsCellCollection cells, CvsCellRange snippetRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!nuRFE5UNWs9SuD3VRP())
		{
			num = 7;
		}
		else
		{
			num = 5;
			if (!xTwECWYK95pQ5F5UZK())
			{
				goto IL_0046;
			}
		}
		goto IL_00b8;
		IL_00b8:
		_003CCognex_002DInSight_002DEasyBuilder_002DViewModels_002DISnippetOwner_002DUpdateSnippet_003Ed__159 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 7:
				stateMachine._003C_003Et__builder = v36vsbKLl0YBmhb19GR();
				goto case 1;
			case 8:
				break;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				if (nuRFE5UNWs9SuD3VRP())
				{
				}
				continue;
			case 2:
				stateMachine._003C_003E1__state = -1;
				num = 3;
				continue;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 4;
				continue;
			case 6:
				stateMachine.cells = cells;
				break;
			default:
				num = 8;
				if (xTwECWYK95pQ5F5UZK())
				{
					continue;
				}
				goto case 4;
			case 4:
				stateMachine.guid = guid;
				num = 6;
				if (!nuRFE5UNWs9SuD3VRP())
				{
					continue;
				}
				goto case 9;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0046;
		IL_0046:
		stateMachine.snippetRange = snippetRange;
		num = 2;
		goto IL_00b8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool ISnippetOwner.SnippetNeedsUpdate(Guid guid, CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!xTwECWYK95pQ5F5UZK()) ? 2 : 3);
		_003C_003Ec__DisplayClass160_0 obj = default;
		EzSupportSnippetType ezSupportSnippetType = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				obj.guid = guid;
				num = 5;
				break;
			case 0:
			case 3:
				obj = new _003C_003Ec__DisplayClass160_0();
				goto case 1;
			case 4:
				if (ezSupportSnippetType != null)
				{
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 5;
				}
				return false;
			case 5:
				ezSupportSnippetType = nQR5aKbwQR.FirstOrDefault(obj._003CCognex_002EInSight_002EEasyBuilder_002EViewModels_002EISnippetOwner_002ESnippetNeedsUpdate_003Eb__0);
				goto case 4;
			default:
				num = 4;
				break;
			case 6:
				return ezSupportSnippetType.NeedsUpdate(range, cells);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDisposeAsyncCore_003Ed__173))]
	protected override ValueTask DisposeAsyncCore()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xTwECWYK95pQ5F5UZK();
		int num = (nuRFE5UNWs9SuD3VRP() ? 2 : 5);
		_003CDisposeAsyncCore_003Ed__173 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 1;
				break;
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = MC7MGpK7g0ooS35LCit();
				num = 4;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CvsCellLocation? KZp21dCSS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((InSight?.Results?.Cells)?.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (CvsCell P_0) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			_003C_003Ec__DisplayClass178_0 obj = default;
			while (true)
			{
				switch (num)
				{
				default:
					if (!oCg7IBKWagS4PCi5Nh2(obj.functionName))
					{
						return new string[2]
						{
							(string)bJsCnd1mxLKL6JRwLn(936),
							CdQUGaROfy7He9T0foW.KbIzwHEDLa(964)
						}.Any(obj._003CFindAcquired2DImageLocation_003Eb__1);
					}
					num = 5;
					break;
				case 0:
				case 1:
					obj.functionName = (string)kcqNJDKRcqR8JtV6XXa(P_0?.Expression ?? "");
					goto default;
				case 3:
					do
					{
						obj = new _003C_003Ec__DisplayClass178_0();
						nuRFE5UNWs9SuD3VRP();
						if (xTwECWYK95pQ5F5UZK())
						{
							num = 0;
							break;
						}
						num = 4;
					}
					while (!xTwECWYK95pQ5F5UZK());
					break;
				case 5:
					return false;
				}
			}
		}))?.Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static EasyBuilderApplicationViewModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Ms2DRbK3qYkgUrBr7Lj();
		Logger = (ILogger)vikPD2Kj1W0LJ7xYisw(typeof(EasyBuilderApplicationViewModel));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task DLpqZLnpw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)Bh9y4NK6vdMkv7DNANj(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task Am9iPlpys()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnJobLoaded();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void R8Ck1WDkk(AppStepViewModel P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (Display != null)
		{
			KZ39iIKCMF7pJ6lorRo(Display, false);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private ValueTask iU1PG0rZf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return TYd5GmKAkTlah8VqYaf(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	internal static bool KposCdIfM(CvsCell P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003C_003Ec__DisplayClass178_0 obj = default;
		while (true)
		{
			switch (num)
			{
			default:
				if (oCg7IBKWagS4PCi5Nh2(obj.functionName))
				{
					num = 5;
					break;
				}
				return new string[2]
				{
					(string)bJsCnd1mxLKL6JRwLn(936),
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(964)
				}.Any(obj._003CFindAcquired2DImageLocation_003Eb__1);
			case 0:
			case 1:
				obj.functionName = (string)kcqNJDKRcqR8JtV6XXa(P_0?.Expression ?? "");
				goto default;
			case 3:
				do
				{
					obj = new _003C_003Ec__DisplayClass178_0();
					nuRFE5UNWs9SuD3VRP();
					if (!xTwECWYK95pQ5F5UZK())
					{
						num = 4;
						continue;
					}
					num = 0;
					break;
				}
				while (!xTwECWYK95pQ5F5UZK());
				break;
			case 5:
				return false;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KLdFnlH3IMh8PxfLNr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YofrSVxj96NtjFa64G(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((AppStepViewModel)P_0).InSight = (CvsInSight)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xTwECWYK95pQ5F5UZK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nuRFE5UNWs9SuD3VRP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UCAjuUmjfkF08W8WH2(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Nj8IOPQ4mm7p32m939(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EasyBuilderLayout.CreateLayout((CvsCogEasyBuilderConfig)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object S7Gtq7NPms6dAJsMb6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).CogSocket;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ySaPJY297twcJ9oO1q(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).GetCameraInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nxtkHGclxSClgsWWcc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCamInfo)P_0).Model;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bJsCnd1mxLKL6JRwLn(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HnY0SMu2BGF5Yo5BUx(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseDelegateCommand)P_0).RaiseCanExecuteChanged();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vkORX9h7RWSVfyONoE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BaseIdeViewModel)P_0).HandleIdOutOfOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WRGrd3tlOekZDlZXTh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.aJCZ45S7XD();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uCJxYkz4xK1CiIxEkD(object P_0, LogLevel P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ILogger)P_0).LogException(P_1, (string)P_2, (Exception)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder v36vsbKLl0YBmhb19GR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncVoidMethodBuilder FgW2nvKKRkBH2QXVcug()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncVoidMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cWhPlUK5lFaXpDkcqaR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSightDisplay)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UO8VA3KwVFgJDt5jdgO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSightDisplay)P_0).Connected;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cH5co6KJCcK9ldxOHl6(object P_0, bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((StepBase)P_0).IsVisible = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GTxpZxKaiOCLBiFWT0U(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gqoIk0Kej895l6kw9ts(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertyChangedEventArgs)P_0).PropertyName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Vo6hpmKOV1lWkEbLxdR(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Equals((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dd8YckKIxa9iqw3YqPc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FilmstripPanelViewModel)P_0).IsFilmstripRecording;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yT8mLrKDY4o38GRvi7b(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BaseIdeViewModel)P_0).Runtime;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TfZZ85KixYnf8O9UZss(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((RuntimeViewModel)P_0).SetLiveMode(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AItyNJKnWLDKShH6HTE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Task)P_0).IgnoreResult();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OvTCvYKV1SoVCS9AlKV(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSight)P_0).Connect((CogNamerDevice)P_1, (string)P_2, (UserData)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hG3XkNKfxc8Re3OWxBE(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IInSightAppStep)P_0).InSight = (CvsInSight)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vxdL6pKd43qO9p9JVIe(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lrnZiBKltyodBp2i0q9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).StepDisplay;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NfYRWNKgXDEeU3BZPZr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((AppStepDisplayBase)P_0).SetDisplayToStepMode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void A2rDSuKspnttUYOeE3Z(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((DisplayStatusBarViewModel)P_0).Display = (CvsInSightDisplay)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void J0SxUOKvXGE9ydrdPXI(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplay)P_0).StateChanged += (CvsDisplayStateChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void l5nI67KrHZrXCGtp6Bb(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (EventArgs)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool d4Z0asKPUdSwlgb29TM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((RuntimeViewModel)P_0).IsOperatorOnline;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FgZ1N5KZwYRBV7c9iLt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((RuntimeViewModel)P_0).IsLiveMode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UrFlORKBJprBYWoMH7D(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StepBase)P_0).CanEnableLiveMode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hMUb2dKbkLtr7dGm1Z4(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Cognex.InSight.Controls.ViewModels.BaseViewModel)P_0).FirePropertyChangedExplicit((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object E9e63VKGv5PqO3CyVbO(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mPwNSjKoP97O2GumUyx(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).HelpTopic;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Je1iIaKSFtn910FgnEb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StepBase)P_0).AllowShowFilmstrip;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TT1lAuKkHEalnn9fAMp(object P_0, bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((StepBase)P_0).AllowShowFilmstrip = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CBwrBMK8cOmFQ007yOF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Results;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VFA3chKqsobWd2EdXVy(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsResultSet)P_0).Cells;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool yZ34P8KEWiTxav60b6Q(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((RuntimeViewModel)P_0).IsOperatorOfflineAndNotInLiveMode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RKSndcKptWFVPwv2Jlg(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Cognex.InSight.Controls.ViewModels.BaseViewModel)P_0).FirePropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool O2lNZIKXTSHC8PF10PW(object P_0, Guid guid)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CommStepViewModel)P_0).Supports(guid);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kcmqE6K9lCLTD8Bkqba(object P_0, Guid guid)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((OutputsStepViewModel)P_0).Supports(guid);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Nl6sVPK4VPCrTcay3sq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<SourceLink>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncValueTaskMethodBuilder MC7MGpK7g0ooS35LCit()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncValueTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ms2DRbK3qYkgUrBr7Lj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vikPD2Kj1W0LJ7xYisw(Type P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return LogManager.GetLogger(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Bh9y4NK6vdMkv7DNANj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BaseIdeViewModel)P_0).OnJobLoading();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KZ39iIKCMF7pJ6lorRo(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsInSightDisplay)P_0).ShowGrid = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ValueTask TYd5GmKAkTlah8VqYaf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BaseIdeViewModel)P_0).DisposeAsyncCore();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kcqNJDKRcqR8JtV6XXa(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsParse.FindIdentifier((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oCg7IBKWagS4PCi5Nh2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}
}
