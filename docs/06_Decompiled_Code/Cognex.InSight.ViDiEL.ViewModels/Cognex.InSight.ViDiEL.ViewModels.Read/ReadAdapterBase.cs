using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Remoting.Serialization.ViDiEL.Read;
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using Cognex.InSight.ViDiEL.ViewModels.Utils;
using Cognex.Ocr.Client;
using Cognex.Ocr.Client.Tool;
using Cognex.WebToolEditControl.Core;
using jUKn21pup6XFIrInBb;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.Read;

public abstract class ReadAdapterBase : ViDiELAdapterBase, IOcrToolAdapter
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public ReadAdapterBase _003C_003E4__this;

		public NewResultArgs args;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass20_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			R8OrkBcFCgqOZ2pMIbr();
			mwxDt0csQv8JKGilri2(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003COnNewResult_003Eb__0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003E4__this.jUVxv2HiuO?.Invoke(_003C_003E4__this, args);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void R8OrkBcFCgqOZ2pMIbr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void mwxDt0csQv8JKGilri2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LwxSRxcDwWH8BAXag3N()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pnM9hDc812s8GNIxiVL()
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
	private struct _003CGetSamples_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ICollection<ISample>> _003C_003Et__builder;

		public ReadAdapterBase _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<ICollection<ISample>> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			euDOoYcEkjtgIymcMV2();
			int num = ((!CniF3bcd4UemsKVRhKi()) ? 1 : 4);
			int num2 = default;
			ReadAdapterBase readAdapterBase = default;
			TaskAwaiter<ICollection<ISample>> awaiter = default;
			ICollection<ISample> result = default;
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
							readAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 0;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
						}
						while (true)
						{
							switch (num3)
							{
							case 8:
								_003C_003Eu__1 = default;
								num3 = 9;
								continue;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 2:
							case 4:
								num2 = (_003C_003E1__state = 0);
								goto case 3;
							case 6:
								return;
							case 0:
								awaiter = readAdapterBase.exOxYFoi5d.GetResultAsync(toolId, IRTUikc58aqDIB3tgPS(readAdapterBase.CancellationSource)).GetAwaiter();
								num3 = 1;
								continue;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								continue;
							case 3:
							case 7:
								_003C_003Eu__1 = awaiter;
								goto case 5;
							default:
								num3 = 5;
								continue;
							case 1:
								if (!awaiter.IsCompleted)
								{
									CniF3bcd4UemsKVRhKi();
									num3 = ((!euDOoYcEkjtgIymcMV2()) ? 4 : 7);
									continue;
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
					break;
				default:
					num = 5;
					continue;
				case 3:
					readAdapterBase = _003C_003E4__this;
					goto case 1;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 3;
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
		internal static CancellationToken IRTUikc58aqDIB3tgPS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CancellationTokenSource)P_0).Token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CniF3bcd4UemsKVRhKi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool euDOoYcEkjtgIymcMV2()
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
	private struct _003CGetNumberOfSamples_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

		public ReadAdapterBase _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<ELReadModelStats> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			ReadAdapterBase readAdapterBase = default;
			TaskAwaiter<ELReadModelStats> awaiter = default;
			int result = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					fV4ZdxcalcKe00sSWC5();
					if (qP6AFdc3PVgbVWVyvqw())
					{
						num = 2;
						continue;
					}
					num = 0;
					if (!fV4ZdxcalcKe00sSWC5())
					{
						continue;
					}
					goto case 1;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							readAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 6;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								continue;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 7:
								_003C_003Eu__1 = default;
								num3 = 0;
								continue;
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 5:
								return;
							case 9:
								if (!awaiter.IsCompleted)
								{
									_ = 1;
									num3 = ((!fV4ZdxcalcKe00sSWC5()) ? 3 : 4);
									continue;
								}
								break;
							case 4:
								return;
							case 1:
								_003C_003Eu__1 = awaiter;
								goto case 8;
							default:
								num3 = 8;
								if (true)
								{
									continue;
								}
								goto case 6;
							case 6:
								awaiter = readAdapterBase.R13xMcH05M.GetResultAsync(toolId, tr5dHYcoqriagZBAUaX(readAdapterBase.CancellationSource)).GetAwaiter();
								num3 = 9;
								if (qP6AFdc3PVgbVWVyvqw())
								{
									continue;
								}
								break;
							case 10:
								break;
							}
							break;
						}
						result = dXSyXdcchae67ftG2Ii(awaiter.GetResult());
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 1:
				case 2:
					readAdapterBase = _003C_003E4__this;
					num = 4;
					continue;
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
		internal static CancellationToken tr5dHYcoqriagZBAUaX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CancellationTokenSource)P_0).Token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int dXSyXdcchae67ftG2Ii(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELReadModelStats)P_0).NumSamples;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qP6AFdc3PVgbVWVyvqw()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fV4ZdxcalcKe00sSWC5()
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
	private struct _003CGetNumberOfUniqueCharacters_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

		public ReadAdapterBase _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<ELReadModelStats> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			ReadAdapterBase readAdapterBase = default;
			TaskAwaiter<ELReadModelStats> awaiter = default;
			int numUniqueCharacters = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					_ = 0;
					if (vGClpYcuCFGoE1KYWoQ())
					{
						num = 3;
						continue;
					}
					num = 4;
					if (vGClpYcuCFGoE1KYWoQ())
					{
						continue;
					}
					goto case 2;
				case 1:
				case 3:
					readAdapterBase = _003C_003E4__this;
					goto case 2;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							readAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 6;
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
							case 6:
								awaiter = readAdapterBase.R13xMcH05M.GetResultAsync(toolId, fstmtucxiHXdbWsAjDC(readAdapterBase.CancellationSource)).GetAwaiter();
								num3 = 8;
								continue;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (true)
								{
									continue;
								}
								goto case 0;
							case 0:
								num2 = (_003C_003E1__state = 0);
								_ = 0;
								num3 = ((!vGClpYcuCFGoE1KYWoQ()) ? 7 : 5);
								continue;
							default:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								continue;
							case 3:
							case 5:
								_003C_003Eu__1 = awaiter;
								goto default;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								break;
							case 9:
								return;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 1;
								continue;
							case 10:
								break;
							}
							break;
						}
						numUniqueCharacters = awaiter.GetResult().NumUniqueCharacters;
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
					num = 0;
					if (vGClpYcuCFGoE1KYWoQ())
					{
						continue;
					}
					break;
				case 0:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult(numUniqueCharacters);
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
		internal static CancellationToken fstmtucxiHXdbWsAjDC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CancellationTokenSource)P_0).Token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vGClpYcuCFGoE1KYWoQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WvZfXOcB3wJTTXGLbP3()
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
	private struct _003CGetImage_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IResultImage> _003C_003Et__builder;

		public ReadAdapterBase _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<IResultImage> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			ReadAdapterBase readAdapterBase = default;
			IResultImage result = default;
			TaskAwaiter<IResultImage> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					H0fOpAch2TyIa30yPnv();
					if (!KgGeYicUQhGcJoFOgJ4())
					{
						num = 2;
						if (0 == 0)
						{
							break;
						}
						goto case 1;
					}
					num = 0;
					break;
				case 1:
				case 2:
					readAdapterBase = _003C_003E4__this;
					num = 4;
					break;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							readAdapterBase.ThrowIfToolIdInvalid(toolId);
							_ = 1;
							if (!KgGeYicUQhGcJoFOgJ4())
							{
								num3 = 9;
								if (KgGeYicUQhGcJoFOgJ4())
								{
								}
							}
							else
							{
								num3 = 8;
							}
							goto IL_0175;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0146;
						IL_0175:
						while (true)
						{
							switch (num3)
							{
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								continue;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 0:
							case 9:
								awaiter = readAdapterBase.lN1xm9iodY.GetResultAsync(toolId, gUhpaqcQl169XippkWS(readAdapterBase.CancellationSource)).GetAwaiter();
								num3 = 7;
								if (KgGeYicUQhGcJoFOgJ4())
								{
								}
								continue;
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								if (H0fOpAch2TyIa30yPnv())
								{
									continue;
								}
								return;
							case 3:
								return;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									if (H0fOpAch2TyIa30yPnv())
									{
										continue;
									}
									break;
								}
								goto case 10;
							case 6:
							case 8:
								break;
							case 2:
								_003C_003Eu__1 = awaiter;
								goto case 1;
							default:
								num3 = 1;
								continue;
							case 10:
								result = awaiter.GetResult();
								goto end_IL_0175;
							}
							goto IL_0146;
							continue;
							end_IL_0175:
							break;
						}
						goto end_IL_0062;
						IL_0146:
						_003C_003Eu__1 = default;
						num3 = 5;
						goto IL_0175;
						end_IL_0062:;
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
		internal static CancellationToken gUhpaqcQl169XippkWS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CancellationTokenSource)P_0).Token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool H0fOpAch2TyIa30yPnv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KgGeYicUQhGcJoFOgJ4()
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
	private struct _003CGetCharacters_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IResultCharacters> _003C_003Et__builder;

		public ReadAdapterBase _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<ELReadResult> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			PAoWqPcqVDH57DTy6vI();
			int num = ((!gO56aHcVgtUDk6cIKF7()) ? 1 : 2);
			ReadAdapterBase readAdapterBase = default;
			int num2 = default;
			IResultCharacters result2 = default;
			Character item = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						TaskAwaiter<ELReadResult> awaiter;
						if (num2 != 0)
						{
							readAdapterBase.ThrowIfToolIdInvalid(toolId);
							awaiter = readAdapterBase.VWix7xX9fI.GetResultAsync(toolId, bHIZDNcioufbGqFyLBp(readAdapterBase.CancellationSource)).GetAwaiter();
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
						ELReadResult result = awaiter.GetResult();
						if (result?.Characters == null)
						{
							result2 = null;
						}
						else
						{
							ResultCharacters resultCharacters = new ResultCharacters();
							List<ELReadCharacterResult>.Enumerator enumerator = result.Characters.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									ELReadCharacterResult current = enumerator.Current;
									_ = 0;
									int num3 = ((!PAoWqPcqVDH57DTy6vI()) ? 2 : 3);
									while (true)
									{
										switch (num3)
										{
										default:
											goto IL_0108;
										case 0:
										case 3:
										{
											Character character = new Character
											{
												Text = (TFlnoNcLhInbiQpvNmf(current.Character) ? ' ' : current.Character.First())
											};
											QdkOR4c9FQk6v5wfeir(character, FaqhJIctHpgZdc43ZRA(current));
											WAmeOvcZ7hDqQfV5IiX(character, kyqa0TcvOcHuWAYmDaW(current));
											JDv2ulcONUSie3LQLro(character, readAdapterBase.TTPxHKVTnE(dI8mZDc0U7XhZBFd06s(current)));
											item = character;
											goto IL_0108;
										}
										case 4:
											break;
										}
										break;
										IL_0108:
										resultCharacters.Characters.Add(item);
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
							result2 = resultCharacters;
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
					_003C_003Et__builder.SetResult(result2);
					num = 6;
					break;
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					break;
				case 4:
					readAdapterBase = _003C_003E4__this;
					num = 5;
					if (1 == 0)
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
		internal static CancellationToken bHIZDNcioufbGqFyLBp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CancellationTokenSource)P_0).Token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TFlnoNcLhInbiQpvNmf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.IsNullOrEmpty((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double FaqhJIctHpgZdc43ZRA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELReadCharacterResult)P_0).CenterX;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void QdkOR4c9FQk6v5wfeir(object P_0, double P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CharacterBase)P_0).CenterX = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double kyqa0TcvOcHuWAYmDaW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELReadCharacterResult)P_0).CenterY;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WAmeOvcZ7hDqQfV5IiX(object P_0, double P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CharacterBase)P_0).CenterY = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double dI8mZDc0U7XhZBFd06s(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELReadCharacterResult)P_0).Score;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void JDv2ulcONUSie3LQLro(object P_0, double P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Character)P_0).Confidence = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PAoWqPcqVDH57DTy6vI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gO56aHcVgtUDk6cIKF7()
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
	private struct _003CGetToolResultAsync_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ELReadResult> _003C_003Et__builder;

		public ReadAdapterBase _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<ELReadResult> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!Px6TqucThf6JWIATq3U())
			{
				num = 4;
			}
			else
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_004e;
				}
			}
			goto IL_01f1;
			IL_01f1:
			int num2 = default;
			ReadAdapterBase readAdapterBase = default;
			TaskAwaiter<ELReadResult> awaiter = default;
			ELReadResult result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 1:
					readAdapterBase = _003C_003E4__this;
					goto case 2;
				case 5:
					break;
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							readAdapterBase.ThrowIfToolIdInvalid(toolId);
							_ = 0;
							if (NHjSX9cHYIXH7wulJYw())
							{
								num3 = 3;
								if (1 == 0)
								{
									return;
								}
							}
							else
							{
								num3 = 1;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
							if (false)
							{
								goto IL_00a6;
							}
						}
						goto IL_013e;
						IL_013e:
						while (true)
						{
							switch (num3)
							{
							case 6:
								return;
							case 7:
								break;
							case 0:
							case 3:
								awaiter = readAdapterBase.VWix7xX9fI.GetResultAsync(toolId, TTjerscYkZ4uKiLgrnj(readAdapterBase.CancellationSource)).GetAwaiter();
								num3 = 9;
								if (Px6TqucThf6JWIATq3U())
								{
								}
								continue;
							default:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								if (true)
								{
									continue;
								}
								goto case 5;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 8;
								if (NHjSX9cHYIXH7wulJYw())
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Eu__1 = awaiter;
								goto default;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									if (!Px6TqucThf6JWIATq3U())
									{
										continue;
									}
								}
								goto case 10;
							case 10:
								result = awaiter.GetResult();
								goto end_IL_013e;
							}
							goto IL_00a6;
							continue;
							end_IL_013e:
							break;
						}
						goto end_IL_0064;
						IL_00a6:
						num2 = (_003C_003E1__state = 0);
						num3 = 2;
						goto IL_013e;
						end_IL_0064:;
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
				case 6:
					return;
				}
				break;
			}
			goto IL_004e;
			IL_004e:
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_01f1;
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
		internal static CancellationToken TTjerscYkZ4uKiLgrnj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CancellationTokenSource)P_0).Token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NHjSX9cHYIXH7wulJYw()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Px6TqucThf6JWIATq3U()
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
	private struct _003CGetFieldingResult_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<FieldingResult> _003C_003Et__builder;

		public ReadAdapterBase _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<ELReadResult> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			uUoUUmcKp5HMZqkYUTQ();
			int num = ((!wKYi0ccJ4dwquCkfIbb()) ? 1 : 2);
			int num2 = default;
			ReadAdapterBase readAdapterBase = default;
			TaskAwaiter<ELReadResult> awaiter = default;
			ELReadResult result = default;
			FieldingResult result2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							readAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 5;
							goto IL_008c;
						}
						awaiter = _003C_003Eu__1;
						goto IL_00f2;
						IL_00f2:
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 8;
						if (!uUoUUmcKp5HMZqkYUTQ())
						{
							goto IL_008c;
						}
						goto IL_0117;
						IL_0117:
						if (result == null)
						{
							num3 = 6;
							if (wKYi0ccJ4dwquCkfIbb())
							{
								goto IL_008c;
							}
							goto IL_012d;
						}
						object obj = result.FieldingResult;
						goto IL_0181;
						IL_008c:
						while (true)
						{
							switch (num3)
							{
							case 5:
								awaiter = readAdapterBase.GetToolResultAsync(toolId).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto IL_012d;
							case 4:
								return;
							default:
								num3 = 10;
								continue;
							case 7:
								break;
							case 10:
								goto end_IL_008c;
							case 3:
								goto IL_0117;
							case 8:
								goto IL_012d;
							case 1:
							case 9:
								goto IL_013f;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								continue;
							case 2:
							case 11:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 6:
								goto IL_0175;
							case 12:
								goto end_IL_0028;
							}
							num2 = (_003C_003E1__state = 0);
							wKYi0ccJ4dwquCkfIbb();
							num3 = (uUoUUmcKp5HMZqkYUTQ() ? 1 : 11);
							continue;
							end_IL_008c:
							break;
						}
						goto IL_00f2;
						IL_012d:
						result = awaiter.GetResult();
						num3 = 3;
						goto IL_008c;
						IL_0181:
						ELReadFieldingResult eLReadFieldingResult = (ELReadFieldingResult)obj;
						if (eLReadFieldingResult == null)
						{
							goto IL_013f;
						}
						FieldingResult fieldingResult = new FieldingResult();
						uno08xcAHgMbKhDbBtL(fieldingResult, nHkrV4cCaKUoGxL3BwU(eLReadFieldingResult));
						pKhhZGcNjDCKaF8Eg5G(fieldingResult, eLReadFieldingResult.PatternName);
						D4n9WycpSHoU6ULxBuQ(fieldingResult, odNZQbcwhkMdKmaLBIs(result));
						result2 = fieldingResult;
						goto end_IL_0028;
						IL_013f:
						result2 = null;
						num3 = 12;
						goto IL_008c;
						IL_0175:
						obj = null;
						goto IL_0181;
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
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 5;
					if (wKYi0ccJ4dwquCkfIbb())
					{
						continue;
					}
					goto case 5;
				case 5:
					readAdapterBase = _003C_003E4__this;
					num = 4;
					continue;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult(result2);
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
		internal static bool nHkrV4cCaKUoGxL3BwU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELReadFieldingResult)P_0).Matches;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void uno08xcAHgMbKhDbBtL(object P_0, bool P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((FieldingResult)P_0).Match = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void pKhhZGcNjDCKaF8Eg5G(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((FieldingResult)P_0).PatternName = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object odNZQbcwhkMdKmaLBIs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELReadResult)P_0).String;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void D4n9WycpSHoU6ULxBuQ(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((FieldingResult)P_0).Text = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wKYi0ccJ4dwquCkfIbb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uUoUUmcKp5HMZqkYUTQ()
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
	private struct _003CGetCharacterSize_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CharacterSize> _003C_003Et__builder;

		public ReadAdapterBase _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<CogSize> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			V7OAOhcRc3vP5SN21yn();
			int num;
			if (awWHJWcGAfI8kd4KFdk())
			{
				num = 5;
			}
			else
			{
				num = 4;
				if (V7OAOhcRc3vP5SN21yn())
				{
				}
			}
			ReadAdapterBase readAdapterBase = default;
			CharacterSize result2 = default;
			int num2 = default;
			TaskAwaiter<CogSize> awaiter = default;
			CogSize result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					readAdapterBase = _003C_003E4__this;
					num = 2;
					if (!V7OAOhcRc3vP5SN21yn())
					{
						break;
					}
					goto case 3;
				case 3:
					_003C_003Et__builder.SetResult(result2);
					num = 6;
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							readAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 0;
							if (false)
							{
								goto IL_0094;
							}
							goto IL_0178;
						}
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						if (true)
						{
							goto IL_0178;
						}
						goto end_IL_0076;
						IL_0178:
						while (true)
						{
							switch (num3)
							{
							case 8:
								break;
							case 4:
							{
								if (result == null)
								{
									num3 = 3;
									continue;
								}
								CharacterSize characterSize = new CharacterSize();
								TT74y6cWLveCou9CeJi(characterSize, nqjXkDcIGGvOQPMibYO(result));
								MEIU4McbqPCEgBJdex9(characterSize, result.Width);
								result2 = characterSize;
								goto end_IL_0178;
							}
							case 3:
								readAdapterBase.GrlxLkpv53 = true;
								num3 = 11;
								continue;
							case 10:
								result = awaiter.GetResult();
								num3 = 4;
								continue;
							case 6:
								if (awaiter.IsCompleted)
								{
									goto case 10;
								}
								V7OAOhcRc3vP5SN21yn();
								if (awWHJWcGAfI8kd4KFdk())
								{
									num3 = 1;
									if (0 == 0)
									{
										continue;
									}
									goto case 11;
								}
								num3 = 9;
								continue;
							case 11:
								result2 = readAdapterBase.pndxdC9u2D;
								num3 = 12;
								continue;
							case 1:
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								if (awWHJWcGAfI8kd4KFdk())
								{
									continue;
								}
								goto case 0;
							case 0:
								awaiter = readAdapterBase.qxAxS5r2Ms.GetResultAsync(toolId, N9DiyJcjsmqJdqyildl(readAdapterBase.CancellationSource)).GetAwaiter();
								num3 = 6;
								continue;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								return;
							case 9:
								return;
							case 12:
								goto end_IL_0178;
							}
							goto IL_0094;
							continue;
							end_IL_0178:
							break;
						}
						goto end_IL_0076;
						IL_0094:
						_003C_003Eu__1 = awaiter;
						num3 = 7;
						goto IL_0178;
						end_IL_0076:;
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
		internal static CancellationToken N9DiyJcjsmqJdqyildl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CancellationTokenSource)P_0).Token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double nqjXkDcIGGvOQPMibYO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CogSize)P_0).Height;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void TT74y6cWLveCou9CeJi(object P_0, double P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CharacterSize)P_0).Height = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MEIU4McbqPCEgBJdex9(object P_0, double P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CharacterSize)P_0).Width = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool awWHJWcGAfI8kd4KFdk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool V7OAOhcRc3vP5SN21yn()
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
	private struct _003CSetCharacterSize_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ReadAdapterBase _003C_003E4__this;

		public string toolId;

		public CharacterSize newCharacterSize;

		private TaskAwaiter<CharacterSize> _003C_003Eu__1;

		private TaskAwaiter<object> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!OhLZDhclHWjhqA5yZsZ())
			{
				num = 5;
			}
			else
			{
				num = 3;
				if (!wI0G3ice08OCWvuAO9P())
				{
					goto IL_0054;
				}
			}
			goto IL_0459;
			IL_0054:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (1 == 0)
			{
				goto IL_006b;
			}
			goto IL_0459;
			IL_006b:
			int num2 = default;
			ReadAdapterBase readAdapterBase = default;
			try
			{
				int num3;
				TaskAwaiter awaiter3 = default;
				TaskAwaiter<object> awaiter2 = default;
				TaskAwaiter<CharacterSize> awaiter = default;
				switch (num2)
				{
				default:
					readAdapterBase.ThrowIfToolIdInvalid(toolId);
					num3 = 19;
					break;
				case 2:
					awaiter3 = _003C_003Eu__3;
					num3 = 8;
					break;
				case 1:
					awaiter2 = _003C_003Eu__2;
					num3 = 11;
					break;
				case 0:
					awaiter = _003C_003Eu__1;
					num3 = 18;
					break;
				}
				CharacterSize result = default;
				CogSize arg = default;
				ResourceNode resourceNode = default;
				while (true)
				{
					switch (num3)
					{
					case 6:
						result = awaiter.GetResult();
						num3 = 4;
						continue;
					case 20:
						arg = new CogSize
						{
							Height = newCharacterSize.Height,
							Width = Rpy88pcyElGHCM7Aosy(newCharacterSize)
						};
						goto case 9;
					default:
						num3 = 9;
						if (0 == 0)
						{
							continue;
						}
						return;
					case 15:
						return;
					case 23:
						return;
					case 7:
						num2 = (_003C_003E1__state = 0);
						num3 = 22;
						continue;
					case 12:
						num2 = (_003C_003E1__state = -1);
						goto IL_0193;
					case 18:
						_003C_003Eu__1 = default;
						num3 = 14;
						continue;
					case 21:
						num2 = (_003C_003E1__state = 2);
						num3 = 0;
						continue;
					case 11:
						_003C_003Eu__2 = default;
						num3 = 12;
						if (wI0G3ice08OCWvuAO9P())
						{
							continue;
						}
						goto case 3;
					case 3:
						if (!awaiter.IsCompleted)
						{
							num3 = 7;
							continue;
						}
						goto case 6;
					case 4:
						if (!readAdapterBase.GrlxLkpv53)
						{
							num3 = 25;
							continue;
						}
						goto IL_0328;
					case 10:
						readAdapterBase.ClearCaches(toolId);
						num3 = 5;
						continue;
					case 2:
					case 16:
						_003C_003Eu__2 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						num3 = 1;
						if (true)
						{
							continue;
						}
						goto case 22;
					case 22:
						_003C_003Eu__1 = awaiter;
						num3 = 24;
						continue;
					case 0:
						_003C_003Eu__3 = awaiter3;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					case 1:
						return;
					case 19:
						awaiter = readAdapterBase.GetCharacterSize(toolId).GetAwaiter();
						num3 = 3;
						continue;
					case 8:
						_003C_003Eu__3 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 27;
						continue;
					case 24:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 17:
						if (lhY2RCcnJwvCMtGimrQ(Rpy88pcyElGHCM7Aosy(result), newCharacterSize.Width, 0.001))
						{
							goto end_IL_00df;
						}
						goto IL_0328;
					case 25:
						if (result == null)
						{
							goto IL_0328;
						}
						num3 = 13;
						if (true)
						{
							continue;
						}
						goto case 9;
					case 9:
						resourceNode = (ResourceNode)ihsPROcfrpTBt6RPPvm(readAdapterBase, toolId);
						num3 = 10;
						continue;
					case 5:
						awaiter2 = resourceNode.PutAsync<object>((string)ondDNDczbCgsFWGyCNY(7432), arg).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num2 = (_003C_003E1__state = 1);
							OhLZDhclHWjhqA5yZsZ();
							num3 = (wI0G3ice08OCWvuAO9P() ? 2 : 15);
							continue;
						}
						goto IL_0193;
					case 14:
						num2 = (_003C_003E1__state = -1);
						num3 = 6;
						continue;
					case 13:
						if (!CvsMath.AreEpsilonEqual(result.Height, rIZgogc70W17nbBj6Kw(newCharacterSize), 0.001))
						{
							goto IL_0328;
						}
						num3 = 17;
						if (0 == 0)
						{
							continue;
						}
						goto case 26;
					case 26:
						awaiter3 = vi6HZPu2I5aqZ1qC9f6(readAdapterBase.Hscx6raHrH(toolId));
						if (!awaiter3.IsCompleted)
						{
							num3 = 21;
							continue;
						}
						break;
					case 27:
						break;
						IL_0193:
						awaiter2.GetResult();
						num3 = 26;
						if (0 == 0)
						{
							continue;
						}
						goto case 18;
						IL_0328:
						readAdapterBase.GrlxLkpv53 = false;
						num3 = 20;
						continue;
					}
					awaiter3.GetResult();
					break;
					continue;
					end_IL_00df:
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
			goto IL_0054;
			IL_0459:
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					readAdapterBase = _003C_003E4__this;
					num = 2;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					break;
				case 2:
					goto IL_006b;
				default:
					num = 4;
					if (true)
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_0054;
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
		internal static double rIZgogc70W17nbBj6Kw(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CharacterSize)P_0).Height;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double Rpy88pcyElGHCM7Aosy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CharacterSize)P_0).Width;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lhY2RCcnJwvCMtGimrQ(double P_0, double P_1, double P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsMath.AreEpsilonEqual(P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ihsPROcfrpTBt6RPPvm(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ViDiELAdapterBase)P_0).GetToolNode((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ondDNDczbCgsFWGyCNY(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter vi6HZPu2I5aqZ1qC9f6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wI0G3ice08OCWvuAO9P()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OhLZDhclHWjhqA5yZsZ()
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
	private struct _003CAcceptLabeling_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ReadAdapterBase _003C_003E4__this;

		public string toolId;

		public ICollection<RevisedCharacter> revisedCharacters;

		private int _003CmaxImagesErrorCode_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			MoM6g2uMNADclmyNkig();
			int num = ((!Gj3x39uXaPdeO4dW1Oj()) ? 2 : 4);
			int num2 = default;
			ReadAdapterBase readAdapterBase = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						if (num2 != 0)
						{
							_003CmaxImagesErrorCode_003E5__2 = -1610354919;
							readAdapterBase.ThrowIfToolIdInvalid(toolId);
							if (revisedCharacters == null)
							{
								throw new ArgumentNullException((string)x6oCA1uknS5MPoyOf4F(7462));
							}
						}
						try
						{
							TaskAwaiter awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = OBMrVXum9tushHLGi9a(readAdapterBase.F0vxn6Tkdv(toolId, revisedCharacters));
								num3 = 4;
								if (!Gj3x39uXaPdeO4dW1Oj())
								{
									return;
								}
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
								case 7:
									return;
								case 0:
								case 1:
									num2 = (_003C_003E1__state = 0);
									num3 = 2;
									continue;
								case 3:
								case 6:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									continue;
								case 5:
									_003C_003Eu__1 = default;
									goto case 3;
								case 2:
									_003C_003Eu__1 = awaiter;
									num3 = 8;
									if (!MoM6g2uMNADclmyNkig())
									{
										continue;
									}
									goto case 4;
								case 4:
									if (!awaiter.IsCompleted)
									{
										Gj3x39uXaPdeO4dW1Oj();
										num3 = (MoM6g2uMNADclmyNkig() ? 3 : 0);
										continue;
									}
									break;
								case 8:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 7;
									continue;
								case 9:
									break;
								}
								break;
							}
							awaiter.GetResult();
						}
						catch (CvsErrorResponseNetworkException ex) when (ex.ErrorCode == _003CmaxImagesErrorCode_003E5__2)
						{
							zD4gCwu4bH3gnPRVHc6(KG7e8jurbpyeHXOtu7v(ex), h14MiKuP6BRFsEPX6SR(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
				case 1:
					readAdapterBase = _003C_003E4__this;
					num = 5;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
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
		internal static object x6oCA1uknS5MPoyOf4F(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter OBMrVXum9tushHLGi9a(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KG7e8jurbpyeHXOtu7v(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Exception)P_0).Message;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object h14MiKuP6BRFsEPX6SR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ViDiELReadError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DialogResult zD4gCwu4bH3gnPRVHc6(object P_0, object P_1, MessageBoxButtons P_2, MessageBoxIcon P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MessageBox.Show((string)P_0, (string)P_1, P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Gj3x39uXaPdeO4dW1Oj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MoM6g2uMNADclmyNkig()
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
	private struct _003CChangeSample_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ReadAdapterBase _003C_003E4__this;

		public string toolId;

		public ICollection<RevisedCharacter> revisedCharacters;

		public string sampleId;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			vSLme3u1401OpnPaxTq();
			int num;
			if (gu8Zn8ugXMg1k1bvOHo())
			{
				num = 5;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 1;
			}
			goto IL_0202;
			IL_002a:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (vSLme3u1401OpnPaxTq())
			{
			}
			goto IL_0202;
			IL_0202:
			ReadAdapterBase readAdapterBase = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 3:
					readAdapterBase = _003C_003E4__this;
					goto case 1;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 3;
					continue;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							readAdapterBase.ThrowIfToolIdInvalid(toolId);
							_ = 1;
							num3 = (vSLme3u1401OpnPaxTq() ? 6 : 9);
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
							case 9:
								if (revisedCharacters == null)
								{
									num3 = 3;
									continue;
								}
								awaiter = mwmPKguSOWXtIHLxV9k(readAdapterBase.F0vxn6Tkdv(toolId, revisedCharacters, sampleId));
								num3 = 4;
								continue;
							case 3:
								throw new ArgumentNullException(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(7462));
							case 1:
								_003C_003Eu__1 = awaiter;
								goto case 5;
							default:
								num3 = 5;
								continue;
							case 8:
								return;
							case 6:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (!vSLme3u1401OpnPaxTq())
								{
									continue;
								}
								goto case 4;
							case 4:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								if (!vSLme3u1401OpnPaxTq())
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Eu__1 = default;
								goto case 6;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
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
					break;
				default:
					num = 4;
					if (vSLme3u1401OpnPaxTq())
					{
					}
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
		internal static TaskAwaiter mwmPKguSOWXtIHLxV9k(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gu8Zn8ugXMg1k1bvOHo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vSLme3u1401OpnPaxTq()
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
	private struct _003CDeleteSamples_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ReadAdapterBase _003C_003E4__this;

		public string toolId;

		public string[] samplesIds;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			ReadAdapterBase readAdapterBase = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<object> awaiter2 = default;
			ResourceNode toolNode = default;
			IEnumerable<string> enumerable = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					readAdapterBase = _003C_003E4__this;
					num = 5;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
					num2 = _003C_003E1__state;
					_ = 0;
					if (kaJhrKu60bBqK16R06M())
					{
						num = 4;
						break;
					}
					num = 0;
					if (EuKnfWuDEJ2r1ZHikia())
					{
					}
					break;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 13;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 0;
								if (!kaJhrKu60bBqK16R06M())
								{
									goto IL_00cc;
								}
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 10;
						}
						goto IL_0212;
						IL_0212:
						while (true)
						{
							switch (num3)
							{
							case 12:
								break;
							case 3:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter;
								num3 = 16;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 14:
								return;
							case 10:
								goto end_IL_0212;
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 11;
								continue;
							case 9:
								awaiter = readAdapterBase.Hscx6raHrH(toolId).GetAwaiter();
								num3 = 6;
								continue;
							case 0:
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
								if (true)
								{
									continue;
								}
								goto case 7;
							case 7:
								toolNode = readAdapterBase.GetToolNode(toolId);
								num3 = 2;
								continue;
							default:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							case 13:
								readAdapterBase.ThrowIfToolIdInvalid(toolId);
								num3 = 7;
								if (kaJhrKu60bBqK16R06M())
								{
									continue;
								}
								goto case 1;
							case 1:
							case 4:
								awaiter2 = toolNode.PostAsync<object>((string)gmMTZ6u8kU5xcRKLHnj(7200), new object[1] { enumerable }).GetAwaiter();
								num3 = 12;
								if (!EuKnfWuDEJ2r1ZHikia())
								{
									continue;
								}
								goto case 15;
							case 15:
								enumerable = samplesIds;
								kaJhrKu60bBqK16R06M();
								num3 = ((!EuKnfWuDEJ2r1ZHikia()) ? 1 : 17);
								continue;
							case 11:
								_003C_003Eu__1 = awaiter2;
								goto default;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 18;
							case 2:
								readAdapterBase.ClearCaches(toolId);
								num3 = 15;
								continue;
							case 16:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 14;
								continue;
							case 18:
								awaiter.GetResult();
								goto end_IL_005b;
							}
							if (!awaiter2.IsCompleted)
							{
								num3 = 5;
								if (EuKnfWuDEJ2r1ZHikia())
								{
								}
								continue;
							}
							goto IL_00d5;
							continue;
							end_IL_0212:
							break;
						}
						goto IL_00cc;
						IL_00cc:
						num2 = (_003C_003E1__state = -1);
						goto IL_00d5;
						IL_00d5:
						awaiter2.GetResult();
						num3 = 9;
						if (EuKnfWuDEJ2r1ZHikia())
						{
						}
						goto IL_0212;
						end_IL_005b:;
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
		internal static object gmMTZ6u8kU5xcRKLHnj(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kaJhrKu60bBqK16R06M()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EuKnfWuDEJ2r1ZHikia()
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
	private struct _003CGetFielding_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<FieldingSettings> _003C_003Et__builder;

		public ReadAdapterBase _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_032e;
			IL_001a:
			int num2 = default;
			ReadAdapterBase readAdapterBase = default;
			FieldingSettings result = default;
			try
			{
				int num3;
				if (num2 != 0)
				{
					readAdapterBase.ThrowIfToolIdInvalid(toolId);
					num3 = 3;
					goto IL_0073;
				}
				TaskAwaiter<object> awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default;
				goto IL_0036;
				IL_0036:
				num2 = (_003C_003E1__state = -1);
				num3 = 16;
				goto IL_0073;
				IL_0073:
				ELReadAdvancedFielding eLReadAdvancedFielding = default;
				FieldingPattern[] array = default;
				ELReadBasicFielding eLReadBasicFielding = default;
				object result2 = default;
				ELReadFlexibleFielding eLReadFlexibleFielding = default;
				while (true)
				{
					switch (num3)
					{
					case 4:
					case 15:
						break;
					case 10:
						if (eLReadAdvancedFielding == null)
						{
							num3 = 6;
							continue;
						}
						array = eLReadAdvancedFielding.Patterns.Select(readAdapterBase.EwmxpnkILb).ToArray();
						num3 = 12;
						if (mn5c60uFXPn9GCruZDV())
						{
							continue;
						}
						goto case 1;
					case 2:
					{
						if (eLReadBasicFielding == null)
						{
							goto case 14;
						}
						FieldingSettings fieldingSettings3 = new FieldingSettings();
						Pviw8Cu54A1QiMsn013(fieldingSettings3, BdQKo7uEd8ZfNBnn92N(7500));
						fieldingSettings3.NumberOfLines = ((mmjRqIu3wZJASgUXcW8(eLReadBasicFielding) > 0) ? new int?(mmjRqIu3wZJASgUXcW8(eLReadBasicFielding)) : ((int?)null));
						A3IudvuoiUkHNILAviQ(fieldingSettings3, ioNpGIuahkBagBrMwhG(eLReadBasicFielding.CharacterClass));
						result = fieldingSettings3;
						goto end_IL_0073;
					}
					default:
						num3 = 14;
						continue;
					case 3:
						awaiter = readAdapterBase.Kq5xK3vuQX.GetResultAsync(toolId, GP0G6IudA2UFWdZuvm9(readAdapterBase.CancellationSource)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							_ = 1;
							if (!QqmoJYusveHDbfa9Rnc())
							{
								num3 = 11;
								continue;
							}
							num3 = 15;
							if (0 == 0)
							{
								continue;
							}
						}
						goto case 16;
					case 9:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 16:
						result2 = awaiter.GetResult();
						num3 = 0;
						if (QqmoJYusveHDbfa9Rnc())
						{
						}
						continue;
					case 0:
						eLReadBasicFielding = result2 as ELReadBasicFielding;
						num3 = 2;
						continue;
					case 14:
						eLReadAdvancedFielding = result2 as ELReadAdvancedFielding;
						num3 = 10;
						continue;
					case 1:
					case 11:
						num2 = (_003C_003E1__state = 0);
						num3 = 8;
						if (mn5c60uFXPn9GCruZDV())
						{
							continue;
						}
						goto end_IL_0073;
					case 7:
						goto end_IL_0073;
					case 8:
						_003C_003Eu__1 = awaiter;
						num3 = 9;
						continue;
					case 12:
					{
						FieldingSettings fieldingSettings = new FieldingSettings();
						Pviw8Cu54A1QiMsn013(fieldingSettings, BdQKo7uEd8ZfNBnn92N(7520));
						fieldingSettings.NumberOfLines = null;
						fieldingSettings.AcceptedCharacters = "";
						F9N1InuchB6S3O9DIYK(fieldingSettings, array);
						result = fieldingSettings;
						num3 = 7;
						if (true)
						{
							continue;
						}
						goto case 13;
					}
					case 13:
						if (eLReadFlexibleFielding != null)
						{
							FieldingSettings fieldingSettings2 = new FieldingSettings();
							Pviw8Cu54A1QiMsn013(fieldingSettings2, BdQKo7uEd8ZfNBnn92N(7534));
							wN5s7vuBc5jTRNutR93(fieldingSettings2, VI82xbuuR8onjZiHo10(eLReadFlexibleFielding));
							result = fieldingSettings2;
							num3 = 17;
							if (QqmoJYusveHDbfa9Rnc())
							{
							}
						}
						else
						{
							num3 = 5;
						}
						continue;
					case 6:
						eLReadFlexibleFielding = result2 as ELReadFlexibleFielding;
						num3 = 13;
						if (mn5c60uFXPn9GCruZDV())
						{
							continue;
						}
						goto end_IL_0073;
					case 17:
						goto end_IL_0073;
					case 5:
						result = null;
						goto end_IL_0073;
					}
					goto IL_0036;
					continue;
					end_IL_0073:
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
			goto IL_0372;
			IL_032e:
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 1:
				case 4:
					readAdapterBase = _003C_003E4__this;
					num = 0;
					if (0 == 0)
					{
						continue;
					}
					goto IL_0372;
				default:
					goto IL_0372;
				case 2:
					goto IL_0388;
				case 6:
					return;
				}
				break;
				IL_0388:
				num2 = _003C_003E1__state;
				_ = 1;
				if (QqmoJYusveHDbfa9Rnc())
				{
					num = 5;
					continue;
				}
				num = 4;
				if (false)
				{
					return;
				}
			}
			goto IL_001a;
			IL_0372:
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_032e;
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
		internal static CancellationToken GP0G6IudA2UFWdZuvm9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CancellationTokenSource)P_0).Token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BdQKo7uEd8ZfNBnn92N(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Pviw8Cu54A1QiMsn013(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((FieldingSettings)P_0).FieldingType = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int mmjRqIu3wZJASgUXcW8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELReadBasicFielding)P_0).NumLines;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ioNpGIuahkBagBrMwhG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FieldingPatternParser.CharacterClassToBasicString((ELReadFieldingCharacterClass)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void A3IudvuoiUkHNILAviQ(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((FieldingSettings)P_0).AcceptedCharacters = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void F9N1InuchB6S3O9DIYK(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((FieldingSettings)P_0).Patterns = (FieldingPattern[])P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VI82xbuuR8onjZiHo10(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELReadFlexibleFielding)P_0).FlexibleFieldingValue;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void wN5s7vuBc5jTRNutR93(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((FieldingSettings)P_0).FlexibleFieldingValue = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mn5c60uFXPn9GCruZDV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QqmoJYusveHDbfa9Rnc()
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
	private struct _003CSetFielding_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ReadAdapterBase _003C_003E4__this;

		public string toolId;

		public FieldingSettings fielding;

		private TaskAwaiter<object> _003C_003Eu__1;

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
			ReadAdapterBase readAdapterBase = default;
			TaskAwaiter<object> awaiter = default;
			TaskAwaiter awaiter2 = default;
			ELReadAdvancedFielding arg = default;
			Dictionary<string, ELReadPattern> dictionary = default;
			int num4 = default;
			ResourceNode resourceNode = default;
			FieldingPattern[] patterns = default;
			ELReadBasicFielding arg2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					if (iHN1DPuxwGilkUJAF1s())
					{
						break;
					}
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							readAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 35;
							goto IL_0342;
						case 1:
							awaiter = _003C_003Eu__1;
							num3 = 12;
							if (false)
							{
								goto IL_0088;
							}
							goto IL_0342;
						case 2:
							awaiter = _003C_003Eu__1;
							num3 = 1;
							if (1 == 0)
							{
								goto IL_00ff;
							}
							goto IL_0342;
						case 3:
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num3 = 14;
							if (!iHN1DPuxwGilkUJAF1s())
							{
								goto IL_02da;
							}
							goto IL_0342;
						case 0:
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 29;
								goto IL_0342;
							}
							IL_0342:
							while (true)
							{
								FieldingPattern fieldingPattern;
								switch (num3)
								{
								case 16:
									return;
								case 19:
									break;
								case 6:
									arg = new ELReadAdvancedFielding
									{
										Patterns = dictionary
									};
									num3 = 15;
									if (0 == 0)
									{
										continue;
									}
									goto case 9;
								case 9:
									num4++;
									goto IL_00d2;
								case 22:
									return;
								case 30:
									return;
								case 8:
									goto IL_00ff;
								case 18:
									readAdapterBase.ClearCaches(toolId);
									num3 = 19;
									if (iHN1DPuxwGilkUJAF1s())
									{
										continue;
									}
									goto case 13;
								case 13:
									num2 = (_003C_003E1__state = -1);
									goto IL_0135;
								case 28:
									goto IL_013d;
								case 35:
									resourceNode = (ResourceNode)DM3xF3uU0MyaIK8mN5l(readAdapterBase, toolId);
									num3 = 18;
									if (iHN1DPuxwGilkUJAF1s())
									{
										continue;
									}
									goto case 26;
								case 26:
									num2 = (_003C_003E1__state = -1);
									num3 = 0;
									continue;
								case 29:
									awaiter.GetResult();
									goto IL_013d;
								case 34:
									awaiter = resourceNode.PutAsync<object>(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(7554), new ELReadFlexibleFielding()).GetAwaiter();
									num3 = 25;
									continue;
								case 10:
									num2 = (_003C_003E1__state = 3);
									num3 = 7;
									continue;
								case 33:
									patterns = fielding.Patterns;
									num3 = 24;
									continue;
								case 32:
									readAdapterBase.UpdateFlexibleFielding((string)GNGxL8uVWlBFQAiRZY7(fielding));
									num3 = 34;
									continue;
								case 23:
								{
									ELReadBasicFielding eLReadBasicFielding = new ELReadBasicFielding();
									FYBtIVuZCWcgmliQGxG(eLReadBasicFielding, u4pGi8uv78U7uO2ePGH(L9PXLju9mXhJL5QVFM2(fielding)));
									EjSOfsu0oCX0NkbBCuh(eLReadBasicFielding, fielding.NumberOfLines.GetValueOrDefault());
									arg2 = eLReadBasicFielding;
									num3 = 5;
									continue;
								}
								case 36:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 3;
									if (iHN1DPuxwGilkUJAF1s())
									{
										continue;
									}
									goto case 7;
								case 7:
									_003C_003Eu__2 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								case 14:
									goto IL_02da;
								case 17:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 1);
										goto IL_00ff;
									}
									goto case 0;
								default:
									num3 = 8;
									if (iHN1DPuxwGilkUJAF1s())
									{
										continue;
									}
									goto case 1;
								case 1:
									_003C_003Eu__1 = default;
									num3 = 13;
									continue;
								case 25:
									if (awaiter.IsCompleted)
									{
										goto case 29;
									}
									num3 = 37;
									if (iHN1DPuxwGilkUJAF1s())
									{
										continue;
									}
									goto case 27;
								case 27:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 24:
									num4 = 0;
									goto IL_00d2;
								case 11:
								case 20:
									dictionary = new Dictionary<string, ELReadPattern>();
									num3 = 33;
									if (ztpfiOuhZba3XTfW00m())
									{
									}
									continue;
								case 37:
									num2 = (_003C_003E1__state = 0);
									num3 = 4;
									continue;
								case 5:
									awaiter = resourceNode.PutAsync<object>(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(7554), arg2).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num3 = 2;
										continue;
									}
									goto IL_0135;
								case 2:
									num2 = (_003C_003E1__state = 2);
									num3 = 31;
									continue;
								case 3:
									return;
								case 21:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 16;
									continue;
								case 31:
									_003C_003Eu__1 = awaiter;
									num3 = 27;
									continue;
								case 4:
									_003C_003Eu__1 = awaiter;
									num3 = 36;
									continue;
								case 12:
									_003C_003Eu__1 = default;
									num3 = 26;
									continue;
								case 15:
									awaiter = resourceNode.PutAsync<object>((string)mUh87ruQRubmmgwlE9U(7554), arg).GetAwaiter();
									num3 = 17;
									continue;
								case 0:
									awaiter.GetResult();
									num3 = 28;
									if (true)
									{
										continue;
									}
									goto end_IL_0045;
								case 38:
									goto end_IL_0045;
									IL_00d2:
									if (num4 >= patterns.Length)
									{
										num3 = 6;
										continue;
									}
									fieldingPattern = patterns[num4];
									dictionary.Add((string)Hj6gU9uL93XZBRR0ZGh(fieldingPattern), (ELReadPattern)reDB1GutAFJouY3WvJp(fieldingPattern.Pattern));
									num3 = 9;
									continue;
									IL_0135:
									awaiter.GetResult();
									goto IL_013d;
								}
								break;
							}
							goto IL_0088;
							IL_02da:
							num2 = (_003C_003E1__state = -1);
							num3 = 38;
							goto IL_0342;
							IL_00ff:
							_003C_003Eu__1 = awaiter;
							num3 = 21;
							goto IL_0342;
							IL_0088:
							if (M3OMg5uqPy9heX0280H(fielding.FieldingType, mUh87ruQRubmmgwlE9U(7534)))
							{
								num3 = 32;
							}
							else if (M3OMg5uqPy9heX0280H(lMnvOvuibMrUqEtQiim(fielding), plfGltUiaC1OFfC2I8.OIRNC4VQ7F(7520)))
							{
								_ = 0;
								num3 = ((!iHN1DPuxwGilkUJAF1s()) ? 22 : 20);
							}
							else
							{
								if (!M3OMg5uqPy9heX0280H(lMnvOvuibMrUqEtQiim(fielding), mUh87ruQRubmmgwlE9U(7500)))
								{
									goto IL_013d;
								}
								num3 = 23;
							}
							goto IL_0342;
							IL_013d:
							awaiter2 = ouAaAJuHM4RXkHQBh3H(bQoLeEuONCYLS0Cvfo5(readAdapterBase));
							if (awaiter2.IsCompleted)
							{
								break;
							}
							num3 = 10;
							goto IL_0342;
							end_IL_0045:
							break;
						}
						awaiter2.GetResult();
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
					readAdapterBase = _003C_003E4__this;
					_ = 0;
					if (!iHN1DPuxwGilkUJAF1s())
					{
						num = 0;
						break;
					}
					num = 1;
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
		internal static object DM3xF3uU0MyaIK8mN5l(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ViDiELAdapterBase)P_0).GetToolNode((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mUh87ruQRubmmgwlE9U(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool M3OMg5uqPy9heX0280H(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GNGxL8uVWlBFQAiRZY7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FieldingSettings)P_0).FlexibleFieldingValue;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lMnvOvuibMrUqEtQiim(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FieldingSettings)P_0).FieldingType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Hj6gU9uL93XZBRR0ZGh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FieldingPattern)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object reDB1GutAFJouY3WvJp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FieldingPatternParser.AdvancedStringToReadPattern((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object L9PXLju9mXhJL5QVFM2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FieldingSettings)P_0).AcceptedCharacters;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object u4pGi8uv78U7uO2ePGH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return FieldingPatternParser.BasicStringToCharacterClass((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void FYBtIVuZCWcgmliQGxG(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ELReadBasicFielding)P_0).CharacterClass = (ELReadFieldingCharacterClass)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void EjSOfsu0oCX0NkbBCuh(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ELReadBasicFielding)P_0).NumLines = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bQoLeEuONCYLS0Cvfo5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ViDiELAdapterBase)P_0).RunToolAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter ouAaAJuHM4RXkHQBh3H(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iHN1DPuxwGilkUJAF1s()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ztpfiOuhZba3XTfW00m()
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
	private struct _003CGetCharacterSizeFromCameraAsync_003Ed__42 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CogSize> _003C_003Et__builder;

		public ReadAdapterBase _003C_003E4__this;

		public string toolId;

		public CancellationToken token;

		private TaskAwaiter<CogSize> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!vGk06AuYFWVBJKLhOhi())
			{
				num = 2;
			}
			else
			{
				num = 5;
				if (false)
				{
					return;
				}
			}
			CogSize result = default;
			ReadAdapterBase readAdapterBase = default;
			int num2 = default;
			TaskAwaiter<CogSize> awaiter = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (vGk06AuYFWVBJKLhOhi())
					{
					}
					break;
				case 1:
					readAdapterBase = _003C_003E4__this;
					num = 4;
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 1;
					if (0 == 0)
					{
						break;
					}
					goto case 4;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							readAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 0;
							if (vGk06AuYFWVBJKLhOhi())
							{
								goto IL_008a;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
						}
						goto IL_00a3;
						IL_00a3:
						while (true)
						{
							switch (num3)
							{
							case 3:
							case 9:
								break;
							case 2:
								return;
							case 1:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								goto IL_012b;
							default:
								goto IL_012b;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto case 10;
							case 0:
							{
								object obj = aJfqH7uJlwFYU5wcjAO(readAdapterBase, toolId);
								token.ThrowIfCancellationRequested();
								awaiter = ((ResourceNode)obj).GetAsync<CogSize>((string)QEv38VuKLjqWrqfjWJg(7432)).GetAwaiter();
								num3 = 8;
								continue;
							}
							case 7:
								goto IL_018f;
							case 10:
								result = awaiter.GetResult();
								goto end_IL_0068;
							}
							break;
							IL_018f:
							num2 = (_003C_003E1__state = 0);
							vGk06AuYFWVBJKLhOhi();
							if (!tnKBr5uTy3tHNKTuuSA())
							{
								num3 = 5;
								if (vGk06AuYFWVBJKLhOhi())
								{
									return;
								}
							}
							else
							{
								num3 = 9;
							}
						}
						goto IL_008a;
						IL_012b:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 2;
						goto IL_00a3;
						IL_008a:
						_003C_003Eu__1 = awaiter;
						goto IL_012b;
						end_IL_0068:;
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
		internal static object aJfqH7uJlwFYU5wcjAO(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ViDiELAdapterBase)P_0).GetToolNode((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QEv38VuKLjqWrqfjWJg(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tnKBr5uTy3tHNKTuuSA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vGk06AuYFWVBJKLhOhi()
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
	private struct _003CGetFieldingFromCameraAsync_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<object> _003C_003Et__builder;

		public ReadAdapterBase _003C_003E4__this;

		public string toolId;

		public CancellationToken token;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!xWk5tCuCEPgUES2YueN()) ? 5 : 3);
			object result = default;
			int num2 = default;
			ReadAdapterBase readAdapterBase = default;
			TaskAwaiter<object> awaiter = default;
			do
			{
				IL_01bd:
				switch (num)
				{
				case 2:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					goto IL_01bd;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							readAdapterBase.ThrowIfToolIdInvalid(toolId);
							_ = 1;
							if (!mimcSOuAb5jCvGZvmNf())
							{
								num3 = 1;
								if (false)
								{
									goto IL_0064;
								}
							}
							else
							{
								num3 = 5;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
						}
						goto IL_00f6;
						IL_0064:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 9;
						goto IL_00f6;
						IL_00f6:
						while (true)
						{
							switch (num3)
							{
							case 3:
								break;
							case 9:
								return;
							case 4:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 0:
							case 1:
							{
								object obj = aDc94iuNphrok39COOk(readAdapterBase, toolId);
								token.ThrowIfCancellationRequested();
								awaiter = ((ResourceNode)obj).GetAsync<object>((string)pDw43guwrne1QTsfWPj(7554)).GetAwaiter();
								num3 = 2;
								if (0 == 0)
								{
									continue;
								}
								goto case 8;
							}
							case 8:
								_003C_003Eu__1 = awaiter;
								break;
							default:
								num3 = 3;
								if (0 == 0)
								{
									continue;
								}
								goto case 2;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 4;
									if (true)
									{
										continue;
									}
									goto case 6;
								}
								goto case 10;
							case 6:
								_003C_003Eu__1 = default;
								goto case 5;
							case 5:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 10:
								result = awaiter.GetResult();
								goto end_IL_00f6;
							}
							goto IL_0064;
							continue;
							end_IL_00f6:
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
					goto case 2;
				default:
					num = 2;
					goto IL_01bd;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					break;
				case 1:
				case 5:
					break;
				case 6:
					return;
				}
				readAdapterBase = _003C_003E4__this;
				num = 4;
			}
			while (xWk5tCuCEPgUES2YueN());
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
		internal static object aDc94iuNphrok39COOk(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ViDiELAdapterBase)P_0).GetToolNode((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pDw43guwrne1QTsfWPj(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xWk5tCuCEPgUES2YueN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mimcSOuAb5jCvGZvmNf()
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
	private struct _003CGetImageFromCameraAsync_003Ed__44 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IResultImage> _003C_003Et__builder;

		public ReadAdapterBase _003C_003E4__this;

		public string toolId;

		public CancellationToken token;

		private Bitmap _003Cbmp_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (rBG3ABupthiGxkegfqH())
			{
				num = 2;
			}
			else
			{
				num = 5;
				if (!rBG3ABupthiGxkegfqH())
				{
					goto IL_02bf;
				}
			}
			goto IL_0262;
			IL_0262:
			IResultImage result = default;
			int num2 = default;
			ReadAdapterBase readAdapterBase = default;
			string text = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					continue;
				case 4:
					try
					{
						if (num2 != 0)
						{
							readAdapterBase.ThrowIfToolIdInvalid(toolId);
							text = (string)XJxjjFuIMgsP46UxZTp(((ResourceNode)IQTXb3uRrLC14V0brI2(readAdapterBase, toolId)).HttpRootResourceUri, VfXkjEujirJNVDoucHh(7574));
							token.ThrowIfCancellationRequested();
						}
						try
						{
							int num3;
							if (num2 != 0)
							{
								_003Cbmp_003E5__2 = (Bitmap)hUwMxtubfZXYIX2rveS(LW0deguWWd1QyUQQuQn(readAdapterBase.InSight), text, null, null, null, null, null, null, VfXkjEujirJNVDoucHh(1982), VfXkjEujirJNVDoucHh(1982));
								num3 = 4;
								if (MxaNlbuGecyNPGFZl2y())
								{
									goto IL_00c0;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 9;
							}
							goto IL_0189;
							IL_0189:
							while (true)
							{
								switch (num3)
								{
								case 7:
									break;
								case 3:
									goto IL_00d9;
								case 9:
									_003C_003Eu__1 = default;
									num3 = 3;
									continue;
								case 0:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 5:
									return;
								case 4:
									goto IL_0120;
								case 1:
								case 6:
									if (!awaiter.IsCompleted)
									{
										num3 = 7;
										continue;
									}
									goto case 10;
								case 8:
									return;
								case 2:
									_003C_003Eu__1 = awaiter;
									goto case 0;
								default:
									num3 = 0;
									continue;
								case 10:
									awaiter.GetResult();
									goto end_IL_0079;
								}
								break;
								IL_0120:
								awaiter = VZ9PmEulf2MOhnrJEog(N7nS00ue1XfauVWFDem());
								_ = 1;
								num3 = ((!MxaNlbuGecyNPGFZl2y()) ? 6 : 8);
							}
							goto IL_00c0;
							IL_00d9:
							num2 = (_003C_003E1__state = -1);
							num3 = 10;
							goto IL_0189;
							IL_00c0:
							num2 = (_003C_003E1__state = 0);
							num3 = 2;
							if (MxaNlbuGecyNPGFZl2y())
							{
								goto IL_00d9;
							}
							goto IL_0189;
							end_IL_0079:;
						}
						catch
						{
							result = null;
							goto end_IL_003a;
						}
						Cognex.Ocr.Client.Tool.Image image = u7exiy49a9(_003Cbmp_003E5__2);
						if (image == null)
						{
							result = null;
						}
						else
						{
							ResultImage resultImage = new ResultImage();
							e4DPFtuyyW1f6NPIMHh(resultImage, ((CvsResultSet)eaUHtau7e9dyluxTWus(readAdapterBase.InSight)).Id.ToString());
							BxI3TWunROSYZEgXfwb(resultImage, image);
							result = resultImage;
						}
						end_IL_003a:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cbmp_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				default:
					num = 3;
					continue;
				case 1:
				case 5:
					readAdapterBase = _003C_003E4__this;
					num = 4;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 3:
					break;
				case 7:
					return;
				}
				break;
			}
			goto IL_02bf;
			IL_02bf:
			_003Cbmp_003E5__2 = null;
			num = 6;
			goto IL_0262;
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
		internal static object IQTXb3uRrLC14V0brI2(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ViDiELAdapterBase)P_0).GetToolNode((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VfXkjEujirJNVDoucHh(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XJxjjFuIMgsP46UxZTp(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LW0deguWWd1QyUQQuQn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hUwMxtubfZXYIX2rveS(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5, object P_6, object P_7, object P_8, object P_9)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).GetImageByHttp((string)P_1, (string)P_2, (string)P_3, (string)P_4, (string)P_5, (string)P_6, (string)P_7, (string)P_8, (string)P_9);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object N7nS00ue1XfauVWFDem()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter VZ9PmEulf2MOhnrJEog(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eaUHtau7e9dyluxTWus(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void e4DPFtuyyW1f6NPIMHh(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ResultImage)P_0).Id = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BxI3TWunROSYZEgXfwb(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ResultImage)P_0).Image = (Cognex.Ocr.Client.Tool.Image)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rBG3ABupthiGxkegfqH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MxaNlbuGecyNPGFZl2y()
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
	private struct _003CGetModelStatsFromCameraAsync_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ELReadModelStats> _003C_003Et__builder;

		public ReadAdapterBase _003C_003E4__this;

		public string toolId;

		public CancellationToken token;

		private TaskAwaiter<ELReadModelStats> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (ak4E5RuzowrojQbDmtn() ? 1 : 2);
			int num2 = default;
			ELReadModelStats result = default;
			ReadAdapterBase readAdapterBase = default;
			TaskAwaiter<ELReadModelStats> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 5;
					break;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							readAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 2;
							if (false)
							{
								goto IL_0069;
							}
							goto IL_0100;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0181;
						IL_0181:
						_003C_003Eu__1 = default;
						num3 = 8;
						goto IL_0100;
						IL_0100:
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								goto case 9;
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								goto case 10;
							case 2:
							{
								object obj = TfvrPpB2YIJdIfJ5Elm(readAdapterBase, toolId);
								token.ThrowIfCancellationRequested();
								awaiter = ((ResourceNode)obj).GetAsync<ELReadModelStats>((string)QhXDGTBXaxhk9uTNY02(7100)).GetAwaiter();
								num3 = 9;
								continue;
							}
							case 3:
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								ak4E5RuzowrojQbDmtn();
								if (vvxYtlufGeiPKjdGDd1())
								{
									num3 = 7;
									continue;
								}
								num3 = 0;
								if (true)
								{
									continue;
								}
								goto IL_0181;
							case 4:
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								continue;
							case 5:
								return;
							case 0:
							case 6:
								goto IL_0181;
							case 10:
								result = awaiter.GetResult();
								goto end_IL_004b;
							}
							break;
						}
						goto IL_0069;
						IL_0069:
						num2 = (_003C_003E1__state = 0);
						num3 = 3;
						if (ak4E5RuzowrojQbDmtn())
						{
						}
						goto IL_0100;
						end_IL_004b:;
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
					readAdapterBase = _003C_003E4__this;
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
		internal static object TfvrPpB2YIJdIfJ5Elm(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ViDiELAdapterBase)P_0).GetToolNode((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QhXDGTBXaxhk9uTNY02(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vvxYtlufGeiPKjdGDd1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ak4E5RuzowrojQbDmtn()
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
	private struct _003CGetToolResultFromCameraAsync_003Ed__46 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ELReadResult> _003C_003Et__builder;

		public ReadAdapterBase _003C_003E4__this;

		public string toolId;

		public CancellationToken token;

		private TaskAwaiter<ELReadResult> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			int num2 = default;
			ELReadResult result = default;
			ReadAdapterBase readAdapterBase = default;
			TaskAwaiter<ELReadResult> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					if (kaFOHlBMTVT2WFtFOTV())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							readAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 4;
							if (1 == 0)
							{
								goto IL_0063;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
						}
						goto IL_007c;
						IL_007c:
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 3:
								break;
							default:
								num3 = 6;
								continue;
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								goto case 10;
							case 4:
							{
								object obj = GogVyxBmDUju1UQbfdS(readAdapterBase, toolId);
								token.ThrowIfCancellationRequested();
								awaiter = ((ResourceNode)obj).GetAsync<ELReadResult>((string)FTN1ImBr2ae5rbeF167(7416)).GetAwaiter();
								num3 = 9;
								continue;
							}
							case 0:
								num2 = (_003C_003E1__state = 0);
								e6ShMnBkbM4hdDHYikV();
								if (kaFOHlBMTVT2WFtFOTV())
								{
									num3 = 1;
									continue;
								}
								num3 = 2;
								if (0 == 0)
								{
									continue;
								}
								goto case 2;
							case 6:
								goto IL_0126;
							case 8:
								return;
							case 5:
								_003C_003Eu__1 = default;
								goto case 2;
							case 2:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 10:
								result = awaiter.GetResult();
								goto end_IL_0045;
							}
							break;
						}
						goto IL_0063;
						IL_0126:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 8;
						goto IL_007c;
						IL_0063:
						_003C_003Eu__1 = awaiter;
						goto IL_0126;
						end_IL_0045:;
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
					readAdapterBase = _003C_003E4__this;
					e6ShMnBkbM4hdDHYikV();
					if (!kaFOHlBMTVT2WFtFOTV())
					{
						num = 4;
						continue;
					}
					num = 0;
					if (kaFOHlBMTVT2WFtFOTV())
					{
						break;
					}
					return;
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
		internal static object GogVyxBmDUju1UQbfdS(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ViDiELAdapterBase)P_0).GetToolNode((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FTN1ImBr2ae5rbeF167(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kaFOHlBMTVT2WFtFOTV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool e6ShMnBkbM4hdDHYikV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public ReadAdapterBase _003C_003E4__this;

		public ResourceNode toolNode;

		public Func<ELReadCharacterLabel, Character> _003C_003E9__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass47_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VKQMtcBgJmOVVBSDOHe();
			H1oT7JB1yvbt8KnwGDu(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Sample _003CGetSamplesFromCameraAsync_003Eb__0(ELReadSample s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Sample sample = new Sample();
			wCeK1hB61nqWOIO6fsw(sample, N0OaCUBSSPgm7KSCksK(s));
			REB7EsBDPNT9i7UXYiP(sample, _003C_003E4__this.KbBxrnO5Hd((string)N0OaCUBSSPgm7KSCksK(s), toolNode));
			sample.Characters = s.Characters.Select([MethodImpl(MethodImplOptions.NoInlining)] (ELReadCharacterLabel c) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				Character character = new Character();
				bZ08gSBFaehpNjXnHox(character, a0GrRZB8nsHmw2JEs7y(c));
				EppvV6Bd21270pdUfjm(character, mPw2QcBst7l3OH7rlQc(c));
				character.Text = iFwVyqB5Vv4rVGvhjAH(fkvcYHBEiSV6Qb8g4A5(c), 0);
				character.Confidence = (c.LabelConfidence.HasValue ? _003C_003E4__this.TTPxHKVTnE(c.LabelConfidence.Value) : 0.0);
				return character;
			}).ToList();
			return sample;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Character _003CGetSamplesFromCameraAsync_003Eb__1(ELReadCharacterLabel c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Character character = new Character();
			bZ08gSBFaehpNjXnHox(character, a0GrRZB8nsHmw2JEs7y(c));
			EppvV6Bd21270pdUfjm(character, mPw2QcBst7l3OH7rlQc(c));
			character.Text = iFwVyqB5Vv4rVGvhjAH(fkvcYHBEiSV6Qb8g4A5(c), 0);
			character.Confidence = (c.LabelConfidence.HasValue ? _003C_003E4__this.TTPxHKVTnE(c.LabelConfidence.Value) : 0.0);
			return character;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void VKQMtcBgJmOVVBSDOHe()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void H1oT7JB1yvbt8KnwGDu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EL2SUpBPVxySivqFW32()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool B4SXx2B4Cw6YnswXPon()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object N0OaCUBSSPgm7KSCksK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELReadSample)P_0).Id;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void wCeK1hB61nqWOIO6fsw(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Sample)P_0).Id = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void REB7EsBDPNT9i7UXYiP(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Sample)P_0).Image = (Cognex.Ocr.Client.Tool.Image)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double a0GrRZB8nsHmw2JEs7y(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELReadCharacterLabel)P_0).CenterX;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void bZ08gSBFaehpNjXnHox(object P_0, double P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CharacterBase)P_0).CenterX = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double mPw2QcBst7l3OH7rlQc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELReadCharacterLabel)P_0).CenterY;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void EppvV6Bd21270pdUfjm(object P_0, double P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CharacterBase)P_0).CenterY = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fkvcYHBEiSV6Qb8g4A5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELReadCharacterLabel)P_0).Character;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static char iFwVyqB5Vv4rVGvhjAH(object P_0, int P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0)[P_1];
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetSamplesFromCameraAsync_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ICollection<ISample>> _003C_003Et__builder;

		public ReadAdapterBase _003C_003E4__this;

		public string toolId;

		public CancellationToken token;

		private _003C_003Ec__DisplayClass47_0 _003C_003E8__1;

		private TaskAwaiter<ELReadSample[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!J0pN3PBab5Ktef9Cmyv())
			{
				num = 5;
			}
			else
			{
				num = 4;
				if (!cTedoxB3YoVySqJ5iQT())
				{
					goto IL_02a8;
				}
			}
			goto IL_025a;
			IL_025a:
			int num2 = default;
			TaskAwaiter<ELReadSample[]> awaiter = default;
			ReadAdapterBase readAdapterBase = default;
			ICollection<ISample> result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 3;
					if (cTedoxB3YoVySqJ5iQT())
					{
						continue;
					}
					goto case 2;
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003C_003E8__1 = new _003C_003Ec__DisplayClass47_0();
							num3 = 1;
							if (J0pN3PBab5Ktef9Cmyv())
							{
								goto IL_005c;
							}
							goto IL_00b3;
						}
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default;
						goto IL_0171;
						IL_01f6:
						object obj = null;
						goto IL_0217;
						IL_0124:
						ELReadSample[] result2 = awaiter.GetResult();
						token.ThrowIfCancellationRequested();
						if (result2 == null)
						{
							num3 = 13;
							goto IL_00b3;
						}
						obj = ((IEnumerable<ISample>)result2.Select([MethodImpl(MethodImplOptions.NoInlining)] (ELReadSample s) =>
						{
							while (false)
							{
								_ = ((object[])null)[0];
							}
							Sample sample = new Sample();
							_003C_003Ec__DisplayClass47_0.wCeK1hB61nqWOIO6fsw(sample, _003C_003Ec__DisplayClass47_0.N0OaCUBSSPgm7KSCksK(s));
							_003C_003Ec__DisplayClass47_0.REB7EsBDPNT9i7UXYiP(sample, _003C_003E8__1._003C_003E4__this.KbBxrnO5Hd((string)_003C_003Ec__DisplayClass47_0.N0OaCUBSSPgm7KSCksK(s), _003C_003E8__1.toolNode));
							sample.Characters = s.Characters.Select([MethodImpl(MethodImplOptions.NoInlining)] (ELReadCharacterLabel c) =>
							{
								while (false)
								{
									_ = ((object[])null)[0];
								}
								Character character = new Character();
								_003C_003Ec__DisplayClass47_0.bZ08gSBFaehpNjXnHox(character, _003C_003Ec__DisplayClass47_0.a0GrRZB8nsHmw2JEs7y(c));
								_003C_003Ec__DisplayClass47_0.EppvV6Bd21270pdUfjm(character, _003C_003Ec__DisplayClass47_0.mPw2QcBst7l3OH7rlQc(c));
								character.Text = _003C_003Ec__DisplayClass47_0.iFwVyqB5Vv4rVGvhjAH(_003C_003Ec__DisplayClass47_0.fkvcYHBEiSV6Qb8g4A5(c), 0);
								character.Confidence = (c.LabelConfidence.HasValue ? _003C_003E8__1._003C_003E4__this.TTPxHKVTnE(c.LabelConfidence.Value) : 0.0);
								return character;
							}).ToList();
							return sample;
						})).ToList();
						goto IL_0217;
						IL_005c:
						if (!awaiter.IsCompleted)
						{
							num3 = 7;
							goto IL_00b3;
						}
						goto IL_0124;
						IL_0171:
						num2 = (_003C_003E1__state = -1);
						num3 = 3;
						goto IL_00b3;
						IL_00b3:
						while (true)
						{
							switch (num3)
							{
							case 5:
								break;
							case 6:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 12:
								token.ThrowIfCancellationRequested();
								num3 = 2;
								continue;
							case 7:
								num2 = (_003C_003E1__state = 0);
								goto case 6;
							default:
								num3 = 6;
								continue;
							case 2:
								awaiter = _003C_003E8__1.toolNode.GetAsync<ELReadSample[]>((string)UElMmhBc9893PQS2fJm(7182)).GetAwaiter();
								num3 = 5;
								continue;
							case 3:
								goto IL_0124;
							case 8:
							case 11:
								return;
							case 4:
							case 9:
								goto IL_0171;
							case 1:
								_003C_003E8__1._003C_003E4__this = _003C_003E4__this;
								readAdapterBase.ThrowIfToolIdInvalid(toolId);
								num3 = 10;
								if (true)
								{
									continue;
								}
								goto case 10;
							case 10:
								_003C_003E8__1.toolNode = (ResourceNode)usPu8RBohItlK9EEWI1(readAdapterBase, toolId);
								num3 = 12;
								continue;
							case 0:
								goto IL_01ce;
							case 13:
								goto IL_01f6;
							}
							break;
							IL_01ce:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							cTedoxB3YoVySqJ5iQT();
							if (J0pN3PBab5Ktef9Cmyv())
							{
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto IL_0171;
							}
							num3 = 11;
						}
						goto IL_005c;
						IL_0217:
						result = (ICollection<ISample>)obj;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003E8__1 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				default:
					num = 1;
					if (0 == 0)
					{
						continue;
					}
					goto case 3;
				case 3:
					readAdapterBase = _003C_003E4__this;
					goto case 2;
				case 1:
					break;
				case 6:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					if (cTedoxB3YoVySqJ5iQT())
					{
						continue;
					}
					return;
				case 7:
					return;
				}
				break;
			}
			goto IL_02a8;
			IL_02a8:
			_003C_003E8__1 = null;
			num = 6;
			goto IL_025a;
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
		internal static object usPu8RBohItlK9EEWI1(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ViDiELAdapterBase)P_0).GetToolNode((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UElMmhBc9893PQS2fJm(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cTedoxB3YoVySqJ5iQT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool J0pN3PBab5Ktef9Cmyv()
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
	private struct _003CTrainAsync_003Ed__50 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ReadAdapterBase _003C_003E4__this;

		public string toolId;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rD9mIOBuUPmZrRDyJer();
			int num;
			if (!tibUgmBBAcQhDhGs1gI())
			{
				num = 2;
				if (tibUgmBBAcQhDhGs1gI())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 5;
				if (!rD9mIOBuUPmZrRDyJer())
				{
					goto IL_0071;
				}
			}
			goto IL_02ad;
			IL_02ad:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					break;
				case 3:
					goto IL_003f;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					break;
				case 4:
					goto IL_0071;
				default:
					num = 3;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_002e;
			IL_0071:
			ReadAdapterBase readAdapterBase = default;
			try
			{
				int num3;
				TaskAwaiter awaiter = default;
				TaskAwaiter<object> awaiter2 = default;
				if (num2 != 0)
				{
					if (num2 != 1)
					{
						num3 = 1;
					}
					else
					{
						awaiter = _003C_003Eu__2;
						num3 = 5;
					}
				}
				else
				{
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num3 = 3;
					if (false)
					{
						goto IL_0253;
					}
				}
				goto IL_010b;
				IL_010b:
				while (true)
				{
					switch (num3)
					{
					case 12:
						if (!awaiter.IsCompleted)
						{
							num3 = 8;
							continue;
						}
						goto case 16;
					case 3:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						continue;
					case 6:
						_003C_003Eu__1 = awaiter2;
						tibUgmBBAcQhDhGs1gI();
						if (rD9mIOBuUPmZrRDyJer())
						{
							num3 = 15;
							continue;
						}
						num3 = 7;
						if (!tibUgmBBAcQhDhGs1gI())
						{
							continue;
						}
						goto case 10;
					case 5:
						_003C_003Eu__2 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 16;
						continue;
					case 9:
						awaiter2.GetResult();
						goto case 2;
					default:
						num3 = 2;
						continue;
					case 13:
						awaiter2 = ((ResourceNode)mUClZtBxp1jHGabYa82(readAdapterBase, toolId)).PostAsync<object>((string)FdgZ3FBh2wNk9owLTSL(7402), Array.Empty<object>()).GetAwaiter();
						num3 = 10;
						continue;
					case 14:
						_003C_003Eu__2 = awaiter;
						break;
					case 10:
						if (awaiter2.IsCompleted)
						{
							goto case 9;
						}
						num2 = (_003C_003E1__state = 0);
						num3 = 6;
						if (0 == 0)
						{
							continue;
						}
						goto case 8;
					case 8:
						num2 = (_003C_003E1__state = 1);
						num3 = 14;
						continue;
					case 0:
						return;
					case 2:
						awaiter = pwR6WdBQefhwKE700b4(zkTmMPBU4hxtmSJdMHf(readAdapterBase));
						num3 = 12;
						continue;
					case 1:
						readAdapterBase.ThrowIfToolIdInvalid(toolId);
						num3 = 13;
						continue;
					case 4:
					case 15:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					case 7:
					case 11:
						break;
					case 16:
						awaiter.GetResult();
						goto end_IL_010b;
					}
					goto IL_0253;
					continue;
					end_IL_010b:
					break;
				}
				goto end_IL_0071;
				IL_0253:
				_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
				num3 = 0;
				goto IL_010b;
				end_IL_0071:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_003f;
			IL_002e:
			readAdapterBase = _003C_003E4__this;
			num = 4;
			goto IL_02ad;
			IL_003f:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_02ad;
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
		internal static object mUClZtBxp1jHGabYa82(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ViDiELAdapterBase)P_0).GetToolNode((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FdgZ3FBh2wNk9owLTSL(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zkTmMPBU4hxtmSJdMHf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ViDiELAdapterBase)P_0).RunToolAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter pwR6WdBQefhwKE700b4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rD9mIOBuUPmZrRDyJer()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tibUgmBBAcQhDhGs1gI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<RevisedCharacter, bool> _003C_003E9__51_0;

		public static Func<RevisedCharacter, ELReadCharacterLabel> _003C_003E9__51_1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			mJlRN5BiYdIBuPHDjZ5();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			mJlRN5BiYdIBuPHDjZ5();
			GA9GJnBL4ucMbiCmAAk(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CLabelImage_003Eb__51_0(RevisedCharacter c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return !RW5XaeB9htffhsQnoKp(tAcR0nBt9YPe1L8wt5m(c));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ELReadCharacterLabel _003CLabelImage_003Eb__51_1(RevisedCharacter c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ELReadCharacterLabel eLReadCharacterLabel = new ELReadCharacterLabel
			{
				CenterX = moGeI6Bvvia0aXwSfTj(c),
				CenterY = c.CenterY
			};
			mtndoiBZXcLlaprFXUB(eLReadCharacterLabel, tAcR0nBt9YPe1L8wt5m(c).ToString());
			return eLReadCharacterLabel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void mJlRN5BiYdIBuPHDjZ5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wxNTDyBqt4C7SEpujyF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RjrLZIBVKuJP5pYTiwA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GA9GJnBL4ucMbiCmAAk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static char tAcR0nBt9YPe1L8wt5m(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CharacterBase)P_0).Text;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RW5XaeB9htffhsQnoKp(char P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return char.IsWhiteSpace(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double moGeI6Bvvia0aXwSfTj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CharacterBase)P_0).CenterX;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void mtndoiBZXcLlaprFXUB(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ELReadCharacterLabel)P_0).Character = (string)P_1;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLabelImage_003Ed__51 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ReadAdapterBase _003C_003E4__this;

		public string toolId;

		public ICollection<RevisedCharacter> revisedCharacters;

		public string sampleId;

		private TaskAwaiter<object> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			jHbDxIBOas34K4rNlQC();
			int num = (rYDy96B0xJeIAytrrqn() ? 1 : 4);
			int num2 = default;
			ReadAdapterBase readAdapterBase = default;
			TaskAwaiter<object> awaiter = default;
			TaskAwaiter awaiter2 = default;
			List<ELReadCharacterLabel> list = default;
			ELReadTrainData eLReadTrainData = default;
			ResourceNode resourceNode = default;
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
							readAdapterBase.ThrowIfToolIdInvalid(toolId);
							num3 = 3;
							break;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 5;
							break;
						case 2:
							awaiter2 = _003C_003Eu__2;
							num3 = 15;
							break;
						case 1:
							awaiter = _003C_003Eu__1;
							jHbDxIBOas34K4rNlQC();
							if (!rYDy96B0xJeIAytrrqn())
							{
								num3 = 4;
								if (jHbDxIBOas34K4rNlQC())
								{
								}
							}
							else
							{
								num3 = 13;
							}
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 20:
								return;
							case 4:
							case 23:
								num2 = (_003C_003E1__state = -1);
								num3 = 26;
								continue;
							case 2:
								throw new ArgumentNullException((string)DMlu2BBHMYnZJgG3Lwa(7462));
							case 13:
							case 17:
								_003C_003Eu__1 = default;
								num3 = 12;
								continue;
							case 25:
								_003C_003Eu__1 = awaiter;
								num3 = 16;
								continue;
							case 21:
								goto end_IL_0358;
							case 0:
								readAdapterBase.ClearCaches(toolId);
								num3 = 8;
								continue;
							case 10:
								return;
							case 9:
								_003C_003Eu__1 = awaiter;
								num3 = 22;
								continue;
							case 1:
								awaiter.GetResult();
								goto IL_0179;
							case 15:
								_003C_003Eu__2 = default;
								goto case 4;
							case 19:
								return;
							case 22:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 20;
								continue;
							case 14:
								if (list.Count > 0)
								{
									eLReadTrainData = new ELReadTrainData
									{
										Characters = list
									};
									num3 = 11;
									continue;
								}
								num3 = 21;
								if (rYDy96B0xJeIAytrrqn())
								{
									continue;
								}
								goto case 18;
							case 18:
								awaiter.GetResult();
								goto IL_0179;
							case 7:
								_003C_003Eu__2 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 10;
								if (jHbDxIBOas34K4rNlQC())
								{
								}
								continue;
							case 3:
								if (revisedCharacters != null)
								{
									list = revisedCharacters.Where([MethodImpl(MethodImplOptions.NoInlining)] (RevisedCharacter c) =>
									{
										while (false)
										{
											_ = ((object[])null)[0];
										}
										return !_003C_003Ec.RW5XaeB9htffhsQnoKp(_003C_003Ec.tAcR0nBt9YPe1L8wt5m(c));
									}).Select([MethodImpl(MethodImplOptions.NoInlining)] (RevisedCharacter c) =>
									{
										while (false)
										{
											_ = ((object[])null)[0];
										}
										ELReadCharacterLabel eLReadCharacterLabel = new ELReadCharacterLabel
										{
											CenterX = _003C_003Ec.moGeI6Bvvia0aXwSfTj(c),
											CenterY = c.CenterY
										};
										_003C_003Ec.mtndoiBZXcLlaprFXUB(eLReadCharacterLabel, _003C_003Ec.tAcR0nBt9YPe1L8wt5m(c).ToString());
										return eLReadCharacterLabel;
									}).ToList();
									num3 = 14;
								}
								else
								{
									num3 = 2;
								}
								continue;
							case 8:
								if (sampleId == null)
								{
									awaiter = resourceNode.PostAsync<object>((string)DMlu2BBHMYnZJgG3Lwa(7230), new object[1] { eLReadTrainData }).GetAwaiter();
									num3 = 24;
									continue;
								}
								awaiter = resourceNode.PostAsync<object>(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(7290), new object[2] { sampleId, eLReadTrainData }).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									if (jHbDxIBOas34K4rNlQC())
									{
									}
									continue;
								}
								goto case 18;
							case 11:
								resourceNode = (ResourceNode)kdB0kRBTZAh9NIDoBwV(readAdapterBase, toolId);
								num3 = 0;
								continue;
							case 24:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 25;
									continue;
								}
								goto case 1;
							case 5:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto case 18;
							default:
								num3 = 18;
								continue;
							case 12:
								num2 = (_003C_003E1__state = -1);
								num3 = 1;
								continue;
							case 16:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 19;
								continue;
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 9;
								continue;
							case 26:
								break;
								IL_0179:
								awaiter2 = readAdapterBase.Hscx6raHrH(toolId).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 2);
									num3 = 7;
									continue;
								}
								break;
							}
							awaiter2.GetResult();
							break;
							continue;
							end_IL_0358:
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
				case 0:
				case 1:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 5:
					readAdapterBase = _003C_003E4__this;
					num = 2;
					if (rYDy96B0xJeIAytrrqn())
					{
						continue;
					}
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
		internal static object DMlu2BBHMYnZJgG3Lwa(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kdB0kRBTZAh9NIDoBwV(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ViDiELAdapterBase)P_0).GetToolNode((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rYDy96B0xJeIAytrrqn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jHbDxIBOas34K4rNlQC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly AsyncCache<string, CogSize> qxAxS5r2Ms;

	private readonly AsyncCache<string, object> Kq5xK3vuQX;

	private readonly AsyncCache<string, IResultImage> lN1xm9iodY;

	private readonly AsyncCache<string, ELReadModelStats> R13xMcH05M;

	private readonly AsyncCache<string, ELReadResult> VWix7xX9fI;

	private readonly AsyncCache<string, ICollection<ISample>> exOxYFoi5d;

	[CompilerGenerated]
	private EventHandler<FlexibleFieldingEventArgs> JNSx0SbsqA;

	[CompilerGenerated]
	private EventHandler<NewResultArgs> jUVxv2HiuO;

	private bool GrlxLkpv53;

	private CharacterSize pndxdC9u2D;

	public event EventHandler<FlexibleFieldingEventArgs> FlexibleFieldingChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<FlexibleFieldingEventArgs> eventHandler = JNSx0SbsqA;
			EventHandler<FlexibleFieldingEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FlexibleFieldingEventArgs> value2 = (EventHandler<FlexibleFieldingEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref JNSx0SbsqA, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<FlexibleFieldingEventArgs> eventHandler = JNSx0SbsqA;
			EventHandler<FlexibleFieldingEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FlexibleFieldingEventArgs> value2 = (EventHandler<FlexibleFieldingEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref JNSx0SbsqA, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<NewResultArgs> NewResult
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<NewResultArgs> eventHandler = jUVxv2HiuO;
			EventHandler<NewResultArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<NewResultArgs> value2 = (EventHandler<NewResultArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref jUVxv2HiuO, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EventHandler<NewResultArgs> eventHandler = jUVxv2HiuO;
			EventHandler<NewResultArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<NewResultArgs> value2 = (EventHandler<NewResultArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref jUVxv2HiuO, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected ReadAdapterBase(CvsInSight insight, Func<Task> triggerAcquisition = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		pndxdC9u2D = new CharacterSize
		{
			Width = 93.3,
			Height = 140.0
		};
		base._002Ector(insight, triggerAcquisition);
		qxAxS5r2Ms = new AsyncCache<string, CogSize>(t4txl9oTcd);
		Kq5xK3vuQX = new AsyncCache<string, object>(lJDxBIqop1);
		lN1xm9iodY = new AsyncCache<string, IResultImage>(r4AxeThPVG);
		R13xMcH05M = new AsyncCache<string, ELReadModelStats>(FV4xtbbWUe);
		VWix7xX9fI = new AsyncCache<string, ELReadResult>(UYOx3bGdaG);
		exOxYFoi5d = new AsyncCache<string, ICollection<ISample>>(accxCRlFWl);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Register(IOcrToolAdapter adapter)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		occ0yTkNaVr7RwjRmSq();
		int num;
		if (!T87ehdkwrpH9av89f0H())
		{
			num = 4;
			if (!occ0yTkNaVr7RwjRmSq())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_0091;
		IL_002e:
		OcrClient.SetLocale(((CultureInfo)PDPSy7kjqR6gTKFSWQD()).TwoLetterISOLanguageName, new LocalizationOverride
		{
			key = (string)wZjSt5kGTnJvKXPeC2o(1938),
			value = (string)lKmZ79kImm7OnkicNK8()
		});
		num = 5;
		goto IL_0091;
		IL_0091:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 1:
			case 2:
				KuRLkUkRSUbSVkFJRxx(wZjSt5kGTnJvKXPeC2o(894));
				break;
			default:
				num = 3;
				if (occ0yTkNaVr7RwjRmSq())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 4:
				vBUPDRkptD9dWnuAr3v(new NoThrowOcrToolAdapterWrapper(adapter));
				goto case 1;
			case 5:
				return;
			}
			break;
		}
		goto IL_002e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void UpdateFlexibleFielding(string newFlexibleFieldingValue)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		FlexibleFieldingEventArgs e = new FlexibleFieldingEventArgs(newFlexibleFieldingValue);
		OnFlexibleFieldingChanged(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnFlexibleFieldingChanged(FlexibleFieldingEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		JNSx0SbsqA?.Invoke(this, e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalClearCaches(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
				Kq5xK3vuQX.Remove(toolId);
				num = 5;
				break;
			case 7:
				R13xMcH05M.Remove(toolId);
				num = 4;
				break;
			case 5:
				lN1xm9iodY.Remove(toolId);
				goto case 7;
			default:
				num = 7;
				break;
			case 0:
				exOxYFoi5d.Remove(toolId);
				num = 9;
				if (true)
				{
					break;
				}
				goto case 8;
			case 8:
				ThrowIfToolIdInvalid(toolId);
				occ0yTkNaVr7RwjRmSq();
				num = (T87ehdkwrpH9av89f0H() ? 3 : 6);
				break;
			case 4:
				VWix7xX9fI.Remove(toolId);
				num = 0;
				break;
			case 1:
			case 6:
				qxAxS5r2Ms.Remove(toolId);
				goto case 2;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnNewResult(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		if (T87ehdkwrpH9av89f0H())
		{
			goto IL_001e;
		}
		goto IL_003b;
		IL_0161:
		if (!dojordkeCkjLIyWOMWE(_mainThreadDispatcher))
		{
			num = 3;
			if (T87ehdkwrpH9av89f0H())
			{
			}
			goto IL_003b;
		}
		goto IL_00bd;
		IL_003b:
		_003C_003Ec__DisplayClass20_0 obj2 = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			default:
				num = 0;
				continue;
			case 4:
				obj2._003C_003E4__this = this;
				occ0yTkNaVr7RwjRmSq();
				if (!T87ehdkwrpH9av89f0H())
				{
					num = 9;
					continue;
				}
				num = 1;
				if (occ0yTkNaVr7RwjRmSq())
				{
					continue;
				}
				goto case 7;
			case 3:
				AYofuKklVRBfxbEE8Oh(_mainThreadDispatcher, new Action(obj2._003COnNewResult_003Eb__0));
				num = 10;
				continue;
			case 10:
				return;
			case 8:
				return;
			case 7:
				obj2 = new _003C_003Ec__DisplayClass20_0();
				num = 4;
				if (occ0yTkNaVr7RwjRmSq())
				{
					continue;
				}
				return;
			case 1:
				return;
			case 2:
			case 9:
			{
				_003C_003Ec__DisplayClass20_0 obj = obj2;
				NewResultArgs newResultArgs = new NewResultArgs();
				gQssbjkWRn1dFTuK4OE(newResultArgs, toolId);
				obj.args = newResultArgs;
				ThrowIfToolIdInvalid(obj2.args.toolId);
				num = 5;
				if (occ0yTkNaVr7RwjRmSq())
				{
					continue;
				}
				goto case 5;
			}
			case 5:
				ClearCaches((string)nxooOekbiPsSyfsq6iF(obj2.args));
				num = 6;
				if (occ0yTkNaVr7RwjRmSq())
				{
					continue;
				}
				goto IL_0161;
			case 0:
				goto IL_0161;
			case 11:
				return;
			}
			break;
		}
		goto IL_001e;
		IL_00bd:
		EventHandler<NewResultArgs> eventHandler = jUVxv2HiuO;
		if (eventHandler == null)
		{
			return;
		}
		eventHandler(this, obj2.args);
		num = 11;
		goto IL_003b;
		IL_001e:
		if (_mainThreadDispatcher == null)
		{
			goto IL_00bd;
		}
		goto IL_0161;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSamples_003Ed__21))]
	public Task<ICollection<ISample>> GetSamples(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetSamples_003Ed__21 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ICollection<ISample>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetNumberOfSamples_003Ed__22))]
	public Task<int> GetNumberOfSamples(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetNumberOfSamples_003Ed__22 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<int>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetNumberOfUniqueCharacters_003Ed__23))]
	public Task<int> GetNumberOfUniqueCharacters(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetNumberOfUniqueCharacters_003Ed__23 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<int>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<double?> GetConfidencePercentage(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ThrowIfToolIdInvalid(toolId);
		return Task.FromResult<double?>(null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetImage_003Ed__25))]
	public Task<IResultImage> GetImage(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetImage_003Ed__25 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IResultImage>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetCharacters_003Ed__26))]
	public Task<IResultCharacters> GetCharacters(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetCharacters_003Ed__26 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IResultCharacters>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetToolResultAsync_003Ed__27))]
	public Task<ELReadResult> GetToolResultAsync(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetToolResultAsync_003Ed__27 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ELReadResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetFieldingResult_003Ed__28))]
	public Task<FieldingResult> GetFieldingResult(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetFieldingResult_003Ed__28 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<FieldingResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetCharacterSize_003Ed__29))]
	public Task<CharacterSize> GetCharacterSize(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetCharacterSize_003Ed__29 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CharacterSize>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AdjustDefaultCharacterSizeBasedOnRoi(double roiWidth, double roiHeight)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		double num2 = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				return;
			case 5:
			{
				CharacterSize characterSize2 = new CharacterSize
				{
					Width = 2.0 * num2
				};
				Dh4fd8k7nUAySJMhO1f(characterSize2, 3.0 * num2);
				pndxdC9u2D = characterSize2;
				num = 6;
				if (occ0yTkNaVr7RwjRmSq())
				{
					break;
				}
				goto case 0;
			}
			case 0:
			case 2:
				num2 = Math.Min((roiWidth - 30.0) / 2.0, (roiHeight - 30.0) / 3.0);
				goto case 5;
			default:
				num = 5;
				if (T87ehdkwrpH9av89f0H())
				{
				}
				break;
			case 4:
				if (!(roiWidth < 93.3))
				{
					_ = 0;
					if (occ0yTkNaVr7RwjRmSq())
					{
						num = 3;
						break;
					}
					num = 0;
					if (0 == 0)
					{
						break;
					}
					return;
				}
				goto case 0;
			case 1:
			case 3:
				if (!(roiHeight < 140.0))
				{
					CharacterSize characterSize = new CharacterSize
					{
						Width = 93.3
					};
					Dh4fd8k7nUAySJMhO1f(characterSize, 140.0);
					pndxdC9u2D = characterSize;
					num = 7;
					if (0 == 0)
					{
						break;
					}
					goto case 5;
				}
				goto case 0;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetCharacterSize_003Ed__35))]
	public Task SetCharacterSize(string toolId, CharacterSize newCharacterSize)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CSetCharacterSize_003Ed__35 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003E1__state = -1;
				num = 2;
				break;
			case 0:
				stateMachine._003C_003Et__builder = luk3vOkyKHSSOR1IR8p();
				_ = 0;
				if (occ0yTkNaVr7RwjRmSq())
				{
					num = 6;
					break;
				}
				num = 5;
				if (!T87ehdkwrpH9av89f0H())
				{
					break;
				}
				goto case 7;
			case 3:
				stateMachine.newCharacterSize = newCharacterSize;
				goto default;
			case 7:
				stateMachine.toolId = toolId;
				num = 3;
				break;
			case 1:
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 7;
				break;
			case 2:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAcceptLabeling_003Ed__36))]
	public virtual Task AcceptLabeling(string toolId, string resultId, ICollection<RevisedCharacter> revisedCharacters)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAcceptLabeling_003Ed__36 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine.revisedCharacters = revisedCharacters;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CChangeSample_003Ed__37))]
	public Task ChangeSample(string toolId, string sampleId, ICollection<RevisedCharacter> revisedCharacters)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CChangeSample_003Ed__37 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine.sampleId = sampleId;
		stateMachine.revisedCharacters = revisedCharacters;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDeleteSamples_003Ed__38))]
	public Task DeleteSamples(string toolId, string[] samplesIds)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!T87ehdkwrpH9av89f0H())
		{
			num = 2;
			if (T87ehdkwrpH9av89f0H())
			{
			}
		}
		else
		{
			num = 6;
		}
		_003CDeleteSamples_003Ed__38 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 5:
				stateMachine.toolId = toolId;
				num = 3;
				break;
			case 3:
				stateMachine.samplesIds = samplesIds;
				goto case 7;
			default:
				num = 7;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 7:
				stateMachine._003C_003E1__state = -1;
				num = 4;
				break;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = luk3vOkyKHSSOR1IR8p();
				goto case 1;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetFielding_003Ed__39))]
	public Task<FieldingSettings> GetFielding(string toolId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetFielding_003Ed__39 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<FieldingSettings>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = toolId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string kP8xTijayK(List<ELReadFieldingCharacterClass> P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Join("", P_0.Select(FieldingPatternParser.CharacterClassToMetaString));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetFielding_003Ed__41))]
	public Task SetFielding(string toolId, FieldingSettings fielding)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_00ae;
		IL_001a:
		_003CSetFielding_003Ed__41 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		num = 7;
		goto IL_00ae;
		IL_00ae:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			case 6:
				stateMachine._003C_003Et__builder = luk3vOkyKHSSOR1IR8p();
				occ0yTkNaVr7RwjRmSq();
				num = (T87ehdkwrpH9av89f0H() ? 4 : 0);
				continue;
			case 2:
			case 4:
				stateMachine.toolId = toolId;
				num = 3;
				continue;
			case 7:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				continue;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 3:
				stateMachine.fielding = fielding;
				break;
			default:
				num = 5;
				continue;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetCharacterSizeFromCameraAsync_003Ed__42))]
	private Task<CogSize> t4txl9oTcd(string P_0, CancellationToken P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetCharacterSizeFromCameraAsync_003Ed__42 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CogSize>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = P_0;
		stateMachine.token = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetFieldingFromCameraAsync_003Ed__43))]
	private Task<object> lJDxBIqop1(string P_0, CancellationToken P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetFieldingFromCameraAsync_003Ed__43 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<object>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = P_0;
		stateMachine.token = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetImageFromCameraAsync_003Ed__44))]
	private Task<IResultImage> r4AxeThPVG(string P_0, CancellationToken P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetImageFromCameraAsync_003Ed__44 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IResultImage>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = P_0;
		stateMachine.token = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetModelStatsFromCameraAsync_003Ed__45))]
	private Task<ELReadModelStats> FV4xtbbWUe(string P_0, CancellationToken P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetModelStatsFromCameraAsync_003Ed__45 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ELReadModelStats>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = P_0;
		stateMachine.token = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetToolResultFromCameraAsync_003Ed__46))]
	private Task<ELReadResult> UYOx3bGdaG(string P_0, CancellationToken P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetToolResultFromCameraAsync_003Ed__46 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ELReadResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = P_0;
		stateMachine.token = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSamplesFromCameraAsync_003Ed__47))]
	private Task<ICollection<ISample>> accxCRlFWl(string P_0, CancellationToken P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetSamplesFromCameraAsync_003Ed__47 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ICollection<ISample>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = P_0;
		stateMachine.token = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Cognex.Ocr.Client.Tool.Image KbBxrnO5Hd(string P_0, ResourceNode P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		string url = (string)PfWTwakfmckIowq0nUt(VMQuLZknSE5dECRNNjq(P_1), wZjSt5kGTnJvKXPeC2o(1966), P_0);
		return u7exiy49a9(InSight.CogSocket.GetImageByHttp(url, null, null, null, null, null, null, (string)wZjSt5kGTnJvKXPeC2o(1982), (string)wZjSt5kGTnJvKXPeC2o(1982)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Cognex.Ocr.Client.Tool.Image u7exiy49a9(Bitmap P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		byte[] array = lkGx7Dm2JCfj5DGILxK(new ImageConverter(), P_0, DvvoTHkzckuKHaYdYPD(typeof(byte[]).TypeHandle)) as byte[];
		Cognex.Ocr.Client.Tool.Image image = new Cognex.Ocr.Client.Tool.Image();
		MpJ2SmmXvQkgJDvxmyD(image, array);
		vKoA1dmkpq3DkZ4dtK2(image, Hn5E4HmM04p4byl1UHP(P_0));
		image.Width = HQwSwKmm69jRKFcYsNe(P_0);
		return image;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CTrainAsync_003Ed__50))]
	private Task Hscx6raHrH(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		T87ehdkwrpH9av89f0H();
		int num;
		if (occ0yTkNaVr7RwjRmSq())
		{
			num = 2;
			if (!occ0yTkNaVr7RwjRmSq())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 6;
		}
		goto IL_0048;
		IL_0077:
		_003CTrainAsync_003Ed__50 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		num = 3;
		if (occ0yTkNaVr7RwjRmSq())
		{
			goto IL_0048;
		}
		goto IL_008f;
		IL_0048:
		while (true)
		{
			switch (num)
			{
			case 5:
				break;
			default:
				num = 4;
				continue;
			case 4:
				goto IL_0077;
			case 1:
			case 6:
				goto IL_008f;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (!T87ehdkwrpH9av89f0H())
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = luk3vOkyKHSSOR1IR8p();
				goto IL_008f;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		stateMachine.toolId = P_0;
		goto IL_0077;
		IL_008f:
		stateMachine._003C_003E4__this = this;
		num = 5;
		goto IL_0048;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLabelImage_003Ed__51))]
	private Task F0vxn6Tkdv(string P_0, ICollection<RevisedCharacter> P_1, string P_2 = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CLabelImage_003Ed__51 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.toolId = P_0;
		stateMachine.revisedCharacters = P_1;
		stateMachine.sampleId = P_2;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private double TTPxHKVTnE(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return z4fYEJmrMLTAtBin8Be(P_0 * 100.0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InternalDisposeCaches()
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
			case 0:
			case 1:
				R13xMcH05M.Dispose();
				goto case 2;
			case 3:
				exOxYFoi5d.Dispose();
				num = 6;
				break;
			case 4:
				SXBeLOmP0N8pa2vWT6n(lN1xm9iodY);
				occ0yTkNaVr7RwjRmSq();
				num = (T87ehdkwrpH9av89f0H() ? 5 : 0);
				break;
			case 2:
			case 5:
				k0hhvXm4crELUvB1AiJ(VWix7xX9fI);
				goto case 3;
			default:
				num = 3;
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private FieldingPattern EwmxpnkILb(KeyValuePair<string, ELReadPattern> P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new FieldingPattern
		{
			Name = P_0.Key,
			Pattern = string.Join(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(1988), P_0.Value.Lines.Select([MethodImpl(MethodImplOptions.NoInlining)] (ELReadPatternLine eLReadPatternLine) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return kP8xTijayK(eLReadPatternLine.Characters);
			}))
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private string orxxW9vFfw(ELReadPatternLine P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kP8xTijayK(P_0.Characters);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vBUPDRkptD9dWnuAr3v(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		OcrClient.RegisterAdapter((IOcrToolAdapter)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wZjSt5kGTnJvKXPeC2o(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KuRLkUkRSUbSVkFJRxx(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		OcrClient.SetInitialTheme((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PDPSy7kjqR6gTKFSWQD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.CurrentUICulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lKmZ79kImm7OnkicNK8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.NextImage;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool occ0yTkNaVr7RwjRmSq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool T87ehdkwrpH9av89f0H()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gQssbjkWRn1dFTuK4OE(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((NewResultArgs)P_0).toolId = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nxooOekbiPsSyfsq6iF(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((NewResultArgs)P_0).toolId;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dojordkeCkjLIyWOMWE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Dispatcher)P_0).CheckAccess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AYofuKklVRBfxbEE8Oh(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Dispatcher)P_0).Invoke((Action)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Dh4fd8k7nUAySJMhO1f(object P_0, double P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CharacterSize)P_0).Height = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder luk3vOkyKHSSOR1IR8p()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VMQuLZknSE5dECRNNjq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ResourceNode)P_0).HttpRootResourceUri;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PfWTwakfmckIowq0nUt(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type DvvoTHkzckuKHaYdYPD(RuntimeTypeHandle P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lkGx7Dm2JCfj5DGILxK(object P_0, object P_1, Type P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((TypeConverter)P_0).ConvertTo(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MpJ2SmmXvQkgJDvxmyD(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Cognex.Ocr.Client.Tool.Image)P_0).Content = (byte[])P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Hn5E4HmM04p4byl1UHP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((System.Drawing.Image)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vKoA1dmkpq3DkZ4dtK2(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Cognex.Ocr.Client.Tool.Image)P_0).Height = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int HQwSwKmm69jRKFcYsNe(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((System.Drawing.Image)P_0).Width;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double z4fYEJmrMLTAtBin8Be(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Truncate(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SXBeLOmP0N8pa2vWT6n(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((AsyncCache<string, IResultImage>)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void k0hhvXm4crELUvB1AiJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((AsyncCache<string, ELReadResult>)P_0).Dispose();
	}
}
