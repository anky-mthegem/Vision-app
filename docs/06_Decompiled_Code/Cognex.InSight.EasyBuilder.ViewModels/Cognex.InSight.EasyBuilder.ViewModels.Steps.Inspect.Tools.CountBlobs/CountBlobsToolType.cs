using System;
using System.Collections.Generic;
using System.Composition;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Threading;
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
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.CountBlobs;

[Export(typeof(EzToolType))]
public class CountBlobsToolType : CompositeRegionToolType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateTool_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public Guid guid;

		public CountBlobsToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private CountBlobsTool _003Ctool_003E5__2;

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
			if (F3Tx5PKmxtiQ01tesbYt())
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_01f9;
			IL_01f9:
			CountBlobsToolType countBlobsToolType = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 5:
					goto IL_0042;
				default:
					num = 2;
					continue;
				case 1:
				case 4:
					countBlobsToolType = _003C_003E4__this;
					num = 5;
					continue;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0042:
			EzTool result = default;
			try
			{
				int num3;
				if (num2 != 0)
				{
					if (ievOIIKmQ8UjPqGdY0GZ(guid, KkdCRAP380))
					{
						num3 = 2;
						goto IL_0098;
					}
					throw new ArgumentException();
				}
				TaskAwaiter awaiter = _003C_003Eu__1;
				goto IL_0136;
				IL_0098:
				while (true)
				{
					switch (num3)
					{
					case 0:
						awaiter.GetResult();
						num3 = 4;
						continue;
					case 3:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						goto default;
					default:
						_ = 0;
						if (F3Tx5PKmxtiQ01tesbYt())
						{
							num3 = 1;
							continue;
						}
						num3 = 10;
						if (F3Tx5PKmxtiQ01tesbYt())
						{
							continue;
						}
						goto case 9;
					case 2:
						_003Ctool_003E5__2 = new CountBlobsTool((InspectStepViewModel)gAMuyLKmNNAyRtNWqcCU(countBlobsToolType), isInitialized: true);
						awaiter = ((Task)lIJ8hnKm2nM6VZWqv7qT(_003Ctool_003E5__2, cells, cellRange)).GetAwaiter();
						num3 = 11;
						continue;
					case 11:
						if (!awaiter.IsCompleted)
						{
							num3 = 9;
							continue;
						}
						goto case 0;
					case 6:
					case 10:
						break;
					case 4:
						result = _003Ctool_003E5__2;
						num3 = 12;
						continue;
					case 7:
						num2 = (_003C_003E1__state = -1);
						num3 = 0;
						continue;
					case 8:
						_003C_003Eu__1 = awaiter;
						num3 = 3;
						if (true)
						{
							continue;
						}
						return;
					case 1:
					case 5:
						return;
					case 9:
						num2 = (_003C_003E1__state = 0);
						num3 = 8;
						continue;
					case 12:
						goto end_IL_0098;
					}
					goto IL_0136;
					continue;
					end_IL_0098:
					break;
				}
				goto end_IL_0042;
				IL_0136:
				_003C_003Eu__1 = default;
				num3 = 7;
				goto IL_0098;
				end_IL_0042:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0026;
			IL_0026:
			_003C_003Et__builder.SetResult(result);
			num = 6;
			if (atugN1KmmRCtW8ZpdBc6())
			{
				goto IL_0042;
			}
			goto IL_01f9;
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
		internal static bool ievOIIKmQ8UjPqGdY0GZ(Guid P_0, Guid P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0 == P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gAMuyLKmNNAyRtNWqcCU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lIJ8hnKm2nM6VZWqv7qT(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool F3Tx5PKmxtiQ01tesbYt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool atugN1KmmRCtW8ZpdBc6()
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
	private struct _003COnBeginAddInternal_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CountBlobsToolType _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!N45ZfKKmc8CDfqaibtgJ())
			{
				goto IL_001e;
			}
			goto IL_021c;
			IL_021c:
			CountBlobsToolType countBlobsToolType = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				default:
					goto IL_003d;
				case 5:
					goto IL_0058;
				case 1:
				case 2:
					countBlobsToolType = _003C_003E4__this;
					num = 5;
					if (true)
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_001e;
			IL_0058:
			int num2 = default;
			try
			{
				CvsCogRectangle acquired2DImageBounds = default;
				int num3;
				TaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					acquired2DImageBounds = countBlobsToolType.GetAcquired2DImageBounds();
					num3 = 9;
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 10;
				}
				while (true)
				{
					switch (num3)
					{
					case 9:
						countBlobsToolType.EditableComposite = EditableGraphicHelper.ConstructComposite(CvsCellLocation.Invalid, 100.0, 100.0, 200.0, 200.0, 0.0, 0.0, acquired2DImageBounds);
						_ = 1;
						num3 = (UduTmjKm12S1tV9sPGbQ() ? 4 : 0);
						continue;
					case 3:
					case 4:
						if (awaiter.IsCompleted)
						{
							break;
						}
						num3 = 2;
						if (0 == 0)
						{
							continue;
						}
						goto case 10;
					case 10:
						_003C_003Eu__1 = default;
						num3 = 8;
						continue;
					case 0:
					case 1:
						countBlobsToolType.QjmCvyGm7k = new CvsEditableDisplayGraphic[1] { countBlobsToolType.EditableComposite };
						num3 = 6;
						continue;
					case 2:
						num2 = (_003C_003E1__state = 0);
						goto case 5;
					default:
						num3 = 5;
						continue;
					case 8:
						num2 = (_003C_003E1__state = -1);
						num3 = 11;
						continue;
					case 7:
						return;
					case 6:
						awaiter = HHgsvPKmuaKFDUum7510(countBlobsToolType.MLjCMW65yW());
						goto case 3;
					case 5:
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 7;
						if (true)
						{
							continue;
						}
						break;
					case 11:
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
			goto IL_003d;
			IL_003d:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (!N45ZfKKmc8CDfqaibtgJ())
			{
				goto IL_0058;
			}
			goto IL_021c;
			IL_001e:
			num2 = _003C_003E1__state;
			_ = 0;
			if (N45ZfKKmc8CDfqaibtgJ())
			{
				num = 2;
				if (1 == 0)
				{
					goto IL_003d;
				}
			}
			else
			{
				num = 0;
			}
			goto IL_021c;
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
		internal static TaskAwaiter HHgsvPKmuaKFDUum7510(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool N45ZfKKmc8CDfqaibtgJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UduTmjKm12S1tV9sPGbQ()
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
	private struct _003CAddTool_003Ed__44 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public CountBlobsToolType _003C_003E4__this;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private CvsCellRange _003CpasteRange_003E5__3;

		private object _003C_003E7__wrap3;

		private string _003CtoolName_003E5__5;

		private CountBlobsTool _003CnewTool_003E5__6;

		private TaskAwaiter<CvsCellRange> _003C_003Eu__1;

		private TaskAwaiter<object> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__4;

		private TaskAwaiter<double> _003C_003Eu__5;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__6;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (nn2WSmKmtZ9jZAy6FnlA() ? 2 : 4);
			EzTool result = default;
			TaskAwaiter awaiter = default;
			CountBlobsToolType countBlobsToolType = default;
			PasteBuffer pasteObject = default;
			TaskAwaiter<object> awaiter6 = default;
			TaskAwaiter<double> awaiter5 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter4 = default;
			TaskAwaiter<CvsCellCollection> awaiter3 = default;
			TaskAwaiter<CvsCellRange> awaiter2 = default;
			string expression = default;
			CvsCellLocation cellLocation = default;
			CvsCellRange result2 = default;
			Dictionary<string, object> dictionary = default;
			double result3 = default;
			CvsCellCollection result4 = default;
			int num2 = default;
			do
			{
				IL_0b64:
				switch (num)
				{
				case 6:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					if (Jn5J2rKmhD2Slwm4SFTL())
					{
						goto IL_0b64;
					}
					goto case 3;
				case 3:
					_003Csheet_003E5__2 = null;
					num = 6;
					if (!nn2WSmKmtZ9jZAy6FnlA())
					{
						goto IL_0b64;
					}
					goto case 5;
				case 5:
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
								goto IL_0adf;
							}
							_003Csheet_003E5__2 = (CvsCogSocketSheet)MvHiYTKQ5gQUmvEQpYd1(L5U7uAKQKP9UEpQ5stCP(IC85cSKQL1bdDssYFiXy(HE9qEMKmztrjb3GEA9V7(countBlobsToolType))));
							_003CpasteRange_003E5__3 = CvsCellRange.Empty;
							num3 = 0;
						}
						try
						{
							int num4;
							switch (num2)
							{
							default:
								pasteObject = EzToolType.UpdateNamesInPasteBuffer(countBlobsToolType.vOpCTK9lVp, countBlobsToolType.Inspect, out _003CtoolName_003E5__5);
								num4 = 15;
								goto IL_03fe;
							case 4:
								awaiter = _003C_003Eu__3;
								num4 = 36;
								goto IL_03fe;
							case 1:
								awaiter6 = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num4 = 17;
								goto IL_03fe;
							case 2:
								awaiter = _003C_003Eu__3;
								num4 = 67;
								if (nn2WSmKmtZ9jZAy6FnlA())
								{
									goto IL_02a8;
								}
								goto IL_03fe;
							case 6:
								awaiter5 = _003C_003Eu__5;
								num4 = 56;
								if (1 == 0)
								{
									goto IL_0342;
								}
								goto IL_03fe;
							case 8:
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num4 = 41;
								if (1 == 0)
								{
									goto IL_03e0;
								}
								goto IL_03fe;
							case 3:
								awaiter4 = _003C_003Eu__4;
								_003C_003Eu__4 = default;
								num4 = 1;
								if (true)
								{
									goto IL_03fe;
								}
								goto IL_0609;
							case 5:
								awaiter4 = _003C_003Eu__4;
								num4 = 62;
								if (Jn5J2rKmhD2Slwm4SFTL())
								{
									goto IL_03fe;
								}
								goto IL_084f;
							case 7:
								awaiter3 = _003C_003Eu__6;
								num4 = 13;
								goto IL_03fe;
							case 0:
								{
									awaiter2 = _003C_003Eu__1;
									num4 = 43;
									goto IL_03fe;
								}
								IL_03fe:
								while (true)
								{
									switch (num4)
									{
									case 33:
										awaiter = qVJcvjKQOoHfTYljxoO3(sY7Wf2KQegMIBJCdxN6b(HE9qEMKmztrjb3GEA9V7(countBlobsToolType), expression, cellLocation));
										num4 = 55;
										continue;
									case 11:
										if (!awaiter4.IsCompleted)
										{
											num4 = 30;
											if (0 == 0)
											{
												continue;
											}
											goto case 43;
										}
										goto case 8;
									case 43:
										_003C_003Eu__1 = default;
										num4 = 20;
										if (Jn5J2rKmhD2Slwm4SFTL())
										{
											continue;
										}
										goto case 15;
									case 15:
										awaiter2 = countBlobsToolType.PasteTool(pasteObject, null, runSheet: false).GetAwaiter();
										if (!awaiter2.IsCompleted)
										{
											num4 = 3;
											if (true)
											{
												continue;
											}
											goto case 56;
										}
										goto case 18;
									case 56:
										_003C_003Eu__5 = default;
										num4 = 5;
										continue;
									case 21:
										_003C_003Eu__2 = awaiter6;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter6, ref this);
										num4 = 27;
										continue;
									case 44:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
										num4 = 32;
										if (nn2WSmKmtZ9jZAy6FnlA())
										{
										}
										continue;
									case 20:
										num2 = (_003C_003E1__state = -1);
										num4 = 18;
										continue;
									case 58:
										return;
									case 1:
										num2 = (_003C_003E1__state = -1);
										num4 = 34;
										continue;
									case 17:
										num2 = (_003C_003E1__state = -1);
										num4 = 24;
										continue;
									case 27:
										return;
									case 4:
										break;
									case 51:
										CvsTraceEzb.Info.TraceMessage(CdQUGaROfy7He9T0foW.KbIzwHEDLa(49576));
										num4 = 42;
										if (nn2WSmKmtZ9jZAy6FnlA())
										{
										}
										continue;
									case 30:
										num2 = (_003C_003E1__state = 5);
										num4 = 54;
										if (0 == 0)
										{
											continue;
										}
										return;
									case 31:
										return;
									case 29:
										goto end_IL_03fe;
									case 41:
										num2 = (_003C_003E1__state = -1);
										num4 = 52;
										continue;
									case 18:
										result2 = awaiter2.GetResult();
										num4 = 40;
										if (true)
										{
											continue;
										}
										goto case 55;
									case 55:
										if (!awaiter.IsCompleted)
										{
											num2 = (_003C_003E1__state = 2);
											_003C_003Eu__3 = awaiter;
											num4 = 48;
											if (true)
											{
												continue;
											}
											goto case 6;
										}
										goto IL_0864;
									case 6:
									case 35:
										awaiter4 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
										num4 = 11;
										continue;
									case 32:
										return;
									case 38:
										goto IL_0342;
									case 23:
										dictionary = new Dictionary<string, object> { 
										{
											EzSnippet.AssembleFullCellName(_003CtoolName_003E5__5, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6148)),
											(int)result3
										} };
										num4 = 46;
										if (true)
										{
											continue;
										}
										goto case 9;
									case 9:
										num2 = (_003C_003E1__state = 4);
										_003C_003Eu__3 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 58;
										continue;
									case 10:
										return;
									case 36:
										goto IL_03e0;
									default:
										num4 = 45;
										continue;
									case 48:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 31;
										if (0 == 0)
										{
											continue;
										}
										goto IL_053b;
									case 34:
										goto IL_053b;
									case 45:
										goto IL_0561;
									case 2:
										goto IL_0581;
									case 19:
										goto IL_059a;
									case 8:
										awaiter4.GetResult();
										AaWnUEKQIESdutxonHuB(CvsTraceEzb.Info, CdQUGaROfy7He9T0foW.KbIzwHEDLa(50768));
										num4 = 60;
										continue;
									case 59:
										return;
									case 12:
										goto IL_0609;
									case 62:
										_003C_003Eu__4 = default;
										num2 = (_003C_003E1__state = -1);
										num4 = 8;
										continue;
									case 16:
									case 57:
										expression = countBlobsToolType.FindInputFixtureCell(countBlobsToolType.vOpCTK9lVp).Expression;
										cellLocation = countBlobsToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, countBlobsToolType.PQuCC3eBFg);
										num4 = 33;
										continue;
									case 61:
										CvsTraceEzb.Info.TraceMessage((string)VVmiTXKQaECgm761SDkr(49466));
										goto case 6;
									case 66:
										result3 = awaiter5.GetResult();
										num4 = 63;
										continue;
									case 7:
										result4 = awaiter3.GetResult();
										AaWnUEKQIESdutxonHuB(CvsTraceEzb.Info, VVmiTXKQaECgm761SDkr(49842));
										_003CnewTool_003E5__6 = new CountBlobsTool((InspectStepViewModel)HE9qEMKmztrjb3GEA9V7(countBlobsToolType), isInitialized: false);
										num4 = 19;
										continue;
									case 50:
										num2 = (_003C_003E1__state = 3);
										num4 = 53;
										if (true)
										{
											continue;
										}
										goto case 40;
									case 40:
										_003CpasteRange_003E5__3 = result2;
										num4 = 51;
										continue;
									case 22:
										goto IL_0733;
									case 14:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										num4 = 47;
										continue;
									case 0:
										if (!awaiter.IsCompleted)
										{
											num2 = (_003C_003E1__state = 8);
											_003C_003Eu__3 = awaiter;
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											num4 = 10;
											continue;
										}
										goto case 52;
									case 63:
										CvsTraceEzb.Info.TraceMessage(CdQUGaROfy7He9T0foW.KbIzwHEDLa(50806));
										num4 = 23;
										continue;
									case 52:
										awaiter.GetResult();
										num4 = 25;
										if (true)
										{
											continue;
										}
										goto case 54;
									case 54:
										_003C_003Eu__4 = awaiter4;
										num4 = 38;
										if (!nn2WSmKmtZ9jZAy6FnlA())
										{
											continue;
										}
										goto case 24;
									case 24:
										awaiter6.GetResult();
										num4 = 4;
										continue;
									case 53:
										_003C_003Eu__4 = awaiter4;
										num4 = 28;
										continue;
									case 46:
										dictionary.Add(EzSnippet.AssembleFullCellName(_003CtoolName_003E5__5, (string)VVmiTXKQaECgm761SDkr(6138)), (int)result3);
										num4 = 26;
										continue;
									case 39:
										return;
									case 67:
										goto IL_084f;
									case 3:
										goto IL_089a;
									case 5:
										num2 = (_003C_003E1__state = -1);
										num4 = 66;
										continue;
									case 49:
										_003C_003Eu__5 = awaiter5;
										num4 = 44;
										continue;
									case 37:
										_003C_003Eu__1 = awaiter2;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num4 = 65;
										continue;
									case 47:
										return;
									case 65:
										return;
									case 25:
										AaWnUEKQIESdutxonHuB(CvsTraceEzb.Info, VVmiTXKQaECgm761SDkr(50846));
										num4 = 68;
										continue;
									case 42:
										awaiter6 = _003Csheet_003E5__2.PutCellExpressionAsync(countBlobsToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, countBlobsToolType.L0ICWDMgTq), (string)MfZInMKQJa8T15X82d04(countBlobsToolType.InputImageLinks[rCFnJkKQwMBVp2PG4eom(countBlobsToolType)])).GetAwaiter();
										num4 = 64;
										continue;
									case 60:
										awaiter5 = _003Csheet_003E5__2.GetCellPropertyAsync<double>(countBlobsToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, countBlobsToolType.h1SCOn83HG), (string)VVmiTXKQaECgm761SDkr(1524)).GetAwaiter();
										if (!awaiter5.IsCompleted)
										{
											num4 = 29;
											continue;
										}
										goto case 66;
									case 13:
										_003C_003Eu__6 = default;
										num4 = 2;
										continue;
									case 64:
										if (!awaiter6.IsCompleted)
										{
											num2 = (_003C_003E1__state = 1);
											num4 = 21;
											continue;
										}
										goto case 24;
									case 28:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										num4 = 59;
										if (0 == 0)
										{
											continue;
										}
										goto case 26;
									case 26:
										awaiter3 = _003Csheet_003E5__2.RunAndGetCellResults(dictionary).GetAwaiter();
										if (!awaiter3.IsCompleted)
										{
											num2 = (_003C_003E1__state = 7);
											_003C_003Eu__6 = awaiter3;
											num4 = 14;
											continue;
										}
										goto case 7;
									case 68:
										result = _003CnewTool_003E5__6;
										goto end_IL_0090;
									}
									CvsTraceEzb.Info.TraceMessage((string)VVmiTXKQaECgm761SDkr(49608));
									_ = 1;
									num4 = (nn2WSmKmtZ9jZAy6FnlA() ? 6 : 57);
									continue;
									IL_0733:
									if (!awaiter.IsCompleted)
									{
										num4 = 9;
										continue;
									}
									goto IL_056a;
									continue;
									end_IL_03fe:
									break;
								}
								goto IL_02a8;
								IL_084f:
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0864;
								IL_0609:
								awaiter = qVJcvjKQOoHfTYljxoO3(EditableGraphicHelper.SendGraphicAsync((CvsInSight)IC85cSKQL1bdDssYFiXy(HE9qEMKmztrjb3GEA9V7(countBlobsToolType)), countBlobsToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, countBlobsToolType.DX5CjXcMSg), countBlobsToolType.EditableComposite));
								num4 = 22;
								goto IL_03fe;
								IL_03e0:
								_003C_003Eu__3 = default;
								goto IL_0561;
								IL_0561:
								num2 = (_003C_003E1__state = -1);
								goto IL_056a;
								IL_056a:
								awaiter.GetResult();
								num4 = 61;
								if (!nn2WSmKmtZ9jZAy6FnlA())
								{
									goto IL_03fe;
								}
								goto IL_0581;
								IL_0581:
								num2 = (_003C_003E1__state = -1);
								num4 = 7;
								if (!nn2WSmKmtZ9jZAy6FnlA())
								{
									goto IL_03fe;
								}
								goto IL_059a;
								IL_059a:
								awaiter = qVJcvjKQOoHfTYljxoO3(n7kIBoKQDcWUuk8osPOZ(_003CnewTool_003E5__6, result4, _003CpasteRange_003E5__3));
								num4 = 0;
								goto IL_03fe;
								IL_0342:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
								num4 = 39;
								goto IL_03fe;
								IL_02a8:
								num2 = (_003C_003E1__state = 6);
								num4 = 49;
								goto IL_03fe;
								IL_0864:
								awaiter.GetResult();
								awaiter4 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
								if (awaiter4.IsCompleted)
								{
									goto IL_053b;
								}
								num4 = 50;
								if (Jn5J2rKmhD2Slwm4SFTL())
								{
									goto IL_03fe;
								}
								goto IL_089a;
								IL_053b:
								awaiter4.GetResult();
								AaWnUEKQIESdutxonHuB(CvsTraceEzb.Info, CdQUGaROfy7He9T0foW.KbIzwHEDLa(49436));
								num4 = 12;
								goto IL_03fe;
								IL_089a:
								num2 = (_003C_003E1__state = 0);
								num4 = 37;
								goto IL_03fe;
								end_IL_0090:
								break;
							}
						}
						catch (object obj)
						{
							_003C_003E7__wrap3 = obj;
							num3 = 1;
							goto IL_0a77;
						}
						goto end_IL_0057;
						IL_0a77:
						if (num3 == 1)
						{
							awaiter = qVJcvjKQOoHfTYljxoO3(countBlobsToolType.CleanUpPastedToolOnFailedAdd(_003CpasteRange_003E5__3));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 9);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0adf;
						}
						goto IL_0b08;
						IL_0adf:
						awaiter.GetResult();
						htC0JYKQn18kBVyre0Mw(U4kTIjKQipflS2WdACLo((_003C_003E7__wrap3 as Exception) ?? throw _003C_003E7__wrap3));
						goto IL_0b08;
						IL_0b08:
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
					goto IL_0b64;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					break;
				case 1:
				case 2:
					break;
				case 7:
					return;
				}
				countBlobsToolType = _003C_003E4__this;
				num = 5;
			}
			while (0 == 0);
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
		internal static object HE9qEMKmztrjb3GEA9V7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IC85cSKQL1bdDssYFiXy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object L5U7uAKQKP9UEpQ5stCP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MvHiYTKQ5gQUmvEQpYd1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int rCFnJkKQwMBVp2PG4eom(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).InputImageIndex;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MfZInMKQJa8T15X82d04(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VVmiTXKQaECgm761SDkr(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object sY7Wf2KQegMIBJCdxN6b(object P_0, object P_1, CvsCellLocation P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return InputFixtureViewModel.YnAyJgATSB((InspectStepViewModel)P_0, (string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter qVJcvjKQOoHfTYljxoO3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void AaWnUEKQIESdutxonHuB(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceMessage((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object n7kIBoKQDcWUuk8osPOZ(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object U4kTIjKQipflS2WdACLo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void htC0JYKQn18kBVyre0Mw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Jn5J2rKmhD2Slwm4SFTL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nn2WSmKmtZ9jZAy6FnlA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly Guid KkdCRAP380;

	private static readonly Guid[] D8sC4IYd8w;

	private readonly Dispatcher vJaCl6LyTl;

	private readonly PasteBuffer vOpCTK9lVp;

	private readonly CvsCellLocation L0ICWDMgTq;

	private readonly CvsCellLocation DX5CjXcMSg;

	private readonly CvsCellLocation PQuCC3eBFg;

	private readonly CvsCellLocation h1SCOn83HG;

	private int ADhCHrLDf7;

	[CompilerGenerated]
	private readonly Func<CvsCogShape, bool> uYSCwvb4tF;

	private int aFJCyiR1Lc;

	private int ToxCxsIbMM;

	private CvsEditableDisplayGraphic[] QjmCvyGm7k;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return D8sC4IYd8w;
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
			return (string)jivF4xRtaVSTA1ZhpZO();
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
			return (string)jV8ZjwRziAByqgtt08y();
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

	public override string Directions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.loZZGY8CBw();
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
			return XAMLGraphicKeys.Tools_CountBlobsIcon;
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
			return XAMLGraphicKeys.Tools_CountBlobsIcon;
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
				Resources.Inspect,
				(string)KZYDIHWLLn9srpdSQFo()
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
			return ADhCHrLDf7;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref ADhCHrLDf7, value, (string)vZM2WjRhBsE5gCOUFnG(3256));
		}
	}

	public override Func<CvsCogShape, bool> GraphicsLayerFilter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return uYSCwvb4tF;
		}
	}

	public int RangeMin
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aFJCyiR1Lc;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref aFJCyiR1Lc, value, (string)vZM2WjRhBsE5gCOUFnG(27124));
		}
	}

	public int RangeMax
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ToxCxsIbMM;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref ToxCxsIbMM, value, (string)vZM2WjRhBsE5gCOUFnG(27144));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CountBlobsToolType()
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
			case 10:
				DX5CjXcMSg = vOpCTK9lVp.GetCellOffset(CdQUGaROfy7He9T0foW.KbIzwHEDLa(5684));
				num = 8;
				continue;
			case 9:
				vJaCl6LyTl = Dispatcher.CurrentDispatcher;
				vOpCTK9lVp = (PasteBuffer)PGh9qaRupoDe1AgDkfb(OUexGgR1WXqo0gN9exg());
				num = 1;
				continue;
			case 6:
				ADhCHrLDf7 = 305;
				num = 0;
				continue;
			case 0:
				base._002Ector();
				num = 9;
				continue;
			case 3:
				AddSnippet(vOpCTK9lVp);
				num = 11;
				if (K2Ks1eR2XRog7Eyrbob())
				{
				}
				continue;
			case 4:
				nlwqLjRcJEfj4GpoBOO();
				num = 6;
				continue;
			case 8:
				PQuCC3eBFg = vOpCTK9lVp.GetCellOffset(CdQUGaROfy7He9T0foW.KbIzwHEDLa(6522));
				break;
			case 1:
				L0ICWDMgTq = vOpCTK9lVp.GetCellOffset((string)vZM2WjRhBsE5gCOUFnG(4928));
				goto default;
			default:
				_ = 0;
				num = (Si33JaRN1foVXQAGaMs() ? 10 : 2);
				continue;
			case 2:
			case 7:
				break;
			case 11:
				return;
			}
			h1SCOn83HG = vOpCTK9lVp.GetCellOffset((string)vZM2WjRhBsE5gCOUFnG(26986));
			num = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateTool_003Ed__40))]
	public override Task<EzTool> CreateTool(Guid guid, CvsCellCollection cells, CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateTool_003Ed__40 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.guid = guid;
		stateMachine.cells = cells;
		stateMachine.cellRange = cellRange;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnBeginAddInternal_003Ed__41))]
	protected override Task OnBeginAddInternal()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (!K2Ks1eR2XRog7Eyrbob())
		{
		}
		_003COnBeginAddInternal_003Ed__41 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				K2Ks1eR2XRog7Eyrbob();
				num = ((!Si33JaRN1foVXQAGaMs()) ? 3 : 0);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetEditableGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return QjmCvyGm7k;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddTool_003Ed__44))]
	public override Task<EzTool> AddTool()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddTool_003Ed__44 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		cells.GetSnippetVersion(range);
		SnippetPasteBuffer.GetSnippetVersion(vOpCTK9lVp);
		return new ISnippetUpdate[0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CountBlobsToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Si33JaRN1foVXQAGaMs();
		int num;
		if (!K2Ks1eR2XRog7Eyrbob())
		{
			num = 1;
		}
		else
		{
			num = 3;
			if (!Si33JaRN1foVXQAGaMs())
			{
				goto IL_0081;
			}
		}
		goto IL_004e;
		IL_004e:
		while (true)
		{
			switch (num)
			{
			case 4:
				KkdCRAP380 = new Guid((string)vZM2WjRhBsE5gCOUFnG(27366));
				goto IL_0090;
			case 0:
			case 1:
				break;
			default:
				goto IL_0090;
			case 5:
				return;
			}
			break;
			IL_0090:
			D8sC4IYd8w = new Guid[1] { KkdCRAP380 };
			num = 5;
		}
		goto IL_0081;
		IL_0081:
		nlwqLjRcJEfj4GpoBOO();
		num = 4;
		goto IL_004e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task MLjCMW65yW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnBeginAddInternal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nlwqLjRcJEfj4GpoBOO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OUexGgR1WXqo0gN9exg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.CountBlobs;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PGh9qaRupoDe1AgDkfb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vZM2WjRhBsE5gCOUFnG(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Si33JaRN1foVXQAGaMs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool K2Ks1eR2XRog7Eyrbob()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jivF4xRtaVSTA1ZhpZO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.XWVZkgalu6();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jV8ZjwRziAByqgtt08y()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.jmTZsQCCIX();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KZYDIHWLLn9srpdSQFo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.qm5ZLplBc4();
	}
}
