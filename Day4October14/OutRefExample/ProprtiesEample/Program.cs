using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProprtiesEample
{
    class Program
    {
        static void Main(string[] args)
        {

            //Employee e = new Employee();
            //e.Ecode = 90;
            //Console.WriteLine(e.Ecode);


            //Object Initializer syntax

            Employee emp = new Employee(emp.Ecode = 101, emp.Name = "June");


        }
    }
    class Employee
    {
        int ecode;
        string ename;
        int salary;
        int depid;

        public int Ecode
        {
            get;
            set;
        }
        public string Name{ get; set; }
        public int DepartmentID { get; set; }
        public int Salary { get; set; }
    }
}
