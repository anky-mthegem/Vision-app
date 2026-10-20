using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows;
using Newtonsoft.Json.Linq;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

[Serializable]
public sealed class CvsCellClipboardData : ICvsCellClipboard
{
	private readonly byte[] sCUoJKltnG;

	public bool IsDataOnClipboard
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			int num2 = default;
			byte[] array = default;
			while (true)
			{
				switch (num)
				{
				case 8:
				case 9:
					if (num2 < array.Length)
					{
						if (array[num2] != sCUoJKltnG[num2])
						{
							goto case 6;
						}
						num2++;
						num = 9;
						if (!gjRMaKlaeSVvkKIxyEL())
						{
							break;
						}
						goto case 0;
					}
					num = 10;
					if (0 == 0)
					{
						break;
					}
					goto case 4;
				case 4:
					if (array.Length != sCUoJKltnG.Length)
					{
						num = 0;
						if (true)
						{
							break;
						}
						goto case 3;
					}
					num2 = 0;
					goto case 8;
				case 3:
					array = (byte[])BQbTyjlXMqcpii208Zg();
					num = 1;
					break;
				case 6:
				case 7:
					return false;
				case 0:
					return false;
				default:
					num = 8;
					if (true)
					{
						break;
					}
					goto case 1;
				case 1:
					if (array != null)
					{
						orKN0slRjjugLSvy4fb();
						num = ((!gjRMaKlaeSVvkKIxyEL()) ? 5 : 7);
						break;
					}
					goto case 0;
				case 2:
				case 5:
					if (sCUoJKltnG != null)
					{
						num = 4;
						break;
					}
					goto case 0;
				case 10:
					return true;
				}
			}
		}
	}

	public static bool ClipboardDataPresent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IDataObject dataObject = (IDataObject)ofWLGflpEroApq7ygdQ();
			if (dataObject != null)
			{
				return pE5VZil41oo7R2jeaMd(dataObject, e8yS6pl04mTtSVX4bM6(typeof(CvsCellClipboardData).TypeHandle));
			}
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CvsCellClipboardData(byte[] rawData)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 3:
				WnETVblnXT8Mpox52by();
				orKN0slRjjugLSvy4fb();
				num = (gjRMaKlaeSVvkKIxyEL() ? 4 : 0);
				continue;
			case 0:
			case 1:
				Mv1K1klGwaG3bSqKail(this);
				break;
			case 5:
				return;
			}
			sCUoJKltnG = rawData;
			num = 5;
			if (gjRMaKlaeSVvkKIxyEL())
			{
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] GetClipboard()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (gjRMaKlaeSVvkKIxyEL() ? 5 : 6);
		object obj = default;
		IDataObject dataObject = default;
		byte[] result = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				if (!(obj is CvsCellClipboardData))
				{
					break;
				}
				goto case 5;
			case 4:
				QHnMOml61DhrosIsUkQ(a22OD1lbL4b1t53U6UK());
				num = 2;
				continue;
			case 3:
				obj = LeGnuklktwyreKdqFU4(dataObject, e8yS6pl04mTtSVX4bM6(typeof(CvsCellClipboardData).TypeHandle));
				num = 8;
				continue;
			case 1:
				if (!pE5VZil41oo7R2jeaMd(dataObject, e8yS6pl04mTtSVX4bM6(typeof(CvsCellClipboardData).TypeHandle)))
				{
					break;
				}
				goto case 3;
			default:
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 6:
				result = null;
				num = 4;
				if (orKN0slRjjugLSvy4fb())
				{
					continue;
				}
				goto case 2;
			case 2:
				dataObject = (IDataObject)ofWLGflpEroApq7ygdQ();
				num = 9;
				continue;
			case 5:
			case 7:
				result = ((CvsCellClipboardData)obj).sCUoJKltnG;
				num = 10;
				if (true)
				{
					continue;
				}
				goto case 9;
			case 9:
				if (dataObject != null)
				{
					num = 1;
					continue;
				}
				break;
			case 10:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsCellRange GetCellRange()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellRange result = CvsCellRange.Empty;
		try
		{
			byte[] clipboard = GetClipboard();
			if (clipboard != null)
			{
				result = pmsNgplgZD9nsiNbJm6(((IEnumerable<JToken>)BYLBcClyWiSMRPUteAM(rxUt4elm6Kc504MivxK(nql7DglF7fJanP6Tbnx(Q1eNKKlf7JCX4Y7kc9A(), clipboard)), kgbOBx7BanbFa22Hp9.ol99ukmDA(35428))).Value<string>());
			}
		}
		catch
		{
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsCellClipboardData SetClipboard(byte[] buffer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		CvsCellClipboardData cvsCellClipboardData = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				if (buffer == null)
				{
					break;
				}
				_ = 0;
				if (orKN0slRjjugLSvy4fb())
				{
					num = 5;
					if (orKN0slRjjugLSvy4fb())
					{
						continue;
					}
					goto case 2;
				}
				num = 0;
				continue;
			case 2:
			case 5:
				cvsCellClipboardData = new CvsCellClipboardData(buffer);
				goto default;
			case 4:
				cvsCellClipboardData = null;
				num = 1;
				continue;
			default:
			{
				DataObject dataObject = new DataObject(cvsCellClipboardData);
				smdDZslZAEdHl62kNUv(dataObject, DataFormats.UnicodeText, kgbOBx7BanbFa22Hp9.ol99ukmDA(35442));
				M4WYJmlJiGpisodEmVW(dataObject, true);
				num = 6;
				continue;
			}
			case 6:
				break;
			}
			break;
		}
		return cvsCellClipboardData;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsCellClipboardData SetClipboard(byte[] buffer, string cellData)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (orKN0slRjjugLSvy4fb())
		{
			num = 1;
		}
		else
		{
			num = 4;
			if (!orKN0slRjjugLSvy4fb())
			{
				goto IL_00d5;
			}
		}
		CvsCellClipboardData cvsCellClipboardData = default;
		while (true)
		{
			switch (num)
			{
			default:
				QHnMOml61DhrosIsUkQ(Thread.CurrentThread);
				num = 6;
				continue;
			case 2:
				if (buffer == null)
				{
					break;
				}
				num = 5;
				if (orKN0slRjjugLSvy4fb())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 1:
				cvsCellClipboardData = null;
				num = 2;
				if (true)
				{
					continue;
				}
				goto case 6;
			case 6:
			{
				DataObject dataObject = new DataObject(cvsCellClipboardData);
				smdDZslZAEdHl62kNUv(dataObject, DataFormats.UnicodeText, cellData);
				M4WYJmlJiGpisodEmVW(dataObject, true);
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			}
			case 5:
				cvsCellClipboardData = new CvsCellClipboardData(buffer);
				goto default;
			case 7:
				break;
			}
			break;
		}
		goto IL_00d5;
		IL_00d5:
		return cvsCellClipboardData;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WnETVblnXT8Mpox52by()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Mv1K1klGwaG3bSqKail(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool orKN0slRjjugLSvy4fb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gjRMaKlaeSVvkKIxyEL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BQbTyjlXMqcpii208Zg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetClipboard();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object a22OD1lbL4b1t53U6UK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Thread.CurrentThread;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ApartmentState QHnMOml61DhrosIsUkQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Thread)P_0).GetApartmentState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ofWLGflpEroApq7ygdQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Clipboard.GetDataObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type e8yS6pl04mTtSVX4bM6(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pE5VZil41oo7R2jeaMd(object P_0, Type P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IDataObject)P_0).GetDataPresent(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LeGnuklktwyreKdqFU4(object P_0, Type P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IDataObject)P_0).GetData(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Q1eNKKlf7JCX4Y7kc9A()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Encoding.UTF8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nql7DglF7fJanP6Tbnx(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rxUt4elm6Kc504MivxK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return JObject.Parse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BYLBcClyWiSMRPUteAM(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((JObject)P_0).GetValue((string?)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellRange pmsNgplgZD9nsiNbJm6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellRange.TryParse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void smdDZslZAEdHl62kNUv(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDataObject)P_0).SetData((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void M4WYJmlJiGpisodEmVW(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Clipboard.SetDataObject(P_0, P_1);
	}
}
