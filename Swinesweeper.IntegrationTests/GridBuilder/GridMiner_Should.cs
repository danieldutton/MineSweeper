using NUnit.Framework;
using Swinesweeper.GameModeFactory;
using Swinesweeper.GamePlay;
using Swinesweeper.GridBuilder;
using Swinesweeper.GridBuilder.Interfaces;
using Swinesweeper.Utilities;
using System.Collections.Generic;
using System.Linq;

namespace Swinesweeper.IntegrationTests.GridBuilder
{
    [TestFixture]
    public class GridMiner_Should
    {
        private IGridMiner _gridMiner;

        private EmptyGridBuilder _emptyGridBuilder;

        [SetUp]
        public void Init()
        {
            _gridMiner = new GridMiner(new RandomNumberGenerator());
            _emptyGridBuilder = new EmptyGridBuilder();
        }

        [Test]
        public void MineGrid_SeedABeginnerGridWith_10_Mines()
        {
            Tile[,] grid = _emptyGridBuilder.GetSquaredGrid(GridSize.Beginner, DifficultyLevel.Beginner);

            Tile[,] minedGrid = _gridMiner.MineTheGrid(grid, DifficultyLevel.Beginner, GridSize.Beginner);

            List<Tile> flattenedGrid = minedGrid.Cast<Tile>().ToList();

            const int expected = 10;
            int actual = flattenedGrid.Count(p => p.IsMined);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MineGrid_SeedANormalGridWith_40_Mines()
        {
            Tile[,] grid = _emptyGridBuilder.GetSquaredGrid(GridSize.Normal, DifficultyLevel.Normal);

            Tile[,] minedGrid = _gridMiner.MineTheGrid(grid, DifficultyLevel.Normal, GridSize.Normal);

            List<Tile> flattenedGrid = minedGrid.Cast<Tile>().ToList();

            const int expected = 40;
            int actual = flattenedGrid.Count(p => p.IsMined);

            Assert.AreEqual(expected, actual);
                
        }

        [Test]
        public void MineGrid_SeedAnAdvancedGridWith_80_Mines()
        {
            Tile[,] grid = _emptyGridBuilder.GetSquaredGrid(GridSize.Advanced, DifficultyLevel.Normal);

            Tile[,] minedGrid = _gridMiner.MineTheGrid(grid, DifficultyLevel.Advanced, GridSize.Advanced);

            List<Tile> flattenedGrid = minedGrid.Cast<Tile>().ToList();

            const int expected = 80;
            int actual = flattenedGrid.Count(p => p.IsMined);

            Assert.AreEqual(expected, actual);      
        }

        [TearDown]
        public void TearDown()
        {
            _gridMiner = null;
            _emptyGridBuilder = null;
        }
    }
}
