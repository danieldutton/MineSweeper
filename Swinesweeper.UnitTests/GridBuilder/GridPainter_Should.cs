using Moq;
using NUnit.Framework;
using Swinesweeper.GameModeFactory;
using Swinesweeper.GameModeFactory.GameModes;
using Swinesweeper.GamePlay;
using Swinesweeper.GamePlay.Interfaces;
using Swinesweeper.GridBuilder;
using Swinesweeper.GridBuilder.Interfaces;
using System;
using System.Windows.Forms;

namespace Swinesweeper.UnitTests.GridBuilder
{
    [TestFixture]
    public class GridPainter_Should
    {
        private Mock<IGridBuilder> _fakeGridBuilder;

        private Mock<IGridControlBuilder> _fakeGridControlBuilder;

        private Mock<IGridMiner> _fakeGridMiner;

        private Mock<IPigCounter> _fakePigCounter;

        private GridPainter _sut;

        [SetUp]
        public void Init()
        {
            _fakeGridBuilder = new Mock<IGridBuilder>();
            _fakeGridControlBuilder = new Mock<IGridControlBuilder>();
            _fakeGridMiner = new Mock<IGridMiner>();
            _fakePigCounter = new Mock<IPigCounter>();

            _sut = new GridPainter(_fakeGridBuilder.Object, _fakeGridControlBuilder.Object,
                                   _fakeGridMiner.Object, _fakePigCounter.Object);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PaintGrid_ThrowAnArgumentNullExceptionIf_ControlParamIsNull()
        {
            var normalStub = new Normal();
            _sut.PaintGrid(normalStub, null);
        }

        [Test]
        public void PaintGrid_CallGetSquaredGrid_ExactlyOnce()
        {
            var beginnerStub = new Beginner();
            _sut.PaintGrid(beginnerStub, new Control());

            _fakeGridBuilder.Verify(x => x.GetSquaredGrid(It.IsAny<GridSize>(), 
                It.IsAny<DifficultyLevel>()), 
                Times.Exactly(2));
        }

        [Test]
        public void PaintGrid_CallGetSquaredGrid_WithCorrectData()
        {
            var beginnerStub = new Beginner();
            _sut.PaintGrid(beginnerStub, new Control());
            _fakeGridBuilder.Setup(x => x.GetSquaredGrid(It.IsAny<GridSize>(), It.IsAny<DifficultyLevel>()))
                .Returns(It.IsAny<Tile[,]>);

            _fakeGridBuilder.Verify(x => x.GetSquaredGrid(It.Is<GridSize>(y => y == GridSize.Beginner),
                It.Is<DifficultyLevel>(y => y == DifficultyLevel.Beginner)),
                Times.Exactly(2));   
        }


        [TearDown]
        public void TearDown()
        {
            _fakeGridBuilder = null;
            _fakeGridControlBuilder = null;
            _fakeGridMiner = null;
            _fakePigCounter = null;
            _sut = null;
        }
    }
}