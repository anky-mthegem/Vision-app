using System;
using System.Collections;
using System.Collections.Generic;
using Cognex.CogNamer.Client.Attributes;

namespace Cognex.CogNamer.Client;

[Serializable]
public class CogNamerRecordList : List<CogNamerRecord>
{
	[Serializable]
	private class RecordListAttributeProvider : INetworkDeviceAttributeProvider, IEnumerable<CogNamerNetworkDeviceAttribute>, IEnumerable
	{
		private class AttributeEnumerator : IEnumerator<CogNamerNetworkDeviceAttribute>, IDisposable, IEnumerator
		{
			private readonly IEnumerator<CogNamerRecord> _recordEnumerator;

			public CogNamerNetworkDeviceAttribute Current => CogNamerNetworkDeviceAttribute.FromRecord(_recordEnumerator.Current);

			object IEnumerator.Current => Current;

			public AttributeEnumerator(CogNamerRecordList records)
			{
				_recordEnumerator = records.GetEnumerator();
			}

			public void Dispose()
			{
				_recordEnumerator.Dispose();
			}

			public bool MoveNext()
			{
				return _recordEnumerator.MoveNext();
			}

			public void Reset()
			{
				_recordEnumerator.Reset();
			}
		}

		private readonly CogNamerRecordList _records;

		public CogNamerNetworkDeviceAttribute this[CogNamerAttributeType type]
		{
			get
			{
				CogNamerRecord cogNamerRecord = _records.FindRecord(type);
				if (cogNamerRecord != null)
				{
					return CogNamerNetworkDeviceAttribute.FromRecord(cogNamerRecord);
				}
				return null;
			}
		}

		public int Count => _records.Count;

		public RecordListAttributeProvider(CogNamerRecordList records)
		{
			_records = records;
		}

		public bool Contains(CogNamerAttributeType type)
		{
			return _records.FindRecord(type) != null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new AttributeEnumerator(_records);
		}

		public IEnumerator<CogNamerNetworkDeviceAttribute> GetEnumerator()
		{
			return new AttributeEnumerator(_records);
		}
	}

	public CogNamerRecordList()
	{
	}

	public CogNamerRecordList(int size)
		: base(size)
	{
	}

	public CogNamerRecord FindRecord(CogNamerAttributeType type)
	{
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				CogNamerRecord current = enumerator.Current;
				if (current.RecordType == type)
				{
					return current;
				}
			}
		}
		return null;
	}

	public CogNamerRecord Add(CogNamerAttributeType type, byte[] data)
	{
		CogNamerRecord cogNamerRecord = new CogNamerRecord(type, data);
		Add(cogNamerRecord);
		return cogNamerRecord;
	}

	public CogNamerRecord Add(CogNamerAttributeType type, string data)
	{
		CogNamerRecord cogNamerRecord = new CogNamerRecord(type, data);
		Add(cogNamerRecord);
		return cogNamerRecord;
	}

	public INetworkDeviceAttributeProvider GetAttributes()
	{
		return new RecordListAttributeProvider(this);
	}

	public CogNamerNetworkDeviceAttribute GetAttribute(CogNamerAttributeType type)
	{
		CogNamerRecord cogNamerRecord = FindRecord(type);
		if (cogNamerRecord != null)
		{
			return CogNamerNetworkDeviceAttribute.FromRecord(cogNamerRecord);
		}
		return null;
	}
}
