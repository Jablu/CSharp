using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q25
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> names = new List<string>();
            names.Add("Kiran");
            names.Add("Ramadrggergergbkbkbn");
            names.Add("Suesjfwhjh");

            names.Sort(new SortByLength());
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
    class SortByLength : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x.Length > y.Length)
            {
                return 1;
            }
            else if (x.Length < y.Length)
            {
                return -1; 
            }
            else
                return 0;
        }
    }
}
