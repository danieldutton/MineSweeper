using Swinesweeper.GameModeFactory;
using Swinesweeper.Presentation.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Swinesweeper.Presentation
{
    public partial class GameResult : Form
    {
        private readonly bool _hasWon;

        private readonly int _secondsTaken;

        private readonly DifficultyLevel _difficultyLevel;

        public GameResult(bool hasWon)
        {
            _hasWon = hasWon;           
            
            InitializeComponent();
            ColourBackground();
        }

        public GameResult(bool hasWon, int secondsTaken, 
            DifficultyLevel difficultyLevel)
            :this(hasWon)
        {
            _difficultyLevel = difficultyLevel;
            _secondsTaken = secondsTaken;
        }

        private void ColourBackground()
        {
            const string colour = "#f2d78b";

            BackColor = ColorTranslator.FromHtml(colour);
        }

        private void GameResult_Load(object sender, EventArgs e)
        {
            _lblResultsText.Text = _hasWon ? "Congratulations you have won!" : "Sorry you lose..oink oink!";

            _lblTimeTakenValue.Text = _hasWon ? _secondsTaken + " Seconds" : "--";

            if (_hasWon)
            {
                SavePlayTime();
                DisplayBestTime();
            }         
        }

        private void SavePlayTime()
        {
            int fastestTime = (int)Settings.Default[_difficultyLevel.ToString()];

            if (_secondsTaken < fastestTime)
            {
                Settings.Default[_difficultyLevel.ToString()] = _secondsTaken;
                Settings.Default.Save();
            }                
        }

        private void DisplayBestTime()
        {
            int bestTime = (int)Settings.Default[_difficultyLevel.ToString()];

            _lblBestTimeValue.Text = bestTime + " Seconds";    
        }

        private void ExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void GameResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }
    }
}
