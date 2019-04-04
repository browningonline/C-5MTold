using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionarytest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressure Altitude: ");
            int pressureAltitude_ft = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Temperature: ");
            int temperature_degC = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("PA: " + pressureAltitude_ft + "ft MSL");
            Console.WriteLine("Temp: " + temperature_degC + " C");

            var mclLookup = new MCLLookup();
            var power_pct = mclLookup.GetMCL(pressureAltitude_ft, temperature_degC);

            
            Console.WriteLine(power_pct);
            Console.ReadLine();
            

        }

    }
}
