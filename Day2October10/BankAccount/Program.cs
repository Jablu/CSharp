using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            double acctNo;
            string custName;
            string accountType;
            string trasactionType;
            double amount;

            Account account = new Account();


            Console.Write("Please Enter Your Account Number - ");
            acctNo = double.Parse(Console.ReadLine());
            Console.Write("Please Enter Your Name - ");
            custName =Console.ReadLine();
            Console.Write("Please Enter Your Account Type (Saving/Current) - ");
            accountType = Console.ReadLine();

            account.UserDetails(acctNo, custName, accountType);

            Restart:

            Console.Write("\n\nWhat do you wanna do? Where do you wanna reach? \n(D-Deposit/W-Withdrawl) - ");
            trasactionType = Console.ReadLine();

            if (trasactionType.Equals("D"))
            {
                Console.Write("Ener the amount you want to Deposit - ");
                amount = double.Parse(Console.ReadLine());
                Console.Write(account.Credit(amount));
                Console.Write(account.Show());
                goto Restart;

            }
            else if (trasactionType.Equals("W"))
            {
                Console.Write("Ener the amount you want to Deposit - ");
                amount = double.Parse(Console.ReadLine());
                Console.Write(account.Debit(amount));
                Console.Write(account.Show());
                goto Restart;
            }   
            else
            {
                Console.Write("Invalid Input!");
                Console.Write(account.Show());
                goto Restart;
            }
        }
    }
}
