using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.Segment;

public class SpreadsheetSegmentAdapter : SegmentAdapterBase
{
	private static SpreadsheetSegmentAdapter UFZ24Q7Z6F;

	protected override int MaxNumClasses
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SpreadsheetSegmentAdapter GetInstance(CvsInSight insight, Func<Task> triggerAcquisition)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (UFZ24Q7Z6F?.InSight.CogSocket != null)
		{
			return UFZ24Q7Z6F;
		}
		UFZ24Q7Z6F = new SpreadsheetSegmentAdapter(insight, triggerAcquisition);
		return UFZ24Q7Z6F;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SpreadsheetSegmentAdapter(CvsInSight insight, Func<Task> triggerAcquisition = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		base._002Ector(insight, triggerAcquisition);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override ResourceNode GetToolNode(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return InSight.CogSocket.Sheet.PropertySheetResourceNode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override SegmentToolApi GetTool(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SegmentToolApi segmentToolApi = new SegmentToolApi();
		Y10FHBk5byDU66BiwUA(segmentToolApi, zO7sV9kEs4gmxmgbIqM(this, toolId));
		return segmentToolApi;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool KYx2q7ks8vEhbHtIYmx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oNfGf5kdecuylgx2jov()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zO7sV9kEs4gmxmgbIqM(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ViDiELAdapterBase)P_0).GetToolNode((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Y10FHBk5byDU66BiwUA(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SegmentToolApi)P_0).ToolNode = (ResourceNode)P_1;
	}
}
