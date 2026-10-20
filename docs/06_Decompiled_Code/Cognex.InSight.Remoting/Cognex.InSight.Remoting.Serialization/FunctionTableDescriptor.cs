using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "FunctionLibrary")]
public class FunctionTableDescriptor
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<FunctionGroupDescriptor, string> _003C_003E9__8_0;

		public static Func<FunctionGroupDescriptor, IEnumerable<FunctionDescriptor>> _003C_003E9__8_2;

		public static Func<FunctionGroupDescriptor, IEnumerable<FunctionCollectionDescriptor>> _003C_003E9__8_3;

		public static Func<IGrouping<string, FunctionGroupDescriptor>, FunctionGroupDescriptor> _003C_003E9__8_1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oZgIAytQvLQ1yo1Qh6b();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003COnDeserialized_003Eb__8_0(FunctionGroupDescriptor g)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)Xuq272t4jZDr8DKh5Gx(t4sENetWcqRsQoZjV5t(g), tQPbNJtCqy14hZYumsu(3894), SMAxLTt6XplPGkCEeA5(g));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal FunctionGroupDescriptor _003COnDeserialized_003Eb__8_1(IGrouping<string, FunctionGroupDescriptor> g)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			FunctionGroupDescriptor functionGroupDescriptor = g.First();
			return new FunctionGroupDescriptor
			{
				Name = functionGroupDescriptor.Name,
				Help = functionGroupDescriptor.Help,
				DisplayName = (string.IsNullOrEmpty(functionGroupDescriptor.DisplayName) ? functionGroupDescriptor.Name : functionGroupDescriptor.DisplayName),
				Functions = g.SelectMany([MethodImpl(MethodImplOptions.NoInlining)] (FunctionGroupDescriptor c) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return c.Functions ?? new FunctionDescriptor[0];
				}).ToArray(),
				Collections = g.SelectMany([MethodImpl(MethodImplOptions.NoInlining)] (FunctionGroupDescriptor c) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return c.Collections ?? new FunctionCollectionDescriptor[0];
				}).ToArray()
			};
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<FunctionDescriptor> _003COnDeserialized_003Eb__8_2(FunctionGroupDescriptor c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return c.Functions ?? new FunctionDescriptor[0];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<FunctionCollectionDescriptor> _003COnDeserialized_003Eb__8_3(FunctionGroupDescriptor c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return c.Collections ?? new FunctionCollectionDescriptor[0];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool M22U7AZeE2ZtBrTSGqg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VXJHsGZzWaGuWgOE29B()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void oZgIAytQvLQ1yo1Qh6b()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object t4sENetWcqRsQoZjV5t(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FunctionGroupDescriptor)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tQPbNJtCqy14hZYumsu(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SMAxLTt6XplPGkCEeA5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FunctionGroupDescriptor)P_0).Help;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Xuq272t4jZDr8DKh5Gx(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1 + (string)P_2;
		}
	}

	[CompilerGenerated]
	private string H2HCjbmNmI;

	[CompilerGenerated]
	private FunctionGroupDescriptor[] rpaCcX3WPN;

	[JsonProperty]
	public string Kind
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return H2HCjbmNmI;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			H2HCjbmNmI = value;
		}
	}

	[JsonProperty]
	public FunctionGroupDescriptor[] Groups
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rpaCcX3WPN;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rpaCcX3WPN = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[OnDeserialized]
	private void qrZCPCQ8t8(StreamingContext voUcBTejrvRf9dVnkD)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Groups = Groups.GroupBy([MethodImpl(MethodImplOptions.NoInlining)] (FunctionGroupDescriptor g) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)_003C_003Ec.Xuq272t4jZDr8DKh5Gx(_003C_003Ec.t4sENetWcqRsQoZjV5t(g), _003C_003Ec.tQPbNJtCqy14hZYumsu(3894), _003C_003Ec.SMAxLTt6XplPGkCEeA5(g));
		}).Select([MethodImpl(MethodImplOptions.NoInlining)] (IGrouping<string, FunctionGroupDescriptor> g) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			FunctionGroupDescriptor functionGroupDescriptor = g.First();
			return new FunctionGroupDescriptor
			{
				Name = functionGroupDescriptor.Name,
				Help = functionGroupDescriptor.Help,
				DisplayName = (string.IsNullOrEmpty(functionGroupDescriptor.DisplayName) ? functionGroupDescriptor.Name : functionGroupDescriptor.DisplayName),
				Functions = g.SelectMany([MethodImpl(MethodImplOptions.NoInlining)] (FunctionGroupDescriptor c) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return c.Functions ?? new FunctionDescriptor[0];
				}).ToArray(),
				Collections = g.SelectMany([MethodImpl(MethodImplOptions.NoInlining)] (FunctionGroupDescriptor c) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return c.Collections ?? new FunctionCollectionDescriptor[0];
				}).ToArray()
			};
		}).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FunctionTableDescriptor()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
		hNGFqEwR5UKkp34OegC(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EoqOkCwrAgxEIYa1aAF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qOWqxUwVXAglBlFgFSX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hNGFqEwR5UKkp34OegC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
