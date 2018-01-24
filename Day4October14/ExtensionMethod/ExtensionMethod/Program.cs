using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            x.Square();
        }
    }

    static class ExtInt
    {
        public static int Square(this int n)
        {
            return n*n;
        }
    }

}
