using System.Runtime.CompilerServices;
using Cognex.InSight.Remoting.Serialization;

namespace Cognex.InSight.Graphic;

public static class CvsGraphicFactory
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CvsGraphic CreateFromCogSocket(CvsCogShape cogGraphic)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		CvsGraphic result = default;
		if (0 == 0)
		{
			CvsCogInspectEdgePoints cvsCogInspectEdgePoints = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 32:
				{
					CvsGraphicPoint cvsGraphicPoint = new CvsGraphicPoint();
					cvsGraphicPoint.FromSerializableGraphic((CvsCogPoint)cogGraphic);
					result = cvsGraphicPoint;
					num = 37;
					if (0 == 0)
					{
						continue;
					}
					goto IL_05fb;
				}
				case 39:
					goto IL_00be;
				case 8:
					goto IL_0108;
				case 30:
				{
					CvsGraphicArc cvsGraphicArc = new CvsGraphicArc();
					KeQCwcrKwxtCZ7wDyUJ(cvsGraphicArc, (CvsCogArc)cogGraphic);
					result = cvsGraphicArc;
					goto IL_05fb;
				}
				case 29:
					goto IL_014b;
				case 26:
				{
					CvsGraphicMaskedRegion cvsGraphicMaskedRegion = new CvsGraphicMaskedRegion();
					pS1Z3erPME34im3FKYe(cvsGraphicMaskedRegion, (CvsCogMaskedRegion)cogGraphic);
					result = cvsGraphicMaskedRegion;
					num = 3;
					continue;
				}
				case 9:
				{
					CvsGraphicPolygon cvsGraphicPolygon = new CvsGraphicPolygon();
					DOcO6prehYGc0rP0tHX(cvsGraphicPolygon, (CvsCogPolygon)cogGraphic);
					result = cvsGraphicPolygon;
					num = 5;
					if (true)
					{
						continue;
					}
					goto IL_05fb;
				}
				case 14:
				case 23:
				{
					CvsGraphicCross cvsGraphicCross = new CvsGraphicCross();
					q6NtrlrYKo1w9xXtdEm(cvsGraphicCross, (CvsCogCross)cogGraphic);
					result = cvsGraphicCross;
					num = 28;
					continue;
				}
				case 31:
					goto IL_0215;
				case 2:
					goto IL_022e;
				case 6:
					goto IL_0244;
				case 21:
				{
					CvsGraphicPolylinePath cvsGraphicPolylinePath = new CvsGraphicPolylinePath();
					pS1Z3erPME34im3FKYe(cvsGraphicPolylinePath, (CvsCogPolylinePath)cogGraphic);
					result = cvsGraphicPolylinePath;
					num = 33;
					continue;
				}
				case 25:
					goto IL_02f1;
				default:
					num = 8;
					continue;
				case 18:
					goto IL_03d8;
				case 7:
				{
					CvsGraphicBeadPathMask cvsGraphicBeadPathMask = new CvsGraphicBeadPathMask();
					cvsGraphicBeadPathMask.FromSerializableGraphic((CvsCogBeadPathMask)cogGraphic);
					result = cvsGraphicBeadPathMask;
					num = 40;
					if (true)
					{
						continue;
					}
					goto case 10;
				}
				case 10:
				{
					CvsGraphicText cvsGraphicText = new CvsGraphicText();
					jsF5JyrIADVRVW5RO2L(cvsGraphicText, (CvsCogText)cogGraphic);
					result = cvsGraphicText;
					goto IL_05fb;
				}
				case 15:
					goto IL_0483;
				case 17:
					goto IL_04b5;
				case 24:
				{
					CvsGraphicLine cvsGraphicLine = new CvsGraphicLine();
					JRlRM6rQ5eWcQwaT8mI(cvsGraphicLine, (CvsCogLine)cogGraphic);
					result = cvsGraphicLine;
					goto IL_05fb;
				}
				case 27:
				{
					CvsGraphicRegion cvsGraphicRegion = new CvsGraphicRegion();
					cvsGraphicRegion.FromSerializableGraphic((CvsCogRegion)cogGraphic);
					result = cvsGraphicRegion;
					goto IL_05fb;
				}
				case 13:
					goto IL_0547;
				case 1:
				{
					CvsGraphicCircle cvsGraphicCircle = new CvsGraphicCircle();
					WcG0a7rotbKZ8hvjpt7(cvsGraphicCircle, (CvsCogCircle)cogGraphic);
					result = cvsGraphicCircle;
					num = 11;
					continue;
				}
				case 3:
				case 4:
				case 5:
				case 11:
				case 12:
				case 16:
				case 19:
				case 20:
				case 22:
				case 28:
				case 33:
				case 34:
				case 35:
				case 36:
				case 37:
				case 38:
				case 40:
					goto IL_05fb;
				}
				break;
				IL_03d8:
				if (cogGraphic is CvsCogMaskedRegion)
				{
					num = 26;
				}
				else if (!(cogGraphic is CvsCogPolylinePath))
				{
					CvsGraphicComposite cvsGraphicComposite = new CvsGraphicComposite(mustBeExtrudeable: false);
					pS1Z3erPME34im3FKYe(cvsGraphicComposite, (CvsCogCompositeRegion)cogGraphic);
					result = cvsGraphicComposite;
					num = 12;
				}
				else
				{
					num = 21;
				}
				continue;
				IL_0215:
				return null;
				IL_02f1:
				CvsGraphicFixture cvsGraphicFixture = new CvsGraphicFixture();
				A6b0u6r1a4lZeWIIG5x(cvsGraphicFixture, (CvsCogFixture)cogGraphic);
				result = cvsGraphicFixture;
				goto IL_05fb;
				IL_0547:
				CvsGraphic4Side cvsGraphic4Side = new CvsGraphic4Side();
				fdpUQarCUx0ugctC21n(cvsGraphic4Side, (CvsCog4Side)cogGraphic);
				result = cvsGraphic4Side;
				goto IL_05fb;
				IL_04b5:
				CvsGraphicFeatureModel cvsGraphicFeatureModel = new CvsGraphicFeatureModel();
				rH0slgrxOyojhDiJY7w(cvsGraphicFeatureModel, (CvsCogFeatureModel)cogGraphic);
				result = cvsGraphicFeatureModel;
				num = 22;
				continue;
				IL_022e:
				if (cogGraphic != null)
				{
					result = null;
					if (cogGraphic is CvsCog4Side)
					{
						num = 13;
						continue;
					}
					if (!(cogGraphic is CvsCogAnnulus))
					{
						if (!(cogGraphic is CvsCogArc))
						{
							if (!(cogGraphic is CvsCogBlobChain))
							{
								if (cogGraphic is CvsCogCheckArea)
								{
									CvsGraphicCheckArea cvsGraphicCheckArea = new CvsGraphicCheckArea();
									ITB439r5lpsPcdqiito(cvsGraphicCheckArea, (CvsCogCheckArea)cogGraphic);
									result = cvsGraphicCheckArea;
								}
								else if (cogGraphic is CvsCogCircle)
								{
									num = 1;
									if (true)
									{
										continue;
									}
								}
								else
								{
									if (cogGraphic is CvsCogCompositeRegion)
									{
										num = 18;
										if (0 == 0)
										{
											continue;
										}
										goto IL_00be;
									}
									if (cogGraphic is CvsCogCross)
									{
										_ = 0;
										if (zW0TFvr73gIPIFGqPqo())
										{
											num = 23;
											continue;
										}
										num = 4;
										if (true)
										{
											continue;
										}
										goto IL_0547;
									}
									if (cogGraphic is CvsCogFeature)
									{
										CvsGraphicFeature cvsGraphicFeature = new CvsGraphicFeature();
										ltCoa4rNgL91exgvYE1(cvsGraphicFeature, (CvsCogFeature)cogGraphic);
										result = cvsGraphicFeature;
										num = 20;
										continue;
									}
									if (cogGraphic is CvsCogFeatureModel)
									{
										num = 17;
										if (zW0TFvr73gIPIFGqPqo())
										{
											continue;
										}
									}
									else
									{
										if (cogGraphic is CvsCogFixture)
										{
											num = 25;
											if (zW0TFvr73gIPIFGqPqo())
											{
												continue;
											}
											goto IL_02f1;
										}
										if (cogGraphic is CvsCogInspectEdgePoints)
										{
											goto IL_0108;
										}
										if (!(cogGraphic is CvsCogLine))
										{
											if (cogGraphic is CvsCogPoint)
											{
												num = 32;
												continue;
											}
											if (cogGraphic is CvsCogPolyline)
											{
												num = 39;
												if (zW0TFvr73gIPIFGqPqo())
												{
													continue;
												}
												goto IL_0483;
											}
											if (!(cogGraphic is CvsCogPolygon))
											{
												if (cogGraphic is CvsCogFilledBox)
												{
													num = 29;
													continue;
												}
												if (cogGraphic is CvsCogRegion)
												{
													num = 27;
													if (0 == 0)
													{
														continue;
													}
													goto IL_0215;
												}
												if (cogGraphic is CvsCogText)
												{
													num = 10;
													continue;
												}
												if (cogGraphic is CvsCogLineList)
												{
													num = 15;
													continue;
												}
												if (cogGraphic is CvsCogBeadPathMask)
												{
													num = 7;
													if (zW0TFvr73gIPIFGqPqo())
													{
														continue;
													}
													goto IL_04b5;
												}
											}
											else
											{
												num = 9;
												if (0 == 0)
												{
													continue;
												}
											}
										}
										else
										{
											num = 24;
											if (true)
											{
												continue;
											}
										}
									}
								}
								goto IL_05fb;
							}
							num = 0;
							if (zW0TFvr73gIPIFGqPqo())
							{
								continue;
							}
							goto IL_014b;
						}
						num = 30;
						continue;
					}
					CvsGraphicAnnulus cvsGraphicAnnulus = new CvsGraphicAnnulus();
					cvsGraphicAnnulus.FromSerializableGraphic((CvsCogAnnulus)cogGraphic);
					result = cvsGraphicAnnulus;
					num = 19;
					if (PEBZtirtMjpefJI1aRA())
					{
					}
					continue;
				}
				num = 31;
				if (!PEBZtirtMjpefJI1aRA())
				{
					continue;
				}
				goto IL_0244;
				IL_014b:
				CvsGraphicFilledBox cvsGraphicFilledBox = new CvsGraphicFilledBox();
				Und5LMruRBInEMUgV7r(cvsGraphicFilledBox, (CvsCogFilledBox)cogGraphic);
				result = cvsGraphicFilledBox;
				num = 36;
				continue;
				IL_0244:
				switch (jOmkpArr7DcuKtoD3Is(cvsCogInspectEdgePoints))
				{
				case InspectEdgePointType.Edge:
				{
					CvsGraphicEdgePoints cvsGraphicEdgePoints = new CvsGraphicEdgePoints();
					TAamDCr3yZ4elhavPq4(cvsGraphicEdgePoints, cvsCogInspectEdgePoints);
					result = cvsGraphicEdgePoints;
					num = 16;
					continue;
				}
				default:
					num = 35;
					continue;
				case InspectEdgePointType.Defect:
					break;
				case InspectEdgePointType.Extreme:
				{
					CvsGraphicExtremePoints cvsGraphicExtremePoints = new CvsGraphicExtremePoints();
					KIVXvgrO79B3I7sMXoB(cvsGraphicExtremePoints, cvsCogInspectEdgePoints);
					result = cvsGraphicExtremePoints;
					num = 38;
					continue;
				}
				}
				CvsGraphicDefectPoints cvsGraphicDefectPoints = new CvsGraphicDefectPoints();
				vLk1NArM4U6enmpRUIX(cvsGraphicDefectPoints, cvsCogInspectEdgePoints);
				result = cvsGraphicDefectPoints;
				goto IL_05fb;
				IL_00be:
				CvsGraphicPolyline cvsGraphicPolyline = new CvsGraphicPolyline();
				RGokFIrl1WpsSo8FxEg(cvsGraphicPolyline, (CvsCogPolyline)cogGraphic);
				result = cvsGraphicPolyline;
				goto IL_05fb;
				IL_0108:
				cvsCogInspectEdgePoints = (CvsCogInspectEdgePoints)cogGraphic;
				num = 6;
				continue;
				IL_0483:
				CvsGraphicLineList cvsGraphicLineList = new CvsGraphicLineList();
				aBwqj3rRyy8rv4Evo94(cvsGraphicLineList, (CvsCogLineList)cogGraphic);
				result = cvsGraphicLineList;
				goto IL_05fb;
			}
		}
		CvsGraphicBlob cvsGraphicBlob = new CvsGraphicBlob();
		cvsGraphicBlob.FromSerializableGraphic((CvsCogBlobChain)cogGraphic);
		result = cvsGraphicBlob;
		goto IL_05fb;
		IL_05fb:
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fdpUQarCUx0ugctC21n(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphic4Side)P_0).FromSerializableGraphic((CvsCog4Side)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KeQCwcrKwxtCZ7wDyUJ(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicArc)P_0).FromSerializableGraphic((CvsCogArc)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ITB439r5lpsPcdqiito(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicCheckArea)P_0).FromSerializableGraphic((CvsCogCheckArea)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WcG0a7rotbKZ8hvjpt7(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicCircle)P_0).FromSerializableGraphic((CvsCogCircle)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pS1Z3erPME34im3FKYe(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicCompositeBase)P_0).FromSerializableGraphic((CvsCogCompositeRegion)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void q6NtrlrYKo1w9xXtdEm(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicCross)P_0).FromSerializableGraphic((CvsCogCross)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ltCoa4rNgL91exgvYE1(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicFeature)P_0).FromSerializableGraphic((CvsCogFeature)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rH0slgrxOyojhDiJY7w(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicFeatureModel)P_0).FromSerializableGraphic((CvsCogFeatureModel)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void A6b0u6r1a4lZeWIIG5x(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicFixture)P_0).FromSerializableGraphic((CvsCogFixture)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static InspectEdgePointType jOmkpArr7DcuKtoD3Is(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogInspectEdgePoints)P_0).PointType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TAamDCr3yZ4elhavPq4(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicEdgePoints)P_0).FromSerializableGraphic((CvsCogInspectEdgePoints)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KIVXvgrO79B3I7sMXoB(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicExtremePoints)P_0).FromSerializableGraphic((CvsCogInspectEdgePoints)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vLk1NArM4U6enmpRUIX(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicDefectPoints)P_0).FromSerializableGraphic((CvsCogInspectEdgePoints)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JRlRM6rQ5eWcQwaT8mI(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicLine)P_0).FromSerializableGraphic((CvsCogLine)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RGokFIrl1WpsSo8FxEg(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicPolyline)P_0).FromSerializableGraphic((CvsCogPolyline)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DOcO6prehYGc0rP0tHX(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicPolygon)P_0).FromSerializableGraphic((CvsCogPolygon)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Und5LMruRBInEMUgV7r(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicFilledBox)P_0).FromSerializableGraphic((CvsCogFilledBox)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jsF5JyrIADVRVW5RO2L(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicText)P_0).FromSerializableGraphic((CvsCogText)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aBwqj3rRyy8rv4Evo94(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsGraphicLineList)P_0).FromSerializableGraphic((CvsCogLineList)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zW0TFvr73gIPIFGqPqo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool PEBZtirtMjpefJI1aRA()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}
}
