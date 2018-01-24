using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDeffinedException
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class ATMException:Exception
    {

        public ATMException(string errMsg)
            : base(errMsg)
        { 
        

        
        }
    
    }

    class Account
    {
        public int Balance
        {
            get; private set;
        }
    }

}

