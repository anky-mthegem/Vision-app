using System;
using System.Annotations;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsChildSerializable]
public abstract class TypedPropertyBag
{
	[CompilerGenerated]
	private Dictionary<string, JToken> DI6ruUC918;

	[CompilerGenerated]
	private JObject QHRrZwp4DJ;

	[JsonExtensionData]
	[UsedImplicitly]
	private Dictionary<string, JToken> wlsrwMA1sx
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DI6ruUC918;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			DI6ruUC918 = value;
		}
	}

	public JObject PropertyBag
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return QHRrZwp4DJ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QHRrZwp4DJ = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[OnDeserialized]
	private void mhmr8ImD8F(StreamingContext P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		Dictionary<string, JToken>.Enumerator enumerator = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				if (wlsrwMA1sx == null)
				{
					return;
				}
				enumerator = wlsrwMA1sx.GetEnumerator();
				num = 5;
				break;
			default:
				return;
			case 4:
				do
				{
					PropertyBag = new JObject();
					nWSFx3hdILihgAjCqjf();
					if (!RQZgqQhnU71lAwN13Po())
					{
						num = 0;
						continue;
					}
					num = 3;
					break;
				}
				while (false);
				break;
			case 0:
				return;
			case 5:
				try
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, JToken> current = enumerator.Current;
						_ = 1;
						int num2;
						if (!nWSFx3hdILihgAjCqjf())
						{
							num2 = 2;
						}
						else
						{
							num2 = 3;
							if (nWSFx3hdILihgAjCqjf())
							{
								continue;
							}
						}
						switch (num2)
						{
						case 0:
						case 2:
							vEQ1uthkTR2wKLXqBl8(PropertyBag, current.Key, current.Value);
							break;
						}
					}
					return;
				}
				finally
				{
					((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected T ConvertToInstance<T>()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PropertyBag.ToObject<T>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected TypedPropertyBag()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
		rIN2nxhMEaDy7qZ9yFe(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RQZgqQhnU71lAwN13Po()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nWSFx3hdILihgAjCqjf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vEQ1uthkTR2wKLXqBl8(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((JObject)P_0)[(string)P_1] = (JToken?)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rIN2nxhMEaDy7qZ9yFe(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
