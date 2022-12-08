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

        public string TypeFile { get; set; }
        public string TypeFileWatch { get; set; }
        public Action<List<string>> RunMethod { get; set; }

        private FileSystemWatcher watcher;


        public Watcher(string typeFileWatch, Action<List<string>> runMethod)
        {
            TypeFileWatch = typeFileWatch;
            RunMethod = runMethod;
            watcher = new FileSystemWatcher();
        }

       public void Findfile(string path, string extansion)
        {
            watcher.Path = path;
            watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            watcher.Created += OnCreated;
            watcher.Filter = extansion;
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
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
