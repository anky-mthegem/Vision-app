using System;
using System.Runtime.CompilerServices;
using System.Windows;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

[Serializable]
public class CvsCellCuttable : ICvsCellClipboard
{
	private readonly string PSFoMvUZk1;

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
			object data = default;
			IDataObject dataObject = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					if (!HwfNM4eSllnP7vw4g28(((CvsCellCuttable)data).PSFoMvUZk1, PSFoMvUZk1))
					{
						break;
					}
					num = 8;
					if (0 == 0)
					{
						continue;
					}
					goto case 7;
				case 7:
					if (dataObject == null)
					{
						break;
					}
					num = 1;
					if (QhGHbal8ojeIYK4fl0K())
					{
						continue;
					}
					goto case 1;
				case 1:
					if (h5QD7Se9QpNgmeO2AO9(dataObject, uNa6v7eLn00vTZIMbQF(typeof(CvsCellCuttable).TypeHandle)))
					{
						num = 2;
						continue;
					}
					break;
				case 3:
					dataObject = (IDataObject)bi4bD8ehIdIvBvTW9W6();
					num = 7;
					continue;
				case 2:
					data = dataObject.GetData(typeof(CvsCellCuttable));
					goto default;
				default:
					wAsu1DlzYDPFk2r8Sxt();
					if (QhGHbal8ojeIYK4fl0K())
					{
						num = 6;
						if (true)
						{
							continue;
						}
						goto case 4;
					}
					num = 0;
					continue;
				case 4:
				case 6:
					if (!(data is CvsCellCuttable))
					{
						break;
					}
					goto case 0;
				case 8:
					return true;
				}
				break;
			}
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellCuttable(string hostName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (!QhGHbal8ojeIYK4fl0K())
		{
			goto IL_001e;
		}
		goto IL_006c;
		IL_001e:
		lkbk7Pew23YMppyYdNA();
		wAsu1DlzYDPFk2r8Sxt();
		if (QhGHbal8ojeIYK4fl0K())
		{
			num = 4;
			if (!QhGHbal8ojeIYK4fl0K())
			{
				goto IL_0043;
			}
		}
		else
		{
			num = 0;
		}
		goto IL_006c;
		IL_006c:
		switch (num)
		{
		case 3:
			break;
		default:
			goto IL_0043;
		case 1:
		case 4:
			VJX3qjesPLtVyYEW4vY(this);
			goto IL_0043;
		case 5:
			return;
		}
		goto IL_001e;
		IL_0043:
		PSFoMvUZk1 = hostName;
		num = 5;
		goto IL_006c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lkbk7Pew23YMppyYdNA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VJX3qjesPLtVyYEW4vY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QhGHbal8ojeIYK4fl0K()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wAsu1DlzYDPFk2r8Sxt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bi4bD8ehIdIvBvTW9W6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Clipboard.GetDataObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type uNa6v7eLn00vTZIMbQF(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool h5QD7Se9QpNgmeO2AO9(object P_0, Type P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IDataObject)P_0).GetDataPresent(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HwfNM4eSllnP7vw4g28(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}
}
