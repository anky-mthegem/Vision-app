using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Cognex.InSight.Remoting.Serialization.ViDiEL.Classify;
using Cognex.InSight.Services;
using Cognex.Mvvm;
using jUKn21pup6XFIrInBb;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels;

public class ClassifyImage : BaseViewModel
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUpdatePrediction_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ClassifyImage _003C_003E4__this;

		private TaskAwaiter<ELClassifyPredictedResult> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			ClassifyImage classifyImage = default;
			int num2 = default;
			ELClassifyPredictedResult result = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (0 == 0)
					{
						break;
					}
					goto case 1;
				case 1:
				case 5:
					classifyImage = _003C_003E4__this;
					goto case 2;
				case 2:
				case 4:
					try
					{
						TaskAwaiter<ELClassifyPredictedResult> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = classifyImage.JRlIKSm5RE().GetAwaiter();
							num3 = 7;
							if (false)
							{
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 6;
							if (false)
							{
								goto IL_0088;
							}
						}
						goto IL_0141;
						IL_00a0:
						if (awaiter.IsCompleted)
						{
							goto IL_0088;
						}
						_ = 1;
						num3 = (PR98qOFJLA8LKNECSZQ() ? 8 : 0);
						goto IL_0141;
						IL_0088:
						result = awaiter.GetResult();
						num3 = 2;
						if (!Gyu8guFYZAk6OrlPjLk())
						{
							goto IL_00a0;
						}
						goto IL_0141;
						IL_0141:
						while (true)
						{
							switch (num3)
							{
							case 4:
								return;
							case 5:
								break;
							case 7:
								goto IL_00a0;
							case 0:
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 9;
								continue;
							case 2:
								classifyImage.Score = result?.Score ?? 0.0;
								if (!classifyImage.IsLabeled)
								{
									num3 = 10;
									continue;
								}
								goto end_IL_0046;
							case 9:
								_003C_003Eu__1 = awaiter;
								goto case 3;
							case 3:
							case 8:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 4;
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 5;
								continue;
							case 10:
								classifyImage.Label = (string)O6R5K6FKoklukFKSCcA(result);
								goto end_IL_0046;
							}
							break;
						}
						goto IL_0088;
						end_IL_0046:;
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
					PR98qOFJLA8LKNECSZQ();
					num = (Gyu8guFYZAk6OrlPjLk() ? 5 : 4);
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
		internal static object O6R5K6FKoklukFKSCcA(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELClassifyPredictedResult)P_0).Label;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Gyu8guFYZAk6OrlPjLk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PR98qOFJLA8LKNECSZQ()
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
	private struct _003CGetPrediction_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ELClassifyPredictedResult> _003C_003Et__builder;

		public ClassifyImage _003C_003E4__this;

		private TaskAwaiter<ELClassifyPredictedResult> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			VoTkZ1FAheNQ7X35h8r();
			int num = ((!XGvIulFCdkaEIQL18It()) ? 4 : 2);
			ClassifyImage classifyImage = default;
			int num2 = default;
			ELClassifyPredictedResult result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					classifyImage = _003C_003E4__this;
					num = 5;
					continue;
				case 5:
					try
					{
						TaskAwaiter<ELClassifyPredictedResult> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = classifyImage.UUJImYeMV0().GetPredictedResult(classifyImage.ImageId).GetAwaiter();
							num3 = 8;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
						}
						ELClassifyPredictedResult eLClassifyPredictedResult;
						while (true)
						{
							switch (num3)
							{
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto default;
							default:
								VoTkZ1FAheNQ7X35h8r();
								num3 = (XGvIulFCdkaEIQL18It() ? 1 : 3);
								continue;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								goto case 3;
							case 3:
							case 7:
								eLClassifyPredictedResult = awaiter.GetResult();
								if (eLClassifyPredictedResult == null)
								{
									num3 = 10;
									continue;
								}
								break;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 5;
								continue;
							case 6:
								_003C_003Eu__1 = awaiter;
								num3 = 9;
								continue;
							case 5:
								num2 = (_003C_003E1__state = -1);
								goto case 3;
							case 1:
							case 4:
								return;
							case 0:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								if (XGvIulFCdkaEIQL18It())
								{
									continue;
								}
								goto case 10;
							case 10:
								eLClassifyPredictedResult = new ELClassifyPredictedResult();
								break;
							}
							break;
						}
						result = eLClassifyPredictedResult;
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
					num = 3;
					continue;
				case 3:
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult(result);
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
		internal static bool XGvIulFCdkaEIQL18It()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VoTkZ1FAheNQ7X35h8r()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private readonly IViDiELClassifyService gFuI7PmjVA;

	[CompilerGenerated]
	private string EF6IYsTrvU;

	[CompilerGenerated]
	private readonly BitmapImage z4GI07t8XT;

	[CompilerGenerated]
	private bool aavIvTb8SK;

	[CompilerGenerated]
	private readonly string iK7ILEpUpH;

	[CompilerGenerated]
	private readonly string aZjIdLbwcw;

	private double uf4I5NkSju;

	private bool ipwIfP8UbZ;

	public string Label
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return EF6IYsTrvU;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			EF6IYsTrvU = value;
		}
	}

	public BitmapImage Image
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return z4GI07t8XT;
		}
	}

	public bool IsLabeled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aavIvTb8SK;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			aavIvTb8SK = value;
		}
	}

	public string ImageId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return iK7ILEpUpH;
		}
	}

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aZjIdLbwcw;
		}
	}

	public double Score
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return uf4I5NkSju;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			uf4I5NkSju = value;
			RaisePropertyChangedEvent(new PropertyChangedEventArgs((string)VBC0seIjBnQCCemB7c(716)));
		}
	}

	public bool IsBelowThreshold
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ipwIfP8UbZ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			ipwIfP8UbZ = value;
			E7q76oWvcFtYYWjQcM(this, new PropertyChangedEventArgs((string)VBC0seIjBnQCCemB7c(730)));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClassifyImage(IViDiELClassifyService service, string imageId, BitmapImage image, bool isLabeled, string category = "", string name = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		if (false)
		{
			goto IL_001a;
		}
		goto IL_0042;
		IL_001a:
		dS2BuVGjIYgOmE4xf6();
		num = 2;
		goto IL_0042;
		IL_0042:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 4:
				z4GI07t8XT = image;
				goto case 9;
			default:
				num = 9;
				continue;
			case 0:
				aZjIdLbwcw = name;
				goto case 6;
			case 6:
			case 8:
				IsBelowThreshold = false;
				num = 11;
				if (znAe4IwRGJ7WfJ9dnE())
				{
					continue;
				}
				goto case 2;
			case 2:
				wfsYPhRER6o2dEMSuC(this);
				num = 7;
				continue;
			case 5:
				iK7ILEpUpH = imageId;
				num = 0;
				continue;
			case 9:
				IsLabeled = isLabeled;
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 7;
			case 7:
				gFuI7PmjVA = service;
				_ = 0;
				num = (znAe4IwRGJ7WfJ9dnE() ? 10 : 6);
				continue;
			case 3:
			case 10:
				Label = category;
				num = 4;
				continue;
			case 11:
				return;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUpdatePrediction_003Ed__1))]
	public Task UpdatePrediction()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (znAe4IwRGJ7WfJ9dnE())
		{
			num = 2;
			if (!znAe4IwRGJ7WfJ9dnE())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 1;
		}
		goto IL_0084;
		IL_002a:
		_003CUpdatePrediction_003Ed__1 stateMachine = default;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0084;
		IL_0084:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = YHj4C2jXjNscWoW4PX();
				num = 5;
				continue;
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 4;
				continue;
			case 4:
				stateMachine._003C_003E1__state = -1;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearPrediction()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!znAe4IwRGJ7WfJ9dnE())
		{
			goto IL_001e;
		}
		goto IL_003b;
		IL_001e:
		if (!IsLabeled)
		{
			goto IL_0068;
		}
		return;
		IL_003b:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			default:
				goto IL_0068;
			case 0:
				goto IL_007d;
			case 5:
				return;
			}
			break;
			IL_007d:
			Score = 0.0;
			znAe4IwRGJ7WfJ9dnE();
			if (Ota8vyp57IbHxEdjcf())
			{
				num = 3;
				continue;
			}
			num = 4;
			if (1 == 0)
			{
				return;
			}
		}
		goto IL_001e;
		IL_0068:
		Label = string.Empty;
		num = 5;
		goto IL_003b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetPrediction_003Ed__3))]
	private Task<ELClassifyPredictedResult> JRlIKSm5RE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetPrediction_003Ed__3 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ELClassifyPredictedResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[CompilerGenerated]
	private IViDiELClassifyService UUJImYeMV0()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return gFuI7PmjVA;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dS2BuVGjIYgOmE4xf6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wfsYPhRER6o2dEMSuC(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseViewModel)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool znAe4IwRGJ7WfJ9dnE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Ota8vyp57IbHxEdjcf()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder YHj4C2jXjNscWoW4PX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VBC0seIjBnQCCemB7c(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void E7q76oWvcFtYYWjQcM(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).RaisePropertyChangedEvent((PropertyChangedEventArgs)P_1);
	}
}
