using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class Emppoyee
    {
        int ecode;
        string ename;
        int salary;
        int deptid;

        public void StoreDetails(int ec, string en, int dsl, int did)
        {
            this.ecode = ec;
            this.ename = en;
            this.salary = dsl;
            this.deptid = did;

        }

        private double GetBonus()
        {
            double bonus = 0;
            if (salary > 5000)
            {
                bonus = salary * 0.1;
            }
            else
                bonus = salary * 0.2;
            return bonus;
        }


        public string GetDetails()
        {   
            string str = "Employee id " + ecode + " named " + ename + " gets " + salary + " this much salary will get "+ GetBonus() +" this much.";
            return str;
        }


    }
}
