using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TriangleChallenge
{
    public class ValidationManagment 
    {
        public static string tTipTitle = "Invalid Input";
        public static string tTipMessage = "We're sorry, but only digits are allowed.";

        public static bool inputsValidator(TextBox input, ToolTip tolTp, TextBox tBox)
        {
            if (!Utilities.isNumeric(input.Text))
            {
                tolTp.ToolTipTitle = tTipTitle;
                tolTp.Show(tTipMessage, input, 3000);
                input.ForeColor = Color.Red;
                input.Focus();
                tBox.Text = string.Empty;
                return false;              
            }
            else
            {
                input.ForeColor = SystemColors.HotTrack;
                return true;
            }
        }
    }
}
