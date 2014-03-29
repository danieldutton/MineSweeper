namespace Swinesweeper.GamePlay.Interfaces
{
    public interface ITilePainter
    {
        void PaintMine(Tile[,] grid, int x, int y);

        void PaintMineCount(Tile[,] grid, int x, int y);
    }
}
