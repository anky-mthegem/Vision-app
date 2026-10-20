using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Controls;
using AujL2CBmg0lxKX9CUc;
using Cognex.InSight.ViDiEL.ViewModels.Validations;
using Cognex.Mvvm;
using jUKn21pup6XFIrInBb;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.PropertySheets;

public class NewClassNameViewModel : BaseViewModel, IDataErrorInfo
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCommitValidatedClassName_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NewClassNameViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0191;
			IL_001a:
			int num2 = _003C_003E1__state;
			_ = 1;
			num = (w0DKsNxNwXVSQrLKCSC() ? 5 : 0);
			goto IL_0191;
			IL_0191:
			NewClassNameViewModel newClassNameViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 2:
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = newClassNameViewModel.N3Co1Ko9Z0.AddClass((string)x7nsKcxwpG3Jqscs3vp(newClassNameViewModel.pN2oDQYXXA)).GetAwaiter();
							num3 = 0;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
							if (1 == 0)
							{
								goto IL_00ee;
							}
						}
						goto IL_0099;
						IL_00ee:
						num2 = (_003C_003E1__state = -1);
						num3 = 9;
						goto IL_0099;
						IL_0099:
						while (true)
						{
							switch (num3)
							{
							case 1:
								_003C_003Eu__1 = default;
								num3 = 8;
								continue;
							case 2:
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								return;
							case 6:
								return;
							case 8:
								break;
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								continue;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									if (!w0DKsNxNwXVSQrLKCSC())
									{
										continue;
									}
									goto case 5;
								}
								goto case 9;
							case 5:
								_003C_003Eu__1 = awaiter;
								znn46kxAPg5u2OrLNBy();
								num3 = ((!w0DKsNxNwXVSQrLKCSC()) ? 2 : 6);
								continue;
							case 9:
								awaiter.GetResult();
								goto end_IL_0099;
							}
							goto IL_00ee;
							continue;
							end_IL_0099:
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
					goto case 4;
				default:
					num = 4;
					continue;
				case 0:
				case 1:
					newClassNameViewModel = _003C_003E4__this;
					goto case 2;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 6:
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
		internal static object x7nsKcxwpG3Jqscs3vp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Trim();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool znn46kxAPg5u2OrLNBy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool w0DKsNxNwXVSQrLKCSC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly Classifier N3Co1Ko9Z0;

	private string pN2oDQYXXA;

	[CompilerGenerated]
	private ValidationRule QKlojkHPro;

	private bool iRHoPKaK4b;

	public string ValidatedClassName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return pN2oDQYXXA;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			pN2oDQYXXA = value;
		}
	}

	public ValidationRule Validation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return QKlojkHPro;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QKlojkHPro = value;
		}
	}

	public string Error
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return null;
		}
	}

	public bool IsValid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iRHoPKaK4b;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref iRHoPKaK4b, value, (string)bmDyoirOp4YSXEUlDMs(2480));
		}
	}

	public string this[string columnName]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			ValidationResult validationResult = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					if (!tUTN2VrKxrDSfxKOFPN(validationResult))
					{
						num = 6;
						continue;
					}
					break;
				case 0:
					if (xptb4nrHWlKOtvZl2ZY(columnName, bmDyoirOp4YSXEUlDMs(2498)) & (ValidatedClassName != null))
					{
						J1fW8MrZDKE6Xwm0hZu();
						num = ((!qgpoclrvHrjn4o5rnhj()) ? 3 : 5);
						continue;
					}
					break;
				case 1:
				case 5:
					validationResult = (ValidationResult)hyngoxrJmWgoYWf8yIc(Validation, TyKGTXrTyZid1PVYkKB(ValidatedClassName), HR4F1yrYXmlZOZaFir4());
					goto case 2;
				case 2:
				case 3:
					IsValid = tUTN2VrKxrDSfxKOFPN(validationResult);
					goto case 4;
				default:
					num = 4;
					continue;
				case 6:
					return kEixlWrCsAp9pXG0Pf6(validationResult).ToString();
				}
				break;
			}
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NewClassNameViewModel(Classifier tool)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		qgpoclrvHrjn4o5rnhj();
		int num;
		if (!J1fW8MrZDKE6Xwm0hZu())
		{
			num = 4;
		}
		else
		{
			num = 3;
			if (J1fW8MrZDKE6Xwm0hZu())
			{
			}
		}
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
				break;
			case 2:
			{
				OVEQ8joX1oMA23scSI oVEQ8joX1oMA23scSI = new OVEQ8joX1oMA23scSI();
				oVEQ8joX1oMA23scSI.Wq6IJQHU5b(new List<ValidationRule>
				{
					new NotInitialized(),
					new UniqueNameInArrayValidationRule
					{
						Classes = N3Co1Ko9Z0.Classes
					}
				});
				Validation = oVEQ8joX1oMA23scSI;
				num = 6;
				continue;
			}
			case 5:
				N3Co1Ko9Z0 = tool;
				goto case 2;
			default:
				num = 2;
				continue;
			case 1:
			case 3:
				break;
			case 6:
				return;
			}
			base._002Ector();
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCommitValidatedClassName_003Ed__6))]
	public Task CommitValidatedClassName()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CCommitValidatedClassName_003Ed__6 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 2:
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				continue;
			case 0:
				stateMachine._003C_003Et__builder = gvrrmTr0CfXnq19vMGi();
				J1fW8MrZDKE6Xwm0hZu();
				num = (qgpoclrvHrjn4o5rnhj() ? 5 : 3);
				continue;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (true)
				{
					continue;
				}
				break;
			case 6:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qgpoclrvHrjn4o5rnhj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool J1fW8MrZDKE6Xwm0hZu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder gvrrmTr0CfXnq19vMGi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bmDyoirOp4YSXEUlDMs(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool xptb4nrHWlKOtvZl2ZY(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TyKGTXrTyZid1PVYkKB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Trim();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HR4F1yrYXmlZOZaFir4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.CurrentCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hyngoxrJmWgoYWf8yIc(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ValidationRule)P_0).Validate(P_1, (CultureInfo)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tUTN2VrKxrDSfxKOFPN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ValidationResult)P_0).IsValid;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kEixlWrCsAp9pXG0Pf6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ValidationResult)P_0).ErrorContent;
	}
}
