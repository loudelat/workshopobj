using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate three student objects
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();

            // set the info for student1
            student1.FirstName = "Lou";
            student1.LastName = "Torre";
            student1.CourseFocus = "C#";

            // set the info for student2
            student2.FirstName = "Joanna";
            student2.LastName = "Torre";
            student2.CourseFocus = "HTML";

            // set the info for student3
            student3.FirstName = "Josiah";
            student3.LastName = "Torre";
            student3.CourseFocus = "JavaScript";

            // print information for each student
            Console.WriteLine(student1.FirstName + " " + student1.LastName + " is studying " + student1.CourseFocus);
            Console.WriteLine(student2.FirstName + " " + student2.LastName + " is studying " + student2.CourseFocus);
            Console.WriteLine(student3.FirstName + " " + student3.LastName + " is studying " + student3.CourseFocus);
        }
    }
}
