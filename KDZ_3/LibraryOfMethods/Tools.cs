using System;
namespace LibraryOfMethods
{
    /// <summary>
    /// Tools - класс, в котором содержатся методы для создания новых массивов из массива типа MyDate[].
    /// </summary>
	public static class Tools
	{
        /// <summary>
        /// Метод, возвращающий новый массив string[,], в котором содержатся все данные о событиях из массива типа MyDate[].
        /// </summary>
        /// <param name="myDates"></param>
        /// <param name="lengthOfAllData"></param>
        /// <returns></returns>
        public static string[,] MakeAllData(MyDate[] myDates, int lengthOfAllData)
        {
            string[,] allData = new string[lengthOfAllData, 2];
            string[] events;
            DateTime[] dates;
            int index = 0;

            for (int i = 0; i < myDates.Length; ++i)
            {
                events = myDates[i].Events;
                dates = myDates[i].Dates;

                for (int j = 0; j < events.Length; ++j)
                {
                    if (events[j] == "N/A")
                    {
                        allData[index, 0] = "N/A";
                        allData[index, 1] = "N/A";
                    }
                    else
                    {
                        allData[index, 0] = $"{dates[j].Year}-{dates[j].Month}-{dates[j].Day}";
                        allData[index, 1] = events[j];
                    }

                    ++index;
                }
            }

            return allData;
        }
    }
}