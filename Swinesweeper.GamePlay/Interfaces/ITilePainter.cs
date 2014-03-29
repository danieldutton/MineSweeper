namespace Swinesweeper.GamePlay.Interfaces
{
    public interface ITilePainter
    {
        void DisplayMineCount(Tile[,] grid, int x, int y);
    }
}
