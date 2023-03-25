using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FrequencyOfElements
    {
        public static void ElementsFrequency()
        {
            Console.Write("Enter a number : ");
            int n=Convert.ToInt32(Console.ReadLine()); //5
            Console.WriteLine("Enter elements :");
            int[] arr =new int[n];
            int[] freq = new int[n];
            int i, j;
            int count;
            for ( i=0; i<arr.Length; i++)     // 2 3 4 2 3
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                freq[i] = -1;
            }
            for(i=0; i<n; i++)
            {
                 count = 1;
                for(j = i + 1; j < n; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        count++;
                        freq[j]=0;
                    }
                }
                if(freq[i] != 0)
                {
                    freq[i]=count;
                }
            }
            Console.Write("\nThe frequency of all elements of the array : \n");
            for ( i = 0; i < n; i++)
            {
                if (freq[i] != 0)
                {
                    Console.Write("{0} occurs {1} times\n", arr[i], freq[i]);      // 2 ocuurs 2 times 
                                                                                    // 3 occcurs 2 times
                }                                                                   // 4 occur 1 time
            }
        }
    }
}
