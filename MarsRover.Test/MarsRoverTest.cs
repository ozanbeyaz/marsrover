using NUnit.Framework;
using FakeItEasy;
using MarsRover.Business.Interfaces;
using MarsRover.Business.Business;
using MarsRover.Test.Models;
using MarsRover.Model;
using MarsRover.Model.Models;

namespace MarsRover.Test
{
    public class MarsRoverTest
    {
        private readonly IInvoker _invoker;
      
        private readonly IReceiver _receiver;

        public MarsRoverTest()
        {
            _invoker = A.Fake<IInvoker>();
            _receiver = new Reciever();
        }
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            bool isCoordinateNull = false;
            RoverMovementInfo roverMovementInfo =  RoverTestData.RoverMovementInfo();
            if (!isCoordinateNull)
                A.CallTo(() => _invoker.Invoke(A<ICommand>._, A<Coordinates>._)).ReturnsLazily(() => roverMovementInfo.coordinates);
            else
                A.CallTo(() => _invoker.Invoke(A<ICommand>._, A<Coordinates>._)).ReturnsLazily(() => null);
            var result = _receiver.Action(roverMovementInfo, _invoker);

            //Assert
           
                Assert.NotNull(result);
                Assert.AreEqual(roverMovementInfo.coordinates.XCoordinate, result.XCoordinate);
                Assert.AreEqual(roverMovementInfo.coordinates.YCoordinate, result.YCoordinate);
                Assert.AreEqual(roverMovementInfo.coordinates.Direction, result.Direction);
            
           
            Assert.Pass();
        }
    }
}