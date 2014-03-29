using NUnit.Framework;
using Swinesweeper.GamePlay;
using Swinesweeper.GamePlay.Interfaces;
using Swinesweeper.GridBuilder;
using Swinesweeper.GridBuilder.Interfaces;
using Swinesweeper.Utilities;
using Swinesweeper.Utilities.Interfaces;

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

        private GridPainter _gridPainter;

        [SetUp]
        public void Init()
        {
            _randomNumberGenerator = new RandomNumberGenerator();
            _gridMiner = new GridMiner(_randomNumberGenerator);
            _emptyGridBuilder = new EmptyGridBuilder();
            _gridControlBuilder = new GridControlBuilder();
            _pigCounter = new PigCounter();
            _gridPainter = new GridPainter(_emptyGridBuilder, _gridControlBuilder, _gridMiner, _pigCounter);
        }

        [Test]
        public void PaintGrid()
        {
            
        }

        [TearDown]
        public void TearDown()
        {
            _gridMiner = null;
            _randomNumberGenerator = null;
            _emptyGridBuilder = null;
            _gridControlBuilder = null;
            _pigCounter = null;
            _gridPainter = null;
        }
    }
}
