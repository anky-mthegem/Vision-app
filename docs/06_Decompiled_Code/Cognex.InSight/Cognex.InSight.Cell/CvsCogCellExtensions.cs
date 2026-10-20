using System.Drawing;
using System.Runtime.CompilerServices;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;

namespace Cognex.InSight.Cell;

public static class CvsCogCellExtensions
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool HasComment(this CvsCogCellResult cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return !wf2glmyM3OKFYNMvbrm(cell.Comment);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsCellComment GetComment(this CvsCogCellResult cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		Color flagColor = default;
		CvsCellFormat cvsCellFormat = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				flagColor = WW5KXByegfolXRmg94d(cvsCellFormat);
				num = 7;
				continue;
			case 2:
			case 6:
				cvsCellFormat = (CvsCellFormat)vkos3tylnXQjFCo1tcb(cell);
				goto case 3;
			default:
				num = 3;
				continue;
			case 1:
			case 5:
				return null;
			case 0:
				if (rSFOyMyQw26W5bPUHVu(cell))
				{
					flagColor = CvsCellComment.DefaultFlagColor;
					goto case 2;
				}
				TswU6GyODCEd9cJjE3Y();
				num = (jXiCqSy32usZ0HlscaA() ? 5 : 6);
				continue;
			case 3:
				if (cvsCellFormat != null)
				{
					num = 4;
					continue;
				}
				break;
			case 7:
				break;
			}
			break;
		}
		return new CvsCellComment(new CvsCellComment((string)aOAYCfyuZfGtuW6GY35(cell), flagColor));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsCellFormat GetCellFormat(this CvsCogCellResult cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		TswU6GyODCEd9cJjE3Y();
		int num;
		if (jXiCqSy32usZ0HlscaA())
		{
			num = 5;
		}
		else
		{
			num = 6;
			if (false)
			{
				goto IL_004a;
			}
		}
		goto IL_0079;
		IL_00ac:
		CvsCellFormat cvsCellFormat = default;
		cvsCellFormat.SetDefaultFonts(CvsCellFormat.DefaultUnscaledFont, CvsCellFormat.DefaultUnscaledFont);
		num = 1;
		if (true)
		{
			goto IL_0079;
		}
		goto IL_00c8;
		IL_004a:
		cvsCellFormat = new CvsCellFormat(new CvsCellLocation((string)UX6gcQyaliDC0wJ7Cuu(cell)), (string)pD7lWXyIbpCHv7eXDSg(cell), cell.GraphicsStyle);
		goto IL_00ac;
		IL_0079:
		while (true)
		{
			switch (num)
			{
			case 4:
				if (wf2glmyM3OKFYNMvbrm(km9WiGyR80J5HUZixTf(cell)))
				{
					goto IL_00c8;
				}
				goto IL_00ca;
			case 7:
				break;
			default:
				num = 3;
				continue;
			case 3:
				goto IL_00ac;
			case 2:
			case 6:
				goto IL_00c8;
			case 0:
			case 5:
				if (wf2glmyM3OKFYNMvbrm(pD7lWXyIbpCHv7eXDSg(cell)))
				{
					num = 4;
					continue;
				}
				goto IL_00ca;
			case 1:
				cell.CellFormatCache = cvsCellFormat;
				num = 8;
				continue;
			case 8:
				{
					return (CvsCellFormat)cell.CellFormatCache;
				}
				IL_00ca:
				if (cell.CellFormatCache == null)
				{
					num = 7;
					if (true)
					{
						continue;
					}
					goto case 0;
				}
				goto case 8;
			}
			break;
		}
		goto IL_004a;
		IL_00c8:
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wf2glmyM3OKFYNMvbrm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jXiCqSy32usZ0HlscaA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TswU6GyODCEd9cJjE3Y()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rSFOyMyQw26W5bPUHVu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).HasComment();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vkos3tylnXQjFCo1tcb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).GetCellFormat();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color WW5KXByegfolXRmg94d(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellFormat)P_0).CommentFlagColor;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aOAYCfyuZfGtuW6GY35(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Comment;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pD7lWXyIbpCHv7eXDSg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).CellStyle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object km9WiGyR80J5HUZixTf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).GraphicsStyle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UX6gcQyaliDC0wJ7Cuu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Location;
	}
}
