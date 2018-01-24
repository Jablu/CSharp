using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutRefExample
{
    class Program
    {
        static void Main(string[] args)
        {

            int salary = 7000;
            double bonus = 0;

            Employee employee = new Employee();
            employee.GetBonus(salary, ref bonus);
            Console.WriteLine("Salary:{0}\tBonus:{1}",salary,bonus);

        }
    }


    class Employee
    {
        public void GetBonus(int salary, ref double bonus)
        {
            if (salary > 5000)
            {
                bonus = 0.1 * salary;

            }
        }
    }

}
