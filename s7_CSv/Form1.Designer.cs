
namespace CSV_TXT_to_XLS
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_FindFile = new System.Windows.Forms.Button();
            this.txtB_FolderForWatcher = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.TxtB_FileOriginal = new System.Windows.Forms.TextBox();
            this.btn_MakeOneReport = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lbl_StatusText = new System.Windows.Forms.Label();
            this.btn_OpenReport = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_SelectFolder = new System.Windows.Forms.Button();
            this.listBox_AllFile = new System.Windows.Forms.ListBox();
            this.btn_formHeigth = new System.Windows.Forms.PictureBox();
            this.btn_MakeReportAllFile = new System.Windows.Forms.Button();
            this.btn_ControlWatcher = new System.Windows.Forms.Button();
            this.lb_statusWatcher = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_formHeigth)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Выберите CSV файл.";
            // 
            // btn_FindFile
            // 
            this.btn_FindFile.BackColor = System.Drawing.SystemColors.Control;
            this.btn_FindFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_FindFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_FindFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_FindFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FindFile.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FindFile.Location = new System.Drawing.Point(18, 114);
            this.btn_FindFile.Name = "btn_FindFile";
            this.btn_FindFile.Size = new System.Drawing.Size(127, 29);
            this.btn_FindFile.TabIndex = 0;
            this.btn_FindFile.Text = "Выберите файл";
            this.btn_FindFile.UseVisualStyleBackColor = false;
            // 
            // txtB_FolderForWatcher
            // 
            this.txtB_FolderForWatcher.AllowDrop = true;
            this.txtB_FolderForWatcher.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.txtB_FolderForWatcher.Location = new System.Drawing.Point(18, 77);
            this.txtB_FolderForWatcher.Multiline = true;
            this.txtB_FolderForWatcher.Name = "txtB_FolderForWatcher";
            this.txtB_FolderForWatcher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtB_FolderForWatcher.Size = new System.Drawing.Size(642, 32);
            this.txtB_FolderForWatcher.TabIndex = 4;
            this.txtB_FolderForWatcher.Text = "Выберите или перетащите папку";
            this.txtB_FolderForWatcher.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            // 
            // TxtB_FileOriginal
            // 
            this.TxtB_FileOriginal.AllowDrop = true;
            this.TxtB_FileOriginal.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtB_FileOriginal.Location = new System.Drawing.Point(19, 152);
            this.TxtB_FileOriginal.Multiline = true;
            this.TxtB_FileOriginal.Name = "TxtB_FileOriginal";
            this.TxtB_FileOriginal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtB_FileOriginal.Size = new System.Drawing.Size(642, 32);
            this.TxtB_FileOriginal.TabIndex = 6;
            this.TxtB_FileOriginal.Text = "Выберите или перетащите CSV файл";
            this.TxtB_FileOriginal.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileOriginal_DragDrop);
            // 
            // btn_MakeOneReport
            // 
            this.btn_MakeOneReport.BackColor = System.Drawing.SystemColors.Control;
            this.btn_MakeOneReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_MakeOneReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_MakeOneReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_MakeOneReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MakeOneReport.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_MakeOneReport.Location = new System.Drawing.Point(151, 115);
            this.btn_MakeOneReport.Name = "btn_MakeOneReport";
            this.btn_MakeOneReport.Size = new System.Drawing.Size(126, 29);
            this.btn_MakeOneReport.TabIndex = 0;
            this.btn_MakeOneReport.Text = "Преобразовать";
            this.btn_MakeOneReport.UseVisualStyleBackColor = false;
            this.btn_MakeOneReport.Click += new System.EventHandler(this.btn_MakeOneReport_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 213);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(227, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "запускать приложение в скрытом виде";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lbl_StatusText
            // 
            this.lbl_StatusText.AutoEllipsis = true;
            this.lbl_StatusText.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_StatusText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_StatusText.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_StatusText.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_StatusText.Location = new System.Drawing.Point(20, 179);
            this.lbl_StatusText.Name = "lbl_StatusText";
            this.lbl_StatusText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_StatusText.Size = new System.Drawing.Size(563, 51);
            this.lbl_StatusText.TabIndex = 9;
            this.lbl_StatusText.Text = "Тут будет имя преобразованного файла";
            this.lbl_StatusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_OpenReport
            // 
            this.btn_OpenReport.BackColor = System.Drawing.SystemColors.Control;
            this.btn_OpenReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_OpenReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_OpenReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_OpenReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenReport.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_OpenReport.Location = new System.Drawing.Point(543, 190);
            this.btn_OpenReport.Name = "btn_OpenReport";
            this.btn_OpenReport.Size = new System.Drawing.Size(118, 37);
            this.btn_OpenReport.TabIndex = 10;
            this.btn_OpenReport.Text = "Показать в папке";
            this.btn_OpenReport.UseVisualStyleBackColor = false;
            this.btn_OpenReport.Click += new System.EventHandler(this.btn_OpenReport_click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(28, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 23);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Siemens";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(313, 11);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 23);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Emicon";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(19, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 42);
            this.panel1.TabIndex = 13;
            // 
            // btn_SelectFolder
            // 
            this.btn_SelectFolder.BackColor = System.Drawing.SystemColors.Control;
            this.btn_SelectFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SelectFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SelectFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_SelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectFolder.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectFolder.Location = new System.Drawing.Point(18, 42);
            this.btn_SelectFolder.Name = "btn_SelectFolder";
            this.btn_SelectFolder.Size = new System.Drawing.Size(127, 32);
            this.btn_SelectFolder.TabIndex = 0;
            this.btn_SelectFolder.Text = "Выберите папку";
            this.btn_SelectFolder.UseVisualStyleBackColor = false;
            // 
            // listBox_AllFile
            // 
            this.listBox_AllFile.AllowDrop = true;
            this.listBox_AllFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.listBox_AllFile.FormattingEnabled = true;
            this.listBox_AllFile.ItemHeight = 15;
            this.listBox_AllFile.Location = new System.Drawing.Point(19, 233);
            this.listBox_AllFile.Name = "listBox_AllFile";
            this.listBox_AllFile.Size = new System.Drawing.Size(518, 154);
            this.listBox_AllFile.TabIndex = 14;
            this.listBox_AllFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox_AllFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            // 
            // btn_formHeigth
            // 
            this.btn_formHeigth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_formHeigth.BackColor = System.Drawing.SystemColors.Control;
            this.btn_formHeigth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_formHeigth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_formHeigth.Image = global::CSV_TXT_to_XLS.Properties.Resources.arrow_down;
            this.btn_formHeigth.Location = new System.Drawing.Point(288, 219);
            this.btn_formHeigth.Name = "btn_formHeigth";
            this.btn_formHeigth.Size = new System.Drawing.Size(73, 10);
            this.btn_formHeigth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_formHeigth.TabIndex = 15;
            this.btn_formHeigth.TabStop = false;
            // 
            // btn_MakeReportAllFile
            // 
            this.btn_MakeReportAllFile.BackColor = System.Drawing.SystemColors.Control;
            this.btn_MakeReportAllFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_MakeReportAllFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_MakeReportAllFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_MakeReportAllFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MakeReportAllFile.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_MakeReportAllFile.Location = new System.Drawing.Point(542, 233);
            this.btn_MakeReportAllFile.Name = "btn_MakeReportAllFile";
            this.btn_MakeReportAllFile.Size = new System.Drawing.Size(118, 155);
            this.btn_MakeReportAllFile.TabIndex = 0;
            this.btn_MakeReportAllFile.Text = "Преобразовать";
            this.btn_MakeReportAllFile.UseVisualStyleBackColor = false;
            this.btn_MakeReportAllFile.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_ControlWatcher
            // 
            this.btn_ControlWatcher.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ControlWatcher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ControlWatcher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ControlWatcher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_ControlWatcher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ControlWatcher.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ControlWatcher.Location = new System.Drawing.Point(151, 42);
            this.btn_ControlWatcher.Name = "btn_ControlWatcher";
            this.btn_ControlWatcher.Size = new System.Drawing.Size(126, 32);
            this.btn_ControlWatcher.TabIndex = 0;
            this.btn_ControlWatcher.Text = "Стоп";
            this.btn_ControlWatcher.UseVisualStyleBackColor = false;
            this.btn_ControlWatcher.Click += new System.EventHandler(this.btn_ControlWatcher_Click);
            // 
            // lb_statusWatcher
            // 
            this.lb_statusWatcher.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_statusWatcher.ForeColor = System.Drawing.Color.OrangeRed;
            this.lb_statusWatcher.Location = new System.Drawing.Point(378, 43);
            this.lb_statusWatcher.Name = "lb_statusWatcher";
            this.lb_statusWatcher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_statusWatcher.Size = new System.Drawing.Size(282, 31);
            this.lb_statusWatcher.TabIndex = 9;
            this.lb_statusWatcher.Text = "Отслеживание остановлено";
            this.lb_statusWatcher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(669, 232);
            this.Controls.Add(this.btn_formHeigth);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_ControlWatcher);
            this.Controls.Add(this.btn_SelectFolder);
            this.Controls.Add(this.btn_FindFile);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_OpenReport);
            this.Controls.Add(this.TxtB_FileOriginal);
            this.Controls.Add(this.lb_statusWatcher);
            this.Controls.Add(this.lbl_StatusText);
            this.Controls.Add(this.txtB_FolderForWatcher);
            this.Controls.Add(this.btn_MakeReportAllFile);
            this.Controls.Add(this.btn_MakeOneReport);
            this.Controls.Add(this.listBox_AllFile);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.Text = "CSV_TXT_to XLS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_formHeigth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_FindFile;
        private System.Windows.Forms.TextBox txtB_FolderForWatcher;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox TxtB_FileOriginal;
        private System.Windows.Forms.Button btn_MakeOneReport;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lbl_StatusText;
        private System.Windows.Forms.Button btn_OpenReport;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_SelectFolder;
        private System.Windows.Forms.ListBox listBox_AllFile;
        private System.Windows.Forms.PictureBox btn_formHeigth;
        private System.Windows.Forms.Button btn_MakeReportAllFile;
        private System.Windows.Forms.Button btn_ControlWatcher;
        private System.Windows.Forms.Label lb_statusWatcher;
    }
}

