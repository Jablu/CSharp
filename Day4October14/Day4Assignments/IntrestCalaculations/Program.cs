using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterestClassLibrary;

namespace IntrestCalaculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Interest interest = new SimpleInterest();
            interest.CalculateInterest(1000, 5, 6);
            Interest interest2 = new CompoundInterest();
            interest2.CalculateInterest(1111, 2, 5);

        }
    }
}
