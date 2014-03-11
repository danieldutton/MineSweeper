﻿using MSweeper.GameModeFactory.EventArg;
using MSweeper.GameModeFactory.Interfaces;
using MSweeper.GameModeFactory.Settings;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MSweeper.Presentation
{
    public partial class GameMode : Form
    {
        public event EventHandler<SelectedGameModeEventArgs> GameSettingsConfirmed;

        private readonly IGameModeFactory _gameModeFactory;


        public GameMode(IGameModeFactory gameModeFactory)
        {
            _gameModeFactory = gameModeFactory;

            InitializeComponent();
            InitGameModeValues();
        }

        private void InitGameModeValues()
        {
            _radioBtnBeginner.Tag = DifficultyLevel.Beginner;
            _radioBtnNormal.Tag = DifficultyLevel.Normal;
            _radioBtnAdvanced.Tag = DifficultyLevel.Advanced;
        }

        private void ConfirmGameSettings_Click(object sender, EventArgs e)
        {
            string gameModeName = GetChosenGameMode();

            IGameMode gameMode = _gameModeFactory.CreateInstance(gameModeName);

            OnGameSettingsConfirmed(new SelectedGameModeEventArgs(gameMode));

            Dispose();
        }

        private string GetChosenGameMode()
        {
            RadioButton checkedButton = _panelCheckBoxes.Controls.OfType<RadioButton>()
                                                        .FirstOrDefault(cBox => cBox.Checked);

            var gameMode = (DifficultyLevel) checkedButton.Tag;

            return gameMode.ToString();
        }

        protected virtual void OnGameSettingsConfirmed(SelectedGameModeEventArgs e)
        {
            EventHandler<SelectedGameModeEventArgs> handler = GameSettingsConfirmed;
            if (handler != null) handler(this, e);
        }
    }
}