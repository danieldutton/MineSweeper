using System;
using System.Drawing;
using System.Windows.Forms;

namespace Swinesweeper.Utilities
{
    public static class ControlStyler
    {
        public static void ColourBackground(Control control, string defaultColour = "#f2d78b")
        {
            if(control == null) throw new ArgumentNullException("control");
            if(defaultColour == null) throw new ArgumentNullException("defaultColour");

            control.BackColor = ColorTranslator.FromHtml(defaultColour);      
        }
    }
}
