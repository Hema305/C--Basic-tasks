using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Perfect
    {
        static void Main(String[] args)
        {
            Console.WriteLine("enter a number");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i=1;i<number;i++)
            {
                if (number % i == 0)
                    sum += i;
            
            }
            if (sum == number)
                Console.WriteLine($"{ number} is perfectnumber");
            else
                Console.WriteLine($"{number} is not a perfect number");
            Console.ReadKey();
        }
    }
}
