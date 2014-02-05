using MSweeper.GridTools.Interfaces;
using MSweeper.Settings;
using System;
using System.Windows.Forms;
using GridSize = MSweeper.GridTools.Settings.GridSize;

namespace MSweeper.GridTools
{
    public class GridControlBuilder : IGridControlBuilder
    {
        public Control AddControlsToGrid<T>(T[,] controlsToAdd, Control control, GridSize gridSize) 
            where T: Control
        {
            gridSize = SetGridSizeBeginnerIfGridSizeUndefined(gridSize);

            int counter = (int) gridSize;

            for (int i = 0; i < counter; i++)
            {
                for (int j = 0; j < counter; j++)
                {
                    if(controlsToAdd[i, j] != null)
                        control.Controls.Add(controlsToAdd[i, j]);
                }
            }
            return control;
        }

        private GridSize SetGridSizeBeginnerIfGridSizeUndefined(GridSize gridSize)
        {
            if (!Enum.IsDefined(typeof(GridSize), gridSize))
                gridSize = GridSize.Beginner;

            return gridSize;
        }
    }
}
