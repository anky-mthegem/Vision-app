using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using nbEpNqgj9oMmbCm0Ft;

namespace jUKn21pup6XFIrInBb;

internal class plfGltUiaC1OFfC2I8
{
	internal class MEN0AgLr76hg2w5MOk : Attribute
	{
		internal class v7EDOea55t9Db5dYOZ<HXnQyj9NFpNDkYkT6t>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public v7EDOea55t9Db5dYOZ()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool dCGWh2L6asUnC5aZx1T()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool kZICKRLDJV4l7rhjFDb()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[MEN0AgLr76hg2w5MOk(typeof(v7EDOea55t9Db5dYOZ<object>[]))]
		public MEN0AgLr76hg2w5MOk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hGN0QFL1G3FK9CoyOmG();
			hWCf7GLSdW4cxJw4lhH(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void hGN0QFL1G3FK9CoyOmG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void hWCf7GLSdW4cxJw4lhH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Attribute)P_0)._002Ector();
		}
	}

	internal class RdS108Hu6VPn7r9Cwa
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[MEN0AgLr76hg2w5MOk(typeof(MEN0AgLr76hg2w5MOk.v7EDOea55t9Db5dYOZ<object>[]))]
		internal static void ce4DmfsmSrOT856tDgfrkMb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if ((string)kGoN4oL5Asu7Uth5xdX(F5GrKsLdpisNtL4dkO5(bw6Q7JLs5uKMJPYmVlp(rUONfwlZ01.GetName())), OuEwE3LE0p1WL68JT68(8076)) != OIRNC4VQ7F(8082))
			{
				while (true)
				{
					ce4DmfsmSrOT856tDgfrkMb();
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[MEN0AgLr76hg2w5MOk(typeof(MEN0AgLr76hg2w5MOk.v7EDOea55t9Db5dYOZ<object>[]))]
		internal static string I5BGOKEQiU(string P_0, string P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			byte[] array = (byte[])SkOIgbLaewBQDn3BN6h(SH3VcvL31bMnvrU72kq(), P_0);
			byte[] array2 = array;
			byte[] array3 = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] iV = (byte[])aOY3HGLo76wnWCm9Ztw(SkOIgbLaewBQDn3BN6h(SH3VcvL31bMnvrU72kq(), P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = RvjNlxxgiE();
			ihDBrILcTE36UnTRHJ6(symmetricAlgorithm, array3);
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, (ICryptoTransform)pIjRKgLu5KtxOfxMMLY(symmetricAlgorithm), CryptoStreamMode.Write);
			cryptoStream.Write(array2, 0, array2.Length);
			lfC9seLBXdMPgARL3LX(cryptoStream);
			return (string)F5GrKsLdpisNtL4dkO5(memoryStream.ToArray());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RdS108Hu6VPn7r9Cwa()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			yGI6mHLxgJrCBZ6hqEk();
			zB6jQPLhYqgH5Bctj1e(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bw6Q7JLs5uKMJPYmVlp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AssemblyName)P_0).GetPublicKeyToken();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object F5GrKsLdpisNtL4dkO5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Convert.ToBase64String((byte[])P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OuEwE3LE0p1WL68JT68(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kGoN4oL5Asu7Uth5xdX(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return I5BGOKEQiU((string)P_0, (string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SH3VcvL31bMnvrU72kq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Encoding.Unicode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SkOIgbLaewBQDn3BN6h(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Encoding)P_0).GetBytes((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object aOY3HGLo76wnWCm9Ztw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return VinNeEGvtH((byte[])P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ihDBrILcTE36UnTRHJ6(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((SymmetricAlgorithm)P_0).Key = (byte[])P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pIjRKgLu5KtxOfxMMLY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SymmetricAlgorithm)P_0).CreateEncryptor();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void lfC9seLBXdMPgARL3LX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Stream)P_0).Close();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yGI6mHLxgJrCBZ6hqEk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void zB6jQPLhYqgH5Bctj1e(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint K5V8mbSEyEiHtK4OsR(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr rJ6lca0kVQsAjVCAGo();

	internal struct Ac8g2kCDZZxt5Od2h0
	{
		internal bool mUQGIo2X0A;

		internal byte[] liXG2QUkUy;
	}

	[Flags]
	private enum Ka1FOc7XrttDbKFtkb
	{

	}

	private static byte[] d4rNZMy2Ib;

	private static byte[] DpLNJjq66H;

	private static IntPtr Nd9Nc0Ucy0;

	private static IntPtr OZZNRiiHiD;

	private static bool thWNDthP8I;

	private static long FXDNqotg9E;

	private static int rVmNw7xe11;

	internal static Hashtable bhaNzAKSFu;

	internal static K5V8mbSEyEiHtK4OsR KpjNgTZrbc;

	private static object SuYNEOLVw2;

	private static bool RSNNAGk0IE;

	private static bool tXlNbdol9w;

	private static SortedList QqSNjgNBQS;

	private static bool XBNNsnkVFl;

	private static int ryIN1FhESh;

	private static Assembly rUONfwlZ01;

	[MEN0AgLr76hg2w5MOk(typeof(MEN0AgLr76hg2w5MOk.v7EDOea55t9Db5dYOZ<object>[]))]
	private static bool n5HNUsB9d2;

	private static int[] vvBN8ZhrTi;

	private static bool JEBN5FDdEg;

	private static int OAcNP4PdwX;

	private static byte[] GDxNFYgQKU;

	private static bool psRNyw2gd3;

	private static IntPtr GQGN43QFru;

	private static long MfDNk7turi;

	internal static K5V8mbSEyEiHtK4OsR RB9NXmLZa1;

	private static int VlHNQgkJaY;

	private static byte[] elUNucnuIF;

	private static uint[] vVbN990t7R;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static plfGltUiaC1OFfC2I8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		JEBN5FDdEg = false;
		rUONfwlZ01 = typeof(plfGltUiaC1OFfC2I8).Assembly;
		vVbN990t7R = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		RSNNAGk0IE = false;
		psRNyw2gd3 = false;
		elUNucnuIF = new byte[0];
		d4rNZMy2Ib = new byte[0];
		DpLNJjq66H = new byte[0];
		GDxNFYgQKU = new byte[0];
		Nd9Nc0Ucy0 = IntPtr.Zero;
		OZZNRiiHiD = IntPtr.Zero;
		SuYNEOLVw2 = new string[0];
		vvBN8ZhrTi = new int[0];
		ryIN1FhESh = 1;
		thWNDthP8I = false;
		QqSNjgNBQS = new SortedList();
		OAcNP4PdwX = 0;
		FXDNqotg9E = 0L;
		RB9NXmLZa1 = null;
		KpjNgTZrbc = null;
		MfDNk7turi = 0L;
		VlHNQgkJaY = 0;
		XBNNsnkVFl = false;
		tXlNbdol9w = false;
		rVmNw7xe11 = 0;
		GQGN43QFru = IntPtr.Zero;
		n5HNUsB9d2 = false;
		bhaNzAKSFu = new Hashtable();
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void P3U8dWLOKVMno()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] PIxNou3xry(byte[] P_0)
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
			XWbNaMH7OF(ref num7, num8, num9, num10, 0u, 7, 1u, array);
			XWbNaMH7OF(ref num10, num7, num8, num9, 1u, 12, 2u, array);
			XWbNaMH7OF(ref num9, num10, num7, num8, 2u, 17, 3u, array);
			XWbNaMH7OF(ref num8, num9, num10, num7, 3u, 22, 4u, array);
			XWbNaMH7OF(ref num7, num8, num9, num10, 4u, 7, 5u, array);
			XWbNaMH7OF(ref num10, num7, num8, num9, 5u, 12, 6u, array);
			XWbNaMH7OF(ref num9, num10, num7, num8, 6u, 17, 7u, array);
			XWbNaMH7OF(ref num8, num9, num10, num7, 7u, 22, 8u, array);
			XWbNaMH7OF(ref num7, num8, num9, num10, 8u, 7, 9u, array);
			XWbNaMH7OF(ref num10, num7, num8, num9, 9u, 12, 10u, array);
			XWbNaMH7OF(ref num9, num10, num7, num8, 10u, 17, 11u, array);
			XWbNaMH7OF(ref num8, num9, num10, num7, 11u, 22, 12u, array);
			XWbNaMH7OF(ref num7, num8, num9, num10, 12u, 7, 13u, array);
			XWbNaMH7OF(ref num10, num7, num8, num9, 13u, 12, 14u, array);
			XWbNaMH7OF(ref num9, num10, num7, num8, 14u, 17, 15u, array);
			XWbNaMH7OF(ref num8, num9, num10, num7, 15u, 22, 16u, array);
			g4NNV6gmsc(ref num7, num8, num9, num10, 1u, 5, 17u, array);
			g4NNV6gmsc(ref num10, num7, num8, num9, 6u, 9, 18u, array);
			g4NNV6gmsc(ref num9, num10, num7, num8, 11u, 14, 19u, array);
			g4NNV6gmsc(ref num8, num9, num10, num7, 0u, 20, 20u, array);
			g4NNV6gmsc(ref num7, num8, num9, num10, 5u, 5, 21u, array);
			g4NNV6gmsc(ref num10, num7, num8, num9, 10u, 9, 22u, array);
			g4NNV6gmsc(ref num9, num10, num7, num8, 15u, 14, 23u, array);
			g4NNV6gmsc(ref num8, num9, num10, num7, 4u, 20, 24u, array);
			g4NNV6gmsc(ref num7, num8, num9, num10, 9u, 5, 25u, array);
			g4NNV6gmsc(ref num10, num7, num8, num9, 14u, 9, 26u, array);
			g4NNV6gmsc(ref num9, num10, num7, num8, 3u, 14, 27u, array);
			g4NNV6gmsc(ref num8, num9, num10, num7, 8u, 20, 28u, array);
			g4NNV6gmsc(ref num7, num8, num9, num10, 13u, 5, 29u, array);
			g4NNV6gmsc(ref num10, num7, num8, num9, 2u, 9, 30u, array);
			g4NNV6gmsc(ref num9, num10, num7, num8, 7u, 14, 31u, array);
			g4NNV6gmsc(ref num8, num9, num10, num7, 12u, 20, 32u, array);
			zN0NNY9e9l(ref num7, num8, num9, num10, 5u, 4, 33u, array);
			zN0NNY9e9l(ref num10, num7, num8, num9, 8u, 11, 34u, array);
			zN0NNY9e9l(ref num9, num10, num7, num8, 11u, 16, 35u, array);
			zN0NNY9e9l(ref num8, num9, num10, num7, 14u, 23, 36u, array);
			zN0NNY9e9l(ref num7, num8, num9, num10, 1u, 4, 37u, array);
			zN0NNY9e9l(ref num10, num7, num8, num9, 4u, 11, 38u, array);
			zN0NNY9e9l(ref num9, num10, num7, num8, 7u, 16, 39u, array);
			zN0NNY9e9l(ref num8, num9, num10, num7, 10u, 23, 40u, array);
			zN0NNY9e9l(ref num7, num8, num9, num10, 13u, 4, 41u, array);
			zN0NNY9e9l(ref num10, num7, num8, num9, 0u, 11, 42u, array);
			zN0NNY9e9l(ref num9, num10, num7, num8, 3u, 16, 43u, array);
			zN0NNY9e9l(ref num8, num9, num10, num7, 6u, 23, 44u, array);
			zN0NNY9e9l(ref num7, num8, num9, num10, 9u, 4, 45u, array);
			zN0NNY9e9l(ref num10, num7, num8, num9, 12u, 11, 46u, array);
			zN0NNY9e9l(ref num9, num10, num7, num8, 15u, 16, 47u, array);
			zN0NNY9e9l(ref num8, num9, num10, num7, 2u, 23, 48u, array);
			pICNG6MpDB(ref num7, num8, num9, num10, 0u, 6, 49u, array);
			pICNG6MpDB(ref num10, num7, num8, num9, 7u, 10, 50u, array);
			pICNG6MpDB(ref num9, num10, num7, num8, 14u, 15, 51u, array);
			pICNG6MpDB(ref num8, num9, num10, num7, 5u, 21, 52u, array);
			pICNG6MpDB(ref num7, num8, num9, num10, 12u, 6, 53u, array);
			pICNG6MpDB(ref num10, num7, num8, num9, 3u, 10, 54u, array);
			pICNG6MpDB(ref num9, num10, num7, num8, 10u, 15, 55u, array);
			pICNG6MpDB(ref num8, num9, num10, num7, 1u, 21, 56u, array);
			pICNG6MpDB(ref num7, num8, num9, num10, 8u, 6, 57u, array);
			pICNG6MpDB(ref num10, num7, num8, num9, 15u, 10, 58u, array);
			pICNG6MpDB(ref num9, num10, num7, num8, 6u, 15, 59u, array);
			pICNG6MpDB(ref num8, num9, num10, num7, 13u, 21, 60u, array);
			pICNG6MpDB(ref num7, num8, num9, num10, 4u, 6, 61u, array);
			pICNG6MpDB(ref num10, num7, num8, num9, 11u, 10, 62u, array);
			pICNG6MpDB(ref num9, num10, num7, num8, 2u, 15, 63u, array);
			pICNG6MpDB(ref num8, num9, num10, num7, 9u, 21, 64u, array);
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
	private static void XWbNaMH7OF(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0 = P_1 + xRtNhp7ang(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + vVbN990t7R[P_6 - 1], P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void g4NNV6gmsc(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0 = P_1 + xRtNhp7ang(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + vVbN990t7R[P_6 - 1], P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void zN0NNY9e9l(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0 = P_1 + xRtNhp7ang(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + vVbN990t7R[P_6 - 1], P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void pICNG6MpDB(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0 = P_1 + xRtNhp7ang(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + vVbN990t7R[P_6 - 1], P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint xRtNhp7ang(uint P_0, ushort P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zHPNTJ33lp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!RSNNAGk0IE)
		{
			xN6NBscoKq();
			RSNNAGk0IE = true;
		}
		return psRNyw2gd3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SymmetricAlgorithm RvjNlxxgiE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (zHPNTJ33lp())
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
	internal static void xN6NBscoKq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			psRNyw2gd3 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] VinNeEGvtH(byte[] P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!zHPNTJ33lp())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return PIxNou3xry(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint MB3N3APSbh(uint P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[MEN0AgLr76hg2w5MOk(typeof(MEN0AgLr76hg2w5MOk.v7EDOea55t9Db5dYOZ<object>[]))]
	internal static string OIRNC4VQ7F(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 423;
		int num6 = default;
		byte[] array = default;
		byte[] array3 = default;
		int num5 = default;
		byte[] array4 = default;
		uint num23 = default;
		int num24 = default;
		byte[] array7 = default;
		int num8 = default;
		int num9 = default;
		int num26 = default;
		byte[] array5 = default;
		BinaryReader binaryReader = default;
		MemoryStream memoryStream = default;
		int num25 = default;
		int num4 = default;
		int num31 = default;
		byte[] array6 = default;
		uint num34 = default;
		uint num29 = default;
		int num30 = default;
		uint num35 = default;
		uint num32 = default;
		uint num11 = default;
		uint num27 = default;
		ICryptoTransform transform = default;
		SymmetricAlgorithm symmetricAlgorithm = default;
		byte[] array2 = default;
		CryptoStream cryptoStream = default;
		int num28 = default;
		uint num22 = default;
		int num33 = default;
		int num36 = default;
		int num7 = default;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IL_2227:
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 232:
						break;
					case 165:
						goto IL_0034;
					case 15:
						num6 = 146 - 116;
						num3 = 212;
						continue;
					case 142:
						goto IL_0066;
					case 181:
						goto IL_007e;
					case 45:
						goto IL_00a1;
					case 70:
						num6 = 0 + 98;
						num3 = 50;
						continue;
					case 341:
						num6 = 127 + 43;
						num3 = 293;
						continue;
					case 50:
						array[25] = (byte)num6;
						num3 = 194;
						continue;
					case 52:
					case 350:
						goto IL_0119;
					case 125:
						array[1] = (byte)num6;
						num2 = 148;
						goto IL_2227;
					case 43:
						goto IL_0148;
					case 263:
						array[21] = 49;
						num2 = 0;
						goto IL_2227;
					case 395:
						array3[12] = 106;
						num2 = 8;
						goto IL_2227;
					case 378:
						goto IL_01ad;
					case 272:
						array3[0] = (byte)num5;
						num3 = 361;
						continue;
					case 67:
						array4 = array3;
						num3 = 320;
						continue;
					case 169:
						goto IL_01f4;
					case 219:
						num23 = 0u;
						num3 = 170;
						continue;
					case 167:
						num6 = 248 - 82;
						num3 = 267;
						continue;
					case 185:
						array[21] = 145;
						num2 = 168;
						if (true)
						{
							goto IL_2227;
						}
						goto case 178;
					case 178:
						num24 = array7.Length / 4;
						num = 4;
						goto end_IL_222b;
					case 288:
						num6 = 47 + 103;
						num = 139;
						goto end_IL_222b;
					case 196:
						array[16] = 97;
						num2 = 60;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 92;
					case 58:
						num6 = 171 - 57;
						num = 46;
						goto end_IL_222b;
					case 88:
						num8 = num9 * 4;
						num = 259;
						goto end_IL_222b;
					case 168:
						array[21] = 101;
						num2 = 104;
						if (f3rHkd90j4hwFuB28K())
						{
							goto IL_2227;
						}
						goto case 182;
					case 197:
						array[31] = (byte)num6;
						num = 42;
						goto end_IL_222b;
					case 116:
						num26 = 0;
						num = 138;
						goto end_IL_222b;
					case 252:
						num6 = 75 - 27;
						num = 243;
						goto end_IL_222b;
					case 390:
						array3[2] = 234;
						num = 246;
						goto end_IL_222b;
					case 211:
						array4[5] = array5[2];
						num3 = 19;
						continue;
					case 241:
						array[17] = (byte)num6;
						num = 284;
						goto end_IL_222b;
					case 183:
						array[16] = (byte)num6;
						num2 = 49;
						if (0 == 0)
						{
							goto IL_2227;
						}
						goto case 361;
					case 361:
						num5 = 7 + 41;
						num2 = 429;
						if (true)
						{
							goto IL_2227;
						}
						goto case 12;
					case 12:
						array[4] = 123;
						num = 269;
						goto end_IL_222b;
					case 114:
						array[29] = (byte)num6;
						num2 = 377;
						goto IL_2227;
					case 5:
						num6 = 102 + 63;
						num2 = 23;
						goto IL_2227;
					case 108:
						array[2] = 55;
						num2 = 118;
						if (true)
						{
							goto IL_2227;
						}
						goto case 46;
					case 46:
						array[20] = (byte)num6;
						num = 171;
						goto end_IL_222b;
					case 160:
						array3[3] = 3;
						num2 = 407;
						if (f3rHkd90j4hwFuB28K())
						{
							goto IL_2227;
						}
						goto case 401;
					case 401:
						num6 = 67 + 40;
						num3 = 69;
						continue;
					case 35:
						X7CrDwJKyQ1Y2cHaQ5(EFkNb4qulQyGsUn1Qb(binaryReader), 0L);
						num = 200;
						goto end_IL_222b;
					case 151:
						array[18] = (byte)num6;
						num3 = 5;
						continue;
					case 140:
						DpLNJjq66H = (byte[])mNlTOTYtF2bKqwtLwJ(memoryStream);
						num = 28;
						goto end_IL_222b;
					case 321:
						num6 = 181 - 60;
						num2 = 122;
						goto IL_2227;
					case 203:
						array[27] = (byte)num6;
						num3 = 401;
						continue;
					case 278:
						if (num25 > 0)
						{
							num = 348;
							goto end_IL_222b;
						}
						goto case 63;
					case 385:
						array[19] = (byte)num6;
						num3 = 190;
						continue;
					case 92:
						array3[11] = (byte)num5;
						num3 = 347;
						continue;
					case 206:
						num4 = 127 - 42;
						num3 = 392;
						continue;
					case 9:
						array[18] = (byte)num6;
						num2 = 387;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 412;
					case 78:
						array3[15] = 106;
						num = 409;
						goto end_IL_222b;
					case 22:
						num31++;
						num3 = 17;
						continue;
					case 16:
						num6 = 90 - 61;
						num2 = 203;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto IL_0119;
					case 422:
						array[8] = (byte)num6;
						num = 338;
						goto end_IL_222b;
					case 36:
						num6 = 190 - 63;
						num2 = 114;
						goto IL_2227;
					case 379:
						array[8] = (byte)num6;
						num2 = 416;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 249;
					case 98:
						array[15] = (byte)num6;
						num2 = 76;
						goto IL_2227;
					case 337:
						num6 = 160 - 53;
						num2 = 393;
						if (0 == 0)
						{
							goto IL_2227;
						}
						goto case 110;
					case 110:
						array6[num8 + num26] = (byte)((num34 & num29) >> num30);
						num = 24;
						goto end_IL_222b;
					case 209:
						if (array5.Length > 0)
						{
							num2 = 227;
							if (!tVNtNnkpAIVa1EGsa2())
							{
								goto IL_2227;
							}
							goto case 147;
						}
						goto case 198;
					case 340:
						array[1] = (byte)num6;
						num3 = 45;
						continue;
					case 115:
						array[17] = (byte)num6;
						num2 = 165;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 404;
					case 404:
						array[5] = 118;
						num3 = 30;
						continue;
					case 213:
						array[13] = (byte)num6;
						num2 = 316;
						goto IL_2227;
					case 121:
						array[9] = 162;
						num = 179;
						goto end_IL_222b;
					case 105:
						array[5] = 104;
						num2 = 177;
						if (f3rHkd90j4hwFuB28K())
						{
							goto IL_2227;
						}
						goto case 374;
					case 264:
						num6 = 196 - 65;
						num2 = 428;
						if (0 == 0)
						{
							goto IL_2227;
						}
						goto case 304;
					case 304:
						num35 |= array7[array7.Length - (1 + num31)];
						num2 = 22;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 2;
					case 268:
						array3[6] = 187;
						num = 33;
						goto end_IL_222b;
					case 159:
						num6 = 193 - 81;
						num2 = 213;
						goto IL_2227;
					case 380:
						num6 = 223 - 74;
						num = 327;
						goto end_IL_222b;
					case 387:
						array[18] = 97;
						num = 354;
						goto end_IL_222b;
					case 33:
						num4 = 15 + 66;
						num2 = 143;
						goto IL_2227;
					case 217:
						array3[8] = (byte)num5;
						num2 = 31;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 117;
					case 117:
						num6 = 29 + 32;
						num = 102;
						goto end_IL_222b;
					case 147:
						array[21] = 113;
						num3 = 185;
						continue;
					case 279:
						array[10] = (byte)num6;
						num3 = 112;
						continue;
					case 408:
						num25 = array7.Length % 4;
						num = 178;
						goto end_IL_222b;
					case 344:
						array[16] = (byte)num6;
						num = 62;
						goto end_IL_222b;
					case 322:
						DpLNJjq66H = array6;
						num2 = 11;
						goto IL_2227;
					case 251:
						array3[10] = (byte)num4;
						num = 155;
						goto end_IL_222b;
					case 73:
						array[11] = 148;
						num2 = 248;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 171;
					case 171:
						num6 = 206 - 93;
						num3 = 258;
						continue;
					case 149:
						array3[12] = (byte)num5;
						num = 395;
						goto end_IL_222b;
					case 245:
					case 250:
						array3[0] = (byte)num5;
						num = 43;
						goto end_IL_222b;
					case 372:
						array[29] = (byte)num6;
						num2 = 36;
						if (f3rHkd90j4hwFuB28K())
						{
							goto IL_2227;
						}
						goto case 294;
					case 294:
						num35 = (uint)((array7[num32 + 3] << 24) | (array7[num32 + 2] << 16) | (array7[num32 + 1] << 8) | array7[num32]);
						num3 = 199;
						continue;
					case 10:
						num6 = 155 + 44;
						num3 = 285;
						continue;
					case 258:
						array[20] = (byte)num6;
						num = 263;
						goto end_IL_222b;
					case 96:
						num6 = 159 - 53;
						num2 = 394;
						if (true)
						{
							goto IL_2227;
						}
						goto case 405;
					case 405:
						num6 = 54 + 68;
						num2 = 319;
						if (f3rHkd90j4hwFuB28K())
						{
							goto IL_2227;
						}
						goto case 225;
					case 225:
						num23 = num11;
						num2 = 274;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 299;
					case 86:
						array3[11] = 142;
						num2 = 206;
						if (true)
						{
							goto IL_2227;
						}
						goto case 246;
					case 246:
						num4 = 1 + 65;
						num2 = 32;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 76;
					case 122:
						array[13] = (byte)num6;
						num3 = 27;
						continue;
					case 373:
						num32 = (uint)num8;
						num2 = 294;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 186;
					case 186:
						array[5] = 125;
						num2 = 299;
						goto IL_2227;
					case 184:
						num6 = 157 - 52;
						num = 296;
						goto end_IL_222b;
					case 195:
						array3[3] = (byte)num4;
						num = 160;
						goto end_IL_222b;
					case 93:
						array[31] = 24;
						num2 = 113;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 371;
					case 17:
					case 207:
						if (num31 >= num25)
						{
							num3 = 216;
							continue;
						}
						if (num31 > 0)
						{
							num = 415;
							goto end_IL_222b;
						}
						goto case 304;
					case 338:
						array[8] = 124;
						num2 = 291;
						goto IL_2227;
					case 333:
						array[30] = 239;
						num2 = 152;
						if (f3rHkd90j4hwFuB28K())
						{
							goto IL_2227;
						}
						goto case 418;
					case 81:
						array3[15] = (byte)num4;
						num2 = 67;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 425;
					case 327:
						array[14] = (byte)num6;
						num2 = 330;
						if (0 == 0)
						{
							goto IL_2227;
						}
						goto case 90;
					case 90:
						num6 = 151 - 50;
						num3 = 183;
						continue;
					case 356:
						array[29] = 70;
						num2 = 1;
						goto IL_2227;
					case 75:
						array[23] = 87;
						num = 253;
						goto end_IL_222b;
					case 309:
						array[26] = (byte)num6;
						num2 = 146;
						if (true)
						{
							goto IL_2227;
						}
						goto case 335;
					case 335:
						array[6] = (byte)num6;
						num2 = 355;
						if (true)
						{
							goto IL_2227;
						}
						goto case 62;
					case 62:
						array[17] = 120;
						num = 189;
						goto end_IL_222b;
					case 316:
						num6 = 185 - 61;
						num3 = 61;
						continue;
					case 359:
						array3[15] = 170;
						num3 = 351;
						continue;
					case 29:
						array3[2] = (byte)num4;
						num = 411;
						goto end_IL_222b;
					case 47:
						array7 = DpLNJjq66H;
						num2 = 408;
						if (true)
						{
							goto IL_2227;
						}
						goto case 412;
					case 412:
						array3[7] = (byte)num5;
						num2 = 164;
						if (0 == 0)
						{
							goto IL_2227;
						}
						goto case 300;
					case 300:
						num29 <<= 8;
						num = 34;
						goto end_IL_222b;
					case 189:
						num6 = 247 - 82;
						num2 = 241;
						goto IL_2227;
					case 283:
						array3[4] = (byte)num5;
						num2 = 406;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 205;
					case 192:
						array[25] = 34;
						num = 70;
						goto end_IL_222b;
					case 256:
						array[15] = (byte)num6;
						num3 = 153;
						continue;
					case 170:
						num27 = 0u;
						num3 = 313;
						continue;
					case 4:
						array6 = new byte[array7.Length];
						num3 = 132;
						continue;
					case 126:
						array[6] = (byte)num6;
						num = 173;
						goto end_IL_222b;
					case 175:
						num4 = 131 - 75;
						num2 = 364;
						goto IL_2227;
					case 317:
						array[24] = 142;
						num3 = 424;
						continue;
					case 220:
						transform = (ICryptoTransform)c7PquqiwuZXeufmTa1(symmetricAlgorithm, array2, array4);
						num2 = 84;
						goto IL_2227;
					case 112:
						array[10] = 118;
						num2 = 341;
						if (true)
						{
							goto IL_2227;
						}
						goto case 42;
					case 42:
						num6 = 102 + 36;
						num2 = 384;
						if (0 == 0)
						{
							goto IL_2227;
						}
						goto case 239;
					case 239:
						array[4] = (byte)num6;
						num2 = 167;
						if (true)
						{
							goto IL_2227;
						}
						goto case 334;
					case 334:
						array[12] = 120;
						num3 = 328;
						continue;
					case 255:
						array[3] = 155;
						num3 = 331;
						continue;
					case 292:
						num6 = 147 - 49;
						num3 = 119;
						continue;
					case 291:
						num6 = 131 + 34;
						num2 = 379;
						if (f3rHkd90j4hwFuB28K())
						{
							goto IL_2227;
						}
						goto case 234;
					case 273:
						array3[12] = 136;
						num = 262;
						goto end_IL_222b;
					case 336:
						array[13] = (byte)num6;
						num = 389;
						goto end_IL_222b;
					case 24:
						num26++;
						num2 = 57;
						if (f3rHkd90j4hwFuB28K())
						{
							goto IL_2227;
						}
						goto case 148;
					case 353:
						array[13] = 220;
						num2 = 159;
						goto IL_2227;
					case 419:
						array[20] = 160;
						num = 58;
						goto end_IL_222b;
					case 120:
						num6 = 102 + 18;
						num2 = 286;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 145;
					case 375:
						array[1] = (byte)num6;
						num2 = 398;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 299;
					case 85:
						array3[2] = (byte)num4;
						num2 = 390;
						if (true)
						{
							goto IL_2227;
						}
						goto case 413;
					case 413:
						array[26] = (byte)num6;
						num = 280;
						goto end_IL_222b;
					case 190:
						array[19] = 138;
						num2 = 180;
						if (f3rHkd90j4hwFuB28K())
						{
							goto IL_2227;
						}
						goto case 49;
					case 244:
						array3[1] = (byte)num5;
						num3 = 277;
						continue;
					case 137:
						array[0] = 91;
						num2 = 205;
						if (0 == 0)
						{
							goto IL_2227;
						}
						goto case 218;
					case 218:
						array4[15] = array5[7];
						num2 = 198;
						if (0 == 0)
						{
							goto IL_2227;
						}
						goto case 65;
					case 65:
						array4[9] = array5[4];
						num2 = 240;
						goto IL_2227;
					case 200:
						array7 = (byte[])aOlpkX5UWD4ixwh6tv(binaryReader, (int)wE1Lu0UGuP67Kr0WE8(EFkNb4qulQyGsUn1Qb(binaryReader)));
						num2 = 169;
						goto IL_2227;
					case 141:
						num6 = 18 + 99;
						num3 = 9;
						continue;
					case 131:
						array3[9] = (byte)num4;
						num3 = 382;
						continue;
					case 53:
						num4 = 51 + 15;
						num2 = 131;
						if (f3rHkd90j4hwFuB28K())
						{
							goto IL_2227;
						}
						goto case 136;
					case 265:
						array[0] = (byte)num6;
						num2 = 282;
						if (true)
						{
							goto IL_2227;
						}
						goto case 2;
					case 2:
						array3[1] = (byte)num5;
						num = 182;
						goto end_IL_222b;
					case 323:
						num6 = 211 - 70;
						num3 = 297;
						continue;
					case 423:
						if (DpLNJjq66H.Length == 0)
						{
							num2 = 111;
							if (!tVNtNnkpAIVa1EGsa2())
							{
								goto IL_2227;
							}
							goto case 260;
						}
						goto case 11;
					case 260:
						array[10] = (byte)num6;
						num3 = 172;
						continue;
					case 25:
						num35 = 0u;
						num2 = 204;
						goto IL_2227;
					case 136:
						num6 = 186 - 62;
						num3 = 385;
						continue;
					case 287:
						array[24] = (byte)num6;
						num3 = 192;
						continue;
					case 72:
						array[22] = 162;
						num3 = 247;
						continue;
					case 312:
						num5 = 185 - 61;
						num = 272;
						goto end_IL_222b;
					case 201:
						num6 = 174 - 58;
						num3 = 279;
						continue;
					case 51:
						array[17] = (byte)num6;
						num3 = 230;
						continue;
					case 82:
						cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
						num2 = 91;
						goto IL_2227;
					case 313:
						num35 = 0u;
						num = 278;
						goto end_IL_222b;
					case 60:
						num6 = 87 + 111;
						num2 = 344;
						goto IL_2227;
					case 38:
						array3[1] = (byte)num4;
						num = 26;
						goto end_IL_222b;
					case 55:
						array[10] = 108;
						num = 74;
						goto end_IL_222b;
					case 8:
						array3[13] = 135;
						num2 = 236;
						if (f3rHkd90j4hwFuB28K())
						{
							goto IL_2227;
						}
						goto case 172;
					case 172:
						array[10] = 104;
						num = 201;
						goto end_IL_222b;
					case 154:
						array[12] = 117;
						num3 = 15;
						continue;
					case 416:
						num6 = 250 - 83;
						num3 = 87;
						continue;
					case 417:
						array[11] = (byte)num6;
						num3 = 334;
						continue;
					case 420:
						array[4] = 99;
						num2 = 187;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 429;
					case 429:
						array3[0] = (byte)num5;
						num3 = 368;
						continue;
					case 106:
						num27 = (uint)((array2[num32 + 3] << 24) | (array2[num32 + 2] << 16) | (array2[num32 + 1] << 8) | array2[num32]);
						num3 = 238;
						continue;
					case 324:
						array3[14] = 38;
						num2 = 388;
						goto IL_2227;
					case 74:
						num6 = 135 - 45;
						num2 = 260;
						if (true)
						{
							goto IL_2227;
						}
						goto case 107;
					case 107:
						num6 = 155 - 51;
						num2 = 129;
						goto IL_2227;
					case 298:
						num4 = 77 + 54;
						num3 = 195;
						continue;
					case 303:
						array[4] = (byte)num6;
						num2 = 404;
						goto IL_2227;
					case 89:
						array3 = new byte[16];
						num3 = 66;
						continue;
					case 119:
						array[27] = (byte)num6;
						num = 184;
						goto end_IL_222b;
					case 166:
						num4 = 108 + 120;
						num3 = 403;
						continue;
					case 221:
					case 396:
						if (num28 >= array4.Length)
						{
							num2 = 97;
							if (0 == 0)
							{
								goto IL_2227;
							}
							goto case 148;
						}
						array2[num28] ^= array4[num28];
						num = 318;
						goto end_IL_222b;
					case 148:
						array[2] = 42;
						num2 = 374;
						if (true)
						{
							goto IL_2227;
						}
						goto case 54;
					case 54:
						num30 = 0;
						num3 = 305;
						continue;
					case 389:
						num6 = 117 + 111;
						num2 = 358;
						goto IL_2227;
					case 307:
						num23 = 0u;
						num2 = 308;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 122;
					case 261:
						num5 = 136 + 52;
						num2 = 92;
						goto IL_2227;
					case 226:
						num4 = 121 + 117;
						num = 193;
						goto end_IL_222b;
					case 415:
						num35 <<= 8;
						num2 = 304;
						if (true)
						{
							goto IL_2227;
						}
						goto case 330;
					case 330:
						num6 = 94 - 74;
						num2 = 371;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 68;
					case 59:
						array4[3] = array5[1];
						num3 = 211;
						continue;
					case 331:
						array[3] = 174;
						num3 = 420;
						continue;
					case 362:
						if (num25 > 0)
						{
							num2 = 191;
							if (true)
							{
								goto IL_2227;
							}
							goto case 30;
						}
						goto IL_211e;
					case 30:
						num6 = 33 + 98;
						num3 = 150;
						continue;
					case 124:
						num6 = 144 + 64;
						num = 417;
						goto end_IL_222b;
					case 194:
						num6 = 220 - 73;
						num3 = 210;
						continue;
					case 44:
						array3[6] = 147;
						num = 268;
						goto end_IL_222b;
					case 285:
						array[28] = (byte)num6;
						num = 117;
						goto end_IL_222b;
					case 346:
						array[20] = (byte)num6;
						num3 = 301;
						continue;
					case 425:
						array[30] = (byte)num6;
						num2 = 13;
						if (f3rHkd90j4hwFuB28K())
						{
							goto IL_2227;
						}
						goto case 35;
					case 343:
						array3[9] = 132;
						num2 = 181;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 92;
					case 123:
						array3[6] = 65;
						num2 = 44;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 44;
					case 14:
						xcEZXOahuqwpsnaXGs(symmetricAlgorithm, CipherMode.CBC);
						num = 220;
						goto end_IL_222b;
					case 249:
						array[22] = (byte)num6;
						num = 427;
						goto end_IL_222b;
					case 145:
						num6 = 131 - 43;
						num2 = 422;
						if (true)
						{
							goto IL_2227;
						}
						goto case 48;
					case 48:
						array3[4] = (byte)num5;
						num2 = 329;
						goto IL_2227;
					case 314:
						array[30] = 148;
						num3 = 163;
						continue;
					case 290:
						array5 = (byte[])mt5FM82A0bbB0memb0(FNyVM7OCnln7LBkfEV(rUONfwlZ01));
						num2 = 3;
						if (true)
						{
							goto IL_2227;
						}
						goto case 135;
					case 135:
						array[22] = (byte)num6;
						num2 = 162;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 364;
					case 191:
						num34 = num23 ^ num35;
						num2 = 116;
						goto IL_2227;
					case 77:
						array[31] = 123;
						num2 = 93;
						if (f3rHkd90j4hwFuB28K())
						{
							goto IL_2227;
						}
						goto case 87;
					case 87:
						array[9] = (byte)num6;
						num2 = 121;
						goto IL_2227;
					case 179:
						array[9] = 94;
						num3 = 289;
						continue;
					case 130:
						array3[9] = 101;
						num = 161;
						goto end_IL_222b;
					case 391:
						array3[3] = (byte)num4;
						num2 = 378;
						if (0 == 0)
						{
							goto IL_2227;
						}
						goto case 367;
					case 367:
						array6[num8 + 2] = (byte)((num22 & 0xFF0000) >> 16);
						num = 215;
						goto end_IL_222b;
					case 383:
						array[3] = (byte)num6;
						num2 = 255;
						goto IL_2227;
					case 210:
						array[25] = (byte)num6;
						num = 365;
						goto end_IL_222b;
					case 386:
						array[15] = (byte)num6;
						num3 = 90;
						continue;
					case 161:
						num4 = 164 - 54;
						num = 242;
						goto end_IL_222b;
					case 242:
						array3[10] = (byte)num4;
						num2 = 7;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 124;
					case 259:
						num32 = (uint)(num33 * 4);
						num = 106;
						goto end_IL_222b;
					case 428:
						array[1] = (byte)num6;
						num2 = 208;
						goto IL_2227;
					case 230:
						num6 = 81 - 27;
						num2 = 115;
						goto IL_2227;
					case 215:
						array6[num8 + 3] = (byte)((num22 & 0xFF000000u) >> 24);
						num2 = 235;
						goto IL_2227;
					case 414:
						array3[7] = (byte)num4;
						num2 = 233;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 253;
					case 253:
						num6 = 219 - 73;
						num = 142;
						goto end_IL_222b;
					case 275:
						num5 = 145 - 48;
						num2 = 271;
						if (0 == 0)
						{
							goto IL_2227;
						}
						goto case 155;
					case 155:
						array3[10] = 161;
						num3 = 86;
						continue;
					case 91:
						H78d3WclZabCyiMDy2(cryptoStream, array7, 0, array7.Length);
						num = 228;
						goto end_IL_222b;
					case 68:
						array[11] = (byte)num6;
						num2 = 73;
						if (true)
						{
							goto IL_2227;
						}
						goto case 164;
					case 164:
						array3[7] = 127;
						num2 = 99;
						goto IL_2227;
					case 69:
						array[28] = (byte)num6;
						num2 = 107;
						if (0 == 0)
						{
							goto IL_2227;
						}
						goto case 41;
					case 41:
						num6 = 209 - 69;
						num2 = 126;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 407;
					case 76:
						num6 = 143 + 62;
						num2 = 386;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 125;
					case 426:
						array[28] = 218;
						num3 = 10;
						continue;
					case 403:
						array3[13] = (byte)num4;
						num = 363;
						goto end_IL_222b;
					case 329:
						array3[5] = 101;
						num3 = 226;
						continue;
					case 374:
						num6 = 60 + 86;
						num = 101;
						goto end_IL_222b;
					case 150:
						array[5] = (byte)num6;
						num2 = 105;
						if (0 == 0)
						{
							goto IL_2227;
						}
						goto case 61;
					case 61:
						array[14] = (byte)num6;
						num = 380;
						goto end_IL_222b;
					case 63:
						num32 = 0u;
						num2 = 229;
						if (f3rHkd90j4hwFuB28K())
						{
							goto IL_2227;
						}
						goto case 398;
					case 398:
						num6 = 31 + 79;
						num = 340;
						goto end_IL_222b;
					case 347:
						array3[12] = 73;
						num = 376;
						goto end_IL_222b;
					case 267:
						array[4] = (byte)num6;
						num2 = 12;
						if (0 == 0)
						{
							goto IL_2227;
						}
						goto case 118;
					case 118:
						array[2] = 100;
						num2 = 326;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 139;
					case 139:
						array[31] = (byte)num6;
						num3 = 77;
						continue;
					case 222:
						num31 = 0;
						num2 = 207;
						if (f3rHkd90j4hwFuB28K())
						{
							goto IL_2227;
						}
						goto case 348;
					case 348:
						num24++;
						num3 = 63;
						continue;
					case 153:
						num6 = 132 - 44;
						num3 = 98;
						continue;
					case 270:
						num6 = 97 + 56;
						num3 = 256;
						continue;
					case 11:
						num36 = NBnG4dNRyLtToZebGh(DpLNJjq66H, P_0);
						num = 430;
						goto end_IL_222b;
					case 295:
						array[29] = 160;
						num = 356;
						goto end_IL_222b;
					case 99:
						num5 = 93 + 3;
						num3 = 217;
						continue;
					case 176:
						array[27] = (byte)num6;
						num3 = 292;
						continue;
					case 305:
						if (num9 == num24 - 1)
						{
							num3 = 202;
							continue;
						}
						goto IL_115c;
					case 23:
						array[18] = (byte)num6;
						num = 141;
						goto end_IL_222b;
					case 34:
						num30 += 8;
						num2 = 110;
						goto IL_2227;
					case 163:
						array[30] = 119;
						num3 = 174;
						continue;
					case 243:
						array[7] = (byte)num6;
						num3 = 418;
						continue;
					case 21:
						num4 = 237 - 79;
						num2 = 391;
						goto IL_2227;
					case 101:
						array[2] = (byte)num6;
						num2 = 108;
						goto IL_2227;
					case 411:
						num4 = 228 - 76;
						num = 85;
						goto end_IL_222b;
					case 286:
						array[15] = (byte)num6;
						num = 270;
						goto end_IL_222b;
					case 18:
						array3[14] = (byte)num4;
						num2 = 71;
						goto IL_2227;
					case 212:
						array[12] = (byte)num6;
						num3 = 321;
						continue;
					case 238:
						num29 = 255u;
						num2 = 54;
						goto IL_2227;
					case 311:
						array3[8] = (byte)num5;
						num3 = 175;
						continue;
					case 156:
						num6 = 190 - 63;
						num2 = 51;
						if (0 == 0)
						{
							goto IL_2227;
						}
						goto case 376;
					case 376:
						array3[12] = 100;
						num2 = 273;
						goto IL_2227;
					case 71:
						array3[14] = 126;
						num3 = 133;
						continue;
					case 188:
						array[20] = (byte)num6;
						num2 = 40;
						goto IL_2227;
					case 293:
						array[10] = (byte)num6;
						num2 = 366;
						goto IL_2227;
					case 180:
						array[19] = 77;
						num = 257;
						goto end_IL_222b;
					case 406:
						array3[4] = 113;
						num2 = 224;
						goto IL_2227;
					case 83:
					case 315:
						array[11] = (byte)num6;
						num3 = 20;
						continue;
					case 20:
						num6 = 220 - 73;
						num2 = 68;
						if (true)
						{
							goto IL_2227;
						}
						goto case 352;
					case 352:
						num4 = 15 + 106;
						num3 = 251;
						continue;
					case 240:
						array4[11] = array5[5];
						num2 = 306;
						goto IL_2227;
					case 318:
						num28++;
						num3 = 396;
						continue;
					case 371:
						array[14] = (byte)num6;
						num2 = 39;
						if (true)
						{
							goto IL_2227;
						}
						goto case 111;
					case 111:
						binaryReader = new BinaryReader((Stream)vYrfldQfbbZg2nI40g(rUONfwlZ01, "0Z47m9VhuOXPhnNtlL.Rfl5TKC9ii3UwSdsYZ"));
						num = 35;
						goto end_IL_222b;
					case 80:
						array[20] = (byte)num6;
						num2 = 419;
						goto IL_2227;
					case 237:
						array3[10] = (byte)num5;
						num3 = 349;
						continue;
					case 377:
						array[29] = 227;
						num3 = 397;
						continue;
					case 133:
						array3[14] = 212;
						num2 = 276;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 397;
					case 358:
						array[13] = (byte)num6;
						num3 = 370;
						continue;
					case 204:
						num23 += num27;
						num3 = 222;
						continue;
					case 158:
						num6 = 5 + 11;
						num = 188;
						goto end_IL_222b;
					case 289:
						array[9] = 119;
						num2 = 55;
						if (true)
						{
							goto IL_2227;
						}
						goto case 229;
					case 229:
						num9 = 0;
						num = 350;
						goto end_IL_222b;
					case 177:
						array[5] = 118;
						num2 = 186;
						goto IL_2227;
					case 57:
					case 138:
						if (num26 < num25)
						{
							if (num26 > 0)
							{
								num2 = 300;
								goto IL_2227;
							}
							goto case 110;
						}
						num2 = 325;
						if (0 == 0)
						{
							goto IL_2227;
						}
						goto case 224;
					case 224:
						num5 = 114 - 73;
						num2 = 48;
						if (true)
						{
							goto IL_2227;
						}
						goto case 227;
					case 227:
						array4[1] = array5[0];
						num2 = 59;
						if (0 == 0)
						{
							goto IL_2227;
						}
						goto case 26;
					case 26:
						num4 = 128 - 42;
						num2 = 29;
						if (f3rHkd90j4hwFuB28K())
						{
							goto IL_2227;
						}
						goto case 129;
					case 129:
						array[28] = (byte)num6;
						goto case 426;
					default:
						num = 426;
						goto end_IL_222b;
					case 79:
						array[26] = (byte)num6;
						num2 = 400;
						goto IL_2227;
					case 247:
						num6 = 168 - 56;
						num3 = 249;
						continue;
					case 202:
						if (num25 > 0)
						{
							num3 = 25;
							continue;
						}
						goto IL_115c;
					case 370:
						array[13] = 144;
						num2 = 353;
						goto IL_2227;
					case 234:
						array3[5] = (byte)num4;
						num = 275;
						goto end_IL_222b;
					case 6:
						array[5] = (byte)num6;
						num3 = 345;
						continue;
					case 248:
						array[11] = 94;
						num3 = 124;
						continue;
					case 424:
						array[24] = 167;
						num3 = 128;
						continue;
					case 365:
						array[25] = 99;
						num2 = 402;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 93;
					case 143:
						array3[7] = (byte)num4;
						num2 = 37;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 274;
					case 274:
						if (num9 == num24 - 1)
						{
							num2 = 362;
							goto IL_2227;
						}
						goto IL_211e;
					case 382:
						array3[9] = 124;
						num2 = 343;
						if (0 == 0)
						{
							goto IL_2227;
						}
						goto case 66;
					case 66:
						num5 = 109 + 51;
						goto case 245;
					case 144:
						array = new byte[32];
						num3 = 137;
						continue;
					case 280:
						num6 = 96 + 55;
						num = 176;
						goto end_IL_222b;
					case 233:
						num5 = 18 + 24;
						num = 412;
						goto end_IL_222b;
					case 262:
						num5 = 120 + 57;
						num3 = 149;
						continue;
					case 421:
						array[26] = 87;
						num3 = 157;
						continue;
					case 368:
						array3[0] = 91;
						num = 281;
						goto end_IL_222b;
					case 355:
						array[6] = 99;
						num3 = 214;
						continue;
					case 49:
						num6 = 118 + 6;
						num3 = 339;
						continue;
					case 319:
						array[7] = (byte)num6;
						num2 = 323;
						goto IL_2227;
					case 13:
						array[30] = 166;
						num3 = 314;
						continue;
					case 94:
						array6[num8 + 1] = (byte)((num22 & 0xFF00) >> 8);
						num2 = 367;
						if (true)
						{
							goto IL_2227;
						}
						goto case 357;
					case 357:
						array3[5] = 114;
						num3 = 254;
						continue;
					case 0:
						array[21] = 129;
						num2 = 147;
						goto IL_2227;
					case 257:
						array[19] = 117;
						num = 158;
						goto end_IL_222b;
					case 32:
						array3[3] = (byte)num4;
						num2 = 231;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 349;
					case 349:
						array3[10] = 102;
						num2 = 352;
						goto IL_2227;
					case 284:
						num6 = 252 - 84;
						num2 = 410;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 394;
					case 394:
						array[16] = (byte)num6;
						num2 = 196;
						if (true)
						{
							goto IL_2227;
						}
						goto case 208;
					case 208:
						num6 = 64 + 82;
						num2 = 125;
						if (f3rHkd90j4hwFuB28K())
						{
							goto IL_2227;
						}
						goto case 282;
					case 282:
						array[0] = 132;
						num = 381;
						goto end_IL_222b;
					case 269:
						array[4] = 54;
						num2 = 310;
						if (f3rHkd90j4hwFuB28K())
						{
							goto IL_2227;
						}
						goto case 141;
					case 381:
						num6 = 45 + 50;
						num3 = 375;
						continue;
					case 40:
						num6 = 68 + 96;
						num3 = 346;
						continue;
					case 31:
						num5 = 153 - 51;
						num = 134;
						goto end_IL_222b;
					case 1:
						num6 = 190 - 63;
						num2 = 372;
						goto IL_2227;
					case 254:
						num4 = 19 + 112;
						num3 = 234;
						continue;
					case 199:
					case 216:
						num11 = num23;
						num = 307;
						goto end_IL_222b;
					case 384:
						array[31] = (byte)num6;
						num3 = 288;
						continue;
					case 102:
						array[29] = (byte)num6;
						num2 = 295;
						if (f3rHkd90j4hwFuB28K())
						{
							goto IL_2227;
						}
						goto case 129;
					case 397:
						num6 = 137 - 45;
						num = 425;
						goto end_IL_222b;
					case 3:
						if (array5 != null)
						{
							num2 = 209;
							if (f3rHkd90j4hwFuB28K())
							{
								goto IL_2227;
							}
							goto case 228;
						}
						goto case 198;
					case 228:
						IUePPUtBB0MeyJxvnZ(cryptoStream);
						num2 = 140;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 127;
					case 113:
						array2 = array;
						num3 = 89;
						continue;
					case 128:
						num6 = 104 + 94;
						num = 287;
						goto end_IL_222b;
					case 410:
						array[17] = (byte)num6;
						num3 = 156;
						continue;
					case 134:
						array3[8] = (byte)num5;
						num2 = 56;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 152;
					case 152:
						num6 = 53 + 36;
						num3 = 197;
						continue;
					case 369:
						array[23] = 39;
						num = 127;
						goto end_IL_222b;
					case 393:
						array[6] = (byte)num6;
						num = 41;
						goto end_IL_222b;
					case 7:
						num5 = 211 - 70;
						num3 = 237;
						continue;
					case 320:
						S26uI4olpUq6NWKPjP(array4);
						num2 = 290;
						goto IL_2227;
					case 302:
						num6 = 58 + 124;
						num3 = 332;
						continue;
					case 297:
						array[7] = (byte)num6;
						num2 = 252;
						goto IL_2227;
					case 266:
						num6 = 93 + 24;
						num2 = 135;
						goto IL_2227;
					case 339:
						array[16] = (byte)num6;
						num2 = 96;
						goto IL_2227;
					case 236:
						array3[13] = 142;
						num = 103;
						goto end_IL_222b;
					case 19:
						array4[7] = array5[3];
						num = 65;
						goto end_IL_222b;
					case 281:
						num5 = 95 + 63;
						num = 244;
						goto end_IL_222b;
					case 95:
						array[1] = (byte)num6;
						num = 264;
						goto end_IL_222b;
					case 392:
						array3[11] = (byte)num4;
						num3 = 261;
						continue;
					case 173:
						num6 = 224 - 74;
						num2 = 335;
						if (f3rHkd90j4hwFuB28K())
						{
							goto IL_2227;
						}
						goto case 388;
					case 388:
						array3[15] = 124;
						num3 = 78;
						continue;
					case 399:
						array6[num8] = (byte)(num22 & 0xFF);
						num2 = 94;
						goto IL_2227;
					case 214:
						num6 = 60 + 100;
						num3 = 360;
						continue;
					case 308:
					{
						uint num10 = num11;
						uint num12 = num11;
						uint num13 = 630887075u;
						uint num14 = 1933418699u;
						uint num15 = 678167927u;
						uint num16 = 406861008u;
						uint num17 = num12;
						uint num18 = 1791887075u;
						ulong num19 = 2139439153 * num16;
						num19 |= 1;
						num13 = (uint)(num13 * num13 % num19);
						uint num20 = num14 & 0x55555555;
						uint num21 = num14 & 0xAAAAAAAAu;
						num20 = ((num20 >> 1) | (num21 << 1)) ^ num15;
						num14 = (num14 << 5) | (num14 >> 27);
						num14 = 3995151 * (num14 & 0x1FF) - (num14 >> 9);
						num13 = 3367361 * (num13 & 0x1FF) - (num13 >> 9);
						num13 = 67024 * num13 - num14;
						num14 = 937 * (num14 & 0xFFFFF) - (num14 >> 20);
						num13 = 3685 * (num13 & 0xFFFFF) - (num13 >> 20);
						num13 = 58222 * num13 + num14;
						num18 -= num13;
						num17 ^= num17 >> 3;
						num17 += num15;
						num17 ^= num17 >> 25;
						num17 += num16;
						num17 ^= num17 << 23;
						num17 += num18;
						num17 = (((num16 << 7) - num15) ^ num15) + num17;
						num11 = num10 + (uint)(double)num17;
						num = 225;
						goto end_IL_222b;
					}
					case 366:
						goto IL_322d;
					case 345:
						array[6] = 147;
						num2 = 337;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 119;
					case 342:
						array[18] = (byte)num6;
						num3 = 136;
						continue;
					case 235:
					case 325:
						num9++;
						num3 = 52;
						continue;
					case 427:
						array[22] = 94;
						num3 = 75;
						continue;
					case 231:
						array3[3] = 125;
						num3 = 21;
						continue;
					case 402:
						array[26] = 158;
						num3 = 100;
						continue;
					case 223:
						wZtRc542NkC6xwU6GB(cryptoStream);
						num = 47;
						goto end_IL_222b;
					case 146:
						num6 = 170 + 60;
						num2 = 413;
						goto IL_2227;
					case 193:
						array3[5] = (byte)num4;
						num3 = 357;
						continue;
					case 97:
						if (P_0 != -1)
						{
							goto case 408;
						}
						num2 = 109;
						if (f3rHkd90j4hwFuB28K())
						{
							goto IL_2227;
						}
						goto case 301;
					case 301:
						num6 = 16 + 104;
						num2 = 80;
						if (0 == 0)
						{
							goto IL_2227;
						}
						goto case 100;
					case 100:
						array[26] = 169;
						num2 = 421;
						goto IL_2227;
					case 28:
						wZtRc542NkC6xwU6GB(memoryStream);
						num2 = 223;
						if (0 == 0)
						{
							goto IL_2227;
						}
						goto case 332;
					case 332:
						array[22] = (byte)num6;
						num = 266;
						goto end_IL_222b;
					case 182:
						num4 = 138 + 74;
						num3 = 38;
						continue;
					case 39:
						array[15] = 162;
						num3 = 120;
						continue;
					case 27:
						num6 = 59 + 56;
						num2 = 336;
						if (f3rHkd90j4hwFuB28K())
						{
							goto IL_2227;
						}
						goto case 272;
					case 64:
						array[21] = (byte)num6;
						num = 302;
						goto end_IL_222b;
					case 310:
						num6 = 139 + 39;
						num2 = 303;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 326;
					case 326:
						num6 = 139 - 46;
						num3 = 383;
						continue;
					case 418:
						array[8] = 68;
						num = 145;
						goto end_IL_222b;
					case 364:
						array3[8] = (byte)num4;
						num = 53;
						goto end_IL_222b;
					case 37:
						num4 = 170 - 56;
						num3 = 414;
						continue;
					case 103:
						array3[13] = 108;
						num2 = 166;
						goto IL_2227;
					case 354:
						num6 = 192 + 19;
						num2 = 342;
						if (true)
						{
							goto IL_2227;
						}
						goto case 407;
					case 407:
						num5 = 167 - 55;
						num2 = 283;
						if (0 == 0)
						{
							goto IL_2227;
						}
						goto case 400;
					case 400:
						num6 = 141 - 47;
						num2 = 309;
						if (f3rHkd90j4hwFuB28K())
						{
							goto IL_2227;
						}
						goto case 271;
					case 271:
						array3[6] = (byte)num5;
						num = 123;
						goto end_IL_222b;
					case 306:
						array4[13] = array5[6];
						num2 = 218;
						if (f3rHkd90j4hwFuB28K())
						{
							goto IL_2227;
						}
						goto case 56;
					case 56:
						num5 = 73 + 1;
						num = 311;
						goto end_IL_222b;
					case 360:
						array[7] = (byte)num6;
						num3 = 405;
						continue;
					case 276:
						array3[14] = 92;
						num3 = 324;
						continue;
					case 127:
						array[24] = 170;
						num2 = 317;
						goto IL_2227;
					case 351:
						num4 = 152 - 33;
						num2 = 81;
						if (0 == 0)
						{
							goto IL_2227;
						}
						goto case 409;
					case 409:
						num5 = 70 + 44;
						num = 232;
						goto end_IL_222b;
					case 328:
						array[12] = 159;
						num3 = 154;
						continue;
					case 104:
						num6 = 112 - 6;
						num3 = 64;
						continue;
					case 174:
						array[30] = 129;
						num = 333;
						goto end_IL_222b;
					case 162:
						array[22] = 121;
						num2 = 72;
						if (true)
						{
							goto IL_2227;
						}
						goto case 299;
					case 299:
						num6 = 110 - 65;
						num3 = 6;
						continue;
					case 132:
						num7 = array2.Length / 4;
						num = 219;
						goto end_IL_222b;
					case 296:
						array[27] = (byte)num6;
						num3 = 16;
						continue;
					case 157:
						num6 = 58 + 103;
						num2 = 79;
						goto IL_2227;
					case 198:
						num28 = 0;
						num2 = 221;
						if (!tVNtNnkpAIVa1EGsa2())
						{
							goto IL_2227;
						}
						goto case 187;
					case 187:
						num6 = 5 + 92;
						num = 239;
						goto end_IL_222b;
					case 277:
						num5 = 164 - 54;
						num = 2;
						goto end_IL_222b;
					case 363:
						num4 = 21 + 92;
						num = 18;
						goto end_IL_222b;
					case 205:
						num6 = 208 - 69;
						num2 = 265;
						if (0 == 0)
						{
							goto IL_2227;
						}
						goto case 430;
					case 430:
						try
						{
							return (string)dZ6tw0WYmHfR4fTvQK(mFmE44wDKJkArLa4kf(), DpLNJjq66H, P_0 + 4, num36);
						}
						catch
						{
						}
						return "";
					case 84:
						memoryStream = new MemoryStream();
						num3 = 82;
						continue;
					case 109:
						{
							symmetricAlgorithm = (SymmetricAlgorithm)U6jAu8CFfgBJ06gOjm();
							num = 14;
							goto end_IL_222b;
						}
						IL_115c:
						num23 += num27;
						num2 = 373;
						if (f3rHkd90j4hwFuB28K())
						{
							goto IL_2227;
						}
						goto case 141;
						IL_211e:
						num22 = num23 ^ num35;
						num3 = 399;
						continue;
					}
					array3[15] = (byte)num5;
					num2 = 359;
					goto IL_2227;
					IL_322d:
					num6 = 113 + 122;
					_ = 0;
					if (!f3rHkd90j4hwFuB28K())
					{
						num2 = 250;
						goto IL_2227;
					}
					num3 = 315;
					continue;
					IL_007e:
					array3[9] = 128;
					num2 = 130;
					goto IL_2227;
					IL_0066:
					array[23] = (byte)num6;
					num = 369;
					break;
					IL_01f4:
					KsD8WXRJp70dC5y8lU(binaryReader);
					num = 144;
					break;
					IL_01ad:
					array3[3] = 100;
					num = 298;
					break;
					IL_0148:
					array3[0] = 17;
					num = 312;
					break;
					IL_0119:
					if (num9 >= num24)
					{
						num3 = 322;
						continue;
					}
					num33 = num9 % num7;
					num = 88;
					break;
					IL_0034:
					num6 = 78 + 107;
					num = 151;
					break;
					IL_00a1:
					num6 = 174 - 58;
					num2 = 95;
					goto IL_2227;
					continue;
					end_IL_222b:
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[MEN0AgLr76hg2w5MOk(typeof(MEN0AgLr76hg2w5MOk.v7EDOea55t9Db5dYOZ<object>[]))]
	internal static string LPeNr7XwFj(string P_0)
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
	private static int abZNi89j0X()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return 5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void NxdN6YkWga()
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
	private static Delegate lYdNnRjQlO(IntPtr P_0, Type P_1)
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
	internal static object JhrNH4inb3(object P_0)
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
	[MEN0AgLr76hg2w5MOk(typeof(MEN0AgLr76hg2w5MOk.v7EDOea55t9Db5dYOZ<object>[]))]
	private static byte[] qdsNpsrWyd(string P_0)
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
	[MEN0AgLr76hg2w5MOk(typeof(MEN0AgLr76hg2w5MOk.v7EDOea55t9Db5dYOZ<object>[]))]
	private static byte[] I85NWTMkiZ(byte[] P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MemoryStream memoryStream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = RvjNlxxgiE();
		symmetricAlgorithm.Key = new byte[32]
		{
			106, 171, 113, 45, 14, 89, 183, 66, 205, 236,
			45, 184, 206, 15, 15, 121, 248, 46, 103, 106,
			43, 120, 131, 232, 176, 5, 11, 163, 51, 147,
			75, 181
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			119, 105, 56, 178, 223, 207, 79, 114, 239, 80,
			68, 140, 174, 2, 162, 126
		};
		CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] UD2NStQTAH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] tCqNKXexjS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] zv9Nmw4X83()
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
	private byte[] ztRNMn6e4x()
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
	private byte[] ebIN7dCcVi()
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
	private byte[] LZDNYER99g()
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
	internal byte[] ar0N0KUUCo()
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
	internal byte[] HvnNvDG4vY()
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
	internal byte[] YegNLxm4yd()
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
	internal byte[] FeANdjORmi()
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
	public plfGltUiaC1OFfC2I8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vYrfldQfbbZg2nI40g(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EFkNb4qulQyGsUn1Qb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BinaryReader)P_0).BaseStream;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void X7CrDwJKyQ1Y2cHaQ5(object P_0, long P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Position = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long wE1Lu0UGuP67Kr0WE8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Stream)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aOlpkX5UWD4ixwh6tv(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BinaryReader)P_0).ReadBytes(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KsD8WXRJp70dC5y8lU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BinaryReader)P_0).Close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void S26uI4olpUq6NWKPjP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Array.Reverse((Array)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FNyVM7OCnln7LBkfEV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Assembly)P_0).GetName();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mt5FM82A0bbB0memb0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object U6jAu8CFfgBJ06gOjm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return RvjNlxxgiE();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xcEZXOahuqwpsnaXGs(object P_0, CipherMode P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object c7PquqiwuZXeufmTa1(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void H78d3WclZabCyiMDy2(object P_0, object P_1, int P_2, int P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IUePPUtBB0MeyJxvnZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CryptoStream)P_0).FlushFinalBlock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mNlTOTYtF2bKqwtLwJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MemoryStream)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wZtRc542NkC6xwU6GB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int NBnG4dNRyLtToZebGh(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return BitConverter.ToInt32((byte[])P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mFmE44wDKJkArLa4kf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Encoding.Unicode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dZ6tw0WYmHfR4fTvQK(object P_0, object P_1, int P_2, int P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Encoding)P_0).GetString((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool f3rHkd90j4hwFuB28K()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tVNtNnkpAIVa1EGsa2()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
