using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cognex.InSight.Graphic;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

public sealed class CvsTrainColorMatchEditor : CvsColorToolEditorBase
{
	public class CvsColorModel
	{
		private readonly int ycGmMvv9U2;

		private string vKjmoPhTIR;

		private float fKPmAVnjgg;

		private float ahBmtVU8Kx;

		private float OC3mWx3SMf;

		private float Wmmm3Fw3fp;

		private float IhYmLtSRwV;

		private float IOSmkLV0es;

		private float tjnmXSg3OA;

		private float Bbnmf3bU9K;

		private bool xiRmjqLmRA;

		private readonly CvsTrainColorMatchEditor iPkmc8eOvn;

		private readonly CvsColorModelSamples J7jm5h8rKE;

		public int Id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ycGmMvv9U2;
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
				BylmBtlUAE();
				return vKjmoPhTIR;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				kHX75Us1ZxuwJTCtX3an();
				int num;
				if (!pPrVKPs1J22L6FjSOC4M())
				{
					num = 2;
					if (pPrVKPs1J22L6FjSOC4M())
					{
					}
				}
				else
				{
					num = 5;
				}
				while (true)
				{
					switch (num)
					{
					case 4:
						vKjmoPhTIR = value;
						num = 6;
						if (0 == 0)
						{
							break;
						}
						goto case 0;
					case 0:
					case 2:
						if (lgLY05srwesdq6UmOj7s(vKjmoPhTIR, value))
						{
							return;
						}
						if (yY6vrnsrsLAh5p39isCN(iPkmc8eOvn, value) != null)
						{
							num = 3;
							break;
						}
						iPkmc8eOvn.QBiAZUJOa5(Id, value);
						goto case 4;
					case 1:
						return;
					case 5:
						return;
					case 3:
						throw new ArgumentException();
					default:
						num = 4;
						if (pPrVKPs1J22L6FjSOC4M())
						{
						}
						break;
					case 6:
						return;
					}
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
				BylmBtlUAE();
				return Bbnmf3bU9K;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				if (value != Bbnmf3bU9K)
				{
					UdWmJl2WD1(EnableMatteLine, LowerMatteLineLimit, value);
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
				BylmBtlUAE();
				return tjnmXSg3OA;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				if (value != tjnmXSg3OA)
				{
					UdWmJl2WD1(EnableMatteLine, value, UpperMatteLineLimit);
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
				BylmBtlUAE();
				return xiRmjqLmRA;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				if (value != xiRmjqLmRA)
				{
					UdWmJl2WD1(value, LowerMatteLineLimit, UpperMatteLineLimit);
				}
			}
		}

		public float Red
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				BylmBtlUAE();
				return fKPmAVnjgg;
			}
		}

		public float Green
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				BylmBtlUAE();
				return OC3mWx3SMf;
			}
		}

		public float Blue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				BylmBtlUAE();
				return ahBmtVU8Kx;
			}
		}

		public float Hue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				BylmBtlUAE();
				return Wmmm3Fw3fp;
			}
		}

		public float Saturation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				BylmBtlUAE();
				return IhYmLtSRwV;
			}
		}

		public float Intensity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				BylmBtlUAE();
				return IOSmkLV0es;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal CvsColorModel(CvsTrainColorMatchEditor trainer, int modelId)
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
				case 8:
					J7jm5h8rKE = new CvsColorModelSamples();
					kHX75Us1ZxuwJTCtX3an();
					num = (pPrVKPs1J22L6FjSOC4M() ? 1 : 4);
					continue;
				case 5:
					iPkmc8eOvn = trainer;
					num = 2;
					continue;
				case 7:
					ycGmMvv9U2 = -1;
					num = 8;
					continue;
				case 3:
				case 4:
					M2mSh8s1zBO9AOtOpLbK(this);
					goto case 5;
				default:
					num = 5;
					if (true)
					{
						continue;
					}
					goto case 2;
				case 2:
					ycGmMvv9U2 = modelId;
					break;
				case 0:
					umgJDRs18y1SaHFgZcNU();
					num = 7;
					continue;
				case 1:
				case 6:
					break;
				case 9:
					return;
				}
				vKjmoPhTIR = null;
				num = 9;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetMatteOptions(bool enable, float lowerLimit, float upperLimit)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			UdWmJl2WD1(enable, lowerLimit, upperLimit);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CvsColorModelSamples CreateColorSamples(int sampleSize)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			GsimAwsrhTgS1YQDcH7d(iPkmc8eOvn, Id, sampleSize);
			return J7jm5h8rKE;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Train(CvsGraphicRegion region)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (kHX75Us1ZxuwJTCtX3an())
			{
				num = 1;
			}
			else
			{
				num = 3;
				if (1 == 0)
				{
					return;
				}
			}
			while (true)
			{
				switch (num)
				{
				default:
					InvalidateModelData();
					num = 5;
					if (!pPrVKPs1J22L6FjSOC4M())
					{
						break;
					}
					goto case 0;
				case 0:
				case 1:
					iPkmc8eOvn.nqFtPnAAf6(region);
					num = 4;
					if (0 == 0)
					{
						break;
					}
					goto case 4;
				case 4:
					j6wXjwsrLAFisy42fTwW(iPkmc8eOvn, Id);
					goto default;
				case 5:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Train(CvsGraphicPolygon polygon)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kHX75Us1ZxuwJTCtX3an();
			int num = (pPrVKPs1J22L6FjSOC4M() ? 3 : 4);
			while (true)
			{
				switch (num)
				{
				case 2:
					InvalidateModelData();
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
				case 3:
					j6wXjwsrLAFisy42fTwW(iPkmc8eOvn, Id);
					goto case 2;
				default:
					num = 2;
					break;
				case 0:
				case 4:
					dTjqGCsr9R2kE1HlnWQG(iPkmc8eOvn, polygon);
					goto case 1;
				case 5:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Train(CvsGraphicCircle circle)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			do
			{
				IL_0067:
				switch (num)
				{
				case 0:
					nElSI7srSTPsGLmqbEiY(iPkmc8eOvn, circle);
					kHX75Us1ZxuwJTCtX3an();
					if (!pPrVKPs1J22L6FjSOC4M())
					{
						num = 3;
						if (kHX75Us1ZxuwJTCtX3an())
						{
							goto IL_0067;
						}
						goto case 1;
					}
					num = 4;
					goto IL_0067;
				case 1:
				case 3:
					iPkmc8eOvn.X14tbZYtNZ(Id);
					break;
				case 5:
					return;
				}
				InvalidateModelData();
				num = 5;
			}
			while (kHX75Us1ZxuwJTCtX3an());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Train(CvsGraphicAnnulus annulus)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (pPrVKPs1J22L6FjSOC4M() ? 4 : 2);
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					j6wXjwsrLAFisy42fTwW(iPkmc8eOvn, Id);
					break;
				default:
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 3:
					break;
				case 0:
				case 2:
					UWf51wsrEJg5D6YOnSX3(iPkmc8eOvn, annulus);
					goto case 1;
				case 5:
					return;
				}
				InvalidateModelData();
				num = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Train(CvsGraphicPoint point)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = (kHX75Us1ZxuwJTCtX3an() ? 1 : 4);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					iPkmc8eOvn.JWitI5psHp(point);
					num = 3;
					if (kHX75Us1ZxuwJTCtX3an())
					{
						continue;
					}
					goto case 3;
				case 3:
					j6wXjwsrLAFisy42fTwW(iPkmc8eOvn, Id);
					break;
				case 5:
					return;
				}
				InvalidateModelData();
				num = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InvalidateModelData()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			vKjmoPhTIR = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BylmBtlUAE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!pPrVKPs1J22L6FjSOC4M())
			{
				num = 4;
			}
			else
			{
				num = 3;
				if (!kHX75Us1ZxuwJTCtX3an())
				{
					return;
				}
			}
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					if (vKjmoPhTIR == null)
					{
						num = 1;
						break;
					}
					return;
				default:
					jHnMHEsrv0JbaiMYMKM6(iPkmc8eOvn, Id);
					num = 5;
					break;
				case 1:
					if (iPkmc8eOvn != null)
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
		private void UdWmJl2WD1(bool P_0, float P_1, float P_2)
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
			goto IL_0068;
			IL_001a:
			Bbnmf3bU9K = P_2;
			num = 7;
			goto IL_0068;
			IL_0068:
			while (true)
			{
				switch (num)
				{
				case 6:
					break;
				case 1:
				case 5:
					iPkmc8eOvn.NorAzSPi78(Id, P_0, P_1, P_2);
					goto case 0;
				case 0:
				case 2:
					xiRmjqLmRA = P_0;
					goto case 3;
				default:
					num = 3;
					if (kHX75Us1ZxuwJTCtX3an())
					{
						continue;
					}
					goto case 3;
				case 3:
					tjnmXSg3OA = P_1;
					num = 6;
					if (kHX75Us1ZxuwJTCtX3an())
					{
						continue;
					}
					goto case 4;
				case 4:
					if (iPkmc8eOvn != null)
					{
						_ = 0;
						num = (kHX75Us1ZxuwJTCtX3an() ? 5 : 0);
						continue;
					}
					goto case 0;
				case 7:
					return;
				}
				break;
			}
			goto IL_001a;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void umgJDRs18y1SaHFgZcNU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void M2mSh8s1zBO9AOtOpLbK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kHX75Us1ZxuwJTCtX3an()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pPrVKPs1J22L6FjSOC4M()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lgLY05srwesdq6UmOj7s(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yY6vrnsrsLAh5p39isCN(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsTrainColorMatchEditor)P_0).IGSADH7v7Y((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GsimAwsrhTgS1YQDcH7d(object P_0, int P_1, int P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsTrainColorMatchEditor)P_0).NThA8KATgp(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void j6wXjwsrLAFisy42fTwW(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsTrainColorMatchEditor)P_0).X14tbZYtNZ(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void dTjqGCsr9R2kE1HlnWQG(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsTrainColorMatchEditor)P_0).BNTtFUXa7o((CvsGraphicPolygon)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void nElSI7srSTPsGLmqbEiY(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsTrainColorMatchEditor)P_0).BOUt1QG4Ce((CvsGraphicCircle)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UWf51wsrEJg5D6YOnSX3(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsTrainColorMatchEditor)P_0).t2ktxxGviY((CvsGraphicAnnulus)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jHnMHEsrv0JbaiMYMKM6(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsTrainColorMatchEditor)P_0).k5QAyawV4D(P_1);
		}
	}

	private class qCUv1nxFSEPSVE491X : CvsColorToolCustomProtocolCommand
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
				return CustomProtocolRequest.MatchGetLibraryName;
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
		public qCUv1nxFSEPSVE491X()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CZDa9hsrA3w7p8EofNgV();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void CZDa9hsrA3w7p8EofNgV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pl83oAsrHGjhJ8HGItdg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool C5igJmsrVnvqBQmNSncb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private class QOkom3MubkxoqG0rmv : CvsColorToolCustomProtocolCommand
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
				return CustomProtocolRequest.MatchGetModelList;
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
		public QOkom3MubkxoqG0rmv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			W1HduosrThjeJ9ToQ8GS();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void W1HduosrThjeJ9ToQ8GS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oEL4J8srDm4ummoGdUMA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool V4dEWcsrU40BN4pVHkRr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private class sudM3QRK4dEA27JVlO : CvsColorToolCustomProtocolCommand
	{
		private readonly int IYcmYKsSl3;

		public override CustomProtocolRequest RequestID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CustomProtocolRequest.MatchGetModelData;
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
		public sudM3QRK4dEA27JVlO(int P_0)
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
				case 2:
					base._002Ector();
					goto default;
				case 4:
					IYcmYKsSl3 = -1;
					_ = 1;
					if (iMQhK8sriuyaqmeNxCu0())
					{
						num = 5;
						if (iMQhK8sriuyaqmeNxCu0())
						{
						}
					}
					else
					{
						num = 0;
					}
					break;
				default:
					IYcmYKsSl3 = P_0;
					num = 6;
					break;
				case 1:
					QRA4n1srqBqUV9ikUqrq();
					num = 4;
					if (false)
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
		internal static void QRA4n1srqBqUV9ikUqrq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RkUu8usrdBELYXD6FQ7W()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iMQhK8sriuyaqmeNxCu0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private class OikuVGvDGMigHowxec : CvsColorToolCustomProtocolCommand
	{
		private readonly int hm7m7roHMB;

		private readonly int pBommixvTL;

		public override CustomProtocolRequest RequestID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CustomProtocolRequest.MatchGetColorSamples;
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
		public OikuVGvDGMigHowxec(int P_0, int P_1)
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
				case 5:
					G8MutYsrcLttYa80i1XM();
					_ = 0;
					if (IJ3DdqsrBr6oh4yWfl3E())
					{
						num = 4;
						if (true)
						{
							break;
						}
						goto case 0;
					}
					num = 3;
					break;
				case 0:
					pBommixvTL = P_1;
					num = 7;
					break;
				case 6:
					hm7m7roHMB = P_0;
					num = 0;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				case 2:
				case 3:
					base._002Ector();
					goto case 6;
				default:
					num = 6;
					break;
				case 1:
				case 4:
					hm7m7roHMB = -1;
					goto case 2;
				case 7:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void G8MutYsrcLttYa80i1XM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IJ3DdqsrBr6oh4yWfl3E()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vSs5KjsrjDIU9xBcCkU5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private class H63ce2A1Wdn81jAk06 : CvsColorToolCustomProtocolCommand
	{
		private readonly CvsGraphicPolygon PTxmnWXYol;

		public override CustomProtocolRequest RequestID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CustomProtocolRequest.MatchSetTrainingPolygon;
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
				return false;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public H63ce2A1Wdn81jAk06(CvsGraphicPolygon P_0)
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
					iM9LyHsr76vMIlmkchoV();
					mqEPUZsrWZh5MmZRKvpI();
					num = (YM0p7Ysr2kEigB6tx88o() ? 4 : 0);
					continue;
				case 1:
				case 4:
					base._002Ector();
					break;
				case 5:
					return;
				}
				PTxmnWXYol = P_0;
				num = 5;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void iM9LyHsr76vMIlmkchoV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YM0p7Ysr2kEigB6tx88o()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mqEPUZsrWZh5MmZRKvpI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private class OQMAyycVU7MxMTiiXT : CvsColorToolCustomProtocolCommand
	{
		private readonly int dN6m9UYRnh;

		private readonly int yj7mUhXuad;

		private readonly CvsGraphicPolygon ag9m0hk2UO;

		public override CustomProtocolRequest RequestID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CustomProtocolRequest.MatchSetTrainingPolygon;
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
				int num = MAC6oQsroMK6t6r0af7g(jZXBSqsr5Q5AdmfWFAiE(ag9m0hk2UO) - dN6m9UYRnh, yj7mUhXuad);
				return 0 + 1 + 4 + num * 2 * 4;
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
		public OQMAyycVU7MxMTiiXT(CvsGraphicPolygon P_0, int P_1, int P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!LDjFo8srCnhvVAfYi5wr())
			{
				num = 6;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 5;
				if (LDjFo8srCnhvVAfYi5wr())
				{
				}
			}
			goto IL_0050;
			IL_0026:
			dN6m9UYRnh = P_1;
			num = 2;
			goto IL_0050;
			IL_0050:
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 4:
					ag9m0hk2UO = P_0;
					break;
				default:
					num = 3;
					continue;
				case 0:
				case 6:
					TeAsjLsrKl7CIYnudGmH();
					goto case 1;
				case 2:
					yj7mUhXuad = P_2;
					num = 7;
					continue;
				case 1:
				case 5:
					base._002Ector();
					num = 4;
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_0026;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void TeAsjLsrKl7CIYnudGmH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool D2ftYKsrtAEL2ewpNJXG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LDjFo8srCnhvVAfYi5wr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int jZXBSqsr5Q5AdmfWFAiE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphicPolygon)P_0).PointCount;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int MAC6oQsroMK6t6r0af7g(int P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Math.Min(P_0, P_1);
		}
	}

	public const int INVALID_ID = -1;

	private bool lm4tpvtRkp;

	private string qfMthwDA2Z;

	private CvsColorModel[] HySt4RLnO6;

	public CvsColorModel[] ColorModels
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (NwLtaYQjGB())
			{
				sBkA25c7OZ();
			}
			return HySt4RLnO6;
		}
	}

	public string LibraryName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IpyH94IHBYhGjDfvoH1();
			int num;
			if (!kGCoSAIVkRWk9LqT7Sy())
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_0072;
			IL_005a:
			JwcAr3LV6t();
			goto IL_0045;
			IL_0072:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					break;
				case 2:
					goto IL_0045;
				case 1:
				case 4:
					goto IL_005a;
				default:
					num = 2;
					continue;
				case 5:
					return string.Empty;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			if (qfMthwDA2Z != null)
			{
				goto IL_0045;
			}
			goto IL_005a;
			IL_0045:
			if (qfMthwDA2Z == null)
			{
				num = 5;
				goto IL_0072;
			}
			return qfMthwDA2Z;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			YHPACm3hnq(value);
			qfMthwDA2Z = null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsTrainColorMatchEditor()
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
			case 0:
				nPSdLEIA00mWfr2mU6x();
				_ = 1;
				if (!kGCoSAIVkRWk9LqT7Sy())
				{
					num = 4;
					if (!kGCoSAIVkRWk9LqT7Sy())
					{
						continue;
					}
					goto case 1;
				}
				num = 5;
				continue;
			case 1:
			case 4:
				lm4tpvtRkp = true;
				num = 2;
				continue;
			case 2:
				HySt4RLnO6 = new CvsColorModel[0];
				break;
			case 6:
				return;
			}
			base._002Ector();
			num = 6;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InvalidateData()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		oKBASmppn6();
		qfMthwDA2Z = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsColorModel CreateModel(string modelName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (kGCoSAIVkRWk9LqT7Sy() ? 4 : 5);
		while (true)
		{
			switch (num)
			{
			case 1:
				sBkA25c7OZ();
				num = 6;
				break;
			case 2:
			case 4:
				Gbfhk0IDZhWlpTs4Wky(this);
				goto case 1;
			default:
				num = 1;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 5:
				if (IGSADH7v7Y(modelName) != null)
				{
					num = 3;
					if (kGCoSAIVkRWk9LqT7Sy())
					{
					}
					break;
				}
				gxUAV6BKVx(modelName);
				goto case 2;
			case 3:
				throw new ArgumentException();
			case 6:
				return IGSADH7v7Y(modelName);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteModel(int modelID)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		s2EAv5HeI3(modelID);
		oKBASmppn6();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CvsColorModel IGSADH7v7Y(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IpyH94IHBYhGjDfvoH1();
		int num = (kGCoSAIVkRWk9LqT7Sy() ? 5 : 3);
		CvsColorModel cvsColorModel = default;
		int num2 = default;
		CvsColorModel[] hySt4RLnO = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				if (GDoTesITLdUmbiQOuEI(TOQFVHIUbCal4LrLIlF(cvsColorModel), P_0))
				{
					goto case 1;
				}
				num2++;
				num = 7;
				if (kGCoSAIVkRWk9LqT7Sy())
				{
				}
				break;
			default:
				num = 1;
				break;
			case 1:
				return cvsColorModel;
			case 0:
			case 3:
				hySt4RLnO = HySt4RLnO6;
				num = 6;
				break;
			case 2:
			case 5:
			case 7:
				if (num2 < hySt4RLnO.Length)
				{
					cvsColorModel = hySt4RLnO[num2];
					num = 4;
				}
				else
				{
					num = 8;
				}
				break;
			case 6:
				num2 = 0;
				goto case 2;
			case 8:
				return null;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private CvsColorModel EAXAevVIoo(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!IpyH94IHBYhGjDfvoH1()) ? 3 : 2);
		CvsColorModel cvsColorModel = default;
		int num2 = default;
		CvsColorModel[] hySt4RLnO = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				if (cvsColorModel.Id == P_0)
				{
					goto case 4;
				}
				num2++;
				num = 6;
				break;
			default:
				num = 4;
				break;
			case 0:
			case 2:
				hySt4RLnO = HySt4RLnO6;
				goto case 1;
			case 4:
				return cvsColorModel;
			case 5:
			case 6:
				if (num2 < hySt4RLnO.Length)
				{
					cvsColorModel = hySt4RLnO[num2];
					num = 7;
					break;
				}
				num = 8;
				if (IpyH94IHBYhGjDfvoH1())
				{
					break;
				}
				goto case 1;
			case 1:
			case 3:
				num2 = 0;
				num = 5;
				break;
			case 8:
				return null;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void oKBASmppn6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		lm4tpvtRkp = true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private bool NwLtaYQjGB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return lm4tpvtRkp;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void JwcAr3LV6t()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SendCommand(new qCUv1nxFSEPSVE491X());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void YHPACm3hnq(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		string expr = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				if (InDialog)
				{
					_ = 1;
					if (!kGCoSAIVkRWk9LqT7Sy())
					{
						num = 0;
						break;
					}
					num = 3;
					if (0 == 0)
					{
						break;
					}
					return;
				}
				sHZkpJIBMwnZY5YVky7(FR5AbWIdOTAVvPJphaL(), Q0lmleIqjfc60k9Svm9(38618), CellLocation.ToString(), P_0);
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 2:
			case 3:
				((CvsPropSheet)dni2uYIibagRvDj13r5(InSight)).RunAsync(expr).Wait();
				return;
			default:
				num = 5;
				if (kGCoSAIVkRWk9LqT7Sy())
				{
				}
				break;
			case 5:
				return;
			case 0:
			case 1:
				expr = string.Format((IFormatProvider)FR5AbWIdOTAVvPJphaL(), kgbOBx7BanbFa22Hp9.ol99ukmDA(38550), P_0);
				goto case 2;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void sBkA25c7OZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SendCommand(new QOkom3MubkxoqG0rmv());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void k5QAyawV4D(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SendCommand(new sudM3QRK4dEA27JVlO(P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void gxUAV6BKVx(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IpyH94IHBYhGjDfvoH1();
		int num = ((!kGCoSAIVkRWk9LqT7Sy()) ? 1 : 5);
		string expr = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				expr = (string)cCkMPiIj3Zqh7k7KHqs(FR5AbWIdOTAVvPJphaL(), Q0lmleIqjfc60k9Svm9(38690), P_0);
				num = 2;
				continue;
			case 2:
				feYK1lIcZ9faAJ5XYiI(((CvsPropSheet)dni2uYIibagRvDj13r5(InSight)).RunAsync(expr));
				return;
			default:
				return;
			case 5:
				return;
			case 0:
			case 1:
				break;
			case 6:
				return;
			}
			do
			{
				if (!InDialog)
				{
					sHZkpJIBMwnZY5YVky7(CultureInfo.InvariantCulture, Q0lmleIqjfc60k9Svm9(38754), CellLocation.ToString(), P_0);
					num = 6;
					continue;
				}
				num = 4;
				if (0 == 0)
				{
					break;
				}
				return;
			}
			while (1 == 0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void s2EAv5HeI3(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		kGCoSAIVkRWk9LqT7Sy();
		int num;
		if (IpyH94IHBYhGjDfvoH1())
		{
			num = 3;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 1;
			if (false)
			{
				goto IL_00aa;
			}
		}
		goto IL_0052;
		IL_00aa:
		if (InDialog)
		{
			num = 4;
			if (1 == 0)
			{
				return;
			}
		}
		else
		{
			sHZkpJIBMwnZY5YVky7(FR5AbWIdOTAVvPJphaL(), Q0lmleIqjfc60k9Svm9(38882), CellLocation.ToString(), P_0);
			num = 6;
		}
		goto IL_0052;
		IL_002a:
		string expr = default;
		((CvsPropSheet)dni2uYIibagRvDj13r5(InSight)).RunAsync(expr).Wait();
		return;
		IL_0052:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				break;
			default:
				num = 5;
				continue;
			case 4:
				expr = (string)cCkMPiIj3Zqh7k7KHqs(FR5AbWIdOTAVvPJphaL(), Q0lmleIqjfc60k9Svm9(38822), P_0);
				break;
			case 0:
			case 3:
				goto IL_00aa;
			case 5:
				return;
			case 6:
				return;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QBiAZUJOa5(int P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		kGCoSAIVkRWk9LqT7Sy();
		int num;
		if (IpyH94IHBYhGjDfvoH1())
		{
			num = 5;
		}
		else
		{
			num = 4;
			if (false)
			{
				return;
			}
		}
		string expr = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				if (InDialog)
				{
					num = 1;
					break;
				}
				n3J9WiI2RNIaPnBKYbU(CultureInfo.InvariantCulture, Q0lmleIqjfc60k9Svm9(39018), CellLocation.ToString(), P_0, P_1);
				num = 6;
				break;
			case 1:
				expr = (string)sHZkpJIBMwnZY5YVky7(CultureInfo.InvariantCulture, Q0lmleIqjfc60k9Svm9(38946), P_0, P_1);
				num = 2;
				if (!IpyH94IHBYhGjDfvoH1())
				{
					return;
				}
				break;
			default:
				return;
			case 4:
				return;
			case 2:
				feYK1lIcZ9faAJ5XYiI(((CvsPropSheet)dni2uYIibagRvDj13r5(InSight)).RunAsync(expr));
				return;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NThA8KATgp(int P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SendCommand(new OikuVGvDGMigHowxec(P_0, P_1));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NorAzSPi78(int P_0, bool P_1, float P_2, float P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (kGCoSAIVkRWk9LqT7Sy() ? 3 : 4);
		string expr = default;
		do
		{
			IL_004c:
			switch (num)
			{
			case 2:
				feYK1lIcZ9faAJ5XYiI(((CvsPropSheet)dni2uYIibagRvDj13r5(InSight)).RunAsync(expr));
				return;
			default:
				num = 5;
				goto IL_004c;
			case 0:
			case 4:
				if (InDialog)
				{
					break;
				}
				AlCrrnIWpDDJnB813Hk(CultureInfo.InvariantCulture, Q0lmleIqjfc60k9Svm9(39184), new object[5]
				{
					CellLocation.ToString(),
					P_0,
					P_1 ? 1 : 0,
					P_2,
					P_3
				});
				num = 6;
				goto IL_004c;
			case 5:
				return;
			case 1:
			case 3:
				break;
			case 6:
				return;
			}
			expr = string.Format((IFormatProvider)FR5AbWIdOTAVvPJphaL(), (string)Q0lmleIqjfc60k9Svm9(39094), P_0, P_1 ? 1 : 0, P_2, P_3);
			num = 2;
		}
		while (true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nqFtPnAAf6(CvsGraphicRegion P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		kGCoSAIVkRWk9LqT7Sy();
		int num = ((!IpyH94IHBYhGjDfvoH1()) ? 2 : 4);
		string expr = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				expr = string.Format(CultureInfo.InvariantCulture, (string)Q0lmleIqjfc60k9Svm9(39278), tvuINaI7uXO1J0xv0I9(P_0).X, tvuINaI7uXO1J0xv0I9(P_0).Y, XCSu7jItfQAWua1DPYY(P_0), GMSi3FICDRYodRXtJkQ(P_0), P_0.Angle, P_0.Curve);
				num = 3;
				if (false)
				{
					return;
				}
				break;
			case 5:
				return;
			case 3:
				feYK1lIcZ9faAJ5XYiI(((CvsPropSheet)dni2uYIibagRvDj13r5(InSight)).RunAsync(expr));
				return;
			default:
				num = 5;
				break;
			case 0:
			case 4:
				if (!InDialog)
				{
					string.Format((IFormatProvider)FR5AbWIdOTAVvPJphaL(), (string)Q0lmleIqjfc60k9Svm9(39420), CellLocation.ToString(), tvuINaI7uXO1J0xv0I9(P_0).X, tvuINaI7uXO1J0xv0I9(P_0).Y, XCSu7jItfQAWua1DPYY(P_0), GMSi3FICDRYodRXtJkQ(P_0), P_0.Angle, s1y66jIKFPnry7OXdv9(P_0));
					num = 6;
					break;
				}
				goto case 1;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void JWitI5psHp(CvsGraphicPoint P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IpyH94IHBYhGjDfvoH1();
		int num;
		if (!kGCoSAIVkRWk9LqT7Sy())
		{
			num = 5;
		}
		else
		{
			num = 1;
			if (!IpyH94IHBYhGjDfvoH1())
			{
				return;
			}
		}
		string expr = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				if (InDialog)
				{
					num = 3;
					if (true)
					{
						break;
					}
					goto case 1;
				}
				n3J9WiI2RNIaPnBKYbU(FR5AbWIdOTAVvPJphaL(), Q0lmleIqjfc60k9Svm9(39650), CellLocation.ToString(), vxuM7JI5Q0wjwi2Q6Ro(P_0).X, P_0.Location.Y);
				num = 6;
				break;
			case 1:
			case 2:
				((CvsPropSheet)dni2uYIibagRvDj13r5(InSight)).RunAsync(expr).Wait();
				return;
			default:
				num = 4;
				break;
			case 3:
				expr = (string)sHZkpJIBMwnZY5YVky7(FR5AbWIdOTAVvPJphaL(), Q0lmleIqjfc60k9Svm9(39566), vxuM7JI5Q0wjwi2Q6Ro(P_0).X, vxuM7JI5Q0wjwi2Q6Ro(P_0).Y);
				goto case 1;
			case 4:
				return;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BOUt1QG4Ce(CvsGraphicCircle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IpyH94IHBYhGjDfvoH1();
		int num = (kGCoSAIVkRWk9LqT7Sy() ? 2 : 3);
		string expr = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				expr = string.Format((IFormatProvider)FR5AbWIdOTAVvPJphaL(), (string)Q0lmleIqjfc60k9Svm9(39738), H6kb2YIoLG3S7r3NDu9(P_0).X, P_0.Center.Y, TBWRg6IP7doCdgadbsi(P_0));
				num = 4;
				break;
			case 4:
				((CvsPropSheet)dni2uYIibagRvDj13r5(InSight)).RunAsync(expr).Wait();
				return;
			default:
				num = 5;
				break;
			case 5:
				return;
			case 0:
			case 3:
				while (!InDialog)
				{
					AlCrrnIWpDDJnB813Hk(FR5AbWIdOTAVvPJphaL(), kgbOBx7BanbFa22Hp9.ol99ukmDA(39838), new object[4]
					{
						CellLocation.ToString(),
						H6kb2YIoLG3S7r3NDu9(P_0).X,
						P_0.Center.Y,
						TBWRg6IP7doCdgadbsi(P_0)
					});
					num = 6;
					if (true)
					{
						goto end_IL_00a0;
					}
				}
				goto case 1;
			case 6:
				return;
				end_IL_00a0:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void t2ktxxGviY(CvsGraphicAnnulus P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (IpyH94IHBYhGjDfvoH1())
		{
			num = 4;
			if (!IpyH94IHBYhGjDfvoH1())
			{
				return;
			}
		}
		else
		{
			num = 3;
		}
		string expr = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				return;
			case 0:
			case 4:
				if (!InDialog)
				{
					AlCrrnIWpDDJnB813Hk(FR5AbWIdOTAVvPJphaL(), kgbOBx7BanbFa22Hp9.ol99ukmDA(40058), new object[5]
					{
						CellLocation.ToString(),
						i1Oel7IY5KBUXbocdwc(P_0).X,
						i1Oel7IY5KBUXbocdwc(P_0).Y,
						Bn1ORNINBtLalK6LkeJ(P_0),
						P_0.OuterRadius
					});
					num = 6;
					break;
				}
				goto case 1;
			case 1:
			case 3:
				expr = (string)AlCrrnIWpDDJnB813Hk(FR5AbWIdOTAVvPJphaL(), Q0lmleIqjfc60k9Svm9(39942), new object[4]
				{
					i1Oel7IY5KBUXbocdwc(P_0).X,
					i1Oel7IY5KBUXbocdwc(P_0).Y,
					Bn1ORNINBtLalK6LkeJ(P_0),
					FO7lQXIxnKm4iEpbcit(P_0)
				});
				num = 2;
				break;
			case 2:
				feYK1lIcZ9faAJ5XYiI(((CvsPropSheet)dni2uYIibagRvDj13r5(InSight)).RunAsync(expr));
				return;
			default:
				num = 5;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void BNTtFUXa7o(CvsGraphicPolygon P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		int num3 = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				num3++;
				kGCoSAIVkRWk9LqT7Sy();
				if (IpyH94IHBYhGjDfvoH1())
				{
					num = 1;
					break;
				}
				num = 9;
				if (0 == 0)
				{
					break;
				}
				goto case 3;
			default:
				if (num2 >= num3)
				{
					num = 10;
					break;
				}
				SendCommand(new OQMAyycVU7MxMTiiXT(P_0, num2 * 250, 250));
				num = 0;
				break;
			case 8:
				num3 = P_0.PointCount / 250;
				num = 7;
				if (!kGCoSAIVkRWk9LqT7Sy())
				{
					break;
				}
				goto case 7;
			case 7:
				if (TnkKMSI1jL7YCtJDxHf(P_0) % 250 != 0)
				{
					num = 2;
					break;
				}
				goto case 1;
			case 1:
			case 4:
				num2 = 0;
				goto default;
			case 3:
				SendCommand(new H63ce2A1Wdn81jAk06(P_0));
				num = 8;
				break;
			case 0:
				num2++;
				num = 6;
				if (1 == 0)
				{
					return;
				}
				break;
			case 10:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void X14tbZYtNZ(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_00b3;
		IL_001a:
		string expr = (string)cCkMPiIj3Zqh7k7KHqs(FR5AbWIdOTAVvPJphaL(), Q0lmleIqjfc60k9Svm9(40178), P_0);
		_ = 0;
		if (IpyH94IHBYhGjDfvoH1())
		{
			num = 0;
			if (!IpyH94IHBYhGjDfvoH1())
			{
				return;
			}
		}
		else
		{
			num = 5;
			if (!IpyH94IHBYhGjDfvoH1())
			{
				goto IL_00ea;
			}
		}
		goto IL_00b3;
		IL_00ea:
		if (!InDialog)
		{
			sHZkpJIBMwnZY5YVky7(FR5AbWIdOTAVvPJphaL(), Q0lmleIqjfc60k9Svm9(40226), CellLocation.ToString(), P_0);
			num = 6;
		}
		else
		{
			num = 4;
			if (1 == 0)
			{
				return;
			}
		}
		goto IL_00b3;
		IL_00b3:
		switch (num)
		{
		case 4:
			break;
		default:
			return;
		case 5:
			return;
		case 0:
		case 2:
			feYK1lIcZ9faAJ5XYiI(((CvsPropSheet)dni2uYIibagRvDj13r5(InSight)).RunAsync(expr));
			return;
		case 1:
			goto IL_00ea;
		case 6:
			return;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nPSdLEIA00mWfr2mU6x()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool IpyH94IHBYhGjDfvoH1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kGCoSAIVkRWk9LqT7Sy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Gbfhk0IDZhWlpTs4Wky(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsColorToolEditorBase)P_0).InvalidateData();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TOQFVHIUbCal4LrLIlF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsColorModel)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GDoTesITLdUmbiQOuEI(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FR5AbWIdOTAVvPJphaL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.InvariantCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dni2uYIibagRvDj13r5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).PropSheet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Q0lmleIqjfc60k9Svm9(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sHZkpJIBMwnZY5YVky7(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((IFormatProvider)P_0, (string)P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cCkMPiIj3Zqh7k7KHqs(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((IFormatProvider)P_0, (string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void feYK1lIcZ9faAJ5XYiI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Task)P_0).Wait();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object n3J9WiI2RNIaPnBKYbU(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((IFormatProvider)P_0, (string)P_1, P_2, P_3, P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AlCrrnIWpDDJnB813Hk(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((IFormatProvider)P_0, (string)P_1, (object[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF tvuINaI7uXO1J0xv0I9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicRegion)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double XCSu7jItfQAWua1DPYY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicRegion)P_0).Width;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double GMSi3FICDRYodRXtJkQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicRegion)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double s1y66jIKFPnry7OXdv9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicRegion)P_0).Curve;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF vxuM7JI5Q0wjwi2Q6Ro(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicPoint)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF H6kb2YIoLG3S7r3NDu9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicCircle)P_0).Center;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float TBWRg6IP7doCdgadbsi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicCircle)P_0).Radius;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PointF i1Oel7IY5KBUXbocdwc(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicAnnulus)P_0).Center;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float Bn1ORNINBtLalK6LkeJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicAnnulus)P_0).InnerRadius;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float FO7lQXIxnKm4iEpbcit(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicAnnulus)P_0).OuterRadius;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int TnkKMSI1jL7YCtJDxHf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicPolygon)P_0).PointCount;
	}
}
