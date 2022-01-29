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
                Expected = 0,

            };
            TestNumber(testCase1);
            var testCase2 = new TestCase()
            {
                NUMBER = 5,
                Expected = 0,

            };
            TestNumber(testCase2);

            Console.ReadLine();

        }
        static void TestNumber(TestCase testCase)
        {

            var actual = CheckNumber(testCase.NUMBER);

            
            if (actual == testCase.Expected)
            {
                Console.WriteLine("действительный тест");
            }
            else
            {
                Console.WriteLine("недействительный тест");
            }
        }

        static int CheckNumber(int number)
        {
            int d = 0;
            int i = 2;

            if (i<=number)
            {
                if (number%i==0)
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
            return number;
            

        }
    }
}
