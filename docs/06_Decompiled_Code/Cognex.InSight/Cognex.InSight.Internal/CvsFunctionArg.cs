using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Cognex.Cnx.Data;
using Cognex.InSight.Remoting.Serialization;
using Newtonsoft.Json;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

[Serializable]
public sealed class CvsFunctionArg
{
	private readonly object YLgLjt3Ig2;

	[CompilerGenerated]
	private int d2DLcKdYro;

	[CompilerGenerated]
	private CvsFunctionArgEnum[] xOeL5JLwTF;

	[CompilerGenerated]
	private int nyrLYjpv9I;

	[CompilerGenerated]
	private readonly string dLbL7he7bs;

	[CompilerGenerated]
	private readonly string Vp1LmUgA0e;

	[CompilerGenerated]
	private string QTJLnoxUUA;

	[CompilerGenerated]
	private string BJIL9TlQQk;

	[CompilerGenerated]
	private string d6wLUfWC4X;

	[CompilerGenerated]
	private string TpJL0iBdab;

	[CompilerGenerated]
	private double G4xLwQEsqV;

	[CompilerGenerated]
	private double PBqLRY9sSR;

	public int Flags
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return d2DLcKdYro;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			d2DLcKdYro = value;
		}
	}

	public CvsFunctionArgEnum[] Enums
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xOeL5JLwTF;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xOeL5JLwTF = value;
		}
	}

	public int Index
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return nyrLYjpv9I;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			nyrLYjpv9I = value;
		}
	}

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return dLbL7he7bs;
		}
	}

	public string DisplayName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Vp1LmUgA0e;
		}
	}

	public string SummaryName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return QTJLnoxUUA;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QTJLnoxUUA = value;
		}
	}

	public string DisplaySummaryName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return BJIL9TlQQk;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			BJIL9TlQQk = value;
		}
	}

	public string FullName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (!LuuIT9X1FORoLVW5Z2V(SummaryName))
			{
				return (string)MiuoS1XrmgsLXP2HAlY(pOjgRxXtLBtBI2ZL7vE(7730), SummaryName, Name);
			}
			return Name;
		}
	}

	public string SummaryHelp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return d6wLUfWC4X;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			d6wLUfWC4X = value;
		}
	}

	public string Help
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TpJL0iBdab;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			TpJL0iBdab = value;
		}
	}

	public double MinVal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return G4xLwQEsqV;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			G4xLwQEsqV = value;
		}
	}

	public double MaxVal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PBqLRY9sSR;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			PBqLRY9sSR = value;
		}
	}

	[JsonIgnore]
	public CvsFunctionArgTypes Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (CvsFunctionArgTypes)(Flags & 0xFF);
		}
	}

	[JsonIgnore]
	internal bool StringArg
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Type == CvsFunctionArgTypes.String;
		}
	}

	[JsonIgnore]
	internal bool EnumArg
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Type == CvsFunctionArgTypes.Enum;
		}
	}

	[JsonIgnore]
	internal bool AllowStringFunction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Flags & 0x800000) != 0;
		}
	}

	[JsonIgnore]
	internal bool AllowCellRange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Flags & 0x80000) != 0;
		}
	}

	[JsonIgnore]
	internal bool AllowZero
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Flags & 0x40000000) != 0;
		}
	}

	[JsonIgnore]
	internal bool AllowReference
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			bool result = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					result = false;
					_ = 0;
					num = (jSfjeAXcm1yAs9hYYpu() ? 3 : 0);
					continue;
				default:
					result = true;
					num = 5;
					if (jSfjeAXcm1yAs9hYYpu())
					{
						continue;
					}
					goto case 1;
				case 1:
				case 3:
					if (Constant)
					{
						break;
					}
					goto default;
				case 5:
					break;
				}
				break;
			}
			return result;
		}
	}

	[JsonIgnore]
	internal bool AbsoluteReferenceByDefault
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (jSfjeAXcm1yAs9hYYpu())
			{
				num = 3;
				if (false)
				{
					goto IL_00cd;
				}
			}
			else
			{
				num = 7;
			}
			bool result = default;
			CvsFunctionArgTypes type = default;
			while (true)
			{
				switch (num)
				{
				default:
					result = upwLfDG2oq;
					num = 8;
					continue;
				case 6:
					if (type == CvsFunctionArgTypes.Model)
					{
					}
					goto default;
				case 5:
					type = Type;
					num = 2;
					continue;
				case 2:
					if (type == CvsFunctionArgTypes.Image)
					{
						result = true;
						num = 1;
					}
					else
					{
						num = 6;
					}
					continue;
				case 0:
				case 3:
					result = false;
					num = 5;
					continue;
				case 1:
				case 8:
					break;
				}
				break;
			}
			goto IL_00cd;
			IL_00cd:
			return result;
		}
	}

	[JsonIgnore]
	public bool Constant
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Flags & 0x40000) != 0;
		}
	}

	[JsonIgnore]
	public bool CanOnlyBeReference
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (Type != CvsFunctionArgTypes.Image && Type != CvsFunctionArgTypes.Model)
			{
				return Type == CvsFunctionArgTypes.Cell;
			}
			return true;
		}
	}

	[JsonIgnore]
	private bool upwLfDG2oq
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Flags & 0x200000) != 0;
		}
	}

	[JsonIgnore]
	public bool FirstChild
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Flags & 0x10000) != 0;
		}
	}

	[JsonIgnore]
	public bool UseButton
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Flags & 0x1000000) != 0;
		}
	}

	[JsonIgnore]
	public bool LastChild
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Flags & 0x20000) != 0;
		}
	}

	[JsonIgnore]
	public bool Password
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Flags & 0x20000000) != 0;
		}
	}

	[JsonIgnore]
	public bool Color
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Flags & 0x8000) != 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsFunctionArg(int index, FunctionArgumentDescriptor descriptor)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 9;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0220;
		IL_001a:
		SGLmqQX7YBOKX00n5TN(this);
		num = 5;
		goto IL_0220;
		IL_0220:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 9:
				WnPXsdXWJtxtejSc1D5();
				num = 0;
				continue;
			case 4:
				throw new ArgumentNullException((string)pOjgRxXtLBtBI2ZL7vE(42458));
			case 5:
				if (descriptor != null)
				{
					Index = index;
					num = 13;
				}
				else
				{
					num = 4;
				}
				continue;
			case 13:
				dLbL7he7bs = descriptor.Name ?? "";
				Vp1LmUgA0e = (string)(string.IsNullOrEmpty((string)HFkeqvXCSsbxK3IHGn3(descriptor)) ? Name : HFkeqvXCSsbxK3IHGn3(descriptor));
				Help = (string)(uPgHnbXKUR8xUMSlrqJ(descriptor) ?? "");
				if (b2w7boX5OUBUY3cOv9D(descriptor) != null)
				{
					SummaryName = (string)(HPuqVtXorGgwNJNnUBa(b2w7boX5OUBUY3cOv9D(descriptor)) ?? "");
					DisplaySummaryName = (string)(cCQqeVXPigNT8J4nk3x(descriptor.Group) ?? "");
					SummaryHelp = (string)(D1FlfXXYROYFZdRDgFh(descriptor.Group) ?? "");
					goto case 10;
				}
				SummaryName = null;
				num = 6;
				continue;
			case 1:
			case 11:
				Enums = descriptor.Enums.Select([MethodImpl(MethodImplOptions.NoInlining)] (KeyValuePair<string, int> kvp) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return new CvsFunctionArgEnum(kvp.Key, kvp.Value);
				}).ToArray();
				num = 14;
				if (true)
				{
					continue;
				}
				goto case 10;
			case 10:
				Flags = descriptor.Flags;
				qEsgyiX2Hv8elmaaMgt();
				num = ((!jSfjeAXcm1yAs9hYYpu()) ? 1 : 3);
				continue;
			case 6:
				DisplaySummaryName = null;
				num = 2;
				continue;
			case 12:
				if (descriptor.Enums != null)
				{
					goto case 1;
				}
				return;
			case 7:
				MinVal = DnK61IXxlbKVGp7nr4a(descriptor);
				MaxVal = descriptor.Max;
				num = 12;
				continue;
			case 3:
			case 8:
				YLgLjt3Ig2 = JOZdMmXNy6aBBgJMKC8(descriptor);
				num = 7;
				continue;
			case 2:
				SummaryHelp = null;
				goto case 10;
			default:
				num = 10;
				continue;
			case 14:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMinMax(double min, double max)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MinVal = min;
		MaxVal = max;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object GetDefaultValue()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		switch (sdUoA1X3NP3tCGcjvaJ(this))
		{
		case CvsFunctionArgTypes.String:
		case CvsFunctionArgTypes.StrFloat:
			return SZ5LgYBfVg();
		case CvsFunctionArgTypes.Cell:
		case CvsFunctionArgTypes.CellPos:
		case CvsFunctionArgTypes.Image:
		case CvsFunctionArgTypes.Model:
		case CvsFunctionArgTypes.PosRef:
		case CvsFunctionArgTypes.PointCloud:
			return xsqLBB9xPS();
		case CvsFunctionArgTypes.Float:
			return i43LTxZcae();
		case CvsFunctionArgTypes.Int:
		case CvsFunctionArgTypes.Bool:
		case CvsFunctionArgTypes.Enum:
		case CvsFunctionArgTypes.Slider:
		case CvsFunctionArgTypes.Light:
			return iDXLq78hCY();
		default:
			return iDXLq78hCY();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object SZ5LgYBfVg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string text = (YLgLjt3Ig2 as string) ?? "";
		return MK3h8nXOVFUY3Uokll1(pOjgRxXtLBtBI2ZL7vE(35866), text, pOjgRxXtLBtBI2ZL7vE(35866));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private long iDXLq78hCY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToInt64(YLgLjt3Ig2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private double i43LTxZcae()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qEsgyiX2Hv8elmaaMgt();
		int num = ((!jSfjeAXcm1yAs9hYYpu()) ? 3 : 2);
		double? num3 = default;
		long? num2 = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				num3 = YLgLjt3Ig2 as double?;
				goto case 1;
			case 1:
			case 3:
				if (!num3.HasValue)
				{
					num = 5;
					if (qEsgyiX2Hv8elmaaMgt())
					{
					}
					break;
				}
				return num3.GetValueOrDefault();
			case 5:
				num2 = YLgLjt3Ig2 as long?;
				goto case 4;
			default:
				num = 4;
				if (!qEsgyiX2Hv8elmaaMgt())
				{
					break;
				}
				goto case 4;
			case 4:
				if (!num2.HasValue)
				{
					num = 6;
					break;
				}
				return num2.GetValueOrDefault();
			case 6:
				return 0.0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private object xsqLBB9xPS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = (int)iDXLq78hCY();
		int column = num & 0xFFFF;
		int num2 = (num >> 16) & 0xFFF;
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append((string)pOjgRxXtLBtBI2ZL7vE(42546));
		stringBuilder.Append(CnxTableLocation.ColumnToString(column));
		RgCMwXXM5TbYqTLZBiF(stringBuilder, kgbOBx7BanbFa22Hp9.ol99ukmDA(42546));
		rdYKsQXQEjjGVex5v6m(stringBuilder, num2);
		return stringBuilder.ToString();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WnPXsdXWJtxtejSc1D5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SGLmqQX7YBOKX00n5TN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pOjgRxXtLBtBI2ZL7vE(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HFkeqvXCSsbxK3IHGn3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FunctionArgumentDescriptor)P_0).DisplayName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uPgHnbXKUR8xUMSlrqJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FunctionArgumentDescriptor)P_0).Help;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object b2w7boX5OUBUY3cOv9D(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FunctionArgumentDescriptor)P_0).Group;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HPuqVtXorGgwNJNnUBa(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ArgumentGroupDescriptor)P_0).Title;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cCQqeVXPigNT8J4nk3x(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ArgumentGroupDescriptor)P_0).DisplayTitle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object D1FlfXXYROYFZdRDgFh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ArgumentGroupDescriptor)P_0).Description;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JOZdMmXNy6aBBgJMKC8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FunctionArgumentDescriptor)P_0).DefaultValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double DnK61IXxlbKVGp7nr4a(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FunctionArgumentDescriptor)P_0).Min;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jSfjeAXcm1yAs9hYYpu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qEsgyiX2Hv8elmaaMgt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LuuIT9X1FORoLVW5Z2V(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MiuoS1XrmgsLXP2HAlY(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsFunctionArgTypes sdUoA1X3NP3tCGcjvaJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionArg)P_0).Type;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MK3h8nXOVFUY3Uokll1(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RgCMwXXM5TbYqTLZBiF(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rdYKsQXQEjjGVex5v6m(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StringBuilder)P_0).Append(P_1);
	}
}
