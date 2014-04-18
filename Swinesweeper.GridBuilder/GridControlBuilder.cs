using Swinesweeper.GameModeFactory;
using Swinesweeper.GridBuilder.Interfaces;
using System;
using System.Windows.Forms;

namespace Swinesweeper.GridBuilder
{
    public class GridControlBuilder : IGridControlBuilder
    {
        public Control AddControlsToGrid<T>(T[,] controlsToAdd, Control controlToPopulate, GridSize gridSize) 
            where T: Control
        {
            if(controlsToAdd == null) throw new ArgumentNullException("controlsToAdd");
            if(controlToPopulate == null) throw new ArgumentNullException("controlToPopulate");

            if (!Enum.IsDefined(typeof(GridSize), gridSize))
                gridSize = GridSize.Beginner;

            int counter = (int) gridSize;

            for (int i = 0; i < counter; i++)
            {
                for (int j = 0; j < counter; j++)
                {
                    if(controlsToAdd[i, j] != null)
                        controlToPopulate.Controls.Add(controlsToAdd[i, j]);
                }
            }
            return controlToPopulate;
        }
    }
}
