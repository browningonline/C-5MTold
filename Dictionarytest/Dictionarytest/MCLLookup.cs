using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionarytest
{
    public class MCLLookup  
    {
        private Dictionary<MCLLookup, double> _lookup = new Dictionary<MCLLookup, double>();
        private double pa;
        private double degC;
       

        public MCLLookup(double pa, double degC)
        {
            this.pa = pa;
            this.degC = degC;
            
        }

        public MCLLookup()
        {
            _lookup.Add(new MCLLookup(-1000, -60), 84.0);
            _lookup.Add(new MCLLookup(-1000, -59), 84.0);
            _lookup.Add(new MCLLookup(-1000, -58), 84.0);
            _lookup.Add(new MCLLookup(-1000, -57), 84.0);
        }

        public double GetMCL(int pressureAltitude_ft, int temperature_degC)

        {
            var roundedPressureAltitude_ft = (pressureAltitude_ft / 1000) * 1000;
            var key = new MCLLookup(roundedPressureAltitude_ft, temperature_degC);
            
            if (_lookup.ContainsKey(key))
            {
                return _lookup[key];
            }
            return -999.9;
        }
    }

}
