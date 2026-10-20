using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.Common;
using Cognex.Common.Commands;
using Cognex.Designer.Utils.Operations;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Controls.ViewModels;
using Cognex.InSight.Internal;
using Cognex.InSight.Services;
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using Cognex.InSight.ViDiEL.ViewModels.PropertySheets.Classify;
using Cognex.Mvvm;
using Cognex.ServiceLocator;
using jUKn21pup6XFIrInBb;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.PropertySheets;

public class ClassifyViewModel : PropertySheetViewModel
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInitializeAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ClassifyViewModel _003C_003E4__this;

		private ITopLevelProgressableOperation _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!cQ9jLvBRACcFRQVZglf())
			{
				num = 4;
			}
			else
			{
				num = 5;
				if (false)
				{
					goto IL_03b4;
				}
			}
			goto IL_035b;
			IL_035b:
			int num2 = default;
			ClassifyViewModel classifyViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					try
					{
						if ((uint)num2 > 2u)
						{
							object obj = Ueb70oBj1pCble7tuk7(classifyViewModel);
							_003C_003E7__wrap1 = (ITopLevelProgressableOperation)((obj != null) ? voLs7ZBWkKGcqBYm1LY(obj, UFJpaFBIBKZggWnIjRp(), Array.Empty<StepDescriptor>()) : null);
						}
						try
						{
							TaskAwaiter awaiter;
							int num3;
							switch (num2)
							{
							default:
								awaiter = Nlepa6BbrANJDFyi8mI(classifyViewModel.UnlabeledImagesViewModel.Initialize());
								_ = 1;
								if (!cQ9jLvBRACcFRQVZglf())
								{
									num3 = 6;
								}
								else
								{
									num3 = 19;
									if (1 == 0)
									{
										goto IL_026b;
									}
								}
								goto IL_0145;
							case 1:
								awaiter = _003C_003Eu__1;
								num3 = 1;
								goto IL_0145;
							case 2:
								awaiter = _003C_003Eu__1;
								goto IL_00ba;
							case 0:
								{
									awaiter = _003C_003Eu__1;
									_003C_003Eu__1 = default;
									num3 = 2;
									goto IL_0145;
								}
								IL_026b:
								_003C_003Eu__1 = awaiter;
								num3 = 9;
								goto IL_0145;
								IL_00ba:
								_003C_003Eu__1 = default;
								num3 = 11;
								goto IL_0145;
								IL_0145:
								while (true)
								{
									switch (num3)
									{
									case 9:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num3 = 7;
										if (true)
										{
											continue;
										}
										goto case 20;
									case 20:
										num2 = (_003C_003E1__state = 2);
										num3 = 14;
										continue;
									case 18:
									case 19:
										break;
									case 12:
										num2 = (_003C_003E1__state = -1);
										goto IL_00d9;
									case 4:
										if (classifyViewModel.ClassifyProjectionParams != null)
										{
											num3 = 15;
											continue;
										}
										goto IL_00e0;
									case 10:
										num2 = (_003C_003E1__state = 1);
										num3 = 16;
										continue;
									case 16:
										_003C_003Eu__1 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									default:
										num3 = 13;
										if (0 == 0)
										{
											continue;
										}
										return;
									case 13:
										return;
									case 8:
										if (awaiter.IsCompleted)
										{
											goto IL_00d9;
										}
										num3 = 10;
										if (0 == 0)
										{
											continue;
										}
										goto case 17;
									case 17:
										awaiter.GetResult();
										num3 = 4;
										if (true)
										{
											continue;
										}
										goto case 15;
									case 15:
										awaiter = Nlepa6BbrANJDFyi8mI(cRoCkgBeo5wkBhvjEFH(classifyViewModel.ClassifyProjectionParams));
										num3 = 8;
										continue;
									case 5:
										if (!awaiter.IsCompleted)
										{
											num3 = 20;
											continue;
										}
										goto case 22;
									case 1:
										_003C_003Eu__1 = default;
										num3 = 12;
										continue;
									case 11:
										num2 = (_003C_003E1__state = -1);
										num3 = 22;
										continue;
									case 7:
										return;
									case 14:
										goto IL_026b;
									case 21:
										return;
									case 2:
										num2 = (_003C_003E1__state = -1);
										num3 = 17;
										continue;
									case 3:
										_003C_003Eu__1 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num3 = 21;
										if (true)
										{
											continue;
										}
										goto case 0;
									case 0:
									case 6:
										if (!awaiter.IsCompleted)
										{
											num2 = (_003C_003E1__state = 0);
											num3 = 3;
											continue;
										}
										goto case 17;
									case 22:
										{
											awaiter.GetResult();
											goto end_IL_0055;
										}
										IL_00d9:
										awaiter.GetResult();
										goto IL_00e0;
										IL_00e0:
										awaiter = Nlepa6BbrANJDFyi8mI(classifyViewModel.EBuxstVOf2());
										num3 = 5;
										continue;
									}
									break;
								}
								goto IL_00ba;
								end_IL_0055:
								break;
							}
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								_003C_003E7__wrap1.Dispose();
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
					goto case 3;
				default:
					num = 3;
					continue;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					break;
				case 1:
				case 5:
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_03b4;
			IL_03b4:
			classifyViewModel = _003C_003E4__this;
			num = 2;
			if (cQ9jLvBRACcFRQVZglf())
			{
				return;
			}
			goto IL_035b;
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
		internal static object Ueb70oBj1pCble7tuk7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((TopLevelViewModel)P_0).OperationProgressManager;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UFJpaFBIBKZggWnIjRp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.Initializing;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object voLs7ZBWkKGcqBYm1LY(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).StartBlockingOperation((string)P_1, (StepDescriptor[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Nlepa6BbrANJDFyi8mI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cRoCkgBeo5wkBhvjEFH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassifyProjectionParamsViewModel)P_0).InitializeProjectionParams();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DVteCMBGmULuARpZ5O6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cQ9jLvBRACcFRQVZglf()
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
	private struct _003CAcceptChangesAsync_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ClassifyViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			int num2 = default;
			TaskAwaiter awaiter = default;
			ClassifyViewModel classifyViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__1;
								goto IL_01a4;
							}
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 11;
						}
						goto IL_0151;
						IL_0151:
						while (true)
						{
							switch (num3)
							{
							case 10:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 2:
								return;
							case 7:
								awaiter = ((Task)lEeAalBnesaSXJuwXWy(qqApV9ByeDdQImGlQYS(classifyViewModel.StandardPropertySheetViewModel), null)).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								goto IL_0138;
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 14;
									continue;
								}
								goto case 16;
							case 12:
								return;
							case 0:
								awaiter = td9tYxBfFCH9aSVgGOo(classifyViewModel.yt4xbix2Os());
								num3 = 9;
								continue;
							case 14:
								num2 = (_003C_003E1__state = 1);
								num3 = 10;
								continue;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 12;
								continue;
							case 11:
								_003C_003Eu__1 = default;
								_ = 1;
								if (IjInmXB7GfTCi8xQ7uK())
								{
									num3 = 3;
									if (UA0f5wBlnuT8qnoQ9HI())
									{
										continue;
									}
									goto case 0;
								}
								num3 = 4;
								continue;
							case 4:
							case 6:
								num2 = (_003C_003E1__state = -1);
								goto IL_0138;
							default:
								num3 = 0;
								continue;
							case 3:
							case 13:
								break;
							case 15:
								goto IL_01c9;
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 15;
								if (true)
								{
									continue;
								}
								goto case 8;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 2;
								continue;
							case 16:
								{
									awaiter.GetResult();
									goto end_IL_0029;
								}
								IL_0138:
								awaiter.GetResult();
								goto case 0;
							}
							break;
						}
						goto IL_01a4;
						IL_01a4:
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						if (UA0f5wBlnuT8qnoQ9HI())
						{
							goto IL_0151;
						}
						goto IL_01c9;
						IL_01c9:
						_003C_003Eu__1 = awaiter;
						num3 = 8;
						goto IL_0151;
						end_IL_0029:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 5:
					do
					{
						classifyViewModel = _003C_003E4__this;
						UA0f5wBlnuT8qnoQ9HI();
						if (IjInmXB7GfTCi8xQ7uK())
						{
							num = 4;
							continue;
						}
						num = 0;
						break;
					}
					while (!UA0f5wBlnuT8qnoQ9HI());
					continue;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
				if (IjInmXB7GfTCi8xQ7uK())
				{
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
		internal static object qqApV9ByeDdQImGlQYS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertySheetViewModel)P_0).Accept;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lEeAalBnesaSXJuwXWy(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IAsyncCommand)P_0).ExecuteAsync(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter td9tYxBfFCH9aSVgGOo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UA0f5wBlnuT8qnoQ9HI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IjInmXB7GfTCi8xQ7uK()
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
	private struct _003CPersistSettings_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ClassifyViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			ClassifyViewModel classifyViewModel = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					num = 4;
					break;
				case 4:
					classifyViewModel = _003C_003E4__this;
					_ = 1;
					num = (B074kcx2VmVW6yvhN0j() ? 1 : 5);
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
							goto IL_014e;
						}
						if (!uBkBgWxXDr89f7NTKJe(classifyViewModel.gOrxzFfboh))
						{
							awaiter = aFXVL9xkKUjfQWGBTOW(BGOV60xM8ID10PYB9l8());
							num3 = 3;
							if (1 == 0)
							{
								return;
							}
							goto IL_014e;
						}
						num3 = 9;
						if (Yt4jIoBzMSSMP8cE9qo())
						{
							goto IL_014e;
						}
						goto end_IL_005d;
						IL_014e:
						while (true)
						{
							switch (num3)
							{
							case 9:
								goto end_IL_014e;
							case 5:
								return;
							case 7:
								return;
							case 0:
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto case 6;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 1;
								continue;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (true)
								{
									continue;
								}
								goto case 3;
							case 3:
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									num3 = ((!Yt4jIoBzMSSMP8cE9qo()) ? 7 : 0);
									continue;
								}
								break;
							case 4:
								_003C_003Eu__1 = awaiter;
								goto case 6;
							default:
								num3 = 6;
								continue;
							case 10:
								break;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_014e:
							break;
						}
						end_IL_005d:;
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
		internal static bool uBkBgWxXDr89f7NTKJe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ScopedCounter)P_0).IsNonZero;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BGOV60xM8ID10PYB9l8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter aFXVL9xkKUjfQWGBTOW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Yt4jIoBzMSSMP8cE9qo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool B074kcx2VmVW6yvhN0j()
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
	private struct _003C_003C_002Dctor_003Eb__6_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ClassifyViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!mieELgxriG3Yemn3pci())
			{
				num = 1;
				if (!EvFkvyxmeOGlaF9WU6h())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_017b;
			IL_01b7:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_017b;
			IL_017b:
			int num2 = default;
			ClassifyViewModel classifyViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					break;
				default:
					num = 5;
					continue;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 3;
					continue;
				case 5:
					goto IL_01b7;
				case 3:
					classifyViewModel = _003C_003E4__this;
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = ((Task)oNsZhYxPywUmDxhA6ip(classifyViewModel.ClassifyProjectionParams)).GetAwaiter();
					_ = 0;
					num3 = ((!EvFkvyxmeOGlaF9WU6h()) ? 5 : 2);
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 3;
					if (1 == 0)
					{
						goto IL_0111;
					}
				}
				goto IL_0077;
				IL_0077:
				while (true)
				{
					switch (num3)
					{
					case 6:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 8;
						continue;
					case 7:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 0:
					case 2:
						if (!awaiter.IsCompleted)
						{
							goto case 1;
						}
						goto case 9;
					case 3:
						_003C_003Eu__1 = default;
						num3 = 7;
						if (!mieELgxriG3Yemn3pci())
						{
							continue;
						}
						return;
					case 8:
						return;
					case 4:
						break;
					case 1:
					case 5:
						num2 = (_003C_003E1__state = 0);
						num3 = 4;
						if (!mieELgxriG3Yemn3pci())
						{
							continue;
						}
						goto case 9;
					case 9:
						awaiter.GetResult();
						goto end_IL_0077;
					}
					goto IL_0111;
					continue;
					end_IL_0077:
					break;
				}
				goto end_IL_002a;
				IL_0111:
				_003C_003Eu__1 = awaiter;
				num3 = 6;
				goto IL_0077;
				end_IL_002a:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01b7;
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
		internal static object oNsZhYxPywUmDxhA6ip(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassifyProjectionParamsViewModel)P_0).PerformAutoTune();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EvFkvyxmeOGlaF9WU6h()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mieELgxriG3Yemn3pci()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly ILogger Qo0xU15THI;

	private readonly ScopedCounter gOrxzFfboh;

	private readonly IViDiELClassifyService mRfoOY8ZAl;

	private readonly PropertySheetConfiguration RKHoI4y5uk;

	private readonly MultiTargetPropertyChangedRouter nDno2OYDuT;

	private readonly Classifier QKloxmrBjk;

	[CompilerGenerated]
	private UnlabeledImagesViewModel ejMooKce2P;

	[CompilerGenerated]
	private ImagesViewModel gItoajuPmv;

	[CompilerGenerated]
	private readonly StandardPropertySheetViewModel TsaoVoZraJ;

	[CompilerGenerated]
	private readonly DelegateCommand EwToNJ7AP3;

	[CompilerGenerated]
	private readonly ClassifyProjectionParamsViewModel SfHoG6Tl24;

	public Classifier Classifier
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return QKloxmrBjk;
		}
	}

	public UnlabeledImagesViewModel UnlabeledImagesViewModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ejMooKce2P;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ejMooKce2P = value;
		}
	}

	public ImagesViewModel ImagesViewModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return gItoajuPmv;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			gItoajuPmv = value;
		}
	}

	public override string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)xPSdWomTRdi6ZCsSdgM(RKHoI4y5uk.Function);
		}
	}

	public StandardPropertySheetViewModel StandardPropertySheetViewModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TsaoVoZraJ;
		}
	}

	public PropertySheetConfiguration PropertySheetConfiguration
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return RKHoI4y5uk;
		}
	}

	public IPropertySheetService PropertySheetService
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (IPropertySheetService)YCp6IimvHEw9FwkrVPD(RKHoI4y5uk);
		}
	}

	public IViDiELClassifyService ClassifyService
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mRfoOY8ZAl;
		}
	}

	public DelegateCommand DoAutoTune
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EwToNJ7AP3;
		}
	}

	public ClassifyProjectionParamsViewModel ClassifyProjectionParams
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SfHoG6Tl24;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClassifyViewModel(CvsInSight insight, PropertySheetConfiguration configuration, IViDiELClassifyService classifyService, ClassifyProjectionParamsViewModel classifyProjectionParams = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ll0k3dmQtboDU5O339L();
		int num;
		if (!PtKKEcmq8V0uQf0rVwi())
		{
			num = 14;
			if (!ll0k3dmQtboDU5O339L())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 7;
			if (false)
			{
				goto IL_0112;
			}
		}
		goto IL_01c3;
		IL_01c3:
		string expressionAsync = default;
		IOperationProgressManager instanceOrDefault = default;
		while (true)
		{
			switch (num)
			{
			case 17:
				break;
			case 3:
				EwToNJ7AP3 = new DelegateCommand([MethodImpl(MethodImplOptions.NoInlining)] [AsyncStateMachine(typeof(_003C_003C_002Dctor_003Eb__6_1_003Ed))] () =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					int num2 = 4;
					_003C_003C_002Dctor_003Eb__6_1_003Ed stateMachine = default;
					while (true)
					{
						switch (num2)
						{
						case 0:
							stateMachine._003C_003E4__this = this;
							_ = 1;
							num2 = (PtKKEcmq8V0uQf0rVwi() ? 1 : 5);
							break;
						default:
							stateMachine._003C_003Et__builder.Start(ref stateMachine);
							num2 = 6;
							break;
						case 2:
						case 5:
							stateMachine._003C_003E1__state = -1;
							goto default;
						case 4:
							stateMachine._003C_003Et__builder = FO2HQXmKEg4cJ86tU6l();
							num2 = 0;
							break;
						case 6:
							return;
						}
					}
				}, [MethodImpl(MethodImplOptions.NoInlining)] () =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return true;
				});
				num = 18;
				continue;
			case 0:
			case 14:
				WdmHBfmVrl0Lg1SZqs8();
				num = 4;
				continue;
			case 11:
				throw new ArgumentNullException((string)NFQ6EBmLjpppcsogE4A(2080));
			case 1:
				goto IL_00ce;
			case 15:
				_ = ((IPropertySheetService)YCp6IimvHEw9FwkrVPD(configuration)).SetExpressionAsync(expressionAsync).Result;
				goto case 7;
			case 2:
				goto IL_0112;
			case 13:
				mRfoOY8ZAl = classifyService;
				TsaoVoZraJ = new StandardPropertySheetViewModel(configuration);
				num = 6;
				if (PtKKEcmq8V0uQf0rVwi())
				{
				}
				continue;
			case 8:
				goto IL_0150;
			case 5:
				SfHoG6Tl24 = classifyProjectionParams;
				num = 10;
				continue;
			case 9:
				RKHoI4y5uk = configuration;
				num = 13;
				continue;
			case 16:
				QKloxmrBjk = new Classifier(insight, classifyService, instanceOrDefault);
				num = 1;
				continue;
			case 6:
				instanceOrDefault = ((IServiceLocator)v21l9JmtMQZYZ3AALcK()).GetInstanceOrDefault<IOperationProgressManager>((string)null);
				goto case 16;
			default:
				num = 16;
				continue;
			case 7:
			case 12:
			{
				MultiTargetPropertyChangedRouter multiTargetPropertyChangedRouter = nDno2OYDuT;
				StandardPropertySheetViewModel standardPropertySheetViewModel = StandardPropertySheetViewModel;
				ParameterExpression parameterExpression = Expression.Parameter(typeof(StandardPropertySheetViewModel), plfGltUiaC1OFfC2I8.OIRNC4VQ7F(2144));
				multiTargetPropertyChangedRouter.Register(standardPropertySheetViewModel, Expression.Lambda<Func<StandardPropertySheetViewModel, string>>((Expression)hpy84Fm0V47pUAY4djC(parameterExpression, (MethodInfo)nP4yedmZetLq2c5Bslx(__ldtoken(StandardPropertySheetViewModel.get_Expression()))), new ParameterExpression[1] { parameterExpression }), So3xkA8rNH);
				num = 5;
				continue;
			}
			case 10:
				if (ClassifyProjectionParams != null)
				{
					num = 3;
					continue;
				}
				return;
			case 4:
				gOrxzFfboh = new ScopedCounter();
				nDno2OYDuT = new MultiTargetPropertyChangedRouter();
				num = 17;
				continue;
			case 18:
				return;
			}
			break;
			IL_0150:
			RKHoI4y5uk = configuration;
			if (configuration != null)
			{
				if (classifyService == null)
				{
					throw new ArgumentNullException((string)NFQ6EBmLjpppcsogE4A(2110));
				}
				UnlabeledImagesViewModel = z2JxXwSPTh();
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				goto IL_00ce;
			}
			num = 11;
			continue;
			IL_00ce:
			expressionAsync = (string)LvNk1im9P3gEtIkOLid(StandardPropertySheetViewModel);
			num = 15;
			if (PtKKEcmq8V0uQf0rVwi())
			{
			}
		}
		goto IL_002e;
		IL_0112:
		ImagesViewModel = gBrxgMnQxX();
		num = 9;
		goto IL_01c3;
		IL_002e:
		NqYJQQmit4ZcDUnp1oB(this);
		num = 8;
		goto IL_01c3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__7))]
	public override Task InitializeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (PtKKEcmq8V0uQf0rVwi() ? 1 : 3);
		_003CInitializeAsync_003Ed__7 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 1;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = rfdRZxmOJRBx7xvoHA2();
				num = 4;
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
	[AsyncStateMachine(typeof(_003CAcceptChangesAsync_003Ed__18))]
	protected override Task AcceptChangesAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = (ll0k3dmQtboDU5O339L() ? 1 : 4);
		_003CAcceptChangesAsync_003Ed__18 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = rfdRZxmOJRBx7xvoHA2();
				num = 5;
				break;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnCompleted(bool result)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QKloxmrBjk.Dispose();
		gdudnAmHPROexW4knuY(this, result);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void FcHxPcBhcp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ViewModelCommandHelper)wnGxVjmYMY5V3FOmTem(this)).Execute((Func<Task>)yGUxq5UZR5, (string)null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPersistSettings_003Ed__26))]
	private Task yGUxq5UZR5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CPersistSettings_003Ed__26 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 4:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				if (!ll0k3dmQtboDU5O339L())
				{
					num = 5;
					continue;
				}
				num = 0;
				if (ll0k3dmQtboDU5O339L())
				{
					continue;
				}
				goto case 1;
			case 1:
				stateMachine._003C_003Et__builder = rfdRZxmOJRBx7xvoHA2();
				num = 4;
				if (!PtKKEcmq8V0uQf0rVwi())
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
	private UnlabeledImagesViewModel z2JxXwSPTh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new UnlabeledImagesViewModel(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ImagesViewModel gBrxgMnQxX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new ImagesViewModel(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void So3xkA8rNH(StandardPropertySheetViewModel P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		WHjCvxmJHHLIRNFb2dl(UnlabeledImagesViewModel, LvNk1im9P3gEtIkOLid(P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassifyViewModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		WdmHBfmVrl0Lg1SZqs8();
		Qo0xU15THI = LogManager.GetLogger<ClassifyViewModel>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003C_002Dctor_003Eb__6_1_003Ed))]
	private void GwRxQE47Ud()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003C_003C_002Dctor_003Eb__6_1_003Ed stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				num = (PtKKEcmq8V0uQf0rVwi() ? 1 : 5);
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 4:
				stateMachine._003C_003Et__builder = FO2HQXmKEg4cJ86tU6l();
				num = 0;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task EBuxstVOf2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)ALa7VjmCG2wRHknULGd(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task yt4xbix2Os()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)AG1wIemAs89Jlxy1wRl(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WdmHBfmVrl0Lg1SZqs8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NqYJQQmit4ZcDUnp1oB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((PropertySheetViewModel)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NFQ6EBmLjpppcsogE4A(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object v21l9JmtMQZYZ3AALcK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Locator.Current;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LvNk1im9P3gEtIkOLid(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StandardPropertySheetViewModel)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YCp6IimvHEw9FwkrVPD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertySheetConfiguration)P_0).PropertySheetService;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nP4yedmZetLq2c5Bslx(RuntimeMethodHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return MethodBase.GetMethodFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hpy84Fm0V47pUAY4djC(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ll0k3dmQtboDU5O339L()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PtKKEcmq8V0uQf0rVwi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder rfdRZxmOJRBx7xvoHA2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gdudnAmHPROexW4knuY(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseCompletableViewModel)P_0).OnCompleted(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xPSdWomTRdi6ZCsSdgM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunction)P_0).DisplayName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wnGxVjmYMY5V3FOmTem(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertySheetViewModel)P_0).CommandHelper;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WHjCvxmJHHLIRNFb2dl(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((UnlabeledImagesViewModel)P_0).Expression = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncVoidMethodBuilder FO2HQXmKEg4cJ86tU6l()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncVoidMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ALa7VjmCG2wRHknULGd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertySheetViewModel)P_0).InitializeAsync();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AG1wIemAs89Jlxy1wRl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertySheetViewModel)P_0).AcceptChangesAsync();
	}
}
