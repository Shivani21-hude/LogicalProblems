using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class UniqueElements
    {
        public static void Unique()
        {
            Console.WriteLine("enter a number :");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr  = new int[n];
            Console.WriteLine("Enter the elements ");
            for(int i= 0; i < n; i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nThe unique elements found in the array are : \n");

            for (int i = 0 ; i < n ; i++)
            {
                int ctr=0;

                for (int j = 0; j < i - 1; j++)
                {
                    //Increment the counter when the seaarch value is duplicate.
                    if (arr[i] == arr[j])
                    {
                        ctr++;
                    }
                }
                for (int k = i + 1 ; k < i ; k++)
                {
                    if (arr[i] == arr[k])
                    {
                        ctr++;
                    }
                    if (arr[i] == arr[i + 1])
                    {
                        i++;
                    }

                }
                if (ctr == 0)
                {
                    Console.Write("{0} ", arr[i]);
                }
            }
            Console.Write("\n\n");
        }

    }
}
