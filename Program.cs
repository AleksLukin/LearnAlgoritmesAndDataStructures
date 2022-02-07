using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlgoritmesAndDataStructures
{
    class Program
    {
        internal class TestCase
        {

            public int Expected { get; set; }
            public int NUMBER { get; set; }

        }
        /// <summary>
        /// Случаи для проверки тестов к методам "CheckNumber", "FibonacchiCycle" и "FibonacchiRequersion"
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задачи - {0}, {1} или {2}", 1, 3,5);
            int inputNumberTask = int.Parse(Console.ReadLine());
            if (inputNumberTask == 1)
            {
                var testCase1 = new TestCase()
                {
                    NUMBER = 4,
                    Expected = 1,

                };
                TestCheckNumber(testCase1);
                var testCase2 = new TestCase()
                {
                    NUMBER = 5,
                    Expected = 1,

                };
                TestCheckNumber(testCase2);

            }
            else if(inputNumberTask==3)
            {
                var testCase3 = new TestCase()
                {
                    NUMBER = 4,
                    Expected = 3,

                };

                TestNumberFiboCycle(testCase3);
                var testCase4 = new TestCase()
                {
                    NUMBER = 5,
                    Expected = 1,

                };
                TestNumberFiboReq(testCase4);
            }
            else if (inputNumberTask==5)
            {
                BinarySearch(new int[] { 1, 2, 3 }, 3);
            }

            Console.ReadLine();

        }
        /// <summary>
        /// Тесты к методам "CheckNumber", "FibonacchiCycle" и "FibonacchiRequersion"
        /// </summary>
        /// <param name="testCase"></param>
        static void TestCheckNumber(TestCase testCase)
        {

            var actual = CheckNumber(testCase.NUMBER);

            if (actual == testCase.Expected)
            {
                Console.WriteLine("Задача 1: " + "недействительный тест");
            }
            else
            {
                Console.WriteLine("Задача 1: " + "действительный тест");
            }
        }
        static void TestNumberFiboCycle(TestCase testCase)
        {

            var actual = FibonacchiCycle(testCase.NUMBER);

            if (actual == testCase.Expected)
            {
                Console.WriteLine("Задача 3: " + "действительный тест");
            }
            else
            {
                Console.WriteLine("Задача 3: " + "недействительный тест");
            }
        }
        static void TestNumberFiboReq(TestCase testCase)
        {
            var actual = FibonacchiRequersion(testCase.NUMBER);

            if (actual == testCase.Expected)
            {
                Console.WriteLine("Задача 3: " + "действительный тест");
            }
            else
            {
                Console.WriteLine("Задача 3: " + "недействительный тест");
            }
        }
        /// <summary>
        /// Код для проверки числа - простое или нет (нет - т.е. делится на себя и на 2)
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int CheckNumber(int number)
        {
            int d = 0;
            int i = 2;

            if (i <= number)
            {
                if (number % i == 0)
                {
                    d++;
                }
                else
                {
                    i++;
                }

            }
            if (d == 0)
            {
                Console.WriteLine(number + " - простое число");
            }
            else
            {
                Console.WriteLine(number + " - непростое число");

            }
            return d;
        }
        /// <summary>
        /// Код для вычисления числа Фибоначчи с помощью цикла
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int FibonacchiCycle(int number)
        {

            int inc = 1;
            int result = 0;

            for (int i = 0; i < number; i++)
            {
                int temp = result;
                result = inc;
                inc += temp;
            }

            return result;

        }
        /// <summary>
        /// Код для вычисления числа Фибоначчи с помощью рекурсии
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int FibonacchiRequersion(int n)
        {
            if (n == 1 || n == 0)
            {
                return n;
            }
            int numberFibonacchi = FibonacchiRequersion(n - 1) + FibonacchiRequersion(n - 2);


            return numberFibonacchi;
        }
        public static void BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    Console.WriteLine("Индекс числа {0} в массиве {1} равен {2}",3,inputArray,mid);
                    break;
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
        }
    }
}

    
    

