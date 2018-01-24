using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentClass
{
    public class SimpleInterest
    {
        public double FindInterest(double amount, double rate, double year)
        {
            return (amount * rate * year) / 100;
        }
    }
}
