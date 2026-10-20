using System;
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
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime.ViewModels.Cells;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.FindEdge;

[Export(typeof(FindEdgeTool))]
public class FindEdgeTool : EzTool
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CShiftEditGraphics_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FindEdgeTool _003C_003E4__this;

		public int delta;

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
			FindEdgeTool findEdgeTool = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 4:
					findEdgeTool = _003C_003E4__this;
					_ = 1;
					num = (ROXG9vKYKYsFDXs2ANP8() ? 1 : 5);
					continue;
				case 2:
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = LGjpJUKY5Hi1XqFtn1gU(findEdgeTool.Region.Shift(delta));
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								return;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 2;
								continue;
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								if (true)
								{
									continue;
								}
								goto case 7;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								break;
							case 0:
								return;
							case 1:
								_003C_003Eu__1 = awaiter;
								_ = 0;
								if (!PbLem7KYLvSfqs6o2Y5a())
								{
									num3 = 0;
									continue;
								}
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 2;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
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
		internal static TaskAwaiter LGjpJUKY5Hi1XqFtn1gU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PbLem7KYLvSfqs6o2Y5a()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ROXG9vKYKYsFDXs2ANP8()
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
	private struct _003CWriteFixturedGraphics_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FindEdgeTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (tFSFKsKYJS2wkCIHnyMt() ? 2 : 4);
			int num2 = default;
			FindEdgeTool findEdgeTool = default;
			TaskAwaiter<CvsCogSheetResult> awaiter = default;
			TaskAwaiter awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (wUsdCxKYwe2IsGSdkKDK())
					{
						break;
					}
					goto case 1;
				case 1:
				case 2:
					findEdgeTool = _003C_003E4__this;
					num = 3;
					if (true)
					{
						break;
					}
					goto case 3;
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								_ = 1;
								num3 = (tFSFKsKYJS2wkCIHnyMt() ? 5 : 14);
							}
							else
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num3 = 9;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 4;
							if (false)
							{
								goto IL_0251;
							}
						}
						goto IL_00db;
						IL_0251:
						_003C_003Eu__2 = awaiter;
						num3 = 1;
						goto IL_00db;
						IL_00db:
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 14:
								awaiter2 = ((Task)M4YbYXKYOse6RxKgES1R(findEdgeTool.InSight, cXq9nPKYae0eXMbEJMLQ(findEdgeTool.Region), taRpvYKYeBPwpjNmWitt(findEdgeTool.Region))).GetAwaiter();
								num3 = 11;
								continue;
							case 4:
								_003C_003Eu__1 = default;
								goto case 2;
							default:
								num3 = 2;
								continue;
							case 3:
							case 5:
								_003C_003Eu__1 = awaiter2;
								num3 = 12;
								continue;
							case 2:
								num2 = (_003C_003E1__state = -1);
								goto IL_0148;
							case 13:
								num2 = (_003C_003E1__state = 1);
								num3 = 6;
								continue;
							case 11:
								if (!awaiter2.IsCompleted)
								{
									num3 = 15;
									if (wUsdCxKYwe2IsGSdkKDK())
									{
										continue;
									}
									return;
								}
								goto IL_0148;
							case 8:
								return;
							case 10:
								if (!awaiter.IsCompleted)
								{
									num3 = 13;
									continue;
								}
								goto case 16;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								if (wUsdCxKYwe2IsGSdkKDK())
								{
									continue;
								}
								goto case 1;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								if (tFSFKsKYJS2wkCIHnyMt())
								{
								}
								continue;
							case 12:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 7;
								continue;
							case 7:
								return;
							case 6:
								break;
							case 15:
								num2 = (_003C_003E1__state = 0);
								goto case 3;
							case 16:
								{
									awaiter.GetResult();
									goto end_IL_00db;
								}
								IL_0148:
								awaiter2.GetResult();
								awaiter = findEdgeTool.InSight.CogSocket.Sheet.RunAsync(fireSheetUpdated: false).GetAwaiter();
								num3 = 10;
								if (tFSFKsKYJS2wkCIHnyMt())
								{
								}
								continue;
							}
							goto IL_0251;
							continue;
							end_IL_00db:
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
					goto case 5;
				default:
					num = 5;
					if (1 == 0)
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
		internal static CvsCellLocation cXq9nPKYae0eXMbEJMLQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object taRpvYKYeBPwpjNmWitt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EditableGraphicsViewModel)P_0).Graphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object M4YbYXKYOse6RxKgES1R(object P_0, CvsCellLocation loc, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wUsdCxKYwe2IsGSdkKDK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tFSFKsKYJS2wkCIHnyMt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private ListBoxViewModel VuM4qCxCYb;

	[CompilerGenerated]
	private ListBoxViewModel wjX4ihR2Z8;

	[CompilerGenerated]
	private EditIntViewModel QkM4kceEIP;

	[CompilerGenerated]
	private CheckBoxViewModel eCY4PZrLbK;

	[CompilerGenerated]
	private EditIntViewModel QN44sF1WEw;

	[CompilerGenerated]
	private EditIntViewModel UiK4Kulegr;

	[CompilerGenerated]
	private EditRegionViewModel cX04GoG9Ve;

	[CompilerGenerated]
	private LineViewModel k404Bk2IvP;

	[CompilerGenerated]
	private LineViewModel mI64ZOp4nb;

	public ListBoxViewModel Polarity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return VuM4qCxCYb;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VuM4qCxCYb = value;
		}
	}

	public ListBoxViewModel FindBy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wjX4ihR2Z8;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			wjX4ihR2Z8 = value;
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
			return QkM4kceEIP;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QkM4kceEIP = value;
		}
	}

	public CheckBoxViewModel NormalizeScore
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return eCY4PZrLbK;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			eCY4PZrLbK = value;
		}
	}

	public EditIntViewModel AngleRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return QN44sF1WEw;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QN44sF1WEw = value;
		}
	}

	public EditIntViewModel EdgeWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return UiK4Kulegr;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			UiK4Kulegr = value;
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
			return cX04GoG9Ve;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cX04GoG9Ve = value;
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
			return XAMLGraphicKeys.Tools_EdgeIcon;
		}
	}

	public LineViewModel OutputLine
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return k404Bk2IvP;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			k404Bk2IvP = value;
		}
	}

	public LineViewModel PixelLine
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mI64ZOp4nb;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			mI64ZOp4nb = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FindEdgeTool(InspectStepViewModel inspect, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		asH0fD3UmSSloRBwvKu();
		base._002Ector(inspect, isInitialized);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalParseCell(string relativeCellName, CvsCellCollection cells, CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!PoPZ793MYAjnbkEVsBC()) ? 8 : 27);
		uint num2 = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			case 11:
				AddProperty(AcceptThreshold);
				return;
			case 23:
				return;
			case 4:
				if (num2 != 20691314)
				{
					if (num2 != 1195222419)
					{
						return;
					}
					if (!(relativeCellName == (string)END5ct3xni2pT9JV56w(7570)))
					{
						num = 30;
						if (ulM0vt3YXXXBKYdYI5q())
						{
							return;
						}
						break;
					}
					InputRegion = new InputRegionViewModel(this, cells, loc, Resources.InputRegion, (string)EpFtMU3QmlY4dyUKH5p(), Region, IsInitialized);
					goto case 24;
				}
				if (!kuL03l3mXX3Jepb9Dyv(relativeCellName, END5ct3xni2pT9JV56w(25664)))
				{
					return;
				}
				PixelLine = new LineViewModel(InSight, cells, loc, (string)rB7V5Z3zORcOXVowGcw());
				num = 26;
				break;
			case 24:
				AddProperty(InputRegion);
				num = 19;
				break;
			case 12:
				return;
			case 21:
				return;
			case 19:
				return;
			case 8:
				return;
			case 28:
				if (num2 > 1195222419)
				{
					if (num2 != 1227782301)
					{
						num = 9;
						break;
					}
					if (kuL03l3mXX3Jepb9Dyv(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(5684)))
					{
						Region = new EditRegionViewModel(InSight, cells, loc, (string)tZgQvi3N4MRC5geXZEd(), fPRd3C32T32obeflb6M(InputImage), showXArrow: true, showYArrow: false, showAxesLabels: false);
						num = 13;
						break;
					}
					num = 16;
					if (!ulM0vt3YXXXBKYdYI5q())
					{
						break;
					}
					goto case 13;
				}
				num = 4;
				break;
			case 22:
				return;
			default:
				num = 24;
				break;
			case 15:
				if (num2 != 3118149576u || !kuL03l3mXX3Jepb9Dyv(relativeCellName, END5ct3xni2pT9JV56w(25630)))
				{
					return;
				}
				EdgeWidth = new EditIntViewModel(InSight, cells, loc, (string)vERQFu3tpB4KNaEvkGP());
				num = 10;
				break;
			case 2:
				if (num2 > 1409224077)
				{
					if (num2 <= 3118149576u)
					{
						num = 17;
						break;
					}
					switch (num2)
					{
					case 3184947036u:
						if (!kuL03l3mXX3Jepb9Dyv(relativeCellName, END5ct3xni2pT9JV56w(25652)))
						{
							num = 22;
							break;
						}
						OutputLine = new LineViewModel(InSight, cells, loc, (string)rB7V5Z3zORcOXVowGcw());
						num = 25;
						break;
					default:
						num = 29;
						break;
					case 3504813046u:
						if (kuL03l3mXX3Jepb9Dyv(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(25574)))
						{
							NormalizeScore = new CheckBoxViewModel(InSight, cells, loc, Resources.NormalizeScore, IsInitialized);
							AddProperty(NormalizeScore);
							num = 33;
						}
						else
						{
							num = 3;
						}
						break;
					}
				}
				else
				{
					num = 28;
					if (1 == 0)
					{
						return;
					}
				}
				break;
			case 16:
				return;
			case 14:
				return;
			case 18:
				return;
			case 0:
			case 27:
				num2 = p2bqkl3HxcLqVAmSwWm(relativeCellName);
				num = 2;
				if (1 == 0)
				{
					return;
				}
				break;
			case 31:
				return;
			case 5:
				return;
			case 30:
				return;
			case 13:
				AddProperty(Region);
				return;
			case 9:
				switch (num2)
				{
				case 1409224077u:
					if (!kuL03l3mXX3Jepb9Dyv(relativeCellName, END5ct3xni2pT9JV56w(25606)))
					{
						return;
					}
					AngleRange = new EditIntViewModel(InSight, cells, loc, (string)RgxU7S3hHVfQwyKwnkU());
					num = 6;
					break;
				case 1358348419u:
					if (kuL03l3mXX3Jepb9Dyv(relativeCellName, END5ct3xni2pT9JV56w(25558)))
					{
						FindBy = new ListBoxViewModel(InSight, cells, loc, (string)TWY9fv3174bjDkF0jBl());
						AddProperty(FindBy);
						num = 7;
					}
					else
					{
						num = 18;
					}
					break;
				default:
					num = 21;
					break;
				}
				break;
			case 29:
				if (num2 == 4292390121u)
				{
					if (!kuL03l3mXX3Jepb9Dyv(relativeCellName, END5ct3xni2pT9JV56w(11110)))
					{
						num = 31;
						break;
					}
					Polarity = new ListBoxViewModel(InSight, cells, loc, (string)AQHsS23cKAJ3PBqNKPZ());
					AddProperty(Polarity);
					num = 14;
					if (0 == 0)
					{
						break;
					}
					goto case 9;
				}
				num = 12;
				break;
			case 20:
				return;
			case 6:
				AddProperty(AngleRange);
				num = 1;
				break;
			case 33:
				return;
			case 10:
				AddProperty(EdgeWidth);
				num = 5;
				break;
			case 1:
				return;
			case 7:
				return;
			case 32:
				return;
			case 26:
				AddProperty(PixelLine);
				num = 34;
				break;
			case 17:
				if (num2 == 2900939788u)
				{
					if (!kuL03l3mXX3Jepb9Dyv(relativeCellName, END5ct3xni2pT9JV56w(20144)))
					{
						num = 32;
						break;
					}
					AcceptThreshold = new EditIntViewModel(InSight, cells, loc, (string)hXrflY3upugyLqyqXS1());
					num = 11;
				}
				else
				{
					num = 15;
				}
				break;
			case 25:
				AddProperty(OutputLine);
				num = 20;
				break;
			case 34:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetFeatures(CvsCellCollection cells, CellType reqDataType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		List<CvsEditableDisplayGraphic> list = default;
		while (true)
		{
			switch (num)
			{
			default:
				list.Add(EditableGraphicHelper.ConstructLine(fPRd3C32T32obeflb6M(PixelLine), cells, OutputLine.CellLocation.ToString(absoluteRow: true, absoluteColumn: true)));
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
				list = new List<CvsEditableDisplayGraphic>();
				PoPZ793MYAjnbkEVsBC();
				if (!ulM0vt3YXXXBKYdYI5q())
				{
					num = 3;
					if (ulM0vt3YXXXBKYdYI5q())
					{
					}
				}
				else
				{
					num = 4;
				}
				continue;
			case 1:
			case 3:
				if (reqDataType != CellType.Line)
				{
					break;
				}
				goto default;
			case 5:
				break;
			}
			break;
		}
		return (CvsEditableDisplayGraphic[])kjXVuOjLHgJ4hGhPC8V(list);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CShiftEditGraphics_003Ed__41))]
	public override Task ShiftEditGraphics(int delta)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (PoPZ793MYAjnbkEVsBC())
		{
			num = 4;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 6;
			if (false)
			{
				goto IL_0044;
			}
		}
		goto IL_009a;
		IL_005c:
		_003CShiftEditGraphics_003Ed__41 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		num = 2;
		goto IL_009a;
		IL_0044:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 7;
		goto IL_009a;
		IL_0026:
		stateMachine._003C_003Et__builder = Go5MwcjKcnL3WtbNsEi();
		goto IL_005c;
		IL_009a:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			case 3:
				goto IL_0044;
			case 1:
			case 6:
				goto IL_005c;
			case 5:
				stateMachine._003C_003E1__state = -1;
				num = 3;
				continue;
			case 2:
				stateMachine.delta = delta;
				goto case 5;
			default:
				num = 5;
				continue;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetViewableEditGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		PoPZ793MYAjnbkEVsBC();
		int num = (ulM0vt3YXXXBKYdYI5q() ? 1 : 2);
		CvsEditableDisplayGraphic cvsEditableDisplayGraphic = default;
		List<CvsEditableDisplayGraphic> list = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				cvsEditableDisplayGraphic = (CvsEditableDisplayGraphic)FmfxO2j5uYqTIL2gvcx(Region);
				num = 4;
				continue;
			case 4:
				if (cvsEditableDisplayGraphic == null)
				{
					break;
				}
				goto default;
			default:
				list.Add(cvsEditableDisplayGraphic);
				num = 6;
				continue;
			case 0:
			case 2:
				list = new List<CvsEditableDisplayGraphic>();
				num = 5;
				if (PoPZ793MYAjnbkEVsBC())
				{
					continue;
				}
				break;
			case 6:
				break;
			}
			break;
		}
		return (CvsEditableDisplayGraphic[])kjXVuOjLHgJ4hGhPC8V(list);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteFixturedGraphics_003Ed__43))]
	internal override Task WriteFixturedGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CWriteFixturedGraphics_003Ed__43 stateMachine = default;
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
				if (true)
				{
					break;
				}
				goto case 3;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003Et__builder = Go5MwcjKcnL3WtbNsEi();
				_ = 1;
				num = (ulM0vt3YXXXBKYdYI5q() ? 4 : 0);
				break;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void asH0fD3UmSSloRBwvKu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PoPZ793MYAjnbkEVsBC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ulM0vt3YXXXBKYdYI5q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint p2bqkl3HxcLqVAmSwWm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object END5ct3xni2pT9JV56w(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kuL03l3mXX3Jepb9Dyv(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EpFtMU3QmlY4dyUKH5p()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.rcKYeAISOR();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tZgQvi3N4MRC5geXZEd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Region;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation fPRd3C32T32obeflb6M(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AQHsS23cKAJ3PBqNKPZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Polarity;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TWY9fv3174bjDkF0jBl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.FindBy;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hXrflY3upugyLqyqXS1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.AcceptThreshold;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RgxU7S3hHVfQwyKwnkU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.AngleRange;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vERQFu3tpB4KNaEvkGP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.EdgeWidth;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rB7V5Z3zORcOXVowGcw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.OutputLine;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kjXVuOjLHgJ4hGhPC8V(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder Go5MwcjKcnL3WtbNsEi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FmfxO2j5uYqTIL2gvcx(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EditableGraphicsViewModel)P_0).Graphic;
	}
}
