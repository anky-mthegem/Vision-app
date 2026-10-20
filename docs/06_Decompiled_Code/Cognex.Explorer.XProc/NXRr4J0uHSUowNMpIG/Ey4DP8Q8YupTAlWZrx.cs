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
using JK709E3DnFfvLewQUh;

namespace NXRr4J0uHSUowNMpIG;

internal class Ey4DP8Q8YupTAlWZrx
{
	private delegate void vT7oNPqFsmL0uFib1l(object o);

	internal class oamTPajlRfuYnXdshk : Attribute
	{
		internal class VAe7DaY6ttTvcEhkli<VHY0TwWLECa5iUvTgr>
		{
			internal static object I1oq9oDyvcihQa1p9E;

			public VAe7DaY6ttTvcEhkli()
			{
				P72r2cmcNm3BJYykhQ.cXSFj2LzQpSyU();
				base._002Ector();
				int num = 0;
				if (false)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static bool kmcyowqCstZlimBoDW()
			{
				return I1oq9oDyvcihQa1p9E == null;
			}

			internal static object H4fLtONp2Y5y3yLDu6()
			{
				return I1oq9oDyvcihQa1p9E;
			}
		}

		[oamTPajlRfuYnXdshk(typeof(VAe7DaY6ttTvcEhkli<object>[]))]
		public oamTPajlRfuYnXdshk(object P_0)
		{
		}
	}

	internal class jnr2yXEyl8O7Qr9fee
	{
		[oamTPajlRfuYnXdshk(typeof(oamTPajlRfuYnXdshk.VAe7DaY6ttTvcEhkli<object>[]))]
		internal static string VFjyLV1osb(string P_0, string P_1)
		{
			byte[] bytes = ((Encoding)tuvsUnzyivMc6AD553()).GetBytes(P_0);
			byte[] array = bytes;
			byte[] array2 = new byte[32];
			b6rRfFb6tT2Vtsc12Qf(array2, __ldtoken(_003CPrivateImplementationDetails_003E_007B68C290F9_002DC874_002D45D6_002DB3A5_002D2609A59BBDAE_007D._0024_0024method0x600034f_002D1));
			byte[] key = array2;
			byte[] iV = EpHbY0TwL((byte[])bayFsXbbGqhhs1YCPf6(Encoding.Unicode, P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = VAeH7Da6t();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return (string)BNCpijbPD4l35cYG0Np(ssqGTgbmNxv476wEdgb(memoryStream));
		}

		internal static object tuvsUnzyivMc6AD553()
		{
			return Encoding.Unicode;
		}

		internal static void b6rRfFb6tT2Vtsc12Qf(object P_0, RuntimeFieldHandle P_1)
		{
			RuntimeHelpers.InitializeArray((Array)P_0, P_1);
		}

		internal static object bayFsXbbGqhhs1YCPf6(object P_0, object P_1)
		{
			return ((Encoding)P_0).GetBytes((string)P_1);
		}

		internal static object ssqGTgbmNxv476wEdgb(object P_0)
		{
			return ((MemoryStream)P_0).ToArray();
		}

		internal static object BNCpijbPD4l35cYG0Np(object P_0)
		{
			return Convert.ToBase64String((byte[])P_0);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint MxQgD2KHLg1iidba7a(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr e663DgUCAELfOnNm7D();

	internal struct PYpVLpvMY75I2kGIB2
	{
		internal bool lg6yf2uI9c;

		internal byte[] yUfyokUQpc;
	}

	internal class yesCHY8pgW8aPptmNL
	{
		private BinaryReader ob0yiTcqvi;

		public yesCHY8pgW8aPptmNL(Stream P_0)
		{
			ob0yiTcqvi = new BinaryReader(P_0);
		}

		[SpecialName]
		internal Stream fHSkdAnkJf()
		{
			return (Stream)fpgVLabtpJNeySVrLd2(ob0yiTcqvi);
		}

		internal byte[] jJ9yOjRNcH(int P_0)
		{
			return (byte[])jTCuYRb3GipEMTIUoZZ(ob0yiTcqvi, P_0);
		}

		internal int YOyyB7n7jh(byte[] P_0, int P_1, int P_2)
		{
			return CYxtpKbo5ms3K3j0X1W(ob0yiTcqvi, P_0, P_1, P_2);
		}

		internal int fv8yea6sCG()
		{
			return BAU4pVbROyyAkXEMKIQ(ob0yiTcqvi);
		}

		internal void seyyRXd5TR()
		{
			ob0yiTcqvi.Close();
		}

		internal static object fpgVLabtpJNeySVrLd2(object P_0)
		{
			return ((BinaryReader)P_0).BaseStream;
		}

		internal static object jTCuYRb3GipEMTIUoZZ(object P_0, int P_1)
		{
			return ((BinaryReader)P_0).ReadBytes(P_1);
		}

		internal static int CYxtpKbo5ms3K3j0X1W(object P_0, object P_1, int P_2, int P_3)
		{
			return ((BinaryReader)P_0).Read((byte[])P_1, P_2, P_3);
		}

		internal static int BAU4pVbROyyAkXEMKIQ(object P_0)
		{
			return ((BinaryReader)P_0).ReadInt32();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr BcFY7r6R1YUQ39n0G5(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr jOsy4ylMaC5GalZ4l0(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int fSLDGhHDCw4F475myS(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int zQLmGxaDM52C9GMl0o(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr VPe9rQbVIYsgWXo6k8(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int wPhOndTHxOgb27oZtd(IntPtr ptr);

	[Flags]
	private enum R2UnqLNrjfc8Yif2hH
	{

	}

	private static bool xlB9aNLeN;

	private static object wVeys4Gpfp;

	private static byte[] e06yyu3q9X;

	private static IntPtr kbfyIcisZ2;

	private static IntPtr PtAyx0HoU0;

	private static bool w6nyjtXalM;

	private static SortedList MIlyYPxINi;

	private static int TqLyWWcV4J;

	private static bool o4vylYw9cT;

	private static int cgPyHEV1yC;

	private static BcFY7r6R1YUQ39n0G5 E7ZyN5JEu0;

	private static zQLmGxaDM52C9GMl0o Jlyy23w0lf;

	private static IntPtr XDVy55vtqC;

	private static fSLDGhHDCw4F475myS QMqy3u1SeC;

	private static byte[] RfYydvANkb;

	private static wPhOndTHxOgb27oZtd diZyCkH83p;

	private static IntPtr C72yarltBt;

	private static object nPYyQB9r3b;

	private static bool FJYy6dn1uu;

	private static VPe9rQbVIYsgWXo6k8 QQtyGJHISL;

	private static uint[] n6gwIPhju;

	private static Dictionary<int, int> Dq2zka65D;

	internal static MxQgD2KHLg1iidba7a tGxyUuxCn9;

	[oamTPajlRfuYnXdshk(typeof(oamTPajlRfuYnXdshk.VAe7DaY6ttTvcEhkli<object>[]))]
	private static bool HWLybgL871;

	private static byte[] WWp4LKwwo;

	private static byte[] jhyPSQ2Al;

	private static long sT0yEcmRmH;

	internal static Hashtable RhnyTgqu12;

	internal static MxQgD2KHLg1iidba7a yM9yKnCtIE;

	private static long DZjyvW31Dk;

	private static jOsy4ylMaC5GalZ4l0 fIZym0Hv2M;

	private static bool cpgpBIX0P;

	private static bool m9rASAgyH;

	private static int Bmty8XIjmZ;

	private static int[] o0ry06P8LH;

	private static Assembly mQSJHjPE8;

	private static int HQLyqyQytQ;

	static Ey4DP8Q8YupTAlWZrx()
	{
		xlB9aNLeN = false;
		mQSJHjPE8 = typeof(Ey4DP8Q8YupTAlWZrx).Assembly;
		n6gwIPhju = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		cpgpBIX0P = false;
		m9rASAgyH = false;
		WWp4LKwwo = new byte[0];
		jhyPSQ2Al = new byte[0];
		Dq2zka65D = null;
		wVeys4Gpfp = new object();
		e06yyu3q9X = new byte[0];
		RfYydvANkb = new byte[0];
		kbfyIcisZ2 = IntPtr.Zero;
		PtAyx0HoU0 = IntPtr.Zero;
		nPYyQB9r3b = new string[0];
		o0ry06P8LH = new int[0];
		HQLyqyQytQ = 1;
		w6nyjtXalM = false;
		MIlyYPxINi = new SortedList();
		TqLyWWcV4J = 0;
		sT0yEcmRmH = 0L;
		yM9yKnCtIE = null;
		tGxyUuxCn9 = null;
		DZjyvW31Dk = 0L;
		Bmty8XIjmZ = 0;
		FJYy6dn1uu = false;
		o4vylYw9cT = false;
		cgPyHEV1yC = 0;
		C72yarltBt = IntPtr.Zero;
		HWLybgL871 = false;
		RhnyTgqu12 = new Hashtable();
		E7ZyN5JEu0 = null;
		fIZym0Hv2M = null;
		QMqy3u1SeC = null;
		Jlyy23w0lf = null;
		QQtyGJHISL = null;
		diZyCkH83p = null;
		XDVy55vtqC = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void ERkFj2LWlsm7S()
	{
	}

	internal static byte[] oWZErxSXR(byte[] P_0)
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
			Q4JKuHSUo(ref num7, num8, num9, num10, 0u, 7, 1u, array);
			Q4JKuHSUo(ref num10, num7, num8, num9, 1u, 12, 2u, array);
			Q4JKuHSUo(ref num9, num10, num7, num8, 2u, 17, 3u, array);
			Q4JKuHSUo(ref num8, num9, num10, num7, 3u, 22, 4u, array);
			Q4JKuHSUo(ref num7, num8, num9, num10, 4u, 7, 5u, array);
			Q4JKuHSUo(ref num10, num7, num8, num9, 5u, 12, 6u, array);
			Q4JKuHSUo(ref num9, num10, num7, num8, 6u, 17, 7u, array);
			Q4JKuHSUo(ref num8, num9, num10, num7, 7u, 22, 8u, array);
			Q4JKuHSUo(ref num7, num8, num9, num10, 8u, 7, 9u, array);
			Q4JKuHSUo(ref num10, num7, num8, num9, 9u, 12, 10u, array);
			Q4JKuHSUo(ref num9, num10, num7, num8, 10u, 17, 11u, array);
			Q4JKuHSUo(ref num8, num9, num10, num7, 11u, 22, 12u, array);
			Q4JKuHSUo(ref num7, num8, num9, num10, 12u, 7, 13u, array);
			Q4JKuHSUo(ref num10, num7, num8, num9, 13u, 12, 14u, array);
			Q4JKuHSUo(ref num9, num10, num7, num8, 14u, 17, 15u, array);
			Q4JKuHSUo(ref num8, num9, num10, num7, 15u, 22, 16u, array);
			VNMUpIG2T(ref num7, num8, num9, num10, 1u, 5, 17u, array);
			VNMUpIG2T(ref num10, num7, num8, num9, 6u, 9, 18u, array);
			VNMUpIG2T(ref num9, num10, num7, num8, 11u, 14, 19u, array);
			VNMUpIG2T(ref num8, num9, num10, num7, 0u, 20, 20u, array);
			VNMUpIG2T(ref num7, num8, num9, num10, 5u, 5, 21u, array);
			VNMUpIG2T(ref num10, num7, num8, num9, 10u, 9, 22u, array);
			VNMUpIG2T(ref num9, num10, num7, num8, 15u, 14, 23u, array);
			VNMUpIG2T(ref num8, num9, num10, num7, 4u, 20, 24u, array);
			VNMUpIG2T(ref num7, num8, num9, num10, 9u, 5, 25u, array);
			VNMUpIG2T(ref num10, num7, num8, num9, 14u, 9, 26u, array);
			VNMUpIG2T(ref num9, num10, num7, num8, 3u, 14, 27u, array);
			VNMUpIG2T(ref num8, num9, num10, num7, 8u, 20, 28u, array);
			VNMUpIG2T(ref num7, num8, num9, num10, 13u, 5, 29u, array);
			VNMUpIG2T(ref num10, num7, num8, num9, 2u, 9, 30u, array);
			VNMUpIG2T(ref num9, num10, num7, num8, 7u, 14, 31u, array);
			VNMUpIG2T(ref num8, num9, num10, num7, 12u, 20, 32u, array);
			JoNvPFsmL(ref num7, num8, num9, num10, 5u, 4, 33u, array);
			JoNvPFsmL(ref num10, num7, num8, num9, 8u, 11, 34u, array);
			JoNvPFsmL(ref num9, num10, num7, num8, 11u, 16, 35u, array);
			JoNvPFsmL(ref num8, num9, num10, num7, 14u, 23, 36u, array);
			JoNvPFsmL(ref num7, num8, num9, num10, 1u, 4, 37u, array);
			JoNvPFsmL(ref num10, num7, num8, num9, 4u, 11, 38u, array);
			JoNvPFsmL(ref num9, num10, num7, num8, 7u, 16, 39u, array);
			JoNvPFsmL(ref num8, num9, num10, num7, 10u, 23, 40u, array);
			JoNvPFsmL(ref num7, num8, num9, num10, 13u, 4, 41u, array);
			JoNvPFsmL(ref num10, num7, num8, num9, 0u, 11, 42u, array);
			JoNvPFsmL(ref num9, num10, num7, num8, 3u, 16, 43u, array);
			JoNvPFsmL(ref num8, num9, num10, num7, 6u, 23, 44u, array);
			JoNvPFsmL(ref num7, num8, num9, num10, 9u, 4, 45u, array);
			JoNvPFsmL(ref num10, num7, num8, num9, 12u, 11, 46u, array);
			JoNvPFsmL(ref num9, num10, num7, num8, 15u, 16, 47u, array);
			JoNvPFsmL(ref num8, num9, num10, num7, 2u, 23, 48u, array);
			fuF8ib1ll(ref num7, num8, num9, num10, 0u, 6, 49u, array);
			fuF8ib1ll(ref num10, num7, num8, num9, 7u, 10, 50u, array);
			fuF8ib1ll(ref num9, num10, num7, num8, 14u, 15, 51u, array);
			fuF8ib1ll(ref num8, num9, num10, num7, 5u, 21, 52u, array);
			fuF8ib1ll(ref num7, num8, num9, num10, 12u, 6, 53u, array);
			fuF8ib1ll(ref num10, num7, num8, num9, 3u, 10, 54u, array);
			fuF8ib1ll(ref num9, num10, num7, num8, 10u, 15, 55u, array);
			fuF8ib1ll(ref num8, num9, num10, num7, 1u, 21, 56u, array);
			fuF8ib1ll(ref num7, num8, num9, num10, 8u, 6, 57u, array);
			fuF8ib1ll(ref num10, num7, num8, num9, 15u, 10, 58u, array);
			fuF8ib1ll(ref num9, num10, num7, num8, 6u, 15, 59u, array);
			fuF8ib1ll(ref num8, num9, num10, num7, 13u, 21, 60u, array);
			fuF8ib1ll(ref num7, num8, num9, num10, 4u, 6, 61u, array);
			fuF8ib1ll(ref num10, num7, num8, num9, 11u, 10, 62u, array);
			fuF8ib1ll(ref num9, num10, num7, num8, 2u, 15, 63u, array);
			fuF8ib1ll(ref num8, num9, num10, num7, 9u, 21, 64u, array);
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

	private static void Q4JKuHSUo(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + pmT6PalRf(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + n6gwIPhju[P_6 - 1], P_5);
	}

	private static void VNMUpIG2T(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + pmT6PalRf(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + n6gwIPhju[P_6 - 1], P_5);
	}

	private static void JoNvPFsmL(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + pmT6PalRf(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + n6gwIPhju[P_6 - 1], P_5);
	}

	private static void fuF8ib1ll(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + pmT6PalRf(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + n6gwIPhju[P_6 - 1], P_5);
	}

	private static uint pmT6PalRf(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	internal static bool SYnlXdshk()
	{
		if (!cpgpBIX0P)
		{
			HTvacEhkl();
			cpgpBIX0P = true;
		}
		return m9rASAgyH;
	}

	internal static SymmetricAlgorithm VAeH7Da6t()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (SYnlXdshk())
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

	internal static void HTvacEhkl()
	{
		try
		{
			m9rASAgyH = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] EpHbY0TwL(byte[] P_0)
	{
		if (!SYnlXdshk())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return oWZErxSXR(P_0);
	}

	public static void jCaT5iUvT(RuntimeTypeHandle P_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(P_0);
			if (Dq2zka65D == null)
			{
				lock (wVeys4Gpfp)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(Ey4DP8Q8YupTAlWZrx).Assembly.GetManifestResourceStream("0QmPOeOGr6bHd2iIce.JQdOvAVBhZAQRNFGsT"));
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
							num3 += zee3FxQgD(num3);
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
						yesCHY8pgW8aPptmNL yesCHY8pgW8aPptmNL2 = new yesCHY8pgW8aPptmNL(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = yesCHY8pgW8aPptmNL2.fv8yea6sCG();
							int value = yesCHY8pgW8aPptmNL2.fv8yea6sCG();
							dictionary.Add(key, value);
						}
						yesCHY8pgW8aPptmNL2.seyyRXd5TR();
					}
					Dq2zka65D = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = Dq2zka65D[metadataToken];
				bool flag = (num12 & 0x40000000) > 0;
				num12 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)typeof(Ey4DP8Q8YupTAlWZrx).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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

	private static uint bl8mO7Qr9(uint P_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint zee3FxQgD(uint P_0)
	{
		return 0u;
	}

	internal static void vHL2g1iid()
	{
	}

	[oamTPajlRfuYnXdshk(typeof(oamTPajlRfuYnXdshk.VAe7DaY6ttTvcEhkli<object>[]))]
	internal static string ra7GaQ663(int P_0)
	{
		int num = 331;
		byte[] array2 = default;
		int num20 = default;
		byte[] array = default;
		int num19 = default;
		int num33 = default;
		uint num38 = default;
		uint num4 = default;
		int num24 = default;
		int num18 = default;
		int num21 = default;
		int num22 = default;
		yesCHY8pgW8aPptmNL yesCHY8pgW8aPptmNL2 = default;
		int num32 = default;
		CryptoStream cryptoStream = default;
		int num37 = default;
		byte[] array3 = default;
		int num23 = default;
		byte[] array4 = default;
		uint num34 = default;
		uint num39 = default;
		byte[] array7 = default;
		ICryptoTransform transform = default;
		SymmetricAlgorithm symmetricAlgorithm = default;
		Stream stream = default;
		uint num43 = default;
		byte[] array6 = default;
		int num30 = default;
		uint num42 = default;
		int num36 = default;
		byte[] array5 = default;
		uint num35 = default;
		uint num31 = default;
		int num41 = default;
		int num40 = default;
		int num25 = default;
		int num27 = default;
		int num29 = default;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 186:
					array2[3] = (byte)num20;
					num2 = 24;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 206:
					num20 = 241 - 80;
					num2 = 3;
					if (n9AjaF5boMRG46ICJT() != null)
					{
						num2 = 3;
					}
					continue;
				case 364:
					array[26] = (byte)num19;
					num2 = 180;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 306:
					if (num33 > 0)
					{
						num2 = 346;
						if (hWjyeqqsRaYsIQvpwj())
						{
							continue;
						}
						break;
					}
					goto case 234;
				case 81:
					array[19] = 126;
					num2 = 2;
					continue;
				case 374:
					array2[1] = 122;
					num = 206;
					break;
				case 363:
					num38 = num4;
					num2 = 223;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 6:
					if (P_0 == -1)
					{
						num2 = 268;
						continue;
					}
					goto case 328;
				case 410:
					num38 = 0u;
					num2 = 95;
					continue;
				case 23:
					num24 = 88 + 24;
					num2 = 116;
					continue;
				case 263:
					array[21] = (byte)num18;
					num2 = 140;
					continue;
				case 87:
				case 149:
					if (num21 >= num22)
					{
						num = 20;
						break;
					}
					goto case 224;
				case 189:
					num19 = 130 - 43;
					num2 = 212;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						num2 = 281;
					}
					continue;
				case 56:
					array[24] = 146;
					num2 = 347;
					continue;
				case 70:
					array[22] = 204;
					num2 = 46;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						num2 = 51;
					}
					continue;
				case 277:
					array[30] = 91;
					num2 = 25;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 144:
					mwNgRG8CHrjCfeyQZx(yesCHY8pgW8aPptmNL2);
					num2 = 194;
					continue;
				case 228:
					if (num32 > 0)
					{
						num2 = 250;
						continue;
					}
					goto case 237;
				case 272:
					hnh6D9KvCtaiNYZshb(cryptoStream);
					num = 127;
					break;
				case 122:
					num18 = 59 + 42;
					num = 15;
					break;
				case 207:
					array[8] = 168;
					num = 221;
					break;
				case 376:
					array[23] = (byte)num19;
					num2 = 344;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 236:
				case 273:
					if (num37 >= num32)
					{
						num2 = 115;
						continue;
					}
					goto case 392;
				case 318:
					array[0] = 66;
					num2 = 122;
					continue;
				case 301:
					array2[7] = (byte)num20;
					num2 = 406;
					continue;
				case 39:
					num19 = 74 + 116;
					num2 = 276;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 74:
					array3[num23] ^= array4[num23];
					num2 = 141;
					if (n9AjaF5boMRG46ICJT() != null)
					{
						num2 = 30;
					}
					continue;
				case 257:
					array[16] = 1;
					num2 = 70;
					if (hWjyeqqsRaYsIQvpwj())
					{
						num2 = 235;
					}
					continue;
				case 248:
					array[2] = 84;
					num = 49;
					break;
				case 10:
					array[17] = 97;
					num2 = 418;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 21:
					array2[6] = (byte)num20;
					num2 = 152;
					continue;
				case 389:
					num20 = 63 + 10;
					num2 = 41;
					if (hWjyeqqsRaYsIQvpwj())
					{
						num2 = 198;
					}
					continue;
				case 295:
					array[3] = (byte)num19;
					num = 341;
					break;
				case 204:
					array2[2] = 102;
					num2 = 118;
					continue;
				case 367:
					array2[11] = 98;
					num2 = 80;
					continue;
				case 135:
					array[19] = 136;
					num2 = 339;
					continue;
				case 11:
					num24 = 228 - 76;
					num2 = 13;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 36:
					array2[2] = (byte)num20;
					num2 = 204;
					continue;
				case 139:
					array2[9] = 134;
					num2 = 397;
					continue;
				case 130:
					array[29] = 106;
					num2 = 62;
					continue;
				case 358:
					num18 = 7 + 23;
					num = 123;
					break;
				case 370:
					array2[7] = 158;
					num2 = 52;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 320:
					array[10] = (byte)num18;
					num2 = 32;
					continue;
				case 71:
					array[3] = 129;
					num2 = 245;
					continue;
				case 116:
					array2[14] = (byte)num24;
					num2 = 10;
					if (hWjyeqqsRaYsIQvpwj())
					{
						num2 = 219;
					}
					continue;
				case 393:
					array2[12] = (byte)num24;
					num2 = 200;
					continue;
				case 49:
					array[2] = 90;
					num2 = 72;
					if (!hWjyeqqsRaYsIQvpwj())
					{
						num2 = 70;
					}
					continue;
				case 385:
					num19 = 228 - 76;
					num2 = 0;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						num2 = 295;
					}
					continue;
				case 120:
					array[13] = 87;
					num2 = 356;
					continue;
				case 308:
					array2[6] = 115;
					num2 = 190;
					if (hWjyeqqsRaYsIQvpwj())
					{
						num2 = 365;
					}
					continue;
				case 198:
					array2[1] = (byte)num20;
					num2 = 182;
					if (hWjyeqqsRaYsIQvpwj())
					{
						num2 = 374;
					}
					continue;
				case 245:
					array[3] = 205;
					num2 = 275;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 138:
					num34 = num38 ^ num39;
					num = 128;
					break;
				case 213:
					num37++;
					num2 = 273;
					continue;
				case 222:
					num20 = 60 + 99;
					num = 233;
					break;
				case 167:
					array[25] = (byte)num18;
					num2 = 75;
					if (n9AjaF5boMRG46ICJT() != null)
					{
						num2 = 73;
					}
					continue;
				case 327:
					num20 = 100 + 11;
					num2 = 384;
					continue;
				case 127:
					array7 = e06yyu3q9X;
					num = 328;
					break;
				case 75:
					array[25] = 220;
					num2 = 168;
					continue;
				case 33:
					array2[0] = (byte)num24;
					num2 = 389;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 153:
					transform = (ICryptoTransform)txsJ9eREEZ8m6jktd6(symmetricAlgorithm, array3, array4);
					num2 = 61;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 265:
					array2[11] = (byte)num24;
					num2 = 299;
					continue;
				case 22:
					num19 = 29 + 75;
					num2 = 136;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 293:
					array2[2] = (byte)num24;
					num2 = 381;
					continue;
				case 297:
					array[24] = 158;
					num2 = 398;
					continue;
				case 124:
					array[8] = 74;
					num2 = 415;
					continue;
				case 194:
					array = new byte[32];
					num2 = 5;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						num2 = 40;
					}
					continue;
				case 157:
					array[30] = (byte)num18;
					num2 = 192;
					continue;
				case 92:
					array2[7] = 178;
					num = 370;
					break;
				case 227:
					array2[1] = 225;
					num2 = 220;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 142:
					num18 = 239 - 79;
					num2 = 232;
					continue;
				case 31:
					array[8] = (byte)num19;
					num2 = 207;
					continue;
				case 392:
					if (num37 > 0)
					{
						num2 = 97;
						continue;
					}
					goto case 417;
				case 59:
					num22 = array7.Length / 4;
					num2 = 19;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 155:
					array[4] = 164;
					num2 = 148;
					if (n9AjaF5boMRG46ICJT() != null)
					{
						num2 = 103;
					}
					continue;
				case 215:
					num20 = 135 - 45;
					num2 = 28;
					continue;
				case 244:
					array[27] = (byte)num19;
					num2 = 170;
					continue;
				case 44:
					num18 = 195 - 65;
					num2 = 334;
					continue;
				case 82:
					num18 = 189 - 63;
					num2 = 94;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 61:
					stream = (Stream)uwvmLEiqUnb8Jysq2n();
					num2 = 319;
					if (n9AjaF5boMRG46ICJT() != null)
					{
						num2 = 17;
					}
					continue;
				case 302:
					num18 = 215 - 71;
					num2 = 403;
					continue;
				case 57:
					array[1] = 71;
					num2 = 402;
					if (!hWjyeqqsRaYsIQvpwj())
					{
						num2 = 111;
					}
					continue;
				case 26:
					array[21] = (byte)num19;
					num2 = 70;
					continue;
				case 16:
					array[1] = (byte)num18;
					num2 = 173;
					continue;
				case 331:
					if (e06yyu3q9X.Length != 0)
					{
						num2 = 330;
						continue;
					}
					goto case 137;
				case 60:
					array[14] = (byte)num19;
					num2 = 212;
					continue;
				case 276:
					array[18] = (byte)num19;
					num2 = 41;
					if (n9AjaF5boMRG46ICJT() != null)
					{
						num2 = 37;
					}
					continue;
				case 98:
					array2[4] = 84;
					num2 = 35;
					continue;
				case 405:
					num19 = 225 - 75;
					num2 = 38;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						num2 = 364;
					}
					continue;
				case 119:
					num24 = 85 + 78;
					num2 = 33;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 146:
					num19 = 40 + 119;
					num2 = 60;
					continue;
				case 246:
					array[30] = 146;
					num2 = 230;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 131:
					array[22] = (byte)num18;
					num2 = 414;
					continue;
				case 133:
					array2[4] = (byte)num20;
					num2 = 286;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 372:
					num20 = 240 - 80;
					num2 = 26;
					if (hWjyeqqsRaYsIQvpwj())
					{
						num2 = 126;
					}
					continue;
				case 37:
					array[15] = (byte)num18;
					num2 = 159;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 256:
					array[9] = 149;
					num = 278;
					break;
				case 309:
					array2[8] = 138;
					num = 294;
					break;
				case 103:
					array2[8] = 236;
					num = 216;
					break;
				case 169:
					num24 = 32 + 45;
					num2 = 129;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 232:
					array[2] = (byte)num18;
					num2 = 248;
					continue;
				case 229:
					num38 = 0u;
					num2 = 279;
					continue;
				case 420:
					array[4] = (byte)num19;
					num2 = 88;
					continue;
				case 66:
					num24 = 219 - 73;
					num = 393;
					break;
				case 386:
					array2[14] = (byte)num20;
					num2 = 324;
					if (hWjyeqqsRaYsIQvpwj())
					{
						num2 = 329;
					}
					continue;
				case 319:
					cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					num = 107;
					break;
				case 322:
					array[16] = (byte)num18;
					num2 = 66;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						num2 = 106;
					}
					continue;
				case 43:
					array2[10] = 144;
					num2 = 209;
					continue;
				case 113:
					num39 = 0u;
					num2 = 241;
					continue;
				case 83:
					array[17] = 161;
					num2 = 82;
					continue;
				case 321:
					array2[14] = 235;
					num2 = 390;
					continue;
				case 147:
					array[5] = 112;
					num2 = 165;
					if (!hWjyeqqsRaYsIQvpwj())
					{
						num2 = 45;
					}
					continue;
				case 305:
					array[24] = 128;
					num2 = 263;
					if (hWjyeqqsRaYsIQvpwj())
					{
						num2 = 412;
					}
					continue;
				case 359:
					array7 = (byte[])ToXcFEkCW7Uskp7uhV(yesCHY8pgW8aPptmNL2, (int)LaKVgVgM2m8Zwe7Sfg(vNnHKmOh4c3ViKcReE(yesCHY8pgW8aPptmNL2)));
					num2 = 96;
					if (hWjyeqqsRaYsIQvpwj())
					{
						num2 = 144;
					}
					continue;
				case 128:
					num33 = 0;
					num2 = 264;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 237:
					num43 = 0u;
					num2 = 258;
					continue;
				case 45:
					array2[13] = (byte)num24;
					num2 = 327;
					continue;
				case 395:
					num24 = 46 + 110;
					num2 = 265;
					continue;
				case 27:
					array2[7] = (byte)num24;
					num2 = 413;
					continue;
				case 148:
					num18 = 174 + 26;
					num2 = 208;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						num2 = 238;
					}
					continue;
				case 380:
					array2[5] = (byte)num20;
					num2 = 282;
					continue;
				case 286:
					num20 = 181 - 60;
					num2 = 380;
					continue;
				case 342:
					array4[1] = array6[0];
					num2 = 50;
					continue;
				case 84:
					array4 = array2;
					num2 = 217;
					if (n9AjaF5boMRG46ICJT() != null)
					{
						num2 = 2;
					}
					continue;
				case 24:
					num24 = 142 + 3;
					num2 = 407;
					continue;
				case 7:
					if (array6 == null)
					{
						num2 = 0;
						if (hWjyeqqsRaYsIQvpwj())
						{
							continue;
						}
						break;
					}
					goto case 12;
				case 126:
					array2[4] = (byte)num20;
					num2 = 222;
					continue;
				case 90:
					array[10] = 45;
					num2 = 163;
					continue;
				case 32:
					array[11] = 171;
					num2 = 33;
					if (hWjyeqqsRaYsIQvpwj())
					{
						num2 = 44;
					}
					continue;
				case 143:
					num24 = 135 - 45;
					num2 = 34;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 203:
					array[10] = 121;
					num2 = 378;
					continue;
				case 339:
					num18 = 163 - 54;
					num2 = 18;
					continue;
				case 164:
					array[14] = 198;
					num2 = 401;
					continue;
				case 384:
					array2[14] = (byte)num20;
					num2 = 321;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 353:
					array[29] = (byte)num19;
					num2 = 246;
					continue;
				case 334:
					array[11] = (byte)num18;
					num2 = 373;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 352:
					num24 = 89 + 112;
					num2 = 93;
					if (hWjyeqqsRaYsIQvpwj())
					{
						num2 = 158;
					}
					continue;
				default:
					num23 = 0;
					num2 = 269;
					continue;
				case 137:
					yesCHY8pgW8aPptmNL2 = new yesCHY8pgW8aPptmNL((Stream)tiLn0wAndx5mcmaxTs(mQSJHjPE8, "meO5QSnp10WXApRUnW.O9O9Bs4IQP6N7kN3N0"));
					num2 = 38;
					continue;
				case 183:
					array[25] = (byte)num19;
					num2 = 30;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 362:
					array[31] = 122;
					num2 = 160;
					continue;
				case 9:
				case 264:
					if (num33 >= num32)
					{
						num2 = 151;
						if (n9AjaF5boMRG46ICJT() == null)
						{
							num2 = 225;
						}
						continue;
					}
					goto case 306;
				case 112:
					num19 = 28 + 54;
					num2 = 317;
					continue;
				case 193:
					array[6] = 130;
					num = 271;
					break;
				case 218:
					num43 = (uint)num30;
					num2 = 60;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						num2 = 104;
					}
					continue;
				case 416:
					num20 = 175 - 58;
					num2 = 178;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 48:
					array[31] = (byte)num19;
					num2 = 362;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 303:
					array[15] = 133;
					num2 = 400;
					continue;
				case 151:
					num18 = 106 + 26;
					num2 = 16;
					continue;
				case 317:
					array[29] = (byte)num19;
					num2 = 130;
					continue;
				case 210:
					num37 = 0;
					num2 = 236;
					continue;
				case 219:
					num20 = 99 + 26;
					num2 = 386;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 125:
					array[21] = 176;
					num2 = 172;
					continue;
				case 110:
					array[1] = (byte)num18;
					num2 = 189;
					continue;
				case 95:
					num42 = 0u;
					num2 = 5;
					continue;
				case 262:
					array4[7] = array6[3];
					num2 = 355;
					continue;
				case 173:
					num18 = 197 - 65;
					num2 = 110;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 242:
					aK0KnDeIFkF7KxmhGc(symmetricAlgorithm, CipherMode.CBC);
					num2 = 153;
					continue;
				case 406:
					num24 = 98 - 21;
					num2 = 27;
					if (!hWjyeqqsRaYsIQvpwj())
					{
						num2 = 27;
					}
					continue;
				case 212:
					array[14] = 28;
					num2 = 291;
					continue;
				case 166:
					num18 = 198 - 66;
					num2 = 60;
					if (hWjyeqqsRaYsIQvpwj())
					{
						num2 = 105;
					}
					continue;
				case 100:
					array[8] = (byte)num19;
					num2 = 22;
					continue;
				case 47:
					num24 = 176 - 80;
					num2 = 293;
					continue;
				case 117:
					array[29] = (byte)num18;
					num2 = 399;
					if (n9AjaF5boMRG46ICJT() != null)
					{
						num2 = 20;
					}
					continue;
				case 414:
					array[22] = 102;
					num2 = 300;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 235:
					array[17] = 170;
					num2 = 366;
					continue;
				case 326:
					array[0] = 17;
					num2 = 151;
					continue;
				case 25:
					num18 = 96 - 18;
					num2 = 157;
					if (!hWjyeqqsRaYsIQvpwj())
					{
						num2 = 128;
					}
					continue;
				case 314:
					array[19] = (byte)num19;
					num2 = 276;
					if (hWjyeqqsRaYsIQvpwj())
					{
						num2 = 371;
					}
					continue;
				case 163:
					array[10] = 145;
					num2 = 419;
					continue;
				case 258:
					num21 = 0;
					num2 = 87;
					continue;
				case 278:
					num18 = 210 + 43;
					num2 = 348;
					continue;
				case 315:
					array[7] = (byte)num18;
					num2 = 289;
					if (hWjyeqqsRaYsIQvpwj())
					{
						num2 = 357;
					}
					continue;
				case 102:
					num42 = (uint)((array3[num43 + 3] << 24) | (array3[num43 + 2] << 16) | (array3[num43 + 1] << 8) | array3[num43]);
					num2 = 191;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 290:
					num20 = 226 - 75;
					num2 = 411;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 252:
					array[18] = 114;
					num2 = 39;
					continue;
				case 332:
					num36 += 8;
					num = 234;
					break;
				case 397:
					num20 = 16 + 112;
					num2 = 350;
					continue;
				case 97:
					num39 <<= 8;
					num2 = 417;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 249:
					num20 = 187 + 26;
					num = 63;
					break;
				case 351:
					array2[2] = (byte)num24;
					num2 = 283;
					continue;
				case 34:
					array2[13] = (byte)num24;
					num2 = 245;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						num2 = 290;
					}
					continue;
				case 357:
					array[7] = 240;
					num2 = 76;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 101:
					num18 = 97 + 124;
					num2 = 394;
					continue;
				case 340:
					array6 = (byte[])usjh9pM1R8s7VTU30a(BWt951bgYJD64E7bv7(mQSJHjPE8));
					num2 = 7;
					continue;
				case 91:
					num19 = 80 + 53;
					num2 = 353;
					continue;
				case 46:
					array[0] = (byte)num19;
					num = 318;
					break;
				case 5:
					num39 = 0u;
					num2 = 228;
					if (!hWjyeqqsRaYsIQvpwj())
					{
						num2 = 155;
					}
					continue;
				case 132:
					array2[1] = 106;
					num2 = 296;
					continue;
				case 313:
					array[23] = (byte)num19;
					num = 297;
					break;
				case 371:
					num18 = 178 - 59;
					num2 = 335;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 177:
					array2[12] = 128;
					num = 66;
					break;
				case 411:
					array2[13] = (byte)num20;
					num2 = 247;
					continue;
				case 30:
					array[25] = 103;
					num2 = 77;
					continue;
				case 35:
					num20 = 179 + 34;
					num2 = 13;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						num2 = 133;
					}
					continue;
				case 338:
					array2[5] = (byte)num20;
					num2 = 308;
					continue;
				case 158:
					array2[15] = (byte)num24;
					num2 = 336;
					continue;
				case 390:
					array2[14] = 141;
					num2 = 23;
					continue;
				case 106:
					num18 = 145 - 48;
					num2 = 190;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 88:
					num19 = 249 - 83;
					num2 = 409;
					continue;
				case 187:
					array[11] = (byte)num19;
					num2 = 179;
					continue;
				case 296:
					num24 = 158 - 52;
					num2 = 343;
					continue;
				case 335:
					array[19] = (byte)num18;
					num = 135;
					break;
				case 261:
					num19 = 46 + 100;
					num2 = 153;
					if (hWjyeqqsRaYsIQvpwj())
					{
						num2 = 244;
					}
					continue;
				case 343:
					array2[1] = (byte)num24;
					num2 = 225;
					if (hWjyeqqsRaYsIQvpwj())
					{
						num2 = 227;
					}
					continue;
				case 89:
					array2[2] = (byte)num20;
					num = 47;
					break;
				case 221:
					array[9] = 136;
					num = 377;
					break;
				case 188:
					array[11] = (byte)num18;
					num2 = 39;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						num2 = 316;
					}
					continue;
				case 185:
					array2[7] = 118;
					num = 92;
					break;
				case 381:
					array2[3] = 215;
					num2 = 53;
					continue;
				case 241:
					num38 += num42;
					num = 210;
					break;
				case 134:
					array2[10] = (byte)num24;
					num2 = 43;
					continue;
				case 234:
					array5[num30 + num33] = (byte)((num34 & num35) >> num36);
					num2 = 2;
					if (hWjyeqqsRaYsIQvpwj())
					{
						num2 = 292;
					}
					continue;
				case 72:
					array[2] = 110;
					num2 = 385;
					continue;
				case 180:
					array[26] = 171;
					num2 = 254;
					if (n9AjaF5boMRG46ICJT() != null)
					{
						num2 = 124;
					}
					continue;
				case 415:
					num19 = 103 + 124;
					num2 = 31;
					continue;
				case 388:
					e06yyu3q9X = (byte[])wabYaENDLsawubxOn3(stream);
					num2 = 134;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						num2 = 243;
					}
					continue;
				case 67:
					return "";
				case 176:
					num19 = 10 + 35;
					num2 = 58;
					continue;
				case 354:
					array[7] = (byte)num19;
					num2 = 23;
					if (hWjyeqqsRaYsIQvpwj())
					{
						num2 = 166;
					}
					continue;
				case 178:
					array2[10] = (byte)num20;
					num2 = 8;
					continue;
				case 79:
					array5[num30 + 2] = (byte)((num31 & 0xFF0000) >> 16);
					num = 199;
					break;
				case 196:
					array[2] = 13;
					num = 142;
					break;
				case 54:
					num30 = num21 * 4;
					num2 = 86;
					if (!hWjyeqqsRaYsIQvpwj())
					{
						num2 = 58;
					}
					continue;
				case 96:
					num20 = 10 + 113;
					num2 = 345;
					continue;
				case 8:
					array2[10] = 104;
					num2 = 249;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 366:
					array[17] = 88;
					num2 = 266;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 337:
					num19 = 47 + 124;
					num2 = 420;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 238:
					array[4] = (byte)num18;
					num = 147;
					break;
				case 1:
					array[5] = 98;
					num = 65;
					break;
				case 298:
					array[28] = 126;
					num2 = 175;
					continue;
				case 171:
					num19 = 18 + 93;
					num2 = 354;
					continue;
				case 240:
					array[0] = 62;
					num2 = 99;
					continue;
				case 13:
					array2[4] = (byte)num24;
					num2 = 98;
					continue;
				case 409:
					array[4] = (byte)num19;
					num2 = 114;
					continue;
				case 274:
					array5[num30] = (byte)(num31 & 0xFF);
					num2 = 285;
					continue;
				case 216:
					num24 = 252 - 84;
					num = 182;
					break;
				case 121:
					array[27] = (byte)num19;
					num2 = 298;
					continue;
				case 299:
					array2[12] = 123;
					num2 = 177;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 349:
					num24 = 189 - 120;
					num2 = 360;
					continue;
				case 64:
					num41 = array3.Length / 4;
					num2 = 410;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 239:
					array[24] = 108;
					num2 = 56;
					continue;
				case 280:
					num20 = 20 + 113;
					num2 = 0;
					if (hWjyeqqsRaYsIQvpwj())
					{
						num2 = 36;
					}
					continue;
				case 123:
					array[30] = (byte)num18;
					num2 = 277;
					continue;
				case 172:
					num18 = 186 - 62;
					num2 = 263;
					continue;
				case 217:
					xrYNjGve5YU9JwUjOw(array4);
					num2 = 340;
					continue;
				case 182:
					array2[9] = (byte)num24;
					num2 = 139;
					continue;
				case 86:
					num43 = (uint)(num40 * 4);
					num2 = 102;
					continue;
				case 18:
					array[19] = (byte)num18;
					num2 = 81;
					if (!hWjyeqqsRaYsIQvpwj())
					{
						num2 = 55;
					}
					continue;
				case 2:
					array[20] = 177;
					num2 = 302;
					continue;
				case 407:
					array2[3] = (byte)num24;
					num2 = 208;
					continue;
				case 42:
					array2[5] = 66;
					num2 = 162;
					continue;
				case 401:
					array[15] = 86;
					num2 = 303;
					continue;
				case 266:
					num19 = 144 - 48;
					num2 = 267;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 368:
					array[13] = 143;
					num2 = 101;
					continue;
				case 259:
					array[11] = (byte)num18;
					num2 = 369;
					continue;
				case 383:
					array2[0] = 50;
					num2 = 215;
					continue;
				case 62:
					num18 = 131 - 43;
					num2 = 117;
					continue;
				case 40:
					array[0] = 83;
					num2 = 240;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 284:
					array4[15] = array6[7];
					num2 = 181;
					continue;
				case 399:
					array[29] = 151;
					num2 = 91;
					if (!hWjyeqqsRaYsIQvpwj())
					{
						num2 = 34;
					}
					continue;
				case 304:
					array[4] = 104;
					num2 = 155;
					continue;
				case 350:
					array2[9] = (byte)num20;
					num2 = 382;
					if (!hWjyeqqsRaYsIQvpwj())
					{
						num2 = 371;
					}
					continue;
				case 341:
					num19 = 74 + 15;
					num2 = 174;
					continue;
				case 168:
					array[26] = 102;
					num2 = 405;
					continue;
				case 360:
					array2[15] = (byte)num24;
					num2 = 12;
					if (hWjyeqqsRaYsIQvpwj())
					{
						num2 = 84;
					}
					continue;
				case 402:
					array[2] = 107;
					num2 = 196;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 175:
					array[28] = 138;
					num2 = 109;
					continue;
				case 4:
					array[14] = 78;
					num2 = 146;
					continue;
				case 356:
					array[13] = 104;
					num2 = 312;
					continue;
				case 53:
					num20 = 34 + 105;
					num2 = 186;
					continue;
				case 251:
					num18 = 25 + 83;
					num2 = 322;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 281:
					array[1] = (byte)num19;
					num = 57;
					break;
				case 28:
					array2[0] = (byte)num20;
					num2 = 119;
					continue;
				case 192:
					num19 = 24 + 104;
					num2 = 48;
					continue;
				case 243:
					hnh6D9KvCtaiNYZshb(stream);
					num2 = 272;
					continue;
				case 50:
					array4[3] = array6[1];
					num = 323;
					break;
				case 19:
					array5 = new byte[array7.Length];
					num2 = 64;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 294:
					array2[8] = 140;
					num2 = 404;
					continue;
				case 129:
					array2[0] = (byte)num24;
					num2 = 333;
					continue;
				case 65:
					array[6] = 88;
					num2 = 193;
					continue;
				case 58:
					array[10] = (byte)num19;
					num2 = 203;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 310:
					num19 = 118 - 113;
					num2 = 78;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 174:
					array[3] = (byte)num19;
					num2 = 71;
					continue;
				case 396:
					num31 = num38 ^ num39;
					num = 274;
					break;
				case 260:
					array[18] = 133;
					num2 = 252;
					continue;
				case 282:
					array2[5] = 148;
					num2 = 42;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 275:
					num19 = 193 - 64;
					num2 = 85;
					continue;
				case 346:
					num35 <<= 8;
					num2 = 332;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 328:
					num32 = array7.Length % 4;
					num = 59;
					break;
				case 300:
					array[23] = 152;
					num2 = 161;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 333:
					array2[0] = 140;
					num2 = 383;
					if (!hWjyeqqsRaYsIQvpwj())
					{
						num2 = 206;
					}
					continue;
				case 195:
					num18 = 37 + 99;
					num2 = 315;
					if (n9AjaF5boMRG46ICJT() != null)
					{
						num2 = 276;
					}
					continue;
				case 255:
					array[30] = (byte)num18;
					num2 = 358;
					continue;
				case 69:
					array[7] = 88;
					num2 = 171;
					if (n9AjaF5boMRG46ICJT() != null)
					{
						num2 = 47;
					}
					continue;
				case 184:
					array2[12] = (byte)num24;
					num2 = 307;
					continue;
				case 230:
					num18 = 46 + 111;
					num2 = 255;
					continue;
				case 159:
					array[15] = 195;
					num2 = 251;
					continue;
				case 3:
					array2[1] = (byte)num20;
					num2 = 132;
					continue;
				case 77:
					num18 = 71 + 100;
					num2 = 167;
					continue;
				case 403:
					array[20] = (byte)num18;
					num2 = 205;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 104:
					num39 = (uint)((array7[num43 + 3] << 24) | (array7[num43 + 2] << 16) | (array7[num43 + 1] << 8) | array7[num43]);
					num2 = 391;
					continue;
				case 292:
					num33++;
					num2 = 9;
					continue;
				case 404:
					array2[8] = 118;
					num2 = 214;
					continue;
				case 160:
					array[31] = 1;
					num2 = 270;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 379:
					num18 = 130 - 43;
					num = 188;
					break;
				case 152:
					array2[6] = 153;
					num2 = 185;
					continue;
				case 325:
					if (num21 == num22 - 1)
					{
						num2 = 17;
						if (n9AjaF5boMRG46ICJT() != null)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 145;
				case 111:
					if (num32 > 0)
					{
						num2 = 138;
						if (n9AjaF5boMRG46ICJT() == null)
						{
							continue;
						}
						break;
					}
					goto case 396;
				case 55:
					array[14] = (byte)num19;
					num2 = 164;
					continue;
				case 63:
					array2[10] = (byte)num20;
					num2 = 96;
					continue;
				case 355:
					array4[9] = array6[4];
					num2 = 211;
					continue;
				case 108:
					array[20] = (byte)num18;
					num = 125;
					break;
				case 14:
					array[9] = (byte)num19;
					num2 = 256;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 323:
					array4[5] = array6[2];
					num2 = 63;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						num2 = 262;
					}
					continue;
				case 311:
					RIApjvtDpRXOCN7jua(cryptoStream);
					num2 = 388;
					continue;
				case 225:
				case 289:
					num21++;
					num2 = 149;
					if (!hWjyeqqsRaYsIQvpwj())
					{
						num2 = 98;
					}
					continue;
				case 336:
					array2[15] = 152;
					num2 = 349;
					continue;
				case 344:
					array[23] = 130;
					num2 = 50;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						num2 = 253;
					}
					continue;
				case 418:
					array[18] = 147;
					num2 = 260;
					continue;
				case 115:
				case 391:
					num4 = num38;
					num2 = 229;
					continue;
				case 191:
					num35 = 255u;
					num2 = 249;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						num2 = 324;
					}
					continue;
				case 78:
					array[12] = (byte)num19;
					num2 = 288;
					continue;
				case 200:
					num24 = 165 - 73;
					num = 184;
					break;
				case 316:
					num19 = 58 + 53;
					num2 = 187;
					if (n9AjaF5boMRG46ICJT() != null)
					{
						num2 = 142;
					}
					continue;
				case 254:
					num19 = 252 - 84;
					num = 226;
					break;
				case 93:
				case 269:
					if (num23 >= array4.Length)
					{
						num2 = 6;
						if (hWjyeqqsRaYsIQvpwj())
						{
							continue;
						}
						break;
					}
					goto case 74;
				case 231:
					array2[13] = (byte)num20;
					num2 = 143;
					continue;
				case 375:
					array[3] = (byte)num18;
					num2 = 337;
					continue;
				case 400:
					num18 = 25 + 98;
					num2 = 37;
					continue;
				case 291:
					num19 = 248 - 82;
					num2 = 55;
					continue;
				case 267:
					array[17] = (byte)num19;
					num2 = 83;
					continue;
				case 421:
					array[13] = (byte)num19;
					num2 = 368;
					continue;
				case 205:
					num18 = 149 - 106;
					num2 = 108;
					if (!hWjyeqqsRaYsIQvpwj())
					{
						num2 = 51;
					}
					continue;
				case 12:
					if (array6.Length > 0)
					{
						num2 = 342;
						continue;
					}
					goto default;
				case 412:
					array[24] = 157;
					num2 = 239;
					continue;
				case 211:
					array4[11] = array6[5];
					num2 = 361;
					continue;
				case 199:
					array5[num30 + 3] = (byte)((num31 & 0xFF000000u) >> 24);
					num2 = 289;
					continue;
				case 209:
					array2[10] = 127;
					num2 = 416;
					continue;
				case 80:
					array2[11] = 169;
					num2 = 395;
					if (n9AjaF5boMRG46ICJT() != null)
					{
						num2 = 132;
					}
					continue;
				case 408:
					num18 = 101 + 110;
					num2 = 375;
					continue;
				case 118:
					num20 = 195 - 65;
					num2 = 89;
					continue;
				case 179:
					num18 = 164 - 93;
					num2 = 259;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 347:
					num19 = 198 - 66;
					num2 = 183;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 201:
					num24 = 94 + 116;
					num2 = 134;
					if (n9AjaF5boMRG46ICJT() != null)
					{
						num2 = 105;
					}
					continue;
				case 288:
					num19 = 70 + 121;
					num2 = 421;
					continue;
				case 417:
					num39 |= array7[array7.Length - (1 + num37)];
					num2 = 213;
					continue;
				case 324:
					num36 = 0;
					num2 = 325;
					continue;
				case 250:
					num22++;
					num2 = 237;
					continue;
				case 345:
					array2[11] = (byte)num20;
					num2 = 367;
					continue;
				case 107:
					tMt3koa3HlHsDGIL3T(cryptoStream, array7, 0, array7.Length);
					num2 = 311;
					if (n9AjaF5boMRG46ICJT() != null)
					{
						num2 = 157;
					}
					continue;
				case 413:
					array2[8] = 225;
					num2 = 309;
					continue;
				case 15:
					array[0] = (byte)num18;
					num2 = 326;
					continue;
				case 38:
					PA8CnCXVgdBhTYNags(vNnHKmOh4c3ViKcReE(yesCHY8pgW8aPptmNL2), 0L);
					num2 = 359;
					continue;
				case 17:
					if (num32 > 0)
					{
						num2 = 80;
						if (n9AjaF5boMRG46ICJT() == null)
						{
							num2 = 113;
						}
						continue;
					}
					goto case 145;
				case 85:
					array[3] = (byte)num19;
					num2 = 255;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						num2 = 408;
					}
					continue;
				case 365:
					num20 = 57 + 68;
					num2 = 21;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 329:
					num24 = 111 + 74;
					num2 = 287;
					continue;
				case 94:
					array[17] = (byte)num18;
					num2 = 10;
					continue;
				case 387:
					array[4] = (byte)num19;
					num2 = 56;
					if (hWjyeqqsRaYsIQvpwj())
					{
						num2 = 304;
					}
					continue;
				case 162:
					num20 = 145 - 105;
					num2 = 338;
					continue;
				case 161:
					array[23] = 160;
					num2 = 150;
					continue;
				case 312:
					array[13] = 186;
					num2 = 4;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 220:
					num24 = 59 + 121;
					num2 = 351;
					continue;
				case 51:
					num18 = 67 + 49;
					num2 = 131;
					if (n9AjaF5boMRG46ICJT() != null)
					{
						num2 = 128;
					}
					continue;
				case 136:
					array[8] = (byte)num19;
					num2 = 124;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 214:
					array2[8] = 125;
					num = 103;
					break;
				case 271:
					array[6] = 243;
					num = 69;
					break;
				case 361:
					array4[13] = array6[6];
					num2 = 284;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 419:
					num18 = 183 + 52;
					num2 = 320;
					continue;
				case 226:
					array[27] = (byte)num19;
					num2 = 261;
					continue;
				case 202:
				case 330:
					num25 = SMHi0uVOTyfWvpxrQw(e06yyu3q9X, P_0);
					num2 = 73;
					continue;
				case 394:
					array[13] = (byte)num18;
					num2 = 120;
					continue;
				case 398:
					array[24] = 107;
					num2 = 305;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 373:
					array[11] = 177;
					num2 = 379;
					continue;
				case 99:
					num19 = 117 + 87;
					num2 = 46;
					continue;
				case 29:
					num19 = 68 + 122;
					num2 = 26;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 233:
					array2[4] = (byte)num20;
					num2 = 11;
					continue;
				case 76:
					num19 = 113 + 48;
					num2 = 100;
					continue;
				case 268:
					symmetricAlgorithm = (SymmetricAlgorithm)hMOlSvu3IZ8d8Biq97();
					num2 = 242;
					continue;
				case 287:
					array2[15] = (byte)num24;
					num = 352;
					break;
				case 68:
					array2[4] = (byte)num20;
					num2 = 372;
					continue;
				case 154:
					array2[0] = 98;
					num2 = 169;
					continue;
				case 20:
					e06yyu3q9X = array5;
					num2 = 202;
					continue;
				case 224:
					num40 = num21 % num41;
					num2 = 54;
					if (n9AjaF5boMRG46ICJT() != null)
					{
						num2 = 9;
					}
					continue;
				case 247:
					num24 = 46 - 21;
					num2 = 45;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 170:
					num19 = 238 + 2;
					num2 = 121;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 377:
					num19 = 8 + 49;
					num2 = 14;
					if (!hWjyeqqsRaYsIQvpwj())
					{
						num2 = 2;
					}
					continue;
				case 165:
					array[5] = 94;
					num2 = 1;
					if (!hWjyeqqsRaYsIQvpwj())
					{
						num2 = 1;
					}
					continue;
				case 150:
					num19 = 107 + 106;
					num2 = 376;
					continue;
				case 253:
					num19 = 91 - 76;
					num = 313;
					break;
				case 285:
					array5[num30 + 1] = (byte)((num31 & 0xFF00) >> 8);
					num2 = 79;
					continue;
				case 369:
					array[12] = 84;
					num2 = 197;
					continue;
				case 114:
					num19 = 145 - 48;
					num2 = 387;
					if (!hWjyeqqsRaYsIQvpwj())
					{
						num2 = 326;
					}
					continue;
				case 190:
					array[16] = (byte)num18;
					num = 257;
					break;
				case 41:
					num19 = 241 - 80;
					num2 = 314;
					if (n9AjaF5boMRG46ICJT() != null)
					{
						num2 = 44;
					}
					continue;
				case 382:
					array2[9] = 234;
					num = 201;
					break;
				case 52:
					num20 = 207 - 69;
					num2 = 301;
					continue;
				case 73:
				{
					string result;
					try
					{
						result = (string)G1GejsH1kdNAehSdkK(Ddotf3ciQCQeaYCiIu(), e06yyu3q9X, P_0 + 4, num25);
						int num26 = 0;
						if (!hWjyeqqsRaYsIQvpwj())
						{
							num26 = num27;
						}
						switch (num26)
						{
						case 0:
							break;
						}
					}
					catch
					{
						int num28 = 0;
						if (!hWjyeqqsRaYsIQvpwj())
						{
							num28 = num29;
						}
						switch (num28)
						{
						}
						goto case 67;
					}
					return result;
				}
				case 223:
					if (num21 == num22 - 1)
					{
						num2 = 111;
						if (!hWjyeqqsRaYsIQvpwj())
						{
							num2 = 16;
						}
						continue;
					}
					goto case 396;
				case 348:
					array[9] = (byte)num18;
					num2 = 176;
					continue;
				case 307:
					num20 = 39 + 3;
					num2 = 231;
					continue;
				case 197:
					array[12] = 153;
					num2 = 310;
					continue;
				case 141:
					num23++;
					num2 = 69;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						num2 = 93;
					}
					continue;
				case 109:
					array[28] = 169;
					num2 = 112;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 145:
					num38 += num42;
					num2 = 218;
					continue;
				case 283:
					array2[2] = 122;
					num2 = 280;
					if (hWjyeqqsRaYsIQvpwj())
					{
						continue;
					}
					break;
				case 270:
					array3 = array;
					num2 = 156;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 378:
					array[10] = 88;
					num2 = 75;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						num2 = 90;
					}
					continue;
				case 208:
					num20 = 233 - 77;
					num2 = 68;
					if (n9AjaF5boMRG46ICJT() == null)
					{
						continue;
					}
					break;
				case 156:
					array2 = new byte[16];
					num2 = 154;
					if (!hWjyeqqsRaYsIQvpwj())
					{
						num2 = 77;
					}
					continue;
				case 105:
					array[7] = (byte)num18;
					num = 195;
					break;
				case 140:
					array[21] = 141;
					num2 = 5;
					if (hWjyeqqsRaYsIQvpwj())
					{
						num2 = 29;
					}
					continue;
				case 279:
				{
					uint num3 = num4;
					uint num5 = num4;
					uint num6 = 309770768u;
					uint num7 = num5;
					uint num8 = 1293346624u;
					uint num9 = 982458892u;
					uint num10 = 2048092166u;
					uint num11 = 1880658544u;
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
					num2 = 363;
					continue;
				}
				}
				break;
			}
		}
	}

	[oamTPajlRfuYnXdshk(typeof(oamTPajlRfuYnXdshk.VAe7DaY6ttTvcEhkli<object>[]))]
	internal static string LgCCAELfO(string P_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int ONm57DZYp()
	{
		return 5;
	}

	private static void KLpLMY75I()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate vkGfIB2Le(IntPtr P_0, Type P_1)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[2] { P_0, P_1 });
	}

	internal static object aCHoYpgW8(object P_0)
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
	public static extern IntPtr qPpOtmNLO(string P_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr NFYB7rR1Y(IntPtr P_0, string P_1);

	private static IntPtr lQ3e9n0G5(IntPtr P_0, string P_1, uint P_2)
	{
		if (E7ZyN5JEu0 == null)
		{
			IntPtr ptr = NFYB7rR1Y(so8WHSBJcy(), "Find ".Trim() + "ResourceA");
			E7ZyN5JEu0 = (BcFY7r6R1YUQ39n0G5)Marshal.GetDelegateForFunctionPointer(ptr, typeof(BcFY7r6R1YUQ39n0G5));
		}
		return E7ZyN5JEu0(P_0, P_1, P_2);
	}

	private static IntPtr jOsRy4yMa(IntPtr P_0, uint P_1, uint P_2, uint P_3)
	{
		if (fIZym0Hv2M == null)
		{
			IntPtr ptr = NFYB7rR1Y(so8WHSBJcy(), "Virtual ".Trim() + "Alloc");
			fIZym0Hv2M = (jOsy4ylMaC5GalZ4l0)Marshal.GetDelegateForFunctionPointer(ptr, typeof(jOsy4ylMaC5GalZ4l0));
		}
		return fIZym0Hv2M(P_0, P_1, P_2, P_3);
	}

	private static int x5GialZ4l(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
	{
		if (QMqy3u1SeC == null)
		{
			IntPtr ptr = NFYB7rR1Y(so8WHSBJcy(), "Write ".Trim() + "Process ".Trim() + "Memory");
			QMqy3u1SeC = (fSLDGhHDCw4F475myS)Marshal.GetDelegateForFunctionPointer(ptr, typeof(fSLDGhHDCw4F475myS));
		}
		return QMqy3u1SeC(P_0, P_1, P_2, P_3, out P_4);
	}

	private static int f0SMLDGhD(IntPtr P_0, int P_1, int P_2, ref int P_3)
	{
		if (Jlyy23w0lf == null)
		{
			IntPtr ptr = NFYB7rR1Y(so8WHSBJcy(), "Virtual ".Trim() + "Protect");
			Jlyy23w0lf = (zQLmGxaDM52C9GMl0o)Marshal.GetDelegateForFunctionPointer(ptr, typeof(zQLmGxaDM52C9GMl0o));
		}
		return Jlyy23w0lf(P_0, P_1, P_2, ref P_3);
	}

	private static IntPtr ww4kF475m(uint P_0, int P_1, uint P_2)
	{
		if (QQtyGJHISL == null)
		{
			IntPtr ptr = NFYB7rR1Y(so8WHSBJcy(), "Open ".Trim() + "Process");
			QQtyGJHISL = (VPe9rQbVIYsgWXo6k8)Marshal.GetDelegateForFunctionPointer(ptr, typeof(VPe9rQbVIYsgWXo6k8));
		}
		return QQtyGJHISL(P_0, P_1, P_2);
	}

	private static int bSfgQLmGx(IntPtr P_0)
	{
		if (diZyCkH83p == null)
		{
			IntPtr ptr = NFYB7rR1Y(so8WHSBJcy(), "Close ".Trim() + "Handle");
			diZyCkH83p = (wPhOndTHxOgb27oZtd)Marshal.GetDelegateForFunctionPointer(ptr, typeof(wPhOndTHxOgb27oZtd));
		}
		return diZyCkH83p(P_0);
	}

	[SpecialName]
	private static IntPtr so8WHSBJcy()
	{
		if (XDVy55vtqC == IntPtr.Zero)
		{
			XDVy55vtqC = qPpOtmNLO("kernel ".Trim() + "32.dll");
		}
		return XDVy55vtqC;
	}

	[oamTPajlRfuYnXdshk(typeof(oamTPajlRfuYnXdshk.VAe7DaY6ttTvcEhkli<object>[]))]
	private static byte[] LM5t2C9GM(string P_0)
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

	private static Stream o0o1pPe9r()
	{
		return new MemoryStream();
	}

	private static byte[] eVI7YsgWX(Stream P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	[oamTPajlRfuYnXdshk(typeof(oamTPajlRfuYnXdshk.VAe7DaY6ttTvcEhkli<object>[]))]
	private static byte[] A6kV8CPhO(byte[] P_0)
	{
		Stream stream = o0o1pPe9r();
		SymmetricAlgorithm symmetricAlgorithm = VAeH7Da6t();
		symmetricAlgorithm.Key = new byte[32]
		{
			243, 208, 45, 146, 44, 142, 199, 236, 81, 49,
			202, 48, 0, 239, 205, 233, 153, 5, 136, 140,
			147, 203, 32, 235, 136, 245, 20, 150, 140, 26,
			163, 126
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			127, 157, 206, 69, 148, 38, 27, 132, 81, 251,
			13, 122, 157, 135, 207, 160
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		return eVI7YsgWX(stream);
	}

	private byte[] OdHDxOgb2()
	{
		return null;
	}

	private byte[] JoZFtdu2U()
	{
		return null;
	}

	private byte[] OqLSrjfc8()
	{
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] hifc2hHZ7()
	{
		string text = "{11111-22222-20001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] ur2nccNm3()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] CJYZykhQ7()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] k70r9EDnF()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] zvLhewQUh()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] hGaulAZh0()
	{
		string text = "{11111-22222-50001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] ONPXD4ro7()
	{
		string text = "{11111-22222-50001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal static object tiLn0wAndx5mcmaxTs(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object vNnHKmOh4c3ViKcReE(object P_0)
	{
		return ((yesCHY8pgW8aPptmNL)P_0).fHSkdAnkJf();
	}

	internal static void PA8CnCXVgdBhTYNags(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long LaKVgVgM2m8Zwe7Sfg(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object ToXcFEkCW7Uskp7uhV(object P_0, int P_1)
	{
		return ((yesCHY8pgW8aPptmNL)P_0).jJ9yOjRNcH(P_1);
	}

	internal static void mwNgRG8CHrjCfeyQZx(object P_0)
	{
		((yesCHY8pgW8aPptmNL)P_0).seyyRXd5TR();
	}

	internal static void xrYNjGve5YU9JwUjOw(object P_0)
	{
		Array.Reverse((Array)P_0);
	}

	internal static object BWt951bgYJD64E7bv7(object P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	internal static object usjh9pM1R8s7VTU30a(object P_0)
	{
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}

	internal static object hMOlSvu3IZ8d8Biq97()
	{
		return VAeH7Da6t();
	}

	internal static void aK0KnDeIFkF7KxmhGc(object P_0, CipherMode P_1)
	{
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	internal static object txsJ9eREEZ8m6jktd6(object P_0, object P_1, object P_2)
	{
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	internal static object uwvmLEiqUnb8Jysq2n()
	{
		return o0o1pPe9r();
	}

	internal static void tMt3koa3HlHsDGIL3T(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void RIApjvtDpRXOCN7jua(object P_0)
	{
		((CryptoStream)P_0).FlushFinalBlock();
	}

	internal static object wabYaENDLsawubxOn3(object P_0)
	{
		return eVI7YsgWX((Stream)P_0);
	}

	internal static void hnh6D9KvCtaiNYZshb(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static int SMHi0uVOTyfWvpxrQw(object P_0, int P_1)
	{
		return BitConverter.ToInt32((byte[])P_0, P_1);
	}

	internal static object Ddotf3ciQCQeaYCiIu()
	{
		return Encoding.Unicode;
	}

	internal static object G1GejsH1kdNAehSdkK(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Encoding)P_0).GetString((byte[])P_1, P_2, P_3);
	}

	internal static bool hWjyeqqsRaYsIQvpwj()
	{
		return null == null;
	}

	internal static object n9AjaF5boMRG46ICJT()
	{
		return null;
	}
}
