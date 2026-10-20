using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Properties;
using Newtonsoft.Json.Linq;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "settings")]
public class CvsCogAcqSettingsContainer : TypedPropertyBag
{
	public const string AutofocusID = "Autofocus";

	public const string TriggerModeTag = "TriggerMode";

	public const string TriggerIntervalTag = "TriggerInterval";

	public const string IlluminationIntensityTag = "IlluminationIntensity";

	public const string IlluminationBanksEnabledTag = "IlluminationBankEnables";

	public const string IlluminationModeTag = "IlluminationMode";

	public const string FocusPositionTag = "FocusPosition";

	public const string AutofocusTag = "Autofocus";

	public const string FocusRegionTag = "FocusRegion";

	public const string WhiteBalanceRegionTag = "WhiteBalanceRegion";

	public const string AutoWhiteBalanceTag = "AutoWhiteBalance";

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogAcqSettings AsSettings()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ConvertToInstance<CvsCogAcqSettings>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<UntypedDescribedProperty> GetDescribedProperties()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCogAcqSettingsContainer cvsCogAcqSettingsContainer = this;
		List<UntypedDescribedProperty> properties = new List<UntypedDescribedProperty>();
		lAqUbnO80K(kgbOBx7BanbFa22Hp9.ol99ukmDA(0), kgbOBx7BanbFa22Hp9.ol99ukmDA(0), UntypedDescribedProperty.EditType.TriggerMode, Resources.TriggerModeName, Resources.TriggerModeDescription, _0020: true, null, _0020: false);
		lAqUbnO80K(kgbOBx7BanbFa22Hp9.ol99ukmDA(26), kgbOBx7BanbFa22Hp9.ol99ukmDA(26), UntypedDescribedProperty.EditType.TriggerInterval, Resources.TriggerInterval, Resources.TriggerIntervalDescription, _0020: true, null, _0020: false);
		lAqUbnO80K(kgbOBx7BanbFa22Hp9.ol99ukmDA(60), kgbOBx7BanbFa22Hp9.ol99ukmDA(94), UntypedDescribedProperty.EditType.Double, Resources.TriggerDebounceName, Resources.TriggerDebounceDescription, _0020: true, null, _0020: false);
		lAqUbnO80K(kgbOBx7BanbFa22Hp9.ol99ukmDA(128), kgbOBx7BanbFa22Hp9.ol99ukmDA(142), UntypedDescribedProperty.EditType.Long, Resources.DelayName, Resources.DelayDescription, _0020: true, null, _0020: false);
		lAqUbnO80K(kgbOBx7BanbFa22Hp9.ol99ukmDA(156), kgbOBx7BanbFa22Hp9.ol99ukmDA(176), UntypedDescribedProperty.EditType.Double, Resources.ExposureName, Resources.ExposureDescription, _0020: true, null, _0020: false);
		lAqUbnO80K(kgbOBx7BanbFa22Hp9.ol99ukmDA(196), kgbOBx7BanbFa22Hp9.ol99ukmDA(212), UntypedDescribedProperty.EditType.Long, Resources.OffsetName, Resources.OffsetDescription, _0020: true, null, _0020: false);
		lAqUbnO80K(kgbOBx7BanbFa22Hp9.ol99ukmDA(228), kgbOBx7BanbFa22Hp9.ol99ukmDA(240), UntypedDescribedProperty.EditType.Long, Resources.GainName, Resources.GainDescription, _0020: true, null, _0020: false);
		lAqUbnO80K(kgbOBx7BanbFa22Hp9.ol99ukmDA(252), kgbOBx7BanbFa22Hp9.ol99ukmDA(278), UntypedDescribedProperty.EditType.Enum, Resources.OrientationName, Resources.OrientationDescription, _0020: true, null, _0020: false);
		lAqUbnO80K(kgbOBx7BanbFa22Hp9.ol99ukmDA(304), kgbOBx7BanbFa22Hp9.ol99ukmDA(324), UntypedDescribedProperty.EditType.Long, Resources.StartRowName, Resources.StartRowDescription, _0020: true, null, _0020: false);
		lAqUbnO80K(kgbOBx7BanbFa22Hp9.ol99ukmDA(344), kgbOBx7BanbFa22Hp9.ol99ukmDA(362), UntypedDescribedProperty.EditType.Long, Resources.NumberOfRowsName, Resources.NumberOfRowsDescription, _0020: true, null, _0020: false);
		lAqUbnO80K(kgbOBx7BanbFa22Hp9.ol99ukmDA(390), kgbOBx7BanbFa22Hp9.ol99ukmDA(418), UntypedDescribedProperty.EditType.Long, Resources.NumberOfBuffersName, Resources.NumberOfBuffersDescription, _0020: false, null, _0020: false);
		lAqUbnO80K(kgbOBx7BanbFa22Hp9.ol99ukmDA(452), kgbOBx7BanbFa22Hp9.ol99ukmDA(490), UntypedDescribedProperty.EditType.Enum, Resources.IlluminationMode, Resources.IlluminationModeDescription, _0020: true, new ArgumentGroupDescriptor
		{
			Title = Resources.IlluminationGroupTitle,
			DisplayTitle = Resources.IlluminationGroupDisplayTitle,
			Description = Resources.IlluminationGroupHelp
		}, _0020: false);
		lAqUbnO80K(kgbOBx7BanbFa22Hp9.ol99ukmDA(526), kgbOBx7BanbFa22Hp9.ol99ukmDA(574), UntypedDescribedProperty.EditType.Long, Resources.IlluminationIntensity, Resources.IlluminationIntensityDescription, _0020: true, null, _0020: false);
		lAqUbnO80K(kgbOBx7BanbFa22Hp9.ol99ukmDA(620), kgbOBx7BanbFa22Hp9.ol99ukmDA(646), UntypedDescribedProperty.EditType.Enum, Resources.StrobeStartName, Resources.StrobeStartDescription, _0020: true, null, _0020: false);
		lAqUbnO80K(kgbOBx7BanbFa22Hp9.ol99ukmDA(672), kgbOBx7BanbFa22Hp9.ol99ukmDA(704), UntypedDescribedProperty.EditType.Enum, Resources.StrobePolarityName, Resources.StrobePolarityDescription, _0020: true, null, _0020: false);
		lAqUbnO80K(kgbOBx7BanbFa22Hp9.ol99ukmDA(736), kgbOBx7BanbFa22Hp9.ol99ukmDA(788), UntypedDescribedProperty.EditType.BanksEnabled, Resources.IlluminationBanksEnabled, Resources.IlluminationBanksEnabledDescription, _0020: true, null, _0020: true);
		lAqUbnO80K(kgbOBx7BanbFa22Hp9.ol99ukmDA(838), kgbOBx7BanbFa22Hp9.ol99ukmDA(870), UntypedDescribedProperty.EditType.Double, Resources.FocusPosition, Resources.FocusPositionDescription, _0020: true, new ArgumentGroupDescriptor
		{
			Title = Resources.FocusGroupTitle,
			DisplayTitle = Resources.FocusGroupDisplayTitle,
			Description = kgbOBx7BanbFa22Hp9.ol99ukmDA(900)
		}, _0020: false);
		lAqUbnO80K(kgbOBx7BanbFa22Hp9.ol99ukmDA(924), kgbOBx7BanbFa22Hp9.ol99ukmDA(952), UntypedDescribedProperty.EditType.FocusRegion, Resources.FocusRegion, Resources.FocusRegionDescription, _0020: true, null, _0020: false);
		lAqUbnO80K(kgbOBx7BanbFa22Hp9.ol99ukmDA(978), kgbOBx7BanbFa22Hp9.ol99ukmDA(978), UntypedDescribedProperty.EditType.Autofocus, Resources.Autofocus, Resources.AutofocusDescription, _0020: true, null, _0020: true);
		lAqUbnO80K(kgbOBx7BanbFa22Hp9.ol99ukmDA(1000), kgbOBx7BanbFa22Hp9.ol99ukmDA(1018), UntypedDescribedProperty.EditType.Enum, Resources.HdrMode, Resources.HdrModeDescription, _0020: true, new ArgumentGroupDescriptor
		{
			Title = Resources.HdrGroupTitle,
			DisplayTitle = Resources.HdrGroupDisplayTitle,
			Description = Resources.HdrGroupHelp
		}, _0020: false);
		lAqUbnO80K(kgbOBx7BanbFa22Hp9.ol99ukmDA(1036), kgbOBx7BanbFa22Hp9.ol99ukmDA(1066), UntypedDescribedProperty.EditType.Enum, Resources.HdrKernelSizeName, Resources.HdrKernelSizeDescription, _0020: true, null, _0020: true);
		lAqUbnO80K(kgbOBx7BanbFa22Hp9.ol99ukmDA(1096), kgbOBx7BanbFa22Hp9.ol99ukmDA(1138), UntypedDescribedProperty.EditType.WhiteBalanceRegion, Resources.WhiteBalanceRegionName, Resources.WhiteBalanceRegionDescription, _0020: true, new ArgumentGroupDescriptor
		{
			Title = Resources.WhiteBalanceGroupTitle,
			DisplayTitle = Resources.WhiteBalanceGroupDisplayTitle,
			Description = Resources.WhiteBalanceGroupHelp
		}, _0020: false);
		lAqUbnO80K(kgbOBx7BanbFa22Hp9.ol99ukmDA(1178), kgbOBx7BanbFa22Hp9.ol99ukmDA(1178), UntypedDescribedProperty.EditType.AutoWhiteBalance, Resources.SetWhiteBalance, Resources.SetWhiteBalanceDescription, _0020: true, null, _0020: true);
		return properties;
		[MethodImpl(MethodImplOptions.NoInlining)]
		void lAqUbnO80K(string P_0, string P_1, UntypedDescribedProperty.EditType P_2, string P_3, string P_4, bool P_5, ArgumentGroupDescriptor P_6, bool P_7)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sr3fnjNa9rxTK1riae();
			int num = (eRLyLC9pUBQCKOMG2k() ? 3 : 2);
			UntypedDescribedProperty untypedDescribedProperty = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					properties.Add(untypedDescribedProperty);
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
				case 3:
					if (!zptUlMKTGx(untypedDescribedProperty))
					{
						return;
					}
					goto case 4;
				default:
					num = 4;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				case 0:
				case 2:
					untypedDescribedProperty = bHgUAhsVY8(P_0, P_3, P_4, P_2, P_1, P_5, P_6, P_7);
					goto case 1;
				case 5:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private UntypedDescribedProperty bHgUAhsVY8(string P_0, string P_1, string P_2, UntypedDescribedProperty.EditType P_3, string P_4, bool P_5, ArgumentGroupDescriptor P_6, bool P_7)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 31;
		JToken value11 = default;
		double[] array5 = default;
		JToken value6 = default;
		JObject jObject4 = default;
		string text4 = default;
		JObject jObject3 = default;
		double[] array2 = default;
		JToken value3 = default;
		CvsCogRegion bounds = default;
		JObject jObject = default;
		string text = default;
		Dictionary<int, string> dictionary4 = default;
		JToken value = default;
		Dictionary<int, string> dictionary2 = default;
		string text3 = default;
		JToken value4 = default;
		Dictionary<int, string> dictionary3 = default;
		JObject jObject2 = default;
		string text2 = default;
		JToken value8 = default;
		double[] array3 = default;
		CvsCogRegion cvsCogRegion4 = default;
		JToken value5 = default;
		Dictionary<int, string> dictionary = default;
		JToken value7 = default;
		CvsCogRegion cvsCogRegion3 = default;
		double[] array = default;
		CvsCogRegion cvsCogRegion2 = default;
		double[] array4 = default;
		CvsCogRegion cvsCogRegion = default;
		while (true)
		{
			UntypedDescribedProperty untypedDescribedProperty7;
			switch (num)
			{
			case 31:
				if (P_0 == (string)A0gsGZBPIjWiChe5hB(0))
				{
					num = 9;
					continue;
				}
				if (gYPaWDvE5iUpVIJZy2(P_0, A0gsGZBPIjWiChe5hB(26)))
				{
					UntypedDescribedProperty untypedDescribedProperty4 = new UntypedDescribedProperty();
					rBmDKr0Po9ELclMdXN(untypedDescribedProperty4, P_3);
					untypedDescribedProperty4.PropertyName = P_0;
					WgU6kv1lSjpDhhZEus(untypedDescribedProperty4, 500);
					s2HH4BJulQDxeD6gqy(untypedDescribedProperty4, P_1);
					untypedDescribedProperty4.TagName = P_4;
					ITxgty8e4UZpJi855g(untypedDescribedProperty4, P_2);
					Bv3nO1j2La6KldnAdK(untypedDescribedProperty4, P_5);
					untypedDescribedProperty4.Maximum = 2147483647.0;
					untypedDescribedProperty4.Minimum = 10.0;
					untypedDescribedProperty4.LastProperty = P_7;
					return untypedDescribedProperty4;
				}
				if (!gYPaWDvE5iUpVIJZy2(P_0, A0gsGZBPIjWiChe5hB(978)))
				{
					if (P_0 == kgbOBx7BanbFa22Hp9.ol99ukmDA(924))
					{
						num = 43;
						if (true)
						{
							continue;
						}
						goto case 14;
					}
					if (!P_0.StartsWith((string)A0gsGZBPIjWiChe5hB(1308)))
					{
						if (gYPaWDvE5iUpVIJZy2(P_0, A0gsGZBPIjWiChe5hB(1178)))
						{
							if (PropertyBag.TryGetValue(kgbOBx7BanbFa22Hp9.ol99ukmDA(1336), out JToken _))
							{
								UntypedDescribedProperty untypedDescribedProperty5 = new UntypedDescribedProperty();
								rBmDKr0Po9ELclMdXN(untypedDescribedProperty5, P_3);
								sggdgaANd6Y9xpeGhH(untypedDescribedProperty5, P_0);
								WgU6kv1lSjpDhhZEus(untypedDescribedProperty5, 0);
								untypedDescribedProperty5.Name = P_1;
								HQXAFbekxqn1wMuNCt(untypedDescribedProperty5, P_4);
								ITxgty8e4UZpJi855g(untypedDescribedProperty5, P_2);
								Bv3nO1j2La6KldnAdK(untypedDescribedProperty5, false);
								untypedDescribedProperty5.Maximum = 1.0;
								untypedDescribedProperty5.Minimum = 0.0;
								untypedDescribedProperty5.LastProperty = P_7;
								return untypedDescribedProperty5;
							}
							num = 47;
						}
						else if (!CQRWJkW4t82s9Lqkeqd(P_0, A0gsGZBPIjWiChe5hB(1336)))
						{
							if (!CQRWJkW4t82s9Lqkeqd(P_0, A0gsGZBPIjWiChe5hB(1214)))
							{
								if (!PropertyBag.TryGetValue(P_0, out value11))
								{
									num = 40;
									continue;
								}
								array5 = FJIUeJZtp0<double[]>(P_0 + kgbOBx7BanbFa22Hp9.ol99ukmDA(1262), null);
								num = 27;
							}
							else if (PropertyBag.TryGetValue((string)A0gsGZBPIjWiChe5hB(1214), out value6))
							{
								jObject4 = value6 as JObject;
								if (jObject4 == null)
								{
									num = 34;
									continue;
								}
								text4 = (string)yg5rmtWQ8NoR034HwSd(P_0, GbGVO9z9QZ3Kw0y7LK(A0gsGZBPIjWiChe5hB(1214)) + 1);
								num = 36;
							}
							else
							{
								num = 32;
							}
						}
						else
						{
							num = 23;
						}
						continue;
					}
					if (PropertyBag.TryGetValue((string)A0gsGZBPIjWiChe5hB(1308), out JToken value12))
					{
						jObject3 = value12 as JObject;
						num = 38;
						if (0 == 0)
						{
							continue;
						}
						goto case 28;
					}
					num = 17;
					continue;
				}
				num = 28;
				continue;
			case 16:
				return null;
			case 25:
			{
				UntypedDescribedProperty untypedDescribedProperty = new UntypedDescribedProperty
				{
					Type = P_3
				};
				sggdgaANd6Y9xpeGhH(untypedDescribedProperty, P_0);
				untypedDescribedProperty.Minimum = ((array2 != null) ? new double?(array2[0]) : ((double?)null));
				untypedDescribedProperty.Maximum = ((array2 != null) ? new double?(array2[1]) : ((double?)null));
				WgU6kv1lSjpDhhZEus(untypedDescribedProperty, cFIUUTNxDF(value3, P_3));
				untypedDescribedProperty.Bounds = bounds;
				s2HH4BJulQDxeD6gqy(untypedDescribedProperty, P_1);
				HQXAFbekxqn1wMuNCt(untypedDescribedProperty, P_4);
				ITxgty8e4UZpJi855g(untypedDescribedProperty, P_2);
				Bv3nO1j2La6KldnAdK(untypedDescribedProperty, P_5);
				t9AGkdW6Hb4x278qwgl(untypedDescribedProperty, P_6);
				untypedDescribedProperty.LastProperty = P_7;
				return untypedDescribedProperty;
			}
			case 17:
				return null;
			case 28:
			{
				if (!PropertyBag.TryGetValue((string)A0gsGZBPIjWiChe5hB(1214), out JToken _))
				{
					return null;
				}
				UntypedDescribedProperty untypedDescribedProperty3 = new UntypedDescribedProperty();
				rBmDKr0Po9ELclMdXN(untypedDescribedProperty3, P_3);
				sggdgaANd6Y9xpeGhH(untypedDescribedProperty3, P_0);
				CogSocketActionPath cogSocketActionPath = new CogSocketActionPath();
				dqNNfn3hIufQyyxCdU(cogSocketActionPath, kgbOBx7BanbFa22Hp9.ol99ukmDA(1228));
				WgU6kv1lSjpDhhZEus(untypedDescribedProperty3, cogSocketActionPath);
				untypedDescribedProperty3.Name = P_1;
				HQXAFbekxqn1wMuNCt(untypedDescribedProperty3, P_4);
				ITxgty8e4UZpJi855g(untypedDescribedProperty3, P_2);
				untypedDescribedProperty3.ShouldAlwaysUpdate = false;
				untypedDescribedProperty3.Maximum = 1.0;
				untypedDescribedProperty3.Minimum = 0.0;
				HGWTAvmgS9AUUS7T3j(untypedDescribedProperty3, P_7);
				return untypedDescribedProperty3;
			}
			case 14:
				if (jObject == null)
				{
					return null;
				}
				text = (string)yg5rmtWQ8NoR034HwSd(P_0, GbGVO9z9QZ3Kw0y7LK(A0gsGZBPIjWiChe5hB(1214)) + 1);
				num = 4;
				if (sr3fnjNa9rxTK1riae())
				{
					continue;
				}
				goto case 44;
			case 44:
				bounds = null;
				num = 30;
				continue;
			case 18:
				dictionary4 = value.ToObject<Dictionary<int, string>>();
				goto IL_021e;
			case 37:
				dictionary2.Add(1, Resources.Low);
				num = 49;
				continue;
			case 12:
				if (jObject3.TryGetValue((string)BGyBlbWWXxpKpKnKG0R(text3, A0gsGZBPIjWiChe5hB(1276)), out value4))
				{
					dictionary3 = value4.ToObject<Dictionary<int, string>>();
					eRLyLC9pUBQCKOMG2k();
					num = ((!sr3fnjNa9rxTK1riae()) ? 46 : 29);
					continue;
				}
				goto case 21;
			case 23:
			{
				if (!PropertyBag.TryGetValue((string)A0gsGZBPIjWiChe5hB(1336), out JToken value14))
				{
					return null;
				}
				jObject2 = value14 as JObject;
				goto case 5;
			}
			default:
				num = 5;
				continue;
			case 32:
				return null;
			case 30:
				if (jObject4.TryGetValue((string)BGyBlbWWXxpKpKnKG0R(text4, A0gsGZBPIjWiChe5hB(1262)), out value6))
				{
					num = 35;
					continue;
				}
				goto case 25;
			case 39:
				return null;
			case 19:
				return null;
			case 38:
				if (jObject3 == null)
				{
					return null;
				}
				text3 = P_0.Substring(GbGVO9z9QZ3Kw0y7LK(A0gsGZBPIjWiChe5hB(1308)) + 1);
				num = 13;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
				if (jObject2.TryGetValue((string)BGyBlbWWXxpKpKnKG0R(text2, A0gsGZBPIjWiChe5hB(1276)), out value))
				{
					num = 18;
					continue;
				}
				goto IL_021e;
			case 10:
				if (!jObject2.TryGetValue(text2 + (string)A0gsGZBPIjWiChe5hB(1262), out value))
				{
					goto case 1;
				}
				num = 20;
				if (sr3fnjNa9rxTK1riae())
				{
					continue;
				}
				goto case 13;
			case 13:
				if (jObject3.TryGetValue(text3, out value8))
				{
					dictionary3 = null;
					array3 = null;
					cvsCogRegion4 = null;
					num = 24;
					continue;
				}
				num = 39;
				if (0 == 0)
				{
					continue;
				}
				goto case 21;
			case 21:
			case 29:
			{
				UntypedDescribedProperty untypedDescribedProperty6 = new UntypedDescribedProperty();
				rBmDKr0Po9ELclMdXN(untypedDescribedProperty6, P_3);
				untypedDescribedProperty6.EnumValues = dictionary3?.ToDictionary([MethodImpl(MethodImplOptions.NoInlining)] (KeyValuePair<int, string> kvp) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return kvp.Value;
				}, [MethodImpl(MethodImplOptions.NoInlining)] (KeyValuePair<int, string> kvp) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return kvp.Key;
				});
				untypedDescribedProperty6.PropertyName = P_0;
				untypedDescribedProperty6.Minimum = ((array3 != null) ? new double?(array3[0]) : ((double?)null));
				untypedDescribedProperty6.Maximum = ((array3 != null) ? new double?(array3[1]) : ((double?)null));
				WgU6kv1lSjpDhhZEus(untypedDescribedProperty6, cFIUUTNxDF(value8, P_3));
				OUtuEfWC38eAcIIfxkr(untypedDescribedProperty6, cvsCogRegion4);
				untypedDescribedProperty6.Name = P_1;
				HQXAFbekxqn1wMuNCt(untypedDescribedProperty6, P_4);
				ITxgty8e4UZpJi855g(untypedDescribedProperty6, P_2);
				Bv3nO1j2La6KldnAdK(untypedDescribedProperty6, P_5);
				t9AGkdW6Hb4x278qwgl(untypedDescribedProperty6, P_6);
				HGWTAvmgS9AUUS7T3j(untypedDescribedProperty6, P_7);
				return untypedDescribedProperty6;
			}
			case 36:
				if (!jObject4.TryGetValue(text4, out value3))
				{
					num = 22;
					continue;
				}
				array2 = null;
				num = 44;
				continue;
			case 6:
				if (jObject.TryGetValue(text + (string)A0gsGZBPIjWiChe5hB(1262), out value5))
				{
					num = 45;
					continue;
				}
				goto case 0;
			case 3:
				dictionary2 = new Dictionary<int, string>();
				dictionary2.Add(0, (string)LgGodfWsL6wL2GpD3iv());
				num = 37;
				continue;
			case 24:
				if (!jObject3.TryGetValue(text3 + (string)A0gsGZBPIjWiChe5hB(1262), out value4))
				{
					goto case 12;
				}
				num = 8;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				if (jObject2 != null)
				{
					text2 = (string)yg5rmtWQ8NoR034HwSd(P_0, ((string)A0gsGZBPIjWiChe5hB(1336)).Length + 1);
					goto case 26;
				}
				num = 19;
				continue;
			case 22:
				return null;
			case 34:
				return null;
			case 0:
				if (jObject.TryGetValue((string)BGyBlbWWXxpKpKnKG0R(text, A0gsGZBPIjWiChe5hB(1276)), out value5))
				{
					dictionary = value5.ToObject<Dictionary<int, string>>();
				}
				if (jObject.TryGetValue((string)BGyBlbWWXxpKpKnKG0R(text, A0gsGZBPIjWiChe5hB(1292)), out value5))
				{
					num = 33;
					continue;
				}
				goto IL_0787;
			case 41:
			{
				if (!DerUHJyoU9((JObject)value7, out var _, out cvsCogRegion3))
				{
					num = 48;
					continue;
				}
				jObject = value7 as JObject;
				num = 14;
				continue;
			}
			case 11:
				if (gYPaWDvE5iUpVIJZy2(P_4, A0gsGZBPIjWiChe5hB(704)))
				{
					num = 3;
					continue;
				}
				break;
			case 33:
				cvsCogRegion3 = value5.ToObject<CvsCogRegion>();
				goto IL_0787;
			case 15:
			{
				UntypedDescribedProperty untypedDescribedProperty8 = new UntypedDescribedProperty
				{
					Type = P_3,
					EnumValues = dictionary4?.ToDictionary([MethodImpl(MethodImplOptions.NoInlining)] (KeyValuePair<int, string> kvp) =>
					{
						while (false)
						{
							_ = ((object[])null)[0];
						}
						return kvp.Value;
					}, [MethodImpl(MethodImplOptions.NoInlining)] (KeyValuePair<int, string> kvp) =>
					{
						while (false)
						{
							_ = ((object[])null)[0];
						}
						return kvp.Key;
					}),
					PropertyName = P_0,
					Minimum = ((array != null) ? new double?(array[0]) : ((double?)null)),
					Maximum = ((array != null) ? new double?(array[1]) : ((double?)null))
				};
				WgU6kv1lSjpDhhZEus(untypedDescribedProperty8, 0);
				OUtuEfWC38eAcIIfxkr(untypedDescribedProperty8, cvsCogRegion2);
				s2HH4BJulQDxeD6gqy(untypedDescribedProperty8, P_1);
				HQXAFbekxqn1wMuNCt(untypedDescribedProperty8, P_4);
				ITxgty8e4UZpJi855g(untypedDescribedProperty8, P_2);
				Bv3nO1j2La6KldnAdK(untypedDescribedProperty8, P_5);
				t9AGkdW6Hb4x278qwgl(untypedDescribedProperty8, P_6);
				untypedDescribedProperty8.LastProperty = P_7;
				return untypedDescribedProperty8;
			}
			case 26:
			case 46:
			{
				if (!jObject2.TryGetValue(text2, out JToken _))
				{
					return null;
				}
				dictionary4 = null;
				array = null;
				num = 2;
				continue;
			}
			case 43:
				if (PropertyBag.TryGetValue((string)A0gsGZBPIjWiChe5hB(1214), out value7))
				{
					num = 41;
					continue;
				}
				goto case 48;
			case 35:
				array2 = value6.ToObject<double[]>();
				num = 25;
				continue;
			case 27:
				dictionary2 = FJIUeJZtp0<Dictionary<int, string>>(P_0 + (string)A0gsGZBPIjWiChe5hB(1276), null);
				num = 42;
				if (sr3fnjNa9rxTK1riae())
				{
					continue;
				}
				goto case 7;
			case 7:
				array4 = null;
				num = 6;
				continue;
			case 47:
				return null;
			case 9:
			{
				UntypedDescribedProperty untypedDescribedProperty2 = new UntypedDescribedProperty();
				rBmDKr0Po9ELclMdXN(untypedDescribedProperty2, P_3);
				sggdgaANd6Y9xpeGhH(untypedDescribedProperty2, P_0);
				WgU6kv1lSjpDhhZEus(untypedDescribedProperty2, 0);
				s2HH4BJulQDxeD6gqy(untypedDescribedProperty2, P_1);
				untypedDescribedProperty2.TagName = P_4;
				ITxgty8e4UZpJi855g(untypedDescribedProperty2, P_2);
				Bv3nO1j2La6KldnAdK(untypedDescribedProperty2, P_5);
				HGWTAvmgS9AUUS7T3j(untypedDescribedProperty2, P_7);
				return untypedDescribedProperty2;
			}
			case 2:
				cvsCogRegion2 = null;
				num = 10;
				continue;
			case 45:
				array4 = value5.ToObject<double[]>();
				num = 0;
				continue;
			case 42:
				cvsCogRegion = FJIUeJZtp0<CvsCogRegion>((string)BGyBlbWWXxpKpKnKG0R(P_0, A0gsGZBPIjWiChe5hB(1292)), null);
				num = 11;
				if (!eRLyLC9pUBQCKOMG2k())
				{
					continue;
				}
				goto case 48;
			case 48:
				return null;
			case 8:
				array3 = value4.ToObject<double[]>();
				num = 12;
				if (eRLyLC9pUBQCKOMG2k())
				{
				}
				continue;
			case 4:
			{
				if (jObject.TryGetValue(text, out JToken _))
				{
					dictionary = null;
					num = 7;
					if (0 == 0)
					{
						continue;
					}
					goto case 25;
				}
				num = 16;
				continue;
			}
			case 20:
				array = value.ToObject<double[]>();
				num = 1;
				continue;
			case 40:
				return null;
			case 49:
				break;
				IL_0787:
				untypedDescribedProperty7 = new UntypedDescribedProperty();
				rBmDKr0Po9ELclMdXN(untypedDescribedProperty7, P_3);
				untypedDescribedProperty7.PropertyName = P_0;
				WgU6kv1lSjpDhhZEus(untypedDescribedProperty7, 0);
				OUtuEfWC38eAcIIfxkr(untypedDescribedProperty7, cvsCogRegion3);
				untypedDescribedProperty7.Name = P_1;
				untypedDescribedProperty7.TagName = P_4;
				untypedDescribedProperty7.Description = P_2;
				Bv3nO1j2La6KldnAdK(untypedDescribedProperty7, false);
				untypedDescribedProperty7.Maximum = ((array4 != null) ? new double?(array4[1]) : ((double?)null));
				untypedDescribedProperty7.Minimum = ((array4 != null) ? new double?(array4[0]) : ((double?)null));
				untypedDescribedProperty7.EnumValues = dictionary?.ToDictionary([MethodImpl(MethodImplOptions.NoInlining)] (KeyValuePair<int, string> kvp) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return kvp.Value;
				}, [MethodImpl(MethodImplOptions.NoInlining)] (KeyValuePair<int, string> kvp) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return kvp.Key;
				});
				untypedDescribedProperty7.LastProperty = P_7;
				return untypedDescribedProperty7;
				IL_021e:
				if (jObject2.TryGetValue(text2 + (string)A0gsGZBPIjWiChe5hB(1292), out value))
				{
					cvsCogRegion2 = value.ToObject<CvsCogRegion>();
					num = 15;
					continue;
				}
				goto case 15;
			}
			break;
		}
		UntypedDescribedProperty untypedDescribedProperty9 = new UntypedDescribedProperty();
		rBmDKr0Po9ELclMdXN(untypedDescribedProperty9, P_3);
		untypedDescribedProperty9.EnumValues = dictionary2?.ToDictionary([MethodImpl(MethodImplOptions.NoInlining)] (KeyValuePair<int, string> kvp) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kvp.Value;
		}, [MethodImpl(MethodImplOptions.NoInlining)] (KeyValuePair<int, string> kvp) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kvp.Key;
		});
		sggdgaANd6Y9xpeGhH(untypedDescribedProperty9, P_0);
		untypedDescribedProperty9.Minimum = ((array5 != null) ? new double?(array5[0]) : ((double?)null));
		untypedDescribedProperty9.Maximum = ((array5 != null) ? new double?(array5[1]) : ((double?)null));
		untypedDescribedProperty9.Value = cFIUUTNxDF(value11, P_3);
		OUtuEfWC38eAcIIfxkr(untypedDescribedProperty9, cvsCogRegion);
		s2HH4BJulQDxeD6gqy(untypedDescribedProperty9, P_1);
		HQXAFbekxqn1wMuNCt(untypedDescribedProperty9, P_4);
		untypedDescribedProperty9.Description = P_2;
		Bv3nO1j2La6KldnAdK(untypedDescribedProperty9, P_5);
		t9AGkdW6Hb4x278qwgl(untypedDescribedProperty9, P_6);
		HGWTAvmgS9AUUS7T3j(untypedDescribedProperty9, P_7);
		return untypedDescribedProperty9;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool DerUHJyoU9(JObject P_0, out CvsCogRegion P_1, out CvsCogRegion P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		JToken value2 = default;
		JToken value = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				P_2 = value2.ToObject<CvsCogRegion>();
				goto default;
			case 3:
				if (P_0.TryGetValue(kgbOBx7BanbFa22Hp9.ol99ukmDA(1364), out value))
				{
					_ = 0;
					if (!sr3fnjNa9rxTK1riae())
					{
						num = 7;
						break;
					}
					num = 0;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				}
				goto IL_00c3;
			case 0:
			case 1:
				if (P_0.TryGetValue((string)A0gsGZBPIjWiChe5hB(1380), out value2))
				{
					num = 5;
					if (sr3fnjNa9rxTK1riae())
					{
						break;
					}
					goto default;
				}
				goto IL_00c3;
			default:
				return true;
			case 5:
				P_1 = value.ToObject<CvsCogRegion>();
				num = 6;
				break;
			case 2:
				P_2 = null;
				num = 8;
				break;
			case 8:
				{
					return false;
				}
				IL_00c3:
				P_1 = null;
				num = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object cFIUUTNxDF(JToken P_0, UntypedDescribedProperty.EditType P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_1 switch
		{
			UntypedDescribedProperty.EditType.BanksEnabled => (object)P_0.ToObject<int>(), 
			UntypedDescribedProperty.EditType.Long => P_0.ToObject<long>(), 
			UntypedDescribedProperty.EditType.Double => P_0.ToObject<double>(), 
			UntypedDescribedProperty.EditType.Enum => P_0.ToObject<int>(), 
			UntypedDescribedProperty.EditType.Region => P_0.ToObject<CvsCogRegion>(), 
			_ => throw new ArgumentOutOfRangeException(), 
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool zptUlMKTGx(UntypedDescribedProperty P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_005c;
		IL_001a:
		double? maximum = P_0.Maximum;
		num = 9;
		if (1 == 0)
		{
			goto IL_002d;
		}
		goto IL_005c;
		IL_005c:
		double? num2 = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			default:
				goto IL_002d;
			case 1:
				if (num2.HasValue)
				{
					goto IL_002d;
				}
				goto IL_015c;
			case 8:
				if ((string)MCfUdeWwXcOrO9FVtBC(P_0) != (string)mkAGCRWPwPBywVRdmtU())
				{
					num = 11;
					if (true)
					{
						continue;
					}
					goto case 9;
				}
				goto IL_015c;
			case 9:
				if (num2 == maximum)
				{
					num = 8;
					if (eRLyLC9pUBQCKOMG2k())
					{
					}
					continue;
				}
				goto IL_015c;
			case 10:
				if (P_0 == null)
				{
					num = 2;
					continue;
				}
				num2 = P_0.Maximum;
				num = 7;
				if (true)
				{
					continue;
				}
				goto case 7;
			case 3:
			case 6:
				num2 = P_0.Minimum;
				num = 1;
				continue;
			case 2:
				return false;
			case 7:
				if (num2.HasValue)
				{
					eRLyLC9pUBQCKOMG2k();
					if (!sr3fnjNa9rxTK1riae())
					{
						num = 0;
						if (0 == 0)
						{
							continue;
						}
						goto case 8;
					}
					num = 6;
					continue;
				}
				goto IL_015c;
			case 11:
				{
					return false;
				}
				IL_015c:
				return true;
			}
			break;
		}
		goto IL_001a;
		IL_002d:
		num2 = P_0.Minimum;
		num = 4;
		goto IL_005c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogAcqSettingsContainer()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CHuKMoWIOdJy61M6I2S();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private TMSHBPfx1HbxsHGp2C FJIUeJZtp0<TMSHBPfx1HbxsHGp2C>(string P_0, TMSHBPfx1HbxsHGp2C MrnYMROiPXXfkX7n2H)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (PropertyBag.TryGetValue(P_0, out JToken value))
		{
			return value.ToObject<TMSHBPfx1HbxsHGp2C>();
		}
		return MrnYMROiPXXfkX7n2H;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object A0gsGZBPIjWiChe5hB(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rBmDKr0Po9ELclMdXN(object P_0, UntypedDescribedProperty.EditType value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((UntypedDescribedProperty)P_0).Type = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sggdgaANd6Y9xpeGhH(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((UntypedDescribedProperty)P_0).PropertyName = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WgU6kv1lSjpDhhZEus(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((UntypedDescribedProperty)P_0).Value = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void s2HH4BJulQDxeD6gqy(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((UntypedDescribedProperty)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ITxgty8e4UZpJi855g(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((UntypedDescribedProperty)P_0).Description = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Bv3nO1j2La6KldnAdK(object P_0, bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((UntypedDescribedProperty)P_0).ShouldAlwaysUpdate = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HGWTAvmgS9AUUS7T3j(object P_0, bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((UntypedDescribedProperty)P_0).LastProperty = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gYPaWDvE5iUpVIJZy2(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dqNNfn3hIufQyyxCdU(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CogSocketActionPath)P_0).Path = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HQXAFbekxqn1wMuNCt(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((UntypedDescribedProperty)P_0).TagName = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GbGVO9z9QZ3Kw0y7LK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yg5rmtWQ8NoR034HwSd(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Substring(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BGyBlbWWXxpKpKnKG0R(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OUtuEfWC38eAcIIfxkr(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((UntypedDescribedProperty)P_0).Bounds = (CvsCogRegion)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void t9AGkdW6Hb4x278qwgl(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((UntypedDescribedProperty)P_0).Group = (ArgumentGroupDescriptor)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CQRWJkW4t82s9Lqkeqd(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).StartsWith((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LgGodfWsL6wL2GpD3iv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.High;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sr3fnjNa9rxTK1riae()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool eRLyLC9pUBQCKOMG2k()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MCfUdeWwXcOrO9FVtBC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((UntypedDescribedProperty)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mkAGCRWPwPBywVRdmtU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.IlluminationBanksEnabled;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CHuKMoWIOdJy61M6I2S()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}
}
