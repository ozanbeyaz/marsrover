using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Model.Models
{
    public class RoverMovementInfo
    {
        public RoverMovementInfo(Coordinates _cordinates, string _instructures)
        {
            coordinates = _cordinates;
            instructures = _instructures;

        }
        public Coordinates coordinates;

        public string instructures;

    }
}
