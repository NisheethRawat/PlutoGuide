using NUnit.Framework;
using PlutoGuide;
using System;

namespace NUnitTestProject
{
    public class ValidateCommandTest
    {
        private IValidateCommand _validateCommand;

        [SetUp]
        public void Setup()
        {
            _validateCommand = new ValidateCommand();
        }

        [TestCase("FFRFF")]
        [TestCase("L")]
        public void ValidateInputCommandTest(string cmnd)
        {
            //Act
            Assert.DoesNotThrow( ()=> _validateCommand.ValidateInputCommand(cmnd));
        }

        [TestCase("AFRFF")]
        [TestCase("123")]
        [TestCase("G")]
        public void ValidateInputCommandExceptionTest(string cmnd)
        {
            //Act
            var ex = Assert.Throws<Exception>(() => _validateCommand.ValidateInputCommand(cmnd));
            //Assert
            Assert.AreEqual("Invalid Command Sequence", ex.Message);
        }
    }
}