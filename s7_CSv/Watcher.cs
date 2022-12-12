using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_TXT_to_XLS
{
    public class Watcher
    {
        public delegate void Method();
        public event Method State;
        public  bool stateWatcher { get; set; }
        private string TypeFileWatch { get; set; }
        private Action<List<string>> RunMethod { get; set; }
        public FileSystemWatcher watcher;


        public Watcher(string typeFileWatch, Action<List<string>> runMethod)
        {
            TypeFileWatch = typeFileWatch;
            RunMethod = runMethod;    
            watcher = new FileSystemWatcher();
        }

        public void Stop()
        {
            watcher.Dispose();
            watcher = new FileSystemWatcher();
            stateWatcher = watcher.EnableRaisingEvents;
            State();
        }

       public void Findfile(string path, string extansion)
        {
            watcher.Path = path;
            watcher.Created += OnCreated;
            watcher.Filter = extansion;
            watcher.IncludeSubdirectories = false;
            watcher.EnableRaisingEvents = true;
            stateWatcher = watcher.EnableRaisingEvents;
            State();
       }

        async void OnCreated(object sender, FileSystemEventArgs e)
        {
                await Task.Delay(1000);
                List<string> files = new List<string>();
                files.Add(e.FullPath);

                RunMethod(files);
        }
    }



}
