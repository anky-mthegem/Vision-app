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
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.FindEdge;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using oF2MOjpuTE9ryB96aX;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.LineFixture;

[Export(typeof(EzToolType))]
public class LineFixtureToolType : FindEdgeToolType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateTool_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public LineFixtureToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private LineFixtureTool _003Ctool_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (VIx8yjKyzXfYLDYPlG0D() ? 6 : 5);
			int num2 = default;
			LineFixtureToolType lineFixtureToolType = default;
			TaskAwaiter awaiter = default;
			EzTool result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Ctool_003E5__2 = new LineFixtureTool(lineFixtureToolType.Inspect, isInitialized: true);
							_ = 0;
							if (dGPok2Kytd8Nr7ra06BM())
							{
								num3 = 9;
								if (VIx8yjKyzXfYLDYPlG0D())
								{
									goto IL_0058;
								}
							}
							else
							{
								num3 = 3;
							}
							goto IL_012b;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00c2;
						IL_0058:
						num2 = (_003C_003E1__state = -1);
						num3 = 2;
						goto IL_012b;
						IL_012b:
						while (true)
						{
							switch (num3)
							{
							case 7:
								break;
							case 1:
								return;
							case 2:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								if (!VIx8yjKyzXfYLDYPlG0D())
								{
									continue;
								}
								goto case 6;
							case 6:
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								continue;
							case 3:
							case 5:
								goto IL_00c2;
							case 0:
							case 9:
								awaiter = ((Task)u5uf1NK0LtD0toDcgvZP(_003Ctool_003E5__2, cells, cellRange)).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								goto case 2;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 1;
								if (dGPok2Kytd8Nr7ra06BM())
								{
									continue;
								}
								goto case 10;
							case 10:
								result = _003Ctool_003E5__2;
								goto end_IL_0024;
							}
							break;
						}
						goto IL_0058;
						IL_00c2:
						_003C_003Eu__1 = default;
						num3 = 7;
						goto IL_012b;
						end_IL_0024:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Ctool_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 3;
				default:
					num = 3;
					break;
				case 2:
					lineFixtureToolType = _003C_003E4__this;
					num = 1;
					if (!VIx8yjKyzXfYLDYPlG0D())
					{
						break;
					}
					goto case 4;
				case 4:
				case 6:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					break;
				case 3:
					_003Ctool_003E5__2 = null;
					goto case 4;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 2;
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
		internal static object u5uf1NK0LtD0toDcgvZP(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dGPok2Kytd8Nr7ra06BM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VIx8yjKyzXfYLDYPlG0D()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetUpdates_003Ed__23 : IEnumerable<ISnippetUpdate>, IEnumerable, IEnumerator<ISnippetUpdate>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ISnippetUpdate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private CvsCellCollection cells;

		public CvsCellCollection _003C_003E3__cells;

		private CvsCellRange range;

		public CvsCellRange _003C_003E3__range;

		public LineFixtureToolType _003C_003E4__this;

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
		public _003CGetUpdates_003Ed__23(int _003C_003E1__state)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			L5Wc67K0K5SjLH1pZD7q();
			int num;
			if (!HEyVRGK05Qru5sXVvnXR())
			{
				num = 4;
				if (!L5Wc67K0K5SjLH1pZD7q())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 3;
				if (false)
				{
					goto IL_0070;
				}
			}
			goto IL_0089;
			IL_002e:
			u9qLQMK0w31poDnHRa2W();
			num = 5;
			goto IL_0089;
			IL_003d:
			_003C_003El__initialThreadId = DYACQnK0aWAYsFHYBblq();
			num = 6;
			if (HEyVRGK05Qru5sXVvnXR())
			{
				goto IL_0058;
			}
			goto IL_0089;
			IL_0089:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					break;
				case 1:
					goto IL_003d;
				case 5:
					goto IL_0058;
				case 2:
				case 3:
					goto IL_0070;
				default:
					num = 1;
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
			goto IL_002e;
			IL_0070:
			this._003C_003E1__state = _003C_003E1__state;
			goto IL_003d;
			IL_0058:
			WfHsFmK0J2NEnB0J7AGE(this);
			goto IL_0070;
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
			int num = 10;
			LineFixtureToolType lineFixtureToolType = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 7:
					_003C_003E2__current = new AXWGRD6PhpEZe2JbB8(lineFixtureToolType._pasteObject, ((CvsInSight)OJk4n3K0OsMTJ3A7jUEh(lineFixtureToolType)).FunctionTable, (IExpressionConstants)zxpsD9K0IZNpb9MocWit(OJk4n3K0OsMTJ3A7jUEh(lineFixtureToolType)));
					num = 6;
					continue;
				case 10:
					num2 = _003C_003E1__state;
					num = 8;
					continue;
				case 0:
					return true;
				case 2:
					if (num2 != 0)
					{
						num = 1;
						continue;
					}
					_003C_003E1__state = -1;
					goto default;
				default:
				{
					int snippetVersion = cells.GetSnippetVersion(range);
					int num3 = nFWEhXK0eHkvJdMh3C5k(lineFixtureToolType._pasteObject);
					if (snippetVersion < num3)
					{
						num = 7;
						continue;
					}
					break;
				}
				case 1:
					if (num2 == 1)
					{
						_003C_003E1__state = -1;
						num = 11;
					}
					else
					{
						HEyVRGK05Qru5sXVvnXR();
						num = ((!L5Wc67K0K5SjLH1pZD7q()) ? 3 : 9);
					}
					continue;
				case 6:
					_003C_003E1__state = 1;
					num = 0;
					continue;
				case 4:
				case 9:
					return false;
				case 8:
					lineFixtureToolType = _003C_003E4__this;
					num = 2;
					continue;
				case 11:
					break;
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
			_003CGetUpdates_003Ed__23 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetUpdates_003Ed__23(0)
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
		internal static void u9qLQMK0w31poDnHRa2W()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WfHsFmK0J2NEnB0J7AGE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int DYACQnK0aWAYsFHYBblq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool L5Wc67K0K5SjLH1pZD7q()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HEyVRGK05Qru5sXVvnXR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int nFWEhXK0eHkvJdMh3C5k(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OJk4n3K0OsMTJ3A7jUEh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zxpsD9K0IZNpb9MocWit(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).ProcessorConstants;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddTool_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public LineFixtureToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsDisplayableRegion editableRegion;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private CvsCellRange _003CpasteRange_003E5__3;

		private object _003C_003E7__wrap3;

		private bool _003ColdPass_003E5__5;

		private LineFixtureTool _003CnewTool_003E5__6;

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
			EzTool result = default;
			LineFixtureToolType lineFixtureToolType = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<CvsCellRange> awaiter3 = default;
			TaskAwaiter<object> awaiter5 = default;
			TaskAwaiter<CvsCellCollection> awaiter2 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter4 = default;
			CvsCellCollection result2 = default;
			string text = default;
			CvsCellLocation cellLocation = default;
			CvsCellRange result3 = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
				case 2:
					lineFixtureToolType = _003C_003E4__this;
					num = 4;
					break;
				default:
					_003Csheet_003E5__2 = null;
					num = 6;
					break;
				case 4:
					try
					{
						int num3;
						if ((uint)num2 > 8u)
						{
							if (num2 == 9)
							{
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0a53;
							}
							_003Csheet_003E5__2 = (CvsCogSocketSheet)DJjaF3K0fHtALcOM0oAp(NI1FMJK0V2AWPtt38tkv(((AppStepViewModel)lPiuQIK0nXib0NITPE2q(lineFixtureToolType)).InSight));
							_003CpasteRange_003E5__3 = CvsCellRange.Empty;
							num3 = 0;
						}
						try
						{
							int num4;
							switch (num2)
							{
							default:
								awaiter3 = lineFixtureToolType.RenameAndPasteTool(lineFixtureToolType._pasteObject, cells, runSheet: false).GetAwaiter();
								num4 = 48;
								goto IL_039c;
							case 6:
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num4 = 56;
								goto IL_039c;
							case 1:
								awaiter5 = _003C_003Eu__2;
								num4 = 40;
								goto IL_039c;
							case 2:
								awaiter = _003C_003Eu__3;
								num4 = 11;
								goto IL_039c;
							case 8:
								awaiter2 = _003C_003Eu__5;
								num4 = 59;
								goto IL_039c;
							case 3:
								awaiter4 = _003C_003Eu__4;
								num4 = 25;
								if (0 == 0)
								{
									goto IL_039c;
								}
								goto IL_06ca;
							case 4:
								awaiter = _003C_003Eu__3;
								num4 = 38;
								goto IL_039c;
							case 0:
								awaiter3 = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num4 = 17;
								goto IL_039c;
							case 7:
								awaiter = _003C_003Eu__3;
								num4 = 22;
								goto IL_039c;
							case 5:
								{
									awaiter2 = _003C_003Eu__5;
									_003C_003Eu__5 = default;
									num4 = 9;
									goto IL_039c;
								}
								IL_039c:
								while (true)
								{
									switch (num4)
									{
									case 3:
										num2 = (_003C_003E1__state = -1);
										num4 = 6;
										if (bwE4QRK0iQqI3O9QL78G())
										{
										}
										continue;
									case 48:
										if (!awaiter3.IsCompleted)
										{
											num4 = 54;
											continue;
										}
										goto case 27;
									case 58:
										awaiter = VoIEpfK0sjCq0GfFdNCv(NIUIeCK0PSQ7CKs4KIum(_003CnewTool_003E5__6, result2, _003CpasteRange_003E5__3));
										num4 = 57;
										continue;
									case 43:
										_003C_003Eu__5 = awaiter2;
										num4 = 42;
										continue;
									case 38:
										_003C_003Eu__3 = default;
										num4 = 41;
										continue;
									case 17:
										num2 = (_003C_003E1__state = -1);
										num4 = 27;
										continue;
									case 13:
										awaiter.GetResult();
										num4 = 16;
										if (true)
										{
											continue;
										}
										return;
									case 45:
										return;
									case 8:
										_003CnewTool_003E5__6 = new LineFixtureTool(lineFixtureToolType.Inspect, isInitialized: false);
										num4 = 58;
										if (true)
										{
											continue;
										}
										goto case 20;
									case 20:
										text = (string)Q6Ql9wK0l4tQ5q3te8i0(lineFixtureToolType.FindInputFixtureCell(lineFixtureToolType._pasteObject));
										cellLocation = lineFixtureToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, lineFixtureToolType.YC7M1vPt8a);
										num4 = 46;
										continue;
									case 52:
										_003CpasteRange_003E5__3 = result3;
										awaiter5 = _003Csheet_003E5__2.PutCellExpressionAsync(lineFixtureToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, lineFixtureToolType.IVjM83E8mn), (string)SkOV81K0dhd8f3p4w7aD(lineFixtureToolType.InputImageLinks[lineFixtureToolType.InputImageIndex])).GetAwaiter();
										if (!awaiter5.IsCompleted)
										{
											num2 = (_003C_003E1__state = 1);
											_003C_003Eu__2 = awaiter5;
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
											return;
										}
										goto case 5;
									case 25:
										_003C_003Eu__4 = default;
										num4 = 3;
										continue;
									case 49:
										if (!awaiter.IsCompleted)
										{
											num4 = 60;
											if (vHK3V5K0Dp0At8Nm19qs())
											{
												continue;
											}
											goto case 40;
										}
										goto case 7;
									case 40:
										_003C_003Eu__2 = default;
										num2 = (_003C_003E1__state = -1);
										num4 = 5;
										if (vHK3V5K0Dp0At8Nm19qs())
										{
											continue;
										}
										goto case 59;
									case 59:
										_003C_003Eu__5 = default;
										num4 = 51;
										continue;
									case 15:
										if (!awaiter.IsCompleted)
										{
											num2 = (_003C_003E1__state = 7);
											_003C_003Eu__3 = awaiter;
											bwE4QRK0iQqI3O9QL78G();
											if (vHK3V5K0Dp0At8Nm19qs())
											{
												num4 = 31;
												if (0 == 0)
												{
													continue;
												}
												goto case 57;
											}
											num4 = 32;
											if (!bwE4QRK0iQqI3O9QL78G())
											{
												continue;
											}
											goto case 24;
										}
										goto case 32;
									case 57:
										if (!awaiter.IsCompleted)
										{
											num4 = 62;
											continue;
										}
										goto case 13;
									case 51:
										num2 = (_003C_003E1__state = -1);
										num4 = 18;
										continue;
									case 22:
										_003C_003Eu__3 = default;
										num2 = (_003C_003E1__state = -1);
										goto case 32;
									case 24:
										awaiter2 = _003Csheet_003E5__2.RunAndGetCellResults().GetAwaiter();
										goto case 61;
									default:
										num4 = 61;
										if (vHK3V5K0Dp0At8Nm19qs())
										{
											continue;
										}
										goto case 60;
									case 60:
										num2 = (_003C_003E1__state = 2);
										_003C_003Eu__3 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									case 27:
										result3 = awaiter3.GetResult();
										num4 = 52;
										if (bwE4QRK0iQqI3O9QL78G())
										{
										}
										continue;
									case 53:
										_003C_003Eu__3 = awaiter;
										num4 = 1;
										if (vHK3V5K0Dp0At8Nm19qs())
										{
											continue;
										}
										goto case 61;
									case 61:
										if (!awaiter2.IsCompleted)
										{
											num2 = (_003C_003E1__state = 5);
											num4 = 43;
											continue;
										}
										goto case 44;
									case 62:
										num2 = (_003C_003E1__state = 6);
										num4 = 29;
										continue;
									case 28:
										return;
									case 32:
									case 50:
										awaiter.GetResult();
										if (!_003ColdPass_003E5__5)
										{
											num4 = 37;
											continue;
										}
										goto end_IL_008b;
									case 5:
										awaiter5.GetResult();
										num4 = 20;
										continue;
									case 41:
										num2 = (_003C_003E1__state = -1);
										num4 = 55;
										continue;
									case 31:
									case 47:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 35;
										if (vHK3V5K0Dp0At8Nm19qs())
										{
											continue;
										}
										goto case 30;
									case 30:
										awaiter = VoIEpfK0sjCq0GfFdNCv(EditableGraphicHelper.SendGraphicAsync((CvsInSight)qLFDWxK0g9KrhO79FBNc(lPiuQIK0nXib0NITPE2q(lineFixtureToolType)), lineFixtureToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, lineFixtureToolType.DpbMmgt4ik), editableRegion));
										if (!awaiter.IsCompleted)
										{
											num4 = 34;
											continue;
										}
										goto case 55;
									case 6:
										awaiter4.GetResult();
										num4 = 30;
										continue;
									case 56:
										num2 = (_003C_003E1__state = -1);
										num4 = 13;
										continue;
									case 39:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										num4 = 10;
										if (!bwE4QRK0iQqI3O9QL78G())
										{
											continue;
										}
										goto case 42;
									case 42:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num4 = 26;
										continue;
									case 12:
										if (!awaiter4.IsCompleted)
										{
											num4 = 2;
											continue;
										}
										goto case 6;
									case 11:
										_003C_003Eu__3 = default;
										num2 = (_003C_003E1__state = -1);
										num4 = 7;
										if (true)
										{
											continue;
										}
										goto case 55;
									case 55:
										awaiter.GetResult();
										num4 = 24;
										continue;
									case 10:
										return;
									case 36:
										break;
									case 16:
										awaiter = VoIEpfK0sjCq0GfFdNCv(DynamicThresholdCalculator.DynamicallyThresholdTool(_003Csheet_003E5__2, lineFixtureToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, lineFixtureToolType.HauMzu3Jab), _003CnewTool_003E5__6.AcceptThreshold));
										num4 = 15;
										if (bwE4QRK0iQqI3O9QL78G())
										{
										}
										continue;
									case 14:
										return;
									case 1:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 14;
										continue;
									case 9:
										num2 = (_003C_003E1__state = -1);
										num4 = 44;
										if (bwE4QRK0iQqI3O9QL78G())
										{
										}
										continue;
									case 44:
										result2 = awaiter2.GetResult();
										_003ColdPass_003E5__5 = vare0sK0rtvw3P6NQ7hB(YVmmscK0v0ErH7nPK8t7(result2, lineFixtureToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, lineFixtureToolType.HauMzu3Jab))).Equals(1.0);
										num4 = 8;
										continue;
									case 19:
										return;
									case 54:
										num2 = (_003C_003E1__state = 0);
										_003C_003Eu__1 = awaiter3;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										num4 = 19;
										if (0 == 0)
										{
											continue;
										}
										goto case 2;
									case 2:
										num2 = (_003C_003E1__state = 3);
										_003C_003Eu__4 = awaiter4;
										num4 = 39;
										continue;
									case 4:
										zcHT49K0ZKvHAIJmOVO6(_003CnewTool_003E5__6, result2);
										num4 = 63;
										continue;
									case 23:
										num2 = (_003C_003E1__state = 8);
										num4 = 0;
										continue;
									case 21:
										awaiter4 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
										num4 = 12;
										if (bwE4QRK0iQqI3O9QL78G())
										{
										}
										continue;
									case 37:
										awaiter2 = _003Csheet_003E5__2.RunAndGetCellResults().GetAwaiter();
										if (!awaiter2.IsCompleted)
										{
											num4 = 23;
											continue;
										}
										goto case 18;
									case 33:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num4 = 28;
										continue;
									case 29:
										_003C_003Eu__3 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 45;
										if (vHK3V5K0Dp0At8Nm19qs())
										{
											continue;
										}
										goto case 34;
									case 34:
										num2 = (_003C_003E1__state = 4);
										num4 = 53;
										continue;
									case 35:
										return;
									case 18:
										result2 = awaiter2.GetResult();
										num4 = 36;
										if (!bwE4QRK0iQqI3O9QL78G())
										{
											continue;
										}
										return;
									case 26:
										return;
									case 0:
										_003C_003Eu__5 = awaiter2;
										num4 = 33;
										if (bwE4QRK0iQqI3O9QL78G())
										{
										}
										continue;
									case 46:
										awaiter = InputFixtureViewModel.YnAyJgATSB(lineFixtureToolType.Inspect, text, cellLocation).GetAwaiter();
										num4 = 49;
										if (!bwE4QRK0iQqI3O9QL78G())
										{
											continue;
										}
										goto case 7;
									case 7:
										awaiter.GetResult();
										num4 = 21;
										continue;
									case 63:
										goto end_IL_008b;
									}
									break;
								}
								goto IL_06ca;
								IL_06ca:
								if (!vare0sK0rtvw3P6NQ7hB(YVmmscK0v0ErH7nPK8t7(result2, lineFixtureToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, lineFixtureToolType.HauMzu3Jab))).Equals(1.0))
								{
									break;
								}
								num4 = 4;
								goto IL_039c;
								end_IL_008b:
								break;
							}
							result = _003CnewTool_003E5__6;
						}
						catch (object obj)
						{
							_003C_003E7__wrap3 = obj;
							num3 = 1;
							goto IL_09eb;
						}
						goto end_IL_0052;
						IL_09eb:
						if (num3 == 1)
						{
							awaiter = VoIEpfK0sjCq0GfFdNCv(lineFixtureToolType.CleanUpPastedToolOnFailedAdd(_003CpasteRange_003E5__3));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 9);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0a53;
						}
						goto IL_0a7c;
						IL_0a53:
						awaiter.GetResult();
						yn36AJK0bMPfpYXXTNIV(cAWWnQK0BbY2ZG7MGJ8r((_003C_003E7__wrap3 as Exception) ?? throw _003C_003E7__wrap3));
						goto IL_0a7c;
						IL_0a7c:
						_003C_003E7__wrap3 = null;
						_003Csheet_003E5__2 = null;
						_003CpasteRange_003E5__3 = default;
						end_IL_0052:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Csheet_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					num = (vHK3V5K0Dp0At8Nm19qs() ? 2 : 5);
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
		internal static object lPiuQIK0nXib0NITPE2q(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object NI1FMJK0V2AWPtt38tkv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DJjaF3K0fHtALcOM0oAp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SkOV81K0dhd8f3p4w7aD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Q6Ql9wK0l4tQ5q3te8i0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qLFDWxK0g9KrhO79FBNc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter VoIEpfK0sjCq0GfFdNCv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YVmmscK0v0ErH7nPK8t7(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vare0sK0rtvw3P6NQ7hB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).CellValue;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object NIUIeCK0PSQ7CKs4KIum(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void zcHT49K0ZKvHAIJmOVO6(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EzTool)P_0).OnResultsChangedTool((CvsCellCollection)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cAWWnQK0BbY2ZG7MGJ8r(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yn36AJK0bMPfpYXXTNIV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vHK3V5K0Dp0At8Nm19qs()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bwE4QRK0iQqI3O9QL78G()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly Guid[] gBPMhYVarU;

	private readonly CvsCellLocation IVjM83E8mn;

	private readonly CvsCellLocation DpbMmgt4ik;

	private readonly CvsCellLocation YC7M1vPt8a;

	private readonly CvsCellLocation HauMzu3Jab;

	private int jQpRahylYe;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return gBPMhYVarU;
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
			return Resources.Uw70XXnpZJ();
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
			return (string)H5TblX4fD9XQsfJf3hO();
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
			return XAMLGraphicKeys.Tools_EdgeFixtureIcon;
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
			return XAMLGraphicKeys.Tools_EdgeFixtureIcon;
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
				(string)UeCxDf4dEn5INNXyo7q(),
				(string)Q6w49A4l25EJjGIMj7H()
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
			return jQpRahylYe;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref jQpRahylYe, value, (string)XMgBaZ4nmyXXycnRKCH(3256));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LineFixtureToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!kC9IdI4OcrtYQaLsoi0())
		{
			num = 9;
			if (!hK07jC4eLIWXlCKYpPQ())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_00dc;
		IL_002a:
		QsQOkY4IngNY8oJ6EH6();
		num = 11;
		goto IL_00dc;
		IL_00dc:
		SnippetLocalizer snippetLocalizer = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 9:
				break;
			case 7:
				YC7M1vPt8a = _pasteObject.GetCellOffset((string)XMgBaZ4nmyXXycnRKCH(6522));
				HauMzu3Jab = _pasteObject.GetCellOffset((string)XMgBaZ4nmyXXycnRKCH(24546));
				num = 6;
				continue;
			case 10:
				_pasteObject = (PasteBuffer)uTYPmI4iRcCH973xkEi(pMYRvY4DxXwHgNJ2B4G());
				num = 8;
				if (0 == 0)
				{
					continue;
				}
				goto case 3;
			case 3:
				AddSnippet(_pasteObject, snippetLocalizer);
				num = 12;
				continue;
			case 1:
				DpbMmgt4ik = _pasteObject.GetCellOffset((string)XMgBaZ4nmyXXycnRKCH(5684));
				goto case 7;
			default:
				num = 7;
				continue;
			case 4:
				snippetLocalizer.ExcludedStrings.Add((string)XMgBaZ4nmyXXycnRKCH(24288));
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 8;
			case 8:
				IVjM83E8mn = _pasteObject.GetCellOffset((string)XMgBaZ4nmyXXycnRKCH(4928));
				num = 1;
				continue;
			case 11:
				jQpRahylYe = 200;
				goto case 2;
			case 2:
			case 5:
				base._002Ector();
				num = 10;
				continue;
			case 6:
				snippetLocalizer = (SnippetLocalizer)sW3m514VorMPQ3igBBF();
				num = 4;
				continue;
			case 12:
				return;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateTool_003Ed__22))]
	public override Task<EzTool> CreateTool(Guid guid, CvsCellCollection cells, CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateTool_003Ed__22 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cells = cells;
		stateMachine.cellRange = cellRange;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetUpdates_003Ed__23))]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetUpdates_003Ed__23(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__cells = cells,
			_003C_003E3__range = range
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddTool_003Ed__24))]
	internal override Task<EzTool> AddTool(CvsDisplayableRegion editableRegion, CvsCellCollection cells = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddTool_003Ed__24 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.editableRegion = editableRegion;
		stateMachine.cells = cells;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static LineFixtureToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QsQOkY4IngNY8oJ6EH6();
		gBPMhYVarU = new Guid[1]
		{
			new Guid(CdQUGaROfy7He9T0foW.KbIzwHEDLa(24566))
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QsQOkY4IngNY8oJ6EH6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pMYRvY4DxXwHgNJ2B4G()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.LineFixture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uTYPmI4iRcCH973xkEi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XMgBaZ4nmyXXycnRKCH(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sW3m514VorMPQ3igBBF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EzSnippetType.CreateDefaultSnippetLocalizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hK07jC4eLIWXlCKYpPQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kC9IdI4OcrtYQaLsoi0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object H5TblX4fD9XQsfJf3hO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.k7O0S5yViQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UeCxDf4dEn5INNXyo7q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Q6w49A4l25EJjGIMj7H()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.F0Z0bUM6Xp();
	}
}
