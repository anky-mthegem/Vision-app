using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.Remoting.Serialization;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels;

public static class CellExtensions
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsReadOnly(this CvsCell cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (MrJsUsJTMDgOLLFmBll())
		{
			num = 4;
		}
		else
		{
			num = 2;
			if (!MrJsUsJTMDgOLLFmBll())
			{
				goto IL_0045;
			}
		}
		goto IL_0077;
		IL_00c4:
		return false;
		IL_0045:
		if (!(cell is CvsCellEditFloat))
		{
			num = 3;
			goto IL_0077;
		}
		goto IL_00c4;
		IL_0077:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			case 1:
			case 2:
				goto end_IL_0077;
			case 3:
				if (!(cell is CvsCellListBox))
				{
					goto case 5;
				}
				goto IL_00c4;
			default:
				num = 5;
				continue;
			case 5:
				if (!(cell is CvsCellEditString))
				{
					num = 6;
					continue;
				}
				goto IL_00c4;
			case 6:
				return !(cell is CvsCellCheckBox);
			}
			if (!(cell is CvsCellEditInt))
			{
				break;
			}
			goto IL_00c4;
			continue;
			end_IL_0077:
			break;
		}
		goto IL_0045;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetBaseName(this CvsCell cell, CvsInSight inSight, string defaultBaseName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 38;
		string text = default;
		string text2;
		while (true)
		{
			switch (num)
			{
			case 0:
				text = (string)E7qCL0JUdPFiYraDP0Y();
				goto case 1;
			case 12:
				if (cell is CvsCellCheckBox)
				{
					goto IL_004d;
				}
				if (cell is CvsCellFloat)
				{
					num = 34;
					if (0 == 0)
					{
						continue;
					}
					goto case 9;
				}
				goto case 1;
			case 11:
				text = (string)hmyHQyJmA4VJJaCWhY4();
				goto case 1;
			case 8:
				text = (string)gncqxsJHLJp4t9TdHkd();
				num = 30;
				continue;
			case 16:
				text = (string)D5tgpkJFb0gOL717Z3X();
				num = 35;
				continue;
			case 28:
				if (cBmksZJ0Fw4oevdk5g7(cell))
				{
					num = 16;
					continue;
				}
				if (!(cell is CvsCellButton))
				{
					if (cell is CvsCellString)
					{
						goto case 20;
					}
					if (cell is CvsCellColorLabel)
					{
						num = 32;
						continue;
					}
					if (!(cell is CvsCellStatusLight) && !(cell is CvsCellStatus))
					{
						num = 17;
						if (true)
						{
							continue;
						}
						goto case 36;
					}
					goto case 21;
				}
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 38;
			case 9:
				if (!(cell is CvsCellListBox))
				{
					num = 25;
					continue;
				}
				goto IL_004d;
			case 25:
				if (!(cell is CvsCellEditString))
				{
					num = 12;
					continue;
				}
				goto IL_004d;
			case 22:
				text = (string)M25J8aJhBk5LF8IUfs1();
				goto case 1;
			case 1:
			case 3:
			case 5:
			case 13:
			case 18:
			case 19:
			case 23:
			case 24:
			case 27:
			case 30:
			case 31:
			case 35:
			case 37:
			case 39:
				text2 = text;
				if (text2 == null)
				{
					num = 44;
					continue;
				}
				break;
			case 4:
				text = Resources.Annulus;
				goto case 1;
			case 38:
				text = null;
				num = 42;
				continue;
			case 2:
				text = JmGp9fEx6o(cell, text);
				num = 19;
				continue;
			case 33:
				text = (string)hmyHQyJmA4VJJaCWhY4();
				num = 24;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 17:
				if (cell is CvsCellMultiStatus)
				{
					num = 21;
					continue;
				}
				if (cell is CvsCellEditFloat)
				{
					goto IL_004d;
				}
				num = 15;
				if (true)
				{
					continue;
				}
				goto case 44;
			case 34:
				text = (string)VnVM4baKtyZS5u9ZWAG(cell, inSight, text);
				if (text == null)
				{
					num = 2;
					continue;
				}
				goto case 1;
			case 26:
				text = Resources.l1fZTglVqg();
				goto case 1;
			case 43:
				text = (string)D5tgpkJFb0gOL717Z3X();
				goto case 1;
			default:
				num = 40;
				if (true)
				{
					continue;
				}
				goto case 32;
			case 32:
				text = Resources.MaursiNrNV();
				goto case 1;
			case 36:
				text = (string)PiXCflJuDWR6DeecpDR();
				num = 3;
				continue;
			case 42:
				if (cell.IsInputImage)
				{
					goto case 16;
				}
				num = 28;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 15:
				if (!(cell is CvsCellEditInt))
				{
					num = 9;
					continue;
				}
				goto IL_004d;
			case 10:
			case 14:
				text = (string)GO9gxQJNgfyT5hE2gme();
				num = 1;
				continue;
			case 7:
				text = (string)tgrRBmJxet53HCWLxZR();
				num = 13;
				continue;
			case 40:
				text = (string)uOPEbrJzDguZ5j0wleG();
				num = 37;
				continue;
			case 29:
				text = Resources.Circle;
				num = 39;
				continue;
			case 20:
			case 41:
				if (!(Ykbuw7JYUpUQPmSXhtK(LXoV0oJMAWYMXRLKNMh(cell)) is CvsCogImage))
				{
					if (!(cell.CellResult.Value is CvsCogFixture))
					{
						if (Ykbuw7JYUpUQPmSXhtK(LXoV0oJMAWYMXRLKNMh(cell)) is CvsCogLine)
						{
							text = (string)tgrRBmJxet53HCWLxZR();
							num = 18;
							continue;
						}
						if (!(Ykbuw7JYUpUQPmSXhtK(LXoV0oJMAWYMXRLKNMh(cell)) is CvsCogCircle))
						{
							if (!(((CvsCogCellResult)LXoV0oJMAWYMXRLKNMh(cell)).Value is CvsCogPoint))
							{
								if (!(((CvsCogCellResult)LXoV0oJMAWYMXRLKNMh(cell)).Value is CvsCogRegion))
								{
									if (Ykbuw7JYUpUQPmSXhtK(LXoV0oJMAWYMXRLKNMh(cell)) is CvsCogAnnulus)
									{
										num = 4;
										continue;
									}
									text = (string)u0Ub8gaLlr5VCy7Dirg();
									num = 23;
									if (jaC23jJytcwvy9vVi5p())
									{
									}
								}
								else
								{
									num = 0;
								}
								continue;
							}
							num = 11;
							if (MrJsUsJTMDgOLLFmBll())
							{
								continue;
							}
							goto case 1;
						}
						num = 29;
						continue;
					}
					goto case 40;
				}
				num = 43;
				continue;
			case 6:
				if (!(Ykbuw7JYUpUQPmSXhtK(LXoV0oJMAWYMXRLKNMh(cell)) is CvsCogRegion))
				{
					if (!(Ykbuw7JYUpUQPmSXhtK(LXoV0oJMAWYMXRLKNMh(cell)) is CvsCogCircle))
					{
						if (Ykbuw7JYUpUQPmSXhtK(LXoV0oJMAWYMXRLKNMh(cell)) is CvsCogLine)
						{
							num = 7;
							continue;
						}
						if (!(Ykbuw7JYUpUQPmSXhtK(LXoV0oJMAWYMXRLKNMh(cell)) is CvsCogAnnulus))
						{
							if (Ykbuw7JYUpUQPmSXhtK(LXoV0oJMAWYMXRLKNMh(cell)) is CvsCogPoint)
							{
								num = 33;
								if (true)
								{
									continue;
								}
								goto case 2;
							}
							if (Ykbuw7JYUpUQPmSXhtK(cell.CellResult) is CvsCogPolygon)
							{
								text = (string)qQafZJJQ3kD5QiZ5old();
								num = 27;
								continue;
							}
							if (Ykbuw7JYUpUQPmSXhtK(LXoV0oJMAWYMXRLKNMh(cell)) is CvsCogPolyline)
							{
								_ = 0;
								num = (MrJsUsJTMDgOLLFmBll() ? 10 : 41);
								continue;
							}
							if (!pbfNrpJ2g2mC0kCcxXU(cell.Expression, CdQUGaROfy7He9T0foW.KbIzwHEDLa(1708), StringComparison.OrdinalIgnoreCase))
							{
								if (pbfNrpJ2g2mC0kCcxXU(Yx6Q5yJcIJ7s748RlH3(cell), P6fdtvJ1RkW0awGPacs(1750), StringComparison.OrdinalIgnoreCase))
								{
									num = 36;
									if (!jaC23jJytcwvy9vVi5p())
									{
										continue;
									}
									goto case 43;
								}
								if (pbfNrpJ2g2mC0kCcxXU(cell.Expression, P6fdtvJ1RkW0awGPacs(1786), StringComparison.OrdinalIgnoreCase))
								{
									num = 22;
									continue;
								}
								text = (string)SDmAhxJtbmYIPtiJQ7l();
							}
							else
							{
								num = 26;
								if (MrJsUsJTMDgOLLFmBll())
								{
									continue;
								}
							}
						}
						else
						{
							text = Resources.Annulus;
						}
						goto case 1;
					}
					num = 8;
					continue;
				}
				text = (string)E7qCL0JUdPFiYraDP0Y();
				num = 5;
				continue;
			case 21:
				text = Resources.LoMrv7BVQK();
				goto case 1;
			case 44:
				{
					text2 = defaultBaseName;
					break;
				}
				IL_004d:
				text = (string)VnVM4baKtyZS5u9ZWAG(cell, inSight, text);
				num = 31;
				continue;
			}
			break;
		}
		return text2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string JmGp9fEx6o(CvsCell P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		string text2 = default;
		string text = default;
		int num2 = default;
		while (true)
		{
			object obj;
			switch (num)
			{
			case 3:
				if (text2.Length > 3)
				{
					num = 2;
					continue;
				}
				break;
			case 5:
				text = (string)rakrTeaepPOuWIlnd8O(Yx6Q5yJcIJ7s748RlH3(P_0), 3, num2 - 3);
				num = 9;
				continue;
			case 0:
			case 4:
				num2 = fiqC03aaWibvWh1XgJD(text2, P6fdtvJ1RkW0awGPacs(1832));
				goto case 6;
			default:
				num = 6;
				continue;
			case 1:
			case 8:
				if (!AHx4aaa5Vb6DIgGelby(text2, P6fdtvJ1RkW0awGPacs(1822)))
				{
					break;
				}
				num = 3;
				if (MrJsUsJTMDgOLLFmBll())
				{
					continue;
				}
				goto case 7;
			case 7:
				text2 = ((string)Yx6Q5yJcIJ7s748RlH3(P_0)).ToLowerInvariant();
				_ = 1;
				if (!jaC23jJytcwvy9vVi5p())
				{
					num = 8;
					if (true)
					{
						continue;
					}
					goto case 6;
				}
				num = 0;
				continue;
			case 6:
				if (num2 >= 4)
				{
					num = 5;
					continue;
				}
				break;
			case 2:
				if (!NKyCZDaJgbyQZ6NsR6p(zAqgYdaw53YwhdckfYX(Yx6Q5yJcIJ7s748RlH3(P_0), 3)))
				{
					break;
				}
				goto case 0;
			case 9:
				if (Quv3nkaIBO1jRl3dajE(mmc9XnaO9I2eawCHQIb(text), CvsCellLocation.Invalid))
				{
					num = 10;
					if (true)
					{
						continue;
					}
					goto case 10;
				}
				goto IL_0171;
			case 10:
				{
					if (!Quv3nkaIBO1jRl3dajE(CvsCellLocation.TryParse((string)RBl6xhaDdNdVgNB4KXu(text, P6fdtvJ1RkW0awGPacs(1838))), CvsCellLocation.Invalid))
					{
						goto IL_0171;
					}
					obj = text;
					goto IL_0187;
				}
				IL_0171:
				obj = RBl6xhaDdNdVgNB4KXu(text, P6fdtvJ1RkW0awGPacs(1044));
				goto IL_0187;
				IL_0187:
				P_1 = (string)obj;
				break;
			}
			break;
		}
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string nkoprNhvMV(CvsCell P_0, CvsInSight P_1, string P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0039;
		IL_0072:
		_ = 1;
		if (!jaC23jJytcwvy9vVi5p())
		{
			num = 0;
		}
		else
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_00d9;
			}
		}
		goto IL_0039;
		IL_00d9:
		CvsCellLocation cvsCellLocation = default;
		cvsCellLocation.Row--;
		CvsCellString cvsCellString = HcB1RMaVxaShnXu25dY(DsSrNjanMMVyf18XVb8(P_1.Results), cvsCellLocation) as CvsCellString;
		num = 7;
		goto IL_0039;
		IL_0039:
		string text = default;
		while (true)
		{
			object obj;
			switch (num)
			{
			case 10:
				break;
			default:
				goto IL_0072;
			case 9:
				if (AHx4aaa5Vb6DIgGelby(Yx6Q5yJcIJ7s748RlH3(cvsCellString), P6fdtvJ1RkW0awGPacs(1538)))
				{
					num = 10;
					continue;
				}
				goto IL_01f7;
			case 4:
				text = text.Replace(CdQUGaROfy7He9T0foW.KbIzwHEDLa(1878), (string)P6fdtvJ1RkW0awGPacs(1044));
				goto case 3;
			case 5:
				goto IL_00d9;
			case 0:
			case 6:
				if (new Regex((string)P6fdtvJ1RkW0awGPacs(1844)).IsMatch(text))
				{
					num = 4;
					continue;
				}
				goto IL_01f7;
			case 3:
			case 8:
				text = (string)mDPKpXafbiPYWiY8QSw(text, P6fdtvJ1RkW0awGPacs(1884), "");
				num = 11;
				continue;
			case 1:
				if (cvsCellLocation.Row > 0)
				{
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					goto case 2;
				}
				goto IL_01f7;
			case 2:
				cvsCellLocation = gDgJMXaiSAHmLDIHZqR(P_0);
				num = 1;
				if (0 == 0)
				{
					continue;
				}
				goto case 11;
			case 11:
				if (Quv3nkaIBO1jRl3dajE(mmc9XnaO9I2eawCHQIb(text), CvsCellLocation.Invalid))
				{
					num = 12;
					if (!jaC23jJytcwvy9vVi5p())
					{
						continue;
					}
					goto case 7;
				}
				goto IL_01df;
			case 7:
				if (cvsCellString != null)
				{
					num = 9;
					if (MrJsUsJTMDgOLLFmBll())
					{
						continue;
					}
					goto case 12;
				}
				goto IL_01f7;
			case 12:
				{
					if (!Quv3nkaIBO1jRl3dajE(CvsCellLocation.TryParse((string)RBl6xhaDdNdVgNB4KXu(text, CdQUGaROfy7He9T0foW.KbIzwHEDLa(1838))), CvsCellLocation.Invalid))
					{
						goto IL_01df;
					}
					obj = text;
					goto IL_01f5;
				}
				IL_01f7:
				return P_2;
				IL_01df:
				obj = RBl6xhaDdNdVgNB4KXu(text, P6fdtvJ1RkW0awGPacs(1044));
				goto IL_01f5;
				IL_01f5:
				P_2 = (string)obj;
				goto IL_01f7;
			}
			break;
		}
		goto IL_001a;
		IL_001a:
		text = cvsCellString.Expression.Substring(1);
		goto IL_0072;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetInputBaseName(this CvsCell cell, CvsInSight inSight)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)kAiVtLalukqZt6ABS3b(cell, inSight, XugL9sad245jaqfeoar());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetOutputBaseName(this CvsCell cell, CvsInSight inSight)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)kAiVtLalukqZt6ABS3b(cell, inSight, keeEP4agZjisvQv58XP());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsPublishable(this CvsCell cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (rieChGashGXgTyXallg(cell))
		{
			return false;
		}
		bool flag = gW4OMkavunVEo6PgkpG(cell);
		bool flag2 = C2OXIparxiN1KpuItph(cell) && !(Ykbuw7JYUpUQPmSXhtK(LXoV0oJMAWYMXRLKNMh(cell)) is CvsCogImage) && !(cell is CvsCellStatus) && !(cell is CvsCellStatusLight);
		bool flag3 = AHx4aaa5Vb6DIgGelby(RDfvNVaPFboaJn88Isu(Yx6Q5yJcIJ7s748RlH3(cell)), P6fdtvJ1RkW0awGPacs(1890));
		return flag | flag2 | flag3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsConstant(this CvsCell cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_006a;
		IL_001a:
		string text = (string)StpgJlaGmu0x88GF6hK(Yx6Q5yJcIJ7s748RlH3(cell), new char[1] { '\'' });
		num = 5;
		goto IL_006a;
		IL_006a:
		string text2 = default;
		while (true)
		{
			IL_006a_2:
			switch (num)
			{
			case 1:
			case 3:
				return false;
			case 0:
				while (rieChGashGXgTyXallg(cell))
				{
					_ = 1;
					if (jaC23jJytcwvy9vVi5p())
					{
						num = 4;
						if (1 == 0)
						{
							continue;
						}
					}
					else
					{
						num = 3;
					}
					goto IL_006a_2;
				}
				text2 = (string)p3R5FUabeFW8VkC29WD(kbPJZPaZY5hUOrKUAsv(), P6fdtvJ1RkW0awGPacs(1906), x3KnGIaBCIeXbf8f2aJ(cell));
				break;
			case 5:
				return oCPqYrao4eKTxZARJxe(text2, text);
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CanBeInputPin(this CvsCell cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		while (true)
		{
			IL_00d3:
			switch (num)
			{
			case 0:
				if (!HOAsxHaSWrYM0o2wAmc(cell))
				{
					num = 9;
					if (jaC23jJytcwvy9vVi5p())
					{
					}
					continue;
				}
				break;
			case 4:
			case 5:
				if (!(cell is CvsCellEditString))
				{
					num = 0;
					continue;
				}
				break;
			case 6:
				if (cell is CvsCellListBox)
				{
					break;
				}
				goto case 4;
			case 7:
				while (rieChGashGXgTyXallg(cell))
				{
					_ = 0;
					if (!MrJsUsJTMDgOLLFmBll())
					{
						num = 4;
						if (1 == 0)
						{
							continue;
						}
					}
					else
					{
						num = 2;
					}
					goto IL_00d3;
				}
				if (!(cell is CvsCellCheckBox))
				{
					num = 8;
					continue;
				}
				break;
			case 1:
			case 2:
				return false;
			case 8:
				if (!(cell is CvsCellEditInt))
				{
					num = 3;
					continue;
				}
				break;
			case 3:
				if (cell is CvsCellEditFloat)
				{
					break;
				}
				goto case 6;
			default:
				num = 6;
				continue;
			case 9:
				return cell.IsAcquireImage;
			}
			break;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CanBeOutputPin(this CvsCell cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 9;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_006d;
		IL_001a:
		if (!(Ykbuw7JYUpUQPmSXhtK(LXoV0oJMAWYMXRLKNMh(cell)) is CvsCogRegion))
		{
			num = 5;
			goto IL_006d;
		}
		goto IL_0309;
		IL_0309:
		return true;
		IL_006d:
		while (true)
		{
			switch (num)
			{
			case 14:
				break;
			case 4:
				return false;
			case 0:
				if (cell is CvsCellEditInt)
				{
					goto IL_00f9;
				}
				goto case 10;
			default:
				num = 10;
				continue;
			case 1:
				goto IL_00e4;
			case 13:
				goto IL_00f9;
			case 3:
				goto IL_0112;
			case 7:
			case 20:
				goto IL_0137;
			case 21:
			case 22:
				goto IL_0152;
			case 17:
				goto IL_0167;
			case 24:
				goto IL_0187;
			case 2:
				if (!HOAsxHaSWrYM0o2wAmc(cell))
				{
					num = 1;
					if (MrJsUsJTMDgOLLFmBll())
					{
						continue;
					}
					goto case 18;
				}
				goto case 12;
			case 18:
				if (!Hxs1rja8tfVkcOouiY1(IwjLc4akLk3hNTBXZY5(LXoV0oJMAWYMXRLKNMh(cell))))
				{
					num = 23;
					continue;
				}
				goto IL_024a;
			case 8:
				goto IL_01d6;
			case 6:
				goto IL_01f5;
			case 11:
				goto IL_0214;
			case 23:
				if (Ykbuw7JYUpUQPmSXhtK(LXoV0oJMAWYMXRLKNMh(cell)) is string)
				{
					return true;
				}
				goto IL_024a;
			case 15:
				goto IL_0297;
			case 19:
				goto IL_02b6;
			case 5:
				goto IL_02f4;
			case 12:
				return false;
			case 9:
				if (!rieChGashGXgTyXallg(cell))
				{
					num = 2;
					continue;
				}
				goto case 12;
			case 16:
				goto IL_0369;
			case 10:
				if (cell is CvsCellListBox)
				{
					goto IL_00f9;
				}
				num = 17;
				if (MrJsUsJTMDgOLLFmBll())
				{
					continue;
				}
				goto case 25;
			case 25:
				return cell is CvsCellColorLabel;
			}
			break;
			IL_0369:
			if (!(cell.CellResult.Value is CvsCogRegion))
			{
				num = 15;
				continue;
			}
			goto IL_02cb;
			IL_0187:
			if (!(cell is CvsCellMultiStatus))
			{
				num = 25;
				continue;
			}
			goto IL_03ad;
			IL_02f4:
			if (!(((CvsCogCellResult)LXoV0oJMAWYMXRLKNMh(cell)).Value is CvsCogAnnulus))
			{
				if (((CvsCogCellResult)LXoV0oJMAWYMXRLKNMh(cell)).Value is CvsCogShape)
				{
					return false;
				}
				_ = Ykbuw7JYUpUQPmSXhtK(cell.CellResult) is CvsCogError;
				num = 4;
				continue;
			}
			goto IL_0309;
			IL_03ad:
			return true;
			IL_0167:
			if (cell is CvsCellEditFloat)
			{
				goto IL_00f9;
			}
			if (!(cell is CvsCellEditString))
			{
				if (cell is CvsCellButton)
				{
					num = 16;
					if (true)
					{
						continue;
					}
					goto IL_0112;
				}
				if (!(cell is CvsCellFloat))
				{
					MrJsUsJTMDgOLLFmBll();
					num = ((!jaC23jJytcwvy9vVi5p()) ? 7 : 22);
					continue;
				}
				goto IL_03ad;
			}
			num = 13;
			continue;
			IL_02cb:
			return true;
			IL_02b6:
			if (!(Ykbuw7JYUpUQPmSXhtK(LXoV0oJMAWYMXRLKNMh(cell)) is CvsCogPoint))
			{
				return false;
			}
			goto IL_02cb;
			IL_0112:
			if (!(((CvsCogCellResult)LXoV0oJMAWYMXRLKNMh(cell)).Value is CvsCogLine))
			{
				num = 8;
				if (!jaC23jJytcwvy9vVi5p())
				{
					continue;
				}
				goto IL_0137;
			}
			goto IL_02cb;
			IL_0214:
			if (!(Ykbuw7JYUpUQPmSXhtK(LXoV0oJMAWYMXRLKNMh(cell)) is CvsCogCircle))
			{
				num = 6;
				continue;
			}
			goto IL_0309;
			IL_0137:
			if (!(cell is CvsCellStatus))
			{
				goto IL_0152;
			}
			goto IL_03ad;
			IL_01f5:
			if (!(Ykbuw7JYUpUQPmSXhtK(LXoV0oJMAWYMXRLKNMh(cell)) is CvsCogPoint))
			{
				num = 14;
				continue;
			}
			goto IL_0309;
			IL_0152:
			if (!(cell is CvsCellStatusLight))
			{
				num = 24;
				continue;
			}
			goto IL_03ad;
			IL_01d6:
			if (!(Ykbuw7JYUpUQPmSXhtK(LXoV0oJMAWYMXRLKNMh(cell)) is CvsCogCircle))
			{
				num = 19;
				continue;
			}
			goto IL_02cb;
			IL_00f9:
			return true;
			IL_024a:
			if (Ykbuw7JYUpUQPmSXhtK(LXoV0oJMAWYMXRLKNMh(cell)) is CvsCogImage)
			{
				return true;
			}
			if (!(Ykbuw7JYUpUQPmSXhtK(cell.CellResult) is CvsCogFixture) && !(Ykbuw7JYUpUQPmSXhtK(LXoV0oJMAWYMXRLKNMh(cell)) is CvsCogLine))
			{
				num = 11;
				if (true)
				{
					continue;
				}
				goto IL_0297;
			}
			goto IL_0309;
			IL_0297:
			if (!(((CvsCogCellResult)LXoV0oJMAWYMXRLKNMh(cell)).Value is CvsCogAnnulus))
			{
				num = 3;
				continue;
			}
			goto IL_02cb;
			IL_00e4:
			if (cBmksZJ0Fw4oevdk5g7(cell))
			{
				num = 12;
				continue;
			}
			if (!(cell is CvsCellString))
			{
				if (!(cell is CvsCellCheckBox))
				{
					num = 0;
					continue;
				}
				goto IL_00f9;
			}
			num = 18;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MrJsUsJTMDgOLLFmBll()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jaC23jJytcwvy9vVi5p()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cBmksZJ0Fw4oevdk5g7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).IsAcquireImage;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object D5tgpkJFb0gOL717Z3X()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Image;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LXoV0oJMAWYMXRLKNMh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).CellResult;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ykbuw7JYUpUQPmSXhtK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object E7qCL0JUdPFiYraDP0Y()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Region;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gncqxsJHLJp4t9TdHkd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Circle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tgrRBmJxet53HCWLxZR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.cvG0u3ZbyF();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hmyHQyJmA4VJJaCWhY4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Point;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qQafZJJQ3kD5QiZ5old()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.y6RJqWiBlx();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GO9gxQJNgfyT5hE2gme()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CAlJkfjsP1();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pbfNrpJ2g2mC0kCcxXU(object P_0, object P_1, StringComparison P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).StartsWith((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Yx6Q5yJcIJ7s748RlH3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object P6fdtvJ1RkW0awGPacs(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PiXCflJuDWR6DeecpDR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.W3G0TNIVJV();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object M25J8aJhBk5LF8IUfs1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.DyWJsddk3D();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SDmAhxJtbmYIPtiJQ7l()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.bQqBGbDSbL();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uOPEbrJzDguZ5j0wleG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.AGktfd70Qc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object u0Ub8gaLlr5VCy7Dirg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.MaursiNrNV();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VnVM4baKtyZS5u9ZWAG(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return nkoprNhvMV((CvsCell)P_0, (CvsInSight)P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AHx4aaa5Vb6DIgGelby(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).StartsWith((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static char zAqgYdaw53YwhdckfYX(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NKyCZDaJgbyQZ6NsR6p(char P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return char.IsUpper(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int fiqC03aaWibvWh1XgJD(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).IndexOf((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rakrTeaepPOuWIlnd8O(object P_0, int P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Substring(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation mmc9XnaO9I2eawCHQIb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.TryParse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Quv3nkaIBO1jRl3dajE(CvsCellLocation P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 == P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RBl6xhaDdNdVgNB4KXu(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation gDgJMXaiSAHmLDIHZqR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DsSrNjanMMVyf18XVb8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsResultSet)P_0).Cells;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HcB1RMaVxaShnXu25dY(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mDPKpXafbiPYWiY8QSw(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XugL9sad245jaqfeoar()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.lpdYbvNgHa();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kAiVtLalukqZt6ABS3b(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).GetBaseName((CvsInSight)P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object keeEP4agZjisvQv58XP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.fTILWgOS7S();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rieChGashGXgTyXallg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCell.IsNullOrEmpty((CvsCell)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gW4OMkavunVEo6PgkpG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).CanBeInputPin();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool C2OXIparxiN1KpuItph(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).CanBeOutputPin();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RDfvNVaPFboaJn88Isu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).ToLower();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kbPJZPaZY5hUOrKUAsv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.InvariantCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object x3KnGIaBCIeXbf8f2aJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).CellValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object p3R5FUabeFW8VkC29WD(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((IFormatProvider)P_0, (string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object StpgJlaGmu0x88GF6hK(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).TrimStart((char[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oCPqYrao4eKTxZARJxe(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool HOAsxHaSWrYM0o2wAmc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).IsInputImage;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IwjLc4akLk3hNTBXZY5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Hxs1rja8tfVkcOouiY1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}
}
