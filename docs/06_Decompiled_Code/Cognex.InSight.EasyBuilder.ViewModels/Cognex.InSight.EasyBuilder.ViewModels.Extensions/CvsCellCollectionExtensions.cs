using System;
using System.Linq;
using System.Runtime.CompilerServices;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;

namespace Cognex.InSight.EasyBuilder.ViewModels.Extensions;

public static class CvsCellCollectionExtensions
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		public CvsCellRange range;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass0_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			Fw3Bdu5PmmNO2UkGf7mU(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CFindCellInRange_003Eb__0(CvsCell c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return range.Contains(c.Location);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Fw3Bdu5PmmNO2UkGf7mU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oknjUZ5PHZqwoqMwf11m()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SADViE5PxhZEjn3Vh4Nl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public CvsCellRange range;

		public Func<string, bool> predicate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass1_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			mCcu0p5P2G5pAg68WuaS(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CFindNamedCellInRange_003Eb__0(CvsCell c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (range.Contains(c.Location))
			{
				return c.Name != null;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CFindNamedCellInRange_003Eb__1(CvsCell c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return predicate(c.Name);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void mCcu0p5P2G5pAg68WuaS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool guIo1N5PQOHSvTUsENfg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hcEgr95PNtmA3tEaESpE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsCell FindCellInRange(this CvsCellCollection cells, CvsCellRange range, Func<CvsCell, bool> predicate)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass0_0();
		CS_0024_003C_003E8__locals2.range = range;
		return cells.Where([MethodImpl(MethodImplOptions.NoInlining)] (CvsCell c) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CS_0024_003C_003E8__locals2.range.Contains(c.Location);
		}).First(predicate);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsCell FindNamedCellInRange(this CvsCellCollection cells, CvsCellRange range, Func<string, bool> predicate)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals4.range = range;
		CS_0024_003C_003E8__locals4.predicate = predicate;
		return cells.Where([MethodImpl(MethodImplOptions.NoInlining)] (CvsCell c) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CS_0024_003C_003E8__locals4.range.Contains(c.Location) && c.Name != null;
		}).First([MethodImpl(MethodImplOptions.NoInlining)] (CvsCell c) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CS_0024_003C_003E8__locals4.predicate(c.Name);
		});
	}
}
