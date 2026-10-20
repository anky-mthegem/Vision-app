using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Designer.Utils.Operations;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.InSight.Undo;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class SnippetNameViewModel : CellViewModel
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSetValue_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SnippetNameViewModel _003C_003E4__this;

		public string newName;

		private ITopLevelProgressableOperation _003Coperation_003E5__2;

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
			if (bjykCQ5LygoMtJacQLnG())
			{
				num = 2;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_0241;
			IL_0039:
			SnippetNameViewModel snippetNameViewModel = _003C_003E4__this;
			num = 4;
			goto IL_0241;
			IL_0241:
			int num2 = default;
			string tNRxtoGCTU = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					break;
				case 1:
					goto IL_0039;
				case 4:
					try
					{
						if (num2 == 0)
						{
							goto IL_0087;
						}
						if (cmPGu05LFAD88JJ0RHQo(snippetNameViewModel.tNRxtoGCTU, newName))
						{
							_003Coperation_003E5__2 = (ITopLevelProgressableOperation)ScJpOy5LYAQWgxOLV6ba(HBu1D95LMXOAEJojRyB1(snippetNameViewModel.JBhxnFK1PK), Resources.uOn9vWiboG(), Array.Empty<StepDescriptor>());
							goto IL_0087;
						}
						goto end_IL_004a;
						IL_0087:
						try
						{
							int num3;
							if (num2 != 0)
							{
								tNRxtoGCTU = snippetNameViewModel.tNRxtoGCTU;
								_ = 1;
								num3 = ((!kuAXiX5L09oXjxroyipd()) ? 1 : 2);
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
								case 4:
									_003C_003Eu__1 = default;
									goto case 2;
								case 9:
									_003C_003Eu__1 = awaiter;
									num3 = 8;
									if (0 == 0)
									{
										continue;
									}
									goto case 2;
								case 2:
								case 6:
									num2 = (_003C_003E1__state = -1);
									num3 = 7;
									continue;
								case 0:
								case 1:
									awaiter = kLxpJZ5LxGujB1GvKRlB(MLauXQ5LHJVtoFHKp9xD(qefKa05LU8HYfqlCcMwv(snippetNameViewModel.InSight), new UndoToolNameChange(snippetNameViewModel.JBhxnFK1PK, tNRxtoGCTU, newName)));
									if (!awaiter.IsCompleted)
									{
										num3 = 3;
										continue;
									}
									goto case 7;
								case 8:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 5;
									continue;
								case 7:
									awaiter.GetResult();
									num3 = 10;
									continue;
								case 3:
									num2 = (_003C_003E1__state = 0);
									num3 = 9;
									continue;
								case 5:
									return;
								case 10:
									snippetNameViewModel.SetField(ref snippetNameViewModel.tNRxtoGCTU, newName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(51238));
									break;
								}
								break;
							}
						}
						finally
						{
							if (num2 < 0 && _003Coperation_003E5__2 != null)
							{
								dcdASh5LmUGqADxEveph(_003Coperation_003E5__2);
							}
						}
						_003Coperation_003E5__2 = null;
						end_IL_004a:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			num2 = _003C_003E1__state;
			num = 1;
			if (false)
			{
				goto IL_0039;
			}
			goto IL_0241;
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
		internal static bool cmPGu05LFAD88JJ0RHQo(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 != (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HBu1D95LMXOAEJojRyB1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).OperationProgressManager;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ScJpOy5LYAQWgxOLV6ba(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).StartBlockingOperation((string)P_1, (StepDescriptor[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qefKa05LU8HYfqlCcMwv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MLauXQ5LHJVtoFHKp9xD(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter kLxpJZ5LxGujB1GvKRlB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void dcdASh5LmUGqADxEveph(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bjykCQ5LygoMtJacQLnG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kuAXiX5L09oXjxroyipd()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private AppStepViewModel JBhxnFK1PK;

	private string tNRxtoGCTU;

	private int TZexYBHSC1;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.String;
		}
	}

	public override bool IsReadOnly
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

	public string Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tNRxtoGCTU;
		}
	}

	public override string DisplayValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Value;
		}
	}

	public int MaxChars
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TZexYBHSC1;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref TZexYBHSC1, value, (string)Aw2tMPHBEYJZWMmfZM9(28082));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SnippetNameViewModel(AppStepViewModel appStepVm, CvsCellCollection cells, CvsCellLocation loc, string displayName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		NvIDW1HsuMt4g53OIiJ();
		int num = ((!GPAxAbHg0A2p83U3pJ3()) ? 5 : 4);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				goto case 1;
			case 2:
				Refresh(cells, init: true);
				num = 6;
				continue;
			case 1:
			case 5:
				base._002Ector((CvsInSight)Fdrb8iHvAGrpT2fMFf3(appStepVm), loc, displayName);
				num = 3;
				continue;
			case 3:
				JBhxnFK1PK = appStepVm;
				goto case 2;
			case 6:
				return;
			}
			num = 2;
			if (1 == 0)
			{
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void RefreshValue(CvsCell cell, bool init)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_00d9;
		IL_001a:
		base.RefreshValue(cell, init);
		num = 10;
		if (NvIDW1HsuMt4g53OIiJ())
		{
		}
		goto IL_00d9;
		IL_00d9:
		int num2 = default;
		string text = default;
		CvsCellEditString cvsCellEditString = default;
		CvsCellString cvsCellString = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				break;
			case 2:
				MaxChars = num2;
				num = 14;
				continue;
			case 10:
				text = string.Empty;
				num = 3;
				continue;
			case 0:
			case 13:
				if (init)
				{
					num = 15;
					if (!NvIDW1HsuMt4g53OIiJ())
					{
						continue;
					}
					goto case 3;
				}
				if (cell != null)
				{
					num = 2;
					continue;
				}
				return;
			case 3:
				num2 = 0;
				num = 11;
				if (0 == 0)
				{
					continue;
				}
				goto case 11;
			case 11:
				if (CellLocation.IsValid)
				{
					num = 6;
					if (NvIDW1HsuMt4g53OIiJ())
					{
					}
					continue;
				}
				goto case 0;
			case 5:
			case 12:
				TZexYBHSC1 = num2;
				return;
			default:
				num = 4;
				continue;
			case 6:
				cvsCellEditString = cell as CvsCellEditString;
				if (cvsCellEditString == null)
				{
					cvsCellString = cell as CvsCellString;
					goto case 4;
				}
				num = 8;
				continue;
			case 15:
				tNRxtoGCTU = text;
				goto case 5;
			case 14:
				ANdxBQgdNJ(text);
				num = 17;
				continue;
			case 4:
				if (cvsCellString != null)
				{
					NvIDW1HsuMt4g53OIiJ();
					if (!GPAxAbHg0A2p83U3pJ3())
					{
						num = 5;
						continue;
					}
					num = 1;
					if (NvIDW1HsuMt4g53OIiJ())
					{
					}
					continue;
				}
				goto case 0;
			case 16:
				num2 = XxBf6UHPOBeFI2XJqNW(cvsCellEditString);
				num = 13;
				continue;
			case 8:
				text = (string)EisOvdHrhSnCy2oEFhc(cvsCellEditString);
				num = 16;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 9:
				text = cvsCellString.Text;
				num = 0;
				continue;
			case 17:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ANdxBQgdNJ(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		GPAxAbHg0A2p83U3pJ3();
		int num;
		if (!NvIDW1HsuMt4g53OIiJ())
		{
			num = 1;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_004c;
		IL_0077:
		nfuVuJHGaQFGVSZTf1R(this, CdQUGaROfy7He9T0foW.KbIzwHEDLa(27684));
		num = 6;
		goto IL_004c;
		IL_004c:
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
				break;
			default:
				num = 4;
				continue;
			case 4:
				goto IL_0077;
			case 0:
			case 1:
				if (Xh8RIPHZGrCridJYGlI(tNRxtoGCTU, P_0))
				{
					num = 5;
					continue;
				}
				return;
			case 5:
				tNRxtoGCTU = P_0;
				break;
			case 6:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		gvwPkAHbZ8QKxDHfgjg(this, Aw2tMPHBEYJZWMmfZM9(5436));
		goto IL_0077;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetValue_003Ed__11))]
	public Task SetValue(string newName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CSetValue_003Ed__11 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				if (GPAxAbHg0A2p83U3pJ3())
				{
					num = 5;
					break;
				}
				num = 6;
				if (!NvIDW1HsuMt4g53OIiJ())
				{
					break;
				}
				goto case 4;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (true)
				{
					break;
				}
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 0;
				if (GPAxAbHg0A2p83U3pJ3())
				{
					break;
				}
				goto case 2;
			case 2:
			case 5:
				stateMachine.newName = newName;
				goto default;
			case 4:
				stateMachine._003C_003Et__builder = dy6hfcHoEm2UBiLYxIl();
				num = 1;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Fdrb8iHvAGrpT2fMFf3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GPAxAbHg0A2p83U3pJ3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NvIDW1HsuMt4g53OIiJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EisOvdHrhSnCy2oEFhc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int XxBf6UHPOBeFI2XJqNW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellEditString)P_0).MaxChars;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Xh8RIPHZGrCridJYGlI(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 != (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Aw2tMPHBEYJZWMmfZM9(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gvwPkAHbZ8QKxDHfgjg(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nfuVuJHGaQFGVSZTf1R(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder dy6hfcHoEm2UBiLYxIl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
