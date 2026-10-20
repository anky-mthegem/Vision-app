using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.MathLogic;

public class EzOperandCollection : INamedOperandCollection, IEnumerable<INamedOperand>, IEnumerable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public string name;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass4_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			uFjdmlKRisLmsh7vhPi5();
			c8AOcKKRn1wj144c6Hx9(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCognex_002EInSight_002EINamedOperandCollection_002EFindByName_003Eb__0(INamedOperand p)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ahJuvsKRfvby4mKNZa6h(dB7jtlKRVqivK2welr8c(p), name);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void uFjdmlKRisLmsh7vhPi5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void c8AOcKKRn1wj144c6Hx9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool erdla8KRIcEvGegwcf5C()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool biUEKlKRDM9NjOhdcrP9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dB7jtlKRVqivK2welr8c(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((INamedOperand)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ahJuvsKRfvby4mKNZa6h(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Equals((string)P_1);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public CvsCellLocation loc;

		public string expr;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass5_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kx1lK2KRghoFjM10nNWe();
			BsLABlKRscVbAZR8dNu7(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCognex_002EInSight_002EINamedOperandCollection_002EFindMatch_003Eb__0(INamedOperand p)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return p.Location.Equals(loc);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCognex_002EInSight_002EINamedOperandCollection_002EFindMatch_003Eb__1(INamedOperand p)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return d7ifMNKRrN22aQG83d29(gau2g9KRvT7Qb2x14Q67(p), expr);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void kx1lK2KRghoFjM10nNWe()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BsLABlKRscVbAZR8dNu7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OGf9tUKRdnvG5SQj42Rr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool neGeKvKRlVBn7BLwqy61()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gau2g9KRvT7Qb2x14Q67(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((INamedOperand)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool d7ifMNKRrN22aQG83d29(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Equals((string)P_1);
		}
	}

	private List<INamedOperand> fcLQq0WDfW;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EzOperandCollection()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (qKsNXRpIUnmBHZZPDPV() ? 3 : 2);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				LtnuvvpDchrAvrxfZ9w();
				goto case 1;
			case 1:
			case 3:
				fcLQq0WDfW = new List<INamedOperand>();
				break;
			default:
				num = 4;
				continue;
			case 4:
				break;
			case 5:
				return;
			}
			AUoeNspiie41kAPlp6V(this);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(INamedOperand operand)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		fcLQq0WDfW.Add(operand);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddRange(IEnumerable<INamedOperand> operands)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		fcLQq0WDfW.AddRange(operands);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	INamedOperand INamedOperandCollection.FindByName(string name)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals2.name = name;
		return fcLQq0WDfW.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (INamedOperand p) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec__DisplayClass4_0.ahJuvsKRfvby4mKNZa6h(_003C_003Ec__DisplayClass4_0.dB7jtlKRVqivK2welr8c(p), CS_0024_003C_003E8__locals2.name);
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	INamedOperand INamedOperandCollection.FindMatch(string expr)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003C_003Ec__DisplayClass5_0 obj = default;
		INamedOperand result = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 8:
				obj.loc = JFwK7IpnR73ccOB3cHY(obj.expr);
				goto default;
			default:
				if (obj.loc.IsValid)
				{
					num = 1;
					if (true)
					{
						continue;
					}
					goto case 1;
				}
				result = fcLQq0WDfW.FirstOrDefault(obj._003CCognex_002EInSight_002EINamedOperandCollection_002EFindMatch_003Eb__1);
				num = 9;
				continue;
			case 1:
				result = fcLQq0WDfW.FirstOrDefault(obj._003CCognex_002EInSight_002EINamedOperandCollection_002EFindMatch_003Eb__0);
				num = 6;
				if (true)
				{
					continue;
				}
				goto case 7;
			case 7:
				result = null;
				_ = 0;
				if (!Fj8kH4pOf5heHLwHqKd())
				{
					num = 5;
					continue;
				}
				num = 8;
				if (true)
				{
					continue;
				}
				break;
			case 0:
				obj = new _003C_003Ec__DisplayClass5_0();
				num = 2;
				if (Fj8kH4pOf5heHLwHqKd())
				{
					continue;
				}
				goto case 2;
			case 2:
				obj.expr = expr;
				num = 7;
				continue;
			case 6:
			case 9:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<INamedOperand> GetEnumerator()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return fcLQq0WDfW.GetEnumerator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetEnumerator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LtnuvvpDchrAvrxfZ9w()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AUoeNspiie41kAPlp6V(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Fj8kH4pOf5heHLwHqKd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qKsNXRpIUnmBHZZPDPV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation JFwK7IpnR73ccOB3cHY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.TryParse((string)P_0);
	}
}
