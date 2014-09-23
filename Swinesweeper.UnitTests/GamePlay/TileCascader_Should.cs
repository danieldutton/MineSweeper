using Moq;
using NUnit.Framework;
using Swinesweeper.GameModeFactory;
using Swinesweeper.GamePlay;
using Swinesweeper.GamePlay.Interfaces;
using System;

namespace Swinesweeper.UnitTests.GamePlay
{
    [TestFixture]
    public class TileCascader_Should
    {
        private Mock<ITilePainter> _fakeTilePainter;

        private Tile[,] _grid1By1;

        private Tile[,] _grid5By5;

        private TileCascader _sut;

        [SetUp]
        public void Init()
        {
            _fakeTilePainter = new Mock<ITilePainter>();
            
            _grid1By1 = Mother.GetCustomTestGrid(1, 1);
            _grid5By5 = Mother.GetCustomTestGrid(5, 5);
            
            _sut = new TileCascader(_fakeTilePainter.Object);
        }

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void CascadeSingle_ThrowArgumentNullException_IfGridIsNull()
        {
            _sut.CascadeSingle(null, 0, 0);
        }

        [Test]
        public void CascadeSingle_IfTheCellIsMined_LeaveCellIsClearedPropertyTo_False()
        {
            _grid1By1[0, 0] = new Tile {IsMined = true};

            Tile[,] result = _sut.CascadeSingle(_grid1By1, 0, 0);

            Assert.IsFalse(result[0, 0].IsCleared);
        }

        [Test]
        public void CascadeSingle_IfTheCellIsNotMined_SetIsClearedPropertyToTrue()
        {
            _grid1By1[0, 0] = new Tile {IsMined = false};

            Tile[,] result = _sut.CascadeSingle(_grid1By1, 0, 0);

            Assert.IsTrue(result[0, 0].IsCleared);
        }

        [Test]
        public void CascadeSingle_CallDisplayMineCount_ExactlyOnce()
        {
            _grid1By1[0, 0] = new Tile {IsMined = false};

            _sut.CascadeSingle(_grid1By1, 0, 0);

            _fakeTilePainter.Verify(x => x.PaintMineCount(It.IsAny<Tile[,]>(), 
                It.IsAny<int>(), 
                It.IsAny<int>()),
                Times.Once());
        }

        [Test]
        public void CascadeSingle_CallDisplayMineCount_WithTheCorrectData()
        {
            _grid1By1[0, 0] = new Tile {IsMined = false};

            _sut.CascadeSingle(_grid1By1, 0, 0);

            _fakeTilePainter.Verify(
                x => x.PaintMineCount(It.Is<Tile[,]>(y => y == _grid1By1), 
                    It.Is<int>(y => y == 0),
                    It.Is<int>(y => y == 0)));
        }


        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void CascadeAll_ThrowArgumentNullException_IfGridIs_Null()
        {
            _sut.CascadeAll(null);
        }

        [Test]
        public void CascadeAll_CallPaintMine_0Times_If0Mines()
        {
            _sut.CascadeAll(_grid5By5);

            _fakeTilePainter.Verify(x => x.PaintMine(It.IsAny<Tile[,]>(), 
                It.IsAny<int>(),
                It.IsAny<int>()), 
                Times.Never);
        }

        [Test]
        public void CascadeAll_CallPaintMine_1Time_If1Mine()
        {
            _grid5By5[0, 0] = new Tile {IsMined = true};

            _sut.CascadeAll(_grid5By5);

            _fakeTilePainter.Verify(x => x.PaintMine(It.IsAny<Tile[,]>(), 
                It.IsAny<int>(),
                It.IsAny<int>()), 
                Times.Once());
        }

        [Test]
        public void CascadeAll_Call_PaintMine_5Times_If5Mines()
        {
            _grid5By5[0, 0] = new Tile {IsMined = true};
            _grid5By5[0, 1] = new Tile {IsMined = true};
            _grid5By5[0, 2] = new Tile {IsMined = true};
            _grid5By5[0, 3] = new Tile {IsMined = true};
            _grid5By5[0, 4] = new Tile {IsMined = true};

            _sut.CascadeAll(_grid5By5);

            _fakeTilePainter.Verify(x => x.PaintMine(It.IsAny<Tile[,]>(), 
                It.IsAny<int>(),
                It.IsAny<int>()), 
                Times.Exactly(5));
        }

        [Test]
        public void CascadeAll_Call_PaintMine_10Times_If10Mines()
        {
            _grid5By5[0, 0] = new Tile {IsMined = true};
            _grid5By5[0, 1] = new Tile {IsMined = true};
            _grid5By5[0, 2] = new Tile {IsMined = true};
            _grid5By5[0, 3] = new Tile {IsMined = true};
            _grid5By5[0, 4] = new Tile {IsMined = true};
            _grid5By5[1, 0] = new Tile {IsMined = true};
            _grid5By5[1, 1] = new Tile {IsMined = true};
            _grid5By5[1, 2] = new Tile {IsMined = true};
            _grid5By5[1, 3] = new Tile {IsMined = true};
            _grid5By5[1, 4] = new Tile {IsMined = true};

            _sut.CascadeAll(_grid5By5);

            _fakeTilePainter.Verify(x => x.PaintMine(It.IsAny<Tile[,]>(),
                It.IsAny<int>(),
                It.IsAny<int>()), 
                Times.Exactly(10));
        }

        [Test]
        public void CascadeAll_Call_PaintMine_WithCorrectParameters()
        {
            _grid5By5[0, 0] = new Tile {IsMined = true};

            _sut.CascadeAll(_grid5By5);

            _fakeTilePainter.Verify(x => x.PaintMine(It.Is<Tile[,]>(y => y == _grid5By5), 
                It.Is<int>(y => y == 0),
                It.Is<int>(y => y == 0)));
        }

        [Test]
        public void CascadeAll_Call_PaintMineCount_81Times_ForBeginnerSizeGrid()
        {
            Tile[,] beginnerGrid = Mother.GetTestGrid(GridSize.Beginner);

            _sut.CascadeAll(beginnerGrid);

            _fakeTilePainter.Verify(x => x.PaintMineCount(It.IsAny<Tile[,]>(), 
                It.IsAny<int>(), 
                It.IsAny<int>()),
                Times.Exactly(81));
        }

        [Test]
        public void CascadeAll_Call_PaintMineCount_256Times_ForNormalSizeGrid()
        {
            Tile[,] beginnerGrid = Mother.GetTestGrid(GridSize.Normal);

            _sut.CascadeAll(beginnerGrid);

            _fakeTilePainter.Verify(x => x.PaintMineCount(It.IsAny<Tile[,]>(), 
                It.IsAny<int>(), 
                It.IsAny<int>()),
                Times.Exactly(256));
        }

        [Test]
        public void CascadeAll_Call_PaintMineCount_400Times_ForAdvancedSizeGrid()
        {
            Tile[,] beginnerGrid = Mother.GetTestGrid(GridSize.Advanced);

            _sut.CascadeAll(beginnerGrid);

            _fakeTilePainter.Verify(x => x.PaintMineCount(It.IsAny<Tile[,]>(), 
                It.IsAny<int>(), 
                It.IsAny<int>()),
                Times.Exactly(400));
        }

        [Test]
        public void CascadeAll_Call_PaintMineCount_WithTheCorrectData()
        {
            _sut.CascadeAll(_grid1By1);

            _fakeTilePainter.Verify(
                x => x.PaintMineCount(It.Is<Tile[,]>(y => y == _grid1By1), 
                    It.IsAny<int>(), 
                    It.IsAny<int>()));
        }

        [TearDown]
        public void TearDown()
        {
            _fakeTilePainter = null;
            _grid1By1 = null;
            _grid5By5 = null;
            _sut = null;
        }
    }
}