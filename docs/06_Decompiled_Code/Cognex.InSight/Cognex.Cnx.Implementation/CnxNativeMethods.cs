using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using Cognex.Cnx.Diagnostics;
using Cognex.Cnx.Geometry;
using Cognex.Cnx.Imaging;
using Cognex.Cnx.Imaging.Implementation;
using Cognex.Explorer.Diagnostics;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.Cnx.Implementation;

[SuppressUnmanagedCodeSecurity]
public static class CnxNativeMethods
{
	public struct SIZE
	{
		public int cx;

		public int cy;
	}

	public struct RECT
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;

		public int Width
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return Right - Left;
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
				return Bottom - Top;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RECT(int left, int top, int right, int bottom)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NDijFUgK7Bbj4Emb33t();
			int num = ((!LiYXNPgCQHtIIq93r7N()) ? 5 : 3);
			while (true)
			{
				switch (num)
				{
				case 6:
					Right = right;
					num = 1;
					continue;
				case 2:
				case 5:
					Top = top;
					goto case 6;
				default:
					num = 6;
					continue;
				case 4:
					Left = left;
					goto case 2;
				case 0:
				case 3:
					VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 1:
					break;
				case 7:
					return;
				}
				Bottom = bottom;
				num = 7;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)e7waVxgPsXSKYOXkSBa(new string[9]
			{
				(string)JwxjxDg5bMOZWudcDdE(48226),
				Left.ToString((IFormatProvider)yrAPJRgo4wyRhkn6PRb()),
				(string)JwxjxDg5bMOZWudcDdE(714),
				Top.ToString(CultureInfo.CurrentCulture),
				kgbOBx7BanbFa22Hp9.ol99ukmDA(48236),
				Width.ToString((IFormatProvider)yrAPJRgo4wyRhkn6PRb()),
				(string)JwxjxDg5bMOZWudcDdE(48254),
				Height.ToString((IFormatProvider)yrAPJRgo4wyRhkn6PRb()),
				(string)JwxjxDg5bMOZWudcDdE(5896)
			});
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator CnxRectangle(RECT r)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new CnxRectangle(r.Left, r.Top, r.Width, r.Height);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator RECT(CnxRectangle r)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new RECT(r.X, r.Y, r.LastX, r.LastY);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LiYXNPgCQHtIIq93r7N()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NDijFUgK7Bbj4Emb33t()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JwxjxDg5bMOZWudcDdE(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yrAPJRgo4wyRhkn6PRb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CultureInfo.CurrentCulture;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object e7waVxgPsXSKYOXkSBa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Concat((string[])P_0);
		}
	}

	public struct XFORM
	{
		public float eM11;

		public float eM12;

		public float eM21;

		public float eM22;

		public float eDx;

		public float eDy;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public XFORM(float[] e)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (!R28HurgNmORSsa1lQ51())
			{
			}
			do
			{
				IL_0110:
				switch (num)
				{
				case 7:
					eM12 = 0f;
					eM21 = 0f;
					num = 11;
					if (0 == 0)
					{
						goto IL_0110;
					}
					goto case 13;
				case 13:
					eM21 = e[2];
					break;
				case 3:
					eDy = e[5];
					return;
				case 10:
					eDx = 0f;
					num = 12;
					goto IL_0110;
				case 0:
					yyYNWCgxgpDNGBKTuZO();
					R28HurgNmORSsa1lQ51();
					if (!GRoa7BgYhaFIbhxwy2E())
					{
						num = 4;
						goto IL_0110;
					}
					num = 2;
					if (!R28HurgNmORSsa1lQ51())
					{
						goto IL_0110;
					}
					goto case 9;
				case 9:
					eM12 = e[1];
					num = 13;
					goto IL_0110;
				case 12:
					eDy = 0f;
					num = 14;
					if (0 == 0)
					{
						goto IL_0110;
					}
					goto case 8;
				case 8:
					eM11 = e[0];
					num = 9;
					goto IL_0110;
				case 6:
					eDx = e[4];
					goto case 3;
				default:
					num = 3;
					goto IL_0110;
				case 1:
				case 2:
					if (e == null)
					{
						eM11 = 1f;
						num = 7;
						if (true)
						{
							goto IL_0110;
						}
						goto case 10;
					}
					num = 8;
					goto IL_0110;
				case 11:
					eM22 = 1f;
					num = 10;
					goto IL_0110;
				case 4:
				case 5:
					break;
				case 14:
					return;
				}
				eM22 = e[3];
				num = 6;
			}
			while (0 == 0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yyYNWCgxgpDNGBKTuZO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GRoa7BgYhaFIbhxwy2E()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool R28HurgNmORSsa1lQ51()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public struct BITMAPINFOHEADER
	{
		public int biSize;

		public int biWidth;

		public int biHeight;

		public short biPlanes;

		public short biBitCount;

		public int biCompression;

		public int biSizeImage;

		public int biXPelsPerMeter;

		public int biYPelsPerMeter;

		public int biClrUsed;

		public int biClrImportant;

		public const int StreamedSize = 40;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Write(BinaryWriter bw)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 11:
					YaS7SJg34DWVTwHS9iM(bw, biXPelsPerMeter);
					break;
				case 3:
					YaS7SJg34DWVTwHS9iM(bw, biSize);
					num = 8;
					if (true)
					{
						continue;
					}
					goto case 5;
				case 5:
					YaS7SJg34DWVTwHS9iM(bw, biClrUsed);
					num = 0;
					if (HfSBIqg1ClxmYjvJeLY())
					{
						continue;
					}
					goto case 1;
				case 1:
					bw.Write(biSizeImage);
					goto case 11;
				default:
					num = 11;
					continue;
				case 8:
					YaS7SJg34DWVTwHS9iM(bw, biWidth);
					num = 9;
					continue;
				case 4:
				case 10:
					OZ63PMgOvEEKxN3ZrTW(bw, biBitCount);
					YaS7SJg34DWVTwHS9iM(bw, biCompression);
					num = 1;
					if (HfSBIqg1ClxmYjvJeLY())
					{
						continue;
					}
					goto case 0;
				case 0:
					YaS7SJg34DWVTwHS9iM(bw, biClrImportant);
					num = 12;
					if (H4qV6hgrm3lxM6malx1())
					{
					}
					continue;
				case 9:
					YaS7SJg34DWVTwHS9iM(bw, biHeight);
					num = 6;
					if (HfSBIqg1ClxmYjvJeLY())
					{
						continue;
					}
					goto case 6;
				case 6:
					bw.Write(biPlanes);
					H4qV6hgrm3lxM6malx1();
					num = (HfSBIqg1ClxmYjvJeLY() ? 10 : 2);
					continue;
				case 2:
				case 7:
					break;
				case 12:
					return;
				}
				YaS7SJg34DWVTwHS9iM(bw, biYPelsPerMeter);
				num = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Read(BinaryReader br)
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
			goto IL_00ff;
			IL_001a:
			if (biSize < 40)
			{
				num = 7;
			}
			else
			{
				biWidth = br.ReadInt32();
				num = 4;
			}
			goto IL_00ff;
			IL_00ff:
			while (true)
			{
				switch (num)
				{
				case 11:
					break;
				case 4:
					biHeight = HR2AupgMVgjPyrKi3Jd(br);
					num = 10;
					continue;
				case 12:
					biSizeImage = HR2AupgMVgjPyrKi3Jd(br);
					num = 8;
					continue;
				case 2:
				case 9:
					biYPelsPerMeter = HR2AupgMVgjPyrKi3Jd(br);
					num = 6;
					continue;
				case 1:
					biSize = HR2AupgMVgjPyrKi3Jd(br);
					num = 11;
					continue;
				case 7:
					throw new ApplicationException((string)U7kDZtgQPhbFrshq79N(48274));
				case 8:
					biXPelsPerMeter = HR2AupgMVgjPyrKi3Jd(br);
					goto case 2;
				case 0:
					biCompression = HR2AupgMVgjPyrKi3Jd(br);
					num = 12;
					continue;
				case 3:
				case 5:
					biBitCount = W4gtXWglwCf28EcMujj(br);
					goto case 0;
				default:
					num = 0;
					continue;
				case 6:
					biClrUsed = HR2AupgMVgjPyrKi3Jd(br);
					biClrImportant = HR2AupgMVgjPyrKi3Jd(br);
					num = 13;
					continue;
				case 10:
					biPlanes = W4gtXWglwCf28EcMujj(br);
					_ = 0;
					num = (HfSBIqg1ClxmYjvJeLY() ? 3 : 2);
					continue;
				case 13:
					return;
				}
				break;
			}
			goto IL_001a;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void YaS7SJg34DWVTwHS9iM(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BinaryWriter)P_0).Write(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void OZ63PMgOvEEKxN3ZrTW(object P_0, short P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BinaryWriter)P_0).Write(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HfSBIqg1ClxmYjvJeLY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool H4qV6hgrm3lxM6malx1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int HR2AupgMVgjPyrKi3Jd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BinaryReader)P_0).ReadInt32();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object U7kDZtgQPhbFrshq79N(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static short W4gtXWglwCf28EcMujj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BinaryReader)P_0).ReadInt16();
		}
	}

	public struct BITMAPINFO
	{
		public BITMAPINFOHEADER bmiHeader;

		public int bmiColors0;

		private readonly int ByNfywgjN3;

		private readonly int jGEfVyUndn;

		private readonly int uAFfvetVCH;

		private readonly int jBAfZdlYa8;

		private readonly int OlQf8AJFiF;

		private readonly int H2afzVUohF;

		private readonly int VZpjPQRKgB;

		private readonly int Y4hjIgIXus;

		private readonly int zmNj1pX3Fu;

		private readonly int tc0jx0Ol8O;

		private readonly int n3BjF2TCwJ;

		private readonly int NuhjbfnnqY;

		private readonly int TRUjae6Tp6;

		private readonly int Y8bjOaqoFG;

		private readonly int ubSjpEZ0jJ;

		private readonly int zmajhYun2h;

		private readonly int SKvj4bLCpy;

		private readonly int mS2jl0X0mv;

		private readonly int d2LjgvpxU0;

		private readonly int trujqSTdSp;

		private readonly int o9VjTOIEia;

		private readonly int f10jB6OtPT;

		private readonly int lX5jJZYTLd;

		private readonly int BdwjMNf8XQ;

		private readonly int lY4joOw8Al;

		private readonly int iDTjAWtUuB;

		private readonly int JG3jtFfaEX;

		private readonly int vYajWfbKcp;

		private readonly int FJfj3jbOBB;

		private readonly int dF6jLgiikD;

		private readonly int rFLjkOEb03;

		private readonly int VgnjXEU1L6;

		private readonly int VdXjfeH4bP;

		private readonly int eH0jjGXGY3;

		private readonly int z89jcSTnmw;

		private readonly int FmZj5SCOAH;

		private readonly int TtxjY30bKR;

		private readonly int Qdej7Y6TRg;

		private readonly int HEOjmxAjYb;

		private readonly int CRWjnqt2gh;

		private readonly int y7dj9s10MP;

		private readonly int f32jUKKdNH;

		private readonly int yGGj0k9xEb;

		private readonly int E2njwFck4k;

		private readonly int f1ijRFnWGV;

		private readonly int hv4jsN3sKo;

		private readonly int cgbj6cCJrY;

		private readonly int otrjHtILTf;

		private readonly int gI3jKHR6U6;

		private readonly int RArjERCGLY;

		private readonly int gWAjQ3lksd;

		private readonly int NWsjNRFVHm;

		private readonly int KcjjiH9wBC;

		private readonly int kPrjdS9fvm;

		private readonly int UL8juPNaqG;

		private readonly int CCsjGNv8NM;

		private readonly int lcUjDfX8IN;

		private readonly int oyujeNHXoZ;

		private readonly int OdAjSPo0sw;

		private readonly int tB2jr0kyS9;

		private readonly int KrVjCKB9fb;

		private readonly int Q4ej2A071u;

		private readonly int PTvjy9MPmA;

		private readonly int YPdjVcrDdj;

		private readonly int sFxjvYi98i;

		private readonly int I0qjZZ0KYT;

		private readonly int TKEj8KdQlR;

		private readonly int oCujzTqxsv;

		private readonly int s7tcPyrONi;

		private readonly int C7kcIfvgYJ;

		private readonly int aq8c1Iybpq;

		private readonly int ES7cxBlQwL;

		private readonly int XCQcFJcwek;

		private readonly int dErcbG4wxT;

		private readonly int Dipca7iHtF;

		private readonly int xtocOYKyEI;

		private readonly int w33cpFrtlQ;

		private readonly int NAschvTeA0;

		private readonly int KeNc455DQp;

		private readonly int jfFclp5Nwx;

		private readonly int vNycg54oKZ;

		private readonly int TZacqEy0je;

		private readonly int i0pcTiKwDj;

		private readonly int VJWcB65Zp6;

		private readonly int zfqcJ5ZZqe;

		private readonly int c2ocM0wclX;

		private readonly int QJRcoKLT5l;

		private readonly int WMtcAScDof;

		private readonly int jTsctQRY5g;

		private readonly int gvMcWHDLNU;

		private readonly int NlZc3iRgVS;

		private readonly int nDLcLetryO;

		private readonly int s4OckND1Ux;

		private readonly int UBKcXoArlR;

		private readonly int b9Icfli4Wu;

		private readonly int gF8cjTVP1v;

		private readonly int oX1cckDSBh;

		private readonly int vSFc5HFI0j;

		private readonly int ICDcYaYsA3;

		private readonly int RnUc7YoPu7;

		private readonly int wQAcmNdhD2;

		private readonly int rsYcngw7wl;

		private readonly int na3c94ABlM;

		private readonly int WhFcUSC2oZ;

		private readonly int JPxc0HbFsH;

		private readonly int kFfcwX02gi;

		private readonly int PlYcRhqEjC;

		private readonly int o57csgeBRr;

		private readonly int sJYc6Yj2hc;

		private readonly int ij5cHDpQ0I;

		private readonly int yKvcKU8tSf;

		private readonly int QoNcE2giHT;

		private readonly int tSIcQcVTX2;

		private readonly int E6DcN7o4mA;

		private readonly int gBSciPaPd3;

		private readonly int lOscdDvQoP;

		private readonly int VefcuEXahH;

		private readonly int q0fcGF5OU5;

		private readonly int r3mcDuCwlk;

		private readonly int y3Dce7VMr8;

		private readonly int aFYcSWwnVn;

		private readonly int OaKcrleJHM;

		private readonly int MKZcCKokhQ;

		private readonly int npBc2fx2Id;

		private readonly int bZOcyaDMsb;

		private readonly int mUocVSKIdI;

		private readonly int xkIcvKBTmN;

		private readonly int ET0cZfnrKV;

		private readonly int z1vc8mYmOd;

		private readonly int q7Cczr2ED1;

		private readonly int B7x5Pr0uIu;

		private readonly int zER5ITKbUm;

		private readonly int pXf51K9WHY;

		private readonly int pJL5x94GGK;

		private readonly int E6Y5FEbeEt;

		private readonly int FbW5bOLkdH;

		private readonly int UJk5apubjr;

		private readonly int OKv5ODJJ9m;

		private readonly int xJW5po860D;

		private readonly int go25hM6hDT;

		private readonly int Mjn54v9l8p;

		private readonly int mDx5lB09iC;

		private readonly int ses5gwMaUU;

		private readonly int Y3b5qoqYHB;

		private readonly int NU65TJ8W6q;

		private readonly int rNY5BALnlq;

		private readonly int sOA5JSU1y7;

		private readonly int GrM5MITcFC;

		private readonly int Och5ovy0ys;

		private readonly int uhV5Afb2Rb;

		private readonly int QmB5txSJPb;

		private readonly int DWy5WUfDDC;

		private readonly int lV253sUUbn;

		private readonly int Xn65LN47sN;

		private readonly int wsT5kULqdU;

		private readonly int LNb5XdaD2e;

		private readonly int NIR5fZL0CI;

		private readonly int w9l5j8PD9P;

		private readonly int Cdr5c7Swxu;

		private readonly int Rje554jqna;

		private readonly int WrZ5YtQPXr;

		private readonly int YRP57He8Fv;

		private readonly int bTe5m7uIPV;

		private readonly int Vu25n7XUun;

		private readonly int FHJ59OqXd0;

		private readonly int iV35UAJjkq;

		private readonly int Kkc50kUEa1;

		private readonly int yyR5wk1CBd;

		private readonly int Q5e5Ruhw73;

		private readonly int ibt5skHkHD;

		private readonly int kkQ56O1AWq;

		private readonly int oqq5Hps8Ba;

		private readonly int omn5K5bVNu;

		private readonly int EA95EkdYmI;

		private readonly int Tjp5QwqYP6;

		private readonly int jhY5Nebb0c;

		private readonly int c9T5ir5PyB;

		private readonly int HrI5dvH2VE;

		private readonly int iC95u01rXu;

		private readonly int uyp5GFugaM;

		private readonly int VfZ5DoB5Ng;

		private readonly int NV55e7IMgH;

		private readonly int Hfe5SWcknx;

		private readonly int tXl5rtpxI1;

		private readonly int USe5CNmKX1;

		private readonly int tKY52xR0sZ;

		private readonly int dxD5yp5sDu;

		private readonly int QAM5VxnjIP;

		private readonly int LMr5vtIttO;

		private readonly int I4J5ZbRZqS;

		private readonly int Ovy58gDI7X;

		private readonly int lsj5zqZxD5;

		private readonly int kZlYPCqG7H;

		private readonly int ptLYIkuMCE;

		private readonly int jFbY1yUM3e;

		private readonly int U37YxOfDMm;

		private readonly int oDCYFYrk8q;

		private readonly int hPsYbChqmE;

		private readonly int PaHYaowBLu;

		private readonly int AuxYObnsTK;

		private readonly int iCaYpZm1wi;

		private readonly int dijYht3LqX;

		private readonly int npCY4D1LMe;

		private readonly int rdLYlgFC8E;

		private readonly int f21YgPoMHq;

		private readonly int lUcYqSM0Ox;

		private readonly int BntYTnuLcy;

		private readonly int bkfYBuLP6C;

		private readonly int glAYJ6gbNc;

		private readonly int cZBYMVELgL;

		private readonly int B98YoYbjcY;

		private readonly int PwbYAjNP85;

		private readonly int qtwYtAnPxZ;

		private readonly int bKyYWaYKMU;

		private readonly int wUcY3jF4Jm;

		private readonly int p6bYL1538c;

		private readonly int TBsYkNFIfo;

		private readonly int JxKYXP7nNG;

		private readonly int sqHYftuZkO;

		private readonly int Ja4YjZ7qmp;

		private readonly int Oe1YcKsRgx;

		private readonly int XUeY5UPgMk;

		private readonly int FagYYDq2a1;

		private readonly int M6WY7SGiuV;

		private readonly int LrwYm0rZJJ;

		private readonly int IL6YnICW0F;

		private readonly int Rk8Y9KomgY;

		private readonly int ndTYUB7R3B;

		private readonly int sx0Y079Be9;

		private readonly int C4GYwI14q7;

		private readonly int citYRcXLlv;

		private readonly int qEJYswkAlE;

		private readonly int Up7Y6eSKk7;

		private readonly int KvqYH7Xqe9;

		private readonly int MmSYKWohQb;

		private readonly int eVbYEYlQHu;

		private readonly int FwlYQRbvoP;

		private readonly int jRZYNue4AA;

		private readonly int YjDYi4NBWD;

		private readonly int V6YYdd2ZB4;

		private readonly int qcEYukbLB9;

		private readonly int TmeYGwhcvM;

		private readonly int fJ7YDllaO0;

		private readonly int HsHYesrB5u;

		private readonly int nkKYS3xDCS;

		private readonly int PxMYrs7FQo;

		private readonly int RKMYCngQa7;

		private readonly int lbLY2nURLg;

		private readonly int bAgYy7VAh2;

		private readonly int gooYVnfHsu;

		private readonly int AlYYvGT3SU;

		private readonly int kjVYZ3chri;

		private readonly int nNTY8cCbhQ;

		private readonly int gqFYzT7ZUv;

		private readonly int xpF7PcC3qT;

		public unsafe CnxPixelFormat PixelFormat
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//The blocks IL_001d, IL_002d, IL_0039, IL_0049, IL_0053, IL_005e, IL_006e, IL_0078, IL_0084, IL_0095, IL_009f, IL_00b4, IL_012d, IL_0139, IL_014e, IL_0158, IL_015a, IL_016a, IL_017a, IL_018b, IL_019b, IL_01a5, IL_01a7, IL_01b7, IL_01c1, IL_01d1, IL_01de, IL_01e0, IL_01f0, IL_0204, IL_021d, IL_0224, IL_0230, IL_023b, IL_0242, IL_0251, IL_0269, IL_0273, IL_027b, IL_0290, IL_02a0, IL_02af, IL_02b5, IL_02b7, IL_02b9, IL_02ca, IL_02db, IL_02eb, IL_02fb, IL_0305, IL_030d, IL_0317, IL_0327, IL_0336, IL_033e, IL_0348, IL_0363, IL_036e, IL_037f, IL_0389, IL_03a2, IL_03a4 are reachable both inside and outside the pinned region starting at IL_0391. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
				while (false)
				{
					_ = ((object[])null)[0];
				}
				int num = 11;
				bool flag = default;
				int* ptr2 = default;
				ref int reference = default;
				int num2 = default;
				short biBitCount = default;
				while (true)
				{
					int* ptr3;
					switch (num)
					{
					case 6:
						if (ByNfywgjN3 == 65280)
						{
							num = 0;
							continue;
						}
						break;
					case 19:
						if (bmiColors0 == 0 && ByNfywgjN3 == 16777215)
						{
							num = 7;
							continue;
						}
						break;
					case 1:
						flag = false;
						num = 8;
						continue;
					case 17:
						if (bmiHeader.biClrUsed == 2)
						{
							num = 19;
							continue;
						}
						break;
					case 10:
						ptr2 = (int*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
						goto case 14;
					default:
						num = 14;
						if (0 == 0)
						{
							continue;
						}
						goto case 20;
					case 20:
						if (bmiHeader.biClrUsed == 256)
						{
							num = 15;
							continue;
						}
						goto IL_02b7;
					case 25:
						return CnxPixelFormat.Format24bppRgb;
					case 12:
						if (bmiHeader.biCompression == 3 && bmiColors0 == 16711680)
						{
							num = 6;
							continue;
						}
						break;
					case 7:
						return CnxPixelFormat.Format1bppMonochrome;
					case 18:
						if (ByNfywgjN3 == 2016 && jGEfVyUndn == 31)
						{
							return CnxPixelFormat.Format16bppRgb565;
						}
						break;
					case 16:
					case 21:
						if (num2 < 256)
						{
							ptr3 = ptr2++;
							if (*ptr3 != (num2 | (num2 << 8) | (num2 << 16)))
							{
								num = 1;
								continue;
							}
							num2++;
							num = 16;
							continue;
						}
						goto case 8;
					case 8:
						reference = ref *(int*)null;
						num = 5;
						continue;
					case 2:
					case 13:
						if (biBitCount <= 8)
						{
							if (biBitCount == 1)
							{
								if (bmiHeader.biCompression != 0)
								{
									break;
								}
								num = 17;
								if (true)
								{
									continue;
								}
								goto case 6;
							}
							goto case 3;
						}
						if (biBitCount == 16)
						{
							if (bmiHeader.biCompression != 3 || bmiHeader.biClrUsed != 3)
							{
								break;
							}
							num = 23;
							if (d8KwxAgecx7iJdWIkVs())
							{
								continue;
							}
							goto case 0;
						}
						num = 4;
						continue;
					case 3:
					case 24:
						if (biBitCount == 8)
						{
							if (bmiHeader.biCompression == 0)
							{
								num = 20;
								continue;
							}
							break;
						}
						num = 27;
						continue;
					case 4:
						if (biBitCount == 24)
						{
							if (bmiHeader.biCompression == 0)
							{
								num = 25;
								if (GK7Mrwgu9cTH5FUZH00())
								{
								}
								continue;
							}
							break;
						}
						num = 22;
						if (d8KwxAgecx7iJdWIkVs())
						{
							continue;
						}
						goto case 8;
					case 14:
						num2 = 0;
						num = 21;
						if (true)
						{
							continue;
						}
						goto case 5;
					case 5:
						if (flag)
						{
							return CnxPixelFormat.Format8bppGrayscale;
						}
						goto IL_02b7;
					case 0:
						if (jGEfVyUndn == 255)
						{
							num = 28;
							continue;
						}
						break;
					case 22:
						if (biBitCount == 32)
						{
							if (bmiHeader.biCompression != 0)
							{
								num = 12;
								if (d8KwxAgecx7iJdWIkVs())
								{
									continue;
								}
								goto case 12;
							}
							goto case 28;
						}
						num = 26;
						continue;
					case 23:
						if (bmiColors0 == 63488)
						{
							num = 18;
							continue;
						}
						break;
					case 9:
						biBitCount = bmiHeader.biBitCount;
						GK7Mrwgu9cTH5FUZH00();
						num = (d8KwxAgecx7iJdWIkVs() ? 13 : 24);
						continue;
					case 11:
						if (bmiHeader.biPlanes == 1)
						{
							num = 9;
							continue;
						}
						break;
					case 15:
						flag = true;
						while (true)
						{
							IL_0391:
							fixed (int* ptr = &bmiColors0)
							{
								num = 10;
								if (GK7Mrwgu9cTH5FUZH00())
								{
									goto IL_03a2;
								}
								while (true)
								{
									switch (num)
									{
									case 6:
										if (ByNfywgjN3 == 65280)
										{
											num = 0;
											continue;
										}
										goto case 26;
									case 19:
										if (bmiColors0 == 0 && ByNfywgjN3 == 16777215)
										{
											num = 7;
											continue;
										}
										goto case 26;
									case 1:
										flag = false;
										num = 8;
										continue;
									case 17:
										if (bmiHeader.biClrUsed == 2)
										{
											num = 19;
											continue;
										}
										goto case 26;
									case 10:
										ptr2 = ptr;
										goto case 14;
									default:
										num = 14;
										if (0 == 0)
										{
											continue;
										}
										goto case 20;
									case 20:
										if (bmiHeader.biClrUsed == 256)
										{
											num = 15;
											continue;
										}
										goto IL_02b7_2;
									case 25:
										return CnxPixelFormat.Format24bppRgb;
									case 12:
										if (bmiHeader.biCompression == 3 && bmiColors0 == 16711680)
										{
											num = 6;
											continue;
										}
										goto case 26;
									case 7:
										return CnxPixelFormat.Format1bppMonochrome;
									case 18:
										if (ByNfywgjN3 == 2016 && jGEfVyUndn == 31)
										{
											return CnxPixelFormat.Format16bppRgb565;
										}
										goto case 26;
									case 16:
									case 21:
										if (num2 < 256)
										{
											ptr3 = ptr2++;
											if (*ptr3 != (num2 | (num2 << 8) | (num2 << 16)))
											{
												num = 1;
												continue;
											}
											num2++;
											num = 16;
											continue;
										}
										goto end_IL_00b4;
									case 2:
									case 13:
										if (biBitCount <= 8)
										{
											if (biBitCount != 1)
											{
												goto case 3;
											}
											if (bmiHeader.biCompression == 0)
											{
												num = 17;
												if (true)
												{
													continue;
												}
												goto case 6;
											}
										}
										else
										{
											if (biBitCount != 16)
											{
												num = 4;
												continue;
											}
											if (bmiHeader.biCompression == 3 && bmiHeader.biClrUsed == 3)
											{
												num = 23;
												if (d8KwxAgecx7iJdWIkVs())
												{
													continue;
												}
												goto case 0;
											}
										}
										goto case 26;
									case 3:
									case 24:
										if (biBitCount == 8)
										{
											if (bmiHeader.biCompression == 0)
											{
												num = 20;
												continue;
											}
											goto case 26;
										}
										num = 27;
										continue;
									case 4:
										if (biBitCount == 24)
										{
											if (bmiHeader.biCompression == 0)
											{
												num = 25;
												if (GK7Mrwgu9cTH5FUZH00())
												{
												}
												continue;
											}
											goto case 26;
										}
										num = 22;
										if (d8KwxAgecx7iJdWIkVs())
										{
											continue;
										}
										goto end_IL_00b4;
									case 8:
										goto end_IL_00b4;
									case 14:
										num2 = 0;
										num = 21;
										if (true)
										{
											continue;
										}
										goto case 5;
									case 5:
										if (flag)
										{
											return CnxPixelFormat.Format8bppGrayscale;
										}
										goto IL_02b7_2;
									case 0:
										if (jGEfVyUndn == 255)
										{
											num = 28;
											continue;
										}
										goto case 26;
									case 22:
										if (biBitCount == 32)
										{
											if (bmiHeader.biCompression == 0)
											{
												break;
											}
											num = 12;
											if (d8KwxAgecx7iJdWIkVs())
											{
												continue;
											}
											goto case 12;
										}
										num = 26;
										continue;
									case 23:
										if (bmiColors0 == 63488)
										{
											num = 18;
											continue;
										}
										goto case 26;
									case 9:
										biBitCount = bmiHeader.biBitCount;
										GK7Mrwgu9cTH5FUZH00();
										num = (d8KwxAgecx7iJdWIkVs() ? 13 : 24);
										continue;
									case 11:
										if (bmiHeader.biPlanes == 1)
										{
											num = 9;
											continue;
										}
										goto case 26;
									case 15:
										flag = true;
										goto IL_0391;
									case 28:
										break;
									case 26:
									case 27:
										{
											return CnxPixelFormat.Unknown;
										}
										IL_02b7_2:
										return CnxPixelFormat.Format8bppIndexed;
									}
									goto IL_03a2;
									continue;
									end_IL_00b4:
									break;
								}
								goto end_IL_0392;
								IL_03a2:
								return CnxPixelFormat.Format32bppRgb;
								end_IL_0392:;
							}
							break;
						}
						goto case 8;
					case 28:
						return CnxPixelFormat.Format32bppRgb;
					case 26:
					case 27:
						break;
						IL_02b7:
						return CnxPixelFormat.Format8bppIndexed;
					}
					break;
				}
				return CnxPixelFormat.Unknown;
			}
		}

		public int StreamedSize
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				if (bmiHeader.biClrUsed > 0)
				{
					return 40 + bmiHeader.biClrUsed * 4;
				}
				return 44;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BITMAPINFO(CnxVector2F size, CnxPixelFormat format, int[] palette)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			FVJJTGgIE0INaroCyMr();
			this = new BITMAPINFO(size, format, palette, topDown: true);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe BITMAPINFO(CnxVector2F size, CnxPixelFormat format, int[] palette, bool topDown)
		{
			//The blocks IL_001b, IL_0058, IL_00ed, IL_00f7, IL_0119, IL_012f, IL_0149, IL_016d, IL_0183, IL_019d, IL_01cb, IL_01d9, IL_01e4, IL_01f5, IL_01fb, IL_0207, IL_0211, IL_0231, IL_024e, IL_0259, IL_0264, IL_0268, IL_0280, IL_02a4, IL_02d8, IL_02f7, IL_0311, IL_032a, IL_034b, IL_0367, IL_0396, IL_03b0, IL_03bf, IL_03e4, IL_03fa, IL_0407, IL_0418, IL_0425, IL_0445, IL_044b, IL_0455, IL_046c, IL_0484 are reachable both inside and outside the pinned region starting at IL_02b6. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
			//The blocks IL_001b, IL_0058, IL_00ed, IL_00f7, IL_0119, IL_012f, IL_0149, IL_016d, IL_0183, IL_019d, IL_01cb, IL_01d9, IL_01e4, IL_01f5, IL_01fb, IL_0207, IL_0211, IL_0231, IL_024e, IL_0259, IL_0264, IL_0268, IL_0273, IL_0276, IL_0280, IL_02a4, IL_02b6, IL_02d8, IL_02f7, IL_0311, IL_032a, IL_034b, IL_0367, IL_0396, IL_03b0, IL_03bf, IL_03e4, IL_03fa, IL_0407, IL_0418, IL_0425, IL_0445, IL_044b, IL_0455, IL_046c, IL_0484 are reachable both inside and outside the pinned region starting at IL_010e. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
			//The blocks IL_001b, IL_0058, IL_00ed, IL_00f7, IL_0108, IL_0119, IL_012f, IL_0149, IL_016d, IL_0183, IL_019d, IL_01cb, IL_01d9, IL_01e4, IL_01f5, IL_01fb, IL_0207, IL_0211, IL_0231, IL_024e, IL_0259, IL_0264, IL_0268, IL_0273, IL_0276, IL_0280, IL_02a4, IL_02b6, IL_02d8, IL_02f7, IL_0311, IL_032a, IL_034b, IL_0367, IL_0396, IL_03b0, IL_03bf, IL_03e4, IL_03fa, IL_0407, IL_0418, IL_0425, IL_0445, IL_044b, IL_0455, IL_046c, IL_0484 are reachable both inside and outside the pinned region starting at IL_0045. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 20;
			if (1 == 0)
			{
				return;
			}
			int* ptr4 = default;
			int num4 = default;
			int num3 = default;
			int* ptr2 = default;
			ref int reference2 = default;
			while (true)
			{
				int* ptr6;
				nuint num2;
				int* ptr5;
				int* ptr3;
				ref BITMAPINFOHEADER reference;
				int biHeight;
				switch (num)
				{
				case 2:
					return;
				case 32:
					while (true)
					{
						fixed (int* ptr = &bmiColors0)
						{
							while (true)
							{
								IL_024e:
								ptr4 = ptr;
								num4 = 0;
								while (true)
								{
									IL_01fb:
									if (num4 >= 256)
									{
										num = 30;
									}
									else if (palette != null)
									{
										ptr6 = ptr4++;
										*ptr6 = palette[num4];
										num = 5;
										if (GK7Mrwgu9cTH5FUZH00())
										{
											goto IL_0311;
										}
									}
									else
									{
										num = 6;
									}
									goto IL_0058_2;
									IL_0058_2:
									while (true)
									{
										switch (num)
										{
										case 32:
											break;
										case 2:
											return;
										default:
											num = 28;
											continue;
										case 7:
											this = default;
											num = 1;
											continue;
										case 31:
											while (true)
											{
												IL_0108:
												fixed (int* ptr = &bmiColors0)
												{
													num = 15;
													while (true)
													{
														switch (num)
														{
														case 32:
															break;
														case 2:
															return;
														default:
															num = 28;
															continue;
														case 7:
															this = default;
															num = 1;
															continue;
														case 31:
															goto IL_0108;
														case 11:
														case 33:
															num3 = 0;
															num = 8;
															if (GK7Mrwgu9cTH5FUZH00())
															{
															}
															continue;
														case 34:
															bmiHeader.biClrUsed = 256;
															num = 31;
															continue;
														case 10:
															num2 = (nuint)ptr;
															*(int*)num2 = 63488;
															*(int*)(num2 + 4) = 2016;
															*(int*)(num2 + (nuint)((nint)2 * (nint)4)) = 31;
															num = 9;
															continue;
														case 12:
															ByNfywgjN3 = 16777215;
															num = 35;
															continue;
														case 14:
															return;
														case 15:
															ptr2 = ptr;
															_ = 0;
															num = ((!d8KwxAgecx7iJdWIkVs()) ? 24 : 33);
															continue;
														case 26:
															bmiColors0 = 0;
															num = 12;
															continue;
														case 5:
														case 19:
															num4++;
															goto case 18;
														case 18:
														case 24:
															if (num4 >= 256)
															{
																num = 30;
																continue;
															}
															if (palette != null)
															{
																ptr6 = ptr4++;
																*ptr6 = palette[num4];
																num = 5;
																if (!GK7Mrwgu9cTH5FUZH00())
																{
																	continue;
																}
																goto case 21;
															}
															num = 6;
															continue;
														case 0:
															bmiHeader.biCompression = 3;
															num = 3;
															if (GK7Mrwgu9cTH5FUZH00())
															{
															}
															continue;
														case 6:
															ptr5 = ptr4++;
															*ptr5 = num4 | (num4 << 8) | (num4 << 16);
															num = 19;
															continue;
														case 28:
															ptr4 = ptr;
															num4 = 0;
															goto case 18;
														case 29:
															num3++;
															goto case 8;
														case 8:
															if (num3 < 256)
															{
																ptr3 = ptr2++;
																*ptr3 = num3 | (num3 << 8) | (num3 << 16);
																num = 29;
																continue;
															}
															goto IL_0276;
														case 1:
															bmiHeader.biSize = 40;
															num = 22;
															continue;
														case 30:
															goto end_IL_0108;
														case 3:
															bmiHeader.biClrUsed = 3;
															while (true)
															{
																IL_02b6:
																fixed (int* ptr = &bmiColors0)
																{
																	num = 10;
																	if (!GK7Mrwgu9cTH5FUZH00())
																	{
																	}
																	while (true)
																	{
																		switch (num)
																		{
																		case 32:
																			break;
																		case 2:
																			return;
																		default:
																			num = 28;
																			continue;
																		case 7:
																			this = default;
																			num = 1;
																			continue;
																		case 31:
																			goto end_IL_02b6;
																		case 11:
																		case 33:
																			num3 = 0;
																			num = 8;
																			if (GK7Mrwgu9cTH5FUZH00())
																			{
																			}
																			continue;
																		case 34:
																			bmiHeader.biClrUsed = 256;
																			num = 31;
																			continue;
																		case 10:
																			num2 = (nuint)ptr;
																			*(int*)num2 = 63488;
																			*(int*)(num2 + 4) = 2016;
																			*(int*)(num2 + (nuint)((nint)2 * (nint)4)) = 31;
																			num = 9;
																			continue;
																		case 12:
																			ByNfywgjN3 = 16777215;
																			num = 35;
																			continue;
																		case 14:
																			return;
																		case 15:
																			ptr2 = ptr;
																			_ = 0;
																			num = ((!d8KwxAgecx7iJdWIkVs()) ? 24 : 33);
																			continue;
																		case 26:
																			bmiColors0 = 0;
																			num = 12;
																			continue;
																		case 5:
																		case 19:
																			num4++;
																			goto case 18;
																		case 18:
																		case 24:
																			if (num4 >= 256)
																			{
																				num = 30;
																				continue;
																			}
																			if (palette != null)
																			{
																				ptr6 = ptr4++;
																				*ptr6 = palette[num4];
																				num = 5;
																				if (!GK7Mrwgu9cTH5FUZH00())
																				{
																					continue;
																				}
																				goto case 21;
																			}
																			num = 6;
																			continue;
																		case 0:
																			bmiHeader.biCompression = 3;
																			num = 3;
																			if (GK7Mrwgu9cTH5FUZH00())
																			{
																			}
																			continue;
																		case 6:
																			ptr5 = ptr4++;
																			*ptr5 = num4 | (num4 << 8) | (num4 << 16);
																			num = 19;
																			continue;
																		case 28:
																			ptr4 = ptr;
																			num4 = 0;
																			goto case 18;
																		case 29:
																			num3++;
																			goto case 8;
																		case 8:
																			if (num3 < 256)
																			{
																				ptr3 = ptr2++;
																				*ptr3 = num3 | (num3 << 8) | (num3 << 16);
																				num = 29;
																				continue;
																			}
																			goto IL_0276;
																		case 1:
																			bmiHeader.biSize = 40;
																			num = 22;
																			continue;
																		case 30:
																			goto end_IL_0108;
																		case 3:
																			bmiHeader.biClrUsed = 3;
																			goto IL_02b6;
																		case 9:
																			goto IL_02cb;
																		case 23:
																			bmiHeader.biClrUsed = 256;
																			num = 32;
																			continue;
																		case 21:
																			bmiHeader.biCompression = 0;
																			num = 34;
																			if (true)
																			{
																				continue;
																			}
																			return;
																		case 27:
																			return;
																		case 22:
																			bmiHeader.biWidth = (int)size.X;
																			num = 16;
																			continue;
																		case 4:
																			bmiHeader.biXPelsPerMeter = 3780;
																			bmiHeader.biYPelsPerMeter = 3780;
																			num = 17;
																			continue;
																		case 20:
																			FVJJTGgIE0INaroCyMr();
																			num = 7;
																			continue;
																		case 17:
																			switch (format)
																			{
																			case CnxPixelFormat.Format8bppIndexed:
																				bmiHeader.biBitCount = 8;
																				bmiHeader.biCompression = 0;
																				num = 23;
																				if (true)
																				{
																					break;
																				}
																				goto end_IL_0058;
																			case CnxPixelFormat.Format24bppRgb:
																				bmiHeader.biBitCount = 24;
																				bmiHeader.biCompression = 0;
																				return;
																			case CnxPixelFormat.Format1bppMonochrome:
																				bmiHeader.biBitCount = 1;
																				bmiHeader.biCompression = 0;
																				bmiHeader.biClrUsed = 2;
																				num = 26;
																				break;
																			case CnxPixelFormat.Format32bppRgb:
																				bmiHeader.biBitCount = 32;
																				num = 25;
																				if (GK7Mrwgu9cTH5FUZH00())
																				{
																				}
																				break;
																			case CnxPixelFormat.Format8bppGrayscale:
																				bmiHeader.biBitCount = 8;
																				num = 21;
																				break;
																			case CnxPixelFormat.Format16bppRgb565:
																				bmiHeader.biBitCount = 16;
																				num = 0;
																				break;
																			default:
																				throw new ApplicationException((string)aCgvAega213MKXQx3SU(45226));
																			}
																			continue;
																		case 16:
																			reference = ref bmiHeader;
																			biHeight = (reference.biHeight = (topDown ? (-(int)YqxkmUgRYFjHYsbWB7s(size.Y)) : ((int)YqxkmUgRYFjHYsbWB7s(size.Y))));
																			bmiHeader.biPlanes = 1;
																			num = 4;
																			continue;
																		case 25:
																			bmiHeader.biCompression = 0;
																			num = 14;
																			continue;
																		case 13:
																			return;
																		case 35:
																			return;
																			end_IL_0058:
																			break;
																		}
																		break;
																	}
																}
																goto end_IL_0058_2;
																continue;
																end_IL_02b6:
																break;
															}
															goto IL_0108;
														case 9:
															goto IL_02cb;
														case 23:
															bmiHeader.biClrUsed = 256;
															num = 32;
															continue;
														case 21:
															bmiHeader.biCompression = 0;
															num = 34;
															if (true)
															{
																continue;
															}
															return;
														case 27:
															return;
														case 22:
															bmiHeader.biWidth = (int)size.X;
															num = 16;
															continue;
														case 4:
															bmiHeader.biXPelsPerMeter = 3780;
															bmiHeader.biYPelsPerMeter = 3780;
															num = 17;
															continue;
														case 20:
															FVJJTGgIE0INaroCyMr();
															num = 7;
															continue;
														case 17:
															switch (format)
															{
															case CnxPixelFormat.Format8bppIndexed:
																bmiHeader.biBitCount = 8;
																bmiHeader.biCompression = 0;
																num = 23;
																if (true)
																{
																	break;
																}
																goto end_IL_0058_2;
															case CnxPixelFormat.Format24bppRgb:
																bmiHeader.biBitCount = 24;
																bmiHeader.biCompression = 0;
																return;
															case CnxPixelFormat.Format1bppMonochrome:
																bmiHeader.biBitCount = 1;
																bmiHeader.biCompression = 0;
																bmiHeader.biClrUsed = 2;
																num = 26;
																break;
															case CnxPixelFormat.Format32bppRgb:
																bmiHeader.biBitCount = 32;
																num = 25;
																if (GK7Mrwgu9cTH5FUZH00())
																{
																}
																break;
															case CnxPixelFormat.Format8bppGrayscale:
																bmiHeader.biBitCount = 8;
																num = 21;
																break;
															case CnxPixelFormat.Format16bppRgb565:
																bmiHeader.biBitCount = 16;
																num = 0;
																break;
															default:
																throw new ApplicationException((string)aCgvAega213MKXQx3SU(45226));
															}
															continue;
														case 16:
															reference = ref bmiHeader;
															biHeight = (reference.biHeight = (topDown ? (-(int)YqxkmUgRYFjHYsbWB7s(size.Y)) : ((int)YqxkmUgRYFjHYsbWB7s(size.Y))));
															bmiHeader.biPlanes = 1;
															num = 4;
															continue;
														case 25:
															bmiHeader.biCompression = 0;
															num = 14;
															continue;
														case 13:
															return;
														case 35:
															return;
															IL_0276:
															num = 2;
															continue;
															end_IL_0058_2:
															break;
														}
														break;
													}
												}
												goto end_IL_0058_3;
												continue;
												end_IL_0108:
												break;
											}
											goto end_IL_003f;
										case 11:
										case 33:
											num3 = 0;
											num = 8;
											if (GK7Mrwgu9cTH5FUZH00())
											{
											}
											continue;
										case 34:
											bmiHeader.biClrUsed = 256;
											num = 31;
											continue;
										case 10:
											num2 = (nuint)ptr;
											*(int*)num2 = 63488;
											*(int*)(num2 + 4) = 2016;
											*(int*)(num2 + (nuint)((nint)2 * (nint)4)) = 31;
											num = 9;
											continue;
										case 12:
											ByNfywgjN3 = 16777215;
											num = 35;
											continue;
										case 14:
											return;
										case 15:
											goto IL_01cb;
										case 26:
											bmiColors0 = 0;
											num = 12;
											continue;
										case 5:
										case 19:
											num4++;
											goto IL_01fb;
										case 18:
										case 24:
											goto IL_01fb;
										case 0:
											bmiHeader.biCompression = 3;
											num = 3;
											if (GK7Mrwgu9cTH5FUZH00())
											{
											}
											continue;
										case 6:
											ptr5 = ptr4++;
											*ptr5 = num4 | (num4 << 8) | (num4 << 16);
											num = 19;
											continue;
										case 28:
											goto IL_024e;
										case 29:
											num3++;
											goto case 8;
										case 8:
											if (num3 < 256)
											{
												ptr3 = ptr2++;
												*ptr3 = num3 | (num3 << 8) | (num3 << 16);
												num = 29;
												continue;
											}
											goto IL_0276_2;
										case 1:
											bmiHeader.biSize = 40;
											num = 22;
											continue;
										case 30:
											goto end_IL_003f;
										case 3:
											bmiHeader.biClrUsed = 3;
											while (true)
											{
												IL_02b6_2:
												fixed (int* ptr = &bmiColors0)
												{
													num = 10;
													if (!GK7Mrwgu9cTH5FUZH00())
													{
													}
													while (true)
													{
														switch (num)
														{
														case 32:
															break;
														case 2:
															return;
														default:
															num = 28;
															continue;
														case 7:
															this = default;
															num = 1;
															continue;
														case 31:
															goto end_IL_02b6_2;
														case 11:
														case 33:
															num3 = 0;
															num = 8;
															if (GK7Mrwgu9cTH5FUZH00())
															{
															}
															continue;
														case 34:
															bmiHeader.biClrUsed = 256;
															num = 31;
															continue;
														case 10:
															num2 = (nuint)ptr;
															*(int*)num2 = 63488;
															*(int*)(num2 + 4) = 2016;
															*(int*)(num2 + (nuint)((nint)2 * (nint)4)) = 31;
															num = 9;
															continue;
														case 12:
															ByNfywgjN3 = 16777215;
															num = 35;
															continue;
														case 14:
															return;
														case 15:
															ptr2 = ptr;
															_ = 0;
															num = ((!d8KwxAgecx7iJdWIkVs()) ? 24 : 33);
															continue;
														case 26:
															bmiColors0 = 0;
															num = 12;
															continue;
														case 5:
														case 19:
															num4++;
															goto case 18;
														case 18:
														case 24:
															if (num4 >= 256)
															{
																num = 30;
																continue;
															}
															if (palette != null)
															{
																ptr6 = ptr4++;
																*ptr6 = palette[num4];
																num = 5;
																if (!GK7Mrwgu9cTH5FUZH00())
																{
																	continue;
																}
																goto case 21;
															}
															num = 6;
															continue;
														case 0:
															bmiHeader.biCompression = 3;
															num = 3;
															if (GK7Mrwgu9cTH5FUZH00())
															{
															}
															continue;
														case 6:
															ptr5 = ptr4++;
															*ptr5 = num4 | (num4 << 8) | (num4 << 16);
															num = 19;
															continue;
														case 28:
															ptr4 = ptr;
															num4 = 0;
															goto case 18;
														case 29:
															num3++;
															goto case 8;
														case 8:
															if (num3 < 256)
															{
																ptr3 = ptr2++;
																*ptr3 = num3 | (num3 << 8) | (num3 << 16);
																num = 29;
																continue;
															}
															goto IL_0276_2;
														case 1:
															bmiHeader.biSize = 40;
															num = 22;
															continue;
														case 30:
															goto end_IL_003f;
														case 3:
															bmiHeader.biClrUsed = 3;
															goto IL_02b6_2;
														case 9:
															goto IL_02cb;
														case 23:
															bmiHeader.biClrUsed = 256;
															num = 32;
															continue;
														case 21:
															bmiHeader.biCompression = 0;
															num = 34;
															if (true)
															{
																continue;
															}
															return;
														case 27:
															return;
														case 22:
															bmiHeader.biWidth = (int)size.X;
															num = 16;
															continue;
														case 4:
															bmiHeader.biXPelsPerMeter = 3780;
															bmiHeader.biYPelsPerMeter = 3780;
															num = 17;
															continue;
														case 20:
															FVJJTGgIE0INaroCyMr();
															num = 7;
															continue;
														case 17:
															switch (format)
															{
															case CnxPixelFormat.Format8bppIndexed:
																bmiHeader.biBitCount = 8;
																bmiHeader.biCompression = 0;
																num = 23;
																if (true)
																{
																	break;
																}
																goto end_IL_0058_4;
															case CnxPixelFormat.Format24bppRgb:
																bmiHeader.biBitCount = 24;
																bmiHeader.biCompression = 0;
																return;
															case CnxPixelFormat.Format1bppMonochrome:
																bmiHeader.biBitCount = 1;
																bmiHeader.biCompression = 0;
																bmiHeader.biClrUsed = 2;
																num = 26;
																break;
															case CnxPixelFormat.Format32bppRgb:
																bmiHeader.biBitCount = 32;
																num = 25;
																if (GK7Mrwgu9cTH5FUZH00())
																{
																}
																break;
															case CnxPixelFormat.Format8bppGrayscale:
																bmiHeader.biBitCount = 8;
																num = 21;
																break;
															case CnxPixelFormat.Format16bppRgb565:
																bmiHeader.biBitCount = 16;
																num = 0;
																break;
															default:
																throw new ApplicationException((string)aCgvAega213MKXQx3SU(45226));
															}
															continue;
														case 16:
															reference = ref bmiHeader;
															biHeight = (reference.biHeight = (topDown ? (-(int)YqxkmUgRYFjHYsbWB7s(size.Y)) : ((int)YqxkmUgRYFjHYsbWB7s(size.Y))));
															bmiHeader.biPlanes = 1;
															num = 4;
															continue;
														case 25:
															bmiHeader.biCompression = 0;
															num = 14;
															continue;
														case 13:
															return;
														case 35:
															return;
															end_IL_0058_4:
															break;
														}
														break;
													}
												}
												goto end_IL_0058_3;
												continue;
												end_IL_02b6_2:
												break;
											}
											goto case 31;
										case 9:
											goto IL_02cb;
										case 23:
											bmiHeader.biClrUsed = 256;
											num = 32;
											continue;
										case 21:
											goto IL_0311;
										case 27:
											return;
										case 22:
											bmiHeader.biWidth = (int)size.X;
											num = 16;
											continue;
										case 4:
											bmiHeader.biXPelsPerMeter = 3780;
											bmiHeader.biYPelsPerMeter = 3780;
											num = 17;
											continue;
										case 20:
											FVJJTGgIE0INaroCyMr();
											num = 7;
											continue;
										case 17:
											goto IL_03bf;
										case 16:
											reference = ref bmiHeader;
											biHeight = (reference.biHeight = (topDown ? (-(int)YqxkmUgRYFjHYsbWB7s(size.Y)) : ((int)YqxkmUgRYFjHYsbWB7s(size.Y))));
											bmiHeader.biPlanes = 1;
											num = 4;
											continue;
										case 25:
											bmiHeader.biCompression = 0;
											num = 14;
											continue;
										case 13:
											return;
										case 35:
											return;
											IL_0276_2:
											num = 2;
											continue;
											end_IL_0058_3:
											break;
										}
										break;
										IL_03bf:
										switch (format)
										{
										case CnxPixelFormat.Format8bppIndexed:
											bmiHeader.biBitCount = 8;
											bmiHeader.biCompression = 0;
											num = 23;
											if (true)
											{
												break;
											}
											goto end_IL_0058_5;
										case CnxPixelFormat.Format24bppRgb:
											bmiHeader.biBitCount = 24;
											bmiHeader.biCompression = 0;
											return;
										case CnxPixelFormat.Format1bppMonochrome:
											bmiHeader.biBitCount = 1;
											bmiHeader.biCompression = 0;
											bmiHeader.biClrUsed = 2;
											num = 26;
											break;
										case CnxPixelFormat.Format32bppRgb:
											bmiHeader.biBitCount = 32;
											num = 25;
											if (GK7Mrwgu9cTH5FUZH00())
											{
											}
											break;
										case CnxPixelFormat.Format8bppGrayscale:
											bmiHeader.biBitCount = 8;
											num = 21;
											break;
										case CnxPixelFormat.Format16bppRgb565:
											bmiHeader.biBitCount = 16;
											num = 0;
											break;
										default:
											throw new ApplicationException((string)aCgvAega213MKXQx3SU(45226));
										}
										continue;
										IL_01cb:
										ptr2 = ptr;
										_ = 0;
										num = ((!d8KwxAgecx7iJdWIkVs()) ? 24 : 33);
										continue;
										end_IL_0058_5:
										break;
									}
									break;
									IL_0311:
									bmiHeader.biCompression = 0;
									num = 34;
									if (1 == 0)
									{
										return;
									}
									goto IL_0058_2;
								}
								break;
							}
						}
						continue;
						end_IL_003f:
						break;
					}
					goto IL_0297;
				default:
					num = 28;
					break;
				case 7:
					this = default;
					num = 1;
					break;
				case 31:
					while (true)
					{
						IL_0108_2:
						fixed (int* ptr = &bmiColors0)
						{
							num = 15;
							while (true)
							{
								switch (num)
								{
								case 32:
									break;
								case 2:
									return;
								default:
									num = 28;
									continue;
								case 7:
									this = default;
									num = 1;
									continue;
								case 31:
									goto IL_0108_2;
								case 11:
								case 33:
									num3 = 0;
									num = 8;
									if (GK7Mrwgu9cTH5FUZH00())
									{
									}
									continue;
								case 34:
									bmiHeader.biClrUsed = 256;
									num = 31;
									continue;
								case 10:
									num2 = (nuint)ptr;
									*(int*)num2 = 63488;
									*(int*)(num2 + 4) = 2016;
									*(int*)(num2 + (nuint)((nint)2 * (nint)4)) = 31;
									num = 9;
									continue;
								case 12:
									ByNfywgjN3 = 16777215;
									num = 35;
									continue;
								case 14:
									return;
								case 15:
									ptr2 = ptr;
									_ = 0;
									num = ((!d8KwxAgecx7iJdWIkVs()) ? 24 : 33);
									continue;
								case 26:
									bmiColors0 = 0;
									num = 12;
									continue;
								case 5:
								case 19:
									num4++;
									goto case 18;
								case 18:
								case 24:
									if (num4 >= 256)
									{
										num = 30;
										continue;
									}
									if (palette != null)
									{
										ptr6 = ptr4++;
										*ptr6 = palette[num4];
										num = 5;
										if (!GK7Mrwgu9cTH5FUZH00())
										{
											continue;
										}
										goto case 21;
									}
									num = 6;
									continue;
								case 0:
									bmiHeader.biCompression = 3;
									num = 3;
									if (GK7Mrwgu9cTH5FUZH00())
									{
									}
									continue;
								case 6:
									ptr5 = ptr4++;
									*ptr5 = num4 | (num4 << 8) | (num4 << 16);
									num = 19;
									continue;
								case 28:
									ptr4 = ptr;
									num4 = 0;
									goto case 18;
								case 29:
									num3++;
									goto case 8;
								case 8:
									if (num3 < 256)
									{
										ptr3 = ptr2++;
										*ptr3 = num3 | (num3 << 8) | (num3 << 16);
										num = 29;
										continue;
									}
									goto IL_0276_3;
								case 1:
									bmiHeader.biSize = 40;
									num = 22;
									continue;
								case 30:
									goto end_IL_0108_2;
								case 3:
									bmiHeader.biClrUsed = 3;
									while (true)
									{
										IL_02b6_3:
										fixed (int* ptr = &bmiColors0)
										{
											num = 10;
											if (!GK7Mrwgu9cTH5FUZH00())
											{
											}
											while (true)
											{
												switch (num)
												{
												case 32:
													break;
												case 2:
													return;
												default:
													num = 28;
													continue;
												case 7:
													this = default;
													num = 1;
													continue;
												case 31:
													goto end_IL_02b6_3;
												case 11:
												case 33:
													num3 = 0;
													num = 8;
													if (GK7Mrwgu9cTH5FUZH00())
													{
													}
													continue;
												case 34:
													bmiHeader.biClrUsed = 256;
													num = 31;
													continue;
												case 10:
													num2 = (nuint)ptr;
													*(int*)num2 = 63488;
													*(int*)(num2 + 4) = 2016;
													*(int*)(num2 + (nuint)((nint)2 * (nint)4)) = 31;
													num = 9;
													continue;
												case 12:
													ByNfywgjN3 = 16777215;
													num = 35;
													continue;
												case 14:
													return;
												case 15:
													ptr2 = ptr;
													_ = 0;
													num = ((!d8KwxAgecx7iJdWIkVs()) ? 24 : 33);
													continue;
												case 26:
													bmiColors0 = 0;
													num = 12;
													continue;
												case 5:
												case 19:
													num4++;
													goto case 18;
												case 18:
												case 24:
													if (num4 >= 256)
													{
														num = 30;
														continue;
													}
													if (palette != null)
													{
														ptr6 = ptr4++;
														*ptr6 = palette[num4];
														num = 5;
														if (!GK7Mrwgu9cTH5FUZH00())
														{
															continue;
														}
														goto case 21;
													}
													num = 6;
													continue;
												case 0:
													bmiHeader.biCompression = 3;
													num = 3;
													if (GK7Mrwgu9cTH5FUZH00())
													{
													}
													continue;
												case 6:
													ptr5 = ptr4++;
													*ptr5 = num4 | (num4 << 8) | (num4 << 16);
													num = 19;
													continue;
												case 28:
													ptr4 = ptr;
													num4 = 0;
													goto case 18;
												case 29:
													num3++;
													goto case 8;
												case 8:
													if (num3 < 256)
													{
														ptr3 = ptr2++;
														*ptr3 = num3 | (num3 << 8) | (num3 << 16);
														num = 29;
														continue;
													}
													goto IL_0276_3;
												case 1:
													bmiHeader.biSize = 40;
													num = 22;
													continue;
												case 30:
													goto end_IL_0108_2;
												case 3:
													bmiHeader.biClrUsed = 3;
													goto IL_02b6_3;
												case 9:
													goto IL_02cb;
												case 23:
													bmiHeader.biClrUsed = 256;
													num = 32;
													continue;
												case 21:
													bmiHeader.biCompression = 0;
													num = 34;
													if (true)
													{
														continue;
													}
													return;
												case 27:
													return;
												case 22:
													bmiHeader.biWidth = (int)size.X;
													num = 16;
													continue;
												case 4:
													bmiHeader.biXPelsPerMeter = 3780;
													bmiHeader.biYPelsPerMeter = 3780;
													num = 17;
													continue;
												case 20:
													FVJJTGgIE0INaroCyMr();
													num = 7;
													continue;
												case 17:
													switch (format)
													{
													case CnxPixelFormat.Format8bppIndexed:
														bmiHeader.biBitCount = 8;
														bmiHeader.biCompression = 0;
														num = 23;
														if (true)
														{
															break;
														}
														goto end_IL_0058_6;
													case CnxPixelFormat.Format24bppRgb:
														bmiHeader.biBitCount = 24;
														bmiHeader.biCompression = 0;
														return;
													case CnxPixelFormat.Format1bppMonochrome:
														bmiHeader.biBitCount = 1;
														bmiHeader.biCompression = 0;
														bmiHeader.biClrUsed = 2;
														num = 26;
														break;
													case CnxPixelFormat.Format32bppRgb:
														bmiHeader.biBitCount = 32;
														num = 25;
														if (GK7Mrwgu9cTH5FUZH00())
														{
														}
														break;
													case CnxPixelFormat.Format8bppGrayscale:
														bmiHeader.biBitCount = 8;
														num = 21;
														break;
													case CnxPixelFormat.Format16bppRgb565:
														bmiHeader.biBitCount = 16;
														num = 0;
														break;
													default:
														throw new ApplicationException((string)aCgvAega213MKXQx3SU(45226));
													}
													continue;
												case 16:
													reference = ref bmiHeader;
													biHeight = (reference.biHeight = (topDown ? (-(int)YqxkmUgRYFjHYsbWB7s(size.Y)) : ((int)YqxkmUgRYFjHYsbWB7s(size.Y))));
													bmiHeader.biPlanes = 1;
													num = 4;
													continue;
												case 25:
													bmiHeader.biCompression = 0;
													num = 14;
													continue;
												case 13:
													return;
												case 35:
													return;
													end_IL_0058_6:
													break;
												}
												break;
											}
										}
										goto end_IL_0058_7;
										continue;
										end_IL_02b6_3:
										break;
									}
									goto IL_0108_2;
								case 9:
									goto IL_02cb;
								case 23:
									bmiHeader.biClrUsed = 256;
									num = 32;
									continue;
								case 21:
									bmiHeader.biCompression = 0;
									num = 34;
									if (true)
									{
										continue;
									}
									return;
								case 27:
									return;
								case 22:
									bmiHeader.biWidth = (int)size.X;
									num = 16;
									continue;
								case 4:
									bmiHeader.biXPelsPerMeter = 3780;
									bmiHeader.biYPelsPerMeter = 3780;
									num = 17;
									continue;
								case 20:
									FVJJTGgIE0INaroCyMr();
									num = 7;
									continue;
								case 17:
									switch (format)
									{
									case CnxPixelFormat.Format8bppIndexed:
										bmiHeader.biBitCount = 8;
										bmiHeader.biCompression = 0;
										num = 23;
										if (true)
										{
											break;
										}
										goto end_IL_0058_7;
									case CnxPixelFormat.Format24bppRgb:
										bmiHeader.biBitCount = 24;
										bmiHeader.biCompression = 0;
										return;
									case CnxPixelFormat.Format1bppMonochrome:
										bmiHeader.biBitCount = 1;
										bmiHeader.biCompression = 0;
										bmiHeader.biClrUsed = 2;
										num = 26;
										break;
									case CnxPixelFormat.Format32bppRgb:
										bmiHeader.biBitCount = 32;
										num = 25;
										if (GK7Mrwgu9cTH5FUZH00())
										{
										}
										break;
									case CnxPixelFormat.Format8bppGrayscale:
										bmiHeader.biBitCount = 8;
										num = 21;
										break;
									case CnxPixelFormat.Format16bppRgb565:
										bmiHeader.biBitCount = 16;
										num = 0;
										break;
									default:
										throw new ApplicationException((string)aCgvAega213MKXQx3SU(45226));
									}
									continue;
								case 16:
									reference = ref bmiHeader;
									biHeight = (reference.biHeight = (topDown ? (-(int)YqxkmUgRYFjHYsbWB7s(size.Y)) : ((int)YqxkmUgRYFjHYsbWB7s(size.Y))));
									bmiHeader.biPlanes = 1;
									num = 4;
									continue;
								case 25:
									bmiHeader.biCompression = 0;
									num = 14;
									continue;
								case 13:
									return;
								case 35:
									return;
									IL_0276_3:
									num = 2;
									continue;
									end_IL_0058_7:
									break;
								}
								break;
							}
						}
						goto case 32;
						continue;
						end_IL_0108_2:
						break;
					}
					goto IL_0297;
				case 11:
				case 33:
					num3 = 0;
					num = 8;
					if (GK7Mrwgu9cTH5FUZH00())
					{
					}
					break;
				case 34:
					bmiHeader.biClrUsed = 256;
					num = 31;
					break;
				case 10:
					num2 = (nuint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
					*(int*)num2 = 63488;
					*(int*)(num2 + 4) = 2016;
					*(int*)(num2 + (nuint)((nint)2 * (nint)4)) = 31;
					num = 9;
					break;
				case 12:
					ByNfywgjN3 = 16777215;
					num = 35;
					break;
				case 14:
					return;
				case 15:
					ptr2 = (int*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
					_ = 0;
					num = ((!d8KwxAgecx7iJdWIkVs()) ? 24 : 33);
					break;
				case 26:
					bmiColors0 = 0;
					num = 12;
					break;
				case 5:
				case 19:
					num4++;
					goto case 18;
				case 18:
				case 24:
					if (num4 >= 256)
					{
						num = 30;
						break;
					}
					if (palette != null)
					{
						ptr6 = ptr4++;
						*ptr6 = palette[num4];
						num = 5;
						if (!GK7Mrwgu9cTH5FUZH00())
						{
							break;
						}
						goto case 21;
					}
					num = 6;
					break;
				case 0:
					bmiHeader.biCompression = 3;
					num = 3;
					if (GK7Mrwgu9cTH5FUZH00())
					{
					}
					break;
				case 6:
					ptr5 = ptr4++;
					*ptr5 = num4 | (num4 << 8) | (num4 << 16);
					num = 19;
					break;
				case 28:
					ptr4 = (int*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
					num4 = 0;
					goto case 18;
				case 29:
					num3++;
					goto case 8;
				case 8:
					if (num3 < 256)
					{
						ptr3 = ptr2++;
						*ptr3 = num3 | (num3 << 8) | (num3 << 16);
						num = 29;
						break;
					}
					goto IL_0276_4;
				case 1:
					bmiHeader.biSize = 40;
					num = 22;
					break;
				case 30:
					goto IL_0297;
				case 3:
					bmiHeader.biClrUsed = 3;
					while (true)
					{
						IL_02b6_4:
						fixed (int* ptr = &bmiColors0)
						{
							num = 10;
							if (!GK7Mrwgu9cTH5FUZH00())
							{
							}
							while (true)
							{
								switch (num)
								{
								case 32:
									break;
								case 2:
									return;
								default:
									num = 28;
									continue;
								case 7:
									this = default;
									num = 1;
									continue;
								case 31:
									goto end_IL_02b6_4;
								case 11:
								case 33:
									num3 = 0;
									num = 8;
									if (GK7Mrwgu9cTH5FUZH00())
									{
									}
									continue;
								case 34:
									bmiHeader.biClrUsed = 256;
									num = 31;
									continue;
								case 10:
									num2 = (nuint)ptr;
									*(int*)num2 = 63488;
									*(int*)(num2 + 4) = 2016;
									*(int*)(num2 + (nuint)((nint)2 * (nint)4)) = 31;
									num = 9;
									continue;
								case 12:
									ByNfywgjN3 = 16777215;
									num = 35;
									continue;
								case 14:
									return;
								case 15:
									ptr2 = ptr;
									_ = 0;
									num = ((!d8KwxAgecx7iJdWIkVs()) ? 24 : 33);
									continue;
								case 26:
									bmiColors0 = 0;
									num = 12;
									continue;
								case 5:
								case 19:
									num4++;
									goto case 18;
								case 18:
								case 24:
									if (num4 >= 256)
									{
										num = 30;
										continue;
									}
									if (palette != null)
									{
										ptr6 = ptr4++;
										*ptr6 = palette[num4];
										num = 5;
										if (!GK7Mrwgu9cTH5FUZH00())
										{
											continue;
										}
										goto case 21;
									}
									num = 6;
									continue;
								case 0:
									bmiHeader.biCompression = 3;
									num = 3;
									if (GK7Mrwgu9cTH5FUZH00())
									{
									}
									continue;
								case 6:
									ptr5 = ptr4++;
									*ptr5 = num4 | (num4 << 8) | (num4 << 16);
									num = 19;
									continue;
								case 28:
									ptr4 = ptr;
									num4 = 0;
									goto case 18;
								case 29:
									num3++;
									goto case 8;
								case 8:
									if (num3 < 256)
									{
										ptr3 = ptr2++;
										*ptr3 = num3 | (num3 << 8) | (num3 << 16);
										num = 29;
										continue;
									}
									goto IL_0276_4;
								case 1:
									bmiHeader.biSize = 40;
									num = 22;
									continue;
								case 30:
									goto IL_0297;
								case 3:
									bmiHeader.biClrUsed = 3;
									goto IL_02b6_4;
								case 9:
									goto IL_02cb;
								case 23:
									bmiHeader.biClrUsed = 256;
									num = 32;
									continue;
								case 21:
									bmiHeader.biCompression = 0;
									num = 34;
									if (true)
									{
										continue;
									}
									return;
								case 27:
									return;
								case 22:
									bmiHeader.biWidth = (int)size.X;
									num = 16;
									continue;
								case 4:
									bmiHeader.biXPelsPerMeter = 3780;
									bmiHeader.biYPelsPerMeter = 3780;
									num = 17;
									continue;
								case 20:
									FVJJTGgIE0INaroCyMr();
									num = 7;
									continue;
								case 17:
									switch (format)
									{
									case CnxPixelFormat.Format8bppIndexed:
										bmiHeader.biBitCount = 8;
										bmiHeader.biCompression = 0;
										num = 23;
										if (true)
										{
											break;
										}
										goto end_IL_0058_8;
									case CnxPixelFormat.Format24bppRgb:
										bmiHeader.biBitCount = 24;
										bmiHeader.biCompression = 0;
										return;
									case CnxPixelFormat.Format1bppMonochrome:
										bmiHeader.biBitCount = 1;
										bmiHeader.biCompression = 0;
										bmiHeader.biClrUsed = 2;
										num = 26;
										break;
									case CnxPixelFormat.Format32bppRgb:
										bmiHeader.biBitCount = 32;
										num = 25;
										if (GK7Mrwgu9cTH5FUZH00())
										{
										}
										break;
									case CnxPixelFormat.Format8bppGrayscale:
										bmiHeader.biBitCount = 8;
										num = 21;
										break;
									case CnxPixelFormat.Format16bppRgb565:
										bmiHeader.biBitCount = 16;
										num = 0;
										break;
									default:
										throw new ApplicationException((string)aCgvAega213MKXQx3SU(45226));
									}
									continue;
								case 16:
									reference = ref bmiHeader;
									biHeight = (reference.biHeight = (topDown ? (-(int)YqxkmUgRYFjHYsbWB7s(size.Y)) : ((int)YqxkmUgRYFjHYsbWB7s(size.Y))));
									bmiHeader.biPlanes = 1;
									num = 4;
									continue;
								case 25:
									bmiHeader.biCompression = 0;
									num = 14;
									continue;
								case 13:
									return;
								case 35:
									return;
									end_IL_0058_8:
									break;
								}
								break;
							}
						}
						goto case 32;
						continue;
						end_IL_02b6_4:
						break;
					}
					goto case 31;
				case 9:
					goto IL_02cb;
				case 23:
					bmiHeader.biClrUsed = 256;
					num = 32;
					break;
				case 21:
					bmiHeader.biCompression = 0;
					num = 34;
					if (1 == 0)
					{
						return;
					}
					break;
				case 27:
					return;
				case 22:
					bmiHeader.biWidth = (int)size.X;
					num = 16;
					break;
				case 4:
					bmiHeader.biXPelsPerMeter = 3780;
					bmiHeader.biYPelsPerMeter = 3780;
					num = 17;
					break;
				case 20:
					FVJJTGgIE0INaroCyMr();
					num = 7;
					break;
				case 17:
					switch (format)
					{
					case CnxPixelFormat.Format8bppIndexed:
						break;
					case CnxPixelFormat.Format24bppRgb:
						bmiHeader.biBitCount = 24;
						bmiHeader.biCompression = 0;
						return;
					case CnxPixelFormat.Format1bppMonochrome:
						bmiHeader.biBitCount = 1;
						bmiHeader.biCompression = 0;
						bmiHeader.biClrUsed = 2;
						num = 26;
						goto end_IL_0058_9;
					case CnxPixelFormat.Format32bppRgb:
						bmiHeader.biBitCount = 32;
						num = 25;
						if (GK7Mrwgu9cTH5FUZH00())
						{
						}
						goto end_IL_0058_9;
					case CnxPixelFormat.Format8bppGrayscale:
						bmiHeader.biBitCount = 8;
						num = 21;
						goto end_IL_0058_9;
					case CnxPixelFormat.Format16bppRgb565:
						bmiHeader.biBitCount = 16;
						num = 0;
						goto end_IL_0058_9;
					default:
						throw new ApplicationException((string)aCgvAega213MKXQx3SU(45226));
					}
					bmiHeader.biBitCount = 8;
					bmiHeader.biCompression = 0;
					num = 23;
					if (true)
					{
						break;
					}
					goto case 32;
				case 16:
					reference = ref bmiHeader;
					biHeight = (topDown ? (-(int)YqxkmUgRYFjHYsbWB7s(size.Y)) : ((int)YqxkmUgRYFjHYsbWB7s(size.Y)));
					reference.biHeight = biHeight;
					bmiHeader.biPlanes = 1;
					num = 4;
					break;
				case 25:
					bmiHeader.biCompression = 0;
					num = 14;
					break;
				case 13:
					return;
				case 35:
					return;
					IL_0297:
					reference2 = ref *(int*)null;
					num = 13;
					break;
					IL_02cb:
					reference2 = ref *(int*)null;
					num = 27;
					break;
					IL_0276_4:
					num = 2;
					break;
					end_IL_0058_9:
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe int[] GetPalette()
		{
			//The blocks IL_001a, IL_0023, IL_002e, IL_0048, IL_0063, IL_0094, IL_009f, IL_00b7, IL_00c2, IL_00dd, IL_00eb, IL_00fe are reachable both inside and outside the pinned region starting at IL_00d2. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_0063;
			IL_00b7:
			int num2 = default;
			int[] array;
			int[] array2 = default;
			int num3;
			int* ptr;
			int* ptr2 = default;
			if (num2 < 256)
			{
				array = array2;
				num3 = num2;
				ptr = ptr2++;
				array[num3] = *ptr;
				goto IL_0094;
			}
			num = 8;
			goto IL_0063;
			IL_0094:
			_ = 1;
			num = ((!GK7Mrwgu9cTH5FUZH00()) ? 2 : 0);
			goto IL_0063;
			IL_0063:
			ref int reference = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					break;
				case 4:
					array2 = new int[256];
					num = 9;
					continue;
				default:
					goto IL_0094;
				case 8:
					reference = ref *(int*)null;
					num = 10;
					continue;
				case 0:
				case 6:
				case 7:
					goto IL_00b7;
				case 9:
					while (true)
					{
						IL_00cc:
						fixed (int* ptr3 = &bmiColors0)
						{
							num = 3;
							while (true)
							{
								switch (num)
								{
								case 8:
									goto end_IL_0063;
								case 2:
								case 5:
									num2++;
									goto case 0;
								case 4:
									array2 = new int[256];
									num = 9;
									continue;
								default:
									_ = 1;
									num = ((!GK7Mrwgu9cTH5FUZH00()) ? 2 : 0);
									continue;
								case 0:
								case 6:
								case 7:
									if (num2 < 256)
									{
										array = array2;
										num3 = num2;
										ptr = ptr2++;
										array[num3] = *ptr;
										goto default;
									}
									num = 8;
									continue;
								case 9:
									goto IL_00cc;
								case 1:
									num2 = 0;
									num = 7;
									if (0 == 0)
									{
										continue;
									}
									goto case 3;
								case 3:
									ptr2 = ptr3;
									num = 1;
									if (d8KwxAgecx7iJdWIkVs())
									{
										continue;
									}
									break;
								case 10:
									break;
								}
								return array2;
								continue;
								end_IL_0063:
								break;
							}
						}
						break;
					}
					goto case 8;
				case 1:
					num2 = 0;
					num = 7;
					if (0 == 0)
					{
						continue;
					}
					goto case 3;
				case 3:
					ptr2 = (int*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
					num = 1;
					if (d8KwxAgecx7iJdWIkVs())
					{
						continue;
					}
					goto case 10;
				case 10:
					return array2;
				}
				break;
			}
			goto IL_001a;
			IL_001a:
			num2++;
			goto IL_00b7;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe void Write(BinaryWriter bw)
		{
			//The blocks IL_0018, IL_002f, IL_0058, IL_006d, IL_007a, IL_008a, IL_00a8, IL_00bd, IL_00f6, IL_0100, IL_011b, IL_012d, IL_0143 are reachable both inside and outside the pinned region starting at IL_0052. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 8;
			int num3 = default;
			int num2 = default;
			byte[] array = default;
			byte* ptr = default;
			ref int reference = default;
			while (true)
			{
				byte[] array2;
				int num4;
				byte* ptr3;
				switch (num)
				{
				case 5:
				case 6:
					if (num3 < num2)
					{
						array2 = array;
						num4 = num3;
						ptr3 = ptr++;
						array2[num4] = *ptr3;
						num = 7;
						if (true)
						{
							continue;
						}
						break;
					}
					goto IL_0023;
				case 0:
					bSHEikgntk64FrkCPRD(bw, array, 0, num2);
					num = 12;
					if (GK7Mrwgu9cTH5FUZH00())
					{
					}
					continue;
				case 11:
					while (true)
					{
						fixed (int* ptr2 = &bmiColors0)
						{
							while (true)
							{
								IL_006d:
								ptr = (byte*)ptr2;
								num = 9;
								while (true)
								{
									switch (num)
									{
									case 11:
										goto end_IL_00bd;
									case 5:
									case 6:
										if (num3 >= num2)
										{
											goto end_IL_004c;
										}
										array2 = array;
										num4 = num3;
										ptr3 = ptr++;
										array2[num4] = *ptr3;
										num = 7;
										if (true)
										{
											continue;
										}
										goto case 3;
									case 0:
										bSHEikgntk64FrkCPRD(bw, array, 0, num2);
										num = 12;
										if (GK7Mrwgu9cTH5FUZH00())
										{
										}
										continue;
									case 2:
									case 4:
										break;
									case 7:
										num3++;
										num = 6;
										continue;
									case 1:
									case 10:
										num2 = 4 * Math.Max(1, bmiHeader.biClrUsed);
										num = 3;
										continue;
									case 9:
										num3 = 0;
										goto case 5;
									default:
										num = 5;
										continue;
									case 8:
										bmiHeader.Write(bw);
										GK7Mrwgu9cTH5FUZH00();
										if (!d8KwxAgecx7iJdWIkVs())
										{
											num = 2;
											if (GK7Mrwgu9cTH5FUZH00())
											{
											}
											continue;
										}
										num = 10;
										if (0 == 0)
										{
											continue;
										}
										goto case 5;
									case 3:
										array = new byte[num2];
										num = 11;
										continue;
									case 12:
										return;
									}
									goto IL_006d;
									continue;
									end_IL_00bd:
									break;
								}
								break;
							}
						}
						continue;
						end_IL_004c:
						break;
					}
					goto IL_0023;
				case 2:
				case 4:
					ptr = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
					num = 9;
					continue;
				case 7:
					num3++;
					num = 6;
					continue;
				case 1:
				case 10:
					num2 = 4 * Math.Max(1, bmiHeader.biClrUsed);
					num = 3;
					continue;
				case 9:
					num3 = 0;
					goto case 5;
				default:
					num = 5;
					continue;
				case 8:
					bmiHeader.Write(bw);
					GK7Mrwgu9cTH5FUZH00();
					if (!d8KwxAgecx7iJdWIkVs())
					{
						num = 2;
						if (GK7Mrwgu9cTH5FUZH00())
						{
						}
						continue;
					}
					num = 10;
					if (0 == 0)
					{
						continue;
					}
					goto case 5;
				case 3:
					break;
				case 12:
					return;
					IL_0023:
					num = 0;
					if (true)
					{
						continue;
					}
					goto case 0;
				}
				array = new byte[num2];
				num = 11;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe void Read(BinaryReader br)
		{
			//The blocks IL_0018, IL_003b, IL_0078, IL_0088, IL_00be, IL_00d4, IL_00da, IL_00eb, IL_00f7, IL_0120, IL_0137, IL_0143, IL_014e, IL_015d, IL_016f are reachable both inside and outside the pinned region starting at IL_00a4. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			int num2 = default;
			int* ptr2 = default;
			while (true)
			{
				int* ptr;
				int num3;
				switch (num)
				{
				case 2:
					num2 = 1 << (int)bmiHeader.biBitCount;
					goto case 6;
				default:
					num = 6;
					if (d8KwxAgecx7iJdWIkVs())
					{
						break;
					}
					goto case 3;
				case 3:
					bmiHeader.Read(br);
					num = 10;
					break;
				case 4:
				case 11:
					while (true)
					{
						fixed (int* ptr3 = &bmiColors0)
						{
							ptr2 = ptr3;
							_ = 0;
							num = ((!d8KwxAgecx7iJdWIkVs()) ? 12 : 5);
							while (true)
							{
								switch (num)
								{
								case 4:
									break;
								case 2:
									num2 = 1 << (int)bmiHeader.biBitCount;
									goto case 6;
								default:
									num = 6;
									if (d8KwxAgecx7iJdWIkVs())
									{
										continue;
									}
									goto case 3;
								case 3:
									bmiHeader.Read(br);
									num = 10;
									continue;
								case 10:
									num2 = bmiHeader.biClrUsed;
									num = 0;
									continue;
								case 0:
									if (num2 != 0)
									{
										break;
									}
									if (bmiHeader.biCompression == 3)
									{
										num = 7;
										if (true)
										{
											continue;
										}
										goto case 5;
									}
									if (bmiHeader.biBitCount < 16)
									{
										num = 2;
										continue;
									}
									break;
								case 5:
								case 8:
									ptr = ptr2++;
									*ptr = my6UwHgG9RuuHIegoXI(br);
									goto case 9;
								case 1:
									goto end_IL_009e;
								case 6:
									bmiHeader.biClrUsed = (short)num2;
									num = 4;
									continue;
								case 7:
									num2 = 3;
									num = 11;
									continue;
								case 9:
								case 12:
									num3 = --num2;
									if (num3 <= 0)
									{
										num = 1;
										continue;
									}
									goto case 5;
								case 11:
									break;
								case 13:
									return;
								}
								break;
							}
						}
						continue;
						end_IL_009e:
						break;
					}
					goto case 1;
				case 10:
					num2 = bmiHeader.biClrUsed;
					num = 0;
					break;
				case 0:
					if (num2 == 0)
					{
						if (bmiHeader.biCompression == 3)
						{
							num = 7;
							if (true)
							{
								break;
							}
							goto case 5;
						}
						if (bmiHeader.biBitCount < 16)
						{
							num = 2;
							break;
						}
					}
					goto case 4;
				case 5:
				case 8:
					ptr = ptr2++;
					*ptr = my6UwHgG9RuuHIegoXI(br);
					goto case 9;
				case 1:
					num = 13;
					break;
				case 6:
					bmiHeader.biClrUsed = (short)num2;
					num = 4;
					break;
				case 7:
					num2 = 3;
					num = 11;
					break;
				case 9:
				case 12:
					num3 = --num2;
					if (num3 <= 0)
					{
						num = 1;
						break;
					}
					goto case 5;
				case 13:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void FVJJTGgIE0INaroCyMr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool d8KwxAgecx7iJdWIkVs()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GK7Mrwgu9cTH5FUZH00()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static float YqxkmUgRYFjHYsbWB7s(float P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Math.Abs(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object aCgvAega213MKXQx3SU(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void bSHEikgntk64FrkCPRD(object P_0, object P_1, int P_2, int P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BinaryWriter)P_0).Write((byte[])P_1, P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int my6UwHgG9RuuHIegoXI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BinaryReader)P_0).ReadInt32();
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class BITMAPFILEHEADER
	{
		public short bfType;

		public int bfSize;

		public short bfReserved1;

		public short bfReserved2;

		public int bfOffBits;

		public const int StreamedSize = 14;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BITMAPFILEHEADER()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kt0U69g6FHfWMJvfr0f();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BITMAPFILEHEADER(BITMAPINFO info)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			knlH5qgbcUPnEH0KjeQ();
			int num = ((!e77U1egXMyx3lH70WeS()) ? 9 : 11);
			int num4 = default;
			int num5 = default;
			int num2 = default;
			int num3 = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					yYCBlxgpxcIv403eiAQ(this);
					num = 3;
					if (e77U1egXMyx3lH70WeS())
					{
						break;
					}
					goto case 2;
				case 2:
					num4 = info.bmiHeader.biBitCount / 8;
					goto case 5;
				default:
					num = 5;
					if (knlH5qgbcUPnEH0KjeQ())
					{
					}
					break;
				case 5:
					num5 = info.bmiHeader.biWidth * num4 % 4;
					goto case 7;
				case 4:
					bfSize = 14 + info.StreamedSize + num2;
					num = 12;
					break;
				case 1:
					bfReserved1 = 0;
					bfReserved2 = 0;
					num = 10;
					break;
				case 7:
				case 9:
					num3 = num4 * (info.bmiHeader.biWidth + num5);
					num = 8;
					break;
				case 10:
					bfOffBits = 14 + info.StreamedSize;
					num = 2;
					break;
				case 0:
				case 11:
					kt0U69g6FHfWMJvfr0f();
					num = 6;
					break;
				case 3:
					bfType = 19778;
					num = 1;
					break;
				case 8:
					num2 = bgEPQsg0Y8vQRlZ42Ir(info.bmiHeader.biHeight) * num3;
					num = 4;
					if (knlH5qgbcUPnEH0KjeQ())
					{
						return;
					}
					break;
				case 12:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Write(BinaryWriter bw)
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
				case 1:
				case 6:
					bw.Write(bfSize);
					goto case 2;
				case 3:
					l0JDDYgkgcmJZWNQQOD(bw, bfOffBits);
					num = 7;
					continue;
				case 5:
					TtVo6Wg4UlwZYmiIuLr(bw, bfType);
					_ = 1;
					if (knlH5qgbcUPnEH0KjeQ())
					{
						num = 4;
						if (0 == 0)
						{
							continue;
						}
						goto case 3;
					}
					num = 6;
					if (e77U1egXMyx3lH70WeS())
					{
						continue;
					}
					goto case 2;
				case 2:
				case 4:
					TtVo6Wg4UlwZYmiIuLr(bw, bfReserved1);
					break;
				default:
					num = 0;
					continue;
				case 0:
					break;
				case 7:
					return;
				}
				TtVo6Wg4UlwZYmiIuLr(bw, bfReserved2);
				num = 3;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Read(BinaryReader br)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (knlH5qgbcUPnEH0KjeQ())
			{
				goto IL_001e;
			}
			goto IL_00a0;
			IL_001e:
			bfOffBits = C3bJHigFo19I6QAY48E(br);
			num = 7;
			goto IL_00a0;
			IL_00a0:
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				default:
					bfReserved2 = gbQZsmgfT9UxTodNtaX(br);
					num = 5;
					continue;
				case 0:
					bfSize = C3bJHigFo19I6QAY48E(br);
					_ = 0;
					num = (e77U1egXMyx3lH70WeS() ? 1 : 6);
					continue;
				case 4:
					bfType = gbQZsmgfT9UxTodNtaX(br);
					num = 0;
					continue;
				case 1:
				case 2:
					bfReserved1 = br.ReadInt16();
					goto default;
				case 7:
					return;
				}
				break;
			}
			goto IL_001e;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void kt0U69g6FHfWMJvfr0f()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool e77U1egXMyx3lH70WeS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool knlH5qgbcUPnEH0KjeQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yYCBlxgpxcIv403eiAQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int bgEPQsg0Y8vQRlZ42Ir(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Math.Abs(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void TtVo6Wg4UlwZYmiIuLr(object P_0, short P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BinaryWriter)P_0).Write(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void l0JDDYgkgcmJZWNQQOD(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BinaryWriter)P_0).Write(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static short gbQZsmgfT9UxTodNtaX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BinaryReader)P_0).ReadInt16();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int C3bJHigFo19I6QAY48E(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BinaryReader)P_0).ReadInt32();
		}
	}

	public struct BITMAP
	{
		public int bmType;

		public int bmWidth;

		public int bmHeight;

		public int bmWidthBytes;

		public short bmPlanes;

		public short bmBitsPixel;

		public IntPtr bmBits;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public class LOGFONT
	{
		public int lfHeight;

		public int lfWidth;

		public int lfEscapement;

		public int lfOrientation;

		public int lfWeight;

		public byte lfItalic;

		public byte lfUnderline;

		public byte lfStrikeOut;

		public byte lfCharSet;

		public byte lfOutPrecision;

		public byte lfClipPrecision;

		public LogFontQuality lfQuality;

		public byte lfPitchAndFamily;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string lfFaceName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LOGFONT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			gnPhJjgJ88B5SaRMm9f();
			IsMeoEg8Mk326Ykdyoh(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gnPhJjgJ88B5SaRMm9f()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void IsMeoEg8Mk326Ykdyoh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VbO2VeggxtU5rNcWDNu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zyJOoqgZoZBYOg7gFjS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public enum LogFontQuality : byte
	{
		DEFAULT_QUALITY,
		DRAFT_QUALITY,
		PROOF_QUALITY,
		NONANTIALIASED_QUALITY,
		ANTIALIASED_QUALITY,
		CLEARTYPE_QUALITY
	}

	public enum LogFontCharSet : byte
	{
		ANSI_CHARSET = 0,
		DEFAULT_CHARSET = 1,
		SYMBOL_CHARSET = 2,
		MAC_CHARSET = 77,
		SHIFTJIS_CHARSET = 128,
		HANGEUL_CHARSET = 129,
		HANGUL_CHARSET = HANGEUL_CHARSET,
		JOHAB_CHARSET = 130,
		GB2312_CHARSET = 134,
		CHINESEBIG5_CHARSET = 136,
		GREEK_CHARSET = 161,
		TURKISH_CHARSET = 162,
		VIETNAMESE_CHARSET = 163,
		HEBREW_CHARSET = 177,
		ARABIC_CHARSET = 178,
		BALTIC_CHARSET = 186,
		RUSSIAN_CHARSET = 204,
		THAI_CHARSET = 222,
		EASTEUROPE_CHARSET = 238,
		OEM_CHARSET = byte.MaxValue
	}

	public struct LOGBRUSH
	{
		public int lbStyle;

		public int lbColor;

		public int lbHatch;
	}

	[Flags]
	public enum PS
	{
		PS_SOLID = 0,
		PS_DASH = 1,
		PS_DOT = 2,
		PS_DASHDOT = PS_DASH | PS_DOT,
		PS_DASHDOTDOT = 4,
		PS_NULL = PS_DASH | PS_DASHDOTDOT,
		PS_INSIDEFRAME = PS_DOT | PS_DASHDOTDOT,
		PS_USERSTYLE = PS_DASHDOT | PS_DASHDOTDOT,
		PS_ALTERNATE = 8,
		PS_ENDCAP_ROUND = 0,
		PS_ENDCAP_SQUARE = 0x100,
		PS_ENDCAP_FLAT = 0x200,
		PS_JOIN_ROUND = 0,
		PS_JOIN_BEVEL = 0x1000,
		PS_JOIN_MITER = 0x2000,
		PS_COSMETIC = 0,
		PS_GEOMETRIC = 0x10000
	}

	[Flags]
	public enum BS
	{
		BS_SOLID = 0,
		BS_NULL = 1,
		BS_HOLLOW = BS_NULL,
		BS_HATCHED = 2,
		BS_PATTERN = BS_NULL | BS_HATCHED,
		BS_INDEXED = 4,
		BS_DIBPATTERN = BS_NULL | BS_INDEXED,
		BS_DIBPATTERNPT = BS_HATCHED | BS_INDEXED,
		BS_PATTERN8X8 = BS_PATTERN | BS_INDEXED,
		BS_DIBPATTERN8X8 = 8,
		BS_MONOPATTERN = BS_NULL | BS_DIBPATTERN8X8
	}

	[Flags]
	public enum HS
	{
		HS_HORIZONTAL = 0,
		HS_VERTICAL = 1,
		HS_FDIAGONAL = 2,
		HS_BDIAGONAL = HS_VERTICAL | HS_FDIAGONAL,
		HS_CROSS = 4,
		HS_DIAGCROSS = HS_VERTICAL | HS_CROSS
	}

	public enum RGN
	{
		RGN_AND = 1,
		RGN_OR = 2,
		RGN_XOR = 3,
		RGN_DIFF = 4,
		RGN_COPY = 5,
		RGN_MIN = RGN_AND,
		RGN_MAX = RGN_COPY
	}

	public enum RasterOp
	{
		SRCCOPY = 13369376,
		SRCPAINT = 15597702,
		SRCAND = 8913094,
		SRCINVERT = 6684742,
		SRCERASE = 4457256,
		NOTSRCCOPY = 3342344,
		NOTSRCERASE = 1114278,
		MERGECOPY = 12583114,
		MERGEPAINT = 12255782,
		PATCOPY = 15728673,
		PATPAINT = 16452105,
		PATINVERT = 5898313,
		DSTINVERT = 5570569,
		BLACKNESS = 66,
		WHITENESS = 16711778,
		NO_OP = 11141161
	}

	public struct BLENDFUNCTION
	{
		public byte BlendOp;

		public byte BlendFlags;

		public byte SourceConstantAlpha;

		private byte AV47IyWFBN;

		public bool SourceAlpha
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return AV47IyWFBN != 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				AV47IyWFBN = (byte)(value ? 1 : 0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool F3EZ5UZiXbm3JBlJqMa()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Wim1s5Zqsh5F1vMw6mI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public enum DeviceCapsIndex
	{
		DRIVERVERSION = 0,
		TECHNOLOGY = 2,
		HORZSIZE = 4,
		VERTSIZE = 6,
		HORZRES = 8,
		VERTRES = 10,
		BITSPIXEL = 12,
		PLANES = 14,
		NUMBRUSHES = 16,
		NUMPENS = 18,
		NUMMARKERS = 20,
		NUMFONTS = 22,
		NUMCOLORS = 24,
		PDEVICESIZE = 26,
		CURVECAPS = 28,
		LINECAPS = 30,
		POLYGONALCAPS = 32,
		TEXTCAPS = 34,
		CLIPCAPS = 36,
		RASTERCAPS = 38,
		ASPECTX = 40,
		ASPECTY = 42,
		ASPECTXY = 44,
		LOGPIXELSX = 88,
		LOGPIXELSY = 90,
		SIZEPALETTE = 104,
		NUMRESERVED = 106,
		COLORRES = 108,
		PHYSICALWIDTH = 110,
		PHYSICALHEIGHT = 111,
		PHYSICALOFFSETX = 112,
		PHYSICALOFFSETY = 113,
		SCALINGFACTORX = 114,
		SCALINGFACTORY = 115,
		VREFRESH = 116,
		DESKTOPVERTRES = 117,
		DESKTOPHORZRES = 118,
		BLTALIGNMENT = 119,
		SHADEBLENDCAPS = 120,
		COLORMGMTCAPS = 121
	}

	public enum GdiStockObjects
	{
		BlackBrush = 4,
		DarkGrayBrush = 3,
		DcBrush = 18,
		GrayBrush = 2,
		NullBrush = 5,
		NullPen = 8,
		LtGrayBrush = 1,
		WhiteBrush = 0,
		BlackPen = 7,
		DcPen = 19,
		WhitePen = 6,
		AnsiFixedFont = 11,
		AnsiVarFont = 12,
		DeviceDefaultFont = 14,
		DefaultGuiFont = 17,
		OemFixedFont = 10,
		SystemFont = 13,
		SystemFixedFont = 16,
		DefaultPalette = 15
	}

	private enum DZXLldbP3vwdUUmLl3
	{

	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public struct TEXTMETRIC
	{
		public int tmHeight;

		public int tmAscent;

		public int tmDescent;

		public int tmInternalLeading;

		public int tmExternalLeading;

		public int tmAveCharWidth;

		public int tmMaxCharWidth;

		public int tmWeight;

		public int tmOverhang;

		public int tmDigitizedAspectX;

		public int tmDigitizedAspectY;

		public char tmFirstChar;

		public char tmLastChar;

		public char tmDefaultChar;

		public char tmBreakChar;

		public byte tmItalic;

		public byte tmUnderlined;

		public byte tmStruckOut;

		public byte tmPitchAndFamily;

		public byte tmCharSet;
	}

	public struct ABC
	{
		public int abcA;

		public int abcB;

		public int abcC;
	}

	[Flags]
	public enum ETO
	{
		ETO_CLIPPED = 4,
		ETO_NUMERICSLATIN = 0x800,
		ETO_NUMERICSLOCAL = 0x400,
		ETO_OPAQUE = 2
	}

	[Flags]
	public enum TextFormat
	{
		DT_TOP = 0,
		DT_LEFT = 0,
		DT_CENTER = 1,
		DT_RIGHT = 2,
		DT_VCENTER = 4,
		DT_BOTTOM = 8,
		DT_WORDBREAK = 0x10,
		DT_SINGLELINE = 0x20,
		DT_EXPANDTABS = 0x40,
		DT_TABSTOP = 0x80,
		DT_NOCLIP = 0x100,
		DT_EXTERNALLEADING = 0x200,
		DT_CALCRECT = 0x400,
		DT_NOPREFIX = 0x800,
		DT_INTERNAL = 0x1000,
		DT_EDITCONTROL = 0x2000,
		DT_PATH_ELLIPSIS = 0x4000,
		DT_END_ELLIPSIS = 0x8000,
		DT_MODIFYSTRING = 0x10000,
		DT_RTLREADING = 0x20000,
		DT_WORD_ELLIPSIS = 0x40000
	}

	[Flags]
	public enum TextOutFormat
	{
		Opaque = 2,
		Clipped = 4,
		GlyphIndex = 0x10,
		RtlReading = 0x80,
		NumericsLocal = 0x400,
		NumericsLatin = 0x800,
		IgnoreLanguage = 0x1000,
		Pdy = 0x2000
	}

	[Flags]
	public enum TextAlign
	{
		NoUpdateCP = 0,
		UpdateCP = 1,
		Left = 0,
		Right = 2,
		Center = 6,
		Top = 0,
		Bottom = 8,
		Baseline = 0x18,
		RtlReading = 0x100
	}

	public enum R2
	{
		R2_COPYPEN = 13,
		R2_NOT = 6
	}

	public enum BkMode
	{
		TRANSPARENT = 1,
		OPAQUE
	}

	public enum GraphicsMode
	{
		GM_COMPATIBLE = 1,
		GM_ADVANCED
	}

	public const int DIB_RGB_COLORS = 0;

	public const int BI_RGB = 0;

	public const int BI_BITFIELDS = 3;

	public const int STRETCH_DELETESCANS = 3;

	public const int STRETCH_HALFTONE = 4;

	public const int CLR_INVALID = -1;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void CopyMemory(IntPtr destination, IntPtr source, int length)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		kfyWoGaVJ(destination, source, length);
	}

	[DllImport("Kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "RtlMoveMemory")]
	private static extern void kfyWoGaVJ(IntPtr P_0, IntPtr P_1, int P_2);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetObject(IntPtr hGdiObj, int cbBuffer, IntPtr lpvObject)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return bJ73TV4n6(hGdiObj, cbBuffer, lpvObject);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "GetObject")]
	private static extern int bJ73TV4n6(IntPtr P_0, int P_1, IntPtr P_2);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr CreateRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return zrYLVFj1F(nLeftRect, nTopRect, nRightRect, nBottomRect);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "CreateRectRgn")]
	private static extern IntPtr zrYLVFj1F(int P_0, int P_1, int P_2, int P_3);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr CreatePolygonRgn(CnxVector2[] lppt, int cPoints, int fnPolyFillMode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return JBtky1Ecy(lppt, cPoints, fnPolyFillMode);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "CreatePolygonRgn")]
	private static extern IntPtr JBtky1Ecy(CnxVector2[] P_0, int P_1, int P_2);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetRgnBox(IntPtr hrgn, out RECT lprc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return TPQXk0rof(hrgn, out lprc);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "GetRgnBox")]
	private static extern int TPQXk0rof(IntPtr P_0, out RECT P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int CombineRgn(IntPtr hrgnDest, IntPtr hrgnSrc1, IntPtr hrgnSrc2, RGN fnCombineMode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return WX2fSnD2F(hrgnDest, hrgnSrc1, hrgnSrc2, fnCombineMode);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "CombineRgn")]
	private static extern int WX2fSnD2F(IntPtr P_0, IntPtr P_1, IntPtr P_2, RGN P_3);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, int bRedraw)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return U0jjQPISZ(hWnd, hRgn, bRedraw);
	}

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "SetWindowRgn")]
	private static extern int U0jjQPISZ(IntPtr P_0, IntPtr P_1, int P_2);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int SetStretchBltMode(IntPtr hdc, int iStretchMode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return z4Ec7xjM7(hdc, iStretchMode);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "SetStretchBltMode")]
	private static extern int z4Ec7xjM7(IntPtr P_0, int P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, RasterOp dwRop)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return j9f5p4ncA(hdcDest, nXDest, nYDest, nWidth, nHeight, hdcSrc, nXSrc, nYSrc, dwRop);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "BitBlt")]
	private static extern bool j9f5p4ncA(IntPtr P_0, int P_1, int P_2, int P_3, int P_4, IntPtr P_5, int P_6, int P_7, RasterOp P_8);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TransparentBlt(IntPtr hdcDest, int nXOriginDest, int nYOriginDest, int nWidthDest, int hHeightDest, IntPtr hdcSrc, int nXOriginSrc, int nYOriginSrc, int nWidthSrc, int hHeightSrc, int crTransparent)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return BYaYj3KgR(hdcDest, nXOriginDest, nYOriginDest, nWidthDest, hHeightDest, hdcSrc, nXOriginSrc, nYOriginSrc, nWidthSrc, hHeightSrc, crTransparent);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "GdiTransparentBlt")]
	private static extern bool BYaYj3KgR(IntPtr P_0, int P_1, int P_2, int P_3, int P_4, IntPtr P_5, int P_6, int P_7, int P_8, int P_9, int P_10);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool StretchBlt(IntPtr hdcDest, int nXOriginDest, int nYOriginDest, int nWidthDest, int nHeightDest, IntPtr hdcSrc, int nXOriginSrc, int nYOriginSrc, int nWidthSrc, int nHeightSrc, RasterOp dwRop)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return NZr7RFTIM(hdcDest, nXOriginDest, nYOriginDest, nWidthDest, nHeightDest, hdcSrc, nXOriginSrc, nYOriginSrc, nWidthSrc, nHeightSrc, dwRop);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "StretchBlt")]
	private static extern bool NZr7RFTIM(IntPtr P_0, int P_1, int P_2, int P_3, int P_4, IntPtr P_5, int P_6, int P_7, int P_8, int P_9, RasterOp P_10);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool MaskBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, IntPtr hbmMask, int xMask, int yMask, int dwRop)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PnjmyFRkO(hdcDest, nXDest, nYDest, nWidth, nHeight, hdcSrc, nXSrc, nYSrc, hbmMask, xMask, yMask, dwRop);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "MaskBlt", SetLastError = true)]
	private static extern bool PnjmyFRkO(IntPtr P_0, int P_1, int P_2, int P_3, int P_4, IntPtr P_5, int P_6, int P_7, IntPtr P_8, int P_9, int P_10, int P_11);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int MAKEROP4(RasterOp fore, RasterOp back)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (((int)back << 8) & -16777216) | (int)fore;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool AlphaBlend(IntPtr hdcDest, int nXOriginDest, int nYOriginDest, int nWidthDest, int nHeightDest, IntPtr hdcSrc, int nXOriginSrc, int nYOriginSrc, int nWidthSrc, int nHeightSrc, BLENDFUNCTION blendFunction)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Q4Wn5SQj3(hdcDest, nXOriginDest, nYOriginDest, nWidthDest, nHeightDest, hdcSrc, nXOriginSrc, nYOriginSrc, nWidthSrc, nHeightSrc, blendFunction);
	}

	[DllImport("Msimg32.dll", CharSet = CharSet.Auto, EntryPoint = "AlphaBlend")]
	private static extern bool Q4Wn5SQj3(IntPtr P_0, int P_1, int P_2, int P_3, int P_4, IntPtr P_5, int P_6, int P_7, int P_8, int P_9, BLENDFUNCTION P_10);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static void BlitGrayToRGB565(byte* source, short* dest, int sourceStride, int destStep, int destStride, int destSizeX, int destSizeY)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		int num3 = default;
		int num2 = default;
		short* grayscaleTo565Table = default;
		short* ptr = default;
		while (true)
		{
			switch (num)
			{
			case 9:
				source += sourceStride;
				num = 7;
				if (true)
				{
					break;
				}
				goto case 0;
			case 3:
				num3 = destSizeY;
				num = 0;
				break;
			case 5:
			case 11:
				num2++;
				goto default;
			case 7:
				dest += destStride;
				num = 1;
				if (haiIIAhNll1rtkUX8rw())
				{
					break;
				}
				goto case 10;
			case 10:
				grayscaleTo565Table = CnxColorConversion.GrayscaleTo565Table;
				num = 3;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 1:
				if (num3-- > 0)
				{
					ptr = dest;
					num = 8;
				}
				else
				{
					num = 12;
				}
				break;
			default:
				if (num2 >= destSizeX)
				{
					num = 9;
					break;
				}
				*(ptr++) = grayscaleTo565Table[(int)source[num2]];
				_ = 0;
				num = (haiIIAhNll1rtkUX8rw() ? 11 : 4);
				break;
			case 8:
				num2 = 0;
				goto default;
			case 2:
				destStride /= 2;
				num = 10;
				if (FBqGUQhxfjqqi4RyyBp())
				{
					return;
				}
				break;
			case 12:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static void BlitColorToRGB565(byte* source, short* dest, int sourceType, int sourceStride, int destStep, int destStride, int destSizeX, int destSizeY)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		int num3 = default;
		int num5 = default;
		short* ptr = default;
		int num4 = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				num3++;
				_ = 1;
				if (!FBqGUQhxfjqqi4RyyBp())
				{
					num = 4;
					continue;
				}
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 3:
				dest += destStride;
				goto case 16;
			case 16:
				if (num5-- <= 0)
				{
					num = 18;
					continue;
				}
				ptr = dest;
				num = 15;
				continue;
			case 6:
			case 8:
				if (num4 >= destSizeX)
				{
					break;
				}
				*(ptr++) |= (short)(source[num4] >> 3);
				num4++;
				num = 8;
				continue;
			case 1:
				destStride /= 2;
				num = 13;
				continue;
			case 2:
			case 4:
			case 11:
				if (num3 >= destSizeX)
				{
					break;
				}
				*(ptr++) |= (short)((source[num3] & 0xFC) << 3);
				num = 7;
				continue;
			case 17:
				num2 = 0;
				num = 9;
				if (0 == 0)
				{
					continue;
				}
				goto case 16;
			case 13:
				num5 = destSizeY;
				num = 16;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				num3 = 0;
				goto case 2;
			default:
				num = 2;
				continue;
			case 9:
			case 12:
				if (num2 < destSizeX)
				{
					*(ptr++) = (short)((source[num2] & 0xF8) << 8);
					num2++;
					num = 12;
					if (0 == 0)
					{
						continue;
					}
					goto case 6;
				}
				num = 10;
				if (!FBqGUQhxfjqqi4RyyBp())
				{
					continue;
				}
				goto case 15;
			case 15:
				if (sourceType == 2)
				{
					num = 17;
					continue;
				}
				if (sourceType != 1)
				{
					num4 = 0;
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					goto case 2;
				}
				num = 5;
				continue;
			case 0:
			case 10:
			case 14:
				break;
			case 18:
				return;
			}
			source += sourceStride;
			num = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static void Blit24bppRgbToRGB565(byte* source, short* dest, int sourceStride, int destStep, int destStride, int destSizeX, int destSizeY)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!haiIIAhNll1rtkUX8rw())
		{
			goto IL_001e;
		}
		goto IL_0066;
		IL_001e:
		int num2 = 0;
		num = 4;
		goto IL_0066;
		IL_0066:
		int num4 = default;
		short* ptr2 = default;
		int num3 = default;
		byte* ptr = default;
		while (true)
		{
			switch (num)
			{
			case 13:
				break;
			case 1:
				num4 = destSizeY;
				num = 10;
				if (true)
				{
					continue;
				}
				goto case 14;
			case 14:
				ptr2 = dest;
				num = 13;
				continue;
			default:
				num = 3;
				continue;
			case 7:
				ptr2 += destStep;
				num = 6;
				if (true)
				{
					continue;
				}
				goto case 8;
			case 8:
			case 11:
				*ptr2 = (short)(num3 | ((*(ptr++) << 8) & 0xF800));
				num = 7;
				continue;
			case 5:
				destStep /= 2;
				num = 1;
				continue;
			case 6:
				num2++;
				num = 2;
				continue;
			case 2:
			case 4:
				if (num2 < destSizeX)
				{
					num3 = *(ptr++) >> 3;
					goto case 3;
				}
				source += sourceStride;
				dest += destStride;
				goto case 9;
			case 0:
				destStride /= 2;
				num = 5;
				continue;
			case 9:
			case 10:
			case 12:
				if (num4-- > 0)
				{
					ptr = source;
					num = 14;
					continue;
				}
				num = 15;
				if (0 == 0)
				{
					continue;
				}
				goto case 3;
			case 3:
				num3 |= (*(ptr++) << 3) & 0x7E0;
				FBqGUQhxfjqqi4RyyBp();
				num = (haiIIAhNll1rtkUX8rw() ? 11 : 9);
				continue;
			case 15:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static void BlitGrayTo24bppRgb(byte* source, byte* dest, int sourceStride, int destStep, int destStride, int destSizeX, int destSizeY)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		int num3 = default;
		byte* ptr2 = default;
		int num4 = default;
		byte* ptr = default;
		byte b = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 10:
			case 11:
				if (num3-- <= 0)
				{
					num = 15;
					break;
				}
				ptr2 = source;
				num = 14;
				break;
			case 9:
				num4 = 0;
				goto case 3;
			case 6:
				num3 = destSizeY;
				haiIIAhNll1rtkUX8rw();
				if (!FBqGUQhxfjqqi4RyyBp())
				{
					num = 12;
					if (haiIIAhNll1rtkUX8rw())
					{
						break;
					}
					goto case 5;
				}
				num = 10;
				if (FBqGUQhxfjqqi4RyyBp())
				{
				}
				break;
			case 5:
				num4++;
				num = 3;
				break;
			case 14:
				ptr = dest;
				num = 9;
				break;
			case 0:
				*(ptr++) = b;
				num = 13;
				break;
			case 7:
				*ptr = b;
				ptr += num2;
				num = 5;
				break;
			case 3:
				if (num4 < destSizeX)
				{
					b = *(ptr2++);
					num = 0;
				}
				else
				{
					num = 4;
				}
				break;
			case 1:
			case 12:
				num2 = destStep - 2;
				goto case 2;
			case 4:
				source += sourceStride;
				num = 8;
				break;
			case 8:
				dest += destStride;
				num = 11;
				if (haiIIAhNll1rtkUX8rw())
				{
					break;
				}
				goto case 13;
			case 13:
				*(ptr++) = b;
				goto case 7;
			default:
				num = 7;
				break;
			case 15:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static void BlitColorTo24bppRgb(byte* source, byte* dest, int sourceType, int sourceStride, int destStep, int destStride, int destSizeX, int destSizeY)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!FBqGUQhxfjqqi4RyyBp())
		{
		}
		int num3 = default;
		int num2 = default;
		byte* ptr = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				num3++;
				goto default;
			default:
				haiIIAhNll1rtkUX8rw();
				if (!FBqGUQhxfjqqi4RyyBp())
				{
					num = 10;
					continue;
				}
				num = 9;
				if (haiIIAhNll1rtkUX8rw())
				{
					continue;
				}
				goto case 4;
			case 0:
				num2 = destSizeY;
				num = 3;
				continue;
			case 5:
			case 7:
			case 10:
				if (num3 < destSizeX)
				{
					*ptr = source[num3];
					ptr += 3;
					num = 8;
					continue;
				}
				break;
			case 4:
				dest += destStride;
				num = 1;
				continue;
			case 2:
				num3 = 0;
				num = 7;
				continue;
			case 1:
			case 3:
				if (num2-- > 0)
				{
					ptr = dest + sourceType;
					num = 2;
					if (haiIIAhNll1rtkUX8rw())
					{
						continue;
					}
					goto case 8;
				}
				num = 11;
				continue;
			case 6:
			case 9:
				break;
			case 11:
				return;
			}
			source += sourceStride;
			num = 4;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static void BlitRGB565To24bppRgb(short* source, byte* dest, int sourceStride, int destStep, int destStride, int destSizeX, int destSizeY)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		byte* ptr = default;
		int num4 = default;
		int num2 = default;
		short* ptr2 = default;
		int num3 = default;
		int num5 = default;
		while (true)
		{
			switch (num)
			{
			case 12:
				*(ptr++) = (byte)(((num4 & 0x7E0) >> 3) * 65 >> 6);
				goto case 2;
			default:
				num = 2;
				continue;
			case 2:
				*ptr = (byte)(((num4 & 0xF800) >> 8) * 33 >> 5);
				num = 8;
				continue;
			case 1:
			case 4:
				if (num2-- > 0)
				{
					ptr2 = source;
					num = 0;
					continue;
				}
				num = 15;
				if (FBqGUQhxfjqqi4RyyBp())
				{
				}
				continue;
			case 10:
			case 14:
				if (num3 >= destSizeX)
				{
					num = 9;
					continue;
				}
				num4 = *(ptr2++);
				FBqGUQhxfjqqi4RyyBp();
				num = (haiIIAhNll1rtkUX8rw() ? 13 : 14);
				continue;
			case 9:
				source += sourceStride;
				dest += destStride;
				num = 4;
				continue;
			case 3:
				num5 = destStep - 2;
				num = 1;
				continue;
			case 7:
				num3++;
				goto case 10;
			case 6:
				sourceStride /= 2;
				num = 11;
				continue;
			case 5:
			case 13:
				*(ptr++) = (byte)(((num4 & 0x1F) << 3) * 33 >> 5);
				num = 12;
				continue;
			case 0:
				ptr = dest;
				num3 = 0;
				goto case 10;
			case 11:
				num2 = destSizeY;
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 8:
				break;
			case 15:
				return;
			}
			ptr += num5;
			num = 7;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static int StretchGrayToGray(byte* source, byte* dest, int sourceStride, int destStep, int destStride, int destSizeX, int destSizeY, int sourceMaxY, int sourceDX16, int sourceDY16, ref int pSourceX16, ref int pSourceY16)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_01b6;
		IL_001a:
		byte* ptr = dest;
		int num2 = pSourceX16;
		int num3 = default;
		if (destStep == 1)
		{
			num = 14;
		}
		else
		{
			num3 = destSizeX;
			num = 18;
		}
		goto IL_01b6;
		IL_01b6:
		int num6 = default;
		int num7 = default;
		int num4 = default;
		byte* ptr2 = default;
		int num5 = default;
		while (true)
		{
			switch (num)
			{
			case 5:
			case 16:
				break;
			case 9:
			case 17:
				num6 += sourceDY16;
				num = 21;
				if (true)
				{
					continue;
				}
				goto case 14;
			case 14:
				num7 = destSizeX;
				goto case 19;
			case 4:
				pSourceY16 = num6;
				num = 22;
				if (0 == 0)
				{
					continue;
				}
				goto case 6;
			case 6:
				num7--;
				num = 19;
				continue;
			case 21:
				dest += destStride;
				num4--;
				num = 7;
				continue;
			case 13:
				ptr2 = source + num5 * sourceStride;
				break;
			case 0:
				num6 = pSourceY16;
				num = 2;
				continue;
			case 1:
			case 18:
				if (num3 <= 0)
				{
					num = 9;
					if (FBqGUQhxfjqqi4RyyBp())
					{
					}
					continue;
				}
				*ptr = ptr2[num2 >> 16];
				goto case 15;
			case 12:
				num3--;
				num = 1;
				if (true)
				{
					continue;
				}
				goto case 9;
			case 15:
				num2 += sourceDX16;
				num = 10;
				continue;
			case 2:
				num4 = destSizeY;
				_ = 1;
				num = ((!FBqGUQhxfjqqi4RyyBp()) ? 20 : 16);
				continue;
			case 11:
				pSourceX16 = num2;
				num = 4;
				if (haiIIAhNll1rtkUX8rw())
				{
					continue;
				}
				goto case 3;
			case 3:
			case 7:
			case 20:
				if (num4 <= 0)
				{
					num = 11;
					continue;
				}
				num5 = num6 >> 16;
				if (num5 > sourceMaxY)
				{
					goto case 11;
				}
				num = 13;
				if (haiIIAhNll1rtkUX8rw())
				{
					continue;
				}
				goto case 8;
			case 19:
				if (num7 > 0)
				{
					*(ptr++) = ptr2[num2 >> 16];
					num2 += sourceDX16;
					num = 6;
				}
				else
				{
					num = 17;
				}
				continue;
			case 8:
				num2 = pSourceX16;
				num = 0;
				continue;
			default:
				num = 15;
				continue;
			case 10:
				ptr += destStep;
				num = 12;
				continue;
			case 22:
				return destSizeY - num4;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static int StretchGrayToRGB565(byte* source, short* dest, int sourceStride, int destStep, int destStride, int destSizeX, int destSizeY, int sourceMaxY, int sourceDX16, int sourceDY16, ref int pSourceX16, ref int pSourceY16)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 15;
		int num5 = default;
		short* grayscaleTo565Table = default;
		int num4 = default;
		int num6 = default;
		short* ptr = default;
		int num2 = default;
		int num7 = default;
		int num3 = default;
		byte* ptr2 = default;
		while (true)
		{
			switch (num)
			{
			case 18:
				pSourceY16 = num5;
				num = 24;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
			case 6:
				destStride /= 2;
				grayscaleTo565Table = CnxColorConversion.GrayscaleTo565Table;
				num = 17;
				break;
			case 17:
				num4 = pSourceX16;
				num = 14;
				break;
			case 21:
				if (num6 <= sourceMaxY)
				{
					num = 2;
					break;
				}
				goto IL_0169;
			case 13:
				ptr += destStep;
				num = 23;
				break;
			case 7:
				num2--;
				num = 20;
				break;
			case 12:
				if (destStep == 1)
				{
					num7 = destSizeX;
					goto case 10;
				}
				num3 = destSizeX;
				num = 8;
				break;
			case 11:
				num4 += sourceDX16;
				goto case 4;
			default:
				num = 4;
				break;
			case 9:
				num4 = pSourceX16;
				num = 12;
				break;
			case 2:
				ptr2 = source + num6 * sourceStride;
				num = 22;
				break;
			case 0:
			case 20:
				while (num2 > 0)
				{
					num6 = num5 >> 16;
					num = 21;
					if (0 == 0)
					{
						goto end_IL_00b8;
					}
				}
				goto IL_0169;
			case 14:
				num5 = pSourceY16;
				num2 = destSizeY;
				num = 0;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
			case 8:
				if (num3 > 0)
				{
					*ptr = grayscaleTo565Table[(int)ptr2[num4 >> 16]];
					num = 3;
					break;
				}
				goto case 19;
			case 19:
				num5 += sourceDY16;
				dest += destStride;
				num = 7;
				break;
			case 4:
				num7--;
				goto case 10;
			case 10:
			case 16:
				if (num7 <= 0)
				{
					num = 19;
					if (!FBqGUQhxfjqqi4RyyBp())
					{
						break;
					}
					goto case 15;
				}
				*(ptr++) = grayscaleTo565Table[(int)ptr2[num4 >> 16]];
				num = 11;
				break;
			case 15:
				destStep /= 2;
				_ = 1;
				if (FBqGUQhxfjqqi4RyyBp())
				{
					num = 16;
					if (haiIIAhNll1rtkUX8rw())
					{
						break;
					}
					goto case 11;
				}
				num = 6;
				break;
			case 3:
				num4 += sourceDX16;
				num = 13;
				break;
			case 23:
				num3--;
				num = 5;
				break;
			case 22:
				ptr = dest;
				num = 9;
				break;
			case 24:
				{
					return destSizeY - num2;
				}
				IL_0169:
				pSourceX16 = num4;
				num = 18;
				break;
				end_IL_00b8:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static int StretchColorToRGB565(byte* source, short* dest, int sourceType, int sourceStride, int destStep, int destStride, int destSizeX, int destSizeY, int sourceMaxY, int sourceDX16, int sourceDY16, ref int pSourceX16, ref int pSourceY16)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		int num3 = default;
		int num11 = default;
		int num10 = default;
		int num5 = default;
		int num2 = default;
		int num9 = default;
		int num7 = default;
		short* ptr = default;
		byte* ptr2 = default;
		int num4 = default;
		int num6 = default;
		int num8 = default;
		while (true)
		{
			switch (num)
			{
			case 36:
				if (sourceType == 2)
				{
					if (destStep == 1)
					{
						num = 12;
						break;
					}
					num3 = destSizeX;
					num = 20;
					break;
				}
				if (sourceType != 1)
				{
					if (destStep == 1)
					{
						num11 = destSizeX;
						goto case 15;
					}
					num10 = destSizeX;
					num = 19;
					if (FBqGUQhxfjqqi4RyyBp())
					{
					}
					break;
				}
				if (destStep == 1)
				{
					num = 28;
					if (haiIIAhNll1rtkUX8rw())
					{
						break;
					}
					goto case 24;
				}
				num5 = destSizeX;
				num = 29;
				break;
			case 17:
			case 37:
			case 38:
				if (num2 > 0)
				{
					num9 = num7 >> 16;
					num = 26;
					break;
				}
				goto IL_0038;
			case 2:
				num5--;
				goto case 29;
			case 29:
				if (num5 <= 0)
				{
					num = 14;
					break;
				}
				*ptr |= (short)((ptr2[num4 >> 16] & 0xFC) << 3);
				num = 39;
				break;
			case 21:
				num6--;
				num = 0;
				break;
			case 0:
			case 34:
				if (num6 <= 0)
				{
					num = 27;
					break;
				}
				*(ptr++) = (short)((ptr2[num4 >> 16] & 0xF8) << 8);
				num = 40;
				break;
			case 9:
				num4 += sourceDX16;
				num11--;
				num = 15;
				if (!FBqGUQhxfjqqi4RyyBp())
				{
					break;
				}
				goto case 8;
			case 8:
				num3--;
				num = 35;
				break;
			case 7:
				ptr = dest;
				num4 = pSourceX16;
				num = 36;
				break;
			case 11:
				num8--;
				num = 24;
				break;
			case 33:
				num4 += sourceDX16;
				goto case 11;
			default:
				num = 11;
				if (FBqGUQhxfjqqi4RyyBp())
				{
				}
				break;
			case 1:
			case 22:
				destStride /= 2;
				num4 = pSourceX16;
				num7 = pSourceY16;
				num = 18;
				if (!FBqGUQhxfjqqi4RyyBp())
				{
					break;
				}
				goto case 17;
			case 6:
			case 19:
				if (num10 <= 0)
				{
					num = 31;
					break;
				}
				*ptr |= (short)(ptr2[num4 >> 16] >> 3);
				num = 5;
				if (true)
				{
					break;
				}
				goto case 13;
			case 10:
				ptr2 = source + num9 * sourceStride;
				num = 7;
				if (true)
				{
					break;
				}
				goto case 4;
			case 4:
				ptr += destStep;
				num = 30;
				if (0 == 0)
				{
					break;
				}
				goto case 30;
			case 30:
				num10--;
				num = 6;
				break;
			case 24:
				if (num8 <= 0)
				{
					num = 16;
					break;
				}
				*(ptr++) |= (short)((ptr2[num4 >> 16] & 0xFC) << 3);
				num = 33;
				if (0 == 0)
				{
					break;
				}
				goto case 26;
			case 32:
				dest += destStride;
				num2--;
				goto case 17;
			case 5:
				num4 += sourceDX16;
				num = 4;
				break;
			case 15:
				if (num11 > 0)
				{
					*(ptr++) |= (short)(ptr2[num4 >> 16] >> 3);
					num = 9;
					break;
				}
				num = 25;
				if (haiIIAhNll1rtkUX8rw())
				{
					break;
				}
				goto case 28;
			case 28:
				num8 = destSizeX;
				goto case 24;
			case 26:
				if (num9 <= sourceMaxY)
				{
					num = 10;
					break;
				}
				goto IL_0038;
			case 18:
				num2 = destSizeY;
				num = 38;
				if (true)
				{
					break;
				}
				goto case 40;
			case 40:
				num4 += sourceDX16;
				num = 21;
				break;
			case 13:
			case 14:
			case 16:
			case 25:
			case 27:
			case 31:
				num7 += sourceDY16;
				num = 32;
				break;
			case 3:
				destStep /= 2;
				_ = 0;
				if (!haiIIAhNll1rtkUX8rw())
				{
					num = 17;
					break;
				}
				num = 22;
				if (!FBqGUQhxfjqqi4RyyBp())
				{
					break;
				}
				goto case 0;
			case 39:
				num4 += sourceDX16;
				ptr += destStep;
				num = 2;
				break;
			case 20:
			case 35:
				if (num3 > 0)
				{
					*ptr = (short)((ptr2[num4 >> 16] & 0xF8) << 8);
					num4 += sourceDX16;
					ptr += destStep;
					num = 8;
					if (0 == 0)
					{
						break;
					}
					goto case 13;
				}
				num = 13;
				if (0 == 0)
				{
					break;
				}
				goto case 12;
			case 12:
				num6 = destSizeX;
				num = 34;
				if (true)
				{
					break;
				}
				goto case 23;
			case 23:
				pSourceY16 = num7;
				num = 41;
				break;
			case 41:
				{
					return destSizeY - num2;
				}
				IL_0038:
				pSourceX16 = num4;
				num = 23;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static int StretchRGB565ToRGB565(short* source, short* dest, int sourceStride, int destStep, int destStride, int destSizeX, int destSizeY, int sourceMaxY, int sourceDX16, int sourceDY16, ref int pSourceX16, ref int pSourceY16)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		int num3 = default;
		int num7 = default;
		short* ptr2 = default;
		int num6 = default;
		int num5 = default;
		short* ptr = default;
		int num4 = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 18:
				num3 = pSourceX16;
				num7 = pSourceY16;
				num = 22;
				continue;
			case 11:
				ptr2 = source + num6 * sourceStride;
				num = 17;
				continue;
			case 22:
				num5 = destSizeY;
				num = 8;
				if (FBqGUQhxfjqqi4RyyBp())
				{
				}
				continue;
			case 6:
				pSourceX16 = num3;
				goto case 9;
			case 9:
			case 21:
				pSourceY16 = num7;
				num = 24;
				continue;
			case 8:
			case 19:
				if (num5 <= 0)
				{
					num = 6;
					continue;
				}
				num6 = num7 >> 16;
				num = 7;
				continue;
			case 7:
				if (num6 > sourceMaxY)
				{
					goto case 6;
				}
				num = 11;
				if (0 == 0)
				{
					continue;
				}
				goto case 17;
			case 17:
				ptr = dest;
				num = 15;
				if (true)
				{
					continue;
				}
				goto case 10;
			case 10:
				destStep /= 2;
				destStride /= 2;
				num = 18;
				continue;
			case 3:
				num4--;
				num = 23;
				continue;
			case 4:
				sourceStride /= 2;
				num = 10;
				continue;
			case 1:
				num2--;
				goto default;
			default:
				haiIIAhNll1rtkUX8rw();
				if (FBqGUQhxfjqqi4RyyBp())
				{
					num = 9;
					continue;
				}
				num = 5;
				if (!FBqGUQhxfjqqi4RyyBp())
				{
					continue;
				}
				goto case 14;
			case 14:
			case 23:
				if (num4 > 0)
				{
					*ptr = ptr2[num3 >> 16];
					num3 += sourceDX16;
					ptr += destStep;
					num = 3;
				}
				else
				{
					num = 2;
					if (FBqGUQhxfjqqi4RyyBp())
					{
					}
				}
				continue;
			case 0:
			case 2:
				num7 += sourceDY16;
				dest += destStride;
				num = 13;
				continue;
			case 20:
				num3 += sourceDX16;
				num = 1;
				if (haiIIAhNll1rtkUX8rw())
				{
					continue;
				}
				goto case 13;
			case 13:
				num5--;
				num = 19;
				continue;
			case 5:
			case 12:
				if (num2 <= 0)
				{
					num = 0;
					continue;
				}
				*(ptr++) = ptr2[num3 >> 16];
				num = 20;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 15:
				num3 = pSourceX16;
				if (destStep != 1)
				{
					num4 = destSizeX;
					num = 14;
					if (0 == 0)
					{
						continue;
					}
					goto case 6;
				}
				num = 16;
				continue;
			case 16:
				num2 = destSizeX;
				goto case 5;
			case 24:
				break;
			}
			break;
		}
		return destSizeY - num5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static int Stretch24bppRgbToRGB565(byte* source, short* dest, int sourceStride, int destStep, int destStride, int destSizeX, int destSizeY, int sourceMaxY, int sourceDX16, int sourceDY16, ref int pSourceX16, ref int pSourceY16)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		int num3 = default;
		int num2 = default;
		int num6 = default;
		short* ptr = default;
		byte* ptr2 = default;
		int num7 = default;
		int num5 = default;
		int num4 = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				num3 = pSourceY16;
				num = 1;
				continue;
			case 6:
				pSourceX16 = num2;
				num = 4;
				continue;
			case 15:
				num2 = pSourceX16;
				haiIIAhNll1rtkUX8rw();
				if (!FBqGUQhxfjqqi4RyyBp())
				{
					num = 0;
					continue;
				}
				num = 12;
				if (true)
				{
					continue;
				}
				goto case 13;
			case 5:
				num3 += sourceDY16;
				dest += destStride;
				num = 18;
				if (FBqGUQhxfjqqi4RyyBp())
				{
				}
				continue;
			case 9:
				num6--;
				num = 17;
				continue;
			case 14:
				num6 = destSizeX;
				goto default;
			case 13:
				*(ptr++) = (short)(((ptr2[num7] >> 3) & 0x1F) | ((ptr2[num7 + 1] << 3) & 0x7E0) | ((ptr2[num7 + 2] << 8) & 0xF800));
				num2 += sourceDX16;
				ptr += destStep;
				num = 9;
				continue;
			case 1:
				num5 = destSizeY;
				num = 11;
				continue;
			default:
				if (num6 > 0)
				{
					num7 = 3 * (num2 >> 16);
					num = 13;
					continue;
				}
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 19;
			case 19:
				ptr2 = source + num4 * sourceStride;
				num = 7;
				continue;
			case 18:
				num5--;
				goto case 11;
			case 11:
				if (num5 <= 0)
				{
					num = 6;
					continue;
				}
				num4 = num3 >> 16;
				num = 16;
				continue;
			case 16:
				if (num4 <= sourceMaxY)
				{
					num = 19;
					if (FBqGUQhxfjqqi4RyyBp())
					{
					}
					continue;
				}
				goto case 6;
			case 4:
				pSourceY16 = num3;
				num = 20;
				continue;
			case 8:
				destStride /= 2;
				num = 15;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
				destStep /= 2;
				num = 8;
				if (true)
				{
					continue;
				}
				goto case 11;
			case 7:
				ptr = dest;
				num2 = pSourceX16;
				num = 14;
				if (haiIIAhNll1rtkUX8rw())
				{
					continue;
				}
				break;
			case 20:
				break;
			}
			break;
		}
		return destSizeY - num5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static int StretchGrayTo24bppRgb(byte* source, byte* dest, int sourceStride, int destStep, int destStride, int destSizeX, int destSizeY, int sourceMaxY, int sourceDX16, int sourceDY16, ref int pSourceX16, ref int pSourceY16)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 11;
		int num2 = default;
		int num6 = default;
		int num3 = default;
		int num4 = default;
		int num5 = default;
		int num7 = default;
		byte* ptr = default;
		byte* ptr2 = default;
		byte b = default;
		while (true)
		{
			switch (num)
			{
			case 16:
				num2 = destSizeY;
				num = 0;
				break;
			case 15:
				num6 += sourceDY16;
				dest += destStride;
				num2--;
				num = 8;
				break;
			case 5:
			case 13:
				num3 += sourceDX16;
				num4--;
				num = 19;
				break;
			case 0:
			case 8:
				if (num2 <= 0)
				{
					num = 1;
					break;
				}
				num5 = num6 >> 16;
				num = 20;
				if (FBqGUQhxfjqqi4RyyBp())
				{
				}
				break;
			case 20:
				if (num5 <= sourceMaxY)
				{
					num = 10;
					if (true)
					{
						break;
					}
					goto case 0;
				}
				goto case 1;
			case 7:
				num6 = pSourceY16;
				num = 16;
				break;
			case 1:
				pSourceX16 = num3;
				num = 3;
				break;
			case 17:
				num3 = pSourceX16;
				num7 = destStep - 2;
				num4 = destSizeX;
				num = 18;
				break;
			case 6:
			case 9:
				ptr = dest;
				num = 17;
				break;
			case 10:
				ptr2 = source + num5 * sourceStride;
				haiIIAhNll1rtkUX8rw();
				if (!FBqGUQhxfjqqi4RyyBp())
				{
					num = 9;
					if (0 == 0)
					{
						break;
					}
					goto case 3;
				}
				num = 5;
				if (true)
				{
					break;
				}
				goto case 4;
			case 3:
				pSourceY16 = num6;
				num = 21;
				break;
			case 12:
				*(ptr++) = b;
				num = 2;
				if (0 == 0)
				{
					break;
				}
				goto case 14;
			case 14:
				ptr += num7;
				goto case 5;
			case 4:
				*(ptr++) = b;
				goto case 12;
			default:
				num = 12;
				break;
			case 18:
			case 19:
				if (num4 > 0)
				{
					b = ptr2[num3 >> 16];
					num = 4;
					if (0 == 0)
					{
						break;
					}
					goto case 5;
				}
				num = 15;
				break;
			case 11:
				num3 = pSourceX16;
				num = 7;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
				*ptr = b;
				num = 14;
				break;
			case 21:
				return destSizeY - num2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static int StretchColorTo24bppRgb(byte* source, byte* dest, int sourceType, int sourceStride, int destStep, int destStride, int destSizeX, int destSizeY, int sourceMaxY, int sourceDX16, int sourceDY16, ref int pSourceX16, ref int pSourceY16)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0135;
		IL_001a:
		int num2 = default;
		pSourceX16 = num2;
		num = 17;
		if (false)
		{
			goto IL_002a;
		}
		goto IL_0135;
		IL_0135:
		int num3 = default;
		int num5 = default;
		int num4 = default;
		int num6 = default;
		byte* ptr2 = default;
		byte* ptr = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 14:
				break;
			case 5:
				goto IL_002a;
			case 4:
				goto IL_003c;
			case 8:
				num3--;
				num = 12;
				if (true)
				{
					continue;
				}
				goto case 12;
			case 12:
				if (num3 <= 0)
				{
					break;
				}
				num5 = num4 >> 16;
				num = 5;
				if (haiIIAhNll1rtkUX8rw())
				{
					continue;
				}
				goto case 13;
			case 3:
				dest += destStride;
				num = 8;
				continue;
			case 11:
				num2 += sourceDX16;
				num = 6;
				continue;
			case 7:
				num2 = pSourceX16;
				num6 = destSizeX;
				num = 0;
				continue;
			case 1:
			case 9:
				num4 = pSourceY16;
				num3 = destSizeY;
				goto case 12;
			case 13:
				num4 += sourceDY16;
				num = 3;
				continue;
			case 6:
				ptr2 += destStep;
				num = 15;
				continue;
			case 0:
			case 10:
				if (num6 <= 0)
				{
					num = 13;
					continue;
				}
				*ptr2 = ptr[num2 >> 16];
				num = 11;
				if (0 == 0)
				{
					continue;
				}
				goto case 15;
			case 15:
				num6--;
				goto case 0;
			default:
				num = 10;
				if (!FBqGUQhxfjqqi4RyyBp())
				{
					continue;
				}
				goto case 17;
			case 17:
				pSourceY16 = num4;
				num = 18;
				if (0 == 0)
				{
					continue;
				}
				goto case 16;
			case 16:
				ptr = source + num5 * sourceStride;
				ptr2 = dest + sourceType;
				num = 7;
				if (FBqGUQhxfjqqi4RyyBp())
				{
				}
				continue;
			case 18:
				return destSizeY - num3;
			}
			break;
			IL_003c:
			num2 = pSourceX16;
			_ = 0;
			num = ((!haiIIAhNll1rtkUX8rw()) ? 2 : 9);
		}
		goto IL_001a;
		IL_002a:
		if (num5 > sourceMaxY)
		{
			goto IL_001a;
		}
		num = 16;
		goto IL_0135;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static int StretchRGB565To24bppRgb(short* source, byte* dest, int sourceStride, int destStep, int destStride, int destSizeX, int destSizeY, int sourceMaxY, int sourceDX16, int sourceDY16, ref int pSourceX16, ref int pSourceY16)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		if (!FBqGUQhxfjqqi4RyyBp())
		{
		}
		int num2 = default;
		int num8 = default;
		int num4 = default;
		int num5 = default;
		int num3 = default;
		byte* ptr = default;
		int num7 = default;
		int num6 = default;
		short* ptr2 = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				if (num2 > 0)
				{
					num8 = num4 >> 16;
					num = 11;
					break;
				}
				goto IL_0029;
			case 14:
				num5 = pSourceX16;
				num = 0;
				if (true)
				{
					break;
				}
				goto case 13;
			case 13:
				num3--;
				num = 9;
				break;
			case 19:
				pSourceY16 = num4;
				num = 21;
				break;
			case 15:
				*(ptr++) = (byte)(((num7 & 0x1F) << 3) * 33 >> 5);
				goto case 3;
			default:
				num = 3;
				break;
			case 3:
				*(ptr++) = (byte)(((num7 & 0x7E0) >> 3) * 65 >> 6);
				num = 8;
				break;
			case 8:
				*ptr = (byte)(((num7 & 0xF800) >> 8) * 33 >> 5);
				ptr += num6;
				goto case 5;
			case 0:
				num4 = pSourceY16;
				num = 10;
				break;
			case 7:
				sourceStride /= 2;
				num = 14;
				break;
			case 9:
			case 18:
				if (num3 <= 0)
				{
					num4 += sourceDY16;
					num = 17;
					break;
				}
				num7 = ptr2[num5 >> 16];
				num = 15;
				if (!FBqGUQhxfjqqi4RyyBp())
				{
					break;
				}
				goto case 11;
			case 11:
				if (num8 <= sourceMaxY)
				{
					ptr2 = source + num8 * sourceStride;
					num = 20;
					break;
				}
				goto IL_0029;
			case 10:
				num2 = destSizeY;
				goto case 4;
			case 16:
				num2--;
				num = 4;
				break;
			case 2:
			case 6:
				num5 = pSourceX16;
				num6 = destStep - 2;
				num = 1;
				break;
			case 17:
				dest += destStride;
				num = 16;
				break;
			case 1:
				num3 = destSizeX;
				num = 18;
				if (true)
				{
					break;
				}
				goto case 20;
			case 20:
				ptr = dest;
				haiIIAhNll1rtkUX8rw();
				if (FBqGUQhxfjqqi4RyyBp())
				{
					num = 5;
					if (true)
					{
						break;
					}
					goto case 0;
				}
				num = 2;
				if (haiIIAhNll1rtkUX8rw())
				{
					break;
				}
				goto case 5;
			case 5:
			case 12:
				num5 += sourceDX16;
				num = 13;
				if (FBqGUQhxfjqqi4RyyBp())
				{
				}
				break;
			case 21:
				{
					return destSizeY - num2;
				}
				IL_0029:
				pSourceX16 = num5;
				num = 19;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static int Stretch24bppRgbTo24bppRgb(byte* source, byte* dest, int sourceStride, int destStep, int destStride, int destSizeX, int destSizeY, int sourceMaxY, int sourceDX16, int sourceDY16, ref int pSourceX16, ref int pSourceY16)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!haiIIAhNll1rtkUX8rw()) ? 16 : 14);
		int num7 = default;
		int num5 = default;
		int num3 = default;
		int num6 = default;
		byte* ptr2 = default;
		int num4 = default;
		int num8 = default;
		int num2 = default;
		while (true)
		{
			byte* ptr;
			switch (num)
			{
			case 5:
				num7 += sourceDY16;
				num = 4;
				break;
			case 0:
			case 14:
				num5 = pSourceX16;
				num = 9;
				break;
			case 15:
				ptr += num3;
				num = 6;
				break;
			case 9:
				num7 = pSourceY16;
				num = 11;
				break;
			case 7:
				pSourceY16 = num7;
				num = 21;
				if (0 == 0)
				{
					break;
				}
				goto case 3;
			case 3:
				if (num6 <= sourceMaxY)
				{
					ptr2 = source + num6 * sourceStride;
					num = 13;
					break;
				}
				goto case 18;
			case 17:
				if (num4 <= 0)
				{
					num = 5;
					if (!FBqGUQhxfjqqi4RyyBp())
					{
						break;
					}
					goto case 6;
				}
				num8 = 3 * (num5 >> 16);
				goto case 8;
			case 6:
				num5 += sourceDX16;
				num = 12;
				if (true)
				{
					break;
				}
				goto case 12;
			case 12:
				num4--;
				num = 17;
				break;
			case 1:
			case 2:
				if (num2 > 0)
				{
					num6 = num7 >> 16;
					num = 3;
					if (true)
					{
						break;
					}
					goto case 0;
				}
				num = 18;
				break;
			case 19:
				num5 = pSourceX16;
				num = 20;
				break;
			case 4:
				dest += destStride;
				num2--;
				num = 1;
				if (haiIIAhNll1rtkUX8rw())
				{
					break;
				}
				goto case 20;
			case 20:
				num4 = destSizeX;
				goto case 17;
			case 11:
				num2 = destSizeY;
				num = 2;
				if (0 == 0)
				{
					break;
				}
				goto case 13;
			case 13:
				ptr = dest;
				num3 = destStep - 2;
				num = 19;
				if (0 == 0)
				{
					break;
				}
				goto case 18;
			case 18:
				pSourceX16 = num5;
				num = 7;
				if (haiIIAhNll1rtkUX8rw())
				{
					break;
				}
				goto case 10;
			case 10:
				*ptr = ptr2[num8 + 2];
				goto case 15;
			default:
				num = 15;
				break;
			case 8:
			case 16:
				*(ptr++) = ptr2[num8];
				*(ptr++) = ptr2[num8 + 1];
				num = 10;
				break;
			case 21:
				return destSizeY - num2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr CreateCompatibleDC(IntPtr hdc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return S9b93GF9T(hdc);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "CreateCompatibleDC")]
	private static extern IntPtr S9b93GF9T(IntPtr P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr GetDC(IntPtr hwnd)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return xU0UGdKAI(hwnd);
	}

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "GetDC")]
	private static extern IntPtr xU0UGdKAI(IntPtr P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ReleaseDC(IntPtr hwnd, IntPtr hdc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return nq30fAFYj(hwnd, hdc) != 0;
	}

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "ReleaseDC")]
	private static extern int nq30fAFYj(IntPtr P_0, IntPtr P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool DeleteDC(IntPtr hdc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return DJ9wNh0Nt(hdc) != 0;
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "DeleteDC")]
	private static extern int DJ9wNh0Nt(IntPtr P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool SaveDC(IntPtr hdc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return BG2RstpAr(hdc) != 0;
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "SaveDC")]
	private static extern int BG2RstpAr(IntPtr P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool RestoreDC(IntPtr hdc, int nSavedDC)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sEtsrR82V(hdc, nSavedDC) != 0;
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "RestoreDC")]
	private static extern int sEtsrR82V(IntPtr P_0, int P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetDeviceCaps(IntPtr hdc, DeviceCapsIndex nIndex)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return G8R6sCSBI(hdc, nIndex);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "GetDeviceCaps")]
	private static extern int G8R6sCSBI(IntPtr P_0, DeviceCapsIndex P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr CreateCompatibleBitmap(IntPtr hdc, int nWidth, int nHeight)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return yS7HmAFQE(hdc, nWidth, nHeight);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "CreateCompatibleBitmap")]
	private static extern IntPtr yS7HmAFQE(IntPtr P_0, int P_1, int P_2);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr CreateDIBSection(IntPtr hdc, ref BITMAPINFO pbmi, int iUsage, out IntPtr ppvBits, IntPtr hSection, int dwOffset)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (haiIIAhNll1rtkUX8rw())
		{
			num = 4;
			if (!haiIIAhNll1rtkUX8rw())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0069;
		IL_002a:
		bool lockTaken = false;
		num = 5;
		goto IL_0069;
		IL_0069:
		IntPtr intPtr = default;
		Type type = default;
		int num3 = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 0:
			case 4:
				intPtr = IntPtr.Zero;
				goto case 1;
			case 1:
			case 2:
				type = hHwhINh10GhQM4nB6Z4(typeof(CnxNativeMethods).TypeHandle);
				break;
			default:
				num = 3;
				if (!FBqGUQhxfjqqi4RyyBp())
				{
					continue;
				}
				goto case 5;
			case 5:
				try
				{
					Monitor.Enter(type, ref lockTaken);
					int num2 = 3;
					while (true)
					{
						switch (num2)
						{
						case 3:
							num3 = 0;
							FBqGUQhxfjqqi4RyyBp();
							if (haiIIAhNll1rtkUX8rw())
							{
								num2 = 4;
								if (haiIIAhNll1rtkUX8rw())
								{
									continue;
								}
								goto case 5;
							}
							num2 = 0;
							continue;
						case 5:
							GC.WaitForPendingFinalizers();
							num2 = 7;
							continue;
						case 0:
						case 2:
							if (intPtr != IntPtr.Zero)
							{
								break;
							}
							TUqpgGhrSOlrCeXX2bh();
							num2 = 5;
							continue;
						default:
							num2 = 6;
							continue;
						case 1:
						case 4:
							intPtr = OfMKGYcaQ(hdc, ref pbmi, iUsage, out ppvBits, hSection, dwOffset);
							goto case 0;
						case 6:
							break;
						case 7:
							if (++num3 >= 10)
							{
								break;
							}
							goto case 1;
						}
						break;
					}
				}
				finally
				{
					if (lockTaken)
					{
						woby6Dh3PuhPXvdLMV9(type);
					}
				}
				return intPtr;
			}
			break;
		}
		goto IL_002a;
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "CreateDIBSection")]
	private static extern IntPtr OfMKGYcaQ(IntPtr P_0, [In] ref BITMAPINFO P_1, int P_2, out IntPtr P_3, IntPtr P_4, int P_5);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetDIBColorTable(IntPtr hdc, int iStartIndex, int cEntries, int[] pRGBQuad)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return leoEyWapn(hdc, iStartIndex, cEntries, pRGBQuad);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "GetDIBColorTable")]
	private static extern int leoEyWapn(IntPtr P_0, int P_1, int P_2, [Out] int[] P_3);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int SetDIBColorTable(IntPtr hdc, int iStartIndex, int cEntries, int[] pRGBQuad)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return tsmQrlL1h(hdc, iStartIndex, cEntries, pRGBQuad);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "SetDIBColorTable")]
	private static extern int tsmQrlL1h(IntPtr P_0, int P_1, int P_2, [In] int[] P_3);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int SetPixel(IntPtr hdc, int X, int Y, int crColor)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return vaSNYNC0Y(hdc, X, Y, crColor);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "SetPixel")]
	private static extern int vaSNYNC0Y(IntPtr P_0, int P_1, int P_2, int P_3);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetPixel(IntPtr hdc, int nXPos, int nYPos)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Qf6iFrQoK(hdc, nXPos, nYPos);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "GetPixel")]
	private static extern int Qf6iFrQoK(IntPtr P_0, int P_1, int P_2);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int SetDIBitsToDevice(IntPtr hdc, int XDest, int YDest, int dwWidth, int dwHeight, int XSrc, int YSrc, int uStartScan, int cScanLines, IntPtr lpvBits, ref BITMAPINFO lpbmi, int fuColorUse)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return dQpdtS2BL(hdc, XDest, YDest, dwWidth, dwHeight, XSrc, YSrc, uStartScan, cScanLines, lpvBits, ref lpbmi, fuColorUse);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "SetDIBitsToDevice")]
	private static extern int dQpdtS2BL(IntPtr P_0, int P_1, int P_2, int P_3, int P_4, int P_5, int P_6, int P_7, int P_8, IntPtr P_9, [In] ref BITMAPINFO P_10, int P_11);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool LineTo(IntPtr hdc, int nXEnd, int nYEnd)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return BbluOFkBA(hdc, nXEnd, nYEnd) != 0;
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "LineTo")]
	private static extern int BbluOFkBA(IntPtr P_0, int P_1, int P_2);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool MoveToEx(IntPtr hdc, int X, int Y, IntPtr lpPoint)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return L5RGbVfT2(hdc, X, Y, lpPoint) != 0;
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "MoveToEx")]
	private static extern int L5RGbVfT2(IntPtr P_0, int P_1, int P_2, IntPtr P_3);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Ellipse(IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return X3vDLBs9T(hdc, nLeftRect, nTopRect, nRightRect, nBottomRect) != 0;
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "Ellipse")]
	private static extern int X3vDLBs9T(IntPtr P_0, int P_1, int P_2, int P_3, int P_4);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Arc(IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nXStartArc, int nYStartArc, int nXEndArc, int nYEndArc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return BaaeBIsPw(hdc, nLeftRect, nTopRect, nRightRect, nBottomRect, nXStartArc, nYStartArc, nXEndArc, nYEndArc) != 0;
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "Arc")]
	private static extern int BaaeBIsPw(IntPtr P_0, int P_1, int P_2, int P_3, int P_4, int P_5, int P_6, int P_7, int P_8);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool AngleArc(IntPtr hdc, int X, int Y, int dwRadius, float eStartAngle, float eSweepAngle)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EpySBSvcR(hdc, X, Y, dwRadius, eStartAngle, eSweepAngle) != 0;
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "AngleArc")]
	private static extern int EpySBSvcR(IntPtr P_0, int P_1, int P_2, int P_3, float P_4, float P_5);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr CreatePen(PS fnPenStyle, int nWidth, int crColor)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ybTrOib1e(fnPenStyle, nWidth, crColor);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "CreatePen")]
	private static extern IntPtr ybTrOib1e(PS P_0, int P_1, int P_2);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr ExtCreatePen(PS dwPenStyle, int dwWidth, ref LOGBRUSH lplb, int dwStyleCount, int[] lpStyle)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return FLlCQcs42(dwPenStyle, dwWidth, ref lplb, dwStyleCount, lpStyle);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "ExtCreatePen")]
	private static extern IntPtr FLlCQcs42(PS P_0, int P_1, ref LOGBRUSH P_2, int P_3, int[] P_4);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr CreateSolidBrush(int crColor)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return dRe2TUa0w(crColor);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "CreateSolidBrush")]
	private static extern IntPtr dRe2TUa0w(int P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr CreatePatternBrush(IntPtr hbmp)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return I15yi23P5(hbmp);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "CreatePatternBrush")]
	private static extern IntPtr I15yi23P5(IntPtr P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr SetBrushOrgEx(IntPtr hdc, int nXOrg, int nYOrg)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SJuVaH1hb(hdc, nXOrg, nYOrg, IntPtr.Zero);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "SetBrushOrgEx")]
	private static extern IntPtr SJuVaH1hb(IntPtr P_0, int P_1, int P_2, IntPtr P_3);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr CreateFontIndirect(LOGFONT lf)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return tJYvgvekW(lf);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "CreateFontIndirect")]
	private static extern IntPtr tJYvgvekW([In] LOGFONT P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr AddFontMemResourceEx(IntPtr pbFont, int cbFont, IntPtr pdv, ref int pcFonts)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return QhuZi1vDw(pbFont, cbFont, pdv, ref pcFonts);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "AddFontMemResourceEx")]
	private static extern IntPtr QhuZi1vDw(IntPtr P_0, int P_1, IntPtr P_2, ref int P_3);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool FillRect(IntPtr hDC, RECT lprc, IntPtr hbr)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Tlt8EcNOp(hDC, ref lprc, hbr);
	}

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "FillRect", SetLastError = true)]
	private static extern bool Tlt8EcNOp(IntPtr P_0, [In] ref RECT P_1, IntPtr P_2);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool RoundRect(IntPtr hDC, int left, int top, int right, int bottom, int cornerWidth, int cornerHeight)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return C3Nz7WC88(hDC, left, top, right - 1, bottom - 1, cornerWidth, cornerHeight);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "RoundRect", SetLastError = true)]
	private static extern bool C3Nz7WC88(IntPtr P_0, [In] int P_1, [In] int P_2, [In] int P_3, [In] int P_4, [In] int P_5, [In] int P_6);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr GetStockObject(GdiStockObjects fnObject)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return xm0IPAf50j((int)fnObject);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "GetStockObject")]
	private static extern IntPtr xm0IPAf50j(int P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return qrwIIuQMdp(hdc, hgdiobj);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "SelectObject")]
	private static extern IntPtr qrwIIuQMdp(IntPtr P_0, IntPtr P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int SelectClipRgn(IntPtr hdc, IntPtr hrgn)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kuxI1Su6SS(hdc, hrgn);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "SelectClipRgn")]
	private static extern int kuxI1Su6SS(IntPtr P_0, IntPtr P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool DeleteBitmap(IntPtr hObject)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return HWbT50hOPlcUlJ7hYQA(hObject, (DZXLldbP3vwdUUmLl3)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool DeletePen(IntPtr hObject)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return HWbT50hOPlcUlJ7hYQA(hObject, (DZXLldbP3vwdUUmLl3)3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool DeleteBrush(IntPtr hObject)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return myTIxdYDYt(hObject, (DZXLldbP3vwdUUmLl3)1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool DeleteFont(IntPtr hObject)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return myTIxdYDYt(hObject, (DZXLldbP3vwdUUmLl3)2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool DeleteRegion(IntPtr hObject)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return HWbT50hOPlcUlJ7hYQA(hObject, (DZXLldbP3vwdUUmLl3)4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool myTIxdYDYt(IntPtr P_0, DZXLldbP3vwdUUmLl3 P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		bool flag = tHsIFf9Gld(P_0) != 0;
		if (!flag)
		{
			int num = lMGoXPhMl6spmNCvh6L();
			mPqrqahuDgYlfH7Q6nh(CvsTrace.Display.Error, x6sfnXheUraCcRQtyAg(W9m7MPhQd5eghu9luZ3(1010), P_1, num, G9PbZShlGwVfQAMM7S0(num)));
		}
		return flag;
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "DeleteObject")]
	private static extern int tHsIFf9Gld(IntPtr P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool DeleteObject(IntPtr hObject)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return tHsIFf9Gld(hObject) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetTextMetrics(IntPtr hdc, out TEXTMETRIC lptm)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return cvnIbjgrA6(hdc, out lptm);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "GetTextMetrics")]
	private static extern bool cvnIbjgrA6(IntPtr P_0, out TEXTMETRIC P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetCharABCWidths(IntPtr hdc, int uFirstChar, int uLastChar, ABC[] lpabc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return JTZIaPtYN0(hdc, uFirstChar, uLastChar, lpabc);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "GetCharABCWidths")]
	private static extern bool JTZIaPtYN0(IntPtr P_0, int P_1, int P_2, [Out] ABC[] P_3);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetTextExtentPoint32(IntPtr hdc, string lpString, int cbString, out SIZE lpSize)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return x4MIO9eGU4(hdc, lpString, cbString, out lpSize) != 0;
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "GetTextExtentPoint32")]
	private static extern int x4MIO9eGU4(IntPtr P_0, string P_1, int P_2, out SIZE P_3);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetTextExtentExPoint(IntPtr hdc, string lpString, int cbString, int nMaxExtent, IntPtr lpnFit, IntPtr alpDx, out SIZE lpSize)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return tfmIpSf6xA(hdc, lpString, cbString, nMaxExtent, lpnFit, alpDx, out lpSize) != 0;
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "GetTextExtentExPoint")]
	private static extern int tfmIpSf6xA(IntPtr P_0, string P_1, int P_2, int P_3, IntPtr P_4, IntPtr P_5, out SIZE P_6);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int DrawText(IntPtr hDC, string lpString, int nCount, ref RECT lpRect, TextFormat uFormat)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return d1ZIheq1WI(hDC, lpString, nCount, ref lpRect, uFormat);
	}

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "DrawText")]
	private static extern int d1ZIheq1WI(IntPtr P_0, string P_1, int P_2, [In] ref RECT P_3, TextFormat P_4);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ExtTextOut(IntPtr hdc, int X, int Y, ETO fuOptions, ref RECT lprc, string lpString, int cbCount, IntPtr lpDx)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return XD1I4U385T(hdc, X, Y, fuOptions, ref lprc, lpString, cbCount, lpDx);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "ExtTextOut")]
	private static extern bool XD1I4U385T(IntPtr P_0, int P_1, int P_2, ETO P_3, [In] ref RECT P_4, string P_5, int P_6, IntPtr P_7);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ExtTextOut(IntPtr hdc, int X, int Y, TextOutFormat fuOptions, ref RECT lprc, string lpString, int cbCount, int[] lpDx)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return lqaIlkS0w7(hdc, X, Y, fuOptions, ref lprc, lpString, cbCount, lpDx);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "ExtTextOut")]
	private static extern bool lqaIlkS0w7(IntPtr P_0, int P_1, int P_2, TextOutFormat P_3, [In] ref RECT P_4, string P_5, int P_6, [In] int[] P_7);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int SetTextAlign(IntPtr hdc, TextAlign fMode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return g0ZIgdQBiA(hdc, fMode);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "SetTextAlign")]
	private static extern int g0ZIgdQBiA(IntPtr P_0, TextAlign P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static TextAlign GetTextAlign(IntPtr hdc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return rrAIqLhFYF(hdc);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "GetTextAlign")]
	private static extern TextAlign rrAIqLhFYF(IntPtr P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int SetTextColor(IntPtr hdc, int crColor)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return XXDITCKvgb(hdc, crColor);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "SetTextColor")]
	private static extern int XXDITCKvgb(IntPtr P_0, int P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int SetBkColor(IntPtr hdc, int crColor)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return bhtIBVp2yY(hdc, crColor);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "SetBkColor")]
	private static extern int bhtIBVp2yY(IntPtr P_0, int P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int SetROP2(IntPtr hdc, R2 fnDrawMode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return B8EIJtf9gW(hdc, fnDrawMode);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "SetROP2")]
	private static extern int B8EIJtf9gW(IntPtr P_0, R2 P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int SetBkMode(IntPtr hdc, BkMode iBkMode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return wkaIMn3cVM(hdc, iBkMode);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "SetBkMode")]
	private static extern int wkaIMn3cVM(IntPtr P_0, BkMode P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool SetViewportOrgEx(IntPtr hdc, int x, int y)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return UThIodM7LZ(hdc, x, y, IntPtr.Zero) != 0;
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "SetViewportOrgEx")]
	private static extern int UThIodM7LZ(IntPtr P_0, int P_1, int P_2, IntPtr P_3);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool SetWorldTransform(IntPtr hdc, ref XFORM lpXform)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return g8WIA2prXt(hdc, ref lpXform) != 0;
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "SetWorldTransform")]
	private static extern int g8WIA2prXt(IntPtr P_0, ref XFORM P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetWorldTransform(IntPtr hdc, out XFORM lpXform)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return mIkItZxUJn(hdc, out lpXform) != 0;
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "GetWorldTransform")]
	private static extern int mIkItZxUJn(IntPtr P_0, out XFORM P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int SetGraphicsMode(IntPtr hdc, GraphicsMode Mode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sdMIW16hIO(hdc, Mode);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "SetGraphicsMode")]
	private static extern int sdMIW16hIO(IntPtr P_0, GraphicsMode P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Polyline(IntPtr hdc, CnxVector2[] lppt, int cPoints)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return RFLI3lgvkJ(hdc, lppt, cPoints);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "Polyline")]
	private static extern bool RFLI3lgvkJ(IntPtr P_0, [In] CnxVector2[] P_1, int P_2);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Polyline(IntPtr hdc, Point[] lppt, int cPoints)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return W95ILTgDSI(hdc, lppt, cPoints);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "Polyline")]
	private static extern bool W95ILTgDSI(IntPtr P_0, [In] Point[] P_1, int P_2);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Polygon(IntPtr hdc, CnxVector2[] lppt, int cPoints)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return qtVIkQa3W8(hdc, lppt, cPoints);
	}

	[DllImport("Gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "Polygon")]
	private static extern bool qtVIkQa3W8(IntPtr P_0, [In] CnxVector2[] P_1, int P_2);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetLastError()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return HbpBiZhI8VThACreVdT();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetFormattedError(int errCode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetFormattedError(errCode, IntPtr.Zero, 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetFormattedError(int errCode, IntPtr module, int langId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = (haiIIAhNll1rtkUX8rw() ? 1 : 2);
		IntPtr zero = default;
		string result = default;
		while (true)
		{
			switch (num)
			{
			default:
				Marshal.FreeHGlobal(zero);
				num = 6;
				if (haiIIAhNll1rtkUX8rw())
				{
					break;
				}
				goto case 4;
			case 4:
				if (tUuRHwhRsQwTgtF4tMH(zero, IntPtr.Zero))
				{
					num = 5;
					if (FBqGUQhxfjqqi4RyyBp())
					{
					}
					break;
				}
				goto default;
			case 0:
			case 1:
			{
				zero = IntPtr.Zero;
				int num2 = c7cIXZYdNS(4864, module, errCode, langId, ref zero, 0, IntPtr.Zero);
				result = "";
				if (num2 > 0)
				{
					num = 4;
					break;
				}
				goto default;
			}
			case 5:
				result = (string)QxfWNchawsXuiCq8Ll4(zero);
				goto default;
			case 6:
				return result;
			}
		}
	}

	[DllImport("Kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "FormatMessage", SetLastError = true)]
	private static extern int c7cIXZYdNS(int P_0, IntPtr P_1, int P_2, int P_3, ref IntPtr P_4, int P_5, IntPtr P_6);

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool haiIIAhNll1rtkUX8rw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FBqGUQhxfjqqi4RyyBp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type hHwhINh10GhQM4nB6Z4(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TUqpgGhrSOlrCeXX2bh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		GC.Collect();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void woby6Dh3PuhPXvdLMV9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Monitor.Exit(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HWbT50hOPlcUlJ7hYQA(IntPtr P_0, DZXLldbP3vwdUUmLl3 P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return myTIxdYDYt(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int lMGoXPhMl6spmNCvh6L()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetLastError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object W9m7MPhQd5eghu9luZ3(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object G9PbZShlGwVfQAMM7S0(int errCode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetFormattedError(errCode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object x6sfnXheUraCcRQtyAg(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mPqrqahuDgYlfH7Q6nh(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CnxTraceChannel)P_0).TraceMessage((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int HbpBiZhI8VThACreVdT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Marshal.GetLastWin32Error();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tUuRHwhRsQwTgtF4tMH(IntPtr P_0, IntPtr P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 != P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QxfWNchawsXuiCq8Ll4(IntPtr P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Marshal.PtrToStringUni(P_0);
	}
}
