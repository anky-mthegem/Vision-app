using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.InSight.Internal;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicPatternMatch : CvsGraphic
{
	private static readonly Color[] QSXBQEm79X;

	private static readonly Color[] rNxBNEG8bY;

	private int zQsBiB88Yv;

	private CvsPatternMatchSegment[] E5IBdWEpTr;

	private int EuLBuAq04t;

	private int bFaBGOcD8J;

	private bool zHVBDiikhH;

	public int NumSegments
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zQsBiB88Yv;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsGraphicPatternMatch()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (bIXB97xot3AruCkQn3P() ? 6 : 8);
		while (true)
		{
			switch (num)
			{
			case 2:
				rNxBNEG8bY = new Color[4];
				num = 4;
				break;
			case 9:
				rNxBNEG8bY[1] = F9RaqXxYY6VN0aV6WdG(InSightColors.RED);
				num = 3;
				break;
			case 0:
			case 8:
				TmwMUixPgHmLVrLn3C5();
				goto case 1;
			case 4:
				QSXBQEm79X[1] = F9RaqXxYY6VN0aV6WdG(InSightColors.DRED);
				num = 7;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 5:
				rNxBNEG8bY[3] = F9RaqXxYY6VN0aV6WdG(InSightColors.GREEN);
				num = 11;
				break;
			case 10:
				QSXBQEm79X[3] = F9RaqXxYY6VN0aV6WdG(InSightColors.DGREEN);
				num = 9;
				break;
			case 3:
				rNxBNEG8bY[2] = CvsColorHelper.InSightToARGB(InSightColors.YELLOW);
				num = 5;
				if (bIXB97xot3AruCkQn3P())
				{
				}
				break;
			case 1:
			case 6:
				QSXBQEm79X = new Color[4];
				num = 2;
				break;
			case 7:
				QSXBQEm79X[2] = CvsColorHelper.InSightToARGB(InSightColors.DYELLOW);
				goto case 10;
			default:
				num = 10;
				break;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CvsGraphicPatternMatch()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicPatternMatch(CvsGraphicPatternMatch graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		int num2 = default;
		CvsPatternMatchSegment[] array = default;
		while (true)
		{
			switch (num)
			{
			default:
				num = 2;
				break;
			case 4:
				zHVBDiikhH = graphic.zHVBDiikhH;
				num = 13;
				break;
			case 1:
			case 11:
				base._002Ector(graphic);
				zQsBiB88Yv = DP6yvmxNHuq75WomA9g(graphic);
				num = 12;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
				bFaBGOcD8J = graphic.bFaBGOcD8J;
				num = 4;
				break;
			case 6:
				num2 = 0;
				goto case 3;
			case 2:
				num2++;
				num = 3;
				break;
			case 3:
			case 5:
			case 8:
				if (num2 < zQsBiB88Yv)
				{
					E5IBdWEpTr[num2] = new CvsPatternMatchSegment(array[num2]);
					goto case 2;
				}
				num = 10;
				break;
			case 9:
				array = (CvsPatternMatchSegment[])AhJ5akxxYsZ83iT67vI(graphic);
				num = 6;
				break;
			case 10:
				EuLBuAq04t = graphic.EuLBuAq04t;
				num = 0;
				break;
			case 12:
				E5IBdWEpTr = new CvsPatternMatchSegment[zQsBiB88Yv];
				num = 9;
				break;
			case 7:
				TmwMUixPgHmLVrLn3C5();
				ibY4wrx5VH8rcmIykkP();
				num = ((!bIXB97xot3AruCkQn3P()) ? 11 : 8);
				break;
			case 13:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicPatternMatch(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsPatternMatchSegment[] GetSegments()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return E5IBdWEpTr;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TmwMUixPgHmLVrLn3C5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color F9RaqXxYY6VN0aV6WdG(InSightColors color)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsColorHelper.InSightToARGB(color);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ibY4wrx5VH8rcmIykkP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bIXB97xot3AruCkQn3P()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int DP6yvmxNHuq75WomA9g(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicPatternMatch)P_0).NumSegments;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AhJ5akxxYsZ83iT67vI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicPatternMatch)P_0).GetSegments();
	}
}
