using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseWord
    {
        public static void Reverse()
        {
            Console.Write("Enter a word for reverse : ");
            string word = Console.ReadLine();

            char[] array = word.ToCharArray();
            
            for(int i = word.Length-1; i >= 0; i--)
            {
                
                Console.Write(array[i]);
            }
          
        }
    }
}
