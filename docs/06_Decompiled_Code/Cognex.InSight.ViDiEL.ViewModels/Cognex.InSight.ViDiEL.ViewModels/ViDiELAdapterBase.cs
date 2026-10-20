using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
using Cognex.Diagnostics.Logging;
using jUKn21pup6XFIrInBb;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels;

public abstract class ViDiELAdapterBase : IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSkip_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELAdapterBase _003C_003E4__this;

		public string toolId;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_01d3;
			IL_001a:
			ViDiELAdapterBase viDiELAdapterBase = _003C_003E4__this;
			num = 0;
			if (false)
			{
				goto IL_002d;
			}
			goto IL_01d3;
			IL_01d3:
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					break;
				case 2:
					goto IL_002d;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 0:
					try
					{
						int num3;
						if (num2 != 0)
						{
							viDiELAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 1;
							if (false)
							{
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							rjM0gvFw0BJM4snhelU();
							if (t6G9YnFNAOmKpIAPWU4())
							{
								num3 = 3;
								if (1 == 0)
								{
									goto IL_00a5;
								}
							}
							else
							{
								num3 = 4;
								if (false)
								{
									goto IL_012f;
								}
							}
						}
						goto IL_00be;
						IL_012f:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						goto IL_00be;
						IL_00a5:
						_003C_003Eu__1 = awaiter;
						goto IL_00f9;
						IL_00f9:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 9;
						goto IL_00be;
						IL_00be:
						while (true)
						{
							switch (num3)
							{
							case 9:
								return;
							case 5:
								break;
							default:
								num3 = 8;
								continue;
							case 8:
								goto IL_00f9;
							case 3:
							case 6:
								_003C_003Eu__1 = default;
								goto IL_012f;
							case 4:
							case 7:
								goto IL_012f;
							case 1:
								if (viDiELAdapterBase.ttlI9CT0dN != null)
								{
									awaiter = DrqlBIFpu1UGwAHXnJR(viDiELAdapterBase.ttlI9CT0dN());
									num3 = 0;
									continue;
								}
								goto end_IL_005f;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								goto case 10;
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								if (0 == 0)
								{
									continue;
								}
								goto case 10;
							case 10:
								awaiter.GetResult();
								goto end_IL_005f;
							}
							break;
						}
						goto IL_00a5;
						end_IL_005f:;
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
				break;
			}
			goto IL_001a;
			IL_002d:
			num2 = _003C_003E1__state;
			_ = 1;
			if (!rjM0gvFw0BJM4snhelU())
			{
				num = 4;
			}
			else
			{
				num = 5;
				if (rjM0gvFw0BJM4snhelU())
				{
					return;
				}
			}
			goto IL_01d3;
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
		internal static TaskAwaiter DrqlBIFpu1UGwAHXnJR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool t6G9YnFNAOmKpIAPWU4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rjM0gvFw0BJM4snhelU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	protected static readonly ILogger Logger;

	private readonly Func<Task> ttlI9CT0dN;

	private bool lNpIAP2ZFg;

	protected readonly Dispatcher _mainThreadDispatcher;

	protected readonly CancellationTokenSource CancellationSource;

	[CompilerGenerated]
	private readonly CvsInSight R9RIy0ljAQ;

	protected CvsInSight InSight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return R9RIy0ljAQ;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected ViDiELAdapterBase(CvsInSight inSight, Func<Task> triggerAcquisition = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		CancellationSource = new CancellationTokenSource();
		base._002Ector();
		R9RIy0ljAQ = inSight;
		ttlI9CT0dN = triggerAcquisition;
		if (!Dispatcher.CurrentDispatcher.Thread.IsThreadPoolThread)
		{
			_mainThreadDispatcher = Dispatcher.CurrentDispatcher;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearCaches(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ThrowIfToolIdInvalid(toolId);
		eaIPnyy9HQN2iy5VEY(this, toolId);
	}

	protected abstract void InternalClearCaches(string toolId);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSkip_003Ed__11))]
	public Task Skip(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CSkip_003Ed__11 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine.toolId = toolId;
				goto case 5;
			default:
				num = 5;
				break;
			case 0:
				stateMachine._003C_003Et__builder = AExePlnBo3jtHZNvjR();
				p1NbBLlpPebSRQViHY();
				num = (dhDn677VYWYCif651J() ? 3 : 6);
				break;
			case 3:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 1:
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void ThrowIfToolIdInvalid(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (IiOG7Xf0htdIWBvw5L(toolId))
		{
			throw new ArgumentException((string)cwFFwIzGbbK5TgXDwU(766), plfGltUiaC1OFfC2I8.OIRNC4VQ7F(832));
		}
	}

	protected abstract ResourceNode GetToolNode(string toolId);

	protected abstract Task RunToolAsync();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Conditional("DEBUG")]
	protected void RetrievedFromCameraDebug([CallerMemberName] string memberName = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		dhDn677VYWYCif651J();
		int num;
		if (p1NbBLlpPebSRQViHY())
		{
			num = 3;
		}
		else
		{
			num = 1;
			if (false)
			{
				goto IL_00a6;
			}
		}
		goto IL_0077;
		IL_00a6:
		if (!lNpIAP2ZFg)
		{
			lNpIAP2ZFg = true;
			goto IL_0028;
		}
		num = 4;
		goto IL_0077;
		IL_0028:
		try
		{
			IPWB3EX20y9ic7E4NN3(CancellationSource);
			yI3PWwXXpOJMYx5fGtQ(CancellationSource);
		}
		catch (Exception ex)
		{
			oxBivpXMAIeddjfsrqN(ex);
		}
		K9laOSXkBkrpWI2vKki(this);
		num = 5;
		goto IL_0077;
		IL_0077:
		switch (num)
		{
		case 4:
			return;
		case 0:
		case 3:
			goto IL_00a6;
		case 5:
			return;
		}
		goto IL_0028;
	}

	protected abstract void InternalDisposeCaches();

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ViDiELAdapterBase()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IuqUlaXmFVNc3WGv8Hx();
		Logger = LogManager.GetLogger<ViDiELAdapterBase>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eaIPnyy9HQN2iy5VEY(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ViDiELAdapterBase)P_0).InternalClearCaches((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool p1NbBLlpPebSRQViHY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dhDn677VYWYCif651J()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder AExePlnBo3jtHZNvjR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IiOG7Xf0htdIWBvw5L(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cwFFwIzGbbK5TgXDwU(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IPWB3EX20y9ic7E4NN3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CancellationTokenSource)P_0).Cancel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yI3PWwXXpOJMYx5fGtQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CancellationTokenSource)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oxBivpXMAIeddjfsrqN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Console.WriteLine(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void K9laOSXkBkrpWI2vKki(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ViDiELAdapterBase)P_0).InternalDisposeCaches();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IuqUlaXmFVNc3WGv8Hx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}
}
