using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.InSight.Cell;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.Runtime.ViewModels;
using Cognex.Mvvm;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Communication;

public class WriteDataSerial : EzFormatStringSupportSnippet
{
	private static class wCoCnGRaexh2Beru4D8
	{
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDisposeAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncValueTaskMethodBuilder _003C_003Et__builder;

		public WriteDataSerial _003C_003E4__this;

		private ValueTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (bTQXFW5gDP3ctOSWgeiQ())
			{
				num = 3;
			}
			else
			{
				num = 2;
				if (1 == 0)
				{
					goto IL_003d;
				}
			}
			goto IL_01ac;
			IL_01ea:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (1 == 0)
			{
				return;
			}
			goto IL_01ac;
			IL_003d:
			int num2 = default;
			WriteDataSerial writeDataSerial = default;
			try
			{
				int num3;
				if (num2 != 0)
				{
					writeDataSerial.aYUPyQ6amN();
					num3 = 7;
					goto IL_006e;
				}
				ValueTaskAwaiter awaiter = _003C_003Eu__1;
				goto IL_013e;
				IL_013e:
				_003C_003Eu__1 = default;
				num3 = 0;
				goto IL_006e;
				IL_006e:
				ValueTask valueTask = default;
				while (true)
				{
					switch (num3)
					{
					case 8:
						num2 = (_003C_003E1__state = 0);
						goto case 3;
					default:
						num3 = 3;
						continue;
					case 4:
					case 5:
						return;
					case 7:
						valueTask = writeDataSerial.COHPxViCd3();
						num3 = 1;
						continue;
					case 0:
						num2 = (_003C_003E1__state = -1);
						num3 = 10;
						continue;
					case 3:
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						XbLdyn5giRNZIw853nk3();
						if (!bTQXFW5gDP3ctOSWgeiQ())
						{
							num3 = 2;
							continue;
						}
						num3 = 4;
						if (XbLdyn5giRNZIw853nk3())
						{
						}
						continue;
					case 1:
						awaiter = valueTask.GetAwaiter();
						num3 = 9;
						if (XbLdyn5giRNZIw853nk3())
						{
						}
						continue;
					case 2:
					case 6:
						break;
					case 9:
						if (!awaiter.IsCompleted)
						{
							num3 = 8;
							continue;
						}
						goto case 10;
					case 10:
						awaiter.GetResult();
						goto end_IL_006e;
					}
					goto IL_013e;
					continue;
					end_IL_006e:
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
			goto IL_01ea;
			IL_01ac:
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					break;
				default:
					num = 5;
					if (true)
					{
						continue;
					}
					goto case 1;
				case 1:
				case 2:
					writeDataSerial = _003C_003E4__this;
					num = 4;
					continue;
				case 5:
					goto IL_01ea;
				case 6:
					return;
				}
				break;
			}
			goto IL_003d;
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
		internal static bool bTQXFW5gDP3ctOSWgeiQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XbLdyn5giRNZIw853nk3()
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
	private struct _003CEnableSource_SourcePropertyChanged_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public WriteDataSerial _003C_003E4__this;

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
			_ = 0;
			int num = ((!an5hGi5gnsIXff1urqIP()) ? 4 : 5);
			int num2 = default;
			WriteDataSerial writeDataSerial = default;
			TaskAwaiter awaiter = default;
			PropertyLinks propertyLinks = default;
			CellViewModel cellViewModel = default;
			do
			{
				IL_01f8:
				switch (num)
				{
				case 2:
					_003C_003Et__builder.SetResult();
					num = 6;
					goto IL_01f8;
				case 3:
					try
					{
						int num3;
						object obj2;
						if (num2 != 0)
						{
							AppStepViewModel parent = writeDataSerial.Parent;
							if (parent == null)
							{
								num3 = 4;
							}
							else
							{
								object obj = UamrPr5gfMaJ5q6ebwYP(parent);
								if (obj != null)
								{
									obj2 = ((EasyBuilderApplicationViewModel)obj).PropertyLinks;
									goto IL_0199;
								}
								num3 = 8;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 11;
						}
						goto IL_00a9;
						IL_0199:
						propertyLinks = (PropertyLinks)obj2;
						if (propertyLinks != null)
						{
							_ = 0;
							num3 = (an5hGi5gnsIXff1urqIP() ? 10 : 7);
							goto IL_00a9;
						}
						goto end_IL_0039;
						IL_00a9:
						while (true)
						{
							switch (num3)
							{
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 1;
								continue;
							case 5:
								awaiter = propertyLinks.OnSourcePropertyChanged(cellViewModel, args).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									goto case 6;
								}
								goto case 12;
							default:
								num3 = 6;
								if (0 == 0)
								{
									continue;
								}
								goto case 7;
							case 7:
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								if (an5hGi5gnsIXff1urqIP())
								{
									continue;
								}
								goto case 11;
							case 11:
								_003C_003Eu__1 = default;
								goto case 7;
							case 4:
								obj2 = null;
								break;
							case 0:
								if (cellViewModel != null)
								{
									num3 = 5;
									continue;
								}
								goto end_IL_00a9;
							case 6:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								continue;
							case 1:
								return;
							case 2:
							case 10:
								cellViewModel = sender as CellViewModel;
								num3 = 0;
								continue;
							case 8:
								obj2 = null;
								break;
							case 12:
								awaiter.GetResult();
								goto end_IL_00a9;
							}
							goto IL_0199;
							continue;
							end_IL_00a9:
							break;
						}
						end_IL_0039:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 2;
				default:
					num = 2;
					goto IL_01f8;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					break;
				case 1:
				case 4:
					break;
				case 6:
					return;
				}
				writeDataSerial = _003C_003E4__this;
				num = 3;
			}
			while (an5hGi5gnsIXff1urqIP());
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
		internal static object UamrPr5gfMaJ5q6ebwYP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).AppViewModel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool an5hGi5gnsIXff1urqIP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oKNh6j5gV1UEBJFdxqmq()
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
	private struct _003CParse_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public WriteDataSerial _003C_003E4__this;

		public CvsCellCollection cells;

		private IEnumerator<CvsCellLocation> _003C_003E7__wrap1;

		private CvsCellLocation _003Clocation_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!FM3Wd55gdRBUs1WVw8ju()) ? 4 : 2);
			int num2 = default;
			WriteDataSerial writeDataSerial = default;
			TaskAwaiter awaiter = default;
			string text = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 5:
					try
					{
						if (num2 != 0)
						{
							writeDataSerial.aYUPyQ6amN();
							writeDataSerial.RemoveAllProperties();
							_003C_003E7__wrap1 = writeDataSerial.CellRange.GetEnumerator();
						}
						try
						{
							if (num2 != 0)
							{
								goto IL_0420;
							}
							awaiter = _003C_003Eu__1;
							int num3 = 22;
							if (oR8mUv5glPi8rT11Ipqj())
							{
							}
							goto IL_0145;
							IL_0145:
							while (true)
							{
								object obj;
								switch (num3)
								{
								case 3:
									AAkrPi5gBwhBqFEhS3MV(writeDataSerial, new EzFormatStringViewModel((CommStepViewModel)writeDataSerial.Parent, Y5U5Cf5gZNFeOeEY5v7Y(writeDataSerial), _003Clocation_003E5__3));
									num3 = 6;
									if (FM3Wd55gdRBUs1WVw8ju())
									{
										continue;
									}
									goto case 6;
								case 6:
									awaiter = ulZh1F5goxpxl7w7MvkK(nT5BCL5gG78JbpoJIO33(EmThJJ5gbh2cTNhxTMsY(writeDataSerial), cells));
									num3 = 9;
									continue;
								case 18:
									_003C_003Eu__1 = awaiter;
									num3 = 12;
									continue;
								case 4:
									writeDataSerial.AddProperty(writeDataSerial.Enabled);
									num3 = 7;
									continue;
								case 17:
								case 21:
									writeDataSerial.Error = new BoolViewModel(writeDataSerial.InSight, cells, _003Clocation_003E5__3, (string)Fmir415gSqKdvbrLrSla());
									num3 = 20;
									continue;
								case 1:
									num2 = (_003C_003E1__state = 0);
									goto case 18;
								default:
									num3 = 18;
									continue;
								case 15:
								{
									object obj2 = h4Dbmx5ggwllvAeNElWA(cells, _003Clocation_003E5__3);
									if (obj2 == null)
									{
										num3 = 10;
										continue;
									}
									obj = cx2BGY5gsZfHphujDNWA(obj2);
									goto IL_040f;
								}
								case 16:
									if (HSomuQ5gvEimoiWKQ7IG(text, CdQUGaROfy7He9T0foW.KbIzwHEDLa(53614), StringComparison.Ordinal))
									{
										num3 = 8;
										continue;
									}
									if (!text.EndsWith((string)vvV3Na5gr2RqyPdHvsfN(53664), StringComparison.Ordinal))
									{
										if (!HSomuQ5gvEimoiWKQ7IG(text, vvV3Na5gr2RqyPdHvsfN(53724), StringComparison.Ordinal))
										{
											if (text.EndsWith((string)vvV3Na5gr2RqyPdHvsfN(53772), StringComparison.Ordinal))
											{
												_ = 0;
												num3 = ((!FM3Wd55gdRBUs1WVw8ju()) ? 11 : 21);
												continue;
											}
											if (HSomuQ5gvEimoiWKQ7IG(text, CdQUGaROfy7He9T0foW.KbIzwHEDLa(53818), StringComparison.Ordinal))
											{
												writeDataSerial.ErrorString = new StringViewModel(writeDataSerial.InSight, cells, _003Clocation_003E5__3, (string)qVT7au5gkhrLVBJqyMyn());
												writeDataSerial.AddProperty(writeDataSerial.ErrorString);
												num3 = 14;
												if (FM3Wd55gdRBUs1WVw8ju())
												{
													continue;
												}
											}
										}
										else
										{
											num3 = 3;
											if (true)
											{
												continue;
											}
										}
										goto case 2;
									}
									writeDataSerial.SendRawBytes = new CheckBoxViewModel(writeDataSerial.InSight, cells, _003Clocation_003E5__3, (string)e0OwGZ5gPFvNXTftWYU0(), isInitialized: true);
									num3 = 5;
									continue;
								case 8:
									writeDataSerial.Enabled = new CheckBoxViewModel(writeDataSerial.InSight, cells, _003Clocation_003E5__3, Resources.Enabled, isInitialized: true);
									num3 = 4;
									if (0 == 0)
									{
										continue;
									}
									return;
								case 13:
									return;
								case 22:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 0;
									continue;
								case 2:
								case 7:
								case 11:
								case 14:
								case 19:
									_003Clocation_003E5__3 = default;
									num3 = 23;
									continue;
								case 12:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 13;
									continue;
								case 0:
									awaiter.GetResult();
									((EzFormatStringViewModel)EmThJJ5gbh2cTNhxTMsY(writeDataSerial)).FormatStringClosed += writeDataSerial.dFHPHLbDsj;
									writeDataSerial.JFXPiU5C3Z = _003Clocation_003E5__3;
									num3 = 2;
									continue;
								case 20:
									writeDataSerial.AddProperty(writeDataSerial.Error);
									goto case 2;
								case 9:
									if (awaiter.IsCompleted)
									{
										goto case 0;
									}
									num3 = 1;
									if (true)
									{
										continue;
									}
									goto case 5;
								case 5:
									writeDataSerial.AddProperty(writeDataSerial.SendRawBytes);
									goto case 2;
								case 10:
									obj = null;
									goto IL_040f;
								case 23:
									break;
									IL_040f:
									text = (string)obj;
									if (text != null)
									{
										num3 = 16;
										continue;
									}
									break;
								}
								break;
							}
							goto IL_0420;
							IL_0420:
							if (_003C_003E7__wrap1.MoveNext())
							{
								_003Clocation_003E5__3 = _003C_003E7__wrap1.Current;
								num3 = 15;
								goto IL_0145;
							}
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								_003C_003E7__wrap1.Dispose();
							}
						}
						_003C_003E7__wrap1 = null;
						IEnumerator<CellViewModel> enumerator = writeDataSerial.Properties.GetEnumerator();
						try
						{
							while (yTbc7T5g8hOK2QsqxOiP(enumerator))
							{
								enumerator.Current.SourcePropertyChanged += writeDataSerial.tM5PwJZRe8;
							}
						}
						finally
						{
							if (num2 < 0 && enumerator != null)
							{
								qB98s45gqyMgjS4PIesB(enumerator);
							}
						}
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
					num = 6;
					if (true)
					{
						continue;
					}
					break;
				case 1:
					break;
				case 6:
					return;
				}
				writeDataSerial = _003C_003E4__this;
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
		internal static object h4Dbmx5ggwllvAeNElWA(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cx2BGY5gsZfHphujDNWA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HSomuQ5gvEimoiWKQ7IG(object P_0, object P_1, StringComparison P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((string)P_0).EndsWith((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vvV3Na5gr2RqyPdHvsfN(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object e0OwGZ5gPFvNXTftWYU0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.eQZ9z1mtQm();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Type Y5U5Cf5gZNFeOeEY5v7Y(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return P_0.GetType();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void AAkrPi5gBwhBqFEhS3MV(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EzFormatStringSupportSnippet)P_0).FormatString = (EzFormatStringViewModel)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EmThJJ5gbh2cTNhxTMsY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzFormatStringSupportSnippet)P_0).FormatString;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nT5BCL5gG78JbpoJIO33(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzFormatStringViewModel)P_0).InitializeAsync((CvsCellCollection)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter ulZh1F5goxpxl7w7MvkK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Fmir415gSqKdvbrLrSla()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.Error;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qVT7au5gkhrLVBJqyMyn()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ErrorString;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yTbc7T5g8hOK2QsqxOiP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void qB98s45gqyMgjS4PIesB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FM3Wd55gdRBUs1WVw8ju()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oR8mUv5glPi8rT11Ipqj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private CvsCellLocation JFXPiU5C3Z;

	[CompilerGenerated]
	private EventHandler UIZPkQkm0J;

	[CompilerGenerated]
	private readonly AsyncDelegateCommand Tk9PPrDwZ2;

	[CompilerGenerated]
	private CheckBoxViewModel B9FPsJmFO0;

	[CompilerGenerated]
	private CheckBoxViewModel BXxPK5YumJ;

	private EzFormatStringViewModel G5hPGUtpb6;

	[CompilerGenerated]
	private BoolViewModel yp3PBrHxIU;

	[CompilerGenerated]
	private StringViewModel kZtPZWtYL3;

	public AsyncDelegateCommand WriteDataSerialDetailsPanelToggle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Tk9PPrDwZ2;
		}
	}

	public override string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)RHsY9yuWMST7O9uW6cy();
		}
	}

	public CheckBoxViewModel Enabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return B9FPsJmFO0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			B9FPsJmFO0 = value;
		}
	}

	public CheckBoxViewModel SendRawBytes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return BXxPK5YumJ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			BXxPK5YumJ = value;
		}
	}

	public override EzFormatStringViewModel FormatString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return G5hPGUtpb6;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			G5hPGUtpb6 = value;
		}
	}

	public BoolViewModel Error
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return yp3PBrHxIU;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			yp3PBrHxIU = value;
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
			return kZtPZWtYL3;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			kZtPZWtYL3 = value;
		}
	}

	public event EventHandler DetailsToggled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0068;
			IL_001a:
			EventHandler eventHandler = default;
			EventHandler eventHandler2 = default;
			if ((object)eventHandler == eventHandler2)
			{
				num = 7;
				if (wnej4cu3hBm2NL3bTdw())
				{
					goto IL_0068;
				}
			}
			goto IL_0031;
			IL_0068:
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
				case 6:
					break;
				case 5:
					goto IL_0031;
				case 1:
				case 2:
					value2 = (EventHandler)oZRgCiuAM6df0vEj4fj(eventHandler2, value);
					goto case 3;
				default:
					num = 3;
					continue;
				case 0:
					eventHandler = UIZPkQkm0J;
					num = 5;
					continue;
				case 3:
					eventHandler = Interlocked.CompareExchange(ref UIZPkQkm0J, value2, eventHandler2);
					break;
				case 7:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_0031:
			eventHandler2 = eventHandler;
			_ = 0;
			num = (wnej4cu3hBm2NL3bTdw() ? 1 : 6);
			goto IL_0068;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
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
			goto IL_007e;
			IL_001a:
			EventHandler eventHandler2 = default;
			EventHandler eventHandler = eventHandler2;
			num = 0;
			goto IL_007e;
			IL_007e:
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 6:
					break;
				default:
					eventHandler2 = Interlocked.CompareExchange(ref UIZPkQkm0J, value2, eventHandler);
					num = 2;
					continue;
				case 4:
					eventHandler2 = UIZPkQkm0J;
					wnej4cu3hBm2NL3bTdw();
					num = (AsO694ujEUAqfqoK8ao() ? 5 : 6);
					continue;
				case 0:
					value2 = (EventHandler)s4r4SHuRvdDYuhBiOeX(eventHandler, value);
					goto default;
				case 2:
					if ((object)eventHandler2 == eventHandler)
					{
						num = 7;
						continue;
					}
					break;
				case 7:
					return;
				}
				break;
			}
			goto IL_001a;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public WriteDataSerial(CommStepViewModel commStepVm, SnippetLocalizer localizer = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		wnej4cu3hBm2NL3bTdw();
		int num = ((!AsO694ujEUAqfqoK8ao()) ? 1 : 3);
		while (true)
		{
			switch (num)
			{
			case 4:
				base._002Ector(commStepVm, localizer);
				break;
			case 0:
			case 1:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 4;
				if (true)
				{
					continue;
				}
				break;
			case 5:
				return;
			}
			Tk9PPrDwZ2 = new AsyncDelegateCommand(ToggleDetailsPanelAsync, [MethodImpl(MethodImplOptions.NoInlining)] () =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			});
			num = 5;
			if (AsO694ujEUAqfqoK8ao())
			{
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__3))]
	public override ValueTask DisposeAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		AsO694ujEUAqfqoK8ao();
		int num = ((!wnej4cu3hBm2NL3bTdw()) ? 4 : 3);
		_003CDisposeAsync_003Ed__3 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = L2CO6Su6ATniU86Qhb3();
				goto case 1;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task ToggleDetailsPanelAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		UIZPkQkm0J?.Invoke(this, EventArgs.Empty);
		return Task.CompletedTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void dFHPHLbDsj(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EventHandler eventHandler = UIZPkQkm0J;
		if (eventHandler != null)
		{
			u4JfrAuCK5waUVg2rt7(eventHandler, this, EventArgs.Empty);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEnableSource_SourcePropertyChanged_003Ed__6))]
	private Task tM5PwJZRe8(object P_0, PropertyValueChangedEventArgs<CellViewModel> P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CEnableSource_SourcePropertyChanged_003Ed__6 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = P_0;
		stateMachine.args = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CParse_003Ed__35))]
	protected override Task Parse(CvsCellCollection cells)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CParse_003Ed__35 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine.cells = cells;
				goto case 2;
			default:
				num = 2;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			case 3:
				stateMachine._003C_003Et__builder = TESxYNuTN6crlpRAUt1();
				wnej4cu3hBm2NL3bTdw();
				if (AsO694ujEUAqfqoK8ao())
				{
					num = 6;
					break;
				}
				num = 0;
				if (!AsO694ujEUAqfqoK8ao())
				{
					break;
				}
				goto case 0;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (AsO694ujEUAqfqoK8ao())
				{
				}
				break;
			case 4:
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void aYUPyQ6amN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (AsO694ujEUAqfqoK8ao() ? 2 : 4);
		IEnumerator<CellViewModel> enumerator = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				enumerator = Properties.GetEnumerator();
				num = 6;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
			case 2:
				G5hPGUtpb6.FormatStringClosed -= dFHPHLbDsj;
				num = 5;
				break;
			case 0:
			case 4:
				if (G5hPGUtpb6 == null)
				{
					goto case 3;
				}
				goto case 1;
			case 5:
				uy0XIBuynDVkpIfbf49(G5hPGUtpb6);
				goto case 3;
			default:
				num = 3;
				break;
			case 6:
				try
				{
					while (AeD2pvu0jWaXtrxQKod(enumerator))
					{
						CellViewModel current = enumerator.Current;
						wnej4cu3hBm2NL3bTdw();
						int num2 = (AsO694ujEUAqfqoK8ao() ? 3 : 2);
						while (true)
						{
							switch (num2)
							{
							default:
								goto IL_00e6;
							case 0:
							case 2:
								if (current != null)
								{
									goto IL_00e6;
								}
								break;
							case 4:
								break;
							}
							break;
							IL_00e6:
							current.SourcePropertyChanged -= tM5PwJZRe8;
							num2 = 4;
						}
					}
					return;
				}
				finally
				{
					if (enumerator != null)
					{
						ENXp7ZuFZ2XY7MmxOEm(enumerator);
					}
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	[DebuggerHidden]
	private ValueTask COHPxViCd3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.DisposeAsync();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wnej4cu3hBm2NL3bTdw()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AsO694ujEUAqfqoK8ao()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncValueTaskMethodBuilder L2CO6Su6ATniU86Qhb3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncValueTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void u4JfrAuCK5waUVg2rt7(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (EventArgs)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oZRgCiuAM6df0vEj4fj(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object s4r4SHuRvdDYuhBiOeX(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object RHsY9yuWMST7O9uW6cy()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.EYqmXZs2K0();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder TESxYNuTN6crlpRAUt1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uy0XIBuynDVkpIfbf49(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((EzFormatStringViewModel)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool AeD2pvu0jWaXtrxQKod(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ENXp7ZuFZ2XY7MmxOEm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}
}
