using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Packaging;
using System.Security.Cryptography;


namespace CSV_TXT_to_XLS
{
    public abstract class AbstractReport
    {
        public string stateReport { get; set; }
        public delegate void Method( string str);
        public event Method SetState = null;
        public async void MakeReport(List<string> ListFile)
        {
            await Task.Run(() =>   
            {
                SetState("Идет формирование файла");
                StringBuilder line = new StringBuilder();                                                                           
                var package = new ExcelPackage();
                var sheet = package.Workbook.Worksheets.Add("Журнал сообщений");  
                int numberLine = 0, MaxColomn=0;
                var listMessages = new List<string>();
                for (int fileNumber = 0; fileNumber < ListFile.Count; fileNumber++)
                {
                    if (!File.Exists(ListFile[fileNumber].ToString())) continue;
                    using (StreamReader streamReader = new StreamReader(ListFile[fileNumber].ToString(), Encoding.GetEncoding(1251)))
                    {
                        line.Append(streamReader.ReadLine());
                        int i = 1;
                        int columnNumberWithMessage = 3;
                        while (line.Length > 0)
                        {
                            string[] dat = GetArrayString(line.ToString());
                            MaxColomn = dat.Length;
                            for (int j = 1; j <= dat.Length; j++)
                            {
                                if (dat[j - 1].Contains("Текст сообщения"))
                                {
                                    columnNumberWithMessage = j;
                                    continue;
                                }

                                sheet.Column(j).Width = (sheet.Column(j).Width < dat[j - 1].Length) ? dat[j - 1].Length : sheet.Column(j).Width;
                                sheet.Cells[i + numberLine, j].Value = dat[j - 1];
                            }

                            SetColorCells( sheet, numberLine + i, MaxColomn, line.ToString());
                            listMessages.Add(dat[columnNumberWithMessage - 1]);
                            line.Clear();
                            line.Append(streamReader.ReadLine());
                            i++;
                        }
                    }
         
                    numberLine = listMessages.Count;
                }

                SetBorderCells(sheet, listMessages.Count(), MaxColomn);
                string extension = Path.GetExtension(ListFile[0].ToString());
                package.Workbook.Worksheets.Add("Cортировка", GetSortSheetRepeatedMessage(listMessages));
                sheet.Protection.IsProtected = false;          
                File.WriteAllBytes(ListFile[0].ToString().Replace(extension, ".xlsx"), package.GetAsByteArray());
                SetState(ListFile[0].ToString().Replace(extension, ".xlsx"));
            });
        }
        public abstract string[] GetArrayString(string line);

        private void SetBorderCells( ExcelWorksheet sheet, int endRow, int endColumn)
        {
            sheet.Cells[1, 1, endRow, endColumn].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            sheet.Cells[1, 1, endRow, endColumn].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            sheet.Cells[1, 1, endRow, endColumn].Style.Border.Left.Style = ExcelBorderStyle.Thin;
            sheet.Cells[1, 1, endRow, endColumn].Style.Border.Right.Style = ExcelBorderStyle.Thin;
        }

        private void SetColorCells( ExcelWorksheet sheet,  int StartFieald, int endFeald, string message )
        {
            var Color= GetColor(message);
            sheet.Cells[StartFieald, 1, StartFieald, endFeald].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet.Cells[StartFieald, 1, StartFieald, endFeald].Style.Fill.BackgroundColor.SetColor(Color);
        }


       public abstract Color GetColor(string line);
       


        private ExcelWorksheet GetSortSheetRepeatedMessage(List<string> list)
        {
            var newlist = list.GroupBy(x => x)
                .Where(x => x.Count() > 1)
                .OrderByDescending(x => x.Count())
                .Select(x => (x.Count().ToString(), x.Key));
            var package = new ExcelPackage();
            var sheet2 = package.Workbook.Worksheets.Add("Sort");
            sheet2.Cells[1, 1].Value = "Количество сообщений";
            sheet2.Cells[1, 2].Value = "Текст  сообщения";
            sheet2.Cells[2, 1].LoadFromCollection(newlist.Select(x => x.Item1));
            sheet2.Cells[2, 2].LoadFromCollection(newlist.Select(x => x.Item2));

            return sheet2;
        }

    }
}
