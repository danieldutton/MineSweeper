//using NUnit.Framework;
//using Swinesweeper.GamePlay;
//using System.Drawing;
//using System.Linq;

//namespace Swinesweeper.UnitTests.GamePlay
//{
//    [TestFixture]
//    public class TileCascader_Should
//    {
//        #region CascadeAll

//        [Test]
//        public void CascadeAll_SetMineResourceImage_OnMinedTiles()
//        {
//            var grid = Mother.GetTiledGrid_10_by_10_With_5_Mines();
//            var tileCascader = new TileCascader();
//            var result = tileCascader.CascadeAll(grid);
//            var flat = result.Cast<Tile>().ToArray().Where((x, i) => i % 2 == 0);

//            // 5 mine image properties are not null
//            Assert.IsTrue(flat.All(x => x.Image != null));
//        }

//        [Test]
//        public void CascadeAll_ClearAllTiles_SetPropertIsClearToTrue()
//        {
//            var grid = Mother.GetTiledGrid_10_by_10_NoMines();
//            var tileCascader = new TileCascader();
//            var result = tileCascader.CascadeAll(grid);
//            var flat = result.Cast<Tile>().ToArray();

//            Assert.IsTrue(flat.All(x => x.IsCleared));
//        }

//        [Test]
//        public void CascadeAll_SetTileBackGroundColourTo_SlateGray()
//        {
//            var grid = Mother.GetTiledGrid_10_by_10_NoMines();
//            var tileCascader = new TileCascader();
//            var result = tileCascader.CascadeAll(grid);
//            var flat = result.Cast<Tile>().ToArray();

//            Assert.IsTrue(flat.All(x => x.BackColor == Color.SlateGray));
//        }

//        [Test]
//        public void CascadeAll_SetMineCountLabelLocationTo_2_2()
//        {
//            var grid = Mother.GetTiledGrid_10_by_10_NoMines();
//            var tileCascader = new TileCascader();
//            var result = tileCascader.CascadeAll(grid);
//            var flat = result.Cast<Tile>().ToArray();

//            Assert.IsTrue(flat.All(x => x.LblMineCount.Location == new Point(2, 2)));
//        }

//        [Test]
//        public void CascadeAll_SetMineCountLabelVisiblePropertyTo_True()
//        {
//            var grid = Mother.GetTiledGrid_10_by_10_NoMines();
//            var tileCascader = new TileCascader();
//            var result = tileCascader.CascadeAll(grid);
//            var flat = result.Cast<Tile>().ToArray();

//            Assert.IsTrue(flat.All(x => x.LblMineCount.Visible));
//        }

//        [Test]
//        public void CascadeAll_SetMineCountLabelForeColorPropertyTo_White()
//        {
//            var grid = Mother.GetTiledGrid_10_by_10_NoMines();
//            var tileCascader = new TileCascader();
//            var result = tileCascader.CascadeAll(grid);
//            var flat = result.Cast<Tile>().ToArray();

//            Assert.IsTrue(flat.All(x => x.LblMineCount.ForeColor == Color.White));
//        }

//        [Test]
//        public void CascadeAll_SetMineCountLabelBackColourPropertyTo_Transparent()
//        {
//            var grid = Mother.GetTiledGrid_10_by_10_NoMines();
//            var tileCascader = new TileCascader();
//            var result = tileCascader.CascadeAll(grid);
//            var flat = result.Cast<Tile>().ToArray();

//            Assert.IsTrue(flat.All(x => x.LblMineCount.BackColor == Color.Transparent));
//        }

//        #endregion
//    }
//}
