using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cognex.InSight.Cell;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Extensions;

public static class EzSnippetExtensions
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsCell GetEzToolNameCell(this CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IEnumerator<CvsCellLocation> enumerator = range.GetEnumerator();
		try
		{
			string text = default;
			CvsCell result = default;
			while (fLHeNhKwJfrabLA9CkE3(enumerator))
			{
				CvsCellLocation current = enumerator.Current;
				_ = 0;
				int num = ((!BWX40xK5tngQe2xSf9LN()) ? 5 : 3);
				while (true)
				{
					object obj2;
					switch (num)
					{
					case 4:
						if (FJZd4jKwwSul5r2wiUOX(text, RCDjNmKw5bpL7400MVEf(1188), StringComparison.Ordinal))
						{
							num = 2;
							continue;
						}
						break;
					case 0:
					case 3:
					{
						object obj = kVtxftKwLXOJwjeZrWnR(cells, current);
						if (obj == null)
						{
							goto case 1;
						}
						obj2 = S1SNZMKwK7um0RMPAMZN(obj);
						goto IL_0099;
					}
					case 2:
						result = (CvsCell)kVtxftKwLXOJwjeZrWnR(cells, current);
						num = 6;
						if (BWX40xK5tngQe2xSf9LN())
						{
							continue;
						}
						goto case 1;
					case 1:
					case 5:
						obj2 = null;
						goto IL_0099;
					default:
						num = 4;
						continue;
					case 6:
						{
							return result;
						}
						IL_0099:
						text = (string)obj2;
						if (text == null)
						{
							break;
						}
						goto case 4;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				NLgGkGKwa4Jl1moP6xBp(enumerator);
			}
		}
		throw new ArgumentException(string.Format((string)RCDjNmKw5bpL7400MVEf(47464), range));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsCell GetSnippetGuidCell(this CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (CvsCell)kVtxftKwLXOJwjeZrWnR(cells, range.Location);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Guid GetSnippetGuid(this CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCell cvsCell = (CvsCell)nsfDdsKwet1iYZUkGbqT(cells, range);
		if (cvsCell.HasComment)
		{
			return new Guid(((CvsCellComment)o9YyrlKwOFAAeouIKLxg(cvsCell)).Text);
		}
		throw new ArgumentException((string)P50LTJKwIBhsvcKWHAjR(RCDjNmKw5bpL7400MVEf(47544), range.Location));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsCell GetSnippetVersionCell(this CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellLocation location = range.Location;
		location.Column++;
		return (CvsCell)kVtxftKwLXOJwjeZrWnR(cells, location);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetSnippetVersion(this CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (BWX40xK5tngQe2xSf9LN())
		{
			num = 3;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 1;
		}
		goto IL_003e;
		IL_0026:
		object obj = default;
		if (obj == null)
		{
			goto IL_0082;
		}
		object value = obj.ToString();
		goto IL_008e;
		IL_00a8:
		return 0;
		IL_003e:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 0:
			case 3:
				obj = G8HJ1WKwibKdomQXxRYC(TPlGIAKwDgFsg8CnhpH3(cells, range));
				num = 4;
				continue;
			default:
				goto IL_0082;
			case 5:
				goto IL_00a8;
			}
			break;
		}
		goto IL_0026;
		IL_008e:
		if (string.IsNullOrEmpty((string)value))
		{
			num = 5;
			if (BWX40xK5tngQe2xSf9LN())
			{
				goto IL_003e;
			}
			goto IL_00a8;
		}
		return x0SdnVKwnoXCiu8Xmb06(obj);
		IL_0082:
		value = null;
		goto IL_008e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsCell FindToolCellWithName(this CvsCellCollection cells, CvsCellRange range, string name, bool isInternal = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string snippetName = G8HJ1WKwibKdomQXxRYC(QmGJQ4KwVHVyqlCHFyKL(cells, range)).ToString();
		return (CvsCell)H71bUjKwfiIARdfKZglf(cells, EzSnippet.AssembleFullCellName(snippetName, name, isInternal));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsCell FindToolCellWithName(this CvsCellCollection cells, string toolName, string name, bool isInternal = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return cells.FindCellByName(EzSnippet.AssembleFullCellName(toolName, name, isInternal));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kVtxftKwLXOJwjeZrWnR(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object S1SNZMKwK7um0RMPAMZN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RCDjNmKw5bpL7400MVEf(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FJZd4jKwwSul5r2wiUOX(object P_0, object P_1, StringComparison P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).EndsWith((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fLHeNhKwJfrabLA9CkE3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NLgGkGKwa4Jl1moP6xBp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BWX40xK5tngQe2xSf9LN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool y6SJhPK5zCBjP1fIw2eX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nsfDdsKwet1iYZUkGbqT(object P_0, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0).GetSnippetGuidCell(range);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object o9YyrlKwOFAAeouIKLxg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).GetComment();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object P50LTJKwIBhsvcKWHAjR(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TPlGIAKwDgFsg8CnhpH3(object P_0, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0).GetSnippetVersionCell(range);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object G8HJ1WKwibKdomQXxRYC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).CellValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int x0SdnVKwnoXCiu8Xmb06(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToInt32(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QmGJQ4KwVHVyqlCHFyKL(object P_0, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0).GetEzToolNameCell(range);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object H71bUjKwfiIARdfKZglf(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0).FindCellByName((string)P_1);
	}
}
