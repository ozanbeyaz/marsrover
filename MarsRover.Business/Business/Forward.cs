using MarsRover.Business.Interfaces;
using MarsRover.Model;
using MarsRover.Model.Enums;
using System;

namespace MarsRover.Business.Business
{
    public class Forward : ICommand
    {
        public Coordinates Execute(Coordinates coordinates)
        {
            switch (coordinates.Direction)
            {
                case Directions.N:
                    if (coordinates.YCoordinate < coordinates.MaxYCoordinate)
                        coordinates.YCoordinate++;
                    break;

                case Directions.E:
                    if (coordinates.XCoordinate < coordinates.MaxXCoordinate)
                       coordinates.XCoordinate++;
                    break;

                case Directions.S:
                    if (coordinates.YCoordinate != 0)
                        coordinates.YCoordinate--;
                    break;

                case Directions.W:
                    if (coordinates.XCoordinate != 0)
                        coordinates.XCoordinate--;
                    break;
            }
            return coordinates;
        }
    }
}
