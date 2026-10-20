using System.Collections.Generic;
using System.Threading.Tasks;
using Cognex.InSight.Remoting.Serialization;

namespace Cognex.InSight;

public interface ICogSocketAcqProperties
{
	Task<IEnumerable<UntypedDescribedProperty>> GetAllProperties();

	Task<IEnumerable<CvsCogPropertyDescriptorGroup>> GetEditableProperties();

	Task SetPropertyValue<T>(UntypedDescribedProperty property, T value);

	Task SetPropertyValue<T>(CvsCogPropertyDescriptor property, T value);

	Task<T> GetPropertyValue<T>(UntypedDescribedProperty property);

	Task<T> GetPropertyValue<T>(CvsCogPropertyDescriptor property);

	Task ResetAcqSettingToDefault();
}
