using System.Threading.Tasks;

namespace Cognex.InSight.Services;

public interface IScriptService
{
	Task<string> GetScript();

	Task SetScript(string script);

	Task<object[]> GetConsoleLog();
}
