using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Cognex.Cnx.Data.Implementation;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Cell;

[Serializable]
public sealed class CvsCellCollection : IEnumerable<CvsCell>, IEnumerable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public CvsCellCollection _003C_003E4__this;

		public CvsCellFormat defaultFormat;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass18_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			jnp7i3seXtlCFRvsLwWO();
			JeXLoisebEJI0dZm8GAU(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal CvsCellFormat _003CGetCurrentFormatting_003Eb__0(CvsCellLocation location)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003E4__this.UQ7ftGmK4J(location, defaultFormat);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jnp7i3seXtlCFRvsLwWO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void JeXLoisebEJI0dZm8GAU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool saUNDQsene9OwiXljBOJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WSFloKseGMskYD1bC4rh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly CnxHashArray OYLfWjNEJP;

	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OYLfWjNEJP.Count;
		}
	}

	public CvsCell this[string cell]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CvsCellLocation cvsCellLocation = new CvsCellLocation(cell);
			return (CvsCell)OYLfWjNEJP.GetItem(cvsCellLocation.GetHashCode());
		}
	}

	public CvsCell this[int index]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (CvsCell)ivaKoWFT2d4qhACPiMg(OYLfWjNEJP, index);
		}
	}

	public CvsCell this[CvsCellLocation cell]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (CvsCell)tV9nI8FdnEuqnh5ruQV(OYLfWjNEJP, cell.GetHashCode());
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsCell[] Items
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CvsCell[] array = new CvsCell[Count];
			((ICollection)OYLfWjNEJP).CopyTo((Array)array, 0);
			return array;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellCollection()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CaLXcrFVmYClwptWjA3();
		int num = ((!nELvC0FHTNRuPat8m4v()) ? 4 : 2);
		while (true)
		{
			switch (num)
			{
			case 3:
				OYLfWjNEJP = new CnxHashArray();
				num = 5;
				break;
			case 1:
			case 4:
				BdMgIGFDcbXi0i1FPNH(this);
				goto case 3;
			default:
				num = 3;
				break;
			case 0:
			case 2:
				nc3MDmFAUtyChvLiBCF();
				goto case 1;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellCollection(CvsCellCollection other)
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
			case 0:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				CaLXcrFVmYClwptWjA3();
				num = ((!nELvC0FHTNRuPat8m4v()) ? 3 : 4);
				continue;
			case 1:
			case 4:
				BdMgIGFDcbXi0i1FPNH(this);
				break;
			case 5:
				return;
			}
			OYLfWjNEJP = new CnxHashArray(other.OYLfWjNEJP);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int IndexOf(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return fx359lFUjD3MgXlhE7V(OYLfWjNEJP, location.GetHashCode());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCell GetCell(int row, int column)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (CvsCell)tV9nI8FdnEuqnh5ruQV(OYLfWjNEJP, JvBvkQFiRrikrL0Blwg(row, column));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellInfoCollection CreateCellInfoCollection()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!CaLXcrFVmYClwptWjA3())
		{
			num = 2;
		}
		else
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_0078;
			}
		}
		IEnumerator<CvsCell> enumerator = default;
		CvsCellInfoCollection cvsCellInfoCollection = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				enumerator = GetEnumerator();
				break;
			default:
				goto IL_0056;
			case 0:
			case 2:
				cvsCellInfoCollection = new CvsCellInfoCollection();
				goto case 1;
			case 4:
				break;
			}
			break;
			IL_0056:
			num = 4;
		}
		goto IL_0078;
		IL_0078:
		try
		{
			while (QHvUdZF2biOo4T8EXWg(enumerator))
			{
				CvsCell current = enumerator.Current;
				_ = 1;
				int num2 = (CaLXcrFVmYClwptWjA3() ? 2 : 3);
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_009a;
					case 0:
					case 3:
						if (!O8jEKUFBNs2fAD2ebsA(iCh3ONFq6C8kKGJHiIo(current)))
						{
							goto IL_009a;
						}
						break;
					case 4:
						break;
					}
					break;
					IL_009a:
					GQjyivFcF1jKDOaHWZg(cvsCellInfoCollection, u8A4NOFjNBYsTR6egZT(current));
					num2 = 4;
				}
			}
			return cvsCellInfoCollection;
		}
		finally
		{
			enumerator?.Dispose();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<CvsCogCellResult> CreateCogCellResultList(CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		List<CvsCogCellResult> list = new List<CvsCogCellResult>();
		using IEnumerator<CvsCell> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			CvsCell current = enumerator.Current;
			if (range.Contains(current.Location))
			{
				list.Add(current.CellResult);
			}
		}
		return list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<CvsCellFormat> GetCurrentFormatting(CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		List<CvsCellFormat> list = new List<CvsCellFormat>();
		using IEnumerator<CvsCell> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			CvsCell current = enumerator.Current;
			if (range.Contains(current.Location))
			{
				CvsCellFormat cellFormat = current.CellResult.GetCellFormat();
				if (cellFormat != null)
				{
					list.Add(cellFormat);
				}
			}
		}
		return list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<CvsCellFormat> GetCurrentFormatting(CvsCellRange range, CvsCellFormat defaultFormat)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass18_0();
		CS_0024_003C_003E8__locals5._003C_003E4__this = this;
		CS_0024_003C_003E8__locals5.defaultFormat = defaultFormat;
		if (CS_0024_003C_003E8__locals5.defaultFormat == null)
		{
			throw new ArgumentNullException(kgbOBx7BanbFa22Hp9.ol99ukmDA(46990));
		}
		return range.Select([MethodImpl(MethodImplOptions.NoInlining)] (CvsCellLocation location) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CS_0024_003C_003E8__locals5._003C_003E4__this.UQ7ftGmK4J(location, CS_0024_003C_003E8__locals5.defaultFormat);
		}).ToList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<CvsCellFormat> GetCurrentFormatting()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		List<CvsCellFormat> list = new List<CvsCellFormat>();
		using IEnumerator<CvsCell> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			CvsCellFormat cellFormat = enumerator.Current.CellResult.GetCellFormat();
			if (cellFormat != null)
			{
				list.Add(cellFormat);
			}
		}
		return list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCell FindCellByName(string name)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IEnumerator<CvsCell> enumerator = GetEnumerator();
		CvsCell result = default;
		try
		{
			while (QHvUdZF2biOo4T8EXWg(enumerator))
			{
				CvsCell current = enumerator.Current;
				_ = 0;
				int num;
				if (nELvC0FHTNRuPat8m4v())
				{
					num = 3;
					if (!nELvC0FHTNRuPat8m4v())
					{
						goto IL_003d;
					}
				}
				else
				{
					num = 2;
				}
				goto IL_0060;
				IL_0060:
				switch (num)
				{
				case 0:
				case 3:
					break;
				default:
					goto IL_0089;
				case 4:
					goto IL_00bb;
				}
				goto IL_003d;
				IL_003d:
				if (!vFVNmPFWvhYbtMCZuXF(iCh3ONFq6C8kKGJHiIo(current), name))
				{
					continue;
				}
				goto IL_0089;
				IL_0089:
				result = current;
				num = 4;
				if (true)
				{
					goto IL_0060;
				}
				goto IL_00bb;
			}
		}
		finally
		{
			if (enumerator != null)
			{
				Ou7qrvF7l0P0cqCMrCG(enumerator);
			}
		}
		return null;
		IL_00bb:
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StoreItem(CvsCell cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		OYLfWjNEJP.StoreItem(cell);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void Remove(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		zuoheiFtZS0meQpaehs(OYLfWjNEJP, location.GetHashCode());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerable)OYLfWjNEJP).GetEnumerator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<CvsCell> GetEnumerator()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return OYLfWjNEJP.Cast<CvsCell>().GetEnumerator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellCollection GetCells(int row, int column, int rows, int columns)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetCells(new CvsCellRange(row, column, rows, columns));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellCollection GetCells(CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		int num2 = default;
		CvsCell cvsCell = default;
		CvsCellLocation cvsCellLocation = default;
		CvsCellCollection cvsCellCollection = default;
		int hashCode = default;
		while (true)
		{
			switch (num)
			{
			case 4:
			case 9:
				if (num2 >= Count)
				{
					num = 13;
					if (0 == 0)
					{
						continue;
					}
					goto case 8;
				}
				cvsCell = this[num2];
				if (!range.Contains(R37l7eFCabN1f79E2pw(cvsCell)))
				{
					cvsCellLocation = R37l7eFCabN1f79E2pw(cvsCell);
					num = 6;
					continue;
				}
				goto case 0;
			case 8:
				cvsCellLocation = range.LastLocation;
				num = 3;
				continue;
			case 11:
				if (num2 < 0)
				{
					num = 12;
					if (CaLXcrFVmYClwptWjA3())
					{
					}
					continue;
				}
				goto case 8;
			case 0:
			case 7:
				TITmy1FKAsaj7NvY4w2(cvsCellCollection.OYLfWjNEJP, cvsCell);
				num = 10;
				continue;
			case 6:
				if (cvsCellLocation.GetHashCode() > hashCode)
				{
					break;
				}
				goto case 10;
			case 10:
				num2++;
				num = 4;
				if (!CaLXcrFVmYClwptWjA3())
				{
					continue;
				}
				goto case 3;
			case 3:
				hashCode = cvsCellLocation.GetHashCode();
				goto case 4;
			default:
				num = 9;
				continue;
			case 12:
				num2 = ~num2;
				num = 8;
				continue;
			case 1:
			case 5:
				num2 = IndexOf(range.Location);
				num = 11;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
				cvsCellCollection = new CvsCellCollection();
				nELvC0FHTNRuPat8m4v();
				num = ((!CaLXcrFVmYClwptWjA3()) ? 5 : 0);
				continue;
			case 13:
				break;
			}
			break;
		}
		return cvsCellCollection;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CvsCellFormat UQ7ftGmK4J(CvsCellLocation P_0, CvsCellFormat P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (nELvC0FHTNRuPat8m4v())
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_0080;
		IL_0026:
		CvsCell cvsCell = this[P_0];
		object obj;
		if (cvsCell == null)
		{
			num = 1;
			if (true)
			{
				goto IL_0080;
			}
		}
		else
		{
			CvsCogCellResult cellResult = cvsCell.CellResult;
			if (cellResult != null)
			{
				obj = W3HQNWF5VETAvXafLrL(cellResult);
				goto IL_004b;
			}
		}
		goto IL_0040;
		IL_005c:
		obj = null;
		goto IL_004b;
		IL_004b:
		CvsCellFormat cvsCellFormat = (CvsCellFormat)obj;
		if (cvsCellFormat != null)
		{
			num = 5;
			goto IL_0080;
		}
		CvsCellFormat cvsCellFormat2 = new CvsCellFormat(P_1);
		M5ybCcFoFbTSgpKa0ps(cvsCellFormat2, P_0);
		return cvsCellFormat2;
		IL_0040:
		obj = null;
		goto IL_004b;
		IL_0080:
		switch (num)
		{
		case 0:
		case 4:
			break;
		default:
			goto IL_0040;
		case 1:
			goto IL_005c;
		case 5:
			return cvsCellFormat;
		}
		goto IL_0026;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nc3MDmFAUtyChvLiBCF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BdMgIGFDcbXi0i1FPNH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nELvC0FHTNRuPat8m4v()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CaLXcrFVmYClwptWjA3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int fx359lFUjD3MgXlhE7V(object P_0, int hashCode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CnxHashArray)P_0).IndexOf(hashCode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ivaKoWFT2d4qhACPiMg(object P_0, int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CnxHashArray)P_0)[index];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tV9nI8FdnEuqnh5ruQV(object P_0, int hashCode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CnxHashArray)P_0).GetItem(hashCode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int JvBvkQFiRrikrL0Blwg(int row, int column)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.GetHashCode(row, column);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iCh3ONFq6C8kKGJHiIo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool O8jEKUFBNs2fAD2ebsA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object u8A4NOFjNBYsTR6egZT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).GetCellInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GQjyivFcF1jKDOaHWZg(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCellInfoCollection)P_0).Add((CvsCellInfo)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QHvUdZF2biOo4T8EXWg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vFVNmPFWvhYbtMCZuXF(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ou7qrvF7l0P0cqCMrCG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int zuoheiFtZS0meQpaehs(object P_0, int hashCode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CnxHashArray)P_0).RemoveAll(hashCode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation R37l7eFCabN1f79E2pw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TITmy1FKAsaj7NvY4w2(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CnxHashArray)P_0).Add(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object W3HQNWF5VETAvXafLrL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).GetCellFormat();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void M5ybCcFoFbTSgpKa0ps(object P_0, CvsCellLocation value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCellFormat)P_0).Location = value;
	}
}
