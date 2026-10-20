using System;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ReadId;

public class ReadIdSymbologyViewModel
{
	[CompilerGenerated]
	private readonly SymbologyType bpEI3pHkmM;

	[CompilerGenerated]
	private readonly string KPsIIrEg9y;

	[CompilerGenerated]
	private readonly string A0gIfL7Txt;

	[CompilerGenerated]
	private CheckBoxViewModel xpiIEr4d3B;

	private EditIntViewModel vPuIbTNiQI;

	public SymbologyType Symbology
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bpEI3pHkmM;
		}
	}

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KPsIIrEg9y;
		}
	}

	public string ImagePath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return A0gIfL7Txt;
		}
	}

	public CheckBoxViewModel Enabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xpiIEr4d3B;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xpiIEr4d3B = value;
		}
	}

	public bool CanEditMaxResults
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MaxResults != null;
		}
	}

	public EditIntViewModel MaxResults
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return vPuIbTNiQI;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (!Symbology.Is2D())
			{
				throw new ArgumentException((string)D7dfNLGSwjUjBeZEsd0(9524));
			}
			vPuIbTNiQI = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ReadIdSymbologyViewModel(SymbologyType symbology)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		(string, string) resources = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				A0gIfL7Txt = resources.Item2;
				num = 8;
				continue;
			case 1:
			case 6:
				imXopKGoEXe0t4ldEdq(this);
				goto case 0;
			case 0:
			case 2:
				bpEI3pHkmM = symbology;
				num = 7;
				continue;
			case 3:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				_ = 0;
				num = (OqRtWEGbnHOUqdIxLBK() ? 6 : 0);
				continue;
			case 7:
				resources = symbology.GetResources();
				break;
			default:
				num = 4;
				continue;
			case 4:
				break;
			case 8:
				return;
			}
			KPsIIrEg9y = resources.Item1;
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void imXopKGoEXe0t4ldEdq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool OqRtWEGbnHOUqdIxLBK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool yn1bNhGGup30CtYPch8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object D7dfNLGSwjUjBeZEsd0(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}
}
