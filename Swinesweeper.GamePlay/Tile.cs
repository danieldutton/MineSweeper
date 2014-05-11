using Swinesweeper.GamePlay.EventArg;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Swinesweeper.GamePlay
{
    public class Tile : PictureBox
    {
        #region Events

        public static event EventHandler<MineHitEventArgs> MineHit;

        public static event EventHandler<TileClearEventArgs> TileClear;

        public static event EventHandler<EventArgs> FlagPlaced;

        public static event EventHandler<EventArgs> FlagRemoved;

        #endregion

        #region Instance Var(s)

        public static Tile[,] ParentGrid { get; set; }

        public int XPos { get; set; }

        public int YPos { get; set; }

        public bool IsMined { get; set; }

        public bool IsFlagged { get; set; }

        public bool IsCleared { get; set; }

        private int _rightClickCount = 1;

        public static int FlagCount { get; set; }

        public static int MineCount { get; set; }

        public static int TileCount { get; set; }

        public static int CorrectFlagCount { get; set; }

        public Label LblMineCount = new Label();

        #endregion

        protected override void OnClick(EventArgs e)
        {
            var mouseEvent = e as MouseEventArgs;
            if (mouseEvent == null) return;

            if (mouseEvent.Button == MouseButtons.Left)
                SelectTile();

            if (mouseEvent.Button == MouseButtons.Right)
            {
                if (ClickCountOneAndNotFlagged())
                    FlagTile();

                else if (ClickCountTwoAndIsFlagged())
                    UnFlagTile();
            }

            base.OnClick(e);
        }

        private void SelectTile()
        {
            if (MinedAndNotFlagged())
                OnMineHit(new MineHitEventArgs(ParentGrid));

            if (NotClearedAndNotFlagged())
                RemoveTile();
        }

        private void RemoveTile()
        {
            IsCleared = true;
            TileCount--;
            OnTileClear(new TileClearEventArgs(ParentGrid, XPos, YPos));
        }

        private void FlagTile()
        {
            if (NotClearedAndNotFlagged())
            {
                if (SpareFlagsRemain())
                {
                    _rightClickCount = 2;

                    BackColor = Color.YellowGreen;
                    IsFlagged = true;
                    FlagCount--;

                    if (IsMined)
                        CorrectFlagCount++;

                    OnFlagPlaced();
                }
            }
        }

        private void UnFlagTile()
        {
            if (NotClearedAndIsFlagged())
            {
                _rightClickCount = 1;

                BackColor = Color.SaddleBrown;
                IsFlagged = false;
                FlagCount++;

                if (IsMined)
                    CorrectFlagCount--;

                OnFlagRemoved();
            }
        }

        private bool ClickCountOneAndNotFlagged()
        {
            return _rightClickCount == 1 && !IsFlagged;
        }

        private bool ClickCountTwoAndIsFlagged()
        {
            return _rightClickCount == 2 && IsFlagged;
        }

        private bool NotClearedAndIsFlagged()
        {
            return IsCleared == false && IsFlagged;
        }

        private bool NotClearedAndNotFlagged()
        {
            return !IsCleared && !IsFlagged;
        }

        private bool MinedAndNotFlagged()
        {
            return IsMined && !IsFlagged;
        }

        private bool SpareFlagsRemain()
        {
            return FlagCount != 0;
        }

        #region Event Invocators

        protected static void OnMineHit(MineHitEventArgs e)
        {
            EventHandler<MineHitEventArgs> handler = MineHit;
            if (handler != null) handler(null, e);
        }

        protected static void OnTileClear(TileClearEventArgs e)
        {
            EventHandler<TileClearEventArgs> handler = TileClear;
            if (handler != null) handler(null, e);
        }

        protected static void OnFlagPlaced()
        {
            EventHandler<EventArgs> handler = FlagPlaced;
            if (handler != null) handler(null, EventArgs.Empty);
        }

        protected static void OnFlagRemoved()
        {
            EventHandler<EventArgs> handler = FlagRemoved;
            if (handler != null) handler(null, EventArgs.Empty);
        }

        #endregion
    }
}