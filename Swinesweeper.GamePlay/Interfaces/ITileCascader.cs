namespace Swinesweeper.GamePlay.Interfaces
{
    public interface ITileCascader
    {
        void CascadeTile(Tile[,] grid, int x, int y);

        Tile[,] CascadeAll(Tile[,] grid);
    }
}
