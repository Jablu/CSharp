    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = 1000;
            int totalPayment, month = 0;
            Console.WriteLine("Enter the monthly payment: ");
            int choice = int.Parse(Console.ReadLine());
            while(balance > 0)
            {
                balance = 1.015 * balance;
                balance = balance - choice;
                month++;
                if(balance>0)
                {
                Console.WriteLine("Month "+ month + " balance: " + balance + " total payments: " + choice*month);
                }
            }
            Console.WriteLine("After "+ month+" months payment will be cleared\n");
        }
    }
}
