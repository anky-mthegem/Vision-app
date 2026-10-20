using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Outputs;

public class OutputsSnippetType : EzSupportSnippetType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateSupportSnippet_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzSupportSnippet> _003C_003Et__builder;

		public OutputsSnippetType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private OutputsSnippet _003Coutputs_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			OutputsSnippetType outputsSnippetType = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			EzSupportSnippet result = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					outputsSnippetType = _003C_003E4__this;
					ktv8hxKlyRgNF108HFW8();
					if (!fZVwmsKl03MtXlAoGP16())
					{
						num = 6;
						if (true)
						{
							break;
						}
						goto default;
					}
					num = 5;
					if (!fZVwmsKl03MtXlAoGP16())
					{
						break;
					}
					goto case 1;
				default:
					_003Coutputs_003E5__2 = null;
					num = 1;
					break;
				case 2:
				case 6:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Coutputs_003E5__2 = new OutputsSnippet(outputsSnippetType.Parent);
							ktv8hxKlyRgNF108HFW8();
							if (!fZVwmsKl03MtXlAoGP16())
							{
								num3 = 7;
								if (false)
								{
									goto IL_007f;
								}
							}
							else
							{
								num3 = 8;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 9;
						}
						goto IL_00b2;
						IL_007f:
						num2 = (_003C_003E1__state = -1);
						goto IL_0088;
						IL_0088:
						awaiter.GetResult();
						num3 = 10;
						goto IL_00b2;
						IL_00b2:
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							case 6:
								_003C_003Eu__1 = awaiter;
								goto case 5;
							default:
								num3 = 5;
								continue;
							case 3:
								if (awaiter.IsCompleted)
								{
									goto IL_0088;
								}
								goto case 2;
							case 4:
								return;
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								continue;
							case 9:
								_003C_003Eu__1 = default;
								num3 = 1;
								continue;
							case 0:
							case 7:
								awaiter = YaFUd6KlMkX8R5f3UAdh(axYtHTKlF8BLyNpWqkvl(_003Coutputs_003E5__2, cells, cellRange));
								num3 = 3;
								continue;
							case 2:
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								if (!fZVwmsKl03MtXlAoGP16())
								{
									continue;
								}
								goto case 10;
							case 10:
								result = _003Coutputs_003E5__2;
								goto end_IL_004c;
							}
							break;
						}
						goto IL_007f;
						end_IL_004c:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Coutputs_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 1:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					break;
				case 0:
					num2 = _003C_003E1__state;
					num = 4;
					if (fZVwmsKl03MtXlAoGP16())
					{
					}
					break;
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
		internal static object axYtHTKlF8BLyNpWqkvl(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter YaFUd6KlMkX8R5f3UAdh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ktv8hxKlyRgNF108HFW8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fZVwmsKl03MtXlAoGP16()
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
	private struct _003CAddSupportSnippet_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzSupportSnippet> _003C_003Et__builder;

		public OutputsSnippetType _003C_003E4__this;

		public ISnippetManager snippetManager;

		private TaskAwaiter<EzSupportSnippet> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			EzSupportSnippet result = default;
			OutputsSnippetType outputsSnippetType = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 0:
				case 1:
					outputsSnippetType = _003C_003E4__this;
					goto case 2;
				case 3:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((!zaMoOyKlYajvWIYbDIQ6()) ? 5 : 0);
					break;
				case 2:
				case 5:
					try
					{
						try
						{
							TaskAwaiter<EzSupportSnippet> awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = outputsSnippetType.cbK7uVKjB4(snippetManager).GetAwaiter();
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
								case 2:
									num2 = (_003C_003E1__state = 0);
									num3 = 4;
									continue;
								case 4:
									_003C_003Eu__1 = awaiter;
									YOuXkCKlU3cxskQWeIwk();
									num3 = (zaMoOyKlYajvWIYbDIQ6() ? 1 : 7);
									continue;
								case 8:
									return;
								case 1:
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 8;
									continue;
								case 0:
									_003C_003Eu__1 = default;
									goto case 6;
								case 5:
									if (!awaiter.IsCompleted)
									{
										num3 = 2;
										continue;
									}
									break;
								case 6:
								case 7:
									num2 = (_003C_003E1__state = -1);
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
						catch (CvsNetworkException ex)
						{
							NGGhg5KlxNFr68S3SAiT(Log, GBIkxJKlHALLew9E4cEe(48306), ex);
							goto IL_0199;
						}
						goto end_IL_0062;
						IL_0199:
						result = null;
						end_IL_0062:;
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
		internal static object GBIkxJKlHALLew9E4cEe(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NGGhg5KlxNFr68S3SAiT(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).WarnException((string)P_1, (Exception)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zaMoOyKlYajvWIYbDIQ6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YOuXkCKlU3cxskQWeIwk()
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

		public static Func<CvsCell, bool> _003C_003E9__8_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			BgmN7vKlNBs2vqHFlXME();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			BgmN7vKlNBs2vqHFlXME();
			ddXPEJKl2C1al844a87K(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetUpdates_003Eb__8_0(CvsCell c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return urgcdhKl1nnpZEUySTWn(c.Expression, MSZ0VNKlcjNin4kgjIZp(48414));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BgmN7vKlNBs2vqHFlXME()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mjNNIqKlmBx3FpJTl1Jf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HWxQAPKlQsASKXrl6fVw()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ddXPEJKl2C1al844a87K(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MSZ0VNKlcjNin4kgjIZp(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool urgcdhKl1nnpZEUySTWn(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).StartsWith((string)P_1);
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetUpdates_003Ed__8 : IEnumerable<ISnippetUpdate>, IEnumerable, IEnumerator<ISnippetUpdate>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ISnippetUpdate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private CvsCellCollection cells;

		public CvsCellCollection _003C_003E3__cells;

		private CvsCellRange range;

		public CvsCellRange _003C_003E3__range;

		public OutputsSnippetType _003C_003E4__this;

		private int _003CcurrentVersion_003E5__2;

		private int _003ClatestVersion_003E5__3;

		private string _003Cname_003E5__4;

		ISnippetUpdate IEnumerator<ISnippetUpdate>.Current
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
		public _003CGetUpdates_003Ed__8(int _003C_003E1__state)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!fEOdbXKluDXf1rBkm6h6()) ? 2 : 4);
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					dRYl7HKlz4vxVngDAOQT(this);
					num = 3;
					break;
				case 0:
				case 4:
					uW0adkKltg35F0ZT5dwi();
					goto case 1;
				case 5:
					_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
					num = 6;
					break;
				case 3:
					this._003C_003E1__state = _003C_003E1__state;
					goto case 5;
				default:
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
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 7;
			OutputsSnippetType outputsSnippetType = default;
			CvsCellLocation offset = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					return true;
				case 5:
				case 11:
					if (_003CcurrentVersion_003E5__2 >= _003ClatestVersion_003E5__3)
					{
						break;
					}
					goto case 12;
				case 12:
				case 16:
					_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__3, outputsSnippetType.Localizer, _003Cname_003E5__4);
					num = 15;
					continue;
				case 0:
					return false;
				case 4:
					if (_003CcurrentVersion_003E5__2 < 1)
					{
						offset = zsUlLnKgwdhCbdIdrgrp(cells.FindCellInRange(range, [MethodImpl(MethodImplOptions.NoInlining)] (CvsCell c) =>
						{
							while (false)
							{
								_ = ((object[])null)[0];
							}
							return _003C_003Ec.urgcdhKl1nnpZEUySTWn(c.Expression, _003C_003Ec.MSZ0VNKlcjNin4kgjIZp(48414));
						}));
						num = 2;
						continue;
					}
					goto case 5;
				case 15:
					_003C_003E1__state = 2;
					num = 8;
					if (fEOdbXKluDXf1rBkm6h6())
					{
						continue;
					}
					goto case 2;
				case 2:
					offset.Row -= range.Row;
					goto case 13;
				default:
					num = 13;
					continue;
				case 3:
					switch (num2)
					{
					case 1:
						_003C_003E1__state = -1;
						XBSprKKlhiyINDVmyI3E();
						num = ((!fEOdbXKluDXf1rBkm6h6()) ? 16 : 5);
						break;
					case 0:
						_003C_003E1__state = -1;
						num = 10;
						break;
					default:
						num = 0;
						break;
					case 2:
						_003C_003E1__state = -1;
						num = 17;
						break;
					}
					continue;
				case 1:
					_003C_003E1__state = 1;
					num = 6;
					if (!XBSprKKlhiyINDVmyI3E())
					{
						continue;
					}
					goto case 14;
				case 14:
					outputsSnippetType = _003C_003E4__this;
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					goto case 9;
				case 9:
					_003ClatestVersion_003E5__3 = XIRG96KgKulZkBU4VPMs(outputsSnippetType.UmA7Xds3Jn);
					_003Cname_003E5__4 = (string)jSQYSaKg5faXmIoGThgr(outputsSnippetType.UmA7Xds3Jn);
					num = 4;
					if (XBSprKKlhiyINDVmyI3E())
					{
					}
					continue;
				case 13:
					offset.Column -= range.Column;
					_003C_003E2__current = new EditArgumentUpdate(offset, (string)MdCfFDKgJ57cpeE0osvU(48444), 2, outputsSnippetType.Localizer);
					num = 1;
					if (true)
					{
						continue;
					}
					goto case 7;
				case 7:
					num2 = _003C_003E1__state;
					num = 14;
					if (fEOdbXKluDXf1rBkm6h6())
					{
						continue;
					}
					goto case 10;
				case 10:
					_003CcurrentVersion_003E5__2 = xu0PbxKgLOvMqQ0HcxsZ(cells, range);
					num = 9;
					continue;
				case 8:
					return true;
				case 17:
					break;
				}
				break;
			}
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
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
		IEnumerator<ISnippetUpdate> IEnumerable<ISnippetUpdate>.GetEnumerator()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003CGetUpdates_003Ed__8 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetUpdates_003Ed__8(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			obj.cells = _003C_003E3__cells;
			obj.range = _003C_003E3__range;
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
			return ((IEnumerable<ISnippetUpdate>)this).GetEnumerator();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void uW0adkKltg35F0ZT5dwi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void dRYl7HKlz4vxVngDAOQT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fEOdbXKluDXf1rBkm6h6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XBSprKKlhiyINDVmyI3E()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int xu0PbxKgLOvMqQ0HcxsZ(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int XIRG96KgKulZkBU4VPMs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jSQYSaKg5faXmIoGThgr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSupportSnippetName((PasteBuffer)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation zsUlLnKgwdhCbdIdrgrp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MdCfFDKgJ57cpeE0osvU(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}
	}

	protected static readonly ILogger Log;

	private readonly Guid[] Jcx7FyPWU0;

	private readonly PasteBuffer UmA7Xds3Jn;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Jcx7FyPWU0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OutputsSnippetType(AppStepViewModel appStepVm)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		bGd4qkIM5b3EcBuNm1S();
		int num = (h6bXXrIYDXM82rta2rG() ? 5 : 4);
		while (true)
		{
			switch (num)
			{
			case 3:
				UmA7Xds3Jn = (PasteBuffer)GckQTrIHI9qTg6sbIPW(Snippets.Outputs);
				num = 6;
				continue;
			case 0:
			case 4:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				goto case 1;
			case 6:
				AddSnippet(UmA7Xds3Jn);
				num = 7;
				continue;
			case 1:
			case 5:
				Jcx7FyPWU0 = new Guid[1]
				{
					new Guid((string)yYDStxIUcHcAfMVMBgE(3602))
				};
				num = 2;
				continue;
			case 2:
				base._002Ector(appStepVm);
				goto case 3;
			case 7:
				return;
			}
			num = 3;
			if (!bGd4qkIM5b3EcBuNm1S())
			{
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateSupportSnippet_003Ed__6))]
	public override Task<EzSupportSnippet> CreateSupportSnippet(Guid guid, CvsCellCollection cells, CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateSupportSnippet_003Ed__6 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzSupportSnippet>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cells = cells;
		stateMachine.cellRange = cellRange;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddSupportSnippet_003Ed__7))]
	public override Task<EzSupportSnippet> AddSupportSnippet(ISnippetManager snippetManager)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddSupportSnippet_003Ed__7 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzSupportSnippet>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.snippetManager = snippetManager;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetUpdates_003Ed__8))]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetUpdates_003Ed__8(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__cells = cells,
			_003C_003E3__range = range
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static OutputsSnippetType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		Log = LogManager.GetLogger<OutputsSnippetType>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<EzSupportSnippet> cbK7uVKjB4(ISnippetManager P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.AddSupportSnippet(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yYDStxIUcHcAfMVMBgE(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GckQTrIHI9qTg6sbIPW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bGd4qkIM5b3EcBuNm1S()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool h6bXXrIYDXM82rta2rG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
