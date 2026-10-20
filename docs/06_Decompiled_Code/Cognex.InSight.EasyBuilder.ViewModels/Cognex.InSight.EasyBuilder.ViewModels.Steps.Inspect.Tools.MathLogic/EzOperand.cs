using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.MathLogic;

public class EzOperand : INamedOperand
{
	private CellViewModel RTkQxoAtvk;

	private string D2PQvpTrf4;

	private CvsCellLocation gE4Qean2tZ;

	private string HYHQ2KVIUx;

	string INamedOperand.Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return D2PQvpTrf4;
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
			return gE4Qean2tZ;
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
			return HYHQ2KVIUx;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EzOperand(CellViewModel vm)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 7:
				RTkQxoAtvk = vm;
				goto case 3;
			case 1:
				HYHQ2KVIUx = (string)pE1P3bpeCTvPcSC6TTZ(vm);
				num = 8;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				base._002Ector();
				dY79KOpwDh3G7AeLA0N();
				if (!S1JyVtp5E4qatHJFDDK())
				{
					num = 4;
					break;
				}
				num = 7;
				if (dY79KOpwDh3G7AeLA0N())
				{
				}
				break;
			case 0:
				gE4Qean2tZ = oyI0Qkpa4A0pU5fRgof(vm);
				num = 1;
				break;
			case 3:
			case 4:
				D2PQvpTrf4 = (string)Y4LNGGpJIRucRJdJBip(vm);
				goto case 0;
			default:
				num = 0;
				break;
			case 6:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 5;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Y4LNGGpJIRucRJdJBip(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation oyI0Qkpa4A0pU5fRgof(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pE1P3bpeCTvPcSC6TTZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).RefExpression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool S1JyVtp5E4qatHJFDDK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dY79KOpwDh3G7AeLA0N()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
