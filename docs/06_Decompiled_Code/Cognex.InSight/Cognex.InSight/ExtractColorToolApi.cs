using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Remoting.Serialization.Color;
using Cognex.InSight.Services;
using Newtonsoft.Json.Linq;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

public class ExtractColorToolApi : BaseIToolCustomService, IExtractColorService, IBaseIToolCustomService
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetLibraryName_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public ExtractColorToolApi _003C_003E4__this;

		private TaskAwaiter<string> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!GwUejLsEvdDdmgeIRtfg())
			{
				num = 1;
			}
			else
			{
				num = 5;
				if (!xdEVq6sEEiTYnttTET5H())
				{
					goto IL_01bd;
				}
			}
			goto IL_0186;
			IL_0186:
			int num2 = default;
			ExtractColorToolApi extractColorToolApi = default;
			string result = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					try
					{
						TaskAwaiter<string> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = extractColorToolApi.CellEditData.GetAsync<string>((string)JvT49isEHDwNIkRHPkvc(50626)).GetAwaiter();
							num3 = 5;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
							case 7:
								_003C_003Eu__1 = awaiter;
								goto case 3;
							case 0:
								return;
							case 3:
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 0;
								continue;
							case 1:
								num2 = (_003C_003E1__state = 0);
								_ = 1;
								if (GwUejLsEvdDdmgeIRtfg())
								{
									num3 = 4;
									if (GwUejLsEvdDdmgeIRtfg())
									{
									}
								}
								else
								{
									num3 = 7;
								}
								continue;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (true)
								{
									continue;
								}
								goto case 5;
							case 5:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 1;
								if (!GwUejLsEvdDdmgeIRtfg())
								{
									continue;
								}
								goto case 6;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 8;
								continue;
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
					break;
				case 2:
					extractColorToolApi = _003C_003E4__this;
					num = 4;
					continue;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 2;
					if (xdEVq6sEEiTYnttTET5H())
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_01bd;
			IL_01bd:
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_0186;
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
		internal static object JvT49isEHDwNIkRHPkvc(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xdEVq6sEEiTYnttTET5H()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GwUejLsEvdDdmgeIRtfg()
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
	private struct _003CGetAllGroups_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Dictionary<string, ExtractColorGroup>> _003C_003Et__builder;

		public ExtractColorToolApi _003C_003E4__this;

		private TaskAwaiter<JObject> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			uxwTXCsEAJ3VWV0gR0Zk();
			int num;
			if (sgsfLPsEVfI9CwvT1TUU())
			{
				num = 3;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_01d5;
			IL_002a:
			int num2 = _003C_003E1__state;
			num = 5;
			goto IL_01d5;
			IL_01d5:
			ExtractColorToolApi extractColorToolApi = default;
			Dictionary<string, ExtractColorGroup> result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					break;
				case 5:
					extractColorToolApi = _003C_003E4__this;
					goto case 2;
				case 1:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					continue;
				case 2:
				case 4:
					try
					{
						TaskAwaiter<JObject> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = extractColorToolApi.CellEditData.GetAsync<JObject>((string)gSNIWqsEDkFoaeSh3QrO(42674)).GetAwaiter();
							num3 = 8;
							if (uxwTXCsEAJ3VWV0gR0Zk())
							{
								goto IL_0099;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
						}
						goto IL_012a;
						IL_012a:
						while (true)
						{
							switch (num3)
							{
							case 3:
								break;
							case 8:
								goto IL_00b0;
							case 4:
							case 5:
								return;
							case 2:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (!uxwTXCsEAJ3VWV0gR0Zk())
								{
									continue;
								}
								goto case 0;
							case 0:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								uxwTXCsEAJ3VWV0gR0Zk();
								num3 = ((!sgsfLPsEVfI9CwvT1TUU()) ? 2 : 5);
								continue;
							case 1:
								_003C_003Eu__1 = default;
								goto case 2;
							case 9:
								goto IL_018d;
							}
							break;
						}
						goto IL_0099;
						IL_018d:
						result = awaiter.GetResult().ToObject<Dictionary<string, ExtractColorGroup>>();
						goto end_IL_0068;
						IL_0099:
						_003C_003Eu__1 = awaiter;
						num3 = 7;
						if (uxwTXCsEAJ3VWV0gR0Zk())
						{
							goto IL_00b0;
						}
						goto IL_012a;
						IL_00b0:
						if (!awaiter.IsCompleted)
						{
							num3 = 0;
							if (false)
							{
								return;
							}
							goto IL_012a;
						}
						goto IL_018d;
						end_IL_0068:;
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
		internal static object gSNIWqsEDkFoaeSh3QrO(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sgsfLPsEVfI9CwvT1TUU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uxwTXCsEAJ3VWV0gR0Zk()
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
	private struct _003CEnableGroup_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ExtractColorToolApi _003C_003E4__this;

		public int groupId;

		public bool enabled;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<object> awaiter2 = default;
			ExtractColorToolApi extractColorToolApi = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (!PUjAiUsET46caeRhFHGq())
					{
						break;
					}
					goto case 0;
				case 0:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 8;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 4;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 11;
							if (PUjAiUsET46caeRhFHGq())
							{
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 4:
								_003C_003Eu__2 = default;
								goto case 5;
							case 2:
								_003C_003Eu__2 = awaiter;
								num3 = 15;
								if (0 == 0)
								{
									continue;
								}
								goto case 14;
							case 14:
								awaiter2.GetResult();
								awaiter = extractColorToolApi.RunChangeAsync().GetAwaiter();
								goto case 9;
							default:
								num3 = 9;
								if (true)
								{
									continue;
								}
								goto case 8;
							case 8:
								awaiter2 = extractColorToolApi.CellEditData.PutAsync<object>((string)F3coB6sEibHte390MTOv(jxdeI7sEdjgBv9S9y6TL(50652), groupId), enabled).GetAwaiter();
								En7wEKsEU5wjjTOAtge3();
								if (PUjAiUsET46caeRhFHGq())
								{
									num3 = 5;
									if (!PUjAiUsET46caeRhFHGq())
									{
										continue;
									}
									goto case 2;
								}
								num3 = 0;
								continue;
							case 7:
								return;
							case 0:
							case 1:
								if (awaiter2.IsCompleted)
								{
									goto case 14;
								}
								num3 = 6;
								if (!PUjAiUsET46caeRhFHGq())
								{
									continue;
								}
								goto case 5;
							case 5:
							case 13:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 9:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 12;
							case 12:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 7;
								continue;
							case 11:
								num2 = (_003C_003E1__state = -1);
								num3 = 14;
								continue;
							case 15:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 10;
								continue;
							case 6:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								num3 = 12;
								continue;
							case 3:
								num2 = (_003C_003E1__state = 1);
								num3 = 2;
								if (En7wEKsEU5wjjTOAtge3())
								{
									continue;
								}
								return;
							case 10:
								return;
							case 16:
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
				case 1:
				case 4:
					extractColorToolApi = _003C_003E4__this;
					num = 0;
					break;
				case 5:
					num2 = _003C_003E1__state;
					En7wEKsEU5wjjTOAtge3();
					if (PUjAiUsET46caeRhFHGq())
					{
						num = 2;
						if (!PUjAiUsET46caeRhFHGq())
						{
							break;
						}
						goto case 1;
					}
					num = 4;
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
		internal static object jxdeI7sEdjgBv9S9y6TL(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object F3coB6sEibHte390MTOv(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool En7wEKsEU5wjjTOAtge3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PUjAiUsET46caeRhFHGq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExtractColorToolApi(CvsInSight insight, CvsCellLocation cellLoc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IFeuSdd514Ctw8Ng4BL();
		base._002Ector(insight, cellLoc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetLibraryName_003Ed__1))]
	public Task<string> GetLibraryName()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetLibraryName_003Ed__1 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetAllGroups_003Ed__2))]
	public Task<Dictionary<string, ExtractColorGroup>> GetAllGroups()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetAllGroups_003Ed__2 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Dictionary<string, ExtractColorGroup>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEnableGroup_003Ed__3))]
	public Task EnableGroup(int groupId, bool enabled)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CEnableGroup_003Ed__3 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				break;
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 3:
				stateMachine.enabled = enabled;
				goto default;
			case 2:
				stateMachine._003C_003Et__builder = f2VU7vdoUBZTNOQVgxc();
				_ = 1;
				if (ltrrprdK6avBpaY9Kbk())
				{
					num = 7;
					break;
				}
				num = 5;
				if (UCWoyedCG3UMEtaIUaJ())
				{
					break;
				}
				goto case 1;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 0;
				break;
			case 0:
				stateMachine.groupId = groupId;
				num = 3;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IFeuSdd514Ctw8Ng4BL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UCWoyedCG3UMEtaIUaJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ltrrprdK6avBpaY9Kbk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder f2VU7vdoUBZTNOQVgxc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
