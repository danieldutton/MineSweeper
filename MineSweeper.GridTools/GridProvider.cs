using MineSweeper.GameModeFactory.Interfaces;
using MineSweeper.GridTools.Interfaces;
using MineSweeper.Model.Components;
using System.Drawing;
using System.Windows.Forms;

namespace MineSweeper.GridTools
{
    public class GridProvider 
    {
        private readonly IGridGenerator _gridGenerator;

        private readonly IGridMiner _gridMiner;


        public GridProvider(IGridGenerator gridGenerator, IGridMiner gridMiner)
        {
            _gridGenerator = gridGenerator;
            _gridMiner = gridMiner;
        }

        public void DrawGrid(IGameMode gameMode, Control control)
        {
            Tile[,] grid = _gridGenerator.GetSquaredGrid(gameMode.GridSize);
            Tile[,] minedGrid = _gridMiner.MineTheGrid(grid, gameMode.DifficultyLevel, gameMode.GridSize);

            GridManager.AddControlsToGrid(minedGrid, control, gameMode.GridSize);

            int formWidth = control.Width; //for border size - use panel
            int counter = (int)gameMode.GridSize;
            int x = 0;
            int y = 0;

            for (int i = 0; i < counter; i++)
            {
                for (int j = 0; j < counter; j++)
                {
                    minedGrid[i, j].BackColor = Color.IndianRed;
                    minedGrid[i, j].Width = 15;
                    minedGrid[i, j].Height = 15;
                    minedGrid[i, j].Location = new Point(x, y);

                    x += 16;

                    if (x > formWidth)
                    {
                        y += 16;
                        x = 0;
                    }
                    minedGrid[i, j] = grid[i, j];
                }
            }
        }
    }
}
