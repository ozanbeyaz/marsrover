using MarsRover.Business.Business;
using MarsRover.Business.Interfaces;
using MarsRover.Model;
using MarsRover.Model.Enums;
using MarsRover.Model.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plateau surface size : ");
            var maxCoordinates = Console.ReadLine().Split(' ');

            List<RoverMovementInfo> roverMovementInfos = new List<RoverMovementInfo>();

            while (true)
            {
                Console.WriteLine("Starting coordinates :");
                string[] startingCoordinates = Console.ReadLine().ToUpper().Split(' ');

                Console.WriteLine("Instructures :");
                string instructure = Console.ReadLine().ToUpper();

                roverMovementInfos.Add(new RoverMovementInfo(new Coordinates
            (
                 Convert.ToInt32(startingCoordinates[0]),
                 Convert.ToInt32(startingCoordinates[1]),
                 (Directions)Enum.Parse(typeof(Directions), startingCoordinates[2]),
                 Convert.ToInt32(maxCoordinates[0]),
                 Convert.ToInt32(maxCoordinates[1])

            ), instructure));

                Console.WriteLine("Do you add new rover ? (Y/N)");
                if (Console.ReadLine().ToUpper() != "Y") break;
            }

            ServiceProvider _sp = Startup.Start();

            IReceiver _receiverService = _sp.GetService<IReceiver>();

            foreach (var item in roverMovementInfos)
            {
                var coordinates = _receiverService.Action(item, _sp.GetService<IInvoker>());

                Console.WriteLine("{0} {1} {2}", coordinates.XCoordinate.ToString(), coordinates.YCoordinate.ToString(), coordinates.Direction.ToString());

                Console.ReadLine();
            }

        }
    }
}
