using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using b4Zxkh9w1NDrmwo2EQ;

namespace pthEIVC1aCm1sfNHFV;

internal class Qcm4wV57Dtu9gCobq9
{
	private delegate void HgPSTBLuBfl4P78DD3(object o);

	internal class i2n8gg7g19hnqW3PeZ : Attribute
	{
		internal class kI4QkNbRW8fxM2yPhp<WJV8QWxsKyXV6gkkjI>
		{
			private static object HoBxRP5x80cvHsR9aNf;

			public kI4QkNbRW8fxM2yPhp()
			{
				YmJIsd6U0Ob0UH6n6b.h4GbY9szT1s12();
				base._002Ector();
				int num = 0;
				if (1 == 0)
				{
					int num2;
					num = num2;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static bool BjPFb25j5Lvr5r9OJJo()
			{
				return HoBxRP5x80cvHsR9aNf == null;
			}

			internal static object mCBZdV5mbfKYLIvVHpg()
			{
				return HoBxRP5x80cvHsR9aNf;
			}
		}

		[i2n8gg7g19hnqW3PeZ(typeof(kI4QkNbRW8fxM2yPhp<object>[]))]
		public i2n8gg7g19hnqW3PeZ(object P_0)
		{
		}
	}

	internal class NVvGRNhpOBsFAtoMEV
	{
		[i2n8gg7g19hnqW3PeZ(typeof(i2n8gg7g19hnqW3PeZ.kI4QkNbRW8fxM2yPhp<object>[]))]
		internal static string dxpTbtLNFK(string P_0, string P_1)
		{
			byte[] array = (byte[])ywtilK57oue5jYjuj2Z(uf30Sp5J5Hn0ofJIFgZ(), P_0);
			byte[] array2 = array;
			byte[] key = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] iV = Rt9IIKEm6e((byte[])ywtilK57oue5jYjuj2Z(Encoding.Unicode, P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = (SymmetricAlgorithm)lvmC3L5nr23147ixFQp();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array2, 0, array2.Length);
			cryptoStream.Close();
			return (string)t1V0gS51q8cmF7RGe45(memoryStream.ToArray());
		}

		internal static object uf30Sp5J5Hn0ofJIFgZ()
		{
			return Encoding.Unicode;
		}

		internal static object ywtilK57oue5jYjuj2Z(object P_0, object P_1)
		{
			return ((Encoding)P_0).GetBytes((string)P_1);
		}

		internal static object lvmC3L5nr23147ixFQp()
		{
			return YvKznWcCX();
		}

		internal static object t1V0gS51q8cmF7RGe45(object P_0)
		{
			return Convert.ToBase64String((byte[])P_0);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint RBhyPAFYF9oCaOfuKT(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr cxXUKif5QaCop31EFU();

	internal struct N4HKeLqMqZ2pVggOLF
	{
		internal bool X8aTxjpgLt;

		internal byte[] po9ThTl74B;
	}

	internal class TC32Ply6qZXwRIkt80
	{
		private BinaryReader xBYTURGK3U;

		public TC32Ply6qZXwRIkt80(Stream P_0)
		{
			xBYTURGK3U = new BinaryReader(P_0);
		}

		[SpecialName]
		internal Stream fHSkdAnkJf()
		{
			return xBYTURGK3U.BaseStream;
		}

		internal byte[] OiXTFQbycs(int P_0)
		{
			return (byte[])zJPjQA5SEpGh9Ma799w(xBYTURGK3U, P_0);
		}

		internal int xhgTfGkQC1(byte[] P_0, int P_1, int P_2)
		{
			return xBYTURGK3U.Read(P_0, P_1, P_2);
		}

		internal int toSTq6dxe2()
		{
			return xBYTURGK3U.ReadInt32();
		}

		internal void AW8Ty8H8Aw()
		{
			BE9cl25vH2fU39p0Pm7(xBYTURGK3U);
		}

		internal static object zJPjQA5SEpGh9Ma799w(object P_0, int P_1)
		{
			return ((BinaryReader)P_0).ReadBytes(P_1);
		}

		internal static void BE9cl25vH2fU39p0Pm7(object P_0)
		{
			((BinaryReader)P_0).Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr qTIjDuUEM5d5bDYJV6(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr efwUVPtuhDcmfeWUjl(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int eUFFmUXQ2psPxb79Eu(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int jYOyygroVfb7cW3w3e(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr BtZacZwNweSkfrxuQF(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int G0Yqhk8yOcce6r7vHY(IntPtr ptr);

	[Flags]
	private enum VgASMbgTo3d09iPTiy
	{

	}

	private static object jcKIQ0bUi2;

	private static byte[] uXoISjY7j5;

	private static object pPYIHaBwEw;

	private static int OhFIRoyQRq;

	internal static RBhyPAFYF9oCaOfuKT j8eIVsjYOu;

	private static long NQLIG7YS0f;

	private static int gXiID0SDxn;

	private static bool j8EIOuge28;

	private static bool tErIn3Ia2M;

	private static IntPtr ESdTAe0p5W;

	private static qTIjDuUEM5d5bDYJV6 RTNTmRnPDn;

	private static eUFFmUXQ2psPxb79Eu xRATd2Qa1D;

	private static IntPtr YKbT7BoYjU;

	private static bool zaKIYgx2jV;

	private static IntPtr mhYIBZxFxa;

	private static efwUVPtuhDcmfeWUjl Jt1TEdiDBs;

	private static uint[] Lf8IlrwFiO;

	private static IntPtr oRhIusnPeg;

	private static Assembly Nd7IcY14HO;

	private static byte[] URWIWFRVnZ;

	private static long IGWIMhi62K;

	private static byte[] IHnIa50jJI;

	[i2n8gg7g19hnqW3PeZ(typeof(i2n8gg7g19hnqW3PeZ.kI4QkNbRW8fxM2yPhp<object>[]))]
	private static bool fBkTIJv4BY;

	private static int[] jRjIKN4aM4;

	private static int fX6I3VBvxW;

	internal static RBhyPAFYF9oCaOfuKT FnKIj3Fe95;

	private static jYOyygroVfb7cW3w3e fe3T5xyeU1;

	private static Dictionary<int, int> uSDIeHyUbW;

	internal static Hashtable FmgTTjc0qF;

	private static BtZacZwNweSkfrxuQF bZDTCYTcoW;

	private static bool cNtI43t5Fj;

	private static byte[] LbQIZruJVF;

	private static bool tMZIPRepUD;

	private static bool m8oI2csaMn;

	private static SortedList lo3IJ1SkHN;

	private static G0Yqhk8yOcce6r7vHY mjTTLae5BA;

	private static int WEkIzMNH3B;

	static Qcm4wV57Dtu9gCobq9()
	{
		m8oI2csaMn = false;
		Nd7IcY14HO = typeof(Qcm4wV57Dtu9gCobq9).Assembly;
		Lf8IlrwFiO = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		tMZIPRepUD = false;
		zaKIYgx2jV = false;
		LbQIZruJVF = new byte[0];
		IHnIa50jJI = new byte[0];
		uSDIeHyUbW = null;
		jcKIQ0bUi2 = new object();
		URWIWFRVnZ = new byte[0];
		uXoISjY7j5 = new byte[0];
		mhYIBZxFxa = IntPtr.Zero;
		oRhIusnPeg = IntPtr.Zero;
		pPYIHaBwEw = new string[0];
		jRjIKN4aM4 = new int[0];
		OhFIRoyQRq = 1;
		cNtI43t5Fj = false;
		lo3IJ1SkHN = new SortedList();
		fX6I3VBvxW = 0;
		IGWIMhi62K = 0L;
		FnKIj3Fe95 = null;
		j8eIVsjYOu = null;
		NQLIG7YS0f = 0L;
		gXiID0SDxn = 0;
		j8EIOuge28 = false;
		tErIn3Ia2M = false;
		WEkIzMNH3B = 0;
		ESdTAe0p5W = IntPtr.Zero;
		fBkTIJv4BY = false;
		FmgTTjc0qF = new Hashtable();
		RTNTmRnPDn = null;
		Jt1TEdiDBs = null;
		xRATd2Qa1D = null;
		fe3T5xyeU1 = null;
		bZDTCYTcoW = null;
		mjTTLae5BA = null;
		YKbT7BoYjU = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void sALbY9sJp5AQK()
	{
	}

	internal static byte[] Kk0MRWQcl(byte[] P_0)
	{
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
			LRljM76s7(ref num7, num8, num9, num10, 0u, 7, 1u, array);
			LRljM76s7(ref num10, num7, num8, num9, 1u, 12, 2u, array);
			LRljM76s7(ref num9, num10, num7, num8, 2u, 17, 3u, array);
			LRljM76s7(ref num8, num9, num10, num7, 3u, 22, 4u, array);
			LRljM76s7(ref num7, num8, num9, num10, 4u, 7, 5u, array);
			LRljM76s7(ref num10, num7, num8, num9, 5u, 12, 6u, array);
			LRljM76s7(ref num9, num10, num7, num8, 6u, 17, 7u, array);
			LRljM76s7(ref num8, num9, num10, num7, 7u, 22, 8u, array);
			LRljM76s7(ref num7, num8, num9, num10, 8u, 7, 9u, array);
			LRljM76s7(ref num10, num7, num8, num9, 9u, 12, 10u, array);
			LRljM76s7(ref num9, num10, num7, num8, 10u, 17, 11u, array);
			LRljM76s7(ref num8, num9, num10, num7, 11u, 22, 12u, array);
			LRljM76s7(ref num7, num8, num9, num10, 12u, 7, 13u, array);
			LRljM76s7(ref num10, num7, num8, num9, 13u, 12, 14u, array);
			LRljM76s7(ref num9, num10, num7, num8, 14u, 17, 15u, array);
			LRljM76s7(ref num8, num9, num10, num7, 15u, 22, 16u, array);
			ifCVaLlWc(ref num7, num8, num9, num10, 1u, 5, 17u, array);
			ifCVaLlWc(ref num10, num7, num8, num9, 6u, 9, 18u, array);
			ifCVaLlWc(ref num9, num10, num7, num8, 11u, 14, 19u, array);
			ifCVaLlWc(ref num8, num9, num10, num7, 0u, 20, 20u, array);
			ifCVaLlWc(ref num7, num8, num9, num10, 5u, 5, 21u, array);
			ifCVaLlWc(ref num10, num7, num8, num9, 10u, 9, 22u, array);
			ifCVaLlWc(ref num9, num10, num7, num8, 15u, 14, 23u, array);
			ifCVaLlWc(ref num8, num9, num10, num7, 4u, 20, 24u, array);
			ifCVaLlWc(ref num7, num8, num9, num10, 9u, 5, 25u, array);
			ifCVaLlWc(ref num10, num7, num8, num9, 14u, 9, 26u, array);
			ifCVaLlWc(ref num9, num10, num7, num8, 3u, 14, 27u, array);
			ifCVaLlWc(ref num8, num9, num10, num7, 8u, 20, 28u, array);
			ifCVaLlWc(ref num7, num8, num9, num10, 13u, 5, 29u, array);
			ifCVaLlWc(ref num10, num7, num8, num9, 2u, 9, 30u, array);
			ifCVaLlWc(ref num9, num10, num7, num8, 7u, 14, 31u, array);
			ifCVaLlWc(ref num8, num9, num10, num7, 12u, 20, 32u, array);
			okWGZfqv1(ref num7, num8, num9, num10, 5u, 4, 33u, array);
			okWGZfqv1(ref num10, num7, num8, num9, 8u, 11, 34u, array);
			okWGZfqv1(ref num9, num10, num7, num8, 11u, 16, 35u, array);
			okWGZfqv1(ref num8, num9, num10, num7, 14u, 23, 36u, array);
			okWGZfqv1(ref num7, num8, num9, num10, 1u, 4, 37u, array);
			okWGZfqv1(ref num10, num7, num8, num9, 4u, 11, 38u, array);
			okWGZfqv1(ref num9, num10, num7, num8, 7u, 16, 39u, array);
			okWGZfqv1(ref num8, num9, num10, num7, 10u, 23, 40u, array);
			okWGZfqv1(ref num7, num8, num9, num10, 13u, 4, 41u, array);
			okWGZfqv1(ref num10, num7, num8, num9, 0u, 11, 42u, array);
			okWGZfqv1(ref num9, num10, num7, num8, 3u, 16, 43u, array);
			okWGZfqv1(ref num8, num9, num10, num7, 6u, 23, 44u, array);
			okWGZfqv1(ref num7, num8, num9, num10, 9u, 4, 45u, array);
			okWGZfqv1(ref num10, num7, num8, num9, 12u, 11, 46u, array);
			okWGZfqv1(ref num9, num10, num7, num8, 15u, 16, 47u, array);
			okWGZfqv1(ref num8, num9, num10, num7, 2u, 23, 48u, array);
			aReDIMAw6(ref num7, num8, num9, num10, 0u, 6, 49u, array);
			aReDIMAw6(ref num10, num7, num8, num9, 7u, 10, 50u, array);
			aReDIMAw6(ref num9, num10, num7, num8, 14u, 15, 51u, array);
			aReDIMAw6(ref num8, num9, num10, num7, 5u, 21, 52u, array);
			aReDIMAw6(ref num7, num8, num9, num10, 12u, 6, 53u, array);
			aReDIMAw6(ref num10, num7, num8, num9, 3u, 10, 54u, array);
			aReDIMAw6(ref num9, num10, num7, num8, 10u, 15, 55u, array);
			aReDIMAw6(ref num8, num9, num10, num7, 1u, 21, 56u, array);
			aReDIMAw6(ref num7, num8, num9, num10, 8u, 6, 57u, array);
			aReDIMAw6(ref num10, num7, num8, num9, 15u, 10, 58u, array);
			aReDIMAw6(ref num9, num10, num7, num8, 6u, 15, 59u, array);
			aReDIMAw6(ref num8, num9, num10, num7, 13u, 21, 60u, array);
			aReDIMAw6(ref num7, num8, num9, num10, 4u, 6, 61u, array);
			aReDIMAw6(ref num10, num7, num8, num9, 11u, 10, 62u, array);
			aReDIMAw6(ref num9, num10, num7, num8, 2u, 15, 63u, array);
			aReDIMAw6(ref num8, num9, num10, num7, 9u, 21, 64u, array);
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

	private static void LRljM76s7(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + eZHOwdYdm(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + Lf8IlrwFiO[P_6 - 1], P_5);
	}

	private static void ifCVaLlWc(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + eZHOwdYdm(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + Lf8IlrwFiO[P_6 - 1], P_5);
	}

	private static void okWGZfqv1(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + eZHOwdYdm(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + Lf8IlrwFiO[P_6 - 1], P_5);
	}

	private static void aReDIMAw6(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + eZHOwdYdm(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + Lf8IlrwFiO[P_6 - 1], P_5);
	}

	private static uint eZHOwdYdm(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	internal static bool Rcln5dfLZ()
	{
		if (!tMZIPRepUD)
		{
			cpDIAEKy6A();
			tMZIPRepUD = true;
		}
		return zaKIYgx2jV;
	}

	internal static SymmetricAlgorithm YvKznWcCX()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (Rcln5dfLZ())
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

	internal static void cpDIAEKy6A()
	{
		try
		{
			zaKIYgx2jV = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] Rt9IIKEm6e(byte[] P_0)
	{
		if (!Rcln5dfLZ())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return Kk0MRWQcl(P_0);
	}

	public static void dvkITxs7RQ(RuntimeTypeHandle P_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(P_0);
			if (uSDIeHyUbW == null)
			{
				lock (jcKIQ0bUi2)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(Qcm4wV57Dtu9gCobq9).Assembly.GetManifestResourceStream("H6ZLMYLfcJmyKLrPr5.9FWiLRJyRafiqkhLS8"));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					binaryReader.Close();
					if (array.Length > 0)
					{
						int num = array.Length % 4;
						int num2 = array.Length / 4;
						byte[] array2 = new byte[array.Length];
						uint num3 = 0u;
						uint num4 = 0u;
						if (num > 0)
						{
							num2++;
						}
						uint num5 = 0u;
						for (int i = 0; i < num2; i++)
						{
							int num6 = i * 4;
							uint num7 = 255u;
							int num8 = 0;
							if (i == num2 - 1 && num > 0)
							{
								num4 = 0u;
								for (int j = 0; j < num; j++)
								{
									if (j > 0)
									{
										num4 <<= 8;
									}
									num4 |= array[array.Length - (1 + j)];
								}
							}
							else
							{
								num5 = (uint)num6;
								num4 = (uint)((array[num5 + 3] << 24) | (array[num5 + 2] << 16) | (array[num5 + 1] << 8) | array[num5]);
							}
							num3 = num3;
							num3 += kEYIdfMZ8u(num3);
							if (i == num2 - 1 && num > 0)
							{
								uint num9 = num3 ^ num4;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num7 <<= 8;
										num8 += 8;
									}
									array2[num6 + k] = (byte)((num9 & num7) >> num8);
								}
							}
							else
							{
								uint num10 = num3 ^ num4;
								array2[num6] = (byte)(num10 & 0xFF);
								array2[num6 + 1] = (byte)((num10 & 0xFF00) >> 8);
								array2[num6 + 2] = (byte)((num10 & 0xFF0000) >> 16);
								array2[num6 + 3] = (byte)((num10 & 0xFF000000u) >> 24);
							}
						}
						array = array2;
						array2 = null;
						int num11 = array.Length / 8;
						TC32Ply6qZXwRIkt80 tC32Ply6qZXwRIkt = new TC32Ply6qZXwRIkt80(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = tC32Ply6qZXwRIkt.toSTq6dxe2();
							int value = tC32Ply6qZXwRIkt.toSTq6dxe2();
							dictionary.Add(key, value);
						}
						tC32Ply6qZXwRIkt.AW8Ty8H8Aw();
					}
					uSDIeHyUbW = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = uSDIeHyUbW[metadataToken];
				bool flag = (num12 & 0x40000000) > 0;
				num12 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)typeof(Qcm4wV57Dtu9gCobq9).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
				if (methodInfo.IsStatic)
				{
					fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
					continue;
				}
				ParameterInfo[] parameters = methodInfo.GetParameters();
				int num13 = parameters.Length + 1;
				Type[] array3 = new Type[num13];
				if (methodInfo.DeclaringType.IsValueType)
				{
					array3[0] = methodInfo.DeclaringType.MakeByRefType();
				}
				else
				{
					array3[0] = typeof(object);
				}
				for (int n = 0; n < parameters.Length; n++)
				{
					array3[n + 1] = parameters[n].ParameterType;
				}
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				for (int num14 = 0; num14 < num13; num14++)
				{
					switch (num14)
					{
					case 0:
						iLGenerator.Emit(OpCodes.Ldarg_0);
						break;
					case 1:
						iLGenerator.Emit(OpCodes.Ldarg_1);
						break;
					case 2:
						iLGenerator.Emit(OpCodes.Ldarg_2);
						break;
					case 3:
						iLGenerator.Emit(OpCodes.Ldarg_3);
						break;
					default:
						iLGenerator.Emit(OpCodes.Ldarg_S, num14);
						break;
					}
				}
				iLGenerator.Emit(OpCodes.Tailcall);
				iLGenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
				iLGenerator.Emit(OpCodes.Ret);
				fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
			}
		}
		catch (Exception)
		{
		}
	}

	private static uint ckCIECbQjH(uint P_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint kEYIdfMZ8u(uint P_0)
	{
		return 0u;
	}

	internal static void CP0I52VOLF()
	{
	}

	[i2n8gg7g19hnqW3PeZ(typeof(i2n8gg7g19hnqW3PeZ.kI4QkNbRW8fxM2yPhp<object>[]))]
	internal static string d2PIC2DeoW(int P_0)
	{
		int num = 144;
		int num19 = default;
		byte[] array = default;
		int num18 = default;
		uint num36 = default;
		int num39 = default;
		int num20 = default;
		byte[] array2 = default;
		ICryptoTransform transform = default;
		SymmetricAlgorithm symmetricAlgorithm = default;
		byte[] array7 = default;
		byte[] array3 = default;
		byte[] array6 = default;
		int num31 = default;
		uint num32 = default;
		int num29 = default;
		CryptoStream cryptoStream = default;
		byte[] array5 = default;
		uint num25 = default;
		uint num33 = default;
		byte[] array4 = default;
		int num26 = default;
		uint num4 = default;
		uint num35 = default;
		int num38 = default;
		uint num37 = default;
		uint num30 = default;
		int num41 = default;
		int num27 = default;
		TC32Ply6qZXwRIkt80 tC32Ply6qZXwRIkt = default;
		Stream stream = default;
		int num21 = default;
		int num34 = default;
		int num40 = default;
		int num28 = default;
		int num23 = default;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 302:
					num19 = 102 + 19;
					num = 22;
					break;
				case 65:
					array[21] = (byte)num18;
					num2 = 109;
					continue;
				case 286:
					num36 = (uint)(num39 * 4);
					num2 = 97;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 375:
					array[13] = (byte)num20;
					num2 = 189;
					continue;
				case 206:
					array[11] = 127;
					num2 = 291;
					continue;
				case 94:
					array[0] = 75;
					num2 = 380;
					if (!TiW9M7lntM9CTiSLTj())
					{
						num2 = 164;
					}
					continue;
				case 283:
					array[23] = 105;
					num2 = 15;
					continue;
				case 25:
					array[2] = 114;
					num = 216;
					break;
				case 382:
					array[14] = 97;
					num2 = 173;
					if (e43uQ39Slxr6EwOuML() != null)
					{
						num2 = 27;
					}
					continue;
				case 230:
					num19 = 131 - 43;
					num2 = 255;
					continue;
				case 250:
					num19 = 194 - 64;
					num2 = 334;
					continue;
				case 273:
					array[2] = (byte)num18;
					num2 = 388;
					continue;
				case 21:
					num18 = 115 + 66;
					num2 = 70;
					continue;
				case 50:
					array2[6] = (byte)num19;
					num = 302;
					break;
				case 389:
					num36 = 0u;
					num2 = 320;
					if (e43uQ39Slxr6EwOuML() != null)
					{
						num2 = 100;
					}
					continue;
				case 203:
					num19 = 30 + 103;
					num2 = 58;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 216:
					num18 = 82 + 49;
					num2 = 17;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						num2 = 19;
					}
					continue;
				case 335:
					transform = (ICryptoTransform)tXyXUtXJYldyxR5pMY(symmetricAlgorithm, array7, array3);
					num = 171;
					break;
				case 154:
					array[9] = (byte)num20;
					num2 = 71;
					continue;
				case 87:
					array[1] = 115;
					num2 = 359;
					continue;
				case 11:
					array[10] = (byte)num20;
					num2 = 134;
					continue;
				case 211:
					num18 = 26 + 92;
					num2 = 392;
					continue;
				case 200:
					array[22] = 100;
					num2 = 315;
					continue;
				case 184:
					if (P_0 == -1)
					{
						num2 = 285;
						continue;
					}
					goto case 105;
				case 324:
					array6[num31] = (byte)(num32 & 0xFF);
					num2 = 177;
					continue;
				case 127:
					array[15] = 159;
					num2 = 322;
					continue;
				case 306:
					array[5] = 87;
					num2 = 217;
					continue;
				case 239:
				case 344:
					if (num29 >= array3.Length)
					{
						num2 = 184;
						continue;
					}
					goto case 82;
				case 52:
					array2[5] = 87;
					num2 = 63;
					continue;
				case 307:
					array[28] = 145;
					num2 = 138;
					continue;
				case 90:
					array[2] = (byte)num20;
					num2 = 25;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 120:
					num18 = 194 - 85;
					num2 = 86;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 98:
					num18 = 235 - 78;
					num2 = 151;
					continue;
				case 293:
					array2[1] = 118;
					num2 = 308;
					continue;
				case 99:
					array[19] = 98;
					num2 = 363;
					continue;
				case 15:
					array[23] = 112;
					num2 = 150;
					continue;
				case 189:
					num18 = 103 + 64;
					num2 = 280;
					continue;
				case 285:
					symmetricAlgorithm = (SymmetricAlgorithm)qoB3ZD32PthkeqRpBh();
					num2 = 349;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 394:
					num19 = 108 + 82;
					num2 = 313;
					continue;
				case 254:
					array[12] = 147;
					num2 = 381;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 271:
					num20 = 33 + 96;
					num2 = 168;
					if (TiW9M7lntM9CTiSLTj())
					{
						num2 = 186;
					}
					continue;
				case 314:
					array[18] = (byte)num18;
					num2 = 98;
					if (!TiW9M7lntM9CTiSLTj())
					{
						num2 = 64;
					}
					continue;
				case 381:
					num18 = 108 + 27;
					num2 = 113;
					continue;
				case 374:
					array2[9] = (byte)num19;
					num2 = 39;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 88:
					array[20] = 143;
					num2 = 152;
					continue;
				case 282:
					array[26] = 198;
					num2 = 3;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						num2 = 43;
					}
					continue;
				case 219:
					array[1] = (byte)num20;
					num2 = 149;
					continue;
				case 409:
					num20 = 12 + 119;
					num = 28;
					break;
				case 125:
					array[28] = (byte)num20;
					num2 = 145;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 196:
					array[28] = 130;
					num2 = 234;
					continue;
				case 261:
					fsDkYSw0e5yRohZA9F(cryptoStream, array5, 0, array5.Length);
					num2 = 385;
					continue;
				case 256:
					array2[10] = (byte)num19;
					num2 = 65;
					if (TiW9M7lntM9CTiSLTj())
					{
						num2 = 202;
					}
					continue;
				case 259:
					num20 = 204 - 68;
					num2 = 11;
					continue;
				case 23:
					array[16] = 102;
					num2 = 42;
					if (!TiW9M7lntM9CTiSLTj())
					{
						num2 = 0;
					}
					continue;
				case 263:
					array[6] = (byte)num20;
					num = 169;
					break;
				case 4:
					array2[13] = 65;
					num2 = 2;
					if (TiW9M7lntM9CTiSLTj())
					{
						num2 = 57;
					}
					continue;
				case 222:
					num18 = 48 + 88;
					num2 = 118;
					continue;
				case 69:
					array2[9] = 86;
					num2 = 27;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 42:
					num18 = 249 - 83;
					num2 = 60;
					continue;
				case 362:
					array5 = URWIWFRVnZ;
					num2 = 105;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 232:
					array[8] = 130;
					num2 = 110;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 173:
					array[14] = 84;
					num2 = 127;
					continue;
				case 183:
					array[17] = 106;
					num2 = 267;
					continue;
				case 347:
					num25 = 0u;
					num2 = 66;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 353:
					array[24] = 91;
					num2 = 220;
					continue;
				case 8:
					array[26] = 131;
					num2 = 282;
					continue;
				case 181:
					array[5] = 114;
					num2 = 147;
					continue;
				case 299:
					num18 = 31 - 14;
					num2 = 370;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 295:
					array2[3] = 142;
					num2 = 124;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 229:
					array[30] = 52;
					num2 = 46;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 111:
					array[1] = (byte)num18;
					num2 = 102;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 108:
					num33 <<= 8;
					num2 = 5;
					continue;
				case 237:
					if (array4.Length > 0)
					{
						num2 = 130;
						continue;
					}
					goto case 83;
				case 270:
					array[30] = 128;
					num2 = 62;
					continue;
				case 277:
					array[14] = 207;
					num2 = 114;
					continue;
				case 91:
					array[3] = 97;
					num2 = 0;
					if (!TiW9M7lntM9CTiSLTj())
					{
						num2 = 0;
					}
					continue;
				case 146:
					array[11] = (byte)num20;
					num2 = 51;
					continue;
				case 280:
					array[13] = (byte)num18;
					num2 = 120;
					continue;
				case 354:
					num19 = 127 - 42;
					num2 = 44;
					continue;
				case 166:
					num31 = num26 * 4;
					num2 = 286;
					if (!TiW9M7lntM9CTiSLTj())
					{
						num2 = 15;
					}
					continue;
				case 267:
					array[17] = 124;
					num2 = 205;
					continue;
				case 37:
				case 296:
					num4 = num25;
					num = 347;
					break;
				case 195:
					array[27] = (byte)num18;
					num2 = 66;
					if (TiW9M7lntM9CTiSLTj())
					{
						num2 = 266;
					}
					continue;
				case 383:
					array[0] = (byte)num18;
					num2 = 94;
					continue;
				case 334:
					array2[6] = (byte)num19;
					num2 = 179;
					if (e43uQ39Slxr6EwOuML() != null)
					{
						num2 = 96;
					}
					continue;
				case 97:
					num35 = (uint)((array7[num36 + 3] << 24) | (array7[num36 + 2] << 16) | (array7[num36 + 1] << 8) | array7[num36]);
					num2 = 264;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 70:
					array[25] = (byte)num18;
					num2 = 268;
					continue;
				case 331:
					array6[num31 + num38] = (byte)((num37 & num30) >> num41);
					num2 = 64;
					if (TiW9M7lntM9CTiSLTj())
					{
						num2 = 218;
					}
					continue;
				case 328:
					array[12] = 194;
					num2 = 360;
					continue;
				case 244:
					array2[10] = (byte)num19;
					num2 = 10;
					continue;
				case 387:
					array[20] = (byte)num20;
					num2 = 159;
					continue;
				case 338:
					array[4] = 94;
					num2 = 299;
					continue;
				case 175:
					array[25] = (byte)num18;
					num2 = 298;
					if (!TiW9M7lntM9CTiSLTj())
					{
						num2 = 65;
					}
					continue;
				case 38:
					array[29] = 141;
					num = 95;
					break;
				case 137:
					num20 = 0 + 108;
					num2 = 219;
					continue;
				case 193:
					array[4] = (byte)num20;
					num2 = 30;
					continue;
				case 221:
					array2[0] = 43;
					num2 = 333;
					continue;
				case 408:
					num18 = 182 - 60;
					num2 = 73;
					if (e43uQ39Slxr6EwOuML() != null)
					{
						num2 = 54;
					}
					continue;
				case 316:
					array[30] = (byte)num18;
					num2 = 229;
					continue;
				case 231:
					array[16] = (byte)num18;
					num2 = 115;
					continue;
				case 158:
					array2[3] = 152;
					num = 295;
					break;
				case 355:
					num20 = 113 + 54;
					num2 = 176;
					continue;
				case 294:
					array2[2] = 17;
					num2 = 158;
					continue;
				case 57:
					num19 = 5 + 65;
					num2 = 103;
					continue;
				case 109:
					array[21] = 47;
					num2 = 207;
					continue;
				case 53:
					array[9] = 42;
					num2 = 165;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 391:
					num19 = 157 - 52;
					num2 = 100;
					continue;
				case 400:
					num41 += 8;
					num2 = 331;
					continue;
				case 406:
					array2[12] = (byte)num19;
					num2 = 292;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 393:
					array6 = new byte[array5.Length];
					num = 341;
					break;
				case 357:
					array[19] = (byte)num18;
					num2 = 99;
					if (e43uQ39Slxr6EwOuML() != null)
					{
						num2 = 77;
					}
					continue;
				case 128:
					if (num26 == num27 - 1)
					{
						num2 = 226;
						if (e43uQ39Slxr6EwOuML() == null)
						{
							continue;
						}
						break;
					}
					goto case 178;
				case 49:
					num20 = 33 + 49;
					num2 = 146;
					continue;
				case 34:
					array5 = (byte[])OUahIkp0k0VpIUsiqx(tC32Ply6qZXwRIkt, (int)zLLx1tArK98FNXSLP1(fHrGsR7MrOm1Xihen4(tC32Ply6qZXwRIkt)));
					num2 = 274;
					continue;
				case 10:
					array2[10] = 149;
					num2 = 7;
					continue;
				case 46:
					array[31] = 176;
					num2 = 191;
					continue;
				case 321:
					array[20] = 48;
					num2 = 327;
					continue;
				case 403:
					array2[8] = (byte)num19;
					num2 = 323;
					continue;
				case 104:
					array2[14] = 104;
					num2 = 233;
					continue;
				case 194:
					num19 = 65 + 16;
					num2 = 366;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 76:
					num18 = 19 + 106;
					num = 330;
					break;
				case 150:
					num18 = 206 - 91;
					num2 = 351;
					continue;
				case 132:
					array2[1] = (byte)num19;
					num2 = 275;
					continue;
				case 243:
					array[8] = (byte)num18;
					num2 = 53;
					continue;
				case 322:
					array[15] = 160;
					num2 = 199;
					continue;
				case 43:
					array[26] = 142;
					num2 = 171;
					if (TiW9M7lntM9CTiSLTj())
					{
						num2 = 228;
					}
					continue;
				case 51:
					num18 = 189 - 63;
					num2 = 281;
					continue;
				case 251:
					num20 = 205 - 68;
					num2 = 163;
					if (!TiW9M7lntM9CTiSLTj())
					{
						num2 = 137;
					}
					continue;
				case 29:
					num19 = 56 + 117;
					num2 = 256;
					continue;
				case 17:
					array[27] = (byte)num18;
					num2 = 307;
					continue;
				case 235:
					num36 = (uint)num31;
					num2 = 136;
					if (!TiW9M7lntM9CTiSLTj())
					{
						num2 = 111;
					}
					continue;
				case 14:
					array[11] = 224;
					num2 = 368;
					continue;
				case 397:
					RxXLgIRuyevXlFsveC(stream);
					num = 9;
					break;
				case 22:
					array2[6] = (byte)num19;
					num2 = 395;
					continue;
				case 308:
					num19 = 102 - 11;
					num2 = 10;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						num2 = 132;
					}
					continue;
				case 143:
				case 215:
					num21 = K4xkn0TIjB7BmZ4ZAd(URWIWFRVnZ, P_0);
					num2 = 402;
					continue;
				case 133:
					num20 = 151 - 50;
					num2 = 263;
					continue;
				case 73:
					array[30] = (byte)num18;
					num2 = 270;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 363:
					array[19] = 130;
					num2 = 32;
					if (!TiW9M7lntM9CTiSLTj())
					{
						num2 = 20;
					}
					continue;
				case 86:
					array[13] = (byte)num18;
					num2 = 361;
					continue;
				case 31:
					array[11] = 146;
					num2 = 49;
					continue;
				case 110:
					array[8] = 134;
					num2 = 251;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 26:
					array[18] = 144;
					num2 = 278;
					if (e43uQ39Slxr6EwOuML() != null)
					{
						num2 = 173;
					}
					continue;
				case 106:
					array[16] = (byte)num20;
					num2 = 183;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 245:
					num20 = 121 + 22;
					num2 = 242;
					continue;
				case 223:
					URWIWFRVnZ = array6;
					num2 = 215;
					continue;
				case 18:
					array[10] = 60;
					num2 = 78;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 82:
					array7[num29] ^= array3[num29];
					num2 = 36;
					continue;
				case 258:
					num41 = 0;
					num2 = 51;
					if (TiW9M7lntM9CTiSLTj())
					{
						num2 = 128;
					}
					continue;
				case 284:
					num18 = 122 + 28;
					num2 = 190;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						num2 = 273;
					}
					continue;
				case 379:
					num34 = 0;
					num2 = 59;
					continue;
				case 131:
					num27++;
					num2 = 389;
					continue;
				case 213:
					array[2] = (byte)num20;
					num2 = 172;
					continue;
				case 39:
					num19 = 246 - 82;
					num = 112;
					break;
				case 317:
					array[25] = 91;
					num2 = 289;
					continue;
				case 85:
					array[22] = 108;
					num2 = 236;
					if (TiW9M7lntM9CTiSLTj())
					{
						num2 = 245;
					}
					continue;
				case 147:
					array[6] = 160;
					num2 = 21;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						num2 = 133;
					}
					continue;
				case 236:
					array[28] = (byte)num18;
					num2 = 196;
					continue;
				case 392:
					array[14] = (byte)num18;
					num2 = 277;
					continue;
				case 121:
					num18 = 2 + 117;
					num2 = 290;
					continue;
				case 373:
					cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					num2 = 261;
					continue;
				case 224:
					array[22] = 102;
					num2 = 200;
					continue;
				case 366:
					array2[13] = (byte)num19;
					num2 = 300;
					continue;
				case 341:
					num40 = array7.Length / 4;
					num2 = 54;
					if (e43uQ39Slxr6EwOuML() != null)
					{
						num2 = 47;
					}
					continue;
				case 376:
					num20 = 227 - 75;
					num2 = 187;
					continue;
				case 122:
					array[0] = 132;
					num2 = 376;
					continue;
				case 234:
					num20 = 150 - 58;
					num2 = 125;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 343:
					array2[15] = (byte)num19;
					num2 = 1;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 287:
					array[23] = 124;
					num2 = 283;
					continue;
				case 304:
					URWIWFRVnZ = (byte[])zQjwpxIBc7MDNUMxXy(stream);
					num2 = 397;
					continue;
				case 44:
					array2[11] = (byte)num19;
					num2 = 394;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 320:
					num26 = 0;
					num2 = 246;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 2:
					array3[5] = array4[2];
					num2 = 72;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 160:
					array3[15] = array4[7];
					num2 = 329;
					continue;
				case 170:
					num18 = 107 + 90;
					num2 = 243;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 288:
					array[17] = 86;
					num2 = 168;
					continue;
				case 96:
					if (num34 > 0)
					{
						num2 = 108;
						continue;
					}
					goto case 5;
				case 64:
					array[20] = (byte)num20;
					num2 = 336;
					continue;
				case 172:
					array[3] = 167;
					num2 = 91;
					if (e43uQ39Slxr6EwOuML() != null)
					{
						num2 = 54;
					}
					continue;
				case 272:
					array[15] = (byte)num18;
					num2 = 3;
					continue;
				case 405:
					num20 = 108 + 106;
					num2 = 365;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 162:
					array2[1] = 214;
					num2 = 293;
					continue;
				case 161:
					WvGqe4SUBv6lvqbPFY(array3);
					num2 = 164;
					continue;
				case 168:
					array[17] = 210;
					num2 = 26;
					if (e43uQ39Slxr6EwOuML() != null)
					{
						num2 = 1;
					}
					continue;
				case 218:
					num38++;
					num2 = 390;
					continue;
				case 72:
					array3[7] = array4[3];
					num2 = 141;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 142:
					array[19] = (byte)num20;
					num2 = 140;
					continue;
				default:
					array[3] = 133;
					num2 = 121;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 199:
					num18 = 169 - 56;
					num2 = 272;
					continue;
				case 264:
					num30 = 255u;
					num2 = 258;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 63:
					array2[5] = 129;
					num = 257;
					break;
				case 159:
					num20 = 214 - 71;
					num = 64;
					break;
				case 151:
					array[18] = (byte)num18;
					num2 = 243;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						num2 = 265;
					}
					continue;
				case 176:
					array[27] = (byte)num20;
					num2 = 93;
					continue;
				case 312:
					num19 = 62 + 32;
					num2 = 406;
					continue;
				case 274:
					LEtOeOCKxBBqXCAFMb(tC32Ply6qZXwRIkt);
					num2 = 55;
					continue;
				case 266:
					num18 = 61 - 41;
					num2 = 17;
					continue;
				case 114:
					num20 = 64 + 9;
					num2 = 210;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 336:
					array[20] = 95;
					num2 = 6;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 311:
					array[5] = 120;
					num2 = 306;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 255:
					array2[4] = (byte)num19;
					num2 = 180;
					continue;
				case 364:
					array2[9] = (byte)num19;
					num = 68;
					break;
				case 303:
				case 407:
					num26++;
					num2 = 319;
					continue;
				case 81:
					array[12] = (byte)num20;
					num = 249;
					break;
				case 318:
					array[26] = (byte)num18;
					num2 = 244;
					if (TiW9M7lntM9CTiSLTj())
					{
						num2 = 355;
					}
					continue;
				case 117:
					num18 = 206 - 68;
					num2 = 357;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 61:
					tC32Ply6qZXwRIkt = new TC32Ply6qZXwRIkt80((Stream)aP7gJBDKU530U2eFvs(Nd7IcY14HO, "AKLu0Zp9kjpvZajAvg.4GGEwl4aIl2tArbDIv"));
					num2 = 174;
					continue;
				case 145:
					array[29] = 117;
					num2 = 405;
					continue;
				case 278:
					num18 = 145 - 48;
					num2 = 314;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 182:
					array2[11] = 43;
					num2 = 354;
					if (!TiW9M7lntM9CTiSLTj())
					{
						num2 = 295;
					}
					continue;
				case 297:
					num39 = num26 % num40;
					num2 = 166;
					if (e43uQ39Slxr6EwOuML() != null)
					{
						num2 = 36;
					}
					continue;
				case 1:
					array3 = array2;
					num2 = 161;
					continue;
				case 208:
				case 390:
					if (num38 >= num28)
					{
						num = 407;
						break;
					}
					goto case 48;
				case 171:
					stream = (Stream)qPQ1Jk4uor8P33JT3F();
					num2 = 373;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 174:
					QO1qMo0t9piom7myZ1(fHrGsR7MrOm1Xihen4(tC32Ply6qZXwRIkt), 0L);
					num2 = 34;
					continue;
				case 205:
					array[17] = 167;
					num2 = 240;
					continue;
				case 165:
					num20 = 82 + 84;
					num2 = 192;
					if (e43uQ39Slxr6EwOuML() != null)
					{
						num2 = 95;
					}
					continue;
				case 262:
					array6[num31 + 3] = (byte)((num32 & 0xFF000000u) >> 24);
					num2 = 303;
					continue;
				case 79:
					array[7] = 239;
					num2 = 198;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 75:
					num20 = 75 + 92;
					num2 = 90;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 92:
					array7 = array;
					num2 = 13;
					continue;
				case 16:
					num32 = num25 ^ num33;
					num2 = 324;
					continue;
				case 3:
					array[15] = 144;
					num2 = 23;
					continue;
				case 226:
					if (num28 > 0)
					{
						num2 = 398;
						continue;
					}
					goto case 178;
				case 7:
					num19 = 84 - 51;
					num2 = 156;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 27:
					num19 = 218 - 72;
					num2 = 374;
					continue;
				case 115:
					num20 = 177 + 31;
					num2 = 106;
					continue;
				case 130:
					array3[1] = array4[0];
					num2 = 356;
					if (!TiW9M7lntM9CTiSLTj())
					{
						num2 = 74;
					}
					continue;
				case 279:
					array2[1] = (byte)num19;
					num = 162;
					break;
				case 179:
					array2[6] = 132;
					num2 = 45;
					continue;
				case 54:
					num25 = 0u;
					num2 = 20;
					if (TiW9M7lntM9CTiSLTj())
					{
						num2 = 80;
					}
					continue;
				case 269:
					array[19] = (byte)num18;
					num2 = 117;
					continue;
				case 388:
					num20 = 164 + 28;
					num2 = 101;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						num2 = 213;
					}
					continue;
				case 103:
					array2[14] = (byte)num19;
					num2 = 104;
					continue;
				case 40:
					array2[12] = 138;
					num2 = 118;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						num2 = 312;
					}
					continue;
				case 358:
					num18 = 118 + 64;
					num2 = 231;
					continue;
				case 371:
					num25 += num35;
					num2 = 379;
					continue;
				case 360:
					num20 = 197 - 65;
					num2 = 375;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 77:
					num38 = 0;
					num2 = 208;
					continue;
				case 185:
					array2[7] = 118;
					num2 = 384;
					if (!TiW9M7lntM9CTiSLTj())
					{
						num2 = 30;
					}
					continue;
				case 369:
					array2[3] = 119;
					num2 = 230;
					continue;
				case 212:
					num20 = 118 + 54;
					num2 = 154;
					continue;
				case 124:
					array2[3] = 60;
					num2 = 369;
					continue;
				case 352:
					num20 = 90 - 57;
					num2 = 340;
					continue;
				case 247:
					num20 = 214 - 71;
					num2 = 126;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 401:
					num34++;
					num2 = 253;
					continue;
				case 365:
					array[29] = (byte)num20;
					num2 = 38;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 333:
					num19 = 6 + 76;
					num2 = 279;
					continue;
				case 399:
					num18 = 105 - 69;
					num2 = 111;
					if (e43uQ39Slxr6EwOuML() != null)
					{
						num2 = 101;
					}
					continue;
				case 191:
					array[31] = 54;
					num2 = 301;
					continue;
				case 386:
					if (num28 > 0)
					{
						num2 = 131;
						if (!TiW9M7lntM9CTiSLTj())
						{
							num2 = 67;
						}
						continue;
					}
					goto case 389;
				case 93:
					num18 = 207 - 69;
					num = 195;
					break;
				case 301:
					array[31] = 53;
					num2 = 409;
					continue;
				case 339:
					num37 = num25 ^ num33;
					num2 = 77;
					continue;
				case 140:
					num18 = 22 + 97;
					num2 = 269;
					continue;
				case 102:
					array[2] = 102;
					num2 = 75;
					continue;
				case 55:
					array = new byte[32];
					num2 = 122;
					continue;
				case 178:
					num25 += num35;
					num2 = 235;
					continue;
				case 136:
					num33 = (uint)((array5[num36 + 3] << 24) | (array5[num36 + 2] << 16) | (array5[num36 + 1] << 8) | array5[num36]);
					num2 = 37;
					continue;
				case 337:
					array2[11] = 78;
					num2 = 182;
					continue;
				case 48:
					if (num38 > 0)
					{
						num2 = 107;
						continue;
					}
					goto case 331;
				case 45:
					num19 = 138 - 46;
					num2 = 50;
					continue;
				case 112:
					array2[9] = (byte)num19;
					num2 = 135;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 153:
					array2[11] = 75;
					num2 = 40;
					continue;
				case 24:
					array[14] = (byte)num18;
					num2 = 211;
					continue;
				case 242:
					array[22] = (byte)num20;
					num2 = 202;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						num2 = 241;
					}
					continue;
				case 164:
					array4 = (byte[])tl1CH0NpYOQVfRBusQ(lVTqcnHeSsn1xKD0TG(Nd7IcY14HO));
					num2 = 367;
					continue;
				case 332:
					array[10] = (byte)num18;
					num2 = 31;
					if (!TiW9M7lntM9CTiSLTj())
					{
						num2 = 8;
					}
					continue;
				case 138:
					num18 = 142 - 47;
					num2 = 236;
					continue;
				case 19:
					array[2] = (byte)num18;
					num2 = 284;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 135:
					num19 = 158 - 39;
					num2 = 364;
					continue;
				case 32:
					array[19] = 99;
					num2 = 88;
					continue;
				case 123:
					num19 = 51 + 15;
					num2 = 377;
					continue;
				case 370:
					array[4] = (byte)num18;
					num2 = 247;
					if (!TiW9M7lntM9CTiSLTj())
					{
						num2 = 81;
					}
					continue;
				case 80:
					num35 = 0u;
					num2 = 326;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 290:
					array[4] = (byte)num18;
					num2 = 139;
					continue;
				case 292:
					array2[12] = 246;
					num2 = 391;
					continue;
				case 228:
					num18 = 83 - 73;
					num2 = 318;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 197:
					array2[0] = 106;
					num2 = 167;
					continue;
				case 119:
					num19 = 99 + 91;
					num2 = 19;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						num2 = 116;
					}
					continue;
				case 220:
					array[24] = 156;
					num2 = 76;
					continue;
				case 404:
					num18 = 153 - 51;
					num2 = 383;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 41:
					array2[0] = (byte)num19;
					num2 = 221;
					continue;
				case 59:
				case 253:
					if (num34 >= num28)
					{
						num2 = 296;
						continue;
					}
					goto case 96;
				case 210:
					array[14] = (byte)num20;
					num2 = 382;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 192:
					array[9] = (byte)num20;
					num2 = 212;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 305:
					if (num26 == num27 - 1)
					{
						num2 = 201;
						continue;
					}
					goto case 16;
				case 241:
					array[22] = 99;
					num2 = 224;
					continue;
				case 300:
					array2[13] = 165;
					num2 = 123;
					continue;
				case 276:
					array[26] = 29;
					num2 = 8;
					continue;
				case 310:
					array2[5] = (byte)num19;
					num2 = 250;
					continue;
				case 144:
					if (URWIWFRVnZ.Length != 0)
					{
						num2 = 143;
						continue;
					}
					goto case 61;
				case 348:
					array2[7] = (byte)num19;
					num2 = 190;
					continue;
				case 163:
					array[8] = (byte)num20;
					num2 = 170;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 275:
					array2[2] = 125;
					num2 = 35;
					continue;
				case 327:
					num18 = 176 - 58;
					num2 = 65;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 139:
					num20 = 201 - 67;
					num2 = 193;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 345:
					array2[8] = 35;
					num2 = 69;
					continue;
				case 190:
					num19 = 118 + 78;
					num2 = 403;
					if (e43uQ39Slxr6EwOuML() != null)
					{
						num2 = 210;
					}
					continue;
				case 238:
					array[7] = 144;
					num2 = 67;
					continue;
				case 252:
					num18 = 206 - 68;
					num2 = 316;
					continue;
				case 315:
					array[23] = 94;
					num2 = 287;
					continue;
				case 30:
					array[4] = 71;
					num2 = 350;
					continue;
				case 248:
					array2[15] = 162;
					num2 = 155;
					continue;
				case 384:
					array2[7] = 148;
					num2 = 325;
					continue;
				case 118:
					array[6] = (byte)num18;
					num2 = 238;
					continue;
				case 367:
					if (array4 == null)
					{
						num2 = 83;
						if (TiW9M7lntM9CTiSLTj())
						{
							continue;
						}
						break;
					}
					goto case 237;
				case 361:
					num18 = 47 + 21;
					num2 = 24;
					continue;
				case 126:
					array[5] = (byte)num20;
					num2 = 311;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 385:
					psSUOFiFqrT0WR8BIi(cryptoStream);
					num2 = 304;
					if (e43uQ39Slxr6EwOuML() != null)
					{
						num2 = 51;
					}
					continue;
				case 398:
					num33 = 0u;
					num2 = 371;
					continue;
				case 225:
					num20 = 126 - 42;
					num2 = 309;
					continue;
				case 217:
					array[5] = 133;
					num2 = 181;
					continue;
				case 309:
					array[6] = (byte)num20;
					num2 = 182;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						num2 = 222;
					}
					continue;
				case 281:
					array[11] = (byte)num18;
					num2 = 206;
					if (e43uQ39Slxr6EwOuML() != null)
					{
						num2 = 146;
					}
					continue;
				case 180:
					array2[4] = 73;
					num2 = 119;
					continue;
				case 13:
					array2 = new byte[16];
					num2 = 197;
					if (e43uQ39Slxr6EwOuML() != null)
					{
						num2 = 24;
					}
					continue;
				case 326:
					num33 = 0u;
					num2 = 386;
					continue;
				case 113:
					array[12] = (byte)num18;
					num2 = 328;
					continue;
				case 207:
					array[21] = 108;
					num2 = 85;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 101:
					num25 = num4;
					num2 = 305;
					continue;
				case 177:
					array6[num31 + 1] = (byte)((num32 & 0xFF00) >> 8);
					num2 = 204;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 340:
					array[9] = (byte)num20;
					num2 = 18;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 157:
					array[7] = 142;
					num = 79;
					break;
				case 240:
					array[17] = 71;
					num2 = 288;
					continue;
				case 323:
					array2[8] = 129;
					num2 = 20;
					continue;
				case 204:
					array6[num31 + 2] = (byte)((num32 & 0xFF0000) >> 16);
					num2 = 262;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 202:
					num19 = 62 + 83;
					num2 = 244;
					continue;
				case 60:
					array[16] = (byte)num18;
					num = 358;
					break;
				case 89:
					array3[13] = array4[6];
					num2 = 160;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 134:
					array[10] = 92;
					num2 = 342;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 313:
					array2[11] = (byte)num19;
					num2 = 153;
					continue;
				case 141:
					array3[9] = array4[4];
					num2 = 260;
					continue;
				case 56:
					array[1] = (byte)num18;
					num2 = 87;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 155:
					array2[15] = 172;
					num2 = 108;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						num2 = 148;
					}
					continue;
				case 68:
					num19 = 5 + 49;
					num2 = 84;
					continue;
				case 378:
					array[24] = 158;
					num = 353;
					break;
				case 395:
					array2[6] = 233;
					num = 185;
					break;
				case 257:
					num19 = 170 + 48;
					num = 310;
					break;
				case 325:
					num19 = 57 + 105;
					num2 = 49;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						num2 = 348;
					}
					continue;
				case 186:
					array[0] = (byte)num20;
					num2 = 404;
					if (!TiW9M7lntM9CTiSLTj())
					{
						num2 = 327;
					}
					continue;
				case 62:
					array[30] = 168;
					num2 = 252;
					continue;
				case 359:
					array[1] = 115;
					num = 399;
					break;
				case 58:
					array2[14] = (byte)num19;
					num2 = 111;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						num2 = 248;
					}
					continue;
				case 149:
					num18 = 151 - 50;
					num2 = 45;
					if (TiW9M7lntM9CTiSLTj())
					{
						num2 = 56;
					}
					continue;
				case 188:
					num20 = 172 - 57;
					num2 = 142;
					continue;
				case 116:
					array2[4] = (byte)num19;
					num2 = 52;
					if (!TiW9M7lntM9CTiSLTj())
					{
						num2 = 22;
					}
					continue;
				case 268:
					array[25] = 98;
					num2 = 276;
					if (!TiW9M7lntM9CTiSLTj())
					{
						num2 = 22;
					}
					continue;
				case 167:
					num19 = 173 - 57;
					num2 = 41;
					continue;
				case 260:
					array3[11] = array4[5];
					num2 = 89;
					continue;
				case 107:
					num30 <<= 8;
					num2 = 400;
					continue;
				case 169:
					array[6] = 174;
					num2 = 225;
					continue;
				case 20:
					array2[8] = 142;
					num2 = 345;
					continue;
				case 67:
					array[7] = 122;
					num2 = 157;
					continue;
				case 84:
					array2[10] = (byte)num19;
					num = 29;
					break;
				case 351:
					array[23] = (byte)num18;
					num2 = 378;
					continue;
				case 9:
					RxXLgIRuyevXlFsveC(cryptoStream);
					num2 = 362;
					continue;
				case 71:
					array[9] = 105;
					num2 = 47;
					continue;
				case 28:
					array[31] = (byte)num20;
					num2 = 92;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 349:
					JLkLbWhaqQytcai1mm(symmetricAlgorithm, CipherMode.CBC);
					num = 335;
					break;
				case 83:
				case 329:
					num29 = 0;
					num2 = 239;
					continue;
				case 265:
					array[18] = 82;
					num2 = 188;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 396:
					array2[11] = 99;
					num2 = 337;
					continue;
				case 36:
					num29++;
					num2 = 344;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 95:
					num18 = 9 + 32;
					num2 = 227;
					continue;
				case 346:
					num18 = 117 + 111;
					num2 = 332;
					continue;
				case 227:
					array[29] = (byte)num18;
					num2 = 209;
					continue;
				case 233:
					array2[14] = 120;
					num2 = 203;
					continue;
				case 6:
					array[20] = 120;
					num2 = 321;
					continue;
				case 35:
					array2[2] = 201;
					num2 = 294;
					continue;
				case 74:
					array[11] = (byte)num18;
					num2 = 14;
					continue;
				case 330:
					array[24] = (byte)num18;
					num2 = 317;
					continue;
				case 372:
					array[12] = (byte)num18;
					num2 = 254;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 201:
					if (num28 > 0)
					{
						num2 = 339;
						continue;
					}
					goto case 16;
				case 148:
					num19 = 13 + 121;
					num = 343;
					break;
				case 410:
					return "";
				case 47:
					array[9] = 107;
					num2 = 352;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 152:
					num20 = 235 - 78;
					num2 = 387;
					continue;
				case 380:
					num20 = 10 + 84;
					num2 = 129;
					continue;
				case 156:
					array2[10] = (byte)num19;
					num2 = 396;
					continue;
				case 78:
					array[10] = 57;
					num2 = 259;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 291:
					num18 = 193 - 64;
					num2 = 74;
					continue;
				case 214:
					array[8] = (byte)num18;
					num2 = 232;
					if (!TiW9M7lntM9CTiSLTj())
					{
						num2 = 193;
					}
					continue;
				case 33:
					num27 = array5.Length / 4;
					num2 = 393;
					continue;
				case 356:
					array3[3] = array4[1];
					num = 2;
					break;
				case 246:
				case 319:
					if (num26 >= num27)
					{
						num = 223;
						break;
					}
					goto case 297;
				case 209:
					array[29] = 64;
					num2 = 408;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 5:
					num33 |= array5[array5.Length - (1 + num34)];
					num2 = 401;
					if (TiW9M7lntM9CTiSLTj())
					{
						continue;
					}
					break;
				case 100:
					array2[13] = (byte)num19;
					num2 = 194;
					continue;
				case 368:
					num20 = 17 + 51;
					num2 = 81;
					continue;
				case 198:
					num18 = 203 - 67;
					num2 = 214;
					continue;
				case 187:
					array[0] = (byte)num20;
					num2 = 271;
					continue;
				case 342:
					array[10] = 126;
					num2 = 261;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						num2 = 346;
					}
					continue;
				case 129:
					array[1] = (byte)num20;
					num2 = 137;
					if (e43uQ39Slxr6EwOuML() != null)
					{
						num2 = 68;
					}
					continue;
				case 249:
					num18 = 166 - 55;
					num2 = 372;
					continue;
				case 402:
				{
					string result;
					try
					{
						result = (string)KBDY7of1n28QFhO2w7(LOOETIFtidjaIaHtPf(), URWIWFRVnZ, P_0 + 4, num21);
						int num22 = 0;
						if (e43uQ39Slxr6EwOuML() != null)
						{
							num22 = num23;
						}
						switch (num22)
						{
						case 0:
							break;
						}
					}
					catch
					{
						int num24 = 0;
						if (!TiW9M7lntM9CTiSLTj())
						{
							num24 = 0;
						}
						switch (num24)
						{
						}
						goto case 410;
					}
					return result;
				}
				case 105:
					num28 = array5.Length % 4;
					num2 = 33;
					continue;
				case 350:
					array[4] = 22;
					num2 = 338;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 12:
					array[25] = (byte)num20;
					num2 = 21;
					continue;
				case 289:
					num18 = 221 - 73;
					num2 = 175;
					continue;
				case 298:
					num20 = 110 + 86;
					num2 = 12;
					continue;
				case 377:
					array2[13] = (byte)num19;
					num2 = 4;
					if (e43uQ39Slxr6EwOuML() == null)
					{
						continue;
					}
					break;
				case 66:
				{
					uint num3 = num4;
					uint num5 = num4;
					uint num6 = 1509987688u;
					uint num7 = num5;
					uint num8 = 561705547u;
					uint num9 = 1322156403u;
					uint num10 = 801110183u;
					uint num11 = 886483354u;
					ulong num12 = 381392362 * num8;
					num12 |= 1;
					num9 = (uint)(num9 * num9 % num12);
					uint num13 = ((num10 >> 12) | (num10 << 20)) ^ num6;
					uint num14 = num13 & 0x55555555;
					num13 &= 0xAAAAAAAAu;
					num10 = (num13 >> 1) | (num14 << 1);
					num6 += num9;
					uint num15 = num8 & 0xF0F0F0F;
					uint num16 = num8 & 0xF0F0F0F0u;
					num15 = ((num15 >> 4) | (num16 << 4)) ^ num9;
					num8 = (num8 >> 15) | (num8 << 17);
					if ((double)num11 == 0.0)
					{
						num11--;
					}
					uint num17 = (uint)(50504.0 / (double)num11 + (double)num11);
					if (num17 == 0)
					{
						num17--;
					}
					num11 = (uint)((uint)((double)(short)num9 - 1184457556.0) / num17 + (short)num9);
					num7 ^= num7 << 3;
					num7 += num6;
					num7 ^= num7 >> 5;
					num7 += num8;
					num7 ^= num7 << 25;
					num7 += num11;
					num7 = (((num10 << 3) - num6) ^ num8) + num7;
					num4 = num3 + (uint)(double)num7;
					num2 = 101;
					continue;
				}
				}
				break;
			}
		}
	}

	[i2n8gg7g19hnqW3PeZ(typeof(i2n8gg7g19hnqW3PeZ.kI4QkNbRW8fxM2yPhp<object>[]))]
	internal static string zUyILxb1G2(string P_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int yuTI7MO3vA()
	{
		return 5;
	}

	private static void GrIIbylCqS()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate ShYIxKkLqs(IntPtr P_0, Type P_1)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[2] { P_0, P_1 });
	}

	internal static object xdWIhbCumF(object P_0)
	{
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

	[DllImport("kernel32", EntryPoint = "LoadLibrary")]
	public static extern IntPtr pJ4IFkWDWf(string P_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr XS9IfMoJja(IntPtr P_0, string P_1);

	private static IntPtr wf4IqhJ2Vu(IntPtr P_0, string P_1, uint P_2)
	{
		if (RTNTmRnPDn == null)
		{
			IntPtr ptr = XS9IfMoJja(so8WHSBJcy(), "Find ".Trim() + "ResourceA");
			RTNTmRnPDn = (qTIjDuUEM5d5bDYJV6)Marshal.GetDelegateForFunctionPointer(ptr, typeof(qTIjDuUEM5d5bDYJV6));
		}
		return RTNTmRnPDn(P_0, P_1, P_2);
	}

	private static IntPtr CIKIycc0Gl(IntPtr P_0, uint P_1, uint P_2, uint P_3)
	{
		if (Jt1TEdiDBs == null)
		{
			IntPtr ptr = XS9IfMoJja(so8WHSBJcy(), "Virtual ".Trim() + "Alloc");
			Jt1TEdiDBs = (efwUVPtuhDcmfeWUjl)Marshal.GetDelegateForFunctionPointer(ptr, typeof(efwUVPtuhDcmfeWUjl));
		}
		return Jt1TEdiDBs(P_0, P_1, P_2, P_3);
	}

	private static int kTbIU7DleK(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
	{
		if (xRATd2Qa1D == null)
		{
			IntPtr ptr = XS9IfMoJja(so8WHSBJcy(), "Write ".Trim() + "Process ".Trim() + "Memory");
			xRATd2Qa1D = (eUFFmUXQ2psPxb79Eu)Marshal.GetDelegateForFunctionPointer(ptr, typeof(eUFFmUXQ2psPxb79Eu));
		}
		return xRATd2Qa1D(P_0, P_1, P_2, P_3, out P_4);
	}

	private static int g8vIt9ZCLq(IntPtr P_0, int P_1, int P_2, ref int P_3)
	{
		if (fe3T5xyeU1 == null)
		{
			IntPtr ptr = XS9IfMoJja(so8WHSBJcy(), "Virtual ".Trim() + "Protect");
			fe3T5xyeU1 = (jYOyygroVfb7cW3w3e)Marshal.GetDelegateForFunctionPointer(ptr, typeof(jYOyygroVfb7cW3w3e));
		}
		return fe3T5xyeU1(P_0, P_1, P_2, ref P_3);
	}

	private static IntPtr v3WIXaF0j1(uint P_0, int P_1, uint P_2)
	{
		if (bZDTCYTcoW == null)
		{
			IntPtr ptr = XS9IfMoJja(so8WHSBJcy(), "Open ".Trim() + "Process");
			bZDTCYTcoW = (BtZacZwNweSkfrxuQF)Marshal.GetDelegateForFunctionPointer(ptr, typeof(BtZacZwNweSkfrxuQF));
		}
		return bZDTCYTcoW(P_0, P_1, P_2);
	}

	private static int OrRIrmQ2Rr(IntPtr P_0)
	{
		if (mjTTLae5BA == null)
		{
			IntPtr ptr = XS9IfMoJja(so8WHSBJcy(), "Close ".Trim() + "Handle");
			mjTTLae5BA = (G0Yqhk8yOcce6r7vHY)Marshal.GetDelegateForFunctionPointer(ptr, typeof(G0Yqhk8yOcce6r7vHY));
		}
		return mjTTLae5BA(P_0);
	}

	[SpecialName]
	private static IntPtr so8WHSBJcy()
	{
		if (YKbT7BoYjU == IntPtr.Zero)
		{
			YKbT7BoYjU = pJ4IFkWDWf("kernel ".Trim() + "32.dll");
		}
		return YKbT7BoYjU;
	}

	[i2n8gg7g19hnqW3PeZ(typeof(i2n8gg7g19hnqW3PeZ.kI4QkNbRW8fxM2yPhp<object>[]))]
	private static byte[] ae3IwxYWlc(string P_0)
	{
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

	private static Stream Df3I8JTsah()
	{
		return new MemoryStream();
	}

	private static byte[] lA5Ig1OCs5(Stream P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	[i2n8gg7g19hnqW3PeZ(typeof(i2n8gg7g19hnqW3PeZ.kI4QkNbRW8fxM2yPhp<object>[]))]
	private static byte[] eR6I6mjYJW(byte[] P_0)
	{
		Stream stream = Df3I8JTsah();
		SymmetricAlgorithm symmetricAlgorithm = YvKznWcCX();
		symmetricAlgorithm.Key = new byte[32]
		{
			195, 116, 21, 164, 50, 217, 80, 34, 86, 240,
			235, 150, 18, 206, 74, 61, 116, 47, 193, 135,
			57, 147, 169, 143, 201, 50, 61, 108, 228, 207,
			9, 241
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			230, 250, 167, 34, 96, 64, 238, 225, 156, 147,
			249, 29, 10, 16, 200, 62
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		return lA5Ig1OCs5(stream);
	}

	private byte[] gtRI9VUQ0a()
	{
		return null;
	}

	private byte[] hULIsTLPSO()
	{
		return null;
	}

	private byte[] bW9I0LZBdA()
	{
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] AeHINVHOjY()
	{
		string text = "{11111-22222-20001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] y8rIoRDLaD()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] vPvIpLRCuf()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] cI7Ikpv8Ba()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] VtZI1ayrZ2()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] rUfIiJcy72()
	{
		string text = "{11111-22222-50001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] rSOIv2bwrr()
	{
		string text = "{11111-22222-50001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal static object aP7gJBDKU530U2eFvs(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object fHrGsR7MrOm1Xihen4(object P_0)
	{
		return ((TC32Ply6qZXwRIkt80)P_0).fHSkdAnkJf();
	}

	internal static void QO1qMo0t9piom7myZ1(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long zLLx1tArK98FNXSLP1(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object OUahIkp0k0VpIUsiqx(object P_0, int P_1)
	{
		return ((TC32Ply6qZXwRIkt80)P_0).OiXTFQbycs(P_1);
	}

	internal static void LEtOeOCKxBBqXCAFMb(object P_0)
	{
		((TC32Ply6qZXwRIkt80)P_0).AW8Ty8H8Aw();
	}

	internal static void WvGqe4SUBv6lvqbPFY(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object lVTqcnHeSsn1xKD0TG(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object tl1CH0NpYOQVfRBusQ(object P_0)
	{
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}

	internal static object qoB3ZD32PthkeqRpBh()
	{
		return YvKznWcCX();
	}

	internal static void JLkLbWhaqQytcai1mm(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object tXyXUtXJYldyxR5pMY(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object qPQ1Jk4uor8P33JT3F()
	{
		return Df3I8JTsah();
	}

	internal static void fsDkYSw0e5yRohZA9F(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void psSUOFiFqrT0WR8BIi(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object zQjwpxIBc7MDNUMxXy(object P_0)
	{
		return lA5Ig1OCs5((Stream)P_0);
	}

	internal static void RxXLgIRuyevXlFsveC(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static int K4xkn0TIjB7BmZ4ZAd(object P_0, int P_1)
	{
		return BitConverter.ToInt32((byte[])P_0, P_1);
	}

	internal static object LOOETIFtidjaIaHtPf()
	{
		return Encoding.Unicode;
	}

	internal static object KBDY7of1n28QFhO2w7(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Encoding)P_0).GetString((byte[])P_1, P_2, P_3);
	}

	internal static bool TiW9M7lntM9CTiSLTj()
	{
		return null == null;
	}

	internal static object e43uQ39Slxr6EwOuML()
	{
		return null;
	}
}
