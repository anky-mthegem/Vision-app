using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cognex.Cnx.Diagnostics;
using Cognex.Configuration;
using Cognex.Explorer.Diagnostics;
using Cognex.Extensions;
using Cognex.InSight.Cell;
using Cognex.InSight.Internal;
using Cognex.InSight.Properties;
using Cognex.InSight.Remoting.Serialization;
using Cognex.Remoting.CogSocket;
using Newtonsoft.Json.Linq;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

public class CvsCogSocketSheet : IResourceUriProvider
{
	public delegate void SheetUpdatedEventHandler(object sender, bool runSheet);

	[Flags]
	private enum HRDVuoTxpW43GMhV99
	{

	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetCellPropertyAsync_003Ed__75<T> : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public CvsCogSocketSheet _003C_003E4__this;

		public CvsCellLocation location;

		public string propertyName;

		private TaskAwaiter<T> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((1 == 0) ? 4 : 5);
			CvsCogSocketSheet cvsCogSocketSheet = default;
			int num2 = default;
			string path = default;
			TaskAwaiter<T> awaiter = default;
			T result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					cvsCogSocketSheet = _003C_003E4__this;
					num = 2;
					continue;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							path = cvsCogSocketSheet.v1f1Xb2PMu(location, propertyName);
							num3 = 5;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 6:
								return;
							case 0:
								_003C_003Eu__1 = default;
								num3 = 3;
								continue;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								continue;
							case 2:
							case 9:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								continue;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 1:
							case 7:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 2;
							case 4:
								_003C_003Eu__1 = awaiter;
								goto case 8;
							default:
								num3 = 8;
								continue;
							case 5:
								awaiter = cvsCogSocketSheet.liS1wH05cA().GetAsync<T>(path).GetAwaiter();
								_ = 0;
								num3 = (true ? 7 : 9);
								continue;
							case 10:
								break;
							}
							break;
						}
						result = awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
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
		internal static bool og3d6wziayVorkMU18h()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SOPHG9zqkFeWymfHmTb()
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
	private struct _003CGetCellCommentAsync_003Ed__77 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public CvsCogSocketSheet _003C_003E4__this;

		public CvsCellLocation location;

		private TaskAwaiter<string> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			CvsCogSocketSheet cvsCogSocketSheet = default;
			string path = default;
			TaskAwaiter<string> awaiter = default;
			string result = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					I4IWrCzByeBU83P3xZ7();
					num = (CmM8e3zjjjZ7uUGVFT9() ? 3 : 0);
					continue;
				case 0:
				case 1:
					cvsCogSocketSheet = _003C_003E4__this;
					goto case 2;
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							path = cvsCogSocketSheet.v1f1Xb2PMu(location, (string)LdUsvHzcvr0bpoDvBSZ(3962));
							num3 = 0;
							goto IL_0145;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0115;
						IL_0115:
						_003C_003Eu__1 = default;
						num3 = 4;
						goto IL_0145;
						IL_0145:
						while (true)
						{
							switch (num3)
							{
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								I4IWrCzByeBU83P3xZ7();
								num3 = (CmM8e3zjjjZ7uUGVFT9() ? 3 : 9);
								continue;
							case 0:
								awaiter = cvsCogSocketSheet.liS1wH05cA().GetAsync<string>(path).GetAwaiter();
								num3 = 1;
								continue;
							case 5:
							case 9:
								return;
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto case 10;
							case 3:
							case 6:
								break;
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 2;
							default:
								num3 = 2;
								continue;
							case 10:
								result = awaiter.GetResult();
								goto end_IL_0145;
							}
							goto IL_0115;
							continue;
							end_IL_0145:
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
				case 5:
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
		internal static object LdUsvHzcvr0bpoDvBSZ(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool I4IWrCzByeBU83P3xZ7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CmM8e3zjjjZ7uUGVFT9()
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
	private struct _003CGetLatestSheetResultAsync_003Ed__84 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCogSheetResult> _003C_003Et__builder;

		public CvsCogSocketSheet _003C_003E4__this;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!afPgOKz2otRS6xxOuqj()) ? 5 : 4);
			int num2 = default;
			CvsCogSocketSheet cvsCogSocketSheet = default;
			CvsCogSheetResult lastSheetResult = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					try
					{
						TaskAwaiter<CvsCogSheetResult> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = cvsCogSocketSheet.liS1wH05cA().GetAsync<CvsCogSheetResult>(cvsCogSocketSheet.mYH1LMmUb4((string)M9jbO9z7QjZZlnfn5lX(4072))).GetAwaiter();
							DMLM2TzWrbLJIb7xkH2();
							num3 = ((!afPgOKz2otRS6xxOuqj()) ? 6 : 7);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								continue;
							case 9:
							{
								CvsCogSheetResult result = awaiter.GetResult();
								cvsCogSocketSheet.dGX15IHsAv(result, null);
								num3 = 10;
								continue;
							}
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								return;
							case 1:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								if (0 == 0)
								{
									continue;
								}
								goto case 5;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 2;
								if (true)
								{
									continue;
								}
								return;
							case 6:
								return;
							case 0:
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 9;
							case 10:
								lastSheetResult = cvsCogSocketSheet.LastSheetResult;
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
					goto case 1;
				default:
					num = 1;
					break;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 3;
					break;
				case 1:
					_003C_003Et__builder.SetResult(lastSheetResult);
					num = 6;
					if (true)
					{
						break;
					}
					goto case 3;
				case 3:
					cvsCogSocketSheet = _003C_003E4__this;
					goto case 2;
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
		internal static object M9jbO9z7QjZZlnfn5lX(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool afPgOKz2otRS6xxOuqj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DMLM2TzWrbLJIb7xkH2()
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
	private struct _003CGetGraphicsAsync_003Ed__86 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCogShape[]> _003C_003Et__builder;

		public CvsCogSocketSheet _003C_003E4__this;

		public string url;

		private ConfiguredTaskAwaitable<CvsCogShape[]>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Jng1WTzCHScY9eia5pn();
			int num = ((!EHDj2UztkTttfTQwu8y()) ? 1 : 3);
			int num2 = default;
			CvsCogShape[] result = default;
			ConfiguredTaskAwaitable<CvsCogShape[]> configuredTaskAwaitable = default;
			CvsCogSocketSheet cvsCogSocketSheet = default;
			ConfiguredTaskAwaitable<CvsCogShape[]>.ConfiguredTaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 4;
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (Jng1WTzCHScY9eia5pn())
					{
					}
					break;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							configuredTaskAwaitable = cvsCogSocketSheet.liS1wH05cA().GetAsync<CvsCogShape[]>(url).ConfigureAwait(continueOnCapturedContext: false);
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
								return;
							case 5:
								return;
							case 3:
							case 8:
								_003C_003Eu__1 = awaiter;
								goto case 4;
							default:
								num3 = 4;
								continue;
							case 7:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								num3 = 6;
								if (!Jng1WTzCHScY9eia5pn())
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 1;
								if (EHDj2UztkTttfTQwu8y())
								{
									continue;
								}
								goto case 4;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 9:
								num2 = (_003C_003E1__state = 0);
								_ = 0;
								if (!EHDj2UztkTttfTQwu8y())
								{
									num3 = 0;
									continue;
								}
								num3 = 8;
								if (true)
								{
									continue;
								}
								goto case 1;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									if (!Jng1WTzCHScY9eia5pn())
									{
										continue;
									}
								}
								break;
							case 10:
								break;
							}
							break;
						}
						result = awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 4;
				default:
					num = 4;
					break;
				case 5:
					cvsCogSocketSheet = _003C_003E4__this;
					goto case 1;
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
		internal static bool EHDj2UztkTttfTQwu8y()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Jng1WTzCHScY9eia5pn()
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
	private struct _003CGetChartAsync_003Ed__87 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCogChart> _003C_003Et__builder;

		public CvsCogSocketSheet _003C_003E4__this;

		public string url;

		private ConfiguredTaskAwaitable<CvsCogChart>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bkPrAxzKs20aUwQ5Qui();
			int num;
			if (!bC2DoPz5xkCf2oqZqjZ())
			{
				num = 4;
			}
			else
			{
				num = 5;
				if (!bkPrAxzKs20aUwQ5Qui())
				{
					return;
				}
			}
			int num2 = default;
			ConfiguredTaskAwaitable<CvsCogChart> configuredTaskAwaitable = default;
			CvsCogSocketSheet cvsCogSocketSheet = default;
			ConfiguredTaskAwaitable<CvsCogChart>.ConfiguredTaskAwaiter awaiter = default;
			CvsCogChart result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
					if (bkPrAxzKs20aUwQ5Qui())
					{
						continue;
					}
					goto case 2;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							configuredTaskAwaitable = cvsCogSocketSheet.liS1wH05cA().GetAsync<CvsCogChart>(url).ConfigureAwait(continueOnCapturedContext: false);
							num3 = 9;
							if (false)
							{
								goto IL_006a;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
						}
						goto IL_00b5;
						IL_00b5:
						while (true)
						{
							switch (num3)
							{
							case 9:
								break;
							case 1:
								_003C_003Eu__1 = default;
								num3 = 8;
								if (bC2DoPz5xkCf2oqZqjZ())
								{
								}
								continue;
							case 3:
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 0;
								continue;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 0:
								return;
							case 5:
								if (!awaiter.IsCompleted)
								{
									bC2DoPz5xkCf2oqZqjZ();
									if (!bkPrAxzKs20aUwQ5Qui())
									{
										num3 = 6;
										if (bkPrAxzKs20aUwQ5Qui())
										{
											continue;
										}
										goto default;
									}
									num3 = 7;
									if (0 == 0)
									{
										continue;
									}
									goto case 2;
								}
								goto case 10;
							case 2:
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 10:
								result = awaiter.GetResult();
								goto end_IL_00b5;
							}
							goto IL_006a;
							continue;
							end_IL_00b5:
							break;
						}
						goto end_IL_003f;
						IL_006a:
						awaiter = configuredTaskAwaitable.GetAwaiter();
						num3 = 5;
						goto IL_00b5;
						end_IL_003f:;
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
					num = 3;
					continue;
				case 3:
					break;
				case 1:
					cvsCogSocketSheet = _003C_003E4__this;
					goto case 2;
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
		internal static bool bkPrAxzKs20aUwQ5Qui()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bC2DoPz5xkCf2oqZqjZ()
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
	private struct _003CInternalPasteCellsAsync_003Ed__109 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocketSheet _003C_003E4__this;

		public CvsCellRange cellRange;

		public byte[] bytes;

		public bool cutFromSameSheet;

		public bool runSheet;

		private MemoryStream _003Cstream_003E5__2;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QlkncuzoFc6EUHhU060();
			int num = (GfKm1uzPVC2fFqq95J7() ? 2 : 5);
			CvsCogSocketSheet cvsCogSocketSheet = default;
			int num2 = default;
			string text = default;
			string text2 = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 2:
					cvsCogSocketSheet = _003C_003E4__this;
					num = 4;
					break;
				case 4:
					try
					{
						if (num2 != 0)
						{
							text = cvsCogSocketSheet.mYH1LMmUb4((string)rppYySzYVnvUBHWOtCc(49518));
							text2 = cellRange.ToString();
						}
						try
						{
							if (num2 != 0)
							{
								_003Cstream_003E5__2 = new MemoryStream(bytes, writable: false);
							}
							try
							{
								TaskAwaiter<Stream> awaiter;
								int num3;
								if (num2 != 0)
								{
									awaiter = cvsCogSocketSheet.liS1wH05cA().MakeHttpPostRequest((string)jsnm9NzNg4Km5SD1eXa(cvsCogSocketSheet.Ifd1QSV4YZ, text), Gfg1Ca2CVo, (string)rppYySzYVnvUBHWOtCc(49542), _003Cstream_003E5__2, 0, text2, cutFromSameSheet).GetAwaiter();
									num3 = 2;
								}
								else
								{
									awaiter = _003C_003Eu__1;
									num3 = 4;
									if (GfKm1uzPVC2fFqq95J7())
									{
									}
								}
								while (true)
								{
									switch (num3)
									{
									case 2:
										if (awaiter.IsCompleted)
										{
											break;
										}
										_ = 0;
										if (QlkncuzoFc6EUHhU060())
										{
											num3 = 0;
											if (false)
											{
												return;
											}
										}
										else
										{
											num3 = 7;
										}
										continue;
									case 3:
										return;
									case 6:
									case 7:
										num2 = (_003C_003E1__state = -1);
										num3 = 9;
										if (QlkncuzoFc6EUHhU060())
										{
											continue;
										}
										goto case 8;
									case 8:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									default:
										num3 = 3;
										continue;
									case 5:
										_003C_003Eu__1 = awaiter;
										num3 = 8;
										continue;
									case 0:
									case 1:
										num2 = (_003C_003E1__state = 0);
										num3 = 5;
										if (QlkncuzoFc6EUHhU060())
										{
											continue;
										}
										goto case 4;
									case 4:
										_003C_003Eu__1 = default;
										goto case 6;
									case 9:
										break;
									}
									break;
								}
								awaiter.GetResult();
							}
							finally
							{
								if (num2 < 0 && _003Cstream_003E5__2 != null)
								{
									((IDisposable)_003Cstream_003E5__2).Dispose();
								}
							}
							_003Cstream_003E5__2 = null;
						}
						catch (Exception ex)
						{
							throw ex.GetAs<CvsNetworkException>() ?? new CvsNetworkException(ex);
						}
						if (runSheet)
						{
							cvsCogSocketSheet.FireSheetUpdated(runSheet: true);
							UNqRIhzxjUKbWmcgoEa(cvsCogSocketSheet.Ifd1QSV4YZ);
						}
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
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
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
		internal static object rppYySzYVnvUBHWOtCc(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jsnm9NzNg4Km5SD1eXa(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).MakeHttpUrl((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UNqRIhzxjUKbWmcgoEa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCogSocket)P_0).WaitForResultBuildComplete();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QlkncuzoFc6EUHhU060()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GfKm1uzPVC2fFqq95J7()
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
	private struct _003CCopyCellsAsync_003Ed__110 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<byte[]> _003C_003Et__builder;

		public CvsCellRange cellRange;

		public CvsCogSocketSheet _003C_003E4__this;

		private Stream _003Cstream_003E5__2;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		private MemoryStream _003CmemStream_003E5__3;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			byte[] result = default;
			CvsCogSocketSheet cvsCogSocketSheet = default;
			string text = default;
			string text2 = default;
			int num2 = default;
			TaskAwaiter awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 1:
				case 2:
					cvsCogSocketSheet = _003C_003E4__this;
					num = 0;
					break;
				case 0:
					try
					{
						if ((uint)num2 > 1u)
						{
							text = cellRange.ToString();
							text2 = cvsCogSocketSheet.mYH1LMmUb4((string)pA5O49z3TalCoE9ih3x(49594));
						}
						try
						{
							TaskAwaiter<Stream> awaiter;
							if (num2 != 0)
							{
								if (num2 == 1)
								{
									goto IL_0115;
								}
								awaiter = cvsCogSocketSheet.liS1wH05cA().MakeHttpPostRequest((string)cG0yjUzOku8mUPOMWrq(cvsCogSocketSheet.Ifd1QSV4YZ, text2), Gfg1Ca2CVo, kgbOBx7BanbFa22Hp9.ol99ukmDA(49542), Stream.Null, 0, text).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
							}
							Stream result2 = awaiter.GetResult();
							_003Cstream_003E5__2 = result2;
							goto IL_0115;
							IL_0115:
							try
							{
								if (num2 == 1)
								{
									goto IL_0149;
								}
								if (!(_003Cstream_003E5__2 is MemoryStream memoryStream))
								{
									_003CmemStream_003E5__3 = new MemoryStream();
									goto IL_0149;
								}
								result = memoryStream.ToArray();
								goto end_IL_0115;
								IL_0149:
								try
								{
									int num3;
									if (num2 != 1)
									{
										apgumYz1HgAdT1Rf2Pu();
										num3 = (iL1d6BzrTbfU1Bms0wV() ? 9 : 6);
									}
									else
									{
										awaiter2 = _003C_003Eu__2;
										num3 = 7;
									}
									while (true)
									{
										switch (num3)
										{
										case 7:
											_003C_003Eu__2 = default;
											num3 = 5;
											if (0 == 0)
											{
												continue;
											}
											goto case 0;
										case 0:
										case 6:
											awaiter2 = HbgPI4zQoXPYb6Qo8sj(RmgCKozMJKynYxVp9Gl(_003Cstream_003E5__2, _003CmemStream_003E5__3));
											goto case 1;
										case 1:
										case 9:
											if (!awaiter2.IsCompleted)
											{
												num3 = 8;
												if (apgumYz1HgAdT1Rf2Pu())
												{
													continue;
												}
												goto case 4;
											}
											goto IL_0213;
										case 4:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
											num3 = 3;
											if (true)
											{
												continue;
											}
											return;
										case 3:
											return;
										case 8:
											num2 = (_003C_003E1__state = 1);
											num3 = 2;
											continue;
										case 5:
											num2 = (_003C_003E1__state = -1);
											goto IL_0213;
										case 2:
											_003C_003Eu__2 = awaiter2;
											goto case 4;
										default:
											num3 = 4;
											continue;
										case 10:
											{
												result = (byte[])PA1IKozlniENhgIiPfJ(_003CmemStream_003E5__3);
												break;
											}
											IL_0213:
											awaiter2.GetResult();
											num3 = 10;
											continue;
										}
										break;
									}
								}
								finally
								{
									if (num2 < 0 && _003CmemStream_003E5__3 != null)
									{
										cLAmqwze63Np21nfaBj(_003CmemStream_003E5__3);
									}
								}
								end_IL_0115:;
							}
							finally
							{
								if (num2 < 0 && _003Cstream_003E5__2 != null)
								{
									((IDisposable)_003Cstream_003E5__2).Dispose();
								}
							}
						}
						catch (Exception ex)
						{
							if (ex is CvsErrorResponseNetworkException { ErrorCode: -2147483646 })
							{
								kVrnugzR5pbOwcJ555H(xl4onEzu1urqcx8HXbB(ex), CvsException.DataDisplayMessageKey, Afrpj9zIlvX0CBPTuJU());
								throw;
							}
							throw new CvsNetworkException(ex);
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
				case 4:
					num2 = _003C_003E1__state;
					_ = 1;
					if (iL1d6BzrTbfU1Bms0wV())
					{
						num = 5;
						if (iL1d6BzrTbfU1Bms0wV())
						{
						}
					}
					else
					{
						num = 2;
					}
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
		internal static object pA5O49z3TalCoE9ih3x(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cG0yjUzOku8mUPOMWrq(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).MakeHttpUrl((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RmgCKozMJKynYxVp9Gl(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Stream)P_0).CopyToAsync((Stream)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter HbgPI4zQoXPYb6Qo8sj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PA1IKozlniENhgIiPfJ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((MemoryStream)P_0).ToArray();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void cLAmqwze63Np21nfaBj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xl4onEzu1urqcx8HXbB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Exception)P_0).Data;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Afrpj9zIlvX0CBPTuJU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.InvalidPasteRange;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void kVrnugzR5pbOwcJ555H(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDictionary)P_0)[P_1] = P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool apgumYz1HgAdT1Rf2Pu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iL1d6BzrTbfU1Bms0wV()
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
	private struct _003CPostImageByHTTPAsync_003Ed__120 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocketSheet _003C_003E4__this;

		public Bitmap bmp;

		public CvsCellLocation location;

		public bool sync;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!XITcq5za2kYmeHonXop()) ? 4 : 5);
			int num2 = default;
			CvsCogSocketSheet cvsCogSocketSheet = default;
			do
			{
				IL_01fc:
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 3;
					goto IL_01fc;
				case 3:
					cvsCogSocketSheet = _003C_003E4__this;
					goto case 2;
				case 2:
				case 4:
					try
					{
						try
						{
							TaskAwaiter<Stream> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = PostImageHelper.PostImageByHTTPAsync(cvsCogSocketSheet.liS1wH05cA(), bmp, cvsCogSocketSheet.bWo10BjELQ(location), cvsCogSocketSheet.u5B19sM6Gn((string)rm9tQhzGc9YOjaft11f(49094)), Iqnu0jzX73gTYNXxnue(), useSystemDebug: true, null, UCi12Xf2ZY, "", sync).GetAwaiter();
								num3 = 2;
								if (false)
								{
									return;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 3;
							}
							while (true)
							{
								switch (num3)
								{
								case 0:
									return;
								case 5:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 0;
									continue;
								case 8:
									_003C_003Eu__1 = awaiter;
									num3 = 5;
									if (0 == 0)
									{
										continue;
									}
									goto case 1;
								case 1:
								case 4:
									num2 = (_003C_003E1__state = 0);
									num3 = 8;
									if (XITcq5za2kYmeHonXop())
									{
										continue;
									}
									goto case 6;
								case 6:
								case 7:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									if (XITcq5za2kYmeHonXop())
									{
										continue;
									}
									goto case 2;
								case 2:
									if (!awaiter.IsCompleted)
									{
										XFm27Lzn8pBb3IBQ9k7();
										num3 = ((!XITcq5za2kYmeHonXop()) ? 7 : 4);
										continue;
									}
									break;
								case 3:
									_003C_003Eu__1 = default;
									goto case 6;
								case 9:
									break;
								}
								break;
							}
							awaiter.GetResult();
						}
						catch (Exception ex)
						{
							if (ex is CvsNetworkException)
							{
								throw;
							}
							throw new CvsNetworkException(ex);
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
					num = 1;
					goto IL_01fc;
				case 1:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
			}
			while (0 == 0);
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
		internal static object rm9tQhzGc9YOjaft11f(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TimeSpan Iqnu0jzX73gTYNXxnue()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCogSocketAcq.HttpImageTimeout;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XITcq5za2kYmeHonXop()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XFm27Lzn8pBb3IBQ9k7()
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
	private struct _003CInvalidateCell_003Ed__121 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocketSheet _003C_003E4__this;

		public CvsCellLocation location;

		public string expression;

		private ConfiguredTaskAwaitable<CvsPropertySheetResult>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			int num2 = default;
			ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter awaiter = default;
			ConfiguredTaskAwaitable<CvsPropertySheetResult>.ConfiguredTaskAwaiter awaiter2 = default;
			ConfiguredTaskAwaitable<CvsPropertySheetResult> configuredTaskAwaitable2 = default;
			ConfiguredTaskAwaitable<object> configuredTaskAwaitable = default;
			CvsCogSocketSheet cvsCogSocketSheet = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 11;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 9;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 6;
						}
						while (true)
						{
							switch (num3)
							{
							case 15:
								num2 = (_003C_003E1__state = -1);
								goto default;
							case 9:
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 17;
								continue;
							case 1:
								_003C_003Eu__1 = awaiter2;
								num3 = 16;
								continue;
							case 0:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter;
								num3 = 10;
								if (p6sDo5z6UPM6DXo4mXK())
								{
								}
								continue;
							case 16:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								_ = 1;
								num3 = ((!p6sDo5z6UPM6DXo4mXK()) ? 2 : 4);
								continue;
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								continue;
							default:
								awaiter2.GetResult();
								num3 = 7;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 2:
							case 5:
								return;
							case 12:
								awaiter2 = configuredTaskAwaitable2.GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num3 = 14;
									continue;
								}
								goto default;
							case 3:
								return;
							case 13:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								break;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 15;
								continue;
							case 14:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								continue;
							case 7:
								configuredTaskAwaitable = cvsCogSocketSheet.PropSheetOkAsync(location, expression).ConfigureAwait(continueOnCapturedContext: false);
								num3 = 13;
								if (q0OfddzbsPo5WgQZAHF())
								{
									continue;
								}
								goto case 11;
							case 11:
								configuredTaskAwaitable2 = cvsCogSocketSheet.PropSheetInitAsync(location, expression).ConfigureAwait(continueOnCapturedContext: false);
								num3 = 12;
								if (true)
								{
									continue;
								}
								break;
							case 17:
								break;
							}
							break;
						}
						awaiter.GetResult();
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
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				case 0:
				case 1:
					cvsCogSocketSheet = _003C_003E4__this;
					goto case 2;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 3:
					num2 = _003C_003E1__state;
					p6sDo5z6UPM6DXo4mXK();
					num = ((!q0OfddzbsPo5WgQZAHF()) ? 4 : 0);
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
		internal static bool q0OfddzbsPo5WgQZAHF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool p6sDo5z6UPM6DXo4mXK()
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
	private struct _003CPostDataByHTTPAsync_003Ed__123 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocketSheet _003C_003E4__this;

		public Stream dataStream;

		public string contentType;

		public CvsCellLocation location;

		public TimeSpan timeout;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			CvsCogSocketSheet cvsCogSocketSheet = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					cvsCogSocketSheet = _003C_003E4__this;
					_ = 0;
					if (GB0KHyzpJxFl386iIdR())
					{
						num = 1;
						if (0 == 0)
						{
							continue;
						}
						goto case 0;
					}
					num = 5;
					if (IZWhHJz0iG7ovc7bcJx())
					{
					}
					continue;
				case 0:
					num2 = _003C_003E1__state;
					num = 4;
					if (true)
					{
						continue;
					}
					goto case 1;
				case 1:
				case 2:
					try
					{
						try
						{
							TaskAwaiter<Stream> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = PostImageHelper.PostDataByHTTPAsync(cvsCogSocketSheet.liS1wH05cA(), dataStream, contentType, cvsCogSocketSheet.bWo10BjELQ(location), cvsCogSocketSheet.u5B19sM6Gn((string)Xuw22xz4JYUh7TgqS4i(4802)), timeout, useSystemDebug: true).GetAwaiter();
								_ = 0;
								num3 = ((!GB0KHyzpJxFl386iIdR()) ? 1 : 7);
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 6;
							}
							while (true)
							{
								switch (num3)
								{
								case 6:
									_003C_003Eu__1 = default;
									num3 = 8;
									continue;
								case 8:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									if (0 == 0)
									{
										continue;
									}
									goto case 0;
								case 0:
								case 7:
									if (!awaiter.IsCompleted)
									{
										num3 = 5;
										continue;
									}
									break;
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									return;
								case 2:
									_003C_003Eu__1 = awaiter;
									num3 = 3;
									continue;
								case 1:
									return;
								case 5:
									num2 = (_003C_003E1__state = 0);
									num3 = 2;
									if (0 == 0)
									{
										continue;
									}
									break;
								case 9:
									break;
								}
								break;
							}
							awaiter.GetResult();
						}
						catch (Exception ex)
						{
							if (ex is CvsNetworkException)
							{
								throw;
							}
							throw new CvsNetworkException(ex);
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
		internal static object Xuw22xz4JYUh7TgqS4i(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GB0KHyzpJxFl386iIdR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IZWhHJz0iG7ovc7bcJx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass137_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct vtbGSuDITPsBUjvDnu : IAsyncStateMachine
		{
			public int I3Sm8QGJGT;

			public AsyncTaskMethodBuilder<Stream> ywdmztOydw;

			public _003C_003Ec__DisplayClass137_0 VuwnPtJg8A;

			private TaskAwaiter<Stream> myxnIjymRX;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				int num = 5;
				int num2 = default;
				Stream result = default;
				_003C_003Ec__DisplayClass137_0 obj = default;
				while (true)
				{
					switch (num)
					{
					case 5:
						num2 = I3Sm8QGJGT;
						num = 4;
						break;
					default:
						ywdmztOydw.SetResult(result);
						num = 6;
						break;
					case 1:
					case 2:
						try
						{
							TaskAwaiter<Stream> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = obj._003C_003E4__this.liS1wH05cA().MakeHttpPostRequest(obj.url, obj.timeout, null, obj.nullStream).GetAwaiter();
								num3 = 8;
								if (!OY9IbNseypNkIVZ291Ic())
								{
									goto IL_007e;
								}
								goto IL_0119;
							}
							awaiter = myxnIjymRX;
							goto IL_015c;
							IL_017c:
							result = awaiter.GetResult();
							goto end_IL_003f;
							IL_0119:
							while (true)
							{
								switch (num3)
								{
								case 2:
									break;
								case 8:
									goto IL_0097;
								case 7:
									num2 = (I3Sm8QGJGT = -1);
									num3 = 9;
									if (OY9IbNseypNkIVZ291Ic())
									{
										continue;
									}
									goto case 3;
								case 3:
									myxnIjymRX = awaiter;
									num3 = 0;
									if (OY9IbNseypNkIVZ291Ic())
									{
										continue;
									}
									return;
								case 1:
								case 4:
									return;
								case 0:
									ywdmztOydw.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									goto default;
								default:
									_ = 0;
									num3 = (OY9IbNseypNkIVZ291Ic() ? 1 : 6);
									continue;
								case 5:
								case 6:
									goto IL_015c;
								case 9:
									goto IL_017c;
								}
								break;
							}
							goto IL_007e;
							IL_007e:
							num2 = (I3Sm8QGJGT = 0);
							num3 = 3;
							if (!OY9IbNseypNkIVZ291Ic())
							{
								goto IL_0097;
							}
							goto IL_0119;
							IL_0097:
							if (!awaiter.IsCompleted)
							{
								num3 = 2;
								goto IL_0119;
							}
							goto IL_017c;
							IL_015c:
							myxnIjymRX = default;
							num3 = 7;
							if (yDTBePsegXYsGJoBGJnr())
							{
							}
							goto IL_0119;
							end_IL_003f:;
						}
						catch (Exception exception)
						{
							I3Sm8QGJGT = -2;
							ywdmztOydw.SetException(exception);
							return;
						}
						I3Sm8QGJGT = -2;
						goto default;
					case 4:
						obj = VuwnPtJg8A;
						yDTBePsegXYsGJoBGJnr();
						num = (OY9IbNseypNkIVZ291Ic() ? 1 : 0);
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
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				ywdmztOydw.SetStateMachine(P_0);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool OY9IbNseypNkIVZ291Ic()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool yDTBePsegXYsGJoBGJnr()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		public CvsCogSocketSheet _003C_003E4__this;

		public string url;

		public TimeSpan timeout;

		public Stream nullStream;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass137_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cG36oHzFEKoZDHSpqWQ();
			TBmCdbzmrCBkC4KuFYh(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(vtbGSuDITPsBUjvDnu))]
		internal Task<Stream> _003CGetArchiveByHttp_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			vtbGSuDITPsBUjvDnu stateMachine = default;
			stateMachine.ywdmztOydw = AsyncTaskMethodBuilder<Stream>.Create();
			stateMachine.VuwnPtJg8A = this;
			stateMachine.I3Sm8QGJGT = -1;
			stateMachine.ywdmztOydw.Start(ref stateMachine);
			return stateMachine.ywdmztOydw.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void cG36oHzFEKoZDHSpqWQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void TBmCdbzmrCBkC4KuFYh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lFVMFRzkC7ALYdMMjge()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool S1LGJhzfBYnQyFm2uBh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass142_0
	{
		public CvsCogSocketSheet _003C_003E4__this;

		public string path;

		public TimeSpan timeout;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass142_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			gvLRIdzZ6WDE1xyjUT1();
			mQKW87zJGa20WQ1vN6U(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gvLRIdzZ6WDE1xyjUT1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void mQKW87zJGa20WQ1vN6U(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MvhjIvzynnipFWPaBDK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zRRJbgzgNa9Mt7tXOM9()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass142_1
	{
		[StructLayout(LayoutKind.Auto)]
		private struct zcw1QxUJcZjBUhQoXL : IAsyncStateMachine
		{
			public int Gp5n1eVEQA;

			public AsyncTaskMethodBuilder<Stream> aQbnxqGDmM;

			public _003C_003Ec__DisplayClass142_1 pVunFqKP9R;

			private TaskAwaiter<Stream> RNjnbOMvXr;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				_ = 0;
				int num;
				if (jkHYoUseZe5rl7soeYCx())
				{
					num = 4;
					if (U0L5vDseJKydoljcOIhb())
					{
					}
				}
				else
				{
					num = 5;
					if (U0L5vDseJKydoljcOIhb())
					{
						goto IL_0211;
					}
				}
				goto IL_01c9;
				IL_0229:
				int num2 = Gp5n1eVEQA;
				num = 1;
				goto IL_01c9;
				IL_0211:
				Stream result = default;
				aQbnxqGDmM.SetResult(result);
				num = 6;
				if (true)
				{
					goto IL_01c9;
				}
				goto IL_0229;
				IL_01c9:
				_003C_003Ec__DisplayClass142_1 obj = default;
				while (true)
				{
					switch (num)
					{
					case 2:
					case 5:
						try
						{
							TaskAwaiter<Stream> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = obj.CS_0024_003C_003E8__locals1._003C_003E4__this.liS1wH05cA().MakeHttpPostRequest((string)S9Cc6dse8IuUcrWMQ3l9(obj.CS_0024_003C_003E8__locals1._003C_003E4__this.Ifd1QSV4YZ, obj.CS_0024_003C_003E8__locals1.path), obj.CS_0024_003C_003E8__locals1.timeout, (string)z7OJ4ksezkVfFpiLLKAA(49542), obj.byteStream).GetAwaiter();
								num3 = 7;
							}
							else
							{
								awaiter = RNjnbOMvXr;
								num3 = 3;
							}
							while (true)
							{
								switch (num3)
								{
								case 3:
									RNjnbOMvXr = default;
									goto case 2;
								case 1:
								case 4:
									num2 = (Gp5n1eVEQA = 0);
									num3 = 8;
									continue;
								case 7:
									if (awaiter.IsCompleted)
									{
										break;
									}
									_ = 0;
									if (!jkHYoUseZe5rl7soeYCx())
									{
										num3 = 2;
										continue;
									}
									num3 = 4;
									if (0 == 0)
									{
										continue;
									}
									goto case 5;
								case 5:
									aQbnxqGDmM.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 0;
									if (0 == 0)
									{
										continue;
									}
									goto case 8;
								case 8:
									RNjnbOMvXr = awaiter;
									num3 = 5;
									if (U0L5vDseJKydoljcOIhb())
									{
									}
									continue;
								case 0:
									return;
								case 2:
								case 6:
									num2 = (Gp5n1eVEQA = -1);
									num3 = 9;
									if (true)
									{
										continue;
									}
									break;
								case 9:
									break;
								}
								break;
							}
							result = awaiter.GetResult();
						}
						catch (Exception exception)
						{
							Gp5n1eVEQA = -2;
							aQbnxqGDmM.SetException(exception);
							return;
						}
						Gp5n1eVEQA = -2;
						break;
					default:
						num = 3;
						continue;
					case 1:
						obj = pVunFqKP9R;
						goto case 2;
					case 3:
						break;
					case 0:
					case 4:
						goto IL_0229;
					case 6:
						return;
					}
					break;
				}
				goto IL_0211;
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				aQbnxqGDmM.SetStateMachine(P_0);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object S9Cc6dse8IuUcrWMQ3l9(object P_0, object P_1)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((CvsCogSocket)P_0).MakeHttpUrl((string)P_1);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object z7OJ4ksezkVfFpiLLKAA(int P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool jkHYoUseZe5rl7soeYCx()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool U0L5vDseJKydoljcOIhb()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		public MemoryStream byteStream;

		public _003C_003Ec__DisplayClass142_0 CS_0024_003C_003E8__locals1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass142_1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			aLkUUHswwb6LiRbx435P();
			d6i1Jysws8jOIUucTirr(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(zcw1QxUJcZjBUhQoXL))]
		internal Task<Stream> _003CPostArchiveByHTTP_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zcw1QxUJcZjBUhQoXL stateMachine = default;
			stateMachine.aQbnxqGDmM = AsyncTaskMethodBuilder<Stream>.Create();
			stateMachine.pVunFqKP9R = this;
			stateMachine.Gp5n1eVEQA = -1;
			stateMachine.aQbnxqGDmM.Start(ref stateMachine);
			return stateMachine.aQbnxqGDmM.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void aLkUUHswwb6LiRbx435P()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void d6i1Jysws8jOIUucTirr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BoSaeaz8n8rRdL04aHh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hWZ7cIzzOvUCrqR56MV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass142_2
	{
		[StructLayout(LayoutKind.Auto)]
		private struct KiLbFPonXb4wVT6hGF : IAsyncStateMachine
		{
			public int YwDnavCLlo;

			public AsyncTaskMethodBuilder<Stream> kPpnOl5JoV;

			public _003C_003Ec__DisplayClass142_2 avTnpGuZWN;

			private TaskAwaiter<Stream> YHNnhJqP8D;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				int num = 0;
				_003C_003Ec__DisplayClass142_2 obj = default;
				Stream result = default;
				int num2 = default;
				while (true)
				{
					switch (num)
					{
					case 4:
						obj = avTnpGuZWN;
						glcf3Isuwu8gMsT5iTwr();
						if (!KFpGdrsusWVMrp9IW4kA())
						{
							num = 1;
							if (0 == 0)
							{
								break;
							}
							goto default;
						}
						num = 5;
						break;
					default:
						kPpnOl5JoV.SetResult(result);
						num = 6;
						if (glcf3Isuwu8gMsT5iTwr())
						{
							break;
						}
						goto case 0;
					case 0:
						num2 = YwDnavCLlo;
						num = 4;
						break;
					case 1:
					case 2:
						try
						{
							TaskAwaiter<Stream> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = obj.CS_0024_003C_003E8__locals2._003C_003E4__this.liS1wH05cA().MakeHttpPostRequest((string)AwUVV5suhbFvZfjbSpcC(obj.CS_0024_003C_003E8__locals2._003C_003E4__this.Ifd1QSV4YZ, obj.CS_0024_003C_003E8__locals2.path), obj.CS_0024_003C_003E8__locals2.timeout, (string)g768RQsuLqKXRSKYVRtK(13942), obj.dataStream).GetAwaiter();
								num3 = 5;
							}
							else
							{
								awaiter = YHNnhJqP8D;
								num3 = 8;
							}
							while (true)
							{
								switch (num3)
								{
								case 5:
									if (!awaiter.IsCompleted)
									{
										KFpGdrsusWVMrp9IW4kA();
										num3 = (glcf3Isuwu8gMsT5iTwr() ? 4 : 0);
										continue;
									}
									break;
								case 0:
								case 2:
									YHNnhJqP8D = awaiter;
									num3 = 7;
									continue;
								case 1:
								case 4:
									num2 = (YwDnavCLlo = 0);
									goto case 0;
								case 8:
									YHNnhJqP8D = default;
									num3 = 3;
									continue;
								case 3:
									num2 = (YwDnavCLlo = -1);
									num3 = 9;
									if (0 == 0)
									{
										continue;
									}
									return;
								case 6:
									return;
								case 7:
									kPpnOl5JoV.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 6;
									continue;
								case 9:
									break;
								}
								break;
							}
							result = awaiter.GetResult();
						}
						catch (Exception exception)
						{
							YwDnavCLlo = -2;
							kPpnOl5JoV.SetException(exception);
							return;
						}
						YwDnavCLlo = -2;
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
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				kPpnOl5JoV.SetStateMachine(P_0);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object AwUVV5suhbFvZfjbSpcC(object P_0, object P_1)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((CvsCogSocket)P_0).MakeHttpUrl((string)P_1);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object g768RQsuLqKXRSKYVRtK(int P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool glcf3Isuwu8gMsT5iTwr()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool KFpGdrsusWVMrp9IW4kA()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		public MemoryStream dataStream;

		public _003C_003Ec__DisplayClass142_0 CS_0024_003C_003E8__locals2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass142_2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			it1XPbsw9KmA48sbpDhh();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(KiLbFPonXb4wVT6hGF))]
		internal Task<Stream> _003CPostArchiveByHTTP_003Eb__1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KiLbFPonXb4wVT6hGF stateMachine = default;
			stateMachine.kPpnOl5JoV = AsyncTaskMethodBuilder<Stream>.Create();
			stateMachine.avTnpGuZWN = this;
			stateMachine.YwDnavCLlo = -1;
			stateMachine.kPpnOl5JoV.Start(ref stateMachine);
			return stateMachine.kPpnOl5JoV.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void it1XPbsw9KmA48sbpDhh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YnviwGswh1WtUm38XwEV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BrEHBrswLyKtqO2oLDHM()
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
	private struct _003CGetEditInfosAsync_003Ed__145 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCogEditInfo[]> _003C_003Et__builder;

		public CvsCogSocketSheet _003C_003E4__this;

		private ConfiguredTaskAwaitable<CvsCogEditInfo[]>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			pjPsn2swE8WThOLMToeb();
			int num = ((!Gp3oraswSBVe4L6BrjKi()) ? 5 : 4);
			CvsCogSocketSheet cvsCogSocketSheet = default;
			CvsCogEditInfo[] result = default;
			int num2 = default;
			string path = default;
			ConfiguredTaskAwaitable<CvsCogEditInfo[]>.ConfiguredTaskAwaiter awaiter = default;
			ConfiguredTaskAwaitable<CvsCogEditInfo[]> configuredTaskAwaitable = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					cvsCogSocketSheet = _003C_003E4__this;
					num = 2;
					break;
				case 3:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							path = cvsCogSocketSheet.mYH1LMmUb4(kgbOBx7BanbFa22Hp9.ol99ukmDA(49616));
							num3 = 7;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
						}
						while (true)
						{
							switch (num3)
							{
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								continue;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 8;
								if (!pjPsn2swE8WThOLMToeb())
								{
									continue;
								}
								goto case 8;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 9:
								num2 = (_003C_003E1__state = 0);
								goto case 3;
							case 3:
							case 4:
								_003C_003Eu__1 = awaiter;
								goto case 5;
							default:
								num3 = 5;
								continue;
							case 0:
							case 1:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 9;
								if (Gp3oraswSBVe4L6BrjKi())
								{
									continue;
								}
								goto case 7;
							case 7:
								configuredTaskAwaitable = cvsCogSocketSheet.liS1wH05cA().PostAsync<CvsCogEditInfo[]>(path, Array.Empty<object>()).ConfigureAwait(continueOnCapturedContext: false);
								_ = 0;
								if (!Gp3oraswSBVe4L6BrjKi())
								{
									num3 = 4;
									if (0 == 0)
									{
										continue;
									}
									goto case 3;
								}
								num3 = 0;
								continue;
							case 6:
								return;
							case 10:
								break;
							}
							break;
						}
						result = awaiter.GetResult();
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
					if (false)
					{
						return;
					}
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
		internal static bool Gp3oraswSBVe4L6BrjKi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pjPsn2swE8WThOLMToeb()
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
	private struct _003CGetRowCountAsync_003Ed__146 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

		public CvsCogSocketSheet _003C_003E4__this;

		private ConfiguredTaskAwaitable<long>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			int num2 = default;
			CvsCogSocketSheet cvsCogSocketSheet = default;
			ConfiguredTaskAwaitable<long> configuredTaskAwaitable = default;
			ConfiguredTaskAwaitable<long>.ConfiguredTaskAwaiter awaiter = default;
			int result = default;
			do
			{
				IL_01b7:
				switch (num)
				{
				case 2:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((!C2XiFGswvg9dNttQX2l5()) ? 5 : 0);
					goto IL_01b7;
				case 0:
				case 1:
					cvsCogSocketSheet = _003C_003E4__this;
					num = 4;
					goto IL_01b7;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							configuredTaskAwaitable = cvsCogSocketSheet.liS1wH05cA().GetAsync<long>(cvsCogSocketSheet.mYH1LMmUb4((string)zXjh6GswVWEAT8OCdca0(49656))).ConfigureAwait(continueOnCapturedContext: false);
							num3 = 1;
							goto IL_00a7;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0147;
						IL_0147:
						_003C_003Eu__1 = default;
						num3 = 3;
						goto IL_00a7;
						IL_00a7:
						while (true)
						{
							switch (num3)
							{
							case 0:
								num2 = (_003C_003E1__state = 0);
								num3 = 9;
								if (true)
								{
									continue;
								}
								goto case 9;
							case 9:
								_003C_003Eu__1 = awaiter;
								goto case 7;
							default:
								num3 = 7;
								continue;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								_ = 0;
								num3 = ((!C2XiFGswvg9dNttQX2l5()) ? 2 : 4);
								continue;
							case 4:
							case 5:
								return;
							case 1:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								num3 = 8;
								continue;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 2:
							case 6:
								break;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								goto case 10;
							case 10:
								result = (int)awaiter.GetResult();
								goto end_IL_00a7;
							}
							goto IL_0147;
							continue;
							end_IL_00a7:
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
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult(result);
				num = 6;
			}
			while (true);
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
		internal static object zXjh6GswVWEAT8OCdca0(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool C2XiFGswvg9dNttQX2l5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vAoh18swHGkeUwGXSleV()
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
	private struct _003CGetEasyBuilderEditable_003Ed__147 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public CvsCogSocketSheet _003C_003E4__this;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			CvsCogSocketSheet cvsCogSocketSheet = default;
			int num2 = default;
			string path = default;
			ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter = default;
			ConfiguredTaskAwaitable<bool> configuredTaskAwaitable = default;
			bool result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					cvsCogSocketSheet = _003C_003E4__this;
					_ = 0;
					if (VNREHsswAHfUvRPbFDTZ())
					{
						num = 5;
						if (VNREHsswAHfUvRPbFDTZ())
						{
							break;
						}
						goto case 2;
					}
					num = 4;
					break;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							path = cvsCogSocketSheet.mYH1LMmUb4((string)K6LBmRswU6HoqGa6Hwei(49676));
							num3 = 6;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 3;
						}
						while (true)
						{
							switch (num3)
							{
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								continue;
							case 8:
								return;
							case 2:
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								break;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 1:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								yqYBtrswDok7AyEkgyXJ();
								if (VNREHsswAHfUvRPbFDTZ())
								{
									num3 = 9;
									if (true)
									{
										continue;
									}
									goto case 6;
								}
								num3 = 7;
								continue;
							case 6:
								configuredTaskAwaitable = cvsCogSocketSheet.liS1wH05cA().GetAsync<bool>(path).ConfigureAwait(continueOnCapturedContext: false);
								num3 = 1;
								if (yqYBtrswDok7AyEkgyXJ())
								{
								}
								continue;
							case 0:
								num2 = (_003C_003E1__state = 0);
								goto default;
							default:
								_003C_003Eu__1 = awaiter;
								num3 = 5;
								continue;
							case 10:
								break;
							}
							break;
						}
						result = awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 1:
					num2 = _003C_003E1__state;
					num = 0;
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
		internal static object K6LBmRswU6HoqGa6Hwei(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VNREHsswAHfUvRPbFDTZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yqYBtrswDok7AyEkgyXJ()
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
	private struct _003CGetSpreadsheetEditable_003Ed__148 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public CvsCogSocketSheet _003C_003E4__this;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			BEeRwxswTNgw8Nb30d65();
			int num = (qgdlJMswd5tR8XHhVOXP() ? 2 : 4);
			int num2 = default;
			string path = default;
			CvsCogSocketSheet cvsCogSocketSheet = default;
			ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter = default;
			ConfiguredTaskAwaitable<bool> configuredTaskAwaitable = default;
			bool result = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							path = cvsCogSocketSheet.mYH1LMmUb4((string)KxnT84swivVNTH0UV4by(49718));
							num3 = 3;
							if (false)
							{
								goto IL_004b;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
						}
						goto IL_0066;
						IL_0066:
						while (true)
						{
							switch (num3)
							{
							case 9:
								break;
							default:
								goto IL_0097;
							case 0:
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 5;
								continue;
							case 2:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								num3 = 1;
								continue;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									continue;
								}
								goto case 10;
							case 8:
								_003C_003Eu__1 = default;
								goto case 6;
							case 6:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 3:
								configuredTaskAwaitable = cvsCogSocketSheet.liS1wH05cA().GetAsync<bool>(path).ConfigureAwait(continueOnCapturedContext: false);
								num3 = 2;
								continue;
							case 10:
								result = awaiter.GetResult();
								goto end_IL_0028;
							}
							break;
						}
						goto IL_004b;
						IL_0097:
						qgdlJMswd5tR8XHhVOXP();
						num3 = ((!BEeRwxswTNgw8Nb30d65()) ? 6 : 0);
						goto IL_0066;
						IL_004b:
						num2 = (_003C_003E1__state = 0);
						goto IL_0097;
						end_IL_0028:;
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
					continue;
				case 5:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					continue;
				case 1:
				case 2:
					break;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					break;
				case 6:
					return;
				}
				cvsCogSocketSheet = _003C_003E4__this;
				num = 3;
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
		internal static object KxnT84swivVNTH0UV4by(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BEeRwxswTNgw8Nb30d65()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qgdlJMswd5tR8XHhVOXP()
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
	private struct _003CCheckForSnippets_003Ed__149 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsCogSocketSheet _003C_003E4__this;

		private ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			string path = default;
			CvsCogSocketSheet cvsCogSocketSheet = default;
			ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter awaiter = default;
			ConfiguredTaskAwaitable<object> configuredTaskAwaitable = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							path = cvsCogSocketSheet.mYH1LMmUb4((string)Xpo5rjswj38jkcG6T8iO(49760));
							_ = 0;
							if (llHd60swqCNlaGigKc5I())
							{
								num3 = 3;
								if (!llHd60swqCNlaGigKc5I())
								{
									return;
								}
							}
							else
							{
								num3 = 6;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
						}
						while (true)
						{
							switch (num3)
							{
							case 9:
								return;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								break;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 0:
							case 3:
								configuredTaskAwaitable = cvsCogSocketSheet.liS1wH05cA().PostAsync<object>(path, Array.Empty<object>()).ConfigureAwait(continueOnCapturedContext: false);
								num3 = 1;
								continue;
							case 5:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								continue;
							case 1:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								num3 = 8;
								if (fkX54gswB5iMBRPnUx3Z())
								{
								}
								continue;
							case 10:
								break;
							}
							break;
						}
						awaiter.GetResult();
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
					num2 = _003C_003E1__state;
					_ = 0;
					num = (llHd60swqCNlaGigKc5I() ? 4 : 0);
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 4:
					cvsCogSocketSheet = _003C_003E4__this;
					num = 2;
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
		internal static object Xpo5rjswj38jkcG6T8iO(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool llHd60swqCNlaGigKc5I()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fkX54gswB5iMBRPnUx3Z()
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
	private struct _003CGetEditInfoAsync_003Ed__150 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCogEditInfo[]> _003C_003Et__builder;

		public CvsCogSocketSheet _003C_003E4__this;

		public CvsCellLocation cellLocation;

		private ConfiguredTaskAwaitable<CvsCogEditInfo[]>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			string path = default;
			CvsCogSocketSheet cvsCogSocketSheet = default;
			ConfiguredTaskAwaitable<CvsCogEditInfo[]>.ConfiguredTaskAwaiter awaiter = default;
			ConfiguredTaskAwaitable<CvsCogEditInfo[]> configuredTaskAwaitable = default;
			CvsCogEditInfo[] result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							path = cvsCogSocketSheet.mYH1LMmUb4((string)S2w7m5swWERymdWxvPXn(49616));
							num3 = 8;
							if (!GvnfCXswc02fldw1GH39())
							{
								goto IL_003f;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
						}
						goto IL_006f;
						IL_006f:
						while (true)
						{
							switch (num3)
							{
							case 6:
								break;
							case 0:
							case 3:
								goto IL_0054;
							case 9:
								if (!awaiter.IsCompleted)
								{
									_ = 1;
									if (adbnPIsw26vm9XBfvp07())
									{
										num3 = 1;
										continue;
									}
									num3 = 0;
									if (GvnfCXswc02fldw1GH39())
									{
										continue;
									}
									goto case 5;
								}
								goto case 10;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							default:
								goto IL_0126;
							case 8:
								configuredTaskAwaitable = cvsCogSocketSheet.liS1wH05cA().PostAsync<CvsCogEditInfo[]>(path, new object[1] { cellLocation.ToString() }).ConfigureAwait(continueOnCapturedContext: false);
								num3 = 6;
								if (0 == 0)
								{
									continue;
								}
								goto case 10;
							case 10:
								result = awaiter.GetResult();
								goto end_IL_0018;
							}
							break;
						}
						goto IL_003f;
						IL_0126:
						_003C_003Eu__1 = awaiter;
						num3 = 5;
						goto IL_006f;
						IL_003f:
						awaiter = configuredTaskAwaitable.GetAwaiter();
						num3 = 9;
						if (false)
						{
							goto IL_0054;
						}
						goto IL_006f;
						IL_0054:
						num2 = (_003C_003E1__state = 0);
						goto IL_0126;
						end_IL_0018:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 0:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				case 5:
					cvsCogSocketSheet = _003C_003E4__this;
					adbnPIsw26vm9XBfvp07();
					num = (GvnfCXswc02fldw1GH39() ? 1 : 4);
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
		internal static object S2w7m5swWERymdWxvPXn(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GvnfCXswc02fldw1GH39()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool adbnPIsw26vm9XBfvp07()
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
	private struct _003CGetEditInfosAsync_003Ed__151 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCogEditInfo[]> _003C_003Et__builder;

		public CvsCogSocketSheet _003C_003E4__this;

		public CvsCellRange cellRange;

		private ConfiguredTaskAwaitable<CvsCogEditInfo[]>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			qwc4hVsw71VRGpx7d3on();
			int num;
			if (!KqGRY6swtkdsPpCvoGc7())
			{
				num = 1;
			}
			else
			{
				num = 4;
				if (KqGRY6swtkdsPpCvoGc7())
				{
					goto IL_021b;
				}
			}
			goto IL_01e4;
			IL_01e4:
			CvsCogEditInfo[] result = default;
			CvsCogSocketSheet cvsCogSocketSheet = default;
			int num2 = default;
			string path = default;
			ConfiguredTaskAwaitable<CvsCogEditInfo[]>.ConfiguredTaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					goto case 2;
				case 2:
					cvsCogSocketSheet = _003C_003E4__this;
					num = 5;
					continue;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							path = cvsCogSocketSheet.mYH1LMmUb4((string)L1tM67swCnFAXtYTue6o(49616));
							num3 = 5;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
							if (!qwc4hVsw71VRGpx7d3on())
							{
								goto IL_01a1;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 5:
								awaiter = cvsCogSocketSheet.liS1wH05cA().PostAsync<CvsCogEditInfo[]>(path, new object[1] { cellRange.ToString() }).ConfigureAwait(continueOnCapturedContext: false)
									.GetAwaiter();
								num3 = 9;
								continue;
							case 1:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								continue;
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								break;
							case 0:
								_003C_003Eu__1 = default;
								goto case 1;
							case 4:
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								continue;
							case 2:
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								_ = 0;
								num3 = ((!qwc4hVsw71VRGpx7d3on()) ? 1 : 6);
								continue;
							case 3:
								return;
							case 10:
								break;
							}
							break;
						}
						goto IL_01a1;
						IL_01a1:
						result = awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 0:
				case 1:
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_021b;
			IL_021b:
			num2 = _003C_003E1__state;
			num = 2;
			goto IL_01e4;
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
		internal static object L1tM67swCnFAXtYTue6o(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qwc4hVsw71VRGpx7d3on()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KqGRY6swtkdsPpCvoGc7()
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
	private struct _003CGetExpressionGraphic_003Ed__152 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCogExpressionGraphic> _003C_003Et__builder;

		public CvsCogEditInfo editInfo;

		public CvsCogSocketSheet _003C_003E4__this;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (U3iiqwswKG9dOSioDoxu())
			{
				num = 3;
			}
			else
			{
				num = 2;
				if (VcIqnFsw5ZkbhutTCIkV())
				{
				}
			}
			CvsCogExpressionGraphic result = default;
			int num2 = default;
			TaskAwaiter<object> awaiter = default;
			CvsCogSocketSheet cvsCogSocketSheet = default;
			do
			{
				IL_01d9:
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					goto IL_01d9;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (editInfo == null)
							{
								goto IL_014e;
							}
							num3 = 8;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
						}
						goto IL_006e;
						IL_014e:
						result = null;
						_ = 0;
						if (!U3iiqwswKG9dOSioDoxu())
						{
							num3 = 6;
						}
						else
						{
							num3 = 9;
							if (false)
							{
								goto IL_0168;
							}
						}
						goto IL_006e;
						IL_006e:
						while (true)
						{
							switch (num3)
							{
							case 10:
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 4;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								continue;
							case 3:
								return;
							case 8:
								break;
							case 2:
							case 9:
								goto end_IL_006e;
							case 7:
								goto IL_014e;
							case 0:
								goto IL_0168;
							case 1:
								_003C_003Eu__1 = default;
								num3 = 4;
								continue;
							case 11:
								goto IL_0191;
							}
							if (yYVOKpswoCfNf592KBYV(editInfo.Url))
							{
								num3 = 7;
								continue;
							}
							awaiter = cvsCogSocketSheet.liS1wH05cA().GetAsync<object>((string)MenasqswPqQmYT8qly0P(editInfo)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num3 = 0;
								if (true)
								{
									continue;
								}
								goto IL_014e;
							}
							goto IL_0191;
							IL_0191:
							result = awaiter.GetResult() as CvsCogExpressionGraphic;
							break;
							continue;
							end_IL_006e:
							break;
						}
						goto end_IL_003a;
						IL_0168:
						num2 = (_003C_003E1__state = 0);
						num3 = 10;
						goto IL_006e;
						end_IL_003a:;
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
					if (!VcIqnFsw5ZkbhutTCIkV())
					{
						goto IL_01d9;
					}
					goto case 0;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					break;
				case 1:
				case 2:
					break;
				case 6:
					return;
				}
				cvsCogSocketSheet = _003C_003E4__this;
				num = 4;
			}
			while (true);
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
		internal static bool yYVOKpswoCfNf592KBYV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.IsNullOrEmpty((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MenasqswPqQmYT8qly0P(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogEditInfo)P_0).Url;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool U3iiqwswKG9dOSioDoxu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VcIqnFsw5ZkbhutTCIkV()
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
	private struct _003CGetRowHeightsAsync_003Ed__156 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<int[]> _003C_003Et__builder;

		public CvsCogSocketSheet _003C_003E4__this;

		private ConfiguredTaskAwaitable<long[]>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			string path = default;
			CvsCogSocketSheet cvsCogSocketSheet = default;
			ConfiguredTaskAwaitable<long[]>.ConfiguredTaskAwaiter awaiter = default;
			int[] result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							path = cvsCogSocketSheet.mYH1LMmUb4((string)O7JcPDswOk5ewhRCnIr6(5654));
							_ = 0;
							if (pSWfQsswri9jCwBXsXmu())
							{
								num3 = 2;
							}
							else
							{
								num3 = 7;
								if (1 == 0)
								{
									goto IL_014a;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
						}
						goto IL_00ea;
						IL_00ea:
						while (true)
						{
							switch (num3)
							{
							case 10:
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									continue;
								}
								goto case 7;
							case 3:
								return;
							case 0:
							case 2:
								awaiter = cvsCogSocketSheet.liS1wH05cA().GetAsync<long[]>(path).ConfigureAwait(continueOnCapturedContext: false)
									.GetAwaiter();
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								goto case 7;
							case 7:
							case 8:
							{
								long[] result2 = awaiter.GetResult();
								if (result2 == null)
								{
									num3 = 11;
									if (0 == 0)
									{
										continue;
									}
									goto case 11;
								}
								result = Array.ConvertAll(result2, [MethodImpl(MethodImplOptions.NoInlining)] (long l) =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									return (int)l;
								});
								goto end_IL_00ea;
							}
							case 11:
								result = new int[0];
								num3 = 12;
								if (0 == 0)
								{
									continue;
								}
								goto case 5;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 1;
							case 1:
								num2 = (_003C_003E1__state = -1);
								goto case 7;
							case 6:
								break;
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 5;
								continue;
							case 9:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								continue;
							case 12:
								goto end_IL_00ea;
							}
							goto IL_014a;
							continue;
							end_IL_00ea:
							break;
						}
						goto end_IL_0018;
						IL_014a:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_00ea;
						end_IL_0018:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 4:
					cvsCogSocketSheet = _003C_003E4__this;
					_ = 0;
					num = (pSWfQsswri9jCwBXsXmu() ? 1 : 0);
					break;
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
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
		internal static object O7JcPDswOk5ewhRCnIr6(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pSWfQsswri9jCwBXsXmu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oLNr54sw3ZwqGa6CwXed()
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
	private struct _003CGetColumnWidthsAsync_003Ed__158 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<int[]> _003C_003Et__builder;

		public CvsCogSocketSheet _003C_003E4__this;

		private ConfiguredTaskAwaitable<long[]>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!NYqfRHswQEKZ1e0gYSmA())
			{
				num = 4;
				if (!da4PELswMTL8dmHXiA7H())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_0243;
			IL_002a:
			int[] result = default;
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_0243;
			IL_0243:
			CvsCogSocketSheet cvsCogSocketSheet = default;
			int num2 = default;
			string path = default;
			ConfiguredTaskAwaitable<long[]>.ConfiguredTaskAwaiter awaiter = default;
			ConfiguredTaskAwaitable<long[]> configuredTaskAwaitable = default;
			long[] result2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				case 5:
					cvsCogSocketSheet = _003C_003E4__this;
					goto case 2;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							path = cvsCogSocketSheet.mYH1LMmUb4(kgbOBx7BanbFa22Hp9.ol99ukmDA(5678));
							NYqfRHswQEKZ1e0gYSmA();
							num3 = ((!da4PELswMTL8dmHXiA7H()) ? 5 : 4);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 11;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 4:
								configuredTaskAwaitable = cvsCogSocketSheet.liS1wH05cA().GetAsync<long[]>(path).ConfigureAwait(continueOnCapturedContext: false);
								goto case 1;
							case 1:
							case 5:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								num3 = 8;
								continue;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								goto case 7;
							case 9:
								if (result2 == null)
								{
									result = new int[0];
									num3 = 12;
									if (!NYqfRHswQEKZ1e0gYSmA())
									{
										continue;
									}
									goto case 2;
								}
								result = Array.ConvertAll(result2, [MethodImpl(MethodImplOptions.NoInlining)] (long l) =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									return (int)l;
								});
								break;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								if (true)
								{
									continue;
								}
								return;
							case 3:
								return;
							case 7:
								result2 = awaiter.GetResult();
								num3 = 9;
								continue;
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 10;
								continue;
							case 11:
								num2 = (_003C_003E1__state = -1);
								num3 = 7;
								if (true)
								{
									continue;
								}
								goto case 10;
							case 10:
								_003C_003Eu__1 = awaiter;
								goto case 2;
							default:
								num3 = 2;
								continue;
							case 12:
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
					num = 1;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
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
		internal static bool da4PELswMTL8dmHXiA7H()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NYqfRHswQEKZ1e0gYSmA()
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
	private struct _003CGetCellResultsAsync_003Ed__160 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCogCellResult[]> _003C_003Et__builder;

		public string resultsPath;

		public CvsCogSocketSheet _003C_003E4__this;

		public bool configureAwait;

		private ConfiguredTaskAwaitable<CvsCogCellResult[]>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			CvsCogCellResult[] result = default;
			CvsCogSocketSheet cvsCogSocketSheet = default;
			int num2 = default;
			string path = default;
			ConfiguredTaskAwaitable<CvsCogCellResult[]>.ConfiguredTaskAwaiter awaiter = default;
			ConfiguredTaskAwaitable<CvsCogCellResult[]> configuredTaskAwaitable = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 0:
				case 1:
					cvsCogSocketSheet = _003C_003E4__this;
					num = 2;
					break;
				case 5:
					num2 = _003C_003E1__state;
					bgOafjswe5nCisBLKiPv();
					if (jDWcrOswlsJZUwQYkaYv())
					{
						num = 0;
						break;
					}
					num = 4;
					if (0 == 0)
					{
						break;
					}
					return;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							path = (string)JHIIGEswIK1vY4pyEpP2(resultsPath, Wh68H1swuA1b3eKwmRGg(49796));
							num3 = 5;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
							if (1 == 0)
							{
								goto IL_00ef;
							}
						}
						goto IL_0140;
						IL_01a6:
						result = awaiter.GetResult();
						goto end_IL_0060;
						IL_00ef:
						if (!awaiter.IsCompleted)
						{
							num3 = 9;
							goto IL_0140;
						}
						goto IL_01a6;
						IL_0140:
						while (true)
						{
							switch (num3)
							{
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								goto default;
							default:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 1;
								continue;
							case 6:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								bgOafjswe5nCisBLKiPv();
								if (jDWcrOswlsJZUwQYkaYv())
								{
									num3 = 7;
									continue;
								}
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 5;
							case 1:
								return;
							case 2:
							case 7:
								break;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 0;
								if (0 == 0)
								{
									continue;
								}
								goto case 9;
							case 9:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								goto default;
							case 5:
								configuredTaskAwaitable = cvsCogSocketSheet.liS1wH05cA().GetAsync<CvsCogCellResult[]>(path).ConfigureAwait(configureAwait);
								num3 = 6;
								continue;
							case 10:
								goto IL_01a6;
							}
							break;
						}
						goto IL_00ef;
						end_IL_0060:;
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
		internal static object Wh68H1swuA1b3eKwmRGg(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JHIIGEswIK1vY4pyEpP2(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return K11133Jr1t((string)P_0, (string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jDWcrOswlsJZUwQYkaYv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bgOafjswe5nCisBLKiPv()
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
	private struct _003CRunAsync_003Ed__165 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCogSheetResult> _003C_003Et__builder;

		public CvsCogSocketSheet _003C_003E4__this;

		public bool fireSheetUpdated;

		private ConfiguredTaskAwaitable<CvsCogSheetResult>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			string path = default;
			CvsCogSocketSheet cvsCogSocketSheet = default;
			ConfiguredTaskAwaitable<CvsCogSheetResult>.ConfiguredTaskAwaiter awaiter = default;
			CvsCogSheetResult result2 = default;
			CvsCogSheetResult result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					num2 = _003C_003E1__state;
					num = 4;
					break;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							path = cvsCogSocketSheet.mYH1LMmUb4((string)tfGGPHswnRrFcyxdcmCH(5744));
							num3 = 8;
							goto IL_017f;
						}
						awaiter = _003C_003Eu__1;
						goto IL_004a;
						IL_004a:
						_003C_003Eu__1 = default;
						num3 = 9;
						goto IL_017f;
						IL_017f:
						while (true)
						{
							switch (num3)
							{
							case 10:
								break;
							case 6:
								cvsCogSocketSheet.FireSheetUpdated();
								num3 = 14;
								continue;
							case 7:
								if (!awaiter.IsCompleted)
								{
									_ = 1;
									num3 = ((!HaC0csswaVbXuH8YhokT()) ? 1 : 12);
									continue;
								}
								goto case 3;
							case 1:
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								continue;
							case 11:
								cvsCogSocketSheet.dGX15IHsAv(result2, null);
								num3 = 5;
								if (true)
								{
									continue;
								}
								goto case 9;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 3;
								continue;
							case 0:
								_003C_003Eu__1 = awaiter;
								goto case 4;
							case 8:
							{
								Dictionary<string, object> dictionary = new Dictionary<string, object>();
								awaiter = cvsCogSocketSheet.liS1wH05cA().PostAsync<CvsCogSheetResult>(path, new object[1] { dictionary }).ConfigureAwait(continueOnCapturedContext: false)
									.GetAwaiter();
								num3 = 7;
								continue;
							}
							case 5:
								if (fireSheetUpdated)
								{
									num3 = 6;
									continue;
								}
								goto case 14;
							case 3:
								result2 = awaiter.GetResult();
								num3 = 11;
								continue;
							case 4:
							case 12:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 13;
								continue;
							case 13:
								return;
							default:
								num3 = 10;
								continue;
							case 14:
								result = result2;
								goto end_IL_017f;
							}
							goto IL_004a;
							continue;
							end_IL_017f:
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
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 4:
					cvsCogSocketSheet = _003C_003E4__this;
					DDjuGjswRaN4KXrilk9b();
					num = ((!HaC0csswaVbXuH8YhokT()) ? 1 : 5);
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
		internal static object tfGGPHswnRrFcyxdcmCH(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DDjuGjswRaN4KXrilk9b()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HaC0csswaVbXuH8YhokT()
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
	private struct _003CRunAsync_003Ed__166 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCogSheetResult> _003C_003Et__builder;

		public string sheetName;

		public CvsCogSocketSheet _003C_003E4__this;

		private ConfiguredTaskAwaitable<CvsCogSheetResult>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			string path = default;
			ConfiguredTaskAwaitable<CvsCogSheetResult>.ConfiguredTaskAwaiter awaiter = default;
			CvsCogSocketSheet cvsCogSocketSheet = default;
			ConfiguredTaskAwaitable<CvsCogSheetResult> configuredTaskAwaitable = default;
			Dictionary<string, object> dictionary = default;
			CvsCogSheetResult result = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					nUXNwYswG6C1FmDLm9L6();
					num = (o1L7uiswXJuDY4SnLWfn() ? 5 : 3);
					break;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							path = null;
							o1L7uiswXJuDY4SnLWfn();
							if (nUXNwYswG6C1FmDLm9L6())
							{
								num3 = 5;
								if (1 == 0)
								{
									goto IL_005d;
								}
							}
							else
							{
								num3 = 8;
								if (!nUXNwYswG6C1FmDLm9L6())
								{
									goto IL_0188;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 13;
						}
						goto IL_00af;
						IL_005d:
						path = cvsCogSocketSheet.nYs1k3egjd(sheetName, (string)u7mMXDswbioZOsqm5fno(5744));
						num3 = 11;
						goto IL_00af;
						IL_00af:
						while (true)
						{
							switch (num3)
							{
							case 12:
								break;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									continue;
								}
								goto case 13;
							case 9:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								goto case 7;
							default:
								num3 = 7;
								continue;
							case 3:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								continue;
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 1:
								configuredTaskAwaitable = cvsCogSocketSheet.liS1wH05cA().PostAsync<CvsCogSheetResult>(path, new object[1] { dictionary }).ConfigureAwait(continueOnCapturedContext: false);
								num3 = 9;
								continue;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 10:
								return;
							case 2:
							case 11:
								goto IL_0188;
							case 0:
							case 5:
								goto IL_0199;
							case 8:
								return;
							case 13:
								result = awaiter.GetResult();
								goto end_IL_0039;
							}
							break;
							IL_0199:
							if (sheetName == null)
							{
								path = cvsCogSocketSheet.mYH1LMmUb4(kgbOBx7BanbFa22Hp9.ol99ukmDA(5744));
								num3 = 2;
							}
							else
							{
								num3 = 12;
							}
						}
						goto IL_005d;
						IL_0188:
						dictionary = new Dictionary<string, object>();
						num3 = 1;
						goto IL_00af;
						end_IL_0039:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 0;
				default:
					num = 0;
					if (nUXNwYswG6C1FmDLm9L6())
					{
						break;
					}
					goto case 0;
				case 0:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (nUXNwYswG6C1FmDLm9L6())
					{
						break;
					}
					goto case 1;
				case 1:
				case 3:
					cvsCogSocketSheet = _003C_003E4__this;
					goto case 2;
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
		internal static object u7mMXDswbioZOsqm5fno(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nUXNwYswG6C1FmDLm9L6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool o1L7uiswXJuDY4SnLWfn()
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
	private struct _003CRunAndGetCellResults_003Ed__167 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCellCollection> _003C_003Et__builder;

		public CvsCogSocketSheet _003C_003E4__this;

		public Dictionary<string, object> inputs;

		private ConfiguredTaskAwaitable<CvsCogSheetResult>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_02a1;
			IL_001a:
			int num2 = default;
			CvsCogSocketSheet cvsCogSocketSheet = default;
			CvsCellCollection result = default;
			try
			{
				int num3;
				TaskAwaiter<CvsCellCollection> awaiter = default;
				ConfiguredTaskAwaitable<CvsCogSheetResult>.ConfiguredTaskAwaiter awaiter2 = default;
				if (num2 != 0)
				{
					if (num2 != 1)
					{
						num3 = 11;
					}
					else
					{
						awaiter = _003C_003Eu__2;
						num3 = 2;
						if (!S3Mva6sw6FBg5lxZdgDr())
						{
							goto IL_022a;
						}
					}
				}
				else
				{
					awaiter2 = _003C_003Eu__1;
					num3 = 3;
				}
				goto IL_00c8;
				IL_00c8:
				string path = default;
				while (true)
				{
					switch (num3)
					{
					case 6:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					case 15:
						inputs = new Dictionary<string, object>();
						num3 = 9;
						if (S3Mva6sw6FBg5lxZdgDr())
						{
							continue;
						}
						goto case 0;
					case 0:
						_003C_003Eu__1 = awaiter2;
						num3 = 6;
						continue;
					case 11:
						break;
					case 3:
						_003C_003Eu__1 = default;
						goto case 4;
					default:
						num3 = 4;
						continue;
					case 9:
						awaiter2 = cvsCogSocketSheet.liS1wH05cA().PostAsync<CvsCogSheetResult>(path, new object[1] { inputs }).ConfigureAwait(continueOnCapturedContext: false)
							.GetAwaiter();
						num3 = 8;
						if (true)
						{
							continue;
						}
						goto case 17;
					case 17:
						num2 = (_003C_003E1__state = 1);
						goto case 12;
					case 2:
						_003C_003Eu__2 = default;
						num3 = 5;
						continue;
					case 4:
						num2 = (_003C_003E1__state = -1);
						goto IL_0193;
					case 7:
						awaiter = cvsCogSocketSheet.GetCellResults().GetAwaiter();
						num3 = 14;
						if (S3Mva6sw6FBg5lxZdgDr())
						{
							continue;
						}
						goto case 12;
					case 12:
					case 13:
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 16;
						continue;
					case 14:
						if (!awaiter.IsCompleted)
						{
							num3 = 17;
							if (true)
							{
								continue;
							}
							goto case 5;
						}
						goto case 18;
					case 5:
						num2 = (_003C_003E1__state = -1);
						num3 = 18;
						continue;
					case 16:
						return;
					case 8:
						goto end_IL_00c8;
					case 1:
					case 10:
						if (inputs == null)
						{
							num3 = 15;
							continue;
						}
						goto case 9;
					case 18:
						result = awaiter.GetResult();
						goto end_IL_001a;
					}
					path = cvsCogSocketSheet.mYH1LMmUb4(kgbOBx7BanbFa22Hp9.ol99ukmDA(5744));
					_ = 0;
					num3 = ((!S3Mva6sw6FBg5lxZdgDr()) ? 13 : 10);
					continue;
					end_IL_00c8:
					break;
				}
				goto IL_022a;
				IL_0193:
				awaiter2.GetResult();
				num3 = 7;
				goto IL_00c8;
				IL_022a:
				if (!awaiter2.IsCompleted)
				{
					num2 = (_003C_003E1__state = 0);
					num3 = 0;
					goto IL_00c8;
				}
				goto IL_0193;
				end_IL_001a:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_02d2;
			IL_02a1:
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				default:
					goto IL_02d2;
				case 4:
					goto IL_02e8;
				case 0:
				case 1:
					cvsCogSocketSheet = _003C_003E4__this;
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
				IL_02e8:
				num2 = _003C_003E1__state;
				S3Mva6sw6FBg5lxZdgDr();
				num = (rc83mKswpl2vcOAYo8NI() ? 2 : 0);
			}
			goto IL_001a;
			IL_02d2:
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_02a1;
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
		internal static bool S3Mva6sw6FBg5lxZdgDr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rc83mKswpl2vcOAYo8NI()
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
	private struct _003CGetCellResults_003Ed__168 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCellCollection> _003C_003Et__builder;

		public CvsCogSocketSheet _003C_003E4__this;

		private CvsCellCollection _003Ccollection_003E5__2;

		private TaskAwaiter<CvsCogCellResult[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			CvsCogSocketSheet cvsCogSocketSheet = default;
			CvsCellCollection result2 = default;
			int num2 = default;
			TaskAwaiter<CvsCogCellResult[]> awaiter = default;
			CvsCogCellResult[] result = default;
			string path = default;
			int num4 = default;
			CvsCell cvsCell = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					cvsCogSocketSheet = _003C_003E4__this;
					_ = 0;
					num = (SUg5jAsw00AAAV0d8hRE() ? 6 : 0);
					break;
				default:
					_003Ccollection_003E5__2 = null;
					num = 4;
					if (true)
					{
						break;
					}
					goto case 4;
				case 4:
					_003C_003Et__builder.SetResult(result2);
					num = 7;
					break;
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					break;
				case 2:
				case 6:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Ccollection_003E5__2 = new CvsCellCollection();
							num3 = 2;
							goto IL_00ee;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00c7;
						IL_00c7:
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_0217;
						IL_0217:
						result = awaiter.GetResult();
						num3 = 13;
						goto IL_00ee;
						IL_00ee:
						while (true)
						{
							switch (num3)
							{
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								if (0 == 0)
								{
									continue;
								}
								goto case 4;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								SUg5jAsw00AAAV0d8hRE();
								if (!zSM5Lesw4eb7WE4b2c0s())
								{
									num3 = 12;
									continue;
								}
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 13;
							case 6:
							case 9:
								break;
							default:
								num3 = 10;
								if (true)
								{
									continue;
								}
								goto case 11;
							case 11:
								awaiter = cvsCogSocketSheet.liS1wH05cA().GetAsync<CvsCogCellResult[]>(path).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto IL_0217;
							case 5:
							case 12:
								return;
							case 13:
								num4 = 0;
								num3 = 14;
								continue;
							case 8:
								if (cvsCell != null)
								{
									num3 = 7;
									continue;
								}
								goto case 0;
							case 2:
								path = K11133Jr1t((string)v55HbgswkfMHpwDPeVM6(cvsCogSocketSheet.e201DwB526), (string)x5WtKYswfUY15pR5xiZ5(49822));
								num3 = 11;
								continue;
							case 7:
								gv7HE2swF9AFEWSFYIcf(_003Ccollection_003E5__2, cvsCell);
								num3 = 0;
								continue;
							case 0:
								num4++;
								goto case 14;
							case 14:
								if (num4 < result.Length)
								{
									cvsCell = CvsCell.CreateNewCell(result[num4]);
									num3 = 8;
								}
								else
								{
									num3 = 15;
								}
								continue;
							case 10:
								goto IL_0217;
							case 1:
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto case 15;
							case 15:
								result2 = _003Ccollection_003E5__2;
								goto end_IL_006f;
							}
							break;
						}
						goto IL_00c7;
						end_IL_006f:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Ccollection_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 7:
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
		internal static object v55HbgswkfMHpwDPeVM6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ResourceNode)P_0).RootResourceUri;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object x5WtKYswfUY15pR5xiZ5(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gv7HE2swF9AFEWSFYIcf(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsCellCollection)P_0).StoreItem((CvsCell)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SUg5jAsw00AAAV0d8hRE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zSM5Lesw4eb7WE4b2c0s()
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
	private struct _003CRunAsync_003Ed__169 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCogSheetResult> _003C_003Et__builder;

		public CvsCogSocketSheet _003C_003E4__this;

		public Dictionary<string, object> inputs;

		public bool fireSheetUpdated;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			string path = default;
			CvsCogSocketSheet cvsCogSocketSheet = default;
			TaskAwaiter<CvsCogSheetResult> awaiter = default;
			CvsCogSheetResult result2 = default;
			CvsCogSheetResult result = default;
			do
			{
				IL_01dc:
				switch (num)
				{
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							path = cvsCogSocketSheet.mYH1LMmUb4((string)jZjSqVswgHPtBa6sesak(5744));
							num3 = 7;
							if (pRjAYHswy0UVADL41Jrt())
							{
							}
							goto IL_00a4;
						}
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						goto IL_00e7;
						IL_00e7:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_00a4;
						IL_00a4:
						while (true)
						{
							switch (num3)
							{
							case 7:
								awaiter = cvsCogSocketSheet.liS1wH05cA().PostAsync<CvsCogSheetResult>(path, new object[1] { inputs }).GetAwaiter();
								num3 = 8;
								continue;
							case 1:
								if (fireSheetUpdated)
								{
									num3 = 10;
									continue;
								}
								goto case 12;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 4;
								continue;
							case 6:
							case 11:
								break;
							case 3:
								_003C_003Eu__1 = awaiter;
								num3 = 5;
								continue;
							case 9:
								result2 = awaiter.GetResult();
								cvsCogSocketSheet.dGX15IHsAv(result2, null);
								num3 = 1;
								if (!pRjAYHswy0UVADL41Jrt())
								{
									continue;
								}
								goto case 10;
							case 10:
								cvsCogSocketSheet.FireSheetUpdated();
								num3 = 12;
								continue;
							case 8:
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									num3 = ((!tZk1XJswmEFReqhw3Ucg()) ? 11 : 0);
									continue;
								}
								goto case 9;
							case 0:
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 3;
								continue;
							case 4:
								return;
							case 12:
								result = result2;
								goto end_IL_00a4;
							}
							goto IL_00e7;
							continue;
							end_IL_00a4:
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
				case 5:
					num2 = _003C_003E1__state;
					num = 0;
					if (true)
					{
						goto IL_01dc;
					}
					goto case 0;
				case 0:
					cvsCogSocketSheet = _003C_003E4__this;
					_ = 0;
					num = (tZk1XJswmEFReqhw3Ucg() ? 1 : 4);
					goto IL_01dc;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult(result);
				num = 6;
			}
			while (tZk1XJswmEFReqhw3Ucg());
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
		internal static object jZjSqVswgHPtBa6sesak(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tZk1XJswmEFReqhw3Ucg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pRjAYHswy0UVADL41Jrt()
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
	private struct _003CQueryCells_003Ed__171 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IEnumerable<IDictionary<string, object>>> _003C_003Et__builder;

		public CvsCogSocketSheet _003C_003E4__this;

		public string filter;

		public IEnumerable<string> fields;

		private TaskAwaiter<object[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			CvsCogSocketSheet cvsCogSocketSheet = default;
			IEnumerable<IDictionary<string, object>> result = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					cvsCogSocketSheet = _003C_003E4__this;
					_ = 0;
					if (Ab7vIoswZVPJOMELKDbx())
					{
						num = 0;
						if (true)
						{
							break;
						}
						goto default;
					}
					num = 1;
					if (JxqIImswJPogk4WHJ1UR())
					{
						return;
					}
					break;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				case 0:
				case 2:
					try
					{
						TaskAwaiter<object[]> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = cvsCogSocketSheet.e201DwB526.PostAsync<object[]>((string)txg9b0sw8rwKJMfna74Y(5754), new object[3]
							{
								"",
								filter,
								fields.JoinToString((string)txg9b0sw8rwKJMfna74Y(7604))
							}).GetAwaiter();
							num3 = 0;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
							if (JxqIImswJPogk4WHJ1UR())
							{
								goto IL_0118;
							}
						}
						goto IL_0167;
						IL_0118:
						num2 = (_003C_003E1__state = 0);
						num3 = 2;
						goto IL_0167;
						IL_0167:
						while (true)
						{
							switch (num3)
							{
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 1;
								if (0 == 0)
								{
									continue;
								}
								goto case 7;
							case 7:
								_003C_003Eu__1 = default;
								goto case 3;
							case 3:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 4:
							case 8:
								return;
							case 5:
								break;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									if (!JxqIImswJPogk4WHJ1UR())
									{
										continue;
									}
									goto case 1;
								}
								goto case 9;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								JxqIImswJPogk4WHJ1UR();
								num3 = (Ab7vIoswZVPJOMELKDbx() ? 8 : 3);
								continue;
							case 9:
								result = awaiter.GetResult().Cast<IDictionary<string, object>>();
								goto end_IL_0167;
							}
							goto IL_0118;
							continue;
							end_IL_0167:
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
		internal static object txg9b0sw8rwKJMfna74Y(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ab7vIoswZVPJOMELKDbx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JxqIImswJPogk4WHJ1UR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CvsCogSocket Ifd1QSV4YZ;

	private readonly string YXs1NTY3sP;

	private string w2E1iCFTn1;

	private Dictionary<string, object> x7J1dOJCsh;

	private CvsCogSheetResult Oui1udGASq;

	private CvsCogCellResult[] CDU1GabpLY;

	private readonly ResourceNode e201DwB526;

	private ResourceNode JFU1edjXaj;

	private static bool D2q1SCyyKt;

	private static int iCq1r83ucb;

	private static readonly TimeSpan Gfg1Ca2CVo;

	private static StreamLogger UCi12Xf2ZY;

	[CompilerGenerated]
	private SheetUpdatedEventHandler qLB1yd5DIw;

	[CompilerGenerated]
	private EventHandler b2t1VmBnmo;

	[CompilerGenerated]
	private string uRe1vbNP45;

	private string C6K1Zy1k0C;

	[CompilerGenerated]
	private EventHandler GTP189hBGp;

	private object aHr1zLgY1R;

	[CompilerGenerated]
	private OcrMaxAutoTuneModelDataCache QQGxPMksU3;

	public static int HttpArchiveTimeout
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iCq1r83ucb;
		}
	}

	public ResourceNode SheetResourceNode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return e201DwB526;
		}
	}

	public ResourceNode PropertySheetResourceNode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return JFU1edjXaj;
		}
	}

	public string Path
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(3810) + YXs1NTY3sP + kgbOBx7BanbFa22Hp9.ol99ukmDA(3810);
		}
	}

	IRemoteDeviceApi IResourceUriProvider.DeviceApi
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (IRemoteDeviceApi)uGxBGwSDtCV1ZBkJa4w(Ifd1QSV4YZ);
		}
	}

	string IResourceUriProvider.RootResourceUri
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Dci1sVvgC9();
		}
	}

	public bool HasSheet
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return !L4OrV6SUarjyrkjSaQ9(ID);
		}
	}

	public string ID
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return w2E1iCFTn1;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			m7TVpcSSwGRe6I95cos();
			int num = ((!gAebkiS9yt8lx8b0s4E()) ? 2 : 4);
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					CkA1cse5HI(value);
					goto case 3;
				default:
					num = 3;
					if (gAebkiS9yt8lx8b0s4E())
					{
						break;
					}
					goto case 3;
				case 3:
					RIW1nawRDo();
					num = 5;
					break;
				case 0:
				case 4:
					if (Fvae6DSjXNGvionHDSS(w2E1iCFTn1, value))
					{
						goto case 1;
					}
					return;
				case 5:
					return;
				}
			}
		}
	}

	public string SimpleSheetName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return uRe1vbNP45;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			uRe1vbNP45 = value;
		}
	}

	public string SheetBlockName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return C6K1Zy1k0C;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = (gAebkiS9yt8lx8b0s4E() ? 1 : 3);
			while (true)
			{
				switch (num)
				{
				default:
					ID = (string)fCoTXiS27if5Teomdgm(C6K1Zy1k0C);
					num = 5;
					break;
				case 0:
				case 1:
					C6K1Zy1k0C = value;
					num = 4;
					break;
				case 4:
					SimpleSheetName = (string)UTVqZ9ScebOhtr0I8Lw(C6K1Zy1k0C);
					goto default;
				case 5:
					return;
				}
			}
		}
	}

	public CvsCogSheetResult LastSheetResult
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
			if (gAebkiS9yt8lx8b0s4E())
			{
				num = 3;
			}
			else
			{
				num = 2;
				if (false)
				{
					goto IL_0074;
				}
			}
			bool lockTaken = default;
			object obj = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					lockTaken = false;
					break;
				default:
					goto IL_0051;
				case 0:
				case 3:
					obj = aHr1zLgY1R;
					goto case 1;
				case 4:
					break;
				}
				break;
				IL_0051:
				num = 4;
			}
			goto IL_0074;
			IL_0074:
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				return Oui1udGASq;
			}
			finally
			{
				if (lockTaken)
				{
					QELM33S5TniDZwp3vCp(obj);
				}
			}
		}
	}

	public CvsCogCellResult[] LastCellResults
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CDU1GabpLY;
		}
	}

	public OcrMaxAutoTuneModelDataCache AutoTuneModelDataCache
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return QQGxPMksU3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QQGxPMksU3 = value;
		}
	}

	public event SheetUpdatedEventHandler SheetUpdated
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (m7TVpcSSwGRe6I95cos() ? 4 : 6);
			SheetUpdatedEventHandler value2 = default;
			SheetUpdatedEventHandler sheetUpdatedEventHandler2 = default;
			SheetUpdatedEventHandler sheetUpdatedEventHandler = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					value2 = (SheetUpdatedEventHandler)oO3xjCSqjDB6CsMpvpK(sheetUpdatedEventHandler2, value);
					break;
				default:
					num = 2;
					continue;
				case 5:
					if ((object)sheetUpdatedEventHandler == sheetUpdatedEventHandler2)
					{
						num = 7;
						continue;
					}
					goto case 1;
				case 1:
				case 4:
					sheetUpdatedEventHandler2 = sheetUpdatedEventHandler;
					num = 3;
					continue;
				case 2:
					break;
				case 0:
				case 6:
					sheetUpdatedEventHandler = qLB1yd5DIw;
					goto case 1;
				case 7:
					return;
				}
				sheetUpdatedEventHandler = Interlocked.CompareExchange(ref qLB1yd5DIw, value2, sheetUpdatedEventHandler2);
				num = 5;
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			SheetUpdatedEventHandler sheetUpdatedEventHandler2 = default;
			SheetUpdatedEventHandler value2 = default;
			SheetUpdatedEventHandler sheetUpdatedEventHandler = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					sheetUpdatedEventHandler2 = Interlocked.CompareExchange(ref qLB1yd5DIw, value2, sheetUpdatedEventHandler);
					goto case 4;
				case 1:
					sheetUpdatedEventHandler2 = qLB1yd5DIw;
					num = 6;
					if (gAebkiS9yt8lx8b0s4E())
					{
						break;
					}
					goto case 6;
				case 6:
					sheetUpdatedEventHandler = sheetUpdatedEventHandler2;
					num = 2;
					break;
				case 2:
					value2 = (SheetUpdatedEventHandler)Dr1EttSBfx3bNt0eHSG(sheetUpdatedEventHandler, value);
					goto default;
				default:
					m7TVpcSSwGRe6I95cos();
					if (!gAebkiS9yt8lx8b0s4E())
					{
						num = 5;
						if (0 == 0)
						{
							break;
						}
						goto case 1;
					}
					num = 0;
					break;
				case 4:
				case 5:
					if ((object)sheetUpdatedEventHandler2 == sheetUpdatedEventHandler)
					{
						num = 7;
						if (m7TVpcSSwGRe6I95cos())
						{
						}
						break;
					}
					goto case 6;
				case 7:
					return;
				}
			}
		}
	}

	public event EventHandler SheetIDChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!gAebkiS9yt8lx8b0s4E()) ? 5 : 4);
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					eventHandler = Interlocked.CompareExchange(ref b2t1VmBnmo, value2, eventHandler2);
					num = 6;
					continue;
				case 6:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						continue;
					}
					break;
				case 3:
					value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					goto case 2;
				default:
					num = 2;
					if (!m7TVpcSSwGRe6I95cos())
					{
						continue;
					}
					break;
				case 1:
				case 5:
					break;
				case 0:
				case 4:
					eventHandler = b2t1VmBnmo;
					break;
				case 7:
					return;
				}
				eventHandler2 = eventHandler;
				num = 3;
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					eventHandler = b2t1VmBnmo;
					_ = 0;
					if (gAebkiS9yt8lx8b0s4E())
					{
						num = 5;
						if (m7TVpcSSwGRe6I95cos())
						{
						}
					}
					else
					{
						num = 0;
					}
					continue;
				case 0:
				case 2:
					value2 = (EventHandler)Dr1EttSBfx3bNt0eHSG(eventHandler2, value);
					break;
				default:
					num = 6;
					continue;
				case 1:
				case 5:
					eventHandler2 = eventHandler;
					goto case 0;
				case 3:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						if (0 == 0)
						{
							continue;
						}
						break;
					}
					goto case 1;
				case 6:
					break;
				case 7:
					return;
				}
				eventHandler = Interlocked.CompareExchange(ref b2t1VmBnmo, value2, eventHandler2);
				num = 3;
			}
		}
	}

	public event EventHandler IdOutOfOrder
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!m7TVpcSSwGRe6I95cos())
			{
				num = 1;
				if (m7TVpcSSwGRe6I95cos())
				{
				}
			}
			else
			{
				num = 3;
			}
			EventHandler eventHandler2 = default;
			EventHandler value2 = default;
			EventHandler eventHandler = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					eventHandler2 = GTP189hBGp;
					num = 2;
					continue;
				case 6:
					value2 = (EventHandler)oO3xjCSqjDB6CsMpvpK(eventHandler, value);
					goto case 5;
				default:
					num = 5;
					continue;
				case 3:
				case 4:
					if ((object)eventHandler2 == eventHandler)
					{
						num = 7;
						continue;
					}
					break;
				case 2:
					break;
				case 5:
					eventHandler2 = Interlocked.CompareExchange(ref GTP189hBGp, value2, eventHandler);
					goto case 3;
				case 7:
					return;
				}
				eventHandler = eventHandler2;
				num = 6;
			}
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					eventHandler = Interlocked.CompareExchange(ref GTP189hBGp, value2, eventHandler2);
					goto case 4;
				case 6:
					eventHandler = GTP189hBGp;
					num = 1;
					if (gAebkiS9yt8lx8b0s4E())
					{
						continue;
					}
					goto case 4;
				case 4:
				case 5:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						continue;
					}
					goto case 1;
				case 1:
					eventHandler2 = eventHandler;
					num = 2;
					if (gAebkiS9yt8lx8b0s4E())
					{
						continue;
					}
					goto case 2;
				case 2:
					value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					break;
				case 7:
					return;
				}
				gAebkiS9yt8lx8b0s4E();
				num = (m7TVpcSSwGRe6I95cos() ? 5 : 0);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsCogSocketSheet()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (m7TVpcSSwGRe6I95cos())
		{
			goto IL_001e;
		}
		goto IL_00c2;
		IL_001e:
		UCi12Xf2ZY = new StreamLogger((string)udHk4CSH53pRfEolLvn(3648), (string)udHk4CSH53pRfEolLvn(3682));
		goto IL_00f9;
		IL_00c2:
		bool value = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 4:
				D2q1SCyyKt = value;
				num = 9;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
				iCq1r83ucb = 30000;
				num = 7;
				continue;
			case 1:
			case 3:
				D2q1SCyyKt = true;
				num = 0;
				continue;
			case 2:
				goto IL_0082;
			case 7:
				Gfg1Ca2CVo = jsqomWSvBWjNdFwu3yL(270.0);
				break;
			default:
				num = 6;
				continue;
			case 5:
			case 8:
				goto IL_00f9;
			case 9:
				return;
			}
			break;
			IL_0082:
			bl2mK7SEWwVFjRLahlc();
			_ = 0;
			num = (gAebkiS9yt8lx8b0s4E() ? 3 : 8);
		}
		goto IL_001e;
		IL_00f9:
		if (AppConfiguration.TryGet<bool>((string)udHk4CSH53pRfEolLvn(3704), out value))
		{
			num = 4;
			if (!gAebkiS9yt8lx8b0s4E())
			{
				return;
			}
			goto IL_00c2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogSocketSheet(CvsCogSocket cogSocket, string sheetPath)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_00ca;
		IL_001a:
		w2E1iCFTn1 = string.Empty;
		num = 10;
		goto IL_00ca;
		IL_00ca:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 2:
				bl2mK7SEWwVFjRLahlc();
				num = 1;
				continue;
			case 3:
			case 6:
				e201DwB526 = new ResourceNode(this, "");
				num = 7;
				if (true)
				{
					continue;
				}
				goto case 9;
			case 9:
				QxAWJfSVo7Ia5eo8mhy(this);
				num = 8;
				if (!m7TVpcSSwGRe6I95cos())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 5:
				YXs1NTY3sP = sheetPath;
				goto case 3;
			case 7:
				JFU1edjXaj = (ResourceNode)IIvLtuSADOdFFLHQt1n(e201DwB526, udHk4CSH53pRfEolLvn(3780));
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 8;
			case 8:
				Ifd1QSV4YZ = cogSocket;
				goto default;
			default:
				_ = 0;
				if (!gAebkiS9yt8lx8b0s4E())
				{
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					goto case 7;
				}
				num = 0;
				if (!m7TVpcSSwGRe6I95cos())
				{
					continue;
				}
				goto case 4;
			case 4:
				AutoTuneModelDataCache = new OcrMaxAutoTuneModelDataCache(this);
				num = 11;
				continue;
			case 10:
				aHr1zLgY1R = new object();
				num = 9;
				continue;
			case 11:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private IRemoteDeviceApi liS1wH05cA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (IRemoteDeviceApi)uGxBGwSDtCV1ZBkJa4w(Ifd1QSV4YZ);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private string Dci1sVvgC9()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!L4OrV6SUarjyrkjSaQ9(ID))
		{
			return (string)TVvlcfSTWdHgmKmt9y1(udHk4CSH53pRfEolLvn(3816), Path, w2E1iCFTn1);
		}
		return (string)Rweil4SdfCApswyqiEW(Path, udHk4CSH53pRfEolLvn(3856));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string VdD1WraZFp(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)TVvlcfSTWdHgmKmt9y1(udHk4CSH53pRfEolLvn(3816), Path, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string K11133Jr1t(string P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!P_0.EndsWith((string)udHk4CSH53pRfEolLvn(3810)))
		{
			P_0 = (string)Rweil4SdfCApswyqiEW(P_0, kgbOBx7BanbFa22Hp9.ol99ukmDA(3810));
		}
		return string.Format((string)udHk4CSH53pRfEolLvn(3880), P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string mYH1LMmUb4(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)TVvlcfSTWdHgmKmt9y1(udHk4CSH53pRfEolLvn(3880), Dci1sVvgC9(), P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string nYs1k3egjd(string P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format(kgbOBx7BanbFa22Hp9.ol99ukmDA(3880), VdD1WraZFp(P_0), P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string v1f1Xb2PMu(CvsCellLocation P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)Rji9n9Si8Wfh6aykV20(udHk4CSH53pRfEolLvn(3896), Dci1sVvgC9(), P_0.ToString(), P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string s1C1fTTNL7(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		int num2 = default;
		string result = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				num2 = sM9Mt3SWPJ1E71ZrZiE(P_0, '.');
				m7TVpcSSwGRe6I95cos();
				num = ((!gAebkiS9yt8lx8b0s4E()) ? 4 : 6);
				continue;
			case 1:
				result = (string)bNepPpSt4oBgwU2l46I(P_0, num2 + 1);
				num = 7;
				continue;
			case 0:
				result = P_0;
				num = 5;
				if (gAebkiS9yt8lx8b0s4E())
				{
					continue;
				}
				goto case 2;
			case 2:
			case 6:
				if (num2 <= 0)
				{
					break;
				}
				goto default;
			default:
				if (num2 + 1 <= IC8kj6S7IQ8bhsL5nTt(P_0))
				{
					num = 1;
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
	private static string vnN1jtafFq(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)Oc1ZFKSCrkRbOHR5kPS(P_0, '.', '_');
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CkA1cse5HI(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (gAebkiS9yt8lx8b0s4E())
		{
			num = 4;
			if (!gAebkiS9yt8lx8b0s4E())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_0097;
		IL_00c2:
		w2E1iCFTn1 = P_0;
		num = 5;
		goto IL_0097;
		IL_0097:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				break;
			case 2:
				dGX15IHsAv(null, null);
				num = 6;
				continue;
			case 5:
				x7J1dOJCsh = null;
				goto case 2;
			default:
				num = 2;
				continue;
			case 1:
			case 3:
				goto IL_00c2;
			case 6:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		W4UWFSSKnxCRCZg55wq(CvsTraceSDK.Info, udHk4CSH53pRfEolLvn(2062), new object[2]
		{
			u5B19sM6Gn((string)udHk4CSH53pRfEolLvn(3932)),
			P_0
		});
		goto IL_00c2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int dGX15IHsAv(CvsCogSheetResult P_0, CvsCogCellResult[] P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!gAebkiS9yt8lx8b0s4E()) ? 2 : 3);
		object obj = default;
		bool lockTaken = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				obj = aHr1zLgY1R;
				goto case 1;
			case 1:
			case 2:
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
		int result = default;
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			gAebkiS9yt8lx8b0s4E();
			int num2 = (m7TVpcSSwGRe6I95cos() ? 8 : 5);
			while (true)
			{
				switch (num2)
				{
				case 2:
				case 8:
					if (kqIrbESo0n7OYRU9Y98(P_0) < Oui1udGASq.Id)
					{
						num2 = 1;
						continue;
					}
					if (kqIrbESo0n7OYRU9Y98(P_0) == kqIrbESo0n7OYRU9Y98(Oui1udGASq))
					{
						goto case 11;
					}
					Oui1udGASq = P_0;
					CDU1GabpLY = P_1;
					num2 = 6;
					if (0 == 0)
					{
						continue;
					}
					goto case 1;
				case 10:
					break;
				default:
					num2 = 11;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 5:
					if (Oui1udGASq != null)
					{
						num2 = 9;
						continue;
					}
					goto IL_0196;
				case 7:
					CDU1GabpLY = P_1;
					goto IL_0142;
				case 4:
					break;
				case 1:
					result = -1;
					num2 = 10;
					continue;
				case 9:
					if (P_0 != null)
					{
						goto case 2;
					}
					goto IL_0196;
				case 11:
					if (P_1 != null)
					{
						num2 = 7;
						continue;
					}
					goto IL_0142;
				case 3:
					CDU1GabpLY = P_1;
					num2 = 12;
					if (m7TVpcSSwGRe6I95cos())
					{
					}
					continue;
				case 6:
				case 12:
					{
						result = 1;
						break;
					}
					IL_0196:
					Oui1udGASq = P_0;
					num2 = 3;
					if (m7TVpcSSwGRe6I95cos())
					{
					}
					continue;
					IL_0142:
					result = 0;
					num2 = 4;
					if (0 == 0)
					{
						continue;
					}
					break;
				}
				break;
			}
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(obj);
			}
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateSheetResult(string url)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCogSheetResult result = liS1wH05cA().GetAsync<CvsCogSheetResult>(url).Result;
		UpdateSheetResult(result);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateSheetResult(CvsCogSheetResult sheetResult)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		while (true)
		{
			IL_0031:
			switch (num)
			{
			case 1:
			case 3:
				FireSheetUpdated();
				break;
			case 4:
				while (true)
				{
					dGX15IHsAv(sheetResult, null);
					_ = 0;
					if (gAebkiS9yt8lx8b0s4E())
					{
						break;
					}
					num = 0;
					if (!m7TVpcSSwGRe6I95cos())
					{
						goto IL_0031;
					}
				}
				num = 3;
				if (true)
				{
					continue;
				}
				break;
			case 5:
				return;
			}
			Ifd1QSV4YZ.WaitForResultBuildComplete();
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateSheetResult(CvsCogSessionResult sessionResult)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		m7TVpcSSwGRe6I95cos();
		int num = (gAebkiS9yt8lx8b0s4E() ? 1 : 3);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
			{
				int num2 = dGX15IHsAv((CvsCogSheetResult)BXACHgSPYSahhysn9X9(sessionResult), (CvsCogCellResult[])PWdmCWSYvBS3Ion7pgZ(sessionResult.CellResults));
				if (num2 <= 0)
				{
					EventHandler eventHandler = GTP189hBGp;
					if (eventHandler != null)
					{
						rhuyf0SNYgyBNiGxve0(eventHandler, this, EventArgs.Empty);
					}
				}
				if (num2 >= 0)
				{
					num = 4;
					continue;
				}
				return;
			}
			case 4:
				FireSheetUpdated();
				break;
			case 5:
				return;
			}
			pIgySTSxXpNimyfhHec(Ifd1QSV4YZ);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetCellPropertyAsync_003Ed__75<>))]
	public Task<T> GetCellPropertyAsync<T>(CvsCellLocation location, string propertyName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetCellPropertyAsync_003Ed__75<T> stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<T>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.location = location;
		stateMachine.propertyName = propertyName;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetCellComment(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetCellCommentAsync(location).Result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetCellCommentAsync_003Ed__77))]
	public Task<string> GetCellCommentAsync(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetCellCommentAsync_003Ed__77 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.location = location;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<object> PutCellCommentAsync(CvsCellLocation location, string comment)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return liS1wH05cA().PutAsync<object>(v1f1Xb2PMu(location, kgbOBx7BanbFa22Hp9.ol99ukmDA(3962)), comment);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InsertCellExpressionAndRunSheet(CvsCellLocation location, string expression, bool withGetters)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_00f6;
		IL_001a:
		string path = default;
		ioNBMQSM2ttlGrLbvWY(liS1wH05cA().PostAsync<object>(path, new object[3]
		{
			location.ToString(),
			expression,
			withGetters
		}));
		goto IL_017c;
		IL_00f6:
		CvsParse cvsParse = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 6:
				goto IL_0060;
			case 9:
				throw new ArgumentException((string)DZd6mKSOmh5QoCVoL0j());
			case 8:
				return;
			case 2:
				if (!Fvae6DSjXNGvionHDSS(Ub3qxwS3GhwjTxu76eS(cvsParse), expression))
				{
					path = mYH1LMmUb4((string)udHk4CSH53pRfEolLvn(3980));
					num = 3;
					continue;
				}
				goto case 9;
			default:
				num = 9;
				continue;
			case 5:
				if (IC8kj6S7IQ8bhsL5nTt(expression) != 0)
				{
					cvsParse = CvsParse.Parse(Ifd1QSV4YZ.FunctionTable, (IExpressionConstants)JmIQO5S1DAVcFOs72jk(Ifd1QSV4YZ), expression, IC8kj6S7IQ8bhsL5nTt(expression));
					num = 10;
					if (!m7TVpcSSwGRe6I95cos())
					{
						continue;
					}
					goto case 2;
				}
				m7TVpcSSwGRe6I95cos();
				if (!gAebkiS9yt8lx8b0s4E())
				{
					num = 4;
					if (true)
					{
						continue;
					}
					goto IL_0060;
				}
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 1:
				ClearCellsContentsAndRun(new CvsCellRange(location));
				num = 8;
				if (m7TVpcSSwGRe6I95cos())
				{
				}
				continue;
			case 4:
			case 7:
				goto IL_017c;
			case 10:
				if (UihGxxSrjf8st5LM1GJ(cvsParse))
				{
					num = 2;
					continue;
				}
				goto case 9;
			case 11:
				return;
			}
			break;
			IL_0060:
			pIgySTSxXpNimyfhHec(Ifd1QSV4YZ);
			num = 11;
		}
		goto IL_001a;
		IL_017c:
		FireSheetUpdated(runSheet: true);
		num = 6;
		goto IL_00f6;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PutCellExpressionAndRunSheet(CvsCellLocation location, string expression)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		CvsParse cvsParse = default;
		string path = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 10:
				if (UihGxxSrjf8st5LM1GJ(cvsParse))
				{
					num = 9;
					if (true)
					{
						break;
					}
				}
				goto case 2;
			case 2:
				throw new ArgumentException((string)DZd6mKSOmh5QoCVoL0j());
			case 4:
				liS1wH05cA().PutAsync<object>(path, expression).Wait();
				num = 5;
				break;
			case 6:
				if (expression.Length == 0)
				{
					gAebkiS9yt8lx8b0s4E();
					num = (m7TVpcSSwGRe6I95cos() ? 10 : 8);
					break;
				}
				cvsParse = CvsParse.Parse((CvsFunctionTable)KrLlN4SQaylQktmujQf(Ifd1QSV4YZ), (IExpressionConstants)JmIQO5S1DAVcFOs72jk(Ifd1QSV4YZ), expression, IC8kj6S7IQ8bhsL5nTt(expression));
				goto case 3;
			case 0:
				return;
			case 7:
				pIgySTSxXpNimyfhHec(Ifd1QSV4YZ);
				num = 11;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				FireSheetUpdated(runSheet: true);
				num = 7;
				break;
			case 1:
			case 8:
				ClearCellsContentsAndRun(new CvsCellRange(location));
				num = 0;
				break;
			case 9:
				if (!((string)Ub3qxwS3GhwjTxu76eS(cvsParse) != expression))
				{
					path = v1f1Xb2PMu(location, (string)udHk4CSH53pRfEolLvn(4016));
					num = 4;
					break;
				}
				goto case 2;
			default:
				num = 2;
				if (m7TVpcSSwGRe6I95cos())
				{
				}
				break;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<object> PutCellExpressionAsync(CvsCellLocation location, string expression)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (expression.Length == 0)
		{
			return ClearCellsAsync(new CvsCellRange(location));
		}
		CvsParse cvsParse = CvsParse.Parse(Ifd1QSV4YZ.FunctionTable, Ifd1QSV4YZ.ProcessorConstants, expression, expression.Length);
		if (!cvsParse.AllowOK || cvsParse.FinishedExpression != expression)
		{
			throw new ArgumentException(Resources.InvalidExpression);
		}
		string path = v1f1Xb2PMu(location, kgbOBx7BanbFa22Hp9.ol99ukmDA(4016));
		return liS1wH05cA().PutAsync<object>(path, expression);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<string> GetCellExpressionAsync(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string path = v1f1Xb2PMu(location, kgbOBx7BanbFa22Hp9.ol99ukmDA(4016));
		return liS1wH05cA().GetAsync<string>(path);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsCogCellFlyOver> GetCellFlyOverAsync(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return liS1wH05cA().PostAsync<CvsCogCellFlyOver>(mYH1LMmUb4(kgbOBx7BanbFa22Hp9.ol99ukmDA(4040)), new object[1] { location.ToString() });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetLatestSheetResultAsync_003Ed__84))]
	public Task<CvsCogSheetResult> GetLatestSheetResultAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetLatestSheetResultAsync_003Ed__84 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCogSheetResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogSheetResult GetLatestSheetResult()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!m7TVpcSSwGRe6I95cos())
		{
			num = 2;
			if (1 == 0)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 4;
			if (false)
			{
				goto IL_00ae;
			}
		}
		goto IL_0052;
		IL_0052:
		CvsCogSheetResult result = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 1:
			case 4:
				dGX15IHsAv(result, null);
				break;
			default:
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				result = liS1wH05cA().GetAsync<CvsCogSheetResult>(mYH1LMmUb4((string)udHk4CSH53pRfEolLvn(4072))).Result;
				goto case 1;
			case 5:
				goto IL_00ae;
			}
			break;
		}
		goto IL_0026;
		IL_00ae:
		return LastSheetResult;
		IL_0026:
		FireSheetUpdated();
		num = 5;
		goto IL_0052;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetGraphicsAsync_003Ed__86))]
	public Task<CvsCogShape[]> GetGraphicsAsync(string url)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetGraphicsAsync_003Ed__86 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCogShape[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = url;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetChartAsync_003Ed__87))]
	public Task<CvsCogChart> GetChartAsync(string url)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetChartAsync_003Ed__87 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCogChart>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = url;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsCogEditingObject> EditEditableObjectAsync(string url)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return liS1wH05cA().PostAsync<CvsCogEditingObject>(K11133Jr1t(url, kgbOBx7BanbFa22Hp9.ol99ukmDA(4088)), new object[1] { kgbOBx7BanbFa22Hp9.ol99ukmDA(4100) });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsCogShape> GetExpandedRectangle3DAsync(string url)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return liS1wH05cA().GetAsync<CvsCogShape>(K11133Jr1t(url, kgbOBx7BanbFa22Hp9.ol99ukmDA(4120)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task ApplyEditableObjectAsync(string url, object obj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return liS1wH05cA().PostAsync<object>((string)Nvi16YSlgAjIGWDt5OB(url, udHk4CSH53pRfEolLvn(4158)), new object[1] { obj });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyEditableObjectAndRunSheet(string url, object obj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				Ifd1QSV4YZ.WaitForResultBuildComplete();
				num = 5;
				break;
			case 4:
				liS1wH05cA().PostAsync<object>((string)Nvi16YSlgAjIGWDt5OB(url, udHk4CSH53pRfEolLvn(4158)), new object[1] { obj }).Wait();
				m7TVpcSSwGRe6I95cos();
				if (gAebkiS9yt8lx8b0s4E())
				{
					num = 0;
					if (m7TVpcSSwGRe6I95cos())
					{
					}
				}
				else
				{
					num = 3;
				}
				break;
			case 0:
			case 1:
				FireSheetUpdated(runSheet: true);
				goto default;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CancelEditableObjectAndRunSheet(string url)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gAebkiS9yt8lx8b0s4E();
		int num = ((!m7TVpcSSwGRe6I95cos()) ? 1 : 4);
		while (true)
		{
			switch (num)
			{
			default:
				Ifd1QSV4YZ.WaitForResultBuildComplete();
				num = 5;
				break;
			case 3:
				FireSheetUpdated(runSheet: true);
				goto default;
			case 0:
			case 1:
				ioNBMQSM2ttlGrLbvWY(liS1wH05cA().PostAsync<object>(K11133Jr1t(url, kgbOBx7BanbFa22Hp9.ol99ukmDA(4172)), Array.Empty<object>()));
				num = 3;
				break;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsCogEditInfo> GetDefaultGraphicAsync(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string path = v1f1Xb2PMu(location, kgbOBx7BanbFa22Hp9.ol99ukmDA(4188));
		return liS1wH05cA().GetAsync<CvsCogEditInfo>(path);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<object> PutCellStyleAsync(CvsCellLocation location, string cellStyle)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return liS1wH05cA().PutAsync<object>(v1f1Xb2PMu(location, kgbOBx7BanbFa22Hp9.ol99ukmDA(4220)), cellStyle);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<object> PutGraphicsStyleAsync(CvsCellLocation location, string graphicsStyle)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return liS1wH05cA().PutAsync<object>(v1f1Xb2PMu(location, kgbOBx7BanbFa22Hp9.ol99ukmDA(4242)), graphicsStyle);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<object> PutCellNameAsync(CvsCellLocation location, object value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (location.Row == -1 || location.Column == -1)
		{
			throw new ArgumentException(kgbOBx7BanbFa22Hp9.ol99ukmDA(4272));
		}
		return liS1wH05cA().PutAsync<object>(v1f1Xb2PMu(location, kgbOBx7BanbFa22Hp9.ol99ukmDA(4310)), value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<string> GetCellNameAsync(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (location.Row == -1 || location.Column == -1)
		{
			throw new ArgumentException(kgbOBx7BanbFa22Hp9.ol99ukmDA(4272));
		}
		return liS1wH05cA().GetAsync<string>(v1f1Xb2PMu(location, kgbOBx7BanbFa22Hp9.ol99ukmDA(4310)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PutCellNameAndRunSheet(CvsCellLocation location, object value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (gAebkiS9yt8lx8b0s4E())
		{
			num = 4;
			if (m7TVpcSSwGRe6I95cos())
			{
			}
		}
		else
		{
			num = 2;
			if (false)
			{
				goto IL_00cf;
			}
		}
		goto IL_009c;
		IL_00cf:
		if (location.Row == -1)
		{
			goto IL_0058;
		}
		num = 5;
		goto IL_009c;
		IL_0058:
		throw new ArgumentException((string)udHk4CSH53pRfEolLvn(4272));
		IL_009c:
		while (true)
		{
			switch (num)
			{
			default:
				FireSheetUpdated(runSheet: true);
				num = 6;
				continue;
			case 5:
				if (location.Column == -1)
				{
					num = 1;
					if (true)
					{
						continue;
					}
					break;
				}
				ioNBMQSM2ttlGrLbvWY(liS1wH05cA().PutAsync<object>(v1f1Xb2PMu(location, kgbOBx7BanbFa22Hp9.ol99ukmDA(4310)), value));
				goto default;
			case 1:
				break;
			case 0:
			case 4:
				goto IL_00cf;
			case 6:
				return;
			}
			break;
		}
		goto IL_0058;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCellInfo(CvsCellInfo cellInfo)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ApplyCellAttributes(new CvsCellRange(cellInfo.Location), true, new DictionaryEntry(udHk4CSH53pRfEolLvn(4310), iRDVgGSel2WslIZsPK2(cellInfo)), new DictionaryEntry(udHk4CSH53pRfEolLvn(4322), GsppkASuCnHrU5IRlZ9(cellInfo)), new DictionaryEntry(kgbOBx7BanbFa22Hp9.ol99ukmDA(4336), NC7hJQSIbv7P360f6YR(cellInfo)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearCellInfo(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ApplyCellAttributes(new CvsCellRange(location), true, new DictionaryEntry(udHk4CSH53pRfEolLvn(4310), string.Empty), new DictionaryEntry(kgbOBx7BanbFa22Hp9.ol99ukmDA(4322), false), new DictionaryEntry(udHk4CSH53pRfEolLvn(4336), false));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearCellsContentsAndRun(CvsCellRange location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ApplyCellAttributes(location, true, new DictionaryEntry(udHk4CSH53pRfEolLvn(4016), string.Empty), new DictionaryEntry(udHk4CSH53pRfEolLvn(4352), string.Empty), new DictionaryEntry(kgbOBx7BanbFa22Hp9.ol99ukmDA(4310), string.Empty), new DictionaryEntry(kgbOBx7BanbFa22Hp9.ol99ukmDA(4322), false), new DictionaryEntry(udHk4CSH53pRfEolLvn(4336), false));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearCellsContentAsync(CvsCellRange location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ApplyCellAttributesAsync(location, new DictionaryEntry(kgbOBx7BanbFa22Hp9.ol99ukmDA(4016), string.Empty), new DictionaryEntry(udHk4CSH53pRfEolLvn(4352), string.Empty), new DictionaryEntry(udHk4CSH53pRfEolLvn(4310), string.Empty), new DictionaryEntry(udHk4CSH53pRfEolLvn(4322), false), new DictionaryEntry(udHk4CSH53pRfEolLvn(4336), false));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<object> PutCellInputFlagAsync(CvsCellLocation location, object value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (location.Row == -1 || location.Column == -1)
		{
			throw new ArgumentException(kgbOBx7BanbFa22Hp9.ol99ukmDA(4272));
		}
		return liS1wH05cA().PutAsync<object>(v1f1Xb2PMu(location, kgbOBx7BanbFa22Hp9.ol99ukmDA(4322)), value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<object> PutCellOutputFlagAsync(CvsCellLocation location, object value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (location.Row == -1 || location.Column == -1)
		{
			throw new ArgumentException(kgbOBx7BanbFa22Hp9.ol99ukmDA(4272));
		}
		return liS1wH05cA().PutAsync<object>(v1f1Xb2PMu(location, kgbOBx7BanbFa22Hp9.ol99ukmDA(4336)), value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<object> ProtectCellsAsync(CvsCellRange cellRange, string hash)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string path = mYH1LMmUb4(kgbOBx7BanbFa22Hp9.ol99ukmDA(4374));
		string text = cellRange.ToString();
		try
		{
			return liS1wH05cA().PostAsync<object>(path, new object[2] { text, hash });
		}
		catch (Exception ex)
		{
			if (ex is CvsNetworkException)
			{
				throw;
			}
			throw new CvsNetworkException(ex);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<object> UnprotectCellsAsync(CvsCellRange cellRange, string hash)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string path = mYH1LMmUb4(kgbOBx7BanbFa22Hp9.ol99ukmDA(4402));
		string text = cellRange.ToString();
		try
		{
			return liS1wH05cA().PostAsync<object>(path, new object[2] { text, hash });
		}
		catch (Exception ex)
		{
			if (ex is CvsNetworkException)
			{
				throw;
			}
			throw new CvsNetworkException(ex);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<object> ClearCellsAsync(CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string path = mYH1LMmUb4(kgbOBx7BanbFa22Hp9.ol99ukmDA(4434));
		string text = cellRange.ToString();
		try
		{
			return liS1wH05cA().PostAsync<object>(path, new object[1] { text });
		}
		catch (Exception ex)
		{
			if (ex is CvsNetworkException)
			{
				throw;
			}
			throw new CvsNetworkException(ex);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearCellsAndRunSheet(CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		m7TVpcSSwGRe6I95cos();
		int num = ((!gAebkiS9yt8lx8b0s4E()) ? 2 : 3);
		string path = default;
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				path = mYH1LMmUb4(kgbOBx7BanbFa22Hp9.ol99ukmDA(4434));
				goto case 1;
			case 1:
			case 2:
				text = cellRange.ToString();
				break;
			default:
				num = 4;
				continue;
			case 4:
				break;
			case 5:
				return;
			}
			try
			{
				_ = liS1wH05cA().PostAsync<object>(path, new object[1] { text }).Result;
			}
			catch (Exception ex)
			{
				if (ex is CvsNetworkException)
				{
					throw;
				}
				throw new CvsNetworkException(ex);
			}
			FireSheetUpdated(runSheet: true);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInternalPasteCellsAsync_003Ed__109))]
	public Task InternalPasteCellsAsync(CvsCellRange cellRange, byte[] bytes, bool cutFromSameSheet, bool runSheet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		_003CInternalPasteCellsAsync_003Ed__109 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				stateMachine._003C_003Et__builder = zsmRXLSRJqPYs7OsGZ7();
				num = 6;
				break;
			case 0:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			case 5:
				stateMachine.bytes = bytes;
				num = 4;
				break;
			case 4:
				stateMachine.cutFromSameSheet = cutFromSameSheet;
				goto case 9;
			default:
				num = 9;
				if (m7TVpcSSwGRe6I95cos())
				{
				}
				break;
			case 9:
				stateMachine.runSheet = runSheet;
				num = 0;
				break;
			case 2:
			case 3:
				stateMachine.cellRange = cellRange;
				num = 5;
				break;
			case 6:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				if (m7TVpcSSwGRe6I95cos())
				{
					num = 1;
					break;
				}
				num = 3;
				if (!m7TVpcSSwGRe6I95cos())
				{
					break;
				}
				goto case 1;
			case 1:
			case 7:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 10;
				break;
			case 10:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCopyCellsAsync_003Ed__110))]
	public Task<byte[]> CopyCellsAsync(CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCopyCellsAsync_003Ed__110 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<byte[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cellRange = cellRange;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCommentAndRunSheet(CvsCogCellResult cell, CvsCellComment comment)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gAebkiS9yt8lx8b0s4E();
		int num = (m7TVpcSSwGRe6I95cos() ? 3 : 4);
		string comment2 = default;
		CvsCellLocation location = default;
		string cellStyle = default;
		while (true)
		{
			switch (num)
			{
			case 9:
				pIgySTSxXpNimyfhHec(Ifd1QSV4YZ);
				num = 11;
				break;
			case 2:
				if (comment != null)
				{
					goto case 1;
				}
				goto case 3;
			default:
				num = 1;
				break;
			case 5:
				comment2 = (string)icZ0cjSaFoAktJHiltd(comment);
				num = 6;
				break;
			case 0:
			case 4:
				comment2 = "";
				num = 10;
				break;
			case 6:
				location = new CvsCellLocation((string)O00KjpSnsiZXXKe2849(cell));
				ioNBMQSM2ttlGrLbvWY(PutCellCommentAsync(location, comment2));
				num = 2;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
				cellStyle = (string)hCsh9kSXvfkgx2kLgOw(hcYEM5SGodjNo1Mlbs7(cell), comment.FlagColor);
				num = 8;
				break;
			case 3:
			case 7:
				FireSheetUpdated(runSheet: true);
				num = 9;
				break;
			case 8:
				ioNBMQSM2ttlGrLbvWY(PutCellStyleAsync(location, cellStyle));
				goto case 3;
			case 10:
				if (comment != null)
				{
					num = 5;
					break;
				}
				goto case 6;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCellStyles(CvsCellLocation location, string cellStyle, string graphicsStyle)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ApplyCellAttributes(new CvsCellRange(location), false, new DictionaryEntry(udHk4CSH53pRfEolLvn(4220), cellStyle), new DictionaryEntry(udHk4CSH53pRfEolLvn(4242), graphicsStyle));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearCellStyles(CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ApplyCellAttributes(range, false, new DictionaryEntry(udHk4CSH53pRfEolLvn(4220), ""), new DictionaryEntry(udHk4CSH53pRfEolLvn(4242), ""));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<string> GetOcrMaxAutoTuneSessionPathForCell(CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return liS1wH05cA().PostAsync<string>(v1f1Xb2PMu(loc, kgbOBx7BanbFa22Hp9.ol99ukmDA(4458)), Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ResourceNode GetCellToolResourceNode(string sheetName, CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new ResourceNode(Ifd1QSV4YZ.CameraResourceNode, (string)TVvlcfSTWdHgmKmt9y1(kgbOBx7BanbFa22Hp9.ol99ukmDA(4508), sheetName, location));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ResourceNode GetCellToolResourceNode(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new ResourceNode(e201DwB526, string.Format((string)udHk4CSH53pRfEolLvn(4570), location));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<DynamicArgBinder> GetDynamicArgBindingAsync(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!location.IsValid)
		{
			throw new ArgumentException(kgbOBx7BanbFa22Hp9.ol99ukmDA(4602), kgbOBx7BanbFa22Hp9.ol99ukmDA(4650));
		}
		string path = mYH1LMmUb4(string.Format(kgbOBx7BanbFa22Hp9.ol99ukmDA(4670), location));
		return liS1wH05cA().GetAsync<DynamicArgBinder>(path);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task SetBoundArgsAsync(CvsCellLocation location, string[] argNames)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!location.IsValid)
		{
			throw new ArgumentException((string)udHk4CSH53pRfEolLvn(4602), (string)udHk4CSH53pRfEolLvn(4650));
		}
		string path = mYH1LMmUb4((string)KhxbHHSbBp1KYrrCtso(udHk4CSH53pRfEolLvn(4726), location));
		return liS1wH05cA().PutAsync<object>(path, argNames);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PostImageByHTTP(CvsCellLocation location, Bitmap bmp)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			PostImageHelper.PostImageByHTTP(liS1wH05cA(), bmp, bWo10BjELQ(location), u5B19sM6Gn((string)udHk4CSH53pRfEolLvn(2984)), HTVP3BS63CSdw7m8XZT(), useSystemDebug: true, null, UCi12Xf2ZY);
		}
		catch (Exception ex)
		{
			if (ex is CvsNetworkException)
			{
				throw;
			}
			throw new CvsNetworkException(ex);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPostImageByHTTPAsync_003Ed__120))]
	public Task PostImageByHTTPAsync(CvsCellLocation location, Bitmap bmp, bool sync = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CPostImageByHTTPAsync_003Ed__120 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				stateMachine.sync = sync;
				num = 4;
				break;
			case 3:
			case 8:
				stateMachine.bmp = bmp;
				goto case 7;
			default:
				num = 7;
				break;
			case 2:
				stateMachine._003C_003Et__builder = zsmRXLSRJqPYs7OsGZ7();
				num = 1;
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 0;
				break;
			case 5:
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				break;
			case 0:
				stateMachine.location = location;
				m7TVpcSSwGRe6I95cos();
				if (!gAebkiS9yt8lx8b0s4E())
				{
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				}
				num = 8;
				break;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInvalidateCell_003Ed__121))]
	public Task InvalidateCell(CvsCellLocation location, string expression)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		_003CInvalidateCell_003Ed__121 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine.expression = expression;
				goto case 6;
			default:
				num = 6;
				continue;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				continue;
			case 4:
				stateMachine.location = location;
				num = 2;
				if (m7TVpcSSwGRe6I95cos())
				{
				}
				continue;
			case 7:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				_ = 0;
				if (gAebkiS9yt8lx8b0s4E())
				{
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					goto case 6;
				}
				num = 0;
				continue;
			case 6:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 4;
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
	public void PostDataByHTTP(CvsCellLocation location, Stream dataStream, string contentType, TimeSpan timeout)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		try
		{
			PostImageHelper.PostDataByHTTP(liS1wH05cA(), dataStream, contentType, bWo10BjELQ(location), u5B19sM6Gn((string)udHk4CSH53pRfEolLvn(4802)), timeout, useSystemDebug: true);
		}
		catch (Exception ex)
		{
			if (ex is CvsNetworkException)
			{
				throw;
			}
			throw new CvsNetworkException(ex);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CPostDataByHTTPAsync_003Ed__123))]
	public Task PostDataByHTTPAsync(CvsCellLocation location, Stream dataStream, string contentType, TimeSpan timeout)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gAebkiS9yt8lx8b0s4E();
		int num = ((!m7TVpcSSwGRe6I95cos()) ? 1 : 6);
		_003CPostDataByHTTPAsync_003Ed__123 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 5;
				continue;
			case 8:
				stateMachine.location = location;
				num = 9;
				continue;
			case 2:
				stateMachine.contentType = contentType;
				goto case 4;
			default:
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 9;
			case 9:
				stateMachine.dataStream = dataStream;
				num = 2;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 8;
				continue;
			case 4:
				stateMachine.timeout = timeout;
				num = 3;
				continue;
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 6;
			case 6:
			case 7:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 10;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 10:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Task<CvsPropertySheetResult> PropSheetInitAsync(CvsCellLocation cellLocation, string expression)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string path = mYH1LMmUb4(kgbOBx7BanbFa22Hp9.ol99ukmDA(4834));
		object[] args = new object[2]
		{
			cellLocation.ToString(),
			expression
		};
		return liS1wH05cA().PostAsync<CvsPropertySheetResult>(path, args);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Task<CvsPropertySheetResult> PropSheetRunAsync(string expression)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string path = mYH1LMmUb4(kgbOBx7BanbFa22Hp9.ol99ukmDA(4864));
		object[] args = new object[1] { expression };
		return liS1wH05cA().PostAsync<CvsPropertySheetResult>(path, args);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Task<CvsPropertySheetResult> PropSheetChangeAsync(string expression, int argIndex, string[] argValues)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return fjF1Y1Ki7u(expression, (HRDVuoTxpW43GMhV99)1, argIndex, argValues);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Task<CvsPropertySheetResult> PropSheetChangeGraphicAsync(string expression, int argIndex, string[] argValues)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return fjF1Y1Ki7u(expression, (HRDVuoTxpW43GMhV99)4, argIndex, argValues);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<CvsPropertySheetResult> fjF1Y1Ki7u(string P_0, HRDVuoTxpW43GMhV99 P_1, int P_2, string[] P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = P_2 + P_3.Length - 1;
		string[] array;
		string[] array2;
		switch (P_1)
		{
		case (HRDVuoTxpW43GMhV99)0:
			throw new ArgumentException(kgbOBx7BanbFa22Hp9.ol99ukmDA(4892));
		case (HRDVuoTxpW43GMhV99)4:
			array = null;
			array2 = P_3;
			break;
		default:
			array = P_3;
			array2 = null;
			break;
		}
		string path = mYH1LMmUb4(kgbOBx7BanbFa22Hp9.ol99ukmDA(4992));
		object[] args = new object[6]
		{
			P_0,
			(int)P_1,
			P_2,
			num,
			array,
			array2
		};
		return liS1wH05cA().PostAsync<CvsPropertySheetResult>(path, args);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Task<object> PropSheetOkAsync(CvsCellLocation cellLocation, string expression)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string path = mYH1LMmUb4(kgbOBx7BanbFa22Hp9.ol99ukmDA(5026));
		object[] args = new object[2]
		{
			cellLocation.ToString(),
			expression
		};
		return liS1wH05cA().PostAsync<object>(path, args);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Task<object> PropSheetCancelAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string path = mYH1LMmUb4(kgbOBx7BanbFa22Hp9.ol99ukmDA(5052));
		return liS1wH05cA().PostAsync<object>(path, Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Task<CvsPropertySheetResult> PropSheetGetResultAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string path = mYH1LMmUb4(kgbOBx7BanbFa22Hp9.ol99ukmDA(5086));
		return liS1wH05cA().GetAsync<CvsPropertySheetResult>(path);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Task PropSheetAddGettersOnOkAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string path = mYH1LMmUb4((string)udHk4CSH53pRfEolLvn(5128));
		return liS1wH05cA().PostAsync<object>(path, Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Task<CvsCogEditInfo> PropSheetGetEditableInfoAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string path = mYH1LMmUb4(kgbOBx7BanbFa22Hp9.ol99ukmDA(5178));
		return liS1wH05cA().PostAsync<CvsCogEditInfo>(path, Array.Empty<object>());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Task<DynamicArgBinder> PropSheetGetDynamicArgBindingAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string path = mYH1LMmUb4(kgbOBx7BanbFa22Hp9.ol99ukmDA(5234));
		return liS1wH05cA().GetAsync<DynamicArgBinder>(path);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Task PropSheetSetBoundArgsAsync(string[] argNames)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string path = mYH1LMmUb4((string)udHk4CSH53pRfEolLvn(5288));
		return liS1wH05cA().PutAsync<object>(path, argNames);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetArchive(string sheetName = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (m7TVpcSSwGRe6I95cos() ? 2 : 5);
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				text = null;
				num = 6;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
				text = nYs1k3egjd(sheetName, (string)udHk4CSH53pRfEolLvn(5362));
				goto case 2;
			default:
				num = 3;
				break;
			case 6:
				if (sheetName == null)
				{
					text = mYH1LMmUb4((string)udHk4CSH53pRfEolLvn(5362));
					goto case 2;
				}
				num = 1;
				break;
			case 2:
			case 3:
			case 4:
				if (D2q1SCyyKt)
				{
					num = 7;
					break;
				}
				return (string)HjuehuSprgVgZvTOfIK(liS1wH05cA().PostAsync<CvsCogByteArray>(text, Array.Empty<object>()).Result);
			case 7:
				return isI17asacA(text);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string isI17asacA(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (m7TVpcSSwGRe6I95cos() ? 2 : 4);
		_003C_003Ec__DisplayClass137_0 obj = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				obj = new _003C_003Ec__DisplayClass137_0();
				goto case 1;
			case 3:
				obj.url = (string)iybpjDS0xafw8fMBQ5Q(Ifd1QSV4YZ, P_0);
				num = 5;
				continue;
			case 1:
			case 2:
				obj._003C_003E4__this = this;
				goto case 3;
			default:
				num = 3;
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
		string result2 = default;
		try
		{
			obj.timeout = qyBdYLSkPgJ3X2ubSFC(iCgtBnS4IjdteZugnUo());
			CvsTraceSDK.TxCogSocket.TraceMessage((string)udHk4CSH53pRfEolLvn(5386), obj.url);
			obj.nullStream = null;
			Stream result = Task.Run((Func<Task<Stream>>)obj._003CGetArchiveByHttp_003Eb__0).Result;
			try
			{
				JObject jObject = (JObject)lVH0TWSf7aNvMVJJA10(new StreamReader(result).ReadToEnd());
				_ = 0;
				int num2;
				if (gAebkiS9yt8lx8b0s4E())
				{
					num2 = 3;
				}
				else
				{
					num2 = 2;
					if (false)
					{
						goto IL_0154;
					}
				}
				goto IL_0129;
				IL_0154:
				result2 = ((IEnumerable<JToken>)cAtDvrSFAisDmig5wWT(jObject, udHk4CSH53pRfEolLvn(5430))).Value<string>();
				num2 = 4;
				if (true)
				{
					goto IL_0129;
				}
				goto end_IL_00ea;
				IL_0129:
				switch (num2)
				{
				case 0:
				case 3:
					if (jObject != null)
					{
						break;
					}
					goto IL_01a2;
				case 4:
					goto end_IL_00ea;
				}
				goto IL_0154;
				end_IL_00ea:;
			}
			finally
			{
				if (result != null)
				{
					Epm2IVSmMVqQUk14cwR(result);
				}
			}
		}
		catch (Exception ex)
		{
			p3cAWISyaJwAoYj1QaN(CvsTraceSDK.Error, ex);
			throw;
		}
		return result2;
		IL_01a2:
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadArchiveAndRunSheet(string base64, string sheetBlockName = null, bool fireSheetUpdated = true)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (!m7TVpcSSwGRe6I95cos())
		{
		}
		TimeSpan gfg1Ca2CVo = default;
		CvsCogByteArray cvsCogByteArray = default;
		RequestOptions options = default;
		string text = default;
		while (true)
		{
			switch (num)
			{
			default:
				gfg1Ca2CVo = Gfg1Ca2CVo;
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 7;
			case 7:
				cvsCogByteArray = new CvsCogByteArray(base64);
				_ = 1;
				if (!m7TVpcSSwGRe6I95cos())
				{
					num = 0;
					continue;
				}
				num = 1;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 5:
				options.ResponseTimeout = gfg1Ca2CVo;
				num = 8;
				continue;
			case 6:
				text = mYH1LMmUb4((string)udHk4CSH53pRfEolLvn(5446));
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 3:
				options = default;
				goto default;
			case 2:
				UpdateBeforeSheetLoadAndRun(sheetBlockName);
				num = 6;
				if (gAebkiS9yt8lx8b0s4E())
				{
					continue;
				}
				break;
			case 8:
				break;
			}
			break;
		}
		try
		{
			IDisposable disposable = (IDisposable)LCfbirSgSHLugd4yGEg(CvsTraceSDK.Info, u5B19sM6Gn((string)udHk4CSH53pRfEolLvn(5480)));
			try
			{
				if (D2q1SCyyKt)
				{
					RMn1mFJReu(cvsCogByteArray, text, gfg1Ca2CVo);
					return;
				}
				ioNBMQSM2ttlGrLbvWY(liS1wH05cA().PostAsync<object>(text, options, new object[1] { cvsCogByteArray }));
			}
			finally
			{
				if (disposable != null)
				{
					Epm2IVSmMVqQUk14cwR(disposable);
				}
			}
		}
		finally
		{
			UpdateAfterSheetLoadedAndRan(fireSheetUpdated);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadArchive(string base64, string sheetName = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		IDisposable disposable = default;
		RequestOptions options = default;
		string text = default;
		TimeSpan gfg1Ca2CVo = default;
		CvsCogByteArray cvsCogByteArray = default;
		while (true)
		{
			switch (num)
			{
			case 7:
			case 8:
				disposable = (IDisposable)LCfbirSgSHLugd4yGEg(CvsTraceSDK.Info, u5B19sM6Gn(kgbOBx7BanbFa22Hp9.ol99ukmDA(5480)));
				num = 11;
				break;
			case 10:
				options = default;
				num = 0;
				break;
			case 3:
				text = null;
				_ = 1;
				if (!m7TVpcSSwGRe6I95cos())
				{
					num = 9;
					break;
				}
				num = 7;
				if (!m7TVpcSSwGRe6I95cos())
				{
					break;
				}
				goto case 1;
			case 0:
				gfg1Ca2CVo = Gfg1Ca2CVo;
				num = 6;
				break;
			case 6:
				options.ResponseTimeout = gfg1Ca2CVo;
				goto case 7;
			case 1:
			case 9:
				if (sheetName == null)
				{
					text = mYH1LMmUb4((string)udHk4CSH53pRfEolLvn(5446));
					num = 5;
				}
				else
				{
					num = 4;
				}
				break;
			case 2:
			case 5:
				cvsCogByteArray = new CvsCogByteArray(base64);
				goto case 10;
			default:
				num = 10;
				if (true)
				{
					break;
				}
				goto case 4;
			case 4:
				text = nYs1k3egjd(sheetName, (string)udHk4CSH53pRfEolLvn(5446));
				num = 2;
				break;
			case 11:
				try
				{
					if (D2q1SCyyKt)
					{
						RMn1mFJReu(cvsCogByteArray, text, gfg1Ca2CVo);
						return;
					}
					ioNBMQSM2ttlGrLbvWY(liS1wH05cA().PostAsync<object>(text, options, new object[1] { cvsCogByteArray }));
					return;
				}
				finally
				{
					if (disposable != null)
					{
						Epm2IVSmMVqQUk14cwR(disposable);
					}
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateBeforeSheetLoadAndRun(string sheetBlockName)
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
			case 2:
			case 4:
				SimpleSheetName = (string)UTVqZ9ScebOhtr0I8Lw(sheetBlockName);
				goto case 0;
			default:
				num = 0;
				break;
			case 5:
				if (sheetBlockName == null)
				{
					return;
				}
				m7TVpcSSwGRe6I95cos();
				if (gAebkiS9yt8lx8b0s4E())
				{
					num = 3;
					if (!m7TVpcSSwGRe6I95cos())
					{
						break;
					}
					goto case 0;
				}
				num = 4;
				if (!gAebkiS9yt8lx8b0s4E())
				{
					return;
				}
				break;
			case 0:
				CkA1cse5HI((string)fCoTXiS27if5Teomdgm(sheetBlockName));
				num = 6;
				break;
			case 1:
			case 3:
				C6K1Zy1k0C = sheetBlockName;
				goto case 2;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateAfterSheetLoadedAndRan(bool fireSheetUpdated = true)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 0:
				if (!gUYjnMSZ22oX7YqJcsu(liS1wH05cA()))
				{
					num = 4;
					break;
				}
				return;
			case 1:
				pIgySTSxXpNimyfhHec(Ifd1QSV4YZ);
				num = 7;
				break;
			case 2:
			case 6:
				if (fireSheetUpdated)
				{
					goto default;
				}
				return;
			default:
				FireSheetUpdated(runSheet: true);
				num = 1;
				break;
			case 4:
				RIW1nawRDo();
				m7TVpcSSwGRe6I95cos();
				if (!gAebkiS9yt8lx8b0s4E())
				{
					num = 5;
					break;
				}
				num = 6;
				if (!gAebkiS9yt8lx8b0s4E())
				{
					return;
				}
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RMn1mFJReu(CvsCogByteArray P_0, string P_1, TimeSpan P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gAebkiS9yt8lx8b0s4E();
		int num;
		if (!m7TVpcSSwGRe6I95cos())
		{
			num = 3;
			if (false)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0043;
		IL_0095:
		_003C_003Ec__DisplayClass142_0 obj = default;
		obj.timeout = P_2;
		num = 6;
		goto IL_0043;
		IL_0043:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			default:
				num = 5;
				continue;
			case 1:
			case 2:
				obj._003C_003E4__this = this;
				num = 4;
				continue;
			case 0:
			case 3:
				obj = new _003C_003Ec__DisplayClass142_0();
				goto case 1;
			case 5:
				goto IL_0095;
			case 6:
				try
				{
					CvsTraceSDK.TxCogSocket.TraceMessage((string)udHk4CSH53pRfEolLvn(2062), u5B19sM6Gn((string)udHk4CSH53pRfEolLvn(5506)), obj.path);
					byte[] buffer = (byte[])IHn7LxSJvwyuUOAPfyW(HjuehuSprgVgZvTOfIK(P_0));
					_003C_003Ec__DisplayClass142_1 CS_0024_003C_003E8__locals12 = new _003C_003Ec__DisplayClass142_1();
					CS_0024_003C_003E8__locals12.CS_0024_003C_003E8__locals1 = obj;
					CS_0024_003C_003E8__locals12.byteStream = new MemoryStream(buffer);
					try
					{
						ioNBMQSM2ttlGrLbvWY(Task.Run([MethodImpl(MethodImplOptions.NoInlining)] [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass142_1.zcw1QxUJcZjBUhQoXL))] () =>
						{
							while (false)
							{
								_ = ((object[])null)[0];
							}
							_003C_003Ec__DisplayClass142_1.zcw1QxUJcZjBUhQoXL stateMachine = default;
							stateMachine.aQbnxqGDmM = AsyncTaskMethodBuilder<Stream>.Create();
							stateMachine.pVunFqKP9R = CS_0024_003C_003E8__locals12;
							stateMachine.Gp5n1eVEQA = -1;
							stateMachine.aQbnxqGDmM.Start(ref stateMachine);
							return stateMachine.aQbnxqGDmM.Task;
						}));
						return;
					}
					finally
					{
						if (CS_0024_003C_003E8__locals12.byteStream != null)
						{
							Epm2IVSmMVqQUk14cwR(CS_0024_003C_003E8__locals12.byteStream);
						}
					}
				}
				catch (Exception ex)
				{
					CvsTraceSDK.TxCogSocket.TraceException(ex);
					W4UWFSSKnxCRCZg55wq(CvsTraceSDK.TxCogSocket, kgbOBx7BanbFa22Hp9.ol99ukmDA(2062), new object[2]
					{
						u5B19sM6Gn(kgbOBx7BanbFa22Hp9.ol99ukmDA(5544)),
						obj.path
					});
					string value = (string)CYQIDiS8F55CG9JfkGZ(new JsonRemoteSerializer(), P_0);
					_003C_003Ec__DisplayClass142_2 CS_0024_003C_003E8__locals13 = new _003C_003Ec__DisplayClass142_2();
					CS_0024_003C_003E8__locals13.CS_0024_003C_003E8__locals2 = obj;
					CS_0024_003C_003E8__locals13.dataStream = new MemoryStream();
					try
					{
						StreamWriter streamWriter = new StreamWriter(CS_0024_003C_003E8__locals13.dataStream);
						streamWriter.Write(value);
						pfJ8KRSzoSwpeoIL2l3(streamWriter);
						gAebkiS9yt8lx8b0s4E();
						switch (m7TVpcSSwGRe6I95cos() ? 3 : 2)
						{
						case 0:
						case 2:
							OahQfcEwdZsdFXKr2wg(CS_0024_003C_003E8__locals13.dataStream, 0L);
							break;
						}
						ioNBMQSM2ttlGrLbvWY(Task.Run([MethodImpl(MethodImplOptions.NoInlining)] [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass142_2.KiLbFPonXb4wVT6hGF))] () =>
						{
							while (false)
							{
								_ = ((object[])null)[0];
							}
							_003C_003Ec__DisplayClass142_2.KiLbFPonXb4wVT6hGF stateMachine = default;
							stateMachine.kPpnOl5JoV = AsyncTaskMethodBuilder<Stream>.Create();
							stateMachine.avTnpGuZWN = CS_0024_003C_003E8__locals13;
							stateMachine.YwDnavCLlo = -1;
							stateMachine.kPpnOl5JoV.Start(ref stateMachine);
							return stateMachine.kPpnOl5JoV.Task;
						}));
						return;
					}
					finally
					{
						if (CS_0024_003C_003E8__locals13.dataStream != null)
						{
							((IDisposable)CS_0024_003C_003E8__locals13.dataStream).Dispose();
						}
					}
				}
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		obj.path = P_1;
		goto IL_0095;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public long GetSheetTimeout()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return liS1wH05cA().GetAsync<long>(mYH1LMmUb4((string)udHk4CSH53pRfEolLvn(5594))).Result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendSheetTimeout(long timeout)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ioNBMQSM2ttlGrLbvWY(liS1wH05cA().PutAsync<object>(mYH1LMmUb4(kgbOBx7BanbFa22Hp9.ol99ukmDA(5594)), timeout));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetEditInfosAsync_003Ed__145))]
	public Task<CvsCogEditInfo[]> GetEditInfosAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetEditInfosAsync_003Ed__145 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCogEditInfo[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetRowCountAsync_003Ed__146))]
	public Task<int> GetRowCountAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetRowCountAsync_003Ed__146 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<int>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetEasyBuilderEditable_003Ed__147))]
	public Task<bool> GetEasyBuilderEditable()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetEasyBuilderEditable_003Ed__147 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSpreadsheetEditable_003Ed__148))]
	public Task<bool> GetSpreadsheetEditable()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetSpreadsheetEditable_003Ed__148 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCheckForSnippets_003Ed__149))]
	public Task CheckForSnippets()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CCheckForSnippets_003Ed__149 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003Et__builder = zsmRXLSRJqPYs7OsGZ7();
				m7TVpcSSwGRe6I95cos();
				if (gAebkiS9yt8lx8b0s4E())
				{
					num = 5;
					if (m7TVpcSSwGRe6I95cos())
					{
					}
					continue;
				}
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 4;
				continue;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 4:
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
	[AsyncStateMachine(typeof(_003CGetEditInfoAsync_003Ed__150))]
	public Task<CvsCogEditInfo[]> GetEditInfoAsync(CvsCellLocation cellLocation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetEditInfoAsync_003Ed__150 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCogEditInfo[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cellLocation = cellLocation;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetEditInfosAsync_003Ed__151))]
	public Task<CvsCogEditInfo[]> GetEditInfosAsync(CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetEditInfosAsync_003Ed__151 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCogEditInfo[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cellRange = cellRange;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetExpressionGraphic_003Ed__152))]
	public Task<CvsCogExpressionGraphic> GetExpressionGraphic(CvsCogEditInfo editInfo)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetExpressionGraphic_003Ed__152 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCogExpressionGraphic>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.editInfo = editInfo;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<object> ApplyCellAttributesAsync(CvsCellRange range, params DictionaryEntry[] args)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		for (int i = 0; i < args.Length; i++)
		{
			DictionaryEntry dictionaryEntry = args[i];
			dictionary.Add((string)dictionaryEntry.Key, dictionaryEntry.Value);
		}
		string text = range.ToString();
		return liS1wH05cA().PostAsync<object>(mYH1LMmUb4(kgbOBx7BanbFa22Hp9.ol99ukmDA(5612)), new object[2] { text, dictionary });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyCellAttributes(CvsCellRange range, bool runSheet, params DictionaryEntry[] args)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		Dictionary<string, object> dictionary = default;
		DictionaryEntry[] array = default;
		int num2 = default;
		DictionaryEntry dictionaryEntry = default;
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				dictionary = new Dictionary<string, object>();
				num = 0;
				if (gAebkiS9yt8lx8b0s4E())
				{
					break;
				}
				goto case 0;
			case 0:
				array = args;
				num = 6;
				break;
			case 6:
				num2 = 0;
				goto case 10;
			case 10:
				while (num2 < array.Length)
				{
					dictionaryEntry = array[num2];
					gAebkiS9yt8lx8b0s4E();
					if (!m7TVpcSSwGRe6I95cos())
					{
						num = 9;
						if (true)
						{
							goto end_IL_0081;
						}
						continue;
					}
					num = 5;
					goto end_IL_0081;
				}
				goto case 1;
			default:
				num = 1;
				break;
			case 7:
				Run();
				num = 12;
				break;
			case 3:
			case 9:
				dictionary.Add((string)dictionaryEntry.Key, dictionaryEntry.Value);
				goto case 4;
			case 4:
			case 5:
				num2++;
				num = 10;
				break;
			case 1:
				text = range.ToString();
				num = 11;
				if (!m7TVpcSSwGRe6I95cos())
				{
					break;
				}
				goto case 8;
			case 8:
				if (runSheet)
				{
					num = 7;
					break;
				}
				return;
			case 11:
				ioNBMQSM2ttlGrLbvWY(liS1wH05cA().PostAsync<object>(mYH1LMmUb4((string)udHk4CSH53pRfEolLvn(5612)), new object[2] { text, dictionary }));
				num = 8;
				break;
			case 12:
				return;
				end_IL_0081:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyCellAttributes(CvsCellRange range, bool runSheet, Dictionary<string, object> args)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		List<DictionaryEntry> list = new List<DictionaryEntry>();
		foreach (KeyValuePair<string, object> arg in args)
		{
			list.Add(new DictionaryEntry(arg.Key, arg.Value));
		}
		ApplyCellAttributes(range, runSheet, list.ToArray());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetRowHeightsAsync_003Ed__156))]
	public Task<int[]> GetRowHeightsAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetRowHeightsAsync_003Ed__156 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<int[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task SetRowHeightsAsync(int[] values)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string path = mYH1LMmUb4((string)udHk4CSH53pRfEolLvn(5654));
		return liS1wH05cA().PutAsync<object[]>(path, values);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetColumnWidthsAsync_003Ed__158))]
	public Task<int[]> GetColumnWidthsAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetColumnWidthsAsync_003Ed__158 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<int[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task SetColumnWidthsAsync(int[] values)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string path = mYH1LMmUb4((string)udHk4CSH53pRfEolLvn(5678));
		return liS1wH05cA().PutAsync<object[]>(path, values);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetCellResultsAsync_003Ed__160))]
	public Task<CvsCogCellResult[]> GetCellResultsAsync(string resultsPath, bool configureAwait = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetCellResultsAsync_003Ed__160 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCogCellResult[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.resultsPath = resultsPath;
		stateMachine.configureAwait = configureAwait;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<object> EvaluateSheetExpressionAsync(string expression)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string path = mYH1LMmUb4(kgbOBx7BanbFa22Hp9.ol99ukmDA(5706));
		return liS1wH05cA().PostAsync<object>(path, new object[1] { expression });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PutOutputs(string outputs)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string path = mYH1LMmUb4((string)udHk4CSH53pRfEolLvn(5726));
		ioNBMQSM2ttlGrLbvWY(liS1wH05cA().PutAsync<object>(path, outputs));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCogSheetResult Run(Dictionary<string, object> inputs)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string path = mYH1LMmUb4(kgbOBx7BanbFa22Hp9.ol99ukmDA(5744));
		x7J1dOJCsh = inputs;
		if (inputs == null)
		{
			inputs = new Dictionary<string, object>();
		}
		CvsCogSheetResult result = liS1wH05cA().PostAsync<CvsCogSheetResult>(path, new object[1] { inputs }).Result;
		dGX15IHsAv(result, null);
		FireSheetUpdated();
		Ifd1QSV4YZ.WaitForResultBuildComplete();
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsCogSheetResult Run(bool fireSheetUpdated = true)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gAebkiS9yt8lx8b0s4E();
		int num = (m7TVpcSSwGRe6I95cos() ? 4 : 5);
		Dictionary<string, object> dictionary = default;
		string path = default;
		Task<CvsCogSheetResult> task = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				FireSheetUpdated();
				num = 8;
				continue;
			case 6:
				dictionary = new Dictionary<string, object>();
				num = 7;
				continue;
			case 0:
			case 5:
				path = mYH1LMmUb4(kgbOBx7BanbFa22Hp9.ol99ukmDA(5744));
				num = 6;
				continue;
			case 7:
				task = liS1wH05cA().PostAsync<CvsCogSheetResult>(path, new object[1] { dictionary });
				goto case 3;
			case 2:
				if (fireSheetUpdated)
				{
					num = 1;
					continue;
				}
				break;
			case 3:
			case 4:
				dGX15IHsAv(task.Result, null);
				goto case 2;
			default:
				num = 2;
				continue;
			case 8:
				break;
			}
			break;
		}
		return LastSheetResult;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRunAsync_003Ed__165))]
	public Task<CvsCogSheetResult> RunAsync(bool fireSheetUpdated = true)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CRunAsync_003Ed__165 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCogSheetResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.fireSheetUpdated = fireSheetUpdated;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRunAsync_003Ed__166))]
	public Task<CvsCogSheetResult> RunAsync(string sheetName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CRunAsync_003Ed__166 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCogSheetResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sheetName = sheetName;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRunAndGetCellResults_003Ed__167))]
	public Task<CvsCellCollection> RunAndGetCellResults(Dictionary<string, object> inputs = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CRunAndGetCellResults_003Ed__167 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCellCollection>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.inputs = inputs;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetCellResults_003Ed__168))]
	public Task<CvsCellCollection> GetCellResults()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetCellResults_003Ed__168 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCellCollection>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRunAsync_003Ed__169))]
	public Task<CvsCogSheetResult> RunAsync(Dictionary<string, object> inputs, bool fireSheetUpdated = true)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CRunAsync_003Ed__169 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCogSheetResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.inputs = inputs;
		stateMachine.fireSheetUpdated = fireSheetUpdated;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsCogCell[]> QueryCells(string filter)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return e201DwB526.PostAsync<CvsCogCell[]>(kgbOBx7BanbFa22Hp9.ol99ukmDA(5754), new object[2] { "", filter });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CQueryCells_003Ed__171))]
	public Task<IEnumerable<IDictionary<string, object>>> QueryCells(string filter, IEnumerable<string> fields)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CQueryCells_003Ed__171 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IEnumerable<IDictionary<string, object>>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.filter = filter;
		stateMachine.fields = fields;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void FireSheetUpdated(bool runSheet = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (gAebkiS9yt8lx8b0s4E())
		{
			num = 4;
		}
		else
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_003d;
			}
		}
		goto IL_0067;
		IL_0067:
		SheetUpdatedEventHandler sheetUpdatedEventHandler = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				sheetUpdatedEventHandler = qLB1yd5DIw;
				goto case 1;
			case 2:
				break;
			case 1:
			case 3:
				if (sheetUpdatedEventHandler != null)
				{
					break;
				}
				return;
			default:
				goto IL_0084;
			case 5:
				return;
			}
			break;
			IL_0084:
			num = 2;
			if (m7TVpcSSwGRe6I95cos())
			{
				return;
			}
		}
		goto IL_003d;
		IL_003d:
		DBjd3ZEs4GgnlBuLO9t(sheetUpdatedEventHandler, this, runSheet);
		num = 5;
		goto IL_0067;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RIW1nawRDo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!gAebkiS9yt8lx8b0s4E())
		{
			goto IL_001e;
		}
		goto IL_004e;
		IL_001e:
		EventHandler eventHandler = default;
		rhuyf0SNYgyBNiGxve0(eventHandler, this, EventArgs.Empty);
		num = 5;
		if (1 == 0)
		{
			goto IL_0036;
		}
		goto IL_004e;
		IL_0036:
		if (eventHandler != null)
		{
			goto IL_001e;
		}
		return;
		IL_004e:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				goto IL_0036;
			case 0:
				do
				{
					eventHandler = b2t1VmBnmo;
					_ = 1;
					if (m7TVpcSSwGRe6I95cos())
					{
						num = 3;
						continue;
					}
					num = 4;
					if (true)
					{
						break;
					}
					return;
				}
				while (m7TVpcSSwGRe6I95cos());
				continue;
			case 5:
				return;
			}
			break;
		}
		goto IL_001e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string u5B19sM6Gn(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)TVvlcfSTWdHgmKmt9y1(udHk4CSH53pRfEolLvn(5778), Ifd1QSV4YZ.Camera, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool sb81UnLotY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return RC9FnvESonkH9Xw9QKU(ovNKvDELq4eOU2Ke38g(FcgqhFEh2xdS4PH50w8(new StackTrace(2).GetFrame(0))).Assembly, pjCoFjE9esDHSGw0b3u());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string bWo10BjELQ(CvsCellLocation P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!P_0.IsValid)
		{
			throw new ArgumentException(kgbOBx7BanbFa22Hp9.ol99ukmDA(4602), (string)udHk4CSH53pRfEolLvn(4650));
		}
		string text = v1f1Xb2PMu(P_0, kgbOBx7BanbFa22Hp9.ol99ukmDA(5832));
		return (string)iybpjDS0xafw8fMBQ5Q(Ifd1QSV4YZ, text);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bl2mK7SEWwVFjRLahlc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TimeSpan jsqomWSvBWjNdFwu3yL(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return TimeSpan.FromSeconds(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object udHk4CSH53pRfEolLvn(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gAebkiS9yt8lx8b0s4E()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool m7TVpcSSwGRe6I95cos()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QxAWJfSVo7Ia5eo8mhy(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IIvLtuSADOdFFLHQt1n(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ResourceNode)P_0).GetChildResource((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uGxBGwSDtCV1ZBkJa4w(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).DeviceApi;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool L4OrV6SUarjyrkjSaQ9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TVvlcfSTWdHgmKmt9y1(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Rweil4SdfCApswyqiEW(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Rji9n9Si8Wfh6aykV20(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oO3xjCSqjDB6CsMpvpK(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Dr1EttSBfx3bNt0eHSG(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Fvae6DSjXNGvionHDSS(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 != (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UTVqZ9ScebOhtr0I8Lw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return s1C1fTTNL7((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fCoTXiS27if5Teomdgm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return vnN1jtafFq((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int sM9Mt3SWPJ1E71ZrZiE(object P_0, char P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).LastIndexOf(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int IC8kj6S7IQ8bhsL5nTt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bNepPpSt4oBgwU2l46I(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Substring(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Oc1ZFKSCrkRbOHR5kPS(object P_0, char P_1, char P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Replace(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void W4UWFSSKnxCRCZg55wq(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CnxTraceChannel)P_0).TraceMessage((string)P_1, (object[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QELM33S5TniDZwp3vCp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Monitor.Exit(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long kqIrbESo0n7OYRU9Y98(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSheetResult)P_0).Id;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BXACHgSPYSahhysn9X9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSessionResult)P_0).SheetResult;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PWdmCWSYvBS3Ion7pgZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsCogCellResult>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rhuyf0SNYgyBNiGxve0(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (EventArgs)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pIgySTSxXpNimyfhHec(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogSocket)P_0).WaitForResultBuildComplete();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JmIQO5S1DAVcFOs72jk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).ProcessorConstants;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UihGxxSrjf8st5LM1GJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsParse)P_0).AllowOK;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ub3qxwS3GhwjTxu76eS(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsParse)P_0).FinishedExpression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DZd6mKSOmh5QoCVoL0j()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.InvalidExpression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ioNBMQSM2ttlGrLbvWY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Task)P_0).Wait();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KrLlN4SQaylQktmujQf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).FunctionTable;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Nvi16YSlgAjIGWDt5OB(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return K11133Jr1t((string)P_0, (string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iRDVgGSel2WslIZsPK2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellInfo)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GsppkASuCnHrU5IRlZ9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellInfo)P_0).Input;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NC7hJQSIbv7P360f6YR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellInfo)P_0).Output;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder zsmRXLSRJqPYs7OsGZ7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object icZ0cjSaFoAktJHiltd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellComment)P_0).Text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object O00KjpSnsiZXXKe2849(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hcYEM5SGodjNo1Mlbs7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).GetCellFormat();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hCsh9kSXvfkgx2kLgOw(object P_0, Color commentFlagColor)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellFormat.UpdateCommentFlagColor((CvsCellFormat)P_0, commentFlagColor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KhxbHHSbBp1KYrrCtso(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TimeSpan HTVP3BS63CSdw7m8XZT()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCogSocketAcq.HttpImageTimeout;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HjuehuSprgVgZvTOfIK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogByteArray)P_0).Base64;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iybpjDS0xafw8fMBQ5Q(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).MakeHttpUrl((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int iCgtBnS4IjdteZugnUo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return HttpArchiveTimeout;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TimeSpan qyBdYLSkPgJ3X2ubSFC(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return TimeSpan.FromMilliseconds(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lVH0TWSf7aNvMVJJA10(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return JObject.Parse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cAtDvrSFAisDmig5wWT(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((JObject)P_0)[(string)P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Epm2IVSmMVqQUk14cwR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void p3cAWISyaJwAoYj1QaN(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CnxTraceChannel)P_0).TraceException((Exception)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LCfbirSgSHLugd4yGEg(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CnxTraceChannel)P_0).TraceBlock((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gUYjnMSZ22oX7YqJcsu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IRemoteDeviceApi)P_0).IsDisposed;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IHn7LxSJvwyuUOAPfyW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Convert.FromBase64String((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CYQIDiS8F55CG9JfkGZ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((JsonRemoteSerializer)P_0).SerializeObject(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pfJ8KRSzoSwpeoIL2l3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((TextWriter)P_0).Flush();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OahQfcEwdZsdFXKr2wg(object P_0, long P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Stream)P_0).Position = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DBjd3ZEs4GgnlBuLO9t(object P_0, object P_1, bool runSheet)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, runSheet);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FcgqhFEh2xdS4PH50w8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StackFrame)P_0).GetMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type ovNKvDELq4eOU2Ke38g(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((MemberInfo)P_0).ReflectedType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pjCoFjE9esDHSGw0b3u()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Assembly.GetExecutingAssembly();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RC9FnvESonkH9Xw9QKU(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (Assembly)P_0 == (Assembly)P_1;
	}
}
