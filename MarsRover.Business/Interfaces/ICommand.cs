using MarsRover.Model;

namespace MarsRover.Business.Interfaces
{
    public interface ICommand
    {
        public Coordinates Execute(Coordinates coordinates);
    }
}
