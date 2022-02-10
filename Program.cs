using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
  

namespace LearnAlgoritmesAndDataStructures
{
    public class PointClass
    {
        public float X;
        public float Y;
    }
    public struct PointStruct
    {
        public float X;
        public float Y;
    }
    public struct PointDouble
    {
        public double X;
        public double Y;
    }
    public struct PointStructDouble
    {
        public double X;
        public double Y;
    }
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
            Console.WriteLine("Введите номер задачи - {0}, {1},{2} или {3}", 1, 3, 5, 6);
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
            else if (inputNumberTask == 3)
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
            else if (inputNumberTask == 5)
            {
                BinarySearch(new int[] { 1, 2, 3 }, 3);
            }
            else if (inputNumberTask == 6)
            {
                BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
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
        /// <summary>
        /// Осуществляет бинарный поиск в массиве
        /// </summary>
        /// <param name="inputArray"></param>
        /// <param name="searchValue"></param>
        public static void BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    Console.WriteLine("Индекс числа {0} в массиве {1} равен {2}", 3, inputArray, mid);
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
        public class BechmarkClass
        {
            PointClass a = new PointClass();
            PointClass b = new PointClass();

            PointStruct a1 = new PointStruct();
            PointStruct b1 = new PointStruct();

            PointStructDouble a2 = new PointStructDouble();
            PointStructDouble b2 = new PointStructDouble();

            public float DistanceRef(PointClass pointClass1, PointClass pointClass2)
            {
                float X = pointClass1.X - pointClass2.X;
                float Y = pointClass2.Y - pointClass2.Y;
                return (float)Math.Sqrt((X * X) + (Y * Y));
            }
            public float DistanceVal(PointStruct pointStruct1, PointStruct pointStruct2)
            {
                float X = pointStruct1.X - pointStruct2.X;
                float Y = pointStruct1.Y - pointStruct2.Y;
                return (float)Math.Sqrt((X * X) + (Y * Y));
            }
            public double DistanceValDouble(PointStructDouble pointStructDouble1, PointStructDouble pointStructDouble2)
            {
                double X = pointStructDouble1.X - pointStructDouble2.X;
                double Y = pointStructDouble1.Y - pointStructDouble2.Y;
                return Math.Sqrt((X * X) + (Y * Y));
            }
            public float DistanceValShort(PointStruct pointStruct1, PointStruct pointStruct2)
            {
                float X = pointStruct1.X - pointStruct2.X;
                float Y = pointStruct1.Y - pointStruct2.Y;
                return (X * X) + (Y * Y);
            }

            [Benchmark]
            public void Test1()
            {
                DistanceRef(a, b);
            }
            [Benchmark]
            public void Test2()
            {
                DistanceVal(a1, b1);
            }
            [Benchmark]
            public void Test3()
            {
                DistanceValDouble(a2, b2);
            }
            [Benchmark]
            public void Test4()
            {
                DistanceValShort(a1, b1);
            }
        }
    }
}

    
    

