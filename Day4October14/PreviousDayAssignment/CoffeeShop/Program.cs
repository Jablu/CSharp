using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double feedbackRating;
            string mobileNumber;
            string name;
            double average = 0;
            int counter=0;
             
            Console.Write("How many customer input you want to take?    ");
            counter = int.Parse(Console.ReadLine());
            Customer[] customer = new Customer[counter];

            for (int i =0; i<counter; i++)
            {
                Console.Write("\nType your name please,");
                name = (Console.ReadLine());
                Console.Write("\nType your mobile number please,");
                mobileNumber = (Console.ReadLine());
                Console.Write("\nType your rating please,");
                feedbackRating = double.Parse((Console.ReadLine()));
                customer[i] = new Customer(feedbackRating, mobileNumber, name);
                average = average + feedbackRating;
            }

            Console.WriteLine("Average Customer Ratings :"+average/counter);


        }
    }

    public class Customer
    {
        double feedbackRating;
        string mobileNumber;
        string name;
        double totalRating;

        public Customer()
        { }
        public Customer(double f, string m, string n)
        {
            this.feedbackRating = f;
            this.mobileNumber = m;
            this.name = n;

            totalRating = totalRating + feedbackRating;

        }
        public double AverageRating()
        {
            return this.totalRating;
        }
    }
}
