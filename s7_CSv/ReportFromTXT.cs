using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_TXT_to_XLS
{
    public class ReportFromTXT : AbstractReport
    {
        public override string[] GetArrayString(string line)
        {
            string[] result = { line.Remove(10).Replace("-", ":"), line.Remove(21).Remove(0, 11), line.Remove(0, 22), };
            result[2] = result[2].Replace("@", "").Replace("!", "").Replace("%", "").Replace("?", "");
            return result;
        }

        public override Color GetColor(string line)
        {
            return line.Contains("@") || line.Contains("02 ") ? Color.Yellow 
                : line.Contains("!") || line.Contains("01 ") ? Color.Red 
                :line.Contains("%") || line.Contains("04 ") ? Color.Cyan 
                : line.Contains("?") || line.Contains("03 ") ? Color.White 
                : Color.LimeGreen;
        }
    }
}
