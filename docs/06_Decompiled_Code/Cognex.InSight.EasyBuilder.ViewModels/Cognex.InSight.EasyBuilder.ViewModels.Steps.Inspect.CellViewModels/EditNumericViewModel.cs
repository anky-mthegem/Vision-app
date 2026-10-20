using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Designer.Utils.Operations;
using Cognex.InSight.Cell;
using Cognex.InSight.Common.PropertyCommitters;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public abstract class EditNumericViewModel<TDataType, TCellType, TEditCellType> : CommittableCellViewModel<TDataType> where TDataType : struct, IEquatable<TDataType> where TCellType : ICvsCellNumber<TDataType>, CvsCell where TEditCellType : CvsCell, ICvsCellEditNumber<TDataType>
{
	private TDataType eXXy5XJnv5;

	private TDataType RKGyplQplU;

	private TDataType d9OyUpLL3g;

	private TDataType? mtBy7fEnKc;

	private TDataType? Cr2yNUccYQ;

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

	public TDataType Min
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return eXXy5XJnv5;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref eXXy5XJnv5, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6148));
		}
	}

	public TDataType Max
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return RKGyplQplU;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref RKGyplQplU, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6138));
		}
	}

	public TDataType Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return d9OyUpLL3g;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref d9OyUpLL3g, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(5436)))
			{
				CommitTask = Committer.Commit(d9OyUpLL3g);
				FirePropertyChanged(CdQUGaROfy7He9T0foW.KbIzwHEDLa(5436));
				FirePropertyChangedExplicit(CdQUGaROfy7He9T0foW.KbIzwHEDLa(27684));
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
			return FormatValue(d9OyUpLL3g);
		}
	}

	public abstract string NumericFormat { get; }

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EditNumericViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName, IPropertyCommitter<TDataType> customCommitter = null, IOperationProgressManager operationProgressManager = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		base._002Ector(insight, cells, loc, displayName, customCommitter, operationProgressManager);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void RefreshValue(CvsCell cell, bool init)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		CvsCellLocation cellLocation = default;
		TDataType val = default;
		TDataType min = default;
		TDataType val3 = default;
		TEditCellType val2 = default;
		while (true)
		{
			switch (num)
			{
			case 10:
				cellLocation = CellLocation;
				num = 14;
				break;
			case 7:
				d9OyUpLL3g = val;
				Committer.SetInitialValue(val);
				eXXy5XJnv5 = min;
				RKGyplQplU = val3;
				num = 11;
				break;
			case 17:
				if (mtBy7fEnKc.HasValue)
				{
					num = 22;
					break;
				}
				Min = min;
				num = 5;
				break;
			case 2:
				base.RefreshValue(cell, init);
				_ = 0;
				num = ((1 == 0) ? 9 : 13);
				break;
			case 12:
				val = val2.Value;
				goto case 4;
			case 3:
				return;
			case 16:
				if (val2 == null)
				{
					if (cell is TCellType val4)
					{
						val = val4.Value;
						num = 6;
					}
					else
					{
						val = CellViewModel.ConvertCellValue<TDataType>(cell);
						num = 4;
					}
				}
				else
				{
					num = 8;
				}
				break;
			case 22:
				Min = mtBy7fEnKc.Value;
				num = 19;
				break;
			case 4:
			case 6:
				if (init)
				{
					goto case 7;
				}
				if (cell != null)
				{
					num = 23;
					break;
				}
				return;
			default:
				num = 7;
				break;
			case 8:
				min = val2.MinValue;
				num = 18;
				break;
			case 15:
				val2 = cell as TEditCellType;
				num = 16;
				break;
			case 5:
			case 19:
				if (!Cr2yNUccYQ.HasValue)
				{
					Max = val3;
					num = 24;
					break;
				}
				goto case 9;
			case 9:
			case 20:
				Max = Cr2yNUccYQ.Value;
				num = 3;
				break;
			case 11:
				return;
			case 18:
				val3 = val2.MaxValue;
				num = 12;
				break;
			case 21:
				gpYyaeJg0p(val);
				num = 17;
				break;
			case 1:
			case 13:
				val = default;
				min = default;
				num = 0;
				break;
			case 0:
				val3 = default;
				num = 10;
				break;
			case 23:
				if (!IsCommitting)
				{
					num = 21;
					break;
				}
				goto case 17;
			case 14:
				if (cellLocation.IsValid)
				{
					num = 15;
					break;
				}
				goto case 4;
			case 24:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gpYyaeJg0p(TDataType X1BIKsoWDQZ6wimUUo)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!d9OyUpLL3g.Equals(X1BIKsoWDQZ6wimUUo))
		{
			d9OyUpLL3g = X1BIKsoWDQZ6wimUUo;
			FirePropertyChanged(CdQUGaROfy7He9T0foW.KbIzwHEDLa(5436));
			FirePropertyChangedExplicit(CdQUGaROfy7He9T0foW.KbIzwHEDLa(27684));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected string FormatValue(TDataType value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format(CdQUGaROfy7He9T0foW.KbIzwHEDLa(28066) + NumericFormat + CdQUGaROfy7He9T0foW.KbIzwHEDLa(28076), value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMinExternally(TDataType min)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		mtBy7fEnKc = min;
		Min = min;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMaxExternally(TDataType max)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Cr2yNUccYQ = max;
		Max = max;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveExternallySetMin()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		mtBy7fEnKc = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveExternallySetMax()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Cr2yNUccYQ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override IPropertyCommitter<TDataType> InternalCreateDefaultCommitter(Func<TDataType, TDataType, Task> commitToDeviceTask)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new EventuallyConsistentPropertyCommitter<TDataType>(new DeduplicatingPropertyCommitter<TDataType>(commitToDeviceTask));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gKCF6rMiLqhcb10pNvQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cmfUqcMnmnCKbl3UVkI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
