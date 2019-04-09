using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal number");
            int decimalNumber = int.Parse(Console.ReadLine());
            Double binaryNumber = 0;
            int counter = 0;
            while (decimalNumber != 0)
            {

                int remider = decimalNumber % 2;
                binaryNumber += (Math.Pow(10, counter) * remider);
                decimalNumber = decimalNumber / 2;
                counter++;

            }
            Console.WriteLine($"binaryValue is {binaryNumber}");
            Console.ReadKey();
        }
    }
}
