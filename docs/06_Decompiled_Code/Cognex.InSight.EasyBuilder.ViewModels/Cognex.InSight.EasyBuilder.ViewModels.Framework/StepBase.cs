using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Framework;

public abstract class StepBase : BaseViewModel
{
	private bool b1J1NUwHIB;

	private bool wxs1AnAN0M;

	private static bool J461dfv7VB;

	[CompilerGenerated]
	private bool FAX163WyQg;

	private int OJl1u0alxu;

	public abstract string Icon { get; }

	public abstract string Name { get; }

	public abstract string Description { get; }

	public abstract int Order { get; set; }

	public bool AllowShowFilmstrip
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return J461dfv7VB;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			pRJVukK54aCBZY3QAJmC();
			int num;
			if (fP7jPkK59B95Z4vVStbK())
			{
				num = 4;
				if (pRJVukK54aCBZY3QAJmC())
				{
				}
			}
			else
			{
				num = 3;
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					VncfxSK53YsyUDGlipY6(this, BtFDWbK57Z32QgqxIuG6(47412));
					num = 5;
					continue;
				case 0:
				case 4:
					if (J461dfv7VB != value)
					{
						goto case 1;
					}
					return;
				case 1:
				case 3:
					J461dfv7VB = value;
					goto case 2;
				case 5:
					return;
				}
				num = 2;
				if (1 == 0)
				{
					return;
				}
			}
		}
	}

	public bool ShowFilmstrip
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (AllowShowFilmstrip)
			{
				return AllowFilmstrip;
			}
			return false;
		}
	}

	public virtual bool AllowFilmstrip
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

	public bool IsActive
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FAX163WyQg;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			FAX163WyQg = value;
		}
	}

	public bool IsEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return b1J1NUwHIB;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref b1J1NUwHIB, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(5228));
		}
	}

	public bool IsVisible
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wxs1AnAN0M;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref wxs1AnAN0M, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(47442));
		}
	}

	public virtual bool CanEnableLiveMode
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
	internal virtual Task EnterStep(StepBase previousState)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IsActive = true;
		OnEnterStep(previousState);
		return (Task)MC5Uh8K5j9ry0uasBx4t();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal virtual Task LeaveStep(StepBase nextState)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IsActive = false;
		XIh72pK56CGy1i3reQLr(this, nextState);
		return (Task)MC5Uh8K5j9ry0uasBx4t();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual Task OnEnterStep(StepBase previousStep)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)MC5Uh8K5j9ry0uasBx4t();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual Task OnLeaveStep(StepBase nextStep)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected StepBase()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!pRJVukK54aCBZY3QAJmC())
		{
			num = 3;
		}
		else
		{
			num = 2;
			if (1 == 0)
			{
				return;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				v0hdyPK5AgR60NY1PVH9(this);
				num = 6;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				wxs1AnAN0M = true;
				goto case 4;
			default:
				num = 4;
				break;
			case 1:
			case 2:
				b1J1NUwHIB = true;
				num = 5;
				if (fP7jPkK59B95Z4vVStbK())
				{
					break;
				}
				goto case 0;
			case 0:
			case 3:
				TCrnOiK5CpGTT5WunBaM();
				goto case 1;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static StepBase()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		J461dfv7VB = true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BtFDWbK57Z32QgqxIuG6(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VncfxSK53YsyUDGlipY6(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fP7jPkK59B95Z4vVStbK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pRJVukK54aCBZY3QAJmC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MC5Uh8K5j9ry0uasBx4t()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XIh72pK56CGy1i3reQLr(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StepBase)P_0).OnLeaveStep((StepBase)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TCrnOiK5CpGTT5WunBaM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void v0hdyPK5AgR60NY1PVH9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseViewModel)P_0)._002Ector();
	}
}
