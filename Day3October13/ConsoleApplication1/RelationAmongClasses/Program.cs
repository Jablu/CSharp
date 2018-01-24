using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationAmongClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Two Bedroom, Hall, Kitchen");
            TwoBHK twoBHK1 = new TwoBHK();
            twoBHK1.CozyRoom();
            twoBHK1.SmallBathroom();
            twoBHK1.WaterSupply();


            Console.WriteLine("Three Bedroom, Hall, Kitchen");
            ThreeBHK threeBHK1 = new ThreeBHK();
            threeBHK1.Hall();
            threeBHK1.LargeBathroom();
            threeBHK1.WaterSupply();
        }
    }

    class Apartment
    {
        public void WaterSupply()
        {
            Console.WriteLine("The water supply system.");
        }
        public void ElectrySupply()
        {
            Console.WriteLine("The electrical supply system.");
        }
    }
    class TwoBHK : Apartment
    {
        public void CozyRoom()
        {
            Console.WriteLine("Cozy Room");
        }
        public void SmallBathroom()
        {
            Console.WriteLine("Small Bathroom");
        }

    }
    class ThreeBHK : Apartment
    {
        public void Hall()
        {
            Console.WriteLine("Large Hall");
        }
        public void LargeBathroom()
        {
            Console.WriteLine("Large Bathroom");
        }
    }
}
