using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {

            Emppoyee emp = new Emppoyee();

            int ec; string en; int sal; int did;


            Console.WriteLine("Employee Id");
            ec = int.Parse(Console.ReadLine());


            Console.WriteLine("Employee Name");
            en = Console.ReadLine();


            Console.WriteLine("Employee Salary");
            sal = int.Parse(Console.ReadLine());


            Console.WriteLine("Employee Dept id");
            did = int.Parse(Console.ReadLine());


            emp.StoreDetails(ec, en, sal, did);
                
            Console.WriteLine(emp.GetDetails());

        }
    }


}
