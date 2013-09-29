using MineSweeper.GameModeFactory.GameModes;
using MineSweeper.Settings.Interfaces;
using NUnit.Framework;
using System;

namespace MineSweeper.GameModeFactory.UnitTests
{
    [TestFixture]
    public class GameModeFactoryShould
    {
        private GameModeFactory _sut;

        [SetUp]
        public void Init()
        {
            _sut = new GameModeFactory();
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreateInstance_ThrowAnArgumentNullException_IfGameModeNameIsNull()
        {
            const string nullGameMode = null;

            _sut.CreateInstance(nullGameMode);
        }

        [Test]
        public void CreateInstance_ReturnNullSettingsType_IfTypeDoesNotExist()
        {
            const string invalidGameModeName = "nonExistantMode";

            IGameMode result = _sut.CreateInstance(invalidGameModeName);

            Assert.IsInstanceOf<NullSettings>(result);
        }

        [Test]
        public void CreateInstance_ReturnBeginnerType_IfBeginnerTypeExists()
        {
            const string beginnerGameModeName = "Beginner";

            IGameMode result = _sut.CreateInstance(beginnerGameModeName);

            Assert.IsInstanceOf<Beginner>(result);
        }

        [Test]
        public void CreateInstance_ReturnNormalType_IfNormalTypeExists()
        {
            const string normalGameModeName = "Normal";

            IGameMode result = _sut.CreateInstance(normalGameModeName);

            Assert.IsInstanceOf<Normal>(result);
        }

        [Test]
        public void CreateInstance_ReturnAdvancedType_IfAdvancedTypeExists_()
        {
            const string advancedGameModeName = "Advanced";

            IGameMode result = _sut.CreateInstance(advancedGameModeName);

            Assert.IsInstanceOf<Advanced>(result);
        }

        [TearDown]
        public void TearDown()
        {
            _sut = null;
        }
    }
}
