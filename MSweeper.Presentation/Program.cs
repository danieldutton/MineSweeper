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
            
            //game settings
            ITypeCreator typeCreator = new TypeCreator();
            IGameModeFactory gameModeFactory = new GameModeFactory.GameModeFactory(typeCreator);
            
            //gameboards
            var gameBoard = new GameBoard();
            var optionsForm = new GameMode(gameModeFactory);
            
            gameBoard.SubscribeToGameModeConfirmedEvent(optionsForm);

            optionsForm.ShowDialog();
            
            Application.Run(gameBoard);
        }

    }
}
