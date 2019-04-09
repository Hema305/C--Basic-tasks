using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArmstrongNumber
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter number");
            int number=int.Parse(Console.ReadLine());
            int temp = number;
            int tempTwo = number;
           double sum = 0;
            int count = 0;
            while(tempTwo!=0)//for calculating the length of the given number
            {
                int r = tempTwo % 10;
                count++;
                tempTwo = tempTwo / 10;
            }
            while(temp!=0)//finding the sum of the each number power to the lenght of that value.
            {
                int rem = temp % 10;
              sum = sum + Math.Pow(rem,count);
                temp = temp / 10;

            }
            if (sum == number)
                Console.WriteLine("armstorng number");
            else
                Console.WriteLine("not an Armstrong number");
            Console.ReadLine();
        }
    }
}
