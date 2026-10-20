using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cognex.InSight.Graphic;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

public sealed class CvsTrainExtractColorEditor : CvsColorToolEditorBase
{
	public enum CvsColorModelOperation
	{
		Additive,
		Subtractive
	}

	public enum CvsColorTrainingMode
	{
		SingleColor,
		MultiColor
	}

	public enum CvsColorTrainingResult
	{
		Commit,
		Discard
	}

	public enum CvsColorTrainingRegionType
	{
		Region,
		Point,
		Polygon,
		Circle,
		Annulus
	}

	public class CvsColorModel
	{
		private string ARB7AcIoGf;

		private byte oma7tuyxWq;

		private byte Q2x7WFpggT;

		private byte xiE73uVshn;

		private float MjH7LtviF8;

		private float OU77kUZ2XT;

		private float Si67Xi7fSC;

		private float Uui7fQDJxd;

		private CvsColorModelOperation IMK7jix0Pl;

		private bool qO97co8p4E;

		private bool gej75r02kN;

		private bool I4o7Y0rIjS;

		private readonly int fgZ77mBj9K;

		private readonly int WRm7mK9YOg;

		private readonly CvsTrainExtractColorEditor Mb87nEtpir;

		private CvsColorModelSamples tXE797N3FS;

		public int Id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return fgZ77mBj9K;
			}
		}

		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				vHr7MyYQ3h();
				return ARB7AcIoGf;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				int num = 1;
				if (!oHc4b0sxgoDiwyobK1of())
				{
					goto IL_001e;
				}
				goto IL_0084;
				IL_001e:
				ARB7AcIoGf = value;
				num = 6;
				if (A7CtpAsxZWlUG6FxhUXF())
				{
					return;
				}
				goto IL_0084;
				IL_0084:
				while (true)
				{
					switch (num)
					{
					case 4:
						return;
					case 0:
					case 2:
						return;
					case 1:
						while (true)
						{
							if (!IiADqhsxz2Fm4E4WvuGX(ARB7AcIoGf, value))
							{
								if (Mb87nEtpir == null)
								{
									_ = 1;
									if (!A7CtpAsxZWlUG6FxhUXF())
									{
										num = 0;
										if (0 == 0)
										{
											break;
										}
										return;
									}
									num = 5;
									if (true)
									{
										break;
									}
									continue;
								}
								goto IL_005a;
							}
							num = 4;
							break;
						}
						continue;
					case 6:
						return;
						IL_005a:
						YnyUxhs1w21EiUg3BTnJ(Mb87nEtpir, WRm7mK9YOg, Id, value);
						break;
					}
					break;
				}
				goto IL_001e;
			}
		}

		public float Sigma
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				vHr7MyYQ3h();
				return MjH7LtviF8;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				if (value != MjH7LtviF8)
				{
					bCQ7ov0y5t(value, EnableHighlight, Highlight, EnableMatteLine, LowerMatteLineLimit, UpperMatteLineLimit, Operation);
				}
			}
		}

		public float Highlight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				vHr7MyYQ3h();
				return OU77kUZ2XT;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				if (value != OU77kUZ2XT)
				{
					bCQ7ov0y5t(Sigma, EnableHighlight, value, EnableMatteLine, LowerMatteLineLimit, UpperMatteLineLimit, Operation);
				}
			}
		}

		public bool EnableHighlight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				vHr7MyYQ3h();
				return qO97co8p4E;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				if (value != qO97co8p4E)
				{
					bCQ7ov0y5t(Sigma, value, Highlight, EnableMatteLine, LowerMatteLineLimit, UpperMatteLineLimit, Operation);
				}
			}
		}

		public float UpperMatteLineLimit
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				vHr7MyYQ3h();
				return Uui7fQDJxd;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				if (value != Uui7fQDJxd)
				{
					bCQ7ov0y5t(Sigma, EnableHighlight, Highlight, EnableMatteLine, LowerMatteLineLimit, value, Operation);
				}
			}
		}

		public float LowerMatteLineLimit
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				vHr7MyYQ3h();
				return Si67Xi7fSC;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				if (value != Si67Xi7fSC)
				{
					bCQ7ov0y5t(Sigma, EnableHighlight, Highlight, EnableMatteLine, value, UpperMatteLineLimit, Operation);
				}
			}
		}

		public bool EnableMatteLine
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				vHr7MyYQ3h();
				return gej75r02kN;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				if (value != gej75r02kN)
				{
					bCQ7ov0y5t(Sigma, EnableHighlight, Highlight, value, LowerMatteLineLimit, UpperMatteLineLimit, Operation);
				}
			}
		}

		public CvsColorModelOperation Operation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				vHr7MyYQ3h();
				return IMK7jix0Pl;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				if (value != IMK7jix0Pl)
				{
					bCQ7ov0y5t(Sigma, EnableHighlight, Highlight, EnableMatteLine, LowerMatteLineLimit, UpperMatteLineLimit, value);
				}
			}
		}

		public byte PeakRed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				vHr7MyYQ3h();
				return oma7tuyxWq;
			}
		}

		public byte PeakGreen
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				vHr7MyYQ3h();
				return xiE73uVshn;
			}
		}

		public byte PeakBlue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				vHr7MyYQ3h();
				return Q2x7WFpggT;
			}
		}

		public bool IsCommitted
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				vHr7MyYQ3h();
				return I4o7Y0rIjS;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal CvsColorModel(CvsTrainExtractColorEditor trainer, int groupId, int modelId)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oHc4b0sxgoDiwyobK1of();
			int num;
			if (!A7CtpAsxZWlUG6FxhUXF())
			{
				num = 7;
			}
			else
			{
				num = 9;
				if (1 == 0)
				{
					goto IL_008b;
				}
			}
			goto IL_00c5;
			IL_00c5:
			while (true)
			{
				switch (num)
				{
				case 6:
					ARB7AcIoGf = null;
					num = 10;
					if (!A7CtpAsxZWlUG6FxhUXF())
					{
						continue;
					}
					goto case 1;
				case 1:
				case 9:
					fgZ77mBj9K = -1;
					num = 3;
					continue;
				case 2:
					WRm7mK9YOg = groupId;
					num = 8;
					continue;
				case 3:
					WRm7mK9YOg = -1;
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 7:
					Pa2Y33sxJp61H3cqUWgg();
					goto case 1;
				case 8:
					break;
				case 4:
					tnKDYDsx85Lkg3UU5SML(this);
					num = 5;
					continue;
				case 5:
					Mb87nEtpir = trainer;
					goto case 2;
				default:
					num = 2;
					if (A7CtpAsxZWlUG6FxhUXF())
					{
					}
					continue;
				case 10:
					return;
				}
				break;
			}
			goto IL_008b;
			IL_008b:
			fgZ77mBj9K = modelId;
			num = 6;
			goto IL_00c5;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlightOptions(bool enable, float limit)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bCQ7ov0y5t(Sigma, enable, limit, EnableMatteLine, LowerMatteLineLimit, UpperMatteLineLimit, Operation);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetMatteOptions(bool enable, float lowerLimit, float upperLimit)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bCQ7ov0y5t(Sigma, EnableHighlight, Highlight, enable, lowerLimit, upperLimit, Operation);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CvsColorModelSamples CreateColorSamples(int sampleSize)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			tXE797N3FS = new CvsColorModelSamples();
			CvsColorModelSamples result = tXE797N3FS;
			MN73WPs1sccG6CZv7H80(Mb87nEtpir, WRm7mK9YOg, Id, sampleSize);
			tXE797N3FS = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InvalidateModelData()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ARB7AcIoGf = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void vHr7MyYQ3h()
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
					fsQ2xss1hReGu7TJATIM(Mb87nEtpir, WRm7mK9YOg, Id);
					num = 5;
					if (!A7CtpAsxZWlUG6FxhUXF())
					{
						break;
					}
					goto case 1;
				case 1:
				case 3:
					if (Mb87nEtpir != null)
					{
						goto default;
					}
					return;
				case 4:
					if (ARB7AcIoGf == null)
					{
						oHc4b0sxgoDiwyobK1of();
						num = ((!A7CtpAsxZWlUG6FxhUXF()) ? 3 : 0);
						break;
					}
					return;
				case 5:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bCQ7ov0y5t(float P_0, bool P_1, float P_2, bool P_3, float P_4, float P_5, CvsColorModelOperation P_6)
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
				case 4:
					IMK7jix0Pl = P_6;
					num = 7;
					break;
				case 7:
					gej75r02kN = P_3;
					goto case 8;
				case 2:
					MjH7LtviF8 = P_0;
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 6;
				case 6:
					Uui7fQDJxd = P_5;
					num = 4;
					break;
				case 8:
				case 9:
					qO97co8p4E = P_1;
					num = 11;
					break;
				case 5:
					OU77kUZ2XT = P_2;
					num = 10;
					if (true)
					{
						break;
					}
					goto case 10;
				case 10:
					Si67Xi7fSC = P_4;
					goto case 6;
				default:
					num = 6;
					if (oHc4b0sxgoDiwyobK1of())
					{
						break;
					}
					goto case 3;
				case 3:
					if (Mb87nEtpir != null)
					{
						_ = 1;
						num = (A7CtpAsxZWlUG6FxhUXF() ? 9 : 0);
						break;
					}
					goto case 2;
				case 0:
				case 1:
					Mb87nEtpir.javA9IAP6c(WRm7mK9YOg, Id, P_0, P_1, P_2, P_3, P_4, P_5, P_6);
					num = 2;
					break;
				case 11:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Pa2Y33sxJp61H3cqUWgg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void tnKDYDsx85Lkg3UU5SML(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oHc4b0sxgoDiwyobK1of()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A7CtpAsxZWlUG6FxhUXF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IiADqhsxz2Fm4E4WvuGX(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void YnyUxhs1w21EiUg3BTnJ(object P_0, int P_1, int P_2, object P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsTrainExtractColorEditor)P_0).RDEAmNajiW(P_1, P_2, (string)P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MN73WPs1sccG6CZv7H80(object P_0, int P_1, int P_2, int P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsTrainExtractColorEditor)P_0).gQHAnTFKi7(P_1, P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fsQ2xss1hReGu7TJATIM(object P_0, int P_1, int P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsTrainExtractColorEditor)P_0).y9xA5fTjwr(P_1, P_2);
		}
	}

	public class CvsColorGroup
	{
		private readonly int fyN7wBuv8F;

		private string Rkl7Rr4HKk;

		private CvsColorModel[] VdC7s7hCEr;

		private readonly CvsTrainExtractColorEditor yMc76uBvBU;

		public int Id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return fyN7wBuv8F;
			}
		}

		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				Y2B70dN4tf();
				return Rkl7Rr4HKk;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				AdHCxOs1Lj76EBTpdDoY();
				int num = ((!FNr414s19HicLur2f6jP()) ? 1 : 5);
				while (true)
				{
					switch (num)
					{
					default:
						Rkl7Rr4HKk = value;
						num = 6;
						break;
					case 2:
						throw new ArgumentException();
					case 4:
						return;
					case 0:
					case 1:
						while (true)
						{
							if (!(Rkl7Rr4HKk == value))
							{
								if (yMc76uBvBU.dKyAAK5Rco(value) != null)
								{
									num = 2;
									if (0 == 0)
									{
										break;
									}
									continue;
								}
								goto IL_003f;
							}
							num = 4;
							break;
						}
						break;
					case 6:
						return;
						IL_003f:
						P4qKfys1StseM7Zd4ljj(yMc76uBvBU, Id, value);
						goto default;
					}
				}
			}
		}

		public CvsColorModel[] Models
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				Y2B70dN4tf();
				return VdC7s7hCEr;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeleteModel(int modelID)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			yMc76uBvBU.mKNA7pCOAY(Id, modelID);
			InvalidateGroupData();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReorderModelList(int[] modelIds)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			K8XFfws1E2jfQaYAWgSJ(yMc76uBvBU, Id, modelIds);
			InvalidateGroupData();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private CvsColorModel mKZ7UT1bEe(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_0038;
			IL_0061:
			_ = 1;
			if (!FNr414s19HicLur2f6jP())
			{
				num = 1;
			}
			else
			{
				num = 7;
				if (!AdHCxOs1Lj76EBTpdDoY())
				{
					goto IL_009f;
				}
			}
			goto IL_0038;
			IL_00b0:
			int num2 = default;
			CvsColorModel[] vdC7s7hCEr = default;
			CvsColorModel cvsColorModel = default;
			if (num2 >= vdC7s7hCEr.Length)
			{
				num = 8;
			}
			else
			{
				cvsColorModel = vdC7s7hCEr[num2];
				num = 0;
			}
			goto IL_0038;
			IL_0038:
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				default:
					goto IL_0061;
				case 2:
					num2 = 0;
					num = 6;
					continue;
				case 1:
				case 4:
					return cvsColorModel;
				case 3:
					goto IL_009f;
				case 5:
				case 6:
				case 7:
					goto IL_00b0;
				case 8:
					return null;
				}
				break;
			}
			goto IL_001a;
			IL_001a:
			if (hgF7Yws1vrPnqm6DRA3k(cvsColorModel) == P_0)
			{
				goto IL_0061;
			}
			num2++;
			goto IL_00b0;
			IL_009f:
			vdC7s7hCEr = VdC7s7hCEr;
			num = 2;
			goto IL_0038;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal CvsColorGroup(CvsTrainExtractColorEditor trainer, int id)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			AdHCxOs1Lj76EBTpdDoY();
			int num;
			if (!FNr414s19HicLur2f6jP())
			{
				num = 6;
				if (1 == 0)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_0042;
			IL_008c:
			fyN7wBuv8F = id;
			num = 7;
			if (FNr414s19HicLur2f6jP())
			{
			}
			goto IL_0042;
			IL_0042:
			while (true)
			{
				switch (num)
				{
				case 3:
				case 5:
					break;
				default:
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					goto case 4;
				case 4:
					fyN7wBuv8F = -1;
					num = 8;
					continue;
				case 1:
					goto IL_008c;
				case 0:
				case 6:
					BIAi5Xs1HUfEj6VMTEXy();
					num = 4;
					continue;
				case 7:
					yMc76uBvBU = trainer;
					num = 2;
					if (!FNr414s19HicLur2f6jP())
					{
						continue;
					}
					goto case 2;
				case 2:
					Rkl7Rr4HKk = null;
					num = 9;
					continue;
				case 8:
					VdC7s7hCEr = new CvsColorModel[0];
					break;
				case 9:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			T94nlys1Vdueawigysmp(this);
			goto IL_008c;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InvalidateGroupData()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Rkl7Rr4HKk = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Y2B70dN4tf()
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
				case 3:
					if (Rkl7Rr4HKk == null)
					{
						_ = 1;
						num = (FNr414s19HicLur2f6jP() ? 4 : 0);
						break;
					}
					return;
				default:
					LMpjfqs1A20w2A8e3viL(yMc76uBvBU, Id);
					num = 5;
					break;
				case 0:
				case 1:
					if (yMc76uBvBU != null)
					{
						goto default;
					}
					return;
				case 5:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AdHCxOs1Lj76EBTpdDoY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FNr414s19HicLur2f6jP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void P4qKfys1StseM7Zd4ljj(object P_0, int P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsTrainExtractColorEditor)P_0).XySAcIq5t1(P_1, (string)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void K8XFfws1E2jfQaYAWgSJ(object P_0, int P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsTrainExtractColorEditor)P_0).geAAYxcH78(P_1, (int[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int hgF7Yws1vrPnqm6DRA3k(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsColorModel)P_0).Id;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BIAi5Xs1HUfEj6VMTEXy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void T94nlys1Vdueawigysmp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LMpjfqs1A20w2A8e3viL(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsTrainExtractColorEditor)P_0).QxEAXyEvoV(P_1);
		}
	}

	public class CvsColorTrainingSession
	{
		private readonly int X347HxCiHm;

		private CvsColorTrainingMode V1e7KIKPSa;

		private CvsColorModelOperation PRJ7E8rw7D;

		private CvsGraphic IQj7Q0tYTp;

		private readonly CvsTrainExtractColorEditor BcM7N224K6;

		private float yjP7iIm3C0;

		private float cxn7d3lHZH;

		public CvsColorTrainingMode TrainingMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return V1e7KIKPSa;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				V1e7KIKPSa = value;
			}
		}

		public CvsColorModelOperation Operation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return PRJ7E8rw7D;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				PRJ7E8rw7D = value;
			}
		}

		public float MulticolorThreshold
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return yjP7iIm3C0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				yjP7iIm3C0 = value;
			}
		}

		public float MulticolorSmoothing
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return cxn7d3lHZH;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				cxn7d3lHZH = value;
			}
		}

		public int GroupID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return X347HxCiHm;
			}
		}

		public CvsGraphic TrainingRegion
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return IQj7Q0tYTp;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				int num = 7;
				while (true)
				{
					switch (num)
					{
					case 0:
						IQj7Q0tYTp = value;
						num = 10;
						if (!hLGiIHs1DQYPXtIDKBBN())
						{
							return;
						}
						break;
					case 8:
						return;
					case 1:
						return;
					case 4:
						return;
					default:
						num = 9;
						break;
					case 2:
					case 5:
						return;
					case 3:
						IQj7Q0tYTp = value;
						_ = 1;
						if (!rLXTArs1U9vN3Xuq5PGl())
						{
							num = 5;
							if (true)
							{
								break;
							}
							goto case 9;
						}
						num = 1;
						break;
					case 9:
						IQj7Q0tYTp = value;
						num = 8;
						break;
					case 7:
						if (!(value is CvsGraphicPolygon))
						{
							if (!(value is CvsGraphicCircle))
							{
								if (!(value is CvsGraphicAnnulus))
								{
									if (value is CvsGraphicRegion)
									{
										num = 0;
										break;
									}
									throw new ArgumentException();
								}
								goto case 9;
							}
							num = 6;
							break;
						}
						num = 3;
						if (true)
						{
							break;
						}
						goto case 6;
					case 6:
						IQj7Q0tYTp = value;
						return;
					case 10:
						return;
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CvsColorTrainingSession(int groupID, CvsTrainExtractColorEditor editor)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0086;
			IL_001a:
			BcM7N224K6 = editor;
			num = 7;
			goto IL_0086;
			IL_0086:
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 1:
				case 5:
					X347HxCiHm = -1;
					num = 2;
					if (hLGiIHs1DQYPXtIDKBBN())
					{
						continue;
					}
					goto default;
				default:
					X347HxCiHm = groupID;
					num = 4;
					continue;
				case 6:
					VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
					_ = 0;
					if (hLGiIHs1DQYPXtIDKBBN())
					{
						num = 5;
						continue;
					}
					num = 0;
					if (false)
					{
						return;
					}
					continue;
				case 2:
					j47IiCs1TEg721PllsS5(this);
					goto default;
				case 7:
					return;
				}
				break;
			}
			goto IL_001a;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Train()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (IQj7Q0tYTp == null)
			{
				throw new InvalidOperationException();
			}
			BcM7N224K6.tBUAwv2WyG(GroupID, TrainingMode, Operation, MulticolorSmoothing, MulticolorThreshold, TrainingRegion);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void j47IiCs1TEg721PllsS5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hLGiIHs1DQYPXtIDKBBN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rLXTArs1U9vN3Xuq5PGl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private class HodJSu494r5lqUuLrc : CvsColorToolCustomProtocolCommand
	{
		public override CustomProtocolRequest RequestID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CustomProtocolRequest.ExtractorGetGroupList;
			}
		}

		public override int RequestDataLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return 0;
			}
		}

		public override bool WaitForColorDataMsg
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HodJSu494r5lqUuLrc()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			AsbC3Ts1qEqudnhU3rMy();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void AsbC3Ts1qEqudnhU3rMy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Wy5tSZs1dlkprEZeDOuD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool E8mAJgs1iZvpNwt1if4b()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private class MZKrVFV3tcMfujwHfo : CvsColorToolCustomProtocolCommand
	{
		private readonly int vCu7uVHStm;

		public override CustomProtocolRequest RequestID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CustomProtocolRequest.ExtractorGetGroupData;
			}
		}

		public override int RequestDataLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return 4;
			}
		}

		public override bool WaitForColorDataMsg
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MZKrVFV3tcMfujwHfo(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			TxUyXOs1B1Lnc8fSVqYd();
			int num;
			if (!wVZf4fs1jdtNga1T3KcB())
			{
				num = 2;
			}
			else
			{
				num = 4;
				if (wVZf4fs1jdtNga1T3KcB())
				{
				}
			}
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					vCu7uVHStm = -1;
					num = 3;
					if (!wVZf4fs1jdtNga1T3KcB())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 2:
					Dc0xfHs1cuIfQqFLqelP();
					goto case 1;
				case 3:
					base._002Ector();
					break;
				default:
					num = 5;
					continue;
				case 5:
					break;
				case 6:
					return;
				}
				vCu7uVHStm = P_0;
				num = 6;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Dc0xfHs1cuIfQqFLqelP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TxUyXOs1B1Lnc8fSVqYd()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wVZf4fs1jdtNga1T3KcB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private class Cb5tqm1nNAR3j0OrSg : CvsColorToolCustomProtocolCommand
	{
		private readonly int ki97GDOGco;

		private readonly int XVv7Dl0FrP;

		public override CustomProtocolRequest RequestID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CustomProtocolRequest.ExtractorGetModelData;
			}
		}

		public override int RequestDataLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return 8;
			}
		}

		public override bool WaitForColorDataMsg
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Cb5tqm1nNAR3j0OrSg(int P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (mTQo8Ks12mUimdrkFOMT())
			{
				num = 2;
				if (!mTQo8Ks12mUimdrkFOMT())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 1;
				if (1 == 0)
				{
					goto IL_00c7;
				}
			}
			goto IL_008c;
			IL_003b:
			XVv7Dl0FrP = P_1;
			num = 8;
			goto IL_008c;
			IL_00c7:
			ki97GDOGco = P_0;
			num = 5;
			goto IL_008c;
			IL_002a:
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
			num = 3;
			if (1 == 0)
			{
				goto IL_003b;
			}
			goto IL_008c;
			IL_008c:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					break;
				case 5:
					goto IL_003b;
				case 6:
					XVv7Dl0FrP = -1;
					num = 7;
					continue;
				case 3:
					ki97GDOGco = -1;
					num = 6;
					if (mTQo8Ks12mUimdrkFOMT())
					{
						continue;
					}
					goto case 7;
				case 7:
					base._002Ector();
					goto IL_00c7;
				default:
					goto IL_00c7;
				case 8:
					return;
				}
				break;
			}
			goto IL_002a;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mTQo8Ks12mUimdrkFOMT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wKJhTxs1WpGfXXvBvkdV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private class IEvK5bsf2nhpBgVWQh : CvsColorToolCustomProtocolCommand
	{
		private readonly int MNd7eaBGmq;

		private readonly int[] DBh7SXT6NO;

		public override CustomProtocolRequest RequestID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CustomProtocolRequest.ExtractorSortModelList;
			}
		}

		public override int RequestDataLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				int num = ((DBh7SXT6NO != null) ? DBh7SXT6NO.Length : 0);
				return 8 + num * 4;
			}
		}

		public override bool WaitForColorDataMsg
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEvK5bsf2nhpBgVWQh(int P_0, int[] P_1)
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
			goto IL_0079;
			IL_001a:
			CCHFrLs1Ces3RaB8Cdav();
			_ = 1;
			num = ((!JfGq29s1tCTM1nEkBqVA()) ? 2 : 0);
			goto IL_0079;
			IL_0079:
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				default:
					MNd7eaBGmq = P_0;
					num = 6;
					continue;
				case 6:
					DBh7SXT6NO = P_1;
					num = 7;
					if (JfGq29s1tCTM1nEkBqVA())
					{
					}
					continue;
				case 5:
					base._002Ector();
					goto default;
				case 1:
				case 2:
					MNd7eaBGmq = -1;
					num = 5;
					if (MV2nvNs17U7fJLlSZ1qu())
					{
						continue;
					}
					return;
				case 7:
					return;
				}
				break;
			}
			goto IL_001a;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void CCHFrLs1Ces3RaB8Cdav()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MV2nvNs17U7fJLlSZ1qu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JfGq29s1tCTM1nEkBqVA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private class NcqGflHiOEEV62aK96 : CvsColorToolCustomProtocolCommand
	{
		private readonly int D1v7rwjAVG;

		private readonly int qaq7CGCf6a;

		private readonly int WZ0721Epiv;

		public override CustomProtocolRequest RequestID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CustomProtocolRequest.ExtractorGetColorSamples;
			}
		}

		public override int RequestDataLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return 12;
			}
		}

		public override bool WaitForColorDataMsg
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NcqGflHiOEEV62aK96(int P_0, int P_1, int P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 7;
			while (true)
			{
				switch (num)
				{
				case 8:
					qaq7CGCf6a = P_1;
					goto case 1;
				case 4:
					D1v7rwjAVG = -1;
					s1aAios1KGZ71oNsHpNK();
					num = (TDd7BRs15yRlSa6aH0Wy() ? 1 : 0);
					break;
				case 3:
					base._002Ector();
					goto case 5;
				default:
					num = 5;
					break;
				case 1:
				case 6:
					WZ0721Epiv = P_2;
					num = 9;
					break;
				case 5:
					D1v7rwjAVG = P_0;
					num = 8;
					if (TDd7BRs15yRlSa6aH0Wy())
					{
					}
					break;
				case 7:
					pf1wuus1oUy82BNB2t8O();
					num = 4;
					break;
				case 0:
				case 2:
					qaq7CGCf6a = -1;
					num = 3;
					break;
				case 9:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void pf1wuus1oUy82BNB2t8O()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool s1aAios1KGZ71oNsHpNK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TDd7BRs15yRlSa6aH0Wy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private class HGqn8dIARNbR2c3cvy : CvsColorToolCustomProtocolCommand
	{
		private readonly int fWZ7ymj7yg;

		public override CustomProtocolRequest RequestID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CustomProtocolRequest.ExtractorBeginTrainingSession;
			}
		}

		public override int RequestDataLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return 4;
			}
		}

		public override bool WaitForColorDataMsg
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HGqn8dIARNbR2c3cvy(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (HOv8Dms1P01x68MaHV1J())
			{
				num = 5;
			}
			else
			{
				num = 2;
				if (1 == 0)
				{
					return;
				}
			}
			while (true)
			{
				switch (num)
				{
				case 3:
					base._002Ector();
					break;
				default:
					num = 4;
					continue;
				case 1:
				case 2:
					fWZ7ymj7yg = -1;
					num = 3;
					if (HOv8Dms1P01x68MaHV1J())
					{
						continue;
					}
					break;
				case 4:
					break;
				case 0:
				case 5:
					f39NWKs1NEk9ilhgbyXH();
					goto case 1;
				case 6:
					return;
				}
				fWZ7ymj7yg = P_0;
				num = 6;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void f39NWKs1NEk9ilhgbyXH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HOv8Dms1P01x68MaHV1J()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SgQ2PBs1Yeu8tpKqki87()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private class l7TUmiNg9o5Q9S21NE : CvsColorToolCustomProtocolCommand
	{
		private readonly int dX17VBDwTi;

		private readonly CvsGraphic PCo7vURQNe;

		public override CustomProtocolRequest RequestID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CustomProtocolRequest.ExtractorSetTrainingRegion;
			}
		}

		public override int RequestDataLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				int num = 10;
				int num2 = default;
				while (true)
				{
					switch (num)
					{
					case 1:
						num2 += 24;
						num = 2;
						if (0 == 0)
						{
							continue;
						}
						goto case 7;
					case 7:
					case 8:
						num2 += 8;
						num = 6;
						if (cdCiwAs11iKFTTHKFSg2())
						{
						}
						continue;
					case 4:
					case 5:
						num2 += 12;
						num = 9;
						continue;
					default:
						num = 12;
						continue;
					case 0:
						if (!(PCo7vURQNe is CvsGraphicRegion))
						{
							if (PCo7vURQNe is CvsGraphicCircle)
							{
								GIL0L4s1xjgm5gvHAtMH();
								num = ((!cdCiwAs11iKFTTHKFSg2()) ? 5 : 7);
								continue;
							}
							if (!(PCo7vURQNe is CvsGraphicAnnulus))
							{
								if (!(PCo7vURQNe is CvsGraphicPoint))
								{
									if (PCo7vURQNe is CvsGraphicPolygon)
									{
										num2++;
										num = 3;
										continue;
									}
									break;
								}
								goto case 7;
							}
							goto case 12;
						}
						num = 1;
						continue;
					case 12:
						num2 += 16;
						num = 11;
						continue;
					case 10:
						num2 = 5;
						num = 0;
						continue;
					case 3:
						num2 += 4;
						num = 13;
						continue;
					case 2:
					case 6:
					case 9:
					case 11:
					case 13:
						break;
					}
					break;
				}
				return num2;
			}
		}

		public override bool WaitForColorDataMsg
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public l7TUmiNg9o5Q9S21NE(int P_0, CvsGraphic P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			GIL0L4s1xjgm5gvHAtMH();
			int num = (cdCiwAs11iKFTTHKFSg2() ? 6 : 2);
			do
			{
				IL_0040:
				switch (num)
				{
				case 3:
					base._002Ector();
					goto case 4;
				default:
					num = 4;
					goto IL_0040;
				case 4:
					dX17VBDwTi = P_0;
					num = 5;
					goto IL_0040;
				case 5:
					PCo7vURQNe = P_1;
					num = 7;
					if (cdCiwAs11iKFTTHKFSg2())
					{
					}
					goto IL_0040;
				case 0:
				case 2:
					htJ48Qs1rS7mM7Yg3rC0();
					break;
				case 1:
				case 6:
					break;
				case 7:
					return;
				}
				dX17VBDwTi = -1;
				num = 3;
			}
			while (GIL0L4s1xjgm5gvHAtMH());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void htJ48Qs1rS7mM7Yg3rC0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GIL0L4s1xjgm5gvHAtMH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cdCiwAs11iKFTTHKFSg2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private class j975Y1tYiejiI1tuZv : CvsColorToolCustomProtocolCommand
	{
		private readonly int FdC7Z9j7n3;

		private readonly int kCo781leSH;

		private readonly int XWo7zlZE7P;

		private readonly CvsGraphicPolygon eC4mPJrVO2;

		public override CustomProtocolRequest RequestID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CustomProtocolRequest.ExtractorSetTrainingRegion;
			}
		}

		public override int RequestDataLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				int num = eXXpDws1ll1atNNExOsF(rXB2y7s1QdG8OLwS3gwa(eC4mPJrVO2) - kCo781leSH, XWo7zlZE7P);
				return 5 + 1 + num * 4;
			}
		}

		public override bool WaitForColorDataMsg
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public j975Y1tYiejiI1tuZv(int P_0, CvsGraphicPolygon P_1, int P_2, int P_3)
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
				case 2:
					kn9m2as1MU8ew5hmoyKZ();
					num = 8;
					break;
				case 6:
					base._002Ector();
					_ = 1;
					num = (ydMVHEs1OH7bZJOrNpte() ? 5 : 0);
					break;
				case 8:
					FdC7Z9j7n3 = -1;
					num = 6;
					break;
				case 7:
					kCo781leSH = P_2;
					num = 1;
					break;
				default:
					eC4mPJrVO2 = P_1;
					num = 7;
					break;
				case 1:
					XWo7zlZE7P = P_3;
					num = 9;
					break;
				case 0:
				case 3:
					FdC7Z9j7n3 = P_0;
					goto default;
				case 9:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void kn9m2as1MU8ew5hmoyKZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DqFQWns13sTpehD8iHoi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ydMVHEs1OH7bZJOrNpte()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int rXB2y7s1QdG8OLwS3gwa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphicPolygon)P_0).PointCount;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int eXXpDws1ll1atNNExOsF(int P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Math.Min(P_0, P_1);
		}
	}

	private class mxZqpJPT23EPhjwued : CvsColorToolCustomProtocolCommand
	{
		private readonly int qSAmIe8o16;

		private readonly CvsColorTrainingMode aqum17wHut;

		private readonly CvsColorModelOperation uKHmx8Mept;

		private readonly float tR8mFfZlAG;

		private readonly float bLEmb3Crck;

		public override CustomProtocolRequest RequestID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CustomProtocolRequest.ExtractorTrain;
			}
		}

		public override int RequestDataLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return 2 + 4 + 8;
			}
		}

		public override bool WaitForColorDataMsg
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public mxZqpJPT23EPhjwued(int P_0, CvsColorTrainingMode P_1, CvsColorModelOperation P_2, float P_3, float P_4)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_0068;
			IL_001a:
			tR8mFfZlAG = P_3;
			num = 5;
			goto IL_0068;
			IL_0068:
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 4:
					qSAmIe8o16 = P_0;
					num = 9;
					continue;
				case 5:
					bLEmb3Crck = P_4;
					num = 10;
					continue;
				case 9:
					aqum17wHut = P_1;
					goto case 7;
				default:
					num = 7;
					continue;
				case 2:
				case 3:
					base._002Ector();
					num = 4;
					continue;
				case 6:
					d4wgHVs1IFnMKSjBtXAW();
					_ = 0;
					if (wUikDEs1e7Y5fs6peAGw())
					{
						num = 8;
						if (!UJWnccs1uABCALhMymep())
						{
							continue;
						}
						goto case 1;
					}
					num = 3;
					continue;
				case 1:
				case 8:
					qSAmIe8o16 = -1;
					goto case 2;
				case 7:
					uKHmx8Mept = P_2;
					num = 0;
					continue;
				case 10:
					return;
				}
				break;
			}
			goto IL_001a;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void d4wgHVs1IFnMKSjBtXAW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wUikDEs1e7Y5fs6peAGw()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UJWnccs1uABCALhMymep()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private class FJERNu8O8y4pdbIVxj : CvsColorToolCustomProtocolCommand
	{
		private readonly int tTomaalleJ;

		private readonly CvsColorTrainingResult OImmO3EoGN;

		public override CustomProtocolRequest RequestID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CustomProtocolRequest.ExtractorEndTrainingSession;
			}
		}

		public override int RequestDataLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return 5;
			}
		}

		public override bool WaitForColorDataMsg
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FJERNu8O8y4pdbIVxj(int P_0, CvsColorTrainingResult P_1)
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
				case 6:
					base._002Ector();
					goto case 3;
				default:
					num = 3;
					break;
				case 5:
					VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
					ji5s0Ms1a9W6AKXbauM2();
					if (DBPJobs1RIZLwHvH90iv())
					{
						num = 4;
						break;
					}
					num = 0;
					if (true)
					{
						break;
					}
					return;
				case 0:
				case 2:
					OImmO3EoGN = CvsColorTrainingResult.Discard;
					num = 6;
					break;
				case 3:
					tTomaalleJ = P_0;
					num = 7;
					if (!ji5s0Ms1a9W6AKXbauM2())
					{
						break;
					}
					goto case 7;
				case 7:
					OImmO3EoGN = P_1;
					num = 8;
					if (!ji5s0Ms1a9W6AKXbauM2())
					{
						break;
					}
					goto case 1;
				case 1:
				case 4:
					tTomaalleJ = -1;
					goto case 0;
				case 8:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DBPJobs1RIZLwHvH90iv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ji5s0Ms1a9W6AKXbauM2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private class pgblD8FNNFsbhngdpM : CvsColorToolCustomProtocolCommand
	{
		private readonly int[] MVrmpkPn9r;

		public override CustomProtocolRequest RequestID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CustomProtocolRequest.ExtractorMarkGroups;
			}
		}

		public override int RequestDataLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				int num = 4;
				if (false)
				{
					goto IL_001a;
				}
				goto IL_0037;
				IL_0064:
				int num2 = num2 + MVrmpkPn9r.Length * 4;
				num = 5;
				goto IL_0037;
				IL_0099:
				return num2;
				IL_0037:
				while (true)
				{
					switch (num)
					{
					case 1:
					case 3:
						break;
					default:
						goto IL_0064;
					case 4:
						goto IL_007b;
					case 5:
						goto IL_0099;
					}
					break;
					IL_007b:
					num2 = 4;
					_ = 1;
					if (HAJGLes1GvjYuyRfpgh9())
					{
						num = 0;
						continue;
					}
					num = 3;
					if (sTNyfus1nQ7FR1Qxvp1B())
					{
						continue;
					}
					goto IL_0099;
				}
				goto IL_001a;
				IL_001a:
				if (MVrmpkPn9r != null)
				{
					goto IL_0064;
				}
				goto IL_0099;
			}
		}

		public override bool WaitForColorDataMsg
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public pgblD8FNNFsbhngdpM(int[] P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sTNyfus1nQ7FR1Qxvp1B();
			int num = (HAJGLes1GvjYuyRfpgh9() ? 2 : 3);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
					goto case 1;
				case 4:
					MVrmpkPn9r = P_0;
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
				case 2:
					base._002Ector();
					goto case 4;
				default:
					num = 4;
					break;
				case 5:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sTNyfus1nQ7FR1Qxvp1B()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HAJGLes1GvjYuyRfpgh9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private class rfqwx0OieMOm88hnGH : CvsColorToolCustomProtocolCommand
	{
		private readonly int PXImhjVi59;

		private readonly int[] vHPm49s1dy;

		public override CustomProtocolRequest RequestID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CustomProtocolRequest.ExtractorMarkModels;
			}
		}

		public override int RequestDataLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				int num = 0;
				int num2 = default;
				while (true)
				{
					switch (num)
					{
					case 0:
						num2 = 8;
						hWf37xs1XYIcmDbRdcJK();
						if (!hYK9cxs1bOtETxefs4DM())
						{
							num = 4;
							continue;
						}
						num = 3;
						if (hWf37xs1XYIcmDbRdcJK())
						{
							continue;
						}
						break;
					default:
						num2 += vHPm49s1dy.Length * 4;
						num = 5;
						continue;
					case 1:
					case 4:
						if (vHPm49s1dy == null)
						{
							break;
						}
						goto default;
					case 5:
						break;
					}
					break;
				}
				return num2;
			}
		}

		public override bool WaitForColorDataMsg
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public rfqwx0OieMOm88hnGH(int P_0, int[] P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (!hYK9cxs1bOtETxefs4DM())
			{
			}
			while (true)
			{
				switch (num)
				{
				case 4:
				case 6:
					vHPm49s1dy = P_1;
					num = 7;
					continue;
				case 3:
				case 5:
					PXImhjVi59 = P_0;
					goto case 4;
				case 2:
					PXImhjVi59 = -1;
					num = 1;
					continue;
				case 0:
					l56lTus16ETFyX1hxfmt();
					num = 2;
					if (true)
					{
						continue;
					}
					goto case 1;
				case 1:
					base._002Ector();
					break;
				case 7:
					return;
				}
				hYK9cxs1bOtETxefs4DM();
				num = (hWf37xs1XYIcmDbRdcJK() ? 5 : 6);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void l56lTus16ETFyX1hxfmt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hWf37xs1XYIcmDbRdcJK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hYK9cxs1bOtETxefs4DM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private class vOR7AhXOs6mr1DOgxv : CvsColorToolCustomProtocolCommand
	{
		public override CustomProtocolRequest RequestID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CustomProtocolRequest.ExtractorGetLibraryName;
			}
		}

		public override int RequestDataLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return 0;
			}
		}

		public override bool WaitForColorDataMsg
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public vOR7AhXOs6mr1DOgxv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			iBRRvcs14Tfiw1bbIafA();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void iBRRvcs14Tfiw1bbIafA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kKtkZhs1pbrLW9XgMFGv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HjoNLVs108UK2OA83ePA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public const int INVALID_ID = -1;

	private bool bskA6Lm0vn;

	private string IytAHgbFvy;

	private CvsColorGroup[] kruAKnLYNc;

	public string LibraryName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (Qoa39NubO58h7WflBIn() ? 1 : 3);
			while (true)
			{
				switch (num)
				{
				default:
					if (IytAHgbFvy == null)
					{
						num = 5;
						break;
					}
					return IytAHgbFvy;
				case 4:
					rHRA3dC9bb();
					goto default;
				case 0:
				case 3:
					if (IytAHgbFvy == null)
					{
						num = 4;
						break;
					}
					goto default;
				case 5:
					return string.Empty;
				}
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sy8ALJPYoU(value);
			IytAHgbFvy = null;
		}
	}

	public CvsColorGroup[] ColorGroups
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (A6gARuGJci())
			{
				fOQAkqPyXb();
			}
			return kruAKnLYNc;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsTrainExtractColorEditor()
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
			case 2:
				fnjSJ4u64IgYbEnEtR5();
				Qoa39NubO58h7WflBIn();
				if (y0GnuTuXaiNlZLfxp4l())
				{
					num = 0;
					if (0 == 0)
					{
						break;
					}
					goto case 4;
				}
				num = 5;
				break;
			case 4:
				kruAKnLYNc = new CvsColorGroup[0];
				goto default;
			default:
				base._002Ector();
				num = 6;
				break;
			case 0:
			case 1:
				bskA6Lm0vn = true;
				num = 4;
				if (1 == 0)
				{
					return;
				}
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InvalidateData()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		p8xAWxbPH4();
		IytAHgbFvy = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MarkGroups(int[] groupIDs)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SendCommand(new pgblD8FNNFsbhngdpM(groupIDs));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MarkModels(int groupID, int[] modelIDs)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SendCommand(new rfqwx0OieMOm88hnGH(groupID, modelIDs));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsColorGroup CreateGroup(string groupName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				hNQfhSupCDTcOiXVj7J(this);
				goto case 3;
			default:
				num = 3;
				break;
			case 1:
			case 5:
				throw new ArgumentException();
			case 0:
				while (dKyAAK5Rco(groupName) != null)
				{
					_ = 0;
					if (!y0GnuTuXaiNlZLfxp4l())
					{
						num = 4;
						if (y0GnuTuXaiNlZLfxp4l())
						{
							goto end_IL_0030;
						}
						continue;
					}
					num = 5;
					goto end_IL_0030;
				}
				psAAfr5GA4(groupName);
				goto case 2;
			case 3:
				fOQAkqPyXb();
				num = 6;
				break;
			case 6:
				{
					return dKyAAK5Rco(groupName);
				}
				end_IL_0030:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteGroup(int groupID)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		JM7AjrduYZ(groupID);
		p8xAWxbPH4();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsColorTrainingSession CreateTrainingSession(int GroupID)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsColorTrainingSession result = new CvsColorTrainingSession(GroupID, this);
		YiPAUdAocP(GroupID);
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExitTrainingSession(CvsColorTrainingSession session, CvsColorTrainingResult result)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RSNA0tZwaY(fWhM3gu0WG87JX4ZgaP(session), result);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CvsColorGroup dKyAAK5Rco(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		CvsColorGroup cvsColorGroup = default;
		int num2 = default;
		CvsColorGroup[] array = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 4:
				if (e654QJukNxbulQCfH5p(aSVqEmu4WQPCRcrtumc(cvsColorGroup), P_0))
				{
					goto case 6;
				}
				num2++;
				num = 7;
				break;
			default:
				num = 6;
				break;
			case 5:
				num2 = 0;
				Qoa39NubO58h7WflBIn();
				if (y0GnuTuXaiNlZLfxp4l())
				{
					num = 1;
					break;
				}
				num = 4;
				if (Qoa39NubO58h7WflBIn())
				{
				}
				break;
			case 6:
				return cvsColorGroup;
			case 1:
			case 2:
			case 7:
				if (num2 < array.Length)
				{
					cvsColorGroup = array[num2];
					goto case 3;
				}
				num = 8;
				break;
			case 0:
				array = kruAKnLYNc;
				num = 5;
				break;
			case 8:
				return null;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CvsColorGroup KFqAtu2Ly8(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Qoa39NubO58h7WflBIn();
		int num;
		if (y0GnuTuXaiNlZLfxp4l())
		{
			num = 5;
			if (!y0GnuTuXaiNlZLfxp4l())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 6;
		}
		CvsColorGroup cvsColorGroup = default;
		int num2 = default;
		CvsColorGroup[] array = default;
		while (true)
		{
			IL_005c:
			switch (num)
			{
			case 3:
				break;
			case 7:
				if (pnlrJ6ufUHoUxeGMwvV(cvsColorGroup) != P_0)
				{
					num2++;
					num = 4;
					continue;
				}
				break;
			default:
				num = 3;
				continue;
			case 1:
				num2 = 0;
				goto case 2;
			case 2:
			case 4:
			case 6:
				while (num2 < array.Length)
				{
					cvsColorGroup = array[num2];
					num = 7;
					if (0 == 0)
					{
						goto IL_005c;
					}
				}
				num = 8;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 5:
				array = kruAKnLYNc;
				num = 1;
				continue;
			case 8:
				return null;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		return cvsColorGroup;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void p8xAWxbPH4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		bskA6Lm0vn = true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private bool A6gARuGJci()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return bskA6Lm0vn;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rHRA3dC9bb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SendCommand(new vOR7AhXOs6mr1DOgxv());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void sy8ALJPYoU(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!y0GnuTuXaiNlZLfxp4l()) ? 5 : 3);
		string expr = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				((CvsPropSheet)p7UR6quyZiodGhD9yn3(InSight)).RunAsync(expr).Wait();
				return;
			default:
				num = 2;
				break;
			case 0:
			case 3:
				if (InDialog)
				{
					goto case 1;
				}
				SKcP2gugMW8ANtasjRf(oc5veTuFi3oPhgE1iXw(), rDwRkXumRSyOOiQo08w(37402), CellLocation.ToString(), P_0);
				num = 6;
				if (1 == 0)
				{
					return;
				}
				break;
			case 1:
			case 5:
				expr = string.Format((IFormatProvider)oc5veTuFi3oPhgE1iXw(), (string)rDwRkXumRSyOOiQo08w(37330), P_0);
				num = 4;
				break;
			case 2:
				return;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fOQAkqPyXb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SendCommand(new HodJSu494r5lqUuLrc());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QxEAXyEvoV(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SendCommand(new MZKrVFV3tcMfujwHfo(P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void psAAfr5GA4(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		y0GnuTuXaiNlZLfxp4l();
		int num = (Qoa39NubO58h7WflBIn() ? 5 : 3);
		string expr = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				wMuYWyuJME6y2ObrgaT(((CvsPropSheet)p7UR6quyZiodGhD9yn3(InSight)).RunAsync(expr));
				return;
			default:
				num = 4;
				break;
			case 0:
			case 3:
				if (InDialog)
				{
					num = 1;
					break;
				}
				SKcP2gugMW8ANtasjRf(oc5veTuFi3oPhgE1iXw(), kgbOBx7BanbFa22Hp9.ol99ukmDA(37546), CellLocation.ToString(), P_0);
				num = 6;
				if (true)
				{
					break;
				}
				return;
			case 1:
				expr = (string)M7hrlTuZAlmaIVVkM2v(oc5veTuFi3oPhgE1iXw(), rDwRkXumRSyOOiQo08w(37478), P_0);
				goto case 2;
			case 4:
				return;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void JM7AjrduYZ(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		string expr = default;
		if (y0GnuTuXaiNlZLfxp4l())
		{
			while (true)
			{
				IL_0046:
				switch (num)
				{
				case 2:
					break;
				default:
					return;
				case 4:
					return;
				case 5:
					while (!InDialog)
					{
						string.Format((IFormatProvider)oc5veTuFi3oPhgE1iXw(), kgbOBx7BanbFa22Hp9.ol99ukmDA(37682), CellLocation.ToString(), P_0);
						num = 6;
						if (!Qoa39NubO58h7WflBIn())
						{
							goto IL_0046;
						}
					}
					_ = 1;
					if (Qoa39NubO58h7WflBIn())
					{
						num = 4;
						continue;
					}
					num = 0;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 1:
					expr = (string)M7hrlTuZAlmaIVVkM2v(oc5veTuFi3oPhgE1iXw(), rDwRkXumRSyOOiQo08w(37618), P_0);
					num = 2;
					continue;
				case 6:
					return;
				}
				break;
			}
		}
		wMuYWyuJME6y2ObrgaT(((CvsPropSheet)p7UR6quyZiodGhD9yn3(InSight)).RunAsync(expr));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void XySAcIq5t1(int P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		string expr = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				expr = string.Format((IFormatProvider)oc5veTuFi3oPhgE1iXw(), kgbOBx7BanbFa22Hp9.ol99ukmDA(37750), P_0, P_1);
				_ = 1;
				if (!Qoa39NubO58h7WflBIn())
				{
					num = 1;
					if (true)
					{
						break;
					}
					goto case 1;
				}
				num = 5;
				break;
			case 1:
			case 2:
				((CvsPropSheet)p7UR6quyZiodGhD9yn3(InSight)).RunAsync(expr).Wait();
				return;
			default:
				return;
			case 0:
				if (InDialog)
				{
					num = 4;
					break;
				}
				string.Format((IFormatProvider)oc5veTuFi3oPhgE1iXw(), kgbOBx7BanbFa22Hp9.ol99ukmDA(37826), CellLocation.ToString(), P_0, P_1);
				num = 6;
				break;
			case 5:
				return;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void y9xA5fTjwr(int P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SendCommand(new Cb5tqm1nNAR3j0OrSg(P_0, P_1));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void geAAYxcH78(int P_0, int[] P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SendCommand(new IEvK5bsf2nhpBgVWQh(P_0, P_1));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mKNA7pCOAY(int P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Qoa39NubO58h7WflBIn();
		int num;
		if (y0GnuTuXaiNlZLfxp4l())
		{
			num = 5;
		}
		else
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_00b2;
			}
		}
		string expr = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				return;
			case 1:
			case 3:
				expr = (string)SKcP2gugMW8ANtasjRf(oc5veTuFi3oPhgE1iXw(), rDwRkXumRSyOOiQo08w(37906), P_0, P_1);
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 5:
				if (!InDialog)
				{
					goSckau8DiuciIDMBor(oc5veTuFi3oPhgE1iXw(), rDwRkXumRSyOOiQo08w(37978), CellLocation.ToString(), P_0, P_1);
					num = 6;
					continue;
				}
				goto case 1;
			case 2:
				break;
			default:
				num = 4;
				if (true)
				{
					continue;
				}
				return;
			case 6:
				return;
			}
			break;
		}
		goto IL_00b2;
		IL_00b2:
		wMuYWyuJME6y2ObrgaT(((CvsPropSheet)p7UR6quyZiodGhD9yn3(InSight)).RunAsync(expr));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RDEAmNajiW(int P_0, int P_1, string P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		y0GnuTuXaiNlZLfxp4l();
		int num = (Qoa39NubO58h7WflBIn() ? 1 : 4);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				if (InDialog)
				{
					num = 3;
					break;
				}
				aqOOEBuzCKUlFgvxG2k(oc5veTuFi3oPhgE1iXw(), kgbOBx7BanbFa22Hp9.ol99ukmDA(38138), new object[4]
				{
					CellLocation.ToString(),
					P_0,
					P_1,
					P_2
				});
				num = 5;
				break;
			case 3:
				goSckau8DiuciIDMBor(oc5veTuFi3oPhgE1iXw(), kgbOBx7BanbFa22Hp9.ol99ukmDA(38054), P_0, P_1, P_2);
				return;
			default:
				return;
			case 1:
				return;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gQHAnTFKi7(int P_0, int P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SendCommand(new NcqGflHiOEEV62aK96(P_0, P_1, P_2));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void javA9IAP6c(int P_0, int P_1, float P_2, bool P_3, float P_4, bool P_5, float P_6, float P_7, CvsColorModelOperation P_8)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		string expr = default;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 4:
				return;
			case 0:
				if (!InDialog)
				{
					string.Format((IFormatProvider)oc5veTuFi3oPhgE1iXw(), kgbOBx7BanbFa22Hp9.ol99ukmDA(38348), CellLocation.ToString(), P_0, P_1, (uint)P_8, P_5 ? 1 : 0, P_6, P_7, P_3 ? 1 : 0, P_4, P_2);
					num = 6;
				}
				else
				{
					num = 5;
				}
				break;
			case 1:
			case 2:
				wMuYWyuJME6y2ObrgaT(InSight.PropSheet.RunAsync(expr));
				return;
			case 5:
				expr = (string)aqOOEBuzCKUlFgvxG2k(oc5veTuFi3oPhgE1iXw(), kgbOBx7BanbFa22Hp9.ol99ukmDA(38226), new object[9]
				{
					P_0,
					P_1,
					(uint)P_8,
					P_5 ? 1 : 0,
					P_6,
					P_7,
					P_3 ? 1 : 0,
					P_4,
					P_2
				});
				Qoa39NubO58h7WflBIn();
				num = (y0GnuTuXaiNlZLfxp4l() ? 1 : 4);
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void YiPAUdAocP(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SendCommand(new HGqn8dIARNbR2c3cvy(P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RSNA0tZwaY(int P_0, CvsColorTrainingResult P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SendCommand(new FJERNu8O8y4pdbIVxj(P_0, P_1));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tBUAwv2WyG(int P_0, CvsColorTrainingMode P_1, CvsColorModelOperation P_2, float P_3, float P_4, CvsGraphic P_5)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		y0GnuTuXaiNlZLfxp4l();
		int num;
		if (!Qoa39NubO58h7WflBIn())
		{
			num = 9;
		}
		else
		{
			num = 8;
			if (Qoa39NubO58h7WflBIn())
			{
			}
		}
		CvsGraphicPolygon cvsGraphicPolygon = default;
		int num2 = default;
		int num3 = default;
		while (true)
		{
			switch (num)
			{
			case 10:
				cvsGraphicPolygon = P_5 as CvsGraphicPolygon;
				num = 4;
				break;
			case 0:
			case 9:
				SendCommand(new l7TUmiNg9o5Q9S21NE(P_0, P_5));
				goto case 1;
			case 1:
			case 8:
				if (P_5 is CvsGraphicPolygon)
				{
					num = 10;
					if (true)
					{
						break;
					}
					goto case 5;
				}
				goto IL_0081;
			case 5:
			case 6:
				if (num2 < num3)
				{
					SendCommand(new j975Y1tYiejiI1tuZv(P_0, cvsGraphicPolygon, num2 * 250, 250));
					num = 3;
					break;
				}
				goto IL_0081;
			case 4:
				num3 = WM8qAPIwPmOvIZV9CKY(cvsGraphicPolygon) / 250;
				num = 11;
				break;
			case 11:
				if (WM8qAPIwPmOvIZV9CKY(cvsGraphicPolygon) % 250 != 0)
				{
					num = 2;
					break;
				}
				goto case 7;
			case 7:
				num2 = 0;
				num = 6;
				if (!Qoa39NubO58h7WflBIn())
				{
					break;
				}
				goto case 5;
			case 2:
				num3++;
				goto case 7;
			default:
				num = 7;
				break;
			case 3:
				num2++;
				num = 5;
				break;
			case 12:
				return;
				IL_0081:
				SendCommand(new mxZqpJPT23EPhjwued(P_0, P_1, P_2, P_3, P_4));
				num = 12;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fnjSJ4u64IgYbEnEtR5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool y0GnuTuXaiNlZLfxp4l()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Qoa39NubO58h7WflBIn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hNQfhSupCDTcOiXVj7J(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsColorToolEditorBase)P_0).InvalidateData();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int fWhM3gu0WG87JX4ZgaP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsColorTrainingSession)P_0).GroupID;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aSVqEmu4WQPCRcrtumc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsColorGroup)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool e654QJukNxbulQCfH5p(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int pnlrJ6ufUHoUxeGMwvV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsColorGroup)P_0).Id;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oc5veTuFi3oPhgE1iXw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.InvariantCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rDwRkXumRSyOOiQo08w(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object p7UR6quyZiodGhD9yn3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).PropSheet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SKcP2gugMW8ANtasjRf(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((IFormatProvider)P_0, (string)P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object M7hrlTuZAlmaIVVkM2v(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((IFormatProvider)P_0, (string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wMuYWyuJME6y2ObrgaT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Task)P_0).Wait();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object goSckau8DiuciIDMBor(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((IFormatProvider)P_0, (string)P_1, P_2, P_3, P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aqOOEBuzCKUlFgvxG2k(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((IFormatProvider)P_0, (string)P_1, (object[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int WM8qAPIwPmOvIZV9CKY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicPolygon)P_0).PointCount;
	}
}
