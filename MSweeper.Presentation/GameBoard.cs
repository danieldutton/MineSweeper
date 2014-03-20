using MSweeper.GameModeFactory.EventArg;
using MSweeper.GameModeFactory.Interfaces;
using MSweeper.GridTools;
using MSweeper.Utilities;
using System.Drawing;
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

        public void SubscribeToGameModeConfirmedEvent(GameMode optionsForm)
        {
            optionsForm.GameModeConfirmed += OptionsFormGameModeConfirmed;
        }

        public void OptionsFormGameModeConfirmed(object sender, ChosenGameModeEventArgs e)
        {
            ChosenGameMode = e.GameMode;
            DrawGrid();
            DrawGameStatsPanel();
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

        private void DrawGameStatsPanel()
        {
            _panelGameStats.Size = new Size(ChosenGameMode.FormSize.X - 70, 30);

            _panelGameStats.BackColor = Color.Teal;
            _lblFlags.Location = new Point(_panelGameStats.Width / 2, _panelGameStats.Height + 80);

            _panelGameStats.Location = new Point(25, ChosenGameMode.FormSize.Y);
            _lblFlagsValue.Location = new Point(ChosenGameMode.FormSize.X - 90, _panelGameStats.Height - 20); 
        }
    }
}