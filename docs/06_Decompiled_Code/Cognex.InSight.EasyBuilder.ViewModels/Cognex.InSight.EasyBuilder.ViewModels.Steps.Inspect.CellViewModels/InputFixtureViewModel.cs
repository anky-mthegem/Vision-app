using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.ViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime.ViewModels.Cells;
using PwP36oJrJgiKa1qpQA;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class InputFixtureViewModel : InputStructureViewModel, FhUY4uBLEMII4DUtd7
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public CvsInSight insight;

		public Func<CvsCellLocation, bool> _003C_003E9__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass4_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CqwaZRKzB6H9d7xKjHQA();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CSetInitialFixtureExpression_003Eb__1(CellRefRange cellRef)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return D3IukVKz8tj16Ajxe1Dy(cellRef).All([MethodImpl(MethodImplOptions.NoInlining)] (CvsCellLocation loc) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return QkCVKoKzE7eUai0paUbK(KpsNotKzqkansZt6QOY1(insight.Results), loc) != null && !lVZ95WKzXZLPVDabknQ7(QkCVKoKzE7eUai0paUbK(KpsNotKzqkansZt6QOY1(jTF7fuKzpQoog2xPSgIc(insight)), loc));
			});
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CSetInitialFixtureExpression_003Eb__2(CvsCellLocation loc)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (QkCVKoKzE7eUai0paUbK(KpsNotKzqkansZt6QOY1(insight.Results), loc) != null)
			{
				return !lVZ95WKzXZLPVDabknQ7(QkCVKoKzE7eUai0paUbK(KpsNotKzqkansZt6QOY1(jTF7fuKzpQoog2xPSgIc(insight)), loc));
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void CqwaZRKzB6H9d7xKjHQA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool K9YtsPKzPXXnfkOyb62i()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tK71P2KzZRIQuG3I2Cxq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gdrvfVKzbSgiVUHV6UV6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).FunctionTable;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gnQsdaKzGX86K6BO8ZeB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).ProcessorConstants;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object C5pcxcKzolLSEHUIeYFS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int oV1YKhKzSTGOQQI3Kiku(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hT6rrQKzk0Nf112UNw4e(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsParse)P_0).CellReferences;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange D3IukVKz8tj16Ajxe1Dy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsReferenceRange)P_0).Range;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KpsNotKzqkansZt6QOY1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QkCVKoKzE7eUai0paUbK(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jTF7fuKzpQoog2xPSgIc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lVZ95WKzXZLPVDabknQ7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Error;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSetInitialFixtureExpression_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InspectStepViewModel inspect;

		public CvsCellLocation fixtureLoc;

		public string defaultFixture;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		private TaskAwaiter<bool> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Wddn68Kz4McT0jRIDFkD();
			int num;
			if (Why0MDKz98P1c4JGU93M())
			{
				num = 4;
			}
			else
			{
				num = 5;
				if (1 == 0)
				{
					goto IL_055d;
				}
			}
			goto IL_0576;
			IL_0039:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0576;
			IL_055d:
			_003Csheet_003E5__2 = null;
			goto IL_0039;
			IL_0576:
			int num2 = default;
			_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals6 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter = default;
			TaskAwaiter<bool> awaiter3 = default;
			TaskAwaiter<object> awaiter2 = default;
			SourceLink sourceLink = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 3;
					continue;
				case 1:
					break;
				case 3:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass4_0();
							_ = 0;
							num3 = ((!Why0MDKz98P1c4JGU93M()) ? 29 : 26);
							goto IL_030c;
						case 4:
							awaiter = _003C_003Eu__2;
							num3 = 9;
							goto IL_030c;
						case 2:
							awaiter3 = _003C_003Eu__3;
							num3 = 1;
							goto IL_030c;
						case 0:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 5;
							goto IL_030c;
						case 3:
							awaiter2 = _003C_003Eu__1;
							num3 = 4;
							if (1 == 0)
							{
								goto IL_021e;
							}
							goto IL_030c;
						case 1:
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num3 = 13;
								goto IL_030c;
							}
							IL_0227:
							awaiter2.GetResult();
							num3 = 25;
							if (Wddn68Kz4McT0jRIDFkD())
							{
								goto IL_023f;
							}
							goto IL_030c;
							IL_023f:
							num2 = (_003C_003E1__state = -1);
							num3 = 35;
							goto IL_030c;
							IL_030c:
							while (true)
							{
								switch (num3)
								{
								case 32:
									return;
								case 9:
									_003C_003Eu__2 = default;
									num3 = 10;
									continue;
								case 17:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 6;
									continue;
								case 18:
									return;
								case 27:
									awaiter.GetResult();
									awaiter3 = _003Csheet_003E5__2.GetCellPropertyAsync<bool>(fixtureLoc, CdQUGaROfy7He9T0foW.KbIzwHEDLa(51222)).GetAwaiter();
									num3 = 23;
									continue;
								case 23:
									if (!awaiter3.IsCompleted)
									{
										num3 = 30;
										continue;
									}
									goto IL_01ea;
								case 14:
									num2 = (_003C_003E1__state = 4);
									num3 = 16;
									continue;
								case 20:
									awaiter2 = _003Csheet_003E5__2.PutCellExpressionAsync(fixtureLoc, (string)jJYkalKzjccl4kMGE4J8(sourceLink)).GetAwaiter();
									num3 = 15;
									continue;
								case 4:
									_003C_003Eu__1 = default;
									num3 = 11;
									if (Why0MDKz98P1c4JGU93M())
									{
										continue;
									}
									goto case 28;
								case 28:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								case 12:
									num2 = (_003C_003E1__state = 1);
									num3 = 33;
									continue;
								case 33:
									_003C_003Eu__2 = awaiter;
									num3 = 17;
									continue;
								case 1:
									_003C_003Eu__3 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_01ea;
								case 22:
									return;
								case 5:
									break;
								case 10:
									goto IL_023f;
								case 3:
									_003C_003Eu__1 = awaiter2;
									num3 = 28;
									if (!Wddn68Kz4McT0jRIDFkD())
									{
										continue;
									}
									goto case 31;
								case 31:
									awaiter = _003Csheet_003E5__2.RunAsync().GetAwaiter();
									num3 = 34;
									continue;
								case 25:
									awaiter = _003Csheet_003E5__2.RunAsync().GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num3 = 12;
										continue;
									}
									goto case 27;
								case 16:
									_003C_003Eu__2 = awaiter;
									num3 = 24;
									continue;
								case 6:
									return;
								case 2:
									_003C_003Eu__3 = awaiter3;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								default:
									num3 = 18;
									continue;
								case 21:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 22;
									continue;
								case 8:
									num2 = (_003C_003E1__state = 0);
									num3 = 3;
									continue;
								case 7:
									if (!awaiter2.IsCompleted)
									{
										num2 = (_003C_003E1__state = 3);
										_003C_003Eu__1 = awaiter2;
										num3 = 21;
										continue;
									}
									goto IL_04ff;
								case 24:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 32;
									continue;
								case 34:
									if (!awaiter.IsCompleted)
									{
										num3 = 14;
										if (Wddn68Kz4McT0jRIDFkD())
										{
										}
										continue;
									}
									goto case 35;
								case 19:
								case 29:
									awaiter2 = _003Csheet_003E5__2.PutCellExpressionAsync(fixtureLoc, defaultFixture).GetAwaiter();
									num3 = 7;
									continue;
								case 0:
								case 26:
								{
									List<SourceLink> links = InputStructureViewModel.GetLinks(inspect, null, CellType.Fixture);
									CS_0024_003C_003E8__locals6.insight = (CvsInSight)BAJOY2Kz7FqAnLlVri8I(inspect);
									_003Csheet_003E5__2 = ((CvsCogSocket)G152KfKz3acFxmbhNL07(CS_0024_003C_003E8__locals6.insight)).Sheet;
									sourceLink = links.FirstOrDefault(ValidateLinkExpression);
									if (sourceLink != null)
									{
										num3 = 20;
										continue;
									}
									goto case 25;
								}
								case 30:
									num2 = (_003C_003E1__state = 2);
									num3 = 2;
									if (0 == 0)
									{
										continue;
									}
									goto case 15;
								case 15:
									if (awaiter2.IsCompleted)
									{
										goto IL_0227;
									}
									num3 = 8;
									if (Why0MDKz98P1c4JGU93M())
									{
										continue;
									}
									goto case 13;
								case 13:
									num2 = (_003C_003E1__state = -1);
									num3 = 27;
									continue;
								case 11:
									num2 = (_003C_003E1__state = -1);
									goto IL_04ff;
								case 35:
									{
										awaiter.GetResult();
										goto end_IL_004f;
									}
									IL_01ea:
									if (awaiter3.GetResult())
									{
										goto case 19;
									}
									goto end_IL_004f;
									IL_04ff:
									awaiter2.GetResult();
									num3 = 31;
									if (0 == 0)
									{
										continue;
									}
									goto case 35;
								}
								break;
							}
							goto IL_021e;
							IL_021e:
							num2 = (_003C_003E1__state = -1);
							goto IL_0227;
							end_IL_004f:
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Csheet_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto IL_055d;
				case 2:
				case 5:
					goto IL_055d;
				default:
					num = 1;
					if (!Wddn68Kz4McT0jRIDFkD())
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_0039;
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
		internal static object BAJOY2Kz7FqAnLlVri8I(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object G152KfKz3acFxmbhNL07(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jJYkalKzjccl4kMGE4J8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Why0MDKz98P1c4JGU93M()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Wddn68Kz4McT0jRIDFkD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private SourceLink GSFy9Nvq30;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.Fixture;
		}
	}

	public IEnumerable<FormatStringArgument> FormatStringArguments
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			string text = CellLocation.ToString(absoluteRow: true, absoluteColumn: true);
			return new List<FormatStringArgument>
			{
				new FormatStringArgument(CdQUGaROfy7He9T0foW.KbIzwHEDLa(28102), CdQUGaROfy7He9T0foW.KbIzwHEDLa(28224) + text + CdQUGaROfy7He9T0foW.KbIzwHEDLa(6970), FormatStringDataType.FloatingPoint),
				new FormatStringArgument(CdQUGaROfy7He9T0foW.KbIzwHEDLa(28130), CdQUGaROfy7He9T0foW.KbIzwHEDLa(28238) + text + CdQUGaROfy7He9T0foW.KbIzwHEDLa(6970), FormatStringDataType.FloatingPoint),
				new FormatStringArgument(CdQUGaROfy7He9T0foW.KbIzwHEDLa(24406), CdQUGaROfy7He9T0foW.KbIzwHEDLa(28252) + text, FormatStringDataType.FloatingPoint)
			};
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InputFixtureViewModel(EzTool tool, CvsCellCollection cells, CvsCellLocation loc, string displayName, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (!T2KQrQY7J2pSxeDlHR6())
		{
			goto IL_001e;
		}
		goto IL_00c4;
		IL_001e:
		RefreshLinks(updateMember: true);
		num = 8;
		goto IL_00c4;
		IL_00c4:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 1:
			case 6:
				GSFy9Nvq30 = new SourceLink((string)ug61r5Y6VbGCudX4IjV(), (string)EabQuAYCXYeKrTmhRhw(1838), CellType.Fixture);
				goto case 2;
			case 3:
				do
				{
					roR5EqYjYX8Qs3uaTMT();
					_ = 0;
					if (!T2KQrQY7J2pSxeDlHR6())
					{
						num = 7;
						continue;
					}
					num = 6;
					break;
				}
				while (!T2KQrQY7J2pSxeDlHR6());
				continue;
			case 2:
			case 7:
				base._002Ector(tool, loc, displayName, isInitialized);
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 4;
			case 4:
				Refresh(cells, init: true);
				num = 0;
				continue;
			case 5:
				DefaultLink = GSFy9Nvq30;
				goto case 4;
			default:
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				return;
			case 8:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetInitialFixtureExpression_003Ed__4))]
	internal static Task YnAyJgATSB(InspectStepViewModel P_0, string P_1, CvsCellLocation P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CSetInitialFixtureExpression_003Ed__4 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine.defaultFixture = P_1;
				RYLS6DY3S43C0BvQWB8();
				num = ((!T2KQrQY7J2pSxeDlHR6()) ? 1 : 6);
				break;
			case 3:
			case 6:
				stateMachine.fixtureLoc = P_2;
				goto case 7;
			default:
				num = 7;
				break;
			case 1:
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 4;
				break;
			case 7:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			case 4:
				stateMachine.inspect = P_0;
				num = 0;
				if (RYLS6DY3S43C0BvQWB8())
				{
				}
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void roR5EqYjYX8Qs3uaTMT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ug61r5Y6VbGCudX4IjV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.rvMLAYkyXc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EabQuAYCXYeKrTmhRhw(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool T2KQrQY7J2pSxeDlHR6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RYLS6DY3S43C0BvQWB8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
