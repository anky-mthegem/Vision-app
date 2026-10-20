using System;
using System.Annotations;
using System.Runtime.CompilerServices;
using System.Text;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

public class CvsFunctionTableEntryPath
{
	[CompilerGenerated]
	private string j8ZkLYyZUd;

	[CompilerGenerated]
	private string XFPkkg2UWw;

	[CompilerGenerated]
	private string J3GkXJZV8C;

	[NotNull]
	public string GroupName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return j8ZkLYyZUd;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			j8ZkLYyZUd = value;
		}
	}

	[CanBeNull]
	public string CategoryName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XFPkkg2UWw;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			XFPkkg2UWw = value;
		}
	}

	[CanBeNull]
	public string FunctionName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return J3GkXJZV8C;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			J3GkXJZV8C = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsFunctionTableEntryPath(string groupName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				if (groupName == null)
				{
					goto case 0;
				}
				GroupName = groupName;
				num = 6;
				break;
			default:
				num = 0;
				break;
			case 1:
			case 3:
				Wr0wyWb6PKEFJioOpRw(this);
				goto case 2;
			case 0:
				throw new ArgumentNullException(kgbOBx7BanbFa22Hp9.ol99ukmDA(42706));
			case 4:
				xZhUNpbbs8ROfErdN9r();
				VD5ZZIbXkjCAgEqTh0y();
				num = (OXbUmPbGU7Li5JgtxqW() ? 3 : 5);
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsFunctionTableEntryPath(string groupName, string categoryName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		while (true)
		{
			switch (num)
			{
			case 5:
				if (groupName == null)
				{
					_ = 1;
					if (!VD5ZZIbXkjCAgEqTh0y())
					{
						num = 7;
						if (true)
						{
							continue;
						}
						goto case 3;
					}
					num = 1;
					continue;
				}
				if (categoryName == null)
				{
					goto default;
				}
				GroupName = groupName;
				num = 2;
				if (!VD5ZZIbXkjCAgEqTh0y())
				{
					continue;
				}
				break;
			case 3:
			case 7:
				throw new ArgumentNullException((string)P1CFPWbpmX2GmR21pJq(42706));
			case 6:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				goto case 2;
			case 2:
				CategoryName = categoryName;
				num = 8;
				continue;
			default:
				throw new ArgumentNullException((string)P1CFPWbpmX2GmR21pJq(42728));
			case 0:
				break;
			case 8:
				return;
			}
			Wr0wyWb6PKEFJioOpRw(this);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsFunctionTableEntryPath(string groupName, string categoryName, string functionName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VD5ZZIbXkjCAgEqTh0y();
		int num = ((!OXbUmPbGU7Li5JgtxqW()) ? 7 : 4);
		while (true)
		{
			switch (num)
			{
			case 2:
				CategoryName = categoryName ?? "";
				FunctionName = functionName;
				num = 8;
				break;
			case 1:
			case 7:
				base._002Ector();
				num = 6;
				if (!VD5ZZIbXkjCAgEqTh0y())
				{
					break;
				}
				goto case 5;
			case 5:
				throw new ArgumentNullException(kgbOBx7BanbFa22Hp9.ol99ukmDA(42706));
			default:
				num = 3;
				break;
			case 3:
				throw new ArgumentNullException((string)P1CFPWbpmX2GmR21pJq(42756));
			case 0:
			case 4:
				xZhUNpbbs8ROfErdN9r();
				goto case 1;
			case 6:
				if (groupName != null)
				{
					if (functionName == null)
					{
						goto case 3;
					}
					GroupName = groupName;
					num = 2;
					break;
				}
				num = 5;
				if (!OXbUmPbGU7Li5JgtxqW())
				{
					return;
				}
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0075;
		IL_001a:
		if (FunctionName != null)
		{
			num = 9;
			goto IL_0075;
		}
		goto IL_012b;
		IL_012b:
		StringBuilder stringBuilder = default;
		return stringBuilder.ToString();
		IL_0075:
		while (true)
		{
			switch (num)
			{
			case 8:
				goto IL_002f;
			case 0:
			case 4:
				hGvIuDb4dxl94ZTYUPC(stringBuilder, CategoryName);
				break;
			case 6:
				hGvIuDb4dxl94ZTYUPC(stringBuilder, FunctionName);
				num = 10;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
				if (CategoryName != null)
				{
					num = 8;
					continue;
				}
				break;
			case 1:
				E72hlIb0joklvLnGLwK(stringBuilder, GroupName, Array.Empty<object>());
				num = 2;
				continue;
			case 7:
				stringBuilder = new StringBuilder();
				num = 1;
				continue;
			case 9:
				hGvIuDb4dxl94ZTYUPC(stringBuilder, P1CFPWbpmX2GmR21pJq(344));
				num = 6;
				continue;
			case 10:
				goto IL_012b;
			}
			break;
			IL_002f:
			hGvIuDb4dxl94ZTYUPC(stringBuilder, P1CFPWbpmX2GmR21pJq(344));
			_ = 0;
			num = ((!OXbUmPbGU7Li5JgtxqW()) ? 3 : 0);
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xZhUNpbbs8ROfErdN9r()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Wr0wyWb6PKEFJioOpRw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool OXbUmPbGU7Li5JgtxqW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VD5ZZIbXkjCAgEqTh0y()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object P1CFPWbpmX2GmR21pJq(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object E72hlIb0joklvLnGLwK(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StringBuilder)P_0).AppendFormat((string)P_1, (object[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hGvIuDb4dxl94ZTYUPC(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StringBuilder)P_0).Append((string)P_1);
	}
}
