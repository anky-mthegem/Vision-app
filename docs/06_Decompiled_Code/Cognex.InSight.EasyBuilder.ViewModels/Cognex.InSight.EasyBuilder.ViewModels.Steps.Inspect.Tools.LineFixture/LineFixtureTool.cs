using System.Collections.Generic;
using System.Composition;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.FindEdge;
using Cognex.InSight.Runtime.ViewModels.Cells;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.LineFixture;

[Export(typeof(LineFixtureTool))]
public class LineFixtureTool : FindEdgeTool
{
	[CompilerGenerated]
	private WorldFixtureViewModel tKXMJluOo5;

	[CompilerGenerated]
	private FixtureViewModel AOuM9R4M0a;

	[CompilerGenerated]
	private StringViewModel drPMruPYkV;

	public override string ImagePath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Tools_EdgeFixtureIcon;
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
			return tKXMJluOo5;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			tKXMJluOo5 = value;
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
			return AOuM9R4M0a;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			AOuM9R4M0a = value;
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
			return drPMruPYkV;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			drPMruPYkV = value;
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
	public LineFixtureTool(InspectStepViewModel inspect, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RNflqI9tLocok9Dj6F4();
		base._002Ector(inspect, isInitialized);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalParseCell(string relativeCellName, CvsCellCollection cells, CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_00c5;
		IL_001a:
		base.InternalParseCell(relativeCellName, cells, loc);
		num = 6;
		goto IL_00c5;
		IL_00c5:
		while (true)
		{
			switch (num)
			{
			case 10:
				break;
			case 8:
				return;
			case 6:
				if (!RwwCgj4LXwboWUBcoOc(relativeCellName, gVbwyO9z3xgb1jShhyZ(24192)))
				{
					num = 9;
					continue;
				}
				OutputFixture = new FixtureViewModel(InSight, cells, loc, (string)Ip0R0X4KudX5ofYwaIj());
				goto default;
			case 3:
				if (RwwCgj4LXwboWUBcoOc(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(24222)))
				{
					FixtureString = new StringViewModel(InSight, cells, loc, (string)MHtCuG4wtvXsLjy0iNb());
					AddProperty(FixtureString);
					num = 11;
				}
				else
				{
					num = 1;
				}
				continue;
			case 1:
				return;
			default:
				fHi3A39hvR3TmU52bDp();
				if (nxsbn69uXtVVPB7TZiR())
				{
					num = 2;
					if (fHi3A39hvR3TmU52bDp())
					{
					}
					continue;
				}
				num = 0;
				if (nxsbn69uXtVVPB7TZiR())
				{
					continue;
				}
				goto case 0;
			case 4:
				return;
			case 0:
			case 7:
				AddProperty(WorldFixture);
				num = 8;
				continue;
			case 9:
				if (RwwCgj4LXwboWUBcoOc(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(24164)))
				{
					WorldFixture = new WorldFixtureViewModel(InSight, cells, loc, (string)Hpo0xB45YpxZxrl74MU());
					goto case 0;
				}
				num = 3;
				continue;
			case 2:
			case 5:
				AddProperty(OutputFixture);
				num = 4;
				continue;
			case 11:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetFeatures(CvsCellCollection cells, CellType reqDataType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!fHi3A39hvR3TmU52bDp())
		{
			num = 2;
		}
		else
		{
			num = 1;
			if (!nxsbn69uXtVVPB7TZiR())
			{
				goto IL_0047;
			}
		}
		goto IL_00dd;
		IL_0047:
		if (reqDataType != CellType.Point)
		{
			if (reqDataType == CellType.Line)
			{
				goto IL_0069;
			}
			goto IL_010c;
		}
		num = 3;
		goto IL_00dd;
		IL_0069:
		List<CvsEditableDisplayGraphic> list = default;
		list.Add(EditableGraphicHelper.ConstructLine(dscJwa4JFh9DU9D4puZ(PixelLine), cells, dscJwa4JFh9DU9D4puZ(OutputLine).ToString(absoluteRow: true, absoluteColumn: true)));
		num = 7;
		goto IL_00dd;
		IL_00dd:
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 0:
			case 2:
				list = new List<CvsEditableDisplayGraphic>();
				num = 6;
				continue;
			case 1:
			case 4:
				goto IL_0069;
			case 3:
				list.Add(EditableGraphicHelper.ConstructCross(dscJwa4JFh9DU9D4puZ(OutputFixture), cells, dscJwa4JFh9DU9D4puZ(WorldFixture).ToString(absoluteRow: true, absoluteColumn: true)));
				goto IL_010c;
			default:
				num = 5;
				continue;
			case 5:
			case 7:
				goto IL_010c;
			}
			break;
		}
		goto IL_0047;
		IL_010c:
		return (CvsEditableDisplayGraphic[])KGlHW74alWVjSVtFigy(list);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RNflqI9tLocok9Dj6F4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nxsbn69uXtVVPB7TZiR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fHi3A39hvR3TmU52bDp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gVbwyO9z3xgb1jShhyZ(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RwwCgj4LXwboWUBcoOc(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ip0R0X4KudX5ofYwaIj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.OutputFixture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Hpo0xB45YpxZxrl74MU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.WorldFixture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MHtCuG4wtvXsLjy0iNb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.FixtureString;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation dscJwa4JFh9DU9D4puZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KGlHW74alWVjSVtFigy(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
	}
}
