using MSweeper.GameModeFactory.EventArg;
using MSweeper.GameModeFactory.Interfaces;
using MSweeper.GridTools.Settings;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MSweeper.Presentation
{
    public partial class GameSettings : Form
    {
        public event EventHandler<ChosenGameModeEventArgs> GameSettingsConfirmed;

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

            OnGameSettingsConfirmed(new ChosenGameModeEventArgs(gameMode));

            Dispose();
        }

        private string GetChosenGameMode()
        {
            RadioButton checkedButton = _panelCheckBoxes.Controls.OfType<RadioButton>()
                                                        .FirstOrDefault(cBox => cBox.Checked);

            var gameMode = (DifficultyLevel) checkedButton.Tag;

            return gameMode.ToString();
        }

        protected virtual void OnGameSettingsConfirmed(ChosenGameModeEventArgs e)
        {
            EventHandler<ChosenGameModeEventArgs> handler = GameSettingsConfirmed;
            if (handler != null) handler(this, e);
        }
    }
}