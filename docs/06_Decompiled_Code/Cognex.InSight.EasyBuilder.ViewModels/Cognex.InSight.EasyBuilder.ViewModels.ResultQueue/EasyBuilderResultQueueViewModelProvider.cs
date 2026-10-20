using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Runtime.ResultQueue;
using Cognex.InSight.Runtime.ViewModels.ResultQueue;

namespace Cognex.InSight.EasyBuilder.ViewModels.ResultQueue;

public class EasyBuilderResultQueueViewModelProvider : ResultQueueViewModelProvider
{
	private readonly EasyBuilderApplicationViewModel jKbGqZjVwL;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EasyBuilderResultQueueViewModelProvider(EasyBuilderApplicationViewModel appViewModel)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VrwJyqKKv26KeQRRxyxb();
		int num = (aNiPQcKKsiqYuLWDIli3() ? 1 : 4);
		while (true)
		{
			switch (num)
			{
			default:
				jKbGqZjVwL = appViewModel;
				num = 5;
				break;
			case 3:
				sdNGplKKPfcDSxHb1hw1(this);
				goto default;
			case 0:
			case 1:
				Y32Y0tKKre89pIJ9gsWO();
				num = 3;
				if (1 == 0)
				{
					return;
				}
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override ResultQueueViewModel CreateInstance(IResultQueueService service)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new EasyBuilderResultQueueViewModel(service, jKbGqZjVwL);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Y32Y0tKKre89pIJ9gsWO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sdNGplKKPfcDSxHb1hw1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ResultQueueViewModelProvider)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool aNiPQcKKsiqYuLWDIli3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VrwJyqKKv26KeQRRxyxb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
