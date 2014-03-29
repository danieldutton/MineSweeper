namespace Swinesweeper.GamePlay.Interfaces
{
    public interface ITileCascader
    {
        Tile[,] CascadeTile(Tile[,] grid, int x, int y);

        Tile[,] CascadeAll(Tile[,] grid);
    }
}
