using System;
using System.Annotations;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using Newtonsoft.Json;

namespace Cognex.Platform;

public static class PlatformCommonOperations
{
	private const int DefaultBufferSize = 4096;

	private const FileOptions DefaultOptions = FileOptions.Asynchronous | FileOptions.SequentialScan;

	private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

	public static async Task<User[]> ResetAdminPassword()
	{
		return await User.ResetAdmin();
	}

	public static async Task<bool> ResetToFactoryDefaults(string backupFilePath, string rootPath, PlatformConfiguration config = null)
	{
		_ = 1;
		try
		{
			if (!File.Exists(backupFilePath))
			{
				Logger.Error("Failure to reset to factory defaults. the backupfile doesn't exist");
				return false;
			}
			string[] value = await ReadAllLinesAsync(backupFilePath);
			BackupConfig backupConfig = JsonConvert.DeserializeObject<BackupConfig>(string.Join(Environment.NewLine, value));
			List<Task> list = new List<Task>();
			string[] systemFiles = backupConfig.SystemFiles;
			foreach (string path in systemFiles)
			{
				list.Add(DeleteFileAsync(Path.Combine(rootPath, path)));
			}
			systemFiles = backupConfig.UserFolders;
			foreach (string path2 in systemFiles)
			{
				list.Add(DeleteAllSubDirectories(Path.Combine(rootPath, path2)));
			}
			await Task.WhenAll(list);
			if (config != null)
			{
				PlatformConfiguration platformConfiguration = PlatformConfiguration.CreateDefaultOptions();
				platformConfiguration.HostIP = config.HostIP;
				platformConfiguration.NetworkAdapterId = config.NetworkAdapterId;
				PlatformConfiguration.Save(platformConfiguration);
			}
			return true;
		}
		catch (Exception ex)
		{
			Logger.Error("Failure to reset to factory defaults \n" + ex);
			return false;
		}
	}

	public static async Task<string> CreateBackup(string backupFilePath, string backupPath, string rootPath)
	{
		try
		{
			if (!File.Exists(backupFilePath))
			{
				throw new IOException("Backup configuration file is missing");
			}
			string[] value = await ReadAllLinesAsync(backupFilePath);
			BackupConfig backupConfig = JsonConvert.DeserializeObject<BackupConfig>(string.Join(Environment.NewLine, value));
			ClearBackup(backupPath);
			string destinationPath = Path.Combine(backupPath, "backupfiles");
			Directory.CreateDirectory(destinationPath);
			List<Task> list = new List<Task>();
			string[] systemFiles = backupConfig.SystemFiles;
			foreach (string path in systemFiles)
			{
				string text = Path.Combine(rootPath, path);
				if (File.Exists(text))
				{
					list.Add(CopyFileAsync(text, Path.Combine(destinationPath, path)));
				}
			}
			systemFiles = backupConfig.UserFolders;
			foreach (string path2 in systemFiles)
			{
				string path3 = Path.Combine(rootPath, path2);
				if (Directory.Exists(path3))
				{
					string[] files = Directory.GetFiles(path3, "*.*", SearchOption.AllDirectories);
					list.AddRange(files.Select((string file) => CopyFileAsync(file, file.Replace(PlatformConfiguration.DataFolderPath, Path.Combine(backupPath, "backupfiles")))));
				}
			}
			await Task.WhenAll(list);
			string path4 = "backup.bak";
			string text2 = Path.Combine(backupPath, path4);
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			ZipFile.CreateFromDirectory(destinationPath, text2);
			ClearBackup(destinationPath);
			return text2;
		}
		catch (Exception arg)
		{
			Logger.Error($"Failure to create backup {arg}");
			return null;
		}
	}

	[CanBeNull]
	public static Task<Exception> Restore(string zipFile, string rootPath, Action<string> reportFunc)
	{
		return Task.Run(async () =>
		{
			_ = 1;
			try
			{
				string tempDir = Path.GetTempPath() + "restore" + Guid.NewGuid().ToString("N").Substring(0, 8);
				if (Directory.Exists(tempDir))
				{
					Directory.Delete(tempDir, recursive: true);
				}
				ZipFile.ExtractToDirectory(zipFile, tempDir);
				string[] value = await ReadAllLinesAsync(Path.Combine(rootPath, "configs", "backupconfig25.1.0.json"));
				BackupConfig backupConfig = JsonConvert.DeserializeObject<BackupConfig>(string.Join(Environment.NewLine, value));
				List<Task> list = new List<Task>();
				string[] systemFiles = backupConfig.SystemFiles;
				foreach (string path in systemFiles)
				{
					string text = Path.Combine(tempDir, path);
					if (File.Exists(text))
					{
						list.Add(CopyFileAsync(text, Path.Combine(rootPath, path)));
					}
				}
				systemFiles = backupConfig.UserFolders;
				foreach (string path2 in systemFiles)
				{
					string path3 = Path.Combine(tempDir, path2);
					if (Directory.Exists(path3))
					{
						string[] files = Directory.GetFiles(path3, "*.*", SearchOption.AllDirectories);
						list.AddRange(files.Select((string file) => CopyFileAsync(file, file.Replace(tempDir, rootPath))));
					}
				}
				await Task.WhenAll(list);
				try
				{
					if (Directory.Exists(tempDir))
					{
						Directory.Delete(tempDir, recursive: true);
					}
				}
				catch (Exception)
				{
				}
			}
			catch (Exception ex2)
			{
				Logger.Error("Restore failed due to \n" + ex2);
				reportFunc?.Invoke("Restore failed");
				return ex2;
			}
			return (Exception)null;
		});
	}

	private static Task<string[]> ReadAllLinesAsync(string path)
	{
		return ReadAllLinesAsync(path, Encoding.UTF8);
	}

	private static async Task<string[]> ReadAllLinesAsync(string path, Encoding encoding)
	{
		List<string> lines = new List<string>();
		using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.Asynchronous | FileOptions.SequentialScan))
		{
			using StreamReader reader = new StreamReader(stream, encoding);
			string item;
			while ((item = await reader.ReadLineAsync()) != null)
			{
				lines.Add(item);
			}
		}
		return lines.ToArray();
	}

	public static async Task CopyFileAsync(string sourcePath, string destinationPath)
	{
		await new FileInfo(sourcePath).CopyFileAsync(destinationPath);
	}

	public static async Task DeleteFileAsync(string sourcePath)
	{
		await new FileInfo(sourcePath).DeleteAsync();
	}

	private static Task DeleteAsync(this FileInfo fi)
	{
		return Task.Factory.StartNew(() =>
		{
			fi.Delete();
		});
	}

	private static Task DeleteAllSubDirectories(string dir)
	{
		return Task.Factory.StartNew(() =>
		{
			if (Directory.Exists(dir))
			{
				string[] directories = Directory.GetDirectories(dir);
				for (int i = 0; i < directories.Length; i++)
				{
					Directory.Delete(directories[i], recursive: true);
				}
				directories = Directory.GetFiles(dir);
				for (int i = 0; i < directories.Length; i++)
				{
					File.Delete(directories[i]);
				}
			}
		});
	}

	private static async Task CopyFileAsync(this FileInfo fi, string destinationPath)
	{
		using Stream source = fi.OpenRead();
		if (!Directory.Exists(Path.GetDirectoryName(destinationPath)))
		{
			Directory.CreateDirectory(Path.GetDirectoryName(destinationPath));
		}
		using Stream destination = File.Create(destinationPath);
		await source.CopyToAsync(destination);
	}

	public static void ClearBackup(string backupPath)
	{
		try
		{
			if (Directory.Exists(backupPath))
			{
				Directory.Delete(backupPath, recursive: true);
			}
		}
		catch (Exception ex)
		{
			Logger.Error("Failed to clear the backup files\n" + ex);
		}
	}
}
