using Moq;
using NUnit.Framework;
using Swinesweeper.GameModeFactory.GameModes;
using Swinesweeper.GameModeFactory.Interfaces;
using Swinesweeper.Utilities.Interfaces;
using System;

namespace Swinesweeper.UnitTests.GameModeFactory
{
    [TestFixture]
    public class GameModeFactory_Should
    {
        private Mock<ITypeCreator> _faketypeCreator;

        private Swinesweeper.GameModeFactory.GameModeFactory _sut;

        [SetUp]
        public void Init()
        {
            _faketypeCreator = new Mock<ITypeCreator>();
            _sut = new Swinesweeper.GameModeFactory.GameModeFactory(_faketypeCreator.Object);
        }

        [Test]
        [ExpectedException(typeof (ArgumentException))]
        public void CreateInstance_ThrowAnArgumentException_IfGameModeNameParamIsNull()
        {
            _sut.CreateInstance(null);
        }

        [Test]
        [ExpectedException(typeof (ArgumentException))]
        public void CreateInstance_ThrowAnArgumentException_IfGameModeNameParamIsAnEmptyString()
        {
            _sut.CreateInstance(string.Empty);
        }

        [Test]
        public void CreateInstance_ReturnANullSettingObject_IfTypeReturnedIsNull()
        {
            IGameMode result = _sut.CreateInstance("NonExistantGameMode");

            Assert.IsInstanceOf<Null>(result);
        }

        [Test]
        public void CreateInstance_CallMethodGetTypeInstance_ExactlyOnce()
        {
            _sut.CreateInstance("Beginner");

            _faketypeCreator.Verify(x => x.GetTypeInstance(It.IsAny<Type>()), Times.Once());
        }

        [TearDown]
        public void TearDown()
        {
            _faketypeCreator = null;
            _sut = null;
        }
    }
}