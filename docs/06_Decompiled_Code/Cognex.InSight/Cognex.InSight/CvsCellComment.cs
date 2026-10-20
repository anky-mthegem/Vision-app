using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

[Serializable]
public class CvsCellComment
{
	private string vVBIUon9pq;

	private Color zvyI0Cqp9Q;

	public static readonly Color DefaultFlagColor;

	public static readonly CvsCellComment Empty;

	public string Text
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return vVBIUon9pq;
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
			if (qWSuZELHRYgPEM28DE1())
			{
				num = 4;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_0048;
				}
			}
			goto IL_005d;
			IL_0048:
			value = null;
			goto IL_0084;
			IL_005d:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					break;
				case 1:
				case 3:
					goto IL_0048;
				default:
					num = 2;
					continue;
				case 2:
					goto IL_0084;
				case 5:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			if (value == "")
			{
				goto IL_0048;
			}
			goto IL_0084;
			IL_0084:
			vVBIUon9pq = value;
			num = 5;
			goto IL_005d;
		}
	}

	public Color FlagColor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zvyI0Cqp9Q;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zvyI0Cqp9Q = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellComment(string text)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RI6JCvLA1Bn66BPBKYd();
		this._002Ector(text, DefaultFlagColor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellComment(string text, Color flagColor)
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
			default:
				FlagColor = flagColor;
				num = 6;
				continue;
			case 1:
			case 2:
				base._002Ector();
				num = 5;
				if (qWSuZELHRYgPEM28DE1())
				{
					continue;
				}
				goto case 5;
			case 5:
				Text = text;
				goto default;
			case 4:
				break;
			case 6:
				return;
			}
			do
			{
				RI6JCvLA1Bn66BPBKYd();
				_ = 1;
				if (cbo2wHLVi6gINTp51U8())
				{
					num = 0;
					continue;
				}
				num = 2;
				break;
			}
			while (1 == 0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellComment(CvsCellComment comment)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		this._002Ector((string)M9KS60LDvcS3eCKISbh(comment), IF8ZRcLUPLkwT27bSXc(comment));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!qWSuZELHRYgPEM28DE1()) ? 6 : 5);
		CvsCellComment cvsCellComment = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 6:
				if (vVBIUon9pq == null)
				{
					goto case 3;
				}
				goto IL_00b7;
			default:
				num = 3;
				break;
			case 4:
				return false;
			case 3:
				if (cvsCellComment.vVBIUon9pq == null)
				{
					num = 1;
					break;
				}
				goto IL_00b7;
			case 0:
			case 5:
				if (obj is CvsCellComment)
				{
					cvsCellComment = (CvsCellComment)obj;
					goto case 2;
				}
				num = 4;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
				return true;
			case 7:
				{
					return zvyI0Cqp9Q.ToArgb() == cvsCellComment.zvyI0Cqp9Q.ToArgb();
				}
				IL_00b7:
				if (KygqqhLTUVjS8LIwkEM(vVBIUon9pq, cvsCellComment.vVBIUon9pq))
				{
					num = 7;
					break;
				}
				return false;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (vVBIUon9pq == null)
		{
			return 0;
		}
		return vVBIUon9pq.GetHashCode() ^ zvyI0Cqp9Q.ToArgb();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsCellComment()
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
			case 0:
			case 1:
				DefaultFlagColor = Color.Red;
				goto default;
			default:
				Empty = new CvsCellComment(null, DefaultFlagColor);
				num = 5;
				break;
			case 4:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				_ = 1;
				num = (cbo2wHLVi6gINTp51U8() ? 3 : 0);
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RI6JCvLA1Bn66BPBKYd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qWSuZELHRYgPEM28DE1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cbo2wHLVi6gINTp51U8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object M9KS60LDvcS3eCKISbh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellComment)P_0).Text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color IF8ZRcLUPLkwT27bSXc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellComment)P_0).FlagColor;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool KygqqhLTUVjS8LIwkEM(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}
}
