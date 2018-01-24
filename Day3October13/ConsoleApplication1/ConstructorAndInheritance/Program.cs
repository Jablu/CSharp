using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Child cobj = new Child(100, 200);
            cobj.Show_P();
            cobj.Show_C();

        }
    }
    class Parent {
        int p;
        public Parent(int p)
        { this.p = p; }
        public void Show_P()
        { Console.WriteLine("Parent P: "+ this.p ); }
    }

    class Child : Parent{
        int c;
        public Child(int c, int p)
            : base(p)
        {
            this.c = c;
        }
        public void Show_C()
        { Console.WriteLine("Child C: " + this.c); }
    }
}
