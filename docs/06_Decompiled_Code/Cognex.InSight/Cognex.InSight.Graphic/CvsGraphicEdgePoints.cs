using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicEdgePoints : CvsGraphicPointList
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicEdgePoints(CvsGraphicEdgePoints graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nWAJvHriN1CgHb6elfA();
		base._002Ector(graphic);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicEdgePoints()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				base._002Ector();
				goto default;
			default:
				SffU62rqrk7AQP3d1sw(this, 0, 0, Array.Empty<PointF>());
				num = 5;
				break;
			case 0:
				nWAJvHriN1CgHb6elfA();
				_ = 0;
				if (!k9QAO5rTbZBWxmEy0VU())
				{
					num = 4;
					break;
				}
				num = 3;
				if (false)
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
		return new CvsGraphicEdgePoints(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nWAJvHriN1CgHb6elfA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool k9QAO5rTbZBWxmEy0VU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BiJH8crdChGGfBkHUIX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SffU62rqrk7AQP3d1sw(object P_0, int cellRow, int cellCol, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicPointList)P_0).Initialize(cellRow, cellCol, (PointF[])P_3);
	}
}
