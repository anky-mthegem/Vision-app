using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Runtime.ResultQueue;
using Cognex.InSight.Runtime.ViewModels.ResultQueue;

namespace Cognex.InSight.EasyBuilder.ViewModels.ResultQueue;

public class EasyBuilderResultQueueViewModel : ResultQueueViewModel
{
	private readonly EasyBuilderApplicationViewModel K7VG2A3h7c;

	public override bool EnforceReadOnlySettingsOnLoad
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DpYhL1KKlrub9Wyh4wnu(K7VG2A3h7c);
		}
	}

	public override bool IsWatchCellReadOnly
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

	public override CvsCellLocation WatchCellLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bctKTCKKgcv8wR6RDTrG(K7VG2A3h7c);
		}
	}

	public override bool AreQueueConditionFlagsReadOnly
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

	public override ResultQueueConditionFlags QueueConditionFlags
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ResultQueueConditionFlags.NegativeIsReject | ResultQueueConditionFlags.ZeroIsReject | ResultQueueConditionFlags.ErrIsReject;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EasyBuilderResultQueueViewModel(IResultQueueService service, EasyBuilderApplicationViewModel appViewModel)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		lx3mNqKKV3iaMufZf2V5();
		int num = (FexkDfKKfp91OoDsDxQs() ? 3 : 2);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				xwJMKpKKd2mr0hr0kS05(this, service);
				break;
			default:
				num = 4;
				continue;
			case 4:
				break;
			case 0:
			case 2:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				goto case 1;
			case 5:
				return;
			}
			K7VG2A3h7c = appViewModel;
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xwJMKpKKd2mr0hr0kS05(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ResultQueueViewModel)P_0)._002Ector((IResultQueueService)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lx3mNqKKV3iaMufZf2V5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FexkDfKKfp91OoDsDxQs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DpYhL1KKlrub9Wyh4wnu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EasyBuilderApplicationViewModel)P_0).IsEzbEditable;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation bctKTCKKgcv8wR6RDTrG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EasyBuilderApplicationViewModel)P_0).JobPassCellLocation;
	}
}
