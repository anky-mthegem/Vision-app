using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Composition;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Cnx.Diagnostics;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.Graphic;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.Utilities.Controls.ViewModels.Extensions;
using d6U6rfDQgjJaEyFRUK;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Plane3D;

[Export(typeof(EzToolType))]
public class Plane3DToolType : EzToolType
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public Plane3DToolType _003C_003E4__this;

		public CvsCellRange pasteRange;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass30_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			vEVXIKK3QKEF7VGxZxwn();
			FqGWkqK3NqK2dVI6VbOf(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task _003CAddTool_003Eb__0(CvsDisplayableComposite region, CvsCellLocation offset)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Task)GqAo6EK3cl2mo38DRBCI(((AppStepViewModel)Dq5s6bK32kkxWMrOETW7(_003C_003E4__this)).InSight, _003C_003E4__this.GetCellLocation(pasteRange.Location, offset), region);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vEVXIKK3QKEF7VGxZxwn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void FqGWkqK3NqK2dVI6VbOf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NK5PGiK3xxnNUmEsP3mM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lv8tBaK3mN5xovmr5obe()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Dq5s6bK32kkxWMrOETW7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GqAo6EK3cl2mo38DRBCI(object P_0, CvsCellLocation loc, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddTool_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public Plane3DToolType _003C_003E4__this;

		private _003C_003Ec__DisplayClass30_0 _003C_003E8__1;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private object _003C_003E7__wrap2;

		private Plane3DTool _003CnewTool_003E5__4;

		private TaskAwaiter<CvsCellRange> _003C_003Eu__1;

		private TaskAwaiter<object> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__4;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__5;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			TaskAwaiter awaiter = default;
			Plane3DToolType plane3DToolType = default;
			PasteBuffer pasteObject = default;
			TaskAwaiter<CvsCellCollection> awaiter5 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter4 = default;
			TaskAwaiter<CvsCellRange> awaiter3 = default;
			TaskAwaiter<object> awaiter2 = default;
			string text = default;
			CvsCellLocation cellLocation = default;
			CvsCellCollection result3 = default;
			CvsCellRange result2 = default;
			EzTool result = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					try
					{
						int num3;
						if ((uint)num2 > 6u)
						{
							if (num2 == 7)
							{
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0898;
							}
							_003C_003E8__1 = new _003C_003Ec__DisplayClass30_0();
							_003C_003E8__1._003C_003E4__this = _003C_003E4__this;
							_003Csheet_003E5__2 = (CvsCogSocketSheet)bPMWB0K3z3dxVE8wrQrT(((CvsInSight)leqQ0DK3tOV9yqfACata(jf05SWK3hUgPugMaIZ24(plane3DToolType))).CogSocket);
							_003C_003E8__1.pasteRange = CvsCellRange.Empty;
							num3 = 0;
						}
						try
						{
							int num4;
							switch (num2)
							{
							default:
							{
								pasteObject = EzToolType.UpdateNamesInPasteBuffer(plane3DToolType._pasteObject, (InspectStepViewModel)jf05SWK3hUgPugMaIZ24(plane3DToolType), out var _);
								num4 = 28;
								if (ECMHikK3ucHtvVE1RXIk())
								{
									goto IL_00b7;
								}
								goto IL_00e6;
							}
							case 6:
								awaiter = _003C_003Eu__3;
								num4 = 22;
								goto IL_00e6;
							case 5:
								awaiter5 = _003C_003Eu__5;
								num4 = 49;
								if (0 == 0)
								{
									goto IL_00e6;
								}
								goto IL_02d9;
							case 3:
								awaiter4 = _003C_003Eu__4;
								num4 = 44;
								if (!hstF1lK310oxEwAis544())
								{
									break;
								}
								goto IL_00e6;
							case 4:
								awaiter = _003C_003Eu__3;
								num4 = 18;
								if (hstF1lK310oxEwAis544())
								{
									goto IL_00e6;
								}
								goto IL_041e;
							case 2:
								awaiter = _003C_003Eu__3;
								num4 = 7;
								goto IL_00e6;
							case 0:
								awaiter3 = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num4 = 10;
								goto IL_00e6;
							case 1:
								{
									awaiter2 = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num4 = 52;
									goto IL_00e6;
								}
								IL_00e6:
								while (true)
								{
									switch (num4)
									{
									case 51:
										break;
									default:
										num4 = 26;
										continue;
									case 14:
									case 46:
										CvsTraceEzb.Info.TraceMessage((string)fUyC8rKjL33ypDykIkX1(49608));
										text = (string)owSRY0Kj5wsvmvHQnfS5(plane3DToolType.FindInputFixtureCell(plane3DToolType._pasteObject));
										cellLocation = plane3DToolType.GetCellLocation(_003C_003E8__1.pasteRange.Location, plane3DToolType.l6OEBWxMHJ);
										num4 = 45;
										continue;
									case 48:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 34;
										if (0 == 0)
										{
											continue;
										}
										goto case 12;
									case 12:
										num2 = (_003C_003E1__state = -1);
										num4 = 25;
										continue;
									case 18:
										_003C_003Eu__3 = default;
										num2 = (_003C_003E1__state = -1);
										num4 = 37;
										continue;
									case 2:
										result3 = awaiter5.GetResult();
										C4A3bxKjacqAAADFPRKZ(CvsTraceEzb.Info, CdQUGaROfy7He9T0foW.KbIzwHEDLa(49842));
										num4 = 43;
										continue;
									case 50:
										_003C_003Eu__3 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									case 15:
										return;
									case 6:
										goto IL_02d9;
									case 19:
										num2 = (_003C_003E1__state = 2);
										num4 = 0;
										continue;
									case 47:
										_003C_003Eu__2 = awaiter2;
										num4 = 38;
										if (true)
										{
											continue;
										}
										goto case 13;
									case 13:
										num2 = (_003C_003E1__state = -1);
										num4 = 33;
										if (!ECMHikK3ucHtvVE1RXIk())
										{
											continue;
										}
										goto case 0;
									case 0:
										_003C_003Eu__3 = awaiter;
										num4 = 48;
										continue;
									case 26:
										goto IL_0348;
									case 33:
										goto IL_0360;
									case 3:
										if (!awaiter5.IsCompleted)
										{
											num4 = 40;
											continue;
										}
										goto case 2;
									case 44:
										_003C_003Eu__4 = default;
										num4 = 13;
										continue;
									case 7:
										_003C_003Eu__3 = default;
										num4 = 12;
										continue;
									case 21:
										if (!awaiter2.IsCompleted)
										{
											num4 = 17;
											if (!ECMHikK3ucHtvVE1RXIk())
											{
												continue;
											}
											return;
										}
										goto IL_07e7;
									case 42:
										return;
									case 53:
										goto end_IL_0071;
									case 4:
										goto IL_041e;
									case 34:
										return;
									case 37:
										goto IL_0448;
									case 49:
										_003C_003Eu__5 = default;
										num4 = 39;
										if (0 == 0)
										{
											continue;
										}
										goto case 38;
									case 38:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num4 = 32;
										continue;
									case 29:
										awaiter.GetResult();
										num4 = 9;
										continue;
									case 20:
										awaiter = rrNMAMKjJfDXe0Ncy1sk(MIXfHoKjeSXVMYgcXyp8(_003CnewTool_003E5__4, result3, _003C_003E8__1.pasteRange));
										num4 = 35;
										if (true)
										{
											continue;
										}
										goto case 25;
									case 25:
										awaiter.GetResult();
										num4 = 8;
										continue;
									case 45:
										awaiter = rrNMAMKjJfDXe0Ncy1sk(alvNc1KjwHIOEwdh8PFp(plane3DToolType.Inspect, text, cellLocation));
										if (!awaiter.IsCompleted)
										{
											num4 = 19;
											continue;
										}
										goto case 25;
									case 22:
										_003C_003Eu__3 = default;
										num4 = 4;
										continue;
									case 11:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
										num4 = 15;
										if (0 == 0)
										{
											continue;
										}
										goto case 30;
									case 30:
										_003C_003Eu__5 = awaiter5;
										num4 = 11;
										if (0 == 0)
										{
											continue;
										}
										goto case 5;
									case 5:
										_003C_003Eu__1 = awaiter3;
										num4 = 24;
										continue;
									case 40:
										num2 = (_003C_003E1__state = 5);
										num4 = 30;
										continue;
									case 24:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										return;
									case 9:
										C4A3bxKjacqAAADFPRKZ(CvsTraceEzb.Info, fUyC8rKjL33ypDykIkX1(50030));
										num4 = 54;
										if (hstF1lK310oxEwAis544())
										{
											continue;
										}
										goto IL_05f0;
									case 27:
									case 31:
										goto IL_05f0;
									case 39:
										num2 = (_003C_003E1__state = -1);
										num4 = 2;
										if (!ECMHikK3ucHtvVE1RXIk())
										{
											continue;
										}
										goto case 17;
									case 17:
										num2 = (_003C_003E1__state = 1);
										num4 = 47;
										continue;
									case 35:
										if (!awaiter.IsCompleted)
										{
											num2 = (_003C_003E1__state = 6);
											num4 = 50;
											continue;
										}
										goto case 29;
									case 10:
										result2 = awaiter3.GetResult();
										num4 = 23;
										continue;
									case 43:
										_003CnewTool_003E5__4 = new Plane3DTool((InspectStepViewModel)jf05SWK3hUgPugMaIZ24(plane3DToolType), isInitialized: false);
										num4 = 20;
										continue;
									case 41:
										_003C_003Eu__3 = awaiter;
										num4 = 53;
										continue;
									case 32:
										return;
									case 8:
										C4A3bxKjacqAAADFPRKZ(CvsTraceEzb.Info, fUyC8rKjL33ypDykIkX1(49398));
										num4 = 6;
										continue;
									case 36:
										awaiter2 = _003Csheet_003E5__2.PutCellExpressionAsync(plane3DToolType.GetCellLocation(_003C_003E8__1.pasteRange.Location, plane3DToolType.x3jEG4FoDL), (string)tq6TqFKjKhbSOx85oEX8(plane3DToolType.CurrentInputImageLink)).GetAwaiter();
										num4 = 21;
										if (0 == 0)
										{
											continue;
										}
										goto case 16;
									case 16:
										if (awaiter3.IsCompleted)
										{
											goto case 10;
										}
										num2 = (_003C_003E1__state = 0);
										num4 = 5;
										if (0 == 0)
										{
											continue;
										}
										goto case 52;
									case 52:
										num2 = (_003C_003E1__state = -1);
										num4 = 1;
										continue;
									case 23:
										_003C_003E8__1.pasteRange = result2;
										CvsTraceEzb.Info.TraceMessage((string)fUyC8rKjL33ypDykIkX1(49576));
										num4 = 36;
										continue;
									case 28:
										awaiter3 = plane3DToolType.PasteTool(pasteObject, null, runSheet: false).GetAwaiter();
										num4 = 16;
										if (ECMHikK3ucHtvVE1RXIk())
										{
										}
										continue;
									case 1:
										goto IL_07e7;
									case 54:
										result = _003CnewTool_003E5__4;
										goto end_IL_0070;
									}
									break;
									IL_07e7:
									awaiter2.GetResult();
									_ = 0;
									if (!hstF1lK310oxEwAis544())
									{
										num4 = 27;
										continue;
									}
									num4 = 46;
									if (ECMHikK3ucHtvVE1RXIk())
									{
									}
								}
								goto IL_00b7;
								IL_041e:
								num2 = (_003C_003E1__state = -1);
								num4 = 29;
								goto IL_00e6;
								IL_02d9:
								awaiter4 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
								num4 = 51;
								goto IL_00e6;
								IL_00b7:
								if (!awaiter4.IsCompleted)
								{
									num2 = (_003C_003E1__state = 3);
									_003C_003Eu__4 = awaiter4;
									goto IL_0348;
								}
								goto IL_0360;
								IL_0448:
								awaiter.GetResult();
								CvsTraceEzb.Info.TraceMessage((string)fUyC8rKjL33ypDykIkX1(49466));
								awaiter5 = _003Csheet_003E5__2.RunAndGetCellResults().GetAwaiter();
								num4 = 3;
								goto IL_00e6;
								IL_0348:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
								num4 = 42;
								goto IL_00e6;
								IL_0360:
								awaiter4.GetResult();
								goto IL_05f0;
								IL_05f0:
								C4A3bxKjacqAAADFPRKZ(CvsTraceEzb.Info, fUyC8rKjL33ypDykIkX1(49436));
								awaiter = rrNMAMKjJfDXe0Ncy1sk(Task.WhenAll(plane3DToolType.GtPEt6ZIT4.Zip(plane3DToolType.IYAEZLxEUQ, [MethodImpl(MethodImplOptions.NoInlining)] (CvsDisplayableComposite region, CvsCellLocation offset) =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									return (Task)_003C_003Ec__DisplayClass30_0.GqAo6EK3cl2mo38DRBCI(((AppStepViewModel)_003C_003Ec__DisplayClass30_0.Dq5s6bK32kkxWMrOETW7(_003C_003E8__1._003C_003E4__this)).InSight, _003C_003E8__1._003C_003E4__this.GetCellLocation(_003C_003E8__1.pasteRange.Location, offset), region);
								})));
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 4);
									num4 = 41;
									goto IL_00e6;
								}
								goto IL_0448;
								end_IL_0071:
								break;
							}
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
							end_IL_0070:;
						}
						catch (object obj)
						{
							_003C_003E7__wrap2 = obj;
							num3 = 1;
							goto IL_082c;
						}
						goto end_IL_0018;
						IL_082c:
						if (num3 == 1)
						{
							awaiter = rrNMAMKjJfDXe0Ncy1sk(plane3DToolType.CleanUpPastedToolOnFailedAdd(_003C_003E8__1.pasteRange));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 7);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0898;
						}
						goto IL_08c1;
						IL_0898:
						awaiter.GetResult();
						((ExceptionDispatchInfo)Q5bCTWKjOfRyeSrJbnOa((_003C_003E7__wrap2 as Exception) ?? throw _003C_003E7__wrap2)).Throw();
						goto IL_08c1;
						IL_08c1:
						_003C_003E7__wrap2 = null;
						_003C_003E8__1 = null;
						_003Csheet_003E5__2 = null;
						end_IL_0018:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003E8__1 = null;
						_003Csheet_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					num = 3;
					if (hstF1lK310oxEwAis544())
					{
						continue;
					}
					goto case 7;
				case 7:
					_003Csheet_003E5__2 = null;
					break;
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					if (!hstF1lK310oxEwAis544())
					{
						num = 4;
						continue;
					}
					num = 6;
					if (hstF1lK310oxEwAis544())
					{
						continue;
					}
					goto case 3;
				case 3:
					_003C_003E8__1 = null;
					goto case 7;
				default:
					num = 7;
					continue;
				case 1:
				case 6:
					plane3DToolType = _003C_003E4__this;
					num = 2;
					continue;
				case 4:
				case 5:
					break;
				case 8:
					return;
				}
				_003C_003Et__builder.SetResult(result);
				num = 8;
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
		internal static object jf05SWK3hUgPugMaIZ24(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object leqQ0DK3tOV9yqfACata(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bPMWB0K3z3dxVE8wrQrT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fUyC8rKjL33ypDykIkX1(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tq6TqFKjKhbSOx85oEX8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object owSRY0Kj5wsvmvHQnfS5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object alvNc1KjwHIOEwdh8PFp(object P_0, object P_1, CvsCellLocation P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return InputFixtureViewModel.YnAyJgATSB((InspectStepViewModel)P_0, (string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter rrNMAMKjJfDXe0Ncy1sk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void C4A3bxKjacqAAADFPRKZ(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceMessage((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MIXfHoKjeSXVMYgcXyp8(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Q5bCTWKjOfRyeSrJbnOa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hstF1lK310oxEwAis544()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ECMHikK3ucHtvVE1RXIk()
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
	private struct _003CCreateTool_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public Plane3DToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private Plane3DTool _003Ctool_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			EzTool result = default;
			int num2 = default;
			Plane3DToolType plane3DToolType = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					break;
				case 6:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Ctool_003E5__2 = new Plane3DTool((InspectStepViewModel)YmQ0tqKjiglG5qW1XwWp(plane3DToolType), isInitialized: true);
							c6ImFwKjD5fugognbsgS();
							if (JfcCUXKjIZEMh7qulSR4())
							{
								num3 = 3;
								if (c6ImFwKjD5fugognbsgS())
								{
									goto IL_0066;
								}
							}
							else
							{
								num3 = 1;
								if (c6ImFwKjD5fugognbsgS())
								{
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
						}
						while (true)
						{
							switch (num3)
							{
							case 9:
								break;
							default:
								num3 = 8;
								continue;
							case 1:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 5;
								continue;
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 9;
								continue;
							case 2:
								_003C_003Eu__1 = default;
								goto case 1;
							case 5:
								awaiter.GetResult();
								num3 = 10;
								if (JfcCUXKjIZEMh7qulSR4())
								{
									continue;
								}
								goto case 0;
							case 0:
							case 3:
								awaiter = QtZdJeKjV79032RDaWfI(eL4mgoKjnjVEeTvuumOS(_003Ctool_003E5__2, cells, cellRange));
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto case 5;
							case 8:
								return;
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								if (JfcCUXKjIZEMh7qulSR4())
								{
									continue;
								}
								goto case 10;
							case 10:
								result = _003Ctool_003E5__2;
								goto end_IL_0086;
							}
							goto IL_0066;
							continue;
							end_IL_0086:
							break;
						}
						goto end_IL_002e;
						IL_0066:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_002e:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Ctool_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 4:
					num2 = _003C_003E1__state;
					_ = 0;
					num = (JfcCUXKjIZEMh7qulSR4() ? 5 : 2);
					break;
				default:
					_003Ctool_003E5__2 = null;
					num = 0;
					break;
				case 1:
				case 5:
					plane3DToolType = _003C_003E4__this;
					num = 6;
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
		internal static object YmQ0tqKjiglG5qW1XwWp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eL4mgoKjnjVEeTvuumOS(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter QtZdJeKjV79032RDaWfI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JfcCUXKjIZEMh7qulSR4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool c6ImFwKjD5fugognbsgS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public CvsCogRectangle imageBounds;

		public float radius;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass32_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			zkVTLeKjlT4jkMWLByym(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal CvsDisplayableComposite _003COnBeginAddInternal_003Eb__0(PointF center)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CvsDisplayableComposite cvsDisplayableComposite = EditableGraphicHelper.ConstructComposite(CvsCellLocation.Invalid, 0.0, 0.0, 1.0, 1.0, 0.0, 0.0, imageBounds, mustBeExtrudeable: true);
			EAF251Kjgp692e4NQpyW(cvsDisplayableComposite.CompositeRegion, 0, new CvsGraphicCircle(CvsCellLocation.Invalid, center, radius, ""));
			return cvsDisplayableComposite;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void zkVTLeKjlT4jkMWLByym(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DkLD12Kjf8jEwNHLhEXZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xqkHXyKjdOMBtSo6rnmH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void EAF251Kjgp692e4NQpyW(object P_0, int P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsGraphicCompositeBase)P_0).SetSubregionCircle(P_1, (CvsGraphicCircle)P_2);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnBeginAddInternal_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Plane3DToolType _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			Plane3DToolType plane3DToolType = default;
			int num2 = default;
			_003C_003Ec__DisplayClass32_0 obj = default;
			TaskAwaiter awaiter = default;
			PointF[] source = default;
			float num4 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					plane3DToolType = _003C_003E4__this;
					num = 0;
					if (Foy62PKjv4faYJhuSfAo())
					{
					}
					continue;
				case 0:
					try
					{
						int num3;
						if (num2 != 0)
						{
							obj = new _003C_003Ec__DisplayClass32_0();
							num3 = 6;
							if (1 == 0)
							{
								goto IL_004b;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
						}
						goto IL_012a;
						IL_012a:
						while (true)
						{
							switch (num3)
							{
							case 9:
								break;
							case 13:
								obj.imageBounds = plane3DToolType.GetAcquired2DImageBounds();
								obj.radius = EditableGraphicHelper.CircleCalculateScaledRadius(obj.imageBounds);
								num3 = 7;
								if (0 == 0)
								{
									continue;
								}
								goto case 0;
							case 0:
							case 5:
								source = new PointF[3]
								{
									new PointF(num4, num4),
									new PointF(num4, (float)mROHrgKjrRcCjoenDADv(obj.imageBounds) - num4),
									new PointF((float)d4NTfWKjPER6YPewMfDJ(obj.imageBounds) - num4, num4)
								};
								num3 = 1;
								continue;
							case 1:
								plane3DToolType.GtPEt6ZIT4 = source.Select(obj._003COnBeginAddInternal_003Eb__0).ToArray();
								goto case 10;
							default:
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								goto case 4;
							case 4:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									num3 = 8;
									continue;
								}
								goto case 15;
							case 10:
								awaiter = evGZhdKjZgSJhG7PFYns(plane3DToolType.MlIEsDmmrC());
								num3 = 4;
								continue;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 12;
								if (Kgir7DKjsr9hQCMeDhKD())
								{
									continue;
								}
								goto case 3;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 11;
								continue;
							case 7:
								num4 = obj.radius + 50f;
								goto case 0;
							case 12:
								return;
							case 11:
								num2 = (_003C_003E1__state = -1);
								num3 = 15;
								if (true)
								{
									continue;
								}
								goto case 6;
							case 6:
								plane3DToolType.ShapeIndex0 = 1;
								num3 = 9;
								continue;
							case 2:
							case 14:
								plane3DToolType.ShapeIndex2 = 1;
								num3 = 13;
								continue;
							case 15:
								awaiter.GetResult();
								goto end_IL_012a;
							}
							goto IL_004b;
							continue;
							end_IL_012a:
							break;
						}
						goto end_IL_0033;
						IL_004b:
						plane3DToolType.ShapeIndex1 = 1;
						Kgir7DKjsr9hQCMeDhKD();
						num3 = ((!Foy62PKjv4faYJhuSfAo()) ? 14 : 0);
						goto IL_012a;
						end_IL_0033:;
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
					num2 = _003C_003E1__state;
					_ = 1;
					num = ((!Foy62PKjv4faYJhuSfAo()) ? 5 : 4);
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
		internal static double mROHrgKjrRcCjoenDADv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogRectangle)P_0).Height;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double d4NTfWKjPER6YPewMfDJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogRectangle)P_0).Width;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter evGZhdKjZgSJhG7PFYns(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Kgir7DKjsr9hQCMeDhKD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Foy62PKjv4faYJhuSfAo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetUpdates_003Ed__35 : IEnumerable<ISnippetUpdate>, IEnumerable, IEnumerator<ISnippetUpdate>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ISnippetUpdate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private CvsCellCollection cells;

		public CvsCellCollection _003C_003E3__cells;

		private CvsCellRange range;

		public CvsCellRange _003C_003E3__range;

		public Plane3DToolType _003C_003E4__this;

		private int _003ClatestVersion_003E5__2;

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
		public _003CGetUpdates_003Ed__35(int _003C_003E1__state)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rvpAvmKjBHZC1jK3tgbJ();
			int num;
			if (!LRLBjWKjbsZkXS5XFgCV())
			{
				num = 3;
				if (LRLBjWKjbsZkXS5XFgCV())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 2;
				if (!rvpAvmKjBHZC1jK3tgbJ())
				{
					goto IL_00a2;
				}
			}
			goto IL_0047;
			IL_0072:
			_003C_003El__initialThreadId = MRC6qrKjov7YqQuOPjKP();
			num = 6;
			goto IL_0047;
			IL_00a2:
			efVLFdKjGY44URUt0NAP(this);
			num = 4;
			goto IL_0047;
			IL_002e:
			this._003C_003E1__state = _003C_003E1__state;
			goto IL_0072;
			IL_0047:
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				default:
					num = 5;
					continue;
				case 5:
					goto IL_0072;
				case 0:
				case 3:
					QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
					goto IL_00a2;
				case 1:
				case 2:
					goto IL_00a2;
				case 6:
					return;
				}
				break;
			}
			goto IL_002e;
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
			_ = 0;
			int num;
			if (rvpAvmKjBHZC1jK3tgbJ())
			{
				num = 3;
			}
			else
			{
				num = 6;
				if (false)
				{
					goto IL_0173;
				}
			}
			int num2 = default;
			Plane3DToolType plane3DToolType = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					switch (num2)
					{
					default:
						return false;
					case 0:
						_003C_003E1__state = -1;
						num = 9;
						continue;
					case 2:
						_003C_003E1__state = -1;
						num = 12;
						continue;
					case 1:
						break;
					}
					_003C_003E1__state = -1;
					goto case 6;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 10;
					if (true)
					{
						continue;
					}
					goto case 6;
				case 6:
				case 7:
					_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__2, plane3DToolType.Localizer);
					num = 2;
					continue;
				case 11:
					_003C_003E2__current = new vwi48nu0V1Jw83UB8d();
					num = 4;
					if (true)
					{
						continue;
					}
					goto case 9;
				case 9:
				{
					int snippetVersion = cells.GetSnippetVersion(range);
					_003ClatestVersion_003E5__2 = YjQwvHKjSAoIMwLBNUv2(plane3DToolType._pasteObject);
					if (snippetVersion < 2)
					{
						num = 11;
						continue;
					}
					goto case 6;
				}
				case 2:
					_003C_003E1__state = 2;
					num = 8;
					continue;
				case 10:
					plane3DToolType = _003C_003E4__this;
					num = 1;
					continue;
				case 4:
					_003C_003E1__state = 1;
					goto case 5;
				default:
					num = 5;
					continue;
				case 8:
					return true;
				case 5:
					return true;
				case 12:
					break;
				}
				break;
			}
			goto IL_0173;
			IL_0173:
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
			_003CGetUpdates_003Ed__35 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetUpdates_003Ed__35(0)
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
		internal static void efVLFdKjGY44URUt0NAP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int MRC6qrKjov7YqQuOPjKP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rvpAvmKjBHZC1jK3tgbJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LRLBjWKjbsZkXS5XFgCV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int YjQwvHKjSAoIMwLBNUv2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}
	}

	private readonly Guid[] fdeEKdx6RC;

	private readonly CvsCellLocation x3jEG4FoDL;

	private readonly CvsCellLocation l6OEBWxMHJ;

	private readonly CvsCellLocation[] IYAEZLxEUQ;

	private int sKAEnInHvG;

	private CvsDisplayableComposite[] GtPEt6ZIT4;

	private readonly int[] GUCEYyMFou;

	public override bool IsTypeEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (((AppStepViewModel)PKasgwkObYh3oP3l0JW(this)).Snippets.None([MethodImpl(MethodImplOptions.NoInlining)] (EzSnippet s) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return s is Plane3DTool;
			}))
			{
				return base.IsTypeEnabled;
			}
			return false;
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
			return (string)g5Dgi4kIr6xK4aCOOyW();
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
			return (string)oFYfuZkDt2BWMiwpHlc();
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

	public override string DisabledDescription
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)eqnFYpki4wZhZ9xiyqM();
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
			return XAMLGraphicKeys.Tools_PlaneIcon;
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
			return XAMLGraphicKeys.Tools_PlaneIcon;
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
				(string)xwV78YknkmtioUwfiWv(),
				(string)qsL3HCkVJOApq36V0XR()
			};
		}
	}

	public string Directions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.do6Jx2C493();
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
			return sKAEnInHvG;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref sKAEnInHvG, value, (string)fQ6G53kJMAx885JCtvs(3256));
		}
	}

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fdeEKdx6RC;
		}
	}

	public int ShapeIndex0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GUCEYyMFou[0];
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Oj2EP0wpOD(0, value, (string)fQ6G53kJMAx885JCtvs(19288));
		}
	}

	public int ShapeIndex1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GUCEYyMFou[1];
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Oj2EP0wpOD(1, value, (string)fQ6G53kJMAx885JCtvs(19314));
		}
	}

	public int ShapeIndex2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GUCEYyMFou[2];
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Oj2EP0wpOD(2, value, (string)fQ6G53kJMAx885JCtvs(19340));
		}
	}

	public IReadOnlyList<string> Shapes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.EditableGraphicShapeNames(mustBeExtrudeable: true);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Plane3DToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		while (true)
		{
			switch (num)
			{
			case 12:
				IYAEZLxEUQ[0] = _pasteObject.GetCellOffset((string)fQ6G53kJMAx885JCtvs(19132));
				num = 8;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
				IYAEZLxEUQ[2] = _pasteObject.GetCellOffset((string)fQ6G53kJMAx885JCtvs(19168));
				goto case 6;
			case 8:
				IYAEZLxEUQ[1] = _pasteObject.GetCellOffset(CdQUGaROfy7He9T0foW.KbIzwHEDLa(19150));
				num = 0;
				break;
			case 7:
				DjFmWOkw8jMWKfubTtI();
				num = 1;
				break;
			case 11:
				GUCEYyMFou = new int[3];
				base._002Ector();
				num = 5;
				if (ci4oI7k57wR9tAFlaEK())
				{
				}
				break;
			case 6:
			case 10:
				AddSnippet(_pasteObject);
				num = 13;
				if (uEAjNKkKc03cYMNpGhN())
				{
					break;
				}
				goto case 3;
			case 3:
				x3jEG4FoDL = _pasteObject.GetCellOffset((string)fQ6G53kJMAx885JCtvs(4928));
				goto case 9;
			default:
				num = 9;
				break;
			case 5:
				_pasteObject = (PasteBuffer)KmwiAFkeh6qF93UsgMa(RgMEtIkaJTnayaC5oq8());
				num = 3;
				break;
			case 9:
				l6OEBWxMHJ = _pasteObject.GetCellOffset((string)fQ6G53kJMAx885JCtvs(6522));
				num = 12;
				break;
			case 1:
				fdeEKdx6RC = new Guid[1]
				{
					new Guid((string)fQ6G53kJMAx885JCtvs(19212))
				};
				_ = 1;
				if (ci4oI7k57wR9tAFlaEK())
				{
					num = 6;
					break;
				}
				num = 4;
				if (ci4oI7k57wR9tAFlaEK())
				{
				}
				break;
			case 2:
			case 4:
				IYAEZLxEUQ = new CvsCellLocation[3];
				sKAEnInHvG = 5;
				num = 11;
				break;
			case 13:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InspectSnippetsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IsEnabled = ((AppStepViewModel)PKasgwkObYh3oP3l0JW(this)).Snippets.None([MethodImpl(MethodImplOptions.NoInlining)] (EzSnippet s) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return s is Plane3DTool;
		});
		base.InspectSnippetsCollectionChanged(sender, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddTool_003Ed__30))]
	public override Task<EzTool> AddTool()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddTool_003Ed__30 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateTool_003Ed__31))]
	public override Task<EzTool> CreateTool(Guid guid, CvsCellCollection cells, CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateTool_003Ed__31 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cells = cells;
		stateMachine.cellRange = cellRange;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnBeginAddInternal_003Ed__32))]
	protected override Task OnBeginAddInternal()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		uEAjNKkKc03cYMNpGhN();
		int num;
		if (!ci4oI7k57wR9tAFlaEK())
		{
			num = 4;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 1;
		}
		goto IL_0086;
		IL_002a:
		_003COnBeginAddInternal_003Ed__32 stateMachine = default;
		stateMachine._003C_003Et__builder = y9HhrakfYT89srEXyk5();
		num = 2;
		goto IL_0086;
		IL_0086:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (true)
				{
					continue;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetEditableGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GtPEt6ZIT4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetUpdates_003Ed__35))]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetUpdates_003Ed__35(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__cells = cells,
			_003C_003E3__range = range
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Oj2EP0wpOD(int P_0, int P_1, [CallerMemberName] string propertyName = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ci4oI7k57wR9tAFlaEK();
		int num = ((!uEAjNKkKc03cYMNpGhN()) ? 4 : 5);
		while (true)
		{
			object editableComposite;
			switch (num)
			{
			case 0:
			case 5:
				if (SetField(ref GUCEYyMFou[P_0], P_1, propertyName))
				{
					num = 1;
					continue;
				}
				return;
			case 1:
			{
				CvsDisplayableComposite[] gtPEt6ZIT = GtPEt6ZIT4;
				if (gtPEt6ZIT == null)
				{
					num = 2;
					if (ci4oI7k57wR9tAFlaEK())
					{
					}
					continue;
				}
				editableComposite = gtPEt6ZIT[P_0];
				goto IL_0086;
			}
			case 2:
				editableComposite = null;
				goto IL_0086;
			case 6:
				return;
				IL_0086:
				EditableGraphicHelper.UpdateGraphicShape((CvsDisplayableComposite)editableComposite, P_1);
				break;
			}
			FireAddGraphicsChanged(null, null);
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task MlIEsDmmrC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnBeginAddInternal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DjFmWOkw8jMWKfubTtI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fQ6G53kJMAx885JCtvs(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RgMEtIkaJTnayaC5oq8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.Plane3D;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KmwiAFkeh6qF93UsgMa(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uEAjNKkKc03cYMNpGhN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ci4oI7k57wR9tAFlaEK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PKasgwkObYh3oP3l0JW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzToolType)P_0).Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object g5Dgi4kIr6xK4aCOOyW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.OgqtSslZ88();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oFYfuZkDt2BWMiwpHlc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.YChJjCvUJ5();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eqnFYpki4wZhZ9xiyqM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.TIKJO0ca8w();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xwV78YknkmtioUwfiWv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qsL3HCkVJOApq36V0XR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.F0Z0bUM6Xp();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder y9HhrakfYT89srEXyk5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
