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
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //game settings
            ITypeCreator typeCreator = new TypeCreator();
            IGameModeFactory gameModeFactory = new GameModeFactory.GameModeFactory(typeCreator);
            
            ITilePainter tilePainter = new TilePainter();
            ITileCascader tileCascader = new TileCascader(tilePainter);

            //gameboards
            var gameBoardForm = new GameBoard(tileCascader);
            var gameModeForm = new GameMode(gameModeFactory);
            
            gameBoardForm.SubscribeToGameModeConfirmedEvent(gameModeForm);

            gameModeForm.ShowDialog();
            
            Application.Run(gameBoardForm);
        }
    }
}
