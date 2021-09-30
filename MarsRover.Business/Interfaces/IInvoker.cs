using MarsRover.Model;

namespace MarsRover.Business.Interfaces
{
    public interface IInvoker
    {
        Coordinates Invoke(ICommand command, Coordinates coordinates);
    }
}
