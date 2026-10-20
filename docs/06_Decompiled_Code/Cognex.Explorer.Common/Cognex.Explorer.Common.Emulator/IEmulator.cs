using System.Collections.Generic;

namespace Cognex.Explorer.Common.Emulator;

public interface IEmulator
{
	bool IsRunning { get; }

	string Status { get; }

	string Identifier { get; }

	Dictionary<string, string> Configurations { get; }

	bool Exclusive { get; }

	string ExclusiveMessage { get; }

	string CurrentConfiguration { get; }

	event StatusChangedDelegate StatusChanged;

	event PropertyChangedDelegate PropertyChanged;

	event ConfigurationWindowClosedDelegate ConfigurationWindowClosed;

	event ProcessExitedDelegate ProcessExited;

	void Start(string emulatorConfig);

	void Stop();

	void Refresh();

	void OpenConfiguration(string configurationName);

	void Initialize(EmulatorInfo info);
}
