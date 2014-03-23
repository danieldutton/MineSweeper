namespace Swinesweeper.GamePlay.Interfaces
{
    public interface ITile
    {
        bool IsMined { get; set; }
        bool IsFlagged { get; set; }
        bool IsCleared { get; set; }
        int GridPositonX { get; set; }
        int GridPositionY { get; set; }

        void SelectTile();
        void AddFlag();
        void RemoveFlag();

        //add final methods to this interface
    }
}
