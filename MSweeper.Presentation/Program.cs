using MSweeper.GameModeFactory.Interfaces;
using System;
using System.Windows.Forms;

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

            IGameModeFactory gameModeFactory = new GameModeFactory.GameModeFactory();
            var optionsForm = new GameMode(gameModeFactory);
            
            form1.SubscribeToGameSettingsEvent(optionsForm);

            optionsForm.ShowDialog();
            
            Application.Run(form1);
        }

    }
}
