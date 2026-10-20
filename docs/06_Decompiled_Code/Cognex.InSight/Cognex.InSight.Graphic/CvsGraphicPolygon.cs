using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicPolygon : CvsGraphic, ICvsEditableGraphic
{
	[CompilerGenerated]
	private bool vUsMWweOoQ;

	private RectangleF r1jM3vAyF7;

	private readonly List<PointF> VTjMLCZbPN;

	private RectangleF c8hMkLVPQC;

	private CvsEditFlags zgbMXfs3a0;

	internal override double[] InternalData
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

	[DefaultValue(false)]
	public bool DisplayFill
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return vUsMWweOoQ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			vUsMWweOoQ = value;
		}
	}

	internal List<PointF> PointList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return VTjMLCZbPN;
		}
	}

	public PointF[] Points
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (PointF[])PbjqD9MU6wb7qJ1ikON(VTjMLCZbPN);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
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
				case 0:
				case 3:
					eKhMANDTNr();
					goto case 4;
				case 4:
				case 5:
					buLvgxMDMELiAQwSrbk(this, VpvifZMT3F1t7vD50MK(34728));
					num = 7;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
					CheckLock();
					num = 6;
					if (!VLFkxkMLJmpBHabc76q())
					{
						break;
					}
					goto case 6;
				case 6:
					VTjMLCZbPN.Clear();
					num = 2;
					break;
				case 2:
					VTjMLCZbPN.AddRange(value);
					goto default;
				default:
					xt7kKnMhW5TllRekvhN();
					if (VLFkxkMLJmpBHabc76q())
					{
						num = 5;
						if (true)
						{
							break;
						}
						goto case 4;
					}
					num = 0;
					break;
				case 7:
					return;
				}
			}
		}
	}

	public int PointCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CwBMwcMdI0Pdtuv0J9c(VTjMLCZbPN);
		}
	}

	public RectangleF BoundingBox
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (r1jM3vAyF7 == RectangleF.Empty)
			{
				r1jM3vAyF7 = bMWMoidoqG(VTjMLCZbPN);
			}
			return r1jM3vAyF7;
		}
	}

	public double Area
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return BoundingBox.Width * BoundingBox.Height;
		}
	}

	public PointF Center
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (VLFkxkMLJmpBHabc76q() ? 5 : 4);
			PointF result = default;
			RectangleF boundingBox = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					result = default;
					num = 3;
					if (xt7kKnMhW5TllRekvhN())
					{
						break;
					}
					goto case 2;
				case 2:
					result.X = boundingBox.X + boundingBox.Width / 2f;
					num = 6;
					break;
				case 3:
					result.Y = boundingBox.Y + boundingBox.Height / 2f;
					goto case 2;
				default:
					num = 2;
					break;
				case 0:
				case 4:
					boundingBox = BoundingBox;
					goto case 1;
				case 6:
					return result;
				}
			}
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
			return zgbMXfs3a0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (VLFkxkMLJmpBHabc76q() ? 2 : 3);
			do
			{
				IL_0043:
				switch (num)
				{
				case 1:
				case 2:
					zgbMXfs3a0 = value & (CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation | CvsEditFlags.AddItem | CvsEditFlags.DeleteItem | CvsEditFlags.EditItem);
					break;
				default:
					num = 4;
					goto IL_0043;
				case 0:
				case 3:
					CheckLock();
					goto case 1;
				case 4:
					break;
				case 5:
					return;
				}
				OnPropertyChanged((string)VpvifZMT3F1t7vD50MK(33720));
				num = 5;
			}
			while (0 == 0);
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
			return c8hMkLVPQC;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xt7kKnMhW5TllRekvhN();
			int num;
			if (!VLFkxkMLJmpBHabc76q())
			{
				num = 3;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 2;
			}
			goto IL_0073;
			IL_005a:
			c8hMkLVPQC = value;
			goto IL_0040;
			IL_0073:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					break;
				case 4:
					goto IL_0040;
				case 1:
				case 2:
					goto IL_005a;
				default:
					num = 4;
					continue;
				case 5:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			CheckLock();
			goto IL_005a;
			IL_0040:
			OnPropertyChanged((string)VpvifZMT3F1t7vD50MK(33862));
			num = 5;
			goto IL_0073;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicPolygon(PointF[] points)
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
			case 0:
			case 1:
				r1jM3vAyF7 = RectangleF.Empty;
				goto case 2;
			case 5:
				epPf7cM9T9G6vf1hp5x();
				_ = 0;
				if (!xt7kKnMhW5TllRekvhN())
				{
					num = 7;
					break;
				}
				num = 0;
				if (!VLFkxkMLJmpBHabc76q())
				{
					break;
				}
				goto case 2;
			case 2:
			case 7:
				VTjMLCZbPN = new List<PointF>();
				num = 3;
				break;
			case 6:
				base._002Ector();
				num = 4;
				break;
			case 4:
				VTjMLCZbPN.AddRange(points);
				num = 8;
				break;
			case 3:
				zgbMXfs3a0 = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation | CvsEditFlags.AddItem | CvsEditFlags.DeleteItem | CvsEditFlags.EditItem;
				goto case 6;
			default:
				num = 6;
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicPolygon(CvsGraphicPolygon graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xt7kKnMhW5TllRekvhN();
		int num = (VLFkxkMLJmpBHabc76q() ? 6 : 4);
		while (true)
		{
			switch (num)
			{
			case 2:
			case 6:
				VTjMLCZbPN = new List<PointF>();
				num = 7;
				break;
			case 3:
				VTjMLCZbPN.AddRange(graphic.PointList);
				num = 8;
				break;
			case 7:
				zgbMXfs3a0 = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation | CvsEditFlags.AddItem | CvsEditFlags.DeleteItem | CvsEditFlags.EditItem;
				goto case 5;
			default:
				num = 5;
				break;
			case 5:
				base._002Ector(graphic);
				num = 3;
				break;
			case 1:
				r1jM3vAyF7 = RectangleF.Empty;
				goto case 2;
			case 0:
			case 4:
				epPf7cM9T9G6vf1hp5x();
				num = 1;
				if (1 == 0)
				{
					return;
				}
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicPolygon(CvsCellLocation cellLocation, CvsCogEditingPolygon editPolygon)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		CvsCogPolygon polygon = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				r1jM3vAyF7 = RectangleF.Empty;
				_ = 0;
				if (xt7kKnMhW5TllRekvhN())
				{
					num = 3;
					if (VLFkxkMLJmpBHabc76q())
					{
					}
				}
				else
				{
					num = 9;
				}
				continue;
			case 2:
			case 3:
				VTjMLCZbPN = new List<PointF>();
				zgbMXfs3a0 = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation | CvsEditFlags.AddItem | CvsEditFlags.DeleteItem | CvsEditFlags.EditItem;
				num = 4;
				continue;
			case 4:
				base._002Ector(cellLocation, editPolygon);
				num = 6;
				continue;
			case 7:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 0;
				continue;
			case 8:
			case 9:
				UniqueId = cellLocation.ToString();
				num = 11;
				if (0 == 0)
				{
					continue;
				}
				goto case 10;
			case 10:
				EditFlags = (CvsEditFlags)((mYtBu2MSvFwKQRSit7G(editPolygon) ? 1 : 0) | (Qc9HaxMEUxn2WefKep9(editPolygon) ? 4 : 0) | (oR63dOMvrEH4Ibwh9xd(editPolygon) ? 2 : 0) | (editPolygon.AddPoints ? 64 : 0) | (MXa92RMHB2gCqkkoi0H(editPolygon) ? 32 : 0) | (YxjP1TMVfAGWXwBvdAx(editPolygon) ? 256 : 0));
				num = 5;
				if (!VLFkxkMLJmpBHabc76q())
				{
					continue;
				}
				goto case 6;
			case 6:
				polygon = editPolygon.Polygon;
				break;
			default:
				num = 1;
				continue;
			case 1:
				break;
			case 5:
				c8hMkLVPQC = ((CvsCogRectangle)bvILJXMAB4TJERP4oE3(editPolygon)).ToRectangleF();
				goto case 8;
			case 11:
				return;
			}
			FromSerializableGraphic(polygon);
			num = 10;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicPolygon()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (xt7kKnMhW5TllRekvhN())
		{
			num = 1;
			if (VLFkxkMLJmpBHabc76q())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0088;
		IL_002a:
		Initialize(0, 0, new PointF[0], "");
		num = 8;
		goto IL_0088;
		IL_0088:
		while (true)
		{
			switch (num)
			{
			case 7:
				break;
			case 0:
			case 1:
				epPf7cM9T9G6vf1hp5x();
				num = 5;
				continue;
			case 5:
				r1jM3vAyF7 = RectangleF.Empty;
				num = 3;
				continue;
			case 6:
				zgbMXfs3a0 = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation | CvsEditFlags.AddItem | CvsEditFlags.DeleteItem | CvsEditFlags.EditItem;
				goto default;
			case 3:
				VTjMLCZbPN = new List<PointF>();
				num = 6;
				continue;
			default:
				base._002Ector();
				num = 7;
				continue;
			case 8:
				return;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(int cellRow, int cellCol, PointF[] points, string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0093;
		IL_0053:
		mLabel = label;
		num = 1;
		goto IL_0093;
		IL_00d2:
		buLvgxMDMELiAQwSrbk(this, null);
		num = 9;
		goto IL_0093;
		IL_003d:
		eKhMANDTNr();
		num = 7;
		if (!xt7kKnMhW5TllRekvhN())
		{
			goto IL_0053;
		}
		goto IL_0093;
		IL_001a:
		VTjMLCZbPN.Clear();
		_ = 1;
		if (!VLFkxkMLJmpBHabc76q())
		{
			num = 2;
			if (1 == 0)
			{
				goto IL_003d;
			}
		}
		else
		{
			num = 6;
			if (1 == 0)
			{
				goto IL_00d2;
			}
		}
		goto IL_0093;
		IL_0093:
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 1:
				goto IL_003d;
			default:
				goto IL_0053;
			case 5:
				CheckLock();
				num = 8;
				continue;
			case 2:
			case 3:
				VTjMLCZbPN.AddRange(points);
				goto IL_0053;
			case 7:
				goto IL_00d2;
			case 8:
				mCellLocation = new CvsCellLocation(cellRow, cellCol);
				num = 0;
				continue;
			case 9:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override object InternalClone()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsGraphicPolygon(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PointF GetPoint(int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return VTjMLCZbPN[index];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPoint(int index, PointF location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (xt7kKnMhW5TllRekvhN())
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 3;
			if (false)
			{
				goto IL_005f;
			}
		}
		goto IL_0087;
		IL_0087:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 5:
				VTjMLCZbPN[index] = location;
				goto case 2;
			case 0:
			case 4:
				goto IL_005f;
			case 2:
			case 3:
				eKhMANDTNr();
				break;
			default:
				num = 1;
				continue;
			case 6:
				return;
			}
			break;
		}
		goto IL_0026;
		IL_005f:
		CheckLock();
		num = 5;
		goto IL_0087;
		IL_0026:
		buLvgxMDMELiAQwSrbk(this, VpvifZMT3F1t7vD50MK(34744));
		num = 6;
		goto IL_0087;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InsertPoint(int index, PointF location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VLFkxkMLJmpBHabc76q();
		int num;
		if (xt7kKnMhW5TllRekvhN())
		{
			num = 2;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
			if (!xt7kKnMhW5TllRekvhN())
			{
				goto IL_00a9;
			}
		}
		goto IL_0042;
		IL_002a:
		eKhMANDTNr();
		goto IL_006d;
		IL_0042:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			default:
				num = 5;
				continue;
			case 5:
				goto IL_006d;
			case 0:
			case 2:
				goto IL_008d;
			case 1:
			case 4:
				goto IL_00a9;
			case 6:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_006d:
		buLvgxMDMELiAQwSrbk(this, VpvifZMT3F1t7vD50MK(34744));
		num = 6;
		if (!VLFkxkMLJmpBHabc76q())
		{
			goto IL_0042;
		}
		goto IL_008d;
		IL_00a9:
		VTjMLCZbPN.Insert(index, location);
		num = 3;
		goto IL_0042;
		IL_008d:
		CheckLock();
		goto IL_00a9;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeletePoint(int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!xt7kKnMhW5TllRekvhN()) ? 6 : 4);
		while (true)
		{
			switch (num)
			{
			default:
				eKhMANDTNr();
				num = 2;
				break;
			case 1:
				if (CwBMwcMdI0Pdtuv0J9c(VTjMLCZbPN) <= 3)
				{
					num = 5;
					break;
				}
				VTjMLCZbPN.RemoveAt(index);
				goto default;
			case 5:
				throw new InvalidOperationException();
			case 2:
				buLvgxMDMELiAQwSrbk(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(34764));
				num = 7;
				break;
			case 0:
			case 4:
				CheckLock();
				num = 1;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static RectangleF bMWMoidoqG(List<PointF> P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (P_0.Count < 1)
		{
			return RectangleF.Empty;
		}
		float num = P_0[0].X;
		float num2 = P_0[0].X;
		float num3 = P_0[0].Y;
		float num4 = P_0[0].Y;
		for (int i = 1; i < P_0.Count; i++)
		{
			num = Math.Min(num, P_0[i].X);
			num2 = Math.Max(num2, P_0[i].X);
			num3 = Math.Min(num3, P_0[i].Y);
			num4 = Math.Max(num4, P_0[i].Y);
		}
		return new RectangleF(num, num3, num2 - num + 1f, num4 - num3 + 1f);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetSerializableGraphic()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 11;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_011b;
		IL_001a:
		CvsCogPolygon cvsCogPolygon = default;
		double[] array = default;
		tBcae8MiLJbk4CiTjwZ(cvsCogPolygon, array);
		num = 9;
		goto IL_011b;
		IL_011b:
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				break;
			case 9:
				nbCAIkMq3RmSWpcb9ud(cvsCogPolygon, CwBMwcMdI0Pdtuv0J9c(VTjMLCZbPN));
				cvsCogPolygon.CellLocation = CellLocation.ToString();
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 11;
			case 11:
				cvsCogPolygon = new CvsCogPolygon();
				_ = 1;
				num = (VLFkxkMLJmpBHabc76q() ? 10 : 3);
				continue;
			case 0:
			case 6:
				if (num2 < CwBMwcMdI0Pdtuv0J9c(VTjMLCZbPN))
				{
					array[num2 * 2] = VTjMLCZbPN[num2].X;
					goto case 4;
				}
				num = 8;
				continue;
			case 1:
			case 3:
				array = new double[VTjMLCZbPN.Count * 2];
				num = 2;
				continue;
			case 5:
				cvsCogPolygon.Color = Color.ToArgb();
				num = 12;
				continue;
			case 7:
				num2++;
				goto case 0;
			default:
				num = 6;
				if (xt7kKnMhW5TllRekvhN())
				{
					continue;
				}
				goto case 2;
			case 2:
				num2 = 0;
				num = 0;
				continue;
			case 4:
			case 10:
				array[num2 * 2 + 1] = VTjMLCZbPN[num2].Y;
				num = 7;
				continue;
			case 12:
				return cvsCogPolygon;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogPolygon poly)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
			case 4:
				if (num2 < ((Array)gnSMx5MBbRlT5boOFXB(poly)).Length)
				{
					InsertPoint(num2 / 2, new PointF((float)((double[])gnSMx5MBbRlT5boOFXB(poly))[num2], (float)((double[])gnSMx5MBbRlT5boOFXB(poly))[num2 + 1]));
					num = 0;
					break;
				}
				goto case 5;
			case 0:
				num2 += 2;
				goto case 1;
			default:
				num = 4;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
			case 7:
				DisplayFill = hVCJVNMjavQc9BvD7U5(poly);
				num = 8;
				break;
			case 6:
				base.FromSerializableGraphic(poly);
				num = 3;
				break;
			case 3:
				num2 = 0;
				VLFkxkMLJmpBHabc76q();
				if (!xt7kKnMhW5TllRekvhN())
				{
					num = 7;
					if (xt7kKnMhW5TllRekvhN())
					{
						break;
					}
					goto case 0;
				}
				num = 1;
				if (VLFkxkMLJmpBHabc76q())
				{
				}
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void eKhMANDTNr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		r1jM3vAyF7 = RectangleF.Empty;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void epPf7cM9T9G6vf1hp5x()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xt7kKnMhW5TllRekvhN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VLFkxkMLJmpBHabc76q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mYtBu2MSvFwKQRSit7G(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingPolygon)P_0).Move;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Qc9HaxMEUxn2WefKep9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingPolygon)P_0).Rotate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oR63dOMvrEH4Ibwh9xd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingPolygon)P_0).Scale;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MXa92RMHB2gCqkkoi0H(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingPolygon)P_0).RemovePoints;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YxjP1TMVfAGWXwBvdAx(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingPolygon)P_0).MovePoints;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bvILJXMAB4TJERP4oE3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogEditingShape)P_0).Bounds;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void buLvgxMDMELiAQwSrbk(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PbjqD9MU6wb7qJ1ikON(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<PointF>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VpvifZMT3F1t7vD50MK(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CwBMwcMdI0Pdtuv0J9c(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<PointF>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tBcae8MiLJbk4CiTjwZ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogPolygon)P_0).Points = (double[])P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nbCAIkMq3RmSWpcb9ud(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogPolygon)P_0).Length = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gnSMx5MBbRlT5boOFXB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogPolygon)P_0).Points;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hVCJVNMjavQc9BvD7U5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogPolygon)P_0).ShowFill;
	}
}
