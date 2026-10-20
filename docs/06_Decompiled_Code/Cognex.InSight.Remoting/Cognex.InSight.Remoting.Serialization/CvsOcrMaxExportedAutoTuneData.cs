using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "OCRMaxExportedAutoTuneDataObject")]
public class CvsOcrMaxExportedAutoTuneData
{
	private static class zoNbquB477xsxV3uBs
	{
		private static readonly byte[] GDGNXpOikX;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] xjSN4f57cm(CvsOcrMaxExportedAutoTuneData P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			MemoryStream memoryStream = new MemoryStream();
			try
			{
				BinaryWriter binaryWriter = new BinaryWriter(memoryStream, (Encoding)BuR0fDtPjLoPesYPmoR());
				try
				{
					gC41T9tIJkYkyFVImg0(binaryWriter, GDGNXpOikX);
					int num = 7;
					byte[] array = default;
					while (true)
					{
						switch (num)
						{
						case 1:
						case 2:
							binaryWriter.Write(P_0.MinorVersion);
							num = 6;
							break;
						case 6:
							array = (byte[])PYtxmdtuNSrxDf1Vfrx(uildPVth94f81Vc0eOJ(g4b1X3tigGgnGsijukV(P_0)));
							goto case 3;
						default:
							num = 3;
							if (qUjXywtsOCqam10a5O4())
							{
								break;
							}
							goto case 4;
						case 4:
						case 5:
							Ssufi1tHXwObiRd24L9(binaryWriter);
							num = 8;
							break;
						case 7:
							hFXmwEtqnLBM0W926Ei(binaryWriter, i42Bc0tcsfJnvphwZ4s(P_0));
							_ = 0;
							num = ((!qUjXywtsOCqam10a5O4()) ? 4 : 2);
							break;
						case 3:
							hFXmwEtqnLBM0W926Ei(binaryWriter, array.Length);
							num = 0;
							if (!taQbMGtwsqtTREsM6m6())
							{
								break;
							}
							goto case 0;
						case 0:
							gC41T9tIJkYkyFVImg0(binaryWriter, array);
							goto case 4;
						case 8:
							return (byte[])LUD0mStZgSHX26Wtb2b(memoryStream);
						}
					}
				}
				finally
				{
					if (binaryWriter != null)
					{
						Cce6MgttEhR324ahH4B(binaryWriter);
					}
				}
			}
			finally
			{
				if (memoryStream != null)
				{
					Cce6MgttEhR324ahH4B(memoryStream);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static CvsOcrMaxExportedAutoTuneData k7PN2lqwjU(byte[] P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			MemoryStream memoryStream = new MemoryStream(P_0);
			try
			{
				BinaryReader binaryReader = new BinaryReader(memoryStream, (Encoding)BuR0fDtPjLoPesYPmoR());
				try
				{
					int num;
					int majorVersion = default;
					if (!((IEnumerable<byte>)uLaGLItaPn9b2SRCAib(binaryReader, GDGNXpOikX.Length)).SequenceEqual(GDGNXpOikX))
					{
						num = 0;
					}
					else
					{
						majorVersion = R8o2Yetfl5W34aeAjHB(binaryReader);
						num = 4;
					}
					int num2 = default;
					int minorVersion = default;
					byte[] array = default;
					while (true)
					{
						switch (num)
						{
						case 2:
						case 5:
							num2 = R8o2Yetfl5W34aeAjHB(binaryReader);
							goto case 1;
						case 4:
							minorVersion = R8o2Yetfl5W34aeAjHB(binaryReader);
							goto default;
						default:
							taQbMGtwsqtTREsM6m6();
							if (!qUjXywtsOCqam10a5O4())
							{
								num = 1;
								break;
							}
							num = 5;
							if (true)
							{
								break;
							}
							goto case 1;
						case 1:
						case 3:
							array = (byte[])uLaGLItaPn9b2SRCAib(binaryReader, num2);
							num = 6;
							break;
						case 0:
							throw new ArgumentException((string)VfOg8NtD83ED6aOPtip(3900), (string)VfOg8NtD83ED6aOPtip(3942));
						case 6:
							return new CvsOcrMaxExportedAutoTuneData
							{
								MajorVersion = majorVersion,
								MinorVersion = minorVersion,
								Data = new CvsCogByteArray((string)CRw6x5tUEOM3bcbxCt7(array))
							};
						}
					}
				}
				finally
				{
					if (binaryReader != null)
					{
						Cce6MgttEhR324ahH4B(binaryReader);
					}
				}
			}
			finally
			{
				if (memoryStream != null)
				{
					Cce6MgttEhR324ahH4B(memoryStream);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static zoNbquB477xsxV3uBs()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			w325QjtrkNPJn3a05T1();
			GDGNXpOikX = new byte[4] { 79, 65, 77, 1 };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BuR0fDtPjLoPesYPmoR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Encoding.ASCII;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gC41T9tIJkYkyFVImg0(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BinaryWriter)P_0).Write((byte[])P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int i42Bc0tcsfJnvphwZ4s(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsOcrMaxExportedAutoTuneData)P_0).MajorVersion;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void hFXmwEtqnLBM0W926Ei(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BinaryWriter)P_0).Write(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object g4b1X3tigGgnGsijukV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsOcrMaxExportedAutoTuneData)P_0).Data;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object uildPVth94f81Vc0eOJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogByteArray)P_0).Base64;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PYtxmdtuNSrxDf1Vfrx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Convert.FromBase64String((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Ssufi1tHXwObiRd24L9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BinaryWriter)P_0).Flush();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LUD0mStZgSHX26Wtb2b(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((MemoryStream)P_0).ToArray();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Cce6MgttEhR324ahH4B(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qUjXywtsOCqam10a5O4()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool taQbMGtwsqtTREsM6m6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object uLaGLItaPn9b2SRCAib(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BinaryReader)P_0).ReadBytes(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VfOg8NtD83ED6aOPtip(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int R8o2Yetfl5W34aeAjHB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BinaryReader)P_0).ReadInt32();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CRw6x5tUEOM3bcbxCt7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Convert.ToBase64String((byte[])P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void w325QjtrkNPJn3a05T1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
		}
	}

	[CompilerGenerated]
	private int cIbMZj5lHO;

	[CompilerGenerated]
	private int vWeMgD4rvZ;

	[CompilerGenerated]
	private CvsCogByteArray z2tMS0VH2X;

	[JsonProperty(PropertyName = "majorVersion")]
	public int MajorVersion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return cIbMZj5lHO;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cIbMZj5lHO = value;
		}
	}

	[JsonProperty(PropertyName = "minorVersion")]
	public int MinorVersion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return vWeMgD4rvZ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			vWeMgD4rvZ = value;
		}
	}

	[JsonProperty(PropertyName = "autoTuneData")]
	public CvsCogByteArray Data
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return z2tMS0VH2X;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			z2tMS0VH2X = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsOcrMaxExportedAutoTuneData FromBytes(byte[] bytes)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return zoNbquB477xsxV3uBs.k7PN2lqwjU(bytes);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] ConvertToBytes(CvsOcrMaxExportedAutoTuneData model)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (byte[])Der7KWqabPTHc6f224J(model);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsOcrMaxExportedAutoTuneData()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RMshEjqDARpv6T80D5h();
		g31BKaqfmZHtMB8XvNr(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sLmjLMqZvb5pwF54IJP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wvVeSlqtp9N3ecuo5bw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Der7KWqabPTHc6f224J(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return zoNbquB477xsxV3uBs.xjSN4f57cm((CvsOcrMaxExportedAutoTuneData)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RMshEjqDARpv6T80D5h()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void g31BKaqfmZHtMB8XvNr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
