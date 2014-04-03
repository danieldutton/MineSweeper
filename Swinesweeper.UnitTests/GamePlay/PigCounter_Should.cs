using NUnit.Framework;
using Swinesweeper.GamePlay;
using System;

namespace Swinesweeper.UnitTests.GamePlay
{   
    //See testNotes.txt in project for further details
    
    [TestFixture]
    public class PigCounter_Should
    {
        private PigCounter _sut;

        private Tile[,] _testGrid;

        [SetUp]
        public void Init()
        {
            _sut = new PigCounter();
            _testGrid = Mother.GetTestGrid(5, 5);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CountPigs_ThrowAnArgumentNullExceptionIf_GridIsNull()
        {
            _sut.CountPigs(null);
        }

        #region Corners

        [Test]
        public void CountPigs_CountCorrectly_OneMine_TopLeftCorner_0_0()
        {
            _testGrid[0, 0] = new Tile { IsMined = true };
            const string expected = "1";
                       
            _sut.CountPigs(_testGrid);

            Assert.AreEqual(expected, _testGrid[0, 1].LblMineCount.Text);
            Assert.AreEqual(expected, _testGrid[1, 0].LblMineCount.Text);
            Assert.AreEqual(expected, _testGrid[1, 1].LblMineCount.Text);
        }

        [Test]
        public void CountPigs_CountCorrectly_OneMine_TopRightCorner_0_4()
        {
            _testGrid[0, 4] = new Tile { IsMined = true };
            const string expected = "1";

            _sut.CountPigs(_testGrid);

            Assert.AreEqual(expected, _testGrid[0, 3].LblMineCount.Text);
            Assert.AreEqual(expected, _testGrid[1, 3].LblMineCount.Text);
            Assert.AreEqual(expected, _testGrid[1, 4].LblMineCount.Text);
        }

        [Test]
        public void CountPigs_CountCorrectly_OneMine_BottomLeft_4_0()
        {
            _testGrid[4, 0] = new Tile { IsMined = true };
            const string expected = "1";

            _sut.CountPigs(_testGrid);

            Assert.AreEqual(expected, _testGrid[3, 0].LblMineCount.Text);
            Assert.AreEqual(expected, _testGrid[3, 1].LblMineCount.Text);
            Assert.AreEqual(expected, _testGrid[4, 1].LblMineCount.Text);
        }

        [Test]
        public void CountPigs_CountCorrectly_OneMine_BottomRight_4_4()
        {
            _testGrid[4, 4] = new Tile { IsMined = true };
            const string expected = "1";

            _sut.CountPigs(_testGrid);

            Assert.AreEqual(expected, _testGrid[3, 3].LblMineCount.Text);
            Assert.AreEqual(expected, _testGrid[3, 4].LblMineCount.Text);
            Assert.AreEqual(expected, _testGrid[4, 3].LblMineCount.Text);
        }

        #endregion


        #region Count Upwards

        [Test]
        public void CountPigs_CountCorrectly_1_Mine()
        {
            _testGrid[0, 0] = new Tile { IsMined = true };
            const string expected = "1";

            _sut.CountPigs(_testGrid);

            Assert.AreEqual(expected, _testGrid[0, 1].LblMineCount.Text);
            Assert.AreEqual(expected, _testGrid[1, 0].LblMineCount.Text);
            Assert.AreEqual(expected, _testGrid[1, 1].LblMineCount.Text);    
        }

        [Test]
        public void CountPigs_CountCorrectly_2_Mines()
        {
            _testGrid[0, 0] = new Tile { IsMined = true };
            _testGrid[0, 1] = new Tile { IsMined = true };

            const string expected = "2";

            _sut.CountPigs(_testGrid);

            Assert.AreEqual(expected, _testGrid[1, 0].LblMineCount.Text);
            Assert.AreEqual(expected, _testGrid[1, 1].LblMineCount.Text);
        }

        [Test]
        public void CountPigs_CountCorrectly_3_Mines()
        {
            _testGrid[0, 0] = new Tile { IsMined = true };
            _testGrid[0, 1] = new Tile { IsMined = true };
            _testGrid[0, 2] = new Tile { IsMined = true };

            const string expected = "3";

            _sut.CountPigs(_testGrid);

            Assert.AreEqual(expected, _testGrid[1, 1].LblMineCount.Text);
        }

        [Test]
        public void CountPigs_CountCorrectly_4_Mines()
        {
            _testGrid[0, 0] = new Tile { IsMined = true };
            _testGrid[0, 1] = new Tile { IsMined = true };
            _testGrid[0, 2] = new Tile { IsMined = true };
            _testGrid[1, 0] = new Tile { IsMined = true };

            const string expected = "4";

            _sut.CountPigs(_testGrid);

            Assert.AreEqual(expected, _testGrid[1, 1].LblMineCount.Text);
        }

        [Test]
        public void CountPigs_CountCorrectly_5_Mines()
        {
            _testGrid[0, 0] = new Tile { IsMined = true };
            _testGrid[0, 1] = new Tile { IsMined = true };
            _testGrid[0, 2] = new Tile { IsMined = true };
            _testGrid[1, 0] = new Tile { IsMined = true };
            _testGrid[2, 0] = new Tile { IsMined = true };

            const string expected = "5";

            _sut.CountPigs(_testGrid);

            Assert.AreEqual(expected, _testGrid[1, 1].LblMineCount.Text);
        }

        [Test]
        public void CountPigs_CountCorrectly_6_Mines()
        {
            _testGrid[0, 0] = new Tile { IsMined = true };
            _testGrid[0, 1] = new Tile { IsMined = true };
            _testGrid[0, 2] = new Tile { IsMined = true };
            _testGrid[1, 0] = new Tile { IsMined = true };
            _testGrid[2, 0] = new Tile { IsMined = true };
            _testGrid[2, 1] = new Tile { IsMined = true };

            const string expected = "6";

            _sut.CountPigs(_testGrid);

            Assert.AreEqual(expected, _testGrid[1, 1].LblMineCount.Text);
        }

        [Test]
        public void CountPigs_CountCorrectly_7_Mines()
        {
            _testGrid[0, 0] = new Tile { IsMined = true };
            _testGrid[0, 1] = new Tile { IsMined = true };
            _testGrid[0, 2] = new Tile { IsMined = true };
            _testGrid[1, 0] = new Tile { IsMined = true };
            _testGrid[2, 0] = new Tile { IsMined = true };
            _testGrid[2, 1] = new Tile { IsMined = true };
            _testGrid[2, 2] = new Tile { IsMined = true };

            const string expected = "7";

            _sut.CountPigs(_testGrid);

            Assert.AreEqual(expected, _testGrid[1, 1].LblMineCount.Text);
        }

        [Test]
        public void CountPigs_CountCorrectly_8_Mines()
        {
            _testGrid[0, 0] = new Tile { IsMined = true };
            _testGrid[0, 1] = new Tile { IsMined = true };
            _testGrid[0, 2] = new Tile { IsMined = true };
            _testGrid[1, 0] = new Tile { IsMined = true };
            _testGrid[2, 0] = new Tile { IsMined = true };
            _testGrid[2, 1] = new Tile { IsMined = true };
            _testGrid[2, 2] = new Tile { IsMined = true };
            _testGrid[1, 2] = new Tile { IsMined = true };

            const string expected = "8";

            _sut.CountPigs(_testGrid);

            Assert.AreEqual(expected, _testGrid[1, 1].LblMineCount.Text);
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
            _sut = null;
            _testGrid = null;
        }
    }
}
