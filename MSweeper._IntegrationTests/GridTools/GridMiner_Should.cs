using MSweeper.GameModeFactory.Settings;
using MSweeper.GridTools;
using MSweeper.GridTools.Interfaces;
using MSweeper.Model;
using MSweeper.Utilities;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace MSweeper._IntegrationTests.GridTools
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
        public void MineGrid_SeedABeginnerGridWithTenMines()
        {
            Tile[,] grid = _emptyGridBuilder.GetSquaredGrid(GridSize.Beginner);

            Tile[,] minedGrid = _gridMiner.MineTheGrid(grid, DifficultyLevel.Beginner, GridSize.Beginner);

            List<Tile> flattenedGrid = minedGrid.Cast<Tile>().ToList();

            const int expected = 10;
            int actual = flattenedGrid.Count(p => p.IsMined);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MineGrid_SeedANormalGridWithFortyMines()
        {
            Tile[,] grid = _emptyGridBuilder.GetSquaredGrid(GridSize.Normal);

            Tile[,] minedGrid = _gridMiner.MineTheGrid(grid, DifficultyLevel.Normal, GridSize.Normal);

            List<Tile> flattenedGrid = minedGrid.Cast<Tile>().ToList();

            const int expected = 40;
            int actual = flattenedGrid.Count(p => p.IsMined);

            Assert.AreEqual(expected, actual);
                
        }

        [Test]
        public void MineGrid_SeedAnAdvancedGridWithNinetyNineMines()
        {
            Tile[,] grid = _emptyGridBuilder.GetSquaredGrid(GridSize.Advanced);

            Tile[,] minedGrid = _gridMiner.MineTheGrid(grid, DifficultyLevel.Advanced, GridSize.Advanced);

            List<Tile> flattenedGrid = minedGrid.Cast<Tile>().ToList();

            const int expected = 99;
            int actual = flattenedGrid.Count(p => p.IsMined);

            Assert.AreEqual(expected, actual);      
        }

        [TearDown]
        public void TearDown()
        {
            _gridMiner = null;
        }
    }
}
