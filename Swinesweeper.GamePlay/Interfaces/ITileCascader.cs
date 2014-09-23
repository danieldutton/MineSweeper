namespace Swinesweeper.GamePlay.Interfaces
{
    public interface ITileCascader
    {
        Tile[,] CascadeSingle(Tile[,] grid, int x, int y);

        Tile[,] CascadeAll(Tile[,] grid);
    }
}
