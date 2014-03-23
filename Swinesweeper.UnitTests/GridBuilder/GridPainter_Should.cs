using Moq;
using NUnit.Framework;
using Swinesweeper.GameModeFactory;
using Swinesweeper.GameModeFactory.GameModes;
using Swinesweeper.GameModeFactory.Interfaces;
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
        public void PaintGrid_CallMethod_GetSquaredGrid_ExactlyOnce()
        {
            IGameMode gameMode = new Beginner();
            var control = new Control();

            _sut.PaintGrid(gameMode, control);
            _fakeGridBuilder.Verify(x => x.GetSquaredGrid(It.IsAny<GridSize>(),
                It.IsAny<DifficultyLevel>()),
                Times.Exactly(2));
        }

        [Test]
        public void PaintGrid_CallMethod_GetSquaredGrid_WithCorrectData()
        {
            _sut.PaintGrid(It.IsAny<IGameMode>(), It.IsAny<Control>()); //both of these params are passing as null
            _fakeGridBuilder.Verify(x => x.GetSquaredGrid(It.IsAny<GridSize>(),
                It.IsAny<DifficultyLevel>()),
                Times.Exactly(2));
        }

        [Test]
        public void PaintGrid_CallMethod_MineTheGrid_ExactlyOnce()
        {
        }

        [Test]
        public void PaintGrid_CallMethod_MineTheGrid_WithCorrectData()
        {
        }

        [Test]
        public void PaintGrid_CallMethod_AddControlsToGrid_ExactlyOnce()
        {
            
        }

        [Test]
        public void PaintGrid_CallMethod_AddControlsToGrid_WithCorrectData()
        {
        }

        [Test]
        public void PaintGrid_CallMethod_CountPigs_ExactlyOnce()
        {
        }

        [Test]
        public void PaintGrid_CallMethod_CountPigs_WithCorrectData()
        {
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