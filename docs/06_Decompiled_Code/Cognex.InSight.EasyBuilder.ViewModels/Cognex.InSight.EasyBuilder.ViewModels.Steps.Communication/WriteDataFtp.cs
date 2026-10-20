using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Internal;
using Cognex.InSight.Runtime.ViewModels;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public class WriteDataFtp : EzFormatStringSupportSnippet
{
	internal static class jC2IglRF6AW7Hl6ssX5
	{
	}

	public enum FtpStorage
	{
		LocalDevice,
		FTPServer,
		SFTPServer
	}

	public enum DataFileType
	{
		TXT,
		HTML,
		XML,
		CSV
	}

	public enum WriteType
	{
		Overwrite,
		Append
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CParse_003Ed__64 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public WriteDataFtp _003C_003E4__this;

		public CvsCellCollection cells;

		private IEnumerator<CvsCellLocation> _003C_003E7__wrap1;

		private CvsCellLocation _003Cloc_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ID66BE5lBUnEK6pLTQyD();
			int num;
			if (hd4Btp5lZEJJfvtuIW7I())
			{
				num = 1;
				if (ID66BE5lBUnEK6pLTQyD())
				{
				}
			}
			else
			{
				num = 2;
			}
			int num2 = default;
			WriteDataFtp writeDataFtp = default;
			TaskAwaiter awaiter = default;
			string text = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					try
					{
						if (num2 != 0)
						{
							writeDataFtp.mOZkmKAAsd();
							writeDataFtp.RemoveAllProperties();
							_003C_003E7__wrap1 = writeDataFtp.CellRange.GetEnumerator();
						}
						try
						{
							if (num2 != 0)
							{
								goto IL_07bf;
							}
							awaiter = _003C_003Eu__1;
							int num3 = 39;
							goto IL_0423;
							IL_0423:
							while (true)
							{
								switch (num3)
								{
								case 1:
								case 5:
									writeDataFtp.Storage = new ListBoxViewModel(writeDataFtp.InSight, cells, _003Cloc_003E5__3, Resources.Storage, null, null, new List<string> { (string)YHqCKX5lojMwcdufZmFe(53174) });
									num3 = 14;
									if (hd4Btp5lZEJJfvtuIW7I())
									{
										continue;
									}
									goto case 0;
								case 7:
									rm8Pr65lpBmYEUaZ7MTX(writeDataFtp.UserName, true);
									num3 = 17;
									continue;
								case 8:
									if (!awaiter.IsCompleted)
									{
										num3 = 12;
										if (!ID66BE5lBUnEK6pLTQyD())
										{
											continue;
										}
										goto case 18;
									}
									goto case 38;
								case 18:
									if (qYpiFE5lShyfCmlBSVdE(text, YHqCKX5lojMwcdufZmFe(53086), StringComparison.Ordinal))
									{
										num3 = 31;
										continue;
									}
									if (!qYpiFE5lShyfCmlBSVdE(text, YHqCKX5lojMwcdufZmFe(53130), StringComparison.Ordinal))
									{
										if (!qYpiFE5lShyfCmlBSVdE(text, YHqCKX5lojMwcdufZmFe(53200), StringComparison.Ordinal))
										{
											if (qYpiFE5lShyfCmlBSVdE(text, YHqCKX5lojMwcdufZmFe(53246), StringComparison.Ordinal))
											{
												num3 = 23;
												continue;
											}
											if (!qYpiFE5lShyfCmlBSVdE(text, YHqCKX5lojMwcdufZmFe(53292), StringComparison.Ordinal))
											{
												if (qYpiFE5lShyfCmlBSVdE(text, YHqCKX5lojMwcdufZmFe(53334), StringComparison.Ordinal))
												{
													writeDataFtp.UserName = new EditStringViewModel(writeDataFtp.InSight, cells, _003Cloc_003E5__3, Resources.S9uhrEc42k());
													num3 = 7;
													continue;
												}
												if (!qYpiFE5lShyfCmlBSVdE(text, CdQUGaROfy7He9T0foW.KbIzwHEDLa(53380), StringComparison.Ordinal))
												{
													if (qYpiFE5lShyfCmlBSVdE(text, YHqCKX5lojMwcdufZmFe(53426), StringComparison.Ordinal))
													{
														writeDataFtp.Append = new ListBoxViewModel(writeDataFtp.InSight, cells, _003Cloc_003E5__3, Resources.IYQB3WgNjp());
														num3 = 4;
														continue;
													}
													if (qYpiFE5lShyfCmlBSVdE(text, YHqCKX5lojMwcdufZmFe(53468), StringComparison.Ordinal))
													{
														num3 = 3;
														continue;
													}
													if (qYpiFE5lShyfCmlBSVdE(text, YHqCKX5lojMwcdufZmFe(30398), StringComparison.Ordinal))
													{
														num3 = 22;
														continue;
													}
													if (qYpiFE5lShyfCmlBSVdE(text, YHqCKX5lojMwcdufZmFe(30352), StringComparison.Ordinal))
													{
														writeDataFtp.FileType = new ListBoxViewModel(writeDataFtp.InSight, cells, _003Cloc_003E5__3, Resources.FileType);
														num3 = 27;
														if (true)
														{
															continue;
														}
														goto case 25;
													}
													if (qYpiFE5lShyfCmlBSVdE(text, YHqCKX5lojMwcdufZmFe(53516), StringComparison.Ordinal))
													{
														writeDataFtp.FileNamePreview = new StringViewModel(writeDataFtp.InSight, cells, _003Cloc_003E5__3, (string)W5M25f5l7MOnDkq3tcln());
														writeDataFtp.AddProperty(writeDataFtp.FileNamePreview);
														num3 = 35;
														continue;
													}
													if (qYpiFE5lShyfCmlBSVdE(text, CdQUGaROfy7He9T0foW.KbIzwHEDLa(53576), StringComparison.Ordinal))
													{
														num3 = 20;
														if (true)
														{
															continue;
														}
														goto case 21;
													}
												}
												else
												{
													writeDataFtp.Password = new EditStringViewModel(writeDataFtp.InSight, cells, _003Cloc_003E5__3, (string)mYCVk75lXBEpTtuAa7yt());
													writeDataFtp.Password.Internal = true;
													writeDataFtp.AddProperty(writeDataFtp.Password);
												}
												goto case 0;
											}
											writeDataFtp.Server = new EditStringViewModel(writeDataFtp.InSight, cells, _003Cloc_003E5__3, (string)hs7WOa5lEZcvIbetMr22());
											num3 = 9;
											continue;
										}
										num3 = 26;
										continue;
									}
									ID66BE5lBUnEK6pLTQyD();
									num3 = (hd4Btp5lZEJJfvtuIW7I() ? 1 : 2);
									continue;
								case 12:
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									num3 = 21;
									continue;
								case 23:
									writeDataFtp.FileName = new EditStringViewModel(writeDataFtp.InSight, cells, _003Cloc_003E5__3, (string)TH6fIR5lqC4CXIK8wo6O());
									num3 = 25;
									continue;
								case 21:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 15;
									continue;
								case 30:
									writeDataFtp.AddProperty(writeDataFtp.TimestampFormat);
									num3 = 29;
									if (0 == 0)
									{
										continue;
									}
									goto case 16;
								case 16:
									writeDataFtp.ssxPSSYMC2 = _003Cloc_003E5__3;
									num3 = 32;
									continue;
								case 31:
									writeDataFtp.Enabled = new CheckBoxViewModel(writeDataFtp.InSight, cells, _003Cloc_003E5__3, (string)GNgNok5lkAUj4XfxdR9X(), isInitialized: true);
									num3 = 37;
									if (true)
									{
										continue;
									}
									goto case 34;
								case 34:
								{
									object obj = Ab0InP5lbCpKRDmxhSXp(cells, _003Cloc_003E5__3);
									text = (string)((obj != null) ? MAGXQ45lGi8d6pLv1hWt(obj) : null);
									if (text == null)
									{
										break;
									}
									num3 = 18;
									if (true)
									{
										continue;
									}
									goto case 33;
								}
								case 33:
									awaiter = ((Task)d094B25lCohkstUTcjPJ(hglk2U5l67ONNH00u9B3(writeDataFtp), cells)).GetAwaiter();
									num3 = 8;
									continue;
								case 0:
								case 2:
								case 6:
								case 10:
								case 11:
								case 13:
								case 28:
								case 29:
								case 32:
								case 35:
								case 36:
								case 40:
									_003Cloc_003E5__3 = default;
									num3 = 41;
									continue;
								case 19:
									writeDataFtp.AddProperty(writeDataFtp.FilePath);
									goto case 0;
								case 26:
									writeDataFtp.FilePath = new EditStringViewModel(writeDataFtp.InSight, cells, _003Cloc_003E5__3, (string)qXgjfd5l8EqECjVO5lK6());
									num3 = 19;
									if (!ID66BE5lBUnEK6pLTQyD())
									{
										continue;
									}
									goto case 24;
								case 24:
									writeDataFtp.AddProperty(writeDataFtp.Server);
									num3 = 36;
									continue;
								default:
									num3 = 0;
									if (true)
									{
										continue;
									}
									goto case 37;
								case 37:
									writeDataFtp.AddProperty(writeDataFtp.Enabled);
									num3 = 6;
									continue;
								case 38:
									awaiter.GetResult();
									TxoXX35lAeIwCaWkjrdw(hglk2U5l67ONNH00u9B3(writeDataFtp), new EventHandler(writeDataFtp.nCgk1POB8u));
									num3 = 16;
									if (ID66BE5lBUnEK6pLTQyD())
									{
									}
									continue;
								case 9:
									writeDataFtp.Server.Internal = true;
									num3 = 24;
									continue;
								case 27:
									writeDataFtp.AddProperty(writeDataFtp.FileType);
									goto case 0;
								case 39:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 38;
									continue;
								case 3:
									writeDataFtp.Timestamp = new CheckBoxViewModel(writeDataFtp.InSight, cells, _003Cloc_003E5__3, (string)LTa2T05l98BRrrsucWpe(), isInitialized: true);
									writeDataFtp.AddProperty(writeDataFtp.Timestamp);
									goto case 0;
								case 15:
									return;
								case 22:
									writeDataFtp.TimestampFormat = new ListBoxViewModel(writeDataFtp.InSight, cells, _003Cloc_003E5__3, (string)ajdxGT5l4DijDLKnlKoP());
									num3 = 30;
									continue;
								case 20:
									V2sepR5ljs56An3LS7om(writeDataFtp, new EzFormatStringViewModel((CommStepViewModel)writeDataFtp.Parent, zstVDM5l3tC1DPRjedEH(writeDataFtp), _003Cloc_003E5__3));
									num3 = 33;
									if (hd4Btp5lZEJJfvtuIW7I())
									{
										continue;
									}
									goto case 4;
								case 4:
									writeDataFtp.AddProperty(writeDataFtp.Append);
									num3 = 13;
									if (0 == 0)
									{
										continue;
									}
									goto case 17;
								case 17:
									writeDataFtp.AddProperty(writeDataFtp.UserName);
									num3 = 40;
									if (true)
									{
										continue;
									}
									goto case 0;
								case 25:
									writeDataFtp.AddProperty(writeDataFtp.FileName);
									num3 = 28;
									continue;
								case 14:
									writeDataFtp.AddProperty(writeDataFtp.Storage);
									num3 = 11;
									continue;
								case 41:
									break;
								}
								break;
							}
							goto IL_07bf;
							IL_07bf:
							if (p8FHqe5lRn6oC7iNnr0D(_003C_003E7__wrap1))
							{
								_003Cloc_003E5__3 = _003C_003E7__wrap1.Current;
								num3 = 34;
								goto IL_0423;
							}
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								_003C_003E7__wrap1.Dispose();
							}
						}
						_003C_003E7__wrap1 = null;
						IEnumerator<CellViewModel> enumerator = writeDataFtp.Properties.GetEnumerator();
						try
						{
							while (p8FHqe5lRn6oC7iNnr0D(enumerator))
							{
								enumerator.Current.SourcePropertyChanged += writeDataFtp.FLkk8wX3WG;
							}
						}
						finally
						{
							if (num2 < 0 && enumerator != null)
							{
								XInV8E5lWCA9kb92BZat(enumerator);
							}
						}
						GtFsX95lToNliR1LDRFQ(writeDataFtp.FileName, new PropertyChangedEventHandler(writeDataFtp.SsikzySL5q));
						GtFsX95lToNliR1LDRFQ(writeDataFtp.TimestampFormat, new PropertyChangedEventHandler(writeDataFtp.SsikzySL5q));
						GtFsX95lToNliR1LDRFQ(writeDataFtp.Timestamp, new PropertyChangedEventHandler(writeDataFtp.SsikzySL5q));
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
					writeDataFtp = _003C_003E4__this;
					num = 4;
					continue;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
				if (ID66BE5lBUnEK6pLTQyD())
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
		internal static object Ab0InP5lbCpKRDmxhSXp(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MAGXQ45lGi8d6pLv1hWt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YHqCKX5lojMwcdufZmFe(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qYpiFE5lShyfCmlBSVdE(object P_0, object P_1, StringComparison P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).EndsWith((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GNgNok5lkAUj4XfxdR9X()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.Enabled;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qXgjfd5l8EqECjVO5lK6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.WOOnmyCMHM();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TH6fIR5lqC4CXIK8wo6O()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.QBWn9gQrv4();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hs7WOa5lEZcvIbetMr22()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.kMQr56dmnF();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void rm8Pr65lpBmYEUaZ7MTX(object P_0, bool value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CellViewModel)P_0).Internal = value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mYCVk75lXBEpTtuAa7yt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.PYQLVi1wyC();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LTa2T05l98BRrrsucWpe()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.aQOrLYhPvC();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ajdxGT5l4DijDLKnlKoP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.eDYr9QBHLO();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object W5M25f5l7MOnDkq3tcln()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.d5inhBYKTI();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Type zstVDM5l3tC1DPRjedEH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0.GetType();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void V2sepR5ljs56An3LS7om(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EzFormatStringSupportSnippet)P_0).FormatString = (EzFormatStringViewModel)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hglk2U5l67ONNH00u9B3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzFormatStringSupportSnippet)P_0).FormatString;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object d094B25lCohkstUTcjPJ(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzFormatStringViewModel)P_0).InitializeAsync((CvsCellCollection)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void TxoXX35lAeIwCaWkjrdw(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EzFormatStringViewModel)P_0).FormatStringClosed += (EventHandler)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool p8FHqe5lRn6oC7iNnr0D(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void XInV8E5lWCA9kb92BZat(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GtFsX95lToNliR1LDRFQ(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hd4Btp5lZEJJfvtuIW7I()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ID66BE5lBUnEK6pLTQyD()
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
	private struct _003CEnableSource_SourcePropertyChanged_003Ed__65 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public WriteDataFtp _003C_003E4__this;

		public object sender;

		public PropertyValueChangedEventArgs<CellViewModel> args;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			if (!onNRMs5lyFcqpgLEfEC5())
			{
				goto IL_001e;
			}
			goto IL_01df;
			IL_001e:
			int num2 = default;
			WriteDataFtp writeDataFtp = default;
			try
			{
				int num3;
				object obj2;
				TaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					AppStepViewModel parent = writeDataFtp.Parent;
					if (parent == null)
					{
						num3 = 7;
					}
					else
					{
						object obj = j9r2NQ5lFPXl296HQ6m7(parent);
						if (obj != null)
						{
							obj2 = ((EasyBuilderApplicationViewModel)obj).PropertyLinks;
							goto IL_0097;
						}
						num3 = 4;
						if (1 == 0)
						{
							return;
						}
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 11;
				}
				goto IL_0154;
				IL_0154:
				CellViewModel cellViewModel = default;
				while (true)
				{
					switch (num3)
					{
					case 9:
						break;
					case 7:
						goto end_IL_0154;
					case 1:
						return;
					case 4:
						goto IL_008c;
					case 3:
					case 10:
						goto IL_00b6;
					case 11:
						goto IL_00da;
					case 8:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 1;
						continue;
					default:
						num2 = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						num3 = 8;
						continue;
					case 6:
						num2 = (_003C_003E1__state = -1);
						num3 = 12;
						continue;
					case 0:
						if (!awaiter.IsCompleted)
						{
							goto default;
						}
						goto case 12;
					case 12:
						awaiter.GetResult();
						goto end_IL_001e;
					}
					if (cellViewModel != null)
					{
						_ = 0;
						num3 = ((!onNRMs5lyFcqpgLEfEC5()) ? 2 : 10);
						continue;
					}
					goto end_IL_001e;
					continue;
					end_IL_0154:
					break;
				}
				obj2 = null;
				goto IL_0097;
				IL_00b6:
				PropertyLinks propertyLinks = default;
				awaiter = eMquT95lMDOpv23UqhTq(propertyLinks.OnSourcePropertyChanged(cellViewModel, args));
				num3 = 0;
				if (!onNRMs5lyFcqpgLEfEC5())
				{
					goto IL_00da;
				}
				goto IL_0154;
				IL_008c:
				obj2 = null;
				goto IL_0097;
				IL_0097:
				propertyLinks = (PropertyLinks)obj2;
				if (propertyLinks != null)
				{
					cellViewModel = sender as CellViewModel;
					num3 = 9;
					if (1 == 0)
					{
						goto IL_00b6;
					}
					goto IL_0154;
				}
				goto end_IL_001e;
				IL_00da:
				_003C_003Eu__1 = default;
				num3 = 6;
				goto IL_0154;
				end_IL_001e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0248;
			IL_01df:
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					break;
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					if (A4Xtu75l0QaFKl97mqHH())
					{
					}
					continue;
				case 4:
					goto IL_022b;
				default:
					goto IL_0248;
				case 6:
					return;
				}
				break;
				IL_022b:
				writeDataFtp = _003C_003E4__this;
				_ = 1;
				num = ((!A4Xtu75l0QaFKl97mqHH()) ? 5 : 0);
			}
			goto IL_001e;
			IL_0248:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01df;
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
		internal static object j9r2NQ5lFPXl296HQ6m7(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter eMquT95lMDOpv23UqhTq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool onNRMs5lyFcqpgLEfEC5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool A4Xtu75l0QaFKl97mqHH()
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
	private struct _003CDisposeAsync_003Ed__70 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncValueTaskMethodBuilder _003C_003Et__builder;

		public WriteDataFtp _003C_003E4__this;

		private ValueTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!bCFf9T5lYeq7pBkMedec()) ? 3 : 4);
			int num2 = default;
			WriteDataFtp writeDataFtp = default;
			ValueTaskAwaiter awaiter = default;
			ValueTask valueTask = default;
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
							writeDataFtp.mOZkmKAAsd();
							num3 = 9;
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
							case 2:
								num2 = (_003C_003E1__state = 0);
								goto default;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								break;
							default:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 1:
							case 3:
								awaiter = valueTask.GetAwaiter();
								num3 = 5;
								continue;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 9:
								valueTask = writeDataFtp.aCWPaMpmuA();
								bCFf9T5lYeq7pBkMedec();
								num3 = ((!Np1RUX5lUnqeBdmZKtad()) ? 3 : 8);
								continue;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
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
					num = 5;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 3:
					writeDataFtp = _003C_003E4__this;
					num = 2;
					continue;
				case 5:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
				if (Np1RUX5lUnqeBdmZKtad())
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
		internal static bool bCFf9T5lYeq7pBkMedec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Np1RUX5lUnqeBdmZKtad()
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
	private struct _003COnFileNamePropertyChanged_003Ed__72 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public WriteDataFtp _003C_003E4__this;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			WriteDataFtp writeDataFtp = default;
			CvsCellCollection result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					try
					{
						TaskAwaiter<CvsCellCollection> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((CvsCogSocketSheet)Nj2S7O5lQ1I3LU5gqV7K(Byf5v35lmlUihXGGsoHG(writeDataFtp.InSight))).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
							num3 = 8;
							goto IL_00ee;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0097;
						IL_00af:
						_003C_003Eu__1 = awaiter;
						num3 = 4;
						if (false)
						{
							goto IL_00c2;
						}
						goto IL_00ee;
						IL_0097:
						_003C_003Eu__1 = default;
						num3 = 9;
						if (1 == 0)
						{
							goto IL_00af;
						}
						goto IL_00ee;
						IL_00ee:
						while (true)
						{
							switch (num3)
							{
							case 0:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								if (CbD3G25lxBab3hG7oPhp())
								{
								}
								continue;
							case 1:
							case 7:
							{
								StringViewModel fileNamePreview = writeDataFtp.FileNamePreview;
								if (fileNamePreview == null)
								{
									num3 = 10;
									continue;
								}
								fileNamePreview.Refresh(result);
								goto end_IL_0018;
							}
							case 9:
								num2 = (_003C_003E1__state = -1);
								_ = 0;
								if (wa4AWV5lHxenxg2RmIYX())
								{
									num3 = 5;
									continue;
								}
								num3 = 1;
								if (!CbD3G25lxBab3hG7oPhp())
								{
									continue;
								}
								goto case 8;
							case 3:
								break;
							case 2:
								goto IL_00af;
							case 4:
								goto IL_00c2;
							default:
								num3 = 3;
								continue;
							case 5:
							case 6:
								result = awaiter.GetResult();
								goto case 1;
							case 8:
								if (awaiter.IsCompleted)
								{
									goto case 5;
								}
								num3 = 0;
								if (wa4AWV5lHxenxg2RmIYX())
								{
									continue;
								}
								goto end_IL_0018;
							case 10:
								goto end_IL_0018;
							}
							break;
						}
						goto IL_0097;
						IL_00c2:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
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
				case 4:
					writeDataFtp = _003C_003E4__this;
					_ = 0;
					num = (wa4AWV5lHxenxg2RmIYX() ? 1 : 5);
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
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
		internal static object Byf5v35lmlUihXGGsoHG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Nj2S7O5lQ1I3LU5gqV7K(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wa4AWV5lHxenxg2RmIYX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CbD3G25lxBab3hG7oPhp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CvsCellLocation ssxPSSYMC2;

	[CompilerGenerated]
	private CheckBoxViewModel Bd1PDvl8SW;

	[CompilerGenerated]
	private ListBoxViewModel WAIP3KwKv2;

	[CompilerGenerated]
	private EditStringViewModel aH9PIxayCV;

	[CompilerGenerated]
	private EditStringViewModel sbnPfipNui;

	[CompilerGenerated]
	private ListBoxViewModel PvEPE3Ij5E;

	[CompilerGenerated]
	private EditStringViewModel likPbpUfoS;

	[CompilerGenerated]
	private EditStringViewModel f36PcYINaX;

	[CompilerGenerated]
	private EditStringViewModel LnHPQuDXtI;

	[CompilerGenerated]
	private ListBoxViewModel cL2PgftSDs;

	[CompilerGenerated]
	private CheckBoxViewModel e4EPMv7a5X;

	[CompilerGenerated]
	private ListBoxViewModel JojPRY64f2;

	[CompilerGenerated]
	private StringViewModel kKOP46YtSC;

	[CompilerGenerated]
	private readonly AsyncDelegateCommand jmaPlrjQmC;

	[CompilerGenerated]
	private EventHandler hCCPTPdFjr;

	private EzFormatStringViewModel guePW5nGgS;

	public override string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.GjGmu1CAx6();
		}
	}

	public CheckBoxViewModel Enabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Bd1PDvl8SW;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Bd1PDvl8SW = value;
		}
	}

	public ListBoxViewModel Storage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WAIP3KwKv2;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WAIP3KwKv2 = value;
		}
	}

	public EditStringViewModel FilePath
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aH9PIxayCV;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			aH9PIxayCV = value;
		}
	}

	public EditStringViewModel FileName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return sbnPfipNui;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			sbnPfipNui = value;
		}
	}

	public ListBoxViewModel FileType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PvEPE3Ij5E;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			PvEPE3Ij5E = value;
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
			return likPbpUfoS;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			likPbpUfoS = value;
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
			return f36PcYINaX;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			f36PcYINaX = value;
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
			return LnHPQuDXtI;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			LnHPQuDXtI = value;
		}
	}

	public ListBoxViewModel Append
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return cL2PgftSDs;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cL2PgftSDs = value;
		}
	}

	public CheckBoxViewModel Timestamp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return e4EPMv7a5X;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			e4EPMv7a5X = value;
		}
	}

	public ListBoxViewModel TimestampFormat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return JojPRY64f2;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			JojPRY64f2 = value;
		}
	}

	public StringViewModel FileNamePreview
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kKOP46YtSC;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kKOP46YtSC = value;
		}
	}

	public AsyncDelegateCommand FtpDetailsPanelToggle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return jmaPlrjQmC;
		}
	}

	public override EzFormatStringViewModel FormatString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return guePW5nGgS;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			guePW5nGgS = value;
		}
	}

	public event EventHandler DetailsToggled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
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
			goto IL_0099;
			IL_0099:
			EventHandler eventHandler = default;
			while (true)
			{
				IL_0099_2:
				switch (num)
				{
				case 0:
					break;
				case 3:
					goto IL_002b;
				case 1:
				case 5:
					goto IL_0043;
				case 6:
					while (true)
					{
						eventHandler = hCCPTPdFjr;
						_ = 0;
						if (rGJxPdurOpkYEsPQlYR())
						{
							break;
						}
						num = 4;
						if (1 == 0)
						{
							continue;
						}
						goto IL_0099_2;
					}
					num = 5;
					if (rGJxPdurOpkYEsPQlYR())
					{
						continue;
					}
					goto IL_007a;
				case 2:
				case 4:
					goto IL_007a;
				default:
					num = 3;
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_002b:
			EventHandler value2 = default;
			EventHandler eventHandler2 = default;
			eventHandler = Interlocked.CompareExchange(ref hCCPTPdFjr, value2, eventHandler2);
			num = 0;
			goto IL_0099;
			IL_0043:
			eventHandler2 = eventHandler;
			goto IL_007a;
			IL_001a:
			if ((object)eventHandler != eventHandler2)
			{
				goto IL_0043;
			}
			num = 7;
			goto IL_0099;
			IL_007a:
			value2 = (EventHandler)A6IpxSubKXuI21KJmxW(eventHandler2, value);
			goto IL_002b;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rGJxPdurOpkYEsPQlYR();
			int num = (laP96OuPsfBY9m3Z4MO() ? 6 : 4);
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					if ((object)eventHandler2 == eventHandler)
					{
						num = 7;
						break;
					}
					goto case 1;
				case 1:
				case 6:
					eventHandler = eventHandler2;
					num = 5;
					if (laP96OuPsfBY9m3Z4MO())
					{
					}
					break;
				case 3:
					eventHandler2 = Interlocked.CompareExchange(ref hCCPTPdFjr, value2, eventHandler);
					num = 2;
					if (laP96OuPsfBY9m3Z4MO())
					{
					}
					break;
				case 0:
				case 4:
					eventHandler2 = hCCPTPdFjr;
					goto case 1;
				case 5:
					value2 = (EventHandler)Delegate.Remove(eventHandler, value);
					goto case 3;
				default:
					num = 3;
					if (laP96OuPsfBY9m3Z4MO())
					{
					}
					break;
				case 7:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WriteDataFtp(CommStepViewModel commStepVm, SnippetLocalizer localizer)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_004f;
		IL_001a:
		X3EoeBuZK5oB1QgX5gF();
		_ = 0;
		num = ((!rGJxPdurOpkYEsPQlYR()) ? 4 : 0);
		goto IL_004f;
		IL_004f:
		while (true)
		{
			Func<Task> executeCallback;
			Func<bool> canExecuteCallback;
			switch (num)
			{
			case 3:
				break;
			case 0:
			case 1:
				base._002Ector(commStepVm, localizer);
				goto default;
			default:
				executeCallback = ToggleDetailsPanel;
				canExecuteCallback = [MethodImpl(MethodImplOptions.NoInlining)] () =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return true;
				};
				goto IL_00ab;
			case 5:
				return;
			}
			break;
			IL_00ab:
			jmaPlrjQmC = new AsyncDelegateCommand(executeCallback, canExecuteCallback);
			num = 5;
			if (laP96OuPsfBY9m3Z4MO())
			{
				return;
			}
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task ToggleDetailsPanel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		hCCPTPdFjr?.Invoke(this, EventArgs.Empty);
		return (Task)EqEbT1uBC38HaELJqnd();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CParse_003Ed__64))]
	protected override Task Parse(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CParse_003Ed__64 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (rGJxPdurOpkYEsPQlYR())
				{
					break;
				}
				goto case 0;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 4:
				stateMachine._003C_003Et__builder = WI6d13uG8ubombYYK2t();
				rGJxPdurOpkYEsPQlYR();
				num = (laP96OuPsfBY9m3Z4MO() ? 6 : 0);
				break;
			case 2:
			case 6:
				stateMachine.cells = cells;
				goto case 3;
			default:
				num = 3;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEnableSource_SourcePropertyChanged_003Ed__65))]
	private Task FLkk8wX3WG(object P_0, PropertyValueChangedEventArgs<CellViewModel> P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CEnableSource_SourcePropertyChanged_003Ed__65 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = P_0;
		stateMachine.args = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mOZkmKAAsd()
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
		goto IL_0043;
		IL_0043:
		while (true)
		{
			switch (num)
			{
			case 7:
				break;
			default:
				goto IL_0078;
			case 2:
				goto IL_0098;
			case 4:
				goto IL_00b3;
			case 3:
				him3TMuo1JkSOFdHaqg(guePW5nGgS, new EventHandler(nCgk1POB8u));
				num = 4;
				continue;
			case 10:
				n1x3R7uSTPxY5O3mO3a(TimestampFormat, new PropertyChangedEventHandler(SsikzySL5q));
				num = 0;
				continue;
			case 1:
				goto IL_010a;
			case 6:
			case 8:
				goto IL_011f;
			case 0:
				goto IL_013a;
			case 5:
			case 9:
				goto IL_0150;
			case 11:
				goto IL_0184;
			}
			break;
		}
		goto IL_001a;
		IL_013a:
		IEnumerator<CellViewModel> enumerator = Properties.GetEnumerator();
		num = 11;
		goto IL_0043;
		IL_010a:
		if (FileName != null)
		{
			num = 7;
			goto IL_0043;
		}
		goto IL_0150;
		IL_001a:
		n1x3R7uSTPxY5O3mO3a(FileName, new PropertyChangedEventHandler(SsikzySL5q));
		goto IL_0078;
		IL_0078:
		rGJxPdurOpkYEsPQlYR();
		if (!laP96OuPsfBY9m3Z4MO())
		{
			num = 9;
			if (laP96OuPsfBY9m3Z4MO())
			{
				goto IL_0098;
			}
		}
		else
		{
			num = 8;
			if (1 == 0)
			{
				goto IL_0184;
			}
		}
		goto IL_0043;
		IL_0184:
		try
		{
			while (lkaY5Huk7ac4MB85Uks(enumerator))
			{
				CellViewModel current = enumerator.Current;
				_ = 0;
				int num2 = ((!rGJxPdurOpkYEsPQlYR()) ? 3 : 2);
				while (true)
				{
					switch (num2)
					{
					case 0:
					case 2:
						if (current != null)
						{
							goto IL_01e7;
						}
						break;
					default:
						goto IL_01e7;
					case 4:
						break;
					}
					break;
					IL_01e7:
					current.SourcePropertyChanged -= FLkk8wX3WG;
					num2 = 4;
				}
			}
			return;
		}
		finally
		{
			if (enumerator != null)
			{
				ULbNuqu8XwghaheDjxs(enumerator);
			}
		}
		IL_011f:
		if (TimestampFormat != null)
		{
			num = 10;
			if (rGJxPdurOpkYEsPQlYR())
			{
				goto IL_0043;
			}
		}
		goto IL_013a;
		IL_0098:
		if (guePW5nGgS != null)
		{
			num = 3;
			if (rGJxPdurOpkYEsPQlYR())
			{
				goto IL_0043;
			}
			goto IL_00b3;
		}
		goto IL_010a;
		IL_0150:
		if (Timestamp != null)
		{
			Timestamp.PropertyChanged -= SsikzySL5q;
		}
		goto IL_011f;
		IL_00b3:
		guePW5nGgS.Dispose();
		num = 1;
		goto IL_0043;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__70))]
	public override ValueTask DisposeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CDisposeAsync_003Ed__70 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder = AsyncValueTaskMethodBuilder.Create();
				num = 1;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				laP96OuPsfBY9m3Z4MO();
				num = ((!rGJxPdurOpkYEsPQlYR()) ? 4 : 0);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void nCgk1POB8u(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		hCCPTPdFjr?.Invoke(this, EventArgs.Empty);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnFileNamePropertyChanged_003Ed__72))]
	private void SsikzySL5q(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003COnFileNamePropertyChanged_003Ed__72 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 4:
				stateMachine._003C_003Et__builder = SVZRlhuqkNjPvNSmjQj();
				_ = 1;
				num = (laP96OuPsfBY9m3Z4MO() ? 2 : 0);
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private ValueTask aCWPaMpmuA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.DisposeAsync();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void X3EoeBuZK5oB1QgX5gF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rGJxPdurOpkYEsPQlYR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool laP96OuPsfBY9m3Z4MO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EqEbT1uBC38HaELJqnd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object A6IpxSubKXuI21KJmxW(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder WI6d13uG8ubombYYK2t()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void him3TMuo1JkSOFdHaqg(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzFormatStringViewModel)P_0).FormatStringClosed -= (EventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void n1x3R7uSTPxY5O3mO3a(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lkaY5Huk7ac4MB85Uks(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ULbNuqu8XwghaheDjxs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncVoidMethodBuilder SVZRlhuqkNjPvNSmjQj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncVoidMethodBuilder.Create();
	}
}
