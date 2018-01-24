using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(100,"Jabs",10,20,"IRC FYFY");
            Console.WriteLine(employee.GetDetails());

            Employee employee2 = new Employee(100, "Jabs", 10, 20, "i" );
            Console.WriteLine(employee2.GetDetails());

            Employee employee3 = new Employee(100, "Jabs", 10, 20, "cascaY");
            Console.WriteLine(employee3.GetDetails());


            

        }
    }
}
public class Employee
{
    int ecode;
    string ename;
    int salary;
    int deptid;
    static string company = "Itc";


    static Employee()
    { 
        
    }

    public Employee(int a, string b, int sal, int did, string c)
    {
        this.ecode = a;
        this.ename = b;
        this.salary = sal;
        this.deptid = did;
        company = c;
        Console.WriteLine("Ctor called");

    }

    public string GetDetails()
    {
        return ecode + " is " + ename + "with this name !"+salary+company;
    }
    ~Employee()
    {
        Console.WriteLine("dESt called!");
    }
}
