using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        double acctNo;
        string custName;
        string accountType;
        string trasactionType;
        double amount;
        double balance=0;



        public void UserDetails(double an, string cn, string at)
        { 
            this.acctNo = an;
            this.accountType = at;
            this.custName = cn;
        }

        public string Credit(double amount)
        {
            this.amount = amount;
            balance = balance + amount;
            return "\nYour Account being credited - " + amount;
        }

        public string Debit(double amount)
        {
            this.amount = amount;
            balance = balance - amount;
            return "\nYour Account being debited - " + amount ;
        }
        public string Show()
        {
            return "\nHi " + custName + ",\n" + "Your Account Number -  " + acctNo + "(" + accountType + " Account)" + "\nYour Balance is - " + balance;
        }


    }
}
