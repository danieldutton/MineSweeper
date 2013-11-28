using MineSweeper.GameModeFactory.GameModes;
using MineSweeper.Settings;
using MineSweeper.Settings.Interfaces;
using NUnit.Framework;
using System;

namespace MineSweeper.GameModeFactory.UnitTests
{
    [TestFixture]
    public class GameModeFactory_Should
    {
        private GameModeFactory _sut;

        private const string Beginner = "Beginner";

        private const string Normal = "Normal";

        private const string Advanced = "Advanced";


        [SetUp]
        public void Init()
        {
            _sut = new GameModeFactory();
        }

        #region Null

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

        #endregion

        #region Beginner

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

        #endregion

        #region Normal

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

        #endregion

        #region Advanced

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

        #endregion
       
        [TearDown]
        public void TearDown()
        {
            _sut = null;
        }
    }
}
