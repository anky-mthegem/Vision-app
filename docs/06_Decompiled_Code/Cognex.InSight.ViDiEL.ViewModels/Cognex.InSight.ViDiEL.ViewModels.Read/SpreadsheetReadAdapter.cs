using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Internal;
using jUKn21pup6XFIrInBb;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.Read;

public class SpreadsheetReadAdapter : ReadAdapterBase
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRunToolAsync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SpreadsheetReadAdapter _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
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
			goto IL_01d3;
			IL_001a:
			int num2 = _003C_003E1__state;
			yJVA6NBJ7yjmhkI9slq();
			num = ((!gkrLtgBYUWW5BaaVr4L()) ? 4 : 2);
			goto IL_01d3;
			IL_01d3:
			TaskAwaiter awaiter = default;
			SpreadsheetReadAdapter spreadsheetReadAdapter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (!yJVA6NBJ7yjmhkI9slq())
					{
						continue;
					}
					goto case 5;
				case 5:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
							if (1 == 0)
							{
								goto IL_00ad;
							}
							goto IL_00c6;
						}
						if (spreadsheetReadAdapter.RunToolCallback != null)
						{
							num3 = 0;
							goto IL_00c6;
						}
						dxsTi9BA53RuFs18oi8(EEux8ECcYW, zGwObXBCNwwVTBFCfYg(7602));
						goto end_IL_0056;
						IL_00c6:
						while (true)
						{
							switch (num3)
							{
							case 6:
								_003C_003Eu__1 = default;
								num3 = 5;
								continue;
							case 4:
								break;
							case 7:
								goto IL_00ad;
							default:
								num3 = 4;
								continue;
							case 9:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 2:
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 1:
							case 3:
								if (awaiter.IsCompleted)
								{
									goto case 9;
								}
								goto case 2;
							case 0:
								awaiter = mNTLmpBKjPsXQYo9NwO(spreadsheetReadAdapter.RunToolCallback());
								gkrLtgBYUWW5BaaVr4L();
								if (yJVA6NBJ7yjmhkI9slq())
								{
									num3 = 8;
									continue;
								}
								num3 = 3;
								if (0 == 0)
								{
									continue;
								}
								goto case 5;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 10:
								goto end_IL_0056;
							}
							break;
						}
						goto IL_0087;
						IL_00ad:
						_003C_003Eu__1 = awaiter;
						goto IL_0087;
						IL_0087:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_0056:;
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
				case 2:
					spreadsheetReadAdapter = _003C_003E4__this;
					num = 5;
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
		internal static TaskAwaiter mNTLmpBKjPsXQYo9NwO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zGwObXBCNwwVTBFCfYg(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void dxsTi9BA53RuFs18oi8(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).Warn((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gkrLtgBYUWW5BaaVr4L()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yJVA6NBJ7yjmhkI9slq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly ILogger EEux8ECcYW;

	private static SpreadsheetReadAdapter ksrx14Zsco;

	[CompilerGenerated]
	private EventHandler<FlexibleFieldingEventArgs> ASWxD6nTYH;

	[CompilerGenerated]
	private Func<Task> NT8xjKcE0D;

	public Func<Task> RunToolCallback
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return NT8xjKcE0D;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NT8xjKcE0D = value;
		}
	}

	public event EventHandler<FlexibleFieldingEventArgs> FlexibleFieldingChangedEvent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<FlexibleFieldingEventArgs> eventHandler = ASWxD6nTYH;
			EventHandler<FlexibleFieldingEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FlexibleFieldingEventArgs> value2 = (EventHandler<FlexibleFieldingEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref ASWxD6nTYH, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<FlexibleFieldingEventArgs> eventHandler = ASWxD6nTYH;
			EventHandler<FlexibleFieldingEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FlexibleFieldingEventArgs> value2 = (EventHandler<FlexibleFieldingEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref ASWxD6nTYH, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SpreadsheetReadAdapter GetInstance(CvsInSight insight, Func<Task> triggerAcquisition = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ksrx14Zsco ?? (ksrx14Zsco = new SpreadsheetReadAdapter(insight, triggerAcquisition));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SpreadsheetReadAdapter(CvsInSight insight, Func<Task> triggerAcquisition = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		base._002Ector(insight, triggerAcquisition);
		FlexibleFieldingChanged += FY6xESH81e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FY6xESH81e(object P_0, FlexibleFieldingEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ASWxD6nTYH?.Invoke(this, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public new void OnNewResult(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base.OnNewResult(toolId);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override ResourceNode GetToolNode(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (ResourceNode)pSG5OAmxIMfr1vAWAu9(rBOb4gmBns4BcPwWvKS(n3PnssmucFXfXWKhcv3(InSight)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRunToolAsync_003Ed__14))]
	protected override Task RunToolAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CRunToolAsync_003Ed__14 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 4:
				stateMachine._003C_003Et__builder = VLH8sumhP9KV7WbvEr7();
				_ = 0;
				num = ((!tgK4qBmopqMqd2L0qgI()) ? 2 : 0);
				continue;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (true)
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
	static SpreadsheetReadAdapter()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		q71fDFmUVyqtgLHeNN2();
		EEux8ECcYW = LogManager.GetLogger<SpreadsheetReadAdapter>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tgK4qBmopqMqd2L0qgI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wEExOCmcqAb0xVVgyyh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object n3PnssmucFXfXWKhcv3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).CogSocket;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rBOb4gmBns4BcPwWvKS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).Sheet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pSG5OAmxIMfr1vAWAu9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocketSheet)P_0).PropertySheetResourceNode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder VLH8sumhP9KV7WbvEr7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void q71fDFmUVyqtgLHeNN2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}
}
