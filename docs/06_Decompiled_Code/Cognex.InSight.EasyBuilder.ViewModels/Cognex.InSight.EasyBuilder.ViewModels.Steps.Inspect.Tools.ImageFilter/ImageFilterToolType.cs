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
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.Internal;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ImageFilter;

[Export(typeof(EzToolType))]
public class ImageFilterToolType : EzToolType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateTool_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public ImageFilterToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private ImageFilterTool _003Ctool_003E5__2;

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
			ImageFilterToolType imageFilterToolType = default;
			TaskAwaiter awaiter = default;
			EzTool result = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 6:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Ctool_003E5__2 = new ImageFilterTool((InspectStepViewModel)jCYboZK03uX0M2IZwRjJ(imageFilterToolType), isInitialized: false);
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 9;
						}
						while (true)
						{
							switch (num3)
							{
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								if (!YYRd4LK07HEZ3Ls0rlHX())
								{
									continue;
								}
								goto case 7;
							case 7:
								awaiter = x2HLrlK0jaMJZFwZ29ah(_003Ctool_003E5__2.SetCellRangeAsync(cells, cellRange));
								num3 = 1;
								if (YYRd4LK07HEZ3Ls0rlHX())
								{
								}
								continue;
							case 8:
								awaiter.GetResult();
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								goto case 8;
							case 2:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 3;
							case 3:
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 0:
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								_ = 0;
								if (BKfkM5K04lZfcKTaBiGF())
								{
									num3 = 3;
									continue;
								}
								num3 = 2;
								if (0 == 0)
								{
									continue;
								}
								break;
							case 9:
								_003C_003Eu__1 = default;
								goto case 2;
							case 10:
								break;
							}
							break;
						}
						result = _003Ctool_003E5__2;
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
				case 5:
					_003Ctool_003E5__2 = null;
					num = 3;
					if (true)
					{
						break;
					}
					goto case 3;
				case 3:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					break;
				case 1:
				case 4:
					imageFilterToolType = _003C_003E4__this;
					goto case 2;
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					num = (BKfkM5K04lZfcKTaBiGF() ? 4 : 6);
					break;
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
		internal static object jCYboZK03uX0M2IZwRjJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter x2HLrlK0jaMJZFwZ29ah(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BKfkM5K04lZfcKTaBiGF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YYRd4LK07HEZ3Ls0rlHX()
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

		public ImageFilterToolType _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			erNvwZK0CTbToVO0i1xb();
			int num;
			if (W6jJPhK06IXDj9qW6jMO())
			{
				num = 4;
			}
			else
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_0067;
				}
			}
			goto IL_01b2;
			IL_0067:
			int num2 = default;
			ImageFilterToolType imageFilterToolType = default;
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = yWkF2aK0RcutU07RfeMR(FROdKuK0ANW20DpmoEk5(imageFilterToolType.AcceptAddCommand));
					_ = 1;
					num3 = (erNvwZK0CTbToVO0i1xb() ? 6 : 7);
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 1;
					if (1 == 0)
					{
						goto IL_0172;
					}
				}
				while (true)
				{
					switch (num3)
					{
					case 0:
					case 7:
						if (!awaiter.IsCompleted)
						{
							num3 = 2;
							continue;
						}
						break;
					case 1:
						_003C_003Eu__1 = default;
						num3 = 8;
						continue;
					case 2:
						num2 = (_003C_003E1__state = 0);
						num3 = 5;
						if (W6jJPhK06IXDj9qW6jMO())
						{
							continue;
						}
						goto case 8;
					case 8:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 3:
					case 6:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					default:
						num3 = 4;
						continue;
					case 5:
						_003C_003Eu__1 = awaiter;
						goto case 3;
					case 4:
						return;
					case 9:
						break;
					}
					break;
				}
				goto IL_0172;
				IL_0172:
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0028;
			IL_0028:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01b2;
			IL_01b2:
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 1:
				case 3:
					imageFilterToolType = _003C_003E4__this;
					num = 2;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 2:
					goto IL_0067;
				default:
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_0028;
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
		internal static object FROdKuK0ANW20DpmoEk5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AsyncDelegateCommand)P_0).Invoke();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter yWkF2aK0RcutU07RfeMR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool W6jJPhK06IXDj9qW6jMO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool erNvwZK0CTbToVO0i1xb()
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

		public ImageFilterToolType _003C_003E4__this;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private CvsCellRange _003CpasteRange_003E5__3;

		private object _003C_003E7__wrap3;

		private ImageFilterTool _003CnewTool_003E5__5;

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
			EzTool result = default;
			TaskAwaiter awaiter = default;
			ImageFilterToolType imageFilterToolType = default;
			TaskAwaiter<CvsCellRange> awaiter2 = default;
			TaskAwaiter<CvsCellCollection> awaiter4 = default;
			TaskAwaiter<object> awaiter3 = default;
			CvsCellRange result3 = default;
			CvsCellCollection result2 = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					num2 = _003C_003E1__state;
					num = 3;
					if (p9WwQ7K0ToECGvfM0sfa())
					{
					}
					continue;
				case 1:
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					continue;
				case 2:
				case 5:
					try
					{
						int num3;
						if ((uint)num2 > 3u)
						{
							if (num2 == 4)
							{
								awaiter = _003C_003Eu__4;
								_003C_003Eu__4 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0509;
							}
							_003Csheet_003E5__2 = (CvsCogSocketSheet)ayVd1oK00Fvi21vj9ebH(((CvsInSight)EKSlNFK0yE5NoVHaP8eP(imageFilterToolType.Inspect)).CogSocket);
							_003CpasteRange_003E5__3 = CvsCellRange.Empty;
							num3 = 0;
						}
						try
						{
							int num4;
							switch (num2)
							{
							default:
								awaiter2 = imageFilterToolType.RenameAndPasteTool(imageFilterToolType._pasteObject).GetAwaiter();
								num4 = 16;
								if (p9WwQ7K0ToECGvfM0sfa())
								{
									goto IL_00bb;
								}
								goto IL_0294;
							case 2:
								awaiter4 = _003C_003Eu__3;
								GliCMpK0WgS1JEkadUro();
								if (!p9WwQ7K0ToECGvfM0sfa())
								{
									num4 = 20;
									if (1 == 0)
									{
										goto IL_025a;
									}
								}
								else
								{
									num4 = 24;
									if (p9WwQ7K0ToECGvfM0sfa())
									{
									}
								}
								goto IL_0294;
							case 1:
								awaiter3 = _003C_003Eu__2;
								num4 = 1;
								goto IL_0294;
							case 3:
								awaiter = _003C_003Eu__4;
								num4 = 15;
								goto IL_0294;
							case 0:
								{
									awaiter2 = _003C_003Eu__1;
									_003C_003Eu__1 = default;
									num4 = 0;
									goto IL_0294;
								}
								IL_025a:
								_003C_003Eu__3 = default;
								num4 = 9;
								if (p9WwQ7K0ToECGvfM0sfa())
								{
								}
								goto IL_0294;
								IL_00bb:
								num2 = (_003C_003E1__state = 2);
								num4 = 2;
								goto IL_0294;
								IL_0294:
								while (true)
								{
									switch (num4)
									{
									case 23:
										break;
									case 24:
									case 26:
										awaiter.GetResult();
										num4 = 29;
										if (true)
										{
											continue;
										}
										goto case 2;
									case 2:
										_003C_003Eu__3 = awaiter4;
										num4 = 21;
										if (GliCMpK0WgS1JEkadUro())
										{
											continue;
										}
										goto case 1;
									case 1:
										_003C_003Eu__2 = default;
										num2 = (_003C_003E1__state = -1);
										num4 = 27;
										continue;
									case 9:
										num2 = (_003C_003E1__state = -1);
										goto IL_0121;
									case 22:
										_003C_003Eu__1 = awaiter2;
										num4 = 12;
										continue;
									case 25:
										_003CpasteRange_003E5__3 = result3;
										awaiter3 = _003Csheet_003E5__2.PutCellExpressionAsync(imageFilterToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, imageFilterToolType.XPMRR86bWd), (string)dI97hMK0MBBIXRxWF8e4(imageFilterToolType.InputImageLinks[vNvJigK0FZFT6YwVJvUh(imageFilterToolType)])).GetAwaiter();
										num4 = 3;
										if (0 == 0)
										{
											continue;
										}
										goto case 6;
									case 6:
										if (!awaiter.IsCompleted)
										{
											num4 = 14;
											continue;
										}
										goto case 24;
									case 3:
										if (!awaiter3.IsCompleted)
										{
											num4 = 17;
											continue;
										}
										goto case 27;
									case 16:
										if (!awaiter2.IsCompleted)
										{
											num4 = 4;
											continue;
										}
										goto case 13;
									case 0:
										num2 = (_003C_003E1__state = -1);
										num4 = 13;
										continue;
									case 17:
										num2 = (_003C_003E1__state = 1);
										_003C_003Eu__2 = awaiter3;
										num4 = 19;
										if (0 == 0)
										{
											continue;
										}
										goto case 12;
									case 12:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num4 = 28;
										continue;
									case 21:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										return;
									case 18:
									case 20:
										goto IL_025a;
									case 27:
										awaiter3.GetResult();
										goto case 8;
									default:
										num4 = 8;
										continue;
									case 13:
										result3 = awaiter2.GetResult();
										num4 = 25;
										continue;
									case 4:
										num2 = (_003C_003E1__state = 0);
										num4 = 22;
										if (GliCMpK0WgS1JEkadUro())
										{
											continue;
										}
										goto case 11;
									case 11:
										_003CnewTool_003E5__5 = new ImageFilterTool(imageFilterToolType.Inspect, isInitialized: false);
										num4 = 10;
										if (p9WwQ7K0ToECGvfM0sfa())
										{
										}
										continue;
									case 5:
										return;
									case 15:
										_003C_003Eu__4 = default;
										num2 = (_003C_003E1__state = -1);
										goto case 24;
									case 7:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									case 14:
										num2 = (_003C_003E1__state = 3);
										_003C_003Eu__4 = awaiter;
										num4 = 7;
										continue;
									case 28:
										return;
									case 8:
										awaiter4 = _003Csheet_003E5__2.RunAndGetCellResults().GetAwaiter();
										if (!awaiter4.IsCompleted)
										{
											num4 = 23;
											continue;
										}
										goto IL_0121;
									case 10:
										awaiter = YlskHSK0Y80oJCkhCTuk(_003CnewTool_003E5__5.SetCellRangeAsync(result2, _003CpasteRange_003E5__3));
										num4 = 6;
										continue;
									case 19:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										num4 = 5;
										if (p9WwQ7K0ToECGvfM0sfa())
										{
										}
										continue;
									case 29:
										{
											result = _003CnewTool_003E5__5;
											goto end_IL_0081;
										}
										IL_0121:
										result2 = awaiter4.GetResult();
										num4 = 11;
										continue;
									}
									break;
								}
								goto IL_00bb;
								end_IL_0081:
								break;
							}
						}
						catch (object obj)
						{
							_003C_003E7__wrap3 = obj;
							num3 = 1;
							goto IL_04a2;
						}
						goto end_IL_0049;
						IL_04a2:
						if (num3 == 1)
						{
							awaiter = YlskHSK0Y80oJCkhCTuk(imageFilterToolType.CleanUpPastedToolOnFailedAdd(_003CpasteRange_003E5__3));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 4);
								_003C_003Eu__4 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0509;
						}
						goto IL_0532;
						IL_0509:
						awaiter.GetResult();
						((ExceptionDispatchInfo)apO7BsK0U29ELY2Ty8U3((_003C_003E7__wrap3 as Exception) ?? throw _003C_003E7__wrap3)).Throw();
						goto IL_0532;
						IL_0532:
						_003C_003E7__wrap3 = null;
						_003Csheet_003E5__2 = null;
						_003CpasteRange_003E5__3 = default;
						end_IL_0049:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Csheet_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 0;
				default:
					num = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 3:
					break;
				case 0:
					_003Csheet_003E5__2 = null;
					goto case 1;
				case 7:
					return;
				}
				imageFilterToolType = _003C_003E4__this;
				p9WwQ7K0ToECGvfM0sfa();
				num = ((!GliCMpK0WgS1JEkadUro()) ? 1 : 5);
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
		internal static object EKSlNFK0yE5NoVHaP8eP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ayVd1oK00Fvi21vj9ebH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int vNvJigK0FZFT6YwVJvUh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).InputImageIndex;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dI97hMK0MBBIXRxWF8e4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter YlskHSK0Y80oJCkhCTuk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object apO7BsK0U29ELY2Ty8U3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GliCMpK0WgS1JEkadUro()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool p9WwQ7K0ToECGvfM0sfa()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
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

		public ImageFilterToolType _003C_003E4__this;

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
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					m4ysTPK0mqVT6jTZgP8x();
					num = 4;
					continue;
				case 1:
				case 2:
					this._003C_003E1__state = _003C_003E1__state;
					break;
				case 4:
					base._002Ector();
					_ = 0;
					if (!SFbGRpK0HKxCEy7ucM0E())
					{
						num = 0;
						continue;
					}
					num = 1;
					if (SFbGRpK0HKxCEy7ucM0E())
					{
						continue;
					}
					break;
				case 6:
					return;
				}
				_003C_003El__initialThreadId = HKD8qYK0QLCVRgGB82Ol();
				num = 6;
			}
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
			int num = 4;
			ImageFilterToolType imageFilterToolType = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					_003C_003E1__state = 1;
					goto default;
				case 2:
					_003C_003E1__state = 3;
					return true;
				case 10:
					if (_003CcurrentVersion_003E5__2 < 1)
					{
						num = 7;
						continue;
					}
					goto case 11;
				case 3:
				case 14:
					_003CcurrentVersion_003E5__2 = rFJN54K0NL9drumGQpAs(cells, range);
					num = 12;
					continue;
				case 1:
					_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__3, imageFilterToolType.Localizer);
					num = 2;
					continue;
				case 13:
					_003C_003E1__state = 2;
					num = 15;
					if (0 == 0)
					{
						continue;
					}
					goto case 6;
				case 6:
					return false;
				case 12:
					_003ClatestVersion_003E5__3 = xad7meK02CalB3FiHybV(imageFilterToolType._pasteObject);
					num = 10;
					if (!SZ4ogUK0xIrxNorIrVoT())
					{
						continue;
					}
					goto case 15;
				case 15:
					return true;
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 11:
					if (_003CcurrentVersion_003E5__2 < _003ClatestVersion_003E5__3)
					{
						num = 1;
						continue;
					}
					break;
				case 7:
					_003C_003E2__current = new ShowOutputImageUpdate(imageFilterToolType.Localizer);
					num = 0;
					if (true)
					{
						continue;
					}
					goto case 5;
				case 5:
					imageFilterToolType = _003C_003E4__this;
					switch (num2)
					{
					case 3:
						break;
					case 0:
						goto IL_0118;
					case 2:
						goto IL_0158;
					default:
						goto IL_01cf;
					case 1:
						goto IL_01dd;
					}
					_003C_003E1__state = -1;
					num = 16;
					continue;
				default:
					return true;
				case 16:
					break;
					IL_01dd:
					_003C_003E1__state = -1;
					_003C_003E2__current = new ToolDisabledJobPassUpdate();
					num = 13;
					continue;
					IL_01cf:
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					goto default;
					IL_0158:
					_003C_003E1__state = -1;
					num = 11;
					continue;
					IL_0118:
					_003C_003E1__state = -1;
					_ = 0;
					if (!SFbGRpK0HKxCEy7ucM0E())
					{
						num = 9;
						if (SFbGRpK0HKxCEy7ucM0E())
						{
							continue;
						}
						goto case 2;
					}
					num = 14;
					continue;
				}
				break;
			}
			return false;
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
		internal static void m4ysTPK0mqVT6jTZgP8x()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int HKD8qYK0QLCVRgGB82Ol()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SFbGRpK0HKxCEy7ucM0E()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SZ4ogUK0xIrxNorIrVoT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int rFJN54K0NL9drumGQpAs(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int xad7meK02CalB3FiHybV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}
	}

	private static readonly Guid[] D84RMq7GpN;

	private readonly CvsCellLocation XPMRR86bWd;

	private int VRUR4Lh85A;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return D84RMq7GpN;
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
			return (string)m3ogU24TmhAhZDIZKj6();
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
			return (string)FSjMHK4ya1e8MdgVqr6();
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
				(string)iDBTha407WtR62MIHWf(),
				Resources.L1bYo4gILj()
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
			return VRUR4Lh85A;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref VRUR4Lh85A, value, (string)qRoQmE4W5cpPPJVSxZk(3256));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ImageFilterToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EUQdfA46AEloTHRk4bO();
		int num = (INs9t84CUh3HKFtC6Qo() ? 6 : 5);
		while (true)
		{
			switch (num)
			{
			default:
				XPMRR86bWd = _pasteObject.GetCellOffset((string)qRoQmE4W5cpPPJVSxZk(4928));
				num = 3;
				if (0 == 0)
				{
					break;
				}
				goto case 3;
			case 3:
				AddSnippet(_pasteObject);
				num = 8;
				if (0 == 0)
				{
					break;
				}
				goto case 7;
			case 7:
				_pasteObject = (PasteBuffer)k9oLbV4RQHrWeEQlTZT(H1SCmE4Au7nCl4CTOlK());
				goto default;
			case 1:
				base._002Ector();
				num = 7;
				if (EUQdfA46AEloTHRk4bO())
				{
					break;
				}
				goto case 2;
			case 2:
				VRUR4Lh85A = 800;
				num = 1;
				break;
			case 0:
			case 5:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 2;
				if (!EUQdfA46AEloTHRk4bO())
				{
					return;
				}
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
		int num = 5;
		_003COnBeginAddInternal_003Ed__22 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			case 5:
				stateMachine._003C_003Et__builder = xfgmUk4FbwDw0X5qNpg();
				EUQdfA46AEloTHRk4bO();
				if (!INs9t84CUh3HKFtC6Qo())
				{
					num = 2;
					break;
				}
				num = 0;
				if (EUQdfA46AEloTHRk4bO())
				{
					break;
				}
				goto default;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
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
	static ImageFilterToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		OLGKCi4MSgKvWqQxR89();
		D84RMq7GpN = new Guid[1]
		{
			new Guid((string)qRoQmE4W5cpPPJVSxZk(24796))
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object H1SCmE4Au7nCl4CTOlK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.ImageFilter;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object k9oLbV4RQHrWeEQlTZT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qRoQmE4W5cpPPJVSxZk(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EUQdfA46AEloTHRk4bO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool INs9t84CUh3HKFtC6Qo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object m3ogU24TmhAhZDIZKj6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.mJPY6GXUua();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FSjMHK4ya1e8MdgVqr6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.bgiYFhSmLa();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iDBTha407WtR62MIHWf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder xfgmUk4FbwDw0X5qNpg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OLGKCi4MSgKvWqQxR89()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}
}
