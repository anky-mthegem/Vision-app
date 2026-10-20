using System;
using System.Net;
using System.Runtime.CompilerServices;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.VisionBuilder.Exceptions;

public class VisionBuilderApiHttpException : Exception
{
	[CompilerGenerated]
	private HttpStatusCode NkUhSfiNjY;

	public HttpStatusCode StatusCode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return NkUhSfiNjY;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NkUhSfiNjY = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VisionBuilderApiHttpException(string message, HttpStatusCode httpStatusCode, Exception innerException = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0045;
		IL_001a:
		StatusCode = httpStatusCode;
		num = 5;
		goto IL_0045;
		IL_0045:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				base._002Ector(message, innerException);
				break;
			case 3:
				do
				{
					VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
					JPVU082AQ0IHHFIwO4v();
					if (LfBKxP2DGisufxYHafj())
					{
						num = 4;
						continue;
					}
					num = 0;
					if (true)
					{
						break;
					}
					return;
				}
				while (1 == 0);
				continue;
			case 5:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JPVU082AQ0IHHFIwO4v()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LfBKxP2DGisufxYHafj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
