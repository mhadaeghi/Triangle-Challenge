using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TriangleChallenge
{
    class Result
    {
        private string errorText = "The Lengths Do Not Present a Triangle!";
        private string resultText = string.Empty;
        public void showResult(string strResult, bool boln, TextBox resultBox)
        {
            if (!boln)
            {
                resultBox.ForeColor = Color.Red;
                resultBox.Text = errorText;
            }
            else
            {
                resultBox.ForeColor = Color.Green;
                resultBox.Text = strResult;
            }
        }
    }
}
