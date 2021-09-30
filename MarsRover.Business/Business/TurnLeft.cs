using MarsRover.Business.Interfaces;
using MarsRover.Model;
using MarsRover.Model.Enums;
using System;

namespace MarsRover.Business.Business
{
    public class TurnLeft : ICommand
    {
        public Coordinates Execute(Coordinates coordinates)
        {
            switch (coordinates.Direction)
            {
                case Directions.N:
                    coordinates.Direction = Directions.W;
                    break;

                case Directions.E:
                    coordinates.Direction = Directions.N;
                    break;

                case Directions.S:
                    coordinates.Direction = Directions.E;
                    break;

                case Directions.W:
                    coordinates.Direction = Directions.S;
                    break;
            }
            return coordinates;
        }
    }
}
