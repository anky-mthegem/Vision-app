using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsChildSerializable]
public class CvsCogAcqSettings
{
	public const string TriggerModeName = "mode";

	public const string DelayName = "delay";

	public const string ExposureName = "exposure";

	public const string GainName = "gain";

	public const string NumberOfImageBuffersName = "imageBuffers";

	public const string NumberOfRowsName = "numRows";

	public const string NumberOfColumnsName = "numCols";

	public const string NumberOfBuffersName = "imageBuffers";

	public const string OffsetName = "offset";

	public const string OrientationName = "orientation";

	public const string StartRowName = "startRow";

	public const string StartColumnName = "startCol";

	public const string StrobePolarityName = "strobePolarity";

	public const string StrobeStartName = "strobeStart";

	public const string TriggerDebounceName = "triggerDebounce";

	public const string FocusSettingsName = "focus";

	public const string FocusRegionName = "focus/region";

	public const string FocusPositionName = "focus/position";

	public const string FocusDistanceMmName = "focus/distance";

	public const string WhiteBalanceSettingsName = "whiteBalance";

	public const string WhiteBalanceRegionName = "whiteBalance/region";

	public const string WhiteBalanceRedName = "whiteBalance/red";

	public const string WhiteBalanceGreenName = "whiteBalance/green";

	public const string WhiteBalanceBlueName = "whiteBalance/blue";

	public const string IlluminationSettingsName = "illumination";

	public const string IlluminationModeName = "illumination/mode";

	public const string IlluminationBankEnablesName = "illumination/bankEnables";

	public const string IlluminationIntensityName = "illumination/intensity";

	public const string IlluminationAlwaysOnName = "illumination/alwaysOn";

	public const string IlluminationLightColorName = "illumination/lightColor";

	public const string HdrModeName = "hdrMode";

	public const string HdrKernelSizeName = "hdrKernelSize";

	public const int MinRangeIndex = 0;

	public const int MaxRangeIndex = 1;

	private bool iuaHB601F6;

	private int bGsHyjeI5f;

	private int[] MfUHMIT8oo;

	private bool YoGHIeqrf7;

	private double YKFHr2CKTW;

	private double[] xFlHQvHGC4;

	private bool eoIHmI5C5D;

	private int kgGHNG7uKy;

	private int[] DBKHfE9dYj;

	private bool X4oH44uLHD;

	private int oQwH2oUZed;

	private int[] RQdHXsCjiH;

	private bool nkBHq8pN0Y;

	private int Ri8HJO6LO2;

	private int[] khGHKstRjF;

	private bool rdpHRwFnVV;

	private int hgvHaaA3jC;

	private int[] CU7HxfWn9K;

	private bool rsBH65kLbb;

	private int uCKHpUh670;

	private int[] Q09H3QrSAB;

	private bool uBtH9X2BHV;

	private int syvHLZ7S2j;

	private Dictionary<string, string> EdmHVwb9os;

	private bool wgUHOWClW7;

	private int KViHt3MvQP;

	private int[] KNvH8BCriW;

	private bool oO8HhyaDKj;

	private int SYaHDCwRw7;

	private int[] DaJHwrBtBv;

	private bool o19Hi77b3C;

	private int sueHuPnk4I;

	private bool iJAHZ2IQ1r;

	private int Sq5Hgk0BE0;

	private Dictionary<string, string> qeqHSEwfJP;

	private bool BlGHnG4KZv;

	private int NL9H1iMOxb;

	private bool YPPHka15PL;

	private double E1VHE2Zh8G;

	private double[] CKSHstsiOm;

	[CompilerGenerated]
	private bool lTyH0ET8JL;

	private CvsCogIlluminationSettings XIgHG1Pf1o;

	[CompilerGenerated]
	private bool cGgH7vtKiF;

	private CvsCogFocusSettings ngbHWMsvQ7;

	private bool umbHoVYy4C;

	private int GJgHPo892O;

	private Dictionary<string, string> FDkHjOFlPD;

	private bool NvvHckRAkp;

	private int eW8HdRcBf8;

	private Dictionary<string, string> kdlHTPJLwy;

	[CompilerGenerated]
	private bool qYMHv6vDKr;

	private CvsCogWhiteBalanceSettings dRVHz8XXbd;

	public bool IsDelaySupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (iuaHB601F6)
			{
				return DelayRange[0] != DelayRange[1];
			}
			return false;
		}
	}

	[JsonProperty(PropertyName = "delay")]
	public int Delay
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bGsHyjeI5f;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bGsHyjeI5f = value;
			iuaHB601F6 = true;
		}
	}

	[JsonProperty(PropertyName = "delayRange")]
	public int[] DelayRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MfUHMIT8oo;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			MfUHMIT8oo = value;
		}
	}

	public bool IsExposureSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (YoGHIeqrf7)
			{
				return ExposureRange[0] != ExposureRange[1];
			}
			return false;
		}
	}

	[JsonProperty(PropertyName = "exposure")]
	public double Exposure
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return YKFHr2CKTW;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			YKFHr2CKTW = value;
			YoGHIeqrf7 = true;
		}
	}

	[JsonProperty(PropertyName = "exposureRange")]
	public double[] ExposureRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xFlHQvHGC4;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xFlHQvHGC4 = value;
		}
	}

	public bool IsGainSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (eoIHmI5C5D)
			{
				return GainRange[0] != GainRange[1];
			}
			return false;
		}
	}

	[JsonProperty(PropertyName = "gain")]
	public int Gain
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgGHNG7uKy;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kgGHNG7uKy = value;
			eoIHmI5C5D = true;
		}
	}

	[JsonProperty(PropertyName = "gainRange")]
	public int[] GainRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DBKHfE9dYj;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			DBKHfE9dYj = value;
		}
	}

	public bool IsNumberOfImageBuffersSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (X4oH44uLHD)
			{
				return NumberOfImageBuffersRange[0] != NumberOfImageBuffersRange[1];
			}
			return false;
		}
	}

	[JsonProperty(PropertyName = "imageBuffers")]
	public int NumberOfImageBuffers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return oQwH2oUZed;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oQwH2oUZed = value;
			X4oH44uLHD = true;
		}
	}

	[JsonProperty(PropertyName = "imageBuffersRange")]
	public int[] NumberOfImageBuffersRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return RQdHXsCjiH;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			RQdHXsCjiH = value;
		}
	}

	public bool IsNumberOfRowsSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return nkBHq8pN0Y;
		}
	}

	public bool IsNumberOfRowsEditable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (nkBHq8pN0Y)
			{
				return NumberOfRowsRange[0] != NumberOfRowsRange[1];
			}
			return false;
		}
	}

	[JsonProperty(PropertyName = "numRows")]
	public int NumberOfRows
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Ri8HJO6LO2;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Ri8HJO6LO2 = value;
			nkBHq8pN0Y = true;
		}
	}

	[JsonProperty(PropertyName = "numRowsRange")]
	public int[] NumberOfRowsRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return khGHKstRjF;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			khGHKstRjF = value;
		}
	}

	public bool IsNumberOfColumnsSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rdpHRwFnVV;
		}
	}

	public bool IsNumberOfColumnsEditable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (rdpHRwFnVV)
			{
				return NumberOfColumnsRange[0] != NumberOfColumnsRange[1];
			}
			return false;
		}
	}

	[JsonProperty(PropertyName = "numCols")]
	public int NumberOfColumns
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hgvHaaA3jC;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hgvHaaA3jC = value;
			rdpHRwFnVV = true;
		}
	}

	[JsonProperty(PropertyName = "numColsRange")]
	public int[] NumberOfColumnsRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CU7HxfWn9K;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CU7HxfWn9K = value;
		}
	}

	public bool IsOffsetSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (rsBH65kLbb)
			{
				return OffsetRange[0] != OffsetRange[1];
			}
			return false;
		}
	}

	[JsonProperty(PropertyName = "offset")]
	public int Offset
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return uCKHpUh670;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			uCKHpUh670 = value;
			rsBH65kLbb = true;
		}
	}

	[JsonProperty(PropertyName = "offsetRange")]
	public int[] OffsetRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Q09H3QrSAB;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Q09H3QrSAB = value;
		}
	}

	public bool IsOrientationSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (uBtH9X2BHV && OrientationValues != null)
			{
				return Gj9cfxbj9BjlIfmkFZ(OrientationValues) > 1;
			}
			return false;
		}
	}

	[JsonProperty(PropertyName = "orientation")]
	public int Orientation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return syvHLZ7S2j;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			syvHLZ7S2j = value;
			uBtH9X2BHV = true;
		}
	}

	[JsonProperty(PropertyName = "orientationValues")]
	public Dictionary<string, string> OrientationValues
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EdmHVwb9os;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EdmHVwb9os = value;
		}
	}

	public bool IsStartRowSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wgUHOWClW7;
		}
	}

	public bool IsStartRowEditable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (wgUHOWClW7)
			{
				return StartRowRange[0] != StartRowRange[1];
			}
			return false;
		}
	}

	[JsonProperty(PropertyName = "startRow")]
	public int StartRow
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KViHt3MvQP;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KViHt3MvQP = value;
			wgUHOWClW7 = true;
		}
	}

	[JsonProperty(PropertyName = "startRowRange")]
	public int[] StartRowRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KNvH8BCriW;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KNvH8BCriW = value;
		}
	}

	public bool IsStartColumnSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return oO8HhyaDKj;
		}
	}

	public bool IsStartColumnEditable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (oO8HhyaDKj)
			{
				return StartColumnRange[0] != StartColumnRange[1];
			}
			return false;
		}
	}

	[JsonProperty(PropertyName = "startCol")]
	public int StartColumn
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SYaHDCwRw7;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SYaHDCwRw7 = value;
			oO8HhyaDKj = true;
		}
	}

	[JsonProperty(PropertyName = "startColRange")]
	public int[] StartColumnRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DaJHwrBtBv;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			DaJHwrBtBv = value;
		}
	}

	public bool IsStrobePolaritySupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return o19Hi77b3C;
		}
	}

	[JsonProperty(PropertyName = "strobePolarity")]
	public int StrobePolarity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return sueHuPnk4I;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sueHuPnk4I = value;
		}
	}

	public bool IsStrobeStartSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (iJAHZ2IQ1r && StrobeStartValues != null)
			{
				return StrobeStartValues.Count > 1;
			}
			return false;
		}
	}

	[JsonProperty(PropertyName = "strobeStart")]
	public int StrobeStart
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Sq5Hgk0BE0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Sq5Hgk0BE0 = value;
			iJAHZ2IQ1r = true;
		}
	}

	[JsonProperty(PropertyName = "strobeStartValues")]
	public Dictionary<string, string> StrobeStartValues
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qeqHSEwfJP;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			qeqHSEwfJP = value;
		}
	}

	public bool IsTriggerModeSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return BlGHnG4KZv;
		}
	}

	[JsonProperty(PropertyName = "mode")]
	public int TriggerMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return NL9H1iMOxb;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NL9H1iMOxb = value;
			BlGHnG4KZv = true;
		}
	}

	public bool IsTriggerDebounceSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (YPPHka15PL)
			{
				return TriggerDebounceRange[0] != TriggerDebounceRange[1];
			}
			return false;
		}
	}

	[JsonProperty(PropertyName = "triggerDebounce")]
	public double TriggerDebounce
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return E1VHE2Zh8G;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			E1VHE2Zh8G = value;
			YPPHka15PL = true;
		}
	}

	[JsonProperty(PropertyName = "triggerDebounceRange")]
	public double[] TriggerDebounceRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CKSHstsiOm;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CKSHstsiOm = value;
		}
	}

	public bool IsIlluminationSettingsSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return lTyH0ET8JL;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			lTyH0ET8JL = value;
		}
	}

	[JsonProperty(PropertyName = "illumination")]
	public CvsCogIlluminationSettings Illumination
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XIgHG1Pf1o;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			XIgHG1Pf1o = value;
			IsIlluminationSettingsSupported = true;
		}
	}

	public bool IsFocusSettingsSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return cGgH7vtKiF;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cGgH7vtKiF = value;
		}
	}

	[JsonProperty(PropertyName = "focus")]
	public CvsCogFocusSettings Focus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ngbHWMsvQ7;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ngbHWMsvQ7 = value;
			IsFocusSettingsSupported = true;
		}
	}

	public bool IsHdrModeSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (umbHoVYy4C && HdrModeValues != null)
			{
				return Gj9cfxbj9BjlIfmkFZ(HdrModeValues) > 1;
			}
			return false;
		}
	}

	[JsonProperty(PropertyName = "hdrMode")]
	public int HdrMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GJgHPo892O;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			GJgHPo892O = value;
			umbHoVYy4C = true;
		}
	}

	[JsonProperty(PropertyName = "hdrModeValues")]
	public Dictionary<string, string> HdrModeValues
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FDkHjOFlPD;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			FDkHjOFlPD = value;
		}
	}

	public bool IsHdrKernelSizeSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (NvvHckRAkp && HdrKernelSizeValues != null)
			{
				return Gj9cfxbj9BjlIfmkFZ(HdrKernelSizeValues) > 1;
			}
			return false;
		}
	}

	[JsonProperty(PropertyName = "hdrKernelSize")]
	public int HdrKernelSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return eW8HdRcBf8;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			eW8HdRcBf8 = value;
			NvvHckRAkp = true;
		}
	}

	[JsonProperty(PropertyName = "hdrKernelSizeValues")]
	public Dictionary<string, string> HdrKernelSizeValues
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kdlHTPJLwy;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kdlHTPJLwy = value;
		}
	}

	public bool IsWhiteBalanceSettingsSupported
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qYMHv6vDKr;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			qYMHv6vDKr = value;
		}
	}

	[JsonProperty(PropertyName = "whiteBalance")]
	public CvsCogWhiteBalanceSettings WhiteBalance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return dRVHz8XXbd;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dRVHz8XXbd = value;
			IsWhiteBalanceSettingsSupported = true;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogAcqSettings()
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
			case 15:
				sueHuPnk4I = 1;
				num = 6;
				break;
			case 3:
				Bpte1LgsynyLEcVwnY();
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 2:
				E1VHE2Zh8G = 0.5;
				CKSHstsiOm = new double[2]
				{
					0.0,
					double.MaxValue
				};
				base._002Ector();
				num = 17;
				if (uD9rcsOQwNobbRxbeA())
				{
				}
				break;
			case 16:
				RQdHXsCjiH = new int[2] { 0, 2147483647 };
				num = 13;
				break;
			case 8:
				DaJHwrBtBv = new int[2] { 0, 2147483647 };
				num = 15;
				break;
			case 13:
				khGHKstRjF = new int[2] { 0, 2147483647 };
				num = 11;
				break;
			case 7:
				KNvH8BCriW = new int[2] { 0, 2147483647 };
				num = 8;
				break;
			case 9:
			case 14:
				Q09H3QrSAB = new int[2] { 0, 2147483647 };
				num = 7;
				if (!uD9rcsOQwNobbRxbeA())
				{
					break;
				}
				goto case 0;
			case 0:
				uCKHpUh670 = 128;
				goto case 9;
			case 10:
				do
				{
					xFlHQvHGC4 = new double[2]
					{
						0.0,
						double.MaxValue
					};
					DBKHfE9dYj = new int[2] { 0, 2147483647 };
					_ = 1;
					if (uD9rcsOQwNobbRxbeA())
					{
						num = 14;
						continue;
					}
					num = 1;
					break;
				}
				while (1 == 0);
				break;
			case 5:
				MfUHMIT8oo = new int[2] { 0, 2147483647 };
				num = 12;
				if (GLvTeXljdC5HsihO3t())
				{
					break;
				}
				goto case 1;
			case 1:
			case 4:
				oQwH2oUZed = 3;
				num = 16;
				break;
			case 12:
				YKFHr2CKTW = 8.0;
				num = 10;
				if (0 == 0)
				{
					break;
				}
				goto case 11;
			case 11:
				CU7HxfWn9K = new int[2] { 0, 2147483647 };
				goto case 0;
			default:
				num = 0;
				break;
			case 6:
				NL9H1iMOxb = 3;
				num = 2;
				break;
			case 17:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GLvTeXljdC5HsihO3t()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uD9rcsOQwNobbRxbeA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Gj9cfxbj9BjlIfmkFZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Dictionary<string, string>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Bpte1LgsynyLEcVwnY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}
}
