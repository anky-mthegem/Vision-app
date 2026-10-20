using System;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public class CvsGraphicLineList : CvsGraphic
{
	protected PointF[] mLineEndpoints;

	public override byte ZOrder
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return 128;
		}
	}

	public int NumPoints
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (mLineEndpoints == null)
			{
				return 0;
			}
			return mLineEndpoints.Length;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicLineList(CvsGraphicLineList graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		g1WNbIOwG6AKjUeyHDV();
		int num;
		if (!iwfnrZOsoA8NCJtD3x6())
		{
			num = 1;
		}
		else
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_0070;
			}
		}
		goto IL_0041;
		IL_008d:
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		num = 4;
		goto IL_0041;
		IL_0070:
		mLineEndpoints = graphic.mLineEndpoints.ToArray();
		num = 5;
		if (true)
		{
			goto IL_0041;
		}
		goto IL_008d;
		IL_0041:
		switch (num)
		{
		case 4:
			base._002Ector(graphic);
			break;
		case 0:
		case 1:
			goto IL_008d;
		case 5:
			return;
		}
		goto IL_0070;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicLineList()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		AH5cTNOhoBD8EyKOe5h();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FromSerializableGraphic(CvsCogLineList lineList)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base.FromSerializableGraphic(lineList);
		mLineEndpoints = (PointF[])YRLf4tO9nD4e1vjlw1h(vIhigWOLndegVykGhbc(lineList));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicLineList(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PointF[] GetPoints()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return mLineEndpoints;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static PointF[] ToPointArray(double[] data)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		PointF[] array = default;
		int num3 = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				array = new PointF[num3];
				num = 2;
				break;
			case 7:
				num3 = data.Length / 2;
				num = 6;
				break;
			case 4:
				num2++;
				goto case 0;
			case 2:
				num2 = 0;
				_ = 1;
				num = (iwfnrZOsoA8NCJtD3x6() ? 1 : 0);
				break;
			default:
				num = 4;
				if (!iwfnrZOsoA8NCJtD3x6())
				{
					break;
				}
				goto case 0;
			case 0:
			case 1:
			case 3:
			case 5:
				if (num2 < num3)
				{
					array[num2] = new PointF((float)data[num2 * 2], (float)data[num2 * 2 + 1]);
					goto case 4;
				}
				num = 8;
				break;
			case 8:
				return array;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool g1WNbIOwG6AKjUeyHDV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool iwfnrZOsoA8NCJtD3x6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AH5cTNOhoBD8EyKOe5h()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vIhigWOLndegVykGhbc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogLineList)P_0).Lines;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YRLf4tO9nD4e1vjlw1h(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ToPointArray((double[])P_0);
	}
}
