using Moq;
using NUnit.Framework;
using PlutoGuide;

namespace NUnitTestProject
{
    public class PlutoRoverControllerTest
    {
        private PlutoRoverController _plutoRoverController;
        private Mock<IObstacleDetection> _obstacleDetection;
        private Mock<IValidateCommand> _validateCommand;

        [SetUp]
        public void Setup()
        {
            INavigate _navigate = new Navigate();
            _obstacleDetection = new Mock<IObstacleDetection>();
            _validateCommand = new Mock<IValidateCommand>();
            _plutoRoverController = new PlutoRoverController(_navigate, _obstacleDetection.Object, _validateCommand.Object);
        }

        [TestCase("FFRFF", "Rover Location : 2/2/E")]
        //[TestCase("FF", "Rover Location : 4/2/E")]
        //[TestCase("FR", "Rover Location : 5/2/S")]
        //[TestCase("FBRFB", "Rover Location : 5/2/W")]
        //[TestCase("BBRBB", "Rover Location : 7/0/N")]
        public void MoveRoverRequestTest(string cmnd, string expectedResponse)
        {
            //Arrange            
            _validateCommand.Setup(a => a.ValidateInputCommand(It.IsAny<string>()));
            _obstacleDetection.Setup(a => a.DetectObstacle(It.IsAny<char>())).Returns(true);

            //Act
            string response = _plutoRoverController.MoveRoverRequest(cmnd);
            //Assert
            Assert.AreEqual(expectedResponse, response);
        }
    }
}