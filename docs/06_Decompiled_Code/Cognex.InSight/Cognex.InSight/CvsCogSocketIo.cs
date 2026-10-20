using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cognex.InSight.Remoting.Serialization;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

public class CvsCogSocketIo
{
	private readonly ResourceNode iE21gkxLp9;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCogSocketIo(ResourceNode ioResource)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		O89VHp9fk2vdCIZ1ReN();
		int num;
		if (C0EVDa9kRfcAZQghQC7())
		{
			num = 1;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
			if (O89VHp9fk2vdCIZ1ReN())
			{
			}
		}
		goto IL_006c;
		IL_002a:
		iE21gkxLp9 = ioResource;
		num = 5;
		if (O89VHp9fk2vdCIZ1ReN())
		{
		}
		goto IL_006c;
		IL_006c:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				goto IL_0045;
			case 4:
				RM9Hkt9mZKphvjNKubX(this);
				break;
			case 5:
				return;
			}
			break;
			IL_0045:
			Mfl3vk9FgFxWnNATImi();
			num = 4;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<T> GetIoSetting<T>(string propertyName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return iE21gkxLp9.GetAsync<T>(propertyName);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task PutIoSetting<T>(string propertyName, T propertyValue)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return iE21gkxLp9.PutAsync<T>(propertyName, propertyValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsCogIoSettings> GetIoSettings()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IResourceUriProvider)iE21gkxLp9).DeviceApi.GetAsync<CvsCogIoSettings>(iE21gkxLp9.GetRootWithoutSeparator());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Mfl3vk9FgFxWnNATImi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RM9Hkt9mZKphvjNKubX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool C0EVDa9kRfcAZQghQC7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool O89VHp9fk2vdCIZ1ReN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
