using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Foundations.Mvvm.Extensions;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.UndoableActions;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime.ViewModels;
using Cognex.InSight.Sensor;
using Cognex.InSight.Undo;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels;

public class PropertyLinks : EzSupportSnippet
{
	private class WW5BIYGnekkgDixF9y
	{
		[CompilerGenerated]
		private int N0y1OdW4sa;

		[CompilerGenerated]
		private readonly string rqq1HCAn3C;

		[CompilerGenerated]
		private readonly object yA01wBcf9d;

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
				return yA01wBcf9d;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WW5BIYGnekkgDixF9y(int P_0, string P_1, object P_2)
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
				case 6:
					base._002Ector();
					num = 0;
					continue;
				case 2:
				case 4:
					yA01wBcf9d = P_2;
					num = 7;
					continue;
				case 3:
				case 5:
					rqq1HCAn3C = P_1;
					goto case 2;
				case 1:
					V51RNOKnpkfH6k3tfNQK();
					num = 6;
					continue;
				case 0:
					H1E1lAVlky(P_0);
					break;
				case 7:
					return;
				}
				_ = 0;
				num = (K47waKKnqrrlrtBWrUhL() ? 5 : 2);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public int qjg14DwR2U()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return N0y1OdW4sa;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public void H1E1lAVlky(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			N0y1OdW4sa = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		[CompilerGenerated]
		public string Mmm1WKNLPY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return rqq1HCAn3C;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CvsCellLocation THw1Q1JclM(CvsCellRange P_0, CvsCellCollection P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			CvsCellLocation result = default;
			CvsCell cvsCell = default;
			CvsCellLocation cvsCellLocation = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					result = CvsCellLocation.TryParse((string)wZ1PZQKn4V0nmlcJxNVN(cvsCell));
					num = 7;
					continue;
				case 1:
				case 4:
					cvsCellLocation = qkfVutKnXMUqN6EEC6vM(qjg14DwR2U(), P_0);
					goto case 2;
				case 2:
				case 3:
					cvsCell = (CvsCell)HEVGDWKn9Goe9Pg9TTJD(P_1, cvsCellLocation);
					goto case 0;
				default:
					num = 0;
					continue;
				case 5:
					result = CvsCellLocation.Invalid;
					_ = 1;
					num = ((!zgFNgfKnEwUcU7oxul6t()) ? 4 : 3);
					continue;
				case 0:
					if (cvsCell != null)
					{
						num = 6;
						continue;
					}
					break;
				case 7:
					break;
				}
				break;
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string eFB1gh9KNF(CvsCellRange P_0, CvsCellCollection P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!zgFNgfKnEwUcU7oxul6t())
			{
				num = 3;
			}
			else
			{
				num = 7;
				if (1 == 0)
				{
					goto IL_009c;
				}
			}
			goto IL_0061;
			IL_009c:
			CvsCell cvsCell = default;
			string result = cvsCell.Name;
			num = 8;
			if (K47waKKnqrrlrtBWrUhL())
			{
				goto IL_0061;
			}
			goto IL_00b3;
			IL_00b3:
			CvsCellLocation cvsCellLocation = default;
			if (cvsCellLocation.IsValid)
			{
				num = 6;
				goto IL_0061;
			}
			goto IL_00d9;
			IL_0061:
			while (true)
			{
				switch (num)
				{
				case 2:
					cvsCellLocation = THw1Q1JclM(P_0, P_1);
					num = 5;
					continue;
				case 0:
				case 3:
					result = string.Empty;
					num = 2;
					continue;
				case 6:
					cvsCell = (CvsCell)HEVGDWKn9Goe9Pg9TTJD(P_1, cvsCellLocation);
					goto default;
				case 1:
					break;
				case 5:
					goto IL_00b3;
				default:
					if (cvsCell != null)
					{
						num = 1;
						continue;
					}
					goto IL_00d9;
				case 8:
					goto IL_00d9;
				}
				break;
			}
			goto IL_009c;
			IL_00d9:
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static CvsCellLocation cll1MDN4Z2(int P_0, CvsCellRange P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			int num3 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					num2 += 2 * (P_0 / P_1.Columns);
					goto default;
				case 0:
					num2 = P_1.Row + 1;
					num = 1;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
					num3 = P_1.Column;
					_ = 1;
					num = ((!zgFNgfKnEwUcU7oxul6t()) ? 4 : 5);
					break;
				default:
					num3 += P_0 % P_1.Columns;
					num = 6;
					break;
				case 6:
					return new CvsCellLocation(num2, num3);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static CvsCellLocation f6M1RPi9YT(int P_0, CvsCellRange P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CvsCellLocation cvsCellLocation = qkfVutKnXMUqN6EEC6vM(P_0, P_1);
			return new CvsCellLocation(cvsCellLocation.Row + 1, cvsCellLocation.Column);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void V51RNOKnpkfH6k3tfNQK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool K47waKKnqrrlrtBWrUhL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zgFNgfKnEwUcU7oxul6t()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation qkfVutKnXMUqN6EEC6vM(int P_0, CvsCellRange P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return cll1MDN4Z2(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HEVGDWKn9Goe9Pg9TTJD(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wZ1PZQKn4V0nmlcJxNVN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Expression;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddLink_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PropertyLinks _003C_003E4__this;

		public string dstName;

		public string srcName;

		private CvsCell _003CdstCell_003E5__2;

		private CvsCell _003CsrcCell_003E5__3;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private TaskAwaiter<object> _003C_003Eu__4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			PropertyLinks propertyLinks = default;
			TaskAwaiter<bool> awaiter2 = default;
			TaskAwaiter<CvsCellCollection> awaiter4 = default;
			TaskAwaiter<object> awaiter3 = default;
			TaskAwaiter awaiter = default;
			int num4 = default;
			WW5BIYGnekkgDixF9y wW5BIYGnekkgDixF9y = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					_ = 1;
					num = ((!V36K1PKn3i16yjlItVUp()) ? 6 : 0);
					continue;
				case 7:
					_003CdstCell_003E5__2 = null;
					goto case 2;
				default:
					num = 2;
					continue;
				case 1:
				case 6:
					propertyLinks = _003C_003E4__this;
					num = 3;
					continue;
				case 2:
					_003CsrcCell_003E5__3 = null;
					goto case 0;
				case 0:
				case 5:
					_003C_003Et__builder.SetResult();
					num = 8;
					if (true)
					{
						continue;
					}
					break;
				case 3:
					break;
				case 8:
					return;
				}
				try
				{
					int num3;
					CvsCellCollection result;
					switch (num2)
					{
					default:
						awaiter2 = propertyLinks.n8BUpNOM7M().GetAwaiter();
						num3 = 27;
						goto IL_0181;
					case 1:
						awaiter4 = _003C_003Eu__2;
						num3 = 11;
						goto IL_0181;
					case 3:
						awaiter3 = _003C_003Eu__4;
						num3 = 4;
						if (0 == 0)
						{
							goto IL_0181;
						}
						goto IL_0245;
					case 0:
						awaiter2 = _003C_003Eu__1;
						num3 = 23;
						goto IL_0181;
					case 2:
						{
							awaiter = _003C_003Eu__3;
							num3 = 16;
							if (t0fmWrKn7vmgG5sK21Jx())
							{
								goto IL_0181;
							}
							goto IL_043a;
						}
						IL_0181:
						while (true)
						{
							switch (num3)
							{
							case 30:
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 31;
								if (0 == 0)
								{
									continue;
								}
								goto case 16;
							case 16:
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0122;
							case 25:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 21;
								continue;
							case 9:
								return;
							case 26:
								return;
							case 28:
								num4 = EDK3f0Kn6nE18oW4s62o(propertyLinks.LFxUNEie7o);
								goto case 1;
							default:
								num3 = 1;
								if (0 == 0)
								{
									continue;
								}
								goto case 27;
							case 27:
								if (!awaiter2.IsCompleted)
								{
									num3 = 24;
									continue;
								}
								goto IL_0386;
							case 17:
								return;
							case 18:
								break;
							case 0:
								goto IL_027d;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 20;
									continue;
								}
								goto IL_0122;
							case 8:
							case 19:
								_003C_003Eu__2 = awaiter4;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
								return;
							case 14:
								if (_003CsrcCell_003E5__3 != null)
								{
									num3 = 28;
									if (t0fmWrKn7vmgG5sK21Jx())
									{
										continue;
									}
									return;
								}
								goto end_IL_00c1;
							case 31:
								return;
							case 10:
								_003C_003Eu__3 = awaiter;
								num3 = 25;
								if (true)
								{
									continue;
								}
								goto case 1;
							case 1:
								wW5BIYGnekkgDixF9y = new WW5BIYGnekkgDixF9y(num4, (string)ztMFqoKnCQT1sAMR2AOk(_003CdstCell_003E5__2), guABR4KnAFgGR3biiyrS(_003CdstCell_003E5__2));
								num3 = 5;
								continue;
							case 15:
								if (_003CdstCell_003E5__2 != null)
								{
									num3 = 14;
									continue;
								}
								goto end_IL_00c1;
							case 2:
								if (!awaiter3.IsCompleted)
								{
									num2 = (_003C_003E1__state = 3);
									num3 = 13;
									continue;
								}
								goto case 32;
							case 22:
								num2 = (_003C_003E1__state = -1);
								goto IL_0386;
							case 24:
								num2 = (_003C_003E1__state = 0);
								num3 = 30;
								continue;
							case 20:
								num2 = (_003C_003E1__state = 2);
								num3 = 10;
								if (true)
								{
									continue;
								}
								goto case 12;
							case 12:
								awaiter3 = ((CvsCogSocketSheet)aJhhLLKnWcpbWhFDlFTN(mnLHMpKnRLKrxHKyWSrT(propertyLinks.InSight))).PutCellExpressionAsync(LSEtFoKnTUQBK3H1AZb9(_003CdstCell_003E5__2), LSEtFoKnTUQBK3H1AZb9(_003CsrcCell_003E5__3).ToString(absoluteRow: true, absoluteColumn: true)).GetAwaiter();
								num3 = 2;
								continue;
							case 13:
								_003C_003Eu__4 = awaiter3;
								num3 = 0;
								continue;
							case 21:
								return;
							case 5:
								goto IL_043a;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 32;
								continue;
							case 23:
								_003C_003Eu__1 = default;
								num3 = 22;
								continue;
							case 11:
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
								if (true)
								{
									continue;
								}
								goto case 29;
							case 29:
								if (awaiter4.IsCompleted)
								{
									break;
								}
								goto IL_04c9;
							case 4:
								_003C_003Eu__4 = default;
								num3 = 3;
								continue;
							case 6:
								goto end_IL_00c1;
							case 32:
								{
									awaiter3.GetResult();
									goto end_IL_00c1;
								}
								IL_0122:
								awaiter.GetResult();
								num3 = 12;
								continue;
								IL_0386:
								if (awaiter2.GetResult())
								{
									num3 = 6;
									continue;
								}
								awaiter4 = propertyLinks.InSight.CogSocket.Sheet.RunAndGetCellResults().GetAwaiter();
								num3 = 29;
								continue;
							}
							break;
							IL_04c9:
							num2 = (_003C_003E1__state = 1);
							_ = 1;
							num3 = ((!V36K1PKn3i16yjlItVUp()) ? 19 : 26);
						}
						goto IL_0245;
						IL_043a:
						propertyLinks.LFxUNEie7o.Add(wW5BIYGnekkgDixF9y);
						awaiter = propertyLinks.OLIp1rdHXF(WW5BIYGnekkgDixF9y.cll1MDN4Z2(num4, propertyLinks.CellRange), dstName, wW5BIYGnekkgDixF9y).GetAwaiter();
						num3 = 7;
						goto IL_0181;
						IL_0245:
						result = awaiter4.GetResult();
						_003CdstCell_003E5__2 = (CvsCell)NCyvmtKnjn2SWhQtleTZ(result, dstName);
						_003CsrcCell_003E5__3 = (CvsCell)NCyvmtKnjn2SWhQtleTZ(result, srcName);
						num3 = 15;
						if (0 == 0)
						{
							goto IL_0181;
						}
						goto IL_027d;
						IL_027d:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						num3 = 17;
						if (V36K1PKn3i16yjlItVUp())
						{
						}
						goto IL_0181;
						end_IL_00c1:
						break;
					}
				}
				catch (Exception exception)
				{
					_003C_003E1__state = -2;
					_003CdstCell_003E5__2 = null;
					_003CsrcCell_003E5__3 = null;
					_003C_003Et__builder.SetException(exception);
					break;
				}
				_003C_003E1__state = -2;
				num = 7;
				if (V36K1PKn3i16yjlItVUp())
				{
				}
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
		internal static object NCyvmtKnjn2SWhQtleTZ(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).FindCellByName((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int EDK3f0Kn6nE18oW4s62o(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((List<WW5BIYGnekkgDixF9y>)P_0).Count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ztMFqoKnCQT1sAMR2AOk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object guABR4KnAFgGR3biiyrS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).CellValue;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mnLHMpKnRLKrxHKyWSrT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object aJhhLLKnWcpbWhFDlFTN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation LSEtFoKnTUQBK3H1AZb9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool t0fmWrKn7vmgG5sK21Jx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool V36K1PKn3i16yjlItVUp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public PropertyLinks _003C_003E4__this;

		public CvsCellCollection cells;

		public string dstName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass12_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			JnfXgEKnFSxLqhxW2DQx();
			bP20pTKnMWnx5ifj5FNc(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CRemoveLink_003Eb__0(WW5BIYGnekkgDixF9y t)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ftudSTKnYdqJbdDFuDQO(t.eFB1gh9KNF(_003C_003E4__this.CellRange, cells), dstName);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void JnfXgEKnFSxLqhxW2DQx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void bP20pTKnMWnx5ifj5FNc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kPI2tyKnyApOTx8IvA7W()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cWGVwBKn0J9YnfaJUvRa()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ftudSTKnYdqJbdDFuDQO(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRemoveLink_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PropertyLinks _003C_003E4__this;

		public string dstName;

		private _003C_003Ec__DisplayClass12_0 _003C_003E8__1;

		private WW5BIYGnekkgDixF9y _003Centry_003E5__2;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		private CvsCell _003Ccell_003E5__3;

		private TaskAwaiter<object> _003C_003Eu__2;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__3;

		private TaskAwaiter _003C_003Eu__4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			PropertyLinks propertyLinks = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003E8__1 = null;
					goto case 1;
				default:
					num = 1;
					if (!HrXyOqKnHPuOtkaACysp())
					{
						break;
					}
					goto case 5;
				case 5:
				case 7:
					_003C_003Et__builder.SetResult();
					num = 8;
					if (xSeaT6KnUvqcDwBEJyHf())
					{
						break;
					}
					goto case 1;
				case 1:
					_003Centry_003E5__2 = null;
					goto case 5;
				case 3:
					num2 = _003C_003E1__state;
					num = 0;
					break;
				case 2:
				case 6:
					try
					{
						TaskAwaiter<CvsCellCollection> awaiter4;
						TaskAwaiter<object> awaiter3;
						TaskAwaiter<CvsCogSheetResult> awaiter2;
						TaskAwaiter awaiter;
						CvsCellCollection result;
						int num3;
						List<WW5BIYGnekkgDixF9y>.Enumerator enumerator;
						switch (num2)
						{
						default:
							_003C_003E8__1 = new _003C_003Ec__DisplayClass12_0();
							_003C_003E8__1._003C_003E4__this = _003C_003E4__this;
							_003C_003E8__1.dstName = dstName;
							awaiter4 = ((CvsCogSocketSheet)KS7EsvKnxnn9l1innxu9(propertyLinks.InSight.CogSocket)).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
							if (!awaiter4.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter4;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
								return;
							}
							goto IL_015d;
						case 0:
							awaiter4 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_015d;
						case 1:
							awaiter3 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0249;
						case 2:
							awaiter2 = _003C_003Eu__3;
							_003C_003Eu__3 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_02bb;
						case 3:
							awaiter = _003C_003Eu__4;
							_003C_003Eu__4 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_033e;
						case 4:
							{
								awaiter = _003C_003Eu__4;
								_003C_003Eu__4 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_03b1;
							}
							IL_0249:
							awaiter3.GetResult();
							awaiter2 = ((CvsCogSocketSheet)KS7EsvKnxnn9l1innxu9(HqH2QsKnQ8XXEeYP21Qo(propertyLinks.InSight))).RunAsync(true).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num2 = (_003C_003E1__state = 2);
								_003C_003Eu__3 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_02bb;
							IL_015d:
							result = awaiter4.GetResult();
							_003C_003E8__1.cells = result;
							_003Centry_003E5__2 = propertyLinks.LFxUNEie7o.LastOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (WW5BIYGnekkgDixF9y t) =>
							{
								while (false)
								{
									_ = ((object[])null)[0];
								}
								return _003C_003Ec__DisplayClass12_0.ftudSTKnYdqJbdDFuDQO(t.eFB1gh9KNF(_003C_003E8__1._003C_003E4__this.CellRange, _003C_003E8__1.cells), _003C_003E8__1.dstName);
							});
							if (_003Centry_003E5__2 != null)
							{
								_003Ccell_003E5__3 = (CvsCell)j96EQvKnmOAtgpfavfpN(_003C_003E8__1.cells, _003C_003E8__1.dstName);
								if (_003Ccell_003E5__3 == null)
								{
									break;
								}
								awaiter3 = ((CvsCogSocketSheet)KS7EsvKnxnn9l1innxu9(HqH2QsKnQ8XXEeYP21Qo(propertyLinks.InSight))).PutCellExpressionAsync(_003Ccell_003E5__3.Location, (string)djJWnvKnNwaQ3LJ7dmoL(_003Centry_003E5__2)).GetAwaiter();
								if (!awaiter3.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter3;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								}
								goto IL_0249;
							}
							goto end_IL_00af;
							IL_033e:
							awaiter.GetResult();
							propertyLinks.LFxUNEie7o.Remove(_003Centry_003E5__2);
							awaiter = NOxLBIKn1157DEpabODP(propertyLinks.VUZphLkjyh());
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 4);
								_003C_003Eu__4 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_03b1;
							IL_02bb:
							awaiter2.GetResult();
							awaiter = NOxLBIKn1157DEpabODP(propertyLinks.jSIUa1579c((string)djJWnvKnNwaQ3LJ7dmoL(_003Centry_003E5__2), zbqMV1Kn2DBDIpFcuK43(_003Ccell_003E5__3), Gb63oSKnc3duk4DkPfAW(_003Centry_003E5__2)));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 3);
								_003C_003Eu__4 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_033e;
							IL_03b1:
							awaiter.GetResult();
							num3 = 0;
							enumerator = propertyLinks.LFxUNEie7o.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									enumerator.Current.H1E1lAVlky(num3++);
								}
							}
							finally
							{
								if (num2 < 0)
								{
									((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
								}
							}
							break;
						}
						_003Ccell_003E5__3 = null;
						end_IL_00af:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003E8__1 = null;
						_003Centry_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					num = 4;
					break;
				case 0:
					propertyLinks = _003C_003E4__this;
					xSeaT6KnUvqcDwBEJyHf();
					if (HrXyOqKnHPuOtkaACysp())
					{
						num = 7;
						if (true)
						{
							break;
						}
						goto case 3;
					}
					num = 6;
					break;
				case 8:
					return;
				}
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
		internal static object KS7EsvKnxnn9l1innxu9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object j96EQvKnmOAtgpfavfpN(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).FindCellByName((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HqH2QsKnQ8XXEeYP21Qo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object djJWnvKnNwaQ3LJ7dmoL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((WW5BIYGnekkgDixF9y)P_0).Mmm1WKNLPY();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation zbqMV1Kn2DBDIpFcuK43(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Gb63oSKnc3duk4DkPfAW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((WW5BIYGnekkgDixF9y)P_0).Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter NOxLBIKn1157DEpabODP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xSeaT6KnUvqcDwBEJyHf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HrXyOqKnHPuOtkaACysp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public PropertyLinks _003C_003E4__this;

		public CvsCellCollection cells;

		public string dstName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass14_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zl4ph1KntyYljlmdgH41();
			XUxLIkKnzIN26m06xwAp(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetSourceCellLocation_003Eb__0(WW5BIYGnekkgDixF9y t)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return t.eFB1gh9KNF(_003C_003E4__this.CellRange, cells) == dstName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void zl4ph1KntyYljlmdgH41()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void XUxLIkKnzIN26m06xwAp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aa0TtWKnuOtZgcbpD1OW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BjR3KSKnhRHwPy9VTgu3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public PropertyLinks _003C_003E4__this;

		public CvsCellCollection cells;

		public string dstName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass15_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hIQO2aKV5ssue1OsdRuA();
			IyvteqKVwVNyHsfjZwQe(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetDestinationCellLocation_003Eb__0(WW5BIYGnekkgDixF9y t)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CMmj45KVJRCfgotlloSp(t.eFB1gh9KNF(_003C_003E4__this.CellRange, cells), dstName);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void hIQO2aKV5ssue1OsdRuA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void IyvteqKVwVNyHsfjZwQe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LmD1uqKVLoT6QOQmjqFc()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool elU8QvKVKbiaYTrS5A3O()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CMmj45KVJRCfgotlloSp(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDuplicateLinks_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PropertyLinks _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange originalRange;

		public CvsCellRange duplicateRange;

		private int _003Ccount_003E5__2;

		private int _003Ci_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			PropertyLinks propertyLinks = default;
			TaskAwaiter awaiter = default;
			CvsCellLocation location = default;
			WW5BIYGnekkgDixF9y wW5BIYGnekkgDixF9y = default;
			int num4 = default;
			CvsCellLocation cvsCellLocation = default;
			WW5BIYGnekkgDixF9y wW5BIYGnekkgDixF9y2 = default;
			int num5 = default;
			CvsCellLocation cvsCellLocation2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					num = 5;
					if (true)
					{
						continue;
					}
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (PR1FYqKVaN2wj4bApu79())
					{
						continue;
					}
					goto case 1;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Ccount_003E5__2 = bv02HmKVO1Y5WH2LOCGH(propertyLinks.LFxUNEie7o);
							num3 = 6;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 14;
						}
						while (true)
						{
							switch (num3)
							{
							case 4:
								return;
							case 15:
								if (originalRange.Contains(location))
								{
									num3 = 8;
									break;
								}
								goto case 13;
							case 11:
								if (!awaiter.IsCompleted)
								{
									num3 = 12;
									break;
								}
								goto IL_0102;
							case 6:
								_003Ci_003E5__3 = 0;
								jgR73dKVeYj8Cc2PJVdH();
								num3 = (PR1FYqKVaN2wj4bApu79() ? 17 : 0);
								break;
							case 0:
							case 2:
								location = wW5BIYGnekkgDixF9y.THw1Q1JclM(propertyLinks.CellRange, cells);
								num3 = 15;
								break;
							case 14:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0102;
							case 7:
								awaiter = AhqL22KVDvCsBWnSuh8Q(propertyLinks.p21pzZeTE7(WW5BIYGnekkgDixF9y.cll1MDN4Z2(num4, propertyLinks.CellRange), cvsCellLocation, wW5BIYGnekkgDixF9y2));
								num3 = 11;
								if (true)
								{
									break;
								}
								goto case 10;
							case 10:
								_003Ci_003E5__3 = num5 + 1;
								num3 = 18;
								break;
							case 12:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								break;
							case 9:
								propertyLinks.LFxUNEie7o.Add(wW5BIYGnekkgDixF9y2);
								cvsCellLocation2 = new CvsCellLocation(location.Row - originalRange.Row, location.Column - originalRange.Column);
								num3 = 16;
								if (PR1FYqKVaN2wj4bApu79())
								{
									break;
								}
								goto case 3;
							case 3:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								break;
							case 5:
								wW5BIYGnekkgDixF9y2 = new WW5BIYGnekkgDixF9y(num4, (string)aoEMtnKVIBL0i5tPsHdX(wW5BIYGnekkgDixF9y), wW5BIYGnekkgDixF9y.Value);
								num3 = 9;
								if (jgR73dKVeYj8Cc2PJVdH())
								{
								}
								break;
							case 13:
								num5 = _003Ci_003E5__3;
								num3 = 10;
								break;
							case 8:
								num4 = bv02HmKVO1Y5WH2LOCGH(propertyLinks.LFxUNEie7o);
								num3 = 5;
								if (!jgR73dKVeYj8Cc2PJVdH())
								{
									break;
								}
								goto case 1;
							case 16:
								cvsCellLocation = new CvsCellLocation(duplicateRange.Row + cvsCellLocation2.Row, duplicateRange.Column + cvsCellLocation2.Column);
								goto case 7;
							default:
								num3 = 7;
								break;
							case 1:
							case 17:
							case 18:
								{
									if (_003Ci_003E5__3 < _003Ccount_003E5__2)
									{
										wW5BIYGnekkgDixF9y = propertyLinks.LFxUNEie7o[_003Ci_003E5__3];
										goto case 0;
									}
									goto end_IL_028e;
								}
								IL_0102:
								awaiter.GetResult();
								num3 = 13;
								if (true)
								{
									break;
								}
								goto case 7;
							}
							continue;
							end_IL_028e:
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 5:
					break;
				case 6:
					return;
				}
				do
				{
					propertyLinks = _003C_003E4__this;
					_ = 1;
					if (jgR73dKVeYj8Cc2PJVdH())
					{
						num = 4;
						continue;
					}
					num = 1;
					break;
				}
				while (false);
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
		internal static int bv02HmKVO1Y5WH2LOCGH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((List<WW5BIYGnekkgDixF9y>)P_0).Count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object aoEMtnKVIBL0i5tPsHdX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((WW5BIYGnekkgDixF9y)P_0).Mmm1WKNLPY();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter AhqL22KVDvCsBWnSuh8Q(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PR1FYqKVaN2wj4bApu79()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jgR73dKVeYj8Cc2PJVdH()
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
	private struct _003CClearAndRewriteAllLinkCells_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PropertyLinks _003C_003E4__this;

		private CvsCellCollection _003Ccells_003E5__2;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		private TaskAwaiter<object> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!O10uioKViwPYUABt5jG2()) ? 6 : 5);
			int num2 = default;
			TaskAwaiter<CvsCellCollection> awaiter = default;
			PropertyLinks propertyLinks = default;
			TaskAwaiter awaiter3 = default;
			TaskAwaiter<object> awaiter4 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter2 = default;
			CvsCellRange cellRange = default;
			CvsCellCollection result = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							awaiter = ((CvsCogSocketSheet)Lcxp4yKVfdPX3BaWR2Wn(QfffXkKVVcqC2CplIREi(propertyLinks.InSight))).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
							num3 = 23;
							if (RoFmaWKVnmlGc9YmLKKg())
							{
							}
							break;
						case 2:
							awaiter3 = _003C_003Eu__3;
							num3 = 32;
							break;
						case 1:
							awaiter4 = _003C_003Eu__2;
							num3 = 4;
							break;
						case 3:
							awaiter2 = _003C_003Eu__4;
							num3 = 11;
							break;
						case 4:
							awaiter3 = _003C_003Eu__3;
							_003C_003Eu__3 = default;
							num3 = 20;
							break;
						case 5:
							awaiter2 = _003C_003Eu__4;
							num3 = 40;
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 35;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 36:
								return;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
								return;
							case 37:
								num2 = (_003C_003E1__state = -1);
								goto IL_00b8;
							case 38:
								cellRange.Rows -= 2;
								num3 = 10;
								continue;
							case 10:
								awaiter4 = ((CvsCogSocketSheet)Lcxp4yKVfdPX3BaWR2Wn(QfffXkKVVcqC2CplIREi(propertyLinks.InSight))).ClearCellsAsync(cellRange).GetAwaiter();
								num3 = 14;
								continue;
							case 29:
								return;
							case 1:
								awaiter3 = mAnIG9KVd1JYmQcB7Iie(propertyLinks.pHQpmmiH6Q());
								num3 = 39;
								continue;
							case 15:
								num2 = (_003C_003E1__state = 1);
								num3 = 24;
								continue;
							case 34:
								awaiter2 = ((CvsCogSocketSheet)Lcxp4yKVfdPX3BaWR2Wn(QfffXkKVVcqC2CplIREi(propertyLinks.InSight))).RunAsync(true).GetAwaiter();
								num3 = 33;
								continue;
							case 22:
								return;
							case 4:
								_003C_003Eu__2 = default;
								num3 = 12;
								continue;
							case 5:
								num2 = (_003C_003E1__state = 0);
								_ = 1;
								if (RoFmaWKVnmlGc9YmLKKg())
								{
									num3 = 41;
									continue;
								}
								num3 = 16;
								if (O10uioKViwPYUABt5jG2())
								{
									continue;
								}
								goto case 28;
							case 28:
								num2 = (_003C_003E1__state = 5);
								_003C_003Eu__4 = awaiter2;
								num3 = 31;
								continue;
							case 18:
								_003C_003Eu__4 = awaiter2;
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 14;
							case 14:
								if (!awaiter4.IsCompleted)
								{
									num3 = 15;
									continue;
								}
								goto case 17;
							case 33:
								if (!awaiter2.IsCompleted)
								{
									num3 = 13;
									continue;
								}
								goto IL_0415;
							case 17:
								awaiter4.GetResult();
								awaiter3 = propertyLinks.ROMp8Peer5(_003Ccells_003E5__2).GetAwaiter();
								num3 = 0;
								continue;
							case 31:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 30;
								if (true)
								{
									continue;
								}
								return;
							case 30:
								return;
							case 35:
								_003C_003Eu__1 = default;
								num3 = 37;
								continue;
							case 13:
								num2 = (_003C_003E1__state = 3);
								num3 = 18;
								continue;
							case 25:
								awaiter3.GetResult();
								awaiter2 = ((CvsCogSocket)QfffXkKVVcqC2CplIREi(propertyLinks.InSight)).Sheet.RunAsync(new Dictionary<string, object>()).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num3 = 28;
									continue;
								}
								break;
							case 40:
								_003C_003Eu__4 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 42;
								continue;
							case 39:
								if (!awaiter3.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 25;
							case 12:
								num2 = (_003C_003E1__state = -1);
								num3 = 17;
								if (true)
								{
									continue;
								}
								goto case 3;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 29;
								if (!RoFmaWKVnmlGc9YmLKKg())
								{
									continue;
								}
								goto case 6;
							case 6:
							case 41:
								_003Ccells_003E5__2 = result;
								cellRange = propertyLinks.CellRange;
								cellRange.Row++;
								num3 = 38;
								continue;
							case 23:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								goto IL_00b8;
							case 0:
								if (!awaiter3.IsCompleted)
								{
									num3 = 19;
									continue;
								}
								goto IL_0548;
							case 8:
								num2 = (_003C_003E1__state = 4);
								num3 = 26;
								if (true)
								{
									continue;
								}
								goto case 19;
							case 19:
								num2 = (_003C_003E1__state = 2);
								_003C_003Eu__3 = awaiter3;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								num3 = 36;
								continue;
							case 26:
								_003C_003Eu__3 = awaiter3;
								num3 = 27;
								if (true)
								{
									continue;
								}
								goto case 11;
							case 11:
								_003C_003Eu__4 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0415;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 32:
								_003C_003Eu__3 = default;
								goto case 21;
							default:
								num3 = 21;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
							case 16:
								_003C_003Eu__1 = awaiter;
								num3 = 9;
								continue;
							case 21:
								num2 = (_003C_003E1__state = -1);
								goto IL_0548;
							case 24:
								_003C_003Eu__2 = awaiter4;
								num3 = 7;
								continue;
							case 20:
								num2 = (_003C_003E1__state = -1);
								num3 = 25;
								continue;
							case 27:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								num3 = 22;
								continue;
							case 42:
								break;
								IL_0548:
								awaiter3.GetResult();
								num3 = 34;
								continue;
								IL_0415:
								awaiter2.GetResult();
								num3 = 1;
								if (O10uioKViwPYUABt5jG2())
								{
									continue;
								}
								goto case 9;
								IL_00b8:
								result = awaiter.GetResult();
								goto case 6;
							}
							break;
						}
						awaiter2.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Ccells_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				default:
					num = 3;
					continue;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 7;
					if (RoFmaWKVnmlGc9YmLKKg())
					{
					}
					continue;
				case 1:
				case 6:
					propertyLinks = _003C_003E4__this;
					num = 2;
					continue;
				case 3:
					break;
				case 7:
					return;
				}
				_003Ccells_003E5__2 = null;
				num = 4;
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
		internal static object QfffXkKVVcqC2CplIREi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Lcxp4yKVfdPX3BaWR2Wn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter mAnIG9KVd1JYmQcB7Iie(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool O10uioKViwPYUABt5jG2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RoFmaWKVnmlGc9YmLKKg()
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
	private struct _003CSetLinkCellExpressions_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PropertyLinks _003C_003E4__this;

		public CvsCellCollection cells;

		private int _003Ci_003E5__2;

		private WW5BIYGnekkgDixF9y _003ClinkEntry_003E5__3;

		private CvsCellLocation _003ClinkExprLocation_003E5__4;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!DOxk4rKVgxf7hSIRaVKB())
			{
				num = 4;
				if (false)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_03e6;
			IL_0411:
			PropertyLinks propertyLinks = _003C_003E4__this;
			num = 2;
			if (DOxk4rKVgxf7hSIRaVKB())
			{
				return;
			}
			goto IL_03e6;
			IL_03e6:
			int num2 = default;
			TaskAwaiter<object> awaiter = default;
			CvsCellLocation location = default;
			int num4 = default;
			CvsCell cvsCell = default;
			CvsCellRange cellRange = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					break;
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 17;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num3 = 21;
								if (1 == 0)
								{
									goto IL_0395;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 18;
							if (false)
							{
								goto IL_015c;
							}
						}
						goto IL_0089;
						IL_021f:
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 1);
							_003C_003Eu__1 = awaiter;
							num3 = 12;
							goto IL_0089;
						}
						goto IL_020d;
						IL_0395:
						if (_003Ci_003E5__2 < a2sHyiKVGRNTaYH8J939(propertyLinks.LFxUNEie7o))
						{
							_003ClinkEntry_003E5__3 = propertyLinks.LFxUNEie7o[_003Ci_003E5__2];
							location = (_003ClinkExprLocation_003E5__4 = aOqSyTKVsE56D3XPXjp8(_003Ci_003E5__2, propertyLinks.CellRange));
							num3 = 19;
							if (true)
							{
								goto IL_0089;
							}
							goto IL_01d0;
						}
						goto end_IL_0052;
						IL_020d:
						awaiter.GetResult();
						num3 = 8;
						goto IL_0089;
						IL_015c:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						IL_0089:
						while (true)
						{
							switch (num3)
							{
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 20;
								if (0 == 0)
								{
									continue;
								}
								goto case 21;
							case 21:
								num2 = (_003C_003E1__state = -1);
								num3 = 7;
								continue;
							case 11:
								num4 = _003Ci_003E5__2;
								num3 = 23;
								continue;
							case 23:
								_003Ci_003E5__2 = num4 + 1;
								num3 = 24;
								continue;
							case 20:
								return;
							case 12:
								break;
							case 14:
								goto IL_01d0;
							case 7:
								goto IL_020d;
							case 5:
							case 15:
								goto IL_021f;
							case 18:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 9:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								continue;
							case 2:
							case 3:
								_003Ci_003E5__2 = 0;
								num3 = 22;
								continue;
							case 6:
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								continue;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									continue;
								}
								goto case 16;
							case 13:
								cvsCell = (CvsCell)Q2DFDbKVro8D5LF8tLr4(cells, BWwOCbKVvQsEHqF7mvbM(_003ClinkEntry_003E5__3, propertyLinks.CellRange, cells));
								num3 = 10;
								continue;
							case 8:
								_003ClinkEntry_003E5__3 = null;
								_003ClinkExprLocation_003E5__4 = default;
								num3 = 11;
								continue;
							case 19:
								num4 = _003ClinkExprLocation_003E5__4.Row++;
								num3 = 13;
								continue;
							case 1:
								goto IL_0311;
							case 16:
								awaiter.GetResult();
								num3 = 14;
								continue;
							case 17:
								cellRange = propertyLinks.CellRange;
								num3 = 1;
								if (!DOxk4rKVgxf7hSIRaVKB())
								{
									continue;
								}
								goto case 10;
							case 10:
								awaiter = ((CvsCogSocketSheet)L0wqQnKVZDtvQRuUbyd2(bJNrjsKVPQg8eVQwYPXV(propertyLinks.InSight))).PutCellExpressionAsync(location, HHYp7CKVB2xRgdZsKknU(cvsCell).ToString(absoluteRow: true, absoluteColumn: true)).GetAwaiter();
								num3 = 0;
								continue;
							case 22:
							case 24:
								goto IL_0395;
							}
							break;
							IL_0311:
							_ = cellRange.Location;
							DOxk4rKVgxf7hSIRaVKB();
							num3 = (FagERuKVlkhXDXoZcAxT() ? 3 : 5);
						}
						goto IL_015c;
						IL_01d0:
						awaiter = ((CvsCogSocketSheet)L0wqQnKVZDtvQRuUbyd2(bJNrjsKVPQg8eVQwYPXV(propertyLinks.InSight))).PutCellExpressionAsync(_003ClinkExprLocation_003E5__4, (string)nPlI6hKVbOOl06saFusq(_003ClinkEntry_003E5__3)).GetAwaiter();
						goto IL_021f;
						end_IL_0052:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 3;
				default:
					num = 3;
					continue;
				case 1:
				case 5:
					goto IL_0411;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			num2 = _003C_003E1__state;
			goto IL_0411;
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
		internal static CvsCellLocation aOqSyTKVsE56D3XPXjp8(int P_0, CvsCellRange P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WW5BIYGnekkgDixF9y.cll1MDN4Z2(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BWwOCbKVvQsEHqF7mvbM(object P_0, CvsCellRange P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((WW5BIYGnekkgDixF9y)P_0).eFB1gh9KNF(P_1, (CvsCellCollection)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Q2DFDbKVro8D5LF8tLr4(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).FindCellByName((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bJNrjsKVPQg8eVQwYPXV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object L0wqQnKVZDtvQRuUbyd2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation HHYp7CKVB2xRgdZsKknU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nPlI6hKVbOOl06saFusq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((WW5BIYGnekkgDixF9y)P_0).Mmm1WKNLPY();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int a2sHyiKVGRNTaYH8J939(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((List<WW5BIYGnekkgDixF9y>)P_0).Count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FagERuKVlkhXDXoZcAxT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DOxk4rKVgxf7hSIRaVKB()
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
	private struct _003CSetLinkCellValues_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PropertyLinks _003C_003E4__this;

		private int _003Ci_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			CvsCellRange cellRange = default;
			PropertyLinks propertyLinks = default;
			TaskAwaiter awaiter = default;
			int num2 = default;
			WW5BIYGnekkgDixF9y wW5BIYGnekkgDixF9y = default;
			CvsCellLocation cvsCellLocation = default;
			int num4 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							cellRange = propertyLinks.CellRange;
							num3 = 13;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							Dj7JRtKVoJ2ago1NqcQ7();
							num3 = (UAaXWRKVSZCyBkoWlDug() ? 12 : 6);
						}
						while (true)
						{
							switch (num3)
							{
							case 6:
							case 7:
								_003C_003Eu__1 = default;
								num3 = 3;
								continue;
							case 2:
								num2 = (_003C_003E1__state = 0);
								goto case 5;
							default:
								num3 = 5;
								continue;
							case 5:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 13:
								_ = cellRange.Location;
								_003Ci_003E5__2 = 0;
								num3 = 1;
								if (0 == 0)
								{
									continue;
								}
								goto case 8;
							case 8:
								awaiter.GetResult();
								num3 = 0;
								if (0 == 0)
								{
									continue;
								}
								goto case 4;
							case 4:
								awaiter = kvt5WyKVEKF7j9KontWT(propertyLinks.jSIUa1579c((string)qbAce7KV8Yxs5Cwj0MkS(wW5BIYGnekkgDixF9y), cvsCellLocation, dQFHXmKVq1hA6nMT40sH(wW5BIYGnekkgDixF9y)));
								num3 = 10;
								continue;
							case 0:
								num4 = _003Ci_003E5__2;
								goto case 11;
							case 11:
							case 12:
								_003Ci_003E5__2 = num4 + 1;
								num3 = 14;
								continue;
							case 9:
								wW5BIYGnekkgDixF9y = propertyLinks.LFxUNEie7o[_003Ci_003E5__2];
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto case 10;
							case 10:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								goto case 8;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 8;
								continue;
							case 1:
							case 14:
								if (_003Ci_003E5__2 < propertyLinks.LFxUNEie7o.Count)
								{
									cvsCellLocation = Aq1tFfKVkU5JOxnAFoj6(_003Ci_003E5__2, propertyLinks.CellRange);
									num3 = 9;
									continue;
								}
								break;
							}
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				default:
					num = 5;
					continue;
				case 0:
					num2 = _003C_003E1__state;
					_ = 1;
					if (!UAaXWRKVSZCyBkoWlDug())
					{
						num = 4;
						if (0 == 0)
						{
							continue;
						}
						goto case 1;
					}
					num = 3;
					if (!UAaXWRKVSZCyBkoWlDug())
					{
						continue;
					}
					break;
				case 1:
				case 4:
					propertyLinks = _003C_003E4__this;
					goto case 2;
				case 5:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
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
		internal static CvsCellLocation Aq1tFfKVkU5JOxnAFoj6(int P_0, CvsCellRange P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WW5BIYGnekkgDixF9y.f6M1RPi9YT(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qbAce7KV8Yxs5Cwj0MkS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((WW5BIYGnekkgDixF9y)P_0).Mmm1WKNLPY();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dQFHXmKVq1hA6nMT40sH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((WW5BIYGnekkgDixF9y)P_0).Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter kvt5WyKVEKF7j9KontWT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Dj7JRtKVoJ2ago1NqcQ7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UAaXWRKVSZCyBkoWlDug()
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
	private struct _003CWriteLink_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PropertyLinks _003C_003E4__this;

		public string dstName;

		public CvsCellLocation linkRefLocation;

		public WW5BIYGnekkgDixF9y entry;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			TaskAwaiter awaiter2 = default;
			TaskAwaiter<CvsCellCollection> awaiter = default;
			PropertyLinks propertyLinks = default;
			CvsCell cvsCell = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
				case 3:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = 3;
							break;
						case 1:
							awaiter2 = _003C_003Eu__2;
							num3 = 1;
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							QFM3EZKVXfcJ4J2KXVdb();
							if (gsb8jAKVpbLY6WG400Z8())
							{
								num3 = 12;
								break;
							}
							num3 = 13;
							if (QFM3EZKVXfcJ4J2KXVdb())
							{
							}
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 11:
								_003C_003Eu__2 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 2;
								if (QFM3EZKVXfcJ4J2KXVdb())
								{
								}
								continue;
							case 2:
								return;
							case 1:
								_003C_003Eu__2 = default;
								num3 = 15;
								continue;
							case 15:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 14:
								return;
							case 5:
							case 12:
								num2 = (_003C_003E1__state = -1);
								num3 = 6;
								continue;
							case 8:
							case 13:
								awaiter2 = Fj6COsKV33CWO4xcZLPS(propertyLinks.p21pzZeTE7(linkRefLocation, P97lhJKV7I6v2GvAr2XT(cvsCell), entry));
								num3 = 0;
								continue;
							case 7:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								continue;
							case 3:
								awaiter = ((CvsCogSocket)VdsVDpKV9XkWO5H5G6nL(propertyLinks.InSight)).Sheet.RunAndGetCellResults().GetAwaiter();
								num3 = 9;
								continue;
							case 6:
								cvsCell = (CvsCell)IC2mRxKV4smqOIPlMwCt(awaiter.GetResult(), dstName);
								goto case 10;
							default:
								num3 = 10;
								continue;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 14;
								continue;
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto case 6;
							case 0:
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 11;
									continue;
								}
								break;
							case 10:
								if (cvsCell != null)
								{
									goto case 8;
								}
								goto end_IL_0181;
							case 16:
								break;
							}
							awaiter2.GetResult();
							break;
							continue;
							end_IL_0181:
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 5;
				default:
					num = 5;
					break;
				case 0:
				case 1:
					propertyLinks = _003C_003E4__this;
					goto case 2;
				case 4:
					num2 = _003C_003E1__state;
					QFM3EZKVXfcJ4J2KXVdb();
					num = ((!gsb8jAKVpbLY6WG400Z8()) ? 3 : 0);
					break;
				case 6:
					return;
				}
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
		internal static object VdsVDpKV9XkWO5H5G6nL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IC2mRxKV4smqOIPlMwCt(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).FindCellByName((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation P97lhJKV7I6v2GvAr2XT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Fj6COsKV33CWO4xcZLPS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gsb8jAKVpbLY6WG400Z8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QFM3EZKVXfcJ4J2KXVdb()
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
	private struct _003CWriteLink_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCellLocation linkRefLocation;

		public PropertyLinks _003C_003E4__this;

		public CvsCellLocation destinationLocation;

		public WW5BIYGnekkgDixF9y entry;

		private CvsCellLocation _003ClinkExprLocation_003E5__2;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			PropertyLinks propertyLinks = default;
			int num2 = default;
			TaskAwaiter awaiter3 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter2 = default;
			TaskAwaiter<object> awaiter = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 5:
					propertyLinks = _003C_003E4__this;
					_ = 1;
					num = (gKDkpeKV6G5DmJpTkxEM() ? 1 : 0);
					break;
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				case 0:
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							_003ClinkExprLocation_003E5__2 = linkRefLocation;
							num3 = 27;
							goto IL_01f6;
						case 3:
							awaiter3 = _003C_003Eu__3;
							_003C_003Eu__3 = default;
							num3 = 24;
							goto IL_01f6;
						case 2:
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							goto IL_009d;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 22;
							goto IL_01f6;
						case 1:
							{
								awaiter = _003C_003Eu__1;
								num3 = 2;
								goto IL_01f6;
							}
							IL_01f6:
							while (true)
							{
								switch (num3)
								{
								case 0:
									if (!awaiter3.IsCompleted)
									{
										num3 = 15;
										continue;
									}
									goto case 28;
								case 18:
								case 21:
									break;
								case 12:
									awaiter2 = ((CvsCogSocketSheet)iyst55KVAqPIgA3BWNVA(zQRmtfKVCovALo4p0jXT(propertyLinks.InSight))).RunAsync(true).GetAwaiter();
									num3 = 26;
									continue;
								case 15:
									num2 = (_003C_003E1__state = 3);
									num3 = 7;
									if (true)
									{
										continue;
									}
									goto case 11;
								case 11:
									awaiter.GetResult();
									num3 = 16;
									if (0 == 0)
									{
										continue;
									}
									goto case 17;
								case 17:
									_003C_003Eu__1 = awaiter;
									num3 = 6;
									continue;
								case 14:
									awaiter2.GetResult();
									num3 = 23;
									continue;
								case 26:
									if (!awaiter2.IsCompleted)
									{
										num2 = (_003C_003E1__state = 2);
										_003C_003Eu__2 = awaiter2;
										num3 = 20;
										continue;
									}
									goto case 14;
								case 24:
									num2 = (_003C_003E1__state = -1);
									num3 = 28;
									if (true)
									{
										continue;
									}
									goto case 5;
								case 5:
									num2 = (_003C_003E1__state = 0);
									num3 = 17;
									continue;
								case 16:
									awaiter = propertyLinks.InSight.CogSocket.Sheet.PutCellExpressionAsync(_003ClinkExprLocation_003E5__2, (string)riiSpxKVROGgFtRuBhTi(entry)).GetAwaiter();
									num3 = 25;
									continue;
								case 25:
									if (!awaiter.IsCompleted)
									{
										num3 = 19;
										if (0 == 0)
										{
											continue;
										}
										goto case 7;
									}
									goto case 13;
								case 7:
									_003C_003Eu__3 = awaiter3;
									num3 = 3;
									if (GvCLeCKVj0g5VZYHfocc())
									{
										continue;
									}
									goto case 2;
								case 2:
									_003C_003Eu__1 = default;
									goto case 9;
								default:
									num3 = 9;
									continue;
								case 23:
									awaiter3 = vGj6ABKVWEQTiUIgPqP1(propertyLinks.jSIUa1579c((string)riiSpxKVROGgFtRuBhTi(entry), _003ClinkExprLocation_003E5__2, entry.Value));
									num3 = 0;
									continue;
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								case 10:
									num2 = (_003C_003E1__state = -1);
									num3 = 11;
									if (0 == 0)
									{
										continue;
									}
									goto case 22;
								case 22:
									_003C_003Eu__1 = default;
									num3 = 10;
									continue;
								case 9:
									num2 = (_003C_003E1__state = -1);
									num3 = 13;
									if (0 == 0)
									{
										continue;
									}
									goto case 20;
								case 20:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								case 6:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 27:
									_003ClinkExprLocation_003E5__2.Row++;
									awaiter = ((CvsCogSocketSheet)iyst55KVAqPIgA3BWNVA(zQRmtfKVCovALo4p0jXT(propertyLinks.InSight))).PutCellExpressionAsync(linkRefLocation, destinationLocation.ToString(absoluteRow: true, absoluteColumn: true)).GetAwaiter();
									_ = 1;
									if (gKDkpeKV6G5DmJpTkxEM())
									{
										num3 = 21;
										continue;
									}
									num3 = 8;
									if (GvCLeCKVj0g5VZYHfocc())
									{
										continue;
									}
									goto case 1;
								case 1:
								case 8:
									if (awaiter.IsCompleted)
									{
										goto case 11;
									}
									num3 = 5;
									if (GvCLeCKVj0g5VZYHfocc())
									{
										continue;
									}
									goto case 19;
								case 19:
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__1 = awaiter;
									num3 = 4;
									continue;
								case 13:
									awaiter.GetResult();
									num3 = 12;
									if (true)
									{
										continue;
									}
									goto case 4;
								case 4:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 28:
									awaiter3.GetResult();
									goto end_IL_01f6;
								}
								goto IL_009d;
								continue;
								end_IL_01f6:
								break;
							}
							break;
							IL_009d:
							num2 = (_003C_003E1__state = -1);
							num3 = 14;
							goto IL_01f6;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 6:
					return;
				}
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
		internal static object zQRmtfKVCovALo4p0jXT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iyst55KVAqPIgA3BWNVA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object riiSpxKVROGgFtRuBhTi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((WW5BIYGnekkgDixF9y)P_0).Mmm1WKNLPY();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter vGj6ABKVWEQTiUIgPqP1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GvCLeCKVj0g5VZYHfocc()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gKDkpeKV6G5DmJpTkxEM()
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
	private struct _003CWriteValueAsync_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string expr;

		public object cellValue;

		public PropertyLinks _003C_003E4__this;

		public CvsCellLocation loc;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!OZUh1hKVTAVhN9sRv3aP()) ? 2 : 5);
			PropertyLinks propertyLinks = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			string text = default;
			int num4 = default;
			int num6 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					propertyLinks = _003C_003E4__this;
					num = 3;
					if (true)
					{
						continue;
					}
					break;
				case 4:
					break;
				case 3:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							if (DvvLfxKVFrHNBMynEixS(expr, VJTxApKV0sSivDxv4Qq1(33756), StringComparison.InvariantCultureIgnoreCase))
							{
								num3 = 16;
								goto IL_0279;
							}
							if (DvvLfxKVFrHNBMynEixS(expr, VJTxApKV0sSivDxv4Qq1(33738), StringComparison.InvariantCultureIgnoreCase))
							{
								num3 = 17;
								goto IL_0279;
							}
							if (DvvLfxKVFrHNBMynEixS(expr, VJTxApKV0sSivDxv4Qq1(33894), StringComparison.InvariantCultureIgnoreCase))
							{
								num3 = 39;
								goto IL_0279;
							}
							if (DvvLfxKVFrHNBMynEixS(expr, VJTxApKV0sSivDxv4Qq1(1450), StringComparison.InvariantCultureIgnoreCase))
							{
								num3 = 3;
								goto IL_0279;
							}
							if (DvvLfxKVFrHNBMynEixS(expr, VJTxApKV0sSivDxv4Qq1(33688), StringComparison.InvariantCultureIgnoreCase) && cellValue is bool)
							{
								bool flag = (bool)cellValue;
								awaiter = cxth8VKVMblBL5w6jD0i(propertyLinks.pTlU5735Oy(loc, flag));
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 40;
								goto IL_0279;
							}
							goto end_IL_004c;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 12;
							goto IL_0279;
						case 1:
							awaiter = _003C_003Eu__1;
							num3 = 29;
							goto IL_0279;
						case 3:
							awaiter = _003C_003Eu__1;
							num3 = 4;
							goto IL_0279;
						case 2:
							awaiter = _003C_003Eu__1;
							num3 = 22;
							if (false)
							{
								return;
							}
							goto IL_0279;
						case 4:
							{
								awaiter = _003C_003Eu__1;
								num3 = 21;
								goto IL_0279;
							}
							IL_0279:
							while (true)
							{
								switch (num3)
								{
								case 27:
									_003C_003Eu__1 = awaiter;
									num3 = 15;
									continue;
								case 3:
									text = cellValue as string;
									num3 = 14;
									continue;
								case 0:
									goto end_IL_0279;
								case 22:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 13;
									continue;
								case 9:
									_003C_003Eu__1 = awaiter;
									num3 = 25;
									continue;
								case 10:
									if (!awaiter.IsCompleted)
									{
										num3 = 5;
										continue;
									}
									goto case 13;
								case 23:
									num2 = (_003C_003E1__state = -1);
									goto IL_016e;
								case 28:
									if (!awaiter.IsCompleted)
									{
										num3 = 19;
										if (true)
										{
											continue;
										}
										goto case 40;
									}
									goto case 1;
								case 40:
									num2 = (_003C_003E1__state = 4);
									num3 = 32;
									if (AC8tZTKVyMEI2hpWuGrk())
									{
									}
									continue;
								case 11:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 31;
									continue;
								case 14:
									if (text != null)
									{
										awaiter = cxth8VKVMblBL5w6jD0i(propertyLinks.pTlU5735Oy(loc, text));
										num3 = 41;
										continue;
									}
									goto end_IL_0279;
								case 19:
									num2 = (_003C_003E1__state = 1);
									num3 = 27;
									continue;
								case 38:
									awaiter = cxth8VKVMblBL5w6jD0i(propertyLinks.pTlU5735Oy(loc, num4));
									num3 = 28;
									if (!AC8tZTKVyMEI2hpWuGrk())
									{
										continue;
									}
									goto case 21;
								case 21:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 43;
									if (0 == 0)
									{
										continue;
									}
									goto case 36;
								case 36:
									num6 = (int)cellValue;
									goto case 42;
								default:
									num3 = 42;
									continue;
								case 33:
									if (!awaiter.IsCompleted)
									{
										num3 = 26;
										continue;
									}
									goto IL_016e;
								case 24:
								case 35:
									_003C_003Eu__1 = awaiter;
									num3 = 20;
									continue;
								case 32:
									_003C_003Eu__1 = awaiter;
									num3 = 6;
									continue;
								case 26:
									num2 = (_003C_003E1__state = 0);
									num3 = 34;
									if (!AC8tZTKVyMEI2hpWuGrk())
									{
										continue;
									}
									goto case 16;
								case 16:
									if (cellValue is double)
									{
										double num5 = (double)cellValue;
										awaiter = propertyLinks.pTlU5735Oy(loc, num5).GetAwaiter();
										num3 = 33;
										continue;
									}
									goto end_IL_0279;
								case 18:
									num2 = (_003C_003E1__state = -1);
									num3 = 1;
									continue;
								case 31:
									return;
								case 8:
								case 37:
									goto end_IL_0279;
								case 12:
									_003C_003Eu__1 = default;
									num3 = 23;
									if (0 == 0)
									{
										continue;
									}
									goto end_IL_0279;
								case 7:
									goto end_IL_0279;
								case 34:
									_003C_003Eu__1 = awaiter;
									num3 = 11;
									if (AC8tZTKVyMEI2hpWuGrk())
									{
									}
									continue;
								case 4:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_048c;
								case 39:
									if (cellValue is int)
									{
										num3 = 36;
										continue;
									}
									goto end_IL_0279;
								case 15:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 1:
									awaiter.GetResult();
									num3 = 7;
									continue;
								case 5:
									num2 = (_003C_003E1__state = 2);
									goto case 24;
								case 2:
									return;
								case 29:
									_003C_003Eu__1 = default;
									num3 = 18;
									continue;
								case 41:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 3);
										num3 = 9;
										continue;
									}
									goto IL_048c;
								case 42:
									awaiter = cxth8VKVMblBL5w6jD0i(propertyLinks.pTlU5735Oy(loc, num6));
									num3 = 10;
									if (true)
									{
										continue;
									}
									goto case 6;
								case 6:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 30;
									continue;
								case 17:
									if (cellValue is int)
									{
										num4 = (int)cellValue;
										num3 = 38;
										if (AC8tZTKVyMEI2hpWuGrk())
										{
										}
										continue;
									}
									goto end_IL_0279;
								case 20:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 30:
									return;
								case 25:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 2;
									continue;
								case 13:
									awaiter.GetResult();
									goto end_IL_0279;
								case 43:
									break;
									IL_016e:
									awaiter.GetResult();
									_ = 1;
									num3 = (AC8tZTKVyMEI2hpWuGrk() ? 35 : 37);
									continue;
									IL_048c:
									awaiter.GetResult();
									num3 = 0;
									continue;
								}
								goto end_IL_004d;
								continue;
								end_IL_0279:
								break;
							}
							goto end_IL_004c;
							end_IL_004d:
							break;
						}
						awaiter.GetResult();
						end_IL_004c:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				default:
					num = 4;
					if (true)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
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
		internal static object VJTxApKV0sSivDxv4Qq1(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DvvLfxKVFrHNBMynEixS(object P_0, object P_1, StringComparison P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).StartsWith((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter cxth8VKVMblBL5w6jD0i(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OZUh1hKVTAVhN9sRv3aP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AC8tZTKVyMEI2hpWuGrk()
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
	private struct _003CWriteValueAsync_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PropertyLinks _003C_003E4__this;

		public CvsCellLocation loc;

		public object cellValue;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private TaskAwaiter<CvsCogEditInfo[]> _003C_003Eu__1;

		private TaskAwaiter<CvsCogEditingObject> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			PropertyLinks propertyLinks = default;
			TaskAwaiter<CvsCogEditingObject> awaiter3 = default;
			TaskAwaiter<CvsCogEditInfo[]> awaiter2 = default;
			TaskAwaiter awaiter = default;
			CvsCogEditInfo[] result2 = default;
			CvsCogEditingObject result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					_003Csheet_003E5__2 = null;
					num = 5;
					continue;
				case 2:
				case 6:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							_003Csheet_003E5__2 = (CvsCogSocketSheet)yuLUrdKVHy2WufIvaFlY(propertyLinks.InSight.CogSocket);
							num3 = 8;
							goto IL_00c7;
						case 1:
							awaiter3 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num3 = 22;
							if (0 == 0)
							{
								goto IL_00c7;
							}
							goto IL_026e;
						case 0:
							awaiter2 = _003C_003Eu__1;
							IWBNkdKVYBNllp9FGAYC();
							num3 = ((!timq1gKVUe24QPP01PKJ()) ? 20 : 18);
							goto IL_00c7;
						case 2:
							{
								awaiter = _003C_003Eu__3;
								num3 = 19;
								goto IL_00c7;
							}
							IL_00c7:
							while (true)
							{
								switch (num3)
								{
								case 6:
								case 20:
									_003C_003Eu__1 = default;
									num3 = 11;
									continue;
								case 12:
									_003C_003Eu__1 = awaiter2;
									num3 = 21;
									continue;
								case 9:
								case 18:
									if (result2.Length == 1)
									{
										num3 = 17;
										if (!timq1gKVUe24QPP01PKJ())
										{
											continue;
										}
										goto case 17;
									}
									goto end_IL_00c7;
								case 17:
									awaiter3 = _003Csheet_003E5__2.EditEditableObjectAsync((string)Vk1BFyKVx8ZprXMgsuaj(result2[0])).GetAwaiter();
									goto case 14;
								default:
									num3 = 14;
									continue;
								case 4:
									num2 = (_003C_003E1__state = 2);
									_003C_003Eu__3 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 15;
									if (timq1gKVUe24QPP01PKJ())
									{
									}
									continue;
								case 21:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 0;
									continue;
								case 10:
									num2 = (_003C_003E1__state = 0);
									num3 = 12;
									continue;
								case 5:
									_003C_003Eu__2 = awaiter3;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num3 = 3;
									if (timq1gKVUe24QPP01PKJ())
									{
									}
									continue;
								case 2:
									num2 = (_003C_003E1__state = 1);
									num3 = 5;
									if (0 == 0)
									{
										continue;
									}
									goto case 13;
								case 13:
									if (result2 != null)
									{
										goto case 9;
									}
									goto end_IL_00c7;
								case 11:
									num2 = (_003C_003E1__state = -1);
									goto IL_01f6;
								case 8:
									awaiter2 = _003Csheet_003E5__2.GetEditInfoAsync(loc).GetAwaiter();
									num3 = 16;
									if (timq1gKVUe24QPP01PKJ())
									{
									}
									continue;
								case 14:
									if (!awaiter3.IsCompleted)
									{
										num3 = 2;
										continue;
									}
									goto case 1;
								case 3:
									return;
								case 22:
									break;
								case 23:
									if (result != null)
									{
										awaiter = BOCq5hKVNsoO5AbjHLMP(gO9liXKVQ9XMB0GDNnA3(_003Csheet_003E5__2, bdD4JOKVma4FejDYfc37(result), cellValue));
										if (!awaiter.IsCompleted)
										{
											num3 = 4;
											continue;
										}
										goto case 24;
									}
									goto end_IL_00c7;
								case 0:
									return;
								case 19:
									_003C_003Eu__3 = default;
									num3 = 7;
									continue;
								case 15:
									return;
								case 1:
									result = awaiter3.GetResult();
									num3 = 23;
									continue;
								case 16:
									if (!awaiter2.IsCompleted)
									{
										num3 = 10;
										continue;
									}
									goto IL_01f6;
								case 7:
									num2 = (_003C_003E1__state = -1);
									num3 = 24;
									continue;
								case 24:
									{
										awaiter.GetResult();
										goto end_IL_00c7;
									}
									IL_01f6:
									result2 = awaiter2.GetResult();
									num3 = 13;
									continue;
								}
								goto IL_026e;
								continue;
								end_IL_00c7:
								break;
							}
							break;
							IL_026e:
							num2 = (_003C_003E1__state = -1);
							num3 = 1;
							goto IL_00c7;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Csheet_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 0;
				default:
					num = 0;
					continue;
				case 4:
					num2 = _003C_003E1__state;
					timq1gKVUe24QPP01PKJ();
					if (IWBNkdKVYBNllp9FGAYC())
					{
						num = 3;
						if (0 == 0)
						{
							continue;
						}
						goto case 1;
					}
					num = 6;
					if (IWBNkdKVYBNllp9FGAYC())
					{
						continue;
					}
					break;
				case 1:
				case 3:
					propertyLinks = _003C_003E4__this;
					goto case 2;
				case 5:
					break;
				case 7:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 7;
				if (timq1gKVUe24QPP01PKJ())
				{
				}
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
		internal static object yuLUrdKVHy2WufIvaFlY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Vk1BFyKVx8ZprXMgsuaj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogEditInfo)P_0).Url;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bdD4JOKVma4FejDYfc37(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogEditingObject)P_0).Url;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gO9liXKVQ9XMB0GDNnA3(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).ApplyEditableObjectAsync((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter BOCq5hKVNsoO5AbjHLMP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IWBNkdKVYBNllp9FGAYC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool timq1gKVUe24QPP01PKJ()
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
	private struct _003CMaxLinksReached_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public PropertyLinks _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			U8JhpPKVc9ZRyh1ReUZL();
			int num;
			if (xningBKV2XuaSssNBfAZ())
			{
				num = 5;
			}
			else
			{
				num = 4;
				if (U8JhpPKVc9ZRyh1ReUZL())
				{
				}
			}
			PropertyLinks propertyLinks = default;
			bool result = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					try
					{
						TaskAwaiter<bool> awaiter;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_01ef;
						}
						TaskAwaiter awaiter2;
						if (num2 == 1)
						{
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0282;
						}
						int num3 = (propertyLinks.CellRange.Rows - 2) * propertyLinks.CellRange.Columns / 2;
						if (FWRqyeKV1xDOyNBwDh3n(propertyLinks.LFxUNEie7o) >= num3)
						{
							if (FWRqyeKV1xDOyNBwDh3n(propertyLinks.LFxUNEie7o) < 200 && propertyLinks.LFxUNEie7o.Count == num3)
							{
								CvsCellRange cellRange = propertyLinks.CellRange;
								cellRange.Rows = 2;
								cellRange.Row = propertyLinks.InSight.ProcessorConstants.SpreadsheetTotalRows - 2;
								CvsCellCollection cells = ((CvsResultSet)aCZFc7KVuqnXgIfP6cD2(propertyLinks.InSight)).Cells;
								bool flag = true;
								IEnumerator<CvsCellLocation> enumerator = cellRange.GetEnumerator();
								try
								{
									while (QDcI1UKVhZJLJTs6wW2n(enumerator))
									{
										CvsCellLocation current = enumerator.Current;
										_ = 0;
										int num4;
										if (xningBKV2XuaSssNBfAZ())
										{
											num4 = 2;
										}
										else
										{
											num4 = 3;
											if (U8JhpPKVc9ZRyh1ReUZL())
											{
											}
										}
										while (true)
										{
											switch (num4)
											{
											default:
												flag = false;
												num4 = 4;
												continue;
											case 0:
											case 2:
												if (cells[current] == null)
												{
													goto IL_0167;
												}
												goto default;
											case 4:
												break;
											}
											break;
										}
										break;
										IL_0167:;
									}
								}
								finally
								{
									if (num2 < 0 && enumerator != null)
									{
										lpC0NsKVtBOjkH5YX2wA(enumerator);
									}
								}
								if (flag)
								{
									awaiter = propertyLinks.wZgUUXRUeR().GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 0);
										_003C_003Eu__1 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									goto IL_01ef;
								}
							}
							goto IL_0202;
						}
						result = false;
						goto end_IL_0028;
						IL_0282:
						awaiter2.GetResult();
						result = true;
						goto end_IL_0028;
						IL_01ef:
						if (!awaiter.GetResult())
						{
							goto IL_0202;
						}
						result = false;
						goto end_IL_0028;
						IL_0202:
						string text = (string)DPaU0gKfL0GK9UvHMIpw(L4G81GKVzg0GKbMH20yU(), 200);
						Exception ex = new Exception();
						awaiter2 = bttfx6Kf53F6dDqbAef2(zt668NKfK6Uduf87mR7o(propertyLinks, ex, Resources.yxfJry2KDU(), text));
						if (!awaiter2.IsCompleted)
						{
							num2 = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0282;
						end_IL_0028:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 3;
				default:
					num = 3;
					continue;
				case 3:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					continue;
				case 1:
				case 4:
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					break;
				case 6:
					return;
				}
				propertyLinks = _003C_003E4__this;
				num = 2;
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
		internal static int FWRqyeKV1xDOyNBwDh3n(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((List<WW5BIYGnekkgDixF9y>)P_0).Count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object aCZFc7KVuqnXgIfP6cD2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QDcI1UKVhZJLJTs6wW2n(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void lpC0NsKVtBOjkH5YX2wA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object L4G81GKVzg0GKbMH20yU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.JQAVQWouc5();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DPaU0gKfL0GK9UvHMIpw(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zt668NKfK6Uduf87mR7o(object P_0, object P_1, object P_2, object P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((BaseViewModel)P_0).NotifyException((Exception)P_1, (string)P_2, (string)P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter bttfx6Kf53F6dDqbAef2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xningBKV2XuaSssNBfAZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool U8JhpPKVc9ZRyh1ReUZL()
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
	private struct _003CExpandCellRange_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public PropertyLinks _003C_003E4__this;

		private CvsCellRange _003CcutRange_003E5__2;

		private CvsCellRange _003CpasteRange_003E5__3;

		private TaskAwaiter<byte[]> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			b50QGZKfwjKr44avltOK();
			int num = (nkQY4KKfJ3MNu1FFIHKc() ? 2 : 5);
			int num2 = default;
			PropertyLinks propertyLinks = default;
			TaskAwaiter<byte[]> awaiter = default;
			TaskAwaiter awaiter2 = default;
			byte[] result2 = default;
			CvsCellRange range = default;
			bool result = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					try
					{
						if ((uint)num2 > 2u)
						{
							_003CcutRange_003E5__2 = propertyLinks.CellRange;
							_003CcutRange_003E5__2.Row = propertyLinks.CellRange.LastRow;
							_003CcutRange_003E5__2.Rows = GKRiN5KfetD7i9AXca1o(AecxUNKfaA3iUUjmBpWQ(propertyLinks.InSight)) - 2 - propertyLinks.CellRange.LastRow;
							_003CpasteRange_003E5__3 = _003CcutRange_003E5__2;
							_003CpasteRange_003E5__3.Row += 2;
						}
						try
						{
							int num3;
							switch (num2)
							{
							default:
								awaiter = ((CvsCogSocket)b0ARKFKfO75V87OkD8w7(propertyLinks.InSight)).Sheet.CopyCellsAsync(_003CcutRange_003E5__2).GetAwaiter();
								num3 = 15;
								goto IL_02df;
							case 2:
								awaiter2 = _003C_003Eu__2;
								num3 = 22;
								goto IL_02df;
							case 1:
								awaiter2 = _003C_003Eu__2;
								goto IL_0104;
							case 0:
								{
									awaiter = _003C_003Eu__1;
									_003C_003Eu__1 = default;
									num3 = 2;
									if (true)
									{
										goto IL_02df;
									}
									goto IL_03c7;
								}
								IL_02df:
								while (true)
								{
									switch (num3)
									{
									case 12:
										result2 = awaiter.GetResult();
										num3 = 16;
										continue;
									case 23:
										num2 = (_003C_003E1__state = 0);
										num3 = 14;
										continue;
									case 17:
										break;
									case 10:
										_003C_003Eu__2 = awaiter2;
										num3 = 6;
										continue;
									case 8:
									case 19:
										return;
									case 22:
										_003C_003Eu__2 = default;
										goto case 13;
									case 0:
										if (!awaiter2.IsCompleted)
										{
											num3 = 18;
											if (!nkQY4KKfJ3MNu1FFIHKc())
											{
												continue;
											}
											goto case 9;
										}
										goto IL_01b8;
									case 9:
										num2 = (_003C_003E1__state = -1);
										num3 = 20;
										if (b50QGZKfwjKr44avltOK())
										{
											continue;
										}
										goto case 20;
									case 20:
										awaiter2.GetResult();
										range = _003CcutRange_003E5__2;
										num3 = 7;
										continue;
									case 13:
									case 21:
										num2 = (_003C_003E1__state = -1);
										goto IL_01b8;
									case 3:
										range.Rows -= 2;
										awaiter2 = ((Task)xj466jKfnkpyFpTIJBUF(propertyLinks.AppViewModel, range, 2)).GetAwaiter();
										num3 = 0;
										if (0 == 0)
										{
											continue;
										}
										goto case 2;
									case 2:
										num2 = (_003C_003E1__state = -1);
										num3 = 12;
										continue;
									case 18:
										num2 = (_003C_003E1__state = 2);
										_003C_003Eu__2 = awaiter2;
										num3 = 11;
										continue;
									case 14:
										_003C_003Eu__1 = awaiter;
										num3 = 5;
										if (nkQY4KKfJ3MNu1FFIHKc())
										{
										}
										continue;
									case 11:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										b50QGZKfwjKr44avltOK();
										if (nkQY4KKfJ3MNu1FFIHKc())
										{
											num3 = 13;
											if (0 == 0)
											{
												continue;
											}
											goto case 0;
										}
										num3 = 8;
										continue;
									case 6:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										return;
									default:
										num3 = 17;
										continue;
									case 1:
										num2 = (_003C_003E1__state = 1);
										num3 = 10;
										continue;
									case 15:
										if (!awaiter.IsCompleted)
										{
											num3 = 23;
											continue;
										}
										goto case 12;
									case 7:
										range.Row += 2;
										num3 = 3;
										continue;
									case 5:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									case 16:
										goto IL_03c7;
									case 4:
										if (!awaiter2.IsCompleted)
										{
											num3 = 1;
											continue;
										}
										goto case 20;
									case 24:
										{
											result = true;
											goto end_IL_00a1;
										}
										IL_01b8:
										awaiter2.GetResult();
										propertyLinks.CellRange = new CvsCellRange(propertyLinks.CellRange.Row, propertyLinks.CellRange.Column, propertyLinks.CellRange.Rows + 2, propertyLinks.CellRange.Columns);
										num3 = 24;
										if (true)
										{
											continue;
										}
										goto case 3;
									}
									break;
								}
								goto IL_0104;
								IL_03c7:
								awaiter2 = NM0sfbKfiiHINe9ihnIp(ATmoQrKfDaq2lVb5TXxr(NOOpZjKfIuXo0sGD9wpr(b0ARKFKfO75V87OkD8w7(propertyLinks.InSight)), _003CpasteRange_003E5__3, result2, true, false));
								num3 = 4;
								goto IL_02df;
								IL_0104:
								_003C_003Eu__2 = default;
								num3 = 9;
								goto IL_02df;
								end_IL_00a1:
								break;
							}
						}
						catch
						{
							goto IL_041a;
						}
						goto end_IL_0028;
						IL_041a:
						result = false;
						end_IL_0028:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				default:
					num = 4;
					continue;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 2:
					propertyLinks = _003C_003E4__this;
					num = 3;
					continue;
				case 4:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult(result);
				num = 6;
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
		internal static object AecxUNKfaA3iUUjmBpWQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).ProcessorConstants;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int GKRiN5KfetD7i9AXca1o(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsProcessorConstants)P_0).SpreadsheetTotalRows;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object b0ARKFKfO75V87OkD8w7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object NOOpZjKfIuXo0sGD9wpr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ATmoQrKfDaq2lVb5TXxr(object P_0, CvsCellRange P_1, object P_2, bool P_3, bool P_4)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).InternalPasteCellsAsync(P_1, (byte[])P_2, P_3, P_4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter NM0sfbKfiiHINe9ihnIp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xj466jKfnkpyFpTIJBUF(object P_0, CvsCellRange range, int shiftDistance)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EasyBuilderApplicationViewModel)P_0).ParseShiftedSnippetsInRange(range, shiftDistance);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool b50QGZKfwjKr44avltOK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nkQY4KKfJ3MNu1FFIHKc()
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
	private struct _003COnSourcePropertyChanged_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CellViewModel property;

		public PropertyValueChangedEventArgs<CellViewModel> args;

		public PropertyLinks _003C_003E4__this;

		private string _003CcellName_003E5__2;

		private IUndoAction _003CundoAction_003E5__3;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private object _003C_003E7__wrap3;

		private int _003C_003E7__wrap4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 7;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_04ca;
			IL_001a:
			PropertyLinks propertyLinks = _003C_003E4__this;
			goto IL_004e;
			IL_04ca:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					break;
				case 7:
					goto IL_0031;
				case 0:
				case 2:
					goto IL_004e;
				case 4:
					_003CcellName_003E5__2 = null;
					goto case 5;
				default:
					num = 5;
					if (true)
					{
						continue;
					}
					goto case 5;
				case 5:
					_003CundoAction_003E5__3 = null;
					num = 6;
					continue;
				case 6:
					_003C_003Et__builder.SetResult();
					num = 8;
					if (true)
					{
						continue;
					}
					return;
				case 8:
					return;
				}
				break;
				IL_0031:
				num2 = _003C_003E1__state;
				_ = 1;
				num = ((!cMwgcNKffrnW6lUwwPhH()) ? 3 : 0);
			}
			goto IL_001a;
			IL_004e:
			try
			{
				TaskAwaiter<bool> awaiter2;
				TaskAwaiter awaiter = default;
				switch (num2)
				{
				default:
					_003CcellName_003E5__2 = property.CellName;
					if (args.Previous != null && args.Current != null)
					{
						_003CundoAction_003E5__3 = new UndoSwitchLink(propertyLinks, _003CcellName_003E5__2, (string)duuiIuKfdwauIdpKYCTp(args.Current));
						goto IL_01ee;
					}
					if (args.Current != null)
					{
						awaiter2 = propertyLinks.n8BUpNOM7M().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num2 = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0127;
					}
					if (args.Previous != null)
					{
						_003CundoAction_003E5__3 = new UndoRemoveLink(propertyLinks, _003CcellName_003E5__2);
						goto IL_01ee;
					}
					goto end_IL_004e;
				case 0:
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num2 = (_003C_003E1__state = -1);
					goto IL_0127;
				case 1:
					awaiter = _003C_003Eu__2;
					_003C_003Eu__2 = default;
					num2 = (_003C_003E1__state = -1);
					goto IL_018f;
				case 2:
				{
					try
					{
						int num3;
						if (num2 != 2)
						{
							num3 = 2;
						}
						else
						{
							awaiter = _003C_003Eu__2;
							_ = 1;
							if (!cMwgcNKffrnW6lUwwPhH())
							{
								num3 = 4;
								if (false)
								{
									goto IL_02ea;
								}
							}
							else
							{
								num3 = 9;
							}
						}
						goto IL_0220;
						IL_0220:
						while (true)
						{
							switch (num3)
							{
							case 5:
								_003C_003Eu__2 = awaiter;
								goto case 0;
							default:
								num3 = 0;
								continue;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									if (0 == 0)
									{
										continue;
									}
									goto case 8;
								}
								goto case 10;
							case 8:
								num2 = (_003C_003E1__state = 2);
								num3 = 5;
								continue;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
								awaiter = A5cKPLKfgZTmeBTq2OhZ(((UndoRedoQueue)yQkfpRKfs9QLkJJYYH43(propertyLinks.InSight)).AddUndo(_003CundoAction_003E5__3));
								num3 = 1;
								continue;
							case 3:
								return;
							case 7:
							case 9:
								break;
							case 4:
							case 6:
								goto IL_0303;
							case 10:
								awaiter.GetResult();
								goto end_IL_01f6;
							}
							break;
						}
						goto IL_02ea;
						IL_02ea:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						if (ljvPbZKfVhuq4GisWyrF())
						{
							goto IL_0220;
						}
						goto IL_0303;
						IL_0303:
						_003C_003Eu__2 = default;
						goto IL_02ea;
						end_IL_01f6:;
					}
					catch (Exception ex)
					{
						_003C_003E7__wrap3 = ex;
						_003C_003E7__wrap4 = 1;
					}
					int num4 = _003C_003E7__wrap4;
					if (num4 != 1)
					{
						break;
					}
					Exception ex2 = (Exception)_003C_003E7__wrap3;
					StringBuilder stringBuilder = new StringBuilder();
					U65SLBKfrgDwSsNGamp9(stringBuilder, InycAXKfvWQjqWCsQQkR(ex2));
					df540DKfPNE9C69ZTM0h(stringBuilder);
					QvvOFwKfbbYD5tRkUsxb(stringBuilder, HfgGFZKfZ2MBJvjf2T5A(), _003CcellName_003E5__2, OfojdmKfBa5d1a3sN5tl(_003CundoAction_003E5__3));
					awaiter = propertyLinks.NotifyException(ex2, (string)kZuws4KfGSbqQXFROpLq(), stringBuilder.ToString()).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num2 = (_003C_003E1__state = 3);
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_03ff;
				}
				case 3:
					awaiter = _003C_003Eu__2;
					_003C_003Eu__2 = default;
					num2 = (_003C_003E1__state = -1);
					goto IL_03ff;
				case 4:
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_0462;
					}
					IL_03ff:
					awaiter.GetResult();
					awaiter = A5cKPLKfgZTmeBTq2OhZ(Ib22SGKfo33P1vGveTPD(_003CundoAction_003E5__3));
					if (!awaiter.IsCompleted)
					{
						num2 = (_003C_003E1__state = 4);
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0462;
					IL_018f:
					awaiter.GetResult();
					goto end_IL_004e;
					IL_0462:
					awaiter.GetResult();
					break;
					IL_01ee:
					_003C_003E7__wrap4 = 0;
					goto case 2;
					IL_0127:
					if (awaiter2.GetResult())
					{
						awaiter = A5cKPLKfgZTmeBTq2OhZ(DCRg8DKflK6GbEtll6Jw(propertyLinks.AppViewModel));
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_018f;
					}
					_003CundoAction_003E5__3 = new UndoAddLink(propertyLinks, _003CcellName_003E5__2, args.Current.CellName);
					goto IL_01ee;
				}
				_003C_003E7__wrap3 = null;
				end_IL_004e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003CcellName_003E5__2 = null;
				_003CundoAction_003E5__3 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			num = 4;
			goto IL_04ca;
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
		internal static object duuiIuKfdwauIdpKYCTp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DCRg8DKflK6GbEtll6Jw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EasyBuilderApplicationViewModel)P_0).ReadCurrentPropertyLinks();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter A5cKPLKfgZTmeBTq2OhZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yQkfpRKfs9QLkJJYYH43(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object InycAXKfvWQjqWCsQQkR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Exception)P_0).Message;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object U65SLBKfrgDwSsNGamp9(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((StringBuilder)P_0).AppendLine((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object df540DKfPNE9C69ZTM0h(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((StringBuilder)P_0).AppendLine();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HfgGFZKfZ2MBJvjf2T5A()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.LuRJ8dOt7q();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OfojdmKfBa5d1a3sN5tl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IUndoAction)P_0).Text;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QvvOFwKfbbYD5tRkUsxb(object P_0, object P_1, object P_2, object P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((StringBuilder)P_0).AppendFormat((string)P_1, P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kZuws4KfGSbqQXFROpLq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.yxfJry2KDU();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Ib22SGKfo33P1vGveTPD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IUndoAction)P_0).Undo();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ljvPbZKfVhuq4GisWyrF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cMwgcNKffrnW6lUwwPhH()
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
	private struct _003CRemoveReferences_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PropertyLinks _003C_003E4__this;

		public SnippetPreRemoveEventArgs e;

		private List<WW5BIYGnekkgDixF9y>.Enumerator _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!XdCLbLKfSTxq1BD7gnuQ()) ? 4 : 2);
			int num2 = default;
			PropertyLinks propertyLinks = default;
			CvsCellLocation sourceCellLocation = default;
			CvsCellRange cvsCellRange = default;
			CvsCellLocation destinationCellLocation = default;
			TaskAwaiter awaiter = default;
			WW5BIYGnekkgDixF9y current2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 1;
					break;
				case 1:
					propertyLinks = _003C_003E4__this;
					num = 5;
					break;
				case 5:
					try
					{
						if (num2 != 0)
						{
							List<WW5BIYGnekkgDixF9y> list = new List<WW5BIYGnekkgDixF9y>();
							IEnumerator<WW5BIYGnekkgDixF9y> enumerator = Enumerable.Reverse(propertyLinks.LFxUNEie7o).GetEnumerator();
							try
							{
								while (EcqsrtKfXZsdG8Oa3yJu(enumerator))
								{
									WW5BIYGnekkgDixF9y current = enumerator.Current;
									_ = 0;
									int num3;
									if (XdCLbLKfSTxq1BD7gnuQ())
									{
										num3 = 5;
										if (!XdCLbLKfSTxq1BD7gnuQ())
										{
											goto IL_00a1;
										}
									}
									else
									{
										num3 = 4;
										if (1 == 0)
										{
											goto IL_01d2;
										}
									}
									goto IL_0173;
									IL_00a1:
									sourceCellLocation = propertyLinks.GetSourceCellLocation(e.Cells, (string)McJwYHKfqhG4PZLADvZP(current, propertyLinks.CellRange, iEaKtqKf8k50CyLUgZ3i(e)));
									num3 = 8;
									if (1 == 0)
									{
										goto IL_00d8;
									}
									goto IL_0173;
									IL_00d8:
									if (!cvsCellRange.Contains(sourceCellLocation))
									{
										goto IL_0108;
									}
									num3 = 6;
									goto IL_0173;
									IL_0108:
									destinationCellLocation = propertyLinks.GetDestinationCellLocation((CvsCellCollection)iEaKtqKf8k50CyLUgZ3i(e), current.eFB1gh9KNF(propertyLinks.CellRange, e.Cells));
									num3 = 3;
									goto IL_0173;
									IL_0173:
									while (true)
									{
										switch (num3)
										{
										case 0:
										case 5:
											break;
										case 2:
										case 4:
											goto IL_00d8;
										case 1:
											if (cvsCellRange.Contains(destinationCellLocation))
											{
												num3 = 7;
												continue;
											}
											goto IL_01ee;
										case 9:
											goto IL_0108;
										case 7:
											list.Add(current);
											num3 = 10;
											if (LnWtcvKfkKtsqrvWpZsb())
											{
											}
											continue;
										case 6:
											list.Add(current);
											goto IL_0108;
										default:
											num3 = 9;
											continue;
										case 8:
											cvsCellRange = LETk8IKfpYmnSJPAYEVL(DQRcjuKfEhsyZEwUk5C6(e));
											goto IL_00d8;
										case 3:
											goto IL_01d2;
										case 10:
											goto IL_01ee;
										}
										break;
									}
									goto IL_00a1;
									IL_01d2:
									cvsCellRange = LETk8IKfpYmnSJPAYEVL(DQRcjuKfEhsyZEwUk5C6(e));
									num3 = 1;
									goto IL_0173;
									IL_01ee:;
								}
							}
							finally
							{
								if (num2 < 0 && enumerator != null)
								{
									miluXdKf9jaqmTWwDkmu(enumerator);
								}
							}
							_003C_003E7__wrap1 = list.GetEnumerator();
						}
						try
						{
							if (num2 != 0)
							{
								goto IL_0380;
							}
							awaiter = _003C_003Eu__1;
							int num4 = 6;
							goto IL_02f1;
							IL_02f1:
							while (true)
							{
								switch (num4)
								{
								case 9:
									num2 = (_003C_003E1__state = 0);
									num4 = 3;
									continue;
								case 7:
									if (!awaiter.IsCompleted)
									{
										num4 = 9;
										if (LnWtcvKfkKtsqrvWpZsb())
										{
										}
										continue;
									}
									goto case 2;
								case 2:
									awaiter.GetResult();
									num4 = 10;
									if (LnWtcvKfkKtsqrvWpZsb())
									{
									}
									continue;
								case 0:
								case 5:
									awaiter = yAbgY3Kf7R6WKyTNNCpC(lYpeKhKf4BfeVY1ekDOK(e, new UndoRemoveLink(propertyLinks, (string)McJwYHKfqhG4PZLADvZP(current2, propertyLinks.CellRange, iEaKtqKf8k50CyLUgZ3i(e)))));
									num4 = 7;
									if (0 == 0)
									{
										continue;
									}
									goto case 3;
								case 3:
									_003C_003Eu__1 = awaiter;
									goto default;
								default:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 8:
									num2 = (_003C_003E1__state = -1);
									num4 = 2;
									continue;
								case 6:
									_003C_003Eu__1 = default;
									num4 = 8;
									continue;
								case 10:
									break;
								}
								break;
							}
							goto IL_0380;
							IL_0380:
							if (_003C_003E7__wrap1.MoveNext())
							{
								current2 = _003C_003E7__wrap1.Current;
								_ = 0;
								num4 = ((!XdCLbLKfSTxq1BD7gnuQ()) ? 1 : 5);
								goto IL_02f1;
							}
						}
						finally
						{
							if (num2 < 0)
							{
								((IDisposable)_003C_003E7__wrap1/*cast due to constrained. prefix*/).Dispose();
							}
						}
						_003C_003E7__wrap1 = default;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 6:
					return;
				}
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
		internal static object iEaKtqKf8k50CyLUgZ3i(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SnippetPreRemoveEventArgs)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object McJwYHKfqhG4PZLADvZP(object P_0, CvsCellRange P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((WW5BIYGnekkgDixF9y)P_0).eFB1gh9KNF(P_1, (CvsCellCollection)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DQRcjuKfEhsyZEwUk5C6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SnippetPreRemoveEventArgs)P_0).Snippet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange LETk8IKfpYmnSJPAYEVL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).CellRange;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EcqsrtKfXZsdG8Oa3yJu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void miluXdKf9jaqmTWwDkmu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lYpeKhKf4BfeVY1ekDOK(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SnippetPreRemoveEventArgs)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter yAbgY3Kf7R6WKyTNNCpC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XdCLbLKfSTxq1BD7gnuQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LnWtcvKfkKtsqrvWpZsb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private readonly EasyBuilderApplicationViewModel KYMU7aBR2D;

	private readonly List<WW5BIYGnekkgDixF9y> LFxUNEie7o;

	public EasyBuilderApplicationViewModel AppViewModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KYMU7aBR2D;
		}
	}

	public override string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)MJ0rGEa9i3qkPo1UIdP();
		}
	}

	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Ld47bwaAaW9DPuqwAvg(LFxUNEie7o);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PropertyLinks(EasyBuilderApplicationViewModel appViewModel)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		pDAdYNaEkMYZr8aZm2a();
		int num;
		if (EFgQqsaq7VB4Y0WFLJQ())
		{
			num = 3;
		}
		else
		{
			num = 4;
			if (1 == 0)
			{
				return;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				base._002Ector((AppStepViewModel)DHJFqkaXq90rCFub6B8(appViewModel));
				goto case 5;
			default:
				num = 5;
				break;
			case 0:
			case 3:
				SXOJHsap60T9607xNaF();
				num = 1;
				break;
			case 5:
				KYMU7aBR2D = appViewModel;
				num = 6;
				if (EFgQqsaq7VB4Y0WFLJQ())
				{
					break;
				}
				goto case 1;
			case 1:
				LFxUNEie7o = new List<WW5BIYGnekkgDixF9y>();
				goto case 2;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Task Parse(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		object obj = default;
		CvsCell cvsCell2 = default;
		CvsCellLocation cvsCellLocation2 = default;
		CvsCell cvsCell = default;
		CvsCellLocation cell = default;
		int num2 = default;
		int num3 = default;
		bool isValid = default;
		CvsCellLocation cvsCellLocation = default;
		string text = default;
		bool flag = default;
		CvsCellRange cellRange = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				obj = null;
				num = 2;
				break;
			case 17:
				cvsCell2 = (CvsCell)DUgAAmajAaH4v343ZZC(cells, cvsCellLocation2);
				num = 10;
				break;
			case 10:
				if (cvsCell2 != null)
				{
					num = 0;
					break;
				}
				goto case 8;
			case 12:
			case 14:
				obj = FaFjDja6ydy5a2fvIXZ(cvsCell2);
				num = 8;
				break;
			case 13:
				if (cvsCell != null)
				{
					num = 5;
					break;
				}
				goto IL_016a;
			case 2:
				cell = new CvsCellLocation(num2, num3);
				num = 18;
				break;
			case 8:
				isValid = cvsCellLocation.IsValid;
				num = 21;
				break;
			case 3:
				text = string.Empty;
				num = 4;
				break;
			case 15:
				if (isValid & flag)
				{
					LFxUNEie7o.Add(new WW5BIYGnekkgDixF9y(Ld47bwaAaW9DPuqwAvg(LFxUNEie7o), text, obj));
					num = 11;
					break;
				}
				_ = isValid | flag;
				goto case 11;
			case 9:
				num3 = cellRange.Column;
				num = 6;
				break;
			case 1:
				ghZ9bQa4TFAljyH0O4Q(LFxUNEie7o);
				num = 20;
				if (true)
				{
					break;
				}
				goto case 6;
			case 11:
				num3++;
				goto case 6;
			case 6:
			{
				int num4 = num3;
				cellRange = CellRange;
				if (num4 <= cellRange.LastColumn)
				{
					cvsCellLocation = CvsCellLocation.Invalid;
					num = 3;
					break;
				}
				goto case 16;
			}
			case 18:
				cvsCell = cells[cell];
				num = 13;
				break;
			case 5:
				cvsCellLocation = xhTg7Ha3Jr4KjYZkE8q(ukui71a7TAP4kxvTdLK(cvsCell));
				goto IL_016a;
			default:
				num = 17;
				break;
			case 20:
				cellRange = CellRange;
				num2 = cellRange.Row + 1;
				num = 7;
				break;
			case 16:
			case 19:
				num2 += 2;
				goto case 7;
			case 7:
			{
				int num5 = num2;
				cellRange = CellRange;
				if (num5 >= cellRange.LastRow)
				{
					num = 22;
					if (true)
					{
						break;
					}
					goto case 21;
				}
				cellRange = CellRange;
				num = 9;
				if (!pDAdYNaEkMYZr8aZm2a())
				{
					break;
				}
				goto case 0;
			}
			case 21:
				flag = !CVQPv0aCelG6uiAREWk(text);
				num = 15;
				break;
			case 0:
				text = (string)ukui71a7TAP4kxvTdLK(cvsCell2);
				pDAdYNaEkMYZr8aZm2a();
				num = (EFgQqsaq7VB4Y0WFLJQ() ? 12 : 16);
				break;
			case 22:
				{
					return (Task)jDeZAPaRAjoWYEPcNyc();
				}
				IL_016a:
				cvsCellLocation2 = new CvsCellLocation(num2 + 1, num3);
				goto case 17;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddLink_003Ed__11))]
	public Task AddLink(string dstName, string srcName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (pDAdYNaEkMYZr8aZm2a() ? 7 : 5);
		_003CAddLink_003Ed__11 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 7:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
				stateMachine.dstName = dstName;
				num = 3;
				break;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = xgMHPWaWL2sVhQC9cHV();
				goto case 1;
			case 6:
				stateMachine._003C_003E1__state = -1;
				num = 4;
				break;
			case 3:
				stateMachine.srcName = srcName;
				goto case 6;
			default:
				num = 6;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveLink_003Ed__12))]
	public Task RemoveLink(string dstName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0098;
		IL_001a:
		_003CRemoveLink_003Ed__12 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		num = 6;
		goto IL_0098;
		IL_0098:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 6:
				stateMachine._003C_003E4__this = this;
				pDAdYNaEkMYZr8aZm2a();
				num = ((!EFgQqsaq7VB4Y0WFLJQ()) ? 4 : 0);
				continue;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto default;
			default:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				continue;
			case 0:
			case 2:
				stateMachine.dstName = dstName;
				goto default;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellLocation GetSourceCellLocation(string dstName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetSourceCellLocation((CvsCellCollection)QMpGFdayA4de1uPMOsl(q63s0HaTDTpwenMT75G(InSight)), dstName);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellLocation GetSourceCellLocation(CvsCellCollection cells, string dstName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_009b;
		IL_001a:
		_003C_003Ec__DisplayClass14_0 obj = default;
		obj.dstName = dstName;
		num = 7;
		goto IL_009b;
		IL_009b:
		CvsCell cvsCell = default;
		CvsCellLocation result = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 10:
				if (cvsCell != null)
				{
					goto case 6;
				}
				goto case 11;
			case 5:
			case 9:
				if (LFxUNEie7o.FirstOrDefault(obj._003CGetSourceCellLocation_003Eb__0) != null)
				{
					num = 3;
					if (!pDAdYNaEkMYZr8aZm2a())
					{
						continue;
					}
					goto case 6;
				}
				goto case 11;
			case 6:
			case 8:
				result = xhTg7Ha3Jr4KjYZkE8q(ukui71a7TAP4kxvTdLK(cvsCell));
				num = 11;
				continue;
			case 7:
				result = CvsCellLocation.Invalid;
				goto default;
			default:
				pDAdYNaEkMYZr8aZm2a();
				num = (EFgQqsaq7VB4Y0WFLJQ() ? 9 : 6);
				continue;
			case 3:
				cvsCell = obj.cells.FindCellByName(obj.dstName);
				num = 10;
				continue;
			case 2:
				obj._003C_003E4__this = this;
				num = 4;
				continue;
			case 4:
				obj.cells = cells;
				num = 0;
				if (EFgQqsaq7VB4Y0WFLJQ())
				{
					continue;
				}
				goto case 1;
			case 1:
				obj = new _003C_003Ec__DisplayClass14_0();
				num = 2;
				continue;
			case 11:
				return result;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCellLocation GetDestinationCellLocation(CvsCellCollection cells, string dstName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0084;
		IL_001a:
		_003C_003Ec__DisplayClass15_0 obj = new _003C_003Ec__DisplayClass15_0();
		_ = 0;
		num = ((!EFgQqsaq7VB4Y0WFLJQ()) ? 4 : 9);
		goto IL_0084;
		IL_0084:
		CvsCell cvsCell = default;
		CvsCellLocation result = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 8:
				if (cvsCell != null)
				{
					num = 3;
					continue;
				}
				goto case 11;
			case 6:
				if (LFxUNEie7o.FirstOrDefault(obj._003CGetDestinationCellLocation_003Eb__0) != null)
				{
					num = 0;
					continue;
				}
				goto case 11;
			case 10:
				result = CvsCellLocation.Invalid;
				goto case 6;
			default:
				num = 6;
				if (pDAdYNaEkMYZr8aZm2a())
				{
				}
				continue;
			case 0:
				cvsCell = (CvsCell)CIxjPha01VMjxKjIQKg(obj.cells, obj.dstName);
				num = 8;
				continue;
			case 7:
				obj.dstName = dstName;
				num = 10;
				if (true)
				{
					continue;
				}
				goto case 3;
			case 3:
				result = bHDnP9aFimcbvbtX4NK(cvsCell);
				num = 11;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 9:
				obj._003C_003E4__this = this;
				goto case 2;
			case 2:
			case 4:
				obj.cells = cells;
				num = 7;
				continue;
			case 11:
				return result;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDuplicateLinks_003Ed__16))]
	public Task DuplicateLinks(CvsCellRange originalRange, CvsCellRange duplicateRange, CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		pDAdYNaEkMYZr8aZm2a();
		int num;
		if (EFgQqsaq7VB4Y0WFLJQ())
		{
			num = 2;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
			if (!EFgQqsaq7VB4Y0WFLJQ())
			{
				goto IL_00b1;
			}
		}
		goto IL_005c;
		IL_005c:
		_003CDuplicateLinks_003Ed__16 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
			case 6:
				break;
			case 7:
				stateMachine.duplicateRange = duplicateRange;
				goto IL_00b1;
			default:
				num = 3;
				continue;
			case 8:
				stateMachine._003C_003E1__state = -1;
				break;
			case 3:
				goto IL_00b1;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = xgMHPWaWL2sVhQC9cHV();
				num = 1;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine.originalRange = originalRange;
				num = 7;
				continue;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
		IL_00b1:
		stateMachine.cells = cells;
		num = 8;
		goto IL_005c;
		IL_002a:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 9;
		goto IL_005c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CClearAndRewriteAllLinkCells_003Ed__17))]
	private Task VUZphLkjyh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CClearAndRewriteAllLinkCells_003Ed__17 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				_ = 0;
				if (EFgQqsaq7VB4Y0WFLJQ())
				{
					num = 0;
					continue;
				}
				num = 2;
				if (true)
				{
					continue;
				}
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetLinkCellExpressions_003Ed__18))]
	private Task ROMp8Peer5(CvsCellCollection P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0034;
		IL_001a:
		_003CSetLinkCellExpressions_003Ed__18 stateMachine = default;
		stateMachine.cells = P_0;
		goto IL_0081;
		IL_0034:
		while (true)
		{
			switch (num)
			{
			case 2:
			case 6:
				break;
			case 0:
				stateMachine._003C_003Et__builder = xgMHPWaWL2sVhQC9cHV();
				num = 1;
				continue;
			default:
				goto IL_0081;
			case 1:
				stateMachine._003C_003E4__this = this;
				pDAdYNaEkMYZr8aZm2a();
				if (!EFgQqsaq7VB4Y0WFLJQ())
				{
					num = 5;
					if (true)
					{
						continue;
					}
					goto case 0;
				}
				num = 6;
				continue;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
		IL_0081:
		stateMachine._003C_003E1__state = -1;
		num = 4;
		if (pDAdYNaEkMYZr8aZm2a())
		{
		}
		goto IL_0034;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetLinkCellValues_003Ed__19))]
	private Task pHQpmmiH6Q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0062;
		IL_001a:
		_003CSetLinkCellValues_003Ed__19 stateMachine = default;
		stateMachine._003C_003Et__builder = xgMHPWaWL2sVhQC9cHV();
		num = 0;
		goto IL_0062;
		IL_0062:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				num = (EFgQqsaq7VB4Y0WFLJQ() ? 1 : 4);
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteLink_003Ed__20))]
	private Task OLIp1rdHXF(CvsCellLocation P_0, string P_1, WW5BIYGnekkgDixF9y P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CWriteLink_003Ed__20 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine.linkRefLocation = P_0;
				_ = 1;
				if (!pDAdYNaEkMYZr8aZm2a())
				{
					num = 4;
					if (EFgQqsaq7VB4Y0WFLJQ())
					{
						break;
					}
					goto case 1;
				}
				num = 1;
				break;
			case 1:
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				break;
			case 3:
			case 4:
				stateMachine.dstName = P_1;
				goto case 7;
			default:
				num = 7;
				break;
			case 7:
				stateMachine.entry = P_2;
				num = 0;
				break;
			case 5:
				stateMachine._003C_003Et__builder = xgMHPWaWL2sVhQC9cHV();
				num = 8;
				break;
			case 0:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			case 8:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteLink_003Ed__21))]
	private Task p21pzZeTE7(CvsCellLocation P_0, CvsCellLocation P_1, WW5BIYGnekkgDixF9y P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CWriteLink_003Ed__21 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				stateMachine.linkRefLocation = P_0;
				num = 3;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
			case 4:
				stateMachine.entry = P_2;
				goto case 0;
			case 3:
				stateMachine.destinationLocation = P_1;
				goto default;
			default:
				pDAdYNaEkMYZr8aZm2a();
				if (!EFgQqsaq7VB4Y0WFLJQ())
				{
					num = 0;
					break;
				}
				num = 1;
				if (pDAdYNaEkMYZr8aZm2a())
				{
				}
				break;
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 7;
				if (EFgQqsaq7VB4Y0WFLJQ())
				{
					break;
				}
				goto case 6;
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				if (pDAdYNaEkMYZr8aZm2a())
				{
				}
				break;
			case 7:
				stateMachine._003C_003E4__this = this;
				num = 8;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 5:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				break;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteValueAsync_003Ed__22))]
	private Task jSIUa1579c(string P_0, CvsCellLocation P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		_003CWriteValueAsync_003Ed__22 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine.cellValue = P_2;
				num = 5;
				break;
			case 6:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				if (!pDAdYNaEkMYZr8aZm2a())
				{
					num = 7;
					if (EFgQqsaq7VB4Y0WFLJQ())
					{
						break;
					}
					goto case 1;
				}
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				break;
			case 2:
			case 7:
				stateMachine.expr = P_0;
				goto case 3;
			case 5:
				stateMachine._003C_003E1__state = -1;
				num = 1;
				break;
			case 8:
				stateMachine._003C_003Et__builder = xgMHPWaWL2sVhQC9cHV();
				num = 6;
				break;
			case 3:
			case 4:
				stateMachine.loc = P_1;
				goto case 0;
			default:
				num = 0;
				break;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteValueAsync_003Ed__23))]
	private Task pTlU5735Oy(CvsCellLocation P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		pDAdYNaEkMYZr8aZm2a();
		int num = ((!EFgQqsaq7VB4Y0WFLJQ()) ? 6 : 3);
		_003CWriteValueAsync_003Ed__23 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				stateMachine._003C_003E1__state = -1;
				num = 2;
				continue;
			case 4:
				stateMachine.cellValue = P_1;
				goto case 7;
			default:
				num = 7;
				continue;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = xgMHPWaWL2sVhQC9cHV();
				goto case 1;
			case 1:
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 5;
				continue;
			case 5:
				stateMachine.loc = P_0;
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (true)
				{
					continue;
				}
				break;
			case 8:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CMaxLinksReached_003Ed__24))]
	private Task<bool> n8BUpNOM7M()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CMaxLinksReached_003Ed__24 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CExpandCellRange_003Ed__25))]
	private Task<bool> wZgUUXRUeR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CExpandCellRange_003Ed__25 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnSourcePropertyChanged_003Ed__26))]
	public Task OnSourcePropertyChanged(CellViewModel property, PropertyValueChangedEventArgs<CellViewModel> args)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003COnSourcePropertyChanged_003Ed__26 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.property = property;
		stateMachine.args = args;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveReferences_003Ed__27))]
	public override Task RemoveReferences(SnippetPreRemoveEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CRemoveReferences_003Ed__27 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 6;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 6:
				stateMachine.e = e;
				goto case 3;
			default:
				num = 3;
				if (pDAdYNaEkMYZr8aZm2a())
				{
				}
				break;
			case 2:
				stateMachine._003C_003Et__builder = xgMHPWaWL2sVhQC9cHV();
				EFgQqsaq7VB4Y0WFLJQ();
				if (pDAdYNaEkMYZr8aZm2a())
				{
					num = 0;
					if (EFgQqsaq7VB4Y0WFLJQ())
					{
						break;
					}
					goto case 1;
				}
				num = 5;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SXOJHsap60T9607xNaF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DHJFqkaXq90rCFub6B8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EasyBuilderApplicationViewModel)P_0).Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EFgQqsaq7VB4Y0WFLJQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pDAdYNaEkMYZr8aZm2a()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MJ0rGEa9i3qkPo1UIdP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.PropertyLinks;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ghZ9bQa4TFAljyH0O4Q(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((List<WW5BIYGnekkgDixF9y>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ukui71a7TAP4kxvTdLK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation xhTg7Ha3Jr4KjYZkE8q(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.TryParse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DUgAAmajAaH4v343ZZC(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FaFjDja6ydy5a2fvIXZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).CellValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CVQPv0aCelG6uiAREWk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Ld47bwaAaW9DPuqwAvg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<WW5BIYGnekkgDixF9y>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jDeZAPaRAjoWYEPcNyc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder xgMHPWaWL2sVhQC9cHV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object q63s0HaTDTpwenMT75G(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Results;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QMpGFdayA4de1uPMOsl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsResultSet)P_0).Cells;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CIxjPha01VMjxKjIQKg(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0).FindCellByName((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation bHDnP9aFimcbvbtX4NK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Location;
	}
}
