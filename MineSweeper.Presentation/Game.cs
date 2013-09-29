using MineSweeper.GridTools;
using MineSweeper.Model.EventArg;
using MineSweeper.Settings.Interfaces;
using MineSweeper.Utilities;
using System.Windows.Forms;

namespace MineSweeper.Presentation
{
    public partial class Game : Form
    {
        public IGameMode ChosenGameMode { get; private set; }

        public Game()
        {            
            InitializeComponent();          
        }

        public void SubscribeToGameSettingsEvent(GameSettings optionsForm)
        {
            optionsForm.GameSettingsConfirmed +=optionsForm_GameSettingsConfirmed;
        }

        public void optionsForm_GameSettingsConfirmed(object sender, GameSettingsEventArgs e)
        {
            ChosenGameMode = e.GameMode;
            DrawGrid();
        }

        private void DrawGrid()
        {
            Height = ChosenGameMode.FormSize.Y;
            Width = ChosenGameMode.FormSize.X;

            var renderer = new GridProvider(new GridBuilder(), new GridMiner(new RandomNumberGenerator()));

            _panelGrid.Width = ChosenGameMode.GridPanelSize.X;
            _panelGrid.Height = ChosenGameMode.GridPanelSize.Y;

            renderer.DrawGrid(ChosenGameMode, _panelGrid);
        }
    }
}
