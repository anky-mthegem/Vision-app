using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Designer.Utils.Operations;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Help;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.Group;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.MathLogic;
using Cognex.InSight.Internal;
using Cognex.InSight.Runtime.Extensions;
using Cognex.InSight.Runtime.ViewModels;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.Mvvm;
using DUIE9v8SVGR17TWQwQ;
using e0SWISkZIyw0sYl1Ml;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools;

public abstract class EzTool : EzSnippet, IPassFailCounters
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CParse_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzTool _003C_003E4__this;

		public CvsCellCollection cells;

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
			if (HbTp9SKoARoFoZNDFyow())
			{
				num = 2;
				if (!HbTp9SKoARoFoZNDFyow())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 3;
			}
			goto IL_10fe;
			IL_002a:
			EzTool ezTool = _003C_003E4__this;
			num = 4;
			goto IL_10fe;
			IL_10fe:
			uint num4 = default;
			string text = default;
			CvsCell cvsCell = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					break;
				case 4:
					try
					{
						TaskAwaiter awaiter;
						IEnumerator<CellViewModel> enumerator;
						if (num2 != 0)
						{
							enumerator = ezTool.Properties.GetEnumerator();
							try
							{
								while (ocyVbgKoWpM9ny1qDxoj(enumerator))
								{
									enumerator.Current.SourcePropertyChanged -= ezTool.EeldmQvMJb;
								}
							}
							finally
							{
								if (num2 < 0 && enumerator != null)
								{
									nGR5ICKoTReXSOg21XoI(enumerator);
								}
							}
							ezTool.RemoveAllProperties();
							ezTool.InputImage = null;
							ezTool.InputFixture = null;
							ezTool.InputCompositeRegion = null;
							ezTool.InputRegion = null;
							ezTool.InputAnnulus = null;
							ezTool.InputPlane = null;
							bqtDQLKoyg5lf0ojI3pl(ezTool);
							IEnumerator<CvsCellLocation> enumerator2 = ezTool.CellRange.GetEnumerator();
							try
							{
								while (ocyVbgKoWpM9ny1qDxoj(enumerator2))
								{
									CvsCellLocation current = enumerator2.Current;
									int num3 = 61;
									while (true)
									{
										object obj;
										switch (num3)
										{
										case 44:
										{
											if (num4 != 1684897913)
											{
												num3 = 17;
												if (true)
												{
													continue;
												}
												break;
											}
											if (!YUSBk5KoH6C8QfZFs1Ex(text, UgHSljKoMB5NifWA04Zr(24964)))
											{
												goto case 0;
											}
											EzTool ezTool6 = ezTool;
											InternalCheckBoxViewModel internalCheckBoxViewModel = new InternalCheckBoxViewModel(ezTool.InSight, cells, current, (string)uJ6uskKSISDgEKAAJdip());
											Twf9cRKo2fw8P1IrEu6g(internalCheckBoxViewModel, true);
											ezTool6.ShowImage = internalCheckBoxViewModel;
											num3 = 20;
											if (HbTp9SKoARoFoZNDFyow())
											{
												continue;
											}
											break;
										}
										case 60:
											obj = null;
											goto IL_015f;
										case 38:
											ezTool.AddProperty(ezTool.ErrorCount);
											num3 = 64;
											continue;
										case 23:
											ezTool.AddProperty(ezTool.InputImage);
											num3 = 1;
											continue;
										case 32:
											ezTool.AddProperty(ezTool.Focus);
											break;
										case 69:
										{
											if (num4 != 417825335)
											{
												num3 = 52;
												continue;
											}
											if (!YUSBk5KoH6C8QfZFs1Ex(text, UgHSljKoMB5NifWA04Zr(3256)))
											{
												num3 = 49;
												continue;
											}
											EzTool ezTool5 = ezTool;
											EditIntViewModel editIntViewModel = new EditIntViewModel(ezTool.InSight, cells, current, (string)BtRQ6kKSD02Jb28lX6Qo());
											Twf9cRKo2fw8P1IrEu6g(editIntViewModel, true);
											ezTool5.Order = editIntViewModel;
											ezTool.AddProperty(ezTool.Order);
											break;
										}
										case 65:
											ezTool.AddProperty(ezTool.ShowResults);
											break;
										case 66:
											ezTool.AddProperty(ezTool.ShowGraphics);
											num3 = 4;
											if (0 == 0)
											{
												continue;
											}
											goto case 59;
										case 59:
											if (num4 != 266367750)
											{
												num3 = 69;
												if (true)
												{
													continue;
												}
											}
											else
											{
												if (!YUSBk5KoH6C8QfZFs1Ex(text, UgHSljKoMB5NifWA04Zr(1188)))
												{
													num3 = 74;
													continue;
												}
												ezTool.SnippetName = new SnippetNameViewModel(ezTool.Parent, cells, current, (string)FeAyF4KoxUuNyvJaA4sl());
												num3 = 39;
												if (!hgnJccKoRUyos36j3JNO())
												{
													continue;
												}
											}
											goto case 0;
										case 25:
											if (num4 != 2626085950u)
											{
												num3 = 29;
												continue;
											}
											if (YUSBk5KoH6C8QfZFs1Ex(text, UgHSljKoMB5NifWA04Zr(20568)))
											{
												ezTool.Enabled = new ListBoxViewModel(ezTool.InSight, cells, current, (string)LBEJXGKouYAOjOpPaBm7());
												ezTool.AddProperty(ezTool.Enabled);
												num3 = 58;
												continue;
											}
											goto case 0;
										case 8:
											if (num4 != 4260616252u)
											{
												num3 = 26;
												if (true)
												{
													continue;
												}
												goto case 34;
											}
											if (!YUSBk5KoH6C8QfZFs1Ex(text, UgHSljKoMB5NifWA04Zr(43430)))
											{
												num3 = 30;
												continue;
											}
											ezTool.TotalCount = new IntViewModel(ezTool.InSight, cells, current, (string)Tg5700KSKKjmNg534bnb());
											ezTool.AddProperty(ezTool.TotalCount);
											num3 = 43;
											continue;
										case 34:
											ezTool.AddProperty(ezTool.ExecutionTime);
											break;
										case 12:
											ezTool.AddProperty(ezTool.Description);
											num3 = 18;
											continue;
										case 51:
											ezTool.AddProperty(ezTool.InputFixture);
											num3 = 31;
											continue;
										case 68:
											if (num4 > 2527199700u)
											{
												if (num4 != 2575194062u)
												{
													num3 = 25;
													continue;
												}
												if (YUSBk5KoH6C8QfZFs1Ex(text, CdQUGaROfy7He9T0foW.KbIzwHEDLa(36102)))
												{
													EzTool ezTool7 = ezTool;
													InternalCheckBoxViewModel internalCheckBoxViewModel2 = new InternalCheckBoxViewModel(ezTool.InSight, cells, current, (string)SoJeYLKSit5ooW2D6OfC());
													Twf9cRKo2fw8P1IrEu6g(internalCheckBoxViewModel2, true);
													ezTool7.EnableInputGraphic = internalCheckBoxViewModel2;
													ezTool.AddProperty(ezTool.EnableInputGraphic);
													break;
												}
											}
											else if (num4 == 2054013062)
											{
												if (YUSBk5KoH6C8QfZFs1Ex(text, UgHSljKoMB5NifWA04Zr(24930)))
												{
													ezTool.ShowOutputImage = new CheckBoxViewModel(ezTool.InSight, cells, current, (string)mXZtEjKSe0Nq5Uf0xHug(), ezTool.IsInitialized);
													num3 = 77;
													continue;
												}
											}
											else
											{
												num3 = 7;
												if (HbTp9SKoARoFoZNDFyow())
												{
													continue;
												}
											}
											goto case 0;
										case 22:
											if (num4 == 2527199700u)
											{
												if (!YUSBk5KoH6C8QfZFs1Ex(text, CdQUGaROfy7He9T0foW.KbIzwHEDLa(4142)))
												{
													num3 = 0;
													if (HbTp9SKoARoFoZNDFyow())
													{
														continue;
													}
													goto case 38;
												}
												ezTool.ExecutionTime = new FloatViewModel(ezTool.InSight, cells, current, (string)FchdvsKSJBHHD2MtBwlV());
												num3 = 34;
												continue;
											}
											num3 = 5;
											continue;
										case 15:
											ezTool.AddProperty(ezTool.FailCount);
											num3 = 2;
											continue;
										case 28:
											if (num4 != 1725856265)
											{
												goto case 0;
											}
											if (text == (string)UgHSljKoMB5NifWA04Zr(29214))
											{
												ezTool.Description = new EditStringViewModel(ezTool.InSight, cells, current, (string)pLkyooKot4jV5m3iQN98());
												num3 = 12;
											}
											else
											{
												num3 = 41;
											}
											continue;
										case 33:
											if (num4 != 2700754061u)
											{
												num3 = 48;
												continue;
											}
											if (YUSBk5KoH6C8QfZFs1Ex(text, UgHSljKoMB5NifWA04Zr(36360)))
											{
												ezTool.Fail = new BoolViewModel(ezTool.InSight, cells, current, (string)eKtGeEKo13SVfeoglshk());
												num3 = 71;
												continue;
											}
											num3 = 36;
											if (hgnJccKoRUyos36j3JNO())
											{
											}
											continue;
										case 13:
											if (num4 != 1384878824)
											{
												hgnJccKoRUyos36j3JNO();
												if (!HbTp9SKoARoFoZNDFyow())
												{
													num3 = 42;
													continue;
												}
												num3 = 53;
												if (HbTp9SKoARoFoZNDFyow())
												{
													continue;
												}
											}
											else if (YUSBk5KoH6C8QfZFs1Ex(text, UgHSljKoMB5NifWA04Zr(36204)))
											{
												ezTool.ErrorCount = new IntViewModel(ezTool.InSight, cells, current, (string)CaO5yrKSLMELr6NGvWpc());
												num3 = 38;
												if (true)
												{
													continue;
												}
												break;
											}
											goto case 0;
										case 9:
										case 53:
											if (num4 == 1458241324 && YUSBk5KoH6C8QfZFs1Ex(text, UgHSljKoMB5NifWA04Zr(6522)))
											{
												ezTool.InputFixture = new InputFixtureViewModel(ezTool, cells, current, (string)MSA2DvKoQJxgMSsqwqJF(), ezTool.IsInitialized);
												num3 = 51;
												continue;
											}
											goto case 0;
										case 70:
											ezTool.AddProperty(ezTool.Error);
											num3 = 24;
											continue;
										case 20:
											ezTool.AddProperty(ezTool.ShowImage);
											num3 = 79;
											continue;
										case 0:
										case 5:
										case 10:
										case 16:
										case 19:
										case 26:
										case 27:
										case 30:
										case 35:
										case 36:
										case 40:
										case 41:
										case 42:
										case 46:
										case 47:
										case 49:
										case 50:
										case 52:
										case 55:
										case 72:
										case 74:
										case 76:
										case 78:
											if (text != null)
											{
												num3 = 54;
												if (hgnJccKoRUyos36j3JNO())
												{
												}
												continue;
											}
											break;
										case 75:
											if (num4 > 417825335)
											{
												if (num4 != 499540992)
												{
													num3 = 13;
													continue;
												}
												if (YUSBk5KoH6C8QfZFs1Ex(text, UgHSljKoMB5NifWA04Zr(4928)))
												{
													ezTool.InputImage = new InputImageViewModel(ezTool, cells, current, Resources.InputImage, ezTool.IsInitialized);
													num3 = 23;
													continue;
												}
												num3 = 72;
												if (true)
												{
													continue;
												}
												goto case 48;
											}
											num3 = 3;
											continue;
										case 67:
											ezTool.AddProperty(ezTool.PassCount);
											break;
										case 61:
											cvsCell = (CvsCell)hox8B4Ko0CccYqOHXvqj(cells, current);
											num3 = 63;
											if (true)
											{
												continue;
											}
											goto case 0;
										case 39:
											ezTool.x0g6UwdAAJ((string)CcDQkwKomSv1tgYwuO6m(ezTool.SnippetName));
											ezTool.AddProperty(ezTool.SnippetName);
											num3 = 56;
											continue;
										case 29:
											if (num4 == 2658149345u && YUSBk5KoH6C8QfZFs1Ex(text, UgHSljKoMB5NifWA04Zr(42842)))
											{
												ezTool.ShowGraphics = new CheckBoxViewModel(ezTool.InSight, cells, current, (string)MqGsYQKSashI9j2K2CDT(), ezTool.IsInitialized);
												num3 = 66;
												continue;
											}
											goto case 0;
										case 37:
											ezTool.AddProperty(ezTool.JobPass);
											num3 = 45;
											continue;
										case 17:
											if (num4 != 1715995554)
											{
												num3 = 28;
												continue;
											}
											if (YUSBk5KoH6C8QfZFs1Ex(text, UgHSljKoMB5NifWA04Zr(31632)))
											{
												ezTool.IncludeInJobPass = new CheckBoxViewModel(ezTool.InSight, cells, current, (string)a039ncKoNiM3pEaZnRkJ(), ezTool.IsInitialized);
												ezTool.AddProperty(ezTool.IncludeInJobPass);
												break;
											}
											num3 = 35;
											if (0 == 0)
											{
												continue;
											}
											break;
										case 14:
											if (num4 == 3797654840u)
											{
												if (!YUSBk5KoH6C8QfZFs1Ex(text, UgHSljKoMB5NifWA04Zr(40592)))
												{
													num3 = 27;
													continue;
												}
												ezTool.Pass = new BoolViewModel(ezTool.InSight, cells, current, (string)syNRyuKocfTI1JyujR8E());
												ezTool.AddProperty(ezTool.Pass);
												break;
											}
											if (num4 != 4011645184u)
											{
												num3 = 78;
												if (0 == 0)
												{
													continue;
												}
												goto case 0;
											}
											if (YUSBk5KoH6C8QfZFs1Ex(text, CdQUGaROfy7He9T0foW.KbIzwHEDLa(8420)))
											{
												ezTool.EnabledStatus = new BoolViewModel(ezTool.InSight, cells, current, (string)CQkxTnKohyfEXSvr6eT5());
												ezTool.AddProperty(ezTool.EnabledStatus);
												num3 = 57;
											}
											else
											{
												num3 = 47;
											}
											continue;
										case 48:
											if (num4 != 3159863731u)
											{
												num3 = 62;
												if (true)
												{
													continue;
												}
												break;
											}
											if (text == CdQUGaROfy7He9T0foW.KbIzwHEDLa(24986))
											{
												ezTool.Focus = new InternalCheckBoxViewModel(ezTool.InSight, cells, current, Resources.Focus)
												{
													Internal = true
												};
												num3 = 32;
												if (true)
												{
													continue;
												}
												goto case 12;
											}
											num3 = 40;
											if (true)
											{
												continue;
											}
											break;
										case 7:
											if (num4 == 2475539436u)
											{
												if (YUSBk5KoH6C8QfZFs1Ex(text, UgHSljKoMB5NifWA04Zr(36228)))
												{
													ezTool.ErrorString = new StringViewModel(ezTool.InSight, cells, current, (string)aYbqsRKSwEdu2vPOnOlK());
													ezTool.AddProperty(ezTool.ErrorString);
													num3 = 73;
													if (!hgnJccKoRUyos36j3JNO())
													{
														continue;
													}
													break;
												}
												num3 = 46;
												if (HbTp9SKoARoFoZNDFyow())
												{
													continue;
												}
												goto case 37;
											}
											num3 = 22;
											continue;
										case 63:
										{
											if (cvsCell == null)
											{
												break;
											}
											object obj2 = PXwhIWKoFQZjJRsf67K9(cvsCell);
											if (obj2 != null)
											{
												obj = ((string)obj2).Substring(gCgxlqKoYE4dt9DZ0dOv(PXwhIWKoFQZjJRsf67K9(cvsCell), UgHSljKoMB5NifWA04Zr(1104), StringComparison.Ordinal) + 1);
												goto IL_015f;
											}
											num3 = 60;
											if (!hgnJccKoRUyos36j3JNO())
											{
												continue;
											}
											goto case 0;
										}
										default:
											num3 = 16;
											continue;
										case 62:
											if (num4 == 3763310604u)
											{
												if (YUSBk5KoH6C8QfZFs1Ex(text, UgHSljKoMB5NifWA04Zr(36372)))
												{
													ezTool.FailCount = new IntViewModel(ezTool.InSight, cells, current, Resources.FailCount);
													num3 = 15;
													continue;
												}
												goto case 0;
											}
											num3 = 76;
											continue;
										case 3:
											if (num4 == 180921696)
											{
												if (text == (string)UgHSljKoMB5NifWA04Zr(42294))
												{
													ezTool.yAY6jPRnJq = current;
													num3 = 11;
													if (0 == 0)
													{
														continue;
													}
													goto case 66;
												}
												goto case 0;
											}
											num3 = 59;
											continue;
										case 54:
											ezTool.InternalParseCell(text, cells, current);
											num3 = 80;
											continue;
										case 71:
											ezTool.AddProperty(ezTool.Fail);
											num3 = 21;
											continue;
										case 77:
											ezTool.AddProperty(ezTool.ShowOutputImage);
											num3 = 6;
											continue;
										case 1:
										case 2:
										case 4:
										case 6:
										case 11:
										case 18:
										case 21:
										case 24:
										case 31:
										case 43:
										case 45:
										case 56:
										case 57:
										case 58:
										case 64:
										case 73:
										case 79:
										case 80:
											break;
											IL_015f:
											text = (string)obj;
											num4 = kUujJlKoUmqDl33KWEu6(text);
											if (num4 <= 1846007925)
											{
												if (num4 <= 1458241324)
												{
													num3 = 75;
													continue;
												}
												if (num4 <= 1725856265)
												{
													num3 = 44;
													continue;
												}
												if (num4 == 1741983394)
												{
													if (YUSBk5KoH6C8QfZFs1Ex(text, UgHSljKoMB5NifWA04Zr(42870)))
													{
														EzTool ezTool2 = ezTool;
														CheckBoxViewModel checkBoxViewModel = new CheckBoxViewModel(ezTool.InSight, cells, current, (string)ivCci5KSO8XoxfBw5p07(), ezTool.IsInitialized);
														Twf9cRKo2fw8P1IrEu6g(checkBoxViewModel, true);
														ezTool2.ShowResults = checkBoxViewModel;
														num3 = 65;
														if (true)
														{
															continue;
														}
														goto case 65;
													}
												}
												else
												{
													if (num4 != 1841712759)
													{
														if (num4 == 1846007925)
														{
															if (!YUSBk5KoH6C8QfZFs1Ex(text, CdQUGaROfy7He9T0foW.KbIzwHEDLa(31614)))
															{
																num3 = 55;
																continue;
															}
															EzTool ezTool3 = ezTool;
															BoolViewModel boolViewModel = new BoolViewModel(ezTool.InSight, cells, current, Resources.JobPass);
															Twf9cRKo2fw8P1IrEu6g(boolViewModel, true);
															ezTool3.JobPass = boolViewModel;
															num3 = 37;
														}
														else
														{
															num3 = 50;
														}
														continue;
													}
													if (!YUSBk5KoH6C8QfZFs1Ex(text, UgHSljKoMB5NifWA04Zr(40604)))
													{
														num3 = 19;
														continue;
													}
													ezTool.PassCount = new IntViewModel(ezTool.InSight, cells, current, (string)QFRQafKozPXhjIVNSDic());
													num3 = 67;
													if (HbTp9SKoARoFoZNDFyow())
													{
														continue;
													}
												}
											}
											else
											{
												if (num4 <= 2658149345u)
												{
													num3 = 68;
													continue;
												}
												if (num4 <= 3763310604u)
												{
													num3 = 33;
													if (!hgnJccKoRUyos36j3JNO())
													{
														continue;
													}
													goto case 54;
												}
												if (num4 <= 4011645184u)
												{
													num3 = 14;
													continue;
												}
												if (num4 != 4086144241u)
												{
													num3 = 8;
													if (0 == 0)
													{
														continue;
													}
												}
												else if (text == CdQUGaROfy7He9T0foW.KbIzwHEDLa(36142))
												{
													EzTool ezTool4 = ezTool;
													BoolViewModel boolViewModel2 = new BoolViewModel(ezTool.InSight, cells, current, (string)vlrv9MKS5U578SyeAIBE());
													Twf9cRKo2fw8P1IrEu6g(boolViewModel2, true);
													ezTool4.Error = boolViewModel2;
													num3 = 70;
													continue;
												}
											}
											goto case 0;
										}
										break;
									}
								}
							}
							finally
							{
								if (num2 < 0 && enumerator2 != null)
								{
									nGR5ICKoTReXSOg21XoI(enumerator2);
								}
							}
							awaiter = B5SYFwKSVQLk8QfEwxHV(CnbyceKSn6iy5eMF5TGP(ezTool, cells));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
						}
						awaiter.GetResult();
						if (ezTool.InputImage != null && ezTool.InputFixture != null)
						{
							PPFs8MKSdygJJrY3P0Mb(ezTool.InputFixture, (string)UgHSljKoMB5NifWA04Zr(28188) + mGkIIiKSfqWfky0YgI9u(ezTool.InputImage).ToString(absoluteRow: true, absoluteColumn: true) + (string)UgHSljKoMB5NifWA04Zr(48964));
						}
						TpSyV9KSlK4POUNLPxGl(ezTool, cells);
						ezTool.X62dzvTlqd(cells);
						enumerator = ezTool.Properties.GetEnumerator();
						try
						{
							while (ocyVbgKoWpM9ny1qDxoj(enumerator))
							{
								enumerator.Current.SourcePropertyChanged += ezTool.EeldmQvMJb;
							}
						}
						finally
						{
							if (num2 < 0 && enumerator != null)
							{
								nGR5ICKoTReXSOg21XoI(enumerator);
							}
						}
						lrEsurKSgJs9oVBp0XIn(ezTool, "");
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 5;
				default:
					num = 5;
					continue;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					break;
				case 6:
					return;
				}
				break;
			}
			goto IL_002a;
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
		internal static bool ocyVbgKoWpM9ny1qDxoj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void nGR5ICKoTReXSOg21XoI(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void bqtDQLKoyg5lf0ojI3pl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EzTool)P_0).InternalPreParse();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hox8B4Ko0CccYqOHXvqj(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PXwhIWKoFQZjJRsf67K9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UgHSljKoMB5NifWA04Zr(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int gCgxlqKoYE4dt9DZ0dOv(object P_0, object P_1, StringComparison P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).IndexOf((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static uint kUujJlKoUmqDl33KWEu6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YUSBk5KoH6C8QfZFs1Ex(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FeAyF4KoxUuNyvJaA4sl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CcDQkwKomSv1tgYwuO6m(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SnippetNameViewModel)P_0).Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MSA2DvKoQJxgMSsqwqJF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.InputFixture;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object a039ncKoNiM3pEaZnRkJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.IncludeInJobPass;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Twf9cRKo2fw8P1IrEu6g(object P_0, bool value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CellViewModel)P_0).Internal = value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object syNRyuKocfTI1JyujR8E()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.Pass;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eKtGeEKo13SVfeoglshk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.Fail;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LBEJXGKouYAOjOpPaBm7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.Enabled;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CQkxTnKohyfEXSvr6eT5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.EnabledStatus;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pLkyooKot4jV5m3iQN98()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.Description;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object QFRQafKozPXhjIVNSDic()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.PassCount;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CaO5yrKSLMELr6NGvWpc()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ErrorCount;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Tg5700KSKKjmNg534bnb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.TotalCount;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vlrv9MKS5U578SyeAIBE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.Error;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object aYbqsRKSwEdu2vPOnOlK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ErrorString;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FchdvsKSJBHHD2MtBwlV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ExecutionTime;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MqGsYQKSashI9j2K2CDT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ShowGraphics;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mXZtEjKSe0Nq5Uf0xHug()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ShowOutputImage;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ivCci5KSO8XoxfBw5p07()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ShowResults;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object uJ6uskKSISDgEKAAJdip()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ShowImage;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BtRQ6kKSD02Jb28lX6Qo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.Order;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SoJeYLKSit5ooW2D6OfC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.EnableInputGraphic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CnbyceKSn6iy5eMF5TGP(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzTool)P_0).InternalPostParse((CvsCellCollection)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter B5SYFwKSVQLk8QfEwxHV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation mGkIIiKSfqWfky0YgI9u(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellLocation;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PPFs8MKSdygJJrY3P0Mb(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((InputStructureViewModel)P_0).DefaultExpression = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void TpSyV9KSlK4POUNLPxGl(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EzTool)P_0).RefreshGraphics((CvsCellCollection)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void lrEsurKSgJs9oVBp0XIn(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BasePropertyChanged)P_0).FirePropertyChanged((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HbTp9SKoARoFoZNDFyow()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hgnJccKoRUyos36j3JNO()
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
	private struct _003CToolProperty_SourcePropertyChanged_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzTool _003C_003E4__this;

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
			DM5VDaKSv7GZwor4ML7i();
			int num;
			if (D0fOSsKSs6CYXZwi2tfs())
			{
				num = 5;
			}
			else
			{
				num = 2;
				if (DM5VDaKSv7GZwor4ML7i())
				{
				}
			}
			EzTool ezTool = default;
			TaskAwaiter awaiter = default;
			CellViewModel cellViewModel = default;
			int num2 = default;
			PropertyLinks propertyLinks = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					break;
				case 4:
					try
					{
						int num3;
						object obj;
						if (num2 != 0)
						{
							InspectStepViewModel parent = ezTool.Parent;
							if (parent == null)
							{
								D0fOSsKSs6CYXZwi2tfs();
								num3 = (DM5VDaKSv7GZwor4ML7i() ? 3 : 10);
							}
							else
							{
								EasyBuilderApplicationViewModel appViewModel = parent.AppViewModel;
								if (appViewModel != null)
								{
									obj = appViewModel.PropertyLinks;
									goto IL_01e5;
								}
								num3 = 8;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
							if (false)
							{
								goto IL_0175;
							}
						}
						goto IL_00e5;
						IL_0175:
						num2 = (_003C_003E1__state = -1);
						num3 = 1;
						goto IL_00e5;
						IL_01da:
						obj = null;
						goto IL_01e5;
						IL_00e5:
						while (true)
						{
							switch (num3)
							{
							case 1:
								awaiter.GetResult();
								num3 = 13;
								if (true)
								{
									continue;
								}
								goto case 12;
							case 12:
								if (cellViewModel != null)
								{
									num3 = 11;
									continue;
								}
								goto IL_0202;
							case 0:
							case 10:
								break;
							case 2:
								num2 = (_003C_003E1__state = 0);
								goto case 9;
							default:
								num3 = 9;
								if (DM5VDaKSv7GZwor4ML7i())
								{
								}
								continue;
							case 9:
								_003C_003Eu__1 = awaiter;
								goto case 3;
							case 3:
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 4:
								goto IL_0175;
							case 6:
								_003C_003Eu__1 = default;
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto case 5;
							case 5:
								if (awaiter.IsCompleted)
								{
									goto case 1;
								}
								num3 = 2;
								if (!DM5VDaKSv7GZwor4ML7i())
								{
									continue;
								}
								goto case 11;
							case 11:
								awaiter = XEDtk4KSrwlWfHNKWsJ6(propertyLinks.OnSourcePropertyChanged(cellViewModel, args));
								num3 = 5;
								continue;
							case 8:
								goto IL_01da;
							case 13:
								goto IL_0202;
							}
							break;
						}
						obj = null;
						goto IL_01e5;
						IL_0202:
						A0FP97KSPj0d1TELuiu8(ezTool);
						goto end_IL_005e;
						IL_01e5:
						propertyLinks = (PropertyLinks)obj;
						if (propertyLinks != null)
						{
							cellViewModel = sender as CellViewModel;
							num3 = 12;
							goto IL_00e5;
						}
						goto IL_0202;
						end_IL_005e:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 3;
				default:
					num = 3;
					continue;
				case 1:
				case 2:
					break;
				case 6:
					return;
				}
				ezTool = _003C_003E4__this;
				num = 4;
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
		internal static TaskAwaiter XEDtk4KSrwlWfHNKWsJ6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void A0FP97KSPj0d1TELuiu8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EzTool)P_0).InternalSourcePropertyChanged();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool D0fOSsKSs6CYXZwi2tfs()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DM5VDaKSv7GZwor4ML7i()
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
	private struct _003CInternalPostParse_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 5;
					break;
				case 4:
					num2 = _003C_003E1__state;
					tixfgKKSZ70l6mO1SMjs();
					num = ((!OECBiAKSBiFEIae75msL()) ? 3 : 0);
					break;
				case 1:
				case 3:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = Task.CompletedTask.GetAwaiter();
							num3 = 2;
							if (OECBiAKSBiFEIae75msL())
							{
								goto IL_006f;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
							if (OECBiAKSBiFEIae75msL())
							{
							}
						}
						goto IL_008f;
						IL_008f:
						while (true)
						{
							switch (num3)
							{
							case 5:
								break;
							default:
								goto IL_00bc;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto case 9;
							case 7:
								num2 = (_003C_003E1__state = 0);
								num3 = 1;
								continue;
							case 4:
							case 8:
								return;
							case 3:
								_003C_003Eu__1 = default;
								goto case 0;
							case 1:
								_003C_003Eu__1 = awaiter;
								num3 = 5;
								continue;
							case 0:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (OECBiAKSBiFEIae75msL())
								{
								}
								continue;
							case 9:
								awaiter.GetResult();
								goto end_IL_004e;
							}
							break;
						}
						goto IL_006f;
						IL_00bc:
						_ = 0;
						num3 = (tixfgKKSZ70l6mO1SMjs() ? 8 : 0);
						goto IL_008f;
						IL_006f:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						goto IL_00bc;
						end_IL_004e:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
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
		internal static bool tixfgKKSZ70l6mO1SMjs()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OECBiAKSBiFEIae75msL()
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
	private struct _003CUpdateCellNames_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Dictionary<string, string>> _003C_003Et__builder;

		public EzTool _003C_003E4__this;

		public string newToolName;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private CvsCellCollection _003Ccells_003E5__3;

		private Dictionary<string, string> _003Cnames_003E5__4;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		private IEnumerator<CvsCellLocation> _003C_003E7__wrap4;

		private TaskAwaiter<object> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			EzTool ezTool = default;
			TaskAwaiter<object> awaiter2 = default;
			CvsCellLocation current = default;
			string text = default;
			CvsCell cvsCell = default;
			string text2 = default;
			int num2 = default;
			Dictionary<string, string> result = default;
			do
			{
				IL_05dd:
				switch (num)
				{
				case 7:
					ezTool = _003C_003E4__this;
					num = 0;
					goto IL_05dd;
				case 0:
					try
					{
						TaskAwaiter<CvsCellCollection> awaiter;
						CvsCellCollection result2;
						IEnumerator<CellViewModel> enumerator;
						switch (num2)
						{
						default:
							_003Csheet_003E5__2 = (CvsCogSocketSheet)tBx1xqKSSwDEnbrpDZm8(Cx53jnKSo8yRu2eO3ZCH(ezTool.InSight));
							awaiter = _003Csheet_003E5__2.RunAndGetCellResults().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_00b1;
						case 0:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00b1;
						case 1:
							try
							{
								int num3;
								if (num2 != 1)
								{
									num3 = 10;
								}
								else
								{
									awaiter2 = _003C_003Eu__2;
									num3 = 11;
								}
								while (true)
								{
									object obj;
									switch (num3)
									{
									case 1:
										if (current.IsValid)
										{
											num3 = 12;
											break;
										}
										goto case 10;
									case 7:
									case 14:
										awaiter2.GetResult();
										num3 = 17;
										break;
									case 6:
										num2 = (_003C_003E1__state = -1);
										goto case 7;
									case 5:
										awaiter2 = _003Csheet_003E5__2.SetCellNameAsync(current, text).GetAwaiter();
										if (!awaiter2.IsCompleted)
										{
											num2 = (_003C_003E1__state = 1);
											num3 = 8;
											break;
										}
										goto case 7;
									case 4:
									case 9:
										obj = null;
										goto IL_031e;
									case 2:
										cvsCell = (CvsCell)cnbZhXKS4OQ7MjpbA1IS(_003Ccells_003E5__3, current);
										num3 = 1;
										break;
									case 0:
										text = (string)lYTDN1KS84EUisxRhLqe(newToolName, text2);
										num3 = 3;
										if (VbqaCOKSbA3KTy5VYUDE())
										{
											break;
										}
										goto case 8;
									case 8:
										_003C_003Eu__2 = awaiter2;
										num3 = 13;
										break;
									case 12:
										if (cvsCell != null)
										{
											obj = h4Ht2xKS7kVGvQAQoR4K(cvsCell);
											goto IL_031e;
										}
										_ = 0;
										num3 = (VbqaCOKSbA3KTy5VYUDE() ? 9 : 7);
										break;
									case 3:
										if (text != null)
										{
											num3 = 15;
											break;
										}
										goto case 10;
									case 15:
										if (!LNvrwCKS6jRtXuZT2v4B(text, text2, StringComparison.Ordinal))
										{
											_003Cnames_003E5__4[(string)t2LSEPKSjHXLKhL8LR4n(cvsCell)] = text;
											goto case 5;
										}
										goto case 10;
									default:
										num3 = 5;
										if (!VbqaCOKSbA3KTy5VYUDE())
										{
											return;
										}
										break;
									case 16:
										return;
									case 13:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num3 = 16;
										break;
									case 11:
										_003C_003Eu__2 = default;
										num3 = 6;
										break;
									case 10:
									case 17:
										{
											if (bs7nU4KSXXJpnRp8Rf8x(_003C_003E7__wrap4))
											{
												current = _003C_003E7__wrap4.Current;
												num3 = 2;
												if (true)
												{
													break;
												}
												goto case 1;
											}
											goto end_IL_03e8;
										}
										IL_031e:
										if (!jJKHxIKS3ID8WPRiC3uh(obj))
										{
											text2 = (string)t2LSEPKSjHXLKhL8LR4n(cvsCell);
											num3 = 0;
											break;
										}
										goto case 10;
									}
									continue;
									end_IL_03e8:
									break;
								}
							}
							finally
							{
								if (num2 < 0 && _003C_003E7__wrap4 != null)
								{
									NWovVVKS9vLmQoRmlpsh(_003C_003E7__wrap4);
								}
							}
							_003C_003E7__wrap4 = null;
							awaiter = _003Csheet_003E5__2.RunAndGetCellResults().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 2);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							break;
						case 2:
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								break;
							}
							IL_00b1:
							result2 = awaiter.GetResult();
							_003Ccells_003E5__3 = result2;
							_003Cnames_003E5__4 = new Dictionary<string, string>();
							enumerator = ezTool.AllProperties.GetEnumerator();
							try
							{
								while (bs7nU4KSXXJpnRp8Rf8x(enumerator))
								{
									CellViewModel current2 = enumerator.Current;
									string text3 = (string)PbsLMHKSkSc6jlo6vFL2(current2);
									string text4 = (string)lYTDN1KS84EUisxRhLqe(newToolName, text3);
									if (text4 != null && !text4.Equals(text3, StringComparison.Ordinal))
									{
										_003Cnames_003E5__4[text3] = text4;
										X7AH4jKSqU0UxTHDtpVA(current2, text4);
										O3CcQdKSpJUdcNn9kmqC(current2, lYTDN1KS84EUisxRhLqe(newToolName, E2BFvsKSE5bYILf3cj5J(current2)));
									}
									if (!(current2 is FixtureArrayViewModel fixtureArrayViewModel))
									{
										continue;
									}
									IEnumerator<FixtureViewModel> enumerator2 = fixtureArrayViewModel.Fixtures.GetEnumerator();
									try
									{
										while (bs7nU4KSXXJpnRp8Rf8x(enumerator2))
										{
											FixtureViewModel current3 = enumerator2.Current;
											_ = 0;
											int num4;
											if (VbqaCOKSbA3KTy5VYUDE())
											{
												num4 = 2;
												if (!VbqaCOKSbA3KTy5VYUDE())
												{
													goto IL_018f;
												}
											}
											else
											{
												num4 = 3;
												if (1 == 0)
												{
													continue;
												}
											}
											goto IL_01dd;
											IL_018f:
											O3CcQdKSpJUdcNn9kmqC(current3, EzSnippet.ReplaceSnippetNameInCellName(newToolName, (string)E2BFvsKSE5bYILf3cj5J(current3)));
											num4 = 4;
											goto IL_01dd;
											IL_01dd:
											switch (num4)
											{
											case 0:
											case 2:
												X7AH4jKSqU0UxTHDtpVA(current3, lYTDN1KS84EUisxRhLqe(newToolName, current3.CellName));
												break;
											case 4:
												continue;
											}
											goto IL_018f;
										}
									}
									finally
									{
										if (num2 < 0 && enumerator2 != null)
										{
											NWovVVKS9vLmQoRmlpsh(enumerator2);
										}
									}
								}
							}
							finally
							{
								if (num2 < 0 && enumerator != null)
								{
									NWovVVKS9vLmQoRmlpsh(enumerator);
								}
							}
							_003C_003E7__wrap4 = ezTool.CellRange.GetEnumerator();
							goto case 1;
						}
						CvsCellCollection result3 = awaiter.GetResult();
						jNQnwwKSCX8mXTO3hPa4(ezTool.Parent, result3);
						result = _003Cnames_003E5__4;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Csheet_003E5__2 = null;
						_003Ccells_003E5__3 = null;
						_003Cnames_003E5__4 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					VbqaCOKSbA3KTy5VYUDE();
					num = ((!KBb0ZeKSGlEbFQumCm9p()) ? 1 : 5);
					goto IL_05dd;
				case 5:
				case 6:
					_003C_003Et__builder.SetResult(result);
					num = 9;
					goto IL_05dd;
				case 8:
					_003Cnames_003E5__4 = null;
					goto case 5;
				case 1:
				case 3:
					_003Csheet_003E5__2 = null;
					break;
				default:
					num = 2;
					goto IL_05dd;
				case 4:
					num2 = _003C_003E1__state;
					num = 7;
					goto IL_05dd;
				case 2:
					break;
				case 9:
					return;
				}
				_003Ccells_003E5__3 = null;
				num = 8;
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
		internal static object Cx53jnKSo8yRu2eO3ZCH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tBx1xqKSSwDEnbrpDZm8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PbsLMHKSkSc6jlo6vFL2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).CellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lYTDN1KS84EUisxRhLqe(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EzSnippet.ReplaceSnippetNameInCellName((string)P_0, (string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void X7AH4jKSqU0UxTHDtpVA(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CellViewModel)P_0).CellName = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object E2BFvsKSE5bYILf3cj5J(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).LocalizedCellName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void O3CcQdKSpJUdcNn9kmqC(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CellViewModel)P_0).LocalizedCellName = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bs7nU4KSXXJpnRp8Rf8x(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NWovVVKS9vLmQoRmlpsh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cnbZhXKS4OQ7MjpbA1IS(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object h4Ht2xKS7kVGvQAQoR4K(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jJKHxIKS3ID8WPRiC3uh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.IsNullOrEmpty((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object t2LSEPKSjHXLKhL8LR4n(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LNvrwCKS6jRtXuZT2v4B(object P_0, object P_1, StringComparison P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).Equals((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jNQnwwKSCX8mXTO3hPa4(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((AppStepViewModel)P_0).Refresh((CvsCellCollection)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VbqaCOKSbA3KTy5VYUDE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KBb0ZeKSGlEbFQumCm9p()
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
	private struct _003CBindResetCounter_003Ed__163 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EzTool _003C_003E4__this;

		private TaskAwaiter<object> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			EzTool ezTool = default;
			int num2 = default;
			TaskAwaiter<object> awaiter = default;
			CvsCellLocation? cvsCellLocation2 = default;
			CvsCellLocation cvsCellLocation3 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 4:
					ezTool = _003C_003E4__this;
					goto case 2;
				case 2:
				case 5:
					try
					{
						int num3;
						CvsCellLocation? cvsCellLocation;
						if (num2 != 0)
						{
							InspectStepViewModel parent = ezTool.Parent;
							if (parent == null)
							{
								num3 = 10;
							}
							else
							{
								JobPassFail jobPassFail = parent.JobPassFail;
								if (jobPassFail != null)
								{
									ButtonViewModel resetCommand = jobPassFail.ResetCommand;
									if (resetCommand != null)
									{
										cvsCellLocation = resetCommand.CellLocation;
										goto IL_01f6;
									}
									num3 = 4;
								}
								else
								{
									MTsRJUKSAk0DrDGVjKlR();
									if (!JMyJ3iKSRtqITgoqW9oM())
									{
										num3 = 0;
										if (!MTsRJUKSAk0DrDGVjKlR())
										{
											goto IL_01e5;
										}
									}
									else
									{
										num3 = 3;
										if (!MTsRJUKSAk0DrDGVjKlR())
										{
											goto IL_0260;
										}
									}
								}
							}
							goto IL_0133;
						}
						awaiter = _003C_003Eu__1;
						goto IL_019c;
						IL_019c:
						_003C_003Eu__1 = default;
						num3 = 6;
						goto IL_0133;
						IL_0133:
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 2:
								cvsCellLocation2 = null;
								num3 = 13;
								continue;
							case 10:
								cvsCellLocation2 = null;
								num3 = 9;
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 15;
								continue;
							case 13:
								break;
							case 14:
								_003C_003Eu__1 = awaiter;
								num3 = 12;
								continue;
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 14;
								continue;
							case 1:
								if (ezTool.yAY6jPRnJq.IsValid)
								{
									awaiter = ((CvsCogSocketSheet)dTJJMdKSTCWat1oH9biQ(nKO8IBKSWDsm3BlGnvyS(ezTool.InSight))).PutCellExpressionAsync(ezTool.yAY6jPRnJq, cvsCellLocation3.ToString(absoluteRow: true, absoluteColumn: true)).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										goto case 5;
									}
									goto IL_0260;
								}
								goto end_IL_0044;
							default:
								num3 = 5;
								continue;
							case 12:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								if (true)
								{
									continue;
								}
								goto IL_019c;
							case 3:
							case 11:
								goto IL_019c;
							case 9:
								goto IL_01b2;
							case 7:
								goto IL_01e5;
							case 4:
								cvsCellLocation2 = null;
								num3 = 7;
								continue;
							case 8:
								return;
							case 15:
								goto IL_0260;
							}
							break;
						}
						cvsCellLocation = cvsCellLocation2;
						goto IL_01f6;
						IL_01e5:
						cvsCellLocation = cvsCellLocation2;
						goto IL_01f6;
						IL_0260:
						awaiter.GetResult();
						goto end_IL_0044;
						IL_01b2:
						cvsCellLocation = cvsCellLocation2;
						goto IL_01f6;
						IL_01f6:
						cvsCellLocation3 = cvsCellLocation ?? CvsCellLocation.Invalid;
						if (cvsCellLocation3.IsValid)
						{
							num3 = 1;
							goto IL_0133;
						}
						end_IL_0044:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 0;
				default:
					num = 0;
					break;
				case 3:
					num2 = _003C_003E1__state;
					JMyJ3iKSRtqITgoqW9oM();
					num = (MTsRJUKSAk0DrDGVjKlR() ? 4 : 5);
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
		internal static object nKO8IBKSWDsm3BlGnvyS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dTJJMdKSTCWat1oH9biQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MTsRJUKSAk0DrDGVjKlR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JMyJ3iKSRtqITgoqW9oM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<CvsEditableDisplayGraphic, bool> _003C_003E9__165_0;

		public static Func<CellViewModel, bool> _003C_003E9__182_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			iyXONVKSF5lGEJVrxxjA();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetEditableGraphics_003Eb__165_0(CvsEditableDisplayGraphic g)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Array)nStp9DKSMSDQY5gV7MiP(g)).Length != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetSourceLinks_003Eb__182_0(CellViewModel c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return !mKUh8vKSY8pD83oEQXXj(c);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool a311vsKSyOKY1PayygnL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iVAmYmKS0vCBOA1mdm1G()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void iyXONVKSF5lGEJVrxxjA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nStp9DKSMSDQY5gV7MiP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditableDisplayGraphic)P_0).GetEditModes();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mKUh8vKSY8pD83oEQXXj(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CellViewModel)P_0).Internal;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CWriteFixturedGraphics_003Ed__166 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

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
			if (!w5qeVyKSH0uJVxGhqsMF())
			{
				num = 1;
				if (w5qeVyKSH0uJVxGhqsMF())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 4;
				if (false)
				{
					return;
				}
			}
			goto IL_01ab;
			IL_0041:
			int num2 = _003C_003E1__state;
			num = 3;
			if (w5qeVyKSH0uJVxGhqsMF())
			{
			}
			goto IL_01ab;
			IL_01ab:
			switch (num)
			{
			case 0:
			case 1:
				goto IL_0041;
			case 3:
				try
				{
					TaskAwaiter awaiter;
					int num3;
					if (num2 != 0)
					{
						awaiter = AxF62oKSmxAXsiBNJGvF(rMUQ46KSxCCaxwZqrfmf());
						num3 = 6;
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
						case 3:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						default:
							return;
						case 0:
						case 1:
							num2 = (_003C_003E1__state = 0);
							num3 = 7;
							continue;
						case 6:
							if (!awaiter.IsCompleted)
							{
								Dodw5IKSUlHwUad52viv();
								num3 = (w5qeVyKSH0uJVxGhqsMF() ? 2 : 0);
								continue;
							}
							break;
						case 7:
							_003C_003Eu__1 = awaiter;
							num3 = 3;
							if (w5qeVyKSH0uJVxGhqsMF())
							{
							}
							continue;
						case 2:
							return;
						case 8:
							num2 = (_003C_003E1__state = -1);
							num3 = 9;
							if (0 == 0)
							{
								continue;
							}
							goto case 5;
						case 5:
							_003C_003Eu__1 = default;
							num3 = 8;
							if (true)
							{
								continue;
							}
							break;
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
				break;
			case 5:
				return;
			}
			goto IL_002a;
			IL_002a:
			_003C_003Et__builder.SetResult();
			num = 5;
			if (1 == 0)
			{
				goto IL_0041;
			}
			goto IL_01ab;
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
		internal static object rMUQ46KSxCCaxwZqrfmf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter AxF62oKSmxAXsiBNJGvF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Dodw5IKSUlHwUad52viv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool w5qeVyKSH0uJVxGhqsMF()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public const int PasteShiftingDelta = 10;

	public const int MaxToolNameLength = 32;

	private CvsCellLocation yAY6jPRnJq;

	private readonly Dictionary<string, object> RNh6C29Wk5;

	[CompilerGenerated]
	private readonly IViewModelBroadcaster PSP6OC05BP;

	private bool dfl6Hayq8f;

	private InputImageViewModel dKH6wANTa1;

	private InputFixtureViewModel TiQ6y2oISL;

	[CompilerGenerated]
	private BoolViewModel tZa6xvPuqC;

	[CompilerGenerated]
	private BoolViewModel AeT6vOjt0F;

	[CompilerGenerated]
	private BoolViewModel jo06e59Y5A;

	[CompilerGenerated]
	private ListBoxViewModel xgw62GEj1h;

	private BoolViewModel sHE6qmBEpY;

	private bool qqk6i7K22U;

	private bool z606kcitq6;

	[CompilerGenerated]
	private CheckBoxViewModel xUU6P8ixCp;

	[CompilerGenerated]
	private EditStringViewModel tJp6scUMFI;

	[CompilerGenerated]
	private IntViewModel PEN6KejuyK;

	[CompilerGenerated]
	private IntViewModel jC56GVUsxJ;

	[CompilerGenerated]
	private IntViewModel NKv6BaBpe3;

	[CompilerGenerated]
	private IntViewModel wfq6ZCofxs;

	private BoolViewModel KU16nuWGGx;

	[CompilerGenerated]
	private StringViewModel GLY6tTRnhR;

	[CompilerGenerated]
	private FloatViewModel KwW6YleZDW;

	[CompilerGenerated]
	private InternalCheckBoxViewModel LYW60PLClI;

	[CompilerGenerated]
	private CheckBoxViewModel nPi6VOFcqY;

	[CompilerGenerated]
	private CheckBoxViewModel vZP6Lrn69g;

	[CompilerGenerated]
	private CheckBoxViewModel fnP6Jg1QDi;

	[CompilerGenerated]
	private InternalCheckBoxViewModel qVV693AO6w;

	private InputCompositeRegionViewModel h9H6rSM4mC;

	private InputRegionViewModel Smj6h3fYQ3;

	private InputAnnulusViewModel pJk68ooghs;

	private InputPlaneViewModel pos6mBtqlR;

	[CompilerGenerated]
	private List<ExtraHelpText> omt61p8D1P;

	[CompilerGenerated]
	private InternalCheckBoxViewModel vfR6z82cWU;

	public bool IsInitialized
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return dfl6Hayq8f;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!U22vRXlycqNmlJZvHjO())
			{
				num = 2;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 3;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					break;
				default:
					num = 4;
					if (jCFQmKlT7aV74Q5kR3V())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 2:
					if (SetField(ref dfl6Hayq8f, value, (string)sQkYZmlURdlespL1ekJ(4976)))
					{
						break;
					}
					return;
				case 4:
					goto IL_0099;
				}
				break;
			}
			goto IL_0026;
			IL_0099:
			IEnumerator<CellViewModel> enumerator = default;
			try
			{
				while (ptop5elHq99H9qYdQU8(enumerator))
				{
					enumerator.Current.IsInitialized = dfl6Hayq8f;
				}
				return;
			}
			finally
			{
				if (enumerator != null)
				{
					ePvjR5lxaZnl36XMK19(enumerator);
				}
			}
			IL_0026:
			enumerator = AllProperties.GetEnumerator();
			goto IL_0099;
		}
	}

	public virtual bool AllowsAnyImageAsInput
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}
	}

	public abstract string ImagePath { get; }

	public new InspectStepViewModel Parent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (InspectStepViewModel)base.Parent;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			base.Parent = value;
		}
	}

	public IOperationProgressManager OperationProgressManager
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (IOperationProgressManager)xy0e0qlNdsQoXjHSbst(Parent);
		}
	}

	public InputImageViewModel InputImage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return dKH6wANTa1;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
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
				case 2:
					if (dKH6wANTa1 != null)
					{
						num = 7;
						if (jCFQmKlT7aV74Q5kR3V())
						{
							break;
						}
						goto case 0;
					}
					goto case 3;
				case 0:
					GfemCSlcc5TY69NY5Uo(dKH6wANTa1, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
					num = 8;
					if (0 == 0)
					{
						break;
					}
					goto default;
				default:
					if (dKH6wANTa1 != null)
					{
						num = 0;
						break;
					}
					return;
				case 7:
					XsSb6Dl2M4r8olEuHyV(dKH6wANTa1, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
					jCFQmKlT7aV74Q5kR3V();
					if (!U22vRXlycqNmlJZvHjO())
					{
						num = 5;
						if (true)
						{
							break;
						}
						goto case 6;
					}
					num = 1;
					break;
				case 6:
					if (dKH6wANTa1 != value)
					{
						num = 2;
						break;
					}
					return;
				case 3:
				case 5:
					dKH6wANTa1 = value;
					goto default;
				case 8:
					return;
				}
			}
		}
	}

	public InputFixtureViewModel InputFixture
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return TiQ6y2oISL;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (TiQ6y2oISL != value)
					{
						num = 0;
						break;
					}
					return;
				case 4:
				case 7:
					if (TiQ6y2oISL != null)
					{
						goto case 5;
					}
					return;
				case 3:
					TiQ6y2oISL = value;
					goto default;
				default:
					U22vRXlycqNmlJZvHjO();
					num = (jCFQmKlT7aV74Q5kR3V() ? 7 : 6);
					break;
				case 0:
					if (TiQ6y2oISL != null)
					{
						num = 1;
						break;
					}
					goto case 3;
				case 5:
				case 6:
					TiQ6y2oISL.PropertyChanged += SourceLink_PropertyChanged;
					num = 8;
					if (true)
					{
						break;
					}
					goto case 1;
				case 1:
					XsSb6Dl2M4r8olEuHyV(TiQ6y2oISL, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
					num = 3;
					break;
				case 8:
					return;
				}
			}
		}
	}

	public BoolViewModel Pass
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tZa6xvPuqC;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			tZa6xvPuqC = value;
		}
	}

	public BoolViewModel Fail
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return AeT6vOjt0F;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			AeT6vOjt0F = value;
		}
	}

	public BoolViewModel JobPass
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return jo06e59Y5A;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			jo06e59Y5A = value;
		}
	}

	public ListBoxViewModel Enabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xgw62GEj1h;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xgw62GEj1h = value;
		}
	}

	public BoolViewModel EnabledStatus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return sHE6qmBEpY;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (U22vRXlycqNmlJZvHjO() ? 3 : 4);
			do
			{
				IL_0090:
				switch (num)
				{
				case 0:
				case 4:
					if (sHE6qmBEpY != null)
					{
						break;
					}
					goto case 2;
				case 5:
					sHE6qmBEpY.PropertyChanged += KGjd1FVIP3;
					num = 7;
					if (0 == 0)
					{
						goto IL_0090;
					}
					goto case 6;
				case 6:
					if (sHE6qmBEpY != null)
					{
						num = 5;
						goto IL_0090;
					}
					return;
				case 2:
					sHE6qmBEpY = value;
					goto case 6;
				default:
					num = 6;
					goto IL_0090;
				case 1:
				case 3:
					break;
				case 7:
					return;
				}
				XsSb6Dl2M4r8olEuHyV(sHE6qmBEpY, new PropertyChangedEventHandler(KGjd1FVIP3));
				num = 2;
			}
			while (0 == 0);
		}
	}

	public bool IsGrouped
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qqk6i7K22U;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref qqk6i7K22U, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(5006)))
			{
				UqnDRml1rpboM6OgKpV(CopyCommand);
			}
		}
	}

	public virtual bool IsCollapsibleParent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public virtual bool IsCollapsed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return z606kcitq6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref z606kcitq6, value, (string)sQkYZmlURdlespL1ekJ(5028));
		}
	}

	public CheckBoxViewModel IncludeInJobPass
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xUU6P8ixCp;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xUU6P8ixCp = value;
		}
	}

	public EditStringViewModel Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tJp6scUMFI;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			tJp6scUMFI = value;
		}
	}

	public IntViewModel PassCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PEN6KejuyK;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			PEN6KejuyK = value;
		}
	}

	public IntViewModel FailCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return jC56GVUsxJ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			jC56GVUsxJ = value;
		}
	}

	public IntViewModel ErrorCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return NKv6BaBpe3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NKv6BaBpe3 = value;
		}
	}

	public IntViewModel TotalCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wfq6ZCofxs;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			wfq6ZCofxs = value;
		}
	}

	public BoolViewModel Error
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KU16nuWGGx;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!jCFQmKlT7aV74Q5kR3V())
			{
				goto IL_001e;
			}
			goto IL_008f;
			IL_001e:
			GfemCSlcc5TY69NY5Uo(KU16nuWGGx, new PropertyChangedEventHandler(cSI653gThU));
			num = 8;
			if (U22vRXlycqNmlJZvHjO())
			{
				goto IL_0045;
			}
			goto IL_008f;
			IL_008f:
			while (true)
			{
				switch (num)
				{
				case 5:
				case 6:
					break;
				case 4:
					goto IL_0045;
				case 0:
					if (KU16nuWGGx != null)
					{
						break;
					}
					return;
				case 3:
					KU16nuWGGx = value;
					goto case 0;
				default:
					num = 0;
					continue;
				case 1:
				case 2:
					XsSb6Dl2M4r8olEuHyV(KU16nuWGGx, new PropertyChangedEventHandler(cSI653gThU));
					num = 3;
					if (0 == 0)
					{
						continue;
					}
					goto case 7;
				case 7:
					if (KU16nuWGGx == null)
					{
						goto case 3;
					}
					goto IL_00f0;
				case 8:
					return;
				}
				break;
				IL_00f0:
				_ = 1;
				num = ((!U22vRXlycqNmlJZvHjO()) ? 1 : 6);
			}
			goto IL_001e;
			IL_0045:
			if (KU16nuWGGx != value)
			{
				num = 7;
				goto IL_008f;
			}
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
			return GLY6tTRnhR;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			GLY6tTRnhR = value;
		}
	}

	public FloatViewModel ExecutionTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return KwW6YleZDW;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KwW6YleZDW = value;
		}
	}

	public InternalCheckBoxViewModel Focus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return LYW60PLClI;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			LYW60PLClI = value;
		}
	}

	public CheckBoxViewModel ShowGraphics
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return nPi6VOFcqY;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			nPi6VOFcqY = value;
		}
	}

	public CheckBoxViewModel ShowOutputImage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return vZP6Lrn69g;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			vZP6Lrn69g = value;
		}
	}

	public CheckBoxViewModel ShowResults
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return fnP6Jg1QDi;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			fnP6Jg1QDi = value;
		}
	}

	public InternalCheckBoxViewModel ShowImage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qVV693AO6w;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			qVV693AO6w = value;
		}
	}

	public InputCompositeRegionViewModel InputCompositeRegion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return h9H6rSM4mC;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
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
				case 3:
					h9H6rSM4mC = value;
					goto default;
				case 7:
					GfemCSlcc5TY69NY5Uo(h9H6rSM4mC, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
					num = 8;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				case 0:
					if (h9H6rSM4mC != value)
					{
						jCFQmKlT7aV74Q5kR3V();
						num = ((!U22vRXlycqNmlJZvHjO()) ? 5 : 6);
						break;
					}
					return;
				default:
					if (h9H6rSM4mC != null)
					{
						num = 7;
						break;
					}
					return;
				case 2:
					XsSb6Dl2M4r8olEuHyV(h9H6rSM4mC, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
					num = 3;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
				case 5:
					if (h9H6rSM4mC != null)
					{
						num = 2;
						break;
					}
					goto case 3;
				case 8:
					return;
				}
			}
		}
	}

	public InputRegionViewModel InputRegion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Smj6h3fYQ3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			jCFQmKlT7aV74Q5kR3V();
			int num = (U22vRXlycqNmlJZvHjO() ? 4 : 3);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					if (Smj6h3fYQ3 != value)
					{
						num = 6;
						break;
					}
					return;
				case 2:
				case 4:
					XsSb6Dl2M4r8olEuHyV(Smj6h3fYQ3, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
					num = 7;
					break;
				case 1:
					Smj6h3fYQ3.PropertyChanged += SourceLink_PropertyChanged;
					num = 8;
					if (jCFQmKlT7aV74Q5kR3V())
					{
						break;
					}
					goto case 5;
				case 5:
					if (Smj6h3fYQ3 != null)
					{
						num = 1;
						if (true)
						{
							break;
						}
						goto case 6;
					}
					return;
				case 6:
					if (Smj6h3fYQ3 != null)
					{
						goto case 2;
					}
					goto case 7;
				case 7:
					Smj6h3fYQ3 = value;
					goto case 5;
				default:
					num = 5;
					if (!jCFQmKlT7aV74Q5kR3V())
					{
						return;
					}
					break;
				case 8:
					return;
				}
			}
		}
	}

	public InputAnnulusViewModel InputAnnulus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return pJk68ooghs;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
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
			goto IL_007b;
			IL_001a:
			pJk68ooghs.PropertyChanged += SourceLink_PropertyChanged;
			num = 8;
			goto IL_007b;
			IL_007b:
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				case 2:
				case 7:
					XsSb6Dl2M4r8olEuHyV(pJk68ooghs, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
					num = 3;
					if (!U22vRXlycqNmlJZvHjO())
					{
						continue;
					}
					goto case 3;
				case 3:
					pJk68ooghs = value;
					goto case 6;
				default:
					num = 6;
					if (U22vRXlycqNmlJZvHjO())
					{
					}
					continue;
				case 6:
					if (pJk68ooghs != null)
					{
						num = 5;
						continue;
					}
					return;
				case 1:
				case 4:
					if (pJk68ooghs != null)
					{
						goto case 2;
					}
					goto case 3;
				case 0:
					do
					{
						if (pJk68ooghs != value)
						{
							_ = 0;
							if (!jCFQmKlT7aV74Q5kR3V())
							{
								num = 7;
								continue;
							}
							num = 4;
							break;
						}
						return;
					}
					while (false);
					continue;
				case 8:
					return;
				}
				break;
			}
			goto IL_001a;
		}
	}

	public InputPlaneViewModel InputPlane
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return pos6mBtqlR;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 4:
				case 6:
					if (pos6mBtqlR != null)
					{
						goto case 2;
					}
					return;
				case 1:
					if (pos6mBtqlR != value)
					{
						num = 0;
						break;
					}
					return;
				case 7:
					pos6mBtqlR = value;
					goto default;
				default:
					jCFQmKlT7aV74Q5kR3V();
					if (U22vRXlycqNmlJZvHjO())
					{
						num = 2;
						break;
					}
					num = 6;
					if (!U22vRXlycqNmlJZvHjO())
					{
						break;
					}
					goto case 2;
				case 2:
				case 5:
					GfemCSlcc5TY69NY5Uo(pos6mBtqlR, new PropertyChangedEventHandler(SourceLink_PropertyChanged));
					num = 8;
					break;
				case 3:
					pos6mBtqlR.PropertyChanged -= SourceLink_PropertyChanged;
					num = 7;
					if (U22vRXlycqNmlJZvHjO())
					{
					}
					break;
				case 0:
					if (pos6mBtqlR != null)
					{
						num = 3;
						if (U22vRXlycqNmlJZvHjO())
						{
							return;
						}
						break;
					}
					goto case 7;
				case 8:
					return;
				}
			}
		}
	}

	public virtual bool ShowHelp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			throw new NotSupportedException();
		}
	}

	public List<ExtraHelpText> AdditionalHelpText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return omt61p8D1P;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			omt61p8D1P = value;
		}
	}

	public InternalCheckBoxViewModel EnableInputGraphic
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return vfR6z82cWU;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			vfR6z82cWU = value;
		}
	}

	protected bool HasError
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Error?.Value ?? false;
		}
	}

	public virtual string ResultOrErrorString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			jCFQmKlT7aV74Q5kR3V();
			int num;
			if (!U22vRXlycqNmlJZvHjO())
			{
				num = 1;
				if (!jCFQmKlT7aV74Q5kR3V())
				{
					goto IL_002e;
				}
			}
			else
			{
				num = 4;
			}
			goto IL_008f;
			IL_002e:
			object obj = null;
			goto IL_0039;
			IL_006a:
			obj = null;
			goto IL_0039;
			IL_0039:
			string text = (string)obj;
			if (!ze5h0VgnHK3FgN6weCb(text))
			{
				num = 5;
				if (!jCFQmKlT7aV74Q5kR3V())
				{
					goto IL_0055;
				}
				goto IL_008f;
			}
			return (string)MLLN2SgVc2gF820HxvL(this);
			IL_0055:
			if (!HasError)
			{
				num = 3;
				goto IL_008f;
			}
			StringViewModel errorString = ErrorString;
			if (errorString != null)
			{
				obj = errorString.Value;
				goto IL_0039;
			}
			goto IL_002e;
			IL_008f:
			switch (num)
			{
			case 0:
			case 1:
				goto IL_0055;
			case 3:
				goto IL_006a;
			case 5:
				return text;
			}
			goto IL_002e;
		}
	}

	public virtual string ResultString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (!JSZZIBgJPS49notjbAW(Pass))
			{
				return (string)fCfSwXgfRRqvrdoTJ38();
			}
			return (string)kaUMSAgdP44AaG6sram();
		}
	}

	public virtual string ResultStringDetail
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

	public virtual CellViewModel ResultCell
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Pass;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected EzTool(InspectStepViewModel inspect, bool isInitialized, SnippetLocalizer localizer = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (1 == 0)
		{
			goto IL_001a;
		}
		goto IL_0055;
		IL_001a:
		yAY6jPRnJq = CvsCellLocation.Invalid;
		num = 5;
		goto IL_0055;
		IL_0055:
		bool lockTaken = default;
		EzTool ezTool = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 2:
			case 7:
				lockTaken = false;
				num = 9;
				continue;
			case 10:
				base._002Ector(inspect, localizer);
				goto case 8;
			default:
				num = 8;
				continue;
			case 5:
				RNh6C29Wk5 = new Dictionary<string, object>();
				num = 1;
				if (!U22vRXlycqNmlJZvHjO())
				{
					continue;
				}
				goto case 1;
			case 1:
				omt61p8D1P = new List<ExtraHelpText>();
				num = 10;
				if (jCFQmKlT7aV74Q5kR3V())
				{
					continue;
				}
				goto case 9;
			case 9:
				try
				{
					Monitor.Enter(ezTool, ref lockTaken);
					IsInitialized = isInitialized;
				}
				finally
				{
					if (lockTaken)
					{
						XravMHlMXrwBjYdvKIg(ezTool);
					}
				}
				Q812VblYmRMh8kt4tu1(this);
				num = 11;
				continue;
			case 3:
			case 6:
				ezTool = this;
				goto case 2;
			case 8:
				do
				{
					PSP6OC05BP = (IViewModelBroadcaster)G453cClFagswVPiiy2t();
					_ = 1;
					if (U22vRXlycqNmlJZvHjO())
					{
						num = 2;
						continue;
					}
					num = 3;
					if (U22vRXlycqNmlJZvHjO())
					{
					}
					break;
				}
				while (1 == 0);
				continue;
			case 4:
				h1w20Ol0n8xJ9J7UcXR();
				num = 0;
				if (jCFQmKlT7aV74Q5kR3V())
				{
					continue;
				}
				return;
			case 11:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override ValueTask DisposeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		U22vRXlycqNmlJZvHjO();
		int num;
		if (jCFQmKlT7aV74Q5kR3V())
		{
			num = 2;
			if (1 == 0)
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 5;
		}
		goto IL_007e;
		IL_002a:
		InputImage = null;
		num = 6;
		goto IL_007e;
		IL_007e:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				break;
			case 4:
				InputCompositeRegion = null;
				goto case 3;
			case 7:
				InputPlane = null;
				num = 8;
				if (true)
				{
					continue;
				}
				goto case 3;
			case 3:
			case 5:
				InputRegion = null;
				goto case 1;
			default:
				num = 1;
				continue;
			case 6:
				InputFixture = null;
				num = 4;
				if (jCFQmKlT7aV74Q5kR3V())
				{
					continue;
				}
				goto case 1;
			case 1:
				InputAnnulus = null;
				num = 7;
				continue;
			case 8:
				return base.DisposeAsync();
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public T GetTag<T>(string tagName, T defaultValue)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		T result = defaultValue;
		try
		{
			if (RNh6C29Wk5.Keys.Contains(tagName))
			{
				result = (T)RNh6C29Wk5[tagName];
			}
		}
		catch
		{
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTag<T>(string tagName, T val)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RNh6C29Wk5[tagName] = val;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	internal IViewModelBroadcaster PXv67cKEEX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PSP6OC05BP;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool CanCopy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return !IsGrouped;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CParse_003Ed__18))]
	protected override Task Parse(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CParse_003Ed__18 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder = bQHMqRlm8iVkXdlqOYJ();
				_ = 0;
				if (jCFQmKlT7aV74Q5kR3V())
				{
					num = 0;
					if (jCFQmKlT7aV74Q5kR3V())
					{
						break;
					}
					goto case 2;
				}
				num = 2;
				if (U22vRXlycqNmlJZvHjO())
				{
				}
				break;
			case 2:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 3:
				stateMachine.cells = cells;
				goto case 6;
			default:
				num = 6;
				break;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 3;
				break;
			case 6:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CToolProperty_SourcePropertyChanged_003Ed__19))]
	private Task EeldmQvMJb(object P_0, PropertyValueChangedEventArgs<CellViewModel> P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CToolProperty_SourcePropertyChanged_003Ed__19 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = P_0;
		stateMachine.args = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void InternalSourcePropertyChanged()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void KGjd1FVIP3(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xRWtbdlQ4UK70N53Sj7(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void InternalEnabledStatusPropertyChanged()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	protected abstract void InternalParseCell(string relativeCellName, CvsCellCollection cells, CvsCellLocation loc);

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void InternalPreParse()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInternalPostParse_003Ed__25))]
	protected virtual Task InternalPostParse(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		U22vRXlycqNmlJZvHjO();
		int num = (jCFQmKlT7aV74Q5kR3V() ? 1 : 4);
		_003CInternalPostParse_003Ed__25 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				break;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = bQHMqRlm8iVkXdlqOYJ();
				num = 3;
				break;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUpdateCellNames_003Ed__28))]
	protected override Task<Dictionary<string, string>> UpdateCellNames(string newToolName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CUpdateCellNames_003Ed__28 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Dictionary<string, string>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.newToolName = newToolName;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	internal virtual bool zFBbb42F97A()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void X62dzvTlqd(CvsCellCollection P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		CvsCellLocation cvsCellLocation = default;
		bool value = default;
		CvsCellRange cellRange = default;
		while (true)
		{
			object obj;
			CvsCell cvsCell;
			switch (num)
			{
			case 8:
				if (cvsCellLocation.IsValid)
				{
					goto case 0;
				}
				goto case 9;
			default:
				num = 0;
				break;
			case 1:
				value = false;
				num = 5;
				break;
			case 2:
			case 4:
				obj = null;
				goto IL_0098;
			case 6:
			case 7:
				value = Parent.WrlAbkIDX4(cvsCellLocation) is GroupTool;
				num = 9;
				break;
			case 10:
				return;
			case 5:
				if (Enabled != null)
				{
					obj = Ouw4G8luNCrbFtvBAAe(P_0, Enabled.CellLocation);
					goto IL_0098;
				}
				_ = 1;
				num = (U22vRXlycqNmlJZvHjO() ? 6 : 4);
				break;
			case 0:
				cellRange = CellRange;
				num = 3;
				if (jCFQmKlT7aV74Q5kR3V())
				{
					break;
				}
				goto case 9;
			case 9:
				IsGrouped = value;
				num = 11;
				break;
			case 3:
				if (!cellRange.Contains(cvsCellLocation))
				{
					goto case 6;
				}
				goto case 9;
			case 11:
				return;
				IL_0098:
				cvsCell = (CvsCell)obj;
				if (cvsCell == null)
				{
					num = 10;
					if (jCFQmKlT7aV74Q5kR3V())
					{
						break;
					}
					goto case 6;
				}
				cvsCellLocation = CvsCellLocation.TryParse((string)dr1K3VlheqwcPgC3wdM(cvsCell));
				num = 8;
				if (jCFQmKlT7aV74Q5kR3V())
				{
					break;
				}
				goto case 5;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEnableInputGraphicValue(bool enable)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		Dictionary<string, object> dictionary = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				if (EnableInputGraphic != null)
				{
					_ = 1;
					if (!U22vRXlycqNmlJZvHjO())
					{
						num = 5;
						if (!U22vRXlycqNmlJZvHjO())
						{
							break;
						}
						goto case 2;
					}
					num = 3;
					break;
				}
				return;
			case 2:
			case 3:
				EnableInputGraphic.WriteViaRun(dictionary, enable);
				goto case 4;
			default:
				num = 4;
				if (true)
				{
					break;
				}
				goto case 4;
			case 4:
				((CvsCogSocketSheet)gKTu2klzWKx9Rouc4TH(OdirmDltYoZcSjFh7PE(InSight))).Run(dictionary);
				num = 6;
				break;
			case 1:
			case 5:
				dictionary = new Dictionary<string, object>();
				goto case 2;
			case 6:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void InitializeAdditionalHelp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnResultsChanged(CvsResultSet results)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CvsCellCollection cvsCellCollection = (CvsCellCollection)uJtMe4gLYjm9yaiShWe(results);
		fshba4gKtr5atVNNZ2x(this, cvsCellCollection);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnResultsChangedTool(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		bool lockTaken = default;
		EzTool ezTool = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				if (!DeleteCommand.IsExecuting)
				{
					_ = 0;
					if (jCFQmKlT7aV74Q5kR3V())
					{
						num = 3;
						break;
					}
					num = 0;
					if (jCFQmKlT7aV74Q5kR3V())
					{
						break;
					}
					goto case 5;
				}
				return;
			default:
				lockTaken = false;
				num = 5;
				break;
			case 1:
			case 3:
				ezTool = this;
				goto default;
			case 5:
				try
				{
					Monitor.Enter(ezTool, ref lockTaken);
					IEnumerator<CellViewModel> enumerator = AllProperties.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							enumerator.Current.Refresh(cells);
						}
					}
					finally
					{
						if (enumerator != null)
						{
							ePvjR5lxaZnl36XMK19(enumerator);
						}
					}
					Q9H8eUg5COTujuM6xHC(this, cells);
					X62dzvTlqd(cells);
					FirePropertyChanged(CdQUGaROfy7He9T0foW.KbIzwHEDLa(4752));
					FirePropertyChanged((string)sQkYZmlURdlespL1ekJ(5054));
					D8wNr1gwZdwCRFgxNVI(this, sQkYZmlURdlespL1ekJ(5096));
					return;
				}
				finally
				{
					if (lockTaken)
					{
						XravMHlMXrwBjYdvKIg(ezTool);
					}
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void RefreshGraphics(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IEnumerator<CellViewModel> enumerator = AllProperties.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				edFbVBhD6RDc8FLg4U edFbVBhD6RDc8FLg4U2 = enumerator.Current as edFbVBhD6RDc8FLg4U;
				_ = 1;
				int num;
				if (!U22vRXlycqNmlJZvHjO())
				{
					num = 2;
					if (U22vRXlycqNmlJZvHjO())
					{
						goto IL_0047;
					}
				}
				else
				{
					num = 3;
					if (1 == 0)
					{
						continue;
					}
				}
				goto IL_008c;
				IL_008c:
				switch (num)
				{
				case 0:
				case 2:
					goto IL_0074;
				case 4:
					continue;
				}
				goto IL_0047;
				IL_0047:
				WLL9hKgeRIApwsNkIRl(edFbVBhD6RDc8FLg4U2, cells, JSZZIBgJPS49notjbAW(Pass), Yb218iga8xNGCPkQZlO(InputImage));
				num = 4;
				if (!jCFQmKlT7aV74Q5kR3V())
				{
					goto IL_0074;
				}
				goto IL_008c;
				IL_0074:
				if (edFbVBhD6RDc8FLg4U2 == null)
				{
					continue;
				}
				goto IL_0047;
			}
		}
		finally
		{
			if (enumerator != null)
			{
				ePvjR5lxaZnl36XMK19(enumerator);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CBindResetCounter_003Ed__163))]
	internal Task hFa6aQHHed()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CBindResetCounter_003Ed__163 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				jCFQmKlT7aV74Q5kR3V();
				num = ((!U22vRXlycqNmlJZvHjO()) ? 1 : 0);
				break;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
				stateMachine._003C_003Et__builder = bQHMqRlm8iVkXdlqOYJ();
				num = 4;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	public abstract CvsEditableDisplayGraphic[] GetViewableEditGraphics();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual CvsEditableDisplayGraphic[] GetEditableGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerable<CvsEditableDisplayGraphic>)tWHPMugOc3f6ultTfx4(this)).Where([MethodImpl(MethodImplOptions.NoInlining)] (CvsEditableDisplayGraphic g) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Array)_003C_003Ec.nStp9DKSMSDQY5gV7MiP(g)).Length != 0;
		}).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CWriteFixturedGraphics_003Ed__166))]
	internal virtual Task WriteFixturedGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		U22vRXlycqNmlJZvHjO();
		int num = ((!jCFQmKlT7aV74Q5kR3V()) ? 4 : 2);
		_003CWriteFixturedGraphics_003Ed__166 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = bQHMqRlm8iVkXdlqOYJ();
				goto case 1;
			case 1:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				continue;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 5;
				if (jCFQmKlT7aV74Q5kR3V())
				{
					continue;
				}
				break;
			case 5:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void RefreshPotentialDependencies()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 13;
		while (true)
		{
			switch (num)
			{
			case 8:
			case 11:
			{
				InputAnnulusViewModel inputAnnulus = InputAnnulus;
				if (inputAnnulus == null)
				{
					goto case 0;
				}
				inputAnnulus.RefreshLinks();
				num = 0;
				break;
			}
			case 3:
			case 10:
			{
				InputRegionViewModel inputRegion = InputRegion;
				if (inputRegion == null)
				{
					num = 12;
					break;
				}
				inputRegion.RefreshLinks();
				goto default;
			}
			case 0:
			{
				InputPlaneViewModel inputPlane = InputPlane;
				if (inputPlane == null)
				{
					num = 6;
					break;
				}
				inputPlane.RefreshLinks();
				goto case 6;
			}
			case 2:
			case 4:
			{
				InputFixtureViewModel inputFixture = InputFixture;
				if (inputFixture != null)
				{
					inputFixture.RefreshLinks();
					num = 10;
					if (jCFQmKlT7aV74Q5kR3V())
					{
						break;
					}
					goto case 8;
				}
				num = 3;
				if (0 == 0)
				{
					break;
				}
				goto default;
			}
			default:
			{
				InputCompositeRegionViewModel inputCompositeRegion = InputCompositeRegion;
				if (inputCompositeRegion == null)
				{
					num = 11;
					break;
				}
				inputCompositeRegion.RefreshLinks();
				num = 8;
				break;
			}
			case 6:
			{
				InputPlaneViewModel inputPlane2 = InputPlane;
				if (inputPlane2 == null)
				{
					num = 14;
					break;
				}
				inputPlane2.MoveDefaultLink();
				return;
			}
			case 13:
				if (InSight != null)
				{
					_ = 0;
					if (jCFQmKlT7aV74Q5kR3V())
					{
						num = 5;
						if (0 == 0)
						{
							break;
						}
						goto case 8;
					}
					num = 9;
					break;
				}
				return;
			case 1:
			case 5:
			{
				InputImageViewModel inputImage = InputImage;
				if (inputImage != null)
				{
					inputImage.RefreshLinks();
					num = 4;
				}
				else
				{
					num = 2;
				}
				break;
			}
			case 14:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void SourceLink_PropertyChanged(object sender, PropertyChangedEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		if (!jCFQmKlT7aV74Q5kR3V())
		{
			goto IL_001e;
		}
		goto IL_009c;
		IL_001e:
		if (!OGNhktgI3b1R56QyUle(e.PropertyName, sQkYZmlURdlespL1ekJ(5136), StringComparison.Ordinal))
		{
			return;
		}
		U22vRXlycqNmlJZvHjO();
		if (jCFQmKlT7aV74Q5kR3V())
		{
			num = 5;
			if (U22vRXlycqNmlJZvHjO())
			{
				goto IL_0059;
			}
		}
		else
		{
			num = 4;
		}
		goto IL_009c;
		IL_009c:
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			default:
				goto IL_0059;
			case 1:
			case 5:
				if (sender == InputImage)
				{
					num = 0;
					continue;
				}
				goto IL_0059;
			case 0:
				CmPLmAgD9TVBjpoMZZQ(Parent);
				goto IL_0059;
			case 6:
				return;
			}
			break;
		}
		goto IL_001e;
		IL_0059:
		FireDependencyChanged();
		num = 6;
		goto IL_009c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnErrorChanged()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void cSI653gThU(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		YXl0pXgiTJLF6RGI3h8(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task ShiftEditGraphics(int delta)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override SourceLink[] GetSourceLinks(CellType reqDataType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 11;
		List<SourceLink> list = default;
		IEnumerable<CellViewModel> enumerable = default;
		QpXw26KT7OGd3H62pw qpXw26KT7OGd3H62pw2 = default;
		IEnumerator<CellViewModel> enumerator = default;
		QpXw26KT7OGd3H62pw qpXw26KT7OGd3H62pw = default;
		while (true)
		{
			switch (num)
			{
			case 13:
				Asl6p0Adp8(list, reqDataType, InputAnnulus);
				break;
			case 1:
				if (reqDataType == CellType.Output)
				{
					num = 6;
					continue;
				}
				if (reqDataType == CellType.Fixture)
				{
					num = 4;
					continue;
				}
				if (reqDataType != CellType.FixtureArray)
				{
					if (reqDataType == CellType.Point)
					{
						goto case 2;
					}
					if (reqDataType == CellType.CompositeRegion)
					{
						goto case 9;
					}
					switch (reqDataType)
					{
					default:
						enumerator = enumerable.GetEnumerator();
						num = 15;
						continue;
					case CellType.Annulus:
						num = 13;
						continue;
					case CellType.Region:
						break;
					}
					num = 14;
					if (0 == 0)
					{
						continue;
					}
					goto case 4;
				}
				num = 10;
				continue;
			case 14:
				Asl6p0Adp8(list, reqDataType, InputRegion);
				num = 5;
				continue;
			case 10:
				enumerator = enumerable.GetEnumerator();
				try
				{
					while (ptop5elHq99H9qYdQU8(enumerator))
					{
						CellViewModel current4 = enumerator.Current;
						if (current4.DataType == CellType.FixtureArray)
						{
							if (current4 is QpXw26KT7OGd3H62pw qpXw26KT7OGd3H62pw3)
							{
								list.Add(qpXw26KT7OGd3H62pw3.SourceLink);
							}
						}
						else
						{
							if (current4.DataType != CellType.FixtureArray)
							{
								continue;
							}
							IEnumerator<FixtureViewModel> enumerator2 = (current4 as FixtureArrayViewModel).Fixtures.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									QpXw26KT7OGd3H62pw current5 = enumerator2.Current;
									U22vRXlycqNmlJZvHjO();
									int num5;
									if (jCFQmKlT7aV74Q5kR3V())
									{
										num5 = 3;
										if (1 == 0)
										{
											goto IL_00f5;
										}
									}
									else
									{
										num5 = 2;
									}
									goto IL_010e;
									IL_010e:
									switch (num5)
									{
									case 0:
									case 3:
										break;
									default:
										goto IL_0137;
									case 4:
										continue;
									}
									goto IL_00f5;
									IL_00f5:
									if (current5 == null)
									{
										continue;
									}
									goto IL_0137;
									IL_0137:
									list.Add(current5.SourceLink);
									num5 = 4;
									goto IL_010e;
								}
							}
							finally
							{
								if (enumerator2 != null)
								{
									ePvjR5lxaZnl36XMK19(enumerator2);
								}
							}
							if (current4 is QpXw26KT7OGd3H62pw qpXw26KT7OGd3H62pw4)
							{
								list.Add((SourceLink)bDIG5egsh1X1Kq5wQmM(qpXw26KT7OGd3H62pw4));
							}
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						ePvjR5lxaZnl36XMK19(enumerator);
					}
				}
				break;
			default:
				num = 2;
				continue;
			case 11:
				list = new List<SourceLink>();
				num = 0;
				continue;
			case 7:
			case 8:
				try
				{
					while (ptop5elHq99H9qYdQU8(enumerator))
					{
						CellViewModel current3 = enumerator.Current;
						_ = 1;
						int num4;
						if (!U22vRXlycqNmlJZvHjO())
						{
							num4 = 6;
						}
						else
						{
							num4 = 3;
							if (U22vRXlycqNmlJZvHjO())
							{
							}
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								list.Add((SourceLink)bDIG5egsh1X1Kq5wQmM(qpXw26KT7OGd3H62pw2));
								num4 = 8;
								continue;
							case 7:
								if (bwqZqlggNbFNm9THERw(current3) != CellType.Fixture)
								{
									num4 = 2;
									continue;
								}
								goto case 5;
							case 5:
								qpXw26KT7OGd3H62pw2 = current3 as QpXw26KT7OGd3H62pw;
								goto case 3;
							case 3:
							case 4:
								if (qpXw26KT7OGd3H62pw2 == null)
								{
									break;
								}
								num4 = 1;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
								if (bwqZqlggNbFNm9THERw(current3) != CellType.Point)
								{
									break;
								}
								goto case 5;
							default:
								num4 = 5;
								if (!U22vRXlycqNmlJZvHjO())
								{
									continue;
								}
								goto case 0;
							case 0:
							case 6:
								if (bwqZqlggNbFNm9THERw(current3) != CellType.Circle)
								{
									num4 = 7;
									continue;
								}
								goto case 5;
							case 8:
								break;
							}
							break;
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						ePvjR5lxaZnl36XMK19(enumerator);
					}
				}
				break;
			case 6:
				enumerator = enumerable.GetEnumerator();
				num = 3;
				continue;
			case 0:
				enumerable = AllProperties.Where([MethodImpl(MethodImplOptions.NoInlining)] (CellViewModel c) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return !_003C_003Ec.mKUh8vKSY8pD83oEQXXj(c);
				});
				num = 1;
				continue;
			case 2:
				enumerator = enumerable.GetEnumerator();
				jCFQmKlT7aV74Q5kR3V();
				num = ((!U22vRXlycqNmlJZvHjO()) ? 7 : 12);
				continue;
			case 3:
				try
				{
					while (ptop5elHq99H9qYdQU8(enumerator))
					{
						CellViewModel current2 = enumerator.Current;
						int num3 = 5;
						while (true)
						{
							switch (num3)
							{
							case 1:
								list.Add(new SourceLink(current2));
								num3 = 7;
								continue;
							case 5:
								if (rKRpY9glXpbXL8ZvXCb(current2))
								{
									num3 = 0;
									continue;
								}
								break;
							case 0:
								if (bwqZqlggNbFNm9THERw(current2) != CellType.Bool)
								{
									_ = 0;
									num3 = ((!jCFQmKlT7aV74Q5kR3V()) ? 6 : 4);
									continue;
								}
								goto case 1;
							case 2:
							case 4:
								if (!(this is MathTool))
								{
									break;
								}
								goto default;
							default:
								if (bwqZqlggNbFNm9THERw(current2) == CellType.Float)
								{
									num3 = 1;
									continue;
								}
								break;
							case 7:
								break;
							}
							break;
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						ePvjR5lxaZnl36XMK19(enumerator);
					}
				}
				break;
			case 9:
			case 12:
				Asl6p0Adp8(list, reqDataType, (InputStructureViewModel)(((object)InputCompositeRegion) ?? ((object)InputRegion)));
				break;
			case 4:
				enumerator = enumerable.GetEnumerator();
				try
				{
					while (ptop5elHq99H9qYdQU8(enumerator))
					{
						CellViewModel current6 = enumerator.Current;
						if (current6.DataType == CellType.Fixture)
						{
							if (current6 is QpXw26KT7OGd3H62pw qpXw26KT7OGd3H62pw5)
							{
								list.Add((SourceLink)bDIG5egsh1X1Kq5wQmM(qpXw26KT7OGd3H62pw5));
							}
						}
						else
						{
							if (current6.DataType != CellType.FixtureArray)
							{
								continue;
							}
							IEnumerator<FixtureViewModel> enumerator2 = (current6 as FixtureArrayViewModel).Fixtures.GetEnumerator();
							try
							{
								while (ptop5elHq99H9qYdQU8(enumerator2))
								{
									QpXw26KT7OGd3H62pw current7 = enumerator2.Current;
									_ = 1;
									int num6 = (U22vRXlycqNmlJZvHjO() ? 2 : 3);
									while (true)
									{
										switch (num6)
										{
										case 0:
										case 3:
											if (current7 != null)
											{
												goto IL_05c7;
											}
											break;
										default:
											goto IL_05c7;
										case 4:
											break;
										}
										break;
										IL_05c7:
										list.Add((SourceLink)bDIG5egsh1X1Kq5wQmM(current7));
										num6 = 4;
									}
								}
							}
							finally
							{
								if (enumerator2 != null)
								{
									ePvjR5lxaZnl36XMK19(enumerator2);
								}
							}
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						ePvjR5lxaZnl36XMK19(enumerator);
					}
				}
				break;
			case 15:
				try
				{
					while (ptop5elHq99H9qYdQU8(enumerator))
					{
						CellViewModel current = enumerator.Current;
						U22vRXlycqNmlJZvHjO();
						int num2 = ((!jCFQmKlT7aV74Q5kR3V()) ? 1 : 3);
						while (true)
						{
							switch (num2)
							{
							default:
								if (qpXw26KT7OGd3H62pw != null)
								{
									num2 = 4;
									continue;
								}
								break;
							case 4:
								list.Add(qpXw26KT7OGd3H62pw.SourceLink);
								num2 = 6;
								continue;
							case 0:
							case 3:
								if (bwqZqlggNbFNm9THERw(current) == reqDataType)
								{
									num2 = 5;
									continue;
								}
								break;
							case 5:
								qpXw26KT7OGd3H62pw = current as QpXw26KT7OGd3H62pw;
								goto default;
							case 6:
								break;
							}
							break;
						}
					}
				}
				finally
				{
					enumerator?.Dispose();
				}
				break;
			case 5:
				break;
			}
			break;
		}
		return list.ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Asl6p0Adp8(List<SourceLink> P_0, CellType P_1, InputStructureViewModel P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if ((P_2 == null || !P_2.IsDefault) && !(this is MathTool))
		{
			return;
		}
		foreach (CellViewModel allProperty in AllProperties)
		{
			if (allProperty.DataType == P_1)
			{
				if (allProperty is QpXw26KT7OGd3H62pw qpXw26KT7OGd3H62pw)
				{
					P_0.Add(qpXw26KT7OGd3H62pw.SourceLink);
				}
			}
			else if (P_1 == CellType.CompositeRegion && allProperty.DataType == CellType.Region && allProperty is QpXw26KT7OGd3H62pw qpXw26KT7OGd3H62pw2)
			{
				P_0.Add(qpXw26KT7OGd3H62pw2.SourceLink);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private void x0g6UwdAAJ(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		base.Name = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void h1w20Ol0n8xJ9J7UcXR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object G453cClFagswVPiiy2t()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ViewModelBroadcaster.Default;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XravMHlMXrwBjYdvKIg(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Monitor.Exit(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Q812VblYmRMh8kt4tu1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzTool)P_0).InitializeAdditionalHelp();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jCFQmKlT7aV74Q5kR3V()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool U22vRXlycqNmlJZvHjO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sQkYZmlURdlespL1ekJ(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ptop5elHq99H9qYdQU8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ePvjR5lxaZnl36XMK19(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder bQHMqRlm8iVkXdlqOYJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xRWtbdlQ4UK70N53Sj7(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzTool)P_0).InternalEnabledStatusPropertyChanged();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xy0e0qlNdsQoXjHSbst(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).OperationProgressManager;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XsSb6Dl2M4r8olEuHyV(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GfemCSlcc5TY69NY5Uo(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UqnDRml1rpboM6OgKpV(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseDelegateCommand)P_0).RaiseCanExecuteChanged();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Ouw4G8luNCrbFtvBAAe(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dr1K3VlheqwcPgC3wdM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OdirmDltYoZcSjFh7PE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).CogSocket;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gKTu2klzWKx9Rouc4TH(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).Sheet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uJtMe4gLYjm9yaiShWe(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsResultSet)P_0).Cells;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fshba4gKtr5atVNNZ2x(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzTool)P_0).OnResultsChangedTool((CvsCellCollection)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Q9H8eUg5COTujuM6xHC(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzTool)P_0).RefreshGraphics((CvsCellCollection)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void D8wNr1gwZdwCRFgxNVI(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JSZZIBgJPS49notjbAW(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BoolViewModel)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation Yb218iga8xNGCPkQZlO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).CellLocation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WLL9hKgeRIApwsNkIRl(object P_0, object P_1, bool P_2, CvsCellLocation P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((edFbVBhD6RDc8FLg4U)P_0).RefreshGraphic((CvsCellCollection)P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tWHPMugOc3f6ultTfx4(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzTool)P_0).GetViewableEditGraphics();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool OGNhktgI3b1R56QyUle(object P_0, object P_1, StringComparison P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CmPLmAgD9TVBjpoMZZQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((InspectStepViewModel)P_0).kuYA6dLHYx();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YXl0pXgiTJLF6RGI3h8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzTool)P_0).OnErrorChanged();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ze5h0VgnHK3FgN6weCb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MLLN2SgVc2gF820HxvL(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzTool)P_0).ResultString;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fCfSwXgfRRqvrdoTJ38()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Fail;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kaUMSAgdP44AaG6sram()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Pass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rKRpY9glXpbXL8ZvXCb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).IsReadOnly;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CellType bwqZqlggNbFNm9THERw(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).DataType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bDIG5egsh1X1Kq5wQmM(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((QpXw26KT7OGd3H62pw)P_0).SourceLink;
	}
}
