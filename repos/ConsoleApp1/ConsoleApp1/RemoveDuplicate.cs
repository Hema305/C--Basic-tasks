using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RemoveDuplicate
    {
        static void Main(string [] args)
        {
            int [] numbers= {2,2,1,1,3,3,3,4,5,5,6};
            int[] temp = new int[numbers.Length];

            for (int i=0;i<numbers.Length;i++)
            {
                for(int j=i+1;j<numbers.Length;j++)
                {
                    if(numbers[i]>numbers[j])
                    {
                        int tempOne = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j]= tempOne;
                    }
                }
            }
            int count = 0;
            int k = 0;

            for( k=0;k<numbers.Length-1;k++)
            {
                if(numbers[k]!=numbers[k+1])
                {
                  
               
                 
                    temp[count++]= numbers[k];
                  

                   
                }
              
            }
           temp[count++] = numbers[k];
            for (int l = 0; l <count; l++)
            {
                Console.WriteLine(temp[l]);
            }
            Console.ReadKey();
        }
    }
}
