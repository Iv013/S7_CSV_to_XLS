using OfficeOpenXml.Style;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;

namespace CSV_TXT_to_XLS
{
    public abstract class AbstractReport
    {
        public string stateReport { get; set; }
        public delegate void Method( string str);
        public event Method SetState = null;
        private int MaxColomnInDocument;
        public async void MakeReport(List<string> ListFile)
        {
            await Task.Run(() =>   
            {
                SetState("Идет формирование файла");
                var tempResult = GetPrimarySheet(ListFile);

                CreateExcelDocument(GetNewNameExcelFile(ListFile[0]),
                    new ExcelWorksheet[]
                    { tempResult.Item1, 
                      GetSortSheetRepeatedMessage(tempResult.Item2) 
                    });
                SetState(GetNewNameExcelFile(ListFile[0]));
            });
        }
        public abstract string[] GetArrayString(string line);


        void CreateExcelDocument(string nameDoc, ExcelWorksheet[] sheets)
        {
            var Document = new ExcelPackage();
            foreach (var sheet in sheets)
            {
                Document.Workbook.Worksheets.Add(sheet.Name, sheet);
            }

           File.WriteAllBytes(nameDoc, Document.GetAsByteArray()) ;
        }

        private (ExcelWorksheet, List<string>) GetPrimarySheet(List<string> ListFile)
        {
            StringBuilder line = new StringBuilder();
            var sheet = new ExcelPackage().Workbook.Worksheets.Add("Журнал сообщений");
            int numberLine = 0;
            var listMessages = new List<string>();
            for (int fileNumber = 0; fileNumber < ListFile.Count; fileNumber++)
            {
                if (!File.Exists(ListFile[fileNumber].ToString())) continue;
                using (StreamReader streamReader = new StreamReader(ListFile[fileNumber].ToString(),
                    Encoding.GetEncoding(1251)))
                {
                    line.Append(streamReader.ReadLine());
                    int i = 1;
                    int columnNumberWithMessage = 3;
                    while (line.Length > 0)
                    {
                        string[] dat = GetArrayString(line.ToString());
                        MaxColomnInDocument = dat.Length;
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

                        SetColorCells(sheet, numberLine + i, line.ToString());
                        listMessages.Add(dat[columnNumberWithMessage - 1]);
                        line.Clear();
                        line.Append(streamReader.ReadLine());
                        i++;
                    }
                }

                numberLine = listMessages.Count;
            }

            SetBorderCells(sheet, listMessages.Count(), MaxColomnInDocument);
            return (sheet, listMessages);
        }




        private string GetNewNameExcelFile(string OldFile) =>
            OldFile.Replace(Path.GetExtension(OldFile), ".xlsx");
    

        private void SetBorderCells( ExcelWorksheet sheet, int endRow, int endColumn)
        {
            var border = sheet.Cells[1, 1, endRow, endColumn].Style.Border;
            //border.Bottom.Style = ExcelBorderStyle.Thin;
            //border.Top.Style = ExcelBorderStyle.Thin;
            //border.Left.Style = ExcelBorderStyle.Thin;
            //border.Right.Style = ExcelBorderStyle.Thin;\
            sheet.Cells[1, 1, endRow, endColumn].Style.Border.BorderAround(ExcelBorderStyle.Thin);
        }

        private void SetColorCells( ExcelWorksheet sheet,  int StartFieald,  string message )
        {
            var cellsfill = sheet.Cells[StartFieald, 1, StartFieald, GetArrayString(message).Count()].Style.Fill;
            cellsfill.PatternType = ExcelFillStyle.Solid;
            cellsfill.BackgroundColor.SetColor(GetColor(message));
        }


       public abstract Color GetColor(string line);
       
        private ExcelWorksheet GetSortSheetRepeatedMessage(List<string> list)
        {
            var newlist = list.GroupBy(x => x)
                .Where(x => x.Count() > 1)
                .OrderByDescending(x => x.Count())
                .Select(x => (x.Count().ToString(), x.Key));

            var sheet2 = new ExcelPackage().Workbook.Worksheets.Add("Sort");
            sheet2.Cells[1, 1].Value = "Количество сообщений";
            sheet2.Cells[1, 2].Value = "Текст  сообщения";
            sheet2.Cells[2, 1].LoadFromCollection(newlist.Select(x => x.Item1));
            sheet2.Cells[2, 2].LoadFromCollection(newlist.Select(x => x.Item2));
            return sheet2;
        }

    }
}
