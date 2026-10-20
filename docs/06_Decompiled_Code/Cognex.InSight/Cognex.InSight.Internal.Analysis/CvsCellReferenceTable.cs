using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using Cognex.InSight.Cell;
using Cognex.InSight.Sensor;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal.Analysis;

public class CvsCellReferenceTable : IEnumerable
{
	private CvsCellCollection DJEXVJROWJ;

	private CvsProcessorConstants D31XvsM1SD;

	private CvsFunctionTable h62XZ4AbSG;

	private readonly Dictionary<CvsCellLocation, CvsCellLocation> TbyX8Yyh5B;

	private readonly Dictionary<CvsCellLocation, CvsCellReferenceInfo> psjXz9vIe7;

	public CvsCellReferenceInfo this[CvsCellLocation location]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			psjXz9vIe7.TryGetValue(location, out var value);
			return value;
		}
	}

	public CvsCellCollection Cells
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DJEXVJROWJ;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<List<CvsCellLocation>> GetReferencePaths(CvsCellLocation destination, CvsCellLocation source)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		List<List<CvsCellLocation>> list = new List<List<CvsCellLocation>>();
		XXGXSiphB9(destination, source, list);
		return list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void XXGXSiphB9(CvsCellLocation P_0, CvsCellLocation P_1, List<List<CvsCellLocation>> P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		List<CvsCellLocation> list = new List<CvsCellLocation>();
		list.Add(P_1);
		MBKXr25cGq(P_0, list, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MBKXr25cGq(CvsCellLocation P_0, List<CvsCellLocation> P_1, List<List<CvsCellLocation>> P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellReferenceInfo cvsCellReferenceInfo = this[P_1[P_1.Count - 1]];
		if (cvsCellReferenceInfo == null)
		{
			return;
		}
		CvsCellReference[] dependents = cvsCellReferenceInfo.Dependents;
		CvsCellLocation cvsCellLocation = cvsCellReferenceInfo.Cell.Location;
		CvsCellReference[] array = dependents;
		foreach (CvsCellReference cvsCellReference in array)
		{
			if (!P_1.Contains(cvsCellReference.CellLocation))
			{
				if (cvsCellReference.CellLocation.Equals(P_0))
				{
					P_1.Add(cvsCellReference.CellLocation);
					P_2.Add(new List<CvsCellLocation>(P_1));
					P_1.RemoveAt(P_1.Count - 1);
				}
				else if (!cvsCellReference.CellLocation.Equals(cvsCellLocation))
				{
					P_1.Add(cvsCellReference.CellLocation);
					MBKXr25cGq(P_0, P_1, P_2);
					P_1.RemoveAt(P_1.Count - 1);
					cvsCellLocation = cvsCellReference.CellLocation;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetCellSymbolicName(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		CvsCell cvsCell = default;
		CvsCell cvsCell2 = default;
		CvsCellLocation value = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				if (CvsCell.IsNullOrEmpty(cvsCell))
				{
					break;
				}
				num = 6;
				if (!m1OsXnkjsOHqD0Z9jo0())
				{
					continue;
				}
				goto case 3;
			case 3:
			case 8:
				return (string)BIalISkWDnvKsUlBUCw(cvsCell2);
			default:
				num = 2;
				continue;
			case 4:
				if (BIalISkWDnvKsUlBUCw(cvsCell2) == null)
				{
					if (!TbyX8Yyh5B.TryGetValue(location, out value))
					{
						break;
					}
					goto case 2;
				}
				goto case 3;
			case 2:
				cvsCell = (CvsCell)S1YSt2kcmB0fA4OEmrc(DJEXVJROWJ, value);
				num = 5;
				continue;
			case 1:
			case 7:
				if (!P4jh61k2y8uXS73aNZu(cvsCell2))
				{
					num = 4;
					continue;
				}
				break;
			case 6:
				if (BIalISkWDnvKsUlBUCw(cvsCell) != null)
				{
					num = 9;
					continue;
				}
				break;
			case 0:
				cvsCell2 = (CvsCell)S1YSt2kcmB0fA4OEmrc(DJEXVJROWJ, location);
				uBOFCUkBm0V5pRGI5Qe();
				num = ((!m1OsXnkjsOHqD0Z9jo0()) ? 7 : 8);
				continue;
			case 9:
				return (string)zihfEAk7kKh0fNlML0W(46448) + (string)BIalISkWDnvKsUlBUCw(cvsCell);
			}
			break;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Update(CvsCellCollection cells, CvsInSight inSight)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (inSight == null)
		{
			throw new ArgumentNullException((string)zihfEAk7kKh0fNlML0W(46454));
		}
		return Update(cells, (CvsProcessorConstants)OddZlpkCIJlIJVwQcrQ(Mqe1tvktW28rGwXO52C(inSight)), inSight.FunctionTable);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool Update(CvsCellCollection cells, CvsProcessorConstants processorConstants, CvsFunctionTable functionTable)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 16;
		bool flag = default;
		CvsCell cvsCell = default;
		CvsCell cvsCell2 = default;
		bool flag2 = default;
		int num3 = default;
		Dictionary<CvsCellLocation, CvsCellReferenceInfo>.ValueCollection.Enumerator enumerator = default;
		while (true)
		{
			switch (num)
			{
			case 16:
				if (cells == null)
				{
					num = 11;
					continue;
				}
				flag = false;
				if (functionTable == h62XZ4AbSG)
				{
					num = 9;
					continue;
				}
				goto IL_01bb;
			case 3:
				if (Vc6jvTkNa3nZrjCDWIG(GUCOXEkY4TuWchqmZ74(cvsCell), GUCOXEkY4TuWchqmZ74(cvsCell2)))
				{
					goto case 18;
				}
				goto case 10;
			default:
				num = 10;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
				flag2 = true;
				goto case 0;
			case 12:
				if (!aOmeJykPRZgRHKfc3se(MlInqhkoFBuouRP5iBb(cvsCell), cvsCell2.Location))
				{
					num = 3;
					continue;
				}
				goto case 18;
			case 2:
				flag2 = false;
				_ = 1;
				num = ((!m1OsXnkjsOHqD0Z9jo0()) ? 6 : 21);
				continue;
			case 8:
				cvsCell2 = cells[num3];
				num = 12;
				if (0 == 0)
				{
					continue;
				}
				goto case 9;
			case 9:
				if (DJEXVJROWJ == null)
				{
					goto IL_01bb;
				}
				if (cells == DJEXVJROWJ)
				{
					num = 2;
					continue;
				}
				if (HVKiEMkKiOrRysZmYEL(cells) == HVKiEMkKiOrRysZmYEL(DJEXVJROWJ))
				{
					flag2 = false;
					num3 = 0;
					goto case 7;
				}
				num = 1;
				continue;
			case 18:
				flag2 = true;
				num = 0;
				continue;
			case 11:
				throw new ArgumentNullException((string)zihfEAk7kKh0fNlML0W(46472));
			case 10:
				if (!Vc6jvTkNa3nZrjCDWIG(pydaANkxrT9SSNPQBc9(cvsCell), cvsCell2.CellStateReference))
				{
					if (jWvLEpk19vREZd0LLdY(cvsCell) != jWvLEpk19vREZd0LLdY(cvsCell2))
					{
						num = 20;
						continue;
					}
					goto case 15;
				}
				num = 18;
				continue;
			case 14:
				h62XZ4AbSG = functionTable;
				num = 4;
				continue;
			case 20:
				flag = true;
				num = 15;
				if (!m1OsXnkjsOHqD0Z9jo0())
				{
					continue;
				}
				goto case 4;
			case 4:
				DJEXVJROWJ = cells;
				num = 17;
				if (uBOFCUkBm0V5pRGI5Qe())
				{
					continue;
				}
				goto case 17;
			case 17:
				if (!flag2)
				{
					enumerator = psjXz9vIe7.Values.GetEnumerator();
					num = 23;
					if (uBOFCUkBm0V5pRGI5Qe())
					{
						continue;
					}
					goto case 0;
				}
				eNDXCO2rjU();
				num = 22;
				continue;
			case 15:
				num3++;
				goto case 7;
			case 7:
			case 21:
				if (num3 < HVKiEMkKiOrRysZmYEL(cells))
				{
					cvsCell = (CvsCell)EEQIERk5K6paWqvq7aJ(DJEXVJROWJ, num3);
					num = 8;
					if (!m1OsXnkjsOHqD0Z9jo0())
					{
						continue;
					}
					goto case 8;
				}
				num = 13;
				continue;
			case 0:
			case 5:
			case 6:
			case 13:
			case 19:
				D31XvsM1SD = processorConstants;
				num = 14;
				continue;
			case 23:
				try
				{
					while (enumerator.MoveNext())
					{
						CvsCellReferenceInfo current = enumerator.Current;
						uBOFCUkBm0V5pRGI5Qe();
						int num2;
						if (!m1OsXnkjsOHqD0Z9jo0())
						{
							num2 = 2;
							if (m1OsXnkjsOHqD0Z9jo0())
							{
							}
						}
						else
						{
							num2 = 3;
							if (false)
							{
								continue;
							}
						}
						switch (num2)
						{
						case 0:
						case 2:
							IyeWgvk3a9WSDnZjb1w(current, S1YSt2kcmB0fA4OEmrc(Cells, MlInqhkoFBuouRP5iBb(J38tmWkrCDU6V5I9aXV(current))));
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
				}
				break;
			case 22:
				break;
				IL_01bb:
				flag2 = true;
				num = 19;
				if (uBOFCUkBm0V5pRGI5Qe())
				{
					continue;
				}
				goto case 18;
			}
			break;
		}
		return flag2 | flag;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void eNDXCO2rjU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 28;
		int num3 = default;
		IEnumerator<CvsCell> enumerator = default;
		CvsCellReference cvsCellReference2 = default;
		int num2 = default;
		int num4 = default;
		CellRefRange[] cellReferences = default;
		CvsCell cvsCell = default;
		CvsCellReference[] array = default;
		int num7 = default;
		CvsCellCollection dJEXVJROWJ = default;
		CvsCell cvsCell2 = default;
		CvsCellReferenceInfo cvsCellReferenceInfo = default;
		CvsCellReference cvsCellReference = default;
		CvsCellReference[] array2 = default;
		int num6 = default;
		while (true)
		{
			switch (num)
			{
			case 20:
				num3 = 0;
				num = 22;
				break;
			case 13:
				try
				{
					while (enumerator.MoveNext())
					{
						CvsCell current = enumerator.Current;
						_ = 1;
						int num5;
						if (!m1OsXnkjsOHqD0Z9jo0())
						{
							num5 = 2;
							if (!uBOFCUkBm0V5pRGI5Qe())
							{
								goto IL_004f;
							}
						}
						else
						{
							num5 = 3;
							if (m1OsXnkjsOHqD0Z9jo0())
							{
								continue;
							}
						}
						switch (num5)
						{
						case 0:
						case 2:
							break;
						default:
							continue;
						}
						goto IL_004f;
						IL_004f:
						WneJOOkeFVAtdSiAoxS(psjXz9vIe7[current.Location], cvsCellReference2);
					}
				}
				finally
				{
					if (enumerator != null)
					{
						qVxUiDkufNkIGhwDhWm(enumerator);
					}
				}
				num3++;
				num = 26;
				if (0 == 0)
				{
					break;
				}
				goto case 19;
			case 19:
				num2++;
				goto case 11;
			case 11:
			{
				if (num4 >= cellReferences.Length)
				{
					num = 18;
					break;
				}
				CvsCellReference cvsCellReference3 = new CvsCellReference(MlInqhkoFBuouRP5iBb(cvsCell), cellReferences[num4]);
				array[num2] = cvsCellReference3;
				num = 5;
				if (uBOFCUkBm0V5pRGI5Qe())
				{
					break;
				}
				goto case 9;
			}
			case 2:
				FrBX237TeK();
				num = 29;
				break;
			case 3:
			case 10:
				if (num7 >= HVKiEMkKiOrRysZmYEL(dJEXVJROWJ))
				{
					num = 2;
					break;
				}
				cvsCell = (CvsCell)EEQIERk5K6paWqvq7aJ(dJEXVJROWJ, num7);
				uBOFCUkBm0V5pRGI5Qe();
				if (!m1OsXnkjsOHqD0Z9jo0())
				{
					num = 6;
					if (uBOFCUkBm0V5pRGI5Qe())
					{
						break;
					}
					goto case 5;
				}
				num = 21;
				break;
			case 4:
				psjXz9vIe7.Add(cvsCell2.Location, new CvsCellReferenceInfo(cvsCell2, this));
				num = 25;
				break;
			case 18:
				HJ20xMkQ7KWhEnX6vQ4(cvsCellReferenceInfo, array);
				num = 16;
				break;
			case 15:
				cellReferences = CvsParse.Parse(h62XZ4AbSG, D31XvsM1SD, cvsCell.Expression, 0).CellReferences;
				cvsCellReference = null;
				num = 1;
				break;
			case 17:
				num7++;
				num = 10;
				break;
			case 23:
				dJEXVJROWJ = DJEXVJROWJ;
				num = 0;
				if (!m1OsXnkjsOHqD0Z9jo0())
				{
					break;
				}
				goto case 28;
			case 28:
				EmRUIWkOHy3SKuJGpcp(psjXz9vIe7);
				num = 23;
				if (0 == 0)
				{
					break;
				}
				goto case 22;
			case 22:
			case 26:
				if (num3 < array2.Length)
				{
					cvsCellReference2 = array2[num3];
					enumerator = dJEXVJROWJ.GetCells(ziLWKDklus08ikVRXWZ(cvsCellReference2)).GetEnumerator();
					num = 13;
				}
				else
				{
					num = 17;
				}
				break;
			case 0:
				num6 = 0;
				num = 9;
				break;
			case 5:
				num4++;
				num = 19;
				break;
			case 9:
			case 24:
				if (num6 < HVKiEMkKiOrRysZmYEL(dJEXVJROWJ))
				{
					cvsCell2 = (CvsCell)EEQIERk5K6paWqvq7aJ(dJEXVJROWJ, num6);
					num = 4;
					break;
				}
				num7 = 0;
				num = 3;
				if (true)
				{
					break;
				}
				goto case 16;
			case 16:
				array2 = array;
				num = 20;
				if (0 == 0)
				{
					break;
				}
				goto case 7;
			case 7:
			case 12:
			case 21:
				num4 = 0;
				num = 11;
				if (true)
				{
					break;
				}
				goto case 25;
			case 25:
				num6++;
				num = 24;
				break;
			case 1:
				if (cvsCell.CellStateReference != null && !y2VxbrkMyvUdVPiBwEp(cvsCell))
				{
					try
					{
						cvsCellReference = new CvsCellReference(MlInqhkoFBuouRP5iBb(cvsCell), new CvsCellRange((string)pydaANkxrT9SSNPQBc9(cvsCell)), isCellStateReference: true);
					}
					catch (Exception)
					{
						cvsCellReference = null;
					}
				}
				if (cvsCellReference == null)
				{
					array = new CvsCellReference[cellReferences.Length];
					num = 27;
					break;
				}
				array = new CvsCellReference[cellReferences.Length + 1];
				array[0] = cvsCellReference;
				num = 14;
				if (0 == 0)
				{
					break;
				}
				goto case 6;
			case 6:
			case 8:
				cvsCellReferenceInfo = psjXz9vIe7[MlInqhkoFBuouRP5iBb(cvsCell)];
				num = 15;
				break;
			case 14:
				num2 = 1;
				goto case 7;
			case 27:
				num2 = 0;
				goto case 7;
			default:
				num = 7;
				if (false)
				{
					return;
				}
				break;
			case 29:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FrBX237TeK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (uBOFCUkBm0V5pRGI5Qe())
		{
			num = 2;
			if (!uBOFCUkBm0V5pRGI5Qe())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_006e;
			}
		}
		goto IL_009e;
		IL_009e:
		IEnumerator<CvsCell> enumerator = default;
		CvsCell cvsCell = default;
		int num3 = default;
		CvsCellLocation value = default;
		CvsCellLocation cvsCellLocation = default;
		CvsCellCollection dJEXVJROWJ = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				break;
			case 6:
				return;
			case 0:
			case 2:
				vOFc3DkIk8YpwCTh7mr(TbyX8Yyh5B);
				break;
			case 4:
				goto IL_006e;
			case 5:
				return;
			default:
				num = 4;
				if (m1OsXnkjsOHqD0Z9jo0())
				{
				}
				continue;
			case 7:
				try
				{
					while (wCgmb1kaDCGpA5tZ3iJ(enumerator))
					{
						CvsCell current = enumerator.Current;
						_ = 0;
						int num2 = ((!uBOFCUkBm0V5pRGI5Qe()) ? 10 : 2);
						while (true)
						{
							switch (num2)
							{
							case 9:
								cvsCell = current;
								num3 = 100;
								num2 = 3;
								continue;
							case 7:
							case 10:
								num3--;
								num2 = 8;
								if (m1OsXnkjsOHqD0Z9jo0())
								{
								}
								continue;
							case 6:
								if (num3 > 0)
								{
									num2 = 11;
									continue;
								}
								break;
							case 0:
							case 2:
								if (current.Name == null)
								{
									num2 = 1;
									continue;
								}
								break;
							case 12:
								TbyX8Yyh5B[MlInqhkoFBuouRP5iBb(current)] = value;
								num2 = 14;
								continue;
							case 1:
								value = CvsCellLocation.Invalid;
								num2 = 9;
								continue;
							case 11:
								if (!value.IsValid)
								{
									break;
								}
								num2 = 12;
								if (0 == 0)
								{
									continue;
								}
								goto case 4;
							case 4:
								value = cvsCellLocation;
								if (BIalISkWDnvKsUlBUCw(current) == null)
								{
									num2 = 5;
									continue;
								}
								goto case 6;
							case 5:
								cvsCell = (CvsCell)S1YSt2kcmB0fA4OEmrc(dJEXVJROWJ, cvsCellLocation);
								goto case 13;
							default:
								num2 = 13;
								continue;
							case 13:
								if (!P4jh61k2y8uXS73aNZu(cvsCell))
								{
									goto case 7;
								}
								goto case 6;
							case 3:
							case 8:
								if (num3 > 0)
								{
									cvsCellLocation = HVcWQukRrW5KkUYvVHr(GUCOXEkY4TuWchqmZ74(cvsCell));
									if (cvsCellLocation.IsValid)
									{
										num2 = 4;
										if (0 == 0)
										{
											continue;
										}
									}
									goto case 6;
								}
								num2 = 6;
								if (uBOFCUkBm0V5pRGI5Qe())
								{
									continue;
								}
								break;
							case 14:
								break;
							}
							break;
						}
					}
					return;
				}
				finally
				{
					enumerator?.Dispose();
				}
			}
			break;
		}
		goto IL_002a;
		IL_006e:
		if (dJEXVJROWJ != null)
		{
			enumerator = dJEXVJROWJ.GetEnumerator();
			num = 7;
		}
		else
		{
			num = 6;
			if (!uBOFCUkBm0V5pRGI5Qe())
			{
				return;
			}
		}
		goto IL_009e;
		IL_002a:
		if (DJEXVJROWJ == null)
		{
			num = 5;
			goto IL_009e;
		}
		dJEXVJROWJ = DJEXVJROWJ;
		goto IL_006e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellLocation GetFirstErrorPrecedent(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		m1OsXnkjsOHqD0Z9jo0();
		int num = ((!uBOFCUkBm0V5pRGI5Qe()) ? 4 : 7);
		CvsCellReferenceInfo cvsCellReferenceInfo = default;
		CvsCellReference[] array = default;
		int num3 = default;
		CvsCellReference cvsCellReference = default;
		IEnumerator<CvsCell> enumerator = default;
		CvsCellLocation result = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 7:
				cvsCellReferenceInfo = this[location];
				num = 9;
				continue;
			case 6:
				array = (CvsCellReference[])KdsRD2knr9nAIBC86XG(cvsCellReferenceInfo);
				goto case 3;
			case 9:
				if (cvsCellReferenceInfo != null)
				{
					num = 6;
					continue;
				}
				goto case 10;
			default:
				num = 2;
				continue;
			case 1:
			case 5:
				if (num3 < array.Length)
				{
					cvsCellReference = array[num3];
					goto case 2;
				}
				num = 10;
				continue;
			case 8:
				try
				{
					while (enumerator.MoveNext())
					{
						CvsCell current = enumerator.Current;
						uBOFCUkBm0V5pRGI5Qe();
						int num2;
						if (!m1OsXnkjsOHqD0Z9jo0())
						{
							num2 = 2;
							if (m1OsXnkjsOHqD0Z9jo0())
							{
							}
						}
						else
						{
							num2 = 3;
						}
						while (true)
						{
							switch (num2)
							{
							case 0:
							case 2:
								if (!jWvLEpk19vREZd0LLdY(current))
								{
									goto end_IL_011a;
								}
								goto default;
							default:
								result = MlInqhkoFBuouRP5iBb(current);
								num2 = 4;
								if (0 == 0)
								{
									continue;
								}
								break;
							case 4:
								break;
							}
							goto end_IL_007c;
							continue;
							end_IL_011a:
							break;
						}
					}
				}
				finally
				{
					enumerator?.Dispose();
				}
				num3++;
				num = 5;
				continue;
			case 2:
				enumerator = ((CvsCellCollection)MaXSXwkGXo0yA6MUEAt(DJEXVJROWJ, ziLWKDklus08ikVRXWZ(cvsCellReference))).GetEnumerator();
				num = 8;
				continue;
			case 3:
			case 4:
				num3 = 0;
				num = 1;
				continue;
			case 10:
				{
					return CvsCellLocation.Invalid;
				}
				end_IL_007c:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetText(TextWriter tw, bool precedents, CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		exUXyOMymU(tw, precedents, cellRange, 0, new List<CvsCellLocation>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void exUXyOMymU(TextWriter P_0, bool P_1, CvsCellRange P_2, int P_3, List<CvsCellLocation> P_4)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		foreach (CvsCellLocation item in P_2)
		{
			CvsCellReferenceInfo cvsCellReferenceInfo = this[item];
			if (cvsCellReferenceInfo != null && !P_4.Contains(item))
			{
				P_4.Add(item);
				P_0.Write(new string(' ', P_3));
				P_0.WriteLine(cvsCellReferenceInfo.ToString());
				CvsCellReference[] array = (P_1 ? cvsCellReferenceInfo.Precedents : cvsCellReferenceInfo.Dependents);
				foreach (CvsCellReference cvsCellReference in array)
				{
					exUXyOMymU(P_0, P_1, cvsCellReference.ReferencedRange, P_3 + 1, P_4);
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (IEnumerator)WU7ETxkX2D5DhV6Zpx9(psjXz9vIe7);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellReferenceTable()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!uBOFCUkBm0V5pRGI5Qe()) ? 4 : 5);
		while (true)
		{
			switch (num)
			{
			case 1:
				TbyX8Yyh5B = new Dictionary<CvsCellLocation, CvsCellLocation>();
				num = 2;
				break;
			default:
				heEteEkb0exIHyf0KtT(this);
				num = 6;
				break;
			case 0:
			case 5:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 1;
				break;
			case 2:
				psjXz9vIe7 = new Dictionary<CvsCellLocation, CvsCellReferenceInfo>();
				goto default;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uBOFCUkBm0V5pRGI5Qe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool m1OsXnkjsOHqD0Z9jo0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object S1YSt2kcmB0fA4OEmrc(object P_0, CvsCellLocation cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[cell];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool P4jh61k2y8uXS73aNZu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCell.IsNullOrEmpty((CvsCell)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BIalISkWDnvKsUlBUCw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zihfEAk7kKh0fNlML0W(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Mqe1tvktW28rGwXO52C(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Sensor;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OddZlpkCIJlIJVwQcrQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsSensor)P_0).ProcessorConstants;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int HVKiEMkKiOrRysZmYEL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EEQIERk5K6paWqvq7aJ(object P_0, int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[index];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation MlInqhkoFBuouRP5iBb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool aOmeJykPRZgRHKfc3se(CvsCellLocation left, CvsCellLocation right)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return left != right;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GUCOXEkY4TuWchqmZ74(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Vc6jvTkNa3nZrjCDWIG(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 != (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pydaANkxrT9SSNPQBc9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).CellStateReference;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jWvLEpk19vREZd0LLdY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Error;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object J38tmWkrCDU6V5I9aXV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellReferenceInfo)P_0).Cell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IyeWgvk3a9WSDnZjb1w(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCellReferenceInfo)P_0).Cell = (CvsCell)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EmRUIWkOHy3SKuJGpcp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Dictionary<CvsCellLocation, CvsCellReferenceInfo>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool y2VxbrkMyvUdVPiBwEp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Hidden;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HJ20xMkQ7KWhEnX6vQ4(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCellReferenceInfo)P_0).SetPrecedents((CvsCellReference[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellRange ziLWKDklus08ikVRXWZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellReference)P_0).ReferencedRange;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WneJOOkeFVAtdSiAoxS(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCellReferenceInfo)P_0).AddDependent((CvsCellReference)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qVxUiDkufNkIGhwDhWm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vOFc3DkIk8YpwCTh7mr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Dictionary<CvsCellLocation, CvsCellLocation>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation HVcWQukRrW5KkUYvVHr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.TryParse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wCgmb1kaDCGpA5tZ3iJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KdsRD2knr9nAIBC86XG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellReferenceInfo)P_0).Precedents;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MaXSXwkGXo0yA6MUEAt(object P_0, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0).GetCells(range);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WU7ETxkX2D5DhV6Zpx9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerable)P_0).GetEnumerator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void heEteEkb0exIHyf0KtT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
