using MSweeper.GridTools;
using MSweeper.GridTools.Interfaces;
using MSweeper.GridTools.Settings;
using MSweeper.Model.Components;
using MSweeper.Utilities;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace MSweeper._UnitTests.GridTools
{
    [TestFixture]
    public class GridMinerShould
    {
        private IGridMiner _gridMiner;

        [SetUp]
        public void Init()
        {
            _gridMiner = new GridMiner(new RandomNumberGenerator());
        }

        [Test]
        public void MineGrid_SeedABeginnerGridWithTenMines()
        {
            //put this in mother class as mock
            var gridGenerator = new EmptyGridBuilder();
            Tile[,] grid = gridGenerator.GetSquaredGrid(GridSize.Beginner);

            Tile[,] minedGrid = _gridMiner.MineTheGrid(grid, DifficultyLevel.Beginner, GridSize.Beginner);

            List<Tile> flattenedGrid = minedGrid.Cast<Tile>().ToList();

            const int expected = 10;
            int actual = flattenedGrid.Count(p => p.IsMined);

            Assert.AreEqual(expected, actual);
        }
        //60 mines
        [Test]
        public void MineGrid_SeedANormalGridWithFortyMines()
        {
            var gridGenerator = new EmptyGridBuilder();
            Tile[,] grid = gridGenerator.GetSquaredGrid(GridSize.Normal);

            Tile[,] minedGrid = _gridMiner.MineTheGrid(grid, DifficultyLevel.Normal, GridSize.Normal);

            List<Tile> flattenedGrid = minedGrid.Cast<Tile>().ToList();

            const int expected = 40;
            int actual = flattenedGrid.Count(p => p.IsMined);

            Assert.AreEqual(expected, actual);
                
        }
        //99 mines
        [Test]
        public void MineGrid_SeedAnAdvancedGridWithNinetyNineMines()
        {
            var gridGenerator = new EmptyGridBuilder();
            Tile[,] grid = gridGenerator.GetSquaredGrid(GridSize.Advanced);

            var gridMiner = new GridMiner(new RandomNumberGenerator());
            Tile[,] minedGrid = gridMiner.MineTheGrid(grid, DifficultyLevel.Advanced, GridSize.Advanced);

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
