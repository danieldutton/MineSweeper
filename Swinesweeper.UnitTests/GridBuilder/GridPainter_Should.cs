using Moq;
using NUnit.Framework;
using Swinesweeper.GameModeFactory;
using Swinesweeper.GameModeFactory.GameModes;
using Swinesweeper.GamePlay;
using Swinesweeper.GamePlay.Interfaces;
using Swinesweeper.GridBuilder;
using Swinesweeper.GridBuilder.Interfaces;
using System;

namespace Swinesweeper.UnitTests.GridBuilder
{
    [TestFixture]
    public class GridPainter_Should
    {
        private Mock<IGridBuilder> _fakeGridBuilder;

        private Mock<IGridControlBuilder> _fakeGridControlBuilder;

        private Mock<IGridMiner> _fakeGridMiner;

        private Mock<ITileCounter> _fakePigCounter;

        private GridPainter _sut;

        [SetUp]
        public void Init()
        {
            _fakeGridBuilder = new Mock<IGridBuilder>();
            _fakeGridControlBuilder = new Mock<IGridControlBuilder>();
            _fakeGridMiner = new Mock<IGridMiner>();
            _fakePigCounter = new Mock<ITileCounter>();

            _sut = new GridPainter(_fakeGridBuilder.Object, _fakeGridControlBuilder.Object,
                _fakeGridMiner.Object, _fakePigCounter.Object);
        }

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void PaintGrid_ThrowAnArgumentNullExceptionIf_ControlParamIsNull()
        {
            var normalStub = new Normal();
            _sut.PaintGrid(normalStub, null);
        }

        [Test]
        public void PaintGrid_CallGetSquaredGrid_ExactlyOnce()
        {
            var beginnerStub = new Beginner();
            Tile[,] beginnerGrid = Mother.GetTestGrid(GridSize.Beginner);

            _fakeGridBuilder.Setup(x => x.GetSquaredGrid(It.IsAny<GridSize>(),
                It.IsAny<DifficultyLevel>()))
                .Returns(() => beginnerGrid);

            _fakeGridMiner.Setup(
                x => x.MineTheGrid(It.IsAny<Tile[,]>(),
                    It.IsAny<DifficultyLevel>(),
                    It.IsAny<GridSize>()))
                .Returns(() => beginnerGrid);

            _sut.PaintGrid(beginnerStub, new Tile());

            _fakeGridBuilder.Verify(x => x.GetSquaredGrid(It.IsAny<GridSize>(),
                It.IsAny<DifficultyLevel>()), Times.Once());
        }

        [Test]
        public void PaintGrid_CallGetSquaredGrid_WithCorrectData()
        {
            var beginnerStub = new Beginner();
            Tile[,] beginnerGrid = Mother.GetTestGrid(GridSize.Beginner);

            _fakeGridBuilder.Setup(x => x.GetSquaredGrid(It.IsAny<GridSize>(),
                It.IsAny<DifficultyLevel>()))
                .Returns(() => beginnerGrid);

            _fakeGridMiner.Setup(
                x => x.MineTheGrid(It.IsAny<Tile[,]>(),
                    It.IsAny<DifficultyLevel>(),
                    It.IsAny<GridSize>()))
                .Returns(() => beginnerGrid);

            _sut.PaintGrid(beginnerStub, new Tile());

            _fakeGridBuilder.Verify(x => x.GetSquaredGrid(It.Is<GridSize>(y => y == GridSize.Beginner),
                It.Is<DifficultyLevel>(y => y == DifficultyLevel.Beginner)));
        }

        [Test]
        public void PaintGrid_CallMineTheGrid_ExactlyOnce()
        {
            var beginnerStub = new Beginner();
            Tile[,] beginnerGrid = Mother.GetTestGrid(GridSize.Beginner);

            _fakeGridBuilder.Setup(x => x.GetSquaredGrid(It.IsAny<GridSize>(),
                It.IsAny<DifficultyLevel>()))
                .Returns(() => beginnerGrid);

            _fakeGridMiner.Setup(
                x => x.MineTheGrid(It.IsAny<Tile[,]>(),
                    It.IsAny<DifficultyLevel>(),
                    It.IsAny<GridSize>()))
                .Returns(() => beginnerGrid);

            _sut.PaintGrid(beginnerStub, new Tile());

            _fakeGridMiner.Verify(x => x.MineTheGrid(It.IsAny<Tile[,]>(),
                It.IsAny<DifficultyLevel>(),
                It.IsAny<GridSize>()),
                Times.Once());
        }

    }
}

  