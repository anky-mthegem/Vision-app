using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Services;

public struct ImageBytes
{
	public static ImageBytes Empty;

	public readonly int Width;

	public readonly int Height;

	public readonly byte[] Bytes;

	public readonly bool HasSize;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ImageBytes(byte[] bytes)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Q6ISxy5SLs5fAxObQXX();
		int num;
		if (VC86qx5944CS4dMN2sm())
		{
			num = 4;
		}
		else
		{
			num = 5;
			if (1 == 0)
			{
				return;
			}
		}
		while (true)
		{
			switch (num)
			{
			default:
				Bytes = bytes;
				num = 6;
				break;
			case 0:
			case 4:
				Yal0wW5EUrKm943Dbhn();
				num = 1;
				break;
			case 1:
				Width = 0;
				num = 2;
				break;
			case 6:
				HasSize = false;
				num = 7;
				break;
			case 2:
				Height = 0;
				goto default;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ImageBytes(int width, int height, byte[] bytes)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				Width = width;
				goto case 0;
			case 4:
				Yal0wW5EUrKm943Dbhn();
				_ = 1;
				num = ((!Q6ISxy5SLs5fAxObQXX()) ? 5 : 0);
				break;
			case 0:
			case 2:
				Height = height;
				goto case 3;
			default:
				num = 3;
				break;
			case 3:
				Bytes = bytes;
				num = 6;
				break;
			case 6:
				HasSize = true;
				num = 7;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ImageBytes(Stream stream)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (VC86qx5944CS4dMN2sm())
		{
			num = 3;
		}
		else
		{
			num = 4;
			if (!VC86qx5944CS4dMN2sm())
			{
				goto IL_0099;
			}
		}
		goto IL_003d;
		IL_00b0:
		Yal0wW5EUrKm943Dbhn();
		num = 5;
		goto IL_003d;
		IL_0099:
		HasSize = false;
		num = 1;
		if (VC86qx5944CS4dMN2sm())
		{
			goto IL_003d;
		}
		goto IL_00b0;
		IL_003d:
		MemoryStream memoryStream = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				Height = 0;
				break;
			default:
				num = 6;
				continue;
			case 1:
				memoryStream = new MemoryStream();
				num = 7;
				continue;
			case 5:
				Width = 0;
				goto case 2;
			case 6:
				break;
			case 0:
			case 3:
				goto IL_00b0;
			case 7:
				try
				{
					stream.CopyTo(memoryStream);
					Bytes = (byte[])WDYkIL5vpFh2hab1K1E(memoryStream);
					return;
				}
				finally
				{
					if (memoryStream != null)
					{
						XEPU3i5HFVVkvkQOhRO(memoryStream);
					}
				}
			}
			break;
		}
		goto IL_0099;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MemoryStream GetMemoryStream()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new MemoryStream(Bytes);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ImageBytes FromBitmap(Bitmap bitmap)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		byte[] bytes = (byte[])iPakEJ5AB8ZkQY2ef7S(new ImageConverter(), bitmap, t6DFWv5VMVCgcqiXpeR(typeof(byte[]).TypeHandle));
		return new ImageBytes(bitmap.Width, n6i85Z5DvAWsYoX0SHP(bitmap), bytes);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImageBytes()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Yal0wW5EUrKm943Dbhn();
		Empty = new ImageBytes(0, 0, Cognex.Empty.Array<byte>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Yal0wW5EUrKm943Dbhn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VC86qx5944CS4dMN2sm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Q6ISxy5SLs5fAxObQXX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WDYkIL5vpFh2hab1K1E(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MemoryStream)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XEPU3i5HFVVkvkQOhRO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type t6DFWv5VMVCgcqiXpeR(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iPakEJ5AB8ZkQY2ef7S(object P_0, object P_1, Type P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((TypeConverter)P_0).ConvertTo(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int n6i85Z5DvAWsYoX0SHP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Image)P_0).Height;
	}
}
