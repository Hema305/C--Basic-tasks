using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int number = int.Parse(Console.ReadLine());
            int factorialValue = fact(number);
            Console.WriteLine(factorialValue);
            Console.ReadKey();
        }
       static int fact(int i)
        {
            if (i == 0 || i == 1)
                return 1;
            else
                return i * fact(i - 1);

            
        }
    }
}
