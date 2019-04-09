using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PrimeNumber
    {
        public static void Main(String[] arg)
        {
            Console.WriteLine("Enter the number");
            int number=int.Parse(Console.ReadLine());
            int count = 0;
            for (int range=2;range<=number/2;range++)
            {
               
                if (number % range == 0)
                        count++;
            }
            if (count == 0)
                Console.WriteLine($"given number {number} is prime");
            else
                Console.WriteLine($"given number {number}  is not prime");
            Console.ReadLine();

        }
    }
}
