using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
using Cognex.InSight.Runtime.ViewModels;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public class WriteImageFtp : EzSupportSnippet
{
	internal static class WA24E0Rvp3Pfk9gU6Of
	{
	}

	public enum FtpStorage
	{
		LocalDevice,
		FTPServer,
		SFTPServer
	}

	public enum ImageType
	{
		BMP,
		JPEG
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEnableSource_SourcePropertyChanged_003Ed__61 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public WriteImageFtp _003C_003E4__this;

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
			int num = 0;
			int num2 = default;
			WriteImageFtp writeImageFtp = default;
			TaskAwaiter awaiter = default;
			PropertyLinks propertyLinks = default;
			CellViewModel cellViewModel = default;
			do
			{
				IL_01d5:
				switch (num)
				{
				case 2:
				case 4:
					try
					{
						object obj;
						int num3;
						if (num2 != 0)
						{
							AppStepViewModel parent = writeImageFtp.Parent;
							if (parent != null)
							{
								obj = parent.AppViewModel?.PropertyLinks;
								goto IL_00bf;
							}
							_ = 1;
							num3 = (Qxb5Hm5sVvABgZpfRu2t() ? 3 : 2);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
						}
						goto IL_005f;
						IL_00bf:
						propertyLinks = (PropertyLinks)obj;
						if (propertyLinks != null)
						{
							num3 = 10;
							goto IL_005f;
						}
						goto end_IL_0018;
						IL_005f:
						while (true)
						{
							switch (num3)
							{
							case 1:
								if (!awaiter.IsCompleted)
								{
									goto case 6;
								}
								goto case 12;
							default:
								num3 = 6;
								continue;
							case 0:
							case 2:
								obj = null;
								break;
							case 5:
								_003C_003Eu__1 = default;
								goto case 3;
							case 8:
								return;
							case 6:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								num3 = 4;
								continue;
							case 7:
								awaiter = bRmJhD5sf3yN2Ki5ptGP(propertyLinks.OnSourcePropertyChanged(cellViewModel, args));
								num3 = 1;
								if (0 == 0)
								{
									continue;
								}
								goto case 4;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								if (true)
								{
									continue;
								}
								goto case 11;
							case 11:
								if (cellViewModel != null)
								{
									num3 = 7;
									if (true)
									{
										continue;
									}
									goto case 10;
								}
								goto end_IL_005f;
							case 10:
								cellViewModel = sender as CellViewModel;
								num3 = 11;
								continue;
							case 3:
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								continue;
							case 12:
								awaiter.GetResult();
								goto end_IL_005f;
							}
							goto IL_00bf;
							continue;
							end_IL_005f:
							break;
						}
						end_IL_0018:;
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
					if (0 == 0)
					{
						goto IL_01d5;
					}
					goto case 1;
				case 1:
				case 5:
					writeImageFtp = _003C_003E4__this;
					goto case 2;
				case 0:
					num2 = _003C_003E1__state;
					Qxb5Hm5sVvABgZpfRu2t();
					if (!c3xeLM5snxUlQWK6dRLQ())
					{
						num = 4;
						goto IL_01d5;
					}
					num = 5;
					if (c3xeLM5snxUlQWK6dRLQ())
					{
						goto IL_01d5;
					}
					break;
				case 3:
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
		internal static TaskAwaiter bRmJhD5sf3yN2Ki5ptGP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool c3xeLM5snxUlQWK6dRLQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Qxb5Hm5sVvABgZpfRu2t()
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
	private struct _003COnFileNamePropertyChanged_003Ed__62 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public WriteImageFtp _003C_003E4__this;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			dX2hV75sdRRVZNKhVhMM();
			int num;
			if (!MJ6VKG5slNC054sybX6j())
			{
				num = 5;
			}
			else
			{
				num = 4;
				if (!dX2hV75sdRRVZNKhVhMM())
				{
					goto IL_0045;
				}
			}
			goto IL_01d1;
			IL_0045:
			int num2 = default;
			WriteImageFtp writeImageFtp = default;
			try
			{
				TaskAwaiter<CvsCellCollection> awaiter;
				int num3;
				if (num2 != 0)
				{
					awaiter = ((CvsCogSocketSheet)PjhqZ35sgl34eOWlWWDi(writeImageFtp.InSight.CogSocket)).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
					num3 = 8;
					goto IL_0139;
				}
				awaiter = _003C_003Eu__1;
				goto IL_0071;
				IL_00d4:
				num2 = (_003C_003E1__state = -1);
				goto IL_00dd;
				IL_0071:
				_003C_003Eu__1 = default;
				num3 = 3;
				if (1 == 0)
				{
					goto IL_0089;
				}
				goto IL_0139;
				IL_0139:
				CvsCellCollection result = default;
				while (true)
				{
					switch (num3)
					{
					case 0:
					case 5:
						break;
					case 8:
						goto IL_0089;
					case 4:
					case 7:
						return;
					case 1:
						goto IL_00bd;
					case 3:
						goto IL_00d4;
					case 9:
						goto IL_00f5;
					case 2:
						num2 = (_003C_003E1__state = 0);
						num3 = 9;
						continue;
					case 6:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						goto default;
					default:
						dX2hV75sdRRVZNKhVhMM();
						if (MJ6VKG5slNC054sybX6j())
						{
							num3 = 0;
							continue;
						}
						num3 = 7;
						if (dX2hV75sdRRVZNKhVhMM())
						{
							continue;
						}
						goto end_IL_0045;
					case 10:
						goto end_IL_0045;
					}
					break;
					IL_00bd:
					StringViewModel fileNamePreview = writeImageFtp.FileNamePreview;
					if (fileNamePreview == null)
					{
						num3 = 10;
						continue;
					}
					fileNamePreview.Refresh(result);
					goto end_IL_0045;
				}
				goto IL_0071;
				IL_00dd:
				result = awaiter.GetResult();
				num3 = 1;
				if (MJ6VKG5slNC054sybX6j())
				{
					goto IL_00f5;
				}
				goto IL_0139;
				IL_00f5:
				_003C_003Eu__1 = awaiter;
				num3 = 6;
				goto IL_0139;
				IL_0089:
				if (awaiter.IsCompleted)
				{
					goto IL_00dd;
				}
				num3 = 2;
				if (false)
				{
					return;
				}
				goto IL_0139;
				end_IL_0045:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_01fc;
			IL_01fc:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01d1;
			IL_01d1:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 2:
					break;
				default:
					num = 3;
					continue;
				case 3:
					goto IL_01fc;
				case 1:
				case 4:
					writeImageFtp = _003C_003E4__this;
					num = 2;
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
			goto IL_0045;
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
		internal static object PjhqZ35sgl34eOWlWWDi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dX2hV75sdRRVZNKhVhMM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MJ6VKG5slNC054sybX6j()
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
	private struct _003CDisposeAsync_003Ed__64 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncValueTaskMethodBuilder _003C_003Et__builder;

		public WriteImageFtp _003C_003E4__this;

		private ValueTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			WriteImageFtp writeImageFtp = default;
			int num2 = default;
			ValueTaskAwaiter awaiter = default;
			ValueTask valueTask = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					writeImageFtp = _003C_003E4__this;
					num = 0;
					if (YlDLen5sspw3xeSNgi3l())
					{
						break;
					}
					goto case 0;
				case 0:
					try
					{
						int num3;
						if (num2 != 0)
						{
							writeImageFtp.rAHPzmUiST();
							sFLO825svWfinNFr7jgF();
							if (YlDLen5sspw3xeSNgi3l())
							{
								num3 = 1;
								if (1 == 0)
								{
									goto IL_0057;
								}
							}
							else
							{
								num3 = 3;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 5;
							if (1 == 0)
							{
								goto IL_014c;
							}
						}
						goto IL_009a;
						IL_0057:
						if (!awaiter.IsCompleted)
						{
							num3 = 6;
							goto IL_009a;
						}
						goto IL_014c;
						IL_014c:
						awaiter.GetResult();
						goto end_IL_002f;
						IL_009a:
						while (true)
						{
							switch (num3)
							{
							case 8:
								break;
							case 2:
								awaiter = valueTask.GetAwaiter();
								num3 = 8;
								continue;
							case 6:
								num2 = (_003C_003E1__state = 0);
								goto default;
							default:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								continue;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								continue;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 0:
							case 1:
								valueTask = writeImageFtp.jJasarrbws();
								num3 = 2;
								continue;
							case 9:
								return;
							case 10:
								goto IL_014c;
							}
							break;
						}
						goto IL_0057;
						end_IL_002f:;
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
					break;
				case 5:
					num2 = _003C_003E1__state;
					YlDLen5sspw3xeSNgi3l();
					if (sFLO825svWfinNFr7jgF())
					{
						num = 4;
						if (YlDLen5sspw3xeSNgi3l())
						{
							break;
						}
						goto default;
					}
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
		internal static bool YlDLen5sspw3xeSNgi3l()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sFLO825svWfinNFr7jgF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private CheckBoxViewModel I2ws3UnVRa;

	[CompilerGenerated]
	private ListBoxViewModel fxVsIKrkQk;

	[CompilerGenerated]
	private EditStringViewModel bUwsfF1M2d;

	[CompilerGenerated]
	private EditStringViewModel X5osERKMlq;

	[CompilerGenerated]
	private ListBoxViewModel XjmsblLhSd;

	[CompilerGenerated]
	private CheckBoxViewModel EVtscNcPLl;

	[CompilerGenerated]
	private EditIntViewModel QkrsQEY63a;

	[CompilerGenerated]
	private CheckBoxViewModel yCRsgsYnY3;

	[CompilerGenerated]
	private EditStringViewModel LD6sM8j0Vl;

	[CompilerGenerated]
	private EditStringViewModel EGgsRAtdKH;

	[CompilerGenerated]
	private EditStringViewModel kKQs4dRy8G;

	[CompilerGenerated]
	private CheckBoxViewModel hpEsliEdB0;

	[CompilerGenerated]
	private ListBoxViewModel WuesTLujHd;

	[CompilerGenerated]
	private StringViewModel IcesWiqvvN;

	public override string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)QmF6nOhfFwS9fPWqLv8();
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
			return I2ws3UnVRa;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			I2ws3UnVRa = value;
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
			return fxVsIKrkQk;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fxVsIKrkQk = value;
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
			return bUwsfF1M2d;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			bUwsfF1M2d = value;
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
			return X5osERKMlq;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			X5osERKMlq = value;
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
			return XjmsblLhSd;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			XjmsblLhSd = value;
		}
	}

	public CheckBoxViewModel AppendValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EVtscNcPLl;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EVtscNcPLl = value;
		}
	}

	public EditIntViewModel MaxAppendValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return QkrsQEY63a;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QkrsQEY63a = value;
		}
	}

	public CheckBoxViewModel OverlayGraphics
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return yCRsgsYnY3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			yCRsgsYnY3 = value;
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
			return LD6sM8j0Vl;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			LD6sM8j0Vl = value;
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
			return EGgsRAtdKH;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EGgsRAtdKH = value;
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
			return kKQs4dRy8G;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kKQs4dRy8G = value;
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
			return hpEsliEdB0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hpEsliEdB0 = value;
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
			return WuesTLujHd;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WuesTLujHd = value;
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
			return IcesWiqvvN;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IcesWiqvvN = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WriteImageFtp(AppStepViewModel appStepVm, SnippetLocalizer localizer = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		base._002Ector(appStepVm, localizer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Task Parse(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (u5eJMuhVERghSdHnkUc() ? 6 : 11);
		IEnumerator<CvsCellLocation> enumerator = default;
		IEnumerator<CellViewModel> enumerator2 = default;
		CvsCellRange cellRange = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 11:
				rAHPzmUiST();
				num = 9;
				continue;
			case 3:
			case 6:
				try
				{
					while (f3rnU6hEyUYGn6RlTOu(enumerator))
					{
						CvsCellLocation current = enumerator.Current;
						int num2 = 32;
						while (true)
						{
							object obj2;
							string text;
							switch (num2)
							{
							case 11:
								AddProperty(UserName);
								num2 = 2;
								continue;
							case 29:
								AddProperty(Server);
								num2 = 10;
								continue;
							case 24:
								MaxAppendValue = new EditIntViewModel(InSight, cells, current, (string)tZ7ICYhbO4NMlBulTnG());
								AddProperty(MaxAppendValue);
								num2 = 25;
								continue;
							case 30:
								AddProperty(Timestamp);
								num2 = 22;
								continue;
							case 20:
								FilePath = new EditStringViewModel(InSight, cells, current, (string)myYDO4hPA7hmlGGEipD());
								num2 = 17;
								continue;
							case 15:
								UserName.Internal = true;
								num2 = 11;
								continue;
							case 28:
								Server = new EditStringViewModel(InSight, cells, current, Resources.kMQr56dmnF());
								num2 = 31;
								if (true)
								{
									continue;
								}
								break;
							case 7:
								FileType = new ListBoxViewModel(InSight, cells, current, Resources.FileType);
								AddProperty(FileType);
								num2 = 34;
								continue;
							case 9:
								obj2 = null;
								goto IL_01e4;
							case 12:
								AddProperty(TimestampFormat);
								num2 = 1;
								continue;
							case 14:
								AddProperty(Enabled);
								break;
							case 4:
							case 19:
								AddProperty(Storage);
								num2 = 6;
								if (TxplFshnwKG2Q8DqU2q())
								{
									continue;
								}
								goto case 21;
							case 21:
								CXO0I1hoo4eeGIclath(Password, true);
								AddProperty(Password);
								num2 = 26;
								continue;
							case 35:
								UserName = new EditStringViewModel(InSight, cells, current, (string)burM2WhSe1oq9XGXFIm());
								num2 = 15;
								if (TxplFshnwKG2Q8DqU2q())
								{
									continue;
								}
								goto case 5;
							case 5:
								AddProperty(FileName);
								break;
							case 0:
								Enabled = new CheckBoxViewModel(InSight, cells, current, (string)RcHCGthsScbD3AdDdSi(), isInitialized: true);
								num2 = 14;
								continue;
							case 13:
							case 16:
								AddProperty(OverlayGraphics);
								break;
							default:
								num2 = 33;
								continue;
							case 31:
								CXO0I1hoo4eeGIclath(Server, true);
								num2 = 29;
								continue;
							case 27:
								AddProperty(AppendValue);
								break;
							case 17:
								AddProperty(FilePath);
								num2 = 3;
								continue;
							case 32:
							{
								object obj = J59u9lhd0d4WkdxgREM(cells, current);
								if (obj != null)
								{
									obj2 = dMhX6whlwL3HhXBiDy7(obj);
									goto IL_01e4;
								}
								num2 = 9;
								continue;
							}
							case 18:
								FileName = new EditStringViewModel(InSight, cells, current, (string)AxyIUHhZ8Jvt09qwn42());
								num2 = 5;
								continue;
							case 8:
								AddProperty(FileNamePreview);
								num2 = 36;
								if (0 == 0)
								{
									continue;
								}
								break;
							case 23:
								FileNamePreview = new StringViewModel(InSight, cells, current, (string)lXxROOhqFYb0HjNPgE3());
								num2 = 8;
								if (!u5eJMuhVERghSdHnkUc())
								{
									continue;
								}
								break;
							case 1:
							case 2:
							case 3:
							case 6:
							case 10:
							case 22:
							case 25:
							case 26:
							case 33:
							case 34:
							case 36:
								break;
								IL_01e4:
								text = (string)obj2;
								if (text == null)
								{
									break;
								}
								if (owY5EqhgrZb8GgrBARt(text, CdQUGaROfy7He9T0foW.KbIzwHEDLa(30702), StringComparison.Ordinal))
								{
									num2 = 0;
									continue;
								}
								if (!owY5EqhgrZb8GgrBARt(text, CdQUGaROfy7He9T0foW.KbIzwHEDLa(30748), StringComparison.Ordinal))
								{
									if (!owY5EqhgrZb8GgrBARt(text, virH0bhrN8MX9r29xtD(30794), StringComparison.Ordinal))
									{
										if (owY5EqhgrZb8GgrBARt(text, CdQUGaROfy7He9T0foW.KbIzwHEDLa(30842), StringComparison.Ordinal))
										{
											num2 = 18;
											continue;
										}
										if (!owY5EqhgrZb8GgrBARt(text, virH0bhrN8MX9r29xtD(30890), StringComparison.Ordinal))
										{
											if (text.EndsWith((string)virH0bhrN8MX9r29xtD(30938), StringComparison.Ordinal))
											{
												AppendValue = new CheckBoxViewModel(InSight, cells, current, (string)n7p5uZhBnTEIrES1mlX(), isInitialized: true);
												num2 = 27;
												continue;
											}
											if (!owY5EqhgrZb8GgrBARt(text, virH0bhrN8MX9r29xtD(30992), StringComparison.Ordinal))
											{
												if (!owY5EqhgrZb8GgrBARt(text, virH0bhrN8MX9r29xtD(31052), StringComparison.Ordinal))
												{
													if (owY5EqhgrZb8GgrBARt(text, virH0bhrN8MX9r29xtD(31114), StringComparison.Ordinal))
													{
														num2 = 28;
														if (!u5eJMuhVERghSdHnkUc())
														{
															continue;
														}
														goto case 7;
													}
													if (!owY5EqhgrZb8GgrBARt(text, virH0bhrN8MX9r29xtD(31158), StringComparison.Ordinal))
													{
														if (!owY5EqhgrZb8GgrBARt(text, virH0bhrN8MX9r29xtD(31206), StringComparison.Ordinal))
														{
															if (owY5EqhgrZb8GgrBARt(text, virH0bhrN8MX9r29xtD(31254), StringComparison.Ordinal))
															{
																Timestamp = new CheckBoxViewModel(InSight, cells, current, (string)y9D3yFhkCnAoRF7VEbD(), isInitialized: true);
																num2 = 30;
																continue;
															}
															if (!text.EndsWith((string)virH0bhrN8MX9r29xtD(31304), StringComparison.Ordinal))
															{
																if (owY5EqhgrZb8GgrBARt(text, virH0bhrN8MX9r29xtD(31366), StringComparison.Ordinal))
																{
																	num2 = 23;
																	continue;
																}
																break;
															}
															TimestampFormat = new ListBoxViewModel(InSight, cells, current, (string)lfPaOWh8NiDQ03tUGnH());
															num2 = 12;
															continue;
														}
														Password = new EditStringViewModel(InSight, cells, current, Resources.PYQLVi1wyC());
														num2 = 21;
														continue;
													}
													num2 = 35;
													continue;
												}
												OverlayGraphics = new CheckBoxViewModel(InSight, cells, current, (string)cCD8oMhGiEXcmWqbOAO(), isInitialized: true);
												goto case 13;
											}
											num2 = 24;
											continue;
										}
										num2 = 7;
										continue;
									}
									num2 = 20;
									continue;
								}
								Storage = new ListBoxViewModel(InSight, cells, current, (string)C7cimGhvYFkKjaIhynW());
								_ = 0;
								if (TxplFshnwKG2Q8DqU2q())
								{
									num2 = 19;
									if (TxplFshnwKG2Q8DqU2q())
									{
										continue;
									}
									goto case 4;
								}
								num2 = 13;
								continue;
							}
							break;
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						A8FHxVhpc8Yo4Fs7Wjt(enumerator);
					}
				}
				enumerator2 = Properties.GetEnumerator();
				num = 1;
				continue;
			case 5:
				if (Timestamp != null)
				{
					num = 10;
					continue;
				}
				break;
			case 9:
				RemoveAllProperties();
				cellRange = CellRange;
				num = 2;
				continue;
			case 7:
				FileName.PropertyChanged += VmBP1hGNUd;
				goto case 8;
			default:
				num = 8;
				continue;
			case 10:
				vlW9SYhXeuJLbmaKwLx(Timestamp, new PropertyChangedEventHandler(VmBP1hGNUd));
				num = 12;
				if (TxplFshnwKG2Q8DqU2q())
				{
					continue;
				}
				goto case 1;
			case 1:
				try
				{
					while (enumerator2.MoveNext())
					{
						enumerator2.Current.SourcePropertyChanged += iHmPmsQxXN;
					}
				}
				finally
				{
					enumerator2?.Dispose();
				}
				if (FileName != null)
				{
					num = 7;
					continue;
				}
				goto case 8;
			case 2:
				enumerator = cellRange.GetEnumerator();
				goto case 3;
			case 8:
				if (TimestampFormat != null)
				{
					num = 4;
					continue;
				}
				goto case 5;
			case 4:
				TimestampFormat.PropertyChanged += VmBP1hGNUd;
				num = 5;
				continue;
			case 12:
				break;
			}
			break;
		}
		return (Task)QyPd2jh9lSUj7c0wkHv();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEnableSource_SourcePropertyChanged_003Ed__61))]
	private Task iHmPmsQxXN(object P_0, PropertyValueChangedEventArgs<CellViewModel> P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CEnableSource_SourcePropertyChanged_003Ed__61 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = P_0;
		stateMachine.args = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnFileNamePropertyChanged_003Ed__62))]
	private void VmBP1hGNUd(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003COnFileNamePropertyChanged_003Ed__62 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder = uSn7A0h4U5Gg3GsEbds();
				_ = 1;
				if (!u5eJMuhVERghSdHnkUc())
				{
					num = 4;
					if (u5eJMuhVERghSdHnkUc())
					{
					}
				}
				else
				{
					num = 5;
				}
				break;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			default:
				num = 0;
				break;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rAHPzmUiST()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0043;
		IL_0043:
		while (true)
		{
			switch (num)
			{
			case 8:
				break;
			default:
				num = 4;
				if (u5eJMuhVERghSdHnkUc())
				{
				}
				continue;
			case 1:
				goto IL_0084;
			case 2:
			case 3:
				if (Timestamp != null)
				{
					num = 8;
					continue;
				}
				goto IL_00f1;
			case 0:
				if (FileName != null)
				{
					num = 1;
					continue;
				}
				goto case 2;
			case 6:
				goto IL_00db;
			case 4:
				goto IL_00f1;
			case 5:
			case 7:
				goto IL_0116;
			case 9:
				goto IL_0139;
			}
			break;
			IL_0084:
			bxVoXPh7oRl50KBUdb2(FileName, new PropertyChangedEventHandler(VmBP1hGNUd));
			_ = 1;
			if (!u5eJMuhVERghSdHnkUc())
			{
				num = 3;
				continue;
			}
			num = 7;
			if (u5eJMuhVERghSdHnkUc())
			{
			}
		}
		goto IL_001a;
		IL_00db:
		IEnumerator<CellViewModel> enumerator = Properties.GetEnumerator();
		num = 9;
		goto IL_0043;
		IL_0139:
		try
		{
			while (enumerator.MoveNext())
			{
				CellViewModel current = enumerator.Current;
				u5eJMuhVERghSdHnkUc();
				int num2 = ((!TxplFshnwKG2Q8DqU2q()) ? 3 : 2);
				while (true)
				{
					switch (num2)
					{
					default:
						current.SourcePropertyChanged -= iHmPmsQxXN;
						num2 = 4;
						if (TxplFshnwKG2Q8DqU2q())
						{
							continue;
						}
						goto case 0;
					case 0:
					case 2:
						if (current == null)
						{
							break;
						}
						goto default;
					case 4:
						break;
					}
					break;
				}
			}
			return;
		}
		finally
		{
			if (enumerator != null)
			{
				A8FHxVhpc8Yo4Fs7Wjt(enumerator);
			}
		}
		IL_001a:
		bxVoXPh7oRl50KBUdb2(Timestamp, new PropertyChangedEventHandler(VmBP1hGNUd));
		goto IL_00f1;
		IL_00f1:
		if (TimestampFormat == null)
		{
			goto IL_00db;
		}
		goto IL_0116;
		IL_0116:
		bxVoXPh7oRl50KBUdb2(TimestampFormat, new PropertyChangedEventHandler(VmBP1hGNUd));
		num = 6;
		if (true)
		{
			goto IL_0043;
		}
		goto IL_0139;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__64))]
	public override ValueTask DisposeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CDisposeAsync_003Ed__64 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (u5eJMuhVERghSdHnkUc())
				{
				}
				break;
			case 2:
				stateMachine._003C_003Et__builder = AsyncValueTaskMethodBuilder.Create();
				_ = 0;
				num = (TxplFshnwKG2Q8DqU2q() ? 4 : 0);
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private ValueTask jJasarrbws()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.DisposeAsync();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TxplFshnwKG2Q8DqU2q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool u5eJMuhVERghSdHnkUc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QmF6nOhfFwS9fPWqLv8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Xs1mf5KXEo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object J59u9lhd0d4WkdxgREM(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dMhX6whlwL3HhXBiDy7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool owY5EqhgrZb8GgrBARt(object P_0, object P_1, StringComparison P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).EndsWith((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RcHCGthsScbD3AdDdSi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Enabled;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object C7cimGhvYFkKjaIhynW()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Storage;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object virH0bhrN8MX9r29xtD(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object myYDO4hPA7hmlGGEipD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.WOOnmyCMHM();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AxyIUHhZ8Jvt09qwn42()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.QBWn9gQrv4();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object n7p5uZhBnTEIrES1mlX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.uONBfuOqbF();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tZ7ICYhbO4NMlBulTnG()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Ub2VuuhCse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cCD8oMhGiEXcmWqbOAO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.cwVLKBc9Hu();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CXO0I1hoo4eeGIclath(object P_0, bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CellViewModel)P_0).Internal = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object burM2WhSe1oq9XGXFIm()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.S9uhrEc42k();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object y9D3yFhkCnAoRF7VEbD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.aQOrLYhPvC();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lfPaOWh8NiDQ03tUGnH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.eDYr9QBHLO();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lXxROOhqFYb0HjNPgE3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.d5inhBYKTI();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool f3rnU6hEyUYGn6RlTOu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void A8FHxVhpc8Yo4Fs7Wjt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vlW9SYhXeuJLbmaKwLx(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QyPd2jh9lSUj7c0wkHv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncVoidMethodBuilder uSn7A0h4U5Gg3GsEbds()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncVoidMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bxVoXPh7oRl50KBUdb2(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
	}
}
