using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.Explorer.Diagnostics;

public class StreamLogger
{
	private MD5Cng UYYF80Xvb;

	[CompilerGenerated]
	private string UYJbR13bQ;

	[CompilerGenerated]
	private string IkKacVm1p;

	public string LogPath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return UYJbR13bQ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			UYJbR13bQ = value;
		}
	}

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return IkKacVm1p;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IkKacVm1p = value;
		}
	}

	public bool CanLogStream
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return !zDN7cdYBM3DDJij8Ob(LogPath);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StreamLogger(string appConfigDirPropertyName, string filePrefix)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		string text = default;
		string text2 = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 0;
				continue;
			case 0:
				CnoZpg5KeeThfCCFf0(this);
				num = 10;
				if (GD3jt5Kq2vpMo66VlO())
				{
				}
				continue;
			case 7:
				try
				{
					if (!f6voESNGiRq2Ef8PtD(text))
					{
						Directory.CreateDirectory(text);
					}
				}
				catch (Exception)
				{
					LogPath = null;
				}
				text2 = hT47NexRmLvYbTBDFH().ToString(kgbOBx7BanbFa22Hp9.ol99ukmDA(402));
				num = 1;
				continue;
			case 4:
			case 9:
				if (!zDN7cdYBM3DDJij8Ob(text))
				{
					goto case 7;
				}
				LogPath = null;
				num = 11;
				continue;
			default:
				num = 7;
				continue;
			case 6:
				return;
			case 8:
				return;
			case 2:
				text = (string)z2f7cJPvCsoHl9f1YH(UpDCkMoGWdET5guMhR(), appConfigDirPropertyName);
				_ = 1;
				num = (GD3jt5Kq2vpMo66VlO() ? 6 : 9);
				continue;
			case 1:
				LogPath = (string)hUp8g03liAHDMWYhri(text, URIGmorxOMIOLjGRJo(filePrefix, wE5mDS1BrOSssrbU9H(444), text2, kgbOBx7BanbFa22Hp9.ol99ukmDA(450)));
				num = 3;
				continue;
			case 10:
				Name = filePrefix;
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 3:
				break;
			case 11:
				return;
			}
			break;
		}
		UYYF80Xvb = new MD5Cng();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogStream(Stream stream, string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!GD3jt5Kq2vpMo66VlO())
		{
			num = 5;
			if (GD3jt5Kq2vpMo66VlO())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0089;
		IL_002a:
		long num2 = default;
		if (!HYwBIhMGaSo9VX3VbN(stream))
		{
			num = 4;
		}
		else
		{
			num2 = kE16dFQr1EupWThiCW(stream);
			num = 7;
		}
		goto IL_0089;
		IL_0089:
		string text = default;
		byte[] array = default;
		int num4 = default;
		string text2 = default;
		int num5 = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 4:
				return;
			case 0:
			case 5:
				if (!CanLogStream)
				{
					return;
				}
				goto case 1;
			case 3:
				if (!GBx0XaODHq1FZMEiRn(stream))
				{
					return;
				}
				break;
			default:
				num = 6;
				if (!GD3jt5Kq2vpMo66VlO())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 2:
				if (stream == null)
				{
					return;
				}
				num = 3;
				continue;
			case 7:
				try
				{
					FileStream fileStream = (FileStream)DyUPG8l97kmtjnZ14l(LogPath, FileMode.Append, FileAccess.Write);
					try
					{
						using TextWriter textWriter = new StreamWriter(fileStream);
						wfyRTOempt0dV8aaG2(stream, 0L);
						int num3 = 10;
						if (false)
						{
							goto IL_00f7;
						}
						goto IL_0260;
						IL_00f7:
						text = (string)v4LojWRMxlJ0jfxYU1(array);
						_ = 1;
						if (!GD3jt5Kq2vpMo66VlO())
						{
							num3 = 7;
						}
						else
						{
							num3 = 3;
							if (false)
							{
								goto IL_01fb;
							}
						}
						goto IL_0260;
						IL_01fb:
						NilMYrnl36KYZukLSv(textWriter, text);
						num3 = 9;
						goto IL_0260;
						IL_0260:
						while (true)
						{
							switch (num3)
							{
							case 8:
								break;
							case 2:
							{
								object obj = VQYtvsIoqrUOVC5ejX(UYYF80Xvb, array);
								num4 = ((IEnumerable<byte>)obj).Aggregate(0, [MethodImpl(MethodImplOptions.NoInlining)] (int current, byte digit) =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									return current + digit;
								});
								text2 = mFMIwRcyo((byte[])obj);
								num3 = 8;
								continue;
							}
							case 9:
								textWriter.WriteLine((string)wE5mDS1BrOSssrbU9H(676) + label + (string)wE5mDS1BrOSssrbU9H(486));
								num3 = 11;
								continue;
							case 1:
								num5 = stream.Read(array, 0, array.Length);
								num3 = 2;
								continue;
							case 5:
								textWriter.WriteLine((string)MIGd6wGBZkp3vcVK3I(wE5mDS1BrOSssrbU9H(522), num4));
								textWriter.WriteLine(string.Format((string)wE5mDS1BrOSssrbU9H(550), mD5FjNu4JSCjfOSHyG(stream), array.Length, num5));
								goto case 3;
							case 0:
								goto IL_01fb;
							case 3:
							case 6:
								NilMYrnl36KYZukLSv(textWriter, lMY2T2X54NuEsJ4Drs(wE5mDS1BrOSssrbU9H(662), text2));
								num3 = 0;
								continue;
							case 4:
							case 7:
								NilMYrnl36KYZukLSv(textWriter, dK4Ka7a4GBUKJ6ULOV(kgbOBx7BanbFa22Hp9.ol99ukmDA(462), label, wE5mDS1BrOSssrbU9H(486)));
								goto case 5;
							default:
								num3 = 5;
								continue;
							case 10:
								array = new byte[mD5FjNu4JSCjfOSHyG(stream)];
								num3 = 1;
								continue;
							case 11:
								VZliq2bwsVt7yPsCJ7(textWriter);
								return;
							}
							break;
						}
						goto IL_00f7;
					}
					finally
					{
						if (fileStream != null)
						{
							jBEjw16uwvrfaedvqH(fileStream);
						}
					}
				}
				catch (Exception)
				{
					return;
				}
				finally
				{
					wfyRTOempt0dV8aaG2(stream, num2);
				}
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string mFMIwRcyo(byte[] P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		StringBuilder stringBuilder = default;
		byte b = default;
		int num2 = default;
		byte[] array = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				P1NKkNpqEPJ6g7dV4P(stringBuilder, MIGd6wGBZkp3vcVK3I(wE5mDS1BrOSssrbU9H(696), b));
				goto case 5;
			case 1:
			case 3:
			case 8:
				if (num2 >= array.Length)
				{
					num = 9;
					if (pL0SYhC5MXXRZ9s8UO())
					{
						break;
					}
					goto case 6;
				}
				b = array[num2];
				goto case 2;
			case 6:
				stringBuilder = new StringBuilder();
				num = 4;
				break;
			default:
				num = 2;
				break;
			case 5:
			case 7:
				num2++;
				num = 8;
				break;
			case 0:
				num2 = 0;
				_ = 1;
				num = ((!GD3jt5Kq2vpMo66VlO()) ? 1 : 7);
				break;
			case 4:
				array = P_0;
				num = 0;
				break;
			case 9:
				return stringBuilder.ToString();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CnoZpg5KeeThfCCFf0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UpDCkMoGWdET5guMhR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ConfigurationManager.AppSettings;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object z2f7cJPvCsoHl9f1YH(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((NameValueCollection)P_0)[(string)P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zDN7cdYBM3DDJij8Ob(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool f6voESNGiRq2Ef8PtD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Directory.Exists((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime hT47NexRmLvYbTBDFH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return DateTime.Now;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wE5mDS1BrOSssrbU9H(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object URIGmorxOMIOLjGRJo(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hUp8g03liAHDMWYhri(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Path.Combine((string)P_0, (string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pL0SYhC5MXXRZ9s8UO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GD3jt5Kq2vpMo66VlO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GBx0XaODHq1FZMEiRn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Stream)P_0).CanRead;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HYwBIhMGaSo9VX3VbN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Stream)P_0).CanSeek;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long kE16dFQr1EupWThiCW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Stream)P_0).Position;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DyUPG8l97kmtjnZ14l(object P_0, FileMode P_1, FileAccess P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return File.Open((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wfyRTOempt0dV8aaG2(object P_0, long P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Position = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long mD5FjNu4JSCjfOSHyG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Stream)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VQYtvsIoqrUOVC5ejX(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((HashAlgorithm)P_0).ComputeHash((byte[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object v4LojWRMxlJ0jfxYU1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return mFMIwRcyo((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dK4Ka7a4GBUKJ6ULOV(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NilMYrnl36KYZukLSv(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((TextWriter)P_0).WriteLine((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MIGd6wGBZkp3vcVK3I(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lMY2T2X54NuEsJ4Drs(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VZliq2bwsVt7yPsCJ7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((TextWriter)P_0).WriteLine();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jBEjw16uwvrfaedvqH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object P1NKkNpqEPJ6g7dV4P(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StringBuilder)P_0).Append((string)P_1);
	}
}
