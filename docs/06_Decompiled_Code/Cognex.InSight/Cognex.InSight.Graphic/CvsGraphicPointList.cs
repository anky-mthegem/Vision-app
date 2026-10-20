using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public abstract class CvsGraphicPointList : CvsGraphic
{
	protected PointF[] mPoints;

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
			if (mPoints == null)
			{
				return 0;
			}
			return mPoints.Length;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected CvsGraphicPointList(CvsGraphicPointList graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!MjtytbOZVqC860kEFFg()) ? 3 : 2);
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 1:
			case 3:
				base._002Ector(graphic);
				break;
			default:
				num = 4;
				if (!VQSaFDOJad6WinnWgYe())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				AGqAnpO8T9F1cptP4Vs();
				goto case 1;
			case 5:
				return;
			}
			mPoints = graphic.mPoints;
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected CvsGraphicPointList()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		AGqAnpO8T9F1cptP4Vs();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Initialize(int cellRow, int cellCol, PointF[] points)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0066;
		IL_001a:
		wOZxwwOzBvaiNoGbWmI(this, null);
		num = 6;
		if (1 == 0)
		{
			goto IL_002d;
		}
		goto IL_0066;
		IL_0066:
		while (true)
		{
			switch (num)
			{
			case 5:
				goto IL_002d;
			case 0:
				mPoints = points;
				break;
			case 1:
			case 4:
				mCellLocation = new CvsCellLocation(cellRow, cellCol);
				num = 0;
				continue;
			case 6:
				return;
			}
			break;
		}
		goto IL_001a;
		IL_002d:
		CheckLock();
		VQSaFDOJad6WinnWgYe();
		num = ((!MjtytbOZVqC860kEFFg()) ? 2 : 4);
		goto IL_0066;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FromSerializableGraphic(CvsCogPointList pointList)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base.FromSerializableGraphic(pointList);
		mPoints = (PointF[])PxpgexMsyMxZR96XZTQ(NjtNZHMwU4wjA3vyZO2(pointList));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PointF[] GetPoints()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return mPoints;
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
			case 1:
				array = new PointF[num3];
				_ = 1;
				num = ((!VQSaFDOJad6WinnWgYe()) ? 6 : 0);
				break;
			case 7:
				num3 = data.Length / 2;
				num = 1;
				break;
			case 4:
				num2++;
				num = 5;
				break;
			case 2:
			case 6:
				num2 = 0;
				goto case 0;
			case 0:
			case 3:
			case 5:
				if (num2 >= num3)
				{
					num = 8;
					break;
				}
				array[num2] = new PointF((float)data[num2 * 2], (float)data[num2 * 2 + 1]);
				goto case 4;
			default:
				num = 4;
				break;
			case 8:
				return array;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AGqAnpO8T9F1cptP4Vs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MjtytbOZVqC860kEFFg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VQSaFDOJad6WinnWgYe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wOZxwwOzBvaiNoGbWmI(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NjtNZHMwU4wjA3vyZO2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogPointList)P_0).Points;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PxpgexMsyMxZR96XZTQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ToPointArray((double[])P_0);
	}
}
