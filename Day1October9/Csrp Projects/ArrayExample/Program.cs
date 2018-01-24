using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] numbers = new int[5];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("Enter number: ");
            //    numbers[i] = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine("\nTraversing the arrat using index");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[,] arr2 = new int[,] { { 1, 2, 3, 5 }, { 3, 4, 6, 7 } };

            ////Multi dimensional - same number of columns
            //int[,] arr2 = new int[2, 3];
            ////arr2[0, 0] = 10;
            ////arr2[0, 1] = 11;
            ////arr2[0, 2] = 12;
            ////arr2[1, 0] = 13;
            ////arr2[1, 1] = 14;
            ////arr2[1, 2] = 15;

            //Console.WriteLine("\nTracersing using index");

            //for (int j = 0; j < 2; j++)
            //{
            //   for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(arr2[j,i]+"\t");
            //}
			 
            //}

            //Jagged array

            int [][] jaggedArr = new int [2][];
            jaggedArr [0] = new int[] {1,2,3};
            jaggedArr [1] = new int[] {1,2,3,4,5,6};


            Console.WriteLine("\nTraverse Jagged Array");

            for(int i = 0; i<2; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.WriteLine(jaggedArr[i][j]+"\t");     
                }
                Console.WriteLine(" ");
            }


        }
    }
}
