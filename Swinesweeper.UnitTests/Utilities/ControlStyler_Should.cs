using NUnit.Framework;
using Swinesweeper.Utilities;
using System;
using System.Windows.Forms;

namespace Swinesweeper.UnitTests.Utilities
{
    [TestFixture]
    public class ControlStyler_Should
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ColourBackground_ThrowArgumentNullException_IfControlIsNull()
        {
            ControlStyler.ColourBackground(null);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ColourBackground_ThrowArgumentNullException_IfDefaultColourIsNull()
        {
            ControlStyler.ColourBackground(new Control(), null);
        }
    }
}
