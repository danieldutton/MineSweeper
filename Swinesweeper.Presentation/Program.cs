using Swinesweeper.GameModeFactory.Interfaces;
using Swinesweeper.GamePlay;
using Swinesweeper.GamePlay.Interfaces;
using Swinesweeper.Utilities;
using Swinesweeper.Utilities.Interfaces;
using System;
using System.Windows.Forms;

namespace Swinesweeper.Presentation
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
            
            ITileCascader tileCascader = new TileCascader();

            //gameboards
            var gameBoard = new GameBoard(tileCascader);
            var optionsForm = new GameMode(gameModeFactory);
            
            gameBoard.SubscribeToGameModeConfirmedEvent(optionsForm);

            optionsForm.ShowDialog();
            
            Application.Run(gameBoard);
        }

    }
}
