using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using GHWKpuG7rE0PZAeeF5;

namespace AkHicK0bA1TrKhYAY7;

internal class M8HpnnnUdjcJPbDHVy
{
	internal class dTfHZF3rIe1ujwmUyK : Attribute
	{
		internal class PFJ9ZwTjAxEfOIqArI<YcJNDyI0N3xfBgKEgW>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public PFJ9ZwTjAxEfOIqArI()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				KB0d0xocsRSAORFNZ9.RtXkSdpzVJ2P6();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool WdfFMqesxWd4D6v2osU()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool LONNxYegOM8dPSrx54b()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[dTfHZF3rIe1ujwmUyK(typeof(PFJ9ZwTjAxEfOIqArI<object>[]))]
		public dTfHZF3rIe1ujwmUyK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			YSlKgdewsNX8yLTDCey();
			fMMl3Oebku4ZKtStfo0(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void YSlKgdewsNX8yLTDCey()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KB0d0xocsRSAORFNZ9.RtXkSdpzVJ2P6();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fMMl3Oebku4ZKtStfo0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Attribute)P_0)._002Ector();
		}
	}

	internal class dZiR5feIZA22vtRsqd
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[dTfHZF3rIe1ujwmUyK(typeof(dTfHZF3rIe1ujwmUyK.PFJ9ZwTjAxEfOIqArI<object>[]))]
		internal static void ce4DmfsmSrOT856tDgfrkMb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if ((string)tS8TTArrDnLYaWKAbde(Convert.ToBase64String((byte[])mNeCjcrKYgK1RQWT4Gg(U5j9kvr429rCrA1smrx(cwOgTofe9p))), qX2SXoreMDXAUL5wD25(492)) != (string)qX2SXoreMDXAUL5wD25(498))
			{
				while (true)
				{
					Oo6XcFrl79wIj1fIcb9();
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[dTfHZF3rIe1ujwmUyK(typeof(dTfHZF3rIe1ujwmUyK.PFJ9ZwTjAxEfOIqArI<object>[]))]
		internal static string Ln1gjyvu11(string P_0, string P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			byte[] array = (byte[])sWgwyxrYPSON7X2AfCh(NwpmWtrSl4Xrtq1pj1r(), P_0);
			byte[] array2 = array;
			byte[] key = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] iV = (byte[])XZtkFArpX1yAsfbJhK0(Encoding.Unicode.GetBytes(P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = RO4tN72xvB();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, (ICryptoTransform)lgdR0NroUu6wgvy69Qe(symmetricAlgorithm), CryptoStreamMode.Write);
			hTesNVrO3dXkAmlCQfH(cryptoStream, array2, 0, array2.Length);
			Hym8g7raZaP28Ip2sYH(cryptoStream);
			return (string)RnstVFrjZNTKnuOeQ9f(jrSSBHrCFip2HrmsexQ(memoryStream));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public dZiR5feIZA22vtRsqd()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zAnYrGrtw8vB1bZpUBI();
			u1c3OhrHCoSjXaINPmC(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object U5j9kvr429rCrA1smrx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Assembly)P_0).GetName();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mNeCjcrKYgK1RQWT4Gg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AssemblyName)P_0).GetPublicKeyToken();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qX2SXoreMDXAUL5wD25(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hDZtYXyjFS(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tS8TTArrDnLYaWKAbde(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Ln1gjyvu11((string)P_0, (string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Oo6XcFrl79wIj1fIcb9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ce4DmfsmSrOT856tDgfrkMb();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object NwpmWtrSl4Xrtq1pj1r()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Encoding.Unicode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object sWgwyxrYPSON7X2AfCh(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Encoding)P_0).GetBytes((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XZtkFArpX1yAsfbJhK0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DgBtaAbklu((byte[])P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lgdR0NroUu6wgvy69Qe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SymmetricAlgorithm)P_0).CreateEncryptor();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void hTesNVrO3dXkAmlCQfH(object P_0, object P_1, int P_2, int P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Stream)P_0).Write((byte[])P_1, P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Hym8g7raZaP28Ip2sYH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Stream)P_0).Close();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jrSSBHrCFip2HrmsexQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((MemoryStream)P_0).ToArray();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RnstVFrjZNTKnuOeQ9f(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Convert.ToBase64String((byte[])P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void zAnYrGrtw8vB1bZpUBI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KB0d0xocsRSAORFNZ9.RtXkSdpzVJ2P6();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void u1c3OhrHCoSjXaINPmC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint UiD1ItLs90ZSIHRadE(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr XktFCdHhMiIkSedu9C();

	internal struct egROInfyR9YNSOIh60
	{
		internal bool aVPgnlQ5Nj;

		internal byte[] c7WgG82qYE;
	}

	[Flags]
	private enum cVJktDQAIbHKxkSP8G
	{

	}

	private static bool TmFgvOLbGd;

	private static Assembly cwOgTofe9p;

	private static bool nLxgPVqSRE;

	private static bool Eo6gCN3b29;

	private static byte[] RBsgROKGDZ;

	private static IntPtr IyngDI0BVY;

	private static object WwAgBcfIo4;

	private static int jo9gmAGhwJ;

	private static bool yW1g3BEhIr;

	private static SortedList p3ggZFM242;

	internal static UiD1ItLs90ZSIHRadE dQjgQ79ZMV;

	private static IntPtr N0jg5nMLVQ;

	internal static Hashtable N0Pgod3The;

	private static byte[] k4bg1NhX8k;

	private static int okEg4gyHO2;

	private static byte[] eYJgyfBsYI;

	private static byte[] Cv8g2HQDlo;

	private static uint[] ON6gEkJRhD;

	private static long sHggIxMUsO;

	private static int e2Ng0eQrr0;

	private static bool bOAgMMXv83;

	private static bool F9UglFF9TU;

	internal static UiD1ItLs90ZSIHRadE d78gAQLOOd;

	[dTfHZF3rIe1ujwmUyK(typeof(dTfHZF3rIe1ujwmUyK.PFJ9ZwTjAxEfOIqArI<object>[]))]
	private static bool Hn6gW1pJWF;

	private static IntPtr Fjmg97KdMO;

	private static long qubgsGKn0U;

	private static int AoKgH8rFeT;

	private static int[] AZ9gktoOP1;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static M8HpnnnUdjcJPbDHVy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		TmFgvOLbGd = false;
		cwOgTofe9p = typeof(M8HpnnnUdjcJPbDHVy).Assembly;
		ON6gEkJRhD = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		nLxgPVqSRE = false;
		Eo6gCN3b29 = false;
		Cv8g2HQDlo = new byte[0];
		eYJgyfBsYI = new byte[0];
		k4bg1NhX8k = new byte[0];
		RBsgROKGDZ = new byte[0];
		IyngDI0BVY = IntPtr.Zero;
		Fjmg97KdMO = IntPtr.Zero;
		WwAgBcfIo4 = new string[0];
		AZ9gktoOP1 = new int[0];
		jo9gmAGhwJ = 1;
		yW1g3BEhIr = false;
		p3ggZFM242 = new SortedList();
		AoKgH8rFeT = 0;
		sHggIxMUsO = 0L;
		dQjgQ79ZMV = null;
		d78gAQLOOd = null;
		qubgsGKn0U = 0L;
		okEg4gyHO2 = 0;
		F9UglFF9TU = false;
		bOAgMMXv83 = false;
		e2Ng0eQrr0 = 0;
		N0jg5nMLVQ = IntPtr.Zero;
		Hn6gW1pJWF = false;
		N0Pgod3The = new Hashtable();
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void hZAkSdp8D8HGF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] Il3tUMWZw5(byte[] P_0)
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
			gIJth5bclq(ref num7, num8, num9, num10, 0u, 7, 1u, array);
			gIJth5bclq(ref num10, num7, num8, num9, 1u, 12, 2u, array);
			gIJth5bclq(ref num9, num10, num7, num8, 2u, 17, 3u, array);
			gIJth5bclq(ref num8, num9, num10, num7, 3u, 22, 4u, array);
			gIJth5bclq(ref num7, num8, num9, num10, 4u, 7, 5u, array);
			gIJth5bclq(ref num10, num7, num8, num9, 5u, 12, 6u, array);
			gIJth5bclq(ref num9, num10, num7, num8, 6u, 17, 7u, array);
			gIJth5bclq(ref num8, num9, num10, num7, 7u, 22, 8u, array);
			gIJth5bclq(ref num7, num8, num9, num10, 8u, 7, 9u, array);
			gIJth5bclq(ref num10, num7, num8, num9, 9u, 12, 10u, array);
			gIJth5bclq(ref num9, num10, num7, num8, 10u, 17, 11u, array);
			gIJth5bclq(ref num8, num9, num10, num7, 11u, 22, 12u, array);
			gIJth5bclq(ref num7, num8, num9, num10, 12u, 7, 13u, array);
			gIJth5bclq(ref num10, num7, num8, num9, 13u, 12, 14u, array);
			gIJth5bclq(ref num9, num10, num7, num8, 14u, 17, 15u, array);
			gIJth5bclq(ref num8, num9, num10, num7, 15u, 22, 16u, array);
			gBAtOq4IfU(ref num7, num8, num9, num10, 1u, 5, 17u, array);
			gBAtOq4IfU(ref num10, num7, num8, num9, 6u, 9, 18u, array);
			gBAtOq4IfU(ref num9, num10, num7, num8, 11u, 14, 19u, array);
			gBAtOq4IfU(ref num8, num9, num10, num7, 0u, 20, 20u, array);
			gBAtOq4IfU(ref num7, num8, num9, num10, 5u, 5, 21u, array);
			gBAtOq4IfU(ref num10, num7, num8, num9, 10u, 9, 22u, array);
			gBAtOq4IfU(ref num9, num10, num7, num8, 15u, 14, 23u, array);
			gBAtOq4IfU(ref num8, num9, num10, num7, 4u, 20, 24u, array);
			gBAtOq4IfU(ref num7, num8, num9, num10, 9u, 5, 25u, array);
			gBAtOq4IfU(ref num10, num7, num8, num9, 14u, 9, 26u, array);
			gBAtOq4IfU(ref num9, num10, num7, num8, 3u, 14, 27u, array);
			gBAtOq4IfU(ref num8, num9, num10, num7, 8u, 20, 28u, array);
			gBAtOq4IfU(ref num7, num8, num9, num10, 13u, 5, 29u, array);
			gBAtOq4IfU(ref num10, num7, num8, num9, 2u, 9, 30u, array);
			gBAtOq4IfU(ref num9, num10, num7, num8, 7u, 14, 31u, array);
			gBAtOq4IfU(ref num8, num9, num10, num7, 12u, 20, 32u, array);
			Q2ptxqwYN5(ref num7, num8, num9, num10, 5u, 4, 33u, array);
			Q2ptxqwYN5(ref num10, num7, num8, num9, 8u, 11, 34u, array);
			Q2ptxqwYN5(ref num9, num10, num7, num8, 11u, 16, 35u, array);
			Q2ptxqwYN5(ref num8, num9, num10, num7, 14u, 23, 36u, array);
			Q2ptxqwYN5(ref num7, num8, num9, num10, 1u, 4, 37u, array);
			Q2ptxqwYN5(ref num10, num7, num8, num9, 4u, 11, 38u, array);
			Q2ptxqwYN5(ref num9, num10, num7, num8, 7u, 16, 39u, array);
			Q2ptxqwYN5(ref num8, num9, num10, num7, 10u, 23, 40u, array);
			Q2ptxqwYN5(ref num7, num8, num9, num10, 13u, 4, 41u, array);
			Q2ptxqwYN5(ref num10, num7, num8, num9, 0u, 11, 42u, array);
			Q2ptxqwYN5(ref num9, num10, num7, num8, 3u, 16, 43u, array);
			Q2ptxqwYN5(ref num8, num9, num10, num7, 6u, 23, 44u, array);
			Q2ptxqwYN5(ref num7, num8, num9, num10, 9u, 4, 45u, array);
			Q2ptxqwYN5(ref num10, num7, num8, num9, 12u, 11, 46u, array);
			Q2ptxqwYN5(ref num9, num10, num7, num8, 15u, 16, 47u, array);
			Q2ptxqwYN5(ref num8, num9, num10, num7, 2u, 23, 48u, array);
			gIrtfq63lw(ref num7, num8, num9, num10, 0u, 6, 49u, array);
			gIrtfq63lw(ref num10, num7, num8, num9, 7u, 10, 50u, array);
			gIrtfq63lw(ref num9, num10, num7, num8, 14u, 15, 51u, array);
			gIrtfq63lw(ref num8, num9, num10, num7, 5u, 21, 52u, array);
			gIrtfq63lw(ref num7, num8, num9, num10, 12u, 6, 53u, array);
			gIrtfq63lw(ref num10, num7, num8, num9, 3u, 10, 54u, array);
			gIrtfq63lw(ref num9, num10, num7, num8, 10u, 15, 55u, array);
			gIrtfq63lw(ref num8, num9, num10, num7, 1u, 21, 56u, array);
			gIrtfq63lw(ref num7, num8, num9, num10, 8u, 6, 57u, array);
			gIrtfq63lw(ref num10, num7, num8, num9, 15u, 10, 58u, array);
			gIrtfq63lw(ref num9, num10, num7, num8, 6u, 15, 59u, array);
			gIrtfq63lw(ref num8, num9, num10, num7, 13u, 21, 60u, array);
			gIrtfq63lw(ref num7, num8, num9, num10, 4u, 6, 61u, array);
			gIrtfq63lw(ref num10, num7, num8, num9, 11u, 10, 62u, array);
			gIrtfq63lw(ref num9, num10, num7, num8, 2u, 15, 63u, array);
			gIrtfq63lw(ref num8, num9, num10, num7, 9u, 21, 64u, array);
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
	private static void gIJth5bclq(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0 = P_1 + ng7tuIRDMg(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + ON6gEkJRhD[P_6 - 1], P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void gBAtOq4IfU(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0 = P_1 + ng7tuIRDMg(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + ON6gEkJRhD[P_6 - 1], P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void Q2ptxqwYN5(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0 = P_1 + ng7tuIRDMg(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + ON6gEkJRhD[P_6 - 1], P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void gIrtfq63lw(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0 = P_1 + ng7tuIRDMg(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + ON6gEkJRhD[P_6 - 1], P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint ng7tuIRDMg(uint P_0, ushort P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EVet7na00v()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!nLxgPVqSRE)
		{
			bdPtVDo3U1();
			nLxgPVqSRE = true;
		}
		return Eo6gCN3b29;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SymmetricAlgorithm RO4tN72xvB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (EVet7na00v())
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
	internal static void bdPtVDo3U1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			Eo6gCN3b29 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] DgBtaAbklu(byte[] P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!EVet7na00v())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return Il3tUMWZw5(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint CJctdSvFVn(uint P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[dTfHZF3rIe1ujwmUyK(typeof(dTfHZF3rIe1ujwmUyK.PFJ9ZwTjAxEfOIqArI<object>[]))]
	internal static string hDZtYXyjFS(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 394;
		byte[] array3 = default;
		byte[] array4 = default;
		int num7 = default;
		int num9 = default;
		int num5 = default;
		int num4 = default;
		byte[] array = default;
		byte[] array2 = default;
		uint num23 = default;
		int num8 = default;
		byte[] array7 = default;
		int num25 = default;
		uint num17 = default;
		int num3 = default;
		uint num14 = default;
		uint num11 = default;
		int num16 = default;
		byte[] array6 = default;
		BinaryReader binaryReader = default;
		uint num19 = default;
		uint num26 = default;
		uint num18 = default;
		int num21 = default;
		byte[] array5 = default;
		int num22 = default;
		MemoryStream memoryStream = default;
		CryptoStream cryptoStream = default;
		uint num24 = default;
		int num10 = default;
		int num15 = default;
		int num12 = default;
		int num13 = default;
		ICryptoTransform transform = default;
		int num20 = default;
		SymmetricAlgorithm symmetricAlgorithm = default;
		while (true)
		{
			int num6;
			int num2;
			switch (num)
			{
			case 170:
				array3[14] = 150;
				num6 = 84;
				if (1 == 0)
				{
					goto case 267;
				}
				goto IL_2e20;
			case 267:
				array4[2] = (byte)num7;
				num6 = 66;
				if (1 == 0)
				{
					goto case 115;
				}
				goto IL_2e20;
			case 115:
				array4[2] = (byte)num9;
				num6 = 284;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 302;
				}
				goto IL_2e20;
			case 302:
				num7 = 1 + 65;
				num6 = 245;
				goto IL_2e20;
			case 23:
				array4[17] = (byte)num7;
				num = 367;
				break;
			case 155:
				num7 = 209 + 3;
				num6 = 17;
				goto IL_2e20;
			case 404:
				array3[6] = (byte)num5;
				num6 = 307;
				goto IL_2e20;
			case 66:
				num7 = 210 + 10;
				num6 = 393;
				if (1 == 0)
				{
					goto case 67;
				}
				goto IL_2e20;
			case 67:
				array4[24] = 166;
				num = 308;
				break;
			case 72:
				array3[1] = 174;
				num2 = 4;
				goto IL_2e1c;
			case 113:
				if (num4 <= 0)
				{
					goto IL_00ed;
				}
				num2 = 359;
				goto IL_2e1c;
			case 19:
				array4[12] = (byte)num9;
				num6 = 184;
				goto IL_2e20;
			case 406:
				array4[15] = 143;
				num6 = 142;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 146;
				}
				goto IL_2e20;
			case 146:
				array[13] = array2[6];
				num6 = 333;
				if (false)
				{
					goto case 183;
				}
				goto IL_2e20;
			case 183:
				num7 = 61 + 30;
				num6 = 223;
				goto IL_2e20;
			case 311:
				num5 = 218 - 72;
				num6 = 404;
				if (s9vDKyYsR6mGCaK1D4())
				{
					goto case 2;
				}
				goto IL_2e20;
			case 2:
			{
				uint num27 = num23;
				uint num28 = num23;
				uint num29 = 881759538u;
				uint num30 = 397850148u;
				uint num31 = 1442226599u;
				uint num32 = 337739533u;
				uint num33 = num28;
				uint num34 = 67484771u;
				ulong num35 = 2139439153 * num32;
				num35 |= 1;
				num29 = (uint)(num29 * num29 % num35);
				uint num36 = num30 & 0x55555555;
				uint num37 = num30 & 0xAAAAAAAAu;
				num36 = ((num36 >> 1) | (num37 << 1)) ^ num31;
				num30 = (num30 << 5) | (num30 >> 27);
				num30 = 3995151 * (num30 & 0x1FF) - (num30 >> 9);
				num29 = 3367361 * (num29 & 0x1FF) - (num29 >> 9);
				num29 = 67024 * num29 - num30;
				num30 = 937 * (num30 & 0xFFFFF) - (num30 >> 20);
				num29 = 3685 * (num29 & 0xFFFFF) - (num29 >> 20);
				num29 = 58222 * num29 + num30;
				num34 -= num29;
				num33 ^= num33 >> 3;
				num33 += num31;
				num33 ^= num33 >> 25;
				num33 += num32;
				num33 ^= num33 << 23;
				num33 += num34;
				num33 = (((num32 << 7) - num31) ^ num31) + num33;
				num23 = num27 + (uint)(double)num33;
				num6 = 210;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 301;
				}
				goto IL_2e20;
			}
			case 296:
				num5 = 9 + 105;
				num2 = 330;
				goto IL_2e1c;
			case 301:
				if (num4 > 0)
				{
					num = 48;
					break;
				}
				goto IL_18fa;
			case 366:
				array4[16] = (byte)num7;
				num = 58;
				break;
			case 394:
				if (k4bg1NhX8k.Length == 0)
				{
					num = 215;
					break;
				}
				goto case 409;
			case 120:
				array4[18] = 168;
				num2 = 399;
				goto IL_2e1c;
			case 181:
				num7 = 132 - 44;
				num2 = 100;
				goto IL_2e1c;
			case 58:
				array4[16] = 94;
				num = 342;
				break;
			case 36:
			case 44:
				num7 = 205 - 68;
				num = 297;
				break;
			case 304:
				array4[9] = 154;
				num6 = 65;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 314;
				}
				goto IL_2e20;
			case 314:
				num8 = 127 - 9;
				num6 = 389;
				if (false)
				{
					goto case 380;
				}
				goto IL_2e20;
			case 380:
				array7[num25] = (byte)(num17 & 0xFF);
				num6 = 385;
				goto IL_2e20;
			case 382:
				array4[25] = (byte)num7;
				num = 341;
				break;
			case 409:
				num3 = yT2e2lZMsnrgmfQHJv(k4bg1NhX8k, P_0);
				num2 = 424;
				goto IL_2e1c;
			case 111:
				array4[7] = 192;
				num6 = 18;
				goto IL_2e20;
			case 114:
				num7 = 246 - 82;
				num2 = 374;
				goto IL_2e1c;
			case 163:
				num7 = 193 - 64;
				num6 = 256;
				if (false)
				{
					goto case 359;
				}
				goto IL_2e20;
			case 359:
				num14 = 0u;
				num2 = 90;
				goto IL_2e1c;
			case 297:
				array4[4] = (byte)num7;
				num = 241;
				break;
			case 219:
				array4[30] = (byte)num9;
				num = 289;
				break;
			case 300:
				array3[3] = 102;
				num2 = 337;
				goto IL_2e1c;
			case 93:
				num7 = 192 - 64;
				num2 = 137;
				goto IL_2e1c;
			case 203:
				array4[23] = (byte)num7;
				num = 233;
				break;
			case 396:
				num7 = 34 + 106;
				num6 = 407;
				if (false)
				{
					goto case 418;
				}
				goto IL_2e20;
			case 418:
				array4[0] = 135;
				num6 = 24;
				if (s9vDKyYsR6mGCaK1D4())
				{
					goto case 16;
				}
				goto IL_2e20;
			case 358:
				num7 = 253 - 84;
				num6 = 274;
				if (s9vDKyYsR6mGCaK1D4())
				{
					goto case 204;
				}
				goto IL_2e20;
			case 204:
				num9 = 115 - 11;
				num2 = 14;
				goto IL_2e1c;
			case 162:
				array4[7] = 115;
				num = 158;
				break;
			case 268:
				array4[9] = 144;
				num2 = 335;
				goto IL_2e1c;
			case 59:
				array4[20] = (byte)num9;
				num6 = 188;
				if (1 == 0)
				{
					goto case 45;
				}
				goto IL_2e20;
			case 45:
				num8 = 126 - 42;
				num = 346;
				break;
			case 139:
				num7 = 159 - 53;
				num6 = 50;
				goto IL_2e20;
			case 15:
				array3[3] = (byte)num5;
				num6 = 300;
				goto IL_2e20;
			case 337:
				num5 = 35 + 88;
				goto case 209;
			case 385:
				array7[num25 + 1] = (byte)((num17 & 0xFF00) >> 8);
				num2 = 248;
				goto IL_2e1c;
			case 242:
				array3[10] = (byte)num5;
				num6 = 169;
				if (s9vDKyYsR6mGCaK1D4())
				{
					goto case 333;
				}
				goto IL_2e20;
			case 6:
				num11 = 0u;
				num6 = 244;
				if (1 == 0)
				{
					goto case 222;
				}
				goto IL_2e20;
			case 222:
				array4[31] = (byte)num9;
				num6 = 88;
				goto IL_2e20;
			case 316:
				num25 = num16 * 4;
				num = 191;
				break;
			case 135:
				array4[10] = 150;
				num = 125;
				break;
			case 393:
				array4[2] = (byte)num7;
				num = 291;
				break;
			case 390:
				array4[0] = (byte)num9;
				num2 = 94;
				goto IL_2e1c;
			case 289:
				num7 = 221 - 73;
				num6 = 107;
				goto IL_2e20;
			case 80:
				num9 = 85 + 22;
				num6 = 395;
				if (s9vDKyYsR6mGCaK1D4())
				{
					goto case 120;
				}
				goto IL_2e20;
			case 328:
				array3[15] = 98;
				num6 = 392;
				goto IL_2e20;
			case 399:
				array4[18] = 95;
				num6 = 207;
				if (false)
				{
					goto case 284;
				}
				goto IL_2e20;
			case 284:
				num7 = 29 + 110;
				num = 267;
				break;
			case 173:
				array3[5] = (byte)num8;
				num = 121;
				break;
			case 416:
				num9 = 61 + 100;
				num6 = 98;
				if (false)
				{
					goto case 291;
				}
				goto IL_2e20;
			case 291:
				num9 = 151 - 50;
				num2 = 326;
				goto IL_2e1c;
			case 176:
				num7 = 126 - 42;
				num = 168;
				break;
			case 391:
				array4[9] = 0;
				num2 = 99;
				goto IL_2e1c;
			case 147:
				array3[5] = 104;
				num = 271;
				break;
			case 376:
				num9 = 3 + 65;
				num6 = 344;
				if (1 == 0)
				{
					goto case 422;
				}
				goto IL_2e20;
			case 422:
				array3[14] = (byte)num8;
				num6 = 185;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 239;
				}
				goto IL_2e20;
			case 239:
				array4[25] = 140;
				num = 172;
				break;
			case 4:
				num5 = 64 + 110;
				num = 128;
				break;
			case 65:
				num7 = 108 + 63;
				num2 = 270;
				goto IL_2e1c;
			case 20:
				array6 = (byte[])BTjUWDGjltfKonYGse(binaryReader, (int)C20moKmamsVOEGcG92(iD9joYRswXZ69FIfDg(binaryReader)));
				num = 138;
				break;
			case 156:
				array4[19] = 87;
				num6 = 43;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 403;
				}
				goto IL_2e20;
			case 403:
				num7 = 49 + 92;
				num2 = 145;
				goto IL_2e1c;
			case 271:
				array3[5] = 112;
				num = 322;
				break;
			case 5:
				array[5] = array2[2];
				num6 = 96;
				if (false)
				{
					goto case 312;
				}
				goto IL_2e20;
			case 312:
				num7 = 157 - 52;
				num6 = 275;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 165;
				}
				goto IL_2e20;
			case 165:
				array3[4] = 161;
				num6 = 240;
				if (s9vDKyYsR6mGCaK1D4())
				{
					goto case 246;
				}
				goto IL_2e20;
			case 246:
				array3[13] = 245;
				num6 = 243;
				if (false)
				{
					goto case 47;
				}
				goto IL_2e20;
			case 47:
				num7 = 206 - 68;
				num6 = 16;
				if (false)
				{
					goto case 287;
				}
				goto IL_2e20;
			case 287:
				array3[11] = 147;
				num6 = 46;
				if (false)
				{
					goto case 407;
				}
				goto IL_2e20;
			case 407:
				array4[17] = (byte)num7;
				num6 = 405;
				if (false)
				{
					goto case 338;
				}
				goto IL_2e20;
			case 338:
				num7 = 200 - 66;
				num6 = 366;
				goto IL_2e20;
			case 419:
				array4[24] = (byte)num9;
				num6 = 195;
				if (1 == 0)
				{
					goto case 307;
				}
				goto IL_2e20;
			case 307:
				array3[6] = 174;
				num = 314;
				break;
			case 31:
				array4[17] = 149;
				num2 = 396;
				goto IL_2e1c;
			case 119:
				array3[1] = 103;
				num2 = 295;
				goto IL_2e1c;
			case 122:
				array4[1] = 118;
				num6 = 157;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 371;
				}
				goto IL_2e20;
			case 371:
				array[3] = array2[1];
				num6 = 5;
				if (1 == 0)
				{
					goto case 238;
				}
				goto IL_2e20;
			case 238:
				array4[10] = (byte)num9;
				num = 205;
				break;
			case 8:
				array3[7] = (byte)num5;
				num6 = 323;
				if (false)
				{
					goto case 235;
				}
				goto IL_2e20;
			case 235:
				array3 = new byte[16];
				num = 91;
				break;
			case 63:
				array3[0] = 4;
				num2 = 72;
				goto IL_2e1c;
			case 402:
				array3[8] = 64;
				num2 = 202;
				goto IL_2e1c;
			case 357:
				array4[18] = (byte)num9;
				num6 = 120;
				if (s9vDKyYsR6mGCaK1D4())
				{
					goto case 251;
				}
				goto IL_2e20;
			case 274:
				array4[27] = (byte)num7;
				num6 = 349;
				if (1 == 0)
				{
					goto case 367;
				}
				goto IL_2e20;
			case 367:
				num7 = 231 - 77;
				num = 26;
				break;
			case 262:
				array4[4] = 144;
				num6 = 183;
				goto IL_2e20;
			case 248:
				array7[num25 + 2] = (byte)((num17 & 0xFF0000) >> 16);
				num = 54;
				break;
			case 255:
				num19 = 255u;
				num2 = 381;
				goto IL_2e1c;
			case 232:
				array4[8] = (byte)num7;
				num6 = 356;
				if (1 == 0)
				{
					goto case 48;
				}
				goto IL_2e20;
			case 48:
				num26 = num18 ^ num14;
				num2 = 254;
				goto IL_2e1c;
			case 160:
				array4[14] = 167;
				num = 352;
				break;
			case 82:
			case 167:
				if (num21 >= array.Length)
				{
					num2 = 277;
				}
				else
				{
					array5[num21] ^= array[num21];
					num2 = 32;
				}
				goto IL_2e1c;
			case 79:
				array4[23] = (byte)num9;
				num6 = 276;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 187;
				}
				goto IL_2e20;
			case 187:
			case 401:
				if (num22 < num4)
				{
					if (num22 <= 0)
					{
						goto case 25;
					}
					num2 = 140;
					goto IL_2e1c;
				}
				num = 305;
				break;
			case 110:
				array4[12] = (byte)num9;
				num6 = 231;
				if (1 == 0)
				{
					goto case 340;
				}
				goto IL_2e20;
			case 340:
				LMrsN7B9hj6x8q4AGF(memoryStream);
				num2 = 109;
				goto IL_2e1c;
			case 33:
				array4[5] = 143;
				num = 80;
				break;
			case 117:
				array3[8] = 145;
				num2 = 182;
				goto IL_2e1c;
			case 182:
				num5 = 230 - 76;
				num = 70;
				break;
			case 11:
				array4[19] = 111;
				num6 = 156;
				if (false)
				{
					goto case 350;
				}
				goto IL_2e20;
			case 350:
				array4[19] = (byte)num7;
				num6 = 114;
				goto IL_2e20;
			case 415:
				array6 = k4bg1NhX8k;
				num2 = 281;
				goto IL_2e1c;
			case 40:
				array4[9] = (byte)num7;
				num2 = 304;
				goto IL_2e1c;
			case 136:
				array3[5] = (byte)num8;
				num2 = 311;
				goto IL_2e1c;
			case 27:
				array4[28] = 75;
				num = 78;
				break;
			case 279:
				G3QtnbxWcSUoHoU1XV(cryptoStream);
				num = 355;
				break;
			case 81:
				num8 = 154 - 51;
				num = 92;
				break;
			case 205:
				num7 = 240 - 80;
				num6 = 211;
				if (false)
				{
					goto case 35;
				}
				goto IL_2e20;
			case 35:
				num9 = 186 - 62;
				num6 = 357;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 180;
				}
				goto IL_2e20;
			case 76:
				array4[18] = (byte)num9;
				num = 312;
				break;
			case 412:
				array4[4] = 157;
				num6 = 262;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 20;
				}
				goto IL_2e20;
			case 106:
				num18 = 0u;
				num6 = 306;
				goto IL_2e20;
			case 178:
				array4[13] = (byte)num7;
				num = 263;
				break;
			case 127:
				array3[0] = (byte)num5;
				num6 = 63;
				goto IL_2e20;
			case 92:
				array3[3] = (byte)num8;
				num6 = 226;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 55;
				}
				goto IL_2e20;
			case 55:
				array4[8] = 31;
				num2 = 93;
				goto IL_2e1c;
			case 234:
				array4[27] = (byte)num9;
				num6 = 358;
				if (1 == 0)
				{
					goto case 257;
				}
				goto IL_2e20;
			case 257:
				array4[1] = (byte)num7;
				num = 368;
				break;
			case 352:
				array4[14] = 114;
				num6 = 228;
				if (1 == 0)
				{
					goto case 229;
				}
				goto IL_2e20;
			case 229:
				array3[12] = 125;
				num6 = 332;
				goto IL_2e20;
			case 169:
				num5 = 42 + 57;
				num = 375;
				break;
			case 90:
				num18 += num24;
				num = 75;
				break;
			case 347:
				array4[5] = 114;
				num6 = 68;
				goto IL_2e20;
			case 230:
				num7 = 186 - 62;
				num2 = 212;
				goto IL_2e1c;
			case 7:
			case 38:
				if (num10 >= num4)
				{
					num6 = 200;
					if (!AThXyJDcSWb9jaOj8B())
					{
						goto case 208;
					}
					goto IL_2e20;
				}
				if (num10 <= 0)
				{
					goto case 89;
				}
				num2 = 373;
				goto IL_2e1c;
			case 208:
				array4[3] = 163;
				AThXyJDcSWb9jaOj8B();
				if (s9vDKyYsR6mGCaK1D4())
				{
					num2 = 209;
					goto IL_2e1c;
				}
				num = 44;
				break;
			case 283:
				num9 = 71 + 87;
				num2 = 189;
				goto IL_2e1c;
			case 54:
				array7[num25 + 3] = (byte)((num17 & 0xFF000000u) >> 24);
				num6 = 421;
				if (s9vDKyYsR6mGCaK1D4())
				{
					goto case 348;
				}
				goto IL_2e20;
			case 348:
				num8 = 18 + 117;
				num2 = 422;
				goto IL_2e1c;
			case 292:
				num22++;
				num6 = 187;
				if (1 == 0)
				{
					goto case 77;
				}
				goto IL_2e20;
			case 77:
				array3[5] = (byte)num8;
				num6 = 147;
				goto IL_2e20;
			case 413:
				array4[14] = (byte)num7;
				num2 = 160;
				goto IL_2e1c;
			case 91:
				array3[0] = 83;
				num = 329;
				break;
			case 125:
				num9 = 139 - 117;
				num6 = 238;
				goto IL_2e20;
			case 295:
				array3[1] = 151;
				num = 217;
				break;
			case 245:
				array4[21] = (byte)num7;
				num2 = 97;
				goto IL_2e1c;
			case 56:
				if (array2.Length > 0)
				{
					num = 285;
					break;
				}
				goto case 280;
			case 410:
				num7 = 52 - 11;
				num6 = 3;
				if (1 == 0)
				{
					goto case 57;
				}
				goto IL_2e20;
			case 57:
				array4[28] = (byte)num7;
				num6 = 343;
				goto IL_2e20;
			case 166:
				num18 = 0u;
				num2 = 2;
				goto IL_2e1c;
			case 395:
				array4[5] = (byte)num9;
				num2 = 174;
				goto IL_2e1c;
			case 327:
				num11 = (uint)num25;
				num6 = 420;
				if (s9vDKyYsR6mGCaK1D4())
				{
					goto case 275;
				}
				goto IL_2e20;
			case 275:
				array4[18] = (byte)num7;
				num6 = 35;
				if (s9vDKyYsR6mGCaK1D4())
				{
					goto case 369;
				}
				goto IL_2e20;
			case 369:
				array4[12] = 177;
				num2 = 163;
				goto IL_2e1c;
			case 141:
				array4[5] = (byte)num7;
				num6 = 69;
				if (s9vDKyYsR6mGCaK1D4())
				{
					goto case 67;
				}
				goto IL_2e20;
			case 237:
				array4[27] = (byte)num9;
				num2 = 334;
				goto IL_2e1c;
			case 389:
				array3[6] = (byte)num8;
				num = 294;
				break;
			case 368:
				array4[1] = 160;
				num6 = 122;
				if (1 == 0)
				{
					goto case 108;
				}
				goto IL_2e20;
			case 108:
				num9 = 205 - 68;
				num2 = 390;
				goto IL_2e1c;
			case 60:
				array4[13] = (byte)num9;
				num6 = 252;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 217;
				}
				goto IL_2e20;
			case 273:
				array3[4] = (byte)num5;
				num = 372;
				break;
			case 278:
				num7 = 96 - 0;
				num6 = 350;
				goto IL_2e20;
			case 303:
				array2 = (byte[])geAEnQuf8uL0mXj2yv(tsgrC4sQCo9sAZhKts(cwOgTofe9p));
				num2 = 164;
				goto IL_2e1c;
			case 153:
				num7 = 213 - 96;
				num6 = 42;
				if (false)
				{
					goto case 315;
				}
				goto IL_2e20;
			case 315:
				num8 = 244 - 81;
				num = 77;
				break;
			case 190:
				array4[27] = (byte)num7;
				num = 171;
				break;
			case 37:
				num24 = (uint)((array5[num11 + 3] << 24) | (array5[num11 + 2] << 16) | (array5[num11 + 1] << 8) | array5[num11]);
				num6 = 255;
				goto IL_2e20;
			case 370:
				array4[29] = 36;
				num6 = 251;
				goto IL_2e20;
			case 244:
				num16 = 0;
				num2 = 247;
				goto IL_2e1c;
			case 70:
				array3[8] = (byte)num5;
				num = 214;
				break;
			case 277:
				if (P_0 != -1)
				{
					goto case 281;
				}
				num6 = 194;
				goto IL_2e20;
			case 423:
				num8 = 157 + 61;
				num = 83;
				break;
			case 293:
				array3[9] = (byte)num5;
				num6 = 331;
				if (AThXyJDcSWb9jaOj8B())
				{
					goto IL_2e20;
				}
				goto case 194;
			case 16:
				array4[22] = (byte)num7;
				num6 = 216;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 330;
				}
				goto IL_2e20;
			case 330:
				array3[4] = (byte)num5;
				num2 = 165;
				goto IL_2e1c;
			case 318:
				array3[7] = (byte)num8;
				num6 = 397;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 105;
				}
				goto IL_2e20;
			case 105:
				num5 = 92 - 4;
				num2 = 313;
				goto IL_2e1c;
			case 353:
				num8 = 52 + 110;
				num2 = 319;
				goto IL_2e1c;
			case 362:
				array3[0] = 165;
				num = 201;
				break;
			case 132:
				num8 = 239 - 79;
				num2 = 116;
				goto IL_2e1c;
			case 130:
				array4[5] = (byte)num7;
				num6 = 33;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 179;
				}
				goto IL_2e20;
			case 215:
				binaryReader = new BinaryReader((Stream)qH8Jm7plUbZ19Q44Q7(cwOgTofe9p, "Ln6rZsUWubcV7JnOH3.SyJOrOA66MeDRaqMNT"));
				num = 186;
				break;
			case 365:
				array4[13] = (byte)num7;
				num2 = 180;
				goto IL_2e1c;
			case 281:
				num4 = array6.Length % 4;
				num2 = 192;
				goto IL_2e1c;
			case 349:
				array4[27] = 99;
				num6 = 378;
				if (1 == 0)
				{
					goto case 305;
				}
				goto IL_2e20;
			case 305:
			case 421:
				num16++;
				num6 = 71;
				goto IL_2e20;
			case 103:
				num9 = 56 + 60;
				num6 = 417;
				goto IL_2e20;
			case 420:
				num14 = (uint)((array6[num11 + 3] << 24) | (array6[num11 + 2] << 16) | (array6[num11 + 1] << 8) | array6[num11]);
				num6 = 152;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 154;
				}
				goto IL_2e20;
			case 154:
				array3[2] = 39;
				num = 81;
				break;
			case 100:
				array4[22] = (byte)num7;
				num6 = 131;
				goto IL_2e20;
			case 128:
				array3[1] = (byte)num5;
				num6 = 351;
				goto IL_2e20;
			case 71:
			case 247:
				if (num16 >= num15)
				{
					num2 = 133;
					goto IL_2e1c;
				}
				num12 = num16 % num13;
				num6 = 316;
				goto IL_2e20;
			case 320:
				num7 = 118 + 7;
				num = 365;
				break;
			case 306:
				num24 = 0u;
				num2 = 30;
				goto IL_2e1c;
			case 61:
				array4[12] = (byte)num7;
				num6 = 369;
				goto IL_2e20;
			case 282:
				num7 = 109 + 87;
				num2 = 57;
				goto IL_2e1c;
			case 309:
				array3[7] = (byte)num5;
				num6 = 298;
				goto IL_2e20;
			case 17:
				array4[22] = (byte)num7;
				num = 364;
				break;
			case 223:
				array4[4] = (byte)num7;
				num6 = 134;
				goto IL_2e20;
			case 26:
				array4[17] = (byte)num7;
				num = 31;
				break;
			case 159:
				num9 = 137 - 45;
				num6 = 196;
				if (s9vDKyYsR6mGCaK1D4())
				{
					goto case 334;
				}
				goto IL_2e20;
			case 334:
				num7 = 11 + 108;
				num6 = 190;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 378;
				}
				goto IL_2e20;
			case 386:
				array4[1] = (byte)num9;
				num = 21;
				break;
			case 228:
				num9 = 34 + 43;
				num2 = 321;
				goto IL_2e1c;
			case 161:
				num9 = 130 - 43;
				num6 = 237;
				if (1 == 0)
				{
					goto case 240;
				}
				goto IL_2e20;
			case 240:
				num5 = 112 + 85;
				num6 = 273;
				goto IL_2e20;
			case 186:
				lWD4nphNCbKZHY0NsK(iD9joYRswXZ69FIfDg(binaryReader), 0L);
				num6 = 20;
				if (false)
				{
					goto case 43;
				}
				goto IL_2e20;
			case 43:
				array4[19] = 130;
				num6 = 278;
				if (s9vDKyYsR6mGCaK1D4())
				{
					goto case 385;
				}
				goto IL_2e20;
			case 195:
				array4[25] = 162;
				num = 103;
				break;
			case 133:
				k4bg1NhX8k = array7;
				num = 409;
				break;
			case 64:
				array3[12] = (byte)num5;
				num6 = 34;
				if (false)
				{
					goto case 98;
				}
				goto IL_2e20;
			case 98:
				array4[0] = (byte)num9;
				num = 149;
				break;
			case 218:
				array3[0] = (byte)num5;
				num = 143;
				break;
			case 149:
				num9 = 108 + 120;
				num6 = 386;
				if (false)
				{
					goto case 388;
				}
				goto IL_2e20;
			case 388:
				array3[11] = 160;
				num2 = 287;
				goto IL_2e1c;
			case 193:
				num5 = 8 + 61;
				num6 = 8;
				if (1 == 0)
				{
					goto case 22;
				}
				goto IL_2e20;
			case 22:
				array4[26] = (byte)num9;
				num6 = 376;
				goto IL_2e20;
			case 210:
				num18 = num23;
				num6 = 345;
				if (s9vDKyYsR6mGCaK1D4())
				{
					goto case 346;
				}
				goto IL_2e20;
			case 53:
				array[9] = array2[4];
				num2 = 150;
				goto IL_2e1c;
			case 252:
				num9 = 4 + 69;
				num6 = 104;
				if (1 == 0)
				{
					goto case 217;
				}
				goto IL_2e20;
			case 217:
				array3[1] = 168;
				num2 = 336;
				goto IL_2e1c;
			case 49:
				cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				num6 = 225;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 402;
				}
				goto IL_2e20;
			case 199:
				num5 = 117 + 38;
				num = 293;
				break;
			case 41:
				array4[31] = 181;
				num6 = 288;
				if (s9vDKyYsR6mGCaK1D4())
				{
					goto case 115;
				}
				goto IL_2e20;
			case 400:
				array3[10] = 107;
				num2 = 105;
				goto IL_2e1c;
			case 231:
				array4[13] = 89;
				num = 320;
				break;
			case 24:
				num7 = 216 - 72;
				num2 = 112;
				goto IL_2e1c;
			case 197:
				array7 = new byte[array6.Length];
				num6 = 272;
				if (false)
				{
					goto case 12;
				}
				goto IL_2e20;
			case 12:
				num9 = 254 - 84;
				num = 219;
				break;
			case 326:
				array4[3] = (byte)num9;
				num = 236;
				break;
			case 411:
				if (num4 > 0)
				{
					num = 354;
					break;
				}
				goto case 6;
			case 280:
				num21 = 0;
				num2 = 82;
				goto IL_2e1c;
			case 96:
				array[7] = array2[3];
				num = 53;
				break;
			case 310:
				array4[24] = (byte)num9;
				num = 67;
				break;
			case 78:
				array4[29] = 82;
				num6 = 198;
				if (false)
				{
					goto case 414;
				}
				goto IL_2e20;
			case 414:
				num9 = 188 - 62;
				num = 290;
				break;
			case 299:
				array3[15] = (byte)num5;
				num2 = 328;
				goto IL_2e1c;
			case 188:
				num7 = 131 - 43;
				num6 = 249;
				if (1 == 0)
				{
					goto case 286;
				}
				goto IL_2e20;
			case 286:
				num8 = 140 + 45;
				num2 = 136;
				goto IL_2e1c;
			case 332:
				num5 = 161 - 53;
				num6 = 64;
				if (s9vDKyYsR6mGCaK1D4())
				{
					goto case 263;
				}
				goto IL_2e20;
			case 263:
				array4[14] = 98;
				num = 87;
				break;
			case 209:
			case 261:
				array3[3] = (byte)num5;
				num = 423;
				break;
			case 152:
			case 200:
				num23 = num18;
				num = 166;
				break;
			case 341:
				num9 = 50 + 8;
				num2 = 22;
				goto IL_2e1c;
			case 216:
				array4[22] = 179;
				num6 = 155;
				if (1 == 0)
				{
					goto case 88;
				}
				goto IL_2e20;
			case 88:
				array5 = array4;
				num2 = 235;
				goto IL_2e1c;
			case 28:
				array4[8] = 153;
				num = 148;
				break;
			case 172:
				num7 = 170 - 54;
				num6 = 382;
				goto IL_2e20;
			case 83:
				array3[3] = (byte)num8;
				num6 = 175;
				if (false)
				{
					goto case 189;
				}
				goto IL_2e20;
			case 189:
				array4[26] = (byte)num9;
				num6 = 161;
				goto IL_2e20;
			case 89:
				num14 |= array6[array6.Length - (1 + num10)];
				num = 269;
				break;
			case 346:
				array3[10] = (byte)num8;
				num2 = 101;
				goto IL_2e1c;
			case 227:
				array3[13] = 98;
				num6 = 246;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 131;
				}
				goto IL_2e20;
			case 131:
				array4[22] = 130;
				num2 = 47;
				goto IL_2e1c;
			case 213:
				array4[15] = (byte)num9;
				num = 204;
				break;
			case 134:
				array4[4] = 5;
				num2 = 347;
				goto IL_2e1c;
			case 129:
				array4[30] = 97;
				num6 = 123;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 241;
				}
				goto IL_2e20;
			case 241:
				array4[4] = 127;
				num6 = 412;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 270;
				}
				goto IL_2e20;
			case 270:
				array4[9] = (byte)num7;
				num6 = 391;
				goto IL_2e20;
			case 68:
				num7 = 222 - 74;
				num2 = 130;
				goto IL_2e1c;
			case 294:
				array3[7] = 163;
				num2 = 193;
				goto IL_2e1c;
			case 269:
				num10++;
				num = 38;
				break;
			case 124:
				array3[2] = 101;
				num6 = 353;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 258;
				}
				goto IL_2e20;
			case 258:
				num9 = 122 + 21;
				num2 = 110;
				goto IL_2e1c;
			case 361:
				array4[30] = 142;
				num = 153;
				break;
			case 243:
				array3[14] = 79;
				num = 348;
				break;
			case 325:
				array4[21] = 121;
				num2 = 302;
				goto IL_2e1c;
			case 377:
				array4[29] = 121;
				num6 = 370;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 95;
				}
				goto IL_2e20;
			case 408:
				num5 = 220 - 73;
				num6 = 299;
				goto IL_2e20;
			case 175:
				array3[4] = 116;
				num2 = 296;
				goto IL_2e1c;
			case 331:
				array3[9] = 87;
				num6 = 45;
				if (s9vDKyYsR6mGCaK1D4())
				{
					goto case 43;
				}
				goto IL_2e20;
			case 224:
				array3[12] = (byte)num8;
				num2 = 383;
				goto IL_2e1c;
			case 344:
				array4[26] = (byte)num9;
				num6 = 283;
				goto IL_2e20;
			case 251:
				array4[29] = 106;
				num2 = 129;
				goto IL_2e1c;
			case 342:
				array4[16] = 84;
				num2 = 73;
				goto IL_2e1c;
			case 355:
				k4bg1NhX8k = (byte[])EIMLNu1vUHTTh4bQ7L(memoryStream);
				num2 = 340;
				goto IL_2e1c;
			case 375:
				array3[10] = (byte)num5;
				num2 = 400;
				goto IL_2e1c;
			case 397:
				array3[8] = 144;
				num6 = 117;
				if (s9vDKyYsR6mGCaK1D4())
				{
					goto case 168;
				}
				goto IL_2e20;
			case 168:
				array4[11] = (byte)num7;
				num2 = 159;
				goto IL_2e1c;
			case 360:
				array4[2] = 182;
				num6 = 339;
				goto IL_2e20;
			case 354:
				num15++;
				num6 = 6;
				goto IL_2e20;
			case 171:
				num9 = 70 + 28;
				num2 = 234;
				goto IL_2e1c;
			case 345:
				if (num16 == num15 - 1)
				{
					num = 301;
					break;
				}
				goto IL_18fa;
			case 112:
				array4[0] = (byte)num7;
				num2 = 62;
				goto IL_2e1c;
			case 10:
				array3[15] = (byte)num8;
				num6 = 51;
				if (s9vDKyYsR6mGCaK1D4())
				{
					goto case 18;
				}
				goto IL_2e20;
			case 18:
				num7 = 172 - 57;
				num2 = 232;
				goto IL_2e1c;
			case 254:
				num22 = 0;
				num6 = 401;
				if (false)
				{
					goto case 212;
				}
				goto IL_2e20;
			case 212:
				array4[6] = (byte)num7;
				num6 = 139;
				goto IL_2e20;
			case 319:
				array3[2] = (byte)num8;
				num = 154;
				break;
			case 85:
				num9 = 65 + 43;
				num2 = 76;
				goto IL_2e1c;
			case 236:
				array4[3] = 172;
				num6 = 208;
				goto IL_2e20;
			case 198:
				array4[29] = 137;
				num = 9;
				break;
			case 32:
				num21++;
				num6 = 167;
				goto IL_2e20;
			case 250:
				array3[13] = (byte)num8;
				num6 = 29;
				goto IL_2e20;
			case 102:
				array4[17] = (byte)num9;
				num6 = 0;
				if (s9vDKyYsR6mGCaK1D4())
				{
					goto case 204;
				}
				goto IL_2e20;
			case 121:
				array3[5] = 92;
				num = 286;
				break;
			case 46:
				array3[11] = 120;
				num2 = 229;
				goto IL_2e1c;
			case 405:
				num9 = 187 - 62;
				num = 102;
				break;
			case 381:
				num20 = 0;
				num6 = 387;
				if (false)
				{
					goto case 62;
				}
				goto IL_2e20;
			case 62:
				num7 = 30 + 103;
				num = 74;
				break;
			case 351:
				array3[1] = 122;
				num = 119;
				break;
			case 364:
				num7 = 155 - 51;
				num = 203;
				break;
			case 324:
				num9 = 24 + 35;
				num = 59;
				break;
			case 137:
				array4[9] = (byte)num7;
				num6 = 268;
				if (1 == 0)
				{
					goto case 253;
				}
				goto IL_2e20;
			case 253:
				num20 += 8;
				num6 = 25;
				goto IL_2e20;
			case 123:
				array4[30] = 100;
				num6 = 12;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 87;
				}
				goto IL_2e20;
			case 87:
				array4[14] = 114;
				num = 95;
				break;
			case 180:
				num9 = 35 + 22;
				num6 = 60;
				if (false)
				{
					goto case 372;
				}
				goto IL_2e20;
			case 372:
				array3[4] = 89;
				num2 = 315;
				goto IL_2e1c;
			case 104:
				array4[13] = (byte)num9;
				num2 = 52;
				goto IL_2e1c;
			case 25:
				array7[num25 + num22] = (byte)((num26 & num19) >> num20);
				num6 = 292;
				if (false)
				{
					goto case 264;
				}
				goto IL_2e20;
			case 264:
				array4[1] = (byte)num7;
				num2 = 179;
				goto IL_2e1c;
			case 335:
				num7 = 30 + 115;
				num = 40;
				break;
			case 29:
				array3[13] = 104;
				num6 = 227;
				if (false)
				{
					goto case 177;
				}
				goto IL_2e20;
			case 177:
				num9 = 187 - 62;
				num2 = 19;
				goto IL_2e1c;
			case 374:
				array4[20] = (byte)num7;
				num = 324;
				break;
			case 249:
				array4[20] = (byte)num7;
				num = 403;
				break;
			case 225:
				S6wpMN9FrqrRcAV02h(cryptoStream, array6, 0, array6.Length);
				num = 279;
				break;
			case 13:
				array4[11] = 206;
				num6 = 177;
				goto IL_2e20;
			case 285:
				array[1] = array2[0];
				num = 371;
				break;
			case 214:
				num8 = 108 + 63;
				num2 = 221;
				goto IL_2e1c;
			case 207:
				num7 = 150 - 49;
				num = 39;
				break;
			case 323:
				num5 = 169 - 56;
				num6 = 309;
				if (1 == 0)
				{
					goto case 86;
				}
				goto IL_2e20;
			case 86:
				num9 = 169 - 56;
				num = 213;
				break;
			case 179:
				array4[1] = 50;
				num2 = 360;
				goto IL_2e1c;
			case 379:
				num5 = 60 + 16;
				num2 = 242;
				goto IL_2e1c;
			case 69:
				array4[6] = 146;
				num2 = 230;
				goto IL_2e1c;
			case 34:
				num8 = 178 - 83;
				num = 224;
				break;
			case 145:
				array4[20] = (byte)num7;
				num6 = 325;
				goto IL_2e20;
			case 384:
				transform = (ICryptoTransform)bnvpG4eWKgKJ9Zjxlj(symmetricAlgorithm, array5, array);
				num6 = 151;
				if (s9vDKyYsR6mGCaK1D4())
				{
					goto case 412;
				}
				goto IL_2e20;
			case 308:
				num9 = 178 - 113;
				num6 = 419;
				if (false)
				{
					goto case 184;
				}
				goto IL_2e20;
			case 184:
				num7 = 91 + 42;
				num2 = 61;
				goto IL_2e1c;
			case 383:
				num8 = 197 - 65;
				num = 250;
				break;
			case 140:
				num19 <<= 8;
				num = 253;
				break;
			case 387:
				if (num16 == num15 - 1)
				{
					num = 113;
					break;
				}
				goto IL_00ed;
			case 290:
				array4[31] = (byte)num9;
				num6 = 41;
				goto IL_2e20;
			case 202:
				array3[9] = 98;
				num6 = 206;
				goto IL_2e20;
			case 321:
				array4[15] = (byte)num9;
				num = 406;
				break;
			case 192:
				num15 = array6.Length / 4;
				num6 = 197;
				goto IL_2e20;
			case 398:
				num7 = 130 - 43;
				num6 = 220;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 332;
				}
				goto IL_2e20;
			case 373:
				num14 <<= 8;
				num6 = 89;
				goto IL_2e20;
			case 363:
				array3[9] = (byte)num8;
				num6 = 199;
				if (s9vDKyYsR6mGCaK1D4())
				{
					goto case 190;
				}
				goto IL_2e20;
			case 84:
				num8 = 220 - 73;
				num2 = 10;
				goto IL_2e1c;
			case 343:
				array4[28] = 162;
				num2 = 27;
				goto IL_2e1c;
			case 378:
				array4[28] = 138;
				num = 282;
				break;
			case 74:
				array4[0] = (byte)num7;
				num2 = 108;
				goto IL_2e1c;
			case 0:
				array4[17] = 39;
				num = 85;
				break;
			case 288:
				num9 = 183 + 36;
				num2 = 222;
				goto IL_2e1c;
			case 272:
				num13 = array5.Length / 4;
				num6 = 106;
				if (1 == 0)
				{
					goto case 30;
				}
				goto IL_2e20;
			case 30:
				num14 = 0u;
				num2 = 411;
				goto IL_2e1c;
			case 1:
				LganFrvkccIsYseEmu(symmetricAlgorithm, CipherMode.CBC);
				num = 384;
				break;
			case 256:
				array4[12] = (byte)num7;
				num6 = 398;
				goto IL_2e20;
			case 138:
				wGuMNtWjsXbq6VGNss(binaryReader);
				num2 = 260;
				goto IL_2e1c;
			case 97:
				array4[21] = 176;
				num = 181;
				break;
			case 42:
				array4[30] = (byte)num7;
				num = 414;
				break;
			case 158:
				array4[7] = 165;
				num6 = 111;
				goto IL_2e20;
			case 329:
				num5 = 55 + 30;
				num6 = 144;
				if (1 == 0)
				{
					goto case 116;
				}
				goto IL_2e20;
			case 116:
				array3[2] = (byte)num8;
				num = 124;
				break;
			case 142:
				array4[15] = 154;
				num6 = 86;
				if (s9vDKyYsR6mGCaK1D4())
				{
					goto case 101;
				}
				goto IL_2e20;
			case 101:
				array3[10] = 100;
				num6 = 379;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 371;
				}
				goto IL_2e20;
			case 107:
				array4[30] = (byte)num7;
				num6 = 361;
				goto IL_2e20;
			case 191:
				num11 = (uint)(num12 * 4);
				num = 37;
				break;
			case 3:
				array4[6] = (byte)num7;
				num2 = 162;
				goto IL_2e1c;
			case 266:
				num7 = 158 - 52;
				num6 = 23;
				if (1 == 0)
				{
					goto case 356;
				}
				goto IL_2e20;
			case 356:
				array4[8] = 108;
				num2 = 28;
				goto IL_2e1c;
			case 75:
				num10 = 0;
				num6 = 7;
				if (false)
				{
					goto case 220;
				}
				goto IL_2e20;
			case 220:
				array4[12] = (byte)num7;
				num6 = 258;
				if (false)
				{
					goto case 226;
				}
				goto IL_2e20;
			case 226:
				num5 = 42 + 44;
				num6 = 15;
				goto IL_2e20;
			case 109:
				LMrsN7B9hj6x8q4AGF(cryptoStream);
				num = 415;
				break;
			case 148:
				array4[8] = 146;
				num2 = 55;
				goto IL_2e1c;
			case 51:
				array3[15] = 152;
				num = 408;
				break;
			case 333:
				array[15] = array2[7];
				num2 = 280;
				goto IL_2e1c;
			case 276:
				array4[23] = 118;
				num2 = 265;
				goto IL_2e1c;
			case 339:
				num9 = 22 + 104;
				num2 = 115;
				goto IL_2e1c;
			case 196:
				array4[11] = (byte)num9;
				num = 13;
				break;
			case 39:
				array4[18] = (byte)num7;
				num6 = 11;
				if (false)
				{
					goto case 336;
				}
				goto IL_2e20;
			case 336:
				array3[2] = 181;
				num6 = 126;
				goto IL_2e20;
			case 185:
				num8 = 69 + 116;
				num2 = 118;
				goto IL_2e1c;
			case 21:
				num7 = 230 - 76;
				num = 257;
				break;
			case 298:
				num8 = 76 - 64;
				num6 = 318;
				goto IL_2e20;
			case 259:
				array4[16] = (byte)num9;
				num6 = 266;
				if (false)
				{
					goto case 260;
				}
				goto IL_2e20;
			case 260:
				array4 = new byte[32];
				num6 = 418;
				if (1 == 0)
				{
					goto case 94;
				}
				goto IL_2e20;
			case 94:
				array4[0] = 98;
				num6 = 416;
				if (1 == 0)
				{
					goto case 99;
				}
				goto IL_2e20;
			case 99:
				array4[10] = 98;
				num6 = 135;
				if (1 == 0)
				{
					goto case 201;
				}
				goto IL_2e20;
			case 201:
				num5 = 19 + 21;
				num6 = 218;
				if (false)
				{
					goto case 174;
				}
				goto IL_2e20;
			case 174:
				num7 = 175 - 115;
				num2 = 141;
				goto IL_2e1c;
			case 95:
				num7 = 39 + 37;
				num2 = 413;
				goto IL_2e1c;
			case 322:
				num8 = 159 - 53;
				num = 173;
				break;
			case 313:
				array3[10] = (byte)num5;
				num6 = 388;
				if (!AThXyJDcSWb9jaOj8B())
				{
					goto case 353;
				}
				goto IL_2e20;
			case 9:
				array4[29] = 86;
				goto case 377;
			default:
				num = 377;
				break;
			case 73:
				num9 = 136 - 36;
				num6 = 259;
				goto IL_2e20;
			case 233:
				num9 = 131 - 43;
				num6 = 79;
				goto IL_2e20;
			case 317:
				lYkTLmOs3EPZ6idSHj(array);
				num6 = 303;
				goto IL_2e20;
			case 265:
				num9 = 118 + 109;
				num6 = 310;
				if (AThXyJDcSWb9jaOj8B())
				{
					goto IL_2e20;
				}
				goto case 52;
			case 52:
				num7 = 135 + 30;
				num = 178;
				break;
			case 14:
				array4[15] = (byte)num9;
				num2 = 338;
				goto IL_2e1c;
			case 126:
				array3[2] = 146;
				num6 = 132;
				if (AThXyJDcSWb9jaOj8B())
				{
					goto IL_2e20;
				}
				goto case 392;
			case 392:
				array = array3;
				num = 317;
				break;
			case 211:
				array4[11] = (byte)num7;
				num = 176;
				break;
			case 417:
				array4[25] = (byte)num9;
				num6 = 239;
				if (AThXyJDcSWb9jaOj8B())
				{
					goto IL_2e20;
				}
				goto case 221;
			case 221:
				array3[8] = (byte)num8;
				num = 402;
				break;
			case 50:
				array4[6] = (byte)num7;
				num6 = 410;
				goto IL_2e20;
			case 206:
				num8 = 224 - 74;
				num = 363;
				break;
			case 144:
				array3[0] = (byte)num5;
				num6 = 362;
				goto IL_2e20;
			case 164:
				if (array2 != null)
				{
					num = 56;
					break;
				}
				goto case 280;
			case 118:
				array3[14] = (byte)num8;
				num6 = 170;
				goto IL_2e20;
			case 157:
				num7 = 87 + 63;
				num6 = 264;
				goto IL_2e20;
			case 143:
				num5 = 229 - 76;
				num6 = 127;
				if (s9vDKyYsR6mGCaK1D4())
				{
					goto case 172;
				}
				goto IL_2e20;
			case 150:
				array[11] = array2[5];
				num = 146;
				break;
			case 424:
				try
				{
					return (string)J3tmgXTVhe3GEGxUsn(n1hu83nQgTHq8rU4S8(), k4bg1NhX8k, P_0 + 4, num3);
				}
				catch
				{
				}
				return "";
			case 151:
				memoryStream = new MemoryStream();
				num2 = 49;
				goto IL_2e1c;
			case 194:
				{
					symmetricAlgorithm = (SymmetricAlgorithm)LGuGT6k0h6OwKmAFgT();
					num6 = 1;
					if (!AThXyJDcSWb9jaOj8B())
					{
						goto case 16;
					}
					goto IL_2e20;
				}
				IL_18fa:
				num17 = num18 ^ num14;
				num2 = 380;
				goto IL_2e1c;
				IL_2e20:
				num = num6;
				break;
				IL_00ed:
				num18 += num24;
				num2 = 327;
				goto IL_2e1c;
				IL_2e1c:
				num6 = num2;
				goto IL_2e20;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[dTfHZF3rIe1ujwmUyK(typeof(dTfHZF3rIe1ujwmUyK.PFJ9ZwTjAxEfOIqArI<object>[]))]
	internal static string yLstX0hPvo(string P_0)
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
	private static int GUWtqm8hxy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return 5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void d88trei3eN()
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
	private static Delegate qvftcZSVLO(IntPtr P_0, Type P_1)
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
	internal static object cantKhsEa7(object P_0)
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
	[dTfHZF3rIe1ujwmUyK(typeof(dTfHZF3rIe1ujwmUyK.PFJ9ZwTjAxEfOIqArI<object>[]))]
	private static byte[] XVOt875JFD(string P_0)
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
	[dTfHZF3rIe1ujwmUyK(typeof(dTfHZF3rIe1ujwmUyK.PFJ9ZwTjAxEfOIqArI<object>[]))]
	private static byte[] rE4teapFxn(byte[] P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		MemoryStream memoryStream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = RO4tN72xvB();
		symmetricAlgorithm.Key = new byte[32]
		{
			49, 130, 122, 226, 254, 241, 214, 165, 200, 204,
			142, 116, 39, 233, 45, 39, 17, 62, 53, 35,
			209, 89, 172, 231, 70, 178, 26, 46, 151, 175,
			160, 126
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			154, 134, 211, 93, 254, 61, 113, 157, 6, 1,
			100, 97, 242, 40, 246, 231
		};
		CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(P_0, 0, P_0.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] KGRtprcn6o()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] l2itFLqpab()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] ePRtztDt6p()
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
	private byte[] xJkgwsSA1h()
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
	private byte[] fHAgt8JOHA()
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
	private byte[] yAcggtc3XM()
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
	internal byte[] WaigL425K8()
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
	internal byte[] v82gbxcv7o()
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
	internal byte[] P7AgSIL2oI()
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
	internal byte[] LV3gJ244Hr()
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
	public M8HpnnnUdjcJPbDHVy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qH8Jm7plUbZ19Q44Q7(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iD9joYRswXZ69FIfDg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BinaryReader)P_0).BaseStream;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lWD4nphNCbKZHY0NsK(object P_0, long P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Position = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long C20moKmamsVOEGcG92(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Stream)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BTjUWDGjltfKonYGse(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BinaryReader)P_0).ReadBytes(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wGuMNtWjsXbq6VGNss(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BinaryReader)P_0).Close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lYkTLmOs3EPZ6idSHj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Array.Reverse((Array)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tsgrC4sQCo9sAZhKts(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Assembly)P_0).GetName();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object geAEnQuf8uL0mXj2yv(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AssemblyName)P_0).GetPublicKeyToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LGuGT6k0h6OwKmAFgT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return RO4tN72xvB();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LganFrvkccIsYseEmu(object P_0, CipherMode P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SymmetricAlgorithm)P_0).Mode = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bnvpG4eWKgKJ9Zjxlj(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void S6wpMN9FrqrRcAV02h(object P_0, object P_1, int P_2, int P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void G3QtnbxWcSUoHoU1XV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CryptoStream)P_0).FlushFinalBlock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EIMLNu1vUHTTh4bQ7L(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MemoryStream)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LMrsN7B9hj6x8q4AGF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int yT2e2lZMsnrgmfQHJv(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return BitConverter.ToInt32((byte[])P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object n1hu83nQgTHq8rU4S8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Encoding.Unicode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object J3tmgXTVhe3GEGxUsn(object P_0, object P_1, int P_2, int P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Encoding)P_0).GetString((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AThXyJDcSWb9jaOj8B()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool s9vDKyYsR6mGCaK1D4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
