using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Cognex.InSight.Cell;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal.Analysis;

public class CvsJobAnalyzer
{
	private CvsInSight CsMf1mULZ2;

	private readonly CvsCellReferenceTable GSwfxDot19;

	private CvsCellInfoCollection VVyfF0D0tT;

	private CvsCellCollection t5QfbTk24L;

	private bool v0GfaHPEvv;

	private bool fl6fOF2g9O;

	[CompilerGenerated]
	private EventHandler wnkfpi6lSu;

	public CvsInSight InSight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CsMf1mULZ2;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
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
				case 3:
					VVyfF0D0tT = new CvsCellInfoCollection();
					goto case 2;
				default:
					num = 2;
					break;
				case 4:
					if (CsMf1mULZ2 != value)
					{
						num = 8;
						break;
					}
					return;
				case 0:
					CsMf1mULZ2 = value;
					num = 3;
					break;
				case 6:
				case 9:
					if (CsMf1mULZ2 != null)
					{
						goto case 1;
					}
					goto case 5;
				case 10:
					CsMf1mULZ2.ResultsChanged -= iTgfIXuDAC;
					num = 0;
					break;
				case 1:
				case 7:
					CsMf1mULZ2.ResultsChanged += iTgfIXuDAC;
					num = 5;
					if (true)
					{
						break;
					}
					goto case 8;
				case 8:
					if (CsMf1mULZ2 == null)
					{
						goto case 0;
					}
					num = 10;
					if (fcuTnsk65Q87ph6hvFf())
					{
						break;
					}
					goto case 5;
				case 5:
					rX6fPVs11Y();
					num = 11;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				case 2:
					v0GfaHPEvv = true;
					_ = 0;
					num = ((!fcuTnsk65Q87ph6hvFf()) ? 1 : 9);
					break;
				case 11:
					return;
				}
			}
		}
	}

	public CvsCellCollection Cells
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return t5QfbTk24L;
		}
	}

	public CvsCellInfoCollection NameList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return VVyfF0D0tT;
		}
	}

	public bool HasChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fl6fOF2g9O;
		}
	}

	public event EventHandler Invalidated
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					eventHandler = wnkfpi6lSu;
					num = 1;
					break;
				case 2:
					value2 = (EventHandler)ikEci0k0XrlZiLhtypT(eventHandler2, value);
					goto default;
				default:
					_ = 1;
					if (!uQJmAHkpaGGqTnLdaZO())
					{
						num = 5;
						if (fcuTnsk65Q87ph6hvFf())
						{
							break;
						}
						goto case 1;
					}
					num = 0;
					break;
				case 1:
					eventHandler2 = eventHandler;
					num = 2;
					break;
				case 0:
				case 4:
					if ((object)eventHandler != eventHandler2)
					{
						goto case 1;
					}
					num = 7;
					if (true)
					{
						break;
					}
					goto case 3;
				case 3:
				case 5:
					eventHandler = Interlocked.CompareExchange(ref wnkfpi6lSu, value2, eventHandler2);
					goto case 0;
				case 7:
					return;
				}
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
				case 5:
					if ((object)eventHandler2 == eventHandler)
					{
						num = 7;
						if (uQJmAHkpaGGqTnLdaZO())
						{
						}
						break;
					}
					goto case 1;
				case 0:
					eventHandler2 = wnkfpi6lSu;
					uQJmAHkpaGGqTnLdaZO();
					if (fcuTnsk65Q87ph6hvFf())
					{
						num = 2;
						if (true)
						{
							break;
						}
						goto case 1;
					}
					num = 5;
					break;
				case 1:
				case 2:
					eventHandler = eventHandler2;
					num = 3;
					if (0 == 0)
					{
						break;
					}
					goto case 6;
				case 6:
					eventHandler2 = Interlocked.CompareExchange(ref wnkfpi6lSu, value2, eventHandler);
					goto case 4;
				case 3:
					value2 = (EventHandler)Tr3LaGk4mdZnshwaNhf(eventHandler, value);
					goto case 6;
				default:
					num = 6;
					break;
				case 7:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsJobAnalyzer()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!uQJmAHkpaGGqTnLdaZO())
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_0083;
		IL_0026:
		CwJpBekkRc2Sj85nmPs();
		goto IL_0050;
		IL_0083:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			case 2:
				goto IL_003b;
			case 1:
			case 5:
				goto IL_0050;
			case 3:
				goto IL_006b;
			default:
				num = 2;
				continue;
			case 6:
				return;
			}
			break;
		}
		goto IL_0026;
		IL_0050:
		VVyfF0D0tT = new CvsCellInfoCollection();
		num = 3;
		if (uQJmAHkpaGGqTnLdaZO())
		{
			goto IL_006b;
		}
		goto IL_0083;
		IL_003b:
		GSwfxDot19 = new CvsCellReferenceTable();
		num = 6;
		goto IL_0083;
		IL_006b:
		FIV090kfRsHjW6xd8D8(this);
		goto IL_003b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rX6fPVs11Y()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (wnkfpi6lSu != null)
		{
			NeKZhEkFsa6iAIi4MP3(wnkfpi6lSu, this, EventArgs.Empty);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetCellName(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellInfo cvsCellInfo = (CvsCellInfo)EeWrLfkmClSrXbnrDns(VVyfF0D0tT, location);
		if (cvsCellInfo != null)
		{
			return (string)K2dKJIky0BdsuJmqHGu(cvsCellInfo);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellReferenceInfo GetCellReferenceInfo(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (CvsCellReferenceInfo)EEPM9JkgTnou4kV5QTf(GSwfxDot19, location);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ReferenceConnected(CvsCellLocation destination, CvsCellLocation source)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Validate();
		return lQoH20kZmr0eshsOaws(GSwfxDot19.GetReferencePaths(destination, source)) > 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Validate(CvsCellCollection cells = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!uQJmAHkpaGGqTnLdaZO())
		{
			num = 5;
		}
		else
		{
			num = 4;
			if (uQJmAHkpaGGqTnLdaZO())
			{
				return;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 6:
				v0GfaHPEvv = false;
				num = 11;
				if (0 == 0)
				{
					break;
				}
				goto case 9;
			case 9:
				if (jxKnITkJCFrUGfWZUwm(InSight) != CvsInSightState.NotConnected)
				{
					num = 7;
					if (uQJmAHkpaGGqTnLdaZO())
					{
					}
					break;
				}
				return;
			case 0:
			case 5:
				if (cells != null)
				{
					num = 1;
					if (fcuTnsk65Q87ph6hvFf())
					{
						break;
					}
					goto case 8;
				}
				if (v0GfaHPEvv)
				{
					num = 8;
					break;
				}
				return;
			case 8:
				if (InSight != null)
				{
					goto case 9;
				}
				return;
			default:
				num = 9;
				break;
			case 1:
				t5QfbTk24L = cells;
				num = 10;
				break;
			case 2:
				fl6fOF2g9O = V0ZiAafwlZesNmLeMws(GSwfxDot19, t5QfbTk24L, InSight);
				num = 6;
				break;
			case 3:
				return;
			case 4:
				return;
			case 7:
				t5QfbTk24L = (CvsCellCollection)UFF19tkze1my8lNKJHu(BKyk37k8FRFWYpMgIKr(InSight));
				num = 2;
				if (fcuTnsk65Q87ph6hvFf())
				{
					break;
				}
				goto case 10;
			case 10:
				fl6fOF2g9O = GSwfxDot19.Update(t5QfbTk24L, InSight);
				return;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void iTgfIXuDAC(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		v0GfaHPEvv = true;
		rX6fPVs11Y();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Reset()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		v0GfaHPEvv = true;
		rX6fPVs11Y();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		InSight = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ikEci0k0XrlZiLhtypT(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fcuTnsk65Q87ph6hvFf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uQJmAHkpaGGqTnLdaZO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Tr3LaGk4mdZnshwaNhf(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CwJpBekkRc2Sj85nmPs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FIV090kfRsHjW6xd8D8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NeKZhEkFsa6iAIi4MP3(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (EventArgs)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EeWrLfkmClSrXbnrDns(object P_0, CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellInfoCollection)P_0)[location];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object K2dKJIky0BdsuJmqHGu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellInfo)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EEPM9JkgTnou4kV5QTf(object P_0, CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellReferenceTable)P_0)[location];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int lQoH20kZmr0eshsOaws(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<List<CvsCellLocation>>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsInSightState jxKnITkJCFrUGfWZUwm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).State;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BKyk37k8FRFWYpMgIKr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Results;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UFF19tkze1my8lNKJHu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsResultSet)P_0).Cells;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool V0ZiAafwlZesNmLeMws(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellReferenceTable)P_0).Update((CvsCellCollection)P_1, (CvsInSight)P_2);
	}
}
