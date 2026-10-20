using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Internal;
using Cognex.InSight.Runtime;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Image.AcquireActions;

public class CameraAcquireAction : IAcquireAction
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAcquire_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CameraAcquireAction _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (Y0feGD5w1c3kWt3rOmZT() ? 3 : 4);
			int num2 = default;
			CameraAcquireAction cameraAcquireAction = default;
			TaskAwaiter awaiter = default;
			do
			{
				IL_01d1:
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 2:
					try
					{
						object obj2;
						int num3;
						if (num2 != 0)
						{
							CvsInSight jBMecaTCR = cameraAcquireAction.jBMecaTCR3;
							if (jBMecaTCR != null)
							{
								object obj = S8qAhA5wuOdINJYodrfP(jBMecaTCR);
								if (obj == null)
								{
									goto IL_013d;
								}
								obj2 = U4rWyo5whGiuVxpTY6GB(obj);
								goto IL_0148;
							}
							Y0feGD5w1c3kWt3rOmZT();
							num3 = ((!KvVj2L5wcKDY3qaNgi8F()) ? 3 : 9);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
						}
						goto IL_00c7;
						IL_0148:
						if (obj2 != null)
						{
							awaiter = o3OpUu5JKSa7Zgu7KShP(D3ZSUJ5JLlkoH7Ao3YVQ(Bb30825wzDIDYDNhYhIW(AdTxCA5wtWtAQKQliXOQ(cameraAcquireAction.jBMecaTCR3))));
							num3 = 2;
							goto IL_00c7;
						}
						goto end_IL_003b;
						IL_013d:
						obj2 = null;
						goto IL_0148;
						IL_00c7:
						while (true)
						{
							switch (num3)
							{
							case 4:
								_003C_003Eu__1 = default;
								num3 = 5;
								continue;
							case 6:
								return;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 7;
							case 7:
								_003C_003Eu__1 = awaiter;
								goto case 8;
							default:
								num3 = 8;
								continue;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (KvVj2L5wcKDY3qaNgi8F())
								{
									continue;
								}
								goto case 0;
							case 0:
							case 9:
								obj2 = null;
								goto IL_0148;
							case 1:
							case 3:
								break;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 7;
									continue;
								}
								goto case 10;
							case 10:
								awaiter.GetResult();
								goto end_IL_003b;
							}
							break;
						}
						goto IL_013d;
						end_IL_003b:;
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
					if (!Y0feGD5w1c3kWt3rOmZT())
					{
						goto IL_01d1;
					}
					goto case 1;
				case 1:
				case 3:
					cameraAcquireAction = _003C_003E4__this;
					num = 2;
					goto IL_01d1;
				case 5:
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
		internal static object S8qAhA5wuOdINJYodrfP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object U4rWyo5whGiuVxpTY6GB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Acq;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AdTxCA5wtWtAQKQliXOQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Bb30825wzDIDYDNhYhIW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Acq;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object D3ZSUJ5JLlkoH7Ao3YVQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ICogSocketAcq)P_0).ManualTriggerAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter o3OpUu5JKSa7Zgu7KShP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KvVj2L5wcKDY3qaNgi8F()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Y0feGD5w1c3kWt3rOmZT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly CvsInSight jBMecaTCR3;

	public bool IsPlayback
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CameraAcquireAction(CvsInSight insight)
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
			case 3:
				UteJxPmWnFeVv8mrBUE();
				Yq9qtHmAGWsWGAMRlvn();
				if (!Ommd5DmRxeq0spjwbdb())
				{
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto case 1;
				}
				num = 0;
				continue;
			case 1:
			case 4:
				base._002Ector();
				break;
			case 5:
				return;
			}
			jBMecaTCR3 = insight;
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAcquire_003Ed__4))]
	public Task Acquire()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Yq9qtHmAGWsWGAMRlvn();
		int num;
		if (!Ommd5DmRxeq0spjwbdb())
		{
			num = 3;
			if (!Yq9qtHmAGWsWGAMRlvn())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 2;
			if (!Yq9qtHmAGWsWGAMRlvn())
			{
				goto IL_00cf;
			}
		}
		goto IL_0048;
		IL_008b:
		_003CAcquire_003Ed__4 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (Ommd5DmRxeq0spjwbdb())
		{
		}
		goto IL_0048;
		IL_00cf:
		return stateMachine._003C_003Et__builder.Task;
		IL_002e:
		stateMachine._003C_003E1__state = -1;
		goto IL_008b;
		IL_0048:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			default:
				num = 4;
				continue;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (Yq9qtHmAGWsWGAMRlvn())
				{
					continue;
				}
				goto IL_008b;
			case 4:
				goto IL_008b;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = I6yseMmTFNM5A0YjrOU();
				goto case 1;
			case 6:
				goto IL_00cf;
			}
			break;
		}
		goto IL_002e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UteJxPmWnFeVv8mrBUE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Yq9qtHmAGWsWGAMRlvn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Ommd5DmRxeq0spjwbdb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder I6yseMmTFNM5A0YjrOU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
