using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03A2CalculateMPG
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles, gallons, mpg;

            Console.Write("Tankmenge in Liter: ");
            gallons = Convert.ToDouble(Console.ReadLine());

            Console.Write("Strecke in km     : ");
            miles = Convert.ToDouble(Console.ReadLine());

            mpg = ( gallons / miles ) * 100;

            Console.WriteLine("Verbrauch " + mpg);

        }
    }
}
