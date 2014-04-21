using NUnit.Framework;
using Swinesweeper.GameModeFactory.GameModes;
using Swinesweeper.GamePlay;
using Swinesweeper.GamePlay.Interfaces;
using Swinesweeper.GridBuilder;
using Swinesweeper.GridBuilder.Interfaces;
using Swinesweeper.Utilities;
using Swinesweeper.Utilities.Interfaces;
using System.Linq;

namespace Swinesweeper.IntegrationTests.GridBuilder
{
    [TestFixture]
    public class GridPainter_Should
    {
        private IGridMiner _gridMiner;

        private IRandomNumberGenerator _randomNumberGenerator;

        private IGridBuilder _emptyGridBuilder;

        private IGridControlBuilder _gridControlBuilder;

        private IPigCounter _pigCounter;

        private GridPainter _sut;

        [SetUp]
        public void Init()
        {
            _randomNumberGenerator = new RandomNumberGenerator();
            _gridMiner = new GridMiner(_randomNumberGenerator);
            _emptyGridBuilder = new EmptyGridBuilder();
            _gridControlBuilder = new GridControlBuilder();
            _pigCounter = new PigCounter();
            _sut = new GridPainter(_emptyGridBuilder, _gridControlBuilder, _gridMiner, _pigCounter);
        }

        [Test]
        public void PaintGrid_ReturnAGridWith81TilesForGameMode_Beginner()
        {
            Tile[,] grid = _sut.PaintGrid(new Beginner(), new Tile());

            Tile[] flattenedGrid = grid.Cast<Tile>().ToArray();

            Assert.AreEqual(81, flattenedGrid.Count());
        }

        [Test]
        public void PaintGrid_ReturnAGridWith10MinesForGameMode_Beginner()
        {
            Tile[,] grid = _sut.PaintGrid(new Beginner(), new Tile());

            Tile[] flattenedGrid = grid.Cast<Tile>().Where(x => x.IsMined).ToArray();

            Assert.AreEqual(10, flattenedGrid.Count());
        }

        [Test]
        public void PaintGrid_ReturnAGridWith256TilesForGameMode_Normal()
        {
            Tile[,] grid = _sut.PaintGrid(new Normal(), new Tile());

            Tile[] flattenedGrid = grid.Cast<Tile>().ToArray();

            Assert.AreEqual(256, flattenedGrid.Count());
        }

        [Test]
        public void PaintGrid_ReturnAGridWith40MinesForGameMode_Normal()
        {
            Tile[,] grid = _sut.PaintGrid(new Normal(), new Tile());

            Tile[] flattenedGrid = grid.Cast<Tile>().Where(x => x.IsMined).ToArray();

            Assert.AreEqual(40, flattenedGrid.Count());
        }

        [Test]
        public void PaintGrid_ReturnAGridWith400TilesForGameMode_Advanced()
        {
            Tile[,] grid = _sut.PaintGrid(new Advanced(), new Tile());

            Tile[] flattenedGrid = grid.Cast<Tile>().ToArray();

            Assert.AreEqual(400, flattenedGrid.Count());
        }

        [Test]
        public void PaintGrid_ReturnAGridWith80MinesForGameMode_Advanced()
        {
            Tile[,] grid = _sut.PaintGrid(new Advanced(), new Tile());

            Tile[] flattenedGrid = grid.Cast<Tile>().Where(x => x.IsMined).ToArray();

            Assert.AreEqual(80, flattenedGrid.Count());
        }

        [TearDown]
        public void TearDown()
        {
            _gridMiner = null;
            _randomNumberGenerator = null;
            _emptyGridBuilder = null;
            _gridControlBuilder = null;
            _pigCounter = null;
            _sut = null;
        }
    }
}
