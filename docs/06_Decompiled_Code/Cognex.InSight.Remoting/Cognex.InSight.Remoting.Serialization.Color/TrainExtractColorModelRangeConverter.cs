using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization.Color;

public class TrainExtractColorModelRangeConverter : JsonConverter
{
	public override bool CanRead
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}
	}

	public override bool CanWrite
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (aoxSKlZftF1gfnbQW88())
		{
			num = 3;
		}
		else
		{
			num = 4;
			if (!aoxSKlZftF1gfnbQW88())
			{
				return;
			}
		}
		TrainExtractColorValueRange trainExtractColorValueRange = default;
		float[] array = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				trainExtractColorValueRange = (TrainExtractColorValueRange)value;
				num = 1;
				continue;
			case 1:
				array = new float[2]
				{
					trainExtractColorValueRange.MinimumValue,
					BZMn6dZrjMPa2RemWSh(trainExtractColorValueRange)
				};
				break;
			case 5:
				return;
			}
			jWKxcTZVPiaurhXt5qo(writer, array);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new TrainExtractColorValueRange(serializer.Deserialize<float[]>(reader));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanConvert(Type objectType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return qX2Dw7ZElI20gs1gEYj(objectType, EbS0qgZRpZ0Md3YZ2g7(typeof(float[]).TypeHandle));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TrainExtractColorModelRangeConverter()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		mvKg4uZxf0ACTOl0BXk();
		e07Z7aZpcbXkiFQNY7e(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float BZMn6dZrjMPa2RemWSh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((TrainExtractColorValueRange)P_0).MaximumValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jWKxcTZVPiaurhXt5qo(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((JsonWriter)P_0).WriteValue(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool aoxSKlZftF1gfnbQW88()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Xy7vA7ZUmll8qfBEbMR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type EbS0qgZRpZ0Md3YZ2g7(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qX2Dw7ZElI20gs1gEYj(Type P_0, Type P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mvKg4uZxf0ACTOl0BXk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void e07Z7aZpcbXkiFQNY7e(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((JsonConverter)P_0)._002Ector();
	}
}
