using Swinesweeper.GameModeFactory;
using Swinesweeper.Presentation.Properties;
using Swinesweeper.Utilities;
using System;
using System.Windows.Forms;

namespace Swinesweeper.Presentation
{
    public partial class GameResult : Form
    {
        private readonly bool _hasWon;

        private readonly int _secondsTaken;

        private readonly DifficultyLevel _difficultyLevel;


        public GameResult(bool hasWon, int secondsTaken, 
            DifficultyLevel difficultyLevel)
        {
            _hasWon = hasWon;
            _difficultyLevel = difficultyLevel;
            _secondsTaken = secondsTaken;

            InitializeComponent();
            AddAdditionalStyling();
            DisplayGameStatus();
            DisplayTimeTaken();
            DisplayBestGameTime();
            
            if (_hasWon)
                SaveTimeIfFastest();
        }


        private void AddAdditionalStyling()
        {
            ControlStyler.ColourBackground(this);    
        }

        private void DisplayGameStatus()
        {
            _lblResultsText.Text = _hasWon 
                ? Resources.winningMessage : Resources.losingMessage;    
        }

        private void DisplayTimeTaken()
        {
            _lblTimeTakenValue.Text = _hasWon 
                ? _secondsTaken + " Seconds" : "--";    
        }

        private void SaveTimeIfFastest()
        {
            if (IsFastestTime())
            {
                Settings.Default[_difficultyLevel.ToString()] = _secondsTaken;
                Settings.Default.Save();
            }                
        }

        private bool IsFastestTime()
        {
            int fastestTime = (int)Settings.Default[_difficultyLevel.ToString()];

            return _secondsTaken < fastestTime;
        }

        private void DisplayBestGameTime()
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
