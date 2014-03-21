using Moq;
using NUnit.Framework;
using Swinesweeper.GameModeFactory.GameModes;
using Swinesweeper.GridTools;
using Swinesweeper.GridTools.Interfaces;
using System;
using System.Windows.Forms;

namespace Swinesweeper._UnitTests.GridTools
{
    [TestFixture]
    public class GridPainter_Should
    {
        private Mock<IGridBuilder> _fakeGridBuilder;

        private Mock<IGridControlBuilder> _fakeGridControlBuilder;

        private Mock<IGridMiner> _fakeGridMiner;

        private GridPainter _sut;

        [SetUp]
        public void Init()
        {
            _fakeGridBuilder = new Mock<IGridBuilder>();
            _fakeGridControlBuilder = new Mock<IGridControlBuilder>();
            _fakeGridMiner = new Mock<IGridMiner>();

            _sut = new GridPainter(_fakeGridBuilder.Object, _fakeGridControlBuilder.Object, _fakeGridMiner.Object);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PaintGrid_ThrowAnArgumentNullExceptionIf_ControlParamIsNull()
        {
            var normalStub = new Normal();
            _sut.PaintGrid(normalStub, null);
        }

        [Test]
        public void PaintGrid_CallMethodGetSquaredGridExactlyOnce()
        {
            var normal = new Normal();
            _sut.PaintGrid(normal, new Control());   
        }

        [Test]
        public void PaintGrid_CallMethodGetSquaredGridWithCorrectData()
        {

        }

        [Test]
        public void PaintGrid_CallMethodMineTheGridExactlyOnce()
        {
            
        }

        [Test]
        public void PaintGrid_CallMethodMineTheGridWithCorrectData()
        {

        }

        [Test]
        public void PaintGrid_CallMethodAddControlsToGridExactlyOnce()
        {
            
        }

        [Test]
        public void PaintGrid_CallMethodAddControlsToGridWithCorrectData()
        {

        }
    }
}
