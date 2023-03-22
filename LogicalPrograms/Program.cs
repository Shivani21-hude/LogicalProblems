using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose from following options : \n 1) To count total number of duplicate elements in an array.");
                int option=Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        DuplicateElements.DuplicateNumbers();
                        break;  
                }
            }
                      
        }
    }
}