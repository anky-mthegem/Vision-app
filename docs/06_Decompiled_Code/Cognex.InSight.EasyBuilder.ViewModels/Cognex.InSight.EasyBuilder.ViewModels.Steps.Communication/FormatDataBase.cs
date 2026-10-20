using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Common;
using Cognex.Common.Commands;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime;
using Cognex.InSight.Runtime.ViewModels;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public abstract class FormatDataBase : BaseViewModel, IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRemoveElementAtAsync_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FormatDataBase _003C_003E4__this;

		public int index;

		private TaskAwaiter<bool> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!TAFOX95IU6OhGVMlMdt0())
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 2;
			}
			goto IL_01c8;
			IL_0026:
			FormatDataBase formatDataBase = _003C_003E4__this;
			num = 4;
			goto IL_01c8;
			IL_01c8:
			int num2 = default;
			TaskAwaiter<bool> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					break;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							formatDataBase.yeWq3UICUT = new TaskCompletionSource<bool>();
							num3 = 5;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 10;
							if (1 == 0)
							{
								goto IL_0188;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 8:
								awaiter.GetResult();
								num3 = 11;
								continue;
							case 9:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								if (w0dgWi5IYkBdvEZCP5Pf())
								{
									continue;
								}
								goto case 5;
							case 5:
								clebXV5IH55wOC3MwESC(formatDataBase.gwvqfdSvGf, index);
								awaiter = formatDataBase.yeWq3UICUT.Task.GetAwaiter();
								TAFOX95IU6OhGVMlMdt0();
								num3 = (w0dgWi5IYkBdvEZCP5Pf() ? 4 : 0);
								continue;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 3;
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 8;
								continue;
							case 10:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 1:
							case 4:
								if (awaiter.IsCompleted)
								{
									goto case 8;
								}
								goto case 0;
							case 0:
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 9;
								if (true)
								{
									continue;
								}
								return;
							case 3:
								return;
							case 11:
								break;
							}
							break;
						}
						goto IL_0188;
						IL_0188:
						formatDataBase.yeWq3UICUT = null;
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
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					break;
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
		internal static void clebXV5IH55wOC3MwESC(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Collection<DataElement>)P_0).RemoveAt(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool w0dgWi5IYkBdvEZCP5Pf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TAFOX95IU6OhGVMlMdt0()
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
	private struct _003CElements_CollectionChanged_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public FormatDataBase _003C_003E4__this;

		public NotifyCollectionChangedEventArgs e;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			int num2 = default;
			FormatDataBase formatDataBase = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					try
					{
						if (num2 == 0 || !formatDataBase._suspendElementsEvents.IsNonZero)
						{
							try
							{
								TaskAwaiter awaiter;
								int num3;
								if (num2 != 0)
								{
									awaiter = PuGlUw5IQGjFplBn5rcM(formatDataBase.OnElementsChanged(e));
									num3 = 1;
									goto IL_00de;
								}
								awaiter = _003C_003Eu__1;
								goto IL_010f;
								IL_010f:
								bHkUYu5ImZTHy11gBP5L();
								num3 = (PDYief5Ix6FSRWBIm051() ? 2 : 6);
								goto IL_00de;
								IL_00de:
								while (true)
								{
									switch (num3)
									{
									case 1:
										if (!awaiter.IsCompleted)
										{
											num3 = 9;
											continue;
										}
										goto case 0;
									case 9:
										num2 = (_003C_003E1__state = 0);
										num3 = 7;
										continue;
									case 2:
									case 4:
										_003C_003Eu__1 = default;
										goto case 5;
									case 8:
									{
										TaskCompletionSource<bool> yeWq3UICUT = formatDataBase.yeWq3UICUT;
										if (yeWq3UICUT == null)
										{
											num3 = 10;
											continue;
										}
										yeWq3UICUT.SetResult(result: true);
										goto end_IL_00de;
									}
									case 3:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									case 5:
									case 6:
										num2 = (_003C_003E1__state = -1);
										num3 = 0;
										if (true)
										{
											continue;
										}
										goto case 7;
									case 7:
										_003C_003Eu__1 = awaiter;
										num3 = 3;
										continue;
									case 0:
										awaiter.GetResult();
										num3 = 8;
										continue;
									case 10:
										goto end_IL_00de;
									}
									goto IL_010f;
									continue;
									end_IL_00de:
									break;
								}
							}
							catch (Exception ex)
							{
								eEVSJk5I2XOMBU8WesSw(Logger, igrGxb5IN3Q9F64ssvrh(ex), ex);
								TaskCompletionSource<bool> yeWq3UICUT2 = formatDataBase.yeWq3UICUT;
								if (yeWq3UICUT2 != null)
								{
									mUGYsj5IcSsiWHQYpIY2(yeWq3UICUT2, ex);
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
					goto case 0;
				default:
					num = 0;
					break;
				case 3:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((!PDYief5Ix6FSRWBIm051()) ? 4 : 5);
					break;
				case 0:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 5:
					formatDataBase = _003C_003E4__this;
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
		internal static TaskAwaiter PuGlUw5IQGjFplBn5rcM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object igrGxb5IN3Q9F64ssvrh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Exception)P_0).Message;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void eEVSJk5I2XOMBU8WesSw(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).WarnException((string)P_1, (Exception)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void mUGYsj5IcSsiWHQYpIY2(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((TaskCompletionSource<bool>)P_0).SetException((Exception)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PDYief5Ix6FSRWBIm051()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bHkUYu5ImZTHy11gBP5L()
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
	private struct _003COnElementsChanged_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FormatDataBase _003C_003E4__this;

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
			FormatDataBase formatDataBase = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							formatDataBase.RaiseElementChanged();
							num3 = 6;
							if (LI4O7P5Iuq9rPvYjXIN2())
							{
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 9;
						}
						while (true)
						{
							switch (num3)
							{
							case 9:
								_003C_003Eu__1 = default;
								num3 = 8;
								continue;
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								continue;
							case 0:
								return;
							case 5:
								return;
							case 6:
								awaiter = Task.CompletedTask.GetAwaiter();
								num3 = 7;
								continue;
							case 1:
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								_ = 0;
								if (OW08dM5I1b8avofFYDyH())
								{
									num3 = 3;
									continue;
								}
								num3 = 0;
								if (true)
								{
									continue;
								}
								break;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								break;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 3:
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
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
					goto default;
				case 5:
					formatDataBase = _003C_003E4__this;
					OW08dM5I1b8avofFYDyH();
					num = ((!LI4O7P5Iuq9rPvYjXIN2()) ? 1 : 4);
					break;
				case 0:
					num2 = _003C_003E1__state;
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
		internal static bool OW08dM5I1b8avofFYDyH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LI4O7P5Iuq9rPvYjXIN2()
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
	private struct _003C_selectedElement_PropertyChanged_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public FormatDataBase _003C_003E4__this;

		public PropertyChangedEventArgs e;

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
			FormatDataBase formatDataBase = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					JCEKqC5ItTbYJE63ivhe();
					if (yJEKaH5Ihk7FqDNRk7DI())
					{
						num = 0;
						continue;
					}
					num = 5;
					if (!JCEKqC5ItTbYJE63ivhe())
					{
						continue;
					}
					break;
				case 2:
				case 5:
					try
					{
						if (num2 == 0 || !formatDataBase._suspendElementsEvents.IsNonZero)
						{
							try
							{
								TaskAwaiter awaiter;
								int num3;
								if (num2 != 0)
								{
									awaiter = ((Task)YOrDu05DL9X7yPy39qx2(formatDataBase, X70v5S5IzdQMlH6nBF52(e))).GetAwaiter();
									num3 = 7;
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
									case 2:
									case 6:
										_003C_003Eu__1 = awaiter;
										goto case 0;
									case 4:
										return;
									case 7:
										if (awaiter.IsCompleted)
										{
											break;
										}
										num3 = 8;
										if (!JCEKqC5ItTbYJE63ivhe())
										{
											continue;
										}
										goto case 1;
									case 1:
										_003C_003Eu__1 = default;
										num3 = 5;
										continue;
									case 8:
										num2 = (_003C_003E1__state = 0);
										yJEKaH5Ihk7FqDNRk7DI();
										num3 = ((!JCEKqC5ItTbYJE63ivhe()) ? 6 : 0);
										continue;
									case 5:
										num2 = (_003C_003E1__state = -1);
										num3 = 9;
										continue;
									case 0:
									case 3:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									default:
										num3 = 4;
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
							catch (Exception ex)
							{
								Logger.WarnException((string)LJYF7N5DKYhv3CWev1KJ(ex), ex);
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
				default:
					num = 3;
					continue;
				case 0:
				case 1:
					formatDataBase = _003C_003E4__this;
					goto case 2;
				case 3:
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
		internal static object X70v5S5IzdQMlH6nBF52(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyChangedEventArgs)P_0).PropertyName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YOrDu05DL9X7yPy39qx2(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FormatDataBase)P_0).OnSelectedElementPropertyChanged((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LJYF7N5DKYhv3CWev1KJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Exception)P_0).Message;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yJEKaH5Ihk7FqDNRk7DI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JCEKqC5ItTbYJE63ivhe()
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
	private struct _003COnSelectedElementPropertyChanged_003Ed__25 : IAsyncStateMachine
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
			cK216L5D5KEpTlGnyQj9();
			int num = ((!M7q96q5Dw4JcHKX9BK4Z()) ? 1 : 3);
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 5;
					if (M7q96q5Dw4JcHKX9BK4Z())
					{
					}
					break;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					break;
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = pqZa8U5DaPi1uG0Yp0pP(OByUWn5DJiyRQuWTwyxM());
							num3 = 4;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
							if (M7q96q5Dw4JcHKX9BK4Z())
							{
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 2:
								_003C_003Eu__1 = awaiter;
								goto case 3;
							case 6:
								return;
							case 3:
							case 8:
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
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								break;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 1;
								continue;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 7:
								num2 = (_003C_003E1__state = 0);
								_ = 1;
								num3 = (M7q96q5Dw4JcHKX9BK4Z() ? 8 : 0);
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
					goto default;
				case 5:
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
		internal static object OByUWn5DJiyRQuWTwyxM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter pqZa8U5DaPi1uG0Yp0pP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cK216L5D5KEpTlGnyQj9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool M7q96q5Dw4JcHKX9BK4Z()
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
	private struct _003CDoAddElement_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CellViewModel dataCell;

		public FormatDataBase _003C_003E4__this;

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
			DataElement item = default;
			TaskAwaiter awaiter = default;
			FormatDataBase formatDataBase = default;
			while (true)
			{
				switch (num)
				{
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
							item = new DataElement(dataCell);
							num3 = 3;
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
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 4:
								_003C_003Eu__1 = default;
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
								_003C_003Eu__1 = awaiter;
								num3 = 9;
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 1:
							case 5:
								awaiter = ((Task)NfjFRw5DIRtiyJOwvpor()).GetAwaiter();
								goto case 2;
							case 2:
							case 8:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 7;
								if (0 == 0)
								{
									continue;
								}
								goto case 7;
							case 7:
								num2 = (_003C_003E1__state = 0);
								goto case 0;
							default:
								num3 = 0;
								if (uiAxAY5DekWUDamyFaLh())
								{
									continue;
								}
								goto case 3;
							case 3:
								formatDataBase.Elements.Add(item);
								_ = 1;
								if (MDWWJl5DOGIrfIJrHeSM())
								{
									num3 = 8;
									if (0 == 0)
									{
										continue;
									}
									goto case 2;
								}
								num3 = 5;
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
					goto case 4;
				default:
					num = 4;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
				case 5:
					formatDataBase = _003C_003E4__this;
					goto case 2;
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					num = (uiAxAY5DekWUDamyFaLh() ? 5 : 3);
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
		internal static object NfjFRw5DIRtiyJOwvpor()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uiAxAY5DekWUDamyFaLh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MDWWJl5DOGIrfIJrHeSM()
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
	private struct _003CDoRemoveElement_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FormatDataBase _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!KTRwsB5DDvG0xPg9SokL()) ? 1 : 3);
			int num2 = default;
			FormatDataBase formatDataBase = default;
			TaskAwaiter awaiter = default;
			do
			{
				IL_0187:
				switch (num)
				{
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							formatDataBase.Elements.Remove(formatDataBase.SelectedElement);
							num3 = 1;
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
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								break;
							case 0:
								return;
							case 5:
								return;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 8;
								if (KTRwsB5DDvG0xPg9SokL())
								{
									continue;
								}
								goto case 3;
							case 3:
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 1:
								awaiter = pxReH15DVAYxDKSSk1EU(jeCEbt5Dnr08W5GDMx1k());
								num3 = 6;
								continue;
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 9;
								continue;
							case 9:
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								_ = 1;
								num3 = ((!DwwMwl5DiogyaS48wxTx()) ? 3 : 0);
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
				default:
					num = 5;
					goto IL_0187;
				case 4:
					formatDataBase = _003C_003E4__this;
					goto case 1;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 4;
					if (DwwMwl5DiogyaS48wxTx())
					{
					}
					goto IL_0187;
				case 5:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
			}
			while (KTRwsB5DDvG0xPg9SokL());
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
		internal static object jeCEbt5Dnr08W5GDMx1k()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter pxReH15DVAYxDKSSk1EU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KTRwsB5DDvG0xPg9SokL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DwwMwl5DiogyaS48wxTx()
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
	private struct _003CDoMoveUpElement_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FormatDataBase _003C_003E4__this;

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
			if (!lsa87Z5DdAZjhWcoovC2())
			{
				num = 5;
			}
			else
			{
				num = 2;
				if (false)
				{
					goto IL_01f3;
				}
			}
			goto IL_01af;
			IL_01af:
			int num2 = default;
			int num3 = default;
			FormatDataBase formatDataBase = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 4:
					try
					{
						int num4;
						if (num2 != 0)
						{
							num3 = formatDataBase.Elements.IndexOf(formatDataBase.SelectedElement);
							num4 = 6;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num4 = 9;
						}
						while (true)
						{
							switch (num4)
							{
							case 2:
							case 3:
								if (!awaiter.IsCompleted)
								{
									num4 = 7;
									continue;
								}
								break;
							case 5:
								return;
							case 6:
								lvDX235DlHkr7drwdO1G(formatDataBase.Elements, num3, num3 - 1);
								_ = 0;
								if (iZidEa5Df37PUrSGccTt())
								{
									num4 = 4;
									if (iZidEa5Df37PUrSGccTt())
									{
										continue;
									}
									goto case 7;
								}
								num4 = 3;
								continue;
							case 7:
								num2 = (_003C_003E1__state = 0);
								goto case 0;
							default:
								num4 = 0;
								continue;
							case 0:
								_003C_003Eu__1 = awaiter;
								num4 = 8;
								continue;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num4 = 5;
								if (true)
								{
									continue;
								}
								goto case 1;
							case 1:
							case 4:
								awaiter = brmMnp5DsUlFXKXIKHZb(upjMwc5DguhdZ8yU90KV());
								goto case 2;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num4 = 10;
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
					goto case 3;
				default:
					num = 3;
					continue;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					break;
				case 1:
				case 2:
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_01f3;
			IL_01f3:
			formatDataBase = _003C_003E4__this;
			num = 4;
			if (lsa87Z5DdAZjhWcoovC2())
			{
			}
			goto IL_01af;
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
		internal static void lvDX235DlHkr7drwdO1G(object P_0, int P_1, int P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ObservableCollection<DataElement>)P_0).Move(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object upjMwc5DguhdZ8yU90KV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter brmMnp5DsUlFXKXIKHZb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iZidEa5Df37PUrSGccTt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lsa87Z5DdAZjhWcoovC2()
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
	private struct _003CDoMoveDownElement_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FormatDataBase _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = ((!gEv23R5DrDfHTEYLklSN()) ? 1 : 4);
			FormatDataBase formatDataBase = default;
			int num3 = default;
			TaskAwaiter awaiter = default;
			int num2 = default;
			do
			{
				IL_01d8:
				switch (num)
				{
				case 5:
					formatDataBase = _003C_003E4__this;
					num = 2;
					goto IL_01d8;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 5;
					goto IL_01d8;
				case 2:
					try
					{
						int num4;
						if (num2 != 0)
						{
							num3 = formatDataBase.Elements.IndexOf(formatDataBase.SelectedElement);
							gEv23R5DrDfHTEYLklSN();
							num4 = ((!Kb2tq45Dvnbio1MfgAiq()) ? 9 : 4);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num4 = 2;
							if (gEv23R5DrDfHTEYLklSN())
							{
								goto IL_013a;
							}
						}
						while (true)
						{
							switch (num4)
							{
							case 8:
								if (!awaiter.IsCompleted)
								{
									num4 = 3;
									if (Kb2tq45Dvnbio1MfgAiq())
									{
										continue;
									}
									goto case 0;
								}
								goto case 10;
							case 0:
							case 4:
								SgdqiR5DPvsREmNY6smf(formatDataBase.Elements, num3, num3 + 1);
								num4 = 6;
								continue;
							case 1:
								break;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num4 = 10;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Eu__1 = default;
								num4 = 7;
								if (true)
								{
									continue;
								}
								goto case 6;
							case 6:
								awaiter = EtePBO5DZ85EFfkHnnhR(Task.CompletedTask);
								num4 = 8;
								if (gEv23R5DrDfHTEYLklSN())
								{
								}
								continue;
							case 5:
							case 9:
								goto IL_0110;
							case 3:
								goto IL_013a;
							default:
								num4 = 1;
								if (!gEv23R5DrDfHTEYLklSN())
								{
									continue;
								}
								goto case 10;
							case 10:
								awaiter.GetResult();
								goto end_IL_0046;
							}
							break;
						}
						goto IL_00ad;
						IL_013a:
						num2 = (_003C_003E1__state = 0);
						goto IL_00ad;
						IL_00ad:
						_003C_003Eu__1 = awaiter;
						goto IL_0110;
						IL_0110:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_0046:;
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
		internal static void SgdqiR5DPvsREmNY6smf(object P_0, int P_1, int P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ObservableCollection<DataElement>)P_0).Move(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter EtePBO5DZ85EFfkHnnhR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Kb2tq45Dvnbio1MfgAiq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gEv23R5DrDfHTEYLklSN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass48_0
	{
		public CvsCellLocation cellLoc;

		public Func<CellViewModel, bool> _003C_003E9__0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass48_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			Jgeiwb5DGNDvAeAXSNkb(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CFindCellVm_003Eb__0(CellViewModel c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hOMyyw5DSvrRWoSix7fO(MrfbOF5DoXBagLUQK4Is(c), cellLoc);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Jgeiwb5DGNDvAeAXSNkb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pHArOK5DBN0UhCI431yr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tT1tY25DbAfvBAKO6wYs()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation MrfbOF5DoXBagLUQK4Is(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hOMyyw5DSvrRWoSix7fO(CvsCellLocation P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0 == P_1;
		}
	}

	protected static ILogger Logger;

	private TaskCompletionSource<bool> yeWq3UICUT;

	[CompilerGenerated]
	private IInSightAppStep t5mqIeIDm6;

	private ObservableCollection<DataElement> gwvqfdSvGf;

	protected ScopedCounter _suspendElementsEvents;

	private DataElement f7bqEjXI1K;

	[CompilerGenerated]
	private readonly AsyncRelayCommand<CellViewModel> bFUqbCTXJg;

	[CompilerGenerated]
	private readonly AsyncRelayCommand zltqcrHKLx;

	[CompilerGenerated]
	private readonly AsyncRelayCommand zNmqQ7j8Li;

	[CompilerGenerated]
	private readonly AsyncRelayCommand oQ4qg4oN5b;

	public CvsInSight InSight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (CvsInSight)DdkFlw25AES0KHobThn(AppStep);
		}
	}

	public IInSightAppStep AppStep
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return t5mqIeIDm6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			t5mqIeIDm6 = value;
		}
	}

	public ObservableCollection<DataElement> Elements
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return gwvqfdSvGf;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (gwvqfdSvGf != null)
			{
				gwvqfdSvGf.CollectionChanged -= VfTq7FTl98;
			}
			SetField(ref gwvqfdSvGf, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(29316));
			if (gwvqfdSvGf != null)
			{
				gwvqfdSvGf.CollectionChanged += VfTq7FTl98;
			}
		}
	}

	public DataElement SelectedElement
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return f7bqEjXI1K;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			N50ov0NuA88LWQ6RVwe();
			int num;
			if (!ktpPHdNhRxSPcDDDnFM())
			{
				num = 2;
				if (!N50ov0NuA88LWQ6RVwe())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_004b;
			IL_00f2:
			f7bqEjXI1K.PropertyChanged += sZ5qN6BPrD;
			num = 7;
			goto IL_004b;
			IL_007e:
			RaiseElementChanged();
			num = 8;
			goto IL_004b;
			IL_002e:
			if (f7bqEjXI1K == null)
			{
				goto IL_007e;
			}
			goto IL_00f2;
			IL_004b:
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				default:
					num = 4;
					continue;
				case 7:
					goto IL_007e;
				case 6:
					if (SetField(ref f7bqEjXI1K, value, (string)v0Kqio2aT9kR1c0ywhK(29336)))
					{
						num = 5;
						continue;
					}
					return;
				case 1:
				case 3:
					f7bqEjXI1K.PropertyChanged -= sZ5qN6BPrD;
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 2:
					if (f7bqEjXI1K == null)
					{
						goto case 6;
					}
					goto case 1;
				case 4:
					goto IL_00f2;
				case 8:
					return;
				}
				break;
			}
			goto IL_002e;
		}
	}

	public AsyncRelayCommand<CellViewModel> AddElementCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bFUqbCTXJg;
		}
	}

	public AsyncRelayCommand RemoveElementCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zltqcrHKLx;
		}
	}

	public AsyncRelayCommand MoveUpElementCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zNmqQ7j8Li;
		}
	}

	public AsyncRelayCommand MoveDownElementCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return oQ4qg4oN5b;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FormatDataBase(IInSightAppStep appStep)
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
			case 4:
			case 10:
				Elements = new ObservableCollection<DataElement>();
				goto case 7;
			default:
				num = 7;
				continue;
			case 0:
				((IRuntimeService)hpu3Vv2LIJk94BB51EC(((BaseIdeViewModel)NPGymfNzU614dUY0f6V(AppStep)).Runtime)).SheetExecuted += E3JqUoeNVe;
				num = 11;
				continue;
			case 2:
				zNmqQ7j8Li = new AsyncRelayCommand(gJ3qFhNvPD, GSSqXkONhT);
				oQ4qg4oN5b = new AsyncRelayCommand(AQpqohxSoN, w5LqSk93eB);
				num = 0;
				if (N50ov0NuA88LWQ6RVwe())
				{
					continue;
				}
				goto case 5;
			case 5:
				VpBLVJNt1PocOpvjF3m();
				num = 9;
				continue;
			case 7:
				bFUqbCTXJg = new AsyncRelayCommand<CellViewModel>(chdqAcNk36, qHjqd7j1i3);
				num = 1;
				if (N50ov0NuA88LWQ6RVwe())
				{
					continue;
				}
				goto case 3;
			case 3:
			case 8:
				AppStep = appStep;
				goto case 4;
			case 6:
				do
				{
					base._002Ector();
					_ = 0;
					if (!N50ov0NuA88LWQ6RVwe())
					{
						num = 10;
						continue;
					}
					num = 8;
					break;
				}
				while (false);
				continue;
			case 1:
				zltqcrHKLx = new AsyncRelayCommand(Rhqq6BfOIf, iUxquKnKiv);
				num = 2;
				if (true)
				{
					continue;
				}
				break;
			case 9:
				break;
			case 11:
				return;
			}
			_suspendElementsEvents = new ScopedCounter();
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IRuntimeService)hpu3Vv2LIJk94BB51EC(FttLad2KDhiwiLohhT0(NPGymfNzU614dUY0f6V(AppStep)))).SheetExecuted -= E3JqUoeNVe;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void E3JqUoeNVe(object P_0, CvsCogSessionResult P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qXimPo2wt1OJCAGr9Mf(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnSheetExecuted()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveElementAtAsync_003Ed__17))]
	public Task RemoveElementAtAsync(int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (ktpPHdNhRxSPcDDDnFM() ? 2 : 6);
		_003CRemoveElementAtAsync_003Ed__17 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E1__state = -1;
				num = 3;
				if (N50ov0NuA88LWQ6RVwe())
				{
					break;
				}
				goto case 1;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			case 4:
				stateMachine.index = index;
				goto case 5;
			default:
				num = 5;
				break;
			case 0:
			case 6:
				stateMachine._003C_003Et__builder = fY72xf2JWFpMIIQHwbT();
				goto case 1;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (ktpPHdNhRxSPcDDDnFM())
				{
				}
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CElements_CollectionChanged_003Ed__18))]
	private void VfTq7FTl98(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CElements_CollectionChanged_003Ed__18 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine.e = P_1;
				goto default;
			default:
				ktpPHdNhRxSPcDDDnFM();
				if (N50ov0NuA88LWQ6RVwe())
				{
					num = 1;
					if (true)
					{
						break;
					}
					goto case 4;
				}
				num = 6;
				break;
			case 4:
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 5:
				stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
				num = 0;
				break;
			case 1:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			case 0:
				stateMachine._003C_003E4__this = this;
				num = 2;
				if (false)
				{
					return;
				}
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnElementsChanged_003Ed__19))]
	protected virtual Task OnElementsChanged(NotifyCollectionChangedEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ktpPHdNhRxSPcDDDnFM();
		int num;
		if (N50ov0NuA88LWQ6RVwe())
		{
			num = 3;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_0076;
		IL_0044:
		_003COnElementsChanged_003Ed__19 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		num = 2;
		if (ktpPHdNhRxSPcDDDnFM())
		{
			goto IL_005c;
		}
		goto IL_0076;
		IL_005c:
		stateMachine._003C_003E1__state = -1;
		goto IL_002a;
		IL_002a:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (false)
		{
			goto IL_0044;
		}
		goto IL_0076;
		IL_0076:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 1:
			case 5:
				goto IL_0044;
			case 2:
				goto IL_005c;
			default:
				num = 4;
				continue;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = fY72xf2JWFpMIIQHwbT();
				goto IL_0044;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003C_selectedElement_PropertyChanged_003Ed__24))]
	private void sZ5qN6BPrD(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (!N50ov0NuA88LWQ6RVwe())
		{
			goto IL_001e;
		}
		goto IL_00a6;
		IL_001e:
		_003C_selectedElement_PropertyChanged_003Ed__24 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_0036;
		IL_00a6:
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 4:
			case 5:
				goto IL_0036;
			case 3:
				goto IL_0058;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 0;
				continue;
			case 0:
				stateMachine.e = P_1;
				break;
			default:
				num = 6;
				continue;
			case 7:
				return;
			}
			break;
			IL_0058:
			stateMachine._003C_003Et__builder = Lc01I42eoAIcbrCcSP7();
			_ = 0;
			num = (N50ov0NuA88LWQ6RVwe() ? 2 : 5);
		}
		goto IL_001e;
		IL_0036:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 7;
		if (ktpPHdNhRxSPcDDDnFM())
		{
		}
		goto IL_00a6;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnSelectedElementPropertyChanged_003Ed__25))]
	protected virtual Task OnSelectedElementPropertyChanged(string propertyName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (ktpPHdNhRxSPcDDDnFM() ? 4 : 3);
		_003COnSelectedElementPropertyChanged_003Ed__25 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = fY72xf2JWFpMIIQHwbT();
				num = 1;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				break;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	public abstract void ResetElements();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoAddElement_003Ed__30))]
	private Task chdqAcNk36(CellViewModel P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CDoAddElement_003Ed__30 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 6:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			case 5:
				stateMachine.dataCell = P_0;
				goto case 6;
			default:
				num = 6;
				break;
			case 2:
				stateMachine._003C_003Et__builder = fY72xf2JWFpMIIQHwbT();
				_ = 0;
				if (!N50ov0NuA88LWQ6RVwe())
				{
					num = 0;
					if (N50ov0NuA88LWQ6RVwe())
					{
						break;
					}
					goto case 5;
				}
				num = 3;
				break;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool qHjqd7j1i3(CellViewModel P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoRemoveElement_003Ed__35))]
	private Task Rhqq6BfOIf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CDoRemoveElement_003Ed__35 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
				stateMachine._003C_003Et__builder = fY72xf2JWFpMIIQHwbT();
				num = 1;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				ktpPHdNhRxSPcDDDnFM();
				num = (N50ov0NuA88LWQ6RVwe() ? 4 : 5);
				break;
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
	private bool iUxquKnKiv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SelectedElement != null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoMoveUpElement_003Ed__40))]
	private Task gJ3qFhNvPD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (N50ov0NuA88LWQ6RVwe())
		{
			num = 1;
			if (ktpPHdNhRxSPcDDDnFM())
			{
			}
		}
		else
		{
			num = 4;
		}
		_003CDoMoveUpElement_003Ed__40 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = fY72xf2JWFpMIIQHwbT();
				num = 5;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool GSSqXkONhT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Elements.IndexOf(SelectedElement) > 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoMoveDownElement_003Ed__45))]
	private Task AQpqohxSoN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		N50ov0NuA88LWQ6RVwe();
		int num = (ktpPHdNhRxSPcDDDnFM() ? 1 : 2);
		_003CDoMoveDownElement_003Ed__45 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 4;
				break;
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
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool w5LqSk93eB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (SelectedElement != null)
		{
			return Elements.IndexOf(SelectedElement) < Ce8xVa2O6Cu8xJvh8Lu(Elements) - 1;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void RaiseElementChanged()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		N50ov0NuA88LWQ6RVwe();
		int num;
		if (!ktpPHdNhRxSPcDDDnFM())
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
			if (!N50ov0NuA88LWQ6RVwe())
			{
				goto IL_004b;
			}
		}
		goto IL_0094;
		IL_002a:
		SYwDfL2ItSfdk9POviZ(RemoveElementCommand);
		goto IL_0077;
		IL_0094:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 1:
				goto IL_004b;
			case 0:
			case 3:
				goto IL_0062;
			case 2:
			case 5:
				goto IL_0077;
			default:
				num = 1;
				continue;
			case 6:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_0077:
		SYwDfL2ItSfdk9POviZ(MoveUpElementCommand);
		goto IL_004b;
		IL_0062:
		AddElementCommand.RaiseCanExecuteChanged();
		num = 4;
		goto IL_0094;
		IL_004b:
		SYwDfL2ItSfdk9POviZ(MoveDownElementCommand);
		num = 6;
		if (1 == 0)
		{
			goto IL_0062;
		}
		goto IL_0094;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected CellViewModel FindCellVm(CvsCellLocation cellLoc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		N50ov0NuA88LWQ6RVwe();
		int num;
		if (!ktpPHdNhRxSPcDDDnFM())
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
			if (ktpPHdNhRxSPcDDDnFM())
			{
				goto IL_0046;
			}
		}
		goto IL_0086;
		IL_006d:
		_003C_003Ec__DisplayClass48_0 obj = default;
		obj.cellLoc = cellLoc;
		goto IL_0046;
		IL_0086:
		List<IGrouping<string, CellViewModel>>.Enumerator enumerator = default;
		CellViewModel result = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			case 2:
				goto IL_0046;
			case 1:
			case 3:
				goto IL_006d;
			default:
				num = 2;
				continue;
			case 5:
				try
				{
					while (enumerator.MoveNext())
					{
						CellViewModel cellViewModel = enumerator.Current.FirstOrDefault(obj._003CFindCellVm_003Eb__0);
						ktpPHdNhRxSPcDDDnFM();
						int num2 = ((!N50ov0NuA88LWQ6RVwe()) ? 3 : 2);
						while (true)
						{
							switch (num2)
							{
							case 0:
							case 2:
								goto IL_0108;
							case 4:
								return result;
							}
							goto IL_00fb;
							IL_0108:
							if (cellViewModel == null)
							{
								break;
							}
							goto IL_00fb;
							IL_00fb:
							result = cellViewModel;
							num2 = 4;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
				}
				return null;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		obj = new _003C_003Ec__DisplayClass48_0();
		goto IL_006d;
		IL_0046:
		enumerator = ((EasyBuilderApplicationViewModel)NPGymfNzU614dUY0f6V(AppStep)).GetSourceablePrimitivesGrouped((CellViewModel)null, (Func<CellViewModel, bool>)null).ToList().GetEnumerator();
		num = 5;
		goto IL_0086;
	}

	public abstract Task RemoveSnippetReferences(EzSnippet snippet);

	[MethodImpl(MethodImplOptions.NoInlining)]
	static FormatDataBase()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		Logger = LogManager.GetLogger<FormatDataBase>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VpBLVJNt1PocOpvjF3m()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NPGymfNzU614dUY0f6V(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IInSightAppStep)P_0).AppViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hpu3Vv2LIJk94BB51EC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((RuntimeViewModel)P_0).RuntimeService;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool N50ov0NuA88LWQ6RVwe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ktpPHdNhRxSPcDDDnFM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FttLad2KDhiwiLohhT0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BaseIdeViewModel)P_0).Runtime;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DdkFlw25AES0KHobThn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IInSightAppStep)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qXimPo2wt1OJCAGr9Mf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((FormatDataBase)P_0).OnSheetExecuted();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder fY72xf2JWFpMIIQHwbT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object v0Kqio2aT9kR1c0ywhK(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncVoidMethodBuilder Lc01I42eoAIcbrCcSP7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncVoidMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Ce8xVa2O6Cu8xJvh8Lu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Collection<DataElement>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SYwDfL2ItSfdk9POviZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseRelayCommand)P_0).RaiseCanExecuteChanged();
	}
}
