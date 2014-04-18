using NUnit.Framework;
using Swinesweeper.GameModeFactory;
using Swinesweeper.GamePlay;
using Swinesweeper.GridBuilder;
using System;
using System.Windows.Forms;

namespace Swinesweeper.UnitTests.GridBuilder
{
    [TestFixture]
    public class GridControlBuilder_Should
    {
        private GridControlBuilder _sut;

        private Tile[,] _gridBeginner;

        private Tile[,] _gridNormal;

        private Tile[,] _gridAdvanced;

        private Control _controlStub;

        [SetUp]
        public void Init()
        {
            _sut = new GridControlBuilder();
            _gridBeginner = Mother.GetTestGrid(GridSize.Beginner);
            _gridNormal = Mother.GetTestGrid(GridSize.Normal);
            _gridAdvanced = Mother.GetTestGrid(GridSize.Advanced);
            _controlStub = new Control();
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddControlsToGrid_ThrowAnArgumentNullException_IfControlsToAdd_IsNull()
        {
            _gridAdvanced = null;
            
            _sut.AddControlsToGrid(_gridAdvanced, _controlStub, GridSize.Advanced);    
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddControlsToGrid_ThrowAnArgumentNullExceptionIf_ControlToPopulate_IsNull()
        {
            _sut.AddControlsToGrid(_gridAdvanced, null, GridSize.Advanced);
        }

        [Test]
        public void AddControlsToGrid_ReturnABeginnerGrid_IfGridSizeParam_IsUndefined()
        {
            Control result = _sut.AddControlsToGrid(_gridAdvanced, _controlStub, new GridSize());
            
            Assert.AreEqual(81, result.Controls.Count);
        }

        [Test]
        public void AddControlsToGrid_ReturnAControl_With81_ControlItems_ForGridSizeBeginner()
        {
            Control result = _sut.AddControlsToGrid(_gridBeginner, _controlStub, GridSize.Beginner);

            Assert.AreEqual(81, result.Controls.Count);    
        }

        [Test]
        public void AddControlsToGrid_ReturnAControl_With256_ControlItemsForGridSizeNormal()
        {
            Control result = _sut.AddControlsToGrid(_gridNormal, _controlStub, GridSize.Normal);

            Assert.AreEqual(256, result.Controls.Count);
        }

        [Test]
        public void AddControlsToGrid_ReturnAControl_With400_ControlItems_ForGridSizeAdvanced()
        {
            Control result = _sut.AddControlsToGrid(_gridAdvanced, _controlStub, GridSize.Advanced);

            Assert.AreEqual(400, result.Controls.Count);
        }

        [Test]
        public void AddControlsToGrid_ReturnAPopulatedControl_LessAnyNullTiles_Beginner()
        {
            _gridBeginner[0, 0] = null;
            _gridBeginner[1, 0] = null;
            _gridBeginner[2, 0] = null;
            _gridBeginner[3, 0] = null;
            
            Control result = _sut.AddControlsToGrid(_gridBeginner, _controlStub, GridSize.Beginner);

            Assert.AreEqual(77, result.Controls.Count);    
        }

        [Test]
        public void AddControlsToGrid_ReturnAPopulatedControl_LessAnyNullTiles_Normal()
        {
            _gridNormal[0, 0] = null;
            _gridNormal[1, 0] = null;
            _gridNormal[2, 0] = null;
            _gridNormal[3, 0] = null;

            Control result = _sut.AddControlsToGrid(_gridNormal, _controlStub, GridSize.Normal);

            Assert.AreEqual(252, result.Controls.Count);
        }

        [Test]
        public void AddControlsToGrid_ReturnAPopulatedControl_LessAnyNullTiles_Advanced()
        {
            _gridAdvanced[0, 0] = null;
            _gridAdvanced[1, 0] = null;
            _gridAdvanced[2, 0] = null;
            _gridAdvanced[3, 0] = null;

            Control result = _sut.AddControlsToGrid(_gridAdvanced, _controlStub, GridSize.Advanced);

            Assert.AreEqual(396, result.Controls.Count);
        }

        [TearDown]
        public void TearDown()
        {
            _sut = null;
            _gridBeginner = null;
            _gridNormal = null;
            _gridAdvanced = null;
            _controlStub = null;
        }
    }
}
