using Moq;
using NUnit.Framework;
using Swinesweeper.GameModeFactory;
using Swinesweeper.GridBuilder;
using Swinesweeper.Utilities.Interfaces;
using System;

namespace Swinesweeper.UnitTests.GridBuilder
{
    [TestFixture]
    public class GridMiner_Should
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MineTheGrid_ThrowAnArgumentNullException_IfGridParamIsNull()
        {
            var fakeNumberGenerator = new Mock<IRandomNumberGenerator>();
            var sut = new GridMiner(fakeNumberGenerator.Object);

            sut.MineTheGrid(null, DifficultyLevel.Beginner, GridSize.Beginner);
        }
    }
}
