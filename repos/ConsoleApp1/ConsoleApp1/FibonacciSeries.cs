using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FibonacciSeries
    {
        public static void Main (String[] args)
        {
            Console.WriteLine("Enter the range to print fibonacci series");
            int range = int.Parse(Console.ReadLine());
            int fib1 = 0;
            int fib2 = 1;
            Console.WriteLine(fib1);
            Console.WriteLine(fib2);
               while(range>2)
            {
                int fib3 = fib1 + fib2;
                fib1 = fib2;
                fib2 = fib3;
                Console.WriteLine(fib3);

                range--;
            }
            Console.Read();
            
        }
    }
}
