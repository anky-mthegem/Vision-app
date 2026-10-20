using System.Threading.Tasks;
using Cognex.InSight.Cell;
using Cognex.InSight.Remoting.Serialization;
using Cognex.InSight.Undo;

namespace Cognex.InSight.Services;

public interface IPropertySheetService : ISensorConnectionStatusService, IViDiFixtureService
{
	SensorConfiguration Configuration { get; }

	ResourceNode GetSpreadsheetResourceNode(CvsCellLocation location);

	Task<CvsPropertySheetResult> InitializeAsync(CvsCellLocation location, string expression);

	Task CommitAsync(CvsCellLocation location, string expression, string undoText = null);

	Task RollbackAsync();

	Task<CvsPropertySheetResult> SetExpressionAsync(string expression);

	Task<CvsPropertySheetResult> ChangeValueAsync(string expression, int argIndex, string argValue);

	Task<CvsPropertySheetResult> ChangeValuesAsync(string expression, int argIndex, string[] argValues);

	Task<CvsPropertySheetResult> ChangeGraphicValueAsync(string expression, int argIndex, string argValue);

	Task<CvsPropertySheetResult> ChangeGraphicValuesAsync(string expression, int argIndex, string[] argValues);

	Task<CvsPropertySheetResult> GetResultsAsync();

	Task AddGettersOnOk();

	Task<CvsCogEditInfo> GetEditableInfoAsync();

	Task<CvsCogExpressionGraphic> GetEditingEnabledAsync(CvsCogEditInfo editInfo);

	Task<CvsCellRange> EmbedArgumentAsync(CvsCellLocation location, IUndoPropertyAction embedAction);

	void MakeNewResult();

	Task<DynamicArgBinder> GetDynamicArgBinderAsync();

	Task SetBoundArgsAsync(string[] argNames);

	CvsCell GetCell(CvsCellLocation location);
}
