using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicDefectPoints : CvsGraphicPointList
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicDefectPoints(CvsGraphicDefectPoints graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Yi50knrDtuSTZV393tV();
		base._002Ector(graphic);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicDefectPoints()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Fy26xSrA22Pga0JFdq3();
		int num;
		if (lqJc1arVf8GLCEqLF2X())
		{
			num = 3;
			if (!lqJc1arVf8GLCEqLF2X())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_006c;
		IL_002e:
		b4yanerUKEvWIVGVdAM(this, 0, 0, Array.Empty<PointF>());
		num = 5;
		goto IL_006c;
		IL_006c:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				goto IL_0045;
			case 1:
				base._002Ector();
				break;
			case 5:
				return;
			}
			break;
			IL_0045:
			Yi50knrDtuSTZV393tV();
			num = 1;
		}
		goto IL_002e;
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
		return new CvsGraphicDefectPoints(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Yi50knrDtuSTZV393tV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lqJc1arVf8GLCEqLF2X()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Fy26xSrA22Pga0JFdq3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void b4yanerUKEvWIVGVdAM(object P_0, int cellRow, int cellCol, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicPointList)P_0).Initialize(cellRow, cellCol, (PointF[])P_3);
	}
}
