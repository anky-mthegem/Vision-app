using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.Runtime.ViewModels.Cells;
using DUIE9v8SVGR17TWQwQ;
using e0SWISkZIyw0sYl1Ml;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class RegionViewModel : CellViewModel, edFbVBhD6RDc8FLg4U, QpXw26KT7OGd3H62pw
{
	[CompilerGenerated]
	private CvsDisplayableRegion LX8xsQ9fR8;

	private string CTyxKU9RJo;

	private SourceLink IVOxGVLEQ4;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.Region;
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

	public CvsDisplayableRegion Region
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LX8xsQ9fR8;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			LX8xsQ9fR8 = value;
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
			return CTyxKU9RJo;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref CTyxKU9RJo, value, (string)Kfq6u0HliMcXS3XNuFr(5436)))
			{
				FirePropertyChangedExplicit((string)Kfq6u0HliMcXS3XNuFr(27684));
			}
		}
	}

	SourceLink QpXw26KT7OGd3H62pw.SourceLink
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (IVOxGVLEQ4 == null)
			{
				IVOxGVLEQ4 = new SourceLink(this);
			}
			return IVOxGVLEQ4;
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
	public RegionViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		vcO2o8HDtsar90OaQX3();
		int num;
		if (U3Y8MwHIeShIWjYBJML())
		{
			num = 2;
			if (!U3Y8MwHIeShIWjYBJML())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_0079;
		IL_002e:
		Refresh(cells, init: true);
		num = 6;
		goto IL_0079;
		IL_0079:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 0:
			case 2:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				goto case 1;
			case 5:
				Region = (CvsDisplayableRegion)Kg5T3KHnCPOj6cx0BsZ(loc, Rm0xdLHipS85xCJfWBL(insight));
				break;
			default:
				num = 4;
				continue;
			case 1:
			case 3:
				base._002Ector(insight, loc, displayName);
				num = 5;
				if (true)
				{
					continue;
				}
				return;
			case 6:
				return;
			}
			break;
		}
		goto IL_002e;
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
	public void RefreshGraphic(CvsCellCollection cells, bool pass, CvsCellLocation inputImageCell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		fJIPoRHfk1uKe6thKkY(Region, NTtZN6HVy51yt033rDM(cells, inputImageCell));
		bIeKjQHd6rE6exQ8Y24(Region, cells, pass);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void lXtxiLj66N(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Value = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Rm0xdLHipS85xCJfWBL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Results;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Kg5T3KHnCPOj6cx0BsZ(CvsCellLocation regionLocation, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EditableGraphicHelper.ConstructRegion(regionLocation, (CvsResultSet)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool U3Y8MwHIeShIWjYBJML()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vcO2o8HDtsar90OaQX3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NTtZN6HVy51yt033rDM(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fJIPoRHfk1uKe6thKkY(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EditableGraphicHelper.UpdateEditBounds((ICvsEditableDisplayGraphic)P_0, (CvsCell)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bIeKjQHd6rE6exQ8Y24(object P_0, object P_1, bool pass)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EditableGraphicHelper.UpdateRegion((CvsDisplayableRegion)P_0, (CvsCellCollection)P_1, pass);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Kfq6u0HliMcXS3XNuFr(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}
}
