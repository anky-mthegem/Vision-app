using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.Runtime.ViewModels.Cells;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class StringViewModel : CellViewModel
{
	private string lFUxLwH3YA;

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
			return true;
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
			return lFUxLwH3YA;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref lFUxLwH3YA, value, (string)VY5NdkHqRm180DjfjUO(5436)))
			{
				FirePropertyChangedExplicit((string)VY5NdkHqRm180DjfjUO(27684));
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
			return Value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StringViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (EpsHCkHSfN5Ng1E0KB4())
		{
			num = 3;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0043;
		IL_007f:
		Refresh(cells, init: true);
		num = 5;
		goto IL_0043;
		IL_0043:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			default:
				num = 2;
				continue;
			case 0:
			case 3:
				VoOnvZH8BU6bwP7TrW1();
				break;
			case 2:
				goto IL_007f;
			case 5:
				return;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		base._002Ector(insight, loc, displayName);
		goto IL_007f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void RefreshValue(CvsCell cell, bool init)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RefreshStringValue([MethodImpl(MethodImplOptions.NoInlining)] (string P_0) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Value = P_0;
		}, cell);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void cUax0F0h39(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Value = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VoOnvZH8BU6bwP7TrW1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EpsHCkHSfN5Ng1E0KB4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JmYXu4HkW2YGTABtcma()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VY5NdkHqRm180DjfjUO(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}
}
