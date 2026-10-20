using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Cognex.CogNamer.Client.Common;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Strings
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (resourceMan == null)
			{
				resourceMan = new ResourceManager("CogNamer.Client.Properties.Strings", typeof(Strings).Assembly);
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static string AttemptingToContact => ResourceManager.GetString("AttemptingToContact", resourceCulture);

	internal static string ChangingNetworkSettings => ResourceManager.GetString("ChangingNetworkSettings", resourceCulture);

	internal static string CogNamerErrorCode_ErrorInsufficientPrivilege => ResourceManager.GetString("CogNamerErrorCode_ErrorInsufficientPrivilege", resourceCulture);

	internal static string CogNamerErrorCode_ErrorInvalidNetworkSettings => ResourceManager.GetString("CogNamerErrorCode_ErrorInvalidNetworkSettings", resourceCulture);

	internal static string CogNamerErrorCode_ErrorInvalidPassword => ResourceManager.GetString("CogNamerErrorCode_ErrorInvalidPassword", resourceCulture);

	internal static string CogNamerErrorCode_ErrorInvalidUsername => ResourceManager.GetString("CogNamerErrorCode_ErrorInvalidUsername", resourceCulture);

	internal static string CogNamerErrorCode_ErrorMissingRequiredRecord => ResourceManager.GetString("CogNamerErrorCode_ErrorMissingRequiredRecord", resourceCulture);

	internal static string CogNamerErrorCode_ErrorUnsupportedCommand => ResourceManager.GetString("CogNamerErrorCode_ErrorUnsupportedCommand", resourceCulture);

	internal static string CogNamerErrorCode_Failed => ResourceManager.GetString("CogNamerErrorCode_Failed", resourceCulture);

	internal static string CommunicationException => ResourceManager.GetString("CommunicationException", resourceCulture);

	internal static string CompletedSuccessfully => ResourceManager.GetString("CompletedSuccessfully", resourceCulture);

	internal static string ConfigurationException_1 => ResourceManager.GetString("ConfigurationException_1", resourceCulture);

	internal static string Connected => ResourceManager.GetString("Connected", resourceCulture);

	internal static string ConnectingTo => ResourceManager.GetString("ConnectingTo", resourceCulture);

	internal static string CouldNotResolveHost => ResourceManager.GetString("CouldNotResolveHost", resourceCulture);

	internal static string FileAlreadyExists => ResourceManager.GetString("FileAlreadyExists", resourceCulture);

	internal static string FileNotFoundException => ResourceManager.GetString("FileNotFoundException", resourceCulture);

	internal static string FileOperationFailedException => ResourceManager.GetString("FileOperationFailedException", resourceCulture);

	internal static string FileReadFailed => ResourceManager.GetString("FileReadFailed", resourceCulture);

	internal static string FileStoreFailed => ResourceManager.GetString("FileStoreFailed", resourceCulture);

	internal static string FileTransferError => ResourceManager.GetString("FileTransferError", resourceCulture);

	internal static string FirmwareNotSupported => ResourceManager.GetString("FirmwareNotSupported", resourceCulture);

	internal static string FtpConnect => ResourceManager.GetString("FtpConnect", resourceCulture);

	internal static string InsufficientPermissions => ResourceManager.GetString("InsufficientPermissions", resourceCulture);

	internal static string InsufficientReadPermissions => ResourceManager.GetString("InsufficientReadPermissions", resourceCulture);

	internal static string InsufficientWritePermissions => ResourceManager.GetString("InsufficientWritePermissions", resourceCulture);

	internal static string InvalidAddressException_1 => ResourceManager.GetString("InvalidAddressException_1", resourceCulture);

	internal static string InvalidHostName => ResourceManager.GetString("InvalidHostName", resourceCulture);

	internal static string InvalidLogonException => ResourceManager.GetString("InvalidLogonException", resourceCulture);

	internal static string InvalidPassword => ResourceManager.GetString("InvalidPassword", resourceCulture);

	internal static string InvalidResponse => ResourceManager.GetString("InvalidResponse", resourceCulture);

	internal static string LimitExceededException => ResourceManager.GetString("LimitExceededException", resourceCulture);

	internal static string Move => ResourceManager.GetString("Move", resourceCulture);

	internal static string NotConnected => ResourceManager.GetString("NotConnected", resourceCulture);

	internal static string NotConnectedException => ResourceManager.GetString("NotConnectedException", resourceCulture);

	internal static string NotRecognizedException => ResourceManager.GetString("NotRecognizedException", resourceCulture);

	internal static string ResponseNotReceived => ResourceManager.GetString("ResponseNotReceived", resourceCulture);

	internal static string SerializationTypeException => ResourceManager.GetString("SerializationTypeException", resourceCulture);

	internal static string SymbolicTagNotFoundException => ResourceManager.GetString("SymbolicTagNotFoundException", resourceCulture);

	internal static string TheOperationWasCanceled => ResourceManager.GetString("TheOperationWasCanceled", resourceCulture);

	internal static string TimeoutException => ResourceManager.GetString("TimeoutException", resourceCulture);

	internal static string UnknownSensorType => ResourceManager.GetString("UnknownSensorType", resourceCulture);

	internal static string USBDriveNotFoundException => ResourceManager.GetString("USBDriveNotFoundException", resourceCulture);

	internal Strings()
	{
	}
}
