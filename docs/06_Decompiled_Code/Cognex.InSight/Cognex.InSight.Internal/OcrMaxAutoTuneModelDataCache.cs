using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cognex.Extensions;
using Cognex.InSight.Cell;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

public class OcrMaxAutoTuneModelDataCache
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<CvsCell, bool> _003C_003E9__7_0;

		public static Func<CvsCell, CvsCellLocation> _003C_003E9__7_1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			PKEjG9se7PSbhXjrFoEN();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			PKEjG9se7PSbhXjrFoEN();
			jSJ76ZsetRyxcpOIGWe2(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetAllValidSessionData_003Eb__7_0(CvsCell c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return cqIWmose5ahavgiunb2H(yFeIouseCSq9o8USSHxg(c), erY9h5seKiK071gZYJr1(56966), StringComparison.InvariantCultureIgnoreCase);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal CvsCellLocation _003CGetAllValidSessionData_003Eb__7_1(CvsCell c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MXSkgQseonHDtiTZL0pD(c);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PKEjG9se7PSbhXjrFoEN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jhAhmOse2cVFJW7qlYfE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool G9JtXRseWBn7sUX0RQ2x()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jSJ76ZsetRyxcpOIGWe2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yFeIouseCSq9o8USSHxg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object erY9h5seKiK071gZYJr1(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cqIWmose5ahavgiunb2H(object P_0, object P_1, StringComparison P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).StartsWith((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation MXSkgQseonHDtiTZL0pD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Location;
		}
	}

	private readonly CvsCogSocketSheet rYyX5vDQwF;

	private readonly Dictionary<string, byte[]> bubXYV7Mrb;

	public Dictionary<string, byte[]> AllData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bubXYV7Mrb;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OcrMaxAutoTuneModelDataCache(CvsCogSocketSheet sheet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_006a;
		IL_0051:
		rYyX5vDQwF = sheet;
		goto IL_0097;
		IL_006a:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				break;
			case 4:
				goto IL_0030;
			case 0:
			case 2:
				goto IL_0051;
			default:
				num = 5;
				if (true)
				{
					continue;
				}
				goto IL_0097;
			case 5:
				goto IL_0097;
			case 6:
				return;
			}
			break;
			IL_0030:
			AIjL6w4cJqYPx6NctoU();
			_ = 1;
			if (DIHGNe4jqtDFlK8pOqr())
			{
				num = 0;
				continue;
			}
			num = 3;
			if (!DIHGNe4jqtDFlK8pOqr())
			{
				continue;
			}
			goto IL_0051;
		}
		goto IL_001a;
		IL_0097:
		bubXYV7Mrb = new Dictionary<string, byte[]>();
		num = 6;
		goto IL_006a;
		IL_001a:
		WA6M3m42A9REtpl3IZh(this);
		goto IL_0051;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		bubXYV7Mrb.Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<string> GetSessionNames()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return bubXYV7Mrb.Keys;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dictionary<string, byte[]> GetAllValidSessionData(CvsResultSet resultSet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (resultSet == null)
		{
			return bubXYV7Mrb;
		}
		if (bubXYV7Mrb.Count == 0)
		{
			return bubXYV7Mrb;
		}
		string[] result = resultSet.Cells.Cast<CvsCell>().Where([MethodImpl(MethodImplOptions.NoInlining)] (CvsCell c) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec.cqIWmose5ahavgiunb2H(_003C_003Ec.yFeIouseCSq9o8USSHxg(c), _003C_003Ec.erY9h5seKiK071gZYJr1(56966), StringComparison.InvariantCultureIgnoreCase);
		}).Select([MethodImpl(MethodImplOptions.NoInlining)] (CvsCell c) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec.MXSkgQseonHDtiTZL0pD(c);
		})
			.ToList()
			.Select([MethodImpl(MethodImplOptions.NoInlining)] (CvsCellLocation P_0) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return rYyX5vDQwF.GetOcrMaxAutoTuneSessionPathForCell(P_0);
			})
			.WhenAll()
			.Result;
		foreach (string item in bubXYV7Mrb.Keys.Except(result).ToList())
		{
			bubXYV7Mrb.Remove(item);
		}
		return bubXYV7Mrb;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] GetModelDataFor(string nameOfData)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (nameOfData == null)
		{
			throw new ArgumentNullException((string)jMlsrk4Wt83pBTr1bP5(45684));
		}
		return bubXYV7Mrb.GetValueOrDefault(nameOfData);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetModelDataFor(string nameOfData, byte[] data)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (nameOfData == null)
		{
			throw new ArgumentNullException((string)jMlsrk4Wt83pBTr1bP5(45684));
		}
		bubXYV7Mrb[nameOfData] = data;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddModelData(Dictionary<string, byte[]> dataDictionary)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		foreach (KeyValuePair<string, byte[]> item in dataDictionary)
		{
			bubXYV7Mrb[item.Key] = item.Value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearModelDataFor(string nameOfData)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		bubXYV7Mrb.Remove(nameOfData);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private Task<string> iJhXcFmNa3(CvsCellLocation P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return rYyX5vDQwF.GetOcrMaxAutoTuneSessionPathForCell(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AIjL6w4cJqYPx6NctoU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WA6M3m42A9REtpl3IZh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HrN3bD4BBMBX8Oklln3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool DIHGNe4jqtDFlK8pOqr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jMlsrk4Wt83pBTr1bP5(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}
}
