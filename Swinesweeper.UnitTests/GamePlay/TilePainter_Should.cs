using NUnit.Framework;
using Swinesweeper.GamePlay;
using System.Drawing;
using System.Windows.Forms;

namespace Swinesweeper.UnitTests.GamePlay
{
    [TestFixture]
    public class TilePainter_Should
    {
        private Tile[,] _grid;

        private TilePainter _sut;

        private const int XPos = 0;

        private const int YPos = 0;

        [SetUp]
        public void Init()
        {
            _grid = new Tile[1,1];
            _grid[XPos, YPos] = new Tile();
            _sut = new TilePainter();
        }

        [Test]
        public void PaintMine_InitImagePropertyFromResources()
        {
            _sut.PaintMine(_grid, XPos, YPos);
            
            Assert.IsTrue(_grid[XPos, YPos].Image != null);    
        } 

        [Test]
        public void PaintMineCount_SetTileProperty_BackColor_To_SlateGray()
        {
            _sut.PaintMineCount(_grid, XPos, YPos);
            
            Assert.AreEqual(_grid[XPos, YPos].BackColor, Color.SlateGray);
        }

        [Test]
        public void PaintMineCount_SetTileProperty_IsCleared_To_True()
        {
            _sut.PaintMineCount(_grid, XPos, YPos);
            
            Assert.IsTrue(_grid[XPos, YPos].IsCleared);
        }

        [Test]
        public void PaintMineCount_SetProperty_LblMineCount_Location_To_2_2()
        {
            _sut.PaintMineCount(_grid, XPos, YPos);
            
            Assert.AreEqual(_grid[XPos, YPos].LblMineCount.Location, new Point(2, 2));
        }

        [Test]
        public void PaintMineCount_SetProperty_LblMineCount_Visible_To_True()
        {
            _sut.PaintMineCount(_grid, XPos, YPos);
            
            Assert.IsTrue(_grid[XPos, YPos].LblMineCount.Visible);
        }

        [Test]
        public void PaintMineCount_SetProperty_LblMineCount_ForeColor_To_White()
        {
            _sut.PaintMineCount(_grid, XPos, YPos);
            
            Assert.AreEqual(_grid[XPos, YPos].LblMineCount.ForeColor, Color.White);
        }

        [Test]
        public void PaintMineCount_SetProperty_LblMineCount_BackColor_To_Transparent()
        {
            _sut.PaintMineCount(_grid, XPos, YPos);
            
            Assert.AreEqual(_grid[XPos, YPos].LblMineCount.BackColor, Color.Transparent);
        }

        [Test]
        public void PaintMineCount_AddLabelToGridControlsProperty()
        {
            _sut.PaintMineCount(_grid, XPos, YPos);
            
            Assert.IsInstanceOf<Label>(_grid[XPos, YPos].Controls[0]);
            Assert.AreEqual(_grid[XPos, YPos].Controls[0].BackColor, Color.Transparent);
        }

        [TearDown]
        public void TearDown()
        {
            _grid = null;
            _sut = null;
        }
    }
}
