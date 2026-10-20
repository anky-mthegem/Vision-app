using System;
using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.VisionBuilder.Types;

[CvsSerializable("ToolChainProjectInfo")]
public class ProjectInfo
{
	[CompilerGenerated]
	private readonly string ANJhtuyZLy;

	[CompilerGenerated]
	private readonly string S0nhWEYgYV;

	[CompilerGenerated]
	private readonly string Anuh39xmcf;

	[CompilerGenerated]
	private readonly string xUKhLvopPu;

	[CompilerGenerated]
	private readonly int DDQhkimSLu;

	[CompilerGenerated]
	private readonly DateTimeOffset V8YhXxyZXS;

	[JsonProperty]
	public string Id
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ANJhtuyZLy;
		}
	}

	[JsonProperty]
	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return S0nhWEYgYV;
		}
	}

	[JsonProperty]
	public string VersionId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Anuh39xmcf;
		}
	}

	[JsonProperty]
	public string VersionDescription
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xUKhLvopPu;
		}
	}

	[JsonProperty]
	public int VersionIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DDQhkimSLu;
		}
	}

	[JsonProperty]
	public DateTimeOffset VersionCreatedDate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return V8YhXxyZXS;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[JsonConstructor]
	public ProjectInfo(string id, string name, string versionId, string versionDescription, int versionIndex, DateTimeOffset versionCreatedDate)
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
			case 8:
				Anuh39xmcf = versionId;
				goto default;
			default:
				RxVPXPcr46oN6mhpNH0();
				if (!YlvD5Vc31paK7m8Oadf())
				{
					num = 4;
					if (YlvD5Vc31paK7m8Oadf())
					{
					}
				}
				else
				{
					num = 3;
				}
				break;
			case 3:
			case 7:
				V8YhXxyZXS = versionCreatedDate;
				num = 10;
				break;
			case 2:
				tCSAXmcMTBC29lt6227(this);
				num = 9;
				break;
			case 1:
				rG995mcOCOQMwoHmLN4();
				num = 2;
				break;
			case 4:
			case 5:
				xUKhLvopPu = versionDescription;
				num = 6;
				break;
			case 6:
				DDQhkimSLu = versionIndex;
				goto case 3;
			case 0:
				S0nhWEYgYV = name;
				num = 8;
				break;
			case 9:
				ANJhtuyZLy = id;
				num = 0;
				if (false)
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
	public ProjectInfo(string id, string name)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		rG995mcOCOQMwoHmLN4();
		this._002Ector(id, name, "", "", 0, DateTimeOffset.MinValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rG995mcOCOQMwoHmLN4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tCSAXmcMTBC29lt6227(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RxVPXPcr46oN6mhpNH0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YlvD5Vc31paK7m8Oadf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
