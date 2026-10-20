using System;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using Cognex.Cnx.Imaging;
using Cognex.InSight.Graphic;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

internal class ImageConfig
{
	internal enum Format
	{
		Image1,
		image2
	}

	internal enum Compression
	{
		None,
		JPEG
	}

	public Format DataFormat;

	public Compression DataCompression;

	public CvsImageResolution Resolution;

	public int flags;

	public int id;

	public int acqSeqNum;

	public int color;

	public int cellRow;

	public int cellCol;

	public int segmentID;

	public int lastSegmentID;

	public int JpegSegmentCount;

	public int AcquiredImageStartRow;

	public int AcquiredImageStartColumn;

	public int AcquiredImageHeight;

	public int AcquiredImageWidth;

	public int CroppedImageStartRow;

	public int CroppedImageStartColumn;

	public int CroppedImageHeight;

	public int CroppedImageWidth;

	public int ReceivedImageHeight;

	public int ReceivedImageWidth;

	public float aRow;

	public float aCol;

	public float aHigh;

	public float aWide;

	public float aTheta;

	public float aPhi;

	public int ImageScalingMethod;

	public int ImageCompression;

	public int ImageOrientation;

	public CnxPixelFormat PixelFormat;

	public int BytesPerPixel;

	public int SegmentPixelCount;

	public int SegmentPixelBytes;

	public int SegmentRows;

	public CvsGraphicRegion ClippingRegion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GetClippingRegion();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ReadBinary(BinaryReader br, Format format)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		DataFormat = format;
		if (format == Format.image2)
		{
			return BRJb6FPEN8(br);
		}
		return iANbsqy4Jd(br);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool iANbsqy4Jd(BinaryReader P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 12;
		int jpegSegmentCount = default;
		int num5 = default;
		int num3 = default;
		int num2 = default;
		int num4 = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				JpegSegmentCount = jpegSegmentCount;
				goto case 24;
			case 22:
				SegmentPixelBytes = num5 - num3;
				num = 28;
				break;
			case 17:
				SegmentRows = SegmentPixelCount / ReceivedImageWidth;
				num = 36;
				break;
			case 29:
				cellCol = P_0.ReadInt16();
				num = 1;
				if (true)
				{
					break;
				}
				goto case 19;
			case 19:
				segmentID = P_0.ReadByte();
				lastSegmentID = int.MaxValue;
				num = 0;
				break;
			case 20:
				aPhi = P_0.ReadSingle();
				num = 35;
				break;
			case 25:
				CroppedImageStartColumn = coqju7UwrRaflTD5qeq(P_0);
				CroppedImageHeight = coqju7UwrRaflTD5qeq(P_0);
				num = 26;
				break;
			case 12:
				flags = NFQbrqD8Pn3dqKcuJbP(P_0);
				num = 3;
				break;
			case 28:
				if (DataCompression == Compression.JPEG)
				{
					num = 5;
					if (nHNLFjDZItikjQuZ0P9())
					{
						break;
					}
					goto case 26;
				}
				SegmentPixelCount = SegmentPixelBytes / BytesPerPixel;
				num = 17;
				break;
			case 26:
				CroppedImageWidth = coqju7UwrRaflTD5qeq(P_0);
				AcquiredImageStartRow = CroppedImageStartRow;
				_ = 0;
				if (!nHNLFjDZItikjQuZ0P9())
				{
					num = 24;
					if (!KTH1w3DJ7Q9gYdY2ETq())
					{
						break;
					}
					goto case 4;
				}
				num = 33;
				if (KTH1w3DJ7Q9gYdY2ETq())
				{
				}
				break;
			case 30:
				aCol = yd6tfHUsgqVoHLFajIY(P_0);
				num = 31;
				if (true)
				{
					break;
				}
				goto case 4;
			case 1:
				num2 = NFQbrqD8Pn3dqKcuJbP(P_0);
				num = 19;
				break;
			case 13:
				ReceivedImageWidth = gLvDkmUhw0ethhhpUZi(1, CroppedImageWidth / (int)Resolution);
				num = 8;
				break;
			case 31:
				aHigh = yd6tfHUsgqVoHLFajIY(P_0);
				aWide = yd6tfHUsgqVoHLFajIY(P_0);
				num = 2;
				break;
			case 4:
			case 23:
			case 34:
			{
				Stream baseStream = P_0.BaseStream;
				NncnYpU9dL3gTvfiXGa(baseStream, uMLkH5ULQ6Eo1EJIjcC(baseStream) + num3);
				num = 22;
				if (nHNLFjDZItikjQuZ0P9())
				{
					break;
				}
				goto case 6;
			}
			case 35:
				num5 = P_0.ReadInt32();
				if (num5 == -1)
				{
					return false;
				}
				switch (num4)
				{
				case 3:
					PixelFormat = CnxPixelFormat.Format24bppRgb;
					num = 21;
					goto end_IL_0252;
				case 1:
					PixelFormat = CnxPixelFormat.Format16bppRgb565;
					BytesPerPixel = 2;
					num = 6;
					goto end_IL_0252;
				}
				PixelFormat = CnxPixelFormat.Format8bppGrayscale;
				goto case 14;
			default:
				num = 14;
				if (true)
				{
					break;
				}
				goto case 9;
			case 9:
				num3 = 28;
				num = 34;
				if (0 == 0)
				{
					break;
				}
				goto case 15;
			case 15:
				AcquiredImageHeight = CroppedImageHeight;
				AcquiredImageWidth = CroppedImageWidth;
				num = 11;
				break;
			case 7:
				CroppedImageStartRow = coqju7UwrRaflTD5qeq(P_0);
				num = 25;
				break;
			case 0:
				jpegSegmentCount = E2eFQiDzh6ImRscvjK0(P_0);
				num = 7;
				break;
			case 8:
				if (num2 < 16)
				{
					if (num2 < 2)
					{
						num3 = 24;
						num = 4;
					}
					else
					{
						num = 9;
					}
					break;
				}
				num3 = 0;
				num = 23;
				if (nHNLFjDZItikjQuZ0P9())
				{
					break;
				}
				goto case 3;
			case 3:
				id = NFQbrqD8Pn3dqKcuJbP(P_0);
				num = 27;
				if (0 == 0)
				{
					break;
				}
				goto case 27;
			case 27:
				num4 = NFQbrqD8Pn3dqKcuJbP(P_0);
				cellRow = NFQbrqD8Pn3dqKcuJbP(P_0);
				num = 29;
				break;
			case 6:
			case 16:
			case 18:
				DataCompression = (((num2 & 0x10) == 16) ? Compression.JPEG : Compression.None);
				Resolution = (CvsImageResolution)Math.Max(1, num2 & 0xF);
				ReceivedImageHeight = gLvDkmUhw0ethhhpUZi(1, CroppedImageHeight / (int)Resolution);
				num = 13;
				break;
			case 11:
				aRow = yd6tfHUsgqVoHLFajIY(P_0);
				num = 30;
				if (KTH1w3DJ7Q9gYdY2ETq())
				{
				}
				break;
			case 21:
				BytesPerPixel = 3;
				num = 18;
				break;
			case 14:
				BytesPerPixel = 1;
				num = 16;
				break;
			case 24:
			case 32:
				SegmentPixelCount = ReceivedImageWidth * ReceivedImageHeight * BytesPerPixel / JpegSegmentCount;
				goto case 17;
			case 10:
			case 33:
				AcquiredImageStartColumn = CroppedImageStartColumn;
				num = 15;
				break;
			case 2:
				aTheta = yd6tfHUsgqVoHLFajIY(P_0);
				num = 20;
				break;
			case 36:
				{
					return true;
				}
				end_IL_0252:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool BRJb6FPEN8(BinaryReader P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 14;
		if (!KTH1w3DJ7Q9gYdY2ETq())
		{
		}
		int num4 = default;
		int num5 = default;
		while (true)
		{
			switch (num)
			{
			case 13:
				switch (num4)
				{
				case 21:
					goto IL_00d9;
				case 19:
					goto IL_00ef;
				case 16:
				case 17:
				case 18:
					goto IL_03ba;
				case 20:
					goto IL_03d9;
				}
				num = 16;
				if (nHNLFjDZItikjQuZ0P9())
				{
					break;
				}
				goto case 7;
			case 7:
				AcquiredImageHeight = CroppedImageHeight;
				num = 12;
				break;
			case 4:
			case 17:
				AcquiredImageStartColumn = P_0.ReadInt32();
				goto case 5;
			case 8:
				num5 -= 16;
				goto case 2;
			case 1:
				AcquiredImageStartRow = coqju7UwrRaflTD5qeq(P_0);
				KTH1w3DJ7Q9gYdY2ETq();
				num = (nHNLFjDZItikjQuZ0P9() ? 17 : 15);
				break;
			case 10:
				BytesPerPixel = 3;
				goto case 0;
			case 18:
				AcquiredImageStartColumn = CroppedImageStartColumn;
				num = 7;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 6:
			case 9:
				Resolution = CvsImageResolution.Full;
				SegmentPixelCount = SegmentPixelBytes / BytesPerPixel;
				num = 21;
				break;
			case 19:
			{
				int num2 = coqju7UwrRaflTD5qeq(P_0);
				int num3 = (int)uMLkH5ULQ6Eo1EJIjcC(NcIIdFUSBpYPSDyvqVr(P_0));
				id = NFQbrqD8Pn3dqKcuJbP(P_0);
				acqSeqNum = knNSSDUEHGyjNLjXAYV(P_0);
				cellRow = P_0.ReadInt16();
				cellCol = NFQbrqD8Pn3dqKcuJbP(P_0);
				segmentID = P_0.ReadInt16();
				lastSegmentID = NFQbrqD8Pn3dqKcuJbP(P_0);
				SegmentRows = NFQbrqD8Pn3dqKcuJbP(P_0);
				P_0.ReadInt16();
				CroppedImageStartRow = coqju7UwrRaflTD5qeq(P_0);
				CroppedImageStartColumn = coqju7UwrRaflTD5qeq(P_0);
				CroppedImageHeight = coqju7UwrRaflTD5qeq(P_0);
				CroppedImageWidth = coqju7UwrRaflTD5qeq(P_0);
				aRow = P_0.ReadSingle();
				aCol = yd6tfHUsgqVoHLFajIY(P_0);
				aHigh = yd6tfHUsgqVoHLFajIY(P_0);
				aWide = yd6tfHUsgqVoHLFajIY(P_0);
				aTheta = P_0.ReadSingle();
				aPhi = yd6tfHUsgqVoHLFajIY(P_0);
				ReceivedImageHeight = coqju7UwrRaflTD5qeq(P_0);
				ReceivedImageWidth = coqju7UwrRaflTD5qeq(P_0);
				ImageScalingMethod = coqju7UwrRaflTD5qeq(P_0);
				ImageCompression = P_0.ReadInt32();
				ImageOrientation = coqju7UwrRaflTD5qeq(P_0);
				num4 = coqju7UwrRaflTD5qeq(P_0);
				num5 = num2 - ((int)uMLkH5ULQ6Eo1EJIjcC(NcIIdFUSBpYPSDyvqVr(P_0)) - num3);
				num = 3;
				if (!KTH1w3DJ7Q9gYdY2ETq())
				{
					break;
				}
				goto case 2;
			}
			case 2:
			{
				object obj = NcIIdFUSBpYPSDyvqVr(P_0);
				NncnYpU9dL3gTvfiXGa(obj, uMLkH5ULQ6Eo1EJIjcC(obj) + num5);
				num = 11;
				if (nHNLFjDZItikjQuZ0P9())
				{
					break;
				}
				goto case 3;
			}
			case 3:
				if (num5 < 16)
				{
					AcquiredImageStartRow = CroppedImageStartRow;
					num = 18;
					if (true)
					{
						break;
					}
					goto case 1;
				}
				num = 1;
				if (0 == 0)
				{
					break;
				}
				goto case 11;
			case 11:
				SegmentPixelBytes = coqju7UwrRaflTD5qeq(P_0);
				num = 13;
				if (nHNLFjDZItikjQuZ0P9())
				{
					break;
				}
				goto case 20;
			case 20:
				BytesPerPixel = 4;
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 12;
			case 12:
				AcquiredImageWidth = CroppedImageWidth;
				goto case 2;
			default:
				num = 2;
				if (0 == 0)
				{
					break;
				}
				goto case 14;
			case 14:
				flags = P_0.ReadInt16();
				num = 19;
				break;
			case 5:
			case 15:
				AcquiredImageHeight = coqju7UwrRaflTD5qeq(P_0);
				AcquiredImageWidth = coqju7UwrRaflTD5qeq(P_0);
				num = 8;
				if (nHNLFjDZItikjQuZ0P9())
				{
					break;
				}
				goto IL_03ba;
			case 16:
				goto IL_03ba;
			case 21:
				{
					return true;
				}
				IL_00d9:
				PixelFormat = CnxPixelFormat.Format32bppRgb;
				num = 20;
				break;
				IL_03d9:
				PixelFormat = CnxPixelFormat.Format24bppRgb;
				num = 10;
				break;
				IL_03ba:
				PixelFormat = CnxPixelFormat.Format8bppGrayscale;
				BytesPerPixel = 1;
				num = 9;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
				IL_00ef:
				PixelFormat = CnxPixelFormat.Format16bppRgb565;
				BytesPerPixel = 2;
				num = 0;
				if (0 == 0)
				{
					break;
				}
				goto case 18;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsGraphicRegion GetClippingRegion()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicRegion(new CvsCellLocation(cellRow, cellCol), new PointF(aCol, aRow), aHigh, aWide, aTheta, aPhi, string.Empty);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ImageConfig()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		nssCO7UvEbK9I5CcE2T(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nHNLFjDZItikjQuZ0P9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool KTH1w3DJ7Q9gYdY2ETq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static short NFQbrqD8Pn3dqKcuJbP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BinaryReader)P_0).ReadInt16();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte E2eFQiDzh6ImRscvjK0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BinaryReader)P_0).ReadByte();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int coqju7UwrRaflTD5qeq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BinaryReader)P_0).ReadInt32();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float yd6tfHUsgqVoHLFajIY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BinaryReader)P_0).ReadSingle();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int gLvDkmUhw0ethhhpUZi(int P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Max(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long uMLkH5ULQ6Eo1EJIjcC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Stream)P_0).Position;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NncnYpU9dL3gTvfiXGa(object P_0, long P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Position = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NcIIdFUSBpYPSDyvqVr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BinaryReader)P_0).BaseStream;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ushort knNSSDUEHGyjNLjXAYV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BinaryReader)P_0).ReadUInt16();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nssCO7UvEbK9I5CcE2T(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
