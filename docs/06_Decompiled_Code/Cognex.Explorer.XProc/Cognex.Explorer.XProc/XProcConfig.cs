using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;
using System.Runtime.Serialization.Formatters;
using JK709E3DnFfvLewQUh;
using NXRr4J0uHSUowNMpIG;

namespace Cognex.Explorer.XProc;

public static class XProcConfig
{
	private class TVC41BymvvevRRuIFY : IClientChannelSinkProvider
	{
		private readonly IClientChannelSinkProvider p1IjvmlPE;

		private readonly string ciXYviy4D;

		private static TVC41BymvvevRRuIFY FoPp4nEcRcgbBad1Ca;

		public IClientChannelSinkProvider Next
		{
			get
			{
				return (IClientChannelSinkProvider)GvHkfEdasUoL9cnDMp(p1IjvmlPE);
			}
			set
			{
				p1IjvmlPE.Next = next;
			}
		}

		internal TVC41BymvvevRRuIFY(IClientChannelSinkProvider P_0, string P_1)
		{
			P72r2cmcNm3BJYykhQ.cXSFj2LzQpSyU();
			base._002Ector();
			int num = 1;
			if (1 == 0)
			{
				goto IL_0026;
			}
			goto IL_002a;
			IL_0026:
			int num2 = default;
			num = num2;
			goto IL_002a;
			IL_002a:
			while (true)
			{
				switch (num)
				{
				case 2:
					return;
				case 1:
					break;
				case 3:
					throw new ArgumentNullException((string)WfOoG3sHpxpdGCjJi3(278));
				default:
					throw new ArgumentNullException(Ey4DP8Q8YupTAlWZrx.ra7GaQ663(298));
				}
				if (P_0 == null)
				{
					num = 3;
					continue;
				}
				if (Uete89Jm2GjqMeGwOM(P_1))
				{
					num = 0;
					if (1 == 0)
					{
						num = 0;
					}
					continue;
				}
				p1IjvmlPE = P_0;
				ciXYviy4D = (string)FqA2rSl5ygke260qlf(Ey4DP8Q8YupTAlWZrx.ra7GaQ663(306), P_1);
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				break;
			}
			goto IL_0026;
		}

		public IClientChannelSink CreateSink(IChannelSender P_0, string P_1, object P_2)
		{
			if (!GZNn6EcR5aH0uTFKdr(P_1, ciXYviy4D))
			{
				return null;
			}
			return p1IjvmlPE.CreateSink(P_0, P_1, P_2);
		}

		internal static object WfOoG3sHpxpdGCjJi3(int P_0)
		{
			return Ey4DP8Q8YupTAlWZrx.ra7GaQ663(P_0);
		}

		internal static bool Uete89Jm2GjqMeGwOM(object P_0)
		{
			return string.IsNullOrEmpty((string)P_0);
		}

		internal static object FqA2rSl5ygke260qlf(object P_0, object P_1)
		{
			return (string)P_0 + (string)P_1;
		}

		internal static bool y2CFSdwgxsMbuLcPCX()
		{
			return FoPp4nEcRcgbBad1Ca == null;
		}

		internal static TVC41BymvvevRRuIFY wlOGwmXg3anZlR43ZG()
		{
			return FoPp4nEcRcgbBad1Ca;
		}

		internal static object GvHkfEdasUoL9cnDMp(object P_0)
		{
			return ((IClientChannelSinkProvider)P_0).Next;
		}

		internal static bool GZNn6EcR5aH0uTFKdr(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}
	}

	internal static XProcConfig PJ0SiWBExAH0Q83NAv;

	public static void RegisterService<TService>(TService service, string serviceName) where TService : MarshalByRefObject
	{
		RemotingServices.Marshal(service, serviceName);
	}

	public static void RegisterChannel(bool childProcess, string id)
	{
		int num = 5;
		string text3 = default;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				string text;
				string text2;
				switch (num2)
				{
				case 5:
					text3 = id + (string)D1LcL4p5VrU9WScntm(236);
					num2 = 4;
					if (!H2r9S5eaPlpwZphCsG())
					{
						num2 = 1;
					}
					continue;
				default:
					text = text3;
					goto IL_00ef;
				case 2:
					if (childProcess)
					{
						num2 = 3;
						if (!H2r9S5eaPlpwZphCsG())
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				case 4:
					if (!childProcess)
					{
						num2 = 1;
						if (oRoNao8vHaET3YALhT() == null)
						{
							continue;
						}
						break;
					}
					text2 = text3;
					goto IL_00d4;
				case 1:
					text2 = id;
					goto IL_00d4;
				case 3:
					{
						text = id;
						goto IL_00ef;
					}
					IL_00d4:
					i55D8yLrDqDgdqDOBX(text2);
					num2 = 2;
					if (H2r9S5eaPlpwZphCsG())
					{
						continue;
					}
					break;
					IL_00ef:
					aQnxu7Kss(text);
					return;
				}
				break;
			}
		}
	}

	private static void he2IveY83(string P_0)
	{
		int num = 1;
		BinaryClientFormatterSinkProvider binaryClientFormatterSinkProvider = default;
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
					ChannelServices.RegisterChannel(new IpcClientChannel(P_0, new TVC41BymvvevRRuIFY(binaryClientFormatterSinkProvider, P_0)), ensureSecurity: false);
					return;
				case 1:
					break;
				}
				binaryClientFormatterSinkProvider = new BinaryClientFormatterSinkProvider();
				num2 = 0;
			}
			while (H2r9S5eaPlpwZphCsG());
		}
	}

	private static void aQnxu7Kss(string P_0)
	{
		BinaryServerFormatterSinkProvider sinkProvider = new BinaryServerFormatterSinkProvider
		{
			TypeFilterLevel = TypeFilterLevel.Full
		};
		lGVHTE1YBshCVn68L5(new IpcServerChannel(P_0, P_0, sinkProvider), false);
		int num = 0;
		if (!H2r9S5eaPlpwZphCsG())
		{
			int num2 = default;
			num = num2;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object D1LcL4p5VrU9WScntm(int P_0)
	{
		return Ey4DP8Q8YupTAlWZrx.ra7GaQ663(P_0);
	}

	internal static void i55D8yLrDqDgdqDOBX(object P_0)
	{
		he2IveY83((string)P_0);
	}

	internal static bool H2r9S5eaPlpwZphCsG()
	{
		return PJ0SiWBExAH0Q83NAv == null;
	}

	internal static XProcConfig oRoNao8vHaET3YALhT()
	{
		return PJ0SiWBExAH0Q83NAv;
	}

	internal static void lGVHTE1YBshCVn68L5(object P_0, bool P_1)
	{
		ChannelServices.RegisterChannel((IChannel)P_0, P_1);
	}
}
