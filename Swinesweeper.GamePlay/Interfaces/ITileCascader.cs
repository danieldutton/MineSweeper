namespace Swinesweeper.GamePlay.Interfaces
{
    public interface ITileCascader
    {
        void CascadeTile(Tile[,] grid, int x, int y);

        void CascadeAll(Tile[,] grid);
    }
}
