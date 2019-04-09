using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
           int numberOne= int.Parse(Console.ReadLine());
            Console.WriteLine("enter next number");
            int numbeTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("addition = "+(numberOne+numbeTwo));
           
            Console.WriteLine("subtraction = "+ (numberOne - numbeTwo));

            Console.WriteLine("multiplication = "+(numberOne * numbeTwo));

            Console.WriteLine("Division = "+ (numberOne / numbeTwo));

            Console.Read();


        }
    }
}
