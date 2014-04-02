using System;
using System.Drawing;
using System.Windows.Forms;

namespace Swinesweeper.Presentation
{
    public partial class GameResult : Form
    {
        private readonly bool _hasWon;

        private readonly int _secondsTaken;

        public GameResult(bool hasWon)
        {
            _hasWon = hasWon;           
            
            InitializeComponent();
            ColourBackground();
        }

        public GameResult(bool hasWon, int secondsTaken)
            :this(hasWon)
        {
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

            _lblTimeTakenValue.Text = _hasWon ? _secondsTaken.ToString() + " Seconds" : "--";
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
