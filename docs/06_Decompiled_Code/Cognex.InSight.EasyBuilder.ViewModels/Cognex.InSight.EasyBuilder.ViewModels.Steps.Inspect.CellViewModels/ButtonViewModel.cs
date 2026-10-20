using System;
using System.Runtime.CompilerServices;
using System.Threading;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

public class ButtonViewModel : CellViewModel
{
	[CompilerGenerated]
	private EventHandler GhuHrZJLbW;

	private string kmZHhcfK8X;

	[CompilerGenerated]
	private readonly DelegateCommand sEgH8QP2o6;

	public override CellType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CellType.Action;
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
			return false;
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
			return kmZHhcfK8X;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref kmZHhcfK8X, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(5436)))
			{
				gskxqd0687w02aeFxsn(this, KPH2oM0jCsZpWQZ3IvM(27684));
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

	public DelegateCommand Command
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return sEgH8QP2o6;
		}
	}

	public event EventHandler CommandExecuted
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			if (!bPeEcZ04Vxl64Lh9jAE())
			{
			}
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					eventHandler2 = eventHandler;
					_ = 0;
					num = (l6fva509M0A488bsAli() ? 4 : 0);
					continue;
				case 2:
				case 4:
					value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					break;
				case 5:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						continue;
					}
					goto case 1;
				case 6:
					eventHandler = GhuHrZJLbW;
					num = 1;
					continue;
				case 7:
					return;
				}
				eventHandler = Interlocked.CompareExchange(ref GhuHrZJLbW, value2, eventHandler2);
				num = 5;
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!l6fva509M0A488bsAli()) ? 6 : 4);
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 6:
					eventHandler2 = eventHandler;
					num = 2;
					continue;
				case 2:
					value2 = (EventHandler)pru59S07kxjYjmhgn4T(eventHandler2, value);
					break;
				default:
					num = 3;
					continue;
				case 0:
				case 4:
					eventHandler = GhuHrZJLbW;
					goto case 1;
				case 5:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						continue;
					}
					goto case 1;
				case 3:
					break;
				case 7:
					return;
				}
				eventHandler = Interlocked.CompareExchange(ref GhuHrZJLbW, value2, eventHandler2);
				num = 5;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ButtonViewModel(CvsInSight insight, CvsCellCollection cells, CvsCellLocation loc, string displayName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 0:
				Icj7Ty03BVsjsw9kg8h();
				num = 1;
				break;
			case 1:
				base._002Ector(insight, loc, displayName);
				_ = 1;
				if (!bPeEcZ04Vxl64Lh9jAE())
				{
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto default;
				}
				num = 4;
				if (!l6fva509M0A488bsAli())
				{
					return;
				}
				break;
			default:
				Refresh(cells, init: true);
				num = 6;
				break;
			case 2:
			case 5:
				sEgH8QP2o6 = new DelegateCommand(HgmHLOyrXd);
				goto default;
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
		RefreshButtonTextValue([MethodImpl(MethodImplOptions.NoInlining)] (string P_0) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Value = P_0;
		}, cell);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void HgmHLOyrXd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		InSight.ClickButton(CellLocation);
		FireCommandExecuted();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FireCommandExecuted()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EventHandler eventHandler = GhuHrZJLbW;
		if (eventHandler != null)
		{
			a89DZh0CQEqT3LPe0Jd(eventHandler, this, EventArgs.Empty);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void cQQHJjOIR3(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Value = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool l6fva509M0A488bsAli()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bPeEcZ04Vxl64Lh9jAE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pru59S07kxjYjmhgn4T(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Icj7Ty03BVsjsw9kg8h()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KPH2oM0jCsZpWQZ3IvM(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gskxqd0687w02aeFxsn(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void a89DZh0CQEqT3LPe0Jd(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (EventArgs)P_2);
	}
}
