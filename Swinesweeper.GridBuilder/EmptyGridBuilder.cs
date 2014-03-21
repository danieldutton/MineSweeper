using Swinesweeper.GameModeFactory.Settings;
using Swinesweeper.GamePlay;
using Swinesweeper.GridBuilder.Interfaces;
using System;

namespace Swinesweeper.GridBuilder
{
    public class EmptyGridBuilder : IGridBuilder
    {
        public Tile[,] GetSquaredGrid(GridSize gridSize, DifficultyLevel difficultyLevel)
        {
            if(!Enum.IsDefined(typeof(GridSize), gridSize))
                gridSize = GridSize.Beginner;
           
            var tileGrid = new Tile[(int) gridSize, (int)gridSize];

            Tile.FlagCount = (int) difficultyLevel;
            Tile.MineCount = (int) difficultyLevel;
            Tile.TileCount = ((int) gridSize*(int) gridSize);

            int counter = tileGrid.Length / (int)gridSize;

            for (int i = 0; i < counter; i++)
            {
                for (int j = 0; j < counter; j++)
                {
                    var tile = new Tile
                        {
                            Grid = tileGrid,    //stop this bloat make it static
                            GridPositonX = i,
                            GridPositionY = j,
                        };
                    tileGrid[i, j] = tile;
                }
            }
            return tileGrid;
        }
    }
}
