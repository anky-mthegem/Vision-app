using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.Mvvm;
using DUIE9v8SVGR17TWQwQ;
using e0SWISkZIyw0sYl1Ml;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class CircleViewModel : CellViewModel, edFbVBhD6RDc8FLg4U, QpXw26KT7OGd3H62pw
{
	[CompilerGenerated]
	private CvsDisplayableCircle I4nwyTru3r;

	private string Rciwxf3WqO;

	private SourceLink EJAwvNdsXy;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.Circle;
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

	public CvsDisplayableCircle Circle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return I4nwyTru3r;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			I4nwyTru3r = value;
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
			return Rciwxf3WqO;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref Rciwxf3WqO, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(5436)))
			{
				TOptwGFofAfA0Eq8cMl(this, zDWaffFGVpD5g7wSlx5(27684));
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
			if (EJAwvNdsXy == null)
			{
				EJAwvNdsXy = new SourceLink(this);
			}
			return EJAwvNdsXy;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CircleViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = (xOusa4Fry60AuHbhBj4() ? 1 : 4);
		while (true)
		{
			switch (num)
			{
			case 3:
				Refresh(cells);
				num = 6;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				base._002Ector(insight, loc, displayName);
				goto case 2;
			case 0:
			case 1:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 2:
			case 4:
				Circle = EditableGraphicHelper.ConstructCircle(loc, cells);
				goto case 3;
			default:
				num = 3;
				break;
			case 6:
				return;
			}
		}
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
		eFPGkbFBT6r0tKPxZmJ(Circle, STEcJrFZRWS3bG1Q6NQ(cells, inputImageCell));
		ERBSU8Fbq6JUpTqn4XQ(Circle, cells, pass);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void A7WwOnCRN5(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Value = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xOusa4Fry60AuHbhBj4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CTqwOZFPe7v1C3fqXmO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object STEcJrFZRWS3bG1Q6NQ(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eFPGkbFBT6r0tKPxZmJ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EditableGraphicHelper.UpdateEditBounds((ICvsEditableDisplayGraphic)P_0, (CvsCell)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ERBSU8Fbq6JUpTqn4XQ(object P_0, object P_1, bool pass)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EditableGraphicHelper.UpdateCircle((CvsDisplayableCircle)P_0, (CvsCellCollection)P_1, pass);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zDWaffFGVpD5g7wSlx5(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TOptwGFofAfA0Eq8cMl(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
	}
}
