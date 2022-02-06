using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlgoritmesAndDataStructures
{
    /// <summary>
    /// Вторая задача - бинарный поиск. Стоимость равна О(N).
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearch(new int[] { 1, 2, 3, 4, 5, 6 }, 5);

            Console.ReadLine();
        }
        public static int BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
                

            }
            return -1;
        }
    }
}
/*Требуется написать функцию бинарного поиска, посчитать его асимптотическую сложность и
проверить работоспособность функции.*/





