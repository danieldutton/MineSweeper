using System.Windows.Forms;

namespace MSweeper.Presentation
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
    }
}
