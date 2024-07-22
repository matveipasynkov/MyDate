using System;
namespace LibraryOfMethods
{
    /// <summary>
    /// Класс, в котором мы храним различные виды сортировок, а также дополнительные к ним методы.
    /// </summary>
	public static class Sortings
	{
        /// <summary>
        /// В данном методе реализован алгоритм сортировки пузырьком.
        /// </summary>
        /// <param name="allData"></param>
        public static void BubbleSort(ref string[,] allData)
        {
            bool flag = true;

            while (flag)
            {
                flag = false;

                for (int i = 0; i < allData.GetLength(0) - 1; ++i)
                {
                    if (String.Compare(allData[i, 0], allData[i + 1, 0]) > 0)
                    {
                        Swap(ref allData, i, i + 1);

                        flag = true;
                    }
                }
            }
        }

        /// <summary>
        /// В данном методе реализован алгоритм сортировки вставками.
        /// </summary>
        /// <param name="allData"></param>
        public static void InsertionSort(ref string[,] allData)
        {
            for (int i = 1; i < allData.GetLength(0); ++i)
            {
                for (int j = i; j > 0; --j)
                {
                    if (String.Compare(allData[j - 1, 0], allData[j, 0]) > 0)
                    {
                        Swap(ref allData, j - 1, j);
                    }
                }
            }
        }

        /// <summary>
        /// В данном методе реализован алгоритм сортировки выбором.
        /// </summary>
        /// <param name="allData"></param>
        public static void SelectionSort(ref string[,] allData)
        {
            for (int i = 0; i < allData.GetLength(0) - 1; ++i)
            {
                string minimum = allData[i, 0];
                int indexOfMinimum = i;

                for (int j = i; j < allData.GetLength(0); ++j)
                {
                    if (String.Compare(allData[j, 0], minimum) < 0)
                    {
                        minimum = allData[j, 0];
                        indexOfMinimum = j;
                    }
                }

                for (int j = indexOfMinimum; j > i; --j)
                {
                    Swap(ref allData, j - 1, j);
                }
            }
        }

        /// <summary>
        /// В данном методе мы меняем две строки изначального массива местами.
        /// </summary>
        /// <param name="allData"></param>
        /// <param name="index_1"></param>
        /// <param name="index_2"></param>
        public static void Swap(ref string[,] allData, int index_1, int index_2)
        {
            string[] tmp = { allData[index_1, 0], allData[index_1, 1] };

            allData[index_1, 0] = allData[index_2, 0];
            allData[index_1, 1] = allData[index_2, 1];

            allData[index_2, 0] = tmp[0];
            allData[index_2, 1] = tmp[1];
        }
    }
}