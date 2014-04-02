using NUnit.Framework;
using Swinesweeper.GamePlay;
using System;

namespace Swinesweeper.UnitTests.GamePlay
{
    [TestFixture]
    public class PigCounter_Should
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CountPigs_ThrowAnArgumentNullExceptionIf_GridIsNull()
        {
            var sut = new PigCounter();
            sut.CountPigs(null);
        }
    }
}
