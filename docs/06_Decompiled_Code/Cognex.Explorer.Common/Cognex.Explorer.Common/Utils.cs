using System.IO;
using System.Windows.Media.Imaging;

namespace Cognex.Explorer.Common;

public static class Utils
{
	internal static byte[] ImageToByte(BitmapSource imageSource)
	{
		if (imageSource == null)
		{
			return new byte[0];
		}
		return DedicatedThreadRunner.Run(() => CreateByteStream(imageSource));
	}

	private static byte[] CreateByteStream(BitmapSource imageSource)
	{
		PngBitmapEncoder pngBitmapEncoder = new PngBitmapEncoder();
		pngBitmapEncoder.Frames.Add(BitmapFrame.Create(imageSource, null, null, null));
		using MemoryStream memoryStream = new MemoryStream();
		pngBitmapEncoder.Save(memoryStream);
		return memoryStream.ToArray();
	}

	internal static BitmapSource BytesToImage(byte[] bytes)
	{
		if (bytes.Length == 0)
		{
			return null;
		}
		return DedicatedThreadRunner.Run(() => CreateBitmapSource(bytes));
	}

	private static BitmapSource CreateBitmapSource(byte[] bytes)
	{
		BitmapImage bitmapImage = new BitmapImage();
		using MemoryStream streamSource = new MemoryStream(bytes);
		bitmapImage.BeginInit();
		bitmapImage.StreamSource = streamSource;
		bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
		bitmapImage.EndInit();
		bitmapImage.Freeze();
		return bitmapImage;
	}
}
