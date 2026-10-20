using System.Collections;
using System.Collections.Generic;

namespace Cognex.InSight;

public interface INamedOperandCollection : IEnumerable<INamedOperand>, IEnumerable
{
	INamedOperand FindByName(string name);

	INamedOperand FindMatch(string expr);
}
