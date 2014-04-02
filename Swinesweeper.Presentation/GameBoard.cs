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
        private Timer _timer;

        private int _secondsPassed;

        public IGameMode ChosenGameMode { get; private set; }

        private readonly ITileCascader _tileCascader;


        public GameBoard(ITileCascader tileCascader)
        {
            _tileCascader = tileCascader; 
            
            InitializeComponent();
            InitTimer();
            ColourBackground();
            SubscribeToTileEvents();
        }

        private void InitTimer()
        {
            _timer = new Timer { Interval = 1000 };
            _timer.Tick += Timer_Tick;               
        }

        private void ColourBackground()
        {
            const string colour = "#f2d78b";

            BackColor = ColorTranslator.FromHtml(colour);
        }

        private void SubscribeToTileEvents()
        {
            Tile.MineHit += Tile_MineHit;
            Tile.TileClear += Tile_TileClear;
            Tile.FlagPlaced += Tile_FlagPlaced;
            Tile.FlagRemoved += Tile_FlagRemoved;
        }

        public void SubscribeToGameModeConfirmedEvent(GameMode optionsForm)
        {
            optionsForm.GameModeConfirmed += GameModeConfirmed_Click;
        }

        public void GameModeConfirmed_Click(object sender, ChosenGameModeEventArgs e)
        {
            ChosenGameMode = e.GameMode;
            DrawGrid();
        }

        private void DrawGrid()
        {
            Height = ChosenGameMode.FormSize.Y;
            Width = ChosenGameMode.FormSize.X;

            MaximumSize = new Size(Width, Height);
            MinimumSize = new Size(Width, Height);

            var painter = new GridPainter(new EmptyGridBuilder(), new GridControlBuilder(),
                                          new GridMiner(new RandomNumberGenerator()), new PigCounter());

            _panelGrid.Width = ChosenGameMode.GridPanelSize.X;
            _panelGrid.Height = ChosenGameMode.GridPanelSize.Y;

            var pigCount = (int) ChosenGameMode.DifficultyLevel;
            _lblFlagCount.Text = pigCount.ToString();
            
            PlaceTimerLabels();
            painter.PaintGrid(ChosenGameMode, _panelGrid);
        }

        private void PlaceTimerLabels()
        {
            const int lblHeight = 4;

            if (ChosenGameMode.GridSize == GridSize.Beginner)
            {
                _lblTimer.Location = new Point(Width - 100, lblHeight);
                _lblTimeValue.Location = new Point(Width - 65, lblHeight);        
            }

            if (ChosenGameMode.GridSize == GridSize.Normal)
            {
                _lblTimer.Location = new Point(Width - 125, lblHeight);
                _lblTimeValue.Location = new Point(Width - 90, lblHeight);
            }

            if (ChosenGameMode.GridSize == GridSize.Advanced)
            {
                _lblTimer.Location = new Point(Width - 145, lblHeight);
                _lblTimeValue.Location = new Point(Width - 110, lblHeight);
            }
        }

        private void Tile_TileClear(object sender, TileClearEventArgs e)
        {
            _timer.Start();

            _tileCascader.CascadeTile(e.Grid, e.XPos, e.YPos);

            HasWon();
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

            HasWon();
        }

        private void Tile_MineHit(object sender, MineHitEventArgs e)
        {
            _timer.Stop();

            PlayOinkWav();
            
            _tileCascader.CascadeAll(e.Grid);
            
            var gameResultForm = new GameResult(hasWon: false,secondsTaken: _secondsPassed);
            gameResultForm.ShowDialog();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _secondsPassed++;
            _lblTimeValue.Text = _secondsPassed.ToString();
        }

        private void HasWon()
        {
            if (Tile.CorrectFlagCount == Tile.MineCount && Tile.TileCount == Tile.MineCount)
            {
                _timer.Stop();

                var gameResultForm = new GameResult(hasWon: true, secondsTaken: _secondsPassed);
                gameResultForm.ShowDialog();
            }    
        }

        private void PlayOinkWav()
        {
            Stream stream = Properties.Resources.Pig_Oinking_Twice;
            var snd = new SoundPlayer(stream);
            snd.Play();
        }
    }
}