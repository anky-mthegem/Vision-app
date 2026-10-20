using System;
using System.ComponentModel;
using Cognex.CogNamer.Client.Common;

namespace Cognex.CogNamer.Client;

[Serializable]
[CoverageExclude]
public class CogNamerException : Exception
{
	private readonly CogNamerErrorCode _errorCode;

	public int ErrorNumber => (int)_errorCode;

	public CogNamerErrorCode CogNamerErrorCode => _errorCode;

	public CogNamerException()
	{
		_errorCode = CogNamerErrorCode.Success;
	}

	public CogNamerException(CogNamerErrorCode errorCode)
		: base(GetErrorString(errorCode))
	{
		_errorCode = errorCode;
	}

	protected static string GetErrorString(CogNamerErrorCode errorCode)
	{
		return errorCode switch
		{
			CogNamerErrorCode.Failed => Strings.CogNamerErrorCode_Failed, 
			CogNamerErrorCode.ErrorUnsupportedCommand => Strings.CogNamerErrorCode_ErrorUnsupportedCommand, 
			CogNamerErrorCode.ErrorInvalidUsername => Strings.CogNamerErrorCode_ErrorInvalidUsername, 
			CogNamerErrorCode.ErrorInvalidPassword => Strings.CogNamerErrorCode_ErrorInvalidPassword, 
			CogNamerErrorCode.ErrorInsufficientPrivilege => Strings.CogNamerErrorCode_ErrorInsufficientPrivilege, 
			CogNamerErrorCode.ErrorInvalidNetworkSettings => Strings.CogNamerErrorCode_ErrorInvalidNetworkSettings, 
			CogNamerErrorCode.ErrorMissingRequiredRecord => Strings.CogNamerErrorCode_ErrorMissingRequiredRecord, 
			_ => errorCode.ToString(), 
		};
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public CogNamerException(string message)
		: base(message)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected CogNamerException(string message, CogNamerException inner)
		: base(message, inner)
	{
		_errorCode = inner.CogNamerErrorCode;
	}
}
