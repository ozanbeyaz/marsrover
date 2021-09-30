using MarsRover.Business.Interfaces;
using MarsRover.Model;
using MarsRover.Model.Enums;

namespace MarsRover.Business.Business
{
    public class TurnRight : ICommand
    {
        public Coordinates Execute(Coordinates coordinates)
        {
            switch (coordinates.Direction)
            {
                case Directions.N:
                    coordinates.Direction = Directions.E;
                    break;

                case Directions.E:
                    coordinates.Direction = Directions.S;
                    break;

                case Directions.S:
                    coordinates.Direction = Directions.W;
                    break;

                case Directions.W:
                    coordinates.Direction = Directions.N;
                    break;
            }
            return coordinates;
        }
    }
}
