using System.Drawing;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.PatMax;

public class PatternCandidate : BaseViewModel
{
	[CompilerGenerated]
	private string l8abcvpsL1;

	[CompilerGenerated]
	private Point z7ebQm5bPK;

	private bool QbrbgmL5Nn;

	private bool RlhbM2nXc1;

	public string Source
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return l8abcvpsL1;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			l8abcvpsL1 = value;
		}
	}

	public Point Center
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return z7ebQm5bPK;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			z7ebQm5bPK = value;
		}
	}

	public bool Accept
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return QbrbgmL5Nn;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bHRR2h8D5XxQ3cRF72g();
			int num;
			if (!G1c4m28ixhZPPi7CHq6())
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 3;
				if (G1c4m28ixhZPPi7CHq6())
				{
				}
			}
			goto IL_007b;
			IL_002a:
			if (SetField(ref QbrbgmL5Nn, value, (string)qQgr9R8fDi18deJunHr(19806)))
			{
				num = 1;
				if (G1c4m28ixhZPPi7CHq6())
				{
				}
				goto IL_007b;
			}
			return;
			IL_007b:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					break;
				case 1:
					RlhbM2nXc1 = !Accept;
					goto IL_00b2;
				default:
					goto IL_00b2;
				case 5:
					return;
				}
				break;
				IL_00b2:
				HJ1eUS8dQaOFwudssSO(this, qQgr9R8fDi18deJunHr(19822));
				num = 5;
			}
			goto IL_002a;
		}
	}

	public bool Reject
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return RlhbM2nXc1;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (!G1c4m28ixhZPPi7CHq6())
			{
			}
			while (true)
			{
				switch (num)
				{
				default:
					HJ1eUS8dQaOFwudssSO(this, qQgr9R8fDi18deJunHr(19806));
					num = 5;
					continue;
				case 1:
				case 4:
					QbrbgmL5Nn = !Reject;
					goto default;
				case 0:
					break;
				case 5:
					return;
				}
				do
				{
					if (SetField(ref RlhbM2nXc1, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(19822)))
					{
						_ = 1;
						if (G1c4m28ixhZPPi7CHq6())
						{
							num = 3;
							continue;
						}
						num = 4;
						break;
					}
					return;
				}
				while (false);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PatternCandidate(string source, Point center)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0071;
		IL_001a:
		b8db7V8Vcjv4LMW0wdS(this);
		num = 0;
		goto IL_0071;
		IL_0071:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				break;
			case 5:
				htnuqQ8ncldZ6FgKxWs();
				_ = 1;
				if (!G1c4m28ixhZPPi7CHq6())
				{
					num = 2;
					if (true)
					{
						continue;
					}
					goto default;
				}
				num = 4;
				continue;
			default:
				Center = center;
				num = 6;
				continue;
			case 0:
				Source = source;
				goto default;
			case 6:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QbrbgmL5Nn = false;
		RlhbM2nXc1 = false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void htnuqQ8ncldZ6FgKxWs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void b8db7V8Vcjv4LMW0wdS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseViewModel)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bHRR2h8D5XxQ3cRF72g()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool G1c4m28ixhZPPi7CHq6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qQgr9R8fDi18deJunHr(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HJ1eUS8dQaOFwudssSO(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChanged((string)P_1);
	}
}
