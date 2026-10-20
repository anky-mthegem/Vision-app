namespace Cognex.Explorer.Common.AppServices;

public interface IAppService
{
	T GetService<T>() where T : class, IHostService;
}
