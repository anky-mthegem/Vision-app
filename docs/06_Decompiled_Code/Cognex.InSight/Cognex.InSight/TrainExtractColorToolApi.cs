using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Remoting.Serialization.Color;
using Cognex.InSight.Services;
using Newtonsoft.Json.Linq;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

public class TrainExtractColorToolApi : BaseIToolCustomService, ITrainExtractColorService, IBaseIToolCustomService
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetLibraryName_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public TrainExtractColorToolApi _003C_003E4__this;

		private TaskAwaiter<string> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (!kCv3EbsH2ZjcM9gujkAk())
			{
				goto IL_001e;
			}
			goto IL_01cc;
			IL_001e:
			string result = default;
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_01cc;
			IL_01cc:
			int num2 = default;
			TrainExtractColorToolApi trainExtractColorToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					if (muidmvsHWWy6oLUwg9Y5())
					{
					}
					continue;
				case 1:
					trainExtractColorToolApi = _003C_003E4__this;
					_ = 0;
					num = (kCv3EbsH2ZjcM9gujkAk() ? 4 : 0);
					continue;
				case 2:
				case 4:
					try
					{
						TaskAwaiter<string> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = trainExtractColorToolApi.CellEditData.GetAsync<string>(kgbOBx7BanbFa22Hp9.ol99ukmDA(50626)).GetAwaiter();
							num3 = 0;
							if (!kCv3EbsH2ZjcM9gujkAk())
							{
								goto IL_009d;
							}
							goto IL_0146;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0110;
						IL_0110:
						_003C_003Eu__1 = default;
						num3 = 6;
						goto IL_0146;
						IL_0146:
						while (true)
						{
							switch (num3)
							{
							case 3:
								break;
							case 4:
							case 7:
								return;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 9;
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 2:
							case 5:
								goto IL_0110;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								_ = 1;
								num3 = ((!muidmvsHWWy6oLUwg9Y5()) ? 7 : 2);
								continue;
							case 9:
								result = awaiter.GetResult();
								goto end_IL_006c;
							}
							break;
						}
						goto IL_009d;
						IL_009d:
						num2 = (_003C_003E1__state = 0);
						num3 = 8;
						if (muidmvsHWWy6oLUwg9Y5())
						{
						}
						goto IL_0146;
						end_IL_006c:;
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
		internal static bool kCv3EbsH2ZjcM9gujkAk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool muidmvsHWWy6oLUwg9Y5()
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
	private struct _003CSetLibraryName_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TrainExtractColorToolApi _003C_003E4__this;

		public string libraryName;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			int num2 = default;
			TaskAwaiter awaiter2 = default;
			TaskAwaiter<object> awaiter = default;
			TrainExtractColorToolApi trainExtractColorToolApi = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
				case 5:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = 1;
							break;
						case 1:
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 16;
							if (!IM2IHDsH7rfFIyjJqhN9())
							{
								return;
							}
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 6;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 10:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									if (0 == 0)
									{
										continue;
									}
									goto case 6;
								}
								goto case 15;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 0;
								if (0 == 0)
								{
									continue;
								}
								goto case 7;
							case 7:
								awaiter2 = trainExtractColorToolApi.RunChangeAsync().GetAwaiter();
								num3 = 9;
								continue;
							case 15:
								awaiter.GetResult();
								num3 = 7;
								if (!wA1BMhsHtvpYhba6awSh())
								{
									continue;
								}
								goto case 11;
							case 11:
							case 12:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 14;
								if (true)
								{
									continue;
								}
								goto case 3;
							case 3:
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								continue;
							case 14:
								return;
							case 4:
								return;
							case 2:
								_003C_003Eu__2 = awaiter2;
								goto case 11;
							case 0:
								num2 = (_003C_003E1__state = -1);
								goto case 15;
							default:
								num3 = 15;
								continue;
							case 9:
								if (awaiter2.IsCompleted)
								{
									break;
								}
								num3 = 13;
								if (!wA1BMhsHtvpYhba6awSh())
								{
									continue;
								}
								goto case 8;
							case 8:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								wA1BMhsHtvpYhba6awSh();
								if (!IM2IHDsH7rfFIyjJqhN9())
								{
									num3 = 11;
									if (IM2IHDsH7rfFIyjJqhN9())
									{
										continue;
									}
									goto case 0;
								}
								num3 = 5;
								continue;
							case 13:
								num2 = (_003C_003E1__state = 1);
								num3 = 2;
								continue;
							case 1:
								awaiter = trainExtractColorToolApi.CellEditData.PutAsync<object>((string)E2gb1DsHCjJWdIJCKZit(50626), libraryName).GetAwaiter();
								num3 = 10;
								continue;
							case 16:
								break;
							}
							break;
						}
						awaiter2.GetResult();
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
					num2 = _003C_003E1__state;
					num = 4;
					break;
				case 4:
					trainExtractColorToolApi = _003C_003E4__this;
					IM2IHDsH7rfFIyjJqhN9();
					if (wA1BMhsHtvpYhba6awSh())
					{
						num = 0;
						if (0 == 0)
						{
							break;
						}
						goto case 1;
					}
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
		internal static object E2gb1DsHCjJWdIJCKZit(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IM2IHDsH7rfFIyjJqhN9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wA1BMhsHtvpYhba6awSh()
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
	private struct _003CGetSelectedModelType_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<TrainExtractColorLibraryModelType> _003C_003Et__builder;

		public TrainExtractColorToolApi _003C_003E4__this;

		private TaskAwaiter<long> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			TrainExtractColorToolApi trainExtractColorToolApi = default;
			TrainExtractColorLibraryModelType result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					try
					{
						TaskAwaiter<long> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = trainExtractColorToolApi.CellEditData.GetAsync<long>(kgbOBx7BanbFa22Hp9.ol99ukmDA(51724)).GetAwaiter();
							num3 = 8;
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
							case 8:
								if (awaiter.IsCompleted)
								{
									break;
								}
								gwKgaEsHKdgqyLd5d68l();
								if (!plNiv7sH5fxZs5UoKjSk())
								{
									num3 = 6;
									if (1 == 0)
									{
										return;
									}
								}
								else
								{
									num3 = 7;
								}
								continue;
							case 3:
								return;
							case 2:
							case 7:
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								continue;
							case 0:
								_003C_003Eu__1 = default;
								num3 = 5;
								if (0 == 0)
								{
									continue;
								}
								goto case 4;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 1;
							case 1:
							case 6:
								num2 = (_003C_003E1__state = 0);
								goto case 2;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (gwKgaEsHKdgqyLd5d68l())
								{
									continue;
								}
								break;
							case 9:
								break;
							}
							break;
						}
						result = (TrainExtractColorLibraryModelType)awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 1:
					trainExtractColorToolApi = _003C_003E4__this;
					plNiv7sH5fxZs5UoKjSk();
					num = ((!gwKgaEsHKdgqyLd5d68l()) ? 5 : 0);
					continue;
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
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
		internal static bool gwKgaEsHKdgqyLd5d68l()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool plNiv7sH5fxZs5UoKjSk()
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
	private struct _003CSetSelectedModelType_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TrainExtractColorToolApi _003C_003E4__this;

		public TrainExtractColorLibraryModelType modelType;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

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
			goto IL_028c;
			IL_001a:
			int num2 = _003C_003E1__state;
			_ = 0;
			num = (MG7ECKsHonWmgLXVI9WO() ? 3 : 0);
			goto IL_028c;
			IL_028c:
			TrainExtractColorToolApi trainExtractColorToolApi = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<object> awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 1:
				case 3:
					trainExtractColorToolApi = _003C_003E4__this;
					goto case 0;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								CywroXsHPNi1012JlhYZ();
								num3 = ((!MG7ECKsHonWmgLXVI9WO()) ? 12 : 6);
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 9;
								if (CywroXsHPNi1012JlhYZ())
								{
								}
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 14;
							if (1 == 0)
							{
								goto IL_014f;
							}
						}
						goto IL_01c9;
						IL_014f:
						_003C_003Eu__2 = default;
						num3 = 15;
						goto IL_01c9;
						IL_01c9:
						while (true)
						{
							switch (num3)
							{
							case 14:
								_003C_003Eu__1 = default;
								num3 = 11;
								continue;
							case 15:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 0:
							case 6:
								awaiter2 = trainExtractColorToolApi.CellEditData.PutAsync<object>(kgbOBx7BanbFa22Hp9.ol99ukmDA(51724), (int)modelType).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 5;
							case 4:
								awaiter = jTh5gssHYXN1GFdje6qb(trainExtractColorToolApi.RunChangeAsync());
								goto case 8;
							case 13:
								_003C_003Eu__2 = awaiter;
								num3 = 2;
								continue;
							case 11:
								num2 = (_003C_003E1__state = -1);
								num3 = 5;
								if (CywroXsHPNi1012JlhYZ())
								{
								}
								continue;
							case 7:
								num2 = (_003C_003E1__state = 1);
								num3 = 13;
								continue;
							case 1:
								return;
							case 9:
								break;
							case 8:
							case 12:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto case 16;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 10;
								if (true)
								{
									continue;
								}
								goto case 10;
							case 10:
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 1;
								continue;
							case 5:
								awaiter2.GetResult();
								goto case 4;
							default:
								num3 = 4;
								continue;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 16:
								awaiter.GetResult();
								goto end_IL_01c9;
							}
							goto IL_014f;
							continue;
							end_IL_01c9:
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
					if (true)
					{
						continue;
					}
					goto case 5;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (MG7ECKsHonWmgLXVI9WO())
					{
						continue;
					}
					return;
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
		internal static TaskAwaiter jTh5gssHYXN1GFdje6qb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MG7ECKsHonWmgLXVI9WO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CywroXsHPNi1012JlhYZ()
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
	private struct _003CCreateGroup_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<TrainExtractColorGroup> _003C_003Et__builder;

		public TrainExtractColorToolApi _003C_003E4__this;

		public string groupName;

		private TrainExtractColorGroup _003CcolorGroup_003E5__2;

		private TaskAwaiter<TrainExtractColorGroup> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			JWSkqxsHNdqGAcuLCivF();
			int num = (b6OaTGsHxAnhdiuFZxnR() ? 2 : 3);
			TrainExtractColorToolApi trainExtractColorToolApi = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<TrainExtractColorGroup> awaiter2 = default;
			TrainExtractColorGroup result = default;
			TrainExtractColorGroup result2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					trainExtractColorToolApi = _003C_003E4__this;
					num = 1;
					if (JWSkqxsHNdqGAcuLCivF())
					{
						continue;
					}
					goto case 1;
				case 1:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 4;
								if (false)
								{
									goto IL_0058;
								}
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 9;
								if (!JWSkqxsHNdqGAcuLCivF())
								{
									goto IL_025b;
								}
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 8;
						}
						goto IL_01be;
						IL_0058:
						_003CcolorGroup_003E5__2 = result;
						awaiter = N2OT2vsH1WyLF4Jo2qoC(trainExtractColorToolApi.RunChangeAsync());
						num3 = 0;
						goto IL_01be;
						IL_01be:
						while (true)
						{
							switch (num3)
							{
							case 3:
								break;
							case 6:
								awaiter.GetResult();
								num3 = 17;
								continue;
							case 11:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 14;
								continue;
							case 0:
								if (awaiter.IsCompleted)
								{
									goto case 6;
								}
								num2 = (_003C_003E1__state = 1);
								goto case 7;
							case 4:
								awaiter2 = trainExtractColorToolApi.CellEditData.PostAsync<TrainExtractColorGroup>(kgbOBx7BanbFa22Hp9.ol99ukmDA(51746), new object[1] { groupName ?? "" }).GetAwaiter();
								num3 = 16;
								continue;
							case 5:
								return;
							case 7:
							case 10:
								_003C_003Eu__2 = awaiter;
								num3 = 11;
								continue;
							case 13:
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 5;
								continue;
							case 2:
							case 15:
								num2 = (_003C_003E1__state = 0);
								num3 = 13;
								if (0 == 0)
								{
									continue;
								}
								goto case 9;
							case 9:
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 6;
								continue;
							case 16:
								if (!awaiter2.IsCompleted)
								{
									goto IL_018e;
								}
								goto case 12;
							case 12:
								result = awaiter2.GetResult();
								break;
							default:
								num3 = 3;
								continue;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								continue;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 1;
								continue;
							case 14:
								return;
							case 17:
								goto IL_025b;
							}
							break;
							IL_018e:
							_ = 0;
							num3 = (JWSkqxsHNdqGAcuLCivF() ? 15 : 7);
						}
						goto IL_0058;
						IL_025b:
						result2 = _003CcolorGroup_003E5__2;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CcolorGroup_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 6;
				default:
					num = 6;
					continue;
				case 6:
					_003CcolorGroup_003E5__2 = null;
					goto case 2;
				case 2:
				case 4:
					_003C_003Et__builder.SetResult(result2);
					num = 7;
					if (!b6OaTGsHxAnhdiuFZxnR())
					{
						continue;
					}
					break;
				case 0:
				case 3:
					break;
				case 7:
					return;
				}
				num2 = _003C_003E1__state;
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
		internal static TaskAwaiter N2OT2vsH1WyLF4Jo2qoC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JWSkqxsHNdqGAcuLCivF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool b6OaTGsHxAnhdiuFZxnR()
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
	private struct _003CDeleteGroup_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TrainExtractColorToolApi _003C_003E4__this;

		public int groupId;

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
			TrainExtractColorToolApi trainExtractColorToolApi = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<object> awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto case 4;
				case 4:
					trainExtractColorToolApi = _003C_003E4__this;
					_ = 1;
					if (!Wua3yFsH30x7yrY6bPpQ())
					{
						num = 5;
						continue;
					}
					num = 1;
					if (DmrjmAsHrn9QCoq1ltkI())
					{
						continue;
					}
					break;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 11;
								if (Wua3yFsH30x7yrY6bPpQ())
								{
								}
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 12;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 8;
						}
						while (true)
						{
							switch (num3)
							{
							case 11:
								awaiter2 = trainExtractColorToolApi.CellEditData.PostAsync<object>((string)obhBjFsHOR2FGweH4heI(51772), new object[1] { groupId }).GetAwaiter();
								num3 = 6;
								if (Wua3yFsH30x7yrY6bPpQ())
								{
								}
								continue;
							case 0:
							case 2:
								num2 = (_003C_003E1__state = 0);
								goto case 3;
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 13:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 7:
								_003C_003Eu__2 = awaiter;
								num3 = 10;
								continue;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								break;
							case 14:
								num2 = (_003C_003E1__state = -1);
								goto case 1;
							default:
								num3 = 1;
								continue;
							case 3:
							case 9:
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 15;
								continue;
							case 1:
								awaiter2.GetResult();
								awaiter = fowpQxsHMg0RHB7jCo5p(trainExtractColorToolApi.RunChangeAsync());
								num3 = 5;
								if (!Wua3yFsH30x7yrY6bPpQ())
								{
									continue;
								}
								return;
							case 15:
								return;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 14;
								continue;
							case 6:
								if (!awaiter2.IsCompleted)
								{
									Wua3yFsH30x7yrY6bPpQ();
									if (!DmrjmAsHrn9QCoq1ltkI())
									{
										num3 = 9;
										continue;
									}
									num3 = 0;
									if (Wua3yFsH30x7yrY6bPpQ())
									{
									}
									continue;
								}
								goto case 1;
							case 12:
								_003C_003Eu__2 = default;
								num3 = 13;
								continue;
							case 4:
								num2 = (_003C_003E1__state = 1);
								num3 = 7;
								continue;
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
		internal static object obhBjFsHOR2FGweH4heI(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter fowpQxsHMg0RHB7jCo5p(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DmrjmAsHrn9QCoq1ltkI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Wua3yFsH30x7yrY6bPpQ()
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
	private struct _003CRenameGroup_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TrainExtractColorToolApi _003C_003E4__this;

		public int groupId;

		public string newName;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			q703D4sHlPuCKUhUHl2r();
			int num = ((!GEKI8JsHQoiOy89T2AuB()) ? 5 : 3);
			TrainExtractColorToolApi trainExtractColorToolApi = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<object> awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
					trainExtractColorToolApi = _003C_003E4__this;
					goto case 2;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 9;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 13;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 5:
							case 12:
								return;
							case 9:
								awaiter2 = trainExtractColorToolApi.CellEditData.PutAsync<object>(string.Format((string)IFRBQTsHeFUhmb6yO7yJ(51798), groupId), newName).GetAwaiter();
								num3 = 3;
								continue;
							case 0:
								num2 = (_003C_003E1__state = -1);
								goto case 7;
							default:
								num3 = 7;
								if (GEKI8JsHQoiOy89T2AuB())
								{
									continue;
								}
								goto case 3;
							case 3:
								if (!awaiter2.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								goto case 7;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 15:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 7:
								awaiter2.GetResult();
								goto case 8;
							case 2:
								_003C_003Eu__1 = awaiter2;
								num3 = 6;
								continue;
							case 14:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 11;
									continue;
								}
								break;
							case 8:
							case 10:
								awaiter = KXpDtSsHuyGxtuGAEJvM(trainExtractColorToolApi.RunChangeAsync());
								num3 = 14;
								continue;
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								continue;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								_ = 1;
								if (q703D4sHlPuCKUhUHl2r())
								{
									num3 = 10;
									if (!q703D4sHlPuCKUhUHl2r())
									{
										continue;
									}
									goto case 2;
								}
								num3 = 12;
								continue;
							case 11:
								_003C_003Eu__2 = awaiter;
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto case 13;
							case 13:
								_003C_003Eu__2 = default;
								num3 = 15;
								continue;
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
					goto case 4;
				default:
					num = 4;
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 1;
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
		internal static object IFRBQTsHeFUhmb6yO7yJ(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter KXpDtSsHuyGxtuGAEJvM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GEKI8JsHQoiOy89T2AuB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool q703D4sHlPuCKUhUHl2r()
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
	private struct _003CSetSelectedGroup_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TrainExtractColorToolApi _003C_003E4__this;

		public int groupId;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = ((!FFhYcisHR86eEZk5x1qv()) ? 1 : 2);
			int num2 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<object> awaiter2 = default;
			TrainExtractColorToolApi trainExtractColorToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								_ = 0;
								if (qUEEvmsHIIcgUh4hJ4F5())
								{
									num3 = 1;
									if (1 == 0)
									{
										goto IL_006f;
									}
								}
								else
								{
									num3 = 14;
								}
							}
							else
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num3 = 11;
								if (!qUEEvmsHIIcgUh4hJ4F5())
								{
									goto IL_01da;
								}
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 2;
							if (FFhYcisHR86eEZk5x1qv())
							{
								goto IL_0181;
							}
						}
						goto IL_00c5;
						IL_00ab:
						awaiter2.GetResult();
						goto IL_0227;
						IL_006f:
						awaiter2 = trainExtractColorToolApi.CellEditData.PutAsync<object>((string)gJ7bw9sHaDteIBBYJ42R(51832), groupId).GetAwaiter();
						if (awaiter2.IsCompleted)
						{
							goto IL_00ab;
						}
						num3 = 7;
						goto IL_00c5;
						IL_0227:
						awaiter = zaawiisHnfvKxJ4Rg1N6(trainExtractColorToolApi.RunChangeAsync());
						num3 = 12;
						goto IL_00c5;
						IL_00c5:
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 1:
								break;
							case 13:
								goto IL_00ab;
							default:
								num3 = 6;
								continue;
							case 3:
								num2 = (_003C_003E1__state = 1);
								num3 = 15;
								continue;
							case 7:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								num3 = 4;
								if (true)
								{
									continue;
								}
								goto case 10;
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								if (qUEEvmsHIIcgUh4hJ4F5())
								{
									continue;
								}
								return;
							case 9:
								return;
							case 4:
								goto IL_0181;
							case 5:
							case 14:
								num2 = (_003C_003E1__state = -1);
								num3 = 13;
								if (!FFhYcisHR86eEZk5x1qv())
								{
									continue;
								}
								return;
							case 8:
								return;
							case 15:
								goto IL_01da;
							case 12:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 16;
							case 2:
								_003C_003Eu__1 = default;
								goto case 5;
							case 6:
								goto IL_0227;
							case 11:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 16:
								awaiter.GetResult();
								goto end_IL_004a;
							}
							break;
						}
						goto IL_006f;
						IL_0181:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						num3 = 9;
						goto IL_00c5;
						IL_01da:
						_003C_003Eu__2 = awaiter;
						num3 = 10;
						if (FFhYcisHR86eEZk5x1qv())
						{
						}
						goto IL_00c5;
						end_IL_004a:;
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
					trainExtractColorToolApi = _003C_003E4__this;
					num = 4;
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
		internal static object gJ7bw9sHaDteIBBYJ42R(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter zaawiisHnfvKxJ4Rg1N6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qUEEvmsHIIcgUh4hJ4F5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FFhYcisHR86eEZk5x1qv()
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
	private struct _003CGetAllGroups_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Dictionary<string, TrainExtractColorGroup>> _003C_003Et__builder;

		public TrainExtractColorToolApi _003C_003E4__this;

		private TaskAwaiter<JObject> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (TQcrCQsHGcceBF9d2gNi())
			{
				num = 2;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_01ee;
				}
			}
			goto IL_0197;
			IL_01ee:
			Dictionary<string, TrainExtractColorGroup> result = default;
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_0197;
			IL_0197:
			TrainExtractColorToolApi trainExtractColorToolApi = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				default:
					num = 4;
					if (true)
					{
						continue;
					}
					goto case 1;
				case 1:
				case 3:
					trainExtractColorToolApi = _003C_003E4__this;
					num = 5;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					goto IL_01ee;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			try
			{
				TaskAwaiter<JObject> awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = trainExtractColorToolApi.CellEditData.GetAsync<JObject>((string)xEuCZMsHbQVCNU9C2FGX(42674)).GetAwaiter();
					num3 = 0;
					if (1 == 0)
					{
						goto IL_0053;
					}
					goto IL_0105;
				}
				awaiter = _003C_003Eu__1;
				goto IL_00ad;
				IL_00ad:
				_003C_003Eu__1 = default;
				num3 = 6;
				goto IL_0105;
				IL_0105:
				while (true)
				{
					switch (num3)
					{
					case 4:
						break;
					case 1:
					case 7:
						num2 = (_003C_003E1__state = 0);
						num3 = 4;
						if (KyXH8ksHXSB4jEu2xBZ6())
						{
						}
						continue;
					case 0:
						if (!awaiter.IsCompleted)
						{
							KyXH8ksHXSB4jEu2xBZ6();
							if (TQcrCQsHGcceBF9d2gNi())
							{
								num3 = 7;
								if (TQcrCQsHGcceBF9d2gNi())
								{
									continue;
								}
								goto IL_00ad;
							}
							num3 = 3;
							if (TQcrCQsHGcceBF9d2gNi())
							{
								continue;
							}
							goto case 2;
						}
						goto case 9;
					case 3:
					case 5:
						goto IL_00ad;
					case 8:
						return;
					case 2:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 8;
						continue;
					case 6:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 9:
						result = awaiter.GetResult().ToObject<Dictionary<string, TrainExtractColorGroup>>();
						goto end_IL_0026;
					}
					break;
				}
				goto IL_0053;
				IL_0053:
				_003C_003Eu__1 = awaiter;
				num3 = 2;
				goto IL_0105;
				end_IL_0026:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01ee;
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
		internal static object xEuCZMsHbQVCNU9C2FGX(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TQcrCQsHGcceBF9d2gNi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KyXH8ksHXSB4jEu2xBZ6()
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
	private struct _003CSetColorModelOrder_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TrainExtractColorToolApi _003C_003E4__this;

		public int groupId;

		public int[] colorModelIds;

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
			TrainExtractColorToolApi trainExtractColorToolApi = default;
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
								num3 = 0;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 12;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 11;
							if (!bDNxXQsH6vj8LeVc79Dm())
							{
								return;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								break;
							case 7:
								awaiter2.GetResult();
								awaiter = trainExtractColorToolApi.RunChangeAsync().GetAwaiter();
								goto case 9;
							default:
								num3 = 9;
								continue;
							case 13:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								num3 = 4;
								if (bDNxXQsH6vj8LeVc79Dm())
								{
									continue;
								}
								goto case 11;
							case 11:
								_003C_003Eu__1 = default;
								num3 = 15;
								if (true)
								{
									continue;
								}
								goto case 3;
							case 3:
								_003C_003Eu__2 = awaiter;
								goto case 2;
							case 1:
							case 8:
								if (!awaiter2.IsCompleted)
								{
									num3 = 13;
									continue;
								}
								goto case 7;
							case 0:
								awaiter2 = trainExtractColorToolApi.CellEditData.PutAsync<object>((string)pVV1NfsH4mjcUaYfN0Ev(X2G6r3sH0q6qnFi6qhwD(51862), groupId), colorModelIds).GetAwaiter();
								_ = 0;
								num3 = (bDNxXQsH6vj8LeVc79Dm() ? 8 : 2);
								continue;
							case 15:
								num2 = (_003C_003E1__state = -1);
								num3 = 7;
								continue;
							case 12:
								_003C_003Eu__2 = default;
								num3 = 6;
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 5:
								num2 = (_003C_003E1__state = 1);
								num3 = 3;
								continue;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							case 14:
								return;
							case 2:
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 14;
								continue;
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
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 5:
					num2 = _003C_003E1__state;
					_ = 1;
					num = ((!g0ZPcKsHpKmTvEtJtZ8O()) ? 2 : 4);
					break;
				case 1:
				case 2:
					trainExtractColorToolApi = _003C_003E4__this;
					num = 0;
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
		internal static object X2G6r3sH0q6qnFi6qhwD(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pVV1NfsH4mjcUaYfN0Ev(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bDNxXQsH6vj8LeVc79Dm()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool g0ZPcKsHpKmTvEtJtZ8O()
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
	private struct _003CGetTrainEditView_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCogView> _003C_003Et__builder;

		public TrainExtractColorToolApi _003C_003E4__this;

		private TaskAwaiter<CvsCogView> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			USNwqTsHkCA6PaeT8f7v();
			int num;
			if (!g9JRSmsHfvLZC10HXrVM())
			{
				num = 4;
			}
			else
			{
				num = 3;
				if (!USNwqTsHkCA6PaeT8f7v())
				{
					return;
				}
			}
			CvsCogView result = default;
			int num2 = default;
			TrainExtractColorToolApi trainExtractColorToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 2:
				case 3:
					try
					{
						TaskAwaiter<CvsCogView> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = trainExtractColorToolApi.CellEditData.GetAsync<CvsCogView>((string)lpBBQksHFdEQ5IbIajlb(51908)).GetAwaiter();
							num3 = 6;
							if (g9JRSmsHfvLZC10HXrVM())
							{
								goto IL_006f;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
						}
						goto IL_00b8;
						IL_00b8:
						while (true)
						{
							switch (num3)
							{
							case 7:
								break;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								goto case 9;
							case 3:
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								return;
							case 1:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 5:
								_003C_003Eu__1 = awaiter;
								_ = 0;
								if (!USNwqTsHkCA6PaeT8f7v())
								{
									num3 = 2;
									if (USNwqTsHkCA6PaeT8f7v())
									{
										continue;
									}
									goto case 1;
								}
								num3 = 8;
								if (USNwqTsHkCA6PaeT8f7v())
								{
									continue;
								}
								return;
							case 2:
								return;
							case 0:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								continue;
							case 9:
								result = awaiter.GetResult();
								goto end_IL_00b8;
							}
							goto IL_006f;
							continue;
							end_IL_00b8:
							break;
						}
						goto end_IL_003e;
						IL_006f:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_00b8;
						end_IL_003e:;
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
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
					trainExtractColorToolApi = _003C_003E4__this;
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
		internal static object lpBBQksHFdEQ5IbIajlb(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool USNwqTsHkCA6PaeT8f7v()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool g9JRSmsHfvLZC10HXrVM()
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
	private struct _003CTrainSingleColor_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<TrainExtractColorModel> _003C_003Et__builder;

		public TrainExtractColorToolApi _003C_003E4__this;

		public int groupId;

		public CvsCogShape shape;

		public TrainExtractColorModelOperation operation;

		private TrainExtractColorModel _003CcolorModel_003E5__2;

		private TaskAwaiter<TrainExtractColorModel> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			TrainExtractColorToolApi trainExtractColorToolApi = default;
			int num2 = default;
			TaskAwaiter awaiter2 = default;
			TaskAwaiter<TrainExtractColorModel> awaiter = default;
			TrainExtractColorModel result2 = default;
			TrainExtractColorModel result = default;
			do
			{
				IL_02c5:
				switch (num)
				{
				case 5:
					trainExtractColorToolApi = _003C_003E4__this;
					RA0jBAsHyRZI2epmLww3();
					num = (cEATlZsHmTA9WfUDM5oi() ? 4 : 0);
					goto IL_02c5;
				case 1:
					num2 = _003C_003E1__state;
					num = 5;
					goto IL_02c5;
				case 2:
				case 4:
					try
					{
						_ = 1;
						try
						{
							int num3;
							switch (num2)
							{
							default:
								num3 = 6;
								break;
							case 1:
								awaiter2 = _003C_003Eu__2;
								num3 = 7;
								break;
							case 0:
								awaiter = _003C_003Eu__1;
								num3 = 5;
								break;
							}
							while (true)
							{
								switch (num3)
								{
								case 9:
									_003C_003Eu__1 = awaiter;
									num3 = 4;
									if (cEATlZsHmTA9WfUDM5oi())
									{
										continue;
									}
									goto case 6;
								case 6:
									awaiter = trainExtractColorToolApi.CellEditData.PostAsync<TrainExtractColorModel>((string)BNMMP5sHZOAUl9g1pKd2(aQJcrJsHgplgWttGZjW1(51938), groupId), new object[2]
									{
										shape,
										(int)operation
									}).GetAwaiter();
									num3 = 16;
									continue;
								case 15:
									if (!awaiter2.IsCompleted)
									{
										goto case 3;
									}
									goto IL_017b;
								case 14:
									_003CcolorModel_003E5__2 = result2;
									num3 = 0;
									continue;
								case 5:
									_003C_003Eu__1 = default;
									num3 = 10;
									continue;
								case 16:
									if (!awaiter.IsCompleted)
									{
										num3 = 2;
										continue;
									}
									goto case 1;
								case 3:
								case 12:
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								case 1:
								case 8:
									result2 = awaiter.GetResult();
									num3 = 14;
									continue;
								case 11:
									num2 = (_003C_003E1__state = -1);
									goto IL_017b;
								case 2:
									num2 = (_003C_003E1__state = 0);
									num3 = 9;
									continue;
								case 13:
									return;
								case 7:
									_003C_003Eu__2 = default;
									num3 = 11;
									if (true)
									{
										continue;
									}
									goto case 10;
								case 10:
									num2 = (_003C_003E1__state = -1);
									goto default;
								default:
									_ = 0;
									num3 = (cEATlZsHmTA9WfUDM5oi() ? 1 : 3);
									continue;
								case 0:
									awaiter2 = hDwMkbsHJIK4mDhsuXOS(trainExtractColorToolApi.RunChangeAsync());
									num3 = 15;
									continue;
								case 4:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 13;
									continue;
								case 17:
									{
										result = _003CcolorModel_003E5__2;
										break;
									}
									IL_017b:
									awaiter2.GetResult();
									num3 = 17;
									continue;
								}
								break;
							}
						}
						catch (CvsNetworkException)
						{
							result = null;
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
				_003C_003Et__builder.SetResult(result);
				num = 6;
			}
			while (cEATlZsHmTA9WfUDM5oi());
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
		internal static object aQJcrJsHgplgWttGZjW1(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BNMMP5sHZOAUl9g1pKd2(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter hDwMkbsHJIK4mDhsuXOS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cEATlZsHmTA9WfUDM5oi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RA0jBAsHyRZI2epmLww3()
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
	private struct _003CTrainMultipleColors_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<TrainExtractColorModel[]> _003C_003Et__builder;

		public TrainExtractColorToolApi _003C_003E4__this;

		public int groupId;

		public CvsCogShape shape;

		public TrainExtractColorModelOperation operation;

		public float minimumColorArea;

		public float smoothing;

		private TrainExtractColorModel[] _003CcolorModels_003E5__2;

		private TaskAwaiter<TrainExtractColorModel[]> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oIVZs3sHzXDT6xSnQovg();
			int num = ((!bfrbtUsH8RvKF5rkuuJN()) ? 1 : 5);
			int num2 = default;
			TrainExtractColorToolApi trainExtractColorToolApi = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<TrainExtractColorModel[]> awaiter2 = default;
			TrainExtractColorModel[] result2 = default;
			TrainExtractColorModel[] result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 3;
					continue;
				case 3:
					trainExtractColorToolApi = _003C_003E4__this;
					goto case 1;
				case 1:
				case 2:
					try
					{
						_ = 1;
						try
						{
							int num3;
							if (num2 != 0)
							{
								if (num2 != 1)
								{
									num3 = 15;
								}
								else
								{
									awaiter = _003C_003Eu__2;
									num3 = 2;
								}
							}
							else
							{
								awaiter2 = _003C_003Eu__1;
								num3 = 8;
								if (!bfrbtUsH8RvKF5rkuuJN())
								{
									goto IL_01d8;
								}
							}
							goto IL_0230;
							IL_0230:
							while (true)
							{
								switch (num3)
								{
								case 5:
									_003C_003Eu__1 = awaiter2;
									num3 = 3;
									continue;
								case 2:
									_003C_003Eu__2 = default;
									num3 = 4;
									continue;
								case 1:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 1);
										_ = 1;
										num3 = ((!oIVZs3sHzXDT6xSnQovg()) ? 7 : 0);
										continue;
									}
									goto case 0;
								case 8:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 11;
									continue;
								case 0:
								case 13:
									awaiter.GetResult();
									num3 = 16;
									continue;
								case 15:
									awaiter2 = trainExtractColorToolApi.CellEditData.PostAsync<TrainExtractColorModel[]>((string)tF0qxksVsDTHbbpja2HH(SAaJuwsVws5DWSkGavS3(51996), groupId), new object[4]
									{
										shape,
										(int)operation,
										minimumColorArea,
										smoothing
									}).GetAwaiter();
									num3 = 10;
									continue;
								case 12:
									_003CcolorModels_003E5__2 = result2 ?? Array.Empty<TrainExtractColorModel>();
									awaiter = WQM4hGsVh54bb53QakCM(trainExtractColorToolApi.RunChangeAsync());
									num3 = 1;
									continue;
								case 6:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								case 7:
								case 9:
									break;
								case 4:
									num2 = (_003C_003E1__state = -1);
									goto case 0;
								case 14:
									num2 = (_003C_003E1__state = 0);
									num3 = 5;
									continue;
								case 11:
									result2 = awaiter2.GetResult();
									goto case 12;
								default:
									num3 = 12;
									if (true)
									{
										continue;
									}
									goto case 10;
								case 10:
									if (!awaiter2.IsCompleted)
									{
										num3 = 14;
										continue;
									}
									goto case 11;
								case 16:
									result = _003CcolorModels_003E5__2;
									goto end_IL_0230;
								}
								goto IL_01d8;
								continue;
								end_IL_0230:
								break;
							}
							goto end_IL_0055;
							IL_01d8:
							_003C_003Eu__2 = awaiter;
							num3 = 6;
							goto IL_0230;
							end_IL_0055:;
						}
						catch (CvsNetworkException)
						{
							result = Array.Empty<TrainExtractColorModel>();
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
					num = 4;
					continue;
				case 4:
					break;
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
		internal static object SAaJuwsVws5DWSkGavS3(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tF0qxksVsDTHbbpja2HH(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter WQM4hGsVh54bb53QakCM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bfrbtUsH8RvKF5rkuuJN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oIVZs3sHzXDT6xSnQovg()
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
	private struct _003CDeleteColorModel_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TrainExtractColorToolApi _003C_003E4__this;

		public int groupId;

		public int colorModelId;

		private TaskAwaiter<object> _003C_003Eu__1;

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
			TaskAwaiter awaiter = default;
			TaskAwaiter<object> awaiter2 = default;
			TrainExtractColorToolApi trainExtractColorToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					M3xJmhsV9oL82U8cEOeb();
					num = ((!P0OCfFsVLiox70S59Yex()) ? 2 : 5);
					break;
				case 0:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 3;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								_ = 0;
								if (P0OCfFsVLiox70S59Yex())
								{
									num3 = 7;
								}
								else
								{
									num3 = 1;
									if (false)
									{
										goto IL_01a8;
									}
								}
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 9;
						}
						goto IL_00be;
						IL_01a8:
						_003C_003Eu__1 = awaiter2;
						num3 = 4;
						goto IL_00be;
						IL_00be:
						while (true)
						{
							switch (num3)
							{
							case 0:
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
							case 13:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								if (!M3xJmhsV9oL82U8cEOeb())
								{
									continue;
								}
								return;
							case 11:
								return;
							case 9:
								_003C_003Eu__1 = default;
								goto case 8;
							default:
								num3 = 8;
								continue;
							case 15:
								num2 = (_003C_003E1__state = 1);
								num3 = 0;
								continue;
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								continue;
							case 10:
								if (!awaiter2.IsCompleted)
								{
									num3 = 2;
									if (P0OCfFsVLiox70S59Yex())
									{
										continue;
									}
									goto case 8;
								}
								goto case 14;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 14;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 5:
								return;
							case 7:
							case 12:
								_003C_003Eu__2 = default;
								goto case 1;
							case 6:
								break;
							case 14:
								awaiter2.GetResult();
								awaiter = PtEYTYsVvYPXJ37OufMu(trainExtractColorToolApi.RunChangeAsync());
								if (!awaiter.IsCompleted)
								{
									num3 = 15;
									continue;
								}
								goto case 16;
							case 3:
								awaiter2 = trainExtractColorToolApi.CellEditData.PostAsync<object>((string)y7iSM0sVE14vbEn59fDx(p6MueisVS7peZSR7GEVS(52060), groupId), new object[1] { colorModelId }).GetAwaiter();
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								goto case 4;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 11;
								continue;
							case 16:
								awaiter.GetResult();
								goto end_IL_00be;
							}
							goto IL_01a8;
							continue;
							end_IL_00be:
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
					break;
				case 1:
				case 5:
					trainExtractColorToolApi = _003C_003E4__this;
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
		internal static object p6MueisVS7peZSR7GEVS(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object y7iSM0sVE14vbEn59fDx(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter PtEYTYsVvYPXJ37OufMu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool P0OCfFsVLiox70S59Yex()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool M3xJmhsV9oL82U8cEOeb()
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
	private struct _003CRenameColorModel_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TrainExtractColorToolApi _003C_003E4__this;

		public int groupId;

		public int colorModelId;

		public string newName;

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
			TrainExtractColorToolApi trainExtractColorToolApi = default;
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
								_003C_003Eu__2 = default;
								goto IL_01c2;
							}
							num3 = 6;
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 15;
						}
						goto IL_015d;
						IL_015d:
						while (true)
						{
							switch (num3)
							{
							case 15:
								_003C_003Eu__1 = default;
								num3 = 14;
								if (0 == 0)
								{
									continue;
								}
								goto case 10;
							case 10:
								_003C_003Eu__2 = awaiter;
								num3 = 8;
								if (s7pyArsVHvIHVTLC56iG())
								{
									continue;
								}
								return;
							case 3:
								return;
							case 1:
							case 9:
								if (!awaiter2.IsCompleted)
								{
									num3 = 0;
									if (jmCj17sVVf3JNOc3d44f())
									{
									}
									continue;
								}
								goto case 2;
							case 0:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								num3 = 12;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 7:
								return;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								continue;
							case 6:
								break;
							case 14:
								num2 = (_003C_003E1__state = -1);
								goto case 2;
							default:
								num3 = 2;
								continue;
							case 2:
								awaiter2.GetResult();
								num3 = 4;
								continue;
							case 5:
							case 13:
								goto end_IL_015d;
							case 12:
								goto IL_01d7;
							case 4:
								awaiter = o7tucdsVUUVpIAQrkeku(trainExtractColorToolApi.RunChangeAsync());
								num3 = 11;
								continue;
							case 11:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 10;
									if (0 == 0)
									{
										continue;
									}
								}
								goto case 16;
							case 16:
								awaiter.GetResult();
								goto end_IL_0018;
							}
							awaiter2 = trainExtractColorToolApi.CellEditData.PutAsync<object>((string)RGFomwsVDo3hEAmTy59I(PstSEPsVAR4LwwGSrZXM(52108), groupId, colorModelId), newName).GetAwaiter();
							_ = 1;
							num3 = ((!jmCj17sVVf3JNOc3d44f()) ? 9 : 5);
							continue;
							end_IL_015d:
							break;
						}
						goto IL_01c2;
						IL_01c2:
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						if (0 == 0)
						{
							goto IL_015d;
						}
						goto IL_01d7;
						IL_01d7:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						num3 = 7;
						goto IL_015d;
						end_IL_0018:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 1:
				case 4:
					trainExtractColorToolApi = _003C_003E4__this;
					num = 2;
					continue;
				case 5:
					num2 = _003C_003E1__state;
					s7pyArsVHvIHVTLC56iG();
					if (jmCj17sVVf3JNOc3d44f())
					{
						num = 0;
						continue;
					}
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
		internal static object PstSEPsVAR4LwwGSrZXM(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RGFomwsVDo3hEAmTy59I(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter o7tucdsVUUVpIAQrkeku(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool s7pyArsVHvIHVTLC56iG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jmCj17sVVf3JNOc3d44f()
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
	private struct _003CSetColorModelDarkMatteLineTolerance_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TrainExtractColorToolApi _003C_003E4__this;

		public int groupId;

		public int colorModelId;

		public double tolerance;

		private TaskAwaiter<object> _003C_003Eu__1;

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
			if (F95edgsVTIXeup1l7a4k())
			{
				num = 1;
			}
			else
			{
				num = 5;
				if (!F95edgsVTIXeup1l7a4k())
				{
					return;
				}
			}
			int num2 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<object> awaiter2 = default;
			TrainExtractColorToolApi trainExtractColorToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					if (Fiey2dsVdxOpBXobglCd())
					{
					}
					continue;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 4:
					break;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 3;
								if (!F95edgsVTIXeup1l7a4k())
								{
									goto IL_0084;
								}
							}
							else
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 11;
						}
						goto IL_011e;
						IL_0084:
						num2 = (_003C_003E1__state = -1);
						num3 = 7;
						goto IL_011e;
						IL_011e:
						while (true)
						{
							IL_011e_2:
							switch (num3)
							{
							case 8:
								break;
							case 3:
								awaiter2 = trainExtractColorToolApi.CellEditData.PutAsync<object>((string)z0RtqosVq54uILGDsO7T(nF5ClVsViX9vHZ2aU2mX(52164), groupId, colorModelId), tolerance).GetAwaiter();
								num3 = 1;
								continue;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 14;
								if (!Fiey2dsVdxOpBXobglCd())
								{
									continue;
								}
								goto case 11;
							case 11:
								_003C_003Eu__1 = default;
								break;
							default:
								num3 = 8;
								if (F95edgsVTIXeup1l7a4k())
								{
									continue;
								}
								goto case 15;
							case 15:
								awaiter = E3deXUsVBPfYfOjRZENE(trainExtractColorToolApi.RunChangeAsync());
								num3 = 2;
								continue;
							case 7:
								awaiter2.GetResult();
								num3 = 15;
								continue;
							case 1:
								if (!awaiter2.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								goto case 7;
							case 0:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								continue;
							case 6:
							case 12:
								_003C_003Eu__2 = awaiter;
								goto case 10;
							case 9:
								while (true)
								{
									num2 = (_003C_003E1__state = 1);
									F95edgsVTIXeup1l7a4k();
									if (!Fiey2dsVdxOpBXobglCd())
									{
										break;
									}
									num3 = 10;
									if (!Fiey2dsVdxOpBXobglCd())
									{
										goto IL_011e_2;
									}
								}
								num3 = 6;
								if (0 == 0)
								{
									continue;
								}
								goto case 4;
							case 4:
								_003C_003Eu__1 = awaiter2;
								num3 = 5;
								if (F95edgsVTIXeup1l7a4k())
								{
									continue;
								}
								return;
							case 14:
								return;
							case 10:
							case 13:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									if (true)
									{
										continue;
									}
								}
								goto case 16;
							case 16:
								awaiter.GetResult();
								goto end_IL_011e;
							}
							goto IL_0084;
							continue;
							end_IL_011e:
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
				case 6:
					return;
				}
				trainExtractColorToolApi = _003C_003E4__this;
				num = 2;
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
		internal static object nF5ClVsViX9vHZ2aU2mX(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object z0RtqosVq54uILGDsO7T(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter E3deXUsVBPfYfOjRZENE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool F95edgsVTIXeup1l7a4k()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Fiey2dsVdxOpBXobglCd()
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
	private struct _003CSetColorModelHighlightLineTolerance_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TrainExtractColorToolApi _003C_003E4__this;

		public int groupId;

		public int colorModelId;

		public double tolerance;

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
			TrainExtractColorToolApi trainExtractColorToolApi = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<object> awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					_ = 1;
					num = ((!jvVDnVsVcfoI5mmfuVkw()) ? 2 : 0);
					continue;
				case 1:
				case 2:
					trainExtractColorToolApi = _003C_003E4__this;
					num = 4;
					continue;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								_ = 1;
								num3 = (jvVDnVsVcfoI5mmfuVkw() ? 10 : 2);
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 15;
								if (!Uan3jrsVj4ML8ucc7JmI())
								{
									goto IL_020c;
								}
							}
							goto IL_0163;
						}
						awaiter2 = _003C_003Eu__1;
						goto IL_0094;
						IL_0094:
						_003C_003Eu__1 = default;
						num3 = 9;
						goto IL_0163;
						IL_020c:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						num3 = 7;
						goto IL_0163;
						IL_0163:
						while (true)
						{
							switch (num3)
							{
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 11;
									continue;
								}
								goto case 16;
							case 5:
							case 10:
								break;
							case 0:
							case 2:
								awaiter2 = trainExtractColorToolApi.CellEditData.PutAsync<object>((string)CgWAVxsVWi1G3cegxcb3(XnyHhSsV2XUZXLL6EB73(52242), groupId, colorModelId), tolerance).GetAwaiter();
								num3 = 8;
								continue;
							case 4:
								_003C_003Eu__1 = awaiter2;
								num3 = 12;
								continue;
							case 15:
								_003C_003Eu__2 = default;
								num3 = 6;
								if (Uan3jrsVj4ML8ucc7JmI())
								{
									continue;
								}
								goto case 6;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 11:
								num2 = (_003C_003E1__state = 1);
								num3 = 14;
								continue;
							case 9:
								num2 = (_003C_003E1__state = -1);
								goto case 13;
							default:
								num3 = 13;
								continue;
							case 7:
								return;
							case 13:
								awaiter2.GetResult();
								awaiter = BmnkP1sV7iFJrAk3SE78(trainExtractColorToolApi.RunChangeAsync());
								num3 = 1;
								continue;
							case 3:
								return;
							case 12:
								goto IL_020c;
							case 14:
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								continue;
							case 8:
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 4;
									continue;
								}
								goto case 13;
							case 16:
								awaiter.GetResult();
								goto end_IL_005b;
							}
							break;
						}
						goto IL_0094;
						end_IL_005b:;
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
		internal static object XnyHhSsV2XUZXLL6EB73(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CgWAVxsVWi1G3cegxcb3(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter BmnkP1sV7iFJrAk3SE78(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Uan3jrsVj4ML8ucc7JmI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jvVDnVsVcfoI5mmfuVkw()
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
	private struct _003CSetColorModelHueTolerance_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TrainExtractColorToolApi _003C_003E4__this;

		public int groupId;

		public int colorModelId;

		public double tolerance;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

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
			goto IL_0280;
			IL_0033:
			int num2 = default;
			TrainExtractColorToolApi trainExtractColorToolApi = default;
			try
			{
				int num3;
				TaskAwaiter awaiter = default;
				TaskAwaiter<object> awaiter2 = default;
				if (num2 != 0)
				{
					if (num2 != 1)
					{
						num3 = 10;
					}
					else
					{
						awaiter = _003C_003Eu__2;
						num3 = 6;
					}
				}
				else
				{
					awaiter2 = _003C_003Eu__1;
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 15:
						_003C_003Eu__1 = awaiter2;
						num3 = 3;
						if (FMVtSbsVthsR2GeaWxTU())
						{
							continue;
						}
						goto case 6;
					case 6:
						_003C_003Eu__2 = default;
						goto case 12;
					case 12:
					case 13:
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						continue;
					case 14:
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 1);
							num3 = 2;
							continue;
						}
						break;
					case 8:
						awaiter2.GetResult();
						awaiter = MdoLKAsVoipsBscrDD0c(trainExtractColorToolApi.RunChangeAsync());
						num3 = 14;
						continue;
					case 11:
						num2 = (_003C_003E1__state = -1);
						goto case 8;
					default:
						num3 = 8;
						if (true)
						{
							continue;
						}
						goto case 9;
					case 9:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 4;
						if (0 == 0)
						{
							continue;
						}
						goto case 5;
					case 5:
						num2 = (_003C_003E1__state = 0);
						num3 = 15;
						if (0 == 0)
						{
							continue;
						}
						goto case 2;
					case 2:
						_003C_003Eu__2 = awaiter;
						num3 = 9;
						continue;
					case 3:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					case 0:
						_003C_003Eu__1 = default;
						num3 = 11;
						continue;
					case 10:
						awaiter2 = trainExtractColorToolApi.CellEditData.PutAsync<object>((string)tLVHtWsV5usPV5W2qb5A(JthLk4sVKZ8riHbGfRL5(52326), groupId, colorModelId), tolerance).GetAwaiter();
						GwqiPLsVCHhG4DYDfVci();
						num3 = (FMVtSbsVthsR2GeaWxTU() ? 7 : 12);
						continue;
					case 1:
					case 7:
						if (!awaiter2.IsCompleted)
						{
							num3 = 5;
							continue;
						}
						goto case 8;
					case 4:
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
			goto IL_02ce;
			IL_0280:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					break;
				case 2:
				case 5:
					goto IL_0033;
				default:
					num = 3;
					if (true)
					{
						continue;
					}
					goto case 4;
				case 4:
					num2 = _003C_003E1__state;
					GwqiPLsVCHhG4DYDfVci();
					if (!FMVtSbsVthsR2GeaWxTU())
					{
						num = 5;
						if (0 == 0)
						{
							continue;
						}
						goto IL_0033;
					}
					num = 0;
					continue;
				case 3:
					goto IL_02ce;
				case 6:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_02ce:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0280;
			IL_001a:
			trainExtractColorToolApi = _003C_003E4__this;
			goto IL_0033;
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
		internal static object JthLk4sVKZ8riHbGfRL5(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tLVHtWsV5usPV5W2qb5A(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter MdoLKAsVoipsBscrDD0c(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FMVtSbsVthsR2GeaWxTU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GwqiPLsVCHhG4DYDfVci()
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
	private struct _003CSetColorModelLightMatteLineTolerance_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TrainExtractColorToolApi _003C_003E4__this;

		public int groupId;

		public int colorModelId;

		public double tolerance;

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
			TrainExtractColorToolApi trainExtractColorToolApi = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<object> awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (WcGFTmsVPGwtlIUCW1ch())
					{
						break;
					}
					goto case 0;
				case 0:
					num2 = _003C_003E1__state;
					oXyH0EsVYFY336759DMs();
					num = ((!WcGFTmsVPGwtlIUCW1ch()) ? 3 : 4);
					break;
				case 1:
				case 4:
					trainExtractColorToolApi = _003C_003E4__this;
					goto case 2;
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								_ = 0;
								if (WcGFTmsVPGwtlIUCW1ch())
								{
									num3 = 1;
									if (!WcGFTmsVPGwtlIUCW1ch())
									{
										goto IL_0094;
									}
								}
								else
								{
									num3 = 6;
								}
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 13;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 3;
						}
						goto IL_0149;
						IL_0149:
						while (true)
						{
							switch (num3)
							{
							case 14:
								break;
							case 15:
								if (!awaiter2.IsCompleted)
								{
									num3 = 12;
									if (oXyH0EsVYFY336759DMs())
									{
									}
									continue;
								}
								goto case 6;
							case 11:
								return;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								if (!oXyH0EsVYFY336759DMs())
								{
									continue;
								}
								goto case 13;
							case 13:
								_003C_003Eu__2 = default;
								num3 = 5;
								continue;
							case 12:
								num2 = (_003C_003E1__state = 0);
								num3 = 10;
								continue;
							case 3:
								_003C_003Eu__1 = default;
								goto case 7;
							default:
								num3 = 7;
								continue;
							case 4:
								return;
							case 7:
								num2 = (_003C_003E1__state = -1);
								goto case 6;
							case 6:
							case 8:
								awaiter2.GetResult();
								awaiter = N2yjIfsVxBWwPyc3XbRT(trainExtractColorToolApi.RunChangeAsync());
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									continue;
								}
								goto case 16;
							case 0:
							case 1:
								awaiter2 = trainExtractColorToolApi.CellEditData.PutAsync<object>((string)M41mLAsVNnqmZLuX4Len(kgbOBx7BanbFa22Hp9.ol99ukmDA(52398), groupId, colorModelId), tolerance).GetAwaiter();
								num3 = 15;
								continue;
							case 10:
								_003C_003Eu__1 = awaiter2;
								num3 = 2;
								continue;
							case 9:
								num2 = (_003C_003E1__state = 1);
								num3 = 14;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 11;
								continue;
							case 16:
								awaiter.GetResult();
								goto end_IL_0149;
							}
							goto IL_0094;
							continue;
							end_IL_0149:
							break;
						}
						goto end_IL_006b;
						IL_0094:
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 4;
						goto IL_0149;
						end_IL_006b:;
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
		internal static object M41mLAsVNnqmZLuX4Len(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter N2yjIfsVxBWwPyc3XbRT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WcGFTmsVPGwtlIUCW1ch()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oXyH0EsVYFY336759DMs()
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
	private struct _003CSetColorModelOperation_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TrainExtractColorToolApi _003C_003E4__this;

		public int groupId;

		public int colorModelId;

		public TrainExtractColorModelOperation operation;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Cvv4xGsV1fHfLfTtfycy();
			int num = (qSbOphsVryQLI0PYWaky() ? 4 : 3);
			int num2 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<object> awaiter2 = default;
			TrainExtractColorToolApi trainExtractColorToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						break;
					}
					goto case 2;
				case 2:
				case 4:
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
								awaiter = _003C_003Eu__2;
								num3 = 12;
								if (qSbOphsVryQLI0PYWaky())
								{
								}
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							case 11:
							case 13:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 1:
								_003C_003Eu__1 = default;
								Cvv4xGsV1fHfLfTtfycy();
								if (!qSbOphsVryQLI0PYWaky())
								{
									num3 = 14;
									if (Cvv4xGsV1fHfLfTtfycy())
									{
										continue;
									}
									goto case 12;
								}
								num3 = 11;
								continue;
							case 12:
								_003C_003Eu__2 = default;
								goto case 11;
							case 0:
								awaiter = y6mFpdsVOGLsEfNjg9p7(trainExtractColorToolApi.RunChangeAsync());
								num3 = 9;
								continue;
							case 7:
								return;
							case 4:
								_003C_003Eu__2 = awaiter;
								num3 = 10;
								continue;
							case 15:
								_003C_003Eu__1 = awaiter2;
								num3 = 2;
								continue;
							case 6:
							case 14:
								num2 = (_003C_003E1__state = -1);
								goto IL_0108;
							default:
								num3 = 0;
								continue;
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								break;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 15;
								if (0 == 0)
								{
									continue;
								}
								goto case 8;
							case 8:
								num2 = (_003C_003E1__state = 1);
								num3 = 4;
								continue;
							case 5:
								awaiter2 = trainExtractColorToolApi.CellEditData.PutAsync<object>((string)OnAML0sV3QRMZKE3dNiC(kgbOBx7BanbFa22Hp9.ol99ukmDA(52478), groupId, colorModelId), (int)operation).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto IL_0108;
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 7;
								if (true)
								{
									continue;
								}
								break;
							case 16:
								break;
								IL_0108:
								awaiter2.GetResult();
								goto case 0;
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
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 1;
					break;
				case 1:
					trainExtractColorToolApi = _003C_003E4__this;
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
		internal static object OnAML0sV3QRMZKE3dNiC(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter y6mFpdsVOGLsEfNjg9p7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Cvv4xGsV1fHfLfTtfycy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qSbOphsVryQLI0PYWaky()
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
	private struct _003CGetColorSamples_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<TrainExtractColorSamples> _003C_003Et__builder;

		public TrainExtractColorToolApi _003C_003E4__this;

		public int groupId;

		public int colorModelId;

		public int numSamples;

		private TaskAwaiter<TrainExtractColorSamples> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = ((!iruvV5sVQIulB4QZjJ3i()) ? 1 : 5);
			TrainExtractColorSamples result = default;
			int num2 = default;
			TrainExtractColorToolApi trainExtractColorToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 2:
				case 5:
					try
					{
						TaskAwaiter<TrainExtractColorSamples> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = trainExtractColorToolApi.CellEditData.PostAsync<TrainExtractColorSamples>((string)Fq3qUQsVlfjiTP7jyYmm(52544), new object[3] { groupId, colorModelId, numSamples }).GetAwaiter();
							num3 = 8;
							goto IL_0148;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0112;
						IL_0112:
						_003C_003Eu__1 = default;
						num3 = 6;
						goto IL_0148;
						IL_0148:
						while (true)
						{
							switch (num3)
							{
							case 7:
								return;
							case 0:
								do
								{
									num2 = (_003C_003E1__state = 0);
									iruvV5sVQIulB4QZjJ3i();
									if (!H4PnSQsVMDrdqgMjMjtg())
									{
										num3 = 3;
										continue;
									}
									num3 = 1;
									break;
								}
								while (false);
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								goto case 9;
							case 1:
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								if (true)
								{
									continue;
								}
								break;
							case 3:
							case 5:
								break;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								if (H4PnSQsVMDrdqgMjMjtg())
								{
									continue;
								}
								goto case 9;
							case 9:
								result = awaiter.GetResult();
								goto end_IL_0148;
							}
							goto IL_0112;
							continue;
							end_IL_0148:
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
					goto case 3;
				default:
					num = 3;
					break;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					break;
				case 4:
					trainExtractColorToolApi = _003C_003E4__this;
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
		internal static object Fq3qUQsVlfjiTP7jyYmm(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool H4PnSQsVMDrdqgMjMjtg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iruvV5sVQIulB4QZjJ3i()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TrainExtractColorToolApi(CvsInSight insight, CvsCellLocation cellLoc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VTq39Tio6hpdM0QWLYH();
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
	[AsyncStateMachine(typeof(_003CSetLibraryName_003Ed__2))]
	public Task SetLibraryName(string libraryName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003CSetLibraryName_003Ed__2 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 6:
				stateMachine._003C_003Et__builder = e0pKNYiPeNfBqPQUDEA();
				_ = 0;
				if (FXH5i6iKCpRKOCZZoLS())
				{
					num = 4;
					if (true)
					{
						break;
					}
					goto case 1;
				}
				num = 0;
				break;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 0;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 0:
			case 2:
				stateMachine.libraryName = libraryName;
				goto case 3;
			default:
				num = 3;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSelectedModelType_003Ed__3))]
	public Task<TrainExtractColorLibraryModelType> GetSelectedModelType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetSelectedModelType_003Ed__3 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<TrainExtractColorLibraryModelType>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetSelectedModelType_003Ed__4))]
	public Task SetSelectedModelType(TrainExtractColorLibraryModelType modelType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (!XQ6Udci5lUAr17I6BXc())
		{
		}
		_003CSetSelectedModelType_003Ed__4 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
				stateMachine.modelType = modelType;
				goto case 0;
			default:
				num = 0;
				break;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				stateMachine._003C_003Et__builder = e0pKNYiPeNfBqPQUDEA();
				XQ6Udci5lUAr17I6BXc();
				num = (FXH5i6iKCpRKOCZZoLS() ? 4 : 3);
				break;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateGroup_003Ed__5))]
	public Task<TrainExtractColorGroup> CreateGroup(string groupName = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateGroup_003Ed__5 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<TrainExtractColorGroup>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.groupName = groupName;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDeleteGroup_003Ed__6))]
	public Task DeleteGroup(int groupId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		FXH5i6iKCpRKOCZZoLS();
		int num = (XQ6Udci5lUAr17I6BXc() ? 3 : 2);
		_003CDeleteGroup_003Ed__6 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 6;
				continue;
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 1:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			case 5:
				stateMachine.groupId = groupId;
				goto case 1;
			default:
				num = 1;
				continue;
			case 3:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (FXH5i6iKCpRKOCZZoLS())
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
	[AsyncStateMachine(typeof(_003CRenameGroup_003Ed__7))]
	public Task RenameGroup(int groupId, string newName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!FXH5i6iKCpRKOCZZoLS()) ? 2 : 3);
		_003CRenameGroup_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				stateMachine._003C_003E1__state = -1;
				num = 4;
				if (true)
				{
					break;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 7;
				if (FXH5i6iKCpRKOCZZoLS())
				{
					break;
				}
				goto case 7;
			case 7:
				stateMachine.groupId = groupId;
				num = 5;
				break;
			case 5:
				stateMachine.newName = newName;
				goto case 6;
			default:
				num = 6;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = e0pKNYiPeNfBqPQUDEA();
				goto case 1;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetSelectedGroup_003Ed__8))]
	public Task SetSelectedGroup(int groupId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		XQ6Udci5lUAr17I6BXc();
		int num = ((!FXH5i6iKCpRKOCZZoLS()) ? 4 : 3);
		_003CSetSelectedGroup_003Ed__8 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 6;
				break;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				num = 1;
				break;
			case 2:
			case 4:
				stateMachine.groupId = groupId;
				goto case 5;
			default:
				num = 5;
				break;
			case 6:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetAllGroups_003Ed__9))]
	public Task<Dictionary<string, TrainExtractColorGroup>> GetAllGroups()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetAllGroups_003Ed__9 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Dictionary<string, TrainExtractColorGroup>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetColorModelOrder_003Ed__10))]
	public Task SetColorModelOrder(int groupId, int[] colorModelIds)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!FXH5i6iKCpRKOCZZoLS())
		{
			goto IL_001e;
		}
		goto IL_0038;
		IL_001e:
		_003CSetColorModelOrder_003Ed__10 stateMachine = default;
		stateMachine.colorModelIds = colorModelIds;
		goto IL_0061;
		IL_0038:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			default:
				goto IL_0061;
			case 1:
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				continue;
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 7;
				if (FXH5i6iKCpRKOCZZoLS())
				{
					continue;
				}
				goto case 3;
			case 3:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			case 7:
				stateMachine.groupId = groupId;
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
				stateMachine._003C_003Et__builder = e0pKNYiPeNfBqPQUDEA();
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 8;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001e;
		IL_0061:
		_ = 1;
		num = (XQ6Udci5lUAr17I6BXc() ? 1 : 3);
		goto IL_0038;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetTrainEditView_003Ed__11))]
	public Task<CvsCogView> GetTrainEditView()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetTrainEditView_003Ed__11 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCogView>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CTrainSingleColor_003Ed__12))]
	public Task<TrainExtractColorModel> TrainSingleColor(int groupId, CvsCogShape shape, TrainExtractColorModelOperation operation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CTrainSingleColor_003Ed__12 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<TrainExtractColorModel>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.groupId = groupId;
		stateMachine.shape = shape;
		stateMachine.operation = operation;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CTrainMultipleColors_003Ed__13))]
	public Task<TrainExtractColorModel[]> TrainMultipleColors(int groupId, CvsCogShape shape, TrainExtractColorModelOperation operation, float minimumColorArea, float smoothing)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CTrainMultipleColors_003Ed__13 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<TrainExtractColorModel[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.groupId = groupId;
		stateMachine.shape = shape;
		stateMachine.operation = operation;
		stateMachine.minimumColorArea = minimumColorArea;
		stateMachine.smoothing = smoothing;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDeleteColorModel_003Ed__14))]
	public Task DeleteColorModel(int groupId, int colorModelId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CDeleteColorModel_003Ed__14 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder = e0pKNYiPeNfBqPQUDEA();
				XQ6Udci5lUAr17I6BXc();
				if (FXH5i6iKCpRKOCZZoLS())
				{
					num = 7;
					break;
				}
				num = 2;
				if (XQ6Udci5lUAr17I6BXc())
				{
				}
				break;
			case 0:
				stateMachine.groupId = groupId;
				goto case 2;
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 2:
			case 3:
				stateMachine.colorModelId = colorModelId;
				goto case 4;
			default:
				num = 4;
				break;
			case 1:
			case 7:
				stateMachine._003C_003E4__this = this;
				num = 0;
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRenameColorModel_003Ed__15))]
	public Task RenameColorModel(int groupId, int colorModelId, string newName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		XQ6Udci5lUAr17I6BXc();
		int num;
		if (FXH5i6iKCpRKOCZZoLS())
		{
			num = 7;
			if (XQ6Udci5lUAr17I6BXc())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0048;
		IL_007f:
		_003CRenameColorModel_003Ed__15 stateMachine = default;
		stateMachine.newName = newName;
		num = 8;
		goto IL_0048;
		IL_0048:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			default:
				num = 1;
				continue;
			case 1:
				goto IL_007f;
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 2:
			case 4:
				stateMachine.groupId = groupId;
				num = 3;
				if (XQ6Udci5lUAr17I6BXc())
				{
				}
				continue;
			case 8:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				if (!XQ6Udci5lUAr17I6BXc())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 7:
				stateMachine._003C_003Et__builder = e0pKNYiPeNfBqPQUDEA();
				num = 5;
				continue;
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				continue;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		stateMachine.colorModelId = colorModelId;
		goto IL_007f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetColorModelDarkMatteLineTolerance_003Ed__16))]
	public Task SetColorModelDarkMatteLineTolerance(int groupId, int colorModelId, double tolerance)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		XQ6Udci5lUAr17I6BXc();
		int num = ((!FXH5i6iKCpRKOCZZoLS()) ? 8 : 3);
		_003CSetColorModelDarkMatteLineTolerance_003Ed__16 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine.colorModelId = colorModelId;
				goto case 4;
			default:
				num = 4;
				break;
			case 4:
				stateMachine.tolerance = tolerance;
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine.groupId = groupId;
				num = 2;
				break;
			case 1:
			case 8:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = e0pKNYiPeNfBqPQUDEA();
				goto case 1;
			case 7:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				break;
			case 6:
				stateMachine._003C_003E1__state = -1;
				num = 7;
				break;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetColorModelHighlightLineTolerance_003Ed__17))]
	public Task SetColorModelHighlightLineTolerance(int groupId, int colorModelId, double tolerance)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003CSetColorModelHighlightLineTolerance_003Ed__17 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 8:
				stateMachine._003C_003E4__this = this;
				goto case 0;
			case 7:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				if (XQ6Udci5lUAr17I6BXc())
				{
				}
				break;
			case 0:
			case 2:
				stateMachine.groupId = groupId;
				num = 4;
				break;
			case 4:
				stateMachine.colorModelId = colorModelId;
				goto case 3;
			default:
				num = 3;
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				num = 7;
				if (0 == 0)
				{
					break;
				}
				goto case 6;
			case 6:
				stateMachine._003C_003Et__builder = e0pKNYiPeNfBqPQUDEA();
				_ = 1;
				if (XQ6Udci5lUAr17I6BXc())
				{
					num = 0;
					if (0 == 0)
					{
						break;
					}
					goto case 7;
				}
				num = 8;
				if (FXH5i6iKCpRKOCZZoLS())
				{
					break;
				}
				goto case 3;
			case 3:
				stateMachine.tolerance = tolerance;
				num = 5;
				break;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetColorModelHueTolerance_003Ed__18))]
	public Task SetColorModelHueTolerance(int groupId, int colorModelId, double tolerance)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		_003CSetColorModelHueTolerance_003Ed__18 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine.groupId = groupId;
				num = 1;
				continue;
			case 3:
			case 4:
				stateMachine.tolerance = tolerance;
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			case 2:
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				continue;
			case 8:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
				stateMachine.colorModelId = colorModelId;
				goto default;
			default:
				_ = 1;
				if (XQ6Udci5lUAr17I6BXc())
				{
					num = 2;
					if (true)
					{
						continue;
					}
					goto case 2;
				}
				num = 3;
				if (!XQ6Udci5lUAr17I6BXc())
				{
					continue;
				}
				goto case 7;
			case 7:
				stateMachine._003C_003Et__builder = e0pKNYiPeNfBqPQUDEA();
				num = 8;
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
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetColorModelLightMatteLineTolerance_003Ed__19))]
	public Task SetColorModelLightMatteLineTolerance(int groupId, int colorModelId, double tolerance)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CSetColorModelLightMatteLineTolerance_003Ed__19 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine.tolerance = tolerance;
				goto case 0;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				break;
			case 3:
			case 8:
				stateMachine.colorModelId = colorModelId;
				goto case 1;
			default:
				num = 1;
				break;
			case 0:
			case 5:
				stateMachine._003C_003E1__state = -1;
				num = 4;
				break;
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 7;
				break;
			case 7:
				stateMachine.groupId = groupId;
				FXH5i6iKCpRKOCZZoLS();
				if (XQ6Udci5lUAr17I6BXc())
				{
					num = 0;
					if (XQ6Udci5lUAr17I6BXc())
					{
					}
				}
				else
				{
					num = 8;
				}
				break;
			case 2:
				stateMachine._003C_003Et__builder = e0pKNYiPeNfBqPQUDEA();
				num = 6;
				break;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetColorModelOperation_003Ed__20))]
	public Task SetColorModelOperation(int groupId, int colorModelId, TrainExtractColorModelOperation operation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CSetColorModelOperation_003Ed__20 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine.colorModelId = colorModelId;
				goto case 1;
			default:
				num = 1;
				break;
			case 6:
			case 7:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				break;
			case 5:
			case 8:
				stateMachine._003C_003E1__state = -1;
				goto case 6;
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 1:
				stateMachine.operation = operation;
				_ = 0;
				if (!FXH5i6iKCpRKOCZZoLS())
				{
					num = 7;
					if (true)
					{
						break;
					}
					goto case 3;
				}
				num = 8;
				break;
			case 2:
				stateMachine.groupId = groupId;
				num = 0;
				break;
			case 4:
				stateMachine._003C_003Et__builder = e0pKNYiPeNfBqPQUDEA();
				num = 3;
				break;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetColorSamples_003Ed__21))]
	public Task<TrainExtractColorSamples> GetColorSamples(int groupId, int colorModelId, int numSamples)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetColorSamples_003Ed__21 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<TrainExtractColorSamples>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.groupId = groupId;
		stateMachine.colorModelId = colorModelId;
		stateMachine.numSamples = numSamples;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VTq39Tio6hpdM0QWLYH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FXH5i6iKCpRKOCZZoLS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XQ6Udci5lUAr17I6BXc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder e0pKNYiPeNfBqPQUDEA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
