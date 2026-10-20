using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cognex.Cnx.Data.Implementation;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
[DebuggerStepThrough]
public sealed class CvsGraphicCollection : IEnumerable
{
	private readonly CnxHashArray sokBEa0n0d;

	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return l8ChO9xB0A8q7F7K82Z(sokBEa0n0d);
		}
	}

	public CvsGraphic this[int index]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (CvsGraphic)sokBEa0n0d[index];
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsGraphic[] Items
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CvsGraphic[] array = new CvsGraphic[Count];
			wtBwijxjSZ3SWSy3W7n(sokBEa0n0d, array, 0);
			return array;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsGraphicCollection()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		irrdYixAIyyAM0Sd2fa();
		int num;
		if (G4fOT7xVdoTt4IA3bTG())
		{
			num = 4;
			if (!G4fOT7xVdoTt4IA3bTG())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0046;
		IL_0082:
		sokBEa0n0d = new CnxHashArray();
		num = 5;
		goto IL_0046;
		IL_0046:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				break;
			default:
				num = 3;
				continue;
			case 0:
			case 4:
				cm2QwPxDLJqHrdnl3j2();
				break;
			case 3:
				goto IL_0082;
			case 5:
				return;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		BrIKgsxU9hQPJo2Y9fL(this);
		goto IL_0082;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsGraphicCollection(CvsGraphicCollection other)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!irrdYixAIyyAM0Sd2fa())
		{
			num = 3;
			if (!G4fOT7xVdoTt4IA3bTG())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 1;
			if (false)
			{
				goto IL_0087;
			}
		}
		goto IL_0058;
		IL_0058:
		IEnumerator enumerator = default;
		switch (num)
		{
		case 4:
			this._002Ector();
			break;
		case 0:
		case 3:
			goto IL_0087;
		case 5:
			try
			{
				while (rx7f0Rxq1KIZ4bxq71t(enumerator))
				{
					CvsGraphic cvsGraphic = (CvsGraphic)WXekGbxdG1wKFesrajb(enumerator);
					RYd6n3xitPUj9Im4eW4(sokBEa0n0d, (cvsGraphic is IDisposable) ? cvsGraphic.Clone() : cvsGraphic);
				}
				return;
			}
			finally
			{
				if (enumerator is IDisposable disposable)
				{
					disposable.Dispose();
				}
			}
		}
		goto IL_002a;
		IL_0087:
		cm2QwPxDLJqHrdnl3j2();
		num = 4;
		goto IL_0058;
		IL_002a:
		enumerator = (IEnumerator)zDqetUxTJjJnkuvFDWt(other.sokBEa0n0d);
		num = 5;
		goto IL_0058;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void Add(CvsGraphic graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RYd6n3xitPUj9Im4eW4(sokBEa0n0d, graphic);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void RemoveFlyoverGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		int num2 = default;
		CvsGraphic cvsGraphic = default;
		CvsCellLocation cvsCellLocation = default;
		while (true)
		{
			switch (num)
			{
			case 7:
			case 10:
				if (num2 < 0)
				{
					num = 11;
					break;
				}
				cvsGraphic = NekNODxcTjIZx0bCQMM(sokBEa0n0d, num2) as CvsGraphic;
				num = 0;
				break;
			case 8:
				cvsCellLocation = SPuG7bx2ojOYY09CF1x(cvsGraphic);
				goto default;
			default:
				irrdYixAIyyAM0Sd2fa();
				if (G4fOT7xVdoTt4IA3bTG())
				{
					num = 2;
					if (true)
					{
						break;
					}
					goto case 4;
				}
				num = 1;
				break;
			case 4:
				num2 = sokBEa0n0d.Count - 1;
				num = 7;
				break;
			case 9:
				if (cvsGraphic.IsFlyover)
				{
					num = 8;
					break;
				}
				goto case 3;
			case 1:
			case 6:
				VA4xpOxWWI5q7HyJA8s(sokBEa0n0d, num2);
				num = 3;
				break;
			case 3:
				num2--;
				num = 10;
				break;
			case 2:
			case 5:
				if (!cvsCellLocation.Equals(CvsCellLocation.PropertySheet))
				{
					goto case 1;
				}
				goto case 3;
			case 0:
				if (cvsGraphic != null)
				{
					num = 9;
					break;
				}
				goto case 3;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void RemoveAll(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		wMbfJjx7Ws3oO5p3IUi(sokBEa0n0d, location.GetHashCode());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void RemoveAll(int hashCode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		sokBEa0n0d.RemoveAll(hashCode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void RemoveAll(CvsCellLocation location, Type type, int id)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RemoveAll(location.GetHashCode(), type, id);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void RemoveAll(int hashCode, Type type, int id)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 12;
		int num2 = default;
		int count = default;
		bool flag = default;
		CvsGraphicImage cvsGraphicImage = default;
		while (true)
		{
			switch (num)
			{
			case 12:
				num2 = sokBEa0n0d.IndexOfAll(hashCode, out count);
				num = 5;
				if (true)
				{
					continue;
				}
				break;
			case 4:
			case 10:
			case 13:
				if (!flag)
				{
					num = 1;
					if (true)
					{
						continue;
					}
					goto case 0;
				}
				goto case 6;
			case 0:
				if (cvsGraphicImage != null)
				{
					num = 14;
					continue;
				}
				goto case 4;
			case 14:
				if (LsBijsxtblobSpo0j9u(cvsGraphicImage) == id)
				{
					num = 8;
					continue;
				}
				goto case 4;
			case 2:
				cvsGraphicImage = sokBEa0n0d[num2] as CvsGraphicImage;
				num = 0;
				continue;
			case 8:
				VA4xpOxWWI5q7HyJA8s(sokBEa0n0d, num2);
				goto case 11;
			default:
				num = 11;
				continue;
			case 7:
				if (!type.Equals(typeof(CvsGraphicImage)))
				{
					if (NekNODxcTjIZx0bCQMM(sokBEa0n0d, num2).GetType().IsAssignableFrom(type))
					{
						VA4xpOxWWI5q7HyJA8s(sokBEa0n0d, num2);
						irrdYixAIyyAM0Sd2fa();
						num = ((!G4fOT7xVdoTt4IA3bTG()) ? 4 : 3);
						continue;
					}
					goto case 4;
				}
				num = 2;
				if (G4fOT7xVdoTt4IA3bTG())
				{
					continue;
				}
				goto case 11;
			case 11:
				flag = true;
				num = 13;
				continue;
			case 1:
				num2++;
				num = 6;
				continue;
			case 3:
			case 9:
				flag = true;
				goto case 4;
			case 6:
				count--;
				break;
			case 5:
				break;
			case 15:
				return;
			}
			if (count > 0)
			{
				flag = false;
				num = 7;
			}
			else
			{
				num = 15;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int GetCellGraphicsCount(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int count = 0;
		sokBEa0n0d.IndexOfAll(location.GetHashCode(), out count);
		return count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerable)sokBEa0n0d).GetEnumerator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicCollection GetCellGraphics(string location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetCellGraphics(new CvsCellLocation(location));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicCollection GetCellGraphics(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!G4fOT7xVdoTt4IA3bTG()) ? 1 : 7);
		int count = default;
		CvsGraphicCollection cvsGraphicCollection = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 5:
			case 6:
				if (count <= 0)
				{
					num = 8;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				}
				IVf5tnxCn2Gqx46gdHO(cvsGraphicCollection, this[num2]);
				num = 3;
				if (irrdYixAIyyAM0Sd2fa())
				{
				}
				break;
			case 2:
				num2 = sokBEa0n0d.IndexOfAll(location.GetHashCode(), out count);
				num = 6;
				break;
			case 0:
			case 7:
				cvsGraphicCollection = new CvsGraphicCollection();
				num = 2;
				break;
			default:
				count--;
				num = 5;
				break;
			case 3:
				num2++;
				goto default;
			case 8:
				return cvsGraphicCollection;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphic GetDefaultGraphic(string location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetDefaultGraphic(new CvsCellLocation(location));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphic GetDefaultGraphic(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0042;
		IL_001a:
		int count = count - 1;
		num = 7;
		if (1 == 0)
		{
			goto IL_002a;
		}
		goto IL_0042;
		IL_002a:
		CvsGraphic cvsGraphic = default;
		return cvsGraphic;
		IL_0042:
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 3:
			case 5:
				goto IL_002a;
			default:
				num = 6;
				continue;
			case 2:
				goto IL_0092;
			case 1:
			case 4:
			case 7:
				goto IL_00c3;
			case 0:
				if (!ehDdsVxKrhCAFUcTGl3(cvsGraphic))
				{
					num2++;
					break;
				}
				goto IL_002a;
			case 8:
				return null;
			}
			break;
			IL_00c3:
			if (count > 0)
			{
				cvsGraphic = this[num2];
				num = 0;
				if (!irrdYixAIyyAM0Sd2fa())
				{
					continue;
				}
				goto IL_0092;
			}
			num = 8;
			continue;
			IL_0092:
			num2 = sokBEa0n0d.IndexOfAll(location.GetHashCode(), out count);
			_ = 0;
			num = ((!G4fOT7xVdoTt4IA3bTG()) ? 5 : 4);
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cm2QwPxDLJqHrdnl3j2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BrIKgsxU9hQPJo2Y9fL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool G4fOT7xVdoTt4IA3bTG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool irrdYixAIyyAM0Sd2fa()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zDqetUxTJjJnkuvFDWt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerable)P_0).GetEnumerator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WXekGbxdG1wKFesrajb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).Current;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RYd6n3xitPUj9Im4eW4(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CnxHashArray)P_0).Add(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rx7f0Rxq1KIZ4bxq71t(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int l8ChO9xB0A8q7F7K82Z(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CnxHashArray)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wtBwijxjSZ3SWSy3W7n(object P_0, object P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ICollection)P_0).CopyTo((Array)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NekNODxcTjIZx0bCQMM(object P_0, int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CnxHashArray)P_0)[index];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation SPuG7bx2ojOYY09CF1x(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphic)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VA4xpOxWWI5q7HyJA8s(object P_0, int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CnxHashArray)P_0).RemoveAt(index);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int wMbfJjx7Ws3oO5p3IUi(object P_0, int hashCode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CnxHashArray)P_0).RemoveAll(hashCode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int LsBijsxtblobSpo0j9u(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphic)P_0).Id;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IVf5tnxCn2Gqx46gdHO(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicCollection)P_0).Add((CvsGraphic)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ehDdsVxKrhCAFUcTGl3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphic)P_0).IsDefaultEdit;
	}
}
