using System;
using System.Collections;
using System.Collections.Generic;
using System.Composition;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.Internal;
using Cognex.Mvvm;
using Newtonsoft.Json.Linq;
using d6U6rfDQgjJaEyFRUK;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.HeightMap;

[Export(typeof(EzToolType))]
public class HeightMapToolType : EzToolType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateTool_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public HeightMapToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private HeightMapTool _003Ctool_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rUlFBjKFcFDkFi9ngBqX();
			int num;
			if (IF3J3xKF2wu0UPy0aV6v())
			{
				num = 3;
			}
			else
			{
				num = 6;
				if (false)
				{
					return;
				}
			}
			int num2 = default;
			HeightMapToolType heightMapToolType = default;
			TaskAwaiter awaiter = default;
			EzTool result = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003Ctool_003E5__2 = null;
					num = 4;
					break;
				case 2:
				case 6:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Ctool_003E5__2 = new HeightMapTool((InspectStepViewModel)xpwDJsKF1GZIpRKiSPee(heightMapToolType), isInitialized: false);
							num3 = 2;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 9;
							if (rUlFBjKFcFDkFi9ngBqX())
							{
								goto IL_0098;
							}
						}
						goto IL_00d0;
						IL_00b7:
						_003C_003Eu__1 = awaiter;
						goto IL_011c;
						IL_011c:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 8;
						goto IL_00d0;
						IL_00d0:
						while (true)
						{
							switch (num3)
							{
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 0;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 8:
								return;
							case 4:
								break;
							case 3:
							case 7:
								goto IL_00b7;
							default:
								num3 = 6;
								continue;
							case 0:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 6:
								goto IL_011c;
							case 1:
							case 5:
								if (awaiter.IsCompleted)
								{
									goto case 0;
								}
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto case 2;
							case 2:
								awaiter = AabQPCKFhaI5drv2BZUF(TBDXsmKFukA7WOJdY9Kf(_003Ctool_003E5__2, cells, cellRange));
								_ = 1;
								if (rUlFBjKFcFDkFi9ngBqX())
								{
									num3 = 7;
									if (IF3J3xKF2wu0UPy0aV6v())
									{
										continue;
									}
									goto IL_00b7;
								}
								num3 = 5;
								continue;
							case 10:
								result = _003Ctool_003E5__2;
								goto end_IL_0039;
							}
							break;
						}
						goto IL_0098;
						IL_0098:
						num2 = (_003C_003E1__state = 0);
						goto IL_00b7;
						end_IL_0039:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Ctool_003E5__2 = null;
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
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					break;
				case 1:
					heightMapToolType = _003C_003E4__this;
					goto case 2;
				case 7:
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
		internal static object xpwDJsKF1GZIpRKiSPee(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TBDXsmKFukA7WOJdY9Kf(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter AabQPCKFhaI5drv2BZUF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IF3J3xKF2wu0UPy0aV6v()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rUlFBjKFcFDkFi9ngBqX()
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
	private struct _003COnBeginAddInternal_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HeightMapToolType _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (EClM8UKFz2o0VowLtto4() ? 1 : 5);
			HeightMapToolType heightMapToolType = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					heightMapToolType = _003C_003E4__this;
					goto case 1;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						break;
					}
					goto case 1;
				case 1:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((Task)DixnUXKMLiKo7kTKd5kh(heightMapToolType.AcceptAddCommand)).GetAwaiter();
							ve5CDdKFtSO43pTwlwgV();
							if (!EClM8UKFz2o0VowLtto4())
							{
								num3 = 2;
								if (1 == 0)
								{
									goto IL_0085;
								}
							}
							else
							{
								num3 = 8;
							}
							goto IL_00d2;
						}
						awaiter = _003C_003Eu__1;
						goto IL_013a;
						IL_0163:
						awaiter.GetResult();
						goto end_IL_0052;
						IL_0085:
						if (!awaiter.IsCompleted)
						{
							num3 = 4;
							goto IL_00d2;
						}
						goto IL_0163;
						IL_013a:
						_003C_003Eu__1 = default;
						num3 = 6;
						goto IL_00d2;
						IL_00d2:
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 2:
								break;
							case 1:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								if (!EClM8UKFz2o0VowLtto4())
								{
									continue;
								}
								goto case 3;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								if (0 == 0)
								{
									continue;
								}
								goto case 6;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 7:
								return;
							case 5:
							case 8:
								goto IL_013a;
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								continue;
							case 9:
								goto IL_0163;
							}
							break;
						}
						goto IL_0085;
						end_IL_0052:;
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
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					if (!ve5CDdKFtSO43pTwlwgV())
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
		internal static object DixnUXKMLiKo7kTKd5kh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AsyncDelegateCommand)P_0).Invoke();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ve5CDdKFtSO43pTwlwgV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EClM8UKFz2o0VowLtto4()
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
	private struct _003CAddTool_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public HeightMapToolType _003C_003E4__this;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private CvsCellRange _003CpasteRange_003E5__3;

		private object _003C_003E7__wrap3;

		private HeightMapTool _003CnewTool_003E5__5;

		private TaskAwaiter<CvsCellRange> _003C_003Eu__1;

		private TaskAwaiter<object> _003C_003Eu__2;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__3;

		private TaskAwaiter _003C_003Eu__4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			if (!HX6iLwKMK8ZsURctvpAy())
			{
				goto IL_001e;
			}
			goto IL_0537;
			IL_001e:
			HeightMapToolType heightMapToolType = default;
			EzTool result = default;
			int num2 = default;
			try
			{
				TaskAwaiter awaiter = default;
				int num3;
				if ((uint)num2 > 3u)
				{
					if (num2 == 4)
					{
						awaiter = _003C_003Eu__4;
						_003C_003Eu__4 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_04b2;
					}
					_003Csheet_003E5__2 = (CvsCogSocketSheet)xSLjkIKMaap0Irkg2P8D(B8uTKYKMJpPHxX77yCMm(FSd7siKMwffeQoi4bH9t(heightMapToolType.Inspect)));
					_003CpasteRange_003E5__3 = CvsCellRange.Empty;
					num3 = 0;
				}
				try
				{
					TaskAwaiter<CvsCellRange> awaiter4 = default;
					int num4;
					TaskAwaiter<CvsCellCollection> awaiter3 = default;
					TaskAwaiter<object> awaiter2 = default;
					CvsCellRange result2 = default;
					switch (num2)
					{
					default:
						awaiter4 = heightMapToolType.RenameAndPasteTool(heightMapToolType._pasteObject).GetAwaiter();
						num4 = 5;
						goto IL_00d5;
					case 0:
						awaiter4 = _003C_003Eu__1;
						num4 = 4;
						if (true)
						{
							goto IL_00d5;
						}
						goto IL_01cd;
					case 2:
						awaiter3 = _003C_003Eu__3;
						_003C_003Eu__3 = default;
						num4 = 8;
						goto IL_00d5;
					case 1:
						awaiter2 = _003C_003Eu__2;
						num4 = 11;
						goto IL_00d5;
					case 3:
						{
							awaiter = _003C_003Eu__4;
							num4 = 7;
							goto IL_00d5;
						}
						IL_00d5:
						while (true)
						{
							switch (num4)
							{
							case 3:
								_003C_003Eu__3 = awaiter3;
								num4 = 26;
								continue;
							case 22:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter4;
								num4 = 2;
								continue;
							case 24:
								if (awaiter3.IsCompleted)
								{
									goto case 16;
								}
								goto case 9;
							default:
								num4 = 9;
								continue;
							case 8:
								num2 = (_003C_003E1__state = -1);
								goto case 16;
							case 16:
							case 19:
							{
								CvsCellCollection result3 = awaiter3.GetResult();
								_003CnewTool_003E5__5 = new HeightMapTool((InspectStepViewModel)BMChd4KMODgp58whjBbe(heightMapToolType), isInitialized: false);
								awaiter = ((Task)wxCgfnKMItQSkMdDh1SR(_003CnewTool_003E5__5, result3, _003CpasteRange_003E5__3)).GetAwaiter();
								num4 = 28;
								continue;
							}
							case 20:
								return;
							case 2:
								break;
							case 28:
								goto IL_01e7;
							case 7:
								_003C_003Eu__4 = default;
								num4 = 27;
								continue;
							case 12:
								awaiter3 = _003Csheet_003E5__2.RunAndGetCellResults().GetAwaiter();
								num4 = 24;
								if (HX6iLwKMK8ZsURctvpAy())
								{
									continue;
								}
								return;
							case 23:
								return;
							case 27:
								num2 = (_003C_003E1__state = -1);
								num4 = 0;
								continue;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num4 = 17;
								continue;
							case 10:
								return;
							case 21:
								_003C_003Eu__4 = awaiter;
								num4 = 1;
								continue;
							case 25:
								awaiter2 = _003Csheet_003E5__2.PutCellExpressionAsync(heightMapToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, heightMapToolType.FNM4UMlQav), heightMapToolType.InputImageLinks[BRFukWKMeVweSYZMvkgG(heightMapToolType)].Expression).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num4 = 15;
									continue;
								}
								goto IL_041c;
							case 13:
								goto IL_030b;
							case 9:
								num2 = (_003C_003E1__state = 2);
								num4 = 3;
								continue;
							case 0:
								goto IL_034a;
							case 5:
								goto IL_035b;
							case 14:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num4 = 10;
								if (HX6iLwKMK8ZsURctvpAy())
								{
									continue;
								}
								goto case 6;
							case 6:
							case 18:
								_003CpasteRange_003E5__3 = result2;
								num4 = 25;
								continue;
							case 15:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter2;
								num4 = 14;
								continue;
							case 17:
								return;
							case 26:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								num4 = 23;
								continue;
							case 4:
								_003C_003Eu__1 = default;
								num4 = 13;
								if (HX6iLwKMK8ZsURctvpAy())
								{
									continue;
								}
								goto case 11;
							case 11:
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_041c;
							case 29:
								{
									result = _003CnewTool_003E5__5;
									goto end_IL_0056;
								}
								IL_041c:
								awaiter2.GetResult();
								num4 = 12;
								continue;
							}
							break;
							IL_035b:
							if (!awaiter4.IsCompleted)
							{
								num4 = 22;
								continue;
							}
							goto IL_0314;
							IL_0314:
							result2 = awaiter4.GetResult();
							B13mkMKM5KYGYTRMx99f();
							num4 = (HX6iLwKMK8ZsURctvpAy() ? 18 : 16);
							continue;
							IL_030b:
							num2 = (_003C_003E1__state = -1);
							goto IL_0314;
						}
						goto IL_01cd;
						IL_01cd:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
						num4 = 20;
						if (true)
						{
							goto IL_00d5;
						}
						goto IL_01e7;
						IL_01e7:
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 3);
							num4 = 21;
							goto IL_00d5;
						}
						goto IL_034a;
						IL_034a:
						awaiter.GetResult();
						num4 = 29;
						goto IL_00d5;
						end_IL_0056:
						break;
					}
				}
				catch (object obj)
				{
					_003C_003E7__wrap3 = obj;
					num3 = 1;
					goto IL_044b;
				}
				goto end_IL_001e;
				IL_044b:
				if (num3 == 1)
				{
					awaiter = kXAOm1KMDSRGCk9t3GM4(heightMapToolType.CleanUpPastedToolOnFailedAdd(_003CpasteRange_003E5__3));
					if (!awaiter.IsCompleted)
					{
						num2 = (_003C_003E1__state = 4);
						_003C_003Eu__4 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_04b2;
				}
				goto IL_04db;
				IL_04b2:
				awaiter.GetResult();
				ea6WNrKMni2OUdyBMnUF(skOwaGKMii0AKJ77daSY((_003C_003E7__wrap3 as Exception) ?? throw _003C_003E7__wrap3));
				goto IL_04db;
				IL_04db:
				_003C_003E7__wrap3 = null;
				_003Csheet_003E5__2 = null;
				_003CpasteRange_003E5__3 = default;
				end_IL_001e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Csheet_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_055c;
			IL_0537:
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				default:
					goto IL_055c;
				case 5:
					heightMapToolType = _003C_003E4__this;
					num = 2;
					continue;
				case 0:
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					continue;
				case 1:
				case 3:
					_003Csheet_003E5__2 = null;
					goto case 0;
				case 6:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_001e;
			IL_055c:
			B13mkMKM5KYGYTRMx99f();
			num = (HX6iLwKMK8ZsURctvpAy() ? 1 : 0);
			goto IL_0537;
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
		internal static object FSd7siKMwffeQoi4bH9t(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object B8uTKYKMJpPHxX77yCMm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xSLjkIKMaap0Irkg2P8D(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int BRFukWKMeVweSYZMvkgG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).InputImageIndex;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BMChd4KMODgp58whjBbe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wxCgfnKMItQSkMdDh1SR(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter kXAOm1KMDSRGCk9t3GM4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object skOwaGKMii0AKJ77daSY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ea6WNrKMni2OUdyBMnUF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HX6iLwKMK8ZsURctvpAy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool B13mkMKM5KYGYTRMx99f()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public CvsCellLocation fillHolesOffset;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass24_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			D6NWV0KMdR1d69adBviP(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CGetUpdates_003Eb__0(PasteBuffer snippet)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Kgw3iTKMlBckRKkLVmTb(snippet, fillHolesOffset).ToString(absoluteRow: true, absoluteColumn: true);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void D6NWV0KMdR1d69adBviP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TgMVWFKMVPEcFs38J0Gb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Qk2oUdKMfVNfHHWQCmZT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation Kgw3iTKMlBckRKkLVmTb(object P_0, CvsCellLocation offset)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBuffer)P_0).GetLocationFromOrigin(offset);
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetUpdates_003Ed__24 : IEnumerable<ISnippetUpdate>, IEnumerable, IEnumerator<ISnippetUpdate>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ISnippetUpdate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private CvsCellCollection cells;

		public CvsCellCollection _003C_003E3__cells;

		private CvsCellRange range;

		public CvsCellRange _003C_003E3__range;

		public HeightMapToolType _003C_003E4__this;

		private _003C_003Ec__DisplayClass24_0 _003C_003E8__1;

		private int _003CcurrentVersion_003E5__2;

		private int _003ClatestVersion_003E5__3;

		ISnippetUpdate IEnumerator<ISnippetUpdate>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003E2__current;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public _003CGetUpdates_003Ed__24(int _003C_003E1__state)
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
			goto IL_005f;
			IL_002f:
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
			num = 6;
			if (1 == 0)
			{
				goto IL_0046;
			}
			goto IL_005f;
			IL_0046:
			this._003C_003E1__state = _003C_003E1__state;
			goto IL_002f;
			IL_005f:
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				default:
					goto IL_002f;
				case 1:
				case 2:
					goto IL_0046;
				case 0:
					goto IL_0090;
				case 6:
					return;
				}
				break;
				IL_0090:
				VAWQ7GKMrlumj6wBOP4v(this);
				_ = 0;
				num = (sCll0jKMgFIJ28p51NWr() ? 1 : 5);
			}
			goto IL_001a;
			IL_001a:
			AaX8IMKMvQodPuVKXPKM();
			num = 0;
			if (KWZj39KMs9h8aE6SIUtp())
			{
				goto IL_002f;
			}
			goto IL_005f;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 16;
			HeightMapToolType heightMapToolType = default;
			int num2 = default;
			CvsCellLocation offset = default;
			CvsCellLocation cvsCellLocation = default;
			CvsCellLocation offset2 = default;
			while (true)
			{
				switch (num)
				{
				case 11:
					_003C_003E1__state = 5;
					num = 4;
					if (sCll0jKMgFIJ28p51NWr())
					{
						break;
					}
					goto case 2;
				case 2:
					_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__3, heightMapToolType.Localizer);
					num = 17;
					break;
				case 6:
					_003C_003E2__current = new vwi48nu0V1Jw83UB8d();
					num = 11;
					if (KWZj39KMs9h8aE6SIUtp())
					{
					}
					break;
				case 5:
					_003C_003E1__state = 6;
					num = 14;
					break;
				case 0:
					_003CcurrentVersion_003E5__2 = cells.GetSnippetVersion(range);
					num = 1;
					if (!KWZj39KMs9h8aE6SIUtp())
					{
						break;
					}
					goto case 16;
				case 16:
					num2 = _003C_003E1__state;
					num = 7;
					if (sCll0jKMgFIJ28p51NWr())
					{
						break;
					}
					goto case 22;
				case 22:
					return true;
				case 9:
					return false;
				case 1:
					_003ClatestVersion_003E5__3 = SnippetPasteBuffer.GetSnippetVersion(heightMapToolType._pasteObject);
					num = 3;
					if (0 == 0)
					{
						break;
					}
					goto case 3;
				case 3:
					if (_003CcurrentVersion_003E5__2 < 1)
					{
						num = 2;
						break;
					}
					goto case 12;
				case 24:
					return true;
				case 15:
				case 21:
					if (_003CcurrentVersion_003E5__2 < 3)
					{
						_003C_003E8__1 = new _003C_003Ec__DisplayClass24_0();
						_003C_003E8__1.fillHolesOffset = new CvsCellLocation(7, 5);
						_003C_003E2__current = new AddCellUpdate(_003C_003E8__1.fillHolesOffset, heightMapToolType.FAD45yVdH2, heightMapToolType.Localizer);
						num = 26;
						if (0 == 0)
						{
							break;
						}
						goto case 13;
					}
					goto IL_02c8;
				case 13:
					switch (num2)
					{
					case 2:
						break;
					case 0:
						goto IL_00ee;
					case 3:
						goto IL_0134;
					default:
						goto IL_01d4;
					case 4:
						goto IL_02ba;
					case 1:
						goto IL_02e6;
					case 5:
						goto IL_0338;
					case 6:
						goto IL_03a5;
					}
					_003C_003E1__state = -1;
					KWZj39KMs9h8aE6SIUtp();
					if (sCll0jKMgFIJ28p51NWr())
					{
						num = 21;
						if (KWZj39KMs9h8aE6SIUtp())
						{
						}
					}
					else
					{
						num = 8;
					}
					break;
				case 12:
					if (_003CcurrentVersion_003E5__2 >= 2)
					{
						goto case 15;
					}
					offset = new CvsCellLocation(1, 4);
					num = 20;
					if (sCll0jKMgFIJ28p51NWr())
					{
						break;
					}
					goto case 19;
				case 19:
					_003C_003E2__current = new EditCellStateUpdate(offset, cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true), heightMapToolType.Localizer);
					goto case 25;
				default:
					num = 25;
					if (true)
					{
						break;
					}
					goto case 23;
				case 23:
					_003C_003E1__state = 4;
					return true;
				case 10:
					return true;
				case 20:
					cvsCellLocation = zBbELqKMPKX4Uah3K1hm(heightMapToolType._pasteObject, new CvsCellLocation(4, 1));
					num = 19;
					break;
				case 7:
					heightMapToolType = _003C_003E4__this;
					num = 13;
					break;
				case 25:
					_003C_003E1__state = 2;
					num = 22;
					break;
				case 4:
					return true;
				case 17:
					_003C_003E1__state = 1;
					num = 10;
					break;
				case 8:
				case 18:
					_003C_003E2__current = new EditArgumentUpdate(offset2, [MethodImpl(MethodImplOptions.NoInlining)] (PasteBuffer snippet) =>
					{
						while (false)
						{
							_ = ((object[])null)[0];
						}
						return _003C_003Ec__DisplayClass24_0.Kgw3iTKMlBckRKkLVmTb(snippet, _003C_003E8__1.fillHolesOffset).ToString(absoluteRow: true, absoluteColumn: true);
					}, 26, heightMapToolType.Localizer);
					num = 23;
					break;
				case 14:
					return true;
				case 26:
					_003C_003E1__state = 3;
					num = 24;
					break;
				case 27:
					{
						return false;
					}
					IL_03a5:
					_003C_003E1__state = -1;
					num = 27;
					break;
					IL_0338:
					_003C_003E1__state = -1;
					goto IL_033f;
					IL_02e6:
					_003C_003E1__state = -1;
					num = 12;
					break;
					IL_02ba:
					_003C_003E1__state = -1;
					_003C_003E8__1 = null;
					goto IL_02c8;
					IL_01d4:
					num = 9;
					break;
					IL_0134:
					_003C_003E1__state = -1;
					offset2 = new CvsCellLocation(2, 0);
					goto case 8;
					IL_00ee:
					_003C_003E1__state = -1;
					num = 0;
					break;
					IL_02c8:
					if (_003CcurrentVersion_003E5__2 < 4)
					{
						num = 6;
						if (sCll0jKMgFIJ28p51NWr())
						{
							break;
						}
						goto case 10;
					}
					goto IL_033f;
					IL_033f:
					_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__3, heightMapToolType.Localizer);
					num = 5;
					break;
				}
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			throw new NotSupportedException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator<ISnippetUpdate> IEnumerable<ISnippetUpdate>.GetEnumerator()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003CGetUpdates_003Ed__24 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetUpdates_003Ed__24(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			obj.cells = _003C_003E3__cells;
			obj.range = _003C_003E3__range;
			return obj;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<ISnippetUpdate>)this).GetEnumerator();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void AaX8IMKMvQodPuVKXPKM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void VAWQ7GKMrlumj6wBOP4v(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sCll0jKMgFIJ28p51NWr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KWZj39KMs9h8aE6SIUtp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation zBbELqKMPKX4Uah3K1hm(object P_0, CvsCellLocation offset)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBuffer)P_0).GetLocationFromOrigin(offset);
		}
	}

	private static readonly Guid[] zrO4pBfEKB;

	private readonly CvsCellLocation FNM4UMlQav;

	private int ePV47JDQO6;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zrO4pBfEKB;
		}
	}

	public override string ToolType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.O2othEcf4B();
		}
	}

	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)bHsLdB7UAepSb121uNF();
		}
	}

	public override bool IsReleased
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}
	}

	public override string Source
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Tools_ImageFilterIcon;
		}
	}

	public override string Icon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Tools_ImageFilterIcon;
		}
	}

	public override string[] Path
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new string[2]
			{
				(string)KLcbgP7HC6MfKbjhrZ8(),
				(string)TLGJpv7x5oin6YHetHF()
			};
		}
	}

	public override int Order
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ePV47JDQO6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref ePV47JDQO6, value, (string)aUnov17Yu4EQjMUBf0H(3256));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HeightMapToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 5:
			case 7:
				AddSnippet(_pasteObject);
				num = 8;
				if (fvRvQY7yXOoMJBhVBi3())
				{
					break;
				}
				goto case 0;
			case 0:
				base._002Ector();
				num = 3;
				break;
			case 6:
				FNM4UMlQav = _pasteObject.GetCellOffset((string)aUnov17Yu4EQjMUBf0H(4928));
				goto case 5;
			case 3:
				_pasteObject = (PasteBuffer)vP0wGt7MnashPHbM6ZE(lUoreZ7FpTwRclyuysS());
				goto case 6;
			default:
				num = 6;
				break;
			case 4:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				_ = 1;
				num = ((!xb3Pk570H8nDumTPehL()) ? 2 : 7);
				break;
			case 1:
			case 2:
				ePV47JDQO6 = 900;
				num = 0;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateTool_003Ed__21))]
	public override Task<EzTool> CreateTool(Guid guid, CvsCellCollection cells, CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateTool_003Ed__21 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cells = cells;
		stateMachine.cellRange = cellRange;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnBeginAddInternal_003Ed__22))]
	protected override Task OnBeginAddInternal()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003COnBeginAddInternal_003Ed__22 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
				stateMachine._003C_003Et__builder = PeiOsB7mipjHuLJXMgx();
				_ = 1;
				num = ((!xb3Pk570H8nDumTPehL()) ? 5 : 4);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddTool_003Ed__23))]
	public override Task<EzTool> AddTool()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddTool_003Ed__23 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetUpdates_003Ed__24))]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetUpdates_003Ed__24(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__cells = cells,
			_003C_003E3__range = range
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PasteBufferCell FAD45yVdH2(PasteBuffer P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation loc = x52aBe7Q55VZyHc9E7R(P_0, new CvsCellLocation(7, 5));
		JObject jObject = new JObject();
		bBUtEP72TBYVlvWF3bw(jObject, aUnov17Yu4EQjMUBf0H(1624), XNVL5m7N15OF9NYLvAq(CdQUGaROfy7He9T0foW.KbIzwHEDLa(8344)));
		jObject[(string)aUnov17Yu4EQjMUBf0H(8360)] = 21;
		bBUtEP72TBYVlvWF3bw(jObject, aUnov17Yu4EQjMUBf0H(8368), (JToken)CdQUGaROfy7He9T0foW.KbIzwHEDLa(25144));
		JObject jObject2 = jObject;
		PasteBufferCell pasteBufferCell = new PasteBufferCell(loc)
		{
			Expression = CdQUGaROfy7He9T0foW.KbIzwHEDLa(25204)
		};
		f9TetS7cb3eO7aDYHjD(pasteBufferCell, jObject2);
		rH2UqO7ukA0JDwCOWuk(pasteBufferCell, EzSnippet.AssembleFullCellName((string)yDMtpb71utZPUYY2qJV(P_0), (string)aUnov17Yu4EQjMUBf0H(25122)));
		return pasteBufferCell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static HeightMapToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		PmjYMI7hsMJMf38kVSd();
		zrO4pBfEKB = new Guid[1]
		{
			new Guid((string)aUnov17Yu4EQjMUBf0H(25250))
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lUoreZ7FpTwRclyuysS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.HeightMap;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vP0wGt7MnashPHbM6ZE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aUnov17Yu4EQjMUBf0H(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fvRvQY7yXOoMJBhVBi3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xb3Pk570H8nDumTPehL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bHsLdB7UAepSb121uNF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.knitm91HLn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KLcbgP7HC6MfKbjhrZ8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TLGJpv7x5oin6YHetHF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.L1bYo4gILj();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder PeiOsB7mipjHuLJXMgx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation x52aBe7Q55VZyHc9E7R(object P_0, CvsCellLocation offset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PasteBuffer)P_0).GetLocationFromOrigin(offset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XNVL5m7N15OF9NYLvAq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)(string?)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bBUtEP72TBYVlvWF3bw(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((JObject)P_0)[(string)P_1] = (JToken?)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void f9TetS7cb3eO7aDYHjD(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Data = (JToken)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yDMtpb71utZPUYY2qJV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SnippetPasteBuffer.GetToolName((PasteBuffer)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rH2UqO7ukA0JDwCOWuk(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PasteBufferCell)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PmjYMI7hsMJMf38kVSd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}
}
