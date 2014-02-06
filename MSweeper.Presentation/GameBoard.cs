using MSweeper.GameModeFactory.EventArg;
using MSweeper.GameModeFactory.Interfaces;
using MSweeper.GridTools;
using MSweeper.Utilities;
using System.Windows.Forms;

namespace MSweeper.Presentation
{
    public partial class GameBoard : Form
    {
        public IGameMode ChosenGameMode { get; private set; }

        public GameBoard()
        {
            InitializeComponent();
        }

        public void SubscribeToGameSettingsEvent(GameMode optionsForm)
        {
            optionsForm.GameSettingsConfirmed += optionsForm_GameSettingsConfirmed;
        }

        public void optionsForm_GameSettingsConfirmed(object sender, ChosenGameModeEventArgs e)
        {
            ChosenGameMode = e.GameMode;
            DrawGrid();
        }

        private void DrawGrid()
        {
            Height = ChosenGameMode.FormSize.Y;
            Width = ChosenGameMode.FormSize.X;

            var painter = new GridPainter(new EmptyGridBuilder(), new GridControlBuilder(),
                                          new GridMiner(new RandomNumberGenerator()));

            _panelGrid.Width = ChosenGameMode.GridPanelSize.X;
            _panelGrid.Height = ChosenGameMode.GridPanelSize.Y;

            painter.PaintGrid(ChosenGameMode, _panelGrid);
        }
    }
}