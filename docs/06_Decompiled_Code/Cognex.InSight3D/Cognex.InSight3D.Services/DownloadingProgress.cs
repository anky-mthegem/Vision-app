using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using AkHicK0bA1TrKhYAY7;
using GHWKpuG7rE0PZAeeF5;

namespace Cognex.InSight3D.Services;

public class DownloadingProgress : IProgress<double?>
{
	[CompilerGenerated]
	private double? BVSv33x5c;

	[CompilerGenerated]
	private PropertyChangedEventHandler oGkTiwuvq;

	public double? Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return BVSv33x5c;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			BVSv33x5c = value;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			PropertyChangedEventHandler propertyChangedEventHandler = default;
			PropertyChangedEventHandler value2 = default;
			PropertyChangedEventHandler propertyChangedEventHandler2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					propertyChangedEventHandler = Interlocked.CompareExchange(ref oGkTiwuvq, value2, propertyChangedEventHandler2);
					num = 1;
					break;
				case 1:
					if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						num = 7;
						break;
					}
					goto case 4;
				case 5:
					propertyChangedEventHandler = oGkTiwuvq;
					num = 4;
					break;
				case 4:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					rv1XXRWEqopmkTmpYp();
					if (!AU0TXpybFvVY7RCENu())
					{
						num = 0;
						if (0 == 0)
						{
							break;
						}
						goto case 0;
					}
					num = 6;
					break;
				case 0:
				case 2:
					value2 = (PropertyChangedEventHandler)Ke21ctQICPG9b3qrZG(propertyChangedEventHandler2, value);
					goto default;
				case 7:
					return;
				}
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			PropertyChangedEventHandler propertyChangedEventHandler2 = default;
			PropertyChangedEventHandler propertyChangedEventHandler = default;
			PropertyChangedEventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					AU0TXpybFvVY7RCENu();
					num = (rv1XXRWEqopmkTmpYp() ? 1 : 5);
					continue;
				case 6:
					if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						num = 7;
						continue;
					}
					goto case 0;
				case 1:
				case 2:
					value2 = (PropertyChangedEventHandler)W74bmcLhREreh9Y5xU(propertyChangedEventHandler2, value);
					break;
				case 4:
					propertyChangedEventHandler = oGkTiwuvq;
					num = 0;
					continue;
				case 7:
					return;
				}
				propertyChangedEventHandler = Interlocked.CompareExchange(ref oGkTiwuvq, value2, propertyChangedEventHandler2);
				num = 6;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Report(double? value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Value = value;
		oGkTiwuvq?.Invoke(this, new PropertyChangedEventArgs(M8HpnnnUdjcJPbDHVy.hDZtYXyjFS(0)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DownloadingProgress()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		senuNgdYlUdb5PCjMB();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ke21ctQICPG9b3qrZG(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rv1XXRWEqopmkTmpYp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AU0TXpybFvVY7RCENu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object W74bmcLhREreh9Y5xU(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void senuNgdYlUdb5PCjMB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KB0d0xocsRSAORFNZ9.RtXkSdpzVJ2P6();
	}
}
