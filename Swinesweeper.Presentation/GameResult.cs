using System.Drawing;
using System.Windows.Forms;

namespace Swinesweeper.Presentation
{
    public partial class GameResult : Form
    {
        private readonly bool _hasWon;

        public GameResult(bool hasWon)
        {
            _hasWon = hasWon;           
            InitializeComponent();
            ColourFormBackground();
        }

        private void ColourFormBackground()
        {
            const string colour = "#f2d78b";

            BackColor = ColorTranslator.FromHtml(colour);
        }

        private void GameResult_Load(object sender, System.EventArgs e)
        {
            _lblResultsText.Text = _hasWon ? "Congratulations you have won" : "Sorry you lose..oink oink";
        }

        private void GameResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }

        private void ExitGame_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void PlayAgain_Click(object sender, System.EventArgs e)
        {
            Application.Restart();
        }
    }
}
