using MineSweeper.GridTools.Interfaces;
using MineSweeper.Model.Components;
using MineSweeper.Settings;
using NUnit.Framework;

namespace MineSweeper.GridTools.UnitTests
{
    [TestFixture]
    public class GridGeneratorShould
    {
        private IGridGenerator _gridGenerator;

        [SetUp]
        public void Init()
        {
            _gridGenerator = new GridBuilder();
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridWithNineRowsForGameModeBeginner()
        {
            Tile[,] grid = _gridGenerator.GetSquaredGrid(GridSize.Beginner);
            
            const int expected = 9;
            int actual = grid.GetLength(0);
            
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridWithSixteenRowsForGameModeNormal()
        {
            Tile[,] grid = _gridGenerator.GetSquaredGrid(GridSize.Normal);

            const int expected = 16;
            int actual = grid.GetLength(0);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridWithTwentyRowsForGameModeAdvanced()
        {
            Tile[,] grid = _gridGenerator.GetSquaredGrid(GridSize.Advanced);

            const int expected = 20;
            int actual = grid.GetLength(0);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridWithNineColumnsForGameModeBeginner()
        {
            Tile[,] grid = _gridGenerator.GetSquaredGrid(GridSize.Beginner);

            const int expected = 9;
            int actual = grid.GetLength(1);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridWithSixteenColumnsForGameModeNormal()
        {
            Tile[,] grid = _gridGenerator.GetSquaredGrid(GridSize.Normal);

            const int expected = 16;
            int actual = grid.GetLength(1);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridWithTwentyColumnsForGameModeAdvanced()
        {
            Tile[,] grid = _gridGenerator.GetSquaredGrid(GridSize.Advanced);

            const int expected = 20;
            int actual = grid.GetLength(1);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridContainingAFullSetOfTilesForGameModeBeginner()
        {
            Tile[,] grid = _gridGenerator.GetSquaredGrid(GridSize.Beginner);

            CollectionAssert.AllItemsAreInstancesOfType(grid, typeof (Tile));
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridContainingAFullSetOfTilesForGameModeNormal()
        {
            Tile[,] grid = _gridGenerator.GetSquaredGrid(GridSize.Normal);

            CollectionAssert.AllItemsAreInstancesOfType(grid, typeof(Tile));
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridContainingAFullSetOfTilesForGameModeAdvanced()
        {
            Tile[,] grid = _gridGenerator.GetSquaredGrid(GridSize.Advanced);

            CollectionAssert.AllItemsAreInstancesOfType(grid, typeof(Tile));
        }
       
        [Test]
        public void GetSquaredGrid_ReturnAGridWithTheCorrectNumberOfTilesForGameModeBeginner()
        {
            Tile[,] grid = _gridGenerator.GetSquaredGrid(GridSize.Beginner);

            const int expected = 81;
            long actual = grid.LongLength;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridWithTheCorrectNumberOfTilesForGameModeNormal()
        {
            Tile[,] grid = _gridGenerator.GetSquaredGrid(GridSize.Normal);

            const int expected = 256;
            long actual = grid.LongLength;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridWithTheCorrectNumberOfTilesForGameModeAdvanced()
        {
            Tile[,] grid = _gridGenerator.GetSquaredGrid(GridSize.Advanced);

            const int expected = 400;
            long actual = grid.LongLength;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_DefaultTheGridCreatedToGameModeBeginnerIfGridSizeParameterIsUndefined()
        {
            Tile[,] grid = _gridGenerator.GetSquaredGrid(new GridSize());

            const int expected = 81;
            long actual = grid.LongLength;

            Assert.AreEqual(expected, actual);
        }

        [TearDown]
        public void TearDown()
        {
            _gridGenerator = null;       
        }
    }
}
