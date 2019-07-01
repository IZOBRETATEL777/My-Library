
using System;
using System.IO;
namespace My_Library
{
    class Parametrs
    {
        ~Parametrs() { }
        public int startRow = 1;
        public int BookNameRow = 0;
        public int AuthorRow = 1;
        public int GenreRow = 2;
        public int InLibraryRow = 5;
        private static string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        public static string directoryPath = Path.Combine(appDataPath, "MyLibrary");
        public string path = Path.Combine(directoryPath, Path.GetFileName("Data.xlsx"));


        public string[] header = new string[] {
            "Название книги",
            "Автор",
            "Жанр",
            "Серия",
            "Год",
            "В наличии",
            };

        public int ColumsCnt = 6;
    }
}
