using System.Drawing;
using System.Windows.Forms;

namespace Swinesweeper.Utilities
{
    public static class ControlStyler
    {
        public static void ColourBackground(Control control)
        {
            const string colour = "#f2d78b";

            control.BackColor = ColorTranslator.FromHtml(colour);      
        }

        public static void ColourBackground(Control control, string hexColour)
        {
            control.BackColor = ColorTranslator.FromHtml(hexColour);    
        }
    }
}
