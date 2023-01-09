using System;
using System.Windows.Forms;
using System.Threading;


namespace CSV_TXT_to_XLS
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

         Application.ThreadException += new ThreadExceptionEventHandler(Exception1);

            Application.Run(new Form1());
            
        }
        
        static void Exception1(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
           MessageBox.Show(e.Exception.ToString());
        }
    }

}
