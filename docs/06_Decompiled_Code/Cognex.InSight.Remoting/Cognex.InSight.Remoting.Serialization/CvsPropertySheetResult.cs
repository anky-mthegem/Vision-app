using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Remoting.Serialization;

[CvsSerializable(JsonName = "PropertySheetResult")]
public class CvsPropertySheetResult
{
	[CompilerGenerated]
	private string KU0F4Wqn9Q;

	[CompilerGenerated]
	private int LQSF2XcoYi;

	[CompilerGenerated]
	private CvsCogView[] VhcFXIqEt6;

	[CompilerGenerated]
	private CvsPropertySheetArg[] qIyFqGKIAu;

	[CompilerGenerated]
	private object rL3FJPH6cI;

	[CompilerGenerated]
	private string tdDFKMwVZZ;

	[CompilerGenerated]
	private string nsfFRKT0ii;

	[JsonProperty(PropertyName = "expression", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Expression
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KU0F4Wqn9Q;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KU0F4Wqn9Q = value;
		}
	}

	[JsonProperty(PropertyName = "argumentFlags", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int ArgumentFlags
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LQSF2XcoYi;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			LQSF2XcoYi = value;
		}
	}

	[JsonProperty(PropertyName = "views", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public CvsCogView[] Views
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return VhcFXIqEt6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VhcFXIqEt6 = value;
		}
	}

	[JsonProperty(PropertyName = "arguments", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public CvsPropertySheetArg[] Arguments
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qIyFqGKIAu;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			qIyFqGKIAu = value;
		}
	}

	[JsonProperty(PropertyName = "value", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rL3FJPH6cI;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rL3FJPH6cI = value;
		}
	}

	[JsonProperty(PropertyName = "inputImageViewTitle", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string InputViewName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tdDFKMwVZZ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			tdDFKMwVZZ = value;
		}
	}

	[JsonProperty(PropertyName = "inputPointCloudViewTitle", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string InputPointCloudViewName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return nsfFRKT0ii;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			nsfFRKT0ii = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsPropertySheetResult()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsPropertySheetResult(string expr, CvsPropertySheetArg[] args)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!nptp0J4XSxKfEYQvqkk())
		{
			num = 1;
		}
		else
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_0091;
			}
		}
		goto IL_005e;
		IL_005e:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				V8x0VW4lYUiUtXyZSIY();
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				uGMElb4OCVkjBehJlZm(this);
				num = 2;
				continue;
			case 2:
				Expression = expr;
				break;
			case 6:
				return;
			}
			break;
		}
		goto IL_0091;
		IL_0091:
		Arguments = args;
		num = 6;
		goto IL_005e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool L01tfq47EnoN9jZkrVA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nptp0J4XSxKfEYQvqkk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void V8x0VW4lYUiUtXyZSIY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.XRor6nLzdSo1Z();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uGMElb4OCVkjBehJlZm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}
}
