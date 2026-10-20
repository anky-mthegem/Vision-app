using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Designer.Utils.Operations;
using Cognex.InSight.Cell;
using Cognex.InSight.Common.PropertyCommitters;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class CheckBoxViewModel : CommittableCellViewModel<bool>
{
	private bool JTswCYnL6o;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.Bool;
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

	public bool Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return JTswCYnL6o;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!wXwq85FiBZxFV6QBbvN()) ? 4 : 2);
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					QWFR4lFgU37B95aVHEb(this, Committer.Commit(JTswCYnL6o));
					goto case 3;
				default:
					num = 3;
					break;
				case 3:
					X3GroTFlN0KyxmwTYNQ(this, w8lV0sFf25jlvxrRxEV(27684));
					num = 5;
					if (true)
					{
						break;
					}
					goto case 0;
				case 0:
				case 2:
					if (SetField(ref JTswCYnL6o, value, (string)w8lV0sFf25jlvxrRxEV(5436)))
					{
						goto case 1;
					}
					return;
				case 5:
					return;
				}
			}
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
			if (!Value)
			{
				return (string)MnWlnKFslgMQaImxaCZ();
			}
			return (string)isrGI2Fv0G9Wn4l8q59();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CheckBoxViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName, bool isInitialized, IPropertyCommitter<bool> customCommitter = null, IOperationProgressManager operationProgressManager = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		base._002Ector(insight, cells, loc, displayName, isInitialized, customCommitter, operationProgressManager);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void RefreshValue(CvsCell cell, bool init)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		CvsCellLocation cellLocation = default;
		CvsCellCheckBox cvsCellCheckBox = default;
		bool flag = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				base.RefreshValue(cell, init);
				num = 12;
				break;
			case 1:
				if (cellLocation.IsValid)
				{
					num = 4;
					break;
				}
				goto case 5;
			case 4:
				cvsCellCheckBox = cell as CvsCellCheckBox;
				num = 7;
				break;
			case 5:
			case 9:
				if (init)
				{
					num = 11;
					break;
				}
				if (!IsCommitting)
				{
					goto case 8;
				}
				return;
			case 8:
			case 10:
				ETJwjatJES(flag);
				num = 13;
				if (!N1hjyvFnk1Ldvi4jAcb())
				{
					break;
				}
				goto case 2;
			case 2:
			case 6:
				cellLocation = CellLocation;
				num = 1;
				break;
			case 3:
				flag = eWMlFKFVM5CJrDNvVYl(cvsCellCheckBox);
				num = 5;
				if (N1hjyvFnk1Ldvi4jAcb())
				{
				}
				break;
			case 11:
				JTswCYnL6o = flag;
				Committer.SetInitialValue(flag);
				return;
			case 12:
				flag = false;
				_ = 0;
				num = (wXwq85FiBZxFV6QBbvN() ? 6 : 8);
				break;
			case 7:
				if (cvsCellCheckBox == null)
				{
					flag = CellViewModel.ConvertCellValue<bool>(cell);
					num = 9;
					break;
				}
				goto case 3;
			default:
				num = 3;
				break;
			case 13:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ETJwjatJES(bool P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (wXwq85FiBZxFV6QBbvN())
		{
			num = 3;
			if (!wXwq85FiBZxFV6QBbvN())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0079;
		IL_0057:
		FvZGmDFdjXdP2oFHJJV(this, w8lV0sFf25jlvxrRxEV(5436));
		goto IL_00a4;
		IL_0079:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 0:
			case 3:
				if (JTswCYnL6o != P_0)
				{
					num = 1;
					continue;
				}
				return;
			case 2:
			case 4:
				goto IL_0057;
			default:
				num = 5;
				continue;
			case 5:
				goto IL_00a4;
			case 6:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		JTswCYnL6o = P_0;
		goto IL_0057;
		IL_00a4:
		X3GroTFlN0KyxmwTYNQ(this, w8lV0sFf25jlvxrRxEV(27684));
		num = 6;
		if (!wXwq85FiBZxFV6QBbvN())
		{
			return;
		}
		goto IL_0079;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override IPropertyCommitter<bool> InternalCreateDefaultCommitter(Func<bool, bool, Task> commitToDeviceTask)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new DelegateValueTrackingPropertyCommitter<bool>(commitToDeviceTask);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eWMlFKFVM5CJrDNvVYl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCheckBox)P_0).Checked;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wXwq85FiBZxFV6QBbvN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool N1hjyvFnk1Ldvi4jAcb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object w8lV0sFf25jlvxrRxEV(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FvZGmDFdjXdP2oFHJJV(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void X3GroTFlN0KyxmwTYNQ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QWFR4lFgU37B95aVHEb(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CommittableCellViewModel<bool>)P_0).CommitTask = (Task)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MnWlnKFslgMQaImxaCZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.QiZnV1GLJC();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object isrGI2Fv0G9Wn4l8q59()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.bfFh7CclKq();
	}
}
