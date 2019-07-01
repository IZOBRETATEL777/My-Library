using System;


namespace My_Library
{
    class FormatInput : Parametrs
    {
        public string[] format(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (i == AuthorRow || i == GenreRow)
                {
                    string[] line = input[i].Split(' ');
                    Array.Sort(line, StringComparer.InvariantCulture);
                    input[i] = "";
                    for (int j = 0; j < line.Length; j++)
                        input[i] += line[j] + (j == line.Length - 1 ? "" : " ");
                }
                if(i == InLibraryRow)
                {
                    input[i].ToLower();
                    if (input[i] == "" || input[i] == "нет" || input[i] == "-")
                        input[i] = "Нет";
                    else
                        input[i] = "Да";
                }

            }
            return input;
        }
    }
}
