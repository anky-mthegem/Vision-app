using System;

namespace Cognex.InSight;

internal interface IResultBuilder
{
	CvsResultSet Results { get; }

	event EventHandler ResultsChanged;

	void Init();

	void MakeNewResult(bool updateExposedResults, bool runSheet = false);

	void WaitForResultBuildComplete();

	void Stop();

	void Disconnect();
}
