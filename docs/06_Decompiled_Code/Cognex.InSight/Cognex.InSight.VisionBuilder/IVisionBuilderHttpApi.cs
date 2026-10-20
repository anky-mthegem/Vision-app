using System.Net.Http;
using System.Threading.Tasks;
using Cognex.InSight.VisionBuilder.Types;

namespace Cognex.InSight.VisionBuilder;

public interface IVisionBuilderHttpApi
{
	Server Server { get; set; }

	Task<string> GetAuthorizationTokenAsync();

	string GetUserName();

	Task Logout();

	bool IsLoggedIn();

	Task OpenUrl(string url);

	Task<HttpResponseMessage> GetAsync(HttpClient client, string url);

	Task<HttpResponseMessage> PutAsync(HttpClient client, string url, HttpContent payload);

	Task<HttpResponseMessage> PostAsync(HttpClient client, string url, HttpContent payload);

	Task<HttpResponseMessage> PatchAsync(HttpClient client, string url, HttpContent payload);

	Task<HttpResponseMessage> DeleteAsync(HttpClient client, string url);
}
