using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Media;
using Cognex.Common.Commands;
using Cognex.InSight.Controls.ViewModels;
using Cognex.InSight.Services;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.PropertySheets;

public class UnlabeledImagesViewModel : PropertySheetChildViewModel
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInitialize_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UnlabeledImagesViewModel _003C_003E4__this;

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
			UnlabeledImagesViewModel unlabeledImagesViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					num2 = _003C_003E1__state;
					_ = 0;
					num = (V7Ms8NxpCJ7riXMXLcg() ? 4 : 0);
					continue;
				case 1:
				case 4:
					unlabeledImagesViewModel = _003C_003E4__this;
					num = 5;
					continue;
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = uPrMACxRnflloJX8qgi(unlabeledImagesViewModel.NextImage());
							num3 = 0;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 5;
									continue;
								}
								break;
							case 5:
								num2 = (_003C_003E1__state = 0);
								hxYWt4xGnJREQkJthcV();
								if (V7Ms8NxpCJ7riXMXLcg())
								{
									num3 = 4;
									continue;
								}
								num3 = 7;
								if (true)
								{
									continue;
								}
								goto case 3;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 6:
								return;
							case 1:
								_003C_003Eu__1 = default;
								num3 = 8;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
							case 4:
								_003C_003Eu__1 = awaiter;
								goto case 3;
							case 3:
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 6;
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
		internal static TaskAwaiter uPrMACxRnflloJX8qgi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool V7Ms8NxpCJ7riXMXLcg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hxYWt4xGnJREQkJthcV()
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
	private struct _003CNextImage_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UnlabeledImagesViewModel _003C_003E4__this;

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
			UnlabeledImagesViewModel unlabeledImagesViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					try
					{
						try
						{
							TaskAwaiter awaiter;
							int num3;
							if (num2 != 0)
							{
								awaiter = w7ISPfxefAVDxDFVs6q(MYtHk7xbawvBYAlts6P(CGsUBgxWlryGRvJaPWL(unlabeledImagesViewModel.aqxoXeJanm)));
								num3 = 5;
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
								case 5:
									if (!awaiter.IsCompleted)
									{
										num3 = 1;
										if (!WQUnXkxItVy92CvYYqQ())
										{
											continue;
										}
										return;
									}
									break;
								default:
									return;
								case 0:
									return;
								case 2:
								case 6:
									_003C_003Eu__1 = awaiter;
									num3 = 8;
									if (true)
									{
										continue;
									}
									goto case 3;
								case 3:
									_003C_003Eu__1 = default;
									num3 = 7;
									continue;
								case 8:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 1:
									do
									{
										num2 = (_003C_003E1__state = 0);
										_ = 0;
										if (!jc13wExjHK5RewTpaFX())
										{
											num3 = 0;
											continue;
										}
										num3 = 6;
										break;
									}
									while (1 == 0);
									continue;
								case 7:
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									if (jc13wExjHK5RewTpaFX())
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
						catch (Exception)
						{
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
					unlabeledImagesViewModel = _003C_003E4__this;
					_ = 0;
					num = (jc13wExjHK5RewTpaFX() ? 1 : 5);
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 4:
					num2 = _003C_003E1__state;
					num = 0;
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
		internal static object CGsUBgxWlryGRvJaPWL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassifyViewModel)P_0).Classifier;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MYtHk7xbawvBYAlts6P(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Classifier)P_0).NextImage();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter w7ISPfxefAVDxDFVs6q(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jc13wExjHK5RewTpaFX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WQUnXkxItVy92CvYYqQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	private readonly ClassifyViewModel aqxoXeJanm;

	private readonly ViewModelErrors i4iogJVGjc;

	[CompilerGenerated]
	private bool qZOokTDAIw;

	private readonly PropertySheetConfiguration JgnoQVJPuB;

	private readonly AsyncRelayCommand Yy1osSdl6N;

	[CompilerGenerated]
	private string hfcobprnQl;

	public bool EnableNext
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return qZOokTDAIw;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			qZOokTDAIw = value;
		}
	}

	public IPropertySheetService PropertySheetService
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (IPropertySheetService)rWGe0orjEMh2HxgmAG1(JgnoQVJPuB);
		}
	}

	public ImageSource CurrentImage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (ImageSource)lYc5EIrIVG8GeRf5JVo(aqxoXeJanm.Classifier);
		}
	}

	public IAsyncCommand NextImageCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Yy1osSdl6N;
		}
	}

	public string Expression
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return hfcobprnQl;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			hfcobprnQl = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UnlabeledImagesViewModel(ClassifyViewModel parentViewModel)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 7;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				aqxoXeJanm = parentViewModel;
				num = 3;
				continue;
			case 8:
				base._002Ector(parentViewModel);
				_ = 1;
				if (!naBpmGrNId5Je2D6cdE())
				{
					num = 5;
					if (naBpmGrNId5Je2D6cdE())
					{
					}
				}
				else
				{
					num = 1;
				}
				continue;
			case 7:
				hDSKO7rwBFCaKbcwjr4();
				num = 8;
				if (true)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 6:
				Yy1osSdl6N = ((ViewModelCommandHelper)IRJTpRrGTLGHGotP3Xu(this)).CreateAsyncCommand((Func<Task>)NextImage, (Func<bool>)([MethodImpl(MethodImplOptions.NoInlining)] () =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return EnableNext;
				}), (string)null, (string)null);
				num = 9;
				continue;
			case 0:
				EnableNext = true;
				goto case 1;
			case 3:
				JgnoQVJPuB = (PropertySheetConfiguration)jgLcnGrpbRiJ5rraQVX(parentViewModel);
				break;
			default:
				num = 4;
				continue;
			case 4:
				break;
			case 9:
				return;
			}
			i4iogJVGjc = new ViewModelErrors(this);
			num = 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInitialize_003Ed__3))]
	public Task Initialize()
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
		goto IL_004a;
		IL_001a:
		_003CInitialize_003Ed__3 stateMachine = default;
		stateMachine._003C_003Et__builder = uxUwIKrR3rmiDjauH8J();
		num = 0;
		goto IL_004a;
		IL_004a:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 0:
				stateMachine._003C_003E4__this = this;
				gavKmQrAdF4gYvjfFSx();
				num = ((!naBpmGrNId5Je2D6cdE()) ? 4 : 5);
				continue;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CNextImage_003Ed__16))]
	public Task NextImage()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!gavKmQrAdF4gYvjfFSx()) ? 4 : 2);
		_003CNextImage_003Ed__16 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = uxUwIKrR3rmiDjauH8J();
				goto case 1;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (gavKmQrAdF4gYvjfFSx())
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool CAZoqMm3EU()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return EnableNext;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hDSKO7rwBFCaKbcwjr4()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jgLcnGrpbRiJ5rraQVX(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ClassifyViewModel)P_0).PropertySheetConfiguration;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IRJTpRrGTLGHGotP3Xu(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertySheetChildViewModel)P_0).CommandHelper;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gavKmQrAdF4gYvjfFSx()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool naBpmGrNId5Je2D6cdE()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder uxUwIKrR3rmiDjauH8J()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rWGe0orjEMh2HxgmAG1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertySheetConfiguration)P_0).PropertySheetService;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lYc5EIrIVG8GeRf5JVo(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Classifier)P_0).CurrentImage;
	}
}
