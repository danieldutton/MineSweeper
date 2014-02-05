using MSweeper.GameModeFactory.Interfaces;
using MSweeper.GridTools.Interfaces;
using MSweeper.Model.Components;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MSweeper.GridTools
{
    public class GridPainter
    {
        private readonly IGridBuilder _emptyGridBuilder;

        private readonly IGridControlBuilder _gridControlBuilder;

        private readonly IGridMiner _gridMiner;


        public GridPainter(IGridBuilder emptyGridBuilder, IGridControlBuilder gridControlBuilder, IGridMiner gridMiner)
        {
            _emptyGridBuilder = emptyGridBuilder;
            _gridControlBuilder = gridControlBuilder;
            _gridMiner = gridMiner;
        }

        public void PaintGrid(IGameMode gameMode, Control control)
        {
            if(control == null) throw new ArgumentNullException("control");

            Tile[,] grid = _emptyGridBuilder.GetSquaredGrid(gameMode.GridSize);
            Tile[,] minedGrid = _gridMiner.MineTheGrid(grid, gameMode.DifficultyLevel, gameMode.GridSize);

            _gridControlBuilder.AddControlsToGrid(minedGrid, control, gameMode.GridSize);

            int formWidth = control.Width;
            int counter = (int) gameMode.GridSize;
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