using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a binary number");
            int binaryNumber = int.Parse(Console.ReadLine());
            Double decimalNumber= 0;
            int counter = 0;
            while (binaryNumber!=0)
            {
               
               int remider = binaryNumber % 10;
                decimalNumber+= (Math.Pow(2,counter)*remider);
                binaryNumber = binaryNumber / 10;
                counter++;
                   
            }
            Console.WriteLine($"decimalValue is {decimalNumber}" );
            Console.ReadKey();
        }
    }
}
