using System.ComponentModel;

namespace Cognex.InSight.Graphic;

[TypeConverter(typeof(CvsCompositeOperationConverter))]
public enum CvsCompositeOperation
{
	Invalid = -1,
	Subtract,
	Add
}
