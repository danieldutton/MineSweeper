using MineSweeper.Settings;
using MineSweeper.Settings.Interfaces;
using System.Drawing;


namespace MineSweeper.GameModeFactory.GameModes
{
    public class NullSettings : IGameMode
    {
        public Point FormSize { get; set; }
        public Point GridPanelSize { get; set; }
        public DifficultyLevel DifficultyLevel { get; set; }
        public GridSize GridSize { get; set; }

        public NullSettings()
        {
            
        }
    }
}
