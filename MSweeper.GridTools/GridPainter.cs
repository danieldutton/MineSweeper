using MSweeper.GameModeFactory.Interfaces;
using MSweeper.GridTools.Interfaces;
using MSweeper.GridTools.Properties;
using MSweeper.Model;
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

                    if (minedGrid[i, j].IsMined)
                        minedGrid[i, j].Image = Resources.mine_jpg;

                    //srp this out to mine

                    if (!minedGrid[i, j].IsMined)
                    {
                        int count = 0;

                        for (int p = i - 1; p <= i + 1; p++)
                        {
                            for (int q = j - 1; q <= j + 1; q++)
                            {
                                if (0 <= p && p < minedGrid.GetLength(0) && 0 <= q && q < minedGrid.GetLength(0))
                                {
                                    if (minedGrid[p, q].IsMined)
                                        ++count;
                                }
                            }
                        }

                        minedGrid[i, j].Paint +=
                            (sender, args) =>
                            args.Graphics.DrawString(count.ToString(), new Font("Arial", 10), new SolidBrush(Color.White), 0, 0);
                    }
                }
            }
        }
    }
}