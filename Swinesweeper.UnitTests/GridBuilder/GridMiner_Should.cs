using Moq;
using NUnit.Framework;
using Swinesweeper.GameModeFactory;
using Swinesweeper.GamePlay;
using Swinesweeper.GridBuilder;
using Swinesweeper.Utilities.Interfaces;
using System;
using System.Linq;

namespace Swinesweeper.UnitTests.GridBuilder
{
    [TestFixture]
    public class GridMiner_Should
    {
        private Mock<IRandomNumberGenerator> _fakeNumberGenerator;

        private GridMiner _sut;
            
        [SetUp]
        public void Init()
        {
            _fakeNumberGenerator = new Mock<IRandomNumberGenerator>();
            _sut = new GridMiner(_fakeNumberGenerator.Object);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MineTheGrid_ThrowAnArgumentNullException_IfGridParamIsNull()
        {
            _sut.MineTheGrid(null, DifficultyLevel.Beginner, GridSize.Beginner);
        }

        [Test]
        public void MineTheGrid_ReturnAGridWithExactly_10Mines_ForGameModeBeginner()
        {
            Tile[,] grid = Mother.GetTestGrid(GridSize.Beginner);

            int counter = 0;

            int[] testCoordinates = Mother.GetTestCoordinates(GridSize.Beginner);

            _fakeNumberGenerator.Setup(x => x.GetRandomNumber(It.IsAny<int>(), It.IsAny<int>()))
                .Returns(() => testCoordinates[counter])
                .Callback(() => counter++);

            Tile[,] minedGrid = _sut.MineTheGrid(grid, DifficultyLevel.Beginner, GridSize.Beginner);
            Tile[] flattenedGrid = minedGrid.Cast<Tile>().ToArray();

            Assert.AreEqual(10, flattenedGrid.Count(x => x.IsMined));
        }

        [Test]
        public void MineTheGrid_ReturnAGridWithExactly_40Mines_ForGameModeNormal()
        {
            Tile[,] grid = Mother.GetTestGrid(GridSize.Normal);

            int counter = 0;

            int[] testCoordinates = Mother.GetTestCoordinates(GridSize.Normal);

            _fakeNumberGenerator.Setup(x => x.GetRandomNumber(It.IsAny<int>(), It.IsAny<int>()))
                .Returns(() => testCoordinates[counter])
                .Callback(() => counter++);

            Tile[,] minedGrid = _sut.MineTheGrid(grid, DifficultyLevel.Normal, GridSize.Normal);
            Tile[] flattenedGrid = minedGrid.Cast<Tile>().ToArray();

            Assert.AreEqual(40, flattenedGrid.Count(x => x.IsMined));
        }

        [Test]
        public void MineTheGrid_ReturnAGridWithExactly_80Mines_ForGameModeAdvanced()
        {
            Tile[,] grid = Mother.GetTestGrid(GridSize.Advanced);

            int counter = 0;

            int[] testCoordinates = Mother.GetTestCoordinates(GridSize.Advanced);

            _fakeNumberGenerator.Setup(x => x.GetRandomNumber(It.IsAny<int>(), It.IsAny<int>()))
                .Returns(() => testCoordinates[counter])
                .Callback(() => counter++);

            Tile[,] result = _sut.MineTheGrid(grid, DifficultyLevel.Advanced, GridSize.Advanced);
            Tile[] minedGrid = result.Cast<Tile>().ToArray();

            Assert.AreEqual(80, minedGrid.Count(x => x.IsMined));
        }

        [TearDown]
        public void TearDown()
        {
            _fakeNumberGenerator = null;
            _sut = null;
        }
    }
}
