using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
namespace My_Library
{
    class NPOImethods : Parametrs
    {
        ~NPOImethods() { }
        public void Add(string[] book)
        {
            IWorkbook workbook;
            FileStream oldFile = new FileStream(path, FileMode.Open, FileAccess.Read);
            workbook = new XSSFWorkbook(oldFile);
            ISheet sheet = workbook.GetSheetAt(0);
            int currentRow = startRow;
            while (sheet.GetRow(currentRow) != null)
                currentRow++;
            IRow row = sheet.CreateRow(currentRow);

            for (int i = 0; i < ColumsCnt; i++)
            {
                row.CreateCell(i).SetCellValue(book[i]);
                sheet.AutoSizeColumn(i);
            }
            oldFile.Close();
            FileStream newFile = new FileStream(path, FileMode.Create, FileAccess.Write);
            workbook.Write(newFile);
            newFile.Close();
        }
        public void CreateBlank()
        {
            if (Directory.Exists(directoryPath) == false)
                Directory.CreateDirectory(directoryPath);
            IWorkbook workbook = new XSSFWorkbook();

            ISheet sheet = workbook.CreateSheet("Список книг");
            ICellStyle style3 = workbook.CreateCellStyle();
            style3.FillForegroundColor = IndexedColors.Lime.Index;
            style3.FillPattern = FillPattern.LessDots;
            style3.FillBackgroundColor = IndexedColors.LightGreen.Index;
            sheet.CreateRow(0);
            for (int i = 0; i < ColumsCnt; i++)
            {
                sheet.GetRow(0).CreateCell(i).CellStyle = style3;
                sheet.GetRow(0).GetCell(i).SetCellValue(header[i]);
                sheet.AutoSizeColumn(i);
            }
            FileStream file = File.Create(path);
            workbook.Write(file);
            file.Close();
        }

        public void GetStringArray(List<string[]> currenntRow)
        {
            IWorkbook workbook;
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            workbook = new XSSFWorkbook(fs);
            IRow row;
            int i = startRow;
            string[] temp;
            while (workbook.GetSheetAt(0).GetRow(i) != null)
            {
                temp = new string[ColumsCnt];
                row = workbook.GetSheetAt(0).GetRow(i);
                for (int j = 0; j < ColumsCnt; j++)
                    temp[j] = row.GetCell(j).ToString();
                currenntRow.Add(temp);
                i++;

            }
            fs.Close();
        }

        public HashSet<int> SearchElement(List<string> keys)
        {
            HashSet<int> pos = new HashSet<int>();
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            IWorkbook workbook = new XSSFWorkbook(file);
            ISheet sheet = workbook.GetSheetAt(0);

            foreach (string key in keys)
            {
                int rowIndex = startRow;
                key.ToLower();
                while(sheet.GetRow(rowIndex) != null)
                {
                    IRow row = sheet.GetRow(rowIndex);
                    string place = "";
                    for (int i = 0; i < ColumsCnt; i++)
                        place += row.GetCell(i).ToString();
                        place.ToLower();
                    if (place.Contains(key))
                        pos.Add(rowIndex);
                    rowIndex++;
                }
            }
            file.Close();
            return pos;
        }
        public string[] GetRowByIndex(int rowIndex)
        {
            string[] currentRow = new string[ColumsCnt];
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            IWorkbook workbook = new XSSFWorkbook(file);
            IRow row = workbook.GetSheetAt(0).GetRow(rowIndex);
            for (int i = 0; i < ColumsCnt; i++)
                currentRow[i] = row.GetCell(i).ToString();
            file.Close();
            return currentRow;
        }
        public void SetNewValueInRow(string[] book, int rowIndex)
        {
            IWorkbook workbook;
            FileStream oldFile = new FileStream(path, FileMode.Open, FileAccess.Read);
            workbook = new XSSFWorkbook(oldFile);
            ISheet sheet = workbook.GetSheetAt(0);
            IRow row = sheet.GetRow(rowIndex);
            for (int i = 0; i < book.Length; i++)
            {
                row.GetCell(i).SetCellValue(book[i]);
                sheet.AutoSizeColumn(i);
            }
            oldFile.Close();
            FileStream newFile = new FileStream(path, FileMode.Create, FileAccess.Write);
            workbook.Write(newFile);
            newFile.Close();
        }
    }
}
