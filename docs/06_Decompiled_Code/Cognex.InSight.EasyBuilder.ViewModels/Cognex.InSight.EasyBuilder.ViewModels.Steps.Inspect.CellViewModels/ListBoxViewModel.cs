using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Designer.Utils.Operations;
using Cognex.InSight.Cell;
using Cognex.InSight.Common.PropertyCommitters;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class ListBoxViewModel : CommittableCellViewModel<int>
{
	private static string[] dTmxlDyYjC;

	private int gO2xThSQtZ;

	private string[] v6XxWqDHjN;

	private List<string> gBDxj5rw5Y;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.Enum;
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

	public int Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return gO2xThSQtZ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					big0fEUQlhIt2bFdXjF(this, Committer.Commit(gO2xThSQtZ));
					goto default;
				default:
					FirePropertyChangedExplicit(CdQUGaROfy7He9T0foW.KbIzwHEDLa(27684));
					num = 6;
					break;
				case 0:
					if (gO2xThSQtZ != -1)
					{
						_ = 1;
						num = ((!H2bEA8UY25G6dA7eYUl()) ? 5 : 4);
						break;
					}
					return;
				case 1:
					if (SetField(ref gO2xThSQtZ, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(5436)))
					{
						num = 0;
						break;
					}
					return;
				case 6:
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
			int num = 3;
			int value = default;
			string result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (value >= Items.Length)
					{
						goto IL_006c;
					}
					goto case 5;
				default:
					num = 5;
					continue;
				case 3:
					value = Value;
					_ = 1;
					num = (H2bEA8UY25G6dA7eYUl() ? 6 : 2);
					continue;
				case 5:
					result = Items[value];
					break;
				case 1:
				case 2:
					if (value >= 0)
					{
						num = 0;
						if (0 == 0)
						{
							continue;
						}
						break;
					}
					goto IL_006c;
				case 4:
				case 6:
				case 7:
					break;
					IL_006c:
					result = string.Format((string)DdDokFUxsyTfgNsqAv7(1906), value);
					num = 7;
					if (H2bEA8UY25G6dA7eYUl())
					{
					}
					continue;
				}
				break;
			}
			return result;
		}
	}

	public string[] Items
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return v6XxWqDHjN;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (H2bEA8UY25G6dA7eYUl() ? 3 : 4);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					if (v6XxWqDHjN != null)
					{
						num = 5;
						break;
					}
					return;
				case 2:
				case 3:
					if (SetField(ref v6XxWqDHjN, value, (string)DdDokFUxsyTfgNsqAv7(28322)))
					{
						goto case 1;
					}
					return;
				default:
					num = 1;
					break;
				case 1:
					big0fEUQlhIt2bFdXjF(this, Committer.Commit(gO2xThSQtZ));
					num = 6;
					if (H2bEA8UY25G6dA7eYUl())
					{
					}
					break;
				case 5:
					if (!v6XxWqDHjN.SequenceEqual(value))
					{
						goto case 2;
					}
					return;
				case 6:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ListBoxViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName, IPropertyCommitter<int> customCommitter = null, IOperationProgressManager operationProgressManager = null, List<string> skipItems = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		base._002Ector(insight, cells, loc, displayName, customCommitter, operationProgressManager);
		gBDxj5rw5Y = skipItems;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void RefreshValue(CvsCell cell, bool init)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 16;
		string[] value = default;
		CvsCellListBox cvsCellListBox = default;
		int num2 = default;
		CvsCellFloat cvsCellFloat = default;
		CvsCellLocation cellLocation = default;
		while (true)
		{
			switch (num)
			{
			case 15:
				if (gBDxj5rw5Y != null)
				{
					num = 7;
					break;
				}
				value = cvsCellListBox.Items;
				goto default;
			case 16:
				base.RefreshValue(cell, init);
				num = 14;
				if (H2bEA8UY25G6dA7eYUl())
				{
				}
				break;
			case 10:
				num2 = (int)lUHRZfUHaHsSLVeppLQ(cvsCellFloat);
				num = 18;
				break;
			case 4:
			case 8:
				if (cellLocation.IsValid)
				{
					num = 13;
					break;
				}
				goto default;
			default:
				if (init)
				{
					gO2xThSQtZ = num2;
					Committer.SetInitialValue(num2);
					num = 6;
					break;
				}
				if (cell != null)
				{
					num = 2;
					break;
				}
				return;
			case 11:
				JqOxgZ8Geo(num2);
				num = 19;
				break;
			case 0:
				if (cvsCellFloat == null)
				{
					num2 = CellViewModel.ConvertCellValue<int>(cell);
					num = 17;
				}
				else
				{
					num = 10;
				}
				break;
			case 2:
				Items = value;
				num = 11;
				break;
			case 3:
				value = dTmxlDyYjC;
				num = 1;
				break;
			case 1:
				cellLocation = CellLocation;
				TbL650UMhd5xwrSf9cW();
				num = ((!H2bEA8UY25G6dA7eYUl()) ? 8 : 5);
				break;
			case 7:
				value = cvsCellListBox.Items.Where([MethodImpl(MethodImplOptions.NoInlining)] (string P_0) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return !gBDxj5rw5Y.Contains(P_0);
				}).ToArray();
				num = 12;
				break;
			case 14:
				num2 = -1;
				num = 3;
				if (true)
				{
					break;
				}
				goto case 13;
			case 13:
				cvsCellListBox = cell as CvsCellListBox;
				if (cvsCellListBox == null)
				{
					cvsCellFloat = cell as CvsCellFloat;
					num = 0;
				}
				else
				{
					num2 = nmqeXeUUxU17jJNARrA(cvsCellListBox);
					num = 15;
				}
				break;
			case 6:
				v6XxWqDHjN = value;
				return;
			case 19:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void JqOxgZ8Geo(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		TbL650UMhd5xwrSf9cW();
		int num;
		if (!H2bEA8UY25G6dA7eYUl())
		{
			num = 2;
		}
		else
		{
			num = 3;
			if (H2bEA8UY25G6dA7eYUl())
			{
			}
		}
		while (true)
		{
			switch (num)
			{
			case 5:
				fjSiuhUmkkpkcdhgDSA(this, DdDokFUxsyTfgNsqAv7(5436));
				goto case 4;
			default:
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
			case 3:
				gO2xThSQtZ = P_0;
				num = 5;
				break;
			case 0:
			case 2:
				if (gO2xThSQtZ != P_0)
				{
					goto case 1;
				}
				return;
			case 4:
				FirePropertyChangedExplicit((string)DdDokFUxsyTfgNsqAv7(27684));
				num = 6;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string EtExMiEmUf(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		H2bEA8UY25G6dA7eYUl();
		int num = ((!TbL650UMhd5xwrSf9cW()) ? 3 : 4);
		string result = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				if (P_0 >= Items.Length)
				{
					break;
				}
				goto case 5;
			default:
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 3:
				if (P_0 < 0)
				{
					break;
				}
				num = 2;
				if (TbL650UMhd5xwrSf9cW())
				{
					continue;
				}
				goto case 5;
			case 5:
				result = Items[P_0];
				num = 6;
				continue;
			case 0:
			case 4:
				result = string.Empty;
				goto case 1;
			case 6:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override IPropertyCommitter<int> InternalCreateDefaultCommitter(Func<int, int, Task> commitToDeviceTask)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new DelegateValueTrackingPropertyCommitter<int>(commitToDeviceTask);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListBoxViewModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		vQYeQ3UNHnGvpXjWDJk();
		dTmxlDyYjC = new string[0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool xaFxRDyvhw(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return !gBDxj5rw5Y.Contains(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int nmqeXeUUxU17jJNARrA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellListBox)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double lUHRZfUHaHsSLVeppLQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellFloat)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TbL650UMhd5xwrSf9cW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool H2bEA8UY25G6dA7eYUl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DdDokFUxsyTfgNsqAv7(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fjSiuhUmkkpkcdhgDSA(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void big0fEUQlhIt2bFdXjF(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CommittableCellViewModel<int>)P_0).CommitTask = (Task)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vQYeQ3UNHnGvpXjWDJk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}
}
