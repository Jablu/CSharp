using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestClassLibrary
{
        public interface Interest
        {

            double CalaculateInterest(int p, double r, int y);
        }


        public class SimpleInterest:Interest
        {
            private int principal, years;
            private double rate;

            public double CalculateInterest(int p, double r, int y)
            {
                this.principal = p;
                this.years = y;
                this.rate = r;

                return (principal * rate * years) / 100;

            }
        }
        public class CompoundInterest : Interest
        {
            private int principal, years;
            private double rate;

            public double CalculateInterest(int p, double r, int y)
            {
                this.principal = p;
                this.years = y;
                this.rate = r;

                return (principal * Math.Pow((1+(rate/100)),years));
            }
        }

    

}
