using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.Extensions;
using Cognex.InSight.Remoting.Serialization.Color;
using Cognex.InSight.Services;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

internal class MatchColorToolApi : IMatchColorService
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetAvailableModels_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ColorMatchModel[]> _003C_003Et__builder;

		public MatchColorToolApi _003C_003E4__this;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter<ColorMatchModel[]> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			TaskAwaiter<ColorMatchModel[]> awaiter = default;
			TaskAwaiter<object> awaiter2 = default;
			MatchColorToolApi matchColorToolApi = default;
			ColorMatchModel[] result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 7;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 0;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 9;
						}
						while (true)
						{
							switch (num3)
							{
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 11:
								return;
							case 8:
								goto end_IL_0076;
							default:
								num3 = 4;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Eu__2 = awaiter;
								num3 = 5;
								continue;
							case 3:
								num2 = (_003C_003E1__state = 1);
								num3 = 2;
								continue;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 12;
								continue;
							case 7:
								awaiter2 = matchColorToolApi.zC6aGgWr1S.GetAsync<object>(kgbOBx7BanbFa22Hp9.ol99ukmDA(10052)).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									rWMAwNsENfO2oAvvggKr();
									num3 = ((!X1ebsMsExwA0RBr6LPfG()) ? 10 : 15);
									continue;
								}
								goto case 13;
							case 13:
								if (awaiter2.GetResult() != null)
								{
									awaiter = matchColorToolApi.ggjaDKssVT.GetAllModels().GetAwaiter();
									goto case 4;
								}
								result = Array.Empty<ColorMatchModel>();
								num3 = 8;
								continue;
							case 14:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 12:
								return;
							case 9:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 13;
								continue;
							case 0:
								_003C_003Eu__2 = default;
								num3 = 14;
								continue;
							case 15:
								return;
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								break;
							case 1:
							case 10:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								num3 = 6;
								continue;
							case 16:
								break;
							}
							result = awaiter.GetResult();
							break;
							continue;
							end_IL_0076:
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
				case 1:
				case 5:
					matchColorToolApi = _003C_003E4__this;
					num = 0;
					continue;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (!X1ebsMsExwA0RBr6LPfG())
					{
						continue;
					}
					break;
				case 4:
					break;
				case 6:
					return;
				}
				num2 = _003C_003E1__state;
				rWMAwNsENfO2oAvvggKr();
				num = ((!X1ebsMsExwA0RBr6LPfG()) ? 5 : 2);
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
		internal static bool rWMAwNsENfO2oAvvggKr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool X1ebsMsExwA0RBr6LPfG()
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
	private struct _003CGetEnabledIds_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ModelId[]> _003C_003Et__builder;

		public MatchColorToolApi _003C_003E4__this;

		private TaskAwaiter<long[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!krXBFisEM4XTnofKNsVS()) ? 1 : 5);
			MatchColorToolApi matchColorToolApi = default;
			int num2 = default;
			ModelId[] result = default;
			do
			{
				IL_01ff:
				switch (num)
				{
				case 4:
					matchColorToolApi = _003C_003E4__this;
					goto case 1;
				case 1:
				case 2:
					try
					{
						TaskAwaiter<long[]> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = matchColorToolApi.zC6aGgWr1S.PostAsync<long[]>((string)pl3GvPsElgmZMBXo1HOL(50948), Array.Empty<object>()).GetAwaiter();
							num3 = 2;
							if (false)
							{
								goto IL_006e;
							}
							goto IL_0132;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00a1;
						IL_00a1:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_0132;
						IL_0132:
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							case 6:
								goto IL_0081;
							case 5:
								goto IL_00a1;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									if (!cOK4gPsEQncmUt1ybLbv())
									{
										continue;
									}
									goto case 0;
								}
								goto case 7;
							case 0:
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								continue;
							case 7:
							{
								long[] result2 = awaiter.GetResult();
								if (result2 == null)
								{
									goto case 8;
								}
								result = result2.ConvertAll([MethodImpl(MethodImplOptions.NoInlining)] (long i) =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									return new ModelId((int)i);
								});
								goto end_IL_003b;
							}
							case 4:
								return;
							default:
								num3 = 5;
								continue;
							case 9:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								continue;
							case 8:
							case 10:
								result = Array.Empty<ModelId>();
								num3 = 11;
								if (true)
								{
									continue;
								}
								goto end_IL_003b;
							case 11:
								goto end_IL_003b;
							}
							break;
							IL_0081:
							_003C_003Eu__1 = awaiter;
							_ = 0;
							if (krXBFisEM4XTnofKNsVS())
							{
								num3 = 0;
								if (true)
								{
									continue;
								}
								goto IL_00a1;
							}
							num3 = 10;
							if (cOK4gPsEQncmUt1ybLbv())
							{
							}
						}
						goto IL_006e;
						IL_006e:
						num2 = (_003C_003E1__state = -1);
						num3 = 7;
						goto IL_0132;
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
					num = 3;
					if (true)
					{
						goto IL_01ff;
					}
					goto case 0;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					if (0 == 0)
					{
						goto IL_01ff;
					}
					break;
				case 3:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult(result);
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
		internal static object pl3GvPsElgmZMBXo1HOL(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool krXBFisEM4XTnofKNsVS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cOK4gPsEQncmUt1ybLbv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly ResourceNode zC6aGgWr1S;

	private readonly TrainMatchColorToolApi ggjaDKssVT;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MatchColorToolApi(ResourceNode resourceNode)
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
			default:
				ggjaDKssVT = new TrainMatchColorToolApi((ResourceNode)sMThnvdlSM2NXUE1abg(zC6aGgWr1S, IPW6UadQs1FurMy6wdw(10052)));
				num = 6;
				break;
			case 2:
			case 4:
				zC6aGgWr1S = resourceNode;
				goto default;
			case 5:
				voPJ8FdOSZe14Ln0VBF();
				num = 0;
				break;
			case 0:
				EftI7ddMRW2trdyjxof(this);
				sobnJFdrDsjk2ElksAD();
				if (NMp4RGd3frLRPqjERev())
				{
					num = 1;
					if (true)
					{
						break;
					}
					goto case 5;
				}
				num = 4;
				if (false)
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
	[AsyncStateMachine(typeof(_003CGetAvailableModels_003Ed__3))]
	public Task<ColorMatchModel[]> GetAvailableModels()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetAvailableModels_003Ed__3 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ColorMatchModel[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetEnabledIds_003Ed__4))]
	public Task<ModelId[]> GetEnabledIds()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetEnabledIds_003Ed__4 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ModelId[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task SetEnabledModels(ModelId[] models)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return zC6aGgWr1S.PostAsync<object>((string)IPW6UadQs1FurMy6wdw(10080), new object[1] { models.Select([MethodImpl(MethodImplOptions.NoInlining)] (ModelId m) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return m.Id;
		}) });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void voPJ8FdOSZe14Ln0VBF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EftI7ddMRW2trdyjxof(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IPW6UadQs1FurMy6wdw(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sMThnvdlSM2NXUE1abg(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ResourceNode)P_0).GetChildResource((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sobnJFdrDsjk2ElksAD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NMp4RGd3frLRPqjERev()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
