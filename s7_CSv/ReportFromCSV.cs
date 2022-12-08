﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_TXT_to_XLS
{
    public   class ReportFromCSV : AbstractReport
    {
        public  override string[] GetArrayString(string line)
        {
            return line.ToString().Split(';');
        }

        public override Color GetColor(string line)
        {
            return line.Contains("Предупредительное")
                || line.Contains("Сбой")
                || line.Contains("Ошибки") ? Color.Yellow
                : (line.Contains("Аварийное")) ? Color.Red
                : Color.LimeGreen;
        }
    }
}
