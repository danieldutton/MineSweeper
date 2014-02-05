using MSweeper.GameModeFactory.Interfaces;
using MSweeper.GridTools.Settings;
using System.Drawing;

namespace MSweeper.GameModeFactory.GameModes
{
    public class NullSettings : IGameMode
    {
        public Point FormSize { get; set; }
        
        public Point GridPanelSize { get; set; }
        
        public DifficultyLevel DifficultyLevel { get; set; }
        
        public GridSize GridSize { get; set; }
    }
}
