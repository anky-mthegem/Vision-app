using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Sensor;

[Serializable]
public sealed class CvsProcessorConstants : IExpressionConstants
{
	private CvsCogSheetLimits WM4MzrDMiF;

	[CompilerGenerated]
	private bool iaGoPPbAuk;

	[CompilerGenerated]
	private Size zVMoIPC5kd;

	public bool IsColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iaGoPPbAuk;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			iaGoPPbAuk = value;
		}
	}

	public int ImageWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SensorSize.Width;
		}
	}

	public int ImageHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SensorSize.Height;
		}
	}

	public Size SensorSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zVMoIPC5kd;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zVMoIPC5kd = value;
		}
	}

	public int SpreadsheetColumns
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return lIKqLRlwab2AaO2MFtM(WM4MzrDMiF);
		}
	}

	public int SpreadsheetRows
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return N8kaYZlsOsyPTwxNONW(WM4MzrDMiF);
		}
	}

	public CvsCellRange SpreadsheetRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new CvsCellRange(0, 0, SpreadsheetRows, SpreadsheetColumns);
		}
	}

	public int MaxExpressionStack
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wmydRKlhOsHQM0KeLrB(WM4MzrDMiF);
		}
	}

	public int MaxExpressionLength
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WM4MzrDMiF.MaxExpressionLength;
		}
	}

	public int SpreadsheetTotalRows
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return N8kaYZlsOsyPTwxNONW(WM4MzrDMiF);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsProcessorConstants(CvsCogSheetLimits limits, CvsCogAcqProperties acqProperties)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		while (true)
		{
			switch (num)
			{
			case 8:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 0;
				break;
			case 0:
				coCHE2Q8Jup76oEcAqU(this);
				num = 2;
				break;
			case 4:
			case 9:
				if (acqProperties != null)
				{
					goto case 6;
				}
				SensorSize = new Size(2592, 1944);
				num = 5;
				break;
			default:
				num = 6;
				break;
			case 6:
				SensorSize = new Size(acqProperties.SensorWidth, vMOjqlQzR5veNNTajRG(acqProperties));
				num = 1;
				break;
			case 1:
				return;
			case 3:
			case 7:
				IsColor = false;
				goto case 4;
			case 2:
				WM4MzrDMiF = limits;
				hGOFj5QZ7e8PV3Xb7xm();
				num = ((!JVVHuEQJSaGcAZffQNO()) ? 7 : 9);
				break;
			case 5:
				IsColor = false;
				num = 10;
				if (JVVHuEQJSaGcAZffQNO())
				{
				}
				break;
			case 10:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void coCHE2Q8Jup76oEcAqU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int vMOjqlQzR5veNNTajRG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogAcqProperties)P_0).SensorHeight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hGOFj5QZ7e8PV3Xb7xm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JVVHuEQJSaGcAZffQNO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int lIKqLRlwab2AaO2MFtM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSheetLimits)P_0).MaxColumns;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int N8kaYZlsOsyPTwxNONW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSheetLimits)P_0).MaxRows;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int wmydRKlhOsHQM0KeLrB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSheetLimits)P_0).MaxExpressionStack;
	}
}
