﻿using Swinesweeper.GameModeFactory;
using Swinesweeper.GameModeFactory.EventArg;
using Swinesweeper.GameModeFactory.Interfaces;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Swinesweeper.Presentation
{
    public partial class GameMode : Form
    {
        public event EventHandler<ChosenGameModeEventArgs> GameModeConfirmed;

        private readonly IGameModeFactory _gameModeFactory;

        public GameMode(IGameModeFactory gameModeFactory)
        {
            _gameModeFactory = gameModeFactory;

            InitializeComponent();
            ColourRadioBox();           
            InitGameModes();
        }

        private void ColourRadioBox()
        {
            _panelRadioBtns.BackColor = ColorTranslator.FromHtml("#f2d78b");
        }

        private void InitGameModes()
        {
            _radioBtnBeginner.Tag = DifficultyLevel.Beginner;
            _radioBtnNormal.Tag = DifficultyLevel.Normal;
            _radioBtnAdvanced.Tag = DifficultyLevel.Advanced;
        }

        private void SelectGameMode_Click(object sender, EventArgs e)
        {
            string gameModeName = FetchChosenGameMode();

            IGameMode gameMode = _gameModeFactory.CreateInstance(gameModeName);

            OnGameModeConfirmed(new ChosenGameModeEventArgs(gameMode));

            Dispose();
        }   

        private string FetchChosenGameMode()
        {
            RadioButton checkedButton = _panelRadioBtns.Controls
            .OfType<RadioButton>().FirstOrDefault(cBox => cBox.Checked);

            var gameMode = (DifficultyLevel) checkedButton.Tag;

            return gameMode.ToString();
        }

        protected virtual void OnGameModeConfirmed(ChosenGameModeEventArgs e)
        {
            EventHandler<ChosenGameModeEventArgs> handler = GameModeConfirmed;
            if (handler != null) handler(this, e);
        }

        private void GameMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }             
    }
}