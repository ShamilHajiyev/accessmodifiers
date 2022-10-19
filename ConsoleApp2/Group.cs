using System;

namespace ConsoleApp2
{
    class Group
    {
        public string No;
        public byte Limit;
        private Student[] StudentGroup;

        public Group(string no, byte limit)
        {
            Limit = limit;
            No = no;
            StudentGroup = new Student[0];
        }

        public void AddStudent(Student addedStudent)
        {
            if (StudentGroup.Length < Limit)
            {
                Array.Resize(ref StudentGroup, StudentGroup.Length + 1);
                StudentGroup[StudentGroup.Length - 1] = addedStudent;
                Console.WriteLine($"{addedStudent.Name} {addedStudent.Surname} added to {No}");
            }
            else
            {
                Console.WriteLine("limit reached");
            }
        }

        public void GetStudents()
        {
            foreach (Student student in StudentGroup)
            {
                Console.WriteLine($"{student.Name} {student.Surname}");
            }
        }
    }
}
