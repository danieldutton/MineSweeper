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
        public IGameMode ChosenGameMode { get; private set; }

        private readonly ITileCascader _tileCascader;


        public GameBoard(ITileCascader tileCascader)
        {
            _tileCascader = tileCascader;
            
            InitializeComponent();
            ColourFormBackground();
            SubscribeToTileEvents();
        }

        private void ColourFormBackground()
        {
            const string colour = "#f2d78b";

            BackColor = ColorTranslator.FromHtml(colour);
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

            painter.PaintGrid(ChosenGameMode, _panelGrid);
        }

        private void SubscribeToTileEvents()
        {
            Tile.MineHit += Tile_MineHit;
            Tile.TileClear += Tile_TileClear;
            Tile.FlagPlaced += Tile_FlagPlaced;
            Tile.FlagRemoved += Tile_FlagRemoved;           
        }

        private void Tile_TileClear(object sender, TileClearEventArgs e)
        {
            _tileCascader.CascadeTile(e.Grid, e.XPos, e.YPos);

            if (Tile.CorrectFlagCount == Tile.MineCount && Tile.TileCount == Tile.MineCount)
            {
                var gameResultForm = new GameResult(true);
                gameResultForm.ShowDialog();
            }
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
        }

        private void Tile_MineHit(object sender, MineHitEventArgs e)
        {
            PlayOinkWav();
            
            _tileCascader.CascadeAll(e.Grid);
            
            var gameResultForm = new GameResult(false);
            gameResultForm.ShowDialog();
        }

        private void PlayOinkWav()
        {
            Stream str = Properties.Resources.Pig_Oinking_Twice;
            var snd = new SoundPlayer(str);
            snd.Play();
        }
    }
}