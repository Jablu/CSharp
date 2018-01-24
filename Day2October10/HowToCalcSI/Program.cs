using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExperimentClass;

namespace HowToCalcSI
{
    class Program
    {
        static void Main(string[] args)
        {

            SimpleInterest si = new SimpleInterest();
            Console.WriteLine(si.FindInterest(1000,10,12));

        }
    }
}
