using System;
using Moq;
using NUnit.Framework;
using Swinesweeper.GamePlay;
using Swinesweeper.GamePlay.Interfaces;

namespace Swinesweeper.UnitTests.GamePlay
{
    [TestFixture]
    public class TileCascader_Should
    {

        #region CascadeTile

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CascadeTile_ThrowArgumentNullException_IfGridIsNull()
        {
            var fakeTilePainter = new Mock<ITilePainter>();
            var sut = new TileCascader(fakeTilePainter.Object);
            sut.CascadeTile(null, 0, 0);
        }

        [Test]
        public void CascadeTile_IfTheCellIsMined_LeaveCellIsClearedPropertyTo_False()
        {
            var fakeTilePainter = new Mock<ITilePainter>();
            Tile[,] grid = new Tile[1,1];
            grid[0, 0] = new Tile {IsMined = true};
            var sut = new TileCascader(fakeTilePainter.Object);
            Tile[,] result = sut.CascadeTile(grid, 0, 0);
            Assert.IsFalse(result[0,0].IsCleared);
        }

        [Test]
        public void CascadeTile_IfTheCellIsNotMined_SetIsClearedPropertyToTrue()
        {
            var fakeTilePainter = new Mock<ITilePainter>();
            Tile[,] grid = new Tile[1, 1];
            grid[0, 0] = new Tile { IsMined = false };
            var sut = new TileCascader(fakeTilePainter.Object);
            Tile[,] result = sut.CascadeTile(grid, 0, 0);
            Assert.IsTrue(result[0, 0].IsCleared);    
        }

        [Test]
        public void CascadeTile_CallDisplayMineCount_ExactlyOnce()
        {
            var fakeTilePainter = new Mock<ITilePainter>();
            Tile[,] grid = new Tile[1, 1];
            grid[0, 0] = new Tile { IsMined = false };
            var sut = new TileCascader(fakeTilePainter.Object);
            sut.CascadeTile(grid, 0, 0);
            fakeTilePainter.Verify(x => x.PaintMineCount(It.IsAny<Tile[,]>(), It.IsAny<int>(), It.IsAny<int>()), Times.Once());
        }

        [Test]
        public void CascadeTile_CallDisplayMineCount_WithTheCorrectData()
        {
            var fakeTilePainter = new Mock<ITilePainter>();
            Tile[,] grid = new Tile[1, 1];
            grid[0, 0] = new Tile { IsMined = false };
            var sut = new TileCascader(fakeTilePainter.Object);
            sut.CascadeTile(grid, 0, 0);
            fakeTilePainter.Verify(x => x.PaintMineCount(It.Is<Tile[,]>(y => y == grid), It.Is<int>(y => y == 0), It.Is<int>(y => y == 0)));
        }

        #endregion

        #region CascadeAll

        [Test]
        public void CascadeAll_ThrowArgumentNullException_IfGridIsNull()
        {
            var fakeTilePainter = new Mock<ITilePainter>();
            var sut = new TileCascader(fakeTilePainter.Object);
            sut.CascadeAll(null);
        }

        [Test]
        public void CascadeAll_Call_PaintMine_0Times_If0Mines()
        {
            var fakeTilePainter = new Mock<ITilePainter>();
            Tile[,] grid = new Tile[1, 1];
            grid[0, 0] = new Tile { IsMined = false };
            var sut = new TileCascader(fakeTilePainter.Object);
            sut.CascadeAll(grid);
            fakeTilePainter.Verify(x => x.PaintMine(It.IsAny<Tile[,]>(), It.IsAny<int>(), It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void CascadeAll_Call_PaintMine_1Times_If1Mine()
        {
            var fakeTilePainter = new Mock<ITilePainter>();
            Tile[,] grid = new Tile[1, 1];
            grid[0, 0] = new Tile { IsMined = true };
            var sut = new TileCascader(fakeTilePainter.Object);
            sut.CascadeAll(grid);
            fakeTilePainter.Verify(x => x.PaintMine(It.IsAny<Tile[,]>(), It.IsAny<int>(), It.IsAny<int>()), Times.Once());
        }

        [Test]
        public void CascadeAll_Call_PaintMine_5Times_If5Mines()
        {
            var fakeTilePainter = new Mock<ITilePainter>();
            Tile[,] grid = new Tile[1, 5];
            grid[0, 0] = new Tile { IsMined = true };
            grid[0, 1] = new Tile { IsMined = true };
            grid[0, 2] = new Tile { IsMined = true };
            grid[0, 3] = new Tile { IsMined = true };
            grid[0, 4] = new Tile { IsMined = true };
            var sut = new TileCascader(fakeTilePainter.Object);
            sut.CascadeAll(grid);
            fakeTilePainter.Verify(x => x.PaintMine(It.IsAny<Tile[,]>(), It.IsAny<int>(), It.IsAny<int>()), Times.Exactly(5));         
        }

        [Test]
        public void CascadeAll_Call_PaintMine_10Times_If10Mines()
        {
            var fakeTilePainter = new Mock<ITilePainter>();
            Tile[,] grid = new Tile[1, 10];
            grid[0, 0] = new Tile { IsMined = true };
            grid[0, 1] = new Tile { IsMined = true };
            grid[0, 2] = new Tile { IsMined = true };
            grid[0, 3] = new Tile { IsMined = true };
            grid[0, 4] = new Tile { IsMined = true };
            grid[0, 5] = new Tile { IsMined = true };
            grid[0, 6] = new Tile { IsMined = true };
            grid[0, 7] = new Tile { IsMined = true };
            grid[0, 8] = new Tile { IsMined = true };
            grid[0, 9] = new Tile { IsMined = true };
            grid[0, 10] = new Tile { IsMined = true };
            var sut = new TileCascader(fakeTilePainter.Object);
            sut.CascadeAll(grid);
            fakeTilePainter.Verify(x => x.PaintMine(It.IsAny<Tile[,]>(), It.IsAny<int>(), It.IsAny<int>()), Times.Exactly(11));
        }

        [Test]
        public void CascadeAll_Call_PaintMine_WithCorrectParameters()
        {
            var fakeTilePainter = new Mock<ITilePainter>();
            Tile[,] grid = new Tile[1, 1];
            grid[0, 0] = new Tile { IsMined = true };
            var sut = new TileCascader(fakeTilePainter.Object);
            sut.CascadeAll(grid);
            fakeTilePainter.Verify(x => x.PaintMine(It.Is<Tile[,]>(y => y == grid), It.Is<int>(y => y == 0), It.Is<int>(y => y ==0)), Times.Never);
        }

        [Test]
        public void CascadeAll_Call_PaintMineCount_81Times_If81Tiles()
        {
            var fakeTilePainter = new Mock<ITilePainter>();
            Tile[,] grid = new Tile[1, 1];
            grid[0, 0] = new Tile { IsMined = false };
            var sut = new TileCascader(fakeTilePainter.Object);
            sut.CascadeAll(grid);
            fakeTilePainter.Verify(x => x.PaintMineCount(It.IsAny<Tile[,]>(), It.IsAny<int>(), It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void CascadeAll_Call_PaintMineCount_256Times_If256Tiles()
        {
            var fakeTilePainter = new Mock<ITilePainter>();
            Tile[,] grid = new Tile[1, 1];
            grid[0, 0] = new Tile { IsMined = false };
            var sut = new TileCascader(fakeTilePainter.Object);
            sut.CascadeAll(grid);
            fakeTilePainter.Verify(x => x.PaintMineCount(It.IsAny<Tile[,]>(), It.IsAny<int>(), It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void CascadeAll_Call_PaintMineCount_400Times_If400Tiles()
        {
            var fakeTilePainter = new Mock<ITilePainter>();
            Tile[,] grid = new Tile[1, 1];
            grid[0, 0] = new Tile { IsMined = false };
            var sut = new TileCascader(fakeTilePainter.Object);
            sut.CascadeAll(grid);
            fakeTilePainter.Verify(x => x.PaintMineCount(It.IsAny<Tile[,]>(), It.IsAny<int>(), It.IsAny<int>()), Times.Never);
        }

        [Test]
        public void CascadeAll_Call_PaintMineCount_WithCorrectParameterData()
        {
            var fakeTilePainter = new Mock<ITilePainter>();
            Tile[,] grid = new Tile[1, 1];
            grid[0, 0] = new Tile { IsMined = false };
            var sut = new TileCascader(fakeTilePainter.Object);
            sut.CascadeAll(grid);
            fakeTilePainter.Verify(x => x.PaintMineCount(It.IsAny<Tile[,]>(), It.IsAny<int>(), It.IsAny<int>()), Times.Never);
        }

        #endregion
    }
}
