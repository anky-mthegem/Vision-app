using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using IawbpyxeWauKVJvQ4t;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using yFqFqrNb1tZ9uvfT9p;

namespace Cognex.Remoting.CogSocket;

public class JsonRemoteSerializer : IRemoteSerializer
{
	private class CSU5wEfk8bgOUit5Pe : JsonConverter
	{
		public static readonly CSU5wEfk8bgOUit5Pe bvriSwS0t8;

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
				return false;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool CanConvert(Type P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0 == gv43x6ZmNIII7wFKmdb(typeof(object).TypeHandle);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object ReadJson(JsonReader P_0, Type P_1, object P_2, JsonSerializer P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (VFe9rfZpTEbx5rNSlDQ(P_0) == JsonToken.StartArray)
			{
				return P_3.Deserialize<object[]>(P_0);
			}
			return xlpI1BZ4BOIf9w08M1M(P_3, P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteJson(JsonWriter P_0, object P_1, JsonSerializer P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			throw new NotImplementedException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CSU5wEfk8bgOUit5Pe()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			O9a3VcZDTmvl6XB5SiN();
			VPLxHEZRP3IVoe2nP8Y(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static CSU5wEfk8bgOUit5Pe()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KrZlKcDAYPHDJxwaTS.pqONvOmz6x5Sx();
			bvriSwS0t8 = new CSU5wEfk8bgOUit5Pe();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Type gv43x6ZmNIII7wFKmdb(RuntimeTypeHandle P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Type.GetTypeFromHandle(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oLueToRgucH1RdxDNjP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool z1cUlIRzriESauXiRKW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JsonToken VFe9rfZpTEbx5rNSlDQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((JsonReader)P_0).TokenType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xlpI1BZ4BOIf9w08M1M(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((JsonSerializer)P_0).Deserialize((JsonReader)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void O9a3VcZDTmvl6XB5SiN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KrZlKcDAYPHDJxwaTS.pqONvOmz6x5Sx();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void VPLxHEZRP3IVoe2nP8Y(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((JsonConverter)P_0)._002Ector();
		}
	}

	public class DictionaryConverter : JsonConverter
	{
		public static readonly DictionaryConverter Instance;

		public override bool CanRead
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
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
		public override bool CanConvert(Type objectType)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return lWXFSJZnaqsu4SU5wbN(objectType, typeof(Dictionary<string, object>));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			throw new NotImplementedException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			Dictionary<string, object>.KeyCollection.Enumerator enumerator = default;
			Dictionary<string, object> dictionary = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					writer.WriteStartObject();
					goto case 0;
				default:
					num = 0;
					if (true)
					{
						break;
					}
					goto case 0;
				case 0:
					enumerator = dictionary.Keys.GetEnumerator();
					num = 3;
					break;
				case 1:
				case 5:
					if (dictionary != null)
					{
						goto case 2;
					}
					return;
				case 3:
					try
					{
						while (enumerator.MoveNext())
						{
							string current = enumerator.Current;
							_ = 1;
							int num2 = (OH691CZk73fZj90PfSZ() ? 3 : 2);
							while (true)
							{
								switch (num2)
								{
								default:
									serializer.Serialize(writer, dictionary[current]);
									num2 = 4;
									if (true)
									{
										continue;
									}
									goto case 0;
								case 0:
								case 2:
									obPUYDZNKaOHZLAWMTu(writer, current);
									goto default;
								case 4:
									break;
								}
								break;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
					}
					writer.WriteEndObject();
					num = 7;
					if (GCEXkhZZ8UDTgmZH06Q())
					{
						break;
					}
					goto case 6;
				case 6:
					dictionary = value as Dictionary<string, object>;
					_ = 1;
					num = ((!OH691CZk73fZj90PfSZ()) ? 5 : 4);
					break;
				case 7:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DictionaryConverter()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			S02lB9ZU2xPLEkijAo6();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DictionaryConverter()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			S02lB9ZU2xPLEkijAo6();
			Instance = new DictionaryConverter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lWXFSJZnaqsu4SU5wbN(Type P_0, Type P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0 == P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GCEXkhZZ8UDTgmZH06Q()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OH691CZk73fZj90PfSZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void obPUYDZNKaOHZLAWMTu(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((JsonWriter)P_0).WritePropertyName((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void S02lB9ZU2xPLEkijAo6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KrZlKcDAYPHDJxwaTS.pqONvOmz6x5Sx();
		}
	}

	public class ContractResolver : DefaultContractResolver
	{
		public static readonly ContractResolver Instance;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override JsonContract CreateContract(Type objectType)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			FWGhdCZKWfNtN7mkIsq();
			int num;
			if (Pm9O1IZokD90341A7wG())
			{
				num = 2;
			}
			else
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_0090;
				}
			}
			goto IL_004f;
			IL_004f:
			JsonContract jsonContract = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					if (objectType == jCNoT3Zadujmml7E2jT(typeof(Dictionary<string, object>).TypeHandle))
					{
						break;
					}
					goto case 5;
				default:
					goto IL_006c;
				case 0:
				case 2:
					jsonContract = (JsonContract)cfma9qZIi5S1l5v2bAX(this, objectType);
					goto case 1;
				case 3:
					break;
				case 5:
					return jsonContract;
				}
				break;
				IL_006c:
				num = 3;
			}
			goto IL_0090;
			IL_0090:
			jsonContract.Converter = DictionaryConverter.Instance;
			num = 5;
			goto IL_004f;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContractResolver()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KrZlKcDAYPHDJxwaTS.pqONvOmz6x5Sx();
			rFcww6ZeDjpkaFrCDAY(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ContractResolver()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			mJEvbFZXZ5YfEXaQ9cK();
			Instance = new ContractResolver();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cfma9qZIi5S1l5v2bAX(object P_0, Type P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((DefaultContractResolver)P_0).CreateContract(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Type jCNoT3Zadujmml7E2jT(RuntimeTypeHandle P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Type.GetTypeFromHandle(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Pm9O1IZokD90341A7wG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FWGhdCZKWfNtN7mkIsq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void rFcww6ZeDjpkaFrCDAY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((DefaultContractResolver)P_0)._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void mJEvbFZXZ5YfEXaQ9cK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KrZlKcDAYPHDJxwaTS.pqONvOmz6x5Sx();
		}
	}

	[CompilerGenerated]
	private static readonly TypeNameBinder xdOiNuhP0V;

	private readonly JsonSerializerSettings yM2iUM6BhH;

	private JsonSerializer jfEiQ1KoD1;

	[CompilerGenerated]
	private TraceListener FtOibIB2E4;

	public static TypeNameBinder TypeNameBinder
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xdOiNuhP0V;
		}
	}

	public JsonSerializerSettings Settings
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return yM2iUM6BhH;
		}
	}

	public TraceListener TraceListener
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FtOibIB2E4;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			FtOibIB2E4 = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static JsonRemoteSerializer()
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
			case 4:
				xdOiNuhP0V = new TypeNameBinder();
				break;
			case 0:
				BkV6rCD5XmiYwdV9wyL();
				_ = 1;
				num = ((!MyWIsNDrsc1aE0nFdRZ()) ? 4 : 3);
				continue;
			case 5:
				return;
			}
			((TypeNameBinder)qh6LrdDuB83olVEcYLY()).RegisterAssembly(C7wNEqDyg3YgYOBhtLC(typeof(JsonRemoteSerializer).TypeHandle).Assembly);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JsonRemoteSerializer(bool prettyPrintJson = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		BkV6rCD5XmiYwdV9wyL();
		this._002Ector(CreateDefaultJsonSerializerSettings(prettyPrintJson));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JsonRemoteSerializer(JsonSerializerSettings settings)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (MyWIsNDrsc1aE0nFdRZ())
		{
			goto IL_001e;
		}
		goto IL_004d;
		IL_0034:
		yM2iUM6BhH = settings;
		goto IL_0093;
		IL_004d:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			case 2:
			case 3:
				goto IL_0034;
			default:
				num = 5;
				continue;
			case 0:
				goto IL_0078;
			case 5:
				goto IL_0093;
			case 6:
				return;
			}
			break;
			IL_0078:
			BkV6rCD5XmiYwdV9wyL();
			_ = 0;
			num = (IXDqUEDsJXsbVjMqSM0() ? 4 : 3);
		}
		goto IL_001e;
		IL_0093:
		jfEiQ1KoD1 = (JsonSerializer)shIUwnD0QjL8F2UdHPq(yM2iUM6BhH);
		num = 6;
		goto IL_004d;
		IL_001e:
		base._002Ector();
		goto IL_0034;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static JsonSerializerSettings CreateDefaultJsonSerializerSettings(bool prettyPrintJson = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IXDqUEDsJXsbVjMqSM0();
		int num;
		if (!MyWIsNDrsc1aE0nFdRZ())
		{
			num = 7;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 6;
			if (MyWIsNDrsc1aE0nFdRZ())
			{
			}
		}
		goto IL_0093;
		IL_002a:
		JsonSerializerSettings jsonSerializerSettings = default;
		mYxEqGDjHjrkebAk1SW(jsonSerializerSettings, ContractResolver.Instance);
		num = 2;
		goto IL_0093;
		IL_0093:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 5:
				jsonSerializerSettings.TypeNameHandling = TypeNameHandling.Objects;
				num = 8;
				continue;
			case 0:
			case 7:
				jsonSerializerSettings = new JsonSerializerSettings();
				num = 5;
				continue;
			case 4:
				QkND5lDbLspATmP04Ud(jsonSerializerSettings, Formatting.Indented);
				num = 9;
				continue;
			case 3:
			case 6:
				jsonSerializerSettings.Converters.Add(CSU5wEfk8bgOUit5Pe.bvriSwS0t8);
				break;
			default:
				num = 1;
				if (MyWIsNDrsc1aE0nFdRZ())
				{
				}
				continue;
			case 8:
				jsonSerializerSettings.Binder = (SerializationBinder?)qh6LrdDuB83olVEcYLY();
				goto case 3;
			case 2:
				if (prettyPrintJson)
				{
					num = 4;
					continue;
				}
				goto case 9;
			case 9:
				return jsonSerializerSettings;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object DeserializeObject(string json)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IXDqUEDsJXsbVjMqSM0();
		int num;
		if (!MyWIsNDrsc1aE0nFdRZ())
		{
			num = 3;
			if (!IXDqUEDsJXsbVjMqSM0())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 2;
			if (false)
			{
				goto IL_00cb;
			}
		}
		goto IL_004b;
		IL_0072:
		object obj = default;
		LpULkUDdISrxxspsu2p(TraceListener, string.Format((string)RP86FTDLFe9ZDVKHv03(1410), json, Gcgw2TDqVTE52ayxeuC(obj.GetType()), IcIQ43DM54KTseyUQgY()));
		num = 5;
		goto IL_004b;
		IL_00cb:
		return obj;
		IL_002e:
		if (TraceListener != null)
		{
			goto IL_0072;
		}
		goto IL_00cb;
		IL_004b:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				break;
			default:
				num = 4;
				continue;
			case 4:
				goto IL_0072;
			case 0:
			case 3:
				obj = iYS94aDAYbThJOBW2VN(json, yM2iUM6BhH);
				break;
			case 5:
				goto IL_00cb;
			}
			break;
		}
		goto IL_002e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public T Deserialize<T>(string json)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		T result = JsonConvert.DeserializeObject<T>(json, yM2iUM6BhH);
		if (TraceListener != null)
		{
			TraceListener.WriteLine(string.Format(UNkfE94JEjYP98PsqC.cGFu3AUnFy(1410), json, result.GetType().Name, Environment.TickCount));
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object DeserializeFromJToken(JToken token)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		string text = default;
		object obj = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				if (TraceListener != null)
				{
					num = 4;
					continue;
				}
				break;
			case 4:
				text = (string)fEM9gbDGHaNlgGONJw8(token);
				goto default;
			default:
				LpULkUDdISrxxspsu2p(TraceListener, vJ7KNWDC9BGnveC10oo(RP86FTDLFe9ZDVKHv03(1410), text, obj.GetType().Name, Environment.TickCount));
				num = 6;
				if (IXDqUEDsJXsbVjMqSM0())
				{
					continue;
				}
				goto case 2;
			case 2:
				obj = token.ToObject<object>(jfEiQ1KoD1);
				IXDqUEDsJXsbVjMqSM0();
				if (MyWIsNDrsc1aE0nFdRZ())
				{
					num = 0;
					if (!MyWIsNDrsc1aE0nFdRZ())
					{
						continue;
					}
					goto default;
				}
				num = 5;
				continue;
			case 6:
				break;
			}
			break;
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string SerializeObject(object obj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MyWIsNDrsc1aE0nFdRZ();
		int num;
		if (IXDqUEDsJXsbVjMqSM0())
		{
			num = 3;
			if (MyWIsNDrsc1aE0nFdRZ())
			{
			}
		}
		else
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_008b;
			}
		}
		goto IL_00a8;
		IL_00d9:
		string text = default;
		return text;
		IL_0032:
		LpULkUDdISrxxspsu2p(TraceListener, vJ7KNWDC9BGnveC10oo(UNkfE94JEjYP98PsqC.cGFu3AUnFy(1464), Gcgw2TDqVTE52ayxeuC(obj.GetType()), text, IcIQ43DM54KTseyUQgY()));
		num = 5;
		goto IL_00a8;
		IL_00a8:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 0:
			case 3:
				text = (string)ajJ3cWDHCKRWqtvLSCQ(obj, yM2iUM6BhH);
				goto IL_008b;
			case 1:
			case 4:
				goto IL_008b;
			default:
				num = 2;
				if (MyWIsNDrsc1aE0nFdRZ())
				{
				}
				continue;
			case 5:
				goto IL_00d9;
			}
			break;
		}
		goto IL_0032;
		IL_008b:
		if (TraceListener != null)
		{
			goto IL_0032;
		}
		goto IL_00d9;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string Serialize(object value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SerializeObject(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JToken SerializeToJToken(object value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (JToken)KvW2SUDVWXbaYd8qLgN(value, jfEiQ1KoD1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BkV6rCD5XmiYwdV9wyL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KrZlKcDAYPHDJxwaTS.pqONvOmz6x5Sx();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qh6LrdDuB83olVEcYLY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return TypeNameBinder;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type C7wNEqDyg3YgYOBhtLC(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IXDqUEDsJXsbVjMqSM0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MyWIsNDrsc1aE0nFdRZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object shIUwnD0QjL8F2UdHPq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return JsonSerializer.Create((JsonSerializerSettings?)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mYxEqGDjHjrkebAk1SW(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((JsonSerializerSettings)P_0).ContractResolver = (IContractResolver?)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QkND5lDbLspATmP04Ud(object P_0, Formatting P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((JsonSerializerSettings)P_0).Formatting = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iYS94aDAYbThJOBW2VN(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return JsonConvert.DeserializeObject((string)P_0, (JsonSerializerSettings)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RP86FTDLFe9ZDVKHv03(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return UNkfE94JEjYP98PsqC.cGFu3AUnFy(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Gcgw2TDqVTE52ayxeuC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MemberInfo)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int IcIQ43DM54KTseyUQgY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Environment.TickCount;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LpULkUDdISrxxspsu2p(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((TraceListener)P_0).WriteLine((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fEM9gbDGHaNlgGONJw8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return JsonConvert.SerializeObject(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vJ7KNWDC9BGnveC10oo(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ajJ3cWDHCKRWqtvLSCQ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return JsonConvert.SerializeObject(P_0, (JsonSerializerSettings?)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KvW2SUDVWXbaYd8qLgN(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return JToken.FromObject(P_0, (JsonSerializer)P_1);
	}
}
