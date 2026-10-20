using System.ServiceModel;

namespace Cognex.Platform;

[ServiceContract]
public interface IIpcClient
{
	[OperationContract(IsOneWay = true)]
	void Send(string data);
}
