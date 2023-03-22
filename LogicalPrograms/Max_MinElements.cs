using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Max_MinElements
    {
        public static void FindMaxAndMinValue()
        {
            Console.Write("Enter a number : ");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter elements : ");
            for(int i=0;i<n;i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }

            int max = arr[0];
            int min = arr[0];
            for(int i = 0; i < n; i++)
            {
                    if (arr[i] > max)
                    {
                    max = arr[i];
                    }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
               
            }
            Console.WriteLine("maximum element is : " + max);
            Console.WriteLine("Minimum element is : " +min);

        }
    }
}
