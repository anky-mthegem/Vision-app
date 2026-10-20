using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using Cognex.InSight.ViDiEL.ViewModels.PropertySheets;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.Validations;

public class UniqueNameInArrayValidationRule : ValidationRule
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public string className;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass4_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CfsIiNFjvTBJdrfTSx3();
			bYmGYJFIRafb8MOc6yI(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CValidate_003Eb__0(ClassViewModel s)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return YiroLDFbrTbYUYMbRvq(R5cf0CFWafMPGeZ86gc(s), className, true) == 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void CfsIiNFjvTBJdrfTSx3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void bYmGYJFIRafb8MOc6yI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xLHC6qFGOoWEoYAQDbx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bAYVCtFRdQVFQSAZ2yh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object R5cf0CFWafMPGeZ86gc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassViewModel)P_0).ClassName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int YiroLDFbrTbYUYMbRvq(object P_0, object P_1, bool P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Compare((string)P_0, (string)P_1, P_2);
		}
	}

	[CompilerGenerated]
	private IEnumerable<ClassViewModel> jpIIuSnFYI;

	public IEnumerable<ClassViewModel> Classes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return jpIIuSnFYI;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			jpIIuSnFYI = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		gdMEC1XDbhaCI6LbnWO();
		int num;
		if (!hpBKbtX8oPhF5DPG8OS())
		{
			num = 2;
		}
		else
		{
			num = 4;
			if (1 == 0)
			{
				goto IL_0088;
			}
		}
		goto IL_0045;
		IL_00d0:
		return ValidationResult.ValidResult;
		IL_0088:
		_003C_003Ec__DisplayClass4_0 obj = default;
		if (Classes.Any(obj._003CValidate_003Eb__0))
		{
			num = 6;
			goto IL_0045;
		}
		goto IL_00d0;
		IL_0045:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			default:
				num = 5;
				continue;
			case 0:
			case 2:
				obj = new _003C_003Ec__DisplayClass4_0();
				goto case 1;
			case 5:
				goto IL_0088;
			case 1:
			case 4:
				obj.className = value as string;
				num = 3;
				continue;
			case 6:
				return new ValidationResult(isValid: false, Resources.ErrorClassNameMustBeUnique);
			}
			break;
		}
		if (obj.className != null)
		{
			goto IL_0088;
		}
		goto IL_00d0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UniqueNameInArrayValidationRule()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		M1xRBfXFvo039kk9dXP();
		GVNnR6XsZbgIJ8Caumj(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gdMEC1XDbhaCI6LbnWO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hpBKbtX8oPhF5DPG8OS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void M1xRBfXFvo039kk9dXP()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GVNnR6XsZbgIJ8Caumj(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ValidationRule)P_0)._002Ector();
	}
}
