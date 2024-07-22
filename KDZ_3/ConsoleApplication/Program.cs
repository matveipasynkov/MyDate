// Пасынков Матвей Евгеньевич БПИ237-2 Вариант 5.
using LibraryOfMethods;

class Program
{
    static void Main()
    {
        do
        {
            Console.Clear();

            try
            {
                string[] lines = TxtProcessing.ReadFile();

                MyDate[] myDates = new MyDate[lines.Length];
                int lengthOfAllData = 0;

                // В данном цикле мы сохраняем полученные из входного файла данные в массив типа MyDate[], параллельно подсчитывая общее количество событий, что упростит нам создание allData.
                for (int i = 0; i < myDates.Length; ++i)
                {
                    myDates[i] = new MyDate(lines[i]);
                    lengthOfAllData += myDates[i].Events.Length;
                }

                string[,] allData = Tools.MakeAllData(myDates, lengthOfAllData);

                // В качестве альтернативного решения можно рассмотреть различные виды других сортировок: InsertionSort, SelectionSort. Их реализация хранится в классе Sortings.
                Sortings.BubbleSort(ref allData);

                TxtProcessing.WriteFile(lines, allData, lengthOfAllData);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Неверное название файла.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Возникла непредвиденная ошибка. Наиболее вероятно неверный формат файла.");
            }
            finally
            {
                Console.WriteLine("Нажмите ESC, чтобы продолжить работу программы. Иначе нажмите любую другую кнопку.");
            }
        }
        while (Console.ReadKey().Key == ConsoleKey.Escape);
    }
}