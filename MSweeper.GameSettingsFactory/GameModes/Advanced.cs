﻿using MSweeper.GameModeFactory.Interfaces;
using MSweeper.GameModeFactory.Settings;
using System.Drawing;

namespace MSweeper.GameModeFactory.GameModes
{
    public sealed class Advanced : IGameMode
    {
        public Point FormSize { get; private set; }
        
        public Point GridPanelSize { get; private set; }

        public DifficultyLevel DifficultyLevel { get; private set; }

        public GridSize GridSize { get; private set; }


        public Advanced()
        {
            FormSize = new Point(359, 436);
            GridPanelSize = new Point(314, 329);
            DifficultyLevel = DifficultyLevel.Advanced;
            GridSize = GridSize.Advanced;
        }
    }
}