using System.Runtime.CompilerServices;
using Cognex.InSight.Internal;
using Cognex.InSight.Sensor;

namespace Cognex.InSight.Services;

public static class InSightServiceHelpers
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SensorConfiguration CreateSensorConfiguration(CvsInSight inSight)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		CvsProcessorConstants cvsProcessorConstants = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				if (inSight != null)
				{
					LDJ9G75dqohkSbVF0qN();
					num = ((!ilDVww5ipC7oqOjMmQs()) ? 3 : 0);
					break;
				}
				goto default;
			default:
				return null;
			case 1:
			case 3:
				if (A7eXEH5qTjPLtkYIPtL(inSight) != CvsInSightState.NotConnected)
				{
					cvsProcessorConstants = (CvsProcessorConstants)vXufoF5BWoC2XGhDLO8(inSight);
					num = 5;
					break;
				}
				goto default;
			case 5:
			{
				SensorConfiguration sensorConfiguration = new SensorConfiguration();
				FtlSAa52Xq7CcU6EjBD(sensorConfiguration, NVxqZM5cFbkkPGT1jUY(JvEwOG5jixAq7FZe81u(inSight)));
				TUFWnn57wXTLg8bAtZ9(sensorConfiguration, wachru5WxiH9VjUDqlJ(inSight));
				sensorConfiguration.Constants = cvsProcessorConstants;
				sensorConfiguration.Rows = Q9v4cn5tNn83rx4okM7(cvsProcessorConstants);
				AvQq4d5K5g1D43T2ycO(sensorConfiguration, DICt4O5C8NFgq9dy2AC(cvsProcessorConstants));
				sensorConfiguration.MaxExpressionLength = cvsProcessorConstants.MaxExpressionLength;
				return sensorConfiguration;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsInSightState A7eXEH5qTjPLtkYIPtL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).State;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vXufoF5BWoC2XGhDLO8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).ProcessorConstants;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JvEwOG5jixAq7FZe81u(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Sensor;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NVxqZM5cFbkkPGT1jUY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsSensor)P_0).HostName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FtlSAa52Xq7CcU6EjBD(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SensorConfiguration)P_0).HostName = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wachru5WxiH9VjUDqlJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).FunctionTable;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TUFWnn57wXTLg8bAtZ9(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SensorConfiguration)P_0).FunctionTable = (CvsFunctionTable)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Q9v4cn5tNn83rx4okM7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsProcessorConstants)P_0).SpreadsheetRows;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int DICt4O5C8NFgq9dy2AC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsProcessorConstants)P_0).SpreadsheetColumns;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AvQq4d5K5g1D43T2ycO(object P_0, int value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((SensorConfiguration)P_0).Columns = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LDJ9G75dqohkSbVF0qN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ilDVww5ipC7oqOjMmQs()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
