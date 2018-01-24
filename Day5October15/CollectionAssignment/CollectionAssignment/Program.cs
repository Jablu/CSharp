using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            String un, mail, pw;
            var theUsers = new List<UserDetails>();

            Console.Write("Enter the desired username please:- ");
            un = Console.ReadLine();
            Console.Write("Enter the desired email please:- ");
            mail = Console.ReadLine();
            Console.Write("Enter the desired password please:- ");
            pw = Console.ReadLine();

            try
            {
                new Add
            }
            catch
            { 
                
            }




        }
    }


    public class UserDetails
    {
        public string Username { get; set; }
        public string Mail_id { get; set; }
        public string Password { get; set; }

        
    }

    class Re_Regisrtation:Exception
    {
        public Re_Regisrtation(string errMsg)
            : base(errMsg)
        { }
    }
    class IncompleteAccount : Exception
    {
        public IncompleteAccount(string errMsg)
            : base(errMsg)
        { }
    }
}
