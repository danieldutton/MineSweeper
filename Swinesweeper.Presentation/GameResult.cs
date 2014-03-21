using System.Windows.Forms;

namespace Swinesweeper.Presentation
{
    public partial class GameResult : Form
    {
        public GameResult()
        {
            InitializeComponent();
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

        }
    }
}
