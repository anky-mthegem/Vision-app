using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Remoting.Serialization.Color;
using Cognex.InSight.Services;
using btFy13pd5uf4WC4h18;
using cJxwT5Abi5ieaPFhYb;

namespace Cognex.InSight;

internal class TrainMatchColorToolApi : ITrainMatchColorService
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetAllModels_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ColorMatchModel[]> _003C_003Et__builder;

		public TrainMatchColorToolApi _003C_003E4__this;

		private ColorMatchModel[] _003Cmodels_003E5__2;

		private ConfiguredTaskAwaitable<ColorMatchModel[]>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ColorMatchModel[] _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			int num2 = default;
			ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = default;
			ConfiguredTaskAwaitable<ColorMatchModel[]>.ConfiguredTaskAwaiter awaiter2 = default;
			ConfiguredTaskAwaitable configuredTaskAwaitable = default;
			TrainMatchColorToolApi trainMatchColorToolApi = default;
			ColorMatchModel colorMatchModel = default;
			ColorMatchModel[] result = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003Cmodels_003E5__2 = null;
					num = 4;
					break;
				case 0:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 15;
								if (!HTG1uFsVewdtkhk97iPY())
								{
									goto IL_0046;
								}
							}
							else
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num3 = 3;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 16;
						}
						goto IL_0068;
						IL_0046:
						configuredTaskAwaitable = eiSUO9sVRll2rgp2HYup(trainMatchColorToolApi.tHLOJbuL3q(colorMatchModel), false);
						goto IL_02c8;
						IL_02c8:
						awaiter = configuredTaskAwaitable.GetAwaiter();
						num3 = 1;
						goto IL_0068;
						IL_0068:
						while (true)
						{
							switch (num3)
							{
							case 12:
								break;
							default:
								num3 = 19;
								continue;
							case 11:
								_003C_003E7__wrap2 = null;
								num3 = 22;
								if (DucFySsVuC8dUp2X274B())
								{
								}
								continue;
							case 14:
							{
								ColorMatchModel[] result2 = awaiter2.GetResult();
								_003Cmodels_003E5__2 = result2;
								num3 = 7;
								continue;
							}
							case 5:
								return;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 21;
								continue;
							case 16:
								num2 = (_003C_003E1__state = -1);
								num3 = 14;
								continue;
							case 6:
								_003C_003E7__wrap3 = 0;
								num3 = 0;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter;
								num3 = 10;
								continue;
							case 13:
							case 17:
								_003C_003E7__wrap3++;
								goto case 0;
							case 0:
							case 9:
							case 18:
								if (_003C_003E7__wrap3 < _003C_003E7__wrap2.Length)
								{
									colorMatchModel = _003C_003E7__wrap2[_003C_003E7__wrap3];
									num3 = 12;
								}
								else
								{
									num3 = 11;
								}
								continue;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 4;
								continue;
							case 21:
								goto IL_01ed;
							case 20:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								num3 = 2;
								continue;
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								continue;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto IL_01ed;
							case 15:
								awaiter2 = trainMatchColorToolApi.by2OMu5cMQ.GetAsync<ColorMatchModel[]>((string)riPeu0sVIaG2blnNfQS1(52598)).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num3 = 20;
									continue;
								}
								goto case 14;
							case 4:
								return;
							case 7:
								_003C_003E7__wrap2 = _003Cmodels_003E5__2;
								num3 = 6;
								continue;
							case 19:
								goto IL_02c8;
							case 22:
								result = _003Cmodels_003E5__2;
								goto end_IL_0029;
							}
							break;
							IL_01ed:
							awaiter.GetResult();
							_ = 0;
							num3 = (HTG1uFsVewdtkhk97iPY() ? 13 : 9);
						}
						goto IL_0046;
						end_IL_0029:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cmodels_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					if (0 == 0)
					{
						break;
					}
					goto case 6;
				case 6:
					num2 = _003C_003E1__state;
					_ = 1;
					if (DucFySsVuC8dUp2X274B())
					{
						num = 2;
						if (DucFySsVuC8dUp2X274B())
						{
						}
					}
					else
					{
						num = 5;
					}
					break;
				case 1:
				case 5:
					trainMatchColorToolApi = _003C_003E4__this;
					num = 0;
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
		internal static object riPeu0sVIaG2blnNfQS1(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ConfiguredTaskAwaitable eiSUO9sVRll2rgp2HYup(object P_0, bool P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).ConfigureAwait(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HTG1uFsVewdtkhk97iPY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DucFySsVuC8dUp2X274B()
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
	private struct _003CRetrain_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ColorMatchModel> _003C_003Et__builder;

		public TrainMatchColorToolApi _003C_003E4__this;

		public ModelId modelId;

		public CvsCogShape shape;

		private ColorMatchModel _003Cmodel_003E5__2;

		private ConfiguredTaskAwaitable<ColorMatchModel>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num;
			if (uuDdkEsVaRR5bIeksyKP())
			{
				num = 4;
			}
			else
			{
				num = 1;
				if (1 == 0)
				{
					goto IL_004e;
				}
			}
			goto IL_02e6;
			IL_0024:
			_003Cmodel_003E5__2 = null;
			num = 6;
			goto IL_02e6;
			IL_004e:
			int num2 = default;
			TrainMatchColorToolApi trainMatchColorToolApi = default;
			ColorMatchModel result = default;
			try
			{
				int num3;
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = default;
				ConfiguredTaskAwaitable<ColorMatchModel>.ConfiguredTaskAwaiter awaiter2 = default;
				if (num2 != 0)
				{
					if (num2 != 1)
					{
						num3 = 6;
						if (ju9DGqsVnsqSAMdcjF1i())
						{
							goto IL_006b;
						}
					}
					else
					{
						awaiter = _003C_003Eu__2;
						num3 = 1;
					}
				}
				else
				{
					awaiter2 = _003C_003Eu__1;
					num3 = 9;
					if (1 == 0)
					{
						goto IL_01a9;
					}
				}
				goto IL_0207;
				IL_0207:
				ConfiguredTaskAwaitable<ColorMatchModel> configuredTaskAwaitable = default;
				ConfiguredTaskAwaitable configuredTaskAwaitable2 = default;
				ColorMatchModel result2 = default;
				while (true)
				{
					switch (num3)
					{
					case 3:
						break;
					case 9:
						_003C_003Eu__1 = default;
						goto case 7;
					case 6:
						configuredTaskAwaitable = trainMatchColorToolApi.by2OMu5cMQ.PostAsync<ColorMatchModel>((string)ftk0iJsVGFixWOC2IFtN(52614), new object[2] { modelId.Id, shape }).ConfigureAwait(continueOnCapturedContext: false);
						num3 = 16;
						continue;
					case 2:
						goto IL_00e2;
					case 5:
						configuredTaskAwaitable2 = trainMatchColorToolApi.tHLOJbuL3q(_003Cmodel_003E5__2).ConfigureAwait(continueOnCapturedContext: false);
						num3 = 14;
						if (0 == 0)
						{
							continue;
						}
						goto case 17;
					case 17:
						_003Cmodel_003E5__2 = result2;
						num3 = 5;
						continue;
					case 12:
						return;
					case 11:
						if (!awaiter2.IsCompleted)
						{
							num2 = (_003C_003E1__state = 0);
							num3 = 10;
							continue;
						}
						goto IL_01ed;
					case 10:
						goto IL_015a;
					case 0:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 12;
						continue;
					case 13:
						return;
					case 14:
						goto IL_01a9;
					case 16:
						awaiter2 = configuredTaskAwaitable.GetAwaiter();
						num3 = 11;
						continue;
					case 7:
					case 15:
						num2 = (_003C_003E1__state = -1);
						goto IL_01ed;
					default:
						num3 = 17;
						if (true)
						{
							continue;
						}
						goto case 4;
					case 4:
					case 8:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						num3 = 13;
						if (true)
						{
							continue;
						}
						goto case 1;
					case 1:
						_003C_003Eu__2 = default;
						num2 = (_003C_003E1__state = -1);
						num3 = 2;
						continue;
					case 18:
						{
							result = _003Cmodel_003E5__2;
							goto end_IL_004e;
						}
						IL_01ed:
						result2 = awaiter2.GetResult();
						goto case 17;
					}
					break;
					IL_015a:
					_003C_003Eu__1 = awaiter2;
					_ = 0;
					num3 = (uuDdkEsVaRR5bIeksyKP() ? 8 : 15);
				}
				goto IL_006b;
				IL_006b:
				_003C_003Eu__2 = awaiter;
				num3 = 0;
				goto IL_0207;
				IL_00e2:
				awaiter.GetResult();
				num3 = 18;
				goto IL_0207;
				IL_01a9:
				awaiter = configuredTaskAwaitable2.GetAwaiter();
				if (awaiter.IsCompleted)
				{
					goto IL_00e2;
				}
				num2 = (_003C_003E1__state = 1);
				num3 = 3;
				goto IL_0207;
				end_IL_004e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cmodel_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0024;
			IL_02e6:
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 5:
					trainMatchColorToolApi = _003C_003E4__this;
					goto IL_004e;
				case 1:
				case 2:
					goto IL_004e;
				default:
					num = 3;
					continue;
				case 6:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					continue;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_0024;
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
		internal static object ftk0iJsVGFixWOC2IFtN(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uuDdkEsVaRR5bIeksyKP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ju9DGqsVnsqSAMdcjF1i()
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
	private struct _003CTrainNewModel_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ColorMatchModel> _003C_003Et__builder;

		public TrainMatchColorToolApi _003C_003E4__this;

		public CvsCogShape shape;

		private ColorMatchModel _003Cmodel_003E5__2;

		private ConfiguredTaskAwaitable<ColorMatchModel>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			ColorMatchModel result = default;
			TrainMatchColorToolApi trainMatchColorToolApi = default;
			int num2 = default;
			ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = default;
			ConfiguredTaskAwaitable<ColorMatchModel>.ConfiguredTaskAwaiter awaiter2 = default;
			ConfiguredTaskAwaitable<ColorMatchModel> configuredTaskAwaitable2 = default;
			ColorMatchModel result2 = default;
			ConfiguredTaskAwaitable configuredTaskAwaitable = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003Cmodel_003E5__2 = null;
					num = 5;
					break;
				case 5:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					break;
				case 1:
				case 2:
					trainMatchColorToolApi = _003C_003E4__this;
					num = 0;
					break;
				case 4:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((!YH2b3csVXPbEnhko5jWO()) ? 6 : 2);
					break;
				case 0:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								eWQ2eJsVbdbSnsJE4M7s();
								if (YH2b3csVXPbEnhko5jWO())
								{
									num3 = 2;
								}
								else
								{
									num3 = 3;
									if (1 == 0)
									{
										goto IL_024f;
									}
								}
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 16;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							num3 = 8;
							if (!YH2b3csVXPbEnhko5jWO())
							{
								goto IL_0121;
							}
						}
						goto IL_0185;
						IL_024f:
						_003C_003Eu__2 = default;
						num3 = 6;
						goto IL_0185;
						IL_0138:
						num2 = (_003C_003E1__state = 0);
						num3 = 12;
						goto IL_0185;
						IL_0121:
						awaiter.GetResult();
						num3 = 18;
						if (eWQ2eJsVbdbSnsJE4M7s())
						{
							goto IL_0138;
						}
						goto IL_0185;
						IL_0185:
						while (true)
						{
							switch (num3)
							{
							case 8:
								_003C_003Eu__1 = default;
								num3 = 14;
								continue;
							case 12:
								_003C_003Eu__1 = awaiter2;
								num3 = 4;
								continue;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter;
									num3 = 9;
									continue;
								}
								break;
							case 1:
							case 3:
								awaiter2 = configuredTaskAwaitable2.GetAwaiter();
								num3 = 10;
								continue;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							case 13:
								break;
							case 15:
								goto IL_0138;
							case 7:
								return;
							case 14:
								num2 = (_003C_003E1__state = -1);
								goto IL_016b;
							default:
								num3 = 11;
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 13;
								continue;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 7;
								if (!eWQ2eJsVbdbSnsJE4M7s())
								{
									continue;
								}
								goto case 0;
							case 0:
							case 2:
								configuredTaskAwaitable2 = trainMatchColorToolApi.by2OMu5cMQ.PostAsync<ColorMatchModel>(kgbOBx7BanbFa22Hp9.ol99ukmDA(52632), new object[1] { shape }).ConfigureAwait(continueOnCapturedContext: false);
								goto case 1;
							case 16:
								goto IL_024f;
							case 11:
								_003Cmodel_003E5__2 = result2;
								configuredTaskAwaitable = YOwQgasV687PE5envI1D(trainMatchColorToolApi.tHLOJbuL3q(_003Cmodel_003E5__2), false);
								num3 = 17;
								if (eWQ2eJsVbdbSnsJE4M7s())
								{
								}
								continue;
							case 10:
								if (!awaiter2.IsCompleted)
								{
									num3 = 15;
									if (eWQ2eJsVbdbSnsJE4M7s())
									{
									}
									continue;
								}
								goto IL_016b;
							case 17:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								num3 = 5;
								continue;
							case 18:
								{
									result = _003Cmodel_003E5__2;
									goto end_IL_006d;
								}
								IL_016b:
								result2 = awaiter2.GetResult();
								goto case 11;
							}
							break;
						}
						goto IL_0121;
						end_IL_006d:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003Cmodel_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
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
		internal static ConfiguredTaskAwaitable YOwQgasV687PE5envI1D(object P_0, bool P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).ConfigureAwait(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YH2b3csVXPbEnhko5jWO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eWQ2eJsVbdbSnsJE4M7s()
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
	private struct _003CGetSamplesFor_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TrainMatchColorToolApi _003C_003E4__this;

		public ColorMatchModel model;

		private ConfiguredTaskAwaitable<ColorModelColorSamples>.ConfiguredTaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			int num2 = default;
			int num3 = default;
			ConfiguredTaskAwaitable<ColorModelColorSamples>.ConfiguredTaskAwaiter awaiter = default;
			ColorModelColorSamples result = default;
			ConfiguredTaskAwaitable<ColorModelColorSamples> configuredTaskAwaitable = default;
			TrainMatchColorToolApi trainMatchColorToolApi = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
					try
					{
						int num4;
						if (num2 != 0)
						{
							num3 = 101;
							num4 = 4;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num4 = 10;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								result = awaiter.GetResult();
								num4 = 11;
								continue;
							case 3:
								_003C_003Eu__1 = awaiter;
								num4 = 7;
								if (true)
								{
									continue;
								}
								goto case 4;
							case 4:
								configuredTaskAwaitable = trainMatchColorToolApi.by2OMu5cMQ.PostAsync<ColorModelColorSamples>(kgbOBx7BanbFa22Hp9.ol99ukmDA(52544), new object[2]
								{
									GnjvFtsV40T9bvu3XrWk(model).Id,
									num3
								}).ConfigureAwait(continueOnCapturedContext: false);
								num4 = 9;
								continue;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num4 = 1;
								continue;
							case 10:
								_003C_003Eu__1 = default;
								num4 = 0;
								continue;
							default:
								return;
							case 6:
								return;
							case 2:
							case 8:
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									num4 = 3;
									continue;
								}
								goto case 1;
							case 11:
								eDFPxKsVkKwN1EFqZs1x(model, result);
								num4 = 12;
								continue;
							case 9:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								a7gGnHsV0T4S0oEbhPnl();
								if (TZJsO5sVpebfpP6Yf8dq())
								{
									num4 = 8;
									if (true)
									{
										continue;
									}
									goto case 7;
								}
								num4 = 6;
								continue;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 12:
								CqjIjDsVmn70mqBCpL0V(X6gKMrsVfudJ8CbToxfb(model), ((IEnumerable<Rgb>)g43sL8sVFZ2qEbdOSXAA(model.Samples)).Reverse().ToArray());
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
					break;
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					if (TZJsO5sVpebfpP6Yf8dq())
					{
						continue;
					}
					goto case 4;
				case 4:
					trainMatchColorToolApi = _003C_003E4__this;
					_ = 0;
					if (!TZJsO5sVpebfpP6Yf8dq())
					{
						num = 0;
						if (true)
						{
							continue;
						}
						goto case 1;
					}
					num = 5;
					continue;
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
		internal static ModelId GnjvFtsV40T9bvu3XrWk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ColorMatchModel)P_0).UniqueModelId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void eDFPxKsVkKwN1EFqZs1x(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ColorMatchModel)P_0).Samples = (ColorModelColorSamples)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object X6gKMrsVfudJ8CbToxfb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ColorMatchModel)P_0).Samples;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object g43sL8sVFZ2qEbdOSXAA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ColorModelColorSamples)P_0).LineDarkPoints;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void CqjIjDsVmn70mqBCpL0V(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ColorModelColorSamples)P_0).LineDarkPoints = (Rgb[])P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TZJsO5sVpebfpP6Yf8dq()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool a7gGnHsV0T4S0oEbhPnl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly ResourceNode by2OMu5cMQ;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TrainMatchColorToolApi(ResourceNode resourceNode)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Hvq8r9iYd7PyIlCIW7v();
		int num = (R4mUcciNlMEMtLxSQFS() ? 4 : 3);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				UPMHdWixf2u8EawowCk();
				goto case 1;
			case 1:
			case 4:
				R1xy4Wi1m9YQgTfeXgE(this);
				break;
			default:
				num = 2;
				if (!R4mUcciNlMEMtLxSQFS())
				{
					continue;
				}
				break;
			case 2:
				break;
			case 5:
				return;
			}
			by2OMu5cMQ = resourceNode;
			num = 5;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetAllModels_003Ed__2))]
	public Task<ColorMatchModel[]> GetAllModels()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetAllModels_003Ed__2 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ColorMatchModel[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task UpdateModelSettings(ModelId modelId, ColorMatchModelSettings settings)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return by2OMu5cMQ.PostAsync<ColorMatchModel>(kgbOBx7BanbFa22Hp9.ol99ukmDA(12354), new object[2] { modelId.Id, settings });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task RemoveModel(ModelId modelId)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return by2OMu5cMQ.PostAsync<object>(kgbOBx7BanbFa22Hp9.ol99ukmDA(12386), new object[1] { modelId.Id });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRetrain_003Ed__5))]
	public Task<ColorMatchModel> Retrain(ModelId modelId, CvsCogShape shape)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CRetrain_003Ed__5 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ColorMatchModel>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.modelId = modelId;
		stateMachine.shape = shape;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CTrainNewModel_003Ed__6))]
	public Task<ColorMatchModel> TrainNewModel(CvsCogShape shape)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CTrainNewModel_003Ed__6 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ColorMatchModel>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.shape = shape;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<string> GetLibraryName()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return by2OMu5cMQ.GetAsync<string>(kgbOBx7BanbFa22Hp9.ol99ukmDA(4310));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task SetLibraryName(string name)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return by2OMu5cMQ.PutAsync<object>((string)dA6qViirakIX4SnNe3I(4310), name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetSamplesFor_003Ed__9))]
	private Task tHLOJbuL3q(ColorMatchModel P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Hvq8r9iYd7PyIlCIW7v();
		int num;
		if (!R4mUcciNlMEMtLxSQFS())
		{
			num = 3;
			if (!Hvq8r9iYd7PyIlCIW7v())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 6;
		}
		goto IL_0048;
		IL_0077:
		_003CGetSamplesFor_003Ed__9 stateMachine = default;
		stateMachine._003C_003E1__state = -1;
		num = 5;
		goto IL_0048;
		IL_0048:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			default:
				num = 2;
				continue;
			case 2:
				goto IL_0077;
			case 0:
			case 3:
				stateMachine._003C_003Et__builder = RDU3pHi3ISa713VcAHh();
				goto case 1;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 4;
				if (R4mUcciNlMEMtLxSQFS())
				{
				}
				continue;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002e;
		IL_002e:
		stateMachine.model = P_0;
		goto IL_0077;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UPMHdWixf2u8EawowCk()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		VGBw0HDkD6ecRxNgrT.e2nOyGozAefKn();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void R1xy4Wi1m9YQgTfeXgE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Hvq8r9iYd7PyIlCIW7v()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool R4mUcciNlMEMtLxSQFS()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dA6qViirakIX4SnNe3I(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kgbOBx7BanbFa22Hp9.ol99ukmDA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder RDU3pHi3ISa713VcAHh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}
}
