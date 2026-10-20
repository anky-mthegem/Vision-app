using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.Extensions;

public static class CollectionHelper
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass0_0<T>
	{
		public EqualityComparer<T> comparer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass0_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CUpdate_003Eb__0(T x, T y)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return comparer.Equals(x, y);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oD9yTwQ8viPpjSlmHuJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qy52FPQF0iSU1cEMRbL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_0<T, K>
	{
		public Func<T, bool> filter;

		public IEnumerable<K> newValues;

		public Func<T, K, bool> comparer;

		public IEnumerable<T> filteredCollection;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass1_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CUpdate_003Eb__0(T x)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return filter?.Invoke(x) ?? true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CUpdate_003Eb__1(T x)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003Ec__DisplayClass1_1<T, K> CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass1_1<T, K>();
			CS_0024_003C_003E8__locals4.CS_0024_003C_003E8__locals1 = this;
			CS_0024_003C_003E8__locals4.x = x;
			return !newValues.Any([MethodImpl(MethodImplOptions.NoInlining)] (K y) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CS_0024_003C_003E8__locals4.CS_0024_003C_003E8__locals1.comparer(CS_0024_003C_003E8__locals4.x, y);
			});
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CUpdate_003Eb__2(K x)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003Ec__DisplayClass1_2<T, K> CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass1_2<T, K>();
			CS_0024_003C_003E8__locals4.CS_0024_003C_003E8__locals2 = this;
			CS_0024_003C_003E8__locals4.x = x;
			return !filteredCollection.Any([MethodImpl(MethodImplOptions.NoInlining)] (T y) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CS_0024_003C_003E8__locals4.CS_0024_003C_003E8__locals2.comparer(y, CS_0024_003C_003E8__locals4.x);
			});
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hGtZ5JQEkQkXPckoFWU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool e26cDQQ5tQI179jJA53()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_1<T, K>
	{
		public T x;

		public _003C_003Ec__DisplayClass1_0<T, K> CS_0024_003C_003E8__locals1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass1_1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CUpdate_003Eb__3(K y)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CS_0024_003C_003E8__locals1.comparer(x, y);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jHWv0uQ3iPpHDZOuidG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Al74ELQaVCyxEbf1D9l()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_2<T, K>
	{
		public K x;

		public _003C_003Ec__DisplayClass1_0<T, K> CS_0024_003C_003E8__locals2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass1_2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CUpdate_003Eb__4(T y)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CS_0024_003C_003E8__locals2.comparer(y, x);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wR97iKQoOs7fpBVFOUv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HVa6l3QchHXsyvKNi92()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0<T, K>
	{
		public Func<T, bool> filter;

		public IEnumerable<K> newValues;

		public Func<T, K, bool> comparer;

		public IEnumerable<T> filteredCollection;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass2_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CUpdateAsync_003Eb__0(T x)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return filter?.Invoke(x) ?? true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CUpdateAsync_003Eb__1(T x)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003Ec__DisplayClass2_1<T, K> CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass2_1<T, K>();
			CS_0024_003C_003E8__locals4.CS_0024_003C_003E8__locals1 = this;
			CS_0024_003C_003E8__locals4.x = x;
			return !newValues.Any([MethodImpl(MethodImplOptions.NoInlining)] (K y) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CS_0024_003C_003E8__locals4.CS_0024_003C_003E8__locals1.comparer(CS_0024_003C_003E8__locals4.x, y);
			});
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CUpdateAsync_003Eb__2(K x)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003Ec__DisplayClass2_2<T, K> CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass2_2<T, K>();
			CS_0024_003C_003E8__locals4.CS_0024_003C_003E8__locals2 = this;
			CS_0024_003C_003E8__locals4.x = x;
			return !filteredCollection.Any([MethodImpl(MethodImplOptions.NoInlining)] (T y) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CS_0024_003C_003E8__locals4.CS_0024_003C_003E8__locals2.comparer(y, CS_0024_003C_003E8__locals4.x);
			});
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sqPw9QQupuuym768iMk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jnRg8KQBsqXbXPwkuFv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_1<T, K>
	{
		public T x;

		public _003C_003Ec__DisplayClass2_0<T, K> CS_0024_003C_003E8__locals1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass2_1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CUpdateAsync_003Eb__3(K y)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CS_0024_003C_003E8__locals1.comparer(x, y);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool K0h9bQQxEESBc6Wn7wb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dbu2kkQhDYiYieRTcWL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_2<T, K>
	{
		public K x;

		public _003C_003Ec__DisplayClass2_0<T, K> CS_0024_003C_003E8__locals2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass2_2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CUpdateAsync_003Eb__4(T y)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CS_0024_003C_003E8__locals2.comparer(y, x);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool k89CsuQU0hLoKCHxPtD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool febi75QQ3Rma5EXwiKc()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUpdateAsync_003Ed__2<T, K> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public Func<T, bool> filter;

		public IEnumerable<K> newValues;

		public Func<T, K, bool> comparer;

		public ICollection<T> collection;

		public Func<K, Task<T>> asyncFactory;

		private List<K>.Enumerator _003C_003E7__wrap1;

		private ICollection<T> _003C_003E7__wrap2;

		private TaskAwaiter<T> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = (true ? 1 : 3);
			int num2 = default;
			bool flag = default;
			TaskAwaiter<T> awaiter = default;
			T result = default;
			K current2 = default;
			bool result2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					try
					{
						if (num2 != 0)
						{
							_003C_003Ec__DisplayClass2_0<T, K> CS_0024_003C_003E8__locals17 = new _003C_003Ec__DisplayClass2_0<T, K>();
							CS_0024_003C_003E8__locals17.filter = filter;
							CS_0024_003C_003E8__locals17.newValues = newValues;
							CS_0024_003C_003E8__locals17.comparer = comparer;
							flag = false;
							CS_0024_003C_003E8__locals17.filteredCollection = collection.Where([MethodImpl(MethodImplOptions.NoInlining)] (T x) =>
							{
								while (false)
								{
									_ = ((object[])null)[0];
								}
								return CS_0024_003C_003E8__locals17.filter?.Invoke(x) ?? true;
							});
							List<T> list = CS_0024_003C_003E8__locals17.filteredCollection.Where([MethodImpl(MethodImplOptions.NoInlining)] (T x) =>
							{
								while (false)
								{
									_ = ((object[])null)[0];
								}
								_003C_003Ec__DisplayClass2_1<T, K> CS_0024_003C_003E8__locals19 = new _003C_003Ec__DisplayClass2_1<T, K>();
								CS_0024_003C_003E8__locals19.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals17;
								CS_0024_003C_003E8__locals19.x = x;
								return !CS_0024_003C_003E8__locals17.newValues.Any([MethodImpl(MethodImplOptions.NoInlining)] (K y) =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									return CS_0024_003C_003E8__locals19.CS_0024_003C_003E8__locals1.comparer(CS_0024_003C_003E8__locals19.x, y);
								});
							}).ToList();
							List<K> list2 = CS_0024_003C_003E8__locals17.newValues.Where([MethodImpl(MethodImplOptions.NoInlining)] (K x) =>
							{
								while (false)
								{
									_ = ((object[])null)[0];
								}
								_003C_003Ec__DisplayClass2_2<T, K> CS_0024_003C_003E8__locals21 = new _003C_003Ec__DisplayClass2_2<T, K>();
								CS_0024_003C_003E8__locals21.CS_0024_003C_003E8__locals2 = CS_0024_003C_003E8__locals17;
								CS_0024_003C_003E8__locals21.x = x;
								return !CS_0024_003C_003E8__locals17.filteredCollection.Any([MethodImpl(MethodImplOptions.NoInlining)] (T y) =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									return CS_0024_003C_003E8__locals21.CS_0024_003C_003E8__locals2.comparer(y, CS_0024_003C_003E8__locals21.x);
								});
							}).ToList();
							List<T>.Enumerator enumerator = list.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									T current = enumerator.Current;
									_ = 0;
									int num3 = ((1 == 0) ? 3 : 2);
									while (true)
									{
										switch (num3)
										{
										default:
											goto IL_00d0;
										case 0:
										case 2:
											collection.Remove(current);
											goto IL_00d0;
										case 4:
											break;
										}
										break;
										IL_00d0:
										flag = true;
										num3 = 4;
									}
								}
							}
							finally
							{
								if (num2 < 0)
								{
									((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
								}
							}
							_003C_003E7__wrap1 = list2.GetEnumerator();
						}
						try
						{
							if (num2 != 0)
							{
								goto IL_02d2;
							}
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							goto IL_01e3;
							IL_01a6:
							int num4;
							while (true)
							{
								switch (num4)
								{
								case 10:
									return;
								case 0:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num4 = 10;
									continue;
								case 1:
									_003C_003E7__wrap2 = collection;
									num4 = 3;
									continue;
								case 5:
									flag = true;
									num4 = 13;
									continue;
								case 9:
								case 12:
									_003C_003E7__wrap2 = null;
									num4 = 5;
									continue;
								case 2:
									result = awaiter.GetResult();
									num4 = 7;
									continue;
								case 7:
									_003C_003E7__wrap2.Add(result);
									goto case 9;
								case 6:
								case 8:
									num2 = (_003C_003E1__state = -1);
									num4 = 2;
									continue;
								case 11:
									num2 = (_003C_003E1__state = 0);
									num4 = 0;
									continue;
								case 4:
									if (!awaiter.IsCompleted)
									{
										num4 = 11;
										continue;
									}
									goto case 2;
								case 3:
									awaiter = asyncFactory(current2).GetAwaiter();
									num4 = 4;
									continue;
								case 13:
									goto IL_02d2;
								}
								break;
							}
							goto IL_01e3;
							IL_02d2:
							if (_003C_003E7__wrap1.MoveNext())
							{
								current2 = _003C_003E7__wrap1.Current;
								num4 = 1;
								goto IL_01a6;
							}
							goto end_IL_0159;
							IL_01e3:
							_ = 0;
							num4 = ((1 == 0) ? 12 : 8);
							goto IL_01a6;
							end_IL_0159:;
						}
						finally
						{
							if (num2 < 0)
							{
								((IDisposable)_003C_003E7__wrap1/*cast due to constrained. prefix*/).Dispose();
							}
						}
						_003C_003E7__wrap1 = default;
						result2 = flag;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					continue;
				case 5:
					return;
				}
				_003C_003Et__builder.SetResult(result2);
				num = 5;
			}
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oRNkXvQq8eeSfcIy2sg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool T8IaytQVTU1HUYTiWyS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Update<T>(this ICollection<T> collection, IEnumerable<T> newValues)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass0_0<T> CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass0_0<T>();
		CS_0024_003C_003E8__locals2.comparer = EqualityComparer<T>.Default;
		return collection.Update(newValues, [MethodImpl(MethodImplOptions.NoInlining)] (T x, T y) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CS_0024_003C_003E8__locals2.comparer.Equals(x, y);
		}, [MethodImpl(MethodImplOptions.NoInlining)] (T x) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return x;
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Update<T, K>(this ICollection<T> collection, IEnumerable<K> newValues, Func<T, K, bool> comparer, Func<K, T> factory, Func<T, bool> filter = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass1_0<T, K> CS_0024_003C_003E8__locals17 = new _003C_003Ec__DisplayClass1_0<T, K>();
		CS_0024_003C_003E8__locals17.filter = filter;
		CS_0024_003C_003E8__locals17.newValues = newValues;
		CS_0024_003C_003E8__locals17.comparer = comparer;
		bool result = false;
		CS_0024_003C_003E8__locals17.filteredCollection = collection.Where([MethodImpl(MethodImplOptions.NoInlining)] (T x) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CS_0024_003C_003E8__locals17.filter?.Invoke(x) ?? true;
		});
		List<T> list = CS_0024_003C_003E8__locals17.filteredCollection.Where([MethodImpl(MethodImplOptions.NoInlining)] (T x) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003Ec__DisplayClass1_1<T, K> CS_0024_003C_003E8__locals19 = new _003C_003Ec__DisplayClass1_1<T, K>();
			CS_0024_003C_003E8__locals19.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals17;
			CS_0024_003C_003E8__locals19.x = x;
			return !CS_0024_003C_003E8__locals17.newValues.Any([MethodImpl(MethodImplOptions.NoInlining)] (K y) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CS_0024_003C_003E8__locals19.CS_0024_003C_003E8__locals1.comparer(CS_0024_003C_003E8__locals19.x, y);
			});
		}).ToList();
		List<K> list2 = CS_0024_003C_003E8__locals17.newValues.Where([MethodImpl(MethodImplOptions.NoInlining)] (K x) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003Ec__DisplayClass1_2<T, K> CS_0024_003C_003E8__locals21 = new _003C_003Ec__DisplayClass1_2<T, K>();
			CS_0024_003C_003E8__locals21.CS_0024_003C_003E8__locals2 = CS_0024_003C_003E8__locals17;
			CS_0024_003C_003E8__locals21.x = x;
			return !CS_0024_003C_003E8__locals17.filteredCollection.Any([MethodImpl(MethodImplOptions.NoInlining)] (T y) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return CS_0024_003C_003E8__locals21.CS_0024_003C_003E8__locals2.comparer(y, CS_0024_003C_003E8__locals21.x);
			});
		}).ToList();
		foreach (T item in list)
		{
			collection.Remove(item);
			result = true;
		}
		foreach (K item2 in list2)
		{
			collection.Add(factory(item2));
			result = true;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUpdateAsync_003Ed__2<, >))]
	public static Task<bool> UpdateAsync<T, K>(this ICollection<T> collection, IEnumerable<K> newValues, Func<T, K, bool> comparer, Func<K, Task<T>> asyncFactory, Func<T, bool> filter = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CUpdateAsync_003Ed__2<T, K> stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine.collection = collection;
		stateMachine.newValues = newValues;
		stateMachine.comparer = comparer;
		stateMachine.asyncFactory = asyncFactory;
		stateMachine.filter = filter;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}
}
