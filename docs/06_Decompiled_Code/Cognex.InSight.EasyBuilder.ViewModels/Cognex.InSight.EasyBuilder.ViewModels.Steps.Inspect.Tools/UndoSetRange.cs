using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Undo;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;

public class UndoSetRange<T> : IUndoAction where T : struct, IEquatable<T>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDo_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoSetRange<T> _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((1 == 0) ? 2 : 5);
			UndoSetRange<T> undoSetRange = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					undoSetRange = _003C_003E4__this;
					num = 1;
					continue;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 1:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = undoSetRange.lAtuiJdRFS(undoSetRange.amruzbIb8B(), undoSetRange.XPHFpAwuco()).GetAwaiter();
							num3 = 2;
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
							case 7:
								return;
							case 5:
								_003C_003Eu__1 = default;
								goto case 1;
							case 3:
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								continue;
							case 8:
								_003C_003Eu__1 = awaiter;
								_ = 0;
								num3 = ((1 == 0) ? 1 : 4);
								continue;
							case 1:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								break;
							case 0:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
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
		internal static bool cGDQagK8G6HXlmBBgZw7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool d5j4pNK8oAojKFYDb9KZ()
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
	private struct _003CRedo_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoSetRange<T> _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((1 == 0) ? 3 : 2);
			int num2 = default;
			UndoSetRange<T> undoSetRange = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = undoSetRange.lAtuiJdRFS(undoSetRange.amruzbIb8B(), undoSetRange.XPHFpAwuco()).GetAwaiter();
							num3 = 0;
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
							case 2:
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								continue;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 0:
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									num3 = ((1 == 0) ? 8 : 7);
									continue;
								}
								break;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 5;
								continue;
							case 1:
							case 7:
								num2 = (_003C_003E1__state = 0);
								goto case 2;
							case 5:
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
					goto case 4;
				default:
					num = 4;
					continue;
				case 1:
				case 3:
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					break;
				case 6:
					return;
				}
				undoSetRange = _003C_003E4__this;
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
		internal static bool wEnpELK8SIvYNRmrRIoy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vnQpPFK8kaJ0EJNXyEs1()
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
	private struct _003CSaveState_003Ed__41 : IAsyncStateMachine
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
			_ = 0;
			int num = ((1 == 0) ? 4 : 3);
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					_003C_003Et__builder.SetResult();
					num = 5;
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = Task.CompletedTask.GetAwaiter();
							num3 = 1;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_ = 0;
							num3 = (true ? 2 : 4);
						}
						while (true)
						{
							switch (num3)
							{
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 2:
							case 5:
								_003C_003Eu__1 = default;
								goto case 4;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 3;
								continue;
							case 3:
								return;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 4:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
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
					goto case 2;
				default:
					num = 2;
					break;
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
		internal static bool f841gxK88YgcHX55iVFL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vtw32EK8q1bpwTlxLnTe()
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
	private struct _003CUndo_003Ed__42 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoSetRange<T> _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((1 == 0) ? 5 : 4);
			int num2 = default;
			UndoSetRange<T> undoSetRange = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = undoSetRange.lAtuiJdRFS(undoSetRange.FsMu9jgV0N(), undoSetRange.w63u8s2cay()).GetAwaiter();
							num3 = 7;
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
							case 0:
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								continue;
							case 2:
								return;
							case 7:
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									num3 = ((1 == 0) ? 8 : 0);
									continue;
								}
								break;
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								continue;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 2;
								continue;
							case 4:
								_003C_003Eu__1 = default;
								goto case 6;
							case 6:
							case 8:
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
					num = 2;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 5:
					undoSetRange = _003C_003E4__this;
					num = 3;
					continue;
				case 2:
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
		internal static bool Kb75XvK8EM2MHeCcDDfa()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Mx7A6QK8phxv7Zkwqyco()
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
	private struct _003CWrite_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UndoSetRange<T> _003C_003E4__this;

		public T min;

		public T max;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((1 == 0) ? 4 : 2);
			UndoSetRange<T> undoSetRange = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
					try
					{
						TaskAwaiter<CvsCellCollection> awaiter;
						if (num2 != 0)
						{
							Dictionary<string, object> inputs = new Dictionary<string, object>
							{
								{
									undoSetRange.dW3utB32LC(),
									min
								},
								{
									undoSetRange.MqfuVDTFc5(),
									max
								}
							};
							awaiter = undoSetRange.isXuK9TU90().CogSocket.Sheet.RunAndGetCellResults(inputs).GetAwaiter();
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
						EzTool ezTool = undoSetRange.Inspect.Tools.FirstOrDefault(undoSetRange.yEBukUcYCq);
						if (ezTool != null)
						{
							CellViewModel cellViewModel = null;
							CellViewModel cellViewModel2 = null;
							IEnumerator<CellViewModel> enumerator = ezTool.Properties.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									CellViewModel current = enumerator.Current;
									_ = 0;
									int num3 = ((1 == 0) ? 3 : 4);
									while (true)
									{
										switch (num3)
										{
										case 1:
										case 3:
											cellViewModel = current;
											break;
										default:
											num3 = 2;
											continue;
										case 0:
										case 4:
											if (!(current.CellName == undoSetRange.dW3utB32LC()))
											{
												if (current.CellName == undoSetRange.MqfuVDTFc5())
												{
													num3 = 5;
													continue;
												}
												break;
											}
											goto case 1;
										case 5:
											cellViewModel2 = current;
											num3 = 6;
											continue;
										case 2:
										case 6:
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
							cellViewModel?.Refresh(result, init: true);
							cellViewModel2?.Refresh(result, init: true);
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
				case 5:
					undoSetRange = _003C_003E4__this;
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
		internal static bool k5LbMqK8X4fWTuQMmmvv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JQRMmkK89XsX1T244PKX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private InspectStepViewModel PSLFNeCwcY;

	[CompilerGenerated]
	private string fH3FAHooKK;

	[CompilerGenerated]
	private string LdgFd6TBBg;

	[CompilerGenerated]
	private string xE1F6HKrtv;

	[CompilerGenerated]
	private T AvXFuLs82M;

	[CompilerGenerated]
	private T eTMFFhJsQC;

	[CompilerGenerated]
	private T JZ5FXQ3wqr;

	[CompilerGenerated]
	private T BbbFo9D8k2;

	private InspectStepViewModel Inspect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PSLFNeCwcY;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			PSLFNeCwcY = value;
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
			return string.Format(Resources.pd1hOYqP56(), rXSuqOSaoi(dW3utB32LC(), MqfuVDTFc5()), IHQu2Ecm1J(FsMu9jgV0N(), w63u8s2cay()), IHQu2Ecm1J(amruzbIb8B(), XPHFpAwuco()));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UndoSetRange(InspectStepViewModel inspect, string toolName, string minCellName, string maxCellName, T oldMin, T oldMax, T newMin, T newMax)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		base._002Ector();
		Inspect = inspect;
		lbUuZlG90R(toolName);
		HgRuYQCjok(minCellName);
		cXQuLPmv1G(maxCellName);
		uXPur2i1P1(oldMin);
		DfMum5cC5M(oldMax);
		mOoFal4ao2(newMin);
		lGDFU689Jv(newMax);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private CvsInSight isXuK9TU90()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Inspect.InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private string MAJuByp2r2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return fH3FAHooKK;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void lbUuZlG90R(string value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		fH3FAHooKK = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private string dW3utB32LC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return LdgFd6TBBg;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void HgRuYQCjok(string value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		LdgFd6TBBg = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private string MqfuVDTFc5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return xE1F6HKrtv;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void cXQuLPmv1G(string value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xE1F6HKrtv = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private T FsMu9jgV0N()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AvXFuLs82M;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void uXPur2i1P1(T value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		AvXFuLs82M = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private T w63u8s2cay()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return eTMFFhJsQC;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void DfMum5cC5M(T value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		eTMFFhJsQC = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private T amruzbIb8B()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return JZ5FXQ3wqr;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void mOoFal4ao2(T value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		JZ5FXQ3wqr = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private T XPHFpAwuco()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return BbbFo9D8k2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void lGDFU689Jv(T value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		BbbFo9D8k2 = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string IHQu2Ecm1J(T jRjn0I1J2fnVqURg2Z, T N1pGPJZjQL52qQAnAL)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (typeof(T).Equals(typeof(double)))
		{
			return string.Format(CdQUGaROfy7He9T0foW.KbIzwHEDLa(5348), jRjn0I1J2fnVqURg2Z, N1pGPJZjQL52qQAnAL);
		}
		return string.Format(CdQUGaROfy7He9T0foW.KbIzwHEDLa(5396), jRjn0I1J2fnVqURg2Z, N1pGPJZjQL52qQAnAL);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string rXSuqOSaoi(string P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(5418) + P_0 + CdQUGaROfy7He9T0foW.KbIzwHEDLa(5424) + P_1 + CdQUGaROfy7He9T0foW.KbIzwHEDLa(5430);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(UndoSetRange<>._003CDo_003Ed__39))]
	public Task Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((1 == 0) ? 2 : 5);
		_003CDo_003Ed__39 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 1;
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 4;
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
	[AsyncStateMachine(typeof(UndoSetRange<>._003CRedo_003Ed__40))]
	public Task Redo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CRedo_003Ed__40 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				_ = 0;
				num = (true ? 5 : 0);
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
	[AsyncStateMachine(typeof(UndoSetRange<>._003CSaveState_003Ed__41))]
	public Task SaveState()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((1 == 0) ? 4 : 2);
		_003CSaveState_003Ed__41 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				break;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(UndoSetRange<>._003CUndo_003Ed__42))]
	public Task Undo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CUndo_003Ed__42 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 0;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				_ = 0;
				num = (true ? 4 : 0);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(UndoSetRange<>._003CWrite_003Ed__43))]
	private Task lAtuiJdRFS(T LhnmgIOXs3n80klMtj, T j1XLVJgSbqEmpHdJak)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CWrite_003Ed__43 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.min = LhnmgIOXs3n80klMtj;
		stateMachine.max = j1XLVJgSbqEmpHdJak;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool yEBukUcYCq(EzTool P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0.Name == MAJuByp2r2();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qjcrXosDQ1wL3hasxus()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CHcaRYsidluXJVKOWup()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
