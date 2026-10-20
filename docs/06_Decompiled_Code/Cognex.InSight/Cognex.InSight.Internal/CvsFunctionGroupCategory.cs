using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

[Serializable]
public sealed class CvsFunctionGroupCategory : IDisplayHelpItem
{
	[CompilerGenerated]
	private readonly CvsFunctionGroup Qc9kpKjlhb;

	[CompilerGenerated]
	private readonly string Rjmkhpukgm;

	[CompilerGenerated]
	private readonly string ELOk4dJbuj;

	[CompilerGenerated]
	private string O8qklBXQ5Z;

	[CompilerGenerated]
	private bool dSmkgZJnnR;

	[CompilerGenerated]
	private List<CvsFunction> LsTkqjbTm7;

	public CvsFunctionGroup Group
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Qc9kpKjlhb;
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
			return Rjmkhpukgm;
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
			return ELOk4dJbuj;
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
			return new CvsFunctionTableEntryPath((string)bSDpFxbcVT2ZWVGlI11(Group), Name);
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
			return O8qklBXQ5Z;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			O8qklBXQ5Z = value;
		}
	}

	public bool IsAnonymous
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return dSmkgZJnnR;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dSmkgZJnnR = value;
		}
	}

	public List<CvsFunction> Functions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LsTkqjbTm7;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			LsTkqjbTm7 = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsFunctionGroupCategory(CvsFunctionGroup group, FunctionCollectionDescriptor collection)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0138;
		IL_001a:
		IsAnonymous = false;
		num = 4;
		goto IL_0138;
		IL_0138:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 1:
			case 5:
				kvuW0kbdqfFXhoJTUIL(this);
				num = 7;
				if (O5XK7kbUOHL2TbL2Ql8())
				{
				}
				continue;
			case 6:
			case 8:
				Functions.Sort();
				num = 11;
				continue;
			case 10:
				throw new ArgumentNullException((string)jUUBK4biU0qdos5fpVW(42628));
			case 4:
				Functions = collection.Functions.Select([MethodImpl(MethodImplOptions.NoInlining)] (FunctionDescriptor P_0) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return new CvsFunction(this, P_0);
				}).ToList();
				goto case 6;
			case 0:
				ELOk4dJbuj = (KUKhhvbjxWB2yY1ulvG(wYnSqwbBvL271V5JXmK(collection)) ? Name : collection.DisplayName);
				Help = collection.Help;
				num = 2;
				continue;
			case 7:
				if (group == null)
				{
					throw new ArgumentNullException(kgbOBx7BanbFa22Hp9.ol99ukmDA(42614));
				}
				if (collection != null)
				{
					Qc9kpKjlhb = group;
					num = 9;
					continue;
				}
				num = 10;
				if (O5XK7kbUOHL2TbL2Ql8())
				{
				}
				continue;
			case 9:
				Rjmkhpukgm = (string)xTHu1sbqE6ndurG1lti(collection);
				goto case 0;
			default:
				num = 0;
				if (NaxhyGbDyqdGmi1e9fh())
				{
					continue;
				}
				goto case 3;
			case 3:
				e9l8wTbT3LR7DxxyiyK();
				_ = 0;
				if (!NaxhyGbDyqdGmi1e9fh())
				{
					num = 6;
					continue;
				}
				num = 5;
				if (false)
				{
					return;
				}
				continue;
			case 11:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsFunctionGroupCategory(CvsFunctionGroup group, IEnumerable<FunctionDescriptor> functions)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		base._002Ector();
		if (group == null)
		{
			throw new ArgumentNullException(kgbOBx7BanbFa22Hp9.ol99ukmDA(42614));
		}
		if (functions == null)
		{
			throw new ArgumentNullException(kgbOBx7BanbFa22Hp9.ol99ukmDA(42652));
		}
		Qc9kpKjlhb = group;
		Rjmkhpukgm = "";
		IsAnonymous = true;
		Functions = functions.Select([MethodImpl(MethodImplOptions.NoInlining)] (FunctionDescriptor P_0) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new CvsFunction(this, P_0);
		}).ToList();
		Functions.Sort();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private CvsFunction nmIkxrVVLV(FunctionDescriptor P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsFunction(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private CvsFunction QvnkFqTWFH(FunctionDescriptor P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsFunction(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void e9l8wTbT3LR7DxxyiyK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kvuW0kbdqfFXhoJTUIL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jUUBK4biU0qdos5fpVW(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xTHu1sbqE6ndurG1lti(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FunctionCollectionDescriptor)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wYnSqwbBvL271V5JXmK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FunctionCollectionDescriptor)P_0).DisplayName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool KUKhhvbjxWB2yY1ulvG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NaxhyGbDyqdGmi1e9fh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool O5XK7kbUOHL2TbL2Ql8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bSDpFxbcVT2ZWVGlI11(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionGroup)P_0).Name;
	}
}
