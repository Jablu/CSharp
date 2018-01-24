using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Era er1 = new Era();
            Console.WriteLine(er1.GetSpeed());


            Era er = new Era();
            er.SetMaxSpeed(80);

            Console.WriteLine(er.GetSpeed());


            Magna magna = new Magna();
            magna.SetMaxSpeed(70);

            Console.WriteLine(magna.GetSpeed());


        }
    }

    class Hyundai
    {
         public int maxSpeedLimit;

        public void SetMaxSpeed(int speed) 
        {
            maxSpeedLimit = 120;
        }
        public virtual string GetSpeed()
        {
            return ""+maxSpeedLimit ;
        }

    }

    class Era : Hyundai
    {
       
        public void SetMaxSpeed(int speed)
        {
            maxSpeedLimit = speed;
        }

        public override string GetSpeed()
        {
            return "" + maxSpeedLimit;
        }
    }

    class Magna : Hyundai
    {

        public void SetMaxSpeed(int speed)
        {
            maxSpeedLimit = speed;
        }

        public override string GetSpeed()
        {
            return "" + maxSpeedLimit;
        }
    }



}
