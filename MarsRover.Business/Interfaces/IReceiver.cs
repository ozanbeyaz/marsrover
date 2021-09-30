using MarsRover.Model;
using MarsRover.Model.Models;

namespace MarsRover.Business.Interfaces
{
    public interface IReceiver
    {
        Coordinates Action(RoverMovementInfo info, IInvoker _invoker);
    }
}
