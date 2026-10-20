using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cognex.InSight.Cell;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal.Analysis;

public class CvsCellReferenceInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<CellRefRange> _003C_003E9__20_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oVLtw2selrXpDV1ISILh();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oVLtw2selrXpDV1ISILh();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int _003CExpandSymbolicTags_003Eb__20_0(CellRefRange a, CellRefRange b)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TJktAwseethstVmouDCe(b) - TJktAwseethstVmouDCe(a);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void oVLtw2selrXpDV1ISILh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FjKrGXseMhDkSm81LVxU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HEif4KseQi9WE1Kg0VWD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int TJktAwseethstVmouDCe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellRefRange)P_0).TextStart;
		}
	}

	private CvsCell vAJXiJrjg6;

	private string qnUXdVgF0p;

	private readonly CvsCellReferenceTable EytXuLd3Ey;

	private CvsCellReference[] nI7XGtVnqK;

	private CvsCellReference[] iKnXDCnHjh;

	private List<CvsCellReference> deKXeLLCId;

	public CvsCell Cell
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return vAJXiJrjg6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!WsISe5kwyII2Z5FJT7R())
			{
				num = 1;
			}
			else
			{
				num = 4;
				if (!XpBKX44zLdmJY759tCU())
				{
					return;
				}
			}
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					if (vAJXiJrjg6 != value)
					{
						num = 3;
						continue;
					}
					return;
				case 3:
					vAJXiJrjg6 = value;
					break;
				case 5:
					return;
				}
				qnUXdVgF0p = null;
				num = 5;
			}
		}
	}

	public CvsCellReference[] Precedents
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return nI7XGtVnqK;
		}
	}

	public CvsCellReference[] Dependents
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WsISe5kwyII2Z5FJT7R();
			int num = ((!XpBKX44zLdmJY759tCU()) ? 4 : 2);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					if (iKnXDCnHjh != null)
					{
						break;
					}
					goto case 1;
				case 3:
					deKXeLLCId = null;
					num = 5;
					continue;
				case 1:
				case 4:
					iKnXDCnHjh = (CvsCellReference[])B5qpJJkL2kUc8OMm1Zc(deKXeLLCId);
					goto case 3;
				default:
					num = 3;
					if (true)
					{
						continue;
					}
					break;
				case 5:
					break;
				}
				break;
			}
			return iKnXDCnHjh;
		}
	}

	public string SymbolicExpression
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (qnUXdVgF0p == null)
			{
				qnUXdVgF0p = JGOXNWJFgG((string)Kg2M9BkDssw9tjTbPnM(vAJXiJrjg6));
			}
			return qnUXdVgF0p;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCellReferenceInfo(CvsCell cell, CvsCellReferenceTable table)
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
			case 5:
				deKXeLLCId = new List<CvsCellReference>();
				XpBKX44zLdmJY759tCU();
				if (!WsISe5kwyII2Z5FJT7R())
				{
					num = 6;
					continue;
				}
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 2:
			case 6:
				rGRjbFkh4O956ajp0so(this);
				goto case 1;
			default:
				num = 1;
				continue;
			case 1:
				vAJXiJrjg6 = cell;
				break;
			case 0:
				UbwWoEks5GyXGmI0JiD();
				num = 5;
				continue;
			case 3:
			case 4:
				break;
			case 7:
				return;
			}
			EytXuLd3Ey = table;
			num = 7;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SetPrecedents(CvsCellReference[] precedents)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nI7XGtVnqK = precedents;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void AddDependent(CvsCellReference dependent)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		deKXeLLCId.Add(dependent);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ToString(expandNames: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ToString(bool expandNames)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = ((!WsISe5kwyII2Z5FJT7R()) ? 1 : 8);
		string text2 = default;
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 9:
				if (expandNames)
				{
					goto case 2;
				}
				goto case 4;
			case 2:
			case 8:
				text2 = (string)zr9sGikSpaD1kpPnrHA(EytXuLd3Ey, eCEPXIk9vqPZCONUv8u(vAJXiJrjg6));
				num = 7;
				continue;
			case 4:
				text = (string)VbxcrFkHepmHHFfubIE(text, eCEPXIk9vqPZCONUv8u(vAJXiJrjg6).ToString(), eMHvXHkErvAhBaSUNi1(46422), SymbolicExpression);
				num = 5;
				continue;
			case 3:
				text = (string)F7d3E1kv8G6DG4iAZKQ(eMHvXHkErvAhBaSUNi1(46408), text2, kgbOBx7BanbFa22Hp9.ol99ukmDA(46414));
				goto case 4;
			default:
				num = 4;
				continue;
			case 6:
				text = (string)F7d3E1kv8G6DG4iAZKQ(text, eMHvXHkErvAhBaSUNi1(46432), YRIM3DkVie1WyfkTZNM(vAJXiJrjg6));
				num = 10;
				continue;
			case 5:
				if (EkWtfHkA6YMjuFrlO23(YRIM3DkVie1WyfkTZNM(vAJXiJrjg6)) > 0)
				{
					num = 6;
					continue;
				}
				break;
			case 7:
				if (text2 != null)
				{
					num = 3;
					continue;
				}
				goto case 4;
			case 0:
			case 1:
				text = "";
				num = 9;
				continue;
			case 10:
				break;
			}
			break;
		}
		return text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string JGOXNWJFgG(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		CvsCellReference cvsCellReference = default;
		List<CellRefRange> list = default;
		int num3 = default;
		CvsCellReference[] array = default;
		List<CellRefRange>.Enumerator enumerator = default;
		CvsCellRange cvsCellRange = default;
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				if (mpjrugkTNpSxxsEVjgG(cvsCellReference) != null)
				{
					list.Add((CellRefRange)mpjrugkTNpSxxsEVjgG(cvsCellReference));
					num = 3;
					break;
				}
				goto case 3;
			case 6:
			case 7:
			case 10:
				if (num3 >= array.Length)
				{
					goto case 2;
				}
				cvsCellReference = array[num3];
				goto case 0;
			case 9:
				list = new List<CellRefRange>();
				num = 1;
				if (XpBKX44zLdmJY759tCU())
				{
					break;
				}
				goto case 6;
			default:
				num = 0;
				break;
			case 5:
				num3 = 0;
				num = 6;
				break;
			case 1:
				array = nI7XGtVnqK;
				num = 5;
				break;
			case 3:
				num3++;
				_ = 1;
				num = ((!WsISe5kwyII2Z5FJT7R()) ? 10 : 2);
				break;
			case 2:
			case 8:
				list.Sort([MethodImpl(MethodImplOptions.NoInlining)] (CellRefRange a, CellRefRange b) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return _003C_003Ec.TJktAwseethstVmouDCe(b) - _003C_003Ec.TJktAwseethstVmouDCe(a);
				});
				enumerator = list.GetEnumerator();
				num = 11;
				break;
			case 4:
				Xw0DT6kUydjXSW29RxV(EytXuLd3Ey);
				num = 9;
				break;
			case 11:
				try
				{
					while (enumerator.MoveNext())
					{
						CellRefRange current = enumerator.Current;
						int num2 = 0;
						while (true)
						{
							switch (num2)
							{
							case 7:
								if (cvsCellRange.Columns != 1)
								{
									break;
								}
								goto case 8;
							default:
								num2 = 8;
								continue;
							case 8:
							{
								CvsCellReferenceTable eytXuLd3Ey = EytXuLd3Ey;
								cvsCellRange = A0Q1H0kdZvPNRVSLWdB(current);
								text = (string)zr9sGikSpaD1kpPnrHA(eytXuLd3Ey, cvsCellRange.Location);
								num2 = 2;
								continue;
							}
							case 1:
							case 5:
								if (cvsCellRange.Rows == 1)
								{
									num2 = 3;
									continue;
								}
								break;
							case 0:
								cvsCellRange = A0Q1H0kdZvPNRVSLWdB(current);
								_ = 1;
								if (!WsISe5kwyII2Z5FJT7R())
								{
									num2 = 5;
									if (WsISe5kwyII2Z5FJT7R())
									{
									}
								}
								else
								{
									num2 = 4;
								}
								continue;
							case 2:
								if (text == null)
								{
									break;
								}
								goto case 4;
							case 3:
								cvsCellRange = A0Q1H0kdZvPNRVSLWdB(current);
								num2 = 7;
								continue;
							case 4:
							case 6:
								P_0 = P_0.Substring(0, xdT1RMkiglLNpkK3yy0(current)) + (string)eMHvXHkErvAhBaSUNi1(46408) + text + (string)eMHvXHkErvAhBaSUNi1(46442) + (string)sDlp5VkqFyAItjTm5cy(P_0, current.TextEnd);
								num2 = 9;
								continue;
							case 9:
								break;
							}
							break;
						}
					}
					return P_0;
				}
				finally
				{
					((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return eCEPXIk9vqPZCONUv8u(vAJXiJrjg6).GetHashCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UbwWoEks5GyXGmI0JiD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rGRjbFkh4O956ajp0so(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XpBKX44zLdmJY759tCU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WsISe5kwyII2Z5FJT7R()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object B5qpJJkL2kUc8OMm1Zc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsCellReference>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation eCEPXIk9vqPZCONUv8u(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zr9sGikSpaD1kpPnrHA(object P_0, CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellReferenceTable)P_0).GetCellSymbolicName(location);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eMHvXHkErvAhBaSUNi1(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object F7d3E1kv8G6DG4iAZKQ(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VbxcrFkHepmHHFfubIE(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YRIM3DkVie1WyfkTZNM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int EkWtfHkA6YMjuFrlO23(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Kg2M9BkDssw9tjTbPnM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Xw0DT6kUydjXSW29RxV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellReferenceTable)P_0).Cells;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mpjrugkTNpSxxsEVjgG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellReference)P_0).ExpressionCellReference;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellRange A0Q1H0kdZvPNRVSLWdB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsReferenceRange)P_0).Range;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int xdT1RMkiglLNpkK3yy0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellRefRange)P_0).TextStart;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sDlp5VkqFyAItjTm5cy(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Substring(P_1);
	}
}
