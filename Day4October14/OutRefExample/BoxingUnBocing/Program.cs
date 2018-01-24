using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnBocing
{
    class Program
    {
        static void Main(string[] args)
        {

            //value-value
            int i = 100;
            long l = i;
            
            int y = (int)l; //truncation may happen

            //value to reffernce
            int a = 10;
            object o = a;

            //unbocing explicit
            int b = (int)o;





        }
    }
}
