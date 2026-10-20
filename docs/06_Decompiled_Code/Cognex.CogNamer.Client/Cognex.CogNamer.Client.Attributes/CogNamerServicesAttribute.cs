using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Cognex.CogNamer.Client.Attributes;

[Serializable]
public class CogNamerServicesAttribute : CogNamerNetworkDeviceAttribute
{
	public struct Service
	{
		private readonly string _name;

		private readonly int _port;

		public string Name => _name;

		public int Port => _port;

		internal Service(string name, int port)
		{
			_name = name;
			_port = port;
		}
	}

	private readonly Service[] _services;

	public Service[] Services => _services;

	public override string StringValue
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder();
			Service[] services = _services;
			for (int i = 0; i < services.Length; i++)
			{
				Service service = services[i];
				stringBuilder.Append(service.Name).Append(':').Append(service.Port)
					.Append(';');
			}
			stringBuilder.Remove(stringBuilder.Length - 1, 1);
			return stringBuilder.ToString();
		}
	}

	internal CogNamerServicesAttribute(byte[] data)
		: base(CogNamerAttributeType.Services, data)
	{
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(data));
		List<Service> list = new List<Service>();
		while (binaryReader.BaseStream.Position < data.Length)
		{
			list.Add(new Service(CogNamerPacket.ReadString(binaryReader), binaryReader.ReadUInt16()));
		}
		_services = list.ToArray();
	}

	public int GetServicePort(string serviceName)
	{
		Service[] services = _services;
		for (int i = 0; i < services.Length; i++)
		{
			Service service = services[i];
			if (serviceName.Equals(service.Name, StringComparison.InvariantCultureIgnoreCase))
			{
				return service.Port;
			}
		}
		return -1;
	}
}
