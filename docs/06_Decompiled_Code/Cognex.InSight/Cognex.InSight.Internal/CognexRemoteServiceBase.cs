using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

public abstract class CognexRemoteServiceBase<T>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		public CognexRemoteServiceBase<T> _003C_003E4__this;

		public string reference;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass0_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal T _003CGetAsync_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003E4__this.Get(reference);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hVEh2JsejTSuCymrMUFK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool d4EfQoseceyZN1xxnFpA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task<T> GetAsync(string reference)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass0_0 obj = new _003C_003Ec__DisplayClass0_0();
		obj._003C_003E4__this = this;
		obj.reference = reference;
		return Task.Run([MethodImpl(MethodImplOptions.NoInlining)] () =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return obj._003C_003E4__this.Get(obj.reference);
		});
	}

	public abstract T Get(string reference);

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected CognexRemoteServiceBase()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vusuQ86Dk3TQsl6EM4D()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zdQX6R6UjScF8hQXKHb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
