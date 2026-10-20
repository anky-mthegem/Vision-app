using System;

namespace Cognex.Explorer.Common;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class EntryPointAttribute : Attribute
{
	public Type EntryPoint { get; private set; }

	public string EntryPointName { get; private set; }

	public EntryPointAttribute(Type type, string entryPointName = null)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		EntryPoint = type;
		EntryPointName = entryPointName;
	}
}
