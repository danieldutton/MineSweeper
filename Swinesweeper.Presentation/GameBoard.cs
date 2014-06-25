using Swinesweeper.GameModeFactory;
using Swinesweeper.GameModeFactory.EventArg;
using Swinesweeper.GameModeFactory.Interfaces;
using Swinesweeper.GamePlay;
using Swinesweeper.GamePlay.EventArg;
using Swinesweeper.GamePlay.Interfaces;
using Swinesweeper.GridBuilder;
using Swinesweeper.Utilities;
using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Swinesweeper.Presentation
{
    public partial class GameBoard : Form
    {
        private readonly GridPainter _gridPainter;

        private Timer _timer;

        private int _secondsPassed;

        public IGameMode ChosenGameMode { get; private set; }

        private readonly ITileCascader _tileCascader;


        public GameBoard(GridPainter gridPainter, ITileCascader tileCascader)
        {
            _gridPainter = gridPainter;
            _tileCascader = tileCascader;

            InitializeComponent();
            InitTimer();
            SubscribeToTileEvents();
        }

        private void InitTimer()
        {
            _timer = new Timer {Interval = 1000};
            _timer.Tick += Timer_Tick;
        }

        private void SubscribeToTileEvents()
        {
            Tile.MineHit += Tile_MineHit;
            Tile.TileClear += Tile_TileClear;
            Tile.FlagPlaced += Tile_FlagPlaced;
            Tile.FlagRemoved += Tile_FlagRemoved;
        }

        private void DrawGameBoard()
        {
            SetFormSize();
            SetFormConstraints();
            SetGridSize();
            SetFlagCountLabel();
            PositionTimerLabels();

            _gridPainter.PaintGrid(ChosenGameMode, _panelGrid);

            ControlStyler.ColourBackground(this);
        }

        private void SetFormSize()
        {
            Height = ChosenGameMode.FormSize.Y;
            Width = ChosenGameMode.FormSize.X;
        }

        private void SetFormConstraints()
        {
            MaximumSize = new Size(Width, Height);
            MinimumSize = new Size(Width, Height);
        }

        private void SetGridSize()
        {
            _panelGrid.Width = ChosenGameMode.GridPanelSize.X;
            _panelGrid.Height = ChosenGameMode.GridPanelSize.Y;
        }

        private void SetFlagCountLabel()
        {
            var flagCount = (int) ChosenGameMode.DifficultyLevel;
            _lblFlagCount.Text = flagCount.ToString();
        }

        private void PositionTimerLabels()
        {
            const int lblYPos = 4;

            switch (ChosenGameMode.GridSize)
            {
                case GridSize.Beginner:
                    _lblTimer.Location = new Point(Width - 100, lblYPos);
                    _lblTimeValue.Location = new Point(Width - 65, lblYPos);
                    break;

                case GridSize.Normal:
                    _lblTimer.Location = new Point(Width - 105, lblYPos);
                    _lblTimeValue.Location = new Point(Width - 70, lblYPos);
                    break;

                case GridSize.Advanced:
                    _lblTimer.Location = new Point(Width - 117, lblYPos);
                    _lblTimeValue.Location = new Point(Width - 82, lblYPos);
                    break;
            }
        }

        private void Tile_TileClear(object sender, TileClearEventArgs e)
        {
            _timer.Start();

            _tileCascader.CascadeTile(e.Grid, e.XPos, e.YPos);

            CheckForWin();
        }

        private void Tile_FlagRemoved(object sender, EventArgs e)
        {
            int flagCount = int.Parse(_lblFlagCount.Text);

            flagCount++;
            
            _lblFlagCount.Text = flagCount.ToString();
        }

        private void Tile_FlagPlaced(object sender, EventArgs e)
        {
            int flagCount = int.Parse(_lblFlagCount.Text);

            flagCount--;
            
            _lblFlagCount.Text = flagCount.ToString();
            CheckForWin();
        }

        private void Tile_MineHit(object sender, MineHitEventArgs e)
        {
            _timer.Stop();
            _tileCascader.CascadeAll(e.Grid);

            PlayOinkWav();
            DisplayGameResults(false);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            const int maxTimeDisplayValue = 1000;

            _secondsPassed++;

            if (_secondsPassed < maxTimeDisplayValue)
                _lblTimeValue.Text = _secondsPassed.ToString();
        }

        private void CheckForWin()
        {
            if (GridIsCompletelyClear())
            {
                _timer.Stop();
                DisplayGameResults(true);
            }
        }

        private void DisplayGameResults(bool hasWon)
        {
            var gameResultForm = new GameResult(hasWon, _secondsPassed, ChosenGameMode.DifficultyLevel);

            gameResultForm.ShowDialog();
        }

        private bool GridIsCompletelyClear()
        {
            return Tile.CorrectFlagCount == Tile.MineCount && Tile.TileCount == Tile.MineCount;
        }

        private void PlayOinkWav()
        {
            using (Stream stream = Properties.Resources.Pig_Oinking_Twice)
            {
                var snd = new SoundPlayer(stream);
                snd.Play();
            }
        }

        public void SubscribeToGameModeConfirmedEvent(GameMode optionsForm)
        {
            optionsForm.GameModeConfirmed += GameModeConfirmed_Click;
        }

        public void GameModeConfirmed_Click(object sender, ChosenGameModeEventArgs e)
        {
            ChosenGameMode = e.GameMode;
            DrawGameBoard();
        }
    }
}