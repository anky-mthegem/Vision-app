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

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.MidLine;

[Export(typeof(MidLineTool))]
public class MidLineTool : EzTool
{
	private InputLineViewModel hnQQS0PFyN;

	private InputLineViewModel W6eQDZMoHg;

	[CompilerGenerated]
	private LineViewModel x7WQ37kAM4;

	[CompilerGenerated]
	private LineViewModel BN3QId7tpx;

	[CompilerGenerated]
	private CheckBoxViewModel uuYQfpVMmj;

	public InputLineViewModel InputLine0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hnQQS0PFyN;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
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
				case 7:
					if (hnQQS0PFyN != null)
					{
						num = 5;
						break;
					}
					goto case 3;
				case 3:
				case 6:
					hnQQS0PFyN = value;
					goto default;
				case 1:
					if (hnQQS0PFyN != value)
					{
						num = 7;
						break;
					}
					return;
				default:
					if (hnQQS0PFyN != null)
					{
						num = 0;
						if (MYF5UeEAAXUXDnelEQe())
						{
							break;
						}
						goto case 5;
					}
					return;
				case 5:
					cCpK6aEm9ZBDvvcB3Ql(hnQQS0PFyN, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
					_ = 0;
					num = (MYF5UeEAAXUXDnelEQe() ? 6 : 2);
					break;
				case 0:
					XeuoR4EQmEgX3pr5Bbv(hnQQS0PFyN, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
					num = 8;
					break;
				case 8:
					return;
				}
			}
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
			return W6eQDZMoHg;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			MYF5UeEAAXUXDnelEQe();
			int num;
			if (!US5R2tERGeKsnnCtofJ())
			{
				num = 3;
			}
			else
			{
				num = 1;
				if (1 == 0)
				{
					goto IL_00d4;
				}
			}
			goto IL_0099;
			IL_00d4:
			if (W6eQDZMoHg == null)
			{
				goto IL_0080;
			}
			num = 7;
			goto IL_0099;
			IL_0080:
			W6eQDZMoHg = value;
			goto IL_00e9;
			IL_0099:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					if (W6eQDZMoHg != value)
					{
						num = 2;
						continue;
					}
					return;
				case 6:
					W6eQDZMoHg.PropertyChanged += SourceLink_PropertyChanged;
					num = 8;
					continue;
				case 7:
					cCpK6aEm9ZBDvvcB3Ql(W6eQDZMoHg, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
					num = 5;
					continue;
				case 5:
					break;
				case 2:
					goto IL_00d4;
				default:
					goto IL_00e9;
				case 8:
					return;
				}
				break;
			}
			goto IL_0080;
			IL_00e9:
			if (W6eQDZMoHg != null)
			{
				num = 6;
				goto IL_0099;
			}
		}
	}

	public LineViewModel OutputLine
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return x7WQ37kAM4;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			x7WQ37kAM4 = value;
		}
	}

	public LineViewModel PixelLine
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return BN3QId7tpx;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			BN3QId7tpx = value;
		}
	}

	public CheckBoxViewModel Invert
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return uuYQfpVMmj;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			uuYQfpVMmj = value;
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
			return string.Format(((CvsEditableDisplayGraphic)IyqXnHExTqaL43uZTK8(PixelLine)).AdjustmentString);
		}
	}

	public override CellViewModel ResultCell
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OutputLine;
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
			return XAMLGraphicKeys.Tools_AngleIcon;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MidLineTool(InspectStepViewModel inspect, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		uNd1ogEWhv1JC9divKE();
		base._002Ector(inspect, isInitialized);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalPreParse()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 3:
				InputLine0 = null;
				US5R2tERGeKsnnCtofJ();
				if (MYF5UeEAAXUXDnelEQe())
				{
					num = 0;
					if (!US5R2tERGeKsnnCtofJ())
					{
						continue;
					}
					goto case 0;
				}
				num = 4;
				continue;
			case 0:
			case 1:
				InputLine1 = null;
				break;
			case 5:
				return;
			}
			base.InternalPreParse();
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalParseCell(string relativeCellName, CvsCellCollection cells, CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (false)
		{
			return;
		}
		do
		{
			IL_0159:
			switch (num)
			{
			case 12:
				return;
			case 5:
				if (R8ejV3EyO4GpAfD69U9(relativeCellName, wPHxAjETOFUgJyEv4bv(9034)))
				{
					OutputLine = new LineViewModel(InSight, cells, loc, (string)lmjGYJEMNFWDfMERwkV());
					break;
				}
				MYF5UeEAAXUXDnelEQe();
				if (US5R2tERGeKsnnCtofJ())
				{
					num = 6;
					goto IL_0159;
				}
				num = 10;
				if (MYF5UeEAAXUXDnelEQe())
				{
					goto IL_0159;
				}
				goto case 3;
			case 3:
			case 10:
				if (R8ejV3EyO4GpAfD69U9(relativeCellName, wPHxAjETOFUgJyEv4bv(21646)))
				{
					PixelLine = new LineViewModel(InSight, cells, loc, (string)iRkBD1EY8YqaNIKbHZg());
					num = 9;
					if (MYF5UeEAAXUXDnelEQe())
					{
						goto IL_0159;
					}
				}
				return;
			case 4:
				AddProperty(InputLine0);
				num = 11;
				goto IL_0159;
			case 1:
				if (!R8ejV3EyO4GpAfD69U9(relativeCellName, wPHxAjETOFUgJyEv4bv(21622)))
				{
					num = 5;
					goto IL_0159;
				}
				InputLine1 = new InputLineViewModel(this, cells, loc, (string)yvTITYE0y4BghQw9HAT(epyAbkEFspLRjovQhV5(), wPHxAjETOFUgJyEv4bv(21668)), IsInitialized);
				goto case 0;
			case 7:
				return;
			case 11:
				return;
			default:
				num = 0;
				if (0 == 0)
				{
					goto IL_0159;
				}
				goto case 9;
			case 9:
				AddProperty(PixelLine);
				num = 13;
				goto IL_0159;
			case 2:
				if (relativeCellName == (string)wPHxAjETOFUgJyEv4bv(21598))
				{
					InputLine0 = new InputLineViewModel(this, cells, loc, (string)yvTITYE0y4BghQw9HAT(Resources.InputLine0, CdQUGaROfy7He9T0foW.KbIzwHEDLa(1838)), IsInitialized);
					num = 4;
					goto IL_0159;
				}
				num = 1;
				if (true)
				{
					goto IL_0159;
				}
				goto case 0;
			case 0:
				AddProperty(InputLine1);
				num = 12;
				goto IL_0159;
			case 6:
			case 8:
				break;
			case 13:
				return;
			}
			AddProperty(OutputLine);
			num = 7;
		}
		while (true);
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
		if (!US5R2tERGeKsnnCtofJ())
		{
			num = 4;
		}
		else
		{
			num = 3;
			if (!MYF5UeEAAXUXDnelEQe())
			{
				goto IL_0071;
			}
		}
		goto IL_003e;
		IL_003e:
		List<CvsEditableDisplayGraphic> list = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				if (reqDataType == CellType.Line)
				{
					break;
				}
				goto case 5;
			case 0:
			case 4:
				goto IL_00a7;
			case 5:
				return (CvsEditableDisplayGraphic[])UsBR8YEUZVCNvMZTHdm(list);
			}
			break;
			IL_00a7:
			list = new List<CvsEditableDisplayGraphic>();
			num = 1;
		}
		goto IL_0071;
		IL_0071:
		list.Add(EditableGraphicHelper.ConstructLine(PixelLine.CellLocation, cells, OutputLine.CellLocation.ToString(absoluteRow: true, absoluteColumn: true)));
		num = 5;
		goto IL_003e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UbbQ667eMh(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (((string)OWI4TgEHUsPuv4G2wtE(P_1)).Equals((string)wPHxAjETOFUgJyEv4bv(5136), StringComparison.Ordinal))
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
		int num = 1;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_007b;
		IL_001a:
		CvsDisplayableLine cvsDisplayableLine = (CvsDisplayableLine)IyqXnHExTqaL43uZTK8(PixelLine);
		MYF5UeEAAXUXDnelEQe();
		num = (US5R2tERGeKsnnCtofJ() ? 4 : 0);
		goto IL_007b;
		IL_007b:
		List<CvsEditableDisplayGraphic> list = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			default:
				list.Add(cvsDisplayableLine);
				num = 6;
				continue;
			case 1:
				list = new List<CvsEditableDisplayGraphic>();
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				if (cvsDisplayableLine != null)
				{
					goto default;
				}
				goto case 6;
			case 6:
				return list.ToArray();
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void RefreshPotentialDependencies()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		while (true)
		{
			IL_009b:
			switch (num)
			{
			case 6:
				if (InSight != null)
				{
					num = 2;
					continue;
				}
				return;
			case 1:
				return;
			case 2:
			{
				InputLineViewModel inputLine = InputLine0;
				if (inputLine == null)
				{
					_ = 1;
					if (US5R2tERGeKsnnCtofJ())
					{
						num = 7;
						if (MYF5UeEAAXUXDnelEQe())
						{
							continue;
						}
						break;
					}
					num = 0;
					if (0 == 0)
					{
						continue;
					}
				}
				else
				{
					inputLine.RefreshLinks();
				}
				goto default;
			}
			default:
			{
				InputLineViewModel inputLine2;
				while (true)
				{
					inputLine2 = InputLine1;
					if (inputLine2 != null)
					{
						break;
					}
					num = 1;
					if (1 == 0)
					{
						continue;
					}
					goto IL_009b;
				}
				inputLine2.RefreshLinks();
				num = 8;
				if (0 == 0)
				{
					continue;
				}
				goto case 2;
			}
			case 5:
				break;
			case 8:
				return;
			}
			base.RefreshPotentialDependencies();
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uNd1ogEWhv1JC9divKE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MYF5UeEAAXUXDnelEQe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool US5R2tERGeKsnnCtofJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wPHxAjETOFUgJyEv4bv(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool R8ejV3EyO4GpAfD69U9(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yvTITYE0y4BghQw9HAT(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object epyAbkEFspLRjovQhV5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.InputLine0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lmjGYJEMNFWDfMERwkV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.OutputLine;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iRkBD1EY8YqaNIKbHZg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.PixelLine;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UsBR8YEUZVCNvMZTHdm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OWI4TgEHUsPuv4G2wtE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertyChangedEventArgs)P_0).PropertyName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IyqXnHExTqaL43uZTK8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((LineViewModel)P_0).Line;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cCpK6aEm9ZBDvvcB3Ql(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XeuoR4EQmEgX3pr5Bbv(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}
}
