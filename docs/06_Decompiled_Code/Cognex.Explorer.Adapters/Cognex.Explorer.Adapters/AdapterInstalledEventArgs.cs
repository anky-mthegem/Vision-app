using System;
using System.Runtime.CompilerServices;
using b4Zxkh9w1NDrmwo2EQ;

namespace Cognex.Explorer.Adapters;

public class AdapterInstalledEventArgs : EventArgs
{
	[CompilerGenerated]
	private IAdapter QMbTNmiXB;

	internal static AdapterInstalledEventArgs TO8DStXaUqVIi8tywC;

	public IAdapter Adapter
	{
		[CompilerGenerated]
		get
		{
			return QMbTNmiXB;
		}
		[CompilerGenerated]
		private set
		{
			QMbTNmiXB = value;
		}
	}

	public AdapterInstalledEventArgs(IAdapter adapter)
	{
		YmJIsd6U0Ob0UH6n6b.h4GbY9szT1s12();
		base._002Ector();
		int num = 0;
		if (0 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Adapter = adapter;
				num = 0;
				if (1 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool ahWksDNNPNAt2Jh5i0()
	{
		return TO8DStXaUqVIi8tywC == null;
	}

	internal static AdapterInstalledEventArgs SS9CSduM9ZqDk1eiXh()
	{
		return TO8DStXaUqVIi8tywC;
	}
}
