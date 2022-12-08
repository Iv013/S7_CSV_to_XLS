using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CSV_TXT_to_XLS
{
    [Serializable]
    public class Settings
    {
        public string DirectoryPath { get; set; }
        public bool integrator { get; set; }
        public bool HideMode { get; set; }
        public bool ModeHeight { get; set; }
        public string TypeFileWatch { get; set; } 
      






    }
}
