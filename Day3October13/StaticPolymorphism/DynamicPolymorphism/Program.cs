using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static binding
            Parent p = new Parent();
            p.Show();

            Child c = new Child();
            c.Show();


            //Dynamic binding

            Parent q;
            q = new Parent();
            p.Show();

            q = new Child();
            q.Show();

        }
    }

    class Parent
    {
        public virtual void Show()
        {
            Console.WriteLine("pARENT");
        }

    }
    class Child : Parent
    {
        public override void Show()
        {
            Console.WriteLine("cHILD");
        } 
    }
}
