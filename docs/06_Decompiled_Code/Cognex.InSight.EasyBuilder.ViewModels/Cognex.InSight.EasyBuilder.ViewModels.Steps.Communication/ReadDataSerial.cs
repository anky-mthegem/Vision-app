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
using Cognex.InSight.Runtime.ViewModels;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public class ReadDataSerial : EzSupportSnippet
{
	private static class DGRtWKRRbtSY9CmcRjl
	{
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDisposeAsync_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncValueTaskMethodBuilder _003C_003Et__builder;

		public ReadDataSerial _003C_003E4__this;

		private ValueTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			ReadDataSerial readDataSerial = default;
			ValueTaskAwaiter awaiter = default;
			ValueTask valueTask = default;
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
							readDataSerial.xZ4kk7CZi4();
							num3 = 9;
							goto IL_0098;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0101;
						IL_0101:
						_003C_003Eu__1 = default;
						num3 = 0;
						goto IL_0098;
						IL_0098:
						while (true)
						{
							switch (num3)
							{
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 2:
								awaiter = valueTask.GetAwaiter();
								num3 = 3;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								goto default;
							default:
								_ = 0;
								num3 = (ufAnMK5dQl0UwutCO4KL() ? 1 : 5);
								continue;
							case 9:
								valueTask = readDataSerial.sB7kPcUUaY();
								num3 = 2;
								continue;
							case 1:
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								continue;
							case 5:
							case 6:
								break;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 10;
							case 10:
								awaiter.GetResult();
								goto end_IL_0098;
							}
							goto IL_0101;
							continue;
							end_IL_0098:
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
					readDataSerial = _003C_003E4__this;
					goto case 2;
				case 5:
					num2 = _003C_003E1__state;
					_ = 0;
					if (!ufAnMK5dQl0UwutCO4KL())
					{
						num = 4;
						continue;
					}
					num = 3;
					if (true)
					{
						continue;
					}
					break;
				case 0:
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
		internal static bool ufAnMK5dQl0UwutCO4KL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zokivQ5dNGQCQm3ELf0S()
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
	private struct _003CEnableSource_SourcePropertyChanged_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ReadDataSerial _003C_003E4__this;

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
			_ = 1;
			int num;
			if (!mGnwre5dcA61wNFADIIF())
			{
				num = 5;
			}
			else
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_004e;
				}
			}
			goto IL_0220;
			IL_004e:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (false)
			{
				goto IL_0065;
			}
			goto IL_0220;
			IL_0065:
			int num2 = default;
			ReadDataSerial readDataSerial = default;
			try
			{
				int num3;
				object obj2;
				TaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					AppStepViewModel parent = readDataSerial.Parent;
					if (parent == null)
					{
						num3 = 10;
					}
					else
					{
						object obj = FZQWFN5d12vObcL1g4f9(parent);
						if (obj != null)
						{
							obj2 = ((EasyBuilderApplicationViewModel)obj).PropertyLinks;
							goto IL_00bc;
						}
						num3 = 11;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					num3 = 4;
					if (1 == 0)
					{
						goto IL_00f4;
					}
				}
				goto IL_016d;
				IL_016d:
				PropertyLinks propertyLinks = default;
				CellViewModel cellViewModel = default;
				while (true)
				{
					switch (num3)
					{
					case 10:
						break;
					case 0:
					case 9:
						num2 = (_003C_003E1__state = -1);
						num3 = 12;
						continue;
					case 11:
						goto IL_00b1;
					case 3:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 7:
						goto IL_00f4;
					case 2:
						num2 = (_003C_003E1__state = 0);
						_ = 1;
						num3 = ((!mGnwre5dcA61wNFADIIF()) ? 1 : 0);
						continue;
					case 1:
					case 6:
						_003C_003Eu__1 = awaiter;
						num3 = 3;
						continue;
					case 5:
						awaiter = FeXSic5duRbHH8ZLIuNl(propertyLinks.OnSourcePropertyChanged(cellViewModel, args));
						if (!awaiter.IsCompleted)
						{
							goto case 2;
						}
						goto case 12;
					default:
						num3 = 2;
						if (true)
						{
							continue;
						}
						goto case 8;
					case 8:
						if (cellViewModel != null)
						{
							num3 = 5;
							continue;
						}
						goto end_IL_0065;
					case 4:
						_003C_003Eu__1 = default;
						goto case 0;
					case 12:
						awaiter.GetResult();
						goto end_IL_0065;
					}
					break;
				}
				obj2 = null;
				goto IL_00bc;
				IL_00bc:
				propertyLinks = (PropertyLinks)obj2;
				if (propertyLinks != null)
				{
					num3 = 7;
					goto IL_016d;
				}
				goto end_IL_0065;
				IL_00b1:
				obj2 = null;
				goto IL_00bc;
				IL_00f4:
				cellViewModel = sender as CellViewModel;
				num3 = 8;
				goto IL_016d;
				end_IL_0065:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_004e;
			IL_0220:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 3;
					continue;
				case 3:
					readDataSerial = _003C_003E4__this;
					goto IL_0065;
				case 1:
					break;
				case 2:
				case 4:
					goto IL_0065;
				default:
					num = 1;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_004e;
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
		internal static object FZQWFN5d12vObcL1g4f9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter FeXSic5duRbHH8ZLIuNl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XQcHu45d20Q8e11cuTZV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mGnwre5dcA61wNFADIIF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private CheckBoxViewModel EEIkZ78n11;

	[CompilerGenerated]
	private StringViewModel MmlknP61s7;

	[CompilerGenerated]
	private BoolViewModel xNxktQje3h;

	[CompilerGenerated]
	private StringViewModel hNVkY6cI9Q;

	public override string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)cEqIjt1tPrPKSiIPFJY();
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
			return EEIkZ78n11;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EEIkZ78n11 = value;
		}
	}

	public StringViewModel Input
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MmlknP61s7;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			MmlknP61s7 = value;
		}
	}

	public BoolViewModel Error
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xNxktQje3h;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xNxktQje3h = value;
		}
	}

	public StringViewModel ErrorString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hNVkY6cI9Q;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hNVkY6cI9Q = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ReadDataSerial(CommStepViewModel commStepVm, SnippetLocalizer localizer = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		base._002Ector(commStepVm, localizer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__2))]
	public override ValueTask DisposeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (TiiQyJ1uxUYJeZZAiQl() ? 5 : 4);
		_003CDisposeAsync_003Ed__2 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				if (true)
				{
					break;
				}
				goto case 3;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 1;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = kDd3ji1hZbixfDakBlk();
				goto case 1;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEnableSource_SourcePropertyChanged_003Ed__3))]
	private Task yi8kieS45L(object P_0, PropertyValueChangedEventArgs<CellViewModel> P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CEnableSource_SourcePropertyChanged_003Ed__3 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = P_0;
		stateMachine.args = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Task Parse(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		if (!E9m8tQ11Wfl9QmSPPTq())
		{
			goto IL_001e;
		}
		goto IL_02b8;
		IL_02dd:
		TiiQyJ1uxUYJeZZAiQl();
		num = ((!E9m8tQ11Wfl9QmSPPTq()) ? 1 : 5);
		goto IL_02b8;
		IL_02b8:
		IEnumerator<CellViewModel> enumerator = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			case 5:
				break;
			case 0:
				RemoveAllProperties();
				num = 2;
				continue;
			case 1:
			case 4:
				goto IL_0046;
			case 2:
				goto IL_029f;
			default:
				goto IL_02dd;
			case 6:
				xZ4kk7CZi4();
				num = 0;
				continue;
			case 7:
				try
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.SourcePropertyChanged += yi8kieS45L;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						cA0sbduOiwhLgtkKORg(enumerator);
					}
				}
				return (Task)WUE8pCuItt2QNUnPkfH();
			}
			break;
		}
		goto IL_001e;
		IL_029f:
		CvsCellRange cellRange = CellRange;
		goto IL_02dd;
		IL_001e:
		IEnumerator<CvsCellLocation> enumerator2 = cellRange.GetEnumerator();
		goto IL_0046;
		IL_0046:
		try
		{
			while (dfeJbLueTFFb98r7tlA(enumerator2))
			{
				CvsCellLocation current = enumerator2.Current;
				int num2 = 3;
				while (true)
				{
					object obj;
					string text;
					switch (num2)
					{
					case 11:
						obj = null;
						goto IL_0067;
					case 10:
						AddProperty(ErrorString);
						num2 = 14;
						if (E9m8tQ11Wfl9QmSPPTq())
						{
							continue;
						}
						goto case 3;
					case 3:
					{
						object obj2 = XZt9771zsbVIGdGc7H6(cells, current);
						if (obj2 != null)
						{
							obj = SOPVuTuLQiHSRXHm3xB(obj2);
							goto IL_0067;
						}
						num2 = 11;
						continue;
					}
					case 6:
						AddProperty(Error);
						num2 = 13;
						continue;
					case 9:
						ErrorString = new StringViewModel(InSight, cells, current, (string)v9D4t8uaxN6CH3LRvuh());
						num2 = 10;
						continue;
					case 2:
					case 7:
						Error = new BoolViewModel(InSight, cells, current, (string)GId1FauJ1gOorgMdXOV());
						num2 = 6;
						if (!TiiQyJ1uxUYJeZZAiQl())
						{
							continue;
						}
						goto case 0;
					case 0:
						AddProperty(Enabled);
						num2 = 12;
						continue;
					case 5:
						AddProperty(Input);
						break;
					default:
						num2 = 1;
						continue;
					case 4:
					case 8:
						Input = new StringViewModel(InSight, cells, current, Resources.lpdYbvNgHa());
						num2 = 5;
						continue;
					case 1:
					case 12:
					case 13:
					case 14:
						break;
						IL_0067:
						text = (string)obj;
						if (text == null)
						{
							break;
						}
						if (OSVEdWu59B6IhDPmPTv(text, fT01qYuKjCl1EVx0AHD(30008), StringComparison.Ordinal))
						{
							Enabled = new CheckBoxViewModel(InSight, cells, current, (string)Avn4MNuwHA2feOJOKLe(), isInitialized: true);
							num2 = 0;
							if (true)
							{
								continue;
							}
							goto case 10;
						}
						if (text.EndsWith(CdQUGaROfy7He9T0foW.KbIzwHEDLa(30056), StringComparison.Ordinal))
						{
							_ = 1;
							if (!TiiQyJ1uxUYJeZZAiQl())
							{
								num2 = 8;
								if (true)
								{
									continue;
								}
								break;
							}
							num2 = 2;
							if (E9m8tQ11Wfl9QmSPPTq())
							{
								continue;
							}
							goto case 4;
						}
						if (!text.EndsWith((string)fT01qYuKjCl1EVx0AHD(30100), StringComparison.Ordinal))
						{
							if (OSVEdWu59B6IhDPmPTv(text, CdQUGaROfy7He9T0foW.KbIzwHEDLa(30144), StringComparison.Ordinal))
							{
								num2 = 9;
								continue;
							}
							break;
						}
						goto case 2;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator2 != null)
			{
				cA0sbduOiwhLgtkKORg(enumerator2);
			}
		}
		enumerator = Properties.GetEnumerator();
		num = 7;
		if (false)
		{
			goto IL_029f;
		}
		goto IL_02b8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void xZ4kk7CZi4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		using IEnumerator<CellViewModel> enumerator = Properties.GetEnumerator();
		while (dfeJbLueTFFb98r7tlA(enumerator))
		{
			CellViewModel current = enumerator.Current;
			TiiQyJ1uxUYJeZZAiQl();
			int num = ((!E9m8tQ11Wfl9QmSPPTq()) ? 3 : 2);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					if (current != null)
					{
						goto IL_0081;
					}
					break;
				default:
					goto IL_0081;
				case 4:
					break;
				}
				break;
				IL_0081:
				current.SourcePropertyChanged -= yi8kieS45L;
				num = 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private ValueTask sB7kPcUUaY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.DisposeAsync();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool E9m8tQ11Wfl9QmSPPTq()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TiiQyJ1uxUYJeZZAiQl()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncValueTaskMethodBuilder kDd3ji1hZbixfDakBlk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncValueTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cEqIjt1tPrPKSiIPFJY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.VmC9oQG4pQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XZt9771zsbVIGdGc7H6(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SOPVuTuLQiHSRXHm3xB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fT01qYuKjCl1EVx0AHD(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool OSVEdWu59B6IhDPmPTv(object P_0, object P_1, StringComparison P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).EndsWith((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Avn4MNuwHA2feOJOKLe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Enabled;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GId1FauJ1gOorgMdXOV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Error;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object v9D4t8uaxN6CH3LRvuh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.ErrorString;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool dfeJbLueTFFb98r7tlA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cA0sbduOiwhLgtkKORg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WUE8pCuItt2QNUnPkfH()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}
}
