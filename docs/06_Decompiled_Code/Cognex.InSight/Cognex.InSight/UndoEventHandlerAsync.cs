using System.Threading.Tasks;
using Cognex.InSight.Undo;

namespace Cognex.InSight;

public delegate Task UndoEventHandlerAsync(object sender, UndoEventArgs e);
