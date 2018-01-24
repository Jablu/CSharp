using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddNumber(10, 12, 11, 55));
            Console.WriteLine(AddNumber(10, 12, 15));

            if(FindNumber(12, 11, 11, 10, 15, 15) ==true)
            {
                Console.WriteLine("F off");
            }

        }
        static int AddNumber(params int[] n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            { sum += n[i]; }
            return sum;
        }
        static bool FindNumber(int n, params int[] numbers)
        {
            bool boo = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 10)
                {
                    boo = true;
                }
            }
            return boo;
        }
    
}
