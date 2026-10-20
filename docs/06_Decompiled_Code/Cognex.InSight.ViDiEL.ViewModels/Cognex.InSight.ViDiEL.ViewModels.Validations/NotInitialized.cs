using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.Validations;

public class NotInitialized : ValidationRule
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		oSbQ6cXr1xDk7ntiKVy();
		int num = (H0uyfOXP2dwcHRLGJF3() ? 3 : 5);
		string text = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
				if (value == null)
				{
					goto case 1;
				}
				text = value as string;
				num = 2;
				if (!H0uyfOXP2dwcHRLGJF3())
				{
					continue;
				}
				goto case 6;
			case 4:
				if (!vpMkDRXgZQVMHPMKDt1(text))
				{
					break;
				}
				num = 6;
				if (!H0uyfOXP2dwcHRLGJF3())
				{
					continue;
				}
				goto case 2;
			case 2:
				if (text == null)
				{
					break;
				}
				goto case 4;
			default:
				num = 4;
				if (oSbQ6cXr1xDk7ntiKVy())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 3:
				return new ValidationResult(isValid: false, sYCekRX4KxTC8uEVy1c());
			case 6:
				return new ValidationResult(isValid: false, Resources.EnterPleaseEnterClassName);
			}
			break;
		}
		return (ValidationResult)SnU3MlX1oxprKISB9Do();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NotInitialized()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		KofnbpXSg7rnQ76VlU3();
		QUXgqoX6NqsnobCFKB3(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sYCekRX4KxTC8uEVy1c()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.EnterPleaseEnterClassName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vpMkDRXgZQVMHPMKDt1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SnU3MlX1oxprKISB9Do()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ValidationResult.ValidResult;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oSbQ6cXr1xDk7ntiKVy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool H0uyfOXP2dwcHRLGJF3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KofnbpXSg7rnQ76VlU3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QUXgqoX6NqsnobCFKB3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ValidationRule)P_0)._002Ector();
	}
}
