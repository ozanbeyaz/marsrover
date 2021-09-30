using MarsRover.Model;
using MarsRover.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Test.Models
{
    /// <summary>
    /// class for mocking data
    /// </summary>
    public static class RoverTestData
    {
        
        public static RoverMovementInfo RoverMovementInfo()
        {

            return new RoverMovementInfo(new Coordinates(1,2,Model.Enums.Directions.N,5,5), "LMLMLMLMM");
           
        }

    }
}
