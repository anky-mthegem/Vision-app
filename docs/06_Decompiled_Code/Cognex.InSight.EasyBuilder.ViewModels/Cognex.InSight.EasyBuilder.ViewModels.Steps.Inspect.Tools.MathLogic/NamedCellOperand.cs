using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.MathLogic;

public class NamedCellOperand : INamedOperand
{
	private readonly string T06gr1qRsu;

	private readonly CvsCellLocation aRXghklPg6;

	string INamedOperand.Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return T06gr1qRsu;
		}
	}

	CvsCellLocation INamedOperand.Location
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aRXghklPg6;
		}
	}

	string INamedOperand.Expression
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aRXghklPg6.ToString(absoluteRow: true, absoluteColumn: true);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NamedCellOperand(string name, CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0064;
		IL_001a:
		RBWQuXX1B1YFlYIMdpZ(this);
		num = 4;
		goto IL_0064;
		IL_0064:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				break;
			case 0:
				v1EyFxXcPk2Wuedhnn6();
				CaZh6lXNXfkdrUnIoj1();
				if (!Mbw1CnX2mR1DGEdj5j2())
				{
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					goto case 4;
				}
				num = 2;
				continue;
			case 4:
				T06gr1qRsu = name;
				goto default;
			default:
				aRXghklPg6 = loc;
				num = 6;
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
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void v1EyFxXcPk2Wuedhnn6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RBWQuXX1B1YFlYIMdpZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CaZh6lXNXfkdrUnIoj1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Mbw1CnX2mR1DGEdj5j2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
