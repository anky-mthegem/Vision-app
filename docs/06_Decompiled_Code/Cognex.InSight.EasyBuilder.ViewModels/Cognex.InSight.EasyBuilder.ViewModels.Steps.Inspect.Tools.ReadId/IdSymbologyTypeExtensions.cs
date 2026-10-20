using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.ReadId;

public static class IdSymbologyTypeExtensions
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Is1D(this SymbologyType symbology)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if ((uint)(symbology - 1) <= 19u)
		{
			return true;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Is2D(this SymbologyType symbology)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if ((uint)(symbology - 21) <= 4u)
		{
			return true;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SymbologyType GetSymbologyTypeBasedOnSymbologyString(string symbology)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 12;
		uint num2 = default;
		while (true)
		{
			switch (num)
			{
			case 30:
				if (num2 != 1395218309)
				{
					if (num2 != 1419870067)
					{
						num = 9;
						continue;
					}
					if (!YQSp70o0gSu246ldu8K(symbology, sfhIvOoyuMSHcAGQEtE(12092)))
					{
						num = 16;
						if (0 == 0)
						{
							continue;
						}
						goto case 31;
					}
					return SymbologyType.Planet;
				}
				if (!YQSp70o0gSu246ldu8K(symbology, CdQUGaROfy7He9T0foW.KbIzwHEDLa(11924)))
				{
					break;
				}
				return SymbologyType.IntelligentMailBarcode;
			case 20:
				if (num2 <= 2900056652u)
				{
					if (num2 != 2626654459u)
					{
						num = 6;
						continue;
					}
					if (!YQSp70o0gSu246ldu8K(symbology, sfhIvOoyuMSHcAGQEtE(11816)))
					{
						num = 26;
						continue;
					}
					return SymbologyType.DataBarExpanded;
				}
				if (num2 == 2931952588u)
				{
					if (!YQSp70o0gSu246ldu8K(symbology, sfhIvOoyuMSHcAGQEtE(11976)))
					{
						num = 42;
						if (NWQvZWoRLTJI7nxlRRn())
						{
							continue;
						}
						goto case 39;
					}
					return SymbologyType.Interleaved2of5;
				}
				num = 10;
				if (NWQvZWoRLTJI7nxlRRn())
				{
					continue;
				}
				goto case 28;
			case 10:
				if (num2 != 2953583821u)
				{
					num = 19;
					if (YItXFXoW9c7H1Asy9fS())
					{
					}
					continue;
				}
				if (!YQSp70o0gSu246ldu8K(symbology, sfhIvOoyuMSHcAGQEtE(11706)))
				{
					break;
				}
				return SymbologyType.CodaBar;
			case 6:
				if (num2 != 2659607307u)
				{
					num = 35;
					continue;
				}
				if (!YQSp70o0gSu246ldu8K(symbology, sfhIvOoyuMSHcAGQEtE(12154)))
				{
					num = 14;
					if (true)
					{
						continue;
					}
					goto case 18;
				}
				return SymbologyType.AztecCode;
			case 3:
				if (num2 != 4225993531u)
				{
					num = 22;
					continue;
				}
				if (!YQSp70o0gSu246ldu8K(symbology, sfhIvOoyuMSHcAGQEtE(11886)))
				{
					num = 24;
					continue;
				}
				return SymbologyType.EanUccComposite;
			case 31:
				if (num2 <= 2528705949u)
				{
					num = 17;
					continue;
				}
				if (num2 <= 3034130509u)
				{
					num = 20;
					continue;
				}
				if (num2 > 3378964645u)
				{
					if (num2 <= 3864523194u)
					{
						num = 8;
					}
					else if (num2 == 3907985465u)
					{
						if (YQSp70o0gSu246ldu8K(symbology, sfhIvOoyuMSHcAGQEtE(12068)))
						{
							return SymbologyType.Pharmacode;
						}
						num = 27;
					}
					else
					{
						num = 3;
					}
					continue;
				}
				if (num2 == 3037228002u)
				{
					if (!(symbology == (string)sfhIvOoyuMSHcAGQEtE(12178)))
					{
						break;
					}
					return SymbologyType.DataMatrix;
				}
				num = 2;
				continue;
			case 39:
				if (num2 == 977278371)
				{
					if (!YQSp70o0gSu246ldu8K(symbology, sfhIvOoyuMSHcAGQEtE(12242)))
					{
						num = 44;
						if (true)
						{
							continue;
						}
						break;
					}
					return SymbologyType.QrCode;
				}
				num = 13;
				continue;
			case 2:
				switch (num2)
				{
				case 3378964645u:
					if (!YQSp70o0gSu246ldu8K(symbology, sfhIvOoyuMSHcAGQEtE(12222)))
					{
						break;
					}
					return SymbologyType.MaxiCode;
				case 3127202479u:
					if (!YQSp70o0gSu246ldu8K(symbology, sfhIvOoyuMSHcAGQEtE(12144)))
					{
						num = 1;
						continue;
					}
					return SymbologyType.Upu;
				}
				break;
			case 35:
				if (num2 == 2900056652u)
				{
					if (!YQSp70o0gSu246ldu8K(symbology, sfhIvOoyuMSHcAGQEtE(11762)))
					{
						num = 11;
						continue;
					}
					return SymbologyType.Code39;
				}
				break;
			case 28:
				if (num2 == 117528581)
				{
					if (!YQSp70o0gSu246ldu8K(symbology, CdQUGaROfy7He9T0foW.KbIzwHEDLa(12050)))
					{
						num = 38;
						if (0 == 0)
						{
							continue;
						}
						break;
					}
					return SymbologyType.Pdf417;
				}
				_ = 1;
				if (!YItXFXoW9c7H1Asy9fS())
				{
					num = 33;
					if (0 == 0)
					{
						continue;
					}
					break;
				}
				num = 29;
				continue;
			case 40:
				if (num2 != 1043421701)
				{
					num = 30;
					if (NWQvZWoRLTJI7nxlRRn())
					{
						continue;
					}
					goto case 15;
				}
				if (!YQSp70o0gSu246ldu8K(symbology, sfhIvOoyuMSHcAGQEtE(11724)))
				{
					break;
				}
				return SymbologyType.Code128;
			case 15:
				if (num2 != 2528705949u || !YQSp70o0gSu246ldu8K(symbology, sfhIvOoyuMSHcAGQEtE(11674)))
				{
					break;
				}
				return SymbologyType.AustraliaPost;
			case 18:
				if (num2 == 2357057690u)
				{
					if (!YQSp70o0gSu246ldu8K(symbology, sfhIvOoyuMSHcAGQEtE(12108)))
					{
						break;
					}
					return SymbologyType.PostNet;
				}
				num = 15;
				if (true)
				{
					continue;
				}
				break;
			case 4:
			case 33:
				if (num2 == 183599411)
				{
					if (!YQSp70o0gSu246ldu8K(symbology, sfhIvOoyuMSHcAGQEtE(12016)))
					{
						break;
					}
					return SymbologyType.JapanPost;
				}
				num = 36;
				if (YItXFXoW9c7H1Asy9fS())
				{
				}
				continue;
			case 19:
				if (num2 == 3034130509u)
				{
					if (!YQSp70o0gSu246ldu8K(symbology, sfhIvOoyuMSHcAGQEtE(11744)))
					{
						num = 43;
						continue;
					}
					return SymbologyType.Code25;
				}
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 37:
				if (num2 != 3864523194u)
				{
					break;
				}
				if (!YQSp70o0gSu246ldu8K(symbology, sfhIvOoyuMSHcAGQEtE(11798)))
				{
					num = 23;
					if (0 == 0)
					{
						continue;
					}
					goto case 36;
				}
				return SymbologyType.DataBar;
			default:
				num = 7;
				continue;
			case 8:
				if (num2 == 3691184580u)
				{
					if (YQSp70o0gSu246ldu8K(symbology, sfhIvOoyuMSHcAGQEtE(11852)))
					{
						return SymbologyType.DataBarLimited;
					}
					num = 41;
				}
				else
				{
					num = 37;
				}
				continue;
			case 36:
				if (num2 == 657920392)
				{
					if (!(symbology == (string)sfhIvOoyuMSHcAGQEtE(12040)))
					{
						num = 21;
						continue;
					}
					return SymbologyType.Msi;
				}
				break;
			case 12:
				num2 = XrIYdSoTXHlxSC0pKem(symbology);
				num = 31;
				continue;
			case 17:
				if (num2 > 977278371)
				{
					if (num2 <= 1419870067)
					{
						num = 40;
						continue;
					}
					if (num2 == 1691929190)
					{
						if (!YQSp70o0gSu246ldu8K(symbology, sfhIvOoyuMSHcAGQEtE(12126)))
						{
							num = 0;
							continue;
						}
						return SymbologyType.UpcEan;
					}
					num = 18;
					if (0 == 0)
					{
						continue;
					}
					break;
				}
				if (num2 > 657920392)
				{
					switch (num2)
					{
					case 918723492u:
						if (!YQSp70o0gSu246ldu8K(symbology, CdQUGaROfy7He9T0foW.KbIzwHEDLa(11780)))
						{
							num = 32;
							break;
						}
						return SymbologyType.Code93;
					case 810194741u:
						if (!YQSp70o0gSu246ldu8K(symbology, CdQUGaROfy7He9T0foW.KbIzwHEDLa(12204)))
						{
							num = 34;
							break;
						}
						return SymbologyType.DotCode;
					default:
						num = 39;
						break;
					}
				}
				else
				{
					num = 28;
				}
				continue;
			case 0:
			case 1:
			case 5:
			case 7:
			case 9:
			case 11:
			case 13:
			case 14:
			case 16:
			case 21:
			case 22:
			case 23:
			case 24:
			case 25:
			case 26:
			case 27:
			case 29:
			case 32:
			case 34:
			case 38:
			case 41:
			case 42:
			case 43:
			case 44:
				break;
			}
			break;
		}
		return SymbologyType.None;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static (string name, string imagePath) GetResources(this SymbologyType symbology)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return symbology switch
		{
			SymbologyType.AustraliaPost => (name: Resources.fP0BcmW3Qp(), imagePath: CdQUGaROfy7He9T0foW.KbIzwHEDLa(12260)), 
			SymbologyType.CodaBar => (name: Resources.SkxZus14wb(), imagePath: CdQUGaROfy7He9T0foW.KbIzwHEDLa(12484)), 
			SymbologyType.Code128 => (name: Resources.HEEZX8qsYj(), imagePath: CdQUGaROfy7He9T0foW.KbIzwHEDLa(12696)), 
			SymbologyType.Code25 => (name: Resources.A6bZSj2ita(), imagePath: CdQUGaROfy7He9T0foW.KbIzwHEDLa(12908)), 
			SymbologyType.Code39 => (name: Resources.VScZ3GQVva(), imagePath: CdQUGaROfy7He9T0foW.KbIzwHEDLa(13118)), 
			SymbologyType.Code93 => (name: Resources.D9hZfjNAdl(), imagePath: CdQUGaROfy7He9T0foW.KbIzwHEDLa(13328)), 
			SymbologyType.DataBar => (name: Resources.DataBar, imagePath: CdQUGaROfy7He9T0foW.KbIzwHEDLa(13538)), 
			SymbologyType.DataBarExpanded => (name: Resources.PhDZzabjrr(), imagePath: CdQUGaROfy7He9T0foW.KbIzwHEDLa(13750)), 
			SymbologyType.DataBarLimited => (name: Resources.RD3n5s3h3j(), imagePath: CdQUGaROfy7He9T0foW.KbIzwHEDLa(13978)), 
			SymbologyType.EanUccComposite => (name: Resources.FkPnIqVcwa(), imagePath: CdQUGaROfy7He9T0foW.KbIzwHEDLa(14204)), 
			SymbologyType.IntelligentMailBarcode => (name: Resources.lajYVBthZL(), imagePath: CdQUGaROfy7He9T0foW.KbIzwHEDLa(14436)), 
			SymbologyType.Interleaved2of5 => (name: Resources.MZOYJ0DNF1(), imagePath: CdQUGaROfy7He9T0foW.KbIzwHEDLa(14678)), 
			SymbologyType.JapanPost => (name: Resources.EuT0ajf7xi(), imagePath: CdQUGaROfy7He9T0foW.KbIzwHEDLa(14906)), 
			SymbologyType.Msi => (name: Resources.mALVzyfFfk(), imagePath: CdQUGaROfy7He9T0foW.KbIzwHEDLa(15122)), 
			SymbologyType.Pdf417 => (name: Resources.HIhJEUPkWZ(), imagePath: CdQUGaROfy7He9T0foW.KbIzwHEDLa(15326)), 
			SymbologyType.Pharmacode => (name: Resources.Pharmacode, imagePath: CdQUGaROfy7He9T0foW.KbIzwHEDLa(15536)), 
			SymbologyType.Planet => (name: Resources.wotJwJ51fj(), imagePath: CdQUGaROfy7He9T0foW.KbIzwHEDLa(15754)), 
			SymbologyType.PostNet => (name: Resources.etrJZqK8SX(), imagePath: CdQUGaROfy7He9T0foW.KbIzwHEDLa(15964)), 
			SymbologyType.UpcEan => (name: Resources.ITphKlS1mQ(), imagePath: CdQUGaROfy7He9T0foW.KbIzwHEDLa(16176)), 
			SymbologyType.Upu => (name: Resources.OaIhVJcSn3(), imagePath: CdQUGaROfy7He9T0foW.KbIzwHEDLa(16386)), 
			SymbologyType.AztecCode => (name: Resources.cRCBCg9Cye(), imagePath: CdQUGaROfy7He9T0foW.KbIzwHEDLa(16590)), 
			SymbologyType.DataMatrix => (name: Resources.WwanUjwSf4(), imagePath: CdQUGaROfy7He9T0foW.KbIzwHEDLa(16806)), 
			SymbologyType.DotCode => (name: Resources.DotCode, imagePath: CdQUGaROfy7He9T0foW.KbIzwHEDLa(17024)), 
			SymbologyType.MaxiCode => (name: Resources.MaxiCode, imagePath: CdQUGaROfy7He9T0foW.KbIzwHEDLa(17236)), 
			SymbologyType.QrCode => (name: Resources.rYP9UVpBL7(), imagePath: CdQUGaROfy7He9T0foW.KbIzwHEDLa(17450)), 
			_ => throw new InvalidEnumArgumentException(Enum.GetName(typeof(SymbologyType), symbology) + CdQUGaROfy7He9T0foW.KbIzwHEDLa(17660), (int)symbology, typeof(SymbologyType)), 
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NWQvZWoRLTJI7nxlRRn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YItXFXoW9c7H1Asy9fS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint XrIYdSoTXHlxSC0pKem(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return _003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sfhIvOoyuMSHcAGQEtE(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YQSp70o0gSu246ldu8K(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}
}
