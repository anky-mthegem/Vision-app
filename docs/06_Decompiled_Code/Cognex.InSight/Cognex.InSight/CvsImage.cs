using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using Cognex.Cnx.ComponentModel;
using Cognex.Cnx.ComponentModel.Implementation;
using Cognex.Cnx.Imaging;
using Cognex.InSight.Graphic;
using Cognex.InSight.Internal;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

[Serializable]
public sealed class CvsImage : ISerializable, IDisposable, IServiceProvider
{
	private enum cYMeWjlSTcsR9PMhhH
	{

	}

	private class kSxcPoEESQaymreoRM : ICnxReferenceCount, IDisposable
	{
		private readonly CvsImage U8f7Frgb4I;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public kSxcPoEESQaymreoRM(CvsImage P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Vlh6PJsS5kYbjxUPrM9L();
			int num = (ONsnVTsSoYFnV0SmxecY() ? 3 : 4);
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					base._002Ector();
					break;
				default:
					num = 2;
					continue;
				case 0:
				case 4:
					uAGkOfsSPGLetCc2bnPq();
					goto case 1;
				case 2:
					break;
				case 5:
					return;
				}
				U8f7Frgb4I = P_0;
				num = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int AddReference()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aMblOrsSYdFUKUDOYgfu(U8f7Frgb4I);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			MRr8RnsSNaUJC0NEIFvx(U8f7Frgb4I);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void uAGkOfsSPGLetCc2bnPq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Vlh6PJsS5kYbjxUPrM9L()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ONsnVTsSoYFnV0SmxecY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int aMblOrsSYdFUKUDOYgfu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsImage)P_0).AddReference();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MRr8RnsSNaUJC0NEIFvx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsImage)P_0).Dispose();
		}
	}

	private CnxPixelFormat odDbE4PegM;

	private int ql4bQFFhkP;

	private int HLFbN7GmH6;

	private int Bb3bij53ng;

	private int ilmbdSdw4V;

	private Rectangle TjvbulSg1f;

	private Rectangle BHSbGkyuLu;

	private int A5xbDi9l2s;

	private int xmebe2xhyS;

	[NonSerialized]
	private CnxReferenceHandle<ICvsImageBuffer> ca5bSLvXv8;

	[NonSerialized]
	private CvsImageResolution RIybrnCv98;

	[NonSerialized]
	private int UElbCaID26;

	[NonSerialized]
	private int dkqb2Eg6AR;

	private int oIibyMTc0K;

	public CnxPixelFormat PixelFormat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return odDbE4PegM;
		}
	}

	public int Height
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HLFbN7GmH6;
		}
	}

	public int Width
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ql4bQFFhkP;
		}
	}

	public CvsCellLocation Location
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new CvsCellLocation(Bb3bij53ng, ilmbdSdw4V);
		}
	}

	public int StartRow
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TjvbulSg1f.Y;
		}
	}

	public int StartColumn
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TjvbulSg1f.X;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public int AcquiredWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TjvbulSg1f.Width;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public int AcquiredHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TjvbulSg1f.Height;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public Rectangle CroppedRegion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return BHSbGkyuLu;
		}
	}

	[Obsolete]
	public CvsImageResolution Resolution
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return RIybrnCv98;
		}
	}

	public int ResolutionScale
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (UElbCaID26 == 0)
			{
				return 1;
			}
			return Math.Max(BHSbGkyuLu.Width / UElbCaID26, 1);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsGraphicRegion ClippingRegion
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

	[EditorBrowsable(EditorBrowsableState.Never)]
	public int Id
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return A5xbDi9l2s;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public int AcqSeqNum
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xmebe2xhyS;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public ICvsImageBuffer Buffer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ca5bSLvXv8.Get();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsImage()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				DKTs5QUD2otRx1uQoQM(this);
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto case 6;
			case 6:
				odDbE4PegM = CnxPixelFormat.Format8bppGrayscale;
				num = 0;
				if (EZFWpaUVGpdliQkdfKJ())
				{
				}
				continue;
			case 5:
				CHEJZ5UAAxUD9yX8DHZ();
				num = 6;
				continue;
			case 0:
				ql4bQFFhkP = 640;
				break;
			case 1:
			case 3:
				HLFbN7GmH6 = 480;
				goto case 2;
			case 7:
				return;
			}
			BMGE0BUH4ghZRkfE71X();
			num = ((!EZFWpaUVGpdliQkdfKJ()) ? 1 : 2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Initialize(int width, int height, CnxPixelFormat format)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		while (true)
		{
			switch (num)
			{
			case 8:
				Bb3bij53ng = 0;
				_ = 0;
				if (BMGE0BUH4ghZRkfE71X())
				{
					num = 10;
					continue;
				}
				num = 7;
				if (EZFWpaUVGpdliQkdfKJ())
				{
				}
				continue;
			case 3:
			case 7:
				ql4bQFFhkP = width;
				num = 5;
				if (EZFWpaUVGpdliQkdfKJ())
				{
				}
				continue;
			case 2:
			case 10:
				ilmbdSdw4V = 0;
				goto case 3;
			case 5:
				HLFbN7GmH6 = height;
				break;
			default:
				num = 0;
				if (EZFWpaUVGpdliQkdfKJ())
				{
				}
				continue;
			case 4:
				NkEbHUqoEn(format);
				num = 11;
				continue;
			case 6:
				odDbE4PegM = format;
				num = 8;
				continue;
			case 9:
				RIybrnCv98 = CvsImageResolution.Full;
				num = 4;
				continue;
			case 1:
				BHSbGkyuLu = TjvbulSg1f;
				num = 9;
				continue;
			case 0:
				break;
			case 11:
				return;
			}
			TjvbulSg1f = new Rectangle(0, 0, ql4bQFFhkP, HLFbN7GmH6);
			num = 1;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void SetImageRegion(Rectangle region)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		TjvbulSg1f = region;
		BHSbGkyuLu = region;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CvsImage(SerializationInfo info, StreamingContext context)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		Array array = default;
		while (true)
		{
			switch (num)
			{
			case 13:
				try
				{
					BHSbGkyuLu = (Rectangle)LFqArmUil0ZMwvFC0yN(info, Rv3CW9UU0Lt0QmKouKb(8746), NBXFvGUBNOgcmGrtN15(BHSbGkyuLu));
				}
				catch
				{
					BHSbGkyuLu = TjvbulSg1f;
				}
				NkEbHUqoEn(odDbE4PegM);
				num = 14;
				break;
			case 7:
				HLFbN7GmH6 = H6X2LPUqkbbQ0047F7T(array, 1);
				num = 4;
				break;
			case 12:
				ilmbdSdw4V = YvuH0EUTGqBuDjSXdhZ(info, Rv3CW9UU0Lt0QmKouKb(8662));
				num = 1;
				break;
			case 0:
			case 2:
				ql4bQFFhkP = 640;
				goto case 3;
			case 1:
				array = (Array)LFqArmUil0ZMwvFC0yN(info, Rv3CW9UU0Lt0QmKouKb(8680), W6bo7ZUd75bmbNOsAQ4(typeof(Array).TypeHandle));
				goto case 9;
			default:
				num = 9;
				break;
			case 9:
				ql4bQFFhkP = H6X2LPUqkbbQ0047F7T(array, 0);
				num = 7;
				break;
			case 5:
				base._002Ector();
				odDbE4PegM = (CnxPixelFormat)info.GetInt32((string)Rv3CW9UU0Lt0QmKouKb(8618));
				Bb3bij53ng = YvuH0EUTGqBuDjSXdhZ(info, Rv3CW9UU0Lt0QmKouKb(8644));
				num = 12;
				if (true)
				{
					break;
				}
				goto case 8;
			case 8:
				RIybrnCv98 = (CvsImageResolution)YvuH0EUTGqBuDjSXdhZ(info, Rv3CW9UU0Lt0QmKouKb(8722));
				num = 13;
				break;
			case 3:
			case 10:
				HLFbN7GmH6 = 480;
				num = 5;
				if (BMGE0BUH4ghZRkfE71X())
				{
					break;
				}
				goto case 11;
			case 11:
				odDbE4PegM = CnxPixelFormat.Format8bppGrayscale;
				BMGE0BUH4ghZRkfE71X();
				num = (EZFWpaUVGpdliQkdfKJ() ? 10 : 0);
				break;
			case 6:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 11;
				break;
			case 4:
				TjvbulSg1f = (Rectangle)info.GetValue((string)Rv3CW9UU0Lt0QmKouKb(8696), NBXFvGUBNOgcmGrtN15(TjvbulSg1f));
				num = 8;
				break;
			case 14:
				tuxKcJUjjjTHVpQgMlh(Buffer, array, 0, odDbE4PegM, new Point(0, 0), array.Length);
				num = 15;
				break;
			case 15:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsImage(ICvsImageBuffer imageBuffer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = ((!EZFWpaUVGpdliQkdfKJ()) ? 1 : 6);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 10;
				if (true)
				{
					continue;
				}
				goto case 13;
			case 13:
				HLFbN7GmH6 = QRD4beU2jy0s0Z2VtSa(imageBuffer).Height;
				num = 4;
				continue;
			case 8:
				ca5bSLvXv8.Set(imageBuffer);
				num = 15;
				continue;
			case 14:
				odDbE4PegM = hOM2GeUcjlyFRfVaCK1(imageBuffer);
				Bb3bij53ng = 0;
				num = 11;
				continue;
			case 5:
				ql4bQFFhkP = 640;
				HLFbN7GmH6 = 480;
				num = 9;
				continue;
			case 12:
				if (imageBuffer != null)
				{
					num = 14;
					continue;
				}
				return;
			case 9:
				DKTs5QUD2otRx1uQoQM(this);
				num = 12;
				if (BMGE0BUH4ghZRkfE71X())
				{
					continue;
				}
				goto case 11;
			case 11:
				ilmbdSdw4V = 0;
				break;
			case 4:
				TjvbulSg1f = new Rectangle(0, 0, ql4bQFFhkP, HLFbN7GmH6);
				num = 3;
				continue;
			case 3:
				BHSbGkyuLu = TjvbulSg1f;
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				goto case 2;
			case 2:
				RIybrnCv98 = CvsImageResolution.Full;
				num = 8;
				continue;
			case 10:
				odDbE4PegM = CnxPixelFormat.Format8bppGrayscale;
				num = 5;
				continue;
			case 15:
				return;
			}
			ql4bQFFhkP = QRD4beU2jy0s0Z2VtSa(imageBuffer).Width;
			num = 13;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CvsImage(ICvsImageBuffer imageBuffer, RectangleF acqRect, RectangleF cropRect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 7:
				ql4bQFFhkP = 640;
				num = 10;
				break;
			case 3:
				if (imageBuffer != null)
				{
					num = 5;
					break;
				}
				return;
			case 4:
				TjvbulSg1f = new Rectangle((int)Math.Round(acqRect.X, MidpointRounding.AwayFromZero), (int)k9kkOxUWOPlVPcM3KYT(acqRect.Y, MidpointRounding.AwayFromZero), (int)k9kkOxUWOPlVPcM3KYT(acqRect.Width, MidpointRounding.AwayFromZero), (int)k9kkOxUWOPlVPcM3KYT(acqRect.Height, MidpointRounding.AwayFromZero));
				BHSbGkyuLu = new Rectangle((int)k9kkOxUWOPlVPcM3KYT(cropRect.X, MidpointRounding.AwayFromZero), (int)Math.Round(cropRect.Y, MidpointRounding.AwayFromZero), (int)k9kkOxUWOPlVPcM3KYT(cropRect.Width, MidpointRounding.AwayFromZero), (int)k9kkOxUWOPlVPcM3KYT(cropRect.Height, MidpointRounding.AwayFromZero));
				goto case 6;
			case 0:
			case 8:
				ql4bQFFhkP = QRD4beU2jy0s0Z2VtSa(imageBuffer).Width;
				num = 13;
				break;
			case 9:
				dkqb2Eg6AR = HLFbN7GmH6;
				num = 4;
				if (!EZFWpaUVGpdliQkdfKJ())
				{
					break;
				}
				goto case 14;
			case 14:
				ca5bSLvXv8.Set(imageBuffer);
				num = 16;
				if (!EZFWpaUVGpdliQkdfKJ())
				{
					break;
				}
				goto case 6;
			case 6:
			case 12:
				RIybrnCv98 = CvsImageResolution.Full;
				num = 14;
				break;
			case 1:
				base._002Ector();
				num = 3;
				if (true)
				{
					break;
				}
				goto case 10;
			case 10:
				HLFbN7GmH6 = 480;
				num = 1;
				if (!EZFWpaUVGpdliQkdfKJ())
				{
					break;
				}
				goto case 15;
			case 15:
				odDbE4PegM = CnxPixelFormat.Format8bppGrayscale;
				num = 7;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 15;
				break;
			case 13:
				HLFbN7GmH6 = imageBuffer.Size.Height;
				UElbCaID26 = ql4bQFFhkP;
				num = 9;
				if (BMGE0BUH4ghZRkfE71X())
				{
					break;
				}
				goto case 11;
			case 11:
				Bb3bij53ng = 0;
				ilmbdSdw4V = 0;
				goto default;
			default:
				BMGE0BUH4ghZRkfE71X();
				num = (EZFWpaUVGpdliQkdfKJ() ? 6 : 0);
				break;
			case 5:
				odDbE4PegM = hOM2GeUcjlyFRfVaCK1(imageBuffer);
				num = 11;
				break;
			case 16:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public int AddReference()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ++oIibyMTc0K;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
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
			case 4:
				oIibyMTc0K--;
				_ = 1;
				if (!EZFWpaUVGpdliQkdfKJ())
				{
					num = 3;
					if (true)
					{
						break;
					}
					goto case 1;
				}
				num = 0;
				if (!EZFWpaUVGpdliQkdfKJ())
				{
					break;
				}
				goto default;
			case 1:
			case 3:
				if (oIibyMTc0K < 1)
				{
					goto default;
				}
				return;
			default:
				r05bKoW9WX(_0020: true);
				num = 5;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_00e1;
		IL_001a:
		info.AddValue((string)Rv3CW9UU0Lt0QmKouKb(8618), (int)odDbE4PegM);
		num = 7;
		goto IL_00e1;
		IL_00e1:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 8:
				dbi2v7U75WLWhK3AMsc(info, Rv3CW9UU0Lt0QmKouKb(8722), (int)RIybrnCv98);
				num = 6;
				continue;
			case 2:
			case 5:
				dbi2v7U75WLWhK3AMsc(info, Rv3CW9UU0Lt0QmKouKb(8662), ilmbdSdw4V);
				num = 3;
				if (true)
				{
					continue;
				}
				goto default;
			default:
				wKQQakUKQvIe9L25hVk(info, Rv3CW9UU0Lt0QmKouKb(8696), TjvbulSg1f, NBXFvGUBNOgcmGrtN15(TjvbulSg1f));
				num = 8;
				if (0 == 0)
				{
					continue;
				}
				goto case 3;
			case 3:
				D9sjlVUCcf9i489SZYS(info, Rv3CW9UU0Lt0QmKouKb(8680), DSJwP2UthsMqYmkgw0Q(Buffer, 2));
				goto default;
			case 6:
				info.AddValue((string)Rv3CW9UU0Lt0QmKouKb(8746), BHSbGkyuLu, NBXFvGUBNOgcmGrtN15(BHSbGkyuLu));
				num = 9;
				if (BMGE0BUH4ghZRkfE71X())
				{
					continue;
				}
				goto case 7;
			case 7:
				dbi2v7U75WLWhK3AMsc(info, kgbOBx7BanbFa22Hp9.ol99ukmDA(8644), Bb3bij53ng);
				_ = 0;
				if (!BMGE0BUH4ghZRkfE71X())
				{
					num = 0;
					continue;
				}
				num = 5;
				if (EZFWpaUVGpdliQkdfKJ())
				{
					return;
				}
				continue;
			case 9:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bitmap ToBitmap()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Bitmap)CdijrqU5aZdbu5j3fBM(Buffer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Save(string fileName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		w7DcpPUoRAJLwwe6s1F(Buffer, fileName);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Save(string filename, ImageFormat format)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Bitmap bitmap = ToBitmap();
		try
		{
			MtipI1UPRTKfBTmgRWg(bitmap, filename, format);
		}
		finally
		{
			if (bitmap != null)
			{
				Qm7Y98UYiN3twMc033Y(bitmap);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color GetPixel(int row, int column)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Buffer.GetPixel(column, row);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte GetPixelGrayscale(int row, int column)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Color color = m1cAeqUNFmOYeZ3tOX6(Buffer, column, row);
		return (byte)((color.R + color.G + color.B) / 3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NkEbHUqoEn(CnxPixelFormat P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ICvsImageBuffer obj = (ICvsImageBuffer)iU3yVYUxgoLGVOLlsfB(new Size(ql4bQFFhkP, HLFbN7GmH6), P_0);
		ca5bSLvXv8.Set(obj);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void r05bKoW9WX(bool P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!EZFWpaUVGpdliQkdfKJ())
		{
			num = 3;
			if (EZFWpaUVGpdliQkdfKJ())
			{
			}
		}
		else
		{
			num = 4;
		}
		bool lockTaken = default;
		CvsImage obj = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				lockTaken = false;
				num = 5;
				if (BMGE0BUH4ghZRkfE71X())
				{
					break;
				}
				goto case 1;
			case 1:
			case 4:
				obj = this;
				goto case 2;
			default:
				num = 2;
				break;
			case 0:
			case 3:
				if (P_0)
				{
					goto case 1;
				}
				return;
			case 5:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					ca5bSLvXv8.Set(null);
					return;
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	object IServiceProvider.GetService(Type serviceType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (Q2R64eU1Ci68VMb6Edk(serviceType, W6bo7ZUd75bmbNOsAQ4(typeof(ICnxReferenceCount).TypeHandle)))
		{
			return new kSxcPoEESQaymreoRM(this);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CHEJZ5UAAxUD9yX8DHZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DKTs5QUD2otRx1uQoQM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BMGE0BUH4ghZRkfE71X()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EZFWpaUVGpdliQkdfKJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Rv3CW9UU0Lt0QmKouKb(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int YvuH0EUTGqBuDjSXdhZ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SerializationInfo)P_0).GetInt32((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type W6bo7ZUd75bmbNOsAQ4(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LFqArmUil0ZMwvFC0yN(object P_0, object P_1, Type P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SerializationInfo)P_0).GetValue((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int H6X2LPUqkbbQ0047F7T(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Array)P_0).GetLength(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type NBXFvGUBNOgcmGrtN15(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0.GetType();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tuxKcJUjjjTHVpQgMlh(object P_0, object P_1, int startIndex, CnxPixelFormat rawPixelFormat, Point location, int pixelCount)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ICvsImageBuffer)P_0).WritePixels((Array)P_1, startIndex, rawPixelFormat, location, pixelCount);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CnxPixelFormat hOM2GeUcjlyFRfVaCK1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ICvsImageBuffer)P_0).PixelFormat;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Size QRD4beU2jy0s0Z2VtSa(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ICvsImageBuffer)P_0).Size;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double k9kkOxUWOPlVPcM3KYT(double P_0, MidpointRounding P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Round(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dbi2v7U75WLWhK3AMsc(object P_0, object P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DSJwP2UthsMqYmkgw0Q(object P_0, int dimensions)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ICvsImageBuffer)P_0).GetPixels(dimensions);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void D9sjlVUCcf9i489SZYS(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wKQQakUKQvIe9L25hVk(object P_0, object P_1, object P_2, Type P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SerializationInfo)P_0).AddValue((string)P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CdijrqU5aZdbu5j3fBM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ICvsImageBuffer)P_0).ToBitmap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void w7DcpPUoRAJLwwe6s1F(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ICvsImageBuffer)P_0).Save((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MtipI1UPRTKfBTmgRWg(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Image)P_0).Save((string)P_1, (ImageFormat)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Qm7Y98UYiN3twMc033Y(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color m1cAeqUNFmOYeZ3tOX6(object P_0, int x, int y)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ICvsImageBuffer)P_0).GetPixel(x, y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iU3yVYUxgoLGVOLlsfB(Size size, CnxPixelFormat format)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsImageBufferFactory.CreateNew(size, format);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Q2R64eU1Ci68VMb6Edk(Type P_0, Type P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}
}
