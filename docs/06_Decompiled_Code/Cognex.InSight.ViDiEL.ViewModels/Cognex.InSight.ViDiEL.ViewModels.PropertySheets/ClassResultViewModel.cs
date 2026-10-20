using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.Common;
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using Cognex.Mvvm;
using jUKn21pup6XFIrInBb;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.PropertySheets;

public class ClassResultViewModel : BaseViewModel, IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDoToggleFailClass_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ClassResultViewModel _003C_003E4__this;

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
			if (ToBjJKx4cdesU3qbagn())
			{
				num = 2;
			}
			else
			{
				num = 5;
				if (atQGScxgkgE3j3Pv270())
				{
				}
			}
			ClassResultViewModel classResultViewModel = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					classResultViewModel = _003C_003E4__this;
					num = 4;
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 1;
					break;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (fY2b2Ex1nKbtQ8QfbFZ(classResultViewModel.aKroCqGXW4))
							{
								awaiter = mnHYqAx6D5FbOsMJR8r(classResultViewModel.FrKoeBU129.ParentTool.K1l72V6Eg((string)wcA7dTxSOnmB8cdl4aI(classResultViewModel.FrKoeBU129), classResultViewModel.IsFailClass));
								goto IL_009a;
							}
							_ = 1;
							if (!atQGScxgkgE3j3Pv270())
							{
								num3 = 4;
							}
							else
							{
								num3 = 9;
								if (!ToBjJKx4cdesU3qbagn())
								{
									goto IL_00f8;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
						}
						goto IL_0174;
						IL_01af:
						awaiter.GetResult();
						goto end_IL_005b;
						IL_00f8:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 2;
						if (1 == 0)
						{
							return;
						}
						goto IL_0174;
						IL_009a:
						if (awaiter.IsCompleted)
						{
							goto IL_01af;
						}
						num3 = 6;
						if (!atQGScxgkgE3j3Pv270())
						{
							goto IL_0174;
						}
						goto end_IL_005b;
						IL_0174:
						while (true)
						{
							switch (num3)
							{
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 1:
							case 9:
								break;
							case 0:
							case 4:
								goto end_IL_005b;
							case 7:
								goto IL_00f8;
							case 2:
								return;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 5;
								if (atQGScxgkgE3j3Pv270())
								{
								}
								continue;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 8:
								_003C_003Eu__1 = awaiter;
								goto IL_00f8;
							default:
								num3 = 7;
								continue;
							case 10:
								goto IL_01af;
							}
							break;
						}
						goto IL_009a;
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
		internal static bool fY2b2Ex1nKbtQ8QfbFZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ScopedCounter)P_0).IsZero;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wcA7dTxSOnmB8cdl4aI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassViewModel)P_0).ClassName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter mnHYqAx6D5FbOsMJR8r(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ToBjJKx4cdesU3qbagn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool atQGScxgkgE3j3Pv270()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly ClassViewModel FrKoeBU129;

	[CompilerGenerated]
	private static readonly string[] ebGotLTLZM;

	private string wd8o3hSd0e;

	private ScopedCounter aKroCqGXW4;

	[CompilerGenerated]
	private AsyncDelegateCommand fIIorgP3KT;

	public static string[] Items
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ebGotLTLZM;
		}
	}

	public string Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wd8o3hSd0e;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
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
				case 1:
				case 4:
					taNZphmbOAbjs5jHfa7(this, YJYXykmIt8NCsrXqS6j(2152));
					goto default;
				case 0:
					if (SetField(ref wd8o3hSd0e, value, plfGltUiaC1OFfC2I8.OIRNC4VQ7F(634)))
					{
						_ = 0;
						num = (SpuTXLmN5HVpkLjtXGL() ? 4 : 3);
						break;
					}
					return;
				default:
					dmloT4Ifq7();
					num = 5;
					break;
				case 5:
					return;
				}
			}
		}
	}

	public bool IsFailClass
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return guDoHvmWogVfiPmSHvH(Value, Resources.Fail);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			IDisposable disposable = aKroCqGXW4.Increment();
			try
			{
				Value = (string)(value ? MXHB0lmlV2FHNeQEA1k() : cXRnPZmeYNN2c1GikG6());
				taNZphmbOAbjs5jHfa7(this, ClassFailLabel);
				dmloT4Ifq7();
			}
			finally
			{
				if (disposable != null)
				{
					Ay3Xudm72X7SVaE7Usa(disposable);
				}
			}
		}
	}

	public bool IsLastPassClass
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (!IsFailClass)
			{
				return l3bsPOmyVC11Q258PaC(FrKoeBU129.ParentTool);
			}
			return false;
		}
	}

	public string ClassFailLabel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (!IsFailClass)
			{
				return (string)qJNfKdmnwdvF0b5cdAe();
			}
			return (string)uNtu50mfI6UBMrXEBbh();
		}
	}

	public string ClassFailToolTip
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (IsLastPassClass)
			{
				return (string)v8ErUFrX7075ASpWGna(sEXj7ImzUNNGjQJULNP(), cXRnPZmeYNN2c1GikG6(), LlMq7Yr2nXyNWhQVTk5(FrKoeBU129), MXHB0lmlV2FHNeQEA1k());
			}
			if (IsFailClass)
			{
				return Resources.PredictingThisClassWillCauseTheToolToReportAFailureToolTip;
			}
			return (string)Syp8aHrMkQoGpvvcge3();
		}
	}

	public AsyncDelegateCommand FailClassCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fIIorgP3KT;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fIIorgP3KT = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClassResultViewModel(ClassViewModel parentVm)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		while (true)
		{
			switch (num)
			{
			case 1:
				aKroCqGXW4 = new ScopedCounter();
				sGLfstmwMb7AhbXmyc5();
				if (SpuTXLmN5HVpkLjtXGL())
				{
					num = 7;
					if (true)
					{
						break;
					}
					goto case 6;
				}
				num = 3;
				break;
			case 6:
				CtOY8DmpHh26Ci7fQxb();
				num = 1;
				break;
			case 2:
			case 7:
				okDlqEmGidfPPSyKF5g(this);
				num = 4;
				break;
			case 0:
				FailClassCommand = new AsyncDelegateCommand(Qc5olmqXTv);
				goto case 3;
			case 3:
			case 5:
				vAPF6NmR113Pmi55ZUW(FrKoeBU129.ParentTool, new PropertyChangedEventHandler(TF7ohp87iA));
				num = 8;
				break;
			case 4:
				FrKoeBU129 = parentVm;
				goto case 0;
			default:
				num = 0;
				if (sGLfstmwMb7AhbXmyc5())
				{
					return;
				}
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		FrKoeBU129.ParentTool.PropertyChanged -= TF7ohp87iA;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TF7ohp87iA(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (guDoHvmWogVfiPmSHvH(jpRhEFmjgqMT6Poa9AE(P_1), YJYXykmIt8NCsrXqS6j(536)))
		{
			dmloT4Ifq7();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dmloT4Ifq7()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		FirePropertyChangedExplicit((string)YJYXykmIt8NCsrXqS6j(2184));
		taNZphmbOAbjs5jHfa7(this, plfGltUiaC1OFfC2I8.OIRNC4VQ7F(2220));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoToggleFailClass_003Ed__26))]
	private Task Qc5olmqXTv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (!SpuTXLmN5HVpkLjtXGL())
		{
			goto IL_001e;
		}
		goto IL_0038;
		IL_00a5:
		_003CDoToggleFailClass_003Ed__26 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		if (SpuTXLmN5HVpkLjtXGL())
		{
			goto IL_0038;
		}
		goto IL_00c3;
		IL_00c3:
		return stateMachine._003C_003Et__builder.Task;
		IL_0038:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				break;
			default:
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				break;
			case 3:
				goto IL_007d;
			case 5:
				goto IL_00a5;
			case 6:
				goto IL_00c3;
			}
			break;
			IL_007d:
			stateMachine._003C_003Et__builder = KxCIU8rkdOfTwTmVj0P();
			SpuTXLmN5HVpkLjtXGL();
			if (sGLfstmwMb7AhbXmyc5())
			{
				num = 0;
				continue;
			}
			num = 4;
			if (true)
			{
				continue;
			}
			goto IL_00a5;
		}
		goto IL_001e;
		IL_001e:
		stateMachine._003C_003E1__state = -1;
		goto IL_00a5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassResultViewModel()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CtOY8DmpHh26Ci7fQxb();
		ebGotLTLZM = new string[2]
		{
			(string)cXRnPZmeYNN2c1GikG6(),
			(string)MXHB0lmlV2FHNeQEA1k()
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CtOY8DmpHh26Ci7fQxb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void okDlqEmGidfPPSyKF5g(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseViewModel)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vAPF6NmR113Pmi55ZUW(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SpuTXLmN5HVpkLjtXGL()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sGLfstmwMb7AhbXmyc5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jpRhEFmjgqMT6Poa9AE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertyChangedEventArgs)P_0).PropertyName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YJYXykmIt8NCsrXqS6j(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool guDoHvmWogVfiPmSHvH(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void taNZphmbOAbjs5jHfa7(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cXRnPZmeYNN2c1GikG6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Pass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MXHB0lmlV2FHNeQEA1k()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Fail;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ay3Xudm72X7SVaE7Usa(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool l3bsPOmyVC11Q258PaC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Classifier)P_0).IsLastPass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qJNfKdmnwdvF0b5cdAe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.NoEffectOnToolPassFail;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uNtu50mfI6UBMrXEBbh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.SetToolFailure;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sEXj7ImzUNNGjQJULNP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.CannotSetAllClassesToFailToolTipFormat;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LlMq7Yr2nXyNWhQVTk5(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ClassViewModel)P_0).ClassName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object v8ErUFrX7075ASpWGna(object P_0, object P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Syp8aHrMkQoGpvvcge3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.PredictingThisClassWillNotAffectToolReportingToolTip;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder KxCIU8rkdOfTwTmVj0P()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
