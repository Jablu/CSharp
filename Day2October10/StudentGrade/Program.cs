using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomLib; //lass library namespace


namespace StudentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            int rollNo;
            string name;
            string standard;
            string semester;
            string branch;
            int[] marks = new int[5];

            Console.Write("Please Enter Your Roll Number - ");
            rollNo = int.Parse(Console.ReadLine());
            Console.Write("Please Enter Your Name - ");
            name = Console.ReadLine();
            Console.Write("Please Enter Your Year - ");
            standard = Console.ReadLine();
            Console.Write("Please Enter Your Semester - ");
            semester = Console.ReadLine();
            Console.Write("Please Enter Your Branch - ");
            branch = Console.ReadLine();

            Student student = new Student(rollNo, name, standard, semester, branch);

            Restart:

            Console.Write("Enter marks of subject 1 - ");
            marks[0] = int.Parse(Console.ReadLine());
            Console.Write("Enter marks of subject 2 - ");
            marks[1] = int.Parse(Console.ReadLine());
            Console.Write("Enter marks of subject 3 - ");
            marks[2] = int.Parse(Console.ReadLine());
            Console.Write("Enter marks of subject 4 - ");
            marks[3] = int.Parse(Console.ReadLine());
            Console.Write("Enter marks of subject 5 - ");
            marks[4] = int.Parse(Console.ReadLine());


            

        }
    }
}
