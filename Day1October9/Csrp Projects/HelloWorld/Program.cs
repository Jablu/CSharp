using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I'm batman!");

            Employee employee1 = new Employee();
            employee1.Store();
            employee1.Display();

        }
    }
}
class Employee
{
    public void Store()
    {
        Console.WriteLine("This where Batman keeps his weapon!");
    }
    public void Display()
    {
        Console.WriteLine("This is for show off!");
    }
}