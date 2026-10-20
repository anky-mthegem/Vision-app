using System;

namespace Cognex.Remoting.CogSocket;

public interface IMessagePayloadPreview
{
	event EventHandler<MessagePayloadPreviewEventArgs> PreviewMessage;
}
