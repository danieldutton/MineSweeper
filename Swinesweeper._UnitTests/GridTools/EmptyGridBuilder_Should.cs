using NUnit.Framework;
using Swinesweeper.GameModeFactory.Settings;
using Swinesweeper.GridTools;
using Swinesweeper.GridTools.Interfaces;
using Swinesweeper.Model;

namespace Swinesweeper._UnitTests.GridTools
{
    [TestFixture]
    public class EmptyGridBuilder_Should
    {
        private IGridBuilder _sut;

        [SetUp]
        public void Init()
        {
            _sut = new EmptyGridBuilder();
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridWithNineRowsForGameModeBeginner()
        {
            Tile[,] grid = _sut.GetSquaredGrid(GridSize.Beginner, DifficultyLevel.Beginner);
            
            const int expected = 9;
            int actual = grid.GetLength(0);
            
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridWithSixteenRowsForGameModeNormal()
        {
            Tile[,] grid = _sut.GetSquaredGrid(GridSize.Normal, DifficultyLevel.Normal);

            const int expected = 16;
            int actual = grid.GetLength(0);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridWithTwentyRowsForGameModeAdvanced()
        {
            Tile[,] grid = _sut.GetSquaredGrid(GridSize.Advanced, DifficultyLevel.Advanced);

            const int expected = 20;
            int actual = grid.GetLength(0);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridWithNineColumnsForGameModeBeginner()
        {
            Tile[,] grid = _sut.GetSquaredGrid(GridSize.Beginner, DifficultyLevel.Beginner);

            const int expected = 9;
            int actual = grid.GetLength(1);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridWithSixteenColumnsForGameModeNormal()
        {
            Tile[,] grid = _sut.GetSquaredGrid(GridSize.Normal, DifficultyLevel.Normal);

            const int expected = 16;
            int actual = grid.GetLength(1);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridWithTwentyColumnsForGameModeAdvanced()
        {
            Tile[,] grid = _sut.GetSquaredGrid(GridSize.Advanced, DifficultyLevel.Advanced);

            const int expected = 20;
            int actual = grid.GetLength(1);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridContainingAFullSetOfTilesForGameModeBeginner()
        {
            Tile[,] grid = _sut.GetSquaredGrid(GridSize.Beginner, DifficultyLevel.Beginner);

            CollectionAssert.AllItemsAreInstancesOfType(grid, typeof (Tile));
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridContainingAFullSetOfTilesForGameModeNormal()
        {
            Tile[,] grid = _sut.GetSquaredGrid(GridSize.Normal, DifficultyLevel.Normal);

            CollectionAssert.AllItemsAreInstancesOfType(grid, typeof(Tile));
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridContainingAFullSetOfTilesForGameModeAdvanced()
        {
            Tile[,] grid = _sut.GetSquaredGrid(GridSize.Advanced, DifficultyLevel.Advanced);

            CollectionAssert.AllItemsAreInstancesOfType(grid, typeof(Tile));
        }
       
        [Test]
        public void GetSquaredGrid_ReturnAGridWithTheCorrectNumberOfTilesForGameModeBeginner()
        {
            Tile[,] grid = _sut.GetSquaredGrid(GridSize.Beginner, DifficultyLevel.Beginner);

            const int expected = 81;
            long actual = grid.LongLength;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridWithTheCorrectNumberOfTilesForGameModeNormal()
        {
            Tile[,] grid = _sut.GetSquaredGrid(GridSize.Normal, DifficultyLevel.Normal);

            const int expected = 256;
            long actual = grid.LongLength;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridWithTheCorrectNumberOfTilesForGameModeAdvanced()
        {
            Tile[,] grid = _sut.GetSquaredGrid(GridSize.Advanced, DifficultyLevel.Advanced);

            const int expected = 400;
            long actual = grid.LongLength;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_DefaultTheGridCreatedToGameModeBeginnerIfGridSizeParameterIsUndefined()
        {
            Tile[,] grid = _sut.GetSquaredGrid(new GridSize(), DifficultyLevel.Beginner);

            const int expected = 81;
            long actual = grid.LongLength;

            Assert.AreEqual(expected, actual);
        }

        [TearDown]
        public void TearDown()
        {
            _sut = null;       
        }
    }
}
