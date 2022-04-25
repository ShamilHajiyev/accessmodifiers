using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name and surname of the added student:");
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            Student student = new Student(name, surname);
            Group group = new Group("P324", 5);
            group.AddStudent(student);
            group.GetStudents();
        }
    }
}
