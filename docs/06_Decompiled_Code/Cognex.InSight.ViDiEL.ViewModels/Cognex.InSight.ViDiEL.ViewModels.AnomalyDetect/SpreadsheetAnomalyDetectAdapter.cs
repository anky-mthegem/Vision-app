using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cognex.InSight.Internal;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.AnomalyDetect;

public class SpreadsheetAnomalyDetectAdapter : AnomalyDetectAdapterBase
{
	private static SpreadsheetAnomalyDetectAdapter q4XVX0Y80V;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SpreadsheetAnomalyDetectAdapter GetInstance(CvsInSight insight, Func<Task> triggerAcquisition)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (q4XVX0Y80V?.InSight.CogSocket != null)
		{
			return q4XVX0Y80V;
		}
		q4XVX0Y80V = new SpreadsheetAnomalyDetectAdapter(insight, triggerAcquisition);
		return q4XVX0Y80V;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SpreadsheetAnomalyDetectAdapter(CvsInSight insight, Func<Task> triggerAcquisition = null)
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
		return (ResourceNode)Wnf56YglV8vPoUEY3JP(ikSVDFgeCp7EHxoZ7xL(ECLnE9gb3olD9AMplld(InSight)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AnomalyDetectToolApi GetTool(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		AnomalyDetectToolApi anomalyDetectToolApi = new AnomalyDetectToolApi();
		gZSftugyjXYRxML12QC(anomalyDetectToolApi, igvZAug7xLuIFY0bVyi(this, toolId));
		return anomalyDetectToolApi;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ECLnE9gb3olD9AMplld(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).CogSocket;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ikSVDFgeCp7EHxoZ7xL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).Sheet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Wnf56YglV8vPoUEY3JP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocketSheet)P_0).PropertySheetResourceNode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool roxOUFgIhvIcoYjA568()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool z8LPJhgW8uXPajQ5aVu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object igvZAug7xLuIFY0bVyi(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ViDiELAdapterBase)P_0).GetToolNode((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gZSftugyjXYRxML12QC(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((AnomalyDetectToolApi)P_0).ToolNode = (ResourceNode)P_1;
	}
}
