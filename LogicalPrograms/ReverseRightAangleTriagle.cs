using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseRightAangleTriagle
    {
        public static void ReverseAngleTraingle()
        {

            Console.WriteLine("Enter the number of patterns for * pattern ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i= 0; i < n; i++)
            {
                for(int j= i; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
