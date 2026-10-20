using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.Cnx.Data.Implementation;

[Serializable]
[DebuggerStepThrough]
public class CnxHashArray : IEnumerable, ICollection
{
	private class gTj1yc2Xbx3iYm6Hc1 : IEnumerator, ICloneable
	{
		private readonly object[] RFQfrA4dmW;

		private readonly int ICwfCw2Jsu;

		private int NZof2Yu9Zd;

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				if (NZof2Yu9Zd < 0)
				{
					throw new InvalidOperationException();
				}
				if (NZof2Yu9Zd >= ICwfCw2Jsu)
				{
					throw new InvalidOperationException();
				}
				return RFQfrA4dmW[NZof2Yu9Zd];
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public gTj1yc2Xbx3iYm6Hc1(object[] P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					vTah85g2ifJO5Dqllch(this);
					goto case 2;
				case 3:
					ICwfCw2Jsu = P_1;
					num = 5;
					continue;
				case 2:
				case 6:
					RFQfrA4dmW = P_0;
					goto case 3;
				default:
					num = 3;
					continue;
				case 5:
					NZof2Yu9Zd = -1;
					num = 7;
					if (true)
					{
						continue;
					}
					break;
				case 0:
					break;
				case 7:
					return;
				}
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				hXkh7RgjIk0fFHlqgS7();
				num = ((!qn0FlBgcXiSRLyBcbpt()) ? 4 : 6);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		bool IEnumerator.MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (NZof2Yu9Zd >= ICwfCw2Jsu)
			{
				return false;
			}
			NZof2Yu9Zd++;
			return NZof2Yu9Zd < ICwfCw2Jsu;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IEnumerator.Reset()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NZof2Yu9Zd = -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		object ICloneable.Clone()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return uZR0tpgWmqG3X0wjli3(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vTah85g2ifJO5Dqllch(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hXkh7RgjIk0fFHlqgS7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qn0FlBgcXiSRLyBcbpt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object uZR0tpgWmqG3X0wjli3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0.MemberwiseClone();
		}
	}

	private object[] iLjqLmUlD;

	private int[] svPT1J4MA;

	private int rt7B6kSoB;

	private int pX5JjoZWs;

	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rt7B6kSoB;
		}
	}

	public object this[int index]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iLjqLmUlD[index];
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			jSPYxUh986LRMw93YKq();
			int num = (nxrTKihSiZrfbvPuDvH() ? 3 : 4);
			int hashCode = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					throw new ArgumentException((string)VoFdaxhAXKf5i9sUVv6(846));
				case 1:
				case 3:
					if (svPT1J4MA[index] == hashCode)
					{
						iLjqLmUlD[index] = value;
						num = 5;
						break;
					}
					goto case 2;
				default:
					num = 2;
					break;
				case 0:
				case 4:
					hashCode = value.GetHashCode();
					goto case 1;
				case 5:
					return;
				}
			}
		}
	}

	bool ICollection.IsSynchronized
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	object ICollection.SyncRoot
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxHashArray()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		l2HjGfhEHYJOI5nJ4Ge();
		this._002Ector(16);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxHashArray(int capacity)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nxrTKihSiZrfbvPuDvH();
		int num = ((!jSPYxUh986LRMw93YKq()) ? 2 : 4);
		while (true)
		{
			switch (num)
			{
			case 3:
				iLjqLmUlD = new object[capacity];
				goto case 2;
			case 7:
				SXCBjchvHSaba03j4cb(this);
				num = 1;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
				if (capacity < 1)
				{
					num = 6;
					break;
				}
				goto case 3;
			case 2:
			case 5:
				svPT1J4MA = new int[capacity];
				num = 8;
				if (jSPYxUh986LRMw93YKq())
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				l2HjGfhEHYJOI5nJ4Ge();
				num = 7;
				break;
			case 6:
				capacity = 1;
				goto case 3;
			default:
				num = 3;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CnxHashArray(CnxHashArray other)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (jSPYxUh986LRMw93YKq())
		{
			num = 3;
		}
		else
		{
			num = 6;
			if (!jSPYxUh986LRMw93YKq())
			{
				goto IL_00dc;
			}
		}
		goto IL_0087;
		IL_0087:
		while (true)
		{
			switch (num)
			{
			case 1:
				svPT1J4MA = new int[other.svPT1J4MA.Length];
				num = 8;
				continue;
			case 8:
				E8aXwnhHI0Ki2cA8yyP(other.iLjqLmUlD, iLjqLmUlD, rt7B6kSoB);
				num = 4;
				continue;
			case 5:
				iLjqLmUlD = new object[other.iLjqLmUlD.Length];
				goto case 1;
			default:
				num = 1;
				if (true)
				{
					continue;
				}
				goto case 7;
			case 7:
				base._002Ector();
				break;
			case 2:
			case 6:
				break;
			case 4:
				E8aXwnhHI0Ki2cA8yyP(other.svPT1J4MA, svPT1J4MA, rt7B6kSoB);
				num = 9;
				continue;
			case 0:
			case 3:
				l2HjGfhEHYJOI5nJ4Ge();
				num = 7;
				continue;
			case 9:
				return;
			}
			break;
		}
		goto IL_00dc;
		IL_00dc:
		rt7B6kSoB = other.rt7B6kSoB;
		num = 5;
		goto IL_0087;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VeD4wohVJWX7sBElkAG(iLjqLmUlD, 0, rt7B6kSoB);
		rt7B6kSoB = 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(object value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		nxrTKihSiZrfbvPuDvH();
		int num;
		if (jSPYxUh986LRMw93YKq())
		{
			num = 4;
			if (nxrTKihSiZrfbvPuDvH())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 5;
			if (!jSPYxUh986LRMw93YKq())
			{
				goto IL_005c;
			}
		}
		goto IL_00f9;
		IL_00f9:
		int hashCode = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				break;
			case 0:
			case 4:
				hashCode = value.GetHashCode();
				goto case 1;
			case 9:
				goto IL_005c;
			case 2:
			case 6:
			case 10:
				do
				{
					qO9lEPdun(value, hashCode, num2);
					num = 11;
				}
				while (false);
				continue;
			case 3:
				goto IL_00a0;
			case 1:
			case 5:
				if (rt7B6kSoB == 0)
				{
					break;
				}
				num = 3;
				if (jSPYxUh986LRMw93YKq())
				{
					continue;
				}
				goto case 2;
			default:
				num = 9;
				if (true)
				{
					continue;
				}
				goto case 7;
			case 7:
				num2 = ~num2;
				num = 6;
				continue;
			case 11:
				return;
			}
			break;
		}
		goto IL_002e;
		IL_00a0:
		if (hashCode >= svPT1J4MA[rt7B6kSoB - 1])
		{
			num = 8;
			goto IL_00f9;
		}
		num2 = AT54wCbqW(hashCode);
		goto IL_005c;
		IL_002e:
		num2 = rt7B6kSoB;
		num = 10;
		goto IL_00f9;
		IL_005c:
		if (num2 < 0)
		{
			num = 7;
		}
		else
		{
			num2 += pX5JjoZWs;
			num = 2;
			if (!jSPYxUh986LRMw93YKq())
			{
				goto IL_00a0;
			}
		}
		goto IL_00f9;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StoreItem(object value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		int num3 = default;
		int num2 = default;
		int num4 = default;
		int hashCode = default;
		while (true)
		{
			switch (num)
			{
			case 10:
				return;
			default:
				num = 6;
				break;
			case 0:
				if (pX5JjoZWs > 1)
				{
					num3 = num2 + 1;
					num = 5;
					break;
				}
				return;
			case 7:
			case 8:
				Tr4gKtk6D(num3, num4);
				num = 11;
				break;
			case 9:
				qO9lEPdun(value, hashCode, ~num2);
				num = 10;
				break;
			case 5:
				num4 = pX5JjoZWs - 1;
				goto case 7;
			case 6:
				svPT1J4MA[num2] = hashCode;
				num = 0;
				break;
			case 1:
			case 2:
				num2 = AT54wCbqW(hashCode);
				num = 4;
				break;
			case 4:
				if (num2 >= 0)
				{
					iLjqLmUlD[num2] = value;
					goto case 6;
				}
				num = 9;
				break;
			case 3:
				hashCode = value.GetHashCode();
				_ = 1;
				num = ((!nxrTKihSiZrfbvPuDvH()) ? 2 : 7);
				break;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Remove(object value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				num2 = IndexOf(value);
				_ = 1;
				num = ((!nxrTKihSiZrfbvPuDvH()) ? 3 : 0);
				break;
			case 1:
			case 3:
				if (num2 >= 0)
				{
					goto default;
				}
				return;
			default:
				Tr4gKtk6D(num2, 1);
				num = 5;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveAt(int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Tr4gKtk6D(index, 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int RemoveAll(int hashCode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			default:
				Tr4gKtk6D(num2, pX5JjoZWs);
				num = 5;
				continue;
			case 1:
			case 4:
				if (pX5JjoZWs <= 0)
				{
					break;
				}
				goto default;
			case 0:
				num2 = AT54wCbqW(hashCode);
				nxrTKihSiZrfbvPuDvH();
				num = (jSPYxUh986LRMw93YKq() ? 4 : 3);
				continue;
			case 5:
				break;
			}
			break;
		}
		return pX5JjoZWs;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object GetItem(int hashCode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = IndexOf(hashCode);
		if (num < 0)
		{
			return null;
		}
		return iLjqLmUlD[num];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe int IndexOf(int hashCode)
	{
		//The blocks IL_0018, IL_001f, IL_0029, IL_0039, IL_0043, IL_0051, IL_0061, IL_0079, IL_00a6, IL_00eb, IL_00fb, IL_010a, IL_0117, IL_011f, IL_012a, IL_013a, IL_0140, IL_0148, IL_0157, IL_016c, IL_0185, IL_0188, IL_0190, IL_019a, IL_01a6 are reachable both inside and outside the pinned region starting at IL_0173. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		int num2 = default;
		int num4 = default;
		int num3 = default;
		int* ptr = default;
		while (true)
		{
			switch (num)
			{
			case 6:
			case 7:
			case 13:
			case 14:
			{
				if (num2 > num4)
				{
					num = 15;
					break;
				}
				num3 = num2 + (num4 - num2 >> 1);
				int num5 = ptr[num3];
				if (num5 == hashCode)
				{
					goto case 3;
				}
				if (num5 >= hashCode)
				{
					num4 = num3 - 1;
					num = 13;
					if (jSPYxUh986LRMw93YKq())
					{
						break;
					}
					goto case 1;
				}
				num = 4;
				break;
			}
			case 8:
				if (ptr[num3 - 1] != hashCode)
				{
					num = 5;
					break;
				}
				num3--;
				goto case 3;
			case 9:
				num4 = rt7B6kSoB - 1;
				goto case 6;
			default:
				num = 3;
				if (!nxrTKihSiZrfbvPuDvH())
				{
					break;
				}
				goto case 4;
			case 4:
				num2 = num3 + 1;
				num = 14;
				break;
			case 0:
			case 2:
				ptr = null;
				num = 11;
				break;
			case 10:
				if (array.Length != 0)
				{
					ptr = (int*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array[0]);
					num = 12;
				}
				else
				{
					_ = 0;
					num = ((!jSPYxUh986LRMw93YKq()) ? 7 : 0);
				}
				break;
			case 3:
				if (num3 > 0)
				{
					num = 8;
					break;
				}
				goto case 5;
			case 1:
			{
				int[] array2 = svPT1J4MA;
				while (true)
				{
					fixed (int[] array = array2)
					{
						if (array2 == null)
						{
							goto IL_010a;
						}
						num = 10;
						if (0 == 0)
						{
							goto IL_00a6_2;
						}
						goto IL_0185;
						IL_00a6_2:
						while (true)
						{
							switch (num)
							{
							case 6:
							case 7:
							case 13:
							case 14:
							{
								if (num2 > num4)
								{
									num = 15;
									continue;
								}
								num3 = num2 + (num4 - num2 >> 1);
								int num5 = ptr[num3];
								if (num5 == hashCode)
								{
									goto case 3;
								}
								if (num5 >= hashCode)
								{
									num4 = num3 - 1;
									num = 13;
									if (jSPYxUh986LRMw93YKq())
									{
										continue;
									}
									goto case 1;
								}
								num = 4;
								continue;
							}
							case 8:
								if (ptr[num3 - 1] != hashCode)
								{
									num = 5;
									continue;
								}
								num3--;
								goto case 3;
							case 9:
								num4 = rt7B6kSoB - 1;
								goto case 6;
							default:
								num = 3;
								if (!nxrTKihSiZrfbvPuDvH())
								{
									continue;
								}
								goto case 4;
							case 4:
								num2 = num3 + 1;
								num = 14;
								continue;
							case 0:
							case 2:
								break;
							case 10:
								goto IL_0117;
							case 3:
								if (num3 > 0)
								{
									num = 8;
									continue;
								}
								goto IL_0185;
							case 1:
								array2 = svPT1J4MA;
								goto end_IL_0174;
							case 5:
								goto IL_0185;
							case 11:
							case 12:
								num2 = 0;
								num = 9;
								continue;
							case 15:
								return ~num2;
							}
							break;
							IL_0117:
							if (array.Length != 0)
							{
								ptr = (int*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array[0]);
								num = 12;
							}
							else
							{
								_ = 0;
								num = ((!jSPYxUh986LRMw93YKq()) ? 7 : 0);
							}
						}
						goto IL_010a;
						IL_0185:
						return num3;
						IL_010a:
						ptr = null;
						num = 11;
						goto IL_00a6_2;
						end_IL_0174:;
					}
				}
			}
			case 5:
				return num3;
			case 11:
			case 12:
				num2 = 0;
				num = 9;
				break;
			case 15:
				return ~num2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int IndexOf(object value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		if (!nxrTKihSiZrfbvPuDvH())
		{
		}
		object obj = default;
		int num2 = default;
		int hashCode = default;
		while (true)
		{
			switch (num)
			{
			case 9:
				obj = iLjqLmUlD[num2];
				num = 11;
				if (true)
				{
					continue;
				}
				goto case 4;
			case 4:
			case 5:
				return num2;
			case 0:
				num2 = IndexOf(hashCode);
				num = 1;
				continue;
			case 7:
			case 11:
				if (!obj.Equals(value))
				{
					num2++;
					goto case 2;
				}
				goto default;
			default:
				_ = 0;
				if (!jSPYxUh986LRMw93YKq())
				{
					num = 2;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				}
				num = 4;
				continue;
			case 1:
				if (num2 < 0)
				{
					break;
				}
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 3;
			case 3:
				obj = iLjqLmUlD[num2];
				num = 7;
				continue;
			case 2:
			case 6:
				if (num2 < Count)
				{
					num = 8;
					continue;
				}
				break;
			case 10:
				hashCode = value.GetHashCode();
				num = 0;
				continue;
			case 8:
				if (svPT1J4MA[num2] != hashCode)
				{
					break;
				}
				num = 9;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			}
			break;
		}
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int IndexOfAll(int hashCode, out int count)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int result = AT54wCbqW(hashCode);
		count = pX5JjoZWs;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int AT54wCbqW(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		int num3 = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
			case 5:
				if (num3 >= rt7B6kSoB)
				{
					goto case 9;
				}
				goto case 6;
			case 0:
				if (num2 < 0)
				{
					num = 3;
					if (jSPYxUh986LRMw93YKq())
					{
						break;
					}
					goto case 1;
				}
				num3 = num2 + 1;
				jSPYxUh986LRMw93YKq();
				if (nxrTKihSiZrfbvPuDvH())
				{
					num = 7;
					break;
				}
				num = 2;
				if (true)
				{
					break;
				}
				goto case 2;
			case 1:
				num2 = IndexOf(P_0);
				num = 0;
				if (jSPYxUh986LRMw93YKq())
				{
					break;
				}
				goto case 9;
			case 9:
				pX5JjoZWs = num3 - num2;
				num = 10;
				break;
			default:
				num = 5;
				if (true)
				{
					break;
				}
				goto case 3;
			case 3:
				pX5JjoZWs = 0;
				num = 8;
				break;
			case 6:
			case 7:
				if (svPT1J4MA[num3] == P_0)
				{
					num3++;
					goto case 2;
				}
				num = 9;
				break;
			case 8:
			case 10:
				return num2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DispId(-4)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new gTj1yc2Xbx3iYm6Hc1(iLjqLmUlD, rt7B6kSoB);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void qO9lEPdun(object P_0, int P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 13;
		int[] destinationArray = default;
		int num2 = default;
		object[] array = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 5:
				destinationArray = new int[num2 * 2];
				goto case 0;
			case 6:
				array = new object[num2 * 2];
				_ = 1;
				if (nxrTKihSiZrfbvPuDvH())
				{
					num = 0;
					if (nxrTKihSiZrfbvPuDvH())
					{
					}
					break;
				}
				num = 5;
				if (true)
				{
					break;
				}
				goto case 9;
			case 9:
				svPT1J4MA = destinationArray;
				goto IL_0063;
			case 2:
				LdXw8ShD4DhAAHmc8gr(iLjqLmUlD, P_2, iLjqLmUlD, P_2 + 1, rt7B6kSoB - P_2);
				num = 10;
				if (jSPYxUh986LRMw93YKq())
				{
					break;
				}
				goto case 7;
			case 7:
				svPT1J4MA[P_2] = P_1;
				num = 11;
				break;
			case 12:
				iLjqLmUlD = array;
				goto case 9;
			default:
				num = 9;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				E8aXwnhHI0Ki2cA8yyP(iLjqLmUlD, array, rt7B6kSoB);
				num = 1;
				break;
			case 13:
				num2 = iLjqLmUlD.Length;
				num = 8;
				break;
			case 10:
				LdXw8ShD4DhAAHmc8gr(svPT1J4MA, P_2, svPT1J4MA, P_2 + 1, rt7B6kSoB - P_2);
				goto IL_0171;
			case 1:
				Array.Copy(svPT1J4MA, destinationArray, rt7B6kSoB);
				num = 12;
				break;
			case 11:
				rt7B6kSoB++;
				num = 14;
				break;
			case 8:
				if (rt7B6kSoB >= num2)
				{
					num = 6;
					break;
				}
				goto IL_0063;
			case 14:
				return;
				IL_0063:
				if (P_2 < rt7B6kSoB)
				{
					num = 2;
					if (!nxrTKihSiZrfbvPuDvH())
					{
						break;
					}
					goto case 2;
				}
				goto IL_0171;
				IL_0171:
				iLjqLmUlD[P_2] = P_0;
				num = 7;
				if (jSPYxUh986LRMw93YKq())
				{
					break;
				}
				goto case 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Tr4gKtk6D(int P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 0:
				rt7B6kSoB -= P_1;
				num = 5;
				continue;
			case 2:
				LdXw8ShD4DhAAHmc8gr(iLjqLmUlD, P_0 + P_1, iLjqLmUlD, P_0, rt7B6kSoB - P_0);
				goto default;
			default:
				nxrTKihSiZrfbvPuDvH();
				if (jSPYxUh986LRMw93YKq())
				{
					num = 1;
					if (jSPYxUh986LRMw93YKq())
					{
						continue;
					}
					goto case 1;
				}
				num = 6;
				continue;
			case 1:
			case 3:
				LdXw8ShD4DhAAHmc8gr(svPT1J4MA, P_0 + P_1, svPT1J4MA, P_0, rt7B6kSoB - P_0);
				break;
			case 5:
				if (P_0 < rt7B6kSoB)
				{
					num = 2;
					continue;
				}
				break;
			case 4:
			case 6:
				break;
			case 7:
				return;
			}
			VeD4wohVJWX7sBElkAG(iLjqLmUlD, rt7B6kSoB, P_1);
			num = 7;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	void ICollection.CopyTo(Array array, int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		LdXw8ShD4DhAAHmc8gr(iLjqLmUlD, 0, array, index, Count - index);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void l2HjGfhEHYJOI5nJ4Ge()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jSPYxUh986LRMw93YKq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nxrTKihSiZrfbvPuDvH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SXCBjchvHSaba03j4cb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void E8aXwnhHI0Ki2cA8yyP(object P_0, object P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Array.Copy((Array)P_0, (Array)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VeD4wohVJWX7sBElkAG(object P_0, int P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Array.Clear((Array)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VoFdaxhAXKf5i9sUVv6(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LdXw8ShD4DhAAHmc8gr(object P_0, int P_1, object P_2, int P_3, int P_4)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Array.Copy((Array)P_0, P_1, (Array)P_2, P_3, P_4);
	}
}
