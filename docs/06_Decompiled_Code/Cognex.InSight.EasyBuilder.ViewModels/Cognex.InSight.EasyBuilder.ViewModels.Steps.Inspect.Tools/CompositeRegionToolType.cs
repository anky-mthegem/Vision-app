using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.Remoting.Serialization;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;

public abstract class CompositeRegionToolType : EzToolType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnBeginAddInternal_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CompositeRegionToolType _003C_003E4__this;

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
			CompositeRegionToolType compositeRegionToolType = default;
			TaskAwaiter awaiter = default;
			do
			{
				IL_0173:
				switch (num)
				{
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							compositeRegionToolType.ShapeIndex = 0;
							_ = 1;
							num3 = (Aoc2FSKofwlswWQI8rgb() ? 2 : 7);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
						}
						while (true)
						{
							switch (num3)
							{
							case 8:
								_003C_003Eu__1 = default;
								num3 = 4;
								continue;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (sTC71BKoV6BCRVAlvmGe())
								{
									continue;
								}
								goto case 6;
							case 6:
								num2 = (_003C_003E1__state = 0);
								num3 = 9;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 5:
								return;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								break;
							case 0:
							case 7:
								awaiter = GEU54mKodgrRDDbkFgfO(compositeRegionToolType.MdOd2UlG8k());
								num3 = 3;
								continue;
							case 2:
								return;
							case 9:
								_003C_003Eu__1 = awaiter;
								goto case 1;
							default:
								num3 = 1;
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
					goto IL_0173;
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((!sTC71BKoV6BCRVAlvmGe()) ? 3 : 4);
					goto IL_0173;
				case 1:
				case 4:
					compositeRegionToolType = _003C_003E4__this;
					goto case 2;
				case 5:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
			}
			while (!Aoc2FSKofwlswWQI8rgb());
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
		internal static TaskAwaiter GEU54mKodgrRDDbkFgfO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sTC71BKoV6BCRVAlvmGe()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Aoc2FSKofwlswWQI8rgb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly bool zHsdqhrHXY;

	[CompilerGenerated]
	private CvsDisplayableComposite YoDdixcxgX;

	private int KtIdkKMVPV;

	public virtual string Directions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)CDBHZof88cTCjiqF1Mv();
		}
	}

	protected CvsDisplayableComposite EditableComposite
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return YoDdixcxgX;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			YoDdixcxgX = value;
		}
	}

	public IReadOnlyList<string> Shapes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.EditableGraphicShapeNames(zHsdqhrHXY);
		}
	}

	public int ShapeIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KtIdkKMVPV;
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
					YCsMMrfE9q1NefANQ00(EditableComposite, ShapeIndex);
					goto default;
				default:
					FireAddGraphicsChanged(null, null);
					num = 5;
					break;
				case 0:
					if (!SetField(ref KtIdkKMVPV, value, (string)TpDBKJfqhZvjD9kDotF(4952)))
					{
						return;
					}
					_ = 1;
					if (txGHicfSjqNVwd1xfX5())
					{
						num = 3;
						break;
					}
					num = 4;
					if (txGHicfSjqNVwd1xfX5())
					{
						return;
					}
					break;
				case 5:
					return;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CompositeRegionToolType(bool is3d = false)
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
			default:
				zHsdqhrHXY = is3d;
				num = 5;
				if (BS2nQvfoSxGQS7bpMLf())
				{
					continue;
				}
				break;
			case 0:
				break;
			case 1:
			case 3:
				base._002Ector();
				goto default;
			case 5:
				return;
			}
			rsHK98fkvpFdX4dRDNx();
			_ = 1;
			num = (txGHicfSjqNVwd1xfX5() ? 4 : 3);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void UpdateFeatureGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		SizeF size = default;
		CvsCogImage cvsCogImage = default;
		SourceLink currentInputImageLink = default;
		PointF location = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				size = new SizeF(hF1OA4f6o8YtKkI7Lc3(cvsCogImage), kSd6F1fCHjL95CSA4AB(cvsCogImage));
				goto case 1;
			case 7:
				cvsCogImage = FIi7aBf75HYeRZ0fW5f(X9kl75f4WiLpHaNdxEq(HPHZqpf907WPPpOIUxq(((CvsResultSet)Sq15ZxfXv8uqIo3EBGB(HDypghfp7a9AM0mL6o2(Inspect))).Cells, CvsCellLocation.TryParse(currentInputImageLink.Expression)))) as CvsCogImage;
				num = 8;
				break;
			case 0:
				location = new PointF(W0fkT0f3pkgDIrhNDQh(cvsCogImage), toI89PfjpvLHNBuwcib(cvsCogImage));
				txGHicfSjqNVwd1xfX5();
				num = ((!BS2nQvfoSxGQS7bpMLf()) ? 1 : 2);
				break;
			case 3:
				base.UpdateFeatureGraphics();
				num = 4;
				break;
			case 4:
				currentInputImageLink = CurrentInputImageLink;
				num = 7;
				break;
			case 1:
			case 6:
				k1JXRafAtoYI5pRG6pA(EditableComposite, new RectangleF(location, size));
				num = 9;
				break;
			case 8:
				if (cvsCogImage != null)
				{
					goto case 0;
				}
				return;
			default:
				num = 0;
				break;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnBeginAddInternal_003Ed__15))]
	protected override Task OnBeginAddInternal()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!txGHicfSjqNVwd1xfX5())
		{
			num = 3;
			if (txGHicfSjqNVwd1xfX5())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 2;
			if (!BS2nQvfoSxGQS7bpMLf())
			{
				goto IL_004c;
			}
		}
		goto IL_0066;
		IL_002a:
		_003COnBeginAddInternal_003Ed__15 stateMachine = default;
		stateMachine._003C_003Et__builder = EUwm81fRjye5nCoS3fe();
		goto IL_00af;
		IL_0097:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0066;
		IL_00af:
		stateMachine._003C_003E4__this = this;
		num = 5;
		goto IL_0066;
		IL_004c:
		stateMachine._003C_003E1__state = -1;
		goto IL_0097;
		IL_0066:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				break;
			case 5:
				goto IL_004c;
			default:
				num = 4;
				if (!txGHicfSjqNVwd1xfX5())
				{
					continue;
				}
				goto IL_0097;
			case 4:
				goto IL_0097;
			case 1:
			case 2:
				goto IL_00af;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task MdOd2UlG8k()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnBeginAddInternal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rsHK98fkvpFdX4dRDNx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BS2nQvfoSxGQS7bpMLf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool txGHicfSjqNVwd1xfX5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CDBHZof88cTCjiqF1Mv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.X4CZjO7h1w();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TpDBKJfqhZvjD9kDotF(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YCsMMrfE9q1NefANQ00(object P_0, int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EditableGraphicHelper.UpdateGraphicShape((CvsDisplayableComposite)P_0, index);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HDypghfp7a9AM0mL6o2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Sq15ZxfXv8uqIo3EBGB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Results;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HPHZqpf907WPPpOIUxq(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object X9kl75f4WiLpHaNdxEq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).CellResult;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FIi7aBf75HYeRZ0fW5f(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int W0fkT0f3pkgDIrhNDQh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImage)P_0).OffsetX;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int toI89PfjpvLHNBuwcib(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImage)P_0).OffsetY;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int hF1OA4f6o8YtKkI7Lc3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImage)P_0).Width;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int kSd6F1fCHjL95CSA4AB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImage)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void k1JXRafAtoYI5pRG6pA(object P_0, RectangleF P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsEditableDisplayGraphic)P_0).EditBounds = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder EUwm81fRjye5nCoS3fe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
