using System.Threading.Tasks;
using Cognex.InSight.Internal;

namespace Cognex.InSight;

public interface ICogSocketAcqFactory
{
	Task<ICogSocketAcq> Create(CvsCogSocket cogSocket);
}
