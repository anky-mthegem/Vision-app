using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization.Color;

[CvsSerializable("TrainExtractColorTool")]
public class TrainExtractColorLibrary
{
	[CompilerGenerated]
	private string qePmojkN17;

	[CompilerGenerated]
	private TrainExtractColorLibraryModelType o1KmPkfy6L;

	[CompilerGenerated]
	private IDictionary<string, TrainExtractColorGroup> H22mjpD20y;

	[JsonProperty("libraryName")]
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
			return qePmojkN17;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			qePmojkN17 = value;
		}
	}

	[JsonProperty("modelType")]
	public TrainExtractColorLibraryModelType ModelType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return o1KmPkfy6L;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			o1KmPkfy6L = value;
		}
	}

	[JsonProperty("groups")]
	private IDictionary<string, TrainExtractColorGroup> JU1mWJpMKu
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return H22mjpD20y;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			H22mjpD20y = value;
		}
	}

	[JsonIgnore]
	public TrainExtractColorGroup[] Groups
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (JU1mWJpMKu == null)
			{
				return new TrainExtractColorGroup[0];
			}
			return JU1mWJpMKu.Values.ToArray();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TrainExtractColorLibrary()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IwwOhYZqugLCFD52xRd();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool b5Sf3yZIcGptUK6BGQg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Ci22ZBZc3RDlNJ5t9gN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IwwOhYZqugLCFD52xRd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}
}
