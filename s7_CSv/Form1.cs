using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using CSV_TXT_to_XLS.Properties;

namespace CSV_TXT_to_XLS
{
    public partial class Form1 : Form
    {
      
        Settings settings = new Settings();
        AbstractReport Report;
        Watcher watcher;

        protected override void OnFormClosing(FormClosingEventArgs eventArgs)
        {
            Saveconfig();
        }

        public Form1()
        {
            InitializeComponent();
            txtB_FolderForWatcher.DragLeave += (s, a) => { txtB_FolderForWatcher.Text = "Выберите или перетащите папку"; };
            txtB_FolderForWatcher.DragEnter += (s, a) => { DragEnterTextBox(s,a); };
            TxtB_FileOriginal.DragEnter+= (s, a) => { DragEnterTextBox(s, a); };
            TxtB_FileOriginal.DragLeave += (s, a) => { TxtB_FileOriginal.Text = $"Выберите или перетащите{settings.TypeFileWatch} файл"; };
            radioButton1.CheckedChanged += (s, a) => { Type_change(); };
            radioButton2.CheckedChanged += (s, a) => { Type_change(); };
            btn_formHeigth.MouseEnter += (s, a) => { btn_formHeigth.BackColor = SystemColors.ControlDark; };
            btn_formHeigth.MouseLeave += (s, a) => { btn_formHeigth.BackColor = SystemColors.Control; };
            radioButton1.CheckedChanged += (s, a) => { settings.integrator = radioButton1.Checked; };
            btn_SelectFolder.Click += (s, a) => { SelectFolder(); };
            btn_FindFile.Click += (s, a) => { FindFileForReport(); };
            btn_formHeigth.Click += (s, a) =>{  ResizeThisForm();};
                 
            }
        void Form1_Load(object sender, EventArgs e)
        {
            int countProcces = 0;
            foreach (Process process in Process.GetProcesses())  //получаем список процессов
            if (process.ProcessName == "CSV_TXT_to XLS") countProcces++;         //Считаем скольок процессов запущено с данным именем 
           
            if (countProcces > 1)
            {
                MessageBox.Show("Данное приложение уже запущено.\n " +
                    "Если приложение не отображается необходимо переоткрыть приложение с атрибутом V", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            InitApp();
            Type_change();
        }

        void InitApp()   
        {
            settings = SerializeData<Settings>.Restore(Application.ExecutablePath.Replace(".exe", ".xml"));
            txtB_FolderForWatcher.Text = settings.DirectoryPath;
            checkBox1.Checked = settings.HideMode;
            radioButton1.Checked = settings.integrator;
            radioButton2.Checked = !settings.integrator;
            if (settings.ModeHeight) ResizeThisForm();
            Opacity = settings.HideMode ? 0 : 1;
            ShowInTaskbar = checkBox1.Checked ? false : true;

            watcher = new Watcher(settings.TypeFileWatch, Report.MakeReport);
            watcher.State += getStateWatcher;
             if (Directory.Exists(txtB_FolderForWatcher.Text))
             {
                watcher.Findfile(txtB_FolderForWatcher.Text, $"*.{settings.TypeFileWatch.ToLower()}");
             }

        }
        void SelectFolder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtB_FolderForWatcher.Text = folderBrowserDialog1.SelectedPath;
                watcher.Findfile(txtB_FolderForWatcher.Text, $"*.{settings.TypeFileWatch.ToLower()}");
            }
           
        }

        void FindFileForReport()
        {
            openFileDialog1.Filter =  string.Format("{0} files (*.{0})|*.{0}|All files (*.*)|*.*", settings.TypeFileWatch);
            openFileDialog1.ShowDialog();
            if (File.Exists(openFileDialog1.FileName)) TxtB_FileOriginal.Text = openFileDialog1.FileName;
          //  StatusText.Text = "Тут будет имя преобразованного файла";
        }

     void btn_MakeOneReport_Click(object sender, EventArgs e)
        {
            if (File.Exists(TxtB_FileOriginal.Text)) {
                var files = new List<string>();
                files.Add(TxtB_FileOriginal.Text);
                Report.MakeReport(files);
            }
           else MessageBox.Show("Файл не выбран либо его не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

      
        void Saveconfig()
        {
            settings.DirectoryPath = txtB_FolderForWatcher.Text;
            settings.HideMode = checkBox1.Checked;
            settings.integrator = radioButton1.Checked;
           settings.ModeHeight = (this.Height > 350)? true: false;
            SerializeData<Settings>.Save(settings, Application.ExecutablePath.Replace(".exe", ".xml"));
        }

        void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtB_FolderForWatcher.Text) & checkBox1.Checked)
            {
                MessageBox.Show("Нельзя установить скрытый режим если\n " +
                    "не выбрана папка для контроля или такой папки не существует", 
                    "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                checkBox1.Checked = false;
            }
        }

        void btn_OpenReport_click(object sender, EventArgs e)
        {
            if (File.Exists(StatusText.Text))
                Process.Start(new ProcessStartInfo("explorer", $"/n, /select, {StatusText.Text}"));  
            else
            {
                MessageBox.Show("Файл отсутcтвует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StatusText.Text = "Файл отсутcтвует";
            }
        }

        private void FileOriginal_DragDrop(object sender, DragEventArgs e)
        {
            String[] line = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (line[0].ToString().Contains($".{settings.TypeFileWatch.ToLower()}"))
            {
                TxtB_FileOriginal.Text = line[0].ToString();
                StatusText.Text = "Тут будет имя преобразованного файла";
            }
            else TxtB_FileOriginal.Text = $"Не является файлом {settings.TypeFileWatch}";
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            String[] line = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (Directory.Exists(line[0].ToString()))
            {
                txtB_FolderForWatcher.Text = line[0].ToString();
                watcher.Findfile(txtB_FolderForWatcher.Text, $"*.{settings.TypeFileWatch.ToLower()}");
                Saveconfig();
            }
            else txtB_FolderForWatcher.Text = "Не является папкой";
        }

        private void DragEnterTextBox(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                TextBox textBox = sender as TextBox;
                e.Effect = DragDropEffects.Copy;
                textBox.Text = "Отпустите кнопку мыши";
            }
        }

    private void Type_change()
        {
      
           if (radioButton1.Checked) 
            {
                settings.TypeFileWatch = "CSV";
                Report = new ReportFromCSV(); ;
            } else
            {
                settings.TypeFileWatch = "TXT";
                Report = new ReportFromTXT(); ;
            }
            StatusText.Text = "Тут будет имя преобразованного файла";
            TxtB_FileOriginal.Text = $"Выберите или перетащите {settings.TypeFileWatch} файл";
        }

        void ResizeThisForm()
        {
            this.ResizeHeight();
             btn_formHeigth.Image = (btn_formHeigth.Image == Resources.arrow_down) ? Resources.Arrow_up: Resources.arrow_down;

        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            listBox_AllFile.Items.Clear();
           // files.Clear();
            btn_MakeReportAllFile.Text = @"Преобразовать";
            String[] line = (string[])e.Data.GetData(DataFormats.FileDrop);
            for (int i = 0; i< line.Length; i++) { 
                 if (line[i].ToString().Contains($".{settings.TypeFileWatch.ToLower()}"))
                //    files.Add(line[i]);
                    listBox_AllFile.Items.Add(line[i].ToString());
            }
           // listBox1.Items.AddRange (files.ToArray());
        }
        
        
        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))    e.Effect = DragDropEffects.Copy;
        }

        private void button5_Click(object sender, EventArgs e)
        { 
           if (listBox_AllFile.Items.Count > 0 )
            {
              var files = new List<string>();
                foreach (var item in listBox_AllFile.Items)
                    files.Add(item.ToString());
                   
                Report.MakeReport(files); ;
             }
                
           
        }

       
        void getStateWatcher()
        {
            lb_statusWatcher.Text = watcher.stateWatcher ? "Отслеживание запущено" : "Отслеживание остановлено";
            lb_statusWatcher.ForeColor = watcher.stateWatcher ? Color.Green: Color.Red;
            btn_ControlWatcher.Text = watcher.stateWatcher ? "Остоновить" : "Запустить";
            btn_ControlWatcher.BackColor = watcher.stateWatcher ? Color.Yellow: Color.LawnGreen;
        }

        private void btn_ControlWatcher_Click(object sender, EventArgs e)
        {
            if(watcher.stateWatcher)
            watcher.Stop();
            else if (Directory.Exists(txtB_FolderForWatcher.Text))
            {
                watcher.Findfile(txtB_FolderForWatcher.Text, $"*.{settings.TypeFileWatch.ToLower()}");
            }
            else MessageBox.Show("Путь для отслеживания отсутствует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }

}
