using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomLib;

namespace StudentGrade
{
    public class Student
    {
        int rollNo;
        string name;
        string standard;
        string semester;
        string branch;
        Boolean status = false;
        double avg = 0;
        double total = 0;
        int[] marks = new int[5];


        public Student(int rollNo, string name, string standard, string semester, string branch)
        {
            // TODO: Complete member initialization
            this.rollNo = rollNo;
            this.name = name;
            this.standard = standard;
            this.semester = semester;
            this.branch = branch;
        }

       public void DisplayResult(int[] marks)

       {
            this.marks = marks;
            for(int i=0;i<5;i++)
            {
                total = total + marks[i];

                if (marks[i] < 35)
                {
                    status = false;
                }
                //if(i==4)
                //{
                //    if((total/5)<5)
                //    {
                //    Console.WriteLine("Failed");
                //    }                  
                //}
            }
            avg = total / 5;
            if (avg < 50)
            {
                status = false;
            }
            else {
                status = true;
            }
       }

       public string DisplayData()
       {
           
       }
    }
}
