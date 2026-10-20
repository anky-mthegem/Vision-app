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

public class AnnulusViewModel : CellViewModel, edFbVBhD6RDc8FLg4U, QpXw26KT7OGd3H62pw
{
	[CompilerGenerated]
	private CvsDisplayableAnnulus XdiHBLrZcf;

	private string xulHZ7qYWf;

	private SourceLink nJtHn7IqpX;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.Annulus;
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

	public CvsDisplayableAnnulus Annulus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XdiHBLrZcf;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			XdiHBLrZcf = value;
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
			return xulHZ7qYWf;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref xulHZ7qYWf, value, (string)aJZOLt0swFYyKVC8aFm(5436)))
			{
				FirePropertyChangedExplicit(CdQUGaROfy7He9T0foW.KbIzwHEDLa(27684));
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

	SourceLink QpXw26KT7OGd3H62pw.SourceLink
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (nJtHn7IqpX == null)
			{
				nJtHn7IqpX = new SourceLink(this);
			}
			return nJtHn7IqpX;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AnnulusViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0056;
		IL_009e:
		Refresh(cells);
		num = 6;
		goto IL_0056;
		IL_0056:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 4:
				goto IL_0037;
			case 1:
			case 5:
				base._002Ector(insight, loc, displayName);
				num = 4;
				if (true)
				{
					continue;
				}
				goto IL_009e;
			default:
				goto IL_009e;
			case 6:
				return;
			}
			break;
		}
		goto IL_001a;
		IL_0037:
		Annulus = EditableGraphicHelper.ConstructAnnulus(loc, cells);
		goto IL_009e;
		IL_001a:
		JEUCRW0fhKlnFeNlBSH();
		_ = 0;
		if (h92B5S0nYAtNhjRvEhq())
		{
			num = 5;
			if (false)
			{
				goto IL_0037;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0056;
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
		vQD9nk0l2ceDMXdOxxx(Annulus, t8nbgJ0d7drCLC6ZLwL(cells, inputImageCell));
		j3EtM20gQJmCVfBj2D5(Annulus, cells, pass);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void qsFHsxTs1i(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Value = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JEUCRW0fhKlnFeNlBSH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool h92B5S0nYAtNhjRvEhq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ooWYKC0Vpm3CnkQTskR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object t8nbgJ0d7drCLC6ZLwL(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vQD9nk0l2ceDMXdOxxx(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EditableGraphicHelper.UpdateEditBounds((ICvsEditableDisplayGraphic)P_0, (CvsCell)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void j3EtM20gQJmCVfBj2D5(object P_0, object P_1, bool pass)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EditableGraphicHelper.UpdateAnnulus((CvsDisplayableAnnulus)P_0, (CvsCellCollection)P_1, pass);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aJZOLt0swFYyKVC8aFm(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}
}
