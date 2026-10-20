using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Cognex.Extensions;
using Cognex.InSight.Remoting.Serialization;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

[Serializable]
public sealed class CvsFunctionTable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<FunctionGroupDescriptor, CvsFunctionGroup> _003C_003E9__4_0;

		public static Func<CvsFunction, bool> _003C_003E9__5_0;

		public static Func<CvsFunctionGroup, IEnumerable<CvsFunction>> _003C_003E9__6_0;

		public static Func<CvsFunction, CvsFunction> _003C_003E9__6_1;

		public static Func<CvsFunction, string> _003C_003E9__6_2;

		public static Func<IGrouping<string, CvsFunction>, string> _003C_003E9__6_3;

		public static Func<CvsFunction, bool> _003C_003E9__13_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IVnbGAseLZODCV6R99be();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IVnbGAseLZODCV6R99be();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal CvsFunctionGroup _003C_002Ector_003Eb__4_0(FunctionGroupDescriptor gd)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new CvsFunctionGroup(gd);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003COrderByListed_003Eb__5_0(CvsFunction f)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qGAlkVse9lm2ZBcqePpv(f);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<CvsFunction> _003C_002Ector_003Eb__6_0(CvsFunctionGroup g)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return g.Functions;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal CvsFunction _003C_002Ector_003Eb__6_1(CvsFunction f)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return f;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003C_002Ector_003Eb__6_2(CvsFunction g)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return g.Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003C_002Ector_003Eb__6_3(IGrouping<string, CvsFunction> f)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return f.Key;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CFindFunction_003Eb__13_0(CvsFunction _)
		{
			while (false)
			{
				object obj = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void IVnbGAseLZODCV6R99be()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Y0R5y0sesHTPhVuEa5dl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PnYbIisehjIwWR8M0fL5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qGAlkVse9lm2ZBcqePpv(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsFunction)P_0).Listed;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetValidFunctions_003Ed__16 : IEnumerable<CvsFunction>, IEnumerable, IEnumerator<CvsFunction>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private CvsFunction _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public CvsFunctionTable _003C_003E4__this;

		private CvsParse result;

		public CvsParse _003C_003E3__result;

		private IEnumerator<CvsFunction> _003C_003E7__wrap1;

		private CvsFunction _003Cfunction_003E5__3;

		CvsFunction IEnumerator<CvsFunction>.Current
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
		public _003CGetValidFunctions_003Ed__16(int _003C_003E1__state)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = ((!MTk4yXseEeAZmerBXxux()) ? 1 : 3);
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003El__initialThreadId = UODlxDseHkVtgbVInS6e();
					num = 6;
					break;
				case 2:
				case 3:
					this._003C_003E1__state = _003C_003E1__state;
					goto case 4;
				default:
					num = 4;
					if (xCqJ23seSI18aELXOMCh())
					{
						break;
					}
					goto case 5;
				case 5:
					xqaPdbsevcHOWS4KnWbF(this);
					goto case 2;
				case 0:
				case 1:
					VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
					num = 5;
					break;
				case 6:
					return;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (MTk4yXseEeAZmerBXxux())
			{
				goto IL_001e;
			}
			goto IL_006a;
			IL_001e:
			int num2 = default;
			if (num2 == 1)
			{
				num = 5;
				goto IL_006a;
			}
			return;
			IL_006a:
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					MTk4yXseEeAZmerBXxux();
					num = ((!xCqJ23seSI18aELXOMCh()) ? 4 : 3);
					continue;
				case 1:
				case 3:
					if (num2 != -3)
					{
						break;
					}
					goto case 5;
				case 5:
					try
					{
						return;
					}
					finally
					{
						_003C_003Em__Finally1();
					}
				}
				break;
			}
			goto IL_001e;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bool flag = default;
			try
			{
				int num = _003C_003E1__state;
				int num2 = 0;
				if (MTk4yXseEeAZmerBXxux())
				{
					goto IL_0025;
				}
				goto IL_00ec;
				IL_0025:
				_003C_003E1__state = 1;
				num2 = 12;
				goto IL_00ec;
				IL_00ec:
				CvsFunctionTable cvsFunctionTable = default;
				string text = default;
				while (true)
				{
					switch (num2)
					{
					case 4:
						break;
					case 8:
						_003C_003E7__wrap1 = cvsFunctionTable.MIMkMVdmLO.GetEnumerator();
						num2 = 3;
						continue;
					case 16:
						text = "";
						num2 = 8;
						continue;
					case 12:
						flag = true;
						goto end_IL_00ec;
					case 6:
					case 7:
						if (pCtBB8seVBpGpOdlFZFG(_003Cfunction_003E5__3) && !aWFeKRseDCdVdpakUSga(jtd1reseAHJWCZA5lojU(_003Cfunction_003E5__3), text))
						{
							goto case 11;
						}
						goto case 5;
					default:
						num2 = 11;
						continue;
					case 2:
						_003C_003Em__Finally1();
						num2 = 15;
						if (true)
						{
							continue;
						}
						goto case 11;
					case 11:
						if (!buayBQseUX8R73YQjvFn(_003Cfunction_003E5__3, result))
						{
							goto case 5;
						}
						goto case 9;
					case 1:
					case 10:
						if (_003C_003E7__wrap1.MoveNext())
						{
							_003Cfunction_003E5__3 = _003C_003E7__wrap1.Current;
							_ = 0;
							num2 = ((!xCqJ23seSI18aELXOMCh()) ? 14 : 6);
							continue;
						}
						num2 = 2;
						if (0 == 0)
						{
							continue;
						}
						goto case 0;
					case 0:
						cvsFunctionTable = _003C_003E4__this;
						num2 = 17;
						continue;
					case 15:
						_003C_003E7__wrap1 = null;
						num2 = 18;
						continue;
					case 5:
						_003Cfunction_003E5__3 = null;
						num2 = 1;
						continue;
					case 13:
						goto end_IL_00ec;
					case 17:
						if (num == 0)
						{
							_003C_003E1__state = -1;
							num2 = 16;
							continue;
						}
						if (num == 1)
						{
							_003C_003E1__state = -3;
							text = _003Cfunction_003E5__3.Name;
							num2 = 5;
							if (true)
							{
								continue;
							}
							goto case 6;
						}
						flag = false;
						num2 = 13;
						continue;
					case 9:
					case 14:
						_003C_003E2__current = _003Cfunction_003E5__3;
						num2 = 4;
						continue;
					case 3:
						_003C_003E1__state = -3;
						num2 = 10;
						continue;
					case 18:
						flag = false;
						goto end_IL_00ec;
					}
					goto IL_0025;
					continue;
					end_IL_00ec:
					break;
				}
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
			return flag;
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
			if (xCqJ23seSI18aELXOMCh())
			{
				num = 3;
				if (MTk4yXseEeAZmerBXxux())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 1;
				if (1 == 0)
				{
					goto IL_008b;
				}
			}
			goto IL_005c;
			IL_005c:
			switch (num)
			{
			case 4:
				if (_003C_003E7__wrap1 != null)
				{
					break;
				}
				return;
			case 0:
			case 3:
				goto IL_008b;
			case 5:
				return;
			}
			goto IL_002a;
			IL_008b:
			_003C_003E1__state = -1;
			num = 4;
			goto IL_005c;
			IL_002a:
			RCGVf8seTAZhLShDnJ3U(_003C_003E7__wrap1);
			num = 5;
			goto IL_005c;
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
		[DebuggerHidden]
		IEnumerator<CvsFunction> IEnumerable<CvsFunction>.GetEnumerator()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003CGetValidFunctions_003Ed__16 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetValidFunctions_003Ed__16(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			obj.result = _003C_003E3__result;
			return obj;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<CvsFunction>)this).GetEnumerator();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void xqaPdbsevcHOWS4KnWbF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int UODlxDseHkVtgbVInS6e()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xCqJ23seSI18aELXOMCh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MTk4yXseEeAZmerBXxux()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pCtBB8seVBpGpOdlFZFG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsFunction)P_0).Listed;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jtd1reseAHJWCZA5lojU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsFunction)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aWFeKRseDCdVdpakUSga(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Equals((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool buayBQseUX8R73YQjvFn(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return IsValidFunction((CvsFunction)P_0, (CvsParse)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RCGVf8seTAZhLShDnJ3U(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}
	}

	private readonly CvsFunctionGroup[] owekJCKN5M;

	private readonly IReadOnlyList<CvsFunction> MIMkMVdmLO;

	private readonly Dictionary<string, IReadOnlyList<CvsFunction>> cvGkoAehBP;

	private int[] w3KkAgs5Lm;

	public IReadOnlyList<CvsFunctionGroup> Groups
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return owekJCKN5M;
		}
	}

	public IReadOnlyList<CvsFunction> AllFunctions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MIMkMVdmLO;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsFunctionTable(FunctionTableDescriptor descriptor)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		this._002Ector((descriptor == null) ? null : ((IEnumerable<FunctionGroupDescriptor>)Gonalkb7lDb60U1mpJH(descriptor))?.Select([MethodImpl(MethodImplOptions.NoInlining)] (FunctionGroupDescriptor gd) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new CvsFunctionGroup(gd);
		}));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal IReadOnlyList<CvsFunction> OrderByListed(IGrouping<string, CvsFunction> group)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return group.OrderByDescending([MethodImpl(MethodImplOptions.NoInlining)] (CvsFunction f) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec.qGAlkVse9lm2ZBcqePpv(f);
		}).ToReadonlyList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsFunctionTable(IEnumerable<CvsFunctionGroup> groups)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		w3KkAgs5Lm = new int[28];
		base._002Ector();
		if (groups == null)
		{
			throw new ArgumentNullException(kgbOBx7BanbFa22Hp9.ol99ukmDA(42674));
		}
		owekJCKN5M = groups.ToArray();
		MIMkMVdmLO = owekJCKN5M.SelectMany([MethodImpl(MethodImplOptions.NoInlining)] (CvsFunctionGroup g) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return g.Functions;
		}).OrderBy([MethodImpl(MethodImplOptions.NoInlining)] (CvsFunction f) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return f;
		}).ToReadonlyList();
		StringComparer invariantCultureIgnoreCase = StringComparer.InvariantCultureIgnoreCase;
		cvGkoAehBP = MIMkMVdmLO.GroupBy([MethodImpl(MethodImplOptions.NoInlining)] (CvsFunction g) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return g.Name;
		}, invariantCultureIgnoreCase).ToDictionary([MethodImpl(MethodImplOptions.NoInlining)] (IGrouping<string, CvsFunction> f) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return f.Key;
		}, OrderByListed, invariantCultureIgnoreCase);
		LKNkTglFuI();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsFunctionTable CreateFunctionTable(params CvsFunction[] functions)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsFunctionGroup[] array = new CvsFunctionGroup[1];
		FunctionGroupDescriptor functionGroupDescriptor = new FunctionGroupDescriptor
		{
			Name = (string)RLRMcybt7QZ4WqsaRMu(42690)
		};
		JxcbkObCS5n92oBi6JN(functionGroupDescriptor, RLRMcybt7QZ4WqsaRMu(42690));
		aHUfucbKssq6pOFBQMC(functionGroupDescriptor, Array.Empty<FunctionCollectionDescriptor>());
		array[0] = new CvsFunctionGroup(functionGroupDescriptor, functions);
		return new CvsFunctionTable(array);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LKNkTglFuI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		int num2 = default;
		char c2 = default;
		int num3 = default;
		char c = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				num2 = 0;
				goto case 4;
			case 4:
				if (num2 < 28)
				{
					w3KkAgs5Lm[num2] = -1;
					num = 14;
				}
				else
				{
					num = 12;
				}
				break;
			case 7:
				if (c2 > 'Z')
				{
					num = 16;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				}
				goto IL_019b;
			case 1:
				w3KkAgs5Lm[26] = num3;
				num = 3;
				break;
			case 10:
				num3 = 0;
				_ = 0;
				num = (tSWDYtb28m3jAScu19X() ? 11 : 9);
				break;
			case 8:
				if (c2 >= 'A')
				{
					goto case 7;
				}
				goto case 16;
			default:
				num = 7;
				if (0 == 0)
				{
					break;
				}
				goto case 12;
			case 12:
				c = '\0';
				num = 10;
				break;
			case 5:
				w3KkAgs5Lm = new int[28];
				num = 0;
				if (0 == 0)
				{
					break;
				}
				goto case 6;
			case 6:
			case 11:
			case 15:
				if (num3 < dKIElHbYZ0mhUUxLjVr(MIMkMVdmLO))
				{
					c2 = Sd0BJibPhvbooe3G6oq(TUVdukb5hYaWOqLBb79(MIMkMVdmLO[num3].Name, 0), dJ0StIbofFkIacxLDM8());
					num = 8;
					break;
				}
				goto IL_017f;
			case 16:
				if (c2 != '_')
				{
					goto IL_017f;
				}
				goto IL_019b;
			case 2:
				c = c2;
				if (c != '_')
				{
					w3KkAgs5Lm[c - 65] = num3;
					goto case 3;
				}
				num = 1;
				break;
			case 3:
			case 9:
			case 13:
				num3++;
				num = 15;
				break;
			case 14:
				num2++;
				num = 4;
				break;
			case 17:
				return;
				IL_019b:
				if (c2 != c)
				{
					num = 2;
					break;
				}
				goto case 3;
				IL_017f:
				w3KkAgs5Lm[27] = num3;
				num = 17;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int AvbkB7oDge(char P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (!AxsmhGbWBfshmkdyIIK())
		{
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 0:
				case 4:
					return w3KkAgs5Lm[26];
				case 1:
					P_0 = Sd0BJibPhvbooe3G6oq(P_0, dJ0StIbofFkIacxLDM8());
					num = 6;
					if (!AxsmhGbWBfshmkdyIIK())
					{
						continue;
					}
					goto case 6;
				case 6:
					if (P_0 >= 'A')
					{
						_ = 0;
						num = (tSWDYtb28m3jAScu19X() ? 5 : 0);
						continue;
					}
					goto IL_002a;
				case 2:
				case 5:
					if (P_0 <= 'Z')
					{
						break;
					}
					goto IL_002a;
				default:
					num = 3;
					continue;
				case 7:
					{
						return w3KkAgs5Lm[27];
					}
					IL_002a:
					switch (P_0)
					{
					case '_':
						break;
					case '!':
						num = 7;
						continue;
					default:
						return -1;
					}
					goto case 0;
				}
				break;
			}
		}
		return w3KkAgs5Lm[P_0 - 65];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int GetFunctionMatch(string str, Func<CvsFunction, bool> isValid)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (string.IsNullOrEmpty(str))
		{
			return 0;
		}
		str = str.ToUpper(CultureInfo.InvariantCulture);
		int num = AvbkB7oDge(str[0]);
		if (num < 0)
		{
			return 0;
		}
		int num2 = 0;
		int length = str.Length;
		string text = str.Substring(0, num2 + 1);
		for (int i = num; i < MIMkMVdmLO.Count; i++)
		{
			CvsFunction cvsFunction = MIMkMVdmLO[i];
			if (isValid != null && !isValid(cvsFunction))
			{
				continue;
			}
			string text2 = cvsFunction.Name.ToUpper(CultureInfo.InvariantCulture);
			if (text2.StartsWith(text))
			{
				int length2 = text2.Length;
				do
				{
					num2 = text.Length;
					if (num2 >= length)
					{
						break;
					}
					text = str.Substring(0, num2 + 1);
				}
				while (text2.StartsWith(text) && num2 < length2);
				if (num2 == length)
				{
					break;
				}
			}
			else if (text2.CompareTo(text) > 0)
			{
				break;
			}
		}
		return num2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsFunction FindFunction(string expr)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string functionName = (string)uaRr3QbNFwDuEYh5nc6(expr);
		return FindFunctionsByName(functionName).FirstOrDefault();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IReadOnlyList<CvsFunction> FindFunctionsByName(string functionName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return cvGkoAehBP.GetValueOrDefault(functionName, Empty.List<CvsFunction>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsFunction FindFunction(string str, int index, Func<CvsFunction, bool> isValid = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string key = CvsParse.FindIdentifier(str.Trim());
		if (isValid == null)
		{
			isValid = [MethodImpl(MethodImplOptions.NoInlining)] (CvsFunction _) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			};
		}
		if (cvGkoAehBP.TryGetValue(key, out var value) && value.IsValidIndex(index) && isValid(value[0]))
		{
			return value[index];
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsFunction FindOverloadedFunction(string expr)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		string key = default;
		string[] source = default;
		CvsFunction cvsFunction2 = default;
		IEnumerator<CvsFunction> enumerator = default;
		CvsFunction result = default;
		int num2 = default;
		CvsFunction cvsFunction3 = default;
		while (true)
		{
			int num3;
			CvsFunction cvsFunction;
			switch (num)
			{
			case 6:
				key = CvsParse.FindIdentifier(expr);
				num = 5;
				continue;
			case 9:
				num3 = source.Count();
				goto IL_0036;
			case 1:
			case 8:
				if (source.Count() != 1)
				{
					goto case 9;
				}
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 4;
			case 4:
				if (t1wLlbbx7Y2O7mhT4TA(source.First()))
				{
					num3 = 0;
					goto IL_0036;
				}
				num = 9;
				continue;
			case 0:
				cvsFunction2 = null;
				goto case 6;
			default:
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				enumerator = cvGkoAehBP.GetValueOrDefault(key, Empty.List<CvsFunction>()).GetEnumerator();
				goto case 3;
			case 3:
			case 7:
				try
				{
					while (Xp6UdZbOcxVOThcAobE(enumerator))
					{
						CvsFunction current = enumerator.Current;
						AxsmhGbWBfshmkdyIIK();
						int num4;
						if (tSWDYtb28m3jAScu19X())
						{
							num4 = 6;
							if (!tSWDYtb28m3jAScu19X())
							{
								goto IL_0129;
							}
						}
						else
						{
							num4 = 5;
						}
						goto IL_01b0;
						IL_0129:
						cvsFunction2 = current;
						num4 = 10;
						goto IL_01b0;
						IL_01b0:
						while (true)
						{
							switch (num4)
							{
							case 1:
								break;
							case 2:
							case 5:
								result = current;
								num4 = 3;
								continue;
							case 9:
								if (cvsFunction2 != null)
								{
									goto IL_0215;
								}
								num4 = 1;
								if (!AxsmhGbWBfshmkdyIIK())
								{
									continue;
								}
								goto case 7;
							case 7:
								if (num2 >= nDSZF0brbkCBi98ULp3(current))
								{
									goto case 2;
								}
								if (cvsFunction3 != null)
								{
									goto case 8;
								}
								goto case 4;
							case 8:
								if (!ILot4ab3PmABlMndknY(current))
								{
									goto IL_0215;
								}
								num4 = 9;
								if (tSWDYtb28m3jAScu19X())
								{
									continue;
								}
								goto end_IL_008f;
							default:
								num4 = 4;
								if (tSWDYtb28m3jAScu19X())
								{
									continue;
								}
								goto case 4;
							case 4:
								cvsFunction3 = current;
								num4 = 8;
								continue;
							case 0:
							case 6:
								if (num2 <= fd8UXMb15bLj627pYSe(current))
								{
									num4 = 7;
									continue;
								}
								goto case 8;
							case 10:
								goto IL_0215;
							case 3:
								goto end_IL_008f;
							}
							break;
						}
						goto IL_0129;
						IL_0215:;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						itVbkhbM2APJ4n1krnF(enumerator);
					}
				}
				cvsFunction = cvsFunction3;
				if (cvsFunction == null)
				{
					num = 10;
					continue;
				}
				goto IL_026a;
			case 2:
				source = CvsParse.FindAllArgs(expr).ToArray();
				_ = 1;
				if (AxsmhGbWBfshmkdyIIK())
				{
					num = 3;
					if (!AxsmhGbWBfshmkdyIIK())
					{
						continue;
					}
					goto case 3;
				}
				num = 8;
				continue;
			case 10:
				{
					cvsFunction = cvsFunction2;
					goto IL_026a;
				}
				IL_0036:
				num2 = num3;
				cvsFunction3 = null;
				num = 0;
				if (tSWDYtb28m3jAScu19X())
				{
					continue;
				}
				goto case 1;
				IL_026a:
				return cvsFunction;
				end_IL_008f:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsValidFunction(CvsFunction fd, CvsParse result)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		while (true)
		{
			switch (num)
			{
			case 5:
				if (xXaOqSbQclw5QZcWMLw(fd))
				{
					num = 9;
					if (true)
					{
						continue;
					}
					goto case 0;
				}
				if (!xRbSPvbeJrGlNpiP78Q(fd))
				{
					if (!result.AllowFunction)
					{
						num = 7;
						continue;
					}
					if (cgDLtgbIiWCsQmf1dtq(fd) && !result.AllowStructure)
					{
						goto case 4;
					}
					goto IL_00e1;
				}
				_ = 0;
				if (!tSWDYtb28m3jAScu19X())
				{
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					goto case 9;
				}
				num = 6;
				if (!AxsmhGbWBfshmkdyIIK())
				{
					continue;
				}
				goto case 10;
			case 0:
				return false;
			case 1:
			case 3:
				return false;
			case 8:
				if (sOFBKnbnP2DRvWbAKiF(result))
				{
					break;
				}
				num = 11;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 7:
				return false;
			default:
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 4;
			case 4:
				return false;
			case 2:
			case 6:
				if (!bYPXTfbuv6K2r5M3Tnk(result))
				{
					goto case 1;
				}
				goto IL_00e1;
			case 9:
				return QJ3HOjblfsmY7YesrK5(result);
			case 10:
				if (!JywDAwbaRgYxu6fsgR5(result))
				{
					num = 0;
					continue;
				}
				goto IL_0031;
			case 11:
				{
					return false;
				}
				IL_0031:
				if (fd.PropertySheetEdit)
				{
					num = 8;
					continue;
				}
				break;
				IL_00e1:
				if (!gwcNGcbRQQBvC9EnblF(fd))
				{
					goto IL_0031;
				}
				num = 10;
				if (true)
				{
					continue;
				}
				goto case 2;
			}
			break;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetValidFunctions_003Ed__16))]
	public IEnumerable<CvsFunction> GetValidFunctions(CvsParse result)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetValidFunctions_003Ed__16(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__result = result
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Gonalkb7lDb60U1mpJH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FunctionTableDescriptor)P_0).Groups;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tSWDYtb28m3jAScu19X()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AxsmhGbWBfshmkdyIIK()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RLRMcybt7QZ4WqsaRMu(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JxcbkObCS5n92oBi6JN(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((FunctionGroupDescriptor)P_0).DisplayName = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aHUfucbKssq6pOFBQMC(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((FunctionGroupDescriptor)P_0).Collections = (FunctionCollectionDescriptor[])P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static char TUVdukb5hYaWOqLBb79(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dJ0StIbofFkIacxLDM8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.InvariantCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static char Sd0BJibPhvbooe3G6oq(char P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return char.ToUpper(P_0, (CultureInfo)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int dKIElHbYZ0mhUUxLjVr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IReadOnlyCollection<CvsFunction>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uaRr3QbNFwDuEYh5nc6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsParse.FindIdentifier((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool t1wLlbbx7Y2O7mhT4TA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int fd8UXMb15bLj627pYSe(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunction)P_0).MaxNumberOfArgs;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int nDSZF0brbkCBi98ULp3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunction)P_0).MinNumberOfArgs;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ILot4ab3PmABlMndknY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunction)P_0).HasVariableArguments;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Xp6UdZbOcxVOThcAobE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void itVbkhbM2APJ4n1krnF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xXaOqSbQclw5QZcWMLw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunction)P_0).Operator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QJ3HOjblfsmY7YesrK5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsParse)P_0).AllowInFix;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xRbSPvbeJrGlNpiP78Q(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunction)P_0).StringFunction;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bYPXTfbuv6K2r5M3Tnk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsParse)P_0).AllowStringFunction;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cgDLtgbIiWCsQmf1dtq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunction)P_0).Structure;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gwcNGcbRQQBvC9EnblF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunction)P_0).SheetOnly;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JywDAwbaRgYxu6fsgR5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsParse)P_0).AllowSheetFunction;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sOFBKnbnP2DRvWbAKiF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsParse)P_0).AllowPropertyFunction;
	}
}
