using MarsRover.Business.Interfaces;
using MarsRover.Model;
using MarsRover.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Business.Business
{
    public class Reciever: IReceiver
    {
        public Coordinates Action(RoverMovementInfo info, IInvoker _invoker)
        {
            
            ICommand command;
            var coordinates = new Coordinates();
            foreach (var dir in info.instructures)
            {
                switch (dir)
                {
                    case 'L':
                        command = new TurnLeft();
                        break;

                    case 'R':
                        command = new TurnRight();
                        break;

                    case 'M':
                        command = new Forward();
                        break;

                    default:
                        return null;
                }
                var c = _invoker.Invoke(command, info.coordinates);

                if (c == null)
                    return null;

                
                coordinates.Direction = c.Direction;
                coordinates.XCoordinate = c.XCoordinate;
                coordinates.YCoordinate = c.YCoordinate;
            }
            return coordinates;
        }
    }
}
