using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanVerification
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Agency 
    {

        string name;
        string address;
        string contact_number;

        Agency()
        { }
        Agency(string name, string address, string contact)
        {
            this.name = name;
            this.address = address;
            this.contact_number = contact;
        }
        public void VerifyAgency(Customer customer)
        { 
        
        }

    }
    class Customer
    {
        
    }
    

}
