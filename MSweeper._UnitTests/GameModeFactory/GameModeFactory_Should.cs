using MSweeper.GameModeFactory.GameModes;
using MSweeper.GameModeFactory.Interfaces;
using MSweeper.GridTools.Settings;
using NUnit.Framework;
using System;

namespace MSweeper._UnitTests.GameModeFactory
{
    [TestFixture]
    public class GameModeFactory_Should
    {
        private MSweeper.GameModeFactory.GameModeFactory _sut;

        private const string Beginner = "Beginner";

        private const string Normal = "Normal";

        private const string Advanced = "Advanced";


        [SetUp]
        public void Init()
        {
            _sut = new MSweeper.GameModeFactory.GameModeFactory();
        }

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
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
            IGameMode result = _sut.CreateInstance(Beginner);

            Assert.IsInstanceOf<Beginner>(result);
        }

        [Test]
        public void CreateInstance_ReturnCorrectFormSizeForBeginnerType()
        {
            IGameMode result = _sut.CreateInstance(Beginner);

            Assert.AreEqual(183, result.FormSize.X);
            Assert.AreEqual(225, result.FormSize.Y);
        }

        [Test]
        public void CreateInstance_ReturnCorrectGridPanelSizeForBeginnerType()
        {
            IGameMode result = _sut.CreateInstance(Beginner);

            Assert.AreEqual(140, result.GridPanelSize.X);
            Assert.AreEqual(100, result.GridPanelSize.Y);
        }

        [Test]
        public void CreateInstance_ReturnCorrectDifficultyLevelForBeginnerType()
        {
            IGameMode result = _sut.CreateInstance(Beginner);

            Assert.AreEqual(GridSize.Beginner, result.GridSize);
        }

        [Test]
        public void CreateInstance_ReturnCorrectGridSizeForBeginnerType()
        {
            IGameMode result = _sut.CreateInstance(Beginner);

            Assert.AreEqual(DifficultyLevel.Beginner, result.DifficultyLevel);
        }

        [Test]
        public void CreateInstance_ReturnNormalType_IfNormalTypeExists()
        {
            IGameMode result = _sut.CreateInstance(Normal);

            Assert.IsInstanceOf<Normal>(result);
        }

        [Test]
        public void CreateInstance_ReturnCorrectFormSizeForNormalType()
        {
            IGameMode result = _sut.CreateInstance(Normal);

            Assert.AreEqual(295, result.FormSize.X);
            Assert.AreEqual(340, result.FormSize.Y);
        }

        [Test]
        public void CreateInstance_ReturnCorrectGridPanelSizeForNormalType()
        {
            IGameMode result = _sut.CreateInstance(Normal);

            Assert.AreEqual(240, result.GridPanelSize.X);
            Assert.AreEqual(100, result.GridPanelSize.Y);
        }

        [Test]
        public void CreateInstance_ReturnCorrectDifficultyLevelForNormalType()
        {
            IGameMode result = _sut.CreateInstance(Normal);

            Assert.AreEqual(DifficultyLevel.Normal, result.DifficultyLevel);
        }

        [Test]
        public void CreateInstance_ReturnCorrectGridSizeForNormalType()
        {
            IGameMode result = _sut.CreateInstance(Normal);

            Assert.AreEqual(GridSize.Normal, result.GridSize);
        }

        [Test]
        public void CreateInstance_ReturnAdvancedType_IfAdvancedTypeExists()
        {
            IGameMode result = _sut.CreateInstance(Advanced);

            Assert.IsInstanceOf<Advanced>(result);
        }

        [Test]
        public void CreateInstance_ReturnCorrectFormSizeForAdvancedType()
        {
            IGameMode result = _sut.CreateInstance(Advanced);

            Assert.AreEqual(359, result.FormSize.X);
            Assert.AreEqual(436, result.FormSize.Y);
        }

        [Test]
        public void CreateInstance_ReturnCorrectGridPanelSizeForAdvancedType()
        {
            IGameMode result = _sut.CreateInstance(Advanced);

            Assert.AreEqual(314, result.GridPanelSize.X);
            Assert.AreEqual(329, result.GridPanelSize.Y);
        }

        [Test]
        public void CreateInstance_ReturnCorrectDifficultyLevelForAdvancedType()
        {
            IGameMode result = _sut.CreateInstance(Advanced);

            Assert.AreEqual(DifficultyLevel.Advanced, result.DifficultyLevel);
        }

        [Test]
        public void CreateInstance_ReturnCorrectGridSizeForAdvancedType()
        {
            IGameMode result = _sut.CreateInstance(Advanced);

            Assert.AreEqual(GridSize.Advanced, result.GridSize);
        }

        [TearDown]
        public void TearDown()
        {
            _sut = null;
        }
    }
}