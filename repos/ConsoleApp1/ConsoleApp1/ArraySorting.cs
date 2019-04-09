using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArraySorting
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 6, 7, 2, 8, 9, 2, 2 };

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            for (int k = 0; k < numbers.Length; k++)
            {
                Console.WriteLine(numbers[k]);
            }
            Console.ReadKey();
        }
    }
}
