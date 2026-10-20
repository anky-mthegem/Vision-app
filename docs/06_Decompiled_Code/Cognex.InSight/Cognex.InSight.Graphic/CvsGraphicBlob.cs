using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public class CvsGraphicBlob : CvsGraphic
{
	private PointF bVCBLXAG4c;

	private int EWJBkXcvDD;

	private int AglBXOHVre;

	private PointF[] gOyBfEQGOH;

	private CvsCogBlob YkfBjGKYIO;

	public PointF Location
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bVCBLXAG4c;
		}
	}

	public int BlobNumber
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EWJBkXcvDD;
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
			return AglBXOHVre;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public override int Id
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return -1;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicBlob()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		C3WWTANWAvmQ08qfqt0();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicBlob(CvsGraphicBlob graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!TxvJvrNcF9Fsks4P7Xc())
		{
			goto IL_001e;
		}
		goto IL_003c;
		IL_001e:
		EWJBkXcvDD = pbwb0pNtcs7wAXYjMX2(graphic);
		goto IL_0065;
		IL_003c:
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			default:
				goto IL_0065;
			case 0:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 7;
				if (E5eU60N2qLEFd3IBKUS())
				{
				}
				continue;
			case 3:
			case 5:
				gOyBfEQGOH = graphic.gOyBfEQGOH;
				num = 8;
				if (E5eU60N2qLEFd3IBKUS())
				{
				}
				continue;
			case 2:
			case 4:
				AglBXOHVre = Q88OgZNCKdLldO3WvC7(graphic);
				goto case 3;
			case 1:
				bVCBLXAG4c = X6VnhqN7riE8aVo7tZE(graphic);
				num = 6;
				continue;
			case 7:
				base._002Ector(graphic);
				num = 1;
				continue;
			case 8:
				return;
			}
			break;
		}
		goto IL_001e;
		IL_0065:
		_ = 0;
		num = ((!TxvJvrNcF9Fsks4P7Xc()) ? 3 : 2);
		goto IL_003c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicBlob(CvsCellLocation location, CvsCogBlob blob, int blobNumber)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		E5eU60N2qLEFd3IBKUS();
		int num = ((!TxvJvrNcF9Fsks4P7Xc()) ? 3 : 4);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				goto case 1;
			case 2:
				FromSerializableGraphic(blob, blobNumber);
				num = 5;
				break;
			case 1:
			case 3:
				base._002Ector(location, blobNumber.ToString());
				goto case 2;
			default:
				num = 2;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetSerializableGraphic()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return YkfBjGKYIO;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogBlob blob, int blobNumber)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (!TxvJvrNcF9Fsks4P7Xc())
		{
			goto IL_001e;
		}
		goto IL_00a9;
		IL_0123:
		int num2 = 0;
		goto IL_0070;
		IL_00a9:
		while (true)
		{
			switch (num)
			{
			case 3:
			case 7:
				break;
			case 8:
				num2++;
				num = 5;
				continue;
			case 2:
				base.FromSerializableGraphic(blob);
				num = 10;
				if (true)
				{
					continue;
				}
				goto case 6;
			case 6:
				YkfBjGKYIO = blob;
				num = 2;
				continue;
			case 5:
				goto IL_0070;
			case 0:
			case 4:
				goto IL_0086;
			default:
				num = 9;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
				bVCBLXAG4c = gOyBfEQGOH[0];
				num = 11;
				continue;
			case 10:
				goto IL_0106;
			case 9:
				goto IL_0123;
			case 11:
				return;
			}
			break;
			IL_0106:
			EWJBkXcvDD = blobNumber;
			_ = 0;
			num = (TxvJvrNcF9Fsks4P7Xc() ? 7 : 0);
		}
		goto IL_001e;
		IL_0070:
		if (num2 >= AglBXOHVre)
		{
			num = 1;
		}
		else
		{
			gOyBfEQGOH[num2] = new PointF((float)((double[])x3k22VNK6kh06JpBQl2(blob))[num2 * 2], (float)((double[])x3k22VNK6kh06JpBQl2(blob))[num2 * 2 + 1]);
			num = 8;
		}
		goto IL_00a9;
		IL_001e:
		AglBXOHVre = ((Array)x3k22VNK6kh06JpBQl2(blob)).Length / 2;
		goto IL_0086;
		IL_0086:
		gOyBfEQGOH = new PointF[AglBXOHVre];
		goto IL_0123;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogBlobChain chain)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		E5eU60N2qLEFd3IBKUS();
		int num;
		if (TxvJvrNcF9Fsks4P7Xc())
		{
			num = 5;
			if (!TxvJvrNcF9Fsks4P7Xc())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_0042;
		IL_0098:
		int num2 = default;
		if (num2 >= AglBXOHVre)
		{
			num = 1;
		}
		else
		{
			gOyBfEQGOH[num2] = new PointF((float)chain.Points[num2 * 2], (float)((double[])f4hocENoF4cioPbZiD5(chain))[num2 * 2 + 1]);
			num = 9;
		}
		goto IL_0042;
		IL_0042:
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			default:
				num = 10;
				if (!E5eU60N2qLEFd3IBKUS())
				{
					continue;
				}
				goto case 8;
			case 8:
				YkfBjGKYIO = null;
				num = 7;
				continue;
			case 2:
			case 10:
				goto IL_0098;
			case 3:
			case 4:
				AglBXOHVre = ((Array)f4hocENoF4cioPbZiD5(chain)).Length / 2;
				gOyBfEQGOH = new PointF[AglBXOHVre];
				num = 6;
				continue;
			case 7:
				EWJBkXcvDD = MGNhSQN5rVTxV0S2Zui(chain);
				goto case 3;
			case 0:
			case 5:
				base.FromSerializableGraphic(chain);
				num = 8;
				continue;
			case 9:
				num2++;
				num = 2;
				continue;
			case 1:
				bVCBLXAG4c = new PointF((float)vDarsiNPUkrMAtCfPrs(chain), (float)chain.Y);
				num = 11;
				if (!E5eU60N2qLEFd3IBKUS())
				{
					continue;
				}
				return;
			case 11:
				return;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		num2 = 0;
		goto IL_0098;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PointF[] GetPoints()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return gOyBfEQGOH;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GraphicsPath GetPath()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!E5eU60N2qLEFd3IBKUS())
		{
			num = 2;
		}
		else
		{
			num = 6;
			if (1 == 0)
			{
				goto IL_0024;
			}
		}
		goto IL_00e3;
		IL_00e3:
		PointF pointF = default;
		GraphicsPath graphicsPath = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 7:
			case 8:
				break;
			case 3:
				pointF = Location;
				num = 4;
				continue;
			case 4:
				zhabNoNNV1GObEwftn0(graphicsPath, pointF, pointF);
				num = 9;
				continue;
			case 5:
				zhabNoNNV1GObEwftn0(graphicsPath, pointF, pointF);
				num = 10;
				if (!E5eU60N2qLEFd3IBKUS())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				graphicsPath = new GraphicsPath();
				goto case 1;
			case 10:
				num2++;
				num = 7;
				continue;
			case 1:
			case 6:
				lN3g4WNYUu6MhsaTM5B(graphicsPath);
				num = 3;
				continue;
			case 9:
				num2 = 0;
				break;
			default:
				num = 8;
				if (TxvJvrNcF9Fsks4P7Xc())
				{
					continue;
				}
				goto case 11;
			case 11:
				return graphicsPath;
			}
			break;
		}
		goto IL_0024;
		IL_0024:
		if (num2 >= gOyBfEQGOH.Length)
		{
			CBBZJiNxUScxiRZTU6B(graphicsPath);
			num = 11;
		}
		else
		{
			pointF = gOyBfEQGOH[num2];
			num = 5;
		}
		goto IL_00e3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicBlob(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void C3WWTANWAvmQ08qfqt0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TxvJvrNcF9Fsks4P7Xc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool E5eU60N2qLEFd3IBKUS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF X6VnhqN7riE8aVo7tZE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicBlob)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int pbwb0pNtcs7wAXYjMX2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicBlob)P_0).BlobNumber;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Q88OgZNCKdLldO3WvC7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicBlob)P_0).NumPoints;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object x3k22VNK6kh06JpBQl2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogBlob)P_0).Points;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int MGNhSQN5rVTxV0S2Zui(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogBlobChain)P_0).Index;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object f4hocENoF4cioPbZiD5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogBlobChain)P_0).Points;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double vDarsiNPUkrMAtCfPrs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogBlobChain)P_0).X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lN3g4WNYUu6MhsaTM5B(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((GraphicsPath)P_0).StartFigure();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zhabNoNNV1GObEwftn0(object P_0, PointF P_1, PointF P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((GraphicsPath)P_0).AddLine(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CBBZJiNxUScxiRZTU6B(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((GraphicsPath)P_0).CloseFigure();
	}
}
