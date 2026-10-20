using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicLine : CvsGraphic, ICvsEditableGraphic
{
	private PointF P94JKgTDQ3;

	private PointF nGIJEZVseh;

	private RectangleF SyyJQgo97k;

	private CvsEditFlags uLpJNA91S2;

	private CvsGraphicLineAdornment Gk6JigLNKM;

	private CvsGraphicLineAdornment eiIJdOpyIV;

	internal override double[] InternalData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new double[5]
			{
				Convert.ToDouble(P94JKgTDQ3.Y),
				wex8623nu7vwx51GwoH(P94JKgTDQ3.X),
				wex8623nu7vwx51GwoH(nGIJEZVseh.Y),
				Convert.ToDouble(nGIJEZVseh.X),
				0.0
			};
		}
	}

	public PointF StartPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P94JKgTDQ3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (JKGZTQ338ld63PbHUGu())
			{
				goto IL_001e;
			}
			goto IL_006f;
			IL_001e:
			CheckLock();
			_ = 1;
			num = (JKGZTQ338ld63PbHUGu() ? 4 : 3);
			goto IL_006f;
			IL_006f:
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				default:
					VLFja33a256uqQdj1ob(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(34602));
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					goto case 1;
				case 1:
				case 3:
					P94JKgTDQ3 = value;
					goto default;
				case 5:
					return;
				}
				break;
			}
			goto IL_001e;
		}
	}

	public PointF EndPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return nGIJEZVseh;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ved5oF3rxnNke6Mau1i();
			int num = ((!JKGZTQ338ld63PbHUGu()) ? 1 : 4);
			while (true)
			{
				switch (num)
				{
				case 3:
					nGIJEZVseh = value;
					break;
				case 0:
				case 1:
					CheckLock();
					num = 3;
					continue;
				case 5:
					return;
				}
				VLFja33a256uqQdj1ob(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(34626));
				num = 5;
			}
		}
	}

	public CvsGraphicLineAdornment StartPointAdornment
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Gk6JigLNKM;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Gk6JigLNKM = value;
		}
	}

	public CvsGraphicLineAdornment EndPointAdornment
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return eiIJdOpyIV;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			eiIJdOpyIV = value;
		}
	}

	public CvsEditFlags EditFlags
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return uLpJNA91S2;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (ved5oF3rxnNke6Mau1i())
			{
				num = 4;
			}
			else
			{
				num = 2;
				if (!ved5oF3rxnNke6Mau1i())
				{
					goto IL_0082;
				}
			}
			goto IL_003f;
			IL_003f:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					uLpJNA91S2 = value & (CvsEditFlags.Location | CvsEditFlags.Size);
					break;
				default:
					goto IL_005c;
				case 0:
				case 4:
					CheckLock();
					goto case 1;
				case 3:
					break;
				case 5:
					return;
				}
				break;
				IL_005c:
				num = 3;
			}
			goto IL_0082;
			IL_0082:
			VLFja33a256uqQdj1ob(this, fiM3XL366EKUYj6CDpo(33720));
			num = 5;
			if (!ved5oF3rxnNke6Mau1i())
			{
				return;
			}
			goto IL_003f;
		}
	}

	public RectangleF EditBounds
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SyyJQgo97k;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ved5oF3rxnNke6Mau1i();
			int num;
			if (!JKGZTQ338ld63PbHUGu())
			{
				num = 4;
				if (!ved5oF3rxnNke6Mau1i())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_0047;
			IL_0070:
			VLFja33a256uqQdj1ob(this, fiM3XL366EKUYj6CDpo(33862));
			num = 5;
			goto IL_0047;
			IL_0047:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					break;
				default:
					num = 2;
					if (true)
					{
						continue;
					}
					goto IL_0070;
				case 2:
					goto IL_0070;
				case 0:
				case 4:
					CheckLock();
					break;
				case 5:
					return;
				}
				break;
			}
			goto IL_002e;
			IL_002e:
			SyyJQgo97k = value;
			goto IL_0070;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicLine(CvsGraphicLine graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (JKGZTQ338ld63PbHUGu() ? 2 : 3);
		do
		{
			IL_0042:
			switch (num)
			{
			case 8:
				P94JKgTDQ3 = graphic.P94JKgTDQ3;
				goto default;
			case 0:
			case 3:
				DyiE893Om3EEjEw8B1b();
				num = 6;
				if (JKGZTQ338ld63PbHUGu())
				{
				}
				goto IL_0042;
			case 6:
				uLpJNA91S2 = CvsEditFlags.Location | CvsEditFlags.Size;
				num = 7;
				goto IL_0042;
			case 7:
				base._002Ector(graphic);
				num = 8;
				goto IL_0042;
			case 5:
				eiIJdOpyIV = graphic.eiIJdOpyIV;
				num = 9;
				goto IL_0042;
			default:
				nGIJEZVseh = graphic.nGIJEZVseh;
				num = 1;
				if (true)
				{
					goto IL_0042;
				}
				break;
			case 1:
				break;
			case 9:
				return;
			}
			Gk6JigLNKM = graphic.Gk6JigLNKM;
			num = 5;
		}
		while (ved5oF3rxnNke6Mau1i());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicLine(CvsCellLocation cellLocation, PointF startPoint, PointF endPoint, string label)
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
			case 5:
			case 6:
				Gk6JigLNKM = CvsGraphicLineAdornment.None;
				num = 8;
				if (true)
				{
					continue;
				}
				goto case 8;
			case 8:
				eiIJdOpyIV = CvsGraphicLineAdornment.None;
				num = 9;
				if (ved5oF3rxnNke6Mau1i())
				{
					continue;
				}
				goto case 4;
			case 4:
			case 7:
				nGIJEZVseh = endPoint;
				goto case 5;
			case 1:
				uLpJNA91S2 = CvsEditFlags.Location | CvsEditFlags.Size;
				num = 0;
				continue;
			case 3:
				DyiE893Om3EEjEw8B1b();
				num = 1;
				continue;
			case 0:
				base._002Ector(cellLocation, label);
				num = 2;
				continue;
			case 2:
				P94JKgTDQ3 = startPoint;
				break;
			case 9:
				return;
			}
			ved5oF3rxnNke6Mau1i();
			num = ((!JKGZTQ338ld63PbHUGu()) ? 7 : 6);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicLine(CvsCellLocation cellLocation, CvsCogEditingLine editLine)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		CvsCogLine cvsCogLine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				uLpJNA91S2 = CvsEditFlags.Location | CvsEditFlags.Size;
				goto case 2;
			case 8:
				DyiE893Om3EEjEw8B1b();
				_ = 0;
				if (!ved5oF3rxnNke6Mau1i())
				{
					num = 7;
					break;
				}
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
				cvsCogLine = (CvsCogLine)kZTOPk3MFlZinYvXUHd(editLine);
				num = 4;
				break;
			case 9:
				nGIJEZVseh = new PointF((float)MoPHSK3QjrtHNc1Faw7(cvsCogLine), (float)xUPsPk3lUOnQZKyhpNF(cvsCogLine));
				num = 6;
				break;
			case 2:
			case 7:
				base._002Ector(cellLocation, editLine);
				num = 0;
				break;
			case 4:
				P94JKgTDQ3 = new PointF((float)cvsCogLine.X0, (float)cvsCogLine.Y0);
				goto case 9;
			default:
				num = 9;
				break;
			case 6:
				EditFlags = (CvsEditFlags)((stW4M43ehkTjXcyOd9K(editLine) ? 1 : 0) | (T76QAT3uD9S3eONwTYG(editLine) ? 2 : 0));
				num = 3;
				if (JKGZTQ338ld63PbHUGu())
				{
				}
				break;
			case 3:
				SyyJQgo97k = K54hGB3RdJ4Ql7gFnSm(UUFkHy3I3ZMCnDZZPLh(editLine));
				num = 10;
				break;
			case 10:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicLine()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 1:
				DyiE893Om3EEjEw8B1b();
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 4;
			case 4:
				uLpJNA91S2 = CvsEditFlags.Location | CvsEditFlags.Size;
				_ = 1;
				num = (JKGZTQ338ld63PbHUGu() ? 5 : 0);
				continue;
			case 0:
			case 2:
				base._002Ector();
				break;
			case 6:
				return;
			}
			Initialize(0, 0, 0f, 0f, 0f, 0f, "", CvsGraphicLineAdornment.None, CvsGraphicLineAdornment.None);
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(int cellRow, int cellCol, float startRow, float startCol, float endRow, float endCol, string label)
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
			case 0:
				eiIJdOpyIV = CvsGraphicLineAdornment.None;
				num = 3;
				if (!JKGZTQ338ld63PbHUGu())
				{
					continue;
				}
				goto case 7;
			case 7:
				nGIJEZVseh = new PointF(endCol, endRow);
				goto case 4;
			case 3:
				VLFja33a256uqQdj1ob(this, null);
				num = 10;
				continue;
			case 5:
				P94JKgTDQ3 = new PointF(startCol, startRow);
				num = 7;
				if (!JKGZTQ338ld63PbHUGu())
				{
					continue;
				}
				goto case 4;
			case 4:
			case 9:
				mLabel = label;
				goto case 8;
			default:
				num = 8;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
				CheckLock();
				JKGZTQ338ld63PbHUGu();
				if (!ved5oF3rxnNke6Mau1i())
				{
					num = 9;
					if (true)
					{
						continue;
					}
					goto case 3;
				}
				num = 6;
				if (ved5oF3rxnNke6Mau1i())
				{
					continue;
				}
				goto case 8;
			case 8:
				Gk6JigLNKM = CvsGraphicLineAdornment.None;
				num = 0;
				if (true)
				{
					continue;
				}
				break;
			case 1:
			case 6:
				break;
			case 10:
				return;
			}
			mCellLocation = new CvsCellLocation(cellRow, cellCol);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(int cellRow, int cellCol, float startRow, float startCol, float endRow, float endCol, string label, CvsGraphicLineAdornment startPointAdornment, CvsGraphicLineAdornment endPointAdornment)
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
			case 9:
				VLFja33a256uqQdj1ob(this, null);
				num = 10;
				break;
			case 1:
				Gk6JigLNKM = startPointAdornment;
				num = 5;
				break;
			case 3:
			case 8:
				nGIJEZVseh = new PointF(endCol, endRow);
				goto case 0;
			case 0:
			case 4:
				mLabel = label;
				goto case 1;
			default:
				num = 1;
				break;
			case 5:
				eiIJdOpyIV = endPointAdornment;
				num = 9;
				break;
			case 7:
				mCellLocation = new CvsCellLocation(cellRow, cellCol);
				num = 2;
				break;
			case 2:
				P94JKgTDQ3 = new PointF(startCol, startRow);
				_ = 0;
				num = (ved5oF3rxnNke6Mau1i() ? 8 : 0);
				break;
			case 6:
				CheckLock();
				num = 7;
				break;
			case 10:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicLine(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetSerializableGraphic()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCogLine(P94JKgTDQ3.X, P94JKgTDQ3.Y, nGIJEZVseh.X, nGIJEZVseh.Y, (int)Gk6JigLNKM, (int)eiIJdOpyIV, mColor.ToArgb(), mCellLocation.ToString());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogLine line)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!ved5oF3rxnNke6Mau1i())
		{
			goto IL_001e;
		}
		goto IL_005a;
		IL_001e:
		base.FromSerializableGraphic(line);
		num = 3;
		goto IL_005a;
		IL_005a:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 2:
			case 6:
				nGIJEZVseh = new PointF((float)MoPHSK3QjrtHNc1Faw7(line), (float)xUPsPk3lUOnQZKyhpNF(line));
				goto case 5;
			default:
				num = 5;
				continue;
			case 5:
				Gk6JigLNKM = (CvsGraphicLineAdornment)zLAc9t3X3m472DbLrEp(line);
				goto case 1;
			case 1:
			case 4:
				eiIJdOpyIV = (CvsGraphicLineAdornment)gPFCTs3bUqnLZPWSfVj(line);
				num = 7;
				continue;
			case 3:
				P94JKgTDQ3 = new PointF((float)EExSnS3GQOBf3uFm4hA(line), (float)line.Y0);
				ved5oF3rxnNke6Mau1i();
				if (JKGZTQ338ld63PbHUGu())
				{
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					goto case 1;
				}
				num = 6;
				if (ved5oF3rxnNke6Mau1i())
				{
					continue;
				}
				return;
			case 7:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DyiE893Om3EEjEw8B1b()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ved5oF3rxnNke6Mau1i()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JKGZTQ338ld63PbHUGu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kZTOPk3MFlZinYvXUHd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingLine)P_0).Line;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double MoPHSK3QjrtHNc1Faw7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogLine)P_0).X1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double xUPsPk3lUOnQZKyhpNF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogLine)P_0).Y1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool stW4M43ehkTjXcyOd9K(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingLine)P_0).Move0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool T76QAT3uD9S3eONwTYG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingLine)P_0).Move1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UUFkHy3I3ZMCnDZZPLh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape)P_0).Bounds;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RectangleF K54hGB3RdJ4Ql7gFnSm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRectangle)P_0).ToRectangleF();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VLFja33a256uqQdj1ob(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double wex8623nu7vwx51GwoH(float P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.ToDouble(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double EExSnS3GQOBf3uFm4hA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogLine)P_0).X0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int zLAc9t3X3m472DbLrEp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogLine)P_0).Adornment0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int gPFCTs3bUqnLZPWSfVj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogLine)P_0).Adornment1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fiM3XL366EKUYj6CDpo(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}
}
