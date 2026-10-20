using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Services;
using Newtonsoft.Json.Linq;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

internal class InspectBeadToolApi : IInspectBeadService
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCognex_002DInSight_002DServices_002DIInspectBeadService_002DClearDefectWithParamUpdate_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsInspectBeadArgUpdate> _003C_003Et__builder;

		public InspectBeadToolApi _003C_003E4__this;

		public int defectIndex;

		public CvsInspectBeadDefectType defectType;

		public int argumentIndex;

		public string expression;

		private TaskAwaiter<CvsInspectBeadArgUpdate> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!xBh8kCsEBOyut8etuRhS())
			{
				num = 5;
				if (!bgMQJdsEqDNqIx4XhQMx())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 2;
			}
			goto IL_01f7;
			IL_0059:
			InspectBeadToolApi inspectBeadToolApi = _003C_003E4__this;
			num = 4;
			goto IL_01f7;
			IL_01f7:
			CvsInspectBeadArgUpdate result = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					break;
				case 3:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (true)
					{
						continue;
					}
					goto IL_0059;
				case 1:
				case 2:
					goto IL_0059;
				case 4:
					try
					{
						TaskAwaiter<CvsInspectBeadArgUpdate> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = inspectBeadToolApi.jVFauOLVnm.PostAsync<CvsInspectBeadArgUpdate>((string)Q9G1v4sEjGQBZAdLdFeQ(50692), new object[4]
							{
								defectIndex,
								(int)defectType,
								argumentIndex,
								expression
							}).GetAwaiter();
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
							if (1 == 0)
							{
								goto IL_0114;
							}
						}
						goto IL_0177;
						IL_0114:
						num2 = (_003C_003E1__state = 0);
						_ = 1;
						num3 = (xBh8kCsEBOyut8etuRhS() ? 3 : 5);
						goto IL_0177;
						IL_0177:
						while (true)
						{
							switch (num3)
							{
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								goto case 9;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 6;
								if (true)
								{
									continue;
								}
								return;
							default:
								return;
							case 3:
								return;
							case 0:
								break;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 2:
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 9:
								result = awaiter.GetResult();
								goto end_IL_0177;
							}
							goto IL_0114;
							continue;
							end_IL_0177:
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
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			num2 = _003C_003E1__state;
			goto IL_0059;
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
		internal static object Q9G1v4sEjGQBZAdLdFeQ(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bgMQJdsEqDNqIx4XhQMx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xBh8kCsEBOyut8etuRhS()
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
	private struct _003CCognex_002DInSight_002DServices_002DIInspectBeadService_002DClearDefectWithFill_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InspectBeadToolApi _003C_003E4__this;

		public int defectIndex;

		public CvsInspectBeadDefectType defectType;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (!eOsjNrsEcfj8Z9e7L4ak())
			{
				goto IL_001e;
			}
			goto IL_01e3;
			IL_001e:
			InspectBeadToolApi inspectBeadToolApi = _003C_003E4__this;
			num = 4;
			goto IL_01e3;
			IL_01e3:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 0:
					num2 = _003C_003E1__state;
					eOsjNrsEcfj8Z9e7L4ak();
					if (!ApHThZsE2Q9yP8lIjr1C())
					{
						num = 5;
						if (eOsjNrsEcfj8Z9e7L4ak())
						{
							continue;
						}
						goto case 4;
					}
					num = 2;
					continue;
				case 4:
					try
					{
						TaskAwaiter<object> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = inspectBeadToolApi.jVFauOLVnm.PostAsync<object>(kgbOBx7BanbFa22Hp9.ol99ukmDA(50748), new object[2]
							{
								defectIndex,
								(int)defectType
							}).GetAwaiter();
							num3 = 6;
							goto IL_011f;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00b8;
						IL_00d0:
						num2 = (_003C_003E1__state = 0);
						num3 = 0;
						goto IL_011f;
						IL_00b8:
						_003C_003Eu__1 = default;
						num3 = 2;
						if (1 == 0)
						{
							goto IL_00d0;
						}
						goto IL_011f;
						IL_011f:
						while (true)
						{
							switch (num3)
							{
							case 4:
							case 5:
								break;
							case 1:
							case 3:
								goto IL_00d0;
							case 8:
								return;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								if (true)
								{
									continue;
								}
								goto case 6;
							case 6:
								if (!awaiter.IsCompleted)
								{
									goto IL_018c;
								}
								goto case 9;
							case 9:
								awaiter.GetResult();
								goto end_IL_006b;
							}
							break;
							IL_018c:
							_ = 0;
							num3 = (eOsjNrsEcfj8Z9e7L4ak() ? 3 : 4);
						}
						goto IL_00b8;
						end_IL_006b:;
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
		internal static bool eOsjNrsEcfj8Z9e7L4ak()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ApHThZsE2Q9yP8lIjr1C()
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
	private struct _003CCognex_002DInSight_002DServices_002DIInspectBeadService_002DClearDefectWithMask_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InspectBeadToolApi _003C_003E4__this;

		public int defectIndex;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!FJK1jasEWrKwTvJ94em9())
			{
				goto IL_001e;
			}
			goto IL_0195;
			IL_001e:
			int num2 = _003C_003E1__state;
			num = 1;
			goto IL_0195;
			IL_0195:
			InspectBeadToolApi inspectBeadToolApi = default;
			while (true)
			{
				IL_0195_2:
				switch (num)
				{
				case 4:
					break;
				case 2:
				case 5:
					try
					{
						TaskAwaiter<object> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = inspectBeadToolApi.jVFauOLVnm.PostAsync<object>((string)bk5e5psEtEm1qtxY0aVm(50790), new object[1] { defectIndex }).GetAwaiter();
							num3 = 8;
							goto IL_00b2;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00e9;
						IL_0101:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_00b2;
						IL_00e9:
						_003C_003Eu__1 = default;
						num3 = 7;
						if (true)
						{
							goto IL_00b2;
						}
						goto IL_0101;
						IL_00b2:
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								continue;
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								continue;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 0;
								continue;
							case 2:
							case 5:
								break;
							case 7:
								goto IL_0101;
							case 8:
								if (!awaiter.IsCompleted)
								{
									goto IL_0120;
								}
								goto case 9;
							case 0:
								return;
							case 9:
								awaiter.GetResult();
								goto end_IL_002f;
							}
							break;
							IL_0120:
							_ = 0;
							if (FJK1jasEWrKwTvJ94em9())
							{
								num3 = 6;
								if (false)
								{
									return;
								}
							}
							else
							{
								num3 = 2;
							}
						}
						goto IL_00e9;
						end_IL_002f:;
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
					while (true)
					{
						inspectBeadToolApi = _003C_003E4__this;
						_ = 0;
						if (FJK1jasEWrKwTvJ94em9())
						{
							break;
						}
						num = 0;
						if (0 == 0)
						{
							goto IL_0195_2;
						}
					}
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (FJK1jasEWrKwTvJ94em9())
					{
						continue;
					}
					return;
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
		internal static object bk5e5psEtEm1qtxY0aVm(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FJK1jasEWrKwTvJ94em9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YWXwsFsE7jAX0wNoy1hv()
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
	private struct _003CCognex_002DInSight_002DServices_002DIInspectBeadService_002DGetBeadPathMaskAndFillForEditing_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCogBeadPathMask> _003C_003Et__builder;

		public InspectBeadToolApi _003C_003E4__this;

		private TaskAwaiter<CvsCogBeadPathMask> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			if (!lw83vasECuTMlWcArEF9())
			{
				goto IL_001e;
			}
			goto IL_0189;
			IL_001e:
			int num2 = default;
			InspectBeadToolApi inspectBeadToolApi = default;
			CvsCogBeadPathMask result = default;
			try
			{
				TaskAwaiter<CvsCogBeadPathMask> awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = inspectBeadToolApi.jVFauOLVnm.PostAsync<CvsCogBeadPathMask>((string)n3gMR4sE55GaZOON888r(50832), Array.Empty<object>()).GetAwaiter();
					num3 = 8;
					if (O144vrsEKQcLw1rKBg4a())
					{
						goto IL_0054;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 5;
				}
				goto IL_00ff;
				IL_00ff:
				while (true)
				{
					switch (num3)
					{
					case 6:
						break;
					default:
						return;
					case 0:
						return;
					case 2:
					case 7:
						_003C_003Eu__1 = awaiter;
						num3 = 1;
						continue;
					case 5:
						_003C_003Eu__1 = default;
						num3 = 3;
						continue;
					case 8:
						if (!awaiter.IsCompleted)
						{
							num3 = 6;
							continue;
						}
						goto case 9;
					case 3:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						if (0 == 0)
						{
							continue;
						}
						goto case 1;
					case 1:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 9:
						result = awaiter.GetResult();
						goto end_IL_00ff;
					}
					goto IL_0054;
					continue;
					end_IL_00ff:
					break;
				}
				goto end_IL_001e;
				IL_0054:
				num2 = (_003C_003E1__state = 0);
				lw83vasECuTMlWcArEF9();
				if (!O144vrsEKQcLw1rKBg4a())
				{
					num3 = 7;
				}
				else
				{
					num3 = 0;
					if (O144vrsEKQcLw1rKBg4a())
					{
					}
				}
				goto IL_00ff;
				end_IL_001e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01ba;
			IL_0189:
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					break;
				default:
					goto IL_01ba;
				case 0:
					inspectBeadToolApi = _003C_003E4__this;
					O144vrsEKQcLw1rKBg4a();
					if (!lw83vasECuTMlWcArEF9())
					{
						num = 5;
						continue;
					}
					num = 4;
					if (true)
					{
						continue;
					}
					goto case 1;
				case 1:
					num2 = _003C_003E1__state;
					num = 0;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_001e;
			IL_01ba:
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_0189;
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
		internal static object n3gMR4sE55GaZOON888r(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lw83vasECuTMlWcArEF9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool O144vrsEKQcLw1rKBg4a()
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
	private struct _003CCognex_002DInSight_002DServices_002DIInspectBeadService_002DSetBeadPathMaskAndFill_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InspectBeadToolApi _003C_003E4__this;

		public List<int> flags;

		private TaskAwaiter<JObject> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			aJ7rXisEoTd8JFZRxt1T();
			int num;
			if (!QX7urxsEPKe492DdheUR())
			{
				num = 2;
				if (!aJ7rXisEoTd8JFZRxt1T())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 5;
				if (1 == 0)
				{
					goto IL_01df;
				}
			}
			goto IL_01ac;
			IL_01ac:
			int num2 = default;
			InspectBeadToolApi inspectBeadToolApi = default;
			switch (num)
			{
			case 0:
			case 2:
				break;
			case 4:
				try
				{
					TaskAwaiter<JObject> awaiter;
					int num3;
					if (num2 != 0)
					{
						awaiter = inspectBeadToolApi.jVFauOLVnm.PostAsync<JObject>((string)OpIRbPsEYedX0Db4nP38(50900), new object[1] { flags }).GetAwaiter();
						aJ7rXisEoTd8JFZRxt1T();
						if (!QX7urxsEPKe492DdheUR())
						{
							num3 = 4;
						}
						else
						{
							num3 = 2;
							if (!aJ7rXisEoTd8JFZRxt1T())
							{
								goto IL_00be;
							}
						}
						goto IL_011e;
					}
					awaiter = _003C_003Eu__1;
					goto IL_0155;
					IL_011e:
					while (true)
					{
						switch (num3)
						{
						case 1:
							num2 = (_003C_003E1__state = -1);
							num3 = 9;
							continue;
						case 8:
							return;
						case 6:
							break;
						case 3:
							num2 = (_003C_003E1__state = 0);
							num3 = 6;
							continue;
						case 0:
						case 4:
							if (!awaiter.IsCompleted)
							{
								num3 = 3;
								if (aJ7rXisEoTd8JFZRxt1T())
								{
									continue;
								}
								goto case 7;
							}
							goto case 9;
						case 7:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						default:
							num3 = 8;
							continue;
						case 2:
						case 5:
							goto IL_0155;
						case 9:
							awaiter.GetResult();
							goto end_IL_003f;
						}
						break;
					}
					goto IL_00be;
					IL_0155:
					_003C_003Eu__1 = default;
					num3 = 1;
					goto IL_011e;
					IL_00be:
					_003C_003Eu__1 = awaiter;
					num3 = 7;
					goto IL_011e;
					end_IL_003f:;
				}
				catch (Exception exception)
				{
					_003C_003E1__state = -2;
					_003C_003Et__builder.SetException(exception);
					return;
				}
				_003C_003E1__state = -2;
				goto IL_01df;
			default:
				goto IL_01df;
			case 1:
				goto IL_01fa;
			case 6:
				return;
			}
			goto IL_002e;
			IL_01df:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (aJ7rXisEoTd8JFZRxt1T())
			{
				goto IL_01ac;
			}
			goto IL_01fa;
			IL_002e:
			num2 = _003C_003E1__state;
			num = 1;
			goto IL_01ac;
			IL_01fa:
			inspectBeadToolApi = _003C_003E4__this;
			num = 4;
			if (QX7urxsEPKe492DdheUR())
			{
			}
			goto IL_01ac;
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
		internal static object OpIRbPsEYedX0Db4nP38(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aJ7rXisEoTd8JFZRxt1T()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QX7urxsEPKe492DdheUR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly ResourceNode jVFauOLVnm;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal InspectBeadToolApi(ResourceNode parentNode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (!M3uhFDdYUmO0paj96Ct())
		{
		}
		while (true)
		{
			switch (num)
			{
			default:
				jVFauOLVnm = parentNode;
				num = 5;
				continue;
			case 1:
			case 4:
				adBrk2dxVPOMYkIOv4u(this);
				goto default;
			case 3:
				break;
			case 5:
				return;
			}
			do
			{
				iXdK4ydN1lCySM3pPsm();
				M3uhFDdYUmO0paj96Ct();
				if (!TZmkJ9dP330PwbUFRUw())
				{
					num = 0;
					continue;
				}
				num = 4;
				break;
			}
			while (false);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DServices_002DIInspectBeadService_002DClearDefectWithParamUpdate_003Ed__2))]
	Task<CvsInspectBeadArgUpdate> IInspectBeadService.ClearDefectWithParamUpdate(int defectIndex, CvsInspectBeadDefectType defectType, int argumentIndex, string expression)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCognex_002DInSight_002DServices_002DIInspectBeadService_002DClearDefectWithParamUpdate_003Ed__2 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsInspectBeadArgUpdate>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.defectIndex = defectIndex;
		stateMachine.defectType = defectType;
		stateMachine.argumentIndex = argumentIndex;
		stateMachine.expression = expression;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DServices_002DIInspectBeadService_002DClearDefectWithFill_003Ed__3))]
	Task IInspectBeadService.ClearDefectWithFill(int defectIndex, CvsInspectBeadDefectType defectType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (M3uhFDdYUmO0paj96Ct() ? 5 : 6);
		_003CCognex_002DInSight_002DServices_002DIInspectBeadService_002DClearDefectWithFill_003Ed__3 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine.defectIndex = defectIndex;
				num = 4;
				break;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 3;
				break;
			case 4:
				stateMachine.defectType = defectType;
				goto case 7;
			default:
				num = 7;
				break;
			case 7:
				stateMachine._003C_003E1__state = -1;
				num = 2;
				break;
			case 0:
			case 6:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DServices_002DIInspectBeadService_002DClearDefectWithMask_003Ed__4))]
	Task IInspectBeadService.ClearDefectWithMask(int defectIndex)
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
		goto IL_0034;
		IL_001a:
		_003CCognex_002DInSight_002DServices_002DIInspectBeadService_002DClearDefectWithMask_003Ed__4 stateMachine = default;
		stateMachine.defectIndex = defectIndex;
		goto IL_00c3;
		IL_0034:
		while (true)
		{
			IL_0034_2:
			switch (num)
			{
			case 6:
				break;
			case 0:
				while (true)
				{
					stateMachine._003C_003Et__builder = uXitpAd1Lm8PuMvrjD3();
					TZmkJ9dP330PwbUFRUw();
					if (!M3uhFDdYUmO0paj96Ct())
					{
						break;
					}
					num = 2;
					if (TZmkJ9dP330PwbUFRUw())
					{
						goto IL_0034_2;
					}
				}
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 6;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			default:
				goto IL_00c3;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
		IL_00c3:
		stateMachine._003C_003E1__state = -1;
		num = 5;
		goto IL_0034;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<CvsInspectBeadDefect[]> IInspectBeadService.GetDefects()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return jVFauOLVnm.GetAsync<CvsInspectBeadDefect[]>(kgbOBx7BanbFa22Hp9.ol99ukmDA(9914));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DServices_002DIInspectBeadService_002DGetBeadPathMaskAndFillForEditing_003Ed__6))]
	Task<CvsCogBeadPathMask> IInspectBeadService.GetBeadPathMaskAndFillForEditing()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCognex_002DInSight_002DServices_002DIInspectBeadService_002DGetBeadPathMaskAndFillForEditing_003Ed__6 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCogBeadPathMask>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCognex_002DInSight_002DServices_002DIInspectBeadService_002DSetBeadPathMaskAndFill_003Ed__7))]
	Task IInspectBeadService.SetBeadPathMaskAndFill(List<int> flags)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCognex_002DInSight_002DServices_002DIInspectBeadService_002DSetBeadPathMaskAndFill_003Ed__7 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.flags = flags;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<CvsInspectBeadStatistics> IInspectBeadService.GetStatistics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return jVFauOLVnm.GetAsync<CvsInspectBeadStatistics>(kgbOBx7BanbFa22Hp9.ol99ukmDA(10028));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iXdK4ydN1lCySM3pPsm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void adBrk2dxVPOMYkIOv4u(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TZmkJ9dP330PwbUFRUw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool M3uhFDdYUmO0paj96Ct()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder uXitpAd1Lm8PuMvrjD3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
