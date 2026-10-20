using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Cell;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Undo;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight.Services;

public class PropertySheetService : IPropertySheetService, ISensorConnectionStatusService, IViDiFixtureService
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCommitAsync_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PropertySheetService _003C_003E4__this;

		public CvsCellLocation location;

		public string expression;

		public string text;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
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
			goto IL_01c1;
			IL_001a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01c1;
			IL_01c1:
			int num2 = default;
			PropertySheetService propertySheetService = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
					continue;
				case 1:
					propertySheetService = _003C_003E4__this;
					uPPel0sYfuh8ArbAtLjG();
					if (x6MMHTsYkgXjTS0cwSvH())
					{
						num = 0;
						if (0 == 0)
						{
							continue;
						}
						goto case 0;
					}
					num = 4;
					continue;
				case 0:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((UndoHandler)FFnFw8sYF7LwaV2ivqoU(propertySheetService.yN2TbK5ESU())).DoPropertySheetChange(location, expression, text).GetAwaiter();
							num3 = 3;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 8;
							if (1 == 0)
							{
								goto IL_010a;
							}
						}
						goto IL_00bb;
						IL_010a:
						_003C_003Eu__1 = awaiter;
						num3 = 5;
						goto IL_00bb;
						IL_00bb:
						while (true)
						{
							switch (num3)
							{
							case 5:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 7;
								continue;
							case 7:
								return;
							case 0:
							case 2:
								break;
							case 1:
							case 6:
								num2 = (_003C_003E1__state = 0);
								break;
							case 8:
								_003C_003Eu__1 = default;
								num3 = 4;
								continue;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 3:
								if (!awaiter.IsCompleted)
								{
									_ = 1;
									if (uPPel0sYfuh8ArbAtLjG())
									{
										num3 = 0;
										if (0 == 0)
										{
											continue;
										}
										goto case 8;
									}
									num3 = 6;
									continue;
								}
								goto case 9;
							case 9:
								awaiter.GetResult();
								goto end_IL_00bb;
							}
							goto IL_010a;
							continue;
							end_IL_00bb:
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
				case 6:
					return;
				}
				break;
			}
			goto IL_001a;
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
		internal static object FFnFw8sYF7LwaV2ivqoU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool x6MMHTsYkgXjTS0cwSvH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uPPel0sYfuh8ArbAtLjG()
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
	private struct _003CRollbackAsync_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PropertySheetService _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (laHrCUsYyBZKFcQt6JVq() ? 4 : 3);
			int num2 = default;
			PropertySheetService propertySheetService = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 4:
					propertySheetService = _003C_003E4__this;
					num = 5;
					if (AZKItCsYmYIdQAhTqd8a())
					{
						break;
					}
					goto case 2;
				case 2:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							propertySheetService.ndRTFLuAQN();
							num3 = 2;
							if (!AZKItCsYmYIdQAhTqd8a())
							{
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_ = 1;
							num3 = (laHrCUsYyBZKFcQt6JVq() ? 5 : 4);
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
								return;
							case 4:
							case 6:
								_003C_003Eu__1 = default;
								goto case 5;
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 0;
								continue;
							case 2:
								awaiter = JjeXIHsYZSwXBQ2RPVdo(cOrKuRsYgwQZUhEkDTRR(propertySheetService.yN2TbK5ESU().PropSheet));
								num3 = 8;
								continue;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								continue;
							case 0:
								_003C_003Eu__1 = awaiter;
								goto case 9;
							default:
								num3 = 9;
								continue;
							case 8:
								if (awaiter.IsCompleted)
								{
									break;
								}
								num3 = 1;
								if (0 == 0)
								{
									continue;
								}
								goto case 5;
							case 5:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								if (0 == 0)
								{
									continue;
								}
								break;
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
					goto case 2;
				default:
					num = 2;
					if (1 == 0)
					{
						return;
					}
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
		internal static object cOrKuRsYgwQZUhEkDTRR(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsPropSheet)P_0).CancelAsync();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter JjeXIHsYZSwXBQ2RPVdo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AZKItCsYmYIdQAhTqd8a()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool laHrCUsYyBZKFcQt6JVq()
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
	private struct _003CFixture_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public PropertySheetService _003C_003E4__this;

		public CvsCellLocation loc;

		public string filter;

		private TaskAwaiter<bool> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			bool result = default;
			PropertySheetService propertySheetService = default;
			int num2 = default;
			CvsCell cvsCell = default;
			TaskAwaiter<bool> awaiter = default;
			IExternalCellDataHandler externalCellDataHandler = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 1:
				case 5:
					propertySheetService = _003C_003E4__this;
					num = 2;
					break;
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							cvsCell = (CvsCell)haAuqdsNsBj9UvUXfNOf(GU7PgisNwMu8OHe5deFZ(qbKCHSsYzMYvbXBlahqL(propertySheetService.yN2TbK5ESU())), loc);
							num3 = 1;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 3;
						}
						while (true)
						{
							switch (num3)
							{
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 9;
								continue;
							case 2:
								if (externalCellDataHandler != null)
								{
									num3 = 7;
									continue;
								}
								break;
							case 0:
								result = awaiter.GetResult();
								num3 = 12;
								continue;
							default:
								_003C_003Eu__1 = awaiter;
								num3 = 10;
								continue;
							case 1:
								if (!Xxc90asNh6tLjNY2wAkL(cvsCell))
								{
									externalCellDataHandler = (IExternalCellDataHandler)IGOeK2sNL4OTi0CZ29Hp(cvsCell);
									num3 = 2;
									continue;
								}
								break;
							case 4:
							case 6:
								num2 = (_003C_003E1__state = 0);
								goto default;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 0;
								continue;
							case 8:
								if (awaiter.IsCompleted)
								{
									goto case 0;
								}
								ty2CHssY8siuF8a4R8yu();
								if (!Yu5Pw3sYJSBWwQOtpc4e())
								{
									num3 = 11;
									if (true)
									{
										continue;
									}
									goto case 9;
								}
								num3 = 6;
								if (!ty2CHssY8siuF8a4R8yu())
								{
									continue;
								}
								goto case 7;
							case 7:
								awaiter = externalCellDataHandler.Fixture(propertySheetService.yN2TbK5ESU(), l43dKEsN9KxKTKIjUb5K(cvsCell), filter).GetAwaiter();
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto end_IL_0113;
							case 12:
								goto end_IL_0113;
							}
							result = false;
							break;
							continue;
							end_IL_0113:
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
					goto default;
				case 0:
					num2 = _003C_003E1__state;
					Yu5Pw3sYJSBWwQOtpc4e();
					num = ((!ty2CHssY8siuF8a4R8yu()) ? 5 : 4);
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
		internal static object qbKCHSsYzMYvbXBlahqL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).Results;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GU7PgisNwMu8OHe5deFZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsResultSet)P_0).Cells;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object haAuqdsNsBj9UvUXfNOf(object P_0, CvsCellLocation cell)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCellCollection)P_0)[cell];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Xxc90asNh6tLjNY2wAkL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CvsCell.IsNullOrEmpty((CvsCell)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IGOeK2sNL4OTi0CZ29Hp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return UndoHandler.GetExternalCellDataHandler((CvsCell)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellLocation l43dKEsN9KxKTKIjUb5K(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCell)P_0).Location;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Yu5Pw3sYJSBWwQOtpc4e()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ty2CHssY8siuF8a4R8yu()
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
	private struct _003CSetBoundArgsAsync_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PropertySheetService _003C_003E4__this;

		public string[] argNames;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
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
			goto IL_01a5;
			IL_001a:
			int num2 = _003C_003E1__state;
			S3OxPgsNSy9ixInRA2g3();
			num = (cSfk0GsNEOOu5k3Ors2s() ? 5 : 4);
			goto IL_01a5;
			IL_01a5:
			PropertySheetService propertySheetService = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 0:
					try
					{
						int num3;
						if (num2 != 0)
						{
							propertySheetService.ndRTFLuAQN();
							num3 = 0;
							if (false)
							{
								goto IL_0053;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 9;
						}
						goto IL_00f5;
						IL_00f5:
						while (true)
						{
							switch (num3)
							{
							case 9:
								_003C_003Eu__1 = default;
								num3 = 1;
								continue;
							case 3:
								if (!awaiter.IsCompleted)
								{
									_ = 0;
									if (S3OxPgsNSy9ixInRA2g3())
									{
										num3 = 5;
										continue;
									}
									num3 = 8;
									if (S3OxPgsNSy9ixInRA2g3())
									{
										continue;
									}
									goto case 1;
								}
								goto case 10;
							case 0:
								awaiter = pWJouksNHxSjmXp9rcBh(((CvsPropSheet)yqc1MTsNvbQ2lvcCdM6O(propertySheetService.yN2TbK5ESU())).SetBoundArgs(argNames));
								num3 = 3;
								continue;
							case 2:
							case 5:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								continue;
							case 6:
								_003C_003Eu__1 = awaiter;
								break;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 7:
								return;
							case 10:
								awaiter.GetResult();
								goto end_IL_00f5;
							}
							goto IL_0053;
							continue;
							end_IL_00f5:
							break;
						}
						goto end_IL_003b;
						IL_0053:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 7;
						goto IL_00f5;
						end_IL_003b:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 1:
				case 4:
					propertySheetService = _003C_003E4__this;
					num = 0;
					continue;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_001a;
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
		internal static object yqc1MTsNvbQ2lvcCdM6O(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).PropSheet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter pWJouksNHxSjmXp9rcBh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool S3OxPgsNSy9ixInRA2g3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cSfk0GsNEOOu5k3Ors2s()
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
	private struct _003CEmbedArgumentAsync_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CvsCellRange> _003C_003Et__builder;

		public IUndoPropertyAction embedAction;

		public PropertySheetService _003C_003E4__this;

		public CvsCellLocation location;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			int num2 = default;
			PropertySheetService propertySheetService = default;
			TaskAwaiter awaiter = default;
			CvsCellRange result = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					num2 = _003C_003E1__state;
					u67YDOsNARwWQ77FdUmp();
					num = (DguqRGsNVk9VwrBAwHr8() ? 5 : 0);
					break;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							d2P6SNsNDw0my5UtVMe5(embedAction, propertySheetService.yN2TbK5ESU());
							DguqRGsNVk9VwrBAwHr8();
							if (!u67YDOsNARwWQ77FdUmp())
							{
								num3 = 9;
								if (false)
								{
									return;
								}
							}
							else
							{
								num3 = 7;
								if (u67YDOsNARwWQ77FdUmp())
								{
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 10;
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
								return;
							case 10:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 5:
								awaiter.GetResult();
								num3 = 11;
								continue;
							case 8:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 3;
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 5;
								continue;
							case 4:
								awaiter = ((Task)tSINo6sNUwJ7SLKXC3po(propertySheetService.yN2TbK5ESU().UndoHandler, embedAction)).GetAwaiter();
								goto case 2;
							case 2:
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								goto case 5;
							case 0:
							case 9:
								embedAction.DropLocation = location;
								num3 = 4;
								continue;
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 8;
								continue;
							case 11:
								result = dY9JbJsNTuoafNBh669E(embedAction);
								break;
							}
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
					goto default;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 1:
				case 5:
					propertySheetService = _003C_003E4__this;
					num = 4;
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
		internal static void d2P6SNsNDw0my5UtVMe5(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IUndoPropertyAction)P_0).InSight = (CvsInSight)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tSINo6sNUwJ7SLKXC3po(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CvsCellRange dY9JbJsNTuoafNBh669E(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IUndoPropertyAction)P_0).ValuesRange;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DguqRGsNVk9VwrBAwHr8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool u67YDOsNARwWQ77FdUmp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly CvsInSight BSmTlEAqcN;

	[CompilerGenerated]
	private SensorConfiguration YtTTgRHRdf;

	[CompilerGenerated]
	private CvsFunction A5sTqnii4N;

	public bool IsConnected
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GhYcwG58E0STdW1jjv6(yN2TbK5ESU()) == CvsInSightState.Connected;
		}
	}

	protected CvsFunctionTable FunctionTable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (CvsFunctionTable)s9f7lK5zGlVwgV2sPjR(Configuration);
		}
	}

	public SensorConfiguration Configuration
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return YtTTgRHRdf;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			YtTTgRHRdf = value;
		}
	}

	public CvsFunction Function
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return A5sTqnii4N;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			A5sTqnii4N = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PropertySheetService(string expression, CvsInSight inSight)
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
			case 2:
				QhNBPB5mxNSHcn9p8fi(this);
				num = 4;
				break;
			case 4:
				BSmTlEAqcN = inSight;
				goto case 3;
			case 0:
				XaTsss5FGdPloa4DbD8();
				A1wYSl5kdfZvsqWlgcv();
				num = ((!fO3s8F5fYSMVJ8t6rb3()) ? 2 : 5);
				break;
			case 3:
			case 5:
				Configuration = InSightServiceHelpers.CreateSensorConfiguration(yN2TbK5ESU());
				goto case 6;
			default:
				num = 6;
				break;
			case 6:
				if (Configuration != null)
				{
					num = 7;
					break;
				}
				return;
			case 7:
				Function = (CvsFunction)hwa6Qs5yViaLksQBlOo(FunctionTable, expression);
				num = 8;
				if (!A1wYSl5kdfZvsqWlgcv())
				{
					return;
				}
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ResourceNode GetSpreadsheetResourceNode(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (ResourceNode)XgDui35J914RlVEYTlK(zP047L5Z16LL31jWxj3(gcicK55gSRtqOrkTMGv(yN2TbK5ESU())), location);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private CvsInSight yN2TbK5ESU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return BSmTlEAqcN;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private CvsCogSocket in8TOuCNyF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (CvsCogSocket)gcicK55gSRtqOrkTMGv(yN2TbK5ESU());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CCommitAsync_003Ed__19))]
	public Task CommitAsync(CvsCellLocation location, string expression, string text = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 2;
		_003CCommitAsync_003Ed__19 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 8:
				stateMachine.expression = expression;
				goto case 0;
			default:
				num = 0;
				break;
			case 5:
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 9;
				break;
			case 3:
				stateMachine.location = location;
				num = 8;
				if (A1wYSl5kdfZvsqWlgcv())
				{
					break;
				}
				goto case 7;
			case 7:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			case 2:
				stateMachine._003C_003Et__builder = xnr9BTowrvgoJK8TlJx();
				_ = 1;
				num = ((!fO3s8F5fYSMVJ8t6rb3()) ? 4 : 5);
				break;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 3;
				break;
			case 0:
				stateMachine.text = text;
				num = 7;
				break;
			case 9:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRollbackAsync_003Ed__20))]
	public Task RollbackAsync()
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
		goto IL_004c;
		IL_001a:
		_003CRollbackAsync_003Ed__20 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_004c;
		IL_004c:
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E1__state = -1;
				break;
			case 2:
				stateMachine._003C_003Et__builder = xnr9BTowrvgoJK8TlJx();
				A1wYSl5kdfZvsqWlgcv();
				num = (fO3s8F5fYSMVJ8t6rb3() ? 4 : 0);
				continue;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (fO3s8F5fYSMVJ8t6rb3())
				{
				}
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void NotifyEndEdit()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (ugT6kGohmrF9PBnWuUm(KOb1PWosW5NG86BY8X3(yN2TbK5ESU())))
		{
			gwv7V4oL5HkbOMucXfP(KOb1PWosW5NG86BY8X3(yN2TbK5ESU()));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsPropertySheetResult> SetExpressionAsync(string expression)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ndRTFLuAQN();
		return yN2TbK5ESU().PropSheet.RunAsync(expression);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsPropertySheetResult> ChangeValueAsync(string expression, int argIndex, string argValue)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ChangeValuesAsync(expression, argIndex, new string[1] { argValue });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsPropertySheetResult> ChangeValuesAsync(string expression, int argIndex, string[] argValues)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ndRTFLuAQN();
		return yN2TbK5ESU().PropSheet.ChangeAsync(expression, argIndex, argValues);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsPropertySheetResult> ChangeGraphicValueAsync(string expression, int argIndex, string argValue)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ChangeGraphicValuesAsync(expression, argIndex, new string[1] { argValue });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsPropertySheetResult> ChangeGraphicValuesAsync(string expression, int argIndex, string[] argValues)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ndRTFLuAQN();
		return yN2TbK5ESU().PropSheet.ChangeGraphicAsync(expression, argIndex, argValues);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsPropertySheetResult> InitializeAsync(CvsCellLocation location, string expression)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ndRTFLuAQN();
		return yN2TbK5ESU().PropSheet.InitAsync(location, expression);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsPropertySheetResult> GetResultsAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ndRTFLuAQN();
		return yN2TbK5ESU().PropSheet.GetResultAsync();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task AddGettersOnOk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ndRTFLuAQN();
		return (Task)C3xwrbo9JaSb4nYN50x(KOb1PWosW5NG86BY8X3(yN2TbK5ESU()));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsCogEditInfo> GetEditableInfoAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ndRTFLuAQN();
		return yN2TbK5ESU().CogSocket.Sheet.PropSheetGetEditableInfoAsync();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<CvsCogExpressionGraphic> GetEditingEnabledAsync(CvsCogEditInfo editInfo)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ndRTFLuAQN();
		return yN2TbK5ESU().CogSocket.Sheet.GetExpressionGraphic(editInfo);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MakeNewResult()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		yN2TbK5ESU().MakeNewResult(updateExposedResults: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CFixture_003Ed__33))]
	public Task<bool> Fixture(CvsCellLocation loc, string filter)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CFixture_003Ed__33 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.loc = loc;
		stateMachine.filter = filter;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FixtureSingle(CvsCellLocation loc, string name, Bitmap bmp)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		fO3s8F5fYSMVJ8t6rb3();
		int num = ((!A1wYSl5kdfZvsqWlgcv()) ? 2 : 6);
		IExternalCellDataHandler externalCellDataHandler = default;
		CvsCell cvsCell = default;
		while (true)
		{
			switch (num)
			{
			default:
				if (externalCellDataHandler != null)
				{
					num = 1;
					break;
				}
				return;
			case 4:
				if (!fUtcVHoHSben9nj4Y2Z(cvsCell))
				{
					num = 5;
					break;
				}
				return;
			case 1:
				lpSkfboASjryPeL2qQd(externalCellDataHandler, yN2TbK5ESU(), cvsCell.Location, name, bmp);
				num = 7;
				if (0 == 0)
				{
					break;
				}
				goto case 5;
			case 5:
				externalCellDataHandler = (IExternalCellDataHandler)sJVB91oVgjEIe2TABTT(cvsCell);
				goto default;
			case 0:
			case 6:
				cvsCell = (CvsCell)a8jtGZovsDWo7OQ1ds5(euPuikoEB7RKFYORSTX(rU4eDpoSbsmuopvh02e(yN2TbK5ESU())), loc);
				num = 4;
				break;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessSingle(CvsCellLocation loc, string name)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		if (!fO3s8F5fYSMVJ8t6rb3())
		{
		}
		IExternalCellDataHandler externalCellDataHandler = default;
		CvsCell cvsCell = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				wmfERZoUxD2SZMLq869(externalCellDataHandler, yN2TbK5ESU(), nwsTB2oDN2iNIToIoU9(cvsCell), name);
				num = 7;
				break;
			default:
				if (externalCellDataHandler != null)
				{
					num = 0;
					break;
				}
				return;
			case 4:
				cvsCell = (CvsCell)a8jtGZovsDWo7OQ1ds5(((CvsResultSet)rU4eDpoSbsmuopvh02e(yN2TbK5ESU())).Cells, loc);
				num = 5;
				break;
			case 5:
				if (CvsCell.IsNullOrEmpty(cvsCell))
				{
					return;
				}
				A1wYSl5kdfZvsqWlgcv();
				if (!fO3s8F5fYSMVJ8t6rb3())
				{
					num = 6;
					break;
				}
				num = 1;
				if (fO3s8F5fYSMVJ8t6rb3())
				{
				}
				break;
			case 2:
			case 6:
				externalCellDataHandler = UndoHandler.GetExternalCellDataHandler(cvsCell);
				goto default;
			case 7:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetFixtureCellLocation(CvsCellLocation loc)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (!A1wYSl5kdfZvsqWlgcv())
		{
			goto IL_001e;
		}
		goto IL_0061;
		IL_00b5:
		object obj = ijbAFaodKcsUngdkc2s(ERnUa0oTSaOs6fGg8DI(KOb1PWosW5NG86BY8X3(yN2TbK5ESU())));
		goto IL_00d5;
		IL_00d5:
		string text = (string)obj;
		CvsFunctionArg cvsFunctionArg = ((CvsFunction)UFWLwQoqRrft9lDIsNg(yN2TbK5ESU().FunctionTable, text)).FindArgumentByName(kgbOBx7BanbFa22Hp9.ol99ukmDA(17824));
		num = 6;
		goto IL_0061;
		IL_0061:
		CvsCell cvsCell = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				break;
			case 2:
			case 4:
				goto IL_0044;
			case 5:
				cvsCell = (CvsCell)a8jtGZovsDWo7OQ1ds5(euPuikoEB7RKFYORSTX(yN2TbK5ESU().Results), loc);
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				goto IL_00b5;
			default:
				goto IL_00b5;
			case 6:
				return CvsParse.FindArg(text, PIfruloB0QXGVgI2BKT(cvsFunctionArg)).ToString();
			}
			break;
		}
		goto IL_001e;
		IL_001e:
		if (cvsCell != null)
		{
			_ = 0;
			if (A1wYSl5kdfZvsqWlgcv())
			{
				num = 4;
				if (fO3s8F5fYSMVJ8t6rb3())
				{
				}
			}
			else
			{
				num = 1;
			}
			goto IL_0061;
		}
		goto IL_00b5;
		IL_0044:
		if (cvsCell.IsEmpty())
		{
			goto IL_00b5;
		}
		obj = yWKYMkoiqGTi3jyqLMb(cvsCell);
		goto IL_00d5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ndRTFLuAQN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (GhYcwG58E0STdW1jjv6(yN2TbK5ESU()) == CvsInSightState.NotConnected || KOb1PWosW5NG86BY8X3(yN2TbK5ESU()) == null)
		{
			throw new CvsNotConnectedException();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<DynamicArgBinder> GetDynamicArgBinderAsync()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ndRTFLuAQN();
		return yN2TbK5ESU().PropSheet.GetDynamicArgBinder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CSetBoundArgsAsync_003Ed__39))]
	public Task SetBoundArgsAsync(string[] argNames)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CSetBoundArgsAsync_003Ed__39 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 0;
				if (0 == 0)
				{
					break;
				}
				goto case 3;
			case 3:
			case 6:
				stateMachine._003C_003E1__state = -1;
				goto case 2;
			case 2:
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (A1wYSl5kdfZvsqWlgcv())
				{
					break;
				}
				goto case 0;
			case 0:
				stateMachine.argNames = argNames;
				goto default;
			default:
				fO3s8F5fYSMVJ8t6rb3();
				num = (A1wYSl5kdfZvsqWlgcv() ? 6 : 2);
				break;
			case 5:
				stateMachine._003C_003Et__builder = xnr9BTowrvgoJK8TlJx();
				num = 1;
				if (fO3s8F5fYSMVJ8t6rb3())
				{
				}
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CvsCell GetCell(CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ndRTFLuAQN();
		return (CvsCell)a8jtGZovsDWo7OQ1ds5(euPuikoEB7RKFYORSTX(rU4eDpoSbsmuopvh02e(yN2TbK5ESU())), location);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CEmbedArgumentAsync_003Ed__41))]
	public Task<CvsCellRange> EmbedArgumentAsync(CvsCellLocation location, IUndoPropertyAction embedAction)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CEmbedArgumentAsync_003Ed__41 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CvsCellRange>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.location = location;
		stateMachine.embedAction = embedAction;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XaTsss5FGdPloa4DbD8()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QhNBPB5mxNSHcn9p8fi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object hwa6Qs5yViaLksQBlOo(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionTable)P_0).FindOverloadedFunction((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool A1wYSl5kdfZvsqWlgcv()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fO3s8F5fYSMVJ8t6rb3()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gcicK55gSRtqOrkTMGv(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).CogSocket;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zP047L5Z16LL31jWxj3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocket)P_0).Sheet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XgDui35J914RlVEYTlK(object P_0, CvsCellLocation location)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCogSocketSheet)P_0).GetCellToolResourceNode(location);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsInSightState GhYcwG58E0STdW1jjv6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).State;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object s9f7lK5zGlVwgV2sPjR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((SensorConfiguration)P_0).FunctionTable;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder xnr9BTowrvgoJK8TlJx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KOb1PWosW5NG86BY8X3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).PropSheet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ugT6kGohmrF9PBnWuUm(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsPropSheet)P_0).IsEditInProgress;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gwv7V4oL5HkbOMucXfP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((CvsPropSheet)P_0).EditComplete();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object C3xwrbo9JaSb4nYN50x(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsPropSheet)P_0).AddGettersOnOk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rU4eDpoSbsmuopvh02e(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).Results;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object euPuikoEB7RKFYORSTX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsResultSet)P_0).Cells;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object a8jtGZovsDWo7OQ1ds5(object P_0, CvsCellLocation cell)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCellCollection)P_0)[cell];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fUtcVHoHSben9nj4Y2Z(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return CvsCell.IsNullOrEmpty((CvsCell)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sJVB91oVgjEIe2TABTT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return UndoHandler.GetExternalCellDataHandler((CvsCell)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lpSkfboASjryPeL2qQd(object P_0, object P_1, CvsCellLocation cellLocation, object P_3, object P_4)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IExternalCellDataHandler)P_0).FixtureSingle((CvsInSight)P_1, cellLocation, (string)P_3, (Bitmap)P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation nwsTB2oDN2iNIToIoU9(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wmfERZoUxD2SZMLq869(object P_0, object P_1, CvsCellLocation cellLocation, object P_3)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IExternalCellDataHandler)P_0).ProcessSingle((CvsInSight)P_1, cellLocation, (string)P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ERnUa0oTSaOs6fGg8DI(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsPropSheet)P_0).LastPropertySheetResult;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ijbAFaodKcsUngdkc2s(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsPropertySheetResult)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object yWKYMkoiqGTi3jyqLMb(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Expression;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UFWLwQoqRrft9lDIsNg(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionTable)P_0).FindFunction((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int PIfruloB0QXGVgI2BKT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsFunctionArg)P_0).Index;
	}
}
