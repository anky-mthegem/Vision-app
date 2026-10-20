using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.Mvvm;
using e0SWISkZIyw0sYl1Ml;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class FixtureArrayViewModel : CellViewModel, QpXw26KT7OGd3H62pw
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public string text;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass21_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Pl81bpKt3TO7KYulCNgN();
			P5u0nvKtjpQWSHDc8jwy(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CFindMatch_003Eb__0(FixtureViewModel f)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fhpJsDKt6S1tAMgGs1PD(f, text) != null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Pl81bpKt3TO7KYulCNgN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void P5u0nvKtjpQWSHDc8jwy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool stpjekKt4na7olBdl99Y()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ESqpI5Kt7INS4SABRIie()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fhpJsDKt6S1tAMgGs1PD(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).FindMatch((string)P_1);
		}
	}

	private string JsYylNfPVf;

	[CompilerGenerated]
	private readonly ObservableCollection<FixtureViewModel> qUnyTWG2U0;

	private SourceLink XFuyWTFhfY;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.FixtureArray;
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
			return JsYylNfPVf;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref JsYylNfPVf, value, (string)bfp2xPM1L8aWkjkKVBG(5436)))
			{
				b2Ed7lMhb3E4eClJyTv(this, bfp2xPM1L8aWkjkKVBG(27684));
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

	public ObservableCollection<FixtureViewModel> Fixtures
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qUnyTWG2U0;
		}
	}

	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Fixtures.Count;
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
			if (XFuyWTFhfY == null)
			{
				XFuyWTFhfY = new SourceLink(this);
			}
			return XFuyWTFhfY;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FixtureArrayViewModel(CvsInSight insight, CvsCellCollection cells, string virtualCellName, string refExpression, string displayName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!FhgAusMNBCPswK6ZIrP())
		{
			num = 6;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_0056;
		IL_0026:
		Refresh(cells);
		num = 7;
		goto IL_0056;
		IL_0056:
		while (true)
		{
			switch (num)
			{
			case 3:
			case 4:
				break;
			case 1:
				base._002Ector(insight, virtualCellName, refExpression, displayName);
				goto case 5;
			default:
				num = 5;
				continue;
			case 2:
				qUnyTWG2U0 = new ObservableCollection<FixtureViewModel>();
				num = 1;
				continue;
			case 5:
				eNKrssMcddhNwacqJD4(Fixtures, new NotifyCollectionChangedEventHandler(zYFyMG26rR));
				break;
			case 0:
			case 6:
				KP0jRDM2RMXjdkH8TXb();
				num = 2;
				if (sSrwGmMQpTCv7ZkpCE4())
				{
					continue;
				}
				return;
			case 7:
				return;
			}
			break;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zYFyMG26rR(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		GCvtySMueqByDO1OJjX(this, bfp2xPM1L8aWkjkKVBG(26986));
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
	public override CellViewModel FindMatch(string text)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!FhgAusMNBCPswK6ZIrP())
		{
			num = 2;
			if (FhgAusMNBCPswK6ZIrP())
			{
			}
		}
		else
		{
			num = 4;
		}
		CellViewModel cellViewModel = default;
		_003C_003Ec__DisplayClass21_0 obj = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				cellViewModel = Fixtures.FirstOrDefault(obj._003CFindMatch_003Eb__0);
				num = 7;
				continue;
			case 1:
			case 4:
				obj.text = text;
				num = 5;
				continue;
			case 3:
				if (cellViewModel == null)
				{
					num = 6;
					continue;
				}
				break;
			case 5:
				cellViewModel = base.FindMatch(obj.text);
				goto case 3;
			default:
				num = 3;
				if (sSrwGmMQpTCv7ZkpCE4())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				obj = new _003C_003Ec__DisplayClass21_0();
				goto case 1;
			case 7:
				break;
			}
			break;
		}
		return cellViewModel;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void s67yRdN3SE(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Value = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KP0jRDM2RMXjdkH8TXb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eNKrssMcddhNwacqJD4(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ObservableCollection<FixtureViewModel>)P_0).CollectionChanged += (NotifyCollectionChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sSrwGmMQpTCv7ZkpCE4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FhgAusMNBCPswK6ZIrP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bfp2xPM1L8aWkjkKVBG(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GCvtySMueqByDO1OJjX(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void b2Ed7lMhb3E4eClJyTv(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
	}
}
