using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.name = "Whatever1";
            employee.state = "Active";
            employee.salary = 360000;

            employee.spouse = new Spouse();

            

            employee.spouse.name = "Whatever2";
            employee.spouse.age = 22;


            Console.WriteLine("nAME  -"+employee.name);
            Console.WriteLine("sTATUS  -"+employee.state);
            Console.WriteLine("sALARY  -"+employee.salary);

            //employee.spouse = new spouse();

            //console.writeline("name" + employee.name);
            //console.writeline("status" + employee.state);
            //console.writeline("spouse name" + employee.spouse.name);
            //console.writeline("salary" + employee.salary);


            Employee employee2 = employee;
            employee2.name = "Whatever3";
            employee2.state = "Inactive";
            employee2.salary = 720000;


            Console.WriteLine("nAME  -" + employee2.name);
            Console.WriteLine("sTATUS  -" + employee2.state);
            Console.WriteLine("sALARY  -" + employee2.salary);


        }
    }

    struct Employee
    {
        public string name;
        public string state;
        public double salary;
        public Spouse spouse;
    }
    struct11 Spouse
    {
        public string name;
        public int age;
    }
}
