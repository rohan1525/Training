using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class HierarchicalInheritance
    {
       public class Person
        {
            public string Name { get; set; }

            public void InputName()
            {
                Console.Write("Enter name: ");
                Name = Console.ReadLine();
            }

            public void DisplayName()
            {
                Console.WriteLine($"Name: {Name}");
            }
        }
        class Student : Person
        {
            public int Grade { get; set; }

            public void InputGrade()
            {
                Console.Write("Enter grade: ");
                Grade = int.Parse(Console.ReadLine());
            }

            public void DisplayStudent()
            {
                DisplayName();
                Console.WriteLine($"Grade: {Grade}");
            }
        }
        class Teacher : Person
        {
            public string Subject { get; set; }

            public void InputSubject()
            {
                Console.Write("Enter subject: ");
                Subject = Console.ReadLine();
            }

            public void DisplayTeacher()
            {
                DisplayName();
                Console.WriteLine($"Subject: {Subject}");
            }
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("Student Information:");
                Student student = new Student();
                student.InputName();
                student.InputGrade();
                student.DisplayStudent();

                Console.WriteLine("\nTeacher Information:");
                Teacher teacher = new Teacher();
                teacher.InputName();
                teacher.InputSubject();
                teacher.DisplayTeacher();
            }
        }
    }
}
