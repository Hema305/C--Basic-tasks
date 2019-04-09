using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number to check:");
            int number = int.Parse(Console.ReadLine());

            int temp = number;
            int rem;
            int sum = 0;

            while(temp!=0)
            {
                rem = temp % 10;
                sum = rem + sum*10;
                temp = temp / 10;
            }
            if (summ == number)
                Console.WriteLine("it's a palindrome");
            else
                Console.WriteLine("not a palindrome");

            Console.Read();


        }
    }
}
