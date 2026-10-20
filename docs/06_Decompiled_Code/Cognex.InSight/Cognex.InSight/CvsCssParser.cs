using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Media;
using Cognex.Cnx.Diagnostics;
using Cognex.InSight.Internal;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

public class CvsCssParser
{
	private SortedList<string, CvsStyleClass> sKoxFUMCT1;

	public SortedList<string, CvsStyleClass> Styles
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return sKoxFUMCT1;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCssParser()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		XlpQLrEvt9i8UuICxvs();
		int num;
		if (uEiNJlEEQbgKr35DWE8())
		{
			num = 3;
		}
		else
		{
			num = 4;
			if (XlpQLrEvt9i8UuICxvs())
			{
			}
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				sKoxFUMCT1 = new SortedList<string, CvsStyleClass>();
				num = 5;
				break;
			case 1:
			case 4:
				base._002Ector();
				goto case 2;
			default:
				num = 2;
				break;
			case 0:
			case 3:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				goto case 1;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsStyleClass GetStyle(string styleName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (Styles.ContainsKey(styleName))
		{
			return Styles[styleName];
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetStyleValue(string styleName, string property, string newValue)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (uEiNJlEEQbgKr35DWE8())
		{
			num = 4;
			if (!uEiNJlEEQbgKr35DWE8())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_0075;
		IL_002a:
		CvsStyleClass style = default;
		if (style != null)
		{
			num = 3;
			goto IL_0075;
		}
		return;
		IL_0075:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				break;
			case 0:
			case 4:
				style = GetStyle(styleName);
				break;
			case 3:
				if (style.Attributes.ContainsKey(property))
				{
					goto case 2;
				}
				return;
			default:
				num = 2;
				continue;
			case 2:
				style.Attributes[property] = newValue;
				num = 6;
				continue;
			case 6:
				return;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public new string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		XlpQLrEvt9i8UuICxvs();
		int num;
		if (uEiNJlEEQbgKr35DWE8())
		{
			num = 3;
		}
		else
		{
			num = 2;
			if (!uEiNJlEEQbgKr35DWE8())
			{
				goto IL_0044;
			}
		}
		StringBuilder stringBuilder = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				stringBuilder = new StringBuilder();
				break;
			case 1:
			case 2:
				break;
			default:
				num = 4;
				continue;
			case 4:
				goto IL_0085;
			}
			break;
		}
		goto IL_0044;
		IL_0044:
		IEnumerator<KeyValuePair<string, CvsStyleClass>> enumerator = Styles.GetEnumerator();
		goto IL_0085;
		IL_0085:
		try
		{
			while (TuFBiREdBD3Mc3ZKp02(enumerator))
			{
				KeyValuePair<string, CvsStyleClass> current = enumerator.Current;
				bool flag = !pOKa81EHQfiH8LKabCm(current.Key);
				if (flag)
				{
					WMhhpgEAcOV09kG6NQ4(stringBuilder, oRUmIBEVUyoNA63vEkR(5862), current.Key);
				}
				IEnumerator<KeyValuePair<string, string>> enumerator2 = current.Value.Attributes.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						KeyValuePair<string, string> current2 = enumerator2.Current;
						_ = 1;
						int num2;
						if (!XlpQLrEvt9i8UuICxvs())
						{
							num2 = 2;
						}
						else
						{
							num2 = 3;
							if (XlpQLrEvt9i8UuICxvs())
							{
								continue;
							}
						}
						switch (num2)
						{
						case 0:
						case 2:
							c0pqsUEDUdlVvPmX8Wk(stringBuilder, oRUmIBEVUyoNA63vEkR(5876), current2.Key, current2.Value);
							break;
						}
					}
				}
				finally
				{
					if (enumerator2 != null)
					{
						fmx008EU93bMC4DTw80(enumerator2);
					}
				}
				if (flag)
				{
					WosGDOETR3wDWnm6UOb(stringBuilder, oRUmIBEVUyoNA63vEkR(5896));
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				fmx008EU93bMC4DTw80(enumerator);
			}
		}
		return stringBuilder.ToString();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ParseStyleSheet(string content)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			int num;
			string[] array = default;
			int num2 = default;
			if (DvtUdfEiKm17lXlDwOm(content, '}') < 0)
			{
				XlpQLrEvt9i8UuICxvs();
				if (uEiNJlEEQbgKr35DWE8())
				{
					num = 8;
				}
				else
				{
					num = 4;
					if (1 == 0)
					{
						goto IL_016a;
					}
				}
			}
			else
			{
				array = (string[])G47ETwEjvsVA7HnIc91(content, new char[1] { '}' });
				num2 = 0;
				num = 5;
				if (1 == 0)
				{
					goto IL_005b;
				}
			}
			goto IL_010b;
			IL_010b:
			string[] array2 = default;
			CvsStyleClass cvsStyleClass = default;
			string text = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					return;
				case 11:
					break;
				case 9:
					array2 = xRBxxFkxvL(content).Split(';');
					num = 1;
					continue;
				case 1:
					Gi3x1U0o35(cvsStyleClass, array2);
					num = 10;
					if (uEiNJlEEQbgKr35DWE8())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 8:
					cvsStyleClass = new CvsStyleClass();
					num = 11;
					continue;
				case 3:
					num2++;
					num = 12;
					continue;
				case 4:
				case 7:
					if (DvtUdfEiKm17lXlDwOm(xRBxxFkxvL(text), '{') > -1)
					{
						num = 2;
						continue;
					}
					goto case 3;
				case 10:
					sKoxFUMCT1.Add((string)PFRMFyEBBO6sCJaYlxN(cvsStyleClass), cvsStyleClass);
					return;
				default:
					num = 6;
					continue;
				case 2:
					goto IL_016a;
				case 5:
				case 12:
					if (num2 < array.Length)
					{
						text = array[num2];
						goto case 4;
					}
					return;
				}
				break;
			}
			goto IL_005b;
			IL_005b:
			ypQWIpEqnvtAHvEh8h3(cvsStyleClass, "");
			num = 9;
			goto IL_010b;
			IL_016a:
			R1AxIhnT6H(text);
			num = 3;
			goto IL_010b;
		}
		catch (Exception ex)
		{
			e7koCmEcwJVn5yYuZ4C(CvsTraceSDK.Error, oRUmIBEVUyoNA63vEkR(5902), new object[1] { content });
			CvsTraceSDK.Error.TraceException(ex);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void R1AxIhnT6H(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		CvsStyleClass cvsStyleClass = default;
		string[] array2 = default;
		string text = default;
		string[] array = default;
		while (true)
		{
			switch (num)
			{
			case 4:
			case 8:
				Gi3x1U0o35(cvsStyleClass, array2);
				goto case 9;
			case 2:
				if (sKoxFUMCT1.ContainsKey(text))
				{
					num = 0;
					break;
				}
				cvsStyleClass = new CvsStyleClass();
				num = 5;
				break;
			case 10:
				sKoxFUMCT1.Remove(text);
				goto case 5;
			default:
				num = 7;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
				text = xRBxxFkxvL(array[0]).Trim().ToLowerInvariant();
				num = 2;
				if (uEiNJlEEQbgKr35DWE8())
				{
					break;
				}
				goto case 5;
			case 5:
			case 7:
				ypQWIpEqnvtAHvEh8h3(cvsStyleClass, text);
				array2 = (string[])G47ETwEjvsVA7HnIc91(xRBxxFkxvL(array[1]).Replace((string)oRUmIBEVUyoNA63vEkR(5896), ""), new char[1] { ';' });
				XlpQLrEvt9i8UuICxvs();
				num = (uEiNJlEEQbgKr35DWE8() ? 4 : 11);
				break;
			case 0:
				cvsStyleClass = sKoxFUMCT1[text];
				num = 10;
				if (true)
				{
					break;
				}
				goto case 3;
			case 3:
				cvsStyleClass = null;
				num = 6;
				break;
			case 9:
			case 11:
				sKoxFUMCT1.Add((string)PFRMFyEBBO6sCJaYlxN(cvsStyleClass), cvsStyleClass);
				num = 12;
				break;
			case 6:
				array = (string[])G47ETwEjvsVA7HnIc91(P_0, new char[1] { '{' });
				num = 1;
				break;
			case 12:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Gi3x1U0o35(CvsStyleClass P_0, string[] P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		int num2 = default;
		string[] array = default;
		string key = default;
		string value = default;
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 8:
				num2++;
				num = 1;
				if (uEiNJlEEQbgKr35DWE8())
				{
					break;
				}
				goto case 6;
			case 6:
				array = P_1;
				num = 2;
				if (uEiNJlEEQbgKr35DWE8())
				{
					break;
				}
				goto case 0;
			case 0:
			case 5:
				P_0.Attributes.Remove(key);
				goto case 4;
			default:
				num = 4;
				break;
			case 11:
				P_0.Attributes.Add(key, value);
				goto case 3;
			case 4:
				value = (string)V8L8WTEWoaPlN6NypFa(((object[])G47ETwEjvsVA7HnIc91(text, new char[1] { ':' }))[1]);
				num = 11;
				break;
			case 1:
			case 7:
				if (num2 < array.Length)
				{
					text = array[num2];
					num = 9;
				}
				else
				{
					num = 12;
				}
				break;
			case 10:
				key = ((string)V8L8WTEWoaPlN6NypFa(((object[])G47ETwEjvsVA7HnIc91(text, new char[1] { ':' }))[0])).ToLowerInvariant();
				if (P_0.Attributes.ContainsKey(key))
				{
					_ = 1;
					num = (XlpQLrEvt9i8UuICxvs() ? 3 : 0);
					break;
				}
				goto case 4;
			case 9:
				if (gG7hqfE28mwY6oVLXdl(text, oRUmIBEVUyoNA63vEkR(5954)))
				{
					num = 10;
					break;
				}
				goto case 3;
			case 2:
				num2 = 0;
				num = 7;
				if (false)
				{
					return;
				}
				break;
			case 12:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string xRBxxFkxvL(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!uEiNJlEEQbgKr35DWE8()) ? 3 : 4);
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				text = (string)JDrHjGE7ub5oJWgRH9T(new Regex((string)oRUmIBEVUyoNA63vEkR(5960)), text, "");
				goto case 2;
			default:
				num = 2;
				break;
			case 2:
				text = (string)RBd44nEt7tDmQJ3b9J5(RBd44nEt7tDmQJ3b9J5(text, kgbOBx7BanbFa22Hp9.ol99ukmDA(6014), ""), oRUmIBEVUyoNA63vEkR(6020), "");
				num = 5;
				break;
			case 0:
			case 4:
				text = P_0;
				goto case 1;
			case 5:
				return text;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static System.Drawing.Color ConvertStringToColor(string colorStr)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		MatchCollection matchCollection = default;
		System.Windows.Media.Color color = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				try
				{
					return Gb7fGNE1rN1bVsWgOv6((int)(OI56p9ENMnLwY9ybwPD(FVJiNbEPTh4bvpZ3jLt(cItiQfEoYb5qmmcu430(matchCollection, 3)), tnIIZkEYqVfSuBC0ZEQ()) * 255.0), mvkD0wEx21aLnkyup74(FVJiNbEPTh4bvpZ3jLt(cItiQfEoYb5qmmcu430(matchCollection, 0))), Convert.ToInt32(matchCollection[1].Value), mvkD0wEx21aLnkyup74(FVJiNbEPTh4bvpZ3jLt(cItiQfEoYb5qmmcu430(matchCollection, 2))));
				}
				catch (Exception)
				{
					return aOkGvUErsQYhJhK6Hd4();
				}
			case 1:
			case 4:
				matchCollection = (MatchCollection)klMD9IEKduWccRwWcX5(colorStr, kgbOBx7BanbFa22Hp9.ol99ukmDA(6038));
				goto case 2;
			case 0:
				if (!pSxImsECW7yX6n71f9J(colorStr, oRUmIBEVUyoNA63vEkR(6026)))
				{
					color = (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(colorStr);
					num = 6;
				}
				else
				{
					_ = 1;
					num = ((!XlpQLrEvt9i8UuICxvs()) ? 4 : 5);
				}
				break;
			case 2:
			case 5:
				if (brBCIqE5Ic9hVBIgqv2(matchCollection) != 4)
				{
					return System.Drawing.Color.Transparent;
				}
				goto case 3;
			default:
				num = 3;
				break;
			case 6:
				return RPcOFhE3ThiWfnwvKqR(color.R, color.G, color.B);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uEiNJlEEQbgKr35DWE8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XlpQLrEvt9i8UuICxvs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pOKa81EHQfiH8LKabCm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oRUmIBEVUyoNA63vEkR(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WMhhpgEAcOV09kG6NQ4(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StringBuilder)P_0).AppendFormat((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object c0pqsUEDUdlVvPmX8Wk(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StringBuilder)P_0).AppendFormat((string)P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fmx008EU93bMC4DTw80(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WosGDOETR3wDWnm6UOb(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TuFBiREdBD3Mc3ZKp02(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int DvtUdfEiKm17lXlDwOm(object P_0, char P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).IndexOf(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ypQWIpEqnvtAHvEh8h3(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsStyleClass)P_0).Name = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PFRMFyEBBO6sCJaYlxN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsStyleClass)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object G47ETwEjvsVA7HnIc91(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Split((char[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void e7koCmEcwJVn5yYuZ4C(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CnxTraceChannel)P_0).TraceMessage((string)P_1, (object[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gG7hqfE28mwY6oVLXdl(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Contains((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object V8L8WTEWoaPlN6NypFa(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Trim();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JDrHjGE7ub5oJWgRH9T(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Regex)P_0).Replace((string)P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RBd44nEt7tDmQJ3b9J5(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pSxImsECW7yX6n71f9J(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).StartsWith((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object klMD9IEKduWccRwWcX5(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Regex.Matches((string)P_0, (string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int brBCIqE5Ic9hVBIgqv2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MatchCollection)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cItiQfEoYb5qmmcu430(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MatchCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FVJiNbEPTh4bvpZ3jLt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Capture)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tnIIZkEYqVfSuBC0ZEQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.InvariantCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double OI56p9ENMnLwY9ybwPD(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToDouble((string)P_0, (IFormatProvider)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int mvkD0wEx21aLnkyup74(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToInt32((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static System.Drawing.Color Gb7fGNE1rN1bVsWgOv6(int P_0, int P_1, int P_2, int P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return System.Drawing.Color.FromArgb(P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static System.Drawing.Color aOkGvUErsQYhJhK6Hd4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return System.Drawing.Color.Transparent;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static System.Drawing.Color RPcOFhE3ThiWfnwvKqR(int P_0, int P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return System.Drawing.Color.FromArgb(P_0, P_1, P_2);
	}
}
