using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise20_MultistateSalesTaxCalculator
{
    public class StateWithTaxData
    {
        public static StateWithTax stateWithTax = new StateWithTax()
        {
            State = new Dictionary<string, double>
            {
                { "tbilisi", 0.7 },
                { "gori", 0.5 },
                { "telavi", 0.25 },
                { "kutaisi", 0.3 },
                { "batumi", 0.8 },
                { "samtredia", 0.1 },
                { "ozurgeti", 0.3 }
            }
        };
    }
}