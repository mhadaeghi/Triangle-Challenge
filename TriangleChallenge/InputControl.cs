using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace TriangleChallenge
{
    public class InputControl
    {
        public bool triangleControl(decimal[] raw)
        {
            decimal[] values = raw;
            bool control = true;

            if (values.Max() >= values.Sum() - values.Max())
                control = false;

            return control;
        }
    }
}
