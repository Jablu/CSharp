using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITC.Hyd;
using ITC;
using ITC.Blr;

namespace NameSpaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            HR hr = new HR();
            hr.Show();
                ITC.Hyd.Employee employee = new ITC.Hyd.Employee();
                
            employee.Show();


           
        }
    }

}
namespace ITC
{
    public class HR
    {
        public void Show()
        {
            Console.WriteLine("ITC HR _>RULES");
        }
    }
    namespace Blr
    {
        public class Employee {
            public void Show()
            {
                Console.WriteLine("itc blr employee");
            }
        }
    }
    namespace Hyd
    {
        public class Employee
        {
            public void Show()
            {
                Console.WriteLine("itc hyd employee");
            }
        }
    }
}