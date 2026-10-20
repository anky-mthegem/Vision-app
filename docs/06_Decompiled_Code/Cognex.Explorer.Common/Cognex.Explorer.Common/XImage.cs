using System;
using System.Runtime.Serialization;
using System.Windows.Media.Imaging;

namespace Cognex.Explorer.Common;

[Serializable]
public class XImage : ISerializable
{
	public BitmapSource Content { get; }

	public XImage(BitmapSource content)
	{
		Content = content;
	}

	protected XImage(SerializationInfo info, StreamingContext context)
	{
		Content = Utils.BytesToImage((byte[])info.GetValue("Content", typeof(byte[])));
		Content?.Freeze();
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("Content", Utils.ImageToByte(Content));
	}
}
