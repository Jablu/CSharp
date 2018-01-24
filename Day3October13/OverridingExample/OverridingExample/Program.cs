using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Shape shape;
            Console.WriteLine("cIRCLE");
            shape = new Circle();
            shape.Area();
            shape.Parameter();
            shape.FillColour();
        }
    }

    abstract class Shape
    {
        public void FillColour()
        {
        }
        public abstract void Area()
        {}
        public abstract void Parameter()
        {}
    }
    class Circle : Shape
    {

        public override void Area()
        {
            Console.WriteLine("Area of circle");
        }

        public override void Parameter()
        {
            Console.WriteLine("Perimeter of circle");
        }
    }
    class Square : Shape
    {
        public override void Area()
        {
            Console.WriteLine("Area of square");
        }

        public override void Parameter()
        {
            Console.WriteLine("Perimeter of square");
        }
    }
}
