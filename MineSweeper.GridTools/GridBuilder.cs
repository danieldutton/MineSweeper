using MineSweeper.GridTools.Interfaces;
using MineSweeper.Model.Components;
using MineSweeper.Settings;
using System;


namespace MineSweeper.GridTools
{
    public class GridBuilder : IGridGenerator
    {
        public Tile[,] GetSquaredGrid(GridSize gridSize)
        {
            if(!Enum.IsDefined(typeof(GridSize), gridSize))
                gridSize = GridSize.Beginner;
           
            var tileGrid = new Tile[(int) gridSize, (int)gridSize];

            int counter = tileGrid.Length / (int)gridSize;

            for (int i = 0; i < counter; i++)
            {
                for (int j = 0; j < counter; j++)
                {
                    var tile = new Tile
                        {
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
