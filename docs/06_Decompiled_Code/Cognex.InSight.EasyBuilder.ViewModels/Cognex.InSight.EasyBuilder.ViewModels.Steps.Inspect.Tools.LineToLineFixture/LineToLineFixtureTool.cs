using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Composition;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.LineToLineFixture;

[Export(typeof(LineToLineFixtureTool))]
public class LineToLineFixtureTool : EzTool
{
	private InputLineViewModel JGuMpmQbev;

	[CompilerGenerated]
	private CvsCellLocation giAMUVNCDE;

	private InputLineViewModel cBcM7RMrOC;

	[CompilerGenerated]
	private WorldFixtureViewModel Yg7MNlKUP0;

	[CompilerGenerated]
	private FixtureViewModel e7RMA1NCSc;

	[CompilerGenerated]
	private StringViewModel Xp7Mdgjm9p;

	public InputLineViewModel InputLine0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return JGuMpmQbev;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (sVJgyHXuLy1UpkKgdah())
			{
				num = 2;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 7;
				if (JOeXcDXh5m2GbdvU1vB())
				{
				}
			}
			goto IL_00bc;
			IL_0026:
			CraD6J9DZ1KSaJd0aIn(JGuMpmQbev, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
			num = 8;
			goto IL_00bc;
			IL_00bc:
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				case 4:
					d097Yc9IfKwu4MAhVOh(JGuMpmQbev, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
					goto case 3;
				case 0:
				case 2:
					if (JGuMpmQbev != value)
					{
						num = 5;
						continue;
					}
					return;
				case 6:
					if (JGuMpmQbev != null)
					{
						num = 1;
						continue;
					}
					return;
				case 3:
				case 7:
					JGuMpmQbev = value;
					goto case 6;
				default:
					num = 6;
					continue;
				case 5:
					if (JGuMpmQbev != null)
					{
						num = 4;
						continue;
					}
					goto case 3;
				case 8:
					return;
				}
				break;
			}
			goto IL_0026;
		}
	}

	public InputLineViewModel InputLine1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return cBcM7RMrOC;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			JOeXcDXh5m2GbdvU1vB();
			int num;
			if (sVJgyHXuLy1UpkKgdah())
			{
				num = 3;
			}
			else
			{
				num = 2;
				if (false)
				{
					goto IL_0045;
				}
			}
			goto IL_0085;
			IL_006c:
			cBcM7RMrOC = value;
			goto IL_0028;
			IL_0045:
			CraD6J9DZ1KSaJd0aIn(cBcM7RMrOC, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
			num = 8;
			if (!sVJgyHXuLy1UpkKgdah())
			{
				goto IL_006c;
			}
			goto IL_0085;
			IL_0085:
			while (true)
			{
				switch (num)
				{
				case 7:
					break;
				case 2:
				case 5:
					goto IL_0045;
				case 6:
					goto IL_006c;
				default:
					num = 7;
					continue;
				case 0:
				case 3:
					if (cBcM7RMrOC != value)
					{
						num = 4;
						continue;
					}
					return;
				case 1:
					d097Yc9IfKwu4MAhVOh(cBcM7RMrOC, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
					num = 6;
					if (true)
					{
						continue;
					}
					goto case 4;
				case 4:
					if (cBcM7RMrOC != null)
					{
						num = 1;
						if (true)
						{
							continue;
						}
						return;
					}
					goto IL_006c;
				case 8:
					return;
				}
				break;
			}
			goto IL_0028;
			IL_0028:
			if (cBcM7RMrOC != null)
			{
				goto IL_0045;
			}
		}
	}

	public CvsCellLocation InputCalibrationCellLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return giAMUVNCDE;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			giAMUVNCDE = value;
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
			return Yg7MNlKUP0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Yg7MNlKUP0 = value;
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
			return e7RMA1NCSc;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			e7RMA1NCSc = value;
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
			return Xp7Mdgjm9p;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Xp7Mdgjm9p = value;
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

	public override string ImagePath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Tools_LineToLineIntersection;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LineToLineFixtureTool(InspectStepViewModel inspect, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (sVJgyHXuLy1UpkKgdah())
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_0043;
		IL_0070:
		base._002Ector(inspect, isInitialized);
		num = 5;
		goto IL_0043;
		IL_0043:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				break;
			default:
				num = 2;
				if (!JOeXcDXh5m2GbdvU1vB())
				{
					continue;
				}
				goto IL_0070;
			case 2:
				goto IL_0070;
			case 0:
			case 4:
				B96XIqXtjcyCmqRShy9();
				break;
			case 5:
				return;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		giAMUVNCDE = CvsCellLocation.Invalid;
		goto IL_0070;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalPreParse()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (sVJgyHXuLy1UpkKgdah())
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 4;
			if (1 == 0)
			{
				return;
			}
		}
		goto IL_003f;
		IL_006c:
		base.InternalPreParse();
		num = 5;
		goto IL_003f;
		IL_003f:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			default:
				num = 2;
				if (sVJgyHXuLy1UpkKgdah())
				{
					continue;
				}
				goto IL_006c;
			case 2:
				goto IL_006c;
			case 0:
			case 3:
				InputLine0 = null;
				break;
			case 5:
				return;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		InputLine1 = null;
		goto IL_006c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalParseCell(string relativeCellName, CvsCellCollection cells, CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 15;
		while (true)
		{
			switch (num)
			{
			case 15:
				if (!bvZWpn9LhtNfGKoFeSW(relativeCellName, HyawPfXzOfBYP7qyI52(21598)))
				{
					num = 9;
					if (true)
					{
						break;
					}
					goto case 0;
				}
				InputLine0 = new InputLineViewModel(this, cells, loc, string.Format(Resources.InputLine0, HyawPfXzOfBYP7qyI52(1838)), IsInitialized);
				AddProperty(InputLine0);
				return;
			case 0:
				if (!(relativeCellName == (string)HyawPfXzOfBYP7qyI52(24164)))
				{
					num = 10;
					break;
				}
				WorldFixture = new WorldFixtureViewModel(InSight, cells, loc, Resources.WorldFixture);
				num = 11;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 14:
				return;
			case 2:
				return;
			case 6:
				return;
			case 10:
				if (!bvZWpn9LhtNfGKoFeSW(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(24192)))
				{
					num = 13;
					break;
				}
				OutputFixture = new FixtureViewModel(InSight, cells, loc, (string)MEib7j95SJ95ndrsvI0());
				AddProperty(OutputFixture);
				num = 14;
				if (true)
				{
					break;
				}
				return;
			case 9:
				if (bvZWpn9LhtNfGKoFeSW(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(21622)))
				{
					InputLine1 = new InputLineViewModel(this, cells, loc, (string)ITW1N09KkFlvNaX0dwh(Resources.InputLine0, CdQUGaROfy7He9T0foW.KbIzwHEDLa(21668)), IsInitialized);
					num = 12;
				}
				else
				{
					num = 0;
				}
				break;
			case 1:
				return;
			case 5:
			case 8:
				if (!bvZWpn9LhtNfGKoFeSW(relativeCellName, CdQUGaROfy7He9T0foW.KbIzwHEDLa(24252)))
				{
					return;
				}
				InputCalibrationCellLocation = loc;
				num = 16;
				break;
			case 13:
				do
				{
					if (relativeCellName == CdQUGaROfy7He9T0foW.KbIzwHEDLa(24222))
					{
						FixtureString = new StringViewModel(InSight, cells, loc, (string)hHYebN9wysrivWYVnRm());
						num = 4;
						break;
					}
					sVJgyHXuLy1UpkKgdah();
					if (JOeXcDXh5m2GbdvU1vB())
					{
						num = 2;
						continue;
					}
					num = 8;
					break;
				}
				while (!sVJgyHXuLy1UpkKgdah());
				break;
			case 11:
				AddProperty(WorldFixture);
				num = 7;
				if (sVJgyHXuLy1UpkKgdah())
				{
					break;
				}
				goto case 12;
			case 12:
				AddProperty(InputLine1);
				return;
			default:
				num = 1;
				break;
			case 3:
				return;
			case 4:
				AddProperty(FixtureString);
				num = 3;
				if (JOeXcDXh5m2GbdvU1vB())
				{
				}
				break;
			case 7:
				return;
			case 16:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetFeatures(CvsCellCollection cells, CellType reqDataType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		sVJgyHXuLy1UpkKgdah();
		int num;
		if (!JOeXcDXh5m2GbdvU1vB())
		{
			num = 4;
		}
		else
		{
			num = 3;
			if (JOeXcDXh5m2GbdvU1vB())
			{
			}
		}
		List<CvsEditableDisplayGraphic> list = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				list = new List<CvsEditableDisplayGraphic>();
				goto case 1;
			case 2:
				list.Add(EditableGraphicHelper.ConstructCross(dNeyfN9JEFZhtUdjcGq(OutputFixture), cells, dNeyfN9JEFZhtUdjcGq(WorldFixture).ToString(absoluteRow: true, absoluteColumn: true)));
				num = 5;
				continue;
			case 1:
			case 3:
				if (reqDataType != CellType.Point)
				{
					break;
				}
				goto case 2;
			default:
				num = 2;
				if (!JOeXcDXh5m2GbdvU1vB())
				{
					continue;
				}
				break;
			case 5:
				break;
			}
			break;
		}
		return list.ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void wccg8smvMY(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (zy4PUf9ei30GegJkDim(goKVEh9awcy85keQ6XN(P_1), CdQUGaROfy7He9T0foW.KbIzwHEDLa(5136), StringComparison.Ordinal))
		{
			FireDependencyChanged();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetViewableEditGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (CvsEditableDisplayGraphic[])hSixjD9OyO8ob3MHgjg(new List<CvsEditableDisplayGraphic>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void RefreshPotentialDependencies()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		while (true)
		{
			switch (num)
			{
			default:
				num = 1;
				if (0 == 0)
				{
					break;
				}
				goto case 7;
			case 7:
				base.RefreshPotentialDependencies();
				num = 0;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
				if (InSight != null)
				{
					sVJgyHXuLy1UpkKgdah();
					num = (JOeXcDXh5m2GbdvU1vB() ? 6 : 5);
					break;
				}
				return;
			case 1:
			case 3:
			case 6:
			{
				InputLineViewModel inputLine = InputLine1;
				if (inputLine == null)
				{
					num = 4;
					break;
				}
				inputLine.RefreshLinks();
				num = 8;
				if (sVJgyHXuLy1UpkKgdah())
				{
					break;
				}
				goto case 2;
			}
			case 4:
				return;
			case 2:
			case 5:
				InputLine0?.RefreshLinks();
				goto case 1;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void B96XIqXtjcyCmqRShy9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sVJgyHXuLy1UpkKgdah()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JOeXcDXh5m2GbdvU1vB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HyawPfXzOfBYP7qyI52(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bvZWpn9LhtNfGKoFeSW(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ITW1N09KkFlvNaX0dwh(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MEib7j95SJ95ndrsvI0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.OutputFixture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hHYebN9wysrivWYVnRm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.FixtureString;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation dNeyfN9JEFZhtUdjcGq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object goKVEh9awcy85keQ6XN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertyChangedEventArgs)P_0).PropertyName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zy4PUf9ei30GegJkDim(object P_0, object P_1, StringComparison P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hSixjD9OyO8ob3MHgjg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void d097Yc9IfKwu4MAhVOh(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CraD6J9DZ1KSaJd0aIn(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}
}
