using NUnit.Framework;
using Swinesweeper.GameModeFactory;
using Swinesweeper.GameModeFactory.GameModes;
using Swinesweeper.GameModeFactory.Interfaces;
using Swinesweeper.Utilities;
using Swinesweeper.Utilities.Interfaces;

namespace Swinesweeper.IntegrationTests.GameModeFactory
{
    [TestFixture]
    public class GameModeFactory_Should
    {
        private ITypeCreator _typeCreator;

        private Swinesweeper.GameModeFactory.GameModeFactory _sut;

        private const string Beginner = "Beginner";

        private const string Normal = "Normal";

        private const string Advanced = "Advanced";


        [SetUp]
        public void Init()
        {
            _typeCreator = new TypeCreator();
            _sut = new Swinesweeper.GameModeFactory.GameModeFactory(_typeCreator);
        }

        [Test]
        public void CreateInstance_ReturnNullObject_IfTypeDoesNotExist()
        {
            const string invalidGameModeName = "nonExistantMode";

            IGameMode result = _sut.CreateInstance(invalidGameModeName);

            Assert.IsInstanceOf<Null>(result);
        }

        [Test]
        public void CreateInstance_ReturnBeginnerObject_IfBeginnerTypeExists()
        {
            IGameMode result = _sut.CreateInstance(Beginner);

            Assert.IsInstanceOf<Beginner>(result);
        }

        [Test]
        public void CreateInstance_ReturnCorrectFormSize_ForBeginnerType()
        {
            IGameMode result = _sut.CreateInstance(Beginner);

            Assert.AreEqual(202, result.FormSize.X);
            Assert.AreEqual(335, result.FormSize.Y);
        }

        [Test]
        public void CreateInstance_ReturnCorrectGridPanelSize_ForBeginnerType()
        {
            IGameMode result = _sut.CreateInstance(Beginner);

            Assert.AreEqual(160, result.GridPanelSize.X);
            Assert.AreEqual(100, result.GridPanelSize.Y);
        }

        [Test]
        public void CreateInstance_ReturnCorrectDifficultyLevel_ForBeginnerType()
        {
            IGameMode result = _sut.CreateInstance(Beginner);

            Assert.AreEqual(GridSize.Beginner, result.GridSize);
        }

        [Test]
        public void CreateInstance_ReturnCorrectGridSizeFor_ForBeginnerType()
        {
            IGameMode result = _sut.CreateInstance(Beginner);

            Assert.AreEqual(DifficultyLevel.Beginner, result.DifficultyLevel);
        }

        [Test]
        public void CreateInstance_ReturnNormalObject_IfNormalTypeExists()
        {
            IGameMode result = _sut.CreateInstance(Normal);

            Assert.IsInstanceOf<Normal>(result);
        }

        [Test]
        public void CreateInstance_ReturnCorrectFormSize_ForNormalType()
        {
            IGameMode result = _sut.CreateInstance(Normal);

            Assert.AreEqual(327, result.FormSize.X);
            Assert.AreEqual(469, result.FormSize.Y);
        }

        [Test]
        public void CreateInstance_ReturnCorrectGridPanelSize_ForNormalType()
        {
            IGameMode result = _sut.CreateInstance(Normal);

            Assert.AreEqual(275, result.GridPanelSize.X);
            Assert.AreEqual(100, result.GridPanelSize.Y);
        }

        [Test]
        public void CreateInstance_ReturnCorrectDifficultyLevel_ForNormalType()
        {
            IGameMode result = _sut.CreateInstance(Normal);

            Assert.AreEqual(DifficultyLevel.Normal, result.DifficultyLevel);
        }

        [Test]
        public void CreateInstance_ReturnCorrectGridSize_ForNormalType()
        {
            IGameMode result = _sut.CreateInstance(Normal);

            Assert.AreEqual(GridSize.Normal, result.GridSize);
        }

        [Test]
        public void CreateInstance_ReturnAdvancedObject_IfAdvancedTypeExists()
        {
            IGameMode result = _sut.CreateInstance(Advanced);

            Assert.IsInstanceOf<Advanced>(result);
        }

        [Test]
        public void CreateInstance_ReturnCorrectFormSize_ForAdvancedType()
        {
            IGameMode result = _sut.CreateInstance(Advanced);

            Assert.AreEqual(399, result.FormSize.X);
            Assert.AreEqual(530, result.FormSize.Y);
        }

        [Test]
        public void CreateInstance_ReturnCorrectGridPanelSize_ForAdvancedType()
        {
            IGameMode result = _sut.CreateInstance(Advanced);

            Assert.AreEqual(350, result.GridPanelSize.X);
            Assert.AreEqual(329, result.GridPanelSize.Y);
        }

        [Test]
        public void CreateInstance_ReturnCorrectDifficultyLevel_ForAdvancedType()
        {
            IGameMode result = _sut.CreateInstance(Advanced);

            Assert.AreEqual(DifficultyLevel.Advanced, result.DifficultyLevel);
        }

        [Test]
        public void CreateInstance_ReturnCorrectGridSize_ForAdvancedType()
        {
            IGameMode result = _sut.CreateInstance(Advanced);

            Assert.AreEqual(GridSize.Advanced, result.GridSize);
        }

        [TearDown]
        public void TearDown()
        {
            _typeCreator = null;
            _sut = null;
        }
    }
}