using Swinesweeper.GameModeFactory.Interfaces;
using Swinesweeper.GamePlay;
using Swinesweeper.GamePlay.Interfaces;
using Swinesweeper.GridBuilder;
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
            ITypeInstanceCreator typeInstanceCreator = new TypeInstanceCreator();
            IGameModeFactory gameModeFactory = new GameModeFactory.GameModeFactory(typeInstanceCreator);
            
            ITilePainter tilePainter = new TilePainter();
            ITileCascader tileCascader = new TileCascader(tilePainter);

            //GridPainter
            var emptyGridBuilder = new EmptyGridBuilder();
            var gridControlBuilder = new GridControlBuilder();
            var gridMiner = new GridMiner(new RandomNumberGenerator());
            var pigCounter = new PigCounter();

            var gridPainter = new GridPainter(emptyGridBuilder, gridControlBuilder, gridMiner, pigCounter);

            //gameboards
            var gameBoardForm = new GameBoard(gridPainter, tileCascader);
            var gameModeForm = new GameMode(gameModeFactory);
            
            gameBoardForm.SubscribeToGameModeConfirmedEvent(gameModeForm);

            gameModeForm.ShowDialog();
            
            Application.Run(gameBoardForm);
        }
    }
}
