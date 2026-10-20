using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cognex.InSight.Remoting.Serialization;
using Cognex.Remoting.CogSocket;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

public class CvsCogSocketNullAcq : ICogSocketAcq, ICogSocketAcqProperties
{
	[CompilerGenerated]
	private readonly string IMn1qEFo9a;

	[CompilerGenerated]
	private bool sje1TkLhB9;

	[CompilerGenerated]
	private string fUd1BCFJdJ;

	[CompilerGenerated]
	private EventHandler LkS1JMquiN;

	[CompilerGenerated]
	private EventHandler J711Mh4Ah0;

	[CompilerGenerated]
	private EventHandler<CogSocketEventArgs> unr1ojGMNH;

	[CompilerGenerated]
	private EventHandler<CogSocketEventArgs> IRK1AubdJC;

	[CompilerGenerated]
	private EventHandler<CogSocketEventArgs> x9E1twX2xi;

	public string AcqPath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return IMn1qEFo9a;
		}
	}

	public bool IsLiveAcquisition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return sje1TkLhB9;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sje1TkLhB9 = value;
		}
	}

	public string LatestAcqImageUrl
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fUd1BCFJdJ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fUd1BCFJdJ = value;
		}
	}

	public event EventHandler ImageReady
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			if (!rQN3Ev9gV4La2Gin7Ip())
			{
			}
			EventHandler eventHandler2 = default;
			EventHandler value2 = default;
			EventHandler eventHandler = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					eventHandler2 = Interlocked.CompareExchange(ref LkS1JMquiN, value2, eventHandler);
					goto case 2;
				case 6:
					eventHandler = eventHandler2;
					num = 5;
					if (true)
					{
						continue;
					}
					goto case 2;
				case 2:
				case 4:
					if ((object)eventHandler2 == eventHandler)
					{
						num = 7;
						continue;
					}
					goto case 6;
				case 5:
					value2 = (EventHandler)Delegate.Combine(eventHandler, value);
					goto default;
				default:
					_ = 1;
					if (rQN3Ev9gV4La2Gin7Ip())
					{
						num = 2;
						if (true)
						{
							continue;
						}
						goto case 6;
					}
					num = 0;
					if (true)
					{
						continue;
					}
					break;
				case 1:
					break;
				case 7:
					return;
				}
				eventHandler2 = LkS1JMquiN;
				num = 6;
				if (rQN3Ev9gV4La2Gin7Ip())
				{
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
			int num = 5;
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					eventHandler2 = eventHandler;
					_ = 0;
					if (blX1UJ9yiM9EvVI8syV())
					{
						num = 1;
						break;
					}
					num = 6;
					if (blX1UJ9yiM9EvVI8syV())
					{
						break;
					}
					goto case 5;
				case 1:
				case 2:
					value2 = (EventHandler)ImRtgy9zCCfsaBAZAQm(eventHandler2, value);
					goto default;
				case 5:
					eventHandler = LkS1JMquiN;
					num = 0;
					break;
				default:
					eventHandler = Interlocked.CompareExchange(ref LkS1JMquiN, value2, eventHandler2);
					num = 4;
					break;
				case 4:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						break;
					}
					goto case 0;
				case 7:
					return;
				}
			}
		}
	}

	public event EventHandler PointCloudReady
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
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					eventHandler = J711Mh4Ah0;
					num = 6;
					continue;
				case 2:
				case 3:
					eventHandler = Interlocked.CompareExchange(ref J711Mh4Ah0, value2, eventHandler2);
					goto case 1;
				case 1:
				case 4:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						continue;
					}
					goto case 6;
				case 6:
					eventHandler2 = eventHandler;
					num = 0;
					if (blX1UJ9yiM9EvVI8syV())
					{
						continue;
					}
					goto case 0;
				case 0:
					value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					break;
				case 7:
					return;
				}
				blX1UJ9yiM9EvVI8syV();
				num = (rQN3Ev9gV4La2Gin7Ip() ? 1 : 2);
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
			_ = 1;
			int num;
			if (!rQN3Ev9gV4La2Gin7Ip())
			{
				num = 3;
			}
			else
			{
				num = 6;
				if (rQN3Ev9gV4La2Gin7Ip())
				{
				}
			}
			EventHandler eventHandler2 = default;
			EventHandler value2 = default;
			EventHandler eventHandler = default;
			do
			{
				IL_008d:
				switch (num)
				{
				case 0:
				case 3:
					eventHandler2 = J711Mh4Ah0;
					break;
				case 5:
					eventHandler2 = Interlocked.CompareExchange(ref J711Mh4Ah0, value2, eventHandler);
					num = 2;
					goto IL_008d;
				case 2:
					if ((object)eventHandler2 == eventHandler)
					{
						num = 7;
						goto IL_008d;
					}
					break;
				case 4:
					value2 = (EventHandler)ImRtgy9zCCfsaBAZAQm(eventHandler, value);
					goto case 5;
				default:
					num = 5;
					goto IL_008d;
				case 1:
				case 6:
					break;
				case 7:
					return;
				}
				eventHandler = eventHandler2;
				num = 4;
			}
			while (true);
		}
	}

	public event EventHandler<CogSocketEventArgs> AcquisitionErrorReceived
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<CogSocketEventArgs> eventHandler = unr1ojGMNH;
			EventHandler<CogSocketEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CogSocketEventArgs> value2 = (EventHandler<CogSocketEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref unr1ojGMNH, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<CogSocketEventArgs> eventHandler = unr1ojGMNH;
			EventHandler<CogSocketEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CogSocketEventArgs> value2 = (EventHandler<CogSocketEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref unr1ojGMNH, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<CogSocketEventArgs> SettingChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<CogSocketEventArgs> eventHandler = IRK1AubdJC;
			EventHandler<CogSocketEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CogSocketEventArgs> value2 = (EventHandler<CogSocketEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref IRK1AubdJC, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<CogSocketEventArgs> eventHandler = IRK1AubdJC;
			EventHandler<CogSocketEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CogSocketEventArgs> value2 = (EventHandler<CogSocketEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref IRK1AubdJC, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<CogSocketEventArgs> PropertyDescriptorsChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<CogSocketEventArgs> eventHandler = x9E1twX2xi;
			EventHandler<CogSocketEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CogSocketEventArgs> value2 = (EventHandler<CogSocketEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref x9E1twX2xi, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<CogSocketEventArgs> eventHandler = x9E1twX2xi;
			EventHandler<CogSocketEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<CogSocketEventArgs> value2 = (EventHandler<CogSocketEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref x9E1twX2xi, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogSocketNullAcq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Y0XvhF9ZNaJccClRjNR();
		LkS1JMquiN = [MethodImpl(MethodImplOptions.NoInlining)] (object obj, EventArgs e) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
		};
		J711Mh4Ah0 = [MethodImpl(MethodImplOptions.NoInlining)] (object obj, EventArgs e) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
		};
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task AddListenersAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task RemoveListenersAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)lqLXap9JShXfdav46np();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task ResetToDefaults()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task EnableTrigger()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)lqLXap9JShXfdav46np();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task DisableTrigger()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)lqLXap9JShXfdav46np();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<object[]> PrivateAcquisition(string format, string clientId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.FromResult(new object[0]);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task CancelAllAcquisitions()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)lqLXap9JShXfdav46np();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task ManualTriggerAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)lqLXap9JShXfdav46np();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualTrigger(bool block = true)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogAcqSettings GetAcqSettings()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsCogAcqSettings();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<T> GetAcqSetting<T>(string propertyName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.FromResult<T>(default);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task PutAcqSetting<T>(string propertyName, T propertyValue)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task PutFocusRegionSetting(CvsCogRegion region)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)lqLXap9JShXfdav46np();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsCogRegion> GetFocusRegionBounds()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.FromResult<CvsCogRegion>(null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<double> GetAcqFocusPositionResolution()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.FromResult(0.0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetAcqFocusAttached()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetAcqIlluminationDetected()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<bool> GetAcqWhiteBalanceSupported()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.FromResult(result: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<bool> AcceptsPointCloudsAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.FromResult(result: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogAcqProperties GetAcqProperties()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCogAcqProperties cvsCogAcqProperties = new CvsCogAcqProperties();
		VW4Lvj98IrYkQdtFlRQ(cvsCogAcqProperties, 960);
		cvsCogAcqProperties.SensorWidth = 1280;
		return cvsCogAcqProperties;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsCogImage> GetAcqImageProperties()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.FromResult<CvsCogImage>(null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsCogAcquisitionStatus> GetAcqStatus()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.FromResult<CvsCogAcquisitionStatus>(null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsCogRef> GetLastImageRef()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.FromResult<CvsCogRef>(null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoAutofocus()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoAutoWhiteBalance()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task DoAutoExposure()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)lqLXap9JShXfdav46np();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task DoAutoROI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)lqLXap9JShXfdav46np();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task PutWhiteBalanceRegionSetting(CvsCogRegion region)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)lqLXap9JShXfdav46np();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task ReleaseImageAsync(string imageUrl)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PostImageByHTTP(Bitmap bmp)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<string> CreateImageAsync(Bitmap bmp)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.FromResult<string>(null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IEnumerable<UntypedDescribedProperty>> GetAllProperties()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.FromResult(Enumerable.Empty<UntypedDescribedProperty>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task SetPropertyValue<T>(UntypedDescribedProperty property, T value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<T> GetPropertyValue<T>(UntypedDescribedProperty property)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.FromResult<T>(default);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task ResetAcqSettingToDefault()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogIlluminationObject GetAcqIlluminationObject()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task Execute(CogSocketActionPath action)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Task)lqLXap9JShXfdav46np();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IEnumerable<CvsCogPropertyDescriptorGroup>> GetEditableProperties()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.FromResult(Enumerable.Empty<CvsCogPropertyDescriptorGroup>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task SetPropertyValue<T>(CvsCogPropertyDescriptor property, T value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<T> GetPropertyValue<T>(CvsCogPropertyDescriptor property)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.FromResult<T>(default);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<bool> Is2DLineScanAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.FromResult(result: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<string> GetSettingsId()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.FromResult<string>(null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Y0XvhF9ZNaJccClRjNR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool blX1UJ9yiM9EvVI8syV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rQN3Ev9gV4La2Gin7Ip()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lqLXap9JShXfdav46np()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VW4Lvj98IrYkQdtFlRQ(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogAcqProperties)P_0).SensorHeight = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ImRtgy9zCCfsaBAZAQm(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}
}
