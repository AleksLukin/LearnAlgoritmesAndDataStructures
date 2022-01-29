using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlgoritmesAndDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = 38;
            CheckNumber(randomNumber);
            

            Console.ReadLine();
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
                i++;
            }
            if (d==0)
            {
                Console.WriteLine(number+" - простое число");
            }
            else
            {
                Console.WriteLine(number + " - непростое число");                    
            }
            return number;

        }
    }
}
