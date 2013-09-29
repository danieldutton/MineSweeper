using MineSweeper.GameModeFactory.Interfaces;
using MineSweeper.Model.EventArg;
using MineSweeper.Settings;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MineSweeper.Presentation
{
    public partial class GameSettings : Form
    {
        public event EventHandler<GameSettingsEventArgs> GameSettingsConfirmed;

        private readonly IGameModeFactory _gameModeFactory;


        public GameSettings(IGameModeFactory gameModeFactory)
        {
            _gameModeFactory = gameModeFactory;
            InitializeComponent();
            InitialiseTags();
        }

        private void InitialiseTags()
        {
            _radioBtnBeginner.Tag = DifficultyLevel.Beginner;
            _radioBtnNormal.Tag = DifficultyLevel.Normal;
            _radioBtnAdvanced.Tag = DifficultyLevel.Advanced;
        }

        private void ConfirmGameSettings_Click(object sender, EventArgs e)
        {
            string gameModeName = GetChosenGameMode();

            IGameMode gameMode = _gameModeFactory.CreateInstance(gameModeName);

            OnGameSettingsConfirmed(new GameSettingsEventArgs(gameMode));

            Dispose();
        }

        private string GetChosenGameMode()
        {
            RadioButton checkedButton = _panelCheckBoxes.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(cBox => cBox.Checked);

            var gameMode = (DifficultyLevel)checkedButton.Tag;

            return gameMode.ToString();
        }

        protected virtual void OnGameSettingsConfirmed(GameSettingsEventArgs e)
        {
            EventHandler<GameSettingsEventArgs> handler = GameSettingsConfirmed;
            if (handler != null) handler(this, e);
        }
    }
}
