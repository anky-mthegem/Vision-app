using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.Graphic;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Runtime.ViewModels.Acq;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;

public class EditableGraphicHelper
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSendGraphicAsync_003Ed__56 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsInSight insight;

		public CvsEditableDisplayGraphic editableGraphic;

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
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = OLdqjtKoBTxZuOZPVgvl(SendGraphicAsync(insight, editableGraphic.CellLocation, editableGraphic));
							num3 = 0;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
						}
						while (true)
						{
							switch (num3)
							{
							case 6:
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 1:
								return;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								break;
							case 2:
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								continue;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 1;
								continue;
							case 5:
								_003C_003Eu__1 = default;
								goto case 6;
							case 3:
								num2 = (_003C_003E1__state = 0);
								oC9WJkKoZrSkUETyaJg1();
								num3 = (Nbr5QZKoPnEoiBuEP4H6() ? 4 : 8);
								continue;
							case 9:
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
					goto default;
				default:
					_003C_003Et__builder.SetResult();
					num = 5;
					break;
				case 0:
					num2 = _003C_003E1__state;
					oC9WJkKoZrSkUETyaJg1();
					if (!Nbr5QZKoPnEoiBuEP4H6())
					{
						num = 3;
						if (oC9WJkKoZrSkUETyaJg1())
						{
						}
					}
					else
					{
						num = 4;
						if (oC9WJkKoZrSkUETyaJg1())
						{
							return;
						}
					}
					break;
				case 5:
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
		internal static TaskAwaiter OLdqjtKoBTxZuOZPVgvl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Nbr5QZKoPnEoiBuEP4H6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oC9WJkKoZrSkUETyaJg1()
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
	private struct _003CSendGraphicAsync_003Ed__57 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CvsEditableDisplayGraphic editableGraphic;

		public CvsInSight insight;

		public CvsCellLocation loc;

		private object _003Cshape_003E5__2;

		private TaskAwaiter<CvsCogEditInfo[]> _003C_003Eu__1;

		private TaskAwaiter<CvsCogEditingObject> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!tYbiMlKobJgwEHOLgXwX()) ? 1 : 4);
			int num2 = default;
			TaskAwaiter awaiter3 = default;
			TaskAwaiter<CvsCogEditInfo[]> awaiter2 = default;
			TaskAwaiter<CvsCogEditingObject> awaiter = default;
			CvsGraphic cvsGraphic = default;
			CvsCogEditInfo[] result2 = default;
			string text = default;
			CvsCogEditingObject result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 3;
					if (true)
					{
						continue;
					}
					break;
				case 3:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							if (editableGraphic != null)
							{
								num3 = 4;
								break;
							}
							goto end_IL_004c;
						case 2:
							awaiter3 = _003C_003Eu__3;
							num3 = 0;
							break;
						case 0:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							tYbiMlKobJgwEHOLgXwX();
							num3 = ((!LyVfNXKoGqfGPWJLHG9g()) ? 23 : 16);
							break;
						case 1:
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num3 = 6;
							break;
						}
						while (true)
						{
							switch (num3)
							{
							case 24:
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 13;
								if (LyVfNXKoGqfGPWJLHG9g())
								{
								}
								continue;
							case 19:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							case 17:
								cvsGraphic = (CvsGraphic)LiBxH4KoSrY91fj9vCHl(editableGraphic);
								num3 = 1;
								continue;
							case 3:
								if (result2.Length != 0)
								{
									goto case 11;
								}
								text = (string)QVQkMBKo7GFmyn05jvkJ(jdCvORKo4WhuRd9QtNP0(48854), _003Cshape_003E5__2.GetType(), loc);
								num3 = 26;
								continue;
							case 8:
								return;
							case 9:
							case 23:
								num2 = (_003C_003E1__state = -1);
								goto IL_01e7;
							case 20:
								editableGraphic = PmjMdOKooTg3SQ5s8rSa(editableGraphic) as CvsEditableDisplayGraphic;
								num3 = 17;
								continue;
							case 22:
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 2;
								if (true)
								{
									continue;
								}
								return;
							case 13:
								return;
							case 0:
								_003C_003Eu__3 = default;
								num3 = 22;
								continue;
							case 26:
								h26lEvKo3dkikYoDpoBr(lXIdY53BaD(), text);
								num3 = 27;
								continue;
							case 25:
								_003C_003Eu__3 = awaiter3;
								num3 = 19;
								if (tYbiMlKobJgwEHOLgXwX())
								{
									continue;
								}
								goto case 7;
							case 7:
								awaiter3 = DfhQo4Ko9GNtSxZH0jA2(PZYgnBKoXTTA6LLP3RF3(vh553dKoqohYN6akRSjS(insight.CogSocket), CY7ecbKopypeTu2FPCqm(result), _003Cshape_003E5__2));
								if (!awaiter3.IsCompleted)
								{
									num3 = 18;
									continue;
								}
								goto case 12;
							case 11:
							case 16:
								awaiter = ((CvsCogSocket)Jufk40Ko8RJurUHRKSGe(insight)).Sheet.EditEditableObjectAsync((string)pODxMnKoEP4IoGSc690Y(result2[0])).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 24;
									continue;
								}
								goto case 2;
							case 18:
								num2 = (_003C_003E1__state = 2);
								num3 = 25;
								continue;
							case 12:
								awaiter3.GetResult();
								num3 = 21;
								continue;
							case 5:
								if (awaiter2.IsCompleted)
								{
									goto IL_01e7;
								}
								num3 = 14;
								if (tYbiMlKobJgwEHOLgXwX())
								{
									continue;
								}
								goto case 4;
							case 4:
								if (editableGraphic.Parent != null)
								{
									num3 = 20;
									continue;
								}
								goto case 17;
							case 1:
								_003Cshape_003E5__2 = qKbeEKKokh3Gi3SwJCBu(cvsGraphic);
								awaiter2 = ((CvsCogSocketSheet)vh553dKoqohYN6akRSjS(Jufk40Ko8RJurUHRKSGe(insight))).GetEditInfoAsync(loc).GetAwaiter();
								num3 = 5;
								continue;
							case 15:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 2;
							case 2:
								result = awaiter.GetResult();
								num3 = 7;
								continue;
							case 14:
								num2 = (_003C_003E1__state = 0);
								num3 = 10;
								continue;
							case 10:
								_003C_003Eu__1 = awaiter2;
								num3 = 15;
								if (LyVfNXKoGqfGPWJLHG9g())
								{
								}
								continue;
							case 21:
							case 27:
								{
									_003Cshape_003E5__2 = null;
									break;
								}
								IL_01e7:
								result2 = awaiter2.GetResult();
								num3 = 3;
								continue;
							}
							break;
						}
						end_IL_004c:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 5:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 5;
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
		internal static object PmjMdOKooTg3SQ5s8rSa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditableDisplayGraphic)P_0).Parent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LiBxH4KoSrY91fj9vCHl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditableDisplayGraphic)P_0).InSightGraphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qKbeEKKokh3Gi3SwJCBu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphic)P_0).GetSerializableGraphic();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Jufk40Ko8RJurUHRKSGe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vh553dKoqohYN6akRSjS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pODxMnKoEP4IoGSc690Y(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogEditInfo)P_0).Url;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CY7ecbKopypeTu2FPCqm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogEditingObject)P_0).Url;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PZYgnBKoXTTA6LLP3RF3(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).ApplyEditableObjectAsync((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter DfhQo4Ko9GNtSxZH0jA2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jdCvORKo4WhuRd9QtNP0(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QVQkMBKo7GFmyn05jvkJ(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void h26lEvKo3dkikYoDpoBr(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ILogger)P_0).Error((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tYbiMlKobJgwEHOLgXwX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LyVfNXKoGqfGPWJLHG9g()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public const int RECTANGLE = 0;

	public const int CIRCLE = 1;

	public const int ANNULUS = 2;

	public const int POLYGON = 3;

	private static readonly Lazy<ILogger> O3OdVyxQGL;

	private static readonly string[] zNNdLluDIu;

	private static readonly string[] mmwdJlBGf9;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private static ILogger lXIdY53BaD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return O3OdVyxQGL.Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static RectangleF frodP7jwAB(CvsCellCollection P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return BcI6NOfYsZaLsoS4sHp(GrdldYfMg5yhMmc2aQp(P_0, P_1));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static RectangleF Y8CdsuxLoo(CvsCell P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_004d;
		IL_001a:
		if (P_0 != null)
		{
			num = 6;
			goto IL_004d;
		}
		goto IL_00e3;
		IL_00e3:
		RectangleF result = default;
		return result;
		IL_004d:
		CvsCogImage cvsCogImage = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 6:
				cvsCogImage = ((CvsCogCellResult)HZ7M0ofUiJYCx1bhW4v(P_0)).Value as CvsCogImage;
				goto default;
			default:
				_ = 1;
				if (!wrALr0fFmSN7jbd3RyF())
				{
					num = 1;
					continue;
				}
				num = 2;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 1:
			case 3:
				if (cvsCogImage != null)
				{
					goto case 2;
				}
				goto IL_00e3;
			case 5:
				result = RectangleF.Empty;
				num = 0;
				continue;
			case 2:
			case 4:
				result = new RectangleF(Eh8AYCfHojMq3lLFOqQ(cvsCogImage), BKEKMxfxhn8MGTMhjXn(cvsCogImage), cvsCogImage.Width, l4eWbCfm11rGpMcHPLC(cvsCogImage));
				num = 7;
				if (mToS1Hf0GMAXoWKjguM())
				{
					continue;
				}
				goto IL_00e3;
			case 7:
				goto IL_00e3;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static RectangleF H6gdKNEWcM(CvsCell P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (P_0 == null)
		{
			return new RectangleF(0f, 0f, 2000f, 2000f);
		}
		return BcI6NOfYsZaLsoS4sHp(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateEditBounds(ICvsEditableDisplayGraphic graphic, CvsCell inputImageCell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RectangleF rectangleF = Y8CdsuxLoo(inputImageCell);
		Jrqh2xfQcKBDWwy8hIc(graphic, rectangleF);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IReadOnlyList<string> EditableGraphicShapeNames(bool mustBeExtrudeable)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (!mustBeExtrudeable)
		{
			return zNNdLluDIu;
		}
		return mmwdJlBGf9;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateGraphicShape(CvsDisplayableComposite editableComposite, int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		CvsGraphicAnnulus cvsGraphicAnnulus = default;
		CvsCogEditingAnnulus cvsCogEditingAnnulus = default;
		CvsCogRectangle cvsCogRectangle = default;
		RectangleF rectangleF = default;
		int num2 = default;
		CvsGraphicCircle cvsGraphicCircle = default;
		CvsCogEditingCircle cvsCogEditingCircle = default;
		float num3 = default;
		CvsGraphicRegion cvsGraphicRegion = default;
		CvsCogEditingPolygon cvsCogEditingPolygon = default;
		while (true)
		{
			switch (num)
			{
			case 9:
				GRqWLcfzSWe3yJvUByR(qQNBEPfcPAk1CWH6VqW(editableComposite), 0, cvsGraphicAnnulus, CvsCompositeOperation.Add);
				num = 14;
				if (mToS1Hf0GMAXoWKjguM())
				{
					break;
				}
				goto case 13;
			case 13:
			case 20:
				cvsCogEditingAnnulus.Bounds = cvsCogRectangle;
				num = 3;
				break;
			case 6:
				cvsCogRectangle = new CvsCogRectangle(rectangleF.Left, rectangleF.Top, rectangleF.Width, rectangleF.Height);
				num = 1;
				break;
			case 2:
				if (editableComposite != null)
				{
					num = 16;
					if (wrALr0fFmSN7jbd3RyF())
					{
					}
					break;
				}
				return;
			case 16:
				rectangleF = LPdtIvfNEiSeaa8urRg(editableComposite);
				num = 6;
				break;
			case 0:
			case 11:
				if (num2 >= ((CvsGraphicCompositeBase)qQNBEPfcPAk1CWH6VqW(editableComposite)).Subregions.Length)
				{
					WUxrpGdJppVuST9I41D(editableComposite, A7pfTGdw8wssRcYij95(), Color.Cyan);
					num = 24;
				}
				else
				{
					hXUuqdd5tmlsIQw2wtM(qQNBEPfcPAk1CWH6VqW(editableComposite), num2);
					num = 22;
				}
				break;
			case 19:
				XbcrvcftGCEZ28J0wLi(qQNBEPfcPAk1CWH6VqW(editableComposite), 0, cvsGraphicCircle, CvsCompositeOperation.Add);
				num = 15;
				if (wrALr0fFmSN7jbd3RyF())
				{
				}
				break;
			case 5:
				cvsGraphicCircle = new CvsGraphicCircle(EhMOOsf2HjdGg6eye3Y(editableComposite), cvsCogEditingCircle);
				num = 19;
				if (!wrALr0fFmSN7jbd3RyF())
				{
					break;
				}
				goto case 3;
			case 3:
				cvsGraphicAnnulus = new CvsGraphicAnnulus(EhMOOsf2HjdGg6eye3Y(editableComposite), cvsCogEditingAnnulus);
				num = 9;
				break;
			case 4:
			case 12:
			case 14:
			case 15:
			case 21:
				num2 = 1;
				num = 11;
				break;
			case 7:
			{
				float num4 = num3 / 2f;
				EIsG98fhOrEMraHv1Nf(cvsCogEditingAnnulus, new CvsCogAnnulus(rectangleF.Left + rectangleF.Width / 2f, rectangleF.Top + rectangleF.Height / 2f, num4, num3));
				goto case 13;
			}
			case 1:
				switch (index)
				{
				case 2:
					cvsCogEditingAnnulus = new CvsCogEditingAnnulus();
					num = 8;
					goto end_IL_033e;
				case 0:
					cvsGraphicRegion = new CvsGraphicRegion(EhMOOsf2HjdGg6eye3Y(editableComposite), new PointF(rectangleF.Left, rectangleF.Top), rectangleF.Height, rectangleF.Width, 0.0, 0.0, string.Empty);
					num = 17;
					goto end_IL_033e;
				case 1:
					cvsCogEditingCircle = new CvsCogEditingCircle();
					num = 18;
					goto end_IL_033e;
				case 3:
				{
					double[] points = new double[6]
					{
						rectangleF.Left,
						rectangleF.Bottom,
						rectangleF.Left + rectangleF.Width / 2f,
						rectangleF.Top,
						rectangleF.Right,
						rectangleF.Bottom
					};
					cvsCogEditingPolygon = new CvsCogEditingPolygon();
					cvsCogEditingPolygon.Shape = new CvsCogPolygon(points);
					num = 10;
					goto end_IL_033e;
				}
				}
				wrALr0fFmSN7jbd3RyF();
				if (!mToS1Hf0GMAXoWKjguM())
				{
					num = 20;
					break;
				}
				num = 21;
				if (!wrALr0fFmSN7jbd3RyF())
				{
					break;
				}
				goto case 18;
			case 18:
				EIsG98fhOrEMraHv1Nf(cvsCogEditingCircle, new CvsCogCircle(rectangleF.Left + rectangleF.Width / 2f, rectangleF.Top + rectangleF.Height / 2f, RWFFLefuh4Ld3yZF9V4(rectangleF.Width, rectangleF.Height) / 2f));
				num = 23;
				if (true)
				{
					break;
				}
				goto case 23;
			case 23:
				cvsCogEditingCircle.Bounds = cvsCogRectangle;
				num = 5;
				break;
			case 10:
			{
				pnixAFdLdynlIuIcrt7(cvsCogEditingPolygon, cvsCogRectangle);
				CvsGraphicPolygon cvsGraphicPolygon = new CvsGraphicPolygon(EhMOOsf2HjdGg6eye3Y(editableComposite), cvsCogEditingPolygon);
				KIMfgTdKKwVW1sJ51qB(qQNBEPfcPAk1CWH6VqW(editableComposite), 0, cvsGraphicPolygon, CvsCompositeOperation.Add);
				num = 12;
				if (mToS1Hf0GMAXoWKjguM())
				{
					break;
				}
				goto case 17;
			}
			case 17:
				pmsXiWf10BIfs31LIGX(qQNBEPfcPAk1CWH6VqW(editableComposite), 0, cvsGraphicRegion, CvsCompositeOperation.Add);
				goto case 4;
			case 8:
				num3 = RWFFLefuh4Ld3yZF9V4(rectangleF.Width, rectangleF.Height) / 2f;
				goto case 7;
			default:
				num = 7;
				if (mToS1Hf0GMAXoWKjguM())
				{
					break;
				}
				goto case 0;
			case 22:
				num2++;
				num = 0;
				break;
			case 24:
				return;
				end_IL_033e:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayableComposite ConstructComposite(CvsCellLocation loc, double x, double y, double width, double height, double angle, double curve, CvsCogRectangle bounds = null, bool mustBeExtrudeable = false)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		CvsCogEditingCompositeRegion cvsCogEditingCompositeRegion = default;
		CvsCogCompositeRegion cvsCogCompositeRegion = default;
		CvsCogSubRegion[] array = default;
		while (true)
		{
			switch (num)
			{
			case 11:
				EIsG98fhOrEMraHv1Nf(cvsCogEditingCompositeRegion, cvsCogCompositeRegion);
				num = 8;
				break;
			case 1:
			case 3:
				array[0] = new CvsCogSubRegion(add: true, new CvsCogRegion(x, y, width, height, angle, curve));
				C3R30qdakO6g5yGv6bq(cvsCogCompositeRegion, array);
				num = 11;
				break;
			case 4:
				cvsCogEditingCompositeRegion = new CvsCogEditingCompositeRegion();
				num = 2;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			case 0:
				array = new CvsCogSubRegion[1];
				_ = 0;
				if (mToS1Hf0GMAXoWKjguM())
				{
					num = 1;
					break;
				}
				num = 5;
				if (true)
				{
					break;
				}
				goto case 6;
			case 2:
				cvsCogCompositeRegion = new CvsCogCompositeRegion();
				num = 0;
				break;
			case 7:
				WOc2dIdIDf8M6nDV4n3(cvsCogEditingCompositeRegion, true);
				num = 10;
				break;
			case 10:
				eq5lZhdDn9JKi38ZMn9(cvsCogEditingCompositeRegion, true);
				goto case 5;
			case 6:
				Mf8uahdOVGKq80K4XvH(cvsCogEditingCompositeRegion, true);
				num = 7;
				break;
			case 8:
				pnixAFdLdynlIuIcrt7(cvsCogEditingCompositeRegion, bounds ?? new CvsCogRectangle(0.0, 0.0, 2448.0, 2048.0));
				M3uQsNdeboXVCUtpd8d(cvsCogEditingCompositeRegion, true);
				goto case 6;
			default:
				num = 6;
				break;
			case 5:
			case 9:
				OPScbndir4RbxHMdITY(cvsCogEditingCompositeRegion, true);
				num = 12;
				break;
			case 12:
			{
				CvsDisplayableComposite cvsDisplayableComposite = new CvsDisplayableComposite(new CvsGraphicComposite(loc, cvsCogEditingCompositeRegion, mustBeExtrudeable));
				dahdGvXUmN(cvsDisplayableComposite, A7pfTGdw8wssRcYij95(), A7pfTGdw8wssRcYij95());
				return cvsDisplayableComposite;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayableComposite ConstructComposite(CvsCellLocation loc, CvsCellCollection cells, CvsCellLocation inputImageLocation, bool mustBeExtrudeable)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!wrALr0fFmSN7jbd3RyF())
		{
			num = 2;
		}
		else
		{
			num = 6;
			if (!mToS1Hf0GMAXoWKjguM())
			{
				goto IL_00ba;
			}
		}
		goto IL_0167;
		IL_00d4:
		CvsCogEditingCompositeRegion cvsCogEditingCompositeRegion = default;
		CvsDisplayableComposite cvsDisplayableComposite = new CvsDisplayableComposite(new CvsGraphicComposite(loc, cvsCogEditingCompositeRegion, mustBeExtrudeable));
		CvsCell cvsCell = default;
		cF8BJudfmkeUvuejUgb(cvsDisplayableComposite, zELLpOdVhaMhf7GpayG(cvsCell));
		GDagGjddwuoZPkq09fO(cvsDisplayableComposite, Color.LightGreen);
		MFQmAqdgSmwW1rETdvE(cvsDisplayableComposite, B95yx3dlbtWUhZ72Fh4());
		CvsDisplayableComposite cvsDisplayableComposite2 = cvsDisplayableComposite;
		num = 1;
		goto IL_0167;
		IL_00ba:
		eq5lZhdDn9JKi38ZMn9(cvsCogEditingCompositeRegion, true);
		cvsCogEditingCompositeRegion.EditRegions = true;
		num = 13;
		if (false)
		{
			goto IL_00d4;
		}
		goto IL_0167;
		IL_0167:
		CvsCogCompositeRegion cvsCogCompositeRegion = default;
		RectangleF rectangleF = default;
		while (true)
		{
			switch (num)
			{
			case 11:
				EIsG98fhOrEMraHv1Nf(cvsCogEditingCompositeRegion, cvsCogCompositeRegion);
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 4;
			case 4:
			case 6:
				if (cvsCogCompositeRegion != null)
				{
					cvsCogEditingCompositeRegion = new CvsCogEditingCompositeRegion();
					num = 11;
					if (true)
					{
						continue;
					}
					goto case 0;
				}
				goto IL_01d1;
			case 0:
			case 2:
				cvsDisplayableComposite2 = null;
				num = 14;
				continue;
			case 3:
				WOc2dIdIDf8M6nDV4n3(cvsCogEditingCompositeRegion, true);
				num = 7;
				if (mToS1Hf0GMAXoWKjguM())
				{
					continue;
				}
				goto case 8;
			case 8:
				if (cvsCell != null)
				{
					num = 15;
					continue;
				}
				goto IL_01d1;
			case 12:
				Mf8uahdOVGKq80K4XvH(cvsCogEditingCompositeRegion, true);
				num = 3;
				continue;
			case 15:
				cvsCogCompositeRegion = cvsCell.CellResult.Value as CvsCogCompositeRegion;
				goto case 4;
			case 7:
				break;
			case 13:
				goto IL_00d4;
			case 5:
				rectangleF = AB6ZdCdnFUbSYyKM8Bg(cells, inputImageLocation);
				num = 10;
				if (0 == 0)
				{
					continue;
				}
				goto case 10;
			case 10:
				pnixAFdLdynlIuIcrt7(cvsCogEditingCompositeRegion, new CvsCogRectangle(rectangleF.X, rectangleF.Y, rectangleF.Width, rectangleF.Height));
				cvsCogEditingCompositeRegion.Move = true;
				goto case 12;
			default:
				num = 12;
				continue;
			case 14:
				cvsCell = (CvsCell)GrdldYfMg5yhMmc2aQp(cells, loc);
				num = 8;
				continue;
			case 9:
				cvsDisplayableComposite2.Visible = false;
				num = 16;
				continue;
			case 1:
			case 16:
				{
					return cvsDisplayableComposite2;
				}
				IL_01d1:
				cvsDisplayableComposite2 = ConstructComposite(loc, 10.0, 10.0, 100.0, 100.0, 0.0, 0.0, null, mustBeExtrudeable);
				num = 9;
				continue;
			}
			break;
		}
		goto IL_00ba;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayableComposite ConstructComposite(CvsCellLocation loc, double x, double y, double width, double height, double angle, double curve, CvsCell imageCell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsDisplayableComposite cvsDisplayableComposite = ConstructComposite(loc, x, y, width, height, angle, curve);
		PGlDhIdsKN90dMD6Nsa(cvsDisplayableComposite, BcI6NOfYsZaLsoS4sHp(imageCell));
		return cvsDisplayableComposite;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateCompositeRegion(CvsDisplayableComposite editableCompositeRegion, CvsCellCollection cells, bool pass)
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
		goto IL_006a;
		IL_0105:
		Color color2;
		Color color = color2;
		if (!pass)
		{
			num = 13;
			goto IL_006a;
		}
		Color color3 = Color.LimeGreen;
		goto IL_0168;
		IL_0159:
		color3 = Color.OrangeRed;
		goto IL_0168;
		IL_0168:
		Color color4 = color3;
		WUxrpGdJppVuST9I41D(editableCompositeRegion, color, color4);
		num = 11;
		goto IL_006a;
		IL_001a:
		CvsCogCompositeRegion cvsCogCompositeRegion = default;
		((CvsGraphic)K8prO9dBnkFAuCEWnkh(editableCompositeRegion)).Label = (string)uoVUtKdbGiDSRZWLicu(cvsCogCompositeRegion);
		if (!pass)
		{
			goto IL_00f6;
		}
		color2 = B95yx3dlbtWUhZ72Fh4();
		goto IL_0105;
		IL_006a:
		CvsCell cvsCell = default;
		while (true)
		{
			switch (num)
			{
			case 7:
				break;
			case 0:
				UAYIwVdZ3hj6vgvEwC2(qQNBEPfcPAk1CWH6VqW(editableCompositeRegion), qUtscgdPDxprTgamgql(cvsCogCompositeRegion));
				goto case 5;
			default:
				num = 5;
				continue;
			case 2:
				if (editableCompositeRegion != null)
				{
					num = 3;
					continue;
				}
				return;
			case 10:
				if (!t9yDUddv3BFYnY0HCib(cvsCell))
				{
					_ = 0;
					if (!mToS1Hf0GMAXoWKjguM())
					{
						num = 12;
						if (mToS1Hf0GMAXoWKjguM())
						{
							continue;
						}
						goto case 0;
					}
					num = 6;
					continue;
				}
				goto IL_0184;
			case 8:
				if (cvsCell != null)
				{
					num = 10;
					continue;
				}
				goto IL_0184;
			case 9:
			case 12:
				goto IL_00f6;
			case 4:
			case 6:
				cvsCogCompositeRegion = rWfTqFdrtEoLu9y7XbC(cvsCell.CellResult) as CvsCogCompositeRegion;
				num = 1;
				continue;
			case 1:
				if (cvsCogCompositeRegion != null)
				{
					num = 0;
					if (0 == 0)
					{
						continue;
					}
					goto case 5;
				}
				cF8BJudfmkeUvuejUgb(editableCompositeRegion, false);
				return;
			case 5:
				cF8BJudfmkeUvuejUgb(editableCompositeRegion, zELLpOdVhaMhf7GpayG(cvsCell));
				num = 7;
				continue;
			case 13:
				goto IL_0159;
			case 11:
				return;
			case 3:
				cvsCell = (CvsCell)GrdldYfMg5yhMmc2aQp(cells, EhMOOsf2HjdGg6eye3Y(editableCompositeRegion));
				num = 8;
				if (0 == 0)
				{
					continue;
				}
				return;
			case 14:
				return;
				IL_0184:
				cF8BJudfmkeUvuejUgb(editableCompositeRegion, false);
				num = 14;
				if (mToS1Hf0GMAXoWKjguM())
				{
					continue;
				}
				goto case 3;
			}
			break;
		}
		goto IL_001a;
		IL_00f6:
		color2 = CyrgxCdGKMH0FK5brCc();
		goto IL_0105;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dahdGvXUmN(CvsDisplayableComposite P_0, Color P_1, Color P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		int num2 = default;
		ICvsEditableDisplayGraphic[] array = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				num2 = 0;
				goto case 3;
			default:
				num = 4;
				break;
			case 0:
				array = (ICvsEditableDisplayGraphic[])a7VVcndoRkKN6ZyPDPO(P_0);
				num = 8;
				break;
			case 2:
			case 5:
				num2++;
				goto case 3;
			case 1:
				P_0.SelectedColor = P_2;
				num = 0;
				break;
			case 3:
			case 4:
			case 6:
				if (num2 < array.Length)
				{
					CvsEditableDisplayGraphic obj = array[num2] as CvsEditableDisplayGraphic;
					MFQmAqdgSmwW1rETdvE(obj, P_1);
					GDagGjddwuoZPkq09fO(obj, P_2);
					_ = 0;
					num = (mToS1Hf0GMAXoWKjguM() ? 2 : 3);
				}
				else
				{
					num = 9;
				}
				break;
			case 7:
				MFQmAqdgSmwW1rETdvE(P_0, P_1);
				num = 1;
				break;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void QEqdBh4Zei(CvsGraphicCompositeBase P_0, CvsCogSubRegion[] P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 16;
		if (!mToS1Hf0GMAXoWKjguM())
		{
			goto IL_001e;
		}
		goto IL_006d;
		IL_001e:
		int num2 = default;
		CvsCogSubRegion cvsCogSubRegion = default;
		RHlT9Ld89y9tDUZO5L9(num2, P_0, cvsCogSubRegion);
		goto IL_0198;
		IL_006d:
		CvsCompositeSubregion cvsCompositeSubregion = default;
		CvsCompositeShapeType cvsCompositeShapeType = default;
		int num3 = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 9:
				cvsCompositeSubregion = null;
				num = 14;
				if (wrALr0fFmSN7jbd3RyF())
				{
				}
				continue;
			case 16:
				num2 = 0;
				num = 0;
				continue;
			case 17:
				cvsCompositeShapeType = CvsCompositeShapeType.PolygonType;
				goto case 5;
			default:
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 15;
			case 15:
				if (Oil9acdkORZLf0WpY1K(cvsCompositeSubregion) != cvsCompositeShapeType)
				{
					num = 4;
					if (mToS1Hf0GMAXoWKjguM())
					{
						continue;
					}
					goto case 3;
				}
				yNk9ghdqandMdNIcgMg(cvsCompositeSubregion, cvsCogSubRegion);
				num = 1;
				if (wrALr0fFmSN7jbd3RyF())
				{
				}
				continue;
			case 3:
				cvsCompositeShapeType = CvsCompositeShapeType.CircleType;
				goto case 5;
			case 2:
				cvsCompositeShapeType = CvsCompositeShapeType.RegionType;
				num = 10;
				continue;
			case 5:
			case 6:
			case 10:
				if (num2 < P_0.Subregions.Length)
				{
					cvsCompositeSubregion = P_0.Subregions[num2];
				}
				if (cvsCompositeSubregion != null)
				{
					num = 15;
					continue;
				}
				break;
			case 1:
			case 13:
			case 20:
				goto IL_0198;
			case 8:
				num3--;
				goto case 18;
			case 18:
				if (num3 < P_1.Length)
				{
					num = 21;
					continue;
				}
				hXUuqdd5tmlsIQw2wtM(P_0, num3);
				num = 8;
				continue;
			case 19:
				num3 = ((Array)z9raIldEjHGJClpguIK(P_0)).Length - 1;
				num = 18;
				continue;
			case 0:
			case 11:
				if (num2 < P_1.Length)
				{
					cvsCogSubRegion = P_1[num2];
					num = 9;
					continue;
				}
				num = 19;
				if (mToS1Hf0GMAXoWKjguM())
				{
					continue;
				}
				goto case 7;
			case 7:
			case 12:
				cvsCompositeShapeType = CvsCompositeShapeType.AnnulusType;
				num = 6;
				if (mToS1Hf0GMAXoWKjguM())
				{
					continue;
				}
				goto case 18;
			case 14:
				cvsCompositeShapeType = CvsCompositeShapeType.None;
				if (!(CfYv8jdSCpxwMvm859j(cvsCogSubRegion) is CvsCogRegion))
				{
					if (!(cvsCogSubRegion.Shape is CvsCogCircle))
					{
						if (CfYv8jdSCpxwMvm859j(cvsCogSubRegion) is CvsCogAnnulus)
						{
							_ = 0;
							if (!mToS1Hf0GMAXoWKjguM())
							{
								num = 20;
								continue;
							}
							num = 12;
							if (true)
							{
								continue;
							}
							goto case 2;
						}
						if (CfYv8jdSCpxwMvm859j(cvsCogSubRegion) is CvsCogPolygon)
						{
							num = 17;
							continue;
						}
					}
					else
					{
						num = 3;
						if (mToS1Hf0GMAXoWKjguM())
						{
							continue;
						}
					}
					goto case 5;
				}
				num = 2;
				continue;
			case 21:
				return;
			}
			break;
		}
		goto IL_001e;
		IL_0198:
		num2++;
		num = 11;
		if (wrALr0fFmSN7jbd3RyF())
		{
		}
		goto IL_006d;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static CvsCompositeSubregion zhUdZHbQBc(int P_0, CvsGraphicCompositeBase P_1, CvsCogSubRegion P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 10;
		if (!mToS1Hf0GMAXoWKjguM())
		{
			goto IL_004b;
		}
		goto IL_00f0;
		IL_004b:
		CvsCompositeSubregion cvsCompositeSubregion = default;
		while (cvsCompositeSubregion != null)
		{
			num = 3;
			if (false)
			{
				continue;
			}
			goto IL_00f0;
		}
		goto IL_0198;
		IL_00f0:
		CvsCompositeOperation cvsCompositeOperation = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				cvsCompositeSubregion = P_1.InsertPolygon(P_0, new CvsGraphicPolygon(), cvsCompositeOperation);
				break;
			case 3:
				yNk9ghdqandMdNIcgMg(cvsCompositeSubregion, P_2);
				num = 13;
				continue;
			case 0:
				goto IL_00ac;
			case 7:
				cvsCompositeSubregion = (CvsCompositeSubregion)XbcrvcftGCEZ28J0wLi(P_1, P_0, new CvsGraphicCircle(), cvsCompositeOperation);
				break;
			case 9:
				goto IL_013d;
			case 11:
				cvsCompositeSubregion = (CvsCompositeSubregion)GRqWLcfzSWe3yJvUByR(P_1, P_0, new CvsGraphicAnnulus(), cvsCompositeOperation);
				num = 2;
				continue;
			case 10:
				cvsCompositeSubregion = null;
				num = 9;
				continue;
			case 1:
				goto IL_0176;
			case 13:
				goto IL_0198;
			}
			break;
			IL_0176:
			int num2 = 0;
			goto IL_017d;
			IL_013d:
			if (!FYDvY1dp925WVB11uJP(P_2))
			{
				num = 1;
				continue;
			}
			num2 = 1;
			goto IL_017d;
			IL_017d:
			cvsCompositeOperation = (CvsCompositeOperation)num2;
			if (!(CfYv8jdSCpxwMvm859j(P_2) is CvsCogRegion))
			{
				if (CfYv8jdSCpxwMvm859j(P_2) is CvsCogCircle)
				{
					num = 7;
					continue;
				}
				if (CfYv8jdSCpxwMvm859j(P_2) is CvsCogAnnulus)
				{
					num = 11;
					continue;
				}
				if (!(CfYv8jdSCpxwMvm859j(P_2) is CvsCogPolygon))
				{
					break;
				}
				num = 8;
			}
			else
			{
				num = 0;
			}
			continue;
			IL_00ac:
			cvsCompositeSubregion = (CvsCompositeSubregion)pmsXiWf10BIfs31LIGX(P_1, P_0, new CvsGraphicRegion(), cvsCompositeOperation);
			_ = 1;
			num = (wrALr0fFmSN7jbd3RyF() ? 12 : 5);
		}
		goto IL_004b;
		IL_0198:
		return cvsCompositeSubregion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void QybdnssorF(CvsCompositeSubregion P_0, CvsCogSubRegion P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		CvsGraphicCircle cvsGraphicCircle = default;
		CvsCogCircle cvsCogCircle = default;
		CvsGraphicPolygon cvsGraphicPolygon = default;
		PointF[] array = default;
		CvsGraphicRegion cvsGraphicRegion = default;
		CvsCogRegion cvsCogRegion = default;
		CvsCogAnnulus cvsCogAnnulus = default;
		CvsGraphicAnnulus cvsGraphicAnnulus = default;
		int num3 = default;
		CvsCogPolygon cvsCogPolygon = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 22:
				if (cvsGraphicCircle != null)
				{
					KFFW2ddXPbKba134sOG(P_0, FYDvY1dp925WVB11uJP(P_1) ? CvsCompositeOperation.Add : CvsCompositeOperation.Subtract);
					cvsGraphicCircle.Center = new PointF((float)inXsModTqVtDXjpIZ5A(cvsCogCircle), (float)cvsCogCircle.Y);
					cvsGraphicCircle.Radius = (float)cvsCogCircle.Radius;
					num = 0;
					break;
				}
				return;
			case 19:
			case 28:
				P_0.Operation = (P_1.Add ? CvsCompositeOperation.Add : CvsCompositeOperation.Subtract);
				dgSpVQdmj1T6JvilQlm(cvsGraphicPolygon, array);
				num = 31;
				break;
			case 24:
				cvsGraphicRegion = P_0.InSightGraphic as CvsGraphicRegion;
				num = 16;
				break;
			case 2:
			case 25:
				cvsCogRegion = CfYv8jdSCpxwMvm859j(P_1) as CvsCogRegion;
				if (cvsCogRegion != null)
				{
					num = 24;
					break;
				}
				goto IL_037c;
			case 4:
				if (cvsCogCircle != null)
				{
					num = 17;
					if (true)
					{
						break;
					}
					goto case 17;
				}
				goto IL_0294;
			case 17:
				cvsGraphicCircle = tomBTrdWBZDh9G0hDsi(P_0) as CvsGraphicCircle;
				num = 22;
				if (0 == 0)
				{
					break;
				}
				goto case 20;
			case 20:
				if (cvsCogAnnulus != null)
				{
					cvsGraphicAnnulus = tomBTrdWBZDh9G0hDsi(P_0) as CvsGraphicAnnulus;
					num = 18;
					break;
				}
				goto IL_017f;
			case 30:
				cMXsHVd6bfPIjomIIEk(cvsGraphicRegion, ju9lvudjVIsCqdG7Bx2(cvsCogRegion));
				RWMd1ydAoKD3hvwrG5o(cvsGraphicRegion, Vlvh3YdC2dNYPjLExcf(cvsCogRegion));
				num = 8;
				break;
			case 3:
				cvsCogAnnulus = CfYv8jdSCpxwMvm859j(P_1) as CvsCogAnnulus;
				num = 20;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				num3 = 0;
				goto case 27;
			case 26:
				return;
			case 1:
				if (P_0 != null)
				{
					num = 21;
					if (wrALr0fFmSN7jbd3RyF())
					{
					}
					break;
				}
				return;
			case 11:
				Y5tqIpd3Ms4X5vOiUb4(cvsGraphicRegion, kTd4LZd7GcfJkjWEcIs(cvsCogRegion));
				num = 30;
				break;
			case 14:
				if (cvsCogPolygon != null)
				{
					num = 15;
					break;
				}
				return;
			case 29:
				num2 = 0;
				num = 5;
				break;
			case 10:
				array = new PointF[cvsCogPolygon.Points.Length / 2];
				num = 29;
				if (wrALr0fFmSN7jbd3RyF())
				{
				}
				break;
			case 16:
				if (cvsGraphicRegion != null)
				{
					num = 9;
					if (true)
					{
						break;
					}
					goto case 13;
				}
				return;
			case 13:
				cvsCogCircle = CfYv8jdSCpxwMvm859j(P_1) as CvsCogCircle;
				num = 4;
				break;
			case 8:
				byeU79dRchxnySruxNT(cvsGraphicRegion, cvsCogRegion.Curve);
				num = 23;
				break;
			case 15:
				cvsGraphicPolygon = tomBTrdWBZDh9G0hDsi(P_0) as CvsGraphicPolygon;
				num = 6;
				break;
			case 7:
				num2++;
				num = 12;
				if (true)
				{
					break;
				}
				goto case 12;
			case 12:
				num3 += 2;
				num = 27;
				if (!mToS1Hf0GMAXoWKjguM())
				{
					return;
				}
				break;
			case 0:
				return;
			default:
				num = 3;
				break;
			case 21:
				if (P_1 == null)
				{
					return;
				}
				if (Oil9acdkORZLf0WpY1K(P_0) == CvsCompositeShapeType.RegionType)
				{
					_ = 1;
					num = (wrALr0fFmSN7jbd3RyF() ? 19 : 25);
					break;
				}
				goto IL_037c;
			case 6:
				if (cvsGraphicPolygon != null)
				{
					num = 10;
					break;
				}
				return;
			case 23:
				return;
			case 9:
				KFFW2ddXPbKba134sOG(P_0, FYDvY1dp925WVB11uJP(P_1) ? CvsCompositeOperation.Add : CvsCompositeOperation.Subtract);
				BXd6Kdd4msLpXXw0ffP(cvsGraphicRegion, new PointF((float)dwyoyGd9bQQkWjSegsB(cvsCogRegion), (float)cvsCogRegion.Y));
				num = 11;
				break;
			case 27:
				if (num2 < array.Length)
				{
					array[num2] = new PointF((float)((double[])NsUVM8dx3mrOY66unh3(cvsCogPolygon))[num3], (float)((double[])NsUVM8dx3mrOY66unh3(cvsCogPolygon))[num3 + 1]);
					num = 7;
					break;
				}
				goto case 19;
			case 18:
				if (cvsGraphicAnnulus != null)
				{
					KFFW2ddXPbKba134sOG(P_0, FYDvY1dp925WVB11uJP(P_1) ? CvsCompositeOperation.Add : CvsCompositeOperation.Subtract);
					fRi7YTdFGLZrusV1UTO(cvsGraphicAnnulus, new PointF((float)YfYHTbdylFpTM7dZu0c(cvsCogAnnulus), (float)dYK6iyd0h06q7Hu9IVQ(cvsCogAnnulus)));
					zHpLFXdYRJi2sFr8LlC(cvsGraphicAnnulus, (float)wcnjkidM4hdhlssFFoo(cvsCogAnnulus));
					iYZrandHPr17Xcsd1pH(cvsGraphicAnnulus, (float)WRVp3odUVR7KR117Byw(cvsCogAnnulus));
					num = 26;
					break;
				}
				return;
			case 31:
				return;
				IL_017f:
				if (P_0.ShapeType == CvsCompositeShapeType.PolygonType)
				{
					cvsCogPolygon = CfYv8jdSCpxwMvm859j(P_1) as CvsCogPolygon;
					num = 14;
					break;
				}
				return;
				IL_037c:
				if (Oil9acdkORZLf0WpY1K(P_0) == CvsCompositeShapeType.CircleType)
				{
					num = 13;
					break;
				}
				goto IL_0294;
				IL_0294:
				if (Oil9acdkORZLf0WpY1K(P_0) == CvsCompositeShapeType.AnnulusType)
				{
					goto case 3;
				}
				goto IL_017f;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayableRegion ConstructRegion(CvsCellLocation regionLocation, CvsResultSet results)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 13;
		CvsDisplayableRegion cvsDisplayableRegion = default;
		CvsCogRegion cvsCogRegion = default;
		CvsCell cvsCell = default;
		while (true)
		{
			switch (num)
			{
			case 7:
			case 11:
				cvsDisplayableRegion.AutoHighlight = true;
				goto case 8;
			case 1:
				if (cvsCogRegion != null)
				{
					cvsDisplayableRegion = new CvsDisplayableRegion(new CvsGraphicRegion(regionLocation, new PointF((float)dwyoyGd9bQQkWjSegsB(cvsCogRegion), (float)sxr6djdQqwO3u1RE47f(cvsCogRegion)), ju9lvudjVIsCqdG7Bx2(cvsCogRegion), kTd4LZd7GcfJkjWEcIs(cvsCogRegion), cvsCogRegion.Angle, M6ORltdNjG0iteLMZv0(cvsCogRegion), string.Empty));
					num = 6;
					if (!wrALr0fFmSN7jbd3RyF())
					{
						break;
					}
					goto case 6;
				}
				goto IL_01be;
			case 6:
				cvsDisplayableRegion.Color = sv7waUd2Rw8cAd7DW9K();
				num = 2;
				break;
			case 3:
				cvsCogRegion = rWfTqFdrtEoLu9y7XbC(HZ7M0ofUiJYCx1bhW4v(cvsCell)) as CvsCogRegion;
				num = 1;
				break;
			case 2:
				GDagGjddwuoZPkq09fO(cvsDisplayableRegion, RZSF5BdcSBMbJnWEOdi());
				num = 0;
				if (wrALr0fFmSN7jbd3RyF())
				{
				}
				break;
			case 13:
				cvsDisplayableRegion = null;
				num = 12;
				if (true)
				{
					break;
				}
				goto case 5;
			case 5:
				cF8BJudfmkeUvuejUgb(cvsDisplayableRegion, false);
				num = 14;
				if (mToS1Hf0GMAXoWKjguM())
				{
					break;
				}
				goto case 12;
			case 12:
				cvsCell = (CvsCell)GrdldYfMg5yhMmc2aQp(results.Cells, regionLocation);
				if (cvsCell != null)
				{
					num = 3;
					break;
				}
				goto IL_01be;
			case 0:
				GaBpZ8d1rpy1pxny7fR(cvsDisplayableRegion, CvsEditFlags.None);
				goto default;
			default:
				_ = 0;
				if (!mToS1Hf0GMAXoWKjguM())
				{
					num = 10;
					if (mToS1Hf0GMAXoWKjguM())
					{
						break;
					}
					goto case 1;
				}
				num = 11;
				break;
			case 8:
			case 10:
				UxOV4JduYxpwXXBLZ0b(cvsDisplayableRegion, true);
				num = 4;
				break;
			case 4:
				cF8BJudfmkeUvuejUgb(cvsDisplayableRegion, cvsCell.Enabled);
				num = 9;
				if (wrALr0fFmSN7jbd3RyF())
				{
				}
				break;
			case 9:
			case 14:
				{
					return cvsDisplayableRegion;
				}
				IL_01be:
				cvsDisplayableRegion = new CvsDisplayableRegion(new CvsGraphicRegion(regionLocation, new PointF(50f, 50f), 100.0, 100.0, 0.0, 0.0, string.Empty));
				num = 5;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayableRegion ConstructRegion(CvsCogRegion region, CvsCogRegion bounds, string displayName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsDisplayableRegion cvsDisplayableRegion = new CvsDisplayableRegion(new CvsGraphicRegion(CvsCellLocation.Invalid, new PointF((float)dwyoyGd9bQQkWjSegsB(region), (float)sxr6djdQqwO3u1RE47f(region)), ju9lvudjVIsCqdG7Bx2(region), kTd4LZd7GcfJkjWEcIs(region), Vlvh3YdC2dNYPjLExcf(region), M6ORltdNjG0iteLMZv0(region), displayName));
		PGlDhIdsKN90dMD6Nsa(cvsDisplayableRegion, new RectangleF((float)bounds.X, (float)sxr6djdQqwO3u1RE47f(bounds), (float)bounds.Width, (float)ju9lvudjVIsCqdG7Bx2(bounds)));
		GaBpZ8d1rpy1pxny7fR(cvsDisplayableRegion, CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation);
		return cvsDisplayableRegion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayableRegion ConstructRegion(CvsCellLocation loc, double x, double y, double width, double height, double angle, double curve, CvsCell imageCell = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsDisplayableRegion cvsDisplayableRegion = new CvsDisplayableRegion(new CvsGraphicRegion(loc, new PointF((float)x, (float)y), height, width, angle, curve, string.Empty));
		PGlDhIdsKN90dMD6Nsa(cvsDisplayableRegion, H6gdKNEWcM(imageCell));
		GaBpZ8d1rpy1pxny7fR(cvsDisplayableRegion, CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation);
		return cvsDisplayableRegion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayableRegion ConstructRegion(CvsCellLocation loc, CvsCellCollection cells, CvsCellLocation inputImageLocation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		wrALr0fFmSN7jbd3RyF();
		int num;
		if (mToS1Hf0GMAXoWKjguM())
		{
			num = 2;
		}
		else
		{
			num = 8;
			if (false)
			{
				goto IL_013d;
			}
		}
		goto IL_0155;
		IL_0155:
		CvsCell cvsCell = default;
		CvsDisplayableRegion cvsDisplayableRegion = default;
		CvsCogRegion cvsCogRegion = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				cvsCell = cells[loc];
				num = 9;
				continue;
			case 4:
				cF8BJudfmkeUvuejUgb(cvsDisplayableRegion, false);
				num = 10;
				continue;
			case 9:
				break;
			case 0:
			case 2:
				cvsDisplayableRegion = null;
				num = 5;
				continue;
			case 3:
				cvsCogRegion = ((CvsCogCellResult)HZ7M0ofUiJYCx1bhW4v(cvsCell)).Value as CvsCogRegion;
				num = 1;
				continue;
			case 7:
				goto end_IL_0155;
			case 1:
				goto IL_013d;
			default:
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto IL_0192;
			case 6:
			case 8:
			case 10:
				goto IL_0192;
			}
			if (cvsCell != null)
			{
				num = 3;
				continue;
			}
			goto IL_0060;
			continue;
			end_IL_0155:
			break;
		}
		goto IL_00cf;
		IL_0060:
		cvsDisplayableRegion = ConstructRegion(loc, 100.0, 100.0, 200.0, 100.0, 0.0, 0.0);
		num = 4;
		goto IL_0155;
		IL_013d:
		if (cvsCogRegion == null)
		{
			goto IL_0060;
		}
		goto IL_00cf;
		IL_0192:
		return cvsDisplayableRegion;
		IL_00cf:
		CvsDisplayableRegion cvsDisplayableRegion2 = new CvsDisplayableRegion(new CvsGraphicRegion(loc, new PointF((float)dwyoyGd9bQQkWjSegsB(cvsCogRegion), (float)sxr6djdQqwO3u1RE47f(cvsCogRegion)), ju9lvudjVIsCqdG7Bx2(cvsCogRegion), kTd4LZd7GcfJkjWEcIs(cvsCogRegion), Vlvh3YdC2dNYPjLExcf(cvsCogRegion), M6ORltdNjG0iteLMZv0(cvsCogRegion), string.Empty))
		{
			EditBounds = AB6ZdCdnFUbSYyKM8Bg(cells, inputImageLocation),
			EditFlags = (CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation)
		};
		cF8BJudfmkeUvuejUgb(cvsDisplayableRegion2, zELLpOdVhaMhf7GpayG(cvsCell));
		cvsDisplayableRegion = cvsDisplayableRegion2;
		goto IL_0192;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayableRegion ConstructRegionCenteredToImage(CvsCellLocation loc, CvsCell imageCell, SizeF maxSize, string displayName = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (wrALr0fFmSN7jbd3RyF() ? 5 : 4);
		int num3 = default;
		RectangleF rectangleF = default;
		int num4 = default;
		int num5 = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				num3 = (int)Math.Floor(rectangleF.Y + (rectangleF.Height - (float)num4) / 2f);
				num = 7;
				break;
			case 3:
				num4 = (int)uukcUudtdcHjAbKrUcV(Math.Min(maxSize.Height, rectangleF.Height - 60f));
				goto case 2;
			default:
				num = 2;
				break;
			case 0:
			case 4:
				rectangleF = v09n8ddhU9fmaZGYalQ(imageCell);
				goto case 1;
			case 1:
			case 5:
				num5 = (int)uukcUudtdcHjAbKrUcV(Math.Min(maxSize.Width, rectangleF.Width - 60f));
				num = 3;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
				num2 = (int)QE78PJdz5RmnlLiRt0O(rectangleF.X + (rectangleF.Width - (float)num5) / 2f);
				num = 6;
				break;
			case 7:
			{
				CvsDisplayableRegion cvsDisplayableRegion = new CvsDisplayableRegion(new CvsGraphicRegion(loc, new PointF(num2, num3), num4, num5, 0.0, 0.0, displayName));
				PGlDhIdsKN90dMD6Nsa(cvsDisplayableRegion, new RectangleF(rectangleF.X, rectangleF.Y, rectangleF.Width, rectangleF.Height));
				cvsDisplayableRegion.EditFlags = CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation;
				return cvsDisplayableRegion;
			}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateRegion(CvsDisplayableRegion editableRegion, CvsCellCollection cells, bool pass)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		CvsCell cvsCell = default;
		CvsCogRegion cvsCogRegion = default;
		Color selectedColor = default;
		Color color2 = default;
		while (true)
		{
			Color color;
			switch (num)
			{
			case 8:
				return;
			case 2:
			case 16:
				if (cvsCell.Error)
				{
					goto IL_0019;
				}
				cvsCogRegion = rWfTqFdrtEoLu9y7XbC(HZ7M0ofUiJYCx1bhW4v(cvsCell)) as CvsCogRegion;
				if (cvsCogRegion != null)
				{
					num = 14;
					if (mToS1Hf0GMAXoWKjguM())
					{
						break;
					}
					goto case 12;
				}
				if (rWfTqFdrtEoLu9y7XbC(HZ7M0ofUiJYCx1bhW4v(cvsCell)) is CvsCogError)
				{
					num = 7;
					if (0 == 0)
					{
						break;
					}
					goto case 6;
				}
				return;
			case 12:
				editableRegion.Visible = zELLpOdVhaMhf7GpayG(cvsCell);
				num = 0;
				if (!mToS1Hf0GMAXoWKjguM())
				{
					return;
				}
				break;
			case 4:
				return;
			case 6:
				((CvsGraphicRegion)FAZTBElLvo8uT8RMV6r(editableRegion)).Curve = M6ORltdNjG0iteLMZv0(cvsCogRegion);
				goto case 12;
			default:
				num = 12;
				break;
			case 10:
				if (cvsCell == null)
				{
					goto IL_0019;
				}
				_ = 0;
				if (mToS1Hf0GMAXoWKjguM())
				{
					num = 16;
					break;
				}
				num = 15;
				if (0 == 0)
				{
					break;
				}
				goto case 9;
			case 11:
			case 15:
				editableRegion.SelectedColor = selectedColor;
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 14;
			case 14:
				BXd6Kdd4msLpXXw0ffP(FAZTBElLvo8uT8RMV6r(editableRegion), new PointF((float)cvsCogRegion.X, (float)sxr6djdQqwO3u1RE47f(cvsCogRegion)));
				num = 5;
				break;
			case 1:
				cvsCell = (CvsCell)GrdldYfMg5yhMmc2aQp(cells, EhMOOsf2HjdGg6eye3Y(editableRegion));
				num = 10;
				break;
			case 0:
				color2 = (pass ? B95yx3dlbtWUhZ72Fh4() : Color.Red);
				if (!pass)
				{
					num = 3;
					break;
				}
				color = sv7waUd2Rw8cAd7DW9K();
				goto IL_01b7;
			case 3:
				color = tyEKhhlKEMxYZvAio7b();
				goto IL_01b7;
			case 9:
				Y5tqIpd3Ms4X5vOiUb4(FAZTBElLvo8uT8RMV6r(editableRegion), kTd4LZd7GcfJkjWEcIs(cvsCogRegion));
				num = 13;
				if (mToS1Hf0GMAXoWKjguM())
				{
					break;
				}
				goto case 13;
			case 13:
				RWMd1ydAoKD3hvwrG5o(FAZTBElLvo8uT8RMV6r(editableRegion), Vlvh3YdC2dNYPjLExcf(cvsCogRegion));
				num = 6;
				break;
			case 5:
				cMXsHVd6bfPIjomIIEk(FAZTBElLvo8uT8RMV6r(editableRegion), cvsCogRegion.Height);
				num = 9;
				break;
			case 7:
				cF8BJudfmkeUvuejUgb(editableRegion, false);
				num = 8;
				break;
			case 17:
				return;
				IL_01b7:
				selectedColor = color;
				MFQmAqdgSmwW1rETdvE(editableRegion, color2);
				goto case 11;
				IL_0019:
				cF8BJudfmkeUvuejUgb(editableRegion, false);
				num = 17;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateRegion(CvsDisplayableRegion editableRegion, AcqRegionPropertyViewModel regionProperty)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		CvsCogRegion localValue = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				editableRegion.Visible = regionProperty.IsEnabled;
				num = 9;
				break;
			case 7:
				RWMd1ydAoKD3hvwrG5o(FAZTBElLvo8uT8RMV6r(editableRegion), Vlvh3YdC2dNYPjLExcf(localValue));
				num = 1;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 2:
			case 6:
				cMXsHVd6bfPIjomIIEk(FAZTBElLvo8uT8RMV6r(editableRegion), ju9lvudjVIsCqdG7Bx2(localValue));
				goto case 0;
			case 0:
			case 3:
				Y5tqIpd3Ms4X5vOiUb4(FAZTBElLvo8uT8RMV6r(editableRegion), kTd4LZd7GcfJkjWEcIs(localValue));
				goto case 7;
			default:
				num = 7;
				if (mToS1Hf0GMAXoWKjguM())
				{
					break;
				}
				goto case 5;
			case 5:
				BXd6Kdd4msLpXXw0ffP(FAZTBElLvo8uT8RMV6r(editableRegion), new PointF((float)dwyoyGd9bQQkWjSegsB(localValue), (float)localValue.Y));
				_ = 0;
				num = (mToS1Hf0GMAXoWKjguM() ? 6 : 0);
				break;
			case 1:
				byeU79dRchxnySruxNT(FAZTBElLvo8uT8RMV6r(editableRegion), M6ORltdNjG0iteLMZv0(localValue));
				num = 8;
				break;
			case 4:
				localValue = regionProperty.LocalValue;
				num = 5;
				break;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayableAnnulus ConstructAnnulus(CvsCellLocation annulusLocation, CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		CvsDisplayableAnnulus cvsDisplayableAnnulus = default;
		CvsCell cvsCell = default;
		CvsCogAnnulus cvsCogAnnulus = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				cF8BJudfmkeUvuejUgb(cvsDisplayableAnnulus, zELLpOdVhaMhf7GpayG(cvsCell));
				num = 4;
				break;
			case 8:
			case 10:
				UxOV4JduYxpwXXBLZ0b(cvsDisplayableAnnulus, true);
				num = 6;
				if (!wrALr0fFmSN7jbd3RyF())
				{
					break;
				}
				goto case 7;
			case 7:
			case 12:
				gsREQ4l5lmyS85lVnVP(cvsDisplayableAnnulus, true);
				goto case 8;
			case 11:
				GDagGjddwuoZPkq09fO(cvsDisplayableAnnulus, RZSF5BdcSBMbJnWEOdi());
				num = 5;
				if (true)
				{
					break;
				}
				goto case 13;
			case 13:
				cvsCell = (CvsCell)GrdldYfMg5yhMmc2aQp(cells, annulusLocation);
				if (cvsCell != null)
				{
					num = 9;
					break;
				}
				goto IL_0033;
			case 0:
				MFQmAqdgSmwW1rETdvE(cvsDisplayableAnnulus, Color.LimeGreen);
				num = 11;
				break;
			case 2:
				cF8BJudfmkeUvuejUgb(cvsDisplayableAnnulus, false);
				num = 14;
				if (mToS1Hf0GMAXoWKjguM())
				{
					break;
				}
				goto case 5;
			case 5:
				cvsDisplayableAnnulus.EditFlags = CvsEditFlags.None;
				goto default;
			default:
				_ = 1;
				num = ((!wrALr0fFmSN7jbd3RyF()) ? 12 : 10);
				break;
			case 1:
				cvsDisplayableAnnulus = null;
				num = 13;
				break;
			case 9:
				cvsCogAnnulus = rWfTqFdrtEoLu9y7XbC(HZ7M0ofUiJYCx1bhW4v(cvsCell)) as CvsCogAnnulus;
				if (cvsCogAnnulus == null)
				{
					goto IL_0033;
				}
				num = 3;
				if (true)
				{
					break;
				}
				goto case 3;
			case 3:
				cvsDisplayableAnnulus = new CvsDisplayableAnnulus(new CvsGraphicAnnulus(annulusLocation, new PointF((float)YfYHTbdylFpTM7dZu0c(cvsCogAnnulus), (float)dYK6iyd0h06q7Hu9IVQ(cvsCogAnnulus)), (float)wcnjkidM4hdhlssFFoo(cvsCogAnnulus), (float)cvsCogAnnulus.OuterRadius, string.Empty));
				num = 0;
				break;
			case 4:
			case 14:
				{
					return cvsDisplayableAnnulus;
				}
				IL_0033:
				cvsDisplayableAnnulus = new CvsDisplayableAnnulus(new CvsGraphicAnnulus(annulusLocation, new PointF(50f, 50f), 100f, 100f, string.Empty));
				num = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayableAnnulus ConstructAnnulus(CvsCellLocation loc, double x, double y, double inner, double outer, CvsCell imageCell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new CvsDisplayableAnnulus(new CvsGraphicAnnulus(loc, new PointF((float)x, (float)y), (float)inner, (float)outer, string.Empty))
		{
			EditBounds = v09n8ddhU9fmaZGYalQ(imageCell),
			EditFlags = (CvsEditFlags.Location | CvsEditFlags.Size)
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayableAnnulus ConstructAnnulus(CvsCellLocation loc, CvsCellCollection cells, CvsCellLocation inputImageLocation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		CvsDisplayableAnnulus cvsDisplayableAnnulus = default;
		CvsCell cvsCell2 = default;
		CvsCogAnnulus cvsCogAnnulus = default;
		CvsCell cvsCell = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				cvsDisplayableAnnulus = null;
				_ = 0;
				if (mToS1Hf0GMAXoWKjguM())
				{
					num = 10;
					break;
				}
				num = 9;
				if (0 == 0)
				{
					break;
				}
				goto case 6;
			case 0:
				cvsDisplayableAnnulus = (CvsDisplayableAnnulus)wB0qFhlw1iaTrTkoDG1(loc, 200.0, 200.0, 75.0, 150.0, cvsCell2);
				num = 6;
				break;
			case 2:
			{
				CvsDisplayableAnnulus cvsDisplayableAnnulus2 = new CvsDisplayableAnnulus(new CvsGraphicAnnulus(loc, new PointF((float)cvsCogAnnulus.X, (float)dYK6iyd0h06q7Hu9IVQ(cvsCogAnnulus)), (float)wcnjkidM4hdhlssFFoo(cvsCogAnnulus), (float)WRVp3odUVR7KR117Byw(cvsCogAnnulus), string.Empty));
				PGlDhIdsKN90dMD6Nsa(cvsDisplayableAnnulus2, frodP7jwAB(cells, inputImageLocation));
				cvsDisplayableAnnulus2.EditFlags = CvsEditFlags.Location | CvsEditFlags.Size;
				cF8BJudfmkeUvuejUgb(cvsDisplayableAnnulus2, zELLpOdVhaMhf7GpayG(cvsCell));
				cvsDisplayableAnnulus = cvsDisplayableAnnulus2;
				num = 7;
				break;
			}
			case 8:
				cvsCogAnnulus = rWfTqFdrtEoLu9y7XbC(HZ7M0ofUiJYCx1bhW4v(cvsCell)) as CvsCogAnnulus;
				goto case 4;
			case 6:
				cvsDisplayableAnnulus.Visible = false;
				num = 11;
				break;
			case 5:
				if (cvsCell == null)
				{
					goto IL_00c7;
				}
				num = 8;
				if (mToS1Hf0GMAXoWKjguM())
				{
					break;
				}
				goto case 1;
			case 1:
			case 10:
				cvsCell = cells[loc];
				num = 5;
				break;
			case 4:
			case 9:
				if (cvsCogAnnulus != null)
				{
					goto case 2;
				}
				goto IL_00c7;
			default:
				num = 2;
				break;
			case 7:
			case 11:
				{
					return cvsDisplayableAnnulus;
				}
				IL_00c7:
				cvsCell2 = (CvsCell)GrdldYfMg5yhMmc2aQp(cells, inputImageLocation);
				num = 0;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateAnnulus(CvsDisplayableAnnulus editableAnnulus, CvsCellCollection cells, bool pass)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		CvsCogAnnulus cvsCogAnnulus = default;
		Color color2 = default;
		CvsCell cvsCell = default;
		while (true)
		{
			Color color;
			Color color3;
			switch (num)
			{
			case 10:
				return;
			case 0:
				((CvsGraphicAnnulus)q5ixXZlJF03FJcqj0Xi(editableAnnulus)).Center = new PointF((float)YfYHTbdylFpTM7dZu0c(cvsCogAnnulus), (float)dYK6iyd0h06q7Hu9IVQ(cvsCogAnnulus));
				num = 4;
				break;
			case 5:
			case 8:
				color2 = (pass ? B95yx3dlbtWUhZ72Fh4() : CyrgxCdGKMH0FK5brCc());
				if (!pass)
				{
					num = 13;
					break;
				}
				color = sv7waUd2Rw8cAd7DW9K();
				goto IL_0087;
			case 13:
				color = tyEKhhlKEMxYZvAio7b();
				goto IL_0087;
			case 1:
				cF8BJudfmkeUvuejUgb(editableAnnulus, false);
				num = 10;
				if (true)
				{
					break;
				}
				goto case 12;
			case 12:
				if (cvsCell == null)
				{
					goto IL_0019;
				}
				_ = 0;
				if (mToS1Hf0GMAXoWKjguM())
				{
					num = 9;
					if (true)
					{
						break;
					}
					goto case 11;
				}
				num = 5;
				break;
			case 11:
				editableAnnulus.Visible = zELLpOdVhaMhf7GpayG(cvsCell);
				goto case 5;
			case 14:
				return;
			case 7:
				cvsCell = (CvsCell)GrdldYfMg5yhMmc2aQp(cells, editableAnnulus.CellLocation);
				num = 12;
				break;
			case 6:
				iYZrandHPr17Xcsd1pH(q5ixXZlJF03FJcqj0Xi(editableAnnulus), (float)WRVp3odUVR7KR117Byw(cvsCogAnnulus));
				goto case 11;
			default:
				num = 11;
				break;
			case 3:
				if (cvsCogAnnulus == null)
				{
					if (rWfTqFdrtEoLu9y7XbC(HZ7M0ofUiJYCx1bhW4v(cvsCell)) is CvsCogError)
					{
						num = 1;
						if (0 == 0)
						{
							break;
						}
						goto case 7;
					}
					return;
				}
				num = 0;
				break;
			case 2:
			case 9:
				if (!t9yDUddv3BFYnY0HCib(cvsCell))
				{
					cvsCogAnnulus = rWfTqFdrtEoLu9y7XbC(HZ7M0ofUiJYCx1bhW4v(cvsCell)) as CvsCogAnnulus;
					num = 3;
					break;
				}
				goto IL_0019;
			case 4:
				((CvsGraphicAnnulus)q5ixXZlJF03FJcqj0Xi(editableAnnulus)).InnerRadius = (float)wcnjkidM4hdhlssFFoo(cvsCogAnnulus);
				num = 6;
				break;
			case 15:
				return;
				IL_0019:
				cF8BJudfmkeUvuejUgb(editableAnnulus, false);
				num = 15;
				break;
				IL_0087:
				color3 = color;
				MFQmAqdgSmwW1rETdvE(editableAnnulus, color2);
				GDagGjddwuoZPkq09fO(editableAnnulus, color3);
				num = 14;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayableCircle GetCircle(CvsInSight insight, CvsCellLocation circleLocation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 11;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_013f;
		IL_001a:
		CvsDisplayableCircle cvsDisplayableCircle = default;
		UxOV4JduYxpwXXBLZ0b(cvsDisplayableCircle, true);
		num = 12;
		goto IL_013f;
		IL_013f:
		CvsCogCircle cvsCogCircle = default;
		CvsCell cvsCell = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 9:
				break;
			case 10:
				cvsDisplayableCircle.Color = Color.LimeGreen;
				num = 4;
				continue;
			case 2:
				if (cvsCogCircle != null)
				{
					num = 0;
					if (wrALr0fFmSN7jbd3RyF())
					{
					}
					continue;
				}
				goto case 12;
			case 4:
				cvsDisplayableCircle.SelectedColor = RZSF5BdcSBMbJnWEOdi();
				mToS1Hf0GMAXoWKjguM();
				if (!wrALr0fFmSN7jbd3RyF())
				{
					num = 3;
					if (mToS1Hf0GMAXoWKjguM())
					{
						continue;
					}
					goto case 3;
				}
				num = 1;
				if (wrALr0fFmSN7jbd3RyF())
				{
				}
				continue;
			case 3:
			case 8:
				cvsDisplayableCircle.EditFlags = CvsEditFlags.None;
				gsREQ4l5lmyS85lVnVP(cvsDisplayableCircle, true);
				break;
			case 11:
				cvsDisplayableCircle = null;
				num = 7;
				continue;
			case 5:
				if (cvsCell != null)
				{
					num = 6;
					continue;
				}
				goto case 12;
			case 6:
				cvsCogCircle = ((CvsCogCellResult)HZ7M0ofUiJYCx1bhW4v(cvsCell)).Value as CvsCogCircle;
				num = 2;
				continue;
			case 7:
				cvsCell = (CvsCell)GrdldYfMg5yhMmc2aQp(((CvsResultSet)nTnusclaAgfEZE5nOeT(insight)).Cells, circleLocation);
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
				cvsDisplayableCircle = new CvsDisplayableCircle(new CvsGraphicCircle(circleLocation, new PointF((float)inXsModTqVtDXjpIZ5A(cvsCogCircle), (float)K1WqXMleLgU1yQA4LiH(cvsCogCircle)), (float)AiYEJKlO14RQkfcv300(cvsCogCircle), string.Empty));
				goto case 10;
			default:
				num = 10;
				continue;
			case 12:
				return cvsDisplayableCircle;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayableCircle ConstructCircle(CvsCellLocation circleLocation, CvsCellCollection cells, string expr = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (wrALr0fFmSN7jbd3RyF() ? 4 : 13);
		CvsDisplayableCircle cvsDisplayableCircle = default;
		CvsCell cvsCell = default;
		CvsCogCircle cvsCogCircle = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				UxOV4JduYxpwXXBLZ0b(cvsDisplayableCircle, true);
				cF8BJudfmkeUvuejUgb(cvsDisplayableCircle, cvsCell.Enabled);
				HddG3olIZ2BJ9o3oNjn(cvsDisplayableCircle, expr);
				num = 7;
				continue;
			case 0:
			case 13:
				cvsDisplayableCircle = null;
				num = 10;
				if (0 == 0)
				{
					continue;
				}
				goto case 8;
			case 8:
				GDagGjddwuoZPkq09fO(cvsDisplayableCircle, RZSF5BdcSBMbJnWEOdi());
				num = 12;
				continue;
			case 4:
			case 9:
				cvsDisplayableCircle.AutoHighlight = true;
				num = 1;
				if (true)
				{
					continue;
				}
				goto case 11;
			case 11:
				if (cvsCell != null)
				{
					num = 2;
					if (!wrALr0fFmSN7jbd3RyF())
					{
						continue;
					}
					goto case 12;
				}
				goto IL_0176;
			case 12:
				GaBpZ8d1rpy1pxny7fR(cvsDisplayableCircle, CvsEditFlags.None);
				goto case 4;
			case 10:
				cvsCell = cells[circleLocation];
				num = 11;
				continue;
			case 5:
				cvsDisplayableCircle = new CvsDisplayableCircle(new CvsGraphicCircle(circleLocation, new PointF((float)inXsModTqVtDXjpIZ5A(cvsCogCircle), (float)K1WqXMleLgU1yQA4LiH(cvsCogCircle)), (float)AiYEJKlO14RQkfcv300(cvsCogCircle), string.Empty));
				num = 6;
				continue;
			case 3:
				cvsDisplayableCircle.Visible = false;
				num = 15;
				continue;
			case 6:
				MFQmAqdgSmwW1rETdvE(cvsDisplayableCircle, Color.LimeGreen);
				goto case 8;
			default:
				num = 8;
				if (true)
				{
					continue;
				}
				break;
			case 14:
				if (cvsCogCircle != null)
				{
					num = 5;
					continue;
				}
				goto IL_0176;
			case 2:
				cvsCogCircle = rWfTqFdrtEoLu9y7XbC(HZ7M0ofUiJYCx1bhW4v(cvsCell)) as CvsCogCircle;
				num = 14;
				continue;
			case 7:
			case 15:
				break;
				IL_0176:
				cvsDisplayableCircle = new CvsDisplayableCircle(new CvsGraphicCircle(circleLocation, new PointF(100f, 100f), 50f, string.Empty));
				num = 3;
				continue;
			}
			break;
		}
		return cvsDisplayableCircle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayableCircle ConstructCircle(CvsCellLocation loc, double centerX, double centerY, double radius, CvsCell imageCell = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsDisplayableCircle cvsDisplayableCircle = new CvsDisplayableCircle(new CvsGraphicCircle(loc, new PointF((float)centerX, (float)centerY), (float)radius, string.Empty));
		PGlDhIdsKN90dMD6Nsa(cvsDisplayableCircle, v09n8ddhU9fmaZGYalQ(imageCell));
		GaBpZ8d1rpy1pxny7fR(cvsDisplayableCircle, CvsEditFlags.Location | CvsEditFlags.Size);
		return cvsDisplayableCircle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayableCircle ConstructCircle(CvsCellLocation loc, CvsCellCollection cells, CvsCellLocation inputImageLocation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		CvsCogCircle cvsCogCircle = default;
		CvsDisplayableCircle cvsDisplayableCircle = default;
		CvsCell cvsCell = default;
		while (true)
		{
			object obj;
			switch (num)
			{
			case 2:
				if (cvsCogCircle != null)
				{
					goto case 6;
				}
				cvsDisplayableCircle = new CvsDisplayableCircle(new CvsGraphicCircle(loc, new PointF(100f, 100f), 50f, string.Empty));
				num = 5;
				continue;
			case 5:
				cF8BJudfmkeUvuejUgb(cvsDisplayableCircle, false);
				num = 11;
				continue;
			case 3:
				obj = null;
				goto IL_0087;
			case 8:
				cvsCell = cells[loc];
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 4:
				obj = null;
				goto IL_0087;
			default:
				num = 2;
				continue;
			case 6:
			case 10:
			{
				CvsDisplayableCircle cvsDisplayableCircle2 = new CvsDisplayableCircle(new CvsGraphicCircle(loc, new PointF((float)inXsModTqVtDXjpIZ5A(cvsCogCircle), (float)K1WqXMleLgU1yQA4LiH(cvsCogCircle)), (float)cvsCogCircle.Radius, string.Empty));
				PGlDhIdsKN90dMD6Nsa(cvsDisplayableCircle2, frodP7jwAB(cells, inputImageLocation));
				GaBpZ8d1rpy1pxny7fR(cvsDisplayableCircle2, CvsEditFlags.Location | CvsEditFlags.Size);
				cF8BJudfmkeUvuejUgb(cvsDisplayableCircle2, zELLpOdVhaMhf7GpayG(cvsCell));
				cvsDisplayableCircle = cvsDisplayableCircle2;
				num = 9;
				continue;
			}
			case 7:
				if (cvsCell != null)
				{
					CvsCogCellResult cellResult = cvsCell.CellResult;
					if (cellResult == null)
					{
						_ = 1;
						num = ((!wrALr0fFmSN7jbd3RyF()) ? 1 : 10);
						continue;
					}
					obj = KKW3IQlDOXYy7Jk2q4d(cellResult);
					goto IL_0087;
				}
				num = 3;
				continue;
			case 0:
				cvsDisplayableCircle = null;
				num = 8;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 9:
			case 11:
				break;
				IL_0087:
				cvsCogCircle = obj as CvsCogCircle;
				goto case 2;
			}
			break;
		}
		return cvsDisplayableCircle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static CvsDisplayableCircle sykdtBFM62(float P_0, float P_1, float P_2, RectangleF P_3, string P_4)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsDisplayableCircle cvsDisplayableCircle = new CvsDisplayableCircle(new CvsGraphicCircle(CvsCellLocation.Invalid, new PointF(P_0, P_1), P_2, P_4))
		{
			EditBounds = P_3
		};
		cF8BJudfmkeUvuejUgb(cvsDisplayableCircle, true);
		cvsDisplayableCircle.Color = Color.Cyan;
		cvsDisplayableCircle.SelectedColor = A7pfTGdw8wssRcYij95();
		GaBpZ8d1rpy1pxny7fR(cvsDisplayableCircle, CvsEditFlags.Location | CvsEditFlags.Size);
		gsREQ4l5lmyS85lVnVP(cvsDisplayableCircle, true);
		return cvsDisplayableCircle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayableCircle ConstructCircle(float x, float y, float radius, CvsCogRectangle cogBounds, string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RectangleF bounds = new RectangleF((float)cogBounds.X, (float)vXc9rLliyipNUFFC1tu(cogBounds), (float)pYan8IlnB8J0ajpG21s(cogBounds), (float)cogBounds.Height);
		return (CvsDisplayableCircle)IF5fU7lVQWZlE95OSE8(x, y, radius, bounds, label);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayableCircle ConstructCircle(float x, float y, float radius, RectangleF bounds, string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (CvsDisplayableCircle)J0hMbclf9I4YYc1ySbg(x, y, radius, bounds, label);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayableCircle ConstructCircleCenteredToBounds(CvsCogRectangle cogBounds, string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (CvsDisplayableCircle)tYLqQPllYwHqnF3ZfXd(new RectangleF((float)cogBounds.X, (float)vXc9rLliyipNUFFC1tu(cogBounds), (float)pYan8IlnB8J0ajpG21s(cogBounds), (float)Yeo9wZldVdRonbpxmX0(cogBounds)), label);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayableCircle ConstructCircleCenteredToBounds(RectangleF bounds, string label)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		float num = CircleCalculateScaledRadius(bounds);
		float num2 = bounds.X + bounds.Width / 2f;
		float num3 = bounds.Y + bounds.Height / 2f;
		return sykdtBFM62(num2, num3, num, bounds, label);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float CircleCalculateScaledRadius(CvsCogRectangle imageBounds, float minRadius = 30f, float maxRadius = 100f, float radiusProportion = 0.1f)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CircleCalculateScaledRadius(new RectangleF((float)jNijBLlgD48UTX2cL6J(imageBounds), (float)imageBounds.Y, (float)pYan8IlnB8J0ajpG21s(imageBounds), (float)Yeo9wZldVdRonbpxmX0(imageBounds)), minRadius, maxRadius, radiusProportion);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float CircleCalculateScaledRadius(RectangleF bounds, float minRadius = 30f, float maxRadius = 100f, float radiusProportion = 0.1f)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Min(Math.Max(bounds.Width * radiusProportion, minRadius), maxRadius);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateCircle(CvsDisplayableCircle displayableCircle, CvsCellCollection cells, bool pass)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 11;
		if (!wrALr0fFmSN7jbd3RyF())
		{
		}
		Color color3 = default;
		CvsCogCircle cvsCogCircle = default;
		CvsCell cvsCell = default;
		do
		{
			IL_00d0:
			Color color;
			Color color2;
			switch (num)
			{
			case 5:
				GDagGjddwuoZPkq09fO(displayableCircle, color3);
				num = 7;
				goto IL_00d0;
			case 3:
				color = CyrgxCdGKMH0FK5brCc();
				goto IL_0042;
			case 2:
				if (pass)
				{
					color = Color.Green;
					goto IL_0042;
				}
				num = 3;
				if (0 == 0)
				{
					goto IL_00d0;
				}
				goto case 8;
			case 8:
				ilFncJlrdJ12o3g55He(W5rvkJlsTWiOcVOSLCH(displayableCircle), (float)AiYEJKlO14RQkfcv300(cvsCogCircle));
				goto case 6;
			case 9:
				if (cvsCogCircle != null)
				{
					num = 4;
					if (0 == 0)
					{
						goto IL_00d0;
					}
					goto case 6;
				}
				cF8BJudfmkeUvuejUgb(displayableCircle, false);
				num = 12;
				goto IL_00d0;
			case 6:
			case 13:
				cF8BJudfmkeUvuejUgb(displayableCircle, zELLpOdVhaMhf7GpayG(cvsCell));
				goto case 2;
			default:
				num = 2;
				goto IL_00d0;
			case 11:
				cvsCell = (CvsCell)GrdldYfMg5yhMmc2aQp(cells, EhMOOsf2HjdGg6eye3Y(displayableCircle));
				wrALr0fFmSN7jbd3RyF();
				num = (mToS1Hf0GMAXoWKjguM() ? 10 : 13);
				goto IL_00d0;
			case 1:
			case 10:
				if (cvsCell != null)
				{
					num = 0;
					goto IL_00d0;
				}
				break;
			case 0:
				if (t9yDUddv3BFYnY0HCib(cvsCell))
				{
					break;
				}
				cvsCogCircle = ((CvsCogCellResult)HZ7M0ofUiJYCx1bhW4v(cvsCell)).Value as CvsCogCircle;
				num = 9;
				if (0 == 0)
				{
					goto IL_00d0;
				}
				goto case 4;
			case 4:
				mo0TjHlvxeUDZqoSP6C(W5rvkJlsTWiOcVOSLCH(displayableCircle), new PointF((float)inXsModTqVtDXjpIZ5A(cvsCogCircle), (float)K1WqXMleLgU1yQA4LiH(cvsCogCircle)));
				num = 8;
				if (true)
				{
					goto IL_00d0;
				}
				return;
			case 7:
				return;
			case 12:
				return;
			case 14:
				return;
				IL_0042:
				color2 = color;
				color3 = (pass ? Color.LimeGreen : tyEKhhlKEMxYZvAio7b());
				MFQmAqdgSmwW1rETdvE(displayableCircle, color2);
				num = 5;
				if (0 == 0)
				{
					goto IL_00d0;
				}
				goto case 2;
			}
			cF8BJudfmkeUvuejUgb(displayableCircle, false);
			num = 14;
		}
		while (true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayableLine ConstructLine(CvsCellLocation lineLocation, CvsCellCollection cells, string expr = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 11;
		CvsDisplayableLine cvsDisplayableLine = default;
		CvsCell cvsCell = default;
		CvsCogLine cvsCogLine = default;
		while (true)
		{
			switch (num)
			{
			case 6:
			case 9:
				gsREQ4l5lmyS85lVnVP(cvsDisplayableLine, true);
				UxOV4JduYxpwXXBLZ0b(cvsDisplayableLine, true);
				num = 1;
				continue;
			case 2:
				GDagGjddwuoZPkq09fO(cvsDisplayableLine, Color.Magenta);
				num = 12;
				if (true)
				{
					continue;
				}
				goto case 13;
			case 13:
				if (cvsCell != null)
				{
					_ = 1;
					if (!wrALr0fFmSN7jbd3RyF())
					{
						num = 8;
						continue;
					}
					num = 6;
					if (0 == 0)
					{
						continue;
					}
					goto case 4;
				}
				goto IL_0117;
			case 12:
				GaBpZ8d1rpy1pxny7fR(cvsDisplayableLine, CvsEditFlags.None);
				goto case 6;
			case 4:
				MFQmAqdgSmwW1rETdvE(cvsDisplayableLine, Color.LimeGreen);
				goto case 2;
			default:
				num = 2;
				continue;
			case 10:
				cvsDisplayableLine.Visible = false;
				num = 15;
				continue;
			case 5:
				cvsCell = (CvsCell)GrdldYfMg5yhMmc2aQp(cells, lineLocation);
				num = 13;
				continue;
			case 14:
				cvsDisplayableLine.Tag = expr;
				break;
			case 11:
				cvsDisplayableLine = null;
				num = 5;
				continue;
			case 7:
				if (cvsCogLine != null)
				{
					num = 0;
					continue;
				}
				goto IL_0117;
			case 1:
				cvsDisplayableLine.Visible = zELLpOdVhaMhf7GpayG(cvsCell);
				num = 14;
				continue;
			case 0:
				cvsDisplayableLine = new CvsDisplayableLine(new CvsGraphicLine(lineLocation, new PointF((float)yPtOjLlPfTbTSfvloJd(cvsCogLine), (float)Cdoq4XlZ3afZ6yJ2sd9(cvsCogLine)), new PointF((float)AvE1uilBnSQC7YB6HcZ(cvsCogLine), (float)cvsCogLine.Y1), string.Empty));
				num = 4;
				if (mToS1Hf0GMAXoWKjguM())
				{
					continue;
				}
				goto case 3;
			case 3:
			case 8:
				cvsCogLine = rWfTqFdrtEoLu9y7XbC(HZ7M0ofUiJYCx1bhW4v(cvsCell)) as CvsCogLine;
				num = 7;
				continue;
			case 15:
				break;
				IL_0117:
				cvsDisplayableLine = new CvsDisplayableLine(new CvsGraphicLine(lineLocation, new PointF(50f, 50f), new PointF(100f, 100f), string.Empty));
				GaBpZ8d1rpy1pxny7fR(cvsDisplayableLine, CvsEditFlags.None);
				num = 10;
				continue;
			}
			break;
		}
		return cvsDisplayableLine;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayableLine ConstructLine(CvsCellLocation loc, double startX, double startY, double endX, double endY, CvsCell imageCell = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsDisplayableLine cvsDisplayableLine = new CvsDisplayableLine(new CvsGraphicLine(loc, new PointF((float)startX, (float)startY), new PointF((float)endX, (float)endY), string.Empty));
		PGlDhIdsKN90dMD6Nsa(cvsDisplayableLine, v09n8ddhU9fmaZGYalQ(imageCell));
		GaBpZ8d1rpy1pxny7fR(cvsDisplayableLine, CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation);
		return cvsDisplayableLine;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateLine(CvsDisplayableLine displayableLine, CvsCellCollection cells, bool pass)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		CvsCell cvsCell = default;
		CvsCogLine cvsCogLine = default;
		Color color3 = default;
		while (true)
		{
			Color color;
			Color color2;
			switch (num)
			{
			case 3:
				cvsCell = cells[EhMOOsf2HjdGg6eye3Y(displayableLine)];
				_ = 1;
				if (!wrALr0fFmSN7jbd3RyF())
				{
					num = 13;
					if (wrALr0fFmSN7jbd3RyF())
					{
					}
				}
				else
				{
					num = 0;
				}
				break;
			case 8:
				yt5pJQlS4PKAKtW2PqI(WGFjBulbhNuY2u9qcFX(displayableLine), new PointF((float)AvE1uilBnSQC7YB6HcZ(cvsCogLine), (float)a4W0cTloYfks6r0DAK1(cvsCogLine)));
				goto case 10;
			default:
				num = 10;
				break;
			case 2:
				if (!t9yDUddv3BFYnY0HCib(cvsCell))
				{
					num = 11;
					if (mToS1Hf0GMAXoWKjguM())
					{
						break;
					}
					goto case 0;
				}
				goto IL_014c;
			case 0:
			case 5:
				kn9tkQlG9s5yNxm9bUx(WGFjBulbhNuY2u9qcFX(displayableLine), new PointF((float)yPtOjLlPfTbTSfvloJd(cvsCogLine), (float)Cdoq4XlZ3afZ6yJ2sd9(cvsCogLine)));
				num = 8;
				break;
			case 12:
				GDagGjddwuoZPkq09fO(displayableLine, color3);
				num = 9;
				break;
			case 9:
				return;
			case 11:
				cvsCogLine = rWfTqFdrtEoLu9y7XbC(HZ7M0ofUiJYCx1bhW4v(cvsCell)) as CvsCogLine;
				num = 6;
				break;
			case 4:
				return;
			case 6:
				if (cvsCogLine == null)
				{
					cF8BJudfmkeUvuejUgb(displayableLine, false);
					num = 4;
					if (wrALr0fFmSN7jbd3RyF())
					{
					}
					break;
				}
				goto case 0;
			case 10:
				cF8BJudfmkeUvuejUgb(displayableLine, zELLpOdVhaMhf7GpayG(cvsCell));
				if (!pass)
				{
					num = 7;
					break;
				}
				color = Color.Green;
				goto IL_019e;
			case 7:
				color = CyrgxCdGKMH0FK5brCc();
				goto IL_019e;
			case 1:
			case 13:
				if (cvsCell != null)
				{
					num = 2;
					break;
				}
				goto IL_014c;
			case 14:
				return;
				IL_019e:
				color2 = color;
				color3 = (pass ? sv7waUd2Rw8cAd7DW9K() : tyEKhhlKEMxYZvAio7b());
				MFQmAqdgSmwW1rETdvE(displayableLine, color2);
				num = 12;
				break;
				IL_014c:
				displayableLine.Visible = false;
				num = 14;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayableCross ConstructCross(CvsCellLocation fixtureLocation, CvsCellCollection cells, string expr = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		CvsCell cvsCell = default;
		CvsDisplayableCross cvsDisplayableCross = default;
		CvsCogFixture cvsCogFixture = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				cvsCell = (CvsCell)GrdldYfMg5yhMmc2aQp(cells, fixtureLocation);
				num = 12;
				break;
			case 0:
				UxOV4JduYxpwXXBLZ0b(cvsDisplayableCross, true);
				num = 6;
				break;
			case 7:
				if (cvsCogFixture != null)
				{
					num = 4;
					break;
				}
				goto IL_002f;
			case 3:
			case 10:
				cvsCogFixture = rWfTqFdrtEoLu9y7XbC(HZ7M0ofUiJYCx1bhW4v(cvsCell)) as CvsCogFixture;
				num = 7;
				break;
			case 4:
				cvsDisplayableCross = new CvsDisplayableCross(new CvsGraphicCross(fixtureLocation, new PointF((float)qfLegmlkes3Z15WUWsg(cvsCogFixture), (float)WFlb2hl8FFxwXMIVAtp(cvsCogFixture)), (float)tNXMU7lqdcMvYHgAvif(cvsCogFixture), 40f, 40f, string.Empty));
				MFQmAqdgSmwW1rETdvE(cvsDisplayableCross, Color.LimeGreen);
				GDagGjddwuoZPkq09fO(cvsDisplayableCross, RZSF5BdcSBMbJnWEOdi());
				num = 8;
				if (mToS1Hf0GMAXoWKjguM())
				{
					break;
				}
				goto case 2;
			case 2:
				cvsDisplayableCross = null;
				num = 5;
				break;
			case 11:
				GaBpZ8d1rpy1pxny7fR(cvsDisplayableCross, CvsEditFlags.None);
				num = 14;
				break;
			case 6:
				cF8BJudfmkeUvuejUgb(cvsDisplayableCross, cvsCell.Enabled);
				goto case 1;
			case 8:
				GaBpZ8d1rpy1pxny7fR(cvsDisplayableCross, CvsEditFlags.None);
				cvsDisplayableCross.AutoHighlight = true;
				goto case 0;
			default:
				num = 0;
				break;
			case 1:
			case 9:
				HddG3olIZ2BJ9o3oNjn(cvsDisplayableCross, expr);
				num = 13;
				break;
			case 14:
				cvsDisplayableCross.Visible = false;
				num = 15;
				break;
			case 12:
				if (cvsCell != null)
				{
					wrALr0fFmSN7jbd3RyF();
					num = ((!mToS1Hf0GMAXoWKjguM()) ? 1 : 10);
					break;
				}
				goto IL_002f;
			case 13:
			case 15:
				{
					return cvsDisplayableCross;
				}
				IL_002f:
				cvsDisplayableCross = new CvsDisplayableCross(new CvsGraphicCross(fixtureLocation, new PointF(50f, 50f), 0f, 50f, 50f, string.Empty));
				num = 11;
				if (0 == 0)
				{
					break;
				}
				goto case 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayableCross GetCross(CvsInSight insight, CvsCellLocation crossLocation, double x, double y, double angle, string expr)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsDisplayableCross cvsDisplayableCross = new CvsDisplayableCross(new CvsGraphicCross(crossLocation, new PointF((float)x, (float)y), (float)angle, 40f, 40f, string.Empty));
		MFQmAqdgSmwW1rETdvE(cvsDisplayableCross, sv7waUd2Rw8cAd7DW9K());
		GDagGjddwuoZPkq09fO(cvsDisplayableCross, RZSF5BdcSBMbJnWEOdi());
		GaBpZ8d1rpy1pxny7fR(cvsDisplayableCross, CvsEditFlags.None);
		gsREQ4l5lmyS85lVnVP(cvsDisplayableCross, true);
		UxOV4JduYxpwXXBLZ0b(cvsDisplayableCross, true);
		cvsDisplayableCross.Tag = expr;
		return cvsDisplayableCross;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayablePoint GetPoint(CvsInSight insight, CvsCellLocation pointLocation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		CvsCogPoint cvsCogPoint = default;
		CvsDisplayablePoint cvsDisplayablePoint = default;
		CvsCell cvsCell = default;
		while (true)
		{
			switch (num)
			{
			case 10:
				if (cvsCogPoint != null)
				{
					num = 3;
					continue;
				}
				break;
			default:
				MFQmAqdgSmwW1rETdvE(cvsDisplayablePoint, sv7waUd2Rw8cAd7DW9K());
				num = 0;
				continue;
			case 11:
				UxOV4JduYxpwXXBLZ0b(cvsDisplayablePoint, true);
				num = 12;
				if (mToS1Hf0GMAXoWKjguM())
				{
					continue;
				}
				goto case 0;
			case 0:
				GDagGjddwuoZPkq09fO(cvsDisplayablePoint, Color.Magenta);
				num = 2;
				continue;
			case 7:
				cvsCogPoint = ((CvsCogCellResult)HZ7M0ofUiJYCx1bhW4v(cvsCell)).Value as CvsCogPoint;
				num = 10;
				continue;
			case 3:
				cvsDisplayablePoint = new CvsDisplayablePoint(new CvsGraphicPoint(pointLocation, new PointF((float)p8Q24RlEWhup8VKD8m1(cvsCogPoint), (float)cvsCogPoint.Y), string.Empty));
				goto default;
			case 1:
			case 4:
				cvsCell = (CvsCell)GrdldYfMg5yhMmc2aQp(insight.Results.Cells, pointLocation);
				num = 9;
				continue;
			case 2:
				GaBpZ8d1rpy1pxny7fR(cvsDisplayablePoint, CvsEditFlags.None);
				gsREQ4l5lmyS85lVnVP(cvsDisplayablePoint, true);
				num = 11;
				if (true)
				{
					continue;
				}
				goto case 9;
			case 9:
				if (cvsCell != null)
				{
					num = 7;
					continue;
				}
				break;
			case 8:
				cvsDisplayablePoint = null;
				_ = 0;
				if (!mToS1Hf0GMAXoWKjguM())
				{
					num = 5;
					continue;
				}
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 12:
				break;
			}
			break;
		}
		return cvsDisplayablePoint;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayablePoint ConstructPoint(CvsCellLocation loc, CvsCellCollection cells, CvsCellLocation inputImageLocation)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		CvsCogPoint cvsCogPoint = default;
		CvsCell cvsCell = default;
		CvsDisplayablePoint cvsDisplayablePoint = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 5:
			{
				CvsDisplayablePoint cvsDisplayablePoint2 = new CvsDisplayablePoint(new CvsGraphicPoint(loc, new PointF((float)p8Q24RlEWhup8VKD8m1(cvsCogPoint), (float)F6CsbSlpy1RFhNLRA3X(cvsCogPoint)), string.Empty))
				{
					EditBounds = AB6ZdCdnFUbSYyKM8Bg(cells, inputImageLocation)
				};
				GaBpZ8d1rpy1pxny7fR(cvsDisplayablePoint2, CvsEditFlags.Location);
				cF8BJudfmkeUvuejUgb(cvsDisplayablePoint2, zELLpOdVhaMhf7GpayG(cvsCell));
				cvsDisplayablePoint = cvsDisplayablePoint2;
				break;
			}
			case 9:
				if (cvsCell != null)
				{
					num = 3;
					continue;
				}
				goto IL_00c3;
			case 1:
				cF8BJudfmkeUvuejUgb(cvsDisplayablePoint, false);
				num = 10;
				if (!wrALr0fFmSN7jbd3RyF())
				{
					continue;
				}
				goto case 3;
			case 3:
				cvsCogPoint = rWfTqFdrtEoLu9y7XbC(cvsCell.CellResult) as CvsCogPoint;
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 2;
			case 2:
				cvsDisplayablePoint = null;
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 4:
				if (cvsCogPoint == null)
				{
					goto IL_00c3;
				}
				goto default;
			default:
				wrALr0fFmSN7jbd3RyF();
				num = ((!mToS1Hf0GMAXoWKjguM()) ? 8 : 0);
				continue;
			case 7:
				cvsCell = cells[loc];
				num = 9;
				continue;
			case 6:
			case 8:
			case 10:
				break;
				IL_00c3:
				cvsDisplayablePoint = ConstructPoint(loc, 100.0, 100.0, (CvsCell)GrdldYfMg5yhMmc2aQp(cells, inputImageLocation));
				num = 1;
				if (0 == 0)
				{
					continue;
				}
				goto case 4;
			}
			break;
		}
		return cvsDisplayablePoint;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayablePoint ConstructPoint(CvsCellLocation loc, double x, double y, CvsCell imageCell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsDisplayablePoint cvsDisplayablePoint = new CvsDisplayablePoint(new CvsGraphicPoint(loc, new PointF((float)x, (float)y), string.Empty));
		PGlDhIdsKN90dMD6Nsa(cvsDisplayablePoint, BcI6NOfYsZaLsoS4sHp(imageCell));
		GaBpZ8d1rpy1pxny7fR(cvsDisplayablePoint, CvsEditFlags.Location | CvsEditFlags.Size | CvsEditFlags.Rotation);
		return cvsDisplayablePoint;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsDisplayablePoint ConstructPoint(CvsCellLocation pointLocation, CvsCellCollection cells, string expr = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 13;
		CvsDisplayablePoint cvsDisplayablePoint = default;
		CvsCell cvsCell = default;
		CvsCogPoint cvsCogPoint = default;
		while (true)
		{
			switch (num)
			{
			case 10:
			case 11:
				HddG3olIZ2BJ9o3oNjn(cvsDisplayablePoint, expr);
				num = 1;
				break;
			case 5:
				UxOV4JduYxpwXXBLZ0b(cvsDisplayablePoint, true);
				cF8BJudfmkeUvuejUgb(cvsDisplayablePoint, zELLpOdVhaMhf7GpayG(cvsCell));
				goto case 10;
			case 3:
			case 7:
				cvsCogPoint = rWfTqFdrtEoLu9y7XbC(cvsCell.CellResult) as CvsCogPoint;
				num = 12;
				break;
			case 9:
				cvsCell = (CvsCell)GrdldYfMg5yhMmc2aQp(cells, pointLocation);
				num = 14;
				break;
			case 12:
				if (cvsCogPoint != null)
				{
					num = 0;
					break;
				}
				goto IL_00ab;
			case 13:
				cvsDisplayablePoint = null;
				num = 9;
				break;
			case 2:
				gsREQ4l5lmyS85lVnVP(cvsDisplayablePoint, true);
				num = 5;
				break;
			case 8:
				GaBpZ8d1rpy1pxny7fR(cvsDisplayablePoint, CvsEditFlags.None);
				num = 2;
				break;
			case 0:
				cvsDisplayablePoint = new CvsDisplayablePoint(new CvsGraphicPoint(pointLocation, new PointF((float)cvsCogPoint.X, (float)cvsCogPoint.Y), string.Empty));
				num = 4;
				break;
			case 14:
				if (cvsCell == null)
				{
					goto IL_00ab;
				}
				mToS1Hf0GMAXoWKjguM();
				if (wrALr0fFmSN7jbd3RyF())
				{
					num = 11;
					break;
				}
				num = 7;
				if (mToS1Hf0GMAXoWKjguM())
				{
					break;
				}
				goto case 6;
			case 6:
				GaBpZ8d1rpy1pxny7fR(cvsDisplayablePoint, CvsEditFlags.None);
				cvsDisplayablePoint.Visible = false;
				num = 15;
				break;
			case 4:
				cvsDisplayablePoint.Color = sv7waUd2Rw8cAd7DW9K();
				GDagGjddwuoZPkq09fO(cvsDisplayablePoint, RZSF5BdcSBMbJnWEOdi());
				goto case 8;
			default:
				num = 8;
				break;
			case 1:
			case 15:
				{
					return cvsDisplayablePoint;
				}
				IL_00ab:
				cvsDisplayablePoint = new CvsDisplayablePoint(new CvsGraphicPoint(pointLocation, new PointF(50f, 50f), string.Empty));
				num = 6;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdatePoint(CvsDisplayablePoint displayablePoint, CvsCellCollection cells, bool pass, string label = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		wrALr0fFmSN7jbd3RyF();
		int num = ((!mToS1Hf0GMAXoWKjguM()) ? 6 : 3);
		CvsCell cvsCell = default;
		Color color2 = default;
		CvsCogPoint cvsCogPoint = default;
		Color color4 = default;
		while (true)
		{
			Color color;
			Color color3;
			switch (num)
			{
			case 10:
				return;
			case 6:
			case 8:
				cF8BJudfmkeUvuejUgb(displayablePoint, zELLpOdVhaMhf7GpayG(cvsCell));
				if (!pass)
				{
					num = 7;
					break;
				}
				color = B95yx3dlbtWUhZ72Fh4();
				goto IL_0170;
			case 5:
				if (cvsCell != null)
				{
					num = 2;
					break;
				}
				goto IL_0031;
			case 9:
				GDagGjddwuoZPkq09fO(displayablePoint, color2);
				num = 10;
				if (0 == 0)
				{
					break;
				}
				goto case 12;
			case 12:
				cvsCogPoint = cvsCell.CellResult.Value as CvsCogPoint;
				num = 13;
				if (mToS1Hf0GMAXoWKjguM())
				{
					break;
				}
				goto case 4;
			case 4:
				if (label == null)
				{
					goto case 6;
				}
				goto case 14;
			default:
				num = 14;
				break;
			case 2:
				if (!t9yDUddv3BFYnY0HCib(cvsCell))
				{
					num = 12;
					break;
				}
				goto IL_0031;
			case 13:
				if (cvsCogPoint == null)
				{
					cF8BJudfmkeUvuejUgb(displayablePoint, false);
					return;
				}
				num = 11;
				break;
			case 0:
			case 3:
				cvsCell = (CvsCell)GrdldYfMg5yhMmc2aQp(cells, displayablePoint.CellLocation);
				num = 5;
				break;
			case 14:
				displayablePoint.PointGraphic.Label = label;
				goto case 6;
			case 7:
				color = CyrgxCdGKMH0FK5brCc();
				goto IL_0170;
			case 1:
				color3 = tyEKhhlKEMxYZvAio7b();
				goto IL_0192;
			case 11:
				CWET4ZlX92pgi6K53sA(displayablePoint.PointGraphic, new PointF((float)cvsCogPoint.X, (float)F6CsbSlpy1RFhNLRA3X(cvsCogPoint)));
				num = 4;
				if (!mToS1Hf0GMAXoWKjguM())
				{
					return;
				}
				break;
			case 15:
				return;
				IL_0192:
				color2 = color3;
				MFQmAqdgSmwW1rETdvE(displayablePoint, color4);
				num = 9;
				break;
				IL_0170:
				color4 = color;
				if (!pass)
				{
					num = 1;
					if (true)
					{
						break;
					}
					goto case 1;
				}
				color3 = sv7waUd2Rw8cAd7DW9K();
				goto IL_0192;
				IL_0031:
				cF8BJudfmkeUvuejUgb(displayablePoint, false);
				num = 15;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSendGraphicAsync_003Ed__56))]
	public static Task SendGraphicAsync(CvsInSight insight, CvsEditableDisplayGraphic editableGraphic)
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
		goto IL_0048;
		IL_001a:
		_003CSendGraphicAsync_003Ed__56 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		num = 1;
		if (1 == 0)
		{
			goto IL_002e;
		}
		goto IL_0048;
		IL_002e:
		stateMachine.editableGraphic = editableGraphic;
		goto IL_001a;
		IL_0048:
		while (true)
		{
			switch (num)
			{
			case 2:
			case 4:
				goto IL_002e;
			case 6:
				stateMachine._003C_003Et__builder = Xm1Vl0l9Dwy3DdeGw5f();
				num = 0;
				continue;
			case 0:
				stateMachine.insight = insight;
				_ = 1;
				if (wrALr0fFmSN7jbd3RyF())
				{
					num = 5;
					if (true)
					{
						continue;
					}
					goto case 6;
				}
				num = 4;
				continue;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (!wrALr0fFmSN7jbd3RyF())
				{
					continue;
				}
				goto case 7;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSendGraphicAsync_003Ed__57))]
	public static Task SendGraphicAsync(CvsInSight insight, CvsCellLocation loc, CvsEditableDisplayGraphic editableGraphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!mToS1Hf0GMAXoWKjguM()) ? 3 : 5);
		_003CSendGraphicAsync_003Ed__57 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				stateMachine.insight = insight;
				num = 7;
				break;
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (!wrALr0fFmSN7jbd3RyF())
				{
					break;
				}
				goto case 4;
			case 4:
				stateMachine.editableGraphic = editableGraphic;
				goto case 2;
			default:
				num = 2;
				break;
			case 7:
				stateMachine.loc = loc;
				num = 4;
				if (wrALr0fFmSN7jbd3RyF())
				{
				}
				break;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = Xm1Vl0l9Dwy3DdeGw5f();
				goto case 1;
			case 2:
				stateMachine._003C_003E1__state = -1;
				num = 6;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ClipToBounds(CvsEditableDisplayGraphic editableGraphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		RectangleF rectangleF2 = default;
		float num3 = default;
		RectangleF rectangleF = default;
		float num2 = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				rectangleF2 = LPdtIvfNEiSeaa8urRg(editableGraphic);
				num = 7;
				break;
			default:
				num3 = rectangleF.Top - rectangleF2.Top;
				num = 0;
				if (0 == 0)
				{
					break;
				}
				goto case 4;
			case 4:
				editableGraphic.Adjust(CvsEditFlags.Location, (int)num2, (int)num3);
				num = 13;
				if (mToS1Hf0GMAXoWKjguM())
				{
					break;
				}
				goto case 2;
			case 2:
			case 12:
				num2 = rectangleF.Left - rectangleF2.Left;
				num = 3;
				break;
			case 5:
				num2 = 0f;
				goto default;
			case 0:
				if (num3 < 0f)
				{
					num3 = rectangleF.Bottom - rectangleF2.Bottom;
					num = 10;
					break;
				}
				goto case 4;
			case 7:
				rectangleF = RO1vAll4ha1XbZTSD28(editableGraphic);
				wrALr0fFmSN7jbd3RyF();
				if (!mToS1Hf0GMAXoWKjguM())
				{
					num = 9;
					if (true)
					{
						break;
					}
					goto case 0;
				}
				num = 12;
				break;
			case 8:
				num3 = 0f;
				num = 4;
				break;
			case 10:
				if (num3 > 0f)
				{
					num = 8;
					break;
				}
				goto case 4;
			case 11:
				if (num2 > 0f)
				{
					num = 5;
					break;
				}
				goto default;
			case 3:
				if (num2 < 0f)
				{
					num2 = rectangleF.Right - rectangleF2.Right;
					num = 11;
					break;
				}
				goto default;
			case 13:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EditableGraphicHelper()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VyOY5ql7nIrXqTJUgui();
		WPVYjel3dTr07oYAbZ1(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static EditableGraphicHelper()
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
			case 4:
				mmwdJlBGf9 = new string[3]
				{
					Resources.WOt9ElpTUI(),
					(string)cWPBlal6GO8sL9AQMJw(),
					(string)iZl5b0lCZ2gdfm41Pv0()
				};
				num = 6;
				break;
			case 0:
				VyOY5ql7nIrXqTJUgui();
				mToS1Hf0GMAXoWKjguM();
				num = (wrALr0fFmSN7jbd3RyF() ? 5 : 3);
				break;
			case 1:
			case 3:
				O3OdVyxQGL = new Lazy<ILogger>([MethodImpl(MethodImplOptions.NoInlining)] () =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return LogManager.GetLogger(typeof(EditableGraphicHelper));
				});
				goto case 2;
			case 2:
			case 5:
				zNNdLluDIu = new string[4]
				{
					(string)g8FXNlljj5K1bA2gj0w(),
					(string)cWPBlal6GO8sL9AQMJw(),
					(string)iZl5b0lCZ2gdfm41Pv0(),
					(string)EXOuk2lAqDjyDNjiUIQ()
				};
				goto case 4;
			default:
				num = 4;
				if (!mToS1Hf0GMAXoWKjguM())
				{
					return;
				}
				break;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GrdldYfMg5yhMmc2aQp(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RectangleF BcI6NOfYsZaLsoS4sHp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Y8CdsuxLoo((CvsCell)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool mToS1Hf0GMAXoWKjguM()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wrALr0fFmSN7jbd3RyF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HZ7M0ofUiJYCx1bhW4v(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).CellResult;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Eh8AYCfHojMq3lLFOqQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImage)P_0).OffsetX;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int BKEKMxfxhn8MGTMhjXn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImage)P_0).OffsetY;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int l4eWbCfm11rGpMcHPLC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImage)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Jrqh2xfQcKBDWwy8hIc(object P_0, RectangleF P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ICvsEditableDisplayGraphic)P_0).EditBounds = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RectangleF LPdtIvfNEiSeaa8urRg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).BoundingBox;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation EhMOOsf2HjdGg6eye3Y(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qQNBEPfcPAk1CWH6VqW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsDisplayableComposite)P_0).CompositeRegion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object pmsXiWf10BIfs31LIGX(object P_0, int P_1, object P_2, CvsCompositeOperation P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicCompositeBase)P_0).InsertRegion(P_1, (CvsGraphicRegion)P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float RWFFLefuh4Ld3yZF9V4(float P_0, float P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Min(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EIsG98fhOrEMraHv1Nf(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogEditingShape)P_0).Shape = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XbcrvcftGCEZ28J0wLi(object P_0, int P_1, object P_2, CvsCompositeOperation P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicCompositeBase)P_0).InsertCircle(P_1, (CvsGraphicCircle)P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GRqWLcfzSWe3yJvUByR(object P_0, int P_1, object P_2, CvsCompositeOperation P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicCompositeBase)P_0).InsertAnnulus(P_1, (CvsGraphicAnnulus)P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pnixAFdLdynlIuIcrt7(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogEditingShape)P_0).Bounds = (CvsCogRectangle)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KIMfgTdKKwVW1sJ51qB(object P_0, int P_1, object P_2, CvsCompositeOperation P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicCompositeBase)P_0).InsertPolygon(P_1, (CvsGraphicPolygon)P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hXUuqdd5tmlsIQw2wtM(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicCompositeBase)P_0).DeleteSubregionByIndex(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color A7pfTGdw8wssRcYij95()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.Cyan;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WUxrpGdJppVuST9I41D(object P_0, Color P_1, Color P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		dahdGvXUmN((CvsDisplayableComposite)P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void C3R30qdakO6g5yGv6bq(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogCompositeRegion)P_0).SubRegions = (CvsCogSubRegion[])P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void M3uQsNdeboXVCUtpd8d(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogEditingCompositeRegion)P_0).Move = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Mf8uahdOVGKq80K4XvH(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogEditingCompositeRegion)P_0).Rotate = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WOc2dIdIDf8M6nDV4n3(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogEditingCompositeRegion)P_0).AddRegions = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eq5lZhdDn9JKi38ZMn9(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogEditingCompositeRegion)P_0).RemoveRegions = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OPScbndir4RbxHMdITY(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCogEditingCompositeRegion)P_0).EditRegions = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RectangleF AB6ZdCdnFUbSYyKM8Bg(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return frodP7jwAB((CvsCellCollection)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zELLpOdVhaMhf7GpayG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Enabled;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cF8BJudfmkeUvuejUgb(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsDisplayableGraphic)P_0).Visible = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GDagGjddwuoZPkq09fO(object P_0, Color P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsDisplayableGraphic)P_0).SelectedColor = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color B95yx3dlbtWUhZ72Fh4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.Green;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MFQmAqdgSmwW1rETdvE(object P_0, Color P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsDisplayableGraphic)P_0).Color = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PGlDhIdsKN90dMD6Nsa(object P_0, RectangleF P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsEditableDisplayGraphic)P_0).EditBounds = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool t9yDUddv3BFYnY0HCib(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Error;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rWfTqFdrtEoLu9y7XbC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qUtscgdPDxprTgamgql(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCompositeRegion)P_0).SubRegions;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UAYIwVdZ3hj6vgvEwC2(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QEqdBh4Zei((CvsGraphicCompositeBase)P_0, (CvsCogSubRegion[])P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object K8prO9dBnkFAuCEWnkh(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).InSightGraphic;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uoVUtKdbGiDSRZWLicu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogShape)P_0).Label;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color CyrgxCdGKMH0FK5brCc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.Red;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object a7VVcndoRkKN6ZyPDPO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).Children;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CfYv8jdSCpxwMvm859j(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSubRegion)P_0).Shape;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCompositeShapeType Oil9acdkORZLf0WpY1K(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCompositeSubregion)P_0).ShapeType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RHlT9Ld89y9tDUZO5L9(int P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return zhUdZHbQBc(P_0, (CvsGraphicCompositeBase)P_1, (CvsCogSubRegion)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yNk9ghdqandMdNIcgMg(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QybdnssorF((CvsCompositeSubregion)P_0, (CvsCogSubRegion)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object z9raIldEjHGJClpguIK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsGraphicCompositeBase)P_0).Subregions;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool FYDvY1dp925WVB11uJP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSubRegion)P_0).Add;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KFFW2ddXPbKba134sOG(object P_0, CvsCompositeOperation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsCompositeSubregion)P_0).Operation = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double dwyoyGd9bQQkWjSegsB(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BXd6Kdd4msLpXXw0ffP(object P_0, PointF P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicRegion)P_0).Location = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double kTd4LZd7GcfJkjWEcIs(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).Width;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Y5tqIpd3Ms4X5vOiUb4(object P_0, double P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicRegion)P_0).Width = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double ju9lvudjVIsCqdG7Bx2(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cMXsHVd6bfPIjomIIEk(object P_0, double P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicRegion)P_0).Height = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double Vlvh3YdC2dNYPjLExcf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).Angle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RWMd1ydAoKD3hvwrG5o(object P_0, double P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicRegion)P_0).Angle = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void byeU79dRchxnySruxNT(object P_0, double P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicRegion)P_0).Curve = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tomBTrdWBZDh9G0hDsi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCompositeSubregion)P_0).InSightGraphic;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double inXsModTqVtDXjpIZ5A(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCircle)P_0).X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double YfYHTbdylFpTM7dZu0c(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogAnnulus)P_0).X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double dYK6iyd0h06q7Hu9IVQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogAnnulus)P_0).Y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fRi7YTdFGLZrusV1UTO(object P_0, PointF P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicAnnulus)P_0).Center = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double wcnjkidM4hdhlssFFoo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogAnnulus)P_0).InnerRadius;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zHpLFXdYRJi2sFr8LlC(object P_0, float P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicAnnulus)P_0).InnerRadius = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double WRVp3odUVR7KR117Byw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogAnnulus)P_0).OuterRadius;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iYZrandHPr17Xcsd1pH(object P_0, float P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicAnnulus)P_0).OuterRadius = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NsUVM8dx3mrOY66unh3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogPolygon)P_0).Points;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dgSpVQdmj1T6JvilQlm(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicPolygon)P_0).Points = (PointF[])P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double sxr6djdQqwO3u1RE47f(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).Y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double M6ORltdNjG0iteLMZv0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRegion)P_0).Curve;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color sv7waUd2Rw8cAd7DW9K()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.LimeGreen;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color RZSF5BdcSBMbJnWEOdi()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.Magenta;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GaBpZ8d1rpy1pxny7fR(object P_0, CvsEditFlags P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsEditableDisplayGraphic)P_0).EditFlags = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UxOV4JduYxpwXXBLZ0b(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsEditableDisplayGraphic)P_0).Selectable = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RectangleF v09n8ddhU9fmaZGYalQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return H6gdKNEWcM((CvsCell)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double uukcUudtdcHjAbKrUcV(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Ceiling(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double QE78PJdz5RmnlLiRt0O(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Floor(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FAZTBElLvo8uT8RMV6r(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsDisplayableRegion)P_0).Region;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color tyEKhhlKEMxYZvAio7b()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Color.OrangeRed;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gsREQ4l5lmyS85lVnVP(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsEditableDisplayGraphic)P_0).AutoHighlight = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wB0qFhlw1iaTrTkoDG1(CvsCellLocation loc, double x, double y, double inner, double outer, object P_5)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ConstructAnnulus(loc, x, y, inner, outer, (CvsCell)P_5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object q5ixXZlJF03FJcqj0Xi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsDisplayableAnnulus)P_0).Annulus;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nTnusclaAgfEZE5nOeT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Results;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double K1WqXMleLgU1yQA4LiH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCircle)P_0).Y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double AiYEJKlO14RQkfcv300(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCircle)P_0).Radius;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HddG3olIZ2BJ9o3oNjn(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsDisplayableGraphic)P_0).Tag = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KKW3IQlDOXYy7Jk2q4d(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double vXc9rLliyipNUFFC1tu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRectangle)P_0).Y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double pYan8IlnB8J0ajpG21s(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRectangle)P_0).Width;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IF5fU7lVQWZlE95OSE8(float x, float y, float radius, RectangleF bounds, object P_4)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ConstructCircle(x, y, radius, bounds, (string)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object J0hMbclf9I4YYc1ySbg(float P_0, float P_1, float P_2, RectangleF P_3, object P_4)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return sykdtBFM62(P_0, P_1, P_2, P_3, (string)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double Yeo9wZldVdRonbpxmX0(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRectangle)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tYLqQPllYwHqnF3ZfXd(RectangleF bounds, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ConstructCircleCenteredToBounds(bounds, (string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double jNijBLlgD48UTX2cL6J(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogRectangle)P_0).X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object W5rvkJlsTWiOcVOSLCH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsDisplayableCircle)P_0).CircleGraphic;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mo0TjHlvxeUDZqoSP6C(object P_0, PointF P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicCircle)P_0).Center = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ilFncJlrdJ12o3g55He(object P_0, float P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicCircle)P_0).Radius = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double yPtOjLlPfTbTSfvloJd(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogLine)P_0).X0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double Cdoq4XlZ3afZ6yJ2sd9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogLine)P_0).Y0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double AvE1uilBnSQC7YB6HcZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogLine)P_0).X1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WGFjBulbhNuY2u9qcFX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsDisplayableLine)P_0).Line;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kn9tkQlG9s5yNxm9bUx(object P_0, PointF P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicLine)P_0).StartPoint = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double a4W0cTloYfks6r0DAK1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogLine)P_0).Y1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yt5pJQlS4PKAKtW2PqI(object P_0, PointF P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicLine)P_0).EndPoint = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double qfLegmlkes3Z15WUWsg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogFixture)P_0).X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double WFlb2hl8FFxwXMIVAtp(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogFixture)P_0).Y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double tNXMU7lqdcMvYHgAvif(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogFixture)P_0).Angle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double p8Q24RlEWhup8VKD8m1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogPoint)P_0).X;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double F6CsbSlpy1RFhNLRA3X(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogPoint)P_0).Y;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CWET4ZlX92pgi6K53sA(object P_0, PointF P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicPoint)P_0).Location = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder Xm1Vl0l9Dwy3DdeGw5f()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RectangleF RO1vAll4ha1XbZTSD28(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).EditBounds;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VyOY5ql7nIrXqTJUgui()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WPVYjel3dTr07oYAbZ1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object g8FXNlljj5K1bA2gj0w()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.WOt9ElpTUI();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cWPBlal6GO8sL9AQMJw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Circle;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object iZl5b0lCZ2gdfm41Pv0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Annulus;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EXOuk2lAqDjyDNjiUIQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.y6RJqWiBlx();
	}
}
