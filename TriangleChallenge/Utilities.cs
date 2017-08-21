using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleChallenge
{
    public class Utilities
    {
        //Controlling the input types:
        public static bool isNumeric(string str)
        {
            if (str == null)
                str = string.Empty;

            decimal output = 0;
            return decimal.TryParse(str, out output);
        }

        //Handelling the Errors:
        public static string getExeptionMessage(Exception err)
        {
            StringBuilder msg = new StringBuilder();
            msg.AppendLine(err.Message);

            while (err.InnerException != null)
            {
                msg.AppendLine(err.InnerException.Message);
                err = err.InnerException;
            }
            return msg.ToString();
        }
    }
}
