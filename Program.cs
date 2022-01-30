using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlgoritmesAndDataStructures
{
    class Program
    {
        public class TestCase
        {

            public int Expected { get; set; }
            public int NUMBER { get; set; }

        }

        static void Main(string[] args)
        {

            var testCase1 = new TestCase()
            {
                NUMBER = 4,
                Expected = 3,

            };
            TestNumberFiboCycle(testCase1);
            var testCase2 = new TestCase()
            {
                NUMBER = 5,
                Expected = 1,

            };
            TestNumberFiboReq(testCase2);

            Console.ReadLine();

        }
        static void TestNumberFiboCycle(TestCase testCase)
        {

            var actual = FibonacchiCycle(testCase.NUMBER);

            if (actual == testCase.Expected)
            {
                Console.WriteLine("действительный тест");
            }
            else
            {
                Console.WriteLine("недействительный тест");
            }
        }
        static void TestNumberFiboReq(TestCase testCase)
        {
            var actual = FibonacchiRequersion(testCase.NUMBER);

            if (actual==testCase.Expected)
            {
                Console.WriteLine("действительный тест");
            }
            else
            {
                Console.WriteLine("недействительный тест");
            }
        }

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
        static int FibonacchiRequersion(int n)
        {
            if (n == 1 || n == 0)
            {
                return n;
            }
            int numberFibonacchi = FibonacchiRequersion(n - 1) + FibonacchiRequersion(n - 2);

            
            return numberFibonacchi;
        }
    }
}
