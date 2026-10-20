using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cognex.Extensions;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

[Serializable]
public sealed class CvsFunctionGroup : IDisplayHelpItem
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<CvsFunctionGroupCategory, string> _003C_003E9__0_1;

		public static Func<CvsFunctionGroupCategory, IEnumerable<CvsFunction>> _003C_003E9__0_2;

		public static Func<CvsFunction, bool> _003C_003E9__26_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VC1rkKsl8VmqT2BoIOfU();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
			rdO7dYslzFmas8wDT80p(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003C_002Ector_003Eb__0_1(CvsFunctionGroupCategory gc)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return gc.Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<CvsFunction> _003C_002Ector_003Eb__0_2(CvsFunctionGroupCategory cat)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return cat.Functions;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003Cget_Deprecated_003Eb__26_0(CvsFunction function)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WZ7k0EsewAZwWlb1EbPx(function);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void VC1rkKsl8VmqT2BoIOfU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oZ8NnfslZ8eb2pPiPCMo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ke8qsfslJbfv39WuwgjX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void rdO7dYslzFmas8wDT80p(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WZ7k0EsewAZwWlb1EbPx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsFunction)P_0).Listed;
		}
	}

	[CompilerGenerated]
	private readonly string I3vLZumb9p;

	[CompilerGenerated]
	private readonly string Nm8L8XDviS;

	[CompilerGenerated]
	private string HD1LzhTZ0S;

	[CompilerGenerated]
	private CvsFunction[] JKrkPjXJqs;

	[CompilerGenerated]
	private CvsFunctionGroupCategory[] xBakITt9b5;

	[CompilerGenerated]
	private CvsFunctionGroupCategory MIFk1X9dO6;

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
			return I3vLZumb9p;
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
			return Nm8L8XDviS;
		}
	}

	public CvsFunctionTableEntryPath Path
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new CvsFunctionTableEntryPath(Name);
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
			return HD1LzhTZ0S;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HD1LzhTZ0S = value;
		}
	}

	public CvsFunction[] Functions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return JKrkPjXJqs;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			JKrkPjXJqs = value;
		}
	}

	public CvsFunctionGroupCategory[] Categories
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xBakITt9b5;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xBakITt9b5 = value;
		}
	}

	public CvsFunctionGroupCategory Uncategorized
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MIFk1X9dO6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			MIFk1X9dO6 = value;
		}
	}

	public bool Deprecated
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (Functions != null)
			{
				return !Functions.Any([MethodImpl(MethodImplOptions.NoInlining)] (CvsFunction function) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return _003C_003Ec.WZ7k0EsewAZwWlb1EbPx(function);
				});
			}
			return true;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsFunctionGroup(FunctionGroupDescriptor descriptor, params CvsFunction[] functions)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		jIRqhebhs6BDaQCWpNU();
		int num = ((!xObZPTbshnLgdceCPTn()) ? 6 : 5);
		while (true)
		{
			switch (num)
			{
			case 2:
				throw new ArgumentNullException((string)u25RcNb9ofvCyj21HgN(42458));
			case 7:
				base._002Ector();
				num = 3;
				break;
			case 1:
				Functions = Categories.Plus(Uncategorized).SelectMany([MethodImpl(MethodImplOptions.NoInlining)] (CvsFunctionGroupCategory cat) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return cat.Functions;
				}).Concat(functions)
					.ToArray();
				num = 8;
				break;
			case 0:
			case 5:
				Si3x56bLHIq0ZIpqRIS();
				num = 7;
				break;
			default:
				Categories = ((IEnumerable<FunctionCollectionDescriptor>)icujYHbAvbW6r5La77k(descriptor)).OrEmpty().Select([MethodImpl(MethodImplOptions.NoInlining)] (FunctionCollectionDescriptor P_0) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return new CvsFunctionGroupCategory(this, P_0);
				}).OrderBy([MethodImpl(MethodImplOptions.NoInlining)] (CvsFunctionGroupCategory gc) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return gc.Name;
				})
					.ToArray();
				num = 1;
				if (0 == 0)
				{
					break;
				}
				goto case 3;
			case 3:
				if (descriptor != null)
				{
					I3vLZumb9p = (string)(LBUkOpbSFl61eEVup3n(descriptor) ?? "");
					Nm8L8XDviS = (string)(sAajTKbEe7QMR4YfwOB(descriptor.DisplayName) ? Name : j55D1Xbv3wd9mPmYDoM(descriptor));
					Help = (string)(k7CHgUbHnpxPsvJCsyF(descriptor) ?? "");
					Uncategorized = new CvsFunctionGroupCategory(this, ((IEnumerable<FunctionDescriptor>)bJesF7bVGXgpVK3HS9A(descriptor)).OrEmpty());
					goto default;
				}
				num = 2;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private CvsFunctionGroupCategory stnL2fWFf9(FunctionCollectionDescriptor P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsFunctionGroupCategory(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Si3x56bLHIq0ZIpqRIS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object u25RcNb9ofvCyj21HgN(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LBUkOpbSFl61eEVup3n(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FunctionGroupDescriptor)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sAajTKbEe7QMR4YfwOB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object j55D1Xbv3wd9mPmYDoM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FunctionGroupDescriptor)P_0).DisplayName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object k7CHgUbHnpxPsvJCsyF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FunctionGroupDescriptor)P_0).Help;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bJesF7bVGXgpVK3HS9A(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FunctionGroupDescriptor)P_0).Functions;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object icujYHbAvbW6r5La77k(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FunctionGroupDescriptor)P_0).Collections;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xObZPTbshnLgdceCPTn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jIRqhebhs6BDaQCWpNU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
