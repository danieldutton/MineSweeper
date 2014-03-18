using MSweeper.GameModeFactory.Interfaces;
using System;
using System.Windows.Forms;
using MSweeper.Utilities;
using MSweeper.Utilities.Interfaces;

namespace MSweeper.Presentation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form1 = new GameBoard();

            ITypeCreator typeCreator = new TypeCreator();
            IGameModeFactory gameModeFactory = new GameModeFactory.GameModeFactory(typeCreator);
            var optionsForm = new GameMode(gameModeFactory);
            
            form1.SubscribeToGameSettingsEvent(optionsForm);

            //subscribe to game over event
            var gameResult = new GameResult();


            optionsForm.ShowDialog();
            
            Application.Run(form1);
        }

    }
}
