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
                Console.WriteLine("\n Choose from following options : \n 1) To count total number of duplicate elements in an array.\n 2) To print unique elements");
                int option=Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        DuplicateElements.DuplicateNumbers();
                        break;

                    case 2:
                        UniqueElements.Unique();
                        break;

                }
            }
                      
        }
    }
}