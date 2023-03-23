using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class SumofDigits
    {
        public static void Sum()
        {
            Console.Write("enter a digit : ");
            int digit=Convert.ToInt32(Console.ReadLine());
            int reverse,sum=0;
            while(digit>0)
            {
                reverse = digit % 10;
                sum = sum + reverse;
                digit /= 10;
            }
            Console.WriteLine("Sum of digits : " + sum);
        }
    }
}
