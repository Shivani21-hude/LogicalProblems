using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class DuplicateElements
    {
        //  take input as array elements to find duplicate numbers
        public static void DuplicateNumbers()
        {
            Console.WriteLine("Enter a number ");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int[] arr = new int[number];
            Console.WriteLine("Enter integer numbers ");

            for(int i=0; i < number; i++)
            {
                arr[i] =Convert.ToInt32(Console.ReadLine());
            }

            for(int j=0; j<number; j++)
            {
                for(int k=j+1; k<number; k++)
                {
                    if (arr[k] == arr[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Duplicate elements " + count);
        }
       
    }
}
