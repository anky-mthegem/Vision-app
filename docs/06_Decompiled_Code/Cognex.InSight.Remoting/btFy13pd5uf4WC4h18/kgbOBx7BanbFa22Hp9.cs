using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using cJxwT5Abi5ieaPFhYb;

namespace btFy13pd5uf4WC4h18;

internal class kgbOBx7BanbFa22Hp9
{
	internal class e6n0ejBIUP7FlAAGH4 : Attribute
	{
		internal class zcty0k3N9IXxl9ukmD<T>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public zcty0k3N9IXxl9ukmD()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool Cs8KlPtbsh2kyHGIAid()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool H7sobUtgdhop8QYY1Xg()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[e6n0ejBIUP7FlAAGH4(typeof(zcty0k3N9IXxl9ukmD<object>[]))]
		public e6n0ejBIUP7FlAAGH4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cRPJlVtlwVb9ioCHn8r();
			equa2ltOVQYDS7CRZI4(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void cRPJlVtlwVb9ioCHn8r()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void equa2ltOVQYDS7CRZI4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Attribute)P_0)._002Ector();
		}
	}

	internal class mX5TgU2XyqskVSIvZp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[e6n0ejBIUP7FlAAGH4(typeof(e6n0ejBIUP7FlAAGH4.zcty0k3N9IXxl9ukmD<object>[]))]
		internal static void ce4DmfsmSrOT856tDgfrkMb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (X3ktYetJwqyZHSQpq93(yqJKXNt1jLyRTNwPFjC(Convert.ToBase64String((byte[])XcasSat0Qc1KrxMKl5Q(dO363mtBXF8diFl7IqD(g5XNuHO1AT))), TZrlkLtAj1TTiC8CDOo(3956)), TZrlkLtAj1TTiC8CDOo(3962)))
			{
				while (true)
				{
					aUFZIAt8y1b7RuLKZPs();
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[e6n0ejBIUP7FlAAGH4(typeof(e6n0ejBIUP7FlAAGH4.zcty0k3N9IXxl9ukmD<object>[]))]
		internal static string P4Y0EqEQ3Z(string P_0, string P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			byte[] array = (byte[])vwl69AtmVJdH3FSG7x8(j1wfwPtjjRnn23jwUly(), P_0);
			byte[] array2 = array;
			byte[] array3 = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] array4 = (byte[])vwKsxCtvms4cqg3n9Xp(vwl69AtmVJdH3FSG7x8(j1wfwPtjjRnn23jwUly(), P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = hHpd90tFy();
			IhcCMXt39nLS2ok8Ufx(symmetricAlgorithm, array3);
			jggZZJtejrG2LY76FQj(symmetricAlgorithm, array4);
			CryptoStream cryptoStream = new CryptoStream(memoryStream, (ICryptoTransform)yfZhWRtzmheKITjeeaU(symmetricAlgorithm), CryptoStreamMode.Write);
			T40FPgaQlTI0xjFILcm(cryptoStream, array2, 0, array2.Length);
			GmM2yOaWM1uglV9pQq1(cryptoStream);
			return Convert.ToBase64String((byte[])dZLZR6aCuirxLnfqHp2(memoryStream));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public mX5TgU2XyqskVSIvZp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			plnhufa6obD7axgm8qB();
			d4BuqUa4Xu3ts5UxuD5(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dO363mtBXF8diFl7IqD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Assembly)P_0).GetName();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XcasSat0Qc1KrxMKl5Q(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AssemblyName)P_0).GetPublicKeyToken();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TZrlkLtAj1TTiC8CDOo(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yqJKXNt1jLyRTNwPFjC(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P4Y0EqEQ3Z((string)P_0, (string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool X3ktYetJwqyZHSQpq93(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 != (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void aUFZIAt8y1b7RuLKZPs()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ce4DmfsmSrOT856tDgfrkMb();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object j1wfwPtjjRnn23jwUly()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Encoding.Unicode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vwl69AtmVJdH3FSG7x8(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Encoding)P_0).GetBytes((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vwKsxCtvms4cqg3n9Xp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return L4h818p6n((byte[])P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void IhcCMXt39nLS2ok8Ufx(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((SymmetricAlgorithm)P_0).Key = (byte[])P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jggZZJtejrG2LY76FQj(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((SymmetricAlgorithm)P_0).IV = (byte[])P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yfZhWRtzmheKITjeeaU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SymmetricAlgorithm)P_0).CreateEncryptor();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void T40FPgaQlTI0xjFILcm(object P_0, object P_1, int P_2, int P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Stream)P_0).Write((byte[])P_1, P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GmM2yOaWM1uglV9pQq1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Stream)P_0).Close();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dZLZR6aCuirxLnfqHp2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((MemoryStream)P_0).ToArray();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void plnhufa6obD7axgm8qB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void d4BuqUa4Xu3ts5UxuD5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint x9sntTdHHfjBTD0RRb(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr g2eFvXaXaERdi3sbPR();

	internal struct KwtUps8tElfujnPScH
	{
		internal bool fVV08Qgyut;

		internal byte[] NWE04v1tMt;
	}

	[Flags]
	private enum YA1OnfYyfXoS8LQshA
	{

	}

	private static bool Q1fNiFmxZM;

	private static Assembly g5XNuHO1AT;

	private static bool H8LNgLXnya;

	private static byte[] evYNnnkP1L;

	private static object jDJNGXIFgx;

	private static bool vEiNoRbjIm;

	private static int MUnNjbGd7d;

	private static long VlJNd0xXYX;

	internal static Hashtable yIq0dLwqw2;

	internal static x9sntTdHHfjBTD0RRb wNs00NSNU4;

	private static IntPtr gscNsxeiJM;

	private static uint[] sAtNZCi53U;

	private static int[] J6jN75udqX;

	private static byte[] IexN1nn0Li;

	[e6n0ejBIUP7FlAAGH4(typeof(e6n0ejBIUP7FlAAGH4.zcty0k3N9IXxl9ukmD<object>[]))]
	private static bool XrafU9NwrM;

	private static byte[] aY3NE5Y8tr;

	private static bool lMbNv5ExiL;

	internal static x9sntTdHHfjBTD0RRb ac80OR2c1l;

	private static int rlQNWg4f6u;

	private static byte[] ra8NkNlyrY;

	private static bool pnNNSrtoa3;

	private static int fKSfAwLS7n;

	private static IntPtr Y2LfHc3vZM;

	private static int XgMNTADp6M;

	private static SortedList lT4NP6G6an;

	private static IntPtr DSxN0p9hXq;

	private static long MgnNcbYlLI;

	private static bool kHXNz1rqtD;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static kgbOBx7BanbFa22Hp9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Q1fNiFmxZM = false;
		g5XNuHO1AT = typeof(kgbOBx7BanbFa22Hp9).Assembly;
		sAtNZCi53U = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		H8LNgLXnya = false;
		pnNNSrtoa3 = false;
		evYNnnkP1L = new byte[0];
		IexN1nn0Li = new byte[0];
		ra8NkNlyrY = new byte[0];
		aY3NE5Y8tr = new byte[0];
		gscNsxeiJM = IntPtr.Zero;
		DSxN0p9hXq = IntPtr.Zero;
		jDJNGXIFgx = new string[0];
		J6jN75udqX = new int[0];
		rlQNWg4f6u = 1;
		vEiNoRbjIm = false;
		lT4NP6G6an = new SortedList();
		MUnNjbGd7d = 0;
		MgnNcbYlLI = 0L;
		wNs00NSNU4 = null;
		ac80OR2c1l = null;
		VlJNd0xXYX = 0L;
		XgMNTADp6M = 0;
		lMbNv5ExiL = false;
		kHXNz1rqtD = false;
		fKSfAwLS7n = 0;
		Y2LfHc3vZM = IntPtr.Zero;
		XrafU9NwrM = false;
		yIq0dLwqw2 = new Hashtable();
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tUFr6nLShBey6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] jFTO0IAwg(byte[] P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		uint[] array = new uint[16];
		int num = 448 - P_0.Length * 8 % 512;
		uint num2 = (uint)((num + 512) % 512);
		if (num2 == 0)
		{
			num2 = 512u;
		}
		uint num3 = (uint)(P_0.Length + num2 / 8 + 8);
		ulong num4 = (ulong)P_0.Length * 8uL;
		byte[] array2 = new byte[num3];
		for (int i = 0; i < P_0.Length; i++)
		{
			array2[i] = P_0[i];
		}
		array2[P_0.Length] |= 128;
		for (int num5 = 8; num5 > 0; num5--)
		{
			array2[num3 - num5] = (byte)((num4 >> (8 - num5) * 8) & 0xFF);
		}
		uint num6 = (uint)(array2.Length * 8) / 32u;
		uint num7 = 1732584193u;
		uint num8 = 4023233417u;
		uint num9 = 2562383102u;
		uint num10 = 271733878u;
		for (uint num11 = 0u; num11 < num6 / 16; num11++)
		{
			uint num12 = num11 << 6;
			for (uint num13 = 0u; num13 < 61; num13 += 4)
			{
				array[num13 >> 2] = (uint)((array2[num12 + (num13 + 3)] << 24) | (array2[num12 + (num13 + 2)] << 16) | (array2[num12 + (num13 + 1)] << 8) | array2[num12 + num13]);
			}
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			uint num17 = num10;
			hcRNqwZGeq(ref num7, num8, num9, num10, 0u, 7, 1u, array);
			hcRNqwZGeq(ref num10, num7, num8, num9, 1u, 12, 2u, array);
			hcRNqwZGeq(ref num9, num10, num7, num8, 2u, 17, 3u, array);
			hcRNqwZGeq(ref num8, num9, num10, num7, 3u, 22, 4u, array);
			hcRNqwZGeq(ref num7, num8, num9, num10, 4u, 7, 5u, array);
			hcRNqwZGeq(ref num10, num7, num8, num9, 5u, 12, 6u, array);
			hcRNqwZGeq(ref num9, num10, num7, num8, 6u, 17, 7u, array);
			hcRNqwZGeq(ref num8, num9, num10, num7, 7u, 22, 8u, array);
			hcRNqwZGeq(ref num7, num8, num9, num10, 8u, 7, 9u, array);
			hcRNqwZGeq(ref num10, num7, num8, num9, 9u, 12, 10u, array);
			hcRNqwZGeq(ref num9, num10, num7, num8, 10u, 17, 11u, array);
			hcRNqwZGeq(ref num8, num9, num10, num7, 11u, 22, 12u, array);
			hcRNqwZGeq(ref num7, num8, num9, num10, 12u, 7, 13u, array);
			hcRNqwZGeq(ref num10, num7, num8, num9, 13u, 12, 14u, array);
			hcRNqwZGeq(ref num9, num10, num7, num8, 14u, 17, 15u, array);
			hcRNqwZGeq(ref num8, num9, num10, num7, 15u, 22, 16u, array);
			bEmNJ2rm7a(ref num7, num8, num9, num10, 1u, 5, 17u, array);
			bEmNJ2rm7a(ref num10, num7, num8, num9, 6u, 9, 18u, array);
			bEmNJ2rm7a(ref num9, num10, num7, num8, 11u, 14, 19u, array);
			bEmNJ2rm7a(ref num8, num9, num10, num7, 0u, 20, 20u, array);
			bEmNJ2rm7a(ref num7, num8, num9, num10, 5u, 5, 21u, array);
			bEmNJ2rm7a(ref num10, num7, num8, num9, 10u, 9, 22u, array);
			bEmNJ2rm7a(ref num9, num10, num7, num8, 15u, 14, 23u, array);
			bEmNJ2rm7a(ref num8, num9, num10, num7, 4u, 20, 24u, array);
			bEmNJ2rm7a(ref num7, num8, num9, num10, 9u, 5, 25u, array);
			bEmNJ2rm7a(ref num10, num7, num8, num9, 14u, 9, 26u, array);
			bEmNJ2rm7a(ref num9, num10, num7, num8, 3u, 14, 27u, array);
			bEmNJ2rm7a(ref num8, num9, num10, num7, 8u, 20, 28u, array);
			bEmNJ2rm7a(ref num7, num8, num9, num10, 13u, 5, 29u, array);
			bEmNJ2rm7a(ref num10, num7, num8, num9, 2u, 9, 30u, array);
			bEmNJ2rm7a(ref num9, num10, num7, num8, 7u, 14, 31u, array);
			bEmNJ2rm7a(ref num8, num9, num10, num7, 12u, 20, 32u, array);
			W7wNKJHKcx(ref num7, num8, num9, num10, 5u, 4, 33u, array);
			W7wNKJHKcx(ref num10, num7, num8, num9, 8u, 11, 34u, array);
			W7wNKJHKcx(ref num9, num10, num7, num8, 11u, 16, 35u, array);
			W7wNKJHKcx(ref num8, num9, num10, num7, 14u, 23, 36u, array);
			W7wNKJHKcx(ref num7, num8, num9, num10, 1u, 4, 37u, array);
			W7wNKJHKcx(ref num10, num7, num8, num9, 4u, 11, 38u, array);
			W7wNKJHKcx(ref num9, num10, num7, num8, 7u, 16, 39u, array);
			W7wNKJHKcx(ref num8, num9, num10, num7, 10u, 23, 40u, array);
			W7wNKJHKcx(ref num7, num8, num9, num10, 13u, 4, 41u, array);
			W7wNKJHKcx(ref num10, num7, num8, num9, 0u, 11, 42u, array);
			W7wNKJHKcx(ref num9, num10, num7, num8, 3u, 16, 43u, array);
			W7wNKJHKcx(ref num8, num9, num10, num7, 6u, 23, 44u, array);
			W7wNKJHKcx(ref num7, num8, num9, num10, 9u, 4, 45u, array);
			W7wNKJHKcx(ref num10, num7, num8, num9, 12u, 11, 46u, array);
			W7wNKJHKcx(ref num9, num10, num7, num8, 15u, 16, 47u, array);
			W7wNKJHKcx(ref num8, num9, num10, num7, 2u, 23, 48u, array);
			QWINR0aaKv(ref num7, num8, num9, num10, 0u, 6, 49u, array);
			QWINR0aaKv(ref num10, num7, num8, num9, 7u, 10, 50u, array);
			QWINR0aaKv(ref num9, num10, num7, num8, 14u, 15, 51u, array);
			QWINR0aaKv(ref num8, num9, num10, num7, 5u, 21, 52u, array);
			QWINR0aaKv(ref num7, num8, num9, num10, 12u, 6, 53u, array);
			QWINR0aaKv(ref num10, num7, num8, num9, 3u, 10, 54u, array);
			QWINR0aaKv(ref num9, num10, num7, num8, 10u, 15, 55u, array);
			QWINR0aaKv(ref num8, num9, num10, num7, 1u, 21, 56u, array);
			QWINR0aaKv(ref num7, num8, num9, num10, 8u, 6, 57u, array);
			QWINR0aaKv(ref num10, num7, num8, num9, 15u, 10, 58u, array);
			QWINR0aaKv(ref num9, num10, num7, num8, 6u, 15, 59u, array);
			QWINR0aaKv(ref num8, num9, num10, num7, 13u, 21, 60u, array);
			QWINR0aaKv(ref num7, num8, num9, num10, 4u, 6, 61u, array);
			QWINR0aaKv(ref num10, num7, num8, num9, 11u, 10, 62u, array);
			QWINR0aaKv(ref num9, num10, num7, num8, 2u, 15, 63u, array);
			QWINR0aaKv(ref num8, num9, num10, num7, 9u, 21, 64u, array);
			num7 += num14;
			num8 += num15;
			num9 += num16;
			num10 += num17;
		}
		byte[] array3 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num7), 0, array3, 0, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array3, 4, 4);
		Array.Copy(BitConverter.GetBytes(num9), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(num10), 0, array3, 12, 4);
		return array3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void hcRNqwZGeq(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0 = P_1 + OUyNaasHQu(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + sAtNZCi53U[P_6 - 1], P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void bEmNJ2rm7a(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0 = P_1 + OUyNaasHQu(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + sAtNZCi53U[P_6 - 1], P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void W7wNKJHKcx(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0 = P_1 + OUyNaasHQu(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + sAtNZCi53U[P_6 - 1], P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void QWINR0aaKv(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0 = P_1 + OUyNaasHQu(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + sAtNZCi53U[P_6 - 1], P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint OUyNaasHQu(uint P_0, ushort P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oBa2nbFa2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!H8LNgLXnya)
		{
			a3dE5uf4W();
			H8LNgLXnya = true;
		}
		return pnNNSrtoa3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SymmetricAlgorithm hHpd90tFy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (oBa2nbFa2())
		{
			return new AesCryptoServiceProvider();
		}
		try
		{
			return new RijndaelManaged();
		}
		catch
		{
			return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void a3dE5uf4W()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			pnNNSrtoa3 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] L4h818p6n(byte[] P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!oBa2nbFa2())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return jFTO0IAwg(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint QAvN6RalbE(uint P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[e6n0ejBIUP7FlAAGH4(typeof(e6n0ejBIUP7FlAAGH4.zcty0k3N9IXxl9ukmD<object>[]))]
	internal static string ol99ukmDA(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 335;
		byte[] array = default;
		int num7 = default;
		byte[] array2 = default;
		int num13 = default;
		int num10 = default;
		BinaryReader binaryReader = default;
		int num4 = default;
		uint num20 = default;
		uint num23 = default;
		byte[] array4 = default;
		byte[] array6 = default;
		SymmetricAlgorithm symmetricAlgorithm = default;
		byte[] array3 = default;
		CryptoStream cryptoStream = default;
		MemoryStream memoryStream = default;
		ICryptoTransform transform = default;
		int num16 = default;
		int num17 = default;
		int num11 = default;
		uint num15 = default;
		int num6 = default;
		byte[] array7 = default;
		uint num8 = default;
		int num14 = default;
		int num9 = default;
		int num35 = default;
		uint num21 = default;
		byte[] array5 = default;
		uint num18 = default;
		uint num22 = default;
		int num12 = default;
		uint num19 = default;
		int num3 = default;
		while (true)
		{
			int num5;
			int num2;
			switch (num)
			{
			case 100:
				array[4] = 143;
				num5 = 65;
				goto IL_2d7d;
			case 20:
				num7 = 44 + 34;
				num = 204;
				break;
			case 123:
				array2[0] = 142;
				num2 = 287;
				goto IL_2d81;
			case 202:
			case 429:
				if (num13 >= num10)
				{
					num2 = 215;
				}
				else
				{
					if (num13 <= 0)
					{
						goto case 285;
					}
					num2 = 4;
					if (false)
					{
						goto case 168;
					}
				}
				goto IL_2d81;
			case 174:
				num7 = 63 + 73;
				goto case 220;
			case 209:
				array[6] = (byte)num7;
				num5 = 3;
				goto IL_2d7d;
			case 6:
				R6wcaADtOnwBkWCKAy(binaryReader);
				num5 = 275;
				goto IL_2d7d;
			case 126:
				array2[3] = (byte)num4;
				num5 = 282;
				goto IL_2d7d;
			case 312:
				num4 = 38 - 36;
				num5 = 29;
				goto IL_2d7d;
			case 194:
				num4 = 122 + 45;
				num2 = 39;
				if (false)
				{
					goto case 392;
				}
				goto IL_2d81;
			case 392:
				array2[26] = (byte)num4;
				num2 = 139;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 181;
				}
				goto IL_2d81;
			case 330:
				array[1] = (byte)num7;
				num2 = 136;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 58;
				}
				goto IL_2d81;
			case 58:
				array[11] = 253;
				num = 233;
				break;
			case 168:
				num4 = 230 - 76;
				num = 214;
				break;
			case 314:
				num4 = 173 + 76;
				num = 267;
				break;
			case 380:
				num4 = 68 - 20;
				num2 = 135;
				if (false)
				{
					goto case 228;
				}
				goto IL_2d81;
			case 228:
				array2[7] = (byte)num4;
				num = 388;
				break;
			case 72:
				array2[25] = 142;
				num2 = 418;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 236;
				}
				goto IL_2d81;
			case 236:
				num7 = 179 - 59;
				num2 = 86;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 417;
				}
				goto IL_2d81;
			case 409:
				num7 = 188 - 62;
				num2 = 59;
				goto IL_2d81;
			case 366:
				array2[15] = (byte)num4;
				num2 = 34;
				if (false)
				{
					goto case 147;
				}
				goto IL_2d81;
			case 147:
				array[13] = 51;
				num5 = 255;
				goto IL_2d7d;
			case 38:
				array[12] = 248;
				num = 20;
				break;
			case 368:
				array2[16] = (byte)num4;
				num = 281;
				break;
			case 138:
				num4 = 171 + 69;
				num = 73;
				break;
			case 106:
				array[2] = 88;
				num2 = 151;
				goto IL_2d81;
			case 28:
				num7 = 122 + 45;
				num = 209;
				break;
			case 383:
				if (P_0 == -1)
				{
					num = 161;
					break;
				}
				goto case 130;
			case 393:
				num20 += num23;
				num2 = 322;
				goto IL_2d81;
			case 127:
				array2[4] = 128;
				num = 344;
				break;
			case 415:
				fnUSmJF2909hAnM3W1(array4);
				num5 = 150;
				goto IL_2d7d;
			case 269:
				num20 = 0u;
				num2 = 23;
				goto IL_2d81;
			case 130:
				num10 = array6.Length % 4;
				num5 = 64;
				goto IL_2d7d;
			case 247:
				array2[18] = 102;
				num = 422;
				break;
			case 27:
				num7 = 8 + 37;
				num2 = 231;
				goto IL_2d81;
			case 141:
				array2[22] = (byte)num4;
				num = 159;
				break;
			case 29:
				array2[6] = (byte)num4;
				num2 = 350;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 309;
				}
				goto IL_2d81;
			case 297:
				array[10] = (byte)num7;
				num5 = 399;
				goto IL_2d7d;
			case 304:
				array[4] = 104;
				num5 = 284;
				goto IL_2d7d;
			case 340:
				num7 = 17 + 112;
				num5 = 369;
				goto IL_2d7d;
			case 294:
				array2[9] = 86;
				num2 = 373;
				if (1 == 0)
				{
					goto case 82;
				}
				goto IL_2d81;
			case 82:
				array2[28] = 138;
				num2 = 326;
				if (false)
				{
					goto case 265;
				}
				goto IL_2d81;
			case 265:
				LfHaGi5i9c3xbCwqc5(symmetricAlgorithm, CipherMode.CBC);
				num2 = 107;
				goto IL_2d81;
			case 361:
				array2[11] = (byte)num4;
				num2 = 51;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 418;
				}
				goto IL_2d81;
			case 418:
				num4 = 108 + 91;
				num2 = 111;
				if (1 == 0)
				{
					goto case 287;
				}
				goto IL_2d81;
			case 287:
				num4 = 179 - 59;
				num2 = 414;
				goto IL_2d81;
			case 433:
				array4[3] = array3[1];
				num5 = 420;
				goto IL_2d7d;
			case 102:
				array2[1] = (byte)num4;
				num5 = 343;
				goto IL_2d7d;
			case 183:
				cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				num5 = 339;
				goto IL_2d7d;
			case 94:
				num7 = 124 + 26;
				num2 = 203;
				goto IL_2d81;
			case 176:
				array2[26] = 129;
				num2 = 46;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 99;
				}
				goto IL_2d81;
			case 154:
				array2[0] = 111;
				num2 = 310;
				if (1 == 0)
				{
					goto case 261;
				}
				goto IL_2d81;
			case 261:
				num4 = 14 + 90;
				num2 = 354;
				if (1 == 0)
				{
					goto case 328;
				}
				goto IL_2d81;
			case 328:
				num16 = 0;
				num = 80;
				break;
			case 193:
				array2[30] = (byte)num4;
				num2 = 54;
				if (false)
				{
					goto case 235;
				}
				goto IL_2d81;
			case 235:
				array = new byte[16];
				num = 394;
				break;
			case 11:
				array2[24] = (byte)num4;
				num = 143;
				break;
			case 10:
				array[5] = (byte)num7;
				num2 = 66;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 28;
				}
				goto IL_2d81;
			case 0:
				array2[6] = (byte)num4;
				num2 = 55;
				if (1 == 0)
				{
					goto case 416;
				}
				goto IL_2d81;
			case 416:
				num4 = 52 - 39;
				num2 = 398;
				goto IL_2d81;
			case 357:
				num7 = 0 + 40;
				num2 = 319;
				if (1 == 0)
				{
					goto case 217;
				}
				goto IL_2d81;
			case 217:
				array2[21] = 62;
				num2 = 170;
				goto IL_2d81;
			case 78:
				array[2] = (byte)num7;
				num = 53;
				break;
			case 104:
				array2[13] = (byte)num4;
				num5 = 405;
				goto IL_2d7d;
			case 333:
				num4 = 167 - 55;
				num2 = 336;
				if (1 == 0)
				{
					goto case 39;
				}
				goto IL_2d81;
			case 39:
				array2[6] = (byte)num4;
				num2 = 160;
				if (1 == 0)
				{
					goto case 233;
				}
				goto IL_2d81;
			case 233:
				num7 = 180 - 60;
				num2 = 342;
				goto IL_2d81;
			case 139:
				array2[26] = 112;
				num = 118;
				break;
			case 355:
				array2[6] = (byte)num4;
				num2 = 194;
				goto IL_2d81;
			case 360:
				num4 = 72 + 44;
				num2 = 105;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 337;
				}
				goto IL_2d81;
			case 337:
				array2[19] = 126;
				num = 95;
				break;
			case 109:
				array[10] = 101;
				num = 381;
				break;
			case 399:
				num7 = 6 + 41;
				num2 = 292;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 99;
				}
				goto IL_2d81;
			case 99:
				num4 = 15 + 56;
				num5 = 43;
				goto IL_2d7d;
			case 216:
				num4 = 4 + 97;
				num = 249;
				break;
			case 150:
				array3 = (byte[])igOran8NjCh2nI5om1(hLM7quyhVU3dK5MU0h(g5XNuHO1AT));
				num2 = 338;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 191;
				}
				goto IL_2d81;
			case 165:
				array2[31] = (byte)num4;
				num = 91;
				break;
			case 156:
				array[2] = (byte)num7;
				num2 = 114;
				if (1 == 0)
				{
					goto case 200;
				}
				goto IL_2d81;
			case 200:
				array[6] = 138;
				num2 = 9;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 246;
				}
				goto IL_2d81;
			case 246:
				array[10] = (byte)num7;
				num2 = 27;
				goto IL_2d81;
			case 339:
				BeZ0uViy2VKnjSZ8Ks(cryptoStream, array6, 0, array6.Length);
				num5 = 272;
				goto IL_2d7d;
			case 153:
				num17 = num11 * 4;
				num2 = 76;
				if (1 == 0)
				{
					goto case 244;
				}
				goto IL_2d81;
			case 244:
				num15 |= array6[array6.Length - (1 + num6)];
				num5 = 87;
				goto IL_2d7d;
			case 245:
				array2[20] = (byte)num4;
				num2 = 321;
				if (1 == 0)
				{
					goto case 276;
				}
				goto IL_2d81;
			case 276:
				array[1] = 95;
				num = 325;
				break;
			case 394:
				num7 = 139 - 46;
				num = 196;
				break;
			case 345:
				array4[13] = array3[6];
				num2 = 186;
				if (1 == 0)
				{
					goto case 23;
				}
				goto IL_2d81;
			case 23:
				num23 = 0u;
				num2 = 17;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 90;
				}
				goto IL_2d81;
			case 90:
				array[7] = (byte)num7;
				num = 124;
				break;
			case 437:
				num23 = (uint)((array7[num8 + 3] << 24) | (array7[num8 + 2] << 16) | (array7[num8 + 1] << 8) | array7[num8]);
				num2 = 69;
				goto IL_2d81;
			case 185:
				array4 = array;
				num2 = 415;
				goto IL_2d81;
			case 214:
				array2[27] = (byte)num4;
				num5 = 113;
				goto IL_2d7d;
			case 49:
				array2[0] = 84;
				num2 = 184;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 251;
				}
				goto IL_2d81;
			case 260:
				num4 = 171 - 57;
				num = 239;
				break;
			case 128:
				array2[14] = 141;
				num2 = 99;
				if (i1BesGYK62T52vW1n7())
				{
					goto IL_2d81;
				}
				goto case 317;
			case 239:
				array2[12] = (byte)num4;
				num = 225;
				break;
			case 97:
				array2[1] = (byte)num4;
				num2 = 218;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 22;
				}
				goto IL_2d81;
			case 22:
				array2[20] = (byte)num4;
				num2 = 416;
				if (false)
				{
					goto case 47;
				}
				goto IL_2d81;
			case 47:
			case 268:
				if (num11 >= num14)
				{
					num5 = 175;
					goto IL_2d7d;
				}
				num9 = num11 % num35;
				num2 = 153;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 91;
				}
				goto IL_2d81;
			case 420:
				array4[5] = array3[2];
				num5 = 253;
				goto IL_2d7d;
			case 77:
				array[4] = (byte)num7;
				num5 = 427;
				goto IL_2d7d;
			case 253:
				array4[7] = array3[3];
				num2 = 224;
				goto IL_2d81;
			case 93:
				array2[19] = 97;
				num2 = 337;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 226;
				}
				goto IL_2d81;
			case 226:
				num4 = 126 - 42;
				num5 = 42;
				goto IL_2d7d;
			case 86:
				array[8] = (byte)num7;
				num = 419;
				break;
			case 124:
				array[7] = 108;
				num = 94;
				break;
			case 14:
				array[0] = (byte)num7;
				num = 266;
				break;
			case 372:
				array2[5] = 146;
				num = 226;
				break;
			case 251:
				num4 = 99 + 38;
				num = 104;
				break;
			case 2:
				num4 = 161 - 53;
				num5 = 193;
				goto IL_2d7d;
			case 112:
				array[5] = 44;
				num5 = 200;
				goto IL_2d7d;
			case 405:
				array2[13] = 100;
				num = 362;
				break;
			case 152:
				array2[22] = (byte)num4;
				num2 = 379;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 188;
				}
				goto IL_2d81;
			case 401:
				num35 = array7.Length / 4;
				num2 = 269;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 237;
				}
				goto IL_2d81;
			case 56:
				array2[24] = (byte)num4;
				num5 = 169;
				goto IL_2d7d;
			case 231:
				array[11] = (byte)num7;
				num2 = 85;
				goto IL_2d81;
			case 396:
				if (num10 <= 0)
				{
					goto IL_0896;
				}
				num2 = 68;
				if (false)
				{
					goto case 414;
				}
				goto IL_2d81;
			case 414:
				array2[0] = (byte)num4;
				num2 = 154;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 275;
				}
				goto IL_2d81;
			case 275:
				array2 = new byte[32];
				num = 49;
				break;
			case 26:
				array2[2] = (byte)num4;
				num = 221;
				break;
			case 164:
				array2[29] = 132;
				num5 = 261;
				goto IL_2d7d;
			case 187:
				array[15] = 156;
				num5 = 213;
				goto IL_2d7d;
			case 113:
				array2[27] = 120;
				num = 374;
				break;
			case 151:
				num7 = 124 - 68;
				num = 156;
				break;
			case 114:
				num7 = 109 + 88;
				num = 208;
				break;
			case 41:
				num4 = 204 - 68;
				num2 = 286;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 110;
				}
				goto IL_2d81;
			case 110:
			case 199:
				num4 = 110 + 63;
				num2 = 129;
				if (false)
				{
					goto case 279;
				}
				goto IL_2d81;
			case 279:
				num14++;
				num5 = 144;
				goto IL_2d7d;
			case 320:
				array2[21] = (byte)num4;
				num = 223;
				break;
			case 182:
			{
				uint num24 = num21;
				uint num25 = num21;
				uint num26 = 700955840u;
				uint num27 = 116293686u;
				uint num28 = 1214538550u;
				uint num29 = 689500885u;
				uint num30 = num25;
				uint num31 = 547073577u;
				ulong num32 = 2139439153 * num29;
				num32 |= 1;
				num26 = (uint)(num26 * num26 % num32);
				uint num33 = num27 & 0x55555555;
				uint num34 = num27 & 0xAAAAAAAAu;
				num33 = ((num33 >> 1) | (num34 << 1)) ^ num28;
				num27 = (num27 << 5) | (num27 >> 27);
				num27 = 3995151 * (num27 & 0x1FF) - (num27 >> 9);
				num26 = 3367361 * (num26 & 0x1FF) - (num26 >> 9);
				num26 = 67024 * num26 - num27;
				num27 = 937 * (num27 & 0xFFFFF) - (num27 >> 20);
				num26 = 3685 * (num26 & 0xFFFFF) - (num26 >> 20);
				num26 = 58222 * num26 + num27;
				num31 -= num26;
				num30 ^= num30 >> 3;
				num30 += num28;
				num30 ^= num30 >> 25;
				num30 += num29;
				num30 ^= num30 << 23;
				num30 += num31;
				num30 = (((num29 << 7) - num28) ^ num28) + num30;
				num21 = num24 + (uint)(double)num30;
				num5 = 120;
				goto IL_2d7d;
			}
			case 105:
				array2[10] = (byte)num4;
				num2 = 13;
				goto IL_2d81;
			case 136:
				num7 = 179 - 59;
				num2 = 370;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 292;
				}
				goto IL_2d81;
			case 96:
				array2[3] = 90;
				num2 = 115;
				goto IL_2d81;
			case 179:
				array2[24] = 105;
				num2 = 157;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 232;
				}
				goto IL_2d81;
			case 232:
				array[9] = 142;
				num2 = 256;
				goto IL_2d81;
			case 18:
			case 400:
				num21 = num20;
				num2 = 288;
				goto IL_2d81;
			case 48:
				array2[11] = (byte)num4;
				num = 83;
				break;
			case 381:
				num7 = 102 + 44;
				num5 = 246;
				goto IL_2d7d;
			case 95:
				array2[19] = 22;
				num2 = 198;
				goto IL_2d81;
			case 425:
				array2[18] = (byte)num4;
				num2 = 307;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 1;
				}
				goto IL_2d81;
			case 1:
				num7 = 90 + 48;
				num5 = 10;
				goto IL_2d7d;
			case 382:
				array2[17] = 50;
				num = 248;
				break;
			case 75:
				num7 = 49 + 73;
				num2 = 146;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 20;
				}
				goto IL_2d81;
			case 55:
				array2[6] = 198;
				num = 376;
				break;
			case 79:
				array2[20] = (byte)num4;
				num2 = 395;
				if (1 == 0)
				{
					goto case 292;
				}
				goto IL_2d81;
			case 292:
				array[10] = (byte)num7;
				num2 = 237;
				if (1 == 0)
				{
					goto case 391;
				}
				goto IL_2d81;
			case 391:
				num15 = (uint)((array6[num8 + 3] << 24) | (array6[num8 + 2] << 16) | (array6[num8 + 1] << 8) | array6[num8]);
				num = 400;
				break;
			case 229:
				array2[11] = (byte)num4;
				num = 207;
				break;
			case 107:
				transform = (ICryptoTransform)fr0LtEqE3RJbm24MJE(symmetricAlgorithm, array7, array4);
				num2 = 278;
				goto IL_2d81;
			case 19:
				array2[22] = (byte)num4;
				num = 385;
				break;
			case 336:
				array2[8] = (byte)num4;
				num5 = 155;
				goto IL_2d7d;
			case 295:
				array5[num17 + 1] = (byte)((num18 & 0xFF00) >> 8);
				num2 = 365;
				if (false)
				{
					goto case 354;
				}
				goto IL_2d81;
			case 354:
				array2[30] = (byte)num4;
				num2 = 371;
				goto IL_2d81;
			case 284:
				num7 = 117 + 68;
				num2 = 77;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 40;
				}
				goto IL_2d81;
			case 40:
				array5 = new byte[array6.Length];
				num2 = 401;
				goto IL_2d81;
			case 146:
				array[9] = (byte)num7;
				num2 = 271;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 46;
				}
				goto IL_2d81;
			case 46:
				num4 = 231 - 77;
				num2 = 392;
				if (false)
				{
					goto case 145;
				}
				goto IL_2d81;
			case 145:
				array2[9] = 117;
				num = 294;
				break;
			case 31:
				array2[8] = 103;
				num2 = 41;
				goto IL_2d81;
			case 390:
				array[10] = (byte)num7;
				num5 = 109;
				goto IL_2d7d;
			case 80:
				if (num11 == num14 - 1)
				{
					num = 436;
					break;
				}
				goto IL_2d03;
			case 25:
				num7 = 195 - 65;
				num = 277;
				break;
			case 350:
				num4 = 152 - 50;
				num5 = 228;
				goto IL_2d7d;
			case 335:
				if (ra8NkNlyrY.Length != 0)
				{
					goto case 206;
				}
				num5 = 52;
				goto IL_2d7d;
			case 222:
				array6 = (byte[])T8xCtN19MwXYyMAnn1(binaryReader, (int)eBiXEut2iB4YnG4won(dfxfZNZVbu4YhB6MJA(binaryReader)));
				num = 6;
				break;
			case 323:
				num4 = 134 - 44;
				num2 = 195;
				if (false)
				{
					goto case 310;
				}
				goto IL_2d81;
			case 310:
				num4 = 97 + 69;
				num2 = 102;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 212;
				}
				goto IL_2d81;
			case 212:
				array2[8] = (byte)num4;
				num5 = 177;
				goto IL_2d7d;
			case 188:
				array2[2] = (byte)num4;
				num2 = 103;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 250;
				}
				goto IL_2d81;
			case 388:
				num4 = 17 + 112;
				num2 = 356;
				if (1 == 0)
				{
					goto case 158;
				}
				goto IL_2d81;
			case 158:
				array2[23] = 94;
				num = 138;
				break;
			case 157:
				array2[24] = 86;
				num5 = 108;
				goto IL_2d7d;
			case 103:
				num4 = 39 + 109;
				num = 92;
				break;
			case 230:
				array2[18] = (byte)num4;
				num2 = 247;
				if (0 == 0)
				{
					goto IL_2d81;
				}
				goto case 161;
			case 282:
				num4 = 114 + 119;
				num = 7;
				break;
			case 305:
				array[6] = (byte)num7;
				num2 = 28;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 288;
				}
				goto IL_2d81;
			case 288:
				num20 = 0u;
				num5 = 182;
				goto IL_2d7d;
			case 365:
				array5[num17 + 2] = (byte)((num18 & 0xFF0000) >> 16);
				num2 = 21;
				goto IL_2d81;
			case 133:
				LGUdsZonXO5VRWYl6Z(dfxfZNZVbu4YhB6MJA(binaryReader), 0L);
				num2 = 222;
				goto IL_2d81;
			case 16:
				array2[11] = 109;
				num = 260;
				break;
			case 404:
				array2[9] = (byte)num4;
				num = 435;
				break;
			case 241:
				array2[17] = (byte)num4;
				num5 = 382;
				goto IL_2d7d;
			case 375:
				array2[28] = (byte)num4;
				num5 = 353;
				goto IL_2d7d;
			case 169:
				num4 = 72 - 65;
				num5 = 408;
				goto IL_2d7d;
			case 68:
				num22 = num20 ^ num15;
				num5 = 98;
				goto IL_2d7d;
			case 53:
				array[2] = 156;
				num2 = 240;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 131;
				}
				goto IL_2d81;
			case 131:
				Xcye2FP7CJUrp2Z0GE(memoryStream);
				num = 384;
				break;
			case 343:
				num4 = 80 + 39;
				num = 137;
				break;
			case 238:
				num12++;
				num2 = 283;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 160;
				}
				goto IL_2d81;
			case 160:
				array2[6] = 90;
				num2 = 312;
				goto IL_2d81;
			case 167:
				num4 = 172 - 48;
				num2 = 148;
				if (false)
				{
					goto case 300;
				}
				goto IL_2d81;
			case 300:
				num7 = 80 + 39;
				num5 = 36;
				goto IL_2d7d;
			case 54:
				num4 = 242 - 80;
				num5 = 35;
				goto IL_2d7d;
			case 362:
				num4 = 200 - 66;
				num2 = 171;
				if (false)
				{
					goto case 45;
				}
				goto IL_2d81;
			case 45:
				num7 = 209 - 69;
				num5 = 30;
				goto IL_2d7d;
			case 91:
				array7 = array2;
				num5 = 235;
				goto IL_2d7d;
			case 430:
				array2[10] = 47;
				num2 = 88;
				if (1 == 0)
				{
					goto case 428;
				}
				goto IL_2d81;
			case 428:
				num4 = 49 + 46;
				num2 = 97;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 250;
				}
				goto IL_2d81;
			case 250:
				num4 = 224 - 74;
				num = 402;
				break;
			case 224:
				array4[9] = array3[4];
				num = 432;
				break;
			case 424:
				array2[3] = 130;
				num5 = 211;
				goto IL_2d7d;
			case 4:
				num19 <<= 8;
				num = 341;
				break;
			case 367:
				array2[31] = 69;
				num5 = 234;
				goto IL_2d7d;
			case 332:
				array2[27] = 130;
				num5 = 318;
				goto IL_2d7d;
			case 178:
				array2[5] = (byte)num4;
				num2 = 372;
				goto IL_2d81;
			case 33:
				array2[25] = (byte)num4;
				num = 346;
				break;
			case 73:
				array2[23] = (byte)num4;
				num = 189;
				break;
			case 122:
				num4 = 69 + 16;
				num5 = 254;
				goto IL_2d7d;
			case 356:
				array2[7] = (byte)num4;
				num = 411;
				break;
			case 419:
				array[8] = 154;
				num = 121;
				break;
			case 159:
				array2[22] = 94;
				num2 = 24;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 311;
				}
				goto IL_2d81;
			case 311:
				array2[23] = (byte)num4;
				num2 = 158;
				goto IL_2d81;
			case 436:
				if (num10 <= 0)
				{
					goto IL_2d03;
				}
				num2 = 423;
				goto IL_2d81;
			case 155:
				num4 = 5 + 49;
				num2 = 212;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 359;
				}
				goto IL_2d81;
			case 359:
				array[15] = 152;
				num2 = 187;
				goto IL_2d81;
			case 308:
				num4 = 109 - 2;
				num = 368;
				break;
			case 411:
				num4 = 163 - 96;
				num2 = 306;
				goto IL_2d81;
			case 197:
				array[4] = 194;
				num5 = 100;
				goto IL_2d7d;
			case 35:
				array2[30] = (byte)num4;
				num = 70;
				break;
			case 89:
				array2[25] = 112;
				num = 72;
				break;
			case 363:
				num15 <<= 8;
				num = 244;
				break;
			case 385:
				array2[22] = 153;
				num5 = 163;
				goto IL_2d7d;
			case 132:
				num7 = 134 - 44;
				num2 = 403;
				if (1 == 0)
				{
					goto case 74;
				}
				goto IL_2d81;
			case 74:
				ra8NkNlyrY = (byte[])eyLZdSbw7kFMvcqXA4(memoryStream);
				num2 = 131;
				if (1 == 0)
				{
					goto case 252;
				}
				goto IL_2d81;
			case 252:
				array2[13] = 107;
				num2 = 352;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 239;
				}
				goto IL_2d81;
			case 62:
				num7 = 86 + 15;
				num5 = 297;
				goto IL_2d7d;
			case 148:
				array2[5] = (byte)num4;
				num = 263;
				break;
			case 210:
			case 283:
				if (num12 >= array4.Length)
				{
					num5 = 383;
					goto IL_2d7d;
				}
				array7[num12] ^= array4[num12];
				num = 238;
				break;
			case 196:
				array[0] = (byte)num7;
				num = 242;
				break;
			case 87:
				num6++;
				num5 = 227;
				goto IL_2d7d;
			case 175:
				ra8NkNlyrY = array5;
				num5 = 206;
				goto IL_2d7d;
			case 218:
				num4 = 214 - 71;
				num = 439;
				break;
			case 213:
				array[15] = 104;
				num2 = 185;
				goto IL_2d81;
			case 211:
				array2[3] = 87;
				num5 = 96;
				goto IL_2d7d;
			case 358:
				array2[19] = 147;
				num2 = 291;
				if (false)
				{
					goto case 389;
				}
				goto IL_2d81;
			case 389:
				num4 = 45 + 21;
				num2 = 262;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 397;
				}
				goto IL_2d81;
			case 397:
				array[1] = (byte)num7;
				num = 84;
				break;
			case 120:
				num20 = num21;
				num5 = 274;
				goto IL_2d7d;
			case 206:
				num3 = d7tqccTttpfC88qkLK(ra8NkNlyrY, P_0);
				num2 = 441;
				if (false)
				{
					goto case 221;
				}
				goto IL_2d81;
			case 221:
				array2[2] = 145;
				num5 = 424;
				goto IL_2d7d;
			case 347:
				array6 = ra8NkNlyrY;
				num2 = 130;
				if (1 == 0)
				{
					goto case 316;
				}
				goto IL_2d81;
			case 316:
				num4 = 229 - 108;
				num5 = 165;
				goto IL_2d7d;
			case 327:
				num4 = 82 + 18;
				num = 8;
				break;
			case 184:
				array2[0] = 206;
				num5 = 32;
				goto IL_2d7d;
			case 410:
				array2[1] = 89;
				num5 = 412;
				goto IL_2d7d;
			case 242:
				array[0] = 102;
				num = 101;
				break;
			case 273:
				num4 = 57 + 50;
				num = 407;
				break;
			case 285:
				array5[num17 + num13] = (byte)((num22 & num19) >> num16);
				num5 = 331;
				goto IL_2d7d;
			case 71:
				num4 = 192 - 64;
				num5 = 178;
				goto IL_2d7d;
			case 50:
				num4 = 220 - 73;
				num5 = 425;
				goto IL_2d7d;
			case 36:
				array[1] = (byte)num7;
				num5 = 296;
				goto IL_2d7d;
			case 64:
				num14 = array6.Length / 4;
				num2 = 40;
				if (false)
				{
					goto case 352;
				}
				goto IL_2d81;
			case 352:
				num4 = 145 - 48;
				num5 = 134;
				goto IL_2d7d;
			case 249:
				array2[31] = (byte)num4;
				num = 316;
				break;
			case 369:
				array[8] = (byte)num7;
				num2 = 301;
				if (1 == 0)
				{
					goto case 256;
				}
				goto IL_2d81;
			case 256:
				array[9] = 166;
				num2 = 75;
				goto IL_2d81;
			case 364:
				array[1] = (byte)num7;
				num5 = 300;
				goto IL_2d7d;
			case 149:
				array2[1] = 221;
				num2 = 410;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 51;
				}
				goto IL_2d81;
			case 51:
				num4 = 40 + 83;
				num5 = 119;
				goto IL_2d7d;
			case 319:
				array[12] = (byte)num7;
				num = 192;
				break;
			case 299:
				num4 = 95 + 54;
				num = 241;
				break;
			case 370:
				array[1] = (byte)num7;
				num2 = 276;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 438;
				}
				goto IL_2d81;
			case 438:
				num4 = 179 - 87;
				num2 = 366;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 119;
				}
				goto IL_2d81;
			case 119:
				array2[11] = (byte)num4;
				num5 = 162;
				goto IL_2d7d;
			case 321:
				num4 = 249 - 83;
				num = 219;
				break;
			case 406:
				array2[26] = 161;
				num2 = 250;
				if (false)
				{
					goto case 258;
				}
				goto IL_2d81;
			case 258:
				array[14] = 204;
				num = 302;
				break;
			case 440:
				array[6] = (byte)num7;
				num5 = 377;
				goto IL_2d7d;
			case 349:
				array2[18] = (byte)num4;
				num2 = 358;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 193;
				}
				goto IL_2d81;
			case 66:
				num7 = 190 - 63;
				num5 = 387;
				goto IL_2d7d;
			case 65:
				array[4] = 41;
				num5 = 304;
				goto IL_2d7d;
			case 291:
				num4 = 116 + 115;
				num2 = 37;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 85;
				}
				goto IL_2d81;
			case 85:
				num7 = 228 - 76;
				num2 = 67;
				goto IL_2d81;
			case 111:
				array2[25] = (byte)num4;
				num = 60;
				break;
			case 255:
				num7 = 91 + 64;
				num = 386;
				break;
			case 37:
				array2[19] = (byte)num4;
				num = 93;
				break;
			case 417:
				array[14] = 97;
				num2 = 174;
				if (false)
				{
					goto case 237;
				}
				goto IL_2d81;
			case 237:
				num7 = 71 + 119;
				num2 = 390;
				if (!MCAqpXNXuU3VQatAnE())
				{
					goto IL_2d81;
				}
				goto case 439;
			case 290:
				num4 = 138 - 46;
				num2 = 320;
				goto IL_2d81;
			case 215:
			case 289:
				num11++;
				num2 = 47;
				if (false)
				{
					goto case 309;
				}
				goto IL_2d81;
			case 309:
				array2[31] = (byte)num4;
				num5 = 173;
				goto IL_2d7d;
			case 434:
				array2[12] = 166;
				num = 327;
				break;
			case 9:
				num7 = 123 + 75;
				num2 = 440;
				goto IL_2d81;
			case 240:
				array[2] = 162;
				num2 = 106;
				goto IL_2d81;
			case 263:
				num4 = 206 - 68;
				num = 0;
				break;
			case 423:
				num15 = 0u;
				num = 393;
				break;
			case 67:
				array[11] = (byte)num7;
				num = 58;
				break;
			case 254:
				array2[29] = (byte)num4;
				num2 = 164;
				goto IL_2d81;
			case 377:
				num7 = 189 - 63;
				num = 305;
				break;
			case 69:
				num19 = 255u;
				num2 = 328;
				goto IL_2d81;
			case 192:
				array[12] = 174;
				num = 38;
				break;
			case 264:
				array5[num17] = (byte)(num18 & 0xFF);
				num2 = 295;
				goto IL_2d81;
			case 225:
				array2[12] = 140;
				num = 434;
				break;
			case 315:
				array2[8] = (byte)num4;
				num2 = 145;
				goto IL_2d81;
			case 201:
				num4 = 148 - 49;
				num2 = 26;
				goto IL_2d81;
			case 234:
				num4 = 126 - 42;
				num = 309;
				break;
			case 21:
				array5[num17 + 3] = (byte)((num18 & 0xFF000000u) >> 24);
				num2 = 289;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 209;
				}
				goto IL_2d81;
			case 204:
				array[13] = (byte)num7;
				num2 = 409;
				if (false)
				{
					goto case 334;
				}
				goto IL_2d81;
			case 334:
				array2[16] = 203;
				num2 = 308;
				if (false)
				{
					goto case 171;
				}
				goto IL_2d81;
			case 171:
				array2[14] = (byte)num4;
				num5 = 128;
				goto IL_2d7d;
			case 42:
				array2[5] = (byte)num4;
				num = 167;
				break;
			case 57:
				array2[21] = 29;
				num = 190;
				break;
			case 422:
				num4 = 134 - 110;
				num = 349;
				break;
			case 432:
				array4[11] = array3[5];
				num = 345;
				break;
			case 59:
				array[13] = (byte)num7;
				num5 = 270;
				goto IL_2d7d;
			case 371:
				array2[30] = 138;
				num5 = 2;
				goto IL_2d7d;
			case 203:
				array[7] = (byte)num7;
				num = 340;
				break;
			case 407:
				array2[15] = (byte)num4;
				num2 = 438;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 327;
				}
				goto IL_2d81;
			case 118:
				array2[26] = 126;
				num5 = 406;
				goto IL_2d7d;
			case 431:
				array[9] = (byte)num7;
				num5 = 62;
				goto IL_2d7d;
			case 378:
				num4 = 173 - 57;
				num5 = 257;
				goto IL_2d7d;
			case 162:
				array2[11] = 163;
				num2 = 16;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 121;
				}
				goto IL_2d81;
			case 121:
				array[8] = 136;
				num5 = 232;
				goto IL_2d7d;
			case 61:
				array2[12] = (byte)num4;
				_ = 0;
				num5 = (i1BesGYK62T52vW1n7() ? 199 : 220);
				goto IL_2d7d;
			case 170:
				array2[21] = 109;
				num2 = 57;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 81;
				}
				goto IL_2d81;
			case 81:
				array4[1] = array3[0];
				num = 433;
				break;
			case 108:
				num4 = 197 - 65;
				num = 56;
				break;
			case 374:
				num4 = 140 - 46;
				num = 205;
				break;
			case 280:
				array2[29] = 155;
				num5 = 122;
				goto IL_2d7d;
			case 307:
				array2[18] = 165;
				num2 = 44;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 269;
				}
				goto IL_2d81;
			case 386:
				array[13] = (byte)num7;
				num5 = 417;
				goto IL_2d7d;
			case 348:
				num4 = 141 - 47;
				num5 = 317;
				goto IL_2d7d;
			case 32:
				array2[0] = 58;
				num5 = 123;
				goto IL_2d7d;
			case 248:
				array2[17] = 50;
				num2 = 50;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 413;
				}
				goto IL_2d81;
			case 60:
				num4 = 99 - 81;
				num = 33;
				break;
			case 413:
				array[5] = (byte)num7;
				num2 = 1;
				if (1 == 0)
				{
					goto case 134;
				}
				goto IL_2d81;
			case 134:
				array2[13] = (byte)num4;
				num5 = 251;
				goto IL_2d7d;
			case 34:
				array2[16] = 90;
				num5 = 334;
				goto IL_2d7d;
			case 325:
				num7 = 196 - 65;
				num2 = 364;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 183;
				}
				goto IL_2d81;
			case 135:
				array2[14] = (byte)num4;
				num2 = 378;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 350;
				}
				goto IL_2d81;
			case 84:
				num7 = 154 - 51;
				num2 = 78;
				goto IL_2d81;
			case 296:
				num7 = 71 - 49;
				num2 = 397;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 398;
				}
				goto IL_2d81;
			case 398:
				array2[20] = (byte)num4;
				num5 = 259;
				goto IL_2d7d;
			case 83:
				num4 = 201 - 67;
				num5 = 361;
				goto IL_2d7d;
			case 129:
				array2[13] = (byte)num4;
				num5 = 252;
				goto IL_2d7d;
			case 293:
				array2[4] = 143;
				num = 348;
				break;
			case 272:
				LiesR9BfuxFfe4YG1P(cryptoStream);
				num2 = 74;
				goto IL_2d81;
			case 298:
				array2[12] = 146;
				num2 = 421;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 346;
				}
				goto IL_2d81;
			case 346:
				num4 = 132 - 44;
				num5 = 166;
				goto IL_2d7d;
			case 208:
				array[3] = (byte)num7;
				num2 = 45;
				goto IL_2d81;
			case 313:
				array2[15] = 129;
				num = 273;
				break;
			case 277:
				array[3] = (byte)num7;
				num5 = 324;
				goto IL_2d7d;
			case 191:
				array[3] = (byte)num7;
				num2 = 132;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 172;
				}
				goto IL_2d81;
			case 44:
				array2[18] = 96;
				num2 = 303;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 258;
				}
				goto IL_2d81;
			case 342:
				array[12] = (byte)num7;
				num = 181;
				break;
			case 257:
				array2[15] = (byte)num4;
				num5 = 313;
				goto IL_2d7d;
			case 326:
				num4 = 143 + 29;
				num5 = 375;
				goto IL_2d7d;
			case 271:
				num7 = 91 - 41;
				num = 431;
				break;
			case 177:
				num4 = 61 + 74;
				num2 = 315;
				if (false)
				{
					goto case 219;
				}
				goto IL_2d81;
			case 219:
				array2[20] = (byte)num4;
				num = 243;
				break;
			case 395:
				num4 = 148 - 49;
				num5 = 22;
				goto IL_2d7d;
			case 116:
				array2[22] = (byte)num4;
				num5 = 329;
				goto IL_2d7d;
			case 376:
				num4 = 189 - 63;
				num2 = 355;
				goto IL_2d81;
			case 373:
				num4 = 41 + 60;
				num = 404;
				break;
			case 318:
				array2[27] = 73;
				num5 = 168;
				goto IL_2d7d;
			case 195:
				array2[8] = (byte)num4;
				num = 31;
				break;
			case 207:
				num4 = 53 + 89;
				num5 = 48;
				goto IL_2d7d;
			case 8:
				array2[12] = (byte)num4;
				num5 = 298;
				goto IL_2d7d;
			case 115:
				num4 = 208 - 69;
				num5 = 126;
				goto IL_2d7d;
			case 15:
				num8 = (uint)num17;
				num5 = 391;
				goto IL_2d7d;
			case 341:
				num16 += 8;
				num = 285;
				break;
			case 387:
				array[5] = (byte)num7;
				num5 = 112;
				goto IL_2d7d;
			case 435:
				array2[9] = 150;
				num5 = 389;
				goto IL_2d7d;
			case 303:
				num4 = 162 - 54;
				num = 230;
				break;
			case 270:
				array[13] = 149;
				num5 = 147;
				goto IL_2d7d;
			case 266:
				array[0] = 221;
				num = 140;
				break;
			case 88:
				num4 = 99 + 50;
				num5 = 229;
				goto IL_2d7d;
			case 402:
				array2[27] = (byte)num4;
				num5 = 332;
				goto IL_2d7d;
			case 163:
				num4 = 47 + 109;
				num = 152;
				break;
			case 17:
				num15 = 0u;
				num = 117;
				break;
			case 140:
				num7 = 79 + 85;
				num2 = 330;
				if (1 == 0)
				{
					goto case 3;
				}
				goto IL_2d81;
			case 3:
				array[6] = 227;
				num2 = 180;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 8;
				}
				goto IL_2d81;
			case 403:
				array[3] = (byte)num7;
				num2 = 12;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 377;
				}
				goto IL_2d81;
			case 186:
				array4[15] = array3[7];
				num2 = 426;
				if (false)
				{
					goto case 274;
				}
				goto IL_2d81;
			case 274:
				if (num11 != num14 - 1)
				{
					goto IL_0896;
				}
				num2 = 396;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 172;
				}
				goto IL_2d81;
			case 331:
				num13++;
				num5 = 429;
				goto IL_2d7d;
			case 223:
				array2[21] = 183;
				num5 = 217;
				goto IL_2d7d;
			case 92:
				array2[2] = (byte)num4;
				num5 = 201;
				goto IL_2d7d;
			case 144:
				num8 = 0u;
				num = 63;
				break;
			case 220:
			case 351:
				array[14] = (byte)num7;
				num2 = 258;
				if (false)
				{
					goto case 353;
				}
				goto IL_2d81;
			case 353:
				array2[29] = 103;
				num2 = 280;
				if (false)
				{
					goto case 24;
				}
				goto IL_2d81;
			case 24:
				num4 = 71 - 22;
				num = 116;
				break;
			case 98:
				num13 = 0;
				num = 202;
				break;
			case 12:
				array[3] = 200;
				num = 197;
				break;
			case 125:
				array2[10] = (byte)num4;
				num2 = 430;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 5;
				}
				goto IL_2d81;
			case 5:
				if (array3.Length > 0)
				{
					num = 81;
					break;
				}
				goto case 426;
			case 408:
				array2[24] = (byte)num4;
				num2 = 89;
				if (false)
				{
					goto case 18;
				}
				goto IL_2d81;
			case 181:
				array[12] = 159;
				num5 = 357;
				goto IL_2d7d;
			case 412:
				num4 = 35 + 80;
				num = 188;
				break;
			case 198:
				num4 = 128 - 42;
				num5 = 245;
				goto IL_2d7d;
			case 205:
				array2[28] = (byte)num4;
				goto case 82;
			default:
				num = 82;
				break;
			case 259:
				array2[21] = 109;
				num5 = 290;
				goto IL_2d7d;
			case 267:
				array2[4] = (byte)num4;
				num2 = 71;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 175;
				}
				goto IL_2d81;
			case 180:
				num7 = 210 - 70;
				num5 = 90;
				goto IL_2d7d;
			case 63:
				num11 = 0;
				num2 = 268;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 307;
				}
				goto IL_2d81;
			case 384:
				Xcye2FP7CJUrp2Z0GE(cryptoStream);
				num5 = 347;
				goto IL_2d7d;
			case 427:
				num7 = 103 + 64;
				num5 = 413;
				goto IL_2d7d;
			case 101:
				num7 = 88 + 39;
				num5 = 14;
				goto IL_2d7d;
			case 344:
				num4 = 70 + 75;
				num2 = 142;
				if (i1BesGYK62T52vW1n7())
				{
					goto IL_2d81;
				}
				goto case 137;
			case 137:
				array2[1] = (byte)num4;
				num = 428;
				break;
			case 189:
				num4 = 161 - 53;
				num5 = 11;
				goto IL_2d7d;
			case 243:
				num4 = 101 + 48;
				num = 79;
				break;
			case 13:
				num4 = 134 - 44;
				num5 = 125;
				goto IL_2d7d;
			case 142:
				array2[4] = (byte)num4;
				num2 = 314;
				if (MCAqpXNXuU3VQatAnE())
				{
					goto case 145;
				}
				goto IL_2d81;
			case 7:
				array2[3] = (byte)num4;
				num2 = 293;
				if (0 == 0)
				{
					goto IL_2d81;
				}
				goto case 338;
			case 338:
				if (array3 != null)
				{
					num = 5;
					break;
				}
				goto case 426;
			case 426:
				num12 = 0;
				num = 210;
				break;
			case 421:
				num4 = 121 - 41;
				num5 = 61;
				goto IL_2d7d;
			case 166:
				array2[26] = (byte)num4;
				num5 = 176;
				goto IL_2d7d;
			case 172:
			case 227:
				if (num6 < num10)
				{
					if (num6 <= 0)
					{
						goto case 244;
					}
					num5 = 363;
					goto IL_2d7d;
				}
				num2 = 18;
				goto IL_2d81;
			case 286:
				array2[8] = (byte)num4;
				num5 = 333;
				goto IL_2d7d;
			case 143:
				array2[24] = 140;
				num5 = 179;
				goto IL_2d7d;
			case 281:
				array2[17] = 159;
				num5 = 299;
				goto IL_2d7d;
			case 117:
				if (num10 > 0)
				{
					num = 279;
					break;
				}
				goto case 144;
			case 76:
				num8 = (uint)(num9 * 4);
				num5 = 437;
				goto IL_2d7d;
			case 324:
				num7 = 130 - 43;
				num5 = 191;
				goto IL_2d7d;
			case 262:
				array2[10] = (byte)num4;
				num2 = 360;
				goto IL_2d81;
			case 173:
				array2[31] = 211;
				num5 = 216;
				goto IL_2d7d;
			case 317:
				array2[4] = (byte)num4;
				num2 = 127;
				if (i1BesGYK62T52vW1n7())
				{
					goto IL_2d81;
				}
				goto case 379;
			case 379:
				num4 = 170 - 56;
				num = 141;
				break;
			case 70:
				array2[30] = 44;
				num2 = 367;
				goto IL_2d81;
			case 306:
				array2[7] = (byte)num4;
				num = 323;
				break;
			case 30:
				array[3] = (byte)num7;
				num = 25;
				break;
			case 322:
				num6 = 0;
				num = 172;
				break;
			case 439:
				array2[1] = (byte)num4;
				num = 149;
				break;
			case 52:
				binaryReader = new BinaryReader((Stream)KQUM7khIc5M3Rm5GxL(g5XNuHO1AT, "AB3oWuyKvTuTWfAfQ9.MZwvVsehmukFMDpGkd"));
				num2 = 133;
				goto IL_2d81;
			case 301:
				array[8] = 215;
				num2 = 236;
				goto IL_2d81;
			case 329:
				num4 = 201 - 67;
				num5 = 311;
				goto IL_2d7d;
			case 43:
				array2[14] = (byte)num4;
				num2 = 380;
				goto IL_2d81;
			case 190:
				num4 = 123 + 115;
				num2 = 19;
				if (true)
				{
					goto IL_2d81;
				}
				goto case 302;
			case 302:
				array[15] = 97;
				num5 = 359;
				goto IL_2d7d;
			case 441:
				try
				{
					return (string)PIjpvtHylkGkcfVWwl(pWPuaWeoDdcoMBjiUP(), ra8NkNlyrY, P_0 + 4, num3);
				}
				catch
				{
				}
				return "";
			case 278:
				memoryStream = new MemoryStream();
				num2 = 183;
				goto IL_2d81;
			case 161:
				{
					symmetricAlgorithm = (SymmetricAlgorithm)jeSxSW6alRI5MeLjk7();
					num2 = 265;
					goto IL_2d81;
				}
				IL_2d03:
				num20 += num23;
				num = 15;
				break;
				IL_0896:
				num18 = num20 ^ num15;
				num2 = 264;
				if (!i1BesGYK62T52vW1n7())
				{
					goto case 150;
				}
				goto IL_2d81;
				IL_2d7d:
				num2 = num5;
				goto IL_2d81;
				IL_2d81:
				num = num2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[e6n0ejBIUP7FlAAGH4(typeof(e6n0ejBIUP7FlAAGH4.zcty0k3N9IXxl9ukmD<object>[]))]
	internal static string A5TugUXyq(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int fOUNpmub22()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return 5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void WPcN3MPq00()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Delegate HWkN9kE2yn(IntPtr P_0, Type P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[2] { P_0, P_1 });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Brl5TS23a(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			if (File.Exists(((Assembly)P_0).Location))
			{
				return ((Assembly)P_0).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)P_0).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((Assembly)P_0).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
				.ToString()))
			{
				return P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
					.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[e6n0ejBIUP7FlAAGH4(typeof(e6n0ejBIUP7FlAAGH4.zcty0k3N9IXxl9ukmD<object>[]))]
	private static byte[] L32NLZyhH1(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		using FileStream fileStream = new FileStream(P_0, FileMode.Open, FileAccess.Read, FileShare.Read);
		int num = 0;
		long length = fileStream.Length;
		int num2 = (int)length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			num += num3;
			num2 -= num3;
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[e6n0ejBIUP7FlAAGH4(typeof(e6n0ejBIUP7FlAAGH4.zcty0k3N9IXxl9ukmD<object>[]))]
	private static byte[] HcBNVAeKaw(byte[] P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MemoryStream memoryStream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = hHpd90tFy();
		symmetricAlgorithm.Key = new byte[32]
		{
			140, 153, 216, 32, 208, 74, 132, 212, 94, 167,
			4, 168, 165, 52, 200, 37, 89, 224, 158, 23,
			83, 156, 21, 13, 144, 52, 204, 117, 107, 134,
			17, 71
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			88, 68, 23, 157, 231, 253, 101, 93, 19, 215,
			114, 161, 189, 112, 101, 170
		};
		CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] UZxNOiKrOn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] kuUNtXkBk2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] wOoN8E7v4Q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] U7oNh7rCqw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string text = "{11111-22222-20001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] uWXNDGFmQ3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] MxENwdpsai()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] UWmehmKtk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] ijqb0ABkx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] x2nasDp9d()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string text = "{11111-22222-50001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal byte[] IdsjjcYpS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string text = "{11111-22222-50001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public kgbOBx7BanbFa22Hp9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KQUM7khIc5M3Rm5GxL(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dfxfZNZVbu4YhB6MJA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BinaryReader)P_0).BaseStream;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LGUdsZonXO5VRWYl6Z(object P_0, long P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Position = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long eBiXEut2iB4YnG4won(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Stream)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object T8xCtN19MwXYyMAnn1(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BinaryReader)P_0).ReadBytes(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void R6wcaADtOnwBkWCKAy(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BinaryReader)P_0).Close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fnUSmJF2909hAnM3W1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Array.Reverse((Array)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hLM7quyhVU3dK5MU0h(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Assembly)P_0).GetName();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object igOran8NjCh2nI5om1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jeSxSW6alRI5MeLjk7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return hHpd90tFy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LfHaGi5i9c3xbCwqc5(object P_0, CipherMode P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fr0LtEqE3RJbm24MJE(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BeZ0uViy2VKnjSZ8Ks(object P_0, object P_1, int P_2, int P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LiesR9BfuxFfe4YG1P(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CryptoStream)P_0).FlushFinalBlock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eyLZdSbw7kFMvcqXA4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MemoryStream)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Xcye2FP7CJUrp2Z0GE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int d7tqccTttpfC88qkLK(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return BitConverter.ToInt32((byte[])P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pWPuaWeoDdcoMBjiUP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Encoding.Unicode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PIjpvtHylkGkcfVWwl(object P_0, object P_1, int P_2, int P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Encoding)P_0).GetString((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool i1BesGYK62T52vW1n7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MCAqpXNXuU3VQatAnE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
