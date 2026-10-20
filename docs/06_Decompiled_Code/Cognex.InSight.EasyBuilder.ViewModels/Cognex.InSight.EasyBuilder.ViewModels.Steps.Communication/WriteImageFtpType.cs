using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public class WriteImageFtpType : EzSupportSnippetType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateSupportSnippet_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzSupportSnippet> _003C_003Et__builder;

		public WriteImageFtpType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private WriteImageFtp _003CwriteImage_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_01dd;
			IL_001a:
			EzSupportSnippet result = default;
			_003C_003Et__builder.SetResult(result);
			num = 7;
			goto IL_01dd;
			IL_01dd:
			int num2 = default;
			WriteImageFtpType writeImageFtpType = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					break;
				default:
					_003CwriteImage_003E5__2 = null;
					num = 6;
					continue;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003CwriteImage_003E5__2 = new WriteImageFtp(writeImageFtpType.Parent, writeImageFtpType.Localizer);
							num3 = 2;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
							if (!UDOaRh5srBVh60ip0xe1())
							{
								goto IL_015c;
							}
						}
						goto IL_00bb;
						IL_015c:
						num2 = (_003C_003E1__state = -1);
						goto IL_0165;
						IL_0165:
						awaiter.GetResult();
						num3 = 10;
						goto IL_00bb;
						IL_00bb:
						while (true)
						{
							switch (num3)
							{
							case 9:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								continue;
							case 2:
								awaiter = riGSGE5sBnVGAW7PcI8X(ls8FeX5sZrx6R8cwY77l(_003CwriteImage_003E5__2, cells, cellRange));
								num3 = 6;
								continue;
							case 5:
								_003C_003Eu__1 = awaiter;
								goto default;
							default:
								_ = 0;
								if (UDOaRh5srBVh60ip0xe1())
								{
									num3 = 0;
									if (jjSlCa5sPFJ6iRHmhivQ())
									{
									}
								}
								else
								{
									num3 = 1;
								}
								continue;
							case 3:
								_003C_003Eu__1 = default;
								goto end_IL_00bb;
							case 6:
								break;
							case 8:
								return;
							case 1:
							case 7:
								goto end_IL_00bb;
							case 0:
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								if (UDOaRh5srBVh60ip0xe1())
								{
									continue;
								}
								goto case 10;
							case 10:
								result = _003CwriteImage_003E5__2;
								goto end_IL_0041;
							}
							if (!awaiter.IsCompleted)
							{
								num3 = 9;
								if (1 == 0)
								{
									return;
								}
								continue;
							}
							goto IL_0165;
							continue;
							end_IL_00bb:
							break;
						}
						goto IL_015c;
						end_IL_0041:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CwriteImage_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 5:
					do
					{
						writeImageFtpType = _003C_003E4__this;
						_ = 1;
						if (jjSlCa5sPFJ6iRHmhivQ())
						{
							num = 0;
							continue;
						}
						num = 1;
						break;
					}
					while (false);
					continue;
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_001a;
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
		internal static object ls8FeX5sZrx6R8cwY77l(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter riGSGE5sBnVGAW7PcI8X(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UDOaRh5srBVh60ip0xe1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jjSlCa5sPFJ6iRHmhivQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetUpdates_003Ed__7 : IEnumerable<ISnippetUpdate>, IEnumerable, IEnumerator<ISnippetUpdate>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ISnippetUpdate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private CvsCellCollection cells;

		public CvsCellCollection _003C_003E3__cells;

		private CvsCellRange range;

		public CvsCellRange _003C_003E3__range;

		public WriteImageFtpType _003C_003E4__this;

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
		public _003CGetUpdates_003Ed__7(int _003C_003E1__state)
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
					_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
					num = 6;
					break;
				case 0:
					Ck78Fw5sSpcmLAjLiMUQ(this);
					_ = 1;
					if (!bafoJt5sGYbbufvDUxcX())
					{
						num = 1;
						if (0 == 0)
						{
							break;
						}
						goto case 1;
					}
					num = 5;
					break;
				case 1:
				case 2:
					this._003C_003E1__state = _003C_003E1__state;
					goto default;
				case 4:
					s2XGPw5so0QLtiL8LcUA();
					num = 0;
					if (!ksgHDU5sb8a1Y7BqwWLq())
					{
						return;
					}
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
			int num = 1;
			int num2 = default;
			WriteImageFtpType writeImageFtpType = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					return true;
				case 23:
					return true;
				case 1:
					num2 = _003C_003E1__state;
					num = 9;
					continue;
				case 11:
					return true;
				case 20:
					_003C_003E2__current = new CellNameUpdate(CdQUGaROfy7He9T0foW.KbIzwHEDLa(53918), oldNameIsInternal: false, (string)QHO8gn5sEBBHCerohRTG(53970), newNameIsInternal: true, isSupportSnippet: true);
					bafoJt5sGYbbufvDUxcX();
					num = ((!ksgHDU5sb8a1Y7BqwWLq()) ? 4 : 12);
					continue;
				case 7:
					if (_003CcurrentVersion_003E5__2 >= 3)
					{
						goto case 3;
					}
					_003C_003E2__current = new CellNameUpdate((string)QHO8gn5sEBBHCerohRTG(53876), oldNameIsInternal: false, (string)QHO8gn5sEBBHCerohRTG(53918), newNameIsInternal: false, isSupportSnippet: true);
					goto case 22;
				default:
					num = 22;
					continue;
				case 3:
					if (_003CcurrentVersion_003E5__2 < 4)
					{
						num = 20;
						continue;
					}
					goto case 10;
				case 9:
					writeImageFtpType = _003C_003E4__this;
					num = 8;
					continue;
				case 4:
				case 21:
					_003C_003E1__state = 6;
					num = 19;
					if (0 == 0)
					{
						continue;
					}
					goto case 10;
				case 10:
					if (_003CcurrentVersion_003E5__2 < 5)
					{
						_003C_003E2__current = new PngUpdate(writeImageFtpType.Localizer);
						_003C_003E1__state = 5;
						num = 6;
						if (bafoJt5sGYbbufvDUxcX())
						{
						}
						continue;
					}
					goto case 0;
				case 16:
					_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__3, writeImageFtpType.Localizer, _003Cname_003E5__4);
					goto case 4;
				case 17:
					_003CcurrentVersion_003E5__2 = vBhE9Y5skyTGlP1BMJFC(cells, range);
					_003ClatestVersion_003E5__3 = OR6Q8R5s86eLHAppbu72(writeImageFtpType.GnTsOAb8gk);
					num = 18;
					if (true)
					{
						continue;
					}
					goto case 24;
				case 24:
					_003C_003E1__state = 1;
					return true;
				case 2:
					return false;
				case 8:
					switch (num2)
					{
					case 5:
						break;
					case 4:
						goto IL_002d;
					case 2:
						goto IL_0051;
					case 1:
						goto IL_0231;
					case 0:
						goto IL_0246;
					default:
						goto IL_0279;
					case 6:
						goto IL_02ba;
					case 3:
						goto IL_02d4;
					}
					_003C_003E1__state = -1;
					num = 0;
					continue;
				case 12:
				case 15:
					_003C_003E1__state = 4;
					num = 23;
					continue;
				case 13:
					_003C_003E2__current = new AddTimestampOption(writeImageFtpType.Localizer);
					_003C_003E1__state = 2;
					num = 11;
					continue;
				case 19:
					return true;
				case 22:
					_003C_003E1__state = 3;
					return true;
				case 5:
					if (_003CcurrentVersion_003E5__2 < 2)
					{
						num = 13;
						continue;
					}
					goto case 7;
				case 14:
					_003C_003E2__current = new SftpUpdate(writeImageFtpType.Localizer);
					num = 24;
					continue;
				case 0:
					if (_003CcurrentVersion_003E5__2 >= _003ClatestVersion_003E5__3)
					{
						break;
					}
					num = 16;
					if (!bafoJt5sGYbbufvDUxcX())
					{
						continue;
					}
					goto case 18;
				case 18:
					_003Cname_003E5__4 = (string)mgQIUu5sq6YUwoEDbaAF(writeImageFtpType.GnTsOAb8gk);
					if (_003CcurrentVersion_003E5__2 < 1)
					{
						num = 14;
						continue;
					}
					goto case 5;
				case 25:
					break;
					IL_02d4:
					_003C_003E1__state = -1;
					num = 3;
					continue;
					IL_02ba:
					_003C_003E1__state = -1;
					num = 25;
					continue;
					IL_0279:
					num = 2;
					if (0 == 0)
					{
						continue;
					}
					goto case 12;
					IL_0246:
					_003C_003E1__state = -1;
					num = 17;
					continue;
					IL_0231:
					_003C_003E1__state = -1;
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					goto case 2;
					IL_0051:
					_003C_003E1__state = -1;
					num = 7;
					continue;
					IL_002d:
					_003C_003E1__state = -1;
					num = 10;
					continue;
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
			_003CGetUpdates_003Ed__7 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetUpdates_003Ed__7(0)
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
		internal static void s2XGPw5so0QLtiL8LcUA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Ck78Fw5sSpcmLAjLiMUQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ksgHDU5sb8a1Y7BqwWLq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bafoJt5sGYbbufvDUxcX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int vBhE9Y5skyTGlP1BMJFC(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int OR6Q8R5s86eLHAppbu72(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mgQIUu5sq6YUwoEDbaAF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSupportSnippetName((PasteBuffer)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QHO8gn5sEBBHCerohRTG(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}
	}

	private readonly Guid[] tRpsCiwkZV;

	private readonly PasteBuffer GnTsOAb8gk;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tRpsCiwkZV;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WriteImageFtpType(AppStepViewModel appStepVm)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				AddSnippet(GnTsOAb8gk, yNVsj1hPKx());
				num = 7;
				if (Kcv5cQh37XHpiG985vV())
				{
					break;
				}
				goto case 1;
			case 1:
			case 5:
				tRpsCiwkZV = new Guid[1]
				{
					new Guid((string)GhmqrphC7M9gb8wnGae(31428))
				};
				num = 3;
				if (Kcv5cQh37XHpiG985vV())
				{
					break;
				}
				goto case 2;
			case 2:
				JIy43Kh64yE2RTNlQZc();
				_ = 1;
				if (!fXkWlHhj2J3sdjQ4E0f())
				{
					num = 5;
					break;
				}
				num = 0;
				if (!fXkWlHhj2J3sdjQ4E0f())
				{
					break;
				}
				goto case 3;
			case 6:
				GnTsOAb8gk = (PasteBuffer)RQOnJNhRy4mI8Emjebu(zArgGbhAFTXYksrlmPW());
				goto case 0;
			case 3:
				base._002Ector(appStepVm);
				goto case 6;
			default:
				num = 6;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SnippetLocalizer yNVsj1hPKx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		SnippetLocalizer snippetLocalizer = EzSnippetType.CreateDefaultSnippetLocalizer();
		snippetLocalizer.ExcludedCellOffsets.Add(GnTsOAb8gk.GetCellOffset((string)GhmqrphC7M9gb8wnGae(30890)));
		CvsCellLocation cellOffset = GnTsOAb8gk.GetCellOffset((string)GhmqrphC7M9gb8wnGae(31304));
		CvsCellLocation item = cellOffset;
		item.Column++;
		snippetLocalizer.ExcludedCellOffsets.Add(cellOffset);
		snippetLocalizer.ExcludedCellOffsets.Add(item);
		return snippetLocalizer;
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
	[IteratorStateMachine(typeof(_003CGetUpdates_003Ed__7))]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetUpdates_003Ed__7(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__cells = cells,
			_003C_003E3__range = range
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JIy43Kh64yE2RTNlQZc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GhmqrphC7M9gb8wnGae(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zArgGbhAFTXYksrlmPW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.WriteImageFtp;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RQOnJNhRy4mI8Emjebu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Kcv5cQh37XHpiG985vV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fXkWlHhj2J3sdjQ4E0f()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
