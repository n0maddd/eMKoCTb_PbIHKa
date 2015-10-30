using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t//////////////////");
            Console.WriteLine("\t/// STATISTICS ///");
            Console.WriteLine("\t//////////////////\n");

            // Zero period
            int Year0 = 2013;

            Console.WriteLine(String.Format("Enter price in {0} year:", Year0));
            decimal Price0 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(String.Format("Number of items sold in {0} year:", Year0));
            decimal NumberOfItems0 = Convert.ToDecimal(Console.ReadLine());

            // Next period
            int Year1 = 2014;

            Console.WriteLine(String.Format("Enter price in {0} year:", Year1));
            decimal Price1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(String.Format("Number of items sold in {0} year:", Year1));
            decimal NumberOfItems1 = Convert.ToDecimal(Console.ReadLine());
        }
    }
}
