using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphismQuestion
{
    class Program
    {
        static void Main(string[] args)
        {


            Labour labour = new Labour(120, 0001, "Watson");
            Console.WriteLine(labour.Display());

            Manager manager = new Manager(270000, 0002, "Sherlock");
            Console.WriteLine(manager.Display());
        }
    }

    public class Employee
    {
        int ecode;
        string ename;
        public Employee(int ec, string en)
        {
            this.ecode = ec;
            this.ename = en;
        }

        public virtual string Display()
        {
            return "Employee Code:" + ecode + "\nEmployee Name:" + ename;
        }

    }
    public class Labour : Employee
    {
        int wages;
        

        public Labour(int wg, int ec, string en): base(ec, en) 
        {
            this.wages = wg;
        }
        
        public override string Display()
        {
            return "\nWages:" + wages+ base.Display();
        }

    }
    class Manager : Employee
    {
        int salary;
        public Manager(int sa, int ec, string en): base(ec, en) 
        {
            this.salary = sa;
        }

        public override string Display()
        {
            return "\nSalary:" + salary;
        }
    }
}
