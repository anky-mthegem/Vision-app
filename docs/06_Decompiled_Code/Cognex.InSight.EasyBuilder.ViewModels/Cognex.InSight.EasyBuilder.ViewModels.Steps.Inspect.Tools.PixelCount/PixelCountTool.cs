using System;
using System.Collections;
using System.Collections.Generic;
using System.Composition;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime;
using Cognex.InSight.Undo;
using DUIE9v8SVGR17TWQwQ;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.PixelCount;

[Export(typeof(PixelCountTool))]
public class PixelCountTool : EzRangeTool<EditIntViewModel>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInternalPostParse_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PixelCountTool _003C_003E4__this;

		public CvsCellCollection cells;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (oiCrDjKj8nTVr1Gym7H5())
			{
				goto IL_001e;
			}
			goto IL_01cc;
			IL_001e:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01cc;
			IL_01cc:
			int num2 = default;
			PixelCountTool pixelCountTool = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					_ = 0;
					if (tjOXeWKjkWUF2WL3EUD6())
					{
						num = 4;
						continue;
					}
					num = 0;
					if (oiCrDjKj8nTVr1Gym7H5())
					{
					}
					continue;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							pixelCountTool.o6IE0Qbd6n();
							num3 = 7;
							if (!tjOXeWKjkWUF2WL3EUD6())
							{
								goto IL_006c;
							}
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
							case 2:
							case 4:
								break;
							case 5:
								return;
							case 3:
								return;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (oiCrDjKj8nTVr1Gym7H5())
								{
								}
								continue;
							case 0:
								_003C_003Eu__1 = default;
								num3 = 1;
								if (tjOXeWKjkWUF2WL3EUD6())
								{
									continue;
								}
								goto case 7;
							case 7:
								awaiter = PPZ2CjKjqXZvGbW1rLa9(pixelCountTool.WKREVuo1Dg(cells));
								num3 = 8;
								continue;
							case 9:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								if (0 == 0)
								{
									continue;
								}
								goto case 6;
							case 6:
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								_ = 0;
								if (!tjOXeWKjkWUF2WL3EUD6())
								{
									num3 = 3;
									if (oiCrDjKj8nTVr1Gym7H5())
									{
									}
								}
								else
								{
									num3 = 2;
								}
								continue;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									if (0 == 0)
									{
										continue;
									}
								}
								goto case 10;
							case 10:
								awaiter.GetResult();
								goto end_IL_012d;
							}
							goto IL_006c;
							continue;
							end_IL_012d:
							break;
						}
						goto end_IL_0050;
						IL_006c:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_0050:;
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
					pixelCountTool = _003C_003E4__this;
					num = 2;
					continue;
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
		internal static TaskAwaiter PPZ2CjKjqXZvGbW1rLa9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tjOXeWKjkWUF2WL3EUD6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oiCrDjKj8nTVr1Gym7H5()
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
	private struct _003CShiftEditGraphics_003Ed__51 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PixelCountTool _003C_003E4__this;

		public int delta;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			int num2 = default;
			PixelCountTool pixelCountTool = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = pixelCountTool.Region.Shift(delta).GetAwaiter();
							num3 = 7;
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
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 7:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
								_003C_003Eu__1 = default;
								num3 = 1;
								continue;
							case 3:
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								return;
							case 2:
								return;
							case 8:
								_003C_003Eu__1 = awaiter;
								VvaQ7hKjEWUIRyuuaGmx();
								if (LuE9RFKjpThasMBElstI())
								{
									num3 = 2;
									continue;
								}
								num3 = 5;
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
						awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 0;
				default:
					num = 0;
					break;
				case 3:
					num2 = _003C_003E1__state;
					_ = 0;
					if (VvaQ7hKjEWUIRyuuaGmx())
					{
						num = 4;
						break;
					}
					num = 5;
					if (true)
					{
						break;
					}
					return;
				case 1:
				case 4:
					pixelCountTool = _003C_003E4__this;
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
		internal static bool VvaQ7hKjEWUIRyuuaGmx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LuE9RFKjpThasMBElstI()
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
	private struct _003COnSetRange_003Ed__53 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PixelCountTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

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
			goto IL_021a;
			IL_001a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_021a;
			IL_021a:
			int num2 = default;
			(double, double) minMax = default;
			PixelCountTool pixelCountTool = default;
			TaskAwaiter awaiter = default;
			UndoSetRange<double> undoSetRange = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					num = 0;
					continue;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							minMax = GetMinMax(pixelCountTool.PixelCount.Value);
							num3 = 4;
							goto IL_0103;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00a9;
						IL_00a9:
						_003C_003Eu__1 = default;
						num3 = 1;
						if (1 == 0)
						{
							goto IL_00c1;
						}
						goto IL_0103;
						IL_00c1:
						awaiter = IGKbFwKj3wwlda7tENSk(PY9YDFKj7NsdWI4xFrq6(pixelCountTool.InSight.UndoHandler, undoSetRange));
						num3 = 5;
						goto IL_0103;
						IL_0103:
						while (true)
						{
							switch (num3)
							{
							case 2:
							case 3:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								num3 = 9;
								if (jAGn9gKjXZdQqhUaePlA())
								{
									continue;
								}
								goto case 5;
							case 5:
								if (!awaiter.IsCompleted)
								{
									goto IL_008f;
								}
								goto case 7;
							case 6:
							case 10:
								break;
							case 8:
								goto IL_00c1;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 0;
								continue;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 7;
								continue;
							case 0:
								return;
							case 4:
								undoSetRange = new UndoSetRange<double>(pixelCountTool.Parent, (string)tyDXEGKj4JkuDuAJDYl3(pixelCountTool), pixelCountTool.Min.CellName, pixelCountTool.Max.CellName, pixelCountTool.Min.Value, pixelCountTool.Max.Value, minMax.Item1, minMax.Item2);
								num3 = 8;
								continue;
							case 7:
								awaiter.GetResult();
								num3 = 11;
								continue;
							case 11:
								pixelCountTool.o6IE0Qbd6n();
								goto end_IL_0040;
							}
							break;
							IL_008f:
							jAGn9gKjXZdQqhUaePlA();
							num3 = (oya2EeKj9ZvgrKL5beS4() ? 10 : 2);
						}
						goto IL_00a9;
						end_IL_0040:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 0:
					pixelCountTool = _003C_003E4__this;
					jAGn9gKjXZdQqhUaePlA();
					if (oya2EeKj9ZvgrKL5beS4())
					{
						num = 1;
						if (oya2EeKj9ZvgrKL5beS4())
						{
						}
					}
					else
					{
						num = 5;
					}
					continue;
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
		internal static object tyDXEGKj4JkuDuAJDYl3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PY9YDFKj7NsdWI4xFrq6(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter IGKbFwKj3wwlda7tENSk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jAGn9gKjXZdQqhUaePlA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oya2EeKj9ZvgrKL5beS4()
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
	private struct _003CWriteFixturedGraphics_003Ed__55 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PixelCountTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			PixelCountTool pixelCountTool = default;
			int num2 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter = default;
			TaskAwaiter awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					pixelCountTool = _003C_003E4__this;
					num = 4;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
					num2 = _003C_003E1__state;
					_ = 0;
					if (dAfddYKjjnJAEulriO2T())
					{
						num = 0;
						if (!A13IWyKj6PBYpX1JW6IT())
						{
							break;
						}
						goto case 4;
					}
					num = 5;
					if (A13IWyKj6PBYpX1JW6IT())
					{
						return;
					}
					break;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 2;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 5;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 14;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
								awaiter2.GetResult();
								dAfddYKjjnJAEulriO2T();
								num3 = (A13IWyKj6PBYpX1JW6IT() ? 11 : 4);
								continue;
							case 5:
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 13:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 1;
									continue;
								}
								break;
							case 4:
							case 8:
								awaiter = ((CvsCogSocketSheet)dassl0KjT6UPT6HMV9e6(kDc8HOKjWriQoocxfcUy(pixelCountTool.InSight))).RunAsync(false).GetAwaiter();
								num3 = 13;
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								goto case 0;
							default:
								num3 = 0;
								if (dAfddYKjjnJAEulriO2T())
								{
									continue;
								}
								goto case 7;
							case 7:
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 15;
								if (A13IWyKj6PBYpX1JW6IT())
								{
								}
								continue;
							case 9:
								num2 = (_003C_003E1__state = 0);
								num3 = 7;
								continue;
							case 11:
								return;
							case 12:
								return;
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 3:
								if (!awaiter2.IsCompleted)
								{
									num3 = 9;
									continue;
								}
								goto case 0;
							case 14:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 15:
								return;
							case 2:
								awaiter2 = ((Task)vhn9WBKjR8Eg2VdiDlfk(pixelCountTool.InSight, UnLRaGKjCSqWMtS6k7JI(pixelCountTool.Region), uqWjXwKjAlTh88oYQnfp(pixelCountTool.Region))).GetAwaiter();
								num3 = 3;
								continue;
							case 1:
								_003C_003Eu__2 = awaiter;
								num3 = 10;
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
		internal static CvsCellLocation UnLRaGKjCSqWMtS6k7JI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object uqWjXwKjAlTh88oYQnfp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EditableGraphicsViewModel)P_0).Graphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vhn9WBKjR8Eg2VdiDlfk(object P_0, CvsCellLocation loc, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kDc8HOKjWriQoocxfcUy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dassl0KjT6UPT6HMV9e6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dAfddYKjjnJAEulriO2T()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A13IWyKj6PBYpX1JW6IT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private int vUGEmnTaJC;

	[CompilerGenerated]
	private CheckBoxViewModel GpHE1fibUD;

	[CompilerGenerated]
	private EditIntViewModel shoEzLOdUE;

	[CompilerGenerated]
	private EditIntViewModel ORDba130Ft;

	[CompilerGenerated]
	private CheckBoxViewModel g68b5E5ZCc;

	[CompilerGenerated]
	private IntViewModel FeRbp9sU8P;

	[CompilerGenerated]
	private EditCompositeRegionViewModel bCsbU5MI39;

	[CompilerGenerated]
	private CheckBoxViewModel LMGb7ED1TF;

	[CompilerGenerated]
	private IntViewModel rIIbNYRanV;

	[CompilerGenerated]
	private IntViewModel O15bAGgWed;

	public CheckBoxViewModel AutoThreshold
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GpHE1fibUD;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			GpHE1fibUD = value;
		}
	}

	public EditIntViewModel MinThreshold
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return shoEzLOdUE;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			shoEzLOdUE = value;
		}
	}

	public EditIntViewModel MaxThreshold
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ORDba130Ft;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ORDba130Ft = value;
		}
	}

	public CheckBoxViewModel InvertPixels
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return g68b5E5ZCc;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			g68b5E5ZCc = value;
		}
	}

	public IntViewModel PixelCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FeRbp9sU8P;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			FeRbp9sU8P = value;
		}
	}

	public EditCompositeRegionViewModel Region
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bCsbU5MI39;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bCsbU5MI39 = value;
		}
	}

	public CheckBoxViewModel Invert
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LMGb7ED1TF;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			LMGb7ED1TF = value;
		}
	}

	public IntViewModel MaximumMax
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rIIbNYRanV;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rIIbNYRanV = value;
		}
	}

	public IntViewModel RegionArea
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return O15bAGgWed;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			O15bAGgWed = value;
		}
	}

	public override string ResultString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return o6k0MRkRKS8wJXCJome(PixelCount).ToString();
		}
	}

	public override CellViewModel ResultCell
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PixelCount;
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
			return XAMLGraphicKeys.Tools_PixelCountIcon;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PixelCountTool(InspectStepViewModel inspect, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		yomuu7kgetqDG98hCx1();
		Qnkb25ksGJ8dtwexRuc(this, inspect, isInitialized);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInternalPostParse_003Ed__5))]
	protected override Task InternalPostParse(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CInternalPostParse_003Ed__5 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
				stateMachine.cells = cells;
				goto case 0;
			default:
				num = 0;
				if (o9cNLtkl4dfs3DXDyGn())
				{
				}
				continue;
			case 0:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				continue;
			case 4:
				stateMachine._003C_003Et__builder = jXlJ6kkvWyQJ4bcl6A5();
				_ = 1;
				num = (o9cNLtkl4dfs3DXDyGn() ? 3 : 5);
				continue;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (true)
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
	protected override void InternalParseCell(string relativeCellName, CvsCellCollection cells, CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 18;
		if (!o9cNLtkl4dfs3DXDyGn())
		{
		}
		uint num2 = default;
		while (true)
		{
			switch (num)
			{
			case 17:
				switch (num2)
				{
				default:
					num = 33;
					break;
				case 1227782301u:
					if (!umvCuJkZLlhcFFjK2jg(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(5684)))
					{
						return;
					}
					Region = new EditCompositeRegionViewModel(InSight, cells, loc, Resources.l1fZTglVqg(), FqeSqwk9q57W2pbsxOK(InputImage), IsInitialized);
					num = 22;
					break;
				case 1017635769u:
					if (umvCuJkZLlhcFFjK2jg(relativeCellName, MMfULMkPYhPVgugdq5V(6138)))
					{
						Max = new EditIntViewModel(InSight, cells, loc, (string)HYd1thkERVEbn5rSY6h());
						AddProperty(Max);
						num = 34;
						break;
					}
					return;
				}
				break;
			case 5:
				return;
			case 18:
				num2 = p2p5c0krYYeC7VDU8rF(relativeCellName);
				num = 8;
				break;
			case 24:
				return;
			case 11:
			case 25:
				if (num2 != 3837039342u)
				{
					num = 20;
					if (0 == 0)
					{
						break;
					}
					goto case 22;
				}
				if (!(relativeCellName == (string)MMfULMkPYhPVgugdq5V(2706)))
				{
					num = 38;
					if (!o9cNLtkl4dfs3DXDyGn())
					{
						break;
					}
					goto case 20;
				}
				PixelCount = new IntViewModel(InSight, cells, loc, (string)mmHwoGkBKn9s7N7GRJ0());
				num = 29;
				break;
			case 22:
				AddProperty(Region);
				return;
			case 4:
				return;
			case 13:
				AddProperty(RegionArea);
				num = 39;
				if (WihqSIkd9RgyO0cilDk())
				{
					break;
				}
				goto case 8;
			case 8:
				if (num2 > 3200242309u)
				{
					if (num2 <= 3530530300u)
					{
						num = 30;
						break;
					}
					if (num2 == 3773669276u)
					{
						if (!umvCuJkZLlhcFFjK2jg(relativeCellName, MMfULMkPYhPVgugdq5V(19548)))
						{
							num = 0;
							break;
						}
						IntViewModel intViewModel = new IntViewModel(InSight, cells, loc, (string)VhTL2wk4MbRernQcBP7());
						whLeAuk8Q0TyfOJPfsd(intViewModel, true);
						RegionArea = intViewModel;
						num = 13;
						break;
					}
					goto case 11;
				}
				num = 32;
				break;
			case 6:
				AddProperty(Min);
				return;
			case 15:
				return;
			case 34:
				return;
			case 38:
				return;
			case 29:
				AddProperty(PixelCount);
				num = 14;
				break;
			case 28:
				return;
			default:
				num = 5;
				break;
			case 9:
				AddProperty(AutoThreshold);
				num = 4;
				break;
			case 30:
				switch (num2)
				{
				default:
					num = 7;
					break;
				case 3399683672u:
					if (!(relativeCellName == (string)MMfULMkPYhPVgugdq5V(19452)))
					{
						num = 3;
						if (1 == 0)
						{
							return;
						}
						break;
					}
					InvertPixels = new CheckBoxViewModel(InSight, cells, loc, (string)LwfWKjkSq3mR1oAxmvb(), IsInitialized);
					num = 12;
					if (o9cNLtkl4dfs3DXDyGn())
					{
					}
					break;
				case 3279533666u:
					if (umvCuJkZLlhcFFjK2jg(relativeCellName, MMfULMkPYhPVgugdq5V(19396)))
					{
						MinThreshold = new EditIntViewModel(InSight, cells, loc, (string)ItBr0WkGVcmVrA3K3Il());
						AddProperty(MinThreshold);
					}
					return;
				}
				break;
			case 37:
				return;
			case 3:
				return;
			case 2:
				AddProperty(MaxThreshold);
				num = 16;
				if (0 == 0)
				{
					break;
				}
				goto case 35;
			case 35:
				switch (num2)
				{
				case 3007377802u:
					if (!(relativeCellName == (string)MMfULMkPYhPVgugdq5V(19504)))
					{
						return;
					}
					InputCompositeRegion = new InputCompositeRegionViewModel(this, cells, loc, (string)LX1YJjkpMgdoG4hveVZ(), (string)AjaKPgkXG1HJcdCmnqJ(), Region, IsInitialized);
					num = 31;
					break;
				case 3200242309u:
				{
					if (!umvCuJkZLlhcFFjK2jg(relativeCellName, MMfULMkPYhPVgugdq5V(19480)))
					{
						return;
					}
					IntViewModel intViewModel2 = new IntViewModel(InSight, cells, loc, (string)jpFPAQkkTrWJSSjRS9o());
					whLeAuk8Q0TyfOJPfsd(intViewModel2, true);
					MaximumMax = intViewModel2;
					AddProperty(MaximumMax);
					num = 26;
					break;
				}
				default:
					num = 24;
					break;
				}
				break;
			case 32:
				if (num2 <= 1227782301)
				{
					num = 19;
					if (WihqSIkd9RgyO0cilDk())
					{
						break;
					}
					goto case 7;
				}
				if (num2 == 2046460609)
				{
					if (umvCuJkZLlhcFFjK2jg(relativeCellName, MMfULMkPYhPVgugdq5V(6122)))
					{
						Invert = new CheckBoxViewModel(InSight, cells, loc, Resources.Invert, IsInitialized);
						AddProperty(Invert);
						num = 15;
						break;
					}
					num = 28;
					if (!o9cNLtkl4dfs3DXDyGn())
					{
						break;
					}
					goto case 2;
				}
				num = 35;
				break;
			case 7:
				if (num2 != 3530530300u)
				{
					_ = 1;
					if (!o9cNLtkl4dfs3DXDyGn())
					{
						num = 36;
						break;
					}
					num = 25;
					if (1 == 0)
					{
						return;
					}
				}
				else if (umvCuJkZLlhcFFjK2jg(relativeCellName, MMfULMkPYhPVgugdq5V(19424)))
				{
					MaxThreshold = new EditIntViewModel(InSight, cells, loc, (string)ynN5bEkoFj3OsBTpPxi());
					num = 2;
				}
				else
				{
					num = 37;
				}
				break;
			case 31:
				AddProperty(InputCompositeRegion);
				num = 23;
				break;
			case 12:
				AddProperty(InvertPixels);
				num = 27;
				break;
			case 14:
				return;
			case 21:
				return;
			case 20:
				if (num2 == 4249096401u)
				{
					if (!umvCuJkZLlhcFFjK2jg(relativeCellName, MMfULMkPYhPVgugdq5V(19366)))
					{
						num = 1;
						if (true)
						{
							break;
						}
						goto case 29;
					}
					AutoThreshold = new CheckBoxViewModel(InSight, cells, loc, (string)RCbGHkkbf58O4tfqPMS(), IsInitialized);
					num = 9;
					if (o9cNLtkl4dfs3DXDyGn())
					{
					}
					break;
				}
				num = 21;
				break;
			case 1:
				return;
			case 23:
				return;
			case 33:
				return;
			case 0:
				return;
			case 19:
				if (num2 == 781469175)
				{
					if (!umvCuJkZLlhcFFjK2jg(relativeCellName, MMfULMkPYhPVgugdq5V(6148)))
					{
						return;
					}
					Min = new EditIntViewModel(InSight, cells, loc, (string)wteG7BkqWp96vLbKDms());
					num = 6;
				}
				else
				{
					num = 17;
				}
				break;
			case 10:
			case 36:
				return;
			case 16:
				return;
			case 26:
				return;
			case 27:
				return;
			case 39:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void RefreshGraphics(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		using IEnumerator<CellViewModel> enumerator = AllProperties.GetEnumerator();
		int num2 = default;
		EditCompositeRegionViewModel editCompositeRegionViewModel = default;
		edFbVBhD6RDc8FLg4U edFbVBhD6RDc8FLg4U2 = default;
		while (mqh5lEkCt66gBLEUrOj(enumerator))
		{
			CellViewModel current = enumerator.Current;
			int num = 6;
			while (true)
			{
				switch (num)
				{
				case 4:
					vUGEmnTaJC = num2;
					num = 1;
					continue;
				case 9:
					if (editCompositeRegionViewModel.CellName != null && o0wnp2k3jsExPSBu2Jq(vsIrHFk7iIoH7xUTpDv(editCompositeRegionViewModel), MMfULMkPYhPVgugdq5V(19572), StringComparison.Ordinal))
					{
						goto case 3;
					}
					goto IL_0170;
				default:
					num = 3;
					continue;
				case 11:
					if (editCompositeRegionViewModel != null)
					{
						num = 9;
						continue;
					}
					goto IL_0170;
				case 8:
					num2 = RegionArea?.Value ?? 0;
					if (num2 == vUGEmnTaJC)
					{
						break;
					}
					goto case 5;
				case 6:
					edFbVBhD6RDc8FLg4U2 = current as edFbVBhD6RDc8FLg4U;
					num = 10;
					if (true)
					{
						continue;
					}
					goto case 5;
				case 5:
				case 7:
					o6IE0Qbd6n();
					num = 4;
					if (!o9cNLtkl4dfs3DXDyGn())
					{
						continue;
					}
					goto case 3;
				case 3:
					B7sDPlk6xuuR1tIeXeO(edFbVBhD6RDc8FLg4U2, cells, XXcFyDkj7nAivZErAvQ(Pass), InputImage.CellLocation);
					num = 8;
					continue;
				case 0:
				case 2:
					editCompositeRegionViewModel = current as EditCompositeRegionViewModel;
					num = 11;
					if (WihqSIkd9RgyO0cilDk())
					{
						continue;
					}
					break;
				case 10:
					if (edFbVBhD6RDc8FLg4U2 != null)
					{
						WihqSIkd9RgyO0cilDk();
						if (o9cNLtkl4dfs3DXDyGn())
						{
							num = 5;
							continue;
						}
						num = 0;
						if (0 == 0)
						{
							continue;
						}
					}
					break;
				case 1:
				case 12:
					break;
					IL_0170:
					B7sDPlk6xuuR1tIeXeO(edFbVBhD6RDc8FLg4U2, cells, Pass.Value, InputImage.CellLocation);
					num = 12;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void o6IE0Qbd6n()
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
			default:
				Max.SetMaxExternally(o6k0MRkRKS8wJXCJome(MaximumMax));
				num = 5;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
			case 3:
				if (ovQGVhkAB0hc5Yvd2uX(RuntimeModeService))
				{
					goto default;
				}
				return;
			case 0:
				if (MaximumMax == null)
				{
					return;
				}
				_ = 1;
				if (o9cNLtkl4dfs3DXDyGn())
				{
					num = 4;
					break;
				}
				num = 3;
				if (!WihqSIkd9RgyO0cilDk())
				{
					return;
				}
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CShiftEditGraphics_003Ed__51))]
	public override Task ShiftEditGraphics(int delta)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (o9cNLtkl4dfs3DXDyGn() ? 4 : 6);
		_003CShiftEditGraphics_003Ed__51 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
			case 6:
				stateMachine._003C_003Et__builder = jXlJ6kkvWyQJ4bcl6A5();
				num = 1;
				break;
			case 3:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 2:
			case 4:
				stateMachine.delta = delta;
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
	public override CvsEditableDisplayGraphic[] GetViewableEditGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		List<CvsEditableDisplayGraphic> list = default;
		CvsEditableDisplayGraphic graphic = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				list.Add(graphic);
				num = 6;
				continue;
			case 2:
			case 3:
				if (graphic == null)
				{
					break;
				}
				goto case 4;
			default:
				num = 4;
				continue;
			case 1:
			case 5:
				graphic = Region.Graphic;
				goto case 2;
			case 0:
				list = new List<CvsEditableDisplayGraphic>();
				o9cNLtkl4dfs3DXDyGn();
				num = (WihqSIkd9RgyO0cilDk() ? 5 : 3);
				continue;
			case 6:
				break;
			}
			break;
		}
		return (CvsEditableDisplayGraphic[])a2wqCikWnETO2PxL8ZJ(list);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnSetRange_003Ed__53))]
	internal override Task OnSetRange()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!WihqSIkd9RgyO0cilDk()) ? 3 : 5);
		_003COnSetRange_003Ed__53 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			default:
				num = 2;
				break;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = jXlJ6kkvWyQJ4bcl6A5();
				goto case 1;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static (double min, double max) GetMinMax(double value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EzRangeTool<EditIntViewModel>.GetMinMax(value, 0.1, 0.0, 999999999.0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteFixturedGraphics_003Ed__55))]
	internal override Task WriteFixturedGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!o9cNLtkl4dfs3DXDyGn())
		{
			num = 5;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 2;
			if (false)
			{
				goto IL_0073;
			}
		}
		goto IL_0040;
		IL_0026:
		_003CWriteFixturedGraphics_003Ed__55 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		goto IL_008f;
		IL_0073:
		stateMachine._003C_003E4__this = this;
		num = 1;
		if (o9cNLtkl4dfs3DXDyGn())
		{
		}
		goto IL_0040;
		IL_008f:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (WihqSIkd9RgyO0cilDk())
		{
			goto IL_0040;
		}
		goto IL_00ad;
		IL_0040:
		switch (num)
		{
		case 1:
			break;
		case 4:
			goto IL_0073;
		default:
			goto IL_008f;
		case 0:
		case 5:
			goto IL_00ad;
		case 6:
			return stateMachine._003C_003Et__builder.Task;
		}
		goto IL_0026;
		IL_00ad:
		stateMachine._003C_003Et__builder = jXlJ6kkvWyQJ4bcl6A5();
		num = 4;
		goto IL_0040;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task WKREVuo1Dg(CvsCellCollection P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.InternalPostParse(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yomuu7kgetqDG98hCx1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Qnkb25ksGJ8dtwexRuc(object P_0, object P_1, bool P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzRangeTool<EditIntViewModel>)P_0)._002Ector((InspectStepViewModel)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WihqSIkd9RgyO0cilDk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool o9cNLtkl4dfs3DXDyGn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder jXlJ6kkvWyQJ4bcl6A5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint p2p5c0krYYeC7VDU8rF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MMfULMkPYhPVgugdq5V(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool umvCuJkZLlhcFFjK2jg(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mmHwoGkBKn9s7N7GRJ0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.PixelCount;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RCbGHkkbf58O4tfqPMS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.AutoThreshold;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ItBr0WkGVcmVrA3K3Il()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.MinThreshold;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ynN5bEkoFj3OsBTpPxi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.MaxThreshold;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LwfWKjkSq3mR1oAxmvb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.InvertPixels;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jpFPAQkkTrWJSSjRS9o()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.MaximumMax;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void whLeAuk8Q0TyfOJPfsd(object P_0, bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CellViewModel)P_0).Internal = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wteG7BkqWp96vLbKDms()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.MjMVZlHh3y();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HYd1thkERVEbn5rSY6h()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CsBVSmiZVr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LX1YJjkpMgdoG4hveVZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.InputCompositeRegion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AjaKPgkXG1HJcdCmnqJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.tY8Y4bDug1();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation FqeSqwk9q57W2pbsxOK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VhTL2wk4MbRernQcBP7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.RegionArea;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vsIrHFk7iIoH7xUTpDv(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool o0wnp2k3jsExPSBu2Jq(object P_0, object P_1, StringComparison P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).EndsWith((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XXcFyDkj7nAivZErAvQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BoolViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void B7sDPlk6xuuR1tIeXeO(object P_0, object P_1, bool P_2, CvsCellLocation P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((edFbVBhD6RDc8FLg4U)P_0).RefreshGraphic((CvsCellCollection)P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mqh5lEkCt66gBLEUrOj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ovQGVhkAB0hc5Yvd2uX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IRuntimeModeService)P_0).IsOperatorOfflineAndNotInLiveMode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int o6k0MRkRKS8wJXCJome(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IntViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object a2wqCikWnETO2PxL8ZJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
	}
}
