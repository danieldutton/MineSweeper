namespace MineSweeper.Model
{
    public interface ITile
    {
        bool IsMined { get; set; }
        bool IsFlagged { get; set; }
        bool HasBeenSelected { get; set; }
        int GridPositonX { get; set; }
        int GridPositionY { get; set; }

        void SelectTile();
        void FlagTile();
        void UnFlagTile();
    }
}
