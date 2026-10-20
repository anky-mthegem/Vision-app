using System;
using System.IO;
using System.Threading.Tasks;
using Cognex.Remoting.CogSocket;

namespace Cognex.InSight.Internal;

internal interface IRemoteDeviceApi : IDisposable, IMessagePayloadPreview
{
	bool IsDisposed { get; }

	event EventHandler Closed;

	void Initialize(string wssUri, string httpUri, string username);

	IRemoteDeviceApi Clone();

	Task Connect();

	string MakeAbsoluteUrlFromRelativeIfRequired(string relativePath);

	Task<T> GetAsync<T>(string path);

	Task<T> PostAsync<T>(string path, params object[] args);

	Task<T> PostAsync<T>(string path, RequestOptions options, params object[] args);

	Task<T> PutAsync<T>(string path, object arg = null);

	Task<Stream> MakeHttpGetRequest(string url, TimeSpan timeout);

	Task<Stream> MakeHttpPostRequest(string url, TimeSpan timeout, string contentType, Stream dataStream);

	Task<Stream> MakeHttpPostRequest(string url, TimeSpan timeout, string contentType, Stream dataStream, int contentAt, params object[] args);

	Task<Stream> MakeHttpPutRequest(string url, TimeSpan timeout, string contentType, Stream dataStream);

	Task AddListener(string eventName, CogSocketEventHandler listener);

	Task RemoveListener(string eventName, CogSocketEventHandler listener);

	Task<IRemoteDeviceApi> CloneAndConnect();
}
