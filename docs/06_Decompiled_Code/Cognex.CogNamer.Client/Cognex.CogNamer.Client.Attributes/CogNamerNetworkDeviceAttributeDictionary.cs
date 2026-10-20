using System;
using System.Collections;
using System.Collections.Generic;

namespace Cognex.CogNamer.Client.Attributes;

[Serializable]
public class CogNamerNetworkDeviceAttributeDictionary : INetworkDeviceAttributeProvider, IEnumerable<CogNamerNetworkDeviceAttribute>, IEnumerable
{
	private readonly Dictionary<CogNamerAttributeType, CogNamerNetworkDeviceAttribute> _dictionary;

	public CogNamerNetworkDeviceAttribute this[CogNamerAttributeType name]
	{
		get
		{
			_dictionary.TryGetValue(name, out var value);
			return value;
		}
	}

	public int Count => _dictionary.Count;

	public CogNamerNetworkDeviceAttributeDictionary(CogNamerNetworkDeviceAttributeDictionary dictionary)
	{
		_dictionary = new Dictionary<CogNamerAttributeType, CogNamerNetworkDeviceAttribute>(dictionary._dictionary);
	}

	public CogNamerNetworkDeviceAttributeDictionary(INetworkDeviceAttributeProvider dictionary)
	{
		_dictionary = new Dictionary<CogNamerAttributeType, CogNamerNetworkDeviceAttribute>();
		foreach (CogNamerNetworkDeviceAttribute item in dictionary)
		{
			Add(item);
		}
	}

	public CogNamerNetworkDeviceAttributeDictionary()
	{
		_dictionary = new Dictionary<CogNamerAttributeType, CogNamerNetworkDeviceAttribute>();
	}

	public void Add(CogNamerNetworkDeviceAttribute attr)
	{
		_dictionary.Add(attr.AttributeType, attr);
	}

	public bool Contains(CogNamerAttributeType name)
	{
		return _dictionary.ContainsKey(name);
	}

	public bool Merge(INetworkDeviceAttributeProvider attributes)
	{
		bool result = false;
		foreach (CogNamerNetworkDeviceAttribute attribute in attributes)
		{
			bool flag = Contains(attribute.AttributeType);
			if (flag && !this[attribute.AttributeType].Equals(attribute))
			{
				_dictionary.Remove(attribute.AttributeType);
				flag = false;
			}
			if (!flag)
			{
				result = true;
				Add(attribute);
			}
		}
		return result;
	}

	public IEnumerator<CogNamerNetworkDeviceAttribute> GetEnumerator()
	{
		return _dictionary.Values.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return _dictionary.Values.GetEnumerator();
	}
}
