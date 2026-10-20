using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicExtremePoints : CvsGraphicPointList
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicExtremePoints(CvsGraphicExtremePoints graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		rjvIVLrW9QSkWt2BiJ6();
		base._002Ector(graphic);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicExtremePoints()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				Initialize(0, 0, Array.Empty<PointF>());
				num = 5;
				break;
			case 3:
				rjvIVLrW9QSkWt2BiJ6();
				eHMIEurcPYsV9Cu2OQG();
				num = ((!vDQQEjr27NH9MA32y2I()) ? 4 : 0);
				break;
			case 1:
			case 4:
				base._002Ector();
				goto default;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogInspectEdgePoints inspectEdgePoints)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base.FromSerializableGraphic(inspectEdgePoints);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicExtremePoints(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rjvIVLrW9QSkWt2BiJ6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eHMIEurcPYsV9Cu2OQG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vDQQEjr27NH9MA32y2I()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
