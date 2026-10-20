using System.Threading.Tasks;

namespace Cognex.Remoting.CogSocket;

public delegate Task<object> CogSocketInvokeHandler(object sender, CogSocketHandlerArgs e);
