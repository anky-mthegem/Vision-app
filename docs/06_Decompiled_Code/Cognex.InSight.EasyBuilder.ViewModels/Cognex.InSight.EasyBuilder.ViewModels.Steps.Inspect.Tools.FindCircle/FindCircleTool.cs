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
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime.ViewModels.Cells;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.FindCircle;

[Export(typeof(FindCircleTool))]
public class FindCircleTool : EzTool
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CShiftEditGraphics_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FindCircleTool _003C_003E4__this;

		public int delta;

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
			goto IL_0181;
			IL_0031:
			int num2 = default;
			FindCircleTool findCircleTool = default;
			try
			{
				TaskAwaiter awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = ((Task)T96sCKKUJSq7GgYymiEh(findCircleTool.Annulus, delta)).GetAwaiter();
					_ = 0;
					num3 = ((!ovJ0ZsKU5ceOpUVst9uu()) ? 5 : 7);
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 3;
					if (!ovJ0ZsKU5ceOpUVst9uu())
					{
						goto IL_0094;
					}
				}
				goto IL_00db;
				IL_00db:
				while (true)
				{
					switch (num3)
					{
					case 6:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					default:
						return;
					case 5:
						return;
					case 0:
					case 7:
						break;
					case 2:
						_003C_003Eu__1 = awaiter;
						num3 = 1;
						continue;
					case 1:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 3:
						_003C_003Eu__1 = default;
						num3 = 6;
						continue;
					case 8:
						num2 = (_003C_003E1__state = 0);
						num3 = 2;
						continue;
					case 9:
						goto IL_0141;
					}
					break;
				}
				goto IL_0094;
				IL_0141:
				awaiter.GetResult();
				goto end_IL_0031;
				IL_0094:
				if (!awaiter.IsCompleted)
				{
					num3 = 8;
					goto IL_00db;
				}
				goto IL_0141;
				end_IL_0031:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01ac;
			IL_0181:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					break;
				case 2:
				case 5:
					goto IL_0031;
				default:
					num = 3;
					continue;
				case 3:
					goto IL_01ac;
				case 4:
					goto IL_01c1;
				case 6:
					return;
				}
				break;
				IL_01c1:
				num2 = _003C_003E1__state;
				_ = 1;
				if (DfWWHZKUwB4cyOtJOZ38())
				{
					num = 5;
					continue;
				}
				num = 0;
				if (1 == 0)
				{
					return;
				}
			}
			goto IL_001a;
			IL_01ac:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0181;
			IL_001a:
			findCircleTool = _003C_003E4__this;
			goto IL_0031;
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
		internal static object T96sCKKUJSq7GgYymiEh(object P_0, float delta)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EditableGraphicsViewModel)P_0).Shift(delta);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ovJ0ZsKU5ceOpUVst9uu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DfWWHZKUwB4cyOtJOZ38()
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
	private struct _003CWriteFixturedGraphics_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FindCircleTool _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (!YQ5eGHKUaE9eM3Fk6U3i())
			{
				goto IL_001e;
			}
			goto IL_02b6;
			IL_001e:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_02b6;
			IL_02b6:
			int num2 = default;
			FindCircleTool findCircleTool = default;
			TaskAwaiter<CvsCogSheetResult> awaiter = default;
			TaskAwaiter awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 5:
					num2 = _003C_003E1__state;
					YQ5eGHKUaE9eM3Fk6U3i();
					if (!howwKUKUe7r2WnAf0Hvb())
					{
						num = 3;
						continue;
					}
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto case 2;
				case 1:
				case 3:
					findCircleTool = _003C_003E4__this;
					goto case 2;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 == 1)
							{
								awaiter = _003C_003Eu__2;
								goto IL_011c;
							}
							num3 = 2;
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 5;
							if (howwKUKUe7r2WnAf0Hvb())
							{
							}
						}
						goto IL_01c2;
						IL_01c2:
						while (true)
						{
							switch (num3)
							{
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 4;
								continue;
							case 13:
								num2 = (_003C_003E1__state = 1);
								num3 = 1;
								continue;
							case 1:
								_003C_003Eu__2 = awaiter;
								num3 = 6;
								if (YQ5eGHKUaE9eM3Fk6U3i())
								{
									continue;
								}
								goto case 6;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 0:
							case 12:
								break;
							case 2:
								awaiter2 = kVivF6KUDh3eYxSMvlM2(EditableGraphicHelper.SendGraphicAsync(findCircleTool.InSight, cCRXKkKUOwenTMKBlcTH(findCircleTool.Annulus), (CvsEditableDisplayGraphic)bixBOeKUIrFYyypNt49a(findCircleTool.Annulus)));
								num3 = 8;
								continue;
							case 8:
								if (!awaiter2.IsCompleted)
								{
									num3 = 11;
									continue;
								}
								goto IL_01a9;
							case 14:
								if (!awaiter.IsCompleted)
								{
									num3 = 13;
									continue;
								}
								goto case 16;
							case 3:
							case 9:
								_003C_003Eu__1 = awaiter2;
								num3 = 10;
								continue;
							case 4:
								num2 = (_003C_003E1__state = -1);
								goto IL_01a9;
							default:
								num3 = 15;
								continue;
							case 11:
								num2 = (_003C_003E1__state = 0);
								_ = 0;
								num3 = (YQ5eGHKUaE9eM3Fk6U3i() ? 9 : 0);
								continue;
							case 15:
								awaiter = ((CvsCogSocketSheet)W7LarWKUn4NMdLrXAZPa(zvJSDpKUic0XXxXGacH6(findCircleTool.InSight))).RunAsync(false).GetAwaiter();
								num3 = 14;
								continue;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								if (YQ5eGHKUaE9eM3Fk6U3i())
								{
									continue;
								}
								goto case 16;
							case 16:
								{
									awaiter.GetResult();
									goto end_IL_01c2;
								}
								IL_01a9:
								awaiter2.GetResult();
								goto case 15;
							}
							goto IL_011c;
							continue;
							end_IL_01c2:
							break;
						}
						goto end_IL_006d;
						IL_011c:
						_003C_003Eu__2 = default;
						num3 = 7;
						goto IL_01c2;
						end_IL_006d:;
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
					num = 0;
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
		internal static CvsCellLocation cCRXKkKUOwenTMKBlcTH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bixBOeKUIrFYyypNt49a(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EditableGraphicsViewModel)P_0).Graphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter kVivF6KUDh3eYxSMvlM2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zvJSDpKUic0XXxXGacH6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object W7LarWKUn4NMdLrXAZPa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YQ5eGHKUaE9eM3Fk6U3i()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool howwKUKUe7r2WnAf0Hvb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private ListBoxViewModel DMplDfHomM;

	[CompilerGenerated]
	private ListBoxViewModel wIhl3jvPie;

	[CompilerGenerated]
	private EditIntViewModel svilIGvMdd;

	[CompilerGenerated]
	private CheckBoxViewModel xWClfswp90;

	[CompilerGenerated]
	private EditIntViewModel Wa0lEhel6b;

	[CompilerGenerated]
	private CircleViewModel FE2lbO83ss;

	[CompilerGenerated]
	private CircleViewModel WOqlcDDZI8;

	[CompilerGenerated]
	private EditAnnulusViewModel jhKlQqguyq;

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
			return DMplDfHomM;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			DMplDfHomM = value;
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
			return wIhl3jvPie;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			wIhl3jvPie = value;
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
			return svilIGvMdd;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			svilIGvMdd = value;
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
			return xWClfswp90;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xWClfswp90 = value;
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
			return Wa0lEhel6b;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Wa0lEhel6b = value;
		}
	}

	public CircleViewModel OutputCircle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FE2lbO83ss;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			FE2lbO83ss = value;
		}
	}

	public CircleViewModel PixelCircle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WOqlcDDZI8;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WOqlcDDZI8 = value;
		}
	}

	public EditAnnulusViewModel Annulus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return jhKlQqguyq;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			jhKlQqguyq = value;
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
			return XAMLGraphicKeys.Tools_CircleIcon;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FindCircleTool(InspectStepViewModel inspect, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KhBWqKj8ShTFhsF1ApA();
		base._002Ector(inspect, isInitialized);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalParseCell(string relativeCellName, CvsCellCollection cells, CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 24;
		if (!yO7jnLjky8DeHc2Ejkk())
		{
		}
		uint num2 = default;
		while (true)
		{
			switch (num)
			{
			case 15:
				if (num2 <= 2407043987u)
				{
					if (num2 <= 1358348419)
					{
						if (num2 != 998425503)
						{
							if (num2 != 1358348419)
							{
								num = 10;
								break;
							}
							if (ID3oS9jpXwA5Vk0Eps0(relativeCellName, xWa9XcjE8s0FT7pQ2dU(25558)))
							{
								FindBy = new ListBoxViewModel(InSight, cells, loc, (string)F8QGTgj3UoYSglDZjBk());
								num = 28;
								break;
							}
							return;
						}
						if (!(relativeCellName == (string)xWa9XcjE8s0FT7pQ2dU(25912)))
						{
							num = 30;
							if (true)
							{
								break;
							}
							goto case 24;
						}
						PixelCircle = new CircleViewModel(InSight, cells, loc, (string)pyue1SjCSjUrNv7mCtV());
						num = 12;
						break;
					}
					if (num2 == 2166834857u)
					{
						if (!(relativeCellName == (string)xWa9XcjE8s0FT7pQ2dU(25896)))
						{
							num = 2;
							if (false)
							{
								return;
							}
							break;
						}
						OutputCircle = new CircleViewModel(InSight, cells, loc, Resources.wgbLCoYDjb());
						num = 9;
						if (1 == 0)
						{
							return;
						}
					}
					else
					{
						num = 25;
					}
					break;
				}
				if (num2 <= 3118149576u)
				{
					if (num2 != 2900939788u)
					{
						num = 11;
						break;
					}
					if (ID3oS9jpXwA5Vk0Eps0(relativeCellName, xWa9XcjE8s0FT7pQ2dU(20144)))
					{
						AcceptThreshold = new EditIntViewModel(InSight, cells, loc, Resources.AcceptThreshold);
						num = 3;
						if (0 == 0)
						{
							break;
						}
						goto case 1;
					}
					num = 14;
					if (!Fb9NdMjSWfIoDjPgDl2())
					{
						return;
					}
					break;
				}
				if (num2 == 3504813046u)
				{
					if (!ID3oS9jpXwA5Vk0Eps0(relativeCellName, xWa9XcjE8s0FT7pQ2dU(25574)))
					{
						num = 18;
						break;
					}
					NormalizeScore = new CheckBoxViewModel(InSight, cells, loc, (string)yOfTkVjjdLipNByloxA(), IsInitialized);
					num = 20;
					if (yO7jnLjky8DeHc2Ejkk())
					{
					}
					break;
				}
				num = 27;
				if (0 == 0)
				{
					break;
				}
				goto case 27;
			case 20:
				AddProperty(NormalizeScore);
				return;
			case 23:
				return;
			case 1:
				AddProperty(InputAnnulus);
				return;
			default:
				num = 6;
				if (!Fb9NdMjSWfIoDjPgDl2())
				{
					return;
				}
				break;
			case 14:
				return;
			case 17:
			case 29:
				AddProperty(Polarity);
				num = 26;
				if (yO7jnLjky8DeHc2Ejkk())
				{
				}
				break;
			case 30:
				return;
			case 9:
				AddProperty(OutputCircle);
				num = 4;
				break;
			case 5:
				return;
			case 21:
				if (num2 == 4292390121u)
				{
					if (!ID3oS9jpXwA5Vk0Eps0(relativeCellName, xWa9XcjE8s0FT7pQ2dU(11110)))
					{
						num = 8;
						break;
					}
					Polarity = new ListBoxViewModel(InSight, cells, loc, (string)SRm4fyj7TKTrMHXncZB());
					goto case 17;
				}
				num = 7;
				if (Fb9NdMjSWfIoDjPgDl2())
				{
					break;
				}
				goto case 11;
			case 11:
				if (num2 == 3118149576u && ID3oS9jpXwA5Vk0Eps0(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(25630)))
				{
					EdgeWidth = new EditIntViewModel(InSight, cells, loc, (string)wcHnc5j6wyX5ZaCIOTr());
					num = 19;
					if (yO7jnLjky8DeHc2Ejkk())
					{
					}
					break;
				}
				return;
			case 27:
				if (num2 == 4083060477u)
				{
					if (ID3oS9jpXwA5Vk0Eps0(relativeCellName, xWa9XcjE8s0FT7pQ2dU(25878)))
					{
						Annulus = new EditAnnulusViewModel(InSight, cells, loc, (string)bBjOmKj9gYvmboJiMHP(), I74ah9j4sMaxXPsYXJJ(InputImage));
						goto case 6;
					}
					return;
				}
				num = 21;
				if (yO7jnLjky8DeHc2Ejkk())
				{
					return;
				}
				break;
			case 2:
				return;
			case 24:
				num2 = Du30QUjqsYZLcy05DvK(relativeCellName);
				num = 15;
				break;
			case 18:
				return;
			case 26:
				return;
			case 10:
				return;
			case 7:
				return;
			case 12:
				AddProperty(PixelCircle);
				num = 31;
				break;
			case 3:
				AddProperty(AcceptThreshold);
				num = 0;
				break;
			case 25:
				if (num2 == 2407043987u)
				{
					if (ID3oS9jpXwA5Vk0Eps0(relativeCellName, xWa9XcjE8s0FT7pQ2dU(25850)))
					{
						InputAnnulus = new InputAnnulusViewModel(this, cells, loc, (string)ATj2jpjXeAST1m6oan1(), Resources.N9RYgdIblq(), Annulus, IsInitialized);
						num = 1;
					}
					else
					{
						num = 5;
					}
					break;
				}
				return;
			case 4:
				return;
			case 19:
				AddProperty(EdgeWidth);
				num = 13;
				break;
			case 28:
				AddProperty(FindBy);
				num = 23;
				if (false)
				{
					return;
				}
				break;
			case 13:
				return;
			case 0:
				return;
			case 6:
				AddProperty(Annulus);
				Fb9NdMjSWfIoDjPgDl2();
				num = (yO7jnLjky8DeHc2Ejkk() ? 29 : 22);
				break;
			case 16:
			case 22:
				return;
			case 8:
				return;
			case 31:
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
		_ = 1;
		int num = (yO7jnLjky8DeHc2Ejkk() ? 5 : 4);
		List<CvsEditableDisplayGraphic> list = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				list = new List<CvsEditableDisplayGraphic>();
				goto case 1;
			case 1:
			case 5:
				if (reqDataType != CellType.Point)
				{
					num = 2;
					continue;
				}
				goto case 3;
			case 3:
				list.Add(EditableGraphicHelper.ConstructCircle(I74ah9j4sMaxXPsYXJJ(PixelCircle), cells, I74ah9j4sMaxXPsYXJJ(OutputCircle).ToString(absoluteRow: true, absoluteColumn: true)));
				num = 6;
				continue;
			case 2:
				if (reqDataType != CellType.Circle)
				{
					break;
				}
				goto case 3;
			default:
				num = 3;
				continue;
			case 6:
				break;
			}
			break;
		}
		return (CvsEditableDisplayGraphic[])pSNs5ijAGeDIJp50FC1(list);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CShiftEditGraphics_003Ed__37))]
	public override Task ShiftEditGraphics(int delta)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		yO7jnLjky8DeHc2Ejkk();
		int num;
		if (Fb9NdMjSWfIoDjPgDl2())
		{
			num = 2;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_0084;
		IL_0058:
		_003CShiftEditGraphics_003Ed__37 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		num = 5;
		goto IL_0084;
		IL_0084:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				continue;
			case 1:
			case 3:
				goto IL_0058;
			case 5:
				stateMachine.delta = delta;
				goto case 4;
			default:
				num = 4;
				continue;
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		stateMachine._003C_003Et__builder = tSx1hqjRLXIbx2mAty1();
		goto IL_0058;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetViewableEditGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (!yO7jnLjky8DeHc2Ejkk())
		{
		}
		List<CvsEditableDisplayGraphic> list = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				list = new List<CvsEditableDisplayGraphic>();
				_ = 0;
				if (Fb9NdMjSWfIoDjPgDl2())
				{
					num = 0;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				}
				num = 4;
				continue;
			case 0:
			case 1:
				if (Annulus == null)
				{
					break;
				}
				goto default;
			default:
				list.Add((CvsEditableDisplayGraphic)PO9Wl1jWT56QLWlrK2M(Annulus));
				num = 5;
				continue;
			case 5:
				break;
			}
			break;
		}
		return (CvsEditableDisplayGraphic[])pSNs5ijAGeDIJp50FC1(list);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteFixturedGraphics_003Ed__39))]
	internal override Task WriteFixturedGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CWriteFixturedGraphics_003Ed__39 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				Fb9NdMjSWfIoDjPgDl2();
				if (!yO7jnLjky8DeHc2Ejkk())
				{
					num = 4;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				}
				num = 3;
				break;
			case 2:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			default:
				num = 0;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KhBWqKj8ShTFhsF1ApA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Fb9NdMjSWfIoDjPgDl2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool yO7jnLjky8DeHc2Ejkk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint Du30QUjqsYZLcy05DvK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xWa9XcjE8s0FT7pQ2dU(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ID3oS9jpXwA5Vk0Eps0(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ATj2jpjXeAST1m6oan1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.InputAnnulus;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bBjOmKj9gYvmboJiMHP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Annulus;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation I74ah9j4sMaxXPsYXJJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SRm4fyj7TKTrMHXncZB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Polarity;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object F8QGTgj3UoYSglDZjBk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.FindBy;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yOfTkVjjdLipNByloxA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.NormalizeScore;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wcHnc5j6wyX5ZaCIOTr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.EdgeWidth;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pyue1SjCSjUrNv7mCtV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.PixelCircle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pSNs5ijAGeDIJp50FC1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder tSx1hqjRLXIbx2mAty1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PO9Wl1jWT56QLWlrK2M(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EditableGraphicsViewModel)P_0).Graphic;
	}
}
