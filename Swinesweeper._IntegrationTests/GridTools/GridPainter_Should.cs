using NUnit.Framework;
using Swinesweeper.GridTools;
using Swinesweeper.GridTools.Interfaces;
using Swinesweeper.Utilities;
using Swinesweeper.Utilities.Interfaces;

namespace Swinesweeper._IntegrationTests.GridTools
{
    [TestFixture]
    public class GridPainter_Should
    {
        private IGridMiner _gridMiner;

        private IRandomNumberGenerator _randomNumberGenerator;

        private IGridBuilder _emptyGridBuilder;

        private IGridControlBuilder _gridControlBuilder;

        private GridPainter _gridPainter;

        [SetUp]
        public void Init()
        {
            _randomNumberGenerator = new RandomNumberGenerator();
            _gridMiner = new GridMiner(_randomNumberGenerator);
            _emptyGridBuilder = new EmptyGridBuilder();
            _gridControlBuilder = new GridControlBuilder();
            _gridPainter = new GridPainter(_emptyGridBuilder, _gridControlBuilder, _gridMiner);
        }

        [TearDown]
        public void TearDown()
        {
            
        }
    }
}
