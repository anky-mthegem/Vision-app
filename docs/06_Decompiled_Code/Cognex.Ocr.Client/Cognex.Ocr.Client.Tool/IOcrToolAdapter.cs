using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cognex.Ocr.Client.Tool;

public interface IOcrToolAdapter
{
	event EventHandler<NewResultArgs> NewResult;

	Task<ICollection<ISample>> GetSamples(string toolId);

	Task<int> GetNumberOfSamples(string toolId);

	Task<int> GetNumberOfUniqueCharacters(string toolId);

	Task<double?> GetConfidencePercentage(string toolId);

	Task<IResultImage> GetImage(string toolId);

	Task<IResultCharacters> GetCharacters(string toolId);

	Task<FieldingResult> GetFieldingResult(string toolId);

	Task<CharacterSize> GetCharacterSize(string toolId);

	Task SetCharacterSize(string toolId, CharacterSize newCharacterSize);

	Task AcceptLabeling(string toolId, string resultId, ICollection<RevisedCharacter> revisedCharacters);

	Task Skip(string toolId);

	Task ChangeSample(string toolId, string sampleId, ICollection<RevisedCharacter> revisedCharacters);

	Task DeleteSamples(string toolId, string[] samplesIds);

	Task<FieldingSettings> GetFielding(string toolId);

	Task SetFielding(string toolId, FieldingSettings fielding);
}
