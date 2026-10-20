using System.Composition;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.FindCircle;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.CircleFixture;

[Export(typeof(CircleFixtureTool))]
public class CircleFixtureTool : FindCircleTool
{
	[CompilerGenerated]
	private WorldFixtureViewModel EYdCYimUHN;

	[CompilerGenerated]
	private FixtureViewModel s3XC0KIxvo;

	[CompilerGenerated]
	private StringViewModel rp2CV773Hb;

	public override string ImagePath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Tools_CircleFixtureIcon;
		}
	}

	public WorldFixtureViewModel WorldFixture
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EYdCYimUHN;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EYdCYimUHN = value;
		}
	}

	public FixtureViewModel OutputFixture
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return s3XC0KIxvo;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			s3XC0KIxvo = value;
		}
	}

	public StringViewModel FixtureString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rp2CV773Hb;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rp2CV773Hb = value;
		}
	}

	public override string ResultString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FixtureString?.Value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CircleFixtureTool(InspectStepViewModel inspect, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		base._002Ector(inspect, isInitialized);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalParseCell(string relativeCellName, CvsCellCollection cells, CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		if (!lVHfMfWE3d5vPf7ef5M())
		{
			goto IL_001e;
		}
		goto IL_014b;
		IL_001e:
		if (!(relativeCellName == (string)FP0RdTWXUB036fFH7MR(24192)))
		{
			num = 4;
			goto IL_014b;
		}
		OutputFixture = new FixtureViewModel(InSight, cells, loc, (string)HdWlUgW4j7G9x7u99Ik());
		AddProperty(OutputFixture);
		goto IL_0180;
		IL_0180:
		_ = 1;
		if (usx3TiWpcidYLo2xBEw())
		{
			num = 8;
		}
		else
		{
			num = 2;
			if (false)
			{
				return;
			}
		}
		goto IL_014b;
		IL_014b:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 0:
				return;
			case 2:
			case 5:
				return;
			case 10:
				goto IL_008f;
			case 6:
			case 8:
				AddProperty(WorldFixture);
				num = 0;
				continue;
			case 7:
				base.InternalParseCell(relativeCellName, cells, loc);
				num = 3;
				if (!usx3TiWpcidYLo2xBEw())
				{
					continue;
				}
				goto case 9;
			case 9:
				AddProperty(FixtureString);
				num = 11;
				if (0 == 0)
				{
					continue;
				}
				goto case 4;
			case 4:
				if (hTWLctW99cnCvd839Gw(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(24164)))
				{
					WorldFixture = new WorldFixtureViewModel(InSight, cells, loc, (string)hgAN3eW7qlNpMywTroQ());
					goto case 6;
				}
				num = 10;
				continue;
			case 1:
				return;
			default:
				goto IL_0180;
			case 11:
				return;
			}
			break;
			IL_008f:
			if (hTWLctW99cnCvd839Gw(relativeCellName, FP0RdTWXUB036fFH7MR(24222)))
			{
				FixtureString = new StringViewModel(InSight, cells, loc, Resources.FixtureString);
				num = 9;
				if (usx3TiWpcidYLo2xBEw())
				{
					return;
				}
			}
			else
			{
				num = 1;
			}
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lVHfMfWE3d5vPf7ef5M()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool usx3TiWpcidYLo2xBEw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FP0RdTWXUB036fFH7MR(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hTWLctW99cnCvd839Gw(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HdWlUgW4j7G9x7u99Ik()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.OutputFixture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hgAN3eW7qlNpMywTroQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.WorldFixture;
	}
}
