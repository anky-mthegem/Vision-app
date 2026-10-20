using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Composition;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Cognex.Common;
using Cognex.Designer.Utils.Operations;
using Cognex.Extensions;
using Cognex.Foundations.Mvvm.Common;
using Cognex.InSight.Cell;
using Cognex.InSight.Controls.ViewModels.Common;
using Cognex.InSight.Internal;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Remoting.Serialization.ViDiEL.Classify;
using Cognex.InSight.Services;
using Cognex.InSight.Undo;
using Cognex.InSight.ViDiEL.ViewModels.Extensions;
using Cognex.InSight.ViDiEL.ViewModels.Interfaces;
using Cognex.InSight.ViDiEL.ViewModels.Properties;
using Cognex.InSight.ViDiEL.ViewModels.PropertySheets;
using Cognex.InSight.ViDiEL.ViewModels.UndoActions;
using Cognex.Mvvm;
using jUKn21pup6XFIrInBb;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels;

[Export(typeof(Classifier))]
public class Classifier : BaseViewModel, IModelHealthViewModel, IDisposable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<IEnumerable<string>, bool> _003C_003E9__16_5;

		public static Func<ClassViewModel, bool> _003C_003E9__85_0;

		public static Func<ClassViewModel, int> _003C_003E9__95_0;

		public static Func<ClassifyImage, bool> _003C_003E9__121_0;

		public static Func<ClassViewModel, IEnumerable<ImageListViewModel>> _003C_003E9__123_0;

		public static Func<ImageListViewModel, IEnumerable<ClassifyImage>> _003C_003E9__123_1;

		public static Func<ClassViewModel, IEnumerable<ClassifyImage>> _003C_003E9__127_0;

		public static Func<ClassifyImage, bool> _003C_003E9__133_0;

		public static Func<ClassViewModel, IEnumerable<ImageListViewModel>> _003C_003E9__169_0;

		public static Func<ImageListViewModel, IEnumerable<ClassifyImage>> _003C_003E9__170_0;

		public static Func<ClassViewModel, string> _003C_003E9__172_0;

		public static Func<ClassifyImage, string, bool> _003C_003E9__175_0;

		public static Func<ClassifyImage, string, bool> _003C_003E9__176_0;

		public static Func<ClassViewModel, bool> _003C_003E9__189_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			jsOaM1gzFGBfjNFFT0d();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			jsOaM1gzFGBfjNFFT0d();
			qe1aTh129lKTB35LMDo(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003C_002Ector_003Eb__16_5(IEnumerable<string> _)
		{
			while (false)
			{
				object obj = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003Cget_IsEditingClassNames_003Eb__85_0(ClassViewModel classItem)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return oGUASO1XU3ro4queWpB(classItem);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int _003CRefreshNumImages_003Eb__95_0(ClassViewModel c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return oiGakQ1MOw249f8idkk(c);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003Cget_AreLabeledImagesSelected_003Eb__121_0(ClassifyImage image)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return image.IsLabeled;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<ImageListViewModel> _003Cget_SelectedImagesInfo_003Eb__123_0(ClassViewModel category)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return category.AllImageViewModels;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<ClassifyImage> _003Cget_SelectedImagesInfo_003Eb__123_1(ImageListViewModel imageViewModel)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return imageViewModel.SelectedImages;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<ClassifyImage> _003Cget_UnlabeledImagesInfo_003Eb__127_0(ClassViewModel category)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return category.UnlabeledImages;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CCanUnlabelSelectedImages_003Eb__133_0(ClassifyImage image)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SoWjby1k5mFmNVH1AHr(image);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<ImageListViewModel> _003Cget_AllImageViewModels_003Eb__169_0(ClassViewModel viewModel)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return viewModel.AllImageViewModels;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<ClassifyImage> _003CGetImagesFromIds_003Eb__170_0(ImageListViewModel imgList)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return imgList;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _003CRefreshClasses_003Eb__172_0(ClassViewModel classItem)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)H2sa3S1mpuIDNe6MDnt(classItem);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CRefreshLabeledImages_003Eb__175_0(ClassifyImage vm, string imageId)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)PeKeGu1rd7T7VXwK5NP(vm) == imageId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CRefreshUnlabeledImages_003Eb__176_0(ClassifyImage vm, string id)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return s1pxfG1PuDFQLRAT3BZ(PeKeGu1rd7T7VXwK5NP(vm), id);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CRefreshIsLastPass_003Eb__189_0(ClassViewModel c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return !Vdn0MY1gUQuSqMy8vWP(Dybv9G14B5kKB7qqtim(c));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jsOaM1gzFGBfjNFFT0d()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QovibggnAn638eVVSkA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XthKlJgffWEEmheWrZ6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void qe1aTh129lKTB35LMDo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oGUASO1XU3ro4queWpB(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassViewModel)P_0).IsInRenameMode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int oiGakQ1MOw249f8idkk(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassViewModel)P_0).ImageCount;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SoWjby1k5mFmNVH1AHr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassifyImage)P_0).IsLabeled;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object H2sa3S1mpuIDNe6MDnt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassViewModel)P_0).ClassName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PeKeGu1rd7T7VXwK5NP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassifyImage)P_0).ImageId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool s1pxfG1PuDFQLRAT3BZ(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Dybv9G14B5kKB7qqtim(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassViewModel)P_0).ClassResult;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Vdn0MY1gUQuSqMy8vWP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassResultViewModel)P_0).IsFailClass;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnUnlabeledImagesChanged_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			db2Saq11K3eKWYD2ael();
			int num = (K5B8Zo1Sx8B3LkUMqCX() ? 3 : 5);
			int num2 = default;
			TaskAwaiter awaiter = default;
			Classifier classifier = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 9;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 3;
								if (K5B8Zo1Sx8B3LkUMqCX())
								{
									goto IL_0252;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 0;
							if (K5B8Zo1Sx8B3LkUMqCX())
							{
								goto IL_02aa;
							}
						}
						goto IL_00ea;
						IL_0258:
						Func<Task> func;
						object obj = func();
						goto IL_025d;
						IL_0213:
						obj = Task.CompletedTask;
						goto IL_0218;
						IL_0252:
						obj = null;
						goto IL_025d;
						IL_0218:
						awaiter = UTLHPA16RCT47n2hPuh(obj);
						if (!awaiter.IsCompleted)
						{
							num3 = 12;
							if (false)
							{
								return;
							}
							goto IL_00ea;
						}
						goto IL_02aa;
						IL_00ea:
						while (true)
						{
							switch (num3)
							{
							case 17:
								num2 = (_003C_003E1__state = 0);
								num3 = 5;
								continue;
							case 12:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								if (true)
								{
									continue;
								}
								goto case 18;
							case 18:
								func = classifier.PZBIOJE1yl;
								if (func == null)
								{
									num3 = 15;
									if (K5B8Zo1Sx8B3LkUMqCX())
									{
									}
									continue;
								}
								goto IL_0258;
							case 9:
								classifier.SortUnlabeledImages();
								num3 = 2;
								if (K5B8Zo1Sx8B3LkUMqCX())
								{
								}
								continue;
							case 19:
								if (!awaiter.IsCompleted)
								{
									num3 = 17;
									continue;
								}
								goto case 6;
							case 1:
								uW218U1De4uvEm1SJxN(classifier.wCcIivQraK);
								goto case 8;
							default:
								num3 = 8;
								if (true)
								{
									continue;
								}
								goto case 8;
							case 8:
								classifier.RaisePropertyChangedEvent(new PropertyChangedEventArgs(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(518)));
								_ = 0;
								num3 = ((!db2Saq11K3eKWYD2ael()) ? 14 : 16);
								continue;
							case 11:
								num2 = (_003C_003E1__state = -1);
								num3 = 20;
								if (!K5B8Zo1Sx8B3LkUMqCX())
								{
									continue;
								}
								goto case 2;
							case 2:
								awaiter = UTLHPA16RCT47n2hPuh(classifier.ROyGHJmpI());
								num3 = 19;
								continue;
							case 10:
							case 16:
								PwLPrI1FlP6yCbrahLh(classifier, new PropertyChangedEventArgs((string)BvfMqX18UHncx66A74b(6814)));
								num3 = 18;
								continue;
							case 0:
								num2 = (_003C_003E1__state = -1);
								num3 = 6;
								continue;
							case 6:
								awaiter.GetResult();
								num3 = 1;
								continue;
							case 5:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								continue;
							case 3:
								_003C_003Eu__1 = default;
								num3 = 11;
								continue;
							case 13:
							case 14:
								break;
							case 4:
								return;
							case 15:
								goto IL_0252;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 20:
								goto IL_02aa;
							}
							break;
						}
						goto IL_0213;
						IL_025d:
						if (obj == null)
						{
							goto IL_0213;
						}
						goto IL_0218;
						IL_02aa:
						awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 4;
				default:
					num = 4;
					if (db2Saq11K3eKWYD2ael())
					{
						break;
					}
					goto case 1;
				case 1:
					classifier = _003C_003E4__this;
					goto case 2;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 1;
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
		internal static TaskAwaiter UTLHPA16RCT47n2hPuh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void uW218U1De4uvEm1SJxN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BaseDelegateCommand)P_0).RaiseCanExecuteChanged();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BvfMqX18UHncx66A74b(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PwLPrI1FlP6yCbrahLh(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BasePropertyChanged)P_0).RaisePropertyChangedEvent((PropertyChangedEventArgs)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool db2Saq11K3eKWYD2ael()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool K5B8Zo1Sx8B3LkUMqCX()
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
	private struct _003COnLabeledImagesChanged_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

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
			Classifier classifier = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (true)
					{
						break;
					}
					goto case 0;
				case 0:
				case 2:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						switch (num2)
						{
						default:
							awaiter = i4u19k1E7aLlVn7uuCq(classifier.RefreshModelHealth());
							num3 = 27;
							goto IL_0496;
						case 2:
							awaiter = _003C_003Eu__1;
							num3 = 30;
							goto IL_0496;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 13;
							goto IL_0496;
						case 1:
							awaiter = _003C_003Eu__1;
							num3 = 6;
							goto IL_0496;
						case 4:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 2;
							goto IL_0496;
						case 6:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 45;
							goto IL_0496;
						case 7:
							awaiter = _003C_003Eu__1;
							num3 = 18;
							goto IL_0496;
						case 5:
							awaiter = _003C_003Eu__1;
							num3 = 47;
							goto IL_0496;
						case 3:
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								goto IL_017a;
							}
							IL_0496:
							while (true)
							{
								object obj;
								switch (num3)
								{
								case 9:
									awaiter.GetResult();
									num3 = 14;
									if (hl0hgU1sqyZBD16lJbZ())
									{
										continue;
									}
									goto case 22;
								case 22:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 5);
										num3 = 43;
										continue;
									}
									goto case 15;
								case 17:
									return;
								case 32:
									return;
								case 26:
									return;
								case 0:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 17;
									continue;
								case 35:
									awaiter.GetResult();
									num3 = 20;
									continue;
								case 30:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 9;
									if (UuuQ241d9fns56r9Ji7())
									{
									}
									continue;
								case 18:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 53;
									continue;
								case 49:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 4);
										_003C_003Eu__1 = awaiter;
										num3 = 12;
										continue;
									}
									goto case 11;
								case 34:
									break;
								case 10:
									awaiter.GetResult();
									num3 = 25;
									continue;
								case 46:
									return;
								case 21:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 20:
									awaiter = i4u19k1E7aLlVn7uuCq(classifier.ROyGHJmpI());
									num3 = 49;
									continue;
								case 31:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 37;
									continue;
								case 24:
									_003C_003Eu__1 = awaiter;
									num3 = 21;
									continue;
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 26;
									continue;
								case 25:
									awaiter = i4u19k1E7aLlVn7uuCq(classifier.RefreshUnlabeledImagePredictions());
									num3 = 8;
									continue;
								case 1:
									_003C_003Eu__1 = awaiter;
									num3 = 29;
									continue;
								case 11:
									awaiter.GetResult();
									awaiter = i4u19k1E7aLlVn7uuCq(classifier.IRgNWRx4r());
									num3 = 22;
									continue;
								case 48:
									num2 = (_003C_003E1__state = 6);
									num3 = 24;
									continue;
								case 5:
									num2 = (_003C_003E1__state = 0);
									num3 = 1;
									continue;
								case 33:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 12:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 46;
									continue;
								case 8:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 2);
										num3 = 4;
										continue;
									}
									goto case 9;
								case 15:
								case 38:
									awaiter.GetResult();
									awaiter = i4u19k1E7aLlVn7uuCq(classifier.RunSheet());
									if (!awaiter.IsCompleted)
									{
										num3 = 48;
										if (true)
										{
											continue;
										}
										goto case 45;
									}
									goto case 36;
								case 45:
									num2 = (_003C_003E1__state = -1);
									num3 = 36;
									continue;
								case 23:
									awaiter = i4u19k1E7aLlVn7uuCq(classifier.RefreshUnlabeledImages());
									num3 = 41;
									continue;
								case 14:
									awaiter = i4u19k1E7aLlVn7uuCq(classifier.RefreshLabeledImagePredictions());
									if (awaiter.IsCompleted)
									{
										goto case 35;
									}
									num3 = 28;
									if (true)
									{
										continue;
									}
									goto case 16;
								case 16:
								case 44:
									dB74831366xRN5y9X1T(classifier, new PropertyChangedEventArgs((string)sFqhgf153XhmykdnPNC(518)));
									num3 = 42;
									continue;
								case 7:
									num2 = (_003C_003E1__state = 7);
									_003C_003Eu__1 = awaiter;
									num3 = 33;
									continue;
								case 50:
									_003C_003Eu__1 = awaiter;
									num3 = 31;
									continue;
								case 43:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 40:
									num2 = (_003C_003E1__state = -1);
									num3 = 19;
									continue;
								case 36:
									awaiter.GetResult();
									goto case 16;
								case 19:
									awaiter.GetResult();
									num3 = 23;
									if (0 == 0)
									{
										continue;
									}
									goto case 6;
								case 6:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 10;
									continue;
								case 42:
								{
									Func<Task> func = classifier.uLWzX3Iav;
									if (func == null)
									{
										num3 = 51;
										continue;
									}
									obj = func();
									goto IL_0664;
								}
								case 37:
									return;
								default:
									num3 = 34;
									if (true)
									{
										continue;
									}
									goto case 2;
								case 2:
									num2 = (_003C_003E1__state = -1);
									num3 = 11;
									continue;
								case 41:
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 1);
										_003C_003Eu__1 = awaiter;
										num3 = 3;
										continue;
									}
									goto case 10;
								case 28:
									num2 = (_003C_003E1__state = 3);
									num3 = 50;
									if (hl0hgU1sqyZBD16lJbZ())
									{
										continue;
									}
									goto case 52;
								case 52:
									num2 = (_003C_003E1__state = -1);
									_ = 1;
									if (UuuQ241d9fns56r9Ji7())
									{
										num3 = 16;
										continue;
									}
									num3 = 15;
									if (true)
									{
										continue;
									}
									goto case 39;
								case 39:
									obj = hvm9c31anGoAdFZukfP();
									goto IL_05f7;
								case 27:
									if (awaiter.IsCompleted)
									{
										goto case 19;
									}
									num3 = 5;
									if (0 == 0)
									{
										continue;
									}
									goto case 29;
								case 29:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 32;
									continue;
								case 13:
									_003C_003Eu__1 = default;
									num3 = 40;
									continue;
								case 51:
									obj = null;
									goto IL_0664;
								case 4:
									_003C_003Eu__1 = awaiter;
									num3 = 0;
									if (hl0hgU1sqyZBD16lJbZ())
									{
										continue;
									}
									goto case 47;
								case 47:
									_003C_003Eu__1 = default;
									num3 = 52;
									continue;
								case 53:
									{
										awaiter.GetResult();
										goto end_IL_0496;
									}
									IL_0664:
									if (obj == null)
									{
										num3 = 39;
										continue;
									}
									goto IL_05f7;
									IL_05f7:
									awaiter = ((Task)obj).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num3 = 7;
										continue;
									}
									goto case 53;
								}
								goto IL_017a;
								continue;
								end_IL_0496:
								break;
							}
							break;
							IL_017a:
							num2 = (_003C_003E1__state = -1);
							num3 = 35;
							goto IL_0496;
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
				case 5:
					classifier = _003C_003E4__this;
					hl0hgU1sqyZBD16lJbZ();
					num = (UuuQ241d9fns56r9Ji7() ? 1 : 0);
					break;
				case 4:
					num2 = _003C_003E1__state;
					num = 5;
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
		internal static TaskAwaiter i4u19k1E7aLlVn7uuCq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object sFqhgf153XhmykdnPNC(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void dB74831366xRN5y9X1T(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BasePropertyChanged)P_0).RaisePropertyChangedEvent((PropertyChangedEventArgs)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hvm9c31anGoAdFZukfP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hl0hgU1sqyZBD16lJbZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UuuQ241d9fns56r9Ji7()
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
	private struct _003CRefresh_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zXikxM1cOpvGZlAFJq9();
			int num = ((!cJO6tF1oZeC3g5xMVPb()) ? 1 : 4);
			Classifier classifier = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 2:
					classifier = _003C_003E4__this;
					num = 5;
					break;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 2;
					break;
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						switch (num2)
						{
						default:
							awaiter = kRLs011uCvtqUW8LCIu(classifier.RefreshLabeledImages());
							num3 = 2;
							if (false)
							{
								goto IL_0095;
							}
							goto IL_00b3;
						case 3:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0290;
						case 4:
							awaiter = _003C_003Eu__1;
							num3 = 14;
							goto IL_00b3;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 20;
							goto IL_00b3;
						case 1:
							awaiter = _003C_003Eu__1;
							num3 = 8;
							if (cJO6tF1oZeC3g5xMVPb())
							{
								goto IL_00b3;
							}
							goto IL_03de;
						case 5:
							awaiter = _003C_003Eu__1;
							num3 = 21;
							goto IL_00b3;
						case 2:
							{
								awaiter = _003C_003Eu__1;
								num3 = 31;
								goto IL_00b3;
							}
							IL_00b3:
							while (true)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									num3 = 15;
									continue;
								case 23:
									awaiter.GetResult();
									awaiter = classifier.RefreshUnlabeledImages().GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num3 = 7;
										if (cJO6tF1oZeC3g5xMVPb())
										{
											continue;
										}
										goto case 0;
									}
									goto IL_0419;
								case 0:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 6;
									continue;
								case 31:
									_003C_003Eu__1 = default;
									num3 = 26;
									continue;
								case 20:
									goto IL_01bf;
								case 30:
								case 38:
									goto IL_01eb;
								case 29:
									goto IL_0202;
								case 19:
									_003C_003Eu__1 = awaiter;
									num3 = 0;
									continue;
								case 12:
									awaiter = classifier.IRgNWRx4r().GetAwaiter();
									num3 = 27;
									if (cJO6tF1oZeC3g5xMVPb())
									{
										continue;
									}
									goto case 37;
								case 37:
									num2 = (_003C_003E1__state = 5);
									_003C_003Eu__1 = awaiter;
									num3 = 5;
									continue;
								case 4:
								case 34:
									num2 = (_003C_003E1__state = -1);
									num3 = 17;
									if (true)
									{
										continue;
									}
									return;
								case 6:
									return;
								case 33:
									if (!awaiter.IsCompleted)
									{
										num3 = 28;
										continue;
									}
									goto case 23;
								case 24:
									_003C_003Eu__1 = awaiter;
									num3 = 16;
									continue;
								case 13:
									num2 = (_003C_003E1__state = -1);
									num3 = 23;
									continue;
								case 10:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 9;
									continue;
								case 17:
									awaiter.GetResult();
									awaiter = kRLs011uCvtqUW8LCIu(classifier.RefreshModelHealth());
									num3 = 33;
									continue;
								case 21:
									_003C_003Eu__1 = default;
									num3 = 25;
									continue;
								case 18:
									_003C_003Eu__1 = awaiter;
									num3 = 36;
									continue;
								case 9:
									return;
								case 11:
									return;
								case 27:
									if (!awaiter.IsCompleted)
									{
										num3 = 37;
										continue;
									}
									goto case 39;
								case 3:
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 11;
									continue;
								case 15:
									goto IL_03a1;
								case 36:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 22:
									goto IL_03de;
								case 32:
									goto IL_03fa;
								case 26:
									num2 = (_003C_003E1__state = -1);
									goto IL_0419;
								case 35:
									num2 = (_003C_003E1__state = 4);
									num3 = 29;
									if (true)
									{
										continue;
									}
									goto case 5;
								case 5:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 16:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 28:
									num2 = (_003C_003E1__state = 1);
									num3 = 18;
									continue;
								case 14:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_01eb;
								case 8:
									_003C_003Eu__1 = default;
									num3 = 13;
									continue;
								case 7:
									num2 = (_003C_003E1__state = 2);
									num3 = 24;
									if (true)
									{
										continue;
									}
									goto case 2;
								case 2:
									if (!awaiter.IsCompleted)
									{
										num3 = 3;
										continue;
									}
									goto case 17;
								case 25:
									num2 = (_003C_003E1__state = -1);
									num3 = 39;
									continue;
								case 39:
									{
										awaiter.GetResult();
										goto end_IL_0060;
									}
									IL_0419:
									awaiter.GetResult();
									awaiter = kRLs011uCvtqUW8LCIu(classifier.RefreshUnlabeledImagePredictions());
									num3 = 1;
									continue;
								}
								break;
								IL_01bf:
								_003C_003Eu__1 = default;
								_ = 1;
								if (!zXikxM1cOpvGZlAFJq9())
								{
									num3 = 34;
									if (zXikxM1cOpvGZlAFJq9())
									{
									}
								}
								else
								{
									num3 = 38;
								}
							}
							goto IL_0095;
							IL_03de:
							if (awaiter.IsCompleted)
							{
								goto IL_01eb;
							}
							num3 = 35;
							if (!zXikxM1cOpvGZlAFJq9())
							{
								goto IL_00b3;
							}
							goto IL_03fa;
							IL_0290:
							awaiter.GetResult();
							num3 = 32;
							goto IL_00b3;
							IL_03fa:
							awaiter = kRLs011uCvtqUW8LCIu(classifier.ROyGHJmpI());
							num3 = 22;
							goto IL_00b3;
							IL_01eb:
							awaiter.GetResult();
							num3 = 12;
							if (cJO6tF1oZeC3g5xMVPb())
							{
								goto IL_00b3;
							}
							goto IL_0202;
							IL_0202:
							_003C_003Eu__1 = awaiter;
							num3 = 10;
							goto IL_00b3;
							IL_0095:
							if (awaiter.IsCompleted)
							{
								goto IL_0290;
							}
							goto IL_03a1;
							IL_03a1:
							num2 = (_003C_003E1__state = 3);
							num3 = 19;
							goto IL_00b3;
							end_IL_0060:
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
		internal static TaskAwaiter kRLs011uCvtqUW8LCIu(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cJO6tF1oZeC3g5xMVPb()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zXikxM1cOpvGZlAFJq9()
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
	private struct _003COnClassesChanged_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			Classifier classifier = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 4:
					classifier = _003C_003E4__this;
					_ = 0;
					num = ((!Y0Uygq1BHrmm1EmQLnr()) ? 5 : 0);
					break;
				case 1:
					num2 = _003C_003E1__state;
					num = 4;
					break;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							classifier.SortUnlabeledImages();
							num3 = 0;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 11;
							if (eEaqZQ1xEx7JSuf3n5P())
							{
								goto IL_00cb;
							}
						}
						goto IL_00e6;
						IL_0177:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						IL_0164:
						_003C_003Eu__1 = awaiter;
						num3 = 5;
						if (true)
						{
							goto IL_00e6;
						}
						goto IL_0177;
						IL_00e6:
						while (true)
						{
							object obj;
							switch (num3)
							{
							case 9:
								obj = classifier.IcmIIhu0Tr?.Invoke();
								if (obj == null)
								{
									num3 = 6;
									continue;
								}
								goto IL_01b6;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 1:
								return;
							case 7:
								return;
							case 2:
								break;
							default:
								num3 = 10;
								continue;
							case 11:
								_003C_003Eu__1 = default;
								num3 = 4;
								if (Y0Uygq1BHrmm1EmQLnr())
								{
									continue;
								}
								goto case 0;
							case 0:
								classifier.RaisePropertyChangedEvent(new PropertyChangedEventArgs(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(518)));
								num3 = 9;
								continue;
							case 10:
								goto IL_0164;
							case 5:
								goto IL_0177;
							case 3:
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									if (!eEaqZQ1xEx7JSuf3n5P())
									{
										continue;
									}
									goto case 6;
								}
								goto case 12;
							case 6:
								obj = vxlpCF1hrDPj5PaRSL6();
								goto IL_01b6;
							case 12:
								{
									awaiter.GetResult();
									goto end_IL_005b;
								}
								IL_01b6:
								awaiter = Tv7xda1Unwg3yndYiEo(obj);
								eEaqZQ1xEx7JSuf3n5P();
								num3 = ((!Y0Uygq1BHrmm1EmQLnr()) ? 1 : 8);
								continue;
							}
							break;
						}
						goto IL_00cb;
						IL_00cb:
						num2 = (_003C_003E1__state = 0);
						goto IL_0164;
						end_IL_005b:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
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
		internal static object vxlpCF1hrDPj5PaRSL6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Task.CompletedTask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Tv7xda1Unwg3yndYiEo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Y0Uygq1BHrmm1EmQLnr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eEaqZQ1xEx7JSuf3n5P()
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
	private struct _003CInitialize_003Ed__52 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
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
			goto IL_02b2;
			IL_001a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_02b2;
			IL_02b2:
			Classifier classifier = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					classifier = _003C_003E4__this;
					_ = 1;
					if (!ttu1jT1qA2h6yHW0nKD())
					{
						num = 1;
						continue;
					}
					num = 4;
					if (1 == 0)
					{
						return;
					}
					continue;
				case 0:
					num2 = _003C_003E1__state;
					num = 5;
					if (d3E6Uw1QbC8ExZL8eix())
					{
						continue;
					}
					goto case 1;
				case 1:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								_ = 0;
								num3 = ((!d3E6Uw1QbC8ExZL8eix()) ? 8 : 3);
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 7;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 15;
						}
						while (true)
						{
							switch (num3)
							{
							case 14:
								num2 = (_003C_003E1__state = 0);
								num3 = 10;
								continue;
							case 6:
							case 8:
								awaiter.GetResult();
								if (!classifier.LiveLabel)
								{
									num3 = 1;
									continue;
								}
								break;
							case 12:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								num3 = 9;
								continue;
							case 1:
								awaiter = AIMYNg1iTfj6OPDxr2C(classifier.NextImage());
								goto case 4;
							default:
								num3 = 4;
								continue;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 13;
								continue;
							case 16:
								return;
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 12;
									continue;
								}
								goto case 13;
							case 13:
								awaiter.GetResult();
								num3 = 17;
								continue;
							case 2:
								if (awaiter.IsCompleted)
								{
									goto case 6;
								}
								num3 = 14;
								if (!ttu1jT1qA2h6yHW0nKD())
								{
									continue;
								}
								goto case 0;
							case 0:
							case 3:
								awaiter = AIMYNg1iTfj6OPDxr2C(OperationProgressHelper.StartOperationIfNonePendingAndDoAsync(classifier.OperationProgressManager, classifier.InitializeInternal, (string)q4xnLS1VMjsQjIpfrrl()));
								num3 = 2;
								continue;
							case 9:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 16;
								continue;
							case 10:
								_003C_003Eu__1 = awaiter;
								num3 = 11;
								continue;
							case 7:
								_003C_003Eu__1 = default;
								num3 = 5;
								continue;
							case 15:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto case 6;
							case 11:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 17:
								break;
							}
							break;
						}
						classifier.RaisePropertyChangedEvent(new PropertyChangedEventArgs((string)hUtysl1LDKxIaFUkBCo(2308)));
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
		internal static object q4xnLS1VMjsQjIpfrrl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.Initializing;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter AIMYNg1iTfj6OPDxr2C(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hUtysl1LDKxIaFUkBCo(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool d3E6Uw1QbC8ExZL8eix()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ttu1jT1qA2h6yHW0nKD()
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
	private struct _003CInitializeInternal_003Ed__53 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0314;
			IL_001a:
			Classifier classifier = _003C_003E4__this;
			_ = 0;
			num = ((!ffvIPU1tjX816muyaaY()) ? 1 : 4);
			goto IL_0314;
			IL_0314:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 2:
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						switch (num2)
						{
						default:
							awaiter = VyYGJj1vliT0dWy2VK4(classifier.RefreshClasses());
							num3 = 8;
							if (1 == 0)
							{
								goto IL_0076;
							}
							goto IL_017c;
						case 0:
							awaiter = _003C_003Eu__1;
							ffvIPU1tjX816muyaaY();
							num3 = (rQMTnI192ice3320XAO() ? 1 : 20);
							goto IL_017c;
						case 1:
							awaiter = _003C_003Eu__1;
							num3 = 13;
							goto IL_017c;
						case 2:
							{
								awaiter = _003C_003Eu__1;
								num3 = 12;
								if (!rQMTnI192ice3320XAO())
								{
									goto IL_017c;
								}
								goto IL_029f;
							}
							IL_029f:
							num2 = (_003C_003E1__state = 1);
							num3 = 5;
							goto IL_017c;
							IL_0076:
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 16;
							goto IL_017c;
							IL_017c:
							while (true)
							{
								switch (num3)
								{
								case 11:
									break;
								case 8:
									if (!awaiter.IsCompleted)
									{
										num3 = 7;
										continue;
									}
									goto case 19;
								case 4:
								case 20:
									_003C_003Eu__1 = default;
									num3 = 2;
									continue;
								case 12:
									_003C_003Eu__1 = default;
									num3 = 18;
									if (true)
									{
										continue;
									}
									return;
								case 16:
									return;
								case 13:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_0114;
								case 17:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 10;
									continue;
								case 9:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 6;
									continue;
								case 5:
									_003C_003Eu__1 = awaiter;
									goto case 17;
								default:
									num3 = 17;
									if (ffvIPU1tjX816muyaaY())
									{
										continue;
									}
									goto case 19;
								case 19:
									awaiter.GetResult();
									num3 = 0;
									continue;
								case 10:
									return;
								case 18:
									num2 = (_003C_003E1__state = -1);
									num3 = 21;
									continue;
								case 2:
									num2 = (_003C_003E1__state = -1);
									num3 = 19;
									if (0 == 0)
									{
										continue;
									}
									goto case 7;
								case 7:
									num2 = (_003C_003E1__state = 0);
									num3 = 11;
									continue;
								case 3:
									if (!awaiter.IsCompleted)
									{
										goto case 1;
									}
									goto case 21;
								case 1:
								case 14:
									num2 = (_003C_003E1__state = 2);
									_003C_003Eu__1 = awaiter;
									num3 = 9;
									if (true)
									{
										continue;
									}
									return;
								case 6:
									return;
								case 15:
									goto IL_029f;
								case 0:
									awaiter = VyYGJj1vliT0dWy2VK4(classifier.RefreshUnlabeledImages());
									if (!awaiter.IsCompleted)
									{
										num3 = 15;
										continue;
									}
									goto IL_0114;
								case 21:
									{
										awaiter.GetResult();
										goto end_IL_004d;
									}
									IL_0114:
									awaiter.GetResult();
									awaiter = VyYGJj1vliT0dWy2VK4(classifier.RefreshLabeledImages());
									num3 = 3;
									if (0 == 0)
									{
										continue;
									}
									goto case 17;
								}
								break;
							}
							goto IL_0076;
							end_IL_004d:
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
				case 5:
					num2 = _003C_003E1__state;
					num = 0;
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
		internal static TaskAwaiter VyYGJj1vliT0dWy2VK4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ffvIPU1tjX816muyaaY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rQMTnI192ice3320XAO()
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
	private struct _003CRefreshModelHealth_003Ed__93 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		private TaskAwaiter<double> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (RFH3Gd10MZ5u45f34ia() ? 2 : 4);
			Classifier classifier = default;
			int num2 = default;
			double result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					classifier = _003C_003E4__this;
					num = 5;
					if (true)
					{
						continue;
					}
					goto case 5;
				case 5:
					try
					{
						TaskAwaiter<double> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = classifier.tFxs6dSMN.GetModelHealth().GetAwaiter();
							_ = 1;
							if (!RFH3Gd10MZ5u45f34ia())
							{
								num3 = 9;
								if (RFH3Gd10MZ5u45f34ia())
								{
									goto IL_006a;
								}
							}
							else
							{
								num3 = 4;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
							if (1 == 0)
							{
								goto IL_0132;
							}
						}
						goto IL_00b4;
						IL_0083:
						_003C_003Eu__1 = awaiter;
						num3 = 6;
						goto IL_00b4;
						IL_006a:
						num2 = (_003C_003E1__state = 0);
						goto IL_0083;
						IL_0132:
						result = awaiter.GetResult();
						num3 = 10;
						goto IL_00b4;
						IL_00b4:
						while (true)
						{
							switch (num3)
							{
							case 3:
								break;
							case 2:
							case 4:
								goto IL_0083;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 5;
								continue;
							case 0:
							case 9:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto IL_0132;
							case 8:
								return;
							case 5:
								goto IL_0132;
							case 7:
								_003C_003Eu__1 = default;
								num3 = 1;
								if (true)
								{
									continue;
								}
								goto case 10;
							case 10:
								classifier.ModelHealth = (int)(result * 100.0);
								goto end_IL_0037;
							}
							break;
						}
						goto IL_006a;
						end_IL_0037:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 1;
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
		internal static bool KHJDNf1ZYOciKvyQQFv()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RFH3Gd10MZ5u45f34ia()
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
	private struct _003CRefreshPredictedResult_003Ed__94 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		private TaskAwaiter<ELClassifyPredictedResult> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
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
			goto IL_024e;
			IL_001a:
			int num2 = _003C_003E1__state;
			hUmb8I1HvfyHmVfEvr7();
			num = ((!iYHB8L1OivA4ce3P3pE()) ? 4 : 0);
			goto IL_024e;
			IL_024e:
			Classifier classifier = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 5:
					try
					{
						TaskAwaiter<ELClassifyPredictedResult> awaiter;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00c3;
						}
						if (classifier.CurrentImageName != null && PqAnq31TPWwuAHFUhHH(classifier.CurrentImageName, nRHUj2QK9))
						{
							awaiter = classifier.tFxs6dSMN.GetPredictedResult(classifier.CurrentImageName).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_00c3;
						}
						goto end_IL_003b;
						IL_00c3:
						ELClassifyPredictedResult result = awaiter.GetResult();
						IEnumerator<ClassViewModel> enumerator = classifier.Classes.GetEnumerator();
						try
						{
							while (lDM6nv1pUsGi8QxODvP(enumerator))
							{
								ClassViewModel current = enumerator.Current;
								hUmb8I1HvfyHmVfEvr7();
								int num3;
								if (iYHB8L1OivA4ce3P3pE())
								{
									num3 = 6;
								}
								else
								{
									num3 = 3;
									if (!iYHB8L1OivA4ce3P3pE())
									{
										continue;
									}
								}
								while (true)
								{
									switch (num3)
									{
									case 1:
									case 3:
										if (pVgX4O1KL1gQCDcJZCv(KclLo01Y5j4U6W9a7iP(current), yvIa7y1J1dTFdH5d2hq(result)))
										{
											num3 = 8;
											continue;
										}
										goto IL_0152;
									case 2:
										current.PredictedScore = 0.0;
										num3 = 9;
										continue;
									case 8:
										fJUUkq1C7HrdsjAbXS1(current, true);
										num3 = 4;
										continue;
									case 7:
										fJUUkq1C7HrdsjAbXS1(current, false);
										num3 = 2;
										continue;
									case 4:
										AvQGDU1NQXpRhWu7GnT(current, anhfk01AyKuDkX1bBFX(result));
										break;
									default:
										num3 = 5;
										continue;
									case 0:
									case 6:
										if (result != null)
										{
											goto case 1;
										}
										goto IL_0152;
									case 5:
									case 9:
										break;
										IL_0152:
										if (j3qdTM1wsiNgMn3SBns(current))
										{
											num3 = 7;
											continue;
										}
										break;
									}
									break;
								}
							}
						}
						finally
						{
							if (num2 < 0 && enumerator != null)
							{
								XmUeqU1G1D5HTj1EqbX(enumerator);
							}
						}
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
				case 0:
				case 1:
					classifier = _003C_003E4__this;
					num = 5;
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
		internal static bool PqAnq31TPWwuAHFUhHH(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 != (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KclLo01Y5j4U6W9a7iP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassViewModel)P_0).ClassName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object yvIa7y1J1dTFdH5d2hq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELClassifyPredictedResult)P_0).Label;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pVgX4O1KL1gQCDcJZCv(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fJUUkq1C7HrdsjAbXS1(object P_0, bool value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ClassViewModel)P_0).IsPredicted = value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double anhfk01AyKuDkX1bBFX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ELClassifyPredictedResult)P_0).Score;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void AvQGDU1NQXpRhWu7GnT(object P_0, double value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ClassViewModel)P_0).PredictedScore = value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool j3qdTM1wsiNgMn3SBns(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassViewModel)P_0).IsPredicted;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lDM6nv1pUsGi8QxODvP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void XmUeqU1G1D5HTj1EqbX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iYHB8L1OivA4ce3P3pE()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hUmb8I1HvfyHmVfEvr7()
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
	private struct _003CRefreshNumImages_003Ed__95 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		private TaskAwaiter<string[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num;
			if (!RRrGu61jErq3vRjUZsh())
			{
				num = 2;
			}
			else
			{
				num = 5;
				if (!nkYioN1RXdqW5YMf7nO())
				{
					goto IL_0056;
				}
			}
			goto IL_0286;
			IL_0024:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_0286;
			IL_0056:
			Classifier classifier = default;
			int num2 = default;
			try
			{
				TaskAwaiter<string[]> awaiter;
				if (num2 != 0)
				{
					IEnumerator<ClassViewModel> enumerator = classifier.Classes.GetEnumerator();
					try
					{
						while (ufXxSP1WmYmBPTXAmfx(enumerator))
						{
							z20ZCA1IgX6npDUDPvp(enumerator.Current);
						}
					}
					finally
					{
						if (num2 < 0)
						{
							enumerator?.Dispose();
						}
					}
					enumerator = classifier.Classes.GetEnumerator();
					try
					{
						while (ufXxSP1WmYmBPTXAmfx(enumerator))
						{
							z20ZCA1IgX6npDUDPvp(enumerator.Current);
						}
					}
					finally
					{
						if (num2 < 0 && enumerator != null)
						{
							qkU6Tc1bfyg4WyPF4PO(enumerator);
						}
					}
					awaiter = classifier.HxYHPrlul().GetAwaiter();
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
				classifier.UnlabeledSampleCount = awaiter.GetResult()?.Length ?? 0;
				classifier.SampleCount = classifier.UnlabeledSampleCount + classifier.Classes.Select([MethodImpl(MethodImplOptions.NoInlining)] (ClassViewModel c) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return _003C_003Ec.oiGakQ1MOw249f8idkk(c);
				}).Sum();
				classifier.DoAutoTuneEnabled = false;
				if (classifier.Classes.Count >= 2)
				{
					IEnumerator<ClassViewModel> enumerator = classifier.Classes.GetEnumerator();
					try
					{
						while (ufXxSP1WmYmBPTXAmfx(enumerator))
						{
							if (qpwAgD1eJktVYg3MXXL(enumerator.Current) >= 2)
							{
								_ = 0;
								switch ((!nkYioN1RXdqW5YMf7nO()) ? 3 : 2)
								{
								case 0:
								case 2:
									classifier.DoAutoTuneEnabled = true;
									break;
								case 3:
									break;
								}
								break;
							}
						}
					}
					finally
					{
						if (num2 < 0 && enumerator != null)
						{
							qkU6Tc1bfyg4WyPF4PO(enumerator);
						}
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
			goto IL_0024;
			IL_0286:
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 3:
					goto IL_0056;
				default:
					num = 4;
					continue;
				case 1:
				case 5:
					classifier = _003C_003E4__this;
					num = 3;
					if (!RRrGu61jErq3vRjUZsh())
					{
						continue;
					}
					return;
				case 6:
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
		internal static void z20ZCA1IgX6npDUDPvp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ClassViewModel)P_0).NotifyImageCountChanged();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ufXxSP1WmYmBPTXAmfx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void qkU6Tc1bfyg4WyPF4PO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int qpwAgD1eJktVYg3MXXL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassViewModel)P_0).ImageCount;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nkYioN1RXdqW5YMf7nO()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RRrGu61jErq3vRjUZsh()
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
	private struct _003CNextImage_003Ed__96 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			UQ2Qy21lmmLFvIoXwyR();
			int num = (PBRiPu17bMtogU5Rc71() ? 2 : 5);
			Classifier classifier = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					classifier = _003C_003E4__this;
					num = 4;
					continue;
				case 4:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = GkRfd41n7n7yP92NWqE(OperationProgressHelper.StartOperationIfNonePendingAndDoAsync(classifier.OperationProgressManager, classifier.DvxhcaSGN, (string)VgcYdc1y9HJWYbKMeVB()));
							num3 = 7;
							if (false)
							{
								goto IL_006d;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 2;
							if (1 == 0)
							{
								goto IL_00e2;
							}
						}
						goto IL_008d;
						IL_006d:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						IL_00e2:
						num2 = (_003C_003E1__state = 0);
						num3 = 0;
						goto IL_008d;
						IL_008d:
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 3:
								break;
							default:
								return;
							case 8:
								return;
							case 6:
								goto IL_00e2;
							case 0:
								goto IL_00f5;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (true)
								{
									continue;
								}
								goto case 2;
							case 2:
								_003C_003Eu__1 = default;
								num3 = 5;
								if (0 == 0)
								{
									continue;
								}
								goto case 7;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								goto case 9;
							case 9:
								awaiter.GetResult();
								goto end_IL_0039;
							}
							break;
							IL_00f5:
							_003C_003Eu__1 = awaiter;
							_ = 1;
							num3 = ((!PBRiPu17bMtogU5Rc71()) ? 1 : 8);
						}
						goto IL_006d;
						end_IL_0039:;
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
					if (UQ2Qy21lmmLFvIoXwyR())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					goto case 1;
				case 3:
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
		internal static object VgcYdc1y9HJWYbKMeVB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.LoadingNextImage;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter GkRfd41n7n7yP92NWqE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UQ2Qy21lmmLFvIoXwyR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PBRiPu17bMtogU5Rc71()
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
	private struct _003CNextImage_Internal_003Ed__97 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		private TaskAwaiter<BitmapImage> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			Classifier classifier = default;
			TaskAwaiter<string> awaiter2 = default;
			TaskAwaiter<BitmapImage> awaiter3 = default;
			TaskAwaiter awaiter = default;
			BitmapImage result = default;
			string result2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							if (classifier.LiveLabel)
							{
								num3 = 25;
							}
							else
							{
								awaiter2 = classifier.tFxs6dSMN.GetNextImageToLabel().GetAwaiter();
								if (awaiter2.IsCompleted)
								{
									goto IL_0159;
								}
								ktewVH1zbFVBUDG9HI3();
								num3 = ((!B4qIKF1fvkovHZ6w0AL()) ? 23 : 22);
							}
							goto IL_0320;
						case 2:
							awaiter3 = _003C_003Eu__3;
							num3 = 1;
							goto IL_0320;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 17;
							goto IL_0320;
						case 1:
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num3 = 11;
							goto IL_0320;
						case 3:
							{
								awaiter = _003C_003Eu__1;
								num3 = 10;
								goto IL_0320;
							}
							IL_0320:
							while (true)
							{
								switch (num3)
								{
								case 16:
									classifier.SetImage(result);
									num3 = 12;
									continue;
								case 12:
								case 29:
									awaiter = RYjj3HS2gkhodKiLhNH(classifier.IRgNWRx4r());
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 3);
										num3 = 6;
										continue;
									}
									goto case 31;
								case 1:
									_003C_003Eu__3 = default;
									num3 = 4;
									continue;
								case 9:
								case 23:
									_003C_003Eu__2 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num3 = 24;
									if (true)
									{
										continue;
									}
									goto case 12;
								case 21:
									result = awaiter3.GetResult();
									num3 = 3;
									continue;
								case 18:
									awaiter.GetResult();
									num3 = 27;
									if (true)
									{
										continue;
									}
									goto case 7;
								case 7:
									awaiter = classifier.lDbwiFefS().GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num3 = 20;
										continue;
									}
									goto case 18;
								case 30:
									return;
								case 25:
									if (classifier.lDbwiFefS != null)
									{
										num3 = 7;
										continue;
									}
									goto end_IL_0320;
								case 11:
									num2 = (_003C_003E1__state = -1);
									num3 = 28;
									if (true)
									{
										continue;
									}
									break;
								case 28:
									break;
								case 10:
									_003C_003Eu__1 = default;
									num3 = 15;
									continue;
								case 20:
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 26;
									if (ktewVH1zbFVBUDG9HI3())
									{
									}
									continue;
								case 17:
									_003C_003Eu__1 = default;
									num3 = 2;
									if (!ktewVH1zbFVBUDG9HI3())
									{
										continue;
									}
									goto case 5;
								case 5:
									num2 = (_003C_003E1__state = 2);
									_003C_003Eu__3 = awaiter3;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num3 = 30;
									if (true)
									{
										continue;
									}
									return;
								case 26:
									return;
								case 6:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 13;
									continue;
								case 27:
									goto end_IL_0320;
								case 24:
									return;
								case 14:
									classifier.CurrentImageName = result2;
									num3 = 0;
									continue;
								case 15:
									num2 = (_003C_003E1__state = -1);
									num3 = 31;
									continue;
								case 8:
								case 22:
									num2 = (_003C_003E1__state = 1);
									goto case 9;
								case 4:
									num2 = (_003C_003E1__state = -1);
									num3 = 21;
									continue;
								case 2:
									num2 = (_003C_003E1__state = -1);
									num3 = 18;
									if (true)
									{
										continue;
									}
									goto case 0;
								case 0:
									awaiter3 = classifier.tFxs6dSMN.GetBitmap(classifier.CurrentImageName).GetAwaiter();
									goto case 19;
								default:
									num3 = 19;
									continue;
								case 3:
									if (result == null)
									{
										classifier.d1OVvbmBc();
										num3 = 29;
									}
									else
									{
										num3 = 16;
									}
									continue;
								case 19:
									if (!awaiter3.IsCompleted)
									{
										num3 = 5;
										if (B4qIKF1fvkovHZ6w0AL())
										{
											continue;
										}
										return;
									}
									goto case 21;
								case 13:
									return;
								case 31:
									awaiter.GetResult();
									goto end_IL_0320;
								}
								goto IL_0159;
								continue;
								end_IL_0320:
								break;
							}
							break;
							IL_0159:
							result2 = awaiter2.GetResult();
							num3 = 14;
							goto IL_0320;
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
				case 0:
					do
					{
						num2 = _003C_003E1__state;
						_ = 0;
						if (!B4qIKF1fvkovHZ6w0AL())
						{
							num = 4;
							continue;
						}
						num = 5;
						break;
					}
					while (!B4qIKF1fvkovHZ6w0AL());
					continue;
				case 1:
				case 5:
					classifier = _003C_003E4__this;
					num = 2;
					if (0 == 0)
					{
						continue;
					}
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
		internal static TaskAwaiter RYjj3HS2gkhodKiLhNH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool B4qIKF1fvkovHZ6w0AL()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ktewVH1zbFVBUDG9HI3()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass104_0
	{
		public string className;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass104_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			yXV9akSk477Qw7G5Wf2();
			b1IwwZSmQIvtOUEusJe(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CAddClass_003Eb__0(ClassViewModel x)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return aMHavsSPmZYuue1vZnQ(Kn3sS9Srl0Ya1MR2NOZ(x), className);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yXV9akSk477Qw7G5Wf2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void b1IwwZSmQIvtOUEusJe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rZWRJESXSmDQMqSyoPt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yrFbA8SMyRryj520Ftp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Kn3sS9Srl0Ya1MR2NOZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassViewModel)P_0).ClassName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aMHavsSPmZYuue1vZnQ(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddClass_003Ed__104 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string className;

		public Classifier _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			c1D0QrSgiuQgw4rFeFh();
			int num = ((!nPgyHOS45V1RMpr3i3L()) ? 5 : 3);
			int num2 = default;
			TaskAwaiter awaiter = default;
			_003C_003Ec__DisplayClass104_0 obj = default;
			Classifier classifier = default;
			UndoAddClass undoAddClass = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 5:
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
								num3 = 10;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 19;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								obj.className = className;
								num3 = 7;
								continue;
							case 9:
								awaiter.GetResult();
								goto end_IL_0144;
							case 13:
								goto end_IL_0144;
							case 8:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (nPgyHOS45V1RMpr3i3L())
								{
									continue;
								}
								goto end_IL_0144;
							case 3:
							case 17:
								goto end_IL_0144;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 20;
								continue;
							case 11:
								awaiter = NcH7etS6dqSOMPlShpt(HurLU2SSIMxqSWaQipZ(XjT1e7S1M1AkQ9jKIGU(classifier.xkMbRK87y), undoAddClass));
								num3 = 0;
								continue;
							case 0:
								if (awaiter.IsCompleted)
								{
									goto case 9;
								}
								num3 = 2;
								if (!c1D0QrSgiuQgw4rFeFh())
								{
									continue;
								}
								goto case 15;
							case 15:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								continue;
							case 6:
								_003C_003Eu__1 = awaiter;
								goto case 14;
							default:
								num3 = 14;
								continue;
							case 19:
								_003C_003Eu__1 = default;
								num3 = 8;
								if (nPgyHOS45V1RMpr3i3L())
								{
									continue;
								}
								goto case 7;
							case 7:
								if (!string.IsNullOrEmpty(obj.className))
								{
									if (classifier.Classes.SingleOrDefault(obj._003CAddClass_003Eb__0) != null)
									{
										num3 = 18;
										continue;
									}
									if (classifier.pLu4jtXb7 != null)
									{
										undoAddClass = new UndoAddClass(classifier.xkMbRK87y, classifier.pLu4jtXb7, obj.className);
										num3 = 11;
										if (true)
										{
											continue;
										}
										goto end_IL_0144;
									}
									awaiter = NcH7etS6dqSOMPlShpt(classifier._AddClass(obj.className));
									if (!awaiter.IsCompleted)
									{
										num3 = 15;
										continue;
									}
									break;
								}
								_ = 0;
								num3 = (nPgyHOS45V1RMpr3i3L() ? 17 : 16);
								continue;
							case 18:
								goto end_IL_0144;
							case 16:
								goto end_IL_0144;
							case 10:
								_003C_003Eu__1 = default;
								num3 = 4;
								continue;
							case 2:
								num2 = (_003C_003E1__state = 0);
								num3 = 6;
								if (c1D0QrSgiuQgw4rFeFh())
								{
								}
								continue;
							case 5:
								return;
							case 12:
								obj = new _003C_003Ec__DisplayClass104_0();
								num3 = 1;
								if (0 == 0)
								{
									continue;
								}
								goto case 14;
							case 14:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 20:
								break;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_0144:
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
					goto case 4;
				default:
					num = 4;
					break;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					num = 1;
					break;
				case 1:
					classifier = _003C_003E4__this;
					goto case 2;
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
		internal static object XjT1e7S1M1AkQ9jKIGU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HurLU2SSIMxqSWaQipZ(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter NcH7etS6dqSOMPlShpt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nPgyHOS45V1RMpr3i3L()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool c1D0QrSgiuQgw4rFeFh()
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
	private struct _003C_AddClass_003Ed__105 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		public string className;

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
			if (agYo8WSDLrPWyCcin29())
			{
				num = 2;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 5;
			}
			goto IL_025d;
			IL_029f:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_025d;
			IL_025d:
			Classifier classifier = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				case 4:
					classifier = _003C_003E4__this;
					num = 1;
					continue;
				default:
					goto IL_029f;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 4;
					if (!bYmX8RS84tbuu4sselo())
					{
						continue;
					}
					return;
				case 6:
					return;
				}
				break;
			}
			goto IL_0026;
			IL_0026:
			try
			{
				int num3;
				TaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					if (num2 != 1)
					{
						num3 = 15;
					}
					else
					{
						awaiter = _003C_003Eu__1;
						num3 = 2;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num3 = 8;
				}
				while (true)
				{
					switch (num3)
					{
					case 7:
						num2 = (_003C_003E1__state = 1);
						_ = 1;
						num3 = (bYmX8RS84tbuu4sselo() ? 1 : 4);
						continue;
					case 6:
						awaiter = FFSt9kSsKbdkpICO3LD(classifier.RefreshClasses());
						if (!awaiter.IsCompleted)
						{
							num3 = 7;
							continue;
						}
						goto case 5;
					case 3:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 13;
						if (bYmX8RS84tbuu4sselo())
						{
						}
						continue;
					case 11:
						num2 = (_003C_003E1__state = 0);
						num3 = 14;
						continue;
					case 0:
						if (!awaiter.IsCompleted)
						{
							num3 = 11;
							continue;
						}
						goto IL_010d;
					case 14:
						_003C_003Eu__1 = awaiter;
						num3 = 3;
						continue;
					case 5:
						awaiter.GetResult();
						num3 = 16;
						if (agYo8WSDLrPWyCcin29())
						{
							continue;
						}
						goto case 1;
					case 1:
					case 12:
						num2 = (_003C_003E1__state = -1);
						num3 = 5;
						continue;
					case 8:
						num2 = (_003C_003E1__state = -1);
						goto IL_010d;
					default:
						num3 = 6;
						continue;
					case 10:
						return;
					case 13:
						return;
					case 4:
					case 9:
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 10;
						if (0 == 0)
						{
							continue;
						}
						goto case 2;
					case 2:
						_003C_003Eu__1 = default;
						goto case 1;
					case 15:
						awaiter = FFSt9kSsKbdkpICO3LD(L60oEWSFqJHU4jrNZQT(classifier.tFxs6dSMN, className));
						num3 = 0;
						continue;
					case 16:
						{
							avdOrdSERkBkVqvVr3S(classifier, new PropertyChangedEventArgs((string)MXsQD8SdXL3GhfRu4wW(518)));
							break;
						}
						IL_010d:
						awaiter.GetResult();
						goto case 6;
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
			goto IL_029f;
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
		internal static object L60oEWSFqJHU4jrNZQT(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IViDiELClassifyService)P_0).AddClass((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter FFSt9kSsKbdkpICO3LD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MXsQD8SdXL3GhfRu4wW(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void avdOrdSERkBkVqvVr3S(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((BasePropertyChanged)P_0).RaisePropertyChangedEvent((PropertyChangedEventArgs)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool agYo8WSDLrPWyCcin29()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bYmX8RS84tbuu4sselo()
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
	private struct _003CConfirmClassDelete_003Ed__109 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public string itemClass;

		private TaskAwaiter<bool> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			int num2 = default;
			Cognex.Foundations.Mvvm.Common.YesNoPromptViewModel viewModel = default;
			TaskAwaiter<bool> awaiter = default;
			bool result = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					try
					{
						int num3;
						if (num2 != 0)
						{
							Cognex.Foundations.Mvvm.Common.YesNoPromptViewModel yesNoPromptViewModel = new Cognex.Foundations.Mvvm.Common.YesNoPromptViewModel();
							NmWg9CSoSNFw3Dktvim(yesNoPromptViewModel, hDB9JuSa1ojTLIKOxyu());
							WSkfq8SumpQXnY3S7oE(yesNoPromptViewModel, string.Format((string)tMydEyScKKqc0onv8dt(), itemClass));
							viewModel = yesNoPromptViewModel;
							_ = 0;
							if (Y9gHXIS5FqoK9TbGubk())
							{
								num3 = 8;
								if (1 == 0)
								{
									return;
								}
							}
							else
							{
								num3 = 5;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 6;
						}
						while (true)
						{
							switch (num3)
							{
							case 9:
								return;
							case 5:
							case 7:
								num2 = (_003C_003E1__state = -1);
								num3 = 10;
								continue;
							case 6:
								_003C_003Eu__1 = default;
								goto case 5;
							case 0:
							case 8:
								awaiter = ViewModelBroadcaster.Default.Broadcast(null, viewModel).GetAwaiter();
								num3 = 1;
								continue;
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 9;
								continue;
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								continue;
							case 2:
								_003C_003Eu__1 = awaiter;
								goto case 4;
							default:
								num3 = 4;
								if (0 == 0)
								{
									continue;
								}
								goto case 1;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								break;
							case 10:
								break;
							}
							break;
						}
						result = awaiter.GetResult();
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
					num = 5;
					break;
				case 4:
					num2 = _003C_003E1__state;
					Y9gHXIS5FqoK9TbGubk();
					if (BAI4HPS3vPj1uGJlHQO())
					{
						num = 0;
						if (Y9gHXIS5FqoK9TbGubk())
						{
							break;
						}
						goto default;
					}
					num = 3;
					break;
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
		internal static object hDB9JuSa1ojTLIKOxyu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.DeleteClass;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NmWg9CSoSNFw3Dktvim(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Cognex.Foundations.Mvvm.Common.BaseMessageViewModel)P_0).Heading = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tMydEyScKKqc0onv8dt()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.DeleteClassMessage;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WSkfq8SumpQXnY3S7oE(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Cognex.Foundations.Mvvm.Common.BaseMessageViewModel)P_0).Message = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Y9gHXIS5FqoK9TbGubk()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BAI4HPS3vPj1uGJlHQO()
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
	private struct _003CDoDeleteClass_003Ed__110 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public object param;

		public Classifier _003C_003E4__this;

		public Func<string, Task<bool>> confirmationCallback;

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
			TaskAwaiter awaiter = default;
			Classifier classifier = default;
			UndoRemoveClass undoRemoveClass = default;
			ClassViewModel classViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 14;
								if (false)
								{
									goto IL_0031;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 10;
								if (!ylpq2hSBKI4kseYt4ep())
								{
									goto IL_0198;
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 11;
							if (!ylpq2hSBKI4kseYt4ep())
							{
								goto IL_027a;
							}
						}
						goto IL_01b3;
						IL_0198:
						num2 = (_003C_003E1__state = -1);
						goto IL_0074;
						IL_0074:
						awaiter.GetResult();
						num3 = 7;
						if (false)
						{
							goto IL_0087;
						}
						goto IL_01b3;
						IL_00be:
						_003C_003Eu__1 = default;
						num3 = 5;
						goto IL_01b3;
						IL_027a:
						awaiter.GetResult();
						goto end_IL_0018;
						IL_0031:
						awaiter = ((Task)inE9YfSUKi2ATqVogrK(iAlC1EShc7hGkNgiPlV(classifier.xkMbRK87y), undoRemoveClass)).GetAwaiter();
						num3 = 4;
						goto IL_01b3;
						IL_01b3:
						while (true)
						{
							switch (num3)
							{
							case 17:
								break;
							case 1:
							case 12:
								if (classViewModel != null)
								{
									if (classifier.pLu4jtXb7 != null)
									{
										goto case 2;
									}
									awaiter = E28vZBSQJkUbR7qgmVd(classifier._DoDeleteClass(classViewModel, confirmationCallback));
									num3 = 8;
									if (XwI1STSxaF31nLcyLv1())
									{
									}
									continue;
								}
								goto end_IL_0018;
							case 9:
								goto IL_0074;
							case 15:
								goto IL_0087;
							case 6:
								goto IL_00a9;
							case 10:
								goto IL_00be;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
								continue;
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 0;
									continue;
								}
								goto IL_0074;
							case 0:
								num2 = (_003C_003E1__state = 0);
								num3 = 16;
								continue;
							case 2:
							case 13:
								undoRemoveClass = new UndoRemoveClass(classifier.xkMbRK87y, classifier.pLu4jtXb7, classViewModel, confirmationCallback);
								num3 = 17;
								if (XwI1STSxaF31nLcyLv1())
								{
								}
								continue;
							case 14:
								goto IL_013d;
							case 8:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									if (ylpq2hSBKI4kseYt4ep())
									{
										continue;
									}
									return;
								}
								goto IL_027a;
							case 3:
								return;
							case 11:
								goto IL_0198;
							default:
								num3 = 9;
								continue;
							case 7:
								goto end_IL_0018;
							case 16:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 18:
								goto IL_027a;
							}
							break;
							IL_013d:
							classViewModel = param as ClassViewModel;
							_ = 0;
							num3 = (ylpq2hSBKI4kseYt4ep() ? 12 : 13);
						}
						goto IL_0031;
						IL_00a9:
						num2 = (_003C_003E1__state = 1);
						num3 = 15;
						if (1 == 0)
						{
							goto IL_00be;
						}
						goto IL_01b3;
						IL_0087:
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 3;
						if (false)
						{
							goto IL_00a9;
						}
						goto IL_01b3;
						end_IL_0018:;
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
					continue;
				case 0:
				case 1:
					classifier = _003C_003E4__this;
					num = 2;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 4:
					break;
				case 6:
					return;
				}
				num2 = _003C_003E1__state;
				_ = 1;
				if (XwI1STSxaF31nLcyLv1())
				{
					num = 5;
					continue;
				}
				num = 0;
				if (!ylpq2hSBKI4kseYt4ep())
				{
					break;
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
		internal static object iAlC1EShc7hGkNgiPlV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object inE9YfSUKi2ATqVogrK(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter E28vZBSQJkUbR7qgmVd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ylpq2hSBKI4kseYt4ep()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XwI1STSxaF31nLcyLv1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass111_0
	{
		public ClassViewModel item;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass111_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			r2ImfkSiBw39XEmigfg();
			W5OjWvSL9UKentlPiCg(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003C_DoDeleteClass_003Eb__0(ClassifyImage img)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CIP2w9Sv1uutoKmTLpu(KnglheStQm71988iUSt(img), ljyuqwS9ZhHBXEcBiFm(item));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void r2ImfkSiBw39XEmigfg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void W5OjWvSL9UKentlPiCg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GNixkPSqgbs3vuIF5Du()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Sv9YY8SVOruGmlNyKDD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KnglheStQm71988iUSt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassifyImage)P_0).Label;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ljyuqwS9ZhHBXEcBiFm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassViewModel)P_0).ClassName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CIP2w9Sv1uutoKmTLpu(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_DoDeleteClass_003Ed__111 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ClassViewModel item;

		public Func<string, Task<bool>> confirmationCallback;

		public Classifier _003C_003E4__this;

		private _003C_003Ec__DisplayClass111_0 _003C_003E8__1;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private ITopLevelProgressableOperation _003Coperation_003E5__2;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			if (!Pud9XDSZPa6fxJctKep())
			{
				goto IL_001e;
			}
			goto IL_050d;
			IL_001e:
			Classifier classifier = _003C_003E4__this;
			num = 0;
			if (wkcKwTS0ZDMv6U5BI4X())
			{
			}
			goto IL_050d;
			IL_050d:
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 1:
				case 4:
					_003C_003Et__builder.SetResult();
					num = 7;
					continue;
				case 3:
				case 5:
					_003C_003E8__1 = null;
					goto case 1;
				case 6:
					num2 = _003C_003E1__state;
					num = 2;
					continue;
				case 0:
					try
					{
						bool flag;
						TaskAwaiter<bool> awaiter;
						if (num2 != 0)
						{
							if ((uint)(num2 - 1) <= 5u)
							{
								goto IL_016f;
							}
							_003C_003E8__1 = new _003C_003Ec__DisplayClass111_0();
							_003C_003E8__1.item = item;
							flag = gHyrLRSOLLkVVfgaeFl(_003C_003E8__1.item) == 0 || confirmationCallback == null;
							if (flag)
							{
								goto IL_0140;
							}
							awaiter = confirmationCallback((string)IDMtikSHTDJcmwDkQNn(_003C_003E8__1.item)).GetAwaiter();
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
						flag = awaiter.GetResult();
						goto IL_0140;
						IL_016f:
						try
						{
							TaskAwaiter awaiter2;
							List<ClassifyImage>.Enumerator enumerator;
							switch (num2)
							{
							default:
								awaiter2 = vOCX2JSKrwrBYXX4VYQ(BL1W7pSJeLJvXyEZUqb(classifier.ClassifyService, _003C_003E8__1.item.ClassName));
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_01fe;
							case 1:
								awaiter2 = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_01fe;
							case 2:
								awaiter2 = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0316;
							case 3:
								awaiter2 = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0377;
							case 4:
								awaiter2 = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_03d8;
							case 5:
								awaiter2 = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0439;
							case 6:
								{
									awaiter2 = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									break;
								}
								IL_03d8:
								awaiter2.GetResult();
								awaiter2 = vOCX2JSKrwrBYXX4VYQ(classifier.RefreshUnlabeledImagePredictions());
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 5);
									_003C_003Eu__2 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_0439;
								IL_01fe:
								awaiter2.GetResult();
								enumerator = classifier.LabeledImages.Where([MethodImpl(MethodImplOptions.NoInlining)] (ClassifyImage img) =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									return _003C_003Ec__DisplayClass111_0.CIP2w9Sv1uutoKmTLpu(_003C_003Ec__DisplayClass111_0.KnglheStQm71988iUSt(img), _003C_003Ec__DisplayClass111_0.ljyuqwS9ZhHBXEcBiFm(_003C_003E8__1.item));
								}).ToList().GetEnumerator();
								try
								{
									while (enumerator.MoveNext())
									{
										ClassifyImage current = enumerator.Current;
										_ = 1;
										switch (wkcKwTS0ZDMv6U5BI4X() ? 3 : 2)
										{
										case 0:
										case 2:
											classifier.LabeledImages.Remove(current);
											break;
										}
									}
								}
								finally
								{
									if (num2 < 0)
									{
										((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
									}
								}
								awaiter2 = vOCX2JSKrwrBYXX4VYQ(classifier.RefreshClasses());
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 2);
									_003C_003Eu__2 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_0316;
								IL_0377:
								awaiter2.GetResult();
								awaiter2 = vOCX2JSKrwrBYXX4VYQ(classifier.RefreshUnlabeledImages());
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 4);
									_003C_003Eu__2 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_03d8;
								IL_0439:
								awaiter2.GetResult();
								awaiter2 = classifier.RefreshLabeledImagePredictions().GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 6);
									_003C_003Eu__2 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								break;
								IL_0316:
								awaiter2.GetResult();
								awaiter2 = vOCX2JSKrwrBYXX4VYQ(classifier.RefreshLabeledImages());
								if (!awaiter2.IsCompleted)
								{
									num2 = (_003C_003E1__state = 3);
									_003C_003Eu__2 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_0377;
							}
							awaiter2.GetResult();
						}
						finally
						{
							if (num2 < 0 && _003Coperation_003E5__2 != null)
							{
								bZou4sSCD0tegAIx4oi(_003Coperation_003E5__2);
							}
						}
						_003Coperation_003E5__2 = null;
						goto end_IL_0076;
						IL_0140:
						if (flag)
						{
							IOperationProgressManager operationProgressManager = classifier.OperationProgressManager;
							_003Coperation_003E5__2 = (ITopLevelProgressableOperation)((operationProgressManager != null) ? nZo47vSY963CoKfZHGm(operationProgressManager, MyjYXbSTMR9yPC3JCew(), Array.Empty<StepDescriptor>()) : null);
							goto IL_016f;
						}
						end_IL_0076:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003E8__1 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				default:
					Pud9XDSZPa6fxJctKep();
					if (wkcKwTS0ZDMv6U5BI4X())
					{
						num = 1;
						continue;
					}
					num = 5;
					if (false)
					{
						return;
					}
					continue;
				case 7:
					return;
				}
				break;
			}
			goto IL_001e;
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
		internal static int gHyrLRSOLLkVVfgaeFl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassViewModel)P_0).AllImageCount;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IDMtikSHTDJcmwDkQNn(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassViewModel)P_0).ClassName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MyjYXbSTMR9yPC3JCew()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.DeletingClass;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nZo47vSY963CoKfZHGm(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).StartBlockingOperation((string)P_1, (StepDescriptor[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BL1W7pSJeLJvXyEZUqb(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IViDiELClassifyService)P_0).RemoveClassLabel((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter vOCX2JSKrwrBYXX4VYQ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void bZou4sSCD0tegAIx4oi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Pud9XDSZPa6fxJctKep()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wkcKwTS0ZDMv6U5BI4X()
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
	private struct _003CRenameClass_003Ed__112 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		public string oldClassName;

		public string newClassName;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!dJKMpQSAEaiEW6l4oqD()) ? 2 : 3);
			Classifier classifier = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			UndoRenameClass action = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 2:
					classifier = _003C_003E4__this;
					num = 4;
					if (true)
					{
						break;
					}
					goto case 0;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 5;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 9;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 13;
						}
						while (true)
						{
							switch (num3)
							{
							case 5:
								if (classifier.pLu4jtXb7 != null)
								{
									action = new UndoRenameClass(classifier.pLu4jtXb7, oldClassName, newClassName);
									num3 = 16;
									continue;
								}
								awaiter = Y1rOafSpLH9olrMvoi1(classifier.vWIlFv0oG(oldClassName, newClassName));
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 12;
									continue;
								}
								break;
							case 11:
							case 15:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								if (true)
								{
									continue;
								}
								goto case 14;
							case 14:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 7;
								continue;
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 17;
								if (!vt6cHLSN03uNuUr2IRL())
								{
									continue;
								}
								goto case 16;
							case 16:
								awaiter = Y1rOafSpLH9olrMvoi1(((UndoRedoQueue)GNI3Q9Sw0srRXZRAk7M(classifier.xkMbRK87y)).AddUndo((IUndoAction)action));
								num3 = 10;
								continue;
							case 0:
								goto end_IL_019d;
							case 7:
								return;
							case 4:
								num2 = (_003C_003E1__state = -1);
								goto IL_016e;
							case 13:
								_003C_003Eu__1 = default;
								goto case 4;
							default:
								num3 = 4;
								if (!vt6cHLSN03uNuUr2IRL())
								{
									continue;
								}
								goto case 10;
							case 10:
								if (!awaiter.IsCompleted)
								{
									vt6cHLSN03uNuUr2IRL();
									num3 = (dJKMpQSAEaiEW6l4oqD() ? 1 : 15);
									continue;
								}
								goto IL_016e;
							case 12:
								_003C_003Eu__1 = awaiter;
								goto case 11;
							case 1:
							case 3:
								num2 = (_003C_003E1__state = 0);
								num3 = 2;
								if (0 == 0)
								{
									continue;
								}
								goto case 9;
							case 9:
								_003C_003Eu__1 = default;
								num3 = 6;
								continue;
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 14;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 8:
								return;
							case 17:
								break;
								IL_016e:
								awaiter.GetResult();
								num3 = 0;
								continue;
							}
							awaiter.GetResult();
							break;
							continue;
							end_IL_019d:
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
					goto case 5;
				default:
					num = 5;
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
		internal static object GNI3Q9Sw0srRXZRAk7M(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Y1rOafSpLH9olrMvoi1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dJKMpQSAEaiEW6l4oqD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vt6cHLSN03uNuUr2IRL()
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
	private struct _003C_RenameClass_003Ed__113 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string oldClassName;

		public string newClassName;

		public Classifier _003C_003E4__this;

		private ITopLevelProgressableOperation _003Coperation_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			eVIbkdSRhyJCitUjLOs();
			int num = ((!gD434bSG8LLQqbGyXCS()) ? 3 : 4);
			int num2 = default;
			Classifier classifier = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 3:
					break;
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					if (gD434bSG8LLQqbGyXCS())
					{
						continue;
					}
					goto case 2;
				case 2:
					try
					{
						if ((uint)num2 <= 3u)
						{
							goto IL_009a;
						}
						if (!oldClassName.Equals(newClassName))
						{
							IOperationProgressManager operationProgressManager = classifier.OperationProgressManager;
							_003Coperation_003E5__2 = (ITopLevelProgressableOperation)((operationProgressManager != null) ? C7tLwkSIwj1CIEgKvFv(operationProgressManager, ECNinOSjhJmvtIUPkxX(), Array.Empty<StepDescriptor>()) : null);
							goto IL_009a;
						}
						goto end_IL_0054;
						IL_009a:
						try
						{
							TaskAwaiter awaiter;
							int num3;
							switch (num2)
							{
							default:
								awaiter = onI678SbZEv45ThAkW8(nnBDSoSWkTS4jAPdJOV(classifier.ClassifyService, oldClassName, newClassName));
								num3 = 22;
								break;
							case 2:
								awaiter = _003C_003Eu__1;
								num3 = 15;
								break;
							case 0:
								awaiter = _003C_003Eu__1;
								num3 = 6;
								break;
							case 3:
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 27;
								if (false)
								{
									return;
								}
								break;
							case 1:
								awaiter = _003C_003Eu__1;
								num3 = 12;
								break;
							}
							while (true)
							{
								switch (num3)
								{
								case 14:
									return;
								case 2:
								case 5:
									return;
								case 20:
									num2 = (_003C_003E1__state = 2);
									_003C_003Eu__1 = awaiter;
									num3 = 24;
									continue;
								case 0:
									return;
								case 10:
									return;
								case 21:
									num2 = (_003C_003E1__state = 1);
									goto case 9;
								case 16:
									awaiter.GetResult();
									num3 = 17;
									if (true)
									{
										continue;
									}
									goto case 26;
								case 26:
									num2 = (_003C_003E1__state = -1);
									num3 = 16;
									continue;
								case 23:
									if (!awaiter.IsCompleted)
									{
										num3 = 21;
										continue;
									}
									goto case 25;
								case 22:
									if (awaiter.IsCompleted)
									{
										goto case 16;
									}
									num3 = 18;
									if (!eVIbkdSRhyJCitUjLOs())
									{
										continue;
									}
									goto case 25;
								case 25:
									awaiter.GetResult();
									num3 = 8;
									continue;
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 10;
									if (gD434bSG8LLQqbGyXCS())
									{
										continue;
									}
									goto case 4;
								case 4:
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 0;
									continue;
								case 6:
									_003C_003Eu__1 = default;
									num3 = 26;
									if (gD434bSG8LLQqbGyXCS())
									{
										continue;
									}
									goto case 13;
								case 13:
									awaiter = onI678SbZEv45ThAkW8(classifier.RefreshLabeledImagePredictions());
									if (awaiter.IsCompleted)
									{
										break;
									}
									num3 = 19;
									if (true)
									{
										continue;
									}
									goto case 12;
								case 12:
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									goto case 25;
								default:
									num3 = 25;
									continue;
								case 18:
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									_ = 1;
									if (eVIbkdSRhyJCitUjLOs())
									{
										num3 = 11;
										if (gD434bSG8LLQqbGyXCS())
										{
											continue;
										}
										goto case 16;
									}
									num3 = 5;
									continue;
								case 19:
									num2 = (_003C_003E1__state = 3);
									num3 = 4;
									continue;
								case 7:
									num2 = (_003C_003E1__state = -1);
									num3 = 1;
									continue;
								case 9:
								case 11:
									_003C_003Eu__1 = awaiter;
									num3 = 3;
									continue;
								case 17:
									awaiter = onI678SbZEv45ThAkW8(classifier.RefreshClasses());
									num3 = 23;
									if (eVIbkdSRhyJCitUjLOs())
									{
									}
									continue;
								case 8:
									awaiter = onI678SbZEv45ThAkW8(classifier.RefreshUnlabeledImagePredictions());
									if (!awaiter.IsCompleted)
									{
										num3 = 20;
										continue;
									}
									goto case 1;
								case 24:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 14;
									if (gD434bSG8LLQqbGyXCS())
									{
										continue;
									}
									goto case 1;
								case 1:
									awaiter.GetResult();
									num3 = 13;
									continue;
								case 15:
									_003C_003Eu__1 = default;
									num3 = 7;
									if (0 == 0)
									{
										continue;
									}
									break;
								case 27:
									break;
								}
								break;
							}
							awaiter.GetResult();
						}
						finally
						{
							if (num2 < 0 && _003Coperation_003E5__2 != null)
							{
								jgLmRdSemaD1LxywjdP(_003Coperation_003E5__2);
							}
						}
						_003Coperation_003E5__2 = null;
						end_IL_0054:;
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
					if (gD434bSG8LLQqbGyXCS())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					break;
				case 6:
					return;
				}
				classifier = _003C_003E4__this;
				num = 2;
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
		internal static object ECNinOSjhJmvtIUPkxX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.RenamingClass;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object C7tLwkSIwj1CIEgKvFv(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).StartBlockingOperation((string)P_1, (StepDescriptor[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nnBDSoSWkTS4jAPdJOV(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IViDiELClassifyService)P_0).RenameClass((string)P_1, (string)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter onI678SbZEv45ThAkW8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jgLmRdSemaD1LxywjdP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool gD434bSG8LLQqbGyXCS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eVIbkdSRhyJCitUjLOs()
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
	private struct _003CLabelCurrentImage_003Ed__114 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		public ClassViewModel classViewModel;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
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
			goto IL_02c3;
			IL_001a:
			int num2 = _003C_003E1__state;
			dpRJBuSlQr0y1RbMtdG();
			num = (HTynLwS7hYQpk7GJGCf() ? 5 : 2);
			goto IL_02c3;
			IL_02c3:
			Classifier classifier = default;
			TaskAwaiter<string> awaiter = default;
			TaskAwaiter awaiter2 = default;
			UndoAddCurrentImage undoAddCurrentImage = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 1:
				case 2:
					classifier = _003C_003E4__this;
					num = 0;
					continue;
				case 0:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								_ = 1;
								num3 = (HTynLwS7hYQpk7GJGCf() ? 6 : 13);
							}
							else
							{
								awaiter = _003C_003Eu__2;
								num3 = 15;
								if (HTynLwS7hYQpk7GJGCf())
								{
									goto IL_0180;
								}
							}
							goto IL_00e3;
						}
						awaiter2 = _003C_003Eu__1;
						goto IL_014d;
						IL_0180:
						num2 = (_003C_003E1__state = 0);
						num3 = 8;
						goto IL_00e3;
						IL_014d:
						_003C_003Eu__1 = default;
						num3 = 16;
						goto IL_00e3;
						IL_00e3:
						while (true)
						{
							switch (num3)
							{
							case 11:
								break;
							case 5:
								return;
							default:
								num3 = 1;
								continue;
							case 2:
								num2 = (_003C_003E1__state = -1);
								num3 = 17;
								continue;
							case 1:
								goto IL_014d;
							case 6:
								return;
							case 12:
								return;
							case 3:
								goto IL_0180;
							case 16:
								num2 = (_003C_003E1__state = -1);
								goto IL_019c;
							case 8:
								_003C_003Eu__1 = awaiter2;
								num3 = 10;
								continue;
							case 0:
							case 13:
								goto IL_01be;
							case 9:
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 7:
								if (!awaiter2.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto IL_019c;
							case 15:
								_003C_003Eu__2 = default;
								num3 = 2;
								continue;
							case 4:
								undoAddCurrentImage = new UndoAddCurrentImage(classifier.xkMbRK87y, classifier.pLu4jtXb7, classViewModel);
								num3 = 14;
								continue;
							case 10:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 5;
								continue;
							case 14:
								awaiter2 = lwh9nhSf4O85EwY3pYo(wp6ug5SnQgCVyMeQSD7(UBhsTWSygoxsVLmBecN(classifier.xkMbRK87y), undoAddCurrentImage));
								num3 = 7;
								continue;
							case 17:
								goto IL_0280;
								IL_019c:
								awaiter2.GetResult();
								num3 = 11;
								continue;
							}
							break;
							IL_01be:
							if (classifier.pLu4jtXb7 == null)
							{
								awaiter = classifier._LabelCurrentImage(classViewModel).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									num3 = 9;
									if (HTynLwS7hYQpk7GJGCf())
									{
									}
									continue;
								}
								goto IL_0280;
							}
							num3 = 4;
							continue;
							IL_0280:
							awaiter.GetResult();
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
		internal static object UBhsTWSygoxsVLmBecN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wp6ug5SnQgCVyMeQSD7(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter lwh9nhSf4O85EwY3pYo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dpRJBuSlQr0y1RbMtdG()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HTynLwS7hYQpk7GJGCf()
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
	private struct _003C_LabelCurrentImage_003Ed__115 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		public ClassViewModel classViewModel;

		private TaskAwaiter<string> _003C_003Eu__1;

		private ITopLevelProgressableOperation _003C_003E7__wrap1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			string result = default;
			TaskAwaiter<string> awaiter = default;
			Classifier classifier = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					AuX7x0SzW9rBoqdVjjI();
					num = (wSnHOg62c6Dcl2YNEhQ() ? 3 : 0);
					break;
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 2:
				case 3:
					try
					{
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00d4;
						}
						if (num2 != 1)
						{
							if (classifier.OperationProgressManager == null || jHIS3f6XDrfdSlsghHq(classifier.OperationProgressManager))
							{
								awaiter = classifier.LtCBqOD3n(classViewModel).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_00d4;
							}
							_003C_003E7__wrap1 = (ITopLevelProgressableOperation)MXuI0j6MFoPXJMsOrau(classifier.OperationProgressManager, Resources.ApplyingLabel, Array.Empty<StepDescriptor>());
						}
						try
						{
							int num3;
							if (num2 != 1)
							{
								AuX7x0SzW9rBoqdVjjI();
								num3 = (wSnHOg62c6Dcl2YNEhQ() ? 8 : 2);
								goto IL_01a5;
							}
							awaiter = _003C_003Eu__1;
							goto IL_0131;
							IL_01a5:
							while (true)
							{
								switch (num3)
								{
								case 4:
									num2 = (_003C_003E1__state = -1);
									num3 = 10;
									continue;
								case 6:
								case 8:
									break;
								case 3:
									num2 = (_003C_003E1__state = 1);
									num3 = 7;
									continue;
								case 1:
									if (!awaiter.IsCompleted)
									{
										num3 = 3;
										continue;
									}
									goto case 10;
								case 0:
								case 2:
									awaiter = classifier.LtCBqOD3n(classViewModel).GetAwaiter();
									num3 = 1;
									continue;
								case 7:
									_003C_003Eu__1 = awaiter;
									goto case 5;
								default:
									num3 = 5;
									continue;
								case 9:
									return;
								case 5:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 9;
									continue;
								case 10:
									result = awaiter.GetResult();
									goto end_IL_01a5;
								}
								goto IL_0131;
								continue;
								end_IL_01a5:
								break;
							}
							goto end_IL_00fd;
							IL_0131:
							_003C_003Eu__1 = default;
							num3 = 4;
							goto IL_01a5;
							end_IL_00fd:;
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								DvRtgU6kbqJh60h8xxC(_003C_003E7__wrap1);
							}
						}
						goto end_IL_004f;
						IL_00d4:
						result = awaiter.GetResult();
						end_IL_004f:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 4;
				default:
					num = 4;
					break;
				case 0:
				case 1:
					classifier = _003C_003E4__this;
					goto case 2;
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
		internal static bool jHIS3f6XDrfdSlsghHq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).HasOperationsPending;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MXuI0j6MFoPXJMsOrau(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).StartBlockingOperation((string)P_1, (StepDescriptor[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void DvRtgU6kbqJh60h8xxC(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AuX7x0SzW9rBoqdVjjI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wSnHOg62c6Dcl2YNEhQ()
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
	private struct _003C_LabelCurrentImage_Internal_003Ed__116 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public ClassViewModel classViewModel;

		public Classifier _003C_003E4__this;

		private string _003CnewId_003E5__2;

		private List<ClassifyImage> _003CbeforeImages_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
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
			goto IL_0065;
			IL_001a:
			_003CbeforeImages_003E5__3 = null;
			num = 0;
			goto IL_0065;
			IL_0065:
			Classifier classifier = default;
			int num2 = default;
			string result = default;
			while (true)
			{
				switch (num)
				{
				case 7:
					break;
				case 4:
					num2 = _003C_003E1__state;
					W90ocI6mH7NdhURfAy0();
					num = (bQcSdG6rGOopWwI3f9Y() ? 5 : 6);
					continue;
				case 3:
				case 5:
					_003CnewId_003E5__2 = null;
					break;
				default:
					num = 7;
					if (W90ocI6mH7NdhURfAy0())
					{
						continue;
					}
					goto case 2;
				case 2:
					try
					{
						TaskAwaiter awaiter;
						switch (num2)
						{
						default:
							_003CnewId_003E5__2 = null;
							_003CbeforeImages_003E5__3 = ((IEnumerable<ClassifyImage>)xD45U16PgqCiCWZCC39(classViewModel)).ToList();
							awaiter = MBfODV6gwla6IKeXoo8(classifier.ClassifyService.LabelCurrentImage((string)O2cW2F6483XGG3YUphU(classViewModel)));
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0138;
						case 0:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_0138;
						case 1:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_019b;
						case 2:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_01f9;
						case 3:
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								break;
							}
							IL_019b:
							awaiter.GetResult();
							awaiter = MBfODV6gwla6IKeXoo8(classifier.RefreshLabeledImages());
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 2);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_01f9;
							IL_0138:
							awaiter.GetResult();
							awaiter = MBfODV6gwla6IKeXoo8(classifier.ClassifyService.Train());
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_019b;
							IL_01f9:
							awaiter.GetResult();
							awaiter = MBfODV6gwla6IKeXoo8(classifier.RunSheet());
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 3);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							break;
						}
						awaiter.GetResult();
						K6k3Cn61KGVDtn91pl1(classViewModel);
						List<ClassifyImage>.Enumerator enumerator = ((IEnumerable<ClassifyImage>)xD45U16PgqCiCWZCC39(classViewModel)).ToList().GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								ClassifyImage current = enumerator.Current;
								W90ocI6mH7NdhURfAy0();
								int num3;
								if (!bQcSdG6rGOopWwI3f9Y())
								{
									num3 = 3;
									if (1 == 0)
									{
										goto IL_02aa;
									}
								}
								else
								{
									num3 = 2;
								}
								goto IL_02e5;
								IL_02e5:
								switch (num3)
								{
								case 0:
								case 3:
									goto IL_02c1;
								case 4:
									goto end_IL_0313;
								}
								goto IL_02aa;
								IL_02c1:
								if (_003CbeforeImages_003E5__3.Contains(current))
								{
									continue;
								}
								goto IL_02aa;
								IL_02aa:
								_003CnewId_003E5__2 = (string)xGEP8Y6ST2nmdCwlrnD(current);
								num3 = 4;
								goto IL_02e5;
								continue;
								end_IL_0313:
								break;
							}
						}
						finally
						{
							if (num2 < 0)
							{
								((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
							}
						}
						result = _003CnewId_003E5__2;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CnewId_003E5__2 = null;
						_003CbeforeImages_003E5__3 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 3;
				case 1:
				case 6:
					classifier = _003C_003E4__this;
					num = 2;
					continue;
				case 0:
					_003C_003Et__builder.SetResult(result);
					num = 8;
					continue;
				case 8:
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
		internal static object xD45U16PgqCiCWZCC39(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassViewModel)P_0).LabeledImages;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object O2cW2F6483XGG3YUphU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassViewModel)P_0).ClassName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter MBfODV6gwla6IKeXoo8(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void K6k3Cn61KGVDtn91pl1(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ClassViewModel)P_0).NotifyImageCountChanged();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xGEP8Y6ST2nmdCwlrnD(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassifyImage)P_0).ImageId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool W90ocI6mH7NdhURfAy0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bQcSdG6rGOopWwI3f9Y()
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
	private struct _003CRemoveCurrentImage_003Ed__117 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		private ITopLevelProgressableOperation _003Coperation_003E5__2;

		private bool _003Cretrain_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			vLFi6V6DEFUCdcRHe9x();
			int num = ((!WkPGA066hNDDJbHPUbe()) ? 3 : 4);
			Classifier classifier = default;
			TaskAwaiter awaiter = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					goto case 1;
				case 1:
				case 3:
					classifier = _003C_003E4__this;
					num = 2;
					if (WkPGA066hNDDJbHPUbe())
					{
						break;
					}
					goto case 2;
				case 2:
					try
					{
						switch (num2)
						{
						default:
							_003Coperation_003E5__2 = classifier.OperationProgressManager?.StartBlockingOperation((string)p7qq0468HfRuHCl3pC1());
							goto case 0;
						case 0:
						case 1:
							try
							{
								int num3;
								switch (num2)
								{
								default:
									num3 = 10;
									break;
								case 1:
									awaiter = _003C_003Eu__1;
									num3 = 8;
									break;
								case 0:
									awaiter = _003C_003Eu__1;
									num3 = 9;
									break;
								}
								while (true)
								{
									switch (num3)
									{
									case 11:
										awaiter = ohct1h6dND6KMcIbTfc(luh2p86sb2HZU2ZmRVu(classifier.tFxs6dSMN, classifier.CurrentImageName));
										_ = 1;
										num3 = ((!vLFi6V6DEFUCdcRHe9x()) ? 1 : 4);
										continue;
									case 12:
										return;
									case 15:
										_003Cretrain_003E5__3 = classifier.LabeledImages.Any(classifier.uqIASceUE);
										num3 = 11;
										continue;
									case 2:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num3 = 12;
										if (true)
										{
											continue;
										}
										goto case 6;
									case 6:
										num2 = (_003C_003E1__state = 0);
										_003C_003Eu__1 = awaiter;
										goto case 4;
									case 8:
										_003C_003Eu__1 = default;
										num2 = (_003C_003E1__state = -1);
										num3 = 18;
										continue;
									case 14:
										if (!awaiter.IsCompleted)
										{
											num3 = 0;
											continue;
										}
										break;
									case 17:
										num2 = (_003C_003E1__state = -1);
										num3 = 16;
										continue;
									case 13:
										if (_003Cretrain_003E5__3)
										{
											awaiter = classifier.tFxs6dSMN.Train().GetAwaiter();
											num3 = 14;
											continue;
										}
										goto end_IL_0271;
									case 16:
										awaiter.GetResult();
										num3 = 13;
										continue;
									case 10:
										if (hrtHnU6F1MGprM242vd(classifier.CurrentImageName, nRHUj2QK9))
										{
											num3 = 15;
											if (WkPGA066hNDDJbHPUbe())
											{
												continue;
											}
											goto case 0;
										}
										goto end_IL_0271;
									case 0:
										num2 = (_003C_003E1__state = 1);
										_003C_003Eu__1 = awaiter;
										num3 = 2;
										continue;
									case 1:
									case 3:
										if (!awaiter.IsCompleted)
										{
											num3 = 6;
											continue;
										}
										goto case 16;
									case 7:
										return;
									case 9:
										_003C_003Eu__1 = default;
										goto case 17;
									default:
										num3 = 17;
										continue;
									case 4:
									case 5:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num3 = 7;
										continue;
									case 18:
										break;
									}
									awaiter.GetResult();
									break;
									continue;
									end_IL_0271:
									break;
								}
							}
							finally
							{
								if (num2 < 0 && _003Coperation_003E5__2 != null)
								{
									kvL1lO6E2D7pZ2jpbDt(_003Coperation_003E5__2);
								}
							}
							_003Coperation_003E5__2 = null;
							awaiter = ohct1h6dND6KMcIbTfc(classifier.NextImage());
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 2);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_036c;
						case 2:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_036c;
						case 3:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_03ca;
						case 4:
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								break;
							}
							IL_036c:
							awaiter.GetResult();
							awaiter = ohct1h6dND6KMcIbTfc(classifier.RefreshLabeledImages());
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 3);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_03ca;
							IL_03ca:
							awaiter.GetResult();
							awaiter = ohct1h6dND6KMcIbTfc(classifier.RefreshUnlabeledImages());
							if (!awaiter.IsCompleted)
							{
								num2 = (_003C_003E1__state = 4);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
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
					goto case 5;
				default:
					num = 5;
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
		internal static object p7qq0468HfRuHCl3pC1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.RemovingImage;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hrtHnU6F1MGprM242vd(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 != (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object luh2p86sb2HZU2ZmRVu(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IViDiELClassifyService)P_0).RemoveImage((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter ohct1h6dND6KMcIbTfc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void kvL1lO6E2D7pZ2jpbDt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WkPGA066hNDDJbHPUbe()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vLFi6V6DEFUCdcRHe9x()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass129_0
	{
		public string categoryName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass129_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			KSqS6n6aeZ7WxO4mCc7();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetCategory_003Eb__0(ClassViewModel vm)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return vm.ClassName == categoryName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void KSqS6n6aeZ7WxO4mCc7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xjgbgU65lsPC17WdLfK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ag8srj63Z9DIdytM5y0()
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
	private struct _003CDoUnlabelSelectedImages_003Ed__134 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			int num2 = default;
			Classifier classifier = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					num2 = _003C_003E1__state;
					_ = 1;
					if (!sIXttG6ccuC6cpem37l())
					{
						num = 0;
						break;
					}
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 1:
					classifier = _003C_003E4__this;
					goto case 2;
				case 2:
				case 5:
					try
					{
						TaskAwaiter awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = classifier.DoUnlabelImages(classifier.yd3jfKdsj().ToList()).GetAwaiter();
							num3 = 4;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
							if (1 == 0)
							{
								goto IL_00a2;
							}
						}
						goto IL_00e1;
						IL_0180:
						awaiter.GetResult();
						goto end_IL_0063;
						IL_00a2:
						num2 = (_003C_003E1__state = 0);
						_ = 1;
						if (!sIXttG6ccuC6cpem37l())
						{
							num3 = 8;
						}
						else
						{
							num3 = 5;
							if (1 == 0)
							{
								goto IL_0180;
							}
						}
						goto IL_00e1;
						IL_00e1:
						while (true)
						{
							switch (num3)
							{
							case 0:
								return;
							case 1:
								break;
							case 3:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 0;
								continue;
							case 5:
							case 6:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (!sIXttG6ccuC6cpem37l())
								{
									continue;
								}
								goto case 4;
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								goto IL_0180;
							case 2:
							case 8:
								_003C_003Eu__1 = awaiter;
								num3 = 3;
								if (sIXttG6ccuC6cpem37l())
								{
								}
								continue;
							case 7:
								_003C_003Eu__1 = default;
								goto case 5;
							case 9:
								goto IL_0180;
							}
							break;
						}
						goto IL_00a2;
						end_IL_0063:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 4;
				default:
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
		internal static bool ClN5BL6o8VVonsLBWvK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sIXttG6ccuC6cpem37l()
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
	private struct _003CDoUnlabelImages_003Ed__135 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		public List<ClassifyImage> images;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (!MW9hJt6ueR4XVgJWTkY())
			{
				goto IL_001e;
			}
			goto IL_02ce;
			IL_001e:
			int num2 = _003C_003E1__state;
			_ = 1;
			if (!Fm9yfV6BVoQhaYRBiJJ())
			{
				num = 0;
			}
			else
			{
				num = 5;
				if (Fm9yfV6BVoQhaYRBiJJ())
				{
					goto IL_0058;
				}
			}
			goto IL_02ce;
			IL_0058:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_02ce;
			IL_02ce:
			Classifier classifier = default;
			TaskAwaiter awaiter = default;
			UndoUnlabelImages undoUnlabelImages = default;
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 0:
				case 1:
					classifier = _003C_003E4__this;
					goto case 2;
				case 4:
					goto IL_0058;
				case 2:
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 10;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 17;
								if (!MW9hJt6ueR4XVgJWTkY())
								{
									goto IL_00e7;
								}
							}
							goto IL_0138;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0104;
						IL_0138:
						while (true)
						{
							switch (num3)
							{
							case 5:
							case 11:
								break;
							case 9:
								return;
							case 14:
								return;
							case 12:
								goto IL_00e7;
							case 0:
								goto IL_0104;
							case 13:
								return;
							default:
								num3 = 0;
								if (true)
								{
									continue;
								}
								goto case 15;
							case 15:
								num2 = (_003C_003E1__state = 1);
								num3 = 3;
								continue;
							case 7:
								awaiter = r1Gvsf6UV5TyeGKYCnl(KUsDpc6hc5JMkP4qiBW(qcQSh96xqIMSfi59Dgi(classifier.xkMbRK87y), undoUnlabelImages));
								num3 = 4;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 0);
								num3 = 16;
								continue;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 12;
								continue;
							case 3:
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 2:
								undoUnlabelImages = new UndoUnlabelImages(classifier.pLu4jtXb7, images);
								num3 = 7;
								if (MW9hJt6ueR4XVgJWTkY())
								{
									continue;
								}
								goto case 6;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 13;
								continue;
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto IL_00e7;
							case 16:
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								continue;
							case 10:
								if (classifier.pLu4jtXb7 == null)
								{
									awaiter = r1Gvsf6UV5TyeGKYCnl(classifier.Oait7AyuH(classifier.yd3jfKdsj().ToList()));
									if (!awaiter.IsCompleted)
									{
										num3 = 15;
										continue;
									}
								}
								else
								{
									num3 = 2;
									if (MW9hJt6ueR4XVgJWTkY())
									{
										continue;
									}
								}
								goto case 17;
							case 17:
								awaiter.GetResult();
								break;
							}
							break;
						}
						goto end_IL_006d;
						IL_0104:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_0138;
						IL_00e7:
						awaiter.GetResult();
						_ = 1;
						num3 = (Fm9yfV6BVoQhaYRBiJJ() ? 9 : 5);
						goto IL_0138;
						end_IL_006d:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto IL_0058;
				default:
					num = 4;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_001e;
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
		internal static object qcQSh96xqIMSfi59Dgi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KUsDpc6hc5JMkP4qiBW(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter r1Gvsf6UV5TyeGKYCnl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MW9hJt6ueR4XVgJWTkY()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Fm9yfV6BVoQhaYRBiJJ()
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
	private struct _003C_DoUnlabelImages_003Ed__136 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		public IEnumerable<ClassifyImage> images;

		private ITopLevelProgressableOperation _003Coperation_003E5__2;

		private int _003CimageCount_003E5__3;

		private IEnumerator<ClassifyImage> _003C_003E7__wrap3;

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
			Classifier classifier = default;
			TaskAwaiter awaiter = default;
			ClassifyImage current = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					hE9bvY6qjwfiVsr9ioE();
					if (Tsu1AG6QApuaoN3hwMl())
					{
						num = 0;
						if (0 == 0)
						{
							break;
						}
						goto case 2;
					}
					num = 3;
					break;
				case 2:
				case 3:
					try
					{
						if ((uint)num2 > 3u)
						{
							IOperationProgressManager operationProgressManager = classifier.OperationProgressManager;
							_003Coperation_003E5__2 = (ITopLevelProgressableOperation)((operationProgressManager != null) ? hVgG7X6iJLmdEfV8nqn(operationProgressManager, M0JEjQ6V0PCv5EJBb3S(), Array.Empty<StepDescriptor>()) : null);
						}
						try
						{
							switch (num2)
							{
							default:
								_003CimageCount_003E5__3 = images.Count();
								_003C_003E7__wrap3 = images.GetEnumerator();
								goto case 0;
							case 0:
								try
								{
									if (num2 != 0)
									{
										goto IL_0208;
									}
									awaiter = _003C_003Eu__1;
									int num3 = 1;
									goto IL_0168;
									IL_01f5:
									_003C_003Eu__1 = awaiter;
									num3 = 11;
									if (true)
									{
										goto IL_0168;
									}
									goto IL_0208;
									IL_0208:
									if (b7Oxfm6ZNdE4c0HCllL(_003C_003E7__wrap3))
									{
										current = _003C_003E7__wrap3.Current;
										_ = 0;
										if (Tsu1AG6QApuaoN3hwMl())
										{
											num3 = 7;
										}
										else
										{
											num3 = 10;
											if (false)
											{
												goto IL_014d;
											}
										}
										goto IL_0168;
									}
									goto end_IL_00a4;
									IL_0168:
									while (true)
									{
										switch (num3)
										{
										case 0:
										case 7:
											if (classifier.jxie4Fcpv(current) != null)
											{
												num3 = 3;
												continue;
											}
											goto IL_0208;
										case 8:
											num2 = (_003C_003E1__state = -1);
											goto IL_00f0;
										case 11:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											num3 = 5;
											continue;
										case 1:
											_003C_003Eu__1 = default;
											num3 = 8;
											continue;
										case 2:
											if (!awaiter.IsCompleted)
											{
												break;
											}
											goto IL_00f0;
										case 4:
										case 10:
											break;
										default:
											num3 = 9;
											continue;
										case 5:
											return;
										case 6:
											awaiter = jrbZjT6vIclWd9ZpaMO(gdFNBf697lQVJTbc9x4(classifier.ClassifyService, kdc7Sq6twUePYO05jrm(current)));
											num3 = 2;
											continue;
										case 3:
											OCEjXk6Lr43gDnkfPZf(current, false);
											num3 = 6;
											if (0 == 0)
											{
												continue;
											}
											goto IL_01f5;
										case 9:
											goto IL_01f5;
										case 12:
											goto IL_0208;
											IL_00f0:
											awaiter.GetResult();
											num3 = 12;
											continue;
										}
										break;
									}
									goto IL_014d;
									IL_014d:
									num2 = (_003C_003E1__state = 0);
									goto IL_01f5;
									end_IL_00a4:;
								}
								finally
								{
									if (num2 < 0 && _003C_003E7__wrap3 != null)
									{
										soIb9l60WAlgVoxVRCM(_003C_003E7__wrap3);
									}
								}
								_003C_003E7__wrap3 = null;
								awaiter = jrbZjT6vIclWd9ZpaMO(zDu6r66OZhaTelaxGWd(classifier.ClassifyService));
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 1);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_029e;
							case 1:
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_029e;
							case 2:
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_02fc;
							case 3:
								{
									awaiter = _003C_003Eu__1;
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									break;
								}
								IL_029e:
								awaiter.GetResult();
								awaiter = classifier.RefreshLabeledImages().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 2);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_02fc;
								IL_02fc:
								awaiter.GetResult();
								awaiter = jrbZjT6vIclWd9ZpaMO(classifier.NextImage());
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 3);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								break;
							}
							awaiter.GetResult();
							ITopLevelProgressableOperation topLevelProgressableOperation = _003Coperation_003E5__2;
							if (topLevelProgressableOperation != null)
							{
								CVDEqn6T1Kr6hVCfTY1(topLevelProgressableOperation, C4hTrn6H7qMQkSkF2KR(), new ProgressAmount(_003CimageCount_003E5__3, _003CimageCount_003E5__3));
							}
						}
						finally
						{
							if (num2 < 0 && _003Coperation_003E5__2 != null)
							{
								_003Coperation_003E5__2.Dispose();
							}
						}
						_003Coperation_003E5__2 = null;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 4;
				default:
					num = 4;
					break;
				case 4:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
				case 1:
					classifier = _003C_003E4__this;
					goto case 2;
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
		internal static object M0JEjQ6V0PCv5EJBb3S()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.RemovingLabel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hVgG7X6iJLmdEfV8nqn(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).StartCancellableBlockingOperation((string)P_1, (StepDescriptor[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void OCEjXk6Lr43gDnkfPZf(object P_0, bool value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ClassifyImage)P_0).IsLabeled = value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kdc7Sq6twUePYO05jrm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassifyImage)P_0).ImageId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gdFNBf697lQVJTbc9x4(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IViDiELClassifyService)P_0).ClearClassLabel((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter jrbZjT6vIclWd9ZpaMO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool b7Oxfm6ZNdE4c0HCllL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void soIb9l60WAlgVoxVRCM(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object zDu6r66OZhaTelaxGWd(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IViDiELClassifyService)P_0).Train();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object C4hTrn6H7qMQkSkF2KR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.Complete;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void CVDEqn6T1Kr6hVCfTY1(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IProgressReporter)P_0).Report((string)P_1, (ProgressAmount)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Tsu1AG6QApuaoN3hwMl()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hE9bvY6qjwfiVsr9ioE()
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
	private struct _003CDoRemoveSelectedImages_003Ed__140 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 4;
			if (!sYcALi6YqbnfjNXpAm8())
			{
				goto IL_001e;
			}
			goto IL_02f4;
			IL_0062:
			_003C_003Et__builder.SetResult();
			num = 6;
			if (false)
			{
				goto IL_0079;
			}
			goto IL_02f4;
			IL_0079:
			int num2 = default;
			Classifier classifier = default;
			try
			{
				int num3;
				TaskAwaiter awaiter = default;
				if (num2 != 0)
				{
					if (num2 != 1)
					{
						num3 = 13;
					}
					else
					{
						awaiter = _003C_003Eu__1;
						num3 = 0;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default;
					num3 = 14;
				}
				UndoRemoveImages undoRemoveImages = default;
				while (true)
				{
					switch (num3)
					{
					case 6:
						num2 = (_003C_003E1__state = 0);
						goto case 4;
					case 7:
						num2 = (_003C_003E1__state = -1);
						num3 = 17;
						continue;
					case 12:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 2;
						continue;
					case 3:
						if (!awaiter.IsCompleted)
						{
							num3 = 6;
							if (true)
							{
								continue;
							}
							goto case 9;
						}
						goto IL_01c3;
					case 9:
						num2 = (_003C_003E1__state = 1);
						_003C_003Eu__1 = awaiter;
						num3 = 12;
						continue;
					case 0:
						_003C_003Eu__1 = default;
						num3 = 7;
						continue;
					case 4:
					case 15:
						_003C_003Eu__1 = awaiter;
						num3 = 16;
						if (sYcALi6YqbnfjNXpAm8())
						{
							continue;
						}
						goto case 1;
					case 1:
					case 8:
						awaiter = bfxZQs6CCnHnKvL6coV(kw9PNj6KTOg81O9dJhZ(classifier.xkMbRK87y.UndoHandler, undoRemoveImages));
						num3 = 3;
						if (LULWLy6JS2kWvslV1Wn())
						{
						}
						continue;
					case 10:
						return;
					case 16:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 10;
						if (sYcALi6YqbnfjNXpAm8())
						{
							continue;
						}
						goto case 11;
					case 11:
						if (awaiter.IsCompleted)
						{
							break;
						}
						num3 = 9;
						if (sYcALi6YqbnfjNXpAm8())
						{
							continue;
						}
						goto case 14;
					case 14:
						num2 = (_003C_003E1__state = -1);
						goto IL_01c3;
					default:
						num3 = 5;
						continue;
					case 5:
						goto end_IL_01dc;
					case 2:
						return;
					case 13:
						if (classifier.pLu4jtXb7 == null)
						{
							awaiter = bfxZQs6CCnHnKvL6coV(classifier.FQt30A3AL(classifier.yd3jfKdsj().ToList(), Resources.SelectedImages));
							num3 = 11;
						}
						else
						{
							undoRemoveImages = new UndoRemoveImages(classifier.xkMbRK87y, classifier.pLu4jtXb7, classifier.yd3jfKdsj().ToList());
							_ = 0;
							num3 = (sYcALi6YqbnfjNXpAm8() ? 8 : 15);
						}
						continue;
					case 17:
						break;
						IL_01c3:
						awaiter.GetResult();
						goto end_IL_01dc;
					}
					awaiter.GetResult();
					break;
					continue;
					end_IL_01dc:
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
			goto IL_0062;
			IL_02f4:
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				case 1:
				case 5:
					classifier = _003C_003E4__this;
					goto IL_0079;
				case 3:
					goto IL_0062;
				case 0:
				case 2:
					goto IL_0079;
				default:
					num = 3;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_001e;
			IL_001e:
			num2 = _003C_003E1__state;
			sYcALi6YqbnfjNXpAm8();
			if (!LULWLy6JS2kWvslV1Wn())
			{
				num = 5;
				if (LULWLy6JS2kWvslV1Wn())
				{
				}
			}
			else
			{
				num = 0;
				if (false)
				{
					goto IL_0062;
				}
			}
			goto IL_02f4;
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
		internal static object kw9PNj6KTOg81O9dJhZ(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter bfxZQs6CCnHnKvL6coV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sYcALi6YqbnfjNXpAm8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LULWLy6JS2kWvslV1Wn()
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
	private struct _003C_DoRemoveSelectedImages_003Ed__141 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		public IEnumerable<ClassifyImage> images;

		private ITopLevelProgressableOperation _003Coperation_003E5__2;

		private bool _003CrefreshLabeledImages_003E5__3;

		private int _003CimageCount_003E5__4;

		private IEnumerator<ClassifyImage> _003C_003E7__wrap4;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			Classifier classifier = default;
			ClassifyImage current = default;
			TaskAwaiter awaiter = default;
			int num2 = default;
			while (true)
			{
				IL_04c8:
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 0:
				case 2:
					try
					{
						if ((uint)num2 > 4u)
						{
							if (num2 == 5)
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0486;
							}
							IOperationProgressManager operationProgressManager = classifier.OperationProgressManager;
							_003Coperation_003E5__2 = (ITopLevelProgressableOperation)((operationProgressManager != null) ? Nxd4p66wfTnCDJ1tbrC(operationProgressManager, Resources.RemovingImages, Array.Empty<StepDescriptor>()) : null);
						}
						try
						{
							switch (num2)
							{
							default:
								_003CrefreshLabeledImages_003E5__3 = false;
								_003CimageCount_003E5__4 = images.Count();
								_003C_003E7__wrap4 = images.GetEnumerator();
								goto case 0;
							case 0:
								try
								{
									if (num2 != 0)
									{
										goto IL_020f;
									}
									awaiter = _003C_003Eu__1;
									int num3 = 2;
									goto IL_012f;
									IL_012f:
									while (true)
									{
										switch (num3)
										{
										case 7:
											awaiter = XI74Rl6jj05UdonmZFa(dYQfRW6RLbMXtqG00VC(classifier.ClassifyService, l4EM3O6GMkvAn1HkBZL(current)));
											num3 = 6;
											if (true)
											{
												continue;
											}
											goto case 10;
										case 10:
											if (z2Nu426p3DrjqHHJCsK(current))
											{
												_ = 0;
												num3 = ((!oN6Nkb6AtBoxLJwqerU()) ? 4 : 11);
												continue;
											}
											goto case 7;
										case 0:
											num2 = (_003C_003E1__state = 0);
											_003C_003Eu__1 = awaiter;
											goto default;
										case 6:
											if (!awaiter.IsCompleted)
											{
												num3 = 0;
												if (true)
												{
													continue;
												}
												goto case 1;
											}
											goto case 3;
										case 1:
										case 11:
											_003CrefreshLabeledImages_003E5__3 = true;
											num3 = 7;
											continue;
										case 3:
											awaiter.GetResult();
											num3 = 12;
											continue;
										case 2:
											_003C_003Eu__1 = default;
											num3 = 9;
											continue;
										case 9:
											num2 = (_003C_003E1__state = -1);
											num3 = 3;
											if (!EsgchC6NBKSIn0mSWVs())
											{
												continue;
											}
											goto default;
										default:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											num3 = 8;
											continue;
										case 8:
											return;
										case 12:
											break;
										}
										break;
									}
									goto IL_020f;
									IL_020f:
									if (_003C_003E7__wrap4.MoveNext())
									{
										current = _003C_003E7__wrap4.Current;
										num3 = 10;
										goto IL_012f;
									}
								}
								finally
								{
									if (num2 < 0 && _003C_003E7__wrap4 != null)
									{
										xirqxl6IpAwb0GRjemy(_003C_003E7__wrap4);
									}
								}
								_003C_003E7__wrap4 = null;
								if (_003CrefreshLabeledImages_003E5__3)
								{
									awaiter = XI74Rl6jj05UdonmZFa(Fa3aJk6WX6Oj0BvWfim(classifier.ClassifyService));
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 1);
										_003C_003Eu__1 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									goto IL_02b0;
								}
								awaiter = XI74Rl6jj05UdonmZFa(classifier.RefreshUnlabeledImages());
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 3);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_0371;
							case 1:
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_02b0;
							case 2:
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_030e;
							case 3:
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0371;
							case 4:
								{
									awaiter = _003C_003Eu__1;
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_03cf;
								}
								IL_03cf:
								awaiter.GetResult();
								break;
								IL_030e:
								awaiter.GetResult();
								break;
								IL_0371:
								awaiter.GetResult();
								awaiter = XI74Rl6jj05UdonmZFa(classifier.RefreshUnlabeledImagePredictions());
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 4);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_03cf;
								IL_02b0:
								awaiter.GetResult();
								awaiter = XI74Rl6jj05UdonmZFa(classifier.RefreshLabeledImages());
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 2);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_030e;
							}
							ITopLevelProgressableOperation topLevelProgressableOperation = _003Coperation_003E5__2;
							if (topLevelProgressableOperation != null)
							{
								UNBY3N6eliIGhUHc7G9(topLevelProgressableOperation, p19xyT6bLFjrJrgOZs5(), new ProgressAmount(_003CimageCount_003E5__4, _003CimageCount_003E5__4));
							}
						}
						finally
						{
							if (num2 < 0 && _003Coperation_003E5__2 != null)
							{
								xirqxl6IpAwb0GRjemy(_003Coperation_003E5__2);
							}
						}
						_003Coperation_003E5__2 = null;
						awaiter = XI74Rl6jj05UdonmZFa(classifier.NextImage());
						if (!awaiter.IsCompleted)
						{
							num2 = (_003C_003E1__state = 5);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0486;
						IL_0486:
						awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 4:
					while (true)
					{
						classifier = _003C_003E4__this;
						_ = 0;
						if (oN6Nkb6AtBoxLJwqerU())
						{
							break;
						}
						num = 5;
						if (oN6Nkb6AtBoxLJwqerU())
						{
							goto IL_04c8;
						}
					}
					num = 0;
					if (!EsgchC6NBKSIn0mSWVs())
					{
						continue;
					}
					break;
				case 1:
					break;
				case 6:
					return;
				}
				num2 = _003C_003E1__state;
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
		internal static object Nxd4p66wfTnCDJ1tbrC(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).StartBlockingOperation((string)P_1, (StepDescriptor[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool z2Nu426p3DrjqHHJCsK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassifyImage)P_0).IsLabeled;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object l4EM3O6GMkvAn1HkBZL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassifyImage)P_0).ImageId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dYQfRW6RLbMXtqG00VC(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IViDiELClassifyService)P_0).RemoveImage((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter XI74Rl6jj05UdonmZFa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void xirqxl6IpAwb0GRjemy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Fa3aJk6WX6Oj0BvWfim(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IViDiELClassifyService)P_0).Train();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object p19xyT6bLFjrJrgOZs5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.Complete;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UNBY3N6eliIGhUHc7G9(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IProgressReporter)P_0).Report((string)P_1, (ProgressAmount)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oN6Nkb6AtBoxLJwqerU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EsgchC6NBKSIn0mSWVs()
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
	private struct _003CDoRemoveUnlabeledImages_003Ed__145 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xRJPWl671PMx8RPBCNu();
			int num;
			if (MsrvyY6lqQrPbaXRPZN())
			{
				num = 2;
			}
			else
			{
				num = 1;
				if (1 == 0)
				{
					return;
				}
			}
			int num2 = default;
			TaskAwaiter awaiter = default;
			Classifier classifier = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					num = 5;
					if (MsrvyY6lqQrPbaXRPZN())
					{
						continue;
					}
					break;
				case 5:
					break;
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 16;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 15;
								if (xRJPWl671PMx8RPBCNu())
								{
								}
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 13;
							if (1 == 0)
							{
								goto IL_029c;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
							case 4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 1;
								if (xRJPWl671PMx8RPBCNu())
								{
								}
								continue;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = 10;
									continue;
								}
								break;
							case 10:
								num2 = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								num3 = 12;
								if (MsrvyY6lqQrPbaXRPZN())
								{
									continue;
								}
								goto case 11;
							case 11:
								awaiter.GetResult();
								goto end_IL_00ed;
							default:
								goto end_IL_00ed;
							case 14:
								return;
							case 5:
								goto end_IL_00ed;
							case 9:
								num2 = (_003C_003E1__state = -1);
								num3 = 17;
								continue;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 3;
									continue;
								}
								goto case 11;
							case 16:
								if (classifier.pLu4jtXb7 == null)
								{
									awaiter = nqUdLv6nnPM8gGd1XLW(classifier.FQt30A3AL(classifier.UnlabeledImages.ToList(), (string)OxgJJa6fFjGhCPPElWJ()));
									num3 = 7;
								}
								else
								{
									num3 = 2;
								}
								continue;
							case 2:
							{
								UndoRemoveImages undoRemoveImages = new UndoRemoveImages(classifier.xkMbRK87y, classifier.pLu4jtXb7, classifier.UnlabeledImages.ToList());
								awaiter = nqUdLv6nnPM8gGd1XLW(LWEXIX6yEJ3vk8lW1O5(classifier.xkMbRK87y.UndoHandler, undoRemoveImages));
								num3 = 6;
								continue;
							}
							case 12:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 14;
								continue;
							case 13:
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								continue;
							case 3:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_ = 1;
								num3 = (xRJPWl671PMx8RPBCNu() ? 5 : 0);
								continue;
							case 15:
								_003C_003Eu__1 = default;
								num3 = 9;
								continue;
							case 1:
								return;
							case 17:
								break;
							}
							goto IL_029c;
							continue;
							end_IL_00ed:
							break;
						}
						goto end_IL_0065;
						IL_029c:
						awaiter.GetResult();
						end_IL_0065:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 6:
					return;
				}
				classifier = _003C_003E4__this;
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
		internal static object LWEXIX6yEJ3vk8lW1O5(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter nqUdLv6nnPM8gGd1XLW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OxgJJa6fFjGhCPPElWJ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.UnlabeledImages;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MsrvyY6lqQrPbaXRPZN()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xRJPWl671PMx8RPBCNu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass152_0
	{
		public Classifier _003C_003E4__this;

		public string value;

		public Func<string, bool> _003C_003E9__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass152_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			iqgtIoDXlfMnRQP75WK();
			oDWgWlDMB6gt7gT2NII(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003Cset_NewClassName_003Eb__0(string cn)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003E4__this.GetCategory(cn) == null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003Cset_NewClassName_003Eb__1(string cn)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return t7QukwDkmAnYEHtlvJb(cn, value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void iqgtIoDXlfMnRQP75WK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void oDWgWlDMB6gt7gT2NII(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cuytvT6zGnorysaFEA5()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yjntoED2jRVyTfRqcQW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool t7QukwDkmAnYEHtlvJb(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 != (string)P_1;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDoRelabelSelectedImages_003Ed__156 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			int num2 = default;
			Classifier classifier = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					num2 = _003C_003E1__state;
					num = 5;
					if (0 == 0)
					{
						continue;
					}
					goto case 5;
				case 5:
					classifier = _003C_003E4__this;
					doHqmJDmH5DUrKMyfVP();
					if (!pLAHPSDrMciaB0R34cd())
					{
						num = 0;
						if (true)
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
							awaiter = n3JDVUDPk8IkF2a65y4(classifier.DoRelabelImages(classifier.yd3jfKdsj().ToList(), classifier.SelectedClassLabel));
							num3 = 5;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 7;
							if (false)
							{
								goto IL_0093;
							}
						}
						goto IL_0108;
						IL_00e8:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						IL_0093:
						if (!awaiter.IsCompleted)
						{
							_ = 1;
							if (!pLAHPSDrMciaB0R34cd())
							{
								num3 = 6;
							}
							else
							{
								num3 = 4;
								if (false)
								{
									goto IL_00e8;
								}
							}
							goto IL_0108;
						}
						goto IL_016f;
						IL_0108:
						while (true)
						{
							switch (num3)
							{
							case 0:
								return;
							case 5:
								break;
							case 7:
								_003C_003Eu__1 = default;
								num3 = 3;
								if (true)
								{
									continue;
								}
								goto case 1;
							case 1:
							case 6:
								num2 = (_003C_003E1__state = 0);
								goto case 2;
							case 8:
								goto IL_00e8;
							default:
								num3 = 0;
								continue;
							case 3:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								if (doHqmJDmH5DUrKMyfVP())
								{
									continue;
								}
								goto case 2;
							case 2:
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 8;
								if (doHqmJDmH5DUrKMyfVP())
								{
									continue;
								}
								goto IL_016f;
							case 9:
								goto IL_016f;
							}
							break;
						}
						goto IL_0093;
						IL_016f:
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
		internal static TaskAwaiter n3JDVUDPk8IkF2a65y4(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool doHqmJDmH5DUrKMyfVP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pLAHPSDrMciaB0R34cd()
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
	private struct _003CDoRelabelImages_003Ed__157 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public List<ClassifyImage> images;

		public Classifier _003C_003E4__this;

		public string classLabel;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			Classifier classifier = default;
			TaskAwaiter awaiter = default;
			UndoLabelImages undoLabelImages = default;
			while (true)
			{
				switch (num)
				{
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 0:
					num2 = _003C_003E1__state;
					_ = 0;
					num = ((!I6F0oND4h7sg6A5mGSh()) ? 2 : 4);
					break;
				case 1:
				case 4:
					classifier = _003C_003E4__this;
					num = 5;
					if (SBeqB6Dg4CJriRBupfv())
					{
					}
					break;
				case 5:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 12;
								if (false)
								{
									goto IL_007e;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 5;
								if (!I6F0oND4h7sg6A5mGSh())
								{
									goto IL_0158;
								}
							}
							goto IL_00b4;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0158;
						IL_00b4:
						while (true)
						{
							switch (num3)
							{
							case 2:
								break;
							case 4:
								return;
							default:
								num3 = 14;
								if (0 == 0)
								{
									continue;
								}
								goto case 12;
							case 12:
								if (images != null)
								{
									num3 = 11;
									continue;
								}
								goto end_IL_0065;
							case 5:
								_003C_003Eu__1 = default;
								num3 = 15;
								continue;
							case 13:
								return;
							case 14:
								goto IL_0158;
							case 1:
								goto end_IL_0065;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 6;
									continue;
								}
								goto IL_0253;
							case 11:
								goto IL_01b9;
							case 16:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								if (I6F0oND4h7sg6A5mGSh())
								{
									continue;
								}
								goto case 15;
							case 15:
								num2 = (_003C_003E1__state = -1);
								num3 = 18;
								continue;
							case 7:
								awaiter = tsnv1MD6GHxL6EUyfLi(b0QtpMDSNDlAyiSEdwD(dv8xHfD135Jxs7OWq8Z(classifier.xkMbRK87y), undoLabelImages));
								num3 = 0;
								continue;
							case 3:
							case 17:
								undoLabelImages = new UndoLabelImages(classifier.pLu4jtXb7, images, classLabel);
								num3 = 7;
								continue;
							case 8:
								num2 = (_003C_003E1__state = 1);
								num3 = 16;
								continue;
							case 9:
							case 10:
								goto IL_0253;
							case 6:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 4;
								continue;
							case 18:
								goto IL_02b5;
							}
							break;
							IL_01b9:
							if (images.Count != 0)
							{
								if (classifier.pLu4jtXb7 != null)
								{
									_ = 0;
									num3 = (I6F0oND4h7sg6A5mGSh() ? 17 : 10);
									continue;
								}
								awaiter = tsnv1MD6GHxL6EUyfLi(classifier.Q7XCNWHf0(images, classLabel));
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto IL_02b5;
							}
							num3 = 1;
							continue;
							IL_02b5:
							awaiter.GetResult();
							goto end_IL_0065;
						}
						goto IL_007e;
						IL_007e:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 13;
						goto IL_00b4;
						IL_0253:
						awaiter.GetResult();
						goto end_IL_0065;
						IL_0158:
						_003C_003Eu__1 = default;
						num2 = (_003C_003E1__state = -1);
						goto IL_0253;
						end_IL_0065:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
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
		internal static object dv8xHfD135Jxs7OWq8Z(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object b0QtpMDSNDlAyiSEdwD(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter tsnv1MD6GHxL6EUyfLi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool I6F0oND4h7sg6A5mGSh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SBeqB6Dg4CJriRBupfv()
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
	private struct _003C_DoRelabelImages_003Ed__158 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		public string classLabel;

		public IEnumerable<ClassifyImage> images;

		private ITopLevelProgressableOperation _003Coperation_003E5__2;

		private int _003CimageCount_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		private IEnumerator<ClassifyImage> _003C_003E7__wrap3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 0;
			int num = ((!JCxIDIDDi6Hy7mB6UtT()) ? 4 : 2);
			Classifier classifier = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			ClassifyImage current = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 1:
				case 4:
					classifier = _003C_003E4__this;
					num = 3;
					if (0 == 0)
					{
						break;
					}
					goto case 0;
				case 0:
				case 2:
					num2 = _003C_003E1__state;
					goto case 1;
				case 3:
					try
					{
						if ((uint)num2 > 7u)
						{
							_003Coperation_003E5__2 = classifier.OperationProgressManager?.StartBlockingOperation((string)g6XxBNDFRbmEHR9hUEU());
						}
						try
						{
							switch (num2)
							{
							default:
								if (classifier.GetCategory(classLabel) == null)
								{
									awaiter = JeQhwcDdcOe1s6Tilwa(F6YUlxDsb8IDvF8mJGf(classifier.ClassifyService, classLabel));
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 0);
										_003C_003Eu__1 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									goto IL_012c;
								}
								goto IL_0133;
							case 0:
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_012c;
							case 1:
								try
								{
									int num3;
									if (num2 != 1)
									{
										num3 = 2;
										goto IL_01c6;
									}
									awaiter = _003C_003Eu__1;
									_003C_003Eu__1 = default;
									goto IL_0241;
									IL_0241:
									num2 = (_003C_003E1__state = -1);
									num3 = 6;
									goto IL_01c6;
									IL_01c6:
									while (true)
									{
										switch (num3)
										{
										case 0:
											return;
										case 9:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											num3 = 0;
											continue;
										case 1:
											_003C_003Eu__1 = awaiter;
											goto case 9;
										default:
											num3 = 9;
											continue;
										case 3:
										case 10:
											num2 = (_003C_003E1__state = 1);
											num3 = 1;
											continue;
										case 8:
											awaiter = JeQhwcDdcOe1s6Tilwa(eolkScD5AyLjZvfBADI(classifier.ClassifyService, UGxWUdDEVExHXcOfe78(current), classLabel));
											num3 = 4;
											if (0 == 0)
											{
												continue;
											}
											break;
										case 5:
										case 7:
											break;
										case 4:
											if (!awaiter.IsCompleted)
											{
												vlwoLgD8w97AGpTVFcE();
												if (!JCxIDIDDi6Hy7mB6UtT())
												{
													num3 = 5;
													if (!vlwoLgD8w97AGpTVFcE())
													{
														continue;
													}
													goto case 9;
												}
												num3 = 10;
												continue;
											}
											goto case 6;
										case 6:
											awaiter.GetResult();
											num3 = 11;
											continue;
										case 2:
										case 11:
											if (_003C_003E7__wrap3.MoveNext())
											{
												current = _003C_003E7__wrap3.Current;
												num3 = 8;
												continue;
											}
											goto end_IL_01c6;
										}
										goto IL_0241;
										continue;
										end_IL_01c6:
										break;
									}
								}
								finally
								{
									if (num2 < 0 && _003C_003E7__wrap3 != null)
									{
										g2jPpKD3Zw8M53JEvcU(_003C_003E7__wrap3);
									}
								}
								_003C_003E7__wrap3 = null;
								awaiter = ((Task)Xl2FogDasCWhqqqm9Wl(classifier.ClassifyService)).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 2);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_033c;
							case 2:
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_033c;
							case 3:
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_039a;
							case 4:
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_03f8;
							case 5:
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0456;
							case 6:
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_04b4;
							case 7:
								{
									awaiter = _003C_003Eu__1;
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									break;
								}
								IL_04b4:
								awaiter.GetResult();
								awaiter = JeQhwcDdcOe1s6Tilwa(classifier.NextImage());
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 7);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								break;
								IL_039a:
								awaiter.GetResult();
								awaiter = JeQhwcDdcOe1s6Tilwa(classifier.RefreshUnlabeledImages());
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 4);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_03f8;
								IL_012c:
								awaiter.GetResult();
								goto IL_0133;
								IL_0133:
								_003CimageCount_003E5__3 = images.Count();
								_003C_003E7__wrap3 = images.GetEnumerator();
								goto case 1;
								IL_0456:
								awaiter.GetResult();
								awaiter = JeQhwcDdcOe1s6Tilwa(classifier.RefreshLabeledImagePredictions());
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 6);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_04b4;
								IL_03f8:
								awaiter.GetResult();
								awaiter = JeQhwcDdcOe1s6Tilwa(classifier.RefreshUnlabeledImagePredictions());
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 5);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_0456;
								IL_033c:
								awaiter.GetResult();
								awaiter = JeQhwcDdcOe1s6Tilwa(classifier.RefreshLabeledImages());
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 3);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_039a;
							}
							awaiter.GetResult();
							ITopLevelProgressableOperation topLevelProgressableOperation = _003Coperation_003E5__2;
							if (topLevelProgressableOperation != null)
							{
								rAKfJIDomad75fgl62F(topLevelProgressableOperation, Resources.Complete, new ProgressAmount(_003CimageCount_003E5__3, _003CimageCount_003E5__3));
							}
						}
						finally
						{
							if (num2 < 0 && _003Coperation_003E5__2 != null)
							{
								g2jPpKD3Zw8M53JEvcU(_003Coperation_003E5__2);
							}
						}
						_003Coperation_003E5__2 = null;
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
		internal static object g6XxBNDFRbmEHR9hUEU()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ApplyingLabel;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object F6YUlxDsb8IDvF8mJGf(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IViDiELClassifyService)P_0).AddClass((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter JeQhwcDdcOe1s6Tilwa(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UGxWUdDEVExHXcOfe78(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassifyImage)P_0).ImageId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eolkScD5AyLjZvfBADI(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IViDiELClassifyService)P_0).SetClassLabel((string)P_1, (string)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void g2jPpKD3Zw8M53JEvcU(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Xl2FogDasCWhqqqm9Wl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IViDiELClassifyService)P_0).Train();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void rAKfJIDomad75fgl62F(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IProgressReporter)P_0).Report((string)P_1, (ProgressAmount)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JCxIDIDDi6Hy7mB6UtT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vlwoLgD8w97AGpTVFcE()
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
	private struct _003CReportImportResults_003Ed__162 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public bool success;

		public int actual;

		public int expected;

		public string failureMessage;

		public Classifier _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			Classifier sender = default;
			bool result = default;
			int num2 = default;
			Cognex.Foundations.Mvvm.Common.BaseMessageViewModel viewModel = default;
			TaskAwaiter<bool> awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					sender = _003C_003E4__this;
					hc8OZiDcow39SYPl3ws();
					if (!h9ar8EDu84vZcjOwyMH())
					{
						num = 0;
						break;
					}
					num = 1;
					if (true)
					{
						break;
					}
					return;
				default:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					break;
				case 0:
				case 2:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (success)
							{
								hc8OZiDcow39SYPl3ws();
								if (!h9ar8EDu84vZcjOwyMH())
								{
									num3 = 6;
								}
								else
								{
									num3 = 4;
									if (1 == 0)
									{
										goto IL_01a3;
									}
								}
							}
							else
							{
								Cognex.Foundations.Mvvm.Common.ErrorMessageViewModel errorMessageViewModel = new Cognex.Foundations.Mvvm.Common.ErrorMessageViewModel();
								q9gvoRDqFt9nPC6saj6(errorMessageViewModel, CjDJ8TDQfbG783dRtEP());
								U2L78XDUkTOmHeGdTXs(errorMessageViewModel, OG7h6RDhGtD6ZLjF1Ka(wrZIl3DxJhNxDDyBhRj(), actual, expected, failureMessage));
								viewModel = errorMessageViewModel;
								num3 = 9;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 5;
						}
						goto IL_0115;
						IL_01a3:
						_003C_003Eu__1 = awaiter;
						num3 = 2;
						goto IL_0115;
						IL_0115:
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 4:
							case 9:
								awaiter = ((IViewModelBroadcaster)OMVRhSDVnVLpUpj4b90()).Broadcast(sender, viewModel).GetAwaiter();
								num3 = 10;
								if (!h9ar8EDu84vZcjOwyMH())
								{
									continue;
								}
								goto case 5;
							case 5:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 11;
								continue;
							case 3:
								return;
							case 10:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto case 11;
							case 8:
								num2 = (_003C_003E1__state = 0);
								break;
							default:
								num3 = 7;
								continue;
							case 0:
							case 6:
							{
								InformationalMessageViewModel informationalMessageViewModel = new InformationalMessageViewModel
								{
									Heading = (string)H1yrSFDBOLYVlfBW1l6()
								};
								U2L78XDUkTOmHeGdTXs(informationalMessageViewModel, OG7h6RDhGtD6ZLjF1Ka(wrZIl3DxJhNxDDyBhRj(), actual, expected, failureMessage));
								viewModel = informationalMessageViewModel;
								goto case 1;
							}
							case 7:
								break;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								continue;
							case 11:
								result = awaiter.GetResult();
								goto end_IL_0115;
							}
							goto IL_01a3;
							continue;
							end_IL_0115:
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
		internal static object H1yrSFDBOLYVlfBW1l6()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ImportResultsSuccess;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wrZIl3DxJhNxDDyBhRj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ImportResultsMessage;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OG7h6RDhGtD6ZLjF1Ka(object P_0, object P_1, object P_2, object P_3)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return string.Format((string)P_0, P_1, P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void U2L78XDUkTOmHeGdTXs(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Cognex.Foundations.Mvvm.Common.BaseMessageViewModel)P_0).Message = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CjDJ8TDQfbG783dRtEP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ImportResultsFailure;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void q9gvoRDqFt9nPC6saj6(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Cognex.Foundations.Mvvm.Common.BaseMessageViewModel)P_0).Heading = (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OMVRhSDVnVLpUpj4b90()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ViewModelBroadcaster.Default;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hc8OZiDcow39SYPl3ws()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool h9ar8EDu84vZcjOwyMH()
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
	private struct _003CDoImportImages_003Ed__164 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public IEnumerable<string> fileNames;

		public Classifier _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<string[]> _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HWALOGDiSxEUmgjK920();
			int num = (Hml7I2DLnTwqZnjrkcm() ? 4 : 3);
			Classifier classifier = default;
			int num2 = default;
			TaskAwaiter<string[]> awaiter2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					classifier = _003C_003E4__this;
					num = 2;
					continue;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
				case 2:
					try
					{
						TaskAwaiter awaiter;
						if (num2 == 0)
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_00f1;
						}
						if (num2 == 1)
						{
							goto IL_00fe;
						}
						if (fileNames != null)
						{
							if (classifier.pLu4jtXb7 != null)
							{
								IUndoAction undoAction = new UndoImport(classifier.pLu4jtXb7, fileNames.ToList());
								awaiter = SUeCaSDvW9m59pq8qCy(SGYXaSD9BaKNmI84B6Q(Uat8pXDte8rTsfGLqx5(classifier.xkMbRK87y), undoAction));
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_00f1;
							}
							goto IL_00fe;
						}
						goto end_IL_0050;
						IL_00f1:
						awaiter.GetResult();
						goto end_IL_0050;
						IL_00fe:
						try
						{
							int num3;
							if (num2 != 1)
							{
								num3 = 7;
								if (Hml7I2DLnTwqZnjrkcm())
								{
								}
								goto IL_0166;
							}
							awaiter2 = _003C_003Eu__2;
							goto IL_01f1;
							IL_01f1:
							_003C_003Eu__2 = default;
							num3 = 0;
							if (!HWALOGDiSxEUmgjK920())
							{
								return;
							}
							goto IL_0166;
							IL_0166:
							while (true)
							{
								switch (num3)
								{
								case 2:
									if (!awaiter2.IsCompleted)
									{
										num3 = 9;
										continue;
									}
									goto case 10;
								case 7:
									awaiter2 = classifier.beG6cP0CX(fileNames).GetAwaiter();
									num3 = 2;
									continue;
								case 1:
									_003C_003Eu__2 = awaiter2;
									goto case 3;
								default:
									num3 = 3;
									if (0 == 0)
									{
										continue;
									}
									goto case 3;
								case 3:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									Hml7I2DLnTwqZnjrkcm();
									if (HWALOGDiSxEUmgjK920())
									{
										num3 = 8;
										continue;
									}
									num3 = 4;
									if (Hml7I2DLnTwqZnjrkcm())
									{
									}
									continue;
								case 0:
									num2 = (_003C_003E1__state = -1);
									num3 = 10;
									continue;
								case 9:
									num2 = (_003C_003E1__state = 1);
									num3 = 1;
									continue;
								case 4:
								case 6:
									break;
								case 5:
								case 8:
									return;
								case 10:
									awaiter2.GetResult();
									goto end_IL_0166;
								}
								goto IL_01f1;
								continue;
								end_IL_0166:
								break;
							}
						}
						catch (UndoActionCanceledException)
						{
						}
						end_IL_0050:;
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
					num = 5;
					if (true)
					{
						continue;
					}
					break;
				case 5:
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
		internal static object Uat8pXDte8rTsfGLqx5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SGYXaSD9BaKNmI84B6Q(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter SUeCaSDvW9m59pq8qCy(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HWALOGDiSxEUmgjK920()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Hml7I2DLnTwqZnjrkcm()
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
	private struct _003C_DoImportImages_003Ed__165 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string[]> _003C_003Et__builder;

		public IEnumerable<string> fileNames;

		public Classifier _003C_003E4__this;

		private List<string> _003CnewIds_003E5__2;

		private int _003CimageCount_003E5__3;

		private int _003CsuccessCount_003E5__4;

		private List<string> _003CfailedImages_003E5__5;

		private bool _003Ccanceled_003E5__6;

		private ITopLevelProgressableOperation _003Coperation_003E5__7;

		private IDisposable _003C_003E7__wrap7;

		private string[] _003CbeforeUnlabeledImageIds_003E5__9;

		private int _003CimageIndex_003E5__10;

		private TaskAwaiter<string[]> _003C_003Eu__1;

		private IEnumerator<string> _003C_003E7__wrap10;

		private string _003CshortPath_003E5__12;

		private MemoryStream _003Cstream_003E5__13;

		private TaskAwaiter _003C_003Eu__2;

		private Bitmap _003Cbmp_003E5__14;

		private TaskAwaiter<bool> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			if (false)
			{
				goto IL_001a;
			}
			goto IL_0bd2;
			IL_0032:
			int num2 = _003C_003E1__state;
			num = 0;
			if (1 == 0)
			{
				goto IL_0045;
			}
			goto IL_0bd2;
			IL_0bd2:
			Classifier classifier = default;
			string[] result = default;
			string current2 = default;
			TaskAwaiter awaiter = default;
			string text = default;
			bool flag = default;
			TaskAwaiter<bool> awaiter3 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					break;
				case 6:
					goto IL_0032;
				case 0:
					goto IL_0045;
				case 3:
					_003CfailedImages_003E5__5 = null;
					break;
				case 2:
				case 4:
					try
					{
						List<string>.Enumerator enumerator;
						switch (num2)
						{
						default:
							_003CnewIds_003E5__2 = new List<string>();
							if (fileNames != null)
							{
								_003CimageCount_003E5__3 = fileNames.Count();
								_003CsuccessCount_003E5__4 = 0;
								_003CfailedImages_003E5__5 = new List<string>();
								_003Ccanceled_003E5__6 = false;
								IOperationProgressManager operationProgressManager = classifier.OperationProgressManager;
								_003Coperation_003E5__7 = (ITopLevelProgressableOperation)((operationProgressManager != null) ? gN31GlDTOov3INHfFXM(operationProgressManager, KfMnpUDH1fG3a8cSgPu(), Array.Empty<StepDescriptor>()) : null);
								goto case 0;
							}
							result = (string[])U479cLDO32bhmGG5QE0(_003CnewIds_003E5__2);
							goto end_IL_007d;
						case 0:
						case 1:
						case 2:
						case 3:
						case 4:
						case 5:
						case 6:
							try
							{
								switch (num2)
								{
								default:
									_003C_003E7__wrap7 = (IDisposable)xFvkNhDYW72ypvTc2jN(classifier.W0mIN5JmIs);
									goto case 0;
								case 0:
								case 1:
								case 2:
								case 3:
								case 4:
									try
									{
										TaskAwaiter<string[]> awaiter2;
										string[] result2;
										switch (num2)
										{
										default:
											awaiter2 = classifier.HxYHPrlul().GetAwaiter();
											if (!awaiter2.IsCompleted)
											{
												num2 = (_003C_003E1__state = 0);
												_003C_003Eu__1 = awaiter2;
												_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
												return;
											}
											goto IL_01c9;
										case 0:
											awaiter2 = _003C_003Eu__1;
											_003C_003Eu__1 = default;
											num2 = (_003C_003E1__state = -1);
											goto IL_01c9;
										case 1:
										case 2:
										case 3:
											try
											{
												if ((uint)(num2 - 1) <= 2u)
												{
													goto IL_0291;
												}
												goto IL_063f;
												IL_063f:
												if (nITsJjDRAdeQaGwv4x3(_003C_003E7__wrap10))
												{
													current2 = _003C_003E7__wrap10.Current;
													ITopLevelProgressableOperation topLevelProgressableOperation = _003Coperation_003E5__7;
													_003Ccanceled_003E5__6 = topLevelProgressableOperation != null && AIJxXWDJHLyouhyv56V(topLevelProgressableOperation).IsCancellationRequested;
													if (!_003Ccanceled_003E5__6)
													{
														_003CshortPath_003E5__12 = classifier.vU3ilu7v4(current2, 40);
														ITopLevelProgressableOperation topLevelProgressableOperation2 = _003Coperation_003E5__7;
														if (topLevelProgressableOperation2 != null)
														{
															KvujKqDK3daRsptaYTB(topLevelProgressableOperation2, _003CshortPath_003E5__12, new ProgressAmount(_003CimageIndex_003E5__10++, _003CimageCount_003E5__3 + 1));
														}
														goto IL_0291;
													}
												}
												goto end_IL_01f3;
												IL_0291:
												try
												{
													switch (num2)
													{
													default:
														if ((string)LWYPOkDC8qHZkgHiLcO(current2) == (string)O4cjLiDAlHiJhOoNJ2u(6854))
														{
															_003Cstream_003E5__13 = new MemoryStream((byte[])GE1qwLDNDdQVa5Jobjm(current2));
															goto case 1;
														}
														_003Cbmp_003E5__14 = classifier.X7vnr2ESJ(current2);
														goto case 2;
													case 1:
														try
														{
															int num5;
															if (num2 != 1)
															{
																num5 = 8;
															}
															else
															{
																awaiter = _003C_003Eu__2;
																num5 = 6;
															}
															while (true)
															{
																switch (num5)
																{
																case 2:
																case 9:
																	num2 = (_003C_003E1__state = 1);
																	num5 = 7;
																	continue;
																case 1:
																	_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
																	return;
																case 5:
																	return;
																case 6:
																	_003C_003Eu__2 = default;
																	num5 = 0;
																	continue;
																case 8:
																	awaiter = ((Task)uVndVfDwAdOlLUq6ylW(classifier.xkMbRK87y.CogSocket, _003Cstream_003E5__13)).GetAwaiter();
																	num5 = 4;
																	continue;
																case 3:
																	return;
																case 0:
																	num2 = (_003C_003E1__state = -1);
																	num5 = 10;
																	if (0 == 0)
																	{
																		continue;
																	}
																	goto case 4;
																case 4:
																	if (!awaiter.IsCompleted)
																	{
																		AICO0qD006Ijaoe50fs();
																		num5 = (PtVQNVDZjmyuSEgKxAD() ? 9 : 3);
																		continue;
																	}
																	break;
																case 7:
																	_003C_003Eu__2 = awaiter;
																	goto case 1;
																default:
																	num5 = 1;
																	continue;
																case 10:
																	break;
																}
																break;
															}
															awaiter.GetResult();
														}
														finally
														{
															if (num2 < 0 && _003Cstream_003E5__13 != null)
															{
																((IDisposable)_003Cstream_003E5__13).Dispose();
															}
														}
														_003Cstream_003E5__13 = null;
														goto IL_05a4;
													case 2:
														try
														{
															int num4;
															if (num2 != 2)
															{
																num4 = 8;
																goto IL_0510;
															}
															awaiter = _003C_003Eu__2;
															goto IL_0475;
															IL_0475:
															_003C_003Eu__2 = default;
															num4 = 5;
															goto IL_0510;
															IL_0510:
															while (true)
															{
																switch (num4)
																{
																case 1:
																	num2 = (_003C_003E1__state = 2);
																	num4 = 0;
																	continue;
																case 5:
																	num2 = (_003C_003E1__state = -1);
																	num4 = 10;
																	continue;
																case 3:
																case 6:
																	break;
																case 7:
																	return;
																case 2:
																	if (!awaiter.IsCompleted)
																	{
																		num4 = 1;
																		continue;
																	}
																	goto case 10;
																case 8:
																{
																	CvsCogSocket cogSocket = classifier.xkMbRK87y.CogSocket;
																	Bitmap bmp = _003Cbmp_003E5__14;
																	string imageName = current2;
																	awaiter = KBIQrkDpZ4oSdiZf3yf(cogSocket.PostImageByHTTPAndRunSheetAsync(bmp, null, imageName, sync: true));
																	num4 = 2;
																	continue;
																}
																case 0:
																	_003C_003Eu__2 = awaiter;
																	goto default;
																default:
																	AICO0qD006Ijaoe50fs();
																	num4 = (PtVQNVDZjmyuSEgKxAD() ? 9 : 3);
																	continue;
																case 4:
																case 9:
																	_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
																	num4 = 7;
																	continue;
																case 10:
																	awaiter.GetResult();
																	goto end_IL_0510;
																}
																goto IL_0475;
																continue;
																end_IL_0510:
																break;
															}
														}
														finally
														{
															if (num2 < 0 && _003Cbmp_003E5__14 != null)
															{
																EZ8K04DGNBR2RxJodla(_003Cbmp_003E5__14);
															}
														}
														_003Cbmp_003E5__14 = null;
														goto IL_05a4;
													case 3:
														{
															awaiter = _003C_003Eu__2;
															_003C_003Eu__2 = default;
															num2 = (_003C_003E1__state = -1);
															break;
														}
														IL_05a4:
														awaiter = classifier.ClassifyService.AddCurrentImageToUnlabeled().GetAwaiter();
														if (!awaiter.IsCompleted)
														{
															num2 = (_003C_003E1__state = 3);
															_003C_003Eu__2 = awaiter;
															_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
															return;
														}
														break;
													}
													awaiter.GetResult();
													_003CsuccessCount_003E5__4++;
												}
												catch (Exception)
												{
													_003CfailedImages_003E5__5.Add(_003CshortPath_003E5__12);
												}
												_003CshortPath_003E5__12 = null;
												goto IL_063f;
												end_IL_01f3:;
											}
											finally
											{
												if (num2 < 0 && _003C_003E7__wrap10 != null)
												{
													EZ8K04DGNBR2RxJodla(_003C_003E7__wrap10);
												}
											}
											_003C_003E7__wrap10 = null;
											awaiter2 = classifier.HxYHPrlul().GetAwaiter();
											if (!awaiter2.IsCompleted)
											{
												num2 = (_003C_003E1__state = 4);
												_003C_003Eu__1 = awaiter2;
												_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
												return;
											}
											break;
										case 4:
											{
												awaiter2 = _003C_003Eu__1;
												_003C_003Eu__1 = default;
												num2 = (_003C_003E1__state = -1);
												break;
											}
											IL_01c9:
											result2 = awaiter2.GetResult();
											_003CbeforeUnlabeledImageIds_003E5__9 = result2;
											_003CimageIndex_003E5__10 = 1;
											_003C_003E7__wrap10 = fileNames.GetEnumerator();
											goto case 1;
										}
										result2 = awaiter2.GetResult();
										foreach (string text2 in result2)
										{
											if (!_003CbeforeUnlabeledImageIds_003E5__9.Contains(text2))
											{
												_003CnewIds_003E5__2.Add(text2);
											}
										}
										_003CbeforeUnlabeledImageIds_003E5__9 = null;
									}
									finally
									{
										if (num2 < 0 && _003C_003E7__wrap7 != null)
										{
											_003C_003E7__wrap7.Dispose();
										}
									}
									_003C_003E7__wrap7 = null;
									awaiter = classifier.RefreshUnlabeledImages().GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 5);
										_003C_003Eu__2 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									goto IL_07a6;
								case 5:
									awaiter = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									goto IL_07a6;
								case 6:
									{
										awaiter = _003C_003Eu__2;
										_003C_003Eu__2 = default;
										num2 = (_003C_003E1__state = -1);
										break;
									}
									IL_07a6:
									awaiter.GetResult();
									awaiter = KBIQrkDpZ4oSdiZf3yf(classifier.RefreshUnlabeledImagePredictions());
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 6);
										_003C_003Eu__2 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									break;
								}
								awaiter.GetResult();
							}
							finally
							{
								if (num2 < 0 && _003Coperation_003E5__7 != null)
								{
									EZ8K04DGNBR2RxJodla(_003Coperation_003E5__7);
								}
							}
							_003Coperation_003E5__7 = null;
							if (_003Ccanceled_003E5__6 && M3m98lDj2QgftVhx3vS(_003CnewIds_003E5__2) > 0)
							{
								IEnumerable<ClassifyImage> imagesFromIds = classifier.GetImagesFromIds(_003CnewIds_003E5__2.ToArray());
								awaiter = classifier.FQt30A3AL(imagesFromIds, Resources.ImportCleanup).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 7);
									_003C_003Eu__2 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_08c8;
							}
							goto IL_08e1;
						case 7:
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default;
							num2 = (_003C_003E1__state = -1);
							goto IL_08c8;
						case 8:
							break;
							IL_08e1:
							text = "";
							flag = true;
							if (_003CimageCount_003E5__3 <= _003CsuccessCount_003E5__4 && _003CimageCount_003E5__3 != 0)
							{
								break;
							}
							flag = false;
							if (_003Ccanceled_003E5__6)
							{
								text = (string)jTYMZ7DWEbYSZ365JjM(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(6866), EymBEpDIiKKuOoAZpqK());
								break;
							}
							if (_003CimageCount_003E5__3 == 0)
							{
								text = (string)jTYMZ7DWEbYSZ365JjM(O4cjLiDAlHiJhOoNJ2u(6866), xQNAwSDb8pZ0jHCJmmQ());
								break;
							}
							text = (string)O4cjLiDAlHiJhOoNJ2u(6866) + (string)MsDdniDevC5ZL7udFNi() + (string)O4cjLiDAlHiJhOoNJ2u(6874);
							enumerator = _003CfailedImages_003E5__5.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									string current = enumerator.Current;
									_ = 0;
									int num3;
									if (PtVQNVDZjmyuSEgKxAD())
									{
										num3 = 2;
										if (1 == 0)
										{
											goto IL_09a5;
										}
									}
									else
									{
										num3 = 3;
									}
									switch (num3)
									{
									case 0:
									case 2:
										break;
									default:
										continue;
									}
									goto IL_09a5;
									IL_09a5:
									text = text + current + (string)O4cjLiDAlHiJhOoNJ2u(6874);
								}
							}
							finally
							{
								if (num2 < 0)
								{
									((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
								}
							}
							break;
							IL_08c8:
							awaiter.GetResult();
							_003CsuccessCount_003E5__4 = 0;
							_003CnewIds_003E5__2 = new List<string>();
							goto IL_08e1;
						}
						try
						{
							int num6;
							if (num2 != 8)
							{
								num6 = 0;
							}
							else
							{
								awaiter3 = _003C_003Eu__3;
								num6 = 3;
							}
							while (true)
							{
								switch (num6)
								{
								case 9:
									num2 = (_003C_003E1__state = 8);
									num6 = 4;
									continue;
								case 6:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								case 5:
									return;
								case 1:
								case 8:
									if (!awaiter3.IsCompleted)
									{
										num6 = 9;
										continue;
									}
									break;
								case 3:
									_003C_003Eu__3 = default;
									num6 = 7;
									continue;
								case 7:
									num2 = (_003C_003E1__state = -1);
									num6 = 10;
									if (0 == 0)
									{
										continue;
									}
									goto case 4;
								case 4:
									_003C_003Eu__3 = awaiter3;
									goto case 6;
								default:
									num6 = 6;
									if (!AICO0qD006Ijaoe50fs())
									{
										continue;
									}
									goto case 0;
								case 0:
									awaiter3 = classifier.HknrmeWHh(_003CsuccessCount_003E5__4, _003CimageCount_003E5__3, flag, text).GetAwaiter();
									_ = 1;
									num6 = ((!AICO0qD006Ijaoe50fs()) ? 8 : 2);
									continue;
								case 2:
									return;
								case 10:
									break;
								}
								break;
							}
							awaiter3.GetResult();
						}
						catch (InvalidOperationException)
						{
						}
						if (_003Ccanceled_003E5__6)
						{
							throw new UndoActionCanceledException((string)RNXe1eDlrZqckOiVhbT());
						}
						result = _003CnewIds_003E5__2.ToArray();
						end_IL_007d:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CnewIds_003E5__2 = null;
						_003CfailedImages_003E5__5 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					num = 7;
					if (PtVQNVDZjmyuSEgKxAD())
					{
						continue;
					}
					goto case 7;
				case 7:
					_003CnewIds_003E5__2 = null;
					goto case 3;
				default:
					num = 3;
					if (PtVQNVDZjmyuSEgKxAD())
					{
						continue;
					}
					return;
				case 8:
					return;
				}
				break;
			}
			goto IL_001a;
			IL_0045:
			classifier = _003C_003E4__this;
			AICO0qD006Ijaoe50fs();
			num = ((!PtVQNVDZjmyuSEgKxAD()) ? 1 : 4);
			goto IL_0bd2;
			IL_001a:
			_003C_003Et__builder.SetResult(result);
			num = 8;
			if (false)
			{
				goto IL_0032;
			}
			goto IL_0bd2;
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
		internal static object U479cLDO32bhmGG5QE0(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((List<string>)P_0).ToArray();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KfMnpUDH1fG3a8cSgPu()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.AddImages;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gN31GlDTOov3INHfFXM(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IOperationProgressManager)P_0).StartCancellableBlockingOperation((string)P_1, (StepDescriptor[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xFvkNhDYW72ypvTc2jN(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ScopedCounter)P_0).Increment();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CancellationToken AIJxXWDJHLyouhyv56V(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IProgressReporter)P_0).CancellationToken;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void KvujKqDK3daRsptaYTB(object P_0, object P_1, object P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IProgressReporter)P_0).Report((string)P_1, (ProgressAmount)P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LWYPOkDC8qHZkgHiLcO(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Path.GetExtension((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object O4cjLiDAlHiJhOoNJ2u(int P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GE1qwLDNDdQVa5Jobjm(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return File.ReadAllBytes((string)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object uVndVfDwAdOlLUq6ylW(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogSocket)P_0).PostPointCloudByHTTPAsync((Stream)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter KBIQrkDpZ4oSdiZf3yf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void EZ8K04DGNBR2RxJodla(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nITsJjDRAdeQaGwv4x3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int M3m98lDj2QgftVhx3vS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((List<string>)P_0).Count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EymBEpDIiKKuOoAZpqK()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ImportCanceled;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object jTYMZ7DWEbYSZ365JjM(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 + (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xQNAwSDb8pZ0jHCJmmQ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.NoImagesFound;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MsDdniDevC5ZL7udFNi()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.FailedImagesMessage;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RNXe1eDlrZqckOiVhbT()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Resources.ImportWasCanceled;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PtVQNVDZjmyuSEgKxAD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AICO0qD006Ijaoe50fs()
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
	private struct _003CGetUnlabeledImageIDs_003Ed__167 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string[]> _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		private TaskAwaiter<string[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = (cJ7w4VDyWgKYYZsgTXf() ? 2 : 3);
			Classifier classifier = default;
			string[] result = default;
			int num2 = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 2:
					classifier = _003C_003E4__this;
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 4;
				case 4:
					_003C_003Et__builder.SetResult(result);
					num = 6;
					break;
				case 5:
					try
					{
						TaskAwaiter<string[]> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = classifier.ClassifyService.GetImageIds("").GetAwaiter();
							num3 = 1;
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
							case 6:
								_003C_003Eu__1 = awaiter;
								num3 = 7;
								continue;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								break;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 0:
								_003C_003Eu__1 = default;
								num3 = 5;
								continue;
							default:
								return;
							case 3:
								return;
							case 8:
								num2 = (_003C_003E1__state = 0);
								_ = 0;
								if (XRY9apD7NmfINMrofor())
								{
									num3 = 6;
									if (cJ7w4VDyWgKYYZsgTXf())
									{
									}
								}
								else
								{
									num3 = 3;
								}
								continue;
							case 7:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 9:
								break;
							}
							break;
						}
						result = awaiter.GetResult();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 4;
				default:
					num = 4;
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
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
		internal static bool XRY9apD7NmfINMrofor()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cJ7w4VDyWgKYYZsgTXf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass170_0
	{
		public string[] ids;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass170_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
			RKys4BDzaCgnwOtcdJT(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CGetImagesFromIds_003Eb__1(ClassifyImage img)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ids.Contains((string)XHUed182JtCLt8uX5RZ(img));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RKys4BDzaCgnwOtcdJT(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool saXN8cDnUYnIenMgaZX()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QaMkXLDfonsnmThaxMy()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XHUed182JtCLt8uX5RZ(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassifyImage)P_0).ImageId;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass171_0
	{
		public object sender;

		public Func<ImageListViewModel, bool> _003C_003E9__0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass171_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			x8AGME8kkg5CEtTxrgj();
			KgJxC68mYXCnyvA50l2(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CSelectedImages_CollectionChanged_003Eb__0(ImageListViewModel category)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return sender != category.SelectedImages;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void x8AGME8kkg5CEtTxrgj()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void KgJxC68mYXCnyvA50l2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IONYpR8X6Y2GnlMhPi1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IIYCy28M1qtpInMwfD8()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass172_0
	{
		public string[] classNames;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass172_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CRefreshClasses_003Eb__2(ClassViewModel classItem)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_003C_003Ec__DisplayClass172_2 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass172_2();
			CS_0024_003C_003E8__locals2.classItem = classItem;
			return !classNames.Any([MethodImpl(MethodImplOptions.NoInlining)] (string u) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003Ec__DisplayClass172_2.L3x6q38EGoksYO0xiWp(u, CS_0024_003C_003E8__locals2.classItem.ClassName);
			});
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool y9wBt78rvsIoFpp0y4S()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool O7DSAc8PmTbtyCEYRga()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass172_1
	{
		public string className;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass172_1()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			AJHtpJ81TlCNQARi6ST();
			BK9wUF8SvZB273pT8Ia(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CRefreshClasses_003Eb__3(ClassViewModel u)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return w2kMJt8D887KmIxoCyI(MYnkBb86F1dy9jRd2no(u), className);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void AJHtpJ81TlCNQARi6ST()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BK9wUF8SvZB273pT8Ia(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GPXhgK84BoDiNMiWyqg()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool J5wAyU8g0PyXdFZLdlr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MYnkBb86F1dy9jRd2no(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassViewModel)P_0).ClassName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool w2kMJt8D887KmIxoCyI(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass172_2
	{
		public ClassViewModel classItem;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass172_2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			uWjRk78swJT6Ixu9Nyc();
			y4CDKp8dtE0LP1LVTXp(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CRefreshClasses_003Eb__4(string u)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return L3x6q38EGoksYO0xiWp(u, classItem.ClassName);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void uWjRk78swJT6Ixu9Nyc()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void y4CDKp8dtE0LP1LVTXp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uTQ4Tc88JMGYwFNmipW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EFvKyx8FcAMUmWdrF8c()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool L3x6q38EGoksYO0xiWp(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRefreshClasses_003Ed__172 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		private _003C_003Ec__DisplayClass172_0 _003C_003E8__1;

		private IDisposable _003C_003E7__wrap1;

		private TaskAwaiter<string[]> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			Classifier classifier = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					try
					{
						if ((uint)num2 > 2u)
						{
							_003C_003E7__wrap1 = classifier.YtoIVacrNb.Increment();
						}
						try
						{
							TaskAwaiter<string[]> awaiter2;
							TaskAwaiter awaiter;
							string[] result;
							switch (num2)
							{
							default:
								_003C_003E8__1 = new _003C_003Ec__DisplayClass172_0();
								if (yqxl0Q8aemqPLxil7lo(classifier.YtoIVacrNb) <= 1)
								{
									awaiter2 = classifier.ClassifyService.GetClassLabels().GetAwaiter();
									if (!awaiter2.IsCompleted)
									{
										num2 = (_003C_003E1__state = 0);
										_003C_003Eu__1 = awaiter2;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										return;
									}
									goto IL_00c0;
								}
								goto end_IL_0031;
							case 0:
								awaiter2 = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_00c0;
							case 1:
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_03b4;
							case 2:
								{
									awaiter = _003C_003Eu__2;
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									break;
								}
								IL_03b4:
								awaiter.GetResult();
								goto IL_03cb;
								IL_03cb:
								classifier.ClassNames = new List<string>(classifier.Classes.Select([MethodImpl(MethodImplOptions.NoInlining)] (ClassViewModel classItem) =>
								{
									while (false)
									{
										_ = ((object[])null)[0];
									}
									return (string)_003C_003Ec.H2sa3S1mpuIDNe6MDnt(classItem);
								}));
								awaiter = plfhHP8QMZOUSgte4vP(classifier.RefreshJobFailClasses());
								if (!awaiter.IsCompleted)
								{
									num2 = (_003C_003E1__state = 2);
									_003C_003Eu__2 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								break;
								IL_00c0:
								result = awaiter2.GetResult();
								_003C_003E8__1.classNames = result;
								if (_003C_003E8__1.classNames != null && _003C_003E8__1.classNames.Length != 0)
								{
									bool flag = false;
									IEnumerable<string> enumerable = _003C_003E8__1.classNames.Where(classifier.qonyDd0Ur);
									IEnumerator<ClassViewModel> enumerator = classifier.Classes.ToList().Where([MethodImpl(MethodImplOptions.NoInlining)] (ClassViewModel classItem) =>
									{
										while (false)
										{
											_ = ((object[])null)[0];
										}
										_003C_003Ec__DisplayClass172_2 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass172_2();
										CS_0024_003C_003E8__locals2.classItem = classItem;
										return !_003C_003E8__1.classNames.Any([MethodImpl(MethodImplOptions.NoInlining)] (string u) =>
										{
											while (false)
											{
												_ = ((object[])null)[0];
											}
											return _003C_003Ec__DisplayClass172_2.L3x6q38EGoksYO0xiWp(u, CS_0024_003C_003E8__locals2.classItem.ClassName);
										});
									}).GetEnumerator();
									try
									{
										while (UsVemV8xHGTm4DO2MQ2(enumerator))
										{
											ClassViewModel current = enumerator.Current;
											List<ClassifyImage>.Enumerator enumerator2 = ((IEnumerable<ClassifyImage>)NyDr5s8otrcOEIh0sHr(current)).ToList().GetEnumerator();
											try
											{
												while (enumerator2.MoveNext())
												{
													T5DX6H8cXbCv2ULOeg5(enumerator2.Current);
												}
											}
											finally
											{
												if (num2 < 0)
												{
													((IDisposable)enumerator2/*cast due to constrained. prefix*/).Dispose();
												}
											}
											enumerator2 = current.LabeledImages.ToList().GetEnumerator();
											try
											{
												while (enumerator2.MoveNext())
												{
													enumerator2.Current.ClearPrediction();
												}
											}
											finally
											{
												if (num2 < 0)
												{
													((IDisposable)enumerator2/*cast due to constrained. prefix*/).Dispose();
												}
											}
											classifier.Classes.Remove(current);
											((ImageListViewModel)cmWVHe8uGVKQ9kQ1PtL(current)).SelectedImages.CollectionChanged -= classifier.JW4pEca9M;
											PMUvTN8Blb1KATlcY5Q(((ImageListViewModel)NyDr5s8otrcOEIh0sHr(current)).SelectedImages, new NotifyCollectionChangedEventHandler(classifier.JW4pEca9M));
											flag = true;
										}
									}
									finally
									{
										if (num2 < 0)
										{
											enumerator?.Dispose();
										}
									}
									IEnumerator<string> enumerator3 = enumerable.GetEnumerator();
									try
									{
										while (enumerator3.MoveNext())
										{
											ClassViewModel classViewModel = new ClassViewModel(enumerator3.Current, classifier);
											_ = 0;
											int num3 = ((!x2FYVJ85S2V8QaZiZmP()) ? 2 : 3);
											while (true)
											{
												switch (num3)
												{
												case 1:
												case 2:
													E8XhD68htE7dgFV42yn(((ImageListViewModel)NyDr5s8otrcOEIh0sHr(classViewModel)).SelectedImages, new NotifyCollectionChangedEventHandler(classifier.JW4pEca9M));
													goto case 4;
												default:
													num3 = 4;
													continue;
												case 0:
												case 3:
													E8XhD68htE7dgFV42yn(classViewModel.LabeledImages.SelectedImages, new NotifyCollectionChangedEventHandler(classifier.JW4pEca9M));
													goto case 1;
												case 5:
													flag = true;
													num3 = 6;
													continue;
												case 4:
													classifier.AddClassSorted(classViewModel);
													num3 = 5;
													continue;
												case 6:
													break;
												}
												break;
											}
										}
									}
									finally
									{
										if (num2 < 0 && enumerator3 != null)
										{
											viLc138UlN9Xvj2JjT6(enumerator3);
										}
									}
									if (flag)
									{
										awaiter = plfhHP8QMZOUSgte4vP(classifier.uoda3OXyX());
										if (!awaiter.IsCompleted)
										{
											num2 = (_003C_003E1__state = 1);
											_003C_003Eu__2 = awaiter;
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											return;
										}
										goto IL_03b4;
									}
								}
								else
								{
									jvpSaf8qvgLLCCstn5r(classifier.Classes);
								}
								goto IL_03cb;
							}
							awaiter.GetResult();
							_003C_003E8__1 = null;
							goto IL_048e;
							end_IL_0031:;
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								viLc138UlN9Xvj2JjT6(_003C_003E7__wrap1);
							}
						}
						goto end_IL_0018;
						IL_048e:
						_003C_003E7__wrap1 = null;
						end_IL_0018:;
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
				case 5:
					num2 = _003C_003E1__state;
					_ = 1;
					if (!QM1IEV837QrqLuKH1ZD())
					{
						num = 3;
						continue;
					}
					num = 0;
					if (!QM1IEV837QrqLuKH1ZD())
					{
						continue;
					}
					break;
				case 1:
				case 3:
					classifier = _003C_003E4__this;
					goto case 0;
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
		internal static int yqxl0Q8aemqPLxil7lo(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ScopedCounter)P_0).Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object NyDr5s8otrcOEIh0sHr(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassViewModel)P_0).UnlabeledImages;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void T5DX6H8cXbCv2ULOeg5(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ClassifyImage)P_0).ClearPrediction();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object cmWVHe8uGVKQ9kQ1PtL(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassViewModel)P_0).LabeledImages;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PMUvTN8Blb1KATlcY5Q(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ObservableCollection<ClassifyImage>)P_0).CollectionChanged -= (NotifyCollectionChangedEventHandler)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UsVemV8xHGTm4DO2MQ2(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void E8XhD68htE7dgFV42yn(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ObservableCollection<ClassifyImage>)P_0).CollectionChanged += (NotifyCollectionChangedEventHandler)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void viLc138UlN9Xvj2JjT6(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter plfhHP8QMZOUSgte4vP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void jvpSaf8qvgLLCCstn5r(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((Collection<ClassViewModel>)P_0).Clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool x2FYVJ85S2V8QaZiZmP()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QM1IEV837QrqLuKH1ZD()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass173_0
	{
		public string[] failClassNames;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass173_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			NX9cBG8Lny2KHjP56aR();
			eGvBRH8tGto41GDaTpE(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _003CRefreshJobFailClasses_003Eb__0(ClassViewModel c)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			rPGr5e8vPZ4SZ2PE56L(pN2oEE890h9I34Tb8eP(c), failClassNames.Contains(c.ClassName));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NX9cBG8Lny2KHjP56aR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void eGvBRH8tGto41GDaTpE(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LwmwDb8V6Hoa6E1cy88()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool l29jw18iEJEmTTehXYW()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object pN2oEE890h9I34Tb8eP(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassViewModel)P_0).ClassResult;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void rPGr5e8vPZ4SZ2PE56L(object P_0, bool value)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((ClassResultViewModel)P_0).IsFailClass = value;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRefreshJobFailClasses_003Ed__173 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		private _003C_003Ec__DisplayClass173_0 _003C_003E8__1;

		private TaskAwaiter<string[]> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 3;
			if (1 == 0)
			{
				goto IL_001a;
			}
			goto IL_0248;
			IL_007c:
			int num2 = default;
			Classifier classifier = default;
			try
			{
				int num3;
				if (num2 != 0)
				{
					_003C_003E8__1 = new _003C_003Ec__DisplayClass173_0();
					num3 = 2;
					goto IL_00e6;
				}
				TaskAwaiter<string[]> awaiter = _003C_003Eu__1;
				goto IL_019e;
				IL_019e:
				_003C_003Eu__1 = default;
				num3 = 11;
				goto IL_00e6;
				IL_00e6:
				string[] result = default;
				while (true)
				{
					switch (num3)
					{
					case 1:
						_003C_003Eu__1 = awaiter;
						num3 = 7;
						continue;
					case 4:
						result = awaiter.GetResult();
						_ = 0;
						if (AfK7e08ZOAmOATYj8h7())
						{
							num3 = 0;
							if (1 == 0)
							{
								return;
							}
						}
						else
						{
							num3 = 6;
						}
						continue;
					case 5:
						return;
					default:
						num3 = 10;
						continue;
					case 3:
						num2 = (_003C_003E1__state = 0);
						num3 = 1;
						if (B0wZn080jRLXKBZQ7n2())
						{
						}
						continue;
					case 11:
						num2 = (_003C_003E1__state = -1);
						num3 = 4;
						if (AfK7e08ZOAmOATYj8h7())
						{
							continue;
						}
						goto case 7;
					case 7:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 5;
						continue;
					case 2:
						awaiter = classifier.ClassifyService.GetToolFailingClassNames().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num3 = 3;
							continue;
						}
						goto case 4;
					case 10:
						break;
					case 0:
					case 8:
						_003C_003E8__1.failClassNames = result;
						goto case 6;
					case 6:
					case 9:
						classifier.Classes.ForEach([MethodImpl(MethodImplOptions.NoInlining)] (ClassViewModel c) =>
						{
							while (false)
							{
								_ = ((object[])null)[0];
							}
							_003C_003Ec__DisplayClass173_0.rPGr5e8vPZ4SZ2PE56L(_003C_003Ec__DisplayClass173_0.pN2oEE890h9I34Tb8eP(c), _003C_003E8__1.failClassNames.Contains(c.ClassName));
						});
						num3 = 12;
						if (B0wZn080jRLXKBZQ7n2())
						{
						}
						continue;
					case 12:
						classifier.pRISqXAWO();
						goto end_IL_00e6;
					}
					goto IL_019e;
					continue;
					end_IL_00e6:
					break;
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003E8__1 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			goto IL_0069;
			IL_0248:
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 1:
				case 5:
					goto IL_0031;
				case 3:
					goto IL_0048;
				case 6:
					goto IL_0069;
				case 2:
				case 4:
					goto IL_007c;
				default:
					num = 6;
					if (true)
					{
						continue;
					}
					return;
				case 7:
					return;
				}
				break;
				IL_0048:
				num2 = _003C_003E1__state;
				AfK7e08ZOAmOATYj8h7();
				num = ((!B0wZn080jRLXKBZQ7n2()) ? 5 : 4);
			}
			goto IL_001a;
			IL_0069:
			_003C_003E8__1 = null;
			num = 0;
			if (1 == 0)
			{
				goto IL_007c;
			}
			goto IL_0248;
			IL_001a:
			_003C_003Et__builder.SetResult();
			num = 7;
			if (false)
			{
				goto IL_0031;
			}
			goto IL_0248;
			IL_0031:
			classifier = _003C_003E4__this;
			goto IL_007c;
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
		internal static bool AfK7e08ZOAmOATYj8h7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool B0wZn080jRLXKBZQ7n2()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass175_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct HrAHnqt2BRMEtY8KtG : IAsyncStateMachine
		{
			public int LLdVgep31n;

			public AsyncTaskMethodBuilder<ClassifyImage> ewfVkpOrMW;

			public _003C_003Ec__DisplayClass175_0 BVBVQ9uqjt;

			public string qsbVsq7Za4;

			private ClassifyImage hLMVbAP6AJ;

			private string y9wVwqKV16;

			private string YJSV43IoU7;

			private IViDiELClassifyService IGRVUHVEUL;

			private string IJQVzqmmHH;

			private TaskAwaiter<CvsCogImage> NrmNOUlTT2;

			private TaskAwaiter<BitmapImage> OThNI7fMM0;

			private TaskAwaiter dsrN29g3Dk;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				_ = 1;
				int num = (MSRZceijMq3paJMlxmP() ? 6 : 5);
				int num2 = default;
				_003C_003Ec__DisplayClass175_0 obj = default;
				TaskAwaiter<CvsCogImage> awaiter3 = default;
				TaskAwaiter awaiter2 = default;
				TaskAwaiter<BitmapImage> awaiter = default;
				BitmapImage result2 = default;
				ClassifyImage result = default;
				while (true)
				{
					switch (num)
					{
					case 1:
						hLMVbAP6AJ = null;
						num = 3;
						break;
					case 0:
					case 5:
						num2 = LLdVgep31n;
						num = 4;
						if (0 == 0)
						{
							break;
						}
						goto case 4;
					case 4:
						obj = BVBVQ9uqjt;
						goto case 2;
					case 2:
					case 6:
						try
						{
							int num3;
							switch (num2)
							{
							default:
								IGRVUHVEUL = obj._003C_003E4__this.ClassifyService;
								num3 = 14;
								break;
							case 0:
								awaiter3 = NrmNOUlTT2;
								_ = 1;
								num3 = ((!MSRZceijMq3paJMlxmP()) ? 2 : 4);
								break;
							case 2:
								awaiter2 = dsrN29g3Dk;
								num3 = 11;
								break;
							case 1:
								awaiter = OThNI7fMM0;
								num3 = 12;
								break;
							}
							while (true)
							{
								switch (num3)
								{
								case 20:
									awaiter2 = nlE4jfieeXPAoe0uVSf(elHeLiibweSFVZKO4LT(hLMVbAP6AJ));
									if (!awaiter2.IsCompleted)
									{
										num2 = (LLdVgep31n = 2);
										num3 = 7;
										if (true)
										{
											continue;
										}
										goto case 1;
									}
									goto case 6;
								case 1:
									IJQVzqmmHH = null;
									num3 = 20;
									continue;
								case 6:
									awaiter2.GetResult();
									num3 = 27;
									if (0 == 0)
									{
										continue;
									}
									goto case 25;
								case 25:
									num2 = (LLdVgep31n = 0);
									num3 = 9;
									if (0 == 0)
									{
										continue;
									}
									goto case 16;
								case 16:
									num2 = (LLdVgep31n = 1);
									OThNI7fMM0 = awaiter;
									num3 = 21;
									continue;
								case 2:
								case 5:
									NrmNOUlTT2 = default;
									num3 = 26;
									continue;
								case 15:
								{
									CvsCogImage result3 = awaiter3.GetResult();
									YJSV43IoU7 = (string)BpcRnNiWd9COy10iEBO(result3);
									goto case 4;
								}
								case 19:
									hLMVbAP6AJ = new ClassifyImage(IGRVUHVEUL, IJQVzqmmHH, result2, isLabeled: true, y9wVwqKV16, YJSV43IoU7);
									num3 = 13;
									continue;
								case 18:
									YJSV43IoU7 = null;
									num3 = 3;
									if (!MSRZceijMq3paJMlxmP())
									{
										continue;
									}
									goto case 3;
								case 3:
									IGRVUHVEUL = null;
									num3 = 1;
									continue;
								case 14:
									y9wVwqKV16 = (string)eORZS7iI1TiVYB9nLFd(obj.classItem);
									IJQVzqmmHH = qsbVsq7Za4;
									num3 = 0;
									if (true)
									{
										continue;
									}
									return;
								case 22:
									return;
								case 10:
									num2 = (LLdVgep31n = -1);
									num3 = 6;
									if (SyASxxiR30fL1KKWMUS())
									{
										continue;
									}
									goto case 13;
								case 13:
									y9wVwqKV16 = null;
									num3 = 18;
									continue;
								case 9:
									NrmNOUlTT2 = awaiter3;
									ewfVkpOrMW.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num3 = 22;
									continue;
								case 26:
									num2 = (LLdVgep31n = -1);
									num3 = 15;
									continue;
								case 17:
									ewfVkpOrMW.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								case 23:
									result2 = awaiter.GetResult();
									num3 = 19;
									continue;
								case 24:
									return;
								case 0:
									awaiter3 = obj._003C_003E4__this.ClassifyService.GetImageInfo(qsbVsq7Za4).GetAwaiter();
									if (!awaiter3.IsCompleted)
									{
										num3 = 25;
										continue;
									}
									goto case 15;
								case 21:
									ewfVkpOrMW.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 24;
									continue;
								case 4:
								case 8:
									awaiter = obj._003C_003E4__this.ClassifyService.GetBitmap(qsbVsq7Za4).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num3 = 16;
										continue;
									}
									goto case 23;
								case 7:
									dsrN29g3Dk = awaiter2;
									num3 = 17;
									continue;
								case 12:
									OThNI7fMM0 = default;
									num2 = (LLdVgep31n = -1);
									goto case 23;
								default:
									num3 = 23;
									if (0 == 0)
									{
										continue;
									}
									goto case 11;
								case 11:
									dsrN29g3Dk = default;
									num3 = 10;
									continue;
								case 27:
									result = hLMVbAP6AJ;
									break;
								}
								break;
							}
						}
						catch (Exception exception)
						{
							LLdVgep31n = -2;
							hLMVbAP6AJ = null;
							ewfVkpOrMW.SetException(exception);
							return;
						}
						LLdVgep31n = -2;
						goto case 1;
					default:
						num = 1;
						break;
					case 3:
						ewfVkpOrMW.SetResult(result);
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
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				ewfVkpOrMW.SetStateMachine(P_0);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object eORZS7iI1TiVYB9nLFd(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((ClassViewModel)P_0).ClassName;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object BpcRnNiWd9COy10iEBO(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((CvsCogImage)P_0).Name;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static object elHeLiibweSFVZKO4LT(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((ClassifyImage)P_0).UpdatePrediction();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static TaskAwaiter nlE4jfieeXPAoe0uVSf(object P_0)
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return ((Task)P_0).GetAwaiter();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool SyASxxiR30fL1KKWMUS()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static bool MSRZceijMq3paJMlxmP()
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return false;
			}
		}

		public ClassViewModel classItem;

		public Classifier _003C_003E4__this;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass175_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
			fhNWZk8TINQPF7x9Smx(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(HrAHnqt2BRMEtY8KtG))]
		internal Task<ClassifyImage> _003CRefreshLabeledImages_003Eb__1(string imageId)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HrAHnqt2BRMEtY8KtG stateMachine = default;
			stateMachine.ewfVkpOrMW = AsyncTaskMethodBuilder<ClassifyImage>.Create();
			stateMachine.BVBVQ9uqjt = this;
			stateMachine.qsbVsq7Za4 = imageId;
			stateMachine.LLdVgep31n = -1;
			stateMachine.ewfVkpOrMW.Start(ref stateMachine);
			return stateMachine.ewfVkpOrMW.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CRefreshLabeledImages_003Eb__2(ClassifyImage vm)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return dk3cUN8JQncPNWjLK4T(N4OQb58Y1xjLyqS00kH(vm), classItem.ClassName);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void fhNWZk8TINQPF7x9Smx(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GuATkS8OmPCBdE0W27h()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool D7iGnw8HSHQ5cEsbCo7()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object N4OQb58Y1xjLyqS00kH(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassifyImage)P_0).Label;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dk3cUN8JQncPNWjLK4T(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRefreshLabeledImages_003Ed__175 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		private _003C_003Ec__DisplayClass175_0 _003C_003E8__1;

		private IDisposable _003C_003E7__wrap1;

		private bool _003Cchanged_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		private IEnumerator<ClassViewModel> _003C_003E7__wrap3;

		private TaskAwaiter<string[]> _003C_003Eu__2;

		private bool _003C_003E7__wrap4;

		private TaskAwaiter<bool> _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 1;
			if (!kOwliU8KDe7jvALAx6P())
			{
				goto IL_001e;
			}
			goto IL_051b;
			IL_001e:
			int num2 = _003C_003E1__state;
			num = 5;
			if (nHUxBC8CEml6pn1pkdD())
			{
			}
			goto IL_051b;
			IL_051b:
			Classifier classifier = default;
			TaskAwaiter<string[]> awaiter2 = default;
			TaskAwaiter<bool> awaiter3 = default;
			bool result = default;
			string[] newValues = default;
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				case 5:
					classifier = _003C_003E4__this;
					kOwliU8KDe7jvALAx6P();
					if (!nHUxBC8CEml6pn1pkdD())
					{
						num = 4;
						continue;
					}
					num = 0;
					if (!kOwliU8KDe7jvALAx6P())
					{
						return;
					}
					continue;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 2:
				case 4:
					try
					{
						if ((uint)num2 > 3u)
						{
							_003C_003E7__wrap1 = (IDisposable)EZHhy18AE9CKYfQIMOf(classifier.HTNIG9RquH);
						}
						try
						{
							TaskAwaiter awaiter;
							switch (num2)
							{
							default:
								if (kYvJwx8NA1U6sLFjtpG(classifier.HTNIG9RquH) <= 1)
								{
									awaiter = classifier.RefreshClasses().GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 0);
										_003C_003Eu__1 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									goto IL_010b;
								}
								goto end_IL_0088;
							case 0:
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_010b;
							case 1:
							case 2:
								try
								{
									int num3;
									if (num2 != 1)
									{
										num3 = 0;
									}
									else
									{
										awaiter2 = _003C_003Eu__2;
										num3 = 5;
									}
									while (true)
									{
										string[] array;
										switch (num3)
										{
										case 6:
											num2 = (_003C_003E1__state = -1);
											goto IL_0145;
										case 20:
											if (!awaiter2.IsCompleted)
											{
												num3 = 12;
												continue;
											}
											goto case 7;
										case 8:
										case 15:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
											return;
										case 3:
											awaiter2 = classifier.ClassifyService.GetImageIds((string)oqCTHj8wqyrYFIZJWw9(_003C_003E8__1.classItem)).GetAwaiter();
											num3 = 20;
											continue;
										case 4:
											if (!awaiter3.IsCompleted)
											{
												num3 = 1;
												continue;
											}
											goto IL_0145;
										case 13:
											_003C_003Eu__2 = awaiter2;
											num3 = 2;
											continue;
										case 2:
											_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
											num3 = 10;
											continue;
										case 1:
											num2 = (_003C_003E1__state = 2);
											_003C_003Eu__3 = awaiter3;
											goto case 8;
										case 10:
											return;
										case 17:
											num2 = (_003C_003E1__state = -1);
											goto case 7;
										default:
											num3 = 7;
											continue;
										case 11:
										case 14:
											array = new string[0];
											goto IL_0307;
										case 19:
											_003C_003E8__1 = null;
											num3 = 21;
											continue;
										case 9:
											_003Cchanged_003E5__3 = _003C_003E7__wrap4 | result;
											num3 = 19;
											continue;
										case 12:
											num2 = (_003C_003E1__state = 1);
											num3 = 13;
											continue;
										case 0:
											if (num2 == 2)
											{
												awaiter3 = _003C_003Eu__3;
												_003C_003Eu__3 = default;
												num3 = 6;
											}
											else
											{
												num3 = 18;
											}
											continue;
										case 5:
											_003C_003Eu__2 = default;
											num3 = 17;
											continue;
										case 16:
											awaiter3 = classifier.LabeledImages.UpdateAsync(newValues, [MethodImpl(MethodImplOptions.NoInlining)] (ClassifyImage vm, string imageId) =>
											{
												while (false)
												{
													_ = ((object[])null)[0];
												}
												return (string)_003C_003Ec.PeKeGu1rd7T7VXwK5NP(vm) == imageId;
											}, [MethodImpl(MethodImplOptions.NoInlining)] [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass175_0.HrAHnqt2BRMEtY8KtG))] (string imageId) =>
											{
												while (false)
												{
													_ = ((object[])null)[0];
												}
												_003C_003Ec__DisplayClass175_0.HrAHnqt2BRMEtY8KtG stateMachine = default;
												stateMachine.ewfVkpOrMW = AsyncTaskMethodBuilder<ClassifyImage>.Create();
												stateMachine.BVBVQ9uqjt = _003C_003E8__1;
												stateMachine.qsbVsq7Za4 = imageId;
												stateMachine.LLdVgep31n = -1;
												stateMachine.ewfVkpOrMW.Start(ref stateMachine);
												return stateMachine.ewfVkpOrMW.Task;
											}, [MethodImpl(MethodImplOptions.NoInlining)] (ClassifyImage vm) =>
											{
												while (false)
												{
													_ = ((object[])null)[0];
												}
												return _003C_003Ec__DisplayClass175_0.dk3cUN8JQncPNWjLK4T(_003C_003Ec__DisplayClass175_0.N4OQb58Y1xjLyqS00kH(vm), _003C_003E8__1.classItem.ClassName);
											}).GetAwaiter();
											num3 = 4;
											if (0 == 0)
											{
												continue;
											}
											goto case 7;
										case 7:
											array = awaiter2.GetResult();
											if (array == null)
											{
												kOwliU8KDe7jvALAx6P();
												num3 = ((!nHUxBC8CEml6pn1pkdD()) ? 14 : 8);
												continue;
											}
											goto IL_0307;
										case 18:
										case 21:
											{
												if (uM5Pgy8pwiU4fSMO3KK(_003C_003E7__wrap3))
												{
													_003C_003E8__1 = new _003C_003Ec__DisplayClass175_0();
													_003C_003E8__1._003C_003E4__this = classifier;
													_003C_003E8__1.classItem = _003C_003E7__wrap3.Current;
													num3 = 3;
													continue;
												}
												break;
											}
											IL_0145:
											result = awaiter3.GetResult();
											num3 = 9;
											continue;
											IL_0307:
											newValues = array;
											_003C_003E7__wrap4 = _003Cchanged_003E5__3;
											num3 = 16;
											continue;
										}
										break;
									}
								}
								finally
								{
									if (num2 < 0 && _003C_003E7__wrap3 != null)
									{
										_003C_003E7__wrap3.Dispose();
									}
								}
								_003C_003E7__wrap3 = null;
								if (_003Cchanged_003E5__3)
								{
									classifier.zsgWNWs1B();
									awaiter = ET9Apq8G15y6arhi6wp(classifier.qcsofnLTX());
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 3);
										_003C_003Eu__1 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									break;
								}
								goto IL_04d9;
							case 3:
								{
									awaiter = _003C_003Eu__1;
									_003C_003Eu__1 = default;
									num2 = (_003C_003E1__state = -1);
									break;
								}
								IL_010b:
								awaiter.GetResult();
								_003Cchanged_003E5__3 = false;
								_003C_003E7__wrap3 = classifier.Classes.GetEnumerator();
								goto case 1;
							}
							awaiter.GetResult();
							goto IL_04d9;
							end_IL_0088:;
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								yZwmw38RJG3uUPWIsac(_003C_003E7__wrap1);
							}
						}
						goto end_IL_006f;
						IL_04d9:
						_003C_003E7__wrap1 = null;
						end_IL_006f:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 6:
					return;
				}
				break;
			}
			goto IL_001e;
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
		internal static object EZHhy18AE9CKYfQIMOf(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ScopedCounter)P_0).Increment();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int kYvJwx8NA1U6sLFjtpG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ScopedCounter)P_0).Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object oqCTHj8wqyrYFIZJWw9(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassViewModel)P_0).ClassName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uM5Pgy8pwiU4fSMO3KK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter ET9Apq8G15y6arhi6wp(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yZwmw38RJG3uUPWIsac(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kOwliU8KDe7jvALAx6P()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nHUxBC8CEml6pn1pkdD()
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
	private struct _003CRefreshUnlabeledImages_003Ed__176 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		private IDisposable _003C_003E7__wrap1;

		private TaskAwaiter<string[]> _003C_003Eu__1;

		private TaskAwaiter<bool> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			v9371G8I0apYsOqk5Bb();
			int num = ((!s2bfnR8j0Z0JL9AhQkH()) ? 4 : 3);
			Classifier classifier = default;
			int num2 = default;
			TaskAwaiter<string[]> awaiter2 = default;
			TaskAwaiter<bool> awaiter3 = default;
			TaskAwaiter awaiter = default;
			while (true)
			{
				switch (num)
				{
				case 1:
				case 4:
					classifier = _003C_003E4__this;
					num = 2;
					continue;
				case 2:
					try
					{
						if ((uint)num2 > 2u)
						{
							_003C_003E7__wrap1 = (IDisposable)DKY5TF8WdlQIcCbhLFG(classifier.W0mIN5JmIs);
						}
						try
						{
							int num3;
							switch (num2)
							{
							default:
								if (pNYk5E8bcg2JsMhXjeK(classifier.W0mIN5JmIs) > 1)
								{
									num3 = 15;
								}
								else
								{
									awaiter2 = classifier.HxYHPrlul().GetAwaiter();
									num3 = 16;
									if (false)
									{
										goto IL_01e4;
									}
								}
								goto IL_021c;
							case 1:
								awaiter3 = _003C_003Eu__2;
								num3 = 19;
								goto IL_021c;
							case 0:
								awaiter2 = _003C_003Eu__1;
								num3 = 0;
								goto IL_021c;
							case 2:
								{
									awaiter = _003C_003Eu__3;
									num3 = 4;
									if (v9371G8I0apYsOqk5Bb())
									{
									}
									goto IL_021c;
								}
								IL_0295:
								num2 = (_003C_003E1__state = 0);
								num3 = 18;
								goto IL_021c;
								IL_032e:
								_003C_003Eu__1 = awaiter2;
								num3 = 21;
								goto IL_021c;
								IL_021c:
								while (true)
								{
									switch (num3)
									{
									case 16:
										if (!awaiter2.IsCompleted)
										{
											num3 = 6;
											continue;
										}
										goto case 1;
									case 13:
										if (!awaiter.IsCompleted)
										{
											num2 = (_003C_003E1__state = 2);
											_003C_003Eu__3 = awaiter;
											num3 = 12;
											continue;
										}
										goto case 22;
									case 4:
										_003C_003Eu__3 = default;
										num3 = 7;
										continue;
									case 1:
									{
										string[] result = awaiter2.GetResult();
										awaiter3 = classifier.UnlabeledImages.UpdateAsync(result, [MethodImpl(MethodImplOptions.NoInlining)] (ClassifyImage vm, string id) =>
										{
											while (false)
											{
												_ = ((object[])null)[0];
											}
											return _003C_003Ec.s1pxfG1PuDFQLRAT3BZ(_003C_003Ec.PeKeGu1rd7T7VXwK5NP(vm), id);
										}, classifier.IYruI1N2o).GetAwaiter();
										num3 = 3;
										continue;
									}
									case 12:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									case 17:
										return;
									case 8:
										return;
									case 7:
										num2 = (_003C_003E1__state = -1);
										num3 = 22;
										continue;
									case 0:
										_003C_003Eu__1 = default;
										num3 = 5;
										continue;
									case 20:
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										num3 = 8;
										if (true)
										{
											continue;
										}
										return;
									case 14:
										return;
									case 9:
									case 10:
										num2 = (_003C_003E1__state = 1);
										num3 = 11;
										continue;
									case 15:
										break;
									case 21:
										goto IL_01e4;
									case 3:
										goto IL_01fe;
									default:
										goto IL_027d;
									case 6:
										goto IL_0295;
									case 5:
										num2 = (_003C_003E1__state = -1);
										num3 = 1;
										continue;
									case 11:
										_003C_003Eu__2 = awaiter3;
										num3 = 20;
										if (true)
										{
											continue;
										}
										return;
									case 2:
										return;
									case 19:
										goto IL_02f0;
									case 18:
										goto IL_032e;
									case 22:
										awaiter.GetResult();
										goto IL_0369;
									}
									break;
								}
								break;
								IL_02f0:
								_003C_003Eu__2 = default;
								num2 = (_003C_003E1__state = -1);
								goto IL_0305;
								IL_01e4:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num3 = 14;
								if (false)
								{
									goto IL_01fe;
								}
								goto IL_021c;
								IL_01fe:
								if (!awaiter3.IsCompleted)
								{
									goto IL_027d;
								}
								goto IL_0305;
								IL_027d:
								_ = 1;
								if (v9371G8I0apYsOqk5Bb())
								{
									num3 = 2;
								}
								else
								{
									num3 = 9;
									if (1 == 0)
									{
										goto IL_0295;
									}
								}
								goto IL_021c;
								IL_0305:
								if (awaiter3.GetResult())
								{
									awaiter = s4o6II8eCnQZZWGPGsc(classifier.sesxrh73e());
									num3 = 13;
									if (!v9371G8I0apYsOqk5Bb())
									{
										goto IL_021c;
									}
									goto IL_032e;
								}
								goto IL_0369;
							}
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								XRlCBP8lcG8OrRFEkJh(_003C_003E7__wrap1);
							}
						}
						goto end_IL_0039;
						IL_0369:
						_003C_003E7__wrap1 = null;
						end_IL_0039:;
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
					num = 5;
					continue;
				case 5:
					break;
				case 0:
				case 3:
					num2 = _003C_003E1__state;
					goto case 1;
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
		internal static object DKY5TF8WdlQIcCbhLFG(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ScopedCounter)P_0).Increment();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int pNYk5E8bcg2JsMhXjeK(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ScopedCounter)P_0).Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter s4o6II8eCnQZZWGPGsc(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void XRlCBP8lcG8OrRFEkJh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool s2bfnR8j0Z0JL9AhQkH()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool v9371G8I0apYsOqk5Bb()
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
	private struct _003CRefreshLabeledImagePredictions_003Ed__177 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		private IEnumerator<ClassifyImage> _003C_003E7__wrap1;

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
			Classifier classifier = default;
			while (true)
			{
				switch (num)
				{
				case 0:
				case 2:
					try
					{
						if (num2 != 0)
						{
							_003C_003E7__wrap1 = classifier.LabeledImages.GetEnumerator();
						}
						try
						{
							if (num2 != 0)
							{
								goto IL_0160;
							}
							TaskAwaiter awaiter = _003C_003Eu__1;
							int num3 = 1;
							goto IL_011f;
							IL_011f:
							while (true)
							{
								switch (num3)
								{
								case 6:
									return;
								case 8:
									num2 = (_003C_003E1__state = 0);
									_ = 1;
									num3 = (qJ6UZD8ypofIT4gFuSC() ? 3 : 5);
									continue;
								case 9:
									if (!awaiter.IsCompleted)
									{
										num3 = 8;
										continue;
									}
									goto case 3;
								case 1:
									_003C_003Eu__1 = default;
									num3 = 4;
									if (tbOvok87GjrBJ3yw6Oh())
									{
										continue;
									}
									goto case 4;
								case 4:
									num2 = (_003C_003E1__state = -1);
									goto case 3;
								case 3:
								case 7:
									awaiter.GetResult();
									num3 = 10;
									if (0 == 0)
									{
										continue;
									}
									goto case 2;
								case 2:
								case 5:
									_003C_003Eu__1 = awaiter;
									num3 = 0;
									continue;
								case 0:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 6;
									if (tbOvok87GjrBJ3yw6Oh())
									{
										continue;
									}
									break;
								case 10:
									break;
								}
								break;
							}
							goto IL_0160;
							IL_0160:
							if (qBNwd98fGfhDhIpC68L(_003C_003E7__wrap1))
							{
								awaiter = kkDD928nRKK27y8wtaV(_003C_003E7__wrap1.Current.UpdatePrediction());
								num3 = 9;
								goto IL_011f;
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
						classifier.RefreshIsBelowThreshold();
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto default;
				case 4:
					classifier = _003C_003E4__this;
					qJ6UZD8ypofIT4gFuSC();
					num = ((!tbOvok87GjrBJ3yw6Oh()) ? 1 : 0);
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					break;
				case 5:
					num2 = _003C_003E1__state;
					num = 4;
					if (!tbOvok87GjrBJ3yw6Oh())
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
		internal static TaskAwaiter kkDD928nRKK27y8wtaV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qBNwd98fGfhDhIpC68L(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tbOvok87GjrBJ3yw6Oh()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qJ6UZD8ypofIT4gFuSC()
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
	private struct _003CRefreshUnlabeledImagePredictions_003Ed__179 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		private IEnumerator<ClassifyImage> _003C_003E7__wrap1;

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
			if (DRZ5ou8zJpMT8ZNtEZS())
			{
				num = 4;
				if (tRFEZeF2ccy2U2MwrSI())
				{
					goto IL_002a;
				}
			}
			else
			{
				num = 1;
			}
			goto IL_01fe;
			IL_002a:
			_003C_003Et__builder.SetResult();
			num = 6;
			goto IL_01fe;
			IL_01fe:
			int num2 = default;
			Classifier classifier = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					try
					{
						if (num2 != 0)
						{
							_003C_003E7__wrap1 = classifier.UnlabeledImages.GetEnumerator();
						}
						try
						{
							if (num2 != 0)
							{
								goto IL_018b;
							}
							TaskAwaiter awaiter = _003C_003Eu__1;
							int num3 = 4;
							if (tRFEZeF2ccy2U2MwrSI())
							{
								goto IL_00d2;
							}
							goto IL_0116;
							IL_0094:
							_003C_003Eu__1 = default;
							goto IL_0178;
							IL_018b:
							if (hZiULDFk10clyJGoCOe(_003C_003E7__wrap1))
							{
								awaiter = haYNhZFMXqA45Lk4Sji(vUN9kYFXXNt9MITFEsV(_003C_003E7__wrap1.Current));
								DRZ5ou8zJpMT8ZNtEZS();
								if (!tRFEZeF2ccy2U2MwrSI())
								{
									num3 = 7;
									if (1 == 0)
									{
										goto IL_0094;
									}
								}
								else
								{
									num3 = 3;
									if (tRFEZeF2ccy2U2MwrSI())
									{
										return;
									}
								}
								goto IL_0116;
							}
							goto end_IL_0057;
							IL_0178:
							num2 = (_003C_003E1__state = -1);
							num3 = 9;
							goto IL_0116;
							IL_00d2:
							num2 = (_003C_003E1__state = 0);
							num3 = 2;
							goto IL_0116;
							IL_0116:
							while (true)
							{
								switch (num3)
								{
								case 4:
									break;
								case 1:
									return;
								case 5:
									goto IL_00d2;
								case 2:
									_003C_003Eu__1 = awaiter;
									num3 = 8;
									continue;
								case 8:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								default:
									num3 = 1;
									continue;
								case 9:
									awaiter.GetResult();
									num3 = 10;
									continue;
								case 0:
								case 7:
									if (!awaiter.IsCompleted)
									{
										num3 = 5;
										continue;
									}
									goto case 9;
								case 3:
								case 6:
									goto IL_0178;
								case 10:
									goto IL_018b;
								}
								break;
							}
							goto IL_0094;
							end_IL_0057:;
						}
						finally
						{
							if (num2 < 0 && _003C_003E7__wrap1 != null)
							{
								ofRJoMFm0D3XD7daFvt(_003C_003E7__wrap1);
							}
						}
						_003C_003E7__wrap1 = null;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					break;
				case 0:
				case 4:
					num2 = _003C_003E1__state;
					num = 2;
					continue;
				case 2:
					classifier = _003C_003E4__this;
					num = 5;
					continue;
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
		internal static object vUN9kYFXXNt9MITFEsV(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassifyImage)P_0).UpdatePrediction();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter haYNhZFMXqA45Lk4Sji(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hZiULDFk10clyJGoCOe(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IEnumerator)P_0).MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ofRJoMFm0D3XD7daFvt(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			((IDisposable)P_0).Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DRZ5ou8zJpMT8ZNtEZS()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tRFEZeF2ccy2U2MwrSI()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass180_0
	{
		public ClassViewModel classItemVM;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass180_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			r27xqWF4A7kJGFom5ed();
			mJIgIbFgWwKyFXDSJKb(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CSortLabeledImages_003Eb__0(ClassifyImage image)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)piEn20F1QCaJFLgMUKW(image) == (string)WIuHX6FSV4LFs5NOHDX(classItemVM);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void r27xqWF4A7kJGFom5ed()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void mJIgIbFgWwKyFXDSJKb(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool e5YjEnFr1ipZSNs8X8X()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hDMyssFPNFnMMGBwaQp()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object piEn20F1QCaJFLgMUKW(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassifyImage)P_0).Label;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object WIuHX6FSV4LFs5NOHDX(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassViewModel)P_0).ClassName;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass181_0
	{
		public ClassViewModel classItemVM;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec__DisplayClass181_0()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Rl7MtIF8XBc0hjL0wNa();
			GXbyN1FFRwZWebAKZbq(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CSortUnlabeledImages_003Eb__0(ClassifyImage image)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (!((string)gnHb9eFsCI9EOsSiYG3(image) == classItemVM.ClassName) && gnHb9eFsCI9EOsSiYG3(image) != null)
			{
				return WywADxFds4mvjufxpM9(gnHb9eFsCI9EOsSiYG3(image), string.Empty);
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _003CSortUnlabeledImages_003Eb__1(ClassifyImage image)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)gnHb9eFsCI9EOsSiYG3(image) == (string)YvF9OnFEwBIUHjBMIPs(classItemVM);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Rl7MtIF8XBc0hjL0wNa()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GXbyN1FFRwZWebAKZbq(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			P_0._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WQSDp0F6pmI4Nucj6KZ()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EOZBG9FDlbvGnmEKNoV()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object gnHb9eFsCI9EOsSiYG3(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassifyImage)P_0).Label;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WywADxFds4mvjufxpM9(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 == (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YvF9OnFEwBIUHjBMIPs(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassViewModel)P_0).ClassName;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddDroppedImages_003Ed__194 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public List<ClassifyImage> images;

		public Classifier _003C_003E4__this;

		public bool destIsLabeled;

		public string destlabel;

		public bool srcIsLabeled;

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
			if (W8KmknF5p2pVt9XfguB())
			{
				num = 5;
			}
			else
			{
				num = 4;
				if (M2dk4hF3adYD3XXt9Mk())
				{
				}
			}
			Classifier classifier = default;
			int num2 = default;
			TaskAwaiter awaiter = default;
			ClassifyImage classifyImage = default;
			ClassViewModel classViewModel = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					classifier = _003C_003E4__this;
					num = 1;
					continue;
				case 0:
				case 5:
					num2 = _003C_003E1__state;
					num = 2;
					continue;
				case 1:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 5;
								if (false)
								{
									goto IL_0074;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 11;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							num3 = 10;
							if (M2dk4hF3adYD3XXt9Mk())
							{
								goto IL_0196;
							}
						}
						goto IL_0224;
						IL_0074:
						_003C_003Eu__1 = default;
						num3 = 1;
						goto IL_0224;
						IL_0224:
						while (true)
						{
							object obj;
							switch (num3)
							{
							case 11:
								break;
							case 15:
								classifyImage = images[0];
								num3 = 9;
								continue;
							case 1:
								num2 = (_003C_003E1__state = -1);
								num3 = 22;
								if (!M2dk4hF3adYD3XXt9Mk())
								{
									continue;
								}
								goto case 18;
							case 18:
								_003C_003Eu__1 = awaiter;
								num3 = 16;
								continue;
							case 9:
								classViewModel = classifier.jxie4Fcpv(classifyImage);
								num3 = 6;
								continue;
							case 7:
								goto end_IL_005b;
							case 6:
								if (!destIsLabeled)
								{
									goto IL_00e3;
								}
								if (QGKXYUFouLXvFLAJA0E(classifyImage))
								{
									num3 = 3;
									if (0 == 0)
									{
										continue;
									}
									goto case 10;
								}
								goto IL_01e1;
							case 10:
								_003C_003Eu__1 = default;
								num3 = 12;
								continue;
							case 16:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 17:
								return;
							case 5:
								if (fEUGa8FawGabkrME16I(images) > 0)
								{
									num3 = 15;
									continue;
								}
								goto end_IL_005b;
							case 8:
								return;
							case 20:
								goto IL_0196;
							case 3:
								if (classViewModel == null)
								{
									num3 = 2;
									if (true)
									{
										continue;
									}
									goto case 2;
								}
								obj = classViewModel.ClassName;
								goto IL_01d1;
							case 2:
								obj = null;
								goto IL_01d1;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								if (M2dk4hF3adYD3XXt9Mk())
								{
								}
								continue;
							case 14:
							case 21:
								if (classViewModel != null)
								{
									awaiter = classifier.DoUnlabelImages(images).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num2 = (_003C_003E1__state = 1);
										num3 = 18;
										continue;
									}
									goto case 22;
								}
								goto end_IL_005b;
							case 19:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 12:
								num2 = (_003C_003E1__state = -1);
								goto IL_02ec;
							case 4:
								return;
							case 13:
								if (!awaiter.IsCompleted)
								{
									num3 = 20;
									continue;
								}
								goto IL_02ec;
							case 22:
								{
									awaiter.GetResult();
									goto end_IL_005b;
								}
								IL_02ec:
								awaiter.GetResult();
								num3 = 7;
								if (!M2dk4hF3adYD3XXt9Mk())
								{
									continue;
								}
								return;
								IL_01e1:
								awaiter = qFrBDdFuPn90laRAE8c(classifier.DoRelabelImages(images, destlabel));
								num3 = 13;
								continue;
								IL_01d1:
								if (FfQQTbFc4PwQ53IQlwO(obj, destlabel))
								{
									goto IL_01e1;
								}
								goto end_IL_005b;
							}
							break;
							IL_00e3:
							if (srcIsLabeled)
							{
								M2dk4hF3adYD3XXt9Mk();
								num3 = ((!W8KmknF5p2pVt9XfguB()) ? 4 : 21);
								continue;
							}
							goto end_IL_005b;
						}
						goto IL_0074;
						IL_0196:
						num2 = (_003C_003E1__state = 0);
						num3 = 19;
						if (M2dk4hF3adYD3XXt9Mk())
						{
						}
						goto IL_0224;
						end_IL_005b:;
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
		internal static int fEUGa8FawGabkrME16I(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((List<ClassifyImage>)P_0).Count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QGKXYUFouLXvFLAJA0E(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassifyImage)P_0).IsLabeled;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FfQQTbFc4PwQ53IQlwO(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return (string)P_0 != (string)P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter qFrBDdFuPn90laRAE8c(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool W8KmknF5p2pVt9XfguB()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool M2dk4hF3adYD3XXt9Mk()
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
	private struct _003CRunSheet_003Ed__197 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		private TaskAwaiter<CvsCogSheetResult> _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 5;
			int num2 = default;
			Classifier classifier = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					num2 = _003C_003E1__state;
					num = 0;
					break;
				case 1:
				case 2:
					try
					{
						TaskAwaiter<CvsCogSheetResult> awaiter;
						int num3;
						if (num2 != 0)
						{
							awaiter = ((CvsCogSocket)KLSbdYFh5K9ZeJOjjBY(classifier.xkMbRK87y)).Sheet.RunAsync().GetAwaiter();
							num3 = 6;
							if (EQ3h6PFx4kZptPimkB9())
							{
							}
							goto IL_00fa;
						}
						awaiter = _003C_003Eu__1;
						goto IL_0131;
						IL_0149:
						awaiter.GetResult();
						goto end_IL_0029;
						IL_0131:
						_003C_003Eu__1 = default;
						num3 = 4;
						if (0 == 0)
						{
							goto IL_00fa;
						}
						goto IL_0149;
						IL_00fa:
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 2:
								_003C_003Eu__1 = awaiter;
								num3 = 0;
								continue;
							case 4:
								num2 = (_003C_003E1__state = -1);
								num3 = 9;
								continue;
							case 7:
								break;
							case 8:
								return;
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									if (true)
									{
										continue;
									}
									goto case 0;
								}
								goto IL_0149;
							case 0:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								num3 = 8;
								continue;
							case 3:
							case 5:
								goto end_IL_00fa;
							case 9:
								goto IL_0149;
							}
							num2 = (_003C_003E1__state = 0);
							EQ3h6PFx4kZptPimkB9();
							num3 = (X2ge8AFB7YqGFtWiJot() ? 1 : 3);
							continue;
							end_IL_00fa:
							break;
						}
						goto IL_0131;
						end_IL_0029:;
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
					break;
				case 0:
					classifier = _003C_003E4__this;
					_ = 0;
					num = (X2ge8AFB7YqGFtWiJot() ? 1 : 4);
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
		internal static object KLSbdYFh5K9ZeJOjjBY(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).CogSocket;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool X2ge8AFB7YqGFtWiJot()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EQ3h6PFx4kZptPimkB9()
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
	private struct _003CToggleFailClass_003Ed__203 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		public string classLabel;

		public bool failTool;

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
			if (!fDjdmFFQsDXPLQhsVe5())
			{
				num = 1;
			}
			else
			{
				num = 2;
				if (1 == 0)
				{
					goto IL_02cb;
				}
			}
			goto IL_0298;
			IL_0298:
			int num2 = default;
			TaskAwaiter awaiter = default;
			UndoEditToolFailClass undoEditToolFailClass = default;
			Classifier classifier = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 1;
								if (!sCHmMXFUcgp6RJ2ZRDR())
								{
									goto IL_0041;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 13;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num3 = 4;
						}
						goto IL_0078;
						IL_01f3:
						num2 = (_003C_003E1__state = 1);
						num3 = 15;
						if (sCHmMXFUcgp6RJ2ZRDR())
						{
							goto IL_0078;
						}
						goto IL_020c;
						IL_020c:
						_003C_003Eu__1 = awaiter;
						num3 = 12;
						goto IL_0078;
						IL_0256:
						awaiter.GetResult();
						goto end_IL_0024;
						IL_0078:
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							case 4:
								num2 = (_003C_003E1__state = -1);
								goto IL_005f;
							default:
								num3 = 10;
								if (true)
								{
									continue;
								}
								goto case 16;
							case 16:
								if (!awaiter.IsCompleted)
								{
									num3 = 7;
									continue;
								}
								goto IL_005f;
							case 7:
								num2 = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								num3 = 6;
								continue;
							case 14:
								return;
							case 11:
								undoEditToolFailClass = new UndoEditToolFailClass(classifier.pLu4jtXb7, classLabel, failTool);
								sCHmMXFUcgp6RJ2ZRDR();
								if (!fDjdmFFQsDXPLQhsVe5())
								{
									num3 = 0;
									if (true)
									{
										continue;
									}
									goto case 5;
								}
								num3 = 3;
								continue;
							case 5:
								num2 = (_003C_003E1__state = -1);
								num3 = 17;
								continue;
							case 6:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 8;
								continue;
							case 0:
							case 2:
								awaiter = InYW8UFibxyVMrOZQtS(VseaqwFVglaHEJbQt1G(IkJqRZFqA62S2HV9W6j(classifier.xkMbRK87y), undoEditToolFailClass));
								num3 = 16;
								if (sCHmMXFUcgp6RJ2ZRDR())
								{
									continue;
								}
								return;
							case 8:
								return;
							case 13:
								_003C_003Eu__1 = default;
								num3 = 5;
								if (sCHmMXFUcgp6RJ2ZRDR())
								{
									continue;
								}
								goto case 12;
							case 12:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 14;
								continue;
							case 3:
							case 9:
								goto IL_01f3;
							case 15:
								goto IL_020c;
							case 10:
								goto end_IL_0024;
							case 17:
								goto IL_0256;
								IL_005f:
								awaiter.GetResult();
								goto end_IL_0024;
							}
							break;
						}
						goto IL_0041;
						IL_0041:
						if (classifier.pLu4jtXb7 != null)
						{
							num3 = 11;
							goto IL_0078;
						}
						awaiter = InYW8UFibxyVMrOZQtS(classifier.F5oYhHPHM(classLabel, failTool));
						if (!awaiter.IsCompleted)
						{
							goto IL_01f3;
						}
						goto IL_0256;
						end_IL_0024:;
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
				case 1:
					break;
				default:
					_003C_003Et__builder.SetResult();
					num = 6;
					continue;
				case 5:
					classifier = _003C_003E4__this;
					num = 4;
					continue;
				case 6:
					return;
				}
				break;
			}
			goto IL_02cb;
			IL_02cb:
			num2 = _003C_003E1__state;
			num = 5;
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
		internal static object IkJqRZFqA62S2HV9W6j(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsInSight)P_0).UndoHandler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VseaqwFVglaHEJbQt1G(object P_0, object P_1)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((UndoRedoQueue)P_0).AddUndo((IUndoAction)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter InYW8UFibxyVMrOZQtS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sCHmMXFUcgp6RJ2ZRDR()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fDjdmFFQsDXPLQhsVe5()
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
	private struct _003C_ToggleFailClass_003Ed__204 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		public string classLabel;

		public bool failTool;

		private TaskAwaiter _003C_003Eu__1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 0;
			int num2 = default;
			TaskAwaiter awaiter = default;
			Classifier classifier = default;
			while (true)
			{
				switch (num)
				{
				case 2:
				case 4:
					try
					{
						int num3;
						if (num2 != 0)
						{
							if (num2 != 1)
							{
								num3 = 10;
							}
							else
							{
								awaiter = _003C_003Eu__1;
								num3 = 11;
							}
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
							case 4:
								_003C_003Eu__1 = awaiter;
								num3 = 2;
								continue;
							case 3:
								awaiter.GetResult();
								goto default;
							default:
								_ = 1;
								if (!ys07e0FthlXjihTf5gN())
								{
									num3 = 8;
									continue;
								}
								num3 = 14;
								if (ys07e0FthlXjihTf5gN())
								{
								}
								continue;
							case 0:
								if (!awaiter.IsCompleted)
								{
									num3 = 1;
									continue;
								}
								goto case 3;
							case 2:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 11:
								_003C_003Eu__1 = default;
								goto case 13;
							case 15:
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								continue;
							case 13:
							case 14:
								num2 = (_003C_003E1__state = -1);
								num3 = 16;
								if (0 == 0)
								{
									continue;
								}
								return;
							case 6:
								return;
							case 9:
								num2 = (_003C_003E1__state = 1);
								num3 = 12;
								if (0 == 0)
								{
									continue;
								}
								goto case 10;
							case 10:
								awaiter = aXeZcEFvCK2j3NLxgFi(ykZeGcF9OHc7Xgxsqvi(classifier.tFxs6dSMN, classLabel, failTool));
								num3 = 0;
								continue;
							case 1:
								num2 = (_003C_003E1__state = 0);
								num3 = 4;
								continue;
							case 7:
							case 8:
								awaiter = classifier.RefreshJobFailClasses().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 9;
									continue;
								}
								break;
							case 5:
								_003C_003Eu__1 = default;
								num2 = (_003C_003E1__state = -1);
								num3 = 3;
								continue;
							case 12:
								_003C_003Eu__1 = awaiter;
								num3 = 15;
								continue;
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
				case 0:
					num2 = _003C_003E1__state;
					num = 5;
					continue;
				case 5:
					classifier = _003C_003E4__this;
					jxD6o5FLfJodVGRFBsM();
					if (ys07e0FthlXjihTf5gN())
					{
						num = 1;
						if (ys07e0FthlXjihTf5gN())
						{
						}
					}
					else
					{
						num = 4;
					}
					continue;
				case 6:
					return;
				}
				_003C_003Et__builder.SetResult();
				num = 6;
				if (ys07e0FthlXjihTf5gN())
				{
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
		internal static object ykZeGcF9OHc7Xgxsqvi(object P_0, object P_1, bool P_2)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((IViDiELClassifyService)P_0).SetClassFailsTool((string)P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter aXeZcEFvCK2j3NLxgFi(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jxD6o5FLfJodVGRFBsM()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ys07e0FthlXjihTf5gN()
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
	private struct _003C_003CRefreshUnlabeledImages_003Eb__176_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ClassifyImage> _003C_003Et__builder;

		public Classifier _003C_003E4__this;

		public string imageId;

		private ClassifyImage _003CimageVM_003E5__2;

		private string _003C_003E7__wrap2;

		private IViDiELClassifyService _003C_003E7__wrap3;

		private string _003C_003E7__wrap4;

		private TaskAwaiter<CvsCogImage> _003C_003Eu__1;

		private TaskAwaiter<BitmapImage> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 6;
			ClassifyImage result = default;
			Classifier classifier = default;
			int num2 = default;
			TaskAwaiter<CvsCogImage> awaiter3 = default;
			TaskAwaiter<BitmapImage> awaiter2 = default;
			TaskAwaiter awaiter = default;
			CvsCogImage result3 = default;
			BitmapImage result2 = default;
			while (true)
			{
				switch (num)
				{
				case 5:
					_003C_003Et__builder.SetResult(result);
					num = 7;
					break;
				case 1:
				case 3:
					classifier = _003C_003E4__this;
					goto case 2;
				case 0:
					_003CimageVM_003E5__2 = null;
					num = 5;
					break;
				case 6:
					num2 = _003C_003E1__state;
					_ = 1;
					if (lER4TXF0m483RDf27Ak())
					{
						num = 4;
						break;
					}
					num = 3;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				case 2:
				case 4:
					try
					{
						int num3;
						switch (num2)
						{
						default:
							_003C_003E7__wrap3 = classifier.ClassifyService;
							num3 = 4;
							goto IL_0269;
						case 0:
							awaiter3 = _003C_003Eu__1;
							_003C_003Eu__1 = default;
							num2 = (_003C_003E1__state = -1);
							num3 = 2;
							if (lER4TXF0m483RDf27Ak())
							{
								break;
							}
							goto IL_0269;
						case 1:
							awaiter2 = _003C_003Eu__2;
							num3 = 20;
							if (1 == 0)
							{
								goto IL_01df;
							}
							goto IL_0269;
						case 2:
							{
								awaiter = _003C_003Eu__3;
								num3 = 19;
								goto IL_0269;
							}
							IL_0269:
							while (true)
							{
								switch (num3)
								{
								case 4:
									_003C_003E7__wrap4 = imageId;
									num3 = 24;
									continue;
								case 10:
									num2 = (_003C_003E1__state = 2);
									goto case 14;
								case 22:
									_003C_003E7__wrap3 = null;
									num3 = 5;
									continue;
								case 15:
									awaiter = YeF7N6FTNbinJoxYMYl(qyetU9FHSjkX0n0MgGg(_003CimageVM_003E5__2));
									num3 = 1;
									if (alZ5afFZQR8KhQ51ukf())
									{
										continue;
									}
									goto case 25;
								case 25:
									_003C_003E7__wrap2 = (string)osLD6LFO9a1jWmOBIfh(result3);
									awaiter2 = classifier.ClassifyService.GetBitmap(imageId).GetAwaiter();
									num3 = 11;
									if (0 == 0)
									{
										continue;
									}
									goto case 20;
								case 20:
									_003C_003Eu__2 = default;
									num2 = (_003C_003E1__state = -1);
									num3 = 23;
									if (0 == 0)
									{
										continue;
									}
									goto case 24;
								case 24:
									awaiter3 = classifier.ClassifyService.GetImageInfo(imageId).GetAwaiter();
									if (!awaiter3.IsCompleted)
									{
										num3 = 17;
										continue;
									}
									goto case 2;
								case 9:
									return;
								case 16:
									break;
								case 1:
									goto end_IL_0269;
								case 5:
									_003C_003E7__wrap4 = null;
									num3 = 15;
									if (true)
									{
										continue;
									}
									goto case 19;
								case 19:
									_003C_003Eu__3 = default;
									num3 = 3;
									continue;
								case 6:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 0;
									if (alZ5afFZQR8KhQ51ukf())
									{
										continue;
									}
									goto case 14;
								case 14:
								case 18:
									_003C_003Eu__3 = awaiter;
									num3 = 6;
									continue;
								case 23:
									result2 = awaiter2.GetResult();
									goto case 7;
								default:
									num3 = 7;
									continue;
								case 17:
									num2 = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter3;
									num3 = 21;
									continue;
								case 8:
								case 12:
									num2 = (_003C_003E1__state = 1);
									num3 = 16;
									continue;
								case 7:
									_003CimageVM_003E5__2 = new ClassifyImage(_003C_003E7__wrap3, _003C_003E7__wrap4, result2, isLabeled: false, "", _003C_003E7__wrap2);
									_003C_003E7__wrap2 = null;
									num3 = 22;
									continue;
								case 21:
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num3 = 9;
									continue;
								case 3:
									num2 = (_003C_003E1__state = -1);
									num3 = 13;
									continue;
								case 0:
									return;
								case 13:
									goto IL_038a;
								case 2:
									result3 = awaiter3.GetResult();
									num3 = 25;
									continue;
								case 11:
									if (awaiter2.IsCompleted)
									{
										goto case 23;
									}
									lER4TXF0m483RDf27Ak();
									if (!alZ5afFZQR8KhQ51ukf())
									{
										num3 = 14;
										continue;
									}
									num3 = 12;
									if (alZ5afFZQR8KhQ51ukf())
									{
										continue;
									}
									goto case 26;
								case 26:
									result = _003CimageVM_003E5__2;
									goto end_IL_0075;
								}
								goto end_IL_0076;
								continue;
								end_IL_0269:
								break;
							}
							goto IL_01df;
							IL_01df:
							if (!awaiter.IsCompleted)
							{
								num3 = 10;
								goto IL_0269;
							}
							goto IL_038a;
							IL_038a:
							awaiter.GetResult();
							num3 = 26;
							if (lER4TXF0m483RDf27Ak())
							{
							}
							goto IL_0269;
							end_IL_0076:
							break;
						}
						_003C_003Eu__2 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
						end_IL_0075:;
					}
					catch (Exception exception)
					{
						_003C_003E1__state = -2;
						_003CimageVM_003E5__2 = null;
						_003C_003Et__builder.SetException(exception);
						return;
					}
					_003C_003E1__state = -2;
					goto case 0;
				default:
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
		internal static object osLD6LFO9a1jWmOBIfh(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((CvsCogImage)P_0).Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object qyetU9FHSjkX0n0MgGg(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassifyImage)P_0).UpdatePrediction();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter YeF7N6FTNbinJoxYMYl(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((Task)P_0).GetAwaiter();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool alZ5afFZQR8KhQ51ukf()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lER4TXF0m483RDf27Ak()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}
	}

	public readonly IOperationProgressManager OperationProgressManager;

	private readonly IViDiELClassifyService tFxs6dSMN;

	private readonly CvsInSight xkMbRK87y;

	private readonly Func<Task> lDbwiFefS;

	private readonly IClassifierHandle pLu4jtXb7;

	private static string nRHUj2QK9;

	[CompilerGenerated]
	private Func<Task> uLWzX3Iav;

	[CompilerGenerated]
	private Func<Task> PZBIOJE1yl;

	[CompilerGenerated]
	private Func<Task> IcmIIhu0Tr;

	private ViewModelErrorState I3GI2a6iRB;

	[CompilerGenerated]
	private AsyncDelegateCommand nI7IxGlpDv;

	[CompilerGenerated]
	private AsyncDelegateCommand xEAIoYlt6N;

	[CompilerGenerated]
	private ClassViewModel yHEIaSapBM;

	private readonly ScopedCounter YtoIVacrNb;

	private readonly ScopedCounter W0mIN5JmIs;

	private readonly ScopedCounter HTNIG9RquH;

	public ObservableCollection<ClassifyImage> LabeledImages;

	public ObservableCollection<ClassifyImage> UnlabeledImages;

	private List<string> XyCIhrCwEC;

	private bool zYsIT4NWsO;

	private ImageSource DhqIlOuATQ;

	private string cDJIB1osip;

	private int gViIeB2X2o;

	private bool mBYIt6D3Ck;

	private readonly AsyncDelegateCommand<object> Bo8I3TyKTA;

	private readonly AsyncDelegateCommand gpsICqjvSK;

	private readonly AsyncDelegateCommand r64IrS3U6g;

	private readonly AsyncDelegateCommand wCcIivQraK;

	private string jRaI68Hrwa;

	private readonly AsyncDelegateCommand Rs0InCbu0g;

	private readonly AsyncDelegateCommand<IEnumerable<string>> jbfIHod64c;

	private bool cOMIpq1uFn;

	private ObservableCollection<ClassViewModel> IPQIW8Kn3d;

	private string bcwISEWJJ8;

	public bool IsOnline
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xkMbRK87y.IsOnline;
		}
	}

	public ViewModelErrorState UnlabledImagesErrorState
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return I3GI2a6iRB;
		}
	}

	public AsyncDelegateCommand RemoveImageCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return nI7IxGlpDv;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			nI7IxGlpDv = value;
		}
	}

	public AsyncDelegateCommand NextImageCommand
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return xEAIoYlt6N;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			xEAIoYlt6N = value;
		}
	}

	public ClassViewModel PredictedClass
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return yHEIaSapBM;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			yHEIaSapBM = value;
		}
	}

	public List<string> ClassNames
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return XyCIhrCwEC;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref XyCIhrCwEC, value, plfGltUiaC1OFfC2I8.OIRNC4VQ7F(90));
		}
	}

	public IViDiELClassifyService ClassifyService
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return tFxs6dSMN;
		}
	}

	public bool LiveLabel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return zYsIT4NWsO;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (SetField(ref zYsIT4NWsO, value, (string)lgbvLfgoSw8BloN8DH(114)))
			{
				CQZ28d1A02GSjUIvqw(this, lgbvLfgoSw8BloN8DH(64));
			}
		}
	}

	public bool IsMoreImages
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return H4pTiC6hHnohvHFq47(CurrentImageName, nRHUj2QK9);
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
			return DhqIlOuATQ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref DhqIlOuATQ, value, (string)lgbvLfgoSw8BloN8DH(136));
		}
	}

	public string CurrentImageName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return cDJIB1osip;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref cDJIB1osip, value, (string)lgbvLfgoSw8BloN8DH(164));
		}
	}

	public int ModelHealth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return gViIeB2X2o;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref gViIeB2X2o, value, plfGltUiaC1OFfC2I8.OIRNC4VQ7F(200));
		}
	}

	public long UnlabeledSampleCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GetBaggedField<long>((string)lgbvLfgoSw8BloN8DH(226));
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetBaggedField(value, shouldForceChange: true, (string)lgbvLfgoSw8BloN8DH(226));
		}
	}

	public long SampleCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GetBaggedField<long>((string)lgbvLfgoSw8BloN8DH(270));
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetBaggedField(value, shouldForceChange: true, (string)lgbvLfgoSw8BloN8DH(270));
			HasSamples = value > 0;
		}
	}

	public bool HasSamples
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GetBaggedField<bool>((string)lgbvLfgoSw8BloN8DH(296));
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetBaggedField(value, shouldForceChange: true, (string)lgbvLfgoSw8BloN8DH(296));
		}
	}

	public bool DoAutoTuneEnabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GetBaggedField<bool>((string)lgbvLfgoSw8BloN8DH(320));
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetBaggedField(value, shouldForceChange: true, plfGltUiaC1OFfC2I8.OIRNC4VQ7F(320));
		}
	}

	public bool IsEditingClassNames
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Classes.Any([MethodImpl(MethodImplOptions.NoInlining)] (ClassViewModel classItem) =>
			{
				while (false)
				{
					_ = ((object[])null)[0];
				}
				return _003C_003Ec.oGUASO1XU3ro4queWpB(classItem);
			});
		}
	}

	public double ClassificationThreshold
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return GetBaggedField<double>(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(358));
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetBaggedField(value, shouldForceChange: true, plfGltUiaC1OFfC2I8.OIRNC4VQ7F(358));
			RefreshIsBelowThreshold();
		}
	}

	public bool ExecutedWithoutError
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
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
			goto IL_00d8;
			IL_001a:
			bool? flag = null;
			num = 9;
			goto IL_00d8;
			IL_00d8:
			bool flag3 = default;
			while (true)
			{
				bool? flag2;
				switch (num)
				{
				case 8:
					break;
				case 2:
				{
					if (pLu4jtXb7 == null)
					{
						num = 3;
						continue;
					}
					CvsInSight cvsInSight = xkMbRK87y;
					if (cvsInSight == null)
					{
						num = 8;
						if (true)
						{
							continue;
						}
					}
					else
					{
						CvsResultSet results = cvsInSight.Results;
						if (results == null)
						{
							num = 5;
							continue;
						}
						object obj = sscotgDKfcbGHeY4oR(results);
						if (obj == null)
						{
							goto case 0;
						}
						CvsCell cvsCell = ((IEnumerable<CvsCell>)obj).FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (CvsCell P_0) =>
						{
							while (false)
							{
								_ = ((object[])null)[0];
							}
							return AjFaRACRClWEtW8pDr(P_0) == tSo9rUA1iJHkrZbR9u(pLu4jtXb7);
						});
						if (cvsCell != null)
						{
							flag2 = cvsCell.Error;
							goto IL_0157;
						}
					}
					goto case 4;
				}
				case 0:
					flag = null;
					y3OaHpP3epw6Hi353d();
					num = (WIW3HJrsrBpeJbC7lF() ? 1 : 4);
					continue;
				case 3:
					return false;
				case 4:
				case 7:
					flag = null;
					num = 10;
					continue;
				case 9:
					flag2 = flag;
					goto IL_0157;
				case 5:
					flag2 = null;
					goto IL_0157;
				default:
					num = 0;
					if (0 == 0)
					{
						continue;
					}
					goto case 1;
				case 1:
				case 6:
					flag2 = flag;
					goto IL_0157;
				case 10:
					flag2 = flag;
					goto IL_0157;
				case 11:
					{
						return flag == flag3;
					}
					IL_0157:
					flag = flag2;
					flag3 = false;
					num = 11;
					if (true)
					{
						continue;
					}
					goto case 11;
				}
				break;
			}
			goto IL_001a;
		}
	}

	public bool ShowEditClasses
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return pLu4jtXb7 != null;
		}
	}

	public bool IsEditingClasses
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return mBYIt6D3Ck;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref mBYIt6D3Ck, value, plfGltUiaC1OFfC2I8.OIRNC4VQ7F(436));
		}
	}

	public ICommand DeleteClass
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Bo8I3TyKTA;
		}
	}

	public bool AreImagesUnlabeled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kA1q4NV5b().Any();
		}
	}

	public ICommand UnlabelSelectedImages
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return gpsICqjvSK;
		}
	}

	public ICommand RemoveSelectedImages
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return r64IrS3U6g;
		}
	}

	public ICommand RemoveUnlabeledImages
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return wCcIivQraK;
		}
	}

	public string SelectedClassLabel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return jRaI68Hrwa;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref jRaI68Hrwa, value, (string)lgbvLfgoSw8BloN8DH(472));
			Rs0InCbu0g.RaiseCanExecuteChanged();
		}
	}

	public string NewClassName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return SelectedClassLabel;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			int num = 2;
			_003C_003Ec__DisplayClass152_0 obj = default;
			IEnumerator<string> enumerator = default;
			List<string> list = default;
			while (true)
			{
				switch (num)
				{
				case 9:
					obj.value = value;
					num = 1;
					break;
				case 4:
				case 10:
					ClassNames.Add(obj.value);
					goto case 0;
				default:
					num = 0;
					break;
				case 3:
					SelectedClassLabel = obj.value;
					num = 7;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				case 2:
					obj = new _003C_003Ec__DisplayClass152_0();
					num = 5;
					break;
				case 6:
				case 8:
					enumerator = list.Where(obj._003Cset_NewClassName_003Eb__1).GetEnumerator();
					num = 11;
					break;
				case 0:
					list = ClassNames.Where(obj._003Cset_NewClassName_003Eb__0).ToList();
					num = 3;
					break;
				case 1:
					if (ClassNames.Contains(obj.value))
					{
						goto case 0;
					}
					y3OaHpP3epw6Hi353d();
					if (WIW3HJrsrBpeJbC7lF())
					{
						num = 10;
						break;
					}
					num = 6;
					if (WIW3HJrsrBpeJbC7lF())
					{
						break;
					}
					goto case 11;
				case 5:
					obj._003C_003E4__this = this;
					num = 9;
					break;
				case 7:
					if (Hkpj9lsoXPlkar5gCi(list) > 1)
					{
						goto case 6;
					}
					return;
				case 11:
					try
					{
						while (enumerator.MoveNext())
						{
							string current = enumerator.Current;
							y3OaHpP3epw6Hi353d();
							int num2;
							if (WIW3HJrsrBpeJbC7lF())
							{
								num2 = 2;
								if (y3OaHpP3epw6Hi353d())
								{
								}
							}
							else
							{
								num2 = 3;
							}
							switch (num2)
							{
							case 0:
							case 2:
								ClassNames.Remove(current);
								break;
							}
						}
						return;
					}
					finally
					{
						if (enumerator != null)
						{
							FP7mOGdfUnkiPWkOVN(enumerator);
						}
					}
				}
			}
		}
	}

	public ICommand RelabelSelectedImages
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Rs0InCbu0g;
		}
	}

	public ICommand ImportImages
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return jbfIHod64c;
		}
	}

	public ObservableCollection<ClassViewModel> Classes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return IPQIW8Kn3d;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (IPQIW8Kn3d != null)
			{
				IPQIW8Kn3d.CollectionChanged -= q45KK2cXZ;
			}
			SetField(ref IPQIW8Kn3d, value, plfGltUiaC1OFfC2I8.OIRNC4VQ7F(518));
			if (IPQIW8Kn3d != null)
			{
				IPQIW8Kn3d.CollectionChanged += q45KK2cXZ;
			}
		}
	}

	public bool IsLastPass
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return cOMIpq1uFn;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref cOMIpq1uFn, value, (string)lgbvLfgoSw8BloN8DH(536));
		}
	}

	public bool CanAddImage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (!IsEditingClassNames)
			{
				if (LiveLabel)
				{
					return ExecutedWithoutError;
				}
				return true;
			}
			return false;
		}
	}

	public string LastImportDirectory
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			_ = 1;
			int num = ((!y3OaHpP3epw6Hi353d()) ? 1 : 4);
			while (true)
			{
				switch (num)
				{
				case 3:
					if (pLu4jtXb7 == null)
					{
						break;
					}
					goto default;
				case 0:
				case 1:
					if (kWRFphHXaU3muG1yNZ(bcwISEWJJ8))
					{
						num = 3;
						continue;
					}
					break;
				default:
					if (vv4PwZTtkOnle0xvIU(pLu4jtXb7))
					{
						num = 5;
						continue;
					}
					break;
				case 5:
					return (string)sBOeUsYjE6Zcv8lp1F(pLu4jtXb7);
				}
				break;
			}
			return bcwISEWJJ8;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			SetField(ref bcwISEWJJ8, value, (string)lgbvLfgoSw8BloN8DH(648));
		}
	}

	public event Func<Task> LabeledImagesChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Func<Task> func = uLWzX3Iav;
			Func<Task> func2;
			do
			{
				func2 = func;
				Func<Task> value2 = (Func<Task>)Delegate.Combine(func2, value);
				func = Interlocked.CompareExchange(ref uLWzX3Iav, value2, func2);
			}
			while ((object)func != func2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Func<Task> func = uLWzX3Iav;
			Func<Task> func2;
			do
			{
				func2 = func;
				Func<Task> value2 = (Func<Task>)Delegate.Remove(func2, value);
				func = Interlocked.CompareExchange(ref uLWzX3Iav, value2, func2);
			}
			while ((object)func != func2);
		}
	}

	public event Func<Task> UnlabeledImagesChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Func<Task> func = PZBIOJE1yl;
			Func<Task> func2;
			do
			{
				func2 = func;
				Func<Task> value2 = (Func<Task>)Delegate.Combine(func2, value);
				func = Interlocked.CompareExchange(ref PZBIOJE1yl, value2, func2);
			}
			while ((object)func != func2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Func<Task> func = PZBIOJE1yl;
			Func<Task> func2;
			do
			{
				func2 = func;
				Func<Task> value2 = (Func<Task>)Delegate.Remove(func2, value);
				func = Interlocked.CompareExchange(ref PZBIOJE1yl, value2, func2);
			}
			while ((object)func != func2);
		}
	}

	public event Func<Task> ClassesChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Func<Task> func = IcmIIhu0Tr;
			Func<Task> func2;
			do
			{
				func2 = func;
				Func<Task> value2 = (Func<Task>)Delegate.Combine(func2, value);
				func = Interlocked.CompareExchange(ref IcmIIhu0Tr, value2, func2);
			}
			while ((object)func != func2);
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			Func<Task> func = IcmIIhu0Tr;
			Func<Task> func2;
			do
			{
				func2 = func;
				Func<Task> value2 = (Func<Task>)Delegate.Remove(func2, value);
				func = Interlocked.CompareExchange(ref IcmIIhu0Tr, value2, func2);
			}
			while ((object)func != func2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Classifier(CvsInSight insight, IViDiELClassifyService classifyService, IOperationProgressManager operationProgressManager, Func<Task> triggerAquisition = null, bool liveLabel = false, IClassifierHandle handle = null)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		I3GI2a6iRB = new ViewModelErrorState(Resources.RemoveUnlabeledInfoToolTip, ErrorStateStatusLevel.Info);
		YtoIVacrNb = new ScopedCounter();
		W0mIN5JmIs = new ScopedCounter();
		HTNIG9RquH = new ScopedCounter();
		LabeledImages = new ObservableCollection<ClassifyImage>();
		UnlabeledImages = new ObservableCollection<ClassifyImage>();
		base._002Ector();
		tFxs6dSMN = classifyService;
		xkMbRK87y = insight;
		OperationProgressManager = operationProgressManager;
		xkMbRK87y.ResultsChanged += ldE27Qac6;
		xkMbRK87y.IsOnlineChanged += OwuIAKH33;
		lDbwiFefS = triggerAquisition;
		LiveLabel = liveLabel;
		pLu4jtXb7 = handle;
		ClassificationThreshold = 0.0;
		NextImageCommand = new AsyncDelegateCommand(NextImage);
		RemoveImageCommand = new AsyncDelegateCommand(RemoveCurrentImage);
		gpsICqjvSK = new AsyncDelegateCommand(DoUnlabelSelectedImages, [MethodImpl(MethodImplOptions.NoInlining)] () =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kYiE8nSwg() && jtI1MEUuC();
		});
		r64IrS3U6g = new AsyncDelegateCommand(DoRemoveSelectedImages, [MethodImpl(MethodImplOptions.NoInlining)] () =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return kYiE8nSwg();
		});
		Rs0InCbu0g = new AsyncDelegateCommand(DoRelabelSelectedImages, [MethodImpl(MethodImplOptions.NoInlining)] () =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (kYiE8nSwg())
			{
				string selectedClassLabel = SelectedClassLabel;
				if (selectedClassLabel == null)
				{
					return false;
				}
				return LciT2yKsyFmAysBpkA(selectedClassLabel) > 0;
			}
			return false;
		});
		Bo8I3TyKTA = new AsyncDelegateCommand<object>([MethodImpl(MethodImplOptions.NoInlining)] (object P_0) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DoDeleteClass(P_0, s1UTA8rbX);
		});
		jbfIHod64c = new AsyncDelegateCommand<IEnumerable<string>>([MethodImpl(MethodImplOptions.NoInlining)] (IEnumerable<string> P_0) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return DoImportImages(P_0);
		}, [MethodImpl(MethodImplOptions.NoInlining)] (IEnumerable<string> _) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		});
		wCcIivQraK = new AsyncDelegateCommand(DoRemoveUnlabeledImages, [MethodImpl(MethodImplOptions.NoInlining)] () =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return AreImagesUnlabeled && !IsOnline;
		});
		Classes = new ObservableCollection<ClassViewModel>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OwuIAKH33(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (y3OaHpP3epw6Hi353d())
		{
			goto IL_001e;
		}
		goto IL_0037;
		IL_001e:
		IsEditingClasses = false;
		goto IL_0062;
		IL_0037:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				break;
			default:
				num = 3;
				continue;
			case 3:
				goto IL_0062;
			case 1:
			case 4:
				if (IsEditingClasses)
				{
					break;
				}
				goto IL_0062;
			case 5:
				goto IL_0097;
			case 6:
				return;
			}
			break;
			IL_0097:
			if (gDB8tx4rrjYrTFcLs8(xkMbRK87y))
			{
				y3OaHpP3epw6Hi353d();
				if (!WIW3HJrsrBpeJbC7lF())
				{
					num = 0;
					continue;
				}
				num = 4;
				if (y3OaHpP3epw6Hi353d())
				{
					return;
				}
				continue;
			}
			goto IL_0062;
		}
		goto IL_001e;
		IL_0062:
		CQZ28d1A02GSjUIvqw(this, lgbvLfgoSw8BloN8DH(0));
		num = 6;
		goto IL_0037;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		xkMbRK87y.ResultsChanged -= ldE27Qac6;
		xkMbRK87y.IsOnlineChanged -= OwuIAKH33;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ldE27Qac6(object P_0, EventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		FirePropertyChangedExplicit(plfGltUiaC1OFfC2I8.OIRNC4VQ7F(20));
		CQZ28d1A02GSjUIvqw(this, lgbvLfgoSw8BloN8DH(64));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnUnlabeledImagesChanged_003Ed__22))]
	private Task sesxrh73e()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!y3OaHpP3epw6Hi353d())
		{
			num = 2;
		}
		else
		{
			num = 4;
			if (!WIW3HJrsrBpeJbC7lF())
			{
				goto IL_00a5;
			}
		}
		goto IL_003e;
		IL_003e:
		_003COnUnlabeledImagesChanged_003Ed__22 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003E1__state = -1;
				break;
			default:
				num = 3;
				if (WIW3HJrsrBpeJbC7lF())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (true)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = uMblsWSSyxwjdr6rcJ();
				goto case 1;
			case 3:
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_00a5;
		IL_00a5:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_003e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnLabeledImagesChanged_003Ed__26))]
	private Task qcsofnLTX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003COnLabeledImagesChanged_003Ed__26 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				WIW3HJrsrBpeJbC7lF();
				if (y3OaHpP3epw6Hi353d())
				{
					num = 0;
					break;
				}
				num = 1;
				if (WIW3HJrsrBpeJbC7lF())
				{
					break;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003Et__builder = uMblsWSSyxwjdr6rcJ();
				num = 5;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefresh_003Ed__27))]
	public Task Refresh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		WIW3HJrsrBpeJbC7lF();
		int num = (y3OaHpP3epw6Hi353d() ? 5 : 4);
		_003CRefresh_003Ed__27 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = uMblsWSSyxwjdr6rcJ();
				num = 1;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 2;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003COnClassesChanged_003Ed__28))]
	private Task uoda3OXyX()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003COnClassesChanged_003Ed__28 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				stateMachine._003C_003Et__builder = uMblsWSSyxwjdr6rcJ();
				num = 5;
				break;
			case 1:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 5:
				stateMachine._003C_003E4__this = this;
				WIW3HJrsrBpeJbC7lF();
				if (y3OaHpP3epw6Hi353d())
				{
					num = 4;
					break;
				}
				num = 1;
				if (true)
				{
					break;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInitialize_003Ed__52))]
	public Task Initialize()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CInitialize_003Ed__52 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
				stateMachine._003C_003Et__builder = uMblsWSSyxwjdr6rcJ();
				num = 4;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (true)
				{
					break;
				}
				goto case 4;
			case 4:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				num = (y3OaHpP3epw6Hi353d() ? 5 : 0);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CInitializeInternal_003Ed__53))]
	public Task InitializeInternal()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num;
		if (WIW3HJrsrBpeJbC7lF())
		{
			num = 5;
			if (y3OaHpP3epw6Hi353d())
			{
				goto IL_002a;
			}
		}
		else
		{
			num = 4;
			if (false)
			{
				goto IL_00a5;
			}
		}
		goto IL_005c;
		IL_005c:
		_003CInitializeInternal_003Ed__53 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 3:
				stateMachine._003C_003E1__state = -1;
				break;
			default:
				num = 2;
				continue;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = uMblsWSSyxwjdr6rcJ();
				goto IL_00a5;
			case 1:
			case 4:
				goto IL_00a5;
			case 6:
				goto IL_00b9;
			}
			break;
		}
		goto IL_002a;
		IL_00b9:
		return stateMachine._003C_003Et__builder.Task;
		IL_002a:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_005c;
		IL_00a5:
		stateMachine._003C_003E4__this = this;
		num = 3;
		if (0 == 0)
		{
			goto IL_005c;
		}
		goto IL_00b9;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void d1OVvbmBc()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (y3OaHpP3epw6Hi353d() ? 4 : 2);
		while (true)
		{
			switch (num)
			{
			case 3:
				RaisePropertyChangedEvent(new PropertyChangedEventArgs((string)lgbvLfgoSw8BloN8DH(408)));
				num = 5;
				break;
			case 1:
			case 4:
				CurrentImageName = nRHUj2QK9;
				goto case 3;
			default:
				num = 3;
				break;
			case 0:
			case 2:
				CurrentImage = null;
				goto case 1;
			case 5:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetImage(ImageSource source)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		CurrentImage = source;
		lptMvf8OoKwqV9B3CF(this, new PropertyChangedEventArgs((string)lgbvLfgoSw8BloN8DH(408)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshModelHealth_003Ed__93))]
	public Task RefreshModelHealth()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		y3OaHpP3epw6Hi353d();
		int num = ((!WIW3HJrsrBpeJbC7lF()) ? 3 : 5);
		_003CRefreshModelHealth_003Ed__93 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (true)
				{
					break;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			default:
				num = 4;
				if (WIW3HJrsrBpeJbC7lF())
				{
					break;
				}
				goto case 0;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				goto case 1;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshPredictedResult_003Ed__94))]
	private Task IRgNWRx4r()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		WIW3HJrsrBpeJbC7lF();
		int num;
		if (!y3OaHpP3epw6Hi353d())
		{
			num = 4;
		}
		else
		{
			num = 3;
			if (false)
			{
				goto IL_00ab;
			}
		}
		goto IL_0060;
		IL_00ab:
		_003CRefreshPredictedResult_003Ed__94 stateMachine = default;
		stateMachine._003C_003E4__this = this;
		num = 2;
		if (!y3OaHpP3epw6Hi353d())
		{
			goto IL_0060;
		}
		goto IL_00c3;
		IL_00c3:
		return stateMachine._003C_003Et__builder.Task;
		IL_0060:
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (!y3OaHpP3epw6Hi353d())
				{
					continue;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			default:
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = uMblsWSSyxwjdr6rcJ();
				break;
			case 1:
			case 3:
				break;
			case 6:
				goto IL_00c3;
			}
			break;
		}
		goto IL_00ab;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshNumImages_003Ed__95))]
	internal Task ROyGHJmpI()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CRefreshNumImages_003Ed__95 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 0;
			default:
				num = 0;
				break;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (WIW3HJrsrBpeJbC7lF())
				{
					break;
				}
				goto case 3;
			case 3:
				stateMachine._003C_003Et__builder = uMblsWSSyxwjdr6rcJ();
				y3OaHpP3epw6Hi353d();
				num = (WIW3HJrsrBpeJbC7lF() ? 4 : 5);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CNextImage_003Ed__96))]
	public Task NextImage()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		y3OaHpP3epw6Hi353d();
		int num = (WIW3HJrsrBpeJbC7lF() ? 1 : 4);
		_003CNextImage_003Ed__96 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				continue;
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 5;
				if (WIW3HJrsrBpeJbC7lF())
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
	[AsyncStateMachine(typeof(_003CNextImage_Internal_003Ed__97))]
	private Task DvxhcaSGN()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = ((!y3OaHpP3epw6Hi353d()) ? 1 : 4);
		_003CNextImage_Internal_003Ed__97 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				stateMachine._003C_003Et__builder = uMblsWSSyxwjdr6rcJ();
				num = 5;
				break;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 2:
			case 4:
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
	[AsyncStateMachine(typeof(_003CAddClass_003Ed__104))]
	public Task AddClass(string className)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		_003CAddClass_003Ed__104 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E1__state = -1;
				num = 5;
				break;
			case 5:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				break;
			case 6:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				_ = 1;
				if (!y3OaHpP3epw6Hi353d())
				{
					num = 3;
					break;
				}
				num = 0;
				if (y3OaHpP3epw6Hi353d())
				{
				}
				break;
			case 0:
			case 2:
				stateMachine.className = className;
				goto case 4;
			default:
				num = 4;
				break;
			case 1:
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 0;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003C_AddClass_003Ed__105))]
	public Task _AddClass(string className)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003C_AddClass_003Ed__105 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 5;
				continue;
			case 4:
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 0:
				stateMachine._003C_003E1__state = -1;
				goto case 4;
			case 2:
			case 3:
				stateMachine.className = className;
				goto case 0;
			default:
				num = 0;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				if (!WIW3HJrsrBpeJbC7lF())
				{
					num = 6;
					if (!y3OaHpP3epw6Hi353d())
					{
						continue;
					}
					goto case 2;
				}
				num = 3;
				if (true)
				{
					continue;
				}
				break;
			case 7:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CConfirmClassDelete_003Ed__109))]
	private Task<bool> s1UTA8rbX(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CConfirmClassDelete_003Ed__109 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine.itemClass = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoDeleteClass_003Ed__110))]
	public Task DoDeleteClass(object param, Func<string, Task<bool>> confirmationCallback)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDoDeleteClass_003Ed__110 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.param = param;
		stateMachine.confirmationCallback = confirmationCallback;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003C_DoDeleteClass_003Ed__111))]
	public Task _DoDeleteClass(ClassViewModel item, Func<string, Task<bool>> confirmationCallback)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_DoDeleteClass_003Ed__111 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.item = item;
		stateMachine.confirmationCallback = confirmationCallback;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRenameClass_003Ed__112))]
	public Task RenameClass(string oldClassName, string newClassName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		_003CRenameClass_003Ed__112 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine.newClassName = newClassName;
				goto default;
			default:
				_ = 0;
				if (WIW3HJrsrBpeJbC7lF())
				{
					num = 7;
					if (0 == 0)
					{
						continue;
					}
					goto case 0;
				}
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				break;
			case 0:
				stateMachine.oldClassName = oldClassName;
				num = 1;
				continue;
			case 3:
				stateMachine._003C_003Et__builder = uMblsWSSyxwjdr6rcJ();
				num = 2;
				continue;
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 0;
				continue;
			case 5:
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				continue;
			case 4:
			case 7:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			case 8:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003C_RenameClass_003Ed__113))]
	internal Task vWIlFv0oG(string P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (y3OaHpP3epw6Hi353d() ? 6 : 7);
		_003C_RenameClass_003Ed__113 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 7:
				stateMachine._003C_003Et__builder = uMblsWSSyxwjdr6rcJ();
				goto case 1;
			case 5:
				stateMachine.newClassName = P_1;
				goto case 2;
			default:
				num = 2;
				break;
			case 1:
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				if (!y3OaHpP3epw6Hi353d())
				{
					break;
				}
				goto case 4;
			case 4:
				stateMachine.oldClassName = P_0;
				num = 5;
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				num = 3;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLabelCurrentImage_003Ed__114))]
	public Task LabelCurrentImage(ClassViewModel classViewModel)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		y3OaHpP3epw6Hi353d();
		int num = ((!WIW3HJrsrBpeJbC7lF()) ? 5 : 4);
		_003CLabelCurrentImage_003Ed__114 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003E1__state = -1;
				num = 1;
				if (WIW3HJrsrBpeJbC7lF())
				{
					continue;
				}
				goto case 2;
			case 2:
				stateMachine.classViewModel = classViewModel;
				goto default;
			case 6:
				stateMachine._003C_003E4__this = this;
				num = 2;
				continue;
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 7;
				continue;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 6;
				if (!y3OaHpP3epw6Hi353d())
				{
					continue;
				}
				break;
			case 7:
				break;
			}
			break;
		}
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003C_LabelCurrentImage_003Ed__115))]
	public Task<string> _LabelCurrentImage(ClassViewModel classViewModel)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_LabelCurrentImage_003Ed__115 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.classViewModel = classViewModel;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003C_LabelCurrentImage_Internal_003Ed__116))]
	private Task<string> LtCBqOD3n(ClassViewModel P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_LabelCurrentImage_Internal_003Ed__116 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.classViewModel = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRemoveCurrentImage_003Ed__117))]
	public Task RemoveCurrentImage()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		_003CRemoveCurrentImage_003Ed__117 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E4__this = this;
				_ = 1;
				num = (y3OaHpP3epw6Hi353d() ? 5 : 0);
				break;
			case 1:
				stateMachine._003C_003Et__builder = uMblsWSSyxwjdr6rcJ();
				num = 4;
				if (true)
				{
					break;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (true)
				{
					break;
				}
				goto case 0;
			case 0:
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private bool kYiE8nSwg()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return yd3jfKdsj().Any();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private bool jtI1MEUuC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return yd3jfKdsj().Any([MethodImpl(MethodImplOptions.NoInlining)] (ClassifyImage image) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return image.IsLabeled;
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private IEnumerable<ClassifyImage> yd3jfKdsj()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Classes.SelectMany([MethodImpl(MethodImplOptions.NoInlining)] (ClassViewModel category) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return category.AllImageViewModels;
		}).SelectMany([MethodImpl(MethodImplOptions.NoInlining)] (ImageListViewModel imageViewModel) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return imageViewModel.SelectedImages;
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private IEnumerable<ClassifyImage> kA1q4NV5b()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Classes.SelectMany([MethodImpl(MethodImplOptions.NoInlining)] (ClassViewModel category) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return category.UnlabeledImages;
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private ClassViewModel jxie4Fcpv(ClassifyImage P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return GetCategory((string)sOGpYAFmwNTNZHmbM6(P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ClassViewModel GetCategory(string categoryName)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass129_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass129_0();
		CS_0024_003C_003E8__locals2.categoryName = categoryName;
		return Classes.FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (ClassViewModel vm) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return vm.ClassName == CS_0024_003C_003E8__locals2.categoryName;
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanUnlabelSelectedImages()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return yd3jfKdsj().Any([MethodImpl(MethodImplOptions.NoInlining)] (ClassifyImage image) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec.SoWjby1k5mFmNVH1AHr(image);
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoUnlabelSelectedImages_003Ed__134))]
	public Task DoUnlabelSelectedImages()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		_003CDoUnlabelSelectedImages_003Ed__134 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				stateMachine._003C_003Et__builder = uMblsWSSyxwjdr6rcJ();
				num = 1;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				num = (WIW3HJrsrBpeJbC7lF() ? 4 : 0);
				break;
			case 2:
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoUnlabelImages_003Ed__135))]
	public Task DoUnlabelImages(List<ClassifyImage> images)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDoUnlabelImages_003Ed__135 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.images = images;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003C_DoUnlabelImages_003Ed__136))]
	internal Task Oait7AyuH(IEnumerable<ClassifyImage> P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_DoUnlabelImages_003Ed__136 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.images = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoRemoveSelectedImages_003Ed__140))]
	public Task DoRemoveSelectedImages()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num = (y3OaHpP3epw6Hi353d() ? 2 : 4);
		_003CDoRemoveSelectedImages_003Ed__140 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = uMblsWSSyxwjdr6rcJ();
				goto case 1;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				break;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003C_DoRemoveSelectedImages_003Ed__141))]
	internal Task FQt30A3AL(IEnumerable<ClassifyImage> P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_DoRemoveSelectedImages_003Ed__141 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.images = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoRemoveUnlabeledImages_003Ed__145))]
	public Task DoRemoveUnlabeledImages()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		WIW3HJrsrBpeJbC7lF();
		int num = (y3OaHpP3epw6Hi353d() ? 5 : 4);
		_003CDoRemoveUnlabeledImages_003Ed__145 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 2:
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 1;
			default:
				num = 1;
				break;
			case 3:
				stateMachine._003C_003E4__this = this;
				goto case 2;
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = uMblsWSSyxwjdr6rcJ();
				num = 3;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoRelabelSelectedImages_003Ed__156))]
	public Task DoRelabelSelectedImages()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CDoRelabelSelectedImages_003Ed__156 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003Et__builder = uMblsWSSyxwjdr6rcJ();
				y3OaHpP3epw6Hi353d();
				num = ((!WIW3HJrsrBpeJbC7lF()) ? 5 : 0);
				break;
			case 0:
			case 1:
				stateMachine._003C_003E4__this = this;
				num = 2;
				break;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (WIW3HJrsrBpeJbC7lF())
				{
					break;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoRelabelImages_003Ed__157))]
	public Task DoRelabelImages(List<ClassifyImage> images, string classLabel)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDoRelabelImages_003Ed__157 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.images = images;
		stateMachine.classLabel = classLabel;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003C_DoRelabelImages_003Ed__158))]
	internal Task Q7XCNWHf0(IEnumerable<ClassifyImage> P_0, string P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_DoRelabelImages_003Ed__158 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.images = P_0;
		stateMachine.classLabel = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CReportImportResults_003Ed__162))]
	private Task<bool> HknrmeWHh(int P_0, int P_1, bool P_2 = true, string P_3 = "")
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CReportImportResults_003Ed__162 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.actual = P_0;
		stateMachine.expected = P_1;
		stateMachine.success = P_2;
		stateMachine.failureMessage = P_3;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string vU3ilu7v4(string P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 6;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 6:
				if (JNnUUVEsxFZ2ZNXEF3(P_0) <= P_1)
				{
					y3OaHpP3epw6Hi353d();
					if (WIW3HJrsrBpeJbC7lF())
					{
						num = 0;
						if (y3OaHpP3epw6Hi353d())
						{
						}
						continue;
					}
					num = 4;
					if (0 == 0)
					{
						continue;
					}
					goto default;
				}
				P_0 = (string)fq2oMY59VM3GNonopR(P_0, JNnUUVEsxFZ2ZNXEF3(P_0) - P_1 + 1);
				num = 5;
				if (0 == 0)
				{
					continue;
				}
				goto case 5;
			case 2:
				P_0 = P_0.Substring(num2);
				num = 7;
				continue;
			case 0:
			case 1:
				return P_0;
			case 5:
				num2 = Y1jbci3I7rtMYKv6qQ(P_0, Path.DirectorySeparatorChar);
				goto default;
			default:
				if (num2 > 0)
				{
					num = 2;
					continue;
				}
				break;
			case 7:
				break;
			}
			break;
		}
		return (string)lgbvLfgoSw8BloN8DH(512) + P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoImportImages_003Ed__164))]
	public Task DoImportImages(IEnumerable<string> fileNames)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CDoImportImages_003Ed__164 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.fileNames = fileNames;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003C_DoImportImages_003Ed__165))]
	internal Task<string[]> beG6cP0CX(IEnumerable<string> P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_DoImportImages_003Ed__165 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.fileNames = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Bitmap X7vnr2ESJ(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		using Image image = (Image)ToIYc3aP96OpSUkDrP(P_0);
		Rectangle rect = new Rectangle(0, 0, tGRRyJoyUOY2XKtd19(image), image.Height);
		return (image as Bitmap).Clone(rect, dGAuY6ctdatwE2wBVT(image));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CGetUnlabeledImageIDs_003Ed__167))]
	private Task<string[]> HxYHPrlul()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CGetUnlabeledImageIDs_003Ed__167 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	private IEnumerable<ImageListViewModel> FofgcJwcd()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Classes.SelectMany([MethodImpl(MethodImplOptions.NoInlining)] (ClassViewModel viewModel) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return viewModel.AllImageViewModels;
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<ClassifyImage> GetImagesFromIds(string[] ids)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass170_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass170_0();
		CS_0024_003C_003E8__locals2.ids = ids;
		return FofgcJwcd().SelectMany([MethodImpl(MethodImplOptions.NoInlining)] (ImageListViewModel imgList) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return imgList;
		}).Where([MethodImpl(MethodImplOptions.NoInlining)] (ClassifyImage img) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return CS_0024_003C_003E8__locals2.ids.Contains((string)_003C_003Ec__DisplayClass170_0.XHUed182JtCLt8uX5RZ(img));
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void JW4pEca9M(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		if (y3OaHpP3epw6Hi353d())
		{
			goto IL_001e;
		}
		goto IL_00b4;
		IL_001e:
		IEnumerator<ImageListViewModel> enumerator = default;
		try
		{
			while (vTlhmCxcVidl4f89YG(enumerator))
			{
				ahco9SBPHexEGsmM39(enumerator.Current.SelectedImages);
			}
		}
		finally
		{
			if (enumerator != null)
			{
				FP7mOGdfUnkiPWkOVN(enumerator);
			}
		}
		goto IL_0050;
		IL_00b4:
		_003C_003Ec__DisplayClass171_0 obj = default;
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 4:
				enumerator = FofgcJwcd().Where(obj._003CSelectedImages_CollectionChanged_003Eb__0).GetEnumerator();
				break;
			default:
				num = 2;
				continue;
			case 3:
				WBnd9Phk1jvw4Stb1m(Rs0InCbu0g);
				goto case 5;
			case 8:
				goto IL_0106;
			case 7:
				goto IL_0122;
			case 0:
			case 1:
				obj.sender = P_0;
				num = 7;
				if (WIW3HJrsrBpeJbC7lF())
				{
					continue;
				}
				goto case 5;
			case 5:
			case 6:
				WBnd9Phk1jvw4Stb1m(r64IrS3U6g);
				num = 9;
				continue;
			case 9:
				return;
			}
			break;
			IL_0122:
			if (qwxqMhuC7ZlwQBaf1g(P_1) == NotifyCollectionChangedAction.Add)
			{
				num = 4;
				continue;
			}
			goto IL_0050;
			IL_0106:
			obj = new _003C_003Ec__DisplayClass171_0();
			_ = 1;
			num = (y3OaHpP3epw6Hi353d() ? 5 : 0);
		}
		goto IL_001e;
		IL_0050:
		gpsICqjvSK.RaiseCanExecuteChanged();
		num = 3;
		if (y3OaHpP3epw6Hi353d())
		{
		}
		goto IL_00b4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshClasses_003Ed__172))]
	public Task RefreshClasses()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		y3OaHpP3epw6Hi353d();
		int num;
		if (WIW3HJrsrBpeJbC7lF())
		{
			num = 5;
			if (!WIW3HJrsrBpeJbC7lF())
			{
				goto IL_002e;
			}
		}
		else
		{
			num = 3;
			if (false)
			{
				goto IL_005e;
			}
		}
		goto IL_0078;
		IL_0078:
		_003CRefreshClasses_003Ed__172 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				break;
			case 0:
			case 5:
				stateMachine._003C_003Et__builder = uMblsWSSyxwjdr6rcJ();
				break;
			case 4:
				goto IL_005e;
			default:
				num = 2;
				continue;
			case 2:
				goto IL_00a3;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_002e;
		IL_00a3:
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		num = 6;
		goto IL_0078;
		IL_002e:
		stateMachine._003C_003E4__this = this;
		num = 4;
		goto IL_0078;
		IL_005e:
		stateMachine._003C_003E1__state = -1;
		goto IL_00a3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshJobFailClasses_003Ed__173))]
	public Task RefreshJobFailClasses()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CRefreshJobFailClasses_003Ed__173 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				break;
			case 1:
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
				stateMachine._003C_003Et__builder = uMblsWSSyxwjdr6rcJ();
				WIW3HJrsrBpeJbC7lF();
				num = ((!y3OaHpP3epw6Hi353d()) ? 4 : 2);
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddClassSorted(ClassViewModel newClass)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 1;
		int num2 = default;
		Comparer<string> comparer = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
				Classes.Insert(num2, newClass);
				num = 8;
				break;
			case 1:
				comparer = Comparer<string>.Default;
				num = 7;
				break;
			case 7:
				num2 = 0;
				num = 4;
				break;
			case 6:
				if (comparer.Compare((string)OF4yFjQAbWHX5nefnl(Classes[num2]), (string)OF4yFjQAbWHX5nefnl(newClass)) < 0)
				{
					num2++;
					_ = 1;
					if (y3OaHpP3epw6Hi353d())
					{
						num = 2;
						break;
					}
					num = 0;
					if (true)
					{
						break;
					}
				}
				goto case 2;
			case 0:
			case 3:
			case 4:
				if (num2 >= G9n8jdUKJBLoGVeqdT(Classes))
				{
					goto case 2;
				}
				goto case 6;
			default:
				num = 6;
				if (y3OaHpP3epw6Hi353d())
				{
				}
				break;
			case 8:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshLabeledImages_003Ed__175))]
	public Task RefreshLabeledImages()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!WIW3HJrsrBpeJbC7lF()) ? 1 : 2);
		_003CRefreshLabeledImages_003Ed__175 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E4__this = this;
				num = 5;
				if (y3OaHpP3epw6Hi353d())
				{
				}
				continue;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = uMblsWSSyxwjdr6rcJ();
				num = 4;
				if (true)
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
	[AsyncStateMachine(typeof(_003CRefreshUnlabeledImages_003Ed__176))]
	public Task RefreshUnlabeledImages()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 0;
		int num = ((!WIW3HJrsrBpeJbC7lF()) ? 2 : 4);
		_003CRefreshUnlabeledImages_003Ed__176 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				stateMachine._003C_003Et__builder = uMblsWSSyxwjdr6rcJ();
				goto case 1;
			case 5:
				stateMachine._003C_003E1__state = -1;
				goto case 3;
			default:
				num = 3;
				if (y3OaHpP3epw6Hi353d())
				{
				}
				break;
			case 3:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (true)
				{
					break;
				}
				goto case 1;
			case 1:
			case 2:
				stateMachine._003C_003E4__this = this;
				num = 5;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshLabeledImagePredictions_003Ed__177))]
	public Task RefreshLabeledImagePredictions()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 4;
		_003CRefreshLabeledImagePredictions_003Ed__177 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 2;
				if (true)
				{
					continue;
				}
				goto case 2;
			case 2:
				stateMachine._003C_003E1__state = -1;
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				continue;
			case 4:
				stateMachine._003C_003Et__builder = uMblsWSSyxwjdr6rcJ();
				_ = 0;
				if (!WIW3HJrsrBpeJbC7lF())
				{
					num = 0;
					if (!y3OaHpP3epw6Hi353d())
					{
						continue;
					}
					goto default;
				}
				num = 5;
				if (true)
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
	public void RefreshIsBelowThreshold()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IEnumerator<ClassifyImage> enumerator = LabeledImages.GetEnumerator();
		try
		{
			while (vTlhmCxcVidl4f89YG(enumerator))
			{
				ClassifyImage current = enumerator.Current;
				CZSoMuVRKGNVyWPknW(current, gGXmWlq66XVxDJryTO(current) < ClassificationThreshold);
			}
		}
		finally
		{
			if (enumerator != null)
			{
				FP7mOGdfUnkiPWkOVN(enumerator);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshUnlabeledImagePredictions_003Ed__179))]
	public Task RefreshUnlabeledImagePredictions()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		y3OaHpP3epw6Hi353d();
		int num = ((!WIW3HJrsrBpeJbC7lF()) ? 1 : 2);
		_003CRefreshUnlabeledImagePredictions_003Ed__179 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (WIW3HJrsrBpeJbC7lF())
				{
					break;
				}
				goto case 5;
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 4;
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 0:
			case 2:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 5;
				break;
			case 6:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zsgWNWs1B()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IEnumerator<ClassViewModel> enumerator = Classes.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass180_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass180_0();
				WIW3HJrsrBpeJbC7lF();
				int num = (y3OaHpP3epw6Hi353d() ? 2 : 3);
				while (true)
				{
					switch (num)
					{
					default:
						goto IL_003f;
					case 0:
					case 3:
						CS_0024_003C_003E8__locals3.classItemVM = enumerator.Current;
						goto IL_003f;
					case 4:
						break;
					}
					break;
					IL_003f:
					CS_0024_003C_003E8__locals3.classItemVM.SetLabeledImages(LabeledImages.Where([MethodImpl(MethodImplOptions.NoInlining)] (ClassifyImage image) =>
					{
						while (false)
						{
							_ = ((object[])null)[0];
						}
						return (string)_003C_003Ec__DisplayClass180_0.piEn20F1QCaJFLgMUKW(image) == (string)_003C_003Ec__DisplayClass180_0.WIuHX6FSV4LFs5NOHDX(CS_0024_003C_003E8__locals3.classItemVM);
					}));
					num = 4;
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				FP7mOGdfUnkiPWkOVN(enumerator);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SortUnlabeledImages()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 8;
		int num2 = default;
		_003C_003Ec__DisplayClass181_0 obj = default;
		while (true)
		{
			switch (num)
			{
			case 2:
			case 5:
			case 9:
				if (num2 >= G9n8jdUKJBLoGVeqdT(Classes))
				{
					num = 11;
					break;
				}
				obj = new _003C_003Ec__DisplayClass181_0();
				goto case 0;
			case 8:
				Classes.FirstOrDefault();
				num = 1;
				break;
			case 4:
			case 6:
				do
				{
					num2++;
					num = 5;
				}
				while (1 == 0);
				break;
			case 1:
				num2 = 0;
				_ = 0;
				num = (WIW3HJrsrBpeJbC7lF() ? 9 : 0);
				break;
			case 7:
				obj.classItemVM.SetUnlabeledImages(UnlabeledImages.Where(obj._003CSortUnlabeledImages_003Eb__0));
				num = 6;
				if (WIW3HJrsrBpeJbC7lF())
				{
					break;
				}
				goto case 0;
			case 0:
			case 3:
				obj.classItemVM = Classes[num2];
				num = 10;
				break;
			case 10:
				if (num2 != 0)
				{
					obj.classItemVM.SetUnlabeledImages(UnlabeledImages.Where(obj._003CSortUnlabeledImages_003Eb__1));
					num = 4;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				}
				goto case 7;
			default:
				num = 7;
				break;
			case 11:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pRISqXAWO()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		IsLastPass = Classes.Where([MethodImpl(MethodImplOptions.NoInlining)] (ClassViewModel c) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return !_003C_003Ec.Vdn0MY1gUQuSqMy8vWP(_003C_003Ec.Dybv9G14B5kKB7qqtim(c));
		}).Count() <= 1 && G9n8jdUKJBLoGVeqdT(Classes) > 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void q45KK2cXZ(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		IEnumerator<ClassViewModel> enumerator = default;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				enumerator = ((IEnumerable)kXvy1CiH305rqeyxOt(P_1)).OfType<ClassViewModel>().GetEnumerator();
				goto case 2;
			case 3:
				if (kXvy1CiH305rqeyxOt(P_1) != null)
				{
					y3OaHpP3epw6Hi353d();
					num = (WIW3HJrsrBpeJbC7lF() ? 4 : 5);
					break;
				}
				goto IL_00cf;
			case 0:
				enumerator = P_1.NewItems.OfType<ClassViewModel>().GetEnumerator();
				num = 6;
				break;
			case 2:
			case 5:
				try
				{
					while (enumerator.MoveNext())
					{
						ClassViewModel current2 = enumerator.Current;
						current2.PropertyChanged -= b0ym2REfY;
						B76B17LvVyaUuUtFCk(current2.ClassResult, new PropertyChangedEventHandler(UEaM78N78));
						ItKcrYtksgVntNmPu1(current2);
					}
				}
				finally
				{
					if (enumerator != null)
					{
						FP7mOGdfUnkiPWkOVN(enumerator);
					}
				}
				goto IL_00cf;
			default:
				num = 0;
				break;
			case 6:
				{
					try
					{
						while (vTlhmCxcVidl4f89YG(enumerator))
						{
							ClassViewModel current = enumerator.Current;
							WTfkjVvGeaICKsGZdn(current, new PropertyChangedEventHandler(b0ym2REfY));
							WTfkjVvGeaICKsGZdn(kQ12reZSGoo3A12LHQ(current), new PropertyChangedEventHandler(UEaM78N78));
						}
						return;
					}
					finally
					{
						if (enumerator != null)
						{
							FP7mOGdfUnkiPWkOVN(enumerator);
						}
					}
				}
				IL_00cf:
				if (lB29YD93okMskJwprK(P_1) != null)
				{
					goto case 0;
				}
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void b0ym2REfY(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_ = 1;
		int num;
		if (!y3OaHpP3epw6Hi353d())
		{
			num = 3;
		}
		else
		{
			num = 4;
			if (!WIW3HJrsrBpeJbC7lF())
			{
				goto IL_009d;
			}
		}
		goto IL_0046;
		IL_0046:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				CQZ28d1A02GSjUIvqw(this, plfGltUiaC1OFfC2I8.OIRNC4VQ7F(592));
				break;
			default:
				goto IL_0063;
			case 0:
			case 3:
				if ((string)IdjtUD0R0Lb8XQwfrT(P_1) == plfGltUiaC1OFfC2I8.OIRNC4VQ7F(560))
				{
					goto case 1;
				}
				return;
			case 2:
				break;
			case 5:
				return;
			}
			break;
			IL_0063:
			num = 2;
		}
		goto IL_009d;
		IL_009d:
		CQZ28d1A02GSjUIvqw(this, lgbvLfgoSw8BloN8DH(64));
		num = 5;
		goto IL_0046;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UEaM78N78(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if ((string)IdjtUD0R0Lb8XQwfrT(P_1) == plfGltUiaC1OFfC2I8.OIRNC4VQ7F(634))
		{
			pRISqXAWO();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CAddDroppedImages_003Ed__194))]
	public Task AddDroppedImages(List<ClassifyImage> images, bool srcIsLabeled, string destlabel, bool destIsLabeled)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003CAddDroppedImages_003Ed__194 stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.images = images;
		stateMachine.srcIsLabeled = srcIsLabeled;
		stateMachine.destlabel = destlabel;
		stateMachine.destIsLabeled = destIsLabeled;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRunSheet_003Ed__197))]
	public Task RunSheet()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		_003CRunSheet_003Ed__197 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto default;
			case 1:
			case 5:
				stateMachine._003C_003E4__this = this;
				num = 4;
				continue;
			case 0:
				stateMachine._003C_003Et__builder = uMblsWSSyxwjdr6rcJ();
				_ = 1;
				if (y3OaHpP3epw6Hi353d())
				{
					num = 2;
					continue;
				}
				num = 5;
				if (true)
				{
					continue;
				}
				goto default;
			default:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 6;
				if (WIW3HJrsrBpeJbC7lF())
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
	public void UpdateToolName(string name)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Ulvl9dONSak3W3G0oe(pLu4jtXb7, name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CToggleFailClass_003Ed__203))]
	internal Task K1l72V6Eg(string P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 5;
		if (!WIW3HJrsrBpeJbC7lF())
		{
			goto IL_001e;
		}
		goto IL_0038;
		IL_001e:
		_003CToggleFailClass_003Ed__203 stateMachine = default;
		stateMachine.failTool = P_1;
		goto IL_00bd;
		IL_0038:
		while (true)
		{
			switch (num)
			{
			case 3:
			case 6:
				break;
			default:
				num = 1;
				if (!y3OaHpP3epw6Hi353d())
				{
					continue;
				}
				goto case 7;
			case 7:
				stateMachine._003C_003E4__this = this;
				_ = 0;
				num = ((!WIW3HJrsrBpeJbC7lF()) ? 6 : 0);
				continue;
			case 5:
				stateMachine._003C_003Et__builder = uMblsWSSyxwjdr6rcJ();
				num = 7;
				continue;
			case 0:
			case 2:
				stateMachine.classLabel = P_0;
				break;
			case 1:
				goto IL_00bd;
			case 4:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				continue;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
			break;
		}
		goto IL_001e;
		IL_00bd:
		stateMachine._003C_003E1__state = -1;
		num = 4;
		goto IL_0038;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003C_ToggleFailClass_003Ed__204))]
	internal Task F5oYhHPHM(string P_0, bool P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 0;
		if (!y3OaHpP3epw6Hi353d())
		{
		}
		_003C_ToggleFailClass_003Ed__204 stateMachine = default;
		while (true)
		{
			switch (num)
			{
			case 3:
				stateMachine._003C_003E4__this = this;
				y3OaHpP3epw6Hi353d();
				if (WIW3HJrsrBpeJbC7lF())
				{
					num = 7;
					if (WIW3HJrsrBpeJbC7lF())
					{
						break;
					}
					goto case 1;
				}
				num = 6;
				if (true)
				{
					break;
				}
				goto case 5;
			case 1:
				stateMachine.failTool = P_1;
				goto case 4;
			default:
				num = 4;
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				goto case 5;
			case 5:
			case 6:
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
				num = 8;
				break;
			case 2:
			case 7:
				stateMachine.classLabel = P_0;
				num = 1;
				break;
			case 0:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num = 3;
				break;
			case 8:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Classifier()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		RSfePjJGGLFC8jVEmC();
		nRHUj2QK9 = plfGltUiaC1OFfC2I8.OIRNC4VQ7F(690);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool BTW0yooBh()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (kYiE8nSwg())
		{
			return jtI1MEUuC();
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool FG7v2M62S()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return kYiE8nSwg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool g5FLIrUk6()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (kYiE8nSwg())
		{
			string selectedClassLabel = SelectedClassLabel;
			if (selectedClassLabel == null)
			{
				return false;
			}
			return LciT2yKsyFmAysBpkA(selectedClassLabel) > 0;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private Task N3CdteRUE(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return DoDeleteClass(P_0, s1UTA8rbX);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private Task d0B5HAGvy(IEnumerable<string> P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return DoImportImages(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool TTkfKWrQZ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (AreImagesUnlabeled)
		{
			return !IsOnline;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool GTJ9hoiJ2(CvsCell P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AjFaRACRClWEtW8pDr(P_0) == tSo9rUA1iJHkrZbR9u(pLu4jtXb7);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool uqIASceUE(ClassifyImage P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)FJKldiNbogG6CP8ovq(P_0) == CurrentImageName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private bool qonyDd0Ur(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003Ec__DisplayClass172_1 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass172_1();
		CS_0024_003C_003E8__locals2.className = P_0;
		return !Classes.Any([MethodImpl(MethodImplOptions.NoInlining)] (ClassViewModel u) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return _003C_003Ec__DisplayClass172_1.w2kMJt8D887KmIxoCyI(_003C_003Ec__DisplayClass172_1.MYnkBb86F1dy9jRd2no(u), CS_0024_003C_003E8__locals2.className);
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003C_003CRefreshUnlabeledImages_003Eb__176_1_003Ed))]
	[CompilerGenerated]
	private Task<ClassifyImage> IYruI1N2o(string P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		_003C_003CRefreshUnlabeledImages_003Eb__176_1_003Ed stateMachine = default;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ClassifyImage>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.imageId = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gDB8tx4rrjYrTFcLs8(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsInSight)P_0).IsOnline;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lgbvLfgoSw8BloN8DH(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CQZ28d1A02GSjUIvqw(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).FirePropertyChangedExplicit((string)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WIW3HJrsrBpeJbC7lF()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool y3OaHpP3epw6Hi353d()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder uMblsWSSyxwjdr6rcJ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return AsyncTaskMethodBuilder.Create();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool H4pTiC6hHnohvHFq47(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 != (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sscotgDKfcbGHeY4oR(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsResultSet)P_0).Cells;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lptMvf8OoKwqV9B3CF(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).RaisePropertyChangedEvent((PropertyChangedEventArgs)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sOGpYAFmwNTNZHmbM6(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ClassifyImage)P_0).Label;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Hkpj9lsoXPlkar5gCi(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<string>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FP7mOGdfUnkiPWkOVN(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IDisposable)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int JNnUUVEsxFZ2ZNXEF3(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fq2oMY59VM3GNonopR(object P_0, int P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Substring(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Y1jbci3I7rtMYKv6qQ(object P_0, char P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).IndexOf(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ToIYc3aP96OpSUkDrP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Image.FromFile((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int tGRRyJoyUOY2XKtd19(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Image)P_0).Width;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static System.Drawing.Imaging.PixelFormat dGAuY6ctdatwE2wBVT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Image)P_0).PixelFormat;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static NotifyCollectionChangedAction qwxqMhuC7ZlwQBaf1g(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((NotifyCollectionChangedEventArgs)P_0).Action;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ahco9SBPHexEGsmM39(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((Collection<ClassifyImage>)P_0).Clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vTlhmCxcVidl4f89YG(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IEnumerator)P_0).MoveNext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WBnd9Phk1jvw4Stb1m(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseDelegateCommand)P_0).RaiseCanExecuteChanged();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int G9n8jdUKJBLoGVeqdT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((Collection<ClassViewModel>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OF4yFjQAbWHX5nefnl(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ClassViewModel)P_0).ClassName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double gGXmWlq66XVxDJryTO(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ClassifyImage)P_0).Score;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CZSoMuVRKGNVyWPknW(object P_0, bool value)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ClassifyImage)P_0).IsBelowThreshold = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kXvy1CiH305rqeyxOt(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((NotifyCollectionChangedEventArgs)P_0).OldItems;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void B76B17LvVyaUuUtFCk(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ItKcrYtksgVntNmPu1(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ClassViewModel)P_0).Dispose();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lB29YD93okMskJwprK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((NotifyCollectionChangedEventArgs)P_0).NewItems;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WTfkjVvGeaICKsGZdn(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kQ12reZSGoo3A12LHQ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ClassViewModel)P_0).ClassResult;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IdjtUD0R0Lb8XQwfrT(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertyChangedEventArgs)P_0).PropertyName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Ulvl9dONSak3W3G0oe(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((IClassifierHandle)P_0).ToolName = (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool kWRFphHXaU3muG1yNZ(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return string.IsNullOrEmpty((string)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vv4PwZTtkOnle0xvIU(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IClassifierHandle)P_0).InitialImagesPathHasImages;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object sBOeUsYjE6Zcv8lp1F(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IClassifierHandle)P_0).InitialImagesPath;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RSfePjJGGLFC8jVEmC()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int LciT2yKsyFmAysBpkA(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((string)P_0).Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation AjFaRACRClWEtW8pDr(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((CvsCell)P_0).Location;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CvsCellLocation tSo9rUA1iJHkrZbR9u(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((IClassifierHandle)P_0).GetCellLocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object FJKldiNbogG6CP8ovq(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((ClassifyImage)P_0).ImageId;
	}
}
