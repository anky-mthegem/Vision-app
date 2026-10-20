using System;
using System.Collections;
using System.Collections.Generic;
using System.Composition;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AYcpgJR0ngPvVcDpiKJ;
using Cognex.Cnx.Imaging;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.Display.Internal;
using Cognex.InSight.EasyBuilder.ResourceData;
using Cognex.InSight.EasyBuilder.ViewModels.Extensions;
using Cognex.InSight.EasyBuilder.ViewModels.Framework;
using Cognex.InSight.EasyBuilder.ViewModels.Properties;
using Cognex.InSight.EasyBuilder.ViewModels.SnippetUpdate;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.CellViewModels;
using Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Links;
using Cognex.InSight.Graphic;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using oF2MOjpuTE9ryB96aX;
using sOsD6r2ordE20V9sta;
using zsQqWwRgKaAshfKAktM;

namespace Cognex.InSight.EasyBuilder.ViewModels.Steps.Inspect.Tools.FindEdge;

[Export(typeof(EzToolType))]
public class FindEdgeToolType : EzToolType, IGraphicInvalidateToolType
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateTool_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public FindEdgeToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsCellRange cellRange;

		private FindEdgeTool _003Ctool_003E5__2;

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
			FindEdgeToolType findEdgeToolType = default;
			TaskAwaiter awaiter = default;
			EzTool result = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					_003Ctool_003E5__2 = null;
					goto case 3;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							_003Ctool_003E5__2 = new FindEdgeTool((InspectStepViewModel)By3HVBKYi23vBVZHwAbA(findEdgeToolType), isInitialized: true);
							_ = 0;
							num3 = ((!C7B5JaKYIAI4ndIvmQjC()) ? 3 : 4);
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 4:
								awaiter = _003Ctool_003E5__2.SetCellRangeAsync(cells, cellRange).GetAwaiter();
								goto case 1;
							case 9:
								return;
							case 8:
								awaiter.GetResult();
								num3 = 10;
								continue;
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								continue;
							case 7:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 8;
								continue;
							case 1:
							case 3:
								if (awaiter.IsCompleted)
								{
									goto case 8;
								}
								num3 = 5;
								if (0 == 0)
								{
									continue;
								}
								goto case 6;
							case 6:
								_003C_003Eu__1 = awaiter;
								goto case 2;
							default:
								num3 = 2;
								continue;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								continue;
							case 10:
								result = _003Ctool_003E5__2;
								break;
							}
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
					goto case 6;
				default:
					num = 6;
					break;
				case 5:
					num2 = _003C_003E1__state;
					num = 0;
					break;
				case 3:
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					break;
				case 0:
					findEdgeToolType = _003C_003E4__this;
					_ = 1;
					if (i5qvKPKYDRuamp8s9QJP())
					{
						num = 3;
						if (true)
						{
							break;
						}
						goto case 1;
					}
					num = 1;
					if (1 == 0)
					{
						return;
					}
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
		internal static object By3HVBKYi23vBVZHwAbA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool C7B5JaKYIAI4ndIvmQjC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool i5qvKPKYDRuamp8s9QJP()
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
	private struct _003COnBeginAddInternal_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FindEdgeToolType _003C_003E4__this;

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
			if (I4Qx6AKYnRnLMSXTwBwq())
			{
				num = 3;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 5;
				if (!I4Qx6AKYnRnLMSXTwBwq())
				{
					return;
				}
			}
			goto IL_0300;
			IL_003d:
			FindEdgeToolType findEdgeToolType = _003C_003E4__this;
			num = 2;
			goto IL_0300;
			IL_0300:
			int num2 = default;
			TaskAwaiter awaiter = default;
			CvsCell imageCell = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 1:
				case 5:
					goto IL_003d;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							findEdgeToolType.ShowLine = false;
							num3 = 4;
							if (false)
							{
								goto IL_0067;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
						}
						goto IL_00c5;
						IL_00c5:
						while (true)
						{
							switch (num3)
							{
							case 10:
								break;
							default:
								findEdgeToolType.IZJ4m5wlfO = (CvsEditableDisplayGraphic[])uj6CtRKYZMplDtfxmVvN(findEdgeToolType.Wp44nN5IP4());
								num3 = 10;
								if (true)
								{
									continue;
								}
								goto case 5;
							case 5:
							case 6:
								SundX5KYvDPbDY1IHsKm(findEdgeToolType.RnI4hXWjht, false);
								goto default;
							case 15:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								num3 = 15;
								continue;
							case 4:
							{
								CvsCellLocation cvsCellLocation = CvsCellLocation.Parse((string)yLfX12KYfDjhlVlEQABx(findEdgeToolType.CurrentInputImageLink));
								imageCell = (CvsCell)V5702AKYsUVQ745L8qIy(tgcrg0KYgmWJvvNI4rKb(zaftEaKYlTG67xn6RvUn(BLoRpvKYdEkufokD2qRh(findEdgeToolType.Inspect))), cvsCellLocation);
								num3 = 14;
								continue;
							}
							case 11:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								continue;
							case 3:
								findEdgeToolType.RnI4hXWjht.Color = Color.Red;
								num3 = 0;
								if (true)
								{
									continue;
								}
								goto case 12;
							case 12:
								SundX5KYvDPbDY1IHsKm(findEdgeToolType.z2F4rG2Twc, false);
								num3 = 13;
								continue;
							case 0:
								goto IL_01cd;
							case 1:
								_003C_003Eu__1 = default;
								num3 = 11;
								continue;
							case 13:
								findEdgeToolType.RnI4hXWjht = EditableGraphicHelper.ConstructLine(CvsCellLocation.Invalid, 100.0, 100.0, 400.0, 100.0, imageCell);
								num3 = 3;
								if (SQSbVfKYVQquXGiqrUV7())
								{
								}
								continue;
							case 9:
								return;
							case 14:
								findEdgeToolType.z2F4rG2Twc = EditableGraphicHelper.ConstructRegion(CvsCellLocation.Invalid, 100.0, 100.0, 50.0, 200.0, 0.0, 0.0, imageCell);
								num3 = 12;
								continue;
							case 16:
								goto IL_02be;
							}
							break;
							IL_01cd:
							vqp3kSKYPoPSDiM6tNZg(findEdgeToolType.RnI4hXWjht, dnVoIIKYrTQHHLmJviQr());
							SQSbVfKYVQquXGiqrUV7();
							num3 = (I4Qx6AKYnRnLMSXTwBwq() ? 5 : 2);
						}
						goto IL_0067;
						IL_02be:
						awaiter.GetResult();
						goto end_IL_004e;
						IL_0067:
						awaiter = UwAR3hKYB6P4CSEQQt3M(findEdgeToolType.HKD4Y6dblu());
						if (!awaiter.IsCompleted)
						{
							num3 = 8;
							goto IL_00c5;
						}
						goto IL_02be;
						end_IL_004e:;
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
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto IL_003d;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (false)
			{
				goto IL_003d;
			}
			goto IL_0300;
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
		internal static object yLfX12KYfDjhlVlEQABx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BLoRpvKYdEkufokD2qRh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zaftEaKYlTG67xn6RvUn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tgcrg0KYgmWJvvNI4rKb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object V5702AKYsUVQ745L8qIy(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void SundX5KYvDPbDY1IHsKm(object P_0, bool P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsDisplayableGraphic)P_0).Visible = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Color dnVoIIKYrTQHHLmJviQr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Color.OrangeRed;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vqp3kSKYPoPSDiM6tNZg(object P_0, Color P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((CvsDisplayableGraphic)P_0).SelectedColor = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object uj6CtRKYZMplDtfxmVvN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter UwAR3hKYB6P4CSEQQt3M(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool I4Qx6AKYnRnLMSXTwBwq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SQSbVfKYVQquXGiqrUV7()
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

		public static Func<CvsEditableDisplayGraphic, bool> _003C_003E9__39_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			YZN9J0KYoXTWeGVQaNMC();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			YZN9J0KYoXTWeGVQaNMC();
			M8SE9pKYS5fnsyYU47CO(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CAddTool_003Eb__39_0(CvsEditableDisplayGraphic g)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return jldveWKYkArB8hb9ETxo(g);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void YZN9J0KYoXTWeGVQaNMC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LyiQFuKYbpfof36mEygy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AA40eSKYGmak7igHXAHs()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void M8SE9pKYS5fnsyYU47CO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jldveWKYkArB8hb9ETxo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsEditableDisplayGraphic)P_0).Selected;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddTool_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public FindEdgeToolType _003C_003E4__this;

		private TaskAwaiter<EzTool> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			wYhFMAKY8g7myaaW3CgC();
			int num;
			if (!LByYaHKYqqLtZHSt4wXj())
			{
				num = 5;
			}
			else
			{
				num = 2;
				if (1 == 0)
				{
					goto IL_0041;
				}
			}
			goto IL_02fb;
			IL_02fb:
			int num2 = default;
			FindEdgeToolType findEdgeToolType = default;
			TaskAwaiter<EzTool> awaiter = default;
			CvsDisplayableRegion editableRegion = default;
			CvsDisplayableLine cvsDisplayableLine = default;
			EzTool result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					break;
				case 1:
				case 2:
					findEdgeToolType = _003C_003E4__this;
					num = 3;
					continue;
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 12;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 16;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
						}
						while (true)
						{
							switch (num3)
							{
							case 15:
								if (!awaiter.IsCompleted)
								{
									num3 = 14;
									continue;
								}
								break;
							case 14:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 17;
								continue;
							case 11:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 13;
								continue;
							case 9:
								goto end_IL_01a9;
							case 0:
							case 10:
								awaiter = findEdgeToolType.AddTool(editableRegion).GetAwaiter();
								num3 = 15;
								if (LByYaHKYqqLtZHSt4wXj())
								{
								}
								continue;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 1;
									if (!LByYaHKYqqLtZHSt4wXj())
									{
										continue;
									}
									return;
								}
								goto case 5;
							case 13:
								return;
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
								continue;
							case 3:
								if (cvsDisplayableLine == null)
								{
									editableRegion = findEdgeToolType.IZJ4m5wlfO.OfType<CvsDisplayableRegion>().FirstOrDefault();
									goto case 0;
								}
								awaiter = findEdgeToolType.YBE4tPvMRf(cvsDisplayableLine).GetAwaiter();
								num3 = 6;
								continue;
							case 4:
								num2 = (_003C_003E1__state = -1);
								goto default;
							default:
								LByYaHKYqqLtZHSt4wXj();
								num3 = (wYhFMAKY8g7myaaW3CgC() ? 5 : 0);
								continue;
							case 12:
								cvsDisplayableLine = findEdgeToolType.IZJ4m5wlfO.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (CvsEditableDisplayGraphic g) =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									return _003C_003Ec.jldveWKYkArB8hb9ETxo(g);
								}) as CvsDisplayableLine;
								num3 = 3;
								continue;
							case 16:
								_003C_003Eu__1 = default;
								num3 = 7;
								continue;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 4;
								continue;
							case 17:
								return;
							case 1:
								_003C_003Eu__1 = awaiter;
								num3 = 11;
								continue;
							case 5:
							case 8:
								result = awaiter.GetResult();
								num3 = 9;
								continue;
							case 18:
								break;
							}
							result = awaiter.GetResult();
							break;
							continue;
							end_IL_01a9:
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
					break;
				default:
					num = 4;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_0041;
			IL_0041:
			_003C_003Et__builder.SetResult(result);
			num = 6;
			goto IL_02fb;
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
		internal static bool wYhFMAKY8g7myaaW3CgC()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LByYaHKYqqLtZHSt4wXj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetUpdates_003Ed__40 : IEnumerable<ISnippetUpdate>, IEnumerable, IEnumerator<ISnippetUpdate>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private ISnippetUpdate _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private CvsCellCollection cells;

		public CvsCellCollection _003C_003E3__cells;

		private CvsCellRange range;

		public CvsCellRange _003C_003E3__range;

		public FindEdgeToolType _003C_003E4__this;

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
		public _003CGetUpdates_003Ed__40(int _003C_003E1__state)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			do
			{
				IL_0031:
				switch (num)
				{
				case 0:
				case 2:
					this._003C_003E1__state = _003C_003E1__state;
					break;
				case 1:
					kVG3mCKYXCXZPk74u1Jo();
					num = 5;
					goto IL_0031;
				case 5:
					base._002Ector();
					_ = 0;
					if (!lApNqMKYEdfd2qAGY7Kk())
					{
						num = 4;
						goto IL_0031;
					}
					num = 0;
					if (lApNqMKYEdfd2qAGY7Kk())
					{
						goto IL_0031;
					}
					break;
				case 6:
					return;
				}
				_003C_003El__initialThreadId = AghJlVKY97e5FcBoe3Dr();
				num = 6;
			}
			while (!InrnkkKYp5G6fgmiVP0H());
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
			FindEdgeToolType findEdgeToolType = default;
			if (true)
			{
				CvsCellLocation offset = default;
				int num2 = default;
				CvsCellLocation offset2 = default;
				while (true)
				{
					switch (num)
					{
					case 14:
					case 22:
						break;
					case 11:
						_003C_003E2__current = new EditArgumentUpdate(offset, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
						goto case 0;
					default:
						num = 0;
						continue;
					case 9:
						if (_003CcurrentVersion_003E5__2 < _003ClatestVersion_003E5__3)
						{
							_003C_003E2__current = new AddCellVersionUpdate(_003ClatestVersion_003E5__3, findEdgeToolType.Localizer);
							num = 18;
							continue;
						}
						goto IL_02ab;
					case 2:
					case 10:
						switch (num2)
						{
						case 6:
							break;
						default:
							goto IL_0154;
						case 1:
							goto IL_01d9;
						case 2:
							goto IL_021a;
						case 3:
							goto IL_0259;
						case 5:
							goto IL_02a4;
						case 4:
							goto IL_02f2;
						case 0:
							goto IL_0343;
						}
						_003C_003E1__state = -1;
						num = 25;
						continue;
					case 19:
						_003C_003E2__current = new EditArgumentUpdate(offset2, SnippetUpdateHelper.InputImageLocationFactory, 0, null);
						_003C_003E1__state = 3;
						num = 21;
						continue;
					case 3:
						num2 = _003C_003E1__state;
						num = 24;
						continue;
					case 5:
						offset = new CvsCellLocation(4, 1);
						num = 11;
						continue;
					case 0:
						_003C_003E1__state = 2;
						num = 4;
						continue;
					case 7:
						if (_003CcurrentVersion_003E5__2 >= 3)
						{
							goto case 9;
						}
						num = 8;
						if (true)
						{
							continue;
						}
						goto case 12;
					case 12:
						return true;
					case 6:
						_003C_003E1__state = 4;
						num = 15;
						continue;
					case 24:
						findEdgeToolType = _003C_003E4__this;
						_ = 0;
						if (lApNqMKYEdfd2qAGY7Kk())
						{
							num = 10;
							continue;
						}
						num = 14;
						if (true)
						{
							continue;
						}
						goto case 16;
					case 4:
						return true;
					case 23:
						_003CcurrentVersion_003E5__2 = YTfrBiKY4c2n6XxTjNL9(cells, range);
						num = 17;
						continue;
					case 21:
						return true;
					case 8:
						_003C_003E2__current = new sgcKMAebGgclKAUaRd(findEdgeToolType.Localizer, (CvsFunctionTable)zuJlB8KYj2JdrCxyV3C1(ppe6pGKY3HOdNjZDEpuQ(findEdgeToolType)), (IExpressionConstants)PUbTLjKY6MxcQkHc1loU(findEdgeToolType.InSight));
						num = 6;
						continue;
					case 18:
						_003C_003E1__state = 5;
						return true;
					case 16:
						_003C_003E1__state = 1;
						num = 12;
						continue;
					case 13:
						if (_003CcurrentVersion_003E5__2 < 2)
						{
							num = 5;
							continue;
						}
						goto case 7;
					case 15:
						return true;
					case 1:
						if (_003CcurrentVersion_003E5__2 >= 1)
						{
							goto case 13;
						}
						_003C_003E2__current = new ToolDisabledJobPassUpdate();
						num = 16;
						if (true)
						{
							continue;
						}
						goto case 17;
					case 17:
						_003ClatestVersion_003E5__3 = QbRQO3KY7Zhbn2nlO0eL(findEdgeToolType._pasteObject);
						num = 1;
						continue;
					case 20:
						return false;
					case 25:
						{
							return false;
						}
						IL_02ab:
						if (_003CcurrentVersion_003E5__2 < 4)
						{
							break;
						}
						goto case 25;
						IL_0343:
						_003C_003E1__state = -1;
						num = 23;
						continue;
						IL_02f2:
						_003C_003E1__state = -1;
						num = 9;
						continue;
						IL_02a4:
						_003C_003E1__state = -1;
						goto IL_02ab;
						IL_0259:
						_003C_003E1__state = -1;
						num = 7;
						continue;
						IL_021a:
						_003C_003E1__state = -1;
						offset2 = new CvsCellLocation(4, 2);
						num = 19;
						if (true)
						{
							continue;
						}
						goto case 23;
						IL_01d9:
						_003C_003E1__state = -1;
						num = 13;
						continue;
						IL_0154:
						num = 20;
						continue;
					}
					break;
				}
			}
			_003C_003E2__current = new AXWGRD6PhpEZe2JbB8(findEdgeToolType._pasteObject, (CvsFunctionTable)zuJlB8KYj2JdrCxyV3C1(ppe6pGKY3HOdNjZDEpuQ(findEdgeToolType)), (IExpressionConstants)PUbTLjKY6MxcQkHc1loU(findEdgeToolType.InSight));
			_003C_003E1__state = 6;
			return true;
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
			_003CGetUpdates_003Ed__40 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetUpdates_003Ed__40(0)
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
		internal static void kVG3mCKYXCXZPk74u1Jo()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int AghJlVKY97e5FcBoe3Dr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Environment.CurrentManagedThreadId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lApNqMKYEdfd2qAGY7Kk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool InrnkkKYp5G6fgmiVP0H()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int YTfrBiKY4c2n6XxTjNL9(object P_0, CvsCellRange range)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0).GetSnippetVersion(range);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int QbRQO3KY7Zhbn2nlO0eL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SnippetPasteBuffer.GetSnippetVersion((PasteBuffer)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ppe6pGKY3HOdNjZDEpuQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzSnippetType)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zuJlB8KYj2JdrCxyV3C1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).FunctionTable;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PUbTLjKY6MxcQkHc1loU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).ProcessorConstants;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddTool_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public CvsDisplayableLine editableLine;

		public FindEdgeToolType _003C_003E4__this;

		private CvsDisplayableRegion _003CdisplayableRegion_003E5__2;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__1;

		private TaskAwaiter<EzTool> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			if (!TiJAgIKYAb7upphtuKqW())
			{
			}
			int num2 = default;
			EzTool result = default;
			TaskAwaiter<EzTool> awaiter = default;
			TaskAwaiter<CvsCellCollection> awaiter2 = default;
			FindEdgeToolType findEdgeToolType = default;
			float num4 = default;
			CvsGraphicRegion region = default;
			double num5 = default;
			float num6 = default;
			PointF location = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					num2 = _003C_003E1__state;
					_ = 0;
					if (VlY0qyKYCi7jJUHwHQNA())
					{
						num = 3;
						if (true)
						{
							break;
						}
						goto case 2;
					}
					num = 2;
					if (!TiJAgIKYAb7upphtuKqW())
					{
						break;
					}
					goto case 5;
				case 2:
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					if (true)
					{
						break;
					}
					goto case 0;
				case 0:
					_003CdisplayableRegion_003E5__2 = null;
					goto case 2;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 3;
							}
							else
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num3 = 8;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 12:
							{
								CvsCellCollection result2 = awaiter2.GetResult();
								awaiter = findEdgeToolType.AddTool(_003CdisplayableRegion_003E5__2, result2).GetAwaiter();
								num3 = 11;
								continue;
							}
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								if (0 == 0)
								{
									continue;
								}
								goto case 9;
							case 9:
								awaiter2 = ((CvsCogSocketSheet)mPcahJKYUhGqH7qy35Dc(naTw2SKYYqj6UjJXmhGp(rjj3WAKYMWx4W91vG8oV(findEdgeToolType.Inspect)))).RunAndGetCellResults((Dictionary<string, object>)null).GetAwaiter();
								_ = 1;
								num3 = (TiJAgIKYAb7upphtuKqW() ? 16 : 18);
								continue;
							case 1:
								num4 = PointToPointDist(((CvsGraphicLine)pksdVYKYWvOkyR4rHYit(editableLine)).StartPoint, TPRG9uKYT4WcZwIrjn4q(pksdVYKYWvOkyR4rHYit(editableLine)));
								num3 = 15;
								continue;
							case 5:
								return;
							case 19:
								_003CdisplayableRegion_003E5__2 = new CvsDisplayableRegion(region);
								num3 = 9;
								continue;
							case 3:
								num5 = dtrXp0KYyJReSpXy2raB(I0VrL1KYRqFwgJWNUVB4(editableLine.Line), TPRG9uKYT4WcZwIrjn4q(pksdVYKYWvOkyR4rHYit(editableLine))) - 90.0;
								num6 = (float)(num5 * Math.PI / 180.0);
								num3 = 1;
								continue;
							case 13:
							case 16:
								num2 = (_003C_003E1__state = 1);
								num3 = 2;
								continue;
							case 15:
								location = new PointF((float)((double)((CvsGraphicLine)pksdVYKYWvOkyR4rHYit(editableLine)).StartPoint.X - 10.0 * ooCg3JKY0xchxMseGwQR(num6)), (float)((double)I0VrL1KYRqFwgJWNUVB4(editableLine.Line).Y - 10.0 * KIHPBkKYF0oIs8RqvnO5(num6)));
								num3 = 17;
								if (TiJAgIKYAb7upphtuKqW())
								{
								}
								continue;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 20;
								if (true)
								{
									continue;
								}
								goto case 6;
							case 6:
							case 18:
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num3 = 14;
									continue;
								}
								goto case 12;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							default:
								num3 = 5;
								if (0 == 0)
								{
									continue;
								}
								goto case 10;
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								if (!TiJAgIKYAb7upphtuKqW())
								{
									continue;
								}
								goto case 14;
							case 14:
								_003C_003Eu__1 = awaiter2;
								num3 = 7;
								continue;
							case 4:
								return;
							case 2:
								_003C_003Eu__2 = awaiter;
								num3 = 10;
								if (true)
								{
									continue;
								}
								goto case 17;
							case 17:
								region = new CvsGraphicRegion(CvsCellLocation.Invalid, location, num4, 20.0, (float)num5, 0.0, string.Empty);
								num3 = 19;
								continue;
							case 11:
								if (awaiter.IsCompleted)
								{
									break;
								}
								goto case 13;
							case 20:
								break;
							}
							break;
						}
						result = awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CdisplayableRegion_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 0;
				default:
					num = 0;
					break;
				case 1:
				case 3:
					findEdgeToolType = _003C_003E4__this;
					num = 5;
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
		internal static PointF I0VrL1KYRqFwgJWNUVB4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphicLine)P_0).StartPoint;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pksdVYKYWvOkyR4rHYit(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsDisplayableLine)P_0).Line;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PointF TPRG9uKYT4WcZwIrjn4q(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsGraphicLine)P_0).EndPoint;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double dtrXp0KYyJReSpXy2raB(PointF p0, PointF p1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return PointToPointAngle(p0, p1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double ooCg3JKY0xchxMseGwQR(double P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Math.Cos(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double KIHPBkKYF0oIs8RqvnO5(double P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Math.Sin(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rjj3WAKYMWx4W91vG8oV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object naTw2SKYYqj6UjJXmhGp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mPcahJKYUhGqH7qy35Dc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VlY0qyKYCi7jJUHwHQNA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TiJAgIKYAb7upphtuKqW()
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
	private struct _003CAddTool_003Ed__42 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<EzTool> _003C_003Et__builder;

		public FindEdgeToolType _003C_003E4__this;

		public CvsCellCollection cells;

		public CvsDisplayableRegion editableRegion;

		private CvsCogSocketSheet _003Csheet_003E5__2;

		private CvsCellRange _003CpasteRange_003E5__3;

		private object _003C_003E7__wrap3;

		private bool _003ColdPass_003E5__5;

		private FindEdgeTool _003CnewTool_003E5__6;

		private TaskAwaiter<CvsCellRange> _003C_003Eu__1;

		private TaskAwaiter<object> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__4;

		private TaskAwaiter<CvsCellCollection> _003C_003Eu__5;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			TaskAwaiter awaiter = default;
			FindEdgeToolType findEdgeToolType = default;
			TaskAwaiter<CvsCellRange> awaiter4 = default;
			TaskAwaiter<object> awaiter5 = default;
			TaskAwaiter<CvsCogSheetResult> awaiter3 = default;
			TaskAwaiter<CvsCellCollection> awaiter2 = default;
			CvsCellCollection result3 = default;
			string expression = default;
			CvsCellLocation cellLocation = default;
			CvsCellRange result2 = default;
			EzTool result = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 6:
					num2 = _003C_003E1__state;
					_ = 1;
					if (!GbqoLRKYx6BSP0wDC28l())
					{
						num = 2;
						break;
					}
					num = 4;
					if (KcSWq2KYHQZn3krRgyLg())
					{
						break;
					}
					goto case 1;
				default:
					_003Csheet_003E5__2 = null;
					num = 0;
					break;
				case 5:
					try
					{
						int num3;
						if ((uint)num2 > 8u)
						{
							if (num2 == 9)
							{
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0a35;
							}
							_003Csheet_003E5__2 = (CvsCogSocketSheet)SBgRq5KY22IJIs1KxD50(XLTgHVKYNGnAdub0ZHsh(VMsgKDKYQN39yYfGjuOd(jHFrufKYmdv1psVNmArS(findEdgeToolType))));
							_003CpasteRange_003E5__3 = CvsCellRange.Empty;
							num3 = 0;
						}
						try
						{
							int num4;
							switch (num2)
							{
							default:
								awaiter4 = findEdgeToolType.RenameAndPasteTool(findEdgeToolType._pasteObject, cells, runSheet: false).GetAwaiter();
								num4 = 58;
								if (false)
								{
									goto IL_00ce;
								}
								goto IL_03ac;
							case 2:
								awaiter = _003C_003Eu__3;
								num4 = 1;
								if (false)
								{
									goto IL_00fa;
								}
								goto IL_03ac;
							case 7:
								awaiter = _003C_003Eu__3;
								num4 = 37;
								goto IL_03ac;
							case 1:
								awaiter5 = _003C_003Eu__2;
								num4 = 36;
								if (false)
								{
									goto IL_0264;
								}
								goto IL_03ac;
							case 0:
								awaiter4 = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num4 = 6;
								if (GbqoLRKYx6BSP0wDC28l())
								{
									goto IL_02bb;
								}
								goto IL_03ac;
							case 3:
								awaiter3 = _003C_003Eu__4;
								num4 = 2;
								goto IL_03ac;
							case 5:
								awaiter2 = _003C_003Eu__5;
								num4 = 19;
								if (0 == 0)
								{
									goto IL_03ac;
								}
								goto IL_04f7;
							case 8:
								awaiter2 = _003C_003Eu__5;
								num4 = 57;
								goto IL_03ac;
							case 4:
								awaiter = _003C_003Eu__3;
								num4 = 5;
								goto IL_03ac;
							case 6:
								{
									awaiter = _003C_003Eu__3;
									num4 = 46;
									goto IL_03ac;
								}
								IL_03ac:
								while (true)
								{
									switch (num4)
									{
									case 52:
										break;
									case 44:
										return;
									case 8:
										goto IL_00fa;
									case 11:
										goto IL_011a;
									case 21:
										return;
									case 62:
										num2 = (_003C_003E1__state = -1);
										num4 = 48;
										continue;
									case 49:
										_003ColdPass_003E5__5 = ((CvsCell)a45oxIKYhnJoEuwTgNuX(result3, findEdgeToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, findEdgeToolType.YS4495gJ1M))).CellValue.Equals(1.0);
										_003CnewTool_003E5__6 = new FindEdgeTool((InspectStepViewModel)jHFrufKYmdv1psVNmArS(findEdgeToolType), isInitialized: false);
										num4 = 35;
										continue;
									case 0:
										goto IL_01bd;
									case 3:
										_003C_003Eu__3 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 4;
										continue;
									case 18:
										return;
									case 2:
										goto IL_0264;
									case 26:
										if (!awaiter3.IsCompleted)
										{
											num4 = 56;
											if (0 == 0)
											{
												continue;
											}
											return;
										}
										goto IL_04f7;
									case 12:
										return;
									case 20:
										goto IL_02bb;
									case 34:
										result3 = awaiter2.GetResult();
										num4 = 49;
										if (KcSWq2KYHQZn3krRgyLg())
										{
											continue;
										}
										goto case 13;
									case 13:
										awaiter.GetResult();
										num4 = 22;
										if (true)
										{
											continue;
										}
										goto case 41;
									case 41:
									case 51:
										if (!awaiter.IsCompleted)
										{
											num2 = (_003C_003E1__state = 6);
											num4 = 53;
											continue;
										}
										goto case 14;
									case 38:
										_003C_003Eu__4 = awaiter3;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										return;
									case 59:
										awaiter = WkVW6gKYu4t3vgSNXdrV(InputFixtureViewModel.YnAyJgATSB((InspectStepViewModel)jHFrufKYmdv1psVNmArS(findEdgeToolType), expression, cellLocation));
										if (!awaiter.IsCompleted)
										{
											num4 = 17;
											continue;
										}
										goto IL_068e;
									case 46:
										_003C_003Eu__3 = default;
										num4 = 52;
										if (KcSWq2KYHQZn3krRgyLg())
										{
											continue;
										}
										goto case 5;
									case 5:
										_003C_003Eu__3 = default;
										goto case 27;
									default:
										num4 = 27;
										continue;
									case 14:
										awaiter.GetResult();
										num4 = 39;
										continue;
									case 53:
										_003C_003Eu__3 = awaiter;
										num4 = 32;
										continue;
									case 10:
										return;
									case 48:
										goto IL_04f7;
									case 30:
										goto IL_0543;
									case 17:
										goto IL_0577;
									case 19:
										goto IL_0590;
									case 57:
										_003C_003Eu__5 = default;
										num4 = 0;
										continue;
									case 35:
										awaiter = WkVW6gKYu4t3vgSNXdrV(_003CnewTool_003E5__6.SetCellRangeAsync(result3, _003CpasteRange_003E5__3));
										goto case 41;
									case 37:
										_003C_003Eu__3 = default;
										num2 = (_003C_003E1__state = -1);
										num4 = 13;
										continue;
									case 50:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										return;
									case 31:
										_003C_003Eu__3 = awaiter;
										num4 = 33;
										if (KcSWq2KYHQZn3krRgyLg())
										{
											continue;
										}
										goto case 33;
									case 33:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 44;
										continue;
									case 9:
										if (!awaiter.IsCompleted)
										{
											num2 = (_003C_003E1__state = 4);
											num4 = 3;
											continue;
										}
										goto case 42;
									case 1:
										_003C_003Eu__3 = default;
										num2 = (_003C_003E1__state = -1);
										goto IL_068e;
									case 61:
										num2 = (_003C_003E1__state = 7);
										_003C_003Eu__3 = awaiter;
										num4 = 29;
										continue;
									case 45:
										_003C_003Eu__1 = awaiter4;
										num4 = 54;
										continue;
									case 39:
										awaiter = WkVW6gKYu4t3vgSNXdrV(DynamicThresholdCalculator.DynamicallyThresholdTool(_003Csheet_003E5__2, findEdgeToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, findEdgeToolType.YS4495gJ1M), (EditIntViewModel)wQ9yiAKYtXm7uAkdw2mF(_003CnewTool_003E5__6)));
										num4 = 60;
										continue;
									case 22:
										if (_003ColdPass_003E5__5)
										{
											goto end_IL_007f;
										}
										num4 = 30;
										if (0 == 0)
										{
											continue;
										}
										goto case 29;
									case 29:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 21;
										continue;
									case 4:
										return;
									case 40:
										cellLocation = findEdgeToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, findEdgeToolType.sam4JSvnE7);
										num4 = 59;
										if (GbqoLRKYx6BSP0wDC28l())
										{
										}
										continue;
									case 25:
										_003C_003Eu__5 = awaiter2;
										num4 = 50;
										continue;
									case 56:
										num2 = (_003C_003E1__state = 3);
										num4 = 38;
										continue;
									case 23:
										num2 = (_003C_003E1__state = 1);
										num4 = 8;
										continue;
									case 43:
										num2 = (_003C_003E1__state = 0);
										num4 = 45;
										continue;
									case 28:
										if (!awaiter5.IsCompleted)
										{
											num4 = 23;
											continue;
										}
										goto IL_0853;
									case 7:
									case 55:
										_003CpasteRange_003E5__3 = result2;
										awaiter5 = _003Csheet_003E5__2.PutCellExpressionAsync(findEdgeToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, findEdgeToolType.Y8M4V5sdA7), (string)GvSAurKY10Y1QqW6crJg(findEdgeToolType.InputImageLinks[xpmF3HKYcS3BI67O6sH1(findEdgeToolType)])).GetAwaiter();
										num4 = 28;
										if (KcSWq2KYHQZn3krRgyLg())
										{
											continue;
										}
										goto case 24;
									case 24:
										num2 = (_003C_003E1__state = -1);
										goto IL_0853;
									case 42:
										awaiter.GetResult();
										awaiter2 = _003Csheet_003E5__2.RunAndGetCellResults().GetAwaiter();
										if (awaiter2.IsCompleted)
										{
											goto case 34;
										}
										num4 = 15;
										if (KcSWq2KYHQZn3krRgyLg())
										{
											continue;
										}
										goto case 36;
									case 36:
										_003C_003Eu__2 = default;
										num4 = 24;
										if (KcSWq2KYHQZn3krRgyLg())
										{
											continue;
										}
										goto case 6;
									case 6:
										num2 = (_003C_003E1__state = -1);
										num4 = 11;
										continue;
									case 58:
										if (!awaiter4.IsCompleted)
										{
											num4 = 43;
											if (GbqoLRKYx6BSP0wDC28l())
											{
											}
											continue;
										}
										goto IL_011a;
									case 15:
										num2 = (_003C_003E1__state = 5);
										num4 = 47;
										continue;
									case 16:
										return;
									case 32:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 16;
										if (GbqoLRKYx6BSP0wDC28l())
										{
										}
										continue;
									case 60:
										if (!awaiter.IsCompleted)
										{
											num4 = 61;
											continue;
										}
										goto case 13;
									case 54:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										num4 = 12;
										continue;
									case 47:
										_003C_003Eu__5 = awaiter2;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										num4 = 10;
										continue;
									case 27:
										num2 = (_003C_003E1__state = -1);
										num4 = 42;
										if (!GbqoLRKYx6BSP0wDC28l())
										{
											continue;
										}
										goto end_IL_007f;
									case 63:
										goto end_IL_007f;
										IL_0853:
										awaiter5.GetResult();
										expression = findEdgeToolType.FindInputFixtureCell(findEdgeToolType._pasteObject).Expression;
										num4 = 40;
										continue;
										IL_068e:
										awaiter.GetResult();
										awaiter3 = _003Csheet_003E5__2.RunAsync(fireSheetUpdated: false).GetAwaiter();
										num4 = 26;
										continue;
									}
									break;
									IL_011a:
									result2 = awaiter4.GetResult();
									_ = 1;
									if (!GbqoLRKYx6BSP0wDC28l())
									{
										num4 = 55;
										if (1 == 0)
										{
											return;
										}
									}
									else
									{
										num4 = 51;
									}
								}
								goto IL_00ce;
								IL_02bb:
								num2 = (_003C_003E1__state = -1);
								num4 = 34;
								goto IL_03ac;
								IL_04f7:
								awaiter3.GetResult();
								awaiter = WkVW6gKYu4t3vgSNXdrV(EditableGraphicHelper.SendGraphicAsync((CvsInSight)VMsgKDKYQN39yYfGjuOd(findEdgeToolType.Inspect), findEdgeToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, findEdgeToolType.RrQ4LXOQdq), editableRegion));
								num4 = 9;
								if (KcSWq2KYHQZn3krRgyLg())
								{
									goto IL_03ac;
								}
								goto IL_0543;
								IL_0543:
								awaiter2 = _003Csheet_003E5__2.RunAndGetCellResults().GetAwaiter();
								if (awaiter2.IsCompleted)
								{
									goto IL_01c6;
								}
								num2 = (_003C_003E1__state = 8);
								num4 = 25;
								if (true)
								{
									goto IL_03ac;
								}
								goto IL_0577;
								IL_00fa:
								_003C_003Eu__2 = awaiter5;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
								num4 = 18;
								goto IL_03ac;
								IL_0577:
								num2 = (_003C_003E1__state = 2);
								num4 = 31;
								if (!GbqoLRKYx6BSP0wDC28l())
								{
									goto IL_03ac;
								}
								goto IL_0590;
								IL_0590:
								_003C_003Eu__5 = default;
								num4 = 20;
								goto IL_03ac;
								IL_0264:
								_003C_003Eu__4 = default;
								num4 = 62;
								goto IL_03ac;
								IL_01bd:
								num2 = (_003C_003E1__state = -1);
								goto IL_01c6;
								IL_01c6:
								result3 = awaiter2.GetResult();
								if (!zB9a5eKYzPVTeJV7nEsZ(result3[findEdgeToolType.GetCellLocation(_003CpasteRange_003E5__3.Location, findEdgeToolType.YS4495gJ1M)]).Equals(1.0))
								{
									break;
								}
								C9faOFKULDrtMQxNAUpx(_003CnewTool_003E5__6, result3);
								num4 = 63;
								if (GbqoLRKYx6BSP0wDC28l())
								{
								}
								goto IL_03ac;
								IL_00ce:
								num2 = (_003C_003E1__state = -1);
								num4 = 14;
								goto IL_03ac;
								end_IL_007f:
								break;
							}
							result = _003CnewTool_003E5__6;
						}
						catch (object obj)
						{
							_003C_003E7__wrap3 = obj;
							num3 = 1;
							goto IL_09cd;
						}
						goto end_IL_0046;
						IL_09cd:
						if (num3 == 1)
						{
							awaiter = WkVW6gKYu4t3vgSNXdrV(findEdgeToolType.CleanUpPastedToolOnFailedAdd(_003CpasteRange_003E5__3));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 9);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0a35;
						}
						goto IL_0a5e;
						IL_0a35:
						awaiter.GetResult();
						uhPr32KUKUal2ATxrh8C(ExceptionDispatchInfo.Capture((_003C_003E7__wrap3 as Exception) ?? throw _003C_003E7__wrap3));
						goto IL_0a5e;
						IL_0a5e:
						_003C_003E7__wrap3 = null;
						_003Csheet_003E5__2 = null;
						_003CpasteRange_003E5__3 = default;
						end_IL_0046:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Csheet_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 1:
				case 2:
					findEdgeToolType = _003C_003E4__this;
					num = 5;
					break;
				case 0:
					_003C_003Et__builder.SetResult(result);
					num = 7;
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
		internal static object jHFrufKYmdv1psVNmArS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).Inspect;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VMsgKDKYQN39yYfGjuOd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((AppStepViewModel)P_0).InSight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XLTgHVKYNGnAdub0ZHsh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SBgRq5KY22IJIs1KxD50(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).Sheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int xpmF3HKYcS3BI67O6sH1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((EzToolType)P_0).InputImageIndex;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GvSAurKY10Y1QqW6crJg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((SourceLink)P_0).Expression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter WkVW6gKYu4t3vgSNXdrV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object a45oxIKYhnJoEuwTgNuX(object P_0, CvsCellLocation P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[P_1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wQ9yiAKYtXm7uAkdw2mF(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((FindEdgeTool)P_0).AcceptThreshold;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zB9a5eKYzPVTeJV7nEsZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).CellValue;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void C9faOFKULDrtMQxNAUpx(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((EzTool)P_0).OnResultsChangedTool((CvsCellCollection)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void uhPr32KUKUal2ATxrh8C(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ExceptionDispatchInfo)P_0).Throw();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KcSWq2KYHQZn3krRgyLg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GbqoLRKYx6BSP0wDC28l()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private static readonly Guid[] dEn40V09NP;

	private readonly CvsCellLocation Y8M4V5sdA7;

	private readonly CvsCellLocation RrQ4LXOQdq;

	private readonly CvsCellLocation sam4JSvnE7;

	private readonly CvsCellLocation YS4495gJ1M;

	private CvsDisplayableRegion z2F4rG2Twc;

	private CvsDisplayableLine RnI4hXWjht;

	private int Ju248F01v2;

	private CvsEditableDisplayGraphic[] IZJ4m5wlfO;

	private bool ruX41Qdr5n;

	[CompilerGenerated]
	private EventHandler wJo4zTT9VR;

	public override Guid[] Guids
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return dEn40V09NP;
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
			return (string)yFskfnjDXrTrls9EWep();
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
			return Resources.S7ktuqxENC();
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
			return XAMLGraphicKeys.Tools_EdgeIcon;
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
			return XAMLGraphicKeys.Tools_EdgeIcon;
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
			return new string[2]
			{
				Resources.Inspect,
				(string)FuLNgQji5lrh2qkAEZE()
			};
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
			return Ju248F01v2;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref Ju248F01v2, value, (string)T7L7NkjIuMeNUpUii29(3256));
		}
	}

	public bool ShowLine
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ruX41Qdr5n;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0058;
			IL_001a:
			if (SetField(ref ruX41Qdr5n, value, CdQUGaROfy7He9T0foW.KbIzwHEDLa(25686)))
			{
				num = 8;
				goto IL_0058;
			}
			return;
			IL_0058:
			CvsDisplayableLine cvsDisplayableLine = default;
			CvsEditableDisplayGraphic[] iZJ4m5wlfO = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 0:
					if (cvsDisplayableLine != null)
					{
						goto case 4;
					}
					goto IL_0140;
				default:
					num = 4;
					continue;
				case 10:
				{
					EventHandler eventHandler = wJo4zTT9VR;
					if (eventHandler == null)
					{
						num = 1;
						continue;
					}
					cAucnujdluLSa3aDfrH(eventHandler, this, EventArgs.Empty);
					num = 11;
					continue;
				}
				case 1:
					return;
				case 8:
					iZJ4m5wlfO = IZJ4m5wlfO;
					num = 7;
					if (0 == 0)
					{
						continue;
					}
					goto case 7;
				case 7:
					num2 = 0;
					_ = 0;
					num = ((!UkcaStjwou2M55odRjN()) ? 5 : 9);
					continue;
				case 3:
				case 5:
				case 6:
				case 9:
					if (num2 < iZJ4m5wlfO.Length)
					{
						cvsDisplayableLine = iZJ4m5wlfO[num2] as CvsDisplayableLine;
						num = 0;
					}
					else
					{
						num = 10;
					}
					continue;
				case 4:
					AyI53JjfQ7jCoON5uQY(cvsDisplayableLine, (cvsDisplayableLine == RnI4hXWjht) ? ruX41Qdr5n : (!ruX41Qdr5n));
					goto IL_0140;
				case 11:
					return;
					IL_0140:
					num2++;
					goto case 3;
				}
				break;
			}
			goto IL_001a;
		}
	}

	public event EventHandler Invalidate
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
			if (false)
			{
				goto IL_001a;
			}
			goto IL_0056;
			IL_001a:
			EventHandler eventHandler = wJo4zTT9VR;
			num = 5;
			goto IL_0056;
			IL_0056:
			EventHandler eventHandler2 = default;
			EventHandler value2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 5:
					eventHandler2 = eventHandler;
					num = 2;
					continue;
				case 2:
					value2 = (EventHandler)djGcbBjldpRtQvRLHHi(eventHandler2, value);
					goto default;
				default:
					_ = 0;
					num = (UkcaStjwou2M55odRjN() ? 1 : 6);
					continue;
				case 1:
				case 3:
					eventHandler = Interlocked.CompareExchange(ref wJo4zTT9VR, value2, eventHandler2);
					goto case 4;
				case 4:
				case 6:
					if ((object)eventHandler == eventHandler2)
					{
						num = 7;
						continue;
					}
					goto case 5;
				case 7:
					return;
				}
				break;
			}
			goto IL_001a;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			EventHandler value2 = default;
			EventHandler eventHandler = default;
			EventHandler eventHandler2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					value2 = (EventHandler)YcxCRZjgyCQ8hUpJXKK(eventHandler, value);
					goto case 3;
				default:
					num = 3;
					continue;
				case 1:
				case 4:
					if ((object)eventHandler2 == eventHandler)
					{
						num = 7;
						if (UkcaStjwou2M55odRjN())
						{
							continue;
						}
					}
					goto case 0;
				case 0:
					eventHandler = eventHandler2;
					_ = 1;
					if (!oexbMejJqQ6UpOPUeN5())
					{
						num = 5;
						continue;
					}
					num = 1;
					if (true)
					{
						continue;
					}
					break;
				case 3:
					eventHandler2 = Interlocked.CompareExchange(ref wJo4zTT9VR, value2, eventHandler);
					goto case 1;
				case 6:
					break;
				case 7:
					return;
				}
				eventHandler2 = wJo4zTT9VR;
				num = 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FindEdgeToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 2:
				Ju248F01v2 = 200;
				num = 0;
				break;
			case 6:
			case 7:
				sam4JSvnE7 = _pasteObject.GetCellOffset((string)T7L7NkjIuMeNUpUii29(6522));
				num = 9;
				break;
			case 1:
				Y8M4V5sdA7 = _pasteObject.GetCellOffset((string)T7L7NkjIuMeNUpUii29(4928));
				goto case 4;
			default:
				num = 4;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 5:
				_pasteObject = (PasteBuffer)tkNjJ4jOkTSk4nwsvyl(s4hU0JjeYNonkao6ADp());
				num = 1;
				break;
			case 8:
			case 10:
				AddSnippet(_pasteObject);
				num = 11;
				break;
			case 3:
				kDJyIkjajYvQO0qhIGr();
				num = 2;
				break;
			case 4:
				RrQ4LXOQdq = _pasteObject.GetCellOffset((string)T7L7NkjIuMeNUpUii29(5684));
				_ = 0;
				num = ((!UkcaStjwou2M55odRjN()) ? 10 : 7);
				break;
			case 9:
				YS4495gJ1M = _pasteObject.GetCellOffset((string)T7L7NkjIuMeNUpUii29(24546));
				goto case 8;
			case 0:
				base._002Ector();
				num = 5;
				break;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCreateTool_003Ed__26))]
	public override Task<EzTool> CreateTool(Guid guid, CvsCellCollection cells, CvsCellRange cellRange)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CCreateTool_003Ed__26 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.cells = cells;
		stateMachine.cellRange = cellRange;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnBeginAddInternal_003Ed__27))]
	protected override Task OnBeginAddInternal()
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
		goto IL_0086;
		IL_001a:
		_003COnBeginAddInternal_003Ed__27 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0086;
		IL_0086:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
				stateMachine._003C_003Et__builder = G0k2IMjn4gqidHRbN0M();
				_ = 1;
				num = ((!oexbMejJqQ6UpOPUeN5()) ? 5 : 3);
				continue;
			case 2:
			case 3:
				stateMachine._003C_003E1__state = -1;
				break;
			default:
				num = 4;
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void UpdateFeatureGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (oexbMejJqQ6UpOPUeN5() ? 1 : 2);
		List<CvsEditableDisplayGraphic> list = default;
		CvsEditableDisplayGraphic[] source = default;
		while (true)
		{
			CvsEditableDisplayGraphic[] array;
			switch (num)
			{
			case 0:
			case 2:
				array = IZJ4m5wlfO;
				if (array != null)
				{
					break;
				}
				num = 4;
				if (!oexbMejJqQ6UpOPUeN5())
				{
					continue;
				}
				goto default;
			default:
				IZJ4m5wlfO = (CvsEditableDisplayGraphic[])YhOojUjVB53RXxQOdPE(list);
				num = 6;
				continue;
			case 5:
				FireAddGraphicsChanged(source.ToList(), list);
				goto default;
			case 4:
				array = Array.Empty<CvsEditableDisplayGraphic>();
				break;
			case 6:
				return;
			}
			source = array;
			list = Wp44nN5IP4();
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<CvsEditableDisplayGraphic> Wp44nN5IP4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		List<CvsEditableDisplayGraphic> list = new List<CvsEditableDisplayGraphic>();
		list.Add(z2F4rG2Twc);
		list.Add(RnI4hXWjht);
		if (Inspect.InSight.Results.Cells[CvsCellLocation.Parse(InputImageLinks[InputImageIndex].Expression)]?.CellResult.Value is CvsCogImage { Width: var width, Height: var height } cvsCogImage)
		{
			ICvsImageBuffer imageBuffer = CvsImageBufferFactory.FromBitmap(Inspect.InSight.CogSocket.GetImageByHttp(cvsCogImage.Url, new Size(width, height), new Rectangle(0, 0, width, height)), CnxPixelFormat.Format8bppGrayscale);
			RectangleF rectangleF = new RectangleF(cvsCogImage.OffsetX, cvsCogImage.OffsetY, width, height);
			CvsImage image = new CvsImage(imageBuffer, rectangleF, rectangleF);
			List<CvsEditableDisplayGraphic> list2 = new FeatureExtractor().FindLines(image);
			list.AddRange(list2.ToArray());
		}
		return list;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CvsEditableDisplayGraphic[] GetEditableGraphics()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return IZJ4m5wlfO;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddTool_003Ed__39))]
	public override Task<EzTool> AddTool()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddTool_003Ed__39 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CGetUpdates_003Ed__40))]
	public override IEnumerable<ISnippetUpdate> GetUpdates(CvsCellCollection cells, CvsCellRange range)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return new _003CGetUpdates_003Ed__40(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__cells = cells,
			_003C_003E3__range = range
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddTool_003Ed__41))]
	internal Task<EzTool> YBE4tPvMRf(CvsDisplayableLine P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddTool_003Ed__41 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.editableLine = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddTool_003Ed__42))]
	internal virtual Task<EzTool> AddTool(CvsDisplayableRegion editableRegion, CvsCellCollection cells = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddTool_003Ed__42 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EzTool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.editableRegion = editableRegion;
		stateMachine.cells = cells;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double PointToPointAngle(PointF p0, PointF p1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return hTkKhTjsOHdR5dDn6UT(p1.Y - p0.Y, p1.X - p0.X) * 180.0 / Math.PI;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float PointToPointDist(PointF p0, PointF p1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		double num = p1.X - p0.X;
		double num2 = p1.Y - p0.Y;
		return (float)Q7R4nKjvndE3YD1517O(num * num + num2 * num2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static FindEdgeToolType()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		kDJyIkjajYvQO0qhIGr();
		dEn40V09NP = new Guid[1]
		{
			new Guid((string)T7L7NkjIuMeNUpUii29(25706))
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task HKD4Y6dblu()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return base.OnBeginAddInternal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kDJyIkjajYvQO0qhIGr()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		QMg9JmRWqlBkDmqLeuW.VTVhNFazaHesk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object s4hU0JjeYNonkao6ADp()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Snippets.FindEdge;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tkNjJ4jOkTSk4nwsvyl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return PasteBuffer.FromBytes((byte[])P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object T7L7NkjIuMeNUpUii29(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CdQUGaROfy7He9T0foW.KbIzwHEDLa(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool UkcaStjwou2M55odRjN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool oexbMejJqQ6UpOPUeN5()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yFskfnjDXrTrls9EWep()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.Kb8tdpAgrR();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FuLNgQji5lrh2qkAEZE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Resources.A6xJ0EZQJY();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder G0k2IMjn4gqidHRbN0M()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YhOojUjVB53RXxQOdPE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<CvsEditableDisplayGraphic>)P_0).ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AyI53JjfQ7jCoON5uQY(object P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsDisplayableGraphic)P_0).Visible = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cAucnujdluLSa3aDfrH(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (EventArgs)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object djGcbBjldpRtQvRLHHi(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YcxCRZjgyCQ8hUpJXKK(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double hTkKhTjsOHdR5dDn6UT(double P_0, double P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Atan2(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double Q7R4nKjvndE3YD1517O(double P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Math.Sqrt(P_0);
	}
}
