using System;
using System.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Cognex.Extensions;
using Cognex.InSight.Properties;
using Cognex.InSight.Remoting.Serialization;
using Cognex.Utilities;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Internal;

[Serializable]
public sealed class CvsFunction : IDisplayHelpItem, IComparable<CvsFunction>, IEquatable<CvsFunction>
{
	private enum gg5QgXhMNuApNXfsxT : uint
	{

	}

	[CompilerGenerated]
	private sealed class _003Cget_Arguments_003Ed__59 : IEnumerable<CvsFunctionArg>, IEnumerable, IEnumerator<CvsFunctionArg>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private CvsFunctionArg _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public CvsFunction _003C_003E4__this;

		private int _003Ci_003E5__2;

		CvsFunctionArg IEnumerator<CvsFunctionArg>.Current
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
		public _003Cget_Arguments_003Ed__59(int _003C_003E1__state)
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
				case 2:
				case 5:
					this._003C_003E1__state = _003C_003E1__state;
					goto default;
				case 0:
					GqGwBaslFkg8CBc6Z1JX();
					num = 1;
					continue;
				default:
					_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 1:
					break;
				case 6:
					return;
				}
				lBrWxCslmIA3s61QdXyp(this);
				e0o4s2slkj3jVvl5BXf0();
				if (AOr6H7slftEQ2YU1tSMu())
				{
					num = 4;
					continue;
				}
				num = 5;
				if (AOr6H7slftEQ2YU1tSMu())
				{
					break;
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
			int num = 3;
			CvsFunctionArg arg = default;
			int num2 = default;
			CvsFunction cvsFunction = default;
			int num3 = default;
			while (true)
			{
				switch (num)
				{
				case 13:
					_003C_003E2__current = arg;
					goto case 10;
				default:
					num = 10;
					break;
				case 6:
					if (num2 != 0)
					{
						num = 1;
						break;
					}
					_003C_003E1__state = -1;
					_003Ci_003E5__2 = 0;
					num = 9;
					if (true)
					{
						break;
					}
					goto case 5;
				case 7:
					if (arg != null)
					{
						num = 13;
						break;
					}
					goto case 12;
				case 10:
					_003C_003E1__state = 1;
					_ = 1;
					if (!AOr6H7slftEQ2YU1tSMu())
					{
						num = 2;
						break;
					}
					num = 4;
					if (0 == 0)
					{
						break;
					}
					goto case 12;
				case 4:
				case 9:
				case 11:
					if (_003Ci_003E5__2 >= cvsFunction.MaxNumberOfArgs)
					{
						num = 14;
						break;
					}
					arg = cvsFunction.GetArg(_003Ci_003E5__2);
					num = 7;
					break;
				case 3:
					num2 = _003C_003E1__state;
					num = 0;
					break;
				case 2:
				case 8:
					return true;
				case 0:
					cvsFunction = _003C_003E4__this;
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 4;
				case 1:
					if (num2 == 1)
					{
						_003C_003E1__state = -1;
						num = 12;
						break;
					}
					return false;
				case 5:
					_003Ci_003E5__2 = num3 + 1;
					goto case 4;
				case 12:
					num3 = _003Ci_003E5__2;
					num = 5;
					break;
				case 14:
					return false;
				}
			}
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
		IEnumerator<CvsFunctionArg> IEnumerable<CvsFunctionArg>.GetEnumerator()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003Cget_Arguments_003Ed__59 result;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				result = this;
			}
			else
			{
				result = new _003Cget_Arguments_003Ed__59(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<CvsFunctionArg>)this).GetEnumerator();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GqGwBaslFkg8CBc6Z1JX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void lBrWxCslmIA3s61QdXyp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool e0o4s2slkj3jVvl5BXf0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AOr6H7slftEQ2YU1tSMu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly Hashtable t9H3ZktUFl;

	private readonly int OaZ38inEw0;

	private readonly CvsFunctionArg[] NSC3z4P8w4;

	private readonly CvsFunctionGraphic[] e6DLPSpZyj;

	[CompilerGenerated]
	private CvsFunctionGroupCategory QxGLIMhLeW;

	[CompilerGenerated]
	private uint HKjL1ATnkV;

	[CompilerGenerated]
	private gg5QgXhMNuApNXfsxT RFdLxZtk5G;

	[CompilerGenerated]
	private readonly string J4QLFQqFhn;

	[CompilerGenerated]
	private readonly string cdULbrBwnj;

	[CompilerGenerated]
	private readonly string nDZLaMvtem;

	[CompilerGenerated]
	private string gNlLO4bycn;

	[CompilerGenerated]
	private string E0OLpttK7N;

	[CompilerGenerated]
	private string boeLh6UcEA;

	[CompilerGenerated]
	private int GRvL42C7hH;

	[CompilerGenerated]
	private int WvELlEdRIR;

	public CvsFunctionGroupCategory Category
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return QxGLIMhLeW;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QxGLIMhLeW = value;
		}
	}

	internal bool HasOptionalArguments
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return MinNumberOfArgs != MaxNumberOfArgs;
		}
	}

	internal bool HasVariableArguments
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return OaZ38inEw0 >= 0;
		}
	}

	public bool HasAutoPopulatedGetters
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return n733e9I8r4().HasFlag((gg5QgXhMNuApNXfsxT)8u);
		}
	}

	internal uint Flags
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return HKjL1ATnkV;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HKjL1ATnkV = value;
		}
	}

	public string Help
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return J4QLFQqFhn;
		}
	}

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return cdULbrBwnj;
		}
	}

	public string DisplayName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return nDZLaMvtem;
		}
	}

	public string DisplayDescription
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return gNlLO4bycn;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			gNlLO4bycn = value;
		}
	}

	[CanBeNull]
	public string Signature
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return E0OLpttK7N;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			E0OLpttK7N = value;
		}
	}

	[CanBeNull]
	public string RawSignature
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return boeLh6UcEA;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			boeLh6UcEA = value;
		}
	}

	public CvsFunctionTableEntryPath Path
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new CvsFunctionTableEntryPath((string)c9mZZaGnTKHfe33nC4X(WYfIesGaRwxvnS1j0Fb(Category)), Category.Name, Name);
		}
	}

	public string HelpKeyword
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			string text = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					if (!VCGvT9GGRVkToa4hWNc(text, YvRpnrGxgjl4QITfNXq(42492)))
					{
						num = 5;
						break;
					}
					goto case 7;
				case 7:
					text = (string)vcCwyRGXtE5DhSMeDQB();
					num = 0;
					break;
				case 4:
				case 6:
					text = text.Replace(' ', '_');
					num = 9;
					break;
				case 5:
					if (!VCGvT9GGRVkToa4hWNc(text, YvRpnrGxgjl4QITfNXq(42498)))
					{
						num = 8;
						break;
					}
					goto case 7;
				case 8:
					if (!VCGvT9GGRVkToa4hWNc(text, YvRpnrGxgjl4QITfNXq(15302)))
					{
						text = text.Replace('/', '_');
						goto case 4;
					}
					goto case 7;
				default:
					num = 7;
					break;
				case 2:
					text = Name;
					_ = 0;
					if (!ftkdrWGoviFuhT3Xyeu())
					{
						num = 4;
						if (ftkdrWGoviFuhT3Xyeu())
						{
							break;
						}
						goto case 8;
					}
					num = 3;
					break;
				case 0:
				case 9:
					return (string)UMnCBYG6cK6rIqKpEKh(CultureInfo.InvariantCulture, string.Format((string)zlPXNyGbRhfoYhUgodQ(), text), Array.Empty<object>());
				}
			}
		}
	}

	public string HelpTopic
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)dxU9XnGpgRalaidjOeW(Path);
		}
	}

	public IEnumerable<CvsFunctionArg> Arguments
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(_003Cget_Arguments_003Ed__59))]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new _003Cget_Arguments_003Ed__59(-2)
			{
				_003C_003E4__this = this
			};
		}
	}

	public int MaxNumberOfArgs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GRvL42C7hH;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			GRvL42C7hH = value;
		}
	}

	public int MinNumberOfArgs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return WvELlEdRIR;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WvELlEdRIR = value;
		}
	}

	public int NumberOfGraphics
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ftkdrWGoviFuhT3Xyeu();
			int num = (y7KYKrGPNijQRO7Z12p() ? 4 : 2);
			int result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					result = 0;
					goto case 1;
				case 1:
				case 4:
					if (e6DLPSpZyj == null)
					{
						break;
					}
					goto case 3;
				default:
					num = 3;
					if (true)
					{
						continue;
					}
					goto case 3;
				case 3:
					result = e6DLPSpZyj.Length;
					num = 5;
					continue;
				case 5:
					break;
				}
				break;
			}
			return result;
		}
	}

	public bool AcquireImage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return AWh9N7GJrhS61GbcKao(HiHUoTGZ4sNt3oHCm3N(Name), YvRpnrGxgjl4QITfNXq(42518));
		}
	}

	public bool Operator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ftkdrWGoviFuhT3Xyeu();
			int num = (y7KYKrGPNijQRO7Z12p() ? 4 : 2);
			char c = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					if (c == '_')
					{
						num = 5;
						continue;
					}
					return true;
				case 0:
				case 2:
					c = x1TixNG0t30MOtKpqj8(Name, 0);
					goto case 1;
				case 1:
				case 4:
					if (char.IsLetter(c))
					{
						break;
					}
					goto case 3;
				default:
					num = 3;
					continue;
				case 5:
					break;
				}
				break;
			}
			return false;
		}
	}

	public bool StringFunction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Flags & 0x100) != 0;
		}
	}

	public bool Structure
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Flags & 1) != 0;
		}
	}

	internal bool ErrFree
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Flags & 0x4000) != 0;
		}
	}

	public bool AllowedInDialog
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Flags & 0x40000) != 0;
		}
	}

	public bool UsesDynamicArguments
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Flags & 0x1000000) != 0;
		}
	}

	internal bool SheetOnly
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return !AllowedInDialog;
		}
	}

	public bool Divider
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Flags & 0x80) != 0;
		}
	}

	public bool Listed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Flags & 2) == 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
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
				case 4:
					if (value)
					{
						_ = 1;
						num = (y7KYKrGPNijQRO7Z12p() ? 3 : 0);
						break;
					}
					Flags |= 2u;
					num = 5;
					if (0 == 0)
					{
						break;
					}
					return;
				case 0:
				case 1:
					Flags &= 4294967293u;
					return;
				default:
					return;
				case 3:
					return;
				case 5:
					return;
				}
			}
		}
	}

	public bool Enabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Flags & 0x822) != 2082;
		}
	}

	public bool PropertySheetEdit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ftkdrWGoviFuhT3Xyeu();
			int num = (y7KYKrGPNijQRO7Z12p() ? 2 : 3);
			bool result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					if (NGjUSPG8CV5Di575mQ9(EditDialog, null))
					{
						goto case 1;
					}
					result = (Flags & 0x20) == 0;
					num = 5;
					continue;
				case 1:
				case 2:
					result = true;
					break;
				default:
					num = 4;
					continue;
				case 4:
				case 5:
					break;
				}
				break;
			}
			return result;
		}
	}

	public Type EditDialog
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (Type)t9H3ZktUFl[Name.ToLowerInvariant()];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal CvsFunction(CvsFunctionGroupCategory category, FunctionDescriptor descriptor)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		string[] array = default;
		int num2 = default;
		int? variableArgumentIndex = default;
		while (true)
		{
			switch (num)
			{
			case 21:
				e6DLPSpZyj = ((IEnumerable<GraphicDescriptor>)I2hTPfGMofJnSY7lDaf(descriptor)).OrEmpty().Select([MethodImpl(MethodImplOptions.NoInlining)] (GraphicDescriptor graphic, int index) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return new CvsFunctionGraphic(index, graphic);
				}).ToArray();
				num = 12;
				continue;
			case 2:
				DisplayDescription = array[1];
				return;
			case 14:
				throw new ArgumentNullException((string)YvRpnrGxgjl4QITfNXq(42458));
			case 15:
				num2 = array.Length;
				num = 6;
				continue;
			case 13:
			case 19:
				Signature = null;
				DisplayDescription = "";
				num = 22;
				continue;
			case 10:
				NSC3z4P8w4 = GlM3uxkSG0(descriptor);
				num = 21;
				continue;
			case 12:
				MinNumberOfArgs = descriptor.MinArgs ?? NSC3z4P8w4.Length;
				MaxNumberOfArgs = descriptor.MaxArgs ?? NSC3z4P8w4.Length;
				variableArgumentIndex = descriptor.VariableArgumentIndex;
				num = 20;
				if (y7KYKrGPNijQRO7Z12p())
				{
				}
				continue;
			case 11:
				return;
			case 3:
			case 9:
				if (category == null)
				{
					num = 16;
					continue;
				}
				if (descriptor != null)
				{
					Category = category;
					num = 0;
					continue;
				}
				num = 14;
				if (ftkdrWGoviFuhT3Xyeu())
				{
					continue;
				}
				goto case 17;
			case 7:
				variableArgumentIndex = descriptor.VariableArgumentIndex;
				OaZ38inEw0 = variableArgumentIndex.Value;
				goto IL_018c;
			case 5:
				RawSignature = array[0];
				num = 4;
				continue;
			case 6:
				if (num2 == 1)
				{
					RawSignature = null;
					num = 17;
					continue;
				}
				if (num2 != 2)
				{
					RawSignature = null;
					goto case 13;
				}
				num = 5;
				continue;
			case 4:
				Signature = GetFunctionSignature(RawSignature);
				num = 2;
				continue;
			case 18:
				hdRt5bGNLr5aLQtm7WW(this);
				y7KYKrGPNijQRO7Z12p();
				if (!ftkdrWGoviFuhT3Xyeu())
				{
					num = 13;
					continue;
				}
				num = 9;
				if (ftkdrWGoviFuhT3Xyeu())
				{
					continue;
				}
				goto case 0;
			case 0:
				cdULbrBwnj = descriptor.Name ?? string.Empty;
				nDZLaMvtem = (string)(string.IsNullOrEmpty((string)gk2FJTG1J5SPL5WYAH8(descriptor)) ? Name : gk2FJTG1J5SPL5WYAH8(descriptor));
				J4QLFQqFhn = (string)(RjnbfQGraaTl4XPSWry(descriptor) ?? string.Empty);
				Flags = k4KJqJG3wkNhQAILf0U(descriptor);
				Uj33SxLU6A((gg5QgXhMNuApNXfsxT)Y0CYv2GOXGNKWxhp0LY(descriptor));
				num = 10;
				continue;
			case 20:
				if (variableArgumentIndex.HasValue)
				{
					goto case 7;
				}
				goto IL_018c;
			default:
				num = 7;
				continue;
			case 16:
				throw new ArgumentNullException((string)YvRpnrGxgjl4QITfNXq(42438));
			case 17:
				Signature = null;
				DisplayDescription = array[0];
				num = 11;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
				AmKbZkGYG81HG8Jm6kh();
				num = 8;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 8:
				break;
			case 22:
				return;
				IL_018c:
				array = (string[])qx5qXyGQde3PftVcWnh(Help, new char[1] { '\n' }, 2);
				num = 15;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			}
			OaZ38inEw0 = -1;
			num = 18;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetFunctionSignature(string defaultSignature)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (y7KYKrGPNijQRO7Z12p() ? 12 : 16);
		int num2 = default;
		string text = default;
		StringBuilder stringBuilder = default;
		CvsFunctionArg cvsFunctionArg = default;
		int num3 = default;
		while (true)
		{
			switch (num)
			{
			case 11:
				return defaultSignature;
			case 10:
				num2++;
				num = 7;
				if (true)
				{
					continue;
				}
				goto case 9;
			case 9:
				if (!qm5M5nGlwRx3XCaduKL(defaultSignature, YvRpnrGxgjl4QITfNXq(42482)))
				{
					num = 1;
					continue;
				}
				break;
			case 0:
			case 16:
				text = defaultSignature;
				num = 6;
				continue;
			case 2:
				stringBuilder = new StringBuilder();
				num = 13;
				if (!y7KYKrGPNijQRO7Z12p())
				{
					continue;
				}
				goto case 5;
			case 5:
				text = stringBuilder.ToString();
				num = 17;
				if (0 == 0)
				{
					continue;
				}
				goto case 14;
			case 14:
				if (!XcHmC7GI41awWYROPmT(fJodYWGuBcItfhsCgwi(cvsFunctionArg)))
				{
					if (num2 > 0)
					{
						stringBuilder.Append(kgbOBx7BanbFa22Hp9.ol99ukmDA(13978));
					}
					sZOeqqGekm3OZEt1aj5(stringBuilder, Fc652MGRCG0ZNhg2iuc(fJodYWGuBcItfhsCgwi(cvsFunctionArg), kgbOBx7BanbFa22Hp9.ol99ukmDA(9124), ""));
					num = 10;
					if (0 == 0)
					{
						continue;
					}
					goto case 10;
				}
				num = 11;
				continue;
			case 1:
				if (MinNumberOfArgs != MaxNumberOfArgs)
				{
					break;
				}
				goto case 4;
			case 6:
				num3 = text.Count([MethodImpl(MethodImplOptions.NoInlining)] (char c) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return c == ',';
				}) + 1;
				num = 9;
				continue;
			case 3:
				if (Listed)
				{
					num = 2;
					continue;
				}
				break;
			case 13:
				sZOeqqGekm3OZEt1aj5(stringBuilder, Name);
				goto case 8;
			default:
				num = 8;
				continue;
			case 4:
			case 12:
				if (num3 < MinNumberOfArgs)
				{
					num = 3;
					continue;
				}
				break;
			case 8:
				sZOeqqGekm3OZEt1aj5(stringBuilder, kgbOBx7BanbFa22Hp9.ol99ukmDA(7598));
				num2 = 0;
				goto case 7;
			case 7:
				if (num2 < NSC3z4P8w4.Length)
				{
					cvsFunctionArg = NSC3z4P8w4[num2];
					num = 14;
				}
				else
				{
					num = 15;
				}
				continue;
			case 15:
				sZOeqqGekm3OZEt1aj5(stringBuilder, YvRpnrGxgjl4QITfNXq(17520));
				num = 5;
				continue;
			case 17:
				break;
			}
			break;
		}
		return text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsFunction CreateFunction(CvsFunctionGroupCategory category, FunctionDescriptor fd)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsFunction(category, fd);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private gg5QgXhMNuApNXfsxT n733e9I8r4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return RFdLxZtk5G;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private void Uj33SxLU6A(gg5QgXhMNuApNXfsxT value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RFdLxZtk5G = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	int IComparable<CvsFunction>.CompareTo(CvsFunction other)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 16;
		char c2 = default;
		char c = default;
		int? num7 = default;
		int? num2 = default;
		int? num9 = default;
		int? num5 = default;
		int? num3 = default;
		int? num6 = default;
		while (true)
		{
			switch (num)
			{
			case 3:
			{
				int lhs = hKkcFUGFoVu8aZtWddk(c2);
				int rhs = hKkcFUGFoVu8aZtWddk(c);
				num7 = CompareUtils.CompareOrNull(lhs, rhs);
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 12;
			}
			case 12:
				num2 = CompareUtils.CompareOrNull(Path.ToString(), other.Path.ToString());
				num = 18;
				if (ftkdrWGoviFuhT3Xyeu())
				{
					break;
				}
				goto case 14;
			case 14:
				if (!num9.HasValue)
				{
					num = 12;
					if (0 == 0)
					{
						break;
					}
					goto case 9;
				}
				return num9.GetValueOrDefault();
			case 9:
			{
				int? num10 = CompareUtils.CompareOrNull(c2, c);
				if (!num10.HasValue)
				{
					num = 5;
					break;
				}
				return num10.GetValueOrDefault();
			}
			case 4:
				if (!num7.HasValue)
				{
					num = 9;
					if (0 == 0)
					{
						break;
					}
					goto case 5;
				}
				return num7.GetValueOrDefault();
			case 5:
			{
				int? num4 = CompareUtils.CompareOrNull(Name, other.Name, StringComparer.InvariantCulture);
				if (!num4.HasValue)
				{
					num5 = CompareUtils.CompareOrNull(Help, (string)RimV7WGmd0PSf2HJOqw(other), (IComparer<string>)FWE9EcGyBcH9xVhZeZA());
					num = 10;
					if (true)
					{
						break;
					}
					goto case 15;
				}
				return num4.GetValueOrDefault();
			}
			case 15:
			{
				int? num8 = CompareUtils.CompareOrNull(OaZ38inEw0, other.OaZ38inEw0);
				if (!num8.HasValue)
				{
					goto case 11;
				}
				return num8.GetValueOrDefault();
			}
			case 11:
			case 17:
				num3 = CompareUtils.CompareOrNull(MinNumberOfArgs, other.MinNumberOfArgs);
				num = 8;
				if (true)
				{
					break;
				}
				goto case 7;
			case 7:
				if (!num6.HasValue)
				{
					num = 15;
					break;
				}
				return num6.GetValueOrDefault();
			case 13:
				throw new ArgumentNullException((string)YvRpnrGxgjl4QITfNXq(42504));
			case 1:
				num9 = CompareUtils.CompareOrNull(MaxNumberOfArgs, iH9Rl8GgCBo6BhtxhjJ(other));
				num = 14;
				break;
			case 10:
				if (!num5.HasValue)
				{
					num = 0;
					break;
				}
				return num5.GetValueOrDefault();
			case 16:
				if (other != null)
				{
					c2 = iZb1qcG49dXuMWrWtV2(x1TixNG0t30MOtKpqj8(Name, 0), CultureInfo.InvariantCulture);
					ftkdrWGoviFuhT3Xyeu();
					num = ((!y7KYKrGPNijQRO7Z12p()) ? 6 : 17);
				}
				else
				{
					num = 13;
				}
				break;
			case 2:
			case 6:
				c = iZb1qcG49dXuMWrWtV2(((string)wrqqmnGkp5QiTQsONac(other))[0], XapKJxGfls7dY8MBIKV());
				num = 3;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
				num6 = CompareUtils.CompareOrNull(Flags, other.Flags);
				goto case 7;
			default:
				num = 7;
				if (!y7KYKrGPNijQRO7Z12p())
				{
					break;
				}
				goto case 8;
			case 8:
				if (!num3.HasValue)
				{
					num = 1;
					break;
				}
				return num3.GetValueOrDefault();
			case 18:
				return num2.GetValueOrDefault();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int TXE3dSRwLX(char P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		int result = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				if (P_0 >= 'A')
				{
					num = 1;
					continue;
				}
				goto IL_00a6;
			case 1:
				if (P_0 <= 'Z')
				{
					_ = 1;
					num = (y7KYKrGPNijQRO7Z12p() ? 7 : 5);
					continue;
				}
				goto IL_00a6;
			case 3:
			case 5:
				result = 0;
				break;
			case 0:
				result = 1;
				num = 8;
				continue;
			case 6:
				{
					result = 2;
					num = 2;
					continue;
				}
				IL_00a6:
				if (P_0 == '_')
				{
					num = 0;
					continue;
				}
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!ftkdrWGoviFuhT3Xyeu()) ? 3 : 2);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				return false;
			default:
				num = 4;
				break;
			case 4:
				return true;
			case 0:
			case 2:
				if (obj != null)
				{
					if (this == obj)
					{
						goto case 4;
					}
					if (obj is CvsFunction)
					{
						num = 5;
						break;
					}
					return false;
				}
				goto case 1;
			case 5:
				return Equals((CvsFunction)obj);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(CvsFunction other)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		return ((IComparable<CvsFunction>)this).CompareTo(other) == 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (Name == null)
		{
			return 0;
		}
		return Name.GetHashCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddEditDialog(string functionName, Type type)
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
		goto IL_0092;
		IL_001a:
		string text = default;
		if (GcAVJyGz5xhMJvewIgE(t9H3ZktUFl, text))
		{
			goto IL_0074;
		}
		lgrdtTXsCylJuNcx86Z(t9H3ZktUFl, text, type);
		num = 6;
		goto IL_0092;
		IL_0074:
		UbS6ILXwyogS1pE0VS8(t9H3ZktUFl, text, type);
		return;
		IL_0092:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				break;
			case 0:
				return;
			case 3:
				goto IL_0051;
			case 2:
			case 4:
				goto IL_0074;
			default:
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				return;
			case 6:
				return;
			}
			break;
			IL_0051:
			text = (string)HiHUoTGZ4sNt3oHCm3N(functionName);
			_ = 1;
			if (y7KYKrGPNijQRO7Z12p())
			{
				num = 4;
				continue;
			}
			num = 5;
			if (ftkdrWGoviFuhT3Xyeu())
			{
				continue;
			}
			goto IL_0074;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsFunctionArg GetArg(int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		CvsFunctionArg result = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 10:
				if (index < 0)
				{
					break;
				}
				num = 3;
				if (0 == 0)
				{
					continue;
				}
				goto case 6;
			case 6:
				if (HasVariableArguments)
				{
					goto case 4;
				}
				_ = MaxNumberOfArgs;
				num = 0;
				continue;
			default:
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 4;
			case 4:
				index = OaZ38inEw0;
				num = 9;
				continue;
			case 7:
			case 8:
				result = NSC3z4P8w4[index];
				num = 11;
				continue;
			case 5:
				if (NSC3z4P8w4 != null)
				{
					_ = 0;
					num = ((!ftkdrWGoviFuhT3Xyeu()) ? 7 : 10);
					continue;
				}
				break;
			case 1:
				result = null;
				num = 5;
				continue;
			case 0:
			case 9:
				if (index >= NSC3z4P8w4.Length)
				{
					break;
				}
				goto case 7;
			case 3:
				if (index >= MinNumberOfArgs)
				{
					num = 6;
					continue;
				}
				goto case 0;
			case 11:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsFunctionArg FindArgumentByName(string name)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0079;
		IL_001a:
		int num2 = 0;
		ftkdrWGoviFuhT3Xyeu();
		if (!y7KYKrGPNijQRO7Z12p())
		{
			num = 5;
		}
		else
		{
			num = 6;
			if (y7KYKrGPNijQRO7Z12p())
			{
			}
		}
		goto IL_0079;
		IL_0079:
		CvsFunctionArg arg = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 7:
				if (arg != null)
				{
					goto case 3;
				}
				goto IL_00c5;
			case 3:
			case 6:
				if (etu6tTXhT5iJq5AxqYp(fJodYWGuBcItfhsCgwi(arg), name))
				{
					goto case 4;
				}
				goto IL_00c5;
			default:
				num = 4;
				continue;
			case 4:
				return arg;
			case 0:
			case 1:
			case 5:
				if (num2 < MaxNumberOfArgs)
				{
					arg = GetArg(num2);
					num = 7;
				}
				else
				{
					num = 8;
				}
				continue;
			case 8:
				{
					return null;
				}
				IL_00c5:
				num2++;
				num = 0;
				continue;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsFunctionArg FindFirstArgumentByType(CvsFunctionArgTypes type)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ftkdrWGoviFuhT3Xyeu();
		int num = (y7KYKrGPNijQRO7Z12p() ? 4 : 2);
		CvsFunctionArg arg = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				if (st8V3aXLIIDQUoJaV3m(arg) == type)
				{
					goto case 3;
				}
				goto IL_00ba;
			default:
				num = 3;
				break;
			case 4:
			case 5:
			case 6:
				do
				{
					if (num2 < MaxNumberOfArgs)
					{
						arg = GetArg(num2);
						num = 1;
						continue;
					}
					num = 8;
					break;
				}
				while (false);
				break;
			case 1:
				if (arg != null)
				{
					num = 7;
					break;
				}
				goto IL_00ba;
			case 3:
				return arg;
			case 0:
			case 2:
				num2 = 0;
				num = 6;
				break;
			case 8:
				{
					return null;
				}
				IL_00ba:
				num2++;
				goto case 4;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsFunctionGraphic GetGraphic(int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!y7KYKrGPNijQRO7Z12p())
		{
			num = 4;
			if (y7KYKrGPNijQRO7Z12p())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
			if (y7KYKrGPNijQRO7Z12p())
			{
			}
		}
		goto IL_0043;
		IL_002a:
		if (index >= 0)
		{
			goto IL_008f;
		}
		goto IL_00ae;
		IL_00ae:
		return null;
		IL_008f:
		if (index < NumberOfGraphics)
		{
			num = 5;
			goto IL_0043;
		}
		goto IL_00ae;
		IL_0043:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				break;
			default:
				num = 3;
				continue;
			case 0:
			case 4:
				goto IL_006a;
			case 3:
				goto IL_008f;
			case 5:
				return e6DLPSpZyj[index];
			}
			break;
		}
		goto IL_002a;
		IL_006a:
		if (e6DLPSpZyj != null)
		{
			goto IL_002a;
		}
		goto IL_00ae;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsFunctionGraphic FindGraphic(int argIndex)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 9;
		if (!ftkdrWGoviFuhT3Xyeu())
		{
			goto IL_0031;
		}
		goto IL_00f0;
		IL_00f0:
		CvsFunctionGraphic cvsFunctionGraphic = default;
		while (true)
		{
			switch (num)
			{
			case 5:
			case 8:
				break;
			case 4:
				goto IL_004a;
			case 1:
			case 2:
				goto IL_006d;
			case 0:
				goto IL_007b;
			case 3:
				if (argIndex >= nS6KWUX9h7eIYKRTgBH(cvsFunctionGraphic))
				{
					num = 0;
					continue;
				}
				goto IL_00af;
			case 6:
			case 7:
				goto IL_00ad;
			case 9:
				if (e6DLPSpZyj != null)
				{
					num = 4;
					continue;
				}
				goto case 11;
			case 10:
				if (nS6KWUX9h7eIYKRTgBH(cvsFunctionGraphic) != -1)
				{
					goto case 3;
				}
				goto IL_00af;
			default:
				num = 3;
				continue;
			case 11:
				return null;
			}
			break;
		}
		goto IL_0031;
		IL_00ad:
		return cvsFunctionGraphic;
		IL_00af:
		int num2 = num2 + 1;
		num = 8;
		goto IL_00f0;
		IL_0031:
		CvsFunctionGraphic[] array = default;
		if (num2 < array.Length)
		{
			cvsFunctionGraphic = array[num2];
			num = 10;
		}
		else
		{
			num = 11;
			if (!ftkdrWGoviFuhT3Xyeu())
			{
				goto IL_004a;
			}
		}
		goto IL_00f0;
		IL_007b:
		if (argIndex <= idKIBrXSeyNoI9FlbPB(cvsFunctionGraphic))
		{
			goto IL_00ad;
		}
		goto IL_00af;
		IL_006d:
		num2 = 0;
		num = 5;
		if (1 == 0)
		{
			goto IL_007b;
		}
		goto IL_00f0;
		IL_004a:
		array = e6DLPSpZyj;
		_ = 0;
		if (ftkdrWGoviFuhT3Xyeu())
		{
			num = 1;
			if (!ftkdrWGoviFuhT3Xyeu())
			{
				goto IL_006d;
			}
		}
		else
		{
			num = 6;
		}
		goto IL_00f0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetDefaultExpression()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		int num2 = default;
		StringBuilder stringBuilder = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				num2++;
				num = 0;
				break;
			case 0:
			case 3:
			case 4:
				if (num2 >= MinNumberOfArgs)
				{
					goto case 7;
				}
				if (num2 > 0)
				{
					num = 5;
					break;
				}
				goto case 6;
			case 7:
			case 8:
				Ey72U8XEJFAlwXjZQnZ(stringBuilder, ')');
				num = 11;
				break;
			case 5:
				Ey72U8XEJFAlwXjZQnZ(stringBuilder, ',');
				goto case 6;
			default:
				num = 6;
				if (ftkdrWGoviFuhT3Xyeu())
				{
					break;
				}
				goto case 6;
			case 6:
				CUGXZ6XHi3NDGHPyMed(stringBuilder, zmkauiXvt8agYZhd9iZ(GetArg(num2)));
				num = 1;
				break;
			case 10:
				sZOeqqGekm3OZEt1aj5(stringBuilder, Name);
				num = 9;
				if (ftkdrWGoviFuhT3Xyeu())
				{
					break;
				}
				goto case 9;
			case 9:
				Ey72U8XEJFAlwXjZQnZ(stringBuilder, '(');
				num2 = 0;
				y7KYKrGPNijQRO7Z12p();
				num = (ftkdrWGoviFuhT3Xyeu() ? 4 : 7);
				break;
			case 2:
				stringBuilder = new StringBuilder();
				num = 10;
				if (ftkdrWGoviFuhT3Xyeu())
				{
					break;
				}
				goto case 0;
			case 11:
				return stringBuilder.ToString();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static CvsFunctionArg[] GlM3uxkSG0(FunctionDescriptor P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!y7KYKrGPNijQRO7Z12p())
		{
			num = 8;
			if (false)
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 9;
			if (1 == 0)
			{
				goto IL_0083;
			}
		}
		goto IL_0130;
		IL_0130:
		List<CvsFunctionArg> list = default;
		int num2 = default;
		ArgumentGroupDescriptor argumentGroupDescriptor = default;
		CvsFunctionArg cvsFunctionArg = default;
		while (true)
		{
			switch (num)
			{
			case 6:
			case 11:
				break;
			case 3:
				goto IL_0037;
			case 4:
				list = new List<CvsFunctionArg>();
				goto case 2;
			case 0:
			case 8:
				goto IL_0083;
			case 1:
				LHj5RUXAp7331luWMtF(((object[])T3XlQVXVehft7eUcjGO(P_0))[num2], argumentGroupDescriptor);
				num = 5;
				continue;
			case 7:
			case 12:
				if (num2 >= P_0.Arguments.Length)
				{
					num = 13;
					continue;
				}
				if (argumentGroupDescriptor != null)
				{
					num = 1;
					if (true)
					{
						continue;
					}
					break;
				}
				goto case 5;
			case 2:
			case 9:
				num2 = 0;
				num = 7;
				continue;
			case 5:
				cvsFunctionArg = new CvsFunctionArg(num2, P_0.Arguments[num2]);
				if (!lDK711XDk3LCiFEncZR(cvsFunctionArg))
				{
					if (!iPJgFJXBg0OAVnIofla(cvsFunctionArg))
					{
						break;
					}
					argumentGroupDescriptor = null;
					num = 11;
					if (ftkdrWGoviFuhT3Xyeu())
					{
						continue;
					}
					goto case 2;
				}
				goto IL_0037;
			default:
				num = 3;
				continue;
			case 10:
				num2++;
				num = 12;
				continue;
			case 13:
				return (CvsFunctionArg[])wniBQZXjQN4Oe4rOmgN(list);
			}
			break;
			IL_0037:
			ArgumentGroupDescriptor argumentGroupDescriptor2 = new ArgumentGroupDescriptor();
			VkUThoXTtGQNa2Qtp3F(argumentGroupDescriptor2, mUZM4YXUOm0JFD4HQV0(cvsFunctionArg));
			KuMDIlXiM4eBsA9gUew(argumentGroupDescriptor2, RU9GRtXdi4Q2FlFG3yd(cvsFunctionArg));
			argumentGroupDescriptor2.DisplayTitle = (string)CscJXiXqyPNWo88RoDY(cvsFunctionArg);
			argumentGroupDescriptor = argumentGroupDescriptor2;
			num = 6;
		}
		goto IL_0026;
		IL_0083:
		argumentGroupDescriptor = null;
		num = 4;
		goto IL_0130;
		IL_0026:
		list.Add(cvsFunctionArg);
		num = 10;
		goto IL_0130;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CvsFunction()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		AmKbZkGYG81HG8Jm6kh();
		t9H3ZktUFl = new Hashtable();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AmKbZkGYG81HG8Jm6kh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hdRt5bGNLr5aLQtm7WW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YvRpnrGxgjl4QITfNXq(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gk2FJTG1J5SPL5WYAH8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FunctionDescriptor)P_0).DisplayName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RjnbfQGraaTl4XPSWry(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FunctionDescriptor)P_0).Help;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint k4KJqJG3wkNhQAILf0U(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FunctionDescriptor)P_0).Flags;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint Y0CYv2GOXGNKWxhp0LY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FunctionDescriptor)P_0).Options;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object I2hTPfGMofJnSY7lDaf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FunctionDescriptor)P_0).Graphics;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qx5qXyGQde3PftVcWnh(object P_0, object P_1, int P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Split((char[])P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ftkdrWGoviFuhT3Xyeu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool y7KYKrGPNijQRO7Z12p()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qm5M5nGlwRx3XCaduKL(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Contains((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sZOeqqGekm3OZEt1aj5(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fJodYWGuBcItfhsCgwi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionArg)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XcHmC7GI41awWYROPmT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Fc652MGRCG0ZNhg2iuc(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WYfIesGaRwxvnS1j0Fb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionGroupCategory)P_0).Group;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object c9mZZaGnTKHfe33nC4X(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionGroup)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VCGvT9GGRVkToa4hWNc(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).StartsWith((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vcCwyRGXtE5DhSMeDQB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Function_Operators;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zlPXNyGbRhfoYhUgodQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Function_HelpKeyword;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UMnCBYG6cK6rIqKpEKh(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.Format((IFormatProvider)P_0, (string)P_1, (object[])P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dxU9XnGpgRalaidjOeW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsHelpResolver.GetHelpTopic((CvsFunctionTableEntryPath)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static char x1TixNG0t30MOtKpqj8(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static char iZb1qcG49dXuMWrWtV2(char P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return char.ToUpper(P_0, (CultureInfo)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wrqqmnGkp5QiTQsONac(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunction)P_0).Name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XapKJxGfls7dY8MBIKV()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CultureInfo.InvariantCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int hKkcFUGFoVu8aZtWddk(char P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return TXE3dSRwLX(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RimV7WGmd0PSf2HJOqw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunction)P_0).Help;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FWE9EcGyBcH9xVhZeZA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return StringComparer.InvariantCulture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int iH9Rl8GgCBo6BhtxhjJ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunction)P_0).MaxNumberOfArgs;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HiHUoTGZ4sNt3oHCm3N(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).ToLowerInvariant();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AWh9N7GJrhS61GbcKao(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Equals((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool NGjUSPG8CV5Di575mQ9(Type P_0, Type P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return P_0 != P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GcAVJyGz5xhMJvewIgE(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Hashtable)P_0).Contains(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UbS6ILXwyogS1pE0VS8(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Hashtable)P_0)[P_1] = P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lgrdtTXsCylJuNcx86Z(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Hashtable)P_0).Add(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool etu6tTXhT5iJq5AxqYp(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsFunctionArgTypes st8V3aXLIIDQUoJaV3m(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionArg)P_0).Type;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int nS6KWUX9h7eIYKRTgBH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionGraphic)P_0).EditStart;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int idKIBrXSeyNoI9FlbPB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionGraphic)P_0).EditEnd;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ey72U8XEJFAlwXjZQnZ(object P_0, char P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StringBuilder)P_0).Append(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zmkauiXvt8agYZhd9iZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionArg)P_0).GetDefaultValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CUGXZ6XHi3NDGHPyMed(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((StringBuilder)P_0).Append(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object T3XlQVXVehft7eUcjGO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((FunctionDescriptor)P_0).Arguments;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LHj5RUXAp7331luWMtF(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((FunctionArgumentDescriptor)P_0).Group = (ArgumentGroupDescriptor)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool lDK711XDk3LCiFEncZR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionArg)P_0).FirstChild;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mUZM4YXUOm0JFD4HQV0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionArg)P_0).SummaryHelp;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VkUThoXTtGQNa2Qtp3F(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ArgumentGroupDescriptor)P_0).Description = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RU9GRtXdi4Q2FlFG3yd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionArg)P_0).SummaryName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KuMDIlXiM4eBsA9gUew(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ArgumentGroupDescriptor)P_0).Title = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CscJXiXqyPNWo88RoDY(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionArg)P_0).DisplaySummaryName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool iPJgFJXBg0OAVnIofla(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionArg)P_0).LastChild;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wniBQZXjQN4Oe4rOmgN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsFunctionArg>)P_0).ToArray();
	}
}
