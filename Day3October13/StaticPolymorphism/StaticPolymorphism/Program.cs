using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Utility u = new Utility();
            Console.WriteLine(u.Add(10, 20));    
                
            Console.WriteLine(u.Add("Hi" , "Weirdo"));
        }
    }
}
class Utility
{
    public int Add(int n1, int n2)
    {
        return n1 + n2;
    }
    public string Add(string n1, string n2)
    {
        return n1 + n2;
    }
}