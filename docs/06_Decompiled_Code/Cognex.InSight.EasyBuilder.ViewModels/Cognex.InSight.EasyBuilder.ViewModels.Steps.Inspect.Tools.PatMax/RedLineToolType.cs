using System;
using System.Collections;
using System.Collections.Generic;
using System.Composition;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Cnx.Diagnostics;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.PatMax.PatMaxUpdates;
using Cognex.InSight.Graphic;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using SBuh9qWVuQSChmKUHq;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.PatMax;

[Export(typeof(EzToolType))]
public class RedLineToolType : EzToolType, IGraphicToolType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateTool_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public RedLineToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private RedLineTool _003Ctool_003E5__2;

		private TaskAwaiter<RedLineTool> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CAqbKFKCSawwRgm7G742();
			int num;
			if (MbvIyNKCoB4boXtNvrFc())
			{
				num = 4;
			}
			else
			{
				num = 1;
				if (false)
				{
					goto IL_02cf;
				}
			}
			goto IL_0298;
			IL_02cf:
			_003Ctool_003E5__2 = null;
			num = 6;
			if (0 == 0)
			{
				goto IL_0298;
			}
			goto IL_02e2;
			IL_02e2:
			EzTool result = default;
			_003C_003Et__builder.SetResult(result);
			num = 7;
			if (0 == 0)
			{
				goto IL_0298;
			}
			goto IL_02fa;
			IL_0298:
			RedLineToolType redLineToolType = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			TaskAwaiter<RedLineTool> awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					redLineToolType = _003C_003E4__this;
					num = 5;
					continue;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 12;
								if (1 == 0)
								{
									goto IL_0052;
								}
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 13;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 1;
						}
						goto IL_0193;
						IL_0052:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 2;
						goto IL_0193;
						IL_0193:
						while (true)
						{
							RedLineTool result2;
							switch (num3)
							{
							case 14:
								break;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							case 0:
								num2 = (_003C_003E1__state = -1);
								goto IL_0098;
							case 3:
							case 11:
								_003C_003Eu__1 = awaiter2;
								num3 = 9;
								continue;
							case 16:
								num2 = (_003C_003E1__state = 1);
								num3 = 5;
								continue;
							case 13:
								_003C_003Eu__2 = default;
								num3 = 0;
								continue;
							case 2:
								return;
							case 7:
								if (!awaiter2.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								goto IL_014a;
							case 12:
								awaiter2 = redLineToolType.CreateNewRedLineTool(redLineToolType.Inspect, cells, cellRange, isInitialized: true).GetAwaiter();
								num3 = 7;
								if (!CAqbKFKCSawwRgm7G742())
								{
									continue;
								}
								goto case 15;
							case 15:
								num2 = (_003C_003E1__state = -1);
								goto IL_014a;
							case 4:
								awaiter = EXM0NfKCk4Ta5UpErGHy(_003Ctool_003E5__2.SetCellRangeAsync(cells, cellRange));
								goto default;
							default:
								if (!awaiter.IsCompleted)
								{
									num3 = 16;
									continue;
								}
								goto IL_0098;
							case 5:
								_003C_003Eu__2 = awaiter;
								num3 = 14;
								continue;
							case 6:
								num2 = (_003C_003E1__state = 0);
								_ = 0;
								if (!MbvIyNKCoB4boXtNvrFc())
								{
									num3 = 10;
									continue;
								}
								num3 = 11;
								if (true)
								{
									continue;
								}
								goto case 1;
							case 1:
								_003C_003Eu__1 = default;
								num3 = 15;
								continue;
							case 17:
								{
									result = _003Ctool_003E5__2;
									goto end_IL_0193;
								}
								IL_0098:
								awaiter.GetResult();
								num3 = 17;
								continue;
								IL_014a:
								result2 = awaiter2.GetResult();
								_003Ctool_003E5__2 = result2;
								num3 = 4;
								continue;
							}
							goto IL_0052;
							continue;
							end_IL_0193:
							break;
						}
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Ctool_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 6:
					goto IL_02e2;
				case 0:
				case 4:
					goto IL_02fa;
				case 7:
					return;
				}
				break;
			}
			goto IL_02cf;
			IL_02fa:
			num2 = _003C_003E1__state;
			num = 2;
			goto IL_0298;
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
		internal static TaskAwaiter EXM0NfKCk4Ta5UpErGHy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MbvIyNKCoB4boXtNvrFc()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CAqbKFKCSawwRgm7G742()
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
	private struct _003COnBeginAddInternal_003Ed__46 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RedLineToolType _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			RedLineToolType redLineToolType = default;
			TaskAwaiter awaiter = default;
			List<CvsEditableDisplayGraphic> list = default;
			CvsCogRectangle acquired2DImageBounds = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					_ = 0;
					if (kDcCpvKC8T9lchL4AfgB())
					{
						num = 3;
						if (Tq3uhRKCqRL7UWtaoeyu())
						{
						}
					}
					else
					{
						num = 0;
					}
					continue;
				case 1:
				case 3:
					redLineToolType = _003C_003E4__this;
					goto case 0;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							redLineToolType.ModelShapeIndex = 0;
							num3 = 5;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 11;
							if (Tq3uhRKCqRL7UWtaoeyu())
							{
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 4:
								list = new List<CvsEditableDisplayGraphic>();
								num3 = 7;
								if (kDcCpvKC8T9lchL4AfgB())
								{
									continue;
								}
								goto case 6;
							case 6:
							case 8:
								awaiter = GqlD9ZKC7ID3uvXVFsev(redLineToolType.qR8cvPUc4f());
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									continue;
								}
								break;
							case 1:
							case 10:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								if (0 == 0)
								{
									continue;
								}
								goto case 5;
							case 5:
								redLineToolType.SearchShapeIndex = 0;
								num3 = 4;
								if (true)
								{
									continue;
								}
								goto case 11;
							case 11:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 0:
								OcQAIxKCpf0QKXHH0sEt(bh7nc9KCEjLIO3gL6bmW(redLineToolType.HmKc2XOn2h), Resources.ipwVhC3LWP());
								num3 = 14;
								continue;
							case 14:
								redLineToolType.WQscqpTt6J = EditableGraphicHelper.ConstructComposite(CvsCellLocation.Invalid, 20.0, 20.0, OAfUViKCX7gog20rWNFO(acquired2DImageBounds) - 40.0, PImYkrKC9MfQMFGIALhc(acquired2DImageBounds) - 40.0, 0.0, 0.0, acquired2DImageBounds);
								OcQAIxKCpf0QKXHH0sEt(redLineToolType.WQscqpTt6J.CompositeRegion, z2sb84KC4UBI5jKILuQM());
								list.Add(redLineToolType.HmKc2XOn2h);
								num3 = 15;
								continue;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 2;
								continue;
							case 12:
								redLineToolType.HmKc2XOn2h = EditableGraphicHelper.ConstructComposite(CvsCellLocation.Invalid, 100.0, 100.0, 150.0, 150.0, 0.0, 0.0, acquired2DImageBounds);
								num3 = 0;
								continue;
							case 13:
								redLineToolType.N73csvO78i = list.ToArray();
								kDcCpvKC8T9lchL4AfgB();
								if (!Tq3uhRKCqRL7UWtaoeyu())
								{
									num3 = 6;
									continue;
								}
								num3 = 1;
								if (kDcCpvKC8T9lchL4AfgB())
								{
									continue;
								}
								break;
							case 2:
								return;
							case 7:
								acquired2DImageBounds = redLineToolType.GetAcquired2DImageBounds();
								num3 = 12;
								continue;
							case 15:
								list.Add(redLineToolType.WQscqpTt6J);
								goto case 13;
							default:
								num3 = 13;
								continue;
							case 9:
								num2 = (_003C_003E1__state = 0);
								goto case 1;
							case 16:
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
					num = 4;
					continue;
				case 4:
					break;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
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
		internal static object bh7nc9KCEjLIO3gL6bmW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsDisplayableComposite)P_0).CompositeRegion;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void OcQAIxKCpf0QKXHH0sEt(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsGraphic)P_0).Label = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double OAfUViKCX7gog20rWNFO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogRectangle)P_0).Width;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double PImYkrKC9MfQMFGIALhc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogRectangle)P_0).Height;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object z2sb84KC4UBI5jKILuQM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.hVN9YZDbpU();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter GqlD9ZKC7ID3uvXVFsev(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kDcCpvKC8T9lchL4AfgB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Tq3uhRKCqRL7UWtaoeyu()
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
	private struct _003CAddTool_003Ed__50 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public RedLineToolType _003C_003E4__this;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private CvsCellRange _003CpasteRange_003E5__3;

		private object _003C_003E7__wrap3;

		private string _003CtoolName_003E5__5;

		private CvsCellCollection _003Ccells_003E5__6;

		private TaskAwaiter<CvsCellRange> _003C_003Eu__1;

		private TaskAwaiter<object> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__4;

		private TaskAwaiter<CvsCogEditInfo[]> _003C_003Eu__5;

		private TaskAwaiter<CvsCogEditingObject> _003C_003Eu__6;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__7;

		private TaskAwaiter<double> _003C_003Eu__8;

		private TaskAwaiter<RedLineTool> _003C_003Eu__9;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			RedLineToolType redLineToolType = default;
			EzTool result3 = default;
			TaskAwaiter awaiter = default;
			PasteBuffer pasteObject = default;
			TaskAwaiter<RedLineTool> awaiter9 = default;
			TaskAwaiter<CvsCellCollection> awaiter4 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter3 = default;
			TaskAwaiter<CvsCellRange> awaiter8 = default;
			TaskAwaiter<double> awaiter7 = default;
			TaskAwaiter<CvsCogEditInfo[]> awaiter6 = default;
			TaskAwaiter<CvsCogEditingObject> awaiter5 = default;
			TaskAwaiter<object> awaiter2 = default;
			CvsCogEditInfo[] result = default;
			Dictionary<string, object> dictionary = default;
			double result2 = default;
			CvsCellCollection result4 = default;
			string text = default;
			CvsCogEditingObject result6 = default;
			CvsCellLocation cellLocation = default;
			CvsCellLocation cellLocation2 = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
					redLineToolType = _003C_003E4__this;
					goto case 2;
				case 3:
					_003C_003Et__builder.SetResult(result3);
					num = 7;
					if (true)
					{
						break;
					}
					goto case 2;
				case 2:
				case 5:
					try
					{
						int num3;
						if ((uint)num2 > 14u)
						{
							if (num2 == 15)
							{
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_1036;
							}
							_003Csheet_003E5__2 = (CvsCogSocketSheet)YcTx9qKCREd9eYK4ki5x(Amxt4nKCACtTQJvHRWV8(SSbjRTKCC2npbVVpEIxR(prj665KC6OKIs6I3SxSl(redLineToolType))));
							_003CpasteRange_003E5__3 = CvsCellRange.Empty;
							num3 = 0;
						}
						try
						{
							int num4;
							switch (num2)
							{
							default:
								pasteObject = EzToolType.UpdateNamesInPasteBuffer(redLineToolType._pasteObject, redLineToolType.Inspect, out _003CtoolName_003E5__5);
								num4 = 104;
								goto IL_0d78;
							case 14:
								awaiter9 = _003C_003Eu__9;
								num4 = 54;
								if (false)
								{
									goto IL_012d;
								}
								goto IL_0d78;
							case 13:
								awaiter4 = _003C_003Eu__7;
								num4 = 99;
								if (NGux8aKCjJ4iOoB922XZ())
								{
								}
								goto IL_0d78;
							case 10:
								awaiter3 = _003C_003Eu__4;
								num4 = 71;
								if (NGux8aKCjJ4iOoB922XZ())
								{
								}
								goto IL_0d78;
							case 4:
								awaiter = _003C_003Eu__3;
								num4 = 41;
								goto IL_0d78;
							case 0:
								awaiter8 = _003C_003Eu__1;
								num4 = 16;
								goto IL_0d78;
							case 12:
								awaiter7 = _003C_003Eu__8;
								_003C_003Eu__8 = default;
								num4 = 102;
								goto IL_0d78;
							case 6:
								awaiter6 = _003C_003Eu__5;
								_003C_003Eu__5 = default;
								num4 = 103;
								goto IL_0d78;
							case 9:
								awaiter3 = _003C_003Eu__4;
								_003C_003Eu__4 = default;
								num2 = (_003C_003E1__state = -1);
								num4 = 44;
								if (1 == 0)
								{
									goto IL_063f;
								}
								goto IL_0d78;
							case 2:
								awaiter = _003C_003Eu__3;
								num4 = 73;
								goto IL_0d78;
							case 8:
								awaiter = _003C_003Eu__3;
								num4 = 6;
								if (NGux8aKCjJ4iOoB922XZ())
								{
								}
								goto IL_0d78;
							case 7:
								awaiter5 = _003C_003Eu__6;
								num4 = 58;
								goto IL_0d78;
							case 11:
								awaiter4 = _003C_003Eu__7;
								num4 = 5;
								goto IL_0d78;
							case 5:
								awaiter = _003C_003Eu__3;
								num4 = 14;
								goto IL_0d78;
							case 3:
								awaiter3 = _003C_003Eu__4;
								num4 = 72;
								if (false)
								{
									goto IL_0aa7;
								}
								goto IL_0d78;
							case 1:
								{
									awaiter2 = _003C_003Eu__2;
									num4 = 19;
									goto IL_0d78;
								}
								IL_0d78:
								while (true)
								{
									CvsCellRange result5;
									switch (num4)
									{
									case 42:
										num2 = (_003C_003E1__state = -1);
										goto IL_00ee;
									case 64:
										num2 = (_003C_003E1__state = 8);
										num4 = 11;
										continue;
									case 48:
										return;
									case 60:
										break;
									case 100:
										if (result.Length == 1)
										{
											num4 = 59;
											continue;
										}
										goto case 32;
									case 63:
										fwr1VoKC0d1KdyVPPkt0(CvsTraceEzb.Info, TbkAL3KCWSZLqDNs3Nx0(49436));
										awaiter = ((Task)RZS11cKCUA8p4nKNHJGD(SSbjRTKCC2npbVVpEIxR(prj665KC6OKIs6I3SxSl(redLineToolType)), redLineToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, redLineToolType._modelRegionOffset), redLineToolType.HmKc2XOn2h)).GetAwaiter();
										num4 = 95;
										continue;
									case 89:
										_003C_003Eu__5 = awaiter6;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter6, ref this);
										num4 = 84;
										continue;
									case 107:
										_003C_003Eu__3 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 20;
										continue;
									case 105:
										if (!awaiter.IsCompleted)
										{
											num4 = 64;
											continue;
										}
										goto case 106;
									case 69:
										if (!awaiter2.IsCompleted)
										{
											num4 = 9;
											continue;
										}
										goto case 25;
									case 93:
										return;
									case 17:
										return;
									case 43:
										_003C_003Eu__2 = awaiter2;
										num4 = 7;
										if (NGux8aKCjJ4iOoB922XZ())
										{
										}
										continue;
									case 25:
										awaiter2.GetResult();
										num4 = 97;
										continue;
									case 96:
										_003C_003Eu__4 = awaiter3;
										num4 = 52;
										continue;
									case 106:
										awaiter.GetResult();
										num4 = 12;
										continue;
									case 38:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 53;
										continue;
									case 1:
									case 86:
										num2 = (_003C_003E1__state = 12);
										_003C_003Eu__8 = awaiter7;
										num4 = 66;
										continue;
									case 31:
										dictionary.Add(EzSnippet.AssembleFullCellName(_003CtoolName_003E5__5, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6148)), (int)result2);
										num4 = 81;
										continue;
									case 9:
										num2 = (_003C_003E1__state = 1);
										num4 = 43;
										if (0 == 0)
										{
											continue;
										}
										goto case 54;
									case 54:
										_003C_003Eu__9 = default;
										num4 = 35;
										continue;
									case 97:
										fwr1VoKC0d1KdyVPPkt0(CvsTraceEzb.Info, TbkAL3KCWSZLqDNs3Nx0(49608));
										if (AME17TKCFRdNmZawewRn(redLineToolType))
										{
											num4 = 88;
											continue;
										}
										goto IL_0580;
									case 71:
										_003C_003Eu__4 = default;
										num2 = (_003C_003E1__state = -1);
										num4 = 57;
										continue;
									case 20:
										return;
									case 15:
										_003Ccells_003E5__6 = result4;
										awaiter7 = _003Csheet_003E5__2.GetCellPropertyAsync<double>(redLineToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, redLineToolType._numberFoundOffset), CdQUGaROfy7He9T0foW.KbIzwHEDLa(1524)).GetAwaiter();
										num4 = 21;
										if (0 == 0)
										{
											continue;
										}
										goto case 92;
									case 92:
										result4 = awaiter4.GetResult();
										num4 = 15;
										continue;
									case 23:
										_003C_003Eu__1 = awaiter8;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter8, ref this);
										num4 = 49;
										continue;
									case 91:
										fwr1VoKC0d1KdyVPPkt0(CvsTraceEzb.Info, TbkAL3KCWSZLqDNs3Nx0(49842));
										goto IL_0423;
									case 6:
										_003C_003Eu__3 = default;
										num2 = (_003C_003E1__state = -1);
										num4 = 106;
										continue;
									case 90:
										num2 = (_003C_003E1__state = 13);
										_003C_003Eu__7 = awaiter4;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										num4 = 93;
										if (true)
										{
											continue;
										}
										goto case 0;
									case 0:
										num2 = (_003C_003E1__state = 11);
										_003C_003Eu__7 = awaiter4;
										num4 = 50;
										continue;
									case 73:
										_003C_003Eu__3 = default;
										num4 = 36;
										if (0 == 0)
										{
											continue;
										}
										return;
									case 49:
										return;
									case 77:
										num2 = (_003C_003E1__state = 0);
										num4 = 23;
										continue;
									case 72:
										_003C_003Eu__4 = default;
										num4 = 65;
										continue;
									case 13:
										return;
									case 26:
										dictionary = new Dictionary<string, object>();
										num4 = 31;
										continue;
									case 7:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num4 = 82;
										continue;
									case 68:
										awaiter3.GetResult();
										num4 = 63;
										if (0 == 0)
										{
											continue;
										}
										goto case 45;
									case 45:
										fwr1VoKC0d1KdyVPPkt0(CvsTraceEzb.Info, TbkAL3KCWSZLqDNs3Nx0(49398));
										goto IL_0580;
									case 12:
										awaiter3 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
										if (!awaiter3.IsCompleted)
										{
											num4 = 28;
											continue;
										}
										goto case 44;
									case 16:
										_003C_003Eu__1 = default;
										num4 = 37;
										continue;
									case 84:
										return;
									case 67:
										return;
									case 95:
										goto IL_063f;
									case 10:
										num2 = (_003C_003E1__state = 2);
										_003C_003Eu__3 = awaiter;
										num4 = 80;
										continue;
									case 39:
										result2 = awaiter7.GetResult();
										fwr1VoKC0d1KdyVPPkt0(CvsTraceEzb.Info, CdQUGaROfy7He9T0foW.KbIzwHEDLa(50196));
										num4 = 24;
										if (Rp66gKKC3NqiliNi9CeL())
										{
											continue;
										}
										goto case 5;
									case 5:
										_003C_003Eu__7 = default;
										num4 = 46;
										if (0 == 0)
										{
											continue;
										}
										return;
									case 4:
										return;
									case 50:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										num4 = 3;
										continue;
									case 101:
										dictionary.Add(EzSnippet.AssembleFullCellName(_003CtoolName_003E5__5, (string)TbkAL3KCWSZLqDNs3Nx0(20040)), false);
										num4 = 76;
										if (true)
										{
											continue;
										}
										goto case 88;
									case 88:
										text = (string)pw07TmKCMcovJpQW1RLd(redLineToolType.FindInputFixtureCell(redLineToolType._pasteObject));
										num4 = 29;
										continue;
									case 55:
										if (!awaiter5.IsCompleted)
										{
											num2 = (_003C_003E1__state = 7);
											num4 = 87;
											continue;
										}
										goto IL_0a2d;
									case 41:
										_003C_003Eu__3 = default;
										num4 = 83;
										if (true)
										{
											continue;
										}
										goto case 57;
									case 57:
										awaiter3.GetResult();
										_ = 0;
										num4 = ((!Rp66gKKC3NqiliNi9CeL()) ? 1 : 32);
										continue;
									case 99:
										_003C_003Eu__7 = default;
										num4 = 42;
										continue;
									case 33:
										if (result6 != null)
										{
											awaiter = ((Task)AnuoIrKCxHPjK1L0K4hk(_003Csheet_003E5__2, result6.Url, 1)).GetAwaiter();
											num4 = 105;
											if (Rp66gKKC3NqiliNi9CeL())
											{
												continue;
											}
											goto case 35;
										}
										goto case 32;
									case 35:
										num2 = (_003C_003E1__state = -1);
										num4 = 108;
										continue;
									case 28:
										num2 = (_003C_003E1__state = 9);
										_003C_003Eu__4 = awaiter3;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										num4 = 67;
										if (Rp66gKKC3NqiliNi9CeL())
										{
											continue;
										}
										goto case 83;
									case 83:
										num2 = (_003C_003E1__state = -1);
										goto IL_081d;
									case 59:
										awaiter5 = _003Csheet_003E5__2.EditEditableObjectAsync((string)FbdL7tKCHfRaKLwDG0as(result[0])).GetAwaiter();
										num4 = 55;
										continue;
									case 32:
									case 75:
										dictionary = new Dictionary<string, object>();
										num4 = 101;
										continue;
									case 53:
										return;
									case 52:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										num4 = 17;
										if (0 == 0)
										{
											continue;
										}
										goto case 85;
									case 85:
										num2 = (_003C_003E1__state = 3);
										_003C_003Eu__4 = awaiter3;
										num4 = 34;
										continue;
									case 61:
										if (!awaiter8.IsCompleted)
										{
											num4 = 77;
											continue;
										}
										goto IL_09e3;
									case 24:
										if (redLineToolType.AdjustRangeLimits)
										{
											num4 = 26;
											continue;
										}
										goto IL_0423;
									case 2:
										num2 = (_003C_003E1__state = -1);
										num4 = 25;
										continue;
									case 11:
										_003C_003Eu__3 = awaiter;
										num4 = 38;
										continue;
									case 80:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 4;
										continue;
									case 98:
										_003Ccells_003E5__6 = result4;
										num4 = 91;
										if (NGux8aKCjJ4iOoB922XZ())
										{
										}
										continue;
									case 70:
										return;
									case 102:
										num2 = (_003C_003E1__state = -1);
										num4 = 39;
										continue;
									case 19:
										_003C_003Eu__2 = default;
										num4 = 2;
										if (0 == 0)
										{
											continue;
										}
										return;
									case 3:
										return;
									case 47:
										return;
									case 34:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										num4 = 8;
										continue;
									case 62:
										num2 = (_003C_003E1__state = 10);
										num4 = 96;
										continue;
									case 37:
										num2 = (_003C_003E1__state = -1);
										goto IL_09e3;
									case 56:
										awaiter = WhWJEPKCYmwML4Aqi0VC(InputFixtureViewModel.YnAyJgATSB((InspectStepViewModel)prj665KC6OKIs6I3SxSl(redLineToolType), text, cellLocation));
										num4 = 60;
										continue;
									case 94:
										num2 = (_003C_003E1__state = -1);
										goto IL_0a2d;
									case 66:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter7, ref this);
										num4 = 13;
										continue;
									case 40:
										if (!awaiter9.IsCompleted)
										{
											num2 = (_003C_003E1__state = 14);
											_003C_003Eu__9 = awaiter9;
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter9, ref this);
											num4 = 48;
											continue;
										}
										goto case 108;
									case 8:
										return;
									case 79:
										goto IL_0aa7;
									case 103:
										num2 = (_003C_003E1__state = -1);
										num4 = 30;
										if (!NGux8aKCjJ4iOoB922XZ())
										{
											continue;
										}
										goto case 21;
									case 21:
										if (!awaiter7.IsCompleted)
										{
											goto case 1;
										}
										goto case 39;
									case 81:
										dictionary.Add(EzSnippet.AssembleFullCellName(_003CtoolName_003E5__5, CdQUGaROfy7He9T0foW.KbIzwHEDLa(6138)), (int)result2);
										awaiter4 = _003Csheet_003E5__2.RunAndGetCellResults(dictionary).GetAwaiter();
										num4 = 27;
										continue;
									case 51:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 47;
										if (true)
										{
											continue;
										}
										goto case 30;
									case 30:
										result = awaiter6.GetResult();
										num4 = 100;
										if (true)
										{
											continue;
										}
										goto case 44;
									case 44:
										awaiter3.GetResult();
										awaiter3 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
										num4 = 74;
										if (0 == 0)
										{
											continue;
										}
										goto case 14;
									case 14:
										_003C_003Eu__3 = default;
										num2 = (_003C_003E1__state = -1);
										goto IL_0be7;
									case 65:
										num2 = (_003C_003E1__state = -1);
										num4 = 68;
										continue;
									case 46:
										num2 = (_003C_003E1__state = -1);
										num4 = 92;
										continue;
									case 76:
										awaiter4 = _003Csheet_003E5__2.RunAndGetCellResults(dictionary).GetAwaiter();
										if (!awaiter4.IsCompleted)
										{
											num4 = 0;
											continue;
										}
										goto case 92;
									case 58:
										_003C_003Eu__6 = default;
										num4 = 94;
										continue;
									case 27:
										if (!awaiter4.IsCompleted)
										{
											num4 = 90;
											continue;
										}
										goto IL_00ee;
									case 78:
										num2 = (_003C_003E1__state = 4);
										num4 = 107;
										if (0 == 0)
										{
											continue;
										}
										goto case 74;
									case 74:
										if (!awaiter3.IsCompleted)
										{
											num4 = 62;
											if (0 == 0)
											{
												continue;
											}
											return;
										}
										goto case 57;
									case 82:
										return;
									case 18:
										awaiter = WhWJEPKCYmwML4Aqi0VC(RZS11cKCUA8p4nKNHJGD(((AppStepViewModel)prj665KC6OKIs6I3SxSl(redLineToolType)).InSight, redLineToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, redLineToolType._searchRegionOffset), redLineToolType.WQscqpTt6J));
										if (!awaiter.IsCompleted)
										{
											num2 = (_003C_003E1__state = 5);
											_003C_003Eu__3 = awaiter;
											num4 = 51;
											if (NGux8aKCjJ4iOoB922XZ())
											{
											}
											continue;
										}
										goto IL_0be7;
									case 36:
										goto IL_0d36;
									case 87:
										_003C_003Eu__6 = awaiter5;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
										return;
									default:
										num4 = 70;
										if (0 == 0)
										{
											continue;
										}
										goto case 104;
									case 104:
										awaiter8 = redLineToolType.PasteTool(pasteObject, null, runSheet: false).GetAwaiter();
										num4 = 61;
										if (0 == 0)
										{
											continue;
										}
										goto case 22;
									case 22:
										awaiter6 = _003Csheet_003E5__2.GetEditInfoAsync(cellLocation2).GetAwaiter();
										if (!awaiter6.IsCompleted)
										{
											num2 = (_003C_003E1__state = 6);
											num4 = 89;
											continue;
										}
										goto case 30;
									case 29:
										cellLocation = redLineToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, redLineToolType._fixtureOffset);
										num4 = 56;
										continue;
									case 108:
										{
											result3 = awaiter9.GetResult();
											goto end_IL_0081;
										}
										IL_09e3:
										result5 = awaiter8.GetResult();
										_003CpasteRange_003E5__3 = result5;
										num4 = 79;
										if (!NGux8aKCjJ4iOoB922XZ())
										{
											continue;
										}
										goto case 56;
										IL_0a2d:
										result6 = awaiter5.GetResult();
										num4 = 33;
										continue;
										IL_0423:
										awaiter9 = redLineToolType.CreateNewRedLineTool((InspectStepViewModel)prj665KC6OKIs6I3SxSl(redLineToolType), _003Ccells_003E5__6, _003CpasteRange_003E5__3, isInitialized: false).GetAwaiter();
										num4 = 40;
										continue;
										IL_0580:
										awaiter3 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
										if (awaiter3.IsCompleted)
										{
											goto case 68;
										}
										num4 = 85;
										if (Rp66gKKC3NqiliNi9CeL())
										{
											continue;
										}
										goto case 12;
										IL_00ee:
										result4 = awaiter4.GetResult();
										num4 = 98;
										continue;
										IL_0be7:
										awaiter.GetResult();
										cellLocation2 = redLineToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, redLineToolType._trainOffset);
										num4 = 22;
										continue;
									}
									break;
								}
								goto IL_012d;
								IL_0d36:
								num2 = (_003C_003E1__state = -1);
								goto IL_0d3f;
								IL_0aa7:
								CvsTraceEzb.Info.TraceMessage((string)TbkAL3KCWSZLqDNs3Nx0(49576));
								awaiter2 = _003Csheet_003E5__2.PutCellExpressionAsync(redLineToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, redLineToolType._imageOffset), (string)SG0ebUKCy04ddxNrXXNC(redLineToolType.InputImageLinks[oVQFv2KCTFF9sFvdHdwW(redLineToolType)])).GetAwaiter();
								num4 = 69;
								goto IL_0d78;
								IL_063f:
								if (awaiter.IsCompleted)
								{
									goto IL_081d;
								}
								num4 = 78;
								goto IL_0d78;
								IL_0d3f:
								awaiter.GetResult();
								num4 = 45;
								goto IL_0d78;
								IL_081d:
								awaiter.GetResult();
								num4 = 18;
								goto IL_0d78;
								IL_012d:
								if (awaiter.IsCompleted)
								{
									goto IL_0d3f;
								}
								num4 = 10;
								goto IL_0d78;
								end_IL_0081:
								break;
							}
						}
						catch (object obj)
						{
							_003C_003E7__wrap3 = obj;
							num3 = 1;
							goto IL_0fce;
						}
						goto end_IL_0047;
						IL_0fce:
						if (num3 == 1)
						{
							awaiter = WhWJEPKCYmwML4Aqi0VC(redLineToolType.CleanUpPastedToolOnFailedAdd(_003CpasteRange_003E5__3));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 15);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_1036;
						}
						goto IL_105f;
						IL_1036:
						awaiter.GetResult();
						FwOVRmKCmOfAq4TyHdnP(ExceptionDispatchInfo.Capture((_003C_003E7__wrap3 as Exception) ?? throw _003C_003E7__wrap3));
						goto IL_105f;
						IL_105f:
						_003C_003E7__wrap3 = null;
						_003Csheet_003E5__2 = null;
						_003CpasteRange_003E5__3 = default;
						end_IL_0047:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Csheet_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 6;
				default:
					num = 6;
					break;
				case 6:
					_003Csheet_003E5__2 = null;
					num = 3;
					break;
				case 4:
					num2 = _003C_003E1__state;
					_ = 1;
					num = (NGux8aKCjJ4iOoB922XZ() ? 5 : 0);
					break;
				case 7:
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
		internal static object prj665KC6OKIs6I3SxSl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SSbjRTKCC2npbVVpEIxR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Amxt4nKCACtTQJvHRWV8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YcTx9qKCREd9eYK4ki5x(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object TbkAL3KCWSZLqDNs3Nx0(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int oVQFv2KCTFF9sFvdHdwW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).InputImageIndex;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SG0ebUKCy04ddxNrXXNC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fwr1VoKC0d1KdyVPPkt0(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CnxTraceChannel)P_0).TraceMessage((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AME17TKCFRdNmZawewRn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((RedLineToolType)P_0).AssignDefaultFixture;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pw07TmKCMcovJpQW1RLd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((PasteBufferCell)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter WhWJEPKCYmwML4Aqi0VC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RZS11cKCUA8p4nKNHJGD(object P_0, CvsCellLocation loc, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.SendGraphicAsync((CvsInSight)P_0, loc, (CvsEditableDisplayGraphic)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object FbdL7tKCHfRaKLwDG0as(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogEditInfo)P_0).Url;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object AnuoIrKCxHPjK1L0K4hk(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocketSheet)P_0).ApplyEditableObjectAsync((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void FwOVRmKCmOfAq4TyHdnP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Rp66gKKC3NqiliNi9CeL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NGux8aKCjJ4iOoB922XZ()
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

		public static Func<PasteBuffer, string> _003C_003E9__51_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			S22n6oKC27Oa8tKY8dFO();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			S22n6oKC27Oa8tKY8dFO();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CGetUpdates_003Eb__51_0(PasteBuffer buffer)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)EPrsawKCc59h1oDQYPNT(49502);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void S22n6oKC27Oa8tKY8dFO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Cay3WWKCQIH9qrjMI4dk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HjwM73KCN2hXyh1OPB1U()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EPrsawKCc59h1oDQYPNT(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetUpdates_003Ed__51 : IEnumerable<ISnippetUpdate>, IEnumerable, IEnumerator<ISnippetUpdate>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ISnippetUpdate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private CvsCellCollection cells;

		public CvsCellCollection _003C_003E3__cells;

		private CvsCellRange range;

		public CvsCellRange _003C_003E3__range;

		public RedLineToolType _003C_003E4__this;

		private int _003CcurrentVersion_003E5__2;

		private int _003ClatestVersion_003E5__3;

		ISnippetUpdate IEnumerator<ISnippetUpdate>.Current
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
		public _003CGetUpdates_003Ed__51(int _003C_003E1__state)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_0033;
			IL_001a:
			this._003C_003E1__state = _003C_003E1__state;
			goto IL_0073;
			IL_0033:
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					break;
				case 4:
					dMKVDxKCh0FmROiA5xTQ();
					num = 1;
					continue;
				default:
					goto IL_0073;
				case 1:
					goto IL_0088;
				case 6:
					return;
				}
				break;
				IL_0088:
				fddOjuKCtoa085Ol9fy3(this);
				_ = 1;
				num = ((!fRCXc8KCugu5MXCUUCLo()) ? 5 : 0);
			}
			goto IL_001a;
			IL_0073:
			_003C_003El__initialThreadId = dt89pTKCzrnm5Vkuj3bx();
			num = 6;
			goto IL_0033;
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
			int num = 24;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0041;
			IL_0315:
			RedLineToolType redLineToolType = default;
			if (_003CcurrentVersion_003E5__2 < 3)
			{
				_003C_003E2__current = new dM56x35dlwOvRXNG9K(redLineToolType.Localizer);
				num = 20;
				goto IL_0041;
			}
			goto IL_0298;
			IL_0298:
			if (_003CcurrentVersion_003E5__2 >= 4)
			{
				goto IL_0127;
			}
			num = 16;
			if (true)
			{
				goto IL_0041;
			}
			goto IL_02b0;
			IL_038c:
			return false;
			IL_001a:
			CvsCellLocation offset = default;
			if (_003CcurrentVersion_003E5__2 < 2)
			{
				offset = new CvsCellLocation(0, 6);
				goto IL_00b6;
			}
			goto IL_0315;
			IL_0120:
			_003C_003E1__state = -1;
			goto IL_0127;
			IL_00b6:
			_ = 1;
			num = (fRCXc8KCugu5MXCUUCLo() ? 3 : 12);
			goto IL_0041;
			IL_0127:
			if (_003CcurrentVersion_003E5__2 < _003ClatestVersion_003E5__3)
			{
				num = 19;
				goto IL_0041;
			}
			goto IL_038c;
			IL_02b0:
			return false;
			IL_0041:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 23:
					break;
				default:
					goto IL_00b6;
				case 7:
					_003C_003E1__state = 6;
					num = 25;
					continue;
				case 12:
				case 13:
					_003C_003E2__current = new EditArgumentUpdate(offset, [MethodImpl(MethodImplOptions.NoInlining)] (PasteBuffer buffer) =>
					{
						while (false)
						{
							_ = ((object[])null)[0];
						}
						return (string)_003C_003Ec.EPrsawKCc59h1oDQYPNT(49502);
					}, 0, null);
					goto case 3;
				case 25:
					return true;
				case 1:
					return true;
				case 3:
				case 14:
					_003C_003E1__state = 4;
					return true;
				case 10:
					_003CcurrentVersion_003E5__2 = pjF8SNKALbbO5g6Gwi81(cells, range);
					_003ClatestVersion_003E5__3 = PyC6TNKAK7qbYTEiLWRU(redLineToolType._pasteObject);
					num = 2;
					if (true)
					{
						continue;
					}
					goto case 9;
				case 9:
					_003C_003E1__state = 7;
					num = 5;
					if (edqynfKC1fbl5St0QTrs())
					{
						continue;
					}
					goto case 26;
				case 26:
					_003C_003E1__state = 3;
					return true;
				case 24:
					num2 = _003C_003E1__state;
					num = 11;
					if (fRCXc8KCugu5MXCUUCLo())
					{
					}
					continue;
				case 22:
					_003C_003E1__state = 2;
					return true;
				case 2:
					if (_003CcurrentVersion_003E5__2 >= 1)
					{
						break;
					}
					num = 4;
					if (edqynfKC1fbl5St0QTrs())
					{
						continue;
					}
					goto case 21;
				case 21:
					_003C_003E2__current = new AddScoreCellUpdate(redLineToolType.Localizer);
					num = 22;
					continue;
				case 11:
					goto IL_0240;
				case 16:
					goto IL_027d;
				case 8:
					goto IL_0298;
				case 18:
					goto IL_02b0;
				case 17:
					_003C_003E2__current = new AddGranularityUpdate(redLineToolType.Localizer);
					num = 26;
					continue;
				case 20:
					_003C_003E1__state = 5;
					num = 1;
					continue;
				case 6:
					_003C_003E1__state = 1;
					num = 15;
					continue;
				case 15:
					return true;
				case 0:
					goto IL_0315;
				case 19:
					_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__3, redLineToolType.Localizer);
					num = 9;
					if (edqynfKC1fbl5St0QTrs())
					{
						continue;
					}
					goto case 4;
				case 4:
					_003C_003E2__current = new ToolDisabledJobPassUpdate();
					num = 6;
					continue;
				case 5:
					return true;
				case 27:
					goto IL_038c;
				}
				break;
				IL_0240:
				redLineToolType = _003C_003E4__this;
				switch (num2)
				{
				case 6:
					break;
				case 5:
					goto IL_0144;
				case 4:
					goto IL_015e;
				case 3:
					goto IL_01c3;
				case 2:
					goto IL_01f8;
				default:
					goto IL_026d;
				case 0:
					goto IL_02b2;
				case 1:
					goto IL_0302;
				case 7:
					goto IL_037b;
				}
				goto IL_0120;
				IL_037b:
				_003C_003E1__state = -1;
				num = 27;
				continue;
				IL_0302:
				_003C_003E1__state = -1;
				num = 21;
				if (0 == 0)
				{
					continue;
				}
				goto IL_0315;
				IL_02b2:
				_003C_003E1__state = -1;
				num = 10;
				continue;
				IL_026d:
				num = 18;
				if (!fRCXc8KCugu5MXCUUCLo())
				{
					continue;
				}
				goto IL_027d;
				IL_027d:
				_003C_003E2__current = new IncreaseNumberToFindLimit(redLineToolType.Localizer);
				num = 7;
				continue;
				IL_01f8:
				_003C_003E1__state = -1;
				num = 17;
				continue;
				IL_01c3:
				_003C_003E1__state = -1;
				num = 23;
				continue;
				IL_015e:
				_003C_003E1__state = -1;
				num = 0;
				continue;
				IL_0144:
				_003C_003E1__state = -1;
				num = 8;
			}
			goto IL_001a;
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
		IEnumerator<ISnippetUpdate> IEnumerable<ISnippetUpdate>.GetEnumerator()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003CGetUpdates_003Ed__51 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetUpdates_003Ed__51(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			obj.cells = _003C_003E3__cells;
			obj.range = _003C_003E3__range;
			return obj;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerable<ISnippetUpdate>)this).GetEnumerator();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void dMKVDxKCh0FmROiA5xTQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fddOjuKCtoa085Ol9fy3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int dt89pTKCzrnm5Vkuj3bx()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool edqynfKC1fbl5St0QTrs()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fRCXc8KCugu5MXCUUCLo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int pjF8SNKALbbO5g6Gwi81(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int PyC6TNKAK7qbYTEiLWRU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateNewRedLineTool_003Ed__52 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<RedLineTool> _003C_003Et__builder;

		public RedLineToolType _003C_003E4__this;

		public InspectStepViewModel inspect;

		public bool isInitialized;

		public CvsCellCollection cells;

		public CvsCellRange pasteRange;

		private RedLineTool _003Ctool_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Pb59OcKA5wIhPXDIXF8i();
			int num;
			if (!Hmmu5OKAwDtGKWg8BuPr())
			{
				num = 4;
				if (false)
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 3;
				if (!Pb59OcKA5wIhPXDIXF8i())
				{
					goto IL_0047;
				}
			}
			goto IL_0221;
			IL_002a:
			RedLineToolType redLineToolType = _003C_003E4__this;
			goto IL_0087;
			IL_0221:
			RedLineTool result = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					break;
				case 1:
					goto IL_0047;
				case 0:
				case 4:
					goto IL_005e;
				case 5:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					if (true)
					{
						continue;
					}
					goto IL_0087;
				case 2:
				case 3:
					goto IL_0087;
				default:
					num = 1;
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_002a;
			IL_0087:
			int num2 = default;
			try
			{
				int num3;
				TaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					_003Ctool_003E5__2 = new RedLineTool(redLineToolType.Source, inspect, isInitialized);
					num3 = 0;
					if (Hmmu5OKAwDtGKWg8BuPr())
					{
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num3 = 1;
					if (1 == 0)
					{
						goto IL_01b4;
					}
				}
				goto IL_0114;
				IL_01b4:
				num2 = (_003C_003E1__state = 0);
				num3 = 9;
				goto IL_0114;
				IL_0114:
				while (true)
				{
					switch (num3)
					{
					case 6:
						if (!awaiter.IsCompleted)
						{
							num3 = 3;
							continue;
						}
						goto case 4;
					case 0:
						awaiter = VxRas7KAaNJDQA9LYair(nNLqHTKAJxOoEPMcNSIM(_003Ctool_003E5__2, cells, pasteRange));
						num3 = 6;
						continue;
					case 9:
						_003C_003Eu__1 = awaiter;
						goto case 2;
					default:
						num3 = 2;
						continue;
					case 2:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						Hmmu5OKAwDtGKWg8BuPr();
						num3 = ((!Pb59OcKA5wIhPXDIXF8i()) ? 4 : 8);
						continue;
					case 1:
						num2 = (_003C_003E1__state = -1);
						goto case 4;
					case 5:
					case 8:
						return;
					case 3:
						break;
					case 4:
					case 7:
						awaiter.GetResult();
						num3 = 10;
						continue;
					case 10:
						result = _003Ctool_003E5__2;
						goto end_IL_0114;
					}
					goto IL_01b4;
					continue;
					end_IL_0114:
					break;
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Ctool_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0047;
			IL_0047:
			_003Ctool_003E5__2 = null;
			num = 5;
			if (!Pb59OcKA5wIhPXDIXF8i())
			{
				goto IL_005e;
			}
			goto IL_0221;
			IL_005e:
			num2 = _003C_003E1__state;
			num = 6;
			goto IL_0221;
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
		internal static object nNLqHTKAJxOoEPMcNSIM(object P_0, object P_1, CvsCellRange cellRange)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippet)P_0).SetCellRangeAsync((CvsCellCollection)P_1, cellRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter VxRas7KAaNJDQA9LYair(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Pb59OcKA5wIhPXDIXF8i()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Hmmu5OKAwDtGKWg8BuPr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly Guid[] sbvceLpQ9d;

	protected readonly CvsCellLocation _imageOffset;

	protected readonly CvsCellLocation _fixtureOffset;

	protected readonly CvsCellLocation _modelRegionOffset;

	protected readonly CvsCellLocation _searchRegionOffset;

	protected readonly CvsCellLocation _trainOffset;

	protected readonly CvsCellLocation _showModelOffset;

	protected readonly CvsCellLocation _numberFoundOffset;

	private CvsDisplayableComposite HmKc2XOn2h;

	private CvsDisplayableComposite WQscqpTt6J;

	private int CQwcixHc31;

	private int vAAckfLnor;

	private int sC1cP0yy6o;

	private CvsEditableDisplayGraphic[] N73csvO78i;

	protected virtual byte[] SnippetResource
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (byte[])lVQLT7q4VJcP7OupHw1();
		}
	}

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return sbvceLpQ9d;
		}
	}

	public override string ToolType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.KYCtX0ZipO();
		}
	}

	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)J2odnnq7ft42vm8lClO();
		}
	}

	public override bool IsReleased
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

	public override string Source
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Tools_PatMaxRedLinePatternIcon;
		}
	}

	public override string Icon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XAMLGraphicKeys.Tools_PatMaxRedLinePatternIcon;
		}
	}

	public override string[] Path
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return new string[1] { (string)tEdlRyq3R1qtycg1Snj() };
		}
	}

	public override int Order
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CQwcixHc31;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref CQwcixHc31, value, (string)AraNByq9DTXCxhRrN4K(3256));
		}
	}

	public virtual bool AssignDefaultFixture
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

	public virtual bool AdjustRangeLimits
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

	public IReadOnlyList<string> Shapes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EditableGraphicHelper.EditableGraphicShapeNames(mustBeExtrudeable: false);
		}
	}

	public int ModelShapeIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return vAAckfLnor;
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
				default:
					FireAddGraphicsChanged(null, null);
					num = 5;
					break;
				case 4:
					if (SetField(ref vAAckfLnor, value, (string)AraNByq9DTXCxhRrN4K(20866)))
					{
						_ = 1;
						num = ((!bD5v2QqEFmGPjjUGcuY()) ? 3 : 0);
						break;
					}
					return;
				case 1:
				case 3:
					xgYwufqj55VtyEyRg91(HmKc2XOn2h, ModelShapeIndex);
					goto default;
				case 5:
					return;
				}
			}
		}
	}

	public int SearchShapeIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return sC1cP0yy6o;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
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
			goto IL_003d;
			IL_001a:
			xgYwufqj55VtyEyRg91(WQscqpTt6J, SearchShapeIndex);
			goto IL_00a0;
			IL_003d:
			while (true)
			{
				IL_003d_2:
				switch (num)
				{
				case 1:
				case 4:
					break;
				case 0:
					while (true)
					{
						if (SetField(ref sC1cP0yy6o, value, (string)AraNByq9DTXCxhRrN4K(20900)))
						{
							_ = 1;
							if (!bD5v2QqEFmGPjjUGcuY())
							{
								break;
							}
							num = 3;
							if (0 == 0)
							{
								goto IL_003d_2;
							}
							continue;
						}
						return;
					}
					num = 4;
					if (true)
					{
						continue;
					}
					goto IL_00a0;
				default:
					goto IL_00a0;
				case 5:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_00a0:
			FireAddGraphicsChanged(null, null);
			num = 5;
			goto IL_003d;
		}
	}

	public PointF Center
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PointF.Empty;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RedLineToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		while (true)
		{
			switch (num)
			{
			case 9:
				base._002Ector();
				num = 4;
				break;
			case 3:
			case 7:
				_showModelOffset = _pasteObject.GetCellOffset((string)AraNByq9DTXCxhRrN4K(20040));
				num = 11;
				if (true)
				{
					break;
				}
				goto case 10;
			case 10:
				_imageOffset = _pasteObject.GetCellOffset(CdQUGaROfy7He9T0foW.KbIzwHEDLa(4928));
				num = 0;
				if (!bD5v2QqEFmGPjjUGcuY())
				{
					break;
				}
				goto case 8;
			case 8:
				QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
				num = 9;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
				AddSnippet(_pasteObject);
				num = 12;
				break;
			case 0:
				_fixtureOffset = _pasteObject.GetCellOffset(CdQUGaROfy7He9T0foW.KbIzwHEDLa(6522));
				num = 2;
				if (o9vsO8qq7jTUdgvUyJn())
				{
					break;
				}
				goto case 2;
			case 2:
				_modelRegionOffset = _pasteObject.GetCellOffset((string)AraNByq9DTXCxhRrN4K(20074));
				_searchRegionOffset = _pasteObject.GetCellOffset(CdQUGaROfy7He9T0foW.KbIzwHEDLa(6650));
				goto default;
			default:
				_ = 1;
				num = (bD5v2QqEFmGPjjUGcuY() ? 3 : 5);
				break;
			case 5:
			case 6:
				_trainOffset = _pasteObject.GetCellOffset((string)AraNByq9DTXCxhRrN4K(20234));
				goto case 3;
			case 11:
				_numberFoundOffset = _pasteObject.GetCellOffset((string)AraNByq9DTXCxhRrN4K(6096));
				num = 1;
				break;
			case 4:
				_pasteObject = (PasteBuffer)QCaq0dqXKOAByW8RCkR(V4Z2qXqpvb4WbvsnKxU(this));
				num = 10;
				break;
			case 12:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateTool_003Ed__35))]
	public override Task<EzTool> CreateTool(Guid guid, CvsCellCollection cells, CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateTool_003Ed__35 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cells = cells;
		stateMachine.cellRange = cellRange;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnBeginAddInternal_003Ed__46))]
	protected override Task OnBeginAddInternal()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!o9vsO8qq7jTUdgvUyJn()) ? 1 : 4);
		_003COnBeginAddInternal_003Ed__46 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 5;
				continue;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 2;
				if (o9vsO8qq7jTUdgvUyJn())
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
	protected override void UpdateFeatureGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		RectangleF rectangleF = default;
		PointF location = default;
		CvsCogImage cvsCogImage = default;
		SourceLink currentInputImageLink = default;
		SizeF size = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				PdIe0rqYmjHQPj2gt4k(WQscqpTt6J, rectangleF);
				num = 11;
				break;
			case 6:
				location = new PointF(cvsCogImage.OffsetX, kjIypRqFbG8Rp98pNDm(cvsCogImage));
				goto case 9;
			default:
				num = 9;
				break;
			case 8:
				base.UpdateFeatureGraphics();
				_ = 0;
				num = ((!o9vsO8qq7jTUdgvUyJn()) ? 2 : 4);
				break;
			case 0:
				cvsCogImage = oKNRN0q0adFWgr1WYaA(((CvsCell)IkV44Tqymnukp53WltX(H6qAGCqRE1Nd0y7riuk(SP51mqqAwxoQRxOL0na(BsXLOAqCAI0O4BdAReN(DCxU5pq6JulvQngKUtQ(this)))), lGfj8pqT10vs0HPJa7S(eEDdOhqW0bkncruKoMn(currentInputImageLink)))).CellResult) as CvsCogImage;
				goto case 2;
			case 7:
				PdIe0rqYmjHQPj2gt4k(HmKc2XOn2h, rectangleF);
				num = 5;
				if (o9vsO8qq7jTUdgvUyJn())
				{
					break;
				}
				goto case 2;
			case 2:
			case 3:
				if (cvsCogImage != null)
				{
					num = 6;
					break;
				}
				return;
			case 1:
			case 4:
				currentInputImageLink = CurrentInputImageLink;
				num = 0;
				break;
			case 10:
				rectangleF = new RectangleF(location, size);
				num = 7;
				if (!bD5v2QqEFmGPjjUGcuY())
				{
					break;
				}
				goto case 9;
			case 9:
				size = new SizeF(cvsCogImage.Width, n54BcNqMVxrDlLL719r(cvsCogImage));
				num = 10;
				break;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetEditableGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return N73csvO78i;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddTool_003Ed__50))]
	public override Task<EzTool> AddTool()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddTool_003Ed__50 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetUpdates_003Ed__51))]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetUpdates_003Ed__51(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__cells = cells,
			_003C_003E3__range = range
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateNewRedLineTool_003Ed__52))]
	protected virtual Task<RedLineTool> CreateNewRedLineTool(InspectStepViewModel inspect, CvsCellCollection cells, CvsCellRange pasteRange, bool isInitialized)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateNewRedLineTool_003Ed__52 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<RedLineTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.inspect = inspect;
		stateMachine.cells = cells;
		stateMachine.pasteRange = pasteRange;
		stateMachine.isInitialized = isInitialized;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task OnGraphicChanged(object sender, CvsEditEventArgs e)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (o9vsO8qq7jTUdgvUyJn())
		{
			num = 4;
		}
		else
		{
			num = 3;
			if (!o9vsO8qq7jTUdgvUyJn())
			{
				goto IL_0061;
			}
		}
		goto IL_00c3;
		IL_00c3:
		CvsEditableDisplayGraphic cvsEditableDisplayGraphic = default;
		RectangleF boundingBox = default;
		ICvsEditableDisplayGraphic cvsEditableDisplayGraphic2 = default;
		RectangleF rectangleF = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				cvsEditableDisplayGraphic = TkCXXZqULUXgPJkNVQt(e) as CvsEditableDisplayGraphic;
				goto case 1;
			case 11:
				break;
			case 5:
				M5gSaPqxx9b36g9lMxT(cvsEditableDisplayGraphic);
				boundingBox = WQscqpTt6J.BoundingBox;
				num = 9;
				continue;
			case 10:
				if (cvsEditableDisplayGraphic2 != HmKc2XOn2h)
				{
					if (cvsEditableDisplayGraphic2 == WQscqpTt6J)
					{
						num = 5;
						continue;
					}
					goto case 2;
				}
				num = 6;
				continue;
			case 7:
				rectangleF = kbKyvnqmrpeCLnrEUco(HmKc2XOn2h);
				goto case 8;
			default:
				num = 8;
				continue;
			case 8:
				H2DsvoqQGTEjfRjuWa8(WQscqpTt6J, rectangleF);
				num = 2;
				continue;
			case 6:
				M5gSaPqxx9b36g9lMxT(cvsEditableDisplayGraphic);
				num = 7;
				continue;
			case 9:
				EsgsD8qN74aP4qGAQFt(HmKc2XOn2h, boundingBox);
				num = 12;
				continue;
			case 1:
			case 3:
				if (cvsEditableDisplayGraphic != null)
				{
					num = 11;
					continue;
				}
				goto case 2;
			case 2:
			case 12:
				return (Task)tF6FcPq2U5tptQhyqDo();
			}
			break;
		}
		goto IL_0061;
		IL_0061:
		cvsEditableDisplayGraphic2 = (ICvsEditableDisplayGraphic)jOD6GZqHRQqGxvtUstZ(cvsEditableDisplayGraphic);
		num = 10;
		goto IL_00c3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSearchRegionShape(int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (o9vsO8qq7jTUdgvUyJn())
		{
			num = 3;
		}
		else
		{
			num = 2;
			if (bD5v2QqEFmGPjjUGcuY())
			{
				goto IL_0041;
			}
		}
		goto IL_0080;
		IL_0080:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				sC1cP0yy6o = index;
				goto case 1;
			case 4:
				break;
			case 1:
			case 2:
				xgYwufqj55VtyEyRg91(WQscqpTt6J, SearchShapeIndex);
				break;
			default:
				goto IL_009d;
			case 5:
				return;
			}
			break;
			IL_009d:
			num = 4;
		}
		goto IL_0041;
		IL_0041:
		FireAddGraphicsChanged(null, null);
		num = 5;
		if (bD5v2QqEFmGPjjUGcuY())
		{
		}
		goto IL_0080;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetModelRegionShape(int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		bD5v2QqEFmGPjjUGcuY();
		int num = ((!o9vsO8qq7jTUdgvUyJn()) ? 4 : 3);
		while (true)
		{
			switch (num)
			{
			case 1:
				EditableGraphicHelper.UpdateGraphicShape(HmKc2XOn2h, ModelShapeIndex);
				break;
			case 0:
			case 3:
				vAAckfLnor = index;
				num = 1;
				if (true)
				{
					continue;
				}
				break;
			case 5:
				return;
			}
			FireAddGraphicsChanged(null, null);
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RedLineToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		sbvceLpQ9d = new Guid[1]
		{
			new Guid(CdQUGaROfy7He9T0foW.KbIzwHEDLa(20936))
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task qR8cvPUc4f()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnBeginAddInternal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object V4Z2qXqpvb4WbvsnKxU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((RedLineToolType)P_0).SnippetResource;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QCaq0dqXKOAByW8RCkR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AraNByq9DTXCxhRrN4K(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool o9vsO8qq7jTUdgvUyJn()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bD5v2QqEFmGPjjUGcuY()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lVQLT7q4VJcP7OupHw1()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.PatMaxRedLine;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object J2odnnq7ft42vm8lClO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.c9T0M3KvP1();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tEdlRyq3R1qtycg1Snj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.F0Z0bUM6Xp();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xgYwufqj55VtyEyRg91(object P_0, int index)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EditableGraphicHelper.UpdateGraphicShape((CvsDisplayableComposite)P_0, index);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DCxU5pq6JulvQngKUtQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((EzToolType)P_0).Inspect;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BsXLOAqCAI0O4BdAReN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((AppStepViewModel)P_0).InSight;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SP51mqqAwxoQRxOL0na(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Results;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object H6qAGCqRE1Nd0y7riuk(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsResultSet)P_0).Cells;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eEDdOhqW0bkncruKoMn(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SourceLink)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation lGfj8pqT10vs0HPJa7S(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCellLocation.TryParse((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IkV44Tqymnukp53WltX(object P_0, CvsCellLocation P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object oKNRN0q0adFWgr1WYaA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogCellResult)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int kjIypRqFbG8Rp98pNDm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImage)P_0).OffsetY;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int n54BcNqMVxrDlLL719r(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogImage)P_0).Height;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PdIe0rqYmjHQPj2gt4k(object P_0, RectangleF P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsEditableDisplayGraphic)P_0).EditBounds = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object TkCXXZqULUXgPJkNVQt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditEventArgs)P_0).Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jOD6GZqHRQqGxvtUstZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).Parent;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool M5gSaPqxx9b36g9lMxT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).Fit();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RectangleF kbKyvnqmrpeCLnrEUco(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).BoundingBox;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool H2DsvoqQGTEjfRjuWa8(object P_0, RectangleF P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).FitToContain(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EsgsD8qN74aP4qGAQFt(object P_0, RectangleF P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsEditableDisplayGraphic)P_0).FitWithin(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tF6FcPq2U5tptQhyqDo()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Task.CompletedTask;
	}
}
