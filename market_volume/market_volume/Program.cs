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

            // Status output
            Console.WriteLine("\nThank you! Data is entered.");
            Console.WriteLine("Calculation is performed...\n");

            // Calculate volumes
            decimal MarketVolume0 = Price0 * NumberOfItems0;
            decimal MarketVolume1 = Price1 * NumberOfItems1;

            // Calculate delta
            decimal DeltaPrice = (Price1 - Price0) * 100 / Price0;
            decimal DeltaNumberOfItems = (NumberOfItems1 - NumberOfItems0) * 100 / NumberOfItems0;

            // Calculate volume delta
            decimal DeltaMarketVolume = (MarketVolume1 - MarketVolume0) * 100 / MarketVolume0;

            // Output table
            //  Header
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine(" YEAR | C\tC %\tM\tM %\tE\t\tE %");
            Console.WriteLine("-------------------------------------------------------------------------------");

            //  Data

            Console.WriteLine(String.Format(" {0} | {1}\t\t{2}\t\t{3}\t\t",
                Year0,
                String.Format("{0:0.##}", Price0),
                String.Format("{0:0.##}", NumberOfItems0),
                String.Format("{0:0.##}", MarketVolume0)));
            Console.WriteLine("-------------------------------------------------------------------------------");

            Console.WriteLine(String.Format(" {0} | {1}\t{2}\t{3}\t{4}\t{5}\t\t{6}",
                Year1,
                String.Format("{0:0.##}", Price1),
                String.Format("{0:0.##}", DeltaPrice),
                String.Format("{0:0.##}", NumberOfItems1),
                String.Format("{0:0.##}", DeltaNumberOfItems),
                String.Format("{0:0.##}", MarketVolume1),
                String.Format("{0:0.##}", DeltaMarketVolume)));
            Console.WriteLine("-------------------------------------------------------------------------------");

            Console.WriteLine("\n\t//////////////");
            Console.WriteLine("\t/// FINISH ///");
            Console.WriteLine("\t//////////////\n");

            Console.Read();
        }
    }
}
