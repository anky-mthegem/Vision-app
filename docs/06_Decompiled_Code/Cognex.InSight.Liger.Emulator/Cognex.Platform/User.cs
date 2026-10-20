using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using NLog;
using Newtonsoft.Json;

namespace Cognex.Platform;

public class User
{
	[JsonProperty(NullValueHandling = NullValueHandling.Include)]
	public string Username;

	[JsonProperty(NullValueHandling = NullValueHandling.Include)]
	public string Password;

	[JsonProperty(NullValueHandling = NullValueHandling.Include)]
	public string Comment;

	[JsonProperty(NullValueHandling = NullValueHandling.Include)]
	public int AccessLevel;

	private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

	private static string FilePath => Path.Combine(PlatformConfiguration.DataFolderPath, "configs", "users.json");

	private static User DefaultUser => new User
	{
		Username = "admin",
		Password = "",
		AccessLevel = 0,
		Comment = ""
	};

	public static User[] Load()
	{
		if (TryLoad(out var users))
		{
			return users;
		}
		return new User[1] { DefaultUser };
	}

	private static bool TryLoad(out User[] users)
	{
		users = null;
		if (!File.Exists(FilePath))
		{
			Logger.Warn("Failed to load the user settings.\nFile does not exist.\nInitializing to defaults.");
			return false;
		}
		try
		{
			users = JsonConvert.DeserializeObject<User[]>(File.ReadAllText(FilePath));
			return true;
		}
		catch (Exception)
		{
		}
		try
		{
			string value = UserEncryptionHelper.XORDecryptFromBase64(File.ReadAllText(FilePath));
			users = JsonConvert.DeserializeObject<User[]>(value);
			return true;
		}
		catch (Exception ex2)
		{
			Logger.Error("Exception while loading the user settings.\nInitializing to defaults.\n " + ex2);
		}
		users = null;
		return false;
	}

	public static User GetAdminUser(User[] users)
	{
		return users.FirstOrDefault((User u) => u.Username == "admin") ?? DefaultUser;
	}

	public static async Task<User[]> ResetAdmin()
	{
		User[] users = null;
		try
		{
			users = Load();
			User user = users.FirstOrDefault((User u) => u.Username == "admin");
			if (user != null)
			{
				user.Password = "";
			}
			else
			{
				List<User> list = users.ToList();
				list.Add(DefaultUser);
				users = list.ToArray();
			}
			string value = UserEncryptionHelper.XOREncryptAndBase64(JsonConvert.SerializeObject(users, new JsonSerializerSettings
			{
				TypeNameHandling = TypeNameHandling.Objects
			}).Replace("Cognex.Platform.User, Cognex.InSight.ViDi.PC.Manager", "User"));
			using FileStream writer = File.Create(FilePath);
			using StreamWriter streamWriter = new StreamWriter(writer);
			await streamWriter.WriteAsync(value);
		}
		catch (Exception ex)
		{
			Logger.Error("Failed to save the settings\n" + ex);
		}
		return users;
	}
}
