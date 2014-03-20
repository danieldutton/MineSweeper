namespace MSweeper.Model.Interfaces
{
    public interface ITile
    {
        bool IsMined { get; set; }
        bool IsFlagged { get; set; }
        bool IsCleared { get; set; }
        int GridPositonX { get; set; }
        int GridPositionY { get; set; }

        void SelectTile();
        void AddFlagToTile();
        void RemoveFlagFromTile();
    }
}
