using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Cognex.InSight.ViDiEL.ViewModels.Extensions;
using Cognex.Mvvm;
using jUKn21pup6XFIrInBb;
using nbEpNqgj9oMmbCm0Ft;

namespace Cognex.InSight.ViDiEL.ViewModels.PropertySheets;

public class ImageListViewModel : BaseViewModel, INotifyCollectionChanged, IEnumerable<ClassifyImage>, IEnumerable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<ClassifyImage> _003C_003E9__2_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CGObq0xYRKTbDJ6MMsA();
			_003C_003E9 = new _003C_003Ec();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _003C_003Ec()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			CGObq0xYRKTbDJ6MMsA();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int _003C_002Ector_003Eb__2_0(ClassifyImage a, ClassifyImage b)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			if (Bg1ZmdxJbFxT8AuCLhS(a) != Bg1ZmdxJbFxT8AuCLhS(b))
			{
				return WE3f2TxKoWJofbkF5U4(Bg1ZmdxJbFxT8AuCLhS(a) - Bg1ZmdxJbFxT8AuCLhS(b));
			}
			return string.Compare((string)IyVTikxCDbpLF69cM1t(a), (string)IyVTikxCDbpLF69cM1t(b));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void CGObq0xYRKTbDJ6MMsA()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool B5jIv9xH7UHuCERIX5Q()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kywldkxTtGfCBmf63sr()
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double Bg1ZmdxJbFxT8AuCLhS(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassifyImage)P_0).Score;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int WE3f2TxKoWJofbkF5U4(double P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return Math.Sign(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IyVTikxCDbpLF69cM1t(object P_0)
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ((ClassifyImage)P_0).ImageId;
		}
	}

	private readonly List<ClassifyImage> mOdouKYwRB;

	private readonly Comparer<ClassifyImage> Oi6oZUD4UY;

	[CompilerGenerated]
	private readonly bool QcRoJyje7g;

	[CompilerGenerated]
	private ClassViewModel pUvoFgjb8h;

	private ObservableCollection<ClassifyImage> BLpocC6tTJ;

	[CompilerGenerated]
	private NotifyCollectionChangedEventHandler VNSoR96BMS;

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
			return QcRoJyje7g;
		}
	}

	public ClassViewModel ParentVm
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return pUvoFgjb8h;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			pUvoFgjb8h = value;
		}
	}

	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return ATtkqgro9QkJti3c3DK(mOdouKYwRB);
		}
	}

	public ObservableCollection<ClassifyImage> SelectedImages
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			return BLpocC6tTJ;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			BLpocC6tTJ.Update(value);
		}
	}

	public event NotifyCollectionChangedEventHandler CollectionChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			cGHPN7rEEMoikpNcXnb();
			int num = (EviMkBr5QCbpLC97uHD() ? 4 : 5);
			NotifyCollectionChangedEventHandler value2 = default;
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler2 = default;
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler = default;
			while (true)
			{
				switch (num)
				{
				case 2:
					value2 = (NotifyCollectionChangedEventHandler)nOFp4DrclTPIFrOaEQY(notifyCollectionChangedEventHandler2, value);
					goto case 6;
				default:
					num = 6;
					break;
				case 1:
				case 4:
					notifyCollectionChangedEventHandler2 = notifyCollectionChangedEventHandler;
					num = 2;
					break;
				case 0:
				case 5:
					notifyCollectionChangedEventHandler = VNSoR96BMS;
					goto case 1;
				case 6:
					notifyCollectionChangedEventHandler = Interlocked.CompareExchange(ref VNSoR96BMS, value2, notifyCollectionChangedEventHandler2);
					num = 3;
					if (true)
					{
						break;
					}
					goto case 3;
				case 3:
					if ((object)notifyCollectionChangedEventHandler == notifyCollectionChangedEventHandler2)
					{
						num = 7;
						break;
					}
					goto case 1;
				case 7:
					return;
				}
			}
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
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler = default;
			NotifyCollectionChangedEventHandler value2 = default;
			NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler2 = default;
			while (true)
			{
				switch (num)
				{
				case 4:
					notifyCollectionChangedEventHandler = VNSoR96BMS;
					num = 5;
					continue;
				case 2:
				case 6:
					value2 = (NotifyCollectionChangedEventHandler)piNoIOruPluQcx7ON32(notifyCollectionChangedEventHandler2, value);
					break;
				case 0:
					if ((object)notifyCollectionChangedEventHandler == notifyCollectionChangedEventHandler2)
					{
						num = 7;
						if (0 == 0)
						{
							continue;
						}
					}
					goto case 5;
				case 5:
					notifyCollectionChangedEventHandler2 = notifyCollectionChangedEventHandler;
					EviMkBr5QCbpLC97uHD();
					if (!cGHPN7rEEMoikpNcXnb())
					{
						num = 1;
						if (EviMkBr5QCbpLC97uHD())
						{
						}
					}
					else
					{
						num = 6;
					}
					continue;
				case 7:
					return;
				}
				notifyCollectionChangedEventHandler = Interlocked.CompareExchange(ref VNSoR96BMS, value2, notifyCollectionChangedEventHandler2);
				num = 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ImageListViewModel(bool isLabeled, ClassViewModel parent)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		EviMkBr5QCbpLC97uHD();
		int num = ((!cGHPN7rEEMoikpNcXnb()) ? 2 : 3);
		while (true)
		{
			switch (num)
			{
			case 5:
				QcRoJyje7g = isLabeled;
				goto case 2;
			case 1:
				hLTJHGraWZQQ5AXPT6R(this);
				num = 5;
				break;
			case 8:
				mOdouKYwRB = new List<ClassifyImage>();
				num = 4;
				if (cGHPN7rEEMoikpNcXnb())
				{
					break;
				}
				goto case 2;
			case 2:
			case 6:
				ParentVm = parent;
				num = 9;
				break;
			case 0:
			case 3:
				IZtZCnr3paedEyAEtyQ();
				num = 8;
				break;
			case 7:
				BLpocC6tTJ = new ObservableCollection<ClassifyImage>();
				goto case 1;
			default:
				num = 1;
				if (EviMkBr5QCbpLC97uHD())
				{
				}
				break;
			case 4:
				Oi6oZUD4UY = Comparer<ClassifyImage>.Create([MethodImpl(MethodImplOptions.NoInlining)] (ClassifyImage a, ClassifyImage b) =>
				{
					while (false)
					{
						_ = ((object[])null)[0];
					}
					return (_003C_003Ec.Bg1ZmdxJbFxT8AuCLhS(a) != _003C_003Ec.Bg1ZmdxJbFxT8AuCLhS(b)) ? _003C_003Ec.WE3f2TxKoWJofbkF5U4(_003C_003Ec.Bg1ZmdxJbFxT8AuCLhS(a) - _003C_003Ec.Bg1ZmdxJbFxT8AuCLhS(b)) : string.Compare((string)_003C_003Ec.IyVTikxCDbpLF69cM1t(a), (string)_003C_003Ec.IyVTikxCDbpLF69cM1t(b));
				});
				num = 7;
				break;
			case 9:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateImages(IEnumerable<ClassifyImage> images)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		foreach (ClassifyImage item in mOdouKYwRB)
		{
			item.PropertyChanged -= Fn9oAUPnQm;
		}
		mOdouKYwRB.Clear();
		mOdouKYwRB.AddRange(images);
		mOdouKYwRB.Sort(Oi6oZUD4UY);
		mOdouKYwRB.ForEach([MethodImpl(MethodImplOptions.NoInlining)] (ClassifyImage P_0) =>
		{
			while (false)
			{
				_ = ((object[])null)[0];
			}
			zNdngbrqJRYDHRZuibj(P_0, new PropertyChangedEventHandler(Fn9oAUPnQm));
		});
		BLpocC6tTJ.Clear();
		VNSoR96BMS?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<ClassifyImage> GetEnumerator()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return mOdouKYwRB.GetEnumerator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return mOdouKYwRB.GetEnumerator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Fn9oAUPnQm(object P_0, PropertyChangedEventArgs P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		int num = 3;
		if (!cGHPN7rEEMoikpNcXnb())
		{
			return;
		}
		ClassifyImage classifyImage = default;
		int index = default;
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 5:
				return;
			default:
				num = 9;
				break;
			case 1:
			case 10:
				classifyImage = P_0 as ClassifyImage;
				num = 11;
				break;
			case 8:
				JyfpOCrQUlTVLuDR9Qo(VNSoR96BMS, this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Move, classifyImage, index, num2));
				num = 12;
				break;
			case 2:
				num2 = mOdouKYwRB.IndexOf(classifyImage);
				goto case 4;
			case 3:
				if (LNY3n8rhOckVvq276bl(HKd6J5rBSri6neFFxDP(P_1), dorGS0rxIK6W8L8iA4t(716)))
				{
					_ = 1;
					num = ((!EviMkBr5QCbpLC97uHD()) ? 10 : 7);
					break;
				}
				return;
			case 0:
				index = mOdouKYwRB.BinarySearch(classifyImage, Oi6oZUD4UY);
				num = 8;
				break;
			case 9:
				if (VNSoR96BMS != null)
				{
					num = 6;
					break;
				}
				return;
			case 4:
			case 7:
				if (num2 >= 0)
				{
					mOdouKYwRB.Sort(Oi6oZUD4UY);
					goto case 9;
				}
				TewiXGrUUqKppPtCo6D(classifyImage, new PropertyChangedEventHandler(Fn9oAUPnQm));
				num = 5;
				break;
			case 6:
				if (mOdouKYwRB[num2] != classifyImage)
				{
					num = 0;
					break;
				}
				return;
			case 11:
				if (classifyImage != null)
				{
					num = 2;
					break;
				}
				return;
			case 12:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void zXUoyCUQST(ClassifyImage P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		zNdngbrqJRYDHRZuibj(P_0, new PropertyChangedEventHandler(Fn9oAUPnQm));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IZtZCnr3paedEyAEtyQ()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		HZfseUyHkCkPrnXlsW.Lkb8dWLzekCVQ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hLTJHGraWZQQ5AXPT6R(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BaseViewModel)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool cGHPN7rEEMoikpNcXnb()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EviMkBr5QCbpLC97uHD()
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int ATtkqgro9QkJti3c3DK(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((List<ClassifyImage>)P_0).Count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nOFp4DrclTPIFrOaEQY(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object piNoIOruPluQcx7ON32(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HKd6J5rBSri6neFFxDP(object P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((PropertyChangedEventArgs)P_0).PropertyName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dorGS0rxIK6W8L8iA4t(int P_0)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return plfGltUiaC1OFfC2I8.OIRNC4VQ7F(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LNY3n8rhOckVvq276bl(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return (string)P_0 == (string)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TewiXGrUUqKppPtCo6D(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JyfpOCrQUlTVLuDR9Qo(object P_0, object P_1, object P_2)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		P_0(P_1, (NotifyCollectionChangedEventArgs)P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zNdngbrqJRYDHRZuibj(object P_0, object P_1)
	{
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((BasePropertyChanged)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}
}
