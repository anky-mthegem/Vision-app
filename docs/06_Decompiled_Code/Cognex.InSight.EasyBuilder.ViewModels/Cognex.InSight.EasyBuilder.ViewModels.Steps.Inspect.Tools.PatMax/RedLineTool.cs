using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Composition;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.Common.PropertyCommitters;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Image;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.InSight.Undo;
using Cognex.Mvvm;
using Newtonsoft.Json.Linq;
using wjIG9PrX4DALC214Qh;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.PatMax;

[Export(typeof(RedLineTool))]
public class RedLineTool : EzRangeTool<EditIntViewModel>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInternalPostParse_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RedLineTool _003C_003E4__this;

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
			int num2 = default;
			RedLineTool redLineTool = default;
			TaskAwaiter awaiter = default;
			int num4 = default;
			FixtureViewModel item = default;
			string text2 = default;
			string text = default;
			CvsCellLocation cvsCellLocation = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (gHLYp4K6AeNLvFYGZ5ng())
					{
					}
					break;
				case 5:
					num2 = _003C_003E1__state;
					gHLYp4K6AeNLvFYGZ5ng();
					num = ((!zQnynpK6CwlJ1Dp2Jmiq()) ? 4 : 3);
					break;
				case 1:
				case 3:
					redLineTool = _003C_003E4__this;
					goto case 2;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							redLineTool.FixtureArray = new FixtureArrayViewModel(redLineTool.InSight, cells, redLineTool.Name + CdQUGaROfy7He9T0foW.KbIzwHEDLa(50158), redLineTool.VSkcA9JSMV.ToString(absoluteRow: true, absoluteColumn: true), (string)WyhMrRK6RaPcPeeWI7tp());
							num3 = 13;
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
							case 17:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 10:
							case 12:
								if (num4 >= redLineTool.NumberToFind.Value)
								{
									num3 = 0;
									continue;
								}
								item = new FixtureViewModel(redLineTool.InSight, cells, string.Format((string)EOhmygK6TBso5IrNB8gA(20586), BC94J4K6yKMtjTc4MEZE(redLineTool), EOhmygK6TBso5IrNB8gA(1104), YyjRKgK60RjmPGy2SMsn(), num4), (string)mKVOC6K6FA9MGJsgKMxC(EOhmygK6TBso5IrNB8gA(20614), new object[7] { text2, text, num4, text, num4, text, num4 }), string.Format((string)EOhmygK6TBso5IrNB8gA(20738), num4));
								num3 = 1;
								continue;
							case 16:
								num2 = (_003C_003E1__state = 0);
								num3 = 17;
								if (zQnynpK6CwlJ1Dp2Jmiq())
								{
									continue;
								}
								goto case 5;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 4:
								if (redLineTool.NumberToFind != null)
								{
									gHLYp4K6AeNLvFYGZ5ng();
									if (zQnynpK6CwlJ1Dp2Jmiq())
									{
										num3 = 15;
										if (zQnynpK6CwlJ1Dp2Jmiq())
										{
											continue;
										}
										goto case 2;
									}
									num3 = 14;
									if (0 == 0)
									{
										continue;
									}
									goto case 9;
								}
								goto case 0;
							case 2:
							case 15:
								if (redLineTool.PixelPatterns != null)
								{
									cvsCellLocation = nMflVKK6WtLgZgAvG5Ck(redLineTool.InputImage);
									goto case 3;
								}
								goto case 0;
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 16;
									continue;
								}
								break;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
								if (!gHLYp4K6AeNLvFYGZ5ng())
								{
									continue;
								}
								goto case 7;
							case 7:
								num4++;
								num3 = 10;
								continue;
							case 8:
								num4 = 0;
								num3 = 12;
								continue;
							case 3:
							case 14:
								text2 = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
								cvsCellLocation = redLineTool.PixelPatterns.CellLocation;
								num3 = 11;
								continue;
							case 0:
								awaiter = yW7wEHK6ML5jDrulDx8k(redLineTool.FFVbeM6uGr(cells));
								num3 = 9;
								if (true)
								{
									continue;
								}
								goto case 11;
							case 11:
								text = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
								num3 = 8;
								continue;
							case 1:
								redLineTool.FixtureArray.Fixtures.Add(item);
								goto case 7;
							default:
								num3 = 7;
								continue;
							case 13:
								redLineTool.AddProperty(redLineTool.FixtureArray);
								num3 = 4;
								if (gHLYp4K6AeNLvFYGZ5ng())
								{
								}
								continue;
							case 18:
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
		internal static object WyhMrRK6RaPcPeeWI7tp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.PX6tQyjxbN();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation nMflVKK6WtLgZgAvG5Ck(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EOhmygK6TBso5IrNB8gA(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BC94J4K6yKMtjTc4MEZE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YyjRKgK60RjmPGy2SMsn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EZBSnippetStrings.OutputFixture;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mKVOC6K6FA9MGJsgKMxC(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, (object[])P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter yW7wEHK6ML5jDrulDx8k(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zQnynpK6CwlJ1Dp2Jmiq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gHLYp4K6AeNLvFYGZ5ng()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct Pe1VMqRyQRFLvX2Lk2J : IAsyncStateMachine
		{
			public int AMu1VSX41W;

			public AsyncVoidMethodBuilder Io41LPhd0A;

			public _003C_003Ec__DisplayClass17_0 A3N1JgkKGg;

			private TaskAwaiter<IUndoAction> SCJ195rDPF;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				y0tL9u5ZffTA8eObF2WV();
				int num = ((!IcsghA5ZVRY4QgwkfZIB()) ? 5 : 3);
				_003C_003Ec__DisplayClass17_0 obj = default;
				int num2 = default;
				while (true)
				{
					switch (num)
					{
					case 4:
						obj = A3N1JgkKGg;
						goto case 2;
					case 2:
					case 5:
						try
						{
							TaskAwaiter<IUndoAction> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = ((InputStructureViewModel)wYHuhC5ZdXRNYxqBuA4g(obj.t)).ResetToDefault(false).GetAwaiter();
								y0tL9u5ZffTA8eObF2WV();
								num3 = ((!IcsghA5ZVRY4QgwkfZIB()) ? 7 : 6);
							}
							else
							{
								awaiter = SCJ195rDPF;
								num3 = 8;
							}
							while (true)
							{
								switch (num3)
								{
								case 1:
									num2 = (AMu1VSX41W = 0);
									goto case 2;
								case 4:
									return;
								case 8:
									SCJ195rDPF = default;
									num3 = 3;
									continue;
								case 5:
									Io41LPhd0A.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 4;
									continue;
								case 3:
									num2 = (AMu1VSX41W = -1);
									num3 = 9;
									continue;
								case 0:
								case 6:
									if (!awaiter.IsCompleted)
									{
										num3 = 1;
										continue;
									}
									break;
								case 2:
								case 7:
									SCJ195rDPF = awaiter;
									num3 = 5;
									continue;
								case 9:
									break;
								}
								break;
							}
							awaiter.GetResult();
						}
						catch (Exception exception)
						{
							AMu1VSX41W = -2;
							Io41LPhd0A.SetException(exception);
							return;
						}
						AMu1VSX41W = -2;
						goto case 1;
					default:
						num = 1;
						if (!y0tL9u5ZffTA8eObF2WV())
						{
							continue;
						}
						goto case 1;
					case 1:
						Io41LPhd0A.SetResult();
						num = 6;
						if (IcsghA5ZVRY4QgwkfZIB())
						{
							continue;
						}
						break;
					case 0:
					case 3:
						break;
					case 6:
						return;
					}
					num2 = AMu1VSX41W;
					num = 4;
				}
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				Io41LPhd0A.SetStateMachine(P_0);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object wYHuhC5ZdXRNYxqBuA4g(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((EzTool)P_0).InputFixture;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool IcsghA5ZVRY4QgwkfZIB()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool y0tL9u5ZffTA8eObF2WV()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		public EzTool t;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass17_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			GJf7ecK6HivCcTe6YyHT();
			AG7ongK6xHGwEGDnedWq(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(Pe1VMqRyQRFLvX2Lk2J))]
		internal void _003CNumberToFind_PropertyChanged_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			Pe1VMqRyQRFLvX2Lk2J stateMachine = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					stateMachine.AMu1VSX41W = -1;
					goto default;
				default:
					stateMachine.Io41LPhd0A.Start(ref stateMachine);
					num = 6;
					break;
				case 1:
				case 5:
					stateMachine.A3N1JgkKGg = this;
					num = 4;
					if (svy4TYK6UejRVtdmlRHO())
					{
					}
					break;
				case 0:
					stateMachine.Io41LPhd0A = TKhOgdK6mIn1dKRfMIMH();
					svy4TYK6UejRVtdmlRHO();
					num = (xhQqusK6YYTZbV8St1FC() ? 5 : 2);
					break;
				case 6:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GJf7ecK6HivCcTe6YyHT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void AG7ongK6xHGwEGDnedWq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xhQqusK6YYTZbV8St1FC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool svy4TYK6UejRVtdmlRHO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AsyncVoidMethodBuilder TKhOgdK6mIn1dKRfMIMH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return AsyncVoidMethodBuilder.Create();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CShiftEditGraphics_003Ed__113 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RedLineTool _003C_003E4__this;

		public int delta;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (Krn27MK6Q7TtnDu9vvyl())
			{
				num = 5;
			}
			else
			{
				num = 4;
				if (false)
				{
					goto IL_01c9;
				}
			}
			goto IL_0185;
			IL_0185:
			RedLineTool redLineTool = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					redLineTool = _003C_003E4__this;
					num = 2;
					continue;
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = redLineTool.SearchRegion.Shift(delta).GetAwaiter();
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 4;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								continue;
							case 2:
							case 6:
								_003C_003Eu__1 = awaiter;
								goto case 0;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								break;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 5:
								num2 = (_003C_003E1__state = 0);
								oYCcD5K6Nfj3GMiTh5Ve();
								num3 = (Krn27MK6Q7TtnDu9vvyl() ? 6 : 0);
								continue;
							case 8:
								return;
							case 4:
								_003C_003Eu__1 = default;
								num3 = 1;
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
					break;
				default:
					num = 3;
					continue;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 3:
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_01c9;
			IL_01c9:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (1 == 0)
			{
				return;
			}
			goto IL_0185;
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
		internal static bool Krn27MK6Q7TtnDu9vvyl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oYCcD5K6Nfj3GMiTh5Ve()
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
	private struct _003COnSetRange_003Ed__115 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RedLineTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			RedLineTool redLineTool = default;
			int num2 = default;
			int num3 = default;
			TaskAwaiter awaiter = default;
			UndoSetRange<int> action = default;
			int newMax = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					redLineTool = _003C_003E4__this;
					goto case 2;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (bPdcx7K62973knOHjfh4())
					{
						break;
					}
					goto case 2;
				case 2:
				case 5:
					try
					{
						int num4;
						if (num2 != 0)
						{
							num3 = UNC57UK61ByAxiVNVoh3(redLineTool.NumberFound);
							num4 = 10;
							if (false)
							{
								goto IL_0068;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num4 = 7;
							if (N0vr3mK6cFfX5e12Wn5J())
							{
								goto IL_0104;
							}
						}
						goto IL_0082;
						IL_0104:
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 0);
							goto IL_0068;
						}
						goto IL_01e2;
						IL_01e2:
						awaiter.GetResult();
						goto end_IL_004a;
						IL_0068:
						_003C_003Eu__1 = awaiter;
						goto IL_0129;
						IL_0129:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num4 = 1;
						goto IL_0082;
						IL_0082:
						while (true)
						{
							switch (num4)
							{
							case 4:
							case 8:
								break;
							default:
								num4 = 5;
								if (N0vr3mK6cFfX5e12Wn5J())
								{
								}
								continue;
							case 7:
								_003C_003Eu__1 = default;
								num4 = 9;
								if (!N0vr3mK6cFfX5e12Wn5J())
								{
									continue;
								}
								return;
							case 1:
								return;
							case 3:
								goto IL_0104;
							case 5:
								goto IL_0129;
							case 6:
								goto IL_0141;
							case 0:
							case 2:
								awaiter = Cl8FX5K6zJXUWUKup8Qb(((UndoRedoQueue)dV3uBCK6t7bliwjqKiWN(redLineTool.InSight)).AddUndo((IUndoAction)action));
								num4 = 3;
								continue;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num4 = 11;
								if (true)
								{
									continue;
								}
								goto case 10;
							case 10:
								newMax = num3;
								num4 = 6;
								if (!N0vr3mK6cFfX5e12Wn5J())
								{
									continue;
								}
								goto IL_01e2;
							case 11:
								goto IL_01e2;
							}
							break;
							IL_0141:
							action = new UndoSetRange<int>(redLineTool.Parent, (string)mjGrWwK6u6CsgnOS9f46(redLineTool), (string)zRh2y8K6hMvPl2j23SSQ(redLineTool.Min), redLineTool.Max.CellName, redLineTool.Min.Value, redLineTool.Max.Value, num3, newMax);
							_ = 0;
							num4 = ((!bPdcx7K62973knOHjfh4()) ? 8 : 0);
						}
						goto IL_0068;
						end_IL_004a:;
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
					break;
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					if (!bPdcx7K62973knOHjfh4())
					{
						num = 5;
						break;
					}
					num = 3;
					if (false)
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
		internal static int UNC57UK61ByAxiVNVoh3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IntViewModel)P_0).Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mjGrWwK6u6CsgnOS9f46(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zRh2y8K6hMvPl2j23SSQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dV3uBCK6t7bliwjqKiWN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Cl8FX5K6zJXUWUKup8Qb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bPdcx7K62973knOHjfh4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool N0vr3mK6cFfX5e12Wn5J()
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
	private struct _003CTrain_003Ed__121 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RedLineTool _003C_003E4__this;

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
			RedLineTool redLineTool = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					ETxDmjKCLy455TnwB1Ih();
					if (!pF8aurKCKWX21vsZ0bXD())
					{
						num = 2;
						if (!pF8aurKCKWX21vsZ0bXD())
						{
							continue;
						}
						goto case 4;
					}
					num = 0;
					continue;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 6;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 8;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
							if (!ETxDmjKCLy455TnwB1Ih())
							{
								goto IL_0072;
							}
						}
						goto IL_00fa;
						IL_00fa:
						while (true)
						{
							switch (num3)
							{
							case 16:
								return;
							case 5:
							case 11:
								break;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 10;
								continue;
							case 9:
							case 15:
								awaiter.GetResult();
								num3 = 18;
								if (0 == 0)
								{
									continue;
								}
								goto case 17;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 16;
								if (true)
								{
									continue;
								}
								goto case 7;
							case 7:
								awaiter.GetResult();
								goto case 17;
							default:
								num3 = 17;
								continue;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 13;
								if (pF8aurKCKWX21vsZ0bXD())
								{
								}
								continue;
							case 2:
								num2 = (_003C_003E1__state = 1);
								pF8aurKCKWX21vsZ0bXD();
								num3 = ((!ETxDmjKCLy455TnwB1Ih()) ? 9 : 5);
								continue;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 13:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								continue;
							case 14:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								goto case 9;
							case 10:
								num2 = (_003C_003E1__state = -1);
								goto case 9;
							case 0:
								_003C_003Eu__1 = default;
								num3 = 12;
								continue;
							case 6:
							{
								UndoTrainPattern undoTrainPattern = new UndoTrainPattern(redLineTool.InSight, (string)A9VOyjKC5wdJP0DA4q76(redLineTool.TrainButtonCommand), redLineTool.xQPc7xnFMi, redLineTool.tdHcdclNtj, redLineTool.TrainButtonCommand);
								if (!redLineTool.IsInitialized)
								{
									awaiter = fIlFJSKCadP6DqdNAYWX(GlGocsKCeS9kGDZEJchP(undoTrainPattern));
									num3 = 14;
									continue;
								}
								awaiter = fIlFJSKCadP6DqdNAYWX(jkCjNLKCJk9LYmbvvZKO(oWCb84KCwUqRDNiOAmw5(redLineTool.InSight), undoTrainPattern));
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 7;
							}
							case 12:
								num2 = (_003C_003E1__state = -1);
								num3 = 7;
								if (true)
								{
									continue;
								}
								goto case 17;
							case 17:
							case 18:
								HGiB3tKCOum7kIPO7oMM(redLineTool.ShowModelRegion, false);
								goto end_IL_00fa;
							}
							goto IL_0072;
							continue;
							end_IL_00fa:
							break;
						}
						goto end_IL_003f;
						IL_0072:
						_003C_003Eu__1 = awaiter;
						num3 = 4;
						goto IL_00fa;
						end_IL_003f:;
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
				case 2:
					redLineTool = _003C_003E4__this;
					num = 4;
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
		internal static object A9VOyjKC5wdJP0DA4q76(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object oWCb84KCwUqRDNiOAmw5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jkCjNLKCJk9LYmbvvZKO(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter fIlFJSKCadP6DqdNAYWX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GlGocsKCeS9kGDZEJchP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoTrainPattern)P_0).Do();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void HGiB3tKCOum7kIPO7oMM(object P_0, bool value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CheckBoxViewModel)P_0).Value = value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ETxDmjKCLy455TnwB1Ih()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pF8aurKCKWX21vsZ0bXD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass122_0<T>
	{
		[StructLayout(LayoutKind.Auto)]
		private struct LRkPd3Rb3ZW2isXjlgt : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public _003C_003Ec__DisplayClass122_0<T> _003C_003E4__this;

			public T oldValue;

			public T newValue;

			private TaskAwaiter _003C_003Eu__1;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				_ = 0;
				int num = ((1 == 0) ? 1 : 4);
				int num2 = default;
				string arg = default;
				_003C_003Ec__DisplayClass122_0<T> obj = default;
				TaskAwaiter awaiter = default;
				string text2 = default;
				string text = default;
				string arg2 = default;
				UndoEditCellChange<T> undoEditCellChange = default;
				while (true)
				{
					switch (num)
					{
					case 1:
					case 2:
						try
						{
							int num3;
							if (num2 != 0)
							{
								arg = obj.valueFormatter(oldValue);
								num3 = 6;
								goto IL_0132;
							}
							awaiter = _003C_003Eu__1;
							goto IL_005c;
							IL_005c:
							_003C_003Eu__1 = default;
							num3 = 9;
							goto IL_0132;
							IL_0132:
							while (true)
							{
								switch (num3)
								{
								case 11:
									text2 = string.Format(Resources.pd1hOYqP56(), text, arg, arg2);
									num3 = 5;
									continue;
								case 7:
								case 8:
									break;
								case 0:
									num2 = (_003C_003E1__state = 0);
									num3 = 4;
									continue;
								case 5:
									undoEditCellChange = new UndoEditCellChange<T>(obj._003C_003E4__this.InSight, text, oldValue, newValue, text2);
									_ = 0;
									num3 = ((1 == 0) ? 7 : 2);
									continue;
								case 4:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 1;
									continue;
								case 1:
									return;
								case 2:
								case 3:
									awaiter = obj._003C_003E4__this.n0YbxNVNdS(undoEditCellChange).GetAwaiter();
									num3 = 10;
									continue;
								case 10:
									if (!awaiter.IsCompleted)
									{
										goto case 0;
									}
									goto case 12;
								default:
									num3 = 0;
									continue;
								case 6:
									arg2 = obj.valueFormatter(newValue);
									text = obj.cellNameProvider();
									num3 = 11;
									continue;
								case 9:
									num2 = (_003C_003E1__state = -1);
									num3 = 12;
									continue;
								case 12:
									awaiter.GetResult();
									goto end_IL_0132;
								}
								goto IL_005c;
								continue;
								end_IL_0132:
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
						break;
					default:
						num = 5;
						continue;
					case 0:
					case 4:
						num2 = _003C_003E1__state;
						num = 3;
						continue;
					case 5:
						break;
					case 3:
						obj = _003C_003E4__this;
						goto case 1;
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
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				_003C_003Et__builder.SetStateMachine(P_0);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool x6NEfa5ZlRJgqqyBsY4m()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool AmRRV25Zgk9567v9XbKh()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		public Func<T, string> valueFormatter;

		public Func<string> cellNameProvider;

		public RedLineTool _003C_003E4__this;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass122_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass122_0<>.LRkPd3Rb3ZW2isXjlgt))]
		internal Task _003CMakeTrainParamPropertyCommitter_003Eb__1(T newValue, T oldValue)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			LRkPd3Rb3ZW2isXjlgt stateMachine = default;
			stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
			stateMachine._003C_003E4__this = this;
			stateMachine.newValue = newValue;
			stateMachine.oldValue = oldValue;
			stateMachine._003C_003E1__state = -1;
			stateMachine._003C_003Et__builder.Start(ref stateMachine);
			return stateMachine._003C_003Et__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool df9HVHKCIv4uAiHqn1Py()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gPYvW0KCDpcKrSIfMR19()
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
	private struct _003CUpdateTrainParamAndRetrainWithExistingImage_003Ed__124 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RedLineTool _003C_003E4__this;

		public IUndoAction undoEditCellChange;

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
			if (!vJq3RmKCfpGmyEHZryM5())
			{
				num = 2;
				if (vJq3RmKCfpGmyEHZryM5())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_02ba;
			IL_02fc:
			RedLineTool redLineTool = _003C_003E4__this;
			num = 4;
			if (!bkIRhCKCVMrGXNw8uCaM())
			{
				return;
			}
			goto IL_02ba;
			IL_02ba:
			int num2 = default;
			TaskAwaiter awaiter = default;
			xb9yB2SHpkLOLZYMq3 xb9yB2SHpkLOLZYMq4 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					break;
				case 4:
					try
					{
						_ = 1;
						try
						{
							int num3;
							if (num2 != 0)
							{
								if (num2 != 1)
								{
									num3 = 7;
									if (vJq3RmKCfpGmyEHZryM5())
									{
										goto IL_0063;
									}
								}
								else
								{
									awaiter = _003C_003Eu__1;
									num3 = 1;
									if (false)
									{
										return;
									}
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 8;
							}
							goto IL_020c;
							IL_0192:
							num2 = (_003C_003E1__state = 1);
							num3 = 3;
							goto IL_020c;
							IL_0063:
							if (!awaiter.IsCompleted)
							{
								goto IL_0192;
							}
							goto IL_025f;
							IL_025f:
							awaiter.GetResult();
							goto end_IL_0046;
							IL_020c:
							while (true)
							{
								switch (num3)
								{
								case 6:
									break;
								case 8:
									goto IL_007f;
								case 5:
								case 12:
									num2 = (_003C_003E1__state = -1);
									goto IL_00ae;
								case 7:
									awaiter = ixjjFgKCla8ekpxRHIiH(DaU7HSKCd6VUMNcNTRZu(redLineTool.jPhcyoPG3q));
									num3 = 2;
									continue;
								case 14:
									num2 = (_003C_003E1__state = -1);
									num3 = 16;
									continue;
								case 3:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 0;
									continue;
								case 13:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 4;
									continue;
								case 2:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 0);
										num3 = 13;
										continue;
									}
									goto IL_00ae;
								case 1:
									_003C_003Eu__1 = default;
									num3 = 14;
									if (0 == 0)
									{
										continue;
									}
									return;
								case 0:
									return;
								case 4:
									return;
								case 9:
								case 15:
									goto IL_0192;
								case 10:
									awaiter = ixjjFgKCla8ekpxRHIiH(nnmIxDKCvNNly78qENPC(Yvw7NCKCsIm8ijCthlSc(redLineTool.InSight), xb9yB2SHpkLOLZYMq4));
									num3 = 6;
									continue;
								case 11:
									xb9yB2SHpkLOLZYMq4 = new xb9yB2SHpkLOLZYMq3(new UndoTrainPattern(redLineTool.InSight, (string)jAVMrQKCgc0LY2E8pvym(redLineTool.RetrainWithExistingImageButtonCommand), redLineTool.xQPc7xnFMi, redLineTool.tdHcdclNtj, redLineTool.RetrainWithExistingImageButtonCommand), undoEditCellChange);
									goto case 10;
								default:
									num3 = 10;
									continue;
								case 16:
									goto IL_025f;
									IL_00ae:
									awaiter.GetResult();
									num3 = 11;
									if (true)
									{
										continue;
									}
									goto case 7;
								}
								break;
								IL_007f:
								_003C_003Eu__1 = default;
								bkIRhCKCVMrGXNw8uCaM();
								num3 = ((!vJq3RmKCfpGmyEHZryM5()) ? 12 : 15);
							}
							goto IL_0063;
							end_IL_0046:;
						}
						finally
						{
							if (num2 < 0)
							{
								Kj869oKCrFd3oOHZ4Pr7(redLineTool.jPhcyoPG3q);
							}
						}
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
					if (0 == 0)
					{
						continue;
					}
					goto case 5;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 1:
				case 3:
					goto IL_02fc;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			num2 = _003C_003E1__state;
			goto IL_02fc;
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
		internal static object DaU7HSKCd6VUMNcNTRZu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SemaphoreSlim)P_0).WaitAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter ixjjFgKCla8ekpxRHIiH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jAVMrQKCgc0LY2E8pvym(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Yvw7NCKCsIm8ijCthlSc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nnmIxDKCvNNly78qENPC(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int Kj869oKCrFd3oOHZ4Pr7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SemaphoreSlim)P_0).Release();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bkIRhCKCVMrGXNw8uCaM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vJq3RmKCfpGmyEHZryM5()
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
	private struct _003CWriteFixturedGraphics_003Ed__125 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RedLineTool _003C_003E4__this;

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
			int num2 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter = default;
			TaskAwaiter awaiter2 = default;
			RedLineTool redLineTool = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
					num2 = _003C_003E1__state;
					l5n9GhKCZHW2vIiCpdCJ();
					if (PTmfCNKCPOCSWKTDhJ49())
					{
						num = 5;
						if (true)
						{
							break;
						}
						goto case 4;
					}
					num = 0;
					break;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 13;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 15;
								if (l5n9GhKCZHW2vIiCpdCJ())
								{
								}
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 2;
						}
						while (true)
						{
							switch (num3)
							{
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 12:
								awaiter2.GetResult();
								goto default;
							case 8:
								return;
							case 3:
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 11;
								if (!l5n9GhKCZHW2vIiCpdCJ())
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								continue;
							case 14:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 8;
								continue;
							default:
								awaiter = redLineTool.InSight.CogSocket.Sheet.RunAsync(fireSheetUpdated: false).GetAwaiter();
								num3 = 6;
								if (PTmfCNKCPOCSWKTDhJ49())
								{
									continue;
								}
								goto case 13;
							case 13:
								awaiter2 = qm5wtvKCG7H3fMwnmM3U(n2gQK2KCbuVlLD54TYXk(redLineTool.InSight, PxEwysKCBlZtIMOQoi3m(redLineTool.SearchRegion), redLineTool.SearchRegion.Graphic));
								PTmfCNKCPOCSWKTDhJ49();
								if (l5n9GhKCZHW2vIiCpdCJ())
								{
									num3 = 4;
									continue;
								}
								num3 = 5;
								if (l5n9GhKCZHW2vIiCpdCJ())
								{
								}
								continue;
							case 10:
								num2 = (_003C_003E1__state = 1);
								num3 = 3;
								continue;
							case 15:
								_003C_003Eu__2 = default;
								num3 = 9;
								continue;
							case 11:
								return;
							case 1:
							case 5:
								if (!awaiter2.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								goto case 12;
							case 0:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								num3 = 14;
								if (PTmfCNKCPOCSWKTDhJ49())
								{
									continue;
								}
								goto case 6;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 10;
									continue;
								}
								break;
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
				case 1:
				case 5:
					redLineTool = _003C_003E4__this;
					num = 4;
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
		internal static CvsCellLocation PxEwysKCBlZtIMOQoi3m(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object n2gQK2KCbuVlLD54TYXk(object P_0, CvsCellLocation loc, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter qm5wtvKCG7H3fMwnmM3U(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PTmfCNKCPOCSWKTDhJ49()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool l5n9GhKCZHW2vIiCpdCJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CvsCellLocation xQPc7xnFMi;

	private CvsCellLocation YFHcNwgQx9;

	private CvsCellLocation VSkcA9JSMV;

	private CvsCellLocation tdHcdclNtj;

	private BitmapImage rwGc6LXLdC;

	private bool v94cuIV23y;

	private readonly string lHOcF8gQJr;

	[CompilerGenerated]
	private PatternsViewModel dbUcX6tHx8;

	[CompilerGenerated]
	private PatternsViewModel pi8coy3VJ2;

	[CompilerGenerated]
	private FixtureArrayViewModel yX9cSWrplD;

	[CompilerGenerated]
	private EditIntViewModel A5LcD27K1T;

	[CompilerGenerated]
	private EditIntViewModel sdRc3h0QRD;

	[CompilerGenerated]
	private EditIntViewModel vvNcIT40U9;

	[CompilerGenerated]
	private EditIntViewModel O81cfPdFA0;

	[CompilerGenerated]
	private EditIntViewModel HN7cEvp25j;

	[CompilerGenerated]
	private ButtonViewModel HsBcbGNVon;

	[CompilerGenerated]
	private ButtonViewModel ioEccYoGlp;

	[CompilerGenerated]
	private BoolViewModel nyXcQVAL7E;

	[CompilerGenerated]
	private CheckBoxViewModel QO7cgX3UnT;

	[CompilerGenerated]
	private EditIntViewModel M9fcMXYWhu;

	[CompilerGenerated]
	private IntViewModel ljRcR70v3l;

	[CompilerGenerated]
	private FloatViewModel coSc4Ae1P7;

	[CompilerGenerated]
	private EditCompositeRegionViewModel bwkclqRc6T;

	[CompilerGenerated]
	private EditCompositeRegionViewModel CNVcTlVlTp;

	[CompilerGenerated]
	private CheckBoxViewModel b7LcWDOU9f;

	[CompilerGenerated]
	private CheckBoxViewModel kAscjY2GFS;

	[CompilerGenerated]
	private CheckBoxViewModel SfccCNwfQA;

	[CompilerGenerated]
	private EditFloatViewModel muDcOGhiwK;

	[CompilerGenerated]
	private EditFloatViewModel dskcH1WGTc;

	[CompilerGenerated]
	private AsyncDelegateCommand LL2cw5ZDxe;

	private readonly SemaphoreSlim jPhcyoPG3q;

	private string thocxTPheA;

	public CvsCellLocation PatternLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xQPc7xnFMi;
		}
	}

	public CvsCellLocation PatternImageLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tdHcdclNtj;
		}
	}

	public PatternsViewModel Patterns
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return dbUcX6tHx8;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dbUcX6tHx8 = value;
		}
	}

	public PatternsViewModel PixelPatterns
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return pi8coy3VJ2;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			pi8coy3VJ2 = value;
		}
	}

	public FixtureArrayViewModel FixtureArray
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return yX9cSWrplD;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			yX9cSWrplD = value;
		}
	}

	public EditIntViewModel AngleStart
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return A5LcD27K1T;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			A5LcD27K1T = value;
		}
	}

	public EditIntViewModel AngleEnd
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return sdRc3h0QRD;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sdRc3h0QRD = value;
		}
	}

	public EditIntViewModel AcceptThreshold
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return vvNcIT40U9;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			vvNcIT40U9 = value;
		}
	}

	public EditIntViewModel ContrastThreshold
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return O81cfPdFA0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			O81cfPdFA0 = value;
		}
	}

	public EditIntViewModel Timeout
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HN7cEvp25j;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HN7cEvp25j = value;
		}
	}

	public ButtonViewModel TrainButtonCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HsBcbGNVon;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HsBcbGNVon = value;
		}
	}

	public ButtonViewModel RetrainWithExistingImageButtonCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ioEccYoGlp;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ioEccYoGlp = value;
		}
	}

	public BoolViewModel IsTrainingEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return nyXcQVAL7E;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			nyXcQVAL7E = value;
		}
	}

	public CheckBoxViewModel IgnorePolarity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return QO7cgX3UnT;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QO7cgX3UnT = value;
		}
	}

	public EditIntViewModel NumberToFind
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return M9fcMXYWhu;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			M9fcMXYWhu = value;
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
			return ljRcR70v3l;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ljRcR70v3l = value;
		}
	}

	public FloatViewModel Score
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return coSc4Ae1P7;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			coSc4Ae1P7 = value;
		}
	}

	public EditCompositeRegionViewModel SearchRegion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bwkclqRc6T;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bwkclqRc6T = value;
		}
	}

	public EditCompositeRegionViewModel ModelRegion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CNVcTlVlTp;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CNVcTlVlTp = value;
		}
	}

	public CheckBoxViewModel ShowModelRegion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return b7LcWDOU9f;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			b7LcWDOU9f = value;
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
			return kAscjY2GFS;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kAscjY2GFS = value;
		}
	}

	public CheckBoxViewModel AutoGranularity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SfccCNwfQA;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SfccCNwfQA = value;
		}
	}

	public EditFloatViewModel CoarseGranularity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return muDcOGhiwK;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			muDcOGhiwK = value;
		}
	}

	public EditFloatViewModel FineGranularity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return dskcH1WGTc;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dskcH1WGTc = value;
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
			return lHOcF8gQJr;
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
			FloatViewModel score = Score;
			return (string)(((score != null) ? ed4gjdqfApwBXmJQKms(score) : null) ?? base.ResultString);
		}
	}

	public override string ResultStringDetail
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 12;
			int num2 = default;
			object[] array2 = default;
			string text = default;
			string format = default;
			CvsCell cvsCell = default;
			JObject jObject = default;
			object[] array = default;
			while (true)
			{
				object obj2;
				switch (num)
				{
				case 0:
					num2++;
					num = 3;
					break;
				case 14:
					if (array2 == null)
					{
						goto case 10;
					}
					if (array2.Length == 0)
					{
						num = 10;
						break;
					}
					text = (string)KFTC3lqsFScA9MQ2Hcg();
					goto default;
				case 1:
					obj2 = null;
					goto IL_0055;
				case 10:
					return null;
				case 13:
					return null;
				case 5:
					format = Resources.h0ftb6GTp4();
					num = 6;
					break;
				case 4:
				case 8:
					array2 = rukIDpqgsgQdbdVOhsE(cvsCell.CellResult) as object[];
					num = 14;
					break;
				case 12:
					if (VSkcA9JSMV.IsValid)
					{
						CvsInSight inSight = InSight;
						if (inSight == null)
						{
							num = 9;
							break;
						}
						object obj = LpIc0lqdc2tUN3N3rRL(inSight);
						if (obj != null)
						{
							obj2 = ((CvsCellCollection)EWpkIqql4rSyYTB8kcC(obj))[VSkcA9JSMV];
							goto IL_0055;
						}
						num = 1;
						break;
					}
					num = 13;
					if (0 == 0)
					{
						break;
					}
					goto case 6;
				case 6:
					text = (string)grFPdZqrhtCxNWpf1V7(text, OTPUcI8CVa8HIVY08aT(20774), string.Format(format, Q3QPcVqvWgwIqihtSdY(jObject, OTPUcI8CVa8HIVY08aT(20780)), Q3QPcVqvWgwIqihtSdY(jObject, OTPUcI8CVa8HIVY08aT(20786)), jObject[(string)OTPUcI8CVa8HIVY08aT(20792)]));
					num = 0;
					if (!yycY8l832NBcXWZFtQJ())
					{
						break;
					}
					goto case 9;
				case 9:
					obj2 = null;
					goto IL_0055;
				case 3:
				case 11:
					if (num2 < array.Length)
					{
						jObject = JObject.Parse(array[num2].ToString());
						num = 5;
						if (0 == 0)
						{
							break;
						}
						goto case 13;
					}
					num = 15;
					break;
				default:
					array = array2;
					num2 = 0;
					num = 11;
					break;
				case 15:
					{
						return text;
					}
					IL_0055:
					cvsCell = (CvsCell)obj2;
					if (cvsCell != null)
					{
						_ = 1;
						num = (yycY8l832NBcXWZFtQJ() ? 2 : 8);
						break;
					}
					goto case 10;
				}
			}
		}
	}

	public AsyncDelegateCommand TrainCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LL2cw5ZDxe;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			LL2cw5ZDxe = value;
		}
	}

	private string PatternUrl
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return thocxTPheA;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref thocxTPheA, value, (string)OTPUcI8CVa8HIVY08aT(20842)))
			{
				try
				{
					PatternImage = (BitmapImage)v8vGSsqk9YhRZYUHhQX(InSight, thocxTPheA);
				}
				catch (Exception)
				{
					PatternImage = null;
				}
			}
		}
	}

	public BitmapImage PatternImage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rwGc6LXLdC;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref rwGc6LXLdC, value, (string)OTPUcI8CVa8HIVY08aT(20382));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RedLineTool(string imagePath, InspectStepViewModel inspect, bool isInitialized)
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
			case 4:
				lHOcF8gQJr = imagePath;
				goto case 0;
			case 1:
			case 2:
				VSkcA9JSMV = CvsCellLocation.Invalid;
				num = 3;
				break;
			case 0:
			case 8:
				TrainCommand = new AsyncDelegateCommand(pPYbwtYNDl, CanTrain);
				num = 11;
				break;
			case 10:
				TBfLpx8jcoGgcQHMmhg(this, inspect, isInitialized);
				num = 4;
				break;
			case 5:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 6;
				break;
			case 7:
				jPhcyoPG3q = new SemaphoreSlim(1, 1);
				num = 10;
				if (UG0Pef87YFfAjHmbR1b())
				{
					break;
				}
				goto case 9;
			case 9:
				v94cuIV23y = true;
				goto case 7;
			default:
				num = 7;
				break;
			case 6:
				xQPc7xnFMi = CvsCellLocation.Invalid;
				YFHcNwgQx9 = CvsCellLocation.Invalid;
				_ = 1;
				num = ((!yycY8l832NBcXWZFtQJ()) ? 1 : 0);
				break;
			case 3:
				tdHcdclNtj = CvsCellLocation.Invalid;
				num = 9;
				if (yycY8l832NBcXWZFtQJ())
				{
					return;
				}
				break;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInternalPostParse_003Ed__8))]
	protected override Task InternalPostParse(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CInternalPostParse_003Ed__8 stateMachine = default;
		while (true)
		{
			IL_0062:
			switch (num)
			{
			case 2:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 1:
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 3;
				if (UG0Pef87YFfAjHmbR1b())
				{
					continue;
				}
				goto case 3;
			case 3:
				stateMachine.cells = cells;
				goto case 0;
			default:
				num = 0;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			case 5:
				while (true)
				{
					stateMachine._003C_003Et__builder = KyaX8E86Gir20hGVSKQ();
					_ = 1;
					if (!yycY8l832NBcXWZFtQJ())
					{
						break;
					}
					num = 2;
					if (true)
					{
						goto IL_0062;
					}
				}
				num = 6;
				if (0 == 0)
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
		int num = 17;
		if (false)
		{
			return;
		}
		uint num2 = default;
		IPropertyCommitter<bool> customCommitter2 = default;
		IPropertyCommitter<double> customCommitter3 = default;
		while (true)
		{
			switch (num)
			{
			case 44:
				return;
			case 83:
				return;
			case 39:
				AddProperty(Invert);
				num = 83;
				if (1 == 0)
				{
					return;
				}
				break;
			case 0:
				return;
			case 43:
				return;
			case 33:
				return;
			default:
				num = 5;
				if (true)
				{
					break;
				}
				goto case 8;
			case 8:
				u458RT8N61QqPsWmlH7(TrainButtonCommand, new PropertyChangedEventHandler(TuIbjUOURB));
				num = 7;
				break;
			case 66:
				return;
			case 5:
				return;
			case 23:
				if (num2 != 3007377802u)
				{
					num = 10;
					break;
				}
				if (relativeCellName == (string)OTPUcI8CVa8HIVY08aT(19504))
				{
					InputCompositeRegion = new InputCompositeRegionViewModel(this, cells, loc, (string)b2EZw08xysZWSF8e4fH(), Resources.DS0YkkHUHL(), SearchRegion, IsInitialized);
					num = 62;
					if (0 == 0)
					{
						break;
					}
					goto case 39;
				}
				return;
			case 62:
				AddProperty(InputCompositeRegion);
				num = 74;
				break;
			case 84:
				if (num2 != 2435959930u)
				{
					num = 37;
					break;
				}
				if (jgDoX78AVjpwspYRfyc(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(20350)))
				{
					PixelPatterns = new PatternsViewModel(InSight, cells, loc, (string)IZOR6x8hmCFQdqccZqt());
					num = 68;
					break;
				}
				num = 6;
				if (UG0Pef87YFfAjHmbR1b())
				{
					break;
				}
				return;
			case 72:
				AddProperty(CoarseGranularity);
				return;
			case 40:
				return;
			case 50:
				return;
			case 7:
				nGWl2y82LMrbFOEy325(TrainButtonCommand, new EventHandler(VFqbCWbTGh));
				AddProperty(TrainButtonCommand);
				return;
			case 27:
				return;
			case 30:
				return;
			case 52:
				AutoGranularity = new CheckBoxViewModel(InSight, cells, loc, Resources.AutoGranularity, IsInitialized, customCommitter2);
				AddProperty(AutoGranularity);
				return;
			case 35:
				return;
			case 28:
				return;
			case 74:
				return;
			case 53:
				if (num2 != 504525065)
				{
					num = 0;
				}
				else if (jgDoX78AVjpwspYRfyc(relativeCellName, OTPUcI8CVa8HIVY08aT(20234)))
				{
					TrainButtonCommand = new ButtonViewModel(InSight, cells, loc, (string)nNDID58QCqeKxaKW66y());
					num = 8;
				}
				else
				{
					num = 51;
				}
				break;
			case 22:
				if (num2 != 1017635769)
				{
					num = 4;
					if (UG0Pef87YFfAjHmbR1b())
					{
						break;
					}
					goto case 48;
				}
				if (!(relativeCellName == (string)OTPUcI8CVa8HIVY08aT(6138)))
				{
					num = 57;
					if (false)
					{
						return;
					}
				}
				else
				{
					Max = new EditIntViewModel(InSight, cells, loc, (string)p4vmox8HJehvcFdIyqx());
					AddProperty(Max);
					num = 31;
				}
				break;
			case 48:
				AddProperty(NumberToFind);
				return;
			case 51:
				return;
			case 10:
				if (num2 == 3770726449u)
				{
					if (!jgDoX78AVjpwspYRfyc(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6650)))
					{
						num = 16;
						break;
					}
					SearchRegion = new EditCompositeRegionViewModel(InSight, cells, loc, Resources.SearchRegion, LpG0Py8THjGxoafMoBw(InputImage), IsInitialized);
					num = 65;
					break;
				}
				return;
			case 82:
				if (num2 <= 967067236)
				{
					num = 46;
					if (yycY8l832NBcXWZFtQJ())
					{
						return;
					}
					break;
				}
				if (num2 > 1328717222)
				{
					if (num2 <= 1597582655)
					{
						if (num2 != 1394153150)
						{
							num = 67;
						}
						else if (!(relativeCellName == (string)OTPUcI8CVa8HIVY08aT(20178)))
						{
							num = 66;
							if (!UG0Pef87YFfAjHmbR1b())
							{
								return;
							}
						}
						else
						{
							ContrastThreshold = new EditIntViewModel(InSight, cells, loc, (string)QJbOnG8MCNuwc0u02lP());
							AddProperty(ContrastThreshold);
							num = 69;
						}
						break;
					}
					if (num2 == 2011890229)
					{
						if (!jgDoX78AVjpwspYRfyc(relativeCellName, OTPUcI8CVa8HIVY08aT(19792)))
						{
							num = 40;
							if (!UG0Pef87YFfAjHmbR1b())
							{
								return;
							}
							break;
						}
						Score = new FloatViewModel(InSight, cells, loc, (string)RSpVPV8memSIsr3hjo4());
						num = 38;
						if (true)
						{
							break;
						}
						goto case 53;
					}
					num = 58;
					if (UG0Pef87YFfAjHmbR1b())
					{
						break;
					}
					goto case 20;
				}
				num = 22;
				break;
			case 16:
				return;
			case 4:
				if (num2 == 1155426524)
				{
					if (jgDoX78AVjpwspYRfyc(relativeCellName, OTPUcI8CVa8HIVY08aT(20248)))
					{
						IsTrainingEnabled = new BoolViewModel(InSight, cells, loc, (string)aSYWFK8cWcNgTDg7Tbx());
						num = 60;
						break;
					}
					num = 28;
					if (true)
					{
						break;
					}
					goto case 10;
				}
				num = 81;
				break;
			case 63:
				return;
			case 59:
				return;
			case 56:
				return;
			case 69:
				return;
			case 21:
				AddProperty(ShowModelRegion);
				num = 36;
				if (true)
				{
					break;
				}
				goto case 78;
			case 78:
				if (num2 != 4126266479u)
				{
					num = 29;
					break;
				}
				if (!jgDoX78AVjpwspYRfyc(relativeCellName, OTPUcI8CVa8HIVY08aT(20482)))
				{
					return;
				}
				customCommitter3 = BBebyBtLh3([MethodImpl(MethodImplOptions.NoInlining)] () =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return (string)Q5Yui0qDxEF8nY46wfe(FineGranularity);
				}, [MethodImpl(MethodImplOptions.NoInlining)] (double P_0) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return P_0.ToString((string)HG0075q8e2AK3SQtEVp(FineGranularity));
				});
				num = 9;
				break;
			case 32:
				return;
			case 64:
				AddProperty(IgnorePolarity);
				return;
			case 42:
				return;
			case 6:
				return;
			case 79:
				return;
			case 68:
				AddProperty(PixelPatterns);
				return;
			case 54:
				return;
			case 75:
				if (num2 != 2333443901u)
				{
					num = 84;
					if (false)
					{
						return;
					}
					break;
				}
				if (!jgDoX78AVjpwspYRfyc(relativeCellName, OTPUcI8CVa8HIVY08aT(20124)))
				{
					return;
				}
				AngleEnd = new EditIntViewModel(InSight, cells, loc, (string)kbDhiK805IPtTfj5QIf());
				AddProperty(AngleEnd);
				num = 41;
				break;
			case 61:
				return;
			case 67:
				if (num2 != 1597582655)
				{
					return;
				}
				if (!jgDoX78AVjpwspYRfyc(relativeCellName, OTPUcI8CVa8HIVY08aT(20008)))
				{
					num = 32;
					break;
				}
				IgnorePolarity = new CheckBoxViewModel(InSight, cells, loc, Resources.IgnorePolarity, IsInitialized);
				num = 64;
				if (UG0Pef87YFfAjHmbR1b())
				{
					break;
				}
				return;
			case 14:
				return;
			case 46:
				if (num2 > 504525065)
				{
					if (num2 != 624045489)
					{
						num = 55;
						break;
					}
					if (!jgDoX78AVjpwspYRfyc(relativeCellName, OTPUcI8CVa8HIVY08aT(20040)))
					{
						return;
					}
					ShowModelRegion = new CheckBoxViewModel(InSight, cells, loc, (string)YEYvih8R939IOgWm7cE(), IsInitialized);
					num = 21;
				}
				else if (num2 == 6917284)
				{
					if (!(relativeCellName == CdQUGaROfy7He9T0foW.KbIzwHEDLa(20100)))
					{
						return;
					}
					AngleStart = new EditIntViewModel(InSight, cells, loc, (string)xZFn9X8y8Q5VCkES8YM());
					num = 13;
				}
				else
				{
					num = 80;
					if (!UG0Pef87YFfAjHmbR1b())
					{
						return;
					}
				}
				break;
			case 41:
				return;
			case 85:
				return;
			case 47:
				u458RT8N61QqPsWmlH7(NumberToFind, new PropertyChangedEventHandler(wsnbHCu6gk));
				num = 48;
				break;
			case 24:
				return;
			case 12:
				return;
			case 49:
				return;
			case 20:
				AddProperty(NumberFound);
				num = 77;
				if (!UG0Pef87YFfAjHmbR1b())
				{
					return;
				}
				break;
			case 31:
				return;
			case 13:
				AddProperty(AngleStart);
				return;
			case 29:
				return;
			case 77:
				return;
			case 3:
				if (num2 == 2900939788u)
				{
					if (!jgDoX78AVjpwspYRfyc(relativeCellName, OTPUcI8CVa8HIVY08aT(20144)))
					{
						num = 24;
						break;
					}
					AcceptThreshold = new EditIntViewModel(InSight, cells, loc, (string)Bhtgno8FPgZ5q0iOtNn());
					AddProperty(AcceptThreshold);
					num = 73;
					if (yycY8l832NBcXWZFtQJ())
					{
						return;
					}
				}
				else
				{
					num = 26;
				}
				break;
			case 34:
				return;
			case 15:
				return;
			case 25:
				return;
			case 57:
				return;
			case 11:
				return;
			case 45:
				AddProperty(ModelRegion);
				num = 12;
				if (UG0Pef87YFfAjHmbR1b())
				{
					break;
				}
				goto case 70;
			case 70:
				if (num2 == 2195291688u)
				{
					if (!jgDoX78AVjpwspYRfyc(relativeCellName, OTPUcI8CVa8HIVY08aT(20216)))
					{
						return;
					}
					Timeout = new EditIntViewModel(InSight, cells, loc, (string)qD2QCk8YT9NvI6o8Fuw());
					AddProperty(Timeout);
					num = 34;
					if (true)
					{
						break;
					}
					goto case 21;
				}
				num = 75;
				if (1 == 0)
				{
					return;
				}
				break;
			case 73:
				return;
			case 18:
				if (num2 == 2759775654u)
				{
					if (!jgDoX78AVjpwspYRfyc(relativeCellName, OTPUcI8CVa8HIVY08aT(20074)))
					{
						num = 61;
						break;
					}
					ModelRegion = new EditModelCompositeRegionViewModel(InSight, cells, loc, (string)pWNF1f8WpxCXHMxpnA1(), LpG0Py8THjGxoafMoBw(InputImage), IsInitialized);
					num = 45;
					if (UG0Pef87YFfAjHmbR1b())
					{
						break;
					}
					goto case 9;
				}
				return;
			case 55:
				switch (num2)
				{
				case 967067236u:
					if (!jgDoX78AVjpwspYRfyc(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6096)))
					{
						return;
					}
					NumberFound = new IntViewModel(InSight, cells, loc, (string)ruynmj8upYldwbP2w0N());
					num = 20;
					goto end_IL_00e2;
				case 781469175u:
					if (!jgDoX78AVjpwspYRfyc(relativeCellName, OTPUcI8CVa8HIVY08aT(6148)))
					{
						num = 42;
						goto end_IL_00e2;
					}
					Min = new EditIntViewModel(InSight, cells, loc, (string)sgri0P8UyIfiJJvjAt7());
					AddProperty(Min);
					return;
				}
				num = 85;
				if (0 == 0)
				{
					break;
				}
				goto case 60;
			case 60:
				u458RT8N61QqPsWmlH7(IsTrainingEnabled, new PropertyChangedEventHandler(fh5bOVUusm));
				AddProperty(IsTrainingEnabled);
				return;
			case 26:
				return;
			case 81:
				if (num2 == 1328717222)
				{
					if (!jgDoX78AVjpwspYRfyc(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(20314)))
					{
						num = 56;
						if (true)
						{
							break;
						}
						goto case 23;
					}
					VSkcA9JSMV = loc;
					num = 50;
					if (true)
					{
						break;
					}
					goto case 3;
				}
				num = 30;
				break;
			case 17:
				num2 = _003CPrivateImplementationDetails_003E.ComputeStringHash(relativeCellName);
				UG0Pef87YFfAjHmbR1b();
				if (yycY8l832NBcXWZFtQJ())
				{
					num = 49;
					if (UG0Pef87YFfAjHmbR1b())
					{
						break;
					}
					goto case 46;
				}
				num = 19;
				break;
			case 36:
				return;
			case 9:
				FineGranularity = new EditFloatViewModel(InSight, cells, loc, (string)OysN9o8tto3GvkbYudy(), customCommitter3);
				AddProperty(FineGranularity);
				num = 43;
				if (UG0Pef87YFfAjHmbR1b())
				{
					break;
				}
				goto case 58;
			case 58:
				if (num2 == 2046460609)
				{
					if (jgDoX78AVjpwspYRfyc(relativeCellName, OTPUcI8CVa8HIVY08aT(6122)))
					{
						Invert = new CheckBoxViewModel(InSight, cells, loc, Resources.Invert, IsInitialized);
						num = 39;
					}
					else
					{
						num = 35;
					}
				}
				else
				{
					num = 79;
				}
				break;
			case 37:
				return;
			case 71:
				if (num2 == 2931084086u)
				{
					if (!(relativeCellName == (string)OTPUcI8CVa8HIVY08aT(20286)))
					{
						num = 33;
						break;
					}
					NumberToFind = new EditIntViewModel(InSight, cells, loc, (string)hYdl27818GE1iw1X6Jl());
					num = 47;
					if (yycY8l832NBcXWZFtQJ())
					{
						return;
					}
				}
				else
				{
					num = 23;
				}
				break;
			case 38:
				AddProperty(Score);
				return;
			case 2:
				AddProperty(Patterns);
				return;
			case 80:
				if (num2 == 87748910)
				{
					if (!(relativeCellName == (string)OTPUcI8CVa8HIVY08aT(20382)))
					{
						num = 15;
						break;
					}
					tdHcdclNtj = loc;
					num = 25;
					break;
				}
				num = 53;
				if (0 == 0)
				{
					break;
				}
				goto case 65;
			case 65:
				AddProperty(SearchRegion);
				num = 27;
				break;
			case 1:
			case 19:
				if (num2 > 2046460609)
				{
					if (num2 <= 2900939788u)
					{
						if (num2 <= 2435959930u)
						{
							num = 70;
							if (0 == 0)
							{
								break;
							}
							goto case 68;
						}
						if (num2 > 2759775654u)
						{
							if (num2 == 2885690212u)
							{
								if (jgDoX78AVjpwspYRfyc(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(20516)))
								{
									RetrainWithExistingImageButtonCommand = new ButtonViewModel(InSight, cells, loc, Resources.RetrainWithExistingImage);
									num = 86;
									if (1 == 0)
									{
										return;
									}
								}
								else
								{
									num = 59;
								}
							}
							else
							{
								num = 3;
							}
						}
						else if (num2 == 2446540392u)
						{
							if (jgDoX78AVjpwspYRfyc(relativeCellName, OTPUcI8CVa8HIVY08aT(20444)))
							{
								IPropertyCommitter<double> customCommitter = BBebyBtLh3([MethodImpl(MethodImplOptions.NoInlining)] () =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									return (string)Q5Yui0qDxEF8nY46wfe(CoarseGranularity);
								}, [MethodImpl(MethodImplOptions.NoInlining)] (double P_0) =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									return P_0.ToString((string)HG0075q8e2AK3SQtEVp(CoarseGranularity));
								});
								CoarseGranularity = new EditFloatViewModel(InSight, cells, loc, Resources.FpRZdx0ibU(), customCommitter);
								num = 72;
								if (1 == 0)
								{
									return;
								}
							}
							else
							{
								num = 54;
							}
						}
						else
						{
							num = 18;
						}
						break;
					}
					if (num2 > 3770726449u)
					{
						if (num2 > 3872723142u)
						{
							if (num2 != 4103151817u)
							{
								num = 78;
								if (yycY8l832NBcXWZFtQJ())
								{
									return;
								}
								break;
							}
							if (!jgDoX78AVjpwspYRfyc(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(19990)))
							{
								return;
							}
							xQPc7xnFMi = loc;
							num = 76;
							break;
						}
						switch (num2)
						{
						default:
							num = 44;
							if (yycY8l832NBcXWZFtQJ())
							{
							}
							break;
						case 3860655209u:
							if (relativeCellName == (string)OTPUcI8CVa8HIVY08aT(19732))
							{
								Patterns = new PatternsViewModel(InSight, cells, loc, Resources.boxJImgyB3());
								num = 2;
							}
							else
							{
								num = 11;
							}
							break;
						case 3872723142u:
							if (!jgDoX78AVjpwspYRfyc(relativeCellName, OTPUcI8CVa8HIVY08aT(20410)))
							{
								num = 63;
								break;
							}
							customCommitter2 = BBebyBtLh3<bool>([MethodImpl(MethodImplOptions.NoInlining)] () =>
							{
								while (false)
								{
									_ = ((object[])null)[0];
								}
								return (string)Q5Yui0qDxEF8nY46wfe(AutoGranularity);
							});
							num = 52;
							if (0 == 0)
							{
								break;
							}
							return;
						}
					}
					else
					{
						num = 71;
						if (yycY8l832NBcXWZFtQJ())
						{
						}
					}
					break;
				}
				num = 82;
				if (false)
				{
					return;
				}
				break;
			case 76:
				return;
			case 86:
				return;
				end_IL_00e2:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TuIbjUOURB(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (xBbjW1qL2t129v78pJG(YFe9Sy8zE7PB4n8ZHWY(P_1), CdQUGaROfy7He9T0foW.KbIzwHEDLa(20568), StringComparison.Ordinal))
		{
			aD6PMqqKHUsH3sE6SCi(TrainCommand);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VFqbCWbTGh(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		v94cuIV23y = true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fh5bOVUusm(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (jgDoX78AVjpwspYRfyc(YFe9Sy8zE7PB4n8ZHWY(P_1), CdQUGaROfy7He9T0foW.KbIzwHEDLa(5436)))
		{
			aD6PMqqKHUsH3sE6SCi(TrainCommand);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void wsnbHCu6gk(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 16;
		int num3 = default;
		FixtureViewModel fixtureViewModel = default;
		int num2 = default;
		string text2 = default;
		int value = default;
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				num3 = oWuCB3q55trk6kNPrIc(FixtureArray.Fixtures);
				UG0Pef87YFfAjHmbR1b();
				num = ((!yycY8l832NBcXWZFtQJ()) ? 1 : 9);
				break;
			case 2:
			{
				IEnumerator<EzTool> enumerator = Parent.Snippets.Cast<EzTool>().GetEnumerator();
				try
				{
					while (FtK4vYqirwd3wjuki6B(enumerator))
					{
						_003C_003Ec__DisplayClass17_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass17_0();
						int num4 = 6;
						if (!UG0Pef87YFfAjHmbR1b())
						{
							goto IL_009c;
						}
						goto IL_0165;
						IL_009c:
						if (CS_0024_003C_003E8__locals4.t == this)
						{
							continue;
						}
						num4 = 7;
						goto IL_0165;
						IL_0165:
						while (true)
						{
							object obj2;
							switch (num4)
							{
							case 1:
							case 3:
								break;
							case 6:
								goto IL_00b3;
							case 0:
								obj2 = null;
								goto IL_00e2;
							case 2:
							case 5:
								new Task([MethodImpl(MethodImplOptions.NoInlining)] [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass17_0.Pe1VMqRyQRFLvX2Lk2J))] () =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									int num5 = 0;
									_003C_003Ec__DisplayClass17_0.Pe1VMqRyQRFLvX2Lk2J stateMachine = default;
									while (true)
									{
										switch (num5)
										{
										case 4:
											stateMachine.AMu1VSX41W = -1;
											goto default;
										default:
											stateMachine.Io41LPhd0A.Start(ref stateMachine);
											num5 = 6;
											break;
										case 1:
										case 5:
											stateMachine.A3N1JgkKGg = CS_0024_003C_003E8__locals4;
											num5 = 4;
											if (_003C_003Ec__DisplayClass17_0.svy4TYK6UejRVtdmlRHO())
											{
											}
											break;
										case 0:
											stateMachine.Io41LPhd0A = _003C_003Ec__DisplayClass17_0.TKhOgdK6mIn1dKRfMIMH();
											_003C_003Ec__DisplayClass17_0.svy4TYK6UejRVtdmlRHO();
											num5 = (_003C_003Ec__DisplayClass17_0.xhQqusK6YYTZbV8St1FC() ? 5 : 2);
											break;
										case 6:
											return;
										}
									}
								}).Start();
								num4 = 8;
								continue;
							case 4:
								obj2 = null;
								goto IL_00e2;
							case 7:
							{
								object obj = Wm7ksBqIsWlfTjWft7F(CS_0024_003C_003E8__locals4.t);
								if (obj != null)
								{
									SourceLink selectedLink = ((InputStructureViewModel)obj).SelectedLink;
									if (selectedLink != null)
									{
										obj2 = selectedLink.Text;
										goto IL_00e2;
									}
									num4 = 0;
									continue;
								}
								goto case 4;
							}
							default:
								num4 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto IL_019a;
							case 8:
								goto IL_019a;
								IL_00e2:
								if (!jgDoX78AVjpwspYRfyc(obj2, Q5Yui0qDxEF8nY46wfe(fixtureViewModel)))
								{
									goto IL_019a;
								}
								goto case 2;
							}
							break;
							IL_00b3:
							CS_0024_003C_003E8__locals4.t = enumerator.Current;
							_ = 0;
							num4 = ((!UG0Pef87YFfAjHmbR1b()) ? 2 : 3);
						}
						goto IL_009c;
						IL_019a:;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						ronWDEqnNFOamueSqxT(enumerator);
					}
				}
				nUhGNSqVUwuPTga3JfA(FixtureArray.Fixtures, num2);
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 14;
			}
			case 14:
				if (xBbjW1qL2t129v78pJG(YFe9Sy8zE7PB4n8ZHWY(P_1), OTPUcI8CVa8HIVY08aT(5436), StringComparison.Ordinal))
				{
					num = 10;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				}
				return;
			case 0:
				num3++;
				num = 17;
				break;
			case 12:
				text2 = LpG0Py8THjGxoafMoBw(PixelPatterns).ToString(absoluteRow: true, absoluteColumn: true);
				num = 3;
				break;
			case 9:
			case 13:
			case 18:
				if (num2 >= value)
				{
					fixtureViewModel = FixtureArray.Fixtures[num2];
					num = 2;
					break;
				}
				goto case 11;
			case 11:
				FireDependencyChanged();
				num = 19;
				break;
			case 10:
				value = NumberToFind.Value;
				num = 6;
				break;
			default:
				num = 0;
				break;
			case 7:
				text = LpG0Py8THjGxoafMoBw(InputImage).ToString(absoluteRow: true, absoluteColumn: true);
				num = 12;
				break;
			case 5:
				num2 = oWuCB3q55trk6kNPrIc(FixtureArray.Fixtures) - 1;
				goto case 9;
			case 16:
				if (Parent != null)
				{
					num = 14;
					break;
				}
				return;
			case 15:
				if (value <= oWuCB3q55trk6kNPrIc(FixtureArray.Fixtures))
				{
					if (value < FixtureArray.Fixtures.Count)
					{
						num = 5;
						break;
					}
					goto case 11;
				}
				num = 7;
				break;
			case 6:
				if (value >= 0)
				{
					num = 15;
					break;
				}
				goto case 11;
			case 1:
			case 8:
			case 17:
				if (num3 < value)
				{
					FixtureViewModel item = new FixtureViewModel(InSight, (CvsCellCollection)uN3SDjqJ0slP30u53e1(L9F7EKqwocT2IQotddZ(InSight)), (string)B72sJbqefNQIs8S2KSv(OTPUcI8CVa8HIVY08aT(20586), new object[4]
					{
						Mk2fW0qa0U8lSLsLY2A(this),
						OTPUcI8CVa8HIVY08aT(1104),
						EZBSnippetStrings.OutputFixture,
						num3
					}), (string)B72sJbqefNQIs8S2KSv(CdQUGaROfy7He9T0foW.KbIzwHEDLa(20614), new object[7] { text, text2, num3, text2, num3, text2, num3 }), (string)Ce3ZEpqO53evNOwsftq(CdQUGaROfy7He9T0foW.KbIzwHEDLa(20738), num3));
					FixtureArray.Fixtures.Add(item);
					goto case 0;
				}
				num = 11;
				break;
			case 4:
				num2--;
				num = 18;
				break;
			case 19:
				return;
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
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 0:
				base.OnResultsChanged(results);
				UG0Pef87YFfAjHmbR1b();
				num = (yycY8l832NBcXWZFtQJ() ? 3 : 4);
				break;
			default:
				v94cuIV23y = fkpbvO73mv(results);
				num = 5;
				break;
			case 1:
			case 4:
				if (v94cuIV23y)
				{
					goto default;
				}
				return;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CShiftEditGraphics_003Ed__113))]
	public override Task ShiftEditGraphics(int delta)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003CShiftEditGraphics_003Ed__113 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine.delta = delta;
				goto default;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 6:
				stateMachine._003C_003Et__builder = KyaX8E86Gir20hGVSKQ();
				UG0Pef87YFfAjHmbR1b();
				if (yycY8l832NBcXWZFtQJ())
				{
					num = 0;
					if (true)
					{
						break;
					}
					goto case 2;
				}
				num = 5;
				break;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 2;
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
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0043;
		IL_001a:
		CvsDisplayableComposite cvsDisplayableComposite = default;
		if (cvsDisplayableComposite != null)
		{
			num = 3;
			goto IL_0043;
		}
		goto IL_00f7;
		IL_00f7:
		List<CvsEditableDisplayGraphic> list = default;
		return (CvsEditableDisplayGraphic[])k2DBMgqZvHqhjYAo05t(list);
		IL_0043:
		CvsDisplayableComposite cvsDisplayableComposite2 = default;
		while (true)
		{
			switch (num)
			{
			case 5:
			case 6:
				break;
			case 4:
				list.Add(cvsDisplayableComposite2);
				goto case 7;
			default:
				num = 7;
				continue;
			case 7:
				cvsDisplayableComposite = zphlYhqPtoqoc2DbGoy(SearchRegion) as CvsDisplayableComposite;
				break;
			case 3:
				list.Add(cvsDisplayableComposite);
				num = 9;
				continue;
			case 1:
				goto IL_00ac;
			case 2:
			case 8:
				if (cvsDisplayableComposite2 != null)
				{
					num = 4;
					continue;
				}
				goto case 7;
			case 0:
				list = new List<CvsEditableDisplayGraphic>();
				num = 1;
				continue;
			case 9:
				goto IL_00f7;
			}
			break;
			IL_00ac:
			cvsDisplayableComposite2 = ModelRegion.Graphic as CvsDisplayableComposite;
			yycY8l832NBcXWZFtQJ();
			num = (UG0Pef87YFfAjHmbR1b() ? 8 : 6);
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnSetRange_003Ed__115))]
	internal override Task OnSetRange()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		UG0Pef87YFfAjHmbR1b();
		int num = (yycY8l832NBcXWZFtQJ() ? 4 : 5);
		_003COnSetRange_003Ed__115 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 3;
				if (true)
				{
					break;
				}
				goto case 3;
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			default:
				num = 2;
				break;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = KyaX8E86Gir20hGVSKQ();
				goto case 1;
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
	public bool CanTrain()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (TrainButtonCommand.Enabled)
		{
			return GQQoCnqBA7NGAFudwPJ(IsTrainingEnabled);
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CTrain_003Ed__121))]
	internal Task pPYbwtYNDl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!yycY8l832NBcXWZFtQJ())
		{
			num = 3;
			if (yycY8l832NBcXWZFtQJ())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 5;
			if (1 == 0)
			{
				goto IL_00c7;
			}
		}
		goto IL_0078;
		IL_0078:
		_003CTrain_003Ed__121 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				if (!yycY8l832NBcXWZFtQJ())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = KyaX8E86Gir20hGVSKQ();
				break;
			case 6:
				goto IL_00c7;
			}
			break;
		}
		goto IL_002a;
		IL_00c7:
		return stateMachine._003C_003Et__builder.Task;
		IL_002a:
		stateMachine._003C_003E4__this = this;
		num = 2;
		if (yycY8l832NBcXWZFtQJ())
		{
		}
		goto IL_0078;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IPropertyCommitter<HcTRQJEUTHsscrrGg4> BBebyBtLh3<HcTRQJEUTHsscrrGg4>(Func<string> P_0, Func<HcTRQJEUTHsscrrGg4, string> P_1 = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass122_0<HcTRQJEUTHsscrrGg4> CS_0024_003C_003E8__locals7 = new _003C_003Ec__DisplayClass122_0<HcTRQJEUTHsscrrGg4>();
		CS_0024_003C_003E8__locals7.valueFormatter = P_1;
		CS_0024_003C_003E8__locals7.cellNameProvider = P_0;
		CS_0024_003C_003E8__locals7._003C_003E4__this = this;
		if (CS_0024_003C_003E8__locals7.cellNameProvider == null)
		{
			throw new ArgumentNullException(CdQUGaROfy7He9T0foW.KbIzwHEDLa(20806));
		}
		if (CS_0024_003C_003E8__locals7.valueFormatter == null)
		{
			CS_0024_003C_003E8__locals7.valueFormatter = [MethodImpl(MethodImplOptions.NoInlining)] (HcTRQJEUTHsscrrGg4 val) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return val.ToString();
			};
		}
		return new EventuallyConsistentPropertyCommitter<HcTRQJEUTHsscrrGg4>(new DeduplicatingPropertyCommitter<HcTRQJEUTHsscrrGg4>([MethodImpl(MethodImplOptions.NoInlining)] [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass122_0<>.LRkPd3Rb3ZW2isXjlgt))] (HcTRQJEUTHsscrrGg4 newValue, HcTRQJEUTHsscrrGg4 oldValue) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003Ec__DisplayClass122_0<HcTRQJEUTHsscrrGg4>.LRkPd3Rb3ZW2isXjlgt stateMachine = default;
			stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
			stateMachine._003C_003E4__this = CS_0024_003C_003E8__locals7;
			stateMachine.newValue = newValue;
			stateMachine.oldValue = oldValue;
			stateMachine._003C_003E1__state = -1;
			stateMachine._003C_003Et__builder.Start(ref stateMachine);
			return stateMachine._003C_003Et__builder.Task;
		}));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUpdateTrainParamAndRetrainWithExistingImage_003Ed__124))]
	private Task n0YbxNVNdS(IUndoAction P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CUpdateTrainParamAndRetrainWithExistingImage_003Ed__124 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine.undoEditCellChange = P_0;
				goto default;
			default:
				_ = 0;
				num = ((!UG0Pef87YFfAjHmbR1b()) ? 1 : 6);
				break;
			case 5:
				stateMachine._003C_003Et__builder = KyaX8E86Gir20hGVSKQ();
				num = 2;
				if (!yycY8l832NBcXWZFtQJ())
				{
					break;
				}
				goto case 1;
			case 1:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 3:
			case 6:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 0;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteFixturedGraphics_003Ed__125))]
	internal override Task WriteFixturedGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		UG0Pef87YFfAjHmbR1b();
		int num;
		if (!yycY8l832NBcXWZFtQJ())
		{
			num = 3;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0044;
		IL_009f:
		_003CWriteFixturedGraphics_003Ed__125 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0044;
		IL_0044:
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				break;
			default:
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
				stateMachine._003C_003E4__this = this;
				break;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = KyaX8E86Gir20hGVSKQ();
				num = 1;
				continue;
			case 5:
				goto IL_009f;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		stateMachine._003C_003E1__state = -1;
		goto IL_009f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetFeatures(CvsCellCollection cells, CellType dataType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		List<CvsEditableDisplayGraphic> list = default;
		CvsDisplayableCross item = default;
		string text2 = default;
		string text = default;
		CvsCellLocation cellLocation = default;
		int num2 = default;
		CvsCellLocation cvsCellLocation = default;
		JObject jObject = default;
		object[] array = default;
		while (true)
		{
			switch (num)
			{
			case 9:
				list.Add(item);
				num = 10;
				continue;
			case 3:
				text2 = string.Format((string)OTPUcI8CVa8HIVY08aT(20614), text, cellLocation, num2, cellLocation, num2, cellLocation, num2);
				num = 4;
				continue;
			case 11:
				if (VSkcA9JSMV.IsValid)
				{
					cvsCellLocation = LpG0Py8THjGxoafMoBw(InputImage);
					num = 15;
					continue;
				}
				break;
			case 4:
				item = (CvsDisplayableCross)EbMYMhqox1iyfkycmKx(InSight, cellLocation, jObject.Value<double>(CdQUGaROfy7He9T0foW.KbIzwHEDLa(20780)), jObject.Value<double>(OTPUcI8CVa8HIVY08aT(20786)), jObject.Value<double>(CdQUGaROfy7He9T0foW.KbIzwHEDLa(20792)), text2);
				num = 9;
				continue;
			case 7:
				list = new List<CvsEditableDisplayGraphic>();
				yycY8l832NBcXWZFtQJ();
				num = ((!UG0Pef87YFfAjHmbR1b()) ? 8 : 6);
				continue;
			case 5:
			case 8:
				cellLocation = Patterns.CellLocation;
				array = rukIDpqgsgQdbdVOhsE(cx52OQqGFZ5lGFCRdSW(PfSjefqbAdse9bWXip0(cells, VSkcA9JSMV))) as object[];
				if (array != null)
				{
					num = 14;
					continue;
				}
				break;
			case 10:
				num2++;
				num = 12;
				if (UG0Pef87YFfAjHmbR1b())
				{
					continue;
				}
				goto case 0;
			default:
				num = 2;
				continue;
			case 1:
			case 6:
				if (dataType != CellType.Point)
				{
					num = 13;
					continue;
				}
				goto case 11;
			case 14:
				num2 = 0;
				num = 0;
				if (!yycY8l832NBcXWZFtQJ())
				{
					continue;
				}
				goto case 13;
			case 13:
				if (dataType != CellType.Fixture)
				{
					break;
				}
				num = 11;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 12:
				if (num2 < array.Length)
				{
					if (FixtureArray.Fixtures.Count <= num2)
					{
						goto case 10;
					}
					goto case 2;
				}
				num = 16;
				continue;
			case 15:
				text = cvsCellLocation.ToString(absoluteRow: true, absoluteColumn: true);
				goto case 5;
			case 2:
				jObject = array[num2] as JObject;
				num = 3;
				if (true)
				{
					continue;
				}
				break;
			case 16:
				break;
			}
			break;
		}
		return list.ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool fkpbvO73mv(CvsResultSet P_0 = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_00ba;
		IL_001a:
		CvsCogImage cvsCogImage = default;
		PatternUrl = (string)eC1Y16qSuVh8mIJV24Y(cvsCogImage);
		num = 0;
		goto IL_00ba;
		IL_00ba:
		bool result = default;
		CvsCell cvsCell = default;
		while (true)
		{
			CvsResultSet cvsResultSet;
			switch (num)
			{
			case 8:
				break;
			case 6:
				result = true;
				UG0Pef87YFfAjHmbR1b();
				if (!yycY8l832NBcXWZFtQJ())
				{
					num = 2;
					if (!yycY8l832NBcXWZFtQJ())
					{
						continue;
					}
					goto case 7;
				}
				num = 3;
				continue;
			case 7:
				if (cvsCogImage != null)
				{
					num = 8;
					continue;
				}
				goto case 11;
			case 10:
				cvsCell = (CvsCell)PfSjefqbAdse9bWXip0(P_0.Cells, tdHcdclNtj);
				num = 4;
				continue;
			case 1:
			case 2:
				cvsResultSet = P_0;
				if (cvsResultSet == null)
				{
					num = 9;
					if (!yycY8l832NBcXWZFtQJ())
					{
						continue;
					}
					goto case 0;
				}
				goto IL_010a;
			case 0:
				result = false;
				num = 11;
				continue;
			case 4:
				if (cvsCell != null)
				{
					goto default;
				}
				goto case 11;
			case 9:
				cvsResultSet = InSight.Results;
				goto IL_010a;
			default:
				cvsCogImage = rukIDpqgsgQdbdVOhsE(cx52OQqGFZ5lGFCRdSW(cvsCell)) as CvsCogImage;
				num = 7;
				continue;
			case 11:
				{
					return result;
				}
				IL_010a:
				P_0 = cvsResultSet;
				if (tdHcdclNtj.IsValid)
				{
					num = 10;
					continue;
				}
				goto case 11;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task FFVbeM6uGr(CvsCellCollection P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.InternalPostParse(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private string vUrb2gYwJX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)Q5Yui0qDxEF8nY46wfe(AutoGranularity);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private string t8obqLSjGC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)Q5Yui0qDxEF8nY46wfe(CoarseGranularity);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private string oH8biM1F5L(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0.ToString((string)HG0075q8e2AK3SQtEVp(CoarseGranularity));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private string Ovwbkui05x()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)Q5Yui0qDxEF8nY46wfe(FineGranularity);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private string PKTbPYVN1t(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0.ToString((string)HG0075q8e2AK3SQtEVp(FineGranularity));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TBfLpx8jcoGgcQHMmhg(object P_0, object P_1, bool P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzRangeTool<EditIntViewModel>)P_0)._002Ector((InspectStepViewModel)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UG0Pef87YFfAjHmbR1b()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool yycY8l832NBcXWZFtQJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder KyaX8E86Gir20hGVSKQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OTPUcI8CVa8HIVY08aT(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jgDoX78AVjpwspYRfyc(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YEYvih8R939IOgWm7cE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.ShowModelRegion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pWNF1f8WpxCXHMxpnA1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.ModelRegion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation LpG0Py8THjGxoafMoBw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xZFn9X8y8Q5VCkES8YM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.AngleStart;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kbDhiK805IPtTfj5QIf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.AngleEnd;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Bhtgno8FPgZ5q0iOtNn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.AcceptThreshold;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QJbOnG8MCNuwc0u02lP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.ContrastThreshold;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qD2QCk8YT9NvI6o8Fuw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Timeout;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sgri0P8UyIfiJJvjAt7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.MjMVZlHh3y();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object p4vmox8HJehvcFdIyqx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CsBVSmiZVr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object b2EZw08xysZWSF8e4fH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.qN0YqEgJAG();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RSpVPV8memSIsr3hjo4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Score;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nNDID58QCqeKxaKW66y()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Train;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void u458RT8N61QqPsWmlH7(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nGWl2y82LMrbFOEy325(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ButtonViewModel)P_0).CommandExecuted += (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aSYWFK8cWcNgTDg7Tbx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.IsTrainingEnabled;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hYdl27818GE1iw1X6Jl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.NumberToFind;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ruynmj8upYldwbP2w0N()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.NumberFound;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IZOR6x8hmCFQdqccZqt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.OutputFixtures;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OysN9o8tto3GvkbYudy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Ug4t3FeWqY();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YFe9Sy8zE7PB4n8ZHWY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertyChangedEventArgs)P_0).PropertyName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xBbjW1qL2t129v78pJG(object P_0, object P_1, StringComparison P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aD6PMqqKHUsH3sE6SCi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseDelegateCommand)P_0).RaiseCanExecuteChanged();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int oWuCB3q55trk6kNPrIc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Collection<FixtureViewModel>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object L9F7EKqwocT2IQotddZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Results;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uN3SDjqJ0slP30u53e1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsResultSet)P_0).Cells;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Mk2fW0qa0U8lSLsLY2A(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzSnippet)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object B72sJbqefNQIs8S2KSv(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, (object[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ce3ZEpqO53evNOwsftq(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Wm7ksBqIsWlfTjWft7F(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzTool)P_0).InputFixture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Q5Yui0qDxEF8nY46wfe(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FtK4vYqirwd3wjuki6B(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ronWDEqnNFOamueSqxT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nUhGNSqVUwuPTga3JfA(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Collection<FixtureViewModel>)P_0).RemoveAt(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ed4gjdqfApwBXmJQKms(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).DisplayValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LpIc0lqdc2tUN3N3rRL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Results;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EWpkIqql4rSyYTB8kcC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsResultSet)P_0).Cells;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rukIDpqgsgQdbdVOhsE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KFTC3lqsFScA9MQ2Hcg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.fPDtMfUC3w();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Q3QPcVqvWgwIqihtSdY(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((JObject)P_0)[(string)P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object grFPdZqrhtCxNWpf1V7(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zphlYhqPtoqoc2DbGoy(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EditableGraphicsViewModel)P_0).Graphic;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object k2DBMgqZvHqhjYAo05t(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GQQoCnqBA7NGAFudwPJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BoolViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PfSjefqbAdse9bWXip0(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cx52OQqGFZ5lGFCRdSW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).CellResult;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EbMYMhqox1iyfkycmKx(object P_0, CvsCellLocation crossLocation, double x, double y, double angle, object P_5)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EditableGraphicHelper.GetCross((CvsInSight)P_0, crossLocation, x, y, angle, (string)P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eC1Y16qSuVh8mIJV24Y(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImage)P_0).Url;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object v8vGSsqk9YhRZYUHhQX(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).GetImageFromInSight((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HG0075q8e2AK3SQtEVp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EditNumericViewModel<double, CvsCellFloat, CvsCellEditFloat>)P_0).NumericFormat;
	}
}
