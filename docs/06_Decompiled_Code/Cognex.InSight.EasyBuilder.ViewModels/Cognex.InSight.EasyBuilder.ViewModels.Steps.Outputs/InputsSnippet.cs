using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Outputs;

public class InputsSnippet : IoSnippet
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public int index;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass9_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Ar6xHJKlV1KrmdDJCjQk();
			JC0NSMKlferr7JWuOfXu(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetByIndex_003Eb__0(Input input)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IntViewModel)bKDUtBKldwDGQZG90rLR(input)).Value == index;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Ar6xHJKlV1KrmdDJCjQk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void JC0NSMKlferr7JWuOfXu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool X0TMQsKliYx1ZQ9t47AA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dZlGKqKlnjHOGBJURa9w()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bKDUtBKldwDGQZG90rLR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Input)P_0).Line;
		}
	}

	private bool SvKU8MANk8;

	[CompilerGenerated]
	private readonly ObservableCollection<Input> m9TUm1ASJK;

	public override string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.rm6YsvlS5R();
		}
	}

	public ObservableCollection<Input> Inputs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return m9TUm1ASJK;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InputsSnippet(AppStepViewModel appStepVm)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (AB8liCIOdisHTL2t4aE() ? 2 : 3);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				m9TUm1ASJK = new ObservableCollection<Input>();
				break;
			default:
				num = 4;
				continue;
			case 0:
			case 3:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				goto case 1;
			case 4:
				break;
			case 5:
				return;
			}
			base._002Ector(appStepVm);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Refresh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		IEnumerator<Input> enumerator = default;
		CvsCellCollection cvsCellCollection = default;
		while (true)
		{
			object obj2;
			switch (num)
			{
			case 1:
			case 4:
				enumerator = Inputs.GetEnumerator();
				num = 7;
				if (0 == 0)
				{
					break;
				}
				goto case 3;
			case 3:
				if (SvKU8MANk8)
				{
					goto case 1;
				}
				return;
			case 6:
				obj2 = null;
				goto IL_009d;
			case 0:
			{
				CvsInSight inSight = InSight;
				if (inSight != null)
				{
					object obj = yRrLEyII0trsPxJ56Qq(inSight);
					if (obj == null)
					{
						_ = 1;
						if (AB8liCIOdisHTL2t4aE())
						{
							num = 1;
							if (mgYiDmIeeyRBrUrEDhM())
							{
								break;
							}
							goto case 6;
						}
						num = 5;
						break;
					}
					obj2 = hiaSIuIDk7uNjvbtPko(obj);
					goto IL_009d;
				}
				num = 6;
				if (true)
				{
					break;
				}
				goto case 2;
			}
			case 2:
			case 5:
				obj2 = null;
				goto IL_009d;
			default:
				num = 3;
				if (mgYiDmIeeyRBrUrEDhM())
				{
					break;
				}
				goto case 7;
			case 7:
				{
					try
					{
						while (enumerator.MoveNext())
						{
							s8ghchIi2iZGVZS9Gve(enumerator.Current, cvsCellCollection);
						}
						return;
					}
					finally
					{
						if (enumerator != null)
						{
							iDDNUiInj0x2KvfO7aM(enumerator);
						}
					}
				}
				IL_009d:
				cvsCellCollection = (CvsCellCollection)obj2;
				if (cvsCellCollection != null)
				{
					goto case 3;
				}
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Task Parse(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (AB8liCIOdisHTL2t4aE() ? 5 : 8);
		int num2 = default;
		CvsCellRange cellRange = default;
		CvsCellLocation location = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				SvKU8MANk8 = true;
				num = 11;
				if (mgYiDmIeeyRBrUrEDhM())
				{
					break;
				}
				goto case 0;
			case 0:
			case 8:
				hyeXRWIVpe8cgXdZco2(Inputs);
				num = 2;
				break;
			case 3:
			case 4:
			case 5:
			{
				int num3 = num2;
				cellRange = CellRange;
				if (num3 >= cellRange.LastRow)
				{
					num = 1;
					break;
				}
				location.Row = num2;
				goto case 6;
			}
			case 10:
				num2++;
				num = 3;
				break;
			case 9:
				location = cellRange.Location;
				cellRange = CellRange;
				num = 7;
				break;
			case 2:
				cellRange = CellRange;
				num = 9;
				break;
			case 6:
			{
				ObservableCollection<Input> inputs = Inputs;
				AppStepViewModel parent = Parent;
				CvsCellLocation signalLocation = location;
				int lineIndex = num2 - (CellRange.Row + 2);
				cellRange = CellRange;
				inputs.Add(new Input(parent, cells, signalLocation, lineIndex, cellRange.LastColumn));
				num = 10;
				break;
			}
			default:
				num = 6;
				if (!AB8liCIOdisHTL2t4aE())
				{
					break;
				}
				goto case 7;
			case 7:
				num2 = cellRange.Row + 2;
				goto case 3;
			case 11:
				return Task.CompletedTask;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Input GetByIndex(int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass9_0();
		CS_0024_003C_003E8__locals2.index = index;
		return Inputs.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (Input input) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IntViewModel)_003C_003Ec__DisplayClass9_0.bKDUtBKldwDGQZG90rLR(input)).Value == CS_0024_003C_003E8__locals2.index;
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mgYiDmIeeyRBrUrEDhM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AB8liCIOdisHTL2t4aE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yRrLEyII0trsPxJ56Qq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Results;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hiaSIuIDk7uNjvbtPko(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsResultSet)P_0).Cells;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void s8ghchIi2iZGVZS9Gve(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Input)P_0).Refresh((CvsCellCollection)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iDDNUiInj0x2KvfO7aM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hyeXRWIVpe8cgXdZco2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Collection<Input>)P_0).Clear();
	}
}
