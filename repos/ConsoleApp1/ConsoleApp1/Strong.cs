using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Strong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            int temp = number;
            int sum = 0;
            while(number!=0)
            {
                int reminder = number % 10;

                int factorialValue = fact(reminder);
                sum += factorialValue;
                number = number / 10;

            }
            if (sum == temp)
            {
                Console.WriteLine($"{temp} is strong number");
            }
            else
                Console.WriteLine($"{temp} is not strong number");
           
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
