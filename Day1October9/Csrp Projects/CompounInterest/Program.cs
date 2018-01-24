using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompounInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            int years = 0;
            double i = 1000;
            while( i < 1000000)
            {
                i = i + (0.05 * i);
                Console.WriteLine("In " + years + "th year, amount the person owns is " + i+ "\n");
                years++;
            }
            
           Console.WriteLine("In " + years + " years the person will be a millionire\n");
        }
    }
}
