using MarsRover.Business.Interfaces;
using MarsRover.Model;

namespace MarsRover.Business.Business
{
    public class Invoker : IInvoker
    {
        public Coordinates Invoke(ICommand command, Coordinates coordinates)
        {
            return command.Execute(coordinates);
        }
    }
}
