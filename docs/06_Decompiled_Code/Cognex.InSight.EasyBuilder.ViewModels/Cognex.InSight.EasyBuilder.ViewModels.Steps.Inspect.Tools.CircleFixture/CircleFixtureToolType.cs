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
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.FindCircle;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using oF2MOjpuTE9ryB96aX;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.CircleFixture;

[Export(typeof(EzToolType))]
public class CircleFixtureToolType : FindCircleToolType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateTool_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public CircleFixtureToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private CircleFixtureTool _003Ctool_003E5__2;

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
			if (!nLhP8YKQ1B5aHpxAu8Dj())
			{
				num = 5;
				if (!ybcYOLKQcRSKyc8sI8h7())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 3;
				if (nLhP8YKQ1B5aHpxAu8Dj())
				{
				}
			}
			goto IL_0212;
			IL_002a:
			_003Ctool_003E5__2 = null;
			num = 6;
			goto IL_0212;
			IL_0212:
			int num2 = default;
			EzTool result = default;
			CircleFixtureToolType circleFixtureToolType = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 6:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					if (true)
					{
						continue;
					}
					goto case 1;
				case 1:
				case 3:
					circleFixtureToolType = _003C_003E4__this;
					num = 4;
					if (ybcYOLKQcRSKyc8sI8h7())
					{
						continue;
					}
					goto case 4;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Ctool_003E5__2 = new CircleFixtureTool((InspectStepViewModel)RkEYb3KQuX629vVXQifp(circleFixtureToolType), isInitialized: true);
							num3 = 0;
							goto IL_0178;
						}
						awaiter = _003C_003Eu__1;
						goto IL_01b3;
						IL_01b3:
						_003C_003Eu__1 = default;
						num3 = 2;
						goto IL_0178;
						IL_0178:
						while (true)
						{
							switch (num3)
							{
							case 6:
								awaiter.GetResult();
								num3 = 10;
								if (!nLhP8YKQ1B5aHpxAu8Dj())
								{
									continue;
								}
								goto case 1;
							case 1:
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto case 6;
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
								awaiter = rXRVt3KQttXpf8svrwYT(VhuhGlKQhoNxbbUZy5Ze(_003Ctool_003E5__2, cells, cellRange));
								_ = 0;
								num3 = ((!ybcYOLKQcRSKyc8sI8h7()) ? 4 : 9);
								continue;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 6;
								continue;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 3;
							default:
								num3 = 3;
								continue;
							case 4:
							case 5:
								break;
							case 10:
								result = _003Ctool_003E5__2;
								goto end_IL_0178;
							}
							goto IL_01b3;
							continue;
							end_IL_0178:
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Ctool_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				default:
					num = 2;
					if (!nLhP8YKQ1B5aHpxAu8Dj())
					{
						continue;
					}
					return;
				case 7:
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
		internal static object RkEYb3KQuX629vVXQifp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VhuhGlKQhoNxbbUZy5Ze(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter rXRVt3KQttXpf8svrwYT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ybcYOLKQcRSKyc8sI8h7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nLhP8YKQ1B5aHpxAu8Dj()
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

		public CircleFixtureToolType _003C_003E4__this;

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
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 5:
					EtTHqOKNKQLYAyclEXUY();
					_ = 0;
					num = ((!xvqjmnKQzRAOgknbE3Eu()) ? 2 : 0);
					break;
				default:
					_003C_003El__initialThreadId = C2Y79cKNwwf4iMSJywJS();
					num = 6;
					break;
				case 4:
					this._003C_003E1__state = _003C_003E1__state;
					goto default;
				case 0:
				case 1:
					vtt1ZbKN5sYbL7OBZUTs(this);
					num = 4;
					break;
				case 6:
					return;
				}
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
			int num = 9;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_0060;
			IL_0161:
			return false;
			IL_0128:
			int num2 = GMovaAKNJFGq0IB8sL9V(cells, range);
			CircleFixtureToolType circleFixtureToolType = default;
			int snippetVersion = SnippetPasteBuffer.GetSnippetVersion(circleFixtureToolType._pasteObject);
			if (num2 < snippetVersion)
			{
				_ = 0;
				num = (xvqjmnKQzRAOgknbE3Eu() ? 8 : 4);
				goto IL_0060;
			}
			goto IL_0161;
			IL_0060:
			int num3 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 5:
					goto IL_0034;
				case 3:
					return false;
				default:
					num = 1;
					continue;
				case 2:
					circleFixtureToolType = _003C_003E4__this;
					num = 0;
					if (xvqjmnKQzRAOgknbE3Eu())
					{
						continue;
					}
					goto case 10;
				case 10:
					return true;
				case 6:
				case 8:
					_003C_003E2__current = new AXWGRD6PhpEZe2JbB8(circleFixtureToolType._pasteObject, (CvsFunctionTable)WvQFZ2KNeiaXl7gV6Yeo(jkKQwlKNaKNdvppDW47L(circleFixtureToolType)), (IExpressionConstants)BEJDm3KNONUq7ateZ7xw(jkKQwlKNaKNdvppDW47L(circleFixtureToolType)));
					goto case 4;
				case 9:
					num3 = _003C_003E1__state;
					num = 2;
					continue;
				case 4:
				case 7:
					_003C_003E1__state = 1;
					num = 10;
					if (xvqjmnKQzRAOgknbE3Eu())
					{
						continue;
					}
					goto IL_0128;
				case 1:
					goto IL_0128;
				case 11:
					goto IL_0161;
				}
				break;
				IL_0034:
				if (num3 != 1)
				{
					num = 3;
					continue;
				}
				_003C_003E1__state = -1;
				num = 11;
			}
			goto IL_001a;
			IL_001a:
			if (num3 != 0)
			{
				num = 5;
				if (aDbdBBKNL1OTjOuM5pbp())
				{
				}
				goto IL_0060;
			}
			_003C_003E1__state = -1;
			goto IL_0128;
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
		internal static void EtTHqOKNKQLYAyclEXUY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vtt1ZbKN5sYbL7OBZUTs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int C2Y79cKNwwf4iMSJywJS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xvqjmnKQzRAOgknbE3Eu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aDbdBBKNL1OTjOuM5pbp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int GMovaAKNJFGq0IB8sL9V(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jkKQwlKNaKNdvppDW47L(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WvQFZ2KNeiaXl7gV6Yeo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).FunctionTable;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BEJDm3KNONUq7ateZ7xw(object P_0)
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

		public CircleFixtureToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsDisplayableAnnulus editableAnnulus;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private CvsCellRange _003CpasteRange_003E5__3;

		private object _003C_003E7__wrap3;

		private bool _003ColdPass_003E5__5;

		private CircleFixtureTool _003CnewTool_003E5__6;

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
			HI7FMyKNI33dOMU6Csav();
			int num;
			if (!a029WPKNDK6Bg4ihEqQx())
			{
				num = 2;
				if (a029WPKNDK6Bg4ihEqQx())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_0a9f;
			IL_002e:
			CircleFixtureToolType circleFixtureToolType = _003C_003E4__this;
			num = 6;
			goto IL_0a9f;
			IL_0a9f:
			EzTool result = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<CvsCellRange> awaiter4 = default;
			TaskAwaiter<object> awaiter5 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter3 = default;
			TaskAwaiter<CvsCellCollection> awaiter2 = default;
			CvsCellCollection result3 = default;
			string text = default;
			CvsCellRange result2 = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					break;
				case 5:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					if (true)
					{
						continue;
					}
					goto case 6;
				case 6:
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
								goto IL_0a1a;
							}
							_003Csheet_003E5__2 = (CvsCogSocketSheet)SYcBUFKNVQrkWJDio1yf(((CvsInSight)UFdIB8KNnuXcyEffyr4D(INIkUcKNiYB8q5rTTcyY(circleFixtureToolType))).CogSocket);
							_003CpasteRange_003E5__3 = CvsCellRange.Empty;
							num3 = 0;
						}
						try
						{
							int num4;
							switch (num2)
							{
							default:
								awaiter4 = circleFixtureToolType.RenameAndPasteTool(circleFixtureToolType._pasteObject, cells, runSheet: false).GetAwaiter();
								num4 = 33;
								if (false)
								{
									goto IL_00df;
								}
								goto IL_070c;
							case 1:
								awaiter5 = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num4 = 48;
								goto IL_070c;
							case 0:
								awaiter4 = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num4 = 7;
								goto IL_070c;
							case 3:
								awaiter3 = _003C_003Eu__4;
								num4 = 40;
								goto IL_070c;
							case 5:
								awaiter2 = _003C_003Eu__5;
								_003C_003Eu__5 = default;
								num4 = 62;
								goto IL_070c;
							case 7:
								awaiter = _003C_003Eu__3;
								num4 = 4;
								if (!HI7FMyKNI33dOMU6Csav())
								{
									goto IL_045f;
								}
								goto IL_070c;
							case 4:
								awaiter = _003C_003Eu__3;
								num4 = 51;
								goto IL_070c;
							case 8:
								awaiter2 = _003C_003Eu__5;
								_003C_003Eu__5 = default;
								num4 = 9;
								if (false)
								{
									goto IL_063a;
								}
								goto IL_070c;
							case 6:
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num4 = 47;
								goto IL_070c;
							case 2:
								{
									awaiter = _003C_003Eu__3;
									num4 = 61;
									goto IL_070c;
								}
								IL_070c:
								while (true)
								{
									switch (num4)
									{
									case 48:
										break;
									case 10:
										awaiter = efH0SGKNgyhw7bUeRaQt(EditableGraphicHelper.SendGraphicAsync(((AppStepViewModel)INIkUcKNiYB8q5rTTcyY(circleFixtureToolType)).InSight, circleFixtureToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, circleFixtureToolType.UC9C9ao5Jo), editableAnnulus));
										num4 = 49;
										continue;
									case 60:
										awaiter = ((Task)J9efkNKNrOBYh9L4YLFH(_003CnewTool_003E5__6, result3, _003CpasteRange_003E5__3)).GetAwaiter();
										if (!awaiter.IsCompleted)
										{
											num2 = (_003C_003E1__state = 6);
											num4 = 57;
											continue;
										}
										goto case 53;
									case 45:
										return;
									case 37:
										return;
									case 18:
										awaiter.GetResult();
										goto case 35;
									case 32:
										_003CnewTool_003E5__6 = new CircleFixtureTool(circleFixtureToolType.Inspect, isInitialized: false);
										num4 = 60;
										if (!a029WPKNDK6Bg4ihEqQx())
										{
											continue;
										}
										goto case 31;
									case 31:
										if (!awaiter2.IsCompleted)
										{
											num4 = 26;
											if (true)
											{
												continue;
											}
											return;
										}
										goto case 55;
									case 50:
										return;
									case 62:
										num2 = (_003C_003E1__state = -1);
										num4 = 27;
										continue;
									case 19:
										num2 = (_003C_003E1__state = -1);
										num4 = 18;
										continue;
									case 35:
									case 36:
										awaiter2 = _003Csheet_003E5__2.RunAndGetCellResults().GetAwaiter();
										num4 = 13;
										if (0 == 0)
										{
											continue;
										}
										goto case 49;
									case 49:
										if (!awaiter.IsCompleted)
										{
											num4 = 42;
											continue;
										}
										goto case 18;
									case 26:
										num2 = (_003C_003E1__state = 8);
										_003C_003Eu__5 = awaiter2;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num4 = 15;
										if (true)
										{
											continue;
										}
										goto case 46;
									case 46:
										if (!awaiter5.IsCompleted)
										{
											num2 = (_003C_003E1__state = 1);
											num4 = 22;
											continue;
										}
										goto case 38;
									case 12:
										_003C_003Eu__5 = awaiter2;
										num4 = 0;
										if (HI7FMyKNI33dOMU6Csav())
										{
											continue;
										}
										goto case 43;
									case 43:
										num2 = (_003C_003E1__state = 7);
										num4 = 24;
										continue;
									case 2:
										awaiter.GetResult();
										num4 = 5;
										continue;
									case 0:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num4 = 56;
										continue;
									case 5:
										awaiter3 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
										num4 = 11;
										continue;
									case 42:
										num2 = (_003C_003E1__state = 4);
										num4 = 59;
										continue;
									case 14:
										awaiter = efH0SGKNgyhw7bUeRaQt(DynamicThresholdCalculator.DynamicallyThresholdTool(_003Csheet_003E5__2, circleFixtureToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, circleFixtureToolType.s8hChAhExm), (EditIntViewModel)rK2XrGKNPphl8D0yrSRJ(_003CnewTool_003E5__6)));
										num4 = 30;
										if (!a029WPKNDK6Bg4ihEqQx())
										{
											continue;
										}
										return;
									case 56:
										return;
									case 20:
										text = (string)XhWem4KNdkZj7VEs55b3(circleFixtureToolType.FindInputFixtureCell(circleFixtureToolType._pasteObject));
										num4 = 23;
										if (0 == 0)
										{
											continue;
										}
										goto case 34;
									case 34:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										num4 = 50;
										if (true)
										{
											continue;
										}
										goto case 16;
									case 16:
									case 58:
										num2 = (_003C_003E1__state = -1);
										num4 = 2;
										continue;
									case 40:
										_003C_003Eu__4 = default;
										num4 = 54;
										continue;
									case 21:
										if (!awaiter.IsCompleted)
										{
											num4 = 52;
											continue;
										}
										goto case 2;
									case 24:
										_003C_003Eu__3 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									case 13:
										goto IL_045f;
									case 1:
										goto IL_0477;
									case 3:
										return;
									case 41:
										awaiter.GetResult();
										if (!_003ColdPass_003E5__5)
										{
											awaiter2 = _003Csheet_003E5__2.RunAndGetCellResults().GetAwaiter();
											num4 = 31;
											continue;
										}
										goto case 63;
									case 59:
										_003C_003Eu__3 = awaiter;
										num4 = 44;
										continue;
									case 29:
										num2 = (_003C_003E1__state = 3);
										num4 = 8;
										continue;
									case 52:
										num2 = (_003C_003E1__state = 2);
										num4 = 6;
										continue;
									case 54:
										num2 = (_003C_003E1__state = -1);
										goto IL_054a;
									case 17:
										if (result3[circleFixtureToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, circleFixtureToolType.s8hChAhExm)].CellValue.Equals(1.0))
										{
											BxWtHYKNZjiRKj3C1WFM(_003CnewTool_003E5__6, result3);
											num4 = 63;
											continue;
										}
										goto case 63;
									case 51:
										_003C_003Eu__3 = default;
										num4 = 19;
										if (true)
										{
											continue;
										}
										goto IL_05c6;
									case 27:
										goto IL_05c6;
									case 47:
										num2 = (_003C_003E1__state = -1);
										num4 = 53;
										continue;
									case 39:
										num2 = (_003C_003E1__state = 0);
										_003C_003Eu__1 = awaiter4;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										num4 = 37;
										continue;
									case 15:
										return;
									case 8:
										goto IL_063a;
									case 55:
										result3 = awaiter2.GetResult();
										num4 = 17;
										continue;
									case 61:
										_003C_003Eu__3 = default;
										HI7FMyKNI33dOMU6Csav();
										if (a029WPKNDK6Bg4ihEqQx())
										{
											num4 = 36;
											if (0 == 0)
											{
												continue;
											}
											goto case 32;
										}
										num4 = 58;
										continue;
									case 33:
										if (!awaiter4.IsCompleted)
										{
											num4 = 39;
											continue;
										}
										goto case 7;
									case 57:
										_003C_003Eu__3 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									case 38:
										awaiter5.GetResult();
										num4 = 20;
										if (!a029WPKNDK6Bg4ihEqQx())
										{
											continue;
										}
										goto case 44;
									case 44:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									default:
										num4 = 3;
										if (true)
										{
											continue;
										}
										goto case 25;
									case 25:
										num2 = (_003C_003E1__state = 5);
										num4 = 12;
										continue;
									case 4:
										_003C_003Eu__3 = default;
										num2 = (_003C_003E1__state = -1);
										num4 = 41;
										if (HI7FMyKNI33dOMU6Csav())
										{
											continue;
										}
										goto case 53;
									case 53:
										awaiter.GetResult();
										num4 = 14;
										continue;
									case 30:
										if (!awaiter.IsCompleted)
										{
											num4 = 43;
											continue;
										}
										goto case 41;
									case 9:
										num2 = (_003C_003E1__state = -1);
										num4 = 55;
										continue;
									case 28:
										_003CpasteRange_003E5__3 = result2;
										awaiter5 = _003Csheet_003E5__2.PutCellExpressionAsync(circleFixtureToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, circleFixtureToolType.oySCJ3uuP6), circleFixtureToolType.InputImageLinks[MD1fo0KNf6tad4LJjWD1(circleFixtureToolType)].Expression).GetAwaiter();
										num4 = 46;
										if (true)
										{
											continue;
										}
										goto case 7;
									case 7:
										result2 = awaiter4.GetResult();
										num4 = 28;
										continue;
									case 11:
										if (awaiter3.IsCompleted)
										{
											goto IL_054a;
										}
										num4 = 29;
										if (true)
										{
											continue;
										}
										goto case 23;
									case 23:
									{
										CvsCellLocation cellLocation = circleFixtureToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, circleFixtureToolType.aUHCrTTfBp);
										awaiter = ((Task)bKetgFKNlVdlOJu867m1(INIkUcKNiYB8q5rTTcyY(circleFixtureToolType), text, cellLocation)).GetAwaiter();
										num4 = 21;
										if (true)
										{
											continue;
										}
										goto case 6;
									}
									case 6:
										_003C_003Eu__3 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									case 22:
										_003C_003Eu__2 = awaiter5;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
										num4 = 45;
										continue;
									case 63:
										{
											result = _003CnewTool_003E5__6;
											goto end_IL_0090;
										}
										IL_054a:
										awaiter3.GetResult();
										num4 = 10;
										continue;
									}
									break;
								}
								goto IL_00df;
								IL_063a:
								_003C_003Eu__4 = awaiter3;
								num4 = 34;
								goto IL_070c;
								IL_045f:
								if (awaiter2.IsCompleted)
								{
									goto IL_05c6;
								}
								num4 = 25;
								if (1 == 0)
								{
									goto IL_0477;
								}
								goto IL_070c;
								IL_00df:
								num2 = (_003C_003E1__state = -1);
								num4 = 38;
								goto IL_070c;
								IL_0477:
								_003ColdPass_003E5__5 = RRUPtNKNvJgv2XHHN2KH(DK0BQuKNsEhJLXN9f1Yi(result3, circleFixtureToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, circleFixtureToolType.s8hChAhExm))).Equals(1.0);
								num4 = 32;
								if (!HI7FMyKNI33dOMU6Csav())
								{
									return;
								}
								goto IL_070c;
								IL_05c6:
								result3 = awaiter2.GetResult();
								num4 = 1;
								goto IL_070c;
								end_IL_0090:
								break;
							}
						}
						catch (object obj)
						{
							_003C_003E7__wrap3 = obj;
							num3 = 1;
							goto IL_09b2;
						}
						goto end_IL_0057;
						IL_09b2:
						if (num3 == 1)
						{
							awaiter = efH0SGKNgyhw7bUeRaQt(circleFixtureToolType.CleanUpPastedToolOnFailedAdd(_003CpasteRange_003E5__3));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 9);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0a1a;
						}
						goto IL_0a43;
						IL_0a1a:
						awaiter.GetResult();
						sBO8nCKNbYl0EfSJLwLu(tNDRllKNBO4er5eHBbyU((_003C_003E7__wrap3 as Exception) ?? throw _003C_003E7__wrap3));
						goto IL_0a43;
						IL_0a43:
						_003C_003E7__wrap3 = null;
						_003Csheet_003E5__2 = null;
						_003CpasteRange_003E5__3 = default;
						end_IL_0057:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Csheet_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 3;
				default:
					num = 3;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					break;
				case 3:
					_003Csheet_003E5__2 = null;
					num = 5;
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_002e;
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
		internal static object INIkUcKNiYB8q5rTTcyY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UFdIB8KNnuXcyEffyr4D(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SYcBUFKNVQrkWJDio1yf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int MD1fo0KNf6tad4LJjWD1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).InputImageIndex;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XhWem4KNdkZj7VEs55b3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bKetgFKNlVdlOJu867m1(object P_0, object P_1, CvsCellLocation P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return InputFixtureViewModel.YnAyJgATSB((InspectStepViewModel)P_0, (string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter efH0SGKNgyhw7bUeRaQt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DK0BQuKNsEhJLXN9f1Yi(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RRUPtNKNvJgv2XHHN2KH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).CellValue;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object J9efkNKNrOBYh9L4YLFH(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rK2XrGKNPphl8D0yrSRJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FindCircleTool)P_0).AcceptThreshold;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BxWtHYKNZjiRKj3C1WFM(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EzTool)P_0).OnResultsChangedTool((CvsCellCollection)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tNDRllKNBO4er5eHBbyU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void sBO8nCKNbYl0EfSJLwLu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HI7FMyKNI33dOMU6Csav()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool a029WPKNDK6Bg4ihEqQx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly Guid[] pfpCLjO7KX;

	private readonly CvsCellLocation oySCJ3uuP6;

	private readonly CvsCellLocation UC9C9ao5Jo;

	private readonly CvsCellLocation aUHCrTTfBp;

	private readonly CvsCellLocation s8hChAhExm;

	private int mbtC865nDY;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return pfpCLjO7KX;
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
			return (string)JIgIUbWAN4wyIlEiRaC();
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
			return (string)RPoocWWR00d0PpT0YgF();
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
			return XAMLGraphicKeys.Tools_CircleFixtureIcon;
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
			return XAMLGraphicKeys.Tools_CircleFixtureIcon;
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
				(string)nHd65iWWb8291GLZi6X(),
				(string)QHK3MlWT4SpIIdeA9Nf()
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
			return mbtC865nDY;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref mbtC865nDY, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(3256));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CircleFixtureToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		SnippetLocalizer snippetLocalizer = default;
		while (true)
		{
			switch (num)
			{
			case 6:
			case 9:
				AddSnippet(_pasteObject, snippetLocalizer);
				num = 12;
				if (0 == 0)
				{
					break;
				}
				goto case 11;
			case 11:
				snippetLocalizer.ExcludedStrings.Add((string)RDke4FWCrLUxmeaq1EH(24288));
				goto case 6;
			case 3:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 1;
				break;
			case 5:
				aUHCrTTfBp = _pasteObject.GetCellOffset((string)RDke4FWCrLUxmeaq1EH(6522));
				goto case 2;
			default:
				num = 2;
				break;
			case 2:
				UC9C9ao5Jo = _pasteObject.GetCellOffset((string)RDke4FWCrLUxmeaq1EH(25878));
				s8hChAhExm = _pasteObject.GetCellOffset((string)RDke4FWCrLUxmeaq1EH(24546));
				num = 8;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
				base._002Ector();
				num = 7;
				break;
			case 4:
			case 10:
				oySCJ3uuP6 = _pasteObject.GetCellOffset(CdQUGaROfy7He9T0foW.KbIzwHEDLa(4928));
				num = 5;
				break;
			case 7:
				_pasteObject = PasteBuffer.FromBytes((byte[])gWFLpEW6ukTr9S8x7W4());
				B8dJmoW3vaG7EqZggbl();
				if (q8dWfXWj3nJ7VoAa4jS())
				{
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 3;
				}
				num = 10;
				if (q8dWfXWj3nJ7VoAa4jS())
				{
				}
				break;
			case 1:
				mbtC865nDY = 300;
				num = 0;
				break;
			case 8:
				snippetLocalizer = EzSnippetType.CreateDefaultSnippetLocalizer();
				num = 11;
				break;
			case 12:
				return;
			}
		}
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
	internal override Task<EzTool> AddTool(CvsDisplayableAnnulus editableAnnulus, CvsCellCollection cells = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddTool_003Ed__24 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.editableAnnulus = editableAnnulus;
		stateMachine.cells = cells;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CircleFixtureToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		pfpCLjO7KX = new Guid[1]
		{
			new Guid(CdQUGaROfy7He9T0foW.KbIzwHEDLa(27518))
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gWFLpEW6ukTr9S8x7W4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.CircleFixture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RDke4FWCrLUxmeaq1EH(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool B8dJmoW3vaG7EqZggbl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool q8dWfXWj3nJ7VoAa4jS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JIgIUbWAN4wyIlEiRaC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.BkCBrdnlQH();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RPoocWWR00d0PpT0YgF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.yAeB8QaoR7();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nHd65iWWb8291GLZi6X()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QHK3MlWT4SpIIdeA9Nf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.F0Z0bUM6Xp();
	}
}
