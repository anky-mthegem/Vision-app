using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Internal;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public class WriteFtpSettings : EzSupportSnippet
{
	private static class fYOywfRN9FfxTjAJrAY
	{
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLinkWriteImageServerSettings_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public WriteFtpSettings _003C_003E4__this;

		public WriteImageFtp writeImage;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (!R4pxOu5gW2yv0BOrb4ED())
			{
				goto IL_001e;
			}
			goto IL_03c4;
			IL_001e:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_03c4;
			IL_03c4:
			int num2 = default;
			WriteFtpSettings writeFtpSettings = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 2:
				case 4:
					try
					{
						TaskAwaiter<object> awaiter;
						int num3;
						switch (num2)
						{
						default:
							awaiter = ((CvsCogSocketSheet)D6AIMt5g0JK1Jwn3E2sR(xbDUle5gypNaQOh2ujEF(writeFtpSettings.InSight))).PutCellExpressionAsync(XTf5Se5gFdA0cRDKiNge(writeImage.Server), XTf5Se5gFdA0cRDKiNge(writeFtpSettings.Server).ToString()).GetAwaiter();
							num3 = 10;
							if (vNZ8t95gT2VdNisYVNt3())
							{
							}
							goto IL_00fe;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 2;
							if (true)
							{
								goto IL_00fe;
							}
							goto IL_01ad;
						case 2:
							awaiter = _003C_003Eu__1;
							num3 = 3;
							if (true)
							{
								goto IL_00fe;
							}
							goto IL_01d8;
						case 1:
							{
								awaiter = _003C_003Eu__1;
								goto IL_017f;
							}
							IL_00fe:
							while (true)
							{
								switch (num3)
								{
								case 5:
								case 16:
									num2 = (_003C_003E1__state = -1);
									num3 = 17;
									continue;
								case 1:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 2);
										_003C_003Eu__1 = awaiter;
										num3 = 7;
										if (!vNZ8t95gT2VdNisYVNt3())
										{
											continue;
										}
										goto case 8;
									}
									goto case 21;
								case 8:
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__1 = awaiter;
									goto case 20;
								default:
									num3 = 20;
									continue;
								case 20:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 4;
									if (0 == 0)
									{
										continue;
									}
									break;
								case 12:
								case 13:
									break;
								case 19:
									return;
								case 6:
									goto IL_01ad;
								case 18:
									return;
								case 15:
									goto IL_01d8;
								case 0:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 19;
									if (R4pxOu5gW2yv0BOrb4ED())
									{
										continue;
									}
									goto case 11;
								case 11:
									if (!awaiter.IsCompleted)
									{
										num3 = 8;
										continue;
									}
									goto IL_01d8;
								case 7:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 18;
									if (vNZ8t95gT2VdNisYVNt3())
									{
									}
									continue;
								case 4:
									return;
								case 2:
									goto IL_02a0;
								case 9:
									awaiter = ((CvsCogSocketSheet)D6AIMt5g0JK1Jwn3E2sR(xbDUle5gypNaQOh2ujEF(writeFtpSettings.InSight))).PutCellExpressionAsync(XTf5Se5gFdA0cRDKiNge(DDdybZ5gMkZS0khyBwg4(writeImage)), XTf5Se5gFdA0cRDKiNge(writeFtpSettings.UserName).ToString()).GetAwaiter();
									num3 = 11;
									continue;
								case 14:
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									num3 = 0;
									if (R4pxOu5gW2yv0BOrb4ED())
									{
										continue;
									}
									goto case 3;
								case 3:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 21;
									if (R4pxOu5gW2yv0BOrb4ED())
									{
										continue;
									}
									goto case 17;
								case 17:
									awaiter.GetResult();
									num3 = 9;
									continue;
								case 10:
									if (!awaiter.IsCompleted)
									{
										num3 = 14;
										continue;
									}
									goto case 17;
								case 21:
									awaiter.GetResult();
									goto end_IL_0034;
								}
								break;
								IL_02a0:
								_003C_003Eu__1 = default;
								R4pxOu5gW2yv0BOrb4ED();
								num3 = ((!vNZ8t95gT2VdNisYVNt3()) ? 16 : 13);
							}
							goto IL_017f;
							IL_01d8:
							awaiter.GetResult();
							awaiter = ((CvsCogSocketSheet)D6AIMt5g0JK1Jwn3E2sR(xbDUle5gypNaQOh2ujEF(writeFtpSettings.InSight))).PutCellExpressionAsync(((CellViewModel)lXPq8u5gYWSJmtXqEx2m(writeImage)).CellLocation, writeFtpSettings.Password.CellLocation.ToString()).GetAwaiter();
							num3 = 1;
							goto IL_00fe;
							IL_01ad:
							num2 = (_003C_003E1__state = -1);
							num3 = 15;
							goto IL_00fe;
							IL_017f:
							_003C_003Eu__1 = default;
							num3 = 6;
							goto IL_00fe;
							end_IL_0034:
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
					num = 0;
					continue;
				case 1:
				case 3:
					writeFtpSettings = _003C_003E4__this;
					goto case 2;
				case 5:
					num2 = _003C_003E1__state;
					_ = 0;
					num = (R4pxOu5gW2yv0BOrb4ED() ? 3 : 4);
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_001e;
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
		internal static object xbDUle5gypNaQOh2ujEF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object D6AIMt5g0JK1Jwn3E2sR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation XTf5Se5gFdA0cRDKiNge(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DDdybZ5gMkZS0khyBwg4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((WriteImageFtp)P_0).UserName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lXPq8u5gYWSJmtXqEx2m(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((WriteImageFtp)P_0).Password;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool R4pxOu5gW2yv0BOrb4ED()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vNZ8t95gT2VdNisYVNt3()
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
	private struct _003CLinkWriteDataServerSettings_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public WriteFtpSettings _003C_003E4__this;

		public WriteDataFtp writeData;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			int num2 = default;
			WriteFtpSettings writeFtpSettings = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					try
					{
						TaskAwaiter<object> awaiter;
						int num3;
						switch (num2)
						{
						default:
							awaiter = ((CvsCogSocket)IHe2T95gxWCUQ7tywdb8(writeFtpSettings.InSight)).Sheet.PutCellExpressionAsync(ktBHMQ5gmjC9NlXNOSmW(writeData.Server), ktBHMQ5gmjC9NlXNOSmW(writeFtpSettings.Server).ToString()).GetAwaiter();
							num3 = 0;
							goto IL_02e7;
						case 2:
							awaiter = _003C_003Eu__1;
							num3 = 3;
							goto IL_02e7;
						case 0:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 5;
							if (!rQ9xmo5gUOcngsjHtKyt())
							{
								goto IL_01cd;
							}
							goto IL_02e7;
						case 1:
							{
								awaiter = _003C_003Eu__1;
								num3 = 6;
								goto IL_02e7;
							}
							IL_02e7:
							while (true)
							{
								switch (num3)
								{
								case 17:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 4;
									continue;
								case 12:
									awaiter.GetResult();
									awaiter = ((CvsCogSocketSheet)eLQOWm5gQw2PcBn4WdpE(writeFtpSettings.InSight.CogSocket)).PutCellExpressionAsync(ktBHMQ5gmjC9NlXNOSmW(j9fQnH5g2wbj3GDCKd3U(writeData)), ktBHMQ5gmjC9NlXNOSmW(writeFtpSettings.Password).ToString()).GetAwaiter();
									num3 = 19;
									continue;
								case 2:
									_003C_003Eu__1 = awaiter;
									num3 = 14;
									continue;
								case 4:
									return;
								case 20:
									awaiter = ((CvsCogSocketSheet)eLQOWm5gQw2PcBn4WdpE(IHe2T95gxWCUQ7tywdb8(writeFtpSettings.InSight))).PutCellExpressionAsync(ktBHMQ5gmjC9NlXNOSmW(JrDWMD5gNj19ohE6uaPl(writeData)), ktBHMQ5gmjC9NlXNOSmW(writeFtpSettings.UserName).ToString()).GetAwaiter();
									num3 = 16;
									continue;
								case 8:
									num2 = (_003C_003E1__state = 1);
									num3 = 2;
									continue;
								case 16:
									if (!awaiter.IsCompleted)
									{
										num3 = 8;
										continue;
									}
									goto case 12;
								case 15:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 10;
									continue;
								case 10:
									return;
								case 1:
								case 13:
									break;
								case 11:
									goto IL_01e4;
								case 5:
									goto IL_01fb;
								case 7:
									return;
								case 3:
									_003C_003Eu__1 = default;
									goto case 9;
								case 9:
								case 18:
									num2 = (_003C_003E1__state = -1);
									num3 = 21;
									if (KupYa85gH57p0anBhS4Z())
									{
									}
									continue;
								case 19:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 2);
										num3 = 11;
										continue;
									}
									goto case 21;
								case 0:
									if (awaiter.IsCompleted)
									{
										goto IL_01fb;
									}
									num2 = (_003C_003E1__state = 0);
									_ = 1;
									if (KupYa85gH57p0anBhS4Z())
									{
										num3 = 9;
										continue;
									}
									num3 = 13;
									if (0 == 0)
									{
										continue;
									}
									goto case 6;
								case 6:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 12;
									continue;
								case 14:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 7;
									continue;
								case 21:
									awaiter.GetResult();
									goto end_IL_0019;
								}
								break;
							}
							goto IL_01cd;
							IL_01cd:
							_003C_003Eu__1 = awaiter;
							num3 = 15;
							if (!rQ9xmo5gUOcngsjHtKyt())
							{
								goto IL_01e4;
							}
							goto IL_02e7;
							IL_01e4:
							_003C_003Eu__1 = awaiter;
							num3 = 17;
							if (!rQ9xmo5gUOcngsjHtKyt())
							{
								goto IL_01fb;
							}
							goto IL_02e7;
							IL_01fb:
							awaiter.GetResult();
							num3 = 20;
							goto IL_02e7;
							end_IL_0019:
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
					_003C_003Et__builder.SetResult();
					num = 6;
					if (KupYa85gH57p0anBhS4Z())
					{
					}
					break;
				case 2:
					num2 = _003C_003E1__state;
					KupYa85gH57p0anBhS4Z();
					if (!rQ9xmo5gUOcngsjHtKyt())
					{
						num = 0;
						if (!KupYa85gH57p0anBhS4Z())
						{
							break;
						}
						goto default;
					}
					num = 5;
					break;
				case 1:
				case 5:
					writeFtpSettings = _003C_003E4__this;
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
		internal static object IHe2T95gxWCUQ7tywdb8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation ktBHMQ5gmjC9NlXNOSmW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eLQOWm5gQw2PcBn4WdpE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object JrDWMD5gNj19ohE6uaPl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((WriteDataFtp)P_0).UserName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object j9fQnH5g2wbj3GDCKd3U(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((WriteDataFtp)P_0).Password;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rQ9xmo5gUOcngsjHtKyt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KupYa85gH57p0anBhS4Z()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private EditStringViewModel zY6PJFCGvE;

	[CompilerGenerated]
	private EditStringViewModel JZ1P9K0sly;

	[CompilerGenerated]
	private EditStringViewModel wQcPr04S42;

	public override string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)wILM4mucOK3nKCstw6h();
		}
	}

	public EditStringViewModel Server
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zY6PJFCGvE;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zY6PJFCGvE = value;
		}
	}

	public EditStringViewModel UserName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return JZ1P9K0sly;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			JZ1P9K0sly = value;
		}
	}

	public EditStringViewModel Password
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wQcPr04S42;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			wQcPr04S42 = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WriteFtpSettings(AppStepViewModel appStepVm)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		mh2C4Yu2gHBWoyYomWj();
		base._002Ector(appStepVm);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Task Parse(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		CvsCellRange cellRange = default;
		IEnumerator<CvsCellLocation> enumerator = default;
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				cellRange = CellRange;
				goto default;
			case 3:
				RemoveAllProperties();
				_ = 0;
				if (!D5ha64uQKRqXR5OOIxu())
				{
					num = 4;
					break;
				}
				num = 0;
				if (D5ha64uQKRqXR5OOIxu())
				{
					break;
				}
				goto default;
			default:
				enumerator = cellRange.GetEnumerator();
				num = 5;
				break;
			case 5:
				try
				{
					while (hhJHoHh5Q1OZpsEWnoD(enumerator))
					{
						CvsCellLocation current = enumerator.Current;
						int num2 = 5;
						while (true)
						{
							object obj2;
							switch (num2)
							{
							case 10:
								Password = new EditStringViewModel(InSight, cells, current, (string)tZqtABhK6WlbW0iYnYW());
								num2 = 2;
								continue;
							case 1:
							case 9:
								obj2 = null;
								goto IL_00d5;
							case 2:
								Password.Internal = true;
								goto case 6;
							case 12:
								UserName.Internal = true;
								num2 = 13;
								continue;
							default:
								num2 = 12;
								continue;
							case 13:
								AddProperty(UserName);
								num2 = 3;
								if (true)
								{
									continue;
								}
								goto case 6;
							case 6:
							case 11:
								AddProperty(Password);
								num2 = 14;
								continue;
							case 7:
								if (!text.EndsWith((string)x0vMtGuuIIm8Tl8WIQ3(30546), StringComparison.Ordinal))
								{
									if (dBC5aIuzTnqZNbJOQgY(text, x0vMtGuuIIm8Tl8WIQ3(30570), StringComparison.Ordinal))
									{
										UserName = new EditStringViewModel(InSight, cells, current, (string)gONM1vhLd41icAK6MUS());
										goto case 12;
									}
									if (text.EndsWith(CdQUGaROfy7He9T0foW.KbIzwHEDLa(30598), StringComparison.Ordinal))
									{
										num2 = 10;
										continue;
									}
									break;
								}
								Server = new EditStringViewModel(InSight, cells, current, (string)DDrW4Uuhl85V0BtWQot());
								num2 = 8;
								continue;
							case 5:
							{
								object obj = mLQOrtu1dCl0nUHTa41(cells, current);
								if (obj != null)
								{
									obj2 = ((CvsCell)obj).Name;
									goto IL_00d5;
								}
								_ = 0;
								if (!D5ha64uQKRqXR5OOIxu())
								{
									num2 = 6;
									if (D5ha64uQKRqXR5OOIxu())
									{
										continue;
									}
									goto case 12;
								}
								num2 = 9;
								continue;
							}
							case 8:
								MImMJputOgoI44SJQS9(Server, true);
								num2 = 4;
								if (true)
								{
									continue;
								}
								break;
							case 4:
								AddProperty(Server);
								num2 = 0;
								continue;
							case 0:
							case 3:
							case 14:
								break;
								IL_00d5:
								text = (string)obj2;
								if (text != null)
								{
									num2 = 7;
									continue;
								}
								break;
							}
							break;
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						mgU4hChwdgsNXCRbd5B(enumerator);
					}
				}
				return Task.CompletedTask;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLinkWriteImageServerSettings_003Ed__17))]
	public Task LinkWriteImageServerSettings(WriteImageFtp writeImage)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (!D5ha64uQKRqXR5OOIxu())
		{
			goto IL_001e;
		}
		goto IL_0038;
		IL_001e:
		_003CLinkWriteImageServerSettings_003Ed__17 stateMachine = default;
		stateMachine.writeImage = writeImage;
		goto IL_00b9;
		IL_0038:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				break;
			default:
				num = 4;
				continue;
			case 1:
			case 6:
				stateMachine._003C_003E4__this = this;
				break;
			case 5:
				goto IL_007f;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 4:
				goto IL_00b9;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
			IL_007f:
			stateMachine._003C_003Et__builder = OyHmechJeSPuIrfyJJr();
			_ = 1;
			num = ((!ByJDuduNxqSgATEe85i()) ? 6 : 0);
		}
		goto IL_001e;
		IL_00b9:
		stateMachine._003C_003E1__state = -1;
		num = 3;
		goto IL_0038;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLinkWriteDataServerSettings_003Ed__18))]
	public Task LinkWriteDataServerSettings(WriteDataFtp writeData)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003CLinkWriteDataServerSettings_003Ed__18 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			case 0:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				if (!D5ha64uQKRqXR5OOIxu())
				{
					num = 3;
					break;
				}
				num = 1;
				if (!ByJDuduNxqSgATEe85i())
				{
					break;
				}
				goto case 3;
			case 3:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 1:
			case 2:
				stateMachine.writeData = writeData;
				goto case 5;
			default:
				num = 5;
				break;
			case 6:
				stateMachine._003C_003Et__builder = OyHmechJeSPuIrfyJJr();
				num = 0;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mh2C4Yu2gHBWoyYomWj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool D5ha64uQKRqXR5OOIxu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ByJDuduNxqSgATEe85i()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wILM4mucOK3nKCstw6h()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.M5Ym3sOkOB();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mLQOrtu1dCl0nUHTa41(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object x0vMtGuuIIm8Tl8WIQ3(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DDrW4Uuhl85V0BtWQot()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.kMQr56dmnF();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MImMJputOgoI44SJQS9(object P_0, bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CellViewModel)P_0).Internal = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dBC5aIuzTnqZNbJOQgY(object P_0, object P_1, StringComparison P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).EndsWith((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gONM1vhLd41icAK6MUS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.S9uhrEc42k();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tZqtABhK6WlbW0iYnYW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.PYQLVi1wyC();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hhJHoHh5Q1OZpsEWnoD(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mgU4hChwdgsNXCRbd5B(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder OyHmechJeSPuIrfyJJr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
