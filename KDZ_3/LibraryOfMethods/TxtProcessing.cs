using System;
using System.IO;

namespace LibraryOfMethods
{
    /// <summary>
    /// В данном классе мы обрабатываем входные и выходные файлы.
    /// </summary>
    public static class TxtProcessing
    {
        /// <summary>
        /// В данном методе мы считываем файл.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string[] ReadFile()
        {
            string path;
            string[] lines = { };

            Console.Write("Введите название входного файла (файл должен быть формата .txt; .txt вводить в название файла не нужно): ");
            path = Console.ReadLine();

            try
            {
                lines = File.ReadAllLines(path + ".txt");
            }
            catch
            {
                // В случае, если название файла некорректно, то мы будем считать это за ошибку аргумента, а значит мы будем вызывать ArgumentException.
                throw new ArgumentException();
            }

            return lines;
        }

        /// <summary>
        /// В данном методе мы сохраняем данные в файл.
        /// </summary>
        /// <param name="lines"></param>
        /// <param name="allData"></param>
        /// <param name="lengthOfAllData"></param>
        public static void WriteFile(string[] lines, string[,] allData, int lengthOfAllData)
        {
            bool flag = true;

            while (flag)
            {
                Console.Write("Введите название выходного файла (файл должен быть формата .txt; .txt вводить в название файла не нужно): ");
                string path = Console.ReadLine();
                path += ".txt";

                try
                {
                    File.WriteAllLines(path, lines);
                    File.AppendAllText(path, "\n");
                    File.AppendAllText(path, "Date Event\n");

                    for (int i = 0; i < lengthOfAllData; ++i)
                    {
                        if (allData[i, 0] == "N/A")
                        {
                            File.AppendAllText(path, "N/A\n");
                        }
                        else
                        {
                            File.AppendAllText(path, $"{allData[i, 0]} {allData[i, 1]}\n");
                        }
                    }

                    flag = false;
                }
                catch
                {
                    Console.Write("Указано неверное название файла. Попробуйте ещё раз. ");
                }
            }
        }
	}
}