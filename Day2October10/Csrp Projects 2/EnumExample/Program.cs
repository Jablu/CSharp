using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{

    enum MenuChoice

    {
        Add = 1, Subtract = 2, Multiply = 3, Divide = 4, Remaining = 5, Exit =6
    }

    class Program
    {
        static void Main(string[] args)
        {

            int n1, n2, result;
            Console.WriteLine("First Number: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Second Number: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("1.Add");
            Console.WriteLine("2.Subtract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            Console.WriteLine("5.Remaining");
            Console.WriteLine("6.Exit");

            int choice = int.Parse(Console.ReadLine());

        MenuLbl:

            switch (choice)
            {

                case (int)MenuChoice.Add:
                    result = n1 + n2;
                    Console.WriteLine("Sum: " + result);
                    goto MenuLbl;

                case (int)MenuChoice.Subtract:
                    result = n1 - n2;
                    Console.WriteLine("Sub: " + result);
                    break;

                case (int)MenuChoice.Multiply:
                    result = n1 * n2;
                    Console.WriteLine("Mult: " + result);
                    break;

                case  (int)MenuChoice.Divide:
                    result = n1 / n2;
                    Console.WriteLine("Div: " + result);
                    break;

                case  (int)MenuChoice.Remaining:
                    result = n1 % n2;
                    Console.WriteLine("Dif: " + result);
                    break;

                case  (int)MenuChoice.Exit:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Fuck Off");
                    break;

            }
    

        }
    }
}
