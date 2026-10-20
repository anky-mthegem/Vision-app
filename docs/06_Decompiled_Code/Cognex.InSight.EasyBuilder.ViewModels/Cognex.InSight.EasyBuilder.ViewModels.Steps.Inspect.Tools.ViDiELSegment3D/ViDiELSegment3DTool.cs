using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Composition;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Help;
using Cognex.InSight.Graphic;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.ViDiEL.ViewModels.PropertySheets.Segment;
using Cognex.InSight.ViDiEL.ViewModels.Segment;
using Cognex.Mvvm;
using Cognex.Segmenter.Client;
using Cognex.Segmenter.Client.Tool.Interfaces;
using Cognex.WebToolEditControl.Core;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ViDiELSegment3D;

[Export(typeof(ViDiELSegment3DTool))]
public class ViDiELSegment3DTool : ViDiELEzToolBase
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDisposeAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncValueTaskMethodBuilder _003C_003Et__builder;

		public ViDiELSegment3DTool _003C_003E4__this;

		private ValueTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!QG3I9aKqHOiPgGVnCrY6())
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_018e;
			IL_01eb:
			ViDiELSegment3DTool viDiELSegment3DTool = _003C_003E4__this;
			num = 2;
			goto IL_018e;
			IL_018e:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				default:
					num = 4;
					continue;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto IL_01eb;
				case 4:
					goto IL_01d0;
				case 1:
				case 5:
					goto IL_01eb;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			try
			{
				int num3;
				ValueTaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					Vr4hxcKqxXGcrZdQvIxu(viDiELSegment3DTool.trHX0qPZKS);
					num3 = 9;
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 1;
					if (false)
					{
						goto IL_00fa;
					}
				}
				goto IL_005c;
				IL_00fa:
				num2 = (_003C_003E1__state = -1);
				num3 = 10;
				goto IL_005c;
				IL_005c:
				ValueTask valueTask = default;
				while (true)
				{
					switch (num3)
					{
					case 3:
					case 4:
						num2 = (_003C_003E1__state = 0);
						goto case 0;
					default:
						num3 = 0;
						continue;
					case 6:
						if (!awaiter.IsCompleted)
						{
							WiornCKqUWoXmn1BFJAV();
							num3 = (QG3I9aKqHOiPgGVnCrY6() ? 2 : 4);
							continue;
						}
						goto case 10;
					case 0:
						_003C_003Eu__1 = awaiter;
						num3 = 8;
						if (WiornCKqUWoXmn1BFJAV())
						{
							continue;
						}
						goto case 8;
					case 8:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 2:
					case 7:
						break;
					case 5:
						awaiter = valueTask.GetAwaiter();
						num3 = 6;
						continue;
					case 9:
						valueTask = viDiELSegment3DTool.y7aX4dvauD();
						num3 = 5;
						continue;
					case 1:
						_003C_003Eu__1 = default;
						break;
					case 10:
						awaiter.GetResult();
						goto end_IL_005c;
					}
					goto IL_00fa;
					continue;
					end_IL_005c:
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
			goto IL_01d0;
			IL_01d0:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (!QG3I9aKqHOiPgGVnCrY6())
			{
				goto IL_018e;
			}
			goto IL_01eb;
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
		internal static void Vr4hxcKqxXGcrZdQvIxu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WiornCKqUWoXmn1BFJAV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QG3I9aKqHOiPgGVnCrY6()
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
	private struct _003CInternalPostParse_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELSegment3DTool _003C_003E4__this;

		public CvsCellCollection cells;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cYPKlYKq1NyxBUhFUVkn();
			int num = ((!asIIg3KqcUWKwkhiWOAJ()) ? 4 : 2);
			int num2 = default;
			ViDiELSegment3DTool viDiELSegment3DTool = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							viDiELSegment3DTool.hVwoE9ITha = new SegmentProjectionParamsViewModel((CvsInSight)i5yh5QKqu1pDmV8GqGXL(viDiELSegment3DTool.fA0XVtI5F0), viDiELSegment3DTool.lfyXLSs72Y, (string)Mbf4RZKqhtjFAgIibhLW(viDiELSegment3DTool.lfyXLSs72Y));
							num3 = 4;
							if (cYPKlYKq1NyxBUhFUVkn())
							{
								goto IL_0065;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
						}
						goto IL_01b5;
						IL_01b5:
						while (true)
						{
							switch (num3)
							{
							case 2:
								break;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 13;
								continue;
							case 3:
								viDiELSegment3DTool.DoAutoTune = new DelegateCommand(viDiELSegment3DTool.hVwoE9ITha.PerformAutoTune, [MethodImpl(MethodImplOptions.NoInlining)] () =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									return true;
								});
								num3 = 5;
								if (!cYPKlYKq1NyxBUhFUVkn())
								{
									continue;
								}
								goto case 5;
							case 5:
								viDiELSegment3DTool.hVwoE9ITha.InitializeProjectionParams();
								num3 = 2;
								continue;
							case 4:
								if (viDiELSegment3DTool.hVwoE9ITha != null)
								{
									_ = 1;
									num3 = (cYPKlYKq1NyxBUhFUVkn() ? 11 : 12);
									continue;
								}
								break;
							case 1:
							case 12:
								m3CoojKqtaOM8yF4npTC(viDiELSegment3DTool.hVwoE9ITha, viDiELSegment3DTool.ToolId);
								num3 = 3;
								continue;
							default:
								_003C_003Eu__1 = awaiter;
								num3 = 10;
								continue;
							case 0:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								continue;
							case 9:
								return;
							case 8:
								awaiter = Ej6XKUKqzhuxHr4T1jED(viDiELSegment3DTool.IAHXlM7pdE(cells));
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									goto default;
								}
								goto case 13;
							case 13:
								awaiter.GetResult();
								goto end_IL_01b5;
							}
							goto IL_0065;
							continue;
							end_IL_01b5:
							break;
						}
						goto end_IL_0028;
						IL_0065:
						viDiELSegment3DTool.NGWXcRvn4Z();
						num3 = 8;
						goto IL_01b5;
						end_IL_0028:;
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
					viDiELSegment3DTool = _003C_003E4__this;
					num = 5;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
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
		internal static object i5yh5QKqu1pDmV8GqGXL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Mbf4RZKqhtjFAgIibhLW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EZBSegment3DAdapter)P_0).FocusedToolId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void m3CoojKqtaOM8yF4npTC(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((SegmentProjectionParamsViewModel)P_0).ToolId = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Ej6XKUKqzhuxHr4T1jED(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool asIIg3KqcUWKwkhiWOAJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cYPKlYKq1NyxBUhFUVkn()
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
	private struct _003CWriteFixturedGraphics_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELSegment3DTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_02b3;
			IL_0067:
			int num2 = default;
			ViDiELSegment3DTool viDiELSegment3DTool = default;
			try
			{
				int num3;
				TaskAwaiter<CvsCogSheetResult> awaiter = default;
				TaskAwaiter awaiter2 = default;
				if (num2 != 0)
				{
					if (num2 != 1)
					{
						pXhyk4KELxwEks6H4fv2();
						if (!I8nsbJKEKG8dr8lNNRxv())
						{
							num3 = 1;
							if (!pXhyk4KELxwEks6H4fv2())
							{
								goto IL_0094;
							}
						}
						else
						{
							num3 = 12;
							if (false)
							{
								return;
							}
						}
					}
					else
					{
						awaiter = _003C_003Eu__2;
						num3 = 15;
					}
				}
				else
				{
					awaiter2 = _003C_003Eu__1;
					num3 = 3;
				}
				goto IL_01c5;
				IL_01c5:
				while (true)
				{
					switch (num3)
					{
					case 6:
						break;
					case 11:
						if (!awaiter2.IsCompleted)
						{
							num3 = 14;
							continue;
						}
						goto case 4;
					case 13:
						return;
					case 10:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					case 5:
						return;
					case 12:
						return;
					case 14:
						num2 = (_003C_003E1__state = 0);
						num3 = 7;
						continue;
					case 9:
						_003C_003Eu__2 = awaiter;
						num3 = 6;
						if (true)
						{
							continue;
						}
						goto case 8;
					case 8:
						awaiter = ((CvsCogSocket)Ds7qrVKEaeEeekDTFGTd(viDiELSegment3DTool.InSight)).Sheet.RunAsync(fireSheetUpdated: false).GetAwaiter();
						num3 = 2;
						continue;
					case 2:
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 1);
							num3 = 9;
							if (pXhyk4KELxwEks6H4fv2())
							{
								continue;
							}
							goto case 15;
						}
						goto case 16;
					case 15:
						_003C_003Eu__2 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						continue;
					case 3:
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						goto case 4;
					default:
						num3 = 4;
						continue;
					case 7:
						_003C_003Eu__1 = awaiter2;
						num3 = 10;
						continue;
					case 4:
						awaiter2.GetResult();
						num3 = 8;
						continue;
					case 0:
					case 1:
						awaiter2 = ((Task)zfu7O6KEJcCrvcW8fZUQ(viDiELSegment3DTool.InSight, Yn746pKEwtKMDI08WQFX(MOX0qhKE5itVATuZ4sDI(viDiELSegment3DTool.Region)), MOX0qhKE5itVATuZ4sDI(viDiELSegment3DTool.Region))).GetAwaiter();
						num3 = 11;
						continue;
					case 16:
						awaiter.GetResult();
						goto end_IL_01c5;
					}
					goto IL_0094;
					continue;
					end_IL_01c5:
					break;
				}
				goto end_IL_0067;
				IL_0094:
				_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
				num3 = 13;
				goto IL_01c5;
				end_IL_0067:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0052;
			IL_02b3:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					break;
				case 0:
					goto IL_0031;
				case 3:
					goto IL_0052;
				case 2:
				case 4:
					goto IL_0067;
				default:
					num = 3;
					if (true)
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
				IL_0031:
				num2 = _003C_003E1__state;
				I8nsbJKEKG8dr8lNNRxv();
				num = (pXhyk4KELxwEks6H4fv2() ? 5 : 4);
			}
			goto IL_001a;
			IL_0052:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_02b3;
			IL_001a:
			viDiELSegment3DTool = _003C_003E4__this;
			goto IL_0067;
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
		internal static object MOX0qhKE5itVATuZ4sDI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EditableGraphicsViewModel)P_0).Graphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation Yn746pKEwtKMDI08WQFX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditableDisplayGraphic)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zfu7O6KEJcCrvcW8fZUQ(object P_0, CvsCellLocation loc, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Ds7qrVKEaeEeekDTFGTd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pXhyk4KELxwEks6H4fv2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool I8nsbJKEKG8dr8lNNRxv()
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
	private struct _003CFocusOnPropertyChanged_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELSegment3DTool _003C_003E4__this;

		public object sender;

		public PropertyChangedEventArgs e;

		private TaskAwaiter _003C_003Eu__1;

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
			ViDiELSegment3DTool viDiELSegment3DTool = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__1;
								goto IL_004e;
							}
							num3 = 8;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
						}
						goto IL_00f7;
						IL_00f7:
						while (true)
						{
							switch (num3)
							{
							case 1:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 9;
									continue;
								}
								goto IL_01bb;
							case 12:
							case 14:
								break;
							case 16:
								if (RvUYkmKEnoSJCuhEEvNG(viDiELSegment3DTool.Focus))
								{
									num3 = 11;
									if (ODSJDIKEevqvDLETaLxL())
									{
										continue;
									}
									goto case 3;
								}
								goto case 18;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto case 10;
							case 10:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								goto case 17;
							case 5:
							case 13:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 17:
								awaiter.GetResult();
								goto case 0;
							default:
								num3 = 0;
								continue;
							case 9:
								_003C_003Eu__1 = awaiter;
								ODSJDIKEevqvDLETaLxL();
								num3 = ((!SnAws6KEOrjoYEK47ISb()) ? 5 : 12);
								continue;
							case 11:
								awaiter = k8VTaLKEIipBYLZRZPy1(viDiELSegment3DTool.cjmXgpZLD6());
								num3 = 1;
								continue;
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 15;
								continue;
							case 4:
								return;
							case 7:
								num2 = (_003C_003E1__state = -1);
								goto IL_01bb;
							case 15:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								continue;
							case 8:
								awaiter = k8VTaLKEIipBYLZRZPy1(viDiELSegment3DTool.bdOXTfmEqw(sender, e));
								num3 = 10;
								if (ODSJDIKEevqvDLETaLxL())
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 17;
								continue;
							case 0:
								if ((string)yq396EKEDK1GcBbWCTni(e) == (string)q5PsaxKEiDtg8KYmuSk9(5436))
								{
									num3 = 16;
									if (0 == 0)
									{
										continue;
									}
									goto case 18;
								}
								goto end_IL_00f7;
							case 18:
								{
									viDiELSegment3DTool.zTyXQHrflt();
									goto end_IL_00f7;
								}
								IL_01bb:
								awaiter.GetResult();
								num3 = 18;
								continue;
							}
							goto IL_004e;
							continue;
							end_IL_00f7:
							break;
						}
						goto end_IL_0018;
						IL_004e:
						_003C_003Eu__1 = default;
						num3 = 7;
						goto IL_00f7;
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
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 1:
					viDiELSegment3DTool = _003C_003E4__this;
					ODSJDIKEevqvDLETaLxL();
					if (SnAws6KEOrjoYEK47ISb())
					{
						num = 0;
						if (!SnAws6KEOrjoYEK47ISb())
						{
							continue;
						}
						goto case 5;
					}
					num = 4;
					if (SnAws6KEOrjoYEK47ISb())
					{
					}
					continue;
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
		internal static TaskAwaiter k8VTaLKEIipBYLZRZPy1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yq396EKEDK1GcBbWCTni(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PropertyChangedEventArgs)P_0).PropertyName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object q5PsaxKEiDtg8KYmuSk9(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RvUYkmKEnoSJCuhEEvNG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((InternalCheckBoxViewModel)P_0).Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ODSJDIKEevqvDLETaLxL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SnAws6KEOrjoYEK47ISb()
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
	private struct _003CCheckHasSamplesAsync_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViDiELSegment3DTool _003C_003E4__this;

		private TaskAwaiter<ISegmenterStats> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hHVmXmKEfCfSvb9OTEbd();
			int num;
			if (nKxq2gKEVI3EGpvagqbI())
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_01d1;
			IL_002a:
			ViDiELSegment3DTool viDiELSegment3DTool = _003C_003E4__this;
			num = 2;
			goto IL_01d1;
			IL_01d1:
			int num2 = default;
			ISegmenterStats result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					break;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 2:
					try
					{
						TaskAwaiter<ISegmenterStats> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = viDiELSegment3DTool.lfyXLSs72Y.GetStats(viDiELSegment3DTool.ToolId).GetAwaiter();
							num3 = 9;
							if (!nKxq2gKEVI3EGpvagqbI())
							{
								goto IL_007d;
							}
							goto IL_00b1;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0159;
						IL_012c:
						num2 = (_003C_003E1__state = -1);
						num3 = 3;
						goto IL_00b1;
						IL_0159:
						_003C_003Eu__1 = default;
						goto IL_012c;
						IL_007d:
						if (!awaiter.IsCompleted)
						{
							num3 = 1;
							goto IL_00b1;
						}
						goto IL_0118;
						IL_0118:
						result = awaiter.GetResult();
						num3 = 7;
						if (true)
						{
							goto IL_00b1;
						}
						goto IL_012c;
						IL_00b1:
						while (true)
						{
							switch (num3)
							{
							case 9:
								break;
							case 4:
								return;
							default:
								num3 = 8;
								continue;
							case 1:
								goto IL_00ec;
							case 3:
								goto IL_0118;
							case 5:
							case 6:
								goto IL_012c;
							case 0:
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto IL_0159;
							case 8:
								goto IL_0159;
							case 7:
								viDiELSegment3DTool.HasSamples = result.numSamples > 0;
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								goto case 10;
							case 10:
								viDiELSegment3DTool.mUmXRuK3i0();
								goto end_IL_0050;
							}
							break;
							IL_00ec:
							num2 = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							_ = 1;
							if (!hHVmXmKEfCfSvb9OTEbd())
							{
								num3 = 0;
								if (!hHVmXmKEfCfSvb9OTEbd())
								{
									continue;
								}
								goto IL_0118;
							}
							num3 = 6;
						}
						goto IL_007d;
						end_IL_0050:;
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
					continue;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					break;
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
		internal static bool nKxq2gKEVI3EGpvagqbI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hHVmXmKEfCfSvb9OTEbd()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly IDisposable trHX0qPZKS;

	private InspectStepViewModel fA0XVtI5F0;

	private EZBSegment3DAdapter lfyXLSs72Y;

	[CompilerGenerated]
	private Dictionary<string, Dictionary<string, FloatViewModel>> p0jXJ1W3ZC;

	private IEnumerable<ViDiELSegment3DResultViewModel> SjLX9UyUm4;

	private readonly List<ViDiELSegment3DResultViewModel> WdtXr6BEJO;

	private bool wO8XhbVR0T;

	private bool OEjX8oy2MN;

	[CompilerGenerated]
	private EditRegionViewModel N8hXmY7MiO;

	[CompilerGenerated]
	private ListBoxViewModel ap6X113kwh;

	[CompilerGenerated]
	private ListBoxViewModel OFAXzlhZkl;

	[CompilerGenerated]
	private ListBoxViewModel SqSoaroi9n;

	[CompilerGenerated]
	private EditFloatViewModel ATWo5DQfTR;

	[CompilerGenerated]
	private ListBoxViewModel XrKop0tlG3;

	[CompilerGenerated]
	private EditIntViewModel io5oUEpSSF;

	[CompilerGenerated]
	private EditFloatViewModel ovAo7eLoKh;

	[CompilerGenerated]
	private EditFloatViewModel siNoN2aiOS;

	[CompilerGenerated]
	private EditFloatViewModel d8CoA4Vhjf;

	[CompilerGenerated]
	private EditFloatViewModel eJNod9O5aE;

	[CompilerGenerated]
	private EditFloatViewModel Y0Oo6b4rGy;

	[CompilerGenerated]
	private EditFloatViewModel zWgouQ8yj3;

	[CompilerGenerated]
	private ListBoxViewModel hckoFb1MqB;

	[CompilerGenerated]
	private IntViewModel GrjoXta4HG;

	[CompilerGenerated]
	private CheckBoxViewModel jypooy48vW;

	[CompilerGenerated]
	private EditIntViewModel cnWoSlCdxF;

	[CompilerGenerated]
	private EditIntViewModel WkhoDs8oFZ;

	[CompilerGenerated]
	private FloatViewModel drSo3AyPnG;

	[CompilerGenerated]
	private FloatViewModel e5toIDk9OA;

	[CompilerGenerated]
	private DelegateCommand fEZofBdG4g;

	private SegmentProjectionParamsViewModel hVwoE9ITha;

	public override bool AllowsAnyImageAsInput
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

	public override string ImagePath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Tools_Segment3DIcon;
		}
	}

	public Dictionary<string, Dictionary<string, FloatViewModel>> ResultViewModels
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return p0jXJ1W3ZC;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			p0jXJ1W3ZC = value;
		}
	}

	public IEnumerable<ViDiELSegment3DResultViewModel> Results
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SjLX9UyUm4;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref SjLX9UyUm4, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6452));
		}
	}

	public bool HasSamples
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wO8XhbVR0T;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref wO8XhbVR0T, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6478));
		}
	}

	public override bool ShowHelp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OEjX8oy2MN;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref OEjX8oy2MN, value, (string)oteC7Wv5uaKQrv1RvHE(6502));
		}
	}

	public EditRegionViewModel Region
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return N8hXmY7MiO;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			N8hXmY7MiO = value;
		}
	}

	public ListBoxViewModel ProjectionImageResolution
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ap6X113kwh;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ap6X113kwh = value;
		}
	}

	public ListBoxViewModel SortKey
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OFAXzlhZkl;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			OFAXzlhZkl = value;
		}
	}

	public ListBoxViewModel SortOrder
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SqSoaroi9n;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SqSoaroi9n = value;
		}
	}

	public EditFloatViewModel SortTolerance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ATWo5DQfTR;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ATWo5DQfTR = value;
		}
	}

	public ListBoxViewModel SortReference
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XrKop0tlG3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			XrKop0tlG3 = value;
		}
	}

	public EditIntViewModel ConfidenceThreshold
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return io5oUEpSSF;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			io5oUEpSSF = value;
		}
	}

	public EditFloatViewModel MinimumVolume
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ovAo7eLoKh;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ovAo7eLoKh = value;
		}
	}

	public EditFloatViewModel MaximumVolume
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return siNoN2aiOS;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			siNoN2aiOS = value;
		}
	}

	public EditFloatViewModel MinimumArea
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return d8CoA4Vhjf;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			d8CoA4Vhjf = value;
		}
	}

	public EditFloatViewModel MaximumArea
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return eJNod9O5aE;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			eJNod9O5aE = value;
		}
	}

	public EditFloatViewModel MinimumHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Y0Oo6b4rGy;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Y0Oo6b4rGy = value;
		}
	}

	public EditFloatViewModel MaximumHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zWgouQ8yj3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zWgouQ8yj3 = value;
		}
	}

	public ListBoxViewModel Orientation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hckoFb1MqB;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hckoFb1MqB = value;
		}
	}

	public IntViewModel NumberFound
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GrjoXta4HG;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			GrjoXta4HG = value;
		}
	}

	public CheckBoxViewModel RangeLimitsInvert
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return jypooy48vW;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			jypooy48vW = value;
		}
	}

	public EditIntViewModel RangeLimitsMax
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return cnWoSlCdxF;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cnWoSlCdxF = value;
		}
	}

	public EditIntViewModel RangeLimitsMin
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WkhoDs8oFZ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WkhoDs8oFZ = value;
		}
	}

	public FloatViewModel FeatureWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return drSo3AyPnG;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			drSo3AyPnG = value;
		}
	}

	public FloatViewModel FeatureHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return e5toIDk9OA;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			e5toIDk9OA = value;
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
			return fEZofBdG4g;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fEZofBdG4g = value;
		}
	}

	public SegmentProjectionParamsViewModel SegmentProjectionParams
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hVwoE9ITha;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ViDiELSegment3DTool(InspectStepViewModel inspect, bool isInitialized, EZBSegment3DAdapter adapter, SnippetLocalizer localizer = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 4:
				ResultViewModels = new Dictionary<string, Dictionary<string, FloatViewModel>>
				{
					{
						(string)oteC7Wv5uaKQrv1RvHE(5450),
						new Dictionary<string, FloatViewModel>()
					},
					{
						CdQUGaROfy7He9T0foW.KbIzwHEDLa(5470),
						new Dictionary<string, FloatViewModel>()
					},
					{
						(string)oteC7Wv5uaKQrv1RvHE(5490),
						new Dictionary<string, FloatViewModel>()
					},
					{
						(string)oteC7Wv5uaKQrv1RvHE(5510),
						new Dictionary<string, FloatViewModel>()
					},
					{
						(string)oteC7Wv5uaKQrv1RvHE(5530),
						new Dictionary<string, FloatViewModel>()
					},
					{
						(string)oteC7Wv5uaKQrv1RvHE(5550),
						new Dictionary<string, FloatViewModel>()
					},
					{
						(string)oteC7Wv5uaKQrv1RvHE(5570),
						new Dictionary<string, FloatViewModel>()
					},
					{
						CdQUGaROfy7He9T0foW.KbIzwHEDLa(5590),
						new Dictionary<string, FloatViewModel>()
					},
					{
						CdQUGaROfy7He9T0foW.KbIzwHEDLa(5610),
						new Dictionary<string, FloatViewModel>()
					},
					{
						(string)oteC7Wv5uaKQrv1RvHE(5630),
						new Dictionary<string, FloatViewModel>()
					}
				};
				num = 11;
				continue;
			case 8:
				fA0XVtI5F0 = inspect;
				goto case 9;
			default:
				num = 9;
				continue;
			case 6:
				OEjX8oy2MN = true;
				goto case 3;
			case 3:
			case 7:
				base._002Ector(inspect, isInitialized, localizer);
				num = 8;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 5:
				WdtXr6BEJO = new List<ViDiELSegment3DResultViewModel>();
				num = 6;
				continue;
			case 9:
				lfyXLSs72Y = adapter;
				num = 2;
				continue;
			case 2:
				lfyXLSs72Y.RunToolCallback = cjmXgpZLD6;
				num = 10;
				if (0 == 0)
				{
					continue;
				}
				goto case 10;
			case 10:
				ViDiELEzToolBase.Log = LogManager.GetLogger<ViDiELSegment3DTool>();
				trHX0qPZKS = ((State)n0kK85vKZMQxeqoMfyS()).StateChanged.Subscribe(OM2XM4fZHL);
				num = 4;
				if (!lbntiBsz46axVojICgy())
				{
					continue;
				}
				break;
			case 0:
				break;
			case 11:
				return;
			}
			lJsaMovLdU2K2CJRObn();
			lbntiBsz46axVojICgy();
			num = (UsR1YGsteqFa2bXoXhn() ? 5 : 7);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__4))]
	public override ValueTask DisposeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!UsR1YGsteqFa2bXoXhn()) ? 5 : 4);
		_003CDisposeAsync_003Ed__4 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = AsyncValueTaskMethodBuilder.Create();
				num = 1;
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnResultsChanged(CvsResultSet results)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base.OnResultsChanged(results);
		NGWXcRvn4Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInternalPostParse_003Ed__10))]
	protected override Task InternalPostParse(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (UsR1YGsteqFa2bXoXhn())
		{
			num = 1;
		}
		else
		{
			num = 5;
			if (1 == 0)
			{
				goto IL_009f;
			}
		}
		goto IL_0068;
		IL_0068:
		_003CInternalPostParse_003Ed__10 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 4;
				continue;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 4:
				stateMachine.cells = cells;
				goto default;
			case 0:
			case 1:
				break;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 2;
				if (!lbntiBsz46axVojICgy())
				{
					continue;
				}
				goto case 7;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_009f;
		IL_009f:
		stateMachine._003C_003Et__builder = qdd5W3vw4TGQNb7VQXZ();
		num = 6;
		goto IL_0068;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalParseCell(string relativeCellName, CvsCellCollection cells, CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		uint num2 = default;
		int num3 = default;
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 54:
				return;
			case 10:
				AddProperty(MaximumVolume);
				num = 33;
				break;
			case 41:
				if (num2 != 2949417131u)
				{
					num = 2;
				}
				else if (ANc6MHvJICHNoWBOp0L(relativeCellName, oteC7Wv5uaKQrv1RvHE(5928)))
				{
					MaximumVolume = new EditFloatViewModel(InSight, cells, loc, (string)fuCbvkvdcxY8wXl1CS1());
					num = 10;
				}
				else
				{
					num = 30;
				}
				break;
			case 63:
				if (num2 != 407935320)
				{
					num = 46;
					break;
				}
				if (ANc6MHvJICHNoWBOp0L(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(5754)))
				{
					SortKey = new ListBoxViewModel(InSight, cells, loc, (string)DuBA1nvI78XymIhtIO4());
					num = 64;
					if (!lbntiBsz46axVojICgy())
					{
						break;
					}
					goto case 37;
				}
				num = 55;
				break;
			case 1:
				if (num2 <= 781469175)
				{
					num = 63;
					break;
				}
				switch (num2)
				{
				case 967067236u:
					if (!(relativeCellName == (string)oteC7Wv5uaKQrv1RvHE(6096)))
					{
						num = 53;
						goto end_IL_05db;
					}
					NumberFound = new IntViewModel(InSight, cells, loc, Resources.NumberFound);
					AddProperty(NumberFound);
					num = 21;
					goto end_IL_05db;
				case 793500076u:
					if (ANc6MHvJICHNoWBOp0L(relativeCellName, oteC7Wv5uaKQrv1RvHE(5796)))
					{
						SortTolerance = new EditFloatViewModel(InSight, cells, loc, (string)BLngZuvij2KvgBV7ulL());
						AddProperty(SortTolerance);
						return;
					}
					num = 66;
					goto end_IL_05db;
				}
				goto case 2;
			case 23:
				return;
			case 2:
			case 5:
			case 18:
			case 20:
			case 22:
			case 24:
			case 30:
			case 39:
			case 43:
			case 44:
			case 50:
			case 51:
			case 53:
			case 55:
			case 66:
			case 69:
				num3 = 0;
				num = 45;
				break;
			case 57:
				return;
			case 64:
				AddProperty(SortKey);
				num = 25;
				break;
			case 25:
				return;
			case 68:
				AddProperty(SortReference);
				num = 15;
				break;
			case 4:
				AddProperty(RangeLimitsMin);
				num = 23;
				break;
			case 45:
			case 65:
				if (num3 >= RewYn6vSx04k39xR9pc(ResultViewModels))
				{
					num = 71;
					break;
				}
				text = num3.ToString((string)oteC7Wv5uaKQrv1RvHE(6158));
				num = 12;
				break;
			case 49:
				CJGXbZwo69(CdQUGaROfy7He9T0foW.KbIzwHEDLa(6166) + text, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6294), cells, loc, (string)PUPLwFvG10RYfmtKprw());
				num = 17;
				break;
			case 7:
			case 8:
				if (num2 != 1227782301)
				{
					num = 50;
					break;
				}
				if (!(relativeCellName == (string)oteC7Wv5uaKQrv1RvHE(5684)))
				{
					num = 69;
					break;
				}
				Region = new EditRegionViewModel(InSight, cells, loc, (string)Gn39AwvalrbTrvSv8v8(), pHBN7Fvev6PuQKaWFbF(InputImage));
				num = 36;
				break;
			case 33:
				return;
			case 48:
				return;
			case 61:
				if (num2 != 2580216872u)
				{
					num = 39;
					if (!lbntiBsz46axVojICgy())
					{
						break;
					}
				}
				else if (ANc6MHvJICHNoWBOp0L(relativeCellName, oteC7Wv5uaKQrv1RvHE(6040)))
				{
					MinimumHeight = new EditFloatViewModel(InSight, cells, loc, (string)rno4govsZ3CJauAhS6Q());
					num = 60;
					break;
				}
				goto case 2;
			case 62:
				return;
			case 60:
				AddProperty(MinimumHeight);
				num = 16;
				break;
			case 32:
				if (num2 <= 2046460609)
				{
					num = 40;
					break;
				}
				if (num2 == 2107307704)
				{
					if (ANc6MHvJICHNoWBOp0L(relativeCellName, oteC7Wv5uaKQrv1RvHE(5958)))
					{
						MaximumArea = new EditFloatViewModel(InSight, cells, loc, (string)WYhJCxvlINmQt9beIFQ());
						num = 35;
						break;
					}
					goto case 2;
				}
				num = 14;
				if (false)
				{
					return;
				}
				break;
			case 21:
				return;
			case 28:
				AddProperty(MaximumHeight);
				num = 27;
				break;
			case 3:
				if (num2 != 2046460609)
				{
					num = 51;
					if (true)
					{
						break;
					}
					goto case 35;
				}
				if (ANc6MHvJICHNoWBOp0L(relativeCellName, oteC7Wv5uaKQrv1RvHE(6122)))
				{
					RangeLimitsInvert = new CheckBoxViewModel(InSight, cells, loc, Resources.wSu9AQgjLd(), IsInitialized);
					AddProperty(RangeLimitsInvert);
					return;
				}
				goto case 2;
			case 35:
				AddProperty(MaximumArea);
				return;
			case 15:
				return;
			case 70:
				AddProperty(RangeLimitsMax);
				return;
			case 56:
				return;
			case 59:
				AddProperty(MinimumVolume);
				num = 54;
				break;
			case 29:
				return;
			case 19:
				if (num2 == 1875177834)
				{
					if (!ANc6MHvJICHNoWBOp0L(relativeCellName, oteC7Wv5uaKQrv1RvHE(5984)))
					{
						num = 18;
						if (true)
						{
							break;
						}
						goto case 32;
					}
					MinimumArea = new EditFloatViewModel(InSight, cells, loc, Resources.MinimumArea);
					num = 31;
					if (!UsR1YGsteqFa2bXoXhn())
					{
						return;
					}
					break;
				}
				goto case 2;
			case 11:
				if (num2 == 2856522564u)
				{
					if (ANc6MHvJICHNoWBOp0L(relativeCellName, oteC7Wv5uaKQrv1RvHE(5856)))
					{
						ConfidenceThreshold = new EditIntViewModel(InSight, cells, loc, (string)vdgNqivVYKcLH4FiM8y());
						AddProperty(ConfidenceThreshold);
						num = 67;
					}
					else
					{
						num = 43;
					}
					break;
				}
				num = 41;
				if (true)
				{
					break;
				}
				goto case 36;
			case 36:
				AddProperty(Region);
				num = 47;
				break;
			case 67:
				return;
			case 42:
				if (num2 <= 967067236)
				{
					num = 1;
					if (1 == 0)
					{
						return;
					}
					break;
				}
				if (num2 > 1227782301)
				{
					if (num2 != 1463500116)
					{
						if (num2 != 1708294022)
						{
							num = 19;
							if (lbntiBsz46axVojICgy())
							{
							}
							break;
						}
						if (ANc6MHvJICHNoWBOp0L(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6010)))
						{
							MaximumHeight = new EditFloatViewModel(InSight, cells, loc, (string)d92YMevgThw0rTi8MWB());
							num = 28;
							if (true)
							{
								break;
							}
						}
					}
					else if (ANc6MHvJICHNoWBOp0L(relativeCellName, oteC7Wv5uaKQrv1RvHE(5772)))
					{
						SortOrder = new ListBoxViewModel(InSight, cells, loc, (string)GL8iSNvDOSy9P5njdpw());
						AddProperty(SortOrder);
						num = 48;
						break;
					}
					goto case 2;
				}
				num = 37;
				break;
			case 0:
				return;
			case 46:
				while (true)
				{
					if (num2 != 781469175)
					{
						num = 22;
						break;
					}
					if (relativeCellName == CdQUGaROfy7He9T0foW.KbIzwHEDLa(6148))
					{
						RangeLimitsMin = new EditIntViewModel(InSight, cells, loc, (string)OB4osovvWKO6aUrvRtY());
						num = 4;
						if (!lbntiBsz46axVojICgy())
						{
							break;
						}
						continue;
					}
					goto case 2;
				}
				break;
			case 47:
				return;
			default:
				num = 58;
				break;
			case 58:
				return;
			case 37:
				if (num2 != 1017635769)
				{
					_ = 0;
					if (!UsR1YGsteqFa2bXoXhn())
					{
						num = 0;
						if (0 == 0)
						{
							break;
						}
						goto case 59;
					}
					num = 7;
					if (0 == 0)
					{
						break;
					}
					goto case 40;
				}
				if (ANc6MHvJICHNoWBOp0L(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6138)))
				{
					RangeLimitsMax = new EditIntViewModel(InSight, cells, loc, Resources.Sk896fGd7e());
					num = 70;
				}
				else
				{
					num = 20;
				}
				break;
			case 40:
				if (num2 == 2024045409)
				{
					if (!ANc6MHvJICHNoWBOp0L(relativeCellName, oteC7Wv5uaKQrv1RvHE(5898)))
					{
						num = 24;
						if (false)
						{
							return;
						}
						break;
					}
					MinimumVolume = new EditFloatViewModel(InSight, cells, loc, (string)HakRoovfSPFdyKMBlYG());
					num = 59;
					if (lbntiBsz46axVojICgy())
					{
					}
				}
				else
				{
					num = 3;
				}
				break;
			case 17:
				return;
			case 38:
				if (num2 == 3310475713u)
				{
					if (ANc6MHvJICHNoWBOp0L(relativeCellName, oteC7Wv5uaKQrv1RvHE(6070)))
					{
						Orientation = new ListBoxViewModel(InSight, cells, loc, Resources.Orientation);
						AddProperty(Orientation);
						num = 57;
						break;
					}
					num = 5;
					if (UsR1YGsteqFa2bXoXhn())
					{
						break;
					}
				}
				goto case 2;
			case 12:
				if (relativeCellName.EndsWith((string)r7yitKvrAxMMsyqSP2a(oteC7Wv5uaKQrv1RvHE(6166), text, oteC7Wv5uaKQrv1RvHE(6182))))
				{
					CJGXbZwo69((string)OnQpblvPsodEIBP7Y08(oteC7Wv5uaKQrv1RvHE(6166), text), (string)oteC7Wv5uaKQrv1RvHE(6200), cells, loc, (string)fv4HL0vZoGLAYf3bbLu());
					return;
				}
				if (L53KRxvBQT40xv2OSqW(relativeCellName, (string)oteC7Wv5uaKQrv1RvHE(6166) + text + CdQUGaROfy7He9T0foW.KbIzwHEDLa(6216)))
				{
					num = 13;
					if (false)
					{
						return;
					}
					break;
				}
				if (!L53KRxvBQT40xv2OSqW(relativeCellName, r7yitKvrAxMMsyqSP2a(oteC7Wv5uaKQrv1RvHE(6166), text, oteC7Wv5uaKQrv1RvHE(6242))))
				{
					if (!L53KRxvBQT40xv2OSqW(relativeCellName, r7yitKvrAxMMsyqSP2a(oteC7Wv5uaKQrv1RvHE(6166), text, oteC7Wv5uaKQrv1RvHE(6260))))
					{
						if (relativeCellName.EndsWith((string)r7yitKvrAxMMsyqSP2a(oteC7Wv5uaKQrv1RvHE(6166), text, oteC7Wv5uaKQrv1RvHE(6324))))
						{
							num = 52;
							if (!lbntiBsz46axVojICgy())
							{
								break;
							}
							goto case 2;
						}
						if (!L53KRxvBQT40xv2OSqW(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6166) + text + (string)oteC7Wv5uaKQrv1RvHE(6388)))
						{
							num3++;
							num = 65;
							break;
						}
						CJGXbZwo69((string)oteC7Wv5uaKQrv1RvHE(6166) + text, (string)oteC7Wv5uaKQrv1RvHE(6422), cells, loc, Resources.SSDmQCPRTU());
						num = 29;
						if (UsR1YGsteqFa2bXoXhn())
						{
							break;
						}
						goto case 13;
					}
					num = 49;
					break;
				}
				CJGXbZwo69(CdQUGaROfy7He9T0foW.KbIzwHEDLa(6166) + text, CdQUGaROfy7He9T0foW.KbIzwHEDLa(2374), cells, loc, Resources.Height);
				num = 9;
				if (UsR1YGsteqFa2bXoXhn())
				{
					break;
				}
				goto case 14;
			case 16:
				return;
			case 27:
				return;
			case 9:
				return;
			case 34:
				if (num2 > 1875177834)
				{
					if (num2 <= 2580216872u)
					{
						num = 32;
						if (true)
						{
							break;
						}
					}
					else
					{
						if (num2 <= 2949417131u)
						{
							num = 11;
							if (UsR1YGsteqFa2bXoXhn())
							{
								break;
							}
							goto case 45;
						}
						if (num2 == 3024705198u)
						{
							if (ANc6MHvJICHNoWBOp0L(relativeCellName, oteC7Wv5uaKQrv1RvHE(5826)))
							{
								SortReference = new ListBoxViewModel(InSight, cells, loc, (string)SE5FmivnVTbWAxARgIK());
								num = 68;
								break;
							}
						}
						else
						{
							if (num2 != 3051080343u)
							{
								num = 38;
								break;
							}
							if (relativeCellName == CdQUGaROfy7He9T0foW.KbIzwHEDLa(5700))
							{
								ProjectionImageResolution = new ListBoxViewModel(InSight, cells, loc, (string)pyOPp7vOln6xNxPAhfR());
								AddProperty(ProjectionImageResolution);
								return;
							}
						}
					}
					goto case 2;
				}
				num = 42;
				break;
			case 31:
				AddProperty(MinimumArea);
				num = 62;
				if (true)
				{
					break;
				}
				goto case 2;
			case 52:
				CJGXbZwo69((string)oteC7Wv5uaKQrv1RvHE(6166) + text, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6358), cells, loc, (string)G2sV3jvoJleo4hIXWCN());
				return;
			case 13:
				CJGXbZwo69(CdQUGaROfy7He9T0foW.KbIzwHEDLa(6166) + text, (string)oteC7Wv5uaKQrv1RvHE(6230), cells, loc, (string)nOT1gZvbVGBdbTltEql());
				num = 26;
				break;
			case 26:
				return;
			case 14:
				if (num2 == 2339848208u)
				{
					if (!ANc6MHvJICHNoWBOp0L(relativeCellName, oteC7Wv5uaKQrv1RvHE(5650)))
					{
						num = 44;
						break;
					}
					ELFunctionCellLocation = loc;
					return;
				}
				num = 61;
				if (UsR1YGsteqFa2bXoXhn())
				{
					break;
				}
				goto case 6;
			case 6:
				num2 = _003CPrivateImplementationDetails_003E.ComputeStringHash(relativeCellName);
				num = 34;
				break;
			case 71:
				return;
				end_IL_05db:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InitializeAdditionalHelp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		AdditionalHelpText = new List<ExtraHelpText>
		{
			new ExtraHelpText((string)IcHZxFvkUhVwxfZSEHY(), DisplayHelpTextType.Header),
			new ExtraHelpText((string)X2CkY0v87ypwhpRHSGr(), DisplayHelpTextType.Paragraph),
			new ExtraHelpText((string)pyOPp7vOln6xNxPAhfR(), DisplayHelpTextType.Header),
			new ExtraHelpText(Resources.U1wmpNypce(), DisplayHelpTextType.Paragraph),
			new ExtraHelpText((string)vdgNqivVYKcLH4FiM8y(), DisplayHelpTextType.Header),
			new ExtraHelpText((string)CH3Jr1vqdjCnEli9YX7(), DisplayHelpTextType.Paragraph),
			new ExtraHelpText((string)TxiokNvEPrNS3wKiaOU(), DisplayHelpTextType.Header),
			new ExtraHelpText((string)GYgP47vpDUksT8eDfqJ(), DisplayHelpTextType.Paragraph),
			new ExtraHelpText(Resources.ATq81AknJg(), DisplayHelpTextType.Header),
			new ExtraHelpText(Resources.EgM88DDb9Q(), DisplayHelpTextType.Paragraph)
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetViewableEditGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsEditableDisplayGraphic[1] { Region?.Graphic }.Where([MethodImpl(MethodImplOptions.NoInlining)] (CvsEditableDisplayGraphic g) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return g != null;
		}).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteFixturedGraphics_003Ed__14))]
	internal override Task WriteFixturedGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CWriteFixturedGraphics_003Ed__14 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				break;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				_ = 1;
				num = ((!lbntiBsz46axVojICgy()) ? 3 : 5);
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
	[AsyncStateMachine(typeof(_003CFocusOnPropertyChanged_003Ed__15))]
	protected override Task FocusOnPropertyChanged(object sender, PropertyChangedEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CFocusOnPropertyChanged_003Ed__15 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 7;
				if (lbntiBsz46axVojICgy())
				{
				}
				continue;
			case 7:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				num = ((!UsR1YGsteqFa2bXoXhn()) ? 6 : 0);
				continue;
			case 5:
				stateMachine._003C_003E1__state = -1;
				num = 1;
				continue;
			case 3:
			case 6:
				stateMachine.e = e;
				goto case 5;
			default:
				num = 5;
				if (lbntiBsz46axVojICgy())
				{
				}
				continue;
			case 0:
			case 2:
				stateMachine.sender = sender;
				goto case 3;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (UsR1YGsteqFa2bXoXhn())
				{
					continue;
				}
				break;
			case 8:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CJGXbZwo69(string P_0, string P_1, CvsCellCollection P_2, CvsCellLocation P_3, string P_4)
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
		goto IL_006b;
		IL_001a:
		FloatViewModel floatViewModel = default;
		AddProperty(floatViewModel);
		num = 7;
		goto IL_006b;
		IL_006b:
		while (true)
		{
			switch (num)
			{
			case 0:
				floatViewModel = new FloatViewModel(InSight, P_2, P_3, P_4);
				num = 1;
				continue;
			case 2:
			case 5:
				ResultViewModels[P_0][P_1] = floatViewModel;
				break;
			case 1:
				if (ResultViewModels[P_0].ContainsKey(P_1))
				{
					_ = 1;
					num = ((!lbntiBsz46axVojICgy()) ? 5 : 4);
				}
				else
				{
					ResultViewModels[P_0].Add(P_1, floatViewModel);
					num = 6;
				}
				continue;
			case 7:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NGWXcRvn4Z()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		List<FloatViewModel> list2 = default;
		int num2 = default;
		List<FloatViewModel> list = default;
		List<FloatViewModel> list3 = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				list2 = ResultViewModels.Values.Select([MethodImpl(MethodImplOptions.NoInlining)] (Dictionary<string, FloatViewModel> dict) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					FloatViewModel value;
					return (!dict.TryGetValue(CdQUGaROfy7He9T0foW.KbIzwHEDLa(2374), out value)) ? null : value;
				}).Where([MethodImpl(MethodImplOptions.NoInlining)] (FloatViewModel val) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return val != null;
				}).ToList();
				num = 11;
				break;
			case 0:
				num2 = 0;
				_ = 1;
				if (!lbntiBsz46axVojICgy())
				{
					num = 8;
					break;
				}
				num = 9;
				if (UsR1YGsteqFa2bXoXhn())
				{
					break;
				}
				goto case 12;
			default:
				if (oa6qcwv91m7fnYTalXY(list[num2]) == -1.0)
				{
					num = 12;
					break;
				}
				goto IL_0210;
			case 4:
				list3 = ResultViewModels.Values.Select([MethodImpl(MethodImplOptions.NoInlining)] (Dictionary<string, FloatViewModel> dict) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					FloatViewModel value;
					return (!dict.TryGetValue(CdQUGaROfy7He9T0foW.KbIzwHEDLa(6200), out value)) ? null : value;
				}).Where([MethodImpl(MethodImplOptions.NoInlining)] (FloatViewModel val) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return val != null;
				}).ToList();
				num = 0;
				if (0 == 0)
				{
					break;
				}
				goto case 3;
			case 3:
				num2++;
				num = 2;
				break;
			case 10:
				Results = WdtXr6BEJO.Take(WdtXr6BEJO.Count);
				num = 13;
				break;
			case 2:
			case 5:
			case 8:
				if (num2 >= x6Byt1v4ISmSA4jj9PR(list2))
				{
					num = 10;
					break;
				}
				if (oa6qcwv91m7fnYTalXY(list2[num2]) == -1.0)
				{
					goto default;
				}
				goto IL_0210;
			case 12:
				if (list3[num2].Value == -1.0)
				{
					goto case 3;
				}
				goto IL_0210;
			case 7:
				KHtDskvXk9t6W2x04ND(WdtXr6BEJO);
				num = 1;
				break;
			case 11:
				list = ResultViewModels.Values.Select([MethodImpl(MethodImplOptions.NoInlining)] (Dictionary<string, FloatViewModel> dict) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					FloatViewModel value;
					return (!dict.TryGetValue(CdQUGaROfy7He9T0foW.KbIzwHEDLa(6230), out value)) ? null : value;
				}).Where([MethodImpl(MethodImplOptions.NoInlining)] (FloatViewModel val) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return val != null;
				}).ToList();
				num = 4;
				break;
			case 13:
				return;
				IL_0210:
				WdtXr6BEJO.Add(new ViDiELSegment3DResultViewModel(num2.ToString(CdQUGaROfy7He9T0foW.KbIzwHEDLa(6470)), list2[num2], list[num2], list3[num2]));
				num = 3;
				if (true)
				{
					break;
				}
				goto case 7;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateOnEditModeChange()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		zTyXQHrflt();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zTyXQHrflt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		lbntiBsz46axVojICgy();
		int num = ((!UsR1YGsteqFa2bXoXhn()) ? 3 : 6);
		while (true)
		{
			switch (num)
			{
			case 4:
				return;
			case 1:
				xY2wJLv3HPcKLoTZZ5L(lfyXLSs72Y, ToolId);
				break;
			default:
				num = 7;
				continue;
			case 2:
			case 3:
				if (Parent.IsEasyBuilderAdvancedMode)
				{
					goto IL_0029;
				}
				num = 1;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 6:
				if (jnEWKWv7fOLPifU5YTR(Focus))
				{
					num = 5;
					continue;
				}
				goto IL_0029;
			case 5:
				if (!IsInSnippetEditMode)
				{
					goto IL_0029;
				}
				goto case 2;
			case 7:
				break;
			case 8:
				return;
				IL_0029:
				MainViewModel = null;
				num = 8;
				if (lbntiBsz46axVojICgy())
				{
				}
				continue;
			}
			MainViewModel = this;
			num = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCheckHasSamplesAsync_003Ed__37))]
	private Task cjmXgpZLD6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CCheckHasSamplesAsync_003Ed__37 stateMachine = default;
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
				break;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 5:
				do
				{
					stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
					_ = 0;
					if (!UsR1YGsteqFa2bXoXhn())
					{
						num = 4;
						continue;
					}
					num = 0;
					break;
				}
				while (!UsR1YGsteqFa2bXoXhn());
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
	private void OM2XM4fZHL(StateChangedArgs P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0050;
		IL_001a:
		if ((States)c3GktjvAXbD4FjFuEFN(TsCnxSv6jepr6DZcXDN(typeof(States).TypeHandle), AZFBOOvCfsTcx72kqlb(P_0).ToString()) == States.None)
		{
			goto IL_00ab;
		}
		return;
		IL_0050:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 5:
				goto IL_008b;
			default:
				goto IL_00ab;
			case 1:
			case 2:
				if (ANc6MHvJICHNoWBOp0L(e4BiuOvjLotYkrwULfP(P_0), ToolId))
				{
					num = 4;
					continue;
				}
				return;
			case 6:
				return;
			}
			break;
			IL_008b:
			if (P_0 == null)
			{
				return;
			}
			UsR1YGsteqFa2bXoXhn();
			if (lbntiBsz46axVojICgy())
			{
				num = 0;
				if (lbntiBsz46axVojICgy())
				{
				}
			}
			else
			{
				num = 2;
			}
		}
		goto IL_001a;
		IL_00ab:
		BADUVlvR3XoeGPqpN1C(n0kK85vKZMQxeqoMfyS(), ToolId, NavigationAction.StartEvaluation, null);
		num = 6;
		goto IL_0050;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mUmXRuK3i0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (true)
		{
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					break;
				default:
					return;
				case 0:
				{
					if (HasSamples)
					{
						_ = 1;
						num = ((!lbntiBsz46axVojICgy()) ? 3 : 4);
						continue;
					}
					object obj = mVyDj3vTnKADS9lgTFF(Region);
					setOWkvWNaNyNntySyy(obj, HBVxRMvybTIdPS8PiPA(obj) | CvsEditFlags.Size);
					num = 5;
					if (lbntiBsz46axVojICgy())
					{
						return;
					}
					continue;
				}
				case 4:
					return;
				case 5:
					return;
				}
				break;
			}
		}
		CvsEditableDisplayGraphic graphic = Region.Graphic;
		setOWkvWNaNyNntySyy(graphic, graphic.EditFlags & ~CvsEditFlags.Size);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private ValueTask y7aX4dvauD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.DisposeAsync();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task IAHXlM7pdE(CvsCellCollection P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.InternalPostParse(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task bdOXTfmEqw(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.FocusOnPropertyChanged(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lJsaMovLdU2K2CJRObn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object n0kK85vKZMQxeqoMfyS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SegmenterClient.State;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oteC7Wv5uaKQrv1RvHE(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UsR1YGsteqFa2bXoXhn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lbntiBsz46axVojICgy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder qdd5W3vw4TGQNb7VQXZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ANc6MHvJICHNoWBOp0L(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Gn39AwvalrbTrvSv8v8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Region;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation pHBN7Fvev6PuQKaWFbF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pyOPp7vOln6xNxPAhfR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.ProjectionImageResolution;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DuBA1nvI78XymIhtIO4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.SortKey;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GL8iSNvDOSy9P5njdpw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.SortOrder_;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BLngZuvij2KvgBV7ulL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.SortTolerance;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SE5FmivnVTbWAxARgIK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.SortReference;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vdgNqivVYKcLH4FiM8y()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.ConfidenceThreshold;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HakRoovfSPFdyKMBlYG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.MinimumVolume;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fuCbvkvdcxY8wXl1CS1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.MaximumVolume;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WYhJCxvlINmQt9beIFQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.MaximumArea;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object d92YMevgThw0rTi8MWB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.MaximumHeight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rno4govsZ3CJauAhS6Q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.MinimumHeight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OB4osovvWKO6aUrvRtY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.TYN9FrMZZ1();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object r7yitKvrAxMMsyqSP2a(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OnQpblvPsodEIBP7Y08(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fv4HL0vZoGLAYf3bbLu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Volume;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool L53KRxvBQT40xv2OSqW(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).EndsWith((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nOT1gZvbVGBdbTltEql()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Area;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PUPLwFvG10RYfmtKprw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object G2sV3jvoJleo4hIXWCN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int RewYn6vSx04k39xR9pc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Dictionary<string, Dictionary<string, FloatViewModel>>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IcHZxFvkUhVwxfZSEHY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.AwSJJVbrtl();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object X2CkY0v87ypwhpRHSGr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.fEnm7JA6tj();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CH3Jr1vqdjCnEli9YX7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.TTx8rgGDW0();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TxiokNvEPrNS3wKiaOU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.RrKLY8D4hQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GYgP47vpDUksT8eDfqJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.KN5ma6OYLn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KHtDskvXk9t6W2x04ND(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((List<ViDiELSegment3DResultViewModel>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double oa6qcwv91m7fnYTalXY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FloatViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int x6Byt1v4ISmSA4jj9PR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<FloatViewModel>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jnEWKWv7fOLPifU5YTR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((InternalCheckBoxViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xY2wJLv3HPcKLoTZZ5L(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SegmentAdapterBase)P_0).OnNewResult((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object e4BiuOvjLotYkrwULfP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StateChangedArgs)P_0).ToolId;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type TsCnxSv6jepr6DZcXDN(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AZFBOOvCfsTcx72kqlb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StateChangedArgs)P_0).State;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object c3GktjvAXbD4FjFuEFN(Type P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Enum.Parse(P_0, (string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BADUVlvR3XoeGPqpN1C(object P_0, object P_1, NavigationAction P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((State)P_0).ExecuteNavigationAction((string)P_1, P_2, (string)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void setOWkvWNaNyNntySyy(object P_0, CvsEditFlags P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsEditableDisplayGraphic)P_0).EditFlags = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mVyDj3vTnKADS9lgTFF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EditableGraphicsViewModel)P_0).Graphic;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsEditFlags HBVxRMvybTIdPS8PiPA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).EditFlags;
	}
}
