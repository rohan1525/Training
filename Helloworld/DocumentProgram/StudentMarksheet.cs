using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class StudentMarksheet
    {
        static void Main(string[] args)
        {
            int rollNumber, subject1Marks, subject2Marks, subject3Marks, totalMarks;
            float percentage;
            string studentName;

            Console.WriteLine("Enter Roll Number :");
            rollNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student Name :");
            studentName = Console.ReadLine();

            Console.WriteLine("Enter Mark of Maths : ");
            subject1Marks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Mark of Gujarati : ");
            subject2Marks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Mark of Hindi : ");
            subject3Marks = Convert.ToInt32(Console.ReadLine());

            totalMarks = subject1Marks + subject2Marks + subject3Marks;
            percentage = totalMarks / 3.0f;

            Console.WriteLine("Total : " + totalMarks);
            Console.WriteLine("Percentage : " + percentage);

            if (percentage >= 35 && percentage < 50)
            {
                Console.WriteLine("Grade is C");
            }
            else if (percentage >= 50 && percentage <= 60)
            {
                Console.WriteLine("Grade is B");
            }
            else if (percentage > 60 && percentage <= 80)
            {
                Console.WriteLine("Grade is A");
            }
            else if (percentage > 80 && percentage <= 100)
            {
                Console.WriteLine("Grade is A+");
            }
            else
            {
                Console.WriteLine("Grade is F");
            }

            Console.ReadLine();
        }
    }
}
