using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1, n2, result;
            Console.WriteLine("Enter N1");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter N2");
            n2 = int.Parse(Console.ReadLine());
            try
            {
                result = n1 / n2;
                Console.WriteLine("Result:" + result);
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine(de.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            finally
            {
                Console.WriteLine("hAVE A GREAT day");
            }
        }
    }
}
