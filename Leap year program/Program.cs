using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_year_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the year :");
            int year=int.Parse(Console.ReadLine());
            Console.WriteLine(" year {0}:",year);
            if(year%4==0 && year%100!=0 || year%400==0)
                Console.WriteLine("this is leap year ({0})",year);
            else
                Console.WriteLine(" Not leap year ({0})",year);
            Console.ReadLine();
        }
    }
}
