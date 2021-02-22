using Moq;
using NUnit.Framework;
using PlutoGuide;

namespace NUnitTestProject
{
    public class ObstacleDetectionTest
    {
        private IObstacleDetection _obstacleDetection;

        [SetUp]
        public void Setup()
        {
            _obstacleDetection = new ObstacleDetection();
        }

        [TestCase('L', true)]
        [TestCase('R', true)]
        public void DetectObstacleTest(char cmnd, bool expectedOutput)
        {
            //Act
            bool response = _obstacleDetection.DetectObstacle(cmnd);
            //Assert
            Assert.AreEqual(expectedOutput, response);
        }
    }
}