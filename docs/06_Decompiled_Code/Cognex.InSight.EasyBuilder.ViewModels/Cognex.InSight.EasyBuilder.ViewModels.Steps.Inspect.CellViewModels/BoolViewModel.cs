using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class BoolViewModel : CellViewModel
{
	private bool N1mHVFtdvc;

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
			return true;
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
			return N1mHVFtdvc;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref N1mHVFtdvc, value, (string)Djs89S08LYHUoV4RHCF(5436)))
			{
				RfN4Du0qnPSKSjFXKj5(this, Djs89S08LYHUoV4RHCF(27684));
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
			if (!Error)
			{
				if (!Value)
				{
					return (string)Dp6ctA0EJjreZdb97f8();
				}
				return (string)KpA0IF0pTMEX8mQ6ug8();
			}
			return (string)VeAWAa0XfJwLaduKjpj();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BoolViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VKHp4b0bCIOF4iJCuVY();
		int num;
		if (!qxSXWV0GEQ8PsJaFm58())
		{
			num = 1;
		}
		else
		{
			num = 4;
			if (false)
			{
				goto IL_0074;
			}
		}
		goto IL_0045;
		IL_0074:
		clFcpU0ouBZVcXfmLET();
		num = 3;
		if (VKHp4b0bCIOF4iJCuVY())
		{
			goto IL_0045;
		}
		goto IL_0089;
		IL_0089:
		Refresh(cells);
		num = 5;
		goto IL_0045;
		IL_0045:
		switch (num)
		{
		case 3:
			base._002Ector(insight, loc, displayName);
			goto IL_0089;
		case 0:
		case 1:
			break;
		default:
			goto IL_0089;
		case 5:
			return;
		}
		goto IL_0074;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void RefreshValue(CvsCell cell, bool init)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		if (!qxSXWV0GEQ8PsJaFm58())
		{
		}
		CvsCellStatusLight cvsCellStatusLight = default;
		CvsCellFloat cvsCellFloat = default;
		CvsCellLocation cellLocation = default;
		while (true)
		{
			switch (num)
			{
			case 5:
			case 6:
				if (cvsCellStatusLight != null)
				{
					num = 7;
					break;
				}
				Value = false;
				num = 11;
				break;
			case 3:
				return;
			case 4:
				if (cvsCellFloat == null)
				{
					cvsCellStatusLight = cell as CvsCellStatusLight;
					goto case 5;
				}
				num = 8;
				if (true)
				{
					break;
				}
				goto case 10;
			case 10:
				cellLocation = CellLocation;
				num = 1;
				if (VKHp4b0bCIOF4iJCuVY())
				{
					break;
				}
				goto case 8;
			case 8:
				Value = Fkk87T0STf14e7bhC9w(cvsCellFloat) != 0.0;
				return;
			default:
				num = 3;
				break;
			case 9:
				return;
			case 1:
				if (!cellLocation.IsValid)
				{
					return;
				}
				_ = 0;
				if (!VKHp4b0bCIOF4iJCuVY())
				{
					num = 5;
					if (qxSXWV0GEQ8PsJaFm58())
					{
					}
				}
				else
				{
					num = 0;
				}
				break;
			case 0:
			case 2:
				cvsCellFloat = cell as CvsCellFloat;
				num = 4;
				break;
			case 7:
				Value = AdobTl0kwQPSn59EtwH(cvsCellStatusLight) != 0;
				num = 9;
				break;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void clFcpU0ouBZVcXfmLET()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VKHp4b0bCIOF4iJCuVY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qxSXWV0GEQ8PsJaFm58()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double Fkk87T0STf14e7bhC9w(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellFloat)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int AdobTl0kwQPSn59EtwH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellStatusLight)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Djs89S08LYHUoV4RHCF(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RfN4Du0qnPSKSjFXKj5(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Dp6ctA0EJjreZdb97f8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.QiZnV1GLJC();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KpA0IF0pTMEX8mQ6ug8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.bfFh7CclKq();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VeAWAa0XfJwLaduKjpj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Error;
	}
}
