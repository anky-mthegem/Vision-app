using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Outputs;

public class OutputsSnippet : IoSnippet
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRemoveReferences_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public OutputsSnippet _003C_003E4__this;

		public SnippetPreRemoveEventArgs e;

		private TaskAwaiter _003C_003Eu__1;

		private IEnumerator<Output> _003C_003E7__wrap1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			OutputsSnippet outputsSnippet = default;
			TaskAwaiter awaiter = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 4:
					outputsSnippet = _003C_003E4__this;
					_ = 1;
					if (!zR66rFKlXgIymXlnAwQ8())
					{
						num = 5;
						continue;
					}
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 2:
				case 5:
					try
					{
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								goto IL_00cd;
							}
							awaiter = qNZ00MKl992Vt84BGMBA(outputsSnippet.bPN7AhyhsB(e));
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
						_003C_003E7__wrap1 = outputsSnippet.Outputs.GetEnumerator();
						goto IL_00cd;
						IL_00cd:
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
								num3 = 3;
							}
							while (true)
							{
								switch (num3)
								{
								case 5:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 9;
									if (uIAI9HKlpMo3ooS5egXw())
									{
										continue;
									}
									goto case 0;
								case 0:
								case 6:
									num2 = (_003C_003E1__state = -1);
									num3 = 4;
									continue;
								case 4:
									awaiter.GetResult();
									num3 = 10;
									continue;
								case 3:
									_003C_003Eu__1 = default;
									goto case 0;
								case 1:
								case 8:
									if (!awaiter.IsCompleted)
									{
										num3 = 2;
										continue;
									}
									goto case 4;
								case 9:
									return;
								case 2:
									break;
								case 7:
								case 10:
									if (!aM8n7JKl3AwUb5QXCLX7(_003C_003E7__wrap1))
									{
										goto end_IL_0105;
									}
									awaiter = qNZ00MKl992Vt84BGMBA(KYCo0tKl7AGFvdByZpWI(MT7wffKl4PADhFCgPyXs(_003C_003E7__wrap1.Current), e));
									uIAI9HKlpMo3ooS5egXw();
									if (zR66rFKlXgIymXlnAwQ8())
									{
										num3 = 0;
										if (0 == 0)
										{
											continue;
										}
										goto case 1;
									}
									num3 = 8;
									if (!zR66rFKlXgIymXlnAwQ8())
									{
										continue;
									}
									break;
								}
								num2 = (_003C_003E1__state = 1);
								num3 = 5;
								continue;
								end_IL_0105:
								break;
							}
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								L2NTCcKljx4xYXkyvoa3(_003C_003E7__wrap1);
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
				case 0:
					break;
				case 6:
					return;
				}
				num2 = _003C_003E1__state;
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
		internal static TaskAwaiter qNZ00MKl992Vt84BGMBA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MT7wffKl4PADhFCgPyXs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Output)P_0).Signal;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KYCo0tKl7AGFvdByZpWI(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((OutputLinksViewModel)P_0).vlFODZL8Hh((SnippetPreRemoveEventArgs)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aM8n7JKl3AwUb5QXCLX7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void L2NTCcKljx4xYXkyvoa3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uIAI9HKlpMo3ooS5egXw()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zR66rFKlXgIymXlnAwQ8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public int index;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass10_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			GNOGXyKlAZLpy2JoDhMt();
			yXSQouKlRU6o7pJbAXHp(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetByIndex_003Eb__0(Output output)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P3c2mwKlTs8Pqrghb3hQ(qRBhSLKlWNMhqekKwtab(output)) == index;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GNOGXyKlAZLpy2JoDhMt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yXSQouKlRU6o7pJbAXHp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KVTChDKl6wMR1pHYLefP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sHOf87KlCsVCDIbP9JOK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qRBhSLKlWNMhqekKwtab(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Output)P_0).Line;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int P3c2mwKlTs8Pqrghb3hQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IntViewModel)P_0).Value;
		}
	}

	private bool fiE7dh245D;

	[CompilerGenerated]
	private readonly ObservableCollection<Output> WrU76EBHjP;

	public override string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)GIK2ssI6Pgk4YZ6kU1d();
		}
	}

	public ObservableCollection<Output> Outputs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WrU76EBHjP;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OutputsSnippet(AppStepViewModel appStepVm)
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
			default:
				base._002Ector(appStepVm);
				num = 5;
				continue;
			case 0:
			case 1:
				WrU76EBHjP = new ObservableCollection<Output>();
				goto default;
			case 3:
				break;
			case 5:
				return;
			}
			do
			{
				x1CJ8jIjLpBylehqIA9();
				_ = 0;
				if (!vqeEyaI7eRJBn03leoo())
				{
					num = 4;
					continue;
				}
				num = 0;
				if (0 == 0)
				{
					break;
				}
				return;
			}
			while (false);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Refresh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		IEnumerator<Output> enumerator = default;
		CvsCellCollection cvsCellCollection = default;
		while (true)
		{
			object obj2;
			switch (num)
			{
			case 1:
			case 6:
				obj2 = null;
				goto IL_0061;
			case 4:
				enumerator = Outputs.GetEnumerator();
				num = 7;
				break;
			case 0:
			case 2:
				obj2 = null;
				goto IL_0061;
			default:
				num = 5;
				break;
			case 5:
				if (fiE7dh245D)
				{
					num = 4;
					break;
				}
				return;
			case 3:
			{
				CvsInSight inSight = InSight;
				if (inSight != null)
				{
					object obj = eA12nXICF0oDm0dEZMF(inSight);
					if (obj == null)
					{
						goto case 0;
					}
					obj2 = LTvMhWIAbxLsQgTpojL(obj);
					goto IL_0061;
				}
				dlqIE6I3dqLPyy9Vb51();
				if (!vqeEyaI7eRJBn03leoo())
				{
					num = 0;
					if (vqeEyaI7eRJBn03leoo())
					{
						break;
					}
					goto case 4;
				}
				num = 6;
				break;
			}
			case 7:
				{
					try
					{
						while (tls2IqIWn4yGBtpKygh(enumerator))
						{
							EouAO3IRw9c5PwmgKcq(enumerator.Current, cvsCellCollection);
						}
						return;
					}
					finally
					{
						if (enumerator != null)
						{
							ddUG0uITAqeOELCo6Ws(enumerator);
						}
					}
				}
				IL_0061:
				cvsCellCollection = (CvsCellCollection)obj2;
				if (cvsCellCollection != null)
				{
					goto case 5;
				}
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Task Parse(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0043;
		IL_00a2:
		int num3 = default;
		int num2 = num3;
		CvsCellRange cellRange = CellRange;
		CvsCellLocation location = default;
		if (num2 < cellRange.LastRow)
		{
			location.Row = num3;
			goto IL_00dd;
		}
		num = 0;
		goto IL_0043;
		IL_00dd:
		ObservableCollection<Output> outputs = Outputs;
		AppStepViewModel parent = Parent;
		CvsCellLocation signalLocation = location;
		int lineIndex = num3 - (CellRange.Row + 2);
		cellRange = CellRange;
		outputs.Add(new Output(parent, cells, signalLocation, lineIndex, cellRange.LastColumn));
		num = 7;
		goto IL_0043;
		IL_0043:
		while (true)
		{
			switch (num)
			{
			case 4:
			case 6:
				break;
			default:
				num = 9;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				location = cellRange.Location;
				_ = 1;
				if (!dlqIE6I3dqLPyy9Vb51())
				{
					num = 8;
					continue;
				}
				num = 6;
				if (!dlqIE6I3dqLPyy9Vb51())
				{
					continue;
				}
				goto IL_00dd;
			case 2:
				goto IL_00a2;
			case 3:
			case 8:
				cellRange = CellRange;
				break;
			case 9:
				goto IL_00dd;
			case 0:
				fiE7dh245D = true;
				num = 11;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
				cellRange = CellRange;
				num = 5;
				continue;
			case 10:
				dEDnpEIyQKbDSPAPLDE(Outputs);
				num = 1;
				continue;
			case 7:
				num3++;
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				goto case 11;
			case 11:
				return (Task)PO1UPMI0U0h4xp3VZNf();
			}
			break;
		}
		goto IL_001a;
		IL_001a:
		num3 = cellRange.Row + 2;
		goto IL_00a2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveReferences_003Ed__9))]
	public override Task RemoveReferences(SnippetPreRemoveEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		vqeEyaI7eRJBn03leoo();
		int num = ((!dlqIE6I3dqLPyy9Vb51()) ? 1 : 4);
		_003CRemoveReferences_003Ed__9 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				continue;
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 2:
			case 4:
				stateMachine.e = e;
				goto case 3;
			default:
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = lDBb9EIFIwWkkZHM5Gr();
				num = 5;
				if (!dlqIE6I3dqLPyy9Vb51())
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
	public Output GetByIndex(int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass10_0();
		CS_0024_003C_003E8__locals2.index = index;
		return Outputs.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (Output output) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec__DisplayClass10_0.P3c2mwKlTs8Pqrghb3hQ(_003C_003Ec__DisplayClass10_0.qRBhSLKlWNMhqekKwtab(output)) == CS_0024_003C_003E8__locals2.index;
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task bPN7AhyhsB(SnippetPreRemoveEventArgs P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.RemoveReferences(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void x1CJ8jIjLpBylehqIA9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vqeEyaI7eRJBn03leoo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dlqIE6I3dqLPyy9Vb51()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GIK2ssI6Pgk4YZ6kU1d()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.GutLPQjZrH();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eA12nXICF0oDm0dEZMF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Results;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LTvMhWIAbxLsQgTpojL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsResultSet)P_0).Cells;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EouAO3IRw9c5PwmgKcq(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Output)P_0).Refresh((CvsCellCollection)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tls2IqIWn4yGBtpKygh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ddUG0uITAqeOELCo6Ws(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dEDnpEIyQKbDSPAPLDE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Collection<Output>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PO1UPMI0U0h4xp3VZNf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder lDBb9EIFIwWkkZHM5Gr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
