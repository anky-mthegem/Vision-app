using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Cognex.Cnx.Data.Implementation;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

[Serializable]
public class CvsCellInfoCollection : IEnumerable, INamedOperandCollection, IEnumerable<INamedOperand>
{
	[CompilerGenerated]
	private sealed class _003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CCognex_002DInSight_002DINamedOperand_003E_002DGetEnumerator_003Ed__19 : IEnumerator<INamedOperand>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private INamedOperand _003C_003E2__current;

		public CvsCellInfoCollection _003C_003E4__this;

		private IEnumerator _003C_003E7__wrap1;

		INamedOperand IEnumerator<INamedOperand>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003E2__current;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public _003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CCognex_002DInSight_002DINamedOperand_003E_002DGetEnumerator_003Ed__19(int _003C_003E1__state)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			e2lyOPZ8Rq0icguBtLg();
			int num;
			if (kHbQ6MZJrM3ietHK92Y())
			{
				num = 4;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 2;
				if (e2lyOPZ8Rq0icguBtLg())
				{
					goto IL_0084;
				}
			}
			goto IL_0042;
			IL_0084:
			this._003C_003E1__state = _003C_003E1__state;
			num = 5;
			if (e2lyOPZ8Rq0icguBtLg())
			{
				return;
			}
			goto IL_0042;
			IL_0042:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					break;
				default:
					num = 3;
					continue;
				case 0:
				case 4:
					eynBZFZzB2ORk4h6X7C();
					break;
				case 3:
					goto IL_0084;
				case 5:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_002a:
			base._002Ector();
			goto IL_0084;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					if (num2 == 1)
					{
						num = 5;
						continue;
					}
					return;
				case 4:
					num2 = _003C_003E1__state;
					_ = 1;
					if (!e2lyOPZ8Rq0icguBtLg())
					{
						num = 3;
						if (true)
						{
							continue;
						}
						goto case 1;
					}
					num = 0;
					continue;
				case 1:
				case 3:
					if (num2 == -3)
					{
						break;
					}
					goto default;
				case 5:
					break;
				}
				try
				{
					break;
				}
				finally
				{
					_003C_003Em__Finally1();
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bool result = default;
			try
			{
				int num = _003C_003E1__state;
				int num2 = 6;
				CvsCellInfoCollection cvsCellInfoCollection = default;
				object obj = default;
				while (true)
				{
					switch (num2)
					{
					default:
						num2 = 13;
						continue;
					case 1:
					case 4:
						_003C_003E1__state = -3;
						num2 = 7;
						continue;
					case 6:
						cvsCellInfoCollection = _003C_003E4__this;
						num2 = 2;
						continue;
					case 13:
						_003C_003E2__current = (INamedOperand)obj;
						_003C_003E1__state = 1;
						num2 = 11;
						continue;
					case 9:
						break;
					case 11:
						result = true;
						num2 = 9;
						continue;
					case 2:
						if (num != 0)
						{
							num2 = 12;
							continue;
						}
						_003C_003E1__state = -1;
						_003C_003E7__wrap1 = ((IEnumerable)cvsCellInfoCollection.GAkIN9804X).GetEnumerator();
						e2lyOPZ8Rq0icguBtLg();
						num2 = (kHbQ6MZJrM3ietHK92Y() ? 1 : 8);
						continue;
					case 8:
					case 10:
						_003C_003Em__Finally1();
						num2 = 0;
						continue;
					case 12:
						if (num == 1)
						{
							_003C_003E1__state = -3;
							num2 = 5;
						}
						else
						{
							num2 = 3;
						}
						continue;
					case 0:
						_003C_003E7__wrap1 = null;
						num2 = 14;
						if (kHbQ6MZJrM3ietHK92Y())
						{
							continue;
						}
						goto case 5;
					case 5:
					case 7:
						if (FMW9YyJsEPMDi351WXC(_003C_003E7__wrap1))
						{
							obj = bvlIqYJw7yBXRf7LQwP(_003C_003E7__wrap1);
							goto case 13;
						}
						goto case 8;
					case 3:
						result = false;
						break;
					case 14:
						result = false;
						break;
					}
					break;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
			return result;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _003C_003Em__Finally1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (kHbQ6MZJrM3ietHK92Y())
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_007d;
			IL_0026:
			_003C_003E1__state = -1;
			num = 1;
			if (false)
			{
				goto IL_0039;
			}
			goto IL_007d;
			IL_007d:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					break;
				case 1:
					goto IL_0039;
				case 4:
					goto IL_0055;
				case 2:
				case 5:
					goto IL_0065;
				default:
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0039:
			IDisposable disposable = _003C_003E7__wrap1 as IDisposable;
			goto IL_0065;
			IL_0055:
			TLGLISJhNx55XN29APE(disposable);
			num = 6;
			goto IL_007d;
			IL_0065:
			if (disposable != null)
			{
				goto IL_0055;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			throw new NotSupportedException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void eynBZFZzB2ORk4h6X7C()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kHbQ6MZJrM3ietHK92Y()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool e2lyOPZ8Rq0icguBtLg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bvlIqYJw7yBXRf7LQwP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).Current;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FMW9YyJsEPMDi351WXC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void TLGLISJhNx55XN29APE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}
	}

	private readonly CnxHashArray GAkIN9804X;

	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GAkIN9804X.Count;
		}
	}

	public CvsCellInfo this[CvsCellLocation location]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			e6QaElLGh8VXvnyrAdF();
			int num;
			if (SqbQvkLnxcXs4hPGXVv())
			{
				num = 3;
				if (e6QaElLGh8VXvnyrAdF())
				{
				}
			}
			else
			{
				num = 2;
				if (!SqbQvkLnxcXs4hPGXVv())
				{
					goto IL_004f;
				}
			}
			CnxHashArray gAkIN9804X = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					gAkIN9804X = GAkIN9804X;
					break;
				case 1:
				case 2:
					break;
				default:
					num = 4;
					continue;
				case 4:
					goto IL_0086;
				}
				break;
			}
			goto IL_004f;
			IL_0086:
			bool lockTaken = default;
			try
			{
				Monitor.Enter(gAkIN9804X, ref lockTaken);
				return (CvsCellInfo)MgqDO1LyYhtt4T6PUpj(GAkIN9804X, location.GetHashCode());
			}
			finally
			{
				if (lockTaken)
				{
					yRRW3lLFBllP64tv3I8(gAkIN9804X);
				}
			}
			IL_004f:
			lockTaken = false;
			goto IL_0086;
		}
	}

	public CvsCellInfo this[int index]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!SqbQvkLnxcXs4hPGXVv()) ? 3 : 2);
			CnxHashArray gAkIN9804X = default;
			bool lockTaken = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					gAkIN9804X = GAkIN9804X;
					goto case 1;
				case 1:
				case 3:
					lockTaken = false;
					break;
				default:
					goto IL_0068;
				case 4:
					break;
				}
				break;
				IL_0068:
				num = 4;
			}
			try
			{
				Monitor.Enter(gAkIN9804X, ref lockTaken);
				return (CvsCellInfo)MXPQhALgNKxVs1aRMe1(GAkIN9804X, index);
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(gAkIN9804X);
				}
			}
		}
	}

	public CvsCellInfo this[string name]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (SqbQvkLnxcXs4hPGXVv())
			{
				num = 3;
				if (!SqbQvkLnxcXs4hPGXVv())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 2;
			}
			CnxHashArray gAkIN9804X = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					break;
				default:
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 3:
					gAkIN9804X = GAkIN9804X;
					break;
				case 4:
					goto IL_007a;
				}
				break;
			}
			goto IL_002a;
			IL_007a:
			bool lockTaken = default;
			try
			{
				Monitor.Enter(gAkIN9804X, ref lockTaken);
				IEnumerator enumerator = bSAGagLZ1TtTalBwAAs(GAkIN9804X);
				try
				{
					CvsCellInfo result = default;
					while (enumerator.MoveNext())
					{
						CvsCellInfo cvsCellInfo = (CvsCellInfo)dRq17bL6wiBmuwGP0qt(enumerator);
						e6QaElLGh8VXvnyrAdF();
						int num2;
						if (SqbQvkLnxcXs4hPGXVv())
						{
							num2 = 3;
						}
						else
						{
							num2 = 2;
							if (1 == 0)
							{
								goto IL_0107;
							}
						}
						goto IL_00dc;
						IL_00dc:
						switch (num2)
						{
						case 0:
						case 3:
							goto IL_00b9;
						case 4:
							return result;
						}
						goto IL_0107;
						IL_00b9:
						if (!((string)H7uZUrLJGGiqcBky094(cvsCellInfo) == name))
						{
							continue;
						}
						goto IL_0107;
						IL_0107:
						result = cvsCellInfo;
						num2 = 4;
						goto IL_00dc;
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
			}
			finally
			{
				if (lockTaken)
				{
					yRRW3lLFBllP64tv3I8(gAkIN9804X);
				}
			}
			return null;
			IL_002a:
			lockTaken = false;
			goto IL_007a;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellInfoCollection()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		do
		{
			IL_005a:
			switch (num)
			{
			case 3:
				EB6UOWLXIg5Fp7wkUJ1();
				_ = 1;
				if (!e6QaElLGh8VXvnyrAdF())
				{
					num = 4;
					if (e6QaElLGh8VXvnyrAdF())
					{
					}
				}
				else
				{
					num = 0;
					if (e6QaElLGh8VXvnyrAdF())
					{
					}
				}
				goto IL_005a;
			case 1:
			case 4:
				GAkIN9804X = new CnxHashArray();
				break;
			case 5:
				return;
			}
			c1Yc4CLbk7ChjIaElJQ(this);
			num = 5;
		}
		while (SqbQvkLnxcXs4hPGXVv());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellInfoCollection(CvsCellInfoCollection original)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		e6QaElLGh8VXvnyrAdF();
		int num = ((!SqbQvkLnxcXs4hPGXVv()) ? 1 : 6);
		CnxHashArray gAkIN9804X = default;
		bool lockTaken = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 6:
				EB6UOWLXIg5Fp7wkUJ1();
				num = 3;
				if (SqbQvkLnxcXs4hPGXVv())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 2:
				c1Yc4CLbk7ChjIaElJQ(this);
				goto case 5;
			default:
				num = 5;
				continue;
			case 3:
				GAkIN9804X = new CnxHashArray();
				goto case 1;
			case 5:
				gAkIN9804X = original.GAkIN9804X;
				num = 4;
				continue;
			case 4:
				lockTaken = false;
				num = 7;
				if (true)
				{
					continue;
				}
				break;
			case 7:
				break;
			}
			break;
		}
		try
		{
			Monitor.Enter(gAkIN9804X, ref lockTaken);
			IEnumerator enumerator = ((IEnumerable)original.GAkIN9804X).GetEnumerator();
			try
			{
				while (nnk34hLpbjKT5XvVdxW(enumerator))
				{
					CvsCellInfo original2 = (CvsCellInfo)dRq17bL6wiBmuwGP0qt(enumerator);
					e6QaElLGh8VXvnyrAdF();
					int num2;
					if (SqbQvkLnxcXs4hPGXVv())
					{
						num2 = 2;
						if (e6QaElLGh8VXvnyrAdF())
						{
							goto IL_0103;
						}
					}
					else
					{
						num2 = 3;
					}
					switch (num2)
					{
					case 0:
					case 2:
						break;
					default:
						continue;
					}
					goto IL_0103;
					IL_0103:
					GAkIN9804X.Add(new CvsCellInfo(original2));
				}
			}
			finally
			{
				if (enumerator is IDisposable disposable)
				{
					g0eIO7L00F7dn8dyXNw(disposable);
				}
			}
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(gAkIN9804X);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SqbQvkLnxcXs4hPGXVv();
		int num;
		if (!e6QaElLGh8VXvnyrAdF())
		{
			num = 3;
		}
		else
		{
			num = 2;
			if (e6QaElLGh8VXvnyrAdF())
			{
				goto IL_0082;
			}
		}
		bool lockTaken = default;
		CnxHashArray gAkIN9804X = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				lockTaken = false;
				break;
			default:
				num = 4;
				if (!e6QaElLGh8VXvnyrAdF())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 3:
				gAkIN9804X = GAkIN9804X;
				goto case 1;
			case 4:
				break;
			}
			break;
		}
		goto IL_0082;
		IL_0082:
		try
		{
			Monitor.Enter(gAkIN9804X, ref lockTaken);
			VbDHgHL4YWFpVFwTmTM(GAkIN9804X);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(gAkIN9804X);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int IndexOf(CvsCellInfo item)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (e6QaElLGh8VXvnyrAdF() ? 2 : 3);
		CnxHashArray gAkIN9804X = default;
		bool lockTaken = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				gAkIN9804X = GAkIN9804X;
				goto case 4;
			default:
				num = 4;
				continue;
			case 0:
			case 3:
			{
				int num2 = -1;
				goto case 1;
			}
			case 4:
				lockTaken = false;
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 5:
				break;
			}
			break;
		}
		try
		{
			Monitor.Enter(gAkIN9804X, ref lockTaken);
			return GVO5dKLkfMiRfhfMoM4(GAkIN9804X, item);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(gAkIN9804X);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(CvsCellInfo item)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!e6QaElLGh8VXvnyrAdF())
		{
			num = 2;
			if (!SqbQvkLnxcXs4hPGXVv())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
		}
		CnxHashArray gAkIN9804X = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				break;
			default:
				num = 4;
				if (SqbQvkLnxcXs4hPGXVv())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				gAkIN9804X = GAkIN9804X;
				break;
			case 4:
				goto IL_007e;
			}
			break;
		}
		goto IL_002a;
		IL_007e:
		bool lockTaken = default;
		try
		{
			Monitor.Enter(gAkIN9804X, ref lockTaken);
			GJj0BkLfSRZHALEkLl7(GAkIN9804X, item);
			return;
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(gAkIN9804X);
			}
		}
		IL_002a:
		lockTaken = false;
		goto IL_007e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Remove(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		e6QaElLGh8VXvnyrAdF();
		int num = ((!SqbQvkLnxcXs4hPGXVv()) ? 2 : 3);
		CnxHashArray gAkIN9804X = default;
		bool lockTaken = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				gAkIN9804X = GAkIN9804X;
				goto case 1;
			case 1:
			case 2:
				lockTaken = false;
				break;
			default:
				goto IL_006c;
			case 4:
				break;
			}
			break;
			IL_006c:
			num = 4;
		}
		try
		{
			Monitor.Enter(gAkIN9804X, ref lockTaken);
			GAkIN9804X.RemoveAll(location.GetHashCode());
		}
		finally
		{
			if (lockTaken)
			{
				yRRW3lLFBllP64tv3I8(gAkIN9804X);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveAt(int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (e6QaElLGh8VXvnyrAdF() ? 3 : 2);
		bool lockTaken = default;
		CnxHashArray gAkIN9804X = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				lockTaken = false;
				break;
			default:
				goto IL_0051;
			case 0:
			case 2:
				gAkIN9804X = GAkIN9804X;
				goto case 1;
			case 4:
				break;
			}
			break;
			IL_0051:
			num = 4;
		}
		try
		{
			Monitor.Enter(gAkIN9804X, ref lockTaken);
			QGL5uFLmRPExKnvXrNp(GAkIN9804X, index);
		}
		finally
		{
			if (lockTaken)
			{
				yRRW3lLFBllP64tv3I8(gAkIN9804X);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetName(CvsCellLocation location, string name, bool input, bool output)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		e6QaElLGh8VXvnyrAdF();
		int num = ((!SqbQvkLnxcXs4hPGXVv()) ? 2 : 3);
		bool lockTaken = default;
		CnxHashArray gAkIN9804X = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				lockTaken = false;
				break;
			default:
				num = 4;
				if (SqbQvkLnxcXs4hPGXVv())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 3:
				gAkIN9804X = GAkIN9804X;
				goto case 1;
			case 4:
				break;
			}
			break;
		}
		try
		{
			Monitor.Enter(gAkIN9804X, ref lockTaken);
			SqbQvkLnxcXs4hPGXVv();
			int num2 = (e6QaElLGh8VXvnyrAdF() ? 2 : 3);
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 3:
					D1yTI7L8jf4JGsm3JHA(GAkIN9804X, location.GetHashCode());
					goto default;
				default:
					if (name != null)
					{
						num2 = 4;
						if (SqbQvkLnxcXs4hPGXVv())
						{
							break;
						}
						goto case 4;
					}
					return;
				case 4:
					GJj0BkLfSRZHALEkLl7(GAkIN9804X, new CvsCellInfo(location, name, input, output));
					return;
				}
			}
		}
		finally
		{
			if (lockTaken)
			{
				yRRW3lLFBllP64tv3I8(gAkIN9804X);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UpdateTag(ref CvsCellInfo oldTag, CvsCellLocation location, string name, bool input, bool output)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SqbQvkLnxcXs4hPGXVv();
		int num = (e6QaElLGh8VXvnyrAdF() ? 3 : 2);
		CnxHashArray gAkIN9804X = default;
		bool lockTaken = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				gAkIN9804X = GAkIN9804X;
				goto case 1;
			case 1:
			case 3:
				lockTaken = false;
				break;
			default:
				goto IL_006c;
			case 4:
				break;
			}
			break;
			IL_006c:
			num = 4;
		}
		bool result = default;
		try
		{
			Monitor.Enter(gAkIN9804X, ref lockTaken);
			int num2 = 2;
			CvsCellInfo cvsCellInfo = default;
			int num3 = default;
			while (true)
			{
				switch (num2)
				{
				case 10:
					GJj0BkLfSRZHALEkLl7(GAkIN9804X, cvsCellInfo);
					num2 = 5;
					if (e6QaElLGh8VXvnyrAdF())
					{
					}
					continue;
				case 7:
					QGL5uFLmRPExKnvXrNp(GAkIN9804X, num3);
					num2 = 10;
					continue;
				case 1:
					if (location.IsValid)
					{
						num2 = 0;
						if (0 == 0)
						{
							continue;
						}
						goto case 4;
					}
					goto IL_01be;
				case 4:
				case 6:
					cvsCellInfo = new CvsCellInfo(location, name, input, output);
					goto case 7;
				default:
					num2 = 7;
					continue;
				case 0:
					if (name != null)
					{
						num3 = GVO5dKLkfMiRfhfMoM4(GAkIN9804X, oldTag);
						SqbQvkLnxcXs4hPGXVv();
						num2 = (e6QaElLGh8VXvnyrAdF() ? 6 : 8);
						continue;
					}
					goto IL_01be;
				case 3:
				case 8:
					if (num3 > -1)
					{
						goto case 4;
					}
					goto IL_01be;
				case 2:
					if (oldTag != null)
					{
						num2 = 1;
						if (0 == 0)
						{
							continue;
						}
						goto case 9;
					}
					goto IL_01be;
				case 9:
					result = true;
					num2 = 11;
					continue;
				case 5:
					oldTag = cvsCellInfo;
					num2 = 9;
					if (true)
					{
						continue;
					}
					break;
				case 11:
					break;
				}
				break;
			}
		}
		finally
		{
			if (lockTaken)
			{
				yRRW3lLFBllP64tv3I8(gAkIN9804X);
			}
		}
		return result;
		IL_01be:
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (IEnumerator)bSAGagLZ1TtTalBwAAs(GAkIN9804X);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CCognex_002DInSight_002DINamedOperand_003E_002DGetEnumerator_003Ed__19))]
	IEnumerator<INamedOperand> IEnumerable<INamedOperand>.GetEnumerator()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CCognex_002DInSight_002DINamedOperand_003E_002DGetEnumerator_003Ed__19(0)
		{
			_003C_003E4__this = this
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	INamedOperand INamedOperandCollection.FindByName(string name)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return this[name];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	INamedOperand INamedOperandCollection.FindMatch(string expr)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		INamedOperand result = default;
		CvsCellLocation location = default;
		while (true)
		{
			switch (num)
			{
			default:
				result = this[location];
				num = 6;
				if (SqbQvkLnxcXs4hPGXVv())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 2:
				if (!location.IsValid)
				{
					break;
				}
				goto default;
			case 0:
				do
				{
					location = bm9LeKLzpUuYn8mlJne(expr);
					e6QaElLGh8VXvnyrAdF();
					if (!SqbQvkLnxcXs4hPGXVv())
					{
						num = 4;
						continue;
					}
					num = 1;
					break;
				}
				while (false);
				continue;
			case 5:
				result = null;
				num = 0;
				continue;
			case 6:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EB6UOWLXIg5Fp7wkUJ1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void c1Yc4CLbk7ChjIaElJQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SqbQvkLnxcXs4hPGXVv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool e6QaElLGh8VXvnyrAdF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dRq17bL6wiBmuwGP0qt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).Current;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool nnk34hLpbjKT5XvVdxW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void g0eIO7L00F7dn8dyXNw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VbDHgHL4YWFpVFwTmTM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CnxHashArray)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GVO5dKLkfMiRfhfMoM4(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CnxHashArray)P_0).IndexOf(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GJj0BkLfSRZHALEkLl7(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CnxHashArray)P_0).Add(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yRRW3lLFBllP64tv3I8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Monitor.Exit(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QGL5uFLmRPExKnvXrNp(object P_0, int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CnxHashArray)P_0).RemoveAt(index);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MgqDO1LyYhtt4T6PUpj(object P_0, int hashCode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CnxHashArray)P_0).GetItem(hashCode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MXPQhALgNKxVs1aRMe1(object P_0, int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CnxHashArray)P_0)[index];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bSAGagLZ1TtTalBwAAs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerable)P_0).GetEnumerator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object H7uZUrLJGGiqcBky094(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellInfo)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int D1yTI7L8jf4JGsm3JHA(object P_0, int hashCode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CnxHashArray)P_0).RemoveAll(hashCode);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation bm9LeKLzpUuYn8mlJne(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.TryParse((string)P_0);
	}
}
