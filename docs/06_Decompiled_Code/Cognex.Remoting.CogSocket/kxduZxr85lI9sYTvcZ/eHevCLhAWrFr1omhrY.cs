using System;
using System.Threading.Tasks;
using Cognex.Remoting.CogSocket;
using swW0OkHZDnPhGmp0Jx;

namespace kxduZxr85lI9sYTvcZ;

internal interface eHevCLhAWrFr1omhrY : IMessagePayloadPreview
{
	event EventHandler Opened;

	event EventHandler Closed;

	event EventHandler<CogSocketErrorArgs> Error;

	event EventHandler<GwKxq4dal8dyreJLBV> Message;

	void Send(CogSocketMessage P_0);

	Task Connect();

	void Close();

	bool LockAndPing(TimeSpan P_0);
}
