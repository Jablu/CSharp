using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myHall = new int[25, 25];
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    myHall[i, j] = 0;
                    Console.Write(myHall[i, j]+" ");
                }
                Console.WriteLine("");
            }


            Console.WriteLine("Enter number of seats you want to book: ");
            int req = int.Parse(Console.ReadLine());

            for (int i = 0; i < req; i++)
            {
                Console.WriteLine("Enter the row starting from bottom 1 to 25: ");
                int row = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the column starting from left 1 to 25: ");
                int col = int.Parse(Console.ReadLine());


                if (myHall[row, col] == 0)
                {
                    myHall[row-1, col-1] = 1;
                }
                else
                {
                    for (int m  = 0; m < 25; m++)
                    {
                        for (int n = 0; n < 25; n++)
                        {
                            if (myHall[m, n] == 0)
                            {
                                if (m == 24 && n == 24)
                                {
                                    Console.WriteLine("Error");
                                    Environment.Exit(0);
                                }
                                break;
                            }
                   
                        }
                    }
                    
                    Console.WriteLine("That seat is not available");
                    
                }
                
            }

            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    Console.Write(myHall[i, j] + " ");
                }
                Console.WriteLine("");
            }
            

        }
    }
}
