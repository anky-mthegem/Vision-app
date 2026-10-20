using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.MathLogic;

public class MiniSheetRow : BaseViewModel
{
	public const int NumberOfColumns = 8;

	private CellViewModel[] CGBgVlYaAk;

	private string[] LuigL3KQ2k;

	[CompilerGenerated]
	private readonly CvsInSight NEAgJBLJWi;

	[CompilerGenerated]
	private string qmQg9pqb7N;

	public CvsInSight InSight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return NEAgJBLJWi;
		}
	}

	public string Header
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qmQg9pqb7N;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			qmQg9pqb7N = value;
		}
	}

	public CellViewModel A
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CGBgVlYaAk[0];
		}
	}

	public CellViewModel B
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CGBgVlYaAk[1];
		}
	}

	public CellViewModel C
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CGBgVlYaAk[2];
		}
	}

	public CellViewModel D
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CGBgVlYaAk[3];
		}
	}

	public CellViewModel E
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CGBgVlYaAk[4];
		}
	}

	public CellViewModel F
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CGBgVlYaAk[5];
		}
	}

	public CellViewModel G
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CGBgVlYaAk[6];
		}
	}

	public CellViewModel H
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CGBgVlYaAk[7];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MiniSheetRow(CvsInSight insight)
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
			case 6:
				CGBgVlYaAk = new CellViewModel[8];
				qwDwWrXHdeRw6dWN5X3();
				if (bJ0iycXUE27VUiwgOw1())
				{
					num = 1;
					continue;
				}
				num = 7;
				if (qwDwWrXHdeRw6dWN5X3())
				{
				}
				continue;
			case 3:
				DcQULSXQqP5QfKTSf3j(this);
				goto case 0;
			default:
				num = 0;
				if (!qwDwWrXHdeRw6dWN5X3())
				{
					continue;
				}
				goto case 0;
			case 0:
				NEAgJBLJWi = insight;
				break;
			case 4:
				ewjSsJXx4mHADgl1EbD();
				num = 6;
				continue;
			case 1:
			case 2:
				LuigL3KQ2k = new string[8]
				{
					(string)LHUw8FXmL7tT6aYXrp4(24116),
					(string)LHUw8FXmL7tT6aYXrp4(24122),
					(string)LHUw8FXmL7tT6aYXrp4(24128),
					CdQUGaROfy7He9T0foW.KbIzwHEDLa(24134),
					(string)LHUw8FXmL7tT6aYXrp4(24140),
					(string)LHUw8FXmL7tT6aYXrp4(24146),
					(string)LHUw8FXmL7tT6aYXrp4(24152),
					(string)LHUw8FXmL7tT6aYXrp4(24158)
				};
				num = 3;
				if (qwDwWrXHdeRw6dWN5X3())
				{
				}
				continue;
			case 5:
			case 7:
				break;
			case 8:
				return;
			}
			CGBgVlYaAk = new CellViewModel[8];
			num = 8;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CellViewModel GetColumn(int c)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CGBgVlYaAk[c];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetColumn(int c, CellViewModel vm)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CGBgVlYaAk[c] = vm;
		FirePropertyChanged(LuigL3KQ2k[c]);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ewjSsJXx4mHADgl1EbD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LHUw8FXmL7tT6aYXrp4(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DcQULSXQqP5QfKTSf3j(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseViewModel)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bJ0iycXUE27VUiwgOw1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qwDwWrXHdeRw6dWN5X3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
