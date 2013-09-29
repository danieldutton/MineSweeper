namespace MineSweeper.Model.Interfaces
{
    public interface ITile
    {
        bool IsMined { get; set; }
        bool IsFlagged { get; set; }
        bool IsSelected { get; set; }
        int GridPositonX { get; set; }
        int GridPositionY { get; set; }

        void SelectTile();
        void AddFlagToTile();
        void RemoveFlagFromTile();
    }
}
