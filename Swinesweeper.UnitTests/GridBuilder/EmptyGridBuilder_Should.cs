using NUnit.Framework;
using Swinesweeper.GameModeFactory;
using Swinesweeper.GamePlay;
using Swinesweeper.GridBuilder;
using Swinesweeper.GridBuilder.Interfaces;

namespace Swinesweeper.UnitTests.GridBuilder
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
        public void GetSquaredGrid_ReturnABeginnerGrid_IfGridSizeParamIsUndefined()
        {
            Tile[,] grid = _sut.GetSquaredGrid(new GridSize(), DifficultyLevel.Beginner);

            const int expectedTileCount = 81;
            long actualTileCount = grid.LongLength;

            Assert.AreEqual(expectedTileCount, actualTileCount);
        }

        [Test]
        public void GetSquaredGrid_SetTileProperty_FlagCount_ToDifficultyLevelBeginner()
        {
            _sut.GetSquaredGrid(GridSize.Beginner, DifficultyLevel.Beginner);

            const int expected = 10;
            int actual = Tile.FlagCount;

            Assert.AreEqual(expected, actual);           
        }

        [Test]
        public void GetSquaredGrid_SetTileProperty_FlagCount_ToDifficultyLevelNormal()
        {
            _sut.GetSquaredGrid(GridSize.Normal, DifficultyLevel.Normal);

            const int expected = 40;
            int actual = Tile.FlagCount;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_SetTileProperty_FlagCount_ToDifficultyLevelAdvanced()
        {
            _sut.GetSquaredGrid(GridSize.Advanced, DifficultyLevel.Advanced);

            const int expected = 80;
            int actual = Tile.FlagCount;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_SetTileProperty_MineCount_ToDifficultyLevelBeginner()
        {
            _sut.GetSquaredGrid(GridSize.Beginner, DifficultyLevel.Beginner);

            const int expected = 10;
            int actual = Tile.MineCount;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_SetTileProperty_MineCount_ToDifficultyLevelNormal()
        {
            _sut.GetSquaredGrid(GridSize.Normal, DifficultyLevel.Normal);

            const int expected = 40;
            int actual = Tile.MineCount;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_SetTileProperty_MineCount_ToDifficultyLevelAdvanced()
        {
            _sut.GetSquaredGrid(GridSize.Advanced, DifficultyLevel.Advanced);

            const int expected = 80;
            int actual = Tile.MineCount;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_SetTileProperty_TileCount_ToBeginnerGridSizeSquared()
        {
            _sut.GetSquaredGrid(GridSize.Beginner, DifficultyLevel.Beginner);

            const int expected = 81;
            int actual = Tile.TileCount;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_SetTileProperty_TileCount_ToNormalGridSize_Squared()
        {
            _sut.GetSquaredGrid(GridSize.Normal, DifficultyLevel.Normal);

            const int expected = 256;
            int actual = Tile.TileCount;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_SetTileProperty_Grid_ToReturnedGrid()
        {
            Tile[,] grid = _sut.GetSquaredGrid(GridSize.Advanced, DifficultyLevel.Advanced);

            Assert.AreEqual(grid, Tile.ParentGrid);
        }

        [Test]
        public void GetSquaredGrid_SetTileProperty_TileCount_ToAdvancedGridSize_Squared()
        {
            _sut.GetSquaredGrid(GridSize.Advanced, DifficultyLevel.Advanced);

            const int expected = 400;
            int actual = Tile.TileCount;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridWith_NineRows_ForGameModeBeginner()
        {
            Tile[,] grid = _sut.GetSquaredGrid(GridSize.Beginner, DifficultyLevel.Beginner);

            const int expected = 9;
            int actual = grid.GetLength(0);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridWith_SixteenRows_ForGameModeNormal()
        {
            Tile[,] grid = _sut.GetSquaredGrid(GridSize.Normal, DifficultyLevel.Normal);

            const int expected = 16;
            int actual = grid.GetLength(0);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridWith_TwentyRows_ForGameModeAdvanced()
        {
            Tile[,] grid = _sut.GetSquaredGrid(GridSize.Advanced, DifficultyLevel.Advanced);

            const int expected = 20;
            int actual = grid.GetLength(0);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridWith_NineColumns_ForGameModeBeginner()
        {
            Tile[,] grid = _sut.GetSquaredGrid(GridSize.Beginner, DifficultyLevel.Beginner);

            const int expected = 9;
            int actual = grid.GetLength(1);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridWith_SixteenColumns_ForGameModeNormal()
        {
            Tile[,] grid = _sut.GetSquaredGrid(GridSize.Normal, DifficultyLevel.Normal);

            const int expected = 16;
            int actual = grid.GetLength(1);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridWith_TwentyColumns_ForGameModeAdvanced()
        {
            Tile[,] grid = _sut.GetSquaredGrid(GridSize.Advanced, DifficultyLevel.Advanced);

            const int expected = 20;
            int actual = grid.GetLength(1);

            Assert.AreEqual(expected, actual);
        }
       
        [Test]
        public void GetSquaredGrid_ReturnAGridWith_81Tiles_ForGameModeBeginner()
        {
            Tile[,] grid = _sut.GetSquaredGrid(GridSize.Beginner, DifficultyLevel.Beginner);

            const int expected = 81;
            long actual = grid.LongLength;

            Assert.AreEqual(expected, actual);
            CollectionAssert.AllItemsAreInstancesOfType(grid, typeof(Tile));
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridWith_256Tiles_ForGameModeNormal()
        {
            Tile[,] grid = _sut.GetSquaredGrid(GridSize.Normal, DifficultyLevel.Normal);

            const int expected = 256;
            long actual = grid.LongLength;

            Assert.AreEqual(expected, actual);
            CollectionAssert.AllItemsAreInstancesOfType(grid, typeof(Tile));
        }

        [Test]
        public void GetSquaredGrid_ReturnAGridWith_400Tiles_ForGameModeAdvanced()
        {
            Tile[,] grid = _sut.GetSquaredGrid(GridSize.Advanced, DifficultyLevel.Advanced);

            const int expected = 400;
            long actual = grid.LongLength;

            Assert.AreEqual(expected, actual);
            CollectionAssert.AllItemsAreInstancesOfType(grid, typeof(Tile));
        }


        [TearDown]
        public void TearDown()
        {
            _sut = null;       
        }
    }
}
