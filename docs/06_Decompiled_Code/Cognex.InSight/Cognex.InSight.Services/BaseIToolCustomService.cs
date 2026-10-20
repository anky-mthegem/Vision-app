using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Services;

public class BaseIToolCustomService : IBaseIToolCustomService
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRunChangeAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public BaseIToolCustomService _003C_003E4__this;

		private TaskAwaiter<CvsPropertySheetResult> _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			BaseIToolCustomService baseIToolCustomService = default;
			TaskAwaiter<CvsCogSheetResult> awaiter = default;
			TaskAwaiter<CvsPropertySheetResult> awaiter2 = default;
			CvsPropertySheetResult result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					_ = 1;
					if (!pmw8q5sY6wj9Sw7iXYLR())
					{
						num = 4;
						continue;
					}
					num = 2;
					if (true)
					{
						continue;
					}
					break;
				case 1:
				case 4:
					baseIToolCustomService = _003C_003E4__this;
					num = 5;
					continue;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 14;
								if (false)
								{
									goto IL_0094;
								}
							}
							else
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 0;
							if (!gX8I8msYb6eUmvMurIc8())
							{
								goto IL_0174;
							}
						}
						goto IL_021f;
						IL_0094:
						awaiter = ((CvsCogSocketSheet)G6mBP2sY4d2Uc1BlJKYX(zA6m4CsY0ATSk3hnobVw(baseIToolCustomService.rQ3qyB2XUP))).RunAsync(true).GetAwaiter();
						num3 = 7;
						goto IL_021f;
						IL_021f:
						while (true)
						{
							switch (num3)
							{
							case 8:
								break;
							case 9:
								goto IL_0094;
							case 3:
								return;
							case 1:
								if (!awaiter2.IsCompleted)
								{
									num3 = 10;
									if (gX8I8msYb6eUmvMurIc8())
									{
										continue;
									}
									goto case 10;
								}
								goto case 16;
							case 10:
								num2 = (_003C_003E1__state = 0);
								_ = 0;
								if (gX8I8msYb6eUmvMurIc8())
								{
									num3 = 2;
									if (0 == 0)
									{
										continue;
									}
									goto case 14;
								}
								num3 = 12;
								continue;
							case 14:
							{
								CvsPropSheet propSheet = baseIToolCustomService.rQ3qyB2XUP.PropSheet;
								if (propSheet != null)
								{
									if (propSheet.IsEditInProgress)
									{
										awaiter2 = baseIToolCustomService.rQ3qyB2XUP.PropSheet.RunUsingPreviousExpression().GetAwaiter();
										num3 = 1;
										continue;
									}
									goto IL_0094;
								}
								num3 = 9;
								if (!pmw8q5sY6wj9Sw7iXYLR())
								{
									continue;
								}
								goto case 16;
							}
							case 16:
								result = awaiter2.GetResult();
								num3 = 11;
								continue;
							case 5:
								return;
							case 15:
								goto IL_0174;
							case 12:
							case 13:
								_003C_003Eu__2 = awaiter;
								num3 = 15;
								if (gX8I8msYb6eUmvMurIc8())
								{
									continue;
								}
								goto case 2;
							case 2:
							case 4:
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 5;
								continue;
							case 11:
							{
								EventHandler eventHandler = baseIToolCustomService.JT4qVFIwTU;
								if (eventHandler == null)
								{
									break;
								}
								fCQCCYsYpAETxTo0NJut(eventHandler, baseIToolCustomService, new PropertySheetChangedEventArgs(result));
								num3 = 8;
								continue;
							}
							case 6:
								num2 = (_003C_003E1__state = 1);
								goto case 12;
							case 17:
								num2 = (_003C_003E1__state = -1);
								goto case 16;
							default:
								num3 = 16;
								continue;
							case 0:
								_003C_003Eu__1 = default;
								num3 = 17;
								if (true)
								{
									continue;
								}
								goto case 7;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								goto case 18;
							case 18:
								awaiter.GetResult();
								break;
							}
							break;
						}
						goto end_IL_0046;
						IL_0174:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 3;
						goto IL_021f;
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
		internal static void fCQCCYsYpAETxTo0NJut(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0(P_1, (EventArgs)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zA6m4CsY0ATSk3hnobVw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object G6mBP2sY4d2Uc1BlJKYX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gX8I8msYb6eUmvMurIc8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pmw8q5sY6wj9Sw7iXYLR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly CvsInSight rQ3qyB2XUP;

	[CompilerGenerated]
	private EventHandler JT4qVFIwTU;

	[CompilerGenerated]
	private readonly ResourceNode EViqvHEOqX;

	protected ResourceNode CellEditData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EViqvHEOqX;
		}
	}

	public event EventHandler IToolPropertyChanged
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
			int num = ((!NmX4H6KO4frhrCASx87()) ? 2 : 5);
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					goto case 6;
				default:
					num = 6;
					break;
				case 3:
					eventHandler2 = eventHandler;
					num = 1;
					if (byo18KKMBS9NOCjJvy1())
					{
					}
					break;
				case 2:
				case 4:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						break;
					}
					goto case 3;
				case 0:
				case 5:
					eventHandler = JT4qVFIwTU;
					num = 3;
					break;
				case 6:
					eventHandler = Interlocked.CompareExchange(ref JT4qVFIwTU, value2, eventHandler2);
					goto case 2;
				case 7:
					return;
				}
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
			byo18KKMBS9NOCjJvy1();
			int num = ((!NmX4H6KO4frhrCASx87()) ? 4 : 2);
			EventHandler eventHandler2 = default;
			EventHandler value2 = default;
			EventHandler eventHandler = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					eventHandler2 = Interlocked.CompareExchange(ref JT4qVFIwTU, value2, eventHandler);
					num = 5;
					if (true)
					{
						break;
					}
					goto case 5;
				case 5:
					if ((object)eventHandler2 == eventHandler)
					{
						num = 7;
						if (byo18KKMBS9NOCjJvy1())
						{
						}
						break;
					}
					goto case 1;
				case 1:
				case 4:
					eventHandler = eventHandler2;
					num = 3;
					break;
				case 0:
				case 2:
					eventHandler2 = JT4qVFIwTU;
					goto case 1;
				case 3:
					value2 = (EventHandler)kqiXCcKaiyAKy0NHFqo(eventHandler, value);
					goto case 6;
				default:
					num = 6;
					break;
				case 7:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BaseIToolCustomService(CvsInSight insight, CvsCellLocation cellLoc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (NmX4H6KO4frhrCASx87())
		{
			num = 5;
			if (1 == 0)
			{
				return;
			}
		}
		else
		{
			num = 6;
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				return;
			case 3:
			case 6:
				EViqvHEOqX = ((CvsCogSocketSheet)PmMVRXKeWsI32O8uV1l(insight.CogSocket)).PropertySheetResourceNode;
				return;
			default:
				num = 4;
				break;
			case 0:
			case 5:
				oLwE2oKQAA1f68Nq0eL();
				num = 1;
				break;
			case 7:
				EViqvHEOqX = (ResourceNode)wbqphKKIEjSmsKUktI8(((CvsCogSocket)PaydT9Kuf9ctAXT2ZcK(insight)).Sheet, cellLoc);
				num = 8;
				break;
			case 2:
				rQ3qyB2XUP = insight ?? throw new ArgumentNullException(kgbOBx7BanbFa22Hp9.ol99ukmDA(17526));
				if (!(cellLoc == CvsCellLocation.PropertySheet))
				{
					if (cellLoc.IsValid)
					{
						num = 7;
						if (byo18KKMBS9NOCjJvy1())
						{
						}
						break;
					}
					throw new ArgumentException((string)Qnl0NoKRJ4Eet4V44qy(17544));
				}
				goto case 3;
			case 1:
				gNKxO2KlhNilgUaDH5L(this);
				num = 2;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRunChangeAsync_003Ed__8))]
	protected Task RunChangeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!byo18KKMBS9NOCjJvy1())
		{
			num = 2;
		}
		else
		{
			num = 4;
			if (byo18KKMBS9NOCjJvy1())
			{
				goto IL_009f;
			}
		}
		goto IL_0068;
		IL_0068:
		_003CRunChangeAsync_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
			case 2:
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_009f;
		IL_009f:
		stateMachine._003C_003Et__builder = V5bEyBKnVFgJZpGhBWO();
		num = 1;
		goto IL_0068;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oLwE2oKQAA1f68Nq0eL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gNKxO2KlhNilgUaDH5L(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PmMVRXKeWsI32O8uV1l(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).Sheet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PaydT9Kuf9ctAXT2ZcK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).CogSocket;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wbqphKKIEjSmsKUktI8(object P_0, CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocketSheet)P_0).GetCellToolResourceNode(location);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Qnl0NoKRJ4Eet4V44qy(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NmX4H6KO4frhrCASx87()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool byo18KKMBS9NOCjJvy1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kqiXCcKaiyAKy0NHFqo(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder V5bEyBKnVFgJZpGhBWO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
