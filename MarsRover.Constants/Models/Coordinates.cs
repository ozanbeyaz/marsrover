using MarsRover.Model.Enums;

namespace MarsRover.Model
{
    public class Coordinates
    {
        public Coordinates()
        {

        }
        public Coordinates(int x, int y, Directions directons, int maxX, int maxY)
        {
            XCoordinate = x;
            YCoordinate = y;
            Direction = directons;
            MaxXCoordinate = maxX;
            MaxYCoordinate = maxY;
        }

        public int XCoordinate { get; set; }

        public int YCoordinate { get; set; }

        public Directions Direction { get; set; }

        public readonly int MaxXCoordinate;

        public readonly int MaxYCoordinate;


    }
}
