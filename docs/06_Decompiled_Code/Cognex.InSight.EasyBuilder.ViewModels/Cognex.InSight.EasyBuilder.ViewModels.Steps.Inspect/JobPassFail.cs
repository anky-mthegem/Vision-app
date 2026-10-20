using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Diagnostics.Logging;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.Runtime.ViewModels.Cells;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect;

public class JobPassFail : EzSupportSnippet, IPassFailCounters
{
	private static class lTsoWVAKtRoiQqJ1a9
	{
	}

	private string geQdSIgVlK;

	protected static readonly ILogger Log;

	[CompilerGenerated]
	private BoolViewModel YPadDd0Pbl;

	[CompilerGenerated]
	private BoolViewModel Wajd3SQunS;

	[CompilerGenerated]
	private BoolViewModel xJgdICJ6iq;

	[CompilerGenerated]
	private IntViewModel HZddfD0tmj;

	[CompilerGenerated]
	private IntViewModel EBwdEfRdOu;

	[CompilerGenerated]
	private IntViewModel WZVdbD7QqQ;

	[CompilerGenerated]
	private IntViewModel HEpdccZ0p2;

	[CompilerGenerated]
	private ButtonViewModel aO0dQjZall;

	[CompilerGenerated]
	private JobExecutionTimeViewModel oU5dghdALy;

	public override string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.d4k0UatuZI();
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
			return YPadDd0Pbl;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			YPadDd0Pbl = value;
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
			return Wajd3SQunS;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Wajd3SQunS = value;
		}
	}

	public BoolViewModel ToolsPass
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xJgdICJ6iq;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xJgdICJ6iq = value;
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
			return HZddfD0tmj;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZddfD0tmj = value;
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
			return EBwdEfRdOu;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EBwdEfRdOu = value;
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
			return WZVdbD7QqQ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			WZVdbD7QqQ = value;
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
			return HEpdccZ0p2;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HEpdccZ0p2 = value;
		}
	}

	public ButtonViewModel ResetCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aO0dQjZall;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			aO0dQjZall = value;
		}
	}

	public JobExecutionTimeViewModel ExecutionTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return oU5dghdALy;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			oU5dghdALy = value;
		}
	}

	public double Rate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return bWFdUe4tGR();
		}
	}

	public string ResultString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (!sY8CJifwmQjmJMEIM9L(Pass))
			{
				return (string)OARoFuVMpiQ19bq5k7K();
			}
			return (string)rx7T6mVFZLRlCBqhJ4V();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public JobPassFail(AppStepViewModel appStepVm)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Q39k5QVW0qOCKpdYiEB();
		base._002Ector(appStepVm);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Task Parse(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0436;
		IL_001a:
		RemoveAllProperties();
		_ = 1;
		if (!yOE3YSVR1U6ZLEE8cu5())
		{
			num = 0;
		}
		else
		{
			num = 5;
			if (false)
			{
				goto IL_047c;
			}
		}
		goto IL_0436;
		IL_047c:
		return Task.CompletedTask;
		IL_0436:
		IEnumerator<CvsCellLocation> enumerator = default;
		CvsCell cvsCell = default;
		string name = default;
		CvsCellRange cellRange = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 4:
				try
				{
					while (Jha6jQVQHKZGZ6rIIEO(enumerator))
					{
						CvsCellLocation current = enumerator.Current;
						int num2 = 1;
						while (true)
						{
							switch (num2)
							{
							case 1:
								cvsCell = (CvsCell)DD8OsyVTBdGgwo6eipQ(cells, current);
								num2 = 0;
								continue;
							case 15:
								FailCount = new IntViewModel(InSight, cells, current, (string)Dy5MjVVHfkTZm2lQF5Q());
								num2 = 21;
								if (true)
								{
									continue;
								}
								goto case 14;
							case 14:
								name = cvsCell.Name;
								_ = cvsCell.Expression;
								num2 = 9;
								continue;
							case 13:
								ToolsPass = new BoolViewModel(InSight, cells, current, (string)BZxvoaVY6x5rRt4uUvt());
								num2 = 10;
								continue;
							case 9:
								if (name == null)
								{
									break;
								}
								num2 = 22;
								if (0 == 0)
								{
									continue;
								}
								goto case 21;
							case 21:
								AddProperty(FailCount);
								num2 = 12;
								continue;
							case 19:
							case 20:
								ResetCommand = new ButtonViewModel(InSight, cells, current, Resources.Reset);
								AddProperty(ResetCommand);
								num2 = 23;
								if (yOE3YSVR1U6ZLEE8cu5())
								{
								}
								continue;
							case 17:
								AddProperty(TotalCount);
								break;
							case 18:
								TotalCount = new IntViewModel(InSight, cells, current, (string)Nw9N4IVm7fgq7bImDB0());
								num2 = 17;
								continue;
							case 0:
								if (cvsCell != null)
								{
									num2 = 14;
									continue;
								}
								break;
							case 5:
								Pass = new BoolViewModel(InSight, cells, current, (string)rx7T6mVFZLRlCBqhJ4V());
								num2 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto case 11;
							case 11:
								AddProperty(PassCount);
								num2 = 2;
								continue;
							case 8:
							case 16:
								ErrorCount = new IntViewModel(InSight, cells, current, (string)Fw3mUUVx4UCSpUGIM2u());
								AddProperty(ErrorCount);
								num2 = 6;
								if (true)
								{
									continue;
								}
								goto case 3;
							case 3:
								PassCount = new IntViewModel(InSight, cells, current, (string)EL7R3EVUQop5Caxb8PQ());
								goto case 11;
							default:
								num2 = 11;
								continue;
							case 4:
								AddProperty(Pass);
								num2 = 7;
								continue;
							case 22:
								if (!Ge8dFMV0VKVk68hgvH4(name, UymWiRVyHampxv03KHh(4536), StringComparison.Ordinal))
								{
									if (Ge8dFMV0VKVk68hgvH4(name, UymWiRVyHampxv03KHh(4556), StringComparison.Ordinal))
									{
										Fail = new BoolViewModel(InSight, cells, current, (string)OARoFuVMpiQ19bq5k7K());
										AddProperty(Fail);
										break;
									}
									if (!Ge8dFMV0VKVk68hgvH4(name, UymWiRVyHampxv03KHh(4576), StringComparison.Ordinal))
									{
										if (Ge8dFMV0VKVk68hgvH4(name, UymWiRVyHampxv03KHh(4606), StringComparison.Ordinal))
										{
											num2 = 3;
											if (!yOE3YSVR1U6ZLEE8cu5())
											{
												continue;
											}
											goto case 15;
										}
										if (!name.EndsWith(CdQUGaROfy7He9T0foW.KbIzwHEDLa(4636), StringComparison.Ordinal))
										{
											if (!Ge8dFMV0VKVk68hgvH4(name, UymWiRVyHampxv03KHh(4666), StringComparison.Ordinal))
											{
												if (Ge8dFMV0VKVk68hgvH4(name, UymWiRVyHampxv03KHh(4698), StringComparison.Ordinal))
												{
													num2 = 18;
													if (true)
													{
														continue;
													}
													goto case 1;
												}
												if (!name.EndsWith((string)UymWiRVyHampxv03KHh(4730), StringComparison.Ordinal))
												{
													break;
												}
												goto case 19;
											}
											_ = 1;
											if (!yOE3YSVR1U6ZLEE8cu5())
											{
												num2 = 8;
												continue;
											}
											num2 = 19;
											if (true)
											{
												continue;
											}
											goto case 18;
										}
										num2 = 15;
										if (pHgtbyVAAFvSGl52Rhe())
										{
											continue;
										}
										goto case 17;
									}
									num2 = 13;
									continue;
								}
								num2 = 5;
								if (0 == 0)
								{
									continue;
								}
								break;
							case 2:
							case 6:
							case 7:
							case 10:
							case 12:
							case 23:
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
						QgqP8UVNCfmaIDtXXJf(enumerator);
					}
				}
				ExecutionTime = new JobExecutionTimeViewModel(InSight, cells, Resources.ExecutionTime);
				num = 6;
				continue;
			case 2:
			case 5:
				enumerator = cellRange.GetEnumerator();
				goto case 4;
			default:
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 1:
				cellRange = CellRange;
				goto case 2;
			case 6:
				goto IL_047c;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnResultsChanged(CvsResultSet results)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		yOE3YSVR1U6ZLEE8cu5();
		int num;
		if (pHgtbyVAAFvSGl52Rhe())
		{
			num = 2;
			if (yOE3YSVR1U6ZLEE8cu5())
			{
			}
		}
		else
		{
			num = 3;
			if (1 == 0)
			{
				goto IL_007f;
			}
		}
		bool lockTaken = default;
		JobPassFail jobPassFail = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				lockTaken = false;
				break;
			default:
				num = 4;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				jobPassFail = this;
				goto case 1;
			case 4:
				break;
			}
			break;
		}
		goto IL_007f;
		IL_007f:
		try
		{
			Monitor.Enter(jobPassFail, ref lockTaken);
			int num2 = 3;
			CvsCellCollection cells = default;
			string text = default;
			while (true)
			{
				switch (num2)
				{
				case 3:
					cells = (CvsCellCollection)x0dPlHV2nE9hO0sFnhn(results);
					_ = 1;
					if (!yOE3YSVR1U6ZLEE8cu5())
					{
						num2 = 0;
						if (0 == 0)
						{
							break;
						}
						goto case 0;
					}
					num2 = 2;
					if (true)
					{
						break;
					}
					goto case 6;
				case 0:
				case 1:
					text = (string)Xpy6KoVcCJKqESemCIM(results, null);
					num2 = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 8;
				case 8:
					if (!SsuUcJV1qBcF0Cqgjdd(geQdSIgVlK, text))
					{
						goto case 7;
					}
					goto default;
				case 6:
					Refresh(cells);
					num2 = 8;
					break;
				case 7:
					FFXloGVuLisVOkp5Zm8(this, CdQUGaROfy7He9T0foW.KbIzwHEDLa(4752));
					num2 = 9;
					if (true)
					{
						break;
					}
					goto case 5;
				case 5:
				{
					JobExecutionTimeViewModel executionTime = ExecutionTime;
					if (executionTime != null)
					{
						executionTime.wW5xSDCNSa();
						goto case 7;
					}
					num2 = 7;
					break;
				}
				default:
					geQdSIgVlK = text;
					num2 = 5;
					break;
				case 9:
					FirePropertyChanged(CdQUGaROfy7He9T0foW.KbIzwHEDLa(4780));
					return;
				}
			}
		}
		finally
		{
			if (lockTaken)
			{
				WEiBMbVhMsSiQVHYwfr(jobPassFail);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Refresh(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IEnumerator<CellViewModel> enumerator = Properties.GetEnumerator();
		try
		{
			while (Jha6jQVQHKZGZ6rIIEO(enumerator))
			{
				enumerator.Current.Refresh(cells);
			}
		}
		finally
		{
			if (enumerator != null)
			{
				QgqP8UVNCfmaIDtXXJf(enumerator);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override SourceLink[] GetSourceLinks(CellType reqDataType)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		yOE3YSVR1U6ZLEE8cu5();
		int num;
		if (pHgtbyVAAFvSGl52Rhe())
		{
			num = 2;
		}
		else
		{
			num = 3;
			if (yOE3YSVR1U6ZLEE8cu5())
			{
			}
		}
		List<SourceLink> list = default;
		IEnumerator<CellViewModel> enumerator = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				list = new List<SourceLink>();
				goto case 1;
			case 4:
				enumerator = Properties.GetEnumerator();
				num = 5;
				continue;
			case 1:
			case 3:
				if (reqDataType != CellType.Output)
				{
					break;
				}
				goto case 4;
			default:
				num = 4;
				continue;
			case 5:
				try
				{
					while (Jha6jQVQHKZGZ6rIIEO(enumerator))
					{
						CellViewModel current = enumerator.Current;
						yOE3YSVR1U6ZLEE8cu5();
						int num2;
						if (pHgtbyVAAFvSGl52Rhe())
						{
							num2 = 4;
						}
						else
						{
							num2 = 1;
							if (!pHgtbyVAAFvSGl52Rhe())
							{
								goto IL_0131;
							}
						}
						goto IL_00fe;
						IL_0131:
						list.Add(new SourceLink(current));
						num2 = 5;
						if (1 == 0)
						{
							continue;
						}
						goto IL_00fe;
						IL_00fe:
						while (true)
						{
							switch (num2)
							{
							case 0:
							case 4:
								if (!duTsjWVt8pqwKHEAULK(current))
								{
									goto IL_0149;
								}
								num2 = 3;
								if (pHgtbyVAAFvSGl52Rhe())
								{
									continue;
								}
								goto case 3;
							case 3:
								if (IKbsnDVzNahLAK8CYsb(current) != CellType.Bool)
								{
									goto IL_0149;
								}
								break;
							case 5:
								goto IL_0149;
							}
							break;
						}
						goto IL_0131;
						IL_0149:;
					}
				}
				finally
				{
					enumerator?.Dispose();
				}
				break;
			}
			break;
		}
		return (SourceLink[])ESCQ2TfLmEuVOaXYa6M(list);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private double bWFdUe4tGR()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 9;
		if (!yOE3YSVR1U6ZLEE8cu5())
		{
		}
		int? num3 = default;
		double num2 = default;
		double num5 = default;
		double num6 = default;
		while (true)
		{
			int? num7;
			int? num4;
			double num8;
			double num10;
			IntViewModel totalCount;
			int? num9;
			switch (num)
			{
			default:
				num7 = num3;
				goto IL_0033;
			case 3:
				num3 = null;
				num = 1;
				break;
			case 9:
			{
				IntViewModel passCount = PassCount;
				if (passCount == null)
				{
					num = 3;
					break;
				}
				num4 = passCount.Value;
				goto IL_0127;
			}
			case 8:
				num8 = 0.0;
				goto IL_0089;
			case 0:
				num10 = 0.0;
				goto IL_00c5;
			case 2:
				try
				{
					num2 = num5 / num6;
				}
				catch (Exception ex)
				{
					rqldAefK8MwFydNDeVd(Log, LogLevel.Debug, UymWiRVyHampxv03KHh(4792), ex);
				}
				if (!CaUnGXf5VolwmSZm0tw(num2))
				{
					num = 10;
					break;
				}
				return 0.0;
			case 1:
				num4 = num3;
				goto IL_0127;
			case 4:
			case 7:
				num3 = null;
				goto default;
			case 10:
				{
					return num2;
				}
				IL_0089:
				num5 = num8;
				totalCount = TotalCount;
				if (totalCount != null)
				{
					num7 = totalCount.Value;
					goto IL_0033;
				}
				_ = 0;
				if (pHgtbyVAAFvSGl52Rhe())
				{
					num = 7;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				}
				num = 6;
				break;
				IL_0033:
				num9 = num7;
				if (!num9.HasValue)
				{
					num = 0;
					break;
				}
				num10 = num9.GetValueOrDefault();
				goto IL_00c5;
				IL_0127:
				num9 = num4;
				if (num9.HasValue)
				{
					num8 = num9.GetValueOrDefault();
					goto IL_0089;
				}
				num = 8;
				break;
				IL_00c5:
				num6 = num10;
				num2 = 0.0;
				num = 2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static JobPassFail()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Q39k5QVW0qOCKpdYiEB();
		Log = LogManager.GetLogger<JobPassFail>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Q39k5QVW0qOCKpdYiEB()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pHgtbyVAAFvSGl52Rhe()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool yOE3YSVR1U6ZLEE8cu5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DD8OsyVTBdGgwo6eipQ(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UymWiRVyHampxv03KHh(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Ge8dFMV0VKVk68hgvH4(object P_0, object P_1, StringComparison P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).EndsWith((string)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rx7T6mVFZLRlCBqhJ4V()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Pass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OARoFuVMpiQ19bq5k7K()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Fail;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BZxvoaVY6x5rRt4uUvt()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.cnurzp4TWS();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EL7R3EVUQop5Caxb8PQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.PassCount;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Dy5MjVVHfkTZm2lQF5Q()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.FailCount;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Fw3mUUVx4UCSpUGIM2u()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.ErrorCount;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Nw9N4IVm7fgq7bImDB0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.TotalCount;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Jha6jQVQHKZGZ6rIIEO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QgqP8UVNCfmaIDtXXJf(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object x0dPlHV2nE9hO0sFnhn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsResultSet)P_0).Cells;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Xpy6KoVcCJKqESemCIM(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsResultSet)P_0).GetPrimaryImageUrl((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool SsuUcJV1qBcF0Cqgjdd(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 != (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FFXloGVuLisVOkp5Zm8(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChanged((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WEiBMbVhMsSiQVHYwfr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Monitor.Exit(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool duTsjWVt8pqwKHEAULK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).IsReadOnly;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CellType IKbsnDVzNahLAK8CYsb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CellViewModel)P_0).DataType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ESCQ2TfLmEuVOaXYa6M(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<SourceLink>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rqldAefK8MwFydNDeVd(object P_0, LogLevel P_1, object P_2, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ILogger)P_0).LogException(P_1, (string)P_2, (Exception)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CaUnGXf5VolwmSZm0tw(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return double.IsNaN(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sY8CJifwmQjmJMEIM9L(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((BoolViewModel)P_0).Value;
	}
}
