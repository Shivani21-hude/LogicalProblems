using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Pattern_InSquareFormat
    {
        public static void SquareFormat()
        {
            Console.WriteLine("==>  * Pattern in Square format ");
            Console.WriteLine("Enter the number of patterns for * pattern ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    if (i == 0|| i == n-1 || j == 0 || j == n-1)
                         
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();

            }

        }
    }
}
