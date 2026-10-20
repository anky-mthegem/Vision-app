using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization.Color;

[CvsSerializable("TrainExtractColorGroup")]
public class TrainExtractColorGroup
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<TrainExtractColorModel, int> _003C_003E9__13_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zt31UgtoLW09RgS3TTM();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zt31UgtoLW09RgS3TTM();
			XPvixgtFLPU06QRvdkG(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int _003Cget_Colors_003Eb__13_0(TrainExtractColorModel clr)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return UFW3dptGAkryBXhQNPi(clr);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void zt31UgtoLW09RgS3TTM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Iwulvqt535QtZ5riKv2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OsQpANtTqZ2FK1D5OUT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void XPvixgtFLPU06QRvdkG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int UFW3dptGAkryBXhQNPi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((TrainExtractColorModel)P_0).SortOrder;
		}
	}

	[CompilerGenerated]
	private int etNmkVrALo;

	[CompilerGenerated]
	private string gG8mE3gik8;

	[CompilerGenerated]
	private IDictionary<string, TrainExtractColorModel> EXWmsyAu3D;

	[JsonProperty("id")]
	public int Id
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return etNmkVrALo;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			etNmkVrALo = value;
		}
	}

	[JsonProperty("name")]
	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return gG8mE3gik8;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			gG8mE3gik8 = value;
		}
	}

	[JsonProperty("colors")]
	public IDictionary<string, TrainExtractColorModel> ColorsDictionary
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EXWmsyAu3D;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EXWmsyAu3D = value;
		}
	}

	[JsonIgnore]
	public TrainExtractColorModel[] Colors
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (ColorsDictionary == null)
			{
				return Array.Empty<TrainExtractColorModel>();
			}
			return ColorsDictionary.Values.OrderBy([MethodImpl(MethodImplOptions.NoInlining)] (TrainExtractColorModel clr) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003Ec.UFW3dptGAkryBXhQNPi(clr);
			}).ToArray();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TrainExtractColorGroup()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		tLtYJ1ZP4BSsfARogsS();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fDanhjZskX3KyGpLl94()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tIuMmbZwUSJgSkF5An7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tLtYJ1ZP4BSsfARogsS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}
}
