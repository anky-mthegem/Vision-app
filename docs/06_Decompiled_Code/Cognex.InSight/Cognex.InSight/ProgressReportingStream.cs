using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

public class ProgressReportingStream : Stream
{
	private double GUmas3Gl4C;

	private long jAOa6FHRY3;

	private long SJTaHPAlHG;

	private IProgress<double?> l3OaK9xISW;

	private CancellationToken jY9aE1NveB;

	private bool eXFaQJ8ANg;

	[CompilerGenerated]
	private readonly Stream BMyaNCOsov;

	public IProgress<double?> Progress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return l3OaK9xISW;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			l3OaK9xISW = value;
		}
	}

	public override bool CanRead
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Xt8AGndHbkJ9hl1TsQg(MqyawoZG8h());
		}
	}

	public override bool CanSeek
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zlGSAsdVFiOPIEory33(MqyawoZG8h());
		}
	}

	public override bool CanWrite
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TqGrshdAl49Kfx0bpNj(MqyawoZG8h());
		}
	}

	public override long Length
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SJTaHPAlHG;
		}
	}

	public override long Position
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return l5WyFqdDqp9v1wJyb2a(MqyawoZG8h());
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			MqyawoZG8h().Position = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void a4sa0wgaxD(long P_0)
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
		goto IL_0081;
		IL_001a:
		double num3 = default;
		double num2 = num3 - GUmas3Gl4C;
		num = 10;
		goto IL_0081;
		IL_0081:
		IProgress<double?> progress = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
				break;
			case 4:
			case 7:
				GUmas3Gl4C = num3;
				num = 5;
				if (!Lk0oQNd9KPn4BfBUlBb())
				{
					continue;
				}
				goto case 6;
			case 6:
				if (num3 == 100.0)
				{
					goto case 4;
				}
				return;
			case 9:
				if (progress != null)
				{
					goto case 1;
				}
				return;
			default:
				num = 1;
				continue;
			case 0:
				num3 = (double)jAOa6FHRY3 * 1.0 / (double)SJTaHPAlHG * 1.0 * 100.0;
				Lk0oQNd9KPn4BfBUlBb();
				if (!Q2ea10dLKpoG3FPNnYQ())
				{
					num = 4;
					if (Q2ea10dLKpoG3FPNnYQ())
					{
						continue;
					}
					goto case 9;
				}
				num = 3;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
				if (!(num2 > 10.0))
				{
					num = 6;
					continue;
				}
				goto case 4;
			case 10:
				progress = l3OaK9xISW;
				num = 9;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				progress.Report(num3);
				num = 11;
				if (!Lk0oQNd9KPn4BfBUlBb())
				{
					continue;
				}
				goto case 8;
			case 8:
				jAOa6FHRY3 += P_0;
				num = 0;
				if (true)
				{
					continue;
				}
				return;
			case 11:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
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
			case 1:
			case 2:
				return;
			case 5:
				eXFaQJ8ANg = true;
				num = 7;
				if (!Lk0oQNd9KPn4BfBUlBb())
				{
					continue;
				}
				goto case 0;
			case 0:
				Uby0TVdSM6gW5k1JkfV(this, disposing);
				num = 6;
				continue;
			case 6:
				if (!eXFaQJ8ANg)
				{
					if (disposing)
					{
						break;
					}
				}
				else
				{
					_ = 1;
					if (!Lk0oQNd9KPn4BfBUlBb())
					{
						num = 1;
						continue;
					}
					num = 4;
					if (!Lk0oQNd9KPn4BfBUlBb())
					{
						continue;
					}
				}
				goto case 5;
			case 7:
				return;
			}
			nQ5tp8dEGvRKSE944Z8(MqyawoZG8h());
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private Stream MqyawoZG8h()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return BMyaNCOsov;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int Read(byte[] buffer, int offset, int count)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Lk0oQNd9KPn4BfBUlBb();
		int num = ((!Q2ea10dLKpoG3FPNnYQ()) ? 1 : 4);
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				num2 = MqyawoZG8h().Read(buffer, offset, count);
				num = 3;
				if (true)
				{
					continue;
				}
				goto default;
			default:
				a4sa0wgaxD(num2);
				num = 5;
				continue;
			case 3:
				if (l3OaK9xISW == null)
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(byte[] buffer, int offset, int count)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		pc8qHudvJGbXkf5bkGU(MqyawoZG8h(), buffer, offset, count);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ProgressReportingStream(Stream s)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Q2ea10dLKpoG3FPNnYQ();
		int num;
		if (!Lk0oQNd9KPn4BfBUlBb())
		{
			num = 2;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
			if (1 == 0)
			{
				return;
			}
		}
		goto IL_0055;
		IL_0055:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 1:
			case 3:
				goto IL_003d;
			default:
				num = 4;
				continue;
			case 0:
			case 2:
				VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
				goto IL_003d;
			case 5:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_003d:
		base._002Ector();
		goto IL_002a;
		IL_002a:
		BMyaNCOsov = s;
		num = 5;
		if (false)
		{
			goto IL_003d;
		}
		goto IL_0055;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Flush()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		vsgpN9dU9FvY1aTblDu(MqyawoZG8h());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override long Seek(long offset, SeekOrigin origin)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GbSy70dTlIdRuLZerwh(MqyawoZG8h(), offset, origin);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetLength(long value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SJTaHPAlHG = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Q2ea10dLKpoG3FPNnYQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Lk0oQNd9KPn4BfBUlBb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Uby0TVdSM6gW5k1JkfV(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Dispose(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nQ5tp8dEGvRKSE944Z8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pc8qHudvJGbXkf5bkGU(object P_0, object P_1, int P_2, int P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Xt8AGndHbkJ9hl1TsQg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Stream)P_0).CanRead;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zlGSAsdVFiOPIEory33(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Stream)P_0).CanSeek;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TqGrshdAl49Kfx0bpNj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Stream)P_0).CanWrite;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long l5WyFqdDqp9v1wJyb2a(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Stream)P_0).Position;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vsgpN9dU9FvY1aTblDu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Flush();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long GbSy70dTlIdRuLZerwh(object P_0, long P_1, SeekOrigin P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Stream)P_0).Seek(P_1, P_2);
	}
}
