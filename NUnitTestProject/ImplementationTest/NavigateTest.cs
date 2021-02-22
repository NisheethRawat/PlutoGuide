using Moq;
using NUnit.Framework;
using PlutoGuide;

namespace NUnitTestProject
{
    public class NavigateTest
    {
        private INavigate _navigate;

        [SetUp]
        public void Setup()
        {
            _navigate = new Navigate();
        }

        [TestCase('F', true)]
        [TestCase('B', true)]
        [TestCase('L', true)]
        [TestCase('R', true)]
        public void MoveRoverRequestTest(char cmnd, bool expectedResponse)
        {
            //Act
            bool response = _navigate.EvaluateNavigation(cmnd);
            //Assert
            Assert.AreEqual(expectedResponse, response);
        }
    }
}