using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Runtime.EdgeIntelligence;
using Cognex.InSight.Runtime.ViewModels.EdgeIntelligence;

namespace Cognex.InSight.EasyBuilder.ViewModels.EdgeIntelligence;

public class EasyBuilderEdgeIntelligenceSettingsViewModel : EdgeIntelligenceSettingsViewModel
{
	private readonly EasyBuilderApplicationViewModel Cka1Fj7esW;

	public override bool IsEasyBuilder
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EasyBuilderEdgeIntelligenceSettingsViewModel(IEdgeIntelligenceSettingsService service, EasyBuilderApplicationViewModel appViewModel)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!Me7PS3KwP8n88fi3dO24())
		{
			num = 3;
			if (!dK88vvKwrsX1sbcvW64E())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
			if (!dK88vvKwrsX1sbcvW64E())
			{
				goto IL_0087;
			}
		}
		goto IL_0054;
		IL_0054:
		switch (num)
		{
		case 1:
			zTS0djKwZcdMm7iHRFuk(this, service);
			break;
		case 0:
		case 3:
			goto IL_0087;
		case 5:
			return;
		}
		goto IL_002a;
		IL_0087:
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		num = 1;
		goto IL_0054;
		IL_002a:
		Cka1Fj7esW = appViewModel;
		num = 5;
		goto IL_0054;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zTS0djKwZcdMm7iHRFuk(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EdgeIntelligenceSettingsViewModel)P_0)._002Ector((IEdgeIntelligenceSettingsService)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dK88vvKwrsX1sbcvW64E()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Me7PS3KwP8n88fi3dO24()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
