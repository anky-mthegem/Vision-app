using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Cognex.Extensions;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

public sealed class CvsHelpResolver
{
	private static readonly Regex ORKkYHFbE4;

	private static readonly Lazy<Dictionary<string, string>> aUck71UOPn;

	private static readonly Dictionary<string, IHelpResolverOverride> uA2km1mKMd;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetSpreadsheetHelpPath(string topic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)RKtRPebmfVyLNpxX0Kb(kjAhaPbFR5f1lxnPMkh(42784), topic);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetHelpTopic(CvsFunctionTableEntryPath path)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		Dictionary<string, IHelpResolverOverride>.Enumerator enumerator = default;
		IHelpResolverOverride value = default;
		string helpTopic = default;
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				if (path == null)
				{
					JrZFxmbkdtyN62GwkY6();
					num = (BZ8xKXbftYBXy32vUXp() ? 3 : 4);
					break;
				}
				enumerator = uA2km1mKMd.GetEnumerator();
				goto default;
			default:
				try
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, IHelpResolverOverride> current = enumerator.Current;
						_ = 0;
						int num2;
						if (JrZFxmbkdtyN62GwkY6())
						{
							num2 = 3;
						}
						else
						{
							num2 = 4;
							if (BZ8xKXbftYBXy32vUXp())
							{
								goto IL_0096;
							}
						}
						goto IL_00b4;
						IL_00b4:
						while (true)
						{
							switch (num2)
							{
							case 2:
								break;
							case 0:
							case 3:
								value = current.Value;
								goto IL_0096;
							case 1:
							case 4:
								goto IL_0096;
							default:
								num2 = 2;
								continue;
							case 5:
								return helpTopic;
							}
							break;
						}
						goto IL_005b;
						IL_0096:
						if (!lRt0qSbyTThLics253U(value, path))
						{
							continue;
						}
						goto IL_005b;
						IL_005b:
						helpTopic = value.GetHelpTopic(path);
						num2 = 5;
						if (BZ8xKXbftYBXy32vUXp())
						{
						}
						goto IL_00b4;
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
				}
				text = (string)DXMlITbgtTWfrwh38Gu(sQTkf3p13F(path));
				num = 5;
				break;
			case 1:
			case 4:
				return kgbOBx7BanbFa22Hp9.ol99ukmDA(42828);
			case 5:
				return (string)lsT5CJbZOocSg9uQBTg(RKtRPebmfVyLNpxX0Kb(kjAhaPbFR5f1lxnPMkh(42882), text));
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddOverride(string featureCategory, IHelpResolverOverride helpResolver)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!BZ8xKXbftYBXy32vUXp())
		{
		}
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				helpResolver.GetSpreadsheetHelpPath = GetSpreadsheetHelpPath;
				break;
			default:
				num = 3;
				continue;
			case 0:
				if (uA2km1mKMd.ContainsKey(featureCategory))
				{
					BZ8xKXbftYBXy32vUXp();
					num = ((!JrZFxmbkdtyN62GwkY6()) ? 4 : 5);
					continue;
				}
				helpResolver.ApplyTopicPathRedirect = uRhkcmFGLV;
				goto case 2;
			case 1:
			case 5:
				throw new InvalidOperationException((string)RR452MbJ6Yg47kyB30G(kgbOBx7BanbFa22Hp9.ol99ukmDA(42910), featureCategory, kgbOBx7BanbFa22Hp9.ol99ukmDA(42960)));
			case 3:
				break;
			case 6:
				return;
			}
			uA2km1mKMd[featureCategory] = helpResolver;
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string sQTkf3p13F(CvsFunctionTableEntryPath P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		string result = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
				result = (string)RKtRPebmfVyLNpxX0Kb(G56mh1bzdDf82JlPETB(CQ8G926w9cf1qvOQ2FM(P_0)), kjAhaPbFR5f1lxnPMkh(42994));
				break;
			case 0:
				if (xPGDW5b8bLsJWEG4bI1(P_0) != null)
				{
					num = 5;
					continue;
				}
				if (CQ8G926w9cf1qvOQ2FM(P_0) == null)
				{
					result = (string)RKtRPebmfVyLNpxX0Kb(G56mh1bzdDf82JlPETB(WvI99M6s4BG5DYGWaTw(P_0)), kjAhaPbFR5f1lxnPMkh(43006));
					num = 7;
					continue;
				}
				goto default;
			default:
				_ = 1;
				num = (BZ8xKXbftYBXy32vUXp() ? 1 : 2);
				continue;
			case 5:
				result = (string)RKtRPebmfVyLNpxX0Kb(G56mh1bzdDf82JlPETB(xPGDW5b8bLsJWEG4bI1(P_0)), kjAhaPbFR5f1lxnPMkh(42994));
				num = 6;
				continue;
			case 1:
			case 4:
			case 6:
			case 7:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string jZBkjd3kMF(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)fhGXyK6hlVhspWB9bFB(ORKkYHFbE4, P_0, string.Empty);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string uRhkcmFGLV(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return aUck71UOPn.Value.GetValueOrDefault(P_0, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Dictionary<string, string> tjCk5wXi8t()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		using Stream stream = typeof(CvsHelpResolver).Assembly.GetManifestResourceStream(kgbOBx7BanbFa22Hp9.ol99ukmDA(43036));
		using StreamReader streamReader = new StreamReader(stream);
		return XElement.Parse(streamReader.ReadToEnd()).Elements(kgbOBx7BanbFa22Hp9.ol99ukmDA(43124)).Select([MethodImpl(MethodImplOptions.NoInlining)] (XElement element) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new
			{
				element = element,
				topic = element.Attribute(kgbOBx7BanbFa22Hp9.ol99ukmDA(56938))
			};
		})
			.Select([MethodImpl(MethodImplOptions.NoInlining)] (_003C_003Eh__TransparentIdentifier0) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return new
				{
					_003C_003Eh__TransparentIdentifier0 = _003C_003Eh__TransparentIdentifier0,
					value = _003C_003Eh__TransparentIdentifier0.element.Attribute(kgbOBx7BanbFa22Hp9.ol99ukmDA(56952))
				};
			})
			.Where([MethodImpl(MethodImplOptions.NoInlining)] (_003C_003Eh__TransparentIdentifier1) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003Eh__TransparentIdentifier1._003C_003Eh__TransparentIdentifier0.topic != null;
			})
			.Where([MethodImpl(MethodImplOptions.NoInlining)] (_003C_003Eh__TransparentIdentifier1) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003Eh__TransparentIdentifier1.value != null;
			})
			.Select([MethodImpl(MethodImplOptions.NoInlining)] (_003C_003Eh__TransparentIdentifier1) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return new
				{
					Topic = _003C_003Eh__TransparentIdentifier1._003C_003Eh__TransparentIdentifier0.topic.Value,
					Value = _003C_003Eh__TransparentIdentifier1.value.Value
				};
			})
			.ToDictionary([MethodImpl(MethodImplOptions.NoInlining)] (redirect) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return redirect.Topic;
			}, [MethodImpl(MethodImplOptions.NoInlining)] (redirect) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return redirect.Value;
			}, StringComparer.OrdinalIgnoreCase);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsHelpResolver()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		FTNpew6L7ZsX66jDk87();
		Xvf1Jo69Groj3KaGUwd(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsHelpResolver()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = ((!BZ8xKXbftYBXy32vUXp()) ? 1 : 3);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				FTNpew6L7ZsX66jDk87();
				num = 5;
				break;
			case 4:
				uA2km1mKMd = new Dictionary<string, IHelpResolverOverride>();
				num = 6;
				break;
			case 2:
			case 3:
				aUck71UOPn = new Lazy<Dictionary<string, string>>(tjCk5wXi8t);
				goto case 4;
			default:
				num = 4;
				break;
			case 5:
				ORKkYHFbE4 = new Regex((string)kjAhaPbFR5f1lxnPMkh(43144), RegexOptions.IgnoreCase);
				goto case 2;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kjAhaPbFR5f1lxnPMkh(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RKtRPebmfVyLNpxX0Kb(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JrZFxmbkdtyN62GwkY6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BZ8xKXbftYBXy32vUXp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lRt0qSbyTThLics253U(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IHelpResolverOverride)P_0).ShouldApplyOverride((CvsFunctionTableEntryPath)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DXMlITbgtTWfrwh38Gu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return uRhkcmFGLV((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lsT5CJbZOocSg9uQBTg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetSpreadsheetHelpPath((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RR452MbJ6Yg47kyB30G(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xPGDW5b8bLsJWEG4bI1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionTableEntryPath)P_0).FunctionName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object G56mh1bzdDf82JlPETB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return jZBkjd3kMF((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CQ8G926w9cf1qvOQ2FM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionTableEntryPath)P_0).CategoryName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WvI99M6s4BG5DYGWaTw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionTableEntryPath)P_0).GroupName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fhGXyK6hlVhspWB9bFB(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Regex)P_0).Replace((string)P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FTNpew6L7ZsX66jDk87()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Xvf1Jo69Groj3KaGUwd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
