using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryAccount
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the basic: ");
            double basic = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the special allowance: ");
            double special = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the bonus amount: ");
            double bonus = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the monthly tax investment: ");
            double tax_inv = double.Parse(Console.ReadLine());

            double gross = basic + special;
            double year_gross = 12 * gross;
            bonus = year_gross * (bonus/100);
            year_gross = year_gross + bonus;

            double deductable_tax;
            if ((tax_inv * 12) >= 100000)
            {
                deductable_tax = 100000;
            }        
            else
                deductable_tax = tax_inv * 12;

            year_gross = year_gross - deductable_tax;

            double tax; 

            if (year_gross <= 100000)
            {
                tax = 0;
                Console.WriteLine("The tax amount is "+tax);
            }
            else if (year_gross > 100000 && year_gross <= 150000)
            {
                tax = year_gross * 0.2;
                Console.WriteLine("The tax amount is " + tax);
            }
            else
            {
                tax = year_gross * 0.3;
                Console.WriteLine("The tax amount is " + tax);
            
            }
        }
    }
}
