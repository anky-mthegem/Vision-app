using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Graphic;

[Serializable]
public sealed class CvsGraphicBeadPathMask : CvsGraphic, ICvsEditableGraphic
{
	[CompilerGenerated]
	private double BsNBJaYFBD;

	[CompilerGenerated]
	private bool gB4BMTyKUd;

	[CompilerGenerated]
	private bool XSdBoJ1jOJ;

	[CompilerGenerated]
	private bool io0BAQjhX3;

	private RectangleF U5KBtT9C8B;

	private CvsEditFlags wmOBWGplJ6;

	private List<BeadPathVertex> HKLB3iOeh0;

	public double CaliperWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return BsNBJaYFBD;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			BsNBJaYFBD = value;
		}
	}

	public IEnumerable<BeadPathVertex> Vertices
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HKLB3iOeh0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CheckLock();
			List<BeadPathVertex> collection = value.ToList();
			HKLB3iOeh0.Clear();
			HKLB3iOeh0.AddRange(collection);
			OnPropertyChanged(kgbOBx7BanbFa22Hp9.ol99ukmDA(34014));
		}
	}

	public bool Closed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return gB4BMTyKUd;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			gB4BMTyKUd = value;
		}
	}

	public bool ShowFillAreas
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XSdBoJ1jOJ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			XSdBoJ1jOJ = value;
		}
	}

	public bool ShowIgnoreAreas
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return io0BAQjhX3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			io0BAQjhX3 = value;
		}
	}

	public int MinVertexCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (!Closed)
			{
				return 2;
			}
			return 3;
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
			return wmOBWGplJ6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (IrGPDaYZSNkQPj0Z0Iu() ? 4 : 3);
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					wmOBWGplJ6 = value & (CvsEditFlags.MaskArea | CvsEditFlags.FillEdgeArea);
					goto case 2;
				default:
					num = 2;
					break;
				case 2:
					WtEdRcNEeFP7OZHuysc(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(33720));
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				case 0:
				case 3:
					CheckLock();
					goto case 1;
				case 5:
					return;
				}
			}
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
			return U5KBtT9C8B;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dr9usMYgO2Et3rsVlYs();
			int num = (IrGPDaYZSNkQPj0Z0Iu() ? 2 : 4);
			while (true)
			{
				switch (num)
				{
				case 3:
					WtEdRcNEeFP7OZHuysc(this, sgcQ8YNhWOued7dpuaZ(33862));
					num = 5;
					break;
				case 1:
				case 2:
					U5KBtT9C8B = value;
					goto case 3;
				default:
					num = 3;
					break;
				case 0:
				case 4:
					CheckLock();
					goto case 1;
				case 5:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicBeadPathMask(CvsGraphicBeadPathMask graphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 9;
		while (true)
		{
			switch (num)
			{
			case 3:
				Closed = UJggk8Y8injnctoWKVC(graphic);
				num = 4;
				continue;
			case 1:
				wmOBWGplJ6 = CvsEditFlags.MaskArea | CvsEditFlags.FillEdgeArea;
				dr9usMYgO2Et3rsVlYs();
				num = (IrGPDaYZSNkQPj0Z0Iu() ? 7 : 8);
				continue;
			case 2:
			case 8:
				HKLB3iOeh0 = new List<BeadPathVertex>();
				num = 6;
				continue;
			case 6:
				base._002Ector(graphic);
				num = 0;
				if (IrGPDaYZSNkQPj0Z0Iu())
				{
				}
				continue;
			case 4:
				ShowFillAreas = qfiK6UYzZDLk9HM69ec(graphic);
				num = 10;
				continue;
			case 0:
				CaliperWidth = NdAH8aYJVo78kV14I5Y(graphic);
				break;
			case 9:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				num = 1;
				continue;
			case 10:
				ShowIgnoreAreas = Vvl5u6Nwfmfga2RTmpv(graphic);
				num = 11;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 11:
				return;
			}
			HKLB3iOeh0 = new List<BeadPathVertex>(graphic.Vertices);
			num = 3;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsGraphicBeadPathMask()
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
		goto IL_0066;
		IL_001a:
		base._002Ector();
		num = 6;
		goto IL_0066;
		IL_0066:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 5:
				hOCoCFNsqpEpnFRJiV8();
				IrGPDaYZSNkQPj0Z0Iu();
				num = (dr9usMYgO2Et3rsVlYs() ? 3 : 0);
				continue;
			case 0:
			case 2:
				HKLB3iOeh0 = new List<BeadPathVertex>();
				break;
			default:
				num = 4;
				continue;
			case 1:
			case 3:
				wmOBWGplJ6 = CvsEditFlags.MaskArea | CvsEditFlags.FillEdgeArea;
				goto case 0;
			case 6:
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
		return new CvsGraphicBeadPathMask(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVertexLocation(int index, PointF location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IrGPDaYZSNkQPj0Z0Iu();
		int num = ((!dr9usMYgO2Et3rsVlYs()) ? 3 : 4);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				CheckLock();
				goto case 1;
			case 1:
			case 3:
				HKLB3iOeh0[index] = new BeadPathVertex(location, HKLB3iOeh0[index].Flags);
				break;
			default:
				num = 2;
				continue;
			case 2:
				break;
			case 5:
				return;
			}
			OnPropertyChanged((string)sgcQ8YNhWOued7dpuaZ(34014));
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanInsertVertex(int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!IsLocked && index >= 0)
		{
			return index <= HKLB3iOeh0.Count();
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InsertVertex(int index, PointF location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		BeadPathMaskFlags flags = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				flags = edjWn7NLNSHqfL137hU(HKLB3iOeh0[index - 1]);
				goto case 6;
			default:
				num = 6;
				continue;
			case 6:
				HKLB3iOeh0.Insert(index, new BeadPathVertex(location, flags));
				break;
			case 5:
				flags = BeadPathMaskFlags.None;
				IrGPDaYZSNkQPj0Z0Iu();
				if (!dr9usMYgO2Et3rsVlYs())
				{
					num = 2;
					continue;
				}
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 3:
				if (index > 0)
				{
					num = 0;
					continue;
				}
				goto case 6;
			case 2:
			case 4:
				break;
			case 7:
				return;
			}
			OnPropertyChanged(kgbOBx7BanbFa22Hp9.ol99ukmDA(34014));
			num = 7;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanDeleteVertex(int index)
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
			case 0:
			case 1:
				return false;
			default:
				if (index >= cpEoqKN9MOKh2RfN0eB(HKLB3iOeh0))
				{
					num = 5;
					continue;
				}
				return !IsLocked;
			case 3:
				if (cpEoqKN9MOKh2RfN0eB(HKLB3iOeh0) > MinVertexCount)
				{
					if (index < 0)
					{
						break;
					}
					goto default;
				}
				_ = 0;
				if (!dr9usMYgO2Et3rsVlYs())
				{
					num = 4;
					continue;
				}
				num = 0;
				if (!IrGPDaYZSNkQPj0Z0Iu())
				{
					continue;
				}
				break;
			case 5:
				break;
			}
			break;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteVertex(int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!dr9usMYgO2Et3rsVlYs()) ? 4 : 3);
		while (true)
		{
			switch (num)
			{
			case 5:
				WtEdRcNEeFP7OZHuysc(this, sgcQ8YNhWOued7dpuaZ(34014));
				num = 6;
				if (dr9usMYgO2Et3rsVlYs())
				{
					break;
				}
				goto case 2;
			case 2:
			case 4:
				throw new InvalidOperationException();
			default:
				num = 5;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
				if (cpEoqKN9MOKh2RfN0eB(HKLB3iOeh0) > MinVertexCount)
				{
					LmgubONSrryr1JfNM1H(HKLB3iOeh0, index);
					goto case 5;
				}
				goto case 2;
			case 0:
			case 3:
				CheckLock();
				num = 1;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanDeleteVerticesBefore(int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (!IrGPDaYZSNkQPj0Z0Iu())
		{
		}
		while (true)
		{
			switch (num)
			{
			default:
				return false;
			case 4:
				if (index <= 0)
				{
					goto default;
				}
				IrGPDaYZSNkQPj0Z0Iu();
				if (dr9usMYgO2Et3rsVlYs())
				{
					num = 3;
					if (dr9usMYgO2Et3rsVlYs())
					{
						break;
					}
					goto case 1;
				}
				num = 0;
				break;
			case 1:
			case 3:
				if (index < HKLB3iOeh0.Count)
				{
					if (HKLB3iOeh0.Count - index < MinVertexCount)
					{
						num = 5;
						break;
					}
					return !IsLocked;
				}
				goto default;
			case 5:
				return false;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteVerticesBefore(int index)
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
				CheckLock();
				_ = 0;
				num = (dr9usMYgO2Et3rsVlYs() ? 5 : 0);
				break;
			case 2:
				throw new InvalidOperationException();
			default:
				OnPropertyChanged((string)sgcQ8YNhWOued7dpuaZ(34014));
				num = 6;
				break;
			case 1:
			case 5:
				if (CanDeleteVerticesBefore(index))
				{
					YqAFHWNv19L9jWOq4gq(HKLB3iOeh0, 0, index);
					goto default;
				}
				num = 2;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanDeleteVerticesAfter(int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		dr9usMYgO2Et3rsVlYs();
		int num;
		if (!IrGPDaYZSNkQPj0Z0Iu())
		{
			num = 2;
		}
		else
		{
			num = 4;
			if (IrGPDaYZSNkQPj0Z0Iu())
			{
				goto IL_00ad;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				if (index >= cpEoqKN9MOKh2RfN0eB(HKLB3iOeh0) - 1)
				{
					goto case 3;
				}
				if (index + 1 < MinVertexCount)
				{
					num = 5;
					if (true)
					{
						continue;
					}
					goto case 0;
				}
				return !IsLocked;
			default:
				num = 3;
				continue;
			case 3:
				return false;
			case 0:
			case 2:
				if (index >= 0)
				{
					goto case 1;
				}
				goto case 3;
			case 5:
				break;
			}
			break;
		}
		goto IL_00ad;
		IL_00ad:
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteVerticesAfter(int index)
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
			case 2:
				throw new InvalidOperationException();
			default:
				WtEdRcNEeFP7OZHuysc(this, kgbOBx7BanbFa22Hp9.ol99ukmDA(34014));
				num = 6;
				if (dr9usMYgO2Et3rsVlYs())
				{
					break;
				}
				goto case 4;
			case 4:
				CheckLock();
				dr9usMYgO2Et3rsVlYs();
				if (IrGPDaYZSNkQPj0Z0Iu())
				{
					num = 5;
					if (!IrGPDaYZSNkQPj0Z0Iu())
					{
						break;
					}
					goto default;
				}
				num = 0;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 1:
				if (CanDeleteVerticesAfter(index))
				{
					YqAFHWNv19L9jWOq4gq(HKLB3iOeh0, index + 1, cpEoqKN9MOKh2RfN0eB(HKLB3iOeh0) - index - 1);
					goto default;
				}
				num = 2;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override object GetSerializableGraphic()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		CvsCogBeadPathMask cvsCogBeadPathMask = default;
		List<BeadPathVertex>.Enumerator enumerator = default;
		List<int> list2 = default;
		List<float> list = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				MnXcN3NVrnbDwqsQseV(cvsCogBeadPathMask, Closed);
				num = 9;
				break;
			case 11:
				gRohlENHfThca6Tw074(cvsCogBeadPathMask, CaliperWidth);
				num = 1;
				break;
			case 3:
				try
				{
					while (enumerator.MoveNext())
					{
						BeadPathVertex current = enumerator.Current;
						int num2 = 3;
						if (1 == 0)
						{
							goto IL_005e;
						}
						goto IL_009d;
						IL_005e:
						list2.Add((int)current.Flags);
						num2 = 5;
						goto IL_009d;
						IL_009d:
						while (true)
						{
							switch (num2)
							{
							case 1:
							case 4:
								list.Add(ijwYSXNTjJ3POKxUjyb(current).Y);
								break;
							case 3:
								do
								{
									list.Add(ijwYSXNTjJ3POKxUjyb(current).X);
									_ = 1;
									if (IrGPDaYZSNkQPj0Z0Iu())
									{
										num2 = 0;
										continue;
									}
									num2 = 4;
									break;
								}
								while (IrGPDaYZSNkQPj0Z0Iu());
								continue;
							case 5:
								goto IL_00fc;
							}
							break;
						}
						goto IL_005e;
						IL_00fc:;
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
				}
				cvsCogBeadPathMask.points = list;
				num = 2;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 6:
				list2 = new List<int>(cpEoqKN9MOKh2RfN0eB(HKLB3iOeh0));
				goto case 5;
			case 4:
				CuJNrWNUYFMencLoye4(cvsCogBeadPathMask, cpEoqKN9MOKh2RfN0eB(HKLB3iOeh0));
				list = new List<float>(cpEoqKN9MOKh2RfN0eB(HKLB3iOeh0) * 2);
				goto default;
			default:
				_ = 1;
				if (IrGPDaYZSNkQPj0Z0Iu())
				{
					num = 5;
					break;
				}
				num = 0;
				if (dr9usMYgO2Et3rsVlYs())
				{
					break;
				}
				goto case 8;
			case 8:
				cvsCogBeadPathMask = new CvsCogBeadPathMask();
				num = 11;
				break;
			case 10:
				oWX6YNNDBYbnninWLwr(cvsCogBeadPathMask, ShowIgnoreAreas);
				num = 4;
				break;
			case 9:
				ebjmgvNA2t5V7EqWKa2(cvsCogBeadPathMask, ShowFillAreas);
				num = 10;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 5:
			case 7:
				enumerator = HKLB3iOeh0.GetEnumerator();
				num = 3;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
				cvsCogBeadPathMask.pointFlags = list2;
				num = 12;
				break;
			case 12:
				return cvsCogBeadPathMask;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FromSerializableGraphic(CvsCogBeadPathMask serializableBeadPath)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		if (!dr9usMYgO2Et3rsVlYs())
		{
			goto IL_001e;
		}
		goto IL_00e1;
		IL_001e:
		if (oYs8WRNjGJF7De365JY(serializableBeadPath) > 0)
		{
			num = 13;
			if (false)
			{
				goto IL_0036;
			}
			goto IL_00e1;
		}
		throw new Exception(kgbOBx7BanbFa22Hp9.ol99ukmDA(34034));
		IL_00e1:
		List<BeadPathVertex> list = default;
		List<float>.Enumerator enumerator = default;
		List<int>.Enumerator enumerator2 = default;
		float current2 = default;
		float current = default;
		while (true)
		{
			switch (num)
			{
			case 12:
				break;
			case 14:
				goto IL_0036;
			case 3:
				ShowFillAreas = ncg5fTNqOnm26jQNvWe(serializableBeadPath);
				num = 0;
				continue;
			case 15:
				if (cpEoqKN9MOKh2RfN0eB(list) != serializableBeadPath.NumPoints)
				{
					throw new Exception((string)sgcQ8YNhWOued7dpuaZ(34034));
				}
				HKLB3iOeh0 = list;
				num = 16;
				continue;
			case 0:
				ShowIgnoreAreas = dVS4xCNBxeUIh6jG5Ut(serializableBeadPath);
				num = 12;
				continue;
			case 9:
				enumerator = serializableBeadPath.points.GetEnumerator();
				enumerator2 = serializableBeadPath.pointFlags.GetEnumerator();
				goto case 1;
			default:
				goto IL_012a;
			case 5:
				list.Add(new BeadPathVertex(new PointF(current2, current), (BeadPathMaskFlags)enumerator2.Current));
				goto case 1;
			case 7:
				base.FromSerializableGraphic(serializableBeadPath);
				num = 14;
				if (true)
				{
					continue;
				}
				goto case 4;
			case 4:
				throw new Exception(kgbOBx7BanbFa22Hp9.ol99ukmDA(34034));
			case 13:
				list = new List<BeadPathVertex>(oYs8WRNjGJF7De365JY(serializableBeadPath));
				num = 9;
				if (0 == 0)
				{
					continue;
				}
				goto case 8;
			case 8:
			case 10:
				if (enumerator.MoveNext())
				{
					current = enumerator.Current;
					num = 5;
				}
				else
				{
					num = 4;
				}
				continue;
			case 2:
				Closed = oYKcvXNib40mYgavgqc(serializableBeadPath);
				num = 3;
				continue;
			case 6:
				goto IL_01e4;
			case 1:
			case 11:
				if (enumerator.MoveNext())
				{
					num = 6;
					if (true)
					{
						continue;
					}
					return;
				}
				goto case 15;
			case 16:
				return;
			}
			break;
			IL_01e4:
			if (enumerator2.MoveNext())
			{
				current2 = enumerator.Current;
				goto IL_012a;
			}
			num = 15;
			continue;
			IL_012a:
			_ = 1;
			num = (IrGPDaYZSNkQPj0Z0Iu() ? 1 : 10);
		}
		goto IL_001e;
		IL_0036:
		CaliperWidth = zxybJGNdW8m2WLYcdSp(serializableBeadPath);
		num = 2;
		goto IL_00e1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double NdAH8aYJVo78kV14I5Y(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicBeadPathMask)P_0).CaliperWidth;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UJggk8Y8injnctoWKVC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicBeadPathMask)P_0).Closed;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qfiK6UYzZDLk9HM69ec(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicBeadPathMask)P_0).ShowFillAreas;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Vvl5u6Nwfmfga2RTmpv(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicBeadPathMask)P_0).ShowIgnoreAreas;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dr9usMYgO2Et3rsVlYs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IrGPDaYZSNkQPj0Z0Iu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hOCoCFNsqpEpnFRJiV8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sgcQ8YNhWOued7dpuaZ(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static BeadPathMaskFlags edjWn7NLNSHqfL137hU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BeadPathVertex)P_0).Flags;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int cpEoqKN9MOKh2RfN0eB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<BeadPathVertex>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LmgubONSrryr1JfNM1H(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((List<BeadPathVertex>)P_0).RemoveAt(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WtEdRcNEeFP7OZHuysc(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic)P_0).OnPropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YqAFHWNv19L9jWOq4gq(object P_0, int P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((List<BeadPathVertex>)P_0).RemoveRange(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gRohlENHfThca6Tw074(object P_0, double P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogBeadPathMask)P_0).CaliperWidth = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MnXcN3NVrnbDwqsQseV(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogBeadPathMask)P_0).Closed = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ebjmgvNA2t5V7EqWKa2(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogBeadPathMask)P_0).ShowFillAreas = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oWX6YNNDBYbnninWLwr(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogBeadPathMask)P_0).ShowIgnoreAreas = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CuJNrWNUYFMencLoye4(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogBeadPathMask)P_0).NumPoints = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF ijwYSXNTjJ3POKxUjyb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BeadPathVertex)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double zxybJGNdW8m2WLYcdSp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogBeadPathMask)P_0).CaliperWidth;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oYKcvXNib40mYgavgqc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogBeadPathMask)P_0).Closed;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ncg5fTNqOnm26jQNvWe(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogBeadPathMask)P_0).ShowFillAreas;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dVS4xCNBxeUIh6jG5Ut(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogBeadPathMask)P_0).ShowIgnoreAreas;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int oYs8WRNjGJF7De365JY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogBeadPathMask)P_0).NumPoints;
	}
}
