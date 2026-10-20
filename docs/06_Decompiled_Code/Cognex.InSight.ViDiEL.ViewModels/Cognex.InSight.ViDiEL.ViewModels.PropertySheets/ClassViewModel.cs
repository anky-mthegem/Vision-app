using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.Designer.Utils.Operations;
using Cognex.InSight.Services;
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using Cognex.Mvvm;
using jUKn21pup6XFIrInBb;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.PropertySheets;

public class ClassViewModel : BaseViewModel, IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddImage_003Ed__60 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ClassViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private ITopLevelProgressableOperation _003Coperation_003E5__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hHuPhux8WkV0B3Z38U7();
			int num = ((!gdZ4QyxD1bVIUoRXLcc()) ? 3 : 2);
			ClassViewModel classViewModel = default;
			TaskAwaiter awaiter = default;
			int num2 = default;
			do
			{
				IL_062d:
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					goto IL_062d;
				case 4:
					try
					{
						switch (num2)
						{
						default:
							if (RSc3u3xF5MTFyoBLPQC(classViewModel.ParentTool))
							{
								awaiter = YR7HqJxdTEL8aaGipgr(KHkvaGxsx5GVy2Jwfyo(classViewModel.ParentTool, classViewModel));
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_00cc;
							}
							_003Coperation_003E5__2 = classViewModel.ParentTool.OperationProgressManager?.StartBlockingOperation((string)CSmcShxExDgl5TD3i2t());
							goto case 1;
						case 0:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00cc;
						case 1:
						case 2:
						case 3:
						case 4:
						case 5:
							try
							{
								int num3;
								switch (num2)
								{
								default:
									num3 = 5;
									goto IL_02f4;
								case 1:
									awaiter = _003C_003Eu__1;
									num3 = 22;
									goto IL_02f4;
								case 2:
									awaiter = _003C_003Eu__1;
									num3 = 27;
									goto IL_02f4;
								case 3:
									awaiter = _003C_003Eu__1;
									_003C_003Eu__1 = default;
									_ = 0;
									num3 = ((!gdZ4QyxD1bVIUoRXLcc()) ? 7 : 4);
									goto IL_02f4;
								case 5:
									awaiter = _003C_003Eu__1;
									num3 = 32;
									if (!gdZ4QyxD1bVIUoRXLcc())
									{
										return;
									}
									goto IL_02f4;
								case 4:
									{
										awaiter = _003C_003Eu__1;
										_003C_003Eu__1 = default;
										num2 = (_003C_003E1__state = -1);
										num3 = 6;
										goto IL_02f4;
									}
									IL_02f4:
									while (true)
									{
										switch (num3)
										{
										case 23:
											if (!awaiter.IsCompleted)
											{
												num3 = 20;
												continue;
											}
											goto case 10;
										case 30:
											return;
										case 16:
											awaiter = YR7HqJxdTEL8aaGipgr(joGL4Pxc70pK0Tr61GU(classViewModel.ParentTool));
											num3 = 28;
											continue;
										case 10:
											awaiter.GetResult();
											num3 = 16;
											continue;
										case 29:
											awaiter.GetResult();
											num3 = 34;
											if (0 == 0)
											{
												continue;
											}
											goto case 4;
										case 4:
										case 19:
											num2 = (_003C_003E1__state = -1);
											num3 = 0;
											if (hHuPhux8WkV0B3Z38U7())
											{
											}
											continue;
										case 17:
											num2 = (_003C_003E1__state = -1);
											num3 = 10;
											continue;
										case 27:
											_003C_003Eu__1 = default;
											num3 = 17;
											continue;
										case 11:
											if (!awaiter.IsCompleted)
											{
												num3 = 14;
												continue;
											}
											goto case 6;
										case 31:
											if (!awaiter.IsCompleted)
											{
												num2 = (_003C_003E1__state = 1);
												num3 = 18;
												if (0 == 0)
												{
													continue;
												}
												return;
											}
											goto case 12;
										case 26:
											return;
										case 5:
											awaiter = YR7HqJxdTEL8aaGipgr(VCeLR4xaj3fHJcI4SCj(lUxKsNx5ovKg4TXrby8(classViewModel.ParentTool), UdeWewx3VKr2hRH10BH(classViewModel.ParentTool), classViewModel.ClassName));
											num3 = 31;
											if (true)
											{
												continue;
											}
											return;
										case 3:
											return;
										case 24:
											if (!awaiter.IsCompleted)
											{
												num3 = 13;
												if (hHuPhux8WkV0B3Z38U7())
												{
												}
												continue;
											}
											goto case 29;
										case 14:
											num2 = (_003C_003E1__state = 4);
											num3 = 15;
											continue;
										case 22:
											_003C_003Eu__1 = default;
											num3 = 33;
											if (true)
											{
												continue;
											}
											goto case 28;
										case 28:
											if (!awaiter.IsCompleted)
											{
												goto case 2;
											}
											goto case 0;
										default:
											num3 = 2;
											continue;
										case 1:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											num3 = 26;
											continue;
										case 20:
											num2 = (_003C_003E1__state = 2);
											_003C_003Eu__1 = awaiter;
											num3 = 1;
											continue;
										case 8:
											_003C_003Eu__1 = awaiter;
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											num3 = 3;
											continue;
										case 6:
											awaiter.GetResult();
											awaiter = YR7HqJxdTEL8aaGipgr(bS2vioxBEfMfLLk90BW(classViewModel.ParentTool));
											num3 = 24;
											continue;
										case 12:
											awaiter.GetResult();
											awaiter = YR7HqJxdTEL8aaGipgr(zeklhZxoF5LFtwWOtoF(classViewModel.ParentTool.ClassifyService));
											num3 = 23;
											if (hHuPhux8WkV0B3Z38U7())
											{
											}
											continue;
										case 15:
											_003C_003Eu__1 = awaiter;
											num3 = 9;
											continue;
										case 33:
											num2 = (_003C_003E1__state = -1);
											num3 = 12;
											continue;
										case 32:
											_003C_003Eu__1 = default;
											num2 = (_003C_003E1__state = -1);
											num3 = 29;
											continue;
										case 13:
											num2 = (_003C_003E1__state = 5);
											_003C_003Eu__1 = awaiter;
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											return;
										case 25:
											return;
										case 7:
										case 21:
											awaiter = YR7HqJxdTEL8aaGipgr(jEcyx2xuXhQQB4jbFfv(classViewModel.ParentTool));
											num3 = 11;
											if (0 == 0)
											{
												continue;
											}
											goto case 2;
										case 2:
											num2 = (_003C_003E1__state = 3);
											num3 = 8;
											continue;
										case 0:
											awaiter.GetResult();
											goto case 7;
										case 9:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											num3 = 25;
											if (true)
											{
												continue;
											}
											goto case 18;
										case 18:
											_003C_003Eu__1 = awaiter;
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											num3 = 30;
											if (gdZ4QyxD1bVIUoRXLcc())
											{
												continue;
											}
											break;
										case 34:
											break;
										}
										break;
									}
									classViewModel.NotifyImageCountChanged();
									break;
								}
							}
							finally
							{
								if (num2 < 0 && _003Coperation_003E5__2 != null)
								{
									lLLeOyxxyn5jBNkN6mj(_003Coperation_003E5__2);
								}
							}
							_003Coperation_003E5__2 = null;
							awaiter = YR7HqJxdTEL8aaGipgr(O70uPyxhTgncFlK3ibU(classViewModel.ParentTool));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 6);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							break;
						case 6:
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								break;
							}
							IL_00cc:
							awaiter.GetResult();
							goto end_IL_003d;
						}
						awaiter.GetResult();
						end_IL_003d:;
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
					goto IL_062d;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					break;
				case 1:
				case 3:
					break;
				case 6:
					return;
				}
				classViewModel = _003C_003E4__this;
				num = 4;
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
		internal static bool RSc3u3xF5MTFyoBLPQC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Classifier)P_0).LiveLabel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KHkvaGxsx5GVy2Jwfyo(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Classifier)P_0).LabelCurrentImage((ClassViewModel)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter YR7HqJxdTEL8aaGipgr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CSmcShxExDgl5TD3i2t()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ApplyingLabel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lUxKsNx5ovKg4TXrby8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Classifier)P_0).ClassifyService;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UdeWewx3VKr2hRH10BH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Classifier)P_0).CurrentImageName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VCeLR4xaj3fHJcI4SCj(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IViDiELClassifyService)P_0).SetClassLabel((string)P_1, (string)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zeklhZxoF5LFtwWOtoF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IViDiELClassifyService)P_0).Train();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object joGL4Pxc70pK0Tr61GU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Classifier)P_0).RefreshUnlabeledImages();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jEcyx2xuXhQQB4jbFfv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Classifier)P_0).RefreshLabeledImages();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bS2vioxBEfMfLLk90BW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Classifier)P_0).RunSheet();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void lLLeOyxxyn5jBNkN6mj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object O70uPyxhTgncFlK3ibU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Classifier)P_0).NextImage();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gdZ4QyxD1bVIUoRXLcc()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hHuPhux8WkV0B3Z38U7()
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
	private struct _003CToggleRenameMode_003Ed__61 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ClassViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			DfocYUxQZs5c3bs03t9();
			int num = ((!kvqHtKxUtyMtuNIrG7d()) ? 3 : 4);
			int num2 = default;
			ClassViewModel classViewModel = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 5;
				case 5:
					classViewModel = _003C_003E4__this;
					goto case 2;
				case 1:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (classViewModel.IsInRenameMode)
							{
								num3 = 0;
							}
							else
							{
								classViewModel.NewClassName = classViewModel.ClassName;
								num3 = 8;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
								awaiter = classViewModel.AcceptRename().GetAwaiter();
								num3 = 4;
								continue;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 1;
								continue;
							case 1:
								return;
							case 11:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								continue;
							case 4:
								if (!awaiter.IsCompleted)
								{
									DfocYUxQZs5c3bs03t9();
									num3 = ((!kvqHtKxUtyMtuNIrG7d()) ? 10 : 9);
									continue;
								}
								goto case 3;
							case 2:
							case 9:
								num2 = (_003C_003E1__state = 0);
								num3 = 11;
								continue;
							case 8:
								OkcZnHxVHmM3f1rBprb(classViewModel, new PropertyChangedEventArgs((string)pEjspdxqryp49fLN9b6(2452)));
								num3 = 12;
								if (DfocYUxQZs5c3bs03t9())
								{
								}
								continue;
							case 5:
								_003C_003Eu__1 = default;
								goto case 7;
							case 7:
							case 10:
								num2 = (_003C_003E1__state = -1);
								num3 = 3;
								continue;
							case 3:
								awaiter.GetResult();
								break;
							case 12:
								classViewModel.IsInRenameMode = true;
								break;
							}
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
					goto case 1;
				default:
					num = 1;
					if (DfocYUxQZs5c3bs03t9())
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
		internal static object pEjspdxqryp49fLN9b6(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void OkcZnHxVHmM3f1rBprb(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BasePropertyChanged)P_0).RaisePropertyChangedEvent((PropertyChangedEventArgs)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kvqHtKxUtyMtuNIrG7d()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DfocYUxQZs5c3bs03t9()
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
	private struct _003CAcceptRename_003Ed__62 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ClassViewModel _003C_003E4__this;

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
			ClassViewModel classViewModel = default;
			TaskAwaiter awaiter = default;
			string beVo5Bo4NW = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 4:
					classViewModel = _003C_003E4__this;
					_ = 1;
					if (!RGgsimxLkZexoPZfMZ5())
					{
						num = 1;
						if (0 == 0)
						{
							continue;
						}
						goto case 1;
					}
					num = 5;
					if (true)
					{
						continue;
					}
					break;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 16;
								if (RGgsimxLkZexoPZfMZ5())
								{
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 11;
								if (!CHFp89xifQFFJ1pZ2aM())
								{
									goto IL_0209;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 9;
						}
						goto IL_0112;
						IL_0228:
						beVo5Bo4NW = classViewModel.beVo5Bo4NW;
						classViewModel.ClassName = classViewModel.NewClassName;
						num3 = 2;
						goto IL_0112;
						IL_0112:
						while (true)
						{
							switch (num3)
							{
							case 16:
								classViewModel.IsInRenameMode = false;
								num3 = 22;
								if (0 == 0)
								{
									continue;
								}
								goto case 3;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
								continue;
							case 1:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 5:
								num2 = (_003C_003E1__state = 1);
								num3 = 21;
								continue;
							case 19:
								awaiter = tCMCo2xZXKWDwKscaSe(yfbY4Wx0ENGwXcf7tsg(classViewModel.ParentTool));
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								goto end_IL_0112;
							case 9:
								_003C_003Eu__1 = default;
								goto case 15;
							default:
								num3 = 15;
								if (!RGgsimxLkZexoPZfMZ5())
								{
									continue;
								}
								goto case 22;
							case 22:
								if (classViewModel.NewClassName == classViewModel.ClassName)
								{
									num3 = 14;
									continue;
								}
								if (classViewModel.NewClassName != null)
								{
									num3 = 10;
									continue;
								}
								goto end_IL_0048;
							case 10:
								if (((string)qyvld7xtVbq4dwG8DU8(classViewModel.NewClassName)).Length > 0)
								{
									num3 = 4;
									continue;
								}
								goto end_IL_0048;
							case 20:
								break;
							case 6:
								return;
							case 17:
								return;
							case 18:
								goto end_IL_0112;
							case 12:
								goto IL_0228;
							case 14:
								goto end_IL_0048;
							case 15:
								num2 = (_003C_003E1__state = -1);
								num3 = 0;
								continue;
							case 2:
								awaiter = tCMCo2xZXKWDwKscaSe(JnjOxJxvsE0KE5lEXVE(classViewModel.ParentTool, beVo5Bo4NW, qyvld7xtVbq4dwG8DU8(classViewModel.NewClassName)));
								if (!awaiter.IsCompleted)
								{
									RGgsimxLkZexoPZfMZ5();
									if (CHFp89xifQFFJ1pZ2aM())
									{
										num3 = 7;
										if (CHFp89xifQFFJ1pZ2aM())
										{
											continue;
										}
										goto case 13;
									}
									num3 = 6;
									continue;
								}
								goto case 0;
							case 13:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 4:
								goto IL_02d9;
							case 7:
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								continue;
							case 11:
								_003C_003Eu__1 = default;
								num3 = 3;
								if (!RGgsimxLkZexoPZfMZ5())
								{
									continue;
								}
								goto case 0;
							case 0:
								awaiter.GetResult();
								num3 = 19;
								if (true)
								{
									continue;
								}
								goto case 21;
							case 21:
								_003C_003Eu__1 = awaiter;
								num3 = 13;
								continue;
							case 23:
								loKeZ4xOmchT6TgLSKH(classViewModel, new PropertyChangedEventArgs(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(2452)));
								goto end_IL_0048;
							}
							if (classViewModel.beVo5Bo4NW != null && U229IAx98KHyoZ89Suq(classViewModel.beVo5Bo4NW) > 0)
							{
								num3 = 12;
								continue;
							}
							goto IL_0210;
							IL_02d9:
							if (!classViewModel.ParentTool.ClassNames.Contains(classViewModel.NewClassName))
							{
								num3 = 20;
								continue;
							}
							goto IL_0210;
							continue;
							end_IL_0112:
							break;
						}
						goto IL_0209;
						IL_0210:
						classViewModel.NewClassName = classViewModel.ClassName;
						num3 = 23;
						if (true)
						{
							goto IL_0112;
						}
						goto IL_0228;
						IL_0209:
						awaiter.GetResult();
						goto IL_0210;
						end_IL_0048:;
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
		internal static object qyvld7xtVbq4dwG8DU8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Trim();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int U229IAx98KHyoZ89Suq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JnjOxJxvsE0KE5lEXVE(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Classifier)P_0).RenameClass((string)P_1, (string)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter tCMCo2xZXKWDwKscaSe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yfbY4Wx0ENGwXcf7tsg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Classifier)P_0).RunSheet();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void loKeZ4xOmchT6TgLSKH(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BasePropertyChanged)P_0).RaisePropertyChangedEvent((PropertyChangedEventArgs)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CHFp89xifQFFJ1pZ2aM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RGgsimxLkZexoPZfMZ5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public readonly Classifier ParentTool;

	private ImageListViewModel UcPoKjorKs;

	private ImageListViewModel KUOomjEYmE;

	private bool TjwoMsFh4h;

	[CompilerGenerated]
	private AsyncDelegateCommand s2Fo7TDi8o;

	[CompilerGenerated]
	private AsyncDelegateCommand BM5oYBO7B8;

	[CompilerGenerated]
	private AsyncDelegateCommand tBeo0pi2Dn;

	[CompilerGenerated]
	private DelegateCommand lxKovFmjjV;

	private bool L88oLNJ6Cm;

	private double OfHodvR7dB;

	private string beVo5Bo4NW;

	[CompilerGenerated]
	private string KDIofGZxd6;

	[CompilerGenerated]
	private ClassResultViewModel wSfo9KCUpi;

	public bool IsOnline
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return lC29lQrDMSpnTIst5Sr(ParentTool);
		}
	}

	public ImageListViewModel UnlabeledImages
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return UcPoKjorKs;
		}
	}

	public ImageListViewModel LabeledImages
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KUOomjEYmE;
		}
	}

	public bool IsInRenameMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TjwoMsFh4h;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref TjwoMsFh4h, value, (string)xIM7XXr1kPSlyh3KDw5(560));
		}
	}

	public IEnumerable<ImageListViewModel> AllImageViewModels
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new ImageListViewModel[2] { LabeledImages, UnlabeledImages };
		}
	}

	public int AllImageCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return E4ta6Dr8b9IO51rLuHw(UnlabeledImages) + E4ta6Dr8b9IO51rLuHw(LabeledImages);
		}
	}

	public AsyncDelegateCommand AddImageCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return s2Fo7TDi8o;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			s2Fo7TDi8o = value;
		}
	}

	public AsyncDelegateCommand ToggleRenameModeCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return BM5oYBO7B8;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			BM5oYBO7B8 = value;
		}
	}

	public AsyncDelegateCommand AcceptRenameCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tBeo0pi2Dn;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			tBeo0pi2Dn = value;
		}
	}

	public DelegateCommand CancelRenameCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return lxKovFmjjV;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			lxKovFmjjV = value;
		}
	}

	public bool IsPredicted
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return L88oLNJ6Cm;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			L88oLNJ6Cm = value;
			RaisePropertyChangedEvent(new PropertyChangedEventArgs((string)xIM7XXr1kPSlyh3KDw5(2372)));
		}
	}

	public double PredictedScore
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OfHodvR7dB;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			OfHodvR7dB = value;
			ctECdXrFuikuCCjGkYO(this, new PropertyChangedEventArgs(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(2398)));
		}
	}

	public string ClassName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return beVo5Bo4NW;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref beVo5Bo4NW, value, (string)xIM7XXr1kPSlyh3KDw5(2430));
		}
	}

	public string NewClassName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KDIofGZxd6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KDIofGZxd6 = value;
		}
	}

	public int ImageCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LabeledImages?.Count ?? 0;
		}
	}

	public ClassResultViewModel ClassResult
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wSfo9KCUpi;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			wSfo9KCUpi = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClassViewModel(string className, Classifier parentTool, bool isPredicted = false)
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
			case 10:
				IsPredicted = isPredicted;
				num = 11;
				continue;
			case 5:
				NGLuZSrPJ0UWqk00fNZ(this);
				num = 6;
				if (!Bsy9VwrrI7tcALkH8BP())
				{
					continue;
				}
				goto case 6;
			case 6:
				ClassName = className;
				NewClassName = ClassName;
				_ = 1;
				num = ((!Bsy9VwrrI7tcALkH8BP()) ? 12 : 0);
				continue;
			case 7:
				KUOomjEYmE = new ImageListViewModel(isLabeled: true, this);
				num = 13;
				continue;
			case 8:
				AcceptRenameCommand = new AsyncDelegateCommand(AcceptRename);
				goto case 0;
			case 2:
				ToggleRenameModeCommand = new AsyncDelegateCommand(ToggleRenameMode);
				num = 8;
				continue;
			case 11:
				ClassResult = new ClassResultViewModel(this);
				num = 14;
				continue;
			case 1:
				LnlCQPr4CAF31VPX7AN(ParentTool, new PropertyChangedEventHandler(Unioiis4PM));
				AddImageCommand = new AsyncDelegateCommand(AddImage, [MethodImpl(MethodImplOptions.NoInlining)] () =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return ParentTool.CanAddImage;
				});
				goto case 2;
			default:
				num = 2;
				continue;
			case 0:
			case 9:
				CancelRenameCommand = new DelegateCommand(CancelRename);
				num = 10;
				continue;
			case 4:
				HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
				num = 5;
				continue;
			case 13:
				ParentTool = parentTool;
				num = 1;
				if (PsZ0Oorm9qxPMDdZYFv())
				{
					continue;
				}
				break;
			case 3:
			case 12:
				break;
			case 14:
				return;
			}
			UcPoKjorKs = new ImageListViewModel(isLabeled: false, this);
			num = 7;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Unioiis4PM(object P_0, PropertyChangedEventArgs P_1)
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
			case 4:
				if (dTbEKxrSsIBdXp4ENbh(pV31xLrg6IBlovLeb7N(P_1), xIM7XXr1kPSlyh3KDw5(64)))
				{
					PsZ0Oorm9qxPMDdZYFv();
					num = ((!Bsy9VwrrI7tcALkH8BP()) ? 3 : 0);
					break;
				}
				goto case 0;
			case 1:
			case 3:
				AddImageCommand?.RaiseCanExecuteChanged();
				goto case 0;
			case 0:
			case 2:
				if ((string)pV31xLrg6IBlovLeb7N(P_1) == (string)xIM7XXr1kPSlyh3KDw5(0))
				{
					goto case 6;
				}
				return;
			default:
				num = 6;
				break;
			case 6:
				IsInRenameMode = false;
				num = 5;
				break;
			case 5:
				z0Hlhjr6rx60Z7SwNtT(this, xIM7XXr1kPSlyh3KDw5(0));
				num = 7;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void NotifyImageCountChanged()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ctECdXrFuikuCCjGkYO(this, new PropertyChangedEventArgs((string)xIM7XXr1kPSlyh3KDw5(2254)));
		RaisePropertyChangedEvent(new PropertyChangedEventArgs((string)xIM7XXr1kPSlyh3KDw5(2284)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLabeledImages(IEnumerable<ClassifyImage> images)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		LabeledImages.UpdateImages(images);
		NotifyImageCountChanged();
		RaisePropertyChangedEvent(new PropertyChangedEventArgs(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(2308)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUnlabeledImages(IEnumerable<ClassifyImage> images)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		UnlabeledImages.UpdateImages(images);
		NotifyImageCountChanged();
		RaisePropertyChangedEvent(new PropertyChangedEventArgs(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(2338)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddImage_003Ed__60))]
	public Task AddImage()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		PsZ0Oorm9qxPMDdZYFv();
		int num = (Bsy9VwrrI7tcALkH8BP() ? 3 : 5);
		_003CAddImage_003Ed__60 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CToggleRenameMode_003Ed__61))]
	public Task ToggleRenameMode()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		PsZ0Oorm9qxPMDdZYFv();
		int num;
		if (!Bsy9VwrrI7tcALkH8BP())
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
			if (!PsZ0Oorm9qxPMDdZYFv())
			{
				goto IL_005e;
			}
		}
		goto IL_0090;
		IL_0090:
		_003CToggleRenameMode_003Ed__61 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				break;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = QCMTbKrsEZdgGAy3MHV();
				break;
			case 5:
				goto IL_005e;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto IL_005e;
			default:
				num = 5;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_005e:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0090;
		IL_002a:
		stateMachine._003C_003E4__this = this;
		num = 4;
		goto IL_0090;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAcceptRename_003Ed__62))]
	public Task AcceptRename()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		PsZ0Oorm9qxPMDdZYFv();
		int num = (Bsy9VwrrI7tcALkH8BP() ? 5 : 3);
		_003CAcceptRename_003Ed__62 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 2;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = QCMTbKrsEZdgGAy3MHV();
				goto case 1;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CancelRename()
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
			default:
				IsInRenameMode = false;
				num = 5;
				break;
			case 0:
			case 1:
				RaisePropertyChangedEvent(new PropertyChangedEventArgs((string)xIM7XXr1kPSlyh3KDw5(2452)));
				goto default;
			case 4:
				NewClassName = ClassName;
				_ = 0;
				num = ((!PsZ0Oorm9qxPMDdZYFv()) ? 3 : 0);
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (1 == 0)
		{
			goto IL_0024;
		}
		goto IL_009a;
		IL_0024:
		ClassResult = null;
		num = 6;
		goto IL_009a;
		IL_009a:
		while (true)
		{
			switch (num)
			{
			case 0:
				HhPKIardp07jTSnRfQQ(ParentTool, new PropertyChangedEventHandler(Unioiis4PM));
				Bsy9VwrrI7tcALkH8BP();
				num = ((!PsZ0Oorm9qxPMDdZYFv()) ? 1 : 4);
				continue;
			case 5:
				if (ParentTool != null)
				{
					num = 0;
					continue;
				}
				goto case 2;
			case 2:
			case 4:
				ClassResult?.Dispose();
				break;
			case 6:
				return;
			}
			break;
		}
		goto IL_0024;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool rfmo6YibG7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ParentTool.CanAddImage;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NGLuZSrPJ0UWqk00fNZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseViewModel)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LnlCQPr4CAF31VPX7AN(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PsZ0Oorm9qxPMDdZYFv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Bsy9VwrrI7tcALkH8BP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pV31xLrg6IBlovLeb7N(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertyChangedEventArgs)P_0).PropertyName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xIM7XXr1kPSlyh3KDw5(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dTbEKxrSsIBdXp4ENbh(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void z0Hlhjr6rx60Z7SwNtT(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lC29lQrDMSpnTIst5Sr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Classifier)P_0).IsOnline;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int E4ta6Dr8b9IO51rLuHw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ImageListViewModel)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ctECdXrFuikuCCjGkYO(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).RaisePropertyChangedEvent((PropertyChangedEventArgs)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder QCMTbKrsEZdgGAy3MHV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HhPKIardp07jTSnRfQQ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
	}
}
