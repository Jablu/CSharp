using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextWorld
{
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
            Console.WriteLine("6.Remaining");

            int choice = int.Parse(Console.ReadLine());
            
            MenuLbl:

            switch (choice)
            { 

                case 1 :
                    result = n1 + n2;
                    Console.WriteLine("Sum: "+ result);
                    goto MenuLbl;

                case 2 :
                    result = n1 - n2;
                    Console.WriteLine("Sub: "+ result);
                    break;

                case 3:
                    result = n1 * n2;
                    Console.WriteLine("Mult: " + result);
                    break;

                case 4:
                    result = n1 / n2;
                    Console.WriteLine("Div: " + result);
                    break;

                case 5:
                    result = n1 % n2;
                    Console.WriteLine("Dif: " + result);
                    break;

                case 6:
                    result = n1 % n2;
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Fuck Off");
                    break;

            }

            //sum = n1 + n2;
            //Console.WriteLine("Sum of "+ n1 +" and " + n2 +" is: " + sum);

        }
    }
}
